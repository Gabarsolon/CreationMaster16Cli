using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000067 RID: 103
	public static class GenericHead
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x0003675C File Offset: 0x0003495C
		public static int GetModelId(GenericHead.EHeadModelSet modelSet, int index)
		{
			switch (modelSet)
			{
			case GenericHead.EHeadModelSet.African:
				if (index < GenericHead.c_AfricanModels.Length)
				{
					return GenericHead.c_AfricanModels[index];
				}
				break;
			case GenericHead.EHeadModelSet.Asiatic:
				if (index < GenericHead.c_AsiaticModels.Length)
				{
					return GenericHead.c_AsiaticModels[index];
				}
				break;
			case GenericHead.EHeadModelSet.Caucasic:
				if (index < GenericHead.c_CaucasicModels.Length)
				{
					return GenericHead.c_CaucasicModels[index];
				}
				break;
			case GenericHead.EHeadModelSet.Latin:
				if (index < GenericHead.c_LatinModels.Length)
				{
					return GenericHead.c_LatinModels[index];
				}
				break;
			case GenericHead.EHeadModelSet.Female:
				if (index < GenericHead.c_FemaleModels.Length)
				{
					return GenericHead.c_FemaleModels[index];
				}
				break;
			}
			return -1;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000367E4 File Offset: 0x000349E4
		public static GenericHead.EHeadModelSet GetModelSet(int modelId)
		{
			for (int i = 0; i < GenericHead.c_CaucasicModels.Length; i++)
			{
				if (modelId == GenericHead.c_CaucasicModels[i])
				{
					return GenericHead.EHeadModelSet.Caucasic;
				}
			}
			for (int j = 0; j < GenericHead.c_LatinModels.Length; j++)
			{
				if (modelId == GenericHead.c_LatinModels[j])
				{
					return GenericHead.EHeadModelSet.Latin;
				}
			}
			for (int k = 0; k < GenericHead.c_AfricanModels.Length; k++)
			{
				if (modelId == GenericHead.c_AfricanModels[k])
				{
					return GenericHead.EHeadModelSet.African;
				}
			}
			for (int l = 0; l < GenericHead.c_AsiaticModels.Length; l++)
			{
				if (modelId == GenericHead.c_AsiaticModels[l])
				{
					return GenericHead.EHeadModelSet.Asiatic;
				}
			}
			for (int m = 0; m < GenericHead.c_FemaleModels.Length; m++)
			{
				if (modelId == GenericHead.c_FemaleModels[m])
				{
					return GenericHead.EHeadModelSet.Female;
				}
			}
			return GenericHead.EHeadModelSet.Unknown;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00036890 File Offset: 0x00034A90
		public static int GetModelSetIndex(GenericHead.EHeadModelSet modelSet, int modelId)
		{
			switch (modelSet)
			{
			case GenericHead.EHeadModelSet.African:
			{
				for (int i = 0; i < GenericHead.c_AfricanModels.Length; i++)
				{
					if (modelId == GenericHead.c_AfricanModels[i])
					{
						return i;
					}
				}
				break;
			}
			case GenericHead.EHeadModelSet.Asiatic:
			{
				for (int j = 0; j < GenericHead.c_AsiaticModels.Length; j++)
				{
					if (modelId == GenericHead.c_AsiaticModels[j])
					{
						return j;
					}
				}
				break;
			}
			case GenericHead.EHeadModelSet.Caucasic:
			{
				for (int k = 0; k < GenericHead.c_CaucasicModels.Length; k++)
				{
					if (modelId == GenericHead.c_CaucasicModels[k])
					{
						return k;
					}
				}
				break;
			}
			case GenericHead.EHeadModelSet.Latin:
			{
				for (int l = 0; l < GenericHead.c_LatinModels.Length; l++)
				{
					if (modelId == GenericHead.c_LatinModels[l])
					{
						return l;
					}
				}
				break;
			}
			case GenericHead.EHeadModelSet.Female:
			{
				for (int m = 0; m < GenericHead.c_FemaleModels.Length; m++)
				{
					if (modelId == GenericHead.c_FemaleModels[m])
					{
						return m;
					}
				}
				break;
			}
			}
			return -1;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00036968 File Offset: 0x00034B68
		public static int GetHairModelId(GenericHead.EHairModelSet modelSet, int index)
		{
			switch (modelSet)
			{
			case GenericHead.EHairModelSet.Shaven:
				if (index < GenericHead.c_ShavenModels.Length)
				{
					return GenericHead.c_ShavenModels[index];
				}
				break;
			case GenericHead.EHairModelSet.VeryShort:
				if (index < GenericHead.c_VeryShortModels.Length)
				{
					return GenericHead.c_VeryShortModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Short:
				if (index < GenericHead.c_ShortModels.Length)
				{
					return GenericHead.c_ShortModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Modern:
				if (index < GenericHead.c_ModernModels.Length)
				{
					return GenericHead.c_ModernModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Medium:
				if (index < GenericHead.c_MediumModels.Length)
				{
					return GenericHead.c_MediumModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Long:
				if (index < GenericHead.c_LongModels.Length)
				{
					return GenericHead.c_LongModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Afro:
				if (index < GenericHead.c_AfroModels.Length)
				{
					return GenericHead.c_AfroModels[index];
				}
				break;
			case GenericHead.EHairModelSet.Headbend:
				if (index < GenericHead.c_HeadbendModels.Length)
				{
					return GenericHead.c_HeadbendModels[index];
				}
				break;
			case GenericHead.EHairModelSet.FemaleHair:
				if (index < GenericHead.c_FemaleHairModels.Length)
				{
					return GenericHead.c_FemaleHairModels[index];
				}
				break;
			}
			return -1;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00036A50 File Offset: 0x00034C50
		public static GenericHead.EHairModelSet GetHairModelSet(int modelId)
		{
			for (int i = 0; i < GenericHead.c_ShavenModels.Length; i++)
			{
				if (modelId == GenericHead.c_ShavenModels[i])
				{
					return GenericHead.EHairModelSet.Shaven;
				}
			}
			for (int j = 0; j < GenericHead.c_VeryShortModels.Length; j++)
			{
				if (modelId == GenericHead.c_VeryShortModels[j])
				{
					return GenericHead.EHairModelSet.VeryShort;
				}
			}
			for (int k = 0; k < GenericHead.c_ShortModels.Length; k++)
			{
				if (modelId == GenericHead.c_ShortModels[k])
				{
					return GenericHead.EHairModelSet.Short;
				}
			}
			for (int l = 0; l < GenericHead.c_ModernModels.Length; l++)
			{
				if (modelId == GenericHead.c_ModernModels[l])
				{
					return GenericHead.EHairModelSet.Modern;
				}
			}
			for (int m = 0; m < GenericHead.c_MediumModels.Length; m++)
			{
				if (modelId == GenericHead.c_MediumModels[m])
				{
					return GenericHead.EHairModelSet.Medium;
				}
			}
			for (int n = 0; n < GenericHead.c_LongModels.Length; n++)
			{
				if (modelId == GenericHead.c_LongModels[n])
				{
					return GenericHead.EHairModelSet.Long;
				}
			}
			for (int num = 0; num < GenericHead.c_AfroModels.Length; num++)
			{
				if (modelId == GenericHead.c_AfroModels[num])
				{
					return GenericHead.EHairModelSet.Afro;
				}
			}
			for (int num2 = 0; num2 < GenericHead.c_HeadbendModels.Length; num2++)
			{
				if (modelId == GenericHead.c_HeadbendModels[num2])
				{
					return GenericHead.EHairModelSet.Headbend;
				}
			}
			for (int num3 = 0; num3 < GenericHead.c_FemaleHairModels.Length; num3++)
			{
				if (modelId == GenericHead.c_FemaleHairModels[num3])
				{
					return GenericHead.EHairModelSet.FemaleHair;
				}
			}
			return GenericHead.EHairModelSet.Shaven;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00036B88 File Offset: 0x00034D88
		public static int GetHairModelSetIndex(GenericHead.EHairModelSet modelSet, int modelId)
		{
			switch (modelSet)
			{
			case GenericHead.EHairModelSet.Shaven:
			{
				for (int i = 0; i < GenericHead.c_ShavenModels.Length; i++)
				{
					if (modelId == GenericHead.c_ShavenModels[i])
					{
						return i;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.VeryShort:
			{
				for (int j = 0; j < GenericHead.c_VeryShortModels.Length; j++)
				{
					if (modelId == GenericHead.c_VeryShortModels[j])
					{
						return j;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Short:
			{
				for (int k = 0; k < GenericHead.c_ShortModels.Length; k++)
				{
					if (modelId == GenericHead.c_ShortModels[k])
					{
						return k;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Modern:
			{
				for (int l = 0; l < GenericHead.c_ModernModels.Length; l++)
				{
					if (modelId == GenericHead.c_ModernModels[l])
					{
						return l;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Medium:
			{
				for (int m = 0; m < GenericHead.c_MediumModels.Length; m++)
				{
					if (modelId == GenericHead.c_MediumModels[m])
					{
						return m;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Long:
			{
				for (int n = 0; n < GenericHead.c_LongModels.Length; n++)
				{
					if (modelId == GenericHead.c_LongModels[n])
					{
						return n;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Afro:
			{
				for (int num = 0; num < GenericHead.c_AfroModels.Length; num++)
				{
					if (modelId == GenericHead.c_AfroModels[num])
					{
						return num;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.Headbend:
			{
				for (int num2 = 0; num2 < GenericHead.c_HeadbendModels.Length; num2++)
				{
					if (modelId == GenericHead.c_HeadbendModels[num2])
					{
						return num2;
					}
				}
				break;
			}
			case GenericHead.EHairModelSet.FemaleHair:
			{
				for (int num3 = 0; num3 < GenericHead.c_FemaleHairModels.Length; num3++)
				{
					if (modelId == GenericHead.c_FemaleHairModels[num3])
					{
						return num3;
					}
				}
				break;
			}
			}
			return -1;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00036D10 File Offset: 0x00034F10
		public static int RandomizeModel(GenericHead.EHeadModelSet modelSet)
		{
			switch (modelSet)
			{
			case GenericHead.EHeadModelSet.African:
				return GenericHead.c_AfricanModels[GenericHead.m_Randomizer.Next(GenericHead.c_AfricanModels.Length)];
			case GenericHead.EHeadModelSet.Asiatic:
				return GenericHead.c_AsiaticModels[GenericHead.m_Randomizer.Next(GenericHead.c_AsiaticModels.Length)];
			case GenericHead.EHeadModelSet.Caucasic:
				return GenericHead.c_CaucasicModels[GenericHead.m_Randomizer.Next(GenericHead.c_CaucasicModels.Length)];
			case GenericHead.EHeadModelSet.Latin:
				return GenericHead.c_LatinModels[GenericHead.m_Randomizer.Next(GenericHead.c_LatinModels.Length)];
			default:
				return 1;
			}
		}

		// Token: 0x04000F4D RID: 3917
		public static int[] c_LowHair = new int[]
		{
			0, 1, 9, 2, 3, 6, 4, 4, 8, 8,
			13, 7, 8, 13, 5, 8, 9, 9, 10, 9,
			5, 9, 9, 9, 9, 1, 0, 10, 1, 9,
			9, 9, 13, 6, 13, 14, 12, 1, 9, 9,
			1, 1, 10, 1, 8, 9, 1, 9, 4, 5,
			16, 2, 2, 4, 9, 12, 12, 9, 9, 14,
			11, 10, 14, 10, 10, 1, 14, 14, 13, 14,
			11, 1, 1, 13, 9, 9, 3, 9, 9, 5,
			6, 13, 9, 9, 3, 14, 9, 13, 11, 14,
			9, 8, 9, 9, 11, 14, 2, 9, 14, 8,
			9, 9, 9, 8, 14, 9, 9, 9, 12, 7,
			1, 9
		};

		// Token: 0x04000F4E RID: 3918
		public static Color[] c_FacialHairColorPalette = new Color[]
		{
			Color.FromArgb(48, 36, 32),
			Color.FromArgb(160, 140, 112),
			Color.FromArgb(72, 52, 40),
			Color.FromArgb(184, 161, 130),
			Color.FromArgb(144, 108, 80),
			Color.FromArgb(112, 96, 72),
			Color.FromArgb(136, 84, 56)
		};

		// Token: 0x04000F4F RID: 3919
		public static int[] c_CaucasicModels = new int[]
		{
			0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
			10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
			20, 21, 22, 23, 24, 25, 2000, 2001, 2002, 2003,
			2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013,
			2014, 2015, 2016, 2017, 2019, 2020, 2021, 2022, 2023, 2024,
			2025, 2026, 2027, 2028, 2029, 2030, 3500, 3501, 3502, 3503,
			3504, 3505, 4000, 4001, 4002, 4003
		};

		// Token: 0x04000F50 RID: 3920
		public static int[] c_AsiaticModels = new int[]
		{
			500, 501, 502, 503, 504, 505, 506, 507, 508, 509,
			510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
			520, 521, 522, 523, 524, 525, 526, 527, 528, 529,
			530, 531, 532
		};

		// Token: 0x04000F51 RID: 3921
		public static int[] c_AfricanModels = new int[]
		{
			1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009,
			1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019,
			1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 3000, 3001,
			3002, 3003, 3004, 3005, 4500, 4501, 4502, 4525, 5000, 5001,
			5002, 5003
		};

		// Token: 0x04000F52 RID: 3922
		public static int[] c_LatinModels = new int[]
		{
			1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509,
			1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519,
			1520, 1521, 1522, 1523, 1524, 1525, 1526, 1527, 1528, 2500,
			2501, 2502, 2503, 2504, 2505, 2506, 2507, 2508, 2509, 2510,
			2511, 2512, 2513, 2514, 2515, 2516, 2517, 2518
		};

		// Token: 0x04000F53 RID: 3923
		public static int[] c_FemaleModels = new int[]
		{
			5500, 5501, 5502, 6000, 6001, 6002, 6500, 6501, 6502, 7000,
			7001, 7002, 7500, 7501, 7502, 8000, 8001, 8002, 8500, 8501,
			8502, 9000, 9001, 9002, 9500, 9501, 9502, 10000, 10001, 10002,
			10500, 10501, 10502
		};

		// Token: 0x04000F54 RID: 3924
		public static int[] c_ShavenModels = new int[] { 0, 25, 1, 43, 41, 46, 120 };

		// Token: 0x04000F55 RID: 3925
		public static int[] c_VeryShortModels = new int[]
		{
			26, 29, 47, 72, 92, 16, 28, 31, 37, 40,
			45, 65, 77, 90, 117
		};

		// Token: 0x04000F56 RID: 3926
		public static int[] c_ShortModels = new int[]
		{
			2, 21, 22, 30, 38, 54, 57, 70, 75, 78,
			82, 97, 101, 102, 104, 105, 106, 107, 108, 111,
			112, 113, 115, 114, 118, 121, 122, 124
		};

		// Token: 0x04000F57 RID: 3927
		public static int[] c_ModernModels = new int[]
		{
			17, 18, 19, 24, 39, 60, 61, 63, 64, 86,
			88, 89, 94, 123
		};

		// Token: 0x04000F58 RID: 3928
		public static int[] c_MediumModels = new int[]
		{
			36, 74, 13, 35, 42, 59, 69, 73, 85, 93,
			32, 66, 67, 68, 14, 20, 23, 58, 62, 83,
			95, 22, 52, 87, 98, 99, 100, 103, 116, 119
		};

		// Token: 0x04000F59 RID: 3929
		public static int[] c_LongModels = new int[]
		{
			8, 9, 15, 44, 84, 34, 10, 33, 12, 80,
			11, 50, 51, 79, 53, 7
		};

		// Token: 0x04000F5A RID: 3930
		public static int[] c_AfroModels = new int[] { 71, 4, 27, 5, 6, 96, 3, 109, 110 };

		// Token: 0x04000F5B RID: 3931
		public static int[] c_HeadbendModels = new int[] { 55, 56, 76, 81, 49, 91, 48 };

		// Token: 0x04000F5C RID: 3932
		public static int[] c_FemaleHairModels = new int[]
		{
			500, 501, 502, 503, 504, 505, 506, 507, 508, 509,
			510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
			520, 521, 522, 523, 524, 525, 526, 527, 528, 529,
			530, 531, 532, 533, 534, 535, 536, 537, 538, 539,
			540, 541
		};

		// Token: 0x04000F5D RID: 3933
		private static Random m_Randomizer = new Random();

		// Token: 0x020000C1 RID: 193
		public enum EHeadModelSet
		{
			// Token: 0x04001276 RID: 4726
			Unknown,
			// Token: 0x04001277 RID: 4727
			African,
			// Token: 0x04001278 RID: 4728
			Asiatic,
			// Token: 0x04001279 RID: 4729
			Caucasic,
			// Token: 0x0400127A RID: 4730
			Latin,
			// Token: 0x0400127B RID: 4731
			Female
		}

		// Token: 0x020000C2 RID: 194
		public enum EHairModelSet
		{
			// Token: 0x0400127D RID: 4733
			Shaven,
			// Token: 0x0400127E RID: 4734
			VeryShort,
			// Token: 0x0400127F RID: 4735
			Short,
			// Token: 0x04001280 RID: 4736
			Modern,
			// Token: 0x04001281 RID: 4737
			Medium,
			// Token: 0x04001282 RID: 4738
			Long,
			// Token: 0x04001283 RID: 4739
			Afro,
			// Token: 0x04001284 RID: 4740
			Headbend,
			// Token: 0x04001285 RID: 4741
			FemaleHair
		}
	}
}
