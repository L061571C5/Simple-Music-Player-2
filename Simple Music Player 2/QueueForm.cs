using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Music_Player_2
{
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();
            MessageBox.Show("The queue is initializing...", "Loading", MessageBoxButtons.OK);
            List<string> queue = MusicData.queue;
            queue.RemoveAt(0);
            int i = 0;
            queueListView.BeginUpdate();
            foreach (var a in queue)
            {
                TagLib.File file = TagLib.File.Create(queue[i]);
                string title = String.IsNullOrWhiteSpace(file.Tag.Title) ? file.Name.Split('\\')[file.Name.Split('\\').Length - 1].Split('.')[0] : file.Tag.Title;
                string artist = file.Tag.Performers.Length == 0 ? "N/A" : file.Tag.Performers.Length > 1 ? String.Join(", ", file.Tag.Performers) : file.Tag.Performers[0];
                string album = String.IsNullOrWhiteSpace(file.Tag.Album) ? "N/A" : file.Tag.Album;
                queueListView.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), title, artist, album}));
                i++;
            }
            queueListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            queueListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            queueListView.EndUpdate();
        }
    }
}
