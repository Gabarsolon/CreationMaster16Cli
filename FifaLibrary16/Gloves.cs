using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000018 RID: 24
	public class Gloves : IdObject
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002B03 File Offset: 0x00000D03
		public Gloves(int ballId)
			: base(ballId)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004A57 File Offset: 0x00002C57
		public static string GlovesFileName(int id)
		{
			return "data/sceneassets/gkgloves/gkgloves_0_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004A6F File Offset: 0x00002C6F
		public static Rx3File GetGloves(int id)
		{
			return FifaEnvironment.GetRx3FromZdata(Gloves.GlovesFileName(id));
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004A7C File Offset: 0x00002C7C
		public static bool SetGloves(int id, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/gkgloves/gkgloves_0_#_textures.rx3", id, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004A8C File Offset: 0x00002C8C
		public static bool SetGloves(int id, string rx3FileName)
		{
			string text = Gloves.GlovesFileName(id);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004AA9 File Offset: 0x00002CA9
		public static bool DeleteGloves(int id)
		{
			return FifaEnvironment.DeleteFromZdata(Gloves.GlovesFileName(id));
		}
	}
}
