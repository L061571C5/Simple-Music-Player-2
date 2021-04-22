
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
            this.PlayPause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.AlbumArt = new System.Windows.Forms.PictureBox();
            this.timeTrackBar = new System.Windows.Forms.TrackBar();
            this.albumText = new System.Windows.Forms.Label();
            this.trackTime = new System.Windows.Forms.Label();
            this.Unskip = new System.Windows.Forms.Button();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.openFolderShuffledToolStripMenuItem});
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
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(4, 27);
            this.titleText.MaximumSize = new System.Drawing.Size(311, 24);
            this.titleText.Name = "titleText";
            this.titleText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.titleText.Size = new System.Drawing.Size(38, 24);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Title";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // artistText
            // 
            this.artistText.AutoSize = true;
            this.artistText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistText.Location = new System.Drawing.Point(4, 63);
            this.artistText.MaximumSize = new System.Drawing.Size(311, 24);
            this.artistText.Name = "artistText";
            this.artistText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artistText.Size = new System.Drawing.Size(44, 24);
            this.artistText.TabIndex = 2;
            this.artistText.Text = "Artist";
            this.artistText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayPause
            // 
            this.PlayPause.Location = new System.Drawing.Point(8, 201);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(70, 23);
            this.PlayPause.TabIndex = 4;
            this.PlayPause.Text = "Play/Pause";
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(236, 201);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(70, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(160, 201);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(70, 23);
            this.Skip.TabIndex = 6;
            this.Skip.Text = "Next";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // AlbumArt
            // 
            this.AlbumArt.Image = ((System.Drawing.Image)(resources.GetObject("AlbumArt.Image")));
            this.AlbumArt.InitialImage = ((System.Drawing.Image)(resources.GetObject("AlbumArt.InitialImage")));
            this.AlbumArt.Location = new System.Drawing.Point(326, 78);
            this.AlbumArt.Name = "AlbumArt";
            this.AlbumArt.Size = new System.Drawing.Size(150, 150);
            this.AlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumArt.TabIndex = 7;
            this.AlbumArt.TabStop = false;
            // 
            // timeTrackBar
            // 
            this.timeTrackBar.LargeChange = 1;
            this.timeTrackBar.Location = new System.Drawing.Point(8, 137);
            this.timeTrackBar.Maximum = 1000;
            this.timeTrackBar.Name = "timeTrackBar";
            this.timeTrackBar.Size = new System.Drawing.Size(298, 45);
            this.timeTrackBar.TabIndex = 4;
            this.timeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timeTrackBar.ValueChanged += new System.EventHandler(this.timeTrackBar_ValueChanged);
            // 
            // albumText
            // 
            this.albumText.AutoSize = true;
            this.albumText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumText.Location = new System.Drawing.Point(4, 100);
            this.albumText.MaximumSize = new System.Drawing.Size(311, 24);
            this.albumText.Name = "albumText";
            this.albumText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albumText.Size = new System.Drawing.Size(50, 24);
            this.albumText.TabIndex = 9;
            this.albumText.Text = "Album";
            this.albumText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackTime
            // 
            this.trackTime.AutoSize = true;
            this.trackTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackTime.Location = new System.Drawing.Point(83, 158);
            this.trackTime.MaximumSize = new System.Drawing.Size(332, 0);
            this.trackTime.Name = "trackTime";
            this.trackTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.trackTime.Size = new System.Drawing.Size(135, 24);
            this.trackTime.TabIndex = 10;
            this.trackTime.Text = "00:00:00 \\ 00:00:00";
            this.trackTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Unskip
            // 
            this.Unskip.Location = new System.Drawing.Point(84, 201);
            this.Unskip.Name = "Unskip";
            this.Unskip.Size = new System.Drawing.Size(70, 23);
            this.Unskip.TabIndex = 11;
            this.Unskip.Text = "Previous";
            this.Unskip.UseVisualStyleBackColor = true;
            this.Unskip.Click += new System.EventHandler(this.Unskip_Click);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.CausesValidation = false;
            this.volumeTrackBar.LargeChange = 1;
            this.volumeTrackBar.Location = new System.Drawing.Point(326, 29);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(150, 45);
            this.volumeTrackBar.TabIndex = 12;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.volumeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(326, 50);
            this.volumeLabel.MaximumSize = new System.Drawing.Size(311, 24);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.volumeLabel.Size = new System.Drawing.Size(150, 24);
            this.volumeLabel.TabIndex = 13;
            this.volumeLabel.Text = "Volume";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.volumeLabel);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "BaseForm";
            this.Text = "Music Player 2";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
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
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

