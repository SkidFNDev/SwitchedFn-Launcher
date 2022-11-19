using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Management.Automation;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using EclipticLauncher;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.WindowsAPICodePack.Dialogs;

// Token: 0x0200001B RID: 27
public partial class Form1 : Form
{
	// Token: 0x06000090 RID: 144 RVA: 0x00006368 File Offset: 0x00004568
	public Form1()
	{
		this.InitializeComponent();
		this.gstruct0_0 = default(GClass1.GStruct0);
		GClass1.Discord_Initialize("1030054598372773910", ref this.gstruct0_0, true, null);
		this.gstruct0_0 = default(GClass1.GStruct0);
		GClass1.Discord_Initialize("1030054598372773910", ref this.gstruct0_0, true, null);
		this.gstruct1_0.details = "SwitchedFN";
		this.gstruct1_0.state = "dsc.gg/SwitchedFN";
		this.gstruct1_0.largeImageKey = "linux_png";
		this.gstruct1_0.smallImageKey = "linux_png";
		GClass1.Discord_UpdatePresence(ref this.gstruct1_0);
		string str = "system*";
		using (PowerShell powerShell = PowerShell.Create())
		{
			powerShell.AddScript("Set-Service 'BEService' -StartupType Disabled" + str);
			powerShell.AddScript("Set-Service 'EasyAntiCheat' -StartupType Disabled" + str);
			powerShell.Invoke();
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000040FC File Offset: 0x000022FC
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

	// Token: 0x06000092 RID: 146 RVA: 0x00006464 File Offset: 0x00004664
	public void method_0(string string_0)
	{
		MessageBox.Show(string_0, "Ecliptic");
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00006480 File Offset: 0x00004680
	private void method_1(object sender, EventArgs e)
	{
		string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
		if (!File.Exists(str + "\\s13\\s13.exe"))
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1019134010213011466/1030917253677465660/s13.zip", str + "\\S13\\test.zip");
			ZipFile.ExtractToDirectory(str + "\\S13\\test.zip", str + "\\S13");
		}
		Process.Start(str + "\\S13\\s13.exe");
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002B50 File Offset: 0x00000D50
	private void Form1_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000064FC File Offset: 0x000046FC
	private void method_2(object sender, EventArgs e)
	{
		option option = new option();
		base.Hide();
		option.Show();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000651C File Offset: 0x0000471C
	private void method_3(object sender, EventArgs e)
	{
		string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
		if (!File.Exists(str + "\\Lawin\\dev.exe"))
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1020740735756148810/1030047242670833684/Testing.zip", str + "\\Lawin\\test.zip");
			ZipFile.ExtractToDirectory(str + "\\Lawin\\test.zip", str + "\\Lawin");
		}
		Process.Start(str + "\\Lawin\\dev.exe");
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00006598 File Offset: 0x00004798
	private void guna2Button4_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00004380 File Offset: 0x00002580
	private void guna2Button5_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000065AC File Offset: 0x000047AC
	private void guna2GradientButton2_Click(object sender, EventArgs e)
	{
		string tempPath = Path.GetTempPath();
		Directory.GetCurrentDirectory() + "\\";
		string arg = Directory.GetCurrentDirectory() + "\\Switched.dll";
		WebClient webClient = new WebClient();
		base.Hide();
		if (!File.Exists(tempPath + "/Inject.exe"))
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1032986535273967696/1033439324609462362/Injector.exe", tempPath + "/Inject.exe");
		}
		Config_file.Default.Path = this.guna2TextBox2.Text;
		string text = Class6.smethod_1(Class6.smethod_0());
		string[] array = text.Split(new char[]
		{
			','
		}, 2);
		if (!text.Contains("error"))
		{
			string str = array[1];
			string string_ = array[0];
			string str2 = Class6.smethod_3(string_);
			new ToastContentBuilder().AddText("Successfully logged in as " + str + "!", null, null, null, null, null, null).AddText("Going into fortnite...", null, null, null, null, null, null).Show();
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = Config_file.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe",
				Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=919348d6add4c4c7c7507e61"
			});
			process.smethod_2();
			Process process2 = Process.Start(new ProcessStartInfo
			{
				FileName = Config_file.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe",
				Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=919348d6add4c4c7c7507e61"
			});
			process2.smethod_2();
			Process process3 = Process.Start(new ProcessStartInfo
			{
				FileName = Config_file.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe",
				Arguments = string.Concat(new string[]
				{
					"-AUTH_LOGIN=unused -AUTH_PASSWORD=" + str2 + " -AUTH_TYPE=exchangecode  -AUTH_PASSWORD=unused -AUTH_TYPE=epic -epicapp=Fortnite -epicportal -noeac -fromfl=be -fltoken=020912211c40g052474d02f1 -skippatchcheck -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ"
				})
			});
			base.Hide();
			process3.WaitForInputIdle();
			new Process
			{
				StartInfo = 
				{
					Arguments = string.Format("\"{0}\" \"{1}\"", process3.Id, arg),
					CreateNoWindow = true,
					UseShellExecute = false,
					FileName = tempPath + "/Inject.exe"
				}
			}.Start();
			Thread.Sleep(30000);
			Thread.Sleep(1000);
			process3.WaitForExit();
			base.Show();
			Process.Start("taskkill", "/f /pid " + process.Id.ToString());
			Process.Start("taskkill", "/f /pid " + process2.Id.ToString());
			Process.Start("taskkill", "/f /im node.exe");
			Process.Start("taskkill", "/f /im cmd.exe");
			Process.Start("taskkill", "/f /im conhost.exe");
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002B50 File Offset: 0x00000D50
	private void method_4(object sender, EventArgs e)
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000068C8 File Offset: 0x00004AC8
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		MessageBox.Show("You found a premium feature, get premium for access");
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000068E0 File Offset: 0x00004AE0
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		commonOpenFileDialog.IsFolderPicker = true;
		if (commonOpenFileDialog.ShowDialog() == 1)
		{
			this.guna2TextBox2.Text = commonOpenFileDialog.FileName;
		}
		if (!Directory.Exists(this.guna2TextBox2.Text + "\\FortniteGame"))
		{
			MessageBox.Show("Invalid path! Please input valid path that contains \"FortniteGame\" and \"Engine\"");
			this.guna2TextBox2.Text = string.Empty;
		}
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002B50 File Offset: 0x00000D50
	private void guna2TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002B50 File Offset: 0x00000D50
	private void method_5(object sender, EventArgs e)
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00006950 File Offset: 0x00004B50
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0400005C RID: 92
	private GClass1.GStruct0 gstruct0_0;

	// Token: 0x0400005D RID: 93
	private GClass1.GStruct1 gstruct1_0;
}
