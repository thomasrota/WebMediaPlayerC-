namespace WebMediaPlayer
{
    partial class FormSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSrc = new System.Windows.Forms.TextBox();
			this.buttonSrc = new System.Windows.Forms.Button();
			this.flowLayoutPanelSrcResults = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cerca";
			// 
			// textBoxSrc
			// 
			this.textBoxSrc.Location = new System.Drawing.Point(34, 90);
			this.textBoxSrc.Name = "textBoxSrc";
			this.textBoxSrc.Size = new System.Drawing.Size(407, 26);
			this.textBoxSrc.TabIndex = 1;
			// 
			// buttonSrc
			// 
			this.buttonSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
			this.buttonSrc.FlatAppearance.BorderSize = 0;
			this.buttonSrc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSrc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSrc.ForeColor = System.Drawing.Color.White;
			this.buttonSrc.Image = ((System.Drawing.Image)(resources.GetObject("buttonSrc.Image")));
			this.buttonSrc.Location = new System.Drawing.Point(447, 89);
			this.buttonSrc.Name = "buttonSrc";
			this.buttonSrc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonSrc.Size = new System.Drawing.Size(42, 26);
			this.buttonSrc.TabIndex = 11;
			this.buttonSrc.UseVisualStyleBackColor = false;
			// 
			// flowLayoutPanelSrcResults
			// 
			this.flowLayoutPanelSrcResults.Location = new System.Drawing.Point(34, 157);
			this.flowLayoutPanelSrcResults.Name = "flowLayoutPanelSrcResults";
			this.flowLayoutPanelSrcResults.Size = new System.Drawing.Size(927, 455);
			this.flowLayoutPanelSrcResults.TabIndex = 12;
			// 
			// FormSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1040, 624);
			this.Controls.Add(this.flowLayoutPanelSrcResults);
			this.Controls.Add(this.buttonSrc);
			this.Controls.Add(this.textBoxSrc);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "FormSearch";
			this.Text = "FormSearch";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSrc;
		private System.Windows.Forms.Button buttonSrc;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSrcResults;
	}
}