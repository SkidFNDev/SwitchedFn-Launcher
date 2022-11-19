using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200001E RID: 30
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class8
{
	// Token: 0x060000A7 RID: 167 RVA: 0x000032D8 File Offset: 0x000014D8
	internal Class8()
	{
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007884 File Offset: 0x00005A84
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class8.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("\\&\\\\1uG4`s \\]ZqO~<>!bVg?h2\\,'", typeof(Class8).Assembly);
				Class8.resourceManager_0 = resourceManager;
			}
			return Class8.resourceManager_0;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x000078C4 File Offset: 0x00005AC4
	// (set) Token: 0x060000AA RID: 170 RVA: 0x000078D8 File Offset: 0x00005AD8
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class8.cultureInfo_0;
		}
		set
		{
			Class8.cultureInfo_0 = value;
		}
	}

	// Token: 0x0400006C RID: 108
	private static ResourceManager resourceManager_0;

	// Token: 0x0400006D RID: 109
	private static CultureInfo cultureInfo_0;
}
