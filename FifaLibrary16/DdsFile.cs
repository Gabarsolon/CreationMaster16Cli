using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000024 RID: 36
	public class DdsFile
	{
		// Token: 0x06000245 RID: 581 RVA: 0x00004648 File Offset: 0x00002848
		public DdsFile()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000095B4 File Offset: 0x000077B4
		public DdsFile(string fileName)
		{
			this.Load(fileName);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000095C4 File Offset: 0x000077C4
		public DdsFile(FifaFile fifaFile)
		{
			this.Load(fifaFile);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000095D4 File Offset: 0x000077D4
		public DdsFile(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000095E4 File Offset: 0x000077E4
		public bool Load(FifaFile fifaFile)
		{
			if (fifaFile.IsCompressed)
			{
				fifaFile.Decompress();
			}
			BinaryReader reader = fifaFile.GetReader();
			bool flag = this.Load(reader);
			fifaFile.ReleaseReader(reader);
			return flag;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009618 File Offset: 0x00007818
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			return flag;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00009648 File Offset: 0x00007848
		public bool Load(BinaryReader r)
		{
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_Signature != "DDS ")
			{
				return false;
			}
			this.m_HeaderSize = r.ReadUInt32();
			this.m_HeaderFlags = r.ReadUInt32();
			this.m_Height = r.ReadInt32();
			this.m_Width = r.ReadInt32();
			this.m_PitchOrLinearSize = r.ReadInt32();
			this.m_Depth = r.ReadInt32();
			this.m_MipMapCount = r.ReadInt32();
			for (int i = 0; i < 11; i++)
			{
				r.ReadInt32();
			}
			this.m_PixelFormatSize = r.ReadInt32();
			this.m_PixelFormatFlag = r.ReadInt32();
			this.m_FourCC = r.ReadInt32();
			int fourCC = this.m_FourCC;
			if (fourCC <= 827611204)
			{
				if (fourCC != 0)
				{
					if (fourCC == 827611204)
					{
						this.m_ImageType = EImageType.DXT1;
					}
				}
				else
				{
					this.m_ImageType = EImageType.A8R8G8B8;
				}
			}
			else if (fourCC != 861165636)
			{
				if (fourCC == 894720068)
				{
					this.m_ImageType = EImageType.DXT5;
				}
			}
			else
			{
				this.m_ImageType = EImageType.DXT3;
			}
			this.m_RGBBitCount = r.ReadInt32();
			this.m_RBitMask = r.ReadInt32();
			this.m_GBitMask = r.ReadInt32();
			this.m_BBitMask = r.ReadInt32();
			this.m_ABitMask = r.ReadInt32();
			this.m_SurfaceFlags = r.ReadInt32();
			this.m_CubemapFlags = r.ReadInt32();
			for (int j = 0; j < 3; j++)
			{
				r.ReadInt32();
			}
			if (this.m_MipMapCount > 0)
			{
				int num = this.m_Width / 4 * this.m_Height / 4 * 16;
				int num2 = this.m_Width;
				int num3 = this.m_Height;
				this.m_RawImages = new RawImage[this.m_MipMapCount + 1];
				for (int k = 0; k <= this.m_MipMapCount; k++)
				{
					this.m_RawImages[k] = new RawImage(num2, num3, this.m_ImageType, num);
					this.m_RawImages[k].Load(r);
					num /= 4;
					num2 /= 2;
					num3 /= 2;
				}
			}
			else
			{
				int num4 = (int)(r.BaseStream.Length - r.BaseStream.Position);
				this.m_RawImages = new RawImage[1];
				this.m_RawImages[0] = new RawImage(this.m_Width, this.m_Height, this.m_ImageType, num4);
				this.m_RawImages[0].Load(r);
			}
			return true;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000098AC File Offset: 0x00007AAC
		public bool Save(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			fileStream.Close();
			binaryWriter.Close();
			return flag;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000098DC File Offset: 0x00007ADC
		public bool Save(BinaryWriter w)
		{
			w.Write('D');
			w.Write('D');
			w.Write('S');
			w.Write(' ');
			w.Write(this.m_HeaderSize);
			w.Write(this.m_HeaderFlags);
			w.Write(this.m_Height);
			w.Write(this.m_Width);
			w.Write(this.m_PitchOrLinearSize);
			w.Write(this.m_Depth);
			w.Write(this.m_MipMapCount);
			for (int i = 0; i < 11; i++)
			{
				w.Write(0);
			}
			w.Write(this.m_PixelFormatSize);
			w.Write(this.m_PixelFormatFlag);
			w.Write(this.m_FourCC);
			w.Write(this.m_RGBBitCount);
			w.Write(this.m_RBitMask);
			w.Write(this.m_GBitMask);
			w.Write(this.m_BBitMask);
			w.Write(this.m_ABitMask);
			w.Write(this.m_SurfaceFlags);
			w.Write(this.m_CubemapFlags);
			for (int j = 0; j < 3; j++)
			{
				w.Write(0);
			}
			if (this.m_MipMapCount > 0)
			{
				for (int k = 0; k < this.m_MipMapCount + 1; k++)
				{
					this.m_RawImages[k].Save(w);
				}
			}
			else
			{
				this.m_RawImages[0].Save(w);
			}
			return true;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009A39 File Offset: 0x00007C39
		public Bitmap GetBitmap()
		{
			if (this.m_RawImages != null && this.m_RawImages.Length >= 1)
			{
				return this.m_RawImages[0].Bitmap;
			}
			return null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009A60 File Offset: 0x00007C60
		public void ReplaceBitmap(Bitmap bitmap)
		{
			if (this.m_MipMapCount > 0)
			{
				Bitmap bitmap2 = bitmap;
				this.m_RawImages[0].Bitmap = bitmap;
				for (int i = 1; i < this.m_MipMapCount + 1; i++)
				{
					bitmap2 = GraphicUtil.ReduceBitmap(bitmap2);
					this.m_RawImages[i].Bitmap = bitmap2;
				}
				return;
			}
			this.m_RawImages[0].Bitmap = bitmap;
		}

		// Token: 0x04000078 RID: 120
		private string m_Signature;

		// Token: 0x04000079 RID: 121
		private uint m_HeaderSize;

		// Token: 0x0400007A RID: 122
		private uint m_HeaderFlags;

		// Token: 0x0400007B RID: 123
		private int m_Width;

		// Token: 0x0400007C RID: 124
		private int m_Height;

		// Token: 0x0400007D RID: 125
		private int m_PitchOrLinearSize;

		// Token: 0x0400007E RID: 126
		private int m_Depth;

		// Token: 0x0400007F RID: 127
		private int m_MipMapCount;

		// Token: 0x04000080 RID: 128
		private int m_PixelFormatSize;

		// Token: 0x04000081 RID: 129
		private int m_PixelFormatFlag;

		// Token: 0x04000082 RID: 130
		private int m_FourCC;

		// Token: 0x04000083 RID: 131
		private EImageType m_ImageType;

		// Token: 0x04000084 RID: 132
		private int m_RGBBitCount;

		// Token: 0x04000085 RID: 133
		private int m_RBitMask;

		// Token: 0x04000086 RID: 134
		private int m_GBitMask;

		// Token: 0x04000087 RID: 135
		private int m_BBitMask;

		// Token: 0x04000088 RID: 136
		private int m_ABitMask;

		// Token: 0x04000089 RID: 137
		private int m_SurfaceFlags;

		// Token: 0x0400008A RID: 138
		private int m_CubemapFlags;

		// Token: 0x0400008B RID: 139
		private RawImage[] m_RawImages;
	}
}
