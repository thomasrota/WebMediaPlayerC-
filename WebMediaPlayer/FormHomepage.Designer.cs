namespace WebMediaPlayer
{
	partial class FormHomepage
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
			this.labelWelcome = new System.Windows.Forms.Label();
			this.flowLayoutPanelRecents = new System.Windows.Forms.FlowLayoutPanel();
			this.labelRecents = new System.Windows.Forms.Label();
			this.labelRecomended = new System.Windows.Forms.Label();
			this.flowLayoutPanelRecomended = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.ForeColor = System.Drawing.Color.White;
			this.labelWelcome.Location = new System.Drawing.Point(32, 6);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(0, 28);
			this.labelWelcome.TabIndex = 0;
			// 
			// flowLayoutPanelRecents
			// 
			this.flowLayoutPanelRecents.AutoScroll = true;
			this.flowLayoutPanelRecents.ForeColor = System.Drawing.Color.White;
			this.flowLayoutPanelRecents.Location = new System.Drawing.Point(37, 61);
			this.flowLayoutPanelRecents.Name = "flowLayoutPanelRecents";
			this.flowLayoutPanelRecents.Size = new System.Drawing.Size(973, 290);
			this.flowLayoutPanelRecents.TabIndex = 1;
			this.flowLayoutPanelRecents.WrapContents = false;
			// 
			// labelRecents
			// 
			this.labelRecents.AutoSize = true;
			this.labelRecents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRecents.ForeColor = System.Drawing.Color.White;
			this.labelRecents.Location = new System.Drawing.Point(34, 41);
			this.labelRecents.Name = "labelRecents";
			this.labelRecents.Size = new System.Drawing.Size(140, 20);
			this.labelRecents.TabIndex = 2;
			this.labelRecents.Text = "Aggiunti di Recente";
			this.labelRecents.Visible = false;
			// 
			// labelRecomended
			// 
			this.labelRecomended.AutoSize = true;
			this.labelRecomended.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRecomended.ForeColor = System.Drawing.Color.White;
			this.labelRecomended.Location = new System.Drawing.Point(38, 364);
			this.labelRecomended.Name = "labelRecomended";
			this.labelRecomended.Size = new System.Drawing.Size(142, 20);
			this.labelRecomended.TabIndex = 3;
			this.labelRecomended.Text = "Consigliati per Oggi";
			this.labelRecomended.Visible = false;
			// 
			// flowLayoutPanelRecomended
			// 
			this.flowLayoutPanelRecomended.AutoScroll = true;
			this.flowLayoutPanelRecomended.ForeColor = System.Drawing.Color.White;
			this.flowLayoutPanelRecomended.Location = new System.Drawing.Point(37, 386);
			this.flowLayoutPanelRecomended.Name = "flowLayoutPanelRecomended";
			this.flowLayoutPanelRecomended.Size = new System.Drawing.Size(973, 336);
			this.flowLayoutPanelRecomended.TabIndex = 4;
			this.flowLayoutPanelRecomended.WrapContents = false;
			// 
			// FormHomepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1040, 624);
			this.Controls.Add(this.flowLayoutPanelRecomended);
			this.Controls.Add(this.labelRecomended);
			this.Controls.Add(this.labelRecents);
			this.Controls.Add(this.flowLayoutPanelRecents);
			this.Controls.Add(this.labelWelcome);
			this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormHomepage";
			this.Text = "FormHomepage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecents;
		private System.Windows.Forms.Label labelRecents;
		private System.Windows.Forms.Label labelRecomended;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecomended;
	}
}