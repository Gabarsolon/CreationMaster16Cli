using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CreationMaster.Properties
{
	// Token: 0x02000021 RID: 33
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000A3F0C File Offset: 0x000A210C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000A3F13 File Offset: 0x000A2113
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000A3F25 File Offset: 0x000A2125
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string RootDir
		{
			get
			{
				return (string)this["RootDir"];
			}
			set
			{
				this["RootDir"] = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000A3F33 File Offset: 0x000A2133
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000A3F45 File Offset: 0x000A2145
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string FifaDbFileName
		{
			get
			{
				return (string)this["FifaDbFileName"];
			}
			set
			{
				this["FifaDbFileName"] = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000A3F53 File Offset: 0x000A2153
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000A3F65 File Offset: 0x000A2165
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string FifaXmlFileName
		{
			get
			{
				return (string)this["FifaXmlFileName"];
			}
			set
			{
				this["FifaXmlFileName"] = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000A3F73 File Offset: 0x000A2173
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000A3F85 File Offset: 0x000A2185
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LangDbFileName
		{
			get
			{
				return (string)this["LangDbFileName"];
			}
			set
			{
				this["LangDbFileName"] = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000A3F93 File Offset: 0x000A2193
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000A3FA5 File Offset: 0x000A21A5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string LangXmlFileName
		{
			get
			{
				return (string)this["LangXmlFileName"];
			}
			set
			{
				this["LangXmlFileName"] = value;
			}
		}

		// Token: 0x04000A40 RID: 2624
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
