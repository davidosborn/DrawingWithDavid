namespace DrawingWithDavid.Presentation
{
	partial class ColorStateBox
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
			this.uxForeColor = new System.Windows.Forms.Label();
			this.uxBackColor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// uxForeColor
			// 
			this.uxForeColor.BackColor = System.Drawing.Color.Black;
			this.uxForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uxForeColor.ForeColor = System.Drawing.Color.White;
			this.uxForeColor.Location = new System.Drawing.Point(12, 9);
			this.uxForeColor.Name = "uxForeColor";
			this.uxForeColor.Size = new System.Drawing.Size(59, 59);
			this.uxForeColor.TabIndex = 3;
			this.uxForeColor.Text = "#000";
			this.uxForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uxBackColor
			// 
			this.uxBackColor.BackColor = System.Drawing.Color.White;
			this.uxBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uxBackColor.ForeColor = System.Drawing.Color.Black;
			this.uxBackColor.Location = new System.Drawing.Point(77, 9);
			this.uxBackColor.Name = "uxBackColor";
			this.uxBackColor.Size = new System.Drawing.Size(59, 59);
			this.uxBackColor.TabIndex = 4;
			this.uxBackColor.Text = "#FFF";
			this.uxBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ColorStateBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(148, 77);
			this.Controls.Add(this.uxBackColor);
			this.Controls.Add(this.uxForeColor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ColorStateBox";
			this.Text = "Colour State";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label uxForeColor;
		private System.Windows.Forms.Label uxBackColor;
	}
}