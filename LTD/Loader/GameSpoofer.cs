using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Loader
{
	// Token: 0x02000002 RID: 2
	public class GameSpoofer : UserControl
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public GameSpoofer()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			string yo = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(yo))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc  LTD_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process.Start(yo).WaitForExit();
			File.Delete(yo);
			MessageBox.Show("FiveM SPOOFED successfully");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000277C File Offset: 0x0000097C
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SOON");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000277C File Offset: 0x0000097C
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SOON");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000277C File Offset: 0x0000097C
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SOON");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000277C File Offset: 0x0000097C
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SOON");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000277C File Offset: 0x0000097C
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SOON");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002789 File Offset: 0x00000989
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027A8 File Offset: 0x000009A8
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(GameSpoofer));
			this.label1 = new Label();
			this.guna2Panel4 = new Guna2Panel();
			this.guna2Button5 = new Guna2Button();
			this.pictureBox5 = new PictureBox();
			this.label5 = new Label();
			this.guna2Panel3 = new Guna2Panel();
			this.guna2Button6 = new Guna2Button();
			this.pictureBox4 = new PictureBox();
			this.label4 = new Label();
			this.guna2Panel2 = new Guna2Panel();
			this.guna2Button1 = new Guna2Button();
			this.pictureBox2 = new PictureBox();
			this.label3 = new Label();
			this.guna2Panel1 = new Guna2Panel();
			this.guna2Button3 = new Guna2Button();
			this.pictureBox3 = new PictureBox();
			this.label2 = new Label();
			this.guna2Panel5 = new Guna2Panel();
			this.guna2Button2 = new Guna2Button();
			this.pictureBox1 = new PictureBox();
			this.label7 = new Label();
			this.guna2Panel6 = new Guna2Panel();
			this.guna2Button4 = new Guna2Button();
			this.pictureBox6 = new PictureBox();
			this.label12 = new Label();
			this.guna2Panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			this.guna2Panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.guna2Panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.guna2Panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.guna2Panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.guna2Panel6.SuspendLayout();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Cyan;
			this.label1.Location = new Point(20, 19);
			this.label1.Name = "label1";
			this.label1.Size = new Size(159, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Game Spoofer";
			this.guna2Panel4.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel4.Controls.Add(this.guna2Button5);
			this.guna2Panel4.Controls.Add(this.pictureBox5);
			this.guna2Panel4.Controls.Add(this.label5);
			this.guna2Panel4.Location = new Point(232, 201);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new Size(186, 111);
			this.guna2Panel4.TabIndex = 9;
			this.guna2Button5.AutoRoundedCorners = true;
			this.guna2Button5.BorderRadius = 13;
			this.guna2Button5.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button5.FillColor = Color.Cyan;
			this.guna2Button5.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button5.ForeColor = Color.Black;
			this.guna2Button5.Location = new Point(17, 62);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new Size(145, 29);
			this.guna2Button5.TabIndex = 15;
			this.guna2Button5.Text = "Spoof";
			this.guna2Button5.Click += this.guna2Button5_Click;
			this.pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new Point(127, 3);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(56, 40);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label5.ForeColor = Color.Cyan;
			this.label5.Location = new Point(13, 10);
			this.label5.Name = "label5";
			this.label5.Size = new Size(46, 21);
			this.label5.TabIndex = 2;
			this.label5.Text = "Rust";
			this.guna2Panel3.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel3.Controls.Add(this.guna2Button6);
			this.guna2Panel3.Controls.Add(this.pictureBox4);
			this.guna2Panel3.Controls.Add(this.label4);
			this.guna2Panel3.Location = new Point(8, 201);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new Size(200, 111);
			this.guna2Panel3.TabIndex = 7;
			this.guna2Button6.AutoRoundedCorners = true;
			this.guna2Button6.BorderRadius = 13;
			this.guna2Button6.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button6.FillColor = Color.Cyan;
			this.guna2Button6.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button6.ForeColor = Color.Black;
			this.guna2Button6.Location = new Point(26, 62);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new Size(145, 29);
			this.guna2Button6.TabIndex = 16;
			this.guna2Button6.Text = "Spoof";
			this.guna2Button6.Click += this.guna2Button6_Click;
			this.pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new Point(144, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(44, 46);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label4.ForeColor = Color.Cyan;
			this.label4.Location = new Point(13, 10);
			this.label4.Name = "label4";
			this.label4.Size = new Size(120, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Apex Legends";
			this.guna2Panel2.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel2.Controls.Add(this.guna2Button1);
			this.guna2Panel2.Controls.Add(this.pictureBox2);
			this.guna2Panel2.Controls.Add(this.label3);
			this.guna2Panel2.Location = new Point(232, 66);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new Size(186, 111);
			this.guna2Panel2.TabIndex = 8;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BorderRadius = 13;
			this.guna2Button1.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = Color.Cyan;
			this.guna2Button1.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button1.ForeColor = Color.Black;
			this.guna2Button1.Location = new Point(17, 58);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new Size(145, 29);
			this.guna2Button1.TabIndex = 12;
			this.guna2Button1.Text = "Spoof";
			this.guna2Button1.Click += this.guna2Button1_Click;
			this.pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(139, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(44, 42);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label3.ForeColor = Color.Cyan;
			this.label3.Location = new Point(13, 10);
			this.label3.Name = "label3";
			this.label3.Size = new Size(78, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valorant";
			this.guna2Panel1.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel1.Controls.Add(this.guna2Button3);
			this.guna2Panel1.Controls.Add(this.pictureBox3);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Location = new Point(8, 66);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new Size(200, 111);
			this.guna2Panel1.TabIndex = 6;
			this.guna2Button3.AutoRoundedCorners = true;
			this.guna2Button3.BorderRadius = 13;
			this.guna2Button3.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = Color.Cyan;
			this.guna2Button3.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button3.ForeColor = Color.Black;
			this.guna2Button3.Location = new Point(26, 58);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new Size(145, 29);
			this.guna2Button3.TabIndex = 11;
			this.guna2Button3.Text = "Spoof";
			this.guna2Button3.Click += this.guna2Button3_Click;
			this.pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(144, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(44, 42);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label2.ForeColor = Color.Cyan;
			this.label2.Location = new Point(13, 10);
			this.label2.Name = "label2";
			this.label2.Size = new Size(58, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "FiveM";
			this.guna2Panel5.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel5.Controls.Add(this.guna2Button2);
			this.guna2Panel5.Controls.Add(this.pictureBox1);
			this.guna2Panel5.Controls.Add(this.label7);
			this.guna2Panel5.Location = new Point(440, 66);
			this.guna2Panel5.Name = "guna2Panel5";
			this.guna2Panel5.Size = new Size(186, 111);
			this.guna2Panel5.TabIndex = 9;
			this.guna2Button2.AutoRoundedCorners = true;
			this.guna2Button2.BorderRadius = 13;
			this.guna2Button2.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = Color.Cyan;
			this.guna2Button2.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button2.ForeColor = Color.Black;
			this.guna2Button2.Location = new Point(17, 58);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new Size(145, 29);
			this.guna2Button2.TabIndex = 13;
			this.guna2Button2.Text = "Spoof";
			this.guna2Button2.Click += this.guna2Button2_Click;
			this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(128, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(55, 49);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label7.ForeColor = Color.Cyan;
			this.label7.Location = new Point(13, 10);
			this.label7.Name = "label7";
			this.label7.Size = new Size(57, 21);
			this.label7.TabIndex = 2;
			this.label7.Text = "CS GO";
			this.guna2Panel6.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel6.Controls.Add(this.guna2Button4);
			this.guna2Panel6.Controls.Add(this.pictureBox6);
			this.guna2Panel6.Controls.Add(this.label12);
			this.guna2Panel6.Location = new Point(440, 201);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new Size(186, 111);
			this.guna2Panel6.TabIndex = 10;
			this.guna2Button4.AutoRoundedCorners = true;
			this.guna2Button4.BorderRadius = 13;
			this.guna2Button4.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = Color.Cyan;
			this.guna2Button4.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button4.ForeColor = Color.Black;
			this.guna2Button4.Location = new Point(17, 62);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new Size(145, 29);
			this.guna2Button4.TabIndex = 14;
			this.guna2Button4.Text = "Spoof";
			this.guna2Button4.Click += this.guna2Button4_Click;
			this.pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			this.pictureBox6.Location = new Point(139, 3);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new Size(44, 40);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 4;
			this.pictureBox6.TabStop = false;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label12.ForeColor = Color.Cyan;
			this.label12.Location = new Point(13, 10);
			this.label12.Name = "label12";
			this.label12.Size = new Size(127, 21);
			this.label12.TabIndex = 2;
			this.label12.Text = "COD : Warzone";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.guna2Panel6);
			base.Controls.Add(this.guna2Panel5);
			base.Controls.Add(this.guna2Panel4);
			base.Controls.Add(this.guna2Panel3);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.label1);
			base.Name = "GameSpoofer";
			base.Size = new Size(638, 345);
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			((ISupportInitialize)this.pictureBox5).EndInit();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.guna2Panel5.ResumeLayout(false);
			this.guna2Panel5.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.guna2Panel6.ResumeLayout(false);
			this.guna2Panel6.PerformLayout();
			((ISupportInitialize)this.pictureBox6).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private IContainer components;

		// Token: 0x04000002 RID: 2
		private Label label1;

		// Token: 0x04000003 RID: 3
		private Guna2Panel guna2Panel4;

		// Token: 0x04000004 RID: 4
		private PictureBox pictureBox5;

		// Token: 0x04000005 RID: 5
		private Label label5;

		// Token: 0x04000006 RID: 6
		private Guna2Panel guna2Panel3;

		// Token: 0x04000007 RID: 7
		private PictureBox pictureBox4;

		// Token: 0x04000008 RID: 8
		private Label label4;

		// Token: 0x04000009 RID: 9
		private Guna2Panel guna2Panel2;

		// Token: 0x0400000A RID: 10
		private PictureBox pictureBox2;

		// Token: 0x0400000B RID: 11
		private Label label3;

		// Token: 0x0400000C RID: 12
		private Guna2Panel guna2Panel1;

		// Token: 0x0400000D RID: 13
		private PictureBox pictureBox3;

		// Token: 0x0400000E RID: 14
		private Label label2;

		// Token: 0x0400000F RID: 15
		private Guna2Panel guna2Panel5;

		// Token: 0x04000010 RID: 16
		private PictureBox pictureBox1;

		// Token: 0x04000011 RID: 17
		private Label label7;

		// Token: 0x04000012 RID: 18
		private Guna2Panel guna2Panel6;

		// Token: 0x04000013 RID: 19
		private PictureBox pictureBox6;

		// Token: 0x04000014 RID: 20
		private Label label12;

		// Token: 0x04000015 RID: 21
		private Guna2Button guna2Button5;

		// Token: 0x04000016 RID: 22
		private Guna2Button guna2Button6;

		// Token: 0x04000017 RID: 23
		private Guna2Button guna2Button1;

		// Token: 0x04000018 RID: 24
		private Guna2Button guna2Button3;

		// Token: 0x04000019 RID: 25
		private Guna2Button guna2Button2;

		// Token: 0x0400001A RID: 26
		private Guna2Button guna2Button4;
	}
}
