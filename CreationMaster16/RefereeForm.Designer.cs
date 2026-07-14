namespace CreationMaster
{
	// Token: 0x02000018 RID: 24
	public partial class RefereeForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00059A68 File Offset: 0x00057C68
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00059A88 File Offset: 0x00057C88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.RefereeForm));
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupIdentity = new global::System.Windows.Forms.GroupBox();
			this.radioButtonGenderFemale = new global::System.Windows.Forms.RadioButton();
			this.refereeBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.radioButtonGenderMale = new global::System.Windows.Forms.RadioButton();
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
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboStyle = new global::System.Windows.Forms.ComboBox();
			this.labelStyle = new global::System.Windows.Forms.Label();
			this.domainSleeves = new global::System.Windows.Forms.DomainUpDown();
			this.labelSleeves = new global::System.Windows.Forms.Label();
			this.comboBody = new global::System.Windows.Forms.ComboBox();
			this.numericHeight = new global::System.Windows.Forms.NumericUpDown();
			this.numericWeight = new global::System.Windows.Forms.NumericUpDown();
			this.labelWeight = new global::System.Windows.Forms.Label();
			this.labelBody = new global::System.Windows.Forms.Label();
			this.labelHeight = new global::System.Windows.Forms.Label();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.numericRefereeId = new global::System.Windows.Forms.NumericUpDown();
			this.buttonRandomizeIdentity = new global::System.Windows.Forms.Button();
			this.dateBirthDate = new global::System.Windows.Forms.DateTimePicker();
			this.labelBirthdate = new global::System.Windows.Forms.Label();
			this.labelRefereeId = new global::System.Windows.Forms.Label();
			this.textSurname = new global::System.Windows.Forms.TextBox();
			this.textFirstName = new global::System.Windows.Forms.TextBox();
			this.comboCountry = new global::System.Windows.Forms.ComboBox();
			this.countryListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelFirstName = new global::System.Windows.Forms.Label();
			this.labelSurame = new global::System.Windows.Forms.Label();
			this.labelCountry = new global::System.Windows.Forms.Label();
			this.groupLeagues = new global::System.Windows.Forms.GroupBox();
			this.comboLeague4 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague7 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague5 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague6 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague0 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague3 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague1 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague2 = new global::System.Windows.Forms.ComboBox();
			this.viewer2DPlayerGui = new global::FifaControls.Viewer2D();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.tool3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSwitchRenderingMode = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolPhoto = new global::System.Windows.Forms.ToolStripButton();
			this.groupGenericFace = new global::System.Windows.Forms.GroupBox();
			this.groupTextureInfo = new global::System.Windows.Forms.GroupBox();
			this.comboSkinColor = new global::System.Windows.Forms.ComboBox();
			this.labelFacialHair = new global::System.Windows.Forms.Label();
			this.labelEyeBow = new global::System.Windows.Forms.Label();
			this.domainFacialHair = new global::System.Windows.Forms.ComboBox();
			this.comboEyeBow = new global::System.Windows.Forms.ComboBox();
			this.labelSideburns = new global::System.Windows.Forms.Label();
			this.comboSideburns = new global::System.Windows.Forms.ComboBox();
			this.labelSkintype = new global::System.Windows.Forms.Label();
			this.comboEyescolor = new global::System.Windows.Forms.ComboBox();
			this.comboSkintype = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboFacialHairColor = new global::System.Windows.Forms.ComboBox();
			this.labelFacialHairColor = new global::System.Windows.Forms.Label();
			this.groupHairModel = new global::System.Windows.Forms.GroupBox();
			this.comboHeadband = new global::System.Windows.Forms.ComboBox();
			this.comboAfro = new global::System.Windows.Forms.ComboBox();
			this.comboLong = new global::System.Windows.Forms.ComboBox();
			this.comboMedium = new global::System.Windows.Forms.ComboBox();
			this.comboModern = new global::System.Windows.Forms.ComboBox();
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
			this.domainHairColor = new global::System.Windows.Forms.ComboBox();
			this.labelHairColor = new global::System.Windows.Forms.Label();
			this.groupHeadModel = new global::System.Windows.Forms.GroupBox();
			this.comboLatinModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonLatin = new global::System.Windows.Forms.RadioButton();
			this.comboAsiaticModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonAsiatic = new global::System.Windows.Forms.RadioButton();
			this.comboAfricanModels = new global::System.Windows.Forms.ComboBox();
			this.radioButtonAfrican = new global::System.Windows.Forms.RadioButton();
			this.radioButtonCaucasic = new global::System.Windows.Forms.RadioButton();
			this.comboCaucasicModels = new global::System.Windows.Forms.ComboBox();
			this.buttonRandomizeAppearance = new global::System.Windows.Forms.Button();
			this.labelHeadType = new global::System.Windows.Forms.Label();
			this.labelHairType = new global::System.Windows.Forms.Label();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupIdentity.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.refereeBindingSource).BeginInit();
			this.groupShoes.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesBrand).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesDesign).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericHeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericWeight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRefereeId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).BeginInit();
			this.groupLeagues.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tool3D.SuspendLayout();
			this.groupGenericFace.SuspendLayout();
			this.groupTextureInfo.SuspendLayout();
			this.groupHairModel.SuspendLayout();
			this.groupHeadModel.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new global::System.Drawing.Size(1357, 807);
			this.splitContainer1.SplitterDistance = 527;
			this.splitContainer1.TabIndex = 2;
			this.flowLayoutPanel1.Controls.Add(this.groupIdentity);
			this.flowLayoutPanel1.Controls.Add(this.groupLeagues);
			this.flowLayoutPanel1.Controls.Add(this.viewer2DPlayerGui);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(527, 807);
			this.flowLayoutPanel1.TabIndex = 0;
			this.groupIdentity.Controls.Add(this.radioButtonGenderFemale);
			this.groupIdentity.Controls.Add(this.radioButtonGenderMale);
			this.groupIdentity.Controls.Add(this.groupShoes);
			this.groupIdentity.Controls.Add(this.comboBox1);
			this.groupIdentity.Controls.Add(this.label3);
			this.groupIdentity.Controls.Add(this.comboStyle);
			this.groupIdentity.Controls.Add(this.labelStyle);
			this.groupIdentity.Controls.Add(this.domainSleeves);
			this.groupIdentity.Controls.Add(this.labelSleeves);
			this.groupIdentity.Controls.Add(this.comboBody);
			this.groupIdentity.Controls.Add(this.numericHeight);
			this.groupIdentity.Controls.Add(this.numericWeight);
			this.groupIdentity.Controls.Add(this.labelWeight);
			this.groupIdentity.Controls.Add(this.labelBody);
			this.groupIdentity.Controls.Add(this.labelHeight);
			this.groupIdentity.Controls.Add(this.buttonGetId);
			this.groupIdentity.Controls.Add(this.numericRefereeId);
			this.groupIdentity.Controls.Add(this.buttonRandomizeIdentity);
			this.groupIdentity.Controls.Add(this.dateBirthDate);
			this.groupIdentity.Controls.Add(this.labelBirthdate);
			this.groupIdentity.Controls.Add(this.labelRefereeId);
			this.groupIdentity.Controls.Add(this.textSurname);
			this.groupIdentity.Controls.Add(this.textFirstName);
			this.groupIdentity.Controls.Add(this.comboCountry);
			this.groupIdentity.Controls.Add(this.labelFirstName);
			this.groupIdentity.Controls.Add(this.labelSurame);
			this.groupIdentity.Controls.Add(this.labelCountry);
			this.groupIdentity.Location = new global::System.Drawing.Point(3, 3);
			this.groupIdentity.Name = "groupIdentity";
			this.groupIdentity.Size = new global::System.Drawing.Size(512, 282);
			this.groupIdentity.TabIndex = 0;
			this.groupIdentity.TabStop = false;
			this.groupIdentity.Text = "Identity";
			this.radioButtonGenderFemale.AutoSize = true;
			this.radioButtonGenderFemale.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.refereeBindingSource, "Female", true));
			this.radioButtonGenderFemale.Location = new global::System.Drawing.Point(163, 147);
			this.radioButtonGenderFemale.Name = "radioButtonGenderFemale";
			this.radioButtonGenderFemale.Size = new global::System.Drawing.Size(59, 17);
			this.radioButtonGenderFemale.TabIndex = 191;
			this.radioButtonGenderFemale.TabStop = true;
			this.radioButtonGenderFemale.Text = "Female";
			this.radioButtonGenderFemale.UseVisualStyleBackColor = true;
			this.refereeBindingSource.DataSource = typeof(global::FifaLibrary.Referee);
			this.radioButtonGenderMale.AutoSize = true;
			this.radioButtonGenderMale.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.refereeBindingSource, "Male", true));
			this.radioButtonGenderMale.Location = new global::System.Drawing.Point(109, 147);
			this.radioButtonGenderMale.Name = "radioButtonGenderMale";
			this.radioButtonGenderMale.Size = new global::System.Drawing.Size(48, 17);
			this.radioButtonGenderMale.TabIndex = 190;
			this.radioButtonGenderMale.TabStop = true;
			this.radioButtonGenderMale.Text = "Male";
			this.radioButtonGenderMale.UseVisualStyleBackColor = true;
			this.groupShoes.Controls.Add(this.label1ShoesType);
			this.groupShoes.Controls.Add(this.pictureColorShoes2);
			this.groupShoes.Controls.Add(this.pictureColorShoes1);
			this.groupShoes.Controls.Add(this.numericShoesBrand);
			this.groupShoes.Controls.Add(this.labelShoesType);
			this.groupShoes.Controls.Add(this.labelShoesColor);
			this.groupShoes.Controls.Add(this.numericShoesDesign);
			this.groupShoes.Controls.Add(this.viewer2DShoes);
			this.groupShoes.Controls.Add(this.labelShoes);
			this.groupShoes.Location = new global::System.Drawing.Point(263, 94);
			this.groupShoes.Name = "groupShoes";
			this.groupShoes.Size = new global::System.Drawing.Size(243, 178);
			this.groupShoes.TabIndex = 189;
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
			this.pictureColorShoes2.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.refereeBindingSource, "shoecolorcode2", true));
			this.pictureColorShoes2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorShoes2.Location = new global::System.Drawing.Point(72, 131);
			this.pictureColorShoes2.Name = "pictureColorShoes2";
			this.pictureColorShoes2.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorShoes2.TabIndex = 63;
			this.pictureColorShoes2.TabStop = false;
			this.pictureColorShoes2.Click += new global::System.EventHandler(this.pictureColorShoes2_Click);
			this.pictureColorShoes1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureColorShoes1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureColorShoes1.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.refereeBindingSource, "shoecolorcode1", true));
			this.pictureColorShoes1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureColorShoes1.Location = new global::System.Drawing.Point(12, 131);
			this.pictureColorShoes1.Name = "pictureColorShoes1";
			this.pictureColorShoes1.Size = new global::System.Drawing.Size(20, 20);
			this.pictureColorShoes1.TabIndex = 62;
			this.pictureColorShoes1.TabStop = false;
			this.pictureColorShoes1.Click += new global::System.EventHandler(this.pictureColorShoes1_Click);
			this.numericShoesBrand.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.refereeBindingSource, "shoetypecode", true));
			this.numericShoesBrand.Location = new global::System.Drawing.Point(12, 36);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericShoesBrand;
			int[] array = new int[4];
			array[0] = 255;
			numericUpDown.Maximum = new decimal(array);
			this.numericShoesBrand.Name = "numericShoesBrand";
			this.numericShoesBrand.Size = new global::System.Drawing.Size(80, 20);
			this.numericShoesBrand.TabIndex = 9;
			this.numericShoesBrand.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericShoesBrand;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
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
			this.numericShoesDesign.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.refereeBindingSource, "shoedesigncode", true));
			this.numericShoesDesign.Location = new global::System.Drawing.Point(12, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericShoesDesign;
			int[] array3 = new int[4];
			array3[0] = 3;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericShoesDesign.Name = "numericShoesDesign";
			this.numericShoesDesign.Size = new global::System.Drawing.Size(80, 20);
			this.numericShoesDesign.TabIndex = 10;
			this.numericShoesDesign.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericShoesDesign;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
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
			this.comboBox1.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.refereeBindingSource, "cardstrictness", true));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] { "Tolerant", "Balanced", "Easy Card" });
			this.comboBox1.Location = new global::System.Drawing.Point(357, 42);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(132, 21);
			this.comboBox1.TabIndex = 188;
			this.label3.AutoSize = true;
			this.label3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new global::System.Drawing.Point(266, 46);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 13);
			this.label3.TabIndex = 187;
			this.label3.Text = "Cards Style";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboStyle.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.refereeBindingSource, "foulstrictness", true));
			this.comboStyle.FormattingEnabled = true;
			this.comboStyle.Items.AddRange(new object[] { "Let Play", "Balanced", "Easy Whistle" });
			this.comboStyle.Location = new global::System.Drawing.Point(357, 17);
			this.comboStyle.Name = "comboStyle";
			this.comboStyle.Size = new global::System.Drawing.Size(132, 21);
			this.comboStyle.TabIndex = 186;
			this.labelStyle.AutoSize = true;
			this.labelStyle.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStyle.Location = new global::System.Drawing.Point(266, 19);
			this.labelStyle.Name = "labelStyle";
			this.labelStyle.Size = new global::System.Drawing.Size(58, 13);
			this.labelStyle.TabIndex = 185;
			this.labelStyle.Text = "Fouls Style";
			this.labelStyle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.domainSleeves.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.refereeBindingSource, "jerseysleevelengthcode", true));
			this.domainSleeves.Items.Add("Short");
			this.domainSleeves.Items.Add("Long");
			this.domainSleeves.Location = new global::System.Drawing.Point(357, 68);
			this.domainSleeves.Name = "domainSleeves";
			this.domainSleeves.Size = new global::System.Drawing.Size(132, 20);
			this.domainSleeves.TabIndex = 175;
			this.domainSleeves.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainSleeves.Wrap = true;
			this.labelSleeves.AutoSize = true;
			this.labelSleeves.BackColor = global::System.Drawing.Color.Transparent;
			this.labelSleeves.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSleeves.Location = new global::System.Drawing.Point(266, 70);
			this.labelSleeves.Name = "labelSleeves";
			this.labelSleeves.Size = new global::System.Drawing.Size(81, 13);
			this.labelSleeves.TabIndex = 176;
			this.labelSleeves.Text = "Sleeves Length";
			this.labelSleeves.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboBody.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.refereeBindingSource, "bodytypecode", true));
			this.comboBody.FormattingEnabled = true;
			this.comboBody.Items.AddRange(new object[] { "Small", "Normal", "Big" });
			this.comboBody.Location = new global::System.Drawing.Point(96, 225);
			this.comboBody.Name = "comboBody";
			this.comboBody.Size = new global::System.Drawing.Size(132, 21);
			this.comboBody.TabIndex = 174;
			this.numericHeight.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.refereeBindingSource, "height", true));
			this.numericHeight.Location = new global::System.Drawing.Point(96, 173);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericHeight;
			int[] array5 = new int[4];
			array5[0] = 215;
			numericUpDown5.Maximum = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericHeight;
			int[] array6 = new int[4];
			array6[0] = 150;
			numericUpDown6.Minimum = new decimal(array6);
			this.numericHeight.Name = "numericHeight";
			this.numericHeight.Size = new global::System.Drawing.Size(132, 20);
			this.numericHeight.TabIndex = 169;
			this.numericHeight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericHeight;
			int[] array7 = new int[4];
			array7[0] = 150;
			numericUpDown7.Value = new decimal(array7);
			this.numericWeight.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.refereeBindingSource, "weight", true));
			this.numericWeight.Location = new global::System.Drawing.Point(96, 199);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericWeight;
			int[] array8 = new int[4];
			array8[0] = 115;
			numericUpDown8.Maximum = new decimal(array8);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericWeight;
			int[] array9 = new int[4];
			array9[0] = 50;
			numericUpDown9.Minimum = new decimal(array9);
			this.numericWeight.Name = "numericWeight";
			this.numericWeight.Size = new global::System.Drawing.Size(132, 20);
			this.numericWeight.TabIndex = 170;
			this.numericWeight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericWeight;
			int[] array10 = new int[4];
			array10[0] = 50;
			numericUpDown10.Value = new decimal(array10);
			this.labelWeight.AutoSize = true;
			this.labelWeight.BackColor = global::System.Drawing.Color.Transparent;
			this.labelWeight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelWeight.Location = new global::System.Drawing.Point(6, 201);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new global::System.Drawing.Size(41, 13);
			this.labelWeight.TabIndex = 172;
			this.labelWeight.Text = "Weight";
			this.labelWeight.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelBody.AutoSize = true;
			this.labelBody.BackColor = global::System.Drawing.Color.Transparent;
			this.labelBody.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBody.Location = new global::System.Drawing.Point(5, 228);
			this.labelBody.Name = "labelBody";
			this.labelBody.Size = new global::System.Drawing.Size(31, 13);
			this.labelBody.TabIndex = 173;
			this.labelBody.Text = "Body";
			this.labelBody.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHeight.AutoSize = true;
			this.labelHeight.BackColor = global::System.Drawing.Color.Transparent;
			this.labelHeight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHeight.Location = new global::System.Drawing.Point(5, 175);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new global::System.Drawing.Size(38, 13);
			this.labelHeight.TabIndex = 171;
			this.labelHeight.Text = "Height";
			this.labelHeight.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonGetId.Location = new global::System.Drawing.Point(204, 17);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(24, 20);
			this.buttonGetId.TabIndex = 168;
			this.buttonGetId.Text = "...";
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.numericRefereeId.Location = new global::System.Drawing.Point(98, 17);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericRefereeId;
			int[] array11 = new int[4];
			array11[0] = 600000;
			numericUpDown11.Maximum = new decimal(array11);
			this.numericRefereeId.Name = "numericRefereeId";
			this.numericRefereeId.Size = new global::System.Drawing.Size(91, 20);
			this.numericRefereeId.TabIndex = 167;
			this.numericRefereeId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericRefereeId;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.numericRefereeId.ValueChanged += new global::System.EventHandler(this.numericRefereeId_ValueChanged);
			this.buttonRandomizeIdentity.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonRandomizeIdentity.Location = new global::System.Drawing.Point(10, 252);
			this.buttonRandomizeIdentity.Name = "buttonRandomizeIdentity";
			this.buttonRandomizeIdentity.Size = new global::System.Drawing.Size(218, 23);
			this.buttonRandomizeIdentity.TabIndex = 166;
			this.buttonRandomizeIdentity.Text = "Randomize";
			this.buttonRandomizeIdentity.UseVisualStyleBackColor = true;
			this.buttonRandomizeIdentity.Visible = false;
			this.buttonRandomizeIdentity.Click += new global::System.EventHandler(this.buttonRandomizeIdentity_Click);
			this.dateBirthDate.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.refereeBindingSource, "birthdate", true));
			this.dateBirthDate.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateBirthDate.Location = new global::System.Drawing.Point(97, 94);
			this.dateBirthDate.MaxDate = new global::System.DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.dateBirthDate.MinDate = new global::System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateBirthDate.Name = "dateBirthDate";
			this.dateBirthDate.Size = new global::System.Drawing.Size(131, 20);
			this.dateBirthDate.TabIndex = 161;
			this.dateBirthDate.Value = new global::System.DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.labelBirthdate.AutoSize = true;
			this.labelBirthdate.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelBirthdate.Location = new global::System.Drawing.Point(7, 98);
			this.labelBirthdate.Name = "labelBirthdate";
			this.labelBirthdate.Size = new global::System.Drawing.Size(49, 13);
			this.labelBirthdate.TabIndex = 163;
			this.labelBirthdate.Text = "Birthdate";
			this.labelBirthdate.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelRefereeId.AutoSize = true;
			this.labelRefereeId.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRefereeId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelRefereeId.Location = new global::System.Drawing.Point(7, 21);
			this.labelRefereeId.Name = "labelRefereeId";
			this.labelRefereeId.Size = new global::System.Drawing.Size(57, 13);
			this.labelRefereeId.TabIndex = 165;
			this.labelRefereeId.Text = "Referee Id";
			this.labelRefereeId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textSurname.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.refereeBindingSource, "surname", true));
			this.textSurname.Location = new global::System.Drawing.Point(97, 68);
			this.textSurname.Name = "textSurname";
			this.textSurname.Size = new global::System.Drawing.Size(131, 20);
			this.textSurname.TabIndex = 159;
			this.textSurname.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textSurname.TextChanged += new global::System.EventHandler(this.textSurname_TextChanged);
			this.textFirstName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.refereeBindingSource, "firstname", true));
			this.textFirstName.Location = new global::System.Drawing.Point(98, 42);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new global::System.Drawing.Size(131, 20);
			this.textFirstName.TabIndex = 157;
			this.textFirstName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textFirstName.TextChanged += new global::System.EventHandler(this.textFirstName_TextChanged);
			this.comboCountry.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.refereeBindingSource, "Country", true));
			this.comboCountry.DataSource = this.countryListBindingSource;
			this.comboCountry.ItemHeight = 13;
			this.comboCountry.Location = new global::System.Drawing.Point(97, 120);
			this.comboCountry.MaxLength = 32767;
			this.comboCountry.Name = "comboCountry";
			this.comboCountry.Size = new global::System.Drawing.Size(131, 21);
			this.comboCountry.TabIndex = 162;
			this.countryListBindingSource.DataSource = typeof(global::FifaLibrary.CountryList);
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFirstName.Location = new global::System.Drawing.Point(7, 45);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new global::System.Drawing.Size(57, 13);
			this.labelFirstName.TabIndex = 158;
			this.labelFirstName.Text = "First Name";
			this.labelFirstName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSurame.AutoSize = true;
			this.labelSurame.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSurame.Location = new global::System.Drawing.Point(6, 71);
			this.labelSurame.Name = "labelSurame";
			this.labelSurame.Size = new global::System.Drawing.Size(58, 13);
			this.labelSurame.TabIndex = 160;
			this.labelSurame.Text = "Last Name";
			this.labelSurame.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.AutoSize = true;
			this.labelCountry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelCountry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCountry.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelCountry.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCountry.Location = new global::System.Drawing.Point(7, 119);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new global::System.Drawing.Size(43, 13);
			this.labelCountry.TabIndex = 164;
			this.labelCountry.Text = "Country";
			this.labelCountry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.DoubleClick += new global::System.EventHandler(this.labelCountry_DoubleClick);
			this.groupLeagues.Controls.Add(this.comboLeague4);
			this.groupLeagues.Controls.Add(this.comboLeague7);
			this.groupLeagues.Controls.Add(this.comboLeague5);
			this.groupLeagues.Controls.Add(this.comboLeague6);
			this.groupLeagues.Controls.Add(this.comboLeague0);
			this.groupLeagues.Controls.Add(this.comboLeague3);
			this.groupLeagues.Controls.Add(this.comboLeague1);
			this.groupLeagues.Controls.Add(this.comboLeague2);
			this.groupLeagues.Location = new global::System.Drawing.Point(3, 291);
			this.groupLeagues.Name = "groupLeagues";
			this.groupLeagues.Size = new global::System.Drawing.Size(512, 134);
			this.groupLeagues.TabIndex = 192;
			this.groupLeagues.TabStop = false;
			this.groupLeagues.Text = "Leagues";
			this.comboLeague4.FormattingEnabled = true;
			this.comboLeague4.Location = new global::System.Drawing.Point(264, 19);
			this.comboLeague4.Name = "comboLeague4";
			this.comboLeague4.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague4.TabIndex = 192;
			this.comboLeague4.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague4_SelectedIndexChanged);
			this.comboLeague7.FormattingEnabled = true;
			this.comboLeague7.Location = new global::System.Drawing.Point(264, 99);
			this.comboLeague7.Name = "comboLeague7";
			this.comboLeague7.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague7.TabIndex = 195;
			this.comboLeague7.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague7_SelectedIndexChanged);
			this.comboLeague5.FormattingEnabled = true;
			this.comboLeague5.Location = new global::System.Drawing.Point(264, 46);
			this.comboLeague5.Name = "comboLeague5";
			this.comboLeague5.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague5.TabIndex = 193;
			this.comboLeague5.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague5_SelectedIndexChanged);
			this.comboLeague6.FormattingEnabled = true;
			this.comboLeague6.Location = new global::System.Drawing.Point(264, 73);
			this.comboLeague6.Name = "comboLeague6";
			this.comboLeague6.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague6.TabIndex = 194;
			this.comboLeague6.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague6_SelectedIndexChanged);
			this.comboLeague0.FormattingEnabled = true;
			this.comboLeague0.Location = new global::System.Drawing.Point(9, 19);
			this.comboLeague0.Name = "comboLeague0";
			this.comboLeague0.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague0.TabIndex = 183;
			this.comboLeague0.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague0_SelectedIndexChanged);
			this.comboLeague3.FormattingEnabled = true;
			this.comboLeague3.Location = new global::System.Drawing.Point(9, 99);
			this.comboLeague3.Name = "comboLeague3";
			this.comboLeague3.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague3.TabIndex = 191;
			this.comboLeague3.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague3_SelectedIndexChanged);
			this.comboLeague1.FormattingEnabled = true;
			this.comboLeague1.Location = new global::System.Drawing.Point(9, 46);
			this.comboLeague1.Name = "comboLeague1";
			this.comboLeague1.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague1.TabIndex = 189;
			this.comboLeague1.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague1_SelectedIndexChanged);
			this.comboLeague2.FormattingEnabled = true;
			this.comboLeague2.Location = new global::System.Drawing.Point(9, 73);
			this.comboLeague2.Name = "comboLeague2";
			this.comboLeague2.Size = new global::System.Drawing.Size(204, 21);
			this.comboLeague2.TabIndex = 190;
			this.comboLeague2.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague2_SelectedIndexChanged);
			this.viewer2DPlayerGui.AutoTransparency = true;
			this.viewer2DPlayerGui.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DPlayerGui.CurrentBitmap = null;
			this.viewer2DPlayerGui.ExtendedFormat = false;
			this.viewer2DPlayerGui.FullSizeButton = false;
			this.viewer2DPlayerGui.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPlayerGui.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DPlayerGui.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DPlayerGui.Location = new global::System.Drawing.Point(3, 431);
			this.viewer2DPlayerGui.Name = "viewer2DPlayerGui";
			this.viewer2DPlayerGui.RemoveButton = false;
			this.viewer2DPlayerGui.ShowButton = false;
			this.viewer2DPlayerGui.ShowButtonChecked = true;
			this.viewer2DPlayerGui.Size = new global::System.Drawing.Size(256, 225);
			this.viewer2DPlayerGui.TabIndex = 193;
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer2.Panel1.Controls.Add(this.viewer3D);
			this.splitContainer2.Panel1.Controls.Add(this.tool3D);
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this.groupGenericFace);
			this.splitContainer2.Size = new global::System.Drawing.Size(826, 807);
			this.splitContainer2.SplitterDistance = 483;
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
			this.viewer3D.Size = new global::System.Drawing.Size(826, 458);
			this.viewer3D.TabIndex = 5;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 171f;
			this.viewer3D.ViewZ = 49f;
			this.viewer3D.ZbufferRenderState = null;
			this.tool3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.tool3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tool3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.buttonSwitchRenderingMode, this.toolStripSeparator1, this.toolPhoto });
			this.tool3D.Location = new global::System.Drawing.Point(0, 458);
			this.tool3D.Name = "tool3D";
			this.tool3D.Size = new global::System.Drawing.Size(826, 25);
			this.tool3D.TabIndex = 6;
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
			this.toolPhoto.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolPhoto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolPhoto.Image");
			this.toolPhoto.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolPhoto.Name = "toolPhoto";
			this.toolPhoto.Size = new global::System.Drawing.Size(23, 22);
			this.toolPhoto.Text = "Take a picture";
			this.toolPhoto.Click += new global::System.EventHandler(this.toolPhoto_Click);
			this.groupGenericFace.Controls.Add(this.groupTextureInfo);
			this.groupGenericFace.Controls.Add(this.groupHairModel);
			this.groupGenericFace.Controls.Add(this.groupHeadModel);
			this.groupGenericFace.Controls.Add(this.labelHeadType);
			this.groupGenericFace.Controls.Add(this.labelHairType);
			this.groupGenericFace.Location = new global::System.Drawing.Point(3, 3);
			this.groupGenericFace.Name = "groupGenericFace";
			this.groupGenericFace.Size = new global::System.Drawing.Size(590, 246);
			this.groupGenericFace.TabIndex = 87;
			this.groupGenericFace.TabStop = false;
			this.groupGenericFace.Text = "Face Modelling";
			this.groupTextureInfo.Controls.Add(this.comboSkinColor);
			this.groupTextureInfo.Controls.Add(this.labelFacialHair);
			this.groupTextureInfo.Controls.Add(this.labelEyeBow);
			this.groupTextureInfo.Controls.Add(this.domainFacialHair);
			this.groupTextureInfo.Controls.Add(this.comboEyeBow);
			this.groupTextureInfo.Controls.Add(this.labelSideburns);
			this.groupTextureInfo.Controls.Add(this.comboSideburns);
			this.groupTextureInfo.Controls.Add(this.labelSkintype);
			this.groupTextureInfo.Controls.Add(this.comboEyescolor);
			this.groupTextureInfo.Controls.Add(this.comboSkintype);
			this.groupTextureInfo.Controls.Add(this.label2);
			this.groupTextureInfo.Controls.Add(this.label1);
			this.groupTextureInfo.Controls.Add(this.comboFacialHairColor);
			this.groupTextureInfo.Controls.Add(this.labelFacialHairColor);
			this.groupTextureInfo.Location = new global::System.Drawing.Point(381, 19);
			this.groupTextureInfo.Name = "groupTextureInfo";
			this.groupTextureInfo.Size = new global::System.Drawing.Size(200, 217);
			this.groupTextureInfo.TabIndex = 35;
			this.groupTextureInfo.TabStop = false;
			this.groupTextureInfo.Text = "Face Type";
			this.comboSkinColor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSkinColor.FormattingEnabled = true;
			this.comboSkinColor.Items.AddRange(new object[] { "1 = unused", "Pink", "3 = unused", "Llight Yellow", "Medium Yellow", "Dark Yellow", "7 = unused", "Light Brown", "Medium Brown", "Dark brown" });
			this.comboSkinColor.Location = new global::System.Drawing.Point(77, 22);
			this.comboSkinColor.Name = "comboSkinColor";
			this.comboSkinColor.Size = new global::System.Drawing.Size(111, 21);
			this.comboSkinColor.TabIndex = 20;
			this.comboSkinColor.SelectedIndexChanged += new global::System.EventHandler(this.comboSkinColor_SelectedIndexChanged);
			this.labelFacialHair.AutoSize = true;
			this.labelFacialHair.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelFacialHair.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFacialHair.Location = new global::System.Drawing.Point(6, 136);
			this.labelFacialHair.Name = "labelFacialHair";
			this.labelFacialHair.Size = new global::System.Drawing.Size(57, 13);
			this.labelFacialHair.TabIndex = 15;
			this.labelFacialHair.Text = "Facial Hair";
			this.labelFacialHair.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelEyeBow.AutoSize = true;
			this.labelEyeBow.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelEyeBow.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelEyeBow.Location = new global::System.Drawing.Point(6, 108);
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
			this.domainFacialHair.Location = new global::System.Drawing.Point(77, 133);
			this.domainFacialHair.Name = "domainFacialHair";
			this.domainFacialHair.Size = new global::System.Drawing.Size(111, 21);
			this.domainFacialHair.TabIndex = 16;
			this.domainFacialHair.SelectedIndexChanged += new global::System.EventHandler(this.domainFacialHair_SelectedItemChanged);
			this.comboEyeBow.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEyeBow.FormattingEnabled = true;
			this.comboEyeBow.Items.AddRange(new object[] { "Normal", "Big", "Thin", "Type Female 3", "Type Female 4", "Type Female 5", "Type Female 6" });
			this.comboEyeBow.Location = new global::System.Drawing.Point(77, 105);
			this.comboEyeBow.Name = "comboEyeBow";
			this.comboEyeBow.Size = new global::System.Drawing.Size(111, 21);
			this.comboEyeBow.TabIndex = 32;
			this.comboEyeBow.SelectedIndexChanged += new global::System.EventHandler(this.comboEyeBow_SelectedIndexChanged);
			this.labelSideburns.AutoSize = true;
			this.labelSideburns.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelSideburns.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSideburns.Location = new global::System.Drawing.Point(6, 192);
			this.labelSideburns.Name = "labelSideburns";
			this.labelSideburns.Size = new global::System.Drawing.Size(54, 13);
			this.labelSideburns.TabIndex = 23;
			this.labelSideburns.Text = "Sideburns";
			this.labelSideburns.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSideburns.Visible = false;
			this.comboSideburns.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSideburns.FormattingEnabled = true;
			this.comboSideburns.Items.AddRange(new object[] { "No", "Yes" });
			this.comboSideburns.Location = new global::System.Drawing.Point(77, 189);
			this.comboSideburns.Name = "comboSideburns";
			this.comboSideburns.Size = new global::System.Drawing.Size(111, 21);
			this.comboSideburns.TabIndex = 24;
			this.comboSideburns.Visible = false;
			this.comboSideburns.SelectedIndexChanged += new global::System.EventHandler(this.comboSideburns_SelectedIndexChanged);
			this.labelSkintype.AutoSize = true;
			this.labelSkintype.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelSkintype.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSkintype.Location = new global::System.Drawing.Point(6, 52);
			this.labelSkintype.Name = "labelSkintype";
			this.labelSkintype.Size = new global::System.Drawing.Size(55, 13);
			this.labelSkintype.TabIndex = 21;
			this.labelSkintype.Text = "Skin Type";
			this.labelSkintype.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboEyescolor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboEyescolor.FormattingEnabled = true;
			this.comboEyescolor.Items.AddRange(new object[] { "Dark Blue", "Light Blue", "Dark Brown", "Light Brown", "Brown and Green", "Dark Green", "Light Green", "Gray", "Black", "Dark Gray" });
			this.comboEyescolor.Location = new global::System.Drawing.Point(77, 77);
			this.comboEyescolor.Name = "comboEyescolor";
			this.comboEyescolor.Size = new global::System.Drawing.Size(111, 21);
			this.comboEyescolor.TabIndex = 26;
			this.comboEyescolor.SelectedIndexChanged += new global::System.EventHandler(this.comboEyescolor_SelectedIndexChanged);
			this.comboSkintype.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSkintype.FormattingEnabled = true;
			this.comboSkintype.Items.AddRange(new object[] { "Clean", "Freckled", "Rough", "Type Female 3", "Type Female 4", "Type Female 5", "Type Female 6", "Type Female 7" });
			this.comboSkintype.Location = new global::System.Drawing.Point(77, 49);
			this.comboSkintype.Name = "comboSkintype";
			this.comboSkintype.Size = new global::System.Drawing.Size(111, 21);
			this.comboSkintype.TabIndex = 22;
			this.comboSkintype.SelectedIndexChanged += new global::System.EventHandler(this.comboSkintype_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.SystemColors.Control;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(6, 80);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Eyes Color";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.SystemColors.Control;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Skin Color";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboFacialHairColor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFacialHairColor.FormattingEnabled = true;
			this.comboFacialHairColor.Items.AddRange(new object[] { "Black", "Blonde", "Dark brown", "Light brown", "Red" });
			this.comboFacialHairColor.Location = new global::System.Drawing.Point(77, 161);
			this.comboFacialHairColor.Name = "comboFacialHairColor";
			this.comboFacialHairColor.Size = new global::System.Drawing.Size(111, 21);
			this.comboFacialHairColor.TabIndex = 18;
			this.comboFacialHairColor.SelectedIndexChanged += new global::System.EventHandler(this.comboFacialHairColor_SelectedIndexChanged);
			this.labelFacialHairColor.AutoSize = true;
			this.labelFacialHairColor.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelFacialHairColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFacialHairColor.Location = new global::System.Drawing.Point(6, 164);
			this.labelFacialHairColor.Name = "labelFacialHairColor";
			this.labelFacialHairColor.Size = new global::System.Drawing.Size(31, 13);
			this.labelFacialHairColor.TabIndex = 17;
			this.labelFacialHairColor.Text = "Color";
			this.labelFacialHairColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupHairModel.Controls.Add(this.comboHeadband);
			this.groupHairModel.Controls.Add(this.comboAfro);
			this.groupHairModel.Controls.Add(this.comboLong);
			this.groupHairModel.Controls.Add(this.comboMedium);
			this.groupHairModel.Controls.Add(this.comboModern);
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
			this.groupHairModel.Controls.Add(this.domainHairColor);
			this.groupHairModel.Controls.Add(this.labelHairColor);
			this.groupHairModel.Location = new global::System.Drawing.Point(6, 104);
			this.groupHairModel.Name = "groupHairModel";
			this.groupHairModel.Size = new global::System.Drawing.Size(364, 132);
			this.groupHairModel.TabIndex = 29;
			this.groupHairModel.TabStop = false;
			this.groupHairModel.Text = "Hair Model";
			this.comboHeadband.FormattingEnabled = true;
			this.comboHeadband.Items.AddRange(new object[] { "55", "56", "76", "81", "49", "91" });
			this.comboHeadband.Location = new global::System.Drawing.Point(6, 76);
			this.comboHeadband.Name = "comboHeadband";
			this.comboHeadband.Size = new global::System.Drawing.Size(260, 21);
			this.comboHeadband.TabIndex = 30;
			this.comboHeadband.Visible = false;
			this.comboHeadband.SelectedIndexChanged += new global::System.EventHandler(this.comboHeadband_SelectedIndexChanged);
			this.comboAfro.FormattingEnabled = true;
			this.comboAfro.Items.AddRange(new object[] { "71", "4", "42", "27", "5", "6", "96", "3" });
			this.comboAfro.Location = new global::System.Drawing.Point(6, 76);
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
			this.comboLong.Location = new global::System.Drawing.Point(6, 76);
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
			this.comboMedium.Location = new global::System.Drawing.Point(6, 76);
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
			this.comboModern.Location = new global::System.Drawing.Point(6, 76);
			this.comboModern.Name = "comboModern";
			this.comboModern.Size = new global::System.Drawing.Size(260, 21);
			this.comboModern.TabIndex = 26;
			this.comboModern.Visible = false;
			this.comboModern.SelectedIndexChanged += new global::System.EventHandler(this.comboModern_SelectedIndexChanged);
			this.comboShort.FormattingEnabled = true;
			this.comboShort.Items.AddRange(new object[]
			{
				"2", "21", "22", "30", "38", "54", "57", "70", "75", "78",
				"82", "97", "101", "102", "104", "105", "106", "107", "108", "109",
				"110", "111", "112"
			});
			this.comboShort.Location = new global::System.Drawing.Point(6, 76);
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
			this.comboVeryShort.Location = new global::System.Drawing.Point(6, 76);
			this.comboVeryShort.Name = "comboVeryShort";
			this.comboVeryShort.Size = new global::System.Drawing.Size(260, 21);
			this.comboVeryShort.TabIndex = 24;
			this.comboVeryShort.Visible = false;
			this.comboVeryShort.SelectedIndexChanged += new global::System.EventHandler(this.comboVeryShort_SelectedIndexChanged);
			this.comboShaven.FormattingEnabled = true;
			this.comboShaven.Items.AddRange(new object[] { "0", "25", "1", "43", "41", "46" });
			this.comboShaven.Location = new global::System.Drawing.Point(6, 76);
			this.comboShaven.Name = "comboShaven";
			this.comboShaven.Size = new global::System.Drawing.Size(260, 21);
			this.comboShaven.TabIndex = 23;
			this.comboShaven.Visible = false;
			this.comboShaven.SelectedIndexChanged += new global::System.EventHandler(this.comboShaven_SelectedIndexChanged);
			this.radioHeadband.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioHeadband.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioHeadband.Location = new global::System.Drawing.Point(136, 40);
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
			this.radioAfro.Location = new global::System.Drawing.Point(201, 40);
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
			this.radioLong.Location = new global::System.Drawing.Point(71, 40);
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
			this.radioMedium.Location = new global::System.Drawing.Point(6, 40);
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
			this.radioModern.Location = new global::System.Drawing.Point(201, 17);
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
			this.radioShort.Location = new global::System.Drawing.Point(136, 17);
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
			this.radioVeryShort.Location = new global::System.Drawing.Point(71, 17);
			this.radioVeryShort.Name = "radioVeryShort";
			this.radioVeryShort.Size = new global::System.Drawing.Size(65, 23);
			this.radioVeryShort.TabIndex = 15;
			this.radioVeryShort.TabStop = true;
			this.radioVeryShort.Tag = this.comboVeryShort;
			this.radioVeryShort.Text = "Very Short";
			this.radioVeryShort.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioVeryShort.UseVisualStyleBackColor = true;
			this.radioVeryShort.CheckedChanged += new global::System.EventHandler(this.radioVeryShort_CheckedChanged);
			this.domainHairColor.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.domainHairColor.FormattingEnabled = true;
			this.domainHairColor.Items.AddRange(new object[]
			{
				"Blonde", "Black", "Dark Blonde", "Dark Brown", "Light Blonde", "Light Brown", "Brown", "Red", "White", "Gray",
				"Green", "Violet"
			});
			this.domainHairColor.Location = new global::System.Drawing.Point(155, 102);
			this.domainHairColor.Name = "domainHairColor";
			this.domainHairColor.Size = new global::System.Drawing.Size(111, 21);
			this.domainHairColor.TabIndex = 14;
			this.domainHairColor.SelectedIndexChanged += new global::System.EventHandler(this.domainHairColor_SelectedIndexChanged);
			this.labelHairColor.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHairColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHairColor.Location = new global::System.Drawing.Point(6, 101);
			this.labelHairColor.Name = "labelHairColor";
			this.labelHairColor.Size = new global::System.Drawing.Size(103, 20);
			this.labelHairColor.TabIndex = 13;
			this.labelHairColor.Text = "Hair Color";
			this.labelHairColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupHeadModel.Controls.Add(this.comboLatinModels);
			this.groupHeadModel.Controls.Add(this.radioButtonLatin);
			this.groupHeadModel.Controls.Add(this.comboAsiaticModels);
			this.groupHeadModel.Controls.Add(this.radioButtonAsiatic);
			this.groupHeadModel.Controls.Add(this.comboAfricanModels);
			this.groupHeadModel.Controls.Add(this.radioButtonAfrican);
			this.groupHeadModel.Controls.Add(this.radioButtonCaucasic);
			this.groupHeadModel.Controls.Add(this.comboCaucasicModels);
			this.groupHeadModel.Controls.Add(this.buttonRandomizeAppearance);
			this.groupHeadModel.Location = new global::System.Drawing.Point(6, 19);
			this.groupHeadModel.Name = "groupHeadModel";
			this.groupHeadModel.Size = new global::System.Drawing.Size(364, 79);
			this.groupHeadModel.TabIndex = 28;
			this.groupHeadModel.TabStop = false;
			this.groupHeadModel.Text = "Head Model";
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
			this.comboLatinModels.TabIndex = 3;
			this.comboLatinModels.Visible = false;
			this.comboLatinModels.SelectedIndexChanged += new global::System.EventHandler(this.comboLatinModels_SelectedIndexChanged);
			this.radioButtonLatin.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonLatin.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.radioButtonLatin.Location = new global::System.Drawing.Point(201, 19);
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
			this.radioButtonAsiatic.Location = new global::System.Drawing.Point(71, 19);
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
			this.radioButtonCaucasic.Location = new global::System.Drawing.Point(136, 19);
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
			this.buttonRandomizeAppearance.Location = new global::System.Drawing.Point(272, 18);
			this.buttonRandomizeAppearance.Name = "buttonRandomizeAppearance";
			this.buttonRandomizeAppearance.Size = new global::System.Drawing.Size(86, 23);
			this.buttonRandomizeAppearance.TabIndex = 27;
			this.buttonRandomizeAppearance.Text = "Randomize";
			this.buttonRandomizeAppearance.UseVisualStyleBackColor = true;
			this.buttonRandomizeAppearance.Click += new global::System.EventHandler(this.buttonRandomizeAppearance_Click);
			this.labelHeadType.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHeadType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHeadType.Location = new global::System.Drawing.Point(185, 112);
			this.labelHeadType.Name = "labelHeadType";
			this.labelHeadType.Size = new global::System.Drawing.Size(127, 20);
			this.labelHeadType.TabIndex = 11;
			this.labelHeadType.Text = "Head Model";
			this.labelHeadType.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelHairType.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelHairType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelHairType.Location = new global::System.Drawing.Point(16, 184);
			this.labelHairType.Name = "labelHairType";
			this.labelHairType.Size = new global::System.Drawing.Size(119, 20);
			this.labelHairType.TabIndex = 9;
			this.labelHairType.Text = "Hair Model";
			this.labelHairType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = true;
			this.pickUpControl.CreateButtonEnabled = true;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by Country", "by League" };
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
			this.pickUpControl.TabIndex = 1;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "RefereeForm";
			this.Text = "RefereeForm";
			base.Load += new global::System.EventHandler(this.RefereeForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupIdentity.ResumeLayout(false);
			this.groupIdentity.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.refereeBindingSource).EndInit();
			this.groupShoes.ResumeLayout(false);
			this.groupShoes.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureColorShoes1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesBrand).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesDesign).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericHeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericWeight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRefereeId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.countryListBindingSource).EndInit();
			this.groupLeagues.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tool3D.ResumeLayout(false);
			this.tool3D.PerformLayout();
			this.groupGenericFace.ResumeLayout(false);
			this.groupTextureInfo.ResumeLayout(false);
			this.groupTextureInfo.PerformLayout();
			this.groupHairModel.ResumeLayout(false);
			this.groupHeadModel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400057D RID: 1405
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400057E RID: 1406
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x0400057F RID: 1407
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000580 RID: 1408
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000581 RID: 1409
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x04000582 RID: 1410
		private global::System.Windows.Forms.GroupBox groupIdentity;

		// Token: 0x04000583 RID: 1411
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x04000584 RID: 1412
		private global::System.Windows.Forms.NumericUpDown numericRefereeId;

		// Token: 0x04000585 RID: 1413
		private global::System.Windows.Forms.Button buttonRandomizeIdentity;

		// Token: 0x04000586 RID: 1414
		private global::System.Windows.Forms.DateTimePicker dateBirthDate;

		// Token: 0x04000587 RID: 1415
		private global::System.Windows.Forms.Label labelBirthdate;

		// Token: 0x04000588 RID: 1416
		private global::System.Windows.Forms.Label labelRefereeId;

		// Token: 0x04000589 RID: 1417
		private global::System.Windows.Forms.TextBox textSurname;

		// Token: 0x0400058A RID: 1418
		private global::System.Windows.Forms.TextBox textFirstName;

		// Token: 0x0400058B RID: 1419
		private global::System.Windows.Forms.ComboBox comboCountry;

		// Token: 0x0400058C RID: 1420
		private global::System.Windows.Forms.Label labelFirstName;

		// Token: 0x0400058D RID: 1421
		private global::System.Windows.Forms.Label labelSurame;

		// Token: 0x0400058E RID: 1422
		private global::System.Windows.Forms.Label labelCountry;

		// Token: 0x0400058F RID: 1423
		private global::System.Windows.Forms.BindingSource refereeBindingSource;

		// Token: 0x04000590 RID: 1424
		private global::System.Windows.Forms.BindingSource countryListBindingSource;

		// Token: 0x04000591 RID: 1425
		private global::System.Windows.Forms.ComboBox comboBody;

		// Token: 0x04000592 RID: 1426
		private global::System.Windows.Forms.NumericUpDown numericHeight;

		// Token: 0x04000593 RID: 1427
		private global::System.Windows.Forms.NumericUpDown numericWeight;

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Forms.Label labelWeight;

		// Token: 0x04000595 RID: 1429
		private global::System.Windows.Forms.Label labelBody;

		// Token: 0x04000596 RID: 1430
		private global::System.Windows.Forms.Label labelHeight;

		// Token: 0x04000597 RID: 1431
		private global::System.Windows.Forms.DomainUpDown domainSleeves;

		// Token: 0x04000598 RID: 1432
		private global::System.Windows.Forms.Label labelSleeves;

		// Token: 0x04000599 RID: 1433
		private global::System.Windows.Forms.ComboBox comboLeague0;

		// Token: 0x0400059A RID: 1434
		private global::System.Windows.Forms.ComboBox comboStyle;

		// Token: 0x0400059B RID: 1435
		private global::System.Windows.Forms.Label labelStyle;

		// Token: 0x0400059C RID: 1436
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x0400059D RID: 1437
		private global::System.Windows.Forms.ToolStrip tool3D;

		// Token: 0x0400059E RID: 1438
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x0400059F RID: 1439
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040005A0 RID: 1440
		private global::System.Windows.Forms.GroupBox groupGenericFace;

		// Token: 0x040005A1 RID: 1441
		private global::System.Windows.Forms.GroupBox groupTextureInfo;

		// Token: 0x040005A2 RID: 1442
		private global::System.Windows.Forms.ComboBox comboSkinColor;

		// Token: 0x040005A3 RID: 1443
		private global::System.Windows.Forms.Label labelFacialHair;

		// Token: 0x040005A4 RID: 1444
		private global::System.Windows.Forms.Label labelEyeBow;

		// Token: 0x040005A5 RID: 1445
		private global::System.Windows.Forms.ComboBox domainFacialHair;

		// Token: 0x040005A6 RID: 1446
		private global::System.Windows.Forms.ComboBox comboEyeBow;

		// Token: 0x040005A7 RID: 1447
		private global::System.Windows.Forms.Label labelSideburns;

		// Token: 0x040005A8 RID: 1448
		private global::System.Windows.Forms.ComboBox comboSideburns;

		// Token: 0x040005A9 RID: 1449
		private global::System.Windows.Forms.Label labelSkintype;

		// Token: 0x040005AA RID: 1450
		private global::System.Windows.Forms.ComboBox comboEyescolor;

		// Token: 0x040005AB RID: 1451
		private global::System.Windows.Forms.ComboBox comboSkintype;

		// Token: 0x040005AC RID: 1452
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040005AD RID: 1453
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040005AE RID: 1454
		private global::System.Windows.Forms.ComboBox comboFacialHairColor;

		// Token: 0x040005AF RID: 1455
		private global::System.Windows.Forms.Label labelFacialHairColor;

		// Token: 0x040005B0 RID: 1456
		private global::System.Windows.Forms.GroupBox groupHairModel;

		// Token: 0x040005B1 RID: 1457
		private global::System.Windows.Forms.ComboBox comboHeadband;

		// Token: 0x040005B2 RID: 1458
		private global::System.Windows.Forms.ComboBox comboAfro;

		// Token: 0x040005B3 RID: 1459
		private global::System.Windows.Forms.ComboBox comboLong;

		// Token: 0x040005B4 RID: 1460
		private global::System.Windows.Forms.ComboBox comboMedium;

		// Token: 0x040005B5 RID: 1461
		private global::System.Windows.Forms.ComboBox comboModern;

		// Token: 0x040005B6 RID: 1462
		private global::System.Windows.Forms.ComboBox comboShort;

		// Token: 0x040005B7 RID: 1463
		private global::System.Windows.Forms.ComboBox comboVeryShort;

		// Token: 0x040005B8 RID: 1464
		private global::System.Windows.Forms.ComboBox comboShaven;

		// Token: 0x040005B9 RID: 1465
		private global::System.Windows.Forms.RadioButton radioHeadband;

		// Token: 0x040005BA RID: 1466
		private global::System.Windows.Forms.RadioButton radioShaven;

		// Token: 0x040005BB RID: 1467
		private global::System.Windows.Forms.RadioButton radioAfro;

		// Token: 0x040005BC RID: 1468
		private global::System.Windows.Forms.RadioButton radioLong;

		// Token: 0x040005BD RID: 1469
		private global::System.Windows.Forms.RadioButton radioMedium;

		// Token: 0x040005BE RID: 1470
		private global::System.Windows.Forms.RadioButton radioModern;

		// Token: 0x040005BF RID: 1471
		private global::System.Windows.Forms.RadioButton radioShort;

		// Token: 0x040005C0 RID: 1472
		private global::System.Windows.Forms.RadioButton radioVeryShort;

		// Token: 0x040005C1 RID: 1473
		private global::System.Windows.Forms.ComboBox domainHairColor;

		// Token: 0x040005C2 RID: 1474
		private global::System.Windows.Forms.Label labelHairColor;

		// Token: 0x040005C3 RID: 1475
		private global::System.Windows.Forms.GroupBox groupHeadModel;

		// Token: 0x040005C4 RID: 1476
		private global::System.Windows.Forms.ComboBox comboLatinModels;

		// Token: 0x040005C5 RID: 1477
		private global::System.Windows.Forms.RadioButton radioButtonLatin;

		// Token: 0x040005C6 RID: 1478
		private global::System.Windows.Forms.ComboBox comboAsiaticModels;

		// Token: 0x040005C7 RID: 1479
		private global::System.Windows.Forms.RadioButton radioButtonAsiatic;

		// Token: 0x040005C8 RID: 1480
		private global::System.Windows.Forms.ComboBox comboAfricanModels;

		// Token: 0x040005C9 RID: 1481
		private global::System.Windows.Forms.RadioButton radioButtonAfrican;

		// Token: 0x040005CA RID: 1482
		private global::System.Windows.Forms.RadioButton radioButtonCaucasic;

		// Token: 0x040005CB RID: 1483
		private global::System.Windows.Forms.ComboBox comboCaucasicModels;

		// Token: 0x040005CC RID: 1484
		private global::System.Windows.Forms.Button buttonRandomizeAppearance;

		// Token: 0x040005CD RID: 1485
		private global::System.Windows.Forms.Label labelHeadType;

		// Token: 0x040005CE RID: 1486
		private global::System.Windows.Forms.Label labelHairType;

		// Token: 0x040005CF RID: 1487
		private global::System.Windows.Forms.ToolStripButton buttonSwitchRenderingMode;

		// Token: 0x040005D0 RID: 1488
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040005D1 RID: 1489
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040005D2 RID: 1490
		private global::System.Windows.Forms.ComboBox comboLeague1;

		// Token: 0x040005D3 RID: 1491
		private global::System.Windows.Forms.ComboBox comboLeague2;

		// Token: 0x040005D4 RID: 1492
		private global::System.Windows.Forms.ComboBox comboLeague3;

		// Token: 0x040005D5 RID: 1493
		private global::System.Windows.Forms.GroupBox groupLeagues;

		// Token: 0x040005D6 RID: 1494
		private global::System.Windows.Forms.ComboBox comboLeague4;

		// Token: 0x040005D7 RID: 1495
		private global::System.Windows.Forms.ComboBox comboLeague7;

		// Token: 0x040005D8 RID: 1496
		private global::System.Windows.Forms.ComboBox comboLeague5;

		// Token: 0x040005D9 RID: 1497
		private global::System.Windows.Forms.ComboBox comboLeague6;

		// Token: 0x040005DA RID: 1498
		private global::FifaControls.Viewer2D viewer2DPlayerGui;

		// Token: 0x040005DB RID: 1499
		private global::System.Windows.Forms.ToolStripButton toolPhoto;

		// Token: 0x040005DC RID: 1500
		private global::System.Windows.Forms.GroupBox groupShoes;

		// Token: 0x040005DD RID: 1501
		private global::System.Windows.Forms.Label label1ShoesType;

		// Token: 0x040005DE RID: 1502
		private global::System.Windows.Forms.PictureBox pictureColorShoes2;

		// Token: 0x040005DF RID: 1503
		private global::System.Windows.Forms.PictureBox pictureColorShoes1;

		// Token: 0x040005E0 RID: 1504
		public global::System.Windows.Forms.NumericUpDown numericShoesBrand;

		// Token: 0x040005E1 RID: 1505
		private global::System.Windows.Forms.Label labelShoesType;

		// Token: 0x040005E2 RID: 1506
		private global::System.Windows.Forms.Label labelShoesColor;

		// Token: 0x040005E3 RID: 1507
		public global::System.Windows.Forms.NumericUpDown numericShoesDesign;

		// Token: 0x040005E4 RID: 1508
		private global::FifaControls.Viewer2D viewer2DShoes;

		// Token: 0x040005E5 RID: 1509
		private global::System.Windows.Forms.Label labelShoes;

		// Token: 0x040005E6 RID: 1510
		private global::System.Windows.Forms.RadioButton radioButtonGenderFemale;

		// Token: 0x040005E7 RID: 1511
		private global::System.Windows.Forms.RadioButton radioButtonGenderMale;
	}
}
