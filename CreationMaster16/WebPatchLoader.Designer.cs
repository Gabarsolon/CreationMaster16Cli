namespace CreationMaster
{
	// Token: 0x02000017 RID: 23
	public partial class WebPatchLoader : global::System.Windows.Forms.Form
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00056034 File Offset: 0x00054234
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00056054 File Offset: 0x00054254
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.WebPatchLoader));
			this.toolMain = new global::System.Windows.Forms.ToolStrip();
			this.buttonImportPatch = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonExitCreator = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonSelectAllObjects = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonDeselectAllObjects = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonSelectNewObjects = new global::System.Windows.Forms.ToolStripButton();
			this.listViewPatch = new global::System.Windows.Forms.ListView();
			this.columnItem = new global::System.Windows.Forms.ColumnHeader();
			this.columnType = new global::System.Windows.Forms.ColumnHeader();
			this.columnImportId = new global::System.Windows.Forms.ColumnHeader();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.groupPatchOptions = new global::System.Windows.Forms.GroupBox();
			this.groupMinifaceOptions = new global::System.Windows.Forms.GroupBox();
			this.radioMinifaceAlways = new global::System.Windows.Forms.RadioButton();
			this.radioMinifaceNotPresent = new global::System.Windows.Forms.RadioButton();
			this.radioMinifaceNever = new global::System.Windows.Forms.RadioButton();
			this.checkTeamLogo = new global::System.Windows.Forms.CheckBox();
			this.groupReplaceSelection = new global::System.Windows.Forms.GroupBox();
			this.labelCmsCreated = new global::System.Windows.Forms.Label();
			this.labelCmsReplaced = new global::System.Windows.Forms.Label();
			this.textCmsReplaced = new global::System.Windows.Forms.TextBox();
			this.radioCmsItem = new global::System.Windows.Forms.RadioButton();
			this.comboReplacePlayer = new global::System.Windows.Forms.ComboBox();
			this.comboReplaceTeam = new global::System.Windows.Forms.ComboBox();
			this.radioReplaceItem = new global::System.Windows.Forms.RadioButton();
			this.radioCreateItem = new global::System.Windows.Forms.RadioButton();
			this.labelReplacedPlayerOverall = new global::System.Windows.Forms.Label();
			this.labelPatchPlayerOverall = new global::System.Windows.Forms.Label();
			this.checkEstimatedOverall = new global::System.Windows.Forms.CheckBox();
			this.labelEstimatedOverall = new global::System.Windows.Forms.Label();
			this.toolMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			this.groupPatchOptions.SuspendLayout();
			this.groupMinifaceOptions.SuspendLayout();
			this.groupReplaceSelection.SuspendLayout();
			base.SuspendLayout();
			this.toolMain.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonImportPatch, this.toolStripSeparator2, this.buttonExitCreator, this.toolStripSeparator3, this.buttonSelectAllObjects, this.toolStripSeparator4, this.buttonDeselectAllObjects, this.toolStripSeparator1, this.buttonSelectNewObjects });
			this.toolMain.Location = new global::System.Drawing.Point(0, 0);
			this.toolMain.Name = "toolMain";
			this.toolMain.Size = new global::System.Drawing.Size(643, 25);
			this.toolMain.TabIndex = 2;
			this.toolMain.Text = "toolStrip1";
			this.buttonImportPatch.Enabled = false;
			this.buttonImportPatch.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportPatch.Image");
			this.buttonImportPatch.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportPatch.Margin = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			this.buttonImportPatch.Name = "buttonImportPatch";
			this.buttonImportPatch.Size = new global::System.Drawing.Size(63, 22);
			this.buttonImportPatch.Text = "Import";
			this.buttonImportPatch.Click += new global::System.EventHandler(this.buttonImportPatch_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonExitCreator.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExitCreator.Image");
			this.buttonExitCreator.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExitCreator.Margin = new global::System.Windows.Forms.Padding(2, 1, 0, 2);
			this.buttonExitCreator.Name = "buttonExitCreator";
			this.buttonExitCreator.Size = new global::System.Drawing.Size(45, 22);
			this.buttonExitCreator.Text = "Exit";
			this.buttonExitCreator.Click += new global::System.EventHandler(this.buttonExitCreator_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(6, 25);
			this.buttonSelectAllObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSelectAllObjects.Image");
			this.buttonSelectAllObjects.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSelectAllObjects.Margin = new global::System.Windows.Forms.Padding(2, 1, 0, 2);
			this.buttonSelectAllObjects.Name = "buttonSelectAllObjects";
			this.buttonSelectAllObjects.Size = new global::System.Drawing.Size(75, 22);
			this.buttonSelectAllObjects.Text = "Select All";
			this.buttonSelectAllObjects.Click += new global::System.EventHandler(this.buttonSelectAllObjects_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.buttonDeselectAllObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonDeselectAllObjects.Image");
			this.buttonDeselectAllObjects.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonDeselectAllObjects.Margin = new global::System.Windows.Forms.Padding(2, 1, 0, 2);
			this.buttonDeselectAllObjects.Name = "buttonDeselectAllObjects";
			this.buttonDeselectAllObjects.Size = new global::System.Drawing.Size(88, 22);
			this.buttonDeselectAllObjects.Text = "Deselect All";
			this.buttonDeselectAllObjects.Click += new global::System.EventHandler(this.buttonDeselectAllObjects_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonSelectNewObjects.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSelectNewObjects.Image");
			this.buttonSelectNewObjects.ImageTransparentColor = global::System.Drawing.Color.Transparent;
			this.buttonSelectNewObjects.Margin = new global::System.Windows.Forms.Padding(2, 1, 0, 2);
			this.buttonSelectNewObjects.Name = "buttonSelectNewObjects";
			this.buttonSelectNewObjects.Size = new global::System.Drawing.Size(93, 22);
			this.buttonSelectNewObjects.Text = "Select if new";
			this.buttonSelectNewObjects.Click += new global::System.EventHandler(this.buttonSelectNewObjects_Click);
			this.listViewPatch.AllowColumnReorder = true;
			this.listViewPatch.CheckBoxes = true;
			this.listViewPatch.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnItem, this.columnType, this.columnImportId });
			this.listViewPatch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPatch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.listViewPatch.FullRowSelect = true;
			this.listViewPatch.GridLines = true;
			this.listViewPatch.HideSelection = false;
			this.listViewPatch.Location = new global::System.Drawing.Point(0, 0);
			this.listViewPatch.Name = "listViewPatch";
			this.listViewPatch.Size = new global::System.Drawing.Size(365, 686);
			this.listViewPatch.TabIndex = 29;
			this.listViewPatch.UseCompatibleStateImageBehavior = false;
			this.listViewPatch.View = global::System.Windows.Forms.View.Details;
			this.listViewPatch.SelectedIndexChanged += new global::System.EventHandler(this.listViewPatch_SelectedIndexChanged);
			this.columnItem.Text = "Name";
			this.columnItem.Width = 169;
			this.columnType.Text = "Type";
			this.columnType.Width = 68;
			this.columnImportId.Text = "Import As";
			this.columnImportId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnImportId.Width = 98;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.listViewPatch);
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
			this.splitContainer1.Panel2.Controls.Add(this.groupPatchOptions);
			this.splitContainer1.Panel2.Controls.Add(this.groupReplaceSelection);
			this.splitContainer1.Size = new global::System.Drawing.Size(643, 686);
			this.splitContainer1.SplitterDistance = 365;
			this.splitContainer1.TabIndex = 30;
			this.pictureBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new global::System.Drawing.Point(0, 262);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(274, 424);
			this.pictureBox.TabIndex = 41;
			this.pictureBox.TabStop = false;
			this.groupPatchOptions.Controls.Add(this.groupMinifaceOptions);
			this.groupPatchOptions.Controls.Add(this.checkTeamLogo);
			this.groupPatchOptions.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupPatchOptions.Location = new global::System.Drawing.Point(0, 144);
			this.groupPatchOptions.Name = "groupPatchOptions";
			this.groupPatchOptions.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.groupPatchOptions.Size = new global::System.Drawing.Size(274, 118);
			this.groupPatchOptions.TabIndex = 40;
			this.groupPatchOptions.TabStop = false;
			this.groupPatchOptions.Text = "Import Options";
			this.groupMinifaceOptions.Controls.Add(this.radioMinifaceAlways);
			this.groupMinifaceOptions.Controls.Add(this.radioMinifaceNotPresent);
			this.groupMinifaceOptions.Controls.Add(this.radioMinifaceNever);
			this.groupMinifaceOptions.Location = new global::System.Drawing.Point(10, 19);
			this.groupMinifaceOptions.Name = "groupMinifaceOptions";
			this.groupMinifaceOptions.Size = new global::System.Drawing.Size(103, 93);
			this.groupMinifaceOptions.TabIndex = 7;
			this.groupMinifaceOptions.TabStop = false;
			this.groupMinifaceOptions.Text = "Miniface";
			this.radioMinifaceAlways.AutoSize = true;
			this.radioMinifaceAlways.Location = new global::System.Drawing.Point(6, 19);
			this.radioMinifaceAlways.Name = "radioMinifaceAlways";
			this.radioMinifaceAlways.Size = new global::System.Drawing.Size(58, 17);
			this.radioMinifaceAlways.TabIndex = 3;
			this.radioMinifaceAlways.Text = "Always";
			this.radioMinifaceAlways.UseVisualStyleBackColor = true;
			this.radioMinifaceNotPresent.AutoSize = true;
			this.radioMinifaceNotPresent.Checked = true;
			this.radioMinifaceNotPresent.Location = new global::System.Drawing.Point(6, 42);
			this.radioMinifaceNotPresent.Name = "radioMinifaceNotPresent";
			this.radioMinifaceNotPresent.Size = new global::System.Drawing.Size(87, 17);
			this.radioMinifaceNotPresent.TabIndex = 4;
			this.radioMinifaceNotPresent.TabStop = true;
			this.radioMinifaceNotPresent.Text = "If not present";
			this.radioMinifaceNotPresent.UseVisualStyleBackColor = true;
			this.radioMinifaceNever.AutoSize = true;
			this.radioMinifaceNever.Location = new global::System.Drawing.Point(6, 65);
			this.radioMinifaceNever.Name = "radioMinifaceNever";
			this.radioMinifaceNever.Size = new global::System.Drawing.Size(54, 17);
			this.radioMinifaceNever.TabIndex = 5;
			this.radioMinifaceNever.Text = "Never";
			this.radioMinifaceNever.UseVisualStyleBackColor = true;
			this.checkTeamLogo.AutoSize = true;
			this.checkTeamLogo.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.checkTeamLogo.Location = new global::System.Drawing.Point(128, 28);
			this.checkTeamLogo.Name = "checkTeamLogo";
			this.checkTeamLogo.Size = new global::System.Drawing.Size(80, 17);
			this.checkTeamLogo.TabIndex = 2;
			this.checkTeamLogo.Text = "Team Logo";
			this.checkTeamLogo.UseVisualStyleBackColor = true;
			this.groupReplaceSelection.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupReplaceSelection.Controls.Add(this.labelEstimatedOverall);
			this.groupReplaceSelection.Controls.Add(this.checkEstimatedOverall);
			this.groupReplaceSelection.Controls.Add(this.labelPatchPlayerOverall);
			this.groupReplaceSelection.Controls.Add(this.labelReplacedPlayerOverall);
			this.groupReplaceSelection.Controls.Add(this.labelCmsCreated);
			this.groupReplaceSelection.Controls.Add(this.labelCmsReplaced);
			this.groupReplaceSelection.Controls.Add(this.textCmsReplaced);
			this.groupReplaceSelection.Controls.Add(this.radioCmsItem);
			this.groupReplaceSelection.Controls.Add(this.comboReplacePlayer);
			this.groupReplaceSelection.Controls.Add(this.comboReplaceTeam);
			this.groupReplaceSelection.Controls.Add(this.radioReplaceItem);
			this.groupReplaceSelection.Controls.Add(this.radioCreateItem);
			this.groupReplaceSelection.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.groupReplaceSelection.Location = new global::System.Drawing.Point(0, 0);
			this.groupReplaceSelection.Name = "groupReplaceSelection";
			this.groupReplaceSelection.Size = new global::System.Drawing.Size(274, 144);
			this.groupReplaceSelection.TabIndex = 38;
			this.groupReplaceSelection.TabStop = false;
			this.groupReplaceSelection.Text = "Replace Selection";
			this.labelCmsCreated.AutoSize = true;
			this.labelCmsCreated.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCmsCreated.ForeColor = global::System.Drawing.Color.Green;
			this.labelCmsCreated.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCmsCreated.Location = new global::System.Drawing.Point(14, 106);
			this.labelCmsCreated.Name = "labelCmsCreated";
			this.labelCmsCreated.Size = new global::System.Drawing.Size(44, 13);
			this.labelCmsCreated.TabIndex = 44;
			this.labelCmsCreated.Text = "Create";
			this.labelCmsCreated.Visible = false;
			this.labelCmsReplaced.AutoSize = true;
			this.labelCmsReplaced.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.labelCmsReplaced.ForeColor = global::System.Drawing.Color.Red;
			this.labelCmsReplaced.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labelCmsReplaced.Location = new global::System.Drawing.Point(14, 106);
			this.labelCmsReplaced.Name = "labelCmsReplaced";
			this.labelCmsReplaced.Size = new global::System.Drawing.Size(54, 13);
			this.labelCmsReplaced.TabIndex = 43;
			this.labelCmsReplaced.Text = "Replace";
			this.labelCmsReplaced.Visible = false;
			this.textCmsReplaced.BackColor = global::System.Drawing.Color.White;
			this.textCmsReplaced.Location = new global::System.Drawing.Point(81, 102);
			this.textCmsReplaced.Name = "textCmsReplaced";
			this.textCmsReplaced.ReadOnly = true;
			this.textCmsReplaced.Size = new global::System.Drawing.Size(178, 20);
			this.textCmsReplaced.TabIndex = 42;
			this.textCmsReplaced.Visible = false;
			this.radioCmsItem.AutoSize = true;
			this.radioCmsItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCmsItem.Location = new global::System.Drawing.Point(10, 83);
			this.radioCmsItem.Name = "radioCmsItem";
			this.radioCmsItem.Size = new global::System.Drawing.Size(87, 17);
			this.radioCmsItem.TabIndex = 41;
			this.radioCmsItem.TabStop = true;
			this.radioCmsItem.Text = "Use Patch Id";
			this.radioCmsItem.UseVisualStyleBackColor = true;
			this.radioCmsItem.CheckedChanged += new global::System.EventHandler(this.radioUsePatchItem_CheckedChanged);
			this.comboReplacePlayer.FormattingEnabled = true;
			this.comboReplacePlayer.Location = new global::System.Drawing.Point(81, 53);
			this.comboReplacePlayer.MaxDropDownItems = 20;
			this.comboReplacePlayer.Name = "comboReplacePlayer";
			this.comboReplacePlayer.Size = new global::System.Drawing.Size(178, 21);
			this.comboReplacePlayer.TabIndex = 4;
			this.comboReplacePlayer.Visible = false;
			this.comboReplacePlayer.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.comboReplaceTeam.FormattingEnabled = true;
			this.comboReplaceTeam.Location = new global::System.Drawing.Point(81, 53);
			this.comboReplaceTeam.MaxDropDownItems = 20;
			this.comboReplaceTeam.Name = "comboReplaceTeam";
			this.comboReplaceTeam.Size = new global::System.Drawing.Size(178, 21);
			this.comboReplaceTeam.TabIndex = 3;
			this.comboReplaceTeam.Visible = false;
			this.comboReplaceTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboReplace_SelectedIndexChanged);
			this.radioReplaceItem.AutoSize = true;
			this.radioReplaceItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioReplaceItem.Location = new global::System.Drawing.Point(10, 53);
			this.radioReplaceItem.Name = "radioReplaceItem";
			this.radioReplaceItem.Size = new global::System.Drawing.Size(65, 17);
			this.radioReplaceItem.TabIndex = 1;
			this.radioReplaceItem.TabStop = true;
			this.radioReplaceItem.Text = "Replace";
			this.radioReplaceItem.UseVisualStyleBackColor = true;
			this.radioReplaceItem.CheckedChanged += new global::System.EventHandler(this.radioReplaceItem_CheckedChanged);
			this.radioCreateItem.AutoSize = true;
			this.radioCreateItem.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radioCreateItem.Location = new global::System.Drawing.Point(10, 23);
			this.radioCreateItem.Name = "radioCreateItem";
			this.radioCreateItem.Size = new global::System.Drawing.Size(56, 17);
			this.radioCreateItem.TabIndex = 0;
			this.radioCreateItem.TabStop = true;
			this.radioCreateItem.Text = "Create";
			this.radioCreateItem.UseVisualStyleBackColor = true;
			this.radioCreateItem.CheckedChanged += new global::System.EventHandler(this.radioCreateItem_CheckedChanged);
			this.labelReplacedPlayerOverall.AutoSize = true;
			this.labelReplacedPlayerOverall.Location = new global::System.Drawing.Point(265, 56);
			this.labelReplacedPlayerOverall.Name = "labelReplacedPlayerOverall";
			this.labelReplacedPlayerOverall.Size = new global::System.Drawing.Size(25, 13);
			this.labelReplacedPlayerOverall.TabIndex = 45;
			this.labelReplacedPlayerOverall.Text = "(50)";
			this.labelReplacedPlayerOverall.Visible = false;
			this.labelPatchPlayerOverall.AutoSize = true;
			this.labelPatchPlayerOverall.Location = new global::System.Drawing.Point(265, 106);
			this.labelPatchPlayerOverall.Name = "labelPatchPlayerOverall";
			this.labelPatchPlayerOverall.Size = new global::System.Drawing.Size(25, 13);
			this.labelPatchPlayerOverall.TabIndex = 46;
			this.labelPatchPlayerOverall.Text = "(50)";
			this.labelPatchPlayerOverall.Visible = false;
			this.checkEstimatedOverall.AutoSize = true;
			this.checkEstimatedOverall.Location = new global::System.Drawing.Point(109, 136);
			this.checkEstimatedOverall.Name = "checkEstimatedOverall";
			this.checkEstimatedOverall.Size = new global::System.Drawing.Size(130, 17);
			this.checkEstimatedOverall.TabIndex = 47;
			this.checkEstimatedOverall.Text = "Use Estimated Overall";
			this.checkEstimatedOverall.UseVisualStyleBackColor = true;
			this.checkEstimatedOverall.Visible = false;
			this.labelEstimatedOverall.AutoSize = true;
			this.labelEstimatedOverall.Location = new global::System.Drawing.Point(265, 137);
			this.labelEstimatedOverall.Name = "labelEstimatedOverall";
			this.labelEstimatedOverall.Size = new global::System.Drawing.Size(25, 13);
			this.labelEstimatedOverall.TabIndex = 48;
			this.labelEstimatedOverall.Text = "(50)";
			this.labelEstimatedOverall.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(643, 711);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.toolMain);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "WebPatchLoader";
			this.Text = "Web-Patch Loader";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.WebPatchLoader_FormClosing);
			this.toolMain.ResumeLayout(false);
			this.toolMain.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			this.groupPatchOptions.ResumeLayout(false);
			this.groupPatchOptions.PerformLayout();
			this.groupMinifaceOptions.ResumeLayout(false);
			this.groupMinifaceOptions.PerformLayout();
			this.groupReplaceSelection.ResumeLayout(false);
			this.groupReplaceSelection.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000551 RID: 1361
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000552 RID: 1362
		private global::System.Windows.Forms.ToolStrip toolMain;

		// Token: 0x04000553 RID: 1363
		private global::System.Windows.Forms.ToolStripButton buttonExitCreator;

		// Token: 0x04000554 RID: 1364
		private global::System.Windows.Forms.ToolStripButton buttonSelectAllObjects;

		// Token: 0x04000555 RID: 1365
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000556 RID: 1366
		private global::System.Windows.Forms.ToolStripButton buttonDeselectAllObjects;

		// Token: 0x04000557 RID: 1367
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000558 RID: 1368
		private global::System.Windows.Forms.ToolStripButton buttonSelectNewObjects;

		// Token: 0x04000559 RID: 1369
		private global::System.Windows.Forms.ListView listViewPatch;

		// Token: 0x0400055A RID: 1370
		private global::System.Windows.Forms.ColumnHeader columnItem;

		// Token: 0x0400055B RID: 1371
		private global::System.Windows.Forms.ColumnHeader columnType;

		// Token: 0x0400055C RID: 1372
		private global::System.Windows.Forms.ColumnHeader columnImportId;

		// Token: 0x0400055D RID: 1373
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400055E RID: 1374
		private global::System.Windows.Forms.GroupBox groupReplaceSelection;

		// Token: 0x0400055F RID: 1375
		private global::System.Windows.Forms.ComboBox comboReplacePlayer;

		// Token: 0x04000560 RID: 1376
		private global::System.Windows.Forms.ComboBox comboReplaceTeam;

		// Token: 0x04000561 RID: 1377
		private global::System.Windows.Forms.RadioButton radioReplaceItem;

		// Token: 0x04000562 RID: 1378
		private global::System.Windows.Forms.RadioButton radioCreateItem;

		// Token: 0x04000563 RID: 1379
		private global::System.Windows.Forms.Label labelCmsCreated;

		// Token: 0x04000564 RID: 1380
		private global::System.Windows.Forms.Label labelCmsReplaced;

		// Token: 0x04000565 RID: 1381
		private global::System.Windows.Forms.TextBox textCmsReplaced;

		// Token: 0x04000566 RID: 1382
		private global::System.Windows.Forms.RadioButton radioCmsItem;

		// Token: 0x04000567 RID: 1383
		private global::System.Windows.Forms.ToolStripButton buttonImportPatch;

		// Token: 0x04000568 RID: 1384
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000569 RID: 1385
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400056A RID: 1386
		private global::System.Windows.Forms.GroupBox groupPatchOptions;

		// Token: 0x0400056B RID: 1387
		private global::System.Windows.Forms.RadioButton radioMinifaceNever;

		// Token: 0x0400056C RID: 1388
		private global::System.Windows.Forms.RadioButton radioMinifaceNotPresent;

		// Token: 0x0400056D RID: 1389
		private global::System.Windows.Forms.RadioButton radioMinifaceAlways;

		// Token: 0x0400056E RID: 1390
		public global::System.Windows.Forms.CheckBox checkTeamLogo;

		// Token: 0x0400056F RID: 1391
		private global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x04000570 RID: 1392
		private global::System.Windows.Forms.GroupBox groupMinifaceOptions;

		// Token: 0x04000571 RID: 1393
		private global::System.Windows.Forms.Label labelEstimatedOverall;

		// Token: 0x04000572 RID: 1394
		private global::System.Windows.Forms.CheckBox checkEstimatedOverall;

		// Token: 0x04000573 RID: 1395
		private global::System.Windows.Forms.Label labelPatchPlayerOverall;

		// Token: 0x04000574 RID: 1396
		private global::System.Windows.Forms.Label labelReplacedPlayerOverall;
	}
}
