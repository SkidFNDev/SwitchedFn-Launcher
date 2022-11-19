using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000010 RID: 16
public class GClass0
{
	// Token: 0x06000049 RID: 73
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_0);

	// Token: 0x0600004A RID: 74
	[DllImport("kernel32.dll")]
	public static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2, IntPtr intptr_3, uint uint_1, IntPtr intptr_4);

	// Token: 0x0600004B RID: 75
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string string_0);

	// Token: 0x0600004C RID: 76
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	// Token: 0x0600004D RID: 77 RVA: 0x00005170 File Offset: 0x00003370
	public static void smethod_0(int int_0, string string_0)
	{
		IntPtr intptr_ = GClass0.OpenProcess(1082, false, int_0);
		IntPtr procAddress = GClass0.GetProcAddress(GClass0.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
		uint uint_ = (uint)((string_0.Length + 1) * Marshal.SizeOf(typeof(char)));
		IntPtr intPtr = GClass0.VirtualAllocEx(intptr_, IntPtr.Zero, uint_, 12288U, 4U);
		UIntPtr uintPtr;
		GClass0.WriteProcessMemory(intptr_, intPtr, Encoding.Default.GetBytes(string_0), uint_, out uintPtr);
		GClass0.CreateRemoteThread(intptr_, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
	}

	// Token: 0x0600004E RID: 78
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	// Token: 0x0600004F RID: 79
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(int int_0, bool bool_0, int int_1);

	// Token: 0x06000050 RID: 80
	[DllImport("kernel32.dll")]
	public static extern int ResumeThread(IntPtr intptr_0);

	// Token: 0x06000051 RID: 81 RVA: 0x000051FC File Offset: 0x000033FC
	public static Process smethod_1(string string_0, bool bool_0, string string_1 = "")
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				FileName = string_0,
				Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=f7b9gah4h5380d10f721dd6a " + string_1
			}
		};
		process.Start();
		if (bool_0)
		{
			foreach (object obj in process.Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				GClass0.SuspendThread(GClass0.OpenThread(2, false, processThread.Id));
			}
		}
		return process;
	}

	// Token: 0x06000052 RID: 82
	[DllImport("kernel32.dll")]
	public static extern int SuspendThread(IntPtr intptr_0);

	// Token: 0x06000053 RID: 83
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2);

	// Token: 0x06000054 RID: 84
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, out UIntPtr uintptr_0);
}
