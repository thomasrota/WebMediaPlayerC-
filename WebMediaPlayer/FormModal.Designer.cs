namespace WebMediaPlayer
{
	partial class FormModal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModal));
			this.panelModalTitle = new System.Windows.Forms.Panel();
			this.buttonCloseModal = new System.Windows.Forms.Button();
			this.labelModalTitle = new System.Windows.Forms.Label();
			this.labelTitleSeparator = new System.Windows.Forms.Label();
			this.panelModalTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelModalTitle
			// 
			this.panelModalTitle.Controls.Add(this.buttonCloseModal);
			this.panelModalTitle.Controls.Add(this.labelModalTitle);
			this.panelModalTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelModalTitle.Location = new System.Drawing.Point(0, 0);
			this.panelModalTitle.Name = "panelModalTitle";
			this.panelModalTitle.Size = new System.Drawing.Size(594, 91);
			this.panelModalTitle.TabIndex = 0;
			// 
			// buttonCloseModal
			// 
			this.buttonCloseModal.FlatAppearance.BorderSize = 0;
			this.buttonCloseModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCloseModal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCloseModal.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseModal.Image")));
			this.buttonCloseModal.Location = new System.Drawing.Point(540, 24);
			this.buttonCloseModal.Name = "buttonCloseModal";
			this.buttonCloseModal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonCloseModal.Size = new System.Drawing.Size(53, 46);
			this.buttonCloseModal.TabIndex = 1;
			this.buttonCloseModal.UseVisualStyleBackColor = true;
			this.buttonCloseModal.Click += new System.EventHandler(this.buttonCloseModal_Click);
			// 
			// labelModalTitle
			// 
			this.labelModalTitle.AutoSize = true;
			this.labelModalTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelModalTitle.Location = new System.Drawing.Point(25, 35);
			this.labelModalTitle.Name = "labelModalTitle";
			this.labelModalTitle.Size = new System.Drawing.Size(78, 32);
			this.labelModalTitle.TabIndex = 0;
			this.labelModalTitle.Text = "label1";
			// 
			// labelTitleSeparator
			// 
			this.labelTitleSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTitleSeparator.Location = new System.Drawing.Point(0, 90);
			this.labelTitleSeparator.Name = "labelTitleSeparator";
			this.labelTitleSeparator.Size = new System.Drawing.Size(594, 2);
			this.labelTitleSeparator.TabIndex = 3;
			// 
			// FormModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(594, 720);
			this.Controls.Add(this.labelTitleSeparator);
			this.Controls.Add(this.panelModalTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(594, 720);
			this.MinimumSize = new System.Drawing.Size(594, 720);
			this.Name = "FormModal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormModal";
			this.panelModalTitle.ResumeLayout(false);
			this.panelModalTitle.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelModalTitle;
		private System.Windows.Forms.Label labelModalTitle;
		private System.Windows.Forms.Button buttonCloseModal;
		private System.Windows.Forms.Label labelTitleSeparator;
	}
}