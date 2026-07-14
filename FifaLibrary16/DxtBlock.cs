using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000048 RID: 72
	public class DxtBlock
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00022E6C File Offset: 0x0002106C
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00022E74 File Offset: 0x00021074
		public Color[,] Colors
		{
			get
			{
				return this.m_Colors;
			}
			set
			{
				this.m_Colors = value;
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00022E80 File Offset: 0x00021080
		public DxtBlock(int dxtType)
		{
			this.m_ColorLut = new int[4, 4];
			this.m_AlfaLut = new int[4, 4];
			this.m_Colors = new Color[4, 4];
			this.m_Alfa = new int[4, 4];
			this.Init(dxtType);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00022ECE File Offset: 0x000210CE
		public DxtBlock(int dxtType, BinaryReader br)
		{
			this.m_DxtType = (EImageType)dxtType;
			this.m_ColorLut = new int[4, 4];
			this.m_Colors = new Color[4, 4];
			this.Load(br);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00022F00 File Offset: 0x00021100
		public void Load(BinaryReader br)
		{
			EImageType dxtType = this.m_DxtType;
			switch (dxtType)
			{
			case EImageType.DXT1:
				this.ReadColorLut(br);
				this.ConvertTo4x4();
				return;
			case EImageType.DXT3:
				this.ReadAlfaChannel(br);
				this.ReadColorLut(br);
				this.ConvertTo4x4();
				return;
			case EImageType.DXT5:
				this.ReadAlfaLut(br);
				this.ReadColorLut(br);
				this.ConvertTo4x4();
				return;
			default:
				if (dxtType != EImageType.DC_XY_NORMAL_MAP)
				{
					return;
				}
				this.ReadAlfaLut(br);
				this.ConvertTo3DC(0);
				this.ReadAlfaLut(br);
				this.ConvertTo3DC(1);
				return;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00022F80 File Offset: 0x00021180
		public void Save(BinaryWriter bw)
		{
			EImageType dxtType = this.m_DxtType;
			switch (dxtType)
			{
			case EImageType.DXT1:
				this.ConvertFrom4x4();
				this.WriteColorLut(bw);
				return;
			case EImageType.DXT3:
				this.ConvertFrom4x4();
				this.WriteAlfaChannel(bw);
				this.WriteColorLut(bw);
				return;
			case EImageType.DXT5:
				this.ConvertFrom4x4();
				this.WriteAlfaLut(bw);
				this.WriteColorLut(bw);
				return;
			default:
				if (dxtType != EImageType.DC_XY_NORMAL_MAP)
				{
					return;
				}
				this.ConvertFrom3DC(0);
				this.WriteAlfaLut(bw);
				this.ConvertFrom3DC(1);
				this.WriteAlfaLut(bw);
				return;
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00023000 File Offset: 0x00021200
		private void Init(int dxtType)
		{
			this.m_DxtType = (EImageType)dxtType;
			this.m_Col0 = 0;
			this.m_Col1 = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					this.m_ColorLut[i, j] = 0;
					this.m_Alfa[i, j] = 255;
					this.m_Colors[i, j] = Color.FromArgb(0, 0, 0);
				}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00023070 File Offset: 0x00021270
		private void ReadAlfaChannel(BinaryReader br)
		{
			for (int i = 0; i < 4; i++)
			{
				int num = (int)br.ReadInt16();
				this.m_Alfa[0, i] = (num & 15) << 4;
				this.m_Alfa[1, i] = ((num >> 4) & 15) << 4;
				this.m_Alfa[2, i] = ((num >> 8) & 15) << 4;
				this.m_Alfa[3, i] = ((num >> 12) & 15) << 4;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000230E4 File Offset: 0x000212E4
		private void ReadColorLut(BinaryReader br)
		{
			this.m_Col0 = br.ReadUInt16();
			this.m_Col1 = br.ReadUInt16();
			for (int i = 0; i < 4; i++)
			{
				byte b = br.ReadByte();
				this.m_ColorLut[0, i] = (int)(b & 3);
				this.m_ColorLut[1, i] = (b >> 2) & 3;
				this.m_ColorLut[2, i] = (b >> 4) & 3;
				this.m_ColorLut[3, i] = (b >> 6) & 3;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00023164 File Offset: 0x00021364
		private void ReadNormalLut(BinaryReader br)
		{
			this.m_Col0 = (ushort)br.ReadByte();
			this.m_Col1 = (ushort)br.ReadByte();
			byte[] array = br.ReadBytes(6);
			this.m_ColorLut[0, 0] = (int)(array[0] & 7);
			this.m_ColorLut[1, 0] = (array[0] >> 3) & 7;
			this.m_ColorLut[2, 0] = ((array[0] >> 6) & 3) + ((int)(array[1] & 1) << 2);
			this.m_ColorLut[3, 0] = (array[1] >> 1) & 7;
			this.m_ColorLut[0, 1] = (array[1] >> 4) & 7;
			this.m_ColorLut[1, 1] = ((array[1] >> 7) & 1) + ((int)(array[2] & 3) << 1);
			this.m_ColorLut[2, 1] = (array[2] >> 2) & 7;
			this.m_ColorLut[3, 1] = (array[2] >> 5) & 7;
			this.m_ColorLut[0, 2] = (int)(array[0] & 7);
			this.m_ColorLut[1, 2] = (array[3] >> 3) & 7;
			this.m_ColorLut[2, 2] = ((array[3] >> 6) & 3) + ((int)(array[4] & 1) << 2);
			this.m_ColorLut[3, 2] = (array[3] >> 1) & 7;
			this.m_ColorLut[0, 3] = (array[4] >> 4) & 7;
			this.m_ColorLut[1, 3] = ((array[4] >> 7) & 1) + ((int)(array[5] & 3) << 1);
			this.m_ColorLut[2, 3] = (array[5] >> 2) & 7;
			this.m_ColorLut[3, 3] = (array[5] >> 5) & 7;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000232F0 File Offset: 0x000214F0
		private void ReadAlfaLut(BinaryReader br)
		{
			this.m_Alfa0 = br.ReadByte();
			this.m_Alfa1 = br.ReadByte();
			byte[] array = br.ReadBytes(6);
			ulong num = 0UL;
			for (int i = 5; i >= 0; i--)
			{
				num = (num * 256UL) | (ulong)array[i];
			}
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 4; k++)
				{
					this.m_AlfaLut[k, j] = (int)(num & 7UL);
					num >>= 3;
				}
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00023370 File Offset: 0x00021570
		private void WriteAlfaChannel(BinaryWriter bw)
		{
			for (int i = 0; i < 4; i++)
			{
				ushort num = (ushort)((this.m_Alfa[0, i] & 240) >> 4);
				num |= (ushort)(this.m_Alfa[1, i] & 240);
				num |= (ushort)((this.m_Alfa[2, i] & 240) << 4);
				num |= (ushort)((this.m_Alfa[3, i] & 240) << 8);
				bw.Write(num);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000233F8 File Offset: 0x000215F8
		private void WriteColorLut(BinaryWriter bw)
		{
			bw.Write(this.m_Col0);
			bw.Write(this.m_Col1);
			for (int i = 0; i < 4; i++)
			{
				byte b = (byte)(this.m_ColorLut[0, i] & 3);
				b |= (byte)((this.m_ColorLut[1, i] & 3) << 2);
				b |= (byte)((this.m_ColorLut[2, i] & 3) << 4);
				b |= (byte)((this.m_ColorLut[3, i] & 3) << 6);
				bw.Write(b);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00023488 File Offset: 0x00021688
		private void WriteAlfaLut(BinaryWriter bw)
		{
			bw.Write(this.m_Alfa0);
			bw.Write(this.m_Alfa1);
			ulong num = 0UL;
			for (int i = 3; i >= 0; i--)
			{
				for (int j = 3; j >= 0; j--)
				{
					num <<= 3;
					num |= (ulong)(this.m_AlfaLut[j, i] & 7);
				}
			}
			byte[] array = new byte[6];
			for (int k = 0; k < 6; k++)
			{
				array[k] = (byte)(num & 255UL);
				num >>= 8;
			}
			bw.Write(array);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00023510 File Offset: 0x00021710
		private void CleanLuts()
		{
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					this.m_AlfaLut[i, j] = 0;
					this.m_ColorLut[i, j] = 0;
				}
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00023554 File Offset: 0x00021754
		private void ConvertFrom4x4()
		{
			Color[] array = new Color[16];
			bool flag = false;
			int num = 0;
			int num2 = 255;
			int num3 = 0;
			int num4 = 4;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					uint num5 = (uint)this.m_Colors[i, j].ToArgb();
					num5 &= 4294507768U;
					this.m_Colors[i, j] = Color.FromArgb((int)num5);
				}
			}
			for (int k = 0; k < 4; k++)
			{
				int l = 0;
				while (l < 4)
				{
					bool flag2 = false;
					if (this.m_DxtType == EImageType.DXT1)
					{
						if (this.m_Colors[k, l].A != 0)
						{
							goto IL_010B;
						}
						flag = true;
						num4 = 3;
					}
					else
					{
						if ((int)this.m_Colors[k, l].A < num2)
						{
							num2 = (int)this.m_Colors[k, l].A;
						}
						if ((int)this.m_Colors[k, l].A > num3)
						{
							num3 = (int)this.m_Colors[k, l].A;
							goto IL_010B;
						}
						goto IL_010B;
					}
					IL_01A7:
					l++;
					continue;
					IL_010B:
					for (int m = 0; m < num; m++)
					{
						if (this.m_Colors[k, l].R == array[m].R && this.m_Colors[k, l].G == array[m].G && this.m_Colors[k, l].B == array[m].B)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						array[num] = this.m_Colors[k, l];
						num++;
						goto IL_01A7;
					}
					goto IL_01A7;
				}
			}
			int num6 = 16777215;
			this.m_TempLut = new int[4, 4];
			if (this.m_DxtType == EImageType.DXT1 && flag)
			{
				if (num == 0)
				{
					for (int n = 0; n < 4; n++)
					{
						for (int num7 = 0; num7 < 4; num7++)
						{
							this.m_ColorLut[n, num7] = 3;
						}
					}
					this.m_Col0 = 0;
					this.m_Col1 = 0;
					return;
				}
				if (num == 1)
				{
					for (int num8 = 0; num8 < 4; num8++)
					{
						for (int num9 = 0; num9 < 4; num9++)
						{
							if (this.m_Colors[num8, num9].A == 0)
							{
								this.m_ColorLut[num8, num9] = 3;
							}
							else
							{
								this.m_ColorLut[num8, num9] = 0;
							}
						}
					}
					this.m_Col0 = (this.m_Col1 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3)));
					return;
				}
				if (num == 2)
				{
					this.m_Col0 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3));
					this.m_Col1 = (ushort)(((int)(array[1].R & 248) << 8) | ((int)(array[1].G & 252) << 3) | ((array[1].B & 248) >> 3));
					if (this.m_Col0 >= this.m_Col1)
					{
						ushort col = this.m_Col0;
						this.m_Col0 = this.m_Col1;
						this.m_Col1 = col;
						Color color = array[0];
						array[0] = array[1];
						array[1] = color;
					}
					for (int num10 = 0; num10 < 4; num10++)
					{
						for (int num11 = 0; num11 < 4; num11++)
						{
							if (this.m_Colors[num10, num11].A == 0)
							{
								this.m_ColorLut[num10, num11] = 3;
							}
							else if (this.m_Colors[num10, num11] == array[0])
							{
								this.m_ColorLut[num10, num11] = 0;
							}
							else
							{
								this.m_ColorLut[num10, num11] = 1;
							}
						}
					}
					return;
				}
			}
			this.CleanLuts();
			if (num3 == 0 && num2 == 0)
			{
				this.m_Alfa0 = 0;
				this.m_Col0 = 0;
				this.m_Alfa1 = 1;
				this.m_Col1 = 1;
				num = 0;
			}
			if (num == 1)
			{
				for (int num12 = 0; num12 < 4; num12++)
				{
					for (int num13 = 0; num13 < 4; num13++)
					{
						this.m_ColorLut[num12, num13] = 0;
					}
				}
				this.m_Col0 = (this.m_Col1 = (ushort)(((int)(array[0].R & 248) << 8) | ((int)(array[0].G & 252) << 3) | ((array[0].B & 248) >> 3)));
			}
			for (int num14 = 0; num14 < num; num14++)
			{
				for (int num15 = num14 + 1; num15 < num; num15++)
				{
					ushort num16 = (ushort)(((int)(array[num14].R & 248) << 8) | ((int)(array[num14].G & 252) << 3) | ((array[num14].B & 248) >> 3));
					ushort num17 = (ushort)(((int)(array[num15].R & 248) << 8) | ((int)(array[num15].G & 252) << 3) | ((array[num15].B & 248) >> 3));
					ushort num18;
					ushort num19;
					int num20;
					int num21;
					if (num16 < num17)
					{
						num18 = num16;
						num19 = num17;
						num20 = num14;
						num21 = num15;
					}
					else
					{
						num18 = num17;
						num19 = num16;
						num20 = num15;
						num21 = num14;
					}
					if (num4 == 4)
					{
						int num22 = this.ScoreColors(array[num21], array[num20], num4);
						if (num22 < num6)
						{
							num6 = num22;
							for (int num23 = 0; num23 < 4; num23++)
							{
								for (int num24 = 0; num24 < 4; num24++)
								{
									this.m_ColorLut[num23, num24] = this.m_TempLut[num23, num24];
								}
							}
							this.m_Col0 = num19;
							this.m_Col1 = num18;
							if (num22 == 0)
							{
								break;
							}
						}
					}
					if (this.m_DxtType == EImageType.DXT1)
					{
						int num22 = this.ScoreColors(array[num20], array[num21], 3);
						if (num22 < num6)
						{
							num6 = num22;
							for (int num25 = 0; num25 < 4; num25++)
							{
								for (int num26 = 0; num26 < 4; num26++)
								{
									this.m_ColorLut[num25, num26] = this.m_TempLut[num25, num26];
								}
							}
							this.m_Col0 = num18;
							this.m_Col1 = num19;
							if (num22 == 0)
							{
								break;
							}
						}
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT3 || this.m_DxtType == EImageType.DXT3)
			{
				for (int num27 = 0; num27 < 4; num27++)
				{
					for (int num28 = 0; num28 < 4; num28++)
					{
						this.m_Alfa[num27, num28] = (int)(this.m_Colors[num27, num28].A & 240);
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT5 || this.m_DxtType == EImageType.DXT5)
			{
				if (num2 == 0 && num3 == 0)
				{
					return;
				}
				this.m_Alfa1 = (byte)num2;
				this.m_Alfa0 = (byte)num3;
				int num29 = num3 - num2;
				int[] array2 = new int[8];
				if (num29 != 0)
				{
					for (int num30 = 2; num30 < 8; num30++)
					{
						array2[num30] = ((int)this.m_Alfa0 * (8 - num30) + (int)this.m_Alfa1 * (num30 - 1)) / 7;
					}
				}
				int num31 = num29 / 7 / 2;
				for (int num32 = 0; num32 < 4; num32++)
				{
					for (int num33 = 0; num33 < 4; num33++)
					{
						int a = (int)this.m_Colors[num32, num33].A;
						if (a <= num2 + num31)
						{
							this.m_AlfaLut[num32, num33] = 1;
						}
						else if (a >= num3 - num31)
						{
							this.m_AlfaLut[num32, num33] = 0;
						}
						else if (num29 != 0)
						{
							this.m_AlfaLut[num32, num33] = 0;
							for (int num34 = 2; num34 < 8; num34++)
							{
								if (a > array2[num34] - num31)
								{
									this.m_AlfaLut[num32, num33] = num34;
									break;
								}
							}
						}
						else
						{
							this.m_AlfaLut[num32, num33] = 0;
						}
					}
				}
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00023DCC File Offset: 0x00021FCC
		private void ConvertFrom3DC(int rgb)
		{
			int num = 255;
			int num2 = 0;
			if (rgb == 0)
			{
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						this.m_Alfa[i, j] = (int)this.m_Colors[i, j].R;
						if (this.m_Alfa[i, j] < num)
						{
							num = this.m_Alfa[i, j];
						}
						if (this.m_Alfa[i, j] > num2)
						{
							num2 = this.m_Alfa[i, j];
						}
					}
				}
			}
			else if (rgb == 1)
			{
				for (int k = 0; k < 4; k++)
				{
					for (int l = 0; l < 4; l++)
					{
						this.m_Alfa[k, l] = (int)this.m_Colors[k, l].G;
						if (this.m_Alfa[k, l] < num)
						{
							num = this.m_Alfa[k, l];
						}
						if (this.m_Alfa[k, l] > num2)
						{
							num2 = this.m_Alfa[k, l];
						}
					}
				}
			}
			this.CleanLuts();
			if (num2 == 0 && num == 0)
			{
				this.m_Alfa0 = 0;
				this.m_Alfa1 = 1;
			}
			if (this.m_DxtType == EImageType.DC_XY_NORMAL_MAP)
			{
				if (num == 0 && num2 == 0)
				{
					return;
				}
				this.m_Alfa1 = (byte)num;
				this.m_Alfa0 = (byte)num2;
				int num3 = num2 - num;
				int[] array = new int[8];
				if (num3 != 0)
				{
					for (int m = 2; m < 8; m++)
					{
						array[m] = ((int)this.m_Alfa0 * (8 - m) + (int)this.m_Alfa1 * (m - 1)) / 7;
					}
				}
				int num4 = num3 / 7 / 2;
				for (int n = 0; n < 4; n++)
				{
					for (int num5 = 0; num5 < 4; num5++)
					{
						int num6 = this.m_Alfa[n, num5];
						if (num6 <= num + num4)
						{
							this.m_AlfaLut[n, num5] = 1;
						}
						else if (num6 >= num2 - num4)
						{
							this.m_AlfaLut[n, num5] = 0;
						}
						else if (num3 != 0)
						{
							this.m_AlfaLut[n, num5] = 0;
							for (int num7 = 2; num7 < 8; num7++)
							{
								if (num6 > array[num7] - num4)
								{
									this.m_AlfaLut[n, num5] = num7;
									break;
								}
							}
						}
						else
						{
							this.m_AlfaLut[n, num5] = 0;
						}
					}
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00024038 File Offset: 0x00022238
		private void ConvertTo3DC(int rgb)
		{
			int[] array = new int[8];
			array[0] = (int)this.m_Alfa0;
			array[1] = (int)this.m_Alfa1;
			if (this.m_Alfa0 > this.m_Alfa1)
			{
				for (int i = 2; i < 8; i++)
				{
					array[i] = ((int)this.m_Alfa0 * (8 - i) + (int)this.m_Alfa1 * (i - 1)) / 7;
				}
			}
			else
			{
				for (int j = 2; j < 6; j++)
				{
					array[j] = ((int)this.m_Alfa0 * (6 - j) + (int)this.m_Alfa1 * (j - 1)) / 5;
				}
				array[6] = 0;
				array[7] = 255;
			}
			for (int k = 0; k < 4; k++)
			{
				for (int l = 0; l < 4; l++)
				{
					int num = this.m_AlfaLut[k, l];
					this.m_Alfa[k, l] = array[num];
				}
			}
			if (rgb == 0)
			{
				for (int m = 0; m < 4; m++)
				{
					for (int n = 0; n < 4; n++)
					{
						this.m_Colors[m, n] = Color.FromArgb(array[this.m_AlfaLut[m, n]], 0, 0);
					}
				}
			}
			if (rgb == 1)
			{
				for (int num2 = 0; num2 < 4; num2++)
				{
					for (int num3 = 0; num3 < 4; num3++)
					{
						this.m_Colors[num2, num3] = Color.FromArgb((int)this.m_Colors[num2, num3].R, array[this.m_ColorLut[num2, num3]], 255);
					}
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000241B0 File Offset: 0x000223B0
		private void ConvertTo4x4()
		{
			int[] array = new int[8];
			array[0] = (int)this.m_Alfa0;
			array[1] = (int)this.m_Alfa1;
			if (this.m_DxtType == EImageType.DXT5)
			{
				if (this.m_Alfa0 > this.m_Alfa1)
				{
					for (int i = 2; i < 8; i++)
					{
						array[i] = ((int)this.m_Alfa0 * (8 - i) + (int)this.m_Alfa1 * (i - 1)) / 7;
					}
				}
				else
				{
					for (int j = 2; j < 6; j++)
					{
						array[j] = ((int)this.m_Alfa0 * (6 - j) + (int)this.m_Alfa1 * (j - 1)) / 5;
					}
					array[6] = 0;
					array[7] = 255;
				}
			}
			if (this.m_DxtType == EImageType.DXT5)
			{
				for (int k = 0; k < 4; k++)
				{
					for (int l = 0; l < 4; l++)
					{
						int num = this.m_AlfaLut[k, l];
						this.m_Alfa[k, l] = array[num];
					}
				}
			}
			if (this.m_DxtType == EImageType.DXT1)
			{
				for (int m = 0; m < 4; m++)
				{
					for (int n = 0; n < 4; n++)
					{
						int num2 = this.m_ColorLut[m, n];
						if (this.m_Col0 <= this.m_Col1 && num2 == 3)
						{
							this.m_Alfa[m, n] = 0;
						}
						else
						{
							this.m_Alfa[m, n] = 255;
						}
					}
				}
			}
			int[] array2 = new int[4];
			int[] array3 = new int[4];
			int[] array4 = new int[4];
			array4[0] = (int)(8 * (this.m_Col0 & 31));
			array3[0] = 4 * ((this.m_Col0 >> 5) & 63);
			array2[0] = 8 * (this.m_Col0 >> 11);
			array4[1] = (int)(8 * (this.m_Col1 & 31));
			array3[1] = 4 * ((this.m_Col1 >> 5) & 63);
			array2[1] = 8 * (this.m_Col1 >> 11);
			if (this.m_Col0 > this.m_Col1 || this.m_DxtType != EImageType.DXT1)
			{
				array2[2] = (2 * array2[0] + array2[1]) / 3;
				array3[2] = (2 * array3[0] + array3[1]) / 3;
				array4[2] = (2 * array4[0] + array4[1]) / 3;
				array2[3] = (array2[0] + 2 * array2[1]) / 3;
				array3[3] = (array3[0] + 2 * array3[1]) / 3;
				array4[3] = (array4[0] + 2 * array4[1]) / 3;
			}
			else
			{
				array2[2] = (array2[0] + array2[1]) / 2;
				array3[2] = (array3[0] + array3[1]) / 2;
				array4[2] = (array4[0] + array4[1]) / 2;
				array2[3] = 0;
				array3[3] = 0;
				array4[3] = 0;
			}
			for (int num3 = 0; num3 < 4; num3++)
			{
				for (int num4 = 0; num4 < 4; num4++)
				{
					int num5 = this.m_ColorLut[num3, num4];
					this.m_Colors[num3, num4] = Color.FromArgb(this.m_Alfa[num3, num4], array2[num5], array3[num5], array4[num5]);
				}
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00024480 File Offset: 0x00022680
		private int[] ComputeInterpolatedAlfa(int alfa0, int alfa1)
		{
			int[] array = new int[8];
			array[0] = alfa0;
			array[1] = alfa1;
			for (int i = 2; i < 8; i++)
			{
				int num = 8 - i;
				int num2 = i - 1;
				array[i] = (num * alfa0 + num2 * alfa1) / 7;
			}
			return array;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000244C0 File Offset: 0x000226C0
		private int[,] ComputeInterpolatedRgb(Color col0, Color col1, int nColors)
		{
			int[,] array = new int[4, 3];
			array[0, 0] = (int)col0.R;
			array[0, 1] = (int)col0.G;
			array[0, 2] = (int)col0.B;
			array[1, 0] = (int)col1.R;
			array[1, 1] = (int)col1.G;
			array[1, 2] = (int)col1.B;
			if (nColors <= 3)
			{
				nColors = 3;
				for (int i = 2; i < nColors; i++)
				{
					int num = nColors - i;
					int num2 = i - 1;
					array[i, 0] = (num * (int)col0.R + num2 * (int)col1.R) / 2;
					array[i, 1] = (num * (int)col0.G + num2 * (int)col1.G) / 2;
					array[i, 2] = (num * (int)col0.B + num2 * (int)col1.B) / 2;
				}
				array[3, 0] = 0;
				array[3, 1] = 0;
				array[3, 2] = 0;
			}
			else
			{
				nColors = 4;
				for (int j = 2; j < nColors; j++)
				{
					int num3 = nColors - j;
					int num4 = j - 1;
					array[j, 0] = (num3 * (int)col0.R + num4 * (int)col1.R) / 3;
					array[j, 1] = (num3 * (int)col0.G + num4 * (int)col1.G) / 3;
					array[j, 2] = (num3 * (int)col0.B + num4 * (int)col1.B) / 3;
				}
			}
			return array;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00024644 File Offset: 0x00022844
		private int ScoreColors(Color col0, Color col1, int nColors)
		{
			int[,] array = this.ComputeInterpolatedRgb(col0, col1, nColors);
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					int num2 = 16777215;
					int r = (int)this.m_Colors[i, j].R;
					int g = (int)this.m_Colors[i, j].G;
					int b = (int)this.m_Colors[i, j].B;
					if (this.m_Colors[i, j].A == 0 && nColors == 3)
					{
						this.m_TempLut[i, j] = 3;
					}
					else
					{
						for (int k = 0; k < nColors; k++)
						{
							int num3 = array[k, 0] - r;
							int num4 = array[k, 1] - g;
							int num5 = array[k, 2] - b;
							int num6 = num3;
							int num7 = num6 * num6;
							int num8 = num4;
							int num9 = num7 + num8 * num8;
							int num10 = num5;
							int num11 = num9 + num10 * num10;
							if (num11 < num2)
							{
								num2 = num11;
								this.m_TempLut[i, j] = k;
								if (num11 == 0)
								{
									break;
								}
							}
						}
						num += num2;
					}
				}
			}
			return num;
		}

		// Token: 0x04000E23 RID: 3619
		private EImageType m_DxtType;

		// Token: 0x04000E24 RID: 3620
		private ushort m_Col0;

		// Token: 0x04000E25 RID: 3621
		private ushort m_Col1;

		// Token: 0x04000E26 RID: 3622
		private byte m_Alfa0;

		// Token: 0x04000E27 RID: 3623
		private byte m_Alfa1;

		// Token: 0x04000E28 RID: 3624
		private int[,] m_ColorLut;

		// Token: 0x04000E29 RID: 3625
		private int[,] m_AlfaLut;

		// Token: 0x04000E2A RID: 3626
		private int[,] m_Alfa;

		// Token: 0x04000E2B RID: 3627
		private int[,] m_TempLut;

		// Token: 0x04000E2C RID: 3628
		private Color[,] m_Colors;
	}
}
