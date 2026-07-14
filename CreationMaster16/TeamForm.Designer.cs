namespace CreationMaster
{
	// Token: 0x0200001C RID: 28
	public partial class TeamForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x0006D6C7 File Offset: 0x0006B8C7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0006D6E8 File Offset: 0x0006B8E8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.TeamForm));
			this.tableEditTeam = new global::System.Windows.Forms.TabControl();
			this.pageTeamGeneric = new global::System.Windows.Forms.TabPage();
			this.flowPanelTeamGeneric = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.viewer2DCrest50 = new global::FifaControls.Viewer2D();
			this.buttonReplicateLogo = new global::System.Windows.Forms.Button();
			this.viewer2DCrestLarge = new global::FifaControls.Viewer2D();
			this.viewer2DCrest16 = new global::FifaControls.Viewer2D();
			this.viewer2DCrest32 = new global::FifaControls.Viewer2D();
			this.groupBoxName = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textTeamName7 = new global::System.Windows.Forms.TextBox();
			this.teamBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.textScoreBoardName = new global::System.Windows.Forms.TextBox();
			this.textDatabaseTeamName = new global::System.Windows.Forms.TextBox();
			this.textFullTeamName = new global::System.Windows.Forms.TextBox();
			this.textStandardTeamName = new global::System.Windows.Forms.TextBox();
			this.textShortTeamName = new global::System.Windows.Forms.TextBox();
			this.labelDatabaseTeamName = new global::System.Windows.Forms.Label();
			this.labelFullTeamName = new global::System.Windows.Forms.Label();
			this.labelStandardTeamName = new global::System.Windows.Forms.Label();
			this.labelShortTeamName = new global::System.Windows.Forms.Label();
			this.labelScoreBoardName = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.textStadiumName = new global::System.Windows.Forms.TextBox();
			this.labelStadiumName = new global::System.Windows.Forms.Label();
			this.comboStadiums = new global::System.Windows.Forms.ComboBox();
			this.stadiumListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelStadium = new global::System.Windows.Forms.Label();
			this.groupManager = new global::System.Windows.Forms.GroupBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.checkIsNationalTeam = new global::System.Windows.Forms.CheckBox();
			this.labelProbObjective = new global::System.Windows.Forms.Label();
			this.labelMaxObjective = new global::System.Windows.Forms.Label();
			this.comboProbObjective = new global::System.Windows.Forms.ComboBox();
			this.comboMaxOnjective = new global::System.Windows.Forms.ComboBox();
			this.comboObjective = new global::System.Windows.Forms.ComboBox();
			this.labelObjective = new global::System.Windows.Forms.Label();
			this.comboTeamLeague = new global::System.Windows.Forms.ComboBox();
			this.leagueListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelLeague = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.pictureTeamTerColor = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboRivalTeam = new global::System.Windows.Forms.ComboBox();
			this.pictureTeamPrimColor = new global::System.Windows.Forms.PictureBox();
			this.pictureTeamSecColor = new global::System.Windows.Forms.PictureBox();
			this.numericTeamId = new global::System.Windows.Forms.NumericUpDown();
			this.numericBall = new global::System.Windows.Forms.NumericUpDown();
			this.labelTeamId = new global::System.Windows.Forms.Label();
			this.pictureBall = new global::System.Windows.Forms.PictureBox();
			this.comboTeamCountry = new global::System.Windows.Forms.ComboBox();
			this.countryListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.numericStarsInternationalPrestige = new global::FifaControls.NumericStars();
			this.labelTeamCountry = new global::System.Windows.Forms.Label();
			this.labelOpponent = new global::System.Windows.Forms.Label();
			this.labelDomesticPrestige = new global::System.Windows.Forms.Label();
			this.numericStarsDomesticPrestige = new global::FifaControls.NumericStars();
			this.labelInitialBudget = new global::System.Windows.Forms.Label();
			this.labelInternationalPrestige = new global::System.Windows.Forms.Label();
			this.numericInitialBudget = new global::System.Windows.Forms.NumericUpDown();
			this.groupLastYear = new global::System.Windows.Forms.GroupBox();
			this.comboPrevLeague = new global::System.Windows.Forms.ComboBox();
			this.numericPositionLastYear = new global::System.Windows.Forms.NumericUpDown();
			this.checkIsChampion = new global::System.Windows.Forms.CheckBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.groupLocation = new global::System.Windows.Forms.GroupBox();
			this.numericUtcOffset = new global::System.Windows.Forms.NumericUpDown();
			this.numericLongitude = new global::System.Windows.Forms.NumericUpDown();
			this.numericLatitude = new global::System.Windows.Forms.NumericUpDown();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.label23 = new global::System.Windows.Forms.Label();
			this.groupTeamTraits = new global::System.Windows.Forms.GroupBox();
			this.checkShortOutBack = new global::System.Windows.Forms.CheckBox();
			this.checkMoreAttackingAtHome = new global::System.Windows.Forms.CheckBox();
			this.checkCenterBacksSplit = new global::System.Windows.Forms.CheckBox();
			this.checkSwitchWingers = new global::System.Windows.Forms.CheckBox();
			this.checkKeepUpPressure = new global::System.Windows.Forms.CheckBox();
			this.checkDefendLead = new global::System.Windows.Forms.CheckBox();
			this.checkConsistentLineup = new global::System.Windows.Forms.CheckBox();
			this.checkSquadRotation = new global::System.Windows.Forms.CheckBox();
			this.checkLoyalBoard = new global::System.Windows.Forms.CheckBox();
			this.checkImpatientBoard = new global::System.Windows.Forms.CheckBox();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.labelThirdKit = new global::System.Windows.Forms.Label();
			this.labelKeeprKit = new global::System.Windows.Forms.Label();
			this.labelAwayKit = new global::System.Windows.Forms.Label();
			this.labelHomeKit = new global::System.Windows.Forms.Label();
			this.pageTeamRoster = new global::System.Windows.Forms.TabPage();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.labelCcpositioning = new global::System.Windows.Forms.Label();
			this.labelCcpassing = new global::System.Windows.Forms.Label();
			this.labelCccrossing = new global::System.Windows.Forms.Label();
			this.labelCcshooting = new global::System.Windows.Forms.Label();
			this.numericCcpassing = new global::System.Windows.Forms.NumericUpDown();
			this.numericCccrossing = new global::System.Windows.Forms.NumericUpDown();
			this.numericCcshooting = new global::System.Windows.Forms.NumericUpDown();
			this.comboCCPositioning = new global::System.Windows.Forms.ComboBox();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.labelBuspositioning = new global::System.Windows.Forms.Label();
			this.labelBusbuildupspeed = new global::System.Windows.Forms.Label();
			this.labelBuspassing = new global::System.Windows.Forms.Label();
			this.numericBusbuildupspeed = new global::System.Windows.Forms.NumericUpDown();
			this.numericBuspassing = new global::System.Windows.Forms.NumericUpDown();
			this.comboBUSPositioning = new global::System.Windows.Forms.ComboBox();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.label20 = new global::System.Windows.Forms.Label();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.labelDefdefendeline = new global::System.Windows.Forms.Label();
			this.labelDefmentality = new global::System.Windows.Forms.Label();
			this.labelDefaggression = new global::System.Windows.Forms.Label();
			this.labelDefteamwidth = new global::System.Windows.Forms.Label();
			this.numericDefmentality = new global::System.Windows.Forms.NumericUpDown();
			this.numericDefaggression = new global::System.Windows.Forms.NumericUpDown();
			this.numericDefteamwidth = new global::System.Windows.Forms.NumericUpDown();
			this.comboDEFLine = new global::System.Windows.Forms.ComboBox();
			this.labelRightFreeKickText = new global::System.Windows.Forms.Label();
			this.labelRightFreeKick = new global::System.Windows.Forms.Label();
			this.labelLeftFreeKickText = new global::System.Windows.Forms.Label();
			this.labelLeftFreeKick = new global::System.Windows.Forms.Label();
			this.groupFormation = new global::System.Windows.Forms.GroupBox();
			this.labelTeamFormationName = new global::System.Windows.Forms.Label();
			this.comboGenericFormations = new global::System.Windows.Forms.ComboBox();
			this.radioUseSpecificFormation = new global::System.Windows.Forms.RadioButton();
			this.radioUseGenericFormation = new global::System.Windows.Forms.RadioButton();
			this.labelLongKick = new global::System.Windows.Forms.Label();
			this.labelLomgKickText = new global::System.Windows.Forms.Label();
			this.labelRightCornerText = new global::System.Windows.Forms.Label();
			this.labelCaptainTetx = new global::System.Windows.Forms.Label();
			this.labelLeftCornertext = new global::System.Windows.Forms.Label();
			this.labelRightCorner = new global::System.Windows.Forms.Label();
			this.labelCaptain = new global::System.Windows.Forms.Label();
			this.labelLeftCorner = new global::System.Windows.Forms.Label();
			this.labelFreeKickText = new global::System.Windows.Forms.Label();
			this.labelPenaltyText = new global::System.Windows.Forms.Label();
			this.labelPenalty = new global::System.Windows.Forms.Label();
			this.labelFreeKick = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.labelPos33U = new global::System.Windows.Forms.Label();
			this.labelPos33T = new global::System.Windows.Forms.Label();
			this.labelPos33S = new global::System.Windows.Forms.Label();
			this.labelPos33R = new global::System.Windows.Forms.Label();
			this.labelPos33Q = new global::System.Windows.Forms.Label();
			this.labelPos33O = new global::System.Windows.Forms.Label();
			this.labelPos33P = new global::System.Windows.Forms.Label();
			this.labelPos33N = new global::System.Windows.Forms.Label();
			this.labelPos33M = new global::System.Windows.Forms.Label();
			this.labelPos33L = new global::System.Windows.Forms.Label();
			this.labelPos33K = new global::System.Windows.Forms.Label();
			this.labelPos33J = new global::System.Windows.Forms.Label();
			this.labelPos33H = new global::System.Windows.Forms.Label();
			this.labelPos33I = new global::System.Windows.Forms.Label();
			this.labelPos33G = new global::System.Windows.Forms.Label();
			this.labelPos33F = new global::System.Windows.Forms.Label();
			this.labelPos33E = new global::System.Windows.Forms.Label();
			this.labelPos33D = new global::System.Windows.Forms.Label();
			this.labelPos33C = new global::System.Windows.Forms.Label();
			this.labelPos33A = new global::System.Windows.Forms.Label();
			this.labelPos33B = new global::System.Windows.Forms.Label();
			this.labelPos32G = new global::System.Windows.Forms.Label();
			this.labelPos32F = new global::System.Windows.Forms.Label();
			this.labelPos32E = new global::System.Windows.Forms.Label();
			this.labelPos32D = new global::System.Windows.Forms.Label();
			this.labelPos32C = new global::System.Windows.Forms.Label();
			this.labelPos32A = new global::System.Windows.Forms.Label();
			this.labelPos32B = new global::System.Windows.Forms.Label();
			this.labelPos26 = new global::System.Windows.Forms.Label();
			this.labelPos27 = new global::System.Windows.Forms.Label();
			this.labelPos21 = new global::System.Windows.Forms.Label();
			this.labelPos22 = new global::System.Windows.Forms.Label();
			this.labelPos23 = new global::System.Windows.Forms.Label();
			this.labelPos24 = new global::System.Windows.Forms.Label();
			this.labelPos25 = new global::System.Windows.Forms.Label();
			this.labelPos14 = new global::System.Windows.Forms.Label();
			this.labelPos15 = new global::System.Windows.Forms.Label();
			this.labelPos16 = new global::System.Windows.Forms.Label();
			this.labelPos17 = new global::System.Windows.Forms.Label();
			this.labelPos18 = new global::System.Windows.Forms.Label();
			this.labelPos20 = new global::System.Windows.Forms.Label();
			this.labelPos19 = new global::System.Windows.Forms.Label();
			this.labelPos9 = new global::System.Windows.Forms.Label();
			this.labelPos10 = new global::System.Windows.Forms.Label();
			this.labelPos11 = new global::System.Windows.Forms.Label();
			this.labelPos12 = new global::System.Windows.Forms.Label();
			this.labelPos13 = new global::System.Windows.Forms.Label();
			this.labelPos2 = new global::System.Windows.Forms.Label();
			this.labelPos3 = new global::System.Windows.Forms.Label();
			this.labelPos4 = new global::System.Windows.Forms.Label();
			this.labelPos5 = new global::System.Windows.Forms.Label();
			this.labelPos6 = new global::System.Windows.Forms.Label();
			this.labelPos8 = new global::System.Windows.Forms.Label();
			this.labelPos7 = new global::System.Windows.Forms.Label();
			this.labelPos0 = new global::System.Windows.Forms.Label();
			this.labelPos1 = new global::System.Windows.Forms.Label();
			this.groupAvailablePlayers = new global::System.Windows.Forms.GroupBox();
			this.listViewPlayersAvailable = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.panelAvailablePlayersTop = new global::System.Windows.Forms.Panel();
			this.buttonDeletePlayer = new global::System.Windows.Forms.Button();
			this.buttonLoanFrom = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.dateTransferPreset = new global::System.Windows.Forms.DateTimePicker();
			this.buttonTransferFrom = new global::System.Windows.Forms.Button();
			this.pickUpAvailablePlayers = new global::FifaControls.PickUpControl();
			this.buttonCall = new global::System.Windows.Forms.Button();
			this.labelAvailablePlayerStars = new global::System.Windows.Forms.Label();
			this.imageListStars = new global::System.Windows.Forms.ImageList(this.components);
			this.pictureAvailablePlayer = new global::System.Windows.Forms.PictureBox();
			this.groupTeamPlayers = new global::System.Windows.Forms.GroupBox();
			this.listViewTeamPlayers = new global::System.Windows.Forms.ListView();
			this.columnRosterSurname = new global::System.Windows.Forms.ColumnHeader();
			this.columnRosterFirstName = new global::System.Windows.Forms.ColumnHeader();
			this.columnRosterYearContract = new global::System.Windows.Forms.ColumnHeader();
			this.columnPreferredRole = new global::System.Windows.Forms.ColumnHeader();
			this.columnAverageAttributes = new global::System.Windows.Forms.ColumnHeader();
			this.columnRosterNum = new global::System.Windows.Forms.ColumnHeader();
			this.panelTeamPlayersTop = new global::System.Windows.Forms.Panel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.buttonPlusContract = new global::System.Windows.Forms.Button();
			this.buttonMinusContract = new global::System.Windows.Forms.Button();
			this.labelLoanedFrom = new global::System.Windows.Forms.Label();
			this.comboTeamLoanedFrom = new global::System.Windows.Forms.ComboBox();
			this.teamListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.label2 = new global::System.Windows.Forms.Label();
			this.dateLoanEnd = new global::System.Windows.Forms.DateTimePicker();
			this.labelLoanEnd = new global::System.Windows.Forms.Label();
			this.buttonRosterLetFree = new global::System.Windows.Forms.Button();
			this.buttonTransferPlayer = new global::System.Windows.Forms.Button();
			this.checkIsLoan = new global::System.Windows.Forms.CheckBox();
			this.numericRosterYear = new global::System.Windows.Forms.NumericUpDown();
			this.buttonLoanTo = new global::System.Windows.Forms.Button();
			this.dateJoiningDate = new global::System.Windows.Forms.DateTimePicker();
			this.viewer2DPhoto = new global::FifaControls.Viewer2D();
			this.labelJoiningDate = new global::System.Windows.Forms.Label();
			this.groupTeamPlayerTuning = new global::System.Windows.Forms.GroupBox();
			this.buttonTeamPlayerMinus = new global::System.Windows.Forms.Button();
			this.buttonTeamPlayerPlus = new global::System.Windows.Forms.Button();
			this.labelTeamPlayerStars = new global::System.Windows.Forms.Label();
			this.labelRosterName = new global::System.Windows.Forms.Label();
			this.comboRosterNumber = new global::System.Windows.Forms.ComboBox();
			this.labelRosterNumber = new global::System.Windows.Forms.Label();
			this.labelRosterNameFrom = new global::System.Windows.Forms.Label();
			this.labelPreviousTeam = new global::System.Windows.Forms.Label();
			this.comboTeamPrevious = new global::System.Windows.Forms.ComboBox();
			this.pageTeamAdboard = new global::System.Windows.Forms.TabPage();
			this.numericAdboards = new global::System.Windows.Forms.NumericUpDown();
			this.checkHasSpecificAdboard = new global::System.Windows.Forms.CheckBox();
			this.labelAdboard = new global::System.Windows.Forms.Label();
			this.viewer2DAdboards_0 = new global::FifaControls.Viewer2D();
			this.pageTeamFlags = new global::System.Windows.Forms.TabPage();
			this.groupFlag = new global::System.Windows.Forms.GroupBox();
			this.multiViewer2DFlags15 = new global::FifaControls.MultiViewer2D();
			this.buttonCreateFlags = new global::System.Windows.Forms.Button();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.pictureFlagBlue = new global::System.Windows.Forms.PictureBox();
			this.pictureFlagRed = new global::System.Windows.Forms.PictureBox();
			this.pictureFlagGreen = new global::System.Windows.Forms.PictureBox();
			this.checkFlag4 = new global::System.Windows.Forms.CheckBox();
			this.checkFlag3 = new global::System.Windows.Forms.CheckBox();
			this.checkFlag2 = new global::System.Windows.Forms.CheckBox();
			this.checkFlag1 = new global::System.Windows.Forms.CheckBox();
			this.labelFlag4 = new global::System.Windows.Forms.Label();
			this.imageListFlags = new global::System.Windows.Forms.ImageList(this.components);
			this.labelFlag3 = new global::System.Windows.Forms.Label();
			this.labelFlag2 = new global::System.Windows.Forms.Label();
			this.labelFlag1 = new global::System.Windows.Forms.Label();
			this.viewer2DBanners = new global::FifaControls.Viewer2D();
			this.pageTeamrevMod = new global::System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupTeamAdboardsRevMod = new global::System.Windows.Forms.GroupBox();
			this.viewer2DTeamAdboard = new global::FifaControls.Viewer2D();
			this.groupTeamBallRevMod = new global::System.Windows.Forms.GroupBox();
			this.viewer3DTeamBall = new global::FifaControls.Viewer3D();
			this.toolTeamBall3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DBall = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImport3DModelTeamBall = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExport3DModelTeamBall = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonRemove3DModelTeamBall = new global::System.Windows.Forms.ToolStripButton();
			this.multiViewer2DTeamBallTextures = new global::FifaControls.MultiViewer2D();
			this.groupTeamManager = new global::System.Windows.Forms.GroupBox();
			this.viewer3DTeamManager = new global::FifaControls.Viewer3D();
			this.toolTeamManager3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DManager = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImportModel3DTeamManager = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExportModel3DTeamManager = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonDeleteModel3DTeamManager = new global::System.Windows.Forms.ToolStripButton();
			this.viewer2DTeamManager = new global::FifaControls.Viewer2D();
			this.groupTeamScarfRevMod = new global::System.Windows.Forms.GroupBox();
			this.multiViewer2DTeamScarf = new global::FifaControls.MultiViewer2D();
			this.groupTeamGoalNetRevMod = new global::System.Windows.Forms.GroupBox();
			this.viewer2DTeamNet = new global::FifaControls.Viewer2D();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.colorDialog = new global::System.Windows.Forms.ColorDialog();
			this.imageListPlayers = new global::System.Windows.Forms.ImageList(this.components);
			this.imageListArrows = new global::System.Windows.Forms.ImageList(this.components);
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.formationListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.ballListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.prevLeagueListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.tableEditTeam.SuspendLayout();
			this.pageTeamGeneric.SuspendLayout();
			this.flowPanelTeamGeneric.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBoxName.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamBindingSource).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.stadiumListBindingSource).BeginInit();
			this.groupManager.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.leagueListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamTerColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamPrimColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamSecColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBall).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBall).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericInitialBudget).BeginInit();
			this.groupLastYear.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericPositionLastYear).BeginInit();
			this.groupLocation.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUtcOffset).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLongitude).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLatitude).BeginInit();
			this.groupTeamTraits.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.pageTeamRoster.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCcpassing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCccrossing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCcshooting).BeginInit();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBusbuildupspeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBuspassing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefmentality).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefaggression).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefteamwidth).BeginInit();
			this.groupFormation.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupAvailablePlayers.SuspendLayout();
			this.panelAvailablePlayersTop.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureAvailablePlayer).BeginInit();
			this.groupTeamPlayers.SuspendLayout();
			this.panelTeamPlayersTop.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRosterYear).BeginInit();
			this.groupTeamPlayerTuning.SuspendLayout();
			this.pageTeamAdboard.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericAdboards).BeginInit();
			this.pageTeamFlags.SuspendLayout();
			this.groupFlag.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagBlue).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagRed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagGreen).BeginInit();
			this.pageTeamrevMod.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupTeamAdboardsRevMod.SuspendLayout();
			this.groupTeamBallRevMod.SuspendLayout();
			this.toolTeamBall3D.SuspendLayout();
			this.groupTeamManager.SuspendLayout();
			this.toolTeamManager3D.SuspendLayout();
			this.groupTeamScarfRevMod.SuspendLayout();
			this.groupTeamGoalNetRevMod.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.formationListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ballListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.prevLeagueListBindingSource).BeginInit();
			base.SuspendLayout();
			this.tableEditTeam.Controls.Add(this.pageTeamGeneric);
			this.tableEditTeam.Controls.Add(this.pageTeamRoster);
			this.tableEditTeam.Controls.Add(this.pageTeamAdboard);
			this.tableEditTeam.Controls.Add(this.pageTeamFlags);
			this.tableEditTeam.Controls.Add(this.pageTeamrevMod);
			this.tableEditTeam.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableEditTeam.Location = new global::System.Drawing.Point(0, 25);
			this.tableEditTeam.Name = "tableEditTeam";
			this.tableEditTeam.SelectedIndex = 0;
			this.tableEditTeam.Size = new global::System.Drawing.Size(1311, 807);
			this.tableEditTeam.TabIndex = 5;
			this.tableEditTeam.SelectedIndexChanged += new global::System.EventHandler(this.tableEditTeam_SelectedIndexChanged);
			this.pageTeamGeneric.AutoScroll = true;
			this.pageTeamGeneric.Controls.Add(this.flowPanelTeamGeneric);
			this.pageTeamGeneric.Location = new global::System.Drawing.Point(4, 22);
			this.pageTeamGeneric.Name = "pageTeamGeneric";
			this.pageTeamGeneric.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageTeamGeneric.Size = new global::System.Drawing.Size(1303, 781);
			this.pageTeamGeneric.TabIndex = 0;
			this.pageTeamGeneric.Text = "Generic";
			this.pageTeamGeneric.UseVisualStyleBackColor = true;
			this.flowPanelTeamGeneric.AutoScroll = true;
			this.flowPanelTeamGeneric.Controls.Add(this.groupBox2);
			this.flowPanelTeamGeneric.Controls.Add(this.groupBoxName);
			this.flowPanelTeamGeneric.Controls.Add(this.groupBox1);
			this.flowPanelTeamGeneric.Controls.Add(this.groupManager);
			this.flowPanelTeamGeneric.Controls.Add(this.groupBox3);
			this.flowPanelTeamGeneric.Controls.Add(this.groupLastYear);
			this.flowPanelTeamGeneric.Controls.Add(this.groupLocation);
			this.flowPanelTeamGeneric.Controls.Add(this.groupTeamTraits);
			this.flowPanelTeamGeneric.Controls.Add(this.groupBox7);
			this.flowPanelTeamGeneric.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowPanelTeamGeneric.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowPanelTeamGeneric.Location = new global::System.Drawing.Point(3, 3);
			this.flowPanelTeamGeneric.Name = "flowPanelTeamGeneric";
			this.flowPanelTeamGeneric.Size = new global::System.Drawing.Size(1297, 775);
			this.flowPanelTeamGeneric.TabIndex = 0;
			this.groupBox2.Controls.Add(this.viewer2DCrest50);
			this.groupBox2.Controls.Add(this.buttonReplicateLogo);
			this.groupBox2.Controls.Add(this.viewer2DCrestLarge);
			this.groupBox2.Controls.Add(this.viewer2DCrest16);
			this.groupBox2.Controls.Add(this.viewer2DCrest32);
			this.groupBox2.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(270, 445);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Logos";
			this.viewer2DCrest50.AutoTransparency = true;
			this.viewer2DCrest50.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCrest50.ButtonStripVisible = false;
			this.viewer2DCrest50.CurrentBitmap = null;
			this.viewer2DCrest50.ExtendedFormat = false;
			this.viewer2DCrest50.FullSizeButton = false;
			this.viewer2DCrest50.ImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.viewer2DCrest50.ImageSize = new global::System.Drawing.Size(64, 64);
			this.viewer2DCrest50.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCrest50.Location = new global::System.Drawing.Point(7, 306);
			this.viewer2DCrest50.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DCrest50.Name = "viewer2DCrest50";
			this.viewer2DCrest50.RemoveButton = false;
			this.viewer2DCrest50.ShowButton = false;
			this.viewer2DCrest50.ShowButtonChecked = true;
			this.viewer2DCrest50.Size = new global::System.Drawing.Size(64, 89);
			this.viewer2DCrest50.TabIndex = 151;
			this.viewer2DCrest50.TabStop = false;
			this.toolTip.SetToolTip(this.viewer2DCrest50, "Crest 50x50");
			this.buttonReplicateLogo.Location = new global::System.Drawing.Point(78, 403);
			this.buttonReplicateLogo.Name = "buttonReplicateLogo";
			this.buttonReplicateLogo.Size = new global::System.Drawing.Size(117, 25);
			this.buttonReplicateLogo.TabIndex = 150;
			this.buttonReplicateLogo.Text = "Replicate";
			this.buttonReplicateLogo.UseVisualStyleBackColor = true;
			this.buttonReplicateLogo.Click += new global::System.EventHandler(this.buttonReplicateLogo_Click);
			this.viewer2DCrestLarge.AutoTransparency = true;
			this.viewer2DCrestLarge.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCrestLarge.ButtonStripVisible = false;
			this.viewer2DCrestLarge.CurrentBitmap = null;
			this.viewer2DCrestLarge.ExtendedFormat = false;
			this.viewer2DCrestLarge.FullSizeButton = false;
			this.viewer2DCrestLarge.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DCrestLarge.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DCrestLarge.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.Auto256;
			this.viewer2DCrestLarge.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DCrestLarge.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DCrestLarge.Name = "viewer2DCrestLarge";
			this.viewer2DCrestLarge.RemoveButton = false;
			this.viewer2DCrestLarge.ShowButton = false;
			this.viewer2DCrestLarge.ShowButtonChecked = true;
			this.viewer2DCrestLarge.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DCrestLarge.TabIndex = 149;
			this.viewer2DCrestLarge.TabStop = false;
			this.toolTip.SetToolTip(this.viewer2DCrestLarge, "Country Map");
			this.viewer2DCrest16.AutoTransparency = true;
			this.viewer2DCrest16.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCrest16.ButtonStripVisible = false;
			this.viewer2DCrest16.CurrentBitmap = null;
			this.viewer2DCrest16.ExtendedFormat = false;
			this.viewer2DCrest16.FullSizeButton = false;
			this.viewer2DCrest16.ImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.viewer2DCrest16.ImageSize = new global::System.Drawing.Size(16, 16);
			this.viewer2DCrest16.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCrest16.Location = new global::System.Drawing.Point(194, 306);
			this.viewer2DCrest16.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DCrest16.Name = "viewer2DCrest16";
			this.viewer2DCrest16.RemoveButton = false;
			this.viewer2DCrest16.ShowButton = false;
			this.viewer2DCrest16.ShowButtonChecked = true;
			this.viewer2DCrest16.Size = new global::System.Drawing.Size(64, 89);
			this.viewer2DCrest16.TabIndex = 148;
			this.viewer2DCrest16.TabStop = false;
			this.toolTip.SetToolTip(this.viewer2DCrest16, "Crest 16x16");
			this.viewer2DCrest32.AutoTransparency = true;
			this.viewer2DCrest32.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCrest32.ButtonStripVisible = false;
			this.viewer2DCrest32.CurrentBitmap = null;
			this.viewer2DCrest32.ExtendedFormat = false;
			this.viewer2DCrest32.FullSizeButton = false;
			this.viewer2DCrest32.ImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.viewer2DCrest32.ImageSize = new global::System.Drawing.Size(32, 32);
			this.viewer2DCrest32.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCrest32.Location = new global::System.Drawing.Point(102, 306);
			this.viewer2DCrest32.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DCrest32.Name = "viewer2DCrest32";
			this.viewer2DCrest32.RemoveButton = false;
			this.viewer2DCrest32.ShowButton = false;
			this.viewer2DCrest32.ShowButtonChecked = true;
			this.viewer2DCrest32.Size = new global::System.Drawing.Size(64, 89);
			this.viewer2DCrest32.TabIndex = 147;
			this.viewer2DCrest32.TabStop = false;
			this.toolTip.SetToolTip(this.viewer2DCrest32, "Crest 32x32");
			this.groupBoxName.Controls.Add(this.label3);
			this.groupBoxName.Controls.Add(this.textTeamName7);
			this.groupBoxName.Controls.Add(this.textScoreBoardName);
			this.groupBoxName.Controls.Add(this.textDatabaseTeamName);
			this.groupBoxName.Controls.Add(this.textFullTeamName);
			this.groupBoxName.Controls.Add(this.textStandardTeamName);
			this.groupBoxName.Controls.Add(this.textShortTeamName);
			this.groupBoxName.Controls.Add(this.labelDatabaseTeamName);
			this.groupBoxName.Controls.Add(this.labelFullTeamName);
			this.groupBoxName.Controls.Add(this.labelStandardTeamName);
			this.groupBoxName.Controls.Add(this.labelShortTeamName);
			this.groupBoxName.Controls.Add(this.labelScoreBoardName);
			this.groupBoxName.Location = new global::System.Drawing.Point(3, 454);
			this.groupBoxName.Name = "groupBoxName";
			this.groupBoxName.Size = new global::System.Drawing.Size(270, 160);
			this.groupBoxName.TabIndex = 0;
			this.groupBoxName.TabStop = false;
			this.groupBoxName.Text = "Name";
			this.label3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(4, 107);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(88, 20);
			this.label3.TabIndex = 56;
			this.label3.Text = "Name (7 chars)";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.label3, "Double click to fill automatically");
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label3.DoubleClick += new global::System.EventHandler(this.labelTeamName7_DoubleClick);
			this.textTeamName7.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "TeamNameAbbr7", true));
			this.textTeamName7.Location = new global::System.Drawing.Point(98, 107);
			this.textTeamName7.Name = "textTeamName7";
			this.textTeamName7.Size = new global::System.Drawing.Size(160, 20);
			this.textTeamName7.TabIndex = 4;
			this.textTeamName7.TextChanged += new global::System.EventHandler(this.textTeamName7_TextChanged);
			this.teamBindingSource.DataSource = typeof(global::FifaLibrary.Team);
			this.textScoreBoardName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "TeamNameAbbr3", true));
			this.textScoreBoardName.Location = new global::System.Drawing.Point(98, 130);
			this.textScoreBoardName.Name = "textScoreBoardName";
			this.textScoreBoardName.Size = new global::System.Drawing.Size(160, 20);
			this.textScoreBoardName.TabIndex = 5;
			this.textScoreBoardName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textDatabaseTeamName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "DatabaseName", true));
			this.textDatabaseTeamName.Location = new global::System.Drawing.Point(98, 15);
			this.textDatabaseTeamName.Name = "textDatabaseTeamName";
			this.textDatabaseTeamName.Size = new global::System.Drawing.Size(160, 20);
			this.textDatabaseTeamName.TabIndex = 0;
			this.textFullTeamName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "TeamNameFull", true));
			this.textFullTeamName.Location = new global::System.Drawing.Point(98, 38);
			this.textFullTeamName.Name = "textFullTeamName";
			this.textFullTeamName.Size = new global::System.Drawing.Size(160, 20);
			this.textFullTeamName.TabIndex = 1;
			this.textStandardTeamName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "TeamNameAbbr15", true));
			this.textStandardTeamName.Location = new global::System.Drawing.Point(98, 61);
			this.textStandardTeamName.Name = "textStandardTeamName";
			this.textStandardTeamName.Size = new global::System.Drawing.Size(160, 20);
			this.textStandardTeamName.TabIndex = 2;
			this.textStandardTeamName.TextChanged += new global::System.EventHandler(this.textStandardTeamName_TextChanged);
			this.textShortTeamName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "TeamNameAbbr10", true));
			this.textShortTeamName.Location = new global::System.Drawing.Point(98, 84);
			this.textShortTeamName.Name = "textShortTeamName";
			this.textShortTeamName.Size = new global::System.Drawing.Size(160, 20);
			this.textShortTeamName.TabIndex = 3;
			this.textShortTeamName.TextChanged += new global::System.EventHandler(this.textShortTeamName_TextChanged);
			this.labelDatabaseTeamName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDatabaseTeamName.Location = new global::System.Drawing.Point(4, 15);
			this.labelDatabaseTeamName.Name = "labelDatabaseTeamName";
			this.labelDatabaseTeamName.Size = new global::System.Drawing.Size(89, 20);
			this.labelDatabaseTeamName.TabIndex = 4;
			this.labelDatabaseTeamName.Text = "Database Name";
			this.labelDatabaseTeamName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelFullTeamName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFullTeamName.Location = new global::System.Drawing.Point(4, 38);
			this.labelFullTeamName.Name = "labelFullTeamName";
			this.labelFullTeamName.Size = new global::System.Drawing.Size(87, 20);
			this.labelFullTeamName.TabIndex = 52;
			this.labelFullTeamName.Text = "Full Name";
			this.labelFullTeamName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelStandardTeamName.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelStandardTeamName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStandardTeamName.Location = new global::System.Drawing.Point(4, 61);
			this.labelStandardTeamName.Name = "labelStandardTeamName";
			this.labelStandardTeamName.Size = new global::System.Drawing.Size(93, 20);
			this.labelStandardTeamName.TabIndex = 5;
			this.labelStandardTeamName.Text = "Name (15 chars)";
			this.labelStandardTeamName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelStandardTeamName, "Double click to fill automatically");
			this.labelStandardTeamName.DoubleClick += new global::System.EventHandler(this.labelStandardTeamName_DoubleClick);
			this.labelShortTeamName.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelShortTeamName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShortTeamName.Location = new global::System.Drawing.Point(4, 84);
			this.labelShortTeamName.Name = "labelShortTeamName";
			this.labelShortTeamName.Size = new global::System.Drawing.Size(93, 20);
			this.labelShortTeamName.TabIndex = 6;
			this.labelShortTeamName.Text = "Name (10 chars)";
			this.labelShortTeamName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelShortTeamName, "Double click to fill automatically");
			this.labelShortTeamName.DoubleClick += new global::System.EventHandler(this.textShortTeamName_Click);
			this.labelScoreBoardName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelScoreBoardName.Location = new global::System.Drawing.Point(4, 130);
			this.labelScoreBoardName.Name = "labelScoreBoardName";
			this.labelScoreBoardName.Size = new global::System.Drawing.Size(88, 20);
			this.labelScoreBoardName.TabIndex = 54;
			this.labelScoreBoardName.Text = "Score Board";
			this.labelScoreBoardName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBox1.Controls.Add(this.textStadiumName);
			this.groupBox1.Controls.Add(this.labelStadiumName);
			this.groupBox1.Controls.Add(this.comboStadiums);
			this.groupBox1.Controls.Add(this.labelStadium);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 620);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(270, 67);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stadium";
			this.textStadiumName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "stadiumcustomname", true));
			this.textStadiumName.Location = new global::System.Drawing.Point(98, 41);
			this.textStadiumName.Name = "textStadiumName";
			this.textStadiumName.Size = new global::System.Drawing.Size(160, 20);
			this.textStadiumName.TabIndex = 1;
			this.textStadiumName.TextChanged += new global::System.EventHandler(this.textStadiumName_TextChanged);
			this.labelStadiumName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStadiumName.Location = new global::System.Drawing.Point(0, 41);
			this.labelStadiumName.Name = "labelStadiumName";
			this.labelStadiumName.Size = new global::System.Drawing.Size(90, 20);
			this.labelStadiumName.TabIndex = 73;
			this.labelStadiumName.Text = "Stadium Name";
			this.labelStadiumName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboStadiums.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.teamBindingSource, "Stadium", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboStadiums.DataSource = this.stadiumListBindingSource;
			this.comboStadiums.Location = new global::System.Drawing.Point(98, 15);
			this.comboStadiums.Name = "comboStadiums";
			this.comboStadiums.Size = new global::System.Drawing.Size(160, 21);
			this.comboStadiums.TabIndex = 0;
			this.stadiumListBindingSource.DataSource = typeof(global::FifaLibrary.StadiumList);
			this.labelStadium.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelStadium.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelStadium.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelStadium.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStadium.Location = new global::System.Drawing.Point(0, 15);
			this.labelStadium.Name = "labelStadium";
			this.labelStadium.Size = new global::System.Drawing.Size(101, 20);
			this.labelStadium.TabIndex = 71;
			this.labelStadium.Text = "Stadium Model";
			this.labelStadium.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelStadium.DoubleClick += new global::System.EventHandler(this.labelTeamStadium_DoubleClick);
			this.groupManager.Controls.Add(this.textBox3);
			this.groupManager.Controls.Add(this.label17);
			this.groupManager.Controls.Add(this.textBox2);
			this.groupManager.Controls.Add(this.label16);
			this.groupManager.Location = new global::System.Drawing.Point(3, 693);
			this.groupManager.Name = "groupManager";
			this.groupManager.Size = new global::System.Drawing.Size(270, 72);
			this.groupManager.TabIndex = 2;
			this.groupManager.TabStop = false;
			this.groupManager.Text = "Manager";
			this.textBox3.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "ManagerSurname", true));
			this.textBox3.Location = new global::System.Drawing.Point(98, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 1;
			this.label17.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label17.Location = new global::System.Drawing.Point(6, 40);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(90, 20);
			this.label17.TabIndex = 77;
			this.label17.Text = "Surname";
			this.label17.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textBox2.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.teamBindingSource, "ManagerFirstName", true));
			this.textBox2.Location = new global::System.Drawing.Point(98, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 0;
			this.label16.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label16.Location = new global::System.Drawing.Point(6, 16);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(90, 20);
			this.label16.TabIndex = 75;
			this.label16.Text = "First Name";
			this.label16.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBox3.Controls.Add(this.checkIsNationalTeam);
			this.groupBox3.Controls.Add(this.labelProbObjective);
			this.groupBox3.Controls.Add(this.labelMaxObjective);
			this.groupBox3.Controls.Add(this.comboProbObjective);
			this.groupBox3.Controls.Add(this.comboMaxOnjective);
			this.groupBox3.Controls.Add(this.comboObjective);
			this.groupBox3.Controls.Add(this.labelObjective);
			this.groupBox3.Controls.Add(this.comboTeamLeague);
			this.groupBox3.Controls.Add(this.labelLeague);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.buttonGetId);
			this.groupBox3.Controls.Add(this.pictureTeamTerColor);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.comboRivalTeam);
			this.groupBox3.Controls.Add(this.pictureTeamPrimColor);
			this.groupBox3.Controls.Add(this.pictureTeamSecColor);
			this.groupBox3.Controls.Add(this.numericTeamId);
			this.groupBox3.Controls.Add(this.numericBall);
			this.groupBox3.Controls.Add(this.labelTeamId);
			this.groupBox3.Controls.Add(this.pictureBall);
			this.groupBox3.Controls.Add(this.comboTeamCountry);
			this.groupBox3.Controls.Add(this.numericStarsInternationalPrestige);
			this.groupBox3.Controls.Add(this.labelTeamCountry);
			this.groupBox3.Controls.Add(this.labelOpponent);
			this.groupBox3.Controls.Add(this.labelDomesticPrestige);
			this.groupBox3.Controls.Add(this.numericStarsDomesticPrestige);
			this.groupBox3.Controls.Add(this.labelInitialBudget);
			this.groupBox3.Controls.Add(this.labelInternationalPrestige);
			this.groupBox3.Controls.Add(this.numericInitialBudget);
			this.groupBox3.Location = new global::System.Drawing.Point(279, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(270, 496);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Info";
			this.checkIsNationalTeam.BackColor = global::System.Drawing.Color.Transparent;
			this.checkIsNationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkIsNationalTeam.Location = new global::System.Drawing.Point(6, 127);
			this.checkIsNationalTeam.Name = "checkIsNationalTeam";
			this.checkIsNationalTeam.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsNationalTeam.Size = new global::System.Drawing.Size(179, 17);
			this.checkIsNationalTeam.TabIndex = 155;
			this.checkIsNationalTeam.Text = "Is National Team";
			this.checkIsNationalTeam.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkIsNationalTeam.UseVisualStyleBackColor = true;
			this.checkIsNationalTeam.CheckedChanged += new global::System.EventHandler(this.checkIsNationalTeam_CheckedChanged);
			this.labelProbObjective.AutoSize = true;
			this.labelProbObjective.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelProbObjective.Location = new global::System.Drawing.Point(6, 285);
			this.labelProbObjective.Name = "labelProbObjective";
			this.labelProbObjective.Size = new global::System.Drawing.Size(49, 13);
			this.labelProbObjective.TabIndex = 154;
			this.labelProbObjective.Text = "Probable";
			this.labelProbObjective.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelMaxObjective.AutoSize = true;
			this.labelMaxObjective.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelMaxObjective.Location = new global::System.Drawing.Point(6, 258);
			this.labelMaxObjective.Name = "labelMaxObjective";
			this.labelMaxObjective.Size = new global::System.Drawing.Size(43, 13);
			this.labelMaxObjective.TabIndex = 153;
			this.labelMaxObjective.Text = "Highest";
			this.labelMaxObjective.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboProbObjective.FormattingEnabled = true;
			this.comboProbObjective.Items.AddRange(new object[]
			{
				"Win the League Title", "Qualify for Champions' Cup", "Qualify for Euro League", "Finish Mid Table", "Avoid Relegation", "Avoid Finish in Bottom Part", "Gain Automatic Promotion", "Fight For Promotion", "Achieve a High Finish", "Fight for the League Title",
				"Qualify For Europe", "Run for the Playoffs", "Reach the Wildcard Stage.", "Reach the Quarter Final", "Reach the Playoff Semi Final", "Reach the Playoff Final", "Become the Playoff Champion"
			});
			this.comboProbObjective.Location = new global::System.Drawing.Point(92, 282);
			this.comboProbObjective.Name = "comboProbObjective";
			this.comboProbObjective.Size = new global::System.Drawing.Size(167, 21);
			this.comboProbObjective.TabIndex = 8;
			this.comboProbObjective.SelectedIndexChanged += new global::System.EventHandler(this.comboProbObjective_SelectedIndexChanged);
			this.comboMaxOnjective.FormattingEnabled = true;
			this.comboMaxOnjective.Items.AddRange(new object[]
			{
				"Win the League Title", "Qualify for Champions' Cup", "Qualify for Euro League", "Finish Mid Table", "Avoid Relegation", "Avoid Finish in Bottom Part", "Gain Automatic Promotion", "Fight For Promotion", "Achieve a High Finish", "Fight for the League Title",
				"Qualify For Europe", "Run for the Playoffs", "Reach the Wildcard Stage.", "Reach the Quarter Final", "Reach the Playoff Semi Final", "Reach the Playoff Final", "Become the Playoff Champion"
			});
			this.comboMaxOnjective.Location = new global::System.Drawing.Point(92, 255);
			this.comboMaxOnjective.Name = "comboMaxOnjective";
			this.comboMaxOnjective.Size = new global::System.Drawing.Size(167, 21);
			this.comboMaxOnjective.TabIndex = 7;
			this.comboMaxOnjective.SelectedIndexChanged += new global::System.EventHandler(this.comboMaxOnjective_SelectedIndexChanged);
			this.comboObjective.FormattingEnabled = true;
			this.comboObjective.Items.AddRange(new object[]
			{
				"Win the League Title", "Qualify for Champions' Cup", "Qualify for Euro League", "Finish Mid Table", "Avoid Relegation", "Avoid Finish in Bottom Part", "Gain Automatic Promotion", "Fight For Promotion", "Achieve a High Finish", "Fight for the League Title",
				"Qualify For Europe", "Run for the Playoffs", "Reach the Wildcard Stage.", "Reach the Quarter Final", "Reach the Playoff Semi Final", "Reach the Playoff Final", "Become the Playoff Champion"
			});
			this.comboObjective.Location = new global::System.Drawing.Point(92, 228);
			this.comboObjective.Name = "comboObjective";
			this.comboObjective.Size = new global::System.Drawing.Size(167, 21);
			this.comboObjective.TabIndex = 6;
			this.comboObjective.SelectedIndexChanged += new global::System.EventHandler(this.comboObjective_SelectedIndexChanged);
			this.labelObjective.AutoSize = true;
			this.labelObjective.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelObjective.Location = new global::System.Drawing.Point(6, 231);
			this.labelObjective.Name = "labelObjective";
			this.labelObjective.Size = new global::System.Drawing.Size(52, 13);
			this.labelObjective.TabIndex = 149;
			this.labelObjective.Text = "Objective";
			this.labelObjective.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboTeamLeague.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.teamBindingSource, "League", true));
			this.comboTeamLeague.DataSource = this.leagueListBindingSource;
			this.comboTeamLeague.Enabled = false;
			this.comboTeamLeague.Location = new global::System.Drawing.Point(92, 100);
			this.comboTeamLeague.Name = "comboTeamLeague";
			this.comboTeamLeague.Size = new global::System.Drawing.Size(167, 21);
			this.comboTeamLeague.TabIndex = 2;
			this.comboTeamLeague.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamLeague_SelectedIndexChanged);
			this.leagueListBindingSource.DataSource = typeof(global::FifaLibrary.LeagueList);
			this.labelLeague.AutoSize = true;
			this.labelLeague.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelLeague.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelLeague.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelLeague.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeague.Location = new global::System.Drawing.Point(6, 97);
			this.labelLeague.Name = "labelLeague";
			this.labelLeague.Size = new global::System.Drawing.Size(43, 13);
			this.labelLeague.TabIndex = 148;
			this.labelLeague.Text = "League";
			this.labelLeague.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelLeague, "For changing the league go to the league page.");
			this.labelLeague.DoubleClick += new global::System.EventHandler(this.labelTeamLeague_DoubleClick);
			this.label15.AutoSize = true;
			this.label15.BackColor = global::System.Drawing.Color.Transparent;
			this.label15.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label15.Location = new global::System.Drawing.Point(6, 24);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(36, 13);
			this.label15.TabIndex = 147;
			this.label15.Text = "Colors";
			this.label15.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.buttonGetId.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetId.Image");
			this.buttonGetId.Location = new global::System.Drawing.Point(184, 45);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(28, 24);
			this.buttonGetId.TabIndex = 6;
			this.buttonGetId.TabStop = false;
			this.buttonGetId.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.pictureTeamTerColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamTerColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamTerColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor3", true));
			this.pictureTeamTerColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamTerColor.Location = new global::System.Drawing.Point(165, 18);
			this.pictureTeamTerColor.Name = "pictureTeamTerColor";
			this.pictureTeamTerColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamTerColor.TabIndex = 146;
			this.pictureTeamTerColor.TabStop = false;
			this.pictureTeamTerColor.Click += new global::System.EventHandler(this.pictureTeamTerColor_Click);
			this.label1.AutoSize = true;
			this.label1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(6, 338);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 13);
			this.label1.TabIndex = 96;
			this.label1.Text = "Ball Number";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.DoubleClick += new global::System.EventHandler(this.labelBall_DoubleClick);
			this.comboRivalTeam.FormattingEnabled = true;
			this.comboRivalTeam.Location = new global::System.Drawing.Point(92, 309);
			this.comboRivalTeam.Name = "comboRivalTeam";
			this.comboRivalTeam.Size = new global::System.Drawing.Size(167, 21);
			this.comboRivalTeam.TabIndex = 9;
			this.comboRivalTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboRivalTeam_SelectedIndexChanged);
			this.pictureTeamPrimColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamPrimColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamPrimColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor1", true));
			this.pictureTeamPrimColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamPrimColor.Location = new global::System.Drawing.Point(91, 18);
			this.pictureTeamPrimColor.Name = "pictureTeamPrimColor";
			this.pictureTeamPrimColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamPrimColor.TabIndex = 144;
			this.pictureTeamPrimColor.TabStop = false;
			this.pictureTeamPrimColor.Click += new global::System.EventHandler(this.pictureTeamPrimColor_Click);
			this.pictureTeamSecColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamSecColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamSecColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor2", true));
			this.pictureTeamSecColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamSecColor.Location = new global::System.Drawing.Point(128, 18);
			this.pictureTeamSecColor.Name = "pictureTeamSecColor";
			this.pictureTeamSecColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamSecColor.TabIndex = 145;
			this.pictureTeamSecColor.TabStop = false;
			this.pictureTeamSecColor.Click += new global::System.EventHandler(this.pictureTeamSecColor_Click);
			this.numericTeamId.Location = new global::System.Drawing.Point(91, 47);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericTeamId;
			int[] array = new int[4];
			array[0] = 200000;
			numericUpDown.Maximum = new decimal(array);
			this.numericTeamId.Name = "numericTeamId";
			this.numericTeamId.Size = new global::System.Drawing.Size(87, 20);
			this.numericTeamId.TabIndex = 0;
			this.numericTeamId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericTeamId;
			int[] array2 = new int[4];
			array2[0] = 200000;
			numericUpDown2.Value = new decimal(array2);
			this.numericTeamId.ValueChanged += new global::System.EventHandler(this.numericTeamId_ValueChanged);
			this.numericBall.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "balltype", true));
			this.numericBall.Location = new global::System.Drawing.Point(168, 336);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericBall;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericBall.Name = "numericBall";
			this.numericBall.Size = new global::System.Drawing.Size(91, 20);
			this.numericBall.TabIndex = 10;
			this.numericBall.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericBall;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			this.numericBall.ValueChanged += new global::System.EventHandler(this.numericBall_ValueChanged);
			this.labelTeamId.AutoSize = true;
			this.labelTeamId.BackColor = global::System.Drawing.Color.Transparent;
			this.labelTeamId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelTeamId.Location = new global::System.Drawing.Point(6, 49);
			this.labelTeamId.Name = "labelTeamId";
			this.labelTeamId.Size = new global::System.Drawing.Size(46, 13);
			this.labelTeamId.TabIndex = 5;
			this.labelTeamId.Text = "Team Id";
			this.labelTeamId.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.pictureBall.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBall.Location = new global::System.Drawing.Point(10, 376);
			this.pictureBall.Name = "pictureBall";
			this.pictureBall.Size = new global::System.Drawing.Size(249, 110);
			this.pictureBall.TabIndex = 5;
			this.pictureBall.TabStop = false;
			this.comboTeamCountry.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.teamBindingSource, "Country", true));
			this.comboTeamCountry.DataSource = this.countryListBindingSource;
			this.comboTeamCountry.Location = new global::System.Drawing.Point(92, 73);
			this.comboTeamCountry.Name = "comboTeamCountry";
			this.comboTeamCountry.Size = new global::System.Drawing.Size(167, 21);
			this.comboTeamCountry.TabIndex = 1;
			this.comboTeamCountry.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamCountry_SelectedIndexChanged);
			this.countryListBindingSource.DataSource = typeof(global::FifaLibrary.CountryList);
			this.numericStarsInternationalPrestige.BackColor = global::System.Drawing.Color.Transparent;
			this.numericStarsInternationalPrestige.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "internationalprestige", true));
			this.numericStarsInternationalPrestige.Location = new global::System.Drawing.Point(92, 176);
			this.numericStarsInternationalPrestige.Margin = new global::System.Windows.Forms.Padding(4);
			this.numericStarsInternationalPrestige.Name = "numericStarsInternationalPrestige";
			this.numericStarsInternationalPrestige.Size = new global::System.Drawing.Size(167, 20);
			this.numericStarsInternationalPrestige.TabIndex = 4;
			this.numericStarsInternationalPrestige.Value = 0;
			this.labelTeamCountry.AutoSize = true;
			this.labelTeamCountry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelTeamCountry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTeamCountry.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelTeamCountry.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelTeamCountry.Location = new global::System.Drawing.Point(6, 73);
			this.labelTeamCountry.Name = "labelTeamCountry";
			this.labelTeamCountry.Size = new global::System.Drawing.Size(43, 13);
			this.labelTeamCountry.TabIndex = 122;
			this.labelTeamCountry.Text = "Country";
			this.labelTeamCountry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelTeamCountry.DoubleClick += new global::System.EventHandler(this.labelTeamCountry_DoubleClick);
			this.labelOpponent.AutoSize = true;
			this.labelOpponent.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelOpponent.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelOpponent.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelOpponent.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelOpponent.Location = new global::System.Drawing.Point(6, 312);
			this.labelOpponent.Name = "labelOpponent";
			this.labelOpponent.Size = new global::System.Drawing.Size(84, 13);
			this.labelOpponent.TabIndex = 124;
			this.labelOpponent.Text = "Opponent Team";
			this.labelOpponent.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelOpponent.DoubleClick += new global::System.EventHandler(this.labelOpponent_DoubleClick);
			this.labelDomesticPrestige.AutoSize = true;
			this.labelDomesticPrestige.BackColor = global::System.Drawing.Color.Transparent;
			this.labelDomesticPrestige.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDomesticPrestige.Location = new global::System.Drawing.Point(6, 152);
			this.labelDomesticPrestige.Name = "labelDomesticPrestige";
			this.labelDomesticPrestige.Size = new global::System.Drawing.Size(51, 13);
			this.labelDomesticPrestige.TabIndex = 103;
			this.labelDomesticPrestige.Text = "Domestic";
			this.labelDomesticPrestige.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericStarsDomesticPrestige.BackColor = global::System.Drawing.Color.Transparent;
			this.numericStarsDomesticPrestige.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "domesticprestige", true));
			this.numericStarsDomesticPrestige.Location = new global::System.Drawing.Point(92, 150);
			this.numericStarsDomesticPrestige.Margin = new global::System.Windows.Forms.Padding(4);
			this.numericStarsDomesticPrestige.Name = "numericStarsDomesticPrestige";
			this.numericStarsDomesticPrestige.Size = new global::System.Drawing.Size(167, 20);
			this.numericStarsDomesticPrestige.TabIndex = 3;
			this.numericStarsDomesticPrestige.Value = 0;
			this.labelInitialBudget.AutoSize = true;
			this.labelInitialBudget.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelInitialBudget.Location = new global::System.Drawing.Point(6, 204);
			this.labelInitialBudget.Name = "labelInitialBudget";
			this.labelInitialBudget.Size = new global::System.Drawing.Size(41, 13);
			this.labelInitialBudget.TabIndex = 95;
			this.labelInitialBudget.Text = "Budget";
			this.labelInitialBudget.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelInternationalPrestige.AutoSize = true;
			this.labelInternationalPrestige.BackColor = global::System.Drawing.Color.Transparent;
			this.labelInternationalPrestige.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelInternationalPrestige.Location = new global::System.Drawing.Point(6, 179);
			this.labelInternationalPrestige.Name = "labelInternationalPrestige";
			this.labelInternationalPrestige.Size = new global::System.Drawing.Size(65, 13);
			this.labelInternationalPrestige.TabIndex = 101;
			this.labelInternationalPrestige.Text = "International";
			this.labelInternationalPrestige.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericInitialBudget.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "transferbudget", true));
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericInitialBudget;
			int[] array5 = new int[4];
			array5[0] = 100000;
			numericUpDown5.Increment = new decimal(array5);
			this.numericInitialBudget.Location = new global::System.Drawing.Point(92, 202);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericInitialBudget;
			int[] array6 = new int[4];
			array6[0] = 100000000;
			numericUpDown6.Maximum = new decimal(array6);
			this.numericInitialBudget.Name = "numericInitialBudget";
			this.numericInitialBudget.Size = new global::System.Drawing.Size(167, 20);
			this.numericInitialBudget.TabIndex = 5;
			this.numericInitialBudget.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericInitialBudget.ThousandsSeparator = true;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericInitialBudget;
			int[] array7 = new int[4];
			array7[0] = 10000000;
			numericUpDown7.Value = new decimal(array7);
			this.groupLastYear.Controls.Add(this.comboPrevLeague);
			this.groupLastYear.Controls.Add(this.numericPositionLastYear);
			this.groupLastYear.Controls.Add(this.checkIsChampion);
			this.groupLastYear.Controls.Add(this.label19);
			this.groupLastYear.Controls.Add(this.label18);
			this.groupLastYear.Location = new global::System.Drawing.Point(279, 505);
			this.groupLastYear.Name = "groupLastYear";
			this.groupLastYear.Size = new global::System.Drawing.Size(270, 101);
			this.groupLastYear.TabIndex = 4;
			this.groupLastYear.TabStop = false;
			this.groupLastYear.Text = "Last Year Performance";
			this.comboPrevLeague.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.teamBindingSource, "PrevLeague", true));
			this.comboPrevLeague.DataSource = this.leagueListBindingSource;
			this.comboPrevLeague.Location = new global::System.Drawing.Point(97, 18);
			this.comboPrevLeague.Name = "comboPrevLeague";
			this.comboPrevLeague.Size = new global::System.Drawing.Size(167, 21);
			this.comboPrevLeague.TabIndex = 0;
			this.comboPrevLeague.SelectedIndexChanged += new global::System.EventHandler(this.comboPrevLeague_SelectedIndexChanged);
			this.numericPositionLastYear.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "previousyeartableposition", true));
			this.numericPositionLastYear.Location = new global::System.Drawing.Point(97, 42);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericPositionLastYear;
			int[] array8 = new int[4];
			array8[0] = 24;
			numericUpDown8.Maximum = new decimal(array8);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericPositionLastYear;
			int[] array9 = new int[4];
			array9[0] = 1;
			numericUpDown9.Minimum = new decimal(array9);
			this.numericPositionLastYear.Name = "numericPositionLastYear";
			this.numericPositionLastYear.Size = new global::System.Drawing.Size(63, 20);
			this.numericPositionLastYear.TabIndex = 1;
			this.numericPositionLastYear.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericPositionLastYear;
			int[] array10 = new int[4];
			array10[0] = 1;
			numericUpDown10.Value = new decimal(array10);
			this.checkIsChampion.AutoSize = true;
			this.checkIsChampion.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "IsChampion", true));
			this.checkIsChampion.Location = new global::System.Drawing.Point(6, 68);
			this.checkIsChampion.Name = "checkIsChampion";
			this.checkIsChampion.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsChampion.Size = new global::System.Drawing.Size(117, 17);
			this.checkIsChampion.TabIndex = 2;
			this.checkIsChampion.Text = "Is Champion           ";
			this.checkIsChampion.UseVisualStyleBackColor = true;
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label19.Location = new global::System.Drawing.Point(6, 44);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(44, 13);
			this.label19.TabIndex = 149;
			this.label19.Text = "Position";
			this.label19.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label18.AutoSize = true;
			this.label18.BackColor = global::System.Drawing.Color.Transparent;
			this.label18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label18.Location = new global::System.Drawing.Point(7, 21);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(43, 13);
			this.label18.TabIndex = 148;
			this.label18.Text = "League";
			this.label18.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.groupLocation.Controls.Add(this.numericUtcOffset);
			this.groupLocation.Controls.Add(this.numericLongitude);
			this.groupLocation.Controls.Add(this.numericLatitude);
			this.groupLocation.Controls.Add(this.label25);
			this.groupLocation.Controls.Add(this.label24);
			this.groupLocation.Controls.Add(this.label23);
			this.groupLocation.Location = new global::System.Drawing.Point(279, 612);
			this.groupLocation.Name = "groupLocation";
			this.groupLocation.Size = new global::System.Drawing.Size(270, 102);
			this.groupLocation.TabIndex = 162;
			this.groupLocation.TabStop = false;
			this.groupLocation.Text = "Location";
			this.numericUtcOffset.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "utcoffset", true));
			this.numericUtcOffset.Location = new global::System.Drawing.Point(91, 73);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericUtcOffset;
			int[] array11 = new int[4];
			array11[0] = 13;
			numericUpDown11.Maximum = new decimal(array11);
			this.numericUtcOffset.Minimum = new decimal(new int[] { 12, 0, 0, int.MinValue });
			this.numericUtcOffset.Name = "numericUtcOffset";
			this.numericUtcOffset.Size = new global::System.Drawing.Size(87, 20);
			this.numericUtcOffset.TabIndex = 154;
			this.numericUtcOffset.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUtcOffset.ValueChanged += new global::System.EventHandler(this.numericUtcOffset_ValueChanged);
			this.numericLongitude.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "longitude", true));
			this.numericLongitude.Location = new global::System.Drawing.Point(91, 45);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericLongitude;
			int[] array12 = new int[4];
			array12[0] = 180;
			numericUpDown12.Maximum = new decimal(array12);
			this.numericLongitude.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
			this.numericLongitude.Name = "numericLongitude";
			this.numericLongitude.Size = new global::System.Drawing.Size(87, 20);
			this.numericLongitude.TabIndex = 153;
			this.numericLongitude.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericLongitude.ValueChanged += new global::System.EventHandler(this.numericLongitude_ValueChanged);
			this.numericLatitude.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "latitude", true));
			this.numericLatitude.Location = new global::System.Drawing.Point(91, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericLatitude;
			int[] array13 = new int[4];
			array13[0] = 90;
			numericUpDown13.Maximum = new decimal(array13);
			this.numericLatitude.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
			this.numericLatitude.Name = "numericLatitude";
			this.numericLatitude.Size = new global::System.Drawing.Size(87, 20);
			this.numericLatitude.TabIndex = 152;
			this.numericLatitude.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericLatitude.ValueChanged += new global::System.EventHandler(this.numericLatitude_ValueChanged);
			this.label25.AutoSize = true;
			this.label25.BackColor = global::System.Drawing.Color.Transparent;
			this.label25.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label25.Location = new global::System.Drawing.Point(6, 73);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(55, 13);
			this.label25.TabIndex = 151;
			this.label25.Text = "UTC Time";
			this.label25.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label24.AutoSize = true;
			this.label24.BackColor = global::System.Drawing.Color.Transparent;
			this.label24.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label24.Location = new global::System.Drawing.Point(6, 48);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(54, 13);
			this.label24.TabIndex = 150;
			this.label24.Text = "Longitude";
			this.label24.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label23.AutoSize = true;
			this.label23.BackColor = global::System.Drawing.Color.Transparent;
			this.label23.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label23.Location = new global::System.Drawing.Point(6, 24);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(45, 13);
			this.label23.TabIndex = 149;
			this.label23.Text = "Latitude";
			this.label23.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.groupTeamTraits.Controls.Add(this.checkShortOutBack);
			this.groupTeamTraits.Controls.Add(this.checkMoreAttackingAtHome);
			this.groupTeamTraits.Controls.Add(this.checkCenterBacksSplit);
			this.groupTeamTraits.Controls.Add(this.checkSwitchWingers);
			this.groupTeamTraits.Controls.Add(this.checkKeepUpPressure);
			this.groupTeamTraits.Controls.Add(this.checkDefendLead);
			this.groupTeamTraits.Controls.Add(this.checkConsistentLineup);
			this.groupTeamTraits.Controls.Add(this.checkSquadRotation);
			this.groupTeamTraits.Controls.Add(this.checkLoyalBoard);
			this.groupTeamTraits.Controls.Add(this.checkImpatientBoard);
			this.groupTeamTraits.Location = new global::System.Drawing.Point(555, 3);
			this.groupTeamTraits.Name = "groupTeamTraits";
			this.groupTeamTraits.Size = new global::System.Drawing.Size(270, 209);
			this.groupTeamTraits.TabIndex = 161;
			this.groupTeamTraits.TabStop = false;
			this.groupTeamTraits.Text = "Team Traits";
			this.checkShortOutBack.AutoSize = true;
			this.checkShortOutBack.BackColor = global::System.Drawing.Color.Transparent;
			this.checkShortOutBack.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "ShortOutBack", true));
			this.checkShortOutBack.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkShortOutBack.Location = new global::System.Drawing.Point(83, 170);
			this.checkShortOutBack.Name = "checkShortOutBack";
			this.checkShortOutBack.Size = new global::System.Drawing.Size(99, 17);
			this.checkShortOutBack.TabIndex = 9;
			this.checkShortOutBack.Text = "Short Out Back";
			this.checkShortOutBack.UseVisualStyleBackColor = false;
			this.checkMoreAttackingAtHome.AutoSize = true;
			this.checkMoreAttackingAtHome.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMoreAttackingAtHome.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "MoreAttackingAtHome", true));
			this.checkMoreAttackingAtHome.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkMoreAttackingAtHome.Location = new global::System.Drawing.Point(83, 148);
			this.checkMoreAttackingAtHome.Name = "checkMoreAttackingAtHome";
			this.checkMoreAttackingAtHome.Size = new global::System.Drawing.Size(142, 17);
			this.checkMoreAttackingAtHome.TabIndex = 8;
			this.checkMoreAttackingAtHome.Text = "More Attacking At Home";
			this.checkMoreAttackingAtHome.UseVisualStyleBackColor = false;
			this.checkCenterBacksSplit.AutoSize = true;
			this.checkCenterBacksSplit.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCenterBacksSplit.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "CenterBacksSplit", true));
			this.checkCenterBacksSplit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCenterBacksSplit.Location = new global::System.Drawing.Point(83, 126);
			this.checkCenterBacksSplit.Name = "checkCenterBacksSplit";
			this.checkCenterBacksSplit.Size = new global::System.Drawing.Size(113, 17);
			this.checkCenterBacksSplit.TabIndex = 7;
			this.checkCenterBacksSplit.Text = "Center Backs Split";
			this.checkCenterBacksSplit.UseVisualStyleBackColor = false;
			this.checkSwitchWingers.AutoSize = true;
			this.checkSwitchWingers.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSwitchWingers.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "SwitchWingers", true));
			this.checkSwitchWingers.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkSwitchWingers.Location = new global::System.Drawing.Point(83, 104);
			this.checkSwitchWingers.Name = "checkSwitchWingers";
			this.checkSwitchWingers.Size = new global::System.Drawing.Size(100, 17);
			this.checkSwitchWingers.TabIndex = 6;
			this.checkSwitchWingers.Text = "Switch Wingers";
			this.checkSwitchWingers.UseVisualStyleBackColor = false;
			this.checkKeepUpPressure.AutoSize = true;
			this.checkKeepUpPressure.BackColor = global::System.Drawing.Color.Transparent;
			this.checkKeepUpPressure.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "KeepUpPressure", true));
			this.checkKeepUpPressure.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKeepUpPressure.Location = new global::System.Drawing.Point(142, 65);
			this.checkKeepUpPressure.Name = "checkKeepUpPressure";
			this.checkKeepUpPressure.Size = new global::System.Drawing.Size(112, 17);
			this.checkKeepUpPressure.TabIndex = 5;
			this.checkKeepUpPressure.Text = "Keep Up Pressure";
			this.checkKeepUpPressure.UseVisualStyleBackColor = false;
			this.checkDefendLead.AutoSize = true;
			this.checkDefendLead.BackColor = global::System.Drawing.Color.Transparent;
			this.checkDefendLead.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "DefendLead", true));
			this.checkDefendLead.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkDefendLead.Location = new global::System.Drawing.Point(19, 65);
			this.checkDefendLead.Name = "checkDefendLead";
			this.checkDefendLead.Size = new global::System.Drawing.Size(88, 17);
			this.checkDefendLead.TabIndex = 2;
			this.checkDefendLead.Text = "Defend Lead";
			this.checkDefendLead.UseVisualStyleBackColor = false;
			this.checkConsistentLineup.AutoSize = true;
			this.checkConsistentLineup.BackColor = global::System.Drawing.Color.Transparent;
			this.checkConsistentLineup.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "ConsistentLineup", true));
			this.checkConsistentLineup.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkConsistentLineup.Location = new global::System.Drawing.Point(142, 42);
			this.checkConsistentLineup.Name = "checkConsistentLineup";
			this.checkConsistentLineup.Size = new global::System.Drawing.Size(110, 17);
			this.checkConsistentLineup.TabIndex = 4;
			this.checkConsistentLineup.Text = "Consistent Lineup";
			this.checkConsistentLineup.UseVisualStyleBackColor = false;
			this.checkSquadRotation.AutoSize = true;
			this.checkSquadRotation.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSquadRotation.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "SquadRotation", true));
			this.checkSquadRotation.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkSquadRotation.Location = new global::System.Drawing.Point(19, 42);
			this.checkSquadRotation.Name = "checkSquadRotation";
			this.checkSquadRotation.Size = new global::System.Drawing.Size(100, 17);
			this.checkSquadRotation.TabIndex = 1;
			this.checkSquadRotation.Text = "Squad Rotation";
			this.checkSquadRotation.UseVisualStyleBackColor = false;
			this.checkLoyalBoard.AutoSize = true;
			this.checkLoyalBoard.BackColor = global::System.Drawing.Color.Transparent;
			this.checkLoyalBoard.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "LoyalBoard", true));
			this.checkLoyalBoard.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLoyalBoard.Location = new global::System.Drawing.Point(142, 19);
			this.checkLoyalBoard.Name = "checkLoyalBoard";
			this.checkLoyalBoard.Size = new global::System.Drawing.Size(82, 17);
			this.checkLoyalBoard.TabIndex = 3;
			this.checkLoyalBoard.Text = "Loyal Board";
			this.checkLoyalBoard.UseVisualStyleBackColor = false;
			this.checkImpatientBoard.AutoSize = true;
			this.checkImpatientBoard.BackColor = global::System.Drawing.Color.Transparent;
			this.checkImpatientBoard.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.teamBindingSource, "ImpatientBoard", true));
			this.checkImpatientBoard.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkImpatientBoard.Location = new global::System.Drawing.Point(19, 19);
			this.checkImpatientBoard.Name = "checkImpatientBoard";
			this.checkImpatientBoard.Size = new global::System.Drawing.Size(100, 17);
			this.checkImpatientBoard.TabIndex = 0;
			this.checkImpatientBoard.Text = "Impatient Board";
			this.checkImpatientBoard.UseVisualStyleBackColor = false;
			this.groupBox7.Controls.Add(this.labelThirdKit);
			this.groupBox7.Controls.Add(this.labelKeeprKit);
			this.groupBox7.Controls.Add(this.labelAwayKit);
			this.groupBox7.Controls.Add(this.labelHomeKit);
			this.groupBox7.Location = new global::System.Drawing.Point(555, 218);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(270, 61);
			this.groupBox7.TabIndex = 163;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Kit Links";
			this.labelThirdKit.AutoSize = true;
			this.labelThirdKit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelThirdKit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.labelThirdKit.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelThirdKit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelThirdKit.Location = new global::System.Drawing.Point(217, 30);
			this.labelThirdKit.Name = "labelThirdKit";
			this.labelThirdKit.Size = new global::System.Drawing.Size(37, 13);
			this.labelThirdKit.TabIndex = 100;
			this.labelThirdKit.Text = "3rd Kit";
			this.labelThirdKit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelThirdKit, "Double click to jump to the 3rd Kit, if any");
			this.labelThirdKit.DoubleClick += new global::System.EventHandler(this.labelThirdKit_DoubleClick);
			this.labelKeeprKit.AutoSize = true;
			this.labelKeeprKit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelKeeprKit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.labelKeeprKit.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelKeeprKit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelKeeprKit.Location = new global::System.Drawing.Point(142, 30);
			this.labelKeeprKit.Name = "labelKeeprKit";
			this.labelKeeprKit.Size = new global::System.Drawing.Size(56, 13);
			this.labelKeeprKit.TabIndex = 99;
			this.labelKeeprKit.Text = "Keeper Kit";
			this.labelKeeprKit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelKeeprKit, "Double click to jump to the Keepr Kit, if any");
			this.labelKeeprKit.DoubleClick += new global::System.EventHandler(this.labelKeeprKit_DoubleClick);
			this.labelAwayKit.AutoSize = true;
			this.labelAwayKit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelAwayKit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.labelAwayKit.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelAwayKit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAwayKit.Location = new global::System.Drawing.Point(75, 30);
			this.labelAwayKit.Name = "labelAwayKit";
			this.labelAwayKit.Size = new global::System.Drawing.Size(48, 13);
			this.labelAwayKit.TabIndex = 98;
			this.labelAwayKit.Text = "Away Kit";
			this.labelAwayKit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelAwayKit, "Double click to jump to the Away Kit");
			this.labelAwayKit.DoubleClick += new global::System.EventHandler(this.labelAwayKit_DoubleClick);
			this.labelHomeKit.AutoSize = true;
			this.labelHomeKit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelHomeKit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline);
			this.labelHomeKit.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelHomeKit.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHomeKit.Location = new global::System.Drawing.Point(6, 30);
			this.labelHomeKit.Name = "labelHomeKit";
			this.labelHomeKit.Size = new global::System.Drawing.Size(50, 13);
			this.labelHomeKit.TabIndex = 97;
			this.labelHomeKit.Text = "Home Kit";
			this.labelHomeKit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.labelHomeKit, "Double click to jump to the Home Kit");
			this.labelHomeKit.DoubleClick += new global::System.EventHandler(this.labelHomeKit_DoubleClick);
			this.pageTeamRoster.AutoScroll = true;
			this.pageTeamRoster.Controls.Add(this.groupBox6);
			this.pageTeamRoster.Controls.Add(this.groupBox5);
			this.pageTeamRoster.Controls.Add(this.groupBox4);
			this.pageTeamRoster.Controls.Add(this.labelRightFreeKickText);
			this.pageTeamRoster.Controls.Add(this.labelRightFreeKick);
			this.pageTeamRoster.Controls.Add(this.labelLeftFreeKickText);
			this.pageTeamRoster.Controls.Add(this.labelLeftFreeKick);
			this.pageTeamRoster.Controls.Add(this.groupFormation);
			this.pageTeamRoster.Controls.Add(this.labelLongKick);
			this.pageTeamRoster.Controls.Add(this.labelLomgKickText);
			this.pageTeamRoster.Controls.Add(this.labelRightCornerText);
			this.pageTeamRoster.Controls.Add(this.labelCaptainTetx);
			this.pageTeamRoster.Controls.Add(this.labelLeftCornertext);
			this.pageTeamRoster.Controls.Add(this.labelRightCorner);
			this.pageTeamRoster.Controls.Add(this.labelCaptain);
			this.pageTeamRoster.Controls.Add(this.labelLeftCorner);
			this.pageTeamRoster.Controls.Add(this.labelFreeKickText);
			this.pageTeamRoster.Controls.Add(this.labelPenaltyText);
			this.pageTeamRoster.Controls.Add(this.labelPenalty);
			this.pageTeamRoster.Controls.Add(this.labelFreeKick);
			this.pageTeamRoster.Controls.Add(this.panel1);
			this.pageTeamRoster.Controls.Add(this.groupAvailablePlayers);
			this.pageTeamRoster.Controls.Add(this.groupTeamPlayers);
			this.pageTeamRoster.Location = new global::System.Drawing.Point(4, 22);
			this.pageTeamRoster.Name = "pageTeamRoster";
			this.pageTeamRoster.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageTeamRoster.Size = new global::System.Drawing.Size(1303, 781);
			this.pageTeamRoster.TabIndex = 1;
			this.pageTeamRoster.Text = "Roster";
			this.pageTeamRoster.UseVisualStyleBackColor = true;
			this.groupBox6.Controls.Add(this.labelCcpositioning);
			this.groupBox6.Controls.Add(this.labelCcpassing);
			this.groupBox6.Controls.Add(this.labelCccrossing);
			this.groupBox6.Controls.Add(this.labelCcshooting);
			this.groupBox6.Controls.Add(this.numericCcpassing);
			this.groupBox6.Controls.Add(this.numericCccrossing);
			this.groupBox6.Controls.Add(this.numericCcshooting);
			this.groupBox6.Controls.Add(this.comboCCPositioning);
			this.groupBox6.Location = new global::System.Drawing.Point(970, 630);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(230, 128);
			this.groupBox6.TabIndex = 272;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Chance Creation";
			this.labelCcpositioning.AutoSize = true;
			this.labelCcpositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCcpositioning.Location = new global::System.Drawing.Point(6, 22);
			this.labelCcpositioning.Name = "labelCcpositioning";
			this.labelCcpositioning.Size = new global::System.Drawing.Size(98, 13);
			this.labelCcpositioning.TabIndex = 240;
			this.labelCcpositioning.Text = "Chance Positioning";
			this.labelCcpositioning.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCcpassing.AutoSize = true;
			this.labelCcpassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCcpassing.Location = new global::System.Drawing.Point(6, 49);
			this.labelCcpassing.Name = "labelCcpassing";
			this.labelCcpassing.Size = new global::System.Drawing.Size(110, 13);
			this.labelCcpassing.TabIndex = 237;
			this.labelCcpassing.Text = "Passing (Safe - Risky)";
			this.labelCcpassing.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCccrossing.AutoSize = true;
			this.labelCccrossing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCccrossing.Location = new global::System.Drawing.Point(6, 73);
			this.labelCccrossing.Name = "labelCccrossing";
			this.labelCccrossing.Size = new global::System.Drawing.Size(107, 13);
			this.labelCccrossing.TabIndex = 238;
			this.labelCccrossing.Text = "Crossing (Little - Lots)";
			this.labelCccrossing.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCcshooting.AutoSize = true;
			this.labelCcshooting.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCcshooting.Location = new global::System.Drawing.Point(6, 97);
			this.labelCcshooting.Name = "labelCcshooting";
			this.labelCcshooting.Size = new global::System.Drawing.Size(109, 13);
			this.labelCcshooting.TabIndex = 239;
			this.labelCcshooting.Text = "Shooting (Little - Lots)";
			this.labelCcshooting.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericCcpassing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "ccpassing", true));
			this.numericCcpassing.Location = new global::System.Drawing.Point(160, 45);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericCcpassing;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Minimum = new decimal(array14);
			this.numericCcpassing.Name = "numericCcpassing";
			this.numericCcpassing.Size = new global::System.Drawing.Size(64, 20);
			this.numericCcpassing.TabIndex = 234;
			this.numericCcpassing.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numericCcpassing;
			int[] array15 = new int[4];
			array15[0] = 50;
			numericUpDown15.Value = new decimal(array15);
			this.numericCccrossing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "cccrossing", true));
			this.numericCccrossing.Location = new global::System.Drawing.Point(160, 69);
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numericCccrossing;
			int[] array16 = new int[4];
			array16[0] = 1;
			numericUpDown16.Minimum = new decimal(array16);
			this.numericCccrossing.Name = "numericCccrossing";
			this.numericCccrossing.Size = new global::System.Drawing.Size(64, 20);
			this.numericCccrossing.TabIndex = 235;
			this.numericCccrossing.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numericCccrossing;
			int[] array17 = new int[4];
			array17[0] = 50;
			numericUpDown17.Value = new decimal(array17);
			this.numericCcshooting.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "ccshooting", true));
			this.numericCcshooting.Location = new global::System.Drawing.Point(160, 93);
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numericCcshooting;
			int[] array18 = new int[4];
			array18[0] = 1;
			numericUpDown18.Minimum = new decimal(array18);
			this.numericCcshooting.Name = "numericCcshooting";
			this.numericCcshooting.Size = new global::System.Drawing.Size(64, 20);
			this.numericCcshooting.TabIndex = 236;
			this.numericCcshooting.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numericCcshooting;
			int[] array19 = new int[4];
			array19[0] = 50;
			numericUpDown19.Value = new decimal(array19);
			this.comboCCPositioning.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.teamBindingSource, "ccpositioning", true));
			this.comboCCPositioning.FormattingEnabled = true;
			this.comboCCPositioning.Items.AddRange(new object[] { "Organized", "Free Form" });
			this.comboCCPositioning.Location = new global::System.Drawing.Point(110, 18);
			this.comboCCPositioning.Name = "comboCCPositioning";
			this.comboCCPositioning.Size = new global::System.Drawing.Size(114, 21);
			this.comboCCPositioning.TabIndex = 233;
			this.comboCCPositioning.SelectedIndexChanged += new global::System.EventHandler(this.comboCCPositioning_SelectedIndexChanged);
			this.groupBox5.Controls.Add(this.labelBuspositioning);
			this.groupBox5.Controls.Add(this.labelBusbuildupspeed);
			this.groupBox5.Controls.Add(this.labelBuspassing);
			this.groupBox5.Controls.Add(this.numericBusbuildupspeed);
			this.groupBox5.Controls.Add(this.numericBuspassing);
			this.groupBox5.Controls.Add(this.comboBUSPositioning);
			this.groupBox5.Controls.Add(this.numericUpDown2);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Location = new global::System.Drawing.Point(734, 627);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(230, 128);
			this.groupBox5.TabIndex = 271;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Build Up";
			this.labelBuspositioning.AutoSize = true;
			this.labelBuspositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBuspositioning.Location = new global::System.Drawing.Point(6, 25);
			this.labelBuspositioning.Name = "labelBuspositioning";
			this.labelBuspositioning.Size = new global::System.Drawing.Size(101, 13);
			this.labelBuspositioning.TabIndex = 231;
			this.labelBuspositioning.Text = "Build Up Positioning";
			this.labelBuspositioning.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBusbuildupspeed.AutoSize = true;
			this.labelBusbuildupspeed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBusbuildupspeed.Location = new global::System.Drawing.Point(6, 52);
			this.labelBusbuildupspeed.Name = "labelBusbuildupspeed";
			this.labelBusbuildupspeed.Size = new global::System.Drawing.Size(109, 13);
			this.labelBusbuildupspeed.TabIndex = 229;
			this.labelBusbuildupspeed.Text = "Speed (Patient - Fast)";
			this.labelBusbuildupspeed.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBuspassing.AutoSize = true;
			this.labelBuspassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBuspassing.Location = new global::System.Drawing.Point(6, 76);
			this.labelBuspassing.Name = "labelBuspassing";
			this.labelBuspassing.Size = new global::System.Drawing.Size(105, 13);
			this.labelBuspassing.TabIndex = 230;
			this.labelBuspassing.Text = "Passing (Short-Long)";
			this.labelBuspassing.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericBusbuildupspeed.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "busbuildupspeed", true));
			this.numericBusbuildupspeed.Location = new global::System.Drawing.Point(161, 48);
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numericBusbuildupspeed;
			int[] array20 = new int[4];
			array20[0] = 1;
			numericUpDown20.Minimum = new decimal(array20);
			this.numericBusbuildupspeed.Name = "numericBusbuildupspeed";
			this.numericBusbuildupspeed.Size = new global::System.Drawing.Size(64, 20);
			this.numericBusbuildupspeed.TabIndex = 226;
			this.numericBusbuildupspeed.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numericBusbuildupspeed;
			int[] array21 = new int[4];
			array21[0] = 50;
			numericUpDown21.Value = new decimal(array21);
			this.numericBuspassing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "buspassing", true));
			this.numericBuspassing.Location = new global::System.Drawing.Point(161, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numericBuspassing;
			int[] array22 = new int[4];
			array22[0] = 1;
			numericUpDown22.Minimum = new decimal(array22);
			this.numericBuspassing.Name = "numericBuspassing";
			this.numericBuspassing.Size = new global::System.Drawing.Size(64, 20);
			this.numericBuspassing.TabIndex = 227;
			this.numericBuspassing.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numericBuspassing;
			int[] array23 = new int[4];
			array23[0] = 50;
			numericUpDown23.Value = new decimal(array23);
			this.comboBUSPositioning.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.teamBindingSource, "buspositioning", true));
			this.comboBUSPositioning.FormattingEnabled = true;
			this.comboBUSPositioning.Items.AddRange(new object[] { "Organized", "Free Form" });
			this.comboBUSPositioning.Location = new global::System.Drawing.Point(116, 21);
			this.comboBUSPositioning.Name = "comboBUSPositioning";
			this.comboBUSPositioning.Size = new global::System.Drawing.Size(109, 21);
			this.comboBUSPositioning.TabIndex = 228;
			this.comboBUSPositioning.SelectedIndexChanged += new global::System.EventHandler(this.comboBUSPositioning_SelectedIndexChanged);
			this.numericUpDown2.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "busdribbling", true));
			this.numericUpDown2.Location = new global::System.Drawing.Point(161, 96);
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numericUpDown2;
			int[] array24 = new int[4];
			array24[0] = 1;
			numericUpDown24.Minimum = new decimal(array24);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(64, 20);
			this.numericUpDown2.TabIndex = 250;
			this.numericUpDown2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.numericUpDown2;
			int[] array25 = new int[4];
			array25[0] = 50;
			numericUpDown25.Value = new decimal(array25);
			this.label20.AutoSize = true;
			this.label20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label20.Location = new global::System.Drawing.Point(6, 100);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(108, 13);
			this.label20.TabIndex = 251;
			this.label20.Text = "Dribbling (Little - Lots)";
			this.label20.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBox4.Controls.Add(this.labelDefdefendeline);
			this.groupBox4.Controls.Add(this.labelDefmentality);
			this.groupBox4.Controls.Add(this.labelDefaggression);
			this.groupBox4.Controls.Add(this.labelDefteamwidth);
			this.groupBox4.Controls.Add(this.numericDefmentality);
			this.groupBox4.Controls.Add(this.numericDefaggression);
			this.groupBox4.Controls.Add(this.numericDefteamwidth);
			this.groupBox4.Controls.Add(this.comboDEFLine);
			this.groupBox4.Location = new global::System.Drawing.Point(970, 493);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(230, 128);
			this.groupBox4.TabIndex = 270;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Defense";
			this.labelDefdefendeline.AutoSize = true;
			this.labelDefdefendeline.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDefdefendeline.Location = new global::System.Drawing.Point(6, 22);
			this.labelDefdefendeline.Name = "labelDefdefendeline";
			this.labelDefdefendeline.Size = new global::System.Drawing.Size(71, 13);
			this.labelDefdefendeline.TabIndex = 248;
			this.labelDefdefendeline.Text = "Defende Line";
			this.labelDefdefendeline.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDefmentality.AutoSize = true;
			this.labelDefmentality.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDefmentality.Location = new global::System.Drawing.Point(6, 49);
			this.labelDefmentality.Name = "labelDefmentality";
			this.labelDefmentality.Size = new global::System.Drawing.Size(104, 13);
			this.labelDefmentality.TabIndex = 245;
			this.labelDefmentality.Text = "Position (Deep-High)";
			this.labelDefmentality.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDefaggression.AutoSize = true;
			this.labelDefaggression.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDefaggression.Location = new global::System.Drawing.Point(6, 73);
			this.labelDefaggression.Name = "labelDefaggression";
			this.labelDefaggression.Size = new global::System.Drawing.Size(113, 13);
			this.labelDefaggression.TabIndex = 246;
			this.labelDefaggression.Text = "Aggression (Low-High)";
			this.labelDefaggression.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDefteamwidth.AutoSize = true;
			this.labelDefteamwidth.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDefteamwidth.Location = new global::System.Drawing.Point(6, 97);
			this.labelDefteamwidth.Name = "labelDefteamwidth";
			this.labelDefteamwidth.Size = new global::System.Drawing.Size(106, 13);
			this.labelDefteamwidth.TabIndex = 247;
			this.labelDefteamwidth.Text = "Width (Narrow-Wide)";
			this.labelDefteamwidth.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericDefmentality.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "defmentality", true));
			this.numericDefmentality.Location = new global::System.Drawing.Point(160, 47);
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.numericDefmentality;
			int[] array26 = new int[4];
			array26[0] = 1;
			numericUpDown26.Minimum = new decimal(array26);
			this.numericDefmentality.Name = "numericDefmentality";
			this.numericDefmentality.Size = new global::System.Drawing.Size(64, 20);
			this.numericDefmentality.TabIndex = 242;
			this.numericDefmentality.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.numericDefmentality;
			int[] array27 = new int[4];
			array27[0] = 50;
			numericUpDown27.Value = new decimal(array27);
			this.numericDefaggression.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "defaggression", true));
			this.numericDefaggression.Location = new global::System.Drawing.Point(160, 71);
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.numericDefaggression;
			int[] array28 = new int[4];
			array28[0] = 1;
			numericUpDown28.Minimum = new decimal(array28);
			this.numericDefaggression.Name = "numericDefaggression";
			this.numericDefaggression.Size = new global::System.Drawing.Size(64, 20);
			this.numericDefaggression.TabIndex = 243;
			this.numericDefaggression.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.numericDefaggression;
			int[] array29 = new int[4];
			array29[0] = 50;
			numericUpDown29.Value = new decimal(array29);
			this.numericDefteamwidth.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.teamBindingSource, "defteamwidth", true));
			this.numericDefteamwidth.Location = new global::System.Drawing.Point(160, 95);
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.numericDefteamwidth;
			int[] array30 = new int[4];
			array30[0] = 1;
			numericUpDown30.Minimum = new decimal(array30);
			this.numericDefteamwidth.Name = "numericDefteamwidth";
			this.numericDefteamwidth.Size = new global::System.Drawing.Size(64, 20);
			this.numericDefteamwidth.TabIndex = 244;
			this.numericDefteamwidth.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.numericDefteamwidth;
			int[] array31 = new int[4];
			array31[0] = 50;
			numericUpDown31.Value = new decimal(array31);
			this.comboDEFLine.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.teamBindingSource, "defdefenderline", true));
			this.comboDEFLine.FormattingEnabled = true;
			this.comboDEFLine.Items.AddRange(new object[] { "Cover", "Offside Trap" });
			this.comboDEFLine.Location = new global::System.Drawing.Point(102, 19);
			this.comboDEFLine.Name = "comboDEFLine";
			this.comboDEFLine.Size = new global::System.Drawing.Size(122, 21);
			this.comboDEFLine.TabIndex = 241;
			this.comboDEFLine.SelectedIndexChanged += new global::System.EventHandler(this.comboDEFLine_SelectedIndexChanged);
			this.labelRightFreeKickText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRightFreeKickText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRightFreeKickText.Location = new global::System.Drawing.Point(1213, 343);
			this.labelRightFreeKickText.Name = "labelRightFreeKickText";
			this.labelRightFreeKickText.Size = new global::System.Drawing.Size(85, 16);
			this.labelRightFreeKickText.TabIndex = 269;
			this.labelRightFreeKickText.Text = "Right Free Kick";
			this.labelRightFreeKickText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRightFreeKick.AllowDrop = true;
			this.labelRightFreeKick.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRightFreeKick.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelRightFreeKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelRightFreeKick.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelRightFreeKick.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelRightFreeKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRightFreeKick.Location = new global::System.Drawing.Point(1213, 359);
			this.labelRightFreeKick.Name = "labelRightFreeKick";
			this.labelRightFreeKick.Size = new global::System.Drawing.Size(85, 38);
			this.labelRightFreeKick.TabIndex = 268;
			this.labelRightFreeKick.Text = "Name";
			this.labelRightFreeKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRightFreeKick.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelRightFreeKick.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelLeftFreeKickText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLeftFreeKickText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeftFreeKickText.Location = new global::System.Drawing.Point(1213, 287);
			this.labelLeftFreeKickText.Name = "labelLeftFreeKickText";
			this.labelLeftFreeKickText.Size = new global::System.Drawing.Size(85, 16);
			this.labelLeftFreeKickText.TabIndex = 267;
			this.labelLeftFreeKickText.Text = "Left Free Kicks";
			this.labelLeftFreeKickText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLeftFreeKick.AllowDrop = true;
			this.labelLeftFreeKick.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLeftFreeKick.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLeftFreeKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelLeftFreeKick.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelLeftFreeKick.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelLeftFreeKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeftFreeKick.Location = new global::System.Drawing.Point(1213, 303);
			this.labelLeftFreeKick.Name = "labelLeftFreeKick";
			this.labelLeftFreeKick.Size = new global::System.Drawing.Size(85, 38);
			this.labelLeftFreeKick.TabIndex = 266;
			this.labelLeftFreeKick.Text = "Name";
			this.labelLeftFreeKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLeftFreeKick.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelLeftFreeKick.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.groupFormation.Controls.Add(this.labelTeamFormationName);
			this.groupFormation.Controls.Add(this.comboGenericFormations);
			this.groupFormation.Controls.Add(this.radioUseSpecificFormation);
			this.groupFormation.Controls.Add(this.radioUseGenericFormation);
			this.groupFormation.Location = new global::System.Drawing.Point(732, 493);
			this.groupFormation.Name = "groupFormation";
			this.groupFormation.Size = new global::System.Drawing.Size(232, 128);
			this.groupFormation.TabIndex = 265;
			this.groupFormation.TabStop = false;
			this.groupFormation.Text = "Formation";
			this.labelTeamFormationName.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelTeamFormationName.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelTeamFormationName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTeamFormationName.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelTeamFormationName.Location = new global::System.Drawing.Point(3, 16);
			this.labelTeamFormationName.Name = "labelTeamFormationName";
			this.labelTeamFormationName.Size = new global::System.Drawing.Size(226, 13);
			this.labelTeamFormationName.TabIndex = 130;
			this.labelTeamFormationName.Text = "Formation Name";
			this.labelTeamFormationName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTeamFormationName.DoubleClick += new global::System.EventHandler(this.labelTeamFormationName_DoubleClick);
			this.comboGenericFormations.FormattingEnabled = true;
			this.comboGenericFormations.Location = new global::System.Drawing.Point(11, 89);
			this.comboGenericFormations.Name = "comboGenericFormations";
			this.comboGenericFormations.Size = new global::System.Drawing.Size(211, 21);
			this.comboGenericFormations.TabIndex = 129;
			this.comboGenericFormations.SelectedIndexChanged += new global::System.EventHandler(this.comboGenericFormations_SelectedIndexChanged);
			this.radioUseSpecificFormation.AutoSize = true;
			this.radioUseSpecificFormation.Location = new global::System.Drawing.Point(6, 37);
			this.radioUseSpecificFormation.Name = "radioUseSpecificFormation";
			this.radioUseSpecificFormation.Size = new global::System.Drawing.Size(112, 17);
			this.radioUseSpecificFormation.TabIndex = 128;
			this.radioUseSpecificFormation.Text = "Specific Formation";
			this.radioUseSpecificFormation.UseVisualStyleBackColor = true;
			this.radioUseSpecificFormation.CheckedChanged += new global::System.EventHandler(this.radioUseSpecificFormation_CheckedChanged);
			this.radioUseGenericFormation.AutoSize = true;
			this.radioUseGenericFormation.Checked = true;
			this.radioUseGenericFormation.Enabled = false;
			this.radioUseGenericFormation.Location = new global::System.Drawing.Point(6, 55);
			this.radioUseGenericFormation.Name = "radioUseGenericFormation";
			this.radioUseGenericFormation.Size = new global::System.Drawing.Size(108, 17);
			this.radioUseGenericFormation.TabIndex = 127;
			this.radioUseGenericFormation.TabStop = true;
			this.radioUseGenericFormation.Text = "Generic formation";
			this.toolTip.SetToolTip(this.radioUseGenericFormation, "A Team cannot have a generic formation.");
			this.radioUseGenericFormation.UseVisualStyleBackColor = true;
			this.radioUseGenericFormation.CheckedChanged += new global::System.EventHandler(this.radioUseGenericFormation_CheckedChanged);
			this.labelLongKick.AllowDrop = true;
			this.labelLongKick.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLongKick.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLongKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelLongKick.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelLongKick.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelLongKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLongKick.Location = new global::System.Drawing.Point(1213, 247);
			this.labelLongKick.Name = "labelLongKick";
			this.labelLongKick.Size = new global::System.Drawing.Size(85, 38);
			this.labelLongKick.TabIndex = 264;
			this.labelLongKick.Text = "Name";
			this.labelLongKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLongKick.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelLongKick.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelLomgKickText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLomgKickText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLomgKickText.Location = new global::System.Drawing.Point(1213, 231);
			this.labelLomgKickText.Name = "labelLomgKickText";
			this.labelLomgKickText.Size = new global::System.Drawing.Size(85, 16);
			this.labelLomgKickText.TabIndex = 263;
			this.labelLomgKickText.Text = "Long Kicks";
			this.labelLomgKickText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRightCornerText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRightCornerText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRightCornerText.Location = new global::System.Drawing.Point(1213, 118);
			this.labelRightCornerText.Name = "labelRightCornerText";
			this.labelRightCornerText.Size = new global::System.Drawing.Size(85, 16);
			this.labelRightCornerText.TabIndex = 262;
			this.labelRightCornerText.Text = "Right Corner";
			this.labelRightCornerText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCaptainTetx.BackColor = global::System.Drawing.Color.Transparent;
			this.labelCaptainTetx.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCaptainTetx.Location = new global::System.Drawing.Point(1213, 2);
			this.labelCaptainTetx.Name = "labelCaptainTetx";
			this.labelCaptainTetx.Size = new global::System.Drawing.Size(85, 16);
			this.labelCaptainTetx.TabIndex = 253;
			this.labelCaptainTetx.Text = "Captain";
			this.labelCaptainTetx.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLeftCornertext.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLeftCornertext.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeftCornertext.Location = new global::System.Drawing.Point(1213, 60);
			this.labelLeftCornertext.Name = "labelLeftCornertext";
			this.labelLeftCornertext.Size = new global::System.Drawing.Size(85, 16);
			this.labelLeftCornertext.TabIndex = 261;
			this.labelLeftCornertext.Text = "Left Corner";
			this.labelLeftCornertext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRightCorner.AllowDrop = true;
			this.labelRightCorner.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRightCorner.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelRightCorner.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelRightCorner.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelRightCorner.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelRightCorner.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRightCorner.Location = new global::System.Drawing.Point(1213, 134);
			this.labelRightCorner.Name = "labelRightCorner";
			this.labelRightCorner.Size = new global::System.Drawing.Size(85, 38);
			this.labelRightCorner.TabIndex = 258;
			this.labelRightCorner.Text = "Name";
			this.labelRightCorner.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelRightCorner.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelRightCorner.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelCaptain.AllowDrop = true;
			this.labelCaptain.BackColor = global::System.Drawing.Color.Transparent;
			this.labelCaptain.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelCaptain.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelCaptain.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCaptain.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelCaptain.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCaptain.Location = new global::System.Drawing.Point(1213, 18);
			this.labelCaptain.Name = "labelCaptain";
			this.labelCaptain.Size = new global::System.Drawing.Size(85, 38);
			this.labelCaptain.TabIndex = 254;
			this.labelCaptain.Text = "Name";
			this.labelCaptain.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCaptain.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelCaptain.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelLeftCorner.AllowDrop = true;
			this.labelLeftCorner.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLeftCorner.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelLeftCorner.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelLeftCorner.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelLeftCorner.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelLeftCorner.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeftCorner.Location = new global::System.Drawing.Point(1213, 76);
			this.labelLeftCorner.Name = "labelLeftCorner";
			this.labelLeftCorner.Size = new global::System.Drawing.Size(85, 38);
			this.labelLeftCorner.TabIndex = 257;
			this.labelLeftCorner.Text = "Name";
			this.labelLeftCorner.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLeftCorner.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelLeftCorner.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelFreeKickText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelFreeKickText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFreeKickText.Location = new global::System.Drawing.Point(1213, 401);
			this.labelFreeKickText.Name = "labelFreeKickText";
			this.labelFreeKickText.Size = new global::System.Drawing.Size(85, 16);
			this.labelFreeKickText.TabIndex = 260;
			this.labelFreeKickText.Text = "Free Kicks";
			this.labelFreeKickText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPenaltyText.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPenaltyText.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenaltyText.Location = new global::System.Drawing.Point(1213, 175);
			this.labelPenaltyText.Name = "labelPenaltyText";
			this.labelPenaltyText.Size = new global::System.Drawing.Size(85, 16);
			this.labelPenaltyText.TabIndex = 259;
			this.labelPenaltyText.Text = "Penalty";
			this.labelPenaltyText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPenalty.AllowDrop = true;
			this.labelPenalty.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPenalty.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPenalty.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelPenalty.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPenalty.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelPenalty.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenalty.Location = new global::System.Drawing.Point(1213, 191);
			this.labelPenalty.Name = "labelPenalty";
			this.labelPenalty.Size = new global::System.Drawing.Size(85, 38);
			this.labelPenalty.TabIndex = 255;
			this.labelPenalty.Text = "Name";
			this.labelPenalty.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPenalty.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelPenalty.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.labelFreeKick.AllowDrop = true;
			this.labelFreeKick.BackColor = global::System.Drawing.Color.Transparent;
			this.labelFreeKick.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelFreeKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelFreeKick.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelFreeKick.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelFreeKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFreeKick.Location = new global::System.Drawing.Point(1214, 417);
			this.labelFreeKick.Name = "labelFreeKick";
			this.labelFreeKick.Size = new global::System.Drawing.Size(85, 38);
			this.labelFreeKick.TabIndex = 256;
			this.labelFreeKick.Text = "Name";
			this.labelFreeKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFreeKick.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragDrop);
			this.labelFreeKick.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelSpecial_DragEnter);
			this.panel1.BackColor = global::System.Drawing.SystemColors.Control;
			this.panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.labelPos33U);
			this.panel1.Controls.Add(this.labelPos33T);
			this.panel1.Controls.Add(this.labelPos33S);
			this.panel1.Controls.Add(this.labelPos33R);
			this.panel1.Controls.Add(this.labelPos33Q);
			this.panel1.Controls.Add(this.labelPos33O);
			this.panel1.Controls.Add(this.labelPos33P);
			this.panel1.Controls.Add(this.labelPos33N);
			this.panel1.Controls.Add(this.labelPos33M);
			this.panel1.Controls.Add(this.labelPos33L);
			this.panel1.Controls.Add(this.labelPos33K);
			this.panel1.Controls.Add(this.labelPos33J);
			this.panel1.Controls.Add(this.labelPos33H);
			this.panel1.Controls.Add(this.labelPos33I);
			this.panel1.Controls.Add(this.labelPos33G);
			this.panel1.Controls.Add(this.labelPos33F);
			this.panel1.Controls.Add(this.labelPos33E);
			this.panel1.Controls.Add(this.labelPos33D);
			this.panel1.Controls.Add(this.labelPos33C);
			this.panel1.Controls.Add(this.labelPos33A);
			this.panel1.Controls.Add(this.labelPos33B);
			this.panel1.Controls.Add(this.labelPos32G);
			this.panel1.Controls.Add(this.labelPos32F);
			this.panel1.Controls.Add(this.labelPos32E);
			this.panel1.Controls.Add(this.labelPos32D);
			this.panel1.Controls.Add(this.labelPos32C);
			this.panel1.Controls.Add(this.labelPos32A);
			this.panel1.Controls.Add(this.labelPos32B);
			this.panel1.Controls.Add(this.labelPos26);
			this.panel1.Controls.Add(this.labelPos27);
			this.panel1.Controls.Add(this.labelPos21);
			this.panel1.Controls.Add(this.labelPos22);
			this.panel1.Controls.Add(this.labelPos23);
			this.panel1.Controls.Add(this.labelPos24);
			this.panel1.Controls.Add(this.labelPos25);
			this.panel1.Controls.Add(this.labelPos14);
			this.panel1.Controls.Add(this.labelPos15);
			this.panel1.Controls.Add(this.labelPos16);
			this.panel1.Controls.Add(this.labelPos17);
			this.panel1.Controls.Add(this.labelPos18);
			this.panel1.Controls.Add(this.labelPos20);
			this.panel1.Controls.Add(this.labelPos19);
			this.panel1.Controls.Add(this.labelPos9);
			this.panel1.Controls.Add(this.labelPos10);
			this.panel1.Controls.Add(this.labelPos11);
			this.panel1.Controls.Add(this.labelPos12);
			this.panel1.Controls.Add(this.labelPos13);
			this.panel1.Controls.Add(this.labelPos2);
			this.panel1.Controls.Add(this.labelPos3);
			this.panel1.Controls.Add(this.labelPos4);
			this.panel1.Controls.Add(this.labelPos5);
			this.panel1.Controls.Add(this.labelPos6);
			this.panel1.Controls.Add(this.labelPos8);
			this.panel1.Controls.Add(this.labelPos7);
			this.panel1.Controls.Add(this.labelPos0);
			this.panel1.Controls.Add(this.labelPos1);
			this.panel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.panel1.Location = new global::System.Drawing.Point(732, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(477, 484);
			this.panel1.TabIndex = 150;
			this.labelPos33U.AllowDrop = true;
			this.labelPos33U.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33U.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33U.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33U.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33U.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33U.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33U.Location = new global::System.Drawing.Point(407, 437);
			this.labelPos33U.Name = "labelPos33U";
			this.labelPos33U.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33U.TabIndex = 59;
			this.labelPos33U.Text = "Tribune";
			this.labelPos33U.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33U.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33U.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33U.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33T.AllowDrop = true;
			this.labelPos33T.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33T.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33T.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33T.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33T.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33T.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33T.Location = new global::System.Drawing.Point(339, 437);
			this.labelPos33T.Name = "labelPos33T";
			this.labelPos33T.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33T.TabIndex = 58;
			this.labelPos33T.Text = "Tribune";
			this.labelPos33T.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33T.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33T.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33T.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33S.AllowDrop = true;
			this.labelPos33S.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33S.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33S.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33S.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33S.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33S.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33S.Location = new global::System.Drawing.Point(271, 437);
			this.labelPos33S.Name = "labelPos33S";
			this.labelPos33S.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33S.TabIndex = 57;
			this.labelPos33S.Text = "Tribune";
			this.labelPos33S.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33S.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33S.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33S.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33R.AllowDrop = true;
			this.labelPos33R.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33R.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33R.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33R.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33R.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33R.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33R.Location = new global::System.Drawing.Point(203, 437);
			this.labelPos33R.Name = "labelPos33R";
			this.labelPos33R.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33R.TabIndex = 56;
			this.labelPos33R.Text = "Tribune";
			this.labelPos33R.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33R.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33R.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33R.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33Q.AllowDrop = true;
			this.labelPos33Q.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33Q.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33Q.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33Q.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33Q.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33Q.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33Q.Location = new global::System.Drawing.Point(135, 437);
			this.labelPos33Q.Name = "labelPos33Q";
			this.labelPos33Q.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33Q.TabIndex = 55;
			this.labelPos33Q.Text = "Tribune";
			this.labelPos33Q.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33Q.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33Q.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33Q.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33O.AllowDrop = true;
			this.labelPos33O.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33O.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33O.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33O.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33O.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33O.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33O.Location = new global::System.Drawing.Point(-1, 437);
			this.labelPos33O.Name = "labelPos33O";
			this.labelPos33O.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33O.TabIndex = 54;
			this.labelPos33O.Text = "Tribune";
			this.labelPos33O.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33O.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33O.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33O.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33P.AllowDrop = true;
			this.labelPos33P.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33P.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33P.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33P.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33P.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33P.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33P.Location = new global::System.Drawing.Point(67, 437);
			this.labelPos33P.Name = "labelPos33P";
			this.labelPos33P.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33P.TabIndex = 53;
			this.labelPos33P.Text = "Tribune";
			this.labelPos33P.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33P.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33P.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33P.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33N.AllowDrop = true;
			this.labelPos33N.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33N.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33N.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33N.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33N.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33N.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33N.Location = new global::System.Drawing.Point(407, 397);
			this.labelPos33N.Name = "labelPos33N";
			this.labelPos33N.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33N.TabIndex = 52;
			this.labelPos33N.Text = "Tribune";
			this.labelPos33N.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33N.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33N.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33N.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33M.AllowDrop = true;
			this.labelPos33M.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33M.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33M.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33M.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33M.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33M.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33M.Location = new global::System.Drawing.Point(339, 397);
			this.labelPos33M.Name = "labelPos33M";
			this.labelPos33M.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33M.TabIndex = 51;
			this.labelPos33M.Text = "Tribune";
			this.labelPos33M.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33M.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33M.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33M.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33L.AllowDrop = true;
			this.labelPos33L.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33L.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33L.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33L.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33L.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33L.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33L.Location = new global::System.Drawing.Point(271, 397);
			this.labelPos33L.Name = "labelPos33L";
			this.labelPos33L.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33L.TabIndex = 50;
			this.labelPos33L.Text = "Tribune";
			this.labelPos33L.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33L.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33L.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33L.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33K.AllowDrop = true;
			this.labelPos33K.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33K.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33K.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33K.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33K.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33K.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33K.Location = new global::System.Drawing.Point(203, 397);
			this.labelPos33K.Name = "labelPos33K";
			this.labelPos33K.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33K.TabIndex = 49;
			this.labelPos33K.Text = "Tribune";
			this.labelPos33K.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33K.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33K.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33K.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33J.AllowDrop = true;
			this.labelPos33J.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33J.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33J.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33J.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33J.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33J.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33J.Location = new global::System.Drawing.Point(135, 397);
			this.labelPos33J.Name = "labelPos33J";
			this.labelPos33J.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33J.TabIndex = 48;
			this.labelPos33J.Text = "Tribune";
			this.labelPos33J.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33J.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33J.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33J.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33H.AllowDrop = true;
			this.labelPos33H.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33H.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33H.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33H.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33H.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33H.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33H.Location = new global::System.Drawing.Point(-1, 397);
			this.labelPos33H.Name = "labelPos33H";
			this.labelPos33H.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33H.TabIndex = 47;
			this.labelPos33H.Text = "Tribune";
			this.labelPos33H.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33H.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33H.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33H.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33I.AllowDrop = true;
			this.labelPos33I.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33I.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33I.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33I.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33I.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33I.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33I.Location = new global::System.Drawing.Point(67, 397);
			this.labelPos33I.Name = "labelPos33I";
			this.labelPos33I.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33I.TabIndex = 46;
			this.labelPos33I.Text = "Tribune";
			this.labelPos33I.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33I.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33I.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33I.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33G.AllowDrop = true;
			this.labelPos33G.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33G.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33G.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33G.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33G.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33G.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33G.Location = new global::System.Drawing.Point(407, 357);
			this.labelPos33G.Name = "labelPos33G";
			this.labelPos33G.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33G.TabIndex = 45;
			this.labelPos33G.Text = "Tribune";
			this.labelPos33G.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33G.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33G.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33G.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33F.AllowDrop = true;
			this.labelPos33F.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33F.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33F.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33F.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33F.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33F.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33F.Location = new global::System.Drawing.Point(339, 357);
			this.labelPos33F.Name = "labelPos33F";
			this.labelPos33F.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33F.TabIndex = 44;
			this.labelPos33F.Text = "Tribune";
			this.labelPos33F.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33F.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33F.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33F.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33E.AllowDrop = true;
			this.labelPos33E.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33E.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33E.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33E.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33E.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33E.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33E.Location = new global::System.Drawing.Point(271, 357);
			this.labelPos33E.Name = "labelPos33E";
			this.labelPos33E.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33E.TabIndex = 43;
			this.labelPos33E.Text = "Tribune";
			this.labelPos33E.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33E.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33E.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33E.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33D.AllowDrop = true;
			this.labelPos33D.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33D.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33D.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33D.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33D.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33D.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33D.Location = new global::System.Drawing.Point(203, 357);
			this.labelPos33D.Name = "labelPos33D";
			this.labelPos33D.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33D.TabIndex = 42;
			this.labelPos33D.Text = "Tribune";
			this.labelPos33D.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33D.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33D.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33D.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33C.AllowDrop = true;
			this.labelPos33C.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33C.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33C.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33C.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33C.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33C.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33C.Location = new global::System.Drawing.Point(135, 357);
			this.labelPos33C.Name = "labelPos33C";
			this.labelPos33C.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33C.TabIndex = 41;
			this.labelPos33C.Text = "Tribune";
			this.labelPos33C.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33C.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33C.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33C.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33A.AllowDrop = true;
			this.labelPos33A.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33A.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33A.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33A.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33A.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33A.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33A.Location = new global::System.Drawing.Point(-1, 357);
			this.labelPos33A.Name = "labelPos33A";
			this.labelPos33A.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33A.TabIndex = 40;
			this.labelPos33A.Text = "Tribune";
			this.labelPos33A.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33A.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33A.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33A.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos33B.AllowDrop = true;
			this.labelPos33B.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos33B.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos33B.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos33B.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos33B.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos33B.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos33B.Location = new global::System.Drawing.Point(67, 357);
			this.labelPos33B.Name = "labelPos33B";
			this.labelPos33B.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos33B.TabIndex = 39;
			this.labelPos33B.Text = "Tribune";
			this.labelPos33B.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos33B.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos33B.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos33B.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32G.AllowDrop = true;
			this.labelPos32G.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32G.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32G.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32G.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32G.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32G.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32G.Location = new global::System.Drawing.Point(407, 313);
			this.labelPos32G.Name = "labelPos32G";
			this.labelPos32G.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32G.TabIndex = 38;
			this.labelPos32G.Text = "Bench";
			this.labelPos32G.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32G.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32G.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32G.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32F.AllowDrop = true;
			this.labelPos32F.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32F.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32F.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32F.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32F.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32F.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32F.Location = new global::System.Drawing.Point(339, 313);
			this.labelPos32F.Name = "labelPos32F";
			this.labelPos32F.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32F.TabIndex = 37;
			this.labelPos32F.Text = "Bench";
			this.labelPos32F.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32F.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32F.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32F.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32E.AllowDrop = true;
			this.labelPos32E.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32E.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32E.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32E.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32E.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32E.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32E.Location = new global::System.Drawing.Point(271, 313);
			this.labelPos32E.Name = "labelPos32E";
			this.labelPos32E.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32E.TabIndex = 36;
			this.labelPos32E.Text = "Bench";
			this.labelPos32E.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32E.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32E.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32E.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32D.AllowDrop = true;
			this.labelPos32D.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32D.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32D.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32D.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32D.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32D.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32D.Location = new global::System.Drawing.Point(203, 313);
			this.labelPos32D.Name = "labelPos32D";
			this.labelPos32D.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32D.TabIndex = 35;
			this.labelPos32D.Text = "Bench";
			this.labelPos32D.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32D.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32D.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32D.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32C.AllowDrop = true;
			this.labelPos32C.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32C.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32C.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32C.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32C.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32C.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32C.Location = new global::System.Drawing.Point(135, 313);
			this.labelPos32C.Name = "labelPos32C";
			this.labelPos32C.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32C.TabIndex = 34;
			this.labelPos32C.Text = "Bench";
			this.labelPos32C.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32C.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32C.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32C.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32A.AllowDrop = true;
			this.labelPos32A.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32A.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32A.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32A.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32A.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32A.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32A.Location = new global::System.Drawing.Point(-1, 313);
			this.labelPos32A.Name = "labelPos32A";
			this.labelPos32A.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32A.TabIndex = 33;
			this.labelPos32A.Text = "Bench";
			this.labelPos32A.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32A.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32A.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32A.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos32B.AllowDrop = true;
			this.labelPos32B.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos32B.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos32B.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos32B.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos32B.ForeColor = global::System.Drawing.Color.Black;
			this.labelPos32B.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos32B.Location = new global::System.Drawing.Point(67, 313);
			this.labelPos32B.Name = "labelPos32B";
			this.labelPos32B.Size = new global::System.Drawing.Size(68, 40);
			this.labelPos32B.TabIndex = 32;
			this.labelPos32B.Text = "Bench";
			this.labelPos32B.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos32B.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos32B.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos32B.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos26.AllowDrop = true;
			this.labelPos26.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos26.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos26.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos26.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos26.ForeColor = global::System.Drawing.Color.White;
			this.labelPos26.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos26.Location = new global::System.Drawing.Point(286, 264);
			this.labelPos26.Name = "labelPos26";
			this.labelPos26.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos26.TabIndex = 28;
			this.labelPos26.Text = "LS";
			this.labelPos26.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos26.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos26.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos26.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos27.AllowDrop = true;
			this.labelPos27.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos27.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos27.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos27.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos27.ForeColor = global::System.Drawing.Color.White;
			this.labelPos27.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos27.Location = new global::System.Drawing.Point(380, 249);
			this.labelPos27.Name = "labelPos27";
			this.labelPos27.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos27.TabIndex = 27;
			this.labelPos27.Text = "LW";
			this.labelPos27.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos27.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos27.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos27.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos21.AllowDrop = true;
			this.labelPos21.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos21.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos21.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos21.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos21.ForeColor = global::System.Drawing.Color.White;
			this.labelPos21.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos21.Location = new global::System.Drawing.Point(191, 228);
			this.labelPos21.Name = "labelPos21";
			this.labelPos21.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos21.TabIndex = 25;
			this.labelPos21.Text = "CF";
			this.labelPos21.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos21.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos21.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos21.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos22.AllowDrop = true;
			this.labelPos22.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos22.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos22.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos22.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos22.ForeColor = global::System.Drawing.Color.White;
			this.labelPos22.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos22.Location = new global::System.Drawing.Point(286, 230);
			this.labelPos22.Name = "labelPos22";
			this.labelPos22.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos22.TabIndex = 24;
			this.labelPos22.Text = "LF";
			this.labelPos22.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos22.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos22.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos22.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos23.AllowDrop = true;
			this.labelPos23.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos23.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos23.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos23.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos23.ForeColor = global::System.Drawing.Color.White;
			this.labelPos23.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos23.Location = new global::System.Drawing.Point(1, 249);
			this.labelPos23.Name = "labelPos23";
			this.labelPos23.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos23.TabIndex = 23;
			this.labelPos23.Text = "RW";
			this.labelPos23.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos23.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos23.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos23.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos24.AllowDrop = true;
			this.labelPos24.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos24.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos24.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos24.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos24.ForeColor = global::System.Drawing.Color.White;
			this.labelPos24.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos24.Location = new global::System.Drawing.Point(96, 264);
			this.labelPos24.Name = "labelPos24";
			this.labelPos24.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos24.TabIndex = 22;
			this.labelPos24.Text = "RS";
			this.labelPos24.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos24.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos24.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos24.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos25.AllowDrop = true;
			this.labelPos25.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos25.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos25.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos25.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos25.ForeColor = global::System.Drawing.Color.White;
			this.labelPos25.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos25.Location = new global::System.Drawing.Point(191, 264);
			this.labelPos25.Name = "labelPos25";
			this.labelPos25.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos25.TabIndex = 21;
			this.labelPos25.Text = "ST";
			this.labelPos25.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos25.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos25.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos25.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos14.AllowDrop = true;
			this.labelPos14.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos14.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos14.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos14.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos14.ForeColor = global::System.Drawing.Color.White;
			this.labelPos14.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos14.Location = new global::System.Drawing.Point(191, 150);
			this.labelPos14.Name = "labelPos14";
			this.labelPos14.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos14.TabIndex = 20;
			this.labelPos14.Text = "CM";
			this.labelPos14.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos14.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos14.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos14.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos15.AllowDrop = true;
			this.labelPos15.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos15.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos15.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos15.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos15.ForeColor = global::System.Drawing.Color.White;
			this.labelPos15.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos15.Location = new global::System.Drawing.Point(286, 150);
			this.labelPos15.Name = "labelPos15";
			this.labelPos15.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos15.TabIndex = 19;
			this.labelPos15.Text = "LCM";
			this.labelPos15.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos15.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos15.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos15.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos16.AllowDrop = true;
			this.labelPos16.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos16.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos16.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos16.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos16.ForeColor = global::System.Drawing.Color.White;
			this.labelPos16.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos16.Location = new global::System.Drawing.Point(381, 151);
			this.labelPos16.Name = "labelPos16";
			this.labelPos16.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos16.TabIndex = 18;
			this.labelPos16.Text = "LM";
			this.labelPos16.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos16.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos16.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos16.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos17.AllowDrop = true;
			this.labelPos17.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos17.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos17.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos17.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos17.ForeColor = global::System.Drawing.Color.White;
			this.labelPos17.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos17.Location = new global::System.Drawing.Point(56, 190);
			this.labelPos17.Name = "labelPos17";
			this.labelPos17.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos17.TabIndex = 17;
			this.labelPos17.Text = "RAM";
			this.labelPos17.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos17.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos17.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos17.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos18.AllowDrop = true;
			this.labelPos18.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos18.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos18.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos18.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos18.ForeColor = global::System.Drawing.Color.White;
			this.labelPos18.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos18.Location = new global::System.Drawing.Point(191, 188);
			this.labelPos18.Name = "labelPos18";
			this.labelPos18.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos18.TabIndex = 16;
			this.labelPos18.Text = "CAM";
			this.labelPos18.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos18.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos18.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos18.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos20.AllowDrop = true;
			this.labelPos20.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos20.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos20.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos20.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos20.ForeColor = global::System.Drawing.Color.White;
			this.labelPos20.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos20.Location = new global::System.Drawing.Point(96, 228);
			this.labelPos20.Name = "labelPos20";
			this.labelPos20.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos20.TabIndex = 15;
			this.labelPos20.Text = "RF";
			this.labelPos20.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos20.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos20.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos20.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos19.AllowDrop = true;
			this.labelPos19.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos19.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos19.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos19.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos19.ForeColor = global::System.Drawing.Color.White;
			this.labelPos19.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos19.Location = new global::System.Drawing.Point(326, 190);
			this.labelPos19.Name = "labelPos19";
			this.labelPos19.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos19.TabIndex = 14;
			this.labelPos19.Text = "LAM";
			this.labelPos19.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos19.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos19.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos19.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos9.AllowDrop = true;
			this.labelPos9.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos9.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos9.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos9.ForeColor = global::System.Drawing.Color.White;
			this.labelPos9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos9.Location = new global::System.Drawing.Point(96, 110);
			this.labelPos9.Name = "labelPos9";
			this.labelPos9.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos9.TabIndex = 13;
			this.labelPos9.Text = "RDM";
			this.labelPos9.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos9.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos9.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos9.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos10.AllowDrop = true;
			this.labelPos10.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos10.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos10.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos10.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos10.ForeColor = global::System.Drawing.Color.White;
			this.labelPos10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos10.Location = new global::System.Drawing.Point(191, 110);
			this.labelPos10.Name = "labelPos10";
			this.labelPos10.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos10.TabIndex = 12;
			this.labelPos10.Text = "CDM";
			this.labelPos10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos10.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos10.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos10.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos11.AllowDrop = true;
			this.labelPos11.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos11.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos11.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos11.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos11.ForeColor = global::System.Drawing.Color.White;
			this.labelPos11.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos11.Location = new global::System.Drawing.Point(286, 110);
			this.labelPos11.Name = "labelPos11";
			this.labelPos11.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos11.TabIndex = 11;
			this.labelPos11.Text = "LDM";
			this.labelPos11.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos11.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos11.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos11.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos12.AllowDrop = true;
			this.labelPos12.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos12.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos12.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos12.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos12.ForeColor = global::System.Drawing.Color.White;
			this.labelPos12.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos12.Location = new global::System.Drawing.Point(1, 150);
			this.labelPos12.Name = "labelPos12";
			this.labelPos12.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos12.TabIndex = 10;
			this.labelPos12.Text = "RM";
			this.labelPos12.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos12.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos12.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos12.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos13.AllowDrop = true;
			this.labelPos13.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos13.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos13.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos13.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos13.ForeColor = global::System.Drawing.Color.White;
			this.labelPos13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos13.Location = new global::System.Drawing.Point(96, 150);
			this.labelPos13.Name = "labelPos13";
			this.labelPos13.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos13.TabIndex = 9;
			this.labelPos13.Text = "RCM";
			this.labelPos13.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos13.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos13.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos13.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos2.AllowDrop = true;
			this.labelPos2.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos2.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos2.ForeColor = global::System.Drawing.Color.White;
			this.labelPos2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos2.Location = new global::System.Drawing.Point(1, 95);
			this.labelPos2.Name = "labelPos2";
			this.labelPos2.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos2.TabIndex = 8;
			this.labelPos2.Text = "RWB";
			this.labelPos2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos2.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos2.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos3.AllowDrop = true;
			this.labelPos3.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos3.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos3.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos3.ForeColor = global::System.Drawing.Color.White;
			this.labelPos3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos3.Location = new global::System.Drawing.Point(1, 70);
			this.labelPos3.Name = "labelPos3";
			this.labelPos3.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos3.TabIndex = 7;
			this.labelPos3.Text = "RB";
			this.labelPos3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos3.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos3.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos3.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos4.AllowDrop = true;
			this.labelPos4.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos4.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos4.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos4.ForeColor = global::System.Drawing.Color.White;
			this.labelPos4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos4.Location = new global::System.Drawing.Point(96, 70);
			this.labelPos4.Name = "labelPos4";
			this.labelPos4.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos4.TabIndex = 6;
			this.labelPos4.Text = "RCB";
			this.labelPos4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos4.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos4.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos4.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos5.AllowDrop = true;
			this.labelPos5.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos5.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos5.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos5.ForeColor = global::System.Drawing.Color.White;
			this.labelPos5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos5.Location = new global::System.Drawing.Point(191, 70);
			this.labelPos5.Name = "labelPos5";
			this.labelPos5.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos5.TabIndex = 5;
			this.labelPos5.Text = "CB";
			this.labelPos5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos5.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos5.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos5.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos6.AllowDrop = true;
			this.labelPos6.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos6.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos6.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos6.ForeColor = global::System.Drawing.Color.White;
			this.labelPos6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos6.Location = new global::System.Drawing.Point(286, 70);
			this.labelPos6.Name = "labelPos6";
			this.labelPos6.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos6.TabIndex = 4;
			this.labelPos6.Text = "LCB";
			this.labelPos6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos6.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos6.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos6.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos8.AllowDrop = true;
			this.labelPos8.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos8.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos8.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos8.ForeColor = global::System.Drawing.Color.White;
			this.labelPos8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos8.Location = new global::System.Drawing.Point(381, 95);
			this.labelPos8.Name = "labelPos8";
			this.labelPos8.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos8.TabIndex = 3;
			this.labelPos8.Text = "LWB";
			this.labelPos8.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos8.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos8.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos8.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos7.AllowDrop = true;
			this.labelPos7.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos7.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos7.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos7.ForeColor = global::System.Drawing.Color.White;
			this.labelPos7.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos7.Location = new global::System.Drawing.Point(381, 70);
			this.labelPos7.Name = "labelPos7";
			this.labelPos7.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos7.TabIndex = 2;
			this.labelPos7.Text = "LB";
			this.labelPos7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos7.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos7.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos7.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos0.AllowDrop = true;
			this.labelPos0.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.labelPos0.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos0.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos0.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos0.ForeColor = global::System.Drawing.Color.White;
			this.labelPos0.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos0.Location = new global::System.Drawing.Point(191, 0);
			this.labelPos0.Name = "labelPos0";
			this.labelPos0.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos0.TabIndex = 0;
			this.labelPos0.Text = "GK";
			this.labelPos0.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPos0.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragDrop);
			this.labelPos0.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.labelPos_DragEnter);
			this.labelPos0.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.labelPos_MouseDown);
			this.labelPos1.AllowDrop = true;
			this.labelPos1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.labelPos1.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPos1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelPos1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPos1.ForeColor = global::System.Drawing.Color.White;
			this.labelPos1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPos1.Location = new global::System.Drawing.Point(191, 40);
			this.labelPos1.Name = "labelPos1";
			this.labelPos1.Size = new global::System.Drawing.Size(95, 40);
			this.labelPos1.TabIndex = 1;
			this.labelPos1.Text = "SW";
			this.labelPos1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.groupAvailablePlayers.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupAvailablePlayers.Controls.Add(this.listViewPlayersAvailable);
			this.groupAvailablePlayers.Controls.Add(this.panelAvailablePlayersTop);
			this.groupAvailablePlayers.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.groupAvailablePlayers.Location = new global::System.Drawing.Point(388, 3);
			this.groupAvailablePlayers.Name = "groupAvailablePlayers";
			this.groupAvailablePlayers.Size = new global::System.Drawing.Size(341, 775);
			this.groupAvailablePlayers.TabIndex = 3;
			this.groupAvailablePlayers.TabStop = false;
			this.groupAvailablePlayers.Text = "Available Players";
			this.listViewPlayersAvailable.AllowColumnReorder = true;
			this.listViewPlayersAvailable.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4 });
			this.listViewPlayersAvailable.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listViewPlayersAvailable.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPlayersAvailable.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.listViewPlayersAvailable.FullRowSelect = true;
			this.listViewPlayersAvailable.GridLines = true;
			this.listViewPlayersAvailable.HideSelection = false;
			this.listViewPlayersAvailable.Location = new global::System.Drawing.Point(3, 231);
			this.listViewPlayersAvailable.MultiSelect = false;
			this.listViewPlayersAvailable.Name = "listViewPlayersAvailable";
			this.listViewPlayersAvailable.Size = new global::System.Drawing.Size(335, 541);
			this.listViewPlayersAvailable.TabIndex = 4;
			this.listViewPlayersAvailable.UseCompatibleStateImageBehavior = false;
			this.listViewPlayersAvailable.View = global::System.Windows.Forms.View.Details;
			this.listViewPlayersAvailable.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
			this.listViewPlayersAvailable.SelectedIndexChanged += new global::System.EventHandler(this.listViewPlayersAvailable_SelectedIndexChanged);
			this.listViewPlayersAvailable.DoubleClick += new global::System.EventHandler(this.listViewPlayersAvailable_DoubleClick);
			this.columnHeader1.Text = "Surname";
			this.columnHeader1.Width = 108;
			this.columnHeader2.Text = "First Name";
			this.columnHeader2.Width = 108;
			this.columnHeader3.Text = "Role";
			this.columnHeader3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 42;
			this.columnHeader4.Text = "Avg.";
			this.columnHeader4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 42;
			this.panelAvailablePlayersTop.BackColor = global::System.Drawing.Color.Transparent;
			this.panelAvailablePlayersTop.Controls.Add(this.buttonDeletePlayer);
			this.panelAvailablePlayersTop.Controls.Add(this.buttonLoanFrom);
			this.panelAvailablePlayersTop.Controls.Add(this.label4);
			this.panelAvailablePlayersTop.Controls.Add(this.dateTransferPreset);
			this.panelAvailablePlayersTop.Controls.Add(this.buttonTransferFrom);
			this.panelAvailablePlayersTop.Controls.Add(this.pickUpAvailablePlayers);
			this.panelAvailablePlayersTop.Controls.Add(this.buttonCall);
			this.panelAvailablePlayersTop.Controls.Add(this.labelAvailablePlayerStars);
			this.panelAvailablePlayersTop.Controls.Add(this.pictureAvailablePlayer);
			this.panelAvailablePlayersTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelAvailablePlayersTop.Location = new global::System.Drawing.Point(3, 16);
			this.panelAvailablePlayersTop.Name = "panelAvailablePlayersTop";
			this.panelAvailablePlayersTop.Size = new global::System.Drawing.Size(335, 215);
			this.panelAvailablePlayersTop.TabIndex = 149;
			this.buttonDeletePlayer.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonDeletePlayer.Location = new global::System.Drawing.Point(79, 85);
			this.buttonDeletePlayer.Name = "buttonDeletePlayer";
			this.buttonDeletePlayer.Size = new global::System.Drawing.Size(68, 38);
			this.buttonDeletePlayer.TabIndex = 152;
			this.buttonDeletePlayer.Text = "Delete";
			this.buttonDeletePlayer.UseVisualStyleBackColor = true;
			this.buttonDeletePlayer.Click += new global::System.EventHandler(this.buttonDeletePlayer_Click);
			this.buttonLoanFrom.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonLoanFrom.Location = new global::System.Drawing.Point(5, 47);
			this.buttonLoanFrom.Name = "buttonLoanFrom";
			this.buttonLoanFrom.Size = new global::System.Drawing.Size(68, 37);
			this.buttonLoanFrom.TabIndex = 151;
			this.buttonLoanFrom.Text = "   Loan    <<";
			this.buttonLoanFrom.UseVisualStyleBackColor = true;
			this.buttonLoanFrom.Click += new global::System.EventHandler(this.buttonLoanFrom_Click);
			this.label4.AutoSize = true;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(15, 127);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(72, 13);
			this.label4.TabIndex = 150;
			this.label4.Text = "Transfer Date";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.dateTransferPreset.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTransferPreset.Location = new global::System.Drawing.Point(5, 144);
			this.dateTransferPreset.MaxDate = new global::System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dateTransferPreset.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateTransferPreset.Name = "dateTransferPreset";
			this.dateTransferPreset.Size = new global::System.Drawing.Size(92, 20);
			this.dateTransferPreset.TabIndex = 149;
			this.dateTransferPreset.Value = new global::System.DateTime(2017, 7, 1, 0, 0, 0, 0);
			this.buttonTransferFrom.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonTransferFrom.Location = new global::System.Drawing.Point(5, 9);
			this.buttonTransferFrom.Name = "buttonTransferFrom";
			this.buttonTransferFrom.Size = new global::System.Drawing.Size(68, 37);
			this.buttonTransferFrom.TabIndex = 0;
			this.buttonTransferFrom.Text = "Transfer <<";
			this.buttonTransferFrom.UseVisualStyleBackColor = true;
			this.buttonTransferFrom.Click += new global::System.EventHandler(this.buttonTransferFrom_Click);
			this.pickUpAvailablePlayers.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpAvailablePlayers.CloneButtonEnabled = false;
			this.pickUpAvailablePlayers.CreateButtonEnabled = false;
			this.pickUpAvailablePlayers.CurrentIndex = 0;
			this.pickUpAvailablePlayers.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pickUpAvailablePlayers.FilterByList = new string[] { "All", "By Team", "By Country", "By Role", "Free Agent" };
			this.pickUpAvailablePlayers.FilterEnabled = true;
			this.pickUpAvailablePlayers.FilterValues = null;
			this.pickUpAvailablePlayers.Location = new global::System.Drawing.Point(0, 190);
			this.pickUpAvailablePlayers.MainSelectionEnabled = false;
			this.pickUpAvailablePlayers.Margin = new global::System.Windows.Forms.Padding(4);
			this.pickUpAvailablePlayers.Name = "pickUpAvailablePlayers";
			this.pickUpAvailablePlayers.ObjectList = null;
			this.pickUpAvailablePlayers.RefreshButtonEnabled = false;
			this.pickUpAvailablePlayers.RemoveButtonEnabled = false;
			this.pickUpAvailablePlayers.SearchEnabled = false;
			this.pickUpAvailablePlayers.Size = new global::System.Drawing.Size(335, 25);
			this.pickUpAvailablePlayers.TabIndex = 148;
			this.pickUpAvailablePlayers.WizardButtonEnabled = false;
			this.pickUpAvailablePlayers.YoungPlayersEnabled = false;
			this.buttonCall.Enabled = false;
			this.buttonCall.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonCall.Location = new global::System.Drawing.Point(5, 85);
			this.buttonCall.Name = "buttonCall";
			this.buttonCall.Size = new global::System.Drawing.Size(68, 38);
			this.buttonCall.TabIndex = 1;
			this.buttonCall.Text = "     Call       <<";
			this.buttonCall.UseVisualStyleBackColor = true;
			this.buttonCall.Click += new global::System.EventHandler(this.buttonCall_Click);
			this.labelAvailablePlayerStars.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAvailablePlayerStars.ImageIndex = 9;
			this.labelAvailablePlayerStars.ImageList = this.imageListStars;
			this.labelAvailablePlayerStars.Location = new global::System.Drawing.Point(231, 142);
			this.labelAvailablePlayerStars.Name = "labelAvailablePlayerStars";
			this.labelAvailablePlayerStars.Size = new global::System.Drawing.Size(101, 20);
			this.labelAvailablePlayerStars.TabIndex = 147;
			this.labelAvailablePlayerStars.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.imageListStars.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListStars.ImageStream");
			this.imageListStars.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageListStars.Images.SetKeyName(0, "Stars_0_5.PNG");
			this.imageListStars.Images.SetKeyName(1, "Stars_1.PNG");
			this.imageListStars.Images.SetKeyName(2, "Stars_1_5.PNG");
			this.imageListStars.Images.SetKeyName(3, "Stars_2.PNG");
			this.imageListStars.Images.SetKeyName(4, "Stars_2_5.PNG");
			this.imageListStars.Images.SetKeyName(5, "Stars_3.PNG");
			this.imageListStars.Images.SetKeyName(6, "Stars_3_5.PNG");
			this.imageListStars.Images.SetKeyName(7, "Stars_4.PNG");
			this.imageListStars.Images.SetKeyName(8, "Stars_4_5.PNG");
			this.imageListStars.Images.SetKeyName(9, "Stars_5.PNG");
			this.pictureAvailablePlayer.Location = new global::System.Drawing.Point(164, 7);
			this.pictureAvailablePlayer.Name = "pictureAvailablePlayer";
			this.pictureAvailablePlayer.Size = new global::System.Drawing.Size(128, 128);
			this.pictureAvailablePlayer.TabIndex = 146;
			this.pictureAvailablePlayer.TabStop = false;
			this.groupTeamPlayers.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupTeamPlayers.Controls.Add(this.listViewTeamPlayers);
			this.groupTeamPlayers.Controls.Add(this.panelTeamPlayersTop);
			this.groupTeamPlayers.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.groupTeamPlayers.Location = new global::System.Drawing.Point(3, 3);
			this.groupTeamPlayers.Name = "groupTeamPlayers";
			this.groupTeamPlayers.Size = new global::System.Drawing.Size(385, 775);
			this.groupTeamPlayers.TabIndex = 0;
			this.groupTeamPlayers.TabStop = false;
			this.groupTeamPlayers.Text = "Team Players";
			this.listViewTeamPlayers.AllowDrop = true;
			this.listViewTeamPlayers.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnRosterSurname, this.columnRosterFirstName, this.columnRosterYearContract, this.columnPreferredRole, this.columnAverageAttributes, this.columnRosterNum });
			this.listViewTeamPlayers.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listViewTeamPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewTeamPlayers.FullRowSelect = true;
			this.listViewTeamPlayers.GridLines = true;
			this.listViewTeamPlayers.HideSelection = false;
			this.listViewTeamPlayers.Location = new global::System.Drawing.Point(3, 231);
			this.listViewTeamPlayers.MultiSelect = false;
			this.listViewTeamPlayers.Name = "listViewTeamPlayers";
			this.listViewTeamPlayers.Size = new global::System.Drawing.Size(379, 541);
			this.listViewTeamPlayers.TabIndex = 8;
			this.listViewTeamPlayers.UseCompatibleStateImageBehavior = false;
			this.listViewTeamPlayers.View = global::System.Windows.Forms.View.Details;
			this.listViewTeamPlayers.AfterLabelEdit += new global::System.Windows.Forms.LabelEditEventHandler(this.listViewTeamPlayers_AfterLabelEdit);
			this.listViewTeamPlayers.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
			this.listViewTeamPlayers.SelectedIndexChanged += new global::System.EventHandler(this.listViewTeamPlayers_SelectedIndexChanged);
			this.listViewTeamPlayers.DoubleClick += new global::System.EventHandler(this.listViewTeamPlayers_DoubleClick);
			this.listViewTeamPlayers.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.listViewTeamPlayers_KeyPress);
			this.columnRosterSurname.DisplayIndex = 1;
			this.columnRosterSurname.Text = "Surname";
			this.columnRosterSurname.Width = 90;
			this.columnRosterFirstName.DisplayIndex = 2;
			this.columnRosterFirstName.Text = "First Name";
			this.columnRosterFirstName.Width = 89;
			this.columnRosterYearContract.DisplayIndex = 3;
			this.columnRosterYearContract.Text = "Y.C.";
			this.columnRosterYearContract.Width = 42;
			this.columnPreferredRole.DisplayIndex = 4;
			this.columnPreferredRole.Text = "Role";
			this.columnPreferredRole.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnPreferredRole.Width = 44;
			this.columnAverageAttributes.DisplayIndex = 5;
			this.columnAverageAttributes.Text = "Overall";
			this.columnAverageAttributes.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnAverageAttributes.Width = 52;
			this.columnRosterNum.DisplayIndex = 0;
			this.columnRosterNum.Text = "N.";
			this.columnRosterNum.Width = 25;
			this.panelTeamPlayersTop.Controls.Add(this.label5);
			this.panelTeamPlayersTop.Controls.Add(this.buttonPlusContract);
			this.panelTeamPlayersTop.Controls.Add(this.buttonMinusContract);
			this.panelTeamPlayersTop.Controls.Add(this.labelLoanedFrom);
			this.panelTeamPlayersTop.Controls.Add(this.comboTeamLoanedFrom);
			this.panelTeamPlayersTop.Controls.Add(this.label2);
			this.panelTeamPlayersTop.Controls.Add(this.dateLoanEnd);
			this.panelTeamPlayersTop.Controls.Add(this.labelLoanEnd);
			this.panelTeamPlayersTop.Controls.Add(this.buttonRosterLetFree);
			this.panelTeamPlayersTop.Controls.Add(this.buttonTransferPlayer);
			this.panelTeamPlayersTop.Controls.Add(this.checkIsLoan);
			this.panelTeamPlayersTop.Controls.Add(this.numericRosterYear);
			this.panelTeamPlayersTop.Controls.Add(this.buttonLoanTo);
			this.panelTeamPlayersTop.Controls.Add(this.dateJoiningDate);
			this.panelTeamPlayersTop.Controls.Add(this.viewer2DPhoto);
			this.panelTeamPlayersTop.Controls.Add(this.labelJoiningDate);
			this.panelTeamPlayersTop.Controls.Add(this.groupTeamPlayerTuning);
			this.panelTeamPlayersTop.Controls.Add(this.labelRosterName);
			this.panelTeamPlayersTop.Controls.Add(this.comboRosterNumber);
			this.panelTeamPlayersTop.Controls.Add(this.labelRosterNumber);
			this.panelTeamPlayersTop.Controls.Add(this.labelRosterNameFrom);
			this.panelTeamPlayersTop.Controls.Add(this.labelPreviousTeam);
			this.panelTeamPlayersTop.Controls.Add(this.comboTeamPrevious);
			this.panelTeamPlayersTop.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelTeamPlayersTop.Location = new global::System.Drawing.Point(3, 16);
			this.panelTeamPlayersTop.Name = "panelTeamPlayersTop";
			this.panelTeamPlayersTop.Size = new global::System.Drawing.Size(379, 215);
			this.panelTeamPlayersTop.TabIndex = 132;
			this.toolTip.SetToolTip(this.panelTeamPlayersTop, "Add 1 year of contract to all player");
			this.label5.AutoSize = true;
			this.label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new global::System.Drawing.Point(3, 191);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(52, 13);
			this.label5.TabIndex = 165;
			this.label5.Text = "Contracts";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonPlusContract.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonPlusContract.BackgroundImage");
			this.buttonPlusContract.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonPlusContract.Location = new global::System.Drawing.Point(64, 181);
			this.buttonPlusContract.Name = "buttonPlusContract";
			this.buttonPlusContract.Size = new global::System.Drawing.Size(32, 32);
			this.buttonPlusContract.TabIndex = 134;
			this.toolTip.SetToolTip(this.buttonPlusContract, "Increase 1 year of contract to all players");
			this.buttonPlusContract.UseVisualStyleBackColor = false;
			this.buttonPlusContract.Click += new global::System.EventHandler(this.buttonPlusContract_Click);
			this.buttonMinusContract.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMinusContract.BackgroundImage");
			this.buttonMinusContract.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonMinusContract.Location = new global::System.Drawing.Point(101, 181);
			this.buttonMinusContract.Name = "buttonMinusContract";
			this.buttonMinusContract.Size = new global::System.Drawing.Size(32, 32);
			this.buttonMinusContract.TabIndex = 135;
			this.toolTip.SetToolTip(this.buttonMinusContract, "Decrease 1 year of contract to all players");
			this.buttonMinusContract.UseVisualStyleBackColor = false;
			this.buttonMinusContract.Click += new global::System.EventHandler(this.buttonMinusContract_Click);
			this.labelLoanedFrom.AutoSize = true;
			this.labelLoanedFrom.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLoanedFrom.Location = new global::System.Drawing.Point(137, 129);
			this.labelLoanedFrom.Name = "labelLoanedFrom";
			this.labelLoanedFrom.Size = new global::System.Drawing.Size(69, 13);
			this.labelLoanedFrom.TabIndex = 140;
			this.labelLoanedFrom.Text = "Loaned From";
			this.labelLoanedFrom.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboTeamLoanedFrom.DataSource = this.teamListBindingSource;
			this.comboTeamLoanedFrom.ItemHeight = 13;
			this.comboTeamLoanedFrom.Location = new global::System.Drawing.Point(210, 125);
			this.comboTeamLoanedFrom.MaxLength = 32767;
			this.comboTeamLoanedFrom.Name = "comboTeamLoanedFrom";
			this.comboTeamLoanedFrom.Size = new global::System.Drawing.Size(163, 21);
			this.comboTeamLoanedFrom.TabIndex = 141;
			this.comboTeamLoanedFrom.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamLoanedFrom_SelectedIndexChanged);
			this.teamListBindingSource.DataSource = typeof(global::FifaLibrary.TeamList);
			this.label2.AutoSize = true;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(137, 57);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(69, 13);
			this.label2.TabIndex = 136;
			this.label2.Text = "Contract End";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.dateLoanEnd.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateLoanEnd.Location = new global::System.Drawing.Point(210, 100);
			this.dateLoanEnd.MaxDate = new global::System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dateLoanEnd.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateLoanEnd.Name = "dateLoanEnd";
			this.dateLoanEnd.Size = new global::System.Drawing.Size(92, 20);
			this.dateLoanEnd.TabIndex = 139;
			this.dateLoanEnd.Value = new global::System.DateTime(2017, 6, 30, 0, 0, 0, 0);
			this.dateLoanEnd.ValueChanged += new global::System.EventHandler(this.dateLoanEnd_ValueChanged);
			this.labelLoanEnd.AutoSize = true;
			this.labelLoanEnd.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLoanEnd.Location = new global::System.Drawing.Point(137, 104);
			this.labelLoanEnd.Name = "labelLoanEnd";
			this.labelLoanEnd.Size = new global::System.Drawing.Size(53, 13);
			this.labelLoanEnd.TabIndex = 138;
			this.labelLoanEnd.Text = "Loan End";
			this.labelLoanEnd.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonRosterLetFree.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRosterLetFree.Location = new global::System.Drawing.Point(305, 85);
			this.buttonRosterLetFree.Name = "buttonRosterLetFree";
			this.buttonRosterLetFree.Size = new global::System.Drawing.Size(68, 38);
			this.buttonRosterLetFree.TabIndex = 1;
			this.buttonRosterLetFree.Text = "Let Free >>";
			this.buttonRosterLetFree.UseVisualStyleBackColor = true;
			this.buttonRosterLetFree.Click += new global::System.EventHandler(this.buttonRosterLetFree_Click);
			this.buttonTransferPlayer.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonTransferPlayer.Location = new global::System.Drawing.Point(305, 6);
			this.buttonTransferPlayer.Name = "buttonTransferPlayer";
			this.buttonTransferPlayer.Size = new global::System.Drawing.Size(68, 40);
			this.buttonTransferPlayer.TabIndex = 0;
			this.buttonTransferPlayer.Text = "Transfer >>";
			this.buttonTransferPlayer.UseVisualStyleBackColor = true;
			this.buttonTransferPlayer.Click += new global::System.EventHandler(this.buttonTransferPlayer_Click);
			this.checkIsLoan.Checked = true;
			this.checkIsLoan.CheckState = global::System.Windows.Forms.CheckState.Indeterminate;
			this.checkIsLoan.Location = new global::System.Drawing.Point(176, 75);
			this.checkIsLoan.Name = "checkIsLoan";
			this.checkIsLoan.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsLoan.Size = new global::System.Drawing.Size(85, 24);
			this.checkIsLoan.TabIndex = 164;
			this.checkIsLoan.Text = "Is Loaned ";
			this.checkIsLoan.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkIsLoan.UseVisualStyleBackColor = true;
			this.checkIsLoan.CheckedChanged += new global::System.EventHandler(this.checkIsLoan_CheckedChanged);
			this.numericRosterYear.Location = new global::System.Drawing.Point(210, 54);
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.numericRosterYear;
			int[] array32 = new int[4];
			array32[0] = 2030;
			numericUpDown32.Maximum = new decimal(array32);
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.numericRosterYear;
			int[] array33 = new int[4];
			array33[0] = 2005;
			numericUpDown33.Minimum = new decimal(array33);
			this.numericRosterYear.Name = "numericRosterYear";
			this.numericRosterYear.Size = new global::System.Drawing.Size(92, 20);
			this.numericRosterYear.TabIndex = 3;
			this.numericRosterYear.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.numericRosterYear;
			int[] array34 = new int[4];
			array34[0] = 2005;
			numericUpDown34.Value = new decimal(array34);
			this.numericRosterYear.ValueChanged += new global::System.EventHandler(this.numericRosterYear_ValueChanged);
			this.buttonLoanTo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonLoanTo.Location = new global::System.Drawing.Point(305, 47);
			this.buttonLoanTo.Name = "buttonLoanTo";
			this.buttonLoanTo.Size = new global::System.Drawing.Size(68, 37);
			this.buttonLoanTo.TabIndex = 163;
			this.buttonLoanTo.Text = "   Loan    >>";
			this.buttonLoanTo.UseVisualStyleBackColor = true;
			this.buttonLoanTo.Click += new global::System.EventHandler(this.buttonLoanTo_Click);
			this.dateJoiningDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateJoiningDate.Location = new global::System.Drawing.Point(210, 30);
			this.dateJoiningDate.MaxDate = new global::System.DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.dateJoiningDate.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateJoiningDate.Name = "dateJoiningDate";
			this.dateJoiningDate.Size = new global::System.Drawing.Size(92, 20);
			this.dateJoiningDate.TabIndex = 132;
			this.dateJoiningDate.Value = new global::System.DateTime(2016, 7, 1, 0, 0, 0, 0);
			this.dateJoiningDate.ValueChanged += new global::System.EventHandler(this.dateJoiningDate_ValueChanged);
			this.viewer2DPhoto.AutoTransparency = true;
			this.viewer2DPhoto.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPhoto.ButtonStripVisible = false;
			this.viewer2DPhoto.CurrentBitmap = null;
			this.viewer2DPhoto.ExtendedFormat = false;
			this.viewer2DPhoto.FullSizeButton = false;
			this.viewer2DPhoto.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPhoto.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DPhoto.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.MiniFace;
			this.viewer2DPhoto.Location = new global::System.Drawing.Point(5, 4);
			this.viewer2DPhoto.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DPhoto.Name = "viewer2DPhoto";
			this.viewer2DPhoto.RemoveButton = false;
			this.viewer2DPhoto.ShowButton = false;
			this.viewer2DPhoto.ShowButtonChecked = true;
			this.viewer2DPhoto.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DPhoto.TabIndex = 162;
			this.viewer2DPhoto.TabStop = false;
			this.labelJoiningDate.AutoSize = true;
			this.labelJoiningDate.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelJoiningDate.Location = new global::System.Drawing.Point(137, 33);
			this.labelJoiningDate.Name = "labelJoiningDate";
			this.labelJoiningDate.Size = new global::System.Drawing.Size(26, 13);
			this.labelJoiningDate.TabIndex = 133;
			this.labelJoiningDate.Text = "Join";
			this.labelJoiningDate.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupTeamPlayerTuning.Controls.Add(this.buttonTeamPlayerMinus);
			this.groupTeamPlayerTuning.Controls.Add(this.buttonTeamPlayerPlus);
			this.groupTeamPlayerTuning.Controls.Add(this.labelTeamPlayerStars);
			this.groupTeamPlayerTuning.Location = new global::System.Drawing.Point(140, 153);
			this.groupTeamPlayerTuning.Name = "groupTeamPlayerTuning";
			this.groupTeamPlayerTuning.Size = new global::System.Drawing.Size(232, 60);
			this.groupTeamPlayerTuning.TabIndex = 161;
			this.groupTeamPlayerTuning.TabStop = false;
			this.groupTeamPlayerTuning.Text = "Rating";
			this.toolTip.SetToolTip(this.groupTeamPlayerTuning, "Increase all players overall");
			this.buttonTeamPlayerMinus.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTeamPlayerMinus.BackgroundImage");
			this.buttonTeamPlayerMinus.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonTeamPlayerMinus.Location = new global::System.Drawing.Point(156, 9);
			this.buttonTeamPlayerMinus.Name = "buttonTeamPlayerMinus";
			this.buttonTeamPlayerMinus.Size = new global::System.Drawing.Size(48, 48);
			this.buttonTeamPlayerMinus.TabIndex = 1;
			this.toolTip.SetToolTip(this.buttonTeamPlayerMinus, "Decrease all players overall");
			this.buttonTeamPlayerMinus.UseVisualStyleBackColor = false;
			this.buttonTeamPlayerMinus.Click += new global::System.EventHandler(this.buttonTeamPlayerMinus_Click);
			this.buttonTeamPlayerPlus.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTeamPlayerPlus.BackgroundImage");
			this.buttonTeamPlayerPlus.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonTeamPlayerPlus.Location = new global::System.Drawing.Point(103, 9);
			this.buttonTeamPlayerPlus.Name = "buttonTeamPlayerPlus";
			this.buttonTeamPlayerPlus.Size = new global::System.Drawing.Size(48, 48);
			this.buttonTeamPlayerPlus.TabIndex = 0;
			this.toolTip.SetToolTip(this.buttonTeamPlayerPlus, "Increase all players overall");
			this.buttonTeamPlayerPlus.UseVisualStyleBackColor = false;
			this.buttonTeamPlayerPlus.Click += new global::System.EventHandler(this.buttonTeamPlayerPlus_Click);
			this.labelTeamPlayerStars.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelTeamPlayerStars.ImageIndex = 9;
			this.labelTeamPlayerStars.ImageList = this.imageListStars;
			this.labelTeamPlayerStars.Location = new global::System.Drawing.Point(3, 23);
			this.labelTeamPlayerStars.Name = "labelTeamPlayerStars";
			this.labelTeamPlayerStars.Size = new global::System.Drawing.Size(101, 20);
			this.labelTeamPlayerStars.TabIndex = 5;
			this.labelTeamPlayerStars.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelRosterName.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelRosterName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelRosterName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelRosterName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRosterName.Location = new global::System.Drawing.Point(4, 159);
			this.labelRosterName.Name = "labelRosterName";
			this.labelRosterName.Size = new global::System.Drawing.Size(129, 20);
			this.labelRosterName.TabIndex = 4;
			this.labelRosterName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.comboRosterNumber.FormattingEnabled = true;
			this.comboRosterNumber.Location = new global::System.Drawing.Point(210, 6);
			this.comboRosterNumber.Name = "comboRosterNumber";
			this.comboRosterNumber.Size = new global::System.Drawing.Size(92, 21);
			this.comboRosterNumber.TabIndex = 2;
			this.comboRosterNumber.SelectedIndexChanged += new global::System.EventHandler(this.comboRosterNumber_SelectedIndexChanged);
			this.labelRosterNumber.AutoSize = true;
			this.labelRosterNumber.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelRosterNumber.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRosterNumber.Location = new global::System.Drawing.Point(137, 10);
			this.labelRosterNumber.Name = "labelRosterNumber";
			this.labelRosterNumber.Size = new global::System.Drawing.Size(42, 13);
			this.labelRosterNumber.TabIndex = 6;
			this.labelRosterNumber.Text = "Shirt N.";
			this.labelRosterNumber.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelRosterNameFrom.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelRosterNameFrom.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelRosterNameFrom.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRosterNameFrom.Location = new global::System.Drawing.Point(137, 52);
			this.labelRosterNameFrom.Name = "labelRosterNameFrom";
			this.labelRosterNameFrom.Size = new global::System.Drawing.Size(76, 20);
			this.labelRosterNameFrom.TabIndex = 144;
			this.labelRosterNameFrom.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPreviousTeam.AutoSize = true;
			this.labelPreviousTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPreviousTeam.Location = new global::System.Drawing.Point(137, 129);
			this.labelPreviousTeam.Name = "labelPreviousTeam";
			this.labelPreviousTeam.Size = new global::System.Drawing.Size(48, 13);
			this.labelPreviousTeam.TabIndex = 167;
			this.labelPreviousTeam.Text = "Previous";
			this.labelPreviousTeam.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboTeamPrevious.DataSource = this.teamListBindingSource;
			this.comboTeamPrevious.ItemHeight = 13;
			this.comboTeamPrevious.Location = new global::System.Drawing.Point(210, 125);
			this.comboTeamPrevious.MaxLength = 32767;
			this.comboTeamPrevious.Name = "comboTeamPrevious";
			this.comboTeamPrevious.Size = new global::System.Drawing.Size(163, 21);
			this.comboTeamPrevious.TabIndex = 166;
			this.comboTeamPrevious.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamPrevious_SelectedIndexChanged);
			this.pageTeamAdboard.AutoScroll = true;
			this.pageTeamAdboard.Controls.Add(this.numericAdboards);
			this.pageTeamAdboard.Controls.Add(this.checkHasSpecificAdboard);
			this.pageTeamAdboard.Controls.Add(this.labelAdboard);
			this.pageTeamAdboard.Controls.Add(this.viewer2DAdboards_0);
			this.pageTeamAdboard.Location = new global::System.Drawing.Point(4, 22);
			this.pageTeamAdboard.Name = "pageTeamAdboard";
			this.pageTeamAdboard.Size = new global::System.Drawing.Size(1303, 781);
			this.pageTeamAdboard.TabIndex = 2;
			this.pageTeamAdboard.Text = "Adboards";
			this.pageTeamAdboard.UseVisualStyleBackColor = true;
			this.numericAdboards.Location = new global::System.Drawing.Point(115, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.numericAdboards;
			int[] array35 = new int[4];
			array35[0] = 245;
			numericUpDown35.Maximum = new decimal(array35);
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.numericAdboards;
			int[] array36 = new int[4];
			array36[0] = 1;
			numericUpDown36.Minimum = new decimal(array36);
			this.numericAdboards.Name = "numericAdboards";
			this.numericAdboards.Size = new global::System.Drawing.Size(112, 20);
			this.numericAdboards.TabIndex = 0;
			this.numericAdboards.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.numericAdboards;
			int[] array37 = new int[4];
			array37[0] = 1;
			numericUpDown37.Value = new decimal(array37);
			this.numericAdboards.ValueChanged += new global::System.EventHandler(this.numericAdboards_ValueChanged);
			this.checkHasSpecificAdboard.AutoSize = true;
			this.checkHasSpecificAdboard.Location = new global::System.Drawing.Point(25, 9);
			this.checkHasSpecificAdboard.Name = "checkHasSpecificAdboard";
			this.checkHasSpecificAdboard.Size = new global::System.Drawing.Size(129, 17);
			this.checkHasSpecificAdboard.TabIndex = 5;
			this.checkHasSpecificAdboard.Text = "Has Specific Adboard";
			this.toolTip.SetToolTip(this.checkHasSpecificAdboard, "Create an Adboard specific for this team");
			this.checkHasSpecificAdboard.UseVisualStyleBackColor = true;
			this.checkHasSpecificAdboard.CheckedChanged += new global::System.EventHandler(this.checkHasSpecificAdboard_CheckedChanged);
			this.labelAdboard.AutoSize = true;
			this.labelAdboard.Location = new global::System.Drawing.Point(22, 34);
			this.labelAdboard.Name = "labelAdboard";
			this.labelAdboard.Size = new global::System.Drawing.Size(87, 13);
			this.labelAdboard.TabIndex = 4;
			this.labelAdboard.Text = "Adboard Number";
			this.viewer2DAdboards_0.AutoTransparency = false;
			this.viewer2DAdboards_0.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DAdboards_0.ButtonStripVisible = false;
			this.viewer2DAdboards_0.CurrentBitmap = null;
			this.viewer2DAdboards_0.ExtendedFormat = false;
			this.viewer2DAdboards_0.FullSizeButton = false;
			this.viewer2DAdboards_0.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DAdboards_0.ImageSize = new global::System.Drawing.Size(512, 1024);
			this.viewer2DAdboards_0.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DAdboards_0.Location = new global::System.Drawing.Point(8, 58);
			this.viewer2DAdboards_0.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DAdboards_0.Name = "viewer2DAdboards_0";
			this.viewer2DAdboards_0.RemoveButton = false;
			this.viewer2DAdboards_0.ShowButton = false;
			this.viewer2DAdboards_0.ShowButtonChecked = true;
			this.viewer2DAdboards_0.Size = new global::System.Drawing.Size(256, 537);
			this.viewer2DAdboards_0.TabIndex = 3;
			this.pageTeamFlags.AutoScroll = true;
			this.pageTeamFlags.Controls.Add(this.groupFlag);
			this.pageTeamFlags.Controls.Add(this.viewer2DBanners);
			this.pageTeamFlags.Location = new global::System.Drawing.Point(4, 22);
			this.pageTeamFlags.Name = "pageTeamFlags";
			this.pageTeamFlags.Size = new global::System.Drawing.Size(1303, 781);
			this.pageTeamFlags.TabIndex = 3;
			this.pageTeamFlags.Text = "Flags";
			this.pageTeamFlags.UseVisualStyleBackColor = true;
			this.groupFlag.Controls.Add(this.multiViewer2DFlags15);
			this.groupFlag.Controls.Add(this.buttonCreateFlags);
			this.groupFlag.Controls.Add(this.pictureBox4);
			this.groupFlag.Controls.Add(this.label22);
			this.groupFlag.Controls.Add(this.pictureFlagBlue);
			this.groupFlag.Controls.Add(this.pictureFlagRed);
			this.groupFlag.Controls.Add(this.pictureFlagGreen);
			this.groupFlag.Controls.Add(this.checkFlag4);
			this.groupFlag.Controls.Add(this.checkFlag3);
			this.groupFlag.Controls.Add(this.checkFlag2);
			this.groupFlag.Controls.Add(this.checkFlag1);
			this.groupFlag.Controls.Add(this.labelFlag4);
			this.groupFlag.Controls.Add(this.labelFlag3);
			this.groupFlag.Controls.Add(this.labelFlag2);
			this.groupFlag.Controls.Add(this.labelFlag1);
			this.groupFlag.Location = new global::System.Drawing.Point(526, 3);
			this.groupFlag.Name = "groupFlag";
			this.groupFlag.Size = new global::System.Drawing.Size(532, 405);
			this.groupFlag.TabIndex = 2;
			this.groupFlag.TabStop = false;
			this.groupFlag.Text = "Flags";
			this.multiViewer2DFlags15.AutoTransparency = false;
			this.multiViewer2DFlags15.Bitmaps = null;
			this.multiViewer2DFlags15.CheckBitmapSize = true;
			this.multiViewer2DFlags15.FixedSize = false;
			this.multiViewer2DFlags15.FullSizeButton = false;
			this.multiViewer2DFlags15.LabelText = "Flag n.";
			this.multiViewer2DFlags15.Location = new global::System.Drawing.Point(6, 19);
			this.multiViewer2DFlags15.Name = "multiViewer2DFlags15";
			this.multiViewer2DFlags15.ShowButton = false;
			this.multiViewer2DFlags15.ShowDeleteButton = false;
			this.multiViewer2DFlags15.Size = new global::System.Drawing.Size(514, 302);
			this.multiViewer2DFlags15.TabIndex = 154;
			this.buttonCreateFlags.Location = new global::System.Drawing.Point(403, 335);
			this.buttonCreateFlags.Name = "buttonCreateFlags";
			this.buttonCreateFlags.Size = new global::System.Drawing.Size(104, 55);
			this.buttonCreateFlags.TabIndex = 153;
			this.buttonCreateFlags.Text = "Create Flags";
			this.buttonCreateFlags.UseVisualStyleBackColor = true;
			this.buttonCreateFlags.Click += new global::System.EventHandler(this.buttonCreateFlags_Click);
			this.pictureBox4.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.BackgroundImage");
			this.pictureBox4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new global::System.Drawing.Point(286, 347);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(98, 13);
			this.pictureBox4.TabIndex = 152;
			this.pictureBox4.TabStop = false;
			this.label22.AutoSize = true;
			this.label22.BackColor = global::System.Drawing.Color.Transparent;
			this.label22.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label22.Location = new global::System.Drawing.Point(320, 331);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(36, 13);
			this.label22.TabIndex = 151;
			this.label22.Text = "Colors";
			this.label22.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.pictureFlagBlue.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureFlagBlue.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureFlagBlue.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor3", true));
			this.pictureFlagBlue.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureFlagBlue.Location = new global::System.Drawing.Point(360, 366);
			this.pictureFlagBlue.Name = "pictureFlagBlue";
			this.pictureFlagBlue.Size = new global::System.Drawing.Size(24, 24);
			this.pictureFlagBlue.TabIndex = 150;
			this.pictureFlagBlue.TabStop = false;
			this.pictureFlagBlue.Click += new global::System.EventHandler(this.pictureFlagBlue_Click);
			this.pictureFlagRed.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureFlagRed.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureFlagRed.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor1", true));
			this.pictureFlagRed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureFlagRed.Location = new global::System.Drawing.Point(286, 366);
			this.pictureFlagRed.Name = "pictureFlagRed";
			this.pictureFlagRed.Size = new global::System.Drawing.Size(24, 24);
			this.pictureFlagRed.TabIndex = 148;
			this.pictureFlagRed.TabStop = false;
			this.pictureFlagRed.Click += new global::System.EventHandler(this.pictureFlagRed_Click);
			this.pictureFlagGreen.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureFlagGreen.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureFlagGreen.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.teamBindingSource, "TeamColor2", true));
			this.pictureFlagGreen.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureFlagGreen.Location = new global::System.Drawing.Point(323, 366);
			this.pictureFlagGreen.Name = "pictureFlagGreen";
			this.pictureFlagGreen.Size = new global::System.Drawing.Size(24, 24);
			this.pictureFlagGreen.TabIndex = 149;
			this.pictureFlagGreen.TabStop = false;
			this.pictureFlagGreen.Click += new global::System.EventHandler(this.pictureFlagGreen_Click);
			this.checkFlag4.AutoSize = true;
			this.checkFlag4.Checked = true;
			this.checkFlag4.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFlag4.Location = new global::System.Drawing.Point(223, 335);
			this.checkFlag4.Name = "checkFlag4";
			this.checkFlag4.Size = new global::System.Drawing.Size(15, 14);
			this.checkFlag4.TabIndex = 7;
			this.toolTip.SetToolTip(this.checkFlag4, "Check to add logo to the flag");
			this.checkFlag4.UseVisualStyleBackColor = true;
			this.checkFlag3.AutoSize = true;
			this.checkFlag3.Checked = true;
			this.checkFlag3.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFlag3.Location = new global::System.Drawing.Point(159, 335);
			this.checkFlag3.Name = "checkFlag3";
			this.checkFlag3.Size = new global::System.Drawing.Size(15, 14);
			this.checkFlag3.TabIndex = 6;
			this.toolTip.SetToolTip(this.checkFlag3, "Check to add logo to the flag");
			this.checkFlag3.UseVisualStyleBackColor = true;
			this.checkFlag2.AutoSize = true;
			this.checkFlag2.Checked = true;
			this.checkFlag2.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFlag2.Location = new global::System.Drawing.Point(95, 335);
			this.checkFlag2.Name = "checkFlag2";
			this.checkFlag2.Size = new global::System.Drawing.Size(15, 14);
			this.checkFlag2.TabIndex = 5;
			this.toolTip.SetToolTip(this.checkFlag2, "Check to add logo to the flag");
			this.checkFlag2.UseVisualStyleBackColor = true;
			this.checkFlag1.AutoSize = true;
			this.checkFlag1.Checked = true;
			this.checkFlag1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFlag1.Location = new global::System.Drawing.Point(29, 335);
			this.checkFlag1.Name = "checkFlag1";
			this.checkFlag1.Size = new global::System.Drawing.Size(15, 14);
			this.checkFlag1.TabIndex = 4;
			this.toolTip.SetToolTip(this.checkFlag1, "Check to add logo to the flag");
			this.checkFlag1.UseVisualStyleBackColor = true;
			this.labelFlag4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFlag4.ImageIndex = 10;
			this.labelFlag4.ImageList = this.imageListFlags;
			this.labelFlag4.Location = new global::System.Drawing.Point(207, 358);
			this.labelFlag4.Name = "labelFlag4";
			this.labelFlag4.Size = new global::System.Drawing.Size(50, 30);
			this.labelFlag4.TabIndex = 3;
			this.toolTip.SetToolTip(this.labelFlag4, "Click to change flag style");
			this.labelFlag4.Click += new global::System.EventHandler(this.labelFlag1_Click);
			this.imageListFlags.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListFlags.ImageStream");
			this.imageListFlags.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListFlags.Images.SetKeyName(0, "gf1.png");
			this.imageListFlags.Images.SetKeyName(1, "gf2.png");
			this.imageListFlags.Images.SetKeyName(2, "gf3.png");
			this.imageListFlags.Images.SetKeyName(3, "gf4.png");
			this.imageListFlags.Images.SetKeyName(4, "gf5.png");
			this.imageListFlags.Images.SetKeyName(5, "gf6.png");
			this.imageListFlags.Images.SetKeyName(6, "gf7.png");
			this.imageListFlags.Images.SetKeyName(7, "gf8.png");
			this.imageListFlags.Images.SetKeyName(8, "gf9.png");
			this.imageListFlags.Images.SetKeyName(9, "gf10.png");
			this.imageListFlags.Images.SetKeyName(10, "gf11.png");
			this.imageListFlags.Images.SetKeyName(11, "gf13.png");
			this.imageListFlags.Images.SetKeyName(12, "gf15.png");
			this.labelFlag3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFlag3.ImageIndex = 2;
			this.labelFlag3.ImageList = this.imageListFlags;
			this.labelFlag3.Location = new global::System.Drawing.Point(142, 358);
			this.labelFlag3.Name = "labelFlag3";
			this.labelFlag3.Size = new global::System.Drawing.Size(50, 30);
			this.labelFlag3.TabIndex = 2;
			this.toolTip.SetToolTip(this.labelFlag3, "Click to change flag style");
			this.labelFlag3.Click += new global::System.EventHandler(this.labelFlag1_Click);
			this.labelFlag2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFlag2.ImageIndex = 1;
			this.labelFlag2.ImageList = this.imageListFlags;
			this.labelFlag2.Location = new global::System.Drawing.Point(77, 358);
			this.labelFlag2.Name = "labelFlag2";
			this.labelFlag2.Size = new global::System.Drawing.Size(50, 30);
			this.labelFlag2.TabIndex = 1;
			this.toolTip.SetToolTip(this.labelFlag2, "Click to change flag style");
			this.labelFlag2.Click += new global::System.EventHandler(this.labelFlag1_Click);
			this.labelFlag1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFlag1.ImageIndex = 0;
			this.labelFlag1.ImageList = this.imageListFlags;
			this.labelFlag1.Location = new global::System.Drawing.Point(12, 358);
			this.labelFlag1.Name = "labelFlag1";
			this.labelFlag1.Size = new global::System.Drawing.Size(50, 30);
			this.labelFlag1.TabIndex = 0;
			this.toolTip.SetToolTip(this.labelFlag1, "Click to change flag style");
			this.labelFlag1.Click += new global::System.EventHandler(this.labelFlag1_Click);
			this.viewer2DBanners.AutoTransparency = false;
			this.viewer2DBanners.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DBanners.ButtonStripVisible = false;
			this.viewer2DBanners.CurrentBitmap = null;
			this.viewer2DBanners.ExtendedFormat = false;
			this.viewer2DBanners.FullSizeButton = false;
			this.viewer2DBanners.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DBanners.ImageSize = new global::System.Drawing.Size(1024, 512);
			this.viewer2DBanners.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DBanners.Location = new global::System.Drawing.Point(8, 3);
			this.viewer2DBanners.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DBanners.Name = "viewer2DBanners";
			this.viewer2DBanners.RemoveButton = false;
			this.viewer2DBanners.ShowButton = false;
			this.viewer2DBanners.ShowButtonChecked = true;
			this.viewer2DBanners.Size = new global::System.Drawing.Size(512, 281);
			this.viewer2DBanners.TabIndex = 0;
			this.pageTeamrevMod.Controls.Add(this.flowLayoutPanel1);
			this.pageTeamrevMod.Location = new global::System.Drawing.Point(4, 22);
			this.pageTeamrevMod.Name = "pageTeamrevMod";
			this.pageTeamrevMod.Size = new global::System.Drawing.Size(1303, 781);
			this.pageTeamrevMod.TabIndex = 4;
			this.pageTeamrevMod.Text = "Rev. Mod. Extensions";
			this.pageTeamrevMod.UseVisualStyleBackColor = true;
			this.flowLayoutPanel1.Controls.Add(this.groupTeamAdboardsRevMod);
			this.flowLayoutPanel1.Controls.Add(this.groupTeamBallRevMod);
			this.flowLayoutPanel1.Controls.Add(this.groupTeamManager);
			this.flowLayoutPanel1.Controls.Add(this.groupTeamScarfRevMod);
			this.flowLayoutPanel1.Controls.Add(this.groupTeamGoalNetRevMod);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(1303, 781);
			this.flowLayoutPanel1.TabIndex = 0;
			this.groupTeamAdboardsRevMod.Controls.Add(this.viewer2DTeamAdboard);
			this.groupTeamAdboardsRevMod.Location = new global::System.Drawing.Point(3, 3);
			this.groupTeamAdboardsRevMod.Name = "groupTeamAdboardsRevMod";
			this.groupTeamAdboardsRevMod.Size = new global::System.Drawing.Size(270, 570);
			this.groupTeamAdboardsRevMod.TabIndex = 164;
			this.groupTeamAdboardsRevMod.TabStop = false;
			this.groupTeamAdboardsRevMod.Text = "Unique Adboards";
			this.viewer2DTeamAdboard.AutoTransparency = false;
			this.viewer2DTeamAdboard.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DTeamAdboard.ButtonStripVisible = false;
			this.viewer2DTeamAdboard.CurrentBitmap = null;
			this.viewer2DTeamAdboard.ExtendedFormat = false;
			this.viewer2DTeamAdboard.FullSizeButton = false;
			this.viewer2DTeamAdboard.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DTeamAdboard.ImageSize = new global::System.Drawing.Size(512, 1024);
			this.viewer2DTeamAdboard.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DTeamAdboard.Location = new global::System.Drawing.Point(5, 24);
			this.viewer2DTeamAdboard.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DTeamAdboard.Name = "viewer2DTeamAdboard";
			this.viewer2DTeamAdboard.RemoveButton = false;
			this.viewer2DTeamAdboard.ShowButton = false;
			this.viewer2DTeamAdboard.ShowButtonChecked = true;
			this.viewer2DTeamAdboard.Size = new global::System.Drawing.Size(256, 537);
			this.viewer2DTeamAdboard.TabIndex = 4;
			this.groupTeamBallRevMod.Controls.Add(this.viewer3DTeamBall);
			this.groupTeamBallRevMod.Controls.Add(this.toolTeamBall3D);
			this.groupTeamBallRevMod.Controls.Add(this.multiViewer2DTeamBallTextures);
			this.groupTeamBallRevMod.Location = new global::System.Drawing.Point(279, 3);
			this.groupTeamBallRevMod.Name = "groupTeamBallRevMod";
			this.groupTeamBallRevMod.Size = new global::System.Drawing.Size(529, 340);
			this.groupTeamBallRevMod.TabIndex = 166;
			this.groupTeamBallRevMod.TabStop = false;
			this.groupTeamBallRevMod.Text = "Unique Ball";
			this.viewer3DTeamBall.AmbientColor = global::System.Drawing.Color.Black;
			this.viewer3DTeamBall.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3DTeamBall.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3DTeamBall.LightDirectionX = 0.5f;
			this.viewer3DTeamBall.LightDirectionY = -0.25f;
			this.viewer3DTeamBall.LightDirectionZ = -1f;
			this.viewer3DTeamBall.LightX = -30f;
			this.viewer3DTeamBall.LightY = 10f;
			this.viewer3DTeamBall.LightZ = 30f;
			this.viewer3DTeamBall.Location = new global::System.Drawing.Point(265, 44);
			this.viewer3DTeamBall.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer3DTeamBall.Name = "viewer3DTeamBall";
			this.viewer3DTeamBall.RotationX = 0f;
			this.viewer3DTeamBall.RotationY = 0f;
			this.viewer3DTeamBall.RotationYCoeff = 0.01f;
			this.viewer3DTeamBall.Size = new global::System.Drawing.Size(256, 256);
			this.viewer3DTeamBall.TabIndex = 3;
			this.viewer3DTeamBall.ViewX = 0f;
			this.viewer3DTeamBall.ViewY = 0f;
			this.viewer3DTeamBall.ViewZ = 30f;
			this.viewer3DTeamBall.ZbufferRenderState = null;
			this.toolTeamBall3D.AutoSize = false;
			this.toolTeamBall3D.Dock = global::System.Windows.Forms.DockStyle.None;
			this.toolTeamBall3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolTeamBall3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DBall, this.toolStripSeparator1, this.buttonImport3DModelTeamBall, this.buttonExport3DModelTeamBall, this.toolStripSeparator2, this.buttonRemove3DModelTeamBall });
			this.toolTeamBall3D.Location = new global::System.Drawing.Point(265, 301);
			this.toolTeamBall3D.Name = "toolTeamBall3D";
			this.toolTeamBall3D.Size = new global::System.Drawing.Size(256, 25);
			this.toolTeamBall3D.TabIndex = 4;
			this.buttonShow3DBall.CheckOnClick = true;
			this.buttonShow3DBall.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DBall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DBall.Image");
			this.buttonShow3DBall.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DBall.Name = "buttonShow3DBall";
			this.buttonShow3DBall.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DBall.Text = "Show / Hide";
			this.buttonShow3DBall.Click += new global::System.EventHandler(this.buttonShow3DBall_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonImport3DModelTeamBall.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImport3DModelTeamBall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImport3DModelTeamBall.Image");
			this.buttonImport3DModelTeamBall.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImport3DModelTeamBall.Name = "buttonImport3DModelTeamBall";
			this.buttonImport3DModelTeamBall.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImport3DModelTeamBall.Text = "Import 3D Model";
			this.buttonImport3DModelTeamBall.Click += new global::System.EventHandler(this.buttonImport3DModelTeamBall_Click);
			this.buttonExport3DModelTeamBall.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExport3DModelTeamBall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExport3DModelTeamBall.Image");
			this.buttonExport3DModelTeamBall.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExport3DModelTeamBall.Name = "buttonExport3DModelTeamBall";
			this.buttonExport3DModelTeamBall.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExport3DModelTeamBall.Text = "Export 3D Model";
			this.buttonExport3DModelTeamBall.Click += new global::System.EventHandler(this.buttonExport3DModelTeamBall_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonRemove3DModelTeamBall.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemove3DModelTeamBall.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemove3DModelTeamBall.Image");
			this.buttonRemove3DModelTeamBall.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemove3DModelTeamBall.Name = "buttonRemove3DModelTeamBall";
			this.buttonRemove3DModelTeamBall.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemove3DModelTeamBall.Text = "Remove 3D Model";
			this.buttonRemove3DModelTeamBall.Click += new global::System.EventHandler(this.buttonRemove3DModelTeamBall_Click);
			this.multiViewer2DTeamBallTextures.AutoTransparency = false;
			this.multiViewer2DTeamBallTextures.Bitmaps = null;
			this.multiViewer2DTeamBallTextures.CheckBitmapSize = true;
			this.multiViewer2DTeamBallTextures.FixedSize = true;
			this.multiViewer2DTeamBallTextures.FullSizeButton = false;
			this.multiViewer2DTeamBallTextures.LabelText = "Texture";
			this.multiViewer2DTeamBallTextures.Location = new global::System.Drawing.Point(3, 24);
			this.multiViewer2DTeamBallTextures.Name = "multiViewer2DTeamBallTextures";
			this.multiViewer2DTeamBallTextures.ShowButton = false;
			this.multiViewer2DTeamBallTextures.ShowDeleteButton = false;
			this.multiViewer2DTeamBallTextures.Size = new global::System.Drawing.Size(256, 302);
			this.multiViewer2DTeamBallTextures.TabIndex = 1;
			this.groupTeamManager.Controls.Add(this.viewer3DTeamManager);
			this.groupTeamManager.Controls.Add(this.toolTeamManager3D);
			this.groupTeamManager.Controls.Add(this.viewer2DTeamManager);
			this.groupTeamManager.Location = new global::System.Drawing.Point(279, 349);
			this.groupTeamManager.Name = "groupTeamManager";
			this.groupTeamManager.Size = new global::System.Drawing.Size(529, 308);
			this.groupTeamManager.TabIndex = 167;
			this.groupTeamManager.TabStop = false;
			this.groupTeamManager.Text = "Unique Team Manager";
			this.viewer3DTeamManager.AmbientColor = global::System.Drawing.Color.Black;
			this.viewer3DTeamManager.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3DTeamManager.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3DTeamManager.LightDirectionX = 0.5f;
			this.viewer3DTeamManager.LightDirectionY = -0.25f;
			this.viewer3DTeamManager.LightDirectionZ = -1f;
			this.viewer3DTeamManager.LightX = -30f;
			this.viewer3DTeamManager.LightY = 10f;
			this.viewer3DTeamManager.LightZ = 30f;
			this.viewer3DTeamManager.Location = new global::System.Drawing.Point(267, 19);
			this.viewer3DTeamManager.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer3DTeamManager.Name = "viewer3DTeamManager";
			this.viewer3DTeamManager.RotationX = 0f;
			this.viewer3DTeamManager.RotationY = 0f;
			this.viewer3DTeamManager.RotationYCoeff = 0.01f;
			this.viewer3DTeamManager.Size = new global::System.Drawing.Size(256, 256);
			this.viewer3DTeamManager.TabIndex = 5;
			this.viewer3DTeamManager.ViewX = 0f;
			this.viewer3DTeamManager.ViewY = 150f;
			this.viewer3DTeamManager.ViewZ = 100f;
			this.viewer3DTeamManager.ZbufferRenderState = null;
			this.toolTeamManager3D.AutoSize = false;
			this.toolTeamManager3D.Dock = global::System.Windows.Forms.DockStyle.None;
			this.toolTeamManager3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolTeamManager3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DManager, this.toolStripSeparator3, this.buttonImportModel3DTeamManager, this.buttonExportModel3DTeamManager, this.toolStripSeparator4, this.buttonDeleteModel3DTeamManager });
			this.toolTeamManager3D.Location = new global::System.Drawing.Point(267, 275);
			this.toolTeamManager3D.Name = "toolTeamManager3D";
			this.toolTeamManager3D.Size = new global::System.Drawing.Size(256, 25);
			this.toolTeamManager3D.TabIndex = 6;
			this.buttonShow3DManager.CheckOnClick = true;
			this.buttonShow3DManager.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DManager.Image");
			this.buttonShow3DManager.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DManager.Name = "buttonShow3DManager";
			this.buttonShow3DManager.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DManager.Text = "Show / Hide";
			this.buttonShow3DManager.Click += new global::System.EventHandler(this.buttonShow3DManager_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.buttonImportModel3DTeamManager.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImportModel3DTeamManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportModel3DTeamManager.Image");
			this.buttonImportModel3DTeamManager.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportModel3DTeamManager.Name = "buttonImportModel3DTeamManager";
			this.buttonImportModel3DTeamManager.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImportModel3DTeamManager.Text = "Import 3D Model";
			this.buttonImportModel3DTeamManager.Click += new global::System.EventHandler(this.buttonImportModel3DTeamManager_Click);
			this.buttonExportModel3DTeamManager.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExportModel3DTeamManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExportModel3DTeamManager.Image");
			this.buttonExportModel3DTeamManager.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExportModel3DTeamManager.Name = "buttonExportModel3DTeamManager";
			this.buttonExportModel3DTeamManager.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExportModel3DTeamManager.Text = "Export 3D Model";
			this.buttonExportModel3DTeamManager.Click += new global::System.EventHandler(this.buttonExportModel3DTeamManager_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.buttonDeleteModel3DTeamManager.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonDeleteModel3DTeamManager.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonDeleteModel3DTeamManager.Image");
			this.buttonDeleteModel3DTeamManager.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonDeleteModel3DTeamManager.Name = "buttonDeleteModel3DTeamManager";
			this.buttonDeleteModel3DTeamManager.Size = new global::System.Drawing.Size(23, 22);
			this.buttonDeleteModel3DTeamManager.Text = "Remove 3D Model";
			this.buttonDeleteModel3DTeamManager.Click += new global::System.EventHandler(this.buttonDeleteModel3DTeamManager_Click);
			this.viewer2DTeamManager.AutoTransparency = false;
			this.viewer2DTeamManager.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DTeamManager.ButtonStripVisible = false;
			this.viewer2DTeamManager.CurrentBitmap = null;
			this.viewer2DTeamManager.ExtendedFormat = false;
			this.viewer2DTeamManager.FullSizeButton = false;
			this.viewer2DTeamManager.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DTeamManager.ImageSize = new global::System.Drawing.Size(1024, 1024);
			this.viewer2DTeamManager.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DTeamManager.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DTeamManager.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DTeamManager.Name = "viewer2DTeamManager";
			this.viewer2DTeamManager.RemoveButton = false;
			this.viewer2DTeamManager.ShowButton = false;
			this.viewer2DTeamManager.ShowButtonChecked = true;
			this.viewer2DTeamManager.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DTeamManager.TabIndex = 4;
			this.viewer2DTeamManager.TabStop = false;
			this.groupTeamScarfRevMod.Controls.Add(this.multiViewer2DTeamScarf);
			this.groupTeamScarfRevMod.Location = new global::System.Drawing.Point(814, 3);
			this.groupTeamScarfRevMod.Name = "groupTeamScarfRevMod";
			this.groupTeamScarfRevMod.Size = new global::System.Drawing.Size(270, 128);
			this.groupTeamScarfRevMod.TabIndex = 165;
			this.groupTeamScarfRevMod.TabStop = false;
			this.groupTeamScarfRevMod.Text = "Unique Scarf";
			this.multiViewer2DTeamScarf.AutoTransparency = false;
			this.multiViewer2DTeamScarf.Bitmaps = null;
			this.multiViewer2DTeamScarf.CheckBitmapSize = true;
			this.multiViewer2DTeamScarf.FixedSize = true;
			this.multiViewer2DTeamScarf.FullSizeButton = false;
			this.multiViewer2DTeamScarf.LabelText = "Scarf n.";
			this.multiViewer2DTeamScarf.Location = new global::System.Drawing.Point(6, 24);
			this.multiViewer2DTeamScarf.Name = "multiViewer2DTeamScarf";
			this.multiViewer2DTeamScarf.ShowButton = false;
			this.multiViewer2DTeamScarf.ShowDeleteButton = false;
			this.multiViewer2DTeamScarf.Size = new global::System.Drawing.Size(256, 90);
			this.multiViewer2DTeamScarf.TabIndex = 155;
			this.groupTeamGoalNetRevMod.Controls.Add(this.viewer2DTeamNet);
			this.groupTeamGoalNetRevMod.Location = new global::System.Drawing.Point(814, 137);
			this.groupTeamGoalNetRevMod.Name = "groupTeamGoalNetRevMod";
			this.groupTeamGoalNetRevMod.Size = new global::System.Drawing.Size(270, 180);
			this.groupTeamGoalNetRevMod.TabIndex = 0;
			this.groupTeamGoalNetRevMod.TabStop = false;
			this.groupTeamGoalNetRevMod.Text = "Unique Goal Net";
			this.viewer2DTeamNet.AutoTransparency = true;
			this.viewer2DTeamNet.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DTeamNet.ButtonStripVisible = false;
			this.viewer2DTeamNet.CurrentBitmap = null;
			this.viewer2DTeamNet.ExtendedFormat = false;
			this.viewer2DTeamNet.FullSizeButton = false;
			this.viewer2DTeamNet.ImageLayout = global::System.Windows.Forms.ImageLayout.Tile;
			this.viewer2DTeamNet.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DTeamNet.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DTeamNet.Location = new global::System.Drawing.Point(67, 19);
			this.viewer2DTeamNet.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DTeamNet.Name = "viewer2DTeamNet";
			this.viewer2DTeamNet.RemoveButton = false;
			this.viewer2DTeamNet.ShowButton = false;
			this.viewer2DTeamNet.ShowButtonChecked = true;
			this.viewer2DTeamNet.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DTeamNet.TabIndex = 2;
			this.viewer2DTeamNet.TabStop = false;
			this.colorDialog.FullOpen = true;
			this.colorDialog.SolidColorOnly = true;
			this.imageListPlayers.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListPlayers.ImageStream");
			this.imageListPlayers.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageListPlayers.Images.SetKeyName(0, "P1.png");
			this.imageListPlayers.Images.SetKeyName(1, "P2.png");
			this.imageListPlayers.Images.SetKeyName(2, "P3.png");
			this.imageListPlayers.Images.SetKeyName(3, "p4.png");
			this.imageListPlayers.Images.SetKeyName(4, "p5.png");
			this.imageListPlayers.Images.SetKeyName(5, "p6.png");
			this.imageListPlayers.Images.SetKeyName(6, "p7.png");
			this.imageListPlayers.Images.SetKeyName(7, "p8.png");
			this.imageListPlayers.Images.SetKeyName(8, "P9.png");
			this.imageListPlayers.Images.SetKeyName(9, "P10.png");
			this.imageListPlayers.Images.SetKeyName(10, "p11.png");
			this.imageListPlayers.Images.SetKeyName(11, "Pnull.png");
			this.imageListArrows.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListArrows.ImageStream");
			this.imageListArrows.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageListArrows.Images.SetKeyName(0, "Move0Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(1, "Move1Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(2, "Move2tYellow.PNG");
			this.imageListArrows.Images.SetKeyName(3, "Move3Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(4, "Move4Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(5, "Move5Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(6, "Move6Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(7, "Move7Yellow.PNG");
			this.imageListArrows.Images.SetKeyName(8, "Move8tYellow.PNG");
			this.imageListArrows.Images.SetKeyName(9, "Move0Red.PNG");
			this.imageListArrows.Images.SetKeyName(10, "Move1Red.PNG");
			this.imageListArrows.Images.SetKeyName(11, "Move2Red.PNG");
			this.imageListArrows.Images.SetKeyName(12, "Move3Red.PNG");
			this.imageListArrows.Images.SetKeyName(13, "Move4Red.PNG");
			this.imageListArrows.Images.SetKeyName(14, "Move5Red.PNG");
			this.imageListArrows.Images.SetKeyName(15, "Move6Red.PNG");
			this.imageListArrows.Images.SetKeyName(16, "Move7Red.PNG");
			this.imageListArrows.Images.SetKeyName(17, "Move8Red.PNG");
			this.imageListArrows.Images.SetKeyName(18, "Move0Blue.PNG");
			this.imageListArrows.Images.SetKeyName(19, "Move1Blue.PNG");
			this.imageListArrows.Images.SetKeyName(20, "Move2Blue.PNG");
			this.imageListArrows.Images.SetKeyName(21, "Move3Blue.PNG");
			this.imageListArrows.Images.SetKeyName(22, "Move4Blue.PNG");
			this.imageListArrows.Images.SetKeyName(23, "Move5Blue.PNG");
			this.imageListArrows.Images.SetKeyName(24, "Move6Blue.PNG");
			this.imageListArrows.Images.SetKeyName(25, "Move7Blue.PNG");
			this.imageListArrows.Images.SetKeyName(26, "Move8Blue.PNG");
			this.imageListArrows.Images.SetKeyName(27, "Move0White.PNG");
			this.imageListArrows.Images.SetKeyName(28, "Move1White.PNG");
			this.imageListArrows.Images.SetKeyName(29, "Move2White.PNG");
			this.imageListArrows.Images.SetKeyName(30, "Move3White.PNG");
			this.imageListArrows.Images.SetKeyName(31, "Move4White.PNG");
			this.imageListArrows.Images.SetKeyName(32, "Move5White.PNG");
			this.imageListArrows.Images.SetKeyName(33, "Move6White.PNG");
			this.imageListArrows.Images.SetKeyName(34, "Move7White.PNG");
			this.imageListArrows.Images.SetKeyName(35, "Move8White.PNG");
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = false;
			this.pickUpControl.CreateButtonEnabled = true;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by League", "by Country" };
			this.pickUpControl.FilterEnabled = true;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = true;
			this.pickUpControl.Margin = new global::System.Windows.Forms.Padding(4);
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = true;
			this.pickUpControl.SearchEnabled = true;
			this.pickUpControl.Size = new global::System.Drawing.Size(1311, 25);
			this.pickUpControl.TabIndex = 4;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			this.formationListBindingSource.DataSource = typeof(global::FifaLibrary.FormationList);
			this.ballListBindingSource.DataSource = typeof(global::FifaLibrary.BallList);
			this.prevLeagueListBindingSource.DataSource = typeof(global::FifaLibrary.LeagueList);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1311, 832);
			base.Controls.Add(this.tableEditTeam);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "TeamForm";
			this.Text = "TeamForm";
			base.Load += new global::System.EventHandler(this.TeamForm_Load);
			this.tableEditTeam.ResumeLayout(false);
			this.pageTeamGeneric.ResumeLayout(false);
			this.flowPanelTeamGeneric.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBoxName.ResumeLayout(false);
			this.groupBoxName.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamBindingSource).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.stadiumListBindingSource).EndInit();
			this.groupManager.ResumeLayout(false);
			this.groupManager.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.leagueListBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamTerColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamPrimColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamSecColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBall).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBall).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericInitialBudget).EndInit();
			this.groupLastYear.ResumeLayout(false);
			this.groupLastYear.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericPositionLastYear).EndInit();
			this.groupLocation.ResumeLayout(false);
			this.groupLocation.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUtcOffset).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLongitude).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLatitude).EndInit();
			this.groupTeamTraits.ResumeLayout(false);
			this.groupTeamTraits.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.pageTeamRoster.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCcpassing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCccrossing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCcshooting).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBusbuildupspeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBuspassing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefmentality).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefaggression).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefteamwidth).EndInit();
			this.groupFormation.ResumeLayout(false);
			this.groupFormation.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupAvailablePlayers.ResumeLayout(false);
			this.panelAvailablePlayersTop.ResumeLayout(false);
			this.panelAvailablePlayersTop.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureAvailablePlayer).EndInit();
			this.groupTeamPlayers.ResumeLayout(false);
			this.panelTeamPlayersTop.ResumeLayout(false);
			this.panelTeamPlayersTop.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRosterYear).EndInit();
			this.groupTeamPlayerTuning.ResumeLayout(false);
			this.pageTeamAdboard.ResumeLayout(false);
			this.pageTeamAdboard.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericAdboards).EndInit();
			this.pageTeamFlags.ResumeLayout(false);
			this.groupFlag.ResumeLayout(false);
			this.groupFlag.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagBlue).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagRed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFlagGreen).EndInit();
			this.pageTeamrevMod.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupTeamAdboardsRevMod.ResumeLayout(false);
			this.groupTeamBallRevMod.ResumeLayout(false);
			this.toolTeamBall3D.ResumeLayout(false);
			this.toolTeamBall3D.PerformLayout();
			this.groupTeamManager.ResumeLayout(false);
			this.toolTeamManager3D.ResumeLayout(false);
			this.toolTeamManager3D.PerformLayout();
			this.groupTeamScarfRevMod.ResumeLayout(false);
			this.groupTeamGoalNetRevMod.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.formationListBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ballListBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.prevLeagueListBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400068D RID: 1677
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400068E RID: 1678
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x0400068F RID: 1679
		private global::System.Windows.Forms.TabControl tableEditTeam;

		// Token: 0x04000690 RID: 1680
		private global::System.Windows.Forms.TabPage pageTeamGeneric;

		// Token: 0x04000691 RID: 1681
		private global::System.Windows.Forms.FlowLayoutPanel flowPanelTeamGeneric;

		// Token: 0x04000692 RID: 1682
		private global::System.Windows.Forms.TabPage pageTeamRoster;

		// Token: 0x04000693 RID: 1683
		private global::System.Windows.Forms.GroupBox groupBoxName;

		// Token: 0x04000694 RID: 1684
		private global::System.Windows.Forms.TextBox textScoreBoardName;

		// Token: 0x04000695 RID: 1685
		private global::System.Windows.Forms.TextBox textDatabaseTeamName;

		// Token: 0x04000696 RID: 1686
		private global::System.Windows.Forms.TextBox textFullTeamName;

		// Token: 0x04000697 RID: 1687
		private global::System.Windows.Forms.TextBox textStandardTeamName;

		// Token: 0x04000698 RID: 1688
		private global::System.Windows.Forms.TextBox textShortTeamName;

		// Token: 0x04000699 RID: 1689
		private global::System.Windows.Forms.Label labelDatabaseTeamName;

		// Token: 0x0400069A RID: 1690
		private global::System.Windows.Forms.Label labelFullTeamName;

		// Token: 0x0400069B RID: 1691
		private global::System.Windows.Forms.Label labelStandardTeamName;

		// Token: 0x0400069C RID: 1692
		private global::System.Windows.Forms.Label labelShortTeamName;

		// Token: 0x0400069D RID: 1693
		private global::System.Windows.Forms.Label labelScoreBoardName;

		// Token: 0x0400069E RID: 1694
		private global::System.Windows.Forms.BindingSource teamBindingSource;

		// Token: 0x0400069F RID: 1695
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x040006A0 RID: 1696
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040006A1 RID: 1697
		private global::System.Windows.Forms.ComboBox comboStadiums;

		// Token: 0x040006A2 RID: 1698
		private global::System.Windows.Forms.BindingSource stadiumListBindingSource;

		// Token: 0x040006A3 RID: 1699
		private global::System.Windows.Forms.Label labelStadium;

		// Token: 0x040006A4 RID: 1700
		private global::System.Windows.Forms.TextBox textStadiumName;

		// Token: 0x040006A5 RID: 1701
		private global::System.Windows.Forms.Label labelStadiumName;

		// Token: 0x040006A6 RID: 1702
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040006A7 RID: 1703
		private global::System.Windows.Forms.ComboBox comboTeamCountry;

		// Token: 0x040006A8 RID: 1704
		private global::System.Windows.Forms.Label labelTeamCountry;

		// Token: 0x040006A9 RID: 1705
		private global::System.Windows.Forms.BindingSource countryListBindingSource;

		// Token: 0x040006AA RID: 1706
		private global::System.Windows.Forms.Label labelOpponent;

		// Token: 0x040006AB RID: 1707
		private global::System.Windows.Forms.BindingSource teamListBindingSource;

		// Token: 0x040006AC RID: 1708
		private global::FifaControls.NumericStars numericStarsInternationalPrestige;

		// Token: 0x040006AD RID: 1709
		private global::FifaControls.NumericStars numericStarsDomesticPrestige;

		// Token: 0x040006AE RID: 1710
		private global::System.Windows.Forms.Label labelDomesticPrestige;

		// Token: 0x040006AF RID: 1711
		private global::System.Windows.Forms.NumericUpDown numericInitialBudget;

		// Token: 0x040006B0 RID: 1712
		private global::System.Windows.Forms.Label labelInternationalPrestige;

		// Token: 0x040006B1 RID: 1713
		private global::System.Windows.Forms.Label labelInitialBudget;

		// Token: 0x040006B2 RID: 1714
		private global::System.Windows.Forms.PictureBox pictureTeamPrimColor;

		// Token: 0x040006B3 RID: 1715
		private global::System.Windows.Forms.PictureBox pictureTeamSecColor;

		// Token: 0x040006B4 RID: 1716
		private global::System.Windows.Forms.PictureBox pictureTeamTerColor;

		// Token: 0x040006B5 RID: 1717
		private global::System.Windows.Forms.ColorDialog colorDialog;

		// Token: 0x040006B6 RID: 1718
		private global::System.Windows.Forms.TabPage pageTeamAdboard;

		// Token: 0x040006B7 RID: 1719
		private global::System.Windows.Forms.TabPage pageTeamFlags;

		// Token: 0x040006B8 RID: 1720
		private global::System.Windows.Forms.BindingSource ballListBindingSource;

		// Token: 0x040006B9 RID: 1721
		public global::System.Windows.Forms.NumericUpDown numericAdboards;

		// Token: 0x040006BA RID: 1722
		private global::FifaControls.Viewer2D viewer2DAdboards_0;

		// Token: 0x040006BB RID: 1723
		private global::System.Windows.Forms.Label labelAdboard;

		// Token: 0x040006BC RID: 1724
		private global::FifaControls.Viewer2D viewer2DBanners;

		// Token: 0x040006BD RID: 1725
		private global::System.Windows.Forms.PictureBox pictureBall;

		// Token: 0x040006BE RID: 1726
		private global::System.Windows.Forms.GroupBox groupAvailablePlayers;

		// Token: 0x040006BF RID: 1727
		private global::System.Windows.Forms.ListView listViewPlayersAvailable;

		// Token: 0x040006C0 RID: 1728
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x040006C1 RID: 1729
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x040006C2 RID: 1730
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x040006C3 RID: 1731
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x040006C4 RID: 1732
		private global::System.Windows.Forms.Panel panelAvailablePlayersTop;

		// Token: 0x040006C5 RID: 1733
		private global::System.Windows.Forms.Button buttonTransferFrom;

		// Token: 0x040006C6 RID: 1734
		private global::FifaControls.PickUpControl pickUpAvailablePlayers;

		// Token: 0x040006C7 RID: 1735
		private global::System.Windows.Forms.Button buttonCall;

		// Token: 0x040006C8 RID: 1736
		private global::System.Windows.Forms.Label labelAvailablePlayerStars;

		// Token: 0x040006C9 RID: 1737
		private global::System.Windows.Forms.Label labelRosterNameFrom;

		// Token: 0x040006CA RID: 1738
		private global::System.Windows.Forms.PictureBox pictureAvailablePlayer;

		// Token: 0x040006CB RID: 1739
		private global::System.Windows.Forms.GroupBox groupTeamPlayers;

		// Token: 0x040006CC RID: 1740
		private global::System.Windows.Forms.ListView listViewTeamPlayers;

		// Token: 0x040006CD RID: 1741
		private global::System.Windows.Forms.ColumnHeader columnRosterNum;

		// Token: 0x040006CE RID: 1742
		private global::System.Windows.Forms.ColumnHeader columnRosterSurname;

		// Token: 0x040006CF RID: 1743
		private global::System.Windows.Forms.ColumnHeader columnRosterFirstName;

		// Token: 0x040006D0 RID: 1744
		private global::System.Windows.Forms.ColumnHeader columnRosterYearContract;

		// Token: 0x040006D1 RID: 1745
		private global::System.Windows.Forms.ColumnHeader columnPreferredRole;

		// Token: 0x040006D2 RID: 1746
		private global::System.Windows.Forms.ColumnHeader columnAverageAttributes;

		// Token: 0x040006D3 RID: 1747
		private global::System.Windows.Forms.Panel panelTeamPlayersTop;

		// Token: 0x040006D4 RID: 1748
		private global::System.Windows.Forms.NumericUpDown numericRosterYear;

		// Token: 0x040006D5 RID: 1749
		private global::System.Windows.Forms.Label labelTeamPlayerStars;

		// Token: 0x040006D6 RID: 1750
		private global::System.Windows.Forms.Label labelRosterName;

		// Token: 0x040006D7 RID: 1751
		private global::System.Windows.Forms.ComboBox comboRosterNumber;

		// Token: 0x040006D8 RID: 1752
		private global::System.Windows.Forms.Button buttonTransferPlayer;

		// Token: 0x040006D9 RID: 1753
		private global::System.Windows.Forms.Button buttonRosterLetFree;

		// Token: 0x040006DA RID: 1754
		private global::System.Windows.Forms.Label labelRosterNumber;

		// Token: 0x040006DB RID: 1755
		private global::System.Windows.Forms.ImageList imageListStars;

		// Token: 0x040006DC RID: 1756
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040006DD RID: 1757
		private global::System.Windows.Forms.NumericUpDown numericBall;

		// Token: 0x040006DE RID: 1758
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x040006DF RID: 1759
		private global::System.Windows.Forms.NumericUpDown numericTeamId;

		// Token: 0x040006E0 RID: 1760
		private global::System.Windows.Forms.Label labelTeamId;

		// Token: 0x040006E1 RID: 1761
		private global::System.Windows.Forms.DateTimePicker dateJoiningDate;

		// Token: 0x040006E2 RID: 1762
		private global::System.Windows.Forms.Label labelJoiningDate;

		// Token: 0x040006E3 RID: 1763
		private global::System.Windows.Forms.BindingSource formationListBindingSource;

		// Token: 0x040006E4 RID: 1764
		private global::System.Windows.Forms.ImageList imageListPlayers;

		// Token: 0x040006E5 RID: 1765
		private global::FifaControls.Viewer2D viewer2DCrest32;

		// Token: 0x040006E6 RID: 1766
		private global::FifaControls.Viewer2D viewer2DCrestLarge;

		// Token: 0x040006E7 RID: 1767
		private global::FifaControls.Viewer2D viewer2DCrest16;

		// Token: 0x040006E8 RID: 1768
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040006E9 RID: 1769
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040006EA RID: 1770
		private global::System.Windows.Forms.Button buttonReplicateLogo;

		// Token: 0x040006EB RID: 1771
		private global::System.Windows.Forms.GroupBox groupManager;

		// Token: 0x040006EC RID: 1772
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x040006ED RID: 1773
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040006EE RID: 1774
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040006EF RID: 1775
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040006F0 RID: 1776
		private global::System.Windows.Forms.ImageList imageListArrows;

		// Token: 0x040006F1 RID: 1777
		private global::System.Windows.Forms.GroupBox groupLastYear;

		// Token: 0x040006F2 RID: 1778
		private global::System.Windows.Forms.CheckBox checkIsChampion;

		// Token: 0x040006F3 RID: 1779
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040006F4 RID: 1780
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040006F5 RID: 1781
		private global::System.Windows.Forms.NumericUpDown numericPositionLastYear;

		// Token: 0x040006F6 RID: 1782
		private global::System.Windows.Forms.ComboBox comboPrevLeague;

		// Token: 0x040006F7 RID: 1783
		private global::System.Windows.Forms.BindingSource leagueListBindingSource;

		// Token: 0x040006F8 RID: 1784
		private global::System.Windows.Forms.Label labelLeague;

		// Token: 0x040006F9 RID: 1785
		private global::System.Windows.Forms.ComboBox comboTeamLeague;

		// Token: 0x040006FA RID: 1786
		private global::System.Windows.Forms.BindingSource prevLeagueListBindingSource;

		// Token: 0x040006FB RID: 1787
		private global::System.Windows.Forms.ComboBox comboRivalTeam;

		// Token: 0x040006FC RID: 1788
		private global::System.Windows.Forms.ComboBox comboObjective;

		// Token: 0x040006FD RID: 1789
		private global::System.Windows.Forms.Label labelObjective;

		// Token: 0x040006FE RID: 1790
		private global::System.Windows.Forms.Label labelProbObjective;

		// Token: 0x040006FF RID: 1791
		private global::System.Windows.Forms.Label labelMaxObjective;

		// Token: 0x04000700 RID: 1792
		private global::System.Windows.Forms.ComboBox comboProbObjective;

		// Token: 0x04000701 RID: 1793
		private global::System.Windows.Forms.ComboBox comboMaxOnjective;

		// Token: 0x04000702 RID: 1794
		private global::System.Windows.Forms.GroupBox groupTeamTraits;

		// Token: 0x04000703 RID: 1795
		private global::System.Windows.Forms.CheckBox checkShortOutBack;

		// Token: 0x04000704 RID: 1796
		private global::System.Windows.Forms.CheckBox checkMoreAttackingAtHome;

		// Token: 0x04000705 RID: 1797
		private global::System.Windows.Forms.CheckBox checkCenterBacksSplit;

		// Token: 0x04000706 RID: 1798
		private global::System.Windows.Forms.CheckBox checkSwitchWingers;

		// Token: 0x04000707 RID: 1799
		private global::System.Windows.Forms.CheckBox checkKeepUpPressure;

		// Token: 0x04000708 RID: 1800
		private global::System.Windows.Forms.CheckBox checkDefendLead;

		// Token: 0x04000709 RID: 1801
		private global::System.Windows.Forms.CheckBox checkConsistentLineup;

		// Token: 0x0400070A RID: 1802
		private global::System.Windows.Forms.CheckBox checkSquadRotation;

		// Token: 0x0400070B RID: 1803
		private global::System.Windows.Forms.CheckBox checkLoyalBoard;

		// Token: 0x0400070C RID: 1804
		private global::System.Windows.Forms.CheckBox checkImpatientBoard;

		// Token: 0x0400070D RID: 1805
		private global::FifaControls.Viewer2D viewer2DCrest50;

		// Token: 0x0400070E RID: 1806
		private global::System.Windows.Forms.Button buttonMinusContract;

		// Token: 0x0400070F RID: 1807
		private global::System.Windows.Forms.Button buttonPlusContract;

		// Token: 0x04000710 RID: 1808
		private global::System.Windows.Forms.GroupBox groupTeamPlayerTuning;

		// Token: 0x04000711 RID: 1809
		private global::System.Windows.Forms.Button buttonTeamPlayerMinus;

		// Token: 0x04000712 RID: 1810
		private global::System.Windows.Forms.Button buttonTeamPlayerPlus;

		// Token: 0x04000713 RID: 1811
		private global::System.Windows.Forms.GroupBox groupFlag;

		// Token: 0x04000714 RID: 1812
		private global::System.Windows.Forms.Label labelFlag1;

		// Token: 0x04000715 RID: 1813
		private global::System.Windows.Forms.ImageList imageListFlags;

		// Token: 0x04000716 RID: 1814
		private global::System.Windows.Forms.Label labelFlag4;

		// Token: 0x04000717 RID: 1815
		private global::System.Windows.Forms.Label labelFlag3;

		// Token: 0x04000718 RID: 1816
		private global::System.Windows.Forms.Label labelFlag2;

		// Token: 0x04000719 RID: 1817
		private global::System.Windows.Forms.CheckBox checkFlag4;

		// Token: 0x0400071A RID: 1818
		private global::System.Windows.Forms.CheckBox checkFlag3;

		// Token: 0x0400071B RID: 1819
		private global::System.Windows.Forms.CheckBox checkFlag2;

		// Token: 0x0400071C RID: 1820
		private global::System.Windows.Forms.CheckBox checkFlag1;

		// Token: 0x0400071D RID: 1821
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x0400071E RID: 1822
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400071F RID: 1823
		private global::System.Windows.Forms.PictureBox pictureFlagBlue;

		// Token: 0x04000720 RID: 1824
		private global::System.Windows.Forms.PictureBox pictureFlagRed;

		// Token: 0x04000721 RID: 1825
		private global::System.Windows.Forms.PictureBox pictureFlagGreen;

		// Token: 0x04000722 RID: 1826
		private global::System.Windows.Forms.Button buttonCreateFlags;

		// Token: 0x04000723 RID: 1827
		private global::System.Windows.Forms.CheckBox checkHasSpecificAdboard;

		// Token: 0x04000724 RID: 1828
		private global::System.Windows.Forms.GroupBox groupLocation;

		// Token: 0x04000725 RID: 1829
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000726 RID: 1830
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000727 RID: 1831
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000728 RID: 1832
		private global::FifaControls.MultiViewer2D multiViewer2DFlags15;

		// Token: 0x04000729 RID: 1833
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400072A RID: 1834
		private global::System.Windows.Forms.Label labelPos33U;

		// Token: 0x0400072B RID: 1835
		private global::System.Windows.Forms.Label labelPos33T;

		// Token: 0x0400072C RID: 1836
		private global::System.Windows.Forms.Label labelPos33S;

		// Token: 0x0400072D RID: 1837
		private global::System.Windows.Forms.Label labelPos33R;

		// Token: 0x0400072E RID: 1838
		private global::System.Windows.Forms.Label labelPos33Q;

		// Token: 0x0400072F RID: 1839
		private global::System.Windows.Forms.Label labelPos33O;

		// Token: 0x04000730 RID: 1840
		private global::System.Windows.Forms.Label labelPos33P;

		// Token: 0x04000731 RID: 1841
		private global::System.Windows.Forms.Label labelPos33N;

		// Token: 0x04000732 RID: 1842
		private global::System.Windows.Forms.Label labelPos33M;

		// Token: 0x04000733 RID: 1843
		private global::System.Windows.Forms.Label labelPos33L;

		// Token: 0x04000734 RID: 1844
		private global::System.Windows.Forms.Label labelPos33K;

		// Token: 0x04000735 RID: 1845
		private global::System.Windows.Forms.Label labelPos33J;

		// Token: 0x04000736 RID: 1846
		private global::System.Windows.Forms.Label labelPos33H;

		// Token: 0x04000737 RID: 1847
		private global::System.Windows.Forms.Label labelPos33I;

		// Token: 0x04000738 RID: 1848
		private global::System.Windows.Forms.Label labelPos33G;

		// Token: 0x04000739 RID: 1849
		private global::System.Windows.Forms.Label labelPos33F;

		// Token: 0x0400073A RID: 1850
		private global::System.Windows.Forms.Label labelPos33E;

		// Token: 0x0400073B RID: 1851
		private global::System.Windows.Forms.Label labelPos33D;

		// Token: 0x0400073C RID: 1852
		private global::System.Windows.Forms.Label labelPos33C;

		// Token: 0x0400073D RID: 1853
		private global::System.Windows.Forms.Label labelPos33A;

		// Token: 0x0400073E RID: 1854
		private global::System.Windows.Forms.Label labelPos33B;

		// Token: 0x0400073F RID: 1855
		private global::System.Windows.Forms.Label labelPos32G;

		// Token: 0x04000740 RID: 1856
		private global::System.Windows.Forms.Label labelPos32F;

		// Token: 0x04000741 RID: 1857
		private global::System.Windows.Forms.Label labelPos32E;

		// Token: 0x04000742 RID: 1858
		private global::System.Windows.Forms.Label labelPos32D;

		// Token: 0x04000743 RID: 1859
		private global::System.Windows.Forms.Label labelPos32C;

		// Token: 0x04000744 RID: 1860
		private global::System.Windows.Forms.Label labelPos32A;

		// Token: 0x04000745 RID: 1861
		private global::System.Windows.Forms.Label labelPos32B;

		// Token: 0x04000746 RID: 1862
		private global::System.Windows.Forms.Label labelPos26;

		// Token: 0x04000747 RID: 1863
		private global::System.Windows.Forms.Label labelPos27;

		// Token: 0x04000748 RID: 1864
		private global::System.Windows.Forms.Label labelPos21;

		// Token: 0x04000749 RID: 1865
		private global::System.Windows.Forms.Label labelPos22;

		// Token: 0x0400074A RID: 1866
		private global::System.Windows.Forms.Label labelPos23;

		// Token: 0x0400074B RID: 1867
		private global::System.Windows.Forms.Label labelPos24;

		// Token: 0x0400074C RID: 1868
		private global::System.Windows.Forms.Label labelPos25;

		// Token: 0x0400074D RID: 1869
		private global::System.Windows.Forms.Label labelPos14;

		// Token: 0x0400074E RID: 1870
		private global::System.Windows.Forms.Label labelPos15;

		// Token: 0x0400074F RID: 1871
		private global::System.Windows.Forms.Label labelPos16;

		// Token: 0x04000750 RID: 1872
		private global::System.Windows.Forms.Label labelPos17;

		// Token: 0x04000751 RID: 1873
		private global::System.Windows.Forms.Label labelPos18;

		// Token: 0x04000752 RID: 1874
		private global::System.Windows.Forms.Label labelPos20;

		// Token: 0x04000753 RID: 1875
		private global::System.Windows.Forms.Label labelPos19;

		// Token: 0x04000754 RID: 1876
		private global::System.Windows.Forms.Label labelPos9;

		// Token: 0x04000755 RID: 1877
		private global::System.Windows.Forms.Label labelPos10;

		// Token: 0x04000756 RID: 1878
		private global::System.Windows.Forms.Label labelPos11;

		// Token: 0x04000757 RID: 1879
		private global::System.Windows.Forms.Label labelPos12;

		// Token: 0x04000758 RID: 1880
		private global::System.Windows.Forms.Label labelPos13;

		// Token: 0x04000759 RID: 1881
		private global::System.Windows.Forms.Label labelPos2;

		// Token: 0x0400075A RID: 1882
		private global::System.Windows.Forms.Label labelPos3;

		// Token: 0x0400075B RID: 1883
		private global::System.Windows.Forms.Label labelPos4;

		// Token: 0x0400075C RID: 1884
		private global::System.Windows.Forms.Label labelPos5;

		// Token: 0x0400075D RID: 1885
		private global::System.Windows.Forms.Label labelPos6;

		// Token: 0x0400075E RID: 1886
		private global::System.Windows.Forms.Label labelPos8;

		// Token: 0x0400075F RID: 1887
		private global::System.Windows.Forms.Label labelPos7;

		// Token: 0x04000760 RID: 1888
		private global::System.Windows.Forms.Label labelPos0;

		// Token: 0x04000761 RID: 1889
		private global::System.Windows.Forms.Label labelPos1;

		// Token: 0x04000762 RID: 1890
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000763 RID: 1891
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000764 RID: 1892
		private global::System.Windows.Forms.ComboBox comboDEFLine;

		// Token: 0x04000765 RID: 1893
		private global::System.Windows.Forms.NumericUpDown numericDefteamwidth;

		// Token: 0x04000766 RID: 1894
		private global::System.Windows.Forms.NumericUpDown numericDefaggression;

		// Token: 0x04000767 RID: 1895
		private global::System.Windows.Forms.NumericUpDown numericDefmentality;

		// Token: 0x04000768 RID: 1896
		private global::System.Windows.Forms.Label labelDefdefendeline;

		// Token: 0x04000769 RID: 1897
		private global::System.Windows.Forms.Label labelDefteamwidth;

		// Token: 0x0400076A RID: 1898
		private global::System.Windows.Forms.Label labelDefaggression;

		// Token: 0x0400076B RID: 1899
		private global::System.Windows.Forms.Label labelDefmentality;

		// Token: 0x0400076C RID: 1900
		private global::System.Windows.Forms.ComboBox comboCCPositioning;

		// Token: 0x0400076D RID: 1901
		private global::System.Windows.Forms.NumericUpDown numericCcshooting;

		// Token: 0x0400076E RID: 1902
		private global::System.Windows.Forms.NumericUpDown numericCccrossing;

		// Token: 0x0400076F RID: 1903
		private global::System.Windows.Forms.NumericUpDown numericCcpassing;

		// Token: 0x04000770 RID: 1904
		private global::System.Windows.Forms.Label labelCcpositioning;

		// Token: 0x04000771 RID: 1905
		private global::System.Windows.Forms.Label labelCcshooting;

		// Token: 0x04000772 RID: 1906
		private global::System.Windows.Forms.Label labelCccrossing;

		// Token: 0x04000773 RID: 1907
		private global::System.Windows.Forms.Label labelCcpassing;

		// Token: 0x04000774 RID: 1908
		private global::System.Windows.Forms.ComboBox comboBUSPositioning;

		// Token: 0x04000775 RID: 1909
		private global::System.Windows.Forms.NumericUpDown numericBuspassing;

		// Token: 0x04000776 RID: 1910
		private global::System.Windows.Forms.NumericUpDown numericBusbuildupspeed;

		// Token: 0x04000777 RID: 1911
		private global::System.Windows.Forms.Label labelBuspositioning;

		// Token: 0x04000778 RID: 1912
		private global::System.Windows.Forms.Label labelBuspassing;

		// Token: 0x04000779 RID: 1913
		private global::System.Windows.Forms.Label labelBusbuildupspeed;

		// Token: 0x0400077A RID: 1914
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x0400077B RID: 1915
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400077C RID: 1916
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400077D RID: 1917
		private global::System.Windows.Forms.Label labelRightFreeKickText;

		// Token: 0x0400077E RID: 1918
		private global::System.Windows.Forms.Label labelRightFreeKick;

		// Token: 0x0400077F RID: 1919
		private global::System.Windows.Forms.Label labelLeftFreeKickText;

		// Token: 0x04000780 RID: 1920
		private global::System.Windows.Forms.Label labelLeftFreeKick;

		// Token: 0x04000781 RID: 1921
		private global::System.Windows.Forms.GroupBox groupFormation;

		// Token: 0x04000782 RID: 1922
		private global::System.Windows.Forms.ComboBox comboGenericFormations;

		// Token: 0x04000783 RID: 1923
		private global::System.Windows.Forms.RadioButton radioUseSpecificFormation;

		// Token: 0x04000784 RID: 1924
		private global::System.Windows.Forms.RadioButton radioUseGenericFormation;

		// Token: 0x04000785 RID: 1925
		private global::System.Windows.Forms.Label labelLongKick;

		// Token: 0x04000786 RID: 1926
		private global::System.Windows.Forms.Label labelLomgKickText;

		// Token: 0x04000787 RID: 1927
		private global::System.Windows.Forms.Label labelRightCornerText;

		// Token: 0x04000788 RID: 1928
		private global::System.Windows.Forms.Label labelCaptainTetx;

		// Token: 0x04000789 RID: 1929
		private global::System.Windows.Forms.Label labelLeftCornertext;

		// Token: 0x0400078A RID: 1930
		private global::System.Windows.Forms.Label labelRightCorner;

		// Token: 0x0400078B RID: 1931
		private global::System.Windows.Forms.Label labelCaptain;

		// Token: 0x0400078C RID: 1932
		private global::System.Windows.Forms.Label labelLeftCorner;

		// Token: 0x0400078D RID: 1933
		private global::System.Windows.Forms.Label labelFreeKickText;

		// Token: 0x0400078E RID: 1934
		private global::System.Windows.Forms.Label labelPenaltyText;

		// Token: 0x0400078F RID: 1935
		private global::System.Windows.Forms.Label labelPenalty;

		// Token: 0x04000790 RID: 1936
		private global::System.Windows.Forms.Label labelFreeKick;

		// Token: 0x04000791 RID: 1937
		private global::System.Windows.Forms.Label labelTeamFormationName;

		// Token: 0x04000792 RID: 1938
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000793 RID: 1939
		private global::FifaControls.Viewer2D viewer2DPhoto;

		// Token: 0x04000794 RID: 1940
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000795 RID: 1941
		private global::System.Windows.Forms.TextBox textTeamName7;

		// Token: 0x04000796 RID: 1942
		private global::System.Windows.Forms.NumericUpDown numericUtcOffset;

		// Token: 0x04000797 RID: 1943
		private global::System.Windows.Forms.NumericUpDown numericLongitude;

		// Token: 0x04000798 RID: 1944
		private global::System.Windows.Forms.NumericUpDown numericLatitude;

		// Token: 0x04000799 RID: 1945
		private global::System.Windows.Forms.TabPage pageTeamrevMod;

		// Token: 0x0400079A RID: 1946
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x0400079B RID: 1947
		private global::System.Windows.Forms.GroupBox groupTeamAdboardsRevMod;

		// Token: 0x0400079C RID: 1948
		private global::FifaControls.Viewer2D viewer2DTeamAdboard;

		// Token: 0x0400079D RID: 1949
		private global::System.Windows.Forms.GroupBox groupTeamGoalNetRevMod;

		// Token: 0x0400079E RID: 1950
		private global::FifaControls.Viewer2D viewer2DTeamNet;

		// Token: 0x0400079F RID: 1951
		private global::System.Windows.Forms.GroupBox groupTeamScarfRevMod;

		// Token: 0x040007A0 RID: 1952
		private global::FifaControls.MultiViewer2D multiViewer2DTeamScarf;

		// Token: 0x040007A1 RID: 1953
		private global::System.Windows.Forms.GroupBox groupTeamBallRevMod;

		// Token: 0x040007A2 RID: 1954
		private global::FifaControls.MultiViewer2D multiViewer2DTeamBallTextures;

		// Token: 0x040007A3 RID: 1955
		private global::FifaControls.Viewer3D viewer3DTeamBall;

		// Token: 0x040007A4 RID: 1956
		private global::System.Windows.Forms.ToolStrip toolTeamBall3D;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Forms.ToolStripButton buttonShow3DBall;

		// Token: 0x040007A6 RID: 1958
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040007A7 RID: 1959
		private global::System.Windows.Forms.ToolStripButton buttonImport3DModelTeamBall;

		// Token: 0x040007A8 RID: 1960
		private global::System.Windows.Forms.ToolStripButton buttonExport3DModelTeamBall;

		// Token: 0x040007A9 RID: 1961
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040007AA RID: 1962
		private global::System.Windows.Forms.ToolStripButton buttonRemove3DModelTeamBall;

		// Token: 0x040007AB RID: 1963
		private global::System.Windows.Forms.GroupBox groupTeamManager;

		// Token: 0x040007AC RID: 1964
		private global::FifaControls.Viewer3D viewer3DTeamManager;

		// Token: 0x040007AD RID: 1965
		private global::System.Windows.Forms.ToolStrip toolTeamManager3D;

		// Token: 0x040007AE RID: 1966
		private global::System.Windows.Forms.ToolStripButton buttonShow3DManager;

		// Token: 0x040007AF RID: 1967
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040007B0 RID: 1968
		private global::System.Windows.Forms.ToolStripButton buttonImportModel3DTeamManager;

		// Token: 0x040007B1 RID: 1969
		private global::System.Windows.Forms.ToolStripButton buttonExportModel3DTeamManager;

		// Token: 0x040007B2 RID: 1970
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040007B3 RID: 1971
		private global::System.Windows.Forms.ToolStripButton buttonDeleteModel3DTeamManager;

		// Token: 0x040007B4 RID: 1972
		private global::FifaControls.Viewer2D viewer2DTeamManager;

		// Token: 0x040007B5 RID: 1973
		private global::System.Windows.Forms.CheckBox checkIsNationalTeam;

		// Token: 0x040007B6 RID: 1974
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040007B7 RID: 1975
		private global::System.Windows.Forms.DateTimePicker dateTransferPreset;

		// Token: 0x040007B8 RID: 1976
		private global::System.Windows.Forms.Button buttonLoanFrom;

		// Token: 0x040007B9 RID: 1977
		private global::System.Windows.Forms.Button buttonLoanTo;

		// Token: 0x040007BA RID: 1978
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x040007BB RID: 1979
		private global::System.Windows.Forms.Label labelHomeKit;

		// Token: 0x040007BC RID: 1980
		private global::System.Windows.Forms.Label labelThirdKit;

		// Token: 0x040007BD RID: 1981
		private global::System.Windows.Forms.Label labelKeeprKit;

		// Token: 0x040007BE RID: 1982
		private global::System.Windows.Forms.Label labelAwayKit;

		// Token: 0x040007BF RID: 1983
		private global::System.Windows.Forms.ComboBox comboTeamLoanedFrom;

		// Token: 0x040007C0 RID: 1984
		private global::System.Windows.Forms.Label labelLoanedFrom;

		// Token: 0x040007C1 RID: 1985
		private global::System.Windows.Forms.DateTimePicker dateLoanEnd;

		// Token: 0x040007C2 RID: 1986
		private global::System.Windows.Forms.Label labelLoanEnd;

		// Token: 0x040007C3 RID: 1987
		private global::System.Windows.Forms.CheckBox checkIsLoan;

		// Token: 0x040007C4 RID: 1988
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040007C5 RID: 1989
		private global::System.Windows.Forms.Label labelPreviousTeam;

		// Token: 0x040007C6 RID: 1990
		private global::System.Windows.Forms.ComboBox comboTeamPrevious;

		// Token: 0x040007C7 RID: 1991
		private global::System.Windows.Forms.Button buttonDeletePlayer;
	}
}
