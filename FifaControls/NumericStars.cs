using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000013 RID: 19
	public class NumericStars : UserControl
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000E306 File Offset: 0x0000C506
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000E318 File Offset: 0x0000C518
		[Category("User")]
		[Description("Value")]
		public int Value
		{
			get
			{
				return (int)this.numericUpDown.Value;
			}
			set
			{
				this.numericUpDown.Value = value;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000E32B File Offset: 0x0000C52B
		public NumericStars()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000E33C File Offset: 0x0000C53C
		private void numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int num = (int)this.numericUpDown.Value;
			int num2 = ((num >= 2) ? ((num - 2) / 2) : 0);
			this.label.ImageIndex = num2;
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, num);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000E388 File Offset: 0x0000C588
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NumericStars));
			this.numericUpDown = new NumericUpDown();
			this.label = new Label();
			this.imageList = new ImageList(this.components);
			((ISupportInitialize)this.numericUpDown).BeginInit();
			base.SuspendLayout();
			this.numericUpDown.Location = new Point(0, 0);
			NumericUpDown numericUpDown = this.numericUpDown;
			int[] array = new int[4];
			array[0] = 20;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new Size(66, 20);
			this.numericUpDown.TabIndex = 0;
			this.numericUpDown.TextAlign = HorizontalAlignment.Center;
			this.numericUpDown.ValueChanged += this.numericUpDown_ValueChanged;
			this.label.ImageIndex = 0;
			this.label.ImageList = this.imageList;
			this.label.Location = new Point(70, 2);
			this.label.Name = "label";
			this.label.Size = new Size(93, 17);
			this.label.TabIndex = 1;
			this.imageList.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList.TransparentColor = Color.Fuchsia;
			this.imageList.Images.SetKeyName(0, "Stars_0_5.PNG");
			this.imageList.Images.SetKeyName(1, "Stars_1.PNG");
			this.imageList.Images.SetKeyName(2, "Stars_1_5.PNG");
			this.imageList.Images.SetKeyName(3, "Stars_2.PNG");
			this.imageList.Images.SetKeyName(4, "Stars_2_5.PNG");
			this.imageList.Images.SetKeyName(5, "Stars_3.PNG");
			this.imageList.Images.SetKeyName(6, "Stars_3_5.PNG");
			this.imageList.Images.SetKeyName(7, "Stars_4.PNG");
			this.imageList.Images.SetKeyName(8, "Stars_4_5.PNG");
			this.imageList.Images.SetKeyName(9, "Stars_5.PNG");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.label);
			base.Controls.Add(this.numericUpDown);
			base.Name = "NumericStars";
			base.Size = new Size(167, 20);
			((ISupportInitialize)this.numericUpDown).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400010E RID: 270
		public NumericStars.StarsEventHandler ValueChanged;

		// Token: 0x0400010F RID: 271
		private IContainer components;

		// Token: 0x04000110 RID: 272
		private Label label;

		// Token: 0x04000111 RID: 273
		private ImageList imageList;

		// Token: 0x04000112 RID: 274
		public NumericUpDown numericUpDown;

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060001CA RID: 458
		public delegate void StarsEventHandler(object sender, int value);
	}
}
