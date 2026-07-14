using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200002C RID: 44
	public class HuffmannTree
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000C139 File Offset: 0x0000A339
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0000C141 File Offset: 0x0000A341
		public int NNodes
		{
			get
			{
				return this.m_NNodes;
			}
			set
			{
				this.m_NNodes = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000C14A File Offset: 0x0000A34A
		public int Size
		{
			get
			{
				return this.m_NNodes * 4;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000C154 File Offset: 0x0000A354
		public HuffmannTree(int nNodes)
		{
			this.m_NNodes = nNodes;
			this.m_Child = new byte[this.m_NNodes, 2];
			this.m_Leaf = new byte[this.m_NNodes, 2];
			for (int i = 0; i < this.m_NNodes; i++)
			{
				this.m_Child[i, 0] = 0;
				this.m_Child[i, 1] = 0;
				this.m_Leaf[i, 0] = 0;
				this.m_Leaf[i, 1] = 0;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000C1FC File Offset: 0x0000A3FC
		public void Load(DbReader r)
		{
			for (int i = 0; i < this.m_NNodes; i++)
			{
				this.m_Child[i, 0] = r.ReadByte();
				this.m_Leaf[i, 0] = r.ReadByte();
				this.m_Child[i, 1] = r.ReadByte();
				this.m_Leaf[i, 1] = r.ReadByte();
			}
			this.BuildEncodingTable();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000C26C File Offset: 0x0000A46C
		public void Save(BinaryWriter w)
		{
			for (int i = 0; i < this.m_NNodes; i++)
			{
				w.Write(this.m_Child[i, 0]);
				w.Write(this.m_Leaf[i, 0]);
				w.Write(this.m_Child[i, 1]);
				w.Write(this.m_Leaf[i, 1]);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		private void BuildEncodingTable()
		{
			ushort[] array = new ushort[this.m_NNodes];
			byte[] array2 = new byte[this.m_NNodes];
			for (int i = 0; i < this.m_NNodes; i++)
			{
				ushort num = (ushort)(array[i] * 2 + 0);
				byte b = (byte)(array2[i] + 1);
				byte b2 = this.m_Child[i, 0];
				if (b2 != 0)
				{
					array[(int)b2] = num;
					array2[(int)b2] = b;
				}
				else
				{
					byte b3 = this.m_Leaf[i, 0];
					this.m_EncodingValue[(int)b3] = num;
					this.m_nBitsForEncoding[(int)b3] = b;
				}
				num += 1;
				byte b4 = this.m_Child[i, 1];
				if (b4 != 0)
				{
					array[(int)b4] = num;
					array2[(int)b4] = b;
				}
				else
				{
					byte b5 = this.m_Leaf[i, 1];
					this.m_EncodingValue[(int)b5] = num;
					this.m_nBitsForEncoding[(int)b5] = b;
				}
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C3B4 File Offset: 0x0000A5B4
		public string ReadString(DbReader r, int outputLength)
		{
			int num = 0;
			int num2 = 0;
			if (outputLength <= 0)
			{
				return string.Empty;
			}
			byte[] array;
			if (this.m_NNodes == 0)
			{
				array = r.ReadBytes(outputLength);
			}
			else
			{
				array = new byte[outputLength];
				do
				{
					byte b = r.ReadByte();
					for (int i = 7; i >= 0; i--)
					{
						int num3 = (b >> i) & 1;
						int num4 = (int)this.m_Child[num2, num3];
						if (num4 == 0)
						{
							array[num++] = this.m_Leaf[num2, num3];
							if (num == outputLength)
							{
								break;
							}
							num2 = 0;
						}
						else
						{
							num2 = num4;
						}
					}
				}
				while (num < outputLength);
			}
			return FifaUtil.ConvertBytesToString(array);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C448 File Offset: 0x0000A648
		public int WriteString(BinaryWriter w, string str, bool longString)
		{
			if (str == null || str.Length == 0)
			{
				return 0;
			}
			byte[] array = FifaUtil.ConvertStringToBytes(str);
			int num2;
			if (longString)
			{
				ushort num = (ushort)array.Length;
				w.Write(FifaUtil.SwapEndian(num));
				num2 = 2;
			}
			else
			{
				w.Write((byte)array.Length);
				num2 = 1;
			}
			if (this.m_NNodes == 0)
			{
				w.Write(array);
				return num2 + array.Length;
			}
			int num3 = 7;
			byte b = 0;
			foreach (byte b2 in array)
			{
				int num4 = (int)this.m_EncodingValue[(int)b2];
				int num5 = (int)this.m_nBitsForEncoding[(int)b2];
				if (num5 == 0)
				{
					num4 = (int)this.m_EncodingValue[32];
					num5 = (int)this.m_nBitsForEncoding[32];
				}
				for (int j = num5 - 1; j >= 0; j--)
				{
					if ((num4 & (1 << j)) != 0)
					{
						b = (byte)((int)b + (1 << num3));
					}
					num3--;
					if (num3 == -1)
					{
						num3 = 7;
						w.Write(b);
						num2++;
						b = 0;
					}
				}
			}
			w.Write(b);
			return num2 + 1;
		}

		// Token: 0x040000C6 RID: 198
		private byte[,] m_Child;

		// Token: 0x040000C7 RID: 199
		private byte[,] m_Leaf;

		// Token: 0x040000C8 RID: 200
		private ushort[] m_EncodingValue = new ushort[256];

		// Token: 0x040000C9 RID: 201
		private byte[] m_nBitsForEncoding = new byte[256];

		// Token: 0x040000CA RID: 202
		private int m_NNodes;
	}
}
