namespace DrawingWithDavid.Presentation
{
	partial class DockingContainerForm
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.uxWorkspace = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// uxWorkspace
			// 
			this.uxWorkspace.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.uxWorkspace.Location = new System.Drawing.Point(50, 50);
			this.uxWorkspace.Name = "uxWorkspace";
			this.uxWorkspace.Size = new System.Drawing.Size(100, 100);
			this.uxWorkspace.TabIndex = 0;
			// 
			// DockingContainerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.uxWorkspace);
			this.Name = "DockingContainerForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel uxWorkspace;
	}
}
