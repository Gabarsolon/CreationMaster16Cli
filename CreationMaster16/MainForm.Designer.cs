namespace CreationMaster
{
	// Token: 0x02000012 RID: 18
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0005152C File Offset: 0x0004F72C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0005154C File Offset: 0x0004F74C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.MainForm));
			this.menuStrip = new global::System.Windows.Forms.MenuStrip();
			this.menuFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFifa16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenLang16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFifa15 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenLang15 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenFifa14 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenLang14 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuReopen = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuClose = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenDebug = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuTools = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuEnableAllMessages = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOptions = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuRegenerate = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuExpandDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuRemoveKidProtection = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCleanFAT = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuRemoveAllLongTeamNames = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuAlignLanguageDB = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuMinimizeNamesTable = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuPreserveOriginalNames = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuInstallRevModPatch = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exportPlayersFromCSVToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importPlayersFromCSVToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.removeFakePlayersToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.playerNameCountryRulesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fixLoanDatesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fixProblemsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuPatch = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuCreatePatch = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuLoadPatch = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuUpdateDB = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOnlineFromFifa16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rostersOnlyFromFIFA16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rostersAndPlayersFromFifa16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuOnlineFromFifa17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rostersOnlyFromFifa17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rostersAndPlayersFromFifa17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuUgc = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportUgc = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportUgcWothKits = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportUgcKits = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuImportUgcPlayers = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuHelpCms = new global::System.Windows.Forms.ToolStripMenuItem();
			this.genericToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.adboardsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ballsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bootsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.countryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fontsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.formationsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.leaguesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.stadiumsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.teamsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tournamentsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.progressBar = new global::System.Windows.Forms.ToolStripProgressBar();
			this.statusBar = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.splitVert = new global::System.Windows.Forms.SplitContainer();
			this.splitHoriz = new global::System.Windows.Forms.SplitContainer();
			this.panelMain = new global::System.Windows.Forms.Panel();
			this.panelBottom = new global::System.Windows.Forms.Panel();
			this.toolStripBottom = new global::System.Windows.Forms.ToolStrip();
			this.buttonShowBottom = new global::System.Windows.Forms.ToolStripButton();
			this.buttonHideBottom = new global::System.Windows.Forms.ToolStripButton();
			this.stripLabelBottom = new global::System.Windows.Forms.ToolStripLabel();
			this.panelRight = new global::System.Windows.Forms.Panel();
			this.toolStripRight = new global::System.Windows.Forms.ToolStrip();
			this.buttonShowRight = new global::System.Windows.Forms.ToolStripButton();
			this.buttonHideRight = new global::System.Windows.Forms.ToolStripButton();
			this.stripLabelRight = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripMain = new global::System.Windows.Forms.ToolStrip();
			this.buttonCountry = new global::System.Windows.Forms.ToolStripButton();
			this.buttonLeague = new global::System.Windows.Forms.ToolStripButton();
			this.buttonTeam = new global::System.Windows.Forms.ToolStripButton();
			this.buttonKit = new global::System.Windows.Forms.ToolStripButton();
			this.buttonPlayer = new global::System.Windows.Forms.ToolStripButton();
			this.buttonStadium = new global::System.Windows.Forms.ToolStripButton();
			this.buttonTournament = new global::System.Windows.Forms.ToolStripButton();
			this.buttonReferee = new global::System.Windows.Forms.ToolStripButton();
			this.buttonBall = new global::System.Windows.Forms.ToolStripButton();
			this.buttonShoes = new global::System.Windows.Forms.ToolStripButton();
			this.buttonManager = new global::System.Windows.Forms.ToolStripButton();
			this.buttonFormation = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSponsor = new global::System.Windows.Forms.ToolStripButton();
			this.buttonTv = new global::System.Windows.Forms.ToolStripButton();
			this.buttonNewspaper = new global::System.Windows.Forms.ToolStripButton();
			this.buttonGloves = new global::System.Windows.Forms.ToolStripButton();
			this.buttonAudio = new global::System.Windows.Forms.ToolStripButton();
			this.buttonGameGraphics = new global::System.Windows.Forms.ToolStripButton();
			this.buttonBrowser = new global::System.Windows.Forms.ToolStripButton();
			this.openFifaDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.openLangDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.browserDialog = new global::System.Windows.Forms.FolderBrowserDialog();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitVert).BeginInit();
			this.splitVert.Panel1.SuspendLayout();
			this.splitVert.Panel2.SuspendLayout();
			this.splitVert.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitHoriz).BeginInit();
			this.splitHoriz.Panel1.SuspendLayout();
			this.splitHoriz.Panel2.SuspendLayout();
			this.splitHoriz.SuspendLayout();
			this.toolStripBottom.SuspendLayout();
			this.toolStripRight.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuFile, this.menuTools, this.menuPatch, this.menuUpdateDB, this.menuUgc, this.helpToolStripMenuItem });
			this.menuStrip.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new global::System.Drawing.Size(1384, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			this.menuFile.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuOpenFifa16, this.menuOpenLang16, this.menuOpenFifa15, this.menuOpenLang15, this.menuOpenFifa14, this.menuOpenLang14, this.menuOpenAll, this.menuReopen, this.menuSave, this.menuClose,
				this.menuExit, this.menuOpenDebug
			});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new global::System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			this.menuOpenFifa16.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenFifa16.Image");
			this.menuOpenFifa16.Name = "menuOpenFifa16";
			this.menuOpenFifa16.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenFifa16.Text = "Open - FIFA 16";
			this.menuOpenFifa16.Click += new global::System.EventHandler(this.menuOpenFifa16_Click);
			this.menuOpenLang16.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenLang16.Image");
			this.menuOpenLang16.Name = "menuOpenLang16";
			this.menuOpenLang16.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenLang16.Text = "Open - Select lan.db";
			this.menuOpenLang16.Click += new global::System.EventHandler(this.menuOpenLang16_Click);
			this.menuOpenFifa15.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenFifa15.Image");
			this.menuOpenFifa15.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuOpenFifa15.Name = "menuOpenFifa15";
			this.menuOpenFifa15.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenFifa15.Text = "Open - FIFA 15";
			this.menuOpenFifa15.Visible = false;
			this.menuOpenFifa15.Click += new global::System.EventHandler(this.menuOpenFifa15Demo_Click);
			this.menuOpenLang15.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenLang15.Image");
			this.menuOpenLang15.Name = "menuOpenLang15";
			this.menuOpenLang15.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenLang15.Text = "Open - Select lan.db";
			this.menuOpenLang15.Visible = false;
			this.menuOpenLang15.Click += new global::System.EventHandler(this.toolStripMenuItem1_Click);
			this.menuOpenFifa14.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenFifa14.Image");
			this.menuOpenFifa14.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuOpenFifa14.Name = "menuOpenFifa14";
			this.menuOpenFifa14.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenFifa14.Text = "Open - FIFA 14";
			this.menuOpenFifa14.Visible = false;
			this.menuOpenFifa14.Click += new global::System.EventHandler(this.menuOpenFifa_Click);
			this.menuOpenLang14.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenLang14.Image");
			this.menuOpenLang14.Name = "menuOpenLang14";
			this.menuOpenLang14.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenLang14.Text = "Open - Select lan.db";
			this.menuOpenLang14.Visible = false;
			this.menuOpenLang14.Click += new global::System.EventHandler(this.openSelectLandbToolStripMenuItem_Click);
			this.menuOpenAll.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOpenAll.Image");
			this.menuOpenAll.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuOpenAll.Name = "menuOpenAll";
			this.menuOpenAll.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenAll.Text = "Open - Select all";
			this.menuOpenAll.Click += new global::System.EventHandler(this.openSelectAllToolStripMenuItem_Click);
			this.menuReopen.Name = "menuReopen";
			this.menuReopen.Size = new global::System.Drawing.Size(181, 22);
			this.menuReopen.Text = "Open - Recent";
			this.menuReopen.Click += new global::System.EventHandler(this.menuReopen_Click);
			this.menuSave.Enabled = false;
			this.menuSave.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuSave.Image");
			this.menuSave.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuSave.Name = "menuSave";
			this.menuSave.Size = new global::System.Drawing.Size(181, 22);
			this.menuSave.Text = "Save";
			this.menuSave.Click += new global::System.EventHandler(this.menuSave_Click);
			this.menuClose.Enabled = false;
			this.menuClose.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuClose.Image");
			this.menuClose.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuClose.Name = "menuClose";
			this.menuClose.Size = new global::System.Drawing.Size(181, 22);
			this.menuClose.Text = "Close";
			this.menuClose.Click += new global::System.EventHandler(this.menuClose_Click);
			this.menuExit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuExit.Image");
			this.menuExit.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new global::System.Drawing.Size(181, 22);
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new global::System.EventHandler(this.menuExit_Click);
			this.menuOpenDebug.Name = "menuOpenDebug";
			this.menuOpenDebug.Size = new global::System.Drawing.Size(181, 22);
			this.menuOpenDebug.Text = "Open - Demo";
			this.menuOpenDebug.Visible = false;
			this.menuTools.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuEnableAllMessages, this.menuOptions, this.menuRegenerate, this.menuExpandDatabase, this.menuRemoveKidProtection, this.menuCleanFAT, this.menuRemoveAllLongTeamNames, this.menuAlignLanguageDB, this.menuMinimizeNamesTable, this.menuPreserveOriginalNames,
				this.menuInstallRevModPatch, this.exportPlayersFromCSVToolStripMenuItem, this.importPlayersFromCSVToolStripMenuItem, this.removeFakePlayersToolStripMenuItem, this.playerNameCountryRulesToolStripMenuItem, this.fixLoanDatesToolStripMenuItem, this.fixProblemsToolStripMenuItem
			});
			this.menuTools.Name = "menuTools";
			this.menuTools.Size = new global::System.Drawing.Size(47, 20);
			this.menuTools.Text = "Tools";
			this.menuEnableAllMessages.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuEnableAllMessages.Image");
			this.menuEnableAllMessages.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuEnableAllMessages.Name = "menuEnableAllMessages";
			this.menuEnableAllMessages.Size = new global::System.Drawing.Size(296, 22);
			this.menuEnableAllMessages.Text = "Enable all messages";
			this.menuEnableAllMessages.Click += new global::System.EventHandler(this.menuEnableAllMessages_Click);
			this.menuOptions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuOptions.Image");
			this.menuOptions.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new global::System.Drawing.Size(296, 22);
			this.menuOptions.Text = "Options";
			this.menuOptions.Visible = false;
			this.menuOptions.Click += new global::System.EventHandler(this.menuOptions_Click);
			this.menuRegenerate.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuRegenerate.Image");
			this.menuRegenerate.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuRegenerate.Name = "menuRegenerate";
			this.menuRegenerate.Size = new global::System.Drawing.Size(296, 22);
			this.menuRegenerate.Text = "Regenerate BH";
			this.menuRegenerate.Click += new global::System.EventHandler(this.menuRegenerate_Click);
			this.menuExpandDatabase.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuExpandDatabase.Image");
			this.menuExpandDatabase.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuExpandDatabase.Name = "menuExpandDatabase";
			this.menuExpandDatabase.Size = new global::System.Drawing.Size(296, 22);
			this.menuExpandDatabase.Text = "Expand Database";
			this.menuExpandDatabase.Visible = false;
			this.menuExpandDatabase.Click += new global::System.EventHandler(this.menuExpandDatabase_Click);
			this.menuRemoveKidProtection.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.menuRemoveKidProtection.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.menuRemoveKidProtection.Name = "menuRemoveKidProtection";
			this.menuRemoveKidProtection.Size = new global::System.Drawing.Size(296, 22);
			this.menuRemoveKidProtection.Text = "Remove \"Kid Protection\" Kits";
			this.menuRemoveKidProtection.Visible = false;
			this.menuRemoveKidProtection.Click += new global::System.EventHandler(this.menuRemoveKidProtection_Click);
			this.menuCleanFAT.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuCleanFAT.Image");
			this.menuCleanFAT.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuCleanFAT.Name = "menuCleanFAT";
			this.menuCleanFAT.Size = new global::System.Drawing.Size(296, 22);
			this.menuCleanFAT.Text = "Clean FAT";
			this.menuCleanFAT.Visible = false;
			this.menuCleanFAT.Click += new global::System.EventHandler(this.menuCleanFAT_Click);
			this.menuRemoveAllLongTeamNames.Name = "menuRemoveAllLongTeamNames";
			this.menuRemoveAllLongTeamNames.Size = new global::System.Drawing.Size(296, 22);
			this.menuRemoveAllLongTeamNames.Text = "Remove All Long Team Names";
			this.menuRemoveAllLongTeamNames.Visible = false;
			this.menuRemoveAllLongTeamNames.Click += new global::System.EventHandler(this.removeAllLongTeamNames_Click);
			this.menuAlignLanguageDB.Name = "menuAlignLanguageDB";
			this.menuAlignLanguageDB.Size = new global::System.Drawing.Size(296, 22);
			this.menuAlignLanguageDB.Text = "Align Language DB";
			this.menuAlignLanguageDB.Click += new global::System.EventHandler(this.menuAlignLanguageDB_Click);
			this.menuMinimizeNamesTable.Name = "menuMinimizeNamesTable";
			this.menuMinimizeNamesTable.Size = new global::System.Drawing.Size(296, 22);
			this.menuMinimizeNamesTable.Text = "Minimize Player Names Table";
			this.menuMinimizeNamesTable.ToolTipText = "Reserve more room in the player names table for created players but makes the database not compatible with online gaming . ";
			this.menuMinimizeNamesTable.Click += new global::System.EventHandler(this.minimizeNamesTableToolStripMenuItem_Click);
			this.menuPreserveOriginalNames.Name = "menuPreserveOriginalNames";
			this.menuPreserveOriginalNames.Size = new global::System.Drawing.Size(296, 22);
			this.menuPreserveOriginalNames.Text = "Preserve Original Player Names";
			this.menuPreserveOriginalNames.ToolTipText = "Preserve all the names originally present in the player names table, in this way the database will be compatible with online gaming but the space of names for new players will be reduced. ";
			this.menuPreserveOriginalNames.Click += new global::System.EventHandler(this.menuPreserveOriginalNames_Click);
			this.menuInstallRevModPatch.Name = "menuInstallRevModPatch";
			this.menuInstallRevModPatch.Size = new global::System.Drawing.Size(296, 22);
			this.menuInstallRevModPatch.Text = "Install RevMod Patch (simplified version)";
			this.menuInstallRevModPatch.Click += new global::System.EventHandler(this.installRevModPatchsimplifiedVersionToolStripMenuItem_Click);
			this.exportPlayersFromCSVToolStripMenuItem.Name = "exportPlayersFromCSVToolStripMenuItem";
			this.exportPlayersFromCSVToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.exportPlayersFromCSVToolStripMenuItem.Text = "Export Players From CSV";
			this.exportPlayersFromCSVToolStripMenuItem.Click += new global::System.EventHandler(this.exportPlayersInCSVToolStripMenuItem_Click);
			this.importPlayersFromCSVToolStripMenuItem.Name = "importPlayersFromCSVToolStripMenuItem";
			this.importPlayersFromCSVToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.importPlayersFromCSVToolStripMenuItem.Text = "Import Players From CSV";
			this.importPlayersFromCSVToolStripMenuItem.Click += new global::System.EventHandler(this.importPlayersFromCSVToolStripMenuItem_Click);
			this.removeFakePlayersToolStripMenuItem.Name = "removeFakePlayersToolStripMenuItem";
			this.removeFakePlayersToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.removeFakePlayersToolStripMenuItem.Text = "Remove Fake Players from Database";
			this.removeFakePlayersToolStripMenuItem.Click += new global::System.EventHandler(this.removeFakePlayersToolStripMenuItem_Click);
			this.playerNameCountryRulesToolStripMenuItem.Name = "playerNameCountryRulesToolStripMenuItem";
			this.playerNameCountryRulesToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.playerNameCountryRulesToolStripMenuItem.Text = "Simplify Player Name using Country Rules";
			this.playerNameCountryRulesToolStripMenuItem.Click += new global::System.EventHandler(this.playerNameCountryRulesToolStripMenuItem_Click);
			this.fixLoanDatesToolStripMenuItem.Name = "fixLoanDatesToolStripMenuItem";
			this.fixLoanDatesToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.fixLoanDatesToolStripMenuItem.Text = "Set Contract End after Loan End Date";
			this.fixLoanDatesToolStripMenuItem.Click += new global::System.EventHandler(this.fixLoanDatesToolStripMenuItem_Click);
			this.fixProblemsToolStripMenuItem.Enabled = false;
			this.fixProblemsToolStripMenuItem.Name = "fixProblemsToolStripMenuItem";
			this.fixProblemsToolStripMenuItem.Size = new global::System.Drawing.Size(296, 22);
			this.fixProblemsToolStripMenuItem.Text = "Fix Problems";
			this.fixProblemsToolStripMenuItem.Click += new global::System.EventHandler(this.FixProblems_Click);
			this.menuPatch.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuCreatePatch, this.menuLoadPatch });
			this.menuPatch.Name = "menuPatch";
			this.menuPatch.Size = new global::System.Drawing.Size(49, 20);
			this.menuPatch.Text = "Patch";
			this.menuCreatePatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuCreatePatch.Image");
			this.menuCreatePatch.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuCreatePatch.Name = "menuCreatePatch";
			this.menuCreatePatch.Size = new global::System.Drawing.Size(108, 22);
			this.menuCreatePatch.Text = "Create";
			this.menuCreatePatch.Click += new global::System.EventHandler(this.menuCreatePatch_Click);
			this.menuLoadPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuLoadPatch.Image");
			this.menuLoadPatch.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuLoadPatch.Name = "menuLoadPatch";
			this.menuLoadPatch.Size = new global::System.Drawing.Size(108, 22);
			this.menuLoadPatch.Text = "Load";
			this.menuLoadPatch.Click += new global::System.EventHandler(this.menuLoadPatch_Click);
			this.menuUpdateDB.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuOnlineFromFifa16, this.menuOnlineFromFifa17 });
			this.menuUpdateDB.Name = "menuUpdateDB";
			this.menuUpdateDB.Size = new global::System.Drawing.Size(95, 20);
			this.menuUpdateDB.Text = "Online Update";
			this.menuOnlineFromFifa16.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.rostersOnlyFromFIFA16, this.rostersAndPlayersFromFifa16 });
			this.menuOnlineFromFifa16.Name = "menuOnlineFromFifa16";
			this.menuOnlineFromFifa16.Size = new global::System.Drawing.Size(142, 22);
			this.menuOnlineFromFifa16.Text = "From FIFA 16";
			this.menuOnlineFromFifa16.Click += new global::System.EventHandler(this.rostersOnlineDBFIFA16ToolStripMenuItem_Click);
			this.rostersOnlyFromFIFA16.Name = "rostersOnlyFromFIFA16";
			this.rostersOnlyFromFIFA16.Size = new global::System.Drawing.Size(175, 22);
			this.rostersOnlyFromFIFA16.Text = "Rosters Only";
			this.rostersOnlyFromFIFA16.Click += new global::System.EventHandler(this.rostersOnlineDBFIFA16ToolStripMenuItem_Click);
			this.rostersAndPlayersFromFifa16.Name = "rostersAndPlayersFromFifa16";
			this.rostersAndPlayersFromFifa16.Size = new global::System.Drawing.Size(175, 22);
			this.rostersAndPlayersFromFifa16.Text = "Rosters and Players";
			this.rostersAndPlayersFromFifa16.Click += new global::System.EventHandler(this.menuOnlineDBFifa16_Click);
			this.menuOnlineFromFifa17.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.rostersOnlyFromFifa17, this.rostersAndPlayersFromFifa17 });
			this.menuOnlineFromFifa17.Name = "menuOnlineFromFifa17";
			this.menuOnlineFromFifa17.Size = new global::System.Drawing.Size(142, 22);
			this.menuOnlineFromFifa17.Text = "From FIFA 17";
			this.rostersOnlyFromFifa17.Name = "rostersOnlyFromFifa17";
			this.rostersOnlyFromFifa17.Size = new global::System.Drawing.Size(175, 22);
			this.rostersOnlyFromFifa17.Text = "Rosters Only";
			this.rostersOnlyFromFifa17.Click += new global::System.EventHandler(this.rostersOnlyFromFifa17_Click);
			this.rostersAndPlayersFromFifa17.Name = "rostersAndPlayersFromFifa17";
			this.rostersAndPlayersFromFifa17.Size = new global::System.Drawing.Size(175, 22);
			this.rostersAndPlayersFromFifa17.Text = "Rosters and Players";
			this.rostersAndPlayersFromFifa17.Click += new global::System.EventHandler(this.rostersAndPlayersFromFifa17_Click);
			this.menuUgc.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuImportUgc, this.menuImportUgcWothKits, this.menuImportUgcKits, this.menuImportUgcPlayers });
			this.menuUgc.Name = "menuUgc";
			this.menuUgc.Size = new global::System.Drawing.Size(81, 20);
			this.menuUgc.Text = "UG Content";
			this.menuUgc.Visible = false;
			this.menuImportUgc.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuImportUgc.Image");
			this.menuImportUgc.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuImportUgc.Name = "menuImportUgc";
			this.menuImportUgc.Size = new global::System.Drawing.Size(177, 22);
			this.menuImportUgc.Text = "Import DB only";
			this.menuImportUgc.Click += new global::System.EventHandler(this.importToolStripMenuItem_Click);
			this.menuImportUgcWothKits.Name = "menuImportUgcWothKits";
			this.menuImportUgcWothKits.Size = new global::System.Drawing.Size(177, 22);
			this.menuImportUgcWothKits.Text = "Import DB and KITS";
			this.menuImportUgcWothKits.Click += new global::System.EventHandler(this.importDBAndKITSToolStripMenuItem_Click);
			this.menuImportUgcKits.Name = "menuImportUgcKits";
			this.menuImportUgcKits.Size = new global::System.Drawing.Size(177, 22);
			this.menuImportUgcKits.Text = "Import KITS only";
			this.menuImportUgcKits.Click += new global::System.EventHandler(this.importKITSOmlyToolStripMenuItem_Click);
			this.menuImportUgcPlayers.Name = "menuImportUgcPlayers";
			this.menuImportUgcPlayers.Size = new global::System.Drawing.Size(177, 22);
			this.menuImportUgcPlayers.Text = "Import Players only";
			this.menuImportUgcPlayers.Click += new global::System.EventHandler(this.menuImportUgcPlayers_Click);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuHelp, this.menuAbout, this.menuHelpCms });
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.menuHelp.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuHelp.Image");
			this.menuHelp.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new global::System.Drawing.Size(107, 22);
			this.menuHelp.Text = "Help";
			this.menuHelp.Click += new global::System.EventHandler(this.menuHelp_Click);
			this.menuAbout.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("menuAbout.Image");
			this.menuAbout.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new global::System.Drawing.Size(107, 22);
			this.menuAbout.Text = "About";
			this.menuAbout.Click += new global::System.EventHandler(this.menuAbout_Click);
			this.menuHelpCms.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.genericToolStripMenuItem, this.adboardsToolStripMenuItem, this.ballsToolStripMenuItem, this.bootsToolStripMenuItem, this.countryToolStripMenuItem, this.fontsToolStripMenuItem, this.formationsToolStripMenuItem, this.leaguesToolStripMenuItem, this.stadiumsToolStripMenuItem, this.teamsToolStripMenuItem,
				this.tournamentsToolStripMenuItem
			});
			this.menuHelpCms.Name = "menuHelpCms";
			this.menuHelpCms.Size = new global::System.Drawing.Size(107, 22);
			this.menuHelpCms.Text = "CMS";
			this.menuHelpCms.Visible = false;
			this.genericToolStripMenuItem.Name = "genericToolStripMenuItem";
			this.genericToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.genericToolStripMenuItem.Text = "Generic";
			this.genericToolStripMenuItem.Click += new global::System.EventHandler(this.menuHelpCms_Click);
			this.adboardsToolStripMenuItem.Name = "adboardsToolStripMenuItem";
			this.adboardsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.adboardsToolStripMenuItem.Text = "Adboards";
			this.adboardsToolStripMenuItem.Click += new global::System.EventHandler(this.adboardsToolStripMenuItem_Click);
			this.ballsToolStripMenuItem.Name = "ballsToolStripMenuItem";
			this.ballsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.ballsToolStripMenuItem.Text = "Balls";
			this.ballsToolStripMenuItem.Click += new global::System.EventHandler(this.ballsToolStripMenuItem_Click);
			this.bootsToolStripMenuItem.Name = "bootsToolStripMenuItem";
			this.bootsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.bootsToolStripMenuItem.Text = "Boots";
			this.bootsToolStripMenuItem.Click += new global::System.EventHandler(this.bootsToolStripMenuItem_Click);
			this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
			this.countryToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.countryToolStripMenuItem.Text = "Country";
			this.countryToolStripMenuItem.Click += new global::System.EventHandler(this.countryToolStripMenuItem_Click);
			this.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
			this.fontsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.fontsToolStripMenuItem.Text = "Fonts";
			this.fontsToolStripMenuItem.Click += new global::System.EventHandler(this.fontsToolStripMenuItem_Click);
			this.formationsToolStripMenuItem.Name = "formationsToolStripMenuItem";
			this.formationsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.formationsToolStripMenuItem.Text = "Formations";
			this.formationsToolStripMenuItem.Click += new global::System.EventHandler(this.formationsToolStripMenuItem_Click);
			this.leaguesToolStripMenuItem.Name = "leaguesToolStripMenuItem";
			this.leaguesToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.leaguesToolStripMenuItem.Text = "Leagues";
			this.leaguesToolStripMenuItem.Click += new global::System.EventHandler(this.leaguesToolStripMenuItem_Click);
			this.stadiumsToolStripMenuItem.Name = "stadiumsToolStripMenuItem";
			this.stadiumsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.stadiumsToolStripMenuItem.Text = "Stadiums";
			this.stadiumsToolStripMenuItem.Click += new global::System.EventHandler(this.stadiumsToolStripMenuItem_Click);
			this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
			this.teamsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.teamsToolStripMenuItem.Text = "Teams";
			this.teamsToolStripMenuItem.Click += new global::System.EventHandler(this.teamsToolStripMenuItem_Click);
			this.tournamentsToolStripMenuItem.Name = "tournamentsToolStripMenuItem";
			this.tournamentsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.tournamentsToolStripMenuItem.Text = "Tournaments";
			this.tournamentsToolStripMenuItem.Click += new global::System.EventHandler(this.tournamentsToolStripMenuItem_Click);
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.progressBar, this.statusBar });
			this.statusStrip.Location = new global::System.Drawing.Point(0, 939);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new global::System.Drawing.Size(1384, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new global::System.Drawing.Size(100, 16);
			this.progressBar.Visible = false;
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new global::System.Drawing.Size(39, 17);
			this.statusBar.Text = "Ready";
			this.splitVert.BackColor = global::System.Drawing.Color.Blue;
			this.splitVert.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitVert.Enabled = false;
			this.splitVert.IsSplitterFixed = true;
			this.splitVert.Location = new global::System.Drawing.Point(0, 79);
			this.splitVert.Name = "splitVert";
			this.splitVert.Panel1.Controls.Add(this.splitHoriz);
			this.splitVert.Panel2.BackColor = global::System.Drawing.Color.LightSkyBlue;
			this.splitVert.Panel2.Controls.Add(this.panelRight);
			this.splitVert.Panel2.Controls.Add(this.toolStripRight);
			this.splitVert.Size = new global::System.Drawing.Size(1384, 860);
			this.splitVert.SplitterDistance = 1355;
			this.splitVert.SplitterWidth = 2;
			this.splitVert.TabIndex = 2;
			this.splitHoriz.BackColor = global::System.Drawing.Color.Blue;
			this.splitHoriz.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitHoriz.IsSplitterFixed = true;
			this.splitHoriz.Location = new global::System.Drawing.Point(0, 0);
			this.splitHoriz.Name = "splitHoriz";
			this.splitHoriz.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitHoriz.Panel1.BackColor = global::System.Drawing.SystemColors.Control;
			this.splitHoriz.Panel1.Controls.Add(this.panelMain);
			this.splitHoriz.Panel2.BackColor = global::System.Drawing.Color.LightSkyBlue;
			this.splitHoriz.Panel2.Controls.Add(this.panelBottom);
			this.splitHoriz.Panel2.Controls.Add(this.toolStripBottom);
			this.splitHoriz.Size = new global::System.Drawing.Size(1355, 860);
			this.splitHoriz.SplitterDistance = 831;
			this.splitHoriz.SplitterWidth = 2;
			this.splitHoriz.TabIndex = 0;
			this.panelMain.BackColor = global::System.Drawing.Color.LightSkyBlue;
			this.panelMain.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new global::System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new global::System.Drawing.Size(1355, 831);
			this.panelMain.TabIndex = 1;
			this.panelBottom.AutoScroll = true;
			this.panelBottom.AutoSize = true;
			this.panelBottom.BackColor = global::System.Drawing.Color.LightSkyBlue;
			this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 25);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(1355, 2);
			this.panelBottom.TabIndex = 1;
			this.toolStripBottom.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripBottom.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShowBottom, this.buttonHideBottom, this.stripLabelBottom });
			this.toolStripBottom.Location = new global::System.Drawing.Point(0, 0);
			this.toolStripBottom.Name = "toolStripBottom";
			this.toolStripBottom.Size = new global::System.Drawing.Size(1355, 25);
			this.toolStripBottom.TabIndex = 0;
			this.toolStripBottom.Text = "toolBottom";
			this.buttonShowBottom.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowBottom.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShowBottom.Image");
			this.buttonShowBottom.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShowBottom.Name = "buttonShowBottom";
			this.buttonShowBottom.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShowBottom.Text = "show";
			this.buttonShowBottom.Click += new global::System.EventHandler(this.buttonShowBottom_Click);
			this.buttonHideBottom.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonHideBottom.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonHideBottom.Image");
			this.buttonHideBottom.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonHideBottom.Name = "buttonHideBottom";
			this.buttonHideBottom.Size = new global::System.Drawing.Size(23, 22);
			this.buttonHideBottom.Text = "hide";
			this.buttonHideBottom.Visible = false;
			this.buttonHideBottom.Click += new global::System.EventHandler(this.buttonHideBottom_Click);
			this.stripLabelBottom.Name = "stripLabelBottom";
			this.stripLabelBottom.Size = new global::System.Drawing.Size(41, 22);
			this.stripLabelBottom.Text = "Empty";
			this.panelRight.AutoScroll = true;
			this.panelRight.BackColor = global::System.Drawing.Color.LightSkyBlue;
			this.panelRight.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new global::System.Drawing.Point(24, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new global::System.Drawing.Size(3, 860);
			this.panelRight.TabIndex = 2;
			this.toolStripRight.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.toolStripRight.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripRight.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShowRight, this.buttonHideRight, this.stripLabelRight });
			this.toolStripRight.Location = new global::System.Drawing.Point(0, 0);
			this.toolStripRight.Name = "toolStripRight";
			this.toolStripRight.Size = new global::System.Drawing.Size(24, 860);
			this.toolStripRight.TabIndex = 1;
			this.toolStripRight.Text = "toolBottom";
			this.buttonShowRight.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowRight.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShowRight.Image");
			this.buttonShowRight.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShowRight.Name = "buttonShowRight";
			this.buttonShowRight.Size = new global::System.Drawing.Size(21, 20);
			this.buttonShowRight.Text = "show";
			this.buttonShowRight.Click += new global::System.EventHandler(this.buttonShowRight_Click);
			this.buttonHideRight.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonHideRight.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonHideRight.Image");
			this.buttonHideRight.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonHideRight.Name = "buttonHideRight";
			this.buttonHideRight.Size = new global::System.Drawing.Size(21, 20);
			this.buttonHideRight.Text = "hide";
			this.buttonHideRight.Visible = false;
			this.buttonHideRight.Click += new global::System.EventHandler(this.buttonHideRight_Click);
			this.stripLabelRight.Name = "stripLabelRight";
			this.stripLabelRight.Size = new global::System.Drawing.Size(21, 41);
			this.stripLabelRight.Text = "Empty";
			this.stripLabelRight.TextDirection = global::System.Windows.Forms.ToolStripTextDirection.Vertical90;
			this.toolStripMain.Enabled = false;
			this.toolStripMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.buttonCountry, this.buttonLeague, this.buttonTeam, this.buttonKit, this.buttonPlayer, this.buttonStadium, this.buttonTournament, this.buttonReferee, this.buttonBall, this.buttonShoes,
				this.buttonManager, this.buttonFormation, this.buttonSponsor, this.buttonTv, this.buttonNewspaper, this.buttonGloves, this.buttonAudio, this.buttonGameGraphics, this.buttonBrowser
			});
			this.toolStripMain.Location = new global::System.Drawing.Point(0, 24);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new global::System.Drawing.Size(1384, 55);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStripMain";
			this.toolTip.SetToolTip(this.toolStripMain, "Click and use Shift, Ctrl and Alt keys to activate a different window");
			this.buttonCountry.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonCountry.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCountry.Image");
			this.buttonCountry.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonCountry.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonCountry.Name = "buttonCountry";
			this.buttonCountry.Size = new global::System.Drawing.Size(52, 52);
			this.buttonCountry.Text = "Country";
			this.buttonCountry.ToolTipText = "Country";
			this.buttonCountry.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonLeague.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonLeague.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLeague.Image");
			this.buttonLeague.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonLeague.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonLeague.Name = "buttonLeague";
			this.buttonLeague.Size = new global::System.Drawing.Size(52, 52);
			this.buttonLeague.Text = "League";
			this.buttonLeague.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonTeam.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonTeam.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTeam.Image");
			this.buttonTeam.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonTeam.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonTeam.Name = "buttonTeam";
			this.buttonTeam.Size = new global::System.Drawing.Size(52, 52);
			this.buttonTeam.Text = "Team";
			this.buttonTeam.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonKit.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonKit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonKit.Image");
			this.buttonKit.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonKit.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonKit.Name = "buttonKit";
			this.buttonKit.Size = new global::System.Drawing.Size(52, 52);
			this.buttonKit.Text = "Kits";
			this.buttonKit.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonPlayer.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonPlayer.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonPlayer.Image");
			this.buttonPlayer.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonPlayer.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonPlayer.Name = "buttonPlayer";
			this.buttonPlayer.Size = new global::System.Drawing.Size(52, 52);
			this.buttonPlayer.Text = "Player";
			this.buttonPlayer.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonStadium.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonStadium.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonStadium.Image");
			this.buttonStadium.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonStadium.ImageTransparentColor = global::System.Drawing.Color.White;
			this.buttonStadium.Name = "buttonStadium";
			this.buttonStadium.Size = new global::System.Drawing.Size(52, 52);
			this.buttonStadium.Text = "Stadium";
			this.buttonStadium.ToolTipText = "Stadium";
			this.buttonStadium.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonTournament.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonTournament.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTournament.Image");
			this.buttonTournament.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonTournament.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonTournament.Name = "buttonTournament";
			this.buttonTournament.Size = new global::System.Drawing.Size(52, 52);
			this.buttonTournament.Text = "Tournament in Manager Mode";
			this.buttonTournament.ToolTipText = "Tournament";
			this.buttonTournament.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonReferee.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonReferee.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonReferee.Image");
			this.buttonReferee.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonReferee.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonReferee.Name = "buttonReferee";
			this.buttonReferee.Size = new global::System.Drawing.Size(52, 52);
			this.buttonReferee.Text = "Referee";
			this.buttonReferee.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonBall.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonBall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonBall.Image");
			this.buttonBall.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonBall.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonBall.Name = "buttonBall";
			this.buttonBall.Size = new global::System.Drawing.Size(52, 52);
			this.buttonBall.Text = "Ball";
			this.buttonBall.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonShoes.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShoes.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShoes.Image");
			this.buttonShoes.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonShoes.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShoes.Name = "buttonShoes";
			this.buttonShoes.Size = new global::System.Drawing.Size(52, 52);
			this.buttonShoes.Text = "Boots";
			this.buttonShoes.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonManager.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonManager.Image");
			this.buttonManager.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonManager.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonManager.Name = "buttonManager";
			this.buttonManager.Size = new global::System.Drawing.Size(52, 52);
			this.buttonManager.Text = "Manager";
			this.buttonManager.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonFormation.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFormation.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFormation.Image");
			this.buttonFormation.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonFormation.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFormation.Name = "buttonFormation";
			this.buttonFormation.Size = new global::System.Drawing.Size(52, 52);
			this.buttonFormation.Text = "Generic Formations";
			this.buttonFormation.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonSponsor.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSponsor.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSponsor.Image");
			this.buttonSponsor.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonSponsor.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSponsor.Name = "buttonSponsor";
			this.buttonSponsor.Size = new global::System.Drawing.Size(52, 52);
			this.buttonSponsor.Text = "Sponsor";
			this.buttonSponsor.Visible = false;
			this.buttonSponsor.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonTv.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonTv.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTv.Image");
			this.buttonTv.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonTv.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonTv.Name = "buttonTv";
			this.buttonTv.Size = new global::System.Drawing.Size(52, 52);
			this.buttonTv.Text = "TV";
			this.buttonTv.Visible = false;
			this.buttonTv.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonNewspaper.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonNewspaper.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonNewspaper.Image");
			this.buttonNewspaper.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonNewspaper.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonNewspaper.Name = "buttonNewspaper";
			this.buttonNewspaper.Size = new global::System.Drawing.Size(52, 52);
			this.buttonNewspaper.Text = "Newspaper";
			this.buttonNewspaper.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonGloves.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonGloves.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGloves.Image");
			this.buttonGloves.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonGloves.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonGloves.Name = "buttonGloves";
			this.buttonGloves.Size = new global::System.Drawing.Size(52, 52);
			this.buttonGloves.Text = "Gloves and accessories";
			this.buttonGloves.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonAudio.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonAudio.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonAudio.Image");
			this.buttonAudio.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonAudio.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonAudio.Name = "buttonAudio";
			this.buttonAudio.Size = new global::System.Drawing.Size(52, 52);
			this.buttonAudio.Text = "Audio";
			this.buttonAudio.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonGameGraphics.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonGameGraphics.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGameGraphics.Image");
			this.buttonGameGraphics.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonGameGraphics.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonGameGraphics.Name = "buttonGameGraphics";
			this.buttonGameGraphics.Size = new global::System.Drawing.Size(52, 52);
			this.buttonGameGraphics.Text = "Game Graphics";
			this.buttonGameGraphics.Click += new global::System.EventHandler(this.buttonMain_Click);
			this.buttonBrowser.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonBrowser.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonBrowser.Image");
			this.buttonBrowser.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonBrowser.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonBrowser.Name = "buttonBrowser";
			this.buttonBrowser.Size = new global::System.Drawing.Size(52, 52);
			this.buttonBrowser.Text = "Web Grabber";
			this.buttonBrowser.Click += new global::System.EventHandler(this.buttonMain_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1384, 961);
			base.Controls.Add(this.splitVert);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.toolStripMain);
			base.Controls.Add(this.menuStrip);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.IsMdiContainer = true;
			base.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new global::System.Drawing.Size(200, 199);
			base.Name = "MainForm";
			this.Text = "Creation Master 16";
			base.SizeChanged += new global::System.EventHandler(this.MainForm_SizeChanged);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.splitVert.Panel1.ResumeLayout(false);
			this.splitVert.Panel2.ResumeLayout(false);
			this.splitVert.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitVert).EndInit();
			this.splitVert.ResumeLayout(false);
			this.splitHoriz.Panel1.ResumeLayout(false);
			this.splitHoriz.Panel2.ResumeLayout(false);
			this.splitHoriz.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitHoriz).EndInit();
			this.splitHoriz.ResumeLayout(false);
			this.toolStripBottom.ResumeLayout(false);
			this.toolStripBottom.PerformLayout();
			this.toolStripRight.ResumeLayout(false);
			this.toolStripRight.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004D7 RID: 1239
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004D8 RID: 1240
		private global::System.Windows.Forms.MenuStrip menuStrip;

		// Token: 0x040004D9 RID: 1241
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x040004DA RID: 1242
		private global::System.Windows.Forms.ToolStripProgressBar progressBar;

		// Token: 0x040004DB RID: 1243
		private global::System.Windows.Forms.ToolStripStatusLabel statusBar;

		// Token: 0x040004DC RID: 1244
		private global::System.Windows.Forms.ToolStripMenuItem menuFile;

		// Token: 0x040004DD RID: 1245
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x040004DE RID: 1246
		private global::System.Windows.Forms.ToolStripMenuItem menuAbout;

		// Token: 0x040004DF RID: 1247
		private global::System.Windows.Forms.ToolStripMenuItem menuHelp;

		// Token: 0x040004E0 RID: 1248
		private global::System.Windows.Forms.SplitContainer splitVert;

		// Token: 0x040004E1 RID: 1249
		private global::System.Windows.Forms.SplitContainer splitHoriz;

		// Token: 0x040004E2 RID: 1250
		private global::System.Windows.Forms.ToolStrip toolStripBottom;

		// Token: 0x040004E3 RID: 1251
		private global::System.Windows.Forms.ToolStripButton buttonShowBottom;

		// Token: 0x040004E4 RID: 1252
		private global::System.Windows.Forms.ToolStripButton buttonHideBottom;

		// Token: 0x040004E5 RID: 1253
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenFifa14;

		// Token: 0x040004E6 RID: 1254
		private global::System.Windows.Forms.ToolStrip toolStripMain;

		// Token: 0x040004E7 RID: 1255
		private global::System.Windows.Forms.ToolStrip toolStripRight;

		// Token: 0x040004E8 RID: 1256
		private global::System.Windows.Forms.ToolStripButton buttonShowRight;

		// Token: 0x040004E9 RID: 1257
		private global::System.Windows.Forms.ToolStripButton buttonHideRight;

		// Token: 0x040004EA RID: 1258
		private global::System.Windows.Forms.ToolStripLabel stripLabelRight;

		// Token: 0x040004EB RID: 1259
		private global::System.Windows.Forms.ToolStripLabel stripLabelBottom;

		// Token: 0x040004EC RID: 1260
		private global::System.Windows.Forms.Panel panelMain;

		// Token: 0x040004ED RID: 1261
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenLang14;

		// Token: 0x040004EE RID: 1262
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenAll;

		// Token: 0x040004EF RID: 1263
		private global::System.Windows.Forms.ToolStripMenuItem menuSave;

		// Token: 0x040004F0 RID: 1264
		private global::System.Windows.Forms.ToolStripMenuItem menuClose;

		// Token: 0x040004F1 RID: 1265
		private global::System.Windows.Forms.ToolStripMenuItem menuExit;

		// Token: 0x040004F2 RID: 1266
		private global::System.Windows.Forms.OpenFileDialog openFifaDialog;

		// Token: 0x040004F3 RID: 1267
		private global::System.Windows.Forms.OpenFileDialog openLangDialog;

		// Token: 0x040004F4 RID: 1268
		private global::System.Windows.Forms.FolderBrowserDialog browserDialog;

		// Token: 0x040004F5 RID: 1269
		private global::System.Windows.Forms.ToolStripMenuItem menuTools;

		// Token: 0x040004F6 RID: 1270
		private global::System.Windows.Forms.ToolStripMenuItem menuEnableAllMessages;

		// Token: 0x040004F7 RID: 1271
		private global::System.Windows.Forms.ToolStripMenuItem menuOptions;

		// Token: 0x040004F8 RID: 1272
		private global::System.Windows.Forms.ToolStripMenuItem menuRegenerate;

		// Token: 0x040004F9 RID: 1273
		private global::System.Windows.Forms.ToolStripMenuItem menuExpandDatabase;

		// Token: 0x040004FA RID: 1274
		private global::System.Windows.Forms.Panel panelBottom;

		// Token: 0x040004FB RID: 1275
		private global::System.Windows.Forms.Panel panelRight;

		// Token: 0x040004FC RID: 1276
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenDebug;

		// Token: 0x040004FD RID: 1277
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x040004FE RID: 1278
		private global::System.Windows.Forms.ToolStripMenuItem menuPatch;

		// Token: 0x040004FF RID: 1279
		private global::System.Windows.Forms.ToolStripMenuItem menuCreatePatch;

		// Token: 0x04000500 RID: 1280
		private global::System.Windows.Forms.ToolStripMenuItem menuLoadPatch;

		// Token: 0x04000501 RID: 1281
		private global::System.Windows.Forms.ToolStripMenuItem menuRemoveKidProtection;

		// Token: 0x04000502 RID: 1282
		private global::System.Windows.Forms.ToolStripMenuItem menuCleanFAT;

		// Token: 0x04000503 RID: 1283
		private global::System.Windows.Forms.ToolStripMenuItem menuHelpCms;

		// Token: 0x04000504 RID: 1284
		private global::System.Windows.Forms.ToolStripMenuItem menuRemoveAllLongTeamNames;

		// Token: 0x04000505 RID: 1285
		private global::System.Windows.Forms.ToolStripMenuItem genericToolStripMenuItem;

		// Token: 0x04000506 RID: 1286
		private global::System.Windows.Forms.ToolStripMenuItem adboardsToolStripMenuItem;

		// Token: 0x04000507 RID: 1287
		private global::System.Windows.Forms.ToolStripMenuItem ballsToolStripMenuItem;

		// Token: 0x04000508 RID: 1288
		private global::System.Windows.Forms.ToolStripMenuItem bootsToolStripMenuItem;

		// Token: 0x04000509 RID: 1289
		private global::System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;

		// Token: 0x0400050A RID: 1290
		private global::System.Windows.Forms.ToolStripMenuItem fontsToolStripMenuItem;

		// Token: 0x0400050B RID: 1291
		private global::System.Windows.Forms.ToolStripMenuItem formationsToolStripMenuItem;

		// Token: 0x0400050C RID: 1292
		private global::System.Windows.Forms.ToolStripMenuItem leaguesToolStripMenuItem;

		// Token: 0x0400050D RID: 1293
		private global::System.Windows.Forms.ToolStripMenuItem stadiumsToolStripMenuItem;

		// Token: 0x0400050E RID: 1294
		private global::System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;

		// Token: 0x0400050F RID: 1295
		private global::System.Windows.Forms.ToolStripMenuItem tournamentsToolStripMenuItem;

		// Token: 0x04000510 RID: 1296
		private global::System.Windows.Forms.ToolStripButton buttonCountry;

		// Token: 0x04000511 RID: 1297
		private global::System.Windows.Forms.ToolStripButton buttonLeague;

		// Token: 0x04000512 RID: 1298
		private global::System.Windows.Forms.ToolStripButton buttonTeam;

		// Token: 0x04000513 RID: 1299
		private global::System.Windows.Forms.ToolStripButton buttonPlayer;

		// Token: 0x04000514 RID: 1300
		private global::System.Windows.Forms.ToolStripButton buttonStadium;

		// Token: 0x04000515 RID: 1301
		private global::System.Windows.Forms.ToolStripButton buttonTournament;

		// Token: 0x04000516 RID: 1302
		private global::System.Windows.Forms.ToolStripButton buttonReferee;

		// Token: 0x04000517 RID: 1303
		private global::System.Windows.Forms.ToolStripButton buttonBall;

		// Token: 0x04000518 RID: 1304
		private global::System.Windows.Forms.ToolStripButton buttonShoes;

		// Token: 0x04000519 RID: 1305
		private global::System.Windows.Forms.ToolStripButton buttonManager;

		// Token: 0x0400051A RID: 1306
		private global::System.Windows.Forms.ToolStripButton buttonFormation;

		// Token: 0x0400051B RID: 1307
		private global::System.Windows.Forms.ToolStripButton buttonTv;

		// Token: 0x0400051C RID: 1308
		private global::System.Windows.Forms.ToolStripButton buttonNewspaper;

		// Token: 0x0400051D RID: 1309
		private global::System.Windows.Forms.ToolStripButton buttonGloves;

		// Token: 0x0400051E RID: 1310
		private global::System.Windows.Forms.ToolStripButton buttonSponsor;

		// Token: 0x0400051F RID: 1311
		private global::System.Windows.Forms.ToolStripButton buttonKit;

		// Token: 0x04000520 RID: 1312
		private global::System.Windows.Forms.ToolStripMenuItem menuUgc;

		// Token: 0x04000521 RID: 1313
		private global::System.Windows.Forms.ToolStripMenuItem menuImportUgc;

		// Token: 0x04000522 RID: 1314
		private global::System.Windows.Forms.ToolStripMenuItem menuImportUgcWothKits;

		// Token: 0x04000523 RID: 1315
		private global::System.Windows.Forms.ToolStripMenuItem menuImportUgcKits;

		// Token: 0x04000524 RID: 1316
		private global::System.Windows.Forms.ToolStripMenuItem menuReopen;

		// Token: 0x04000525 RID: 1317
		private global::System.Windows.Forms.ToolStripButton buttonAudio;

		// Token: 0x04000526 RID: 1318
		private global::System.Windows.Forms.ToolStripMenuItem menuUpdateDB;

		// Token: 0x04000527 RID: 1319
		private global::System.Windows.Forms.ToolStripMenuItem menuAlignLanguageDB;

		// Token: 0x04000528 RID: 1320
		private global::System.Windows.Forms.ToolStripMenuItem menuImportUgcPlayers;

		// Token: 0x04000529 RID: 1321
		private global::System.Windows.Forms.ToolStripMenuItem menuMinimizeNamesTable;

		// Token: 0x0400052A RID: 1322
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenFifa15;

		// Token: 0x0400052B RID: 1323
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenLang15;

		// Token: 0x0400052C RID: 1324
		private global::System.Windows.Forms.ToolStripMenuItem menuPreserveOriginalNames;

		// Token: 0x0400052D RID: 1325
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenFifa16;

		// Token: 0x0400052E RID: 1326
		private global::System.Windows.Forms.ToolStripMenuItem menuOpenLang16;

		// Token: 0x0400052F RID: 1327
		private global::System.Windows.Forms.ToolStripMenuItem menuInstallRevModPatch;

		// Token: 0x04000530 RID: 1328
		private global::System.Windows.Forms.ToolStripMenuItem menuOnlineFromFifa16;

		// Token: 0x04000531 RID: 1329
		private global::System.Windows.Forms.ToolStripMenuItem rostersAndPlayersFromFifa16;

		// Token: 0x04000532 RID: 1330
		private global::System.Windows.Forms.ToolStripMenuItem menuOnlineFromFifa17;

		// Token: 0x04000533 RID: 1331
		private global::System.Windows.Forms.ToolStripMenuItem rostersOnlyFromFIFA16;

		// Token: 0x04000534 RID: 1332
		private global::System.Windows.Forms.ToolStripMenuItem rostersOnlyFromFifa17;

		// Token: 0x04000535 RID: 1333
		private global::System.Windows.Forms.ToolStripMenuItem rostersAndPlayersFromFifa17;

		// Token: 0x04000536 RID: 1334
		private global::System.Windows.Forms.ToolStripMenuItem playerNameCountryRulesToolStripMenuItem;

		// Token: 0x04000537 RID: 1335
		private global::System.Windows.Forms.ToolStripMenuItem removeFakePlayersToolStripMenuItem;

		// Token: 0x04000538 RID: 1336
		private global::System.Windows.Forms.ToolStripButton buttonGameGraphics;

		// Token: 0x04000539 RID: 1337
		private global::System.Windows.Forms.ToolStripMenuItem exportPlayersFromCSVToolStripMenuItem;

		// Token: 0x0400053A RID: 1338
		private global::System.Windows.Forms.ToolStripMenuItem importPlayersFromCSVToolStripMenuItem;

		// Token: 0x0400053B RID: 1339
		private global::System.Windows.Forms.ToolStripMenuItem fixLoanDatesToolStripMenuItem;

		// Token: 0x0400053C RID: 1340
		private global::System.Windows.Forms.ToolStripButton buttonBrowser;

		// Token: 0x0400053D RID: 1341
		private global::System.Windows.Forms.ToolStripMenuItem fixProblemsToolStripMenuItem;
	}
}
