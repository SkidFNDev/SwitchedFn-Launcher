using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

// Token: 0x0200001C RID: 28
public partial class option : Form
{
	// Token: 0x060000A1 RID: 161 RVA: 0x000073A8 File Offset: 0x000055A8
	public option()
	{
		this.InitializeComponent();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000073C8 File Offset: 0x000055C8
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		form.Show();
		base.Hide();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002B50 File Offset: 0x00000D50
	private void guna2Button2_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000073E8 File Offset: 0x000055E8
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000067 RID: 103
	private IContainer icontainer_0 = null;
}
