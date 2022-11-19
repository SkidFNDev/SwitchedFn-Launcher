using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

// Token: 0x0200000D RID: 13
internal static class Class5
{
	// Token: 0x06000038 RID: 56 RVA: 0x00003FD0 File Offset: 0x000021D0
	public static void smethod_0(string string_0, string string_1)
	{
		new WebClient().DownloadFile(string_0, string_1);
	}

	// Token: 0x06000039 RID: 57
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(Class5.Enum0 enum0_0, bool bool_0, uint uint_0);

	// Token: 0x0600003A RID: 58 RVA: 0x00003FEC File Offset: 0x000021EC
	public static void smethod_1(this Process process_0)
	{
		foreach (object obj in process_0.Threads)
		{
			ProcessThread processThread = (ProcessThread)obj;
			IntPtr intPtr = Class5.OpenThread(Class5.Enum0.SUSPEND_RESUME, false, (uint)processThread.Id);
			if (intPtr == IntPtr.Zero)
			{
				break;
			}
			Class5.ResumeThread(intPtr);
		}
	}

	// Token: 0x0600003B RID: 59
	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr intptr_0);

	// Token: 0x0600003C RID: 60 RVA: 0x00004064 File Offset: 0x00002264
	public static void smethod_2(this Process process_0)
	{
		foreach (object obj in process_0.Threads)
		{
			ProcessThread processThread = (ProcessThread)obj;
			IntPtr intPtr = Class5.OpenThread(Class5.Enum0.SUSPEND_RESUME, false, (uint)processThread.Id);
			if (intPtr == IntPtr.Zero)
			{
				break;
			}
			Class5.SuspendThread(intPtr);
		}
	}

	// Token: 0x0600003D RID: 61
	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x0200000E RID: 14
	[Flags]
	public enum Enum0
	{
		// Token: 0x0400002F RID: 47
		TERMINATE = 1,
		// Token: 0x04000030 RID: 48
		SUSPEND_RESUME = 2,
		// Token: 0x04000031 RID: 49
		GET_CONTEXT = 8,
		// Token: 0x04000032 RID: 50
		SET_CONTEXT = 16,
		// Token: 0x04000033 RID: 51
		SET_INFORMATION = 32,
		// Token: 0x04000034 RID: 52
		QUERY_INFORMATION = 64,
		// Token: 0x04000035 RID: 53
		SET_THREAD_TOKEN = 128,
		// Token: 0x04000036 RID: 54
		IMPERSONATE = 256,
		// Token: 0x04000037 RID: 55
		DIRECT_IMPERSONATION = 512
	}
}
