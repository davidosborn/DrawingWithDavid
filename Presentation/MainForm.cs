using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawingWithDavid.Presentation
{
	public partial class MainForm : DockingContainerForm
	{
		private List<DockableForm> toolForms = new List<DockableForm>();
		private List<CanvasBox> canvasBoxes = new List<CanvasBox>();

////////////////////////////////////////////////////////////////////////////////

		public MainForm()
		{
			InitializeComponent();

			Resize += delegate
			{
				Rectangle dockingRect = ClientRectangle;
				dockingRect.Height -= uxMenuStrip.Height + uxStatusStrip.Height + 4;
				UpdateDockingBounds(dockingRect);
			};
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
			toolForm.ShowInTaskbar = false;
			toolForm.Show(uxWorkspace);
		}
	}
}
