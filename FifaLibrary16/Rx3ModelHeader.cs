using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000078 RID: 120
	public class Rx3ModelHeader
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x0003B29D File Offset: 0x0003949D
		public Rx3ModelHeader(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0003B2B4 File Offset: 0x000394B4
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Unknown_00 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_04 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_08 = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			else
			{
				this.m_Unknown_00 = r.ReadInt32();
				this.m_Unknown_04 = r.ReadInt32();
				this.m_Unknown_08 = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0003B338 File Offset: 0x00039538
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_00));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_04));
				w.Write(this.m_Unknown_08);
				w.Write(this.m_Unknown_0c);
			}
			else
			{
				w.Write(this.m_Unknown_00);
				w.Write(this.m_Unknown_04);
				w.Write(this.m_Unknown_08);
				w.Write(this.m_Unknown_0c);
			}
			return true;
		}

		// Token: 0x04000FD4 RID: 4052
		private int m_Unknown_00;

		// Token: 0x04000FD5 RID: 4053
		private int m_Unknown_04;

		// Token: 0x04000FD6 RID: 4054
		private int m_Unknown_08;

		// Token: 0x04000FD7 RID: 4055
		private int m_Unknown_0c;

		// Token: 0x04000FD8 RID: 4056
		private bool m_SwapEndian;
	}
}
