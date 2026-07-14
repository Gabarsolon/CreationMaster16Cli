namespace FifaControls
{
	// Token: 0x02000006 RID: 6
	public partial class HairSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003DB8 File Offset: 0x00001FB8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.HairSelector));
			this.labelHairSideCurrent = new global::System.Windows.Forms.Label();
			this.imageListHairSide = new global::System.Windows.Forms.ImageList(this.components);
			this.imageListHairFront = new global::System.Windows.Forms.ImageList(this.components);
			this.labelHairFrontCurrent = new global::System.Windows.Forms.Label();
			this.labelHairFrontSelected = new global::System.Windows.Forms.Label();
			this.labelHairSideSelected = new global::System.Windows.Forms.Label();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.labelHairSideCurrent.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHairSideCurrent.ImageList = this.imageListHairSide;
			this.labelHairSideCurrent.Location = new global::System.Drawing.Point(910, 142);
			this.labelHairSideCurrent.Name = "labelHairSideCurrent";
			this.labelHairSideCurrent.Size = new global::System.Drawing.Size(128, 128);
			this.labelHairSideCurrent.TabIndex = 0;
			this.imageListHairSide.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListHairSide.ImageStream");
			this.imageListHairSide.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListHairSide.Images.SetKeyName(0, "000.png");
			this.imageListHairSide.Images.SetKeyName(1, "001.png");
			this.imageListHairSide.Images.SetKeyName(2, "002.png");
			this.imageListHairSide.Images.SetKeyName(3, "003.png");
			this.imageListHairSide.Images.SetKeyName(4, "004.png");
			this.imageListHairSide.Images.SetKeyName(5, "005.png");
			this.imageListHairSide.Images.SetKeyName(6, "006.png");
			this.imageListHairSide.Images.SetKeyName(7, "007.png");
			this.imageListHairSide.Images.SetKeyName(8, "008.png");
			this.imageListHairSide.Images.SetKeyName(9, "009.png");
			this.imageListHairSide.Images.SetKeyName(10, "010.png");
			this.imageListHairSide.Images.SetKeyName(11, "011.png");
			this.imageListHairSide.Images.SetKeyName(12, "012.png");
			this.imageListHairSide.Images.SetKeyName(13, "013.png");
			this.imageListHairSide.Images.SetKeyName(14, "014.png");
			this.imageListHairSide.Images.SetKeyName(15, "015.png");
			this.imageListHairSide.Images.SetKeyName(16, "016.png");
			this.imageListHairSide.Images.SetKeyName(17, "017.png");
			this.imageListHairSide.Images.SetKeyName(18, "018.png");
			this.imageListHairSide.Images.SetKeyName(19, "019.png");
			this.imageListHairSide.Images.SetKeyName(20, "020.png");
			this.imageListHairSide.Images.SetKeyName(21, "021.png");
			this.imageListHairSide.Images.SetKeyName(22, "022.png");
			this.imageListHairSide.Images.SetKeyName(23, "023.png");
			this.imageListHairSide.Images.SetKeyName(24, "024.png");
			this.imageListHairSide.Images.SetKeyName(25, "025.png");
			this.imageListHairSide.Images.SetKeyName(26, "026.png");
			this.imageListHairSide.Images.SetKeyName(27, "027.png");
			this.imageListHairSide.Images.SetKeyName(28, "028.png");
			this.imageListHairSide.Images.SetKeyName(29, "029.png");
			this.imageListHairSide.Images.SetKeyName(30, "030.png");
			this.imageListHairSide.Images.SetKeyName(31, "031.png");
			this.imageListHairSide.Images.SetKeyName(32, "032.png");
			this.imageListHairSide.Images.SetKeyName(33, "033.png");
			this.imageListHairSide.Images.SetKeyName(34, "034.png");
			this.imageListHairSide.Images.SetKeyName(35, "035.png");
			this.imageListHairSide.Images.SetKeyName(36, "036.png");
			this.imageListHairSide.Images.SetKeyName(37, "037.png");
			this.imageListHairSide.Images.SetKeyName(38, "038.png");
			this.imageListHairSide.Images.SetKeyName(39, "039.png");
			this.imageListHairSide.Images.SetKeyName(40, "040.png");
			this.imageListHairSide.Images.SetKeyName(41, "041.png");
			this.imageListHairSide.Images.SetKeyName(42, "042.png");
			this.imageListHairSide.Images.SetKeyName(43, "043.png");
			this.imageListHairSide.Images.SetKeyName(44, "044.png");
			this.imageListHairSide.Images.SetKeyName(45, "045.png");
			this.imageListHairSide.Images.SetKeyName(46, "046.png");
			this.imageListHairSide.Images.SetKeyName(47, "047.png");
			this.imageListHairSide.Images.SetKeyName(48, "048.png");
			this.imageListHairSide.Images.SetKeyName(49, "049.png");
			this.imageListHairSide.Images.SetKeyName(50, "050.png");
			this.imageListHairSide.Images.SetKeyName(51, "051.png");
			this.imageListHairSide.Images.SetKeyName(52, "052.png");
			this.imageListHairSide.Images.SetKeyName(53, "053.png");
			this.imageListHairSide.Images.SetKeyName(54, "054.png");
			this.imageListHairSide.Images.SetKeyName(55, "055.png");
			this.imageListHairSide.Images.SetKeyName(56, "056.png");
			this.imageListHairSide.Images.SetKeyName(57, "057.png");
			this.imageListHairSide.Images.SetKeyName(58, "058.png");
			this.imageListHairSide.Images.SetKeyName(59, "059.png");
			this.imageListHairSide.Images.SetKeyName(60, "060.png");
			this.imageListHairSide.Images.SetKeyName(61, "061.png");
			this.imageListHairSide.Images.SetKeyName(62, "062.png");
			this.imageListHairSide.Images.SetKeyName(63, "063.png");
			this.imageListHairSide.Images.SetKeyName(64, "064.png");
			this.imageListHairSide.Images.SetKeyName(65, "065.png");
			this.imageListHairSide.Images.SetKeyName(66, "066.png");
			this.imageListHairSide.Images.SetKeyName(67, "067.png");
			this.imageListHairSide.Images.SetKeyName(68, "068.png");
			this.imageListHairSide.Images.SetKeyName(69, "069.png");
			this.imageListHairSide.Images.SetKeyName(70, "070.png");
			this.imageListHairSide.Images.SetKeyName(71, "071.png");
			this.imageListHairSide.Images.SetKeyName(72, "072.png");
			this.imageListHairSide.Images.SetKeyName(73, "073.png");
			this.imageListHairSide.Images.SetKeyName(74, "074.png");
			this.imageListHairSide.Images.SetKeyName(75, "075.png");
			this.imageListHairSide.Images.SetKeyName(76, "076.png");
			this.imageListHairSide.Images.SetKeyName(77, "077.png");
			this.imageListHairSide.Images.SetKeyName(78, "078.png");
			this.imageListHairSide.Images.SetKeyName(79, "079.png");
			this.imageListHairSide.Images.SetKeyName(80, "080.png");
			this.imageListHairSide.Images.SetKeyName(81, "081.png");
			this.imageListHairSide.Images.SetKeyName(82, "082.png");
			this.imageListHairSide.Images.SetKeyName(83, "083.png");
			this.imageListHairSide.Images.SetKeyName(84, "084.png");
			this.imageListHairSide.Images.SetKeyName(85, "085.png");
			this.imageListHairSide.Images.SetKeyName(86, "086.png");
			this.imageListHairSide.Images.SetKeyName(87, "087.png");
			this.imageListHairSide.Images.SetKeyName(88, "088.png");
			this.imageListHairSide.Images.SetKeyName(89, "089.png");
			this.imageListHairSide.Images.SetKeyName(90, "090.png");
			this.imageListHairSide.Images.SetKeyName(91, "091.png");
			this.imageListHairSide.Images.SetKeyName(92, "092.png");
			this.imageListHairSide.Images.SetKeyName(93, "093.png");
			this.imageListHairSide.Images.SetKeyName(94, "094.png");
			this.imageListHairSide.Images.SetKeyName(95, "095.png");
			this.imageListHairSide.Images.SetKeyName(96, "096.png");
			this.imageListHairSide.Images.SetKeyName(97, "097.png");
			this.imageListHairSide.Images.SetKeyName(98, "098.png");
			this.imageListHairSide.Images.SetKeyName(99, "099.png");
			this.imageListHairSide.Images.SetKeyName(100, "100.png");
			this.imageListHairSide.Images.SetKeyName(101, "101.png");
			this.imageListHairSide.Images.SetKeyName(102, "102.png");
			this.imageListHairSide.Images.SetKeyName(103, "103.png");
			this.imageListHairSide.Images.SetKeyName(104, "104.png");
			this.imageListHairSide.Images.SetKeyName(105, "105.png");
			this.imageListHairSide.Images.SetKeyName(106, "106.png");
			this.imageListHairSide.Images.SetKeyName(107, "107.png");
			this.imageListHairSide.Images.SetKeyName(108, "108.png");
			this.imageListHairSide.Images.SetKeyName(109, "109.png");
			this.imageListHairSide.Images.SetKeyName(110, "110.png");
			this.imageListHairSide.Images.SetKeyName(111, "111.png");
			this.imageListHairSide.Images.SetKeyName(112, "112.png");
			this.imageListHairSide.Images.SetKeyName(113, "113.png");
			this.imageListHairSide.Images.SetKeyName(114, "114.png");
			this.imageListHairSide.Images.SetKeyName(115, "115.png");
			this.imageListHairSide.Images.SetKeyName(116, "116.png");
			this.imageListHairSide.Images.SetKeyName(117, "117.png");
			this.imageListHairSide.Images.SetKeyName(118, "118.png");
			this.imageListHairSide.Images.SetKeyName(119, "119.png");
			this.imageListHairSide.Images.SetKeyName(120, "120.png");
			this.imageListHairSide.Images.SetKeyName(121, "121.png");
			this.imageListHairSide.Images.SetKeyName(122, "122.png");
			this.imageListHairSide.Images.SetKeyName(123, "123.png");
			this.imageListHairSide.Images.SetKeyName(124, "124.png");
			this.imageListHairFront.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListHairFront.ImageStream");
			this.imageListHairFront.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListHairFront.Images.SetKeyName(0, "000_B.png");
			this.imageListHairFront.Images.SetKeyName(1, "001_B.png");
			this.imageListHairFront.Images.SetKeyName(2, "002_B.png");
			this.imageListHairFront.Images.SetKeyName(3, "003_B.png");
			this.imageListHairFront.Images.SetKeyName(4, "004_B.png");
			this.imageListHairFront.Images.SetKeyName(5, "005_B.png");
			this.imageListHairFront.Images.SetKeyName(6, "006_B.png");
			this.imageListHairFront.Images.SetKeyName(7, "007_B.png");
			this.imageListHairFront.Images.SetKeyName(8, "008_B.png");
			this.imageListHairFront.Images.SetKeyName(9, "009_B.png");
			this.imageListHairFront.Images.SetKeyName(10, "010_B.png");
			this.imageListHairFront.Images.SetKeyName(11, "011_B.png");
			this.imageListHairFront.Images.SetKeyName(12, "012_B.png");
			this.imageListHairFront.Images.SetKeyName(13, "013_B.png");
			this.imageListHairFront.Images.SetKeyName(14, "014_B.png");
			this.imageListHairFront.Images.SetKeyName(15, "015_B.png");
			this.imageListHairFront.Images.SetKeyName(16, "016_B.png");
			this.imageListHairFront.Images.SetKeyName(17, "017_B.png");
			this.imageListHairFront.Images.SetKeyName(18, "018_B.png");
			this.imageListHairFront.Images.SetKeyName(19, "019_B.png");
			this.imageListHairFront.Images.SetKeyName(20, "020_B.png");
			this.imageListHairFront.Images.SetKeyName(21, "021_B.png");
			this.imageListHairFront.Images.SetKeyName(22, "022_B.png");
			this.imageListHairFront.Images.SetKeyName(23, "023_B.png");
			this.imageListHairFront.Images.SetKeyName(24, "024_B.png");
			this.imageListHairFront.Images.SetKeyName(25, "025_B.png");
			this.imageListHairFront.Images.SetKeyName(26, "026_B.png");
			this.imageListHairFront.Images.SetKeyName(27, "027_B.png");
			this.imageListHairFront.Images.SetKeyName(28, "028_B.png");
			this.imageListHairFront.Images.SetKeyName(29, "029_B.png");
			this.imageListHairFront.Images.SetKeyName(30, "030_B.png");
			this.imageListHairFront.Images.SetKeyName(31, "031_B.png");
			this.imageListHairFront.Images.SetKeyName(32, "032_B.png");
			this.imageListHairFront.Images.SetKeyName(33, "033_B.png");
			this.imageListHairFront.Images.SetKeyName(34, "034_B.png");
			this.imageListHairFront.Images.SetKeyName(35, "035_B.png");
			this.imageListHairFront.Images.SetKeyName(36, "036_B.png");
			this.imageListHairFront.Images.SetKeyName(37, "037_B.png");
			this.imageListHairFront.Images.SetKeyName(38, "038_B.png");
			this.imageListHairFront.Images.SetKeyName(39, "039_B.png");
			this.imageListHairFront.Images.SetKeyName(40, "040_B.png");
			this.imageListHairFront.Images.SetKeyName(41, "041_B.png");
			this.imageListHairFront.Images.SetKeyName(42, "042_B.png");
			this.imageListHairFront.Images.SetKeyName(43, "043_B.png");
			this.imageListHairFront.Images.SetKeyName(44, "044_B.png");
			this.imageListHairFront.Images.SetKeyName(45, "045_B.png");
			this.imageListHairFront.Images.SetKeyName(46, "046_B.png");
			this.imageListHairFront.Images.SetKeyName(47, "047_B.png");
			this.imageListHairFront.Images.SetKeyName(48, "048_B.png");
			this.imageListHairFront.Images.SetKeyName(49, "049_B.png");
			this.imageListHairFront.Images.SetKeyName(50, "050_B.png");
			this.imageListHairFront.Images.SetKeyName(51, "051_B.png");
			this.imageListHairFront.Images.SetKeyName(52, "052_B.png");
			this.imageListHairFront.Images.SetKeyName(53, "053_B.png");
			this.imageListHairFront.Images.SetKeyName(54, "054_B.png");
			this.imageListHairFront.Images.SetKeyName(55, "055_B.png");
			this.imageListHairFront.Images.SetKeyName(56, "056_B.png");
			this.imageListHairFront.Images.SetKeyName(57, "057_B.png");
			this.imageListHairFront.Images.SetKeyName(58, "058_B.png");
			this.imageListHairFront.Images.SetKeyName(59, "059_B.png");
			this.imageListHairFront.Images.SetKeyName(60, "060_B.png");
			this.imageListHairFront.Images.SetKeyName(61, "061_B.png");
			this.imageListHairFront.Images.SetKeyName(62, "062_B.png");
			this.imageListHairFront.Images.SetKeyName(63, "063_B.png");
			this.imageListHairFront.Images.SetKeyName(64, "064_B.png");
			this.imageListHairFront.Images.SetKeyName(65, "065_B.png");
			this.imageListHairFront.Images.SetKeyName(66, "066_B.png");
			this.imageListHairFront.Images.SetKeyName(67, "067_B.png");
			this.imageListHairFront.Images.SetKeyName(68, "068_B.png");
			this.imageListHairFront.Images.SetKeyName(69, "069_B.png");
			this.imageListHairFront.Images.SetKeyName(70, "070_B.png");
			this.imageListHairFront.Images.SetKeyName(71, "071_B.png");
			this.imageListHairFront.Images.SetKeyName(72, "072_B.png");
			this.imageListHairFront.Images.SetKeyName(73, "073_B.png");
			this.imageListHairFront.Images.SetKeyName(74, "074_B.png");
			this.imageListHairFront.Images.SetKeyName(75, "075_B.png");
			this.imageListHairFront.Images.SetKeyName(76, "076_B.png");
			this.imageListHairFront.Images.SetKeyName(77, "077_B.png");
			this.imageListHairFront.Images.SetKeyName(78, "078_B.png");
			this.imageListHairFront.Images.SetKeyName(79, "079_B.png");
			this.imageListHairFront.Images.SetKeyName(80, "080_B.png");
			this.imageListHairFront.Images.SetKeyName(81, "081_B.png");
			this.imageListHairFront.Images.SetKeyName(82, "082_B.png");
			this.imageListHairFront.Images.SetKeyName(83, "083_B.png");
			this.imageListHairFront.Images.SetKeyName(84, "084_B.png");
			this.imageListHairFront.Images.SetKeyName(85, "085_B.png");
			this.imageListHairFront.Images.SetKeyName(86, "086_B.png");
			this.imageListHairFront.Images.SetKeyName(87, "087_B.png");
			this.imageListHairFront.Images.SetKeyName(88, "088_B.png");
			this.imageListHairFront.Images.SetKeyName(89, "089_B.png");
			this.imageListHairFront.Images.SetKeyName(90, "090_B.png");
			this.imageListHairFront.Images.SetKeyName(91, "091_B.png");
			this.imageListHairFront.Images.SetKeyName(92, "092_B.png");
			this.imageListHairFront.Images.SetKeyName(93, "093_B.png");
			this.imageListHairFront.Images.SetKeyName(94, "094_B.png");
			this.imageListHairFront.Images.SetKeyName(95, "095_B.png");
			this.imageListHairFront.Images.SetKeyName(96, "096_B.png");
			this.imageListHairFront.Images.SetKeyName(97, "097_B.png");
			this.imageListHairFront.Images.SetKeyName(98, "098_B.png");
			this.imageListHairFront.Images.SetKeyName(99, "099_B.png");
			this.imageListHairFront.Images.SetKeyName(100, "100_B.png");
			this.imageListHairFront.Images.SetKeyName(101, "101_B.png");
			this.imageListHairFront.Images.SetKeyName(102, "102_B.png");
			this.imageListHairFront.Images.SetKeyName(103, "103_B.png");
			this.imageListHairFront.Images.SetKeyName(104, "104_B.png");
			this.imageListHairFront.Images.SetKeyName(105, "105_B.png");
			this.imageListHairFront.Images.SetKeyName(106, "106_B.png");
			this.imageListHairFront.Images.SetKeyName(107, "107_B.png");
			this.imageListHairFront.Images.SetKeyName(108, "108_B.png");
			this.imageListHairFront.Images.SetKeyName(109, "109_B.png");
			this.imageListHairFront.Images.SetKeyName(110, "110_B.png");
			this.imageListHairFront.Images.SetKeyName(111, "111_B.png");
			this.imageListHairFront.Images.SetKeyName(112, "112_B.png");
			this.imageListHairFront.Images.SetKeyName(113, "113_B.png");
			this.imageListHairFront.Images.SetKeyName(114, "114_B.png");
			this.imageListHairFront.Images.SetKeyName(115, "115_B.png");
			this.imageListHairFront.Images.SetKeyName(116, "116_B.png");
			this.imageListHairFront.Images.SetKeyName(117, "117_B.png");
			this.imageListHairFront.Images.SetKeyName(118, "118_B.png");
			this.imageListHairFront.Images.SetKeyName(119, "119_B.png");
			this.imageListHairFront.Images.SetKeyName(120, "120_B.png");
			this.imageListHairFront.Images.SetKeyName(121, "121_B.png");
			this.imageListHairFront.Images.SetKeyName(122, "122_B.png");
			this.imageListHairFront.Images.SetKeyName(123, "123_B.png");
			this.imageListHairFront.Images.SetKeyName(124, "124_B.png");
			this.labelHairFrontCurrent.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHairFrontCurrent.ImageList = this.imageListHairFront;
			this.labelHairFrontCurrent.Location = new global::System.Drawing.Point(910, 9);
			this.labelHairFrontCurrent.Name = "labelHairFrontCurrent";
			this.labelHairFrontCurrent.Size = new global::System.Drawing.Size(128, 128);
			this.labelHairFrontCurrent.TabIndex = 4;
			this.labelHairFrontSelected.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHairFrontSelected.ImageList = this.imageListHairFront;
			this.labelHairFrontSelected.Location = new global::System.Drawing.Point(910, 276);
			this.labelHairFrontSelected.Name = "labelHairFrontSelected";
			this.labelHairFrontSelected.Size = new global::System.Drawing.Size(128, 128);
			this.labelHairFrontSelected.TabIndex = 6;
			this.labelHairSideSelected.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHairSideSelected.ImageList = this.imageListHairSide;
			this.labelHairSideSelected.Location = new global::System.Drawing.Point(910, 409);
			this.labelHairSideSelected.Name = "labelHairSideSelected";
			this.labelHairSideSelected.Size = new global::System.Drawing.Size(128, 128);
			this.labelHairSideSelected.TabIndex = 5;
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(910, 550);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(60, 23);
			this.buttonOk.TabIndex = 7;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(978, 550);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(60, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1044, 582);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.labelHairFrontSelected);
			base.Controls.Add(this.labelHairSideSelected);
			base.Controls.Add(this.labelHairFrontCurrent);
			base.Controls.Add(this.labelHairSideCurrent);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "HairSelector";
			this.Text = "Generic Hair Selector";
			base.ResumeLayout(false);
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label labelHairSideCurrent;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ImageList imageListHairSide;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ImageList imageListHairFront;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label labelHairFrontCurrent;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label labelHairFrontSelected;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label labelHairSideSelected;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button buttonCancel;
	}
}
