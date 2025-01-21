namespace WebMediaPlayer
{
    partial class FormLibrary
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
			this.labelTitleLibrary = new System.Windows.Forms.Label();
			this.flowLayoutPanelArtists = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// labelTitleLibrary
			// 
			this.labelTitleLibrary.AutoSize = true;
			this.labelTitleLibrary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitleLibrary.Location = new System.Drawing.Point(31, 22);
			this.labelTitleLibrary.Name = "labelTitleLibrary";
			this.labelTitleLibrary.Size = new System.Drawing.Size(130, 28);
			this.labelTitleLibrary.TabIndex = 1;
			this.labelTitleLibrary.Text = "La tua libreria";
			// 
			// flowLayoutPanelArtists
			// 
			this.flowLayoutPanelArtists.AutoScroll = true;
			this.flowLayoutPanelArtists.Location = new System.Drawing.Point(36, 75);
			this.flowLayoutPanelArtists.Name = "flowLayoutPanelArtists";
			this.flowLayoutPanelArtists.Size = new System.Drawing.Size(961, 537);
			this.flowLayoutPanelArtists.TabIndex = 2;
			// 
			// FormLibrary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1040, 624);
			this.Controls.Add(this.flowLayoutPanelArtists);
			this.Controls.Add(this.labelTitleLibrary);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "FormLibrary";
			this.Text = "FormLibrary";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleLibrary;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelArtists;
	}
}