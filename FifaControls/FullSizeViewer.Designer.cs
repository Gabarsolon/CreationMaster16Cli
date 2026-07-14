namespace FifaControls
{
	// Token: 0x0200000C RID: 12
	public partial class FullSizeViewer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00009F1C File Offset: 0x0000811C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009F3C File Offset: 0x0000813C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.FullSizeViewer));
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new global::System.Windows.Forms.ToolStripButton();
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.toolStrip.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.toolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripButton1 });
			this.toolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new global::System.Drawing.Size(292, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.toolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton1.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
			this.toolStripButton1.Size = new global::System.Drawing.Size(69, 22);
			this.toolStripButton1.Text = "Close";
			this.toolStripButton1.Click += new global::System.EventHandler(this.toolStripButton1_Click);
			this.pictureBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new global::System.Drawing.Point(0, 25);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(292, 241);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(292, 266);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.toolStrip);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "FullSizeViewer";
			this.Text = "Full Size Viewer";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008A RID: 138
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.ToolStrip toolStrip;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.ToolStripButton toolStripButton1;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.PictureBox pictureBox;
	}
}
