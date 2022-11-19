// Token: 0x0200001C RID: 28
public partial class option : global::System.Windows.Forms.Form
{
	// Token: 0x060000A5 RID: 165 RVA: 0x00007418 File Offset: 0x00005618
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::option));
		this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
		this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
		this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
		this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
		base.SuspendLayout();
		this.guna2Panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Panel1.BackgroundImage");
		this.guna2Panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
		this.guna2Panel1.Location = new global::System.Drawing.Point(152, 12);
		this.guna2Panel1.Name = "guna2Panel1";
		this.guna2Panel1.Size = new global::System.Drawing.Size(472, 174);
		this.guna2Panel1.TabIndex = 0;
		this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Transparent;
		this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Segoe UI", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.guna2HtmlLabel1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
		this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(200, 192);
		this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
		this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(379, 42);
		this.guna2HtmlLabel1.TabIndex = 1;
		this.guna2HtmlLabel1.Text = "What would you like to do?";
		this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button2.FillColor = global::System.Drawing.Color.White;
		this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.guna2Button2.ForeColor = global::System.Drawing.Color.Black;
		this.guna2Button2.Location = new global::System.Drawing.Point(209, 257);
		this.guna2Button2.Name = "guna2Button2";
		this.guna2Button2.Size = new global::System.Drawing.Size(117, 97);
		this.guna2Button2.TabIndex = 5;
		this.guna2Button2.Text = "Launch Fortnite";
		this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
		this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button1.FillColor = global::System.Drawing.Color.White;
		this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.guna2Button1.ForeColor = global::System.Drawing.Color.Black;
		this.guna2Button1.Location = new global::System.Drawing.Point(462, 257);
		this.guna2Button1.Name = "guna2Button1";
		this.guna2Button1.Size = new global::System.Drawing.Size(117, 97);
		this.guna2Button1.TabIndex = 6;
		this.guna2Button1.Text = "Host Games";
		this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.Black;
		base.ClientSize = new global::System.Drawing.Size(800, 450);
		base.Controls.Add(this.guna2Button1);
		base.Controls.Add(this.guna2Button2);
		base.Controls.Add(this.guna2HtmlLabel1);
		base.Controls.Add(this.guna2Panel1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Name = "option";
		this.Text = "option";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000068 RID: 104
	private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

	// Token: 0x04000069 RID: 105
	private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

	// Token: 0x0400006A RID: 106
	private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

	// Token: 0x0400006B RID: 107
	private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
}
