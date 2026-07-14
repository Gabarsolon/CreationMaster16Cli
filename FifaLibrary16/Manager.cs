using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200000F RID: 15
	public class Manager : IdObject
	{
		// Token: 0x060000AC RID: 172 RVA: 0x000036AB File Offset: 0x000018AB
		public static string RevModManagerTextureFileName(int teamId)
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/sceneassets/manager/specificmanager_" + teamId.ToString() + "_0_0_textures.rx3";
			}
			return "data/sceneassets/slc/specificmanager_" + teamId.ToString() + "_0_0_textures.rx3";
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000036E4 File Offset: 0x000018E4
		public static string ManagerTextureFileName(int dress, int skin, int color, int coat)
		{
			if (FifaEnvironment.Year == 14)
			{
				return string.Concat(new string[]
				{
					"data/sceneassets/manager/manager_",
					dress.ToString(),
					"_",
					skin.ToString(),
					"_",
					color.ToString(),
					"_",
					coat.ToString(),
					"_textures.rx3"
				});
			}
			return string.Concat(new string[]
			{
				"data/sceneassets/slc/manager_",
				dress.ToString(),
				"_0_",
				skin.ToString(),
				"_",
				color.ToString(),
				"_",
				coat.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000037B4 File Offset: 0x000019B4
		public static string ManagerModelFileName(int dress, int body, int coat)
		{
			if (FifaEnvironment.Year == 14)
			{
				return string.Concat(new string[]
				{
					"data/sceneassets/manager/manager_",
					dress.ToString(),
					"_",
					body.ToString(),
					"_",
					coat.ToString(),
					".rx3"
				});
			}
			return string.Concat(new string[]
			{
				"data/sceneassets/slc/manager_",
				dress.ToString(),
				"_",
				body.ToString(),
				"_1_",
				coat.ToString(),
				".rx3"
			});
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000385D File Offset: 0x00001A5D
		public static string RevModManagerModelFileName(int teamId)
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/sceneassets/manager/specificmanager_" + teamId.ToString() + "_0_0.rx3";
			}
			return "data/sceneassets/slc/specificmanager_" + teamId.ToString() + "_0_0.rx3";
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003895 File Offset: 0x00001A95
		public static Bitmap GetManagerTextures(int dress, int skin, int color, int coat)
		{
			return FifaEnvironment.GetBmpFromRx3(Manager.ManagerTextureFileName(dress, skin, color, coat), 0);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000038A6 File Offset: 0x00001AA6
		public static Bitmap GetRevModManagerTextures(int teamId)
		{
			return FifaEnvironment.GetBmpFromRx3(Manager.RevModManagerTextureFileName(teamId), 0);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000038B4 File Offset: 0x00001AB4
		public static bool SetRevModManagerTexture(int teamId, Bitmap bitmap)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/manager/specificmanager_#_0_0_textures.rx3", Manager.RevModManagerTextureFileName(teamId), array, ECompressionMode.None, null);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000038DF File Offset: 0x00001ADF
		public static bool SetRevModManagerModel(int teamId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Manager.RevModManagerModelFileName(teamId), false, ECompressionMode.None, null);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000038F0 File Offset: 0x00001AF0
		public static bool SetRevModManagerTexture(int teamId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Manager.RevModManagerTextureFileName(teamId), false, ECompressionMode.None, null);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003901 File Offset: 0x00001B01
		public static Rx3File GetManagerModel(int dress, int body, int coat)
		{
			return FifaEnvironment.GetRx3FromZdata(Manager.ManagerModelFileName(dress, body, coat));
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003910 File Offset: 0x00001B10
		public static Rx3File GetRevModManagerModel(int teamId)
		{
			return FifaEnvironment.GetRx3FromZdata(Manager.RevModManagerModelFileName(teamId));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003920 File Offset: 0x00001B20
		public static bool SetManager(int dress, int skin, int color, int coat, Bitmap bitmap)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata(Manager.ManagerTextureFileName(0, 0, 0, 0), Manager.ManagerTextureFileName(dress, skin, color, coat), array, ECompressionMode.Chunkzip, Manager.ManagerSignature(dress, skin, color, coat));
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000395B File Offset: 0x00001B5B
		public static bool DeleteManagerTexture(int dress, int skin, int color, int coat)
		{
			return FifaEnvironment.DeleteFromZdata(Manager.ManagerTextureFileName(dress, skin, color, coat));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000396B File Offset: 0x00001B6B
		public static bool DeleteRevModManagerTexture(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Manager.RevModManagerTextureFileName(teamId));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003978 File Offset: 0x00001B78
		public static bool DeleteRevModManagerModel(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Manager.RevModManagerModelFileName(teamId));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003988 File Offset: 0x00001B88
		private static Rx3Signatures ManagerSignature(int dress, int skin, int color, int coat)
		{
			if (FifaEnvironment.Year == 14)
			{
				return new Rx3Signatures(1398432, 36, new string[] { string.Concat(new string[]
				{
					"manager_",
					dress.ToString(),
					"_",
					skin.ToString(),
					"_",
					color.ToString(),
					"_",
					coat.ToString(),
					"_cm.Raster"
				}) });
			}
			return new Rx3Signatures(2097968, 27, new string[] { string.Concat(new string[]
			{
				"manager_",
				dress.ToString(),
				"_",
				skin.ToString(),
				"_",
				color.ToString(),
				"_",
				coat.ToString(),
				"_cm"
			}) });
		}
	}
}
