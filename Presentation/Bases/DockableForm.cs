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
		 * The anchors that describe the current docking state.
		 */
		DockAnchors Anchors;
		//public List<Anchor> Anchors = new List<Anchor>();

		private Rectangle lastBounds;

		private SideFlags sidesBeingResized = 0;

		private bool docking = false;

		/**
		 * Constructor.
		 */
		public DockableForm()
		{
			InitializeComponent();

			Load += delegate
			{
				this.Move += new System.EventHandler(DockableForm_Move);
				this.Resize += new System.EventHandler(DockableForm_Resize);
				this.ResizeBegin += new System.EventHandler(DockableForm_ResizeBegin);
				this.ResizeEnd   += new System.EventHandler(DockableForm_ResizeEnd);
			};
			
			/**
			 * Bind events for updating the docking.
			 */
			/*Move += delegate
			{
				if (Owner == null) return;
				DockingContainerForm parent = ((DockingContainerForm)Owner);
				parent.TryToDock(this);
			};
			ResizeBegin += delegate
			{
				// determine which side(s) of the form are being resized


			};
			Resize += delegate
			{
				if (Owner == null) return;
				DockingContainerForm parent = ((DockingContainerForm)Owner);
				parent.TryToDock(this);
			};*/
		}

		/**
		 * Returns a list of the forms that this form is anchored to.
		 */
		public List<Form> GetDependencies()
		{
			List<Form> dependencies = new List<Form>();
			foreach (DockAnchor anchor in Anchors)
				dependencies.Add(anchor.TargetForm);
			return dependencies;
		}

		/**
		 * Update the form's position and size to match the forms that it is
		 * anchored to.
		 */
		public void RepositionToAnchors()
		{
			/*bool
				stretchHorizontally =
					Anchors.TopLeft    != null && Anchors.TopRight    != null ||
					Anchors.BottomLeft != null && Anchors.BottomRight != null,
				stretchVertically =
					Anchors.TopLeft  != null && Anchors.BottomLeft  != null ||
					Anchors.TopRight != null && Anchors.BottomRight != null;*/

		}

		public DockingContainerForm DockingContainer {
			get { return (DockingContainerForm)Owner; }}

		private void DockableForm_Move(object sender, EventArgs e)
		{
			if (!docking)
			{
				docking = true;
				DockingContainer.TryToDock(this, SideFlags.All, false);
				docking = false;
			}
		}

		private void DockableForm_Resize(object sender, EventArgs e)
		{
			// determine which sides of the form are being resized
			if (sidesBeingResized == 0)
				sidesBeingResized =
					(Bounds.Left   != lastBounds.Left   ? SideFlags.Left   : 0) |
					(Bounds.Top    != lastBounds.Top    ? SideFlags.Top    : 0) |
					(Bounds.Right  != lastBounds.Right  ? SideFlags.Right  : 0) |
					(Bounds.Bottom != lastBounds.Bottom ? SideFlags.Bottom : 0);
		}

		private void DockableForm_ResizeBegin(object sender, EventArgs e)
		{
			sidesBeingResized = 0;
			lastBounds = Bounds;
		}

		private void DockableForm_ResizeEnd(object sender, EventArgs e)
		{
			if (!docking)
			{
				docking = true;
				DockingContainer.TryToDock(this, sidesBeingResized, true);
				docking = false;
			}
		}
	}
}
