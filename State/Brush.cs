using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawingWithDavid.State
{
	using GdiBrush = System.Drawing.Brush;

	public class Brush
	{
		/**
		 * The colour of the brush.
		 */
		public Color Color = Color.Red;

		/**
		 * The starting point of the brush, for when it has a texture.
		 */
		public Point Origin = new Point();

		/**
		 * The roundness of the brush.
		 * A value of 0 produces a square brush.
		 * A value of 1 produces a circle brush.
		 */
		public float Roundness = 1;

		/**
		 * The size of the brush, measured by its radius.
		 */
		public float Size = 10;

		/**
		 * The softness of the brush.
		 * A value of 0 describes a brush with a hard edge.
		 * A value of 1 describes a brush with a linear gradient.
		 */
		public float Softness = .5f;

		/**
		 * The minimum distance the mouse must move before a stroke will be
		 * drawn.
		 */
		public float Step = 4;

		/**
		 * An optional texture.
		 */
		public Image Texture;

////////////////////////////////////////////////////////////////////////////////

		public GdiBrush GdiBrush
		{
			get
			{
				return Texture != null ? (GdiBrush)
					new TextureBrush(Texture) :
					new SolidBrush(Color);
			}
		}

		public Pen Pen
		{
			get
			{
				var pen = new Pen(GdiBrush, Size * 2 - 1);
				pen.StartCap = pen.EndCap = LineCap.Round;
				pen.TranslateTransform(Origin.X, Origin.Y);
				return pen;
			}
		}

////////////////////////////////////////////////////////////////////////////////

		private static Image GenerateRadialGradientImage(int size)
		{
			var path = new GraphicsPath();
			path.AddEllipse(new Rectangle(0, 0, size, size));
			var brush = new PathGradientBrush(path);
			brush.CenterColor = Color.Black;
			brush.SurroundColors = new Color[] { Color.Transparent };
			brush.FocusScales = new PointF(.5f, .5f);

			var bitmap = new Bitmap(size, size);
			using (var g = Graphics.FromImage(bitmap))
			{
				g.FillPath(brush, path);
			}
			return bitmap;
		}
	}
}
