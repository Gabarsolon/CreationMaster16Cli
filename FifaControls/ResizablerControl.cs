using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000015 RID: 21
	public class ResizablerControl : UserControl
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0000E847 File Offset: 0x0000CA47
		public ResizablerControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000E855 File Offset: 0x0000CA55
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000E874 File Offset: 0x0000CA74
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x04000115 RID: 277
		private IContainer components;
	}
}
