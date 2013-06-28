namespace DrawingWithDavid.Presentation
{
	partial class MainForm
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
			this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colourDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historyBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uxStatusStrip = new System.Windows.Forms.StatusStrip();
			this.uxStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.uxMenuStrip.SuspendLayout();
			this.uxStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// uxMenuStrip
			// 
			this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.uxMenuStrip.Name = "uxMenuStrip";
			this.uxMenuStrip.Size = new System.Drawing.Size(292, 24);
			this.uxMenuStrip.TabIndex = 1;
			this.uxMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.newToolStripMenuItem.Text = "&New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.openToolStripMenuItem.Text = "&Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.saveasToolStripMenuItem.Text = "Save &As...";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			// 
			// windowToolStripMenuItem
			// 
			this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourDialogToolStripMenuItem,
            this.historyBrowserToolStripMenuItem,
            this.zoomToolStripMenuItem});
			this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
			this.windowToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.windowToolStripMenuItem.Text = "&Window";
			// 
			// colourDialogToolStripMenuItem
			// 
			this.colourDialogToolStripMenuItem.Name = "colourDialogToolStripMenuItem";
			this.colourDialogToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.colourDialogToolStripMenuItem.Text = "&Colour";
			this.colourDialogToolStripMenuItem.Click += new System.EventHandler(this.colourDialogToolStripMenuItem_Click);
			// 
			// historyBrowserToolStripMenuItem
			// 
			this.historyBrowserToolStripMenuItem.Name = "historyBrowserToolStripMenuItem";
			this.historyBrowserToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.historyBrowserToolStripMenuItem.Text = "&History";
			this.historyBrowserToolStripMenuItem.Click += new System.EventHandler(this.historyBrowserToolStripMenuItem_Click);
			// 
			// zoomToolStripMenuItem
			// 
			this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
			this.zoomToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.zoomToolStripMenuItem.Text = "&Zoom";
			this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// uxStatusStrip
			// 
			this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxStatus});
			this.uxStatusStrip.Location = new System.Drawing.Point(0, 251);
			this.uxStatusStrip.Name = "uxStatusStrip";
			this.uxStatusStrip.Size = new System.Drawing.Size(292, 22);
			this.uxStatusStrip.TabIndex = 3;
			this.uxStatusStrip.Text = "statusStrip1";
			// 
			// uxStatus
			// 
			this.uxStatus.BackColor = System.Drawing.SystemColors.Control;
			this.uxStatus.Name = "uxStatus";
			this.uxStatus.Size = new System.Drawing.Size(54, 17);
			this.uxStatus.Text = "Welcome!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.uxStatusStrip);
			this.Controls.Add(this.uxMenuStrip);
			this.MainMenuStrip = this.uxMenuStrip;
			this.Name = "MainForm";
			this.Text = "Drawing with David";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Controls.SetChildIndex(this.uxMenuStrip, 0);
			this.Controls.SetChildIndex(this.uxStatusStrip, 0);
			this.uxMenuStrip.ResumeLayout(false);
			this.uxMenuStrip.PerformLayout();
			this.uxStatusStrip.ResumeLayout(false);
			this.uxStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip uxMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colourDialogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historyBrowserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
		private System.Windows.Forms.StatusStrip uxStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel uxStatus;
	}
}

