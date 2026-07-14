using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CreationMaster
{
	// Token: 0x0200001F RID: 31
	public partial class TvForm : Form
	{
		// Token: 0x060005DC RID: 1500 RVA: 0x000A3E07 File Offset: 0x000A2007
		public TvForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}
	}
}
