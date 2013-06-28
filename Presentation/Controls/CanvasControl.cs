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

////////////////////////////////////////////////////////////////////////////////

		private static void DrawStroke(Graphics g, Point a, Point b, float radius)
		{
			var pen = new Pen(Color.Green, 1 + radius * 2);
			var brush = new SolidBrush(Color.Green);
			g.DrawLine(pen, a, b);
			g.FillEllipse(brush,
				a.X - radius,
				a.Y - radius,
				1 + radius * 2,
				1 + radius * 2);
			g.FillEllipse(brush,
				b.X - radius,
				b.Y - radius,
				1 + radius * 2,
				1 + radius * 2);
		}

////////////////////////////////////////////////////////////////////////////////

		protected override void OnMouseMove(MouseEventArgs e)
		{
			var diff = Point.Subtract(e.Location, new Size(lastMousePosition));
			var maxDiff = System.Math.Max(
				System.Math.Abs(diff.X),
				System.Math.Abs(diff.Y));
			if (maxDiff > 10)
			{
				if (MouseButtons.HasFlag(MouseButtons.Left))
				{
					using (var g = Graphics.FromImage(Image))
					{
						DrawStroke(g, lastMousePosition,e.Location, 10);
					}
					Refresh();
				}

				lastMousePosition = e.Location;
			}

			base.OnMouseMove(e);
		}

		protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
		{
			var brushes = new Brush[]{
				new SolidBrush(Color.LightGray),
				new SolidBrush(Color.White)};

			const int step = 16;
			for (int i = 0; i < ClientSize.Width; i += step)
				for (int j = 0; j < ClientSize.Height; j += step)
					e.Graphics.FillRectangle(brushes[(i + j) / step % 2],
						new Rectangle(i, j, i + step - 1, j + step - 1));
		}
	}
}
