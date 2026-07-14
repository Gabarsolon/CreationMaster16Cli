using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000015 RID: 21
	public class CmSponsor
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00004650 File Offset: 0x00002850
		public static string CmSponsorTemplateBigFileName()
		{
			return "data/ui/artassets/cmsponsors/cmsponsor_#.big";
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004657 File Offset: 0x00002857
		public static string CmSponsorTemplateDdsName()
		{
			return "36";
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000465E File Offset: 0x0000285E
		public static string CmSponsorBigFileName(int id)
		{
			return "data/ui/artassets/cmsponsors/cmsponsor_" + id.ToString() + ".big";
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004676 File Offset: 0x00002876
		public static string CmSponsorDdsFileName(int id)
		{
			return "data/ui/imgassets/cmsponsors/cmsponsors" + id.ToString() + ".dds";
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000468E File Offset: 0x0000288E
		public static Bitmap GetCmSponsor(int id)
		{
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.GetArtasset(CmSponsor.CmSponsorBigFileName(id));
			}
			return FifaEnvironment.GetDdsArtasset(CmSponsor.CmSponsorDdsFileName(id));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000046B0 File Offset: 0x000028B0
		public static string CmSponsorsDdsTemplateFileName()
		{
			return "data/ui/imgassets/cmsponsors/cmsponsors#.dds";
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000046B7 File Offset: 0x000028B7
		public static bool SetCmSponsor(int id, Bitmap bitmap)
		{
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.SetArtasset(CmSponsor.CmSponsorTemplateBigFileName(), CmSponsor.CmSponsorTemplateDdsName(), id, bitmap);
			}
			return FifaEnvironment.SetDdsArtasset(CmSponsor.CmSponsorsDdsTemplateFileName(), id, bitmap);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000046E0 File Offset: 0x000028E0
		public static bool DeleteCmSponsor(int id)
		{
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.DeleteFromZdata(CmSponsor.CmSponsorBigFileName(id));
			}
			return FifaEnvironment.DeleteFromZdata(CmSponsor.CmSponsorDdsFileName(id));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004702 File Offset: 0x00002902
		public static string CmSponsorSmallTemplateBigFileName()
		{
			return "data/ui/artassets/cmsponsorssmall/cmsponsor_sml_#.big";
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004609 File Offset: 0x00002809
		public static string CmSponsorSmallTemplateDdsName()
		{
			return "4";
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004709 File Offset: 0x00002909
		public static string CmSponsorSmallBigFileName(int id)
		{
			return "data/ui/artassets/cmsponsorssmall/cmsponsor_sml_" + id.ToString() + ".big";
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004721 File Offset: 0x00002921
		public static Bitmap GetCmSponsorSmall(int id)
		{
			return FifaEnvironment.GetArtasset(CmSponsor.CmSponsorSmallBigFileName(id));
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000472E File Offset: 0x0000292E
		public static bool SetCmSponsorSmall(int id, Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(CmSponsor.CmSponsorSmallTemplateBigFileName(), CmSponsor.CmSponsorSmallTemplateDdsName(), id, bitmap);
		}
	}
}
