namespace CreationMaster
{
	// Token: 0x0200000B RID: 11
	public partial class NewspapersForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000127 RID: 295 RVA: 0x0001A3DC File Offset: 0x000185DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001A3FC File Offset: 0x000185FC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.numericNewspaper1 = new global::System.Windows.Forms.NumericUpDown();
			this.labelNewpaper = new global::System.Windows.Forms.Label();
			this.groupNewspaper = new global::System.Windows.Forms.GroupBox();
			this.viewer2DNewspaper = new global::FifaControls.Viewer2D();
			this.groupCmSponsor = new global::System.Windows.Forms.GroupBox();
			this.viewer2DCmSponsorSmall = new global::FifaControls.Viewer2D();
			this.numericCmSponsor = new global::System.Windows.Forms.NumericUpDown();
			this.viewer2DCmSponsor = new global::FifaControls.Viewer2D();
			this.groupSpecificTeamNews = new global::System.Windows.Forms.GroupBox();
			this.viewer2DTeamNews = new global::FifaControls.Viewer2D();
			this.numericTeamNewsCounter = new global::System.Windows.Forms.NumericUpDown();
			this.comboTeamNewsType = new global::System.Windows.Forms.ComboBox();
			this.comboTeamAvailable = new global::System.Windows.Forms.ComboBox();
			this.pickUpControl = new global::FifaControls.PickUpControl();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.numericNewspaper1).BeginInit();
			this.groupNewspaper.SuspendLayout();
			this.groupCmSponsor.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericCmSponsor).BeginInit();
			this.groupSpecificTeamNews.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamNewsCounter).BeginInit();
			base.SuspendLayout();
			this.numericNewspaper1.Location = new global::System.Drawing.Point(85, 176);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericNewspaper1;
			int[] array = new int[4];
			array[0] = 14;
			numericUpDown.Maximum = new decimal(array);
			this.numericNewspaper1.Name = "numericNewspaper1";
			this.numericNewspaper1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.numericNewspaper1.Size = new global::System.Drawing.Size(66, 20);
			this.numericNewspaper1.TabIndex = 2;
			this.numericNewspaper1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericNewspaper1.ValueChanged += new global::System.EventHandler(this.numericNewspaper);
			this.labelNewpaper.AutoSize = true;
			this.labelNewpaper.BackColor = global::System.Drawing.Color.Transparent;
			this.labelNewpaper.Location = new global::System.Drawing.Point(6, 178);
			this.labelNewpaper.Name = "labelNewpaper";
			this.labelNewpaper.Size = new global::System.Drawing.Size(73, 13);
			this.labelNewpaper.TabIndex = 3;
			this.labelNewpaper.Text = "Newspaper n.";
			this.groupNewspaper.Controls.Add(this.viewer2DNewspaper);
			this.groupNewspaper.Controls.Add(this.labelNewpaper);
			this.groupNewspaper.Controls.Add(this.numericNewspaper1);
			this.groupNewspaper.Location = new global::System.Drawing.Point(12, 31);
			this.groupNewspaper.Name = "groupNewspaper";
			this.groupNewspaper.Size = new global::System.Drawing.Size(524, 201);
			this.groupNewspaper.TabIndex = 4;
			this.groupNewspaper.TabStop = false;
			this.groupNewspaper.Text = "Newspapers";
			this.viewer2DNewspaper.AutoTransparency = false;
			this.viewer2DNewspaper.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DNewspaper.ButtonStripVisible = true;
			this.viewer2DNewspaper.CurrentBitmap = null;
			this.viewer2DNewspaper.ExtendedFormat = false;
			this.viewer2DNewspaper.FullSizeButton = false;
			this.viewer2DNewspaper.ImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.viewer2DNewspaper.ImageSize = new global::System.Drawing.Size(1024, 128);
			this.viewer2DNewspaper.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DNewspaper.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DNewspaper.Name = "viewer2DNewspaper";
			this.viewer2DNewspaper.RemoveButton = false;
			this.viewer2DNewspaper.ShowButton = true;
			this.viewer2DNewspaper.ShowButtonChecked = true;
			this.viewer2DNewspaper.Size = new global::System.Drawing.Size(512, 153);
			this.viewer2DNewspaper.TabIndex = 1;
			this.toolTip1.SetToolTip(this.viewer2DNewspaper, "Import 1024 x 128 image");
			this.groupCmSponsor.Controls.Add(this.viewer2DCmSponsorSmall);
			this.groupCmSponsor.Controls.Add(this.numericCmSponsor);
			this.groupCmSponsor.Controls.Add(this.viewer2DCmSponsor);
			this.groupCmSponsor.Location = new global::System.Drawing.Point(12, 238);
			this.groupCmSponsor.Name = "groupCmSponsor";
			this.groupCmSponsor.Size = new global::System.Drawing.Size(524, 216);
			this.groupCmSponsor.TabIndex = 5;
			this.groupCmSponsor.TabStop = false;
			this.groupCmSponsor.Text = "News Sponsor";
			this.viewer2DCmSponsorSmall.AutoTransparency = false;
			this.viewer2DCmSponsorSmall.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCmSponsorSmall.ButtonStripVisible = true;
			this.viewer2DCmSponsorSmall.CurrentBitmap = null;
			this.viewer2DCmSponsorSmall.ExtendedFormat = false;
			this.viewer2DCmSponsorSmall.FullSizeButton = false;
			this.viewer2DCmSponsorSmall.ImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.viewer2DCmSponsorSmall.ImageSize = new global::System.Drawing.Size(256, 32);
			this.viewer2DCmSponsorSmall.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCmSponsorSmall.Location = new global::System.Drawing.Point(3, 138);
			this.viewer2DCmSponsorSmall.Name = "viewer2DCmSponsorSmall";
			this.viewer2DCmSponsorSmall.RemoveButton = false;
			this.viewer2DCmSponsorSmall.ShowButton = true;
			this.viewer2DCmSponsorSmall.ShowButtonChecked = true;
			this.viewer2DCmSponsorSmall.Size = new global::System.Drawing.Size(256, 64);
			this.viewer2DCmSponsorSmall.TabIndex = 4;
			this.toolTip1.SetToolTip(this.viewer2DCmSponsorSmall, "Import 256 x 32 image");
			this.viewer2DCmSponsorSmall.Visible = false;
			this.numericCmSponsor.Location = new global::System.Drawing.Point(3, 114);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericCmSponsor;
			int[] array2 = new int[4];
			array2[0] = 21;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericCmSponsor.Name = "numericCmSponsor";
			this.numericCmSponsor.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.numericCmSponsor.Size = new global::System.Drawing.Size(66, 20);
			this.numericCmSponsor.TabIndex = 3;
			this.numericCmSponsor.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericCmSponsor.ValueChanged += new global::System.EventHandler(this.numericCmSponsor_ValueChanged);
			this.viewer2DCmSponsor.AutoTransparency = false;
			this.viewer2DCmSponsor.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DCmSponsor.ButtonStripVisible = true;
			this.viewer2DCmSponsor.CurrentBitmap = null;
			this.viewer2DCmSponsor.ExtendedFormat = false;
			this.viewer2DCmSponsor.FullSizeButton = false;
			this.viewer2DCmSponsor.ImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.viewer2DCmSponsor.ImageSize = new global::System.Drawing.Size(512, 64);
			this.viewer2DCmSponsor.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DCmSponsor.Location = new global::System.Drawing.Point(6, 19);
			this.viewer2DCmSponsor.Name = "viewer2DCmSponsor";
			this.viewer2DCmSponsor.RemoveButton = true;
			this.viewer2DCmSponsor.ShowButton = true;
			this.viewer2DCmSponsor.ShowButtonChecked = true;
			this.viewer2DCmSponsor.Size = new global::System.Drawing.Size(512, 96);
			this.viewer2DCmSponsor.TabIndex = 2;
			this.toolTip1.SetToolTip(this.viewer2DCmSponsor, "Import 512 x 64 image");
			this.groupSpecificTeamNews.Controls.Add(this.viewer2DTeamNews);
			this.groupSpecificTeamNews.Controls.Add(this.numericTeamNewsCounter);
			this.groupSpecificTeamNews.Controls.Add(this.comboTeamNewsType);
			this.groupSpecificTeamNews.Controls.Add(this.comboTeamAvailable);
			this.groupSpecificTeamNews.Location = new global::System.Drawing.Point(536, 31);
			this.groupSpecificTeamNews.Name = "groupSpecificTeamNews";
			this.groupSpecificTeamNews.Size = new global::System.Drawing.Size(347, 423);
			this.groupSpecificTeamNews.TabIndex = 6;
			this.groupSpecificTeamNews.TabStop = false;
			this.groupSpecificTeamNews.Text = "Specific Team News";
			this.groupSpecificTeamNews.Paint += new global::System.Windows.Forms.PaintEventHandler(this.groupSpecificTeamNews_Paint);
			this.viewer2DTeamNews.AutoTransparency = false;
			this.viewer2DTeamNews.BackColor = global::System.Drawing.Color.Transparent;
			this.viewer2DTeamNews.ButtonStripVisible = true;
			this.viewer2DTeamNews.CurrentBitmap = null;
			this.viewer2DTeamNews.ExtendedFormat = false;
			this.viewer2DTeamNews.FullSizeButton = true;
			this.viewer2DTeamNews.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.viewer2DTeamNews.ImageSize = new global::System.Drawing.Size(668, 550);
			this.viewer2DTeamNews.ImageSizeMultiplier = global::FifaControls.Viewer2D.SizeMultiplier.None;
			this.viewer2DTeamNews.Location = new global::System.Drawing.Point(6, 101);
			this.viewer2DTeamNews.Name = "viewer2DTeamNews";
			this.viewer2DTeamNews.RemoveButton = true;
			this.viewer2DTeamNews.ShowButton = true;
			this.viewer2DTeamNews.ShowButtonChecked = true;
			this.viewer2DTeamNews.Size = new global::System.Drawing.Size(334, 315);
			this.viewer2DTeamNews.TabIndex = 3;
			this.toolTip1.SetToolTip(this.viewer2DTeamNews, "Import 668 x 550 image");
			this.numericTeamNewsCounter.Location = new global::System.Drawing.Point(173, 57);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericTeamNewsCounter;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericTeamNewsCounter.Name = "numericTeamNewsCounter";
			this.numericTeamNewsCounter.Size = new global::System.Drawing.Size(71, 20);
			this.numericTeamNewsCounter.TabIndex = 2;
			this.numericTeamNewsCounter.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericTeamNewsCounter;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			this.numericTeamNewsCounter.ValueChanged += new global::System.EventHandler(this.numericTeamNewsCounter_ValueChanged);
			this.comboTeamNewsType.FormattingEnabled = true;
			this.comboTeamNewsType.Items.AddRange(new object[] { "Neutral", "Celebrating", "Disappointed" });
			this.comboTeamNewsType.Location = new global::System.Drawing.Point(6, 56);
			this.comboTeamNewsType.Name = "comboTeamNewsType";
			this.comboTeamNewsType.Size = new global::System.Drawing.Size(121, 21);
			this.comboTeamNewsType.TabIndex = 1;
			this.comboTeamNewsType.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamNewsType_SelectedIndexChanged);
			this.comboTeamAvailable.FormattingEnabled = true;
			this.comboTeamAvailable.Location = new global::System.Drawing.Point(6, 19);
			this.comboTeamAvailable.Name = "comboTeamAvailable";
			this.comboTeamAvailable.Size = new global::System.Drawing.Size(238, 21);
			this.comboTeamAvailable.Sorted = true;
			this.comboTeamAvailable.TabIndex = 0;
			this.comboTeamAvailable.SelectedIndexChanged += new global::System.EventHandler(this.comboTeamAvailable_SelectedIndexChanged);
			this.pickUpControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.pickUpControl.CloneButtonEnabled = false;
			this.pickUpControl.CreateButtonEnabled = false;
			this.pickUpControl.CurrentIndex = 0;
			this.pickUpControl.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pickUpControl.FilterByList = null;
			this.pickUpControl.FilterEnabled = false;
			this.pickUpControl.FilterValues = null;
			this.pickUpControl.Location = new global::System.Drawing.Point(0, 0);
			this.pickUpControl.MainSelectionEnabled = false;
			this.pickUpControl.Name = "pickUpControl";
			this.pickUpControl.ObjectList = null;
			this.pickUpControl.RefreshButtonEnabled = true;
			this.pickUpControl.RemoveButtonEnabled = false;
			this.pickUpControl.SearchEnabled = false;
			this.pickUpControl.Size = new global::System.Drawing.Size(1165, 25);
			this.pickUpControl.TabIndex = 0;
			this.pickUpControl.WizardButtonEnabled = false;
			this.pickUpControl.YoungPlayersEnabled = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1165, 798);
			base.Controls.Add(this.groupSpecificTeamNews);
			base.Controls.Add(this.groupCmSponsor);
			base.Controls.Add(this.groupNewspaper);
			base.Controls.Add(this.pickUpControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "NewspapersForm";
			this.Text = "NewspapersForm";
			((global::System.ComponentModel.ISupportInitialize)this.numericNewspaper1).EndInit();
			this.groupNewspaper.ResumeLayout(false);
			this.groupNewspaper.PerformLayout();
			this.groupCmSponsor.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericCmSponsor).EndInit();
			this.groupSpecificTeamNews.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericTeamNewsCounter).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001A9 RID: 425
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001AA RID: 426
		private global::FifaControls.PickUpControl pickUpControl;

		// Token: 0x040001AB RID: 427
		private global::FifaControls.Viewer2D viewer2DNewspaper;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.NumericUpDown numericNewspaper1;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.Label labelNewpaper;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.GroupBox groupNewspaper;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.GroupBox groupCmSponsor;

		// Token: 0x040001B0 RID: 432
		private global::FifaControls.Viewer2D viewer2DCmSponsor;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.NumericUpDown numericCmSponsor;

		// Token: 0x040001B2 RID: 434
		private global::FifaControls.Viewer2D viewer2DCmSponsorSmall;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.GroupBox groupSpecificTeamNews;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.ComboBox comboTeamAvailable;

		// Token: 0x040001B5 RID: 437
		private global::FifaControls.Viewer2D viewer2DTeamNews;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.NumericUpDown numericTeamNewsCounter;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.ComboBox comboTeamNewsType;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.ToolTip toolTip1;
	}
}
