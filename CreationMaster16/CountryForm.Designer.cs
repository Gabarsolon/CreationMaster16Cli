namespace CreationMaster
{
	// Token: 0x02000011 RID: 17
	public partial class CountryForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060002CD RID: 717 RVA: 0x00049AA5 File Offset: 0x00047CA5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00049AC4 File Offset: 0x00047CC4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.CountryForm));
			this.flowLayoutPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupBox = new global::System.Windows.Forms.GroupBox();
			this.textIsoCountryCode = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.labelContry3Letters = new global::System.Windows.Forms.Label();
			this.textLanguageAbbreviation = new global::System.Windows.Forms.TextBox();
			this.textLanguageShortName = new global::System.Windows.Forms.TextBox();
			this.labelNationShortName = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.numericLevel = new global::System.Windows.Forms.NumericUpDown();
			this.comboRegionalTarget = new global::System.Windows.Forms.ComboBox();
			this.comboWorkltarget = new global::System.Windows.Forms.ComboBox();
			this.labeRegionalTarget = new global::System.Windows.Forms.Label();
			this.labelWorldTarget = new global::System.Windows.Forms.Label();
			this.checkTopTier = new global::System.Windows.Forms.CheckBox();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.numericCountryId = new global::System.Windows.Forms.NumericUpDown();
			this.comboContinent = new global::System.Windows.Forms.ComboBox();
			this.textLanguageName = new global::System.Windows.Forms.TextBox();
			this.labelLanguageName = new global::System.Windows.Forms.Label();
			this.textDatabaseCountryName = new global::System.Windows.Forms.TextBox();
			this.labelDatabaseCountryName = new global::System.Windows.Forms.Label();
			this.labelContinent = new global::System.Windows.Forms.Label();
			this.labelCountrId = new global::System.Windows.Forms.Label();
			this.groupCountryShape = new global::System.Windows.Forms.GroupBox();
			this.groupAudio = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboPepper = new global::System.Windows.Forms.ComboBox();
			this.comboPlayerCall = new global::System.Windows.Forms.ComboBox();
			this.comboCrowdType = new global::System.Windows.Forms.ComboBox();
			this.checkCanWhistle = new global::System.Windows.Forms.CheckBox();
			this.checkTauntKeeper = new global::System.Windows.Forms.CheckBox();
			this.comboLanguage = new global::System.Windows.Forms.ComboBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.comboChants = new global::System.Windows.Forms.ComboBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.numericNationalTeam = new global::System.Windows.Forms.NumericUpDown();
			this.labelNationalTeam = new global::System.Windows.Forms.Label();
			this.pictureNationalTeam = new global::System.Windows.Forms.PictureBox();
			this.comboNationalTeam = new global::System.Windows.Forms.ComboBox();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.sponsorListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.countryBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.viewer2DFlag512 = new global::FifaControls.Viewer2D();
			this.viewer2DFlag = new global::FifaControls.Viewer2D();
			this.viewer2DCardFlag = new global::FifaControls.Viewer2D();
			this.viewer2DMiniFlag = new global::FifaControls.Viewer2D();
			this.viewer2DShape = new global::FifaControls.Viewer2D();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.flowLayoutPanel.SuspendLayout();
			this.groupBox.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericLevel).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCountryId).BeginInit();
			this.groupCountryShape.SuspendLayout();
			this.groupAudio.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNationalTeam).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureNationalTeam).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.sponsorListBindingSource).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.countryBindingSource).BeginInit();
			base.SuspendLayout();
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Controls.Add(this.groupBox);
			this.flowLayoutPanel.Controls.Add(this.groupCountryShape);
			this.flowLayoutPanel.Controls.Add(this.groupAudio);
			this.flowLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.Location = new global::System.Drawing.Point(0, 25);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new global::System.Drawing.Size(1357, 807);
			this.flowLayoutPanel.TabIndex = 0;
			this.groupBox.Controls.Add(this.groupBox1);
			this.groupBox.Controls.Add(this.textIsoCountryCode);
			this.groupBox.Controls.Add(this.label5);
			this.groupBox.Controls.Add(this.viewer2DFlag512);
			this.groupBox.Controls.Add(this.labelContry3Letters);
			this.groupBox.Controls.Add(this.textLanguageAbbreviation);
			this.groupBox.Controls.Add(this.textLanguageShortName);
			this.groupBox.Controls.Add(this.labelNationShortName);
			this.groupBox.Controls.Add(this.label4);
			this.groupBox.Controls.Add(this.numericLevel);
			this.groupBox.Controls.Add(this.checkTopTier);
			this.groupBox.Controls.Add(this.buttonGetId);
			this.groupBox.Controls.Add(this.viewer2DFlag);
			this.groupBox.Controls.Add(this.viewer2DCardFlag);
			this.groupBox.Controls.Add(this.viewer2DMiniFlag);
			this.groupBox.Controls.Add(this.numericCountryId);
			this.groupBox.Controls.Add(this.comboContinent);
			this.groupBox.Controls.Add(this.textLanguageName);
			this.groupBox.Controls.Add(this.labelLanguageName);
			this.groupBox.Controls.Add(this.textDatabaseCountryName);
			this.groupBox.Controls.Add(this.labelDatabaseCountryName);
			this.groupBox.Controls.Add(this.labelContinent);
			this.groupBox.Controls.Add(this.labelCountrId);
			this.groupBox.Location = new global::System.Drawing.Point(3, 1);
			this.groupBox.Margin = new global::System.Windows.Forms.Padding(3, 1, 3, 3);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new global::System.Drawing.Size(767, 489);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.textIsoCountryCode.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.countryBindingSource, "IsoCountryCode", true));
			this.textIsoCountryCode.Location = new global::System.Drawing.Point(117, 195);
			this.textIsoCountryCode.Name = "textIsoCountryCode";
			this.textIsoCountryCode.Size = new global::System.Drawing.Size(117, 20);
			this.textIsoCountryCode.TabIndex = 164;
			this.textIsoCountryCode.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new global::System.Drawing.Point(11, 198);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(92, 13);
			this.label5.TabIndex = 163;
			this.label5.Text = "ISO Country Code";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelContry3Letters.AutoSize = true;
			this.labelContry3Letters.BackColor = global::System.Drawing.Color.Transparent;
			this.labelContry3Letters.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelContry3Letters.Location = new global::System.Drawing.Point(11, 137);
			this.labelContry3Letters.Name = "labelContry3Letters";
			this.labelContry3Letters.Size = new global::System.Drawing.Size(66, 13);
			this.labelContry3Letters.TabIndex = 161;
			this.labelContry3Letters.Text = "Abbreviation";
			this.labelContry3Letters.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textLanguageAbbreviation.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.countryBindingSource, "LanguageAbbreviation", true));
			this.textLanguageAbbreviation.Location = new global::System.Drawing.Point(101, 134);
			this.textLanguageAbbreviation.Name = "textLanguageAbbreviation";
			this.textLanguageAbbreviation.Size = new global::System.Drawing.Size(133, 20);
			this.textLanguageAbbreviation.TabIndex = 160;
			this.textLanguageShortName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.countryBindingSource, "LanguageShortName", true));
			this.textLanguageShortName.Location = new global::System.Drawing.Point(101, 104);
			this.textLanguageShortName.Name = "textLanguageShortName";
			this.textLanguageShortName.Size = new global::System.Drawing.Size(133, 20);
			this.textLanguageShortName.TabIndex = 158;
			this.textLanguageShortName.TextChanged += new global::System.EventHandler(this.textLanguageShortName_TextChanged);
			this.labelNationShortName.AutoSize = true;
			this.labelNationShortName.BackColor = global::System.Drawing.Color.Transparent;
			this.labelNationShortName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNationShortName.Location = new global::System.Drawing.Point(11, 107);
			this.labelNationShortName.Name = "labelNationShortName";
			this.labelNationShortName.Size = new global::System.Drawing.Size(63, 13);
			this.labelNationShortName.TabIndex = 159;
			this.labelNationShortName.Text = "Short Name";
			this.labelNationShortName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(11, 227);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(33, 13);
			this.label4.TabIndex = 157;
			this.label4.Text = "Level";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericLevel.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.countryBindingSource, "Level", true));
			this.numericLevel.Location = new global::System.Drawing.Point(117, 225);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericLevel;
			int[] array = new int[4];
			array[0] = 7;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericLevel;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericLevel.Name = "numericLevel";
			this.numericLevel.Size = new global::System.Drawing.Size(115, 20);
			this.numericLevel.TabIndex = 156;
			this.numericLevel.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericLevel;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.comboRegionalTarget.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.countryBindingSource, "ContinentalCupTarget", true));
			this.comboRegionalTarget.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.comboRegionalTarget.ItemHeight = 13;
			this.comboRegionalTarget.Items.AddRange(new object[] { "N/A", "WIN", "FINAL", "SEMI", "QUARTER", "KNOCKOUT", "QUALIFY" });
			this.comboRegionalTarget.Location = new global::System.Drawing.Point(117, 44);
			this.comboRegionalTarget.Name = "comboRegionalTarget";
			this.comboRegionalTarget.Size = new global::System.Drawing.Size(102, 21);
			this.comboRegionalTarget.TabIndex = 155;
			this.comboWorkltarget.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.countryBindingSource, "WorldCupTarget", true));
			this.comboWorkltarget.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.comboWorkltarget.ItemHeight = 13;
			this.comboWorkltarget.Items.AddRange(new object[] { "N/A", "WIN", "FINAL", "SEMI", "QUARTER", "KNOCKOUT", "QUALIFY" });
			this.comboWorkltarget.Location = new global::System.Drawing.Point(117, 18);
			this.comboWorkltarget.Name = "comboWorkltarget";
			this.comboWorkltarget.Size = new global::System.Drawing.Size(102, 21);
			this.comboWorkltarget.TabIndex = 154;
			this.labeRegionalTarget.AutoSize = true;
			this.labeRegionalTarget.BackColor = global::System.Drawing.SystemColors.Control;
			this.labeRegionalTarget.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labeRegionalTarget.Location = new global::System.Drawing.Point(6, 45);
			this.labeRegionalTarget.Name = "labeRegionalTarget";
			this.labeRegionalTarget.Size = new global::System.Drawing.Size(105, 13);
			this.labeRegionalTarget.TabIndex = 153;
			this.labeRegionalTarget.Text = "Regional Cup Target";
			this.labeRegionalTarget.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelWorldTarget.AutoSize = true;
			this.labelWorldTarget.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelWorldTarget.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelWorldTarget.Location = new global::System.Drawing.Point(6, 20);
			this.labelWorldTarget.Name = "labelWorldTarget";
			this.labelWorldTarget.Size = new global::System.Drawing.Size(91, 13);
			this.labelWorldTarget.TabIndex = 152;
			this.labelWorldTarget.Text = "World Cup Target";
			this.labelWorldTarget.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkTopTier.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.countryBindingSource, "Top_tier", true));
			this.checkTopTier.Location = new global::System.Drawing.Point(11, 255);
			this.checkTopTier.Name = "checkTopTier";
			this.checkTopTier.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkTopTier.Size = new global::System.Drawing.Size(164, 18);
			this.checkTopTier.TabIndex = 151;
			this.checkTopTier.Text = "Top tier";
			this.checkTopTier.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkTopTier.UseVisualStyleBackColor = true;
			this.buttonGetId.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetId.Image");
			this.buttonGetId.Location = new global::System.Drawing.Point(207, 37);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(25, 23);
			this.buttonGetId.TabIndex = 150;
			this.toolTip.SetToolTip(this.buttonGetId, "Get a free id");
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.numericCountryId.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.countryBindingSource, "Id", true));
			this.numericCountryId.Location = new global::System.Drawing.Point(101, 44);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericCountryId;
			int[] array4 = new int[4];
			array4[0] = 200000;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericCountryId.Name = "numericCountryId";
			this.numericCountryId.Size = new global::System.Drawing.Size(100, 20);
			this.numericCountryId.TabIndex = 143;
			this.numericCountryId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCountryId.ValueChanged += new global::System.EventHandler(this.numericCountryId_ValueChanged);
			this.comboContinent.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.countryBindingSource, "Confederation", true));
			this.comboContinent.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.comboContinent.ItemHeight = 13;
			this.comboContinent.Items.AddRange(new object[] { "None", "Europe", "Africa", "South America", "Asia", "Oceania", "North America" });
			this.comboContinent.Location = new global::System.Drawing.Point(101, 164);
			this.comboContinent.Name = "comboContinent";
			this.comboContinent.Size = new global::System.Drawing.Size(133, 21);
			this.comboContinent.TabIndex = 145;
			this.textLanguageName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.countryBindingSource, "LanguageName", true));
			this.textLanguageName.Location = new global::System.Drawing.Point(101, 74);
			this.textLanguageName.Name = "textLanguageName";
			this.textLanguageName.Size = new global::System.Drawing.Size(133, 20);
			this.textLanguageName.TabIndex = 144;
			this.textLanguageName.TextChanged += new global::System.EventHandler(this.textLanguageName_TextChanged);
			this.labelLanguageName.AutoSize = true;
			this.labelLanguageName.BackColor = global::System.Drawing.Color.Transparent;
			this.labelLanguageName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLanguageName.Location = new global::System.Drawing.Point(11, 77);
			this.labelLanguageName.Name = "labelLanguageName";
			this.labelLanguageName.Size = new global::System.Drawing.Size(35, 13);
			this.labelLanguageName.TabIndex = 147;
			this.labelLanguageName.Text = "Name";
			this.labelLanguageName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textDatabaseCountryName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.countryBindingSource, "DatabaseName", true));
			this.textDatabaseCountryName.Location = new global::System.Drawing.Point(101, 14);
			this.textDatabaseCountryName.Name = "textDatabaseCountryName";
			this.textDatabaseCountryName.Size = new global::System.Drawing.Size(133, 20);
			this.textDatabaseCountryName.TabIndex = 142;
			this.labelDatabaseCountryName.AutoSize = true;
			this.labelDatabaseCountryName.BackColor = global::System.Drawing.Color.Transparent;
			this.labelDatabaseCountryName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDatabaseCountryName.Location = new global::System.Drawing.Point(11, 18);
			this.labelDatabaseCountryName.Name = "labelDatabaseCountryName";
			this.labelDatabaseCountryName.Size = new global::System.Drawing.Size(84, 13);
			this.labelDatabaseCountryName.TabIndex = 146;
			this.labelDatabaseCountryName.Text = "Database Name";
			this.labelDatabaseCountryName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelContinent.AutoSize = true;
			this.labelContinent.BackColor = global::System.Drawing.Color.Transparent;
			this.labelContinent.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelContinent.Location = new global::System.Drawing.Point(11, 167);
			this.labelContinent.Name = "labelContinent";
			this.labelContinent.Size = new global::System.Drawing.Size(73, 13);
			this.labelContinent.TabIndex = 148;
			this.labelContinent.Text = "Confederation";
			this.labelContinent.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountrId.AutoSize = true;
			this.labelCountrId.BackColor = global::System.Drawing.Color.Transparent;
			this.labelCountrId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCountrId.Location = new global::System.Drawing.Point(11, 47);
			this.labelCountrId.Name = "labelCountrId";
			this.labelCountrId.Size = new global::System.Drawing.Size(55, 13);
			this.labelCountrId.TabIndex = 149;
			this.labelCountrId.Text = "Country Id";
			this.labelCountrId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupCountryShape.Controls.Add(this.viewer2DShape);
			this.groupCountryShape.Location = new global::System.Drawing.Point(776, 3);
			this.groupCountryShape.Name = "groupCountryShape";
			this.groupCountryShape.Size = new global::System.Drawing.Size(528, 308);
			this.groupCountryShape.TabIndex = 4;
			this.groupCountryShape.TabStop = false;
			this.groupCountryShape.Text = "Map (Shape)";
			this.groupAudio.Controls.Add(this.label3);
			this.groupAudio.Controls.Add(this.label2);
			this.groupAudio.Controls.Add(this.label1);
			this.groupAudio.Controls.Add(this.comboPepper);
			this.groupAudio.Controls.Add(this.comboPlayerCall);
			this.groupAudio.Controls.Add(this.comboCrowdType);
			this.groupAudio.Controls.Add(this.checkCanWhistle);
			this.groupAudio.Controls.Add(this.checkTauntKeeper);
			this.groupAudio.Controls.Add(this.comboLanguage);
			this.groupAudio.Controls.Add(this.label15);
			this.groupAudio.Controls.Add(this.label14);
			this.groupAudio.Controls.Add(this.label11);
			this.groupAudio.Controls.Add(this.label10);
			this.groupAudio.Controls.Add(this.labelNationalTeam);
			this.groupAudio.Controls.Add(this.comboChants);
			this.groupAudio.Controls.Add(this.label9);
			this.groupAudio.Controls.Add(this.numericNationalTeam);
			this.groupAudio.Controls.Add(this.comboNationalTeam);
			this.groupAudio.Location = new global::System.Drawing.Point(3, 496);
			this.groupAudio.Name = "groupAudio";
			this.groupAudio.Size = new global::System.Drawing.Size(624, 250);
			this.groupAudio.TabIndex = 3;
			this.groupAudio.TabStop = false;
			this.groupAudio.Text = "Audio";
			this.groupAudio.Visible = false;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(11, 219);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(55, 13);
			this.label3.TabIndex = 33;
			this.label3.Text = "Reactions";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 192);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(46, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Heckles";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 165);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(54, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Ambience";
			this.comboPepper.FormattingEnabled = true;
			this.comboPepper.Items.AddRange(new object[] { "Undefined", "English", "French", "Italian", "German", "Spanish", "Scandinavian", "Brazilian" });
			this.comboPepper.Location = new global::System.Drawing.Point(88, 132);
			this.comboPepper.Name = "comboPepper";
			this.comboPepper.Size = new global::System.Drawing.Size(145, 21);
			this.comboPepper.TabIndex = 29;
			this.comboPepper.SelectedIndexChanged += new global::System.EventHandler(this.comboPepper_SelectedIndexChanged);
			this.comboPlayerCall.FormattingEnabled = true;
			this.comboPlayerCall.Items.AddRange(new object[]
			{
				"English", "French", "Italian", "German", "Spanish", "Brazilian", "Japaneese", "Korean", "Dutch", "Danish",
				"Swedish", "Norwegian", "Portuguese", "Russian", "US English", "Iranian", "Indian", "Chineese", "Arabic"
			});
			this.comboPlayerCall.Location = new global::System.Drawing.Point(88, 105);
			this.comboPlayerCall.Name = "comboPlayerCall";
			this.comboPlayerCall.Size = new global::System.Drawing.Size(145, 21);
			this.comboPlayerCall.TabIndex = 28;
			this.comboPlayerCall.SelectedIndexChanged += new global::System.EventHandler(this.comboPlayerCall_SelectedIndexChanged);
			this.comboCrowdType.FormattingEnabled = true;
			this.comboCrowdType.Items.AddRange(new object[] { " 0 = English", " 8 = Brazilian", "15 = Rest of World" });
			this.comboCrowdType.Location = new global::System.Drawing.Point(88, 78);
			this.comboCrowdType.Name = "comboCrowdType";
			this.comboCrowdType.Size = new global::System.Drawing.Size(145, 21);
			this.comboCrowdType.TabIndex = 27;
			this.comboCrowdType.SelectedIndexChanged += new global::System.EventHandler(this.comboCrowdType_SelectedIndexChanged);
			this.checkCanWhistle.AutoSize = true;
			this.checkCanWhistle.Location = new global::System.Drawing.Point(259, 48);
			this.checkCanWhistle.Name = "checkCanWhistle";
			this.checkCanWhistle.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkCanWhistle.Size = new global::System.Drawing.Size(83, 17);
			this.checkCanWhistle.TabIndex = 26;
			this.checkCanWhistle.Text = "Can Whistle";
			this.checkCanWhistle.UseVisualStyleBackColor = true;
			this.checkCanWhistle.CheckedChanged += new global::System.EventHandler(this.checkCanWhistle_CheckedChanged);
			this.checkTauntKeeper.AutoSize = true;
			this.checkTauntKeeper.Location = new global::System.Drawing.Point(251, 25);
			this.checkTauntKeeper.Name = "checkTauntKeeper";
			this.checkTauntKeeper.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkTauntKeeper.Size = new global::System.Drawing.Size(91, 17);
			this.checkTauntKeeper.TabIndex = 25;
			this.checkTauntKeeper.Text = "Taunt Keeper";
			this.checkTauntKeeper.UseVisualStyleBackColor = true;
			this.checkTauntKeeper.CheckedChanged += new global::System.EventHandler(this.checkTauntKeeper_CheckedChanged);
			this.comboLanguage.FormattingEnabled = true;
			this.comboLanguage.Items.AddRange(new object[]
			{
				"English ", "French ", "German ", "Italian ", "Spanish from Spain ", "Croatian", "Czech", "Dutch", "Greek", "Polish ",
				"Russian", "Swedish", "Turkish", "Spanish from Mexico ", "Spanish from Argentina ", "Brazilian Portuguese", "Korean", "Japanese"
			});
			this.comboLanguage.Location = new global::System.Drawing.Point(89, 24);
			this.comboLanguage.Name = "comboLanguage";
			this.comboLanguage.Size = new global::System.Drawing.Size(144, 21);
			this.comboLanguage.TabIndex = 24;
			this.comboLanguage.SelectedIndexChanged += new global::System.EventHandler(this.comboLanguage_SelectedIndexChanged);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(9, 135);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(42, 13);
			this.label15.TabIndex = 23;
			this.label15.Text = "Whistle";
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(9, 108);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(56, 13);
			this.label14.TabIndex = 22;
			this.label14.Text = "Player Call";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(9, 81);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(64, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "Crowd Type";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(6, 27);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(55, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Language";
			this.comboChants.FormattingEnabled = true;
			this.comboChants.Items.AddRange(new object[]
			{
				"English Area", "French Area", "Italy", "German Area", "Spain", "Scandinavian Area", "Rest Of World", "Latin America", "Brazil", "Africa",
				"Asia", "Mexico", "Denmark", "Russian Area", "Portugal", "Turkey"
			});
			this.comboChants.Location = new global::System.Drawing.Point(89, 51);
			this.comboChants.Name = "comboChants";
			this.comboChants.Size = new global::System.Drawing.Size(144, 21);
			this.comboChants.TabIndex = 17;
			this.comboChants.SelectedIndexChanged += new global::System.EventHandler(this.comboChants_SelectedIndexChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(9, 54);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(40, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Chants";
			this.numericNationalTeam.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.countryBindingSource, "NationalTeamId", true));
			this.numericNationalTeam.Location = new global::System.Drawing.Point(449, 27);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericNationalTeam;
			int[] array5 = new int[4];
			array5[0] = 200000;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericNationalTeam.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
			this.numericNationalTeam.Name = "numericNationalTeam";
			this.numericNationalTeam.Size = new global::System.Drawing.Size(133, 20);
			this.numericNationalTeam.TabIndex = 131;
			this.numericNationalTeam.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.numericNationalTeam, "Use this to assign a national team identifier though the national team does not exists");
			this.numericNationalTeam.ValueChanged += new global::System.EventHandler(this.numericNationalTeam_ValueChanged);
			this.labelNationalTeam.AutoSize = true;
			this.labelNationalTeam.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelNationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelNationalTeam.Location = new global::System.Drawing.Point(266, 78);
			this.labelNationalTeam.Name = "labelNationalTeam";
			this.labelNationalTeam.Size = new global::System.Drawing.Size(76, 13);
			this.labelNationalTeam.TabIndex = 133;
			this.labelNationalTeam.Text = "National Team";
			this.labelNationalTeam.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pictureNationalTeam.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureNationalTeam.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureNationalTeam.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureNationalTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureNationalTeam.Location = new global::System.Drawing.Point(119, 71);
			this.pictureNationalTeam.Name = "pictureNationalTeam";
			this.pictureNationalTeam.Size = new global::System.Drawing.Size(100, 100);
			this.pictureNationalTeam.TabIndex = 134;
			this.pictureNationalTeam.TabStop = false;
			this.toolTip.SetToolTip(this.pictureNationalTeam, "Go to the team page for setting the National Team of a Country");
			this.pictureNationalTeam.DoubleClick += new global::System.EventHandler(this.pictureNationalTeam_DoubleClick);
			this.comboNationalTeam.ItemHeight = 13;
			this.comboNationalTeam.Location = new global::System.Drawing.Point(449, 50);
			this.comboNationalTeam.MaxLength = 32767;
			this.comboNationalTeam.Name = "comboNationalTeam";
			this.comboNationalTeam.Size = new global::System.Drawing.Size(133, 21);
			this.comboNationalTeam.Sorted = true;
			this.comboNationalTeam.TabIndex = 132;
			this.toolTip.SetToolTip(this.comboNationalTeam, "Use this to assign to the country an existing national team");
			this.comboNationalTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboNationalTeam_SelectedIndexChanged);
			this.groupBox1.Controls.Add(this.pictureNationalTeam);
			this.groupBox1.Controls.Add(this.labelWorldTarget);
			this.groupBox1.Controls.Add(this.labeRegionalTarget);
			this.groupBox1.Controls.Add(this.comboWorkltarget);
			this.groupBox1.Controls.Add(this.comboRegionalTarget);
			this.groupBox1.Location = new global::System.Drawing.Point(9, 292);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(225, 184);
			this.groupBox1.TabIndex = 165;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "National Team";
			this.countryBindingSource.DataSource = typeof(global::FifaLibrary.Country);
			this.viewer2DFlag512.AutoTransparency = false;
			this.viewer2DFlag512.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DFlag512.ButtonStripVisible = true;
			this.viewer2DFlag512.CurrentBitmap = null;
			this.viewer2DFlag512.ExtendedFormat = false;
			this.viewer2DFlag512.FullSizeButton = false;
			this.viewer2DFlag512.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DFlag512.ImageSize = new global::System.Drawing.Size(512, 512);
			this.viewer2DFlag512.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DFlag512.Location = new global::System.Drawing.Point(502, 13);
			this.viewer2DFlag512.Name = "viewer2DFlag512";
			this.viewer2DFlag512.RemoveButton = false;
			this.viewer2DFlag512.ShowButton = true;
			this.viewer2DFlag512.ShowButtonChecked = true;
			this.viewer2DFlag512.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DFlag512.TabIndex = 162;
			this.toolTip.SetToolTip(this.viewer2DFlag512, "Country Flag 512 x 512");
			this.viewer2DFlag.AutoTransparency = true;
			this.viewer2DFlag.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DFlag.ButtonStripVisible = true;
			this.viewer2DFlag.CurrentBitmap = null;
			this.viewer2DFlag.ExtendedFormat = false;
			this.viewer2DFlag.FullSizeButton = false;
			this.viewer2DFlag.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DFlag.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DFlag.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.Auto256;
			this.viewer2DFlag.Location = new global::System.Drawing.Point(240, 13);
			this.viewer2DFlag.Name = "viewer2DFlag";
			this.viewer2DFlag.RemoveButton = false;
			this.viewer2DFlag.ShowButton = true;
			this.viewer2DFlag.ShowButtonChecked = true;
			this.viewer2DFlag.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DFlag.TabIndex = 1;
			this.toolTip.SetToolTip(this.viewer2DFlag, "Country Badge");
			this.viewer2DCardFlag.AutoTransparency = true;
			this.viewer2DCardFlag.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCardFlag.ButtonStripVisible = true;
			this.viewer2DCardFlag.CurrentBitmap = null;
			this.viewer2DCardFlag.ExtendedFormat = false;
			this.viewer2DCardFlag.FullSizeButton = false;
			this.viewer2DCardFlag.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DCardFlag.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DCardFlag.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCardFlag.Location = new global::System.Drawing.Point(240, 300);
			this.viewer2DCardFlag.Name = "viewer2DCardFlag";
			this.viewer2DCardFlag.RemoveButton = false;
			this.viewer2DCardFlag.ShowButton = true;
			this.viewer2DCardFlag.ShowButtonChecked = true;
			this.viewer2DCardFlag.Size = new global::System.Drawing.Size(150, 177);
			this.viewer2DCardFlag.TabIndex = 30;
			this.toolTip.SetToolTip(this.viewer2DCardFlag, "Country Flag");
			this.viewer2DMiniFlag.AutoTransparency = false;
			this.viewer2DMiniFlag.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DMiniFlag.ButtonStripVisible = true;
			this.viewer2DMiniFlag.CurrentBitmap = null;
			this.viewer2DMiniFlag.ExtendedFormat = false;
			this.viewer2DMiniFlag.FullSizeButton = false;
			this.viewer2DMiniFlag.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DMiniFlag.ImageSize = new global::System.Drawing.Size(64, 64);
			this.viewer2DMiniFlag.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DMiniFlag.Location = new global::System.Drawing.Point(502, 299);
			this.viewer2DMiniFlag.Name = "viewer2DMiniFlag";
			this.viewer2DMiniFlag.RemoveButton = false;
			this.viewer2DMiniFlag.ShowButton = true;
			this.viewer2DMiniFlag.ShowButtonChecked = true;
			this.viewer2DMiniFlag.Size = new global::System.Drawing.Size(64, 64);
			this.viewer2DMiniFlag.TabIndex = 2;
			this.viewer2DShape.AutoTransparency = true;
			this.viewer2DShape.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DShape.ButtonStripVisible = true;
			this.viewer2DShape.CurrentBitmap = null;
			this.viewer2DShape.ExtendedFormat = false;
			this.viewer2DShape.FullSizeButton = false;
			this.viewer2DShape.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DShape.ImageSize = new global::System.Drawing.Size(512, 256);
			this.viewer2DShape.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DShape.Location = new global::System.Drawing.Point(6, 16);
			this.viewer2DShape.Name = "viewer2DShape";
			this.viewer2DShape.RemoveButton = false;
			this.viewer2DShape.ShowButton = true;
			this.viewer2DShape.ShowButtonChecked = true;
			this.viewer2DShape.Size = new global::System.Drawing.Size(512, 281);
			this.viewer2DShape.TabIndex = 2;
			this.toolTip.SetToolTip(this.viewer2DShape, "Country Badge");
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = false;
			this.pickUpControl.CreateButtonEnabled = true;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = null;
			this.pickUpControl.FilterEnabled = false;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = true;
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = true;
			this.pickUpControl.SearchEnabled = true;
			this.pickUpControl.Size = new global::System.Drawing.Size(1357, 25);
			this.pickUpControl.TabIndex = 2;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.flowLayoutPanel);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "CountryForm";
			this.Text = "Country";
			base.Load += new global::System.EventHandler(this.CountryForm_Load);
			this.flowLayoutPanel.ResumeLayout(false);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericLevel).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCountryId).EndInit();
			this.groupCountryShape.ResumeLayout(false);
			this.groupAudio.ResumeLayout(false);
			this.groupAudio.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNationalTeam).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureNationalTeam).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.sponsorListBindingSource).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.countryBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400047C RID: 1148
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400047D RID: 1149
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

		// Token: 0x0400047E RID: 1150
		private global::System.Windows.Forms.GroupBox groupBox;

		// Token: 0x0400047F RID: 1151
		private global::System.Windows.Forms.NumericUpDown numericCountryId;

		// Token: 0x04000480 RID: 1152
		private global::System.Windows.Forms.ComboBox comboContinent;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.TextBox textLanguageName;

		// Token: 0x04000482 RID: 1154
		private global::System.Windows.Forms.Label labelLanguageName;

		// Token: 0x04000483 RID: 1155
		private global::System.Windows.Forms.TextBox textDatabaseCountryName;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.Label labelDatabaseCountryName;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Forms.Label labelContinent;

		// Token: 0x04000486 RID: 1158
		private global::System.Windows.Forms.Label labelCountrId;

		// Token: 0x04000487 RID: 1159
		private global::FifaControls.Viewer2D viewer2DFlag;

		// Token: 0x04000488 RID: 1160
		private global::FifaControls.Viewer2D viewer2DMiniFlag;

		// Token: 0x04000489 RID: 1161
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x0400048A RID: 1162
		private global::System.Windows.Forms.NumericUpDown numericNationalTeam;

		// Token: 0x0400048B RID: 1163
		private global::System.Windows.Forms.ComboBox comboNationalTeam;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.PictureBox pictureNationalTeam;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.Label labelNationalTeam;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x0400048F RID: 1167
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x04000490 RID: 1168
		private global::System.Windows.Forms.BindingSource countryBindingSource;

		// Token: 0x04000491 RID: 1169
		private global::System.Windows.Forms.BindingSource sponsorListBindingSource;

		// Token: 0x04000492 RID: 1170
		private global::System.Windows.Forms.GroupBox groupAudio;

		// Token: 0x04000493 RID: 1171
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000494 RID: 1172
		private global::System.Windows.Forms.ComboBox comboChants;

		// Token: 0x04000495 RID: 1173
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000496 RID: 1174
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000497 RID: 1175
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000498 RID: 1176
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000499 RID: 1177
		private global::System.Windows.Forms.ComboBox comboLanguage;

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Forms.CheckBox checkCanWhistle;

		// Token: 0x0400049B RID: 1179
		private global::System.Windows.Forms.CheckBox checkTauntKeeper;

		// Token: 0x0400049C RID: 1180
		private global::System.Windows.Forms.ComboBox comboPlayerCall;

		// Token: 0x0400049D RID: 1181
		private global::System.Windows.Forms.ComboBox comboCrowdType;

		// Token: 0x0400049E RID: 1182
		private global::System.Windows.Forms.ComboBox comboPepper;

		// Token: 0x0400049F RID: 1183
		private global::System.Windows.Forms.CheckBox checkTopTier;

		// Token: 0x040004A0 RID: 1184
		private global::FifaControls.Viewer2D viewer2DCardFlag;

		// Token: 0x040004A1 RID: 1185
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004A3 RID: 1187
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004A4 RID: 1188
		private global::System.Windows.Forms.GroupBox groupCountryShape;

		// Token: 0x040004A5 RID: 1189
		private global::FifaControls.Viewer2D viewer2DShape;

		// Token: 0x040004A6 RID: 1190
		private global::System.Windows.Forms.ComboBox comboRegionalTarget;

		// Token: 0x040004A7 RID: 1191
		private global::System.Windows.Forms.ComboBox comboWorkltarget;

		// Token: 0x040004A8 RID: 1192
		private global::System.Windows.Forms.Label labeRegionalTarget;

		// Token: 0x040004A9 RID: 1193
		private global::System.Windows.Forms.Label labelWorldTarget;

		// Token: 0x040004AA RID: 1194
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040004AB RID: 1195
		private global::System.Windows.Forms.NumericUpDown numericLevel;

		// Token: 0x040004AC RID: 1196
		private global::System.Windows.Forms.Label labelContry3Letters;

		// Token: 0x040004AD RID: 1197
		private global::System.Windows.Forms.TextBox textLanguageAbbreviation;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Forms.TextBox textLanguageShortName;

		// Token: 0x040004AF RID: 1199
		private global::System.Windows.Forms.Label labelNationShortName;

		// Token: 0x040004B0 RID: 1200
		private global::FifaControls.Viewer2D viewer2DFlag512;

		// Token: 0x040004B1 RID: 1201
		private global::System.Windows.Forms.TextBox textIsoCountryCode;

		// Token: 0x040004B2 RID: 1202
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040004B3 RID: 1203
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
