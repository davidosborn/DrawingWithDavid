using DrawingWithDavid.Presentation;
using System;
using System.Windows.Forms;

namespace DrawingWithDavid.Program
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
