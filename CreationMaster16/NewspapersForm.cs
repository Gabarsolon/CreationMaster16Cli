using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200000B RID: 11
	public partial class NewspapersForm : Form
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00019DD8 File Offset: 0x00017FD8
		public NewspapersForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshNewspapers);
			this.viewer2DNewspaper.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageNewspapers);
			this.viewer2DNewspaper.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageNewspapers);
			this.viewer2DNewspaper.ButtonStripVisible = true;
			this.viewer2DNewspaper.RemoveButton = true;
			this.viewer2DCmSponsor.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCmSponsor);
			this.viewer2DCmSponsor.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageCmSponsor);
			this.viewer2DCmSponsor.ButtonStripVisible = true;
			this.viewer2DCmSponsor.RemoveButton = true;
			this.viewer2DCmSponsorSmall.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCmSponsorSmall);
			this.viewer2DCmSponsorSmall.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageCmSponsorSmall);
			this.viewer2DCmSponsorSmall.ButtonStripVisible = true;
			this.viewer2DCmSponsorSmall.RemoveButton = true;
			this.viewer2DTeamNews.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageTeamNews);
			this.viewer2DTeamNews.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageTeamNews);
			this.viewer2DTeamNews.ButtonStripVisible = true;
			this.viewer2DTeamNews.RemoveButton = true;
			this.comboTeamNewsType.SelectedIndex = 0;
			this.Preset();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00019F3C File Offset: 0x0001813C
		public void Preset()
		{
			if (!base.Visible)
			{
				return;
			}
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DCmSponsor.ImageSize = new Size(256, 64);
				this.numericCmSponsor.Maximum = 19m;
				this.viewer2DCmSponsorSmall.Visible = true;
				this.viewer2DTeamNews.ImageSize = new Size(512, 512);
			}
			else
			{
				this.viewer2DCmSponsorSmall.Visible = false;
				this.viewer2DTeamNews.ImageSize = new Size(668, 580);
			}
			if (this.comboTeamAvailable.Items.Count != FifaEnvironment.Teams.Count)
			{
				this.comboTeamAvailable.Items.Clear();
				this.comboTeamAvailable.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001A018 File Offset: 0x00018218
		public IdObject RefreshNewspapers(object sender, object obj)
		{
			this.Preset();
			this.LoadNews();
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001A028 File Offset: 0x00018228
		private void LoadTeamNews()
		{
			Team team = (Team)this.comboTeamAvailable.SelectedItem;
			if (team == null)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return;
			}
			int id = team.Id;
			int selectedIndex = this.comboTeamNewsType.SelectedIndex;
			if (selectedIndex < 0)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return;
			}
			int num = (int)this.numericTeamNewsCounter.Value;
			this.viewer2DTeamNews.CurrentBitmap = TeamNews.GetTeamNews(id, selectedIndex, num);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001A0A0 File Offset: 0x000182A0
		private void LoadNews()
		{
			this.numericNewspaper1.Value = this.m_CurrentNewspaperId;
			this.viewer2DNewspaper.CurrentBitmap = Newspaper.GetNewspaper(this.m_CurrentNewspaperId);
			this.numericCmSponsor.Value = this.m_CurrentCmSponsorId;
			this.viewer2DCmSponsor.CurrentBitmap = CmSponsor.GetCmSponsor(this.m_CurrentCmSponsorId);
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DCmSponsorSmall.CurrentBitmap = CmSponsor.GetCmSponsorSmall(this.m_CurrentCmSponsorId);
			}
			this.LoadTeamNews();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001A12A File Offset: 0x0001832A
		private bool ImportImageNewspapers(object sender, Bitmap bitmap)
		{
			return Newspaper.SetNewspaper(this.m_CurrentNewspaperId, bitmap);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001A138 File Offset: 0x00018338
		private bool DeleteImageNewspapers(object sender)
		{
			return FifaEnvironment.DeleteFromZdata(Newspaper.NewspaperBigFileName(this.m_CurrentNewspaperId));
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001A14A File Offset: 0x0001834A
		private bool ImportImageCmSponsor(object sender, Bitmap bitmap)
		{
			return CmSponsor.SetCmSponsor(this.m_CurrentCmSponsorId, bitmap);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001A158 File Offset: 0x00018358
		private bool DeleteImageCmSponsor(object sender)
		{
			bool flag = CmSponsor.DeleteCmSponsor(this.m_CurrentCmSponsorId);
			if (flag)
			{
				this.LoadNews();
			}
			return flag;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001A170 File Offset: 0x00018370
		private bool ImportImageTeamNews(object sender, Bitmap bitmap)
		{
			Team team = (Team)this.comboTeamAvailable.SelectedItem;
			if (team == null)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return false;
			}
			int id = team.Id;
			int selectedIndex = this.comboTeamNewsType.SelectedIndex;
			if (selectedIndex < 0)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return false;
			}
			int num = (int)this.numericTeamNewsCounter.Value;
			bool flag = TeamNews.SetTeamNews(id, selectedIndex, num, bitmap);
			if (flag)
			{
				switch (selectedIndex)
				{
				case 0:
					if (num > team.maxvariationsstd)
					{
						team.maxvariationsstd = num;
					}
					break;
				case 1:
					if (num > team.maxvariationspos)
					{
						team.maxvariationspos = num;
					}
					break;
				case 2:
					if (num > team.maxvariationsneg)
					{
						team.maxvariationsneg = num;
					}
					break;
				}
			}
			return flag;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001A230 File Offset: 0x00018430
		private bool DeleteImageTeamNews(object sender)
		{
			Team team = (Team)this.comboTeamAvailable.SelectedItem;
			if (team == null)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return false;
			}
			int id = team.Id;
			int selectedIndex = this.comboTeamNewsType.SelectedIndex;
			if (selectedIndex < 0)
			{
				this.viewer2DTeamNews.CurrentBitmap = null;
				return false;
			}
			int num = (int)this.numericTeamNewsCounter.Value;
			bool flag = TeamNews.DeleteTeamNews(id, selectedIndex, num);
			if (flag)
			{
				switch (selectedIndex)
				{
				case 0:
					if (num == team.maxvariationsstd)
					{
						team.maxvariationsstd = num - 1;
					}
					break;
				case 1:
					if (num == team.maxvariationspos)
					{
						team.maxvariationspos = num - 1;
					}
					break;
				case 2:
					if (num == team.maxvariationsneg)
					{
						team.maxvariationsneg = num - 1;
					}
					break;
				}
			}
			if (flag)
			{
				this.LoadNews();
			}
			return flag;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001A2FD File Offset: 0x000184FD
		private bool ImportImageCmSponsorSmall(object sender, Bitmap bitmap)
		{
			return CmSponsor.SetCmSponsorSmall(this.m_CurrentCmSponsorId, bitmap);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001A30B File Offset: 0x0001850B
		private bool DeleteImageCmSponsorSmall(object sender)
		{
			return FifaEnvironment.DeleteFromZdata(CmSponsor.CmSponsorSmallBigFileName(this.m_CurrentCmSponsorId));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001A31D File Offset: 0x0001851D
		private void NewspapersForm_Load(object sender, EventArgs e)
		{
			this.Preset();
			this.LoadNews();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001A32B File Offset: 0x0001852B
		private void numericNewspaper(object sender, EventArgs e)
		{
			this.m_CurrentNewspaperId = (int)this.numericNewspaper1.Value;
			this.viewer2DNewspaper.CurrentBitmap = Newspaper.GetNewspaper(this.m_CurrentNewspaperId);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001A35C File Offset: 0x0001855C
		private void numericCmSponsor_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentCmSponsorId = (int)this.numericCmSponsor.Value;
			this.viewer2DCmSponsor.CurrentBitmap = CmSponsor.GetCmSponsor(this.m_CurrentCmSponsorId);
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DCmSponsorSmall.CurrentBitmap = CmSponsor.GetCmSponsorSmall(this.m_CurrentCmSponsorId);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001A3B4 File Offset: 0x000185B4
		private void comboTeamNewsType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadTeamNews();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001A3B4 File Offset: 0x000185B4
		private void numericTeamNewsCounter_ValueChanged(object sender, EventArgs e)
		{
			this.LoadTeamNews();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001A3B4 File Offset: 0x000185B4
		private void comboTeamAvailable_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadTeamNews();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001A3BC File Offset: 0x000185BC
		private void groupSpecificTeamNews_Paint(object sender, PaintEventArgs e)
		{
			if (this.comboTeamAvailable.Items.Count == 0)
			{
				this.Preset();
				this.LoadNews();
			}
		}

		// Token: 0x040001A7 RID: 423
		private int m_CurrentNewspaperId;

		// Token: 0x040001A8 RID: 424
		private int m_CurrentCmSponsorId;
	}
}
