namespace CreationMaster
{
	// Token: 0x02000007 RID: 7
	public partial class KitForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000109E3 File Offset: 0x0000EBE3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00010A04 File Offset: 0x0000EC04
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.KitForm));
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new global::System.Windows.Forms.SplitContainer();
			this.multiViewer2DKit = new global::FifaControls.MultiViewer2D();
			this.groupPositions = new global::System.Windows.Forms.GroupBox();
			this.toolStrip3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonJerseyBadge = new global::System.Windows.Forms.ToolStripButton();
			this.buttonFrontNumber = new global::System.Windows.Forms.ToolStripButton();
			this.buttonBackName = new global::System.Windows.Forms.ToolStripButton();
			this.buttonNameCurvature = new global::System.Windows.Forms.ToolStripButton();
			this.buttonShortsNumber = new global::System.Windows.Forms.ToolStripButton();
			this.buttonShortsBadge = new global::System.Windows.Forms.ToolStripButton();
			this.buttonBackNumber = new global::System.Windows.Forms.ToolStripButton();
			this.buttonCopyPositions = new global::System.Windows.Forms.ToolStripButton();
			this.buttonPastePositions = new global::System.Windows.Forms.ToolStripButton();
			this.numericBottom = new global::System.Windows.Forms.NumericUpDown();
			this.numericTop = new global::System.Windows.Forms.NumericUpDown();
			this.numericRight = new global::System.Windows.Forms.NumericUpDown();
			this.numericLeft = new global::System.Windows.Forms.NumericUpDown();
			this.checkLink = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonExportAllKits = new global::System.Windows.Forms.Button();
			this.numericTeamId = new global::System.Windows.Forms.NumericUpDown();
			this.kitBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.labelTeamId = new global::System.Windows.Forms.Label();
			this.labelKitType = new global::System.Windows.Forms.Label();
			this.labelTeam = new global::System.Windows.Forms.Label();
			this.comboTeam = new global::System.Windows.Forms.ComboBox();
			this.teamListBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.comboKitType = new global::System.Windows.Forms.ComboBox();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new global::System.Windows.Forms.SplitContainer();
			this.group3D = new global::System.Windows.Forms.GroupBox();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.toolNear3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonRefresh3D = new global::System.Windows.Forms.ToolStripButton();
			this.buttonShowNumbers3D = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonCamera = new global::System.Windows.Forms.ToolStripButton();
			this.multiViewer2DShortsNumbers = new global::FifaControls.MultiViewer2D();
			this.pictureShortsNumberColor = new global::System.Windows.Forms.PictureBox();
			this.numericShortsNumberFont = new global::System.Windows.Forms.NumericUpDown();
			this.multiViewer2DJerseyNumbers = new global::FifaControls.MultiViewer2D();
			this.checkShortsNumber = new global::System.Windows.Forms.CheckBox();
			this.checkFrontNumber = new global::System.Windows.Forms.CheckBox();
			this.pictureJerseyNumberColor = new global::System.Windows.Forms.PictureBox();
			this.numericJerseyNumberFont = new global::System.Windows.Forms.NumericUpDown();
			this.splitContainer5 = new global::System.Windows.Forms.SplitContainer();
			this.viewer2DMinikit = new global::FifaControls.Viewer2D();
			this.flowPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.groupCollar = new global::System.Windows.Forms.GroupBox();
			this.labelCollarImage = new global::System.Windows.Forms.Label();
			this.imageListCollar = new global::System.Windows.Forms.ImageList(this.components);
			this.checkIsFitting = new global::System.Windows.Forms.CheckBox();
			this.checkHasAdvertising = new global::System.Windows.Forms.CheckBox();
			this.pictureTeamTerColor = new global::System.Windows.Forms.PictureBox();
			this.pictureTeamPrimColor = new global::System.Windows.Forms.PictureBox();
			this.pictureTeamSecColor = new global::System.Windows.Forms.PictureBox();
			this.labelCollar = new global::System.Windows.Forms.Label();
			this.numericCollar = new global::System.Windows.Forms.NumericUpDown();
			this.groupName = new global::System.Windows.Forms.GroupBox();
			this.labelFont = new global::System.Windows.Forms.Label();
			this.toolStripNameFont = new global::System.Windows.Forms.ToolStrip();
			this.buttonPreviewNameFont = new global::System.Windows.Forms.ToolStripButton();
			this.buttonImportNameFont = new global::System.Windows.Forms.ToolStripButton();
			this.buttonDeleteNameFont = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExportNameFont = new global::System.Windows.Forms.ToolStripButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.checkHasBackname = new global::System.Windows.Forms.CheckBox();
			this.numericNameFont = new global::System.Windows.Forms.NumericUpDown();
			this.labelNameFont = new global::System.Windows.Forms.Label();
			this.pictureNameColor = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboNameLayout = new global::System.Windows.Forms.ComboBox();
			this.pictureFont = new global::System.Windows.Forms.PictureBox();
			this.colorDialog = new global::System.Windows.Forms.ColorDialog();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.fontDialog = new global::System.Windows.Forms.FontDialog();
			this.processFontView = new global::System.Diagnostics.Process();
			this.fontDialog1 = new global::System.Windows.Forms.FontDialog();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.groupPositions.SuspendLayout();
			this.toolStrip3D.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBottom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTop).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRight).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeft).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamId).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.kitBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer4).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.group3D.SuspendLayout();
			this.toolNear3D.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureShortsNumberColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShortsNumberFont).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureJerseyNumberColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericJerseyNumberFont).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer5).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.flowPanel.SuspendLayout();
			this.groupCollar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamTerColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamPrimColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamSecColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCollar).BeginInit();
			this.groupName.SuspendLayout();
			this.toolStripNameFont.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNameFont).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureNameColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFont).BeginInit();
			base.SuspendLayout();
			this.splitContainer1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new global::System.Drawing.Size(1357, 807);
			this.splitContainer1.SplitterDistance = 516;
			this.splitContainer1.TabIndex = 2;
			this.splitContainer3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer3.Panel1.Controls.Add(this.multiViewer2DKit);
			this.splitContainer3.Panel1.Controls.Add(this.groupPositions);
			this.splitContainer3.Panel2.Controls.Add(this.buttonExportAllKits);
			this.splitContainer3.Panel2.Controls.Add(this.numericTeamId);
			this.splitContainer3.Panel2.Controls.Add(this.labelTeamId);
			this.splitContainer3.Panel2.Controls.Add(this.labelKitType);
			this.splitContainer3.Panel2.Controls.Add(this.labelTeam);
			this.splitContainer3.Panel2.Controls.Add(this.comboTeam);
			this.splitContainer3.Panel2.Controls.Add(this.comboKitType);
			this.splitContainer3.Size = new global::System.Drawing.Size(516, 807);
			this.splitContainer3.SplitterDistance = 682;
			this.splitContainer3.TabIndex = 0;
			this.multiViewer2DKit.AutoTransparency = false;
			this.multiViewer2DKit.Bitmaps = null;
			this.multiViewer2DKit.CheckBitmapSize = true;
			this.multiViewer2DKit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.multiViewer2DKit.FixedSize = false;
			this.multiViewer2DKit.FullSizeButton = true;
			this.multiViewer2DKit.LabelText = "Image n.";
			this.multiViewer2DKit.Location = new global::System.Drawing.Point(0, 0);
			this.multiViewer2DKit.Name = "multiViewer2DKit";
			this.multiViewer2DKit.ShowButton = true;
			this.multiViewer2DKit.ShowDeleteButton = false;
			this.multiViewer2DKit.Size = new global::System.Drawing.Size(512, 558);
			this.multiViewer2DKit.TabIndex = 0;
			this.groupPositions.Controls.Add(this.toolStrip3D);
			this.groupPositions.Controls.Add(this.numericBottom);
			this.groupPositions.Controls.Add(this.numericTop);
			this.groupPositions.Controls.Add(this.numericRight);
			this.groupPositions.Controls.Add(this.numericLeft);
			this.groupPositions.Controls.Add(this.checkLink);
			this.groupPositions.Controls.Add(this.label2);
			this.groupPositions.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.groupPositions.Location = new global::System.Drawing.Point(0, 558);
			this.groupPositions.Name = "groupPositions";
			this.groupPositions.Size = new global::System.Drawing.Size(512, 120);
			this.groupPositions.TabIndex = 3;
			this.groupPositions.TabStop = false;
			this.groupPositions.Text = "Positions";
			this.toolStrip3D.AutoSize = false;
			this.toolStrip3D.CanOverflow = false;
			this.toolStrip3D.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.toolStrip3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonJerseyBadge, this.buttonFrontNumber, this.buttonBackName, this.buttonNameCurvature, this.buttonShortsNumber, this.buttonShortsBadge, this.buttonBackNumber, this.buttonCopyPositions, this.buttonPastePositions });
			this.toolStrip3D.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip3D.Location = new global::System.Drawing.Point(3, 16);
			this.toolStrip3D.Name = "toolStrip3D";
			this.toolStrip3D.Size = new global::System.Drawing.Size(201, 101);
			this.toolStrip3D.TabIndex = 190;
			this.toolStrip3D.Text = "toolStrip1";
			this.buttonJerseyBadge.AutoToolTip = false;
			this.buttonJerseyBadge.Checked = true;
			this.buttonJerseyBadge.CheckOnClick = true;
			this.buttonJerseyBadge.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.buttonJerseyBadge.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonJerseyBadge.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonJerseyBadge.Image");
			this.buttonJerseyBadge.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonJerseyBadge.Name = "buttonJerseyBadge";
			this.buttonJerseyBadge.Size = new global::System.Drawing.Size(90, 19);
			this.buttonJerseyBadge.Text = "  Jersey Badge  ";
			this.buttonJerseyBadge.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonFrontNumber.AutoToolTip = false;
			this.buttonFrontNumber.CheckOnClick = true;
			this.buttonFrontNumber.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonFrontNumber.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonFrontNumber.Image");
			this.buttonFrontNumber.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonFrontNumber.Name = "buttonFrontNumber";
			this.buttonFrontNumber.Size = new global::System.Drawing.Size(92, 19);
			this.buttonFrontNumber.Text = " Front Number ";
			this.buttonFrontNumber.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonBackName.AutoToolTip = false;
			this.buttonBackName.CheckOnClick = true;
			this.buttonBackName.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonBackName.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonBackName.Image");
			this.buttonBackName.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonBackName.Name = "buttonBackName";
			this.buttonBackName.Size = new global::System.Drawing.Size(89, 19);
			this.buttonBackName.Text = "   Back Name   ";
			this.buttonBackName.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonNameCurvature.AutoToolTip = false;
			this.buttonNameCurvature.CheckOnClick = true;
			this.buttonNameCurvature.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonNameCurvature.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonNameCurvature.Image");
			this.buttonNameCurvature.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonNameCurvature.Name = "buttonNameCurvature";
			this.buttonNameCurvature.Size = new global::System.Drawing.Size(98, 19);
			this.buttonNameCurvature.Text = "Name Curvature";
			this.buttonNameCurvature.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonShortsNumber.AutoToolTip = false;
			this.buttonShortsNumber.CheckOnClick = true;
			this.buttonShortsNumber.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonShortsNumber.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShortsNumber.Image");
			this.buttonShortsNumber.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShortsNumber.Name = "buttonShortsNumber";
			this.buttonShortsNumber.Size = new global::System.Drawing.Size(91, 19);
			this.buttonShortsNumber.Text = "Shorts Number";
			this.buttonShortsNumber.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonShortsBadge.AutoToolTip = false;
			this.buttonShortsBadge.CheckOnClick = true;
			this.buttonShortsBadge.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonShortsBadge.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShortsBadge.Image");
			this.buttonShortsBadge.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShortsBadge.Name = "buttonShortsBadge";
			this.buttonShortsBadge.Size = new global::System.Drawing.Size(86, 19);
			this.buttonShortsBadge.Text = " Shorts Badge ";
			this.buttonShortsBadge.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonBackNumber.AutoToolTip = false;
			this.buttonBackNumber.CheckOnClick = true;
			this.buttonBackNumber.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonBackNumber.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonBackNumber.Image");
			this.buttonBackNumber.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonBackNumber.Name = "buttonBackNumber";
			this.buttonBackNumber.Size = new global::System.Drawing.Size(89, 19);
			this.buttonBackNumber.Text = " Back Number ";
			this.buttonBackNumber.Click += new global::System.EventHandler(this.buttonPositions_Click);
			this.buttonCopyPositions.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonCopyPositions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCopyPositions.Image");
			this.buttonCopyPositions.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonCopyPositions.Margin = new global::System.Windows.Forms.Padding(15, 1, 0, 2);
			this.buttonCopyPositions.Name = "buttonCopyPositions";
			this.buttonCopyPositions.Size = new global::System.Drawing.Size(23, 20);
			this.buttonCopyPositions.Text = "Copy All Positions";
			this.buttonCopyPositions.Click += new global::System.EventHandler(this.buttonCopyPositions_Click);
			this.buttonPastePositions.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonPastePositions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonPastePositions.Image");
			this.buttonPastePositions.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonPastePositions.Name = "buttonPastePositions";
			this.buttonPastePositions.Size = new global::System.Drawing.Size(23, 20);
			this.buttonPastePositions.Text = "Paste All Positions";
			this.buttonPastePositions.Click += new global::System.EventHandler(this.buttonPastePositions_Click);
			this.numericBottom.DecimalPlaces = 3;
			this.numericBottom.Enabled = false;
			this.numericBottom.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
			this.numericBottom.Location = new global::System.Drawing.Point(302, 74);
			this.numericBottom.Maximum = new decimal(new int[] { 10, 0, 0, 65536 });
			this.numericBottom.Name = "numericBottom";
			this.numericBottom.Size = new global::System.Drawing.Size(64, 20);
			this.numericBottom.TabIndex = 178;
			this.numericBottom.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericBottom.ValueChanged += new global::System.EventHandler(this.numericPositions_ValueChanged);
			this.numericTop.DecimalPlaces = 3;
			this.numericTop.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
			this.numericTop.Location = new global::System.Drawing.Point(300, 17);
			this.numericTop.Maximum = new decimal(new int[] { 10, 0, 0, 65536 });
			this.numericTop.Name = "numericTop";
			this.numericTop.Size = new global::System.Drawing.Size(64, 20);
			this.numericTop.TabIndex = 174;
			this.numericTop.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericTop.ValueChanged += new global::System.EventHandler(this.numericPositions_ValueChanged);
			this.numericRight.DecimalPlaces = 3;
			this.numericRight.Enabled = false;
			this.numericRight.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
			this.numericRight.Location = new global::System.Drawing.Point(359, 44);
			this.numericRight.Maximum = new decimal(new int[] { 10, 0, 0, 65536 });
			this.numericRight.Name = "numericRight";
			this.numericRight.Size = new global::System.Drawing.Size(64, 20);
			this.numericRight.TabIndex = 172;
			this.numericRight.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericRight.ValueChanged += new global::System.EventHandler(this.numericPositions_ValueChanged);
			this.numericLeft.DecimalPlaces = 3;
			this.numericLeft.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
			this.numericLeft.Location = new global::System.Drawing.Point(237, 46);
			this.numericLeft.Maximum = new decimal(new int[] { 10, 0, 0, 65536 });
			this.numericLeft.Name = "numericLeft";
			this.numericLeft.Size = new global::System.Drawing.Size(64, 20);
			this.numericLeft.TabIndex = 173;
			this.numericLeft.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericLeft.ValueChanged += new global::System.EventHandler(this.numericPositions_ValueChanged);
			this.checkLink.AutoSize = true;
			this.checkLink.Checked = true;
			this.checkLink.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkLink.Location = new global::System.Drawing.Point(307, 47);
			this.checkLink.Name = "checkLink";
			this.checkLink.Size = new global::System.Drawing.Size(46, 17);
			this.checkLink.TabIndex = 189;
			this.checkLink.Text = "Link";
			this.checkLink.UseVisualStyleBackColor = true;
			this.checkLink.CheckedChanged += new global::System.EventHandler(this.checkLink_CheckedChanged);
			this.label2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new global::System.Drawing.Point(263, 27);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(129, 56);
			this.label2.TabIndex = 188;
			this.buttonExportAllKits.Enabled = false;
			this.buttonExportAllKits.Location = new global::System.Drawing.Point(226, 35);
			this.buttonExportAllKits.Name = "buttonExportAllKits";
			this.buttonExportAllKits.Size = new global::System.Drawing.Size(89, 23);
			this.buttonExportAllKits.TabIndex = 12;
			this.buttonExportAllKits.Text = "Export all Kits";
			this.buttonExportAllKits.UseVisualStyleBackColor = true;
			this.buttonExportAllKits.Visible = false;
			this.buttonExportAllKits.Click += new global::System.EventHandler(this.buttonExportAllKits_Click);
			this.numericTeamId.BackColor = global::System.Drawing.SystemColors.Window;
			this.numericTeamId.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.kitBindingSource, "teamid", true));
			this.numericTeamId.Enabled = false;
			this.numericTeamId.Location = new global::System.Drawing.Point(106, 35);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericTeamId;
			int[] array = new int[4];
			array[0] = 300000;
			numericUpDown.Maximum = new decimal(array);
			this.numericTeamId.Name = "numericTeamId";
			this.numericTeamId.ReadOnly = true;
			this.numericTeamId.Size = new global::System.Drawing.Size(98, 20);
			this.numericTeamId.TabIndex = 11;
			this.numericTeamId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.kitBindingSource.DataSource = typeof(global::FifaLibrary.Kit);
			this.labelTeamId.AutoSize = true;
			this.labelTeamId.Location = new global::System.Drawing.Point(10, 42);
			this.labelTeamId.Name = "labelTeamId";
			this.labelTeamId.Size = new global::System.Drawing.Size(46, 13);
			this.labelTeamId.TabIndex = 4;
			this.labelTeamId.Text = "Team Id";
			this.labelKitType.AutoSize = true;
			this.labelKitType.Location = new global::System.Drawing.Point(227, 11);
			this.labelKitType.Name = "labelKitType";
			this.labelKitType.Size = new global::System.Drawing.Size(19, 13);
			this.labelKitType.TabIndex = 3;
			this.labelKitType.Text = "Kit";
			this.labelTeam.AutoSize = true;
			this.labelTeam.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelTeam.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTeam.ForeColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.labelTeam.Location = new global::System.Drawing.Point(10, 11);
			this.labelTeam.Name = "labelTeam";
			this.labelTeam.Size = new global::System.Drawing.Size(34, 13);
			this.labelTeam.TabIndex = 2;
			this.labelTeam.Text = "Team";
			this.labelTeam.DoubleClick += new global::System.EventHandler(this.labelTeam_DoubleClick);
			this.comboTeam.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedItem", this.kitBindingSource, "Team", true));
			this.comboTeam.DataSource = this.teamListBindingSource;
			this.comboTeam.Enabled = false;
			this.comboTeam.FormattingEnabled = true;
			this.comboTeam.Location = new global::System.Drawing.Point(50, 8);
			this.comboTeam.Name = "comboTeam";
			this.comboTeam.Size = new global::System.Drawing.Size(154, 21);
			this.comboTeam.TabIndex = 0;
			this.teamListBindingSource.DataSource = typeof(global::FifaLibrary.TeamList);
			this.comboKitType.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.kitBindingSource, "kittype", true));
			this.comboKitType.Enabled = false;
			this.comboKitType.FormattingEnabled = true;
			this.comboKitType.Items.AddRange(new object[]
			{
				"Home", "Away", "Goalkeeper", "3rd", "4th", "5th", "6th", "7th", "8th", "9th",
				"10th"
			});
			this.comboKitType.Location = new global::System.Drawing.Point(271, 8);
			this.comboKitType.Name = "comboKitType";
			this.comboKitType.Size = new global::System.Drawing.Size(114, 21);
			this.comboKitType.TabIndex = 1;
			this.splitContainer2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
			this.splitContainer2.Size = new global::System.Drawing.Size(837, 807);
			this.splitContainer2.SplitterDistance = 437;
			this.splitContainer2.TabIndex = 0;
			this.splitContainer4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer4.Panel1.Controls.Add(this.group3D);
			this.splitContainer4.Panel2.AutoScroll = true;
			this.splitContainer4.Panel2.Controls.Add(this.multiViewer2DShortsNumbers);
			this.splitContainer4.Panel2.Controls.Add(this.pictureShortsNumberColor);
			this.splitContainer4.Panel2.Controls.Add(this.numericShortsNumberFont);
			this.splitContainer4.Panel2.Controls.Add(this.multiViewer2DJerseyNumbers);
			this.splitContainer4.Panel2.Controls.Add(this.checkShortsNumber);
			this.splitContainer4.Panel2.Controls.Add(this.checkFrontNumber);
			this.splitContainer4.Panel2.Controls.Add(this.pictureJerseyNumberColor);
			this.splitContainer4.Panel2.Controls.Add(this.numericJerseyNumberFont);
			this.splitContainer4.Size = new global::System.Drawing.Size(437, 807);
			this.splitContainer4.SplitterDistance = 576;
			this.splitContainer4.TabIndex = 0;
			this.group3D.Controls.Add(this.viewer3D);
			this.group3D.Controls.Add(this.toolNear3D);
			this.group3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.group3D.Location = new global::System.Drawing.Point(0, 0);
			this.group3D.Name = "group3D";
			this.group3D.Size = new global::System.Drawing.Size(433, 572);
			this.group3D.TabIndex = 2;
			this.group3D.TabStop = false;
			this.group3D.Text = "3D Model";
			this.viewer3D.AmbientColor = global::System.Drawing.Color.White;
			this.viewer3D.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer3D.LightDirectionX = 0f;
			this.viewer3D.LightDirectionY = 0f;
			this.viewer3D.LightDirectionZ = -1f;
			this.viewer3D.LightX = 100f;
			this.viewer3D.LightY = 10f;
			this.viewer3D.LightZ = 100f;
			this.viewer3D.Location = new global::System.Drawing.Point(3, 16);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 0.1f;
			this.viewer3D.RotationY = 0f;
			this.viewer3D.RotationYCoeff = 0.01f;
			this.viewer3D.Size = new global::System.Drawing.Size(427, 528);
			this.viewer3D.TabIndex = 1;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 95f;
			this.viewer3D.ViewZ = 190f;
			this.viewer3D.ZbufferRenderState = null;
			this.toolNear3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.toolNear3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolNear3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.buttonRefresh3D, this.buttonShowNumbers3D, this.toolStripSeparator1, this.buttonCamera });
			this.toolNear3D.Location = new global::System.Drawing.Point(3, 544);
			this.toolNear3D.Name = "toolNear3D";
			this.toolNear3D.Size = new global::System.Drawing.Size(427, 25);
			this.toolNear3D.TabIndex = 2;
			this.buttonShow3DModel.CheckOnClick = true;
			this.buttonShow3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DModel.Image");
			this.buttonShow3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DModel.Name = "buttonShow3DModel";
			this.buttonShow3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DModel.Text = "Show / Hide";
			this.buttonShow3DModel.Click += new global::System.EventHandler(this.buttonShow3DModel_Click);
			this.buttonRefresh3D.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRefresh3D.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRefresh3D.Image");
			this.buttonRefresh3D.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRefresh3D.Name = "buttonRefresh3D";
			this.buttonRefresh3D.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRefresh3D.Text = "Refresh 3D View";
			this.buttonRefresh3D.Click += new global::System.EventHandler(this.buttonRefresh3D_Click);
			this.buttonShowNumbers3D.CheckOnClick = true;
			this.buttonShowNumbers3D.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowNumbers3D.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShowNumbers3D.Image");
			this.buttonShowNumbers3D.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShowNumbers3D.Name = "buttonShowNumbers3D";
			this.buttonShowNumbers3D.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShowNumbers3D.Text = "Show Numbers";
			this.buttonShowNumbers3D.Click += new global::System.EventHandler(this.buttonShowNumbers3D_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonCamera.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonCamera.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCamera.Image");
			this.buttonCamera.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonCamera.Name = "buttonCamera";
			this.buttonCamera.Size = new global::System.Drawing.Size(23, 22);
			this.buttonCamera.Text = "Take a picture for minikit";
			this.buttonCamera.Click += new global::System.EventHandler(this.buttonCamera_Click);
			this.multiViewer2DShortsNumbers.AutoTransparency = true;
			this.multiViewer2DShortsNumbers.Bitmaps = null;
			this.multiViewer2DShortsNumbers.CheckBitmapSize = true;
			this.multiViewer2DShortsNumbers.FixedSize = false;
			this.multiViewer2DShortsNumbers.FullSizeButton = false;
			this.multiViewer2DShortsNumbers.LabelText = "Shorts";
			this.multiViewer2DShortsNumbers.Location = new global::System.Drawing.Point(220, 27);
			this.multiViewer2DShortsNumbers.Name = "multiViewer2DShortsNumbers";
			this.multiViewer2DShortsNumbers.ShowButton = false;
			this.multiViewer2DShortsNumbers.ShowDeleteButton = false;
			this.multiViewer2DShortsNumbers.Size = new global::System.Drawing.Size(132, 178);
			this.multiViewer2DShortsNumbers.TabIndex = 1;
			this.pictureShortsNumberColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureShortsNumberColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureShortsNumberColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureShortsNumberColor.Location = new global::System.Drawing.Point(357, 108);
			this.pictureShortsNumberColor.Name = "pictureShortsNumberColor";
			this.pictureShortsNumberColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureShortsNumberColor.TabIndex = 147;
			this.pictureShortsNumberColor.TabStop = false;
			this.pictureShortsNumberColor.Click += new global::System.EventHandler(this.pictureShortsNumberColor_Click);
			this.numericShortsNumberFont.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.kitBindingSource, "shortsNumberFont", true));
			this.numericShortsNumberFont.Location = new global::System.Drawing.Point(357, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericShortsNumberFont;
			int[] array2 = new int[4];
			array2[0] = 255;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericShortsNumberFont.Name = "numericShortsNumberFont";
			this.numericShortsNumberFont.Size = new global::System.Drawing.Size(55, 20);
			this.numericShortsNumberFont.TabIndex = 12;
			this.numericShortsNumberFont.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericShortsNumberFont.ValueChanged += new global::System.EventHandler(this.numericShortsNumberFont_ValueChanged);
			this.multiViewer2DJerseyNumbers.AutoTransparency = true;
			this.multiViewer2DJerseyNumbers.Bitmaps = null;
			this.multiViewer2DJerseyNumbers.CheckBitmapSize = true;
			this.multiViewer2DJerseyNumbers.FixedSize = false;
			this.multiViewer2DJerseyNumbers.FullSizeButton = false;
			this.multiViewer2DJerseyNumbers.LabelText = "Jersey";
			this.multiViewer2DJerseyNumbers.Location = new global::System.Drawing.Point(13, 27);
			this.multiViewer2DJerseyNumbers.Name = "multiViewer2DJerseyNumbers";
			this.multiViewer2DJerseyNumbers.ShowButton = false;
			this.multiViewer2DJerseyNumbers.ShowDeleteButton = false;
			this.multiViewer2DJerseyNumbers.Size = new global::System.Drawing.Size(132, 178);
			this.multiViewer2DJerseyNumbers.TabIndex = 0;
			this.checkShortsNumber.AutoSize = true;
			this.checkShortsNumber.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.kitBindingSource, "shortsNumber", true));
			this.checkShortsNumber.Location = new global::System.Drawing.Point(220, 10);
			this.checkShortsNumber.Name = "checkShortsNumber";
			this.checkShortsNumber.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkShortsNumber.Size = new global::System.Drawing.Size(117, 17);
			this.checkShortsNumber.TabIndex = 4;
			this.checkShortsNumber.Text = "Shorts Number       ";
			this.checkShortsNumber.UseVisualStyleBackColor = true;
			this.checkShortsNumber.CheckedChanged += new global::System.EventHandler(this.checkShortsNumber_CheckedChanged);
			this.checkFrontNumber.AutoSize = true;
			this.checkFrontNumber.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.kitBindingSource, "jerseyFrontNumber", true));
			this.checkFrontNumber.Location = new global::System.Drawing.Point(13, 10);
			this.checkFrontNumber.Name = "checkFrontNumber";
			this.checkFrontNumber.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkFrontNumber.Size = new global::System.Drawing.Size(105, 17);
			this.checkFrontNumber.TabIndex = 3;
			this.checkFrontNumber.Text = "Front Number     ";
			this.checkFrontNumber.UseVisualStyleBackColor = true;
			this.checkFrontNumber.CheckedChanged += new global::System.EventHandler(this.checkFrontNumber_CheckedChanged);
			this.pictureJerseyNumberColor.BackColor = global::System.Drawing.SystemColors.Control;
			this.pictureJerseyNumberColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureJerseyNumberColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureJerseyNumberColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureJerseyNumberColor.Location = new global::System.Drawing.Point(151, 108);
			this.pictureJerseyNumberColor.Name = "pictureJerseyNumberColor";
			this.pictureJerseyNumberColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureJerseyNumberColor.TabIndex = 146;
			this.pictureJerseyNumberColor.TabStop = false;
			this.pictureJerseyNumberColor.Click += new global::System.EventHandler(this.pictureJerseyNumberColor_Click);
			this.numericJerseyNumberFont.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.kitBindingSource, "jerseyNumberFont", true));
			this.numericJerseyNumberFont.Location = new global::System.Drawing.Point(151, 82);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericJerseyNumberFont;
			int[] array3 = new int[4];
			array3[0] = 255;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericJerseyNumberFont.Name = "numericJerseyNumberFont";
			this.numericJerseyNumberFont.Size = new global::System.Drawing.Size(55, 20);
			this.numericJerseyNumberFont.TabIndex = 10;
			this.numericJerseyNumberFont.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericJerseyNumberFont.ValueChanged += new global::System.EventHandler(this.numericJerseyNumberFont_ValueChanged);
			this.splitContainer5.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer5.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer5.Panel1.Controls.Add(this.viewer2DMinikit);
			this.splitContainer5.Panel2.Controls.Add(this.flowPanel);
			this.splitContainer5.Size = new global::System.Drawing.Size(396, 807);
			this.splitContainer5.SplitterDistance = 297;
			this.splitContainer5.TabIndex = 0;
			this.viewer2DMinikit.AutoTransparency = true;
			this.viewer2DMinikit.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DMinikit.ButtonStripVisible = true;
			this.viewer2DMinikit.CurrentBitmap = null;
			this.viewer2DMinikit.ExtendedFormat = false;
			this.viewer2DMinikit.FullSizeButton = false;
			this.viewer2DMinikit.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DMinikit.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DMinikit.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DMinikit.Location = new global::System.Drawing.Point(0, 0);
			this.viewer2DMinikit.Name = "viewer2DMinikit";
			this.viewer2DMinikit.RemoveButton = false;
			this.viewer2DMinikit.ShowButton = false;
			this.viewer2DMinikit.ShowButtonChecked = true;
			this.viewer2DMinikit.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DMinikit.TabIndex = 0;
			this.flowPanel.AutoScroll = true;
			this.flowPanel.Controls.Add(this.groupCollar);
			this.flowPanel.Controls.Add(this.groupName);
			this.flowPanel.Controls.Add(this.pictureFont);
			this.flowPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowPanel.Location = new global::System.Drawing.Point(0, 0);
			this.flowPanel.Name = "flowPanel";
			this.flowPanel.Size = new global::System.Drawing.Size(392, 502);
			this.flowPanel.TabIndex = 0;
			this.groupCollar.Controls.Add(this.labelCollarImage);
			this.groupCollar.Controls.Add(this.checkIsFitting);
			this.groupCollar.Controls.Add(this.checkHasAdvertising);
			this.groupCollar.Controls.Add(this.pictureTeamTerColor);
			this.groupCollar.Controls.Add(this.pictureTeamPrimColor);
			this.groupCollar.Controls.Add(this.pictureTeamSecColor);
			this.groupCollar.Controls.Add(this.labelCollar);
			this.groupCollar.Controls.Add(this.numericCollar);
			this.groupCollar.Location = new global::System.Drawing.Point(3, 3);
			this.groupCollar.Name = "groupCollar";
			this.groupCollar.Size = new global::System.Drawing.Size(379, 173);
			this.groupCollar.TabIndex = 1;
			this.groupCollar.TabStop = false;
			this.groupCollar.Text = "Jersey";
			this.labelCollarImage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelCollarImage.ImageList = this.imageListCollar;
			this.labelCollarImage.Location = new global::System.Drawing.Point(9, 44);
			this.labelCollarImage.Name = "labelCollarImage";
			this.labelCollarImage.Size = new global::System.Drawing.Size(210, 120);
			this.labelCollarImage.TabIndex = 154;
			this.imageListCollar.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListCollar.ImageStream");
			this.imageListCollar.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListCollar.Images.SetKeyName(0, "col_00.png");
			this.imageListCollar.Images.SetKeyName(1, "col_01.png");
			this.imageListCollar.Images.SetKeyName(2, "col_02.png");
			this.imageListCollar.Images.SetKeyName(3, "col_03.png");
			this.imageListCollar.Images.SetKeyName(4, "col_04.png");
			this.imageListCollar.Images.SetKeyName(5, "col_05.png");
			this.imageListCollar.Images.SetKeyName(6, "col_06.png");
			this.imageListCollar.Images.SetKeyName(7, "col_07.png");
			this.imageListCollar.Images.SetKeyName(8, "col_08.png");
			this.imageListCollar.Images.SetKeyName(9, "col_09.png");
			this.imageListCollar.Images.SetKeyName(10, "col_10.png");
			this.imageListCollar.Images.SetKeyName(11, "col_11.png");
			this.imageListCollar.Images.SetKeyName(12, "col_12.png");
			this.imageListCollar.Images.SetKeyName(13, "col_13.png");
			this.imageListCollar.Images.SetKeyName(14, "col_14.png");
			this.imageListCollar.Images.SetKeyName(15, "col_15.png");
			this.imageListCollar.Images.SetKeyName(16, "col_16.png");
			this.imageListCollar.Images.SetKeyName(17, "col_17.png");
			this.imageListCollar.Images.SetKeyName(18, "col_18.png");
			this.imageListCollar.Images.SetKeyName(19, "col_19.png");
			this.imageListCollar.Images.SetKeyName(20, "col_20.png");
			this.imageListCollar.Images.SetKeyName(21, "col_21.png");
			this.checkIsFitting.AutoSize = true;
			this.checkIsFitting.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.kitBindingSource, "jerseyfit", true));
			this.checkIsFitting.Location = new global::System.Drawing.Point(245, 42);
			this.checkIsFitting.Name = "checkIsFitting";
			this.checkIsFitting.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkIsFitting.Size = new global::System.Drawing.Size(65, 17);
			this.checkIsFitting.TabIndex = 152;
			this.checkIsFitting.Text = "Is Fitting";
			this.checkIsFitting.UseVisualStyleBackColor = true;
			this.checkHasAdvertising.AutoSize = true;
			this.checkHasAdvertising.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.kitBindingSource, "hasadvertisingkit", true));
			this.checkHasAdvertising.Location = new global::System.Drawing.Point(246, 19);
			this.checkHasAdvertising.Name = "checkHasAdvertising";
			this.checkHasAdvertising.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkHasAdvertising.Size = new global::System.Drawing.Size(118, 17);
			this.checkHasAdvertising.TabIndex = 151;
			this.checkHasAdvertising.Text = "Has Advertising      ";
			this.checkHasAdvertising.UseVisualStyleBackColor = true;
			this.pictureTeamTerColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamTerColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamTerColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.kitBindingSource, "TeamColor3", true));
			this.pictureTeamTerColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamTerColor.Location = new global::System.Drawing.Point(329, 98);
			this.pictureTeamTerColor.Name = "pictureTeamTerColor";
			this.pictureTeamTerColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamTerColor.TabIndex = 150;
			this.pictureTeamTerColor.TabStop = false;
			this.pictureTeamTerColor.Click += new global::System.EventHandler(this.pictureTeamTerColor_Click);
			this.pictureTeamPrimColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamPrimColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamPrimColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.kitBindingSource, "TeamColor1", true));
			this.pictureTeamPrimColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamPrimColor.Location = new global::System.Drawing.Point(255, 98);
			this.pictureTeamPrimColor.Name = "pictureTeamPrimColor";
			this.pictureTeamPrimColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamPrimColor.TabIndex = 148;
			this.pictureTeamPrimColor.TabStop = false;
			this.pictureTeamPrimColor.Click += new global::System.EventHandler(this.pictureTeamPrimColor_Click);
			this.pictureTeamSecColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureTeamSecColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureTeamSecColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.kitBindingSource, "TeamColor2", true));
			this.pictureTeamSecColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureTeamSecColor.Location = new global::System.Drawing.Point(292, 98);
			this.pictureTeamSecColor.Name = "pictureTeamSecColor";
			this.pictureTeamSecColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureTeamSecColor.TabIndex = 149;
			this.pictureTeamSecColor.TabStop = false;
			this.pictureTeamSecColor.Click += new global::System.EventHandler(this.pictureTeamSecColor_Click);
			this.labelCollar.AutoSize = true;
			this.labelCollar.Location = new global::System.Drawing.Point(6, 21);
			this.labelCollar.Name = "labelCollar";
			this.labelCollar.Size = new global::System.Drawing.Size(33, 13);
			this.labelCollar.TabIndex = 1;
			this.labelCollar.Text = "Collar";
			this.numericCollar.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.kitBindingSource, "jerseyCollar", true));
			this.numericCollar.Location = new global::System.Drawing.Point(111, 14);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericCollar;
			int[] array4 = new int[4];
			array4[0] = 21;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericCollar.Name = "numericCollar";
			this.numericCollar.Size = new global::System.Drawing.Size(108, 20);
			this.numericCollar.TabIndex = 0;
			this.numericCollar.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCollar.ValueChanged += new global::System.EventHandler(this.numericCollar_ValueChanged);
			this.groupName.Controls.Add(this.labelFont);
			this.groupName.Controls.Add(this.toolStripNameFont);
			this.groupName.Controls.Add(this.label3);
			this.groupName.Controls.Add(this.comboBox1);
			this.groupName.Controls.Add(this.checkHasBackname);
			this.groupName.Controls.Add(this.numericNameFont);
			this.groupName.Controls.Add(this.labelNameFont);
			this.groupName.Controls.Add(this.pictureNameColor);
			this.groupName.Controls.Add(this.label1);
			this.groupName.Controls.Add(this.comboNameLayout);
			this.groupName.Location = new global::System.Drawing.Point(3, 182);
			this.groupName.Name = "groupName";
			this.groupName.Size = new global::System.Drawing.Size(379, 151);
			this.groupName.TabIndex = 2;
			this.groupName.TabStop = false;
			this.groupName.Text = "Name";
			this.labelFont.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelFont.Location = new global::System.Drawing.Point(255, 42);
			this.labelFont.Name = "labelFont";
			this.labelFont.Size = new global::System.Drawing.Size(100, 92);
			this.labelFont.TabIndex = 5;
			this.labelFont.Visible = false;
			this.toolStripNameFont.AutoSize = false;
			this.toolStripNameFont.Dock = global::System.Windows.Forms.DockStyle.None;
			this.toolStripNameFont.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripNameFont.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonPreviewNameFont, this.buttonImportNameFont, this.buttonDeleteNameFont, this.buttonExportNameFont });
			this.toolStripNameFont.Location = new global::System.Drawing.Point(9, 66);
			this.toolStripNameFont.Name = "toolStripNameFont";
			this.toolStripNameFont.Size = new global::System.Drawing.Size(241, 25);
			this.toolStripNameFont.TabIndex = 148;
			this.buttonPreviewNameFont.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonPreviewNameFont.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonPreviewNameFont.Image");
			this.buttonPreviewNameFont.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonPreviewNameFont.Margin = new global::System.Windows.Forms.Padding(70, 1, 0, 2);
			this.buttonPreviewNameFont.Name = "buttonPreviewNameFont";
			this.buttonPreviewNameFont.Size = new global::System.Drawing.Size(23, 22);
			this.buttonPreviewNameFont.Text = "Preview Font";
			this.buttonPreviewNameFont.Visible = false;
			this.buttonPreviewNameFont.Click += new global::System.EventHandler(this.buttonPreviewNameFont_Click);
			this.buttonImportNameFont.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImportNameFont.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportNameFont.Image");
			this.buttonImportNameFont.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportNameFont.Name = "buttonImportNameFont";
			this.buttonImportNameFont.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImportNameFont.Text = "Import Font";
			this.buttonImportNameFont.Click += new global::System.EventHandler(this.buttonImportNameFont_Click);
			this.buttonDeleteNameFont.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonDeleteNameFont.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonDeleteNameFont.Image");
			this.buttonDeleteNameFont.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonDeleteNameFont.Name = "buttonDeleteNameFont";
			this.buttonDeleteNameFont.Size = new global::System.Drawing.Size(23, 22);
			this.buttonDeleteNameFont.Text = "Remove Font";
			this.buttonDeleteNameFont.Click += new global::System.EventHandler(this.buttonDeleteNameFont_Click);
			this.buttonExportNameFont.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExportNameFont.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExportNameFont.Image");
			this.buttonExportNameFont.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExportNameFont.Name = "buttonExportNameFont";
			this.buttonExportNameFont.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExportNameFont.Text = "Export";
			this.buttonExportNameFont.Visible = false;
			this.buttonExportNameFont.Click += new global::System.EventHandler(this.buttonExportNameFont_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 110);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(55, 13);
			this.label3.TabIndex = 146;
			this.label3.Text = "Font Case";
			this.comboBox1.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.kitBindingSource, "jerseyNameFontCase", true));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] { "UPPER CASE", "lower case", "Mixed Case" });
			this.comboBox1.Location = new global::System.Drawing.Point(139, 98);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(108, 21);
			this.comboBox1.TabIndex = 147;
			this.checkHasBackname.AutoSize = true;
			this.checkHasBackname.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.kitBindingSource, "jerseyBackName", true));
			this.checkHasBackname.Location = new global::System.Drawing.Point(9, 19);
			this.checkHasBackname.Name = "checkHasBackname";
			this.checkHasBackname.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.checkHasBackname.Size = new global::System.Drawing.Size(112, 17);
			this.checkHasBackname.TabIndex = 2;
			this.checkHasBackname.Text = "Back Name          ";
			this.checkHasBackname.UseVisualStyleBackColor = true;
			this.checkHasBackname.CheckedChanged += new global::System.EventHandler(this.checkHasBackname_CheckedChanged);
			this.numericNameFont.DataBindings.Add(new global::System.Windows.Forms.Binding("Value", this.kitBindingSource, "jerseyNameFont", true));
			this.numericNameFont.Location = new global::System.Drawing.Point(139, 42);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericNameFont;
			int[] array5 = new int[4];
			array5[0] = 21;
			numericUpDown5.Maximum = new decimal(array5);
			this.numericNameFont.Name = "numericNameFont";
			this.numericNameFont.Size = new global::System.Drawing.Size(108, 20);
			this.numericNameFont.TabIndex = 5;
			this.numericNameFont.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericNameFont.ValueChanged += new global::System.EventHandler(this.numericNameFont_ValueChanged);
			this.labelNameFont.AutoSize = true;
			this.labelNameFont.Location = new global::System.Drawing.Point(6, 48);
			this.labelNameFont.Name = "labelNameFont";
			this.labelNameFont.Size = new global::System.Drawing.Size(55, 13);
			this.labelNameFont.TabIndex = 6;
			this.labelNameFont.Text = "Font Type";
			this.pictureNameColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureNameColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureNameColor.DataBindings.Add(new global::System.Windows.Forms.Binding("BackColor", this.kitBindingSource, "JerseyNameColor", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.pictureNameColor.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.pictureNameColor.Location = new global::System.Drawing.Point(190, 12);
			this.pictureNameColor.Name = "pictureNameColor";
			this.pictureNameColor.Size = new global::System.Drawing.Size(24, 24);
			this.pictureNameColor.TabIndex = 145;
			this.pictureNameColor.TabStop = false;
			this.pictureNameColor.Click += new global::System.EventHandler(this.pictureNameColor_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 129);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(39, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Layout";
			this.comboNameLayout.DataBindings.Add(new global::System.Windows.Forms.Binding("SelectedIndex", this.kitBindingSource, "jerseyNameLayout", true));
			this.comboNameLayout.FormattingEnabled = true;
			this.comboNameLayout.Items.AddRange(new object[] { "Straight", "Curved" });
			this.comboNameLayout.Location = new global::System.Drawing.Point(139, 122);
			this.comboNameLayout.Name = "comboNameLayout";
			this.comboNameLayout.Size = new global::System.Drawing.Size(108, 21);
			this.comboNameLayout.TabIndex = 8;
			this.pictureFont.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureFont.Location = new global::System.Drawing.Point(3, 339);
			this.pictureFont.Name = "pictureFont";
			this.pictureFont.Size = new global::System.Drawing.Size(379, 139);
			this.pictureFont.TabIndex = 4;
			this.pictureFont.TabStop = false;
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = true;
			this.pickUpControl.CreateButtonEnabled = false;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = new string[] { "All", "by Team", "by League", "by Country" };
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
			this.fontDialog.Color = global::System.Drawing.SystemColors.ControlText;
			this.processFontView.StartInfo.Domain = "";
			this.processFontView.StartInfo.LoadUserProfile = false;
			this.processFontView.StartInfo.Password = null;
			this.processFontView.StartInfo.StandardErrorEncoding = null;
			this.processFontView.StartInfo.StandardOutputEncoding = null;
			this.processFontView.StartInfo.UserName = "";
			this.processFontView.SynchronizingObject = this;
			this.fontDialog1.Color = global::System.Drawing.SystemColors.ControlText;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "KitForm";
			this.Text = "KitForm";
			base.Load += new global::System.EventHandler(this.KitForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.groupPositions.ResumeLayout(false);
			this.groupPositions.PerformLayout();
			this.toolStrip3D.ResumeLayout(false);
			this.toolStrip3D.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericBottom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTop).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericRight).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericLeft).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamId).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.kitBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.teamListBindingSource).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer4).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.group3D.ResumeLayout(false);
			this.group3D.PerformLayout();
			this.toolNear3D.ResumeLayout(false);
			this.toolNear3D.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureShortsNumberColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericShortsNumberFont).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureJerseyNumberColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericJerseyNumberFont).EndInit();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer5).EndInit();
			this.splitContainer5.ResumeLayout(false);
			this.flowPanel.ResumeLayout(false);
			this.groupCollar.ResumeLayout(false);
			this.groupCollar.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamTerColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamPrimColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureTeamSecColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCollar).EndInit();
			this.groupName.ResumeLayout(false);
			this.groupName.PerformLayout();
			this.toolStripNameFont.ResumeLayout(false);
			this.toolStripNameFont.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericNameFont).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureNameColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureFont).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000F2 RID: 242
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000F3 RID: 243
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.SplitContainer splitContainer3;

		// Token: 0x040000F6 RID: 246
		private global::FifaControls.Viewer2D viewer2DMinikit;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.SplitContainer splitContainer4;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.SplitContainer splitContainer5;

		// Token: 0x040000FA RID: 250
		private global::FifaControls.MultiViewer2D multiViewer2DKit;

		// Token: 0x040000FB RID: 251
		private global::FifaControls.MultiViewer2D multiViewer2DJerseyNumbers;

		// Token: 0x040000FC RID: 252
		private global::FifaControls.MultiViewer2D multiViewer2DShortsNumbers;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.GroupBox group3D;

		// Token: 0x040000FE RID: 254
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.ToolStrip toolNear3D;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.ToolStripButton buttonCamera;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.FlowLayoutPanel flowPanel;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.NumericUpDown numericCollar;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.GroupBox groupCollar;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label labelCollar;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.BindingSource kitBindingSource;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.CheckBox checkHasBackname;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.CheckBox checkFrontNumber;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.CheckBox checkShortsNumber;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.Label labelNameFont;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.NumericUpDown numericNameFont;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.ComboBox comboNameLayout;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.NumericUpDown numericShortsNumberFont;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.NumericUpDown numericJerseyNumberFont;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.PictureBox pictureNameColor;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.ColorDialog colorDialog;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.PictureBox pictureJerseyNumberColor;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.PictureBox pictureShortsNumberColor;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.PictureBox pictureTeamTerColor;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.PictureBox pictureTeamPrimColor;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.PictureBox pictureTeamSecColor;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.GroupBox groupName;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.CheckBox checkHasAdvertising;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.NumericUpDown numericBottom;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.NumericUpDown numericTop;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.NumericUpDown numericLeft;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.NumericUpDown numericRight;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.ComboBox comboKitType;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ComboBox comboTeam;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.BindingSource teamListBindingSource;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.Label labelKitType;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.Label labelTeam;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.GroupBox groupPositions;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.CheckBox checkLink;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.ToolStrip toolStrip3D;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.ToolStripButton buttonFrontNumber;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.ToolStripButton buttonShortsBadge;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.ToolStripButton buttonJerseyBadge;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.ToolStripButton buttonShortsNumber;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.ToolStripButton buttonBackName;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.ToolStripButton buttonBackNumber;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.ToolStripButton buttonNameCurvature;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.ToolStripButton buttonRefresh3D;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.ToolStripButton buttonShowNumbers3D;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.FontDialog fontDialog;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.ToolStrip toolStripNameFont;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.ToolStripButton buttonPreviewNameFont;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.ToolStripButton buttonImportNameFont;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.ToolStripButton buttonExportNameFont;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.ToolStripButton buttonDeleteNameFont;

		// Token: 0x04000138 RID: 312
		private global::System.Diagnostics.Process processFontView;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.ToolStripButton buttonCopyPositions;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.ToolStripButton buttonPastePositions;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.FontDialog fontDialog1;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.CheckBox checkIsFitting;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.ImageList imageListCollar;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.Label labelCollarImage;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.PictureBox pictureFont;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.NumericUpDown numericTeamId;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.Label labelTeamId;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.Label labelFont;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.Button buttonExportAllKits;
	}
}
