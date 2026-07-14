using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200000A RID: 10
	public partial class ModifyHairColor : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000192EE File Offset: 0x000174EE
		public Bitmap Bitmap
		{
			get
			{
				return this.m_OutputBitmap;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000192F8 File Offset: 0x000174F8
		public ModifyHairColor(Bitmap inputBitmap)
		{
			this.InitializeComponent();
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.m_InputBitmap = inputBitmap;
			this.m_PreviewBitmap = GraphicUtil.SubSampleBitmap(inputBitmap, 2, 2);
			this.m_OutputBitmap = (Bitmap)this.m_PreviewBitmap.Clone();
			this.Colorize(this.m_PreviewBitmap, this.m_OutputBitmap, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00019390 File Offset: 0x00017590
		private void Colorize(Bitmap sourceBitmap, Bitmap destBitmap, bool preserveAlfa)
		{
			if (sourceBitmap == null)
			{
				return;
			}
			if (sourceBitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			int num = sourceBitmap.Width * sourceBitmap.Height;
			int[] array = new int[num];
			Rectangle rectangle = new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height);
			BitmapData bitmapData = sourceBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_InputBitmap.PixelFormat);
			Marshal.Copy(bitmapData.Scan0, array, 0, num);
			sourceBitmap.UnlockBits(bitmapData);
			for (int i = 0; i < num; i++)
			{
				Color color = Color.FromArgb(array[i]);
				int num2 = (int)color.R;
				int num3 = (int)color.G;
				int num4 = (int)color.B;
				int a = (int)color.A;
				num2 += this.trackBarRed.Value;
				num3 += this.trackBarGreen.Value;
				num4 += this.trackBarBlue.Value;
				if (num2 > 255)
				{
					num2 = 255;
				}
				if (num3 > 255)
				{
					num3 = 255;
				}
				if (num4 > 255)
				{
					num4 = 255;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num3 < 0)
				{
					num3 = 0;
				}
				if (num4 < 0)
				{
					num4 = 0;
				}
				if (preserveAlfa)
				{
					array[i] = Color.FromArgb(a, num2, num3, num4).ToArgb();
				}
				else
				{
					array[i] = Color.FromArgb(255, num2, num3, num4).ToArgb();
				}
			}
			rectangle = new Rectangle(0, 0, destBitmap.Width, this.m_OutputBitmap.Height);
			BitmapData bitmapData2 = destBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_OutputBitmap.PixelFormat);
			IntPtr scan = bitmapData2.Scan0;
			Marshal.Copy(array, 0, scan, num);
			destBitmap.UnlockBits(bitmapData2);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00019559 File Offset: 0x00017759
		private void trackBar_MouseUp(object sender, MouseEventArgs e)
		{
			this.Colorize(this.m_PreviewBitmap, this.m_OutputBitmap, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001958C File Offset: 0x0001778C
		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.Colorize(this.m_PreviewBitmap, this.m_OutputBitmap, false);
			this.pictureBox.BackgroundImage = this.m_OutputBitmap;
			this.pictureBox.Refresh();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000195EC File Offset: 0x000177EC
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_OutputBitmap = (Bitmap)this.m_InputBitmap.Clone();
			this.Colorize(this.m_InputBitmap, this.m_OutputBitmap, true);
		}

		// Token: 0x04000198 RID: 408
		private Bitmap m_InputBitmap;

		// Token: 0x04000199 RID: 409
		private Bitmap m_PreviewBitmap;

		// Token: 0x0400019A RID: 410
		private Bitmap m_OutputBitmap;
	}
}
