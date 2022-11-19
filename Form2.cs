using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

// Token: 0x02000012 RID: 18
public partial class Form2 : Form
{
	// Token: 0x0600005E RID: 94 RVA: 0x000053A0 File Offset: 0x000035A0
	public Form2()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000040FC File Offset: 0x000022FC
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

	// Token: 0x06000060 RID: 96 RVA: 0x000053C0 File Offset: 0x000035C0
	private void guna2Button3_Click(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
		foreach (Process process in processesByName)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Shadownite";
			Process process2 = new Process();
			ProcessStartInfo startInfo = process2.StartInfo;
			string format = "\"{0}\" \"{1}\"";
			object arg = process.Id;
			string text2 = text;
			startInfo.Arguments = string.Format(format, arg, ((text2 != null) ? text2.ToString() : null) + "\\Lawin\\uws.dll");
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.FileName = text + "\\Lawin/Injector.exe";
			process2.Start();
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00005478 File Offset: 0x00003678
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
		foreach (Process process in processesByName)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			Process process2 = new Process();
			ProcessStartInfo startInfo = process2.StartInfo;
			string format = "\"{0}\" \"{1}\"";
			object arg = process.Id;
			string text = currentDirectory;
			startInfo.Arguments = string.Format(format, arg, ((text != null) ? text.ToString() : null) + "\\Lawin\\raider.dll");
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.FileName = currentDirectory + "\\Lawin/Injector.exe";
			process2.Start();
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00005524 File Offset: 0x00003724
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
		foreach (Process process in processesByName)
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			Process process2 = new Process();
			ProcessStartInfo startInfo = process2.StartInfo;
			string format = "\"{0}\" \"{1}\"";
			object arg = process.Id;
			string text = currentDirectory;
			startInfo.Arguments = string.Format(format, arg, ((text != null) ? text.ToString() : null) + "\\Lawin\\nova.dll");
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.FileName = currentDirectory + "\\Lawin/Injector.exe";
			process2.Start();
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002B50 File Offset: 0x00000D50
	private void Form2_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000055D0 File Offset: 0x000037D0
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000043 RID: 67
	private IContainer icontainer_0 = null;
}
