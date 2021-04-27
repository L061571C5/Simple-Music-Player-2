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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleText = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.Label();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.albumText = new System.Windows.Forms.Label();
            this.trackTime = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volumePicture = new System.Windows.Forms.PictureBox();
            this.Unskip = new System.Windows.Forms.Button();
            this.AlbumArt = new System.Windows.Forms.PictureBox();
            this.Skip = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.PlayPause = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queueToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(-4, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem2.Text = "Open File";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem3.Text = "Open Folder";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem4.Text = "Open Folder Shuffled";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.openFolderShuffledToolStripMenuItem_Click);
            // 
            // queueToolStripMenuItem
            // 
            this.queueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewQueueToolStripMenuItem,
            this.shuffleQueueToolStripMenuItem});
            this.queueToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            this.queueToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.queueToolStripMenuItem.Text = "Queue";
            // 
            // viewQueueToolStripMenuItem
            // 
            this.viewQueueToolStripMenuItem.Name = "viewQueueToolStripMenuItem";
            this.viewQueueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewQueueToolStripMenuItem.Text = "View Queue";
            this.viewQueueToolStripMenuItem.Click += new System.EventHandler(this.viewQueueToolStripMenuItem_Click);
            // 
            // shuffleQueueToolStripMenuItem
            // 
            this.shuffleQueueToolStripMenuItem.Name = "shuffleQueueToolStripMenuItem";
            this.shuffleQueueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shuffleQueueToolStripMenuItem.Text = "Shuffle Queue";
            this.shuffleQueueToolStripMenuItem.Click += new System.EventHandler(this.shuffleQueueToolStripMenuItem_Click);
            // 
            // titleText
            // 
            this.titleText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.DarkGray;
            this.titleText.Location = new System.Drawing.Point(263, 67);
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
            this.artistText.Location = new System.Drawing.Point(263, 106);
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
            this.timeTrackBar.Location = new System.Drawing.Point(24, 436);
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
            this.albumText.Location = new System.Drawing.Point(263, 145);
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
            this.trackTime.Location = new System.Drawing.Point(217, 409);
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
            this.volumeTrackBar.Location = new System.Drawing.Point(24, 506);
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
            // volumePicture
            // 
            this.volumePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumePicture.Image = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.volumePicture.InitialImage = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.volumePicture.Location = new System.Drawing.Point(75, 475);
            this.volumePicture.Name = "volumePicture";
            this.volumePicture.Size = new System.Drawing.Size(24, 24);
            this.volumePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volumePicture.TabIndex = 13;
            this.volumePicture.TabStop = false;
            // 
            // Unskip
            // 
            this.Unskip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unskip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unskip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Unskip.Image = global::Simple_Music_Player_2.Properties.Resources.unskip;
            this.Unskip.Location = new System.Drawing.Point(156, 487);
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
            this.AlbumArt.Location = new System.Drawing.Point(187, 189);
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
            this.Skip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Skip.Image = global::Simple_Music_Player_2.Properties.Resources.skip;
            this.Skip.Location = new System.Drawing.Point(344, 487);
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
            this.Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Stop.Image = global::Simple_Music_Player_2.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(440, 487);
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
            this.PlayPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PlayPause.Image = global::Simple_Music_Player_2.Properties.Resources.pause;
            this.PlayPause.Location = new System.Drawing.Point(255, 487);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(559, 611);
            this.Controls.Add(this.volumePicture);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(549, 599);
            this.Name = "BaseForm";
            this.Text = "Music Player 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label artistText;
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
        private System.Windows.Forms.PictureBox volumePicture;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleQueueToolStripMenuItem;
    }
}

