using System.Drawing;
using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	public class CanvasControl : PictureBox
	{
		private Point lastMousePosition;

		public CanvasControl()
		{
			Image = new Bitmap(640, 480);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			/*points.Add(e.Location);
			Invalidate();*/

			if (MouseButtons.HasFlag(MouseButtons.Left))
			{
				using (var g = Graphics.FromImage(Image))
				{
					var pen = new Pen(Color.Green, 3);
					g.DrawLine(pen, lastMousePosition, e.Location);
				}
				Refresh();
			}

			lastMousePosition = e.Location;

			base.OnMouseMove(e);
		}
	}
}
