using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000016 RID: 22
	public partial class WebBrowserForm : Form
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00054C29 File Offset: 0x00052E29
		public WebBrowserForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00054C50 File Offset: 0x00052E50
		private void buttonSoccerway_Click(object sender, EventArgs e)
		{
			Uri uri = new Uri("http://it.soccerway.com/");
			this.webBrowser1.Url = uri;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00054C74 File Offset: 0x00052E74
		private void buttonTransfermrkt_Click(object sender, EventArgs e)
		{
			Uri uri = new Uri("https://www.transfermarkt.com/");
			this.webBrowser1.Url = uri;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00054C98 File Offset: 0x00052E98
		private void buttonImportTeamAs_Click(object sender, EventArgs e)
		{
			if (this.m_WebGrabber.ExtractInfoFromWeb(this.webBrowser1.Document))
			{
				this.m_WebPatchLoader.Load(this.m_WebGrabber.WebTable, this.m_WebGrabber.Picture);
				this.m_WebPatchLoader.ShowDialog();
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00054CEC File Offset: 0x00052EEC
		private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			this.buttonBack.Enabled = this.webBrowser1.CanGoBack;
			this.buttonForward.Enabled = this.webBrowser1.CanGoForward;
			this.buttonReload.Enabled = this.buttonBack.Enabled || this.buttonForward.Enabled;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00054D4B File Offset: 0x00052F4B
		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.webBrowser1.GoBack();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00054D59 File Offset: 0x00052F59
		private void buttonForward_Click(object sender, EventArgs e)
		{
			this.webBrowser1.GoForward();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00054D68 File Offset: 0x00052F68
		private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			if (this.m_WebGrabber.Sync(this.webBrowser1.Document.Title))
			{
				this.buttonImportWeb.Enabled = this.m_WebGrabber.CanExtractWebTeam || this.m_WebGrabber.CanExtractWebPlayer;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00054DB8 File Offset: 0x00052FB8
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.webBrowser1.Refresh();
		}

		// Token: 0x04000543 RID: 1347
		private WebGrabber m_WebGrabber = new WebGrabber();

		// Token: 0x04000544 RID: 1348
		private WebPatchLoader m_WebPatchLoader = new WebPatchLoader();
	}
}
