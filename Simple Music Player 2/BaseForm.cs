using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;
using System.Threading;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using DiscordRPC;

namespace Simple_Music_Player_2
{
    public partial class BaseForm : Form
    {
        public static DiscordRpcClient client = new DiscordRpcClient("834866728830894140");
        public static bool rpcInitialised = false;
        public static ISoundOut soundOut;
        public static IWaveSource waveSource;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public BaseForm()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "Music files (*.mp3, *.flac, *.ogg)|*.mp3;*.flac;*.ogg";
            dialog.FilterIndex = 0;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = dialog.FileName;
                MusicData.queue.Add(selectedFileName);
                playMusic();
            }
        }
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            {
                dialog.IsFolderPicker = true;
            }
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedFolderPath = dialog.FileName;
                MusicData.queue.AddRange(ProcessDirectory(selectedFolderPath));
                if (soundOut == null) playMusic();
            }
        }
        private void openFolderShuffledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            {
                dialog.IsFolderPicker = true;
            }
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedFolderPath = dialog.FileName;
                MusicData.queue.AddRange((ProcessDirectory(selectedFolderPath)).OrderBy(x => Guid.NewGuid()).ToList());
                if (soundOut == null) playMusic();
            }
        }
        public static List<string> ProcessDirectory(string targetDirectory)
        {
            List<string> lst = new List<string>();
            var fileEntries = Directory.GetFiles(targetDirectory, "*.mp3", SearchOption.AllDirectories).Union(Directory.GetFiles(targetDirectory, "*.flac", SearchOption.AllDirectories)).Union(Directory.GetFiles(targetDirectory, "*.ogg", SearchOption.AllDirectories));
            foreach (string fileName in fileEntries)
                lst.Add(fileName);
            return lst;
        }
        public void playMusic()
        {
            if (!rpcInitialised)
            {
                client.Initialize();
                rpcInitialised = true;
            }
            CleanupPlayback();
            waveSource = CodecFactory.Instance.GetCodec(MusicData.queue[0]).ToSampleSource().ToWaveSource();
            soundOut = new WasapiOut() { Latency = 100 };
            soundOut.Initialize(waveSource);
            soundOut.Play();
            soundOut.Volume = MusicData.volume;
            timer1.Start();
            setMetadata();
            setLabel();
            MusicData.previous.Add(MusicData.queue[0]);
            MusicData.queue.RemoveAt(0);
            setPresence(MusicData.title, MusicData.artist, (MusicData.totalMs - MusicData.posMs), "logo", MusicData.album, true);
            setLabel();
            while (soundOut != null && (soundOut.PlaybackState == PlaybackState.Playing || soundOut.PlaybackState == PlaybackState.Paused))
            {
                MusicData.posMs = waveSource.Position * 1000.0 / waveSource.WaveFormat.BitsPerSample / waveSource.WaveFormat.Channels * 8 / waveSource.WaveFormat.SampleRate;
                volumeTrackBar.Value = soundOut != null ? Math.Min(100, Math.Max((int)(MusicData.volume * 100), 0)) : 100;
                trackTime.Text = TimeSpan.FromMilliseconds(MusicData.posMs).ToString(@"hh\:mm\:ss") + " \\ " + TimeSpan.FromMilliseconds(MusicData.totalMs).ToString(@"hh\:mm\:ss");
                setPresence(MusicData.title, MusicData.artist, MusicData.totalMs - MusicData.posMs, "logo", MusicData.album, soundOut.PlaybackState == PlaybackState.Playing ? true : false);
                Application.DoEvents();
                Thread.Sleep(250);
            }
            if (soundOut != null && soundOut.PlaybackState == PlaybackState.Stopped)
            {
                if (MusicData.queue.Count() >= 1)
                {
                    CleanupPlayback();
                    playMusic();
                    return;
                }
            }
        }
        public void setMetadata()
        {
            TagLib.File file = TagLib.File.Create(MusicData.queue[0]);
            MusicData.title = String.IsNullOrWhiteSpace(file.Tag.Title) ? file.Name.Split('\\')[file.Name.Split('\\').Length - 1].Split('.')[0] : file.Tag.Title;
            MusicData.artist = file.Tag.Performers.Length == 0 ? "N/A" : file.Tag.Performers.Length > 1 ? String.Join(", ", file.Tag.Performers) : file.Tag.Performers[0];
            MusicData.album = String.IsNullOrWhiteSpace(file.Tag.Album) ? "N/A" : file.Tag.Album;
            MusicData.posMs = waveSource.Position * 1000.0 / waveSource.WaveFormat.BitsPerSample / waveSource.WaveFormat.Channels * 8 / waveSource.WaveFormat.SampleRate;
            MusicData.totalMs = waveSource.GetTime(waveSource.Length).TotalMilliseconds;
            if (file.Tag.Pictures.Length != 0)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                AlbumArt.Image = Image.FromStream(new MemoryStream(bin));
            }
        }
        public void setLabel()
        {
            titleText.Text = MusicData.title;
            artistText.Text = MusicData.artist;
            albumText.Text = MusicData.album;
            PlayPause.Image = Properties.Resources.play;
            resizeIfNeeded();
            relocatelabel(titleText);
            relocatelabel(artistText);
            relocatelabel(albumText);
        }
        public void resizeIfNeeded()
        {
            while (artistText.Width < System.Windows.Forms.TextRenderer.MeasureText(artistText.Text, new Font(artistText.Font.FontFamily, artistText.Font.Size, artistText.Font.Style)).Width)
            {
                artistText.Font = new Font(artistText.Font.FontFamily, artistText.Font.Size - 0.5f, artistText.Font.Style);
                Application.DoEvents();
            }
            while (titleText.Width < System.Windows.Forms.TextRenderer.MeasureText(titleText.Text, new Font(titleText.Font.FontFamily, titleText.Font.Size, titleText.Font.Style)).Width)
            {
                titleText.Font = new Font(titleText.Font.FontFamily, titleText.Font.Size - 0.5f, titleText.Font.Style);
                Application.DoEvents();
            }
            while (albumText.Width < System.Windows.Forms.TextRenderer.MeasureText(albumText.Text, new Font(albumText.Font.FontFamily, albumText.Font.Size, albumText.Font.Style)).Width)
            {
                albumText.Font = new Font(albumText.Font.FontFamily, albumText.Font.Size - 0.5f, albumText.Font.Style);
                Application.DoEvents();
            }
        }
        public static void setPresence(string a, string b, double c, string d, string e, bool f)
        {
            if (client != null)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = a,
                    State = "By: " + b,
                    Timestamps = f == true ? Timestamps.FromTimeSpan(c / 1000) : null,
                    Assets = new Assets()
                    {
                        LargeImageKey = d,
                        LargeImageText = e,

                    }
                });
            }
        }
        public void CleanupPlayback()
        {
            titleText.Text = "";
            artistText.Text = "";
            albumText.Text = "";
            AlbumArt.Image = AlbumArt.InitialImage;
            trackTime.Text = "00:00:00 \\ 00:00:00";
            titleText.Font = new Font(titleText.Font.FontFamily, 12f, titleText.Font.Style);
            artistText.Font = new Font(artistText.Font.FontFamily, 12f, artistText.Font.Style);
            albumText.Font = new Font(albumText.Font.FontFamily, 12f, albumText.Font.Style);
            PlayPause.Image = Properties.Resources.pause;
            timer1.Dispose();
            timeTrackBar.Value = 0;
            if (soundOut != null)
            {
                soundOut.Dispose();
                soundOut = null;
            }
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }
        }
        public void relocatelabel(Label l)
        {
            int x = (this.Width / 2) - (l.Width / 2);
            l.Location = new Point((int)x, l.Location.Y);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            client.Dispose();
            client = null;
            CleanupPlayback();
        }
        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (soundOut != null && soundOut.PlaybackState == PlaybackState.Playing)
            {
                timer1.Stop();
                PlayPause.Image = Properties.Resources.pause;
                soundOut.Pause();
            }
            else if (soundOut != null && soundOut.PlaybackState == PlaybackState.Paused)
            {
                timer1.Start();
                PlayPause.Image = Properties.Resources.play;
                soundOut.Play();
            }
            titleText.Focus();
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            MusicData.queue.RemoveRange(0, MusicData.queue.Count);
            CleanupPlayback();
            titleText.Focus();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            CleanupPlayback();
            if (MusicData.queue.Count == 0) return;
            if (MusicData.queue.Count() >= 1)
            {
                playMusic();
                titleText.Focus();
                return;
            }
            titleText.Focus();
        }

        private void Unskip_Click(object sender, EventArgs e)
        {
            if (MusicData.previous.Count >= 2)
            {
                MusicData.queue.Insert(0, MusicData.previous[MusicData.previous.Count - 1]);
                MusicData.queue.Insert(0, MusicData.previous[MusicData.previous.Count - 2]);
                MusicData.previous.RemoveAt(MusicData.previous.Count - 1);
                MusicData.previous.RemoveAt(MusicData.previous.Count - 1);
                CleanupPlayback();
                playMusic();
                titleText.Focus();
                return;
            }
            titleText.Focus();
        }
        private void volumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (soundOut != null)
            {
                soundOut.Volume = Math.Min(1.0f, Math.Max(volumeTrackBar.Value / 100f, 0f));
                MusicData.volume = soundOut.Volume;
            }
            titleText.Focus();
        }

        private void timeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (soundOut != null)
            {
                soundOut.Pause();
                waveSource.Position = timeTrackBar.Value;
                System.Threading.Thread.Sleep(0);
                soundOut.Play();
            }
            titleText.Focus();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTrackBar.Maximum = (int)waveSource.Length;
            timeTrackBar.Value = (int)waveSource.Position;
            titleText.Focus();
        }

        private void viewQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MusicData.queue.Count != 0)
            {
                Thread queueThread = new Thread(new ThreadStart(RunQueue));
                queueThread.IsBackground = true;
                queueThread.Name = "Queue";
                queueThread.Start();
            }
            else
            {
                MessageBox.Show("There is no queue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static void RunQueue()
        {
           try
            {
                Application.Run(new QueueForm());
           }
            catch (ArgumentOutOfRangeException){ }
        }

        private void shuffleQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicData.queue = MusicData.queue.OrderBy(x => Guid.NewGuid()).ToList();
            MessageBox.Show("The queue has been shuffled!", "Shuffler", MessageBoxButtons.OK);
        }
    }
}
