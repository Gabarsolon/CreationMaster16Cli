namespace CreationMaster
{
	// Token: 0x0200001B RID: 27
	public partial class StadiumForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00062594 File Offset: 0x00060794
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000625B4 File Offset: 0x000607B4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.StadiumForm));
			this.tabEsitStadium = new global::System.Windows.Forms.TabControl();
			this.pageStadiumGeneral = new global::System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.checkIsLicensed = new global::System.Windows.Forms.CheckBox();
			this.checkOrientation = new global::System.Windows.Forms.CheckBox();
			this.comboCountry = new global::System.Windows.Forms.ComboBox();
			this.labelCountry = new global::System.Windows.Forms.Label();
			this.numericCrowdColor = new global::System.Windows.Forms.NumericUpDown();
			this.labelCrowdColor = new global::System.Windows.Forms.Label();
			this.buttonGetId = new global::System.Windows.Forms.Button();
			this.numericStadiumId = new global::System.Windows.Forms.NumericUpDown();
			this.comboHomeTeam = new global::System.Windows.Forms.ComboBox();
			this.textDatabaseStadiumName = new global::System.Windows.Forms.TextBox();
			this.pictureHomeTeam = new global::System.Windows.Forms.PictureBox();
			this.labelDatabaseStadiumName = new global::System.Windows.Forms.Label();
			this.textLocalStadiumName = new global::System.Windows.Forms.TextBox();
			this.labelLocalStadiumName = new global::System.Windows.Forms.Label();
			this.labelStadiumId = new global::System.Windows.Forms.Label();
			this.domainStadiumType = new global::System.Windows.Forms.DomainUpDown();
			this.numericYearBuilt = new global::System.Windows.Forms.NumericUpDown();
			this.numericCapacity = new global::System.Windows.Forms.NumericUpDown();
			this.labelCapacity = new global::System.Windows.Forms.Label();
			this.labelYearBuilt = new global::System.Windows.Forms.Label();
			this.labelStadiumType = new global::System.Windows.Forms.Label();
			this.groupMowingPattern = new global::System.Windows.Forms.GroupBox();
			this.numericMowing = new global::System.Windows.Forms.NumericUpDown();
			this.viewer2DMowing = new global::FifaControls.Viewer2D();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.checkDeepNet = new global::System.Windows.Forms.CheckBox();
			this.viewer2DNet = new global::FifaControls.Viewer2D();
			this.numericNet = new global::System.Windows.Forms.NumericUpDown();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.groupCamera = new global::System.Windows.Forms.GroupBox();
			this.numericCameraZoom = new global::System.Windows.Forms.NumericUpDown();
			this.numericCameraHeight = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupAdboards = new global::System.Windows.Forms.GroupBox();
			this.numericAdboardType = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.numericSideLineDistance = new global::System.Windows.Forms.NumericUpDown();
			this.numericEndLineDistance = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelAdboardEndLine = new global::System.Windows.Forms.Label();
			this.groupTimeAndWeather = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboDayWeather = new global::System.Windows.Forms.ComboBox();
			this.checkNight = new global::System.Windows.Forms.CheckBox();
			this.checkSunnyDay = new global::System.Windows.Forms.CheckBox();
			this.groupPolice = new global::System.Windows.Forms.GroupBox();
			this.comboPolice = new global::System.Windows.Forms.ComboBox();
			this.viewer2DPolice = new global::FifaControls.Viewer2D();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.groupBox10 = new global::System.Windows.Forms.GroupBox();
			this.numericTechZoneAwayMaxZ = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneAwayMinZ = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneAwayMaxX = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneAwayMinX = new global::System.Windows.Forms.NumericUpDown();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.groupBox9 = new global::System.Windows.Forms.GroupBox();
			this.numericTechZoneHomeMaxZ = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneHomeMinZ = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneHomeMaxX = new global::System.Windows.Forms.NumericUpDown();
			this.numericTechZoneHomeMinX = new global::System.Windows.Forms.NumericUpDown();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.pageStadiumPreview = new global::System.Windows.Forms.TabPage();
			this.groupEnvironment = new global::System.Windows.Forms.GroupBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.viewer2DPreviewLarge = new global::FifaControls.Viewer2D();
			this.viewer2DPreview = new global::FifaControls.Viewer2D();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.radioPreviewClearDay = new global::System.Windows.Forms.RadioButton();
			this.radioPreviewNight = new global::System.Windows.Forms.RadioButton();
			this.pageStadiumModel = new global::System.Windows.Forms.TabPage();
			this.flowLayoutPanel2 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.radioModelClearDay = new global::System.Windows.Forms.RadioButton();
			this.radioModelNight = new global::System.Windows.Forms.RadioButton();
			this.multiViewer2DTextures = new global::FifaControls.MultiViewer2D();
			this.groupLights = new global::System.Windows.Forms.GroupBox();
			this.comboStadiumLights = new global::System.Windows.Forms.ComboBox();
			this.stadiumListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.buttonCopyCrowd = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.multiViewer2DCoverMap = new global::FifaControls.MultiViewer2D();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.radioPreviewOvercast = new global::System.Windows.Forms.RadioButton();
			this.radioPreviewSunset = new global::System.Windows.Forms.RadioButton();
			this.tabEsitStadium.SuspendLayout();
			this.pageStadiumGeneral.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCrowdColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericStadiumId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureHomeTeam).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericYearBuilt).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCapacity).BeginInit();
			this.groupMowingPattern.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericMowing).BeginInit();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNet).BeginInit();
			this.groupBox6.SuspendLayout();
			this.groupCamera.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCameraZoom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCameraHeight).BeginInit();
			this.groupAdboards.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericAdboardType).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSideLineDistance).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericEndLineDistance).BeginInit();
			this.groupTimeAndWeather.SuspendLayout();
			this.groupPolice.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox10.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMaxZ).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMinZ).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMaxX).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMinX).BeginInit();
			this.groupBox9.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMaxZ).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMinZ).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMaxX).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMinX).BeginInit();
			this.pageStadiumPreview.SuspendLayout();
			this.groupEnvironment.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pageStadiumModel.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupLights.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.stadiumListBindingSource).BeginInit();
			this.groupBox5.SuspendLayout();
			base.SuspendLayout();
			this.tabEsitStadium.Controls.Add(this.pageStadiumGeneral);
			this.tabEsitStadium.Controls.Add(this.pageStadiumPreview);
			this.tabEsitStadium.Controls.Add(this.pageStadiumModel);
			this.tabEsitStadium.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabEsitStadium.Location = new global::System.Drawing.Point(0, 25);
			this.tabEsitStadium.Name = "tabEsitStadium";
			this.tabEsitStadium.SelectedIndex = 0;
			this.tabEsitStadium.Size = new global::System.Drawing.Size(1357, 807);
			this.tabEsitStadium.TabIndex = 2;
			this.tabEsitStadium.SelectedIndexChanged += new global::System.EventHandler(this.tabEsitStadium_SelectedIndexChanged);
			this.pageStadiumGeneral.Controls.Add(this.flowLayoutPanel1);
			this.pageStadiumGeneral.Location = new global::System.Drawing.Point(4, 22);
			this.pageStadiumGeneral.Name = "pageStadiumGeneral";
			this.pageStadiumGeneral.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageStadiumGeneral.Size = new global::System.Drawing.Size(1349, 781);
			this.pageStadiumGeneral.TabIndex = 0;
			this.pageStadiumGeneral.Text = "General";
			this.pageStadiumGeneral.UseVisualStyleBackColor = true;
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = global::System.Drawing.SystemColors.Control;
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupMowingPattern);
			this.flowLayoutPanel1.Controls.Add(this.groupBox3);
			this.flowLayoutPanel1.Controls.Add(this.groupBox6);
			this.flowLayoutPanel1.Controls.Add(this.groupPolice);
			this.flowLayoutPanel1.Controls.Add(this.groupBox8);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(1343, 775);
			this.flowLayoutPanel1.TabIndex = 0;
			this.groupBox1.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.checkIsLicensed);
			this.groupBox1.Controls.Add(this.checkOrientation);
			this.groupBox1.Controls.Add(this.comboCountry);
			this.groupBox1.Controls.Add(this.labelCountry);
			this.groupBox1.Controls.Add(this.numericCrowdColor);
			this.groupBox1.Controls.Add(this.labelCrowdColor);
			this.groupBox1.Controls.Add(this.buttonGetId);
			this.groupBox1.Controls.Add(this.numericStadiumId);
			this.groupBox1.Controls.Add(this.comboHomeTeam);
			this.groupBox1.Controls.Add(this.textDatabaseStadiumName);
			this.groupBox1.Controls.Add(this.pictureHomeTeam);
			this.groupBox1.Controls.Add(this.labelDatabaseStadiumName);
			this.groupBox1.Controls.Add(this.textLocalStadiumName);
			this.groupBox1.Controls.Add(this.labelLocalStadiumName);
			this.groupBox1.Controls.Add(this.labelStadiumId);
			this.groupBox1.Controls.Add(this.domainStadiumType);
			this.groupBox1.Controls.Add(this.numericYearBuilt);
			this.groupBox1.Controls.Add(this.numericCapacity);
			this.groupBox1.Controls.Add(this.labelCapacity);
			this.groupBox1.Controls.Add(this.labelYearBuilt);
			this.groupBox1.Controls.Add(this.labelStadiumType);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(265, 339);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Info";
			this.checkIsLicensed.AutoSize = true;
			this.checkIsLicensed.Location = new global::System.Drawing.Point(6, 238);
			this.checkIsLicensed.Name = "checkIsLicensed";
			this.checkIsLicensed.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsLicensed.Size = new global::System.Drawing.Size(122, 17);
			this.checkIsLicensed.TabIndex = 126;
			this.checkIsLicensed.Text = "              Is Licensed";
			this.checkIsLicensed.UseVisualStyleBackColor = true;
			this.checkIsLicensed.CheckedChanged += new global::System.EventHandler(this.checkIsLicensed_CheckedChanged);
			this.checkOrientation.AutoSize = true;
			this.checkOrientation.Location = new global::System.Drawing.Point(6, 215);
			this.checkOrientation.Name = "checkOrientation";
			this.checkOrientation.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkOrientation.Size = new global::System.Drawing.Size(122, 17);
			this.checkOrientation.TabIndex = 8;
			this.checkOrientation.Text = "Opposite Orientation";
			this.checkOrientation.UseVisualStyleBackColor = true;
			this.checkOrientation.CheckedChanged += new global::System.EventHandler(this.checkOrientation_CheckedChanged);
			this.comboCountry.Location = new global::System.Drawing.Point(118, 177);
			this.comboCountry.Name = "comboCountry";
			this.comboCountry.Size = new global::System.Drawing.Size(137, 21);
			this.comboCountry.TabIndex = 7;
			this.comboCountry.SelectedIndexChanged += new global::System.EventHandler(this.comboCountry_SelectedIndexChanged);
			this.labelCountry.AutoSize = true;
			this.labelCountry.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelCountry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCountry.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelCountry.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCountry.Location = new global::System.Drawing.Point(6, 180);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new global::System.Drawing.Size(43, 13);
			this.labelCountry.TabIndex = 125;
			this.labelCountry.Text = "Country";
			this.labelCountry.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelCountry.Click += new global::System.EventHandler(this.labelCountry_DoubleClick);
			this.numericCrowdColor.Location = new global::System.Drawing.Point(118, 152);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericCrowdColor;
			int[] array = new int[4];
			array[0] = 8;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericCrowdColor;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericCrowdColor.Name = "numericCrowdColor";
			this.numericCrowdColor.Size = new global::System.Drawing.Size(136, 20);
			this.numericCrowdColor.TabIndex = 6;
			this.numericCrowdColor.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericCrowdColor;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.numericCrowdColor.ValueChanged += new global::System.EventHandler(this.numericCrowdColor_ValueChanged);
			this.labelCrowdColor.AutoSize = true;
			this.labelCrowdColor.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelCrowdColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCrowdColor.Location = new global::System.Drawing.Point(6, 154);
			this.labelCrowdColor.Name = "labelCrowdColor";
			this.labelCrowdColor.Size = new global::System.Drawing.Size(59, 13);
			this.labelCrowdColor.TabIndex = 122;
			this.labelCrowdColor.Text = "Seat Color ";
			this.labelCrowdColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonGetId.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonGetId.BackgroundImage");
			this.buttonGetId.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonGetId.Location = new global::System.Drawing.Point(225, 59);
			this.buttonGetId.Name = "buttonGetId";
			this.buttonGetId.Size = new global::System.Drawing.Size(24, 24);
			this.buttonGetId.TabIndex = 1;
			this.buttonGetId.TabStop = false;
			this.buttonGetId.UseVisualStyleBackColor = true;
			this.buttonGetId.Click += new global::System.EventHandler(this.buttonGetId_Click);
			this.numericStadiumId.Location = new global::System.Drawing.Point(118, 61);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericStadiumId;
			int[] array4 = new int[4];
			array4[0] = 200000;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericStadiumId.Name = "numericStadiumId";
			this.numericStadiumId.Size = new global::System.Drawing.Size(100, 20);
			this.numericStadiumId.TabIndex = 2;
			this.numericStadiumId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericStadiumId;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Value = new decimal(array5);
			this.numericStadiumId.ValueChanged += new global::System.EventHandler(this.numericStadiumId_ValueChanged);
			this.comboHomeTeam.ItemHeight = 13;
			this.comboHomeTeam.Location = new global::System.Drawing.Point(155, 304);
			this.comboHomeTeam.MaxLength = 32767;
			this.comboHomeTeam.Name = "comboHomeTeam";
			this.comboHomeTeam.Size = new global::System.Drawing.Size(100, 21);
			this.comboHomeTeam.Sorted = true;
			this.comboHomeTeam.TabIndex = 9;
			this.comboHomeTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboHomeTeam_SelectedIndexChanged);
			this.textDatabaseStadiumName.Location = new global::System.Drawing.Point(118, 16);
			this.textDatabaseStadiumName.Name = "textDatabaseStadiumName";
			this.textDatabaseStadiumName.Size = new global::System.Drawing.Size(136, 20);
			this.textDatabaseStadiumName.TabIndex = 0;
			this.textDatabaseStadiumName.TextChanged += new global::System.EventHandler(this.textDatabaseStadiumName_TextChanged);
			this.pictureHomeTeam.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureHomeTeam.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureHomeTeam.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureHomeTeam.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureHomeTeam.Location = new global::System.Drawing.Point(155, 204);
			this.pictureHomeTeam.Name = "pictureHomeTeam";
			this.pictureHomeTeam.Size = new global::System.Drawing.Size(100, 100);
			this.pictureHomeTeam.TabIndex = 68;
			this.pictureHomeTeam.TabStop = false;
			this.pictureHomeTeam.DoubleClick += new global::System.EventHandler(this.pictureHomeTeam_DoubleClick);
			this.labelDatabaseStadiumName.AutoSize = true;
			this.labelDatabaseStadiumName.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelDatabaseStadiumName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelDatabaseStadiumName.Location = new global::System.Drawing.Point(6, 16);
			this.labelDatabaseStadiumName.Name = "labelDatabaseStadiumName";
			this.labelDatabaseStadiumName.Size = new global::System.Drawing.Size(84, 13);
			this.labelDatabaseStadiumName.TabIndex = 1;
			this.labelDatabaseStadiumName.Text = "Database Name";
			this.labelDatabaseStadiumName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textLocalStadiumName.Location = new global::System.Drawing.Point(118, 38);
			this.textLocalStadiumName.Name = "textLocalStadiumName";
			this.textLocalStadiumName.Size = new global::System.Drawing.Size(136, 20);
			this.textLocalStadiumName.TabIndex = 1;
			this.textLocalStadiumName.TextChanged += new global::System.EventHandler(this.textLocalStadiumName_TextChanged);
			this.labelLocalStadiumName.AutoSize = true;
			this.labelLocalStadiumName.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLocalStadiumName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelLocalStadiumName.Location = new global::System.Drawing.Point(6, 37);
			this.labelLocalStadiumName.Name = "labelLocalStadiumName";
			this.labelLocalStadiumName.Size = new global::System.Drawing.Size(35, 13);
			this.labelLocalStadiumName.TabIndex = 2;
			this.labelLocalStadiumName.Text = "Name";
			this.labelLocalStadiumName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelStadiumId.AutoSize = true;
			this.labelStadiumId.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelStadiumId.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStadiumId.Location = new global::System.Drawing.Point(6, 63);
			this.labelStadiumId.Name = "labelStadiumId";
			this.labelStadiumId.Size = new global::System.Drawing.Size(57, 13);
			this.labelStadiumId.TabIndex = 121;
			this.labelStadiumId.Text = "Stadium Id";
			this.labelStadiumId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.domainStadiumType.Items.Add("Official");
			this.domainStadiumType.Items.Add("Training");
			this.domainStadiumType.Location = new global::System.Drawing.Point(118, 129);
			this.domainStadiumType.Name = "domainStadiumType";
			this.domainStadiumType.Size = new global::System.Drawing.Size(136, 20);
			this.domainStadiumType.TabIndex = 5;
			this.domainStadiumType.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.domainStadiumType.Wrap = true;
			this.domainStadiumType.SelectedItemChanged += new global::System.EventHandler(this.domainStadiumType_SelectedItemChanged);
			this.numericYearBuilt.Location = new global::System.Drawing.Point(118, 106);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericYearBuilt;
			int[] array6 = new int[4];
			array6[0] = 2050;
			numericUpDown6.Maximum = new decimal(array6);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericYearBuilt;
			int[] array7 = new int[4];
			array7[0] = 1800;
			numericUpDown7.Minimum = new decimal(array7);
			this.numericYearBuilt.Name = "numericYearBuilt";
			this.numericYearBuilt.Size = new global::System.Drawing.Size(136, 20);
			this.numericYearBuilt.TabIndex = 4;
			this.numericYearBuilt.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericYearBuilt;
			int[] array8 = new int[4];
			array8[0] = 1800;
			numericUpDown8.Value = new decimal(array8);
			this.numericYearBuilt.ValueChanged += new global::System.EventHandler(this.numericYearBuilt_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericCapacity;
			int[] array9 = new int[4];
			array9[0] = 1000;
			numericUpDown9.Increment = new decimal(array9);
			this.numericCapacity.Location = new global::System.Drawing.Point(118, 84);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericCapacity;
			int[] array10 = new int[4];
			array10[0] = 200000;
			numericUpDown10.Maximum = new decimal(array10);
			this.numericCapacity.Name = "numericCapacity";
			this.numericCapacity.Size = new global::System.Drawing.Size(136, 20);
			this.numericCapacity.TabIndex = 3;
			this.numericCapacity.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCapacity.ThousandsSeparator = true;
			this.numericCapacity.ValueChanged += new global::System.EventHandler(this.numericCapacity_ValueChanged);
			this.labelCapacity.AutoSize = true;
			this.labelCapacity.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelCapacity.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCapacity.Location = new global::System.Drawing.Point(6, 84);
			this.labelCapacity.Name = "labelCapacity";
			this.labelCapacity.Size = new global::System.Drawing.Size(48, 13);
			this.labelCapacity.TabIndex = 70;
			this.labelCapacity.Text = "Capacity";
			this.labelCapacity.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelYearBuilt.AutoSize = true;
			this.labelYearBuilt.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelYearBuilt.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelYearBuilt.Location = new global::System.Drawing.Point(6, 106);
			this.labelYearBuilt.Name = "labelYearBuilt";
			this.labelYearBuilt.Size = new global::System.Drawing.Size(52, 13);
			this.labelYearBuilt.TabIndex = 72;
			this.labelYearBuilt.Text = "Year Built";
			this.labelYearBuilt.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelStadiumType.AutoSize = true;
			this.labelStadiumType.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelStadiumType.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelStadiumType.Location = new global::System.Drawing.Point(6, 129);
			this.labelStadiumType.Name = "labelStadiumType";
			this.labelStadiumType.Size = new global::System.Drawing.Size(31, 13);
			this.labelStadiumType.TabIndex = 74;
			this.labelStadiumType.Text = "Type";
			this.labelStadiumType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupMowingPattern.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupMowingPattern.Controls.Add(this.numericMowing);
			this.groupMowingPattern.Controls.Add(this.viewer2DMowing);
			this.groupMowingPattern.Location = new global::System.Drawing.Point(274, 3);
			this.groupMowingPattern.Name = "groupMowingPattern";
			this.groupMowingPattern.Size = new global::System.Drawing.Size(266, 339);
			this.groupMowingPattern.TabIndex = 1;
			this.groupMowingPattern.TabStop = false;
			this.groupMowingPattern.Text = "Mowing Pattern";
			this.numericMowing.Location = new global::System.Drawing.Point(6, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericMowing;
			int[] array11 = new int[4];
			array11[0] = 13;
			numericUpDown11.Maximum = new decimal(array11);
			this.numericMowing.Name = "numericMowing";
			this.numericMowing.Size = new global::System.Drawing.Size(64, 20);
			this.numericMowing.TabIndex = 0;
			this.numericMowing.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numericMowing;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown12.Value = new decimal(array12);
			this.numericMowing.ValueChanged += new global::System.EventHandler(this.numericMowing_ValueChanged);
			this.viewer2DMowing.AutoTransparency = false;
			this.viewer2DMowing.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DMowing.ButtonStripVisible = false;
			this.viewer2DMowing.CurrentBitmap = null;
			this.viewer2DMowing.ExtendedFormat = false;
			this.viewer2DMowing.FullSizeButton = false;
			this.viewer2DMowing.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DMowing.ImageSize = new global::System.Drawing.Size(1024, 2048);
			this.viewer2DMowing.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DMowing.Location = new global::System.Drawing.Point(6, 45);
			this.viewer2DMowing.Name = "viewer2DMowing";
			this.viewer2DMowing.RemoveButton = false;
			this.viewer2DMowing.ShowButton = false;
			this.viewer2DMowing.ShowButtonChecked = true;
			this.viewer2DMowing.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DMowing.TabIndex = 1;
			this.viewer2DMowing.TabStop = false;
			this.groupBox3.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox3.Controls.Add(this.checkDeepNet);
			this.groupBox3.Controls.Add(this.viewer2DNet);
			this.groupBox3.Controls.Add(this.numericNet);
			this.groupBox3.Location = new global::System.Drawing.Point(546, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(152, 339);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Net";
			this.checkDeepNet.AutoSize = true;
			this.checkDeepNet.Location = new global::System.Drawing.Point(14, 214);
			this.checkDeepNet.Name = "checkDeepNet";
			this.checkDeepNet.Size = new global::System.Drawing.Size(72, 17);
			this.checkDeepNet.TabIndex = 1;
			this.checkDeepNet.Text = "Deep Net";
			this.checkDeepNet.UseVisualStyleBackColor = true;
			this.checkDeepNet.CheckedChanged += new global::System.EventHandler(this.checkDeepNet_CheckedChanged);
			this.viewer2DNet.AutoTransparency = true;
			this.viewer2DNet.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DNet.ButtonStripVisible = false;
			this.viewer2DNet.CurrentBitmap = null;
			this.viewer2DNet.ExtendedFormat = false;
			this.viewer2DNet.FullSizeButton = false;
			this.viewer2DNet.ImageLayout = global::System.Windows.Forms.ImageLayout.Tile;
			this.viewer2DNet.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DNet.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DNet.Location = new global::System.Drawing.Point(14, 44);
			this.viewer2DNet.Name = "viewer2DNet";
			this.viewer2DNet.RemoveButton = false;
			this.viewer2DNet.ShowButton = false;
			this.viewer2DNet.ShowButtonChecked = true;
			this.viewer2DNet.Size = new global::System.Drawing.Size(128, 153);
			this.viewer2DNet.TabIndex = 1;
			this.viewer2DNet.TabStop = false;
			this.numericNet.Location = new global::System.Drawing.Point(14, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numericNet;
			int[] array13 = new int[4];
			array13[0] = 10;
			numericUpDown13.Maximum = new decimal(array13);
			this.numericNet.Name = "numericNet";
			this.numericNet.Size = new global::System.Drawing.Size(64, 20);
			this.numericNet.TabIndex = 0;
			this.numericNet.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numericNet;
			int[] array14 = new int[4];
			array14[0] = 1;
			numericUpDown14.Value = new decimal(array14);
			this.numericNet.ValueChanged += new global::System.EventHandler(this.numericNet_ValueChanged);
			this.groupBox6.Controls.Add(this.groupCamera);
			this.groupBox6.Controls.Add(this.groupAdboards);
			this.groupBox6.Controls.Add(this.groupTimeAndWeather);
			this.groupBox6.Location = new global::System.Drawing.Point(704, 3);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(202, 339);
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupCamera.Controls.Add(this.numericCameraZoom);
			this.groupCamera.Controls.Add(this.numericCameraHeight);
			this.groupCamera.Controls.Add(this.label4);
			this.groupCamera.Controls.Add(this.label5);
			this.groupCamera.Location = new global::System.Drawing.Point(6, 215);
			this.groupCamera.Name = "groupCamera";
			this.groupCamera.Size = new global::System.Drawing.Size(192, 73);
			this.groupCamera.TabIndex = 2;
			this.groupCamera.TabStop = false;
			this.groupCamera.Text = "Camera";
			this.numericCameraZoom.Location = new global::System.Drawing.Point(106, 45);
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numericCameraZoom;
			int[] array15 = new int[4];
			array15[0] = 15;
			numericUpDown15.Maximum = new decimal(array15);
			this.numericCameraZoom.Name = "numericCameraZoom";
			this.numericCameraZoom.Size = new global::System.Drawing.Size(80, 20);
			this.numericCameraZoom.TabIndex = 119;
			this.numericCameraZoom.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numericCameraZoom;
			int[] array16 = new int[4];
			array16[0] = 7;
			numericUpDown16.Value = new decimal(array16);
			this.numericCameraZoom.ValueChanged += new global::System.EventHandler(this.numericCameraZoom_ValueChanged);
			this.numericCameraHeight.Location = new global::System.Drawing.Point(106, 19);
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numericCameraHeight;
			int[] array17 = new int[4];
			array17[0] = 31;
			numericUpDown17.Maximum = new decimal(array17);
			this.numericCameraHeight.Name = "numericCameraHeight";
			this.numericCameraHeight.Size = new global::System.Drawing.Size(80, 20);
			this.numericCameraHeight.TabIndex = 118;
			this.numericCameraHeight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numericCameraHeight;
			int[] array18 = new int[4];
			array18[0] = 15;
			numericUpDown18.Value = new decimal(array18);
			this.numericCameraHeight.ValueChanged += new global::System.EventHandler(this.numericCameraHeight_ValueChanged);
			this.label4.AutoSize = true;
			this.label4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new global::System.Drawing.Point(3, 47);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(34, 13);
			this.label4.TabIndex = 117;
			this.label4.Text = "Zoom";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label5.AutoSize = true;
			this.label5.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new global::System.Drawing.Point(3, 21);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(38, 13);
			this.label5.TabIndex = 116;
			this.label5.Text = "Height";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupAdboards.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupAdboards.Controls.Add(this.numericAdboardType);
			this.groupAdboards.Controls.Add(this.label6);
			this.groupAdboards.Controls.Add(this.numericSideLineDistance);
			this.groupAdboards.Controls.Add(this.numericEndLineDistance);
			this.groupAdboards.Controls.Add(this.label1);
			this.groupAdboards.Controls.Add(this.labelAdboardEndLine);
			this.groupAdboards.Location = new global::System.Drawing.Point(6, 13);
			this.groupAdboards.Name = "groupAdboards";
			this.groupAdboards.Size = new global::System.Drawing.Size(192, 106);
			this.groupAdboards.TabIndex = 0;
			this.groupAdboards.TabStop = false;
			this.groupAdboards.Text = "Adboards";
			this.numericAdboardType.Location = new global::System.Drawing.Point(106, 26);
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numericAdboardType;
			int[] array19 = new int[4];
			array19[0] = 3;
			numericUpDown19.Maximum = new decimal(array19);
			this.numericAdboardType.Name = "numericAdboardType";
			this.numericAdboardType.Size = new global::System.Drawing.Size(80, 20);
			this.numericAdboardType.TabIndex = 119;
			this.numericAdboardType.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericAdboardType.ValueChanged += new global::System.EventHandler(this.numericAdboardType_ValueChanged);
			this.label6.AutoSize = true;
			this.label6.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label6.Location = new global::System.Drawing.Point(7, 28);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(31, 13);
			this.label6.TabIndex = 116;
			this.label6.Text = "Type";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericSideLineDistance.Location = new global::System.Drawing.Point(106, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numericSideLineDistance;
			int[] array20 = new int[4];
			array20[0] = 2000;
			numericUpDown20.Maximum = new decimal(array20);
			this.numericSideLineDistance.Name = "numericSideLineDistance";
			this.numericSideLineDistance.Size = new global::System.Drawing.Size(82, 20);
			this.numericSideLineDistance.TabIndex = 1;
			this.numericSideLineDistance.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numericSideLineDistance;
			int[] array21 = new int[4];
			array21[0] = 500;
			numericUpDown21.Value = new decimal(array21);
			this.numericSideLineDistance.ValueChanged += new global::System.EventHandler(this.numericSideLineDistance_ValueChanged);
			this.numericEndLineDistance.Location = new global::System.Drawing.Point(106, 53);
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numericEndLineDistance;
			int[] array22 = new int[4];
			array22[0] = 2000;
			numericUpDown22.Maximum = new decimal(array22);
			this.numericEndLineDistance.Name = "numericEndLineDistance";
			this.numericEndLineDistance.Size = new global::System.Drawing.Size(82, 20);
			this.numericEndLineDistance.TabIndex = 0;
			this.numericEndLineDistance.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numericEndLineDistance;
			int[] array23 = new int[4];
			array23[0] = 500;
			numericUpDown23.Value = new decimal(array23);
			this.numericEndLineDistance.ValueChanged += new global::System.EventHandler(this.numericEndLineDistance_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(7, 81);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(96, 13);
			this.label1.TabIndex = 115;
			this.label1.Text = "Side Line Distance";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelAdboardEndLine.AutoSize = true;
			this.labelAdboardEndLine.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelAdboardEndLine.Location = new global::System.Drawing.Point(7, 55);
			this.labelAdboardEndLine.Name = "labelAdboardEndLine";
			this.labelAdboardEndLine.Size = new global::System.Drawing.Size(94, 13);
			this.labelAdboardEndLine.TabIndex = 114;
			this.labelAdboardEndLine.Text = "End Line Distance";
			this.labelAdboardEndLine.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.groupTimeAndWeather.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupTimeAndWeather.Controls.Add(this.label2);
			this.groupTimeAndWeather.Controls.Add(this.comboDayWeather);
			this.groupTimeAndWeather.Controls.Add(this.checkNight);
			this.groupTimeAndWeather.Controls.Add(this.checkSunnyDay);
			this.groupTimeAndWeather.Location = new global::System.Drawing.Point(6, 125);
			this.groupTimeAndWeather.Name = "groupTimeAndWeather";
			this.groupTimeAndWeather.Size = new global::System.Drawing.Size(192, 84);
			this.groupTimeAndWeather.TabIndex = 1;
			this.groupTimeAndWeather.TabStop = false;
			this.groupTimeAndWeather.Text = "Time and Weather";
			this.label2.AutoSize = true;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(6, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(48, 13);
			this.label2.TabIndex = 116;
			this.label2.Text = "Weather";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboDayWeather.FormattingEnabled = true;
			this.comboDayWeather.Items.AddRange(new object[] { "Dry", "Can Rain", "Can Snow" });
			this.comboDayWeather.Location = new global::System.Drawing.Point(69, 52);
			this.comboDayWeather.Name = "comboDayWeather";
			this.comboDayWeather.Size = new global::System.Drawing.Size(117, 21);
			this.comboDayWeather.TabIndex = 4;
			this.comboDayWeather.SelectedIndexChanged += new global::System.EventHandler(this.comboDayWeather_SelectedIndexChanged);
			this.checkNight.AutoSize = true;
			this.checkNight.Location = new global::System.Drawing.Point(106, 25);
			this.checkNight.Name = "checkNight";
			this.checkNight.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkNight.Size = new global::System.Drawing.Size(51, 17);
			this.checkNight.TabIndex = 3;
			this.checkNight.Text = "Night";
			this.checkNight.UseVisualStyleBackColor = true;
			this.checkNight.CheckedChanged += new global::System.EventHandler(this.checkNight_CheckedChanged);
			this.checkSunnyDay.AutoSize = true;
			this.checkSunnyDay.Location = new global::System.Drawing.Point(6, 25);
			this.checkSunnyDay.Name = "checkSunnyDay";
			this.checkSunnyDay.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkSunnyDay.Size = new global::System.Drawing.Size(45, 17);
			this.checkSunnyDay.TabIndex = 0;
			this.checkSunnyDay.Text = "Day";
			this.checkSunnyDay.UseVisualStyleBackColor = true;
			this.checkSunnyDay.CheckedChanged += new global::System.EventHandler(this.checkSunnyDay_CheckedChanged);
			this.groupPolice.Controls.Add(this.comboPolice);
			this.groupPolice.Controls.Add(this.viewer2DPolice);
			this.groupPolice.Location = new global::System.Drawing.Point(912, 3);
			this.groupPolice.Name = "groupPolice";
			this.groupPolice.Size = new global::System.Drawing.Size(270, 339);
			this.groupPolice.TabIndex = 4;
			this.groupPolice.TabStop = false;
			this.groupPolice.Text = "Police";
			this.comboPolice.FormattingEnabled = true;
			this.comboPolice.Items.AddRange(new object[]
			{
				"0 = None", "1 = English Police", "2 = French Police", "3 = Italian Police", "4 = German Police", "5 = Spanish Police", "6 = Mexican Police", "7 = Asiatic Traits Police", "8 = African Traits Police", "9 = CaucasicTraits Police",
				"10 = ArabicTraits Police"
			});
			this.comboPolice.Location = new global::System.Drawing.Point(32, 17);
			this.comboPolice.Name = "comboPolice";
			this.comboPolice.Size = new global::System.Drawing.Size(207, 21);
			this.comboPolice.TabIndex = 126;
			this.comboPolice.SelectedIndexChanged += new global::System.EventHandler(this.comboPolice_SelectedIndexChanged);
			this.viewer2DPolice.AutoTransparency = false;
			this.viewer2DPolice.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPolice.ButtonStripVisible = false;
			this.viewer2DPolice.CurrentBitmap = null;
			this.viewer2DPolice.ExtendedFormat = false;
			this.viewer2DPolice.FullSizeButton = false;
			this.viewer2DPolice.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DPolice.ImageSize = new global::System.Drawing.Size(1024, 1024);
			this.viewer2DPolice.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DPolice.Location = new global::System.Drawing.Point(7, 44);
			this.viewer2DPolice.Name = "viewer2DPolice";
			this.viewer2DPolice.RemoveButton = false;
			this.viewer2DPolice.ShowButton = false;
			this.viewer2DPolice.ShowButtonChecked = true;
			this.viewer2DPolice.Size = new global::System.Drawing.Size(256, 256);
			this.viewer2DPolice.TabIndex = 2;
			this.viewer2DPolice.TabStop = false;
			this.groupBox8.Controls.Add(this.groupBox10);
			this.groupBox8.Controls.Add(this.groupBox9);
			this.groupBox8.Location = new global::System.Drawing.Point(3, 348);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new global::System.Drawing.Size(475, 133);
			this.groupBox8.TabIndex = 5;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Technical Zone Coordinates";
			this.groupBox10.Controls.Add(this.numericTechZoneAwayMaxZ);
			this.groupBox10.Controls.Add(this.numericTechZoneAwayMinZ);
			this.groupBox10.Controls.Add(this.numericTechZoneAwayMaxX);
			this.groupBox10.Controls.Add(this.numericTechZoneAwayMinX);
			this.groupBox10.Controls.Add(this.label11);
			this.groupBox10.Controls.Add(this.label12);
			this.groupBox10.Controls.Add(this.label13);
			this.groupBox10.Controls.Add(this.label14);
			this.groupBox10.Location = new global::System.Drawing.Point(237, 19);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new global::System.Drawing.Size(228, 108);
			this.groupBox10.TabIndex = 1;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Away";
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numericTechZoneAwayMaxZ;
			int[] array24 = new int[4];
			array24[0] = 5;
			numericUpDown24.Increment = new decimal(array24);
			this.numericTechZoneAwayMaxZ.Location = new global::System.Drawing.Point(135, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.numericTechZoneAwayMaxZ;
			int[] array25 = new int[4];
			array25[0] = 4500;
			numericUpDown25.Maximum = new decimal(array25);
			this.numericTechZoneAwayMaxZ.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneAwayMaxZ.Name = "numericTechZoneAwayMaxZ";
			this.numericTechZoneAwayMaxZ.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneAwayMaxZ.TabIndex = 15;
			this.numericTechZoneAwayMaxZ.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneAwayMaxZ.ValueChanged += new global::System.EventHandler(this.numericTechZoneAwayMaxZ_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.numericTechZoneAwayMinZ;
			int[] array26 = new int[4];
			array26[0] = 5;
			numericUpDown26.Increment = new decimal(array26);
			this.numericTechZoneAwayMinZ.Location = new global::System.Drawing.Point(38, 72);
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.numericTechZoneAwayMinZ;
			int[] array27 = new int[4];
			array27[0] = 4500;
			numericUpDown27.Maximum = new decimal(array27);
			this.numericTechZoneAwayMinZ.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneAwayMinZ.Name = "numericTechZoneAwayMinZ";
			this.numericTechZoneAwayMinZ.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneAwayMinZ.TabIndex = 14;
			this.numericTechZoneAwayMinZ.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneAwayMinZ.ValueChanged += new global::System.EventHandler(this.numericTechZoneAwayMinZ_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.numericTechZoneAwayMaxX;
			int[] array28 = new int[4];
			array28[0] = 5;
			numericUpDown28.Increment = new decimal(array28);
			this.numericTechZoneAwayMaxX.Location = new global::System.Drawing.Point(135, 41);
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.numericTechZoneAwayMaxX;
			int[] array29 = new int[4];
			array29[0] = 4500;
			numericUpDown29.Maximum = new decimal(array29);
			this.numericTechZoneAwayMaxX.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneAwayMaxX.Name = "numericTechZoneAwayMaxX";
			this.numericTechZoneAwayMaxX.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneAwayMaxX.TabIndex = 13;
			this.numericTechZoneAwayMaxX.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneAwayMaxX.ValueChanged += new global::System.EventHandler(this.numericTechZoneAwayMaxX_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.numericTechZoneAwayMinX;
			int[] array30 = new int[4];
			array30[0] = 5;
			numericUpDown30.Increment = new decimal(array30);
			this.numericTechZoneAwayMinX.Location = new global::System.Drawing.Point(38, 41);
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.numericTechZoneAwayMinX;
			int[] array31 = new int[4];
			array31[0] = 4500;
			numericUpDown31.Maximum = new decimal(array31);
			this.numericTechZoneAwayMinX.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneAwayMinX.Name = "numericTechZoneAwayMinX";
			this.numericTechZoneAwayMinX.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneAwayMinX.TabIndex = 12;
			this.numericTechZoneAwayMinX.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneAwayMinX.ValueChanged += new global::System.EventHandler(this.numericTechZoneAwayMinX_ValueChanged);
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(12, 74);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(14, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Z";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(13, 45);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(14, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "X";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(163, 17);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(26, 13);
			this.label13.TabIndex = 9;
			this.label13.Text = "max";
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(68, 17);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(23, 13);
			this.label14.TabIndex = 8;
			this.label14.Text = "min";
			this.groupBox9.Controls.Add(this.numericTechZoneHomeMaxZ);
			this.groupBox9.Controls.Add(this.numericTechZoneHomeMinZ);
			this.groupBox9.Controls.Add(this.numericTechZoneHomeMaxX);
			this.groupBox9.Controls.Add(this.numericTechZoneHomeMinX);
			this.groupBox9.Controls.Add(this.label10);
			this.groupBox9.Controls.Add(this.label9);
			this.groupBox9.Controls.Add(this.label8);
			this.groupBox9.Controls.Add(this.label7);
			this.groupBox9.Location = new global::System.Drawing.Point(9, 19);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new global::System.Drawing.Size(222, 108);
			this.groupBox9.TabIndex = 0;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Home";
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.numericTechZoneHomeMaxZ;
			int[] array32 = new int[4];
			array32[0] = 5;
			numericUpDown32.Increment = new decimal(array32);
			this.numericTechZoneHomeMaxZ.Location = new global::System.Drawing.Point(128, 71);
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.numericTechZoneHomeMaxZ;
			int[] array33 = new int[4];
			array33[0] = 4500;
			numericUpDown33.Maximum = new decimal(array33);
			this.numericTechZoneHomeMaxZ.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneHomeMaxZ.Name = "numericTechZoneHomeMaxZ";
			this.numericTechZoneHomeMaxZ.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneHomeMaxZ.TabIndex = 7;
			this.numericTechZoneHomeMaxZ.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneHomeMaxZ.ValueChanged += new global::System.EventHandler(this.numericTechZoneHomeMaxZ_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.numericTechZoneHomeMinZ;
			int[] array34 = new int[4];
			array34[0] = 5;
			numericUpDown34.Increment = new decimal(array34);
			this.numericTechZoneHomeMinZ.Location = new global::System.Drawing.Point(31, 71);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.numericTechZoneHomeMinZ;
			int[] array35 = new int[4];
			array35[0] = 4500;
			numericUpDown35.Maximum = new decimal(array35);
			this.numericTechZoneHomeMinZ.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneHomeMinZ.Name = "numericTechZoneHomeMinZ";
			this.numericTechZoneHomeMinZ.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneHomeMinZ.TabIndex = 6;
			this.numericTechZoneHomeMinZ.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneHomeMinZ.ValueChanged += new global::System.EventHandler(this.numericTechZoneHomeMinZ_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.numericTechZoneHomeMaxX;
			int[] array36 = new int[4];
			array36[0] = 5;
			numericUpDown36.Increment = new decimal(array36);
			this.numericTechZoneHomeMaxX.Location = new global::System.Drawing.Point(128, 40);
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.numericTechZoneHomeMaxX;
			int[] array37 = new int[4];
			array37[0] = 4500;
			numericUpDown37.Maximum = new decimal(array37);
			this.numericTechZoneHomeMaxX.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneHomeMaxX.Name = "numericTechZoneHomeMaxX";
			this.numericTechZoneHomeMaxX.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneHomeMaxX.TabIndex = 5;
			this.numericTechZoneHomeMaxX.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneHomeMaxX.ValueChanged += new global::System.EventHandler(this.numericTechZoneHomeMaxX_ValueChanged);
			global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.numericTechZoneHomeMinX;
			int[] array38 = new int[4];
			array38[0] = 5;
			numericUpDown38.Increment = new decimal(array38);
			this.numericTechZoneHomeMinX.Location = new global::System.Drawing.Point(31, 40);
			global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.numericTechZoneHomeMinX;
			int[] array39 = new int[4];
			array39[0] = 4500;
			numericUpDown39.Maximum = new decimal(array39);
			this.numericTechZoneHomeMinX.Minimum = new decimal(new int[] { 4500, 0, 0, int.MinValue });
			this.numericTechZoneHomeMinX.Name = "numericTechZoneHomeMinX";
			this.numericTechZoneHomeMinX.Size = new global::System.Drawing.Size(82, 20);
			this.numericTechZoneHomeMinX.TabIndex = 4;
			this.numericTechZoneHomeMinX.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTechZoneHomeMinX.ValueChanged += new global::System.EventHandler(this.numericTechZoneHomeMinX_ValueChanged);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(5, 73);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(14, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "Z";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(6, 44);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(14, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "X";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(156, 16);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(26, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "max";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(61, 16);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(23, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "min";
			this.pageStadiumPreview.Controls.Add(this.groupEnvironment);
			this.pageStadiumPreview.Location = new global::System.Drawing.Point(4, 22);
			this.pageStadiumPreview.Name = "pageStadiumPreview";
			this.pageStadiumPreview.Size = new global::System.Drawing.Size(1349, 781);
			this.pageStadiumPreview.TabIndex = 2;
			this.pageStadiumPreview.Text = "Preview";
			this.pageStadiumPreview.UseVisualStyleBackColor = true;
			this.groupEnvironment.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupEnvironment.Controls.Add(this.groupBox4);
			this.groupEnvironment.Controls.Add(this.groupBox2);
			this.groupEnvironment.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupEnvironment.Location = new global::System.Drawing.Point(0, 0);
			this.groupEnvironment.Name = "groupEnvironment";
			this.groupEnvironment.Size = new global::System.Drawing.Size(1349, 781);
			this.groupEnvironment.TabIndex = 104;
			this.groupEnvironment.TabStop = false;
			this.groupBox4.Controls.Add(this.viewer2DPreviewLarge);
			this.groupBox4.Controls.Add(this.viewer2DPreview);
			this.groupBox4.Location = new global::System.Drawing.Point(6, 69);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(1039, 595);
			this.groupBox4.TabIndex = 107;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Preview";
			this.viewer2DPreviewLarge.AutoTransparency = false;
			this.viewer2DPreviewLarge.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPreviewLarge.ButtonStripVisible = false;
			this.viewer2DPreviewLarge.CurrentBitmap = null;
			this.viewer2DPreviewLarge.ExtendedFormat = false;
			this.viewer2DPreviewLarge.FullSizeButton = false;
			this.viewer2DPreviewLarge.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPreviewLarge.ImageSize = new global::System.Drawing.Size(1024, 512);
			this.viewer2DPreviewLarge.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DPreviewLarge.Location = new global::System.Drawing.Point(2, 282);
			this.viewer2DPreviewLarge.Name = "viewer2DPreviewLarge";
			this.viewer2DPreviewLarge.RemoveButton = false;
			this.viewer2DPreviewLarge.ShowButton = false;
			this.viewer2DPreviewLarge.ShowButtonChecked = true;
			this.viewer2DPreviewLarge.Size = new global::System.Drawing.Size(1024, 300);
			this.viewer2DPreviewLarge.TabIndex = 106;
			this.viewer2DPreview.AutoTransparency = false;
			this.viewer2DPreview.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPreview.ButtonStripVisible = false;
			this.viewer2DPreview.CurrentBitmap = null;
			this.viewer2DPreview.ExtendedFormat = false;
			this.viewer2DPreview.FullSizeButton = false;
			this.viewer2DPreview.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPreview.ImageSize = new global::System.Drawing.Size(1024, 256);
			this.viewer2DPreview.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DPreview.Location = new global::System.Drawing.Point(2, 16);
			this.viewer2DPreview.Name = "viewer2DPreview";
			this.viewer2DPreview.RemoveButton = false;
			this.viewer2DPreview.ShowButton = false;
			this.viewer2DPreview.ShowButtonChecked = true;
			this.viewer2DPreview.Size = new global::System.Drawing.Size(605, 260);
			this.viewer2DPreview.TabIndex = 105;
			this.groupBox2.Controls.Add(this.radioPreviewSunset);
			this.groupBox2.Controls.Add(this.radioPreviewOvercast);
			this.groupBox2.Controls.Add(this.radioPreviewClearDay);
			this.groupBox2.Controls.Add(this.radioPreviewNight);
			this.groupBox2.Location = new global::System.Drawing.Point(8, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(607, 50);
			this.groupBox2.TabIndex = 106;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Time";
			this.radioPreviewClearDay.AutoSize = true;
			this.radioPreviewClearDay.Checked = true;
			this.radioPreviewClearDay.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPreviewClearDay.Location = new global::System.Drawing.Point(16, 19);
			this.radioPreviewClearDay.Name = "radioPreviewClearDay";
			this.radioPreviewClearDay.Size = new global::System.Drawing.Size(44, 17);
			this.radioPreviewClearDay.TabIndex = 100;
			this.radioPreviewClearDay.TabStop = true;
			this.radioPreviewClearDay.Text = "Day";
			this.radioPreviewClearDay.UseVisualStyleBackColor = true;
			this.radioPreviewClearDay.CheckedChanged += new global::System.EventHandler(this.radioPreviewClearDay_CheckedChanged);
			this.radioPreviewNight.AutoSize = true;
			this.radioPreviewNight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPreviewNight.Location = new global::System.Drawing.Point(92, 19);
			this.radioPreviewNight.Name = "radioPreviewNight";
			this.radioPreviewNight.Size = new global::System.Drawing.Size(50, 17);
			this.radioPreviewNight.TabIndex = 101;
			this.radioPreviewNight.Text = "Night";
			this.radioPreviewNight.UseVisualStyleBackColor = true;
			this.radioPreviewNight.CheckedChanged += new global::System.EventHandler(this.radioPreviewlNight_CheckedChanged);
			this.pageStadiumModel.Controls.Add(this.flowLayoutPanel2);
			this.pageStadiumModel.Location = new global::System.Drawing.Point(4, 22);
			this.pageStadiumModel.Name = "pageStadiumModel";
			this.pageStadiumModel.Padding = new global::System.Windows.Forms.Padding(3);
			this.pageStadiumModel.Size = new global::System.Drawing.Size(1349, 781);
			this.pageStadiumModel.TabIndex = 1;
			this.pageStadiumModel.Text = "Model";
			this.pageStadiumModel.UseVisualStyleBackColor = true;
			this.flowLayoutPanel2.AutoScroll = true;
			this.flowLayoutPanel2.BackColor = global::System.Drawing.SystemColors.Control;
			this.flowLayoutPanel2.Controls.Add(this.groupBox7);
			this.flowLayoutPanel2.Controls.Add(this.multiViewer2DTextures);
			this.flowLayoutPanel2.Controls.Add(this.groupLights);
			this.flowLayoutPanel2.Controls.Add(this.groupBox5);
			this.flowLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new global::System.Drawing.Point(3, 3);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new global::System.Drawing.Size(1343, 775);
			this.flowLayoutPanel2.TabIndex = 104;
			this.groupBox7.Controls.Add(this.radioModelClearDay);
			this.groupBox7.Controls.Add(this.radioModelNight);
			this.groupBox7.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(512, 50);
			this.groupBox7.TabIndex = 110;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Time";
			this.radioModelClearDay.AutoSize = true;
			this.radioModelClearDay.Checked = true;
			this.radioModelClearDay.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioModelClearDay.Location = new global::System.Drawing.Point(16, 19);
			this.radioModelClearDay.Name = "radioModelClearDay";
			this.radioModelClearDay.Size = new global::System.Drawing.Size(44, 17);
			this.radioModelClearDay.TabIndex = 100;
			this.radioModelClearDay.TabStop = true;
			this.radioModelClearDay.Text = "Day";
			this.radioModelClearDay.UseVisualStyleBackColor = true;
			this.radioModelClearDay.CheckedChanged += new global::System.EventHandler(this.radioModelClearDay_CheckedChanged);
			this.radioModelNight.AutoSize = true;
			this.radioModelNight.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioModelNight.Location = new global::System.Drawing.Point(92, 19);
			this.radioModelNight.Name = "radioModelNight";
			this.radioModelNight.Size = new global::System.Drawing.Size(50, 17);
			this.radioModelNight.TabIndex = 101;
			this.radioModelNight.Text = "Night";
			this.radioModelNight.UseVisualStyleBackColor = true;
			this.radioModelNight.CheckedChanged += new global::System.EventHandler(this.radioModelNight_CheckedChanged);
			this.multiViewer2DTextures.AutoTransparency = false;
			this.multiViewer2DTextures.BackColor = global::System.Drawing.SystemColors.Control;
			this.multiViewer2DTextures.Bitmaps = null;
			this.multiViewer2DTextures.CheckBitmapSize = false;
			this.multiViewer2DTextures.FixedSize = false;
			this.multiViewer2DTextures.FullSizeButton = false;
			this.multiViewer2DTextures.LabelText = "Image n.";
			this.multiViewer2DTextures.Location = new global::System.Drawing.Point(3, 59);
			this.multiViewer2DTextures.Name = "multiViewer2DTextures";
			this.multiViewer2DTextures.ShowDeleteButton = false;
			this.multiViewer2DTextures.Size = new global::System.Drawing.Size(512, 552);
			this.multiViewer2DTextures.TabIndex = 104;
			this.groupLights.Controls.Add(this.comboStadiumLights);
			this.groupLights.Controls.Add(this.buttonCopyCrowd);
			this.groupLights.Controls.Add(this.label3);
			this.groupLights.Location = new global::System.Drawing.Point(3, 617);
			this.groupLights.Name = "groupLights";
			this.groupLights.Size = new global::System.Drawing.Size(289, 121);
			this.groupLights.TabIndex = 111;
			this.groupLights.TabStop = false;
			this.groupLights.Text = "Crowd, Glares and Radiosity";
			this.comboStadiumLights.DataSource = this.stadiumListBindingSource;
			this.comboStadiumLights.FormattingEnabled = true;
			this.comboStadiumLights.Location = new global::System.Drawing.Point(17, 49);
			this.comboStadiumLights.Name = "comboStadiumLights";
			this.comboStadiumLights.Size = new global::System.Drawing.Size(247, 21);
			this.comboStadiumLights.TabIndex = 2;
			this.comboStadiumLights.SelectedIndexChanged += new global::System.EventHandler(this.comboStadiumLights_SelectedIndexChanged);
			this.stadiumListBindingSource.DataSource = typeof(global::FifaLibrary.StadiumList);
			this.buttonCopyCrowd.Enabled = false;
			this.buttonCopyCrowd.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCopyCrowd.Image");
			this.buttonCopyCrowd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonCopyCrowd.Location = new global::System.Drawing.Point(17, 76);
			this.buttonCopyCrowd.Name = "buttonCopyCrowd";
			this.buttonCopyCrowd.Size = new global::System.Drawing.Size(247, 25);
			this.buttonCopyCrowd.TabIndex = 102;
			this.buttonCopyCrowd.Text = "Copy Files";
			this.buttonCopyCrowd.UseVisualStyleBackColor = true;
			this.buttonCopyCrowd.Click += new global::System.EventHandler(this.buttonCopyCrowd_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(62, 28);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(146, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Select a stadium to copy from";
			this.groupBox5.Controls.Add(this.multiViewer2DCoverMap);
			this.groupBox5.Location = new global::System.Drawing.Point(521, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(312, 604);
			this.groupBox5.TabIndex = 109;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Shadow Map";
			this.groupBox5.Visible = false;
			this.multiViewer2DCoverMap.AutoTransparency = false;
			this.multiViewer2DCoverMap.Bitmaps = null;
			this.multiViewer2DCoverMap.CheckBitmapSize = false;
			this.multiViewer2DCoverMap.FixedSize = false;
			this.multiViewer2DCoverMap.FullSizeButton = false;
			this.multiViewer2DCoverMap.LabelText = "Image n.";
			this.multiViewer2DCoverMap.Location = new global::System.Drawing.Point(6, 19);
			this.multiViewer2DCoverMap.Name = "multiViewer2DCoverMap";
			this.multiViewer2DCoverMap.ShowDeleteButton = false;
			this.multiViewer2DCoverMap.Size = new global::System.Drawing.Size(301, 346);
			this.multiViewer2DCoverMap.TabIndex = 108;
			this.multiViewer2DCoverMap.Visible = false;
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = true;
			this.pickUpControl.CreateButtonEnabled = false;
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
			this.pickUpControl.Size = new global::System.Drawing.Size(1357, 25);
			this.pickUpControl.TabIndex = 0;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			this.radioPreviewOvercast.AutoSize = true;
			this.radioPreviewOvercast.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPreviewOvercast.Location = new global::System.Drawing.Point(173, 19);
			this.radioPreviewOvercast.Name = "radioPreviewOvercast";
			this.radioPreviewOvercast.Size = new global::System.Drawing.Size(90, 17);
			this.radioPreviewOvercast.TabIndex = 102;
			this.radioPreviewOvercast.Text = "Overcast Day";
			this.radioPreviewOvercast.UseVisualStyleBackColor = true;
			this.radioPreviewOvercast.CheckedChanged += new global::System.EventHandler(this.radioPreviewOvercast_CheckedChanged);
			this.radioPreviewSunset.AutoSize = true;
			this.radioPreviewSunset.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioPreviewSunset.Location = new global::System.Drawing.Point(283, 19);
			this.radioPreviewSunset.Name = "radioPreviewSunset";
			this.radioPreviewSunset.Size = new global::System.Drawing.Size(58, 17);
			this.radioPreviewSunset.TabIndex = 103;
			this.radioPreviewSunset.Text = "Sunset";
			this.radioPreviewSunset.UseVisualStyleBackColor = true;
			this.radioPreviewSunset.CheckedChanged += new global::System.EventHandler(this.radioPreviewSunset_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.tabEsitStadium);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "StadiumForm";
			this.Text = "StadiumForm";
			base.Load += new global::System.EventHandler(this.StadiumForm_Load);
			this.tabEsitStadium.ResumeLayout(false);
			this.pageStadiumGeneral.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCrowdColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericStadiumId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureHomeTeam).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericYearBuilt).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCapacity).EndInit();
			this.groupMowingPattern.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericMowing).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNet).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupCamera.ResumeLayout(false);
			this.groupCamera.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCameraZoom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCameraHeight).EndInit();
			this.groupAdboards.ResumeLayout(false);
			this.groupAdboards.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericAdboardType).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericSideLineDistance).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericEndLineDistance).EndInit();
			this.groupTimeAndWeather.ResumeLayout(false);
			this.groupTimeAndWeather.PerformLayout();
			this.groupPolice.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMaxZ).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMinZ).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMaxX).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneAwayMinX).EndInit();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMaxZ).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMinZ).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMaxX).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTechZoneHomeMinX).EndInit();
			this.pageStadiumPreview.ResumeLayout(false);
			this.groupEnvironment.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.pageStadiumModel.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupLights.ResumeLayout(false);
			this.groupLights.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.stadiumListBindingSource).EndInit();
			this.groupBox5.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000612 RID: 1554
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000613 RID: 1555
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x04000614 RID: 1556
		private global::System.Windows.Forms.TabControl tabEsitStadium;

		// Token: 0x04000615 RID: 1557
		private global::System.Windows.Forms.TabPage pageStadiumGeneral;

		// Token: 0x04000616 RID: 1558
		private global::System.Windows.Forms.TabPage pageStadiumModel;

		// Token: 0x04000617 RID: 1559
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000618 RID: 1560
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000619 RID: 1561
		private global::System.Windows.Forms.Button buttonGetId;

		// Token: 0x0400061A RID: 1562
		private global::System.Windows.Forms.NumericUpDown numericStadiumId;

		// Token: 0x0400061B RID: 1563
		private global::System.Windows.Forms.ComboBox comboHomeTeam;

		// Token: 0x0400061C RID: 1564
		private global::System.Windows.Forms.TextBox textDatabaseStadiumName;

		// Token: 0x0400061D RID: 1565
		private global::System.Windows.Forms.PictureBox pictureHomeTeam;

		// Token: 0x0400061E RID: 1566
		private global::System.Windows.Forms.Label labelDatabaseStadiumName;

		// Token: 0x0400061F RID: 1567
		private global::System.Windows.Forms.TextBox textLocalStadiumName;

		// Token: 0x04000620 RID: 1568
		private global::System.Windows.Forms.Label labelLocalStadiumName;

		// Token: 0x04000621 RID: 1569
		private global::System.Windows.Forms.Label labelStadiumId;

		// Token: 0x04000622 RID: 1570
		private global::System.Windows.Forms.DomainUpDown domainStadiumType;

		// Token: 0x04000623 RID: 1571
		private global::System.Windows.Forms.NumericUpDown numericYearBuilt;

		// Token: 0x04000624 RID: 1572
		private global::System.Windows.Forms.NumericUpDown numericCapacity;

		// Token: 0x04000625 RID: 1573
		private global::System.Windows.Forms.Label labelCapacity;

		// Token: 0x04000626 RID: 1574
		private global::System.Windows.Forms.Label labelYearBuilt;

		// Token: 0x04000627 RID: 1575
		private global::System.Windows.Forms.Label labelStadiumType;

		// Token: 0x04000628 RID: 1576
		private global::System.Windows.Forms.NumericUpDown numericCrowdColor;

		// Token: 0x04000629 RID: 1577
		private global::System.Windows.Forms.Label labelCrowdColor;

		// Token: 0x0400062A RID: 1578
		private global::System.Windows.Forms.ComboBox comboCountry;

		// Token: 0x0400062B RID: 1579
		private global::System.Windows.Forms.Label labelCountry;

		// Token: 0x0400062C RID: 1580
		private global::System.Windows.Forms.CheckBox checkOrientation;

		// Token: 0x0400062D RID: 1581
		private global::System.Windows.Forms.GroupBox groupMowingPattern;

		// Token: 0x0400062E RID: 1582
		public global::System.Windows.Forms.NumericUpDown numericMowing;

		// Token: 0x0400062F RID: 1583
		private global::FifaControls.Viewer2D viewer2DMowing;

		// Token: 0x04000630 RID: 1584
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000631 RID: 1585
		private global::FifaControls.Viewer2D viewer2DNet;

		// Token: 0x04000632 RID: 1586
		public global::System.Windows.Forms.NumericUpDown numericNet;

		// Token: 0x04000633 RID: 1587
		private global::System.Windows.Forms.CheckBox checkDeepNet;

		// Token: 0x04000634 RID: 1588
		private global::System.Windows.Forms.GroupBox groupAdboards;

		// Token: 0x04000635 RID: 1589
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000636 RID: 1590
		private global::System.Windows.Forms.Label labelAdboardEndLine;

		// Token: 0x04000637 RID: 1591
		private global::System.Windows.Forms.NumericUpDown numericSideLineDistance;

		// Token: 0x04000638 RID: 1592
		private global::System.Windows.Forms.NumericUpDown numericEndLineDistance;

		// Token: 0x04000639 RID: 1593
		private global::System.Windows.Forms.GroupBox groupTimeAndWeather;

		// Token: 0x0400063A RID: 1594
		private global::System.Windows.Forms.CheckBox checkSunnyDay;

		// Token: 0x0400063B RID: 1595
		private global::System.Windows.Forms.ComboBox comboDayWeather;

		// Token: 0x0400063C RID: 1596
		private global::System.Windows.Forms.CheckBox checkNight;

		// Token: 0x0400063D RID: 1597
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400063E RID: 1598
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

		// Token: 0x0400063F RID: 1599
		private global::FifaControls.MultiViewer2D multiViewer2DTextures;

		// Token: 0x04000640 RID: 1600
		private global::FifaControls.MultiViewer2D multiViewer2DCoverMap;

		// Token: 0x04000641 RID: 1601
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000642 RID: 1602
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000643 RID: 1603
		private global::System.Windows.Forms.GroupBox groupPolice;

		// Token: 0x04000644 RID: 1604
		private global::FifaControls.Viewer2D viewer2DPolice;

		// Token: 0x04000645 RID: 1605
		private global::System.Windows.Forms.ComboBox comboPolice;

		// Token: 0x04000646 RID: 1606
		private global::System.Windows.Forms.Button buttonCopyCrowd;

		// Token: 0x04000647 RID: 1607
		private global::System.Windows.Forms.BindingSource stadiumListBindingSource;

		// Token: 0x04000648 RID: 1608
		private global::System.Windows.Forms.GroupBox groupLights;

		// Token: 0x04000649 RID: 1609
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400064A RID: 1610
		private global::System.Windows.Forms.ComboBox comboStadiumLights;

		// Token: 0x0400064B RID: 1611
		private global::System.Windows.Forms.TabPage pageStadiumPreview;

		// Token: 0x0400064C RID: 1612
		private global::System.Windows.Forms.GroupBox groupEnvironment;

		// Token: 0x0400064D RID: 1613
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400064E RID: 1614
		private global::FifaControls.Viewer2D viewer2DPreviewLarge;

		// Token: 0x0400064F RID: 1615
		private global::FifaControls.Viewer2D viewer2DPreview;

		// Token: 0x04000650 RID: 1616
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000651 RID: 1617
		private global::System.Windows.Forms.RadioButton radioPreviewClearDay;

		// Token: 0x04000652 RID: 1618
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000653 RID: 1619
		private global::System.Windows.Forms.RadioButton radioModelClearDay;

		// Token: 0x04000654 RID: 1620
		private global::System.Windows.Forms.GroupBox groupCamera;

		// Token: 0x04000655 RID: 1621
		public global::System.Windows.Forms.NumericUpDown numericCameraZoom;

		// Token: 0x04000656 RID: 1622
		public global::System.Windows.Forms.NumericUpDown numericCameraHeight;

		// Token: 0x04000657 RID: 1623
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000658 RID: 1624
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000659 RID: 1625
		public global::System.Windows.Forms.NumericUpDown numericAdboardType;

		// Token: 0x0400065A RID: 1626
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400065B RID: 1627
		private global::System.Windows.Forms.RadioButton radioPreviewNight;

		// Token: 0x0400065C RID: 1628
		private global::System.Windows.Forms.RadioButton radioModelNight;

		// Token: 0x0400065D RID: 1629
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x0400065E RID: 1630
		private global::System.Windows.Forms.GroupBox groupBox10;

		// Token: 0x0400065F RID: 1631
		private global::System.Windows.Forms.NumericUpDown numericTechZoneAwayMaxZ;

		// Token: 0x04000660 RID: 1632
		private global::System.Windows.Forms.NumericUpDown numericTechZoneAwayMinZ;

		// Token: 0x04000661 RID: 1633
		private global::System.Windows.Forms.NumericUpDown numericTechZoneAwayMaxX;

		// Token: 0x04000662 RID: 1634
		private global::System.Windows.Forms.NumericUpDown numericTechZoneAwayMinX;

		// Token: 0x04000663 RID: 1635
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000664 RID: 1636
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000665 RID: 1637
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000666 RID: 1638
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000667 RID: 1639
		private global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x04000668 RID: 1640
		private global::System.Windows.Forms.NumericUpDown numericTechZoneHomeMaxZ;

		// Token: 0x04000669 RID: 1641
		private global::System.Windows.Forms.NumericUpDown numericTechZoneHomeMinZ;

		// Token: 0x0400066A RID: 1642
		private global::System.Windows.Forms.NumericUpDown numericTechZoneHomeMaxX;

		// Token: 0x0400066B RID: 1643
		private global::System.Windows.Forms.NumericUpDown numericTechZoneHomeMinX;

		// Token: 0x0400066C RID: 1644
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400066D RID: 1645
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400066E RID: 1646
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400066F RID: 1647
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000670 RID: 1648
		private global::System.Windows.Forms.CheckBox checkIsLicensed;

		// Token: 0x04000671 RID: 1649
		private global::System.Windows.Forms.RadioButton radioPreviewSunset;

		// Token: 0x04000672 RID: 1650
		private global::System.Windows.Forms.RadioButton radioPreviewOvercast;
	}
}
