namespace CreationMaster
{
	// Token: 0x02000006 RID: 6
	public partial class GlovesForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000DCD5 File Offset: 0x0000BED5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.GlovesForm));
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.multiViewer2DGkGloves = new global::FifaControls.MultiViewer2D();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.viewer3D = new global::FifaControls.Viewer3D();
			this.toolNear3D = new global::System.Windows.Forms.ToolStrip();
			this.buttonShow3DModel = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.toolNear3D.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.multiViewer2DGkGloves);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new global::System.Drawing.Size(1165, 773);
			this.splitContainer1.SplitterDistance = 516;
			this.splitContainer1.TabIndex = 1;
			this.multiViewer2DGkGloves.AutoTransparency = false;
			this.multiViewer2DGkGloves.Bitmaps = null;
			this.multiViewer2DGkGloves.CheckBitmapSize = true;
			this.multiViewer2DGkGloves.FixedSize = false;
			this.multiViewer2DGkGloves.FullSizeButton = false;
			this.multiViewer2DGkGloves.LabelText = "Image n.";
			this.multiViewer2DGkGloves.Location = new global::System.Drawing.Point(3, 6);
			this.multiViewer2DGkGloves.Name = "multiViewer2DGkGloves";
			this.multiViewer2DGkGloves.ShowDeleteButton = true;
			this.multiViewer2DGkGloves.Size = new global::System.Drawing.Size(512, 304);
			this.multiViewer2DGkGloves.TabIndex = 0;
			this.multiViewer2DGkGloves.Load += new global::System.EventHandler(this.GkGlovesForm_Load);
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer2.Panel1.Controls.Add(this.viewer3D);
			this.splitContainer2.Panel1.Controls.Add(this.toolNear3D);
			this.splitContainer2.Size = new global::System.Drawing.Size(645, 773);
			this.splitContainer2.SplitterDistance = 503;
			this.splitContainer2.TabIndex = 0;
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
			this.viewer3D.Location = new global::System.Drawing.Point(0, 0);
			this.viewer3D.Name = "viewer3D";
			this.viewer3D.RotationX = 0.18f;
			this.viewer3D.RotationY = 0.93f;
			this.viewer3D.RotationYCoeff = 0.01f;
			this.viewer3D.Size = new global::System.Drawing.Size(645, 478);
			this.viewer3D.TabIndex = 3;
			this.viewer3D.ViewX = 12f;
			this.viewer3D.ViewY = 110f;
			this.viewer3D.ViewZ = 114.2f;
			this.viewer3D.ZbufferRenderState = null;
			this.toolNear3D.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.toolNear3D.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolNear3D.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonShow3DModel, this.toolStripSeparator1 });
			this.toolNear3D.Location = new global::System.Drawing.Point(0, 478);
			this.toolNear3D.Name = "toolNear3D";
			this.toolNear3D.Size = new global::System.Drawing.Size(645, 25);
			this.toolNear3D.TabIndex = 4;
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
			this.pickUpControl.Size = new global::System.Drawing.Size(1165, 25);
			this.pickUpControl.TabIndex = 0;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1165, 798);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "GlovesForm";
			this.Text = "GlovesForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.toolNear3D.ResumeLayout(false);
			this.toolNear3D.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000DE RID: 222
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000DF RID: 223
		public global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x040000E2 RID: 226
		private global::FifaControls.MultiViewer2D multiViewer2DGkGloves;

		// Token: 0x040000E3 RID: 227
		private global::FifaControls.Viewer3D viewer3D;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.ToolStrip toolNear3D;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.ToolStripButton buttonShow3DModel;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}
