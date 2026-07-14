using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000022 RID: 34
	public class Country : IdObject
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00008794 File Offset: 0x00006994
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000879C File Offset: 0x0000699C
		public int ChantRegionIndex
		{
			get
			{
				return this.m_ChantRegionIndex;
			}
			set
			{
				this.m_ChantRegionIndex = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000087A5 File Offset: 0x000069A5
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x000087AD File Offset: 0x000069AD
		public int PALanguageIndex
		{
			get
			{
				return this.m_PALanguageIndex;
			}
			set
			{
				this.m_PALanguageIndex = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000087B6 File Offset: 0x000069B6
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x000087BE File Offset: 0x000069BE
		public int CrowdBedsRegionIndex
		{
			get
			{
				return this.m_CrowdBedsRegionIndex;
			}
			set
			{
				this.m_CrowdBedsRegionIndex = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000087C7 File Offset: 0x000069C7
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x000087CF File Offset: 0x000069CF
		public int WhistlesRegionIndex
		{
			get
			{
				return this.m_WhistlesRegionIndex;
			}
			set
			{
				this.m_WhistlesRegionIndex = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000087D8 File Offset: 0x000069D8
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000087E0 File Offset: 0x000069E0
		public int AmbienceRegionIndex
		{
			get
			{
				return this.m_AmbienceRegionIndex;
			}
			set
			{
				this.m_AmbienceRegionIndex = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000087E9 File Offset: 0x000069E9
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000087F1 File Offset: 0x000069F1
		public int HecklesRegionIndex
		{
			get
			{
				return this.m_HecklesRegionIndex;
			}
			set
			{
				this.m_HecklesRegionIndex = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000087FA File Offset: 0x000069FA
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00008802 File Offset: 0x00006A02
		public int ReactionsRegionIndex
		{
			get
			{
				return this.m_ReactionsRegionIndex;
			}
			set
			{
				this.m_ReactionsRegionIndex = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000880B File Offset: 0x00006A0B
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00008813 File Offset: 0x00006A13
		public int PlayerCallPatchBankIndex
		{
			get
			{
				return this.m_PlayerCallPatchBankIndex;
			}
			set
			{
				this.m_PlayerCallPatchBankIndex = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000881C File Offset: 0x00006A1C
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00008824 File Offset: 0x00006A24
		public int TeamCanWhistleIndex
		{
			get
			{
				return this.m_TeamCanWhistleIndex;
			}
			set
			{
				this.m_TeamCanWhistleIndex = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000882D File Offset: 0x00006A2D
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00008835 File Offset: 0x00006A35
		public string DatabaseName
		{
			get
			{
				return this.m_nationname;
			}
			set
			{
				this.m_nationname = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000883E File Offset: 0x00006A3E
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00008846 File Offset: 0x00006A46
		public int Confederation
		{
			get
			{
				return this.m_confederation;
			}
			set
			{
				this.m_confederation = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000884F File Offset: 0x00006A4F
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00008857 File Offset: 0x00006A57
		public int ContinentalCupTarget
		{
			get
			{
				return this.m_ContinentalCupTarget;
			}
			set
			{
				this.m_ContinentalCupTarget = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00008860 File Offset: 0x00006A60
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00008868 File Offset: 0x00006A68
		public int WorldCupTarget
		{
			get
			{
				return this.m_WorldCupTarget;
			}
			set
			{
				this.m_WorldCupTarget = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00008871 File Offset: 0x00006A71
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00008879 File Offset: 0x00006A79
		public int Level
		{
			get
			{
				return this.m_Level;
			}
			set
			{
				this.m_Level = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00008882 File Offset: 0x00006A82
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000888A File Offset: 0x00006A8A
		public bool Top_tier
		{
			get
			{
				return this.m_top_tier;
			}
			set
			{
				this.m_top_tier = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00008893 File Offset: 0x00006A93
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000889B File Offset: 0x00006A9B
		public string IsoCountryCode
		{
			get
			{
				return this.m_isocountrycode;
			}
			set
			{
				this.m_isocountrycode = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000088A4 File Offset: 0x00006AA4
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000088AC File Offset: 0x00006AAC
		public string DefaultCommLang
		{
			get
			{
				return this.m_DefaultCommLang;
			}
			set
			{
				this.m_DefaultCommLang = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000088B5 File Offset: 0x00006AB5
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000088BD File Offset: 0x00006ABD
		public string LanguageName
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000088C6 File Offset: 0x00006AC6
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000088CE File Offset: 0x00006ACE
		public string LanguageShortName
		{
			get
			{
				return this.m_LanguageShortName;
			}
			set
			{
				this.m_LanguageShortName = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000088D7 File Offset: 0x00006AD7
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000088DF File Offset: 0x00006ADF
		public string LanguageAbbreviation
		{
			get
			{
				return this.m_LanguageAbbreviation;
			}
			set
			{
				this.m_LanguageAbbreviation = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000088E8 File Offset: 0x00006AE8
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000088F0 File Offset: 0x00006AF0
		public Team NationalTeam
		{
			get
			{
				return this.m_NationalTeam;
			}
			set
			{
				this.m_NationalTeam = value;
				if (this.m_NationalTeam != null)
				{
					this.m_NationalTeamId = this.m_NationalTeam.Id;
					return;
				}
				this.m_NationalTeamId = -1;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000891A File Offset: 0x00006B1A
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00008922 File Offset: 0x00006B22
		public int NationalTeamId
		{
			get
			{
				return this.m_NationalTeamId;
			}
			set
			{
				this.m_NationalTeamId = value;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000892C File Offset: 0x00006B2C
		public Country(int countryid)
			: base(countryid)
		{
			this.m_nationname = "Country " + countryid.ToString();
			this.m_LanguageName = this.m_nationname;
			this.m_LanguageShortName = this.m_nationname;
			this.m_LanguageAbbreviation = "XXX";
			this.m_confederation = 0;
			this.m_top_tier = false;
			this.m_nationstartingfirstletter = 1;
			this.m_isocountrycode = "XX";
			this.m_NationalTeamId = -1;
			this.m_NationalTeam = null;
			this.m_WorldCupTarget = 0;
			this.m_ContinentalCupTarget = 0;
			this.m_Level = 7;
			this.m_ChantRegionIndex = 1;
			this.m_PALanguageIndex = 0;
			this.m_CrowdBedsRegionIndex = 0;
			this.m_WhistlesRegionIndex = 0;
			this.m_AmbienceRegionIndex = 0;
			this.m_PlayerCallPatchBankIndex = 0;
			this.m_HecklesRegionIndex = 0;
			this.m_TeamCanWhistleIndex = 0;
			this.m_ReactionsRegionIndex = 0;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000089FC File Offset: 0x00006BFC
		public Country(Record r)
			: base(r.IntField[FI.nations_nationid])
		{
			this.m_WorldCupTarget = 0;
			this.m_ContinentalCupTarget = 0;
			this.m_Level = 7;
			this.Load(r);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00008A2C File Offset: 0x00006C2C
		public void Load(Record r)
		{
			this.m_nationname = r.StringField[FI.nations_nationname];
			this.m_confederation = r.GetAndCheckIntField(FI.nations_confederation) - 1;
			this.m_top_tier = r.GetAndCheckIntField(FI.nations_top_tier) != 0;
			this.m_nationstartingfirstletter = r.GetAndCheckIntField(FI.nations_nationstartingfirstletter);
			if (FI.nations_isocountrycode >= 0)
			{
				this.m_isocountrycode = r.StringField[FI.nations_isocountrycode];
			}
			if (FifaEnvironment.Language != null)
			{
				this.m_LanguageName = FifaEnvironment.Language.GetCountryString(base.Id, Language.ECountryStringType.Full);
				this.m_LanguageShortName = FifaEnvironment.Language.GetCountryString(base.Id, Language.ECountryStringType.Abbr15);
				this.m_LanguageAbbreviation = FifaEnvironment.Language.GetCountryString(base.Id, Language.ECountryStringType.Abbr3);
			}
			else
			{
				this.m_LanguageName = string.Empty;
				this.m_LanguageShortName = string.Empty;
				this.m_LanguageAbbreviation = string.Empty;
			}
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = this.m_nationname;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00008B20 File Offset: 0x00006D20
		public void FillFromAudionation(Record r)
		{
			this.m_ChantRegionIndex = r.GetAndCheckIntField(FI.audionation_ChantRegionIndex);
			this.m_PALanguageIndex = r.GetAndCheckIntField(FI.audionation_PALanguageIndex);
			this.m_DefaultCommLang = r.StringField[FI.audionation_DefaultCommLang];
			this.m_CrowdBedsRegionIndex = r.GetAndCheckIntField(FI.audionation_CrowdBedsRegionIndex);
			this.m_WhistlesRegionIndex = r.GetAndCheckIntField(FI.audionation_WhistlesRegionIndex);
			this.m_AmbienceRegionIndex = r.GetAndCheckIntField(FI.audionation_AmbienceRegionIndex);
			this.m_PlayerCallPatchBankIndex = r.GetAndCheckIntField(FI.audionation_PlayerCallPatchBankIndex);
			this.m_HecklesRegionIndex = r.GetAndCheckIntField(FI.audionation_HecklesRegionIndex);
			this.m_TeamCanWhistleIndex = r.GetAndCheckIntField(FI.audionation_TeamCanWhistleIndex);
			this.m_ReactionsRegionIndex = r.GetAndCheckIntField(FI.audionation_ReactionsRegionIndex);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public void SaveAudionation(Record r)
		{
			r.IntField[FI.audionation_nationid] = base.Id;
			r.IntField[FI.audionation_ChantRegionIndex] = this.m_ChantRegionIndex;
			r.StringField[FI.audionation_DefaultCommLang] = this.m_DefaultCommLang;
			r.IntField[FI.audionation_PALanguageIndex] = this.m_PALanguageIndex;
			r.IntField[FI.audionation_CrowdBedsRegionIndex] = this.m_CrowdBedsRegionIndex;
			r.IntField[FI.audionation_WhistlesRegionIndex] = this.m_WhistlesRegionIndex;
			r.IntField[FI.audionation_AmbienceRegionIndex] = this.m_AmbienceRegionIndex;
			r.IntField[FI.audionation_PlayerCallPatchBankIndex] = this.m_PlayerCallPatchBankIndex;
			r.IntField[FI.audionation_HecklesRegionIndex] = this.m_HecklesRegionIndex;
			r.IntField[FI.audionation_TeamCanWhistleIndex] = this.m_TeamCanWhistleIndex;
			r.IntField[FI.audionation_ReactionsRegionIndex] = this.m_ReactionsRegionIndex;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00008CAB File Offset: 0x00006EAB
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_NationalTeam = (Team)teamList.SearchId(this.m_NationalTeamId);
			Team nationalTeam = this.m_NationalTeam;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008CD0 File Offset: 0x00006ED0
		public void SetNationalTeam(Team nationalTeam, int nationalTeamId)
		{
			if (nationalTeam != null)
			{
				nationalTeamId = nationalTeam.Id;
			}
			if (nationalTeamId <= 0)
			{
				nationalTeam = null;
			}
			Team nationalTeam2 = this.m_NationalTeam;
			int nationalTeamId2 = this.m_NationalTeamId;
			if (nationalTeam2 != null)
			{
				nationalTeam2.NationalTeam = false;
			}
			this.m_NationalTeam = nationalTeam;
			this.m_NationalTeamId = nationalTeamId;
			if (this.m_NationalTeam != null)
			{
				this.m_NationalTeam.Country = this;
				this.m_NationalTeam.NationalTeam = true;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00008D38 File Offset: 0x00006F38
		public void SaveCountry(Record r)
		{
			r.IntField[FI.nations_nationid] = base.Id;
			r.StringField[FI.nations_nationname] = this.m_nationname;
			r.IntField[FI.nations_confederation] = this.m_confederation + 1;
			r.IntField[FI.nations_top_tier] = (this.m_top_tier ? 1 : 0);
			r.IntField[FI.nations_nationstartingfirstletter] = this.m_nationstartingfirstletter;
			r.StringField[FI.nations_isocountrycode] = this.m_isocountrycode;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008DBC File Offset: 0x00006FBC
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetCountryString(base.Id, Language.ECountryStringType.Full, this.m_LanguageName);
				FifaEnvironment.Language.SetCountryString(base.Id, Language.ECountryStringType.Abbr15, this.m_LanguageShortName);
				FifaEnvironment.Language.SetCountryString(base.Id, Language.ECountryStringType.Abbr3, this.m_LanguageAbbreviation);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00008E15 File Offset: 0x00007015
		public override string ToString()
		{
			if (this.m_LanguageName != null && this.m_LanguageName != string.Empty)
			{
				return this.m_LanguageName;
			}
			if (this.m_nationname != null)
			{
				return this.m_nationname;
			}
			return string.Empty;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000882D File Offset: 0x00006A2D
		public string DatabaseString()
		{
			return this.m_nationname;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00008E4C File Offset: 0x0000704C
		public string FlagBigFileName()
		{
			return Country.FlagBigFileName(base.Id);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00008E59 File Offset: 0x00007059
		public static string FlagTemplateBigFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/countryflags/2014_f_#.big";
			}
			return "data/ui/artassets/countryflags/f_#.big";
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000027B4 File Offset: 0x000009B4
		public static string FlagTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008E6F File Offset: 0x0000706F
		public static string FlagBigFileName(int id)
		{
			return "data/ui/artassets/countryflags/f_" + id.ToString() + ".big";
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008E87 File Offset: 0x00007087
		public Bitmap GetFlag()
		{
			return FifaEnvironment.GetArtasset(Country.FlagBigFileName(base.Id));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008E99 File Offset: 0x00007099
		public bool SetFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.FlagTemplateBigFileName(), Country.FlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00008EB1 File Offset: 0x000070B1
		public bool DeleteFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.FlagBigFileName());
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008EBE File Offset: 0x000070BE
		public string Flag512TemplateFileName()
		{
			return "data/ui/imgassets/flags512x512/f_#.dds";
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00008EC8 File Offset: 0x000070C8
		public string Flag512DdsFileName()
		{
			return "data/ui/imgassets/flags512x512/f_" + base.Id.ToString() + ".dds";
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008EF2 File Offset: 0x000070F2
		public static string Flag512DdsFileName(int id)
		{
			return "data/ui/imgassets/flags512x512/f_" + id.ToString() + ".dds";
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00008F0A File Offset: 0x0000710A
		public Bitmap GetFlag512()
		{
			return FifaEnvironment.GetDdsArtasset(this.Flag512DdsFileName());
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008F17 File Offset: 0x00007117
		public bool SetFlag512(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Flag512TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008F2B File Offset: 0x0000712B
		public bool DeleteFlag512()
		{
			return FifaEnvironment.DeleteFromZdata(this.Flag512DdsFileName());
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008F38 File Offset: 0x00007138
		public string MiniFlagBigFileName()
		{
			return Country.MiniFlagBigFileName(base.Id);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00008F45 File Offset: 0x00007145
		public static string MiniFlagTemplateBigFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/miniflags/2014_flag_#.big";
			}
			return "data/ui/artassets/miniflags/flag_#.big";
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00008F5B File Offset: 0x0000715B
		public static string MiniFlagTemplateDdsName()
		{
			return "208";
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00008F62 File Offset: 0x00007162
		public static string MiniFlagBigFileName(int id)
		{
			return "data/ui/artassets/miniflags/flag_" + id.ToString() + ".big";
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008F7A File Offset: 0x0000717A
		public Bitmap GetMiniFlag()
		{
			return FifaEnvironment.GetArtasset(Country.MiniFlagBigFileName(base.Id));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008F8C File Offset: 0x0000718C
		public bool SetMiniFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.MiniFlagTemplateBigFileName(), Country.MiniFlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008FA4 File Offset: 0x000071A4
		public bool DeleteMiniFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.MiniFlagBigFileName());
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008FB1 File Offset: 0x000071B1
		public string CardFlagBigFileName()
		{
			return Country.CardFlagBigFileName(base.Id);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008FBE File Offset: 0x000071BE
		public static string CardFlagTemplateBigFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/cardflags/2014_#.big";
			}
			return "data/ui/artassets/cardflags/#.big";
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000027B4 File Offset: 0x000009B4
		public static string CardFlagTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00008FD4 File Offset: 0x000071D4
		public static string CardFlagBigFileName(int id)
		{
			return "data/ui/artassets/cardflags/" + id.ToString() + ".big";
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00008FEC File Offset: 0x000071EC
		public Bitmap GetCardFlag()
		{
			return FifaEnvironment.GetArtasset(Country.CardFlagBigFileName(base.Id));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008FFE File Offset: 0x000071FE
		public bool SetCardFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.CardFlagTemplateBigFileName(), Country.CardFlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009016 File Offset: 0x00007216
		public bool DeleteCardFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.CardFlagBigFileName());
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009023 File Offset: 0x00007223
		public bool Fit(string lowerName, int id)
		{
			return (this.m_nationname != null && this.m_nationname.ToLower() == lowerName) || (this.m_LanguageName != null && this.m_LanguageName.ToLower() == lowerName);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000905E File Offset: 0x0000725E
		public string ShapeFileName()
		{
			return Country.ShapeFileName(base.Id);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000906B File Offset: 0x0000726B
		public static string ShapeFileName(int countryid)
		{
			return "data/ui/imgassets/tiles/careerhub/countryshapes/c" + countryid.ToString() + ".dds";
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00009083 File Offset: 0x00007283
		public string ShapeTemplateFileName()
		{
			return "data/ui/imgassets/tiles/careerhub/countryshapes/c#.dds";
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000908A File Offset: 0x0000728A
		public Bitmap GetShape()
		{
			return FifaEnvironment.GetDdsArtasset(this.ShapeFileName());
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009097 File Offset: 0x00007297
		public static Bitmap GetShape(int countryId)
		{
			return FifaEnvironment.GetDdsArtasset(Country.ShapeFileName(countryId));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000090A4 File Offset: 0x000072A4
		public bool SetShape(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.ShapeTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000090B8 File Offset: 0x000072B8
		public bool DeleteShape()
		{
			return FifaEnvironment.DeleteFromZdata(this.ShapeFileName());
		}

		// Token: 0x04000061 RID: 97
		private int m_ChantRegionIndex;

		// Token: 0x04000062 RID: 98
		private int m_PALanguageIndex;

		// Token: 0x04000063 RID: 99
		private int m_CrowdBedsRegionIndex;

		// Token: 0x04000064 RID: 100
		private int m_WhistlesRegionIndex;

		// Token: 0x04000065 RID: 101
		private int m_AmbienceRegionIndex;

		// Token: 0x04000066 RID: 102
		private int m_HecklesRegionIndex;

		// Token: 0x04000067 RID: 103
		private int m_ReactionsRegionIndex;

		// Token: 0x04000068 RID: 104
		private int m_PlayerCallPatchBankIndex;

		// Token: 0x04000069 RID: 105
		private int m_TeamCanWhistleIndex;

		// Token: 0x0400006A RID: 106
		private string m_nationname;

		// Token: 0x0400006B RID: 107
		public int m_confederation;

		// Token: 0x0400006C RID: 108
		private int m_ContinentalCupTarget;

		// Token: 0x0400006D RID: 109
		private int m_WorldCupTarget;

		// Token: 0x0400006E RID: 110
		public int m_Level;

		// Token: 0x0400006F RID: 111
		public bool m_top_tier;

		// Token: 0x04000070 RID: 112
		private int m_nationstartingfirstletter;

		// Token: 0x04000071 RID: 113
		private string m_isocountrycode;

		// Token: 0x04000072 RID: 114
		private string m_DefaultCommLang;

		// Token: 0x04000073 RID: 115
		private string m_LanguageName;

		// Token: 0x04000074 RID: 116
		private string m_LanguageShortName;

		// Token: 0x04000075 RID: 117
		private string m_LanguageAbbreviation;

		// Token: 0x04000076 RID: 118
		private Team m_NationalTeam;

		// Token: 0x04000077 RID: 119
		private int m_NationalTeamId;

		// Token: 0x020000A8 RID: 168
		public enum EConfederation
		{
			// Token: 0x04001237 RID: 4663
			None = 1,
			// Token: 0x04001238 RID: 4664
			Europe,
			// Token: 0x04001239 RID: 4665
			Africa,
			// Token: 0x0400123A RID: 4666
			South_America,
			// Token: 0x0400123B RID: 4667
			Asia,
			// Token: 0x0400123C RID: 4668
			Oceania,
			// Token: 0x0400123D RID: 4669
			North_America
		}
	}
}
