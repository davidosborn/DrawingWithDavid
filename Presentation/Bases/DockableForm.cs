using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	/**
	 * A form that can be docked.
	 */
	public partial class DockableForm : Form
	{
		/**
		 * The bounding rectangle of the form before it is resized.
		 * 
		 * @note This field is only valid when the form is being resized.
		 */
		private Rectangle boundsBeforeResize;

		/**
		 * A sentry used to prevent the docking code in ResizeEnd event from
		 * calling itself recursively.
		 */
		private bool inResizeEnd = false;

		/**
		 * The sides of the form that are currently being resized.
		 * 
		 * @note This field is only valid when the form is being resized.
		 */
		private SideFlags sidesBeingResized = SideFlags.None;

////////////////////////////////////////////////////////////////////////////////

		/**
		 * Constructor.
		 */
		public DockableForm()
		{
			InitializeComponent();

			Load += delegate
			{
				this.Resize      += DockableForm_Resize;
				this.ResizeBegin += DockableForm_ResizeBegin;
				this.ResizeEnd   += DockableForm_ResizeEnd;
			};
		}

		/**
		 * Returns a list of the forms that this form is anchored to.
		 */
		public List<Form> GetDependencies()
		{
			List<Form> dependencies = new List<Form>();
			/*foreach (DockAnchor anchor in Anchors)
				dependencies.Add(anchor.TargetForm);*/
			return dependencies;
		}

		/**
		 * Returns the DockingContainer that contains this form.
		 */
		public DockingContainerForm DockingContainer {
			get { return (DockingContainerForm)Owner; }}

////////////////////////////////////////////////////////////////////////////////

		private void DockableForm_Resize(object sender, EventArgs e)
		{
			// determine which sides of the form are being resized
			if (sidesBeingResized == 0)
				sidesBeingResized =
					(Bounds.Left   != boundsBeforeResize.Left   ? SideFlags.Left   : 0) |
					(Bounds.Top    != boundsBeforeResize.Top    ? SideFlags.Top    : 0) |
					(Bounds.Right  != boundsBeforeResize.Right  ? SideFlags.Right  : 0) |
					(Bounds.Bottom != boundsBeforeResize.Bottom ? SideFlags.Bottom : 0);
		}

		private void DockableForm_ResizeBegin(object sender, EventArgs e)
		{
			sidesBeingResized = SideFlags.None;
			boundsBeforeResize = Bounds;
		}

		private void DockableForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!inResizeEnd)
			{
				inResizeEnd = true;
				
				if (sidesBeingResized != SideFlags.None)
					DockingContainer.TryToDock(this, sidesBeingResized, true);
				else DockingContainer.TryToDock(this, SideFlags.All, false);

				inResizeEnd = false;
			}
		}
	}
}
