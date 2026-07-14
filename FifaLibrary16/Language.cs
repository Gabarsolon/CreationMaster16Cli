using System;
using System.Collections.Generic;

namespace FifaLibrary
{
	// Token: 0x02000051 RID: 81
	public class Language : Dictionary<int, string>
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x0002885C File Offset: 0x00026A5C
		public Language(Table langTable)
		{
			this.m_LangTable = langTable;
			this.m_Conventional = new Dictionary<int, string>();
			this.Load(this.m_LangTable);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00028884 File Offset: 0x00026A84
		public void Load(Table langTable)
		{
			base.Clear();
			this.m_Conventional.Clear();
			for (int i = 0; i < langTable.NRecords; i++)
			{
				Record record = langTable.Records[i];
				int num = record.IntField[FI.language_hashid];
				if (!base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.language_sourcetext];
					base.Add(num, text);
					text = record.CompressedString[FI.language_stringid];
					this.m_Conventional.Add(num, text);
				}
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00028904 File Offset: 0x00026B04
		public void Save(Table langTable)
		{
			langTable.ResizeRecords(base.Count);
			langTable.NValidRecords = base.Count;
			int num = 0;
			foreach (KeyValuePair<int, string> keyValuePair in this)
			{
				Record record = langTable.Records[num];
				num++;
				record.IntField[FI.language_hashid] = keyValuePair.Key;
				string empty;
				if (!this.m_Conventional.TryGetValue(keyValuePair.Key, out empty))
				{
					empty = string.Empty;
				}
				if (keyValuePair.Value != null)
				{
					record.CompressedString[FI.language_sourcetext] = keyValuePair.Value;
				}
				else
				{
					record.CompressedString[FI.language_sourcetext] = string.Empty;
				}
				record.CompressedString[FI.language_stringid] = empty;
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000289EC File Offset: 0x00026BEC
		public uint GetTournamentHash(int assetId, Language.ETournamentStringType stringType)
		{
			return FifaUtil.ComputeLanguageHash(this.GetTournamentConventionalString(assetId, stringType));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000289FC File Offset: 0x00026BFC
		public string GetTournamentConventionalString(int assetId, Language.ETournamentStringType stringType)
		{
			string text;
			if (stringType != Language.ETournamentStringType.Full)
			{
				if (stringType != Language.ETournamentStringType.Abbr15)
				{
					return null;
				}
				text = "TrophyName_Abbr15_";
			}
			else
			{
				text = "TrophyName_";
			}
			return text + assetId.ToString();
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00028A34 File Offset: 0x00026C34
		public string GetTournamentString(int assetId, Language.ETournamentStringType stringType)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(tournamentConventionalString);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00028A5C File Offset: 0x00026C5C
		public void SetTournamentString(int assetId, Language.ETournamentStringType stringType, string name)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return;
			}
			this.SetString(tournamentConventionalString, name);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00028A80 File Offset: 0x00026C80
		public void RemoveTournamentString(int assetId, Language.ETournamentStringType stringType)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return;
			}
			this.RemoveString(tournamentConventionalString);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00028AA1 File Offset: 0x00026CA1
		public uint GetFormationtHash(int formationFullNameId)
		{
			return FifaUtil.ComputeLanguageHash(this.GetFormationConventionalString(formationFullNameId));
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00028AAF File Offset: 0x00026CAF
		public string GetFormationConventionalString(int formationFullNameId)
		{
			return "Formation_FullName_" + formationFullNameId.ToString();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00028AC4 File Offset: 0x00026CC4
		public int GetFreeFormationFullNameId()
		{
			for (int i = 0; i < 31; i++)
			{
				if (this.GetFormationString(i) == null)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00028AEC File Offset: 0x00026CEC
		public int SearchFormationFullName(string fullName)
		{
			for (int i = 0; i < 31; i++)
			{
				if (this.GetFormationString(i) == fullName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00028B18 File Offset: 0x00026D18
		public string GetFormationString(int formationFullNameId)
		{
			if (formationFullNameId < 0)
			{
				return null;
			}
			string formationConventionalString = this.GetFormationConventionalString(formationFullNameId);
			if (formationConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(formationConventionalString);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00028B44 File Offset: 0x00026D44
		public void SetFormationString(int formationFullNameId, string name)
		{
			string formationConventionalString = this.GetFormationConventionalString(formationFullNameId);
			if (formationConventionalString == null)
			{
				return;
			}
			this.SetString(formationConventionalString, name);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00028B68 File Offset: 0x00026D68
		public void RemoveFormationString(int assetId)
		{
			string formationConventionalString = this.GetFormationConventionalString(assetId);
			if (formationConventionalString == null)
			{
				return;
			}
			this.RemoveString(formationConventionalString);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00028B88 File Offset: 0x00026D88
		public uint GetLeagueHash(int assetId, Language.ELeagueStringType stringType)
		{
			return FifaUtil.ComputeLanguageHash(this.GetLeagueConventionalString(assetId, stringType));
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00028B98 File Offset: 0x00026D98
		private string GetLeagueConventionalString(int assetId, Language.ELeagueStringType stringType)
		{
			string text;
			if (stringType != Language.ELeagueStringType.Full)
			{
				if (stringType != Language.ELeagueStringType.Abbr15)
				{
					return null;
				}
				text = "LeagueName_Abbr15_";
			}
			else
			{
				text = "LeagueName_";
			}
			return text + assetId.ToString();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00028BD0 File Offset: 0x00026DD0
		public string GetLeagueString(int assetId, Language.ELeagueStringType stringType)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(leagueConventionalString);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00028BF8 File Offset: 0x00026DF8
		public void SetLeagueString(int assetId, Language.ELeagueStringType stringType, string name)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return;
			}
			this.SetString(leagueConventionalString, name);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00028C1C File Offset: 0x00026E1C
		public void RemoveLeagueString(int assetId, Language.ELeagueStringType stringType)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return;
			}
			this.RemoveString(leagueConventionalString);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00028C3D File Offset: 0x00026E3D
		public uint GetStadiumHash(int id)
		{
			return FifaUtil.ComputeLanguageHash(this.GetStadiumConventionalString(id));
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00028C4B File Offset: 0x00026E4B
		private string GetStadiumConventionalString(int stadiumId)
		{
			return "StadiumName_" + stadiumId.ToString();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00028C60 File Offset: 0x00026E60
		public string GetStadiumName(int stadiumId)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			return this.GetString(stadiumConventionalString);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00028C7C File Offset: 0x00026E7C
		public void SetStadiumName(int stadiumId, string stadiumName)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			this.SetString(stadiumConventionalString, stadiumName);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00028C9C File Offset: 0x00026E9C
		public void RemoveStadiumName(int stadiumId)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			this.RemoveString(stadiumConventionalString);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00028CB8 File Offset: 0x00026EB8
		public uint GetBallHash(int id)
		{
			return FifaUtil.ComputeLanguageHash(this.GetBallConventionalString(id, true));
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00028CC8 File Offset: 0x00026EC8
		private string GetBallConventionalString(int ballId, bool isGeneric)
		{
			string text;
			if (isGeneric)
			{
				text = "ballname_" + ballId.ToString();
			}
			else
			{
				text = "BallName_" + ballId.ToString();
			}
			return text;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00028D00 File Offset: 0x00026F00
		public string GetBallName(int ballId, out bool isGeneric)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, true);
			int num = (int)FifaUtil.ComputeLanguageHash(ballConventionalString);
			string @string = this.GetString(num);
			string conventionalString = this.GetConventionalString(num);
			isGeneric = conventionalString == ballConventionalString;
			return @string;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00028D38 File Offset: 0x00026F38
		public void SetBallName(int ballId, string ballName, bool isGeneric)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, isGeneric);
			this.SetString(ballConventionalString, ballName);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00028D58 File Offset: 0x00026F58
		public void RemoveBallName(int ballId)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, true);
			this.RemoveString(ballConventionalString);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00028D75 File Offset: 0x00026F75
		public uint GetShoesHash(int id)
		{
			return FifaUtil.ComputeLanguageHash(this.GetShoesConventionalString(id));
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00028D83 File Offset: 0x00026F83
		private string GetShoesConventionalString(int ShoesId)
		{
			return "CreatePlayerBoot_" + ShoesId.ToString();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00028D98 File Offset: 0x00026F98
		public string GetShoesName(int ShoesId)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(this.GetShoesConventionalString(ShoesId));
			return this.GetString(num);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00028DBC File Offset: 0x00026FBC
		public void SetShoesName(int ShoesId, string ShoesName)
		{
			string shoesConventionalString = this.GetShoesConventionalString(ShoesId);
			this.SetString(shoesConventionalString, ShoesName);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00028DDC File Offset: 0x00026FDC
		public void RemoveShoesName(int ShoesId)
		{
			string shoesConventionalString = this.GetShoesConventionalString(ShoesId);
			this.RemoveString(shoesConventionalString);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00028DF8 File Offset: 0x00026FF8
		public uint GetCountryHash(int countryId, Language.ECountryStringType stringType)
		{
			return FifaUtil.ComputeLanguageHash(this.GetCountryConventionalString(countryId, stringType));
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00028E08 File Offset: 0x00027008
		public string GetCountryConventionalString(int countryId, Language.ECountryStringType stringType)
		{
			string text;
			switch (stringType)
			{
			case Language.ECountryStringType.Full:
				text = "NationName_" + countryId.ToString();
				break;
			case Language.ECountryStringType.Abbr3:
				text = "nationname_abbr3_" + countryId.ToString();
				break;
			case Language.ECountryStringType.Abbr15:
				text = "NationName_" + countryId.ToString() + "_abbr_15";
				break;
			default:
				return null;
			}
			return text;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00028E70 File Offset: 0x00027070
		public string GetCountryString(int countryId, Language.ECountryStringType stringType)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId, stringType);
			return this.GetString(countryConventionalString);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00028E90 File Offset: 0x00027090
		public void SetCountryString(int countryId, Language.ECountryStringType stringType, string countryName)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId, stringType);
			this.SetString(countryConventionalString, countryName);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00028EB0 File Offset: 0x000270B0
		public void RemoveCountryStrings(int countryId)
		{
			string text = this.GetCountryConventionalString(countryId, Language.ECountryStringType.Abbr15);
			this.RemoveString(text);
			text = this.GetCountryConventionalString(countryId, Language.ECountryStringType.Abbr3);
			this.RemoveString(text);
			text = this.GetCountryConventionalString(countryId, Language.ECountryStringType.Full);
			this.RemoveString(text);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00028EF0 File Offset: 0x000270F0
		public void RemoveCountryString(int countryId, Language.ECountryStringType stringType)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId, stringType);
			this.RemoveString(countryConventionalString);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00028F0D File Offset: 0x0002710D
		private string GetRoleLongConventionalString(int roleId)
		{
			return "SoccerFormationPosFull_" + roleId.ToString();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00028F20 File Offset: 0x00027120
		private string GetRoleShortConventionalString(int roleId)
		{
			string text = "SoccerFormationPos_Abbr4_";
			switch (roleId)
			{
			case 0:
				text += "GK";
				break;
			case 1:
				text += "SW";
				break;
			case 2:
				text += "RWB";
				break;
			case 3:
				text += "RB";
				break;
			case 4:
				text += "RCB";
				break;
			case 5:
				text += "CB";
				break;
			case 6:
				text += "LCB";
				break;
			case 7:
				text += "LB";
				break;
			case 8:
				text += "LWB";
				break;
			case 9:
				text += "RDM";
				break;
			case 10:
				text += "CDM";
				break;
			case 11:
				text += "LDM";
				break;
			case 12:
				text += "RM";
				break;
			case 13:
				text += "RCM";
				break;
			case 14:
				text += "CM";
				break;
			case 15:
				text += "LCM";
				break;
			case 16:
				text += "LM";
				break;
			case 17:
				text += "RAM";
				break;
			case 18:
				text += "CAM";
				break;
			case 19:
				text += "LAM";
				break;
			case 20:
				text += "RF";
				break;
			case 21:
				text += "CF";
				break;
			case 22:
				text += "LF";
				break;
			case 23:
				text += "RW";
				break;
			case 24:
				text += "RS";
				break;
			case 25:
				text += "ST";
				break;
			case 26:
				text += "LS";
				break;
			case 27:
				text += "LW";
				break;
			default:
				return null;
			}
			return text;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00029174 File Offset: 0x00027374
		public string GetRoleShortString(int roleId)
		{
			string text;
			if (roleId != 28)
			{
				if (roleId != 29)
				{
					text = this.GetRoleShortConventionalString(roleId);
				}
				else
				{
					text = "Reserve";
				}
			}
			else
			{
				text = "Substitute";
			}
			string text2 = this.GetString(text);
			if (text2 == null || text2 == string.Empty)
			{
				text2 = text;
			}
			return text2;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000291C4 File Offset: 0x000273C4
		public void SetRoleShortString(int roleId, string roleShortName)
		{
			string roleShortConventionalString = this.GetRoleShortConventionalString(roleId);
			this.SetString(roleShortConventionalString, roleShortName);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000291E4 File Offset: 0x000273E4
		public string GetRoleLongString(int roleId)
		{
			string roleLongConventionalString = this.GetRoleLongConventionalString(roleId);
			return this.GetString(roleLongConventionalString);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00029200 File Offset: 0x00027400
		public void SetRoleLongString(int roleId, string roleLongName)
		{
			string roleLongConventionalString = this.GetRoleLongConventionalString(roleId);
			this.SetString(roleLongConventionalString, roleLongName);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0002921D File Offset: 0x0002741D
		public uint GetSponsorDescriptionHash(int id)
		{
			return FifaUtil.ComputeLanguageHash(this.GetSponsorDescrConventionalString(id));
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002922B File Offset: 0x0002742B
		public uint GetSponsorNameHash(int id)
		{
			return FifaUtil.ComputeLanguageHash(this.GetSponsorNameConventionalString(id));
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00029239 File Offset: 0x00027439
		private string GetSponsorNameConventionalString(int sponsorId)
		{
			return "mm_Sponsor" + sponsorId.ToString();
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0002924C File Offset: 0x0002744C
		private string GetSponsorDescrConventionalString(int sponsorId)
		{
			return "mm_SponsorBio" + sponsorId.ToString();
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00029260 File Offset: 0x00027460
		public string GetSponsorName(int sponsorId)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			return this.GetString(sponsorNameConventionalString);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0002927C File Offset: 0x0002747C
		public string GetSponsorDescription(int sponsorId)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			return this.GetString(sponsorDescrConventionalString);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00029298 File Offset: 0x00027498
		public void SetSponsorName(int sponsorId, string sponsorName)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			this.SetString(sponsorNameConventionalString, sponsorName);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000292B8 File Offset: 0x000274B8
		public void SetSponsorDescription(int sponsorId, string sponsorDesc)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			this.SetString(sponsorDescrConventionalString, sponsorDesc);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000292D8 File Offset: 0x000274D8
		public void RemoveSponsorName(int sponsorId)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			this.RemoveString(sponsorNameConventionalString);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000292F4 File Offset: 0x000274F4
		public void RemoveSponsorDescription(int sponsorId)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			this.RemoveString(sponsorDescrConventionalString);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00029310 File Offset: 0x00027510
		public uint GetTeamHash(int teamId, Language.ETeamStringType stringType)
		{
			return FifaUtil.ComputeLanguageHash(this.GetTeamConventionalString(teamId, stringType));
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00029320 File Offset: 0x00027520
		public string GetTeamConventionalString(int teamId, Language.ETeamStringType stringType)
		{
			string text;
			switch (stringType)
			{
			case Language.ETeamStringType.Full:
				text = "TeamName_";
				break;
			case Language.ETeamStringType.Abbr3:
				text = "TeamName_Abbr3_";
				break;
			case Language.ETeamStringType.Abbr10:
				text = "TeamName_Abbr10_";
				break;
			case Language.ETeamStringType.Abbr15:
				text = "TeamName_Abbr15_";
				break;
			case Language.ETeamStringType.Abbr7:
				text = "TeamName_Abbr7_";
				break;
			default:
				return null;
			}
			return text + teamId.ToString();
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00029384 File Offset: 0x00027584
		public string GetTeamString(int teamId, Language.ETeamStringType stringType)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, stringType);
			return this.GetString(teamConventionalString);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000293A4 File Offset: 0x000275A4
		public void SetTeamString(int teamId, Language.ETeamStringType stringType, string teamName)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, stringType);
			this.SetString(teamConventionalString, teamName);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000293C4 File Offset: 0x000275C4
		public void RemoveTeamStrings(int teamId)
		{
			string text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr10);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr15);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr3);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr7);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Full);
			this.RemoveString(text);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00029424 File Offset: 0x00027624
		public void RemoveTeamString(int teamId, Language.ETeamStringType stringType)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr10);
			this.RemoveString(teamConventionalString);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00029444 File Offset: 0x00027644
		public string GetString(int key)
		{
			string text;
			if (base.TryGetValue(key, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00029460 File Offset: 0x00027660
		public string GetConventionalString(int key)
		{
			string text;
			if (this.m_Conventional.TryGetValue(key, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00029480 File Offset: 0x00027680
		public string GetString(string stringConventional)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			string text;
			if (base.TryGetValue(num, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000294A4 File Offset: 0x000276A4
		public void SetString(string stringConventional, string stringValue)
		{
			if (stringValue == null || stringValue == string.Empty)
			{
				return;
			}
			if (stringConventional == null || stringConventional == string.Empty)
			{
				return;
			}
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			this.SetString(num, stringConventional, stringValue);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000294E4 File Offset: 0x000276E4
		public void SetString(int key, string stringConventional, string stringValue)
		{
			if (base.ContainsKey(key))
			{
				base.Remove(key);
			}
			base.Add(key, stringValue);
			if (this.m_Conventional.ContainsKey(key))
			{
				this.m_Conventional.Remove(key);
			}
			this.m_Conventional.Add(key, stringConventional);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00029532 File Offset: 0x00027732
		public void RemoveString(int key)
		{
			if (base.ContainsKey(key))
			{
				base.Remove(key);
			}
			if (this.m_Conventional.ContainsKey(key))
			{
				this.m_Conventional.Remove(key);
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00029560 File Offset: 0x00027760
		public void RemoveString(string stringConventional)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			this.RemoveString(num);
		}

		// Token: 0x04000E65 RID: 3685
		private Dictionary<int, string> m_Conventional;

		// Token: 0x04000E66 RID: 3686
		private Table m_LangTable;

		// Token: 0x020000AF RID: 175
		public enum ETournamentStringType
		{
			// Token: 0x04001252 RID: 4690
			Full,
			// Token: 0x04001253 RID: 4691
			Abbr15
		}

		// Token: 0x020000B0 RID: 176
		public enum ELeagueStringType
		{
			// Token: 0x04001255 RID: 4693
			Full,
			// Token: 0x04001256 RID: 4694
			Abbr15
		}

		// Token: 0x020000B1 RID: 177
		public enum ECountryStringType
		{
			// Token: 0x04001258 RID: 4696
			Full,
			// Token: 0x04001259 RID: 4697
			Abbr3,
			// Token: 0x0400125A RID: 4698
			Abbr15
		}

		// Token: 0x020000B2 RID: 178
		public enum ETeamStringType
		{
			// Token: 0x0400125C RID: 4700
			Full,
			// Token: 0x0400125D RID: 4701
			Abbr3,
			// Token: 0x0400125E RID: 4702
			Abbr7 = 4,
			// Token: 0x0400125F RID: 4703
			Abbr10 = 2,
			// Token: 0x04001260 RID: 4704
			Abbr15
		}
	}
}
