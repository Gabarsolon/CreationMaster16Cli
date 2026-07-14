using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000045 RID: 69
	public class FshImage
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00021EC1 File Offset: 0x000200C1
		public Bitmap Bitmap
		{
			get
			{
				return this.m_MainSection.m_Bitmap;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00021ECE File Offset: 0x000200CE
		public FshImage(Fsh parent, BinaryReader r, int maxSize)
		{
			this.m_Parent = parent;
			this.m_MainSection = new FshSection(parent, r, maxSize);
			this.m_MainSection.RawDataToBmp();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00021EF7 File Offset: 0x000200F7
		public void Save(BinaryWriter w)
		{
			this.m_MainSection.Save(w);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00021F05 File Offset: 0x00020105
		public bool ReplaceBitmap(Bitmap bitmap)
		{
			return this.m_MainSection.ReplaceBitmap(bitmap);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00021F13 File Offset: 0x00020113
		public bool ReplaceRawData(byte[] rawData, int width, int height)
		{
			return this.m_MainSection.ReplaceRawData(rawData, width, height);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00021F23 File Offset: 0x00020123
		public byte[] GetRawData()
		{
			return this.m_MainSection.m_RawData;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00021F30 File Offset: 0x00020130
		public void Hash(string fileName)
		{
			for (FshSection fshSection = this.m_MainSection.NextSection; fshSection != null; fshSection = fshSection.NextSection)
			{
				if (fshSection.Type == 111)
				{
					fshSection.Hash(fileName);
					return;
				}
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00021F68 File Offset: 0x00020168
		public int ComputeLength()
		{
			int num = this.m_MainSection.m_Size;
			for (FshSection fshSection = this.m_MainSection.NextSection; fshSection != null; fshSection = fshSection.NextSection)
			{
				num += fshSection.m_Size;
			}
			return num;
		}

		// Token: 0x04000E16 RID: 3606
		private FshSection m_MainSection;

		// Token: 0x04000E17 RID: 3607
		private Fsh m_Parent;
	}
}
