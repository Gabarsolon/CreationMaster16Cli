namespace FifaLibrary
{
	// Token: 0x020000A1 RID: 161
	public partial class UserOptions : global::System.Windows.Forms.Form
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x00057687 File Offset: 0x00055887
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000576A8 File Offset: 0x000558A8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaLibrary.UserOptions));
			this.textExportFolder = new global::System.Windows.Forms.TextBox();
			this.buttonBrowseExportFolder = new global::System.Windows.Forms.Button();
			this.toolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.checkSaveDb = new global::System.Windows.Forms.CheckBox();
			this.checkSaveZdata = new global::System.Windows.Forms.CheckBox();
			this.checkSaveGui = new global::System.Windows.Forms.CheckBox();
			this.radioAutoZdata = new global::System.Windows.Forms.RadioButton();
			this.radioSpecificZdata = new global::System.Windows.Forms.RadioButton();
			this.numericZdata = new global::System.Windows.Forms.NumericUpDown();
			this.radioGuiSaveArchive = new global::System.Windows.Forms.RadioButton();
			this.radioGuiSaveFolder = new global::System.Windows.Forms.RadioButton();
			this.checkAutoExportFolder = new global::System.Windows.Forms.CheckBox();
			this.radioZdataSaveFolder = new global::System.Windows.Forms.RadioButton();
			this.groupZdataSelection = new global::System.Windows.Forms.GroupBox();
			this.groupAllowSaving = new global::System.Windows.Forms.GroupBox();
			this.groupGuiSaveOptions = new global::System.Windows.Forms.GroupBox();
			this.groupExportFolde = new global::System.Windows.Forms.GroupBox();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.optionsSet = new global::FifaLibrary.Options();
			((global::System.ComponentModel.ISupportInitialize)this.numericZdata).BeginInit();
			this.groupZdataSelection.SuspendLayout();
			this.groupAllowSaving.SuspendLayout();
			this.groupGuiSaveOptions.SuspendLayout();
			this.groupExportFolde.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.optionsSet).BeginInit();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.textExportFolder, "textExportFolder");
			this.textExportFolder.Name = "textExportFolder";
			this.textExportFolder.TextChanged += new global::System.EventHandler(this.textExportFolder_TextChanged);
			componentResourceManager.ApplyResources(this.buttonBrowseExportFolder, "buttonBrowseExportFolder");
			this.buttonBrowseExportFolder.Name = "buttonBrowseExportFolder";
			this.buttonBrowseExportFolder.UseVisualStyleBackColor = true;
			this.buttonBrowseExportFolder.Click += new global::System.EventHandler(this.buttonBrowseExportFolder_Click);
			componentResourceManager.ApplyResources(this.checkSaveDb, "checkSaveDb");
			this.checkSaveDb.Checked = true;
			this.checkSaveDb.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkSaveDb.Name = "checkSaveDb";
			this.toolTip.SetToolTip(this.checkSaveDb, componentResourceManager.GetString("checkSaveDb.ToolTip"));
			this.checkSaveDb.UseVisualStyleBackColor = true;
			this.checkSaveDb.CheckedChanged += new global::System.EventHandler(this.checkEditDb_CheckedChanged);
			componentResourceManager.ApplyResources(this.checkSaveZdata, "checkSaveZdata");
			this.checkSaveZdata.Checked = true;
			this.checkSaveZdata.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkSaveZdata.Name = "checkSaveZdata";
			this.toolTip.SetToolTip(this.checkSaveZdata, componentResourceManager.GetString("checkSaveZdata.ToolTip"));
			this.checkSaveZdata.UseVisualStyleBackColor = true;
			this.checkSaveZdata.CheckedChanged += new global::System.EventHandler(this.checkEditZdata_CheckedChanged);
			componentResourceManager.ApplyResources(this.checkSaveGui, "checkSaveGui");
			this.checkSaveGui.Checked = true;
			this.checkSaveGui.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkSaveGui.Name = "checkSaveGui";
			this.toolTip.SetToolTip(this.checkSaveGui, componentResourceManager.GetString("checkSaveGui.ToolTip"));
			this.checkSaveGui.UseVisualStyleBackColor = true;
			this.checkSaveGui.CheckedChanged += new global::System.EventHandler(this.checkEditGui_CheckedChanged);
			componentResourceManager.ApplyResources(this.radioAutoZdata, "radioAutoZdata");
			this.radioAutoZdata.Checked = true;
			this.radioAutoZdata.Name = "radioAutoZdata";
			this.radioAutoZdata.TabStop = true;
			this.toolTip.SetToolTip(this.radioAutoZdata, componentResourceManager.GetString("radioAutoZdata.ToolTip"));
			this.radioAutoZdata.UseVisualStyleBackColor = true;
			this.radioAutoZdata.CheckedChanged += new global::System.EventHandler(this.radioAutoZdata_CheckedChanged);
			componentResourceManager.ApplyResources(this.radioSpecificZdata, "radioSpecificZdata");
			this.radioSpecificZdata.Name = "radioSpecificZdata";
			this.radioSpecificZdata.TabStop = true;
			this.toolTip.SetToolTip(this.radioSpecificZdata, componentResourceManager.GetString("radioSpecificZdata.ToolTip"));
			this.radioSpecificZdata.UseVisualStyleBackColor = true;
			this.radioSpecificZdata.CheckedChanged += new global::System.EventHandler(this.radioSpecificZdata_CheckedChanged);
			componentResourceManager.ApplyResources(this.numericZdata, "numericZdata");
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericZdata;
			int[] array = new int[4];
			array[0] = 98;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericZdata;
			int[] array2 = new int[4];
			array2[0] = 40;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericZdata.Name = "numericZdata";
			this.toolTip.SetToolTip(this.numericZdata, componentResourceManager.GetString("numericZdata.ToolTip"));
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericZdata;
			int[] array3 = new int[4];
			array3[0] = 49;
			numericUpDown3.Value = new decimal(array3);
			this.numericZdata.ValueChanged += new global::System.EventHandler(this.numericZdata_ValueChanged);
			componentResourceManager.ApplyResources(this.radioGuiSaveArchive, "radioGuiSaveArchive");
			this.radioGuiSaveArchive.Checked = true;
			this.radioGuiSaveArchive.Name = "radioGuiSaveArchive";
			this.radioGuiSaveArchive.TabStop = true;
			this.toolTip.SetToolTip(this.radioGuiSaveArchive, componentResourceManager.GetString("radioGuiSaveArchive.ToolTip"));
			this.radioGuiSaveArchive.UseVisualStyleBackColor = true;
			this.radioGuiSaveArchive.CheckedChanged += new global::System.EventHandler(this.radioGuiSaveArchive_CheckedChanged);
			componentResourceManager.ApplyResources(this.radioGuiSaveFolder, "radioGuiSaveFolder");
			this.radioGuiSaveFolder.Name = "radioGuiSaveFolder";
			this.toolTip.SetToolTip(this.radioGuiSaveFolder, componentResourceManager.GetString("radioGuiSaveFolder.ToolTip"));
			this.radioGuiSaveFolder.UseVisualStyleBackColor = true;
			this.radioGuiSaveFolder.CheckedChanged += new global::System.EventHandler(this.radioGuiSaveFolder_CheckedChanged);
			componentResourceManager.ApplyResources(this.checkAutoExportFolder, "checkAutoExportFolder");
			this.checkAutoExportFolder.Checked = true;
			this.checkAutoExportFolder.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkAutoExportFolder.Name = "checkAutoExportFolder";
			this.toolTip.SetToolTip(this.checkAutoExportFolder, componentResourceManager.GetString("checkAutoExportFolder.ToolTip"));
			this.checkAutoExportFolder.UseVisualStyleBackColor = true;
			this.checkAutoExportFolder.CheckedChanged += new global::System.EventHandler(this.checkAutoExportFolder_CheckedChanged);
			componentResourceManager.ApplyResources(this.radioZdataSaveFolder, "radioZdataSaveFolder");
			this.radioZdataSaveFolder.Name = "radioZdataSaveFolder";
			this.radioZdataSaveFolder.TabStop = true;
			this.toolTip.SetToolTip(this.radioZdataSaveFolder, componentResourceManager.GetString("radioZdataSaveFolder.ToolTip"));
			this.radioZdataSaveFolder.UseVisualStyleBackColor = true;
			this.radioZdataSaveFolder.CheckedChanged += new global::System.EventHandler(this.radioZdataSaveFolder_CheckedChanged);
			this.groupZdataSelection.BackColor = global::System.Drawing.Color.Transparent;
			this.groupZdataSelection.Controls.Add(this.radioZdataSaveFolder);
			this.groupZdataSelection.Controls.Add(this.numericZdata);
			this.groupZdataSelection.Controls.Add(this.radioAutoZdata);
			this.groupZdataSelection.Controls.Add(this.radioSpecificZdata);
			componentResourceManager.ApplyResources(this.groupZdataSelection, "groupZdataSelection");
			this.groupZdataSelection.Name = "groupZdataSelection";
			this.groupZdataSelection.TabStop = false;
			this.groupAllowSaving.BackColor = global::System.Drawing.Color.Transparent;
			this.groupAllowSaving.Controls.Add(this.checkSaveDb);
			this.groupAllowSaving.Controls.Add(this.checkSaveZdata);
			this.groupAllowSaving.Controls.Add(this.checkSaveGui);
			componentResourceManager.ApplyResources(this.groupAllowSaving, "groupAllowSaving");
			this.groupAllowSaving.Name = "groupAllowSaving";
			this.groupAllowSaving.TabStop = false;
			this.groupGuiSaveOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.groupGuiSaveOptions.Controls.Add(this.radioGuiSaveFolder);
			this.groupGuiSaveOptions.Controls.Add(this.radioGuiSaveArchive);
			componentResourceManager.ApplyResources(this.groupGuiSaveOptions, "groupGuiSaveOptions");
			this.groupGuiSaveOptions.Name = "groupGuiSaveOptions";
			this.groupGuiSaveOptions.TabStop = false;
			this.groupExportFolde.BackColor = global::System.Drawing.Color.Transparent;
			this.groupExportFolde.Controls.Add(this.checkAutoExportFolder);
			this.groupExportFolde.Controls.Add(this.textExportFolder);
			this.groupExportFolde.Controls.Add(this.buttonBrowseExportFolder);
			componentResourceManager.ApplyResources(this.groupExportFolde, "groupExportFolde");
			this.groupExportFolde.Name = "groupExportFolde";
			this.groupExportFolde.TabStop = false;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			componentResourceManager.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			componentResourceManager.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.optionsSet.DataSetName = "Options";
			this.optionsSet.Locale = new global::System.Globalization.CultureInfo("");
			this.optionsSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.groupExportFolde);
			base.Controls.Add(this.groupGuiSaveOptions);
			base.Controls.Add(this.groupAllowSaving);
			base.Controls.Add(this.groupZdataSelection);
			base.Name = "UserOptions";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.UserOptions_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.numericZdata).EndInit();
			this.groupZdataSelection.ResumeLayout(false);
			this.groupZdataSelection.PerformLayout();
			this.groupAllowSaving.ResumeLayout(false);
			this.groupAllowSaving.PerformLayout();
			this.groupGuiSaveOptions.ResumeLayout(false);
			this.groupGuiSaveOptions.PerformLayout();
			this.groupExportFolde.ResumeLayout(false);
			this.groupExportFolde.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.optionsSet).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040011D2 RID: 4562
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040011D3 RID: 4563
		private global::System.Windows.Forms.TextBox textExportFolder;

		// Token: 0x040011D4 RID: 4564
		private global::System.Windows.Forms.Button buttonBrowseExportFolder;

		// Token: 0x040011D5 RID: 4565
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x040011D6 RID: 4566
		private global::System.Windows.Forms.CheckBox checkSaveDb;

		// Token: 0x040011D7 RID: 4567
		private global::System.Windows.Forms.CheckBox checkSaveZdata;

		// Token: 0x040011D8 RID: 4568
		private global::System.Windows.Forms.CheckBox checkSaveGui;

		// Token: 0x040011D9 RID: 4569
		private global::System.Windows.Forms.RadioButton radioAutoZdata;

		// Token: 0x040011DA RID: 4570
		private global::System.Windows.Forms.RadioButton radioSpecificZdata;

		// Token: 0x040011DB RID: 4571
		private global::System.Windows.Forms.NumericUpDown numericZdata;

		// Token: 0x040011DC RID: 4572
		private global::System.Windows.Forms.GroupBox groupZdataSelection;

		// Token: 0x040011DD RID: 4573
		private global::System.Windows.Forms.GroupBox groupAllowSaving;

		// Token: 0x040011DE RID: 4574
		private global::System.Windows.Forms.GroupBox groupGuiSaveOptions;

		// Token: 0x040011DF RID: 4575
		private global::System.Windows.Forms.RadioButton radioGuiSaveFolder;

		// Token: 0x040011E0 RID: 4576
		private global::System.Windows.Forms.RadioButton radioGuiSaveArchive;

		// Token: 0x040011E1 RID: 4577
		private global::System.Windows.Forms.GroupBox groupExportFolde;

		// Token: 0x040011E2 RID: 4578
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x040011E3 RID: 4579
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x040011E4 RID: 4580
		private global::System.Windows.Forms.CheckBox checkAutoExportFolder;

		// Token: 0x040011E5 RID: 4581
		private global::FifaLibrary.Options optionsSet;

		// Token: 0x040011E6 RID: 4582
		private global::System.Windows.Forms.RadioButton radioZdataSaveFolder;
	}
}
