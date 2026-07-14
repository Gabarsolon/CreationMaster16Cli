namespace CreationMaster
{
	// Token: 0x02000008 RID: 8
	public partial class LeagueForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00015CBB File Offset: 0x00013EBB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00015CDC File Offset: 0x00013EDC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.LeagueForm));
			this.flowPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupBoxTeams = new global::System.Windows.Forms.GroupBox();
			this.listViewPlayingTeams = new global::System.Windows.Forms.ListView();
			this.imageListTeamLogos = new global::System.Windows.Forms.ImageList(this.components);
			this.toolStripTeamAvailable = new global::System.Windows.Forms.ToolStrip();
			this.separatorBegin = new global::System.Windows.Forms.ToolStripSeparator();
			this.comboTeamAvailable = new global::System.Windows.Forms.ToolStripComboBox();
			this.separatorButtons = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonAddTeam = new global::System.Windows.Forms.ToolStripButton();
			this.buttonReplaceTeam = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRemoveTeam = new global::System.Windows.Forms.ToolStripButton();
			this.separatorShowLogo = new global::System.Windows.Forms.ToolStripSeparator();
			this.checkShowTeamLogo = new global::System.Windows.Forms.ToolStripButton();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.buttonreplicateLeagueLogo512x128 = new global::System.Windows.Forms.Button();
			this.viewer2DLeague512x128Logo = new global::FifaControls.Viewer2D();
			this.buttonreplicateLeagueSmallLogo = new global::System.Windows.Forms.Button();
			this.buttonreplicateLeagueTinyLogo = new global::System.Windows.Forms.Button();
			this.viewer2DLeagueTinyLogo = new global::FifaControls.Viewer2D();
			this.viewer2DLeagueSmallLogo = new global::FifaControls.Viewer2D();
			this.viewer2DLeagueAnimLogo = new global::FifaControls.Viewer2D();
			this.groupBoxNames = new global::System.Windows.Forms.GroupBox();
			this.comboLeaguePrestige = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textLeagueFullName = new global::System.Windows.Forms.TextBox();
			this.leagueBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelLeagueFullName = new global::System.Windows.Forms.Label();
			this.labelLeagueId = new global::System.Windows.Forms.Label();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.numericBoardOutcome5 = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.numericBoardOutcome4 = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.numericBoardOutcome3 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numericBoardOutcome2 = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericBoardOutcome1 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textLeagueShortName = new global::System.Windows.Forms.TextBox();
			this.labelLeagueShortName = new global::System.Windows.Forms.Label();
			this.textDatabaseLeagueName = new global::System.Windows.Forms.TextBox();
			this.comboLeagueCountry = new global::System.Windows.Forms.ComboBox();
			this.labelDatabaseLeagueName = new global::System.Windows.Forms.Label();
			this.numericLeagueId = new global::System.Windows.Forms.NumericUpDown();
			this.numericLeagueLevel = new global::System.Windows.Forms.NumericUpDown();
			this.labelCountry = new global::System.Windows.Forms.Label();
			this.labelLeagueLevel = new global::System.Windows.Forms.Label();
			this.groupLeaguePlayerTuning = new global::System.Windows.Forms.GroupBox();
			this.buttonLeaguePlayerMinus = new global::System.Windows.Forms.Button();
			this.buttonLeaguePlayerPlus = new global::System.Windows.Forms.Button();
			this.groupSwitchLeagues = new global::System.Windows.Forms.GroupBox();
			this.labelThisLeague = new global::System.Windows.Forms.Label();
			this.buttonSwitchLeagueIds = new global::System.Windows.Forms.Button();
			this.comboSwitchLeagues = new global::System.Windows.Forms.ComboBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.countryListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.flowPanel.SuspendLayout();
			this.groupBoxTeams.SuspendLayout();
			this.toolStripTeamAvailable.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBoxNames.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.leagueBindingSource).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueLevel).BeginInit();
			this.groupLeaguePlayerTuning.SuspendLayout();
			this.groupSwitchLeagues.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).BeginInit();
			base.SuspendLayout();
			this.flowPanel.AutoScroll = true;
			this.flowPanel.Controls.Add(this.groupBoxTeams);
			this.flowPanel.Controls.Add(this.groupBox3);
			this.flowPanel.Controls.Add(this.groupBoxNames);
			this.flowPanel.Controls.Add(this.groupLeaguePlayerTuning);
			this.flowPanel.Controls.Add(this.groupSwitchLeagues);
			this.flowPanel.Controls.Add(this.button1);
			this.flowPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowPanel.Location = new global::System.Drawing.Point(0, 25);
			this.flowPanel.Name = "flowPanel";
			this.flowPanel.Size = new global::System.Drawing.Size(1165, 755);
			this.flowPanel.TabIndex = 2;
			this.groupBoxTeams.Controls.Add(this.listViewPlayingTeams);
			this.groupBoxTeams.Controls.Add(this.toolStripTeamAvailable);
			this.groupBoxTeams.Location = new global::System.Drawing.Point(3, 3);
			this.groupBoxTeams.Name = "groupBoxTeams";
			this.groupBoxTeams.Size = new global::System.Drawing.Size(467, 454);
			this.groupBoxTeams.TabIndex = 0;
			this.groupBoxTeams.TabStop = false;
			this.groupBoxTeams.Text = "Teams";
			this.listViewPlayingTeams.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listViewPlayingTeams.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPlayingTeams.FullRowSelect = true;
			this.listViewPlayingTeams.GridLines = true;
			this.listViewPlayingTeams.HideSelection = false;
			this.listViewPlayingTeams.LargeImageList = this.imageListTeamLogos;
			this.listViewPlayingTeams.Location = new global::System.Drawing.Point(3, 41);
			this.listViewPlayingTeams.MultiSelect = false;
			this.listViewPlayingTeams.Name = "listViewPlayingTeams";
			this.listViewPlayingTeams.Size = new global::System.Drawing.Size(461, 410);
			this.listViewPlayingTeams.TabIndex = 0;
			this.listViewPlayingTeams.UseCompatibleStateImageBehavior = false;
			this.listViewPlayingTeams.DoubleClick += new global::System.EventHandler(this.listViewPlayingTeams_DoubleClick);
			this.imageListTeamLogos.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListTeamLogos.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imageListTeamLogos.TransparentColor = global::System.Drawing.Color.Transparent;
			this.toolStripTeamAvailable.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripTeamAvailable.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.separatorBegin, this.comboTeamAvailable, this.separatorButtons, this.buttonAddTeam, this.buttonReplaceTeam, this.buttonRemoveTeam, this.separatorShowLogo, this.checkShowTeamLogo });
			this.toolStripTeamAvailable.Location = new global::System.Drawing.Point(3, 16);
			this.toolStripTeamAvailable.Name = "toolStripTeamAvailable";
			this.toolStripTeamAvailable.Size = new global::System.Drawing.Size(461, 25);
			this.toolStripTeamAvailable.TabIndex = 124;
			this.separatorBegin.Name = "separatorBegin";
			this.separatorBegin.Size = new global::System.Drawing.Size(6, 25);
			this.comboTeamAvailable.DropDownHeight = 256;
			this.comboTeamAvailable.IntegralHeight = false;
			this.comboTeamAvailable.MaxDropDownItems = 16;
			this.comboTeamAvailable.Name = "comboTeamAvailable";
			this.comboTeamAvailable.Size = new global::System.Drawing.Size(150, 25);
			this.separatorButtons.Name = "separatorButtons";
			this.separatorButtons.Size = new global::System.Drawing.Size(6, 25);
			this.buttonAddTeam.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonAddTeam.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonAddTeam.Image");
			this.buttonAddTeam.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonAddTeam.Name = "buttonAddTeam";
			this.buttonAddTeam.Size = new global::System.Drawing.Size(23, 22);
			this.buttonAddTeam.Text = "Add";
			this.buttonAddTeam.Click += new global::System.EventHandler(this.buttonAddTeam_Click);
			this.buttonReplaceTeam.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonReplaceTeam.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonReplaceTeam.Image");
			this.buttonReplaceTeam.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonReplaceTeam.Name = "buttonReplaceTeam";
			this.buttonReplaceTeam.Size = new global::System.Drawing.Size(23, 22);
			this.buttonReplaceTeam.Text = "Replace";
			this.buttonReplaceTeam.Click += new global::System.EventHandler(this.buttonReplaceTeam_Click);
			this.buttonRemoveTeam.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemoveTeam.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemoveTeam.Image");
			this.buttonRemoveTeam.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemoveTeam.Name = "buttonRemoveTeam";
			this.buttonRemoveTeam.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemoveTeam.Text = "Remove";
			this.buttonRemoveTeam.Click += new global::System.EventHandler(this.buttonRemoveTeam_Click);
			this.separatorShowLogo.Name = "separatorShowLogo";
			this.separatorShowLogo.Size = new global::System.Drawing.Size(6, 25);
			this.checkShowTeamLogo.Checked = true;
			this.checkShowTeamLogo.CheckOnClick = true;
			this.checkShowTeamLogo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkShowTeamLogo.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.checkShowTeamLogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkShowTeamLogo.Image");
			this.checkShowTeamLogo.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.checkShowTeamLogo.Name = "checkShowTeamLogo";
			this.checkShowTeamLogo.Size = new global::System.Drawing.Size(102, 22);
			this.checkShowTeamLogo.Text = "Show Team Logo";
			this.checkShowTeamLogo.Click += new global::System.EventHandler(this.checkShowTeamLogo_CheckedChanged);
			this.groupBox3.Controls.Add(this.buttonreplicateLeagueLogo512x128);
			this.groupBox3.Controls.Add(this.viewer2DLeague512x128Logo);
			this.groupBox3.Controls.Add(this.buttonreplicateLeagueSmallLogo);
			this.groupBox3.Controls.Add(this.buttonreplicateLeagueTinyLogo);
			this.groupBox3.Controls.Add(this.viewer2DLeagueTinyLogo);
			this.groupBox3.Controls.Add(this.viewer2DLeagueSmallLogo);
			this.groupBox3.Controls.Add(this.viewer2DLeagueAnimLogo);
			this.groupBox3.Location = new global::System.Drawing.Point(476, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(532, 454);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Logos";
			this.buttonreplicateLeagueLogo512x128.Location = new global::System.Drawing.Point(138, 426);
			this.buttonreplicateLeagueLogo512x128.Name = "buttonreplicateLeagueLogo512x128";
			this.buttonreplicateLeagueLogo512x128.Size = new global::System.Drawing.Size(70, 23);
			this.buttonreplicateLeagueLogo512x128.TabIndex = 159;
			this.buttonreplicateLeagueLogo512x128.Text = "Replicate";
			this.buttonreplicateLeagueLogo512x128.UseVisualStyleBackColor = true;
			this.buttonreplicateLeagueLogo512x128.Click += new global::System.EventHandler(this.buttonreplicateLeagueLogo512x128_Click);
			this.viewer2DLeague512x128Logo.AutoTransparency = true;
			this.viewer2DLeague512x128Logo.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DLeague512x128Logo.ButtonStripVisible = true;
			this.viewer2DLeague512x128Logo.CurrentBitmap = null;
			this.viewer2DLeague512x128Logo.ExtendedFormat = false;
			this.viewer2DLeague512x128Logo.FullSizeButton = false;
			this.viewer2DLeague512x128Logo.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DLeague512x128Logo.ImageSize = new global::System.Drawing.Size(512, 128);
			this.viewer2DLeague512x128Logo.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DLeague512x128Logo.Location = new global::System.Drawing.Point(6, 297);
			this.viewer2DLeague512x128Logo.Name = "viewer2DLeague512x128Logo";
			this.viewer2DLeague512x128Logo.RemoveButton = true;
			this.viewer2DLeague512x128Logo.ShowButton = false;
			this.viewer2DLeague512x128Logo.ShowButtonChecked = true;
			this.viewer2DLeague512x128Logo.Size = new global::System.Drawing.Size(512, 153);
			this.viewer2DLeague512x128Logo.TabIndex = 158;
			this.buttonreplicateLeagueSmallLogo.Location = new global::System.Drawing.Point(399, 268);
			this.buttonreplicateLeagueSmallLogo.Name = "buttonreplicateLeagueSmallLogo";
			this.buttonreplicateLeagueSmallLogo.Size = new global::System.Drawing.Size(70, 23);
			this.buttonreplicateLeagueSmallLogo.TabIndex = 158;
			this.buttonreplicateLeagueSmallLogo.Text = "Replicate";
			this.buttonreplicateLeagueSmallLogo.UseVisualStyleBackColor = true;
			this.buttonreplicateLeagueSmallLogo.Visible = false;
			this.buttonreplicateLeagueSmallLogo.Click += new global::System.EventHandler(this.buttonreplicateLeagueSmallLogo_Click);
			this.buttonreplicateLeagueTinyLogo.Location = new global::System.Drawing.Point(399, 85);
			this.buttonreplicateLeagueTinyLogo.Name = "buttonreplicateLeagueTinyLogo";
			this.buttonreplicateLeagueTinyLogo.Size = new global::System.Drawing.Size(75, 23);
			this.buttonreplicateLeagueTinyLogo.TabIndex = 3;
			this.buttonreplicateLeagueTinyLogo.Text = "Replicate";
			this.buttonreplicateLeagueTinyLogo.UseVisualStyleBackColor = true;
			this.buttonreplicateLeagueTinyLogo.Click += new global::System.EventHandler(this.buttonreplicateLeagueTinyLogo_Click);
			this.viewer2DLeagueTinyLogo.AutoTransparency = true;
			this.viewer2DLeagueTinyLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DLeagueTinyLogo.ButtonStripVisible = true;
			this.viewer2DLeagueTinyLogo.CurrentBitmap = null;
			this.viewer2DLeagueTinyLogo.ExtendedFormat = false;
			this.viewer2DLeagueTinyLogo.FullSizeButton = false;
			this.viewer2DLeagueTinyLogo.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DLeagueTinyLogo.ImageSize = new global::System.Drawing.Size(256, 64);
			this.viewer2DLeagueTinyLogo.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DLeagueTinyLogo.Location = new global::System.Drawing.Point(268, 19);
			this.viewer2DLeagueTinyLogo.Name = "viewer2DLeagueTinyLogo";
			this.viewer2DLeagueTinyLogo.RemoveButton = true;
			this.viewer2DLeagueTinyLogo.ShowButton = false;
			this.viewer2DLeagueTinyLogo.ShowButtonChecked = true;
			this.viewer2DLeagueTinyLogo.Size = new global::System.Drawing.Size(256, 89);
			this.viewer2DLeagueTinyLogo.TabIndex = 2;
			this.viewer2DLeagueSmallLogo.AutoTransparency = true;
			this.viewer2DLeagueSmallLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DLeagueSmallLogo.ButtonStripVisible = true;
			this.viewer2DLeagueSmallLogo.CurrentBitmap = null;
			this.viewer2DLeagueSmallLogo.ExtendedFormat = false;
			this.viewer2DLeagueSmallLogo.FullSizeButton = false;
			this.viewer2DLeagueSmallLogo.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DLeagueSmallLogo.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DLeagueSmallLogo.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DLeagueSmallLogo.Location = new global::System.Drawing.Point(268, 114);
			this.viewer2DLeagueSmallLogo.Name = "viewer2DLeagueSmallLogo";
			this.viewer2DLeagueSmallLogo.RemoveButton = true;
			this.viewer2DLeagueSmallLogo.ShowButton = false;
			this.viewer2DLeagueSmallLogo.ShowButtonChecked = true;
			this.viewer2DLeagueSmallLogo.Size = new global::System.Drawing.Size(201, 177);
			this.viewer2DLeagueSmallLogo.TabIndex = 157;
			this.viewer2DLeagueSmallLogo.Visible = false;
			this.viewer2DLeagueAnimLogo.AutoTransparency = true;
			this.viewer2DLeagueAnimLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DLeagueAnimLogo.ButtonStripVisible = true;
			this.viewer2DLeagueAnimLogo.CurrentBitmap = null;
			this.viewer2DLeagueAnimLogo.ExtendedFormat = false;
			this.viewer2DLeagueAnimLogo.FullSizeButton = false;
			this.viewer2DLeagueAnimLogo.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DLeagueAnimLogo.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DLeagueAnimLogo.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DLeagueAnimLogo.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DLeagueAnimLogo.Name = "viewer2DLeagueAnimLogo";
			this.viewer2DLeagueAnimLogo.RemoveButton = true;
			this.viewer2DLeagueAnimLogo.ShowButton = false;
			this.viewer2DLeagueAnimLogo.ShowButtonChecked = true;
			this.viewer2DLeagueAnimLogo.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DLeagueAnimLogo.TabIndex = 156;
			this.groupBoxNames.Controls.Add(this.comboLeaguePrestige);
			this.groupBoxNames.Controls.Add(this.label6);
			this.groupBoxNames.Controls.Add(this.textLeagueFullName);
			this.groupBoxNames.Controls.Add(this.labelLeagueFullName);
			this.groupBoxNames.Controls.Add(this.labelLeagueId);
			this.groupBoxNames.Controls.Add(this.buttonGetId);
			this.groupBoxNames.Controls.Add(this.groupBox1);
			this.groupBoxNames.Controls.Add(this.textLeagueShortName);
			this.groupBoxNames.Controls.Add(this.labelLeagueShortName);
			this.groupBoxNames.Controls.Add(this.textDatabaseLeagueName);
			this.groupBoxNames.Controls.Add(this.comboLeagueCountry);
			this.groupBoxNames.Controls.Add(this.labelDatabaseLeagueName);
			this.groupBoxNames.Controls.Add(this.numericLeagueId);
			this.groupBoxNames.Controls.Add(this.numericLeagueLevel);
			this.groupBoxNames.Controls.Add(this.labelCountry);
			this.groupBoxNames.Controls.Add(this.labelLeagueLevel);
			this.groupBoxNames.Location = new global::System.Drawing.Point(3, 463);
			this.groupBoxNames.Name = "groupBoxNames";
			this.groupBoxNames.Size = new global::System.Drawing.Size(531, 202);
			this.groupBoxNames.TabIndex = 1;
			this.groupBoxNames.TabStop = false;
			this.groupBoxNames.Text = "Names and Other Information";
			this.comboLeaguePrestige.FormattingEnabled = true;
			this.comboLeaguePrestige.Items.AddRange(new object[]
			{
				"Top Prestige    \t(England Spain Germany Italy)", "Prestige Level  2 \t(France)", "Prestige Level  3\t(Argentina Brazil)", "Prestige Level  4\t(Russia Portugal Turkey)", "Prestige Level  5 \t(Holland)", "Prestige Level  6 \t(Mexico England2)", "Prestige Level  7 \t(Belgium Germany2 Colombia)", "Prestige Level  8 \t(USA Chile)", "Prestige Level  9 \t(Scotland Italy2 Spain2)", "Prestige Level 10 \t(Denmark Norway Switzerland France2)",
				"Prestige Level 11 \t(Poland Austria Korea)", "Prestige Level 12\t(Australia Sweden England3 Ireland)", "Undefined"
			});
			this.comboLeaguePrestige.Location = new global::System.Drawing.Point(90, 170);
			this.comboLeaguePrestige.Name = "comboLeaguePrestige";
			this.comboLeaguePrestige.Size = new global::System.Drawing.Size(426, 21);
			this.comboLeaguePrestige.TabIndex = 162;
			this.comboLeaguePrestige.SelectedIndexChanged += new global::System.EventHandler(this.comboLeaguePrestige_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.SystemColors.Control;
			this.label6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new global::System.Drawing.Point(9, 174);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(45, 13);
			this.label6.TabIndex = 161;
			this.label6.Text = "Prestige";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textLeagueFullName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.leagueBindingSource, "LongName", true));
			this.textLeagueFullName.Location = new global::System.Drawing.Point(91, 60);
			this.textLeagueFullName.Name = "textLeagueFullName";
			this.textLeagueFullName.Size = new global::System.Drawing.Size(192, 20);
			this.textLeagueFullName.TabIndex = 116;
			this.leagueBindingSource.DataSource = typeof(global::FifaLibrary.League);
			this.labelLeagueFullName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueFullName.Location = new global::System.Drawing.Point(6, 60);
			this.labelLeagueFullName.Name = "labelLeagueFullName";
			this.labelLeagueFullName.Size = new global::System.Drawing.Size(79, 20);
			this.labelLeagueFullName.TabIndex = 120;
			this.labelLeagueFullName.Text = "Long Name";
			this.labelLeagueFullName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelLeagueId.AutoSize = true;
			this.labelLeagueId.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLeagueId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueId.Location = new global::System.Drawing.Point(6, 90);
			this.labelLeagueId.Name = "labelLeagueId";
			this.labelLeagueId.Size = new global::System.Drawing.Size(55, 13);
			this.labelLeagueId.TabIndex = 152;
			this.labelLeagueId.Text = "League Id";
			this.labelLeagueId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonGetId.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetId.BackgroundImage");
			this.buttonGetId.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.buttonGetId.Location = new global::System.Drawing.Point(229, 90);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(25, 23);
			this.buttonGetId.TabIndex = 153;
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.groupBox1.Controls.Add(this.numericBoardOutcome5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.numericBoardOutcome4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.numericBoardOutcome3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.numericBoardOutcome2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numericBoardOutcome1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(292, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(239, 148);
			this.groupBox1.TabIndex = 160;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Position necessary to achieve objectives";
			this.numericBoardOutcome5.Location = new global::System.Drawing.Point(164, 122);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericBoardOutcome5;
			int[] array = new int[4];
			array[0] = 24;
			numericUpDown.Maximum = new decimal(array);
			this.numericBoardOutcome5.Name = "numericBoardOutcome5";
			this.numericBoardOutcome5.Size = new global::System.Drawing.Size(60, 20);
			this.numericBoardOutcome5.TabIndex = 9;
			this.numericBoardOutcome5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericBoardOutcome5;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
			this.numericBoardOutcome5.ValueChanged += new global::System.EventHandler(this.numericBoardOutcome5_ValueChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 124);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(154, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Avoid Relegation or Low Class.";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericBoardOutcome4.Location = new global::System.Drawing.Point(164, 97);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericBoardOutcome4;
			int[] array3 = new int[4];
			array3[0] = 24;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericBoardOutcome4.Name = "numericBoardOutcome4";
			this.numericBoardOutcome4.Size = new global::System.Drawing.Size(60, 20);
			this.numericBoardOutcome4.TabIndex = 7;
			this.numericBoardOutcome4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericBoardOutcome4;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			this.numericBoardOutcome4.ValueChanged += new global::System.EventHandler(this.numericBoardOutcome4_ValueChanged);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 99);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(108, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Medium Classification";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericBoardOutcome3.Location = new global::System.Drawing.Point(164, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericBoardOutcome3;
			int[] array5 = new int[4];
			array5[0] = 24;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericBoardOutcome3.Name = "numericBoardOutcome3";
			this.numericBoardOutcome3.Size = new global::System.Drawing.Size(60, 20);
			this.numericBoardOutcome3.TabIndex = 5;
			this.numericBoardOutcome3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericBoardOutcome3;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.numericBoardOutcome3.ValueChanged += new global::System.EventHandler(this.numericBoardOutcome3_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(148, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Europa League or High Class.";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericBoardOutcome2.Location = new global::System.Drawing.Point(164, 47);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericBoardOutcome2;
			int[] array7 = new int[4];
			array7[0] = 24;
			numericUpDown7.Maximum = new decimal(array7);
			this.numericBoardOutcome2.Name = "numericBoardOutcome2";
			this.numericBoardOutcome2.Size = new global::System.Drawing.Size(60, 20);
			this.numericBoardOutcome2.TabIndex = 3;
			this.numericBoardOutcome2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericBoardOutcome2;
			int[] array8 = new int[4];
			array8[0] = 1;
			numericUpDown8.Value = new decimal(array8);
			this.numericBoardOutcome2.ValueChanged += new global::System.EventHandler(this.numericBoardOutcome2_ValueChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(145, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Champions League or Playoff";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericBoardOutcome1.Location = new global::System.Drawing.Point(164, 22);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericBoardOutcome1;
			int[] array9 = new int[4];
			array9[0] = 24;
			numericUpDown9.Maximum = new decimal(array9);
			this.numericBoardOutcome1.Name = "numericBoardOutcome1";
			this.numericBoardOutcome1.Size = new global::System.Drawing.Size(60, 20);
			this.numericBoardOutcome1.TabIndex = 1;
			this.numericBoardOutcome1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericBoardOutcome1;
			int[] array10 = new int[4];
			array10[0] = 1;
			numericUpDown10.Value = new decimal(array10);
			this.numericBoardOutcome1.ValueChanged += new global::System.EventHandler(this.numericBoardOutcome1_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(119, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Win or Direct Promotion";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textLeagueShortName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.leagueBindingSource, "ShortName", true));
			this.textLeagueShortName.Location = new global::System.Drawing.Point(91, 37);
			this.textLeagueShortName.Name = "textLeagueShortName";
			this.textLeagueShortName.Size = new global::System.Drawing.Size(192, 20);
			this.textLeagueShortName.TabIndex = 1;
			this.textLeagueShortName.TextChanged += new global::System.EventHandler(this.textLeagueShortName_TextChanged);
			this.labelLeagueShortName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueShortName.Location = new global::System.Drawing.Point(6, 37);
			this.labelLeagueShortName.Name = "labelLeagueShortName";
			this.labelLeagueShortName.Size = new global::System.Drawing.Size(79, 20);
			this.labelLeagueShortName.TabIndex = 119;
			this.labelLeagueShortName.Text = "Name";
			this.labelLeagueShortName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textDatabaseLeagueName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.leagueBindingSource, "leaguename", true));
			this.textDatabaseLeagueName.Location = new global::System.Drawing.Point(91, 15);
			this.textDatabaseLeagueName.Name = "textDatabaseLeagueName";
			this.textDatabaseLeagueName.Size = new global::System.Drawing.Size(192, 20);
			this.textDatabaseLeagueName.TabIndex = 0;
			this.comboLeagueCountry.Location = new global::System.Drawing.Point(90, 142);
			this.comboLeagueCountry.Name = "comboLeagueCountry";
			this.comboLeagueCountry.Size = new global::System.Drawing.Size(193, 21);
			this.comboLeagueCountry.TabIndex = 3;
			this.comboLeagueCountry.SelectedIndexChanged += new global::System.EventHandler(this.comboLeagueCountry_SelectedIndexChanged);
			this.labelDatabaseLeagueName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDatabaseLeagueName.Location = new global::System.Drawing.Point(6, 15);
			this.labelDatabaseLeagueName.Name = "labelDatabaseLeagueName";
			this.labelDatabaseLeagueName.Size = new global::System.Drawing.Size(97, 20);
			this.labelDatabaseLeagueName.TabIndex = 54;
			this.labelDatabaseLeagueName.Text = "Database Name";
			this.labelDatabaseLeagueName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericLeagueId.Location = new global::System.Drawing.Point(91, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericLeagueId;
			int[] array11 = new int[4];
			array11[0] = 200000;
			numericUpDown11.Maximum = new decimal(array11);
			this.numericLeagueId.Name = "numericLeagueId";
			this.numericLeagueId.Size = new global::System.Drawing.Size(132, 20);
			this.numericLeagueId.TabIndex = 0;
			this.numericLeagueId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericLeagueId.ValueChanged += new global::System.EventHandler(this.numericLeagueId_ValueChanged);
			this.numericLeagueLevel.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.leagueBindingSource, "level", true));
			this.numericLeagueLevel.Location = new global::System.Drawing.Point(91, 116);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericLeagueLevel;
			int[] array12 = new int[4];
			array12[0] = 7;
			numericUpDown12.Maximum = new decimal(array12);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericLeagueLevel;
			int[] array13 = new int[4];
			array13[0] = 1;
			numericUpDown13.Minimum = new decimal(array13);
			this.numericLeagueLevel.Name = "numericLeagueLevel";
			this.numericLeagueLevel.Size = new global::System.Drawing.Size(66, 20);
			this.numericLeagueLevel.TabIndex = 1;
			this.numericLeagueLevel.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericLeagueLevel.ThousandsSeparator = true;
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericLeagueLevel;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Value = new decimal(array14);
			this.labelCountry.AutoSize = true;
			this.labelCountry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelCountry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCountry.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelCountry.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCountry.Location = new global::System.Drawing.Point(6, 145);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new global::System.Drawing.Size(43, 13);
			this.labelCountry.TabIndex = 123;
			this.labelCountry.Text = "Country";
			this.labelCountry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.DoubleClick += new global::System.EventHandler(this.labelCountry_DoubleClick);
			this.labelLeagueLevel.AutoSize = true;
			this.labelLeagueLevel.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLeagueLevel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueLevel.Location = new global::System.Drawing.Point(6, 118);
			this.labelLeagueLevel.Name = "labelLeagueLevel";
			this.labelLeagueLevel.Size = new global::System.Drawing.Size(33, 13);
			this.labelLeagueLevel.TabIndex = 108;
			this.labelLeagueLevel.Text = "Level";
			this.labelLeagueLevel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupLeaguePlayerTuning.Controls.Add(this.buttonLeaguePlayerMinus);
			this.groupLeaguePlayerTuning.Controls.Add(this.buttonLeaguePlayerPlus);
			this.groupLeaguePlayerTuning.Location = new global::System.Drawing.Point(540, 463);
			this.groupLeaguePlayerTuning.Name = "groupLeaguePlayerTuning";
			this.groupLeaguePlayerTuning.Size = new global::System.Drawing.Size(167, 139);
			this.groupLeaguePlayerTuning.TabIndex = 159;
			this.groupLeaguePlayerTuning.TabStop = false;
			this.groupLeaguePlayerTuning.Text = "Player Overall Tuning";
			this.buttonLeaguePlayerMinus.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonLeaguePlayerMinus.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLeaguePlayerMinus.Image");
			this.buttonLeaguePlayerMinus.Location = new global::System.Drawing.Point(90, 43);
			this.buttonLeaguePlayerMinus.Name = "buttonLeaguePlayerMinus";
			this.buttonLeaguePlayerMinus.Size = new global::System.Drawing.Size(64, 64);
			this.buttonLeaguePlayerMinus.TabIndex = 1;
			this.buttonLeaguePlayerMinus.UseVisualStyleBackColor = false;
			this.buttonLeaguePlayerMinus.Click += new global::System.EventHandler(this.buttonLeaguePlayerMinus_Click);
			this.buttonLeaguePlayerPlus.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonLeaguePlayerPlus.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLeaguePlayerPlus.Image");
			this.buttonLeaguePlayerPlus.Location = new global::System.Drawing.Point(11, 43);
			this.buttonLeaguePlayerPlus.Name = "buttonLeaguePlayerPlus";
			this.buttonLeaguePlayerPlus.Size = new global::System.Drawing.Size(64, 64);
			this.buttonLeaguePlayerPlus.TabIndex = 0;
			this.buttonLeaguePlayerPlus.UseVisualStyleBackColor = false;
			this.buttonLeaguePlayerPlus.Click += new global::System.EventHandler(this.buttonLeaguePlayerPlus_Click);
			this.groupSwitchLeagues.Controls.Add(this.labelThisLeague);
			this.groupSwitchLeagues.Controls.Add(this.buttonSwitchLeagueIds);
			this.groupSwitchLeagues.Controls.Add(this.comboSwitchLeagues);
			this.groupSwitchLeagues.Location = new global::System.Drawing.Point(713, 463);
			this.groupSwitchLeagues.Name = "groupSwitchLeagues";
			this.groupSwitchLeagues.Size = new global::System.Drawing.Size(237, 139);
			this.groupSwitchLeagues.TabIndex = 158;
			this.groupSwitchLeagues.TabStop = false;
			this.groupSwitchLeagues.Text = "Switch League Ids";
			this.groupSwitchLeagues.Visible = false;
			this.labelThisLeague.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelThisLeague.Enabled = false;
			this.labelThisLeague.Location = new global::System.Drawing.Point(24, 22);
			this.labelThisLeague.Name = "labelThisLeague";
			this.labelThisLeague.Size = new global::System.Drawing.Size(202, 21);
			this.labelThisLeague.TabIndex = 159;
			this.labelThisLeague.Text = "League name";
			this.labelThisLeague.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonSwitchLeagueIds.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonSwitchLeagueIds.Enabled = false;
			this.buttonSwitchLeagueIds.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSwitchLeagueIds.Image");
			this.buttonSwitchLeagueIds.Location = new global::System.Drawing.Point(87, 48);
			this.buttonSwitchLeagueIds.Name = "buttonSwitchLeagueIds";
			this.buttonSwitchLeagueIds.Size = new global::System.Drawing.Size(71, 54);
			this.buttonSwitchLeagueIds.TabIndex = 158;
			this.buttonSwitchLeagueIds.UseVisualStyleBackColor = true;
			this.buttonSwitchLeagueIds.Click += new global::System.EventHandler(this.buttonSwitchLeagueIds_Click);
			this.comboSwitchLeagues.FormattingEnabled = true;
			this.comboSwitchLeagues.Location = new global::System.Drawing.Point(24, 108);
			this.comboSwitchLeagues.Name = "comboSwitchLeagues";
			this.comboSwitchLeagues.Size = new global::System.Drawing.Size(202, 21);
			this.comboSwitchLeagues.TabIndex = 157;
			this.comboSwitchLeagues.SelectedIndexChanged += new global::System.EventHandler(this.comboSwitchLeagues_SelectedIndexChanged);
			this.button1.Location = new global::System.Drawing.Point(956, 463);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 160;
			this.button1.Text = "Export Kits";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = false;
			this.pickUpControl.CreateButtonEnabled = true;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by Country" };
			this.pickUpControl.FilterEnabled = true;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = true;
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = true;
			this.pickUpControl.SearchEnabled = true;
			this.pickUpControl.Size = new global::System.Drawing.Size(1165, 25);
			this.pickUpControl.TabIndex = 1;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			this.countryListBindingSource.DataSource = typeof(global::FifaLibrary.CountryList);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1165, 780);
			base.Controls.Add(this.flowPanel);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "LeagueForm";
			this.Text = "LeagueForm";
			base.Load += new global::System.EventHandler(this.LeagueForm_Load);
			this.flowPanel.ResumeLayout(false);
			this.groupBoxTeams.ResumeLayout(false);
			this.groupBoxTeams.PerformLayout();
			this.toolStripTeamAvailable.ResumeLayout(false);
			this.toolStripTeamAvailable.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBoxNames.ResumeLayout(false);
			this.groupBoxNames.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.leagueBindingSource).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericBoardOutcome1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueLevel).EndInit();
			this.groupLeaguePlayerTuning.ResumeLayout(false);
			this.groupSwitchLeagues.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000148 RID: 328
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000149 RID: 329
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.FlowLayoutPanel flowPanel;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.GroupBox groupBoxTeams;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.ListView listViewPlayingTeams;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.ToolStrip toolStripTeamAvailable;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.ToolStripSeparator separatorBegin;

		// Token: 0x0400014F RID: 335
		public global::System.Windows.Forms.ToolStripComboBox comboTeamAvailable;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.ToolStripSeparator separatorButtons;

		// Token: 0x04000151 RID: 337
		public global::System.Windows.Forms.ToolStripButton buttonAddTeam;

		// Token: 0x04000152 RID: 338
		public global::System.Windows.Forms.ToolStripButton buttonReplaceTeam;

		// Token: 0x04000153 RID: 339
		public global::System.Windows.Forms.ToolStripButton buttonRemoveTeam;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.ToolStripSeparator separatorShowLogo;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.ToolStripButton checkShowTeamLogo;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.GroupBox groupBoxNames;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.TextBox textLeagueFullName;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.Label labelLeagueFullName;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.TextBox textLeagueShortName;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.Label labelLeagueShortName;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.TextBox textDatabaseLeagueName;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Label labelDatabaseLeagueName;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.Label labelLeagueId;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.ComboBox comboLeagueCountry;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.NumericUpDown numericLeagueId;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.Label labelCountry;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.Label labelLeagueLevel;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.NumericUpDown numericLeagueLevel;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.ImageList imageListTeamLogos;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.BindingSource leagueBindingSource;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.BindingSource countryListBindingSource;

		// Token: 0x04000168 RID: 360
		private global::FifaControls.Viewer2D viewer2DLeagueTinyLogo;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Button buttonreplicateLeagueTinyLogo;

		// Token: 0x0400016A RID: 362
		private global::FifaControls.Viewer2D viewer2DLeagueAnimLogo;

		// Token: 0x0400016B RID: 363
		private global::FifaControls.Viewer2D viewer2DLeagueSmallLogo;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.Button buttonreplicateLeagueSmallLogo;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.GroupBox groupSwitchLeagues;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.Label labelThisLeague;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.Button buttonSwitchLeagueIds;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.ComboBox comboSwitchLeagues;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.GroupBox groupLeaguePlayerTuning;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.Button buttonLeaguePlayerMinus;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.Button buttonLeaguePlayerPlus;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.NumericUpDown numericBoardOutcome5;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.NumericUpDown numericBoardOutcome4;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.NumericUpDown numericBoardOutcome3;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.NumericUpDown numericBoardOutcome2;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.NumericUpDown numericBoardOutcome1;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400017F RID: 383
		private global::FifaControls.Viewer2D viewer2DLeague512x128Logo;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Button buttonreplicateLeagueLogo512x128;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.ComboBox comboLeaguePrestige;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Label label6;
	}
}
