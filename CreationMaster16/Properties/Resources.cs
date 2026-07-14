using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CreationMaster.Properties
{
	// Token: 0x02000020 RID: 32
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x000A3EC9 File Offset: 0x000A20C9
		internal Resources()
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x000A3ED1 File Offset: 0x000A20D1
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("CreationMaster.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000A3EFD File Offset: 0x000A20FD
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x000A3F04 File Offset: 0x000A2104
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000A3E RID: 2622
		private static ResourceManager resourceMan;

		// Token: 0x04000A3F RID: 2623
		private static CultureInfo resourceCulture;
	}
}
