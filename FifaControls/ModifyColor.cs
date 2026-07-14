using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000007 RID: 7
	public partial class ModifyColor : Form
	{
		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00005874 File Offset: 0x00003A74
		public Bitmap InputBitmap
		{
			set
			{
				this.m_InputBitmap = value;
				this.m_OutputBitmap = (Bitmap)this.m_InputBitmap.Clone();
				this.ResetTrackBars();
				this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, false);
				this.pictureBox.BackgroundImage = this.m_OutputBitmap;
				this.pictureBox.Refresh();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000058F3 File Offset: 0x00003AF3
		public Bitmap OutputBitmap
		{
			get
			{
				return this.m_OutputBitmap;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000058FB File Offset: 0x00003AFB
		public void ResetTrackBars()
		{
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005921 File Offset: 0x00003B21
		public ModifyColor()
		{
			this.InitializeComponent();
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005954 File Offset: 0x00003B54
		public ModifyColor(Bitmap inputBitmap)
		{
			this.InitializeComponent();
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.m_InputBitmap = inputBitmap;
			this.m_OutputBitmap = (Bitmap)this.m_InputBitmap.Clone();
			this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005A00 File Offset: 0x00003C00
		private void trackBar_MouseUp(object sender, MouseEventArgs e)
		{
			this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005A5C File Offset: 0x00003C5C
		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005ADC File Offset: 0x00003CDC
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_OutputBitmap = (Bitmap)this.m_InputBitmap.Clone();
			this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, true);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005B34 File Offset: 0x00003D34
		private void menuSampleRGB_Click(object sender, EventArgs e)
		{
			int num = ((this.m_X >= 4) ? (this.m_X * 2 - 8) : 0);
			int num2 = ((this.m_X < 252) ? (this.m_X * 2 - 8) : 496);
			int num3 = ((this.m_Y >= 4) ? (this.m_Y * 2 - 8) : 0);
			int num4 = ((this.m_Y < 252) ? (this.m_Y * 2 - 8) : 496);
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			for (int i = num2; i < num2 + 16; i++)
			{
				for (int j = num4; j < num4 + 16; j++)
				{
					Color pixel = this.m_OutputBitmap.GetPixel(i, j);
					num5 += (int)pixel.R;
					num6 += (int)pixel.G;
					num7 += (int)pixel.B;
				}
			}
			num5 /= 256;
			num6 /= 256;
			num7 /= 256;
			this.m_TargetColor = Color.FromArgb(num5, num6, num7);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005C34 File Offset: 0x00003E34
		private void menuApplyRGB_Click(object sender, EventArgs e)
		{
			int num = ((this.m_X >= 4) ? (this.m_X * 2 - 8) : 0);
			int num2 = ((this.m_X < 252) ? (this.m_X * 2 - 8) : 496);
			int num3 = ((this.m_Y >= 4) ? (this.m_Y * 2 - 8) : 0);
			int num4 = ((this.m_Y < 252) ? (this.m_Y * 2 - 8) : 496);
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			for (int i = num2; i < num2 + 16; i++)
			{
				for (int j = num4; j < num4 + 16; j++)
				{
					Color pixel = this.m_InputBitmap.GetPixel(i, j);
					num5 += (int)pixel.R;
					num6 += (int)pixel.G;
					num7 += (int)pixel.B;
				}
			}
			num5 /= 256;
			num6 /= 256;
			num7 /= 256;
			this.trackBarRed.Value = (int)this.m_TargetColor.R - num5;
			this.trackBarGreen.Value = (int)this.m_TargetColor.G - num6;
			this.trackBarBlue.Value = (int)this.m_TargetColor.B - num7;
			this.m_OutputBitmap = GraphicUtil.AddColorOffsetPreservingAlfa(this.m_InputBitmap, this.trackBarRed.Value, this.trackBarGreen.Value, this.trackBarBlue.Value, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005DBD File Offset: 0x00003FBD
		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			this.m_X = e.X;
			this.m_Y = e.Y;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005DD7 File Offset: 0x00003FD7
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.m_OutputBitmap = this.m_InputBitmap;
		}

		// Token: 0x04000036 RID: 54
		private Bitmap m_InputBitmap;

		// Token: 0x04000037 RID: 55
		private Bitmap m_OutputBitmap;

		// Token: 0x04000038 RID: 56
		private int m_X;

		// Token: 0x04000039 RID: 57
		private int m_Y;

		// Token: 0x0400003A RID: 58
		private Color m_TargetColor;
	}
}
