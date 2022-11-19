using System;
using System.Runtime.InteropServices;

// Token: 0x02000014 RID: 20
public class GClass1
{
	// Token: 0x0600006B RID: 107
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Initialize(string string_0, ref GClass1.GStruct0 gstruct0_0, bool bool_0, string string_1);

	// Token: 0x0600006C RID: 108
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_RunCallbacks();

	// Token: 0x0600006D RID: 109
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Shutdown();

	// Token: 0x0600006E RID: 110
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_UpdatePresence(ref GClass1.GStruct1 gstruct1_0);

	// Token: 0x0600006F RID: 111 RVA: 0x000061AC File Offset: 0x000043AC
	internal static void smethod_0(string string_0, ref object object_0, bool bool_0, object object_1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x02000015 RID: 21
	// (Invoke) Token: 0x06000072 RID: 114
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate0(int errorCode, string message);

	// Token: 0x02000016 RID: 22
	// (Invoke) Token: 0x06000076 RID: 118
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate1(int errorCode, string message);

	// Token: 0x02000017 RID: 23
	public struct GStruct0
	{
		// Token: 0x04000049 RID: 73
		public GClass1.GDelegate2 gdelegate2_0;

		// Token: 0x0400004A RID: 74
		public GClass1.GDelegate0 gdelegate0_0;

		// Token: 0x0400004B RID: 75
		public GClass1.GDelegate1 gdelegate1_0;
	}

	// Token: 0x02000018 RID: 24
	// (Invoke) Token: 0x0600007A RID: 122
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate2();

	// Token: 0x02000019 RID: 25
	[Serializable]
	public struct GStruct1
	{
		// Token: 0x0400004C RID: 76
		public string state;

		// Token: 0x0400004D RID: 77
		public string details;

		// Token: 0x0400004E RID: 78
		public long startTimestamp;

		// Token: 0x0400004F RID: 79
		public long endTimestamp;

		// Token: 0x04000050 RID: 80
		public string largeImageKey;

		// Token: 0x04000051 RID: 81
		public string largeImageText;

		// Token: 0x04000052 RID: 82
		public string smallImageKey;

		// Token: 0x04000053 RID: 83
		public string smallImageText;

		// Token: 0x04000054 RID: 84
		public string partyId;

		// Token: 0x04000055 RID: 85
		public int partySize;

		// Token: 0x04000056 RID: 86
		public int partyMax;

		// Token: 0x04000057 RID: 87
		public string matchSecret;

		// Token: 0x04000058 RID: 88
		public string joinSecret;

		// Token: 0x04000059 RID: 89
		public string spectateSecret;

		// Token: 0x0400005A RID: 90
		public bool instance;
	}
}
