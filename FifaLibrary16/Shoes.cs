using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000011 RID: 17
	public class Shoes : IdObject
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00003C9E File Offset: 0x00001E9E
		public static Color GetGenericColor(int colorId)
		{
			if (colorId >= 0 && colorId <= 15)
			{
				return Shoes.c_ShoesColor[colorId];
			}
			return Color.FromArgb(0, 0, 0, 0);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00003CBE File Offset: 0x00001EBE
		public static Color[] ShoesColorPalette
		{
			get
			{
				return Shoes.c_ShoesColor;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003CC5 File Offset: 0x00001EC5
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00003CCD File Offset: 0x00001ECD
		public bool HasName
		{
			get
			{
				return this.m_HasName;
			}
			set
			{
				this.m_HasName = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003CD6 File Offset: 0x00001ED6
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00003CDE File Offset: 0x00001EDE
		public string Name
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
				FifaEnvironment.Language.SetShoesName(base.Id, this.m_LanguageName);
				this.m_HasName = true;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00003D04 File Offset: 0x00001F04
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00003D0C File Offset: 0x00001F0C
		public int shoecolor1
		{
			get
			{
				return this.m_shoecolor1;
			}
			set
			{
				this.m_shoecolor1 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00003D15 File Offset: 0x00001F15
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00003D1D File Offset: 0x00001F1D
		public int shoecolor2
		{
			get
			{
				return this.m_shoecolor2;
			}
			set
			{
				this.m_shoecolor2 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003D26 File Offset: 0x00001F26
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00003D2E File Offset: 0x00001F2E
		public int shoedesign
		{
			get
			{
				return this.m_shoedesign;
			}
			set
			{
				this.m_shoedesign = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003D37 File Offset: 0x00001F37
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00003D3F File Offset: 0x00001F3F
		public int powid
		{
			get
			{
				return this.m_powid;
			}
			set
			{
				this.m_powid = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003D48 File Offset: 0x00001F48
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00003D50 File Offset: 0x00001F50
		public bool IsAdidas
		{
			get
			{
				return this.m_IsAdidas;
			}
			set
			{
				this.m_IsAdidas = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003D59 File Offset: 0x00001F59
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00003D61 File Offset: 0x00001F61
		public bool IsAvailableinStore
		{
			get
			{
				return this.m_IsAvailableinStore;
			}
			set
			{
				this.m_IsAvailableinStore = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003D6A File Offset: 0x00001F6A
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00003D72 File Offset: 0x00001F72
		public bool IsGender
		{
			get
			{
				return this.m_IsGender;
			}
			set
			{
				this.m_IsGender = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003D7B File Offset: 0x00001F7B
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00003D83 File Offset: 0x00001F83
		public bool IsEmbargoed
		{
			get
			{
				return this.m_IsEmbargoed;
			}
			set
			{
				this.m_IsEmbargoed = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00003D94 File Offset: 0x00001F94
		public bool IsLegacy
		{
			get
			{
				return this.m_IsLegacy;
			}
			set
			{
				this.m_IsLegacy = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003D9D File Offset: 0x00001F9D
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00003DA5 File Offset: 0x00001FA5
		public bool IsLicensed
		{
			get
			{
				return this.m_IsLicensed;
			}
			set
			{
				this.m_IsLicensed = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003DAE File Offset: 0x00001FAE
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00003DB6 File Offset: 0x00001FB6
		public bool IsLocked
		{
			get
			{
				return this.m_IsLocked;
			}
			set
			{
				this.m_IsLocked = value;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public Shoes(Record r)
			: base(r.IntField[FI.playerboots_shoetype])
		{
			this.m_LanguageName = FifaEnvironment.Language.GetShoesName(base.Id);
			this.m_HasName = this.m_LanguageName != null;
			if (!this.m_HasName)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				this.m_LanguageName = "Shoes n. " + text;
			}
			this.m_shoecolor1 = r.GetAndCheckIntField(FI.playerboots_shoecolor1);
			this.m_shoecolor2 = r.GetAndCheckIntField(FI.playerboots_shoecolor2);
			this.m_shoedesign = r.GetAndCheckIntField(FI.playerboots_shoedesign);
			this.m_IsAdidas = r.IntField[FI.playerboots_isadidas] > 0;
			this.m_IsAvailableinStore = r.IntField[FI.playerboots_isavailableinstore] > 0;
			this.m_IsEmbargoed = r.IntField[FI.playerboots_isembargoed] > 0;
			if (FI.playerboots_gender >= 0)
			{
				this.m_IsGender = r.IntField[FI.playerboots_gender] != 0;
			}
			this.m_IsLegacy = r.IntField[FI.playerboots_islegacy] > 0;
			this.m_IsLicensed = r.IntField[FI.playerboots_islicensed] > 0;
			this.m_IsLocked = r.IntField[FI.playerboots_islocked] > 0;
			this.m_powid = r.GetAndCheckIntField(FI.playerboots_powid);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003F2C File Offset: 0x0000212C
		public Shoes(int shoesId)
			: base(shoesId)
		{
			this.m_LanguageName = FifaEnvironment.Language.GetShoesName(base.Id);
			this.m_HasName = this.m_LanguageName != null;
			if (!this.m_HasName)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				this.m_LanguageName = "Shoes n. " + text;
			}
			this.m_shoecolor1 = 30;
			this.m_shoecolor2 = 31;
			this.m_shoedesign = 0;
			this.m_IsAdidas = false;
			this.m_IsAvailableinStore = false;
			this.m_IsGender = false;
			this.m_IsEmbargoed = false;
			this.m_IsLegacy = false;
			this.m_IsLicensed = false;
			this.m_IsLocked = false;
			this.m_powid = -1;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003FE4 File Offset: 0x000021E4
		public void SaveShoes(Record r)
		{
			r.IntField[FI.playerboots_shoetype] = base.Id;
			r.IntField[FI.playerboots_shoecolor1] = this.m_shoecolor1;
			r.IntField[FI.playerboots_shoecolor2] = this.m_shoecolor2;
			r.IntField[FI.playerboots_shoedesign] = this.m_shoedesign;
			r.IntField[FI.playerboots_isadidas] = (this.m_IsAdidas ? 1 : 0);
			r.IntField[FI.playerboots_isavailableinstore] = (this.m_IsAvailableinStore ? 1 : 0);
			r.IntField[FI.playerboots_gender] = (this.m_IsGender ? 2 : 0);
			r.IntField[FI.playerboots_isembargoed] = 0;
			r.IntField[FI.playerboots_islegacy] = 0;
			r.IntField[FI.playerboots_islicensed] = ((base.Id == 0) ? 0 : 1);
			r.IntField[FI.playerboots_islocked] = 0;
			r.IntField[FI.playerboots_powid] = this.m_powid;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000040D4 File Offset: 0x000022D4
		public override IdObject Clone(int newId)
		{
			Shoes shoes = (Shoes)base.Clone(newId);
			if (shoes != null)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				shoes.Name = "Shoes n. " + text;
				FifaEnvironment.CloneIntoZdata(Shoes.ShoesTexturesFileName(base.Id, 0), Shoes.ShoesTexturesFileName(newId, 0));
				FifaEnvironment.CloneIntoZdata(Shoes.ShoesModelFileName(base.Id), Shoes.ShoesModelFileName(newId));
			}
			return shoes;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public override string ToString()
		{
			return this.m_LanguageName;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004148 File Offset: 0x00002348
		public static string ShoesTexturesFileName(int shoesBrand, int shoesDesign)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/shoe/shoe_",
				shoesBrand.ToString(),
				"_",
				shoesDesign.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004181 File Offset: 0x00002381
		public static string ShoesModelFileName(int shoesBrand)
		{
			return "data/sceneassets/shoe/shoe_" + shoesBrand.ToString() + ".rx3";
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004199 File Offset: 0x00002399
		public static Bitmap GetShoesColorTexture(int shoesBrand, int shoesDesign)
		{
			return FifaEnvironment.GetBmpFromRx3(Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign));
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000041A7 File Offset: 0x000023A7
		public static Bitmap[] GetShoesTextures(int shoesBrand, int shoesDesign)
		{
			return FifaEnvironment.GetBmpsFromRx3(Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000041B5 File Offset: 0x000023B5
		public static bool ImportShoesTextures(int shoesBrand, int shoesColor, string rx3FileName)
		{
			return Shoes.SetShoesTextures(shoesBrand, shoesColor, rx3FileName);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000041BF File Offset: 0x000023BF
		public static bool ExportShoesTextures(int shoesBrand, int shoesColor, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(Shoes.ShoesTexturesFileName(shoesBrand, shoesColor), exportDir);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000041CE File Offset: 0x000023CE
		public static Rx3File GetShoesModel(int shoesBrand)
		{
			return FifaEnvironment.GetRx3FromZdata(Shoes.ShoesModelFileName(shoesBrand));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000041DB File Offset: 0x000023DB
		public static string ShoeTemplateFilename()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/sceneassets/shoe/2014_shoe_#_%_textures.rx3";
			}
			return "data/sceneassets/shoe/shoe_#_%_textures.rx3";
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000041F4 File Offset: 0x000023F4
		public static bool SetShoesTextures(int shoesBrand, int shoesDesign, Bitmap[] bitmaps)
		{
			Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			int[] array = new int[] { shoesBrand, shoesDesign };
			return FifaEnvironment.ImportBmpsIntoZdata(Shoes.ShoeTemplateFilename(), array, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004228 File Offset: 0x00002428
		public static bool SetShoesTextures(int shoesBrand, int shoesDesign, string rx3FileName)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004248 File Offset: 0x00002448
		public static bool SetShoesModel(int shoesBrand, string rx3FileName)
		{
			string text = Shoes.ShoesModelFileName(shoesBrand);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004265 File Offset: 0x00002465
		public static bool ExportShoesModel(int shoesBrand, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(Shoes.ShoesModelFileName(shoesBrand), exportDir);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004273 File Offset: 0x00002473
		public static bool DeleteShoes(int shoesBrand, int shoesColor)
		{
			FifaEnvironment.DeleteFromZdata(Shoes.ShoesTexturesFileName(shoesBrand, shoesColor));
			FifaEnvironment.DeleteFromZdata(Shoes.ShoesModelFileName(shoesBrand));
			return true;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000428F File Offset: 0x0000248F
		public static bool DeleteShoesTextures(int shoesBrand, int shoesColor)
		{
			FifaEnvironment.DeleteFromZdata(Shoes.ShoesTexturesFileName(shoesBrand, shoesColor));
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000429F File Offset: 0x0000249F
		public static bool DeleteShoesModel(int shoesBrand)
		{
			FifaEnvironment.DeleteFromZdata(Shoes.ShoesModelFileName(shoesBrand));
			return true;
		}

		// Token: 0x0400000D RID: 13
		private static Color[] c_ShoesColor = new Color[]
		{
			Color.FromArgb(255, 20, 20, 20),
			Color.FromArgb(255, 50, 34, 105),
			Color.FromArgb(255, 1, 32, 87),
			Color.FromArgb(255, 8, 77, 158),
			Color.FromArgb(255, 1, 159, 224),
			Color.FromArgb(255, 0, 177, 17),
			Color.FromArgb(255, 120, 200, 25),
			Color.FromArgb(255, 250, 245, 10),
			Color.FromArgb(255, 250, 240, 0),
			Color.FromArgb(255, 236, 86, 1),
			Color.FromArgb(255, 227, 1, 103),
			Color.FromArgb(255, 177, 11, 35),
			Color.FromArgb(255, 112, 37, 42),
			Color.FromArgb(255, 146, 114, 63),
			Color.FromArgb(255, 160, 160, 160),
			Color.FromArgb(255, 235, 235, 235)
		};

		// Token: 0x0400000E RID: 14
		private bool m_HasName;

		// Token: 0x0400000F RID: 15
		private string m_LanguageName;

		// Token: 0x04000010 RID: 16
		private int m_shoecolor1;

		// Token: 0x04000011 RID: 17
		private int m_shoecolor2;

		// Token: 0x04000012 RID: 18
		private int m_shoedesign;

		// Token: 0x04000013 RID: 19
		private int m_powid;

		// Token: 0x04000014 RID: 20
		private bool m_IsAdidas;

		// Token: 0x04000015 RID: 21
		private bool m_IsAvailableinStore;

		// Token: 0x04000016 RID: 22
		private bool m_IsGender;

		// Token: 0x04000017 RID: 23
		private bool m_IsEmbargoed;

		// Token: 0x04000018 RID: 24
		private bool m_IsLegacy;

		// Token: 0x04000019 RID: 25
		private bool m_IsLicensed;

		// Token: 0x0400001A RID: 26
		private bool m_IsLocked;
	}
}
