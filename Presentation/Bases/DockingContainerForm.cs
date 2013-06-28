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
		private List<DockableForm> dockedForms = new List<DockableForm>();

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
		protected void UpdateWorkspaceRectangle(Rectangle rect)
		{
			uxWorkspace.Bounds = rect;
		}

		/**
		 * Attempts to dock the specified form within the container.
		 */
		public void TryToDock(DockableForm form, SideFlags sides, bool resize)
		{
			var docks = new List<Rectangle>();
			
			// consider the outside edges of the main window
			// FIXME: implement

			// consider the edges of the workspace (the client area)
			docks.Add(RectangleToScreen(uxWorkspace.Bounds));
			
			// consider the outside edges of other dockable forms
			/*foreach (var dockedForm in dockedForms)
				docks.Add(new Rectangle(
					dockedForm.Bounds.Right,
					dockedForm.Bounds.Bottom,
					dockedForm.Bounds.Left,
					dockedForm.Bounds.Top));*/

			var distancePerSide = new int[4]{0, 0, 0, 0};

			if ((sides & SideFlags.Left) != SideFlags.None)
			{
				int minDistance = 0;
				foreach (var dock in docks)
				{
					int distance = dock.Left - form.Bounds.Left;
					if (System.Math.Abs(distance) <= Config.DockSnapThreshold)
						minDistance = Math.AbsMinNotZero(minDistance, distance);
				}
				distancePerSide[(int)Side.Left] = minDistance;
			}

			if ((sides & SideFlags.Top) != SideFlags.None)
			{
				int minDistance = 0;
				foreach (var dock in docks)
				{
					int distance = dock.Top - form.Bounds.Top;
					if (System.Math.Abs(distance) <= Config.DockSnapThreshold)
						minDistance = Math.AbsMinNotZero(minDistance, distance);
				}
				distancePerSide[(int)Side.Top] = minDistance;
			}

			if ((sides & SideFlags.Right) != SideFlags.None)
			{
				int minDistance = 0;
				foreach (var dock in docks)
				{
					int distance = dock.Right - form.Bounds.Right;
					if (System.Math.Abs(distance) <= Config.DockSnapThreshold)
						minDistance = Math.AbsMinNotZero(minDistance, distance);
				}
				distancePerSide[(int)Side.Right] = minDistance;
			}

			if ((sides & SideFlags.Bottom) != SideFlags.None)
			{
				int minDistance = 0;
				foreach (var dock in docks)
				{
					int distance = dock.Bottom - form.Bounds.Bottom;
					if (System.Math.Abs(distance) <= Config.DockSnapThreshold)
						minDistance = Math.AbsMinNotZero(minDistance, distance);
				}
				distancePerSide[(int)Side.Bottom] = minDistance;
			}

			var newBounds = form.Bounds;
			if (resize)
			{
				distancePerSide[(int)Side.Right] -= distancePerSide[(int)Side.Left];
				distancePerSide[(int)Side.Bottom] -= distancePerSide[(int)Side.Top];

				if (distancePerSide[(int)Side.Right] != newBounds.Width)
				{
					newBounds.X += distancePerSide[(int)Side.Left];
					newBounds.Width += distancePerSide[(int)Side.Right];
				}
				if (distancePerSide[(int)Side.Bottom] != newBounds.Height)
				{
					newBounds.Y += distancePerSide[(int)Side.Top];
					newBounds.Height += distancePerSide[(int)Side.Bottom];
				}
			}
			else
			{
				newBounds.X += 
					Math.AbsMinNotZero(
						distancePerSide[(int)Side.Left],
						distancePerSide[(int)Side.Right]);
				newBounds.Y += 
					Math.AbsMinNotZero(
						distancePerSide[(int)Side.Top],
						distancePerSide[(int)Side.Bottom]);
			}
			form.Bounds = newBounds;
		}
	}
}
