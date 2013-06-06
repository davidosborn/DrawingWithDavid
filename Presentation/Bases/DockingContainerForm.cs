using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	/**
	 * A container for dockable forms.
	 */
	public partial class DockingContainerForm : Form
	{
		/**
		 * 
		 */
		private static double SNAP_THRESHOLD = 100;

		/**
		 * 
		 */
		private List<Form> dockedForms;

		/**
		 * 
		 */
		private List<Point> anchors;

		/**
		 * Constructor.
		 */
		public DockingContainerForm()
		{
			InitializeComponent();
		}

		/**
		 * Initializes the docking area.
		 * 
		 * @note This function must be called by the derived class.
		 */
		protected void UpdateDockingBounds(Rectangle rect)
		{
			anchors = new List<Point>{
				new Point(rect.Left,  rect.Top),
				new Point(rect.Left,  rect.Bottom),
				new Point(rect.Right, rect.Top),
				new Point(rect.Right, rect.Bottom)};
		}

		/**
		 * Attempts to dock the specified form within the container.
		 */
		public void TryToDock(Form form)
		{
			List<Point> corners = new List<Point>{
				new Point(form.Bounds.Left,  form.Bounds.Top),
				new Point(form.Bounds.Left,  form.Bounds.Bottom),
				new Point(form.Bounds.Right, form.Bounds.Top),
				new Point(form.Bounds.Right, form.Bounds.Bottom)};

			int closestAnchor = -1;
			int closestCorner;
			Point closestDiff = default(Point);
			double distanceBetweenClosestAnchorAndCorner = double.PositiveInfinity;

			for (int j = 0; j < anchors.Count; ++j)
				for (int i = 0; i < corners.Count; ++i)
				{
					Point diff = Point.Subtract(anchors[i], new Size(corners[j]));
					double distance = System.Math.Sqrt(diff.X * diff.X + diff.Y * diff.Y);
					if (distance < SNAP_THRESHOLD &&
						distance < distanceBetweenClosestAnchorAndCorner)
					{
						closestAnchor = i;
						closestCorner = j;
						distanceBetweenClosestAnchorAndCorner = distance;
						closestDiff = diff;
					}
				}

			if (closestAnchor != -1)
			{
				form.Location = Point.Add(form.Location, new Size(closestDiff));
			}
		}
	}
}
