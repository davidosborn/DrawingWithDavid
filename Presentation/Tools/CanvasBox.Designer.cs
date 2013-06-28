namespace DrawingWithDavid.Presentation
{
	partial class CanvasBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanvasBox));
			this.uxPicture = new DrawingWithDavid.Presentation.CanvasControl();
			((System.ComponentModel.ISupportInitialize)(this.uxPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// uxPicture
			// 
			this.uxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uxPicture.Image = ((System.Drawing.Image)(resources.GetObject("uxPicture.Image")));
			this.uxPicture.Location = new System.Drawing.Point(0, 0);
			this.uxPicture.Name = "uxPicture";
			this.uxPicture.Size = new System.Drawing.Size(292, 276);
			this.uxPicture.TabIndex = 0;
			this.uxPicture.TabStop = false;
			// 
			// CanvasBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 276);
			this.Controls.Add(this.uxPicture);
			this.Name = "CanvasBox";
			this.Text = "Canvas";
			((System.ComponentModel.ISupportInitialize)(this.uxPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CanvasControl uxPicture;

	}
}