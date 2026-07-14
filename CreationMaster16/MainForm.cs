using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using CreationMaster.Properties;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000012 RID: 18
	public partial class MainForm : Form
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
		public MainForm()
		{
			this.InitializeComponent();
			this.m_SplitterDistanceBottom = this.splitHoriz.Height * 2 / 3;
			this.m_SplitterDistanceRight = this.splitVert.Width * 3 / 4;
			FifaEnvironment.InitializeDefault();
			this.CreateForms();
			MainForm.CM = this;
			this.EnablePanels(false);
			this.EnableMenus();
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0004C518 File Offset: 0x0004A718
		private void CreateForms()
		{
			this.m_FormationForm = new FormationForm();
			this.m_FormationForm.MdiParent = this;
			this.m_FormationForm.Dock = DockStyle.Fill;
			this.m_CountryForm = new CountryForm();
			this.m_CountryForm.MdiParent = this;
			this.m_CountryForm.Dock = DockStyle.Fill;
			this.m_TeamForm = new TeamForm();
			this.m_TeamForm.MdiParent = this;
			this.m_TeamForm.Dock = DockStyle.Fill;
			this.m_KitForm = new KitForm();
			this.m_KitForm.MdiParent = this;
			this.m_KitForm.Dock = DockStyle.Fill;
			this.m_BallForm = new BallForm();
			this.m_BallForm.MdiParent = this;
			this.m_BallForm.Dock = DockStyle.Fill;
			this.m_ManagerForm = new ManagerForm();
			this.m_ManagerForm.MdiParent = this;
			this.m_ManagerForm.Dock = DockStyle.Fill;
			this.m_GameGraphicForm = new GameGraphicForm();
			this.m_GameGraphicForm.MdiParent = this;
			this.m_GameGraphicForm.Dock = DockStyle.Fill;
			this.m_WebBrowserForm = new WebBrowserForm();
			this.m_WebBrowserForm.MdiParent = this;
			this.m_WebBrowserForm.Dock = DockStyle.Fill;
			this.m_LeagueForm = new LeagueForm();
			this.m_LeagueForm.MdiParent = this;
			this.m_LeagueForm.Dock = DockStyle.Fill;
			this.m_ShoesForm = new ShoesForm();
			this.m_ShoesForm.MdiParent = this;
			this.m_ShoesForm.Dock = DockStyle.Fill;
			this.m_TvForm = new TvForm();
			this.m_TvForm.MdiParent = this;
			this.m_TvForm.Dock = DockStyle.Fill;
			this.m_NewspapersForm = new NewspapersForm();
			this.m_NewspapersForm.MdiParent = this;
			this.m_NewspapersForm.Dock = DockStyle.Fill;
			this.m_RefereeForm = new RefereeForm();
			this.m_RefereeForm.MdiParent = this;
			this.m_RefereeForm.Dock = DockStyle.Fill;
			this.m_TrophyForm = new CompetitionForm();
			this.m_TrophyForm.MdiParent = this;
			this.m_TrophyForm.Dock = DockStyle.Fill;
			this.m_PlayerForm = new PlayerForm();
			this.m_PlayerForm.MdiParent = this;
			this.m_PlayerForm.Dock = DockStyle.Fill;
			this.m_StadiumForm = new StadiumForm();
			this.m_StadiumForm.MdiParent = this;
			this.m_StadiumForm.Dock = DockStyle.Fill;
			this.m_GlovesForm = new GlovesForm();
			this.m_GlovesForm.MdiParent = this;
			this.m_GlovesForm.Dock = DockStyle.Fill;
			this.m_AudioForm = new AudioForm();
			this.m_AudioForm.MdiParent = this;
			this.m_AudioForm.Dock = DockStyle.Fill;
			MainForm.m_PatchCreatorForm = new PatchCreatorForm();
			MainForm.m_PatchLoaderForm = new PatchLoaderForm();
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		private void DestroyForms()
		{
			this.m_FormationForm.Dispose();
			this.m_CountryForm.Dispose();
			this.m_TeamForm.Dispose();
			this.m_KitForm.Dispose();
			this.m_BallForm.Dispose();
			this.m_ManagerForm.Dispose();
			this.m_GameGraphicForm.Dispose();
			this.m_WebBrowserForm.Dispose();
			this.m_LeagueForm.Dispose();
			this.m_ShoesForm.Dispose();
			this.m_TvForm.Dispose();
			this.m_NewspapersForm.Dispose();
			this.m_RefereeForm.Dispose();
			this.m_TrophyForm.Dispose();
			this.m_PlayerForm.Dispose();
			this.m_StadiumForm.Dispose();
			this.m_GlovesForm.Dispose();
			this.m_AudioForm.Dispose();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0004C883 File Offset: 0x0004AA83
		private void EnablePanels(bool enable)
		{
			this.splitVert.Enabled = enable;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0004C894 File Offset: 0x0004AA94
		private void EnableMenus()
		{
			if (this.m_OpenFileFlag)
			{
				this.menuOpenFifa16.Enabled = false;
				this.menuOpenLang16.Enabled = false;
				this.menuOpenFifa15.Enabled = false;
				this.menuOpenFifa14.Enabled = false;
				this.menuOpenAll.Enabled = false;
				this.menuOpenLang14.Enabled = false;
				this.menuOpenLang15.Enabled = false;
				this.menuReopen.Enabled = false;
				this.menuSave.Enabled = true;
				this.menuClose.Enabled = true;
				this.menuOptions.Enabled = false;
				this.menuRegenerate.Enabled = true;
				this.menuExpandDatabase.Enabled = true;
				this.menuAlignLanguageDB.Enabled = true;
				this.menuCleanFAT.Enabled = true;
				this.menuRemoveKidProtection.Enabled = true;
				this.toolStripMain.Enabled = true;
				this.menuPatch.Enabled = true;
				this.menuRemoveAllLongTeamNames.Enabled = true;
				this.menuUgc.Enabled = FifaEnvironment.Year == 14;
				this.menuUpdateDB.Enabled = true;
				this.menuEnableAllMessages.Enabled = true;
				this.menuInstallRevModPatch.Enabled = true;
				this.menuMinimizeNamesTable.Enabled = true;
				this.menuPreserveOriginalNames.Enabled = true;
				this.exportPlayersFromCSVToolStripMenuItem.Enabled = true;
				this.importPlayersFromCSVToolStripMenuItem.Enabled = true;
				this.removeFakePlayersToolStripMenuItem.Enabled = true;
				this.playerNameCountryRulesToolStripMenuItem.Enabled = true;
				this.fixLoanDatesToolStripMenuItem.Enabled = true;
				this.fixProblemsToolStripMenuItem.Enabled = true;
			}
			else
			{
				this.menuOpenFifa16.Enabled = true;
				this.menuOpenLang16.Enabled = true;
				this.menuOpenFifa15.Enabled = true;
				this.menuOpenFifa14.Enabled = true;
				this.menuOpenAll.Enabled = true;
				this.menuOpenLang14.Enabled = true;
				this.menuOpenLang15.Enabled = true;
				this.menuReopen.Enabled = true;
				this.menuSave.Enabled = false;
				this.menuClose.Enabled = false;
				this.menuOptions.Enabled = true;
				this.menuRegenerate.Enabled = true;
				this.menuExpandDatabase.Enabled = false;
				this.menuAlignLanguageDB.Enabled = false;
				this.menuCleanFAT.Enabled = false;
				this.menuRemoveKidProtection.Enabled = false;
				this.toolStripMain.Enabled = false;
				this.menuPatch.Enabled = false;
				this.menuRemoveAllLongTeamNames.Enabled = false;
				this.menuUgc.Enabled = false;
				this.menuUpdateDB.Enabled = false;
				this.menuEnableAllMessages.Enabled = false;
				this.menuInstallRevModPatch.Enabled = false;
				this.menuMinimizeNamesTable.Enabled = false;
				this.menuPreserveOriginalNames.Enabled = false;
				this.exportPlayersFromCSVToolStripMenuItem.Enabled = false;
				this.importPlayersFromCSVToolStripMenuItem.Enabled = false;
				this.removeFakePlayersToolStripMenuItem.Enabled = false;
				this.playerNameCountryRulesToolStripMenuItem.Enabled = false;
				this.fixLoanDatesToolStripMenuItem.Enabled = false;
				this.fixProblemsToolStripMenuItem.Enabled = false;
			}
			this.menuExit.Enabled = true;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		private void ShowFormOnPanel(Form form, Panel panel)
		{
			panel.Controls.Clear();
			panel.Controls.Add(form);
			form.Show();
			if (this.panelBottom.Controls.Count == 0)
			{
				this.stripLabelBottom.Text = "Empty";
			}
			else
			{
				this.stripLabelBottom.Text = this.panelBottom.Controls[0].Text;
			}
			if (this.panelRight.Controls.Count == 0)
			{
				this.stripLabelRight.Text = "Empty";
				return;
			}
			this.stripLabelRight.Text = this.panelRight.Controls[0].Text;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0004CC64 File Offset: 0x0004AE64
		public void JumpTo(IdObject idObject)
		{
			Panel panel = (this.m_IsAltPressed ? this.panelRight : (this.m_IsCtrlPressed ? this.panelBottom : this.panelMain));
			if (idObject.GetType().Name == "Player")
			{
				Player player = (Player)idObject;
				if (!this.m_PlayerForm.pickUpControl.combo.Items.Contains(player))
				{
					this.m_PlayerForm.pickUpControl.combo.Items.Add(player);
				}
				this.m_PlayerForm.pickUpControl.combo.SelectedItem = player;
				this.ShowFormOnPanel(this.m_PlayerForm, panel);
			}
			if (idObject.GetType().Name == "Team")
			{
				Team team = (Team)idObject;
				if (!this.m_TeamForm.pickUpControl.combo.Items.Contains(team))
				{
					this.m_TeamForm.pickUpControl.combo.Items.Add(team);
				}
				this.m_TeamForm.pickUpControl.combo.SelectedItem = team;
				this.ShowFormOnPanel(this.m_TeamForm, panel);
			}
			if (idObject.GetType().Name == "Kit")
			{
				Kit kit = (Kit)idObject;
				if (!this.m_KitForm.pickUpControl.combo.Items.Contains(kit))
				{
					this.m_KitForm.pickUpControl.combo.Items.Add(kit);
				}
				this.m_KitForm.pickUpControl.combo.SelectedItem = kit;
				this.ShowFormOnPanel(this.m_KitForm, panel);
			}
			if (idObject.GetType().Name == "League")
			{
				League league = (League)idObject;
				if (!this.m_LeagueForm.pickUpControl.combo.Items.Contains(league))
				{
					this.m_LeagueForm.pickUpControl.combo.Items.Add(league);
				}
				this.m_LeagueForm.pickUpControl.combo.SelectedItem = league;
				this.ShowFormOnPanel(this.m_LeagueForm, panel);
			}
			if (idObject.GetType().Name == "Country")
			{
				Country country = (Country)idObject;
				if (!this.m_CountryForm.pickUpControl.combo.Items.Contains(country))
				{
					this.m_CountryForm.pickUpControl.combo.Items.Add(country);
				}
				this.m_CountryForm.pickUpControl.combo.SelectedItem = country;
				this.ShowFormOnPanel(this.m_CountryForm, panel);
			}
			if (idObject.GetType().Name == "Trophy")
			{
				this.ShowFormOnPanel(this.m_TrophyForm, panel);
			}
			if (idObject.GetType().Name == "Stadium")
			{
				Stadium stadium = (Stadium)idObject;
				if (!this.m_StadiumForm.pickUpControl.combo.Items.Contains(stadium))
				{
					this.m_StadiumForm.pickUpControl.combo.Items.Add(stadium);
				}
				this.m_StadiumForm.pickUpControl.combo.SelectedItem = stadium;
				this.ShowFormOnPanel(this.m_StadiumForm, panel);
			}
			if (idObject.GetType().Name == "Formation")
			{
				Formation formation = (Formation)idObject;
				if (!this.m_FormationForm.pickUpControl.combo.Items.Contains(formation))
				{
					this.m_FormationForm.pickUpControl.combo.Items.Add(formation);
				}
				this.m_FormationForm.pickUpControl.combo.SelectedItem = formation;
				this.ShowFormOnPanel(this.m_FormationForm, panel);
			}
			if (idObject.GetType().Name == "Ball")
			{
				Ball ball = (Ball)idObject;
				if (!this.m_BallForm.pickUpControl.combo.Items.Contains(ball))
				{
					this.m_BallForm.pickUpControl.combo.Items.Add(ball);
				}
				this.m_BallForm.pickUpControl.combo.SelectedItem = ball;
				this.ShowFormOnPanel(this.m_BallForm, panel);
			}
			if (idObject.GetType().Name == "Shoes")
			{
				Shoes shoes = (Shoes)idObject;
				if (!this.m_ShoesForm.pickUpControl.combo.Items.Contains(shoes))
				{
					this.m_ShoesForm.pickUpControl.combo.Items.Add(shoes);
				}
				this.m_ShoesForm.pickUpControl.combo.SelectedItem = shoes;
				this.ShowFormOnPanel(this.m_ShoesForm, panel);
			}
			if (idObject.GetType().Name == "GkGloves")
			{
				GkGloves gkGloves = (GkGloves)idObject;
				if (!this.m_GlovesForm.pickUpControl.combo.Items.Contains(gkGloves))
				{
					this.m_GlovesForm.pickUpControl.combo.Items.Add(gkGloves);
				}
				this.m_GlovesForm.pickUpControl.combo.SelectedItem = gkGloves;
				this.ShowFormOnPanel(this.m_GlovesForm, panel);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0004D19C File Offset: 0x0004B39C
		private void menuAbout_Click(object sender, EventArgs e)
		{
			this.m_AboutForm.labelProduct.Text = "Creation Master 16";
			this.m_AboutForm.labelRelease.Text = "Version 2.0";
			this.m_AboutForm.ShowDialog();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0004D1D4 File Offset: 0x0004B3D4
		private void buttonShowBottom_Click(object sender, EventArgs e)
		{
			this.toolStripBottom.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStripBottom.Dock = DockStyle.Left;
			this.splitHoriz.SplitterDistance = this.m_SplitterDistanceBottom;
			this.splitHoriz.IsSplitterFixed = false;
			this.buttonShowBottom.Visible = false;
			this.stripLabelBottom.TextDirection = ToolStripTextDirection.Vertical90;
			this.buttonHideBottom.Visible = true;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0004D23C File Offset: 0x0004B43C
		private void buttonHideBottom_Click(object sender, EventArgs e)
		{
			this.toolStripBottom.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripBottom.Dock = DockStyle.Bottom;
			this.toolStripBottom.AutoSize = true;
			this.m_SplitterDistanceBottom = this.splitHoriz.SplitterDistance;
			this.splitHoriz.SplitterDistance = this.splitHoriz.Height - 23;
			this.splitHoriz.IsSplitterFixed = true;
			this.buttonShowBottom.Visible = true;
			this.stripLabelBottom.TextDirection = ToolStripTextDirection.Horizontal;
			this.buttonHideBottom.Visible = false;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0004D2C8 File Offset: 0x0004B4C8
		private void buttonShowRight_Click(object sender, EventArgs e)
		{
			this.toolStripRight.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripRight.Dock = DockStyle.Top;
			this.toolStripRight.AutoSize = true;
			this.splitVert.SplitterDistance = this.m_SplitterDistanceRight;
			this.splitVert.IsSplitterFixed = false;
			this.buttonShowRight.Visible = false;
			this.stripLabelRight.TextDirection = ToolStripTextDirection.Horizontal;
			this.buttonHideRight.Visible = true;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0004D33C File Offset: 0x0004B53C
		private void buttonHideRight_Click(object sender, EventArgs e)
		{
			this.toolStripRight.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStripRight.Dock = DockStyle.Right;
			this.m_SplitterDistanceRight = this.splitVert.SplitterDistance;
			this.splitVert.SplitterDistance = this.splitVert.Width - 23;
			this.splitVert.IsSplitterFixed = true;
			this.buttonShowRight.Visible = true;
			this.stripLabelRight.TextDirection = ToolStripTextDirection.Vertical90;
			this.buttonHideRight.Visible = false;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0004D3BC File Offset: 0x0004B5BC
		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			if (this.splitHoriz.IsSplitterFixed && this.splitHoriz.Height >= 23)
			{
				this.splitHoriz.SplitterDistance = this.splitHoriz.Height - 23;
			}
			if (this.splitVert.IsSplitterFixed && this.splitVert.Width >= 23)
			{
				this.splitVert.SplitterDistance = this.splitVert.Width - 23;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0004D433 File Offset: 0x0004B633
		private void menuOpenFifa_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (!this.InitializeFifaEnvironment(14))
			{
				return;
			}
			this.Refresh();
			this.Open();
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0004D460 File Offset: 0x0004B660
		private void menuOpenFifa15Demo_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (!this.InitializeFifaEnvironment(15))
			{
				return;
			}
			this.Refresh();
			this.Open();
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0004D490 File Offset: 0x0004B690
		private bool InitializeFifaEnvironment(int year, string rootDir)
		{
			bool flag = false;
			if (year > 0)
			{
				flag = FifaEnvironment.Initialize(year, rootDir);
			}
			else if (rootDir != null)
			{
				if (rootDir.Contains("14"))
				{
					flag = FifaEnvironment.Initialize(14, rootDir);
				}
				if (rootDir.Contains("15"))
				{
					flag = FifaEnvironment.Initialize(15, rootDir);
				}
				if (rootDir.Contains("16"))
				{
					flag = FifaEnvironment.Initialize(16, rootDir);
				}
			}
			if (!flag)
			{
				FifaEnvironment.UserMessages.ShowMessage(10004);
			}
			return flag;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0004D506 File Offset: 0x0004B706
		private bool InitializeFifaEnvironment(int year)
		{
			return this.InitializeFifaEnvironment(year, null);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0004D510 File Offset: 0x0004B710
		private bool InitializeFifaEnvironment(string rootDir)
		{
			return this.InitializeFifaEnvironment(-1, rootDir);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0004D51C File Offset: 0x0004B71C
		private void Open()
		{
			if (!FifaEnvironment.Open(this.statusBar))
			{
				return;
			}
			this.m_OpenFileFlag = true;
			Settings.Default.RootDir = FifaEnvironment.RootDir;
			Settings.Default.FifaDbFileName = FifaEnvironment.FifaDbFileName;
			Settings.Default.FifaXmlFileName = FifaEnvironment.FifaXmlFileName;
			Settings.Default.LangDbFileName = FifaEnvironment.LangDbFileName;
			Settings.Default.LangXmlFileName = FifaEnvironment.LangXmlFileName;
			Settings.Default.Save();
			this.EnablePanels(true);
			this.EnableMenus();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0004D5A0 File Offset: 0x0004B7A0
		private void buttonMain_Click(object sender, EventArgs e)
		{
			ToolStripButton toolStripButton = (ToolStripButton)sender;
			Panel panel = (this.m_IsAltPressed ? this.panelRight : (this.m_IsCtrlPressed ? this.panelBottom : this.panelMain));
			if (toolStripButton == this.buttonCountry)
			{
				this.ShowFormOnPanel(this.m_CountryForm, panel);
			}
			if (toolStripButton == this.buttonTeam)
			{
				this.ShowFormOnPanel(this.m_TeamForm, panel);
			}
			if (toolStripButton == this.buttonKit)
			{
				this.ShowFormOnPanel(this.m_KitForm, panel);
			}
			if (toolStripButton == this.buttonFormation)
			{
				this.ShowFormOnPanel(this.m_FormationForm, panel);
			}
			if (toolStripButton == this.buttonBrowser)
			{
				this.ShowFormOnPanel(this.m_WebBrowserForm, panel);
			}
			if (toolStripButton == this.buttonBall)
			{
				this.ShowFormOnPanel(this.m_BallForm, panel);
			}
			if (toolStripButton == this.buttonManager)
			{
				this.ShowFormOnPanel(this.m_ManagerForm, panel);
			}
			if (toolStripButton == this.buttonGameGraphics)
			{
				this.ShowFormOnPanel(this.m_GameGraphicForm, panel);
			}
			if (toolStripButton == this.buttonLeague)
			{
				this.ShowFormOnPanel(this.m_LeagueForm, panel);
			}
			if (toolStripButton == this.buttonShoes)
			{
				this.ShowFormOnPanel(this.m_ShoesForm, panel);
			}
			if (toolStripButton == this.buttonTv)
			{
				this.ShowFormOnPanel(this.m_TvForm, panel);
			}
			if (toolStripButton == this.buttonNewspaper)
			{
				this.ShowFormOnPanel(this.m_NewspapersForm, panel);
			}
			if (toolStripButton == this.buttonReferee)
			{
				this.ShowFormOnPanel(this.m_RefereeForm, panel);
			}
			if (toolStripButton == this.buttonTournament)
			{
				this.ShowFormOnPanel(this.m_TrophyForm, panel);
			}
			if (toolStripButton == this.buttonStadium)
			{
				this.ShowFormOnPanel(this.m_StadiumForm, panel);
			}
			if (toolStripButton == this.buttonPlayer)
			{
				this.ShowFormOnPanel(this.m_PlayerForm, panel);
			}
			if (toolStripButton == this.buttonGloves)
			{
				this.ShowFormOnPanel(this.m_GlovesForm, panel);
			}
			if (toolStripButton == this.buttonAudio)
			{
				this.ShowFormOnPanel(this.m_AudioForm, panel);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0004D765 File Offset: 0x0004B965
		private void openSelectLandbToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.InitializeFifaEnvironment(14))
			{
				return;
			}
			if (!this.AskUserOpenLangDatabase())
			{
				return;
			}
			this.Open();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0004D781 File Offset: 0x0004B981
		private void openSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.AskUserOpen())
			{
				return;
			}
			this.Open();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0004D794 File Offset: 0x0004B994
		private bool AskUserOpen()
		{
			string text = this.AskUserOpenRootFolder();
			if (text == null)
			{
				return false;
			}
			if (!this.InitializeFifaEnvironment(text))
			{
				return false;
			}
			if (!FifaEnvironment.OpenFat())
			{
				FifaEnvironment.UserMessages.ShowMessage(10003);
				return false;
			}
			FifaEnvironment.ExtractMainDatabase();
			if (!this.AskUserOpenMainDatabase())
			{
				return false;
			}
			if (!FifaEnvironment.OpenFifaDb())
			{
				FifaEnvironment.UserMessages.ShowMessage(10000);
				return false;
			}
			FifaEnvironment.ExtractLangDatabase();
			if (!this.AskUserOpenLangDatabase())
			{
				return false;
			}
			if (!FifaEnvironment.OpenLangDb())
			{
				FifaEnvironment.UserMessages.ShowMessage(10035);
				return false;
			}
			return true;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0004D824 File Offset: 0x0004BA24
		private bool AskUserOpenLangDatabase()
		{
			this.openLangDialog.CheckFileExists = true;
			this.openLangDialog.InitialDirectory = FifaEnvironment.GameDir + "data\\loc\\";
			this.openLangDialog.Filter = "db files (*.db)|*.db";
			this.openLangDialog.FilterIndex = 1;
			this.openLangDialog.Title = "Open Language Database";
			if (this.openLangDialog.ShowDialog() != DialogResult.OK)
			{
				return false;
			}
			FifaEnvironment.LangDbFileName = this.openLangDialog.FileName;
			FifaEnvironment.LangXmlFileName = this.openLangDialog.FileName.Replace(".db", "-meta.xml");
			return true;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0004D8C4 File Offset: 0x0004BAC4
		private string AskUserOpenRootFolder()
		{
			this.browserDialog.Description = "Select the root folder of FIFA";
			this.browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
			this.browserDialog.ShowNewFolderButton = false;
			this.browserDialog.SelectedPath = FifaEnvironment.RootDir;
			if (this.browserDialog.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			return this.browserDialog.SelectedPath;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0004D924 File Offset: 0x0004BB24
		private bool AskUserOpenMainDatabase()
		{
			return this.BrowseXml() && this.BrowseDB();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0004D93C File Offset: 0x0004BB3C
		private bool BrowseDB()
		{
			this.openFifaDialog.InitialDirectory = FifaEnvironment.GameDir + "data\\db\\";
			this.openFifaDialog.Filter = "db files (*.db)|*.db";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open Database File";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				FifaEnvironment.FifaDbFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0004D9B4 File Offset: 0x0004BBB4
		private bool BrowseXmlDb()
		{
			this.openFifaDialog.InitialDirectory = FifaEnvironment.GameDir + "data\\db\\";
			this.openFifaDialog.Filter = "xml files (*.xml)|*.xml";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open XML Descriptor File";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_XmlDbFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0004DA2C File Offset: 0x0004BC2C
		private bool BrowseXml()
		{
			this.openFifaDialog.InitialDirectory = FifaEnvironment.GameDir + "data\\db\\";
			this.openFifaDialog.Filter = "xml files (*.xml)|*.xml";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open XML Descriptor File";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				FifaEnvironment.FifaXmlFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0004DAA2 File Offset: 0x0004BCA2
		private void menuSave_Click(object sender, EventArgs e)
		{
			if (this.m_OpenFileFlag)
			{
				Cursor.Current = Cursors.WaitCursor;
				this.Refresh();
				this.SaveFiles();
				this.statusBar.Text = "Ready - Save completed!";
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0004DADC File Offset: 0x0004BCDC
		private void menuClose_Click(object sender, EventArgs e)
		{
			if (this.AskAndSave())
			{
				this.CloseFile();
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0004DAEC File Offset: 0x0004BCEC
		private void menuExit_Click(object sender, EventArgs e)
		{
			this.AskAndExit();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0004DAF4 File Offset: 0x0004BCF4
		private bool AskAndSave()
		{
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(1);
			if (dialogResult == DialogResult.Yes)
			{
				this.SaveFiles();
				return true;
			}
			return dialogResult == DialogResult.No || dialogResult == DialogResult.OK;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0004DB24 File Offset: 0x0004BD24
		private void AskAndExit()
		{
			if (this.m_OpenFileFlag)
			{
				if (this.AskAndSave())
				{
					this.m_OpenFileFlag = false;
					Application.Exit();
					return;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0004DB48 File Offset: 0x0004BD48
		private void SaveFiles()
		{
			FifaEnvironment.Save(this.statusBar);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0004DB58 File Offset: 0x0004BD58
		private void CloseFile()
		{
			this.m_OpenFileFlag = false;
			this.m_CountryForm.Clean();
			this.m_LeagueForm.Clean();
			this.m_TeamForm.Clean();
			this.m_KitForm.Clean();
			this.m_PlayerForm.Clean();
			this.m_StadiumForm.Clean();
			this.m_RefereeForm.Clean();
			this.m_FormationForm.Clean();
			this.m_TrophyForm.Clean();
			this.m_ManagerForm.Clean();
			this.m_GameGraphicForm.Clean();
			this.m_TvForm.Clean();
			this.m_ShoesForm.Clean();
			this.m_BallForm.Clean();
			this.m_GlovesForm.Clean();
			this.m_AudioForm.Clean();
			this.DestroyForms();
			this.CreateForms();
			this.EnableMenus();
			this.EnablePanels(false);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0004DC35 File Offset: 0x0004BE35
		private void menuOptions_Click(object sender, EventArgs e)
		{
			FifaEnvironment.ShowOptions();
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0004DC3C File Offset: 0x0004BE3C
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			this.m_IsShiftPressed = (keyData & Keys.Shift) > Keys.None;
			this.m_IsCtrlPressed = (keyData & Keys.Control) > Keys.None;
			this.m_IsAltPressed = (keyData & Keys.Alt) > Keys.None;
			return false;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0004DC70 File Offset: 0x0004BE70
		private void menuExpandDatabase_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaDb.NTables != 137)
			{
				FifaEnvironment.UserMessages.ShowMessage(5049);
				return;
			}
			bool flag = FifaEnvironment.FifaDb.Expand();
			FifaEnvironment.UserMessages.ShowMessage(flag ? 1010 : 1011);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0004DCC4 File Offset: 0x0004BEC4
		private void menuEnableAllMessages_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.UserMessages == null)
			{
				return;
			}
			FifaEnvironment.UserMessages.EnableMessages(true);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0004DCDC File Offset: 0x0004BEDC
		private void menuRegenerate_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.UserMessages != null)
			{
				DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(14);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			if (FifaEnvironment.FifaFat != null)
			{
				this.statusBar.Text = "Regenerating bh files";
				Cursor.Current = Cursors.WaitCursor;
				this.Refresh();
				FifaEnvironment.FifaFat.RegenerateAllBh(true);
				Cursor.Current = Cursors.Default;
				this.statusBar.Text = "Ready";
				return;
			}
			string text = this.AskUserOpenRootFolder();
			if (text == null)
			{
				return;
			}
			string[] files = Directory.GetFiles(text, "*.big");
			Cursor.Current = Cursors.WaitCursor;
			foreach (string text2 in files)
			{
				this.statusBar.Text = "Regenerating " + Path.GetFileName(text2);
				this.Refresh();
				BhFile.Regenerate(text2, true);
			}
			Cursor.Current = Cursors.Default;
			this.statusBar.Text = "Ready";
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		private void menuHelp_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.LaunchDir + "\\CreationMaster.htm";
			if (File.Exists(text))
			{
				Help.ShowHelp(this, text);
				return;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		private void menuCreatePatch_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(19);
			if (dialogResult == DialogResult.Yes)
			{
				this.SaveFiles();
			}
			else if (dialogResult == DialogResult.Cancel)
			{
				return;
			}
			MainForm.m_PatchCreatorForm.ShowDialog();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0004DE32 File Offset: 0x0004C032
		private void menuLoadPatch_Click(object sender, EventArgs e)
		{
			MainForm.m_PatchLoaderForm.ShowDialog();
			this.statusBar.Text = "Updating windows ...";
			this.statusBar.Text = "Ready";
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void menuRemoveKidProtection_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void menuCleanFAT_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void menuHelpCms_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void removeAllLongTeamNames_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void adboardsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void ballsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void bootsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void countryToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void formationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void leaguesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void stadiumsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void tournamentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0004DE60 File Offset: 0x0004C060
		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseUgc())
			{
				return;
			}
			if (!this.OpenUgcFile())
			{
				return;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(29);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_UgcFile.Import(this.m_XmlDbFileName, false, this.statusBar);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
		private void importDBAndKITSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseUgc())
			{
				return;
			}
			if (!this.OpenUgcFile())
			{
				return;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(29);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_UgcFile.Import(this.m_XmlDbFileName, true, this.statusBar);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004DF60 File Offset: 0x0004C160
		private bool OpenUgcFile()
		{
			if (this.m_UgcFileName == null)
			{
				return false;
			}
			this.m_UgcFile = new UgcFile(this.m_UgcFileName);
			if (this.m_UgcFile == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_UgcFile.NFiles; i++)
			{
				this.m_UgcFile.Extract(i, FifaEnvironment.TempFolder);
			}
			return true;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		private bool BrowseUgc()
		{
			this.openFifaDialog = new OpenFileDialog();
			this.openFifaDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FIFA 14";
			this.openFifaDialog.Filter = "UGC Files|UG*.*";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open User Generated Content file";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_UgcFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0004E040 File Offset: 0x0004C240
		private void importKITSOmlyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseUgc())
			{
				return;
			}
			if (!this.OpenUgcFile())
			{
				return;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(29);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_UgcFile.ImportKitGraphics(this.m_XmlDbFileName, this.statusBar);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		private void menuReopen_Click(object sender, EventArgs e)
		{
			if (Settings.Default.RootDir != null && Settings.Default.RootDir != string.Empty && Settings.Default.FifaDbFileName != null && Settings.Default.FifaDbFileName != string.Empty && Settings.Default.LangXmlFileName != null && Settings.Default.FifaXmlFileName != string.Empty && Settings.Default.LangDbFileName != null && Settings.Default.LangDbFileName != string.Empty && Settings.Default.LangXmlFileName != null && Settings.Default.LangXmlFileName != string.Empty)
			{
				if (!this.InitializeFifaEnvironment(Settings.Default.RootDir))
				{
					return;
				}
				Cursor.Current = Cursors.WaitCursor;
				FifaEnvironment.FifaDbFileName = Settings.Default.FifaDbFileName;
				FifaEnvironment.FifaXmlFileName = Settings.Default.FifaXmlFileName;
				FifaEnvironment.LangDbFileName = Settings.Default.LangDbFileName;
				FifaEnvironment.LangXmlFileName = Settings.Default.LangXmlFileName;
				this.Refresh();
				this.Open();
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0004E204 File Offset: 0x0004C404
		private void menuOnlineDBFifa14_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseOnline())
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_OnlineDbFile = new CareerFile(this.m_OnlineDbFileName, this.m_XmlDbFileName);
			Cursor.Current = Cursors.Default;
			if (this.m_OnlineDbFile == null)
			{
				return;
			}
			this.m_OnlineDb = this.m_OnlineDbFile.Databases[0];
			this.MergeOnlineDb(false);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0004E288 File Offset: 0x0004C488
		private bool MergeOnlineDb17(bool updatePlayers)
		{
			if (this.m_OnlineDb == null)
			{
				return false;
			}
			Table table = this.m_OnlineDb.GetTable("dcplayernames");
			Table table2 = this.m_OnlineDb.GetTable("teamplayerlinks");
			Table table3 = this.m_OnlineDb.GetTable("formations");
			Table table4 = this.m_OnlineDb.GetTable("teams");
			Table table5 = this.m_OnlineDb.GetTable("playerloans");
			Table table6 = this.m_OnlineDb.GetTable("manager");
			Table table7 = this.m_OnlineDb.GetTable("players");
			Table table8 = this.m_OnlineDb.GetTable("previousteam");
			string text = FifaEnvironment.LaunchDir + "\\Templates\\2017\\data\\db\\fifa_ng_db.xml";
			Table table9 = new DbFile(text.Replace(".xml", ".db"), text).GetTable("playernames");
			if (table == null || table2 == null || table3 == null || table4 == null || table5 == null || table6 == null || table7 == null || table8 == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(10036);
				return false;
			}
			int fieldIndex = table7.TableDescriptor.GetFieldIndex("playerid");
			int fieldIndex2 = table7.TableDescriptor.GetFieldIndex("gender");
			int fieldIndex3 = table7.TableDescriptor.GetFieldIndex("birthdate");
			for (int i = 0; i < table7.NValidRecords; i++)
			{
				Record record = table7.Records[i];
				int num = record.IntField[fieldIndex];
				int num2 = record.IntField[fieldIndex2];
				int num3 = record.IntField[fieldIndex3];
				DateTime dateTime = new DateTime((long)num3);
				if ((dateTime.Month != 12 || dateTime.Day != 29) && num != 0 && num2 == 0)
				{
					Player player = (Player)FifaEnvironment.Players.SearchId(num);
					if (player == null)
					{
						player = new Player(num);
						player.UpdateFromOnlineRecord17(record, table7.TableDescriptor);
						player.firstnameid = record.GetAndCheckIntField(table7.TableDescriptor.GetFieldIndex("firstnameid"));
						player.lastnameid = record.GetAndCheckIntField(table7.TableDescriptor.GetFieldIndex("lastnameid"));
						player.commonnameid = record.GetAndCheckIntField(table7.TableDescriptor.GetFieldIndex("commonnameid"));
						player.playerjerseynameid = record.GetAndCheckIntField(table7.TableDescriptor.GetFieldIndex("playerjerseynameid"));
						player.UpdatePlayername(table, table9);
						FifaEnvironment.Players.InsertId(player);
					}
					else if (updatePlayers)
					{
						player.UpdateFromOnlineRecord17(record, table7.TableDescriptor);
					}
				}
			}
			FifaEnvironment.Players.FillFromPlayerloans(table5);
			FifaEnvironment.Players.FillFromPreviousTeam(table8);
			int fieldIndex4 = table3.TableDescriptor.GetFieldIndex("teamid");
			int fieldIndex5 = table3.TableDescriptor.GetFieldIndex("formationid");
			for (int j = 0; j < table3.NValidRecords; j++)
			{
				Record record2 = table3.Records[j];
				int num4 = record2.IntField[fieldIndex4];
				int num5 = record2.IntField[fieldIndex5];
				if (num4 >= 0)
				{
					Formation formation = FifaEnvironment.Formations.SearchByTeamId(num4);
					if (formation != null)
					{
						formation.Load17(record2);
					}
					else if (num4 != 111 && num4 != 112 && num4 != 383 && num4 != 516 && num4 != 567 && num4 != 568 && num4 != 569 && num4 != 598 && num4 != 1035 && num4 != 1039 && num4 != 1048 && num4 != 1053 && num4 != 111042 && num4 != 111043 && num4 != 111044 && num4 != 111045 && num4 != 111046 && num4 != 111054 && num4 != 111057 && num4 != 111058 && num4 != 111072 && num4 != 111205 && num4 != 111592 && num4 != 111596 && num4 != 112001 && num4 != 112190 && num4 != 112998 && num4 != 112999 && num4 != 113000 && num4 != 113001 && num4 != 113002 && num4 != 113003 && num4 != 113004 && num4 != 113005 && num4 != 113006 && num4 != 113007 && num4 != 113008 && num4 != 113009 && num4 != 113010 && num4 != 113011 && num4 != 113012 && num4 != 113138 && num4 != 113139 && num4 != 113154 && num4 != 113155 && num4 != 113308 && num4 != 113309)
					{
						formation = new Formation(num5);
						formation.Load17(record2);
						FifaEnvironment.Formations.InsertId(formation);
					}
				}
			}
			int fieldIndex6 = table4.TableDescriptor.GetFieldIndex("teamid");
			for (int k = 0; k < table4.NValidRecords; k++)
			{
				Record record3 = table4.Records[k];
				int num6 = record3.IntField[fieldIndex6];
				if (num6 != 111 && num6 != 112 && num6 != 383 && num6 != 516 && num6 != 567 && num6 != 568 && num6 != 569 && num6 != 598 && num6 != 1035 && num6 != 1039 && num6 != 1048 && num6 != 1053 && num6 != 111042 && num6 != 111043 && num6 != 111044 && num6 != 111045 && num6 != 111046 && num6 != 111054 && num6 != 111057 && num6 != 111058 && num6 != 111072 && num6 != 111205 && num6 != 111592 && num6 != 111596 && num6 != 112001 && num6 != 112190 && num6 != 112998 && num6 != 112999 && num6 != 113000 && num6 != 113001 && num6 != 113002 && num6 != 113003 && num6 != 113004 && num6 != 113005 && num6 != 113006 && num6 != 113007 && num6 != 113008 && num6 != 113009 && num6 != 113010 && num6 != 113011 && num6 != 113012 && num6 != 113138 && num6 != 113139 && num6 != 113154 && num6 != 113155 && num6 != 113308 && num6 != 113309)
				{
					Team team = (Team)FifaEnvironment.Teams.SearchId(num6);
					if (team == null)
					{
						team = new Team(num6);
						team.Roster.ResetToEmpty();
						team.Load17(record3, table4.TableDescriptor);
						FifaEnvironment.Teams.InsertId(team);
					}
					else
					{
						team.Roster.ResetToEmpty();
						team.Load17(record3, table4.TableDescriptor);
					}
				}
			}
			FifaEnvironment.Teams.FillFromTeamPlayerLinks(table2);
			FifaEnvironment.Teams.FillFromManager(table6);
			FifaEnvironment.Players.LinkTeam(FifaEnvironment.Teams);
			FifaEnvironment.Players.LinkCountry(FifaEnvironment.Countries);
			FifaEnvironment.Teams.LinkPlayer(FifaEnvironment.Players);
			FifaEnvironment.Teams.LinkOpponent(FifaEnvironment.Teams);
			FifaEnvironment.Teams.LinkFormation(FifaEnvironment.Formations);
			FifaEnvironment.UserMessages.ShowMessage(15007);
			return true;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0004EB30 File Offset: 0x0004CD30
		private bool MergeOnlineDb(bool updatePlayers)
		{
			if (this.m_OnlineDb == null)
			{
				return false;
			}
			Table table = this.m_OnlineDb.GetTable("dcplayernames");
			Table table2 = this.m_OnlineDb.GetTable("teamplayerlinks");
			Table table3 = this.m_OnlineDb.GetTable("formations");
			Table table4 = this.m_OnlineDb.GetTable("teams");
			Table table5 = this.m_OnlineDb.GetTable("playerloans");
			Table table6 = this.m_OnlineDb.GetTable("manager");
			Table table7 = this.m_OnlineDb.GetTable("players");
			Table table8 = this.m_OnlineDb.GetTable("previousteam");
			Table table9 = FifaEnvironment.OriginalFifaDb.GetTable("playernames");
			if (table == null || table2 == null || table3 == null || table4 == null || table5 == null || table6 == null || table7 == null || table8 == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(10036);
				return false;
			}
			int fieldIndex = table7.TableDescriptor.GetFieldIndex("playerid");
			for (int i = 0; i < table7.NValidRecords; i++)
			{
				Record record = table7.Records[i];
				int num = record.IntField[fieldIndex];
				if (num != 0)
				{
					Player player = (Player)FifaEnvironment.Players.SearchId(num);
					if (player == null)
					{
						player = new Player(record);
						player.UpdatePlayername(table, table9);
						FifaEnvironment.Players.InsertId(player);
					}
					else if (updatePlayers)
					{
						player.UpdateFromOnlineRecord17(record, table7.TableDescriptor);
					}
				}
			}
			FifaEnvironment.Players.FillFromPlayerloans(table5);
			FifaEnvironment.Players.FillFromPreviousTeam(table8);
			for (int j = 0; j < table3.NValidRecords; j++)
			{
				Record record2 = table3.Records[j];
				int num2 = record2.IntField[FI.formations_teamid];
				int num3 = record2.IntField[FI.formations_formationid];
				if (num2 >= 0)
				{
					Formation formation = (Formation)FifaEnvironment.Formations.SearchId(num3);
					if (formation != null)
					{
						formation.Load(record2);
					}
					else
					{
						formation = new Formation(record2);
						FifaEnvironment.Formations.InsertId(formation);
					}
				}
			}
			for (int k = 0; k < table4.NValidRecords; k++)
			{
				Record record3 = table4.Records[k];
				int num4 = record3.IntField[FI.teams_teamid];
				Team team = (Team)FifaEnvironment.Teams.SearchId(num4);
				if (team != null)
				{
					team.Roster.ResetToEmpty();
					team.Load(record3);
				}
			}
			FifaEnvironment.Teams.FillFromTeamPlayerLinks(table2);
			FifaEnvironment.Teams.FillFromFormations(table3);
			FifaEnvironment.Teams.FillFromManager(table6);
			FifaEnvironment.Players.LinkTeam(FifaEnvironment.Teams);
			FifaEnvironment.Players.LinkCountry(FifaEnvironment.Countries);
			FifaEnvironment.Teams.LinkPlayer(FifaEnvironment.Players);
			FifaEnvironment.Teams.LinkOpponent(FifaEnvironment.Teams);
			FifaEnvironment.Teams.LinkFormation(FifaEnvironment.Formations);
			FifaEnvironment.UserMessages.ShowMessage(15007);
			return true;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0004EE0C File Offset: 0x0004D00C
		private bool BrowseOnline()
		{
			this.openFifaDialog = new OpenFileDialog();
			this.openFifaDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FIFA 14";
			this.openFifaDialog.Filter = "Online Files|Squad*.*;FutSquads*.*;MatchDay*.*";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open DB Update file";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_OnlineDbFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			this.openFifaDialog.Dispose();
			return flag;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0004EE9C File Offset: 0x0004D09C
		private bool BrowseOnlineFifa16()
		{
			this.openFifaDialog = new OpenFileDialog();
			this.openFifaDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FIFA 16\\0\\FIFA16";
			this.openFifaDialog.Filter = "Online Files|DATA*";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open DB Update file";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_OnlineDbFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			this.openFifaDialog.Dispose();
			return flag;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0004EF2C File Offset: 0x0004D12C
		private bool BrowseOnlineFifa17()
		{
			this.openFifaDialog = new OpenFileDialog();
			this.openFifaDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FIFA 17\\settings";
			this.openFifaDialog.Filter = "Online Files|Squad*;Match*";
			this.openFifaDialog.FilterIndex = 1;
			this.openFifaDialog.Title = "Open DB Update file";
			bool flag = false;
			if (this.openFifaDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_OnlineDbFileName = this.openFifaDialog.FileName;
				flag = true;
			}
			this.openFifaDialog.Dispose();
			return flag;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0004EFBC File Offset: 0x0004D1BC
		private void uGContentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseUgc())
			{
				return;
			}
			if (!this.OpenUgcFile())
			{
				return;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(29);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_UgcFile.UpdateRosters(this.m_XmlDbFileName, false, this.statusBar);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0004F03C File Offset: 0x0004D23C
		private void menuAlignLanguageDB_Click(object sender, EventArgs e)
		{
			this.openLangDialog.CheckFileExists = true;
			this.openLangDialog.InitialDirectory = FifaEnvironment.GameDir + "data\\loc\\";
			this.openLangDialog.Filter = "db files (*.db)|*.db";
			this.openLangDialog.FilterIndex = 1;
			this.openLangDialog.Title = "Open Language Database";
			if (this.openLangDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = this.openLangDialog.FileName;
			if (fileName == FifaEnvironment.LangDbFileName)
			{
				return;
			}
			DbFile dbFile = new DbFile(fileName, FifaEnvironment.LangXmlFileName);
			if (dbFile == null)
			{
				return;
			}
			Table table = FifaEnvironment.LangDb.Table[0];
			Table table2 = dbFile.Table[0];
			int num = 0;
			int[] array = new int[table.NValidRecords];
			string[] array2 = new string[table.NValidRecords];
			string[] array3 = new string[table.NValidRecords];
			Cursor.Current = Cursors.WaitCursor;
			this.statusBar.Text = "Analizing the language database...";
			this.Refresh();
			for (int i = 0; i < table.NValidRecords; i++)
			{
				Record record = table.Records[i];
				bool flag = false;
				for (int j = 0; j < table2.NValidRecords; j++)
				{
					if (table.Records[j].IntField[FI.language_hashid] == record.IntField[FI.language_hashid])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					array[num] = record.IntField[FI.language_hashid];
					array2[num] = record.CompressedString[FI.language_sourcetext];
					array3[num] = record.CompressedString[FI.language_stringid];
					num++;
				}
			}
			Cursor.Current = Cursors.Default;
			if (num > 0)
			{
				int num2 = table2.NValidRecords;
				Table table3 = table2;
				table3.ResizeRecords(table3.NValidRecords + num);
				for (int k = 0; k < num; k++)
				{
					table2.Records[num2].IntField[FI.language_hashid] = array[k];
					table2.Records[num2].CompressedString[FI.language_sourcetext] = array2[k];
					table2.Records[num2].CompressedString[FI.language_stringid] = array3[k];
					num2++;
				}
				dbFile.SaveDb();
				this.statusBar.Text = fileName + " has been aligned.";
				return;
			}
			this.statusBar.Text = fileName + " was already aligned.";
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0004F29C File Offset: 0x0004D49C
		private void menuImportUgcPlayers_Click(object sender, EventArgs e)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseUgc())
			{
				return;
			}
			if (!this.OpenUgcFile())
			{
				return;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(29);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_UgcFile.ImportPlayers(this.m_XmlDbFileName, false, this.statusBar);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0004F31C File Offset: 0x0004D51C
		private void minimizeNamesTableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			foreach (object obj in FifaEnvironment.PlayerNamesList)
			{
				((PlayerName)obj).IsOriginal = false;
			}
			foreach (object obj2 in FifaEnvironment.Players)
			{
				Player player = (Player)obj2;
				Player player2 = player;
				player2.firstname = player2.firstname.Trim();
				foreach (object obj3 in FifaEnvironment.PlayerNamesList)
				{
					PlayerName playerName = (PlayerName)obj3;
					if (playerName.Text == player.firstname)
					{
						if (player.firstnameid != playerName.Id && playerName.CommentaryId == 900000)
						{
							FifaEnvironment.PlayerNamesList.RemoveId(player.firstnameid);
							player.firstnameid = playerName.Id;
							break;
						}
						break;
					}
				}
				Player player3 = player;
				player3.lastname = player3.lastname.Trim();
				foreach (object obj4 in FifaEnvironment.PlayerNamesList)
				{
					PlayerName playerName2 = (PlayerName)obj4;
					if (playerName2.Text == player.lastname)
					{
						if (player.lastnameid != playerName2.Id && playerName2.CommentaryId == 900000)
						{
							FifaEnvironment.PlayerNamesList.RemoveId(player.lastnameid);
							player.lastnameid = playerName2.Id;
							break;
						}
						break;
					}
				}
				Player player4 = player;
				player4.commonname = player4.commonname.Trim();
				if (player.commonnameid != 0)
				{
					if (player.commonname.IndexOf('.') >= 0)
					{
						if (player.playerjerseynameid == player.commonnameid)
						{
							Player player5 = player;
							player5.playerjerseynameid = player5.lastnameid;
							Player player6 = player;
							player6.playerjerseyname = player6.lastname;
						}
						player.commonname = string.Empty;
						player.commonnameid = 0;
					}
					else if (player.playerjerseynameid != player.commonnameid)
					{
						Player player7 = player;
						player7.playerjerseynameid = player7.commonnameid;
						Player player8 = player;
						player8.playerjerseyname = player8.commonname;
					}
				}
				foreach (object obj5 in FifaEnvironment.PlayerNamesList)
				{
					PlayerName playerName3 = (PlayerName)obj5;
					if (playerName3.Text == player.commonname)
					{
						if (player.commonnameid != playerName3.Id && playerName3.CommentaryId == 900000)
						{
							FifaEnvironment.PlayerNamesList.RemoveId(player.commonnameid);
							player.commonnameid = playerName3.Id;
							break;
						}
						break;
					}
				}
				Player player9 = player;
				player9.playerjerseyname = player9.playerjerseyname.Trim();
				if (player.playerjerseyname.IndexOf('.') >= 0)
				{
					Player player10 = player;
					player10.playerjerseynameid = player10.lastnameid;
					Player player11 = player;
					player11.playerjerseyname = player11.lastname;
				}
				foreach (object obj6 in FifaEnvironment.PlayerNamesList)
				{
					PlayerName playerName4 = (PlayerName)obj6;
					if (playerName4.Text == player.playerjerseyname)
					{
						if (player.playerjerseynameid != playerName4.Id && playerName4.CommentaryId == 900000)
						{
							FifaEnvironment.PlayerNamesList.RemoveId(player.playerjerseynameid);
							player.playerjerseynameid = playerName4.Id;
							break;
						}
						break;
					}
				}
			}
			foreach (object obj7 in FifaEnvironment.Players)
			{
				Player player12 = (Player)obj7;
				if (player12.firstnameid >= 29000)
				{
					FifaEnvironment.PlayerNamesList.RemoveId(player12.firstnameid);
					player12.firstnameid = FifaEnvironment.PlayerNamesList.GetKey(player12.firstname);
				}
				if (player12.lastnameid >= 29000)
				{
					FifaEnvironment.PlayerNamesList.RemoveId(player12.lastnameid);
					player12.lastnameid = FifaEnvironment.PlayerNamesList.GetKey(player12.lastname);
				}
				if (player12.commonnameid >= 29000)
				{
					FifaEnvironment.PlayerNamesList.RemoveId(player12.commonnameid);
					player12.commonnameid = FifaEnvironment.PlayerNamesList.GetKey(player12.commonname);
				}
				if (player12.playerjerseynameid >= 29000)
				{
					FifaEnvironment.PlayerNamesList.RemoveId(player12.playerjerseynameid);
					player12.playerjerseynameid = FifaEnvironment.PlayerNamesList.GetKey(player12.playerjerseyname);
				}
			}
			Cursor.Current = Cursors.Default;
			int num = 29000 - FifaEnvironment.PlayerNamesList.Count;
			this.statusBar.Text = "Names updated, " + num.ToString() + " names still availbale. Ready!";
			FifaEnvironment.UserMessages.ShowMessage(1036);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0004F8C8 File Offset: 0x0004DAC8
		private void menuPreserveOriginalNames_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			this.statusBar.Text = "Comparing current names with original names...";
			this.Refresh();
			for (int i = 0; i < FifaEnvironment.PlayerNamesList.Count; i++)
			{
				PlayerName playerName = (PlayerName)FifaEnvironment.PlayerNamesList[i];
				PlayerName playerName2 = (PlayerName)FifaEnvironment.OriginalPlayerNamesList.SearchId(playerName.Id);
				if (playerName2 != null)
				{
					if (playerName2.Text != playerName.Text)
					{
						FifaEnvironment.PlayerNamesList.RemoveId(playerName.Id);
						playerName2.IsOriginal = true;
						FifaEnvironment.PlayerNamesList.InsertId(playerName2);
						playerName.Id = FifaEnvironment.PlayerNamesList.GetNewId();
						FifaEnvironment.PlayerNamesList.InsertId(playerName);
					}
					else
					{
						playerName.IsOriginal = true;
						playerName.CommentaryId = playerName2.CommentaryId;
					}
				}
			}
			this.statusBar.Text = "Recovering missed original names ...";
			this.Refresh();
			for (int j = 0; j < FifaEnvironment.OriginalPlayerNamesList.Count; j++)
			{
				PlayerName playerName3 = (PlayerName)FifaEnvironment.OriginalPlayerNamesList[j];
				if ((PlayerName)FifaEnvironment.PlayerNamesList.SearchId(playerName3.Id) == null)
				{
					playerName3.IsOriginal = true;
					FifaEnvironment.PlayerNamesList.InsertId(playerName3);
				}
			}
			this.statusBar.Text = "Updating player names...";
			this.Refresh();
			foreach (object obj in FifaEnvironment.Players)
			{
				Player player = (Player)obj;
				PlayerName playerName4 = FifaEnvironment.OriginalPlayerNamesList.SearchName(player.firstname);
				if (playerName4 != null)
				{
					player.firstnameid = playerName4.Id;
				}
				else
				{
					playerName4 = FifaEnvironment.PlayerNamesList.SearchName(player.firstname);
					if (playerName4 != null)
					{
						player.firstnameid = playerName4.Id;
					}
				}
				playerName4 = FifaEnvironment.OriginalPlayerNamesList.SearchName(player.lastname);
				if (playerName4 != null)
				{
					player.lastnameid = playerName4.Id;
				}
				else
				{
					playerName4 = FifaEnvironment.PlayerNamesList.SearchName(player.lastname);
					if (playerName4 != null)
					{
						player.lastnameid = playerName4.Id;
					}
				}
				playerName4 = FifaEnvironment.OriginalPlayerNamesList.SearchName(player.commonname);
				if (playerName4 != null)
				{
					player.commonnameid = playerName4.Id;
				}
				else
				{
					playerName4 = FifaEnvironment.PlayerNamesList.SearchName(player.commonname);
					if (playerName4 != null)
					{
						player.commonnameid = playerName4.Id;
					}
				}
				playerName4 = FifaEnvironment.OriginalPlayerNamesList.SearchName(player.playerjerseyname);
				if (playerName4 != null)
				{
					player.playerjerseynameid = playerName4.Id;
				}
				else
				{
					playerName4 = FifaEnvironment.PlayerNamesList.SearchName(player.playerjerseyname);
					if (playerName4 != null)
					{
						player.playerjerseynameid = playerName4.Id;
					}
				}
				player.UpdateNamesAndCommentary();
			}
			int num = 29000 - FifaEnvironment.PlayerNamesList.Count;
			this.statusBar.Text = "Names updated, " + num.ToString() + " names still availbale. Ready!";
			Cursor.Current = Cursors.Default;
			FifaEnvironment.UserMessages.ShowMessage(1036);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0004FC08 File Offset: 0x0004DE08
		private string RemoveDottedInitial(string text)
		{
			while (text.IndexOf('.') == 1)
			{
				text = text.Substring(2);
			}
			return text;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0004FC24 File Offset: 0x0004DE24
		private void UpdateOnline16(bool updatePlayers)
		{
			if (FifaEnvironment.FifaXmlFileName != null)
			{
				this.m_XmlDbFileName = FifaEnvironment.FifaXmlFileName;
			}
			else if (!this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseOnlineFifa16())
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_OnlineDbFile = new CareerFile(this.m_OnlineDbFileName, this.m_XmlDbFileName);
			Cursor.Current = Cursors.Default;
			if (this.m_OnlineDbFile == null)
			{
				return;
			}
			if (this.m_OnlineDbFile.Databases[1] != null || this.m_OnlineDbFile.Databases[2] != null || this.m_OnlineDbFile.Databases[3] != null)
			{
				FifaEnvironment.UserMessages.ShowMessage(10036);
				return;
			}
			this.m_OnlineDb = this.m_OnlineDbFile.Databases[0];
			this.MergeOnlineDb(updatePlayers);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		private void UpdateOnline17(bool updatePlayers)
		{
			string text = FifaEnvironment.LaunchDir + "\\Templates\\2017\\data\\db\\fifa_ng_db.xml";
			if (FifaEnvironment.FifaXmlFileName == null && !this.BrowseXmlDb())
			{
				return;
			}
			if (!this.BrowseOnlineFifa17())
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_OnlineDbFile = new CareerFile(this.m_OnlineDbFileName, text);
			Cursor.Current = Cursors.Default;
			if (this.m_OnlineDbFile == null)
			{
				return;
			}
			if (this.m_OnlineDbFile.Databases[1] != null || this.m_OnlineDbFile.Databases[2] != null || this.m_OnlineDbFile.Databases[3] != null)
			{
				FifaEnvironment.UserMessages.ShowMessage(10036);
				return;
			}
			this.m_OnlineDb = this.m_OnlineDbFile.Databases[0];
			this.MergeOnlineDb17(updatePlayers);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0004FDA2 File Offset: 0x0004DFA2
		private void menuOnlineDBFifa16_Click(object sender, EventArgs e)
		{
			this.UpdateOnline16(true);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0004FDAB File Offset: 0x0004DFAB
		private void rostersOnlineDBFIFA16ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.UpdateOnline16(false);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		private void rostersOnlyFromFifa17_Click(object sender, EventArgs e)
		{
			this.UpdateOnline17(false);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0004FDBD File Offset: 0x0004DFBD
		private void rostersAndPlayersFromFifa17_Click(object sender, EventArgs e)
		{
			this.UpdateOnline17(true);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0004FDC6 File Offset: 0x0004DFC6
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (!this.InitializeFifaEnvironment(15))
			{
				return;
			}
			if (!this.AskUserOpenLangDatabase())
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0004FDE2 File Offset: 0x0004DFE2
		private void menuOpenFifa16_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (!this.InitializeFifaEnvironment(16))
			{
				return;
			}
			this.Refresh();
			this.Open();
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0004FE0F File Offset: 0x0004E00F
		private void menuOpenLang16_Click(object sender, EventArgs e)
		{
			if (!this.InitializeFifaEnvironment(16))
			{
				return;
			}
			if (!this.AskUserOpenLangDatabase())
			{
				return;
			}
			this.Open();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0004FE2B File Offset: 0x0004E02B
		private void installRevModPatchsimplifiedVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FifaEnvironment.ExtractRevModFiles();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0004FE33 File Offset: 0x0004E033
		private void playerNameCountryRulesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ApplyCountryRules();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0004FE3C File Offset: 0x0004E03C
		private void ApplyCountryRules()
		{
			foreach (object obj in FifaEnvironment.Players)
			{
				Player player = (Player)obj;
				if (player.nationality == 183 && player.playerjerseyname != player.firstname && player.playerjerseyname != player.lastname)
				{
					Player player2 = player;
					player2.playerjerseyname = player2.lastname;
				}
			}
			foreach (object obj2 in FifaEnvironment.Players)
			{
				Player player3 = (Player)obj2;
				if (player3.nationality == 167 || player3.nationality == 166)
				{
					string text = player3.firstname;
					string lastname = player3.lastname;
					string text2 = player3.commonname;
					string playerjerseyname = player3.playerjerseyname;
					if (text != null && text != string.Empty)
					{
						text = text.Replace(' ', '-');
						player3.firstname = string.Empty;
					}
					if (lastname != null && lastname != string.Empty)
					{
						player3.lastname = string.Empty;
					}
					if (text2 != null && text2 != string.Empty)
					{
						int num = text2.IndexOf(' ');
						int num2 = text2.LastIndexOf(' ');
						if (num != num2)
						{
							text2 = text2.Substring(0, num2) + "-" + text2.Substring(num2 + 1);
						}
					}
					else
					{
						text2 = text + " " + lastname;
					}
					player3.commonname = text2;
					Player player4 = player3;
					player4.playerjerseyname = player4.commonname;
				}
			}
			foreach (object obj3 in FifaEnvironment.Players)
			{
				Player player5 = (Player)obj3;
				if (player5.nationality == 54)
				{
					if (player5.firstname.Contains(player5.playerjerseyname) && player5.firstname != player5.playerjerseyname)
					{
						Player player6 = player5;
						player6.firstname = player6.playerjerseyname;
					}
					int num3 = player5.playerjerseyname.IndexOf(' ');
					if (num3 != -1)
					{
						string text3 = player5.playerjerseyname.Substring(0, num3);
						string text4 = player5.playerjerseyname.Substring(num3 + 1);
						if (player5.firstname.Contains(text3) && player5.lastname.Contains(text4))
						{
							player5.firstname = text3;
							player5.lastname = text4;
							if (player5.commonname == string.Empty)
							{
								Player player7 = player5;
								player7.audioname = player7.lastname;
								player5.commentaryid = -1;
							}
						}
					}
				}
			}
			foreach (object obj4 in FifaEnvironment.Players)
			{
				Player player8 = (Player)obj4;
				if (player8.nationality == 38)
				{
					int num3 = player8.playerjerseyname.IndexOf(' ');
					if (num3 != -1)
					{
						string text5 = player8.playerjerseyname.Substring(0, num3);
						string text6 = player8.playerjerseyname.Substring(num3 + 1);
						if (player8.firstname.Contains(text5) && player8.lastname.Contains(text6))
						{
							player8.firstname = text5;
							player8.lastname = text6;
							if (player8.commonname == string.Empty)
							{
								Player player9 = player8;
								player9.audioname = player9.lastname;
								player8.commentaryid = -1;
							}
						}
					}
				}
			}
			foreach (object obj5 in FifaEnvironment.Players)
			{
				Player player10 = (Player)obj5;
				if (player10.nationality == 45 && player10.playerjerseyname != null && player10.lastname != player10.playerjerseyname)
				{
					if (player10.lastname.Contains(player10.playerjerseyname))
					{
						Player player11 = player10;
						player11.lastname = player11.playerjerseyname;
						if (player10.commonname == string.Empty)
						{
							Player player12 = player10;
							player12.audioname = player12.lastname;
							player10.commentaryid = -1;
						}
					}
					int num3 = player10.playerjerseyname.IndexOf(' ');
					if (num3 != -1)
					{
						string text7 = player10.playerjerseyname.Substring(num3 + 1);
						if (player10.lastname != text7 && player10.lastname.Contains(text7 + " "))
						{
							player10.lastname = text7;
							if (player10.commonname == string.Empty)
							{
								Player player13 = player10;
								player13.audioname = player13.lastname;
								player10.commentaryid = -1;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0005038C File Offset: 0x0004E58C
		private void removeFakePlayersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (int i = 0; i < FifaEnvironment.Players.Count; i++)
			{
				Player player = (Player)FifaEnvironment.Players[i];
				bool flag = false;
				if (player.birthdate.Day == 29 && player.birthdate.Month == 2)
				{
					if (player.m_PlayingForTeams.Count == 0)
					{
						flag = true;
					}
					else if (((Team)player.m_PlayingForTeams[0]).Country.Id == 54)
					{
						flag = true;
					}
					if (flag)
					{
						while (player.m_PlayingForTeams.Count > 0)
						{
							((Team)player.m_PlayingForTeams[0]).RemoveTeamPlayer(player);
						}
						FifaEnvironment.Players.DeletePlayer(player);
						i--;
						num++;
					}
				}
			}
			this.statusBar.Text = "Removed " + num.ToString() + " palyers.";
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00050484 File Offset: 0x0004E684
		private bool ReplaceName(Player player, string wrongName, string rightName)
		{
			bool flag = false;
			if (player.lastname == wrongName)
			{
				player.lastname = rightName;
				flag = true;
			}
			if (player.playerjerseyname == wrongName)
			{
				player.playerjerseyname = rightName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void exportKitsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000504C4 File Offset: 0x0004E6C4
		private void PrintPlayer(StreamWriter sw, Player player)
		{
			char c = ',';
			string text = player.Id.ToString();
			sw.Write(text);
			sw.Write(c);
			sw.Write(player.firstname);
			sw.Write(c);
			sw.Write(player.lastname);
			sw.Write(c);
			sw.Write(player.commonname);
			sw.Write(c);
			sw.Write(player.playerjerseyname);
			sw.Write(c);
			text = player.birthdate.ToString("dd/MM/yyyy");
			sw.Write(text);
			sw.Write(c);
			text = player.Country.ToString();
			sw.Write(text);
			sw.Write(c);
			text = ((ERole)player.preferredposition1).ToString();
			sw.Write(text);
			sw.Write(c);
			text = player.height.ToString();
			sw.Write(text);
			sw.Write(c);
			text = player.weight.ToString();
			sw.Write(text);
			sw.Write(c);
			text = player.overallrating.ToString();
			sw.Write(text);
			sw.Write(c);
			text = player.contractvaliduntil.ToString();
			sw.Write(text);
			sw.Write(c);
			text = player.joindate.ToString("dd/MM/yyyy");
			sw.Write(text);
			sw.Write(c);
			if (player.PreviousTeam != null)
			{
				text = player.PreviousTeam.ToString();
				text = text + " (" + player.PreviousTeam.Id.ToString() + ")";
				sw.Write(text);
			}
			sw.Write(c);
			text = (player.IsLoaned ? "Y" : "N");
			sw.Write(text);
			sw.Write(c);
			if (player.IsLoaned)
			{
				text = player.loandateend.ToString("dd/MM/yyyy");
				sw.Write(text);
				sw.Write(c);
				text = player.TeamLoanedFrom.ToString();
				text = text + " (" + player.TeamLoanedFrom.Id.ToString() + ")";
				sw.Write(text);
				sw.Write(c);
			}
			else
			{
				sw.Write(c);
				sw.Write(c);
			}
			sw.Write("\r\n");
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00050724 File Offset: 0x0004E924
		private void PrintTeamPlayer(StreamWriter sw, TeamPlayer teamPlayer)
		{
			char c = ',';
			if (teamPlayer != null)
			{
				string text = teamPlayer.Team.ToString();
				text = text + " (" + teamPlayer.Team.Id.ToString() + ")";
				sw.Write(text);
				sw.Write(c);
				text = teamPlayer.jerseynumber.ToString();
				sw.Write(text);
				sw.Write(c);
				return;
			}
			sw.Write(c);
			sw.Write(c);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000507A4 File Offset: 0x0004E9A4
		private void exportPlayersInCSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StreamWriter streamWriter = new StreamWriter(FifaEnvironment.TempFolder + "\\rosters.csv", false, this.m_Encoder);
			streamWriter.WriteLine("Team,Num,Playerid,First Name,Last Name,Common Name,Jersey Name,Birthday,Country,Role,Height,Weight,Overall,Contract,Join Date,Previous Team,Loan,Loan End Date,Loaning Team");
			foreach (object obj in FifaEnvironment.Teams)
			{
				Team team = (Team)obj;
				if (team.IsClub())
				{
					foreach (object obj2 in team.Roster)
					{
						TeamPlayer teamPlayer = (TeamPlayer)obj2;
						this.PrintTeamPlayer(streamWriter, teamPlayer);
						this.PrintPlayer(streamWriter, teamPlayer.Player);
					}
				}
			}
			foreach (object obj3 in FifaEnvironment.Players)
			{
				Player player = (Player)obj3;
				if (player.IsFreeAgent())
				{
					this.PrintTeamPlayer(streamWriter, null);
					this.PrintPlayer(streamWriter, player);
				}
			}
			streamWriter.Close();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000508E8 File Offset: 0x0004EAE8
		private int GetTeamIdFromCsv(string teamString)
		{
			int num = teamString.IndexOf('(');
			int num2 = teamString.IndexOf(')');
			return Convert.ToInt32(teamString.Substring(num + 1, num2 - num - 1));
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0005091C File Offset: 0x0004EB1C
		private void importPlayersFromCSVToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.TempFolder + "\\rosters.csv";
			if (!File.Exists(text))
			{
				return;
			}
			StreamReader streamReader = new StreamReader(text, this.m_Encoder);
			if (streamReader == null)
			{
				return;
			}
			streamReader.ReadLine() != "Team,Num,Playerid,First Name,Last Name,Common Name,Jersey Name,Birthday,Country,Role,Height,Weight,Overall,Contract,Join Date,Previous Team,Loan,Loan End Date,Loaning Team";
			char[] array = new char[] { ',' };
			string text2;
			while ((text2 = streamReader.ReadLine()) != null)
			{
				string[] array2 = text2.Split(array);
				Team team = null;
				TeamPlayer teamPlayer = null;
				int num;
				if (array2[0] != string.Empty)
				{
					num = this.GetTeamIdFromCsv(array2[0]);
					team = (Team)FifaEnvironment.Teams.SearchId(num);
				}
				num = Convert.ToInt32(array2[2]);
				Player player = (Player)FifaEnvironment.Players.SearchId(num);
				if (player == null)
				{
					player = (Player)FifaEnvironment.Players.CreateNewId(num);
				}
				if (team != null)
				{
					teamPlayer = team.Roster.SearchTeamPlayer(player);
					if (teamPlayer == null)
					{
						Team club = player.GetClub();
						if (club != null)
						{
							club.RemoveTeamPlayer(player);
						}
						teamPlayer = team.AddTeamPlayer(player);
					}
				}
				if (teamPlayer != null)
				{
					teamPlayer.jerseynumber = Convert.ToInt32(array2[1]);
				}
				if (player != null)
				{
					player.firstname = array2[3];
					player.lastname = array2[4];
					player.commonname = array2[5];
					player.playerjerseyname = array2[6];
					if (array2[7] != string.Empty)
					{
						DateTime dateTime = Convert.ToDateTime(array2[7]);
						player.birthdate = dateTime;
					}
					Country country = FifaEnvironment.Countries.SearchCountry(array2[8]);
					if (country != null)
					{
						player.Country = country;
					}
					player.height = Convert.ToInt32(array2[10]);
					player.weight = Convert.ToInt32(array2[11]);
					int num2 = Convert.ToInt32(array2[12]);
					player.ChangeSkills(num2 - player.overallrating);
					ERole erole = Role.ConvertToERole(array2[9]);
					if (erole != ERole.Tribune)
					{
						bool flag = player.preferredposition1 != (int)erole;
						player.preferredposition1 = (int)erole;
						if (flag)
						{
							player.RandomizeSkillsExactly(num2);
						}
					}
					player.contractvaliduntil = Convert.ToInt32(array2[13]);
					if (array2[14] != string.Empty)
					{
						DateTime dateTime = Convert.ToDateTime(array2[14]);
						player.joindate = dateTime;
					}
					if (array2[15] != string.Empty)
					{
						num = this.GetTeamIdFromCsv(array2[15]);
						team = (Team)FifaEnvironment.Teams.SearchId(num);
						if (team != null)
						{
							player.PreviousTeam = team;
						}
					}
					player.IsLoaned = array2[16] == "Y";
					if (player.IsLoaned)
					{
						if (array2[17] != string.Empty)
						{
							DateTime dateTime = Convert.ToDateTime(array2[17]);
							player.loandateend = dateTime;
						}
						if (array2[18] != string.Empty)
						{
							num = this.GetTeamIdFromCsv(array2[18]);
							team = (Team)FifaEnvironment.Teams.SearchId(num);
							if (team != null)
							{
								player.TeamLoanedFrom = team;
							}
						}
					}
					else
					{
						player.TeamLoanedFrom = null;
					}
				}
			}
			streamReader.Close();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00050C3C File Offset: 0x0004EE3C
		private void fixLoanDatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (object obj in FifaEnvironment.Players)
			{
				Player player = (Player)obj;
				if (player.IsLoaned)
				{
					int num = player.loandateend.Year;
					int num2 = player.loandateend.Month;
					int num3 = player.loandateend.Day;
					int contractvaliduntil = player.contractvaliduntil;
					bool flag = false;
					if (num <= 2016)
					{
						num = 2017;
						flag = true;
					}
					if (num2 == 1 && num3 != 1)
					{
						num3 = 1;
						flag = true;
					}
					else if (num2 == 2 || num2 == 3)
					{
						num2 = 3;
						num3 = 31;
						flag = true;
					}
					else if (num2 >= 4 && num2 <= 5)
					{
						num2 = 6;
						num3 = 30;
						flag = true;
					}
					else if (num2 == 6 && num3 != 30)
					{
						num2 = 6;
						num3 = 30;
						flag = true;
					}
					else if (num2 == 7)
					{
						num2 = 6;
						num3 = 30;
						flag = true;
					}
					else if (num2 >= 8 && num2 <= 9)
					{
						num2 = 9;
						num3 = 30;
						flag = true;
					}
					else if (num2 >= 10 && num2 <= 11)
					{
						num2 = 12;
						num3 = 31;
						flag = true;
					}
					else if (num2 == 12 && num3 != 31)
					{
						num2 = 12;
						num3 = 31;
						flag = true;
					}
					if (contractvaliduntil <= num)
					{
						player.contractvaliduntil = num + 1;
					}
					if (flag)
					{
						player.loandateend = new DateTime(num, num2, num3);
					}
				}
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00050DB8 File Offset: 0x0004EFB8
		private void FixFormations()
		{
			string[] array = new string[25];
			float[] array2 = new float[]
			{
				3f, 3f, 3.5f, 3f, 4f, 3f, 4f, 6f, 6f, 5f,
				5f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4.5f, 4f,
				5f, 4f, 4f, 4.5f, 4f
			};
			float[] array3 = new float[]
			{
				4f, 5f, 4.5f, 4.5f, 4f, 5f, 2f, 2f, 2f, 3f,
				4f, 3f, 3f, 3.5f, 3.5f, 4f, 4f, 3.5f, 3.5f, 4.5f,
				4f, 4.5f, 5f, 4.5f, 5f
			};
			float[] array4 = new float[]
			{
				3f, 2f, 2f, 2.5f, 2f, 2f, 4f, 1f, 2f, 2f,
				1f, 3f, 3f, 2.5f, 2.5f, 2f, 2f, 2.5f, 2f, 1.5f,
				1f, 1.5f, 1f, 1f, 1f
			};
			RuntimeHelpers.InitializeArray(new int[25], fieldof(<PrivateImplementationDetails>.EF91AB0BCDBB200C3924BAD356638EC3E4427D63).FieldHandle);
			int[] array5 = new int[]
			{
				0, 0, 1, 1, 1, 1, 2, 3, 4, 4,
				5, 6, 7, 8, 9, 10, 10, 11, 12, 13,
				14, 14, 14, 15, 15
			};
			array[0] = "3-4-3";
			array[1] = "3-4-2-1";
			array[2] = "3-1-4-2";
			array[3] = "3-4-1-2";
			array[4] = "3-5-1-1";
			array[5] = "3-5-2";
			array[6] = "4-2-4";
			array[7] = "5-2-2-1";
			array[8] = "5-2-1-2";
			array[9] = "5-3-2";
			array[10] = "5-4-1";
			array[11] = "4-3-3";
			array[12] = "4-3-3 F";
			array[13] = "4-3-2-1";
			array[14] = "4-3-1-2";
			array[15] = "4-2-2-2";
			array[16] = "4-4-2";
			array[17] = "4-1-2-1-2";
			array[18] = "4-1-3-2";
			array[19] = "4-4-1-1";
			array[20] = "4-2-3-1";
			array[21] = "unused";
			array[22] = "unused";
			array[23] = "4-1-4-1";
			array[24] = "4-5-1";
			for (int i = 0; i < FifaEnvironment.Formations.Count; i++)
			{
				Formation formation = (Formation)FifaEnvironment.Formations[i];
				if (!formation.IsGeneric())
				{
					for (int j = array.Length - 1; j >= 0; j--)
					{
						if (formation.formationname.Contains(array[j]))
						{
							formation.formationaudioid = array5[j];
							formation.defenders = array2[j];
							formation.midfielders = array3[j];
							formation.attackers = array4[j];
							break;
						}
					}
				}
				if (formation.IsGeneric() && i >= 34)
				{
					FifaEnvironment.Formations.DeleteId(formation);
					i--;
				}
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00050FB8 File Offset: 0x0004F1B8
		private void FixPlayers()
		{
			bool flag = File.Exists(FifaEnvironment.GameDir + Player.GenericSkinTextureFileName(1, 0));
			foreach (object obj in FifaEnvironment.Players)
			{
				Player player = (Player)obj;
				if (player.facialhairtypecode >= 16)
				{
					player.facialhairtypecode = 0;
				}
				if (player.facialhaircolorcode >= 5)
				{
					player.facialhairtypecode %= 5;
				}
				if (player.haircolorcode >= 13)
				{
					player.haircolorcode = 0;
				}
				if (player.bodytypecode >= 18)
				{
					player.bodytypecode = 2;
				}
				if (!flag && (player.skintypecode == 1 || player.skintypecode == 3) && !player.HasSpecificHeadModel)
				{
					player.skintypecode = 2;
				}
				if (player.skintypecode == 7 && !player.HasSpecificHeadModel)
				{
					player.skintypecode = 8;
				}
				if ((Shoes)FifaEnvironment.Shoes.SearchId(player.shoetypecode) == null)
				{
					player.shoetypecode = 0;
					player.shoedesigncode = 1;
					player.shoecolorcode1 = 15;
					player.shoecolorcode2 = 0;
				}
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000510E0 File Offset: 0x0004F2E0
		private void setFormationAudioAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.FixFormations();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000510E8 File Offset: 0x0004F2E8
		private void fixPlayerAppearanceProblemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.FixPlayers();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000510F0 File Offset: 0x0004F2F0
		private void FixProblems_Click(object sender, EventArgs e)
		{
			foreach (object obj in FifaEnvironment.Countries)
			{
				Country country = (Country)obj;
				if (country.NationalTeam != null)
				{
					if (country.WorldCupTarget == 0)
					{
						country.WorldCupTarget = 6;
					}
					if (country.ContinentalCupTarget == 0)
					{
						switch (country.Confederation)
						{
						case 1:
							country.ContinentalCupTarget = 6;
							break;
						case 2:
						case 3:
						case 4:
						case 6:
							country.ContinentalCupTarget = 4;
							break;
						}
					}
				}
			}
			foreach (object obj2 in FifaEnvironment.Teams)
			{
				Team team = (Team)obj2;
				if (team.DatabaseName == string.Empty)
				{
					Team team2 = team;
					team2.DatabaseName = team2.TeamNameFull;
				}
				if (team.TeamNameFull == string.Empty)
				{
					Team team3 = team;
					team3.TeamNameFull = team3.DatabaseName;
				}
				Team team4 = team;
				team4.SetNameAutomatically(team4.TeamNameFull, 15);
				Team team5 = team;
				team5.SetNameAutomatically(team5.TeamNameAbbr15, 10);
				Team team6 = team;
				team6.SetNameAutomatically(team6.TeamNameAbbr10, 7);
				Team team7 = team;
				team7.SetNameAutomatically(team7.TeamNameAbbr7, 3);
				if (team.IsClub() || team.IsNationalTeam())
				{
					if (team.Stadium == null)
					{
						team.Stadium = (Stadium)FifaEnvironment.Stadiums.SearchId(35);
					}
					League defaultLeague = League.GetDefaultLeague();
					if (team.League == null)
					{
						team.League = defaultLeague;
						defaultLeague.AddTeam(team);
					}
					if (team.League == defaultLeague)
					{
						team.previousyeartableposition = 1;
						team.PrevLeague = defaultLeague;
					}
					bool flag = false;
					Formation formation;
					for (int i = 0; i < FifaEnvironment.Formations.Count; i++)
					{
						formation = (Formation)FifaEnvironment.Formations[i];
						if (formation.teamid == team.Id && formation.Id != team.formationid)
						{
							FifaEnvironment.Formations.DeleteId(formation);
							i--;
						}
						if (formation.teamid == team.Id && formation.Id == team.formationid)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						formation = FifaEnvironment.Formations.CreateNewFormation();
						if (formation != null)
						{
							team.Formation = formation;
							formation.Team = team;
						}
					}
					formation = team.Formation;
					Roster roster = team.Roster;
					bool flag2 = true;
					for (int j = 0; j < 11; j++)
					{
						Role role = formation.PlayingRoles[j].Role;
						if (roster.SearchTeamPlayer(role) == null)
						{
							flag2 = false;
							break;
						}
					}
					if (!flag2)
					{
						team.AssignRoles(formation);
					}
					if (team.RivalTeam == null)
					{
						Team team8 = null;
						if (team.IsClub())
						{
							team8 = FifaEnvironment.Teams.SearchTeamByCountr(team.Country, true);
						}
						else if (team.IsNationalTeam())
						{
							team8 = (Team)FifaEnvironment.Teams.SearchId(1318);
						}
						if (team8 == null || team8 == team)
						{
							team8 = (Team)FifaEnvironment.Teams.SearchId(1);
						}
						team.RivalTeam = team8;
					}
					if ((Ball)FifaEnvironment.Balls.SearchId(team.balltype) == null)
					{
						team.balltype = 1;
					}
					if (team.objective < 0)
					{
						team.objective = 0;
					}
					if (team.highestprobable < team.objective)
					{
						Team team9 = team;
						team9.highestprobable = team9.objective;
					}
					if (team.latitude == 0 && team.longitude == 0 && team.utcoffset == 0)
					{
						Team team10 = FifaEnvironment.Teams.SearchTeamByCountr(team.Country, true);
						if (team10 != null)
						{
							team.latitude = team10.latitude;
							team.longitude = team10.longitude;
							team.utcoffset = team10.utcoffset;
						}
					}
					if (team.GetCrestDark() == null)
					{
						Bitmap crest = team.GetCrest();
						if (crest != null)
						{
							team.SetAllCrests(crest);
						}
					}
				}
			}
			this.FixPlayers();
			this.FixFormations();
		}

		// Token: 0x040004B4 RID: 1204
		public static MainForm CM;

		// Token: 0x040004B5 RID: 1205
		private int m_SplitterDistanceRight;

		// Token: 0x040004B6 RID: 1206
		private int m_SplitterDistanceBottom;

		// Token: 0x040004B7 RID: 1207
		private bool m_OpenFileFlag;

		// Token: 0x040004B8 RID: 1208
		private bool m_IsShiftPressed;

		// Token: 0x040004B9 RID: 1209
		private bool m_IsCtrlPressed;

		// Token: 0x040004BA RID: 1210
		private bool m_IsAltPressed;

		// Token: 0x040004BB RID: 1211
		private AboutForm m_AboutForm = new AboutForm();

		// Token: 0x040004BC RID: 1212
		public FormationForm m_FormationForm;

		// Token: 0x040004BD RID: 1213
		public CountryForm m_CountryForm;

		// Token: 0x040004BE RID: 1214
		public TeamForm m_TeamForm;

		// Token: 0x040004BF RID: 1215
		public KitForm m_KitForm;

		// Token: 0x040004C0 RID: 1216
		public BallForm m_BallForm;

		// Token: 0x040004C1 RID: 1217
		public ManagerForm m_ManagerForm;

		// Token: 0x040004C2 RID: 1218
		public GameGraphicForm m_GameGraphicForm;

		// Token: 0x040004C3 RID: 1219
		public WebBrowserForm m_WebBrowserForm;

		// Token: 0x040004C4 RID: 1220
		public LeagueForm m_LeagueForm;

		// Token: 0x040004C5 RID: 1221
		public ShoesForm m_ShoesForm;

		// Token: 0x040004C6 RID: 1222
		public TvForm m_TvForm;

		// Token: 0x040004C7 RID: 1223
		public NewspapersForm m_NewspapersForm;

		// Token: 0x040004C8 RID: 1224
		public RefereeForm m_RefereeForm;

		// Token: 0x040004C9 RID: 1225
		public CompetitionForm m_TrophyForm;

		// Token: 0x040004CA RID: 1226
		public PlayerForm m_PlayerForm;

		// Token: 0x040004CB RID: 1227
		public StadiumForm m_StadiumForm;

		// Token: 0x040004CC RID: 1228
		public GlovesForm m_GlovesForm;

		// Token: 0x040004CD RID: 1229
		public AudioForm m_AudioForm;

		// Token: 0x040004CE RID: 1230
		public static PatchCreatorForm m_PatchCreatorForm;

		// Token: 0x040004CF RID: 1231
		public static PatchLoaderForm m_PatchLoaderForm;

		// Token: 0x040004D0 RID: 1232
		private string m_XmlDbFileName;

		// Token: 0x040004D1 RID: 1233
		private string m_UgcFileName;

		// Token: 0x040004D2 RID: 1234
		private UgcFile m_UgcFile;

		// Token: 0x040004D3 RID: 1235
		private string m_OnlineDbFileName;

		// Token: 0x040004D4 RID: 1236
		private CareerFile m_OnlineDbFile;

		// Token: 0x040004D5 RID: 1237
		private DbFile m_OnlineDb;

		// Token: 0x040004D6 RID: 1238
		private UnicodeEncoding m_Encoder = new UnicodeEncoding();
	}
}
