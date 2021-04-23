namespace Simple_Music_Player_2
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderShuffledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleText = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.Label();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.albumText = new System.Windows.Forms.Label();
            this.trackTime = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Unskip = new System.Windows.Forms.Button();
            this.AlbumArt = new System.Windows.Forms.PictureBox();
            this.Skip = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.PlayPause = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openFolderShuffledToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openFolderShuffledToolStripMenuItem
            // 
            this.openFolderShuffledToolStripMenuItem.Name = "openFolderShuffledToolStripMenuItem";
            this.openFolderShuffledToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFolderShuffledToolStripMenuItem.Text = "Open Folder Shuffled";
            this.openFolderShuffledToolStripMenuItem.Click += new System.EventHandler(this.openFolderShuffledToolStripMenuItem_Click);
            // 
            // titleText
            // 
            this.titleText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.DarkGray;
            this.titleText.Location = new System.Drawing.Point(251, 42);
            this.titleText.MaximumSize = new System.Drawing.Size(311, 24);
            this.titleText.Name = "titleText";
            this.titleText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleText.Size = new System.Drawing.Size(0, 24);
            this.titleText.TabIndex = 1;
            this.titleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // artistText
            // 
            this.artistText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artistText.AutoSize = true;
            this.artistText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistText.ForeColor = System.Drawing.Color.DarkGray;
            this.artistText.Location = new System.Drawing.Point(251, 81);
            this.artistText.MaximumSize = new System.Drawing.Size(311, 24);
            this.artistText.Name = "artistText";
            this.artistText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artistText.Size = new System.Drawing.Size(0, 24);
            this.artistText.TabIndex = 2;
            this.artistText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTrackBar.LargeChange = 1;
            this.timeTrackBar.Location = new System.Drawing.Point(12, 411);
            this.timeTrackBar.Maximum = 1000;
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.Size = new System.Drawing.Size(510, 45);
            this.timeTrackBar.TabIndex = 4;
            this.timeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timeTrackBar.ValueChanged += new System.EventHandler(this.timeTrackBar_ValueChanged);
            // 
            // albumText
            // 
            this.albumText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.albumText.AutoSize = true;
            this.albumText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumText.ForeColor = System.Drawing.Color.DarkGray;
            this.albumText.Location = new System.Drawing.Point(251, 120);
            this.albumText.MaximumSize = new System.Drawing.Size(311, 24);
            this.albumText.Name = "albumText";
            this.albumText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albumText.Size = new System.Drawing.Size(0, 24);
            this.albumText.TabIndex = 9;
            this.albumText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackTime
            // 
            this.trackTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackTime.AutoSize = true;
            this.trackTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackTime.ForeColor = System.Drawing.Color.DarkGray;
            this.trackTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.trackTime.Location = new System.Drawing.Point(205, 384);
            this.trackTime.MaximumSize = new System.Drawing.Size(332, 0);
            this.trackTime.Name = "trackTime";
            this.trackTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trackTime.Size = new System.Drawing.Size(135, 24);
            this.trackTime.TabIndex = 10;
            this.trackTime.Text = "00:00:00 \\ 00:00:00";
            this.trackTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumeTrackBar.CausesValidation = false;
            this.volumeTrackBar.LargeChange = 1;
            this.volumeTrackBar.Location = new System.Drawing.Point(12, 481);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(126, 45);
            this.volumeTrackBar.TabIndex = 12;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.pictureBox1.InitialImage = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.pictureBox1.Location = new System.Drawing.Point(63, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Unskip
            // 
            this.Unskip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unskip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unskip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Unskip.Image = global::Simple_Music_Player_2.Properties.Resources.unskip;
            this.Unskip.Location = new System.Drawing.Point(144, 462);
            this.Unskip.Name = "Unskip";
            this.Unskip.Size = new System.Drawing.Size(64, 64);
            this.Unskip.TabIndex = 11;
            this.Unskip.UseVisualStyleBackColor = true;
            this.Unskip.Click += new System.EventHandler(this.Unskip_Click);
            // 
            // AlbumArt
            // 
            this.AlbumArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlbumArt.Image = ((System.Drawing.Image)(resources.GetObject("AlbumArt.Image")));
            this.AlbumArt.InitialImage = ((System.Drawing.Image)(resources.GetObject("AlbumArt.InitialImage")));
            this.AlbumArt.Location = new System.Drawing.Point(175, 164);
            this.AlbumArt.Name = "AlbumArt";
            this.AlbumArt.Size = new System.Drawing.Size(200, 200);
            this.AlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumArt.TabIndex = 7;
            this.AlbumArt.TabStop = false;
            // 
            // Skip
            // 
            this.Skip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Skip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Skip.Image = global::Simple_Music_Player_2.Properties.Resources.skip;
            this.Skip.Location = new System.Drawing.Point(332, 462);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(64, 64);
            this.Skip.TabIndex = 6;
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stop.Image = global::Simple_Music_Player_2.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(428, 462);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(64, 64);
            this.Stop.TabIndex = 5;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // PlayPause
            // 
            this.PlayPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayPause.Image = global::Simple_Music_Player_2.Properties.Resources.pause;
            this.PlayPause.Location = new System.Drawing.Point(243, 462);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(64, 64);
            this.PlayPause.TabIndex = 4;
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.Unskip);
            this.Controls.Add(this.trackTime);
            this.Controls.Add(this.albumText);
            this.Controls.Add(this.timeTrackBar);
            this.Controls.Add(this.AlbumArt);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PlayPause);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "BaseForm";
            this.Text = "Music Player 2";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label artistText;
        private System.Windows.Forms.ToolStripMenuItem openFolderShuffledToolStripMenuItem;
        private System.Windows.Forms.Button PlayPause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.PictureBox AlbumArt;
        private System.Windows.Forms.TrackBar timeTrackBar;
        private System.Windows.Forms.Label albumText;
        private System.Windows.Forms.Label trackTime;
        private System.Windows.Forms.Button Unskip;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

