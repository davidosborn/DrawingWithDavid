namespace DrawingWithDavid.Presentation
{
	partial class AboutBox
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
			this.uxText = new System.Windows.Forms.TextBox();
			this.uxOkay = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// uxText
			// 
			this.uxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uxText.Location = new System.Drawing.Point(12, 12);
			this.uxText.Multiline = true;
			this.uxText.Name = "uxText";
			this.uxText.ReadOnly = true;
			this.uxText.Size = new System.Drawing.Size(268, 220);
			this.uxText.TabIndex = 1;
			this.uxText.TabStop = false;
			this.uxText.Text = "Drawing with David\r\nCopyright © 2013 David Osborn.\r\nSource code is available unde" +
    "r the MIT License.";
			// 
			// uxOkay
			// 
			this.uxOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uxOkay.Location = new System.Drawing.Point(205, 238);
			this.uxOkay.Name = "uxOkay";
			this.uxOkay.Size = new System.Drawing.Size(75, 23);
			this.uxOkay.TabIndex = 2;
			this.uxOkay.Text = "Okay";
			this.uxOkay.UseVisualStyleBackColor = true;
			this.uxOkay.Click += new System.EventHandler(this.uxOkay_Click);
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.uxOkay);
			this.Controls.Add(this.uxText);
			this.Name = "AboutBox";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox uxText;
		private System.Windows.Forms.Button uxOkay;
	}
}