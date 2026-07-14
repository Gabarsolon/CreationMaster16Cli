using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200000E RID: 14
	public class Police : IdObject
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00002B03 File Offset: 0x00000D03
		public Police(int policeId)
			: base(policeId)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000034DC File Offset: 0x000016DC
		public override IdObject Clone(int newId)
		{
			Police police = (Police)base.Clone(newId);
			if (police != null)
			{
				FifaEnvironment.CloneIntoZdata(Police.PoliceFileName(base.Id, 0), Police.PoliceFileName(newId, 0));
				FifaEnvironment.CloneIntoZdata(Police.PoliceFileName(base.Id, 1), Police.PoliceFileName(newId, 1));
			}
			return police;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000352C File Offset: 0x0000172C
		public override string ToString()
		{
			string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
			return "Police n. " + text;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000355C File Offset: 0x0000175C
		public static string PoliceFileName(int policeid, int type)
		{
			if (FifaEnvironment.Year == 14)
			{
				return string.Concat(new string[]
				{
					"data/sceneassets/policeofficer/policeofficer_",
					policeid.ToString(),
					"_0_0_",
					type.ToString(),
					"_textures.rx3"
				});
			}
			return string.Concat(new string[]
			{
				"data/sceneassets/slc/policeofficer_",
				policeid.ToString(),
				"_0_0_",
				type.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000035E1 File Offset: 0x000017E1
		public static string PoliceTemplateName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/sceneassets/policeofficer/policeofficer_#_0_0_%_textures.rx3";
			}
			return "data/sceneassets/slc/policeofficer_#_0_0_%_textures.rx3";
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000035F7 File Offset: 0x000017F7
		public static Bitmap GetPolice(int policeid, int type)
		{
			return FifaEnvironment.GetBmpFromRx3(Police.PoliceFileName(policeid, type), 0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003608 File Offset: 0x00001808
		public static bool SetPolice(int policeid, int type, Bitmap bitmap)
		{
			int[] array = new int[] { policeid, type };
			return FifaEnvironment.ImportBmpsIntoZdata(Police.PoliceTemplateName(), array, bitmap, ECompressionMode.Chunkzip, Police.PoliceSignature(policeid, type));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003638 File Offset: 0x00001838
		public static bool DeletePolice(int policeid, int type)
		{
			return FifaEnvironment.DeleteFromZdata(Police.PoliceFileName(policeid, type));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003648 File Offset: 0x00001848
		private static Rx3Signatures PoliceSignature(int policeid, int type)
		{
			return new Rx3Signatures(43984, 48, new string[] { string.Concat(new string[]
			{
				"policeofficer_",
				policeid.ToString(),
				"_0_0_",
				type.ToString(),
				"_cm.Raster"
			}) });
		}
	}
}
