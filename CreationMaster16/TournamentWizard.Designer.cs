namespace CreationMaster
{
	// Token: 0x0200001D RID: 29
	public partial class TournamentWizard : global::System.Windows.Forms.Form
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0007F0EA File Offset: 0x0007D2EA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0007F10C File Offset: 0x0007D30C
		private void InitializeComponent()
		{
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.groupKO = new global::System.Windows.Forms.GroupBox();
			this.numericFinalGames = new global::System.Windows.Forms.NumericUpDown();
			this.numericKOGames = new global::System.Windows.Forms.NumericUpDown();
			this.domainNTeamsKO = new global::System.Windows.Forms.DomainUpDown();
			this.labelFinalGames = new global::System.Windows.Forms.Label();
			this.labelNTeamsKO = new global::System.Windows.Forms.Label();
			this.labelKnockOutGames = new global::System.Windows.Forms.Label();
			this.groupGroups = new global::System.Windows.Forms.GroupBox();
			this.numericGamesPerGroup = new global::System.Windows.Forms.NumericUpDown();
			this.numericTeamsPerGroup = new global::System.Windows.Forms.NumericUpDown();
			this.domainNGroups = new global::System.Windows.Forms.DomainUpDown();
			this.labelGamesPerGroup = new global::System.Windows.Forms.Label();
			this.labelNumberofGroups = new global::System.Windows.Forms.Label();
			this.labelTeamPerGroup = new global::System.Windows.Forms.Label();
			this.groupPreliminary = new global::System.Windows.Forms.GroupBox();
			this.numericPrelimGames = new global::System.Windows.Forms.NumericUpDown();
			this.numericPreliminaryTeams = new global::System.Windows.Forms.NumericUpDown();
			this.labelNumberofGames = new global::System.Windows.Forms.Label();
			this.labelPrelimNTeams = new global::System.Windows.Forms.Label();
			this.groupStructure = new global::System.Windows.Forms.GroupBox();
			this.radioEuro2008 = new global::System.Windows.Forms.RadioButton();
			this.radioEuro2004 = new global::System.Windows.Forms.RadioButton();
			this.radioWC2006 = new global::System.Windows.Forms.RadioButton();
			this.radioPGKO = new global::System.Windows.Forms.RadioButton();
			this.radioPKO = new global::System.Windows.Forms.RadioButton();
			this.radioGKO = new global::System.Windows.Forms.RadioButton();
			this.radioKO = new global::System.Windows.Forms.RadioButton();
			this.radioLeague = new global::System.Windows.Forms.RadioButton();
			this.numericNTeams = new global::System.Windows.Forms.NumericUpDown();
			this.labelNumberofTeams = new global::System.Windows.Forms.Label();
			this.groupLeague = new global::System.Windows.Forms.GroupBox();
			this.numericLeagueGames = new global::System.Windows.Forms.NumericUpDown();
			this.labelLeagueGames = new global::System.Windows.Forms.Label();
			this.groupQualification = new global::System.Windows.Forms.GroupBox();
			this.labelLeagueReadHelp = new global::System.Windows.Forms.Label();
			this.groupKO.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericFinalGames).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericKOGames).BeginInit();
			this.groupGroups.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericGamesPerGroup).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamsPerGroup).BeginInit();
			this.groupPreliminary.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericPrelimGames).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPreliminaryTeams).BeginInit();
			this.groupStructure.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNTeams).BeginInit();
			this.groupLeague.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueGames).BeginInit();
			this.groupQualification.SuspendLayout();
			base.SuspendLayout();
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonCancel.Location = new global::System.Drawing.Point(389, 334);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(94, 44);
			this.buttonCancel.TabIndex = 150;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonOK.Location = new global::System.Drawing.Point(179, 334);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(94, 44);
			this.buttonOK.TabIndex = 148;
			this.buttonOK.Text = "Create Tournament";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.groupKO.Controls.Add(this.numericFinalGames);
			this.groupKO.Controls.Add(this.numericKOGames);
			this.groupKO.Controls.Add(this.domainNTeamsKO);
			this.groupKO.Controls.Add(this.labelFinalGames);
			this.groupKO.Controls.Add(this.labelNTeamsKO);
			this.groupKO.Controls.Add(this.labelKnockOutGames);
			this.groupKO.Location = new global::System.Drawing.Point(439, 184);
			this.groupKO.Name = "groupKO";
			this.groupKO.Size = new global::System.Drawing.Size(200, 144);
			this.groupKO.TabIndex = 147;
			this.groupKO.TabStop = false;
			this.groupKO.Text = "Knock Out Stage Options";
			this.groupKO.Visible = false;
			this.numericFinalGames.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericFinalGames.Location = new global::System.Drawing.Point(125, 91);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericFinalGames;
			int[] array = new int[4];
			array[0] = 2;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericFinalGames;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericFinalGames.Name = "numericFinalGames";
			this.numericFinalGames.ReadOnly = true;
			this.numericFinalGames.Size = new global::System.Drawing.Size(69, 20);
			this.numericFinalGames.TabIndex = 133;
			this.numericFinalGames.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericFinalGames;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.numericFinalGames.ValueChanged += new global::System.EventHandler(this.numericFinalGames_ValueChanged);
			this.numericKOGames.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericKOGames.Location = new global::System.Drawing.Point(125, 61);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericKOGames;
			int[] array4 = new int[4];
			array4[0] = 2;
			numericUpDown4.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericKOGames;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.numericKOGames.Name = "numericKOGames";
			this.numericKOGames.ReadOnly = true;
			this.numericKOGames.Size = new global::System.Drawing.Size(69, 20);
			this.numericKOGames.TabIndex = 132;
			this.numericKOGames.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericKOGames;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.numericKOGames.ValueChanged += new global::System.EventHandler(this.numericKOGames_ValueChanged);
			this.domainNTeamsKO.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.domainNTeamsKO.Items.Add("2");
			this.domainNTeamsKO.Items.Add("4");
			this.domainNTeamsKO.Items.Add("8");
			this.domainNTeamsKO.Items.Add("16");
			this.domainNTeamsKO.Items.Add("32");
			this.domainNTeamsKO.Items.Add("64");
			this.domainNTeamsKO.Location = new global::System.Drawing.Point(125, 29);
			this.domainNTeamsKO.Name = "domainNTeamsKO";
			this.domainNTeamsKO.ReadOnly = true;
			this.domainNTeamsKO.Size = new global::System.Drawing.Size(69, 20);
			this.domainNTeamsKO.TabIndex = 131;
			this.domainNTeamsKO.Wrap = true;
			this.domainNTeamsKO.SelectedItemChanged += new global::System.EventHandler(this.domainNTeamsKO_SelectedItemChanged);
			this.labelFinalGames.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelFinalGames.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFinalGames.Location = new global::System.Drawing.Point(6, 89);
			this.labelFinalGames.Name = "labelFinalGames";
			this.labelFinalGames.Size = new global::System.Drawing.Size(188, 20);
			this.labelFinalGames.TabIndex = 130;
			this.labelFinalGames.Text = "Final Games";
			this.labelFinalGames.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelNTeamsKO.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelNTeamsKO.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNTeamsKO.Location = new global::System.Drawing.Point(6, 29);
			this.labelNTeamsKO.Name = "labelNTeamsKO";
			this.labelNTeamsKO.Size = new global::System.Drawing.Size(188, 20);
			this.labelNTeamsKO.TabIndex = 129;
			this.labelNTeamsKO.Text = "Number of Teams";
			this.labelNTeamsKO.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelKnockOutGames.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelKnockOutGames.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelKnockOutGames.Location = new global::System.Drawing.Point(6, 59);
			this.labelKnockOutGames.Name = "labelKnockOutGames";
			this.labelKnockOutGames.Size = new global::System.Drawing.Size(188, 20);
			this.labelKnockOutGames.TabIndex = 128;
			this.labelKnockOutGames.Text = "Knock Out Games";
			this.labelKnockOutGames.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupGroups.Controls.Add(this.numericGamesPerGroup);
			this.groupGroups.Controls.Add(this.numericTeamsPerGroup);
			this.groupGroups.Controls.Add(this.domainNGroups);
			this.groupGroups.Controls.Add(this.labelGamesPerGroup);
			this.groupGroups.Controls.Add(this.labelNumberofGroups);
			this.groupGroups.Controls.Add(this.labelTeamPerGroup);
			this.groupGroups.Location = new global::System.Drawing.Point(230, 184);
			this.groupGroups.Name = "groupGroups";
			this.groupGroups.Size = new global::System.Drawing.Size(200, 144);
			this.groupGroups.TabIndex = 146;
			this.groupGroups.TabStop = false;
			this.groupGroups.Text = "Groups Stage Options";
			this.groupGroups.Visible = false;
			this.numericGamesPerGroup.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericGamesPerGroup.Location = new global::System.Drawing.Point(125, 86);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericGamesPerGroup;
			int[] array7 = new int[4];
			array7[0] = 2;
			numericUpDown7.Maximum = new decimal(array7);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericGamesPerGroup;
			int[] array8 = new int[4];
			array8[0] = 1;
			numericUpDown8.Minimum = new decimal(array8);
			this.numericGamesPerGroup.Name = "numericGamesPerGroup";
			this.numericGamesPerGroup.ReadOnly = true;
			this.numericGamesPerGroup.Size = new global::System.Drawing.Size(69, 20);
			this.numericGamesPerGroup.TabIndex = 130;
			this.numericGamesPerGroup.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericGamesPerGroup;
			int[] array9 = new int[4];
			array9[0] = 1;
			numericUpDown9.Value = new decimal(array9);
			this.numericGamesPerGroup.ValueChanged += new global::System.EventHandler(this.numericGamesPerGroup_ValueChanged);
			this.numericTeamsPerGroup.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericTeamsPerGroup.Enabled = false;
			this.numericTeamsPerGroup.Location = new global::System.Drawing.Point(125, 56);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericTeamsPerGroup;
			int[] array10 = new int[4];
			array10[0] = 16;
			numericUpDown10.Maximum = new decimal(array10);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericTeamsPerGroup;
			int[] array11 = new int[4];
			array11[0] = 3;
			numericUpDown11.Minimum = new decimal(array11);
			this.numericTeamsPerGroup.Name = "numericTeamsPerGroup";
			this.numericTeamsPerGroup.ReadOnly = true;
			this.numericTeamsPerGroup.Size = new global::System.Drawing.Size(69, 20);
			this.numericTeamsPerGroup.TabIndex = 129;
			this.numericTeamsPerGroup.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericTeamsPerGroup;
			int[] array12 = new int[4];
			array12[0] = 3;
			numericUpDown12.Value = new decimal(array12);
			this.domainNGroups.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.domainNGroups.Items.Add("1");
			this.domainNGroups.Items.Add("2");
			this.domainNGroups.Items.Add("4");
			this.domainNGroups.Items.Add("8");
			this.domainNGroups.Location = new global::System.Drawing.Point(125, 26);
			this.domainNGroups.Name = "domainNGroups";
			this.domainNGroups.ReadOnly = true;
			this.domainNGroups.Size = new global::System.Drawing.Size(69, 20);
			this.domainNGroups.TabIndex = 128;
			this.domainNGroups.Wrap = true;
			this.domainNGroups.SelectedItemChanged += new global::System.EventHandler(this.domainNGroups_SelectedItemChanged);
			this.labelGamesPerGroup.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelGamesPerGroup.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelGamesPerGroup.Location = new global::System.Drawing.Point(6, 86);
			this.labelGamesPerGroup.Name = "labelGamesPerGroup";
			this.labelGamesPerGroup.Size = new global::System.Drawing.Size(188, 20);
			this.labelGamesPerGroup.TabIndex = 127;
			this.labelGamesPerGroup.Text = "Number of Games";
			this.labelGamesPerGroup.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelNumberofGroups.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelNumberofGroups.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNumberofGroups.Location = new global::System.Drawing.Point(6, 26);
			this.labelNumberofGroups.Name = "labelNumberofGroups";
			this.labelNumberofGroups.Size = new global::System.Drawing.Size(188, 20);
			this.labelNumberofGroups.TabIndex = 126;
			this.labelNumberofGroups.Text = "Number of Groups";
			this.labelNumberofGroups.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelTeamPerGroup.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelTeamPerGroup.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelTeamPerGroup.Location = new global::System.Drawing.Point(6, 56);
			this.labelTeamPerGroup.Name = "labelTeamPerGroup";
			this.labelTeamPerGroup.Size = new global::System.Drawing.Size(188, 20);
			this.labelTeamPerGroup.TabIndex = 125;
			this.labelTeamPerGroup.Text = "Teams per Group";
			this.labelTeamPerGroup.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupPreliminary.Controls.Add(this.numericPrelimGames);
			this.groupPreliminary.Controls.Add(this.numericPreliminaryTeams);
			this.groupPreliminary.Controls.Add(this.labelNumberofGames);
			this.groupPreliminary.Controls.Add(this.labelPrelimNTeams);
			this.groupPreliminary.Location = new global::System.Drawing.Point(15, 184);
			this.groupPreliminary.Name = "groupPreliminary";
			this.groupPreliminary.Size = new global::System.Drawing.Size(200, 144);
			this.groupPreliminary.TabIndex = 144;
			this.groupPreliminary.TabStop = false;
			this.groupPreliminary.Text = "Preliminary Stage Options";
			this.groupPreliminary.Visible = false;
			this.numericPrelimGames.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericPrelimGames.Location = new global::System.Drawing.Point(125, 56);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericPrelimGames;
			int[] array13 = new int[4];
			array13[0] = 2;
			numericUpDown13.Maximum = new decimal(array13);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericPrelimGames;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Minimum = new decimal(array14);
			this.numericPrelimGames.Name = "numericPrelimGames";
			this.numericPrelimGames.ReadOnly = true;
			this.numericPrelimGames.Size = new global::System.Drawing.Size(69, 20);
			this.numericPrelimGames.TabIndex = 127;
			this.numericPrelimGames.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numericPrelimGames;
			int[] array15 = new int[4];
			array15[0] = 1;
			numericUpDown15.Value = new decimal(array15);
			this.numericPrelimGames.ValueChanged += new global::System.EventHandler(this.numericPrelimGames_ValueChanged);
			this.numericPreliminaryTeams.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericPreliminaryTeams.Enabled = false;
			this.numericPreliminaryTeams.Location = new global::System.Drawing.Point(125, 26);
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numericPreliminaryTeams;
			int[] array16 = new int[4];
			array16[0] = 64;
			numericUpDown16.Maximum = new decimal(array16);
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numericPreliminaryTeams;
			int[] array17 = new int[4];
			array17[0] = 2;
			numericUpDown17.Minimum = new decimal(array17);
			this.numericPreliminaryTeams.Name = "numericPreliminaryTeams";
			this.numericPreliminaryTeams.ReadOnly = true;
			this.numericPreliminaryTeams.Size = new global::System.Drawing.Size(69, 20);
			this.numericPreliminaryTeams.TabIndex = 126;
			this.numericPreliminaryTeams.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numericPreliminaryTeams;
			int[] array18 = new int[4];
			array18[0] = 3;
			numericUpDown18.Value = new decimal(array18);
			this.labelNumberofGames.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelNumberofGames.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNumberofGames.Location = new global::System.Drawing.Point(6, 56);
			this.labelNumberofGames.Name = "labelNumberofGames";
			this.labelNumberofGames.Size = new global::System.Drawing.Size(188, 20);
			this.labelNumberofGames.TabIndex = 125;
			this.labelNumberofGames.Text = "Number of Games";
			this.labelNumberofGames.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPrelimNTeams.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelPrelimNTeams.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelPrelimNTeams.Location = new global::System.Drawing.Point(6, 26);
			this.labelPrelimNTeams.Name = "labelPrelimNTeams";
			this.labelPrelimNTeams.Size = new global::System.Drawing.Size(188, 20);
			this.labelPrelimNTeams.TabIndex = 124;
			this.labelPrelimNTeams.Text = "Number of Teams";
			this.labelPrelimNTeams.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupStructure.Controls.Add(this.radioEuro2008);
			this.groupStructure.Controls.Add(this.radioEuro2004);
			this.groupStructure.Controls.Add(this.radioWC2006);
			this.groupStructure.Controls.Add(this.radioPGKO);
			this.groupStructure.Controls.Add(this.radioPKO);
			this.groupStructure.Controls.Add(this.radioGKO);
			this.groupStructure.Controls.Add(this.radioKO);
			this.groupStructure.Controls.Add(this.radioLeague);
			this.groupStructure.Location = new global::System.Drawing.Point(15, 35);
			this.groupStructure.Name = "groupStructure";
			this.groupStructure.Size = new global::System.Drawing.Size(624, 117);
			this.groupStructure.TabIndex = 143;
			this.groupStructure.TabStop = false;
			this.groupStructure.Text = "Tournament Structure";
			this.radioEuro2008.AutoSize = true;
			this.radioEuro2008.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioEuro2008.Location = new global::System.Drawing.Point(439, 79);
			this.radioEuro2008.Name = "radioEuro2008";
			this.radioEuro2008.Size = new global::System.Drawing.Size(109, 17);
			this.radioEuro2008.TabIndex = 7;
			this.radioEuro2008.TabStop = true;
			this.radioEuro2008.Text = "Euro 2008 Format";
			this.radioEuro2008.UseVisualStyleBackColor = true;
			this.radioEuro2008.CheckedChanged += new global::System.EventHandler(this.radioEuro2008_CheckedChanged);
			this.radioEuro2004.AutoSize = true;
			this.radioEuro2004.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioEuro2004.Location = new global::System.Drawing.Point(439, 56);
			this.radioEuro2004.Name = "radioEuro2004";
			this.radioEuro2004.Size = new global::System.Drawing.Size(109, 17);
			this.radioEuro2004.TabIndex = 6;
			this.radioEuro2004.TabStop = true;
			this.radioEuro2004.Text = "Euro 2004 Format";
			this.radioEuro2004.UseVisualStyleBackColor = true;
			this.radioEuro2004.CheckedChanged += new global::System.EventHandler(this.radioEuro2004_CheckedChanged);
			this.radioWC2006.AutoSize = true;
			this.radioWC2006.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioWC2006.Location = new global::System.Drawing.Point(439, 33);
			this.radioWC2006.Name = "radioWC2006";
			this.radioWC2006.Size = new global::System.Drawing.Size(78, 17);
			this.radioWC2006.TabIndex = 5;
			this.radioWC2006.TabStop = true;
			this.radioWC2006.Text = "WC Format";
			this.radioWC2006.UseVisualStyleBackColor = true;
			this.radioWC2006.CheckedChanged += new global::System.EventHandler(this.radioWC2006_CheckedChanged);
			this.radioPGKO.AutoSize = true;
			this.radioPGKO.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPGKO.Location = new global::System.Drawing.Point(195, 79);
			this.radioPGKO.Name = "radioPGKO";
			this.radioPGKO.Size = new global::System.Drawing.Size(210, 17);
			this.radioPGKO.TabIndex = 4;
			this.radioPGKO.TabStop = true;
			this.radioPGKO.Text = "Preliminary + Group Stage + Knock Out";
			this.radioPGKO.UseVisualStyleBackColor = true;
			this.radioPGKO.CheckedChanged += new global::System.EventHandler(this.radioPGKO_CheckedChanged);
			this.radioPKO.AutoSize = true;
			this.radioPKO.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPKO.Location = new global::System.Drawing.Point(195, 56);
			this.radioPKO.Name = "radioPKO";
			this.radioPKO.Size = new global::System.Drawing.Size(138, 17);
			this.radioPKO.TabIndex = 3;
			this.radioPKO.TabStop = true;
			this.radioPKO.Text = "Preliminary + Knock Out";
			this.radioPKO.UseVisualStyleBackColor = true;
			this.radioPKO.CheckedChanged += new global::System.EventHandler(this.radioPKO_CheckedChanged);
			this.radioGKO.AutoSize = true;
			this.radioGKO.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioGKO.Location = new global::System.Drawing.Point(28, 79);
			this.radioGKO.Name = "radioGKO";
			this.radioGKO.Size = new global::System.Drawing.Size(151, 17);
			this.radioGKO.TabIndex = 2;
			this.radioGKO.TabStop = true;
			this.radioGKO.Text = "Groups Stage + Knock out";
			this.radioGKO.UseVisualStyleBackColor = true;
			this.radioGKO.CheckedChanged += new global::System.EventHandler(this.radioGKO_CheckedChanged);
			this.radioKO.AutoSize = true;
			this.radioKO.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioKO.Location = new global::System.Drawing.Point(28, 56);
			this.radioKO.Name = "radioKO";
			this.radioKO.Size = new global::System.Drawing.Size(76, 17);
			this.radioKO.TabIndex = 1;
			this.radioKO.TabStop = true;
			this.radioKO.Text = "Knock Out";
			this.radioKO.UseVisualStyleBackColor = true;
			this.radioKO.CheckedChanged += new global::System.EventHandler(this.radioKO_CheckedChanged);
			this.radioLeague.AutoSize = true;
			this.radioLeague.Checked = true;
			this.radioLeague.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioLeague.Location = new global::System.Drawing.Point(28, 33);
			this.radioLeague.Name = "radioLeague";
			this.radioLeague.Size = new global::System.Drawing.Size(61, 17);
			this.radioLeague.TabIndex = 0;
			this.radioLeague.TabStop = true;
			this.radioLeague.Text = "League";
			this.radioLeague.UseVisualStyleBackColor = true;
			this.radioLeague.CheckedChanged += new global::System.EventHandler(this.radioLeague_CheckedChanged);
			this.numericNTeams.Location = new global::System.Drawing.Point(140, 9);
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numericNTeams;
			int[] array19 = new int[4];
			array19[0] = 64;
			numericUpDown19.Maximum = new decimal(array19);
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numericNTeams;
			int[] array20 = new int[4];
			array20[0] = 3;
			numericUpDown20.Minimum = new decimal(array20);
			this.numericNTeams.Name = "numericNTeams";
			this.numericNTeams.Size = new global::System.Drawing.Size(60, 20);
			this.numericNTeams.TabIndex = 141;
			this.numericNTeams.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numericNTeams;
			int[] array21 = new int[4];
			array21[0] = 3;
			numericUpDown21.Value = new decimal(array21);
			this.numericNTeams.ValueChanged += new global::System.EventHandler(this.numericNTeams_ValueChanged);
			this.labelNumberofTeams.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelNumberofTeams.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNumberofTeams.Location = new global::System.Drawing.Point(12, 9);
			this.labelNumberofTeams.Name = "labelNumberofTeams";
			this.labelNumberofTeams.Size = new global::System.Drawing.Size(188, 20);
			this.labelNumberofTeams.TabIndex = 142;
			this.labelNumberofTeams.Text = "Number of Teams";
			this.labelNumberofTeams.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupLeague.Controls.Add(this.numericLeagueGames);
			this.groupLeague.Controls.Add(this.labelLeagueGames);
			this.groupLeague.Location = new global::System.Drawing.Point(15, 184);
			this.groupLeague.Name = "groupLeague";
			this.groupLeague.Size = new global::System.Drawing.Size(200, 144);
			this.groupLeague.TabIndex = 149;
			this.groupLeague.TabStop = false;
			this.groupLeague.Text = "League Options";
			this.groupLeague.Visible = false;
			this.numericLeagueGames.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.numericLeagueGames.Location = new global::System.Drawing.Point(125, 26);
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numericLeagueGames;
			int[] array22 = new int[4];
			array22[0] = 2;
			numericUpDown22.Maximum = new decimal(array22);
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numericLeagueGames;
			int[] array23 = new int[4];
			array23[0] = 1;
			numericUpDown23.Minimum = new decimal(array23);
			this.numericLeagueGames.Name = "numericLeagueGames";
			this.numericLeagueGames.ReadOnly = true;
			this.numericLeagueGames.Size = new global::System.Drawing.Size(69, 20);
			this.numericLeagueGames.TabIndex = 129;
			this.numericLeagueGames.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numericLeagueGames;
			int[] array24 = new int[4];
			array24[0] = 1;
			numericUpDown24.Value = new decimal(array24);
			this.labelLeagueGames.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.labelLeagueGames.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueGames.Location = new global::System.Drawing.Point(6, 26);
			this.labelLeagueGames.Name = "labelLeagueGames";
			this.labelLeagueGames.Size = new global::System.Drawing.Size(188, 20);
			this.labelLeagueGames.TabIndex = 128;
			this.labelLeagueGames.Text = "Number of Games";
			this.labelLeagueGames.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupQualification.Controls.Add(this.labelLeagueReadHelp);
			this.groupQualification.Location = new global::System.Drawing.Point(15, 184);
			this.groupQualification.Name = "groupQualification";
			this.groupQualification.Size = new global::System.Drawing.Size(200, 144);
			this.groupQualification.TabIndex = 145;
			this.groupQualification.TabStop = false;
			this.groupQualification.Text = "Special Format";
			this.groupQualification.Visible = false;
			this.labelLeagueReadHelp.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLeagueReadHelp.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLeagueReadHelp.Location = new global::System.Drawing.Point(6, 62);
			this.labelLeagueReadHelp.Name = "labelLeagueReadHelp";
			this.labelLeagueReadHelp.Size = new global::System.Drawing.Size(188, 20);
			this.labelLeagueReadHelp.TabIndex = 127;
			this.labelLeagueReadHelp.Text = "See the Help";
			this.labelLeagueReadHelp.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(649, 384);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.groupKO);
			base.Controls.Add(this.groupGroups);
			base.Controls.Add(this.groupPreliminary);
			base.Controls.Add(this.groupStructure);
			base.Controls.Add(this.numericNTeams);
			base.Controls.Add(this.labelNumberofTeams);
			base.Controls.Add(this.groupLeague);
			base.Controls.Add(this.groupQualification);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "TournamentWizard";
			this.Text = "TournamentWizard";
			this.groupKO.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericFinalGames).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericKOGames).EndInit();
			this.groupGroups.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericGamesPerGroup).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamsPerGroup).EndInit();
			this.groupPreliminary.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericPrelimGames).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericPreliminaryTeams).EndInit();
			this.groupStructure.ResumeLayout(false);
			this.groupStructure.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNTeams).EndInit();
			this.groupLeague.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericLeagueGames).EndInit();
			this.groupQualification.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040007D4 RID: 2004
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007D5 RID: 2005
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x040007D6 RID: 2006
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x040007D7 RID: 2007
		private global::System.Windows.Forms.GroupBox groupKO;

		// Token: 0x040007D8 RID: 2008
		private global::System.Windows.Forms.NumericUpDown numericFinalGames;

		// Token: 0x040007D9 RID: 2009
		private global::System.Windows.Forms.NumericUpDown numericKOGames;

		// Token: 0x040007DA RID: 2010
		private global::System.Windows.Forms.DomainUpDown domainNTeamsKO;

		// Token: 0x040007DB RID: 2011
		private global::System.Windows.Forms.Label labelFinalGames;

		// Token: 0x040007DC RID: 2012
		private global::System.Windows.Forms.Label labelNTeamsKO;

		// Token: 0x040007DD RID: 2013
		private global::System.Windows.Forms.Label labelKnockOutGames;

		// Token: 0x040007DE RID: 2014
		private global::System.Windows.Forms.GroupBox groupGroups;

		// Token: 0x040007DF RID: 2015
		private global::System.Windows.Forms.NumericUpDown numericGamesPerGroup;

		// Token: 0x040007E0 RID: 2016
		private global::System.Windows.Forms.NumericUpDown numericTeamsPerGroup;

		// Token: 0x040007E1 RID: 2017
		private global::System.Windows.Forms.DomainUpDown domainNGroups;

		// Token: 0x040007E2 RID: 2018
		private global::System.Windows.Forms.Label labelGamesPerGroup;

		// Token: 0x040007E3 RID: 2019
		private global::System.Windows.Forms.Label labelNumberofGroups;

		// Token: 0x040007E4 RID: 2020
		private global::System.Windows.Forms.Label labelTeamPerGroup;

		// Token: 0x040007E5 RID: 2021
		private global::System.Windows.Forms.GroupBox groupPreliminary;

		// Token: 0x040007E6 RID: 2022
		private global::System.Windows.Forms.NumericUpDown numericPrelimGames;

		// Token: 0x040007E7 RID: 2023
		private global::System.Windows.Forms.NumericUpDown numericPreliminaryTeams;

		// Token: 0x040007E8 RID: 2024
		private global::System.Windows.Forms.Label labelNumberofGames;

		// Token: 0x040007E9 RID: 2025
		private global::System.Windows.Forms.Label labelPrelimNTeams;

		// Token: 0x040007EA RID: 2026
		private global::System.Windows.Forms.GroupBox groupStructure;

		// Token: 0x040007EB RID: 2027
		private global::System.Windows.Forms.RadioButton radioEuro2008;

		// Token: 0x040007EC RID: 2028
		private global::System.Windows.Forms.RadioButton radioEuro2004;

		// Token: 0x040007ED RID: 2029
		private global::System.Windows.Forms.RadioButton radioWC2006;

		// Token: 0x040007EE RID: 2030
		private global::System.Windows.Forms.RadioButton radioPGKO;

		// Token: 0x040007EF RID: 2031
		private global::System.Windows.Forms.RadioButton radioPKO;

		// Token: 0x040007F0 RID: 2032
		private global::System.Windows.Forms.RadioButton radioGKO;

		// Token: 0x040007F1 RID: 2033
		private global::System.Windows.Forms.RadioButton radioKO;

		// Token: 0x040007F2 RID: 2034
		private global::System.Windows.Forms.RadioButton radioLeague;

		// Token: 0x040007F3 RID: 2035
		private global::System.Windows.Forms.NumericUpDown numericNTeams;

		// Token: 0x040007F4 RID: 2036
		private global::System.Windows.Forms.Label labelNumberofTeams;

		// Token: 0x040007F5 RID: 2037
		private global::System.Windows.Forms.GroupBox groupLeague;

		// Token: 0x040007F6 RID: 2038
		private global::System.Windows.Forms.NumericUpDown numericLeagueGames;

		// Token: 0x040007F7 RID: 2039
		private global::System.Windows.Forms.Label labelLeagueGames;

		// Token: 0x040007F8 RID: 2040
		private global::System.Windows.Forms.GroupBox groupQualification;

		// Token: 0x040007F9 RID: 2041
		private global::System.Windows.Forms.Label labelLeagueReadHelp;
	}
}
