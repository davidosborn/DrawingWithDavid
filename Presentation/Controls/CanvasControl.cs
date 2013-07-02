using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using DrawingWithDavid.State;

namespace DrawingWithDavid.Presentation
{
	public class CanvasControl : PictureBox
	{
		private Bitmap backgroundBitmap;

		private Point strokeStartingPoint;
		private State.Brush strokeBrush;

		private Point lastMousePosition;

		public CanvasControl()
		{
			Image = new Bitmap(640, 480);
		}

////////////////////////////////////////////////////////////////////////////////

		private void DrawStroke(Graphics g, Point a, Point b)
		{
			g.DrawLine(State.State.Brush.Pen, a, b);
		}

////////////////////////////////////////////////////////////////////////////////

		protected override void OnMouseDown(MouseEventArgs e)
		{
			State.State.Brush.Origin = e.Location;
			
			base.OnMouseDown(e);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			var diff = Point.Subtract(e.Location, new Size(lastMousePosition));
			var distance = System.Math.Sqrt(diff.X * diff.X + diff.Y * diff.Y);
			if (distance >= State.State.Brush.Step)
			{
				if (MouseButtons.HasFlag(MouseButtons.Left))
				{
					using (var g = Graphics.FromImage(Image))
					{
						DrawStroke(g, lastMousePosition,e.Location);
					}
					Refresh();
				}

				lastMousePosition = e.Location;
			}

			base.OnMouseMove(e);
		}

		protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawImage(backgroundBitmap, 0, 0);
		}

		protected override void OnResize(System.EventArgs e)
		{
			// render checkerboard pattern to bitmap for background
			backgroundBitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
			using (var g = Graphics.FromImage(backgroundBitmap))
			{
				var brushes = new System.Drawing.Brush[]{
					new SolidBrush(Color.LightGray),
					new SolidBrush(Color.White)};

				const int step = 16;
				for (int i = 0; i < ClientSize.Width; i += step)
					for (int j = 0; j < ClientSize.Height; j += step)
						g.FillRectangle(brushes[(i + j) / step % 2],
							new Rectangle(i, j, i + step - 1, j + step - 1));
			}

			base.OnResize(e);
		}
	}
}
