using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200009F RID: 159
	public class UgcDirEntry
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00056399 File Offset: 0x00054599
		public uint Offset
		{
			get
			{
				return this.m_Offset;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000563A1 File Offset: 0x000545A1
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000563A9 File Offset: 0x000545A9
		public override string ToString()
		{
			return Path.GetFileName(this.m_FileName);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000563B6 File Offset: 0x000545B6
		public UgcDirEntry(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x000563C6 File Offset: 0x000545C6
		public bool Load(BinaryReader r)
		{
			r.ReadBytes(16);
			this.m_Offset = r.ReadUInt32();
			r.ReadInt16();
			this.m_FileName = FifaUtil.ReadNullPaddedString(r, 66);
			return true;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000563F3 File Offset: 0x000545F3
		public bool IsPng()
		{
			return this.m_FileName.EndsWith("png");
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00056405 File Offset: 0x00054605
		public bool IsDb()
		{
			return this.m_FileName.EndsWith("db");
		}

		// Token: 0x040011B7 RID: 4535
		private uint m_Offset;

		// Token: 0x040011B8 RID: 4536
		private string m_FileName;
	}
}
