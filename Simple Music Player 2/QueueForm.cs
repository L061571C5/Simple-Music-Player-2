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
            queueListView.VirtualMode = true;
            queueListView.VirtualListSize = MusicData.queue.Count -1;
        }
        public void queueListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
                int itemIndex = e.ItemIndex;
                TagLib.File file = TagLib.File.Create(MusicData.queue[itemIndex]);
                string title = String.IsNullOrWhiteSpace(file.Tag.Title) ? file.Name.Split('\\')[file.Name.Split('\\').Length - 1].Split('.')[0] : file.Tag.Title;
                string artist = file.Tag.Performers.Length == 0 ? "N/A" : file.Tag.Performers.Length > 1 ? String.Join(", ", file.Tag.Performers) : file.Tag.Performers[0];
                string album = String.IsNullOrWhiteSpace(file.Tag.Album) ? "N/A" : file.Tag.Album;
                ListViewItem data = new ListViewItem(new string[] { (itemIndex + 1).ToString(), title, artist, album });
                e.Item = data;
        }
    }
}
