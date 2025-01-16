namespace WebMediaPlayer
{
    partial class Homepage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
			this.labelTitleSeparator = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonHome = new System.Windows.Forms.Button();
			this.buttonSrc = new System.Windows.Forms.Button();
			this.buttonUpload = new System.Windows.Forms.Button();
			this.buttonLibrary = new System.Windows.Forms.Button();
			this.buttonProfile = new System.Windows.Forms.Button();
			this.panelSidebar = new System.Windows.Forms.Panel();
			this.panelApp = new System.Windows.Forms.Panel();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.buttonViewProfile = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
			this.panelSidebar.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
			this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClose.Location = new System.Drawing.Point(0, 636);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonClose.Size = new System.Drawing.Size(167, 35);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Chiudi";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Controls.Add(this.pictureBoxTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(167, 175);
			this.panelTitle.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(13, 114);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(172, 28);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "WebMediaPlayer";
			// 
			// pictureBoxTitle
			// 
			this.pictureBoxTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.BackgroundImage")));
			this.pictureBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxTitle.Location = new System.Drawing.Point(9, 12);
			this.pictureBoxTitle.Name = "pictureBoxTitle";
			this.pictureBoxTitle.Size = new System.Drawing.Size(149, 91);
			this.pictureBoxTitle.TabIndex = 0;
			this.pictureBoxTitle.TabStop = false;
			// 
			// labelTitleSeparator
			// 
			this.labelTitleSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitleSeparator.Location = new System.Drawing.Point(0, 151);
			this.labelTitleSeparator.Name = "labelTitleSeparator";
			this.labelTitleSeparator.Size = new System.Drawing.Size(167, 2);
			this.labelTitleSeparator.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(0, 636);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 2);
			this.label1.TabIndex = 3;
			// 
			// buttonHome
			// 
			this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonHome.FlatAppearance.BorderSize = 0;
			this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
			this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonHome.Location = new System.Drawing.Point(0, 175);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(167, 35);
			this.buttonHome.TabIndex = 4;
			this.buttonHome.Text = "Home";
			this.buttonHome.UseVisualStyleBackColor = true;
			this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
			// 
			// buttonSrc
			// 
			this.buttonSrc.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonSrc.FlatAppearance.BorderSize = 0;
			this.buttonSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSrc.Image = ((System.Drawing.Image)(resources.GetObject("buttonSrc.Image")));
			this.buttonSrc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSrc.Location = new System.Drawing.Point(0, 210);
			this.buttonSrc.Name = "buttonSrc";
			this.buttonSrc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonSrc.Size = new System.Drawing.Size(167, 35);
			this.buttonSrc.TabIndex = 5;
			this.buttonSrc.Text = "Cerca";
			this.buttonSrc.UseVisualStyleBackColor = true;
			this.buttonSrc.Click += new System.EventHandler(this.buttonSrc_Click);
			// 
			// buttonUpload
			// 
			this.buttonUpload.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonUpload.FlatAppearance.BorderSize = 0;
			this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpload.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpload.Image")));
			this.buttonUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonUpload.Location = new System.Drawing.Point(0, 245);
			this.buttonUpload.Name = "buttonUpload";
			this.buttonUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonUpload.Size = new System.Drawing.Size(167, 35);
			this.buttonUpload.TabIndex = 6;
			this.buttonUpload.Text = "Carica brano";
			this.buttonUpload.UseVisualStyleBackColor = true;
			this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
			// 
			// buttonLibrary
			// 
			this.buttonLibrary.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonLibrary.FlatAppearance.BorderSize = 0;
			this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLibrary.Image = ((System.Drawing.Image)(resources.GetObject("buttonLibrary.Image")));
			this.buttonLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonLibrary.Location = new System.Drawing.Point(0, 280);
			this.buttonLibrary.Name = "buttonLibrary";
			this.buttonLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonLibrary.Size = new System.Drawing.Size(167, 35);
			this.buttonLibrary.TabIndex = 7;
			this.buttonLibrary.Text = "La tua libreria";
			this.buttonLibrary.UseVisualStyleBackColor = true;
			this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
			// 
			// buttonProfile
			// 
			this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonProfile.FlatAppearance.BorderSize = 0;
			this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
			this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonProfile.Location = new System.Drawing.Point(0, 601);
			this.buttonProfile.Name = "buttonProfile";
			this.buttonProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonProfile.Size = new System.Drawing.Size(167, 35);
			this.buttonProfile.TabIndex = 8;
			this.buttonProfile.Text = "Profilo";
			this.buttonProfile.UseVisualStyleBackColor = true;
			this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
			// 
			// panelSidebar
			// 
			this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.panelSidebar.Controls.Add(this.buttonViewProfile);
			this.panelSidebar.Controls.Add(this.buttonLogout);
			this.panelSidebar.Controls.Add(this.buttonProfile);
			this.panelSidebar.Controls.Add(this.buttonLibrary);
			this.panelSidebar.Controls.Add(this.buttonUpload);
			this.panelSidebar.Controls.Add(this.buttonSrc);
			this.panelSidebar.Controls.Add(this.buttonHome);
			this.panelSidebar.Controls.Add(this.label1);
			this.panelSidebar.Controls.Add(this.labelTitleSeparator);
			this.panelSidebar.Controls.Add(this.panelTitle);
			this.panelSidebar.Controls.Add(this.buttonClose);
			this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidebar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelSidebar.ForeColor = System.Drawing.Color.White;
			this.panelSidebar.Location = new System.Drawing.Point(0, 0);
			this.panelSidebar.Name = "panelSidebar";
			this.panelSidebar.Size = new System.Drawing.Size(167, 671);
			this.panelSidebar.TabIndex = 0;
			// 
			// panelApp
			// 
			this.panelApp.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelApp.Location = new System.Drawing.Point(167, 0);
			this.panelApp.Name = "panelApp";
			this.panelApp.Size = new System.Drawing.Size(1058, 671);
			this.panelApp.TabIndex = 1;
			// 
			// buttonLogout
			// 
			this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonLogout.FlatAppearance.BorderSize = 0;
			this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonLogout.Location = new System.Drawing.Point(0, 566);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonLogout.Size = new System.Drawing.Size(167, 35);
			this.buttonLogout.TabIndex = 9;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = false;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// buttonViewProfile
			// 
			this.buttonViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
			this.buttonViewProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonViewProfile.FlatAppearance.BorderSize = 0;
			this.buttonViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonViewProfile.Location = new System.Drawing.Point(0, 531);
			this.buttonViewProfile.Name = "buttonViewProfile";
			this.buttonViewProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonViewProfile.Size = new System.Drawing.Size(167, 35);
			this.buttonViewProfile.TabIndex = 10;
			this.buttonViewProfile.Text = "Profilo";
			this.buttonViewProfile.UseVisualStyleBackColor = false;
			this.buttonViewProfile.Click += new System.EventHandler(this.buttonViewProfile_Click);
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1225, 671);
			this.Controls.Add(this.panelApp);
			this.Controls.Add(this.panelSidebar);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1225, 671);
			this.MinimumSize = new System.Drawing.Size(1225, 671);
			this.Name = "Homepage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WebMediaPlayer";
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
			this.panelSidebar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Label labelTitleSeparator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonSrc;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelApp;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Button buttonViewProfile;
	}
}

