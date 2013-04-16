﻿namespace iTSfvGUI
{
    partial class AddFilesWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilesWizard));
            this.gbAlbumTags = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.chkGenre = new System.Windows.Forms.CheckBox();
            this.cboAlbumArtist = new System.Windows.Forms.ComboBox();
            this.chkAlbumArtist = new System.Windows.Forms.CheckBox();
            this.lblOf = new System.Windows.Forms.Label();
            this.chkDisc = new System.Windows.Forms.CheckBox();
            this.nudDiscCount = new System.Windows.Forms.NumericUpDown();
            this.nudDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.chkAlbum = new System.Windows.Forms.CheckBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.tvBands = new System.Windows.Forms.TreeView();
            this.gbAlbumTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlbumTags
            // 
            this.gbAlbumTags.Controls.Add(this.btnSave);
            this.gbAlbumTags.Controls.Add(this.cboGenre);
            this.gbAlbumTags.Controls.Add(this.nudYear);
            this.gbAlbumTags.Controls.Add(this.chkYear);
            this.gbAlbumTags.Controls.Add(this.chkGenre);
            this.gbAlbumTags.Controls.Add(this.cboAlbumArtist);
            this.gbAlbumTags.Controls.Add(this.chkAlbumArtist);
            this.gbAlbumTags.Controls.Add(this.lblOf);
            this.gbAlbumTags.Controls.Add(this.chkDisc);
            this.gbAlbumTags.Controls.Add(this.nudDiscCount);
            this.gbAlbumTags.Controls.Add(this.nudDiscNumber);
            this.gbAlbumTags.Controls.Add(this.chkAlbum);
            this.gbAlbumTags.Controls.Add(this.txtAlbum);
            this.gbAlbumTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlbumTags.Location = new System.Drawing.Point(16, 296);
            this.gbAlbumTags.Name = "gbAlbumTags";
            this.gbAlbumTags.Size = new System.Drawing.Size(456, 188);
            this.gbAlbumTags.TabIndex = 2;
            this.gbAlbumTags.TabStop = false;
            this.gbAlbumTags.Text = "Disc Tags";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(105, 96);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(337, 21);
            this.cboGenre.TabIndex = 7;
            // 
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Location = new System.Drawing.Point(105, 70);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(335, 20);
            this.nudYear.TabIndex = 5;
            this.nudYear.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Location = new System.Drawing.Point(10, 71);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(48, 17);
            this.chkYear.TabIndex = 4;
            this.chkYear.Text = "Year";
            this.chkYear.UseVisualStyleBackColor = true;
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Location = new System.Drawing.Point(10, 98);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(55, 17);
            this.chkGenre.TabIndex = 6;
            this.chkGenre.Text = "Genre";
            this.chkGenre.UseVisualStyleBackColor = true;
            // 
            // cboAlbumArtist
            // 
            this.cboAlbumArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlbumArtist.FormattingEnabled = true;
            this.cboAlbumArtist.ItemHeight = 13;
            this.cboAlbumArtist.Location = new System.Drawing.Point(105, 19);
            this.cboAlbumArtist.Name = "cboAlbumArtist";
            this.cboAlbumArtist.Size = new System.Drawing.Size(335, 21);
            this.cboAlbumArtist.Sorted = true;
            this.cboAlbumArtist.TabIndex = 1;
            // 
            // chkAlbumArtist
            // 
            this.chkAlbumArtist.AutoSize = true;
            this.chkAlbumArtist.Location = new System.Drawing.Point(9, 21);
            this.chkAlbumArtist.Name = "chkAlbumArtist";
            this.chkAlbumArtist.Size = new System.Drawing.Size(81, 17);
            this.chkAlbumArtist.TabIndex = 0;
            this.chkAlbumArtist.Text = "Album Artist";
            this.chkAlbumArtist.UseVisualStyleBackColor = true;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(171, 126);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(16, 13);
            this.lblOf.TabIndex = 10;
            this.lblOf.Text = "of";
            // 
            // chkDisc
            // 
            this.chkDisc.AutoSize = true;
            this.chkDisc.Location = new System.Drawing.Point(9, 124);
            this.chkDisc.Name = "chkDisc";
            this.chkDisc.Size = new System.Drawing.Size(47, 17);
            this.chkDisc.TabIndex = 8;
            this.chkDisc.Text = "Disc";
            this.chkDisc.UseVisualStyleBackColor = true;
            // 
            // nudDiscCount
            // 
            this.nudDiscCount.Location = new System.Drawing.Point(193, 123);
            this.nudDiscCount.Name = "nudDiscCount";
            this.nudDiscCount.ReadOnly = true;
            this.nudDiscCount.Size = new System.Drawing.Size(60, 20);
            this.nudDiscCount.TabIndex = 11;
            this.nudDiscCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiscNumber
            // 
            this.nudDiscNumber.Location = new System.Drawing.Point(105, 123);
            this.nudDiscNumber.Name = "nudDiscNumber";
            this.nudDiscNumber.ReadOnly = true;
            this.nudDiscNumber.Size = new System.Drawing.Size(60, 20);
            this.nudDiscNumber.TabIndex = 9;
            this.nudDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Location = new System.Drawing.Point(9, 46);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(55, 17);
            this.chkAlbum.TabIndex = 2;
            this.chkAlbum.Text = "Album";
            this.chkAlbum.UseVisualStyleBackColor = true;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.Location = new System.Drawing.Point(105, 44);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(335, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // lbPaths
            // 
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(8, 176);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(464, 108);
            this.lbPaths.TabIndex = 1;
            // 
            // tvBands
            // 
            this.tvBands.Location = new System.Drawing.Point(8, 8);
            this.tvBands.Name = "tvBands";
            this.tvBands.Size = new System.Drawing.Size(464, 160);
            this.tvBands.TabIndex = 0;
            this.tvBands.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvBands_NodeMouseClick);
            // 
            // AddFilesWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 497);
            this.Controls.Add(this.tvBands);
            this.Controls.Add(this.lbPaths);
            this.Controls.Add(this.gbAlbumTags);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFilesWizard";
            this.Text = "AddFilesWizard";
            this.Load += new System.EventHandler(this.AddFilesWizard_Load);
            this.gbAlbumTags.ResumeLayout(false);
            this.gbAlbumTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbAlbumTags;
        internal System.Windows.Forms.ComboBox cboGenre;
        internal System.Windows.Forms.NumericUpDown nudYear;
        internal System.Windows.Forms.CheckBox chkYear;
        internal System.Windows.Forms.CheckBox chkGenre;
        internal System.Windows.Forms.ComboBox cboAlbumArtist;
        internal System.Windows.Forms.CheckBox chkAlbumArtist;
        internal System.Windows.Forms.Label lblOf;
        internal System.Windows.Forms.CheckBox chkDisc;
        internal System.Windows.Forms.NumericUpDown nudDiscCount;
        internal System.Windows.Forms.NumericUpDown nudDiscNumber;
        internal System.Windows.Forms.CheckBox chkAlbum;
        internal System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.TreeView tvBands;
        private System.Windows.Forms.Button btnSave;
    }
}