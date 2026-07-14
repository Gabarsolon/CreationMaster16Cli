using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000002 RID: 2
	public partial class AboutForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AboutForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private void linkFifaMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitLink();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002088 File Offset: 0x00000288
		private void VisitLink()
		{
			Process.Start("http://www.fifa-master.com");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002095 File Offset: 0x00000295
		private void VisitLinkFifaInfinity()
		{
			Process.Start("http://www.fifa-infinity.com/");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020A2 File Offset: 0x000002A2
		private void VisitAbio()
		{
			Process.Start("http://www.abio.org");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020AF File Offset: 0x000002AF
		private void VisitUnicef()
		{
			Process.Start("http://www.unicef.org");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020BC File Offset: 0x000002BC
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitAbio();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020E4 File Offset: 0x000002E4
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitUnicef();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000210C File Offset: 0x0000030C
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitLinkFifaInfinity();
			}
			catch (Exception)
			{
			}
		}
	}
}
