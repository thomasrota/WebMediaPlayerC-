namespace WebMediaPlayer
{
	partial class FormUpload
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
            this.labelTitleUpload = new System.Windows.Forms.Label();
            this.labelFileSel = new System.Windows.Forms.Label();
            this.labelImgAlbumSel = new System.Windows.Forms.Label();
            this.buttonUploadFiles = new System.Windows.Forms.Button();
            this.panelConfirmUpload = new System.Windows.Forms.Panel();
            this.textBoxConfirmAlbum = new System.Windows.Forms.TextBox();
            this.textBoxConfirmArtist = new System.Windows.Forms.TextBox();
            this.textBoxConfirmTitle = new System.Windows.Forms.TextBox();
            this.labelConfirmYear = new System.Windows.Forms.Label();
            this.labelConfirmAlbum = new System.Windows.Forms.Label();
            this.labelConfirmArtist = new System.Windows.Forms.Label();
            this.labelConfirmTitle = new System.Windows.Forms.Label();
            this.buttonConfirmUpload = new System.Windows.Forms.Button();
            this.textBoxConfirmYear = new System.Windows.Forms.TextBox();
            this.panelConfirmUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleUpload
            // 
            this.labelTitleUpload.AutoSize = true;
            this.labelTitleUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleUpload.Location = new System.Drawing.Point(27, 26);
            this.labelTitleUpload.Name = "labelTitleUpload";
            this.labelTitleUpload.Size = new System.Drawing.Size(168, 21);
            this.labelTitleUpload.TabIndex = 0;
            this.labelTitleUpload.Text = "Carica un nuovo brano";
            // 
            // labelFileSel
            // 
            this.labelFileSel.AutoSize = true;
            this.labelFileSel.Location = new System.Drawing.Point(31, 78);
            this.labelFileSel.Name = "labelFileSel";
            this.labelFileSel.Size = new System.Drawing.Size(78, 13);
            this.labelFileSel.TabIndex = 1;
            this.labelFileSel.Text = "File del brano";
            // 
            // labelImgAlbumSel
            // 
            this.labelImgAlbumSel.AutoSize = true;
            this.labelImgAlbumSel.Location = new System.Drawing.Point(34, 142);
            this.labelImgAlbumSel.Name = "labelImgAlbumSel";
            this.labelImgAlbumSel.Size = new System.Drawing.Size(174, 13);
            this.labelImgAlbumSel.TabIndex = 2;
            this.labelImgAlbumSel.Text = "Immagine dell\'album (opzionale)";
            // 
            // buttonUploadFiles
            // 
            this.buttonUploadFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.buttonUploadFiles.FlatAppearance.BorderSize = 0;
            this.buttonUploadFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUploadFiles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUploadFiles.ForeColor = System.Drawing.Color.White;
            this.buttonUploadFiles.Location = new System.Drawing.Point(37, 207);
            this.buttonUploadFiles.Name = "buttonUploadFiles";
            this.buttonUploadFiles.Size = new System.Drawing.Size(82, 29);
            this.buttonUploadFiles.TabIndex = 10;
            this.buttonUploadFiles.Text = "Carica";
            this.buttonUploadFiles.UseVisualStyleBackColor = false;
            // 
            // panelConfirmUpload
            // 
            this.panelConfirmUpload.Controls.Add(this.textBoxConfirmYear);
            this.panelConfirmUpload.Controls.Add(this.textBoxConfirmAlbum);
            this.panelConfirmUpload.Controls.Add(this.textBoxConfirmArtist);
            this.panelConfirmUpload.Controls.Add(this.textBoxConfirmTitle);
            this.panelConfirmUpload.Controls.Add(this.labelConfirmYear);
            this.panelConfirmUpload.Controls.Add(this.labelConfirmAlbum);
            this.panelConfirmUpload.Controls.Add(this.labelConfirmArtist);
            this.panelConfirmUpload.Controls.Add(this.labelConfirmTitle);
            this.panelConfirmUpload.Location = new System.Drawing.Point(37, 244);
            this.panelConfirmUpload.Name = "panelConfirmUpload";
            this.panelConfirmUpload.Size = new System.Drawing.Size(480, 368);
            this.panelConfirmUpload.TabIndex = 11;
            // 
            // textBoxConfirmAlbum
            // 
            this.textBoxConfirmAlbum.Location = new System.Drawing.Point(0, 191);
            this.textBoxConfirmAlbum.Name = "textBoxConfirmAlbum";
            this.textBoxConfirmAlbum.Size = new System.Drawing.Size(171, 21);
            this.textBoxConfirmAlbum.TabIndex = 6;
            // 
            // textBoxConfirmArtist
            // 
            this.textBoxConfirmArtist.Location = new System.Drawing.Point(0, 114);
            this.textBoxConfirmArtist.Name = "textBoxConfirmArtist";
            this.textBoxConfirmArtist.Size = new System.Drawing.Size(171, 21);
            this.textBoxConfirmArtist.TabIndex = 5;
            // 
            // textBoxConfirmTitle
            // 
            this.textBoxConfirmTitle.Location = new System.Drawing.Point(0, 42);
            this.textBoxConfirmTitle.Name = "textBoxConfirmTitle";
            this.textBoxConfirmTitle.Size = new System.Drawing.Size(171, 21);
            this.textBoxConfirmTitle.TabIndex = 4;
            // 
            // labelConfirmYear
            // 
            this.labelConfirmYear.AutoSize = true;
            this.labelConfirmYear.Location = new System.Drawing.Point(-3, 250);
            this.labelConfirmYear.Name = "labelConfirmYear";
            this.labelConfirmYear.Size = new System.Drawing.Size(35, 13);
            this.labelConfirmYear.TabIndex = 3;
            this.labelConfirmYear.Text = "Anno";
            // 
            // labelConfirmAlbum
            // 
            this.labelConfirmAlbum.AutoSize = true;
            this.labelConfirmAlbum.Location = new System.Drawing.Point(-3, 175);
            this.labelConfirmAlbum.Name = "labelConfirmAlbum";
            this.labelConfirmAlbum.Size = new System.Drawing.Size(40, 13);
            this.labelConfirmAlbum.TabIndex = 2;
            this.labelConfirmAlbum.Text = "Album";
            // 
            // labelConfirmArtist
            // 
            this.labelConfirmArtist.AutoSize = true;
            this.labelConfirmArtist.Location = new System.Drawing.Point(-3, 98);
            this.labelConfirmArtist.Name = "labelConfirmArtist";
            this.labelConfirmArtist.Size = new System.Drawing.Size(40, 13);
            this.labelConfirmArtist.TabIndex = 1;
            this.labelConfirmArtist.Text = "Artista";
            // 
            // labelConfirmTitle
            // 
            this.labelConfirmTitle.AutoSize = true;
            this.labelConfirmTitle.Location = new System.Drawing.Point(-3, 26);
            this.labelConfirmTitle.Name = "labelConfirmTitle";
            this.labelConfirmTitle.Size = new System.Drawing.Size(90, 13);
            this.labelConfirmTitle.TabIndex = 0;
            this.labelConfirmTitle.Text = "Titolo del brano";
            // 
            // buttonConfirmUpload
            // 
            this.buttonConfirmUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.buttonConfirmUpload.FlatAppearance.BorderSize = 0;
            this.buttonConfirmUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmUpload.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmUpload.Location = new System.Drawing.Point(37, 560);
            this.buttonConfirmUpload.Name = "buttonConfirmUpload";
            this.buttonConfirmUpload.Size = new System.Drawing.Size(82, 29);
            this.buttonConfirmUpload.TabIndex = 12;
            this.buttonConfirmUpload.Text = "Conferma";
            this.buttonConfirmUpload.UseVisualStyleBackColor = false;
            // 
            // textBoxConfirmYear
            // 
            this.textBoxConfirmYear.Location = new System.Drawing.Point(0, 266);
            this.textBoxConfirmYear.Name = "textBoxConfirmYear";
            this.textBoxConfirmYear.Size = new System.Drawing.Size(171, 21);
            this.textBoxConfirmYear.TabIndex = 7;
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1040, 624);
            this.Controls.Add(this.buttonConfirmUpload);
            this.Controls.Add(this.panelConfirmUpload);
            this.Controls.Add(this.buttonUploadFiles);
            this.Controls.Add(this.labelImgAlbumSel);
            this.Controls.Add(this.labelFileSel);
            this.Controls.Add(this.labelTitleUpload);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormUpload";
            this.Text = "FormUpload";
            this.panelConfirmUpload.ResumeLayout(false);
            this.panelConfirmUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label labelTitleUpload;
        private System.Windows.Forms.Label labelFileSel;
        private System.Windows.Forms.Label labelImgAlbumSel;
        private System.Windows.Forms.Button buttonUploadFiles;
        private System.Windows.Forms.Panel panelConfirmUpload;
        private System.Windows.Forms.Label labelConfirmTitle;
        private System.Windows.Forms.Button buttonConfirmUpload;
        private System.Windows.Forms.TextBox textBoxConfirmAlbum;
        private System.Windows.Forms.TextBox textBoxConfirmArtist;
        private System.Windows.Forms.TextBox textBoxConfirmTitle;
        private System.Windows.Forms.Label labelConfirmYear;
        private System.Windows.Forms.Label labelConfirmAlbum;
        private System.Windows.Forms.Label labelConfirmArtist;
        private System.Windows.Forms.TextBox textBoxConfirmYear;
    }
}