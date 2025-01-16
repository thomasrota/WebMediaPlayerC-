namespace WebMediaPlayer
{
    partial class FormLogin
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
            this.panelLoginForm = new System.Windows.Forms.Panel();
            this.buttonGoToRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPswd = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelLoginFormPswd = new System.Windows.Forms.Label();
            this.labelLoginFormUsrnm = new System.Windows.Forms.Label();
            this.labelLoginFormTitle = new System.Windows.Forms.Label();
            this.labelTitleSeparator = new System.Windows.Forms.Label();
            this.panelLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoginForm
            // 
            this.panelLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelLoginForm.Controls.Add(this.buttonGoToRegister);
            this.panelLoginForm.Controls.Add(this.buttonLogin);
            this.panelLoginForm.Controls.Add(this.textBoxPswd);
            this.panelLoginForm.Controls.Add(this.textBoxUsername);
            this.panelLoginForm.Controls.Add(this.labelLoginFormPswd);
            this.panelLoginForm.Controls.Add(this.labelLoginFormUsrnm);
            this.panelLoginForm.Controls.Add(this.labelLoginFormTitle);
            this.panelLoginForm.Controls.Add(this.labelTitleSeparator);
            this.panelLoginForm.ForeColor = System.Drawing.Color.White;
            this.panelLoginForm.Location = new System.Drawing.Point(363, 138);
            this.panelLoginForm.Name = "panelLoginForm";
            this.panelLoginForm.Size = new System.Drawing.Size(309, 347);
            this.panelLoginForm.TabIndex = 0;
            // 
            // buttonGoToRegister
            // 
            this.buttonGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToRegister.FlatAppearance.BorderSize = 0;
            this.buttonGoToRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            this.buttonGoToRegister.Location = new System.Drawing.Point(13, 305);
            this.buttonGoToRegister.Name = "buttonGoToRegister";
            this.buttonGoToRegister.Size = new System.Drawing.Size(285, 23);
            this.buttonGoToRegister.TabIndex = 10;
            this.buttonGoToRegister.Text = "Non hai un account? Registrati";
            this.buttonGoToRegister.UseVisualStyleBackColor = true;
            this.buttonGoToRegister.Click += new System.EventHandler(this.buttonGoToRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(13, 259);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(285, 39);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Accedi";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPswd
            // 
            this.textBoxPswd.Location = new System.Drawing.Point(13, 207);
            this.textBoxPswd.Name = "textBoxPswd";
            this.textBoxPswd.PasswordChar = '*';
            this.textBoxPswd.Size = new System.Drawing.Size(285, 22);
            this.textBoxPswd.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(13, 130);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(285, 22);
            this.textBoxUsername.TabIndex = 7;
            // 
            // labelLoginFormPswd
            // 
            this.labelLoginFormPswd.AutoSize = true;
            this.labelLoginFormPswd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLoginFormPswd.Location = new System.Drawing.Point(9, 183);
            this.labelLoginFormPswd.Name = "labelLoginFormPswd";
            this.labelLoginFormPswd.Size = new System.Drawing.Size(76, 21);
            this.labelLoginFormPswd.TabIndex = 6;
            this.labelLoginFormPswd.Text = "Password";
            // 
            // labelLoginFormUsrnm
            // 
            this.labelLoginFormUsrnm.AutoSize = true;
            this.labelLoginFormUsrnm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelLoginFormUsrnm.Location = new System.Drawing.Point(9, 106);
            this.labelLoginFormUsrnm.Name = "labelLoginFormUsrnm";
            this.labelLoginFormUsrnm.Size = new System.Drawing.Size(136, 21);
            this.labelLoginFormUsrnm.TabIndex = 5;
            this.labelLoginFormUsrnm.Text = "Username o Email";
            // 
            // labelLoginFormTitle
            // 
            this.labelLoginFormTitle.AutoSize = true;
            this.labelLoginFormTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginFormTitle.Location = new System.Drawing.Point(111, 19);
            this.labelLoginFormTitle.Name = "labelLoginFormTitle";
            this.labelLoginFormTitle.Size = new System.Drawing.Size(89, 37);
            this.labelLoginFormTitle.TabIndex = 4;
            this.labelLoginFormTitle.Text = "Login";
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 632);
            this.Controls.Add(this.panelLoginForm);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panelLoginForm.ResumeLayout(false);
            this.panelLoginForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginForm;
        private System.Windows.Forms.Label labelLoginFormTitle;
        private System.Windows.Forms.Label labelTitleSeparator;
        private System.Windows.Forms.Label labelLoginFormPswd;
        private System.Windows.Forms.Label labelLoginFormUsrnm;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPswd;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonGoToRegister;
    }
}