using System;
using System.Windows.Forms;

namespace CreationMaster
{
	// Token: 0x02000014 RID: 20
	internal static class Program
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00054A65 File Offset: 0x00052C65
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
