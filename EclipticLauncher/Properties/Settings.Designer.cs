using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace EclipticLauncher.Properties
{
	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000078EC File Offset: 0x00005AEC
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x0400006E RID: 110
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
