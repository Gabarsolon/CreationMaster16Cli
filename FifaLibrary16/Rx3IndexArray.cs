using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200007A RID: 122
	public class Rx3IndexArray
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0003B564 File Offset: 0x00039764
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0003B56B File Offset: 0x0003976B
		public static Rx3IndexArray.ETriangleListType TriangleListType
		{
			get
			{
				return Rx3IndexArray.s_TriangleListType;
			}
			set
			{
				Rx3IndexArray.s_TriangleListType = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0003B573 File Offset: 0x00039773
		public int NIndex
		{
			get
			{
				return this.m_nIndex;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0003B57B File Offset: 0x0003977B
		public int nFaces
		{
			get
			{
				return this.m_nFaces;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0003B583 File Offset: 0x00039783
		public short[] IndexStream
		{
			get
			{
				return this.m_IndexStream;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0003B58B File Offset: 0x0003978B
		public bool IsTriangleList
		{
			get
			{
				return this.m_IsTriangleList;
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0003B593 File Offset: 0x00039793
		public Rx3IndexArray(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0003B5AC File Offset: 0x000397AC
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_nIndex = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_SizeOfIndex = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_IndexStream = new short[this.m_nIndex];
				for (int i = 0; i < this.m_nIndex; i++)
				{
					this.m_IndexStream[i] = FifaUtil.SwapEndian(r.ReadInt16());
				}
			}
			else
			{
				this.m_Size = r.ReadInt32();
				this.m_nIndex = r.ReadInt32();
				this.m_SizeOfIndex = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_IndexStream = new short[this.m_nIndex];
				for (int j = 0; j < this.m_nIndex; j++)
				{
					this.m_IndexStream[j] = r.ReadInt16();
				}
			}
			this.m_IsTriangleList = false;
			this.m_nFaces = this.m_nIndex / 3;
			if (this.m_nFaces * 3 != this.m_nIndex)
			{
				this.m_IsTriangleList = true;
			}
			else
			{
				for (int k = 0; k < this.nFaces; k++)
				{
					short num = this.m_IndexStream[k * 3];
					short num2 = this.m_IndexStream[k * 3 + 1];
					short num3 = this.m_IndexStream[k * 3 + 2];
					if (num == num2 || num2 == num3 || num == num3)
					{
						this.m_IsTriangleList = true;
						break;
					}
				}
			}
			if (this.m_IsTriangleList)
			{
				this.m_nFaces = 0;
				for (int l = 0; l < this.m_nIndex - 2; l++)
				{
					short num4 = this.m_IndexStream[l];
					short num5 = this.m_IndexStream[l + 1];
					short num6 = this.m_IndexStream[l + 2];
					if (num4 != num5 && num5 != num6 && num4 != num6)
					{
						this.m_nFaces++;
					}
				}
			}
			return true;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0003B780 File Offset: 0x00039980
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_nIndex));
				w.Write(this.m_SizeOfIndex);
				w.Write(this.m_Unknown);
				for (int i = 0; i < this.m_nIndex; i++)
				{
					w.Write(FifaUtil.SwapEndian(this.m_IndexStream[i]));
				}
			}
			else
			{
				w.Write(this.m_Size);
				w.Write(this.m_nIndex);
				w.Write(this.m_SizeOfIndex);
				w.Write(this.m_Unknown);
				for (int j = 0; j < this.m_nIndex; j++)
				{
					w.Write(this.m_IndexStream[j]);
				}
			}
			return true;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0003B848 File Offset: 0x00039A48
		public bool SetIndexStream(short[] indexStream)
		{
			if (this.m_IndexStream.Length != indexStream.Length)
			{
				return false;
			}
			for (int i = 0; i < this.m_IndexStream.Length; i++)
			{
				this.m_IndexStream[i] = indexStream[i];
			}
			return true;
		}

		// Token: 0x04000FDC RID: 4060
		private static Rx3IndexArray.ETriangleListType s_TriangleListType;

		// Token: 0x04000FDD RID: 4061
		private int m_Size;

		// Token: 0x04000FDE RID: 4062
		private int m_nIndex;

		// Token: 0x04000FDF RID: 4063
		private int m_SizeOfIndex;

		// Token: 0x04000FE0 RID: 4064
		private int m_Unknown;

		// Token: 0x04000FE1 RID: 4065
		private int m_nFaces;

		// Token: 0x04000FE2 RID: 4066
		private short[] m_IndexStream;

		// Token: 0x04000FE3 RID: 4067
		private bool m_IsTriangleList;

		// Token: 0x04000FE4 RID: 4068
		private bool m_SwapEndian;

		// Token: 0x020000C3 RID: 195
		public enum ETriangleListType
		{
			// Token: 0x04001287 RID: 4743
			InvertOdd,
			// Token: 0x04001288 RID: 4744
			InvertEven
		}
	}
}
