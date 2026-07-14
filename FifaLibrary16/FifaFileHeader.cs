using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200001E RID: 30
	public class FifaFileHeader
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000568A File Offset: 0x0000388A
		public FifaBigFile BigFile
		{
			get
			{
				return this.m_BigFile;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005692 File Offset: 0x00003892
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000569A File Offset: 0x0000389A
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000056A3 File Offset: 0x000038A3
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000056AB File Offset: 0x000038AB
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000056B4 File Offset: 0x000038B4
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000056BC File Offset: 0x000038BC
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000056C5 File Offset: 0x000038C5
		public FifaFileHeader(FifaBigFile bigFile)
		{
			this.m_BigFile = bigFile;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000056D4 File Offset: 0x000038D4
		public FifaFileHeader()
		{
			this.m_BigFile = null;
			this.m_StartPosition = 0U;
			this.m_Name = null;
			this.m_Size = 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000056F8 File Offset: 0x000038F8
		public bool Load(BinaryReader r)
		{
			this.m_StartPosition = FifaUtil.SwapEndian(r.ReadUInt32());
			this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Name = FifaUtil.ReadNullTerminatedString(r);
			return true;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005729 File Offset: 0x00003929
		public bool Save(BinaryWriter w)
		{
			w.Write(FifaUtil.SwapEndian(this.m_StartPosition));
			w.Write(FifaUtil.SwapEndian(this.m_Size));
			FifaUtil.WriteNullTerminatedString(w, this.m_Name);
			return true;
		}

		// Token: 0x04000042 RID: 66
		private FifaBigFile m_BigFile;

		// Token: 0x04000043 RID: 67
		private uint m_StartPosition;

		// Token: 0x04000044 RID: 68
		private int m_Size;

		// Token: 0x04000045 RID: 69
		private string m_Name;
	}
}
