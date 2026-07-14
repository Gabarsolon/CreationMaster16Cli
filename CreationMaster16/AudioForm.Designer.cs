namespace CreationMaster
{
	// Token: 0x02000003 RID: 3
	public partial class AudioForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000042B0 File Offset: 0x000024B0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000042D0 File Offset: 0x000024D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.AudioForm));
			this.groupAudio = new global::System.Windows.Forms.GroupBox();
			this.textAudioName = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonDeleteSound = new global::System.Windows.Forms.Button();
			this.buttonSetSound = new global::System.Windows.Forms.Button();
			this.textSurnameSoundId = new global::System.Windows.Forms.TextBox();
			this.buttonSearchPlayerId = new global::System.Windows.Forms.Button();
			this.textPlayerId = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonSearchSurnameId = new global::System.Windows.Forms.Button();
			this.textKnownAs = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.groupNameDictionary = new global::System.Windows.Forms.GroupBox();
			this.numericNameDictionary = new global::System.Windows.Forms.NumericUpDown();
			this.listViewNameDictionary = new global::System.Windows.Forms.ListView();
			this.columnNameId = new global::System.Windows.Forms.ColumnHeader();
			this.columnSurname = new global::System.Windows.Forms.ColumnHeader();
			this.toolStripNameDictionary = new global::System.Windows.Forms.ToolStrip();
			this.textNameDictionary = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonAddName = new global::System.Windows.Forms.ToolStripButton();
			this.buttonReplaceName = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRemoveName = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSearchnameDictionary = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.textSearchNameDictionary = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonFindNameExact = new global::System.Windows.Forms.ToolStripButton();
			this.buttonFindNameStart = new global::System.Windows.Forms.ToolStripButton();
			this.buttonFindNameAny = new global::System.Windows.Forms.ToolStripButton();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.groupPlayerInfo = new global::System.Windows.Forms.GroupBox();
			this.labelCommonName = new global::System.Windows.Forms.Label();
			this.textCommonName = new global::System.Windows.Forms.TextBox();
			this.viewer2DPhoto = new global::FifaControls.Viewer2D();
			this.textSurname = new global::System.Windows.Forms.TextBox();
			this.textFirstName = new global::System.Windows.Forms.TextBox();
			this.labelFirstName = new global::System.Windows.Forms.Label();
			this.labelSurame = new global::System.Windows.Forms.Label();
			this.groupAudio.SuspendLayout();
			this.groupNameDictionary.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNameDictionary).BeginInit();
			this.toolStripNameDictionary.SuspendLayout();
			this.toolStripSearchnameDictionary.SuspendLayout();
			this.groupPlayerInfo.SuspendLayout();
			base.SuspendLayout();
			this.groupAudio.Controls.Add(this.textAudioName);
			this.groupAudio.Controls.Add(this.label3);
			this.groupAudio.Controls.Add(this.label2);
			this.groupAudio.Controls.Add(this.buttonDeleteSound);
			this.groupAudio.Controls.Add(this.buttonSetSound);
			this.groupAudio.Controls.Add(this.textSurnameSoundId);
			this.groupAudio.Controls.Add(this.buttonSearchPlayerId);
			this.groupAudio.Controls.Add(this.textPlayerId);
			this.groupAudio.Controls.Add(this.label1);
			this.groupAudio.Controls.Add(this.buttonSearchSurnameId);
			this.groupAudio.Controls.Add(this.textKnownAs);
			this.groupAudio.Controls.Add(this.label13);
			this.groupAudio.Location = new global::System.Drawing.Point(12, 40);
			this.groupAudio.Name = "groupAudio";
			this.groupAudio.Size = new global::System.Drawing.Size(302, 149);
			this.groupAudio.TabIndex = 92;
			this.groupAudio.TabStop = false;
			this.groupAudio.Text = "Player Audio";
			this.textAudioName.BackColor = global::System.Drawing.Color.White;
			this.textAudioName.Location = new global::System.Drawing.Point(88, 104);
			this.textAudioName.Name = "textAudioName";
			this.textAudioName.ReadOnly = true;
			this.textAudioName.Size = new global::System.Drawing.Size(148, 20);
			this.textAudioName.TabIndex = 110;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 107);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(65, 13);
			this.label3.TabIndex = 109;
			this.label3.Text = "Audio Name";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(55, 13);
			this.label2.TabIndex = 108;
			this.label2.Text = "Known As";
			this.buttonDeleteSound.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonDeleteSound.BackgroundImage");
			this.buttonDeleteSound.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonDeleteSound.Location = new global::System.Drawing.Point(211, 76);
			this.buttonDeleteSound.Name = "buttonDeleteSound";
			this.buttonDeleteSound.Size = new global::System.Drawing.Size(25, 23);
			this.buttonDeleteSound.TabIndex = 107;
			this.toolTip.SetToolTip(this.buttonDeleteSound, "Remove the generic audio associated to this name");
			this.buttonDeleteSound.UseVisualStyleBackColor = true;
			this.buttonDeleteSound.Click += new global::System.EventHandler(this.buttonDeleteSound_Click);
			this.buttonSetSound.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSetSound.BackgroundImage");
			this.buttonSetSound.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonSetSound.Enabled = false;
			this.buttonSetSound.Location = new global::System.Drawing.Point(242, 71);
			this.buttonSetSound.Name = "buttonSetSound";
			this.buttonSetSound.Size = new global::System.Drawing.Size(50, 59);
			this.buttonSetSound.TabIndex = 106;
			this.buttonSetSound.UseVisualStyleBackColor = true;
			this.buttonSetSound.Click += new global::System.EventHandler(this.buttonSetSound_Click);
			this.textSurnameSoundId.BackColor = global::System.Drawing.Color.White;
			this.textSurnameSoundId.Location = new global::System.Drawing.Point(88, 78);
			this.textSurnameSoundId.Name = "textSurnameSoundId";
			this.textSurnameSoundId.ReadOnly = true;
			this.textSurnameSoundId.Size = new global::System.Drawing.Size(86, 20);
			this.textSurnameSoundId.TabIndex = 105;
			this.textSurnameSoundId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.buttonSearchPlayerId.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSearchPlayerId.BackgroundImage");
			this.buttonSearchPlayerId.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonSearchPlayerId.Location = new global::System.Drawing.Point(180, 23);
			this.buttonSearchPlayerId.Name = "buttonSearchPlayerId";
			this.buttonSearchPlayerId.Size = new global::System.Drawing.Size(25, 23);
			this.buttonSearchPlayerId.TabIndex = 104;
			this.toolTip.SetToolTip(this.buttonSearchPlayerId, "Search specific audio for this player");
			this.buttonSearchPlayerId.UseVisualStyleBackColor = true;
			this.buttonSearchPlayerId.Click += new global::System.EventHandler(this.buttonSearchPlayerId_Click);
			this.textPlayerId.BackColor = global::System.Drawing.Color.White;
			this.textPlayerId.Location = new global::System.Drawing.Point(88, 25);
			this.textPlayerId.Name = "textPlayerId";
			this.textPlayerId.ReadOnly = true;
			this.textPlayerId.Size = new global::System.Drawing.Size(86, 20);
			this.textPlayerId.TabIndex = 103;
			this.textPlayerId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(48, 13);
			this.label1.TabIndex = 102;
			this.label1.Text = "Player Id";
			this.buttonSearchSurnameId.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSearchSurnameId.BackgroundImage");
			this.buttonSearchSurnameId.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.buttonSearchSurnameId.Location = new global::System.Drawing.Point(180, 76);
			this.buttonSearchSurnameId.Name = "buttonSearchSurnameId";
			this.buttonSearchSurnameId.Size = new global::System.Drawing.Size(25, 23);
			this.buttonSearchSurnameId.TabIndex = 101;
			this.toolTip.SetToolTip(this.buttonSearchSurnameId, "Search generic audio for this name");
			this.buttonSearchSurnameId.UseVisualStyleBackColor = true;
			this.buttonSearchSurnameId.Click += new global::System.EventHandler(this.buttonSearchSurnameId_Click);
			this.textKnownAs.BackColor = global::System.Drawing.Color.White;
			this.textKnownAs.Location = new global::System.Drawing.Point(88, 52);
			this.textKnownAs.Name = "textKnownAs";
			this.textKnownAs.ReadOnly = true;
			this.textKnownAs.Size = new global::System.Drawing.Size(148, 20);
			this.textKnownAs.TabIndex = 2;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(6, 81);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(46, 13);
			this.label13.TabIndex = 1;
			this.label13.Text = "Audio Id";
			this.groupNameDictionary.Controls.Add(this.numericNameDictionary);
			this.groupNameDictionary.Controls.Add(this.listViewNameDictionary);
			this.groupNameDictionary.Controls.Add(this.toolStripNameDictionary);
			this.groupNameDictionary.Controls.Add(this.toolStripSearchnameDictionary);
			this.groupNameDictionary.Location = new global::System.Drawing.Point(320, 40);
			this.groupNameDictionary.Name = "groupNameDictionary";
			this.groupNameDictionary.Size = new global::System.Drawing.Size(364, 736);
			this.groupNameDictionary.TabIndex = 3;
			this.groupNameDictionary.TabStop = false;
			this.groupNameDictionary.Text = "Names Dictionary";
			this.numericNameDictionary.Location = new global::System.Drawing.Point(6, 44);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericNameDictionary;
			int[] array = new int[4];
			array[0] = 1000000;
			numericUpDown.Maximum = new decimal(array);
			this.numericNameDictionary.Name = "numericNameDictionary";
			this.numericNameDictionary.Size = new global::System.Drawing.Size(80, 20);
			this.numericNameDictionary.TabIndex = 126;
			this.numericNameDictionary.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericNameDictionary.ThousandsSeparator = true;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericNameDictionary;
			int[] array2 = new int[4];
			array2[0] = 900000;
			numericUpDown2.Value = new decimal(array2);
			this.numericNameDictionary.ValueChanged += new global::System.EventHandler(this.numericNameDictionary_ValueChanged);
			this.listViewNameDictionary.AllowDrop = true;
			this.listViewNameDictionary.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnNameId, this.columnSurname });
			this.listViewNameDictionary.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listViewNameDictionary.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewNameDictionary.FullRowSelect = true;
			this.listViewNameDictionary.GridLines = true;
			this.listViewNameDictionary.HideSelection = false;
			this.listViewNameDictionary.Location = new global::System.Drawing.Point(3, 66);
			this.listViewNameDictionary.MultiSelect = false;
			this.listViewNameDictionary.Name = "listViewNameDictionary";
			this.listViewNameDictionary.Size = new global::System.Drawing.Size(358, 667);
			this.listViewNameDictionary.TabIndex = 9;
			this.listViewNameDictionary.UseCompatibleStateImageBehavior = false;
			this.listViewNameDictionary.View = global::System.Windows.Forms.View.Details;
			this.listViewNameDictionary.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.listViewNameDictionary_ColumnClick);
			this.listViewNameDictionary.SelectedIndexChanged += new global::System.EventHandler(this.listViewNameDictionary_SelectedIndexChanged);
			this.columnNameId.Text = "N.";
			this.columnNameId.Width = 88;
			this.columnSurname.Text = "Name";
			this.columnSurname.Width = 154;
			this.toolStripNameDictionary.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripNameDictionary.BackgroundImage");
			this.toolStripNameDictionary.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripNameDictionary.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.textNameDictionary, this.toolStripSeparator7, this.buttonAddName, this.buttonReplaceName, this.buttonRemoveName });
			this.toolStripNameDictionary.Location = new global::System.Drawing.Point(3, 41);
			this.toolStripNameDictionary.Name = "toolStripNameDictionary";
			this.toolStripNameDictionary.Size = new global::System.Drawing.Size(358, 25);
			this.toolStripNameDictionary.TabIndex = 127;
			this.toolStripNameDictionary.Text = "toolStrip1";
			this.textNameDictionary.Margin = new global::System.Windows.Forms.Padding(90, 0, 1, 0);
			this.textNameDictionary.Name = "textNameDictionary";
			this.textNameDictionary.Size = new global::System.Drawing.Size(150, 25);
			this.textNameDictionary.TextChanged += new global::System.EventHandler(this.textNameDictionary_TextChanged);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(6, 25);
			this.buttonAddName.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonAddName.Enabled = false;
			this.buttonAddName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonAddName.Image");
			this.buttonAddName.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonAddName.Name = "buttonAddName";
			this.buttonAddName.Size = new global::System.Drawing.Size(23, 22);
			this.buttonAddName.Text = "Add";
			this.buttonAddName.ToolTipText = "Add to the Names Directory";
			this.buttonAddName.Click += new global::System.EventHandler(this.buttonAddName_Click);
			this.buttonReplaceName.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonReplaceName.Enabled = false;
			this.buttonReplaceName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonReplaceName.Image");
			this.buttonReplaceName.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonReplaceName.Name = "buttonReplaceName";
			this.buttonReplaceName.Size = new global::System.Drawing.Size(23, 22);
			this.buttonReplaceName.Text = "Replace";
			this.buttonReplaceName.ToolTipText = "Replace in the Names Directory";
			this.buttonReplaceName.Click += new global::System.EventHandler(this.buttonReplaceName_Click);
			this.buttonRemoveName.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemoveName.Enabled = false;
			this.buttonRemoveName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemoveName.Image");
			this.buttonRemoveName.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemoveName.Name = "buttonRemoveName";
			this.buttonRemoveName.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemoveName.Text = "Remove";
			this.buttonRemoveName.ToolTipText = "Remove from the Names Directory";
			this.buttonRemoveName.Click += new global::System.EventHandler(this.buttonRemoveName_Click);
			this.toolStripSearchnameDictionary.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripSearchnameDictionary.BackgroundImage");
			this.toolStripSearchnameDictionary.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripSearchnameDictionary.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripLabel1, this.textSearchNameDictionary, this.toolStripSeparator6, this.buttonFindNameExact, this.buttonFindNameStart, this.buttonFindNameAny });
			this.toolStripSearchnameDictionary.Location = new global::System.Drawing.Point(3, 16);
			this.toolStripSearchnameDictionary.Name = "toolStripSearchnameDictionary";
			this.toolStripSearchnameDictionary.Size = new global::System.Drawing.Size(358, 25);
			this.toolStripSearchnameDictionary.TabIndex = 125;
			this.toolStripLabel1.AutoSize = false;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new global::System.Drawing.Size(90, 22);
			this.toolStripLabel1.Text = "Search";
			this.textSearchNameDictionary.Margin = new global::System.Windows.Forms.Padding(0, 0, 1, 0);
			this.textSearchNameDictionary.Name = "textSearchNameDictionary";
			this.textSearchNameDictionary.Size = new global::System.Drawing.Size(150, 25);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(6, 25);
			this.buttonFindNameExact.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFindNameExact.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFindNameExact.Image");
			this.buttonFindNameExact.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFindNameExact.Name = "buttonFindNameExact";
			this.buttonFindNameExact.Size = new global::System.Drawing.Size(23, 22);
			this.buttonFindNameExact.Text = "Search Exactly";
			this.buttonFindNameExact.Click += new global::System.EventHandler(this.buttonFindNameExact_Click);
			this.buttonFindNameStart.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFindNameStart.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFindNameStart.Image");
			this.buttonFindNameStart.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFindNameStart.Name = "buttonFindNameStart";
			this.buttonFindNameStart.Size = new global::System.Drawing.Size(23, 22);
			this.buttonFindNameStart.Text = "Search if starting with";
			this.buttonFindNameStart.Click += new global::System.EventHandler(this.buttonFindNameStart_Click);
			this.buttonFindNameAny.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonFindNameAny.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFindNameAny.Image");
			this.buttonFindNameAny.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFindNameAny.Name = "buttonFindNameAny";
			this.buttonFindNameAny.Size = new global::System.Drawing.Size(23, 22);
			this.buttonFindNameAny.Text = "Search if containing";
			this.buttonFindNameAny.Click += new global::System.EventHandler(this.buttonFindNameAny_Click);
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = false;
			this.pickUpControl.CreateButtonEnabled = false;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by Team", "by Country", "Free Agents" };
			this.pickUpControl.FilterEnabled = true;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = true;
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = false;
			this.pickUpControl.SearchEnabled = true;
			this.pickUpControl.Size = new global::System.Drawing.Size(1165, 25);
			this.pickUpControl.TabIndex = 1;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			this.groupPlayerInfo.Controls.Add(this.labelCommonName);
			this.groupPlayerInfo.Controls.Add(this.textCommonName);
			this.groupPlayerInfo.Controls.Add(this.viewer2DPhoto);
			this.groupPlayerInfo.Controls.Add(this.textSurname);
			this.groupPlayerInfo.Controls.Add(this.textFirstName);
			this.groupPlayerInfo.Controls.Add(this.labelFirstName);
			this.groupPlayerInfo.Controls.Add(this.labelSurame);
			this.groupPlayerInfo.Location = new global::System.Drawing.Point(12, 195);
			this.groupPlayerInfo.Name = "groupPlayerInfo";
			this.groupPlayerInfo.Size = new global::System.Drawing.Size(292, 160);
			this.groupPlayerInfo.TabIndex = 93;
			this.groupPlayerInfo.TabStop = false;
			this.labelCommonName.AutoSize = true;
			this.labelCommonName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCommonName.Location = new global::System.Drawing.Point(148, 106);
			this.labelCommonName.Name = "labelCommonName";
			this.labelCommonName.Size = new global::System.Drawing.Size(79, 13);
			this.labelCommonName.TabIndex = 168;
			this.labelCommonName.Text = "Common Name";
			this.labelCommonName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textCommonName.BackColor = global::System.Drawing.Color.White;
			this.textCommonName.Location = new global::System.Drawing.Point(147, 122);
			this.textCommonName.Name = "textCommonName";
			this.textCommonName.ReadOnly = true;
			this.textCommonName.Size = new global::System.Drawing.Size(131, 20);
			this.textCommonName.TabIndex = 166;
			this.textCommonName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.viewer2DPhoto.AutoTransparency = false;
			this.viewer2DPhoto.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DPhoto.ButtonStripVisible = false;
			this.viewer2DPhoto.CurrentBitmap = null;
			this.viewer2DPhoto.ExtendedFormat = false;
			this.viewer2DPhoto.FullSizeButton = false;
			this.viewer2DPhoto.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DPhoto.ImageSize = new global::System.Drawing.Size(128, 128);
			this.viewer2DPhoto.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.MiniFace;
			this.viewer2DPhoto.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DPhoto.Name = "viewer2DPhoto";
			this.viewer2DPhoto.RemoveButton = false;
			this.viewer2DPhoto.ShowButton = false;
			this.viewer2DPhoto.ShowButtonChecked = true;
			this.viewer2DPhoto.Size = new global::System.Drawing.Size(128, 128);
			this.viewer2DPhoto.TabIndex = 167;
			this.viewer2DPhoto.TabStop = false;
			this.textSurname.BackColor = global::System.Drawing.Color.White;
			this.textSurname.Location = new global::System.Drawing.Point(147, 83);
			this.textSurname.Name = "textSurname";
			this.textSurname.ReadOnly = true;
			this.textSurname.Size = new global::System.Drawing.Size(131, 20);
			this.textSurname.TabIndex = 163;
			this.textSurname.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.textFirstName.BackColor = global::System.Drawing.Color.White;
			this.textFirstName.Location = new global::System.Drawing.Point(147, 44);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.ReadOnly = true;
			this.textFirstName.Size = new global::System.Drawing.Size(131, 20);
			this.textFirstName.TabIndex = 162;
			this.textFirstName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelFirstName.Location = new global::System.Drawing.Point(148, 28);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new global::System.Drawing.Size(57, 13);
			this.labelFirstName.TabIndex = 164;
			this.labelFirstName.Text = "First Name";
			this.labelFirstName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.labelSurame.AutoSize = true;
			this.labelSurame.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelSurame.Location = new global::System.Drawing.Point(148, 67);
			this.labelSurame.Name = "labelSurame";
			this.labelSurame.Size = new global::System.Drawing.Size(58, 13);
			this.labelSurame.TabIndex = 165;
			this.labelSurame.Text = "Last Name";
			this.labelSurame.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1165, 798);
			base.Controls.Add(this.groupPlayerInfo);
			base.Controls.Add(this.groupNameDictionary);
			base.Controls.Add(this.groupAudio);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "AudioForm";
			this.Text = "aUDIOForm";
			base.Load += new global::System.EventHandler(this.AudioForm_Load);
			this.groupAudio.ResumeLayout(false);
			this.groupAudio.PerformLayout();
			this.groupNameDictionary.ResumeLayout(false);
			this.groupNameDictionary.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNameDictionary).EndInit();
			this.toolStripNameDictionary.ResumeLayout(false);
			this.toolStripNameDictionary.PerformLayout();
			this.toolStripSearchnameDictionary.ResumeLayout(false);
			this.toolStripSearchnameDictionary.PerformLayout();
			this.groupPlayerInfo.ResumeLayout(false);
			this.groupPlayerInfo.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000025 RID: 37
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000026 RID: 38
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.GroupBox groupAudio;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.GroupBox groupNameDictionary;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ListView listViewNameDictionary;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ColumnHeader columnNameId;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ColumnHeader columnSurname;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.NumericUpDown numericNameDictionary;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStrip toolStripSearchnameDictionary;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripButton buttonFindNameExact;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripButton buttonFindNameStart;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripButton buttonFindNameAny;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStrip toolStripNameDictionary;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000034 RID: 52
		public global::System.Windows.Forms.ToolStripButton buttonAddName;

		// Token: 0x04000035 RID: 53
		public global::System.Windows.Forms.ToolStripButton buttonReplaceName;

		// Token: 0x04000036 RID: 54
		public global::System.Windows.Forms.ToolStripButton buttonRemoveName;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.TextBox textKnownAs;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ToolStripTextBox textNameDictionary;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Button buttonSearchSurnameId;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.ToolStripTextBox textSearchNameDictionary;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TextBox textPlayerId;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button buttonSearchPlayerId;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox textSurnameSoundId;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button buttonSetSound;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button buttonDeleteSound;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.GroupBox groupPlayerInfo;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label labelCommonName;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.TextBox textCommonName;

		// Token: 0x04000047 RID: 71
		private global::FifaControls.Viewer2D viewer2DPhoto;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.TextBox textSurname;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TextBox textFirstName;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label labelFirstName;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label labelSurame;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.TextBox textAudioName;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label2;
	}
}
