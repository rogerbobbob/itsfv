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
            this.tpChecks = new System.Windows.Forms.TabPage();
            this.chkChecksMissingTags = new System.Windows.Forms.CheckBox();
            this.tpTracks = new System.Windows.Forms.TabPage();
            this.chkTracksAlbumArtistFill = new System.Windows.Forms.CheckBox();
            this.chkTracksGenreFill = new System.Windows.Forms.CheckBox();
            this.tpFileSystem = new System.Windows.Forms.TabPage();
            this.chkFileSystemExportArtworkFolderJpg = new System.Windows.Forms.CheckBox();
            this.lbDiscs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTasksAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTasksValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.ttApp = new System.Windows.Forms.ToolTip(this.components);
            this.tvLibrary = new System.Windows.Forms.TreeView();
            this.tlpApp = new System.Windows.Forms.TableLayoutPanel();
            this.flpChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTracks = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFileSystem = new System.Windows.Forms.FlowLayoutPanel();
            this.chkFillMissingTrackCount = new System.Windows.Forms.CheckBox();
            this.tcValidator.SuspendLayout();
            this.tpChecks.SuspendLayout();
            this.tpTracks.SuspendLayout();
            this.tpFileSystem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tlpApp.SuspendLayout();
            this.flpChecks.SuspendLayout();
            this.flpTracks.SuspendLayout();
            this.flpFileSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcValidator
            // 
            this.tcValidator.Controls.Add(this.tpChecks);
            this.tcValidator.Controls.Add(this.tpTracks);
            this.tcValidator.Controls.Add(this.tpFileSystem);
            this.tcValidator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcValidator.Location = new System.Drawing.Point(3, 3);
            this.tcValidator.Name = "tcValidator";
            this.tcValidator.SelectedIndex = 0;
            this.tcValidator.Size = new System.Drawing.Size(308, 411);
            this.tcValidator.TabIndex = 1;
            // 
            // tpChecks
            // 
            this.tpChecks.Controls.Add(this.flpChecks);
            this.tpChecks.Location = new System.Drawing.Point(4, 22);
            this.tpChecks.Name = "tpChecks";
            this.tpChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tpChecks.Size = new System.Drawing.Size(300, 385);
            this.tpChecks.TabIndex = 1;
            this.tpChecks.Text = "Checks";
            this.tpChecks.UseVisualStyleBackColor = true;
            // 
            // chkChecksMissingTags
            // 
            this.chkChecksMissingTags.AutoSize = true;
            this.chkChecksMissingTags.Location = new System.Drawing.Point(3, 3);
            this.chkChecksMissingTags.Name = "chkChecksMissingTags";
            this.chkChecksMissingTags.Size = new System.Drawing.Size(132, 17);
            this.chkChecksMissingTags.TabIndex = 0;
            this.chkChecksMissingTags.Text = "Check for missing tags";
            this.chkChecksMissingTags.UseVisualStyleBackColor = true;
            this.chkChecksMissingTags.CheckedChanged += new System.EventHandler(this.chkChecksMissingTags_CheckedChanged);
            // 
            // tpTracks
            // 
            this.tpTracks.Controls.Add(this.flpTracks);
            this.tpTracks.Location = new System.Drawing.Point(4, 22);
            this.tpTracks.Name = "tpTracks";
            this.tpTracks.Padding = new System.Windows.Forms.Padding(3);
            this.tpTracks.Size = new System.Drawing.Size(300, 385);
            this.tpTracks.TabIndex = 2;
            this.tpTracks.Text = "Tracks";
            this.tpTracks.UseVisualStyleBackColor = true;
            // 
            // chkTracksAlbumArtistFill
            // 
            this.chkTracksAlbumArtistFill.AutoSize = true;
            this.chkTracksAlbumArtistFill.Location = new System.Drawing.Point(3, 26);
            this.chkTracksAlbumArtistFill.Name = "chkTracksAlbumArtistFill";
            this.chkTracksAlbumArtistFill.Size = new System.Drawing.Size(215, 17);
            this.chkTracksAlbumArtistFill.TabIndex = 1;
            this.chkTracksAlbumArtistFill.Text = "Fill missing Album Artist using best guess";
            this.chkTracksAlbumArtistFill.UseVisualStyleBackColor = true;
            // 
            // chkTracksGenreFill
            // 
            this.chkTracksGenreFill.AutoSize = true;
            this.chkTracksGenreFill.Location = new System.Drawing.Point(3, 3);
            this.chkTracksGenreFill.Name = "chkTracksGenreFill";
            this.chkTracksGenreFill.Size = new System.Drawing.Size(187, 17);
            this.chkTracksGenreFill.TabIndex = 0;
            this.chkTracksGenreFill.Text = "Fill missing genre using best guess";
            this.chkTracksGenreFill.UseVisualStyleBackColor = true;
            // 
            // tpFileSystem
            // 
            this.tpFileSystem.Controls.Add(this.flpFileSystem);
            this.tpFileSystem.Location = new System.Drawing.Point(4, 22);
            this.tpFileSystem.Name = "tpFileSystem";
            this.tpFileSystem.Size = new System.Drawing.Size(300, 385);
            this.tpFileSystem.TabIndex = 3;
            this.tpFileSystem.Text = "FileSystem";
            this.tpFileSystem.UseVisualStyleBackColor = true;
            // 
            // chkFileSystemExportArtworkFolderJpg
            // 
            this.chkFileSystemExportArtworkFolderJpg.AutoSize = true;
            this.chkFileSystemExportArtworkFolderJpg.Location = new System.Drawing.Point(3, 3);
            this.chkFileSystemExportArtworkFolderJpg.Name = "chkFileSystemExportArtworkFolderJpg";
            this.chkFileSystemExportArtworkFolderJpg.Size = new System.Drawing.Size(231, 17);
            this.chkFileSystemExportArtworkFolderJpg.TabIndex = 0;
            this.chkFileSystemExportArtworkFolderJpg.Text = "Export Artwork to Album folder as Folder.jpg";
            this.chkFileSystemExportArtworkFolderJpg.UseVisualStyleBackColor = true;
            // 
            // lbDiscs
            // 
            this.lbDiscs.AllowDrop = true;
            this.lbDiscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscs.FormattingEnabled = true;
            this.lbDiscs.Location = new System.Drawing.Point(631, 3);
            this.lbDiscs.Name = "lbDiscs";
            this.lbDiscs.Size = new System.Drawing.Size(310, 411);
            this.lbDiscs.Sorted = true;
            this.lbDiscs.TabIndex = 0;
            this.lbDiscs.SelectedIndexChanged += new System.EventHandler(this.lbDiscs_SelectedIndexChanged);
            this.lbDiscs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragDrop);
            this.lbDiscs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragEnter);
            this.lbDiscs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDiscs_MouseDown);
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
            this.tsmiTasksAddFiles,
            this.tsmiTasksValidate});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowsToolStripMenuItem.Text = "&Tasks";
            // 
            // tsmiTasksAddFiles
            // 
            this.tsmiTasksAddFiles.Name = "tsmiTasksAddFiles";
            this.tsmiTasksAddFiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiTasksAddFiles.Size = new System.Drawing.Size(173, 22);
            this.tsmiTasksAddFiles.Text = "&Add Files...";
            this.tsmiTasksAddFiles.Click += new System.EventHandler(this.miTasksAddFiles_Click);
            // 
            // tsmiTasksValidate
            // 
            this.tsmiTasksValidate.Name = "tsmiTasksValidate";
            this.tsmiTasksValidate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiTasksValidate.Size = new System.Drawing.Size(173, 22);
            this.tsmiTasksValidate.Text = "&Validate";
            this.tsmiTasksValidate.Click += new System.EventHandler(this.tsmiTasksValidate_Click);
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
            this.tvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLibrary.Location = new System.Drawing.Point(317, 3);
            this.tvLibrary.Name = "tvLibrary";
            this.tvLibrary.Size = new System.Drawing.Size(308, 411);
            this.tvLibrary.TabIndex = 2;
            this.tvLibrary.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLibrary_NodeMouseClick);
            this.tvLibrary.Click += new System.EventHandler(this.tvLibrary_Click);
            // 
            // tlpApp
            // 
            this.tlpApp.ColumnCount = 3;
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpApp.Controls.Add(this.tvLibrary, 1, 0);
            this.tlpApp.Controls.Add(this.tcValidator, 0, 0);
            this.tlpApp.Controls.Add(this.lbDiscs, 2, 0);
            this.tlpApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApp.Location = new System.Drawing.Point(0, 24);
            this.tlpApp.Name = "tlpApp";
            this.tlpApp.RowCount = 1;
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApp.Size = new System.Drawing.Size(944, 417);
            this.tlpApp.TabIndex = 3;
            // 
            // flpChecks
            // 
            this.flpChecks.Controls.Add(this.chkChecksMissingTags);
            this.flpChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChecks.Location = new System.Drawing.Point(3, 3);
            this.flpChecks.Name = "flpChecks";
            this.flpChecks.Size = new System.Drawing.Size(294, 379);
            this.flpChecks.TabIndex = 1;
            // 
            // flpTracks
            // 
            this.flpTracks.Controls.Add(this.chkTracksGenreFill);
            this.flpTracks.Controls.Add(this.chkTracksAlbumArtistFill);
            this.flpTracks.Controls.Add(this.chkFillMissingTrackCount);
            this.flpTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTracks.Location = new System.Drawing.Point(3, 3);
            this.flpTracks.Name = "flpTracks";
            this.flpTracks.Size = new System.Drawing.Size(294, 379);
            this.flpTracks.TabIndex = 2;
            // 
            // flpFileSystem
            // 
            this.flpFileSystem.Controls.Add(this.chkFileSystemExportArtworkFolderJpg);
            this.flpFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFileSystem.Location = new System.Drawing.Point(0, 0);
            this.flpFileSystem.Name = "flpFileSystem";
            this.flpFileSystem.Size = new System.Drawing.Size(300, 385);
            this.flpFileSystem.TabIndex = 1;
            // 
            // chkFillMissingTrackCount
            // 
            this.chkFillMissingTrackCount.AutoSize = true;
            this.chkFillMissingTrackCount.Location = new System.Drawing.Point(3, 49);
            this.chkFillMissingTrackCount.Name = "chkFillMissingTrackCount";
            this.chkFillMissingTrackCount.Size = new System.Drawing.Size(280, 17);
            this.chkFillMissingTrackCount.TabIndex = 2;
            this.chkFillMissingTrackCount.Text = "Fill missing Track Count, Disc Number and Disc Count";
            this.chkFillMissingTrackCount.UseVisualStyleBackColor = true;
            // 
            // ValidatorWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 441);
            this.Controls.Add(this.tlpApp);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "ValidatorWizard";
            this.Text = "iTSfv";
            this.Load += new System.EventHandler(this.ValidatorWizard_Load);
            this.Shown += new System.EventHandler(this.ValidatorWizard_Shown);
            this.Move += new System.EventHandler(this.ValidatorWizard_Move);
            this.Resize += new System.EventHandler(this.ValidatorWizard_Resize);
            this.tcValidator.ResumeLayout(false);
            this.tpChecks.ResumeLayout(false);
            this.tpTracks.ResumeLayout(false);
            this.tpFileSystem.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tlpApp.ResumeLayout(false);
            this.flpChecks.ResumeLayout(false);
            this.flpChecks.PerformLayout();
            this.flpTracks.ResumeLayout(false);
            this.flpTracks.PerformLayout();
            this.flpFileSystem.ResumeLayout(false);
            this.flpFileSystem.PerformLayout();
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
        private System.Windows.Forms.ListBox lbDiscs;
        private System.Windows.Forms.ToolTip ttApp;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.CheckBox chkChecksMissingTags;
        private System.Windows.Forms.CheckBox chkTracksAlbumArtistFill;
        private System.Windows.Forms.CheckBox chkFileSystemExportArtworkFolderJpg;
        private System.Windows.Forms.TreeView tvLibrary;
        private System.Windows.Forms.ToolStripMenuItem tsmiTasksValidate;
        private System.Windows.Forms.TableLayoutPanel tlpApp;
        private System.Windows.Forms.FlowLayoutPanel flpChecks;
        private System.Windows.Forms.FlowLayoutPanel flpTracks;
        private System.Windows.Forms.FlowLayoutPanel flpFileSystem;
        private System.Windows.Forms.CheckBox chkFillMissingTrackCount;
    }
}

