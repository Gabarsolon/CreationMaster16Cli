using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000074 RID: 116
	public class Rx3FileDescriptor
	{
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003AB87 File Offset: 0x00038D87
		public uint Signature
		{
			get
			{
				return this.m_Signature;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0003AB8F File Offset: 0x00038D8F
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x0003AB97 File Offset: 0x00038D97
		public int Offset
		{
			get
			{
				return this.m_FileOffset;
			}
			set
			{
				this.m_FileOffset = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0003ABA0 File Offset: 0x00038DA0
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0003ABA8 File Offset: 0x00038DA8
		public int Size
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

		// Token: 0x060009D5 RID: 2517 RVA: 0x0003ABB1 File Offset: 0x00038DB1
		public Rx3FileDescriptor(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0003ABC8 File Offset: 0x00038DC8
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Signature = FifaUtil.SwapEndian(r.ReadUInt32());
				this.m_FileOffset = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_FileSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown_0c = FifaUtil.SwapEndian(r.ReadInt32());
			}
			else
			{
				this.m_Signature = r.ReadUInt32();
				this.m_FileOffset = r.ReadInt32();
				this.m_FileSize = r.ReadInt32();
				this.m_Unknown_0c = r.ReadInt32();
			}
			return true;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0003AC54 File Offset: 0x00038E54
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Signature));
				w.Write(FifaUtil.SwapEndian(this.m_FileOffset));
				w.Write(FifaUtil.SwapEndian(this.m_FileSize));
				w.Write(FifaUtil.SwapEndian(this.m_Unknown_0c));
			}
			else
			{
				w.Write(this.m_Signature);
				w.Write(this.m_FileOffset);
				w.Write(this.m_FileSize);
				w.Write(this.m_Unknown_0c);
			}
			return true;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0003ACE0 File Offset: 0x00038EE0
		public bool Is3dDirectory()
		{
			return this.m_Signature == 582139446U;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003ACEF File Offset: 0x00038EEF
		public bool IsTexture()
		{
			return this.m_Signature == 1879793882U;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0003ACFE File Offset: 0x00038EFE
		public bool IsImageDirectory()
		{
			return this.m_Signature == 1808827868U;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0003AD0D File Offset: 0x00038F0D
		public bool IsIndexStream()
		{
			return this.m_Signature == 5798132U;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0003AD1C File Offset: 0x00038F1C
		public bool IsVertexVector()
		{
			return this.m_Signature == 5798561U;
		}

		// Token: 0x04000FBE RID: 4030
		private uint m_Signature;

		// Token: 0x04000FBF RID: 4031
		private int m_FileOffset;

		// Token: 0x04000FC0 RID: 4032
		private int m_FileSize;

		// Token: 0x04000FC1 RID: 4033
		private int m_Unknown_0c;

		// Token: 0x04000FC2 RID: 4034
		private bool m_SwapEndian;
	}
}
