using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000012 RID: 18
	public partial class Login : Form
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00008FD7 File Offset: 0x000071D7
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008FE5 File Offset: 0x000071E5
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008FF0 File Offset: 0x000071F0
		private void Login_Load(object sender, EventArgs e)
		{
			this.password.PasswordChar = '*';
			Login.KeyAuthApp.init();
			if (!Login.KeyAuthApp.response.success)
			{
				MessageBox.Show(Login.KeyAuthApp.response.message);
				Environment.Exit(0);
			}
			if (Login.KeyAuthApp.response.message == "invalidver")
			{
				if (!string.IsNullOrEmpty(Login.KeyAuthApp.app_data.downloadLink))
				{
					DialogResult dialogResult = MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo);
					if (dialogResult != DialogResult.Yes)
					{
						if (dialogResult != DialogResult.No)
						{
							MessageBox.Show("Invalid option");
							Environment.Exit(0);
						}
						else
						{
							WebClient webClient = new WebClient();
							string destFile = Application.ExecutablePath;
							string rand = Login.random_string();
							destFile = destFile.Replace(".exe", "-" + rand + ".exe");
							webClient.DownloadFile(Login.KeyAuthApp.app_data.downloadLink, destFile);
							Process.Start(destFile);
							Process.Start(new ProcessStartInfo
							{
								Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
								WindowStyle = ProcessWindowStyle.Hidden,
								CreateNoWindow = true,
								FileName = "cmd.exe"
							});
							Environment.Exit(0);
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
				MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer");
				Thread.Sleep(2500);
				Environment.Exit(0);
			}
			Login.KeyAuthApp.check();
			string url = "https://github.com/GanjaXTnnnn/ltd-spoofer/raw/main/spoofe.exe";
			string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "spoofe.exe");
			new WebClient().DownloadFile(url, savePath);
			Process.Start(savePath);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000091A8 File Offset: 0x000073A8
		private static string random_string()
		{
			string str = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				str += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return str;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009204 File Offset: 0x00007404
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00009254 File Offset: 0x00007454
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000092AD File Offset: 0x000074AD
		private void LicBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.license(this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000092E8 File Offset: 0x000074E8
		private void LoginBtn_Click_1(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00009338 File Offset: 0x00007538
		private void RgstrBtn_Click_1(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			if (Login.KeyAuthApp.response.success)
			{
				new Main().Show();
				base.Hide();
			}
		}

		// Token: 0x04000093 RID: 147
		public static api KeyAuthApp = new api("LTD Service", "6NRM3uhCkq", "1ca4bf3d5f651bdd8b20af60d2fbd195cdbaf67c8ed693f6098dff825c8b9f0a", "1.0");
	}
}
