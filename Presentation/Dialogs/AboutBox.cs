using System.Windows.Forms;

namespace DrawingWithDavid.Presentation
{
	public partial class AboutBox : Form
	{
		public AboutBox()
		{
			InitializeComponent();
		}

		private void uxOkay_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
