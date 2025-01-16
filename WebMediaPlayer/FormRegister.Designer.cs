namespace WebMediaPlayer
{
    partial class FormRegister
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
			this.textBoxRegConfirmPswd = new System.Windows.Forms.TextBox();
			this.labelRegFormConfPswd = new System.Windows.Forms.Label();
			this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
			this.labelRegisterPswd = new System.Windows.Forms.Label();
			this.buttonGoToLogin = new System.Windows.Forms.Button();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
			this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
			this.labelRegisterFormPswd = new System.Windows.Forms.Label();
			this.labelRegisterFormUsrnm = new System.Windows.Forms.Label();
			this.labelRegisterFormTitle = new System.Windows.Forms.Label();
			this.labelTitleSeparator = new System.Windows.Forms.Label();
			this.panelRegisterForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelRegisterForm
			// 
			this.panelRegisterForm.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panelRegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.panelRegisterForm.Controls.Add(this.textBoxRegConfirmPswd);
			this.panelRegisterForm.Controls.Add(this.labelRegFormConfPswd);
			this.panelRegisterForm.Controls.Add(this.textBoxRegisterPassword);
			this.panelRegisterForm.Controls.Add(this.labelRegisterPswd);
			this.panelRegisterForm.Controls.Add(this.buttonGoToLogin);
			this.panelRegisterForm.Controls.Add(this.buttonRegister);
			this.panelRegisterForm.Controls.Add(this.textBoxRegisterEmail);
			this.panelRegisterForm.Controls.Add(this.textBoxRegisterUsername);
			this.panelRegisterForm.Controls.Add(this.labelRegisterFormPswd);
			this.panelRegisterForm.Controls.Add(this.labelRegisterFormUsrnm);
			this.panelRegisterForm.Controls.Add(this.labelRegisterFormTitle);
			this.panelRegisterForm.Controls.Add(this.labelTitleSeparator);
			this.panelRegisterForm.ForeColor = System.Drawing.Color.White;
			this.panelRegisterForm.Location = new System.Drawing.Point(367, 92);
			this.panelRegisterForm.Name = "panelRegisterForm";
			this.panelRegisterForm.Size = new System.Drawing.Size(309, 455);
			this.panelRegisterForm.TabIndex = 2;
			// 
			// textBoxRegConfirmPswd
			// 
			this.textBoxRegConfirmPswd.Location = new System.Drawing.Point(13, 318);
			this.textBoxRegConfirmPswd.Name = "textBoxRegConfirmPswd";
			this.textBoxRegConfirmPswd.PasswordChar = '*';
			this.textBoxRegConfirmPswd.Size = new System.Drawing.Size(285, 26);
			this.textBoxRegConfirmPswd.TabIndex = 14;
			// 
			// labelRegFormConfPswd
			// 
			this.labelRegFormConfPswd.AutoSize = true;
			this.labelRegFormConfPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegFormConfPswd.Location = new System.Drawing.Point(9, 294);
			this.labelRegFormConfPswd.Name = "labelRegFormConfPswd";
			this.labelRegFormConfPswd.Size = new System.Drawing.Size(183, 28);
			this.labelRegFormConfPswd.TabIndex = 13;
			this.labelRegFormConfPswd.Text = "Conferma Password";
			// 
			// textBoxRegisterPassword
			// 
			this.textBoxRegisterPassword.Location = new System.Drawing.Point(13, 251);
			this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
			this.textBoxRegisterPassword.PasswordChar = '*';
			this.textBoxRegisterPassword.Size = new System.Drawing.Size(285, 26);
			this.textBoxRegisterPassword.TabIndex = 12;
			// 
			// labelRegisterPswd
			// 
			this.labelRegisterPswd.AutoSize = true;
			this.labelRegisterPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegisterPswd.Location = new System.Drawing.Point(9, 227);
			this.labelRegisterPswd.Name = "labelRegisterPswd";
			this.labelRegisterPswd.Size = new System.Drawing.Size(93, 28);
			this.labelRegisterPswd.TabIndex = 11;
			this.labelRegisterPswd.Text = "Password";
			// 
			// buttonGoToLogin
			// 
			this.buttonGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGoToLogin.FlatAppearance.BorderSize = 0;
			this.buttonGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGoToLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
			this.buttonGoToLogin.Location = new System.Drawing.Point(13, 417);
			this.buttonGoToLogin.Name = "buttonGoToLogin";
			this.buttonGoToLogin.Size = new System.Drawing.Size(285, 23);
			this.buttonGoToLogin.TabIndex = 10;
			this.buttonGoToLogin.Text = "Hai già un account? Accedi";
			this.buttonGoToLogin.UseVisualStyleBackColor = true;
			this.buttonGoToLogin.Click += new System.EventHandler(this.buttonGoToLogin_Click);
			// 
			// buttonRegister
			// 
			this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.buttonRegister.FlatAppearance.BorderSize = 0;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.ForeColor = System.Drawing.Color.White;
			this.buttonRegister.Location = new System.Drawing.Point(13, 371);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(285, 39);
			this.buttonRegister.TabIndex = 9;
			this.buttonRegister.Text = "Registrati";
			this.buttonRegister.UseVisualStyleBackColor = false;
			this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
			// 
			// textBoxRegisterEmail
			// 
			this.textBoxRegisterEmail.Location = new System.Drawing.Point(13, 186);
			this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
			this.textBoxRegisterEmail.Size = new System.Drawing.Size(285, 26);
			this.textBoxRegisterEmail.TabIndex = 8;
			// 
			// textBoxRegisterUsername
			// 
			this.textBoxRegisterUsername.Location = new System.Drawing.Point(13, 122);
			this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
			this.textBoxRegisterUsername.Size = new System.Drawing.Size(285, 26);
			this.textBoxRegisterUsername.TabIndex = 7;
			// 
			// labelRegisterFormPswd
			// 
			this.labelRegisterFormPswd.AutoSize = true;
			this.labelRegisterFormPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegisterFormPswd.Location = new System.Drawing.Point(9, 162);
			this.labelRegisterFormPswd.Name = "labelRegisterFormPswd";
			this.labelRegisterFormPswd.Size = new System.Drawing.Size(59, 28);
			this.labelRegisterFormPswd.TabIndex = 6;
			this.labelRegisterFormPswd.Text = "Email";
			// 
			// labelRegisterFormUsrnm
			// 
			this.labelRegisterFormUsrnm.AutoSize = true;
			this.labelRegisterFormUsrnm.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.labelRegisterFormUsrnm.Location = new System.Drawing.Point(9, 98);
			this.labelRegisterFormUsrnm.Name = "labelRegisterFormUsrnm";
			this.labelRegisterFormUsrnm.Size = new System.Drawing.Size(99, 28);
			this.labelRegisterFormUsrnm.TabIndex = 5;
			this.labelRegisterFormUsrnm.Text = "Username";
			// 
			// labelRegisterFormTitle
			// 
			this.labelRegisterFormTitle.AutoSize = true;
			this.labelRegisterFormTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegisterFormTitle.Location = new System.Drawing.Point(91, 18);
			this.labelRegisterFormTitle.Name = "labelRegisterFormTitle";
			this.labelRegisterFormTitle.Size = new System.Drawing.Size(173, 46);
			this.labelRegisterFormTitle.TabIndex = 4;
			this.labelRegisterFormTitle.Text = "Registrati";
			// 
			// labelTitleSeparator
			// 
			this.labelTitleSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.labelTitleSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitleSeparator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.labelTitleSeparator.Location = new System.Drawing.Point(13, 68);
			this.labelTitleSeparator.Name = "labelTitleSeparator";
			this.labelTitleSeparator.Size = new System.Drawing.Size(285, 2);
			this.labelTitleSeparator.TabIndex = 3;
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1042, 632);
			this.Controls.Add(this.panelRegisterForm);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormRegister";
			this.Text = "FormRegister";
			this.panelRegisterForm.ResumeLayout(false);
			this.panelRegisterForm.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRegisterForm;
        private System.Windows.Forms.Button buttonGoToLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterUsername;
        private System.Windows.Forms.Label labelRegisterFormPswd;
        private System.Windows.Forms.Label labelRegisterFormUsrnm;
        private System.Windows.Forms.Label labelRegisterFormTitle;
        private System.Windows.Forms.Label labelTitleSeparator;
        private System.Windows.Forms.TextBox textBoxRegConfirmPswd;
        private System.Windows.Forms.Label labelRegFormConfPswd;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label labelRegisterPswd;
    }
}