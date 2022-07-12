using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Loader
{
	// Token: 0x02000004 RID: 4
	public class Spoofer : UserControl
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000040A8 File Offset: 0x000022A8
		public Spoofer()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000040B6 File Offset: 0x000022B6
		private void Spoofer_Load(object sender, EventArgs e)
		{
			this.start.Hide();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000040C3 File Offset: 0x000022C3
		private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
		{
			this.start.Show();
			this.guna2Button4.Hide();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000040DB File Offset: 0x000022DB
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nothing Selected !");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000040E8 File Offset: 0x000022E8
		private void start_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Spoofed Succesfuly");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000040F5 File Offset: 0x000022F5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004114 File Offset: 0x00002314
		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.guna2Panel6 = new Guna2Panel();
			this.start = new Guna2Button();
			this.guna2Button4 = new Guna2Button();
			this.guna2Panel1 = new Guna2Panel();
			this.guna2ToggleSwitch6 = new Guna2ToggleSwitch();
			this.guna2ToggleSwitch5 = new Guna2ToggleSwitch();
			this.guna2ToggleSwitch4 = new Guna2ToggleSwitch();
			this.guna2ToggleSwitch3 = new Guna2ToggleSwitch();
			this.guna2ToggleSwitch2 = new Guna2ToggleSwitch();
			this.guna2ToggleSwitch1 = new Guna2ToggleSwitch();
			this.label12 = new Label();
			this.label5 = new Label();
			this.label7 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label2 = new Label();
			this.guna2Panel6.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Cyan;
			this.label1.Location = new Point(20, 19);
			this.label1.Name = "label1";
			this.label1.Size = new Size(175, 30);
			this.label1.TabIndex = 11;
			this.label1.Text = "System Spoofer";
			this.guna2Panel6.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel6.Controls.Add(this.start);
			this.guna2Panel6.Controls.Add(this.guna2Button4);
			this.guna2Panel6.Location = new Point(337, 109);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new Size(186, 145);
			this.guna2Panel6.TabIndex = 19;
			this.start.AutoRoundedCorners = true;
			this.start.BorderRadius = 13;
			this.start.DisabledState.BorderColor = Color.DarkGray;
			this.start.DisabledState.CustomBorderColor = Color.DarkGray;
			this.start.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.start.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.start.FillColor = Color.Cyan;
			this.start.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.start.ForeColor = Color.Black;
			this.start.Location = new Point(21, 60);
			this.start.Name = "start";
			this.start.Size = new Size(145, 29);
			this.start.TabIndex = 19;
			this.start.Text = "Start";
			this.start.Click += this.start_Click_1;
			this.guna2Button4.AutoRoundedCorners = true;
			this.guna2Button4.BorderRadius = 13;
			this.guna2Button4.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = Color.Cyan;
			this.guna2Button4.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.guna2Button4.ForeColor = Color.Black;
			this.guna2Button4.Location = new Point(21, 60);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new Size(145, 29);
			this.guna2Button4.TabIndex = 18;
			this.guna2Button4.Text = "Apply";
			this.guna2Button4.Click += this.guna2Button4_Click;
			this.guna2Panel1.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch6);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch5);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch4);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch3);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch2);
			this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch1);
			this.guna2Panel1.Controls.Add(this.label12);
			this.guna2Panel1.Controls.Add(this.label5);
			this.guna2Panel1.Controls.Add(this.label7);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.label4);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Location = new Point(8, 66);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new Size(269, 246);
			this.guna2Panel1.TabIndex = 18;
			this.guna2ToggleSwitch6.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch6.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch6.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch6.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch6.Location = new Point(194, 208);
			this.guna2ToggleSwitch6.Name = "guna2ToggleSwitch6";
			this.guna2ToggleSwitch6.Size = new Size(35, 20);
			this.guna2ToggleSwitch6.TabIndex = 7;
			this.guna2ToggleSwitch6.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch6.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch6.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch6.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch6.CheckedChanged += this.guna2ToggleSwitch6_CheckedChanged;
			this.guna2ToggleSwitch5.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch5.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch5.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch5.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch5.Location = new Point(194, 167);
			this.guna2ToggleSwitch5.Name = "guna2ToggleSwitch5";
			this.guna2ToggleSwitch5.Size = new Size(35, 20);
			this.guna2ToggleSwitch5.TabIndex = 6;
			this.guna2ToggleSwitch5.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch5.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch5.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch5.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch5.CheckedChanged += this.guna2ToggleSwitch5_CheckedChanged;
			this.guna2ToggleSwitch4.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch4.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch4.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch4.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch4.Location = new Point(194, 129);
			this.guna2ToggleSwitch4.Name = "guna2ToggleSwitch4";
			this.guna2ToggleSwitch4.Size = new Size(35, 20);
			this.guna2ToggleSwitch4.TabIndex = 5;
			this.guna2ToggleSwitch4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch4.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch4.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch4.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch4.CheckedChanged += this.guna2ToggleSwitch4_CheckedChanged;
			this.guna2ToggleSwitch3.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch3.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch3.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch3.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch3.Location = new Point(194, 89);
			this.guna2ToggleSwitch3.Name = "guna2ToggleSwitch3";
			this.guna2ToggleSwitch3.Size = new Size(35, 20);
			this.guna2ToggleSwitch3.TabIndex = 4;
			this.guna2ToggleSwitch3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch3.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch3.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch3.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch3.CheckedChanged += this.guna2ToggleSwitch3_CheckedChanged;
			this.guna2ToggleSwitch2.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch2.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch2.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch2.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch2.Location = new Point(194, 51);
			this.guna2ToggleSwitch2.Name = "guna2ToggleSwitch2";
			this.guna2ToggleSwitch2.Size = new Size(35, 20);
			this.guna2ToggleSwitch2.TabIndex = 3;
			this.guna2ToggleSwitch2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch2.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch2.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch2.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch2.CheckedChanged += this.guna2ToggleSwitch2_CheckedChanged;
			this.guna2ToggleSwitch1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch1.CheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch1.Location = new Point(194, 11);
			this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
			this.guna2ToggleSwitch1.Size = new Size(35, 20);
			this.guna2ToggleSwitch1.TabIndex = 0;
			this.guna2ToggleSwitch1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White;
			this.guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White;
			this.guna2ToggleSwitch1.CheckedChanged += this.guna2ToggleSwitch1_CheckedChanged;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label12.ForeColor = Color.Cyan;
			this.label12.Location = new Point(51, 208);
			this.label12.Name = "label12";
			this.label12.Size = new Size(99, 21);
			this.label12.TabIndex = 2;
			this.label12.Text = "DeviceGuid";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label5.ForeColor = Color.Cyan;
			this.label5.Location = new Point(51, 167);
			this.label5.Name = "label5";
			this.label5.Size = new Size(86, 21);
			this.label5.TabIndex = 2;
			this.label5.Text = "WMIGuid";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label7.ForeColor = Color.Cyan;
			this.label7.Location = new Point(51, 128);
			this.label7.Name = "label7";
			this.label7.Size = new Size(88, 21);
			this.label7.TabIndex = 2;
			this.label7.Text = "VolumeID";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label3.ForeColor = Color.Cyan;
			this.label3.Location = new Point(51, 88);
			this.label3.Name = "label3";
			this.label3.Size = new Size(130, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "HardwareGUID";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label4.ForeColor = Color.Cyan;
			this.label4.Location = new Point(51, 50);
			this.label4.Name = "label4";
			this.label4.Size = new Size(90, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "ProductID";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label2.ForeColor = Color.Cyan;
			this.label2.Location = new Point(51, 10);
			this.label2.Name = "label2";
			this.label2.Size = new Size(99, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "MACadress";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.guna2Panel6);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.label1);
			base.Name = "Spoofer";
			base.Size = new Size(638, 345);
			base.Load += this.Spoofer_Load;
			this.guna2Panel6.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000021 RID: 33
		private IContainer components;

		// Token: 0x04000022 RID: 34
		private Label label1;

		// Token: 0x04000023 RID: 35
		private Guna2Panel guna2Panel6;

		// Token: 0x04000024 RID: 36
		private Guna2Button start;

		// Token: 0x04000025 RID: 37
		private Guna2Button guna2Button4;

		// Token: 0x04000026 RID: 38
		private Guna2Panel guna2Panel1;

		// Token: 0x04000027 RID: 39
		private Guna2ToggleSwitch guna2ToggleSwitch6;

		// Token: 0x04000028 RID: 40
		private Guna2ToggleSwitch guna2ToggleSwitch5;

		// Token: 0x04000029 RID: 41
		private Guna2ToggleSwitch guna2ToggleSwitch4;

		// Token: 0x0400002A RID: 42
		private Guna2ToggleSwitch guna2ToggleSwitch3;

		// Token: 0x0400002B RID: 43
		private Guna2ToggleSwitch guna2ToggleSwitch2;

		// Token: 0x0400002C RID: 44
		private Guna2ToggleSwitch guna2ToggleSwitch1;

		// Token: 0x0400002D RID: 45
		private Label label12;

		// Token: 0x0400002E RID: 46
		private Label label5;

		// Token: 0x0400002F RID: 47
		private Label label7;

		// Token: 0x04000030 RID: 48
		private Label label3;

		// Token: 0x04000031 RID: 49
		private Label label4;

		// Token: 0x04000032 RID: 50
		private Label label2;
	}
}
