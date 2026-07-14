using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000047 RID: 71
	public class MipMap : RawImage
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x00022D20 File Offset: 0x00020F20
		public MipMap(int width, int height, EImageType dxtType, bool swapEndian)
			: base(width, height, dxtType, 0)
		{
			this.m_SwapEndian = swapEndian;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00022D34 File Offset: 0x00020F34
		public new bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Unknown0 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown4 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_UnknownC = FifaUtil.SwapEndian(r.ReadInt32());
				base.Load(r);
			}
			else
			{
				this.m_Unknown0 = r.ReadInt32();
				this.m_Unknown4 = r.ReadInt32();
				this.m_Size = r.ReadInt32();
				this.m_UnknownC = r.ReadInt32();
				base.Load(r);
			}
			return true;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00022DD0 File Offset: 0x00020FD0
		public new bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Unknown0));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown4));
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_UnknownC));
				base.Save(w);
			}
			else
			{
				w.Write(this.m_Unknown0);
				w.Write(this.m_Unknown4);
				w.Write(this.m_Size);
				w.Write(this.m_UnknownC);
				base.Save(w);
			}
			return true;
		}

		// Token: 0x04000E20 RID: 3616
		private int m_Unknown0;

		// Token: 0x04000E21 RID: 3617
		private int m_Unknown4;

		// Token: 0x04000E22 RID: 3618
		private int m_UnknownC;
	}
}
