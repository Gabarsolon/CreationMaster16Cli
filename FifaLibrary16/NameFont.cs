using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200000B RID: 11
	public class NameFont : IdObject
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00003257 File Offset: 0x00001457
		public static void Clone(int oldStyle, int newStyle)
		{
			FifaEnvironment.CloneIntoZdata(NameFont.NameFontFileName(oldStyle), NameFont.NameFontFileName(newStyle));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000326B File Offset: 0x0000146B
		public static string NameFontFileName(int id)
		{
			return "data/sceneassets/jerseyfonts/font_" + id.ToString() + ".ttf";
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002B03 File Offset: 0x00000D03
		public NameFont(int id)
			: base(id)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003284 File Offset: 0x00001484
		public override string ToString()
		{
			return "Name Font n. " + base.Id.ToString();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000032AC File Offset: 0x000014AC
		public static string CanShowNameFont(int style)
		{
			string text = NameFont.NameFontFileName(style);
			string text2 = FifaEnvironment.GameDir + text;
			if (File.Exists(text2))
			{
				return text2;
			}
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000032D7 File Offset: 0x000014D7
		public static bool Delete(int style)
		{
			return FifaEnvironment.DeleteFromZdata(NameFont.NameFontFileName(style));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000032E4 File Offset: 0x000014E4
		public static bool Import(int style, string srcFileName)
		{
			string text = NameFont.NameFontFileName(style);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003301 File Offset: 0x00001501
		public static bool Export(int style, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(NameFont.NameFontFileName(style), exportDir);
		}
	}
}
