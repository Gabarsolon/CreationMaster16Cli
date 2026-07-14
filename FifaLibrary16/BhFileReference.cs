using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200001C RID: 28
	public class BhFileReference
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00005525 File Offset: 0x00003725
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000552D File Offset: 0x0000372D
		public uint StartPosition
		{
			get
			{
				return this.m_StartPosition;
			}
			set
			{
				this.m_StartPosition = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00005536 File Offset: 0x00003736
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000553E File Offset: 0x0000373E
		public int Size
		{
			get
			{
				return this.m_Size;
			}
			set
			{
				this.m_Size = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00005547 File Offset: 0x00003747
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000554F File Offset: 0x0000374F
		public int UncompressedSize
		{
			get
			{
				return this.m_UncompressedSize;
			}
			set
			{
				this.m_UncompressedSize = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00005558 File Offset: 0x00003758
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00005560 File Offset: 0x00003760
		public ulong Hash
		{
			get
			{
				return this.m_Hash;
			}
			set
			{
				this.m_Hash = value;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000556C File Offset: 0x0000376C
		public BhFileReference(uint startPosition, int size, int uncompressedSize, string name)
		{
			this.m_StartPosition = startPosition;
			this.m_Size = size;
			this.m_UncompressedSize = uncompressedSize;
			if (this.m_UncompressedSize != 0)
			{
				this.m_Size = (this.m_Size + 15 >> 4) * 16;
			}
			this.m_Hash = FifaUtil.ComputeBhHash(name);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00004648 File Offset: 0x00002848
		public BhFileReference()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000055C0 File Offset: 0x000037C0
		public bool Load(BinaryReader r)
		{
			this.m_StartPosition = FifaUtil.SwapEndian(r.ReadUInt32());
			this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Hash = FifaUtil.SwapEndian(r.ReadUInt64());
			return true;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005614 File Offset: 0x00003814
		public bool Save(BinaryWriter w)
		{
			w.Write(FifaUtil.SwapEndian(this.m_StartPosition));
			w.Write(FifaUtil.SwapEndian(this.m_Size));
			w.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			w.Write(FifaUtil.SwapEndian(this.m_Hash));
			return true;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005666 File Offset: 0x00003866
		public void Hide()
		{
			this.m_Hash = 0UL;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005670 File Offset: 0x00003870
		public bool IsHidden()
		{
			return this.m_Hash == 0UL;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000567C File Offset: 0x0000387C
		public void Restore(string name)
		{
			this.m_Hash = FifaUtil.ComputeBhHash(name);
		}

		// Token: 0x04000034 RID: 52
		private uint m_StartPosition;

		// Token: 0x04000035 RID: 53
		private int m_Size;

		// Token: 0x04000036 RID: 54
		private int m_UncompressedSize;

		// Token: 0x04000037 RID: 55
		private ulong m_Hash;
	}
}
