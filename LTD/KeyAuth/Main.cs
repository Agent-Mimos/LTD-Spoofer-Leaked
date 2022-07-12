using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Loader;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000011 RID: 17
	public partial class Main : Form
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00007A16 File Offset: 0x00005C16
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007A30 File Offset: 0x00005C30
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			string folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "winsys/launch.exe");
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ltd.exe");
			if (File.Exists(folderpath))
			{
				File.Delete(folderpath);
			}
			File.Delete(path);
			Environment.Exit(0);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007A7C File Offset: 0x00005C7C
		private void Main_Load(object sender, EventArgs e)
		{
			this.gameSpoofer1.Hide();
			this.setting1.Hide();
			this.spoofer1.Hide();
			Login.KeyAuthApp.check();
			this.key.Text = Login.KeyAuthApp.user_data.username;
			this.expiry.Text = (this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString() ?? "");
			this.subscription.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
			this.lastLogin.Text = (this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.lastlogin)).ToString() ?? "");
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007B6C File Offset: 0x00005D6C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			dtDateTime = dtDateTime.AddSeconds((double)unixtime).ToLocalTime();
			return dtDateTime;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007BA0 File Offset: 0x00005DA0
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.dashboard1.Show();
			this.gameSpoofer1.Hide();
			this.spoofer1.Hide();
			this.key.Show();
			this.expiry.Show();
			this.lastLogin.Show();
			this.setting1.Hide();
			this.subscription.Show();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007C08 File Offset: 0x00005E08
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.dashboard1.Hide();
			this.gameSpoofer1.Show();
			this.spoofer1.Hide();
			this.key.Hide();
			this.expiry.Hide();
			this.lastLogin.Hide();
			this.subscription.Hide();
			this.setting1.Hide();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007C70 File Offset: 0x00005E70
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.setting1.Hide();
			this.spoofer1.Show();
			this.gameSpoofer1.Hide();
			this.dashboard1.Hide();
			this.key.Hide();
			this.expiry.Hide();
			this.lastLogin.Hide();
			this.subscription.Hide();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007CD8 File Offset: 0x00005ED8
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.key.Hide();
			this.expiry.Hide();
			this.lastLogin.Hide();
			this.subscription.Hide();
			this.setting1.Show();
			this.dashboard1.Hide();
			this.gameSpoofer1.Hide();
			this.spoofer1.Hide();
		}

		// Token: 0x0400007B RID: 123
		private string chatchannel = "testing";
	}
}
