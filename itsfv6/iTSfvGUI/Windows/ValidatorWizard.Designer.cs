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
            this.tcValidator = new System.Windows.Forms.TabControl();
            this.tpChecks = new System.Windows.Forms.TabPage();
            this.tpTracks = new System.Windows.Forms.TabPage();
            this.chkTracksGenreFill = new System.Windows.Forms.CheckBox();
            this.tpFileSystem = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miTasksAddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tpDiscs = new System.Windows.Forms.TabPage();
            this.lbDiscs = new System.Windows.Forms.ListBox();
            this.tcValidator.SuspendLayout();
            this.tpTracks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tpDiscs.SuspendLayout();
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
            this.tcValidator.Location = new System.Drawing.Point(8, 32);
            this.tcValidator.Name = "tcValidator";
            this.tcValidator.SelectedIndex = 0;
            this.tcValidator.Size = new System.Drawing.Size(772, 323);
            this.tcValidator.TabIndex = 1;
            // 
            // tpChecks
            // 
            this.tpChecks.Location = new System.Drawing.Point(4, 22);
            this.tpChecks.Name = "tpChecks";
            this.tpChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tpChecks.Size = new System.Drawing.Size(764, 297);
            this.tpChecks.TabIndex = 1;
            this.tpChecks.Text = "Checks";
            this.tpChecks.UseVisualStyleBackColor = true;
            // 
            // tpTracks
            // 
            this.tpTracks.Controls.Add(this.chkTracksGenreFill);
            this.tpTracks.Location = new System.Drawing.Point(4, 22);
            this.tpTracks.Name = "tpTracks";
            this.tpTracks.Padding = new System.Windows.Forms.Padding(3);
            this.tpTracks.Size = new System.Drawing.Size(764, 297);
            this.tpTracks.TabIndex = 2;
            this.tpTracks.Text = "Tracks";
            this.tpTracks.UseVisualStyleBackColor = true;
            // 
            // chkTracksGenreFill
            // 
            this.chkTracksGenreFill.AutoSize = true;
            this.chkTracksGenreFill.Location = new System.Drawing.Point(8, 8);
            this.chkTracksGenreFill.Name = "chkTracksGenreFill";
            this.chkTracksGenreFill.Size = new System.Drawing.Size(105, 17);
            this.chkTracksGenreFill.TabIndex = 0;
            this.chkTracksGenreFill.Text = "Fill missing genre";
            this.chkTracksGenreFill.UseVisualStyleBackColor = true;
            // 
            // tpFileSystem
            // 
            this.tpFileSystem.Location = new System.Drawing.Point(4, 22);
            this.tpFileSystem.Name = "tpFileSystem";
            this.tpFileSystem.Size = new System.Drawing.Size(764, 297);
            this.tpFileSystem.TabIndex = 3;
            this.tpFileSystem.Text = "FileSystem";
            this.tpFileSystem.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTasksAddFiles});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.windowsToolStripMenuItem.Text = "&Tasks";
            // 
            // miTasksAddFiles
            // 
            this.miTasksAddFiles.Name = "miTasksAddFiles";
            this.miTasksAddFiles.Size = new System.Drawing.Size(152, 22);
            this.miTasksAddFiles.Text = "&Add Files...";
            this.miTasksAddFiles.Click += new System.EventHandler(this.miTasksAddFiles_Click);
            // 
            // tpDiscs
            // 
            this.tpDiscs.Controls.Add(this.lbDiscs);
            this.tpDiscs.Location = new System.Drawing.Point(4, 22);
            this.tpDiscs.Name = "tpDiscs";
            this.tpDiscs.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiscs.Size = new System.Drawing.Size(764, 297);
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
            this.lbDiscs.Size = new System.Drawing.Size(758, 291);
            this.lbDiscs.TabIndex = 0;
            this.lbDiscs.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragDrop);
            this.lbDiscs.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDiscs_DragEnter);
            // 
            // ValidatorWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.tcValidator);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ValidatorWizard";
            this.Text = "iTSfv";
            this.Load += new System.EventHandler(this.ValidatorWizard_Load);
            this.Shown += new System.EventHandler(this.ValidatorWizard_Shown);
            this.Move += new System.EventHandler(this.ValidatorWizard_Move);
            this.tcValidator.ResumeLayout(false);
            this.tpTracks.ResumeLayout(false);
            this.tpTracks.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpDiscs.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem miTasksAddFiles;
        private System.Windows.Forms.CheckBox chkTracksGenreFill;
        private System.Windows.Forms.TabPage tpDiscs;
        private System.Windows.Forms.ListBox lbDiscs;
    }
}

