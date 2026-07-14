using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000013 RID: 19
	public class MowingPattern : IdObject
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002B03 File Offset: 0x00000D03
		public MowingPattern(int mowingPatternId)
			: base(mowingPatternId)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004527 File Offset: 0x00002727
		public override IdObject Clone(int newMowingPatternId)
		{
			MowingPattern mowingPattern = (MowingPattern)base.Clone(newMowingPatternId);
			if (mowingPattern != null)
			{
				FifaEnvironment.CloneIntoZdata(MowingPattern.MowingPatternFileName(base.Id), MowingPattern.MowingPatternFileName(newMowingPatternId));
			}
			return mowingPattern;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004550 File Offset: 0x00002750
		public override string ToString()
		{
			string text = base.Id.ToString("000");
			return "Mowing Pattern n. " + text;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000457C File Offset: 0x0000277C
		public static string MowingPatternFileName(int mowingPatternId)
		{
			return "data/sceneassets/pitch/pitchmowpattern_" + mowingPatternId.ToString() + "_textures.rx3";
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004594 File Offset: 0x00002794
		public static Bitmap GetMowingPattern(int mowingPatternId)
		{
			return FifaEnvironment.GetBmpFromRx3(MowingPattern.MowingPatternFileName(mowingPatternId));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000045A4 File Offset: 0x000027A4
		public static bool SetMowingPattern(int mowingPatternId, string srcFileName)
		{
			string text = MowingPattern.MowingPatternFileName(mowingPatternId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000045C1 File Offset: 0x000027C1
		public static bool DeleteMowingPattern(int mowingPatternId)
		{
			return FifaEnvironment.DeleteFromZdata(MowingPattern.MowingPatternFileName(mowingPatternId));
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000045CE File Offset: 0x000027CE
		public static string MowingPatternTemplate()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/sceneassets/pitch/2014_pitchmowpattern_#_textures.rx3";
			}
			return "data/sceneassets/pitch/pitchmowpattern_#_textures.rx3";
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000045E4 File Offset: 0x000027E4
		public static bool SetMowingPattern(int mowingPatternId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(MowingPattern.MowingPatternTemplate(), mowingPatternId, bitmap, ECompressionMode.Chunkzip);
		}
	}
}
