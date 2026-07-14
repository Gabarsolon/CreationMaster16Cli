namespace CreationMaster
{
	// Token: 0x02000009 RID: 9
	public partial class ManagerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000108 RID: 264 RVA: 0x000186FF File Offset: 0x000168FF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00018720 File Offset: 0x00016920
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.ManagerForm));
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.checkManagerCoat = new global::System.Windows.Forms.CheckBox();
			this.comboManagerDress = new global::System.Windows.Forms.ComboBox();
			this.comboManagerSkin = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericManagerColor = new global::System.Windows.Forms.NumericUpDown();
			this.labellManagerSkin = new global::System.Windows.Forms.Label();
			this.viewer2DManager = new global::FifaControls.Viewer2D();
			this.group3D = new global::System.Windows.Forms.GroupBox();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.toolNear3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.comboManagerBodyType = new global::System.Windows.Forms.ToolStripComboBox();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericManagerColor).BeginInit();
			this.group3D.SuspendLayout();
			this.toolNear3D.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.checkManagerCoat);
			this.splitContainer1.Panel1.Controls.Add(this.comboManagerDress);
			this.splitContainer1.Panel1.Controls.Add(this.comboManagerSkin);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.numericManagerColor);
			this.splitContainer1.Panel1.Controls.Add(this.labellManagerSkin);
			this.splitContainer1.Panel1.Controls.Add(this.viewer2DManager);
			this.splitContainer1.Panel2.Controls.Add(this.group3D);
			this.splitContainer1.Size = new global::System.Drawing.Size(1024, 780);
			this.splitContainer1.SplitterDistance = 539;
			this.splitContainer1.TabIndex = 0;
			this.checkManagerCoat.Location = new global::System.Drawing.Point(9, 89);
			this.checkManagerCoat.Name = "checkManagerCoat";
			this.checkManagerCoat.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkManagerCoat.Size = new global::System.Drawing.Size(173, 24);
			this.checkManagerCoat.TabIndex = 87;
			this.checkManagerCoat.Text = "Winter Coat";
			this.checkManagerCoat.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.checkManagerCoat.UseVisualStyleBackColor = true;
			this.checkManagerCoat.CheckedChanged += new global::System.EventHandler(this.checkManagerCoat_CheckedChanged);
			this.comboManagerDress.FormattingEnabled = true;
			this.comboManagerDress.Items.AddRange(new object[] { "Jacket", "Shirt", "Sportswear" });
			this.comboManagerDress.Location = new global::System.Drawing.Point(121, 36);
			this.comboManagerDress.Name = "comboManagerDress";
			this.comboManagerDress.Size = new global::System.Drawing.Size(121, 21);
			this.comboManagerDress.TabIndex = 85;
			this.comboManagerDress.SelectedIndexChanged += new global::System.EventHandler(this.comboManagerDress_SelectedIndexChanged);
			this.comboManagerSkin.FormattingEnabled = true;
			this.comboManagerSkin.Items.AddRange(new object[] { "1 = unused", "Pink", "3 = unused", "Llight Yellow", "Medium Yellow", "Dark Yellow", "7 = unused", "Light Brown", "Medium Brown", "Dark brown" });
			this.comboManagerSkin.Location = new global::System.Drawing.Point(121, 9);
			this.comboManagerSkin.Name = "comboManagerSkin";
			this.comboManagerSkin.Size = new global::System.Drawing.Size(121, 21);
			this.comboManagerSkin.TabIndex = 84;
			this.comboManagerSkin.SelectedIndexChanged += new global::System.EventHandler(this.comboManagerSkin_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.SystemColors.Control;
			this.label2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new global::System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 13);
			this.label2.TabIndex = 82;
			this.label2.Text = "Dress Color";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.SystemColors.Control;
			this.label1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new global::System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(61, 13);
			this.label1.TabIndex = 81;
			this.label1.Text = "Dress Type";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.numericManagerColor.Location = new global::System.Drawing.Point(121, 63);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericManagerColor;
			int[] array = new int[4];
			array[0] = 1;
			numericUpDown.Maximum = new decimal(array);
			this.numericManagerColor.Name = "numericManagerColor";
			this.numericManagerColor.Size = new global::System.Drawing.Size(121, 20);
			this.numericManagerColor.TabIndex = 79;
			this.numericManagerColor.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericManagerColor.ValueChanged += new global::System.EventHandler(this.numericManager3_ValueChanged);
			this.labellManagerSkin.AutoSize = true;
			this.labellManagerSkin.BackColor = global::System.Drawing.SystemColors.Control;
			this.labellManagerSkin.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.labellManagerSkin.Location = new global::System.Drawing.Point(11, 12);
			this.labellManagerSkin.Name = "labellManagerSkin";
			this.labellManagerSkin.Size = new global::System.Drawing.Size(28, 13);
			this.labellManagerSkin.TabIndex = 76;
			this.labellManagerSkin.Text = "Skin";
			this.labellManagerSkin.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.viewer2DManager.AutoTransparency = false;
			this.viewer2DManager.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DManager.ButtonStripVisible = true;
			this.viewer2DManager.CurrentBitmap = null;
			this.viewer2DManager.ExtendedFormat = false;
			this.viewer2DManager.FullSizeButton = true;
			this.viewer2DManager.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DManager.ImageSize = new global::System.Drawing.Size(1024, 1024);
			this.viewer2DManager.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DManager.Location = new global::System.Drawing.Point(14, 127);
			this.viewer2DManager.Name = "viewer2DManager";
			this.viewer2DManager.RemoveButton = false;
			this.viewer2DManager.ShowButton = false;
			this.viewer2DManager.ShowButtonChecked = true;
			this.viewer2DManager.Size = new global::System.Drawing.Size(512, 537);
			this.viewer2DManager.TabIndex = 3;
			this.viewer2DManager.TabStop = false;
			this.group3D.Controls.Add(this.viewer3D);
			this.group3D.Controls.Add(this.toolNear3D);
			this.group3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.group3D.Location = new global::System.Drawing.Point(0, 0);
			this.group3D.Name = "group3D";
			this.group3D.Size = new global::System.Drawing.Size(481, 780);
			this.group3D.TabIndex = 2;
			this.group3D.TabStop = false;
			this.group3D.Text = "3D Model";
			this.viewer3D.AmbientColor = global::System.Drawing.Color.Black;
			this.viewer3D.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer3D.LightDirectionX = 0.5f;
			this.viewer3D.LightDirectionY = -0.25f;
			this.viewer3D.LightDirectionZ = -1f;
			this.viewer3D.LightX = -30f;
			this.viewer3D.LightY = 180f;
			this.viewer3D.LightZ = 30f;
			this.viewer3D.Location = new global::System.Drawing.Point(3, 16);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 0f;
			this.viewer3D.RotationY = 6.28f;
			this.viewer3D.RotationYCoeff = 0.01f;
			this.viewer3D.Size = new global::System.Drawing.Size(475, 736);
			this.viewer3D.TabIndex = 1;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 90f;
			this.viewer3D.ViewZ = 270f;
			this.viewer3D.ZbufferRenderState = null;
			this.toolNear3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.toolNear3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolNear3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.comboManagerBodyType });
			this.toolNear3D.Location = new global::System.Drawing.Point(3, 752);
			this.toolNear3D.Name = "toolNear3D";
			this.toolNear3D.Size = new global::System.Drawing.Size(475, 25);
			this.toolNear3D.TabIndex = 2;
			this.buttonShow3DModel.CheckOnClick = true;
			this.buttonShow3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShow3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonShow3DModel.Image");
			this.buttonShow3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonShow3DModel.Name = "buttonShow3DModel";
			this.buttonShow3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonShow3DModel.Text = "Show / Hide";
			this.buttonShow3DModel.Click += new global::System.EventHandler(this.buttonShow3DModel_Click);
			this.comboManagerBodyType.Items.AddRange(new object[] { "Average", "Lean", "Stocky" });
			this.comboManagerBodyType.Name = "comboManagerBodyType";
			this.comboManagerBodyType.Size = new global::System.Drawing.Size(121, 25);
			this.comboManagerBodyType.SelectedIndexChanged += new global::System.EventHandler(this.comboManagerBodyType_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1024, 780);
			base.Controls.Add(this.splitContainer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ManagerForm";
			this.Text = "ManagerForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericManagerColor).EndInit();
			this.group3D.ResumeLayout(false);
			this.group3D.PerformLayout();
			this.toolNear3D.ResumeLayout(false);
			this.toolNear3D.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000189 RID: 393
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400018B RID: 395
		private global::FifaControls.Viewer2D viewer2DManager;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.Label labellManagerSkin;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.NumericUpDown numericManagerColor;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.GroupBox group3D;

		// Token: 0x0400018F RID: 399
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.ToolStrip toolNear3D;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.CheckBox checkManagerCoat;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.ComboBox comboManagerDress;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Forms.ComboBox comboManagerSkin;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.ToolStripComboBox comboManagerBodyType;
	}
}
