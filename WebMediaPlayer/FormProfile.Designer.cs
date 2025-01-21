namespace WebMediaPlayer
{
    partial class FormProfile
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
			this.panelRegisterForm = new System.Windows.Forms.Panel();
			this.pictureBoxPfp = new System.Windows.Forms.PictureBox();
			this.textBoxConfirmChangePswd = new System.Windows.Forms.TextBox();
			this.labelRegFormConfPswd = new System.Windows.Forms.Label();
			this.textBoxChangePassword = new System.Windows.Forms.TextBox();
			this.labelRegisterPswd = new System.Windows.Forms.Label();
			this.buttonUpdateProfile = new System.Windows.Forms.Button();
			this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
			this.textBoxChangeUsername = new System.Windows.Forms.TextBox();
			this.labelChngeOldPswd = new System.Windows.Forms.Label();
			this.labelRegisterFormUsrnm = new System.Windows.Forms.Label();
			this.labelTitleSeparator = new System.Windows.Forms.Label();
			this.buttonChangeImage = new System.Windows.Forms.Button();
			this.panelRegisterForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPfp)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRegisterForm
			// 
			this.panelRegisterForm.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelRegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.panelRegisterForm.Controls.Add(this.buttonChangeImage);
			this.panelRegisterForm.Controls.Add(this.pictureBoxPfp);
			this.panelRegisterForm.Controls.Add(this.textBoxConfirmChangePswd);
			this.panelRegisterForm.Controls.Add(this.labelRegFormConfPswd);
			this.panelRegisterForm.Controls.Add(this.textBoxChangePassword);
			this.panelRegisterForm.Controls.Add(this.labelRegisterPswd);
			this.panelRegisterForm.Controls.Add(this.buttonUpdateProfile);
			this.panelRegisterForm.Controls.Add(this.textBoxRegisterEmail);
			this.panelRegisterForm.Controls.Add(this.textBoxChangeUsername);
			this.panelRegisterForm.Controls.Add(this.labelChngeOldPswd);
			this.panelRegisterForm.Controls.Add(this.labelRegisterFormUsrnm);
			this.panelRegisterForm.Controls.Add(this.labelTitleSeparator);
			this.panelRegisterForm.ForeColor = System.Drawing.Color.White;
			this.panelRegisterForm.Location = new System.Drawing.Point(366, 68);
			this.panelRegisterForm.Name = "panelRegisterForm";
			this.panelRegisterForm.Size = new System.Drawing.Size(309, 485);
			this.panelRegisterForm.TabIndex = 3;
			// 
			// pictureBoxPfp
			// 
			this.pictureBoxPfp.Location = new System.Drawing.Point(103, 15);
			this.pictureBoxPfp.Name = "pictureBoxPfp";
			this.pictureBoxPfp.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxPfp.TabIndex = 15;
			this.pictureBoxPfp.TabStop = false;
			// 
			// textBoxConfirmChangePswd
			// 
			this.textBoxConfirmChangePswd.Location = new System.Drawing.Point(13, 362);
			this.textBoxConfirmChangePswd.Name = "textBoxConfirmChangePswd";
			this.textBoxConfirmChangePswd.PasswordChar = '*';
			this.textBoxConfirmChangePswd.Size = new System.Drawing.Size(285, 26);
			this.textBoxConfirmChangePswd.TabIndex = 14;
			// 
			// labelRegFormConfPswd
			// 
			this.labelRegFormConfPswd.AutoSize = true;
			this.labelRegFormConfPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegFormConfPswd.Location = new System.Drawing.Point(9, 338);
			this.labelRegFormConfPswd.Name = "labelRegFormConfPswd";
			this.labelRegFormConfPswd.Size = new System.Drawing.Size(183, 28);
			this.labelRegFormConfPswd.TabIndex = 13;
			this.labelRegFormConfPswd.Text = "Conferma Password";
			// 
			// textBoxChangePassword
			// 
			this.textBoxChangePassword.Location = new System.Drawing.Point(13, 295);
			this.textBoxChangePassword.Name = "textBoxChangePassword";
			this.textBoxChangePassword.PasswordChar = '*';
			this.textBoxChangePassword.Size = new System.Drawing.Size(285, 26);
			this.textBoxChangePassword.TabIndex = 12;
			// 
			// labelRegisterPswd
			// 
			this.labelRegisterPswd.AutoSize = true;
			this.labelRegisterPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegisterPswd.Location = new System.Drawing.Point(9, 271);
			this.labelRegisterPswd.Name = "labelRegisterPswd";
			this.labelRegisterPswd.Size = new System.Drawing.Size(93, 28);
			this.labelRegisterPswd.TabIndex = 11;
			this.labelRegisterPswd.Text = "Password";
			// 
			// buttonUpdateProfile
			// 
			this.buttonUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.buttonUpdateProfile.FlatAppearance.BorderSize = 0;
			this.buttonUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonUpdateProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdateProfile.ForeColor = System.Drawing.Color.White;
			this.buttonUpdateProfile.Location = new System.Drawing.Point(13, 424);
			this.buttonUpdateProfile.Name = "buttonUpdateProfile";
			this.buttonUpdateProfile.Size = new System.Drawing.Size(285, 39);
			this.buttonUpdateProfile.TabIndex = 9;
			this.buttonUpdateProfile.Text = "Aggiorna Profilo";
			this.buttonUpdateProfile.UseVisualStyleBackColor = false;
			this.buttonUpdateProfile.Click += new System.EventHandler(this.buttonUpdateProfile_Click);
			// 
			// textBoxRegisterEmail
			// 
			this.textBoxRegisterEmail.Location = new System.Drawing.Point(13, 230);
			this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
			this.textBoxRegisterEmail.PasswordChar = '*';
			this.textBoxRegisterEmail.Size = new System.Drawing.Size(285, 26);
			this.textBoxRegisterEmail.TabIndex = 8;
			// 
			// textBoxChangeUsername
			// 
			this.textBoxChangeUsername.Location = new System.Drawing.Point(13, 166);
			this.textBoxChangeUsername.Name = "textBoxChangeUsername";
			this.textBoxChangeUsername.Size = new System.Drawing.Size(285, 26);
			this.textBoxChangeUsername.TabIndex = 7;
			// 
			// labelChngeOldPswd
			// 
			this.labelChngeOldPswd.AutoSize = true;
			this.labelChngeOldPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelChngeOldPswd.Location = new System.Drawing.Point(9, 206);
			this.labelChngeOldPswd.Name = "labelChngeOldPswd";
			this.labelChngeOldPswd.Size = new System.Drawing.Size(163, 28);
			this.labelChngeOldPswd.TabIndex = 6;
			this.labelChngeOldPswd.Text = "Vecchia Password";
			// 
			// labelRegisterFormUsrnm
			// 
			this.labelRegisterFormUsrnm.AutoSize = true;
			this.labelRegisterFormUsrnm.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegisterFormUsrnm.Location = new System.Drawing.Point(9, 142);
			this.labelRegisterFormUsrnm.Name = "labelRegisterFormUsrnm";
			this.labelRegisterFormUsrnm.Size = new System.Drawing.Size(99, 28);
			this.labelRegisterFormUsrnm.TabIndex = 5;
			this.labelRegisterFormUsrnm.Text = "Username";
			// 
			// labelTitleSeparator
			// 
			this.labelTitleSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.labelTitleSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitleSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.labelTitleSeparator.Location = new System.Drawing.Point(13, 126);
			this.labelTitleSeparator.Name = "labelTitleSeparator";
			this.labelTitleSeparator.Size = new System.Drawing.Size(285, 2);
			this.labelTitleSeparator.TabIndex = 3;
			// 
			// buttonChangeImage
			// 
			this.buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.buttonChangeImage.FlatAppearance.BorderSize = 0;
			this.buttonChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonChangeImage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChangeImage.ForeColor = System.Drawing.Color.White;
			this.buttonChangeImage.Location = new System.Drawing.Point(103, 15);
			this.buttonChangeImage.Name = "buttonChangeImage";
			this.buttonChangeImage.Size = new System.Drawing.Size(100, 100);
			this.buttonChangeImage.TabIndex = 16;
			this.buttonChangeImage.Text = "Cambia Immagine";
			this.buttonChangeImage.UseVisualStyleBackColor = false;
			// 
			// FormProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1040, 624);
			this.Controls.Add(this.panelRegisterForm);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "FormProfile";
			this.Text = "FormProfile";
			this.panelRegisterForm.ResumeLayout(false);
			this.panelRegisterForm.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPfp)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegisterForm;
        private System.Windows.Forms.PictureBox pictureBoxPfp;
        private System.Windows.Forms.TextBox textBoxConfirmChangePswd;
        private System.Windows.Forms.Label labelRegFormConfPswd;
        private System.Windows.Forms.TextBox textBoxChangePassword;
        private System.Windows.Forms.Label labelRegisterPswd;
        private System.Windows.Forms.Button buttonUpdateProfile;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxChangeUsername;
        private System.Windows.Forms.Label labelChngeOldPswd;
        private System.Windows.Forms.Label labelRegisterFormUsrnm;
        private System.Windows.Forms.Label labelTitleSeparator;
		private System.Windows.Forms.Button buttonChangeImage;
	}
}