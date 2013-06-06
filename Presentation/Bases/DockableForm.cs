using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	public partial class DockableForm : Form
	{
		public DockableForm()
		{
			InitializeComponent();

			Move += delegate
			{
				DockingContainerForm parent = ((DockingContainerForm)MdiParent);
				parent.TryToDock(this);
			};
		}
	}
}
