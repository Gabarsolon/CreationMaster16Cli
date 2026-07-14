namespace CreationMaster
{
	// Token: 0x02000010 RID: 16
	public partial class PlayerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000298 RID: 664 RVA: 0x00035B08 File Offset: 0x00033D08
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00035B28 File Offset: 0x00033D28
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.PlayerForm));
			this.tabEditPlayer = new global::System.Windows.Forms.TabControl();
			this.pageInfo = new global::System.Windows.Forms.TabPage();
			this.flowPanelInfo = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupPlayerIdentity = new global::System.Windows.Forms.GroupBox();
			this.radioButtonGenderFemale = new global::System.Windows.Forms.RadioButton();
			this.playerBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.radioButtonGenderMale = new global::System.Windows.Forms.RadioButton();
			this.labelCommonName = new global::System.Windows.Forms.Label();
			this.textCommonName = new global::System.Windows.Forms.TextBox();
			this.textJerseyName = new global::System.Windows.Forms.TextBox();
			this.labelJerseyName = new global::System.Windows.Forms.Label();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.viewer2DPhoto = new global::FifaControls.Viewer2D();
			this.numericPlayerId = new global::System.Windows.Forms.NumericUpDown();
			this.buttonRandomizeIdentity = new global::System.Windows.Forms.Button();
			this.dateBirthDate = new global::System.Windows.Forms.DateTimePicker();
			this.labelBirthdate = new global::System.Windows.Forms.Label();
			this.labelPlayerId = new global::System.Windows.Forms.Label();
			this.textSurname = new global::System.Windows.Forms.TextBox();
			this.textFirstName = new global::System.Windows.Forms.TextBox();
			this.comboCountry = new global::System.Windows.Forms.ComboBox();
			this.countryListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelFirstName = new global::System.Windows.Forms.Label();
			this.labelSurame = new global::System.Windows.Forms.Label();
			this.labelCountry = new global::System.Windows.Forms.Label();
			this.groupBoxBody = new global::System.Windows.Forms.GroupBox();
			this.comboWeakFoot = new global::System.Windows.Forms.ComboBox();
			this.labelWeakFoot = new global::System.Windows.Forms.Label();
			this.comboBody = new global::System.Windows.Forms.ComboBox();
			this.numericHeight = new global::System.Windows.Forms.NumericUpDown();
			this.numericWeight = new global::System.Windows.Forms.NumericUpDown();
			this.labelWeight = new global::System.Windows.Forms.Label();
			this.labelBody = new global::System.Windows.Forms.Label();
			this.domainPreferredFoot = new global::System.Windows.Forms.DomainUpDown();
			this.labelHeight = new global::System.Windows.Forms.Label();
			this.labelPreferredFoot = new global::System.Windows.Forms.Label();
			this.groupBoxLook = new global::System.Windows.Forms.GroupBox();
			this.checkJerseyFit = new global::System.Windows.Forms.CheckBox();
			this.checkTrainingPants = new global::System.Windows.Forms.CheckBox();
			this.domainSocksStyle = new global::System.Windows.Forms.DomainUpDown();
			this.label8 = new global::System.Windows.Forms.Label();
			this.numericGkGloves = new global::System.Windows.Forms.NumericUpDown();
			this.labelGkGloves = new global::System.Windows.Forms.Label();
			this.labelWinter = new global::System.Windows.Forms.Label();
			this.comboWinterAccessories = new global::System.Windows.Forms.ComboBox();
			this.domainJerseyStyle = new global::System.Windows.Forms.DomainUpDown();
			this.domainSleeves = new global::System.Windows.Forms.DomainUpDown();
			this.pictureColorAcc2 = new global::System.Windows.Forms.PictureBox();
			this.pictureColorAcc3 = new global::System.Windows.Forms.PictureBox();
			this.pictureColorAcc4 = new global::System.Windows.Forms.PictureBox();
			this.pictureColorAcc1 = new global::System.Windows.Forms.PictureBox();
			this.domainAccessory4 = new global::System.Windows.Forms.ComboBox();
			this.domainAccessory3 = new global::System.Windows.Forms.ComboBox();
			this.domainAccessory2 = new global::System.Windows.Forms.ComboBox();
			this.domainAccessory1 = new global::System.Windows.Forms.ComboBox();
			this.labelSleeves = new global::System.Windows.Forms.Label();
			this.labelJerseyStyle = new global::System.Windows.Forms.Label();
			this.labelAccesories = new global::System.Windows.Forms.Label();
			this.groupPlayFirTeam = new global::System.Windows.Forms.GroupBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.groupIsLoan = new global::System.Windows.Forms.GroupBox();
			this.comboTeamLoanedFrom = new global::System.Windows.Forms.ComboBox();
			this.teamListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.label12 = new global::System.Windows.Forms.Label();
			this.dateLoanEnd = new global::System.Windows.Forms.DateTimePicker();
			this.label11 = new global::System.Windows.Forms.Label();
			this.checkIsLoan = new global::System.Windows.Forms.CheckBox();
			this.dateJoiningDate = new global::System.Windows.Forms.DateTimePicker();
			this.label4 = new global::System.Windows.Forms.Label();
			this.listViewPlayingTeams = new global::System.Windows.Forms.ListView();
			this.imageListTeamLogos = new global::System.Windows.Forms.ImageList(this.components);
			this.comboClubTeam = new global::System.Windows.Forms.ComboBox();
			this.buttonCallNationalTeam = new global::System.Windows.Forms.Button();
			this.buttonRemoveNationalTeam = new global::System.Windows.Forms.Button();
			this.groupShoes = new global::System.Windows.Forms.GroupBox();
			this.label1ShoesType = new global::System.Windows.Forms.Label();
			this.pictureColorShoes2 = new global::System.Windows.Forms.PictureBox();
			this.pictureColorShoes1 = new global::System.Windows.Forms.PictureBox();
			this.numericShoesBrand = new global::System.Windows.Forms.NumericUpDown();
			this.labelShoesType = new global::System.Windows.Forms.Label();
			this.labelShoesColor = new global::System.Windows.Forms.Label();
			this.numericShoesDesign = new global::System.Windows.Forms.NumericUpDown();
			this.viewer2DShoes = new global::FifaControls.Viewer2D();
			this.labelShoes = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.labelPreferredPositions = new global::System.Windows.Forms.Label();
			this.comboPreferredPosition4 = new global::System.Windows.Forms.ComboBox();
			this.comboPreferredPosition3 = new global::System.Windows.Forms.ComboBox();
			this.comboPreferredPosition2 = new global::System.Windows.Forms.ComboBox();
			this.comboPreferredPosition1 = new global::System.Windows.Forms.ComboBox();
			this.domainInternationalReputation = new global::System.Windows.Forms.DomainUpDown();
			this.labelInternationalReputation = new global::System.Windows.Forms.Label();
			this.pageSkills = new global::System.Windows.Forms.TabPage();
			this.flowPanelSkills = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupGenerateAttributes = new global::System.Windows.Forms.GroupBox();
			this.labelOverallrating = new global::System.Windows.Forms.Label();
			this.trackOverallrating = new global::System.Windows.Forms.TrackBar();
			this.labelRandomize = new global::System.Windows.Forms.Label();
			this.numericRandomize = new global::System.Windows.Forms.NumericUpDown();
			this.buttonRandomAboveAvg = new global::System.Windows.Forms.Button();
			this.buttonRandomBelowAvg = new global::System.Windows.Forms.Button();
			this.buttonRandomSuperstar = new global::System.Windows.Forms.Button();
			this.buttonRandomVeryGood = new global::System.Windows.Forms.Button();
			this.buttonRandomGood = new global::System.Windows.Forms.Button();
			this.buttonRandomAverage = new global::System.Windows.Forms.Button();
			this.buttonRandomPoor = new global::System.Windows.Forms.Button();
			this.groupGoalkeperSkills = new global::System.Windows.Forms.GroupBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.comboGkSaveStyle = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelGkKick = new global::System.Windows.Forms.Label();
			this.comboGkKickStyle = new global::System.Windows.Forms.ComboBox();
			this.trackGkKicking = new global::System.Windows.Forms.TrackBar();
			this.labelDiving = new global::System.Windows.Forms.Label();
			this.labelPositioning = new global::System.Windows.Forms.Label();
			this.labelReflexes = new global::System.Windows.Forms.Label();
			this.labelHandling = new global::System.Windows.Forms.Label();
			this.trackDiving = new global::System.Windows.Forms.TrackBar();
			this.trackPositioning = new global::System.Windows.Forms.TrackBar();
			this.trackReflexes = new global::System.Windows.Forms.TrackBar();
			this.trackHandling = new global::System.Windows.Forms.TrackBar();
			this.numericGoalkeeperSkills = new global::System.Windows.Forms.NumericUpDown();
			this.groupDefensiveSkills = new global::System.Windows.Forms.GroupBox();
			this.labelInterception = new global::System.Windows.Forms.Label();
			this.trackInterception = new global::System.Windows.Forms.TrackBar();
			this.labelSliding = new global::System.Windows.Forms.Label();
			this.trackSliding = new global::System.Windows.Forms.TrackBar();
			this.numericDefensiveSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelAggression = new global::System.Windows.Forms.Label();
			this.labelMarking = new global::System.Windows.Forms.Label();
			this.labelTackling = new global::System.Windows.Forms.Label();
			this.trackTackling = new global::System.Windows.Forms.TrackBar();
			this.trackMarking = new global::System.Windows.Forms.TrackBar();
			this.trackAggression = new global::System.Windows.Forms.TrackBar();
			this.groupMidfielderSkills = new global::System.Windows.Forms.GroupBox();
			this.labelCurve = new global::System.Windows.Forms.Label();
			this.trackCurve = new global::System.Windows.Forms.TrackBar();
			this.labelVision = new global::System.Windows.Forms.Label();
			this.trackVision = new global::System.Windows.Forms.TrackBar();
			this.numericMidfielderSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelBallControl = new global::System.Windows.Forms.Label();
			this.labelCrossing = new global::System.Windows.Forms.Label();
			this.labelLongPassing = new global::System.Windows.Forms.Label();
			this.trackLongPassing = new global::System.Windows.Forms.TrackBar();
			this.labelShortPassing = new global::System.Windows.Forms.Label();
			this.trackShortPassing = new global::System.Windows.Forms.TrackBar();
			this.trackBallControl = new global::System.Windows.Forms.TrackBar();
			this.trackCrossing = new global::System.Windows.Forms.TrackBar();
			this.groupMental = new global::System.Windows.Forms.GroupBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.numericUpDown5 = new global::System.Windows.Forms.NumericUpDown();
			this.comboDefensiveWorkrate = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.comboAttackWorkRate = new global::System.Windows.Forms.ComboBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.numericMentalSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelPlayerPositioning = new global::System.Windows.Forms.Label();
			this.labelPotential = new global::System.Windows.Forms.Label();
			this.trackPlayerPositioning = new global::System.Windows.Forms.TrackBar();
			this.trackPotential = new global::System.Windows.Forms.TrackBar();
			this.groupAttackingSkills = new global::System.Windows.Forms.GroupBox();
			this.labelFinishing = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.labelHeading = new global::System.Windows.Forms.Label();
			this.trackHeading = new global::System.Windows.Forms.TrackBar();
			this.labelVolley = new global::System.Windows.Forms.Label();
			this.trackVolley = new global::System.Windows.Forms.TrackBar();
			this.numericAttackingSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelDribbling = new global::System.Windows.Forms.Label();
			this.labelLongShot = new global::System.Windows.Forms.Label();
			this.labelShotPower = new global::System.Windows.Forms.Label();
			this.trackFinishing = new global::System.Windows.Forms.TrackBar();
			this.trackShotPower = new global::System.Windows.Forms.TrackBar();
			this.trackLongShot = new global::System.Windows.Forms.TrackBar();
			this.trackDribbling = new global::System.Windows.Forms.TrackBar();
			this.groupGenericAttributes = new global::System.Windows.Forms.GroupBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.numericUpDown3 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new global::System.Windows.Forms.NumericUpDown();
			this.labelJumping = new global::System.Windows.Forms.Label();
			this.labelBalance = new global::System.Windows.Forms.Label();
			this.trackBalance = new global::System.Windows.Forms.TrackBar();
			this.labelAgility = new global::System.Windows.Forms.Label();
			this.trackAgility = new global::System.Windows.Forms.TrackBar();
			this.numericPhysicalSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelReactions = new global::System.Windows.Forms.Label();
			this.labelStrength = new global::System.Windows.Forms.Label();
			this.labelStamina = new global::System.Windows.Forms.Label();
			this.trackStamina = new global::System.Windows.Forms.TrackBar();
			this.labelSprintSpeed = new global::System.Windows.Forms.Label();
			this.trackSprintSpeed = new global::System.Windows.Forms.TrackBar();
			this.labelAcceleration = new global::System.Windows.Forms.Label();
			this.trackAcceleration = new global::System.Windows.Forms.TrackBar();
			this.trackStrength = new global::System.Windows.Forms.TrackBar();
			this.trackReactions = new global::System.Windows.Forms.TrackBar();
			this.trackJumping = new global::System.Windows.Forms.TrackBar();
			this.groupFreeKick = new global::System.Windows.Forms.GroupBox();
			this.labelSkillsStars = new global::System.Windows.Forms.Label();
			this.imageListStars = new global::System.Windows.Forms.ImageList(this.components);
			this.numericSkillMoves = new global::System.Windows.Forms.NumericUpDown();
			this.labelSkillMoves = new global::System.Windows.Forms.Label();
			this.numericFreeKickSkills = new global::System.Windows.Forms.NumericUpDown();
			this.labelPenalties = new global::System.Windows.Forms.Label();
			this.labelFreeKick = new global::System.Windows.Forms.Label();
			this.trackFreeKick = new global::System.Windows.Forms.TrackBar();
			this.trackPenalties = new global::System.Windows.Forms.TrackBar();
			this.labelPenaltyKick = new global::System.Windows.Forms.Label();
			this.comboPenaltyKick = new global::System.Windows.Forms.ComboBox();
			this.labelPenaltyMove = new global::System.Windows.Forms.Label();
			this.comboPenaltyMove = new global::System.Windows.Forms.ComboBox();
			this.labelFreeKickStart = new global::System.Windows.Forms.Label();
			this.labelPenaltyStart = new global::System.Windows.Forms.Label();
			this.comboFreeKickStart = new global::System.Windows.Forms.ComboBox();
			this.comboPenaltyStart = new global::System.Windows.Forms.ComboBox();
			this.groupTraits = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.checkGKFlatKick = new global::System.Windows.Forms.CheckBox();
			this.checkDrivenPass = new global::System.Windows.Forms.CheckBox();
			this.checkDivingHeader = new global::System.Windows.Forms.CheckBox();
			this.checkBycicleKick = new global::System.Windows.Forms.CheckBox();
			this.checkChipperPenalty = new global::System.Windows.Forms.CheckBox();
			this.checkStutterPenalty = new global::System.Windows.Forms.CheckBox();
			this.checkFancyFlicks = new global::System.Windows.Forms.CheckBox();
			this.checkFancyPasses = new global::System.Windows.Forms.CheckBox();
			this.checkFancyFeet = new global::System.Windows.Forms.CheckBox();
			this.checkGKOneonOne = new global::System.Windows.Forms.CheckBox();
			this.checkAcrobaticClearance = new global::System.Windows.Forms.CheckBox();
			this.checkSecondWind = new global::System.Windows.Forms.CheckBox();
			this.checkCrowdFavourite = new global::System.Windows.Forms.CheckBox();
			this.checkInflexible = new global::System.Windows.Forms.CheckBox();
			this.checkTeamPlayer = new global::System.Windows.Forms.CheckBox();
			this.checkSwervePasser = new global::System.Windows.Forms.CheckBox();
			this.checkCornerSpecialist = new global::System.Windows.Forms.CheckBox();
			this.checkPowerHeader = new global::System.Windows.Forms.CheckBox();
			this.checkGkLongThrower = new global::System.Windows.Forms.CheckBox();
			this.checkLongPasser = new global::System.Windows.Forms.CheckBox();
			this.checkFlair = new global::System.Windows.Forms.CheckBox();
			this.checkFinesseShot = new global::System.Windows.Forms.CheckBox();
			this.checkArguesWithOfficials = new global::System.Windows.Forms.CheckBox();
			this.checkBeatsOffsideTrap = new global::System.Windows.Forms.CheckBox();
			this.checkAvoidsWeakFoot = new global::System.Windows.Forms.CheckBox();
			this.checkInjuryFree = new global::System.Windows.Forms.CheckBox();
			this.checkPowerFreeKick = new global::System.Windows.Forms.CheckBox();
			this.checkSelfish = new global::System.Windows.Forms.CheckBox();
			this.checkPlaymaker = new global::System.Windows.Forms.CheckBox();
			this.checkTechnicaldribbler = new global::System.Windows.Forms.CheckBox();
			this.checkLeadership = new global::System.Windows.Forms.CheckBox();
			this.checkPuncher = new global::System.Windows.Forms.CheckBox();
			this.checkDiver = new global::System.Windows.Forms.CheckBox();
			this.checkDivesintotackles = new global::System.Windows.Forms.CheckBox();
			this.checkLongshottaker = new global::System.Windows.Forms.CheckBox();
			this.checkHighClubIdentification = new global::System.Windows.Forms.CheckBox();
			this.checkPushesupforcorners = new global::System.Windows.Forms.CheckBox();
			this.checkEarlycrosser = new global::System.Windows.Forms.CheckBox();
			this.checkInjuryProne = new global::System.Windows.Forms.CheckBox();
			this.checkGiantThrower = new global::System.Windows.Forms.CheckBox();
			this.checkLongThrower = new global::System.Windows.Forms.CheckBox();
			this.pageFace = new global::System.Windows.Forms.TabPage();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.tool3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSwitchRenderingMode = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImport3DHeadModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExport3DHeadModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRemove3DHeadModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImport3DHairModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExport3DHairModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRemoveHairModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonMoveHairAhead = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMoveHairBack = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMoveHairUp = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMoveHairDown = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMoveHairLeft = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMoveHairRight = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMakeHairCloser = new global::System.Windows.Forms.ToolStripButton();
			this.buttonMakeHairWider = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSaveHair = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolPhoto = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonShowJesey = new global::System.Windows.Forms.ToolStripButton();
			this.groupGenericFace = new global::System.Windows.Forms.GroupBox();
			this.checkUsingRevMod = new global::System.Windows.Forms.CheckBox();
			this.viewer2DPlayerGui = new global::FifaControls.Viewer2D();
			this.groupGenericFaceType = new global::System.Windows.Forms.GroupBox();
			this.labelFacialHair = new global::System.Windows.Forms.Label();
			this.labelEyeBow = new global::System.Windows.Forms.Label();
			this.domainFacialHair = new global::System.Windows.Forms.ComboBox();
			this.comboEyeBow = new global::System.Windows.Forms.ComboBox();
			this.labelSkintype = new global::System.Windows.Forms.Label();
			this.comboSkintype = new global::System.Windows.Forms.ComboBox();
			this.comboFacialHairColor = new global::System.Windows.Forms.ComboBox();
			this.labelFacialHairColor = new global::System.Windows.Forms.Label();
			this.checkHasGenericFace = new global::System.Windows.Forms.CheckBox();
			this.groupHairModel = new global::System.Windows.Forms.GroupBox();
			this.comboFemaleHair = new global::System.Windows.Forms.ComboBox();
			this.radioButtonFemaleHair = new global::System.Windows.Forms.RadioButton();
			this.buttonHairSelection = new global::System.Windows.Forms.Button();
			this.comboHeadband = new global::System.Windows.Forms.ComboBox();
			this.comboAfro = new global::System.Windows.Forms.ComboBox();
			this.comboLong = new global::System.Windows.Forms.ComboBox();
			this.comboMedium = new global::System.Windows.Forms.ComboBox();
			this.comboModern = new global::System.Windows.Forms.ComboBox();
			this.labelHairColor = new global::System.Windows.Forms.Label();
			this.domainHairColor = new global::System.Windows.Forms.ComboBox();
			this.comboShort = new global::System.Windows.Forms.ComboBox();
			this.comboVeryShort = new global::System.Windows.Forms.ComboBox();
			this.comboShaven = new global::System.Windows.Forms.ComboBox();
			this.radioHeadband = new global::System.Windows.Forms.RadioButton();
			this.radioShaven = new global::System.Windows.Forms.RadioButton();
			this.radioAfro = new global::System.Windows.Forms.RadioButton();
			this.radioLong = new global::System.Windows.Forms.RadioButton();
			this.radioMedium = new global::System.Windows.Forms.RadioButton();
			this.radioModern = new global::System.Windows.Forms.RadioButton();
			this.radioShort = new global::System.Windows.Forms.RadioButton();
			this.radioVeryShort = new global::System.Windows.Forms.RadioButton();
			this.groupHeadModel = new global::System.Windows.Forms.GroupBox();
			this.radioButtonFemale = new global::System.Windows.Forms.RadioButton();
			this.comboFemaleModels = new global::System.Windows.Forms.ComboBox();
			this.comboLatinModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonLatin = new global::System.Windows.Forms.RadioButton();
			this.comboAsiaticModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonAsiatic = new global::System.Windows.Forms.RadioButton();
			this.comboAfricanModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonAfrican = new global::System.Windows.Forms.RadioButton();
			this.radioButtonCaucasic = new global::System.Windows.Forms.RadioButton();
			this.comboCaucasicModels = new global::System.Windows.Forms.ComboBox();
			this.buttonRandomizeAppearance = new global::System.Windows.Forms.Button();
			this.labelSideburns = new global::System.Windows.Forms.Label();
			this.comboSideburns = new global::System.Windows.Forms.ComboBox();
			this.labelHeadType = new global::System.Windows.Forms.Label();
			this.labelHairType = new global::System.Windows.Forms.Label();
			this.splitContainer3 = new global::System.Windows.Forms.SplitContainer();
			this.groupSpecifiHeadControls = new global::System.Windows.Forms.GroupBox();
			this.viewer2DTattoos = new global::FifaControls.Viewer2D();
			this.checkHighQaualityFace = new global::System.Windows.Forms.CheckBox();
			this.multiViewerFace = new global::FifaControls.MultiViewer2D();
			this.groupCommonHeadControls = new global::System.Windows.Forms.GroupBox();
			this.comboFaceposer = new global::System.Windows.Forms.ComboBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.buttonRgbHair = new global::System.Windows.Forms.Button();
			this.multiViewerHair = new global::FifaControls.MultiViewer2D();
			this.viewer2DEyeTexture = new global::FifaControls.Viewer2D();
			this.viewer2DSkinTexture = new global::FifaControls.Viewer2D();
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelSkinColorInfo = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboEyescolor = new global::System.Windows.Forms.ComboBox();
			this.numericSkinTone = new global::System.Windows.Forms.NumericUpDown();
			this.checkShowTexures = new global::System.Windows.Forms.CheckBox();
			this.imageListTabIcons = new global::System.Windows.Forms.ImageList(this.components);
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.tabEditPlayer.SuspendLayout();
			this.pageInfo.SuspendLayout();
			this.flowPanelInfo.SuspendLayout();
			this.groupPlayerIdentity.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.playerBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPlayerId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).BeginInit();
			this.groupBoxBody.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericHeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericWeight).BeginInit();
			this.groupBoxLook.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericGkGloves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc1).BeginInit();
			this.groupPlayFirTeam.SuspendLayout();
			this.groupIsLoan.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).BeginInit();
			this.groupShoes.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesBrand).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesDesign).BeginInit();
			this.groupBox1.SuspendLayout();
			this.pageSkills.SuspendLayout();
			this.flowPanelSkills.SuspendLayout();
			this.groupGenerateAttributes.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackOverallrating).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRandomize).BeginInit();
			this.groupGoalkeperSkills.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackGkKicking).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackDiving).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPositioning).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackReflexes).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackHandling).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericGoalkeeperSkills).BeginInit();
			this.groupDefensiveSkills.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackInterception).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackSliding).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefensiveSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackTackling).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackMarking).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAggression).BeginInit();
			this.groupMidfielderSkills.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackCurve).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackVision).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMidfielderSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackLongPassing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackShortPassing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBallControl).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackCrossing).BeginInit();
			this.groupMental.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMentalSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPlayerPositioning).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPotential).BeginInit();
			this.groupAttackingSkills.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackHeading).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackVolley).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericAttackingSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackFinishing).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackShotPower).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackLongShot).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackDribbling).BeginInit();
			this.groupGenericAttributes.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBalance).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAgility).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPhysicalSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackStamina).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackSprintSpeed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAcceleration).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackStrength).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackReactions).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackJumping).BeginInit();
			this.groupFreeKick.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericSkillMoves).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericFreeKickSkills).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackFreeKick).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPenalties).BeginInit();
			this.groupTraits.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pageFace.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tool3D.SuspendLayout();
			this.groupGenericFace.SuspendLayout();
			this.groupGenericFaceType.SuspendLayout();
			this.groupHairModel.SuspendLayout();
			this.groupHeadModel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.groupSpecifiHeadControls.SuspendLayout();
			this.groupCommonHeadControls.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericSkinTone).BeginInit();
			base.SuspendLayout();
			this.tabEditPlayer.Controls.Add(this.pageInfo);
			this.tabEditPlayer.Controls.Add(this.pageSkills);
			this.tabEditPlayer.Controls.Add(this.pageFace);
			this.tabEditPlayer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabEditPlayer.ImageList = this.imageListTabIcons;
			this.tabEditPlayer.Location = new global::System.Drawing.Point(0, 25);
			this.tabEditPlayer.Name = "tabEditPlayer";
			this.tabEditPlayer.SelectedIndex = 0;
			this.tabEditPlayer.Size = new global::System.Drawing.Size(1357, 807);
			this.tabEditPlayer.TabIndex = 1;
			this.tabEditPlayer.SelectedIndexChanged += new global::System.EventHandler(this.tabEditPlayer_SelectedIndexChanged);
			this.pageInfo.Controls.Add(this.flowPanelInfo);
			this.pageInfo.ImageIndex = 0;
			this.pageInfo.Location = new global::System.Drawing.Point(4, 23);
			this.pageInfo.Name = "pageInfo";
			this.pageInfo.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageInfo.Size = new global::System.Drawing.Size(1349, 780);
			this.pageInfo.TabIndex = 0;
			this.pageInfo.Text = "Info";
			this.pageInfo.UseVisualStyleBackColor = true;
			this.flowPanelInfo.AutoScroll = true;
			this.flowPanelInfo.Controls.Add(this.groupPlayerIdentity);
			this.flowPanelInfo.Controls.Add(this.groupBoxBody);
			this.flowPanelInfo.Controls.Add(this.groupBoxLook);
			this.flowPanelInfo.Controls.Add(this.groupPlayFirTeam);
			this.flowPanelInfo.Controls.Add(this.groupShoes);
			this.flowPanelInfo.Controls.Add(this.groupBox1);
			this.flowPanelInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowPanelInfo.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowPanelInfo.Location = new global::System.Drawing.Point(3, 3);
			this.flowPanelInfo.Name = "flowPanelInfo";
			this.flowPanelInfo.Size = new global::System.Drawing.Size(1343, 774);
			this.flowPanelInfo.TabIndex = 0;
			this.groupPlayerIdentity.Controls.Add(this.radioButtonGenderFemale);
			this.groupPlayerIdentity.Controls.Add(this.radioButtonGenderMale);
			this.groupPlayerIdentity.Controls.Add(this.labelCommonName);
			this.groupPlayerIdentity.Controls.Add(this.textCommonName);
			this.groupPlayerIdentity.Controls.Add(this.textJerseyName);
			this.groupPlayerIdentity.Controls.Add(this.labelJerseyName);
			this.groupPlayerIdentity.Controls.Add(this.buttonGetId);
			this.groupPlayerIdentity.Controls.Add(this.viewer2DPhoto);
			this.groupPlayerIdentity.Controls.Add(this.numericPlayerId);
			this.groupPlayerIdentity.Controls.Add(this.buttonRandomizeIdentity);
			this.groupPlayerIdentity.Controls.Add(this.dateBirthDate);
			this.groupPlayerIdentity.Controls.Add(this.labelBirthdate);
			this.groupPlayerIdentity.Controls.Add(this.labelPlayerId);
			this.groupPlayerIdentity.Controls.Add(this.textSurname);
			this.groupPlayerIdentity.Controls.Add(this.textFirstName);
			this.groupPlayerIdentity.Controls.Add(this.comboCountry);
			this.groupPlayerIdentity.Controls.Add(this.labelFirstName);
			this.groupPlayerIdentity.Controls.Add(this.labelSurame);
			this.groupPlayerIdentity.Controls.Add(this.labelCountry);
			this.groupPlayerIdentity.Location = new global::System.Drawing.Point(3, 3);
			this.groupPlayerIdentity.Name = "groupPlayerIdentity";
			this.groupPlayerIdentity.Size = new global::System.Drawing.Size(391, 239);
			this.groupPlayerIdentity.TabIndex = 85;
			this.groupPlayerIdentity.TabStop = false;
			this.groupPlayerIdentity.Text = "Identity Card";
			this.radioButtonGenderFemale.AutoSize = true;
			this.radioButtonGenderFemale.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Female", true));
			this.radioButtonGenderFemale.Location = new global::System.Drawing.Point(314, 206);
			this.radioButtonGenderFemale.Name = "radioButtonGenderFemale";
			this.radioButtonGenderFemale.Size = new global::System.Drawing.Size(59, 17);
			this.radioButtonGenderFemale.TabIndex = 163;
			this.radioButtonGenderFemale.TabStop = true;
			this.radioButtonGenderFemale.Text = "Female";
			this.radioButtonGenderFemale.UseVisualStyleBackColor = true;
			this.playerBindingSource.DataSource = typeof(global::FifaLibrary.Player);
			this.radioButtonGenderMale.AutoSize = true;
			this.radioButtonGenderMale.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Male", true));
			this.radioButtonGenderMale.Location = new global::System.Drawing.Point(260, 206);
			this.radioButtonGenderMale.Name = "radioButtonGenderMale";
			this.radioButtonGenderMale.Size = new global::System.Drawing.Size(48, 17);
			this.radioButtonGenderMale.TabIndex = 162;
			this.radioButtonGenderMale.TabStop = true;
			this.radioButtonGenderMale.Text = "Male";
			this.radioButtonGenderMale.UseVisualStyleBackColor = true;
			this.labelCommonName.AutoSize = true;
			this.labelCommonName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCommonName.Location = new global::System.Drawing.Point(156, 99);
			this.labelCommonName.Name = "labelCommonName";
			this.labelCommonName.Size = new global::System.Drawing.Size(79, 13);
			this.labelCommonName.TabIndex = 161;
			this.labelCommonName.Text = "Common Name";
			this.labelCommonName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textCommonName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.playerBindingSource, "commonname", true));
			this.textCommonName.Location = new global::System.Drawing.Point(247, 96);
			this.textCommonName.Name = "textCommonName";
			this.textCommonName.Size = new global::System.Drawing.Size(131, 20);
			this.textCommonName.TabIndex = 2;
			this.textCommonName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textCommonName.TextChanged += new global::System.EventHandler(this.textCommonName_TextChanged);
			this.textJerseyName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.playerBindingSource, "playerjerseyname", true));
			this.textJerseyName.Location = new global::System.Drawing.Point(247, 122);
			this.textJerseyName.Name = "textJerseyName";
			this.textJerseyName.Size = new global::System.Drawing.Size(131, 20);
			this.textJerseyName.TabIndex = 3;
			this.textJerseyName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textJerseyName.TextChanged += new global::System.EventHandler(this.textJerseyName_TextChanged);
			this.labelJerseyName.AutoSize = true;
			this.labelJerseyName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelJerseyName.Location = new global::System.Drawing.Point(156, 125);
			this.labelJerseyName.Name = "labelJerseyName";
			this.labelJerseyName.Size = new global::System.Drawing.Size(37, 13);
			this.labelJerseyName.TabIndex = 159;
			this.labelJerseyName.Text = "Jersey";
			this.labelJerseyName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonGetId.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetId.Image");
			this.buttonGetId.Location = new global::System.Drawing.Point(354, 19);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(24, 20);
			this.buttonGetId.TabIndex = 156;
			this.buttonGetId.TabStop = false;
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.viewer2DPhoto.AutoTransparency = true;
			this.viewer2DPhoto.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPhoto.ButtonStripVisible = false;
			this.viewer2DPhoto.CurrentBitmap = null;
			this.viewer2DPhoto.ExtendedFormat = false;
			this.viewer2DPhoto.FullSizeButton = false;
			this.viewer2DPhoto.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPhoto.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DPhoto.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.MiniFace;
			this.viewer2DPhoto.Location = new global::System.Drawing.Point(6, 16);
			this.viewer2DPhoto.Name = "viewer2DPhoto";
			this.viewer2DPhoto.RemoveButton = false;
			this.viewer2DPhoto.ShowButton = false;
			this.viewer2DPhoto.ShowButtonChecked = true;
			this.viewer2DPhoto.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DPhoto.TabIndex = 125;
			this.viewer2DPhoto.TabStop = false;
			this.numericPlayerId.Location = new global::System.Drawing.Point(248, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericPlayerId;
			int[] array = new int[4];
			array[0] = 600000;
			numericUpDown.Maximum = new decimal(array);
			this.numericPlayerId.Name = "numericPlayerId";
			this.numericPlayerId.Size = new global::System.Drawing.Size(91, 20);
			this.numericPlayerId.TabIndex = 154;
			this.numericPlayerId.TabStop = false;
			this.numericPlayerId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericPlayerId;
			int[] array2 = new int[4];
			array2[0] = 200000;
			numericUpDown2.Value = new decimal(array2);
			this.numericPlayerId.ValueChanged += new global::System.EventHandler(this.numericPlayerId_ValueChanged);
			this.buttonRandomizeIdentity.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomizeIdentity.Location = new global::System.Drawing.Point(6, 177);
			this.buttonRandomizeIdentity.Name = "buttonRandomizeIdentity";
			this.buttonRandomizeIdentity.Size = new global::System.Drawing.Size(128, 23);
			this.buttonRandomizeIdentity.TabIndex = 124;
			this.buttonRandomizeIdentity.TabStop = false;
			this.buttonRandomizeIdentity.Text = "Randomize";
			this.buttonRandomizeIdentity.UseVisualStyleBackColor = true;
			this.buttonRandomizeIdentity.Click += new global::System.EventHandler(this.buttonRandomizeIdentity_Click);
			this.dateBirthDate.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "birthdate", true));
			this.dateBirthDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateBirthDate.Location = new global::System.Drawing.Point(247, 153);
			this.dateBirthDate.MaxDate = new global::System.DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.dateBirthDate.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateBirthDate.Name = "dateBirthDate";
			this.dateBirthDate.Size = new global::System.Drawing.Size(131, 20);
			this.dateBirthDate.TabIndex = 4;
			this.dateBirthDate.Value = new global::System.DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.labelBirthdate.AutoSize = true;
			this.labelBirthdate.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBirthdate.Location = new global::System.Drawing.Point(156, 156);
			this.labelBirthdate.Name = "labelBirthdate";
			this.labelBirthdate.Size = new global::System.Drawing.Size(49, 13);
			this.labelBirthdate.TabIndex = 4;
			this.labelBirthdate.Text = "Birthdate";
			this.labelBirthdate.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPlayerId.AutoSize = true;
			this.labelPlayerId.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPlayerId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPlayerId.Location = new global::System.Drawing.Point(156, 23);
			this.labelPlayerId.Name = "labelPlayerId";
			this.labelPlayerId.Size = new global::System.Drawing.Size(48, 13);
			this.labelPlayerId.TabIndex = 122;
			this.labelPlayerId.Text = "Player Id";
			this.labelPlayerId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textSurname.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.playerBindingSource, "lastname", true));
			this.textSurname.Location = new global::System.Drawing.Point(247, 70);
			this.textSurname.Name = "textSurname";
			this.textSurname.Size = new global::System.Drawing.Size(131, 20);
			this.textSurname.TabIndex = 1;
			this.textSurname.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textSurname.TextChanged += new global::System.EventHandler(this.textSurname_TextChanged);
			this.textFirstName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.playerBindingSource, "firstname", true));
			this.textFirstName.Location = new global::System.Drawing.Point(248, 44);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new global::System.Drawing.Size(131, 20);
			this.textFirstName.TabIndex = 0;
			this.textFirstName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textFirstName.TextChanged += new global::System.EventHandler(this.textFirstName_TextChanged);
			this.comboCountry.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.playerBindingSource, "Country", true));
			this.comboCountry.DataSource = this.countryListBindingSource;
			this.comboCountry.ItemHeight = 13;
			this.comboCountry.Location = new global::System.Drawing.Point(247, 179);
			this.comboCountry.MaxLength = 32767;
			this.comboCountry.Name = "comboCountry";
			this.comboCountry.Size = new global::System.Drawing.Size(131, 21);
			this.comboCountry.TabIndex = 5;
			this.countryListBindingSource.DataSource = typeof(global::FifaLibrary.CountryList);
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFirstName.Location = new global::System.Drawing.Point(156, 47);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new global::System.Drawing.Size(57, 13);
			this.labelFirstName.TabIndex = 1;
			this.labelFirstName.Text = "First Name";
			this.labelFirstName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSurame.AutoSize = true;
			this.labelSurame.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSurame.Location = new global::System.Drawing.Point(156, 73);
			this.labelSurame.Name = "labelSurame";
			this.labelSurame.Size = new global::System.Drawing.Size(58, 13);
			this.labelSurame.TabIndex = 2;
			this.labelSurame.Text = "Last Name";
			this.labelSurame.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.AutoSize = true;
			this.labelCountry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelCountry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCountry.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelCountry.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCountry.Location = new global::System.Drawing.Point(156, 182);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new global::System.Drawing.Size(43, 13);
			this.labelCountry.TabIndex = 5;
			this.labelCountry.Text = "Country";
			this.labelCountry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.DoubleClick += new global::System.EventHandler(this.labelCountry_DoubleClick);
			this.groupBoxBody.Controls.Add(this.comboWeakFoot);
			this.groupBoxBody.Controls.Add(this.labelWeakFoot);
			this.groupBoxBody.Controls.Add(this.comboBody);
			this.groupBoxBody.Controls.Add(this.numericHeight);
			this.groupBoxBody.Controls.Add(this.numericWeight);
			this.groupBoxBody.Controls.Add(this.labelWeight);
			this.groupBoxBody.Controls.Add(this.labelBody);
			this.groupBoxBody.Controls.Add(this.domainPreferredFoot);
			this.groupBoxBody.Controls.Add(this.labelHeight);
			this.groupBoxBody.Controls.Add(this.labelPreferredFoot);
			this.groupBoxBody.Location = new global::System.Drawing.Point(3, 248);
			this.groupBoxBody.Name = "groupBoxBody";
			this.groupBoxBody.Size = new global::System.Drawing.Size(391, 113);
			this.groupBoxBody.TabIndex = 86;
			this.groupBoxBody.TabStop = false;
			this.groupBoxBody.Text = "Body";
			this.comboWeakFoot.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "weakfootabilitytypecode", true));
			this.comboWeakFoot.FormattingEnabled = true;
			this.comboWeakFoot.Items.AddRange(new object[] { "Very Poor", "Poor", "Medium", "Good", "Ambidexter" });
			this.comboWeakFoot.Location = new global::System.Drawing.Point(247, 76);
			this.comboWeakFoot.Name = "comboWeakFoot";
			this.comboWeakFoot.Size = new global::System.Drawing.Size(103, 21);
			this.comboWeakFoot.TabIndex = 3;
			this.labelWeakFoot.AutoSize = true;
			this.labelWeakFoot.BackColor = global::System.Drawing.Color.Transparent;
			this.labelWeakFoot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelWeakFoot.Location = new global::System.Drawing.Point(184, 79);
			this.labelWeakFoot.Name = "labelWeakFoot";
			this.labelWeakFoot.Size = new global::System.Drawing.Size(57, 13);
			this.labelWeakFoot.TabIndex = 54;
			this.labelWeakFoot.Text = "Weak foot";
			this.labelWeakFoot.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboBody.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "bodytypecode", true));
			this.comboBody.FormattingEnabled = true;
			this.comboBody.Items.AddRange(new object[]
			{
				"Average Height and Lean", "Average Height ", "Average Height and Muscular", "Tall and Lean", "Tall", "Tall and Muscular", "Short and Lean", "Short ", "Short and Muscular", "10 Messi",
				"Very Tall and Lean", "12 Akinfenwa", "13 Courtois", "14 Neymar", "15 Shaqiri", "16 Ronaldo", "17 Unused", "18 Leroux"
			});
			this.comboBody.Location = new global::System.Drawing.Point(71, 46);
			this.comboBody.Name = "comboBody";
			this.comboBody.Size = new global::System.Drawing.Size(279, 21);
			this.comboBody.TabIndex = 4;
			this.numericHeight.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "height", true));
			this.numericHeight.Location = new global::System.Drawing.Point(71, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericHeight;
			int[] array3 = new int[4];
			array3[0] = 215;
			numericUpDown3.Maximum = new decimal(array3);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericHeight;
			int[] array4 = new int[4];
			array4[0] = 150;
			numericUpDown4.Minimum = new decimal(array4);
			this.numericHeight.Name = "numericHeight";
			this.numericHeight.Size = new global::System.Drawing.Size(103, 20);
			this.numericHeight.TabIndex = 0;
			this.numericHeight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericHeight;
			int[] array5 = new int[4];
			array5[0] = 150;
			numericUpDown5.Value = new decimal(array5);
			this.numericWeight.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "weight", true));
			this.numericWeight.Location = new global::System.Drawing.Point(247, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericWeight;
			int[] array6 = new int[4];
			array6[0] = 115;
			numericUpDown6.Maximum = new decimal(array6);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericWeight;
			int[] array7 = new int[4];
			array7[0] = 50;
			numericUpDown7.Minimum = new decimal(array7);
			this.numericWeight.Name = "numericWeight";
			this.numericWeight.Size = new global::System.Drawing.Size(103, 20);
			this.numericWeight.TabIndex = 2;
			this.numericWeight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericWeight;
			int[] array8 = new int[4];
			array8[0] = 50;
			numericUpDown8.Value = new decimal(array8);
			this.labelWeight.AutoSize = true;
			this.labelWeight.BackColor = global::System.Drawing.Color.Transparent;
			this.labelWeight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelWeight.Location = new global::System.Drawing.Point(184, 23);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new global::System.Drawing.Size(41, 13);
			this.labelWeight.TabIndex = 12;
			this.labelWeight.Text = "Weight";
			this.labelWeight.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBody.AutoSize = true;
			this.labelBody.BackColor = global::System.Drawing.Color.Transparent;
			this.labelBody.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBody.Location = new global::System.Drawing.Point(6, 48);
			this.labelBody.Name = "labelBody";
			this.labelBody.Size = new global::System.Drawing.Size(31, 13);
			this.labelBody.TabIndex = 26;
			this.labelBody.Text = "Body";
			this.labelBody.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.domainPreferredFoot.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "preferredfoot", true));
			this.domainPreferredFoot.Items.Add("Right");
			this.domainPreferredFoot.Items.Add("Left");
			this.domainPreferredFoot.Location = new global::System.Drawing.Point(71, 77);
			this.domainPreferredFoot.Name = "domainPreferredFoot";
			this.domainPreferredFoot.Size = new global::System.Drawing.Size(103, 20);
			this.domainPreferredFoot.TabIndex = 1;
			this.domainPreferredFoot.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainPreferredFoot.Wrap = true;
			this.labelHeight.AutoSize = true;
			this.labelHeight.BackColor = global::System.Drawing.Color.Transparent;
			this.labelHeight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHeight.Location = new global::System.Drawing.Point(6, 23);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new global::System.Drawing.Size(38, 13);
			this.labelHeight.TabIndex = 11;
			this.labelHeight.Text = "Height";
			this.labelHeight.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPreferredFoot.AutoSize = true;
			this.labelPreferredFoot.BackColor = global::System.Drawing.Color.Transparent;
			this.labelPreferredFoot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPreferredFoot.Location = new global::System.Drawing.Point(6, 79);
			this.labelPreferredFoot.Name = "labelPreferredFoot";
			this.labelPreferredFoot.Size = new global::System.Drawing.Size(49, 13);
			this.labelPreferredFoot.TabIndex = 49;
			this.labelPreferredFoot.Text = "Best foot";
			this.labelPreferredFoot.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupBoxLook.Controls.Add(this.checkJerseyFit);
			this.groupBoxLook.Controls.Add(this.checkTrainingPants);
			this.groupBoxLook.Controls.Add(this.domainSocksStyle);
			this.groupBoxLook.Controls.Add(this.label8);
			this.groupBoxLook.Controls.Add(this.numericGkGloves);
			this.groupBoxLook.Controls.Add(this.labelGkGloves);
			this.groupBoxLook.Controls.Add(this.labelWinter);
			this.groupBoxLook.Controls.Add(this.comboWinterAccessories);
			this.groupBoxLook.Controls.Add(this.domainJerseyStyle);
			this.groupBoxLook.Controls.Add(this.domainSleeves);
			this.groupBoxLook.Controls.Add(this.pictureColorAcc2);
			this.groupBoxLook.Controls.Add(this.pictureColorAcc3);
			this.groupBoxLook.Controls.Add(this.pictureColorAcc4);
			this.groupBoxLook.Controls.Add(this.pictureColorAcc1);
			this.groupBoxLook.Controls.Add(this.domainAccessory4);
			this.groupBoxLook.Controls.Add(this.domainAccessory3);
			this.groupBoxLook.Controls.Add(this.domainAccessory2);
			this.groupBoxLook.Controls.Add(this.domainAccessory1);
			this.groupBoxLook.Controls.Add(this.labelSleeves);
			this.groupBoxLook.Controls.Add(this.labelJerseyStyle);
			this.groupBoxLook.Controls.Add(this.labelAccesories);
			this.groupBoxLook.Location = new global::System.Drawing.Point(3, 367);
			this.groupBoxLook.Name = "groupBoxLook";
			this.groupBoxLook.Size = new global::System.Drawing.Size(391, 280);
			this.groupBoxLook.TabIndex = 87;
			this.groupBoxLook.TabStop = false;
			this.groupBoxLook.Text = "Look";
			this.checkJerseyFit.AutoSize = true;
			this.checkJerseyFit.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "jerseyfit", true));
			this.checkJerseyFit.Location = new global::System.Drawing.Point(280, 18);
			this.checkJerseyFit.Name = "checkJerseyFit";
			this.checkJerseyFit.Size = new global::System.Drawing.Size(70, 17);
			this.checkJerseyFit.TabIndex = 99;
			this.checkJerseyFit.Text = "Jersey Fit";
			this.checkJerseyFit.UseVisualStyleBackColor = true;
			this.checkTrainingPants.AutoSize = true;
			this.checkTrainingPants.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "TrainingPants", true));
			this.checkTrainingPants.Location = new global::System.Drawing.Point(238, 131);
			this.checkTrainingPants.Name = "checkTrainingPants";
			this.checkTrainingPants.Size = new global::System.Drawing.Size(112, 17);
			this.checkTrainingPants.TabIndex = 98;
			this.checkTrainingPants.Text = "GK Training Pants";
			this.checkTrainingPants.UseVisualStyleBackColor = true;
			this.domainSocksStyle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "socklengthcode", true));
			this.domainSocksStyle.Items.Add("Normal Socks");
			this.domainSocksStyle.Items.Add("Low Socks");
			this.domainSocksStyle.Items.Add("High Socks");
			this.domainSocksStyle.Location = new global::System.Drawing.Point(108, 70);
			this.domainSocksStyle.Name = "domainSocksStyle";
			this.domainSocksStyle.Size = new global::System.Drawing.Size(242, 20);
			this.domainSocksStyle.TabIndex = 68;
			this.domainSocksStyle.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainSocksStyle.Wrap = true;
			this.label8.AutoSize = true;
			this.label8.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new global::System.Drawing.Point(6, 72);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(63, 13);
			this.label8.TabIndex = 69;
			this.label8.Text = "Socks Style";
			this.label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericGkGloves.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkglovetypecode", true));
			this.numericGkGloves.Location = new global::System.Drawing.Point(108, 130);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericGkGloves;
			int[] array9 = new int[4];
			array9[0] = 127;
			numericUpDown9.Maximum = new decimal(array9);
			this.numericGkGloves.Name = "numericGkGloves";
			this.numericGkGloves.Size = new global::System.Drawing.Size(106, 20);
			this.numericGkGloves.TabIndex = 8;
			this.numericGkGloves.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericGkGloves;
			int[] array10 = new int[4];
			array10[0] = 1;
			numericUpDown10.Value = new decimal(array10);
			this.labelGkGloves.AutoSize = true;
			this.labelGkGloves.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelGkGloves.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelGkGloves.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelGkGloves.Location = new global::System.Drawing.Point(10, 132);
			this.labelGkGloves.Name = "labelGkGloves";
			this.labelGkGloves.Size = new global::System.Drawing.Size(58, 13);
			this.labelGkGloves.TabIndex = 67;
			this.labelGkGloves.Text = "GK Gloves";
			this.labelGkGloves.DoubleClick += new global::System.EventHandler(this.labelGkGloves_DoubleClick);
			this.labelWinter.AutoSize = true;
			this.labelWinter.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelWinter.Location = new global::System.Drawing.Point(6, 101);
			this.labelWinter.Name = "labelWinter";
			this.labelWinter.Size = new global::System.Drawing.Size(98, 13);
			this.labelWinter.TabIndex = 64;
			this.labelWinter.Text = "Winter Accessories";
			this.labelWinter.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboWinterAccessories.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "hasseasonaljersey", true));
			this.comboWinterAccessories.FormattingEnabled = true;
			this.comboWinterAccessories.Items.AddRange(new object[] { "None", "Long Sleeves no underarmor stuff", "Long Sleeves with underarmor neck", "Short sleeves with underarmor arms no neck", "Short sleeves with underarmor arms and neck" });
			this.comboWinterAccessories.Location = new global::System.Drawing.Point(108, 98);
			this.comboWinterAccessories.Name = "comboWinterAccessories";
			this.comboWinterAccessories.Size = new global::System.Drawing.Size(242, 21);
			this.comboWinterAccessories.TabIndex = 2;
			this.domainJerseyStyle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "jerseystylecode", true));
			this.domainJerseyStyle.Items.Add("Normal");
			this.domainJerseyStyle.Items.Add("Untucked");
			this.domainJerseyStyle.Location = new global::System.Drawing.Point(108, 17);
			this.domainJerseyStyle.Name = "domainJerseyStyle";
			this.domainJerseyStyle.Size = new global::System.Drawing.Size(164, 20);
			this.domainJerseyStyle.TabIndex = 1;
			this.domainJerseyStyle.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainJerseyStyle.Wrap = true;
			this.domainSleeves.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "jerseysleevelengthcode", true));
			this.domainSleeves.Items.Add("Short Sleeves ");
			this.domainSleeves.Items.Add("Long Sleeves ");
			this.domainSleeves.Items.Add("Long Sleeves with underarmor neck");
			this.domainSleeves.Items.Add("Short sleeves with underarmor arms no neck");
			this.domainSleeves.Items.Add("Short sleeves with underarmor arms and neck");
			this.domainSleeves.Location = new global::System.Drawing.Point(108, 43);
			this.domainSleeves.Name = "domainSleeves";
			this.domainSleeves.Size = new global::System.Drawing.Size(242, 20);
			this.domainSleeves.TabIndex = 0;
			this.domainSleeves.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainSleeves.Wrap = true;
			this.pictureColorAcc2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorAcc2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorAcc2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorAcc2.Location = new global::System.Drawing.Point(223, 201);
			this.pictureColorAcc2.Name = "pictureColorAcc2";
			this.pictureColorAcc2.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorAcc2.TabIndex = 55;
			this.pictureColorAcc2.TabStop = false;
			this.pictureColorAcc2.Click += new global::System.EventHandler(this.pictureColorAcc2_Click);
			this.pictureColorAcc3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorAcc3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorAcc3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorAcc3.Location = new global::System.Drawing.Point(223, 227);
			this.pictureColorAcc3.Name = "pictureColorAcc3";
			this.pictureColorAcc3.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorAcc3.TabIndex = 56;
			this.pictureColorAcc3.TabStop = false;
			this.pictureColorAcc3.Click += new global::System.EventHandler(this.pictureColorAcc3_Click);
			this.pictureColorAcc4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorAcc4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorAcc4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorAcc4.Location = new global::System.Drawing.Point(223, 253);
			this.pictureColorAcc4.Name = "pictureColorAcc4";
			this.pictureColorAcc4.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorAcc4.TabIndex = 57;
			this.pictureColorAcc4.TabStop = false;
			this.pictureColorAcc4.Click += new global::System.EventHandler(this.pictureColorAcc4_Click);
			this.pictureColorAcc1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorAcc1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorAcc1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorAcc1.Location = new global::System.Drawing.Point(223, 174);
			this.pictureColorAcc1.Name = "pictureColorAcc1";
			this.pictureColorAcc1.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorAcc1.TabIndex = 45;
			this.pictureColorAcc1.TabStop = false;
			this.pictureColorAcc1.Click += new global::System.EventHandler(this.pictureColorAcc1_Click);
			this.domainAccessory4.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "accessorycode4", true));
			this.domainAccessory4.Items.AddRange(new object[]
			{
				"None", "1 Unused", "2 Hearphone", "3 Unused", "4 Left watch", "5 Right watch", "6 Left hand tape", "7 Right hand tape", "8 Left wristle tape", "9 Right wristle tape",
				"10 Left knee tape", "11 Right knee tape", "12 Left knee tutor", "13 Right knee tutor", "14 Left ankle tape", "15 Right ankle tape", "16 Gloves", "17 Unused", "18 Unused", "19 Unused",
				"20 Unused", "21 Unused", "22 Left finger tape", "23 Right finger tape", "24 Left wide wristle tape", "25 Right wide wristle tape", "26 Left bracelet", "27 Right bracelet"
			});
			this.domainAccessory4.Location = new global::System.Drawing.Point(12, 252);
			this.domainAccessory4.Name = "domainAccessory4";
			this.domainAccessory4.Size = new global::System.Drawing.Size(197, 21);
			this.domainAccessory4.TabIndex = 7;
			this.domainAccessory3.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "accessorycode3", true));
			this.domainAccessory3.Items.AddRange(new object[]
			{
				"None", "1 Unused", "2 Hearphone", "3 Unused", "4 Left watch", "5 Right watch", "6 Left hand tape", "7 Right hand tape", "8 Left wristle tape", "9 Right wristle tape",
				"10 Left knee tape", "11 Right knee tape", "12 Left knee tutor", "13 Right knee tutor", "14 Left ankle tape", "15 Right ankle tape", "16 Gloves", "17 Unused", "18 Unused", "19 Unused",
				"20 Unused", "21 Unused", "22 Left finger tape", "23 Right finger tape", "24 Left wide wristle tape", "25 Right wide wristle tape", "26 Left bracelet", "27 Right bracelet"
			});
			this.domainAccessory3.Location = new global::System.Drawing.Point(12, 226);
			this.domainAccessory3.Name = "domainAccessory3";
			this.domainAccessory3.Size = new global::System.Drawing.Size(197, 21);
			this.domainAccessory3.TabIndex = 6;
			this.domainAccessory2.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "accessorycode2", true));
			this.domainAccessory2.Items.AddRange(new object[]
			{
				"None", "1 Unused", "2 Hearphone", "3 Unused", "4 Left watch", "5 Right watch", "6 Left hand tape", "7 Right hand tape", "8 Left wristle tape", "9 Right wristle tape",
				"10 Left knee tape", "11 Right knee tape", "12 Left knee tutor", "13 Right knee tutor", "14 Left ankle tape", "15 Right ankle tape", "16 Gloves", "17 Unused", "18 Unused", "19 Unused",
				"20 Unused", "21 Unused", "22 Left finger tape", "23 Right finger tape", "24 Left wide wristle tape", "25 Right wide wristle tape", "26 Left bracelet", "27 Right bracelet"
			});
			this.domainAccessory2.Location = new global::System.Drawing.Point(12, 200);
			this.domainAccessory2.Name = "domainAccessory2";
			this.domainAccessory2.Size = new global::System.Drawing.Size(197, 21);
			this.domainAccessory2.TabIndex = 5;
			this.domainAccessory1.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "accessorycode1", true));
			this.domainAccessory1.Items.AddRange(new object[]
			{
				"None", "1 Unused", "2 Hearphone", "3 Unused", "4 Left watch", "5 Right watch", "6 Left hand tape", "7 Right hand tape", "8 Left wristle tape", "9 Right wristle tape",
				"10 Left knee tape", "11 Right knee tape", "12 Left knee tutor", "13 Right knee tutor", "14 Left ankle tape", "15 Right ankle tape", "16 Gloves", "17 Unused", "18 Unused", "19 Unused",
				"20 Unused", "21 Unused", "22 Left finger tape", "23 Right finger tape", "24 Left wide wristle tape", "25 Right wide wristle tape", "26 Left bracelet", "27 Right bracelet"
			});
			this.domainAccessory1.Location = new global::System.Drawing.Point(12, 173);
			this.domainAccessory1.Name = "domainAccessory1";
			this.domainAccessory1.Size = new global::System.Drawing.Size(197, 21);
			this.domainAccessory1.TabIndex = 4;
			this.labelSleeves.AutoSize = true;
			this.labelSleeves.BackColor = global::System.Drawing.Color.Transparent;
			this.labelSleeves.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSleeves.Location = new global::System.Drawing.Point(5, 44);
			this.labelSleeves.Name = "labelSleeves";
			this.labelSleeves.Size = new global::System.Drawing.Size(81, 13);
			this.labelSleeves.TabIndex = 35;
			this.labelSleeves.Text = "Sleeves Length";
			this.labelSleeves.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelJerseyStyle.AutoSize = true;
			this.labelJerseyStyle.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelJerseyStyle.Location = new global::System.Drawing.Point(5, 19);
			this.labelJerseyStyle.Name = "labelJerseyStyle";
			this.labelJerseyStyle.Size = new global::System.Drawing.Size(63, 13);
			this.labelJerseyStyle.TabIndex = 37;
			this.labelJerseyStyle.Text = "Jersey Style";
			this.labelJerseyStyle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAccesories.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAccesories.Location = new global::System.Drawing.Point(42, 154);
			this.labelAccesories.Name = "labelAccesories";
			this.labelAccesories.Size = new global::System.Drawing.Size(136, 20);
			this.labelAccesories.TabIndex = 39;
			this.labelAccesories.Text = "Accesories";
			this.labelAccesories.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.groupPlayFirTeam.Controls.Add(this.label15);
			this.groupPlayFirTeam.Controls.Add(this.groupIsLoan);
			this.groupPlayFirTeam.Controls.Add(this.checkIsLoan);
			this.groupPlayFirTeam.Controls.Add(this.dateJoiningDate);
			this.groupPlayFirTeam.Controls.Add(this.label4);
			this.groupPlayFirTeam.Controls.Add(this.listViewPlayingTeams);
			this.groupPlayFirTeam.Controls.Add(this.comboClubTeam);
			this.groupPlayFirTeam.Controls.Add(this.buttonCallNationalTeam);
			this.groupPlayFirTeam.Controls.Add(this.buttonRemoveNationalTeam);
			this.groupPlayFirTeam.Location = new global::System.Drawing.Point(400, 3);
			this.groupPlayFirTeam.Name = "groupPlayFirTeam";
			this.groupPlayFirTeam.Size = new global::System.Drawing.Size(243, 239);
			this.groupPlayFirTeam.TabIndex = 88;
			this.groupPlayFirTeam.TabStop = false;
			this.groupPlayFirTeam.Text = "Playing for";
			this.label15.AutoSize = true;
			this.label15.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label15.Location = new global::System.Drawing.Point(12, 210);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(78, 13);
			this.label15.TabIndex = 140;
			this.label15.Text = "Previous Team";
			this.label15.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label15.Visible = false;
			this.groupIsLoan.Controls.Add(this.comboTeamLoanedFrom);
			this.groupIsLoan.Controls.Add(this.label12);
			this.groupIsLoan.Controls.Add(this.dateLoanEnd);
			this.groupIsLoan.Controls.Add(this.label11);
			this.groupIsLoan.Location = new global::System.Drawing.Point(6, 139);
			this.groupIsLoan.Name = "groupIsLoan";
			this.groupIsLoan.Size = new global::System.Drawing.Size(231, 63);
			this.groupIsLoan.TabIndex = 139;
			this.groupIsLoan.TabStop = false;
			this.groupIsLoan.Visible = false;
			this.comboTeamLoanedFrom.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.playerBindingSource, "TeamLoanedFrom", true));
			this.comboTeamLoanedFrom.DataSource = this.teamListBindingSource;
			this.comboTeamLoanedFrom.ItemHeight = 13;
			this.comboTeamLoanedFrom.Location = new global::System.Drawing.Point(89, 37);
			this.comboTeamLoanedFrom.MaxLength = 32767;
			this.comboTeamLoanedFrom.Name = "comboTeamLoanedFrom";
			this.comboTeamLoanedFrom.Size = new global::System.Drawing.Size(131, 21);
			this.comboTeamLoanedFrom.TabIndex = 141;
			this.comboTeamLoanedFrom.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamLoanedFrom_SelectedIndexChanged);
			this.teamListBindingSource.DataSource = typeof(global::FifaLibrary.TeamList);
			this.label12.AutoSize = true;
			this.label12.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label12.Location = new global::System.Drawing.Point(6, 40);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(69, 13);
			this.label12.TabIndex = 140;
			this.label12.Text = "Loaned From";
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.dateLoanEnd.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "loandateend", true));
			this.dateLoanEnd.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateLoanEnd.Location = new global::System.Drawing.Point(89, 11);
			this.dateLoanEnd.MaxDate = new global::System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dateLoanEnd.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateLoanEnd.Name = "dateLoanEnd";
			this.dateLoanEnd.Size = new global::System.Drawing.Size(131, 20);
			this.dateLoanEnd.TabIndex = 139;
			this.dateLoanEnd.Value = new global::System.DateTime(2017, 6, 30, 0, 0, 0, 0);
			this.label11.AutoSize = true;
			this.label11.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new global::System.Drawing.Point(6, 15);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(79, 13);
			this.label11.TabIndex = 138;
			this.label11.Text = "Loan End Date";
			this.label11.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkIsLoan.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "IsLoaned", true));
			this.checkIsLoan.Location = new global::System.Drawing.Point(6, 124);
			this.checkIsLoan.Name = "checkIsLoan";
			this.checkIsLoan.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsLoan.Size = new global::System.Drawing.Size(104, 17);
			this.checkIsLoan.TabIndex = 138;
			this.checkIsLoan.Text = "Is Loaned ";
			this.checkIsLoan.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkIsLoan.UseVisualStyleBackColor = true;
			this.checkIsLoan.CheckedChanged += new global::System.EventHandler(this.checkIsLoan_CheckedChanged);
			this.dateJoiningDate.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "joindate", true));
			this.dateJoiningDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateJoiningDate.Location = new global::System.Drawing.Point(95, 99);
			this.dateJoiningDate.MaxDate = new global::System.DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dateJoiningDate.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateJoiningDate.Name = "dateJoiningDate";
			this.dateJoiningDate.Size = new global::System.Drawing.Size(131, 20);
			this.dateJoiningDate.TabIndex = 137;
			this.dateJoiningDate.Value = new global::System.DateTime(2016, 7, 1, 0, 0, 0, 0);
			this.label4.AutoSize = true;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(12, 103);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(66, 13);
			this.label4.TabIndex = 136;
			this.label4.Text = "Joining Date";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.listViewPlayingTeams.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listViewPlayingTeams.FullRowSelect = true;
			this.listViewPlayingTeams.GridLines = true;
			this.listViewPlayingTeams.HideSelection = false;
			this.listViewPlayingTeams.LargeImageList = this.imageListTeamLogos;
			this.listViewPlayingTeams.Location = new global::System.Drawing.Point(6, 19);
			this.listViewPlayingTeams.MultiSelect = false;
			this.listViewPlayingTeams.Name = "listViewPlayingTeams";
			this.listViewPlayingTeams.Size = new global::System.Drawing.Size(231, 71);
			this.listViewPlayingTeams.TabIndex = 135;
			this.listViewPlayingTeams.TabStop = false;
			this.listViewPlayingTeams.UseCompatibleStateImageBehavior = false;
			this.listViewPlayingTeams.DoubleClick += new global::System.EventHandler(this.listViewPlayingTeams_DoubleClick);
			this.imageListTeamLogos.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListTeamLogos.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imageListTeamLogos.TransparentColor = global::System.Drawing.Color.Transparent;
			this.comboClubTeam.ItemHeight = 13;
			this.comboClubTeam.Location = new global::System.Drawing.Point(10, 334);
			this.comboClubTeam.MaxLength = 32767;
			this.comboClubTeam.Name = "comboClubTeam";
			this.comboClubTeam.Size = new global::System.Drawing.Size(100, 21);
			this.comboClubTeam.Sorted = true;
			this.comboClubTeam.TabIndex = 0;
			this.comboClubTeam.Visible = false;
			this.buttonCallNationalTeam.Enabled = false;
			this.buttonCallNationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonCallNationalTeam.Location = new global::System.Drawing.Point(130, 334);
			this.buttonCallNationalTeam.Name = "buttonCallNationalTeam";
			this.buttonCallNationalTeam.Size = new global::System.Drawing.Size(50, 20);
			this.buttonCallNationalTeam.TabIndex = 1;
			this.buttonCallNationalTeam.Text = "Call";
			this.buttonCallNationalTeam.Visible = false;
			this.buttonRemoveNationalTeam.Enabled = false;
			this.buttonRemoveNationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRemoveNationalTeam.Location = new global::System.Drawing.Point(180, 334);
			this.buttonRemoveNationalTeam.Name = "buttonRemoveNationalTeam";
			this.buttonRemoveNationalTeam.Size = new global::System.Drawing.Size(50, 20);
			this.buttonRemoveNationalTeam.TabIndex = 2;
			this.buttonRemoveNationalTeam.Text = "Remove";
			this.buttonRemoveNationalTeam.Visible = false;
			this.groupShoes.Controls.Add(this.label1ShoesType);
			this.groupShoes.Controls.Add(this.pictureColorShoes2);
			this.groupShoes.Controls.Add(this.pictureColorShoes1);
			this.groupShoes.Controls.Add(this.numericShoesBrand);
			this.groupShoes.Controls.Add(this.labelShoesType);
			this.groupShoes.Controls.Add(this.labelShoesColor);
			this.groupShoes.Controls.Add(this.numericShoesDesign);
			this.groupShoes.Controls.Add(this.viewer2DShoes);
			this.groupShoes.Controls.Add(this.labelShoes);
			this.groupShoes.Location = new global::System.Drawing.Point(400, 248);
			this.groupShoes.Name = "groupShoes";
			this.groupShoes.Size = new global::System.Drawing.Size(243, 178);
			this.groupShoes.TabIndex = 90;
			this.groupShoes.TabStop = false;
			this.groupShoes.Text = "Shoes";
			this.label1ShoesType.AutoSize = true;
			this.label1ShoesType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1ShoesType.Location = new global::System.Drawing.Point(29, 66);
			this.label1ShoesType.Name = "label1ShoesType";
			this.label1ShoesType.Size = new global::System.Drawing.Size(40, 13);
			this.label1ShoesType.TabIndex = 64;
			this.label1ShoesType.Text = "Design";
			this.label1ShoesType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pictureColorShoes2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorShoes2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorShoes2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorShoes2.Location = new global::System.Drawing.Point(72, 131);
			this.pictureColorShoes2.Name = "pictureColorShoes2";
			this.pictureColorShoes2.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorShoes2.TabIndex = 63;
			this.pictureColorShoes2.TabStop = false;
			this.pictureColorShoes2.Click += new global::System.EventHandler(this.pictureColorShoes2_Click);
			this.pictureColorShoes1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorShoes1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorShoes1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorShoes1.Location = new global::System.Drawing.Point(12, 131);
			this.pictureColorShoes1.Name = "pictureColorShoes1";
			this.pictureColorShoes1.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorShoes1.TabIndex = 62;
			this.pictureColorShoes1.TabStop = false;
			this.pictureColorShoes1.Click += new global::System.EventHandler(this.pictureColorShoes1_Click);
			this.numericShoesBrand.Location = new global::System.Drawing.Point(12, 36);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericShoesBrand;
			int[] array11 = new int[4];
			array11[0] = 255;
			numericUpDown11.Maximum = new decimal(array11);
			this.numericShoesBrand.Name = "numericShoesBrand";
			this.numericShoesBrand.Size = new global::System.Drawing.Size(80, 20);
			this.numericShoesBrand.TabIndex = 9;
			this.numericShoesBrand.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericShoesBrand;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.numericShoesBrand.ValueChanged += new global::System.EventHandler(this.numericShoesBrand_ValueChanged);
			this.labelShoesType.AutoSize = true;
			this.labelShoesType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShoesType.Location = new global::System.Drawing.Point(31, 18);
			this.labelShoesType.Name = "labelShoesType";
			this.labelShoesType.Size = new global::System.Drawing.Size(35, 13);
			this.labelShoesType.TabIndex = 60;
			this.labelShoesType.Text = "Brand";
			this.labelShoesType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelShoesColor.AutoSize = true;
			this.labelShoesColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShoesColor.Location = new global::System.Drawing.Point(33, 113);
			this.labelShoesColor.Name = "labelShoesColor";
			this.labelShoesColor.Size = new global::System.Drawing.Size(36, 13);
			this.labelShoesColor.TabIndex = 61;
			this.labelShoesColor.Text = "Colors";
			this.labelShoesColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericShoesDesign.Location = new global::System.Drawing.Point(12, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericShoesDesign;
			int[] array13 = new int[4];
			array13[0] = 3;
			numericUpDown13.Maximum = new decimal(array13);
			this.numericShoesDesign.Name = "numericShoesDesign";
			this.numericShoesDesign.Size = new global::System.Drawing.Size(80, 20);
			this.numericShoesDesign.TabIndex = 10;
			this.numericShoesDesign.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericShoesDesign;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Value = new decimal(array14);
			this.numericShoesDesign.ValueChanged += new global::System.EventHandler(this.numericShoesDesign_ValueChanged);
			this.viewer2DShoes.AutoTransparency = false;
			this.viewer2DShoes.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DShoes.ButtonStripVisible = false;
			this.viewer2DShoes.CurrentBitmap = null;
			this.viewer2DShoes.ExtendedFormat = false;
			this.viewer2DShoes.FullSizeButton = false;
			this.viewer2DShoes.ImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.viewer2DShoes.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DShoes.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.Double;
			this.viewer2DShoes.Location = new global::System.Drawing.Point(107, 37);
			this.viewer2DShoes.Name = "viewer2DShoes";
			this.viewer2DShoes.RemoveButton = false;
			this.viewer2DShoes.ShowButton = false;
			this.viewer2DShoes.ShowButtonChecked = true;
			this.viewer2DShoes.Size = new global::System.Drawing.Size(128, 128);
			this.viewer2DShoes.TabIndex = 59;
			this.labelShoes.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelShoes.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelShoes.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelShoes.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShoes.Location = new global::System.Drawing.Point(106, 14);
			this.labelShoes.Name = "labelShoes";
			this.labelShoes.Size = new global::System.Drawing.Size(131, 20);
			this.labelShoes.TabIndex = 47;
			this.labelShoes.Text = "Shoes";
			this.labelShoes.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelShoes.DoubleClick += new global::System.EventHandler(this.labelShoes_DoubleClick);
			this.groupBox1.Controls.Add(this.labelPreferredPositions);
			this.groupBox1.Controls.Add(this.comboPreferredPosition4);
			this.groupBox1.Controls.Add(this.comboPreferredPosition3);
			this.groupBox1.Controls.Add(this.comboPreferredPosition2);
			this.groupBox1.Controls.Add(this.comboPreferredPosition1);
			this.groupBox1.Controls.Add(this.domainInternationalReputation);
			this.groupBox1.Controls.Add(this.labelInternationalReputation);
			this.groupBox1.Location = new global::System.Drawing.Point(400, 432);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(243, 215);
			this.groupBox1.TabIndex = 89;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Playing Info";
			this.labelPreferredPositions.AutoSize = true;
			this.labelPreferredPositions.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPreferredPositions.Location = new global::System.Drawing.Point(66, 12);
			this.labelPreferredPositions.Name = "labelPreferredPositions";
			this.labelPreferredPositions.Size = new global::System.Drawing.Size(95, 13);
			this.labelPreferredPositions.TabIndex = 157;
			this.labelPreferredPositions.Text = "Preferred Positions";
			this.labelPreferredPositions.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboPreferredPosition4.FormattingEnabled = true;
			this.comboPreferredPosition4.Items.AddRange(new object[]
			{
				"None", "Goalkeeper", "Sweeper", "Right Wing Back", "Right Back", "Right Central Back", "Central Back", "Left Central Back", "Left Back", "Left Wing Back",
				"Right Defensive Midfielder", "Central Defensive Midfielder", "Left Defensive Midfielder", "Right Midfielder", "Right Central Midfielder", "Central Midfielder", "Left Central Midfielder", "Left Midfielder", "Right Advanced Midfielder", "Central Advanced Midfielder",
				"Left Advanced Midfielder", "Right Forward", "Central Forward", "Left Forward", "Right Wing", "Right Striker", "Central Striker", "Left Striker", "Left Wing"
			});
			this.comboPreferredPosition4.Location = new global::System.Drawing.Point(18, 121);
			this.comboPreferredPosition4.Name = "comboPreferredPosition4";
			this.comboPreferredPosition4.Size = new global::System.Drawing.Size(208, 21);
			this.comboPreferredPosition4.TabIndex = 3;
			this.comboPreferredPosition4.SelectedIndexChanged += new global::System.EventHandler(this.comboPreferredPosition4_SelectedIndexChanged);
			this.comboPreferredPosition3.FormattingEnabled = true;
			this.comboPreferredPosition3.Items.AddRange(new object[]
			{
				"None", "Goalkeeper", "Sweeper", "Right Wing Back", "Right Back", "Right Central Back", "Central Back", "Left Central Back", "Left Back", "Left Wing Back",
				"Right Defensive Midfielder", "Central Defensive Midfielder", "Left Defensive Midfielder", "Right Midfielder", "Right Central Midfielder", "Central Midfielder", "Left Central Midfielder", "Left Midfielder", "Right Advanced Midfielder", "Central Advanced Midfielder",
				"Left Advanced Midfielder", "Right Forward", "Central Forward", "Left Forward", "Right Wing", "Right Striker", "Central Striker", "Left Striker", "Left Wing"
			});
			this.comboPreferredPosition3.Location = new global::System.Drawing.Point(17, 94);
			this.comboPreferredPosition3.Name = "comboPreferredPosition3";
			this.comboPreferredPosition3.Size = new global::System.Drawing.Size(208, 21);
			this.comboPreferredPosition3.TabIndex = 2;
			this.comboPreferredPosition3.SelectedIndexChanged += new global::System.EventHandler(this.comboPreferredPosition3_SelectedIndexChanged);
			this.comboPreferredPosition2.FormattingEnabled = true;
			this.comboPreferredPosition2.Items.AddRange(new object[]
			{
				"None", "Goalkeeper", "Sweeper", "Right Wing Back", "Right Back", "Right Central Back", "Central Back", "Left Central Back", "Left Back", "Left Wing Back",
				"Right Defensive Midfielder", "Central Defensive Midfielder", "Left Defensive Midfielder", "Right Midfielder", "Right Central Midfielder", "Central Midfielder", "Left Central Midfielder", "Left Midfielder", "Right Advanced Midfielder", "Central Advanced Midfielder",
				"Left Advanced Midfielder", "Right Forward", "Central Forward", "Left Forward", "Right Wing", "Right Striker", "Central Striker", "Left Striker", "Left Wing"
			});
			this.comboPreferredPosition2.Location = new global::System.Drawing.Point(17, 67);
			this.comboPreferredPosition2.Name = "comboPreferredPosition2";
			this.comboPreferredPosition2.Size = new global::System.Drawing.Size(208, 21);
			this.comboPreferredPosition2.TabIndex = 1;
			this.comboPreferredPosition2.SelectedIndexChanged += new global::System.EventHandler(this.comboPreferredPosition2_SelectedIndexChanged);
			this.comboPreferredPosition1.FormattingEnabled = true;
			this.comboPreferredPosition1.Items.AddRange(new object[]
			{
				"None", "Goalkeeper", "Sweeper", "Right Wing Back", "Right Back", "Right Central Back", "Central Back", "Left Central Back", "Left Back", "Left Wing Back",
				"Right Defensive Midfielder", "Central Defensive Midfielder", "Left Defensive Midfielder", "Right Midfielder", "Right Central Midfielder", "Central Midfielder", "Left Central Midfielder", "Left Midfielder", "Right Advanced Midfielder", "Central Advanced Midfielder",
				"Left Advanced Midfielder", "Right Forward", "Central Forward", "Left Forward", "Right Wing", "Right Striker", "Central Striker", "Left Striker", "Left Wing"
			});
			this.comboPreferredPosition1.Location = new global::System.Drawing.Point(17, 40);
			this.comboPreferredPosition1.Name = "comboPreferredPosition1";
			this.comboPreferredPosition1.Size = new global::System.Drawing.Size(208, 21);
			this.comboPreferredPosition1.TabIndex = 0;
			this.comboPreferredPosition1.SelectedIndexChanged += new global::System.EventHandler(this.comboPreferredPosition1_SelectedIndexChanged);
			this.domainInternationalReputation.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "internationalrep", true));
			this.domainInternationalReputation.Items.Add("Poor");
			this.domainInternationalReputation.Items.Add("Medium");
			this.domainInternationalReputation.Items.Add("Good");
			this.domainInternationalReputation.Items.Add("Very Good");
			this.domainInternationalReputation.Items.Add("Superstar");
			this.domainInternationalReputation.Location = new global::System.Drawing.Point(107, 164);
			this.domainInternationalReputation.Name = "domainInternationalReputation";
			this.domainInternationalReputation.Size = new global::System.Drawing.Size(119, 20);
			this.domainInternationalReputation.TabIndex = 4;
			this.domainInternationalReputation.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainInternationalReputation.Wrap = true;
			this.labelInternationalReputation.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelInternationalReputation.Location = new global::System.Drawing.Point(14, 152);
			this.labelInternationalReputation.Name = "labelInternationalReputation";
			this.labelInternationalReputation.Size = new global::System.Drawing.Size(87, 41);
			this.labelInternationalReputation.TabIndex = 141;
			this.labelInternationalReputation.Text = "International Reputation";
			this.labelInternationalReputation.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pageSkills.Controls.Add(this.flowPanelSkills);
			this.pageSkills.ImageIndex = 1;
			this.pageSkills.Location = new global::System.Drawing.Point(4, 23);
			this.pageSkills.Name = "pageSkills";
			this.pageSkills.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageSkills.Size = new global::System.Drawing.Size(1349, 780);
			this.pageSkills.TabIndex = 1;
			this.pageSkills.Text = "Skills";
			this.pageSkills.UseVisualStyleBackColor = true;
			this.flowPanelSkills.AutoScroll = true;
			this.flowPanelSkills.Controls.Add(this.groupGenerateAttributes);
			this.flowPanelSkills.Controls.Add(this.groupGoalkeperSkills);
			this.flowPanelSkills.Controls.Add(this.groupDefensiveSkills);
			this.flowPanelSkills.Controls.Add(this.groupMidfielderSkills);
			this.flowPanelSkills.Controls.Add(this.groupMental);
			this.flowPanelSkills.Controls.Add(this.groupAttackingSkills);
			this.flowPanelSkills.Controls.Add(this.groupGenericAttributes);
			this.flowPanelSkills.Controls.Add(this.groupFreeKick);
			this.flowPanelSkills.Controls.Add(this.groupTraits);
			this.flowPanelSkills.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowPanelSkills.Location = new global::System.Drawing.Point(3, 3);
			this.flowPanelSkills.Name = "flowPanelSkills";
			this.flowPanelSkills.Size = new global::System.Drawing.Size(1343, 774);
			this.flowPanelSkills.TabIndex = 0;
			this.groupGenerateAttributes.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupGenerateAttributes.Controls.Add(this.labelOverallrating);
			this.groupGenerateAttributes.Controls.Add(this.trackOverallrating);
			this.groupGenerateAttributes.Controls.Add(this.labelRandomize);
			this.groupGenerateAttributes.Controls.Add(this.numericRandomize);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomAboveAvg);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomBelowAvg);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomSuperstar);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomVeryGood);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomGood);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomAverage);
			this.groupGenerateAttributes.Controls.Add(this.buttonRandomPoor);
			this.groupGenerateAttributes.Location = new global::System.Drawing.Point(3, 3);
			this.groupGenerateAttributes.Name = "groupGenerateAttributes";
			this.groupGenerateAttributes.Size = new global::System.Drawing.Size(128, 378);
			this.groupGenerateAttributes.TabIndex = 9;
			this.groupGenerateAttributes.TabStop = false;
			this.groupGenerateAttributes.Text = "Random Generation";
			this.labelOverallrating.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelOverallrating.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelOverallrating.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelOverallrating.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelOverallrating.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelOverallrating.Image");
			this.labelOverallrating.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelOverallrating.Location = new global::System.Drawing.Point(10, 280);
			this.labelOverallrating.Name = "labelOverallrating";
			this.labelOverallrating.Size = new global::System.Drawing.Size(112, 16);
			this.labelOverallrating.TabIndex = 126;
			this.labelOverallrating.Text = "Overall ";
			this.labelOverallrating.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackOverallrating.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackOverallrating.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackOverallrating.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "overallrating", true));
			this.trackOverallrating.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackOverallrating.LargeChange = 10;
			this.trackOverallrating.Location = new global::System.Drawing.Point(2, 288);
			this.trackOverallrating.Maximum = 99;
			this.trackOverallrating.Minimum = 1;
			this.trackOverallrating.Name = "trackOverallrating";
			this.trackOverallrating.Size = new global::System.Drawing.Size(128, 45);
			this.trackOverallrating.TabIndex = 125;
			this.trackOverallrating.TickFrequency = 10;
			this.trackOverallrating.Value = 1;
			this.trackOverallrating.ValueChanged += new global::System.EventHandler(this.trackOverallrating_ValueChanged);
			this.labelRandomize.Location = new global::System.Drawing.Point(2, 16);
			this.labelRandomize.Name = "labelRandomize";
			this.labelRandomize.Size = new global::System.Drawing.Size(56, 31);
			this.labelRandomize.TabIndex = 8;
			this.labelRandomize.Text = "Computed Overall";
			this.numericRandomize.Location = new global::System.Drawing.Point(59, 24);
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numericRandomize;
			int[] array15 = new int[4];
			array15[0] = 99;
			numericUpDown15.Maximum = new decimal(array15);
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numericRandomize;
			int[] array16 = new int[4];
			array16[0] = 1;
			numericUpDown16.Minimum = new decimal(array16);
			this.numericRandomize.Name = "numericRandomize";
			this.numericRandomize.Size = new global::System.Drawing.Size(53, 20);
			this.numericRandomize.TabIndex = 0;
			this.numericRandomize.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numericRandomize;
			int[] array17 = new int[4];
			array17[0] = 1;
			numericUpDown17.Value = new decimal(array17);
			this.numericRandomize.ValueChanged += new global::System.EventHandler(this.numericOverall_ValueChanged);
			this.buttonRandomAboveAvg.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomAboveAvg.Location = new global::System.Drawing.Point(11, 134);
			this.buttonRandomAboveAvg.Name = "buttonRandomAboveAvg";
			this.buttonRandomAboveAvg.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomAboveAvg.TabIndex = 4;
			this.buttonRandomAboveAvg.Text = "Above Avg.";
			this.buttonRandomAboveAvg.Click += new global::System.EventHandler(this.buttonRandomAboveAvg_Click);
			this.buttonRandomBelowAvg.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomBelowAvg.Location = new global::System.Drawing.Point(11, 78);
			this.buttonRandomBelowAvg.Name = "buttonRandomBelowAvg";
			this.buttonRandomBelowAvg.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomBelowAvg.TabIndex = 2;
			this.buttonRandomBelowAvg.Text = "Below Avg.";
			this.buttonRandomBelowAvg.Click += new global::System.EventHandler(this.buttonRandomBelowAvg_Click);
			this.buttonRandomSuperstar.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonRandomSuperstar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomSuperstar.Location = new global::System.Drawing.Point(11, 219);
			this.buttonRandomSuperstar.Name = "buttonRandomSuperstar";
			this.buttonRandomSuperstar.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomSuperstar.TabIndex = 7;
			this.buttonRandomSuperstar.Text = "Superstar";
			this.buttonRandomSuperstar.Click += new global::System.EventHandler(this.buttonRandomSuperstar_Click);
			this.buttonRandomVeryGood.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomVeryGood.Location = new global::System.Drawing.Point(11, 190);
			this.buttonRandomVeryGood.Name = "buttonRandomVeryGood";
			this.buttonRandomVeryGood.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomVeryGood.TabIndex = 6;
			this.buttonRandomVeryGood.Text = "Very Good";
			this.buttonRandomVeryGood.Click += new global::System.EventHandler(this.buttonRandomVeryGood_Click);
			this.buttonRandomGood.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomGood.Location = new global::System.Drawing.Point(11, 162);
			this.buttonRandomGood.Name = "buttonRandomGood";
			this.buttonRandomGood.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomGood.TabIndex = 5;
			this.buttonRandomGood.Text = "Good";
			this.buttonRandomGood.Click += new global::System.EventHandler(this.buttonRandomGood_Click);
			this.buttonRandomAverage.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomAverage.Location = new global::System.Drawing.Point(11, 106);
			this.buttonRandomAverage.Name = "buttonRandomAverage";
			this.buttonRandomAverage.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomAverage.TabIndex = 3;
			this.buttonRandomAverage.Text = "Average";
			this.buttonRandomAverage.Click += new global::System.EventHandler(this.buttonRandomAverage_Click);
			this.buttonRandomPoor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomPoor.Location = new global::System.Drawing.Point(11, 50);
			this.buttonRandomPoor.Name = "buttonRandomPoor";
			this.buttonRandomPoor.Size = new global::System.Drawing.Size(101, 27);
			this.buttonRandomPoor.TabIndex = 1;
			this.buttonRandomPoor.Text = "Poor";
			this.buttonRandomPoor.Click += new global::System.EventHandler(this.buttonRandomPoor_Click);
			this.groupGoalkeperSkills.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupGoalkeperSkills.Controls.Add(this.label5);
			this.groupGoalkeperSkills.Controls.Add(this.comboGkSaveStyle);
			this.groupGoalkeperSkills.Controls.Add(this.label3);
			this.groupGoalkeperSkills.Controls.Add(this.labelGkKick);
			this.groupGoalkeperSkills.Controls.Add(this.comboGkKickStyle);
			this.groupGoalkeperSkills.Controls.Add(this.trackGkKicking);
			this.groupGoalkeperSkills.Controls.Add(this.labelDiving);
			this.groupGoalkeperSkills.Controls.Add(this.labelPositioning);
			this.groupGoalkeperSkills.Controls.Add(this.labelReflexes);
			this.groupGoalkeperSkills.Controls.Add(this.labelHandling);
			this.groupGoalkeperSkills.Controls.Add(this.trackDiving);
			this.groupGoalkeperSkills.Controls.Add(this.trackPositioning);
			this.groupGoalkeperSkills.Controls.Add(this.trackReflexes);
			this.groupGoalkeperSkills.Controls.Add(this.trackHandling);
			this.groupGoalkeperSkills.Controls.Add(this.numericGoalkeeperSkills);
			this.groupGoalkeperSkills.Location = new global::System.Drawing.Point(137, 3);
			this.groupGoalkeperSkills.Name = "groupGoalkeperSkills";
			this.groupGoalkeperSkills.Size = new global::System.Drawing.Size(140, 378);
			this.groupGoalkeperSkills.TabIndex = 14;
			this.groupGoalkeperSkills.TabStop = false;
			this.groupGoalkeperSkills.Text = "Goalkeeper Skills";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(43, 301);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(58, 13);
			this.label5.TabIndex = 96;
			this.label5.Text = "Save Style";
			this.comboGkSaveStyle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "gksavetype", true));
			this.comboGkSaveStyle.FormattingEnabled = true;
			this.comboGkSaveStyle.Items.AddRange(new object[] { "Traditional", "Acrobatic" });
			this.comboGkSaveStyle.Location = new global::System.Drawing.Point(7, 317);
			this.comboGkSaveStyle.Name = "comboGkSaveStyle";
			this.comboGkSaveStyle.Size = new global::System.Drawing.Size(124, 21);
			this.comboGkSaveStyle.TabIndex = 95;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 280);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(54, 13);
			this.label3.TabIndex = 81;
			this.label3.Text = "Kick Style";
			this.labelGkKick.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelGkKick.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelGkKick.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelGkKick.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelGkKick.Image");
			this.labelGkKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelGkKick.Location = new global::System.Drawing.Point(14, 232);
			this.labelGkKick.Name = "labelGkKick";
			this.labelGkKick.Size = new global::System.Drawing.Size(112, 16);
			this.labelGkKick.TabIndex = 94;
			this.labelGkKick.Text = "Kicking ";
			this.labelGkKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.comboGkKickStyle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "gkkickstyle", true));
			this.comboGkKickStyle.FormattingEnabled = true;
			this.comboGkKickStyle.Items.AddRange(new object[] { "0", "1", "2", "3" });
			this.comboGkKickStyle.Location = new global::System.Drawing.Point(66, 277);
			this.comboGkKickStyle.Name = "comboGkKickStyle";
			this.comboGkKickStyle.Size = new global::System.Drawing.Size(65, 21);
			this.comboGkKickStyle.TabIndex = 7;
			this.trackGkKicking.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackGkKicking.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.trackGkKicking.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkkicking", true));
			this.trackGkKicking.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackGkKicking.LargeChange = 10;
			this.trackGkKicking.Location = new global::System.Drawing.Point(6, 240);
			this.trackGkKicking.Maximum = 99;
			this.trackGkKicking.Minimum = 1;
			this.trackGkKicking.Name = "trackGkKicking";
			this.trackGkKicking.Size = new global::System.Drawing.Size(128, 45);
			this.trackGkKicking.TabIndex = 6;
			this.trackGkKicking.TickFrequency = 10;
			this.trackGkKicking.Value = 1;
			this.trackGkKicking.ValueChanged += new global::System.EventHandler(this.trackGkKick_ValueChanged);
			this.labelDiving.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelDiving.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelDiving.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelDiving.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelDiving.Image");
			this.labelDiving.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDiving.Location = new global::System.Drawing.Point(14, 136);
			this.labelDiving.Name = "labelDiving";
			this.labelDiving.Size = new global::System.Drawing.Size(112, 16);
			this.labelDiving.TabIndex = 88;
			this.labelDiving.Text = "Diving ";
			this.labelDiving.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPositioning.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelPositioning.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPositioning.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelPositioning.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelPositioning.Image");
			this.labelPositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPositioning.Location = new global::System.Drawing.Point(14, 184);
			this.labelPositioning.Name = "labelPositioning";
			this.labelPositioning.Size = new global::System.Drawing.Size(112, 16);
			this.labelPositioning.TabIndex = 90;
			this.labelPositioning.Text = "Positioning ";
			this.labelPositioning.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelReflexes.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelReflexes.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelReflexes.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelReflexes.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelReflexes.Image");
			this.labelReflexes.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelReflexes.Location = new global::System.Drawing.Point(14, 40);
			this.labelReflexes.Name = "labelReflexes";
			this.labelReflexes.Size = new global::System.Drawing.Size(112, 16);
			this.labelReflexes.TabIndex = 84;
			this.labelReflexes.Text = "Reflexes ";
			this.labelReflexes.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHandling.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHandling.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelHandling.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelHandling.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelHandling.Image");
			this.labelHandling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHandling.Location = new global::System.Drawing.Point(14, 88);
			this.labelHandling.Name = "labelHandling";
			this.labelHandling.Size = new global::System.Drawing.Size(112, 16);
			this.labelHandling.TabIndex = 86;
			this.labelHandling.Text = "Handling ";
			this.labelHandling.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackDiving.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackDiving.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.trackDiving.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkdiving", true));
			this.trackDiving.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackDiving.LargeChange = 10;
			this.trackDiving.Location = new global::System.Drawing.Point(5, 144);
			this.trackDiving.Maximum = 99;
			this.trackDiving.Minimum = 1;
			this.trackDiving.Name = "trackDiving";
			this.trackDiving.Size = new global::System.Drawing.Size(128, 45);
			this.trackDiving.TabIndex = 3;
			this.trackDiving.TickFrequency = 10;
			this.trackDiving.Value = 1;
			this.trackDiving.ValueChanged += new global::System.EventHandler(this.trackDiving_ValueChanged);
			this.trackPositioning.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackPositioning.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.trackPositioning.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkpositioning", true));
			this.trackPositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackPositioning.LargeChange = 10;
			this.trackPositioning.Location = new global::System.Drawing.Point(6, 195);
			this.trackPositioning.Maximum = 99;
			this.trackPositioning.Minimum = 1;
			this.trackPositioning.Name = "trackPositioning";
			this.trackPositioning.Size = new global::System.Drawing.Size(128, 45);
			this.trackPositioning.TabIndex = 4;
			this.trackPositioning.TickFrequency = 10;
			this.trackPositioning.Value = 1;
			this.trackPositioning.ValueChanged += new global::System.EventHandler(this.trackPositioning_ValueChanged);
			this.trackReflexes.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackReflexes.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.trackReflexes.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkreflexes", true));
			this.trackReflexes.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackReflexes.LargeChange = 10;
			this.trackReflexes.Location = new global::System.Drawing.Point(6, 48);
			this.trackReflexes.Maximum = 99;
			this.trackReflexes.Minimum = 1;
			this.trackReflexes.Name = "trackReflexes";
			this.trackReflexes.Size = new global::System.Drawing.Size(128, 45);
			this.trackReflexes.TabIndex = 1;
			this.trackReflexes.TickFrequency = 10;
			this.trackReflexes.Value = 1;
			this.trackReflexes.ValueChanged += new global::System.EventHandler(this.trackReflexes_ValueChanged);
			this.trackHandling.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackHandling.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.trackHandling.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "gkhandling", true));
			this.trackHandling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackHandling.LargeChange = 10;
			this.trackHandling.Location = new global::System.Drawing.Point(5, 96);
			this.trackHandling.Maximum = 99;
			this.trackHandling.Minimum = 1;
			this.trackHandling.Name = "trackHandling";
			this.trackHandling.Size = new global::System.Drawing.Size(128, 45);
			this.trackHandling.TabIndex = 2;
			this.trackHandling.TickFrequency = 10;
			this.trackHandling.Value = 1;
			this.trackHandling.ValueChanged += new global::System.EventHandler(this.trackHandling_ValueChanged);
			this.numericGoalkeeperSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericGoalkeeperSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericGoalkeeperSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericGoalkeeperSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericGoalkeeperSkills.Location = new global::System.Drawing.Point(49, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numericGoalkeeperSkills;
			int[] array18 = new int[4];
			array18[0] = 99;
			numericUpDown18.Maximum = new decimal(array18);
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numericGoalkeeperSkills;
			int[] array19 = new int[4];
			array19[0] = 1;
			numericUpDown19.Minimum = new decimal(array19);
			this.numericGoalkeeperSkills.Name = "numericGoalkeeperSkills";
			this.numericGoalkeeperSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericGoalkeeperSkills.TabIndex = 0;
			this.numericGoalkeeperSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numericGoalkeeperSkills;
			int[] array20 = new int[4];
			array20[0] = 99;
			numericUpDown20.Value = new decimal(array20);
			this.numericGoalkeeperSkills.ValueChanged += new global::System.EventHandler(this.numericGoalkeeperSkills_ValueChanged);
			this.groupDefensiveSkills.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupDefensiveSkills.Controls.Add(this.labelInterception);
			this.groupDefensiveSkills.Controls.Add(this.trackInterception);
			this.groupDefensiveSkills.Controls.Add(this.labelSliding);
			this.groupDefensiveSkills.Controls.Add(this.trackSliding);
			this.groupDefensiveSkills.Controls.Add(this.numericDefensiveSkills);
			this.groupDefensiveSkills.Controls.Add(this.labelAggression);
			this.groupDefensiveSkills.Controls.Add(this.labelMarking);
			this.groupDefensiveSkills.Controls.Add(this.labelTackling);
			this.groupDefensiveSkills.Controls.Add(this.trackTackling);
			this.groupDefensiveSkills.Controls.Add(this.trackMarking);
			this.groupDefensiveSkills.Controls.Add(this.trackAggression);
			this.groupDefensiveSkills.Location = new global::System.Drawing.Point(283, 3);
			this.groupDefensiveSkills.Name = "groupDefensiveSkills";
			this.groupDefensiveSkills.Size = new global::System.Drawing.Size(140, 378);
			this.groupDefensiveSkills.TabIndex = 15;
			this.groupDefensiveSkills.TabStop = false;
			this.groupDefensiveSkills.Text = "Defensive Skills";
			this.labelInterception.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelInterception.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelInterception.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelInterception.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelInterception.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelInterception.Image");
			this.labelInterception.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelInterception.Location = new global::System.Drawing.Point(16, 230);
			this.labelInterception.Name = "labelInterception";
			this.labelInterception.Size = new global::System.Drawing.Size(112, 16);
			this.labelInterception.TabIndex = 102;
			this.labelInterception.Text = "Interception ";
			this.labelInterception.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackInterception.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackInterception.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackInterception.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "interceptions", true));
			this.trackInterception.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackInterception.LargeChange = 10;
			this.trackInterception.Location = new global::System.Drawing.Point(6, 238);
			this.trackInterception.Maximum = 99;
			this.trackInterception.Minimum = 1;
			this.trackInterception.Name = "trackInterception";
			this.trackInterception.Size = new global::System.Drawing.Size(128, 45);
			this.trackInterception.TabIndex = 101;
			this.trackInterception.TickFrequency = 10;
			this.trackInterception.Value = 1;
			this.trackInterception.ValueChanged += new global::System.EventHandler(this.trackInterception_ValueChanged);
			this.labelSliding.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelSliding.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelSliding.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelSliding.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelSliding.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelSliding.Image");
			this.labelSliding.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSliding.Location = new global::System.Drawing.Point(16, 184);
			this.labelSliding.Name = "labelSliding";
			this.labelSliding.Size = new global::System.Drawing.Size(112, 16);
			this.labelSliding.TabIndex = 100;
			this.labelSliding.Text = "Sliding ";
			this.labelSliding.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackSliding.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackSliding.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackSliding.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "slidingtackle", true));
			this.trackSliding.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackSliding.LargeChange = 10;
			this.trackSliding.Location = new global::System.Drawing.Point(6, 192);
			this.trackSliding.Maximum = 99;
			this.trackSliding.Minimum = 1;
			this.trackSliding.Name = "trackSliding";
			this.trackSliding.Size = new global::System.Drawing.Size(128, 45);
			this.trackSliding.TabIndex = 4;
			this.trackSliding.TickFrequency = 10;
			this.trackSliding.Value = 1;
			this.trackSliding.ValueChanged += new global::System.EventHandler(this.trackSliding_ValueChanged);
			this.numericDefensiveSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericDefensiveSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericDefensiveSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericDefensiveSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericDefensiveSkills.Location = new global::System.Drawing.Point(48, 16);
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numericDefensiveSkills;
			int[] array21 = new int[4];
			array21[0] = 99;
			numericUpDown21.Maximum = new decimal(array21);
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numericDefensiveSkills;
			int[] array22 = new int[4];
			array22[0] = 1;
			numericUpDown22.Minimum = new decimal(array22);
			this.numericDefensiveSkills.Name = "numericDefensiveSkills";
			this.numericDefensiveSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericDefensiveSkills.TabIndex = 0;
			this.numericDefensiveSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numericDefensiveSkills;
			int[] array23 = new int[4];
			array23[0] = 99;
			numericUpDown23.Value = new decimal(array23);
			this.numericDefensiveSkills.ValueChanged += new global::System.EventHandler(this.numericDefensiveSkills_ValueChanged);
			this.labelAggression.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelAggression.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelAggression.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelAggression.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelAggression.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelAggression.Image");
			this.labelAggression.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAggression.Location = new global::System.Drawing.Point(14, 136);
			this.labelAggression.Name = "labelAggression";
			this.labelAggression.Size = new global::System.Drawing.Size(112, 16);
			this.labelAggression.TabIndex = 67;
			this.labelAggression.Text = "Aggression ";
			this.labelAggression.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMarking.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelMarking.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelMarking.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelMarking.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelMarking.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelMarking.Image");
			this.labelMarking.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelMarking.Location = new global::System.Drawing.Point(14, 40);
			this.labelMarking.Name = "labelMarking";
			this.labelMarking.Size = new global::System.Drawing.Size(112, 16);
			this.labelMarking.TabIndex = 75;
			this.labelMarking.Text = "Marking ";
			this.labelMarking.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTackling.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelTackling.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelTackling.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelTackling.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelTackling.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelTackling.Image");
			this.labelTackling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelTackling.Location = new global::System.Drawing.Point(14, 88);
			this.labelTackling.Name = "labelTackling";
			this.labelTackling.Size = new global::System.Drawing.Size(112, 16);
			this.labelTackling.TabIndex = 77;
			this.labelTackling.Text = "Tackling ";
			this.labelTackling.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackTackling.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackTackling.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackTackling.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "standingtackle", true));
			this.trackTackling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackTackling.LargeChange = 10;
			this.trackTackling.Location = new global::System.Drawing.Point(6, 96);
			this.trackTackling.Maximum = 99;
			this.trackTackling.Minimum = 1;
			this.trackTackling.Name = "trackTackling";
			this.trackTackling.Size = new global::System.Drawing.Size(128, 45);
			this.trackTackling.TabIndex = 2;
			this.trackTackling.TickFrequency = 10;
			this.trackTackling.Value = 1;
			this.trackTackling.ValueChanged += new global::System.EventHandler(this.trackTackling_ValueChanged);
			this.trackMarking.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackMarking.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackMarking.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "marking", true));
			this.trackMarking.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackMarking.LargeChange = 10;
			this.trackMarking.Location = new global::System.Drawing.Point(6, 48);
			this.trackMarking.Maximum = 99;
			this.trackMarking.Minimum = 1;
			this.trackMarking.Name = "trackMarking";
			this.trackMarking.Size = new global::System.Drawing.Size(128, 45);
			this.trackMarking.TabIndex = 1;
			this.trackMarking.TickFrequency = 10;
			this.trackMarking.Value = 1;
			this.trackMarking.ValueChanged += new global::System.EventHandler(this.trackMarking_ValueChanged);
			this.trackAggression.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackAggression.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackAggression.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "aggression", true));
			this.trackAggression.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackAggression.LargeChange = 10;
			this.trackAggression.Location = new global::System.Drawing.Point(6, 144);
			this.trackAggression.Maximum = 99;
			this.trackAggression.Minimum = 1;
			this.trackAggression.Name = "trackAggression";
			this.trackAggression.Size = new global::System.Drawing.Size(128, 45);
			this.trackAggression.TabIndex = 3;
			this.trackAggression.TickFrequency = 10;
			this.trackAggression.Value = 1;
			this.trackAggression.ValueChanged += new global::System.EventHandler(this.trackAggression_ValueChanged);
			this.groupMidfielderSkills.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupMidfielderSkills.Controls.Add(this.labelCurve);
			this.groupMidfielderSkills.Controls.Add(this.trackCurve);
			this.groupMidfielderSkills.Controls.Add(this.labelVision);
			this.groupMidfielderSkills.Controls.Add(this.trackVision);
			this.groupMidfielderSkills.Controls.Add(this.numericMidfielderSkills);
			this.groupMidfielderSkills.Controls.Add(this.labelBallControl);
			this.groupMidfielderSkills.Controls.Add(this.labelCrossing);
			this.groupMidfielderSkills.Controls.Add(this.labelLongPassing);
			this.groupMidfielderSkills.Controls.Add(this.trackLongPassing);
			this.groupMidfielderSkills.Controls.Add(this.labelShortPassing);
			this.groupMidfielderSkills.Controls.Add(this.trackShortPassing);
			this.groupMidfielderSkills.Controls.Add(this.trackBallControl);
			this.groupMidfielderSkills.Controls.Add(this.trackCrossing);
			this.groupMidfielderSkills.Location = new global::System.Drawing.Point(429, 3);
			this.groupMidfielderSkills.Name = "groupMidfielderSkills";
			this.groupMidfielderSkills.Size = new global::System.Drawing.Size(140, 378);
			this.groupMidfielderSkills.TabIndex = 16;
			this.groupMidfielderSkills.TabStop = false;
			this.groupMidfielderSkills.Text = "Midfielder Skills";
			this.labelCurve.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelCurve.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelCurve.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCurve.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelCurve.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelCurve.Image");
			this.labelCurve.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCurve.Location = new global::System.Drawing.Point(11, 280);
			this.labelCurve.Name = "labelCurve";
			this.labelCurve.Size = new global::System.Drawing.Size(112, 16);
			this.labelCurve.TabIndex = 106;
			this.labelCurve.Text = "Curve ";
			this.labelCurve.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackCurve.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackCurve.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackCurve.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "curve", true));
			this.trackCurve.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackCurve.LargeChange = 10;
			this.trackCurve.Location = new global::System.Drawing.Point(1, 288);
			this.trackCurve.Maximum = 99;
			this.trackCurve.Minimum = 1;
			this.trackCurve.Name = "trackCurve";
			this.trackCurve.Size = new global::System.Drawing.Size(128, 45);
			this.trackCurve.TabIndex = 6;
			this.trackCurve.TickFrequency = 10;
			this.trackCurve.Value = 1;
			this.trackCurve.ValueChanged += new global::System.EventHandler(this.trackCurve_ValueChanged);
			this.labelVision.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelVision.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelVision.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelVision.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelVision.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelVision.Image");
			this.labelVision.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelVision.Location = new global::System.Drawing.Point(11, 232);
			this.labelVision.Name = "labelVision";
			this.labelVision.Size = new global::System.Drawing.Size(112, 16);
			this.labelVision.TabIndex = 104;
			this.labelVision.Text = "Vision ";
			this.labelVision.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackVision.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackVision.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackVision.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "vision", true));
			this.trackVision.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackVision.LargeChange = 10;
			this.trackVision.Location = new global::System.Drawing.Point(1, 240);
			this.trackVision.Maximum = 99;
			this.trackVision.Minimum = 1;
			this.trackVision.Name = "trackVision";
			this.trackVision.Size = new global::System.Drawing.Size(128, 45);
			this.trackVision.TabIndex = 5;
			this.trackVision.TickFrequency = 10;
			this.trackVision.Value = 1;
			this.trackVision.ValueChanged += new global::System.EventHandler(this.trackVision_ValueChanged);
			this.numericMidfielderSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericMidfielderSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericMidfielderSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericMidfielderSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericMidfielderSkills.Location = new global::System.Drawing.Point(41, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numericMidfielderSkills;
			int[] array24 = new int[4];
			array24[0] = 99;
			numericUpDown24.Maximum = new decimal(array24);
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.numericMidfielderSkills;
			int[] array25 = new int[4];
			array25[0] = 1;
			numericUpDown25.Minimum = new decimal(array25);
			this.numericMidfielderSkills.Name = "numericMidfielderSkills";
			this.numericMidfielderSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericMidfielderSkills.TabIndex = 0;
			this.numericMidfielderSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.numericMidfielderSkills;
			int[] array26 = new int[4];
			array26[0] = 99;
			numericUpDown26.Value = new decimal(array26);
			this.numericMidfielderSkills.ValueChanged += new global::System.EventHandler(this.numericMidfielderSkills_ValueChanged);
			this.labelBallControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelBallControl.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelBallControl.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelBallControl.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelBallControl.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelBallControl.Image");
			this.labelBallControl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBallControl.Location = new global::System.Drawing.Point(11, 184);
			this.labelBallControl.Name = "labelBallControl";
			this.labelBallControl.Size = new global::System.Drawing.Size(112, 16);
			this.labelBallControl.TabIndex = 79;
			this.labelBallControl.Text = "Ball-Control ";
			this.labelBallControl.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCrossing.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelCrossing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelCrossing.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCrossing.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelCrossing.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelCrossing.Image");
			this.labelCrossing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCrossing.Location = new global::System.Drawing.Point(9, 136);
			this.labelCrossing.Name = "labelCrossing";
			this.labelCrossing.Size = new global::System.Drawing.Size(112, 16);
			this.labelCrossing.TabIndex = 84;
			this.labelCrossing.Text = "Crossing ";
			this.labelCrossing.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLongPassing.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLongPassing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelLongPassing.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelLongPassing.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelLongPassing.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelLongPassing.Image");
			this.labelLongPassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLongPassing.Location = new global::System.Drawing.Point(9, 88);
			this.labelLongPassing.Name = "labelLongPassing";
			this.labelLongPassing.Size = new global::System.Drawing.Size(112, 16);
			this.labelLongPassing.TabIndex = 102;
			this.labelLongPassing.Text = "Long-Passing ";
			this.labelLongPassing.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackLongPassing.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackLongPassing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackLongPassing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "longpassing", true));
			this.trackLongPassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackLongPassing.LargeChange = 10;
			this.trackLongPassing.Location = new global::System.Drawing.Point(1, 96);
			this.trackLongPassing.Maximum = 99;
			this.trackLongPassing.Minimum = 1;
			this.trackLongPassing.Name = "trackLongPassing";
			this.trackLongPassing.Size = new global::System.Drawing.Size(128, 45);
			this.trackLongPassing.TabIndex = 2;
			this.trackLongPassing.TickFrequency = 10;
			this.trackLongPassing.Value = 1;
			this.trackLongPassing.ValueChanged += new global::System.EventHandler(this.trackLongPassing_ValueChanged);
			this.labelShortPassing.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelShortPassing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelShortPassing.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelShortPassing.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelShortPassing.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelShortPassing.Image");
			this.labelShortPassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShortPassing.Location = new global::System.Drawing.Point(9, 40);
			this.labelShortPassing.Name = "labelShortPassing";
			this.labelShortPassing.Size = new global::System.Drawing.Size(112, 16);
			this.labelShortPassing.TabIndex = 100;
			this.labelShortPassing.Text = "Short-Passing ";
			this.labelShortPassing.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackShortPassing.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackShortPassing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackShortPassing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "shortpassing", true));
			this.trackShortPassing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackShortPassing.LargeChange = 10;
			this.trackShortPassing.Location = new global::System.Drawing.Point(1, 48);
			this.trackShortPassing.Maximum = 99;
			this.trackShortPassing.Minimum = 1;
			this.trackShortPassing.Name = "trackShortPassing";
			this.trackShortPassing.Size = new global::System.Drawing.Size(128, 45);
			this.trackShortPassing.TabIndex = 1;
			this.trackShortPassing.TickFrequency = 10;
			this.trackShortPassing.Value = 1;
			this.trackShortPassing.ValueChanged += new global::System.EventHandler(this.trackShortPassing_ValueChanged);
			this.trackBallControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackBallControl.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackBallControl.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "ballcontrol", true));
			this.trackBallControl.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackBallControl.LargeChange = 10;
			this.trackBallControl.Location = new global::System.Drawing.Point(1, 192);
			this.trackBallControl.Maximum = 99;
			this.trackBallControl.Minimum = 1;
			this.trackBallControl.Name = "trackBallControl";
			this.trackBallControl.Size = new global::System.Drawing.Size(128, 45);
			this.trackBallControl.TabIndex = 4;
			this.trackBallControl.TickFrequency = 10;
			this.trackBallControl.Value = 1;
			this.trackBallControl.ValueChanged += new global::System.EventHandler(this.trackBallControl_ValueChanged);
			this.trackCrossing.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackCrossing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackCrossing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "crossing", true));
			this.trackCrossing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackCrossing.LargeChange = 10;
			this.trackCrossing.Location = new global::System.Drawing.Point(1, 144);
			this.trackCrossing.Maximum = 99;
			this.trackCrossing.Minimum = 1;
			this.trackCrossing.Name = "trackCrossing";
			this.trackCrossing.Size = new global::System.Drawing.Size(128, 45);
			this.trackCrossing.TabIndex = 3;
			this.trackCrossing.TickFrequency = 10;
			this.trackCrossing.Value = 1;
			this.trackCrossing.ValueChanged += new global::System.EventHandler(this.trackCrossing_ValueChanged);
			this.groupMental.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupMental.Controls.Add(this.label14);
			this.groupMental.Controls.Add(this.numericUpDown5);
			this.groupMental.Controls.Add(this.comboDefensiveWorkrate);
			this.groupMental.Controls.Add(this.label10);
			this.groupMental.Controls.Add(this.comboAttackWorkRate);
			this.groupMental.Controls.Add(this.label9);
			this.groupMental.Controls.Add(this.numericMentalSkills);
			this.groupMental.Controls.Add(this.labelPlayerPositioning);
			this.groupMental.Controls.Add(this.labelPotential);
			this.groupMental.Controls.Add(this.trackPlayerPositioning);
			this.groupMental.Controls.Add(this.trackPotential);
			this.groupMental.Location = new global::System.Drawing.Point(575, 3);
			this.groupMental.Name = "groupMental";
			this.groupMental.Size = new global::System.Drawing.Size(140, 378);
			this.groupMental.TabIndex = 26;
			this.groupMental.TabStop = false;
			this.groupMental.Text = "Mental Skills";
			this.label14.AutoSize = true;
			this.label14.BackColor = global::System.Drawing.Color.Transparent;
			this.label14.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label14.Location = new global::System.Drawing.Point(13, 234);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(45, 13);
			this.label14.TabIndex = 138;
			this.label14.Text = "Emotion";
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericUpDown5.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "emotion", true));
			this.numericUpDown5.Location = new global::System.Drawing.Point(70, 230);
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.numericUpDown5;
			int[] array27 = new int[4];
			array27[0] = 5;
			numericUpDown27.Maximum = new decimal(array27);
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.numericUpDown5;
			int[] array28 = new int[4];
			array28[0] = 1;
			numericUpDown28.Minimum = new decimal(array28);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new global::System.Drawing.Size(58, 20);
			this.numericUpDown5.TabIndex = 137;
			this.numericUpDown5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.numericUpDown5;
			int[] array29 = new int[4];
			array29[0] = 1;
			numericUpDown29.Value = new decimal(array29);
			this.comboDefensiveWorkrate.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "defensiveworkrate", true));
			this.comboDefensiveWorkrate.FormattingEnabled = true;
			this.comboDefensiveWorkrate.Items.AddRange(new object[] { "Medium", "Low", "High" });
			this.comboDefensiveWorkrate.Location = new global::System.Drawing.Point(8, 190);
			this.comboDefensiveWorkrate.Name = "comboDefensiveWorkrate";
			this.comboDefensiveWorkrate.Size = new global::System.Drawing.Size(120, 21);
			this.comboDefensiveWorkrate.TabIndex = 135;
			this.label10.AutoSize = true;
			this.label10.BackColor = global::System.Drawing.Color.Transparent;
			this.label10.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new global::System.Drawing.Point(13, 174);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(102, 13);
			this.label10.TabIndex = 136;
			this.label10.Text = "Defensive Workrate";
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboAttackWorkRate.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "attackingworkrate", true));
			this.comboAttackWorkRate.FormattingEnabled = true;
			this.comboAttackWorkRate.Items.AddRange(new object[] { "Medium", "Low", "High" });
			this.comboAttackWorkRate.Location = new global::System.Drawing.Point(8, 145);
			this.comboAttackWorkRate.Name = "comboAttackWorkRate";
			this.comboAttackWorkRate.Size = new global::System.Drawing.Size(120, 21);
			this.comboAttackWorkRate.TabIndex = 133;
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new global::System.Drawing.Point(15, 129);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(99, 13);
			this.label9.TabIndex = 134;
			this.label9.Text = "Attacking Workrate";
			this.label9.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericMentalSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericMentalSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericMentalSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericMentalSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericMentalSkills.Location = new global::System.Drawing.Point(44, 13);
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.numericMentalSkills;
			int[] array30 = new int[4];
			array30[0] = 99;
			numericUpDown30.Maximum = new decimal(array30);
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.numericMentalSkills;
			int[] array31 = new int[4];
			array31[0] = 1;
			numericUpDown31.Minimum = new decimal(array31);
			this.numericMentalSkills.Name = "numericMentalSkills";
			this.numericMentalSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericMentalSkills.TabIndex = 0;
			this.numericMentalSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.numericMentalSkills;
			int[] array32 = new int[4];
			array32[0] = 99;
			numericUpDown32.Value = new decimal(array32);
			this.numericMentalSkills.ValueChanged += new global::System.EventHandler(this.numericMentalSkills_ValueChanged);
			this.labelPlayerPositioning.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelPlayerPositioning.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelPlayerPositioning.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPlayerPositioning.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelPlayerPositioning.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelPlayerPositioning.Image");
			this.labelPlayerPositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPlayerPositioning.Location = new global::System.Drawing.Point(16, 86);
			this.labelPlayerPositioning.Name = "labelPlayerPositioning";
			this.labelPlayerPositioning.Size = new global::System.Drawing.Size(112, 16);
			this.labelPlayerPositioning.TabIndex = 120;
			this.labelPlayerPositioning.Text = "Positioning ";
			this.labelPlayerPositioning.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPotential.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelPotential.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelPotential.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPotential.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelPotential.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelPotential.Image");
			this.labelPotential.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPotential.Location = new global::System.Drawing.Point(16, 38);
			this.labelPotential.Name = "labelPotential";
			this.labelPotential.Size = new global::System.Drawing.Size(112, 16);
			this.labelPotential.TabIndex = 118;
			this.labelPotential.Text = "Potential ";
			this.labelPotential.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackPlayerPositioning.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackPlayerPositioning.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackPlayerPositioning.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "positioning", true));
			this.trackPlayerPositioning.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackPlayerPositioning.LargeChange = 10;
			this.trackPlayerPositioning.Location = new global::System.Drawing.Point(8, 94);
			this.trackPlayerPositioning.Maximum = 99;
			this.trackPlayerPositioning.Minimum = 1;
			this.trackPlayerPositioning.Name = "trackPlayerPositioning";
			this.trackPlayerPositioning.Size = new global::System.Drawing.Size(128, 45);
			this.trackPlayerPositioning.TabIndex = 3;
			this.trackPlayerPositioning.TickFrequency = 10;
			this.trackPlayerPositioning.Value = 1;
			this.trackPlayerPositioning.ValueChanged += new global::System.EventHandler(this.trackPlayerPositioning_ValueChanged);
			this.trackPotential.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackPotential.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackPotential.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "potential", true));
			this.trackPotential.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackPotential.LargeChange = 10;
			this.trackPotential.Location = new global::System.Drawing.Point(8, 46);
			this.trackPotential.Maximum = 99;
			this.trackPotential.Minimum = 1;
			this.trackPotential.Name = "trackPotential";
			this.trackPotential.Size = new global::System.Drawing.Size(128, 45);
			this.trackPotential.TabIndex = 1;
			this.trackPotential.TickFrequency = 10;
			this.trackPotential.Value = 1;
			this.trackPotential.ValueChanged += new global::System.EventHandler(this.trackPotential_ValueChanged);
			this.groupAttackingSkills.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupAttackingSkills.Controls.Add(this.labelFinishing);
			this.groupAttackingSkills.Controls.Add(this.label6);
			this.groupAttackingSkills.Controls.Add(this.numericUpDown2);
			this.groupAttackingSkills.Controls.Add(this.numericUpDown1);
			this.groupAttackingSkills.Controls.Add(this.labelHeading);
			this.groupAttackingSkills.Controls.Add(this.trackHeading);
			this.groupAttackingSkills.Controls.Add(this.labelVolley);
			this.groupAttackingSkills.Controls.Add(this.trackVolley);
			this.groupAttackingSkills.Controls.Add(this.numericAttackingSkills);
			this.groupAttackingSkills.Controls.Add(this.labelDribbling);
			this.groupAttackingSkills.Controls.Add(this.labelLongShot);
			this.groupAttackingSkills.Controls.Add(this.labelShotPower);
			this.groupAttackingSkills.Controls.Add(this.trackFinishing);
			this.groupAttackingSkills.Controls.Add(this.trackShotPower);
			this.groupAttackingSkills.Controls.Add(this.trackLongShot);
			this.groupAttackingSkills.Controls.Add(this.trackDribbling);
			this.groupAttackingSkills.Location = new global::System.Drawing.Point(721, 3);
			this.groupAttackingSkills.Name = "groupAttackingSkills";
			this.groupAttackingSkills.Size = new global::System.Drawing.Size(140, 378);
			this.groupAttackingSkills.TabIndex = 17;
			this.groupAttackingSkills.TabStop = false;
			this.groupAttackingSkills.Text = "Attacking Skills";
			this.labelFinishing.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelFinishing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelFinishing.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelFinishing.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelFinishing.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelFinishing.Image");
			this.labelFinishing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFinishing.Location = new global::System.Drawing.Point(14, 280);
			this.labelFinishing.Name = "labelFinishing";
			this.labelFinishing.Size = new global::System.Drawing.Size(112, 16);
			this.labelFinishing.TabIndex = 106;
			this.labelFinishing.Text = "Finishing ";
			this.labelFinishing.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(31, 327);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(79, 13);
			this.label6.TabIndex = 121;
			this.label6.Text = "Finishing Styles";
			this.numericUpDown2.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "finishingcode2", true));
			this.numericUpDown2.Location = new global::System.Drawing.Point(74, 348);
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.numericUpDown2;
			int[] array33 = new int[4];
			array33[0] = 127;
			numericUpDown33.Maximum = new decimal(array33);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(58, 20);
			this.numericUpDown2.TabIndex = 120;
			this.numericUpDown2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "finishingcode1", true));
			this.numericUpDown1.Location = new global::System.Drawing.Point(10, 348);
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.numericUpDown1;
			int[] array34 = new int[4];
			array34[0] = 127;
			numericUpDown34.Maximum = new decimal(array34);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(58, 20);
			this.numericUpDown1.TabIndex = 119;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelHeading.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHeading.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelHeading.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelHeading.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelHeading.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelHeading.Image");
			this.labelHeading.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHeading.Location = new global::System.Drawing.Point(14, 230);
			this.labelHeading.Name = "labelHeading";
			this.labelHeading.Size = new global::System.Drawing.Size(112, 16);
			this.labelHeading.TabIndex = 98;
			this.labelHeading.Text = "Heading ";
			this.labelHeading.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackHeading.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackHeading.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackHeading.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "headingaccuracy", true));
			this.trackHeading.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackHeading.LargeChange = 10;
			this.trackHeading.Location = new global::System.Drawing.Point(6, 238);
			this.trackHeading.Maximum = 99;
			this.trackHeading.Minimum = 1;
			this.trackHeading.Name = "trackHeading";
			this.trackHeading.Size = new global::System.Drawing.Size(128, 45);
			this.trackHeading.TabIndex = 7;
			this.trackHeading.TickFrequency = 10;
			this.trackHeading.Value = 1;
			this.trackHeading.ValueChanged += new global::System.EventHandler(this.trackHeading_ValueChanged);
			this.labelVolley.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelVolley.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelVolley.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelVolley.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelVolley.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelVolley.Image");
			this.labelVolley.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelVolley.Location = new global::System.Drawing.Point(14, 182);
			this.labelVolley.Name = "labelVolley";
			this.labelVolley.Size = new global::System.Drawing.Size(112, 16);
			this.labelVolley.TabIndex = 118;
			this.labelVolley.Text = "Volley ";
			this.labelVolley.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackVolley.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackVolley.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackVolley.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "volleys", true));
			this.trackVolley.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackVolley.LargeChange = 10;
			this.trackVolley.Location = new global::System.Drawing.Point(6, 190);
			this.trackVolley.Maximum = 99;
			this.trackVolley.Minimum = 1;
			this.trackVolley.Name = "trackVolley";
			this.trackVolley.Size = new global::System.Drawing.Size(128, 45);
			this.trackVolley.TabIndex = 6;
			this.trackVolley.TickFrequency = 10;
			this.trackVolley.Value = 1;
			this.trackVolley.ValueChanged += new global::System.EventHandler(this.trackVolley_ValueChanged);
			this.numericAttackingSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericAttackingSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericAttackingSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericAttackingSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericAttackingSkills.Location = new global::System.Drawing.Point(43, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.numericAttackingSkills;
			int[] array35 = new int[4];
			array35[0] = 99;
			numericUpDown35.Maximum = new decimal(array35);
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.numericAttackingSkills;
			int[] array36 = new int[4];
			array36[0] = 1;
			numericUpDown36.Minimum = new decimal(array36);
			this.numericAttackingSkills.Name = "numericAttackingSkills";
			this.numericAttackingSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericAttackingSkills.TabIndex = 0;
			this.numericAttackingSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.numericAttackingSkills;
			int[] array37 = new int[4];
			array37[0] = 99;
			numericUpDown37.Value = new decimal(array37);
			this.numericAttackingSkills.ValueChanged += new global::System.EventHandler(this.numericAttackingSkills_ValueChanged);
			this.labelDribbling.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelDribbling.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelDribbling.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelDribbling.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelDribbling.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelDribbling.Image");
			this.labelDribbling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDribbling.Location = new global::System.Drawing.Point(14, 136);
			this.labelDribbling.Name = "labelDribbling";
			this.labelDribbling.Size = new global::System.Drawing.Size(112, 16);
			this.labelDribbling.TabIndex = 82;
			this.labelDribbling.Text = "Dribbling ";
			this.labelDribbling.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLongShot.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLongShot.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelLongShot.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelLongShot.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelLongShot.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelLongShot.Image");
			this.labelLongShot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLongShot.Location = new global::System.Drawing.Point(14, 88);
			this.labelLongShot.Name = "labelLongShot";
			this.labelLongShot.Size = new global::System.Drawing.Size(112, 16);
			this.labelLongShot.TabIndex = 104;
			this.labelLongShot.Text = "Long-Shot ";
			this.labelLongShot.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelShotPower.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelShotPower.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelShotPower.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelShotPower.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelShotPower.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelShotPower.Image");
			this.labelShotPower.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelShotPower.Location = new global::System.Drawing.Point(14, 40);
			this.labelShotPower.Name = "labelShotPower";
			this.labelShotPower.Size = new global::System.Drawing.Size(112, 16);
			this.labelShotPower.TabIndex = 108;
			this.labelShotPower.Text = "Shot-Power ";
			this.labelShotPower.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackFinishing.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackFinishing.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackFinishing.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "finishing", true));
			this.trackFinishing.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackFinishing.LargeChange = 10;
			this.trackFinishing.Location = new global::System.Drawing.Point(6, 288);
			this.trackFinishing.Maximum = 99;
			this.trackFinishing.Minimum = 1;
			this.trackFinishing.Name = "trackFinishing";
			this.trackFinishing.Size = new global::System.Drawing.Size(128, 45);
			this.trackFinishing.TabIndex = 1;
			this.trackFinishing.TickFrequency = 10;
			this.trackFinishing.Value = 1;
			this.trackFinishing.ValueChanged += new global::System.EventHandler(this.trackFinishing_ValueChanged);
			this.trackShotPower.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackShotPower.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackShotPower.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "shotpower", true));
			this.trackShotPower.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackShotPower.LargeChange = 10;
			this.trackShotPower.Location = new global::System.Drawing.Point(6, 48);
			this.trackShotPower.Maximum = 99;
			this.trackShotPower.Minimum = 1;
			this.trackShotPower.Name = "trackShotPower";
			this.trackShotPower.Size = new global::System.Drawing.Size(128, 45);
			this.trackShotPower.TabIndex = 2;
			this.trackShotPower.TickFrequency = 10;
			this.trackShotPower.Value = 1;
			this.trackShotPower.ValueChanged += new global::System.EventHandler(this.trackShotPower_ValueChanged);
			this.trackLongShot.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackLongShot.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackLongShot.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "longshots", true));
			this.trackLongShot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackLongShot.LargeChange = 10;
			this.trackLongShot.Location = new global::System.Drawing.Point(6, 96);
			this.trackLongShot.Maximum = 99;
			this.trackLongShot.Minimum = 1;
			this.trackLongShot.Name = "trackLongShot";
			this.trackLongShot.Size = new global::System.Drawing.Size(128, 45);
			this.trackLongShot.TabIndex = 3;
			this.trackLongShot.TickFrequency = 10;
			this.trackLongShot.Value = 1;
			this.trackLongShot.ValueChanged += new global::System.EventHandler(this.trackLongShot_ValueChanged);
			this.trackDribbling.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackDribbling.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackDribbling.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "dribbling", true));
			this.trackDribbling.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackDribbling.LargeChange = 10;
			this.trackDribbling.Location = new global::System.Drawing.Point(6, 144);
			this.trackDribbling.Maximum = 99;
			this.trackDribbling.Minimum = 1;
			this.trackDribbling.Name = "trackDribbling";
			this.trackDribbling.Size = new global::System.Drawing.Size(128, 45);
			this.trackDribbling.TabIndex = 4;
			this.trackDribbling.TickFrequency = 10;
			this.trackDribbling.Value = 1;
			this.trackDribbling.ValueChanged += new global::System.EventHandler(this.trackDribbling_ValueChanged);
			this.groupGenericAttributes.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupGenericAttributes.Controls.Add(this.label7);
			this.groupGenericAttributes.Controls.Add(this.numericUpDown3);
			this.groupGenericAttributes.Controls.Add(this.numericUpDown4);
			this.groupGenericAttributes.Controls.Add(this.labelJumping);
			this.groupGenericAttributes.Controls.Add(this.labelBalance);
			this.groupGenericAttributes.Controls.Add(this.trackBalance);
			this.groupGenericAttributes.Controls.Add(this.labelAgility);
			this.groupGenericAttributes.Controls.Add(this.trackAgility);
			this.groupGenericAttributes.Controls.Add(this.numericPhysicalSkills);
			this.groupGenericAttributes.Controls.Add(this.labelReactions);
			this.groupGenericAttributes.Controls.Add(this.labelStrength);
			this.groupGenericAttributes.Controls.Add(this.labelStamina);
			this.groupGenericAttributes.Controls.Add(this.trackStamina);
			this.groupGenericAttributes.Controls.Add(this.labelSprintSpeed);
			this.groupGenericAttributes.Controls.Add(this.trackSprintSpeed);
			this.groupGenericAttributes.Controls.Add(this.labelAcceleration);
			this.groupGenericAttributes.Controls.Add(this.trackAcceleration);
			this.groupGenericAttributes.Controls.Add(this.trackStrength);
			this.groupGenericAttributes.Controls.Add(this.trackReactions);
			this.groupGenericAttributes.Controls.Add(this.trackJumping);
			this.groupGenericAttributes.Location = new global::System.Drawing.Point(867, 3);
			this.groupGenericAttributes.Name = "groupGenericAttributes";
			this.groupGenericAttributes.Size = new global::System.Drawing.Size(268, 378);
			this.groupGenericAttributes.TabIndex = 18;
			this.groupGenericAttributes.TabStop = false;
			this.groupGenericAttributes.Text = "Physical Skills";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(30, 327);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(78, 13);
			this.label7.TabIndex = 133;
			this.label7.Text = "Running Styles";
			this.numericUpDown3.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "runningcode2", true));
			this.numericUpDown3.Location = new global::System.Drawing.Point(73, 348);
			global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.numericUpDown3;
			int[] array38 = new int[4];
			array38[0] = 127;
			numericUpDown38.Maximum = new decimal(array38);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new global::System.Drawing.Size(58, 20);
			this.numericUpDown3.TabIndex = 132;
			this.numericUpDown3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown4.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "runningcode1", true));
			this.numericUpDown4.Location = new global::System.Drawing.Point(9, 348);
			global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.numericUpDown4;
			int[] array39 = new int[4];
			array39[0] = 127;
			numericUpDown39.Maximum = new decimal(array39);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new global::System.Drawing.Size(58, 20);
			this.numericUpDown4.TabIndex = 131;
			this.numericUpDown4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelJumping.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelJumping.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelJumping.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelJumping.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelJumping.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelJumping.Image");
			this.labelJumping.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelJumping.Location = new global::System.Drawing.Point(12, 280);
			this.labelJumping.Name = "labelJumping";
			this.labelJumping.Size = new global::System.Drawing.Size(112, 16);
			this.labelJumping.TabIndex = 130;
			this.labelJumping.Text = "Jumping ";
			this.labelJumping.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBalance.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelBalance.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelBalance.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelBalance.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelBalance.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelBalance.Image");
			this.labelBalance.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBalance.Location = new global::System.Drawing.Point(148, 86);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new global::System.Drawing.Size(112, 16);
			this.labelBalance.TabIndex = 128;
			this.labelBalance.Text = "Balance ";
			this.labelBalance.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackBalance.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackBalance.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackBalance.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "balance", true));
			this.trackBalance.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackBalance.LargeChange = 10;
			this.trackBalance.Location = new global::System.Drawing.Point(140, 94);
			this.trackBalance.Maximum = 99;
			this.trackBalance.Minimum = 1;
			this.trackBalance.Name = "trackBalance";
			this.trackBalance.Size = new global::System.Drawing.Size(128, 45);
			this.trackBalance.TabIndex = 8;
			this.trackBalance.TickFrequency = 10;
			this.trackBalance.Value = 1;
			this.trackBalance.ValueChanged += new global::System.EventHandler(this.trackBalance_ValueChanged);
			this.labelAgility.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelAgility.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelAgility.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelAgility.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelAgility.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelAgility.Image");
			this.labelAgility.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAgility.Location = new global::System.Drawing.Point(12, 232);
			this.labelAgility.Name = "labelAgility";
			this.labelAgility.Size = new global::System.Drawing.Size(112, 16);
			this.labelAgility.TabIndex = 126;
			this.labelAgility.Text = "Agility ";
			this.labelAgility.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackAgility.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackAgility.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackAgility.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "agility", true));
			this.trackAgility.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackAgility.LargeChange = 10;
			this.trackAgility.Location = new global::System.Drawing.Point(4, 240);
			this.trackAgility.Maximum = 99;
			this.trackAgility.Minimum = 1;
			this.trackAgility.Name = "trackAgility";
			this.trackAgility.Size = new global::System.Drawing.Size(128, 45);
			this.trackAgility.TabIndex = 5;
			this.trackAgility.TickFrequency = 10;
			this.trackAgility.Value = 1;
			this.trackAgility.ValueChanged += new global::System.EventHandler(this.trackAgility_ValueChanged);
			this.numericPhysicalSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericPhysicalSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericPhysicalSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericPhysicalSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericPhysicalSkills.Location = new global::System.Drawing.Point(114, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown40 = this.numericPhysicalSkills;
			int[] array40 = new int[4];
			array40[0] = 99;
			numericUpDown40.Maximum = new decimal(array40);
			global::System.Windows.Forms.NumericUpDown numericUpDown41 = this.numericPhysicalSkills;
			int[] array41 = new int[4];
			array41[0] = 1;
			numericUpDown41.Minimum = new decimal(array41);
			this.numericPhysicalSkills.Name = "numericPhysicalSkills";
			this.numericPhysicalSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericPhysicalSkills.TabIndex = 0;
			this.numericPhysicalSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown42 = this.numericPhysicalSkills;
			int[] array42 = new int[4];
			array42[0] = 99;
			numericUpDown42.Value = new decimal(array42);
			this.numericPhysicalSkills.ValueChanged += new global::System.EventHandler(this.numericGenericSkills_ValueChanged);
			this.labelReactions.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelReactions.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelReactions.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelReactions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelReactions.Image");
			this.labelReactions.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelReactions.Location = new global::System.Drawing.Point(148, 40);
			this.labelReactions.Name = "labelReactions";
			this.labelReactions.Size = new global::System.Drawing.Size(112, 16);
			this.labelReactions.TabIndex = 82;
			this.labelReactions.Text = "Reactions ";
			this.labelReactions.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelStrength.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelStrength.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelStrength.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelStrength.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelStrength.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelStrength.Image");
			this.labelStrength.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStrength.Location = new global::System.Drawing.Point(12, 184);
			this.labelStrength.Name = "labelStrength";
			this.labelStrength.Size = new global::System.Drawing.Size(112, 16);
			this.labelStrength.TabIndex = 73;
			this.labelStrength.Text = "Strength ";
			this.labelStrength.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelStamina.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelStamina.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelStamina.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelStamina.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelStamina.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelStamina.Image");
			this.labelStamina.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStamina.Location = new global::System.Drawing.Point(12, 134);
			this.labelStamina.Name = "labelStamina";
			this.labelStamina.Size = new global::System.Drawing.Size(112, 16);
			this.labelStamina.TabIndex = 71;
			this.labelStamina.Text = "Stamina ";
			this.labelStamina.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackStamina.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackStamina.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackStamina.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "stamina", true));
			this.trackStamina.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackStamina.LargeChange = 10;
			this.trackStamina.Location = new global::System.Drawing.Point(4, 142);
			this.trackStamina.Maximum = 99;
			this.trackStamina.Minimum = 1;
			this.trackStamina.Name = "trackStamina";
			this.trackStamina.Size = new global::System.Drawing.Size(128, 45);
			this.trackStamina.TabIndex = 3;
			this.trackStamina.TickFrequency = 10;
			this.trackStamina.Value = 1;
			this.trackStamina.ValueChanged += new global::System.EventHandler(this.trackStamina_ValueChanged);
			this.labelSprintSpeed.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelSprintSpeed.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelSprintSpeed.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelSprintSpeed.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelSprintSpeed.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelSprintSpeed.Image");
			this.labelSprintSpeed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSprintSpeed.Location = new global::System.Drawing.Point(12, 88);
			this.labelSprintSpeed.Name = "labelSprintSpeed";
			this.labelSprintSpeed.Size = new global::System.Drawing.Size(112, 16);
			this.labelSprintSpeed.TabIndex = 69;
			this.labelSprintSpeed.Text = "Sprint-Speed ";
			this.labelSprintSpeed.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackSprintSpeed.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackSprintSpeed.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackSprintSpeed.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "sprintspeed", true));
			this.trackSprintSpeed.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackSprintSpeed.LargeChange = 10;
			this.trackSprintSpeed.Location = new global::System.Drawing.Point(4, 96);
			this.trackSprintSpeed.Maximum = 99;
			this.trackSprintSpeed.Minimum = 1;
			this.trackSprintSpeed.Name = "trackSprintSpeed";
			this.trackSprintSpeed.Size = new global::System.Drawing.Size(128, 45);
			this.trackSprintSpeed.TabIndex = 2;
			this.trackSprintSpeed.TickFrequency = 10;
			this.trackSprintSpeed.Value = 1;
			this.trackSprintSpeed.ValueChanged += new global::System.EventHandler(this.trackSprintSpeed_ValueChanged);
			this.labelAcceleration.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelAcceleration.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelAcceleration.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelAcceleration.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelAcceleration.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelAcceleration.Image");
			this.labelAcceleration.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAcceleration.Location = new global::System.Drawing.Point(12, 40);
			this.labelAcceleration.Name = "labelAcceleration";
			this.labelAcceleration.Size = new global::System.Drawing.Size(112, 16);
			this.labelAcceleration.TabIndex = 65;
			this.labelAcceleration.Text = "Acceleration ";
			this.labelAcceleration.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackAcceleration.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackAcceleration.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackAcceleration.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "acceleration", true));
			this.trackAcceleration.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackAcceleration.LargeChange = 10;
			this.trackAcceleration.Location = new global::System.Drawing.Point(4, 48);
			this.trackAcceleration.Maximum = 99;
			this.trackAcceleration.Minimum = 1;
			this.trackAcceleration.Name = "trackAcceleration";
			this.trackAcceleration.Size = new global::System.Drawing.Size(128, 45);
			this.trackAcceleration.TabIndex = 1;
			this.trackAcceleration.TickFrequency = 10;
			this.trackAcceleration.Value = 1;
			this.trackAcceleration.ValueChanged += new global::System.EventHandler(this.trackAcceleration_ValueChanged);
			this.trackStrength.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackStrength.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackStrength.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "strength", true));
			this.trackStrength.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackStrength.LargeChange = 10;
			this.trackStrength.Location = new global::System.Drawing.Point(4, 192);
			this.trackStrength.Maximum = 99;
			this.trackStrength.Minimum = 1;
			this.trackStrength.Name = "trackStrength";
			this.trackStrength.Size = new global::System.Drawing.Size(128, 45);
			this.trackStrength.TabIndex = 4;
			this.trackStrength.TickFrequency = 10;
			this.trackStrength.Value = 1;
			this.trackStrength.ValueChanged += new global::System.EventHandler(this.trackStrength_ValueChanged);
			this.trackReactions.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackReactions.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "reactions", true));
			this.trackReactions.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackReactions.LargeChange = 10;
			this.trackReactions.Location = new global::System.Drawing.Point(139, 48);
			this.trackReactions.Maximum = 99;
			this.trackReactions.Minimum = 1;
			this.trackReactions.Name = "trackReactions";
			this.trackReactions.Size = new global::System.Drawing.Size(128, 45);
			this.trackReactions.TabIndex = 7;
			this.trackReactions.TickFrequency = 10;
			this.trackReactions.Value = 1;
			this.trackReactions.ValueChanged += new global::System.EventHandler(this.trackReactions_ValueChanged);
			this.trackJumping.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackJumping.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackJumping.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "jumping", true));
			this.trackJumping.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackJumping.LargeChange = 10;
			this.trackJumping.Location = new global::System.Drawing.Point(4, 288);
			this.trackJumping.Maximum = 99;
			this.trackJumping.Minimum = 1;
			this.trackJumping.Name = "trackJumping";
			this.trackJumping.Size = new global::System.Drawing.Size(128, 45);
			this.trackJumping.TabIndex = 6;
			this.trackJumping.TickFrequency = 10;
			this.trackJumping.Value = 1;
			this.trackJumping.ValueChanged += new global::System.EventHandler(this.trackJumping_ValueChanged);
			this.groupFreeKick.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupFreeKick.Controls.Add(this.labelSkillsStars);
			this.groupFreeKick.Controls.Add(this.numericSkillMoves);
			this.groupFreeKick.Controls.Add(this.labelSkillMoves);
			this.groupFreeKick.Controls.Add(this.numericFreeKickSkills);
			this.groupFreeKick.Controls.Add(this.labelPenalties);
			this.groupFreeKick.Controls.Add(this.labelFreeKick);
			this.groupFreeKick.Controls.Add(this.trackFreeKick);
			this.groupFreeKick.Controls.Add(this.trackPenalties);
			this.groupFreeKick.Controls.Add(this.labelPenaltyKick);
			this.groupFreeKick.Controls.Add(this.comboPenaltyKick);
			this.groupFreeKick.Controls.Add(this.labelPenaltyMove);
			this.groupFreeKick.Controls.Add(this.comboPenaltyMove);
			this.groupFreeKick.Controls.Add(this.labelFreeKickStart);
			this.groupFreeKick.Controls.Add(this.labelPenaltyStart);
			this.groupFreeKick.Controls.Add(this.comboFreeKickStart);
			this.groupFreeKick.Controls.Add(this.comboPenaltyStart);
			this.groupFreeKick.Location = new global::System.Drawing.Point(3, 387);
			this.groupFreeKick.Name = "groupFreeKick";
			this.groupFreeKick.Size = new global::System.Drawing.Size(250, 309);
			this.groupFreeKick.TabIndex = 28;
			this.groupFreeKick.TabStop = false;
			this.groupFreeKick.Text = "Free Kick Skills";
			this.labelSkillsStars.ImageList = this.imageListStars;
			this.labelSkillsStars.Location = new global::System.Drawing.Point(118, 148);
			this.labelSkillsStars.Name = "labelSkillsStars";
			this.labelSkillsStars.Size = new global::System.Drawing.Size(117, 23);
			this.labelSkillsStars.TabIndex = 156;
			this.imageListStars.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListStars.ImageStream");
			this.imageListStars.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageListStars.Images.SetKeyName(0, "Stars_1.PNG");
			this.imageListStars.Images.SetKeyName(1, "Stars_2.PNG");
			this.imageListStars.Images.SetKeyName(2, "Stars_3.PNG");
			this.imageListStars.Images.SetKeyName(3, "Stars_4.PNG");
			this.imageListStars.Images.SetKeyName(4, "Stars_5.PNG");
			this.numericSkillMoves.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "skillmoves", true));
			this.numericSkillMoves.Location = new global::System.Drawing.Point(69, 151);
			global::System.Windows.Forms.NumericUpDown numericUpDown43 = this.numericSkillMoves;
			int[] array43 = new int[4];
			array43[0] = 5;
			numericUpDown43.Maximum = new decimal(array43);
			global::System.Windows.Forms.NumericUpDown numericUpDown44 = this.numericSkillMoves;
			int[] array44 = new int[4];
			array44[0] = 1;
			numericUpDown44.Minimum = new decimal(array44);
			this.numericSkillMoves.Name = "numericSkillMoves";
			this.numericSkillMoves.Size = new global::System.Drawing.Size(43, 20);
			this.numericSkillMoves.TabIndex = 3;
			this.numericSkillMoves.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown45 = this.numericSkillMoves;
			int[] array45 = new int[4];
			array45[0] = 1;
			numericUpDown45.Value = new decimal(array45);
			this.numericSkillMoves.ValueChanged += new global::System.EventHandler(this.numericSkillMoves_ValueChanged);
			this.labelSkillMoves.AutoSize = true;
			this.labelSkillMoves.Location = new global::System.Drawing.Point(8, 153);
			this.labelSkillMoves.Name = "labelSkillMoves";
			this.labelSkillMoves.Size = new global::System.Drawing.Size(61, 13);
			this.labelSkillMoves.TabIndex = 154;
			this.labelSkillMoves.Text = "Skill Moves";
			this.numericFreeKickSkills.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.numericFreeKickSkills.BackColor = global::System.Drawing.Color.Teal;
			this.numericFreeKickSkills.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.numericFreeKickSkills.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.numericFreeKickSkills.Location = new global::System.Drawing.Point(50, 15);
			global::System.Windows.Forms.NumericUpDown numericUpDown46 = this.numericFreeKickSkills;
			int[] array46 = new int[4];
			array46[0] = 99;
			numericUpDown46.Maximum = new decimal(array46);
			global::System.Windows.Forms.NumericUpDown numericUpDown47 = this.numericFreeKickSkills;
			int[] array47 = new int[4];
			array47[0] = 1;
			numericUpDown47.Minimum = new decimal(array47);
			this.numericFreeKickSkills.Name = "numericFreeKickSkills";
			this.numericFreeKickSkills.Size = new global::System.Drawing.Size(44, 22);
			this.numericFreeKickSkills.TabIndex = 0;
			this.numericFreeKickSkills.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown48 = this.numericFreeKickSkills;
			int[] array48 = new int[4];
			array48[0] = 99;
			numericUpDown48.Value = new decimal(array48);
			this.numericFreeKickSkills.ValueChanged += new global::System.EventHandler(this.numericFreeKickSkills_ValueChanged);
			this.labelPenalties.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelPenalties.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelPenalties.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelPenalties.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelPenalties.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelPenalties.Image");
			this.labelPenalties.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenalties.Location = new global::System.Drawing.Point(16, 88);
			this.labelPenalties.Name = "labelPenalties";
			this.labelPenalties.Size = new global::System.Drawing.Size(112, 16);
			this.labelPenalties.TabIndex = 116;
			this.labelPenalties.Text = "Penalties ";
			this.labelPenalties.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFreeKick.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelFreeKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.labelFreeKick.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelFreeKick.ForeColor = global::System.Drawing.Color.Yellow;
			this.labelFreeKick.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("labelFreeKick.Image");
			this.labelFreeKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFreeKick.Location = new global::System.Drawing.Point(16, 40);
			this.labelFreeKick.Name = "labelFreeKick";
			this.labelFreeKick.Size = new global::System.Drawing.Size(112, 16);
			this.labelFreeKick.TabIndex = 112;
			this.labelFreeKick.Text = "Free-Kick ";
			this.labelFreeKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.trackFreeKick.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackFreeKick.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackFreeKick.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "freekickaccuracy", true));
			this.trackFreeKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackFreeKick.LargeChange = 10;
			this.trackFreeKick.Location = new global::System.Drawing.Point(8, 48);
			this.trackFreeKick.Maximum = 99;
			this.trackFreeKick.Minimum = 1;
			this.trackFreeKick.Name = "trackFreeKick";
			this.trackFreeKick.Size = new global::System.Drawing.Size(128, 45);
			this.trackFreeKick.TabIndex = 1;
			this.trackFreeKick.TickFrequency = 10;
			this.trackFreeKick.Value = 1;
			this.trackFreeKick.ValueChanged += new global::System.EventHandler(this.trackFreeKick_ValueChanged);
			this.trackPenalties.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackPenalties.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.trackPenalties.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.playerBindingSource, "penalties", true));
			this.trackPenalties.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.trackPenalties.LargeChange = 10;
			this.trackPenalties.Location = new global::System.Drawing.Point(8, 96);
			this.trackPenalties.Maximum = 99;
			this.trackPenalties.Minimum = 1;
			this.trackPenalties.Name = "trackPenalties";
			this.trackPenalties.Size = new global::System.Drawing.Size(128, 45);
			this.trackPenalties.TabIndex = 2;
			this.trackPenalties.TickFrequency = 10;
			this.trackPenalties.Value = 1;
			this.trackPenalties.ValueChanged += new global::System.EventHandler(this.trackPenalties_ValueChanged);
			this.labelPenaltyKick.AutoSize = true;
			this.labelPenaltyKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenaltyKick.Location = new global::System.Drawing.Point(6, 259);
			this.labelPenaltyKick.Name = "labelPenaltyKick";
			this.labelPenaltyKick.Size = new global::System.Drawing.Size(66, 13);
			this.labelPenaltyKick.TabIndex = 153;
			this.labelPenaltyKick.Text = "Penalty Kick";
			this.labelPenaltyKick.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboPenaltyKick.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "animpenaltieskickstylecode", true));
			this.comboPenaltyKick.FormattingEnabled = true;
			this.comboPenaltyKick.Items.AddRange(new object[] { "Normal", "Finesse Shot", "Powerful Shot" });
			this.comboPenaltyKick.Location = new global::System.Drawing.Point(89, 253);
			this.comboPenaltyKick.Name = "comboPenaltyKick";
			this.comboPenaltyKick.Size = new global::System.Drawing.Size(139, 21);
			this.comboPenaltyKick.TabIndex = 7;
			this.labelPenaltyMove.AutoSize = true;
			this.labelPenaltyMove.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenaltyMove.Location = new global::System.Drawing.Point(6, 235);
			this.labelPenaltyMove.Name = "labelPenaltyMove";
			this.labelPenaltyMove.Size = new global::System.Drawing.Size(72, 13);
			this.labelPenaltyMove.TabIndex = 151;
			this.labelPenaltyMove.Text = "Penalty Move";
			this.labelPenaltyMove.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboPenaltyMove.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "animpenaltiesmotionstylecode", true));
			this.comboPenaltyMove.FormattingEnabled = true;
			this.comboPenaltyMove.Items.AddRange(new object[] { "Continuous Motion", "Start/Stop Motion", "Henry's style", "Unknown style", "Lampard's style", "Podolski's style", "Ronaldinho's style" });
			this.comboPenaltyMove.Location = new global::System.Drawing.Point(89, 229);
			this.comboPenaltyMove.Name = "comboPenaltyMove";
			this.comboPenaltyMove.Size = new global::System.Drawing.Size(139, 21);
			this.comboPenaltyMove.TabIndex = 6;
			this.labelFreeKickStart.AutoSize = true;
			this.labelFreeKickStart.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFreeKickStart.Location = new global::System.Drawing.Point(6, 189);
			this.labelFreeKickStart.Name = "labelFreeKickStart";
			this.labelFreeKickStart.Size = new global::System.Drawing.Size(77, 13);
			this.labelFreeKickStart.TabIndex = 147;
			this.labelFreeKickStart.Text = "Free Kick Start";
			this.labelFreeKickStart.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPenaltyStart.AutoSize = true;
			this.labelPenaltyStart.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPenaltyStart.Location = new global::System.Drawing.Point(6, 212);
			this.labelPenaltyStart.Name = "labelPenaltyStart";
			this.labelPenaltyStart.Size = new global::System.Drawing.Size(67, 13);
			this.labelPenaltyStart.TabIndex = 149;
			this.labelPenaltyStart.Text = "Penalty Start";
			this.labelPenaltyStart.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboFreeKickStart.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "animfreekickstartposcode", true));
			this.comboFreeKickStart.FormattingEnabled = true;
			this.comboFreeKickStart.Items.AddRange(new object[] { "Normal", "Long run-up", "90 degrees from ball", "Henry's style", "Beckham's style", "Lampard's style", "Adriano's style", "Cristiano Ronaldo's style", "Juninho's style", "Ronaldinho's style" });
			this.comboFreeKickStart.Location = new global::System.Drawing.Point(89, 183);
			this.comboFreeKickStart.Name = "comboFreeKickStart";
			this.comboFreeKickStart.Size = new global::System.Drawing.Size(139, 21);
			this.comboFreeKickStart.TabIndex = 4;
			this.comboPenaltyStart.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.playerBindingSource, "animpenaltiesstartposcode", true));
			this.comboPenaltyStart.FormattingEnabled = true;
			this.comboPenaltyStart.Items.AddRange(new object[] { "Edge of the penalty box", "Close to the ball", "Outside the penalty box", "Henry's style", "Unknown style", "Lampard's style", "Podolski's style", "Ronaldinho's style", "Cristiano Ronaldo's style" });
			this.comboPenaltyStart.Location = new global::System.Drawing.Point(89, 206);
			this.comboPenaltyStart.Name = "comboPenaltyStart";
			this.comboPenaltyStart.Size = new global::System.Drawing.Size(139, 21);
			this.comboPenaltyStart.TabIndex = 5;
			this.groupTraits.Controls.Add(this.groupBox2);
			this.groupTraits.Controls.Add(this.checkGKOneonOne);
			this.groupTraits.Controls.Add(this.checkAcrobaticClearance);
			this.groupTraits.Controls.Add(this.checkSecondWind);
			this.groupTraits.Controls.Add(this.checkCrowdFavourite);
			this.groupTraits.Controls.Add(this.checkInflexible);
			this.groupTraits.Controls.Add(this.checkTeamPlayer);
			this.groupTraits.Controls.Add(this.checkSwervePasser);
			this.groupTraits.Controls.Add(this.checkCornerSpecialist);
			this.groupTraits.Controls.Add(this.checkPowerHeader);
			this.groupTraits.Controls.Add(this.checkGkLongThrower);
			this.groupTraits.Controls.Add(this.checkLongPasser);
			this.groupTraits.Controls.Add(this.checkFlair);
			this.groupTraits.Controls.Add(this.checkFinesseShot);
			this.groupTraits.Controls.Add(this.checkArguesWithOfficials);
			this.groupTraits.Controls.Add(this.checkBeatsOffsideTrap);
			this.groupTraits.Controls.Add(this.checkAvoidsWeakFoot);
			this.groupTraits.Controls.Add(this.checkInjuryFree);
			this.groupTraits.Controls.Add(this.checkPowerFreeKick);
			this.groupTraits.Controls.Add(this.checkSelfish);
			this.groupTraits.Controls.Add(this.checkPlaymaker);
			this.groupTraits.Controls.Add(this.checkTechnicaldribbler);
			this.groupTraits.Controls.Add(this.checkLeadership);
			this.groupTraits.Controls.Add(this.checkPuncher);
			this.groupTraits.Controls.Add(this.checkDiver);
			this.groupTraits.Controls.Add(this.checkDivesintotackles);
			this.groupTraits.Controls.Add(this.checkLongshottaker);
			this.groupTraits.Controls.Add(this.checkHighClubIdentification);
			this.groupTraits.Controls.Add(this.checkPushesupforcorners);
			this.groupTraits.Controls.Add(this.checkEarlycrosser);
			this.groupTraits.Controls.Add(this.checkInjuryProne);
			this.groupTraits.Controls.Add(this.checkGiantThrower);
			this.groupTraits.Controls.Add(this.checkLongThrower);
			this.groupTraits.Location = new global::System.Drawing.Point(259, 387);
			this.groupTraits.Name = "groupTraits";
			this.groupTraits.Size = new global::System.Drawing.Size(619, 309);
			this.groupTraits.TabIndex = 30;
			this.groupTraits.TabStop = false;
			this.groupTraits.Text = "Traits";
			this.groupBox2.Controls.Add(this.checkGKFlatKick);
			this.groupBox2.Controls.Add(this.checkDrivenPass);
			this.groupBox2.Controls.Add(this.checkDivingHeader);
			this.groupBox2.Controls.Add(this.checkBycicleKick);
			this.groupBox2.Controls.Add(this.checkChipperPenalty);
			this.groupBox2.Controls.Add(this.checkStutterPenalty);
			this.groupBox2.Controls.Add(this.checkFancyFlicks);
			this.groupBox2.Controls.Add(this.checkFancyPasses);
			this.groupBox2.Controls.Add(this.checkFancyFeet);
			this.groupBox2.Location = new global::System.Drawing.Point(472, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(130, 284);
			this.groupBox2.TabIndex = 57;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Virtual Pro";
			this.checkGKFlatKick.AutoSize = true;
			this.checkGKFlatKick.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGKFlatKick.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "GkFlatKick", true));
			this.checkGKFlatKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkGKFlatKick.Location = new global::System.Drawing.Point(16, 216);
			this.checkGKFlatKick.Name = "checkGKFlatKick";
			this.checkGKFlatKick.Size = new global::System.Drawing.Size(85, 17);
			this.checkGKFlatKick.TabIndex = 51;
			this.checkGKFlatKick.Text = "GK Flat Kick";
			this.checkGKFlatKick.UseVisualStyleBackColor = false;
			this.checkDrivenPass.AutoSize = true;
			this.checkDrivenPass.BackColor = global::System.Drawing.Color.Transparent;
			this.checkDrivenPass.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "DrivenPass", true));
			this.checkDrivenPass.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkDrivenPass.Location = new global::System.Drawing.Point(16, 194);
			this.checkDrivenPass.Name = "checkDrivenPass";
			this.checkDrivenPass.Size = new global::System.Drawing.Size(83, 17);
			this.checkDrivenPass.TabIndex = 50;
			this.checkDrivenPass.Text = "Driven Pass";
			this.checkDrivenPass.UseVisualStyleBackColor = false;
			this.checkDivingHeader.AutoSize = true;
			this.checkDivingHeader.BackColor = global::System.Drawing.Color.Transparent;
			this.checkDivingHeader.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "DivingHeader", true));
			this.checkDivingHeader.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkDivingHeader.Location = new global::System.Drawing.Point(16, 172);
			this.checkDivingHeader.Name = "checkDivingHeader";
			this.checkDivingHeader.Size = new global::System.Drawing.Size(94, 17);
			this.checkDivingHeader.TabIndex = 49;
			this.checkDivingHeader.Text = "Diving Header";
			this.checkDivingHeader.UseVisualStyleBackColor = false;
			this.checkBycicleKick.AutoSize = true;
			this.checkBycicleKick.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBycicleKick.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "BycicleKick", true));
			this.checkBycicleKick.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkBycicleKick.Location = new global::System.Drawing.Point(16, 150);
			this.checkBycicleKick.Name = "checkBycicleKick";
			this.checkBycicleKick.Size = new global::System.Drawing.Size(84, 17);
			this.checkBycicleKick.TabIndex = 48;
			this.checkBycicleKick.Text = "Bycicle Kick";
			this.checkBycicleKick.UseVisualStyleBackColor = false;
			this.checkChipperPenalty.AutoSize = true;
			this.checkChipperPenalty.BackColor = global::System.Drawing.Color.Transparent;
			this.checkChipperPenalty.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "ChipperPenalty", true));
			this.checkChipperPenalty.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkChipperPenalty.Location = new global::System.Drawing.Point(16, 128);
			this.checkChipperPenalty.Name = "checkChipperPenalty";
			this.checkChipperPenalty.Size = new global::System.Drawing.Size(100, 17);
			this.checkChipperPenalty.TabIndex = 47;
			this.checkChipperPenalty.Text = "Chipper Penalty";
			this.checkChipperPenalty.UseVisualStyleBackColor = false;
			this.checkStutterPenalty.AutoSize = true;
			this.checkStutterPenalty.BackColor = global::System.Drawing.Color.Transparent;
			this.checkStutterPenalty.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "StutterPenalty", true));
			this.checkStutterPenalty.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStutterPenalty.Location = new global::System.Drawing.Point(16, 106);
			this.checkStutterPenalty.Name = "checkStutterPenalty";
			this.checkStutterPenalty.Size = new global::System.Drawing.Size(95, 17);
			this.checkStutterPenalty.TabIndex = 46;
			this.checkStutterPenalty.Text = "Stutter Penalty";
			this.checkStutterPenalty.UseVisualStyleBackColor = false;
			this.checkFancyFlicks.AutoSize = true;
			this.checkFancyFlicks.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFancyFlicks.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "FancyFlicks", true));
			this.checkFancyFlicks.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkFancyFlicks.Location = new global::System.Drawing.Point(16, 84);
			this.checkFancyFlicks.Name = "checkFancyFlicks";
			this.checkFancyFlicks.Size = new global::System.Drawing.Size(85, 17);
			this.checkFancyFlicks.TabIndex = 45;
			this.checkFancyFlicks.Text = "Fancy Flicks";
			this.checkFancyFlicks.UseVisualStyleBackColor = false;
			this.checkFancyPasses.AutoSize = true;
			this.checkFancyPasses.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFancyPasses.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "FancyPasses", true));
			this.checkFancyPasses.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkFancyPasses.Location = new global::System.Drawing.Point(16, 62);
			this.checkFancyPasses.Name = "checkFancyPasses";
			this.checkFancyPasses.Size = new global::System.Drawing.Size(92, 17);
			this.checkFancyPasses.TabIndex = 44;
			this.checkFancyPasses.Text = "Fancy Passes";
			this.checkFancyPasses.UseVisualStyleBackColor = false;
			this.checkFancyFeet.AutoSize = true;
			this.checkFancyFeet.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFancyFeet.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "FancyFeet", true));
			this.checkFancyFeet.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkFancyFeet.Location = new global::System.Drawing.Point(16, 40);
			this.checkFancyFeet.Name = "checkFancyFeet";
			this.checkFancyFeet.Size = new global::System.Drawing.Size(79, 17);
			this.checkFancyFeet.TabIndex = 43;
			this.checkFancyFeet.Text = "Fancy Feet";
			this.checkFancyFeet.UseVisualStyleBackColor = false;
			this.checkGKOneonOne.AutoSize = true;
			this.checkGKOneonOne.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGKOneonOne.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "GkOneOnOne", true));
			this.checkGKOneonOne.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkGKOneonOne.Location = new global::System.Drawing.Point(24, 213);
			this.checkGKOneonOne.Name = "checkGKOneonOne";
			this.checkGKOneonOne.Size = new global::System.Drawing.Size(102, 17);
			this.checkGKOneonOne.TabIndex = 56;
			this.checkGKOneonOne.Text = "GK One on One";
			this.checkGKOneonOne.UseVisualStyleBackColor = false;
			this.checkAcrobaticClearance.AutoSize = true;
			this.checkAcrobaticClearance.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAcrobaticClearance.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "AcrobaticClearance", true));
			this.checkAcrobaticClearance.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkAcrobaticClearance.Location = new global::System.Drawing.Point(24, 235);
			this.checkAcrobaticClearance.Name = "checkAcrobaticClearance";
			this.checkAcrobaticClearance.Size = new global::System.Drawing.Size(122, 17);
			this.checkAcrobaticClearance.TabIndex = 55;
			this.checkAcrobaticClearance.Text = "Acrobatic Clearance";
			this.checkAcrobaticClearance.UseVisualStyleBackColor = false;
			this.checkSecondWind.AutoSize = true;
			this.checkSecondWind.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSecondWind.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "SecondWind", true));
			this.checkSecondWind.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkSecondWind.Location = new global::System.Drawing.Point(24, 81);
			this.checkSecondWind.Name = "checkSecondWind";
			this.checkSecondWind.Size = new global::System.Drawing.Size(91, 17);
			this.checkSecondWind.TabIndex = 54;
			this.checkSecondWind.Text = "Second Wind";
			this.checkSecondWind.UseVisualStyleBackColor = false;
			this.checkCrowdFavourite.AutoSize = true;
			this.checkCrowdFavourite.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCrowdFavourite.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "CrowdFavorite", true));
			this.checkCrowdFavourite.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCrowdFavourite.Location = new global::System.Drawing.Point(334, 213);
			this.checkCrowdFavourite.Name = "checkCrowdFavourite";
			this.checkCrowdFavourite.Size = new global::System.Drawing.Size(103, 17);
			this.checkCrowdFavourite.TabIndex = 53;
			this.checkCrowdFavourite.Text = "Crowd Favourite";
			this.checkCrowdFavourite.UseVisualStyleBackColor = false;
			this.checkInflexible.AutoSize = true;
			this.checkInflexible.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInflexible.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Inflexible", true));
			this.checkInflexible.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkInflexible.Location = new global::System.Drawing.Point(334, 191);
			this.checkInflexible.Name = "checkInflexible";
			this.checkInflexible.Size = new global::System.Drawing.Size(67, 17);
			this.checkInflexible.TabIndex = 52;
			this.checkInflexible.Text = "Inflexible";
			this.checkInflexible.UseVisualStyleBackColor = false;
			this.checkTeamPlayer.AutoSize = true;
			this.checkTeamPlayer.BackColor = global::System.Drawing.Color.Transparent;
			this.checkTeamPlayer.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "TeamPlayer", true));
			this.checkTeamPlayer.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamPlayer.Location = new global::System.Drawing.Point(334, 169);
			this.checkTeamPlayer.Name = "checkTeamPlayer";
			this.checkTeamPlayer.Size = new global::System.Drawing.Size(85, 17);
			this.checkTeamPlayer.TabIndex = 51;
			this.checkTeamPlayer.Text = "Team Player";
			this.checkTeamPlayer.UseVisualStyleBackColor = false;
			this.checkSwervePasser.AutoSize = true;
			this.checkSwervePasser.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "SwervePasser", true));
			this.checkSwervePasser.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkSwervePasser.Location = new global::System.Drawing.Point(170, 125);
			this.checkSwervePasser.Name = "checkSwervePasser";
			this.checkSwervePasser.Size = new global::System.Drawing.Size(97, 17);
			this.checkSwervePasser.TabIndex = 50;
			this.checkSwervePasser.Text = "Swerve Passer";
			this.checkSwervePasser.UseVisualStyleBackColor = false;
			this.checkCornerSpecialist.AutoSize = true;
			this.checkCornerSpecialist.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "OutsideFootShot", true));
			this.checkCornerSpecialist.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCornerSpecialist.Location = new global::System.Drawing.Point(170, 258);
			this.checkCornerSpecialist.Name = "checkCornerSpecialist";
			this.checkCornerSpecialist.Size = new global::System.Drawing.Size(111, 17);
			this.checkCornerSpecialist.TabIndex = 49;
			this.checkCornerSpecialist.Text = "Outside Foot Shot";
			this.checkCornerSpecialist.UseVisualStyleBackColor = false;
			this.checkPowerHeader.AutoSize = true;
			this.checkPowerHeader.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "PowerHeader", true));
			this.checkPowerHeader.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPowerHeader.Location = new global::System.Drawing.Point(170, 192);
			this.checkPowerHeader.Name = "checkPowerHeader";
			this.checkPowerHeader.Size = new global::System.Drawing.Size(94, 17);
			this.checkPowerHeader.TabIndex = 48;
			this.checkPowerHeader.Text = "Power Header";
			this.checkPowerHeader.UseVisualStyleBackColor = false;
			this.checkGkLongThrower.AutoSize = true;
			this.checkGkLongThrower.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "GkLongThrower", true));
			this.checkGkLongThrower.Location = new global::System.Drawing.Point(24, 191);
			this.checkGkLongThrower.Name = "checkGkLongThrower";
			this.checkGkLongThrower.Size = new global::System.Drawing.Size(110, 17);
			this.checkGkLongThrower.TabIndex = 47;
			this.checkGkLongThrower.Text = "GK Long Thrower";
			this.checkGkLongThrower.UseVisualStyleBackColor = true;
			this.checkLongPasser.AutoSize = true;
			this.checkLongPasser.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "LongPasser", true));
			this.checkLongPasser.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLongPasser.Location = new global::System.Drawing.Point(170, 103);
			this.checkLongPasser.Name = "checkLongPasser";
			this.checkLongPasser.Size = new global::System.Drawing.Size(85, 17);
			this.checkLongPasser.TabIndex = 46;
			this.checkLongPasser.Text = "Long Passer";
			this.checkLongPasser.UseVisualStyleBackColor = false;
			this.checkFlair.AutoSize = true;
			this.checkFlair.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Flair", true));
			this.checkFlair.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkFlair.Location = new global::System.Drawing.Point(170, 147);
			this.checkFlair.Name = "checkFlair";
			this.checkFlair.Size = new global::System.Drawing.Size(45, 17);
			this.checkFlair.TabIndex = 45;
			this.checkFlair.Text = "Flair";
			this.checkFlair.UseVisualStyleBackColor = false;
			this.checkFinesseShot.AutoSize = true;
			this.checkFinesseShot.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "FinesseShot", true));
			this.checkFinesseShot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkFinesseShot.Location = new global::System.Drawing.Point(170, 236);
			this.checkFinesseShot.Name = "checkFinesseShot";
			this.checkFinesseShot.Size = new global::System.Drawing.Size(87, 17);
			this.checkFinesseShot.TabIndex = 44;
			this.checkFinesseShot.Text = "Finesse Shot";
			this.checkFinesseShot.UseVisualStyleBackColor = false;
			this.checkArguesWithOfficials.AutoSize = true;
			this.checkArguesWithOfficials.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "ArguesWithOfficials", true));
			this.checkArguesWithOfficials.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkArguesWithOfficials.Location = new global::System.Drawing.Point(334, 125);
			this.checkArguesWithOfficials.Name = "checkArguesWithOfficials";
			this.checkArguesWithOfficials.Size = new global::System.Drawing.Size(121, 17);
			this.checkArguesWithOfficials.TabIndex = 43;
			this.checkArguesWithOfficials.Text = "Argues with Officials";
			this.checkArguesWithOfficials.UseVisualStyleBackColor = false;
			this.checkBeatsOffsideTrap.AutoSize = true;
			this.checkBeatsOffsideTrap.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBeatsOffsideTrap.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "BeatDefensiveLine", true));
			this.checkBeatsOffsideTrap.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkBeatsOffsideTrap.Location = new global::System.Drawing.Point(334, 59);
			this.checkBeatsOffsideTrap.Name = "checkBeatsOffsideTrap";
			this.checkBeatsOffsideTrap.Size = new global::System.Drawing.Size(114, 17);
			this.checkBeatsOffsideTrap.TabIndex = 42;
			this.checkBeatsOffsideTrap.Text = "Beats Offside Trap";
			this.checkBeatsOffsideTrap.UseVisualStyleBackColor = false;
			this.checkAvoidsWeakFoot.AutoSize = true;
			this.checkAvoidsWeakFoot.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAvoidsWeakFoot.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "AvoidsWeakFoot", true));
			this.checkAvoidsWeakFoot.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkAvoidsWeakFoot.Location = new global::System.Drawing.Point(170, 37);
			this.checkAvoidsWeakFoot.Name = "checkAvoidsWeakFoot";
			this.checkAvoidsWeakFoot.Size = new global::System.Drawing.Size(144, 17);
			this.checkAvoidsWeakFoot.TabIndex = 41;
			this.checkAvoidsWeakFoot.Text = "Avoids Using Weak Foot";
			this.checkAvoidsWeakFoot.UseVisualStyleBackColor = false;
			this.checkInjuryFree.AutoSize = true;
			this.checkInjuryFree.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInjuryFree.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "InjuryFree", true));
			this.checkInjuryFree.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkInjuryFree.Location = new global::System.Drawing.Point(24, 59);
			this.checkInjuryFree.Name = "checkInjuryFree";
			this.checkInjuryFree.Size = new global::System.Drawing.Size(75, 17);
			this.checkInjuryFree.TabIndex = 40;
			this.checkInjuryFree.Text = "Injury Free";
			this.checkInjuryFree.UseVisualStyleBackColor = false;
			this.checkPowerFreeKick.AutoSize = true;
			this.checkPowerFreeKick.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "PowerfulFreeKicks", true));
			this.checkPowerFreeKick.Location = new global::System.Drawing.Point(334, 37);
			this.checkPowerFreeKick.Name = "checkPowerFreeKick";
			this.checkPowerFreeKick.Size = new global::System.Drawing.Size(104, 17);
			this.checkPowerFreeKick.TabIndex = 39;
			this.checkPowerFreeKick.Text = "Power Free Kick";
			this.checkPowerFreeKick.UseVisualStyleBackColor = true;
			this.checkSelfish.AutoSize = true;
			this.checkSelfish.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Selfish", true));
			this.checkSelfish.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkSelfish.Location = new global::System.Drawing.Point(334, 81);
			this.checkSelfish.Name = "checkSelfish";
			this.checkSelfish.Size = new global::System.Drawing.Size(57, 17);
			this.checkSelfish.TabIndex = 37;
			this.checkSelfish.Text = "Selfish";
			this.checkSelfish.UseVisualStyleBackColor = false;
			this.checkPlaymaker.AutoSize = true;
			this.checkPlaymaker.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Playmaker", true));
			this.checkPlaymaker.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlaymaker.Location = new global::System.Drawing.Point(170, 59);
			this.checkPlaymaker.Name = "checkPlaymaker";
			this.checkPlaymaker.Size = new global::System.Drawing.Size(75, 17);
			this.checkPlaymaker.TabIndex = 33;
			this.checkPlaymaker.Text = "Playmaker";
			this.checkPlaymaker.UseVisualStyleBackColor = false;
			this.checkTechnicaldribbler.AutoSize = true;
			this.checkTechnicaldribbler.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Technicaldribbler", true));
			this.checkTechnicaldribbler.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTechnicaldribbler.Location = new global::System.Drawing.Point(170, 169);
			this.checkTechnicaldribbler.Name = "checkTechnicaldribbler";
			this.checkTechnicaldribbler.Size = new global::System.Drawing.Size(112, 17);
			this.checkTechnicaldribbler.TabIndex = 38;
			this.checkTechnicaldribbler.Text = "Technical Dribbler";
			this.checkTechnicaldribbler.UseVisualStyleBackColor = false;
			this.checkLeadership.AutoSize = true;
			this.checkLeadership.BackColor = global::System.Drawing.Color.Transparent;
			this.checkLeadership.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Leadership", true));
			this.checkLeadership.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeadership.Location = new global::System.Drawing.Point(334, 235);
			this.checkLeadership.Name = "checkLeadership";
			this.checkLeadership.Size = new global::System.Drawing.Size(78, 17);
			this.checkLeadership.TabIndex = 36;
			this.checkLeadership.Text = "Leadership";
			this.checkLeadership.UseVisualStyleBackColor = false;
			this.checkPuncher.AutoSize = true;
			this.checkPuncher.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Puncher", true));
			this.checkPuncher.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPuncher.Location = new global::System.Drawing.Point(24, 169);
			this.checkPuncher.Name = "checkPuncher";
			this.checkPuncher.Size = new global::System.Drawing.Size(84, 17);
			this.checkPuncher.TabIndex = 34;
			this.checkPuncher.Text = "GK Puncher";
			this.checkPuncher.UseVisualStyleBackColor = false;
			this.checkDiver.AutoSize = true;
			this.checkDiver.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Diver", true));
			this.checkDiver.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkDiver.Location = new global::System.Drawing.Point(334, 103);
			this.checkDiver.Name = "checkDiver";
			this.checkDiver.Size = new global::System.Drawing.Size(51, 17);
			this.checkDiver.TabIndex = 27;
			this.checkDiver.Text = "Diver";
			this.checkDiver.UseVisualStyleBackColor = false;
			this.checkDivesintotackles.AutoSize = true;
			this.checkDivesintotackles.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Divesintotackles", true));
			this.checkDivesintotackles.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkDivesintotackles.Location = new global::System.Drawing.Point(24, 257);
			this.checkDivesintotackles.Name = "checkDivesintotackles";
			this.checkDivesintotackles.Size = new global::System.Drawing.Size(114, 17);
			this.checkDivesintotackles.TabIndex = 28;
			this.checkDivesintotackles.Text = "Dives into Tackles";
			this.checkDivesintotackles.UseVisualStyleBackColor = false;
			this.checkLongshottaker.AutoSize = true;
			this.checkLongshottaker.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "LongShotTaker", true));
			this.checkLongshottaker.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLongshottaker.Location = new global::System.Drawing.Point(170, 214);
			this.checkLongshottaker.Name = "checkLongshottaker";
			this.checkLongshottaker.Size = new global::System.Drawing.Size(106, 17);
			this.checkLongshottaker.TabIndex = 30;
			this.checkLongshottaker.Text = "Long Shot Taker";
			this.checkLongshottaker.UseVisualStyleBackColor = false;
			this.checkHighClubIdentification.AutoSize = true;
			this.checkHighClubIdentification.BackColor = global::System.Drawing.Color.Transparent;
			this.checkHighClubIdentification.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "HighClubIdentification", true));
			this.checkHighClubIdentification.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkHighClubIdentification.Location = new global::System.Drawing.Point(334, 147);
			this.checkHighClubIdentification.Name = "checkHighClubIdentification";
			this.checkHighClubIdentification.Size = new global::System.Drawing.Size(107, 17);
			this.checkHighClubIdentification.TabIndex = 31;
			this.checkHighClubIdentification.Text = "High Club Identif.";
			this.checkHighClubIdentification.UseVisualStyleBackColor = false;
			this.checkPushesupforcorners.AutoSize = true;
			this.checkPushesupforcorners.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Pushesupforcorners", true));
			this.checkPushesupforcorners.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPushesupforcorners.Location = new global::System.Drawing.Point(24, 147);
			this.checkPushesupforcorners.Name = "checkPushesupforcorners";
			this.checkPushesupforcorners.Size = new global::System.Drawing.Size(112, 17);
			this.checkPushesupforcorners.TabIndex = 35;
			this.checkPushesupforcorners.Text = "GK Up for Corners";
			this.checkPushesupforcorners.UseVisualStyleBackColor = false;
			this.checkEarlycrosser.AutoSize = true;
			this.checkEarlycrosser.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Earlycrosser", true));
			this.checkEarlycrosser.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkEarlycrosser.Location = new global::System.Drawing.Point(170, 81);
			this.checkEarlycrosser.Name = "checkEarlycrosser";
			this.checkEarlycrosser.Size = new global::System.Drawing.Size(87, 17);
			this.checkEarlycrosser.TabIndex = 29;
			this.checkEarlycrosser.Text = "Early Crosser";
			this.checkEarlycrosser.UseVisualStyleBackColor = false;
			this.checkInjuryProne.AutoSize = true;
			this.checkInjuryProne.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInjuryProne.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "InjuryProne", true));
			this.checkInjuryProne.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkInjuryProne.Location = new global::System.Drawing.Point(24, 37);
			this.checkInjuryProne.Name = "checkInjuryProne";
			this.checkInjuryProne.Size = new global::System.Drawing.Size(82, 17);
			this.checkInjuryProne.TabIndex = 32;
			this.checkInjuryProne.Text = "Injury Prone";
			this.checkInjuryProne.UseVisualStyleBackColor = false;
			this.checkGiantThrower.AutoSize = true;
			this.checkGiantThrower.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "GiantThrow", true));
			this.checkGiantThrower.Location = new global::System.Drawing.Point(24, 125);
			this.checkGiantThrower.Name = "checkGiantThrower";
			this.checkGiantThrower.Size = new global::System.Drawing.Size(93, 17);
			this.checkGiantThrower.TabIndex = 1;
			this.checkGiantThrower.Text = "Giant Thrower";
			this.checkGiantThrower.UseVisualStyleBackColor = true;
			this.checkLongThrower.AutoSize = true;
			this.checkLongThrower.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "Longthrows", true));
			this.checkLongThrower.Location = new global::System.Drawing.Point(24, 103);
			this.checkLongThrower.Name = "checkLongThrower";
			this.checkLongThrower.Size = new global::System.Drawing.Size(92, 17);
			this.checkLongThrower.TabIndex = 0;
			this.checkLongThrower.Text = "Long Thrower";
			this.checkLongThrower.UseVisualStyleBackColor = true;
			this.pageFace.BackColor = global::System.Drawing.Color.Transparent;
			this.pageFace.Controls.Add(this.splitContainer1);
			this.pageFace.ImageIndex = 2;
			this.pageFace.Location = new global::System.Drawing.Point(4, 23);
			this.pageFace.Name = "pageFace";
			this.pageFace.Size = new global::System.Drawing.Size(1349, 780);
			this.pageFace.TabIndex = 2;
			this.pageFace.Text = "Face";
			this.pageFace.UseVisualStyleBackColor = true;
			this.splitContainer1.BackColor = global::System.Drawing.Color.Transparent;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new global::System.Drawing.Size(1349, 780);
			this.splitContainer1.SplitterDistance = 748;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer2.BackColor = global::System.Drawing.Color.Transparent;
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer2.Panel1.Controls.Add(this.viewer3D);
			this.splitContainer2.Panel1.Controls.Add(this.tool3D);
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this.groupGenericFace);
			this.splitContainer2.Size = new global::System.Drawing.Size(748, 780);
			this.splitContainer2.SplitterDistance = 466;
			this.splitContainer2.TabIndex = 0;
			this.viewer3D.AmbientColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer3D.LightDirectionX = -0.5f;
			this.viewer3D.LightDirectionY = -0.25f;
			this.viewer3D.LightDirectionZ = -1f;
			this.viewer3D.LightX = 30f;
			this.viewer3D.LightY = 180f;
			this.viewer3D.LightZ = 100f;
			this.viewer3D.Location = new global::System.Drawing.Point(0, 0);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 6.28f;
			this.viewer3D.RotationY = 0f;
			this.viewer3D.RotationYCoeff = 0.001f;
			this.viewer3D.Size = new global::System.Drawing.Size(748, 441);
			this.viewer3D.TabIndex = 3;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 171f;
			this.viewer3D.ViewZ = 49f;
			this.viewer3D.ZbufferRenderState = null;
			this.tool3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.tool3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tool3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.buttonShow3DModel, this.buttonSwitchRenderingMode, this.toolStripSeparator1, this.buttonImport3DHeadModel, this.buttonExport3DHeadModel, this.buttonRemove3DHeadModel, this.toolStripSeparator4, this.buttonImport3DHairModel, this.buttonExport3DHairModel, this.buttonRemoveHairModel,
				this.toolStripSeparator5, this.buttonMoveHairAhead, this.buttonMoveHairBack, this.buttonMoveHairUp, this.buttonMoveHairDown, this.buttonMoveHairLeft, this.buttonMoveHairRight, this.buttonMakeHairCloser, this.buttonMakeHairWider, this.buttonSaveHair,
				this.toolStripSeparator2, this.toolPhoto, this.toolStripSeparator3, this.buttonShowJesey
			});
			this.tool3D.Location = new global::System.Drawing.Point(0, 441);
			this.tool3D.Name = "tool3D";
			this.tool3D.Size = new global::System.Drawing.Size(748, 25);
			this.tool3D.TabIndex = 4;
			this.buttonShow3DModel.CheckOnClick = true;
			this.buttonShow3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DModel.Image");
			this.buttonShow3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DModel.Name = "buttonShow3DModel";
			this.buttonShow3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DModel.Text = "Show / Hide";
			this.buttonShow3DModel.Click += new global::System.EventHandler(this.buttonShow3DModel_Click);
			this.buttonSwitchRenderingMode.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSwitchRenderingMode.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSwitchRenderingMode.Image");
			this.buttonSwitchRenderingMode.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSwitchRenderingMode.Name = "buttonSwitchRenderingMode";
			this.buttonSwitchRenderingMode.Size = new global::System.Drawing.Size(23, 22);
			this.buttonSwitchRenderingMode.Text = "Switch Rendering Mode";
			this.buttonSwitchRenderingMode.Click += new global::System.EventHandler(this.buttonSwitchRenderingMode_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonImport3DHeadModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImport3DHeadModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImport3DHeadModel.Image");
			this.buttonImport3DHeadModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImport3DHeadModel.Name = "buttonImport3DHeadModel";
			this.buttonImport3DHeadModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImport3DHeadModel.Text = "Import 3D Head Model";
			this.buttonImport3DHeadModel.Click += new global::System.EventHandler(this.buttonImport3DHeadModel_Click);
			this.buttonExport3DHeadModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExport3DHeadModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExport3DHeadModel.Image");
			this.buttonExport3DHeadModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExport3DHeadModel.Name = "buttonExport3DHeadModel";
			this.buttonExport3DHeadModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExport3DHeadModel.Text = "Export 3D Head Model";
			this.buttonExport3DHeadModel.Click += new global::System.EventHandler(this.buttonExport3DHeadModel_Click);
			this.buttonRemove3DHeadModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemove3DHeadModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemove3DHeadModel.Image");
			this.buttonRemove3DHeadModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemove3DHeadModel.Name = "buttonRemove3DHeadModel";
			this.buttonRemove3DHeadModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemove3DHeadModel.Text = "Remove 3D Head Model";
			this.buttonRemove3DHeadModel.Click += new global::System.EventHandler(this.buttonRemove3DModel_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.buttonImport3DHairModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImport3DHairModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImport3DHairModel.Image");
			this.buttonImport3DHairModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImport3DHairModel.Name = "buttonImport3DHairModel";
			this.buttonImport3DHairModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImport3DHairModel.Text = "Import 3D Hair Model";
			this.buttonImport3DHairModel.Click += new global::System.EventHandler(this.buttonImport3DHairModels_Click);
			this.buttonExport3DHairModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExport3DHairModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExport3DHairModel.Image");
			this.buttonExport3DHairModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExport3DHairModel.Name = "buttonExport3DHairModel";
			this.buttonExport3DHairModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExport3DHairModel.Text = "Export 3D Hair Model";
			this.buttonExport3DHairModel.Click += new global::System.EventHandler(this.buttonExport3DHairModels_Click);
			this.buttonRemoveHairModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemoveHairModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemoveHairModel.Image");
			this.buttonRemoveHairModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemoveHairModel.Name = "buttonRemoveHairModel";
			this.buttonRemoveHairModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemoveHairModel.Text = "Remove Hair Model";
			this.buttonRemoveHairModel.Click += new global::System.EventHandler(this.buttonRemoveHairModel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(6, 25);
			this.buttonMoveHairAhead.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairAhead.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairAhead.Image");
			this.buttonMoveHairAhead.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairAhead.Name = "buttonMoveHairAhead";
			this.buttonMoveHairAhead.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairAhead.Text = "Move Hair Ahead";
			this.buttonMoveHairAhead.Click += new global::System.EventHandler(this.buttonAhead_Click);
			this.buttonMoveHairBack.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairBack.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairBack.Image");
			this.buttonMoveHairBack.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.buttonMoveHairBack.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairBack.Name = "buttonMoveHairBack";
			this.buttonMoveHairBack.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairBack.Text = "Move Hair Back";
			this.buttonMoveHairBack.Click += new global::System.EventHandler(this.buttonBack_Click);
			this.buttonMoveHairUp.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairUp.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairUp.Image");
			this.buttonMoveHairUp.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairUp.Name = "buttonMoveHairUp";
			this.buttonMoveHairUp.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairUp.Text = "Move Hair Up";
			this.buttonMoveHairUp.Click += new global::System.EventHandler(this.buttonUp_Click);
			this.buttonMoveHairDown.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairDown.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairDown.Image");
			this.buttonMoveHairDown.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.buttonMoveHairDown.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairDown.Name = "buttonMoveHairDown";
			this.buttonMoveHairDown.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairDown.Text = "Move Hair Down";
			this.buttonMoveHairDown.Click += new global::System.EventHandler(this.buttonDown_Click);
			this.buttonMoveHairLeft.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairLeft.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairLeft.Image");
			this.buttonMoveHairLeft.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairLeft.Name = "buttonMoveHairLeft";
			this.buttonMoveHairLeft.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairLeft.Text = "Move Hair Left";
			this.buttonMoveHairLeft.Click += new global::System.EventHandler(this.buttonMoveHairLeft_Click);
			this.buttonMoveHairRight.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMoveHairRight.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMoveHairRight.Image");
			this.buttonMoveHairRight.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMoveHairRight.Name = "buttonMoveHairRight";
			this.buttonMoveHairRight.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMoveHairRight.Text = "Move Hair Right";
			this.buttonMoveHairRight.Click += new global::System.EventHandler(this.buttonMoveHairRight_Click);
			this.buttonMakeHairCloser.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMakeHairCloser.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMakeHairCloser.Image");
			this.buttonMakeHairCloser.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMakeHairCloser.Name = "buttonMakeHairCloser";
			this.buttonMakeHairCloser.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMakeHairCloser.Text = "Make Hair Closer";
			this.buttonMakeHairCloser.Click += new global::System.EventHandler(this.buttonMakeHairCloser_Click);
			this.buttonMakeHairWider.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonMakeHairWider.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonMakeHairWider.Image");
			this.buttonMakeHairWider.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonMakeHairWider.Name = "buttonMakeHairWider";
			this.buttonMakeHairWider.Size = new global::System.Drawing.Size(23, 22);
			this.buttonMakeHairWider.Text = "Make Hair Wider";
			this.buttonMakeHairWider.Click += new global::System.EventHandler(this.buttonMakeHairWider_Click);
			this.buttonSaveHair.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSaveHair.Enabled = false;
			this.buttonSaveHair.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSaveHair.Image");
			this.buttonSaveHair.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSaveHair.Name = "buttonSaveHair";
			this.buttonSaveHair.Size = new global::System.Drawing.Size(23, 22);
			this.buttonSaveHair.Text = "Save Modified Hair";
			this.buttonSaveHair.Click += new global::System.EventHandler(this.buttonSaveHair_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.toolPhoto.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolPhoto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolPhoto.Image");
			this.toolPhoto.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolPhoto.Name = "toolPhoto";
			this.toolPhoto.Size = new global::System.Drawing.Size(23, 22);
			this.toolPhoto.Text = "Take a picture";
			this.toolPhoto.Click += new global::System.EventHandler(this.toolPhoto_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.buttonShowJesey.Checked = true;
			this.buttonShowJesey.CheckOnClick = true;
			this.buttonShowJesey.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.buttonShowJesey.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowJesey.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShowJesey.Image");
			this.buttonShowJesey.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShowJesey.Name = "buttonShowJesey";
			this.buttonShowJesey.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShowJesey.Text = "Show team jersey";
			this.buttonShowJesey.Click += new global::System.EventHandler(this.buttonShowJesey_Click);
			this.groupGenericFace.Controls.Add(this.checkUsingRevMod);
			this.groupGenericFace.Controls.Add(this.viewer2DPlayerGui);
			this.groupGenericFace.Controls.Add(this.groupGenericFaceType);
			this.groupGenericFace.Controls.Add(this.checkHasGenericFace);
			this.groupGenericFace.Controls.Add(this.groupHairModel);
			this.groupGenericFace.Controls.Add(this.groupHeadModel);
			this.groupGenericFace.Controls.Add(this.labelSideburns);
			this.groupGenericFace.Controls.Add(this.comboSideburns);
			this.groupGenericFace.Controls.Add(this.labelHeadType);
			this.groupGenericFace.Controls.Add(this.labelHairType);
			this.groupGenericFace.Location = new global::System.Drawing.Point(8, 3);
			this.groupGenericFace.Name = "groupGenericFace";
			this.groupGenericFace.Size = new global::System.Drawing.Size(734, 296);
			this.groupGenericFace.TabIndex = 86;
			this.groupGenericFace.TabStop = false;
			this.groupGenericFace.Text = "Face Modelling";
			this.checkUsingRevMod.AutoSize = true;
			this.checkUsingRevMod.Location = new global::System.Drawing.Point(610, 19);
			this.checkUsingRevMod.Name = "checkUsingRevMod";
			this.checkUsingRevMod.Size = new global::System.Drawing.Size(106, 17);
			this.checkUsingRevMod.TabIndex = 122;
			this.checkUsingRevMod.Text = "Using Rev. Mod.";
			this.toolTip.SetToolTip(this.checkUsingRevMod, "Check this box if you are using RevMod and want to enable specific face even if Has Generic Face is checked");
			this.checkUsingRevMod.UseVisualStyleBackColor = true;
			this.checkUsingRevMod.Visible = false;
			this.checkUsingRevMod.CheckedChanged += new global::System.EventHandler(this.checkUsingrevMod_CheckedChanged);
			this.viewer2DPlayerGui.AutoTransparency = true;
			this.viewer2DPlayerGui.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPlayerGui.ButtonStripVisible = false;
			this.viewer2DPlayerGui.CurrentBitmap = null;
			this.viewer2DPlayerGui.ExtendedFormat = false;
			this.viewer2DPlayerGui.FullSizeButton = false;
			this.viewer2DPlayerGui.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DPlayerGui.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DPlayerGui.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.MiniFace;
			this.viewer2DPlayerGui.Location = new global::System.Drawing.Point(599, 43);
			this.viewer2DPlayerGui.Name = "viewer2DPlayerGui";
			this.viewer2DPlayerGui.RemoveButton = false;
			this.viewer2DPlayerGui.ShowButton = false;
			this.viewer2DPlayerGui.ShowButtonChecked = true;
			this.viewer2DPlayerGui.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DPlayerGui.TabIndex = 126;
			this.groupGenericFaceType.Controls.Add(this.labelFacialHair);
			this.groupGenericFaceType.Controls.Add(this.labelEyeBow);
			this.groupGenericFaceType.Controls.Add(this.domainFacialHair);
			this.groupGenericFaceType.Controls.Add(this.comboEyeBow);
			this.groupGenericFaceType.Controls.Add(this.labelSkintype);
			this.groupGenericFaceType.Controls.Add(this.comboSkintype);
			this.groupGenericFaceType.Controls.Add(this.comboFacialHairColor);
			this.groupGenericFaceType.Controls.Add(this.labelFacialHairColor);
			this.groupGenericFaceType.Location = new global::System.Drawing.Point(376, 42);
			this.groupGenericFaceType.Name = "groupGenericFaceType";
			this.groupGenericFaceType.Size = new global::System.Drawing.Size(217, 220);
			this.groupGenericFaceType.TabIndex = 35;
			this.groupGenericFaceType.TabStop = false;
			this.groupGenericFaceType.Text = "Face Type";
			this.labelFacialHair.AutoSize = true;
			this.labelFacialHair.BackColor = global::System.Drawing.Color.Transparent;
			this.labelFacialHair.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFacialHair.Location = new global::System.Drawing.Point(6, 123);
			this.labelFacialHair.Name = "labelFacialHair";
			this.labelFacialHair.Size = new global::System.Drawing.Size(57, 13);
			this.labelFacialHair.TabIndex = 15;
			this.labelFacialHair.Text = "Facial Hair";
			this.labelFacialHair.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelEyeBow.AutoSize = true;
			this.labelEyeBow.BackColor = global::System.Drawing.Color.Transparent;
			this.labelEyeBow.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelEyeBow.Location = new global::System.Drawing.Point(6, 90);
			this.labelEyeBow.Name = "labelEyeBow";
			this.labelEyeBow.Size = new global::System.Drawing.Size(57, 13);
			this.labelEyeBow.TabIndex = 33;
			this.labelEyeBow.Text = "Eyes Brow";
			this.labelEyeBow.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.domainFacialHair.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.domainFacialHair.FormattingEnabled = true;
			this.domainFacialHair.Items.AddRange(new object[]
			{
				"None", "Chin Stubble Light", "Chin Strap", "Goatee", "Casual Beard", "Partial Goatee", "Stubble", "Tuft", "Full Beard", "Light Goatee",
				"Mustache", "Light Chin Curtain", "Full Goatee", "Chin Curtain", "Beard", "Patchy Beard"
			});
			this.domainFacialHair.Location = new global::System.Drawing.Point(70, 120);
			this.domainFacialHair.Name = "domainFacialHair";
			this.domainFacialHair.Size = new global::System.Drawing.Size(140, 21);
			this.domainFacialHair.TabIndex = 4;
			this.domainFacialHair.SelectedIndexChanged += new global::System.EventHandler(this.domainFacialHair_SelectedItemChanged);
			this.comboEyeBow.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEyeBow.FormattingEnabled = true;
			this.comboEyeBow.Items.AddRange(new object[] { "Normal", "Big", "Thin", "Type Female 3", "Type Female 4", "Type Female 5", "Type Female 6" });
			this.comboEyeBow.Location = new global::System.Drawing.Point(70, 87);
			this.comboEyeBow.Name = "comboEyeBow";
			this.comboEyeBow.Size = new global::System.Drawing.Size(140, 21);
			this.comboEyeBow.TabIndex = 3;
			this.comboEyeBow.SelectedIndexChanged += new global::System.EventHandler(this.comboEyeBow_SelectedIndexChanged);
			this.labelSkintype.AutoSize = true;
			this.labelSkintype.BackColor = global::System.Drawing.Color.Transparent;
			this.labelSkintype.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSkintype.Location = new global::System.Drawing.Point(6, 54);
			this.labelSkintype.Name = "labelSkintype";
			this.labelSkintype.Size = new global::System.Drawing.Size(55, 13);
			this.labelSkintype.TabIndex = 21;
			this.labelSkintype.Text = "Skin Type";
			this.labelSkintype.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboSkintype.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSkintype.FormattingEnabled = true;
			this.comboSkintype.Items.AddRange(new object[] { "Clean", "Freckled", "Rough", "Type Female 3", "Type Female 4", "Type Female 5", "Type Female 6", "Type Female 7" });
			this.comboSkintype.Location = new global::System.Drawing.Point(70, 51);
			this.comboSkintype.Name = "comboSkintype";
			this.comboSkintype.Size = new global::System.Drawing.Size(140, 21);
			this.comboSkintype.TabIndex = 1;
			this.comboSkintype.SelectedIndexChanged += new global::System.EventHandler(this.comboSkintype_SelectedIndexChanged);
			this.comboFacialHairColor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFacialHairColor.FormattingEnabled = true;
			this.comboFacialHairColor.Items.AddRange(new object[] { "Black", "Blonde", "Dark Brown", "Light Brown", "Red" });
			this.comboFacialHairColor.Location = new global::System.Drawing.Point(70, 154);
			this.comboFacialHairColor.Name = "comboFacialHairColor";
			this.comboFacialHairColor.Size = new global::System.Drawing.Size(140, 21);
			this.comboFacialHairColor.TabIndex = 5;
			this.comboFacialHairColor.SelectedIndexChanged += new global::System.EventHandler(this.comboFacialHairColor_SelectedIndexChanged);
			this.labelFacialHairColor.AutoSize = true;
			this.labelFacialHairColor.BackColor = global::System.Drawing.Color.Transparent;
			this.labelFacialHairColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFacialHairColor.Location = new global::System.Drawing.Point(6, 157);
			this.labelFacialHairColor.Name = "labelFacialHairColor";
			this.labelFacialHairColor.Size = new global::System.Drawing.Size(31, 13);
			this.labelFacialHairColor.TabIndex = 17;
			this.labelFacialHairColor.Text = "Color";
			this.labelFacialHairColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkHasGenericFace.AutoSize = true;
			this.checkHasGenericFace.Location = new global::System.Drawing.Point(66, 19);
			this.checkHasGenericFace.Name = "checkHasGenericFace";
			this.checkHasGenericFace.Size = new global::System.Drawing.Size(112, 17);
			this.checkHasGenericFace.TabIndex = 0;
			this.checkHasGenericFace.Text = "Has Generic Face";
			this.toolTip.SetToolTip(this.checkHasGenericFace, "Check this box if you want the player has a generic face. Uncheck for ahaving a specific face. This info is saved in the database.");
			this.checkHasGenericFace.UseVisualStyleBackColor = true;
			this.checkHasGenericFace.CheckedChanged += new global::System.EventHandler(this.checkHasGenericFace_CheckedChanged);
			this.groupHairModel.Controls.Add(this.comboFemaleHair);
			this.groupHairModel.Controls.Add(this.radioButtonFemaleHair);
			this.groupHairModel.Controls.Add(this.buttonHairSelection);
			this.groupHairModel.Controls.Add(this.comboHeadband);
			this.groupHairModel.Controls.Add(this.comboAfro);
			this.groupHairModel.Controls.Add(this.comboLong);
			this.groupHairModel.Controls.Add(this.comboMedium);
			this.groupHairModel.Controls.Add(this.comboModern);
			this.groupHairModel.Controls.Add(this.labelHairColor);
			this.groupHairModel.Controls.Add(this.domainHairColor);
			this.groupHairModel.Controls.Add(this.comboShort);
			this.groupHairModel.Controls.Add(this.comboVeryShort);
			this.groupHairModel.Controls.Add(this.comboShaven);
			this.groupHairModel.Controls.Add(this.radioHeadband);
			this.groupHairModel.Controls.Add(this.radioShaven);
			this.groupHairModel.Controls.Add(this.radioAfro);
			this.groupHairModel.Controls.Add(this.radioLong);
			this.groupHairModel.Controls.Add(this.radioMedium);
			this.groupHairModel.Controls.Add(this.radioModern);
			this.groupHairModel.Controls.Add(this.radioShort);
			this.groupHairModel.Controls.Add(this.radioVeryShort);
			this.groupHairModel.Location = new global::System.Drawing.Point(6, 127);
			this.groupHairModel.Name = "groupHairModel";
			this.groupHairModel.Size = new global::System.Drawing.Size(364, 135);
			this.groupHairModel.TabIndex = 29;
			this.groupHairModel.TabStop = false;
			this.groupHairModel.Text = "Hair Model and Color";
			this.comboFemaleHair.FormattingEnabled = true;
			this.comboFemaleHair.Location = new global::System.Drawing.Point(6, 78);
			this.comboFemaleHair.Name = "comboFemaleHair";
			this.comboFemaleHair.Size = new global::System.Drawing.Size(260, 21);
			this.comboFemaleHair.TabIndex = 32;
			this.comboFemaleHair.Visible = false;
			this.comboFemaleHair.SelectedIndexChanged += new global::System.EventHandler(this.comboFemaleHair_SelectedIndexChanged);
			this.radioButtonFemaleHair.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonFemaleHair.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonFemaleHair.Location = new global::System.Drawing.Point(290, 17);
			this.radioButtonFemaleHair.Name = "radioButtonFemaleHair";
			this.radioButtonFemaleHair.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonFemaleHair.TabIndex = 31;
			this.radioButtonFemaleHair.TabStop = true;
			this.radioButtonFemaleHair.Tag = this.comboFemaleHair;
			this.radioButtonFemaleHair.Text = "Female";
			this.radioButtonFemaleHair.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonFemaleHair.UseVisualStyleBackColor = true;
			this.radioButtonFemaleHair.CheckedChanged += new global::System.EventHandler(this.radioButtonFemaleHair_CheckedChanged);
			this.buttonHairSelection.Location = new global::System.Drawing.Point(272, 83);
			this.buttonHairSelection.Name = "buttonHairSelection";
			this.buttonHairSelection.Size = new global::System.Drawing.Size(86, 46);
			this.buttonHairSelection.TabIndex = 30;
			this.buttonHairSelection.Text = "Fast Hair Selection";
			this.buttonHairSelection.UseVisualStyleBackColor = true;
			this.buttonHairSelection.Click += new global::System.EventHandler(this.buttonHairSelection_Click);
			this.comboHeadband.FormattingEnabled = true;
			this.comboHeadband.Location = new global::System.Drawing.Point(6, 78);
			this.comboHeadband.Name = "comboHeadband";
			this.comboHeadband.Size = new global::System.Drawing.Size(260, 21);
			this.comboHeadband.TabIndex = 0;
			this.comboHeadband.Visible = false;
			this.comboHeadband.SelectedIndexChanged += new global::System.EventHandler(this.comboHeadband_SelectedIndexChanged);
			this.comboAfro.FormattingEnabled = true;
			this.comboAfro.Items.AddRange(new object[] { "71", "4", "42", "27", "5", "6", "96", "3" });
			this.comboAfro.Location = new global::System.Drawing.Point(6, 78);
			this.comboAfro.Name = "comboAfro";
			this.comboAfro.Size = new global::System.Drawing.Size(260, 21);
			this.comboAfro.TabIndex = 29;
			this.comboAfro.Visible = false;
			this.comboAfro.SelectedIndexChanged += new global::System.EventHandler(this.comboAfro_SelectedIndexChanged);
			this.comboLong.FormattingEnabled = true;
			this.comboLong.Items.AddRange(new object[]
			{
				"8", "9", "15", "44", "84", "34", "10", "33", "12", "80",
				"11", "51", "79", "53", "7", "48"
			});
			this.comboLong.Location = new global::System.Drawing.Point(6, 78);
			this.comboLong.Name = "comboLong";
			this.comboLong.Size = new global::System.Drawing.Size(260, 21);
			this.comboLong.TabIndex = 28;
			this.comboLong.Visible = false;
			this.comboLong.SelectedIndexChanged += new global::System.EventHandler(this.comboLong_SelectedIndexChanged);
			this.comboMedium.FormattingEnabled = true;
			this.comboMedium.Items.AddRange(new object[]
			{
				"36", "74", "13", "35", "59", "69", "73", "85", "93", "32",
				"66", "67", "68", "14", "20", "23", "58", "62", "83", "95",
				"22", "52", "87", "98", "99", "100", "103"
			});
			this.comboMedium.Location = new global::System.Drawing.Point(6, 78);
			this.comboMedium.Name = "comboMedium";
			this.comboMedium.Size = new global::System.Drawing.Size(260, 21);
			this.comboMedium.TabIndex = 27;
			this.comboMedium.Visible = false;
			this.comboMedium.SelectedIndexChanged += new global::System.EventHandler(this.comboMedium_SelectedIndexChanged);
			this.comboModern.FormattingEnabled = true;
			this.comboModern.Items.AddRange(new object[]
			{
				"17", "18", "19", "24", "39", "60", "61", "63", "64", "86",
				"88", "89", "94"
			});
			this.comboModern.Location = new global::System.Drawing.Point(6, 78);
			this.comboModern.Name = "comboModern";
			this.comboModern.Size = new global::System.Drawing.Size(260, 21);
			this.comboModern.TabIndex = 26;
			this.comboModern.Visible = false;
			this.comboModern.SelectedIndexChanged += new global::System.EventHandler(this.comboModern_SelectedIndexChanged);
			this.labelHairColor.AutoSize = true;
			this.labelHairColor.BackColor = global::System.Drawing.Color.Transparent;
			this.labelHairColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHairColor.Location = new global::System.Drawing.Point(6, 112);
			this.labelHairColor.Name = "labelHairColor";
			this.labelHairColor.Size = new global::System.Drawing.Size(53, 13);
			this.labelHairColor.TabIndex = 13;
			this.labelHairColor.Text = "Hair Color";
			this.labelHairColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.domainHairColor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.domainHairColor.FormattingEnabled = true;
			this.domainHairColor.Items.AddRange(new object[]
			{
				"Blonde", "Black", "Ash Blonde", "Dark Brown", "Platinum Blonde", "Light Brown", "Brown", "Red", "White", "Gray",
				"Green", "Violet", "Intense Red"
			});
			this.domainHairColor.Location = new global::System.Drawing.Point(71, 108);
			this.domainHairColor.Name = "domainHairColor";
			this.domainHairColor.Size = new global::System.Drawing.Size(195, 21);
			this.domainHairColor.TabIndex = 1;
			this.domainHairColor.SelectedIndexChanged += new global::System.EventHandler(this.domainHairColor_SelectedIndexChanged);
			this.comboShort.FormattingEnabled = true;
			this.comboShort.Items.AddRange(new object[]
			{
				"2", "21", "22", "30", "38", "54", "57", "70", "75", "78",
				"82", "97", "101", "102", "104", "105", "106", "107", "108", "109",
				"110", "111", "112"
			});
			this.comboShort.Location = new global::System.Drawing.Point(6, 78);
			this.comboShort.Name = "comboShort";
			this.comboShort.Size = new global::System.Drawing.Size(260, 21);
			this.comboShort.TabIndex = 25;
			this.comboShort.Visible = false;
			this.comboShort.SelectedIndexChanged += new global::System.EventHandler(this.comboShort_SelectedIndexChanged);
			this.comboVeryShort.FormattingEnabled = true;
			this.comboVeryShort.Items.AddRange(new object[]
			{
				"26", "29", "47", "72", "92", "16", "28", "31", "37", "40",
				"45", "65", "77", "90"
			});
			this.comboVeryShort.Location = new global::System.Drawing.Point(6, 78);
			this.comboVeryShort.Name = "comboVeryShort";
			this.comboVeryShort.Size = new global::System.Drawing.Size(260, 21);
			this.comboVeryShort.TabIndex = 24;
			this.comboVeryShort.Visible = false;
			this.comboVeryShort.SelectedIndexChanged += new global::System.EventHandler(this.comboVeryShort_SelectedIndexChanged);
			this.comboShaven.FormattingEnabled = true;
			this.comboShaven.Items.AddRange(new object[] { "0", "25", "1", "43", "41", "46" });
			this.comboShaven.Location = new global::System.Drawing.Point(6, 78);
			this.comboShaven.Name = "comboShaven";
			this.comboShaven.Size = new global::System.Drawing.Size(260, 21);
			this.comboShaven.TabIndex = 23;
			this.comboShaven.Visible = false;
			this.comboShaven.SelectedIndexChanged += new global::System.EventHandler(this.comboShaven_SelectedIndexChanged);
			this.radioHeadband.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioHeadband.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioHeadband.Location = new global::System.Drawing.Point(148, 46);
			this.radioHeadband.Name = "radioHeadband";
			this.radioHeadband.Size = new global::System.Drawing.Size(65, 23);
			this.radioHeadband.TabIndex = 22;
			this.radioHeadband.TabStop = true;
			this.radioHeadband.Tag = this.comboHeadband;
			this.radioHeadband.Text = "Headband";
			this.radioHeadband.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioHeadband.UseVisualStyleBackColor = true;
			this.radioHeadband.CheckedChanged += new global::System.EventHandler(this.radioHeadband_CheckedChanged);
			this.radioShaven.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioShaven.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioShaven.Location = new global::System.Drawing.Point(6, 17);
			this.radioShaven.Name = "radioShaven";
			this.radioShaven.Size = new global::System.Drawing.Size(65, 23);
			this.radioShaven.TabIndex = 21;
			this.radioShaven.TabStop = true;
			this.radioShaven.Tag = this.comboShaven;
			this.radioShaven.Text = "Shaven";
			this.radioShaven.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioShaven.UseVisualStyleBackColor = true;
			this.radioShaven.CheckedChanged += new global::System.EventHandler(this.radioShaven_CheckedChanged);
			this.radioAfro.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioAfro.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioAfro.Location = new global::System.Drawing.Point(219, 46);
			this.radioAfro.Name = "radioAfro";
			this.radioAfro.Size = new global::System.Drawing.Size(65, 23);
			this.radioAfro.TabIndex = 20;
			this.radioAfro.TabStop = true;
			this.radioAfro.Tag = this.comboAfro;
			this.radioAfro.Text = "Afro";
			this.radioAfro.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioAfro.UseVisualStyleBackColor = true;
			this.radioAfro.CheckedChanged += new global::System.EventHandler(this.radioButtonAfro_CheckedChanged);
			this.radioLong.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioLong.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioLong.Location = new global::System.Drawing.Point(77, 46);
			this.radioLong.Name = "radioLong";
			this.radioLong.Size = new global::System.Drawing.Size(65, 23);
			this.radioLong.TabIndex = 19;
			this.radioLong.TabStop = true;
			this.radioLong.Tag = this.comboLong;
			this.radioLong.Text = "Long";
			this.radioLong.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioLong.UseVisualStyleBackColor = true;
			this.radioLong.CheckedChanged += new global::System.EventHandler(this.radioButtonLong_CheckedChanged);
			this.radioMedium.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioMedium.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioMedium.Location = new global::System.Drawing.Point(6, 46);
			this.radioMedium.Name = "radioMedium";
			this.radioMedium.Size = new global::System.Drawing.Size(65, 23);
			this.radioMedium.TabIndex = 18;
			this.radioMedium.TabStop = true;
			this.radioMedium.Tag = this.comboMedium;
			this.radioMedium.Text = "Medium";
			this.radioMedium.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioMedium.UseVisualStyleBackColor = true;
			this.radioMedium.CheckedChanged += new global::System.EventHandler(this.radioButtonMedium_CheckedChanged);
			this.radioModern.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioModern.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioModern.Location = new global::System.Drawing.Point(219, 17);
			this.radioModern.Name = "radioModern";
			this.radioModern.Size = new global::System.Drawing.Size(65, 23);
			this.radioModern.TabIndex = 17;
			this.radioModern.TabStop = true;
			this.radioModern.Tag = this.comboModern;
			this.radioModern.Text = "Modern";
			this.radioModern.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioModern.UseVisualStyleBackColor = true;
			this.radioModern.CheckedChanged += new global::System.EventHandler(this.radioModern_CheckedChanged);
			this.radioShort.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioShort.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioShort.Location = new global::System.Drawing.Point(148, 17);
			this.radioShort.Name = "radioShort";
			this.radioShort.Size = new global::System.Drawing.Size(65, 23);
			this.radioShort.TabIndex = 16;
			this.radioShort.TabStop = true;
			this.radioShort.Tag = this.comboShort;
			this.radioShort.Text = "Short";
			this.radioShort.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioShort.UseVisualStyleBackColor = true;
			this.radioShort.CheckedChanged += new global::System.EventHandler(this.radioShort_CheckedChanged);
			this.radioVeryShort.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioVeryShort.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioVeryShort.Location = new global::System.Drawing.Point(77, 17);
			this.radioVeryShort.Name = "radioVeryShort";
			this.radioVeryShort.Size = new global::System.Drawing.Size(65, 23);
			this.radioVeryShort.TabIndex = 15;
			this.radioVeryShort.TabStop = true;
			this.radioVeryShort.Tag = this.comboVeryShort;
			this.radioVeryShort.Text = "Very Short";
			this.radioVeryShort.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioVeryShort.UseVisualStyleBackColor = true;
			this.radioVeryShort.CheckedChanged += new global::System.EventHandler(this.radioVeryShort_CheckedChanged);
			this.groupHeadModel.Controls.Add(this.radioButtonFemale);
			this.groupHeadModel.Controls.Add(this.comboFemaleModels);
			this.groupHeadModel.Controls.Add(this.comboLatinModels);
			this.groupHeadModel.Controls.Add(this.radioButtonLatin);
			this.groupHeadModel.Controls.Add(this.comboAsiaticModels);
			this.groupHeadModel.Controls.Add(this.radioButtonAsiatic);
			this.groupHeadModel.Controls.Add(this.comboAfricanModels);
			this.groupHeadModel.Controls.Add(this.radioButtonAfrican);
			this.groupHeadModel.Controls.Add(this.radioButtonCaucasic);
			this.groupHeadModel.Controls.Add(this.comboCaucasicModels);
			this.groupHeadModel.Controls.Add(this.buttonRandomizeAppearance);
			this.groupHeadModel.Location = new global::System.Drawing.Point(6, 42);
			this.groupHeadModel.Name = "groupHeadModel";
			this.groupHeadModel.Size = new global::System.Drawing.Size(364, 79);
			this.groupHeadModel.TabIndex = 28;
			this.groupHeadModel.TabStop = false;
			this.groupHeadModel.Text = "Head Model";
			this.radioButtonFemale.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonFemale.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonFemale.Location = new global::System.Drawing.Point(290, 19);
			this.radioButtonFemale.Name = "radioButtonFemale";
			this.radioButtonFemale.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonFemale.TabIndex = 29;
			this.radioButtonFemale.TabStop = true;
			this.radioButtonFemale.Tag = "comboFemaleModels [System.Windows.Forms.ComboBox], Items.Count: 42";
			this.radioButtonFemale.Text = "Female";
			this.radioButtonFemale.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonFemale.UseVisualStyleBackColor = true;
			this.radioButtonFemale.CheckedChanged += new global::System.EventHandler(this.radioButtonFemale_CheckedChanged);
			this.comboFemaleModels.FormattingEnabled = true;
			this.comboFemaleModels.Items.AddRange(new object[]
			{
				"5500", "5501", "5502", "6000", "6001", "6002", "6500", "6501", "6502", "7000",
				"7001", "7002", "7500", "7501", "7502", "8000", "8001", "8002", "8500", "8501",
				"8502", "9000", "9001", "9002", "9500", "9501", "9502", "10000", "10001", "10002",
				"10500", "10501", "10502"
			});
			this.comboFemaleModels.Location = new global::System.Drawing.Point(6, 48);
			this.comboFemaleModels.Name = "comboFemaleModels";
			this.comboFemaleModels.Size = new global::System.Drawing.Size(260, 21);
			this.comboFemaleModels.TabIndex = 28;
			this.comboFemaleModels.Visible = false;
			this.comboFemaleModels.SelectedIndexChanged += new global::System.EventHandler(this.comboFemaleModels_SelectedIndexChanged);
			this.comboLatinModels.FormattingEnabled = true;
			this.comboLatinModels.Items.AddRange(new object[]
			{
				"1500", "1501", "1502", "1503", "1504", "1505", "1506", "1507", "1508", "1509",
				"1510", "1511", "1512", "1513", "1514", "1515", "1516", "1517", "1518", "1519",
				"1520", "1521", "1522", "1523", "1524", "1525", "1526", "1527", "1528", "2500",
				"2501", "2502", "2503", "2504", "2505", "2506", "2507", "2508", "2509", "2510",
				"2511", "2512"
			});
			this.comboLatinModels.Location = new global::System.Drawing.Point(6, 48);
			this.comboLatinModels.Name = "comboLatinModels";
			this.comboLatinModels.Size = new global::System.Drawing.Size(260, 21);
			this.comboLatinModels.TabIndex = 0;
			this.comboLatinModels.Visible = false;
			this.comboLatinModels.SelectedIndexChanged += new global::System.EventHandler(this.comboLatinModels_SelectedIndexChanged);
			this.radioButtonLatin.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonLatin.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonLatin.Location = new global::System.Drawing.Point(219, 19);
			this.radioButtonLatin.Name = "radioButtonLatin";
			this.radioButtonLatin.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonLatin.TabIndex = 8;
			this.radioButtonLatin.TabStop = true;
			this.radioButtonLatin.Tag = this.comboLatinModels;
			this.radioButtonLatin.Text = "Latin";
			this.radioButtonLatin.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonLatin.UseVisualStyleBackColor = true;
			this.radioButtonLatin.CheckedChanged += new global::System.EventHandler(this.radioButtonLatin_CheckedChanged);
			this.comboAsiaticModels.FormattingEnabled = true;
			this.comboAsiaticModels.Items.AddRange(new object[]
			{
				"500", "501", "502", "503", "504", "505", "506", "507", "508", "509",
				"510", "511", "512", "513", "514", "515", "516", "517", "518", "519",
				"520", "521", "522", "523", "524", "525", "526", "527", "528", "529",
				"530", "531", "532"
			});
			this.comboAsiaticModels.Location = new global::System.Drawing.Point(6, 48);
			this.comboAsiaticModels.Name = "comboAsiaticModels";
			this.comboAsiaticModels.Size = new global::System.Drawing.Size(254, 21);
			this.comboAsiaticModels.TabIndex = 0;
			this.comboAsiaticModels.Visible = false;
			this.comboAsiaticModels.SelectedIndexChanged += new global::System.EventHandler(this.comboAsiaticModels_SelectedIndexChanged);
			this.radioButtonAsiatic.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonAsiatic.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonAsiatic.Location = new global::System.Drawing.Point(77, 19);
			this.radioButtonAsiatic.Name = "radioButtonAsiatic";
			this.radioButtonAsiatic.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonAsiatic.TabIndex = 6;
			this.radioButtonAsiatic.TabStop = true;
			this.radioButtonAsiatic.Tag = this.comboAsiaticModels;
			this.radioButtonAsiatic.Text = "Asiatic";
			this.radioButtonAsiatic.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonAsiatic.UseVisualStyleBackColor = true;
			this.radioButtonAsiatic.CheckedChanged += new global::System.EventHandler(this.radioButtonAsiatic_CheckedChanged);
			this.comboAfricanModels.FormattingEnabled = true;
			this.comboAfricanModels.Items.AddRange(new object[]
			{
				"1000", "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009",
				"1010", "1011", "1012", "1013", "1014", "1015", "1016", "1017", "1018", "1019",
				"1020", "1021", "3000", "3001", "3002", "3003", "3004", "3005", "4500", "4501",
				"4502", "4525", "5000", "5001", "5002", "5003"
			});
			this.comboAfricanModels.Location = new global::System.Drawing.Point(6, 48);
			this.comboAfricanModels.Name = "comboAfricanModels";
			this.comboAfricanModels.Size = new global::System.Drawing.Size(254, 21);
			this.comboAfricanModels.TabIndex = 1;
			this.comboAfricanModels.Visible = false;
			this.comboAfricanModels.SelectedIndexChanged += new global::System.EventHandler(this.comboAfricanModels_SelectedIndexChanged);
			this.radioButtonAfrican.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonAfrican.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonAfrican.Location = new global::System.Drawing.Point(6, 19);
			this.radioButtonAfrican.Name = "radioButtonAfrican";
			this.radioButtonAfrican.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonAfrican.TabIndex = 5;
			this.radioButtonAfrican.TabStop = true;
			this.radioButtonAfrican.Tag = this.comboAfricanModels;
			this.radioButtonAfrican.Text = "African";
			this.radioButtonAfrican.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonAfrican.UseVisualStyleBackColor = true;
			this.radioButtonAfrican.CheckedChanged += new global::System.EventHandler(this.radioButtonAfrican_CheckedChanged);
			this.radioButtonCaucasic.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonCaucasic.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonCaucasic.Location = new global::System.Drawing.Point(148, 19);
			this.radioButtonCaucasic.Name = "radioButtonCaucasic";
			this.radioButtonCaucasic.Size = new global::System.Drawing.Size(65, 23);
			this.radioButtonCaucasic.TabIndex = 7;
			this.radioButtonCaucasic.TabStop = true;
			this.radioButtonCaucasic.Tag = this.comboCaucasicModels;
			this.radioButtonCaucasic.Text = "Caucasian";
			this.radioButtonCaucasic.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonCaucasic.UseVisualStyleBackColor = true;
			this.radioButtonCaucasic.CheckedChanged += new global::System.EventHandler(this.radioButtonCaucasic_CheckedChanged);
			this.comboCaucasicModels.FormattingEnabled = true;
			this.comboCaucasicModels.Items.AddRange(new object[]
			{
				"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
				"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
				"21", "22", "23", "24", "25", "2000", "2001", "2002", "2003", "2004",
				"2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014",
				"2015", "2016", "2017", "2018", "2019", "2020", "2021", "3500", "3501", "3502",
				"3503", "3504", "3505", "4000", "4001", "4002", "4003"
			});
			this.comboCaucasicModels.Location = new global::System.Drawing.Point(6, 48);
			this.comboCaucasicModels.Name = "comboCaucasicModels";
			this.comboCaucasicModels.Size = new global::System.Drawing.Size(254, 21);
			this.comboCaucasicModels.TabIndex = 2;
			this.comboCaucasicModels.Visible = false;
			this.comboCaucasicModels.SelectedIndexChanged += new global::System.EventHandler(this.comboCaucasicModels_SelectedIndexChanged);
			this.buttonRandomizeAppearance.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomizeAppearance.Location = new global::System.Drawing.Point(272, 46);
			this.buttonRandomizeAppearance.Name = "buttonRandomizeAppearance";
			this.buttonRandomizeAppearance.Size = new global::System.Drawing.Size(86, 23);
			this.buttonRandomizeAppearance.TabIndex = 27;
			this.buttonRandomizeAppearance.Text = "Randomize";
			this.buttonRandomizeAppearance.UseVisualStyleBackColor = true;
			this.buttonRandomizeAppearance.Click += new global::System.EventHandler(this.buttonRandomizeAppearance_Click);
			this.labelSideburns.AutoSize = true;
			this.labelSideburns.BackColor = global::System.Drawing.Color.Transparent;
			this.labelSideburns.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSideburns.Location = new global::System.Drawing.Point(603, 208);
			this.labelSideburns.Name = "labelSideburns";
			this.labelSideburns.Size = new global::System.Drawing.Size(54, 13);
			this.labelSideburns.TabIndex = 23;
			this.labelSideburns.Text = "Sideburns";
			this.labelSideburns.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSideburns.Visible = false;
			this.comboSideburns.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSideburns.FormattingEnabled = true;
			this.comboSideburns.Items.AddRange(new object[] { "No", "Yes" });
			this.comboSideburns.Location = new global::System.Drawing.Point(674, 205);
			this.comboSideburns.Name = "comboSideburns";
			this.comboSideburns.Size = new global::System.Drawing.Size(140, 21);
			this.comboSideburns.TabIndex = 6;
			this.comboSideburns.Visible = false;
			this.comboSideburns.SelectedIndexChanged += new global::System.EventHandler(this.comboSideburns_SelectedIndexChanged);
			this.labelHeadType.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHeadType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHeadType.Location = new global::System.Drawing.Point(185, 164);
			this.labelHeadType.Name = "labelHeadType";
			this.labelHeadType.Size = new global::System.Drawing.Size(127, 20);
			this.labelHeadType.TabIndex = 11;
			this.labelHeadType.Text = "Head Model";
			this.labelHeadType.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHairType.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHairType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHairType.Location = new global::System.Drawing.Point(16, 204);
			this.labelHairType.Name = "labelHairType";
			this.labelHairType.Size = new global::System.Drawing.Size(119, 20);
			this.labelHairType.TabIndex = 9;
			this.labelHairType.Text = "Hair Model";
			this.labelHairType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.splitContainer3.BackColor = global::System.Drawing.Color.Transparent;
			this.splitContainer3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer3.Panel1.AutoScroll = true;
			this.splitContainer3.Panel1.Controls.Add(this.groupSpecifiHeadControls);
			this.splitContainer3.Panel1.Controls.Add(this.groupCommonHeadControls);
			this.splitContainer3.Panel1.Controls.Add(this.checkShowTexures);
			this.splitContainer3.Panel2.AutoScroll = true;
			this.splitContainer3.Size = new global::System.Drawing.Size(597, 780);
			this.splitContainer3.SplitterDistance = 745;
			this.splitContainer3.TabIndex = 0;
			this.groupSpecifiHeadControls.Controls.Add(this.viewer2DTattoos);
			this.groupSpecifiHeadControls.Controls.Add(this.checkHighQaualityFace);
			this.groupSpecifiHeadControls.Controls.Add(this.multiViewerFace);
			this.groupSpecifiHeadControls.Location = new global::System.Drawing.Point(3, 359);
			this.groupSpecifiHeadControls.Name = "groupSpecifiHeadControls";
			this.groupSpecifiHeadControls.Size = new global::System.Drawing.Size(544, 349);
			this.groupSpecifiHeadControls.TabIndex = 127;
			this.groupSpecifiHeadControls.TabStop = false;
			this.viewer2DTattoos.AutoTransparency = false;
			this.viewer2DTattoos.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DTattoos.ButtonStripVisible = false;
			this.viewer2DTattoos.CurrentBitmap = null;
			this.viewer2DTattoos.ExtendedFormat = false;
			this.viewer2DTattoos.FullSizeButton = false;
			this.viewer2DTattoos.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DTattoos.ImageSize = new global::System.Drawing.Size(1024, 1024);
			this.viewer2DTattoos.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DTattoos.Location = new global::System.Drawing.Point(268, 51);
			this.viewer2DTattoos.Name = "viewer2DTattoos";
			this.viewer2DTattoos.RemoveButton = false;
			this.viewer2DTattoos.ShowButton = false;
			this.viewer2DTattoos.ShowButtonChecked = true;
			this.viewer2DTattoos.Size = new global::System.Drawing.Size(256, 279);
			this.viewer2DTattoos.TabIndex = 124;
			this.checkHighQaualityFace.AutoSize = true;
			this.checkHighQaualityFace.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.playerBindingSource, "hashighqualityhead", true));
			this.checkHighQaualityFace.Location = new global::System.Drawing.Point(6, 7);
			this.checkHighQaualityFace.Name = "checkHighQaualityFace";
			this.checkHighQaualityFace.Size = new global::System.Drawing.Size(110, 17);
			this.checkHighQaualityFace.TabIndex = 123;
			this.checkHighQaualityFace.Text = "High Quality Face";
			this.toolTip.SetToolTip(this.checkHighQaualityFace, "Check this box if the player face is high quality.");
			this.checkHighQaualityFace.UseVisualStyleBackColor = true;
			this.multiViewerFace.AutoTransparency = false;
			this.multiViewerFace.Bitmaps = null;
			this.multiViewerFace.CheckBitmapSize = false;
			this.multiViewerFace.FixedSize = false;
			this.multiViewerFace.FullSizeButton = false;
			this.multiViewerFace.LabelText = "Image n.";
			this.multiViewerFace.Location = new global::System.Drawing.Point(6, 30);
			this.multiViewerFace.Name = "multiViewerFace";
			this.multiViewerFace.ShowButton = false;
			this.multiViewerFace.ShowDeleteButton = false;
			this.multiViewerFace.Size = new global::System.Drawing.Size(256, 301);
			this.multiViewerFace.TabIndex = 101;
			this.groupCommonHeadControls.Controls.Add(this.comboFaceposer);
			this.groupCommonHeadControls.Controls.Add(this.label13);
			this.groupCommonHeadControls.Controls.Add(this.buttonRgbHair);
			this.groupCommonHeadControls.Controls.Add(this.multiViewerHair);
			this.groupCommonHeadControls.Controls.Add(this.viewer2DEyeTexture);
			this.groupCommonHeadControls.Controls.Add(this.viewer2DSkinTexture);
			this.groupCommonHeadControls.Controls.Add(this.label1);
			this.groupCommonHeadControls.Controls.Add(this.labelSkinColorInfo);
			this.groupCommonHeadControls.Controls.Add(this.label2);
			this.groupCommonHeadControls.Controls.Add(this.comboEyescolor);
			this.groupCommonHeadControls.Controls.Add(this.numericSkinTone);
			this.groupCommonHeadControls.Location = new global::System.Drawing.Point(3, 30);
			this.groupCommonHeadControls.Name = "groupCommonHeadControls";
			this.groupCommonHeadControls.Size = new global::System.Drawing.Size(544, 323);
			this.groupCommonHeadControls.TabIndex = 128;
			this.groupCommonHeadControls.TabStop = false;
			this.comboFaceposer.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFaceposer.FormattingEnabled = true;
			this.comboFaceposer.Items.AddRange(new object[] { "Default", "Variant 1", "Variant 2", "Variant 3" });
			this.comboFaceposer.Location = new global::System.Drawing.Point(385, 245);
			this.comboFaceposer.Name = "comboFaceposer";
			this.comboFaceposer.Size = new global::System.Drawing.Size(128, 21);
			this.comboFaceposer.TabIndex = 125;
			this.comboFaceposer.SelectedIndexChanged += new global::System.EventHandler(this.comboFaceposer_SelectedIndexChanged);
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.label13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new global::System.Drawing.Point(289, 250);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(90, 13);
			this.label13.TabIndex = 124;
			this.label13.Text = "Face Expressions";
			this.label13.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonRgbHair.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRgbHair.BackgroundImage");
			this.buttonRgbHair.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonRgbHair.Location = new global::System.Drawing.Point(236, 290);
			this.buttonRgbHair.Name = "buttonRgbHair";
			this.buttonRgbHair.Size = new global::System.Drawing.Size(25, 23);
			this.buttonRgbHair.TabIndex = 100;
			this.toolTip.SetToolTip(this.buttonRgbHair, "Modify the RGB components");
			this.buttonRgbHair.UseVisualStyleBackColor = true;
			this.buttonRgbHair.Click += new global::System.EventHandler(this.buttonRgbHair_Click);
			this.multiViewerHair.AutoTransparency = false;
			this.multiViewerHair.Bitmaps = null;
			this.multiViewerHair.CheckBitmapSize = false;
			this.multiViewerHair.FixedSize = false;
			this.multiViewerHair.FullSizeButton = false;
			this.multiViewerHair.LabelText = "Image n.";
			this.multiViewerHair.Location = new global::System.Drawing.Point(6, 13);
			this.multiViewerHair.Name = "multiViewerHair";
			this.multiViewerHair.ShowButton = false;
			this.multiViewerHair.ShowDeleteButton = false;
			this.multiViewerHair.Size = new global::System.Drawing.Size(256, 301);
			this.multiViewerHair.TabIndex = 5;
			this.viewer2DEyeTexture.AutoTransparency = false;
			this.viewer2DEyeTexture.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DEyeTexture.ButtonStripVisible = false;
			this.viewer2DEyeTexture.CurrentBitmap = null;
			this.viewer2DEyeTexture.ExtendedFormat = false;
			this.viewer2DEyeTexture.FullSizeButton = false;
			this.viewer2DEyeTexture.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DEyeTexture.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DEyeTexture.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DEyeTexture.Location = new global::System.Drawing.Point(268, 33);
			this.viewer2DEyeTexture.Name = "viewer2DEyeTexture";
			this.viewer2DEyeTexture.RemoveButton = false;
			this.viewer2DEyeTexture.ShowButton = false;
			this.viewer2DEyeTexture.ShowButtonChecked = true;
			this.viewer2DEyeTexture.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DEyeTexture.TabIndex = 4;
			this.viewer2DSkinTexture.AutoTransparency = false;
			this.viewer2DSkinTexture.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DSkinTexture.ButtonStripVisible = false;
			this.viewer2DSkinTexture.CurrentBitmap = null;
			this.viewer2DSkinTexture.ExtendedFormat = false;
			this.viewer2DSkinTexture.FullSizeButton = false;
			this.viewer2DSkinTexture.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DSkinTexture.ImageSize = new global::System.Drawing.Size(1024, 1024);
			this.viewer2DSkinTexture.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DSkinTexture.Location = new global::System.Drawing.Point(402, 33);
			this.viewer2DSkinTexture.Name = "viewer2DSkinTexture";
			this.viewer2DSkinTexture.RemoveButton = false;
			this.viewer2DSkinTexture.ShowButton = false;
			this.viewer2DSkinTexture.ShowButtonChecked = true;
			this.viewer2DSkinTexture.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DSkinTexture.TabIndex = 7;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(408, 195);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Skin Color";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSkinColorInfo.AutoSize = true;
			this.labelSkinColorInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.labelSkinColorInfo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSkinColorInfo.Location = new global::System.Drawing.Point(429, 221);
			this.labelSkinColorInfo.Name = "labelSkinColorInfo";
			this.labelSkinColorInfo.Size = new global::System.Drawing.Size(84, 13);
			this.labelSkinColorInfo.TabIndex = 121;
			this.labelSkinColorInfo.Text = "Skin Description";
			this.labelSkinColorInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(308, 221);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Eyes Color";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboEyescolor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEyescolor.FormattingEnabled = true;
			this.comboEyescolor.Items.AddRange(new object[] { "Dark Blue", "Light Blue", "Dark Brown", "Light Brown", "Brown and Green", "Dark Green", "Light Green", "Gray", "Black", "Dark Gray" });
			this.comboEyescolor.Location = new global::System.Drawing.Point(268, 192);
			this.comboEyescolor.Name = "comboEyescolor";
			this.comboEyescolor.Size = new global::System.Drawing.Size(128, 21);
			this.comboEyescolor.TabIndex = 2;
			this.comboEyescolor.SelectedIndexChanged += new global::System.EventHandler(this.comboEyescolor_SelectedIndexChanged);
			this.numericSkinTone.Location = new global::System.Drawing.Point(469, 193);
			global::System.Windows.Forms.NumericUpDown numericUpDown49 = this.numericSkinTone;
			int[] array49 = new int[4];
			array49[0] = 256;
			numericUpDown49.Maximum = new decimal(array49);
			global::System.Windows.Forms.NumericUpDown numericUpDown50 = this.numericSkinTone;
			int[] array50 = new int[4];
			array50[0] = 1;
			numericUpDown50.Minimum = new decimal(array50);
			this.numericSkinTone.Name = "numericSkinTone";
			this.numericSkinTone.Size = new global::System.Drawing.Size(61, 20);
			this.numericSkinTone.TabIndex = 120;
			this.numericSkinTone.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown51 = this.numericSkinTone;
			int[] array51 = new int[4];
			array51[0] = 1;
			numericUpDown51.Value = new decimal(array51);
			this.numericSkinTone.ValueChanged += new global::System.EventHandler(this.numericSkinTone_ValueChanged);
			this.checkShowTexures.AutoSize = true;
			this.checkShowTexures.Location = new global::System.Drawing.Point(3, 7);
			this.checkShowTexures.Name = "checkShowTexures";
			this.checkShowTexures.Size = new global::System.Drawing.Size(97, 17);
			this.checkShowTexures.TabIndex = 0;
			this.checkShowTexures.Text = "Show Textures";
			this.checkShowTexures.UseVisualStyleBackColor = true;
			this.checkShowTexures.CheckedChanged += new global::System.EventHandler(this.checkShowTexures_CheckedChanged);
			this.imageListTabIcons.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListTabIcons.ImageStream");
			this.imageListTabIcons.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageListTabIcons.Images.SetKeyName(0, "Info_16.PNG");
			this.imageListTabIcons.Images.SetKeyName(1, "Star_16.PNG");
			this.imageListTabIcons.Images.SetKeyName(2, "Face_16.PNG");
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = true;
			this.pickUpControl.CreateButtonEnabled = true;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by Team", "by Country", "Free Agents", "Multi Club", "Same Name", "Specific Head" };
			this.pickUpControl.FilterEnabled = true;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = true;
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = true;
			this.pickUpControl.SearchEnabled = true;
			this.pickUpControl.Size = new global::System.Drawing.Size(1357, 25);
			this.pickUpControl.TabIndex = 0;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.tabEditPlayer);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "PlayerForm";
			this.Text = "PlayerForm";
			base.Load += new global::System.EventHandler(this.PlayerForm_Load);
			this.tabEditPlayer.ResumeLayout(false);
			this.pageInfo.ResumeLayout(false);
			this.flowPanelInfo.ResumeLayout(false);
			this.groupPlayerIdentity.ResumeLayout(false);
			this.groupPlayerIdentity.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.playerBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPlayerId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).EndInit();
			this.groupBoxBody.ResumeLayout(false);
			this.groupBoxBody.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericHeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericWeight).EndInit();
			this.groupBoxLook.ResumeLayout(false);
			this.groupBoxLook.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericGkGloves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorAcc1).EndInit();
			this.groupPlayFirTeam.ResumeLayout(false);
			this.groupPlayFirTeam.PerformLayout();
			this.groupIsLoan.ResumeLayout(false);
			this.groupIsLoan.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).EndInit();
			this.groupShoes.ResumeLayout(false);
			this.groupShoes.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesBrand).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesDesign).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.pageSkills.ResumeLayout(false);
			this.flowPanelSkills.ResumeLayout(false);
			this.groupGenerateAttributes.ResumeLayout(false);
			this.groupGenerateAttributes.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackOverallrating).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRandomize).EndInit();
			this.groupGoalkeperSkills.ResumeLayout(false);
			this.groupGoalkeperSkills.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackGkKicking).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackDiving).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPositioning).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackReflexes).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackHandling).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericGoalkeeperSkills).EndInit();
			this.groupDefensiveSkills.ResumeLayout(false);
			this.groupDefensiveSkills.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackInterception).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackSliding).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericDefensiveSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackTackling).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackMarking).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAggression).EndInit();
			this.groupMidfielderSkills.ResumeLayout(false);
			this.groupMidfielderSkills.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackCurve).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackVision).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMidfielderSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackLongPassing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackShortPassing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBallControl).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackCrossing).EndInit();
			this.groupMental.ResumeLayout(false);
			this.groupMental.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericMentalSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPlayerPositioning).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPotential).EndInit();
			this.groupAttackingSkills.ResumeLayout(false);
			this.groupAttackingSkills.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackHeading).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackVolley).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericAttackingSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackFinishing).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackShotPower).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackLongShot).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackDribbling).EndInit();
			this.groupGenericAttributes.ResumeLayout(false);
			this.groupGenericAttributes.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBalance).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAgility).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPhysicalSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackStamina).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackSprintSpeed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackAcceleration).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackStrength).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackReactions).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackJumping).EndInit();
			this.groupFreeKick.ResumeLayout(false);
			this.groupFreeKick.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericSkillMoves).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericFreeKickSkills).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackFreeKick).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackPenalties).EndInit();
			this.groupTraits.ResumeLayout(false);
			this.groupTraits.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.pageFace.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tool3D.ResumeLayout(false);
			this.tool3D.PerformLayout();
			this.groupGenericFace.ResumeLayout(false);
			this.groupGenericFace.PerformLayout();
			this.groupGenericFaceType.ResumeLayout(false);
			this.groupGenericFaceType.PerformLayout();
			this.groupHairModel.ResumeLayout(false);
			this.groupHairModel.PerformLayout();
			this.groupHeadModel.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.groupSpecifiHeadControls.ResumeLayout(false);
			this.groupSpecifiHeadControls.PerformLayout();
			this.groupCommonHeadControls.ResumeLayout(false);
			this.groupCommonHeadControls.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericSkinTone).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400030C RID: 780
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400030D RID: 781
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.TabControl tabEditPlayer;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.TabPage pageInfo;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.TabPage pageSkills;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.TabPage pageFace;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.ImageList imageListTabIcons;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.FlowLayoutPanel flowPanelInfo;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.GroupBox groupPlayerIdentity;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.NumericUpDown numericPlayerId;

		// Token: 0x04000317 RID: 791
		private global::FifaControls.Viewer2D viewer2DPhoto;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Button buttonRandomizeIdentity;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.DateTimePicker dateBirthDate;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label labelBirthdate;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Label labelPlayerId;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.TextBox textSurname;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.TextBox textFirstName;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.ComboBox comboCountry;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.Label labelFirstName;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.Label labelSurame;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.Label labelCountry;

		// Token: 0x04000322 RID: 802
		private global::System.Windows.Forms.Label labelCommonName;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.TextBox textCommonName;

		// Token: 0x04000324 RID: 804
		private global::System.Windows.Forms.TextBox textJerseyName;

		// Token: 0x04000325 RID: 805
		private global::System.Windows.Forms.Label labelJerseyName;

		// Token: 0x04000326 RID: 806
		private global::System.Windows.Forms.BindingSource countryListBindingSource;

		// Token: 0x04000327 RID: 807
		private global::System.Windows.Forms.BindingSource playerBindingSource;

		// Token: 0x04000328 RID: 808
		private global::System.Windows.Forms.GroupBox groupBoxBody;

		// Token: 0x04000329 RID: 809
		private global::System.Windows.Forms.NumericUpDown numericHeight;

		// Token: 0x0400032A RID: 810
		private global::System.Windows.Forms.NumericUpDown numericWeight;

		// Token: 0x0400032B RID: 811
		private global::System.Windows.Forms.Label labelWeight;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.Label labelBody;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.DomainUpDown domainPreferredFoot;

		// Token: 0x0400032E RID: 814
		private global::System.Windows.Forms.Label labelHeight;

		// Token: 0x0400032F RID: 815
		private global::System.Windows.Forms.Label labelPreferredFoot;

		// Token: 0x04000330 RID: 816
		private global::System.Windows.Forms.ComboBox comboBody;

		// Token: 0x04000331 RID: 817
		private global::System.Windows.Forms.GroupBox groupBoxLook;

		// Token: 0x04000332 RID: 818
		public global::System.Windows.Forms.NumericUpDown numericShoesDesign;

		// Token: 0x04000333 RID: 819
		private global::FifaControls.Viewer2D viewer2DShoes;

		// Token: 0x04000334 RID: 820
		private global::System.Windows.Forms.DomainUpDown domainJerseyStyle;

		// Token: 0x04000335 RID: 821
		public global::System.Windows.Forms.NumericUpDown numericShoesBrand;

		// Token: 0x04000336 RID: 822
		private global::System.Windows.Forms.DomainUpDown domainSleeves;

		// Token: 0x04000337 RID: 823
		private global::System.Windows.Forms.PictureBox pictureColorAcc2;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.PictureBox pictureColorAcc3;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.PictureBox pictureColorAcc4;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.PictureBox pictureColorAcc1;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.ComboBox domainAccessory4;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.ComboBox domainAccessory3;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.ComboBox domainAccessory2;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.ComboBox domainAccessory1;

		// Token: 0x0400033F RID: 831
		private global::System.Windows.Forms.Label labelSleeves;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Label labelJerseyStyle;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.Label labelAccesories;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label labelShoes;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Label labelShoesColor;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Label labelShoesType;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.GroupBox groupPlayFirTeam;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.ListView listViewPlayingTeams;

		// Token: 0x04000347 RID: 839
		private global::System.Windows.Forms.ComboBox comboClubTeam;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.Button buttonCallNationalTeam;

		// Token: 0x04000349 RID: 841
		private global::System.Windows.Forms.Button buttonRemoveNationalTeam;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.ImageList imageListTeamLogos;

		// Token: 0x0400034B RID: 843
		private global::System.Windows.Forms.Label labelWinter;

		// Token: 0x0400034C RID: 844
		private global::System.Windows.Forms.ComboBox comboWinterAccessories;

		// Token: 0x0400034D RID: 845
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x0400034E RID: 846
		private global::System.Windows.Forms.FlowLayoutPanel flowPanelSkills;

		// Token: 0x0400034F RID: 847
		private global::System.Windows.Forms.GroupBox groupGenerateAttributes;

		// Token: 0x04000350 RID: 848
		private global::System.Windows.Forms.Label labelRandomize;

		// Token: 0x04000351 RID: 849
		private global::System.Windows.Forms.NumericUpDown numericRandomize;

		// Token: 0x04000352 RID: 850
		private global::System.Windows.Forms.Button buttonRandomAboveAvg;

		// Token: 0x04000353 RID: 851
		private global::System.Windows.Forms.Button buttonRandomBelowAvg;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.Button buttonRandomSuperstar;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Button buttonRandomVeryGood;

		// Token: 0x04000356 RID: 854
		private global::System.Windows.Forms.Button buttonRandomGood;

		// Token: 0x04000357 RID: 855
		private global::System.Windows.Forms.Button buttonRandomAverage;

		// Token: 0x04000358 RID: 856
		private global::System.Windows.Forms.Button buttonRandomPoor;

		// Token: 0x04000359 RID: 857
		private global::System.Windows.Forms.GroupBox groupGoalkeperSkills;

		// Token: 0x0400035A RID: 858
		private global::System.Windows.Forms.Label labelDiving;

		// Token: 0x0400035B RID: 859
		private global::System.Windows.Forms.Label labelPositioning;

		// Token: 0x0400035C RID: 860
		private global::System.Windows.Forms.Label labelReflexes;

		// Token: 0x0400035D RID: 861
		private global::System.Windows.Forms.Label labelHandling;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.TrackBar trackDiving;

		// Token: 0x0400035F RID: 863
		private global::System.Windows.Forms.TrackBar trackPositioning;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Forms.TrackBar trackReflexes;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.TrackBar trackHandling;

		// Token: 0x04000362 RID: 866
		private global::System.Windows.Forms.NumericUpDown numericGoalkeeperSkills;

		// Token: 0x04000363 RID: 867
		private global::System.Windows.Forms.GroupBox groupDefensiveSkills;

		// Token: 0x04000364 RID: 868
		private global::System.Windows.Forms.NumericUpDown numericDefensiveSkills;

		// Token: 0x04000365 RID: 869
		private global::System.Windows.Forms.Label labelAggression;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Forms.Label labelMarking;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.Label labelHeading;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.TrackBar trackHeading;

		// Token: 0x04000369 RID: 873
		private global::System.Windows.Forms.Label labelTackling;

		// Token: 0x0400036A RID: 874
		private global::System.Windows.Forms.TrackBar trackTackling;

		// Token: 0x0400036B RID: 875
		private global::System.Windows.Forms.TrackBar trackMarking;

		// Token: 0x0400036C RID: 876
		private global::System.Windows.Forms.TrackBar trackAggression;

		// Token: 0x0400036D RID: 877
		private global::System.Windows.Forms.GroupBox groupMidfielderSkills;

		// Token: 0x0400036E RID: 878
		private global::System.Windows.Forms.NumericUpDown numericMidfielderSkills;

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Label labelBallControl;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.Label labelCrossing;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.Label labelLongPassing;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.TrackBar trackLongPassing;

		// Token: 0x04000373 RID: 883
		private global::System.Windows.Forms.Label labelShortPassing;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Forms.TrackBar trackShortPassing;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.Forms.TrackBar trackBallControl;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.TrackBar trackCrossing;

		// Token: 0x04000377 RID: 887
		private global::System.Windows.Forms.GroupBox groupAttackingSkills;

		// Token: 0x04000378 RID: 888
		private global::System.Windows.Forms.NumericUpDown numericAttackingSkills;

		// Token: 0x04000379 RID: 889
		private global::System.Windows.Forms.Label labelDribbling;

		// Token: 0x0400037A RID: 890
		private global::System.Windows.Forms.Label labelLongShot;

		// Token: 0x0400037B RID: 891
		private global::System.Windows.Forms.Label labelFreeKick;

		// Token: 0x0400037C RID: 892
		private global::System.Windows.Forms.Label labelShotPower;

		// Token: 0x0400037D RID: 893
		private global::System.Windows.Forms.Label labelFinishing;

		// Token: 0x0400037E RID: 894
		private global::System.Windows.Forms.TrackBar trackFinishing;

		// Token: 0x0400037F RID: 895
		private global::System.Windows.Forms.TrackBar trackShotPower;

		// Token: 0x04000380 RID: 896
		private global::System.Windows.Forms.TrackBar trackLongShot;

		// Token: 0x04000381 RID: 897
		private global::System.Windows.Forms.TrackBar trackFreeKick;

		// Token: 0x04000382 RID: 898
		private global::System.Windows.Forms.TrackBar trackDribbling;

		// Token: 0x04000383 RID: 899
		private global::System.Windows.Forms.GroupBox groupGenericAttributes;

		// Token: 0x04000384 RID: 900
		private global::System.Windows.Forms.Label labelPlayerPositioning;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.TrackBar trackPlayerPositioning;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Forms.Label labelPotential;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Forms.TrackBar trackPotential;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Forms.NumericUpDown numericPhysicalSkills;

		// Token: 0x04000389 RID: 905
		private global::System.Windows.Forms.Label labelReactions;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.Label labelStrength;

		// Token: 0x0400038B RID: 907
		private global::System.Windows.Forms.Label labelStamina;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.TrackBar trackStamina;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.Label labelSprintSpeed;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.TrackBar trackSprintSpeed;

		// Token: 0x0400038F RID: 911
		private global::System.Windows.Forms.Label labelAcceleration;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.TrackBar trackAcceleration;

		// Token: 0x04000391 RID: 913
		private global::System.Windows.Forms.TrackBar trackStrength;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.Forms.TrackBar trackReactions;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.Label labelGkKick;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Forms.TrackBar trackGkKicking;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.Label labelAgility;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.TrackBar trackAgility;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.Label labelBalance;

		// Token: 0x04000398 RID: 920
		private global::System.Windows.Forms.TrackBar trackBalance;

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Forms.Label labelJumping;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.TrackBar trackJumping;

		// Token: 0x0400039B RID: 923
		private global::System.Windows.Forms.Label labelPenalties;

		// Token: 0x0400039C RID: 924
		private global::System.Windows.Forms.TrackBar trackPenalties;

		// Token: 0x0400039D RID: 925
		private global::System.Windows.Forms.Label labelSliding;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.TrackBar trackSliding;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.Label labelVision;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.TrackBar trackVision;

		// Token: 0x040003A1 RID: 929
		private global::System.Windows.Forms.Label labelVolley;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.TrackBar trackVolley;

		// Token: 0x040003A3 RID: 931
		private global::System.Windows.Forms.Label labelOverallrating;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.TrackBar trackOverallrating;

		// Token: 0x040003A5 RID: 933
		private global::System.Windows.Forms.GroupBox groupMental;

		// Token: 0x040003A6 RID: 934
		private global::System.Windows.Forms.Label labelFreeKickStart;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Forms.ComboBox comboFreeKickStart;

		// Token: 0x040003A8 RID: 936
		private global::System.Windows.Forms.Label labelPenaltyKick;

		// Token: 0x040003A9 RID: 937
		private global::System.Windows.Forms.ComboBox comboPenaltyKick;

		// Token: 0x040003AA RID: 938
		private global::System.Windows.Forms.Label labelPenaltyMove;

		// Token: 0x040003AB RID: 939
		private global::System.Windows.Forms.ComboBox comboPenaltyMove;

		// Token: 0x040003AC RID: 940
		private global::System.Windows.Forms.Label labelPenaltyStart;

		// Token: 0x040003AD RID: 941
		private global::System.Windows.Forms.ComboBox comboPenaltyStart;

		// Token: 0x040003AE RID: 942
		private global::System.Windows.Forms.GroupBox groupFreeKick;

		// Token: 0x040003AF RID: 943
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.SplitContainer splitContainer3;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.GroupBox groupGenericFace;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.GroupBox groupHairModel;

		// Token: 0x040003B4 RID: 948
		private global::System.Windows.Forms.ComboBox comboHeadband;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.ComboBox comboAfro;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.ComboBox comboLong;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.ComboBox comboMedium;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.ComboBox comboModern;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Forms.ComboBox comboShort;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.ComboBox comboVeryShort;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Forms.ComboBox comboShaven;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.RadioButton radioHeadband;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.RadioButton radioShaven;

		// Token: 0x040003BE RID: 958
		private global::System.Windows.Forms.RadioButton radioAfro;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Forms.RadioButton radioLong;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.RadioButton radioMedium;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Forms.RadioButton radioModern;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Forms.RadioButton radioShort;

		// Token: 0x040003C3 RID: 963
		private global::System.Windows.Forms.RadioButton radioVeryShort;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.ComboBox domainHairColor;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Forms.Label labelHairColor;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Forms.GroupBox groupHeadModel;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Forms.ComboBox comboLatinModels;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.RadioButton radioButtonLatin;

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.Forms.ComboBox comboAsiaticModels;

		// Token: 0x040003CA RID: 970
		private global::System.Windows.Forms.RadioButton radioButtonAsiatic;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Forms.ComboBox comboAfricanModels;

		// Token: 0x040003CC RID: 972
		private global::System.Windows.Forms.RadioButton radioButtonAfrican;

		// Token: 0x040003CD RID: 973
		private global::System.Windows.Forms.RadioButton radioButtonCaucasic;

		// Token: 0x040003CE RID: 974
		private global::System.Windows.Forms.ComboBox comboCaucasicModels;

		// Token: 0x040003CF RID: 975
		private global::System.Windows.Forms.Button buttonRandomizeAppearance;

		// Token: 0x040003D0 RID: 976
		private global::System.Windows.Forms.ComboBox comboEyescolor;

		// Token: 0x040003D1 RID: 977
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003D2 RID: 978
		private global::System.Windows.Forms.ComboBox comboFacialHairColor;

		// Token: 0x040003D3 RID: 979
		private global::System.Windows.Forms.Label labelFacialHairColor;

		// Token: 0x040003D4 RID: 980
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003D5 RID: 981
		private global::System.Windows.Forms.ComboBox comboSkintype;

		// Token: 0x040003D6 RID: 982
		private global::System.Windows.Forms.Label labelSkintype;

		// Token: 0x040003D7 RID: 983
		private global::System.Windows.Forms.ComboBox comboSideburns;

		// Token: 0x040003D8 RID: 984
		private global::System.Windows.Forms.Label labelSideburns;

		// Token: 0x040003D9 RID: 985
		private global::System.Windows.Forms.ComboBox domainFacialHair;

		// Token: 0x040003DA RID: 986
		private global::System.Windows.Forms.Label labelHeadType;

		// Token: 0x040003DB RID: 987
		private global::System.Windows.Forms.Label labelHairType;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.Label labelFacialHair;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040003DE RID: 990
		private global::System.Windows.Forms.Label labelPreferredPositions;

		// Token: 0x040003DF RID: 991
		private global::System.Windows.Forms.ComboBox comboPreferredPosition4;

		// Token: 0x040003E0 RID: 992
		private global::System.Windows.Forms.ComboBox comboPreferredPosition3;

		// Token: 0x040003E1 RID: 993
		private global::System.Windows.Forms.ComboBox comboPreferredPosition2;

		// Token: 0x040003E2 RID: 994
		private global::System.Windows.Forms.ComboBox comboPreferredPosition1;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.Forms.DomainUpDown domainInternationalReputation;

		// Token: 0x040003E4 RID: 996
		private global::System.Windows.Forms.Label labelInternationalReputation;

		// Token: 0x040003E5 RID: 997
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x040003E6 RID: 998
		private global::System.Windows.Forms.ToolStrip tool3D;

		// Token: 0x040003E7 RID: 999
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x040003E8 RID: 1000
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040003E9 RID: 1001
		private global::System.Windows.Forms.ToolStripButton buttonImport3DHairModel;

		// Token: 0x040003EA RID: 1002
		private global::System.Windows.Forms.ToolStripButton buttonExport3DHairModel;

		// Token: 0x040003EB RID: 1003
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040003EC RID: 1004
		private global::System.Windows.Forms.ToolStripButton buttonRemove3DHeadModel;

		// Token: 0x040003ED RID: 1005
		private global::System.Windows.Forms.Label labelEyeBow;

		// Token: 0x040003EE RID: 1006
		private global::System.Windows.Forms.ComboBox comboEyeBow;

		// Token: 0x040003EF RID: 1007
		private global::System.Windows.Forms.CheckBox checkShowTexures;

		// Token: 0x040003F0 RID: 1008
		private global::FifaControls.Viewer2D viewer2DEyeTexture;

		// Token: 0x040003F1 RID: 1009
		private global::FifaControls.Viewer2D viewer2DPlayerGui;

		// Token: 0x040003F2 RID: 1010
		private global::System.Windows.Forms.ComboBox comboWeakFoot;

		// Token: 0x040003F3 RID: 1011
		private global::System.Windows.Forms.Label labelWeakFoot;

		// Token: 0x040003F4 RID: 1012
		private global::System.Windows.Forms.CheckBox checkHasGenericFace;

		// Token: 0x040003F5 RID: 1013
		private global::System.Windows.Forms.GroupBox groupGenericFaceType;

		// Token: 0x040003F6 RID: 1014
		private global::System.Windows.Forms.ToolStripButton buttonImport3DHeadModel;

		// Token: 0x040003F7 RID: 1015
		private global::System.Windows.Forms.ToolStripButton buttonExport3DHeadModel;

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.Forms.NumericUpDown numericMentalSkills;

		// Token: 0x040003F9 RID: 1017
		private global::System.Windows.Forms.NumericUpDown numericFreeKickSkills;

		// Token: 0x040003FA RID: 1018
		private global::System.Windows.Forms.Label labelCurve;

		// Token: 0x040003FB RID: 1019
		private global::System.Windows.Forms.TrackBar trackCurve;

		// Token: 0x040003FC RID: 1020
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003FD RID: 1021
		private global::System.Windows.Forms.ComboBox comboGkKickStyle;

		// Token: 0x040003FE RID: 1022
		private global::System.Windows.Forms.ImageList imageListStars;

		// Token: 0x040003FF RID: 1023
		private global::System.Windows.Forms.Label labelSkillMoves;

		// Token: 0x04000400 RID: 1024
		private global::System.Windows.Forms.Label labelSkillsStars;

		// Token: 0x04000401 RID: 1025
		private global::System.Windows.Forms.NumericUpDown numericSkillMoves;

		// Token: 0x04000402 RID: 1026
		private global::System.Windows.Forms.ToolStripButton toolPhoto;

		// Token: 0x04000403 RID: 1027
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000404 RID: 1028
		public global::System.Windows.Forms.NumericUpDown numericGkGloves;

		// Token: 0x04000405 RID: 1029
		private global::System.Windows.Forms.Label labelGkGloves;

		// Token: 0x04000406 RID: 1030
		private global::System.Windows.Forms.ToolStripButton buttonSwitchRenderingMode;

		// Token: 0x04000407 RID: 1031
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000408 RID: 1032
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000409 RID: 1033
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairAhead;

		// Token: 0x0400040A RID: 1034
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairUp;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairBack;

		// Token: 0x0400040C RID: 1036
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairDown;

		// Token: 0x0400040D RID: 1037
		private global::System.Windows.Forms.ToolStripButton buttonSaveHair;

		// Token: 0x0400040E RID: 1038
		private global::System.Windows.Forms.ToolStripButton buttonRemoveHairModel;

		// Token: 0x0400040F RID: 1039
		private global::System.Windows.Forms.ToolStripButton buttonShowJesey;

		// Token: 0x04000410 RID: 1040
		private global::FifaControls.MultiViewer2D multiViewerHair;

		// Token: 0x04000411 RID: 1041
		private global::System.Windows.Forms.GroupBox groupTraits;

		// Token: 0x04000412 RID: 1042
		private global::System.Windows.Forms.CheckBox checkLongThrower;

		// Token: 0x04000413 RID: 1043
		private global::System.Windows.Forms.CheckBox checkGiantThrower;

		// Token: 0x04000414 RID: 1044
		private global::System.Windows.Forms.CheckBox checkAvoidsWeakFoot;

		// Token: 0x04000415 RID: 1045
		private global::System.Windows.Forms.CheckBox checkInjuryFree;

		// Token: 0x04000416 RID: 1046
		private global::System.Windows.Forms.CheckBox checkPowerFreeKick;

		// Token: 0x04000417 RID: 1047
		private global::System.Windows.Forms.CheckBox checkSelfish;

		// Token: 0x04000418 RID: 1048
		private global::System.Windows.Forms.CheckBox checkPlaymaker;

		// Token: 0x04000419 RID: 1049
		private global::System.Windows.Forms.CheckBox checkTechnicaldribbler;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Forms.CheckBox checkLeadership;

		// Token: 0x0400041B RID: 1051
		private global::System.Windows.Forms.CheckBox checkPuncher;

		// Token: 0x0400041C RID: 1052
		private global::System.Windows.Forms.CheckBox checkDiver;

		// Token: 0x0400041D RID: 1053
		private global::System.Windows.Forms.CheckBox checkDivesintotackles;

		// Token: 0x0400041E RID: 1054
		private global::System.Windows.Forms.CheckBox checkLongshottaker;

		// Token: 0x0400041F RID: 1055
		private global::System.Windows.Forms.CheckBox checkHighClubIdentification;

		// Token: 0x04000420 RID: 1056
		private global::System.Windows.Forms.CheckBox checkPushesupforcorners;

		// Token: 0x04000421 RID: 1057
		private global::System.Windows.Forms.CheckBox checkEarlycrosser;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.CheckBox checkInjuryProne;

		// Token: 0x04000423 RID: 1059
		private global::System.Windows.Forms.CheckBox checkBeatsOffsideTrap;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.CheckBox checkLongPasser;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.CheckBox checkFlair;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.CheckBox checkFinesseShot;

		// Token: 0x04000427 RID: 1063
		private global::System.Windows.Forms.CheckBox checkArguesWithOfficials;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.CheckBox checkSwervePasser;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.CheckBox checkCornerSpecialist;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.CheckBox checkPowerHeader;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Forms.CheckBox checkGkLongThrower;

		// Token: 0x0400042C RID: 1068
		private global::System.Windows.Forms.CheckBox checkTeamPlayer;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.DateTimePicker dateJoiningDate;

		// Token: 0x0400042E RID: 1070
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400042F RID: 1071
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000430 RID: 1072
		private global::System.Windows.Forms.ComboBox comboGkSaveStyle;

		// Token: 0x04000431 RID: 1073
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000432 RID: 1074
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000433 RID: 1075
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000434 RID: 1076
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000435 RID: 1077
		private global::System.Windows.Forms.NumericUpDown numericUpDown3;

		// Token: 0x04000436 RID: 1078
		private global::System.Windows.Forms.NumericUpDown numericUpDown4;

		// Token: 0x04000437 RID: 1079
		private global::System.Windows.Forms.DomainUpDown domainSocksStyle;

		// Token: 0x04000438 RID: 1080
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000439 RID: 1081
		private global::System.Windows.Forms.ComboBox comboAttackWorkRate;

		// Token: 0x0400043A RID: 1082
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400043B RID: 1083
		private global::System.Windows.Forms.ComboBox comboDefensiveWorkrate;

		// Token: 0x0400043C RID: 1084
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400043D RID: 1085
		private global::System.Windows.Forms.CheckBox checkTrainingPants;

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.GroupBox groupShoes;

		// Token: 0x0400043F RID: 1087
		private global::System.Windows.Forms.NumericUpDown numericSkinTone;

		// Token: 0x04000440 RID: 1088
		private global::FifaControls.Viewer2D viewer2DSkinTexture;

		// Token: 0x04000441 RID: 1089
		private global::System.Windows.Forms.Label labelSkinColorInfo;

		// Token: 0x04000442 RID: 1090
		private global::System.Windows.Forms.Button buttonRgbHair;

		// Token: 0x04000443 RID: 1091
		private global::System.Windows.Forms.GroupBox groupIsLoan;

		// Token: 0x04000444 RID: 1092
		private global::System.Windows.Forms.CheckBox checkIsLoan;

		// Token: 0x04000445 RID: 1093
		private global::System.Windows.Forms.DateTimePicker dateLoanEnd;

		// Token: 0x04000446 RID: 1094
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000447 RID: 1095
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000448 RID: 1096
		private global::System.Windows.Forms.ComboBox comboTeamLoanedFrom;

		// Token: 0x04000449 RID: 1097
		private global::System.Windows.Forms.BindingSource teamListBindingSource;

		// Token: 0x0400044A RID: 1098
		private global::System.Windows.Forms.Label label1ShoesType;

		// Token: 0x0400044B RID: 1099
		private global::System.Windows.Forms.PictureBox pictureColorShoes2;

		// Token: 0x0400044C RID: 1100
		private global::System.Windows.Forms.PictureBox pictureColorShoes1;

		// Token: 0x0400044D RID: 1101
		private global::System.Windows.Forms.CheckBox checkJerseyFit;

		// Token: 0x0400044E RID: 1102
		private global::System.Windows.Forms.Label labelInterception;

		// Token: 0x0400044F RID: 1103
		private global::System.Windows.Forms.TrackBar trackInterception;

		// Token: 0x04000450 RID: 1104
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairLeft;

		// Token: 0x04000451 RID: 1105
		private global::System.Windows.Forms.ToolStripButton buttonMoveHairRight;

		// Token: 0x04000452 RID: 1106
		private global::System.Windows.Forms.ToolStripButton buttonMakeHairCloser;

		// Token: 0x04000453 RID: 1107
		private global::System.Windows.Forms.ToolStripButton buttonMakeHairWider;

		// Token: 0x04000454 RID: 1108
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000455 RID: 1109
		private global::System.Windows.Forms.CheckBox checkGKFlatKick;

		// Token: 0x04000456 RID: 1110
		private global::System.Windows.Forms.CheckBox checkDrivenPass;

		// Token: 0x04000457 RID: 1111
		private global::System.Windows.Forms.CheckBox checkDivingHeader;

		// Token: 0x04000458 RID: 1112
		private global::System.Windows.Forms.CheckBox checkBycicleKick;

		// Token: 0x04000459 RID: 1113
		private global::System.Windows.Forms.CheckBox checkChipperPenalty;

		// Token: 0x0400045A RID: 1114
		private global::System.Windows.Forms.CheckBox checkStutterPenalty;

		// Token: 0x0400045B RID: 1115
		private global::System.Windows.Forms.CheckBox checkFancyFlicks;

		// Token: 0x0400045C RID: 1116
		private global::System.Windows.Forms.CheckBox checkFancyPasses;

		// Token: 0x0400045D RID: 1117
		private global::System.Windows.Forms.CheckBox checkFancyFeet;

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Forms.CheckBox checkGKOneonOne;

		// Token: 0x0400045F RID: 1119
		private global::System.Windows.Forms.CheckBox checkAcrobaticClearance;

		// Token: 0x04000460 RID: 1120
		private global::System.Windows.Forms.CheckBox checkSecondWind;

		// Token: 0x04000461 RID: 1121
		private global::System.Windows.Forms.CheckBox checkCrowdFavourite;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.CheckBox checkInflexible;

		// Token: 0x04000463 RID: 1123
		private global::FifaControls.MultiViewer2D multiViewerFace;

		// Token: 0x04000464 RID: 1124
		private global::System.Windows.Forms.Button buttonHairSelection;

		// Token: 0x04000465 RID: 1125
		private global::System.Windows.Forms.CheckBox checkUsingRevMod;

		// Token: 0x04000466 RID: 1126
		private global::System.Windows.Forms.RadioButton radioButtonGenderFemale;

		// Token: 0x04000467 RID: 1127
		private global::System.Windows.Forms.RadioButton radioButtonGenderMale;

		// Token: 0x04000468 RID: 1128
		private global::System.Windows.Forms.CheckBox checkHighQaualityFace;

		// Token: 0x04000469 RID: 1129
		private global::System.Windows.Forms.ComboBox comboFemaleModels;

		// Token: 0x0400046A RID: 1130
		private global::System.Windows.Forms.RadioButton radioButtonFemale;

		// Token: 0x0400046B RID: 1131
		private global::System.Windows.Forms.RadioButton radioButtonFemaleHair;

		// Token: 0x0400046C RID: 1132
		private global::System.Windows.Forms.ComboBox comboFemaleHair;

		// Token: 0x0400046D RID: 1133
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400046E RID: 1134
		private global::System.Windows.Forms.ComboBox comboFaceposer;

		// Token: 0x0400046F RID: 1135
		private global::System.Windows.Forms.GroupBox groupCommonHeadControls;

		// Token: 0x04000470 RID: 1136
		private global::System.Windows.Forms.GroupBox groupSpecifiHeadControls;

		// Token: 0x04000471 RID: 1137
		private global::FifaControls.Viewer2D viewer2DTattoos;

		// Token: 0x04000472 RID: 1138
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000473 RID: 1139
		private global::System.Windows.Forms.NumericUpDown numericUpDown5;

		// Token: 0x04000474 RID: 1140
		private global::System.Windows.Forms.Label label15;
	}
}
