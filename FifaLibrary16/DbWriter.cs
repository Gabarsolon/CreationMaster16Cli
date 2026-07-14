using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000028 RID: 40
	public class DbWriter : BinaryWriter
	{
		// Token: 0x06000274 RID: 628 RVA: 0x0000A27D File Offset: 0x0000847D
		public DbWriter(Stream stream, FifaPlatform platform)
			: base(stream)
		{
			this.m_Platform = platform;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000A28D File Offset: 0x0000848D
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000A295 File Offset: 0x00008495
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

		// Token: 0x06000277 RID: 631 RVA: 0x0000A2A0 File Offset: 0x000084A0
		public override void Write(short value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000A2D4 File Offset: 0x000084D4
		public override void Write(ushort value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A308 File Offset: 0x00008508
		public override void Write(int value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000A33C File Offset: 0x0000853C
		public override void Write(uint value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000A370 File Offset: 0x00008570
		public override void Write(long value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public override void Write(ulong value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public override void Write(float value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A40C File Offset: 0x0000860C
		public override void Write(double value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000A43E File Offset: 0x0000863E
		public void PushInteger(int value, FieldDescriptor fieldDescriptor)
		{
			if (this.m_Platform == FifaPlatform.PC)
			{
				this.PushIntegerPc(value, fieldDescriptor);
				return;
			}
			this.PushIntegerXbox(value, fieldDescriptor);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000A45C File Offset: 0x0000865C
		private void PushIntegerXbox(int value, FieldDescriptor fieldDescriptor)
		{
			BinaryReader binaryReader = new BinaryReader(this.BaseStream);
			int num = 0;
			if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
			{
				num = (int)binaryReader.ReadByte();
				Stream baseStream = binaryReader.BaseStream;
				long num2 = baseStream.Position;
				baseStream.Position = num2 - 1L;
			}
			int num3 = fieldDescriptor.BitOffset % 8;
			int num4 = value - fieldDescriptor.RangeLow;
			for (int i = fieldDescriptor.Depth - 1; i >= 0; i--)
			{
				bool flag = (num4 & (1 << i)) != 0;
				int num5 = 128 >> num3;
				if (!flag)
				{
					num &= ~num5;
				}
				else
				{
					num |= num5;
				}
				num3++;
				if (num3 == 8)
				{
					byte b = (byte)num;
					this.Write(b);
					num3 = 0;
					num = 0;
					if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
					{
						num = (int)binaryReader.ReadByte();
						Stream baseStream2 = binaryReader.BaseStream;
						long num2 = baseStream2.Position;
						baseStream2.Position = num2 - 1L;
					}
				}
			}
			if (num3 != 0)
			{
				byte b2 = (byte)num;
				this.Write(b2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000A55C File Offset: 0x0000875C
		private void PushIntegerPc(int value, FieldDescriptor fieldDescriptor)
		{
			int num = fieldDescriptor.Depth;
			bool flag = false;
			int num2 = value - fieldDescriptor.RangeLow;
			do
			{
				if (this.m_CurrentBitPosition + num > 8)
				{
					int num3 = 8 - this.m_CurrentBitPosition;
					int num4 = (1 << num3) - 1;
					int num5 = num2 & num4;
					this.m_CurrentByte += num5 << this.m_CurrentBitPosition;
					this.Write((byte)this.m_CurrentByte);
					num2 >>= num3;
					this.m_CurrentByte = 0;
					this.m_CurrentBitPosition = 0;
					num -= num3;
				}
				else if (this.m_CurrentBitPosition + num < 8)
				{
					this.m_CurrentByte += num2 << this.m_CurrentBitPosition;
					this.m_CurrentBitPosition += num;
					flag = true;
				}
				else
				{
					this.m_CurrentByte += num2 << this.m_CurrentBitPosition;
					this.Write((byte)this.m_CurrentByte);
					this.m_CurrentByte = 0;
					this.m_CurrentBitPosition = 0;
					flag = true;
				}
			}
			while (!flag);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000A650 File Offset: 0x00008850
		public void WritePendingByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write((byte)this.m_CurrentByte);
				this.m_CurrentBitPosition = 0;
				this.m_CurrentByte = 0;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000A675 File Offset: 0x00008875
		public void Align(long position)
		{
			this.BaseStream.Position = position;
			this.m_CurrentBitPosition = 0;
			this.m_CurrentByte = 0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000A691 File Offset: 0x00008891
		public void AlignToByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write(this.m_CurrentByte);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000A6A8 File Offset: 0x000088A8
		public void AlignTo32Bit()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write(this.m_CurrentByte);
			}
			int i = (int)(this.BaseStream.Position & 3L);
			if (i != 0)
			{
				while (i < 4)
				{
					this.Write(0);
					i++;
				}
			}
		}

		// Token: 0x04000094 RID: 148
		private int m_CurrentByte;

		// Token: 0x04000095 RID: 149
		private int m_CurrentBitPosition;

		// Token: 0x04000096 RID: 150
		private FifaPlatform m_Platform;
	}
}
