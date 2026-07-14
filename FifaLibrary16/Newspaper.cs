using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000014 RID: 20
	public class Newspaper
	{
		// Token: 0x060000FE RID: 254 RVA: 0x000045F3 File Offset: 0x000027F3
		public static string NewspaperTemplateBigFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/newspapers/2014_np_#.big";
			}
			return "data/ui/artassets/newspapers/np_#.big";
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004609 File Offset: 0x00002809
		public static string NewspaperTemplateDdsName()
		{
			return "4";
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004610 File Offset: 0x00002810
		public static string NewspaperBigFileName(int id)
		{
			return "data/ui/artassets/newspapers/np_" + id.ToString() + ".big";
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004628 File Offset: 0x00002828
		public static Bitmap GetNewspaper(int id)
		{
			return FifaEnvironment.GetArtasset(Newspaper.NewspaperBigFileName(id));
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004635 File Offset: 0x00002835
		public static bool SetNewspaper(int id, Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Newspaper.NewspaperTemplateBigFileName(), Newspaper.NewspaperTemplateDdsName(), id, bitmap);
		}

		// Token: 0x020000A6 RID: 166
		public enum ENewspaperCountry
		{
			// Token: 0x04001227 RID: 4647
			Equipe,
			// Token: 0x04001228 RID: 4648
			Kicker,
			// Token: 0x04001229 RID: 4649
			SkySport,
			// Token: 0x0400122A RID: 4650
			CorriereDelloSport,
			// Token: 0x0400122B RID: 4651
			Carrusel,
			// Token: 0x0400122C RID: 4652
			LasNoticias,
			// Token: 0x0400122D RID: 4653
			FutbolMundial,
			// Token: 0x0400122E RID: 4654
			EAInsider,
			// Token: 0x0400122F RID: 4655
			RMC,
			// Token: 0x04001230 RID: 4656
			Deportes,
			// Token: 0x04001231 RID: 4657
			Marca,
			// Token: 0x04001232 RID: 4658
			LaStampa,
			// Token: 0x04001233 RID: 4659
			talkSport,
			// Token: 0x04001234 RID: 4660
			Carrusel2,
			// Token: 0x04001235 RID: 4661
			Soccer
		}
	}
}
