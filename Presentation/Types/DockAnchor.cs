using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	/**
	 * An anchor point between a form and the form it is docked to.
	 *
	public struct Anchor
	{
		/**
		 * A side of a rectangle.
		 *
		public enum Side
		{
			Left,
			Top,
			Right,
			Bottom
		}

		/**
		 * The anchor point on the source form, which can be one of its corners.
		 *
		public Corner SourceCorner;

		/**
		 * The form that this form is anchored to.
		 *
		public Form TargetForm;

		/**
		 * The side of the target form on which the anchor point lies.
		 *
		public Side TargetSide;

		/**
		 * A unit ratio specifying the anchor point on the target form along the
		 * specified side, from left-to-right or top-to-bottom.
		 *
		public float TargetSideRatio;

		/**
		 * The position of the anchor on the target form, in screen coordinates.
		 *
		public Point TargetPosition
		{
			get
			{
				Point a, b;
				var rect = new Rectangle(TargetForm.Location, TargetForm.Size);
				switch (TargetSide)
				{
					case Side.Left:
					case Side.Right:
					a = new Point(rect.Left, rect.Top);
					b = new Point(rect.Left, rect.Bottom);
					break;

					case Side.Top:
					case Side.Bottom:
					a = new Point(rect.Left, rect.Top);
					b = new Point(rect.Right, rect.Top);
					break;
				}
				return new Point(
					a.X + (int)((b.X - a.X) * TargetSideRatio),
					a.Y + (int)((b.Y - a.Y) * TargetSideRatio));
			}
		}
	}*/

	public struct DockAnchor
	{
		/**
		 * The form that this form is anchored to.
		 */
		public Form TargetForm;

		/**
		 * The side of the target form on which the anchor point lies.
		 */
		public Side TargetSide;
	}
}
