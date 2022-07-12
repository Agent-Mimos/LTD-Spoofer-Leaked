using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000013 RID: 19
	internal static class Program
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x0000A39A File Offset: 0x0000859A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
