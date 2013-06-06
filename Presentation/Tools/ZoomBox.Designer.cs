namespace DrawingWithDavid.Presentation
{
	partial class ZoomBox
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
			this.uxZoom = new System.Windows.Forms.TrackBar();
			this.uxPreview = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.uxZoom)).BeginInit();
			this.SuspendLayout();
			// 
			// uxZoom
			// 
			this.uxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxZoom.Location = new System.Drawing.Point(12, 219);
			this.uxZoom.Name = "uxZoom";
			this.uxZoom.Size = new System.Drawing.Size(267, 42);
			this.uxZoom.TabIndex = 0;
			// 
			// uxPreview
			// 
			this.uxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.uxPreview.Location = new System.Drawing.Point(13, 25);
			this.uxPreview.Name = "uxPreview";
			this.uxPreview.Size = new System.Drawing.Size(267, 175);
			this.uxPreview.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Preview";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Zoom";
			// 
			// ZoomBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uxPreview);
			this.Controls.Add(this.uxZoom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ZoomBox";
			this.Text = "Zoom";
			((System.ComponentModel.ISupportInitialize)(this.uxZoom)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar uxZoom;
		private System.Windows.Forms.Panel uxPreview;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}