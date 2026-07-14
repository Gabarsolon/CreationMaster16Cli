using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000027 RID: 39
	public class DbReader : BinaryReader
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00009FB4 File Offset: 0x000081B4
		public DbReader(Stream stream, FifaPlatform platform)
			: base(stream)
		{
			this.m_Platform = platform;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00009FC4 File Offset: 0x000081C4
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00009FCC File Offset: 0x000081CC
		public FifaPlatform Platform
		{
			get
			{
				return this.m_Platform;
			}
			set
			{
				this.m_Platform = value;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009FD5 File Offset: 0x000081D5
		public override short ReadInt16()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(2);
				Array.Reverse(array);
				return BitConverter.ToInt16(array, 0);
			}
			return base.ReadInt16();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009FFA File Offset: 0x000081FA
		public override ushort ReadUInt16()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(2);
				Array.Reverse(array);
				return BitConverter.ToUInt16(array, 0);
			}
			return base.ReadUInt16();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A01F File Offset: 0x0000821F
		public override int ReadInt32()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToInt32(array, 0);
			}
			return base.ReadInt32();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A044 File Offset: 0x00008244
		public override uint ReadUInt32()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToUInt32(array, 0);
			}
			return base.ReadUInt32();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000A069 File Offset: 0x00008269
		public override long ReadInt64()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToInt64(array, 0);
			}
			return base.ReadInt64();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000A08E File Offset: 0x0000828E
		public override ulong ReadUInt64()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToUInt64(array, 0);
			}
			return base.ReadUInt64();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000A0B3 File Offset: 0x000082B3
		public override float ReadSingle()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToSingle(array, 0);
			}
			return base.ReadSingle();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000A0D8 File Offset: 0x000082D8
		public override double ReadDouble()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToDouble(array, 0);
			}
			return base.ReadDouble();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000A0FD File Offset: 0x000082FD
		public int PopInteger(FieldDescriptor fieldDescriptor)
		{
			if (this.m_Platform == FifaPlatform.PC)
			{
				return this.PopIntegerPc(fieldDescriptor);
			}
			return this.PopIntegerXbox(fieldDescriptor);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000A118 File Offset: 0x00008318
		private int PopIntegerXbox(FieldDescriptor fieldDescriptor)
		{
			int num = (int)this.ReadByte();
			int num2 = fieldDescriptor.BitOffset % 8;
			int num3 = 0;
			for (int i = fieldDescriptor.Depth - 1; i >= 0; i--)
			{
				int num4 = (((num & (128 >> num2)) == 0) ? 0 : 1);
				num3 += num4 << i;
				num2++;
				if (num2 == 8)
				{
					num = (int)this.ReadByte();
					num2 = 0;
				}
			}
			return num3 + fieldDescriptor.RangeLow;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000A184 File Offset: 0x00008384
		private int PopIntegerPc(FieldDescriptor fieldDescriptor)
		{
			int num = 0;
			int depth = fieldDescriptor.Depth;
			int i = 0;
			if (this.m_CurrentBitPosition != 0)
			{
				i = 8 - this.m_CurrentBitPosition;
				num = this.m_CurrentByte >> this.m_CurrentBitPosition;
			}
			while (i < depth)
			{
				this.m_CurrentByte = (int)this.ReadByte();
				num += this.m_CurrentByte << i;
				i += 8;
			}
			this.m_CurrentBitPosition = (depth + 8 - i) & 7;
			int num2 = (int)((1L << depth) - 1L);
			num &= num2;
			return num + fieldDescriptor.RangeLow;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000A209 File Offset: 0x00008409
		public void Align(long position)
		{
			this.BaseStream.Position = position;
			this.m_CurrentBitPosition = 0;
			this.m_CurrentByte = 0;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000A225 File Offset: 0x00008425
		public void AlignToByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.m_CurrentBitPosition = 0;
				this.m_CurrentByte = 0;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000A240 File Offset: 0x00008440
		public void AlignTo32Bit()
		{
			int num = (int)(this.BaseStream.Position & 3L);
			if (num != 0)
			{
				this.BaseStream.Position += (long)(4 - num);
			}
			this.m_CurrentBitPosition = 0;
		}

		// Token: 0x04000091 RID: 145
		private int m_CurrentByte;

		// Token: 0x04000092 RID: 146
		private int m_CurrentBitPosition;

		// Token: 0x04000093 RID: 147
		private FifaPlatform m_Platform;
	}
}
