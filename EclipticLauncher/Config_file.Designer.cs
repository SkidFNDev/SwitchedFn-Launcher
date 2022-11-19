using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EclipticLauncher
{
	// Token: 0x0200001A RID: 26
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Config_file : ApplicationSettingsBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000061C0 File Offset: 0x000043C0
		public static Config_file Default
		{
			get
			{
				return Config_file.config_file_0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000534C File Offset: 0x0000354C
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000061D4 File Offset: 0x000043D4
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000061F4 File Offset: 0x000043F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Show
		{
			get
			{
				return (bool)this["Show"];
			}
			set
			{
				this["Show"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00006214 File Offset: 0x00004414
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00006234 File Offset: 0x00004434
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AC_bypass
		{
			get
			{
				return (bool)this["AC_bypass"];
			}
			set
			{
				this["AC_bypass"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00006254 File Offset: 0x00004454
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00006274 File Offset: 0x00004474
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Email
		{
			get
			{
				return (string)this["Email"];
			}
			set
			{
				this["Email"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00006290 File Offset: 0x00004490
		// (set) Token: 0x0600008A RID: 138 RVA: 0x000062B0 File Offset: 0x000044B0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Imgpath
		{
			get
			{
				return (string)this["Imgpath"];
			}
			set
			{
				this["Imgpath"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000062CC File Offset: 0x000044CC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000062EC File Offset: 0x000044EC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Accid
		{
			get
			{
				return (string)this["Accid"];
			}
			set
			{
				this["Accid"] = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00006308 File Offset: 0x00004508
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00006328 File Offset: 0x00004528
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Args
		{
			get
			{
				return (string)this["Args"];
			}
			set
			{
				this["Args"] = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private static Config_file config_file_0 = (Config_file)SettingsBase.Synchronized(new Config_file());
	}
}
