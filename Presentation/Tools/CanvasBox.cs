using System.Collections.Generic;
using System.Drawing;

namespace DrawingWithDavid.Presentation
{
	public partial class CanvasBox : DockableForm
	{
		public CanvasBox()
		{
			InitializeComponent();
		}

		private void uxPicture_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			MainForm.SetStatus(string.Format("Cursor: {0},{1}", e.Location.X, e.Location.Y));
		}
	}
}
