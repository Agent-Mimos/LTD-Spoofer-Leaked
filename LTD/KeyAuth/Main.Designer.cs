namespace KeyAuth
{
	// Token: 0x02000011 RID: 17
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00007D3D File Offset: 0x00005F3D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00007D64 File Offset: 0x00005F64
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.key = new global::System.Windows.Forms.Label();
			this.expiry = new global::System.Windows.Forms.Label();
			this.subscription = new global::System.Windows.Forms.Label();
			this.lastLogin = new global::System.Windows.Forms.Label();
			this.spoofer1 = new global::Loader.Spoofer();
			this.gameSpoofer1 = new global::Loader.GameSpoofer();
			this.dashboard1 = new global::KeyAuth.Dashboard();
			this.setting1 = new global::Loader.Setting();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this.pictureBox1;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(751, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, 0);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(706, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = 1;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, 0);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.panel1.Controls.Add(this.guna2Button4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.guna2Button3);
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.siticoneTransition1.SetDecoration(this.panel1, 0);
			this.panel1.Location = new global::System.Drawing.Point(-22, -8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(174, 592);
			this.panel1.TabIndex = 23;
			this.guna2Button4.BorderColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Button4.BorderRadius = 1;
			this.guna2Button4.BorderThickness = 1;
			this.siticoneTransition1.SetDecoration(this.guna2Button4, 0);
			this.guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = global::System.Drawing.Color.FromArgb(5, 5, 5);
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.Cyan;
			this.guna2Button4.Image = (global::System.Drawing.Image)resources.GetObject("guna2Button4.Image");
			this.guna2Button4.Location = new global::System.Drawing.Point(29, 299);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new global::System.Drawing.Size(142, 45);
			this.guna2Button4.TabIndex = 26;
			this.guna2Button4.Text = "Settings";
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.siticoneTransition1.SetDecoration(this.pictureBox1, 0);
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(22, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(152, 94);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.guna2Button3.BorderColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Button3.BorderThickness = 1;
			this.siticoneTransition1.SetDecoration(this.guna2Button3, 0);
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.Cyan;
			this.guna2Button3.Image = (global::System.Drawing.Image)resources.GetObject("guna2Button3.Image");
			this.guna2Button3.Location = new global::System.Drawing.Point(29, 236);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(142, 45);
			this.guna2Button3.TabIndex = 25;
			this.guna2Button3.Text = "System Spoofer";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.guna2Button2.BorderColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Button2.BorderThickness = 1;
			this.siticoneTransition1.SetDecoration(this.guna2Button2, 0);
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.Cyan;
			this.guna2Button2.Image = (global::System.Drawing.Image)resources.GetObject("guna2Button2.Image");
			this.guna2Button2.Location = new global::System.Drawing.Point(29, 175);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(142, 45);
			this.guna2Button2.TabIndex = 25;
			this.guna2Button2.Text = "Game Spoofer";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button1.BorderColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.guna2Button1.BorderThickness = 1;
			this.siticoneTransition1.SetDecoration(this.guna2Button1, 0);
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI Black", 10f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Cyan;
			this.guna2Button1.Image = (global::System.Drawing.Image)resources.GetObject("guna2Button1.Image");
			this.guna2Button1.Location = new global::System.Drawing.Point(29, 112);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(142, 45);
			this.guna2Button1.TabIndex = 24;
			this.guna2Button1.Text = "Dashboard";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.key.AutoSize = true;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.key, 0);
			this.key.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.key.ForeColor = global::System.Drawing.Color.White;
			this.key.Location = new global::System.Drawing.Point(219, 179);
			this.key.Name = "key";
			this.key.Size = new global::System.Drawing.Size(66, 15);
			this.key.TabIndex = 28;
			this.key.Text = "username";
			this.expiry.AutoSize = true;
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, 0);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.expiry.ForeColor = global::System.Drawing.Color.White;
			this.expiry.Location = new global::System.Drawing.Point(412, 179);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(66, 15);
			this.expiry.TabIndex = 29;
			this.expiry.Text = "username";
			this.subscription.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.subscription, 0);
			this.subscription.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.subscription.ForeColor = global::System.Drawing.Color.White;
			this.subscription.Location = new global::System.Drawing.Point(219, 321);
			this.subscription.Name = "subscription";
			this.subscription.Size = new global::System.Drawing.Size(66, 15);
			this.subscription.TabIndex = 30;
			this.subscription.Text = "username";
			this.lastLogin.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.lastLogin, 0);
			this.lastLogin.Font = new global::System.Drawing.Font("Segoe UI Black", 9f, global::System.Drawing.FontStyle.Bold);
			this.lastLogin.ForeColor = global::System.Drawing.Color.White;
			this.lastLogin.Location = new global::System.Drawing.Point(412, 321);
			this.lastLogin.Name = "lastLogin";
			this.lastLogin.Size = new global::System.Drawing.Size(66, 15);
			this.lastLogin.TabIndex = 31;
			this.lastLogin.Text = "username";
			this.spoofer1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.spoofer1, 0);
			this.spoofer1.Location = new global::System.Drawing.Point(158, 52);
			this.spoofer1.Name = "spoofer1";
			this.spoofer1.Size = new global::System.Drawing.Size(638, 345);
			this.spoofer1.TabIndex = 26;
			this.gameSpoofer1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.gameSpoofer1, 0);
			this.gameSpoofer1.Location = new global::System.Drawing.Point(158, 52);
			this.gameSpoofer1.Name = "gameSpoofer1";
			this.gameSpoofer1.Size = new global::System.Drawing.Size(638, 453);
			this.gameSpoofer1.TabIndex = 25;
			this.dashboard1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.dashboard1, 0);
			this.dashboard1.Location = new global::System.Drawing.Point(158, 52);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new global::System.Drawing.Size(638, 345);
			this.dashboard1.TabIndex = 24;
			this.setting1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.setting1, 0);
			this.setting1.Location = new global::System.Drawing.Point(158, 52);
			this.setting1.Name = "setting1";
			this.setting1.Size = new global::System.Drawing.Size(638, 345);
			this.setting1.TabIndex = 32;
			this.guna2BorderlessForm1.BorderRadius = 7;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(7, 7, 7);
			base.ClientSize = new global::System.Drawing.Size(800, 409);
			base.Controls.Add(this.setting1);
			base.Controls.Add(this.lastLogin);
			base.Controls.Add(this.subscription);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.key);
			base.Controls.Add(this.spoofer1);
			base.Controls.Add(this.gameSpoofer1);
			base.Controls.Add(this.dashboard1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, 1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.9;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007C RID: 124
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400007D RID: 125
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400007E RID: 126
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400007F RID: 127
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000080 RID: 128
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000082 RID: 130
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000085 RID: 133
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000086 RID: 134
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000087 RID: 135
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000089 RID: 137
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400008A RID: 138
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x0400008B RID: 139
		private global::KeyAuth.Dashboard dashboard1;

		// Token: 0x0400008C RID: 140
		private global::Loader.GameSpoofer gameSpoofer1;

		// Token: 0x0400008D RID: 141
		private global::Loader.Spoofer spoofer1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label expiry;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label key;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label lastLogin;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label subscription;

		// Token: 0x04000092 RID: 146
		private global::Loader.Setting setting1;
	}
}
