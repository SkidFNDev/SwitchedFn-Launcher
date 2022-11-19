using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace StormFN_Launcher
{
	// Token: 0x02000020 RID: 32
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Config_file : ApplicationSettingsBase
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00007924 File Offset: 0x00005B24
		public static Config_file Default
		{
			get
			{
				return Config_file.config_file_0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000534C File Offset: 0x0000354C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000061D4 File Offset: 0x000043D4
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000061F4 File Offset: 0x000043F4
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00006214 File Offset: 0x00004414
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00006234 File Offset: 0x00004434
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00006254 File Offset: 0x00004454
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00006274 File Offset: 0x00004474
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00006290 File Offset: 0x00004490
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000062B0 File Offset: 0x000044B0
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
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

		// Token: 0x0400006F RID: 111
		private static Config_file config_file_0 = (Config_file)SettingsBase.Synchronized(new Config_file());
	}
}
