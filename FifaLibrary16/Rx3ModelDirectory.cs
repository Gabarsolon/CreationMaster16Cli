using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000076 RID: 118
	public class Rx3ModelDirectory
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0003AEB1 File Offset: 0x000390B1
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0003AEB9 File Offset: 0x000390B9
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

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0003AEC2 File Offset: 0x000390C2
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0003AECA File Offset: 0x000390CA
		public Rx3ModelHeader[] Rx3ModelHeader
		{
			get
			{
				return this.m_Rx3ModelHeader;
			}
			set
			{
				this.m_Rx3ModelHeader = value;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0003AED3 File Offset: 0x000390D3
		public Rx3ModelDirectory(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0003AEEC File Offset: 0x000390EC
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ModelHeader = new Rx3ModelHeader[this.m_NFiles];
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ModelHeader[i] = new Rx3ModelHeader(r, this.m_SwapEndian);
				}
			}
			else
			{
				this.m_NFiles = r.ReadInt32();
				this.m_Padding = r.ReadBytes(12);
				this.m_Rx3ModelHeader = new Rx3ModelHeader[this.m_NFiles];
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ModelHeader[j] = new Rx3ModelHeader(r, this.m_SwapEndian);
				}
			}
			return true;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0003AFAC File Offset: 0x000391AC
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
				w.Write(this.m_Padding);
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_Rx3ModelHeader[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_NFiles);
				w.Write(this.m_Padding);
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Rx3ModelHeader[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x04000FC7 RID: 4039
		private int m_NFiles;

		// Token: 0x04000FC8 RID: 4040
		private byte[] m_Padding;

		// Token: 0x04000FC9 RID: 4041
		private Rx3ModelHeader[] m_Rx3ModelHeader;

		// Token: 0x04000FCA RID: 4042
		private bool m_SwapEndian;
	}
}
