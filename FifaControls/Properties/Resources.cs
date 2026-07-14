using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FifaControls.Properties
{
	// Token: 0x0200001D RID: 29
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600019D RID: 413 RVA: 0x000164E6 File Offset: 0x000146E6
		internal Resources()
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000164EE File Offset: 0x000146EE
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("FifaControls.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0001651A File Offset: 0x0001471A
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00016521 File Offset: 0x00014721
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

		// Token: 0x040001D0 RID: 464
		private static ResourceManager resourceMan;

		// Token: 0x040001D1 RID: 465
		private static CultureInfo resourceCulture;
	}
}
