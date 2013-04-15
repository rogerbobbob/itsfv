namespace iTSfvGUI
{
    partial class ValidatorWizard
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
            this.tcValidator = new System.Windows.Forms.TabControl();
            this.tpDiscs = new System.Windows.Forms.TabPage();
            this.lbDiscs = new System.Windows.Forms.ListBox();
            this.tpChecks = new System.Windows.Forms.TabPage();
            this.chkChecksItunesStoreStandard = new System.Windows.Forms.CheckBox();
            this.tpTracks = new System.Windows.Forms.TabPage();
            this.chkTracksAlbumArtistFill = new System.Windows.Forms.CheckBox();
            this.chkTracksGenreFill = new System.Windows.Forms.CheckBox();
            this.tpFileSystem = new System.Windows.Forms.TabPage();
            this.chkFileSystemExportArtworkFolderJpg = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTasksAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.ttApp = new System.Windows.Forms.ToolTip(this.components);
            this.tvLibrary = new System.Windows.Forms.TreeView();
            this.tcValidator.SuspendLayout();
            this.tpDiscs.SuspendLayout();
            this.tpChecks.SuspendLayout();
            this.tpTracks.SuspendLayout();
            this.tpFileSystem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcValidator
            // 
            this.tcValidator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcValidator.Controls.Add(this.tpDiscs);
            this.tcValidator.Controls.Add(this.tpChecks);
            this.tcValidator.Controls.Add(this.tpTracks);
            this.tcValidator.Controls.Add(this.tpFileSystem);
            this.tcValidator.Location = new System.Drawing.Point(343, 24);
            this.tcValidator.Name = "tcValidator";
            this.tcValidator.SelectedIndex = 0;
            this.tcValidator.Size = new System.Drawing.Size(601, 417);
            this.tcValidator.TabIndex = 1;
            // 
            // tpDiscs
            // 
            this.tpDiscs.Controls.Add(this.lbDiscs);
            this.tpDiscs.Location = new System.Drawing.Point(4, 22);
            this.tpDiscs.Name = "tpDiscs";
            this.tpDiscs.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiscs.Size = new System.Drawing.Size(593, 391);
            this.tpDiscs.TabIndex = 0;
            this.tpDiscs.Text = "Discs";
            this.tpDiscs.UseVisualStyleBackColor = true;
            // 
            // lbDiscs
            // 
            this.lbDiscs.AllowDrop = true;
            this.lbDiscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscs.FormattingEnabled = true;
            this.lbDiscs.Location = new System.Drawing.Point(3, 3);
            this.lbDiscs.Name = "lbDiscs";
            this.lbDiscs.Size = new System.Drawing.Size(587, 385);
            this.lbDiscs.Sorted = true;
            this.lbDiscs.TabIndex = 0;
            this.lbDiscs.SelectedIndexChanged += new System.EventHandler(this.lbDiscs_SelectedIndexChanged);
            this.lbDiscs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragDrop);
            this.lbDiscs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragEnter);
            this.lbDiscs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDiscs_MouseDown);
            // 
            // tpChecks
            // 
            this.tpChecks.Controls.Add(this.chkChecksItunesStoreStandard);
            this.tpChecks.Location = new System.Drawing.Point(4, 22);
            this.tpChecks.Name = "tpChecks";
            this.tpChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tpChecks.Size = new System.Drawing.Size(593, 391);
            this.tpChecks.TabIndex = 1;
            this.tpChecks.Text = "Checks";
            this.tpChecks.UseVisualStyleBackColor = true;
            // 
            // chkChecksItunesStoreStandard
            // 
            this.chkChecksItunesStoreStandard.AutoSize = true;
            this.chkChecksItunesStoreStandard.Location = new System.Drawing.Point(8, 8);
            this.chkChecksItunesStoreStandard.Name = "chkChecksItunesStoreStandard";
            this.chkChecksItunesStoreStandard.Size = new System.Drawing.Size(179, 17);
            this.chkChecksItunesStoreStandard.TabIndex = 0;
            this.chkChecksItunesStoreStandard.Text = "Check for iTunes Store standard";
            this.chkChecksItunesStoreStandard.UseVisualStyleBackColor = true;
            // 
            // tpTracks
            // 
            this.tpTracks.Controls.Add(this.chkTracksAlbumArtistFill);
            this.tpTracks.Controls.Add(this.chkTracksGenreFill);
            this.tpTracks.Location = new System.Drawing.Point(4, 22);
            this.tpTracks.Name = "tpTracks";
            this.tpTracks.Padding = new System.Windows.Forms.Padding(3);
            this.tpTracks.Size = new System.Drawing.Size(593, 391);
            this.tpTracks.TabIndex = 2;
            this.tpTracks.Text = "Tracks";
            this.tpTracks.UseVisualStyleBackColor = true;
            // 
            // chkTracksAlbumArtistFill
            // 
            this.chkTracksAlbumArtistFill.AutoSize = true;
            this.chkTracksAlbumArtistFill.Location = new System.Drawing.Point(8, 32);
            this.chkTracksAlbumArtistFill.Name = "chkTracksAlbumArtistFill";
            this.chkTracksAlbumArtistFill.Size = new System.Drawing.Size(215, 17);
            this.chkTracksAlbumArtistFill.TabIndex = 1;
            this.chkTracksAlbumArtistFill.Text = "Fill missing Album Artist using best guess";
            this.chkTracksAlbumArtistFill.UseVisualStyleBackColor = true;
            // 
            // chkTracksGenreFill
            // 
            this.chkTracksGenreFill.AutoSize = true;
            this.chkTracksGenreFill.Location = new System.Drawing.Point(8, 8);
            this.chkTracksGenreFill.Name = "chkTracksGenreFill";
            this.chkTracksGenreFill.Size = new System.Drawing.Size(187, 17);
            this.chkTracksGenreFill.TabIndex = 0;
            this.chkTracksGenreFill.Text = "Fill missing genre using best guess";
            this.chkTracksGenreFill.UseVisualStyleBackColor = true;
            // 
            // tpFileSystem
            // 
            this.tpFileSystem.Controls.Add(this.chkFileSystemExportArtworkFolderJpg);
            this.tpFileSystem.Location = new System.Drawing.Point(4, 22);
            this.tpFileSystem.Name = "tpFileSystem";
            this.tpFileSystem.Size = new System.Drawing.Size(593, 391);
            this.tpFileSystem.TabIndex = 3;
            this.tpFileSystem.Text = "FileSystem";
            this.tpFileSystem.UseVisualStyleBackColor = true;
            // 
            // chkFileSystemExportArtworkFolderJpg
            // 
            this.chkFileSystemExportArtworkFolderJpg.AutoSize = true;
            this.chkFileSystemExportArtworkFolderJpg.Location = new System.Drawing.Point(8, 8);
            this.chkFileSystemExportArtworkFolderJpg.Name = "chkFileSystemExportArtworkFolderJpg";
            this.chkFileSystemExportArtworkFolderJpg.Size = new System.Drawing.Size(231, 17);
            this.chkFileSystemExportArtworkFolderJpg.TabIndex = 0;
            this.chkFileSystemExportArtworkFolderJpg.Text = "Export Artwork to Album folder as Folder.jpg";
            this.chkFileSystemExportArtworkFolderJpg.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTasksAddFiles});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowsToolStripMenuItem.Text = "&Tasks";
            // 
            // tsmiTasksAddFiles
            // 
            this.tsmiTasksAddFiles.Name = "tsmiTasksAddFiles";
            this.tsmiTasksAddFiles.Size = new System.Drawing.Size(131, 22);
            this.tsmiTasksAddFiles.Text = "&Add Files...";
            this.tsmiTasksAddFiles.Click += new System.EventHandler(this.miTasksAddFiles_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(125, 22);
            this.tsmiOptions.Text = "&Options...";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // tvLibrary
            // 
            this.tvLibrary.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvLibrary.Location = new System.Drawing.Point(0, 24);
            this.tvLibrary.Name = "tvLibrary";
            this.tvLibrary.Size = new System.Drawing.Size(337, 417);
            this.tvLibrary.TabIndex = 2;
            this.tvLibrary.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLibrary_NodeMouseClick);
            this.tvLibrary.Click += new System.EventHandler(this.tvLibrary_Click);
            // 
            // ValidatorWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.tvLibrary);
            this.Controls.Add(this.tcValidator);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "ValidatorWizard";
            this.Text = "iTSfv";
            this.Load += new System.EventHandler(this.ValidatorWizard_Load);
            this.Shown += new System.EventHandler(this.ValidatorWizard_Shown);
            this.Move += new System.EventHandler(this.ValidatorWizard_Move);
            this.tcValidator.ResumeLayout(false);
            this.tpDiscs.ResumeLayout(false);
            this.tpChecks.ResumeLayout(false);
            this.tpChecks.PerformLayout();
            this.tpTracks.ResumeLayout(false);
            this.tpTracks.PerformLayout();
            this.tpFileSystem.ResumeLayout(false);
            this.tpFileSystem.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcValidator;
        private System.Windows.Forms.TabPage tpChecks;
        private System.Windows.Forms.TabPage tpTracks;
        private System.Windows.Forms.TabPage tpFileSystem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTasksAddFiles;
        private System.Windows.Forms.CheckBox chkTracksGenreFill;
        private System.Windows.Forms.TabPage tpDiscs;
        private System.Windows.Forms.ListBox lbDiscs;
        private System.Windows.Forms.ToolTip ttApp;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.CheckBox chkChecksItunesStoreStandard;
        private System.Windows.Forms.CheckBox chkTracksAlbumArtistFill;
        private System.Windows.Forms.CheckBox chkFileSystemExportArtworkFolderJpg;
        private System.Windows.Forms.TreeView tvLibrary;
    }
}

