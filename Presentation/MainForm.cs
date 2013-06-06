using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	public partial class MainForm : Form
	{
		private List<Form> toolForms = new List<Form>();
		private List<CanvasBox> canvasBoxes = new List<CanvasBox>();
		private DockingContainerControl dockingContainer;

////////////////////////////////////////////////////////////////////////////////

		public MainForm()
		{
			InitializeComponent();

			dockingContainer = new DockingContainerControl();
			dockingContainer.BackColor = System.Drawing.Color.AliceBlue;
			dockingContainer.Bounds = ClientRectangle;
			dockingContainer.Top += uxMenuStrip.Height;
			dockingContainer.Height -= uxStatusStrip.Height;
			this.Controls.Add(dockingContainer);
		}

////////////////////////////////////////////////////////////////////////////////

		private void MainWindow_Load(object sender, EventArgs e)
		{
			ShowToolForm<ColorStateBox>();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new AboutBox()).ShowDialog();
		}

		private void colourDialogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowToolForm<ColorBox>();
		}

		private void historyBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowToolForm<HistoryBox>();
		}

		private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowToolForm<ZoomBox>();
		}

////////////////////////////////////////////////////////////////////////////////

		private void ShowToolForm<T>() where T : DockableForm, new()
		{
			T toolForm = new T();
			toolForms.Add(toolForm);
			toolForm.MdiParent = this;
			toolForm.Show();
		}
	}
}
