using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EclipticLauncher;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using RestSharp;

// Token: 0x0200000F RID: 15
public partial class Statchanger : Form
{
	// Token: 0x0600003E RID: 62 RVA: 0x000040DC File Offset: 0x000022DC
	public Statchanger()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000040FC File Offset: 0x000022FC
	protected virtual void WndProc(ref Message m)
	{
		int msg = m.Msg;
		int num = msg;
		if (num == 132)
		{
			base.WndProc(ref m);
			if ((int)m.Result == 1)
			{
				m.Result = (IntPtr)2;
			}
		}
		else
		{
			base.WndProc(ref m);
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00004148 File Offset: 0x00002348
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.youtube.com/watch?v=mq9qXeT8Y5g");
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00004160 File Offset: 0x00002360
	private void guna2GradientButton2_Click(object sender, EventArgs e)
	{
		Config_file.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://b608a37a-8fe4-4b25-aba3-031fa1df91ab.id.repl.co/endpoints/vbucks/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox2.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Vbucks As " + this.guna2TextBox2.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004254 File Offset: 0x00002454
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		Config_file.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://b608a37a-8fe4-4b25-aba3-031fa1df91ab.id.repl.co/endpoints/level/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox3.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Level As " + this.guna2TextBox3.Text + "!", null, null, null, null, null, null).AddText("Change a cosmetic or restart fn for this to show", null, null, null, null, null, null).Show();
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004348 File Offset: 0x00002548
	private void Statchanger_Load(object sender, EventArgs e)
	{
		this.guna2TextBox1.Text = Config_file.Default.Accid;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000436C File Offset: 0x0000256C
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004380 File Offset: 0x00002580
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004394 File Offset: 0x00002594
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000038 RID: 56
	private IContainer icontainer_0 = null;
}
