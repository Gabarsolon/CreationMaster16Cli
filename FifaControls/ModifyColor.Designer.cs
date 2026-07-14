namespace FifaControls
{
	// Token: 0x02000007 RID: 7
	public partial class ModifyColor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00005DE5 File Offset: 0x00003FE5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005E04 File Offset: 0x00004004
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.contextMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuSampleRGB = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuApplyRGB = new global::System.Windows.Forms.ToolStripMenuItem();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.trackBarRed = new global::System.Windows.Forms.TrackBar();
			this.label4 = new global::System.Windows.Forms.Label();
			this.trackBarGreen = new global::System.Windows.Forms.TrackBar();
			this.trackBarBlue = new global::System.Windows.Forms.TrackBar();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.buttonReset = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			this.contextMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).BeginInit();
			base.SuspendLayout();
			this.pictureBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox.ContextMenuStrip = this.contextMenu;
			this.pictureBox.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(256, 256);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
			this.contextMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.menuSampleRGB, this.menuApplyRGB });
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new global::System.Drawing.Size(139, 48);
			this.menuSampleRGB.Name = "menuSampleRGB";
			this.menuSampleRGB.Size = new global::System.Drawing.Size(138, 22);
			this.menuSampleRGB.Text = "Sample RGB";
			this.menuSampleRGB.Click += new global::System.EventHandler(this.menuSampleRGB_Click);
			this.menuApplyRGB.Name = "menuApplyRGB";
			this.menuApplyRGB.Size = new global::System.Drawing.Size(138, 22);
			this.menuApplyRGB.Text = "Apply RGB";
			this.menuApplyRGB.Click += new global::System.EventHandler(this.menuApplyRGB_Click);
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(12, 456);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(197, 454);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.trackBarRed.LargeChange = 25;
			this.trackBarRed.Location = new global::System.Drawing.Point(55, 315);
			this.trackBarRed.Maximum = 250;
			this.trackBarRed.Minimum = -250;
			this.trackBarRed.Name = "trackBarRed";
			this.trackBarRed.Size = new global::System.Drawing.Size(217, 45);
			this.trackBarRed.TabIndex = 6;
			this.trackBarRed.TickFrequency = 25;
			this.trackBarRed.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(158, 414);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(13, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "0";
			this.trackBarGreen.LargeChange = 25;
			this.trackBarGreen.Location = new global::System.Drawing.Point(55, 360);
			this.trackBarGreen.Maximum = 250;
			this.trackBarGreen.Minimum = -250;
			this.trackBarGreen.Name = "trackBarGreen";
			this.trackBarGreen.Size = new global::System.Drawing.Size(217, 45);
			this.trackBarGreen.TabIndex = 8;
			this.trackBarGreen.TickFrequency = 25;
			this.trackBarGreen.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
			this.trackBarBlue.LargeChange = 25;
			this.trackBarBlue.Location = new global::System.Drawing.Point(55, 405);
			this.trackBarBlue.Maximum = 250;
			this.trackBarBlue.Minimum = -250;
			this.trackBarBlue.Name = "trackBarBlue";
			this.trackBarBlue.Size = new global::System.Drawing.Size(217, 45);
			this.trackBarBlue.TabIndex = 9;
			this.trackBarBlue.TickFrequency = 25;
			this.trackBarBlue.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(9, 405);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(40, 14);
			this.label5.TabIndex = 12;
			this.label5.Text = "Blue";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(9, 360);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(40, 14);
			this.label6.TabIndex = 11;
			this.label6.Text = "Green";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.BackColor = global::System.Drawing.Color.Red;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(9, 315);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(40, 14);
			this.label7.TabIndex = 10;
			this.label7.Text = "Red";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonReset.Location = new global::System.Drawing.Point(122, 274);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new global::System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 13;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new global::System.EventHandler(this.buttonReset_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(280, 489);
			base.Controls.Add(this.buttonReset);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.trackBarBlue);
			base.Controls.Add(this.trackBarGreen);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.trackBarRed);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.pictureBox);
			base.Name = "ModifyColor";
			this.Text = "Modify Color";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			this.contextMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003B RID: 59
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TrackBar trackBarRed;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TrackBar trackBarGreen;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.TrackBar trackBarBlue;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button buttonReset;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ContextMenuStrip contextMenu;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripMenuItem menuSampleRGB;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripMenuItem menuApplyRGB;
	}
}
