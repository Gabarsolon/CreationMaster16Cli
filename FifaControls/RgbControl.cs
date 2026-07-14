using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000016 RID: 22
	public partial class RgbControl : Form
	{
		// Token: 0x06000118 RID: 280 RVA: 0x0000E888 File Offset: 0x0000CA88
		public RgbControl(Bitmap inputBitmap, Control caller)
		{
			if (inputBitmap == null)
			{
				return;
			}
			this.m_OutputBitmap = inputBitmap;
			this.m_InputBitmap = (Bitmap)inputBitmap.Clone();
			this.m_Caller = caller;
			this.InitializeComponent();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000E8BC File Offset: 0x0000CABC
		private void Colorize()
		{
			if (this.m_InputBitmap == null)
			{
				return;
			}
			if (this.m_InputBitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			int num = this.m_InputBitmap.Width * this.m_InputBitmap.Height;
			int[] array = new int[num];
			Rectangle rectangle = new Rectangle(0, 0, this.m_InputBitmap.Width, this.m_InputBitmap.Height);
			BitmapData bitmapData = this.m_InputBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_InputBitmap.PixelFormat);
			Marshal.Copy(bitmapData.Scan0, array, 0, num);
			this.m_InputBitmap.UnlockBits(bitmapData);
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
				array[i] = Color.FromArgb(a, num2, num3, num4).ToArgb();
			}
			rectangle = new Rectangle(0, 0, this.m_OutputBitmap.Width, this.m_OutputBitmap.Height);
			BitmapData bitmapData2 = this.m_OutputBitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_OutputBitmap.PixelFormat);
			IntPtr scan = bitmapData2.Scan0;
			Marshal.Copy(array, 0, scan, num);
			this.m_OutputBitmap.UnlockBits(bitmapData2);
			Cursor.Current = Cursors.Default;
			base.FindForm().Refresh();
			this.m_Caller.Refresh();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_InputBitmap = this.m_OutputBitmap;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000EABE File Offset: 0x0000CCBE
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.m_OutputBitmap = this.m_InputBitmap;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000A527 File Offset: 0x00008727
		private void trackBarRed_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000EACC File Offset: 0x0000CCCC
		private void trackBarRed_MouseDown(object sender, MouseEventArgs e)
		{
			this.m_MouseStatus = -1;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		private void trackBarRed_MouseUp(object sender, MouseEventArgs e)
		{
			this.m_MouseStatus = 0;
			this.Colorize();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.trackBarRed.Value = 0;
			this.trackBarGreen.Value = 0;
			this.trackBarBlue.Value = 0;
			this.Colorize();
		}

		// Token: 0x04000116 RID: 278
		private Bitmap m_InputBitmap;

		// Token: 0x04000117 RID: 279
		private Bitmap m_OutputBitmap;

		// Token: 0x04000118 RID: 280
		private Control m_Caller;

		// Token: 0x04000119 RID: 281
		private int m_MouseStatus;
	}
}
