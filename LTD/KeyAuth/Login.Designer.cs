namespace KeyAuth
{
	// Token: 0x02000012 RID: 18
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00009391 File Offset: 0x00007591
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000093B8 File Offset: 0x000075B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation2 = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.key = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.LoginBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.RgstrBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2PictureBox1.BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(718, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, 1);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.Black;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(672, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = 1;
			this.siticoneTransition1.Cursor = null;
			animation2.AnimateOnlyDifferences = true;
			animation2.BlindCoeff = (global::System.Drawing.PointF)resources.GetObject("animation2.BlindCoeff");
			animation2.LeafCoeff = 0f;
			animation2.MaxTime = 1f;
			animation2.MinTime = 0f;
			animation2.MosaicCoeff = (global::System.Drawing.PointF)resources.GetObject("animation2.MosaicCoeff");
			animation2.MosaicShift = (global::System.Drawing.PointF)resources.GetObject("animation2.MosaicShift");
			animation2.MosaicSize = 0;
			animation2.Padding = new global::System.Windows.Forms.Padding(50);
			animation2.RotateCoeff = 1f;
			animation2.RotateLimit = 0f;
			animation2.ScaleCoeff = (global::System.Drawing.PointF)resources.GetObject("animation2.ScaleCoeff");
			animation2.SlideCoeff = (global::System.Drawing.PointF)resources.GetObject("animation2.SlideCoeff");
			animation2.TimeCoeff = 0f;
			animation2.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation2;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, 0);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.username.AutoRoundedCorners = true;
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.username.BorderRadius = 16;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.username, 0);
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.username.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.username.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.Location = new global::System.Drawing.Point(401, 75);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.username.PlaceholderText = "username";
			this.username.SelectedText = "";
			this.username.Size = new global::System.Drawing.Size(344, 35);
			this.username.TabIndex = 37;
			this.password.AutoRoundedCorners = true;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.password.BorderRadius = 17;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.password, 0);
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.password.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.password.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.Location = new global::System.Drawing.Point(401, 128);
			this.password.Name = "password";
			this.password.PasswordChar = '\0';
			this.password.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.password.PlaceholderText = "password";
			this.password.SelectedText = "";
			this.password.Size = new global::System.Drawing.Size(344, 37);
			this.password.TabIndex = 38;
			this.key.AutoRoundedCorners = true;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.key.BorderRadius = 17;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.key, 0);
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(230, 230, 230);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.key.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.key.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.Location = new global::System.Drawing.Point(401, 182);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.key.PlaceholderText = "key";
			this.key.SelectedText = "";
			this.key.Size = new global::System.Drawing.Size(344, 37);
			this.key.TabIndex = 39;
			this.LoginBtn.AutoRoundedCorners = true;
			this.LoginBtn.BorderRadius = 14;
			this.siticoneTransition1.SetDecoration(this.LoginBtn, 0);
			this.LoginBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LoginBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.LoginBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LoginBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.LoginBtn.FillColor = global::System.Drawing.Color.Cyan;
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.Black;
			this.LoginBtn.Location = new global::System.Drawing.Point(624, 225);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new global::System.Drawing.Size(121, 30);
			this.LoginBtn.TabIndex = 40;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click_1);
			this.RgstrBtn.AutoRoundedCorners = true;
			this.RgstrBtn.BorderRadius = 14;
			this.siticoneTransition1.SetDecoration(this.RgstrBtn, 0);
			this.RgstrBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.RgstrBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.RgstrBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.RgstrBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.RgstrBtn.FillColor = global::System.Drawing.Color.Cyan;
			this.RgstrBtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.RgstrBtn.ForeColor = global::System.Drawing.Color.Black;
			this.RgstrBtn.Location = new global::System.Drawing.Point(401, 274);
			this.RgstrBtn.Name = "RgstrBtn";
			this.RgstrBtn.Size = new global::System.Drawing.Size(344, 30);
			this.RgstrBtn.TabIndex = 41;
			this.RgstrBtn.Text = "Register LTD Spoofer account";
			this.RgstrBtn.Click += new global::System.EventHandler(this.RgstrBtn_Click_1);
			this.siticoneTransition1.SetDecoration(this.guna2PictureBox1, 0);
			this.guna2PictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("guna2PictureBox1.Image");
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(42, 40);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(304, 261);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.guna2PictureBox1);
			this.siticoneTransition1.SetDecoration(this.panel1, 0);
			this.panel1.Location = new global::System.Drawing.Point(-15, -15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(389, 485);
			this.panel1.TabIndex = 36;
			this.guna2BorderlessForm1.BorderRadius = 7;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(767, 335);
			base.Controls.Add(this.RgstrBtn);
			base.Controls.Add(this.key);
			base.Controls.Add(this.password);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.username);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, 1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Login";
			base.Opacity = 0.9;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			this.guna2PictureBox1.EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000094 RID: 148
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000095 RID: 149
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000096 RID: 150
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000097 RID: 151
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000099 RID: 153
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400009A RID: 154
		private global::Guna.UI2.WinForms.Guna2Button RgstrBtn;

		// Token: 0x0400009B RID: 155
		private global::Guna.UI2.WinForms.Guna2Button LoginBtn;

		// Token: 0x0400009C RID: 156
		private global::Guna.UI2.WinForms.Guna2TextBox key;

		// Token: 0x0400009D RID: 157
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x0400009E RID: 158
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x0400009F RID: 159
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A1 RID: 161
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
	}
}
