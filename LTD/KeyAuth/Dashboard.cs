using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class Dashboard : UserControl
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00005242 File Offset: 0x00003442
		public Dashboard()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005250 File Offset: 0x00003450
		private void Dashboard_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005252 File Offset: 0x00003452
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005274 File Offset: 0x00003474
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Dashboard));
			this.label1 = new Label();
			this.guna2Panel1 = new Guna2Panel();
			this.pictureBox3 = new PictureBox();
			this.label2 = new Label();
			this.guna2Panel2 = new Guna2Panel();
			this.pictureBox2 = new PictureBox();
			this.label3 = new Label();
			this.guna2Panel3 = new Guna2Panel();
			this.pictureBox4 = new PictureBox();
			this.label4 = new Label();
			this.guna2Panel4 = new Guna2Panel();
			this.pictureBox5 = new PictureBox();
			this.label5 = new Label();
			this.guna2Panel5 = new Guna2Panel();
			this.label7 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label6 = new Label();
			this.guna2Panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			this.guna2Panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.guna2Panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			this.guna2Panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			this.guna2Panel5.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Segoe UI Black", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Cyan;
			this.label1.Location = new Point(20, 19);
			this.label1.Name = "label1";
			this.label1.Size = new Size(124, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dashboard";
			this.guna2Panel1.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel1.Controls.Add(this.pictureBox3);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Location = new Point(8, 66);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new Size(200, 111);
			this.guna2Panel1.TabIndex = 1;
			this.pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(153, 10);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(35, 33);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label2.ForeColor = Color.Cyan;
			this.label2.Location = new Point(13, 10);
			this.label2.Name = "label2";
			this.label2.Size = new Size(89, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username";
			this.guna2Panel2.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel2.Controls.Add(this.pictureBox2);
			this.guna2Panel2.Controls.Add(this.label3);
			this.guna2Panel2.Location = new Point(232, 66);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new Size(186, 111);
			this.guna2Panel2.TabIndex = 3;
			this.pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(139, 10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(35, 33);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label3.ForeColor = Color.Cyan;
			this.label3.Location = new Point(13, 10);
			this.label3.Name = "label3";
			this.label3.Size = new Size(60, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Expiry";
			this.guna2Panel3.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel3.Controls.Add(this.pictureBox4);
			this.guna2Panel3.Controls.Add(this.label4);
			this.guna2Panel3.Location = new Point(8, 201);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new Size(200, 111);
			this.guna2Panel3.TabIndex = 3;
			this.pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new Point(140, 10);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(48, 33);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label4.ForeColor = Color.Cyan;
			this.label4.Location = new Point(13, 10);
			this.label4.Name = "label4";
			this.label4.Size = new Size(109, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Subscription";
			this.guna2Panel4.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel4.Controls.Add(this.pictureBox5);
			this.guna2Panel4.Controls.Add(this.label5);
			this.guna2Panel4.Location = new Point(232, 201);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new Size(186, 111);
			this.guna2Panel4.TabIndex = 4;
			this.pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new Point(139, 10);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(35, 33);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Segoe UI Black", 12f, FontStyle.Bold);
			this.label5.ForeColor = Color.Cyan;
			this.label5.Location = new Point(13, 10);
			this.label5.Name = "label5";
			this.label5.Size = new Size(91, 21);
			this.label5.TabIndex = 2;
			this.label5.Text = "Last Login";
			this.guna2Panel5.BackColor = Color.FromArgb(10, 10, 10);
			this.guna2Panel5.Controls.Add(this.label7);
			this.guna2Panel5.Controls.Add(this.pictureBox1);
			this.guna2Panel5.Controls.Add(this.label6);
			this.guna2Panel5.Location = new Point(439, 66);
			this.guna2Panel5.Name = "guna2Panel5";
			this.guna2Panel5.Size = new Size(196, 246);
			this.guna2Panel5.TabIndex = 5;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(13, 62);
			this.label7.Name = "label7";
			this.label7.Size = new Size(157, 105);
			this.label7.TabIndex = 40;
			this.label7.Text = "To Be Updated\r\nCheck our\r\nDiscord server\r\nFor the new\r\nUpdates \r\nFrom this link :\r\ndiscord.gg/Ke4gDnRkDK";
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
			this.label6.Size = new Size(75, 21);
			this.label6.TabIndex = 2;
			this.label6.Text = "Updates";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.guna2Panel5);
			base.Controls.Add(this.guna2Panel4);
			base.Controls.Add(this.guna2Panel3);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.label1);
			base.Name = "Dashboard";
			base.Size = new Size(638, 345);
			base.Load += this.Dashboard_Load;
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			((ISupportInitialize)this.pictureBox4).EndInit();
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			((ISupportInitialize)this.pictureBox5).EndInit();
			this.guna2Panel5.ResumeLayout(false);
			this.guna2Panel5.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000033 RID: 51
		private IContainer components;

		// Token: 0x04000034 RID: 52
		private Label label1;

		// Token: 0x04000035 RID: 53
		private Guna2Panel guna2Panel1;

		// Token: 0x04000036 RID: 54
		private Label label2;

		// Token: 0x04000037 RID: 55
		private Guna2Panel guna2Panel2;

		// Token: 0x04000038 RID: 56
		private Label label3;

		// Token: 0x04000039 RID: 57
		private Guna2Panel guna2Panel3;

		// Token: 0x0400003A RID: 58
		private Label label4;

		// Token: 0x0400003B RID: 59
		private Guna2Panel guna2Panel4;

		// Token: 0x0400003C RID: 60
		private Label label5;

		// Token: 0x0400003D RID: 61
		private Guna2Panel guna2Panel5;

		// Token: 0x0400003E RID: 62
		private Label label6;

		// Token: 0x0400003F RID: 63
		private PictureBox pictureBox1;

		// Token: 0x04000040 RID: 64
		private PictureBox pictureBox2;

		// Token: 0x04000041 RID: 65
		private PictureBox pictureBox3;

		// Token: 0x04000042 RID: 66
		private PictureBox pictureBox4;

		// Token: 0x04000043 RID: 67
		private PictureBox pictureBox5;

		// Token: 0x04000044 RID: 68
		private Label label7;
	}
}
