namespace CreationMaster
{
	// Token: 0x02000002 RID: 2
	public partial class BallForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002672 File Offset: 0x00000872
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002694 File Offset: 0x00000894
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.BallForm));
			this.group3D = new global::System.Windows.Forms.GroupBox();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.toolNear3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonImport3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonExport3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.buttonRemove3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.buttonCamera = new global::System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new global::System.Windows.Forms.SplitContainer();
			this.multiViewer2DTextures = new global::FifaControls.MultiViewer2D();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.ballBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.labelId = new global::System.Windows.Forms.Label();
			this.checkIsGenericBall = new global::System.Windows.Forms.CheckBox();
			this.labelBallName = new global::System.Windows.Forms.Label();
			this.textBalllName = new global::System.Windows.Forms.TextBox();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.viewer2DBallPicture = new global::FifaControls.Viewer2D();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.group3D.SuspendLayout();
			this.toolNear3D.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ballBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			base.SuspendLayout();
			this.group3D.Controls.Add(this.viewer3D);
			this.group3D.Controls.Add(this.toolNear3D);
			this.group3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.group3D.Location = new global::System.Drawing.Point(0, 0);
			this.group3D.Name = "group3D";
			this.group3D.Size = new global::System.Drawing.Size(833, 558);
			this.group3D.TabIndex = 1;
			this.group3D.TabStop = false;
			this.group3D.Text = "3D Model";
			this.viewer3D.AmbientColor = global::System.Drawing.Color.Black;
			this.viewer3D.BackColor = global::System.Drawing.Color.Gray;
			this.viewer3D.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.viewer3D.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.viewer3D.LightDirectionX = -0.5f;
			this.viewer3D.LightDirectionY = -0.5f;
			this.viewer3D.LightDirectionZ = -1f;
			this.viewer3D.LightX = 30f;
			this.viewer3D.LightY = 30f;
			this.viewer3D.LightZ = 30f;
			this.viewer3D.Location = new global::System.Drawing.Point(3, 16);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 0f;
			this.viewer3D.RotationY = 0f;
			this.viewer3D.RotationYCoeff = 0.01f;
			this.viewer3D.Size = new global::System.Drawing.Size(827, 514);
			this.viewer3D.TabIndex = 1;
			this.viewer3D.ViewX = 0f;
			this.viewer3D.ViewY = 0f;
			this.viewer3D.ViewZ = 30f;
			this.viewer3D.ZbufferRenderState = null;
			this.toolNear3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.toolNear3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolNear3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.toolStripSeparator1, this.buttonImport3DModel, this.buttonExport3DModel, this.toolStripSeparator2, this.buttonRemove3DModel, this.buttonCamera });
			this.toolNear3D.Location = new global::System.Drawing.Point(3, 530);
			this.toolNear3D.Name = "toolNear3D";
			this.toolNear3D.Size = new global::System.Drawing.Size(827, 25);
			this.toolNear3D.TabIndex = 2;
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
			this.buttonImport3DModel.Click += new global::System.EventHandler(this.buttonImportNear3DModel_Click);
			this.buttonExport3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonExport3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonExport3DModel.Image");
			this.buttonExport3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonExport3DModel.Name = "buttonExport3DModel";
			this.buttonExport3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonExport3DModel.Text = "Export 3D Model";
			this.buttonExport3DModel.Click += new global::System.EventHandler(this.buttonExportNear3DModel_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.buttonRemove3DModel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonRemove3DModel.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonRemove3DModel.Image");
			this.buttonRemove3DModel.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonRemove3DModel.Name = "buttonRemove3DModel";
			this.buttonRemove3DModel.Size = new global::System.Drawing.Size(23, 22);
			this.buttonRemove3DModel.Text = "Remove 3D Model";
			this.buttonRemove3DModel.Click += new global::System.EventHandler(this.buttonRemoveNear3DModel_Click);
			this.buttonCamera.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonCamera.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCamera.Image");
			this.buttonCamera.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonCamera.Name = "buttonCamera";
			this.buttonCamera.Size = new global::System.Drawing.Size(23, 22);
			this.buttonCamera.Text = "Picture";
			this.buttonCamera.Click += new global::System.EventHandler(this.buttonCamera_Click);
			this.splitContainer1.BackColor = global::System.Drawing.SystemColors.Control;
			this.splitContainer1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.AutoScroll = true;
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
			this.splitContainer3.Panel1.AutoScroll = true;
			this.splitContainer3.Panel1.Controls.Add(this.multiViewer2DTextures);
			this.splitContainer3.Panel2.AutoScroll = true;
			this.splitContainer3.Panel2.Controls.Add(this.checkBox1);
			this.splitContainer3.Panel2.Controls.Add(this.textBox1);
			this.splitContainer3.Panel2.Controls.Add(this.labelId);
			this.splitContainer3.Panel2.Controls.Add(this.checkIsGenericBall);
			this.splitContainer3.Panel2.Controls.Add(this.labelBallName);
			this.splitContainer3.Panel2.Controls.Add(this.textBalllName);
			this.splitContainer3.Size = new global::System.Drawing.Size(516, 807);
			this.splitContainer3.SplitterDistance = 562;
			this.splitContainer3.TabIndex = 1;
			this.multiViewer2DTextures.AutoTransparency = false;
			this.multiViewer2DTextures.Bitmaps = null;
			this.multiViewer2DTextures.CheckBitmapSize = true;
			this.multiViewer2DTextures.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.multiViewer2DTextures.FixedSize = true;
			this.multiViewer2DTextures.FullSizeButton = true;
			this.multiViewer2DTextures.LabelText = "Texture";
			this.multiViewer2DTextures.Location = new global::System.Drawing.Point(0, 0);
			this.multiViewer2DTextures.Name = "multiViewer2DTextures";
			this.multiViewer2DTextures.ShowDeleteButton = true;
			this.multiViewer2DTextures.Size = new global::System.Drawing.Size(512, 558);
			this.multiViewer2DTextures.TabIndex = 0;
			this.checkBox1.AutoSize = true;
			this.checkBox1.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.ballBindingSource, "IsLicensed", true));
			this.checkBox1.Location = new global::System.Drawing.Point(9, 76);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkBox1.Size = new global::System.Drawing.Size(129, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Licensed                    ";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.ballBindingSource.DataSource = typeof(global::FifaLibrary.Ball);
			this.textBox1.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.ballBindingSource, "Id", true));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new global::System.Drawing.Point(65, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(73, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.labelId.AutoSize = true;
			this.labelId.Location = new global::System.Drawing.Point(10, 6);
			this.labelId.Name = "labelId";
			this.labelId.Size = new global::System.Drawing.Size(16, 13);
			this.labelId.TabIndex = 3;
			this.labelId.Text = "Id";
			this.labelId.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkIsGenericBall.AutoSize = true;
			this.checkIsGenericBall.DataBindings.Add(new global::System.Windows.Forms.Binding("Checked", this.ballBindingSource, "IsAvailable", true));
			this.checkIsGenericBall.Location = new global::System.Drawing.Point(10, 53);
			this.checkIsGenericBall.Name = "checkIsGenericBall";
			this.checkIsGenericBall.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.checkIsGenericBall.Size = new global::System.Drawing.Size(128, 17);
			this.checkIsGenericBall.TabIndex = 2;
			this.checkIsGenericBall.Text = "Visible in Game Menu";
			this.checkIsGenericBall.UseVisualStyleBackColor = true;
			this.labelBallName.AutoSize = true;
			this.labelBallName.Location = new global::System.Drawing.Point(10, 30);
			this.labelBallName.Name = "labelBallName";
			this.labelBallName.Size = new global::System.Drawing.Size(35, 13);
			this.labelBallName.TabIndex = 0;
			this.labelBallName.Text = "Name";
			this.labelBallName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.textBalllName.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", this.ballBindingSource, "Name", true));
			this.textBalllName.Location = new global::System.Drawing.Point(65, 27);
			this.textBalllName.Name = "textBalllName";
			this.textBalllName.Size = new global::System.Drawing.Size(312, 20);
			this.textBalllName.TabIndex = 1;
			this.textBalllName.TextChanged += new global::System.EventHandler(this.textBalllName_TextChanged);
			this.splitContainer2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer2.Panel1.AutoScroll = true;
			this.splitContainer2.Panel1.Controls.Add(this.group3D);
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this.viewer2DBallPicture);
			this.splitContainer2.Size = new global::System.Drawing.Size(837, 807);
			this.splitContainer2.SplitterDistance = 562;
			this.splitContainer2.TabIndex = 0;
			this.viewer2DBallPicture.AutoTransparency = false;
			this.viewer2DBallPicture.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DBallPicture.ButtonStripVisible = true;
			this.viewer2DBallPicture.CurrentBitmap = null;
			this.viewer2DBallPicture.ExtendedFormat = false;
			this.viewer2DBallPicture.FullSizeButton = false;
			this.viewer2DBallPicture.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DBallPicture.ImageSize = new global::System.Drawing.Size(512, 256);
			this.viewer2DBallPicture.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DBallPicture.Location = new global::System.Drawing.Point(3, 3);
			this.viewer2DBallPicture.Name = "viewer2DBallPicture";
			this.viewer2DBallPicture.RemoveButton = false;
			this.viewer2DBallPicture.ShowButton = false;
			this.viewer2DBallPicture.ShowButtonChecked = true;
			this.viewer2DBallPicture.Size = new global::System.Drawing.Size(362, 207);
			this.viewer2DBallPicture.TabIndex = 3;
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
			this.pickUpControl.Size = new global::System.Drawing.Size(1357, 25);
			this.pickUpControl.TabIndex = 0;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1357, 832);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "BallForm";
			this.Text = "Ball";
			base.Load += new global::System.EventHandler(this.BallForm_Load);
			this.group3D.ResumeLayout(false);
			this.group3D.PerformLayout();
			this.toolNear3D.ResumeLayout(false);
			this.toolNear3D.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer3).EndInit();
			this.splitContainer3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.ballBindingSource).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000006 RID: 6
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.GroupBox group3D;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ToolStrip toolNear3D;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ToolStripButton buttonImport3DModel;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ToolStripButton buttonExport3DModel;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ToolStripButton buttonRemove3DModel;

		// Token: 0x0400000C RID: 12
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.TextBox textBalllName;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label labelBallName;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.SplitContainer splitContainer3;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.CheckBox checkIsGenericBall;

		// Token: 0x04000016 RID: 22
		private global::FifaControls.Viewer2D viewer2DBallPicture;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.BindingSource ballBindingSource;

		// Token: 0x04000018 RID: 24
		private global::FifaControls.MultiViewer2D multiViewer2DTextures;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label labelId;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripButton buttonCamera;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
