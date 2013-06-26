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

			// bind events for updating workspace rectangle
			EventHandler updateWorkspaceRectangle = delegate
			{
				UpdateWorkspaceRectangle();
			};
			Load   += updateWorkspaceRectangle;
			Resize += updateWorkspaceRectangle;
		}

////////////////////////////////////////////////////////////////////////////////

		/**
		 * Resize workspace to fill client rectangle.
		 */
		private void UpdateWorkspaceRectangle()
		{
			Rectangle wsRect = ClientRectangle;
			wsRect.Y += uxMenuStrip.Height;
			wsRect.Height -= uxMenuStrip.Height;
			wsRect.Height -= uxStatusStrip.Height;
			UpdateWorkspaceRectangle(wsRect);
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
			toolForm.Show(this);
		}
	}
}
