namespace CreationMaster
{
	// Token: 0x0200000A RID: 10
	public partial class ModifyHairColor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00019617 File Offset: 0x00017817
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00019638 File Offset: 0x00017838
		private void InitializeComponent()
		{
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
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
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).BeginInit();
			base.SuspendLayout();
			this.pictureBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox.Location = new global::System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(256, 256);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(12, 433);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(197, 433);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
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
			this.trackBarGreen.Location = new global::System.Drawing.Point(55, 347);
			this.trackBarGreen.Maximum = 250;
			this.trackBarGreen.Minimum = -250;
			this.trackBarGreen.Name = "trackBarGreen";
			this.trackBarGreen.Size = new global::System.Drawing.Size(217, 45);
			this.trackBarGreen.TabIndex = 8;
			this.trackBarGreen.TickFrequency = 25;
			this.trackBarGreen.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
			this.trackBarBlue.LargeChange = 25;
			this.trackBarBlue.Location = new global::System.Drawing.Point(55, 382);
			this.trackBarBlue.Maximum = 250;
			this.trackBarBlue.Minimum = -250;
			this.trackBarBlue.Name = "trackBarBlue";
			this.trackBarBlue.Size = new global::System.Drawing.Size(217, 45);
			this.trackBarBlue.TabIndex = 9;
			this.trackBarBlue.TickFrequency = 25;
			this.trackBarBlue.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(9, 386);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(40, 14);
			this.label5.TabIndex = 12;
			this.label5.Text = "Blue";
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(9, 350);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(40, 14);
			this.label6.TabIndex = 11;
			this.label6.Text = "Green";
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.BackColor = global::System.Drawing.Color.Red;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(9, 318);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(40, 14);
			this.label7.TabIndex = 10;
			this.label7.Text = "Red";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonReset.Location = new global::System.Drawing.Point(124, 286);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new global::System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 13;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new global::System.EventHandler(this.buttonReset_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(280, 479);
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
			base.Name = "ModifyHairColor";
			this.Text = "Modify Hair Color";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400019B RID: 411
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x0400019F RID: 415
		private global::System.Windows.Forms.TrackBar trackBarRed;

		// Token: 0x040001A0 RID: 416
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040001A1 RID: 417
		private global::System.Windows.Forms.TrackBar trackBarGreen;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.Forms.TrackBar trackBarBlue;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.Button buttonReset;
	}
}
