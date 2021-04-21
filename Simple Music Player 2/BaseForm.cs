using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using DiscordRPC;

namespace Simple_Music_Player_2
{

    public partial class BaseForm : Form
    {
        public static DiscordRpcClient client = new DiscordRpcClient("834077982628511764");
        public static bool rpcInitialised = false;
        public static ISoundOut soundOut;
        public static IWaveSource waveSource;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "Music files (*.mp3, *.flac)|*.mp3;*.flac";
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
                MusicData.queue = ProcessDirectory(selectedFolderPath);
                playMusic();
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
                MusicData.queue = (ProcessDirectory(selectedFolderPath)).OrderBy(x => Guid.NewGuid()).ToList();
                playMusic();
            }
        }
        public static List<string> ProcessDirectory(string targetDirectory)
        {
            List<string> lst = new List<string>();
            // Process the list of files found in the directory.
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
            waveSource = CodecFactory.Instance.GetCodec(MusicData.queue[0]).ToSampleSource().ToWaveSource();
            soundOut = new WasapiOut() { Latency = 100 };
            soundOut.Initialize(waveSource);
            soundOut.Play();

            TagLib.File file = TagLib.File.Create(MusicData.queue[0]);
            TimeSpan time = waveSource.GetTime(waveSource.Length);
            var title = String.IsNullOrWhiteSpace(file.Tag.Title) ? file.Name.Split('\\')[file.Name.Split('\\').Length - 1].Split('.')[0] : file.Tag.Title;
            var artist = file.Tag.Performers.Length == 0 ? "Artist: N/A" : file.Tag.Performers.Length > 1 ? "Artists: " + String.Join(", ", file.Tag.Performers) : "Artist: " + file.Tag.Performers[0];
            var album = String.IsNullOrWhiteSpace(file.Tag.Album) ? "N/A" : file.Tag.Album;
            double ms = waveSource.Position * 1000.0 / waveSource.WaveFormat.BitsPerSample / waveSource.WaveFormat.Channels * 8 / waveSource.WaveFormat.SampleRate;
            setPresence(title, artist, (time.TotalMilliseconds - ms), "logo", album, soundOut.PlaybackState == PlaybackState.Playing ? "playing" : "paused");
            titleText.Font = new Font(titleText.Font.FontFamily, 12f, titleText.Font.Style);
            artistText.Font = new Font(artistText.Font.FontFamily, 12f, artistText.Font.Style);
            albumText.Font = new Font(albumText.Font.FontFamily, 12f, albumText.Font.Style);
            titleText.Text = "Title: " + title;
            artistText.Text = artist;
            albumText.Text = "Album: " + album;
            if (file.Tag.Pictures.Length != 0)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                AlbumArt.Image = Image.FromStream(new MemoryStream(bin));
            }
            resizeIfNeeded();
            while (soundOut != null && (soundOut.PlaybackState == PlaybackState.Playing || soundOut.PlaybackState == PlaybackState.Paused))
            {
                ms = waveSource.Position * 1000.0 / waveSource.WaveFormat.BitsPerSample / waveSource.WaveFormat.Channels * 8 / waveSource.WaveFormat.SampleRate;
                setPresence(title, artist, (time.TotalMilliseconds - ms), "logo", album, soundOut.PlaybackState == PlaybackState.Playing ? "playing" : "paused");
                Application.DoEvents(); //let the app show the picturebox
                Thread.Sleep(250);
            }
            if (soundOut != null && soundOut.PlaybackState == PlaybackState.Stopped)
            {
                MusicData.queue.RemoveAt(0);
                if (MusicData.queue.Count() >= 1)
                {
                    CleanupPlayback();
                    playMusic();
                    return;
                }
            }
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
        public static void setPresence(string a, string b, double c, string d, string e, string f)
        {
            client.SetPresence(new RichPresence()
            {
                Details = a,
                State = "By: " + b,
                Timestamps = Timestamps.FromTimeSpan(c / 1000),
                Assets = new Assets()
                {
                    LargeImageKey = d,
                    LargeImageText = e,
                    SmallImageKey = f,

                }
            });
        }
        public static void CleanupPlayback()
        {
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            client.Dispose();
            client = null;
            CleanupPlayback();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (soundOut != null && soundOut.PlaybackState == PlaybackState.Playing) soundOut.Pause();
            else if (soundOut != null && soundOut.PlaybackState == PlaybackState.Paused) soundOut.Play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            MusicData.queue.RemoveRange(0, MusicData.queue.Count);
            titleText.Text = "Title";
            artistText.Text = "Artist";
            albumText.Text = "Album";
            CleanupPlayback();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            CleanupPlayback();
            if (MusicData.queue.Count == 0) return;
            MusicData.queue.RemoveAt(0);
            if (MusicData.queue.Count() >= 1)
            {
                playMusic();
                return;
            }
        }
    }
    static class MusicData
    {
        public static List<string> queue = new List<string>();
        public static float volume = 1f;
    }
}
