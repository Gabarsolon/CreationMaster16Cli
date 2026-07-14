namespace CreationMaster
{
	// Token: 0x0200000D RID: 13
	public partial class PatchCreatorForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000167 RID: 359 RVA: 0x0001E929 File Offset: 0x0001CB29
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001E948 File Offset: 0x0001CB48
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.PatchCreatorForm));
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.listSource = new global::System.Windows.Forms.ListBox();
			this.listViewDest = new global::System.Windows.Forms.ListView();
			this.columnComment = new global::System.Windows.Forms.ColumnHeader();
			this.columnType = new global::System.Windows.Forms.ColumnHeader();
			this.columnId = new global::System.Windows.Forms.ColumnHeader();
			this.columnItem = new global::System.Windows.Forms.ColumnHeader();
			this.toolAddRemove = new global::System.Windows.Forms.ToolStrip();
			this.buttonAddObject = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonRemoveObject = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonAddFile = new global::System.Windows.Forms.ToolStripButton();
			this.panelLeft = new global::System.Windows.Forms.Panel();
			this.statusBar = new global::System.Windows.Forms.StatusStrip();
			this.statusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.textDescription = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkCMSCompatible = new global::System.Windows.Forms.CheckBox();
			this.textPatchVersion = new global::System.Windows.Forms.TextBox();
			this.textPatchName = new global::System.Windows.Forms.TextBox();
			this.labelPatchVersion = new global::System.Windows.Forms.Label();
			this.labelPatchName = new global::System.Windows.Forms.Label();
			this.comboPatchType = new global::System.Windows.Forms.ComboBox();
			this.groupPatchOptions = new global::System.Windows.Forms.GroupBox();
			this.tabPatchOptions = new global::System.Windows.Forms.TabControl();
			this.pageGeneralOptions = new global::System.Windows.Forms.TabPage();
			this.radioIncludeOriginal = new global::System.Windows.Forms.RadioButton();
			this.radioIncludePatched = new global::System.Windows.Forms.RadioButton();
			this.pageCountryOptions = new global::System.Windows.Forms.TabPage();
			this.checkCountryMap = new global::System.Windows.Forms.CheckBox();
			this.checkCountryFlag512x512 = new global::System.Windows.Forms.CheckBox();
			this.checkCountryCardFlag = new global::System.Windows.Forms.CheckBox();
			this.checkCountryTournaments = new global::System.Windows.Forms.CheckBox();
			this.checkCountryLeagues = new global::System.Windows.Forms.CheckBox();
			this.checkContrynationalTeam = new global::System.Windows.Forms.CheckBox();
			this.checkCountryMiniFlag = new global::System.Windows.Forms.CheckBox();
			this.checkCountryDatabase = new global::System.Windows.Forms.CheckBox();
			this.checkCountryFlag = new global::System.Windows.Forms.CheckBox();
			this.pageLeagueOptions = new global::System.Windows.Forms.TabPage();
			this.checkLeagueBall = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueReferees = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueLinkedTournament = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueLinkedTeams = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueLogo = new global::System.Windows.Forms.CheckBox();
			this.checkLeagueDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageTeamOptions = new global::System.Windows.Forms.TabPage();
			this.checkTeamStadium = new global::System.Windows.Forms.CheckBox();
			this.checkTeamFormation = new global::System.Windows.Forms.CheckBox();
			this.checkTeamAdboard = new global::System.Windows.Forms.CheckBox();
			this.checkTeamBall = new global::System.Windows.Forms.CheckBox();
			this.checkTeamLinkedPlayers = new global::System.Windows.Forms.CheckBox();
			this.checkTeamKits = new global::System.Windows.Forms.CheckBox();
			this.checkTeamFlags = new global::System.Windows.Forms.CheckBox();
			this.checkTeamGuiBanner = new global::System.Windows.Forms.CheckBox();
			this.checkTeamGuiLogo = new global::System.Windows.Forms.CheckBox();
			this.checkTeamDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageKitOptions = new global::System.Windows.Forms.TabPage();
			this.checkKitTextures = new global::System.Windows.Forms.CheckBox();
			this.checkKitNameFonts = new global::System.Windows.Forms.CheckBox();
			this.checkKitDatabase = new global::System.Windows.Forms.CheckBox();
			this.checkKitNumbers = new global::System.Windows.Forms.CheckBox();
			this.checkKitMinikits = new global::System.Windows.Forms.CheckBox();
			this.pagePlayerOptions = new global::System.Windows.Forms.TabPage();
			this.checkPlayerGloves = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerShoes = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerMiniface = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerHead = new global::System.Windows.Forms.CheckBox();
			this.checkPlayerDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageRefereeOptions = new global::System.Windows.Forms.TabPage();
			this.checkRefereeMiniFace = new global::System.Windows.Forms.CheckBox();
			this.checkRefereeShoes = new global::System.Windows.Forms.CheckBox();
			this.checkRefereeKits = new global::System.Windows.Forms.CheckBox();
			this.checkRefereeDatabase = new global::System.Windows.Forms.CheckBox();
			this.pageStadiumOptions = new global::System.Windows.Forms.TabPage();
			this.checkStadiumMowingPattern = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumModel = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumPreview = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumDatabase = new global::System.Windows.Forms.CheckBox();
			this.checkStadiumNet = new global::System.Windows.Forms.CheckBox();
			this.labelPatchType = new global::System.Windows.Forms.Label();
			this.mainMenuStrip = new global::System.Windows.Forms.MenuStrip();
			this.patchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.newPatchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.createPatchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openPatchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolMain = new global::System.Windows.Forms.ToolStrip();
			this.buttonNewPatch = new global::System.Windows.Forms.ToolStripButton();
			this.buttonOpenPatch = new global::System.Windows.Forms.ToolStripButton();
			this.buttonCreatePatch = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExit = new global::System.Windows.Forms.ToolStripButton();
			this.openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.m_PatchDataSet = new global::CreationMaster.Patch();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolAddRemove.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.groupPatchOptions.SuspendLayout();
			this.tabPatchOptions.SuspendLayout();
			this.pageGeneralOptions.SuspendLayout();
			this.pageCountryOptions.SuspendLayout();
			this.pageLeagueOptions.SuspendLayout();
			this.pageTeamOptions.SuspendLayout();
			this.pageKitOptions.SuspendLayout();
			this.pagePlayerOptions.SuspendLayout();
			this.pageRefereeOptions.SuspendLayout();
			this.pageStadiumOptions.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.toolMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.m_PatchDataSet).BeginInit();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(300, 49);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.listSource);
			this.splitContainer1.Panel2.Controls.Add(this.listViewDest);
			this.splitContainer1.Panel2.Controls.Add(this.toolAddRemove);
			this.splitContainer1.Size = new global::System.Drawing.Size(728, 697);
			this.splitContainer1.SplitterDistance = 262;
			this.splitContainer1.TabIndex = 0;
			this.listSource.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listSource.FormattingEnabled = true;
			this.listSource.Location = new global::System.Drawing.Point(0, 0);
			this.listSource.Name = "listSource";
			this.listSource.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.listSource.Size = new global::System.Drawing.Size(262, 697);
			this.listSource.TabIndex = 27;
			this.listViewDest.AllowColumnReorder = true;
			this.listViewDest.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnComment, this.columnType, this.columnId, this.columnItem });
			this.listViewDest.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewDest.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.listViewDest.FullRowSelect = true;
			this.listViewDest.GridLines = true;
			this.listViewDest.HideSelection = false;
			this.listViewDest.LabelEdit = true;
			this.listViewDest.Location = new global::System.Drawing.Point(0, 25);
			this.listViewDest.Name = "listViewDest";
			this.listViewDest.Size = new global::System.Drawing.Size(462, 672);
			this.listViewDest.TabIndex = 27;
			this.listViewDest.UseCompatibleStateImageBehavior = false;
			this.listViewDest.View = global::System.Windows.Forms.View.Details;
			this.columnComment.DisplayIndex = 3;
			this.columnComment.Text = "Comment";
			this.columnComment.Width = 147;
			this.columnType.DisplayIndex = 0;
			this.columnType.Text = "Type";
			this.columnType.Width = 72;
			this.columnId.DisplayIndex = 1;
			this.columnId.Text = "ID";
			this.columnId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnId.Width = 51;
			this.columnItem.DisplayIndex = 2;
			this.columnItem.Text = "Item";
			this.columnItem.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnItem.Width = 124;
			this.toolAddRemove.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolAddRemove.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonAddObject, this.toolStripSeparator1, this.buttonRemoveObject, this.toolStripSeparator2, this.buttonAddFile });
			this.toolAddRemove.Location = new global::System.Drawing.Point(0, 0);
			this.toolAddRemove.Name = "toolAddRemove";
			this.toolAddRemove.Size = new global::System.Drawing.Size(462, 25);
			this.toolAddRemove.TabIndex = 7;
			this.buttonAddObject.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonAddObject.Image");
			this.buttonAddObject.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonAddObject.Name = "buttonAddObject";
			this.buttonAddObject.Size = new global::System.Drawing.Size(49, 22);
			this.buttonAddObject.Text = "Add";
			this.buttonAddObject.Click += new global::System.EventHandler(this.buttonAdd_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonRemoveObject.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemoveObject.Image");
			this.buttonRemoveObject.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemoveObject.Name = "buttonRemoveObject";
			this.buttonRemoveObject.Size = new global::System.Drawing.Size(70, 22);
			this.buttonRemoveObject.Text = "Remove";
			this.buttonRemoveObject.Click += new global::System.EventHandler(this.buttonRemoveObject_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonAddFile.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonAddFile.Image");
			this.buttonAddFile.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonAddFile.Name = "buttonAddFile";
			this.buttonAddFile.Size = new global::System.Drawing.Size(70, 22);
			this.buttonAddFile.Text = "Add File";
			this.buttonAddFile.Visible = false;
			this.buttonAddFile.Click += new global::System.EventHandler(this.buttonAddFile_Click);
			this.panelLeft.AutoScroll = true;
			this.panelLeft.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLeft.Controls.Add(this.statusBar);
			this.panelLeft.Controls.Add(this.textDescription);
			this.panelLeft.Controls.Add(this.label1);
			this.panelLeft.Controls.Add(this.checkCMSCompatible);
			this.panelLeft.Controls.Add(this.textPatchVersion);
			this.panelLeft.Controls.Add(this.textPatchName);
			this.panelLeft.Controls.Add(this.labelPatchVersion);
			this.panelLeft.Controls.Add(this.labelPatchName);
			this.panelLeft.Controls.Add(this.comboPatchType);
			this.panelLeft.Controls.Add(this.groupPatchOptions);
			this.panelLeft.Controls.Add(this.labelPatchType);
			this.panelLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new global::System.Drawing.Point(0, 49);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new global::System.Drawing.Size(300, 697);
			this.panelLeft.TabIndex = 3;
			this.statusBar.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.statusLabel });
			this.statusBar.Location = new global::System.Drawing.Point(0, 671);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new global::System.Drawing.Size(296, 22);
			this.statusBar.TabIndex = 29;
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new global::System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Status";
			this.textDescription.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.textDescription.Location = new global::System.Drawing.Point(0, 411);
			this.textDescription.Multiline = true;
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new global::System.Drawing.Size(296, 185);
			this.textDescription.TabIndex = 15;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(0, 390);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(296, 21);
			this.label1.TabIndex = 14;
			this.label1.Text = "Description";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.checkCMSCompatible.CheckAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.checkCMSCompatible.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.checkCMSCompatible.Location = new global::System.Drawing.Point(0, 362);
			this.checkCMSCompatible.Name = "checkCMSCompatible";
			this.checkCMSCompatible.Size = new global::System.Drawing.Size(296, 28);
			this.checkCMSCompatible.TabIndex = 28;
			this.checkCMSCompatible.Text = "CMS 14 Compliant";
			this.checkCMSCompatible.UseVisualStyleBackColor = true;
			this.checkCMSCompatible.Visible = false;
			this.textPatchVersion.Location = new global::System.Drawing.Point(86, 338);
			this.textPatchVersion.Name = "textPatchVersion";
			this.textPatchVersion.Size = new global::System.Drawing.Size(203, 20);
			this.textPatchVersion.TabIndex = 13;
			this.textPatchVersion.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textPatchName.Location = new global::System.Drawing.Point(86, 310);
			this.textPatchName.Name = "textPatchName";
			this.textPatchName.Size = new global::System.Drawing.Size(203, 20);
			this.textPatchName.TabIndex = 11;
			this.textPatchName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelPatchVersion.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelPatchVersion.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPatchVersion.Location = new global::System.Drawing.Point(0, 334);
			this.labelPatchVersion.Name = "labelPatchVersion";
			this.labelPatchVersion.Size = new global::System.Drawing.Size(296, 28);
			this.labelPatchVersion.TabIndex = 12;
			this.labelPatchVersion.Text = "Patch Version";
			this.labelPatchVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPatchName.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelPatchName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPatchName.Location = new global::System.Drawing.Point(0, 306);
			this.labelPatchName.Name = "labelPatchName";
			this.labelPatchName.Size = new global::System.Drawing.Size(296, 28);
			this.labelPatchName.TabIndex = 10;
			this.labelPatchName.Text = "Patch Name";
			this.labelPatchName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboPatchType.FormattingEnabled = true;
			this.comboPatchType.Items.AddRange(new object[]
			{
				"Countries", "Leagues", "Teams", "Players", "Kits", "Referees", "Stadiums", "Formations", "Balls", "Adboards",
				"Number Fonts", "Name Fonts", "Shoes", "GK Gloves", "Nets", "Mowing Patterns"
			});
			this.comboPatchType.Location = new global::System.Drawing.Point(7, 21);
			this.comboPatchType.Name = "comboPatchType";
			this.comboPatchType.Size = new global::System.Drawing.Size(282, 21);
			this.comboPatchType.TabIndex = 1;
			this.comboPatchType.SelectedIndexChanged += new global::System.EventHandler(this.comboPatchType_SelectedIndexChanged);
			this.groupPatchOptions.Controls.Add(this.tabPatchOptions);
			this.groupPatchOptions.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPatchOptions.Location = new global::System.Drawing.Point(0, 48);
			this.groupPatchOptions.Name = "groupPatchOptions";
			this.groupPatchOptions.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.groupPatchOptions.Size = new global::System.Drawing.Size(296, 258);
			this.groupPatchOptions.TabIndex = 9;
			this.groupPatchOptions.TabStop = false;
			this.groupPatchOptions.Text = "Patch Options";
			this.tabPatchOptions.Controls.Add(this.pageGeneralOptions);
			this.tabPatchOptions.Controls.Add(this.pageCountryOptions);
			this.tabPatchOptions.Controls.Add(this.pageLeagueOptions);
			this.tabPatchOptions.Controls.Add(this.pageTeamOptions);
			this.tabPatchOptions.Controls.Add(this.pageKitOptions);
			this.tabPatchOptions.Controls.Add(this.pagePlayerOptions);
			this.tabPatchOptions.Controls.Add(this.pageRefereeOptions);
			this.tabPatchOptions.Controls.Add(this.pageStadiumOptions);
			this.tabPatchOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabPatchOptions.ItemSize = new global::System.Drawing.Size(80, 20);
			this.tabPatchOptions.Location = new global::System.Drawing.Point(3, 16);
			this.tabPatchOptions.Multiline = true;
			this.tabPatchOptions.Name = "tabPatchOptions";
			this.tabPatchOptions.SelectedIndex = 0;
			this.tabPatchOptions.Size = new global::System.Drawing.Size(290, 239);
			this.tabPatchOptions.SizeMode = global::System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabPatchOptions.TabIndex = 8;
			this.pageGeneralOptions.Controls.Add(this.radioIncludeOriginal);
			this.pageGeneralOptions.Controls.Add(this.radioIncludePatched);
			this.pageGeneralOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageGeneralOptions.Name = "pageGeneralOptions";
			this.pageGeneralOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageGeneralOptions.TabIndex = 8;
			this.pageGeneralOptions.Text = "General";
			this.pageGeneralOptions.UseVisualStyleBackColor = true;
			this.radioIncludeOriginal.AutoSize = true;
			this.radioIncludeOriginal.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.radioIncludeOriginal.Location = new global::System.Drawing.Point(24, 43);
			this.radioIncludeOriginal.Name = "radioIncludeOriginal";
			this.radioIncludeOriginal.Size = new global::System.Drawing.Size(186, 17);
			this.radioIncludeOriginal.TabIndex = 1;
			this.radioIncludeOriginal.TabStop = true;
			this.radioIncludeOriginal.Text = "Include Patched and Original Files";
			this.radioIncludeOriginal.UseVisualStyleBackColor = true;
			this.radioIncludePatched.AutoSize = true;
			this.radioIncludePatched.Checked = true;
			this.radioIncludePatched.Location = new global::System.Drawing.Point(24, 20);
			this.radioIncludePatched.Name = "radioIncludePatched";
			this.radioIncludePatched.Size = new global::System.Drawing.Size(151, 17);
			this.radioIncludePatched.TabIndex = 0;
			this.radioIncludePatched.TabStop = true;
			this.radioIncludePatched.Text = "Include Patched Files Only";
			this.radioIncludePatched.UseVisualStyleBackColor = true;
			this.pageCountryOptions.Controls.Add(this.checkCountryMap);
			this.pageCountryOptions.Controls.Add(this.checkCountryFlag512x512);
			this.pageCountryOptions.Controls.Add(this.checkCountryCardFlag);
			this.pageCountryOptions.Controls.Add(this.checkCountryTournaments);
			this.pageCountryOptions.Controls.Add(this.checkCountryLeagues);
			this.pageCountryOptions.Controls.Add(this.checkContrynationalTeam);
			this.pageCountryOptions.Controls.Add(this.checkCountryMiniFlag);
			this.pageCountryOptions.Controls.Add(this.checkCountryDatabase);
			this.pageCountryOptions.Controls.Add(this.checkCountryFlag);
			this.pageCountryOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageCountryOptions.Name = "pageCountryOptions";
			this.pageCountryOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageCountryOptions.TabIndex = 3;
			this.pageCountryOptions.Text = "Countries";
			this.pageCountryOptions.UseVisualStyleBackColor = true;
			this.checkCountryMap.AutoSize = true;
			this.checkCountryMap.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryMap.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryMap.Location = new global::System.Drawing.Point(20, 66);
			this.checkCountryMap.Name = "checkCountryMap";
			this.checkCountryMap.Size = new global::System.Drawing.Size(47, 17);
			this.checkCountryMap.TabIndex = 9;
			this.checkCountryMap.Text = "Map";
			this.checkCountryMap.UseVisualStyleBackColor = true;
			this.checkCountryFlag512x512.AutoSize = true;
			this.checkCountryFlag512x512.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryFlag512x512.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryFlag512x512.Location = new global::System.Drawing.Point(20, 135);
			this.checkCountryFlag512x512.Name = "checkCountryFlag512x512";
			this.checkCountryFlag512x512.Size = new global::System.Drawing.Size(93, 17);
			this.checkCountryFlag512x512.TabIndex = 8;
			this.checkCountryFlag512x512.Text = "512 x 512 flag";
			this.checkCountryFlag512x512.UseVisualStyleBackColor = true;
			this.checkCountryCardFlag.AutoSize = true;
			this.checkCountryCardFlag.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryCardFlag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryCardFlag.Location = new global::System.Drawing.Point(20, 89);
			this.checkCountryCardFlag.Name = "checkCountryCardFlag";
			this.checkCountryCardFlag.Size = new global::System.Drawing.Size(71, 17);
			this.checkCountryCardFlag.TabIndex = 7;
			this.checkCountryCardFlag.Text = "Card Flag";
			this.checkCountryCardFlag.UseVisualStyleBackColor = true;
			this.checkCountryTournaments.AutoSize = true;
			this.checkCountryTournaments.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryTournaments.Location = new global::System.Drawing.Point(150, 66);
			this.checkCountryTournaments.Name = "checkCountryTournaments";
			this.checkCountryTournaments.Size = new global::System.Drawing.Size(123, 17);
			this.checkCountryTournaments.TabIndex = 6;
			this.checkCountryTournaments.Text = "Linked Tournaments";
			this.checkCountryTournaments.UseVisualStyleBackColor = true;
			this.checkCountryTournaments.Visible = false;
			this.checkCountryLeagues.AutoSize = true;
			this.checkCountryLeagues.Checked = true;
			this.checkCountryLeagues.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryLeagues.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryLeagues.Location = new global::System.Drawing.Point(150, 43);
			this.checkCountryLeagues.Name = "checkCountryLeagues";
			this.checkCountryLeagues.Size = new global::System.Drawing.Size(102, 17);
			this.checkCountryLeagues.TabIndex = 5;
			this.checkCountryLeagues.Text = "Linked Leagues";
			this.checkCountryLeagues.UseVisualStyleBackColor = true;
			this.checkContrynationalTeam.AutoSize = true;
			this.checkContrynationalTeam.Checked = true;
			this.checkContrynationalTeam.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkContrynationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkContrynationalTeam.Location = new global::System.Drawing.Point(150, 20);
			this.checkContrynationalTeam.Name = "checkContrynationalTeam";
			this.checkContrynationalTeam.Size = new global::System.Drawing.Size(130, 17);
			this.checkContrynationalTeam.TabIndex = 4;
			this.checkContrynationalTeam.Text = "Linked National Team";
			this.checkContrynationalTeam.UseVisualStyleBackColor = true;
			this.checkCountryMiniFlag.AutoSize = true;
			this.checkCountryMiniFlag.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryMiniFlag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryMiniFlag.Location = new global::System.Drawing.Point(20, 112);
			this.checkCountryMiniFlag.Name = "checkCountryMiniFlag";
			this.checkCountryMiniFlag.Size = new global::System.Drawing.Size(68, 17);
			this.checkCountryMiniFlag.TabIndex = 2;
			this.checkCountryMiniFlag.Text = "Mini Flag";
			this.checkCountryMiniFlag.UseVisualStyleBackColor = true;
			this.checkCountryDatabase.AutoSize = true;
			this.checkCountryDatabase.Checked = true;
			this.checkCountryDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryDatabase.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkCountryDatabase.Name = "checkCountryDatabase";
			this.checkCountryDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkCountryDatabase.TabIndex = 1;
			this.checkCountryDatabase.Text = "Database Info";
			this.checkCountryDatabase.UseVisualStyleBackColor = true;
			this.checkCountryFlag.AutoSize = true;
			this.checkCountryFlag.Checked = true;
			this.checkCountryFlag.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCountryFlag.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkCountryFlag.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkCountryFlag.Location = new global::System.Drawing.Point(20, 43);
			this.checkCountryFlag.Name = "checkCountryFlag";
			this.checkCountryFlag.Size = new global::System.Drawing.Size(46, 17);
			this.checkCountryFlag.TabIndex = 0;
			this.checkCountryFlag.Text = "Flag";
			this.checkCountryFlag.UseVisualStyleBackColor = true;
			this.pageLeagueOptions.Controls.Add(this.checkLeagueBall);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueReferees);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueLinkedTournament);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueLinkedTeams);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueLogo);
			this.pageLeagueOptions.Controls.Add(this.checkLeagueDatabase);
			this.pageLeagueOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageLeagueOptions.Name = "pageLeagueOptions";
			this.pageLeagueOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageLeagueOptions.TabIndex = 2;
			this.pageLeagueOptions.Text = "Leagues";
			this.pageLeagueOptions.UseVisualStyleBackColor = true;
			this.checkLeagueBall.AutoSize = true;
			this.checkLeagueBall.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueBall.Location = new global::System.Drawing.Point(150, 101);
			this.checkLeagueBall.Name = "checkLeagueBall";
			this.checkLeagueBall.Size = new global::System.Drawing.Size(78, 17);
			this.checkLeagueBall.TabIndex = 15;
			this.checkLeagueBall.Text = "Linked Ball";
			this.checkLeagueBall.UseVisualStyleBackColor = true;
			this.checkLeagueBall.Visible = false;
			this.checkLeagueReferees.AutoSize = true;
			this.checkLeagueReferees.Checked = true;
			this.checkLeagueReferees.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueReferees.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueReferees.Location = new global::System.Drawing.Point(150, 43);
			this.checkLeagueReferees.Name = "checkLeagueReferees";
			this.checkLeagueReferees.Size = new global::System.Drawing.Size(104, 17);
			this.checkLeagueReferees.TabIndex = 14;
			this.checkLeagueReferees.Text = "Linked Referees";
			this.checkLeagueReferees.UseVisualStyleBackColor = true;
			this.checkLeagueLinkedTournament.AutoSize = true;
			this.checkLeagueLinkedTournament.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueLinkedTournament.Location = new global::System.Drawing.Point(150, 124);
			this.checkLeagueLinkedTournament.Name = "checkLeagueLinkedTournament";
			this.checkLeagueLinkedTournament.Size = new global::System.Drawing.Size(118, 17);
			this.checkLeagueLinkedTournament.TabIndex = 13;
			this.checkLeagueLinkedTournament.Text = "Linked Tournament";
			this.checkLeagueLinkedTournament.UseVisualStyleBackColor = true;
			this.checkLeagueLinkedTournament.Visible = false;
			this.checkLeagueLinkedTeams.AutoSize = true;
			this.checkLeagueLinkedTeams.Checked = true;
			this.checkLeagueLinkedTeams.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueLinkedTeams.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueLinkedTeams.Location = new global::System.Drawing.Point(150, 20);
			this.checkLeagueLinkedTeams.Name = "checkLeagueLinkedTeams";
			this.checkLeagueLinkedTeams.Size = new global::System.Drawing.Size(93, 17);
			this.checkLeagueLinkedTeams.TabIndex = 12;
			this.checkLeagueLinkedTeams.Text = "Linked Teams";
			this.checkLeagueLinkedTeams.UseVisualStyleBackColor = true;
			this.checkLeagueLogo.AutoSize = true;
			this.checkLeagueLogo.Checked = true;
			this.checkLeagueLogo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueLogo.Location = new global::System.Drawing.Point(20, 43);
			this.checkLeagueLogo.Name = "checkLeagueLogo";
			this.checkLeagueLogo.Size = new global::System.Drawing.Size(55, 17);
			this.checkLeagueLogo.TabIndex = 10;
			this.checkLeagueLogo.Text = "Logos";
			this.checkLeagueLogo.UseVisualStyleBackColor = true;
			this.checkLeagueDatabase.AutoSize = true;
			this.checkLeagueDatabase.Checked = true;
			this.checkLeagueDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLeagueDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkLeagueDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkLeagueDatabase.Name = "checkLeagueDatabase";
			this.checkLeagueDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkLeagueDatabase.TabIndex = 9;
			this.checkLeagueDatabase.Text = "Database Info";
			this.checkLeagueDatabase.UseVisualStyleBackColor = true;
			this.pageTeamOptions.Controls.Add(this.checkTeamStadium);
			this.pageTeamOptions.Controls.Add(this.checkTeamFormation);
			this.pageTeamOptions.Controls.Add(this.checkTeamAdboard);
			this.pageTeamOptions.Controls.Add(this.checkTeamBall);
			this.pageTeamOptions.Controls.Add(this.checkTeamLinkedPlayers);
			this.pageTeamOptions.Controls.Add(this.checkTeamKits);
			this.pageTeamOptions.Controls.Add(this.checkTeamFlags);
			this.pageTeamOptions.Controls.Add(this.checkTeamGuiBanner);
			this.pageTeamOptions.Controls.Add(this.checkTeamGuiLogo);
			this.pageTeamOptions.Controls.Add(this.checkTeamDatabase);
			this.pageTeamOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageTeamOptions.Name = "pageTeamOptions";
			this.pageTeamOptions.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageTeamOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageTeamOptions.TabIndex = 1;
			this.pageTeamOptions.Text = "Teams";
			this.pageTeamOptions.UseVisualStyleBackColor = true;
			this.checkTeamStadium.AutoSize = true;
			this.checkTeamStadium.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamStadium.Location = new global::System.Drawing.Point(150, 135);
			this.checkTeamStadium.Name = "checkTeamStadium";
			this.checkTeamStadium.Size = new global::System.Drawing.Size(99, 17);
			this.checkTeamStadium.TabIndex = 13;
			this.checkTeamStadium.Text = "Linked Stadium";
			this.checkTeamStadium.UseVisualStyleBackColor = true;
			this.checkTeamFormation.AutoSize = true;
			this.checkTeamFormation.Checked = true;
			this.checkTeamFormation.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamFormation.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamFormation.Location = new global::System.Drawing.Point(150, 66);
			this.checkTeamFormation.Name = "checkTeamFormation";
			this.checkTeamFormation.Size = new global::System.Drawing.Size(107, 17);
			this.checkTeamFormation.TabIndex = 12;
			this.checkTeamFormation.Text = "Linked Formation";
			this.checkTeamFormation.UseVisualStyleBackColor = true;
			this.checkTeamAdboard.AutoSize = true;
			this.checkTeamAdboard.Checked = true;
			this.checkTeamAdboard.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamAdboard.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamAdboard.Location = new global::System.Drawing.Point(150, 89);
			this.checkTeamAdboard.Name = "checkTeamAdboard";
			this.checkTeamAdboard.Size = new global::System.Drawing.Size(106, 17);
			this.checkTeamAdboard.TabIndex = 11;
			this.checkTeamAdboard.Text = "Linked Adboards";
			this.checkTeamAdboard.UseVisualStyleBackColor = true;
			this.checkTeamBall.AutoSize = true;
			this.checkTeamBall.Checked = true;
			this.checkTeamBall.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamBall.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamBall.Location = new global::System.Drawing.Point(150, 112);
			this.checkTeamBall.Name = "checkTeamBall";
			this.checkTeamBall.Size = new global::System.Drawing.Size(78, 17);
			this.checkTeamBall.TabIndex = 10;
			this.checkTeamBall.Text = "Linked Ball";
			this.checkTeamBall.UseVisualStyleBackColor = true;
			this.checkTeamLinkedPlayers.AutoSize = true;
			this.checkTeamLinkedPlayers.Checked = true;
			this.checkTeamLinkedPlayers.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamLinkedPlayers.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamLinkedPlayers.Location = new global::System.Drawing.Point(150, 20);
			this.checkTeamLinkedPlayers.Name = "checkTeamLinkedPlayers";
			this.checkTeamLinkedPlayers.Size = new global::System.Drawing.Size(95, 17);
			this.checkTeamLinkedPlayers.TabIndex = 8;
			this.checkTeamLinkedPlayers.Text = "Linked Players";
			this.checkTeamLinkedPlayers.UseVisualStyleBackColor = true;
			this.checkTeamKits.AutoSize = true;
			this.checkTeamKits.Checked = true;
			this.checkTeamKits.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamKits.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamKits.Location = new global::System.Drawing.Point(150, 43);
			this.checkTeamKits.Name = "checkTeamKits";
			this.checkTeamKits.Size = new global::System.Drawing.Size(78, 17);
			this.checkTeamKits.TabIndex = 6;
			this.checkTeamKits.Text = "Linked Kits";
			this.checkTeamKits.UseVisualStyleBackColor = true;
			this.checkTeamFlags.AutoSize = true;
			this.checkTeamFlags.Checked = true;
			this.checkTeamFlags.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamFlags.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamFlags.Location = new global::System.Drawing.Point(20, 89);
			this.checkTeamFlags.Name = "checkTeamFlags";
			this.checkTeamFlags.Size = new global::System.Drawing.Size(51, 17);
			this.checkTeamFlags.TabIndex = 5;
			this.checkTeamFlags.Text = "Flags";
			this.checkTeamFlags.UseVisualStyleBackColor = true;
			this.checkTeamGuiBanner.AutoSize = true;
			this.checkTeamGuiBanner.Checked = true;
			this.checkTeamGuiBanner.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamGuiBanner.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamGuiBanner.Location = new global::System.Drawing.Point(20, 66);
			this.checkTeamGuiBanner.Name = "checkTeamGuiBanner";
			this.checkTeamGuiBanner.Size = new global::System.Drawing.Size(60, 17);
			this.checkTeamGuiBanner.TabIndex = 3;
			this.checkTeamGuiBanner.Text = "Banner";
			this.checkTeamGuiBanner.UseVisualStyleBackColor = true;
			this.checkTeamGuiLogo.AutoSize = true;
			this.checkTeamGuiLogo.Checked = true;
			this.checkTeamGuiLogo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamGuiLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamGuiLogo.Location = new global::System.Drawing.Point(20, 43);
			this.checkTeamGuiLogo.Name = "checkTeamGuiLogo";
			this.checkTeamGuiLogo.Size = new global::System.Drawing.Size(55, 17);
			this.checkTeamGuiLogo.TabIndex = 2;
			this.checkTeamGuiLogo.Text = "Logos";
			this.checkTeamGuiLogo.UseVisualStyleBackColor = true;
			this.checkTeamDatabase.AutoSize = true;
			this.checkTeamDatabase.Checked = true;
			this.checkTeamDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTeamDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkTeamDatabase.Name = "checkTeamDatabase";
			this.checkTeamDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkTeamDatabase.TabIndex = 1;
			this.checkTeamDatabase.Text = "Database Info";
			this.checkTeamDatabase.UseVisualStyleBackColor = true;
			this.pageKitOptions.Controls.Add(this.checkKitTextures);
			this.pageKitOptions.Controls.Add(this.checkKitNameFonts);
			this.pageKitOptions.Controls.Add(this.checkKitDatabase);
			this.pageKitOptions.Controls.Add(this.checkKitNumbers);
			this.pageKitOptions.Controls.Add(this.checkKitMinikits);
			this.pageKitOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageKitOptions.Name = "pageKitOptions";
			this.pageKitOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageKitOptions.TabIndex = 9;
			this.pageKitOptions.Text = "Kits";
			this.pageKitOptions.UseVisualStyleBackColor = true;
			this.checkKitTextures.AutoSize = true;
			this.checkKitTextures.Checked = true;
			this.checkKitTextures.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitTextures.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitTextures.Location = new global::System.Drawing.Point(20, 43);
			this.checkKitTextures.Name = "checkKitTextures";
			this.checkKitTextures.Size = new global::System.Drawing.Size(82, 17);
			this.checkKitTextures.TabIndex = 13;
			this.checkKitTextures.Text = "Kit Textures";
			this.checkKitTextures.UseVisualStyleBackColor = true;
			this.checkKitNameFonts.AutoSize = true;
			this.checkKitNameFonts.Checked = true;
			this.checkKitNameFonts.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitNameFonts.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitNameFonts.Location = new global::System.Drawing.Point(150, 43);
			this.checkKitNameFonts.Name = "checkKitNameFonts";
			this.checkKitNameFonts.Size = new global::System.Drawing.Size(113, 17);
			this.checkKitNameFonts.TabIndex = 12;
			this.checkKitNameFonts.Text = "Linked Name Font";
			this.checkKitNameFonts.UseVisualStyleBackColor = true;
			this.checkKitDatabase.AutoSize = true;
			this.checkKitDatabase.Checked = true;
			this.checkKitDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkKitDatabase.Name = "checkKitDatabase";
			this.checkKitDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkKitDatabase.TabIndex = 11;
			this.checkKitDatabase.Text = "Database Info";
			this.checkKitDatabase.UseVisualStyleBackColor = true;
			this.checkKitNumbers.AutoSize = true;
			this.checkKitNumbers.Checked = true;
			this.checkKitNumbers.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitNumbers.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitNumbers.Location = new global::System.Drawing.Point(150, 20);
			this.checkKitNumbers.Name = "checkKitNumbers";
			this.checkKitNumbers.Size = new global::System.Drawing.Size(103, 17);
			this.checkKitNumbers.TabIndex = 10;
			this.checkKitNumbers.Text = "Linked Numbers";
			this.checkKitNumbers.UseVisualStyleBackColor = true;
			this.checkKitMinikits.AutoSize = true;
			this.checkKitMinikits.Checked = true;
			this.checkKitMinikits.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkKitMinikits.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkKitMinikits.Location = new global::System.Drawing.Point(20, 66);
			this.checkKitMinikits.Name = "checkKitMinikits";
			this.checkKitMinikits.Size = new global::System.Drawing.Size(61, 17);
			this.checkKitMinikits.TabIndex = 8;
			this.checkKitMinikits.Text = "Minikits";
			this.checkKitMinikits.UseVisualStyleBackColor = true;
			this.pagePlayerOptions.Controls.Add(this.checkPlayerGloves);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerShoes);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerMiniface);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerHead);
			this.pagePlayerOptions.Controls.Add(this.checkPlayerDatabase);
			this.pagePlayerOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pagePlayerOptions.Name = "pagePlayerOptions";
			this.pagePlayerOptions.Padding = new global::System.Windows.Forms.Padding(3);
			this.pagePlayerOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pagePlayerOptions.TabIndex = 0;
			this.pagePlayerOptions.Text = "Players";
			this.pagePlayerOptions.UseVisualStyleBackColor = true;
			this.checkPlayerGloves.AutoSize = true;
			this.checkPlayerGloves.Checked = true;
			this.checkPlayerGloves.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerGloves.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerGloves.Location = new global::System.Drawing.Point(150, 43);
			this.checkPlayerGloves.Name = "checkPlayerGloves";
			this.checkPlayerGloves.Size = new global::System.Drawing.Size(94, 17);
			this.checkPlayerGloves.TabIndex = 4;
			this.checkPlayerGloves.Text = "Linked Gloves";
			this.checkPlayerGloves.UseVisualStyleBackColor = true;
			this.checkPlayerShoes.AutoSize = true;
			this.checkPlayerShoes.Checked = true;
			this.checkPlayerShoes.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerShoes.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerShoes.Location = new global::System.Drawing.Point(150, 20);
			this.checkPlayerShoes.Name = "checkPlayerShoes";
			this.checkPlayerShoes.Size = new global::System.Drawing.Size(91, 17);
			this.checkPlayerShoes.TabIndex = 3;
			this.checkPlayerShoes.Text = "Linked Shoes";
			this.checkPlayerShoes.UseVisualStyleBackColor = true;
			this.checkPlayerMiniface.AutoSize = true;
			this.checkPlayerMiniface.Checked = true;
			this.checkPlayerMiniface.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerMiniface.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerMiniface.Location = new global::System.Drawing.Point(20, 66);
			this.checkPlayerMiniface.Name = "checkPlayerMiniface";
			this.checkPlayerMiniface.Size = new global::System.Drawing.Size(72, 17);
			this.checkPlayerMiniface.TabIndex = 2;
			this.checkPlayerMiniface.Text = "Mini Face";
			this.checkPlayerMiniface.UseVisualStyleBackColor = true;
			this.checkPlayerHead.AutoSize = true;
			this.checkPlayerHead.Checked = true;
			this.checkPlayerHead.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerHead.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerHead.Location = new global::System.Drawing.Point(20, 43);
			this.checkPlayerHead.Name = "checkPlayerHead";
			this.checkPlayerHead.Size = new global::System.Drawing.Size(93, 17);
			this.checkPlayerHead.TabIndex = 1;
			this.checkPlayerHead.Text = "Specific Head";
			this.checkPlayerHead.UseVisualStyleBackColor = true;
			this.checkPlayerDatabase.AutoSize = true;
			this.checkPlayerDatabase.Checked = true;
			this.checkPlayerDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPlayerDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkPlayerDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkPlayerDatabase.Name = "checkPlayerDatabase";
			this.checkPlayerDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkPlayerDatabase.TabIndex = 0;
			this.checkPlayerDatabase.Text = "Database Info";
			this.checkPlayerDatabase.UseVisualStyleBackColor = true;
			this.pageRefereeOptions.Controls.Add(this.checkRefereeMiniFace);
			this.pageRefereeOptions.Controls.Add(this.checkRefereeShoes);
			this.pageRefereeOptions.Controls.Add(this.checkRefereeKits);
			this.pageRefereeOptions.Controls.Add(this.checkRefereeDatabase);
			this.pageRefereeOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageRefereeOptions.Name = "pageRefereeOptions";
			this.pageRefereeOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageRefereeOptions.TabIndex = 5;
			this.pageRefereeOptions.Text = "Referees";
			this.pageRefereeOptions.UseVisualStyleBackColor = true;
			this.checkRefereeMiniFace.AutoSize = true;
			this.checkRefereeMiniFace.Checked = true;
			this.checkRefereeMiniFace.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkRefereeMiniFace.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkRefereeMiniFace.Location = new global::System.Drawing.Point(20, 43);
			this.checkRefereeMiniFace.Name = "checkRefereeMiniFace";
			this.checkRefereeMiniFace.Size = new global::System.Drawing.Size(72, 17);
			this.checkRefereeMiniFace.TabIndex = 6;
			this.checkRefereeMiniFace.Text = "Mini Face";
			this.checkRefereeMiniFace.UseVisualStyleBackColor = true;
			this.checkRefereeShoes.AutoSize = true;
			this.checkRefereeShoes.Checked = true;
			this.checkRefereeShoes.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkRefereeShoes.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkRefereeShoes.Location = new global::System.Drawing.Point(150, 20);
			this.checkRefereeShoes.Name = "checkRefereeShoes";
			this.checkRefereeShoes.Size = new global::System.Drawing.Size(91, 17);
			this.checkRefereeShoes.TabIndex = 5;
			this.checkRefereeShoes.Text = "Linked Shoes";
			this.checkRefereeShoes.UseVisualStyleBackColor = true;
			this.checkRefereeKits.AutoSize = true;
			this.checkRefereeKits.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkRefereeKits.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkRefereeKits.Location = new global::System.Drawing.Point(20, 73);
			this.checkRefereeKits.Name = "checkRefereeKits";
			this.checkRefereeKits.Size = new global::System.Drawing.Size(84, 17);
			this.checkRefereeKits.TabIndex = 4;
			this.checkRefereeKits.Text = "Referee Kits";
			this.checkRefereeKits.UseVisualStyleBackColor = true;
			this.checkRefereeKits.Visible = false;
			this.checkRefereeDatabase.AutoSize = true;
			this.checkRefereeDatabase.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRefereeDatabase.Checked = true;
			this.checkRefereeDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkRefereeDatabase.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.checkRefereeDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkRefereeDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkRefereeDatabase.Name = "checkRefereeDatabase";
			this.checkRefereeDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkRefereeDatabase.TabIndex = 2;
			this.checkRefereeDatabase.Text = "Database Info";
			this.checkRefereeDatabase.UseVisualStyleBackColor = false;
			this.pageStadiumOptions.Controls.Add(this.checkStadiumMowingPattern);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumModel);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumPreview);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumDatabase);
			this.pageStadiumOptions.Controls.Add(this.checkStadiumNet);
			this.pageStadiumOptions.Location = new global::System.Drawing.Point(4, 44);
			this.pageStadiumOptions.Name = "pageStadiumOptions";
			this.pageStadiumOptions.Size = new global::System.Drawing.Size(282, 191);
			this.pageStadiumOptions.TabIndex = 6;
			this.pageStadiumOptions.Text = "Stadiums";
			this.pageStadiumOptions.UseVisualStyleBackColor = true;
			this.checkStadiumMowingPattern.AutoSize = true;
			this.checkStadiumMowingPattern.Checked = true;
			this.checkStadiumMowingPattern.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumMowingPattern.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumMowingPattern.Location = new global::System.Drawing.Point(144, 43);
			this.checkStadiumMowingPattern.Name = "checkStadiumMowingPattern";
			this.checkStadiumMowingPattern.Size = new global::System.Drawing.Size(135, 17);
			this.checkStadiumMowingPattern.TabIndex = 17;
			this.checkStadiumMowingPattern.Text = "Linked Mowing Pattern";
			this.checkStadiumMowingPattern.UseVisualStyleBackColor = true;
			this.checkStadiumModel.AutoSize = true;
			this.checkStadiumModel.Checked = true;
			this.checkStadiumModel.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumModel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumModel.Location = new global::System.Drawing.Point(20, 43);
			this.checkStadiumModel.Name = "checkStadiumModel";
			this.checkStadiumModel.Size = new global::System.Drawing.Size(77, 17);
			this.checkStadiumModel.TabIndex = 15;
			this.checkStadiumModel.Text = "3D Models";
			this.checkStadiumModel.UseVisualStyleBackColor = true;
			this.checkStadiumPreview.AutoSize = true;
			this.checkStadiumPreview.Checked = true;
			this.checkStadiumPreview.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumPreview.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumPreview.Location = new global::System.Drawing.Point(20, 66);
			this.checkStadiumPreview.Name = "checkStadiumPreview";
			this.checkStadiumPreview.Size = new global::System.Drawing.Size(105, 17);
			this.checkStadiumPreview.TabIndex = 13;
			this.checkStadiumPreview.Text = "Preview Pictures";
			this.checkStadiumPreview.UseVisualStyleBackColor = true;
			this.checkStadiumDatabase.AutoSize = true;
			this.checkStadiumDatabase.Checked = true;
			this.checkStadiumDatabase.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumDatabase.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumDatabase.Location = new global::System.Drawing.Point(20, 20);
			this.checkStadiumDatabase.Name = "checkStadiumDatabase";
			this.checkStadiumDatabase.Size = new global::System.Drawing.Size(93, 17);
			this.checkStadiumDatabase.TabIndex = 12;
			this.checkStadiumDatabase.Text = "Database Info";
			this.checkStadiumDatabase.UseVisualStyleBackColor = true;
			this.checkStadiumNet.AutoSize = true;
			this.checkStadiumNet.Checked = true;
			this.checkStadiumNet.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkStadiumNet.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkStadiumNet.Location = new global::System.Drawing.Point(144, 20);
			this.checkStadiumNet.Name = "checkStadiumNet";
			this.checkStadiumNet.Size = new global::System.Drawing.Size(78, 17);
			this.checkStadiumNet.TabIndex = 10;
			this.checkStadiumNet.Text = "Linked Net";
			this.checkStadiumNet.UseVisualStyleBackColor = true;
			this.labelPatchType.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.labelPatchType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPatchType.Location = new global::System.Drawing.Point(0, 0);
			this.labelPatchType.Name = "labelPatchType";
			this.labelPatchType.Size = new global::System.Drawing.Size(296, 48);
			this.labelPatchType.TabIndex = 6;
			this.labelPatchType.Text = "Objects Selection";
			this.labelPatchType.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.mainMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.patchToolStripMenuItem });
			this.mainMenuStrip.Location = new global::System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new global::System.Drawing.Size(1028, 24);
			this.mainMenuStrip.TabIndex = 29;
			this.mainMenuStrip.Text = "menuStrip1";
			this.patchToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.newPatchToolStripMenuItem, this.createPatchToolStripMenuItem, this.openPatchToolStripMenuItem, this.exitToolStripMenuItem });
			this.patchToolStripMenuItem.Name = "patchToolStripMenuItem";
			this.patchToolStripMenuItem.Size = new global::System.Drawing.Size(49, 20);
			this.patchToolStripMenuItem.Text = "Patch";
			this.newPatchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("newPatchToolStripMenuItem.Image");
			this.newPatchToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.newPatchToolStripMenuItem.Name = "newPatchToolStripMenuItem";
			this.newPatchToolStripMenuItem.Size = new global::System.Drawing.Size(141, 22);
			this.newPatchToolStripMenuItem.Text = "New Patch";
			this.newPatchToolStripMenuItem.Click += new global::System.EventHandler(this.newPatchToolStripMenuItem_Click);
			this.createPatchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("createPatchToolStripMenuItem.Image");
			this.createPatchToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.createPatchToolStripMenuItem.Name = "createPatchToolStripMenuItem";
			this.createPatchToolStripMenuItem.Size = new global::System.Drawing.Size(141, 22);
			this.createPatchToolStripMenuItem.Text = "Create Patch";
			this.createPatchToolStripMenuItem.Click += new global::System.EventHandler(this.createPatchToolStripMenuItem_Click);
			this.openPatchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openPatchToolStripMenuItem.Image");
			this.openPatchToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.openPatchToolStripMenuItem.Name = "openPatchToolStripMenuItem";
			this.openPatchToolStripMenuItem.Size = new global::System.Drawing.Size(141, 22);
			this.openPatchToolStripMenuItem.Text = "Open Patch";
			this.openPatchToolStripMenuItem.Click += new global::System.EventHandler(this.openPatchToolStripMenuItem_Click);
			this.exitToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("exitToolStripMenuItem.Image");
			this.exitToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Fuchsia;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.exitToolStripMenuItem_Click);
			this.toolMain.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonNewPatch, this.buttonOpenPatch, this.buttonCreatePatch, this.buttonExit });
			this.toolMain.Location = new global::System.Drawing.Point(0, 24);
			this.toolMain.Name = "toolMain";
			this.toolMain.Size = new global::System.Drawing.Size(1028, 25);
			this.toolMain.TabIndex = 30;
			this.toolMain.Text = "toolStrip2";
			this.buttonNewPatch.AutoSize = false;
			this.buttonNewPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonNewPatch.Image");
			this.buttonNewPatch.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonNewPatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonNewPatch.Name = "buttonNewPatch";
			this.buttonNewPatch.Size = new global::System.Drawing.Size(90, 22);
			this.buttonNewPatch.Text = "New";
			this.buttonNewPatch.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonNewPatch.Click += new global::System.EventHandler(this.buttonNewPatch_Click);
			this.buttonOpenPatch.AutoSize = false;
			this.buttonOpenPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonOpenPatch.Image");
			this.buttonOpenPatch.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonOpenPatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonOpenPatch.Name = "buttonOpenPatch";
			this.buttonOpenPatch.Size = new global::System.Drawing.Size(90, 22);
			this.buttonOpenPatch.Text = "Open";
			this.buttonOpenPatch.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonOpenPatch.Click += new global::System.EventHandler(this.buttonOpenPatch_Click);
			this.buttonCreatePatch.AutoSize = false;
			this.buttonCreatePatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCreatePatch.Image");
			this.buttonCreatePatch.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonCreatePatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonCreatePatch.Name = "buttonCreatePatch";
			this.buttonCreatePatch.Size = new global::System.Drawing.Size(90, 22);
			this.buttonCreatePatch.Text = "Create";
			this.buttonCreatePatch.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCreatePatch.Click += new global::System.EventHandler(this.buttonCreatePatch_Click);
			this.buttonExit.AutoSize = false;
			this.buttonExit.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExit.Image");
			this.buttonExit.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonExit.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new global::System.Drawing.Size(90, 22);
			this.buttonExit.Text = "Exit";
			this.buttonExit.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.Click += new global::System.EventHandler(this.buttonExit_Click);
			this.openFileDialog.FileName = "openFileDialog";
			this.m_PatchDataSet.DataSetName = "Patch";
			this.m_PatchDataSet.Locale = new global::System.Globalization.CultureInfo("");
			this.m_PatchDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1028, 746);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.panelLeft);
			base.Controls.Add(this.toolMain);
			base.Controls.Add(this.mainMenuStrip);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.mainMenuStrip;
			base.Name = "PatchCreatorForm";
			this.Text = " CM-Patch Creator";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolAddRemove.ResumeLayout(false);
			this.toolAddRemove.PerformLayout();
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.groupPatchOptions.ResumeLayout(false);
			this.tabPatchOptions.ResumeLayout(false);
			this.pageGeneralOptions.ResumeLayout(false);
			this.pageGeneralOptions.PerformLayout();
			this.pageCountryOptions.ResumeLayout(false);
			this.pageCountryOptions.PerformLayout();
			this.pageLeagueOptions.ResumeLayout(false);
			this.pageLeagueOptions.PerformLayout();
			this.pageTeamOptions.ResumeLayout(false);
			this.pageTeamOptions.PerformLayout();
			this.pageKitOptions.ResumeLayout(false);
			this.pageKitOptions.PerformLayout();
			this.pagePlayerOptions.ResumeLayout(false);
			this.pagePlayerOptions.PerformLayout();
			this.pageRefereeOptions.ResumeLayout(false);
			this.pageRefereeOptions.PerformLayout();
			this.pageStadiumOptions.ResumeLayout(false);
			this.pageStadiumOptions.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.toolMain.ResumeLayout(false);
			this.toolMain.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.m_PatchDataSet).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001DF RID: 479
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.Panel panelLeft;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.TextBox textPatchVersion;

		// Token: 0x040001E3 RID: 483
		private global::System.Windows.Forms.TextBox textPatchName;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.TextBox textDescription;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001E6 RID: 486
		private global::System.Windows.Forms.Label labelPatchVersion;

		// Token: 0x040001E7 RID: 487
		private global::System.Windows.Forms.Label labelPatchName;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.ComboBox comboPatchType;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.GroupBox groupPatchOptions;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.TabControl tabPatchOptions;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.TabPage pagePlayerOptions;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.CheckBox checkPlayerShoes;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.CheckBox checkPlayerMiniface;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.CheckBox checkPlayerHead;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.CheckBox checkPlayerDatabase;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.TabPage pageTeamOptions;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.CheckBox checkTeamAdboard;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.CheckBox checkTeamBall;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.CheckBox checkTeamLinkedPlayers;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.CheckBox checkTeamKits;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.CheckBox checkTeamFlags;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.CheckBox checkTeamGuiBanner;

		// Token: 0x040001F7 RID: 503
		private global::System.Windows.Forms.CheckBox checkTeamGuiLogo;

		// Token: 0x040001F8 RID: 504
		private global::System.Windows.Forms.CheckBox checkTeamDatabase;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.TabPage pageLeagueOptions;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.CheckBox checkLeagueLinkedTournament;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.CheckBox checkLeagueLinkedTeams;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.CheckBox checkLeagueLogo;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.CheckBox checkLeagueDatabase;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.TabPage pageCountryOptions;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.CheckBox checkCountryMiniFlag;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.CheckBox checkCountryDatabase;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.CheckBox checkCountryFlag;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.TabPage pageRefereeOptions;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.CheckBox checkRefereeDatabase;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.TabPage pageStadiumOptions;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.CheckBox checkStadiumMowingPattern;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.CheckBox checkStadiumModel;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.CheckBox checkStadiumPreview;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.CheckBox checkStadiumDatabase;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.CheckBox checkStadiumNet;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.Label labelPatchType;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Forms.CheckBox checkCMSCompatible;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.CheckBox checkTeamFormation;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.CheckBox checkRefereeKits;

		// Token: 0x0400020E RID: 526
		private global::System.Windows.Forms.ListBox listSource;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.ListView listViewDest;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.ColumnHeader columnComment;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.ColumnHeader columnType;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.ColumnHeader columnId;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.ColumnHeader columnItem;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.ToolStrip toolAddRemove;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.ToolStripButton buttonAddObject;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.ToolStripButton buttonRemoveObject;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.TabPage pageGeneralOptions;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.RadioButton radioIncludeOriginal;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.RadioButton radioIncludePatched;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.CheckBox checkCountryLeagues;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.CheckBox checkContrynationalTeam;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.CheckBox checkCountryTournaments;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.TabPage pageKitOptions;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.CheckBox checkKitNumbers;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.CheckBox checkKitMinikits;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.CheckBox checkKitDatabase;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.CheckBox checkKitNameFonts;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.CheckBox checkLeagueReferees;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.CheckBox checkRefereeShoes;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.CheckBox checkTeamStadium;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.CheckBox checkPlayerGloves;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.MenuStrip mainMenuStrip;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.ToolStrip toolMain;

		// Token: 0x04000229 RID: 553
		private global::System.Windows.Forms.ToolStripMenuItem patchToolStripMenuItem;

		// Token: 0x0400022A RID: 554
		private global::System.Windows.Forms.ToolStripMenuItem newPatchToolStripMenuItem;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Forms.ToolStripMenuItem createPatchToolStripMenuItem;

		// Token: 0x0400022C RID: 556
		private global::System.Windows.Forms.ToolStripMenuItem openPatchToolStripMenuItem;

		// Token: 0x0400022D RID: 557
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Forms.ToolStripButton buttonNewPatch;

		// Token: 0x0400022F RID: 559
		private global::System.Windows.Forms.ToolStripButton buttonOpenPatch;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.ToolStripButton buttonCreatePatch;

		// Token: 0x04000231 RID: 561
		private global::System.Windows.Forms.ToolStripButton buttonExit;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.StatusStrip statusBar;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.ToolStripStatusLabel statusLabel;

		// Token: 0x04000234 RID: 564
		private global::CreationMaster.Patch m_PatchDataSet;

		// Token: 0x04000235 RID: 565
		private global::System.Windows.Forms.OpenFileDialog openFileDialog;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.CheckBox checkKitTextures;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.CheckBox checkCountryCardFlag;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.CheckBox checkRefereeMiniFace;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.CheckBox checkLeagueBall;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.ToolStripButton buttonAddFile;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.CheckBox checkCountryMap;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.CheckBox checkCountryFlag512x512;
	}
}
