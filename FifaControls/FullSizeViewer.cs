using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200000C RID: 12
	public partial class FullSizeViewer : Form
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00009EDA File Offset: 0x000080DA
		public FullSizeViewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009EE8 File Offset: 0x000080E8
		public void SetImage(Image image)
		{
			base.Width = image.Width + 10;
			base.Height = image.Height + 50;
			this.pictureBox.BackgroundImage = image;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009F14 File Offset: 0x00008114
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
