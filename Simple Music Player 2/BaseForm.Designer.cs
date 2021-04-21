
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderShuffledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleText = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.Label();
            this.albumText = new System.Windows.Forms.Label();
            this.PlayPause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.AlbumArt = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumArt)).BeginInit();
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
            this.titleText.Location = new System.Drawing.Point(12, 27);
            this.titleText.MaximumSize = new System.Drawing.Size(332, 0);
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
            this.artistText.Location = new System.Drawing.Point(12, 61);
            this.artistText.MaximumSize = new System.Drawing.Size(332, 0);
            this.artistText.Name = "artistText";
            this.artistText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artistText.Size = new System.Drawing.Size(44, 24);
            this.artistText.TabIndex = 2;
            this.artistText.Text = "Artist";
            this.artistText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // albumText
            // 
            this.albumText.AutoSize = true;
            this.albumText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumText.Location = new System.Drawing.Point(12, 94);
            this.albumText.MinimumSize = new System.Drawing.Size(332, 0);
            this.albumText.Name = "albumText";
            this.albumText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.albumText.Size = new System.Drawing.Size(332, 24);
            this.albumText.TabIndex = 3;
            this.albumText.Text = "Album";
            // 
            // PlayPause
            // 
            this.PlayPause.Location = new System.Drawing.Point(12, 126);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(75, 23);
            this.PlayPause.TabIndex = 4;
            this.PlayPause.Text = "Play/Pause";
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(174, 126);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(93, 126);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(75, 23);
            this.Skip.TabIndex = 6;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // AlbumArt
            // 
            this.AlbumArt.Image = ((System.Drawing.Image)(resources.GetObject("AlbumArt.Image")));
            this.AlbumArt.InitialImage = ((System.Drawing.Image)(resources.GetObject("AlbumArt.InitialImage")));
            this.AlbumArt.Location = new System.Drawing.Point(350, 27);
            this.AlbumArt.Name = "AlbumArt";
            this.AlbumArt.Size = new System.Drawing.Size(128, 128);
            this.AlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlbumArt.TabIndex = 7;
            this.AlbumArt.TabStop = false;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.AlbumArt);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.PlayPause);
            this.Controls.Add(this.albumText);
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
        private System.Windows.Forms.Label albumText;
        private System.Windows.Forms.ToolStripMenuItem openFolderShuffledToolStripMenuItem;
        private System.Windows.Forms.Button PlayPause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.PictureBox AlbumArt;
    }
}

