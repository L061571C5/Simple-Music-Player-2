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
            this.formTitleBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainlabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.volumePicture = new System.Windows.Forms.PictureBox();
            this.Unskip = new System.Windows.Forms.Button();
            this.AlbumArt = new System.Windows.Forms.PictureBox();
            this.Skip = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.PlayPause = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.formTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openFolderShuffledToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // openFolderShuffledToolStripMenuItem
            // 
            this.openFolderShuffledToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.titleText.Location = new System.Drawing.Point(259, 62);
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
            this.artistText.Location = new System.Drawing.Point(259, 101);
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
            this.timeTrackBar.Location = new System.Drawing.Point(20, 431);
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
            this.albumText.Location = new System.Drawing.Point(259, 140);
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
            this.trackTime.Location = new System.Drawing.Point(213, 404);
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
            this.volumeTrackBar.Location = new System.Drawing.Point(20, 501);
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
            // formTitleBar
            // 
            this.formTitleBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formTitleBar.Controls.Add(this.minimizeButton);
            this.formTitleBar.Controls.Add(this.maximizeButton);
            this.formTitleBar.Controls.Add(this.closeButton);
            this.formTitleBar.Controls.Add(this.mainlabel);
            this.formTitleBar.Controls.Add(this.icon);
            this.formTitleBar.Location = new System.Drawing.Point(0, 0);
            this.formTitleBar.Name = "formTitleBar";
            this.formTitleBar.Size = new System.Drawing.Size(550, 26);
            this.formTitleBar.TabIndex = 14;
            this.formTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formTitleBar_MouseMove);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Gray;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(458, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 26);
            this.minimizeButton.TabIndex = 15;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.Gray;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(488, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(33, 26);
            this.maximizeButton.TabIndex = 17;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Gray;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(518, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 26);
            this.closeButton.TabIndex = 18;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainlabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlabel.ForeColor = System.Drawing.Color.Silver;
            this.mainlabel.Location = new System.Drawing.Point(32, 4);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(143, 17);
            this.mainlabel.TabIndex = 15;
            this.mainlabel.Text = "Simple Music Player 2";
            this.mainlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mainlabel_MouseMove);
            // 
            // icon
            // 
            this.icon.Image = global::Simple_Music_Player_2.Properties.Resources.icon;
            this.icon.Location = new System.Drawing.Point(10, 5);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(16, 16);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 15;
            this.icon.TabStop = false;
            this.icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_MouseMove);
            // 
            // volumePicture
            // 
            this.volumePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volumePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volumePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumePicture.Image = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.volumePicture.InitialImage = global::Simple_Music_Player_2.Properties.Resources.megaphone;
            this.volumePicture.Location = new System.Drawing.Point(71, 470);
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
            this.Unskip.Location = new System.Drawing.Point(152, 482);
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
            this.AlbumArt.Location = new System.Drawing.Point(183, 184);
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
            this.Skip.Location = new System.Drawing.Point(340, 482);
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
            this.Stop.Location = new System.Drawing.Point(436, 482);
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
            this.PlayPause.Location = new System.Drawing.Point(251, 482);
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
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.formTitleBar);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.formTitleBar.ResumeLayout(false);
            this.formTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).EndInit();
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
        private System.Windows.Forms.Panel formTitleBar;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.PictureBox volumePicture;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
    }
}

