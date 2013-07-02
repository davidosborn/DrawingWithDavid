using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using DrawingWithDavid.State;

namespace DrawingWithDavid.Presentation
{
	public partial class ColorPickerControl : UserControl
	{
		public ColorPickerControl()
		{
			InitializeComponent();
		}

		/**
		 * Returns a Color from a hue, saturation, and value.
		 * 
		 * @note Based on C++ code from <https://github.com/davidcosborn/page/>.
		 * @note HSV to RGB conversion algorithm from
		 *       <http://www.cs.rit.edu/~ncs/color/t_convert.html>.
		 */
		private static Color hsvToRgb(float h, float s, float v)
		{
			uint i = (uint)(h * 6);
			float
				f = h * 6 - i,
				p = v * (1 - s),
				q = v * (1 - s * f),
				t = v * (1 - s * (1 - f)),
				r = 0,
				g = 0,
				b = 0;
			switch (i)
			{
				case  0: r = v; g = t; b = p; break;
				case  1: r = q; g = v; b = p; break;
				case  2: r = p; g = v; b = t; break;
				case  3: r = p; g = q; b = v; break;
				case  4: r = t; g = p; b = v; break;
				default: r = v; g = p; b = q; break;
			}
			return Color.FromArgb(
				(int)(r * 255),
				(int)(g * 255),
				(int)(b * 255));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			int
				x = e.ClipRectangle.Width,
				y = e.ClipRectangle.Height;
			Point[] points = {
				new Point(0, y / 2),
				new Point(x / 3, 0),
				new Point(x * 2 / 3, 0),
				new Point(x, y / 2),
				new Point(x * 2 / 3, y),
				new Point(x / 3, y)};
			Color[] colors = {
				hsvToRgb(0.0f, 1, 1),
				hsvToRgb(0.2f, 1, 1),
				hsvToRgb(0.4f, 1, 1),
				hsvToRgb(0.6f, 1, 1),
				hsvToRgb(0.8f, 1, 1),
				hsvToRgb(1.0f, 1, 1)};
			PathGradientBrush gradientBrush = new PathGradientBrush(points);
			gradientBrush.CenterColor = Color.White;
			gradientBrush.SurroundColors = colors;
			e.Graphics.FillRectangle(gradientBrush, e.ClipRectangle);
		}

		protected override void OnClick(System.EventArgs e)
		{
			base.OnClick(e);

			Point cp = Cursor.Position;
			Bitmap bm = new Bitmap(Width, Height, CreateGraphics());
			bm.GetPixel(cp.X, cp.Y);
		}
	}
}
