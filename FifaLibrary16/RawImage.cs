using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace FifaLibrary
{
	// Token: 0x02000046 RID: 70
	public class RawImage
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00021FA3 File Offset: 0x000201A3
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00021FB9 File Offset: 0x000201B9
		public Bitmap Bitmap
		{
			get
			{
				if (this.m_Bitmap == null)
				{
					this.CreateBitmap();
				}
				return this.m_Bitmap;
			}
			set
			{
				this.m_Bitmap = value;
				this.m_NeedToSaveRawData = true;
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00021FC9 File Offset: 0x000201C9
		public RawImage(int width, int height, EImageType dxtType, int size)
		{
			this.m_Width = width;
			this.m_Height = height;
			this.m_ImageType = dxtType;
			this.m_Size = size;
			this.m_Bitmap = null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00021FF8 File Offset: 0x000201F8
		public bool Load(BinaryReader r)
		{
			int num = this.m_Size;
			if (this.m_ImageType == EImageType.A8R8G8B8)
			{
				num = this.m_Width * this.m_Height * 4;
			}
			this.m_RawData = r.ReadBytes(num);
			this.m_NeedToSaveRawData = false;
			return true;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0002203A File Offset: 0x0002023A
		public bool Save(BinaryWriter w)
		{
			if (this.m_NeedToSaveRawData)
			{
				this.CreateRawData();
				this.m_NeedToSaveRawData = false;
			}
			w.Write(this.m_RawData);
			return true;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00022060 File Offset: 0x00020260
		private void CreateBitmap()
		{
			if (this.m_Width < 1)
			{
				this.m_Width = 1;
			}
			if (this.m_Height < 1)
			{
				this.m_Height = 1;
			}
			switch (this.m_ImageType)
			{
			case EImageType.DXT1:
			case EImageType.DXT3:
			case EImageType.DXT5:
				this.m_Bitmap = new Bitmap(this.m_Width, this.m_Height, PixelFormat.Format32bppArgb);
				this.ReadDxtToBitmap();
				return;
			case EImageType.A8R8G8B8:
			{
				this.m_Bitmap = new Bitmap(this.m_Width, this.m_Height, PixelFormat.Format32bppArgb);
				Rectangle rectangle = new Rectangle(0, 0, this.m_Bitmap.Width, this.m_Bitmap.Height);
				BitmapData bitmapData = this.m_Bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_Bitmap.PixelFormat);
				IntPtr scan = bitmapData.Scan0;
				int num = this.m_Bitmap.Width * this.m_Bitmap.Height;
				Marshal.Copy(this.m_RawData, 0, scan, num * 4);
				this.m_Bitmap.UnlockBits(bitmapData);
				return;
			}
			case EImageType.GREY8:
			{
				this.m_Bitmap = new Bitmap(this.m_Width, this.m_Height, PixelFormat.Format32bppArgb);
				int num2 = 0;
				for (int i = 0; i < this.m_Bitmap.Height; i++)
				{
					for (int j = 0; j < this.m_Bitmap.Width; j++)
					{
						byte b = this.m_RawData[num2++];
						int num3 = 255;
						int num4 = (int)b;
						int num5 = (int)b;
						int num6 = (int)b;
						this.m_Bitmap.SetPixel(j, i, Color.FromArgb(num3, num4, num5, num6));
					}
				}
				return;
			}
			case EImageType.GREY8ALFA8:
			{
				this.m_Bitmap = new Bitmap(this.m_Width, this.m_Height, PixelFormat.Format32bppArgb);
				int num2 = 0;
				for (int k = 0; k < this.m_Bitmap.Height; k++)
				{
					for (int l = 0; l < this.m_Bitmap.Width; l++)
					{
						byte b2 = this.m_RawData[num2++];
						int num7 = (int)this.m_RawData[num2++];
						int num8 = (int)b2;
						int num9 = (int)b2;
						int num10 = (int)b2;
						this.m_Bitmap.SetPixel(l, k, Color.FromArgb(num7, num8, num9, num10));
					}
				}
				return;
			}
			case (EImageType)6:
				break;
			case EImageType.DC_XY_NORMAL_MAP:
				this.m_Bitmap = new Bitmap(this.m_Width, this.m_Height, PixelFormat.Format32bppArgb);
				this.ReadDxtToBitmap();
				break;
			default:
				return;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000222B8 File Offset: 0x000204B8
		private void CreateRawData()
		{
			if (this.m_Width < 1)
			{
				this.m_Width = 1;
			}
			if (this.m_Height < 1)
			{
				this.m_Height = 1;
			}
			switch (this.m_ImageType)
			{
			case EImageType.DXT1:
			case EImageType.DXT3:
			case EImageType.DXT5:
			case EImageType.DC_XY_NORMAL_MAP:
				this.WriteBitmapToDxt();
				return;
			case EImageType.A8R8G8B8:
				this.WriteBitmapToA8R8G8B8();
				return;
			case EImageType.GREY8:
				this.WriteBitmapToGrey8();
				return;
			case EImageType.GREY8ALFA8:
				this.WriteBitmapToGrey8Alfa8();
				break;
			case (EImageType)6:
				break;
			default:
				return;
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00022330 File Offset: 0x00020530
		private void ReadDxtToBitmap()
		{
			DxtBlock dxtBlock = new DxtBlock((int)this.m_ImageType);
			MemoryStream memoryStream = new MemoryStream(this.m_RawData);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			Rectangle rectangle = new Rectangle(0, 0, this.m_Width, this.m_Height);
			BitmapData bitmapData = this.m_Bitmap.LockBits(rectangle, ImageLockMode.WriteOnly, this.m_Bitmap.PixelFormat);
			IntPtr scan = bitmapData.Scan0;
			int num = this.m_Bitmap.Width * this.m_Bitmap.Height;
			int[] array = new int[num];
			for (int i = 0; i < this.m_Bitmap.Height / 4; i++)
			{
				for (int j = 0; j < this.m_Bitmap.Width / 4; j++)
				{
					dxtBlock.Load(binaryReader);
					int num2 = i * 4 * this.m_Bitmap.Width;
					num2 += j * 4;
					array[num2] = dxtBlock.Colors[0, 0].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 0].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 0].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 0].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 1].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 1].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 1].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 1].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 2].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 2].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 2].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 2].ToArgb();
					num2 += this.m_Bitmap.Width;
					array[num2] = dxtBlock.Colors[0, 3].ToArgb();
					array[num2 + 1] = dxtBlock.Colors[1, 3].ToArgb();
					array[num2 + 2] = dxtBlock.Colors[2, 3].ToArgb();
					array[num2 + 3] = dxtBlock.Colors[3, 3].ToArgb();
				}
			}
			Marshal.Copy(array, 0, scan, num);
			this.m_Bitmap.UnlockBits(bitmapData);
			binaryReader.Close();
			memoryStream.Close();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000225FC File Offset: 0x000207FC
		private void WriteBitmapToA8R8G8B8()
		{
			if (this.m_Bitmap.Height * this.m_Bitmap.Width * 4 > this.m_RawData.Length)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < this.m_Bitmap.Height; i++)
			{
				for (int j = 0; j < this.m_Bitmap.Width; j++)
				{
					Color pixel = this.m_Bitmap.GetPixel(j, i);
					byte b = pixel.B;
					byte g = pixel.G;
					byte r = pixel.R;
					byte a = pixel.A;
					this.m_RawData[num++] = b;
					this.m_RawData[num++] = g;
					this.m_RawData[num++] = r;
					this.m_RawData[num++] = a;
				}
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000226CC File Offset: 0x000208CC
		private void WriteBitmapToDxt()
		{
			MemoryStream memoryStream = new MemoryStream(this.m_RawData);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			DxtBlock dxtBlock = new DxtBlock((int)this.m_ImageType);
			int num = (this.m_Bitmap.Height + 3) / 4;
			int num2 = (this.m_Bitmap.Width + 3) / 4;
			if (this.m_Bitmap.Height < 4 || this.m_Bitmap.Width < 4)
			{
				dxtBlock.Colors[0, 0] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[0, 1] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[0, 2] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[0, 3] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[1, 0] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[1, 1] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[1, 2] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[1, 3] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[2, 0] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[2, 1] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[2, 2] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[2, 3] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[3, 0] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[3, 1] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[3, 2] = Color.FromArgb(0, 128, 128, 128);
				dxtBlock.Colors[3, 3] = Color.FromArgb(0, 128, 128, 128);
				for (int i = 0; i < this.m_Bitmap.Width; i++)
				{
					for (int j = 0; j < this.m_Bitmap.Height; j++)
					{
						if (i >= 0 && j >= 0 && i < 4 && j < 4)
						{
							dxtBlock.Colors[i, j] = this.m_Bitmap.GetPixel(i, j);
						}
					}
				}
				dxtBlock.Save(binaryWriter);
			}
			else
			{
				for (int k = 0; k < num; k++)
				{
					int num3 = k * 4;
					for (int l = 0; l < num2; l++)
					{
						int num4 = l * 4;
						dxtBlock.Colors[0, 0] = this.m_Bitmap.GetPixel(num4 + 0, num3 + 0);
						dxtBlock.Colors[0, 1] = this.m_Bitmap.GetPixel(num4 + 0, num3 + 1);
						dxtBlock.Colors[0, 2] = this.m_Bitmap.GetPixel(num4 + 0, num3 + 2);
						dxtBlock.Colors[0, 3] = this.m_Bitmap.GetPixel(num4 + 0, num3 + 3);
						dxtBlock.Colors[1, 0] = this.m_Bitmap.GetPixel(num4 + 1, num3 + 0);
						dxtBlock.Colors[1, 1] = this.m_Bitmap.GetPixel(num4 + 1, num3 + 1);
						dxtBlock.Colors[1, 2] = this.m_Bitmap.GetPixel(num4 + 1, num3 + 2);
						dxtBlock.Colors[1, 3] = this.m_Bitmap.GetPixel(num4 + 1, num3 + 3);
						dxtBlock.Colors[2, 0] = this.m_Bitmap.GetPixel(num4 + 2, num3 + 0);
						dxtBlock.Colors[2, 1] = this.m_Bitmap.GetPixel(num4 + 2, num3 + 1);
						dxtBlock.Colors[2, 2] = this.m_Bitmap.GetPixel(num4 + 2, num3 + 2);
						dxtBlock.Colors[2, 3] = this.m_Bitmap.GetPixel(num4 + 2, num3 + 3);
						dxtBlock.Colors[3, 0] = this.m_Bitmap.GetPixel(num4 + 3, num3 + 0);
						dxtBlock.Colors[3, 1] = this.m_Bitmap.GetPixel(num4 + 3, num3 + 1);
						dxtBlock.Colors[3, 2] = this.m_Bitmap.GetPixel(num4 + 3, num3 + 2);
						dxtBlock.Colors[3, 3] = this.m_Bitmap.GetPixel(num4 + 3, num3 + 3);
						dxtBlock.Save(binaryWriter);
					}
				}
			}
			binaryWriter.Close();
			memoryStream.Close();
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00022C18 File Offset: 0x00020E18
		private void WriteBitmapToGrey8()
		{
			if (this.m_Bitmap.Height * this.m_Bitmap.Width > this.m_RawData.Length)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < this.m_Bitmap.Height; i++)
			{
				for (int j = 0; j < this.m_Bitmap.Width; j++)
				{
					byte b = this.m_Bitmap.GetPixel(j, i).B;
					this.m_RawData[num++] = b;
				}
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00022C9C File Offset: 0x00020E9C
		private void WriteBitmapToGrey8Alfa8()
		{
			if (this.m_Bitmap.Height * this.m_Bitmap.Width * 4 > this.m_RawData.Length)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < this.m_Bitmap.Height; i++)
			{
				for (int j = 0; j < this.m_Bitmap.Width; j++)
				{
					byte b = this.m_Bitmap.GetPixel(j, i).B;
					this.m_RawData[num++] = b;
				}
			}
		}

		// Token: 0x04000E18 RID: 3608
		private int m_Width;

		// Token: 0x04000E19 RID: 3609
		private int m_Height;

		// Token: 0x04000E1A RID: 3610
		private EImageType m_ImageType;

		// Token: 0x04000E1B RID: 3611
		protected bool m_SwapEndian;

		// Token: 0x04000E1C RID: 3612
		private Bitmap m_Bitmap;

		// Token: 0x04000E1D RID: 3613
		private bool m_NeedToSaveRawData;

		// Token: 0x04000E1E RID: 3614
		private byte[] m_RawData;

		// Token: 0x04000E1F RID: 3615
		protected int m_Size;
	}
}
