using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ShadowNiteLauncher
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class GameSettings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000052A0 File Offset: 0x000034A0
		public static GameSettings Default
		{
			get
			{
				return GameSettings.gameSettings_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000052B4 File Offset: 0x000034B4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000052D4 File Offset: 0x000034D4
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string key
		{
			get
			{
				return (string)this["key"];
			}
			set
			{
				this["key"] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000052F0 File Offset: 0x000034F0
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00005310 File Offset: 0x00003510
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Name
		{
			get
			{
				return (string)this["Name"];
			}
			set
			{
				this["Name"] = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000534C File Offset: 0x0000354C
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Path
		{
			get
			{
				return (string)this["Path"];
			}
			set
			{
				this["Path"] = value;
			}
		}

		// Token: 0x04000042 RID: 66
		private static GameSettings gameSettings_0 = (GameSettings)SettingsBase.Synchronized(new GameSettings());
	}
}
