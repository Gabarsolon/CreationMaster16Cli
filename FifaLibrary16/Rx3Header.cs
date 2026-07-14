using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000073 RID: 115
	public class Rx3Header
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		public int SizeOf_
		{
			get
			{
				return this.m_SizeOf_;
			}
			set
			{
				this.m_SizeOf_ = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0003AA01 File Offset: 0x00038C01
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0003AA09 File Offset: 0x00038C09
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

		// Token: 0x060009CD RID: 2509 RVA: 0x0003AA12 File Offset: 0x00038C12
		public Rx3Header(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0003AA2C File Offset: 0x00038C2C
		public bool Load(BinaryReader r)
		{
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_SwapEndian)
			{
				if (!(this.m_Signature == "RX3b"))
				{
					return false;
				}
				this.m_Unknown_04 = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_SizeOf_ = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
			}
			else
			{
				if (!(this.m_Signature == "RX3l"))
				{
					return false;
				}
				this.m_Unknown_04 = r.ReadInt32();
				this.m_SizeOf_ = r.ReadInt32();
				this.m_NFiles = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write('R');
				w.Write('X');
				w.Write('3');
				w.Write('b');
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_04));
				w.Write(FifaUtil.SwapEndian(this.m_SizeOf_));
				w.Write(FifaUtil.SwapEndian(this.m_NFiles));
			}
			else
			{
				w.Write('R');
				w.Write('X');
				w.Write('3');
				w.Write('l');
				w.Write(this.m_Unknown_04);
				w.Write(this.m_SizeOf_);
				w.Write(this.m_NFiles);
			}
			return true;
		}

		// Token: 0x04000FB9 RID: 4025
		private string m_Signature;

		// Token: 0x04000FBA RID: 4026
		private int m_Unknown_04;

		// Token: 0x04000FBB RID: 4027
		private int m_SizeOf_;

		// Token: 0x04000FBC RID: 4028
		private int m_NFiles;

		// Token: 0x04000FBD RID: 4029
		private bool m_SwapEndian;
	}
}
