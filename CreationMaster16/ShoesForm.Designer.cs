namespace CreationMaster
{
	// Token: 0x02000019 RID: 25
	public partial class ShoesForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x0005FAE6 File Offset: 0x0005DCE6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0005FB08 File Offset: 0x0005DD08
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.ShoesForm));
			this.group3D = new global::System.Windows.Forms.GroupBox();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.tool3DModel = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImport3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExport3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonRemove3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.checkShoesGender = new global::System.Windows.Forms.CheckBox();
			this.checkIsAvailableInStore = new global::System.Windows.Forms.CheckBox();
			this.textShoesType = new global::System.Windows.Forms.TextBox();
			this.labelId = new global::System.Windows.Forms.Label();
			this.textShoesName = new global::System.Windows.Forms.TextBox();
			this.numericShoesColor = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.multiViewer2DShoesColor = new global::FifaControls.MultiViewer2D();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textShoesShopPackage = new global::System.Windows.Forms.TextBox();
			this.group3D.SuspendLayout();
			this.tool3DModel.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesColor).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.group3D.Controls.Add(this.viewer3D);
			this.group3D.Controls.Add(this.tool3DModel);
			this.group3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.group3D.Location = new global::System.Drawing.Point(0, 0);
			this.group3D.Name = "group3D";
			this.group3D.Size = new global::System.Drawing.Size(516, 755);
			this.group3D.TabIndex = 2;
			this.group3D.TabStop = false;
			this.group3D.Text = "3D Model";
			this.viewer3D.AmbientColor = global::System.Drawing.Color.DimGray;
			this.viewer3D.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer3D.LightDirectionX = 0.5f;
			this.viewer3D.LightDirectionY = -0.25f;
			this.viewer3D.LightDirectionZ = -1f;
			this.viewer3D.LightX = -30f;
			this.viewer3D.LightY = 10f;
			this.viewer3D.LightZ = 50f;
			this.viewer3D.Location = new global::System.Drawing.Point(3, 16);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 0.43f;
			this.viewer3D.RotationY = 0.23f;
			this.viewer3D.RotationYCoeff = 0.01f;
			this.viewer3D.Size = new global::System.Drawing.Size(510, 711);
			this.viewer3D.TabIndex = 1;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 0f;
			this.viewer3D.ViewZ = 64f;
			this.viewer3D.ZbufferRenderState = null;
			this.tool3DModel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.tool3DModel.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tool3DModel.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.toolStripSeparator1, this.buttonImport3DModel, this.buttonExport3DModel, this.toolStripSeparator2, this.buttonRemove3DModel });
			this.tool3DModel.Location = new global::System.Drawing.Point(3, 727);
			this.tool3DModel.Name = "tool3DModel";
			this.tool3DModel.Size = new global::System.Drawing.Size(510, 25);
			this.tool3DModel.TabIndex = 2;
			this.buttonShow3DModel.CheckOnClick = true;
			this.buttonShow3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DModel.Image");
			this.buttonShow3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DModel.Name = "buttonShow3DModel";
			this.buttonShow3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DModel.Text = "Show / Hide";
			this.buttonShow3DModel.Click += new global::System.EventHandler(this.buttonShow3DModel_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.buttonImport3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImport3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImport3DModel.Image");
			this.buttonImport3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImport3DModel.Name = "buttonImport3DModel";
			this.buttonImport3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonImport3DModel.Text = "Import 3D Model";
			this.buttonImport3DModel.Click += new global::System.EventHandler(this.buttonImport3DModel_Click);
			this.buttonExport3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExport3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExport3DModel.Image");
			this.buttonExport3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExport3DModel.Name = "buttonExport3DModel";
			this.buttonExport3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExport3DModel.Text = "Export 3D Model";
			this.buttonExport3DModel.Click += new global::System.EventHandler(this.buttonExport3DModel_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonRemove3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemove3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemove3DModel.Image");
			this.buttonRemove3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemove3DModel.Name = "buttonRemove3DModel";
			this.buttonRemove3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemove3DModel.Text = "Remove 3D Model";
			this.buttonRemove3DModel.Click += new global::System.EventHandler(this.buttonRemove3DModel_Click);
			this.panel1.Controls.Add(this.textShoesShopPackage);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.checkShoesGender);
			this.panel1.Controls.Add(this.checkIsAvailableInStore);
			this.panel1.Controls.Add(this.textShoesType);
			this.panel1.Controls.Add(this.labelId);
			this.panel1.Controls.Add(this.textShoesName);
			this.panel1.Controls.Add(this.numericShoesColor);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.multiViewer2DShoesColor);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new global::System.Drawing.Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(520, 755);
			this.panel1.TabIndex = 3;
			this.checkShoesGender.AutoSize = true;
			this.checkShoesGender.Location = new global::System.Drawing.Point(164, 644);
			this.checkShoesGender.Name = "checkShoesGender";
			this.checkShoesGender.Size = new global::System.Drawing.Size(111, 17);
			this.checkShoesGender.TabIndex = 66;
			this.checkShoesGender.Text = "Shoes for Woman";
			this.checkShoesGender.UseVisualStyleBackColor = true;
			this.checkShoesGender.CheckedChanged += new global::System.EventHandler(this.checkShoesGender_CheckedChanged);
			this.checkIsAvailableInStore.AutoSize = true;
			this.checkIsAvailableInStore.Location = new global::System.Drawing.Point(164, 621);
			this.checkIsAvailableInStore.Name = "checkIsAvailableInStore";
			this.checkIsAvailableInStore.Size = new global::System.Drawing.Size(80, 17);
			this.checkIsAvailableInStore.TabIndex = 0;
			this.checkIsAvailableInStore.Text = "Is Available";
			this.checkIsAvailableInStore.UseVisualStyleBackColor = true;
			this.checkIsAvailableInStore.CheckedChanged += new global::System.EventHandler(this.checkIsAvailableInStore_CheckedChanged);
			this.textShoesType.Enabled = false;
			this.textShoesType.Location = new global::System.Drawing.Point(76, 619);
			this.textShoesType.Name = "textShoesType";
			this.textShoesType.Size = new global::System.Drawing.Size(73, 20);
			this.textShoesType.TabIndex = 65;
			this.textShoesType.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelId.AutoSize = true;
			this.labelId.Location = new global::System.Drawing.Point(10, 622);
			this.labelId.Name = "labelId";
			this.labelId.Size = new global::System.Drawing.Size(49, 13);
			this.labelId.TabIndex = 64;
			this.labelId.Text = "Shoes Id";
			this.labelId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textShoesName.Location = new global::System.Drawing.Point(76, 593);
			this.textShoesName.Name = "textShoesName";
			this.textShoesName.Size = new global::System.Drawing.Size(438, 20);
			this.textShoesName.TabIndex = 0;
			this.textShoesName.TextChanged += new global::System.EventHandler(this.textShoesName_TextChanged);
			this.numericShoesColor.Location = new global::System.Drawing.Point(51, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericShoesColor;
			int[] array = new int[4];
			array[0] = 3;
			numericUpDown.Maximum = new decimal(array);
			this.numericShoesColor.Name = "numericShoesColor";
			this.numericShoesColor.Size = new global::System.Drawing.Size(76, 20);
			this.numericShoesColor.TabIndex = 63;
			this.numericShoesColor.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericShoesColor;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
			this.numericShoesColor.ValueChanged += new global::System.EventHandler(this.numericShoesColor_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(31, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Color";
			this.multiViewer2DShoesColor.AutoTransparency = false;
			this.multiViewer2DShoesColor.Bitmaps = null;
			this.multiViewer2DShoesColor.CheckBitmapSize = true;
			this.multiViewer2DShoesColor.FixedSize = true;
			this.multiViewer2DShoesColor.FullSizeButton = false;
			this.multiViewer2DShoesColor.LabelText = "Texture";
			this.multiViewer2DShoesColor.Location = new global::System.Drawing.Point(3, 28);
			this.multiViewer2DShoesColor.Name = "multiViewer2DShoesColor";
			this.multiViewer2DShoesColor.ShowDeleteButton = true;
			this.multiViewer2DShoesColor.Size = new global::System.Drawing.Size(512, 559);
			this.multiViewer2DShoesColor.TabIndex = 1;
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = true;
			this.pickUpControl.CreateButtonEnabled = false;
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
			this.pickUpControl.SearchEnabled = false;
			this.pickUpControl.Size = new global::System.Drawing.Size(1036, 25);
			this.pickUpControl.TabIndex = 1;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			this.panel2.Controls.Add(this.group3D);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new global::System.Drawing.Point(520, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(516, 755);
			this.panel2.TabIndex = 4;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(10, 596);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(60, 13);
			this.label2.TabIndex = 67;
			this.label2.Text = "Description";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textShoesShopPackage.Location = new global::System.Drawing.Point(13, 644);
			this.textShoesShopPackage.Name = "textShoesShopPackage";
			this.textShoesShopPackage.ReadOnly = true;
			this.textShoesShopPackage.Size = new global::System.Drawing.Size(136, 20);
			this.textShoesShopPackage.TabIndex = 68;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1036, 780);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ShoesForm";
			this.Text = "ShoesForm";
			base.Load += new global::System.EventHandler(this.ShoesForm_Load);
			this.group3D.ResumeLayout(false);
			this.group3D.PerformLayout();
			this.tool3DModel.ResumeLayout(false);
			this.tool3DModel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericShoesColor).EndInit();
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040005EC RID: 1516
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040005ED RID: 1517
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x040005EE RID: 1518
		private global::FifaControls.MultiViewer2D multiViewer2DShoesColor;

		// Token: 0x040005EF RID: 1519
		private global::System.Windows.Forms.GroupBox group3D;

		// Token: 0x040005F0 RID: 1520
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x040005F1 RID: 1521
		private global::System.Windows.Forms.ToolStrip tool3DModel;

		// Token: 0x040005F2 RID: 1522
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x040005F3 RID: 1523
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040005F4 RID: 1524
		private global::System.Windows.Forms.ToolStripButton buttonImport3DModel;

		// Token: 0x040005F5 RID: 1525
		private global::System.Windows.Forms.ToolStripButton buttonExport3DModel;

		// Token: 0x040005F6 RID: 1526
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040005F7 RID: 1527
		private global::System.Windows.Forms.ToolStripButton buttonRemove3DModel;

		// Token: 0x040005F8 RID: 1528
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040005F9 RID: 1529
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040005FA RID: 1530
		public global::System.Windows.Forms.NumericUpDown numericShoesColor;

		// Token: 0x040005FB RID: 1531
		private global::System.Windows.Forms.TextBox textShoesName;

		// Token: 0x040005FC RID: 1532
		private global::System.Windows.Forms.TextBox textShoesType;

		// Token: 0x040005FD RID: 1533
		private global::System.Windows.Forms.Label labelId;

		// Token: 0x040005FE RID: 1534
		private global::System.Windows.Forms.CheckBox checkIsAvailableInStore;

		// Token: 0x040005FF RID: 1535
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000600 RID: 1536
		private global::System.Windows.Forms.CheckBox checkShoesGender;

		// Token: 0x04000601 RID: 1537
		private global::System.Windows.Forms.TextBox textShoesShopPackage;

		// Token: 0x04000602 RID: 1538
		private global::System.Windows.Forms.Label label2;
	}
}
