using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000077 RID: 119
	public class Rx3ImageHeader
	{
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0003B039 File Offset: 0x00039239
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0003B041 File Offset: 0x00039241
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003B04A File Offset: 0x0003924A
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x0003B052 File Offset: 0x00039252
		public EImageType ImageType
		{
			get
			{
				return (EImageType)this.m_ImageType;
			}
			set
			{
				this.m_ImageType = (byte)value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003B05C File Offset: 0x0003925C
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0003B064 File Offset: 0x00039264
		public short Width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0003B06D File Offset: 0x0003926D
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0003B075 File Offset: 0x00039275
		public short Height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0003B07E File Offset: 0x0003927E
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0003B086 File Offset: 0x00039286
		public short NMipMaps
		{
			get
			{
				return this.m_NMipMaps;
			}
			set
			{
				this.m_NMipMaps = value;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0003B08F File Offset: 0x0003928F
		public Rx3ImageHeader(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0003B0A8 File Offset: 0x000392A8
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_FileSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_04 = r.ReadByte();
				this.m_ImageType = r.ReadByte();
				this.m_Unknown_06 = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Width = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Height = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_Unknown_0C = FifaUtil.SwapEndian(r.ReadInt16());
				this.m_NMipMaps = FifaUtil.SwapEndian(r.ReadInt16());
			}
			else
			{
				this.m_FileSize = r.ReadInt32();
				this.m_Unknown_04 = r.ReadByte();
				this.m_ImageType = r.ReadByte();
				this.m_Unknown_06 = r.ReadInt16();
				this.m_Width = r.ReadInt16();
				this.m_Height = r.ReadInt16();
				this.m_Unknown_0C = r.ReadInt16();
				this.m_NMipMaps = r.ReadInt16();
			}
			return true;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0003B1A4 File Offset: 0x000393A4
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_FileSize));
				w.Write(this.m_Unknown_04);
				w.Write(this.m_ImageType);
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_06));
				w.Write(FifaUtil.SwapEndian(this.m_Width));
				w.Write(FifaUtil.SwapEndian(this.m_Height));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_0C));
				w.Write(FifaUtil.SwapEndian(this.m_NMipMaps));
			}
			else
			{
				w.Write(this.m_FileSize);
				w.Write(this.m_Unknown_04);
				w.Write(this.m_ImageType);
				w.Write(this.m_Unknown_06);
				w.Write(this.m_Width);
				w.Write(this.m_Height);
				w.Write(this.m_Unknown_0C);
				w.Write(this.m_NMipMaps);
			}
			return true;
		}

		// Token: 0x04000FCB RID: 4043
		private int m_FileSize;

		// Token: 0x04000FCC RID: 4044
		private byte m_Unknown_04;

		// Token: 0x04000FCD RID: 4045
		private byte m_ImageType;

		// Token: 0x04000FCE RID: 4046
		private short m_Unknown_06;

		// Token: 0x04000FCF RID: 4047
		private short m_Width;

		// Token: 0x04000FD0 RID: 4048
		private short m_Height;

		// Token: 0x04000FD1 RID: 4049
		private short m_Unknown_0C;

		// Token: 0x04000FD2 RID: 4050
		private short m_NMipMaps;

		// Token: 0x04000FD3 RID: 4051
		private bool m_SwapEndian;
	}
}
