using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000075 RID: 117
	public class Rx3ImageDirectory
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0003AD2B File Offset: 0x00038F2B
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0003AD33 File Offset: 0x00038F33
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
			set
			{
				this.m_NFiles = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0003AD3C File Offset: 0x00038F3C
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x0003AD44 File Offset: 0x00038F44
		public Rx3ImageHeader[] Rx3ImageHeader
		{
			get
			{
				return this.m_Rx3ImageHeader;
			}
			set
			{
				this.m_Rx3ImageHeader = value;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0003AD4D File Offset: 0x00038F4D
		public Rx3ImageDirectory(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0003AD64 File Offset: 0x00038F64
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ImageHeader = new Rx3ImageHeader[this.m_NFiles];
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ImageHeader[i] = new Rx3ImageHeader(r, this.m_SwapEndian);
				}
			}
			else
			{
				this.m_NFiles = r.ReadInt32();
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ImageHeader = new Rx3ImageHeader[this.m_NFiles];
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ImageHeader[j] = new Rx3ImageHeader(r, this.m_SwapEndian);
				}
			}
			return true;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0003AE24 File Offset: 0x00039024
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
				w.Write(this.m_Padding);
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ImageHeader[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_NFiles);
				w.Write(this.m_Padding);
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ImageHeader[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x04000FC3 RID: 4035
		private int m_NFiles;

		// Token: 0x04000FC4 RID: 4036
		private byte[] m_Padding;

		// Token: 0x04000FC5 RID: 4037
		private Rx3ImageHeader[] m_Rx3ImageHeader;

		// Token: 0x04000FC6 RID: 4038
		private bool m_SwapEndian;
	}
}
