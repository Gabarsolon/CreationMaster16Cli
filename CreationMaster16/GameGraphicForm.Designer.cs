namespace CreationMaster
{
	// Token: 0x02000004 RID: 4
	public partial class GameGraphicForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00007072 File Offset: 0x00005272
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007094 File Offset: 0x00005294
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.GameGraphicForm));
			this.groupMenu = new global::System.Windows.Forms.GroupBox();
			this.buttonSaveStartGraphics = new global::System.Windows.Forms.Button();
			this.viewer2DMessi = new global::FifaControls.Viewer2D();
			this.viewer2DFifa = new global::FifaControls.Viewer2D();
			this.multiViewerMenuPictures = new global::FifaControls.MultiViewer2D();
			this.multiViewerIcons = new global::FifaControls.MultiViewer2D();
			this.groupIcons = new global::System.Windows.Forms.GroupBox();
			this.viewer2DIcons = new global::FifaControls.Viewer2D();
			this.numericIcons = new global::System.Windows.Forms.NumericUpDown();
			this.labelTextIcons = new global::System.Windows.Forms.Label();
			this.groupMenu.SuspendLayout();
			this.groupIcons.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericIcons).BeginInit();
			base.SuspendLayout();
			this.groupMenu.Controls.Add(this.buttonSaveStartGraphics);
			this.groupMenu.Controls.Add(this.viewer2DMessi);
			this.groupMenu.Controls.Add(this.viewer2DFifa);
			this.groupMenu.Location = new global::System.Drawing.Point(3, 3);
			this.groupMenu.Name = "groupMenu";
			this.groupMenu.Size = new global::System.Drawing.Size(534, 308);
			this.groupMenu.TabIndex = 2;
			this.groupMenu.TabStop = false;
			this.groupMenu.Text = "Start";
			this.buttonSaveStartGraphics.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSaveStartGraphics.Image");
			this.buttonSaveStartGraphics.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSaveStartGraphics.Location = new global::System.Drawing.Point(352, 209);
			this.buttonSaveStartGraphics.Name = "buttonSaveStartGraphics";
			this.buttonSaveStartGraphics.Size = new global::System.Drawing.Size(75, 23);
			this.buttonSaveStartGraphics.TabIndex = 2;
			this.buttonSaveStartGraphics.Text = "Save";
			this.buttonSaveStartGraphics.UseVisualStyleBackColor = true;
			this.buttonSaveStartGraphics.Click += new global::System.EventHandler(this.buttonSaveStartGraphics_Click);
			this.viewer2DMessi.AutoTransparency = false;
			this.viewer2DMessi.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DMessi.ButtonStripVisible = true;
			this.viewer2DMessi.CurrentBitmap = null;
			this.viewer2DMessi.ExtendedFormat = false;
			this.viewer2DMessi.FullSizeButton = true;
			this.viewer2DMessi.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DMessi.ImageSize = new global::System.Drawing.Size(2048, 2048);
			this.viewer2DMessi.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DMessi.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DMessi.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DMessi.Name = "viewer2DMessi";
			this.viewer2DMessi.RemoveButton = false;
			this.viewer2DMessi.ShowButton = true;
			this.viewer2DMessi.ShowButtonChecked = true;
			this.viewer2DMessi.Size = new global::System.Drawing.Size(256, 281);
			this.viewer2DMessi.TabIndex = 0;
			this.viewer2DFifa.AutoTransparency = false;
			this.viewer2DFifa.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DFifa.ButtonStripVisible = true;
			this.viewer2DFifa.CurrentBitmap = null;
			this.viewer2DFifa.ExtendedFormat = false;
			this.viewer2DFifa.FullSizeButton = true;
			this.viewer2DFifa.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DFifa.ImageSize = new global::System.Drawing.Size(1024, 512);
			this.viewer2DFifa.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DFifa.Location = new global::System.Drawing.Point(268, 19);
			this.viewer2DFifa.Margin = new global::System.Windows.Forms.Padding(4);
			this.viewer2DFifa.Name = "viewer2DFifa";
			this.viewer2DFifa.RemoveButton = false;
			this.viewer2DFifa.ShowButton = true;
			this.viewer2DFifa.ShowButtonChecked = true;
			this.viewer2DFifa.Size = new global::System.Drawing.Size(256, 153);
			this.viewer2DFifa.TabIndex = 1;
			this.multiViewerMenuPictures.AutoTransparency = false;
			this.multiViewerMenuPictures.Bitmaps = null;
			this.multiViewerMenuPictures.CheckBitmapSize = false;
			this.multiViewerMenuPictures.FixedSize = false;
			this.multiViewerMenuPictures.FullSizeButton = false;
			this.multiViewerMenuPictures.LabelText = "Image n.";
			this.multiViewerMenuPictures.Location = new global::System.Drawing.Point(542, 10);
			this.multiViewerMenuPictures.Margin = new global::System.Windows.Forms.Padding(2);
			this.multiViewerMenuPictures.Name = "multiViewerMenuPictures";
			this.multiViewerMenuPictures.ShowButton = false;
			this.multiViewerMenuPictures.ShowDeleteButton = true;
			this.multiViewerMenuPictures.Size = new global::System.Drawing.Size(384, 457);
			this.multiViewerMenuPictures.TabIndex = 3;
			this.multiViewerIcons.AutoTransparency = false;
			this.multiViewerIcons.Bitmaps = null;
			this.multiViewerIcons.CheckBitmapSize = false;
			this.multiViewerIcons.FixedSize = false;
			this.multiViewerIcons.FullSizeButton = false;
			this.multiViewerIcons.LabelText = "Image n.";
			this.multiViewerIcons.Location = new global::System.Drawing.Point(950, 320);
			this.multiViewerIcons.Margin = new global::System.Windows.Forms.Padding(2);
			this.multiViewerIcons.Name = "multiViewerIcons";
			this.multiViewerIcons.ShowButton = false;
			this.multiViewerIcons.ShowDeleteButton = true;
			this.multiViewerIcons.Size = new global::System.Drawing.Size(280, 336);
			this.multiViewerIcons.TabIndex = 4;
			this.groupIcons.Controls.Add(this.numericIcons);
			this.groupIcons.Controls.Add(this.labelTextIcons);
			this.groupIcons.Controls.Add(this.viewer2DIcons);
			this.groupIcons.Location = new global::System.Drawing.Point(6, 318);
			this.groupIcons.Name = "groupIcons";
			this.groupIcons.Size = new global::System.Drawing.Size(534, 338);
			this.groupIcons.TabIndex = 9;
			this.groupIcons.TabStop = false;
			this.groupIcons.Text = "Icons";
			this.viewer2DIcons.AutoTransparency = false;
			this.viewer2DIcons.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DIcons.ButtonStripVisible = true;
			this.viewer2DIcons.CurrentBitmap = null;
			this.viewer2DIcons.ExtendedFormat = false;
			this.viewer2DIcons.FullSizeButton = false;
			this.viewer2DIcons.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DIcons.ImageSize = new global::System.Drawing.Size(256, 256);
			this.viewer2DIcons.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DIcons.Location = new global::System.Drawing.Point(9, 46);
			this.viewer2DIcons.Name = "viewer2DIcons";
			this.viewer2DIcons.RemoveButton = true;
			this.viewer2DIcons.ShowButton = true;
			this.viewer2DIcons.ShowButtonChecked = true;
			this.viewer2DIcons.Size = new global::System.Drawing.Size(256, 283);
			this.viewer2DIcons.TabIndex = 6;
			this.numericIcons.Location = new global::System.Drawing.Point(23, 17);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericIcons;
			int[] array = new int[4];
			array[0] = 216;
			numericUpDown.Maximum = new decimal(array);
			this.numericIcons.Name = "numericIcons";
			this.numericIcons.Size = new global::System.Drawing.Size(113, 20);
			this.numericIcons.TabIndex = 11;
			this.numericIcons.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericIcons.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.labelTextIcons.AutoSize = true;
			this.labelTextIcons.Location = new global::System.Drawing.Point(154, 21);
			this.labelTextIcons.Name = "labelTextIcons";
			this.labelTextIcons.Size = new global::System.Drawing.Size(35, 13);
			this.labelTextIcons.TabIndex = 10;
			this.labelTextIcons.Text = "label2";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1024, 780);
			base.Controls.Add(this.groupIcons);
			base.Controls.Add(this.multiViewerIcons);
			base.Controls.Add(this.multiViewerMenuPictures);
			base.Controls.Add(this.groupMenu);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "GameGraphicForm";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.GameGraphicForm_Load);
			this.groupMenu.ResumeLayout(false);
			this.groupIcons.ResumeLayout(false);
			this.groupIcons.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericIcons).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000054 RID: 84
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000055 RID: 85
		private global::FifaControls.Viewer2D viewer2DMessi;

		// Token: 0x04000056 RID: 86
		private global::FifaControls.Viewer2D viewer2DFifa;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.GroupBox groupMenu;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Button buttonSaveStartGraphics;

		// Token: 0x04000059 RID: 89
		private global::FifaControls.MultiViewer2D multiViewerMenuPictures;

		// Token: 0x0400005A RID: 90
		private global::FifaControls.MultiViewer2D multiViewerIcons;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.GroupBox groupIcons;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.NumericUpDown numericIcons;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label labelTextIcons;

		// Token: 0x0400005E RID: 94
		private global::FifaControls.Viewer2D viewer2DIcons;
	}
}
