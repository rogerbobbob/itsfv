namespace iTSfvGUI
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
            this.gbAlbumTags = new System.Windows.Forms.GroupBox();
            this.cboArtist = new System.Windows.Forms.ComboBox();
            this.chkArtist = new System.Windows.Forms.CheckBox();
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
            this.gbAlbumTags.Controls.Add(this.cboArtist);
            this.gbAlbumTags.Controls.Add(this.chkArtist);
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
            // cboArtist
            // 
            this.cboArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboArtist.FormattingEnabled = true;
            this.cboArtist.ItemHeight = 13;
            this.cboArtist.Location = new System.Drawing.Point(105, 46);
            this.cboArtist.Name = "cboArtist";
            this.cboArtist.Size = new System.Drawing.Size(335, 21);
            this.cboArtist.Sorted = true;
            this.cboArtist.TabIndex = 3;
            // 
            // chkArtist
            // 
            this.chkArtist.AutoSize = true;
            this.chkArtist.Location = new System.Drawing.Point(9, 48);
            this.chkArtist.Name = "chkArtist";
            this.chkArtist.Size = new System.Drawing.Size(49, 17);
            this.chkArtist.TabIndex = 2;
            this.chkArtist.Text = "Artist";
            this.chkArtist.UseVisualStyleBackColor = true;
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(105, 125);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(337, 21);
            this.cboGenre.TabIndex = 9;
            // 
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Location = new System.Drawing.Point(105, 99);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(335, 20);
            this.nudYear.TabIndex = 7;
            this.nudYear.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Location = new System.Drawing.Point(10, 100);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(48, 17);
            this.chkYear.TabIndex = 6;
            this.chkYear.Text = "Year";
            this.chkYear.UseVisualStyleBackColor = true;
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Location = new System.Drawing.Point(10, 127);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(55, 17);
            this.chkGenre.TabIndex = 8;
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
            this.lblOf.Location = new System.Drawing.Point(171, 155);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(16, 13);
            this.lblOf.TabIndex = 12;
            this.lblOf.Text = "of";
            // 
            // chkDisc
            // 
            this.chkDisc.AutoSize = true;
            this.chkDisc.Location = new System.Drawing.Point(9, 153);
            this.chkDisc.Name = "chkDisc";
            this.chkDisc.Size = new System.Drawing.Size(47, 17);
            this.chkDisc.TabIndex = 10;
            this.chkDisc.Text = "Disc";
            this.chkDisc.UseVisualStyleBackColor = true;
            // 
            // nudDiscCount
            // 
            this.nudDiscCount.Location = new System.Drawing.Point(193, 152);
            this.nudDiscCount.Name = "nudDiscCount";
            this.nudDiscCount.ReadOnly = true;
            this.nudDiscCount.Size = new System.Drawing.Size(60, 20);
            this.nudDiscCount.TabIndex = 13;
            this.nudDiscCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiscNumber
            // 
            this.nudDiscNumber.Location = new System.Drawing.Point(105, 152);
            this.nudDiscNumber.Name = "nudDiscNumber";
            this.nudDiscNumber.ReadOnly = true;
            this.nudDiscNumber.Size = new System.Drawing.Size(60, 20);
            this.nudDiscNumber.TabIndex = 11;
            this.nudDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Location = new System.Drawing.Point(9, 75);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(55, 17);
            this.chkAlbum.TabIndex = 4;
            this.chkAlbum.Text = "Album";
            this.chkAlbum.UseVisualStyleBackColor = true;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.Location = new System.Drawing.Point(105, 73);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(335, 20);
            this.txtAlbum.TabIndex = 5;
            // 
            // lbPaths
            // 
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.Location = new System.Drawing.Point(16, 184);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(456, 95);
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
        internal System.Windows.Forms.ComboBox cboArtist;
        internal System.Windows.Forms.CheckBox chkArtist;
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
    }
}