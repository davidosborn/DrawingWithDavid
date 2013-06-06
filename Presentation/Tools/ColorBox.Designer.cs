namespace DrawingWithDavid.Presentation
{
	partial class ColorBox
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
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorPicker1 = new DrawingWithDavid.Presentation.ColorPickerControl();
			this.SuspendLayout();
			// 
			// colorPicker1
			// 
			this.colorPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.colorPicker1.Location = new System.Drawing.Point(13, 13);
			this.colorPicker1.Name = "colorPicker1";
			this.colorPicker1.Size = new System.Drawing.Size(150, 150);
			this.colorPicker1.TabIndex = 0;
			// 
			// ColorBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.colorPicker1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ColorBox";
			this.Text = "Colour";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private ColorPickerControl colorPicker1;

	}
}