using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Loader
{
	// Token: 0x02000003 RID: 3
	public class Setting : UserControl
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00003CAC File Offset: 0x00001EAC
		public Setting()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003CBA File Offset: 0x00001EBA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003CDC File Offset: 0x00001EDC
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Setting));
			this.label1 = new Label();
			this.guna2Panel5 = new Guna2Panel();
			this.label7 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label6 = new Label();
			this.guna2Panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Cyan;
			this.label1.Location = new Point(20, 19);
			this.label1.Name = "label1";
			this.label1.Size = new Size(97, 30);
			this.label1.TabIndex = 12;
			this.label1.Text = "Settings";
			this.guna2Panel5.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel5.Controls.Add(this.pictureBox1);
			this.guna2Panel5.Controls.Add(this.label7);
			this.guna2Panel5.Controls.Add(this.label6);
			this.guna2Panel5.Location = new Point(25, 77);
			this.guna2Panel5.Name = "guna2Panel5";
			this.guna2Panel5.Size = new Size(196, 246);
			this.guna2Panel5.TabIndex = 6;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(14, 58);
			this.label7.Name = "label7";
			this.label7.Size = new Size(157, 105);
			this.label7.TabIndex = 40;
			this.label7.Text = "If you changed\r\nYour pc windows\r\nBuild or cpu \r\nor gpu Please\r\nContact Us\r\nFrom this link :\r\ndiscord.gg/Ke4gDnRkDK";
			this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(147, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(35, 33);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label6.ForeColor = Color.Cyan;
			this.label6.Location = new Point(13, 10);
			this.label6.Name = "label6";
			this.label6.Size = new Size(100, 21);
			this.label6.TabIndex = 2;
			this.label6.Text = "Hwid Reset";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.guna2Panel5);
			base.Controls.Add(this.label1);
			base.Name = "Setting";
			base.Size = new Size(638, 345);
			this.guna2Panel5.ResumeLayout(false);
			this.guna2Panel5.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001B RID: 27
		private IContainer components;

		// Token: 0x0400001C RID: 28
		private Label label1;

		// Token: 0x0400001D RID: 29
		private Guna2Panel guna2Panel5;

		// Token: 0x0400001E RID: 30
		private PictureBox pictureBox1;

		// Token: 0x0400001F RID: 31
		private Label label7;

		// Token: 0x04000020 RID: 32
		private Label label6;
	}
}
