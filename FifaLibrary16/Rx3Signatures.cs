using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200007D RID: 125
	public class Rx3Signatures
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0003D12C File Offset: 0x0003B32C
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0003D134 File Offset: 0x0003B334
		public int Offset
		{
			get
			{
				return this.m_Offset;
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0003D13D File Offset: 0x0003B33D
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0003D145 File Offset: 0x0003B345
		public int Length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0003D14E File Offset: 0x0003B34E
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x0003D156 File Offset: 0x0003B356
		public string[] Signatures
		{
			get
			{
				return this.m_Signatures;
			}
			set
			{
				this.m_Signatures = value;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0003D15F File Offset: 0x0003B35F
		public Rx3Signatures(int offset, int length, string[] signatures)
		{
			this.Init(offset, length, signatures);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0003D170 File Offset: 0x0003B370
		private void Init(int offset, int length, string[] signatures)
		{
			this.m_Offset = offset;
			this.m_Length = length;
			this.m_Signatures = signatures;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0003D188 File Offset: 0x0003B388
		public bool Save(BinaryWriter w)
		{
			if (this.m_Signatures == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_Signatures.Length; i++)
			{
				w.BaseStream.Position = (long)(this.m_Offset + this.m_Length * i + 4);
				w.Write(this.m_Length - 8);
				w.Write(this.m_Signatures[i].ToCharArray(0, this.m_Signatures[i].Length));
				for (int j = this.m_Signatures[i].Length; j < this.m_Length - 8; j++)
				{
					w.Write(0);
				}
			}
			return true;
		}

		// Token: 0x04000FF3 RID: 4083
		private int m_Offset;

		// Token: 0x04000FF4 RID: 4084
		private int m_Length;

		// Token: 0x04000FF5 RID: 4085
		private string[] m_Signatures;
	}
}
