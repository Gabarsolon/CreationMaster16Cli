using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000042 RID: 66
	public class Fsh
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000203CF File Offset: 0x0001E5CF
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000203D7 File Offset: 0x0001E5D7
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
			set
			{
				this.m_FileName = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000203E0 File Offset: 0x0001E5E0
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x000203E8 File Offset: 0x0001E5E8
		public int FileSize
		{
			get
			{
				return this.m_FileSize;
			}
			set
			{
				this.m_FileSize = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x000203F1 File Offset: 0x0001E5F1
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000203F9 File Offset: 0x0001E5F9
		public ImageDir[] ImageDir
		{
			get
			{
				return this.m_ImageDir;
			}
			set
			{
				this.m_ImageDir = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00020402 File Offset: 0x0001E602
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0002040A File Offset: 0x0001E60A
		public FshImage[] FshImages
		{
			get
			{
				return this.m_FshImages;
			}
			set
			{
				this.m_FshImages = value;
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00020413 File Offset: 0x0001E613
		public Fsh(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00020424 File Offset: 0x0001E624
		public Fsh(string filePath)
		{
			this.m_FileName = filePath;
			FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			if (fileStream == null)
			{
				return;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			if (binaryReader == null)
			{
				return;
			}
			this.Load(binaryReader);
			binaryReader.Close();
			fileStream.Close();
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0002046C File Offset: 0x0001E66C
		public bool Load(BinaryReader r)
		{
			if ((int)r.BaseStream.Length < 4)
			{
				return false;
			}
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_Signature != "SHPI")
			{
				return false;
			}
			this.m_FileSize = r.ReadInt32();
			this.m_NImages = r.ReadInt32();
			this.m_DirId = new string(r.ReadChars(4));
			this.m_ImageDir = new ImageDir[this.m_NImages];
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i] = new ImageDir(r);
			}
			int num = this.m_FileSize;
			for (int j = 0; j < this.m_NImages; j++)
			{
				if (this.m_ImageDir[j].Offset < num)
				{
					num = this.m_ImageDir[j].Offset;
				}
			}
			int num2 = num - (16 + 8 * this.m_NImages);
			if (num2 > 0)
			{
				this.m_DirPad = r.ReadBytes(num2);
			}
			this.m_FshImages = new FshImage[this.m_NImages];
			for (int k = 0; k < this.m_NImages; k++)
			{
				int num3 = ((k + 1 < this.m_NImages) ? (this.m_ImageDir[k + 1].Offset - this.m_ImageDir[k].Offset) : (this.m_FileSize - this.m_ImageDir[k].Offset));
				this.m_FshImages[k] = new FshImage(this, r, num3);
			}
			return true;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000205DC File Offset: 0x0001E7DC
		public bool Save(BinaryWriter w)
		{
			w.Write('S');
			w.Write('H');
			w.Write('P');
			w.Write('I');
			w.Write(this.m_FileSize);
			w.Write(this.m_NImages);
			char[] array = this.m_DirId.ToCharArray();
			w.Write((byte)array[0]);
			w.Write((byte)array[1]);
			w.Write((byte)array[2]);
			w.Write((byte)array[3]);
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i].Save(w);
			}
			if (this.m_DirPad != null)
			{
				w.Write(this.m_DirPad);
			}
			for (int j = 0; j < this.m_NImages; j++)
			{
				this.m_FshImages[j].Save(w);
			}
			return true;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000206A8 File Offset: 0x0001E8A8
		public bool Save()
		{
			return this.Save(this.m_FileName);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000206B8 File Offset: 0x0001E8B8
		public bool Save(string fileName)
		{
			if (fileName == null)
			{
				return false;
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			binaryWriter.Close();
			fileStream.Close();
			return flag;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000206EC File Offset: 0x0001E8EC
		public void Hash(string fileName)
		{
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_FshImages[i].Hash(fileName);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00020718 File Offset: 0x0001E918
		public void ComputeImageDir()
		{
			int num = this.m_ImageDir[0].Offset;
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i].Offset = num;
				num += this.m_FshImages[i].ComputeLength();
			}
			this.m_FileSize = num;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002076C File Offset: 0x0001E96C
		public void ReplaceBitmaps(Bitmap[] bitmaps)
		{
			int num = ((bitmaps.Length <= this.m_NImages) ? bitmaps.Length : this.m_NImages);
			for (int i = 0; i < num; i++)
			{
				this.m_FshImages[i].ReplaceBitmap(bitmaps[i]);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000207AD File Offset: 0x0001E9AD
		public bool ReplaceBitmap(Bitmap bitmap, int index)
		{
			return index < this.m_NImages && this.m_FshImages[index].ReplaceBitmap(bitmap);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000207C8 File Offset: 0x0001E9C8
		public Bitmap GetBitmap(int index)
		{
			if (index < this.m_NImages)
			{
				return this.m_FshImages[index].Bitmap;
			}
			return null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000207E4 File Offset: 0x0001E9E4
		public Bitmap[] GetBitmaps()
		{
			Bitmap[] array = new Bitmap[this.m_NImages];
			for (int i = 0; i < this.m_NImages; i++)
			{
				array[i] = this.m_FshImages[i].Bitmap;
			}
			return array;
		}

		// Token: 0x04000DFC RID: 3580
		private string m_FileName;

		// Token: 0x04000DFD RID: 3581
		private string m_DirId;

		// Token: 0x04000DFE RID: 3582
		private string m_Signature;

		// Token: 0x04000DFF RID: 3583
		private int m_FileSize;

		// Token: 0x04000E00 RID: 3584
		private int m_NImages;

		// Token: 0x04000E01 RID: 3585
		private ImageDir[] m_ImageDir;

		// Token: 0x04000E02 RID: 3586
		private byte[] m_DirPad;

		// Token: 0x04000E03 RID: 3587
		private FshImage[] m_FshImages;
	}
}
