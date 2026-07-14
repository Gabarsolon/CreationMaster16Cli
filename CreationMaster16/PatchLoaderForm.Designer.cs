namespace CreationMaster
{
	// Token: 0x0200000E RID: 14
	public partial class PatchLoaderForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00024A0C File Offset: 0x00022C0C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00024A2C File Offset: 0x00022C2C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.PatchLoaderForm));
			this.mainMenu = new global::System.Windows.Forms.MenuStrip();
			this.patchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolMain = new global::System.Windows.Forms.ToolStrip();
			this.buttonLoadPatch = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImportPatch = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonExitCreator = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSelectAllObjects = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonDeselectAllObjects = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonSelectNewObjects = new global::System.Windows.Forms.ToolStripButton();
			this.stripButtonPreview = new global::System.Windows.Forms.ToolStripButton();
			this.panelLeft = new global::System.Windows.Forms.Panel();
			this.textDescription = new global::System.Windows.Forms.TextBox();
			this.groupPatchOptions = new global::System.Windows.Forms.GroupBox();
			this.tabPatchOptions = new global::System.Windows.Forms.TabControl();
			this.pagePlayerOptions = new global::System.Windows.Forms.TabPage();
			this.groupDualClub = new global::System.Windows.Forms.GroupBox();
			this.radioPutInBothTeams = new global::System.Windows.Forms.RadioButton();
			this.radioTransferToNewTeam = new global::System.Windows.Forms.RadioButton();
			this.radioLeaveInExistingTeam = new global::System.Windows.Forms.RadioButton();
			this.checkPlayerMiniface = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerHead = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageTeamOptions = new global::System.Windows.Forms.TabPage();
			this.checkTeamFlags = new global::System.Windows.Forms.CheckBox();
			this.checkTeamBanner = new global::System.Windows.Forms.CheckBox();
			this.checkTeamLogo = new global::System.Windows.Forms.CheckBox();
			this.checkTeamDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageLeagueOptions = new global::System.Windows.Forms.TabPage();
			this.checkLeagueLogo = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageStadiumOptions = new global::System.Windows.Forms.TabPage();
			this.checkStadiumModel = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumPreview = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageKitOptions = new global::System.Windows.Forms.TabPage();
			this.checkMinikits = new global::System.Windows.Forms.CheckBox();
			this.checkKits = new global::System.Windows.Forms.CheckBox();
			this.checkKitDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageCountryOptions = new global::System.Windows.Forms.TabPage();
			this.checkCountryMap = new global::System.Windows.Forms.CheckBox();
			this.checkCountryDatabase = new global::System.Windows.Forms.CheckBox();
			this.checkCountryFlag = new global::System.Windows.Forms.CheckBox();
			this.textPatchVersion = new global::System.Windows.Forms.TextBox();
			this.textPatchName = new global::System.Windows.Forms.TextBox();
			this.labelDescription = new global::System.Windows.Forms.Label();
			this.labelPatchVersion = new global::System.Windows.Forms.Label();
			this.labelPatchName = new global::System.Windows.Forms.Label();
			this.statusBar = new global::System.Windows.Forms.StatusStrip();
			this.statusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.listViewPatch = new global::System.Windows.Forms.ListView();
			this.columnItem = new global::System.Windows.Forms.ColumnHeader();
			this.columnType = new global::System.Windows.Forms.ColumnHeader();
			this.columnPatchId = new global::System.Windows.Forms.ColumnHeader();
			this.columnImportId = new global::System.Windows.Forms.ColumnHeader();
			this.columnComment = new global::System.Windows.Forms.ColumnHeader();
			this.panelRight = new global::System.Windows.Forms.Panel();
			this.tabPreview = new global::System.Windows.Forms.TabControl();
			this.pageViewer2D = new global::System.Windows.Forms.TabPage();
			this.viewer2D = new global::FifaControls.Viewer2D();
			this.pageMultiViewer2D = new global::System.Windows.Forms.TabPage();
			this.multiViewer2D = new global::FifaControls.MultiViewer2D();
			this.panelGraphicGroups = new global::System.Windows.Forms.Panel();
			this.groupTeam = new global::System.Windows.Forms.GroupBox();
			this.radioTeamCrest50 = new global::System.Windows.Forms.RadioButton();
			this.radioTeamCrest16 = new global::System.Windows.Forms.RadioButton();
			this.radioTeamCrest32 = new global::System.Windows.Forms.RadioButton();
			this.radioTeamCrestLarge = new global::System.Windows.Forms.RadioButton();
			this.radioTeamFlags = new global::System.Windows.Forms.RadioButton();
			this.radioTeamBanners = new global::System.Windows.Forms.RadioButton();
			this.groupLeague = new global::System.Windows.Forms.GroupBox();
			this.radioLeagueLogo512x128 = new global::System.Windows.Forms.RadioButton();
			this.radioLeagueAnimLogo = new global::System.Windows.Forms.RadioButton();
			this.radioLeagueTinyLogo = new global::System.Windows.Forms.RadioButton();
			this.radioLeagueSmallLogo = new global::System.Windows.Forms.RadioButton();
			this.groupStadium = new global::System.Windows.Forms.GroupBox();
			this.radioStadiumPreview = new global::System.Windows.Forms.RadioButton();
			this.groupTod = new global::System.Windows.Forms.GroupBox();
			this.radioStadiumGuiNight = new global::System.Windows.Forms.RadioButton();
			this.radioStadiumGuiSunset = new global::System.Windows.Forms.RadioButton();
			this.radioStadiumGuiOvercast = new global::System.Windows.Forms.RadioButton();
			this.radioStadiumGuiClearDay = new global::System.Windows.Forms.RadioButton();
			this.radioStadium3D = new global::System.Windows.Forms.RadioButton();
			this.groupShoes = new global::System.Windows.Forms.GroupBox();
			this.radioShoesColor = new global::System.Windows.Forms.RadioButton();
			this.groupBall = new global::System.Windows.Forms.GroupBox();
			this.radioBallPreview = new global::System.Windows.Forms.RadioButton();
			this.radioBallTexture = new global::System.Windows.Forms.RadioButton();
			this.groupCountry = new global::System.Windows.Forms.GroupBox();
			this.radioCountryMap = new global::System.Windows.Forms.RadioButton();
			this.radioCountryFlag512x512 = new global::System.Windows.Forms.RadioButton();
			this.radioCountryCard = new global::System.Windows.Forms.RadioButton();
			this.radioCountryMainFlag = new global::System.Windows.Forms.RadioButton();
			this.radioCountryMiniflag = new global::System.Windows.Forms.RadioButton();
			this.groupAdboards = new global::System.Windows.Forms.GroupBox();
			this.radioAdboard1 = new global::System.Windows.Forms.RadioButton();
			this.groupKit = new global::System.Windows.Forms.GroupBox();
			this.radioKitKit = new global::System.Windows.Forms.RadioButton();
			this.radioKitMinikit = new global::System.Windows.Forms.RadioButton();
			this.groupPlayer = new global::System.Windows.Forms.GroupBox();
			this.radioHairTextures = new global::System.Windows.Forms.RadioButton();
			this.radioHairColorTexture = new global::System.Windows.Forms.RadioButton();
			this.radioEyesTexture = new global::System.Windows.Forms.RadioButton();
			this.radioFaceTexture = new global::System.Windows.Forms.RadioButton();
			this.radioMiniHead = new global::System.Windows.Forms.RadioButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupReplaceSelection = new global::System.Windows.Forms.GroupBox();
			this.comboReplaceLicensedTournament = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceKit = new global::System.Windows.Forms.ComboBox();
			this.labelCmsCreated = new global::System.Windows.Forms.Label();
			this.labelCmsReplaced = new global::System.Windows.Forms.Label();
			this.textCmsReplaced = new global::System.Windows.Forms.TextBox();
			this.comboReplaceMowingPattern = new global::System.Windows.Forms.ComboBox();
			this.radioCmsItem = new global::System.Windows.Forms.RadioButton();
			this.comboReplaceGkGloves = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceNet = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceShoes = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceNamesFont = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceNumberFont = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceAdboard = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceBall = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceReferee = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceSponsor = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceFormation = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceTournament = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceStadium = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceCountry = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceLeague = new global::System.Windows.Forms.ComboBox();
			this.comboReplacePlayer = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceTeam = new global::System.Windows.Forms.ComboBox();
			this.radioReplaceItem = new global::System.Windows.Forms.RadioButton();
			this.radioCreateItem = new global::System.Windows.Forms.RadioButton();
			this.labelDetails = new global::System.Windows.Forms.Label();
			this.mainMenu.SuspendLayout();
			this.toolMain.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.groupPatchOptions.SuspendLayout();
			this.tabPatchOptions.SuspendLayout();
			this.pagePlayerOptions.SuspendLayout();
			this.groupDualClub.SuspendLayout();
			this.pageTeamOptions.SuspendLayout();
			this.pageLeagueOptions.SuspendLayout();
			this.pageStadiumOptions.SuspendLayout();
			this.pageKitOptions.SuspendLayout();
			this.pageCountryOptions.SuspendLayout();
			this.statusBar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.tabPreview.SuspendLayout();
			this.pageViewer2D.SuspendLayout();
			this.pageMultiViewer2D.SuspendLayout();
			this.panelGraphicGroups.SuspendLayout();
			this.groupTeam.SuspendLayout();
			this.groupLeague.SuspendLayout();
			this.groupStadium.SuspendLayout();
			this.groupTod.SuspendLayout();
			this.groupShoes.SuspendLayout();
			this.groupBall.SuspendLayout();
			this.groupCountry.SuspendLayout();
			this.groupAdboards.SuspendLayout();
			this.groupKit.SuspendLayout();
			this.groupPlayer.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupReplaceSelection.SuspendLayout();
			base.SuspendLayout();
			this.mainMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.patchToolStripMenuItem });
			this.mainMenu.Location = new global::System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Padding = new global::System.Windows.Forms.Padding(8, 2, 0, 2);
			this.mainMenu.Size = new global::System.Drawing.Size(1543, 28);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			this.patchToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.openToolStripMenuItem, this.importToolStripMenuItem, this.exitToolStripMenuItem });
			this.patchToolStripMenuItem.Name = "patchToolStripMenuItem";
			this.patchToolStripMenuItem.Size = new global::System.Drawing.Size(57, 24);
			this.patchToolStripMenuItem.Text = "Patch";
			this.openToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openToolStripMenuItem.Image");
			this.openToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new global::System.Drawing.Size(123, 24);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new global::System.EventHandler(this.openToolStripMenuItem_Click);
			this.importToolStripMenuItem.Enabled = false;
			this.importToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("importToolStripMenuItem.Image");
			this.importToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new global::System.Drawing.Size(123, 24);
			this.importToolStripMenuItem.Text = "Import";
			this.importToolStripMenuItem.Click += new global::System.EventHandler(this.importToolStripMenuItem_Click);
			this.exitToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitToolStripMenuItem.Image");
			this.exitToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(123, 24);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.exitToolStripMenuItem_Click);
			this.toolMain.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.buttonLoadPatch, this.toolStripSeparator1, this.buttonImportPatch, this.toolStripSeparator2, this.buttonExitCreator, this.buttonSelectAllObjects, this.toolStripSeparator3, this.buttonDeselectAllObjects, this.toolStripSeparator4, this.buttonSelectNewObjects,
				this.stripButtonPreview
			});
			this.toolMain.Location = new global::System.Drawing.Point(0, 28);
			this.toolMain.Name = "toolMain";
			this.toolMain.Size = new global::System.Drawing.Size(1543, 27);
			this.toolMain.TabIndex = 1;
			this.toolMain.Text = "toolStrip1";
			this.buttonLoadPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLoadPatch.Image");
			this.buttonLoadPatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonLoadPatch.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonLoadPatch.Name = "buttonLoadPatch";
			this.buttonLoadPatch.Size = new global::System.Drawing.Size(73, 24);
			this.buttonLoadPatch.Text = "Open  ";
			this.buttonLoadPatch.Click += new global::System.EventHandler(this.buttonLoadPatch_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 27);
			this.buttonImportPatch.Enabled = false;
			this.buttonImportPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportPatch.Image");
			this.buttonImportPatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportPatch.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonImportPatch.Name = "buttonImportPatch";
			this.buttonImportPatch.Size = new global::System.Drawing.Size(74, 24);
			this.buttonImportPatch.Text = "Import";
			this.buttonImportPatch.Click += new global::System.EventHandler(this.buttonImportPatch_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 27);
			this.buttonExitCreator.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExitCreator.Image");
			this.buttonExitCreator.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExitCreator.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonExitCreator.Name = "buttonExitCreator";
			this.buttonExitCreator.Size = new global::System.Drawing.Size(53, 24);
			this.buttonExitCreator.Text = "Exit";
			this.buttonExitCreator.Click += new global::System.EventHandler(this.buttonExitCreator_Click);
			this.buttonSelectAllObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSelectAllObjects.Image");
			this.buttonSelectAllObjects.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSelectAllObjects.Margin = new global::System.Windows.Forms.Padding(220, 1, 0, 2);
			this.buttonSelectAllObjects.Name = "buttonSelectAllObjects";
			this.buttonSelectAllObjects.Size = new global::System.Drawing.Size(91, 24);
			this.buttonSelectAllObjects.Text = "Select All";
			this.buttonSelectAllObjects.Click += new global::System.EventHandler(this.buttonSelectAll_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 27);
			this.buttonDeselectAllObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonDeselectAllObjects.Image");
			this.buttonDeselectAllObjects.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonDeselectAllObjects.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonDeselectAllObjects.Name = "buttonDeselectAllObjects";
			this.buttonDeselectAllObjects.Size = new global::System.Drawing.Size(108, 24);
			this.buttonDeselectAllObjects.Text = "Deselect All";
			this.buttonDeselectAllObjects.Click += new global::System.EventHandler(this.buttonDeselectAll_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 27);
			this.buttonSelectNewObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSelectNewObjects.Image");
			this.buttonSelectNewObjects.ImageTransparentColor = global::System.Drawing.Color.Transparent;
			this.buttonSelectNewObjects.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonSelectNewObjects.Name = "buttonSelectNewObjects";
			this.buttonSelectNewObjects.Size = new global::System.Drawing.Size(113, 24);
			this.buttonSelectNewObjects.Text = "Select if new";
			this.buttonSelectNewObjects.Click += new global::System.EventHandler(this.buttonSelectNewObjects_Click);
			this.stripButtonPreview.CheckOnClick = true;
			this.stripButtonPreview.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("stripButtonPreview.Image");
			this.stripButtonPreview.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.stripButtonPreview.Margin = new global::System.Windows.Forms.Padding(310, 1, 0, 2);
			this.stripButtonPreview.Name = "stripButtonPreview";
			this.stripButtonPreview.Size = new global::System.Drawing.Size(80, 24);
			this.stripButtonPreview.Text = "Preview";
			this.stripButtonPreview.Click += new global::System.EventHandler(this.stripButtonPreview_Click);
			this.panelLeft.AutoScroll = true;
			this.panelLeft.Controls.Add(this.textDescription);
			this.panelLeft.Controls.Add(this.groupPatchOptions);
			this.panelLeft.Controls.Add(this.textPatchVersion);
			this.panelLeft.Controls.Add(this.textPatchName);
			this.panelLeft.Controls.Add(this.labelDescription);
			this.panelLeft.Controls.Add(this.labelPatchVersion);
			this.panelLeft.Controls.Add(this.labelPatchName);
			this.panelLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new global::System.Drawing.Point(0, 55);
			this.panelLeft.Margin = new global::System.Windows.Forms.Padding(4);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new global::System.Drawing.Size(400, 838);
			this.panelLeft.TabIndex = 2;
			this.textDescription.BackColor = global::System.Drawing.Color.White;
			this.textDescription.Enabled = false;
			this.textDescription.Location = new global::System.Drawing.Point(11, 96);
			this.textDescription.Margin = new global::System.Windows.Forms.Padding(4);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new global::System.Drawing.Size(373, 245);
			this.textDescription.TabIndex = 33;
			this.groupPatchOptions.Controls.Add(this.tabPatchOptions);
			this.groupPatchOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupPatchOptions.Location = new global::System.Drawing.Point(0, 347);
			this.groupPatchOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupPatchOptions.Name = "groupPatchOptions";
			this.groupPatchOptions.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupPatchOptions.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.groupPatchOptions.Size = new global::System.Drawing.Size(400, 491);
			this.groupPatchOptions.TabIndex = 34;
			this.groupPatchOptions.TabStop = false;
			this.groupPatchOptions.Text = "Import Options";
			this.tabPatchOptions.Controls.Add(this.pagePlayerOptions);
			this.tabPatchOptions.Controls.Add(this.pageTeamOptions);
			this.tabPatchOptions.Controls.Add(this.pageLeagueOptions);
			this.tabPatchOptions.Controls.Add(this.pageStadiumOptions);
			this.tabPatchOptions.Controls.Add(this.pageKitOptions);
			this.tabPatchOptions.Controls.Add(this.pageCountryOptions);
			this.tabPatchOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabPatchOptions.ItemSize = new global::System.Drawing.Size(80, 20);
			this.tabPatchOptions.Location = new global::System.Drawing.Point(4, 19);
			this.tabPatchOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPatchOptions.Multiline = true;
			this.tabPatchOptions.Name = "tabPatchOptions";
			this.tabPatchOptions.SelectedIndex = 0;
			this.tabPatchOptions.Size = new global::System.Drawing.Size(392, 468);
			this.tabPatchOptions.SizeMode = global::System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabPatchOptions.TabIndex = 8;
			this.pagePlayerOptions.Controls.Add(this.groupDualClub);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerMiniface);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerHead);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerDatabase);
			this.pagePlayerOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pagePlayerOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pagePlayerOptions.Name = "pagePlayerOptions";
			this.pagePlayerOptions.Padding = new global::System.Windows.Forms.Padding(4);
			this.pagePlayerOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pagePlayerOptions.TabIndex = 0;
			this.pagePlayerOptions.Text = "Players";
			this.pagePlayerOptions.UseVisualStyleBackColor = true;
			this.groupDualClub.Controls.Add(this.radioPutInBothTeams);
			this.groupDualClub.Controls.Add(this.radioTransferToNewTeam);
			this.groupDualClub.Controls.Add(this.radioLeaveInExistingTeam);
			this.groupDualClub.Location = new global::System.Drawing.Point(27, 124);
			this.groupDualClub.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupDualClub.Name = "groupDualClub";
			this.groupDualClub.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupDualClub.Size = new global::System.Drawing.Size(319, 123);
			this.groupDualClub.TabIndex = 3;
			this.groupDualClub.TabStop = false;
			this.groupDualClub.Text = "Double Club Option";
			this.radioPutInBothTeams.AutoSize = true;
			this.radioPutInBothTeams.Checked = true;
			this.radioPutInBothTeams.Location = new global::System.Drawing.Point(11, 80);
			this.radioPutInBothTeams.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioPutInBothTeams.Name = "radioPutInBothTeams";
			this.radioPutInBothTeams.Size = new global::System.Drawing.Size(139, 21);
			this.radioPutInBothTeams.TabIndex = 6;
			this.radioPutInBothTeams.TabStop = true;
			this.radioPutInBothTeams.Text = "Put in both teams";
			this.radioPutInBothTeams.UseVisualStyleBackColor = true;
			this.radioTransferToNewTeam.AutoSize = true;
			this.radioTransferToNewTeam.Location = new global::System.Drawing.Point(11, 52);
			this.radioTransferToNewTeam.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTransferToNewTeam.Name = "radioTransferToNewTeam";
			this.radioTransferToNewTeam.Size = new global::System.Drawing.Size(163, 21);
			this.radioTransferToNewTeam.TabIndex = 5;
			this.radioTransferToNewTeam.Text = "Transfer to new team";
			this.radioTransferToNewTeam.UseVisualStyleBackColor = true;
			this.radioLeaveInExistingTeam.AutoSize = true;
			this.radioLeaveInExistingTeam.Location = new global::System.Drawing.Point(11, 23);
			this.radioLeaveInExistingTeam.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioLeaveInExistingTeam.Name = "radioLeaveInExistingTeam";
			this.radioLeaveInExistingTeam.Size = new global::System.Drawing.Size(167, 21);
			this.radioLeaveInExistingTeam.TabIndex = 4;
			this.radioLeaveInExistingTeam.Text = "Leave in current team";
			this.radioLeaveInExistingTeam.UseVisualStyleBackColor = true;
			this.checkPlayerMiniface.AutoSize = true;
			this.checkPlayerMiniface.Checked = true;
			this.checkPlayerMiniface.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerMiniface.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerMiniface.Location = new global::System.Drawing.Point(27, 81);
			this.checkPlayerMiniface.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkPlayerMiniface.Name = "checkPlayerMiniface";
			this.checkPlayerMiniface.Size = new global::System.Drawing.Size(82, 21);
			this.checkPlayerMiniface.TabIndex = 2;
			this.checkPlayerMiniface.Text = "Miniface";
			this.checkPlayerMiniface.UseVisualStyleBackColor = true;
			this.checkPlayerHead.AutoSize = true;
			this.checkPlayerHead.Checked = true;
			this.checkPlayerHead.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerHead.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerHead.Location = new global::System.Drawing.Point(27, 53);
			this.checkPlayerHead.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkPlayerHead.Name = "checkPlayerHead";
			this.checkPlayerHead.Size = new global::System.Drawing.Size(117, 21);
			this.checkPlayerHead.TabIndex = 1;
			this.checkPlayerHead.Text = "Specific Head";
			this.checkPlayerHead.UseVisualStyleBackColor = true;
			this.checkPlayerDatabase.AutoSize = true;
			this.checkPlayerDatabase.Checked = true;
			this.checkPlayerDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerDatabase.Location = new global::System.Drawing.Point(27, 25);
			this.checkPlayerDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkPlayerDatabase.Name = "checkPlayerDatabase";
			this.checkPlayerDatabase.Size = new global::System.Drawing.Size(161, 21);
			this.checkPlayerDatabase.TabIndex = 0;
			this.checkPlayerDatabase.Text = "Database player info";
			this.checkPlayerDatabase.UseVisualStyleBackColor = true;
			this.pageTeamOptions.Controls.Add(this.checkTeamFlags);
			this.pageTeamOptions.Controls.Add(this.checkTeamBanner);
			this.pageTeamOptions.Controls.Add(this.checkTeamLogo);
			this.pageTeamOptions.Controls.Add(this.checkTeamDatabase);
			this.pageTeamOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pageTeamOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageTeamOptions.Name = "pageTeamOptions";
			this.pageTeamOptions.Padding = new global::System.Windows.Forms.Padding(4);
			this.pageTeamOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pageTeamOptions.TabIndex = 1;
			this.pageTeamOptions.Text = "Teams";
			this.pageTeamOptions.UseVisualStyleBackColor = true;
			this.checkTeamFlags.AutoSize = true;
			this.checkTeamFlags.Checked = true;
			this.checkTeamFlags.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamFlags.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamFlags.Location = new global::System.Drawing.Point(27, 110);
			this.checkTeamFlags.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkTeamFlags.Name = "checkTeamFlags";
			this.checkTeamFlags.Size = new global::System.Drawing.Size(64, 21);
			this.checkTeamFlags.TabIndex = 5;
			this.checkTeamFlags.Text = "Flags";
			this.checkTeamFlags.UseVisualStyleBackColor = true;
			this.checkTeamBanner.AutoSize = true;
			this.checkTeamBanner.Checked = true;
			this.checkTeamBanner.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamBanner.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamBanner.Location = new global::System.Drawing.Point(27, 81);
			this.checkTeamBanner.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkTeamBanner.Name = "checkTeamBanner";
			this.checkTeamBanner.Size = new global::System.Drawing.Size(83, 21);
			this.checkTeamBanner.TabIndex = 3;
			this.checkTeamBanner.Text = "Banners";
			this.checkTeamBanner.UseVisualStyleBackColor = true;
			this.checkTeamLogo.AutoSize = true;
			this.checkTeamLogo.Checked = true;
			this.checkTeamLogo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamLogo.Location = new global::System.Drawing.Point(27, 53);
			this.checkTeamLogo.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkTeamLogo.Name = "checkTeamLogo";
			this.checkTeamLogo.Size = new global::System.Drawing.Size(62, 21);
			this.checkTeamLogo.TabIndex = 2;
			this.checkTeamLogo.Text = "Logo";
			this.checkTeamLogo.UseVisualStyleBackColor = true;
			this.checkTeamDatabase.AutoSize = true;
			this.checkTeamDatabase.Checked = true;
			this.checkTeamDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamDatabase.Location = new global::System.Drawing.Point(27, 25);
			this.checkTeamDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkTeamDatabase.Name = "checkTeamDatabase";
			this.checkTeamDatabase.Size = new global::System.Drawing.Size(153, 21);
			this.checkTeamDatabase.TabIndex = 1;
			this.checkTeamDatabase.Text = "Database team info";
			this.checkTeamDatabase.UseVisualStyleBackColor = true;
			this.pageLeagueOptions.Controls.Add(this.checkLeagueLogo);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueDatabase);
			this.pageLeagueOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pageLeagueOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageLeagueOptions.Name = "pageLeagueOptions";
			this.pageLeagueOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pageLeagueOptions.TabIndex = 2;
			this.pageLeagueOptions.Text = "Leagues";
			this.pageLeagueOptions.UseVisualStyleBackColor = true;
			this.checkLeagueLogo.AutoSize = true;
			this.checkLeagueLogo.Checked = true;
			this.checkLeagueLogo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueLogo.Location = new global::System.Drawing.Point(27, 53);
			this.checkLeagueLogo.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkLeagueLogo.Name = "checkLeagueLogo";
			this.checkLeagueLogo.Size = new global::System.Drawing.Size(62, 21);
			this.checkLeagueLogo.TabIndex = 10;
			this.checkLeagueLogo.Text = "Logo";
			this.checkLeagueLogo.UseVisualStyleBackColor = true;
			this.checkLeagueDatabase.AutoSize = true;
			this.checkLeagueDatabase.Checked = true;
			this.checkLeagueDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueDatabase.Location = new global::System.Drawing.Point(27, 25);
			this.checkLeagueDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkLeagueDatabase.Name = "checkLeagueDatabase";
			this.checkLeagueDatabase.Size = new global::System.Drawing.Size(165, 21);
			this.checkLeagueDatabase.TabIndex = 9;
			this.checkLeagueDatabase.Text = "Database league info";
			this.checkLeagueDatabase.UseVisualStyleBackColor = true;
			this.pageStadiumOptions.Controls.Add(this.checkStadiumModel);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumPreview);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumDatabase);
			this.pageStadiumOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pageStadiumOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageStadiumOptions.Name = "pageStadiumOptions";
			this.pageStadiumOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pageStadiumOptions.TabIndex = 6;
			this.pageStadiumOptions.Text = "Stadiums";
			this.pageStadiumOptions.ToolTipText = "Check the stadium elements that you want to import (if present)";
			this.pageStadiumOptions.UseVisualStyleBackColor = true;
			this.checkStadiumModel.AutoSize = true;
			this.checkStadiumModel.Checked = true;
			this.checkStadiumModel.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumModel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumModel.Location = new global::System.Drawing.Point(27, 53);
			this.checkStadiumModel.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkStadiumModel.Name = "checkStadiumModel";
			this.checkStadiumModel.Size = new global::System.Drawing.Size(90, 21);
			this.checkStadiumModel.TabIndex = 19;
			this.checkStadiumModel.Text = "3D model";
			this.checkStadiumModel.UseVisualStyleBackColor = true;
			this.checkStadiumPreview.AutoSize = true;
			this.checkStadiumPreview.Checked = true;
			this.checkStadiumPreview.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumPreview.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumPreview.Location = new global::System.Drawing.Point(27, 81);
			this.checkStadiumPreview.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkStadiumPreview.Name = "checkStadiumPreview";
			this.checkStadiumPreview.Size = new global::System.Drawing.Size(126, 21);
			this.checkStadiumPreview.TabIndex = 17;
			this.checkStadiumPreview.Text = "Preview picture";
			this.checkStadiumPreview.UseVisualStyleBackColor = true;
			this.checkStadiumDatabase.AutoSize = true;
			this.checkStadiumDatabase.Checked = true;
			this.checkStadiumDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumDatabase.Location = new global::System.Drawing.Point(27, 25);
			this.checkStadiumDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkStadiumDatabase.Name = "checkStadiumDatabase";
			this.checkStadiumDatabase.Size = new global::System.Drawing.Size(171, 21);
			this.checkStadiumDatabase.TabIndex = 16;
			this.checkStadiumDatabase.Text = "Database stadium info";
			this.checkStadiumDatabase.UseVisualStyleBackColor = true;
			this.pageKitOptions.Controls.Add(this.checkMinikits);
			this.pageKitOptions.Controls.Add(this.checkKits);
			this.pageKitOptions.Controls.Add(this.checkKitDatabase);
			this.pageKitOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pageKitOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageKitOptions.Name = "pageKitOptions";
			this.pageKitOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pageKitOptions.TabIndex = 5;
			this.pageKitOptions.Text = "Kits";
			this.pageKitOptions.UseVisualStyleBackColor = true;
			this.checkMinikits.AutoSize = true;
			this.checkMinikits.Checked = true;
			this.checkMinikits.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkMinikits.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkMinikits.Location = new global::System.Drawing.Point(27, 53);
			this.checkMinikits.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkMinikits.Name = "checkMinikits";
			this.checkMinikits.Size = new global::System.Drawing.Size(76, 21);
			this.checkMinikits.TabIndex = 9;
			this.checkMinikits.Text = "Minikits";
			this.checkMinikits.UseVisualStyleBackColor = true;
			this.checkKits.AutoSize = true;
			this.checkKits.Checked = true;
			this.checkKits.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKits.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKits.Location = new global::System.Drawing.Point(27, 25);
			this.checkKits.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkKits.Name = "checkKits";
			this.checkKits.Size = new global::System.Drawing.Size(53, 21);
			this.checkKits.TabIndex = 8;
			this.checkKits.Text = "Kits";
			this.checkKits.UseVisualStyleBackColor = true;
			this.checkKitDatabase.AutoSize = true;
			this.checkKitDatabase.Checked = true;
			this.checkKitDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitDatabase.Location = new global::System.Drawing.Point(205, 53);
			this.checkKitDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkKitDatabase.Name = "checkKitDatabase";
			this.checkKitDatabase.Size = new global::System.Drawing.Size(136, 21);
			this.checkKitDatabase.TabIndex = 2;
			this.checkKitDatabase.Text = "Database kit info";
			this.checkKitDatabase.UseVisualStyleBackColor = true;
			this.checkKitDatabase.Visible = false;
			this.pageCountryOptions.Controls.Add(this.checkCountryMap);
			this.pageCountryOptions.Controls.Add(this.checkCountryDatabase);
			this.pageCountryOptions.Controls.Add(this.checkCountryFlag);
			this.pageCountryOptions.Location = new global::System.Drawing.Point(4, 24);
			this.pageCountryOptions.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageCountryOptions.Name = "pageCountryOptions";
			this.pageCountryOptions.Size = new global::System.Drawing.Size(384, 440);
			this.pageCountryOptions.TabIndex = 3;
			this.pageCountryOptions.Text = "Countries";
			this.pageCountryOptions.UseVisualStyleBackColor = true;
			this.checkCountryMap.AutoSize = true;
			this.checkCountryMap.Checked = true;
			this.checkCountryMap.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryMap.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryMap.Location = new global::System.Drawing.Point(27, 81);
			this.checkCountryMap.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkCountryMap.Name = "checkCountryMap";
			this.checkCountryMap.Size = new global::System.Drawing.Size(57, 21);
			this.checkCountryMap.TabIndex = 3;
			this.checkCountryMap.Text = "Map";
			this.checkCountryMap.UseVisualStyleBackColor = true;
			this.checkCountryDatabase.AutoSize = true;
			this.checkCountryDatabase.Checked = true;
			this.checkCountryDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryDatabase.Location = new global::System.Drawing.Point(27, 25);
			this.checkCountryDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkCountryDatabase.Name = "checkCountryDatabase";
			this.checkCountryDatabase.Size = new global::System.Drawing.Size(169, 21);
			this.checkCountryDatabase.TabIndex = 1;
			this.checkCountryDatabase.Text = "Database country info";
			this.checkCountryDatabase.UseVisualStyleBackColor = true;
			this.checkCountryFlag.AutoSize = true;
			this.checkCountryFlag.Checked = true;
			this.checkCountryFlag.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryFlag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryFlag.Location = new global::System.Drawing.Point(27, 53);
			this.checkCountryFlag.Margin = new global::System.Windows.Forms.Padding(4);
			this.checkCountryFlag.Name = "checkCountryFlag";
			this.checkCountryFlag.Size = new global::System.Drawing.Size(64, 21);
			this.checkCountryFlag.TabIndex = 0;
			this.checkCountryFlag.Text = "Flags";
			this.checkCountryFlag.UseVisualStyleBackColor = true;
			this.textPatchVersion.BackColor = global::System.Drawing.Color.White;
			this.textPatchVersion.Enabled = false;
			this.textPatchVersion.Location = new global::System.Drawing.Point(101, 41);
			this.textPatchVersion.Margin = new global::System.Windows.Forms.Padding(4);
			this.textPatchVersion.Name = "textPatchVersion";
			this.textPatchVersion.Size = new global::System.Drawing.Size(283, 22);
			this.textPatchVersion.TabIndex = 31;
			this.textPatchVersion.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textPatchName.BackColor = global::System.Drawing.Color.White;
			this.textPatchName.Enabled = false;
			this.textPatchName.Location = new global::System.Drawing.Point(103, 6);
			this.textPatchName.Margin = new global::System.Windows.Forms.Padding(4);
			this.textPatchName.Name = "textPatchName";
			this.textPatchName.Size = new global::System.Drawing.Size(283, 22);
			this.textPatchName.TabIndex = 29;
			this.textPatchName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelDescription.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelDescription.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDescription.Location = new global::System.Drawing.Point(0, 68);
			this.labelDescription.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new global::System.Drawing.Size(400, 279);
			this.labelDescription.TabIndex = 32;
			this.labelDescription.Text = "Description";
			this.labelDescription.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.labelPatchVersion.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelPatchVersion.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPatchVersion.Location = new global::System.Drawing.Point(0, 34);
			this.labelPatchVersion.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPatchVersion.Name = "labelPatchVersion";
			this.labelPatchVersion.Size = new global::System.Drawing.Size(400, 34);
			this.labelPatchVersion.TabIndex = 30;
			this.labelPatchVersion.Text = "Patch Version";
			this.labelPatchVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPatchName.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelPatchName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPatchName.Location = new global::System.Drawing.Point(0, 0);
			this.labelPatchName.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPatchName.Name = "labelPatchName";
			this.labelPatchName.Size = new global::System.Drawing.Size(400, 34);
			this.labelPatchName.TabIndex = 28;
			this.labelPatchName.Text = "Patch Name";
			this.labelPatchName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.statusBar.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.statusLabel });
			this.statusBar.Location = new global::System.Drawing.Point(0, 893);
			this.statusBar.Name = "statusBar";
			this.statusBar.Padding = new global::System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusBar.Size = new global::System.Drawing.Size(1543, 25);
			this.statusBar.TabIndex = 3;
			this.statusBar.Text = "statusStrip1";
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new global::System.Drawing.Size(50, 20);
			this.statusLabel.Text = "Ready";
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(400, 55);
			this.splitContainer1.Margin = new global::System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.listViewPatch);
			this.splitContainer1.Panel2.Controls.Add(this.panelRight);
			this.splitContainer1.Size = new global::System.Drawing.Size(1143, 838);
			this.splitContainer1.SplitterDistance = 624;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 3;
			this.splitContainer1.TabStop = false;
			this.listViewPatch.AllowColumnReorder = true;
			this.listViewPatch.CheckBoxes = true;
			this.listViewPatch.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnItem, this.columnType, this.columnPatchId, this.columnImportId, this.columnComment });
			this.listViewPatch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPatch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.listViewPatch.FullRowSelect = true;
			this.listViewPatch.GridLines = true;
			this.listViewPatch.HideSelection = false;
			this.listViewPatch.Location = new global::System.Drawing.Point(0, 0);
			this.listViewPatch.Margin = new global::System.Windows.Forms.Padding(4);
			this.listViewPatch.Name = "listViewPatch";
			this.listViewPatch.Size = new global::System.Drawing.Size(624, 838);
			this.listViewPatch.TabIndex = 28;
			this.listViewPatch.UseCompatibleStateImageBehavior = false;
			this.listViewPatch.View = global::System.Windows.Forms.View.Details;
			this.listViewPatch.SelectedIndexChanged += new global::System.EventHandler(this.listViewPatch_SelectedIndexChanged);
			this.columnItem.Text = "Name";
			this.columnItem.Width = 136;
			this.columnType.Text = "Type";
			this.columnType.Width = 68;
			this.columnPatchId.Text = "Patch Id";
			this.columnPatchId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnPatchId.Width = 55;
			this.columnImportId.Text = "Import As";
			this.columnImportId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnComment.Text = "Comment";
			this.columnComment.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnComment.Width = 121;
			this.panelRight.AutoScroll = true;
			this.panelRight.Controls.Add(this.tabPreview);
			this.panelRight.Controls.Add(this.panelGraphicGroups);
			this.panelRight.Controls.Add(this.pictureBox1);
			this.panelRight.Controls.Add(this.groupReplaceSelection);
			this.panelRight.Controls.Add(this.labelDetails);
			this.panelRight.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new global::System.Drawing.Point(0, 0);
			this.panelRight.Margin = new global::System.Windows.Forms.Padding(4);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new global::System.Drawing.Size(514, 838);
			this.panelRight.TabIndex = 4;
			this.tabPreview.Controls.Add(this.pageViewer2D);
			this.tabPreview.Controls.Add(this.pageMultiViewer2D);
			this.tabPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabPreview.Location = new global::System.Drawing.Point(0, 283);
			this.tabPreview.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPreview.Name = "tabPreview";
			this.tabPreview.SelectedIndex = 0;
			this.tabPreview.Size = new global::System.Drawing.Size(514, 555);
			this.tabPreview.TabIndex = 53;
			this.pageViewer2D.Controls.Add(this.viewer2D);
			this.pageViewer2D.Location = new global::System.Drawing.Point(4, 25);
			this.pageViewer2D.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageViewer2D.Name = "pageViewer2D";
			this.pageViewer2D.Padding = new global::System.Windows.Forms.Padding(4);
			this.pageViewer2D.Size = new global::System.Drawing.Size(506, 526);
			this.pageViewer2D.TabIndex = 0;
			this.pageViewer2D.Text = "UI Art Assets";
			this.pageViewer2D.UseVisualStyleBackColor = true;
			this.viewer2D.AutoTransparency = false;
			this.viewer2D.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2D.ButtonStripVisible = false;
			this.viewer2D.CurrentBitmap = null;
			this.viewer2D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer2D.ExtendedFormat = false;
			this.viewer2D.FullSizeButton = false;
			this.viewer2D.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2D.ImageSize = new global::System.Drawing.Size(0, 0);
			this.viewer2D.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2D.Location = new global::System.Drawing.Point(4, 4);
			this.viewer2D.Margin = new global::System.Windows.Forms.Padding(5);
			this.viewer2D.Name = "viewer2D";
			this.viewer2D.RemoveButton = false;
			this.viewer2D.ShowButton = false;
			this.viewer2D.ShowButtonChecked = true;
			this.viewer2D.Size = new global::System.Drawing.Size(498, 518);
			this.viewer2D.TabIndex = 0;
			this.pageMultiViewer2D.Controls.Add(this.multiViewer2D);
			this.pageMultiViewer2D.Location = new global::System.Drawing.Point(4, 25);
			this.pageMultiViewer2D.Margin = new global::System.Windows.Forms.Padding(4);
			this.pageMultiViewer2D.Name = "pageMultiViewer2D";
			this.pageMultiViewer2D.Size = new global::System.Drawing.Size(506, 526);
			this.pageMultiViewer2D.TabIndex = 2;
			this.pageMultiViewer2D.Text = "Scene Assets";
			this.pageMultiViewer2D.UseVisualStyleBackColor = true;
			this.multiViewer2D.AutoTransparency = false;
			this.multiViewer2D.Bitmaps = null;
			this.multiViewer2D.CheckBitmapSize = false;
			this.multiViewer2D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.multiViewer2D.FixedSize = false;
			this.multiViewer2D.FullSizeButton = false;
			this.multiViewer2D.LabelText = "Image n.";
			this.multiViewer2D.Location = new global::System.Drawing.Point(0, 0);
			this.multiViewer2D.Margin = new global::System.Windows.Forms.Padding(4);
			this.multiViewer2D.Name = "multiViewer2D";
			this.multiViewer2D.ShowButton = false;
			this.multiViewer2D.ShowDeleteButton = false;
			this.multiViewer2D.Size = new global::System.Drawing.Size(506, 526);
			this.multiViewer2D.TabIndex = 0;
			this.panelGraphicGroups.Controls.Add(this.groupTeam);
			this.panelGraphicGroups.Controls.Add(this.groupLeague);
			this.panelGraphicGroups.Controls.Add(this.groupStadium);
			this.panelGraphicGroups.Controls.Add(this.groupShoes);
			this.panelGraphicGroups.Controls.Add(this.groupBall);
			this.panelGraphicGroups.Controls.Add(this.groupCountry);
			this.panelGraphicGroups.Controls.Add(this.groupAdboards);
			this.panelGraphicGroups.Controls.Add(this.groupKit);
			this.panelGraphicGroups.Controls.Add(this.groupPlayer);
			this.panelGraphicGroups.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelGraphicGroups.Location = new global::System.Drawing.Point(0, 155);
			this.panelGraphicGroups.Margin = new global::System.Windows.Forms.Padding(4);
			this.panelGraphicGroups.Name = "panelGraphicGroups";
			this.panelGraphicGroups.Size = new global::System.Drawing.Size(514, 128);
			this.panelGraphicGroups.TabIndex = 52;
			this.panelGraphicGroups.Visible = false;
			this.groupTeam.Controls.Add(this.radioTeamCrest50);
			this.groupTeam.Controls.Add(this.radioTeamCrest16);
			this.groupTeam.Controls.Add(this.radioTeamCrest32);
			this.groupTeam.Controls.Add(this.radioTeamCrestLarge);
			this.groupTeam.Controls.Add(this.radioTeamFlags);
			this.groupTeam.Controls.Add(this.radioTeamBanners);
			this.groupTeam.Location = new global::System.Drawing.Point(7, 6);
			this.groupTeam.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupTeam.Name = "groupTeam";
			this.groupTeam.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupTeam.Size = new global::System.Drawing.Size(320, 111);
			this.groupTeam.TabIndex = 41;
			this.groupTeam.TabStop = false;
			this.groupTeam.Text = "Team";
			this.groupTeam.Visible = false;
			this.radioTeamCrest50.AutoSize = true;
			this.radioTeamCrest50.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamCrest50.Location = new global::System.Drawing.Point(164, 20);
			this.radioTeamCrest50.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamCrest50.Name = "radioTeamCrest50";
			this.radioTeamCrest50.Size = new global::System.Drawing.Size(112, 21);
			this.radioTeamCrest50.TabIndex = 14;
			this.radioTeamCrest50.Text = "Crest 50 x 50";
			this.radioTeamCrest50.UseVisualStyleBackColor = true;
			this.radioTeamCrest50.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioTeamCrest16.AutoSize = true;
			this.radioTeamCrest16.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamCrest16.Location = new global::System.Drawing.Point(164, 71);
			this.radioTeamCrest16.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamCrest16.Name = "radioTeamCrest16";
			this.radioTeamCrest16.Size = new global::System.Drawing.Size(112, 21);
			this.radioTeamCrest16.TabIndex = 13;
			this.radioTeamCrest16.Text = "Crest 16 x 16";
			this.radioTeamCrest16.UseVisualStyleBackColor = true;
			this.radioTeamCrest16.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioTeamCrest32.AutoSize = true;
			this.radioTeamCrest32.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamCrest32.Location = new global::System.Drawing.Point(164, 46);
			this.radioTeamCrest32.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamCrest32.Name = "radioTeamCrest32";
			this.radioTeamCrest32.Size = new global::System.Drawing.Size(112, 21);
			this.radioTeamCrest32.TabIndex = 12;
			this.radioTeamCrest32.Text = "Crest 32 x 32";
			this.radioTeamCrest32.UseVisualStyleBackColor = true;
			this.radioTeamCrest32.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioTeamCrestLarge.AutoSize = true;
			this.radioTeamCrestLarge.Checked = true;
			this.radioTeamCrestLarge.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamCrestLarge.Location = new global::System.Drawing.Point(8, 20);
			this.radioTeamCrestLarge.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamCrestLarge.Name = "radioTeamCrestLarge";
			this.radioTeamCrestLarge.Size = new global::System.Drawing.Size(62, 21);
			this.radioTeamCrestLarge.TabIndex = 11;
			this.radioTeamCrestLarge.TabStop = true;
			this.radioTeamCrestLarge.Text = "Crest";
			this.radioTeamCrestLarge.UseVisualStyleBackColor = true;
			this.radioTeamCrestLarge.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioTeamFlags.AutoSize = true;
			this.radioTeamFlags.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamFlags.Location = new global::System.Drawing.Point(9, 73);
			this.radioTeamFlags.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamFlags.Name = "radioTeamFlags";
			this.radioTeamFlags.Size = new global::System.Drawing.Size(63, 21);
			this.radioTeamFlags.TabIndex = 10;
			this.radioTeamFlags.Text = "Flags";
			this.radioTeamFlags.UseVisualStyleBackColor = true;
			this.radioTeamFlags.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioTeamBanners.AutoSize = true;
			this.radioTeamBanners.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioTeamBanners.Location = new global::System.Drawing.Point(9, 46);
			this.radioTeamBanners.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioTeamBanners.Name = "radioTeamBanners";
			this.radioTeamBanners.Size = new global::System.Drawing.Size(82, 21);
			this.radioTeamBanners.TabIndex = 9;
			this.radioTeamBanners.Text = "Banners";
			this.radioTeamBanners.UseVisualStyleBackColor = true;
			this.radioTeamBanners.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupLeague.Controls.Add(this.radioLeagueLogo512x128);
			this.groupLeague.Controls.Add(this.radioLeagueAnimLogo);
			this.groupLeague.Controls.Add(this.radioLeagueTinyLogo);
			this.groupLeague.Controls.Add(this.radioLeagueSmallLogo);
			this.groupLeague.Location = new global::System.Drawing.Point(7, 6);
			this.groupLeague.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupLeague.Name = "groupLeague";
			this.groupLeague.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupLeague.Size = new global::System.Drawing.Size(320, 111);
			this.groupLeague.TabIndex = 49;
			this.groupLeague.TabStop = false;
			this.groupLeague.Text = "League";
			this.groupLeague.Visible = false;
			this.radioLeagueLogo512x128.AutoSize = true;
			this.radioLeagueLogo512x128.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioLeagueLogo512x128.Location = new global::System.Drawing.Point(140, 23);
			this.radioLeagueLogo512x128.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioLeagueLogo512x128.Name = "radioLeagueLogo512x128";
			this.radioLeagueLogo512x128.Size = new global::System.Drawing.Size(127, 21);
			this.radioLeagueLogo512x128.TabIndex = 4;
			this.radioLeagueLogo512x128.Text = "Logo 512 x 128";
			this.radioLeagueLogo512x128.UseVisualStyleBackColor = true;
			this.radioLeagueLogo512x128.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioLeagueAnimLogo.AutoSize = true;
			this.radioLeagueAnimLogo.Checked = true;
			this.radioLeagueAnimLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioLeagueAnimLogo.Location = new global::System.Drawing.Point(9, 23);
			this.radioLeagueAnimLogo.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioLeagueAnimLogo.Name = "radioLeagueAnimLogo";
			this.radioLeagueAnimLogo.Size = new global::System.Drawing.Size(95, 21);
			this.radioLeagueAnimLogo.TabIndex = 3;
			this.radioLeagueAnimLogo.TabStop = true;
			this.radioLeagueAnimLogo.Text = "Main Logo";
			this.radioLeagueAnimLogo.UseVisualStyleBackColor = true;
			this.radioLeagueAnimLogo.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioLeagueTinyLogo.AutoSize = true;
			this.radioLeagueTinyLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioLeagueTinyLogo.Location = new global::System.Drawing.Point(8, 55);
			this.radioLeagueTinyLogo.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioLeagueTinyLogo.Name = "radioLeagueTinyLogo";
			this.radioLeagueTinyLogo.Size = new global::System.Drawing.Size(92, 21);
			this.radioLeagueTinyLogo.TabIndex = 2;
			this.radioLeagueTinyLogo.Text = "Tiny Logo";
			this.radioLeagueTinyLogo.UseVisualStyleBackColor = true;
			this.radioLeagueTinyLogo.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioLeagueSmallLogo.AutoSize = true;
			this.radioLeagueSmallLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioLeagueSmallLogo.Location = new global::System.Drawing.Point(140, 54);
			this.radioLeagueSmallLogo.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioLeagueSmallLogo.Name = "radioLeagueSmallLogo";
			this.radioLeagueSmallLogo.Size = new global::System.Drawing.Size(99, 21);
			this.radioLeagueSmallLogo.TabIndex = 1;
			this.radioLeagueSmallLogo.Text = "Small Logo";
			this.radioLeagueSmallLogo.UseVisualStyleBackColor = true;
			this.radioLeagueSmallLogo.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupStadium.Controls.Add(this.radioStadiumPreview);
			this.groupStadium.Controls.Add(this.groupTod);
			this.groupStadium.Controls.Add(this.radioStadium3D);
			this.groupStadium.Location = new global::System.Drawing.Point(7, 6);
			this.groupStadium.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupStadium.Name = "groupStadium";
			this.groupStadium.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupStadium.Size = new global::System.Drawing.Size(320, 111);
			this.groupStadium.TabIndex = 45;
			this.groupStadium.TabStop = false;
			this.groupStadium.Text = "Stadium";
			this.groupStadium.Visible = false;
			this.radioStadiumPreview.AutoSize = true;
			this.radioStadiumPreview.Checked = true;
			this.radioStadiumPreview.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadiumPreview.Location = new global::System.Drawing.Point(9, 20);
			this.radioStadiumPreview.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadiumPreview.Name = "radioStadiumPreview";
			this.radioStadiumPreview.Size = new global::System.Drawing.Size(78, 21);
			this.radioStadiumPreview.TabIndex = 12;
			this.radioStadiumPreview.TabStop = true;
			this.radioStadiumPreview.Text = "Preview";
			this.radioStadiumPreview.UseVisualStyleBackColor = true;
			this.radioStadiumPreview.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupTod.Controls.Add(this.radioStadiumGuiNight);
			this.groupTod.Controls.Add(this.radioStadiumGuiSunset);
			this.groupTod.Controls.Add(this.radioStadiumGuiOvercast);
			this.groupTod.Controls.Add(this.radioStadiumGuiClearDay);
			this.groupTod.Location = new global::System.Drawing.Point(173, 9);
			this.groupTod.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupTod.Name = "groupTod";
			this.groupTod.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupTod.Size = new global::System.Drawing.Size(139, 102);
			this.groupTod.TabIndex = 11;
			this.groupTod.TabStop = false;
			this.groupTod.Text = "Time of Day";
			this.radioStadiumGuiNight.AutoSize = true;
			this.radioStadiumGuiNight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadiumGuiNight.Location = new global::System.Drawing.Point(9, 58);
			this.radioStadiumGuiNight.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadiumGuiNight.Name = "radioStadiumGuiNight";
			this.radioStadiumGuiNight.Size = new global::System.Drawing.Size(62, 21);
			this.radioStadiumGuiNight.TabIndex = 10;
			this.radioStadiumGuiNight.TabStop = true;
			this.radioStadiumGuiNight.Text = "Night";
			this.radioStadiumGuiNight.UseVisualStyleBackColor = true;
			this.radioStadiumGuiNight.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioStadiumGuiSunset.AutoSize = true;
			this.radioStadiumGuiSunset.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadiumGuiSunset.Location = new global::System.Drawing.Point(9, 78);
			this.radioStadiumGuiSunset.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadiumGuiSunset.Name = "radioStadiumGuiSunset";
			this.radioStadiumGuiSunset.Size = new global::System.Drawing.Size(73, 21);
			this.radioStadiumGuiSunset.TabIndex = 9;
			this.radioStadiumGuiSunset.TabStop = true;
			this.radioStadiumGuiSunset.Text = "Sunset";
			this.radioStadiumGuiSunset.UseVisualStyleBackColor = true;
			this.radioStadiumGuiSunset.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioStadiumGuiOvercast.AutoSize = true;
			this.radioStadiumGuiOvercast.Checked = true;
			this.radioStadiumGuiOvercast.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadiumGuiOvercast.Location = new global::System.Drawing.Point(9, 17);
			this.radioStadiumGuiOvercast.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadiumGuiOvercast.Name = "radioStadiumGuiOvercast";
			this.radioStadiumGuiOvercast.Size = new global::System.Drawing.Size(115, 21);
			this.radioStadiumGuiOvercast.TabIndex = 6;
			this.radioStadiumGuiOvercast.TabStop = true;
			this.radioStadiumGuiOvercast.Text = "Overcast Day";
			this.radioStadiumGuiOvercast.UseVisualStyleBackColor = true;
			this.radioStadiumGuiOvercast.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioStadiumGuiClearDay.AutoSize = true;
			this.radioStadiumGuiClearDay.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadiumGuiClearDay.Location = new global::System.Drawing.Point(9, 37);
			this.radioStadiumGuiClearDay.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadiumGuiClearDay.Name = "radioStadiumGuiClearDay";
			this.radioStadiumGuiClearDay.Size = new global::System.Drawing.Size(91, 21);
			this.radioStadiumGuiClearDay.TabIndex = 7;
			this.radioStadiumGuiClearDay.TabStop = true;
			this.radioStadiumGuiClearDay.Text = "Clear Day";
			this.radioStadiumGuiClearDay.UseVisualStyleBackColor = true;
			this.radioStadiumGuiClearDay.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioStadium3D.AutoSize = true;
			this.radioStadium3D.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioStadium3D.Location = new global::System.Drawing.Point(9, 46);
			this.radioStadium3D.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioStadium3D.Name = "radioStadium3D";
			this.radioStadium3D.Size = new global::System.Drawing.Size(106, 21);
			this.radioStadium3D.TabIndex = 8;
			this.radioStadium3D.TabStop = true;
			this.radioStadium3D.Text = "3D Textures";
			this.radioStadium3D.UseVisualStyleBackColor = true;
			this.radioStadium3D.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupShoes.Controls.Add(this.radioShoesColor);
			this.groupShoes.Location = new global::System.Drawing.Point(7, 6);
			this.groupShoes.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupShoes.Name = "groupShoes";
			this.groupShoes.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupShoes.Size = new global::System.Drawing.Size(320, 111);
			this.groupShoes.TabIndex = 52;
			this.groupShoes.TabStop = false;
			this.groupShoes.Text = "Shoes";
			this.groupShoes.Visible = false;
			this.radioShoesColor.AutoSize = true;
			this.radioShoesColor.Checked = true;
			this.radioShoesColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioShoesColor.Location = new global::System.Drawing.Point(8, 23);
			this.radioShoesColor.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioShoesColor.Name = "radioShoesColor";
			this.radioShoesColor.Size = new global::System.Drawing.Size(121, 21);
			this.radioShoesColor.TabIndex = 9;
			this.radioShoesColor.TabStop = true;
			this.radioShoesColor.Text = "Color Textures";
			this.radioShoesColor.UseVisualStyleBackColor = true;
			this.radioShoesColor.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupBall.Controls.Add(this.radioBallPreview);
			this.groupBall.Controls.Add(this.radioBallTexture);
			this.groupBall.Location = new global::System.Drawing.Point(7, 6);
			this.groupBall.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupBall.Name = "groupBall";
			this.groupBall.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupBall.Size = new global::System.Drawing.Size(320, 111);
			this.groupBall.TabIndex = 47;
			this.groupBall.TabStop = false;
			this.groupBall.Text = "Ball";
			this.groupBall.Visible = false;
			this.radioBallPreview.AutoSize = true;
			this.radioBallPreview.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioBallPreview.Location = new global::System.Drawing.Point(8, 52);
			this.radioBallPreview.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioBallPreview.Name = "radioBallPreview";
			this.radioBallPreview.Size = new global::System.Drawing.Size(78, 21);
			this.radioBallPreview.TabIndex = 4;
			this.radioBallPreview.TabStop = true;
			this.radioBallPreview.Text = "Preview";
			this.radioBallPreview.UseVisualStyleBackColor = true;
			this.radioBallPreview.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioBallTexture.AutoSize = true;
			this.radioBallTexture.Checked = true;
			this.radioBallTexture.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioBallTexture.Location = new global::System.Drawing.Point(8, 23);
			this.radioBallTexture.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioBallTexture.Name = "radioBallTexture";
			this.radioBallTexture.Size = new global::System.Drawing.Size(84, 21);
			this.radioBallTexture.TabIndex = 3;
			this.radioBallTexture.TabStop = true;
			this.radioBallTexture.Text = "Textures";
			this.radioBallTexture.UseVisualStyleBackColor = true;
			this.radioBallTexture.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupCountry.Controls.Add(this.radioCountryMap);
			this.groupCountry.Controls.Add(this.radioCountryFlag512x512);
			this.groupCountry.Controls.Add(this.radioCountryCard);
			this.groupCountry.Controls.Add(this.radioCountryMainFlag);
			this.groupCountry.Controls.Add(this.radioCountryMiniflag);
			this.groupCountry.Location = new global::System.Drawing.Point(7, 6);
			this.groupCountry.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupCountry.Name = "groupCountry";
			this.groupCountry.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupCountry.Size = new global::System.Drawing.Size(320, 111);
			this.groupCountry.TabIndex = 48;
			this.groupCountry.TabStop = false;
			this.groupCountry.Text = "Country";
			this.groupCountry.Visible = false;
			this.radioCountryMap.AutoSize = true;
			this.radioCountryMap.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCountryMap.Location = new global::System.Drawing.Point(133, 58);
			this.radioCountryMap.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCountryMap.Name = "radioCountryMap";
			this.radioCountryMap.Size = new global::System.Drawing.Size(56, 21);
			this.radioCountryMap.TabIndex = 7;
			this.radioCountryMap.Text = "Map";
			this.radioCountryMap.UseVisualStyleBackColor = false;
			this.radioCountryMap.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioCountryFlag512x512.AutoSize = true;
			this.radioCountryFlag512x512.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCountryFlag512x512.Location = new global::System.Drawing.Point(132, 27);
			this.radioCountryFlag512x512.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCountryFlag512x512.Name = "radioCountryFlag512x512";
			this.radioCountryFlag512x512.Size = new global::System.Drawing.Size(122, 21);
			this.radioCountryFlag512x512.TabIndex = 6;
			this.radioCountryFlag512x512.Text = "Flag 512 x 512";
			this.radioCountryFlag512x512.UseVisualStyleBackColor = false;
			this.radioCountryFlag512x512.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioCountryCard.AutoSize = true;
			this.radioCountryCard.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCountryCard.Location = new global::System.Drawing.Point(8, 84);
			this.radioCountryCard.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCountryCard.Name = "radioCountryCard";
			this.radioCountryCard.Size = new global::System.Drawing.Size(59, 21);
			this.radioCountryCard.TabIndex = 5;
			this.radioCountryCard.Text = "Card";
			this.radioCountryCard.UseVisualStyleBackColor = true;
			this.radioCountryCard.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioCountryMainFlag.AutoSize = true;
			this.radioCountryMainFlag.Checked = true;
			this.radioCountryMainFlag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCountryMainFlag.Location = new global::System.Drawing.Point(8, 27);
			this.radioCountryMainFlag.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCountryMainFlag.Name = "radioCountryMainFlag";
			this.radioCountryMainFlag.Size = new global::System.Drawing.Size(90, 21);
			this.radioCountryMainFlag.TabIndex = 4;
			this.radioCountryMainFlag.TabStop = true;
			this.radioCountryMainFlag.Text = "Main Flag";
			this.radioCountryMainFlag.UseVisualStyleBackColor = false;
			this.radioCountryMainFlag.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioCountryMiniflag.AutoSize = true;
			this.radioCountryMiniflag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCountryMiniflag.Location = new global::System.Drawing.Point(8, 55);
			this.radioCountryMiniflag.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCountryMiniflag.Name = "radioCountryMiniflag";
			this.radioCountryMiniflag.Size = new global::System.Drawing.Size(77, 21);
			this.radioCountryMiniflag.TabIndex = 2;
			this.radioCountryMiniflag.Text = "Miniflag";
			this.radioCountryMiniflag.UseVisualStyleBackColor = true;
			this.radioCountryMiniflag.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupAdboards.Controls.Add(this.radioAdboard1);
			this.groupAdboards.Location = new global::System.Drawing.Point(7, 6);
			this.groupAdboards.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupAdboards.Name = "groupAdboards";
			this.groupAdboards.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupAdboards.Size = new global::System.Drawing.Size(320, 111);
			this.groupAdboards.TabIndex = 46;
			this.groupAdboards.TabStop = false;
			this.groupAdboards.Text = "Adboards";
			this.groupAdboards.Visible = false;
			this.radioAdboard1.AutoSize = true;
			this.radioAdboard1.Checked = true;
			this.radioAdboard1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioAdboard1.Location = new global::System.Drawing.Point(8, 23);
			this.radioAdboard1.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioAdboard1.Name = "radioAdboard1";
			this.radioAdboard1.Size = new global::System.Drawing.Size(77, 21);
			this.radioAdboard1.TabIndex = 9;
			this.radioAdboard1.TabStop = true;
			this.radioAdboard1.Text = "Texture";
			this.radioAdboard1.UseVisualStyleBackColor = true;
			this.radioAdboard1.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupKit.Controls.Add(this.radioKitKit);
			this.groupKit.Controls.Add(this.radioKitMinikit);
			this.groupKit.Location = new global::System.Drawing.Point(7, 6);
			this.groupKit.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupKit.Name = "groupKit";
			this.groupKit.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupKit.Size = new global::System.Drawing.Size(320, 111);
			this.groupKit.TabIndex = 51;
			this.groupKit.TabStop = false;
			this.groupKit.Text = "Kit";
			this.groupKit.Visible = false;
			this.radioKitKit.AutoSize = true;
			this.radioKitKit.Checked = true;
			this.radioKitKit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioKitKit.Location = new global::System.Drawing.Point(8, 27);
			this.radioKitKit.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioKitKit.Name = "radioKitKit";
			this.radioKitKit.Size = new global::System.Drawing.Size(104, 21);
			this.radioKitKit.TabIndex = 4;
			this.radioKitKit.TabStop = true;
			this.radioKitKit.Text = "Kit Textures";
			this.radioKitKit.UseVisualStyleBackColor = false;
			this.radioKitKit.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioKitMinikit.AutoSize = true;
			this.radioKitMinikit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioKitMinikit.Location = new global::System.Drawing.Point(8, 55);
			this.radioKitMinikit.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioKitMinikit.Name = "radioKitMinikit";
			this.radioKitMinikit.Size = new global::System.Drawing.Size(68, 21);
			this.radioKitMinikit.TabIndex = 2;
			this.radioKitMinikit.TabStop = true;
			this.radioKitMinikit.Text = "Minikit";
			this.radioKitMinikit.UseVisualStyleBackColor = true;
			this.radioKitMinikit.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.groupPlayer.Controls.Add(this.radioHairTextures);
			this.groupPlayer.Controls.Add(this.radioHairColorTexture);
			this.groupPlayer.Controls.Add(this.radioEyesTexture);
			this.groupPlayer.Controls.Add(this.radioFaceTexture);
			this.groupPlayer.Controls.Add(this.radioMiniHead);
			this.groupPlayer.Location = new global::System.Drawing.Point(7, 6);
			this.groupPlayer.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupPlayer.Name = "groupPlayer";
			this.groupPlayer.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupPlayer.Size = new global::System.Drawing.Size(320, 111);
			this.groupPlayer.TabIndex = 50;
			this.groupPlayer.TabStop = false;
			this.groupPlayer.Text = "Player";
			this.groupPlayer.Visible = false;
			this.radioHairTextures.AutoSize = true;
			this.radioHairTextures.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioHairTextures.Location = new global::System.Drawing.Point(155, 54);
			this.radioHairTextures.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioHairTextures.Name = "radioHairTextures";
			this.radioHairTextures.Size = new global::System.Drawing.Size(107, 21);
			this.radioHairTextures.TabIndex = 52;
			this.radioHairTextures.TabStop = true;
			this.radioHairTextures.Text = "Hair Texture";
			this.radioHairTextures.UseVisualStyleBackColor = true;
			this.radioHairTextures.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioHairColorTexture.AutoSize = true;
			this.radioHairColorTexture.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioHairColorTexture.Location = new global::System.Drawing.Point(155, 30);
			this.radioHairColorTexture.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioHairColorTexture.Name = "radioHairColorTexture";
			this.radioHairColorTexture.Size = new global::System.Drawing.Size(144, 21);
			this.radioHairColorTexture.TabIndex = 51;
			this.radioHairColorTexture.TabStop = true;
			this.radioHairColorTexture.Text = "Hair Color Texture";
			this.radioHairColorTexture.UseVisualStyleBackColor = true;
			this.radioHairColorTexture.Visible = false;
			this.radioHairColorTexture.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioEyesTexture.AutoSize = true;
			this.radioEyesTexture.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioEyesTexture.Location = new global::System.Drawing.Point(16, 76);
			this.radioEyesTexture.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioEyesTexture.Name = "radioEyesTexture";
			this.radioEyesTexture.Size = new global::System.Drawing.Size(112, 21);
			this.radioEyesTexture.TabIndex = 2;
			this.radioEyesTexture.TabStop = true;
			this.radioEyesTexture.Text = "Eyes Texture";
			this.radioEyesTexture.UseVisualStyleBackColor = true;
			this.radioEyesTexture.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioFaceTexture.AutoSize = true;
			this.radioFaceTexture.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioFaceTexture.Location = new global::System.Drawing.Point(16, 52);
			this.radioFaceTexture.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioFaceTexture.Name = "radioFaceTexture";
			this.radioFaceTexture.Size = new global::System.Drawing.Size(112, 21);
			this.radioFaceTexture.TabIndex = 1;
			this.radioFaceTexture.TabStop = true;
			this.radioFaceTexture.Text = "Face Texture";
			this.radioFaceTexture.UseVisualStyleBackColor = true;
			this.radioFaceTexture.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.radioMiniHead.AutoSize = true;
			this.radioMiniHead.Checked = true;
			this.radioMiniHead.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioMiniHead.Location = new global::System.Drawing.Point(16, 25);
			this.radioMiniHead.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioMiniHead.Name = "radioMiniHead";
			this.radioMiniHead.Size = new global::System.Drawing.Size(92, 21);
			this.radioMiniHead.TabIndex = 0;
			this.radioMiniHead.TabStop = true;
			this.radioMiniHead.Text = "Mini Head";
			this.radioMiniHead.UseVisualStyleBackColor = true;
			this.radioMiniHead.CheckedChanged += new global::System.EventHandler(this.radioViewer_CheckedChanged);
			this.pictureBox1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox1.Location = new global::System.Drawing.Point(-356, 242);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(356, 290);
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.groupReplaceSelection.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupReplaceSelection.Controls.Add(this.comboReplaceLicensedTournament);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceKit);
			this.groupReplaceSelection.Controls.Add(this.labelCmsCreated);
			this.groupReplaceSelection.Controls.Add(this.labelCmsReplaced);
			this.groupReplaceSelection.Controls.Add(this.textCmsReplaced);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceMowingPattern);
			this.groupReplaceSelection.Controls.Add(this.radioCmsItem);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceGkGloves);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceNet);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceShoes);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceNamesFont);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceNumberFont);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceAdboard);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceBall);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceReferee);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceSponsor);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceFormation);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceTournament);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceStadium);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceCountry);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceLeague);
			this.groupReplaceSelection.Controls.Add(this.comboReplacePlayer);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceTeam);
			this.groupReplaceSelection.Controls.Add(this.radioReplaceItem);
			this.groupReplaceSelection.Controls.Add(this.radioCreateItem);
			this.groupReplaceSelection.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupReplaceSelection.Location = new global::System.Drawing.Point(0, 18);
			this.groupReplaceSelection.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupReplaceSelection.Name = "groupReplaceSelection";
			this.groupReplaceSelection.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupReplaceSelection.Size = new global::System.Drawing.Size(514, 137);
			this.groupReplaceSelection.TabIndex = 37;
			this.groupReplaceSelection.TabStop = false;
			this.groupReplaceSelection.Text = "Replace Selection";
			this.comboReplaceLicensedTournament.FormattingEnabled = true;
			this.comboReplaceLicensedTournament.Location = new global::System.Drawing.Point(109, 48);
			this.comboReplaceLicensedTournament.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceLicensedTournament.MaxDropDownItems = 20;
			this.comboReplaceLicensedTournament.Name = "comboReplaceLicensedTournament";
			this.comboReplaceLicensedTournament.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceLicensedTournament.TabIndex = 42;
			this.comboReplaceLicensedTournament.Visible = false;
			this.comboReplaceLicensedTournament.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceKit.FormattingEnabled = true;
			this.comboReplaceKit.Location = new global::System.Drawing.Point(109, 48);
			this.comboReplaceKit.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceKit.MaxDropDownItems = 20;
			this.comboReplaceKit.Name = "comboReplaceKit";
			this.comboReplaceKit.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceKit.TabIndex = 41;
			this.comboReplaceKit.Visible = false;
			this.comboReplaceKit.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.labelCmsCreated.AutoSize = true;
			this.labelCmsCreated.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCmsCreated.ForeColor = global::System.Drawing.Color.Green;
			this.labelCmsCreated.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCmsCreated.Location = new global::System.Drawing.Point(19, 107);
			this.labelCmsCreated.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCmsCreated.Name = "labelCmsCreated";
			this.labelCmsCreated.Size = new global::System.Drawing.Size(56, 17);
			this.labelCmsCreated.TabIndex = 40;
			this.labelCmsCreated.Text = "Create";
			this.labelCmsCreated.Visible = false;
			this.labelCmsReplaced.AutoSize = true;
			this.labelCmsReplaced.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCmsReplaced.ForeColor = global::System.Drawing.Color.Red;
			this.labelCmsReplaced.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCmsReplaced.Location = new global::System.Drawing.Point(19, 107);
			this.labelCmsReplaced.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCmsReplaced.Name = "labelCmsReplaced";
			this.labelCmsReplaced.Size = new global::System.Drawing.Size(67, 17);
			this.labelCmsReplaced.TabIndex = 22;
			this.labelCmsReplaced.Text = "Replace";
			this.labelCmsReplaced.Visible = false;
			this.textCmsReplaced.BackColor = global::System.Drawing.Color.White;
			this.textCmsReplaced.Location = new global::System.Drawing.Point(108, 103);
			this.textCmsReplaced.Margin = new global::System.Windows.Forms.Padding(4);
			this.textCmsReplaced.Name = "textCmsReplaced";
			this.textCmsReplaced.ReadOnly = true;
			this.textCmsReplaced.Size = new global::System.Drawing.Size(236, 22);
			this.textCmsReplaced.TabIndex = 21;
			this.textCmsReplaced.Visible = false;
			this.comboReplaceMowingPattern.FormattingEnabled = true;
			this.comboReplaceMowingPattern.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceMowingPattern.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceMowingPattern.MaxDropDownItems = 20;
			this.comboReplaceMowingPattern.Name = "comboReplaceMowingPattern";
			this.comboReplaceMowingPattern.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceMowingPattern.TabIndex = 20;
			this.comboReplaceMowingPattern.Visible = false;
			this.comboReplaceMowingPattern.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.radioCmsItem.AutoSize = true;
			this.radioCmsItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCmsItem.Location = new global::System.Drawing.Point(13, 79);
			this.radioCmsItem.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCmsItem.Name = "radioCmsItem";
			this.radioCmsItem.Size = new global::System.Drawing.Size(109, 21);
			this.radioCmsItem.TabIndex = 19;
			this.radioCmsItem.TabStop = true;
			this.radioCmsItem.Text = "Use Patch Id";
			this.radioCmsItem.UseVisualStyleBackColor = true;
			this.radioCmsItem.CheckedChanged += new global::System.EventHandler(this.radioUsePatchItem_CheckedChanged);
			this.comboReplaceGkGloves.FormattingEnabled = true;
			this.comboReplaceGkGloves.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceGkGloves.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceGkGloves.MaxDropDownItems = 20;
			this.comboReplaceGkGloves.Name = "comboReplaceGkGloves";
			this.comboReplaceGkGloves.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceGkGloves.TabIndex = 18;
			this.comboReplaceGkGloves.Visible = false;
			this.comboReplaceGkGloves.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceNet.FormattingEnabled = true;
			this.comboReplaceNet.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceNet.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceNet.MaxDropDownItems = 20;
			this.comboReplaceNet.Name = "comboReplaceNet";
			this.comboReplaceNet.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceNet.TabIndex = 17;
			this.comboReplaceNet.Visible = false;
			this.comboReplaceNet.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceShoes.FormattingEnabled = true;
			this.comboReplaceShoes.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceShoes.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceShoes.MaxDropDownItems = 20;
			this.comboReplaceShoes.Name = "comboReplaceShoes";
			this.comboReplaceShoes.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceShoes.TabIndex = 16;
			this.comboReplaceShoes.Visible = false;
			this.comboReplaceShoes.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceNamesFont.FormattingEnabled = true;
			this.comboReplaceNamesFont.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceNamesFont.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceNamesFont.MaxDropDownItems = 20;
			this.comboReplaceNamesFont.Name = "comboReplaceNamesFont";
			this.comboReplaceNamesFont.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceNamesFont.TabIndex = 15;
			this.comboReplaceNamesFont.Visible = false;
			this.comboReplaceNamesFont.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceNumberFont.FormattingEnabled = true;
			this.comboReplaceNumberFont.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceNumberFont.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceNumberFont.MaxDropDownItems = 20;
			this.comboReplaceNumberFont.Name = "comboReplaceNumberFont";
			this.comboReplaceNumberFont.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceNumberFont.TabIndex = 14;
			this.comboReplaceNumberFont.Visible = false;
			this.comboReplaceNumberFont.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceAdboard.FormattingEnabled = true;
			this.comboReplaceAdboard.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceAdboard.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceAdboard.MaxDropDownItems = 20;
			this.comboReplaceAdboard.Name = "comboReplaceAdboard";
			this.comboReplaceAdboard.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceAdboard.TabIndex = 13;
			this.comboReplaceAdboard.Visible = false;
			this.comboReplaceAdboard.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceBall.FormattingEnabled = true;
			this.comboReplaceBall.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceBall.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceBall.MaxDropDownItems = 20;
			this.comboReplaceBall.Name = "comboReplaceBall";
			this.comboReplaceBall.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceBall.TabIndex = 12;
			this.comboReplaceBall.Visible = false;
			this.comboReplaceBall.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceReferee.FormattingEnabled = true;
			this.comboReplaceReferee.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceReferee.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceReferee.MaxDropDownItems = 20;
			this.comboReplaceReferee.Name = "comboReplaceReferee";
			this.comboReplaceReferee.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceReferee.TabIndex = 11;
			this.comboReplaceReferee.Visible = false;
			this.comboReplaceReferee.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceSponsor.FormattingEnabled = true;
			this.comboReplaceSponsor.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceSponsor.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceSponsor.MaxDropDownItems = 20;
			this.comboReplaceSponsor.Name = "comboReplaceSponsor";
			this.comboReplaceSponsor.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceSponsor.TabIndex = 10;
			this.comboReplaceSponsor.Visible = false;
			this.comboReplaceSponsor.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceFormation.FormattingEnabled = true;
			this.comboReplaceFormation.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceFormation.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceFormation.MaxDropDownItems = 20;
			this.comboReplaceFormation.Name = "comboReplaceFormation";
			this.comboReplaceFormation.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceFormation.TabIndex = 9;
			this.comboReplaceFormation.Visible = false;
			this.comboReplaceFormation.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceTournament.FormattingEnabled = true;
			this.comboReplaceTournament.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceTournament.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceTournament.MaxDropDownItems = 20;
			this.comboReplaceTournament.Name = "comboReplaceTournament";
			this.comboReplaceTournament.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceTournament.TabIndex = 8;
			this.comboReplaceTournament.Visible = false;
			this.comboReplaceTournament.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceStadium.FormattingEnabled = true;
			this.comboReplaceStadium.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceStadium.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceStadium.MaxDropDownItems = 20;
			this.comboReplaceStadium.Name = "comboReplaceStadium";
			this.comboReplaceStadium.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceStadium.TabIndex = 7;
			this.comboReplaceStadium.Visible = false;
			this.comboReplaceStadium.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceCountry.FormattingEnabled = true;
			this.comboReplaceCountry.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceCountry.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceCountry.MaxDropDownItems = 20;
			this.comboReplaceCountry.Name = "comboReplaceCountry";
			this.comboReplaceCountry.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceCountry.TabIndex = 6;
			this.comboReplaceCountry.Visible = false;
			this.comboReplaceCountry.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceLeague.FormattingEnabled = true;
			this.comboReplaceLeague.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceLeague.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceLeague.Name = "comboReplaceLeague";
			this.comboReplaceLeague.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceLeague.TabIndex = 5;
			this.comboReplaceLeague.Visible = false;
			this.comboReplaceLeague.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplacePlayer.FormattingEnabled = true;
			this.comboReplacePlayer.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplacePlayer.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplacePlayer.MaxDropDownItems = 20;
			this.comboReplacePlayer.Name = "comboReplacePlayer";
			this.comboReplacePlayer.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplacePlayer.TabIndex = 4;
			this.comboReplacePlayer.Visible = false;
			this.comboReplacePlayer.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceTeam.FormattingEnabled = true;
			this.comboReplaceTeam.Location = new global::System.Drawing.Point(108, 48);
			this.comboReplaceTeam.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboReplaceTeam.MaxDropDownItems = 20;
			this.comboReplaceTeam.Name = "comboReplaceTeam";
			this.comboReplaceTeam.Size = new global::System.Drawing.Size(236, 24);
			this.comboReplaceTeam.TabIndex = 3;
			this.comboReplaceTeam.Visible = false;
			this.comboReplaceTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.radioReplaceItem.AutoSize = true;
			this.radioReplaceItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioReplaceItem.Location = new global::System.Drawing.Point(13, 48);
			this.radioReplaceItem.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioReplaceItem.Name = "radioReplaceItem";
			this.radioReplaceItem.Size = new global::System.Drawing.Size(81, 21);
			this.radioReplaceItem.TabIndex = 1;
			this.radioReplaceItem.TabStop = true;
			this.radioReplaceItem.Text = "Replace";
			this.radioReplaceItem.UseVisualStyleBackColor = true;
			this.radioReplaceItem.CheckedChanged += new global::System.EventHandler(this.radioReplaceItem_CheckedChanged);
			this.radioCreateItem.AutoSize = true;
			this.radioCreateItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCreateItem.Location = new global::System.Drawing.Point(13, 20);
			this.radioCreateItem.Margin = new global::System.Windows.Forms.Padding(4);
			this.radioCreateItem.Name = "radioCreateItem";
			this.radioCreateItem.Size = new global::System.Drawing.Size(71, 21);
			this.radioCreateItem.TabIndex = 0;
			this.radioCreateItem.TabStop = true;
			this.radioCreateItem.Text = "Create";
			this.radioCreateItem.UseVisualStyleBackColor = true;
			this.radioCreateItem.CheckedChanged += new global::System.EventHandler(this.radioCreateItem_CheckedChanged);
			this.labelDetails.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelDetails.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDetails.Location = new global::System.Drawing.Point(0, 0);
			this.labelDetails.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDetails.Name = "labelDetails";
			this.labelDetails.Size = new global::System.Drawing.Size(514, 18);
			this.labelDetails.TabIndex = 41;
			this.labelDetails.Text = "Details";
			this.labelDetails.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1543, 918);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.panelLeft);
			base.Controls.Add(this.toolMain);
			base.Controls.Add(this.mainMenu);
			base.Controls.Add(this.statusBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.mainMenu;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "PatchLoaderForm";
			this.Text = " CM-Patch Loader";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PatchLoaderForm_FormClosing);
			base.Load += new global::System.EventHandler(this.PatchLoaderForm_Load);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.toolMain.ResumeLayout(false);
			this.toolMain.PerformLayout();
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			this.groupPatchOptions.ResumeLayout(false);
			this.tabPatchOptions.ResumeLayout(false);
			this.pagePlayerOptions.ResumeLayout(false);
			this.pagePlayerOptions.PerformLayout();
			this.groupDualClub.ResumeLayout(false);
			this.groupDualClub.PerformLayout();
			this.pageTeamOptions.ResumeLayout(false);
			this.pageTeamOptions.PerformLayout();
			this.pageLeagueOptions.ResumeLayout(false);
			this.pageLeagueOptions.PerformLayout();
			this.pageStadiumOptions.ResumeLayout(false);
			this.pageStadiumOptions.PerformLayout();
			this.pageKitOptions.ResumeLayout(false);
			this.pageKitOptions.PerformLayout();
			this.pageCountryOptions.ResumeLayout(false);
			this.pageCountryOptions.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.tabPreview.ResumeLayout(false);
			this.pageViewer2D.ResumeLayout(false);
			this.pageMultiViewer2D.ResumeLayout(false);
			this.panelGraphicGroups.ResumeLayout(false);
			this.groupTeam.ResumeLayout(false);
			this.groupTeam.PerformLayout();
			this.groupLeague.ResumeLayout(false);
			this.groupLeague.PerformLayout();
			this.groupStadium.ResumeLayout(false);
			this.groupStadium.PerformLayout();
			this.groupTod.ResumeLayout(false);
			this.groupTod.PerformLayout();
			this.groupShoes.ResumeLayout(false);
			this.groupShoes.PerformLayout();
			this.groupBall.ResumeLayout(false);
			this.groupBall.PerformLayout();
			this.groupCountry.ResumeLayout(false);
			this.groupCountry.PerformLayout();
			this.groupAdboards.ResumeLayout(false);
			this.groupAdboards.PerformLayout();
			this.groupKit.ResumeLayout(false);
			this.groupKit.PerformLayout();
			this.groupPlayer.ResumeLayout(false);
			this.groupPlayer.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupReplaceSelection.ResumeLayout(false);
			this.groupReplaceSelection.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000246 RID: 582
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000247 RID: 583
		private global::System.Windows.Forms.MenuStrip mainMenu;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.ToolStrip toolMain;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.ToolStripButton buttonLoadPatch;

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.ToolStripButton buttonImportPatch;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.ToolStripButton buttonExitCreator;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.ToolStripButton buttonSelectAllObjects;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.ToolStripButton buttonDeselectAllObjects;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.ToolStripButton stripButtonPreview;

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.ToolStripMenuItem patchToolStripMenuItem;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.Panel panelLeft;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.GroupBox groupPatchOptions;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.TabControl tabPatchOptions;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.TabPage pagePlayerOptions;

		// Token: 0x0400025A RID: 602
		public global::System.Windows.Forms.CheckBox checkPlayerMiniface;

		// Token: 0x0400025B RID: 603
		public global::System.Windows.Forms.CheckBox checkPlayerHead;

		// Token: 0x0400025C RID: 604
		public global::System.Windows.Forms.CheckBox checkPlayerDatabase;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.TabPage pageTeamOptions;

		// Token: 0x0400025E RID: 606
		public global::System.Windows.Forms.CheckBox checkTeamFlags;

		// Token: 0x0400025F RID: 607
		public global::System.Windows.Forms.CheckBox checkTeamBanner;

		// Token: 0x04000260 RID: 608
		public global::System.Windows.Forms.CheckBox checkTeamLogo;

		// Token: 0x04000261 RID: 609
		public global::System.Windows.Forms.CheckBox checkTeamDatabase;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Forms.TabPage pageLeagueOptions;

		// Token: 0x04000263 RID: 611
		public global::System.Windows.Forms.CheckBox checkLeagueLogo;

		// Token: 0x04000264 RID: 612
		public global::System.Windows.Forms.CheckBox checkLeagueDatabase;

		// Token: 0x04000265 RID: 613
		private global::System.Windows.Forms.TabPage pageCountryOptions;

		// Token: 0x04000266 RID: 614
		public global::System.Windows.Forms.CheckBox checkCountryDatabase;

		// Token: 0x04000267 RID: 615
		public global::System.Windows.Forms.CheckBox checkCountryFlag;

		// Token: 0x04000268 RID: 616
		private global::System.Windows.Forms.TabPage pageStadiumOptions;

		// Token: 0x04000269 RID: 617
		public global::System.Windows.Forms.CheckBox checkStadiumModel;

		// Token: 0x0400026A RID: 618
		public global::System.Windows.Forms.CheckBox checkStadiumPreview;

		// Token: 0x0400026B RID: 619
		public global::System.Windows.Forms.CheckBox checkStadiumDatabase;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.TabPage pageKitOptions;

		// Token: 0x0400026D RID: 621
		public global::System.Windows.Forms.CheckBox checkKitDatabase;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.TextBox textDescription;

		// Token: 0x0400026F RID: 623
		private global::System.Windows.Forms.Label labelDescription;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.TextBox textPatchVersion;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.Label labelPatchVersion;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.TextBox textPatchName;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.Label labelPatchName;

		// Token: 0x04000274 RID: 628
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000275 RID: 629
		private global::System.Windows.Forms.StatusStrip statusBar;

		// Token: 0x04000276 RID: 630
		private global::System.Windows.Forms.ToolStripStatusLabel statusLabel;

		// Token: 0x04000277 RID: 631
		private global::System.Windows.Forms.ListView listViewPatch;

		// Token: 0x04000278 RID: 632
		private global::System.Windows.Forms.ColumnHeader columnItem;

		// Token: 0x04000279 RID: 633
		private global::System.Windows.Forms.ColumnHeader columnType;

		// Token: 0x0400027A RID: 634
		private global::System.Windows.Forms.ColumnHeader columnPatchId;

		// Token: 0x0400027B RID: 635
		private global::System.Windows.Forms.ColumnHeader columnComment;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Forms.Panel panelRight;

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Forms.TabControl tabPreview;

		// Token: 0x0400027E RID: 638
		private global::System.Windows.Forms.TabPage pageViewer2D;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.Panel panelGraphicGroups;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.GroupBox groupBall;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.Forms.RadioButton radioBallPreview;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.RadioButton radioBallTexture;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.GroupBox groupCountry;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.RadioButton radioCountryMainFlag;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.RadioButton radioCountryMiniflag;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.GroupBox groupPlayer;

		// Token: 0x04000287 RID: 647
		private global::System.Windows.Forms.RadioButton radioFaceTexture;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.RadioButton radioMiniHead;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.GroupBox groupLeague;

		// Token: 0x0400028A RID: 650
		private global::System.Windows.Forms.GroupBox groupTeam;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.RadioButton radioTeamFlags;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.RadioButton radioTeamBanners;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.GroupBox groupStadium;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.RadioButton radioStadiumGuiSunset;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.RadioButton radioStadiumGuiOvercast;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.RadioButton radioStadiumGuiClearDay;

		// Token: 0x04000291 RID: 657
		private global::System.Windows.Forms.RadioButton radioStadium3D;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.RadioButton radioStadiumGuiNight;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.GroupBox groupAdboards;

		// Token: 0x04000294 RID: 660
		private global::System.Windows.Forms.RadioButton radioAdboard1;

		// Token: 0x04000295 RID: 661
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.GroupBox groupReplaceSelection;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.ComboBox comboReplaceKit;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Label labelCmsCreated;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.Label labelCmsReplaced;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.TextBox textCmsReplaced;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.ComboBox comboReplaceMowingPattern;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.RadioButton radioCmsItem;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.ComboBox comboReplaceGkGloves;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.ComboBox comboReplaceNet;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.ComboBox comboReplaceShoes;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.ComboBox comboReplaceNamesFont;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.ComboBox comboReplaceNumberFont;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.ComboBox comboReplaceAdboard;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.ComboBox comboReplaceBall;

		// Token: 0x040002A4 RID: 676
		private global::System.Windows.Forms.ComboBox comboReplaceReferee;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.ComboBox comboReplaceSponsor;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Forms.ComboBox comboReplaceFormation;

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Forms.ComboBox comboReplaceTournament;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.ComboBox comboReplaceStadium;

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Forms.ComboBox comboReplaceCountry;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.ComboBox comboReplaceLeague;

		// Token: 0x040002AB RID: 683
		private global::System.Windows.Forms.ComboBox comboReplacePlayer;

		// Token: 0x040002AC RID: 684
		private global::System.Windows.Forms.ComboBox comboReplaceTeam;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Forms.RadioButton radioReplaceItem;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.RadioButton radioCreateItem;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.Label labelDetails;

		// Token: 0x040002B0 RID: 688
		private global::System.Windows.Forms.TabPage pageMultiViewer2D;

		// Token: 0x040002B1 RID: 689
		public global::System.Windows.Forms.CheckBox checkMinikits;

		// Token: 0x040002B2 RID: 690
		public global::System.Windows.Forms.CheckBox checkKits;

		// Token: 0x040002B3 RID: 691
		private global::FifaControls.Viewer2D viewer2D;

		// Token: 0x040002B4 RID: 692
		private global::FifaControls.MultiViewer2D multiViewer2D;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.RadioButton radioEyesTexture;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.RadioButton radioHairTextures;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.RadioButton radioHairColorTexture;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.GroupBox groupKit;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.RadioButton radioKitKit;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.RadioButton radioKitMinikit;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.GroupBox groupShoes;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.RadioButton radioShoesColor;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.RadioButton radioStadiumPreview;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.GroupBox groupTod;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.ColumnHeader columnImportId;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.ComboBox comboReplaceLicensedTournament;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.RadioButton radioCountryCard;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.RadioButton radioLeagueTinyLogo;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.RadioButton radioLeagueSmallLogo;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.RadioButton radioLeagueAnimLogo;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.RadioButton radioTeamCrest16;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.RadioButton radioTeamCrest32;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.RadioButton radioTeamCrestLarge;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.RadioButton radioLeagueLogo512x128;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.RadioButton radioCountryFlag512x512;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.RadioButton radioCountryMap;

		// Token: 0x040002CB RID: 715
		public global::System.Windows.Forms.CheckBox checkCountryMap;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.RadioButton radioTeamCrest50;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.GroupBox groupDualClub;

		// Token: 0x040002CE RID: 718
		public global::System.Windows.Forms.RadioButton radioPutInBothTeams;

		// Token: 0x040002CF RID: 719
		public global::System.Windows.Forms.RadioButton radioTransferToNewTeam;

		// Token: 0x040002D0 RID: 720
		public global::System.Windows.Forms.RadioButton radioLeaveInExistingTeam;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.ToolStripButton buttonSelectNewObjects;
	}
}
