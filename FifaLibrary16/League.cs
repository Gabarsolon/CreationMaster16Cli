using System;
using System.Collections;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000053 RID: 83
	public class League : IdObject
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0002957B File Offset: 0x0002777B
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00029583 File Offset: 0x00027783
		public string leaguename
		{
			get
			{
				return this.m_leaguename;
			}
			set
			{
				this.m_leaguename = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0002958C File Offset: 0x0002778C
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00029594 File Offset: 0x00027794
		public int level
		{
			get
			{
				return this.m_level;
			}
			set
			{
				this.m_level = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0002959D File Offset: 0x0002779D
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x000295A5 File Offset: 0x000277A5
		public int countryid
		{
			get
			{
				return this.m_countryid;
			}
			set
			{
				this.m_countryid = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000295AE File Offset: 0x000277AE
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x000295B6 File Offset: 0x000277B6
		public ELeaguePrestige Prestige
		{
			get
			{
				return this.m_Prestige;
			}
			set
			{
				this.m_Prestige = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000295BF File Offset: 0x000277BF
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x000295C7 File Offset: 0x000277C7
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				if (this.m_Country != null)
				{
					this.m_countryid = this.m_Country.Id;
					return;
				}
				this.m_countryid = 0;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000295F1 File Offset: 0x000277F1
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000295F9 File Offset: 0x000277F9
		public int[] boardoutcomes
		{
			get
			{
				return this.m_boardoutcomes;
			}
			set
			{
				this.m_boardoutcomes = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00029602 File Offset: 0x00027802
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0002960A File Offset: 0x0002780A
		public bool iswithintransferwindow
		{
			get
			{
				return this.m_iswithintransferwindow;
			}
			set
			{
				this.m_iswithintransferwindow = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00029613 File Offset: 0x00027813
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0002961B File Offset: 0x0002781B
		public int leaguetimeslice
		{
			get
			{
				return this.leaguetimeslice;
			}
			set
			{
				this.leaguetimeslice = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00029624 File Offset: 0x00027824
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0002962C File Offset: 0x0002782C
		public string ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00029635 File Offset: 0x00027835
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0002963D File Offset: 0x0002783D
		public string LongName
		{
			get
			{
				return this.m_LongName;
			}
			set
			{
				this.m_LongName = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00029646 File Offset: 0x00027846
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x0002964E File Offset: 0x0002784E
		public TeamList PlayingTeams
		{
			get
			{
				return this.m_PlayingTeams;
			}
			set
			{
				this.m_PlayingTeams = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00029657 File Offset: 0x00027857
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x0002965F File Offset: 0x0002785F
		public Trophy Trophy
		{
			get
			{
				return this.m_Trophy;
			}
			set
			{
				this.m_Trophy = value;
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00029668 File Offset: 0x00027868
		public override string ToString()
		{
			if (this.m_ShortName != null && this.m_ShortName != string.Empty)
			{
				return this.m_ShortName;
			}
			if (this.m_leaguename != null)
			{
				return this.m_leaguename;
			}
			return string.Empty;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0002957B File Offset: 0x0002777B
		public string DatabaseString()
		{
			return this.m_leaguename;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000296A0 File Offset: 0x000278A0
		public League(int leagueid)
			: base(leagueid)
		{
			base.Id = leagueid;
			this.m_leaguename = "New League";
			this.m_level = 1;
			this.m_Prestige = ELeaguePrestige.Undefined;
			this.m_countryid = 0;
			this.LinkCountry(FifaEnvironment.Countries);
			this.m_iswithintransferwindow = false;
			this.m_leaguetimeslice = 0;
			this.m_ShortName = "Short League Name";
			this.m_LongName = "Long League Name";
			this.m_boardoutcomes[0] = 0;
			this.m_boardoutcomes[1] = 0;
			this.m_boardoutcomes[2] = 0;
			this.m_boardoutcomes[3] = 0;
			this.m_boardoutcomes[4] = 0;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0002974F File Offset: 0x0002794F
		public League(Record r)
			: base(r.IntField[FI.leagues_leagueid])
		{
			this.Load(r);
			this.FillFromLanguage();
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00029788 File Offset: 0x00027988
		public void Load(Record r)
		{
			this.m_leaguename = r.StringField[FI.leagues_leaguename];
			this.m_level = r.GetAndCheckIntField(FI.leagues_level);
			this.m_countryid = r.GetAndCheckIntField(FI.leagues_countryid);
			this.m_iswithintransferwindow = r.GetAndCheckIntField(FI.leagues_iswithintransferwindow) != 0;
			this.m_leaguetimeslice = r.GetAndCheckIntField(FI.leagues_leaguetimeslice);
			this.m_Prestige = ELeaguePrestige.Undefined;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000297F6 File Offset: 0x000279F6
		public static League GetDefaultLeague()
		{
			return FifaEnvironment.Leagues.SearchLeague(76);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00029804 File Offset: 0x00027A04
		public static int GetDefaultLeagueId()
		{
			return 76;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00029808 File Offset: 0x00027A08
		public void LinkTeam(int teamid)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			Team team = (Team)FifaEnvironment.Teams.SearchId(teamid);
			if (team == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(5022, teamid);
				return;
			}
			this.m_PlayingTeams.Add(team);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00029850 File Offset: 0x00027A50
		public void LinkTeam(Team team)
		{
			if (team == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(5022, team.Id);
				return;
			}
			this.m_PlayingTeams.Add(team);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00029879 File Offset: 0x00027A79
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_countryid);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00029898 File Offset: 0x00027A98
		public void FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				this.m_ShortName = FifaEnvironment.Language.GetLeagueString(base.Id, Language.ELeagueStringType.Abbr15);
				this.m_LongName = FifaEnvironment.Language.GetLeagueString(base.Id, Language.ELeagueStringType.Full);
				if (this.m_LongName == null || this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
					return;
				}
			}
			else
			{
				this.m_ShortName = string.Empty;
				this.m_LongName = string.Empty;
				if (this.m_LongName == null || this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00029940 File Offset: 0x00027B40
		public void FillFromBoardOutcomes(Record r)
		{
			this.m_boardoutcomes[0] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome1);
			this.m_boardoutcomes[1] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome2);
			this.m_boardoutcomes[2] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome3);
			this.m_boardoutcomes[3] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome4);
			this.m_boardoutcomes[4] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome5);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000299AC File Offset: 0x00027BAC
		public void SaveBoardOutcomes(Record r)
		{
			r.IntField[FI.career_boardoutcomes_leagueid] = base.Id;
			r.IntField[FI.career_boardoutcomes_outcome1] = this.m_boardoutcomes[0];
			r.IntField[FI.career_boardoutcomes_outcome2] = this.m_boardoutcomes[1];
			r.IntField[FI.career_boardoutcomes_outcome3] = this.m_boardoutcomes[2];
			r.IntField[FI.career_boardoutcomes_outcome4] = this.m_boardoutcomes[3];
			r.IntField[FI.career_boardoutcomes_outcome5] = this.m_boardoutcomes[4];
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00029A30 File Offset: 0x00027C30
		public void AddTeam(Team team)
		{
			if (team == null)
			{
				return;
			}
			if (team.League != null && team.League != this)
			{
				team.League.RemoveTeam(team);
			}
			this.m_PlayingTeams.InsertId(team);
			team.League = this;
			team.PrevLeague = this;
			team.currenttableposition = this.m_PlayingTeams.Count;
			team.previousyeartableposition = this.m_PlayingTeams.Count;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00029A9B File Offset: 0x00027C9B
		public void RemoveTeam(Team team)
		{
			if (team == null)
			{
				return;
			}
			if (team.League == this)
			{
				team.League = null;
			}
			this.m_PlayingTeams.RemoveId(team);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00029AC0 File Offset: 0x00027CC0
		public void RemoveAllTeams()
		{
			while (this.m_PlayingTeams.Count > 0)
			{
				Team team = (Team)this.m_PlayingTeams[0];
				this.RemoveTeam(team);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00029AF6 File Offset: 0x00027CF6
		public static string ReplayLogoTextureFileName(int id)
		{
			return "data/sceneassets/leaguelogo/leaguelogo_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00029B0E File Offset: 0x00027D0E
		public string ReplayLogoTextureFileName()
		{
			return League.ReplayLogoTextureFileName(base.Id);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00029B1B File Offset: 0x00027D1B
		public string ReplayLogoTexturesTemplateFileName()
		{
			return "data/sceneassets/leaguelogo/leaguelogo_#_textures.rx3";
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00029B22 File Offset: 0x00027D22
		public static Bitmap[] GetReplayLogoTextures(int leagueId)
		{
			return FifaEnvironment.GetBmpsFromRx3(League.ReplayLogoTextureFileName(leagueId));
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00029B2F File Offset: 0x00027D2F
		public Bitmap[] GetReplayLogoTextures()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.ReplayLogoTextureFileName());
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00029B3C File Offset: 0x00027D3C
		public bool SetReplayLogoTextures(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.ReplayLogoTexturesTemplateFileName(), base.Id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00029B51 File Offset: 0x00027D51
		public bool DeleteReplayLogoTextures()
		{
			return FifaEnvironment.DeleteFromZdata(this.ReplayLogoTextureFileName());
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00029B5E File Offset: 0x00027D5E
		public static string ReplayLogoModelFileName(int id)
		{
			return "data/sceneassets/leaguelogo/leaguelogo_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00029B76 File Offset: 0x00027D76
		public string ReplayLogoModelTemplateFileName()
		{
			return "data/sceneassets/leaguelogo/leaguelogo_#.rx3";
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00029B7D File Offset: 0x00027D7D
		public string ReplayLogoModelFileName()
		{
			return League.ReplayLogoModelFileName(base.Id);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00029B8A File Offset: 0x00027D8A
		public Rx3File GetReplayLogoModel()
		{
			return FifaEnvironment.GetRx3FromZdata(this.ReplayLogoModelFileName());
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00029B97 File Offset: 0x00027D97
		public static Rx3File GetReplayLogoModel(int id)
		{
			return FifaEnvironment.GetRx3FromZdata(League.ReplayLogoModelFileName(id));
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00029BA4 File Offset: 0x00027DA4
		public bool SetReplayLogoModel(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ReplayLogoModelFileName(), false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00029BB4 File Offset: 0x00027DB4
		public bool DeleteReplayLogoModel()
		{
			return FifaEnvironment.DeleteFromZdata(this.ReplayLogoModelFileName());
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00029BC4 File Offset: 0x00027DC4
		public bool IsReplayLogoPatched()
		{
			bool flag = FifaEnvironment.IsPatched(this.ReplayLogoTextureFileName());
			return FifaEnvironment.IsPatched(this.ReplayLogoTextureFileName()) || flag;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00029BEC File Offset: 0x00027DEC
		public bool CreateReplayLogoPatch()
		{
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(FifaEnvironment.LaunchDir + "\\Templates\\" + this.ReplayLogoTexturesTemplateFileName(), this.ReplayLogoTextureFileName(), false, ECompressionMode.None);
			return FifaEnvironment.ImportFileIntoZdataAs(FifaEnvironment.LaunchDir + "\\Templates\\" + this.ReplayLogoModelTemplateFileName(), this.ReplayLogoModelFileName(), false, ECompressionMode.None) && flag;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00029C40 File Offset: 0x00027E40
		public bool RemoveReplayLogoPatch()
		{
			bool flag = FifaEnvironment.DeleteFromZdata(this.ReplayLogoTextureFileName());
			return FifaEnvironment.DeleteFromZdata(this.ReplayLogoModelFileName()) && flag;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00029C66 File Offset: 0x00027E66
		public static string AnimLogoDdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/league/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/league/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00029C9A File Offset: 0x00027E9A
		public static string AnimLogoDdsFileName(int id)
		{
			return League.AnimLogoDdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00029CA7 File Offset: 0x00027EA7
		public string AnimLogoTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/league/l#.dds";
			}
			return "data/ui/imgassets/league/light/l#.dds";
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00029CBD File Offset: 0x00027EBD
		public string AnimLogoDdsFileName()
		{
			return League.AnimLogoDdsFileName(base.Id);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00029CCA File Offset: 0x00027ECA
		public Bitmap GetAnimLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.AnimLogoDdsFileName());
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00029CD7 File Offset: 0x00027ED7
		public bool SetAnimLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.AnimLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00029CF0 File Offset: 0x00027EF0
		public bool DeleteAnimLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.AnimLogoDdsFileName());
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00029CFD File Offset: 0x00027EFD
		public static string AnimLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/league/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00029D15 File Offset: 0x00027F15
		public string AnimLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/league/dark/l#.dds";
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00029D1C File Offset: 0x00027F1C
		public string AnimLogoDarkDdsFileName()
		{
			return League.AnimLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00029D29 File Offset: 0x00027F29
		public Bitmap GetAnimLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.AnimLogoDarkDdsFileName());
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00029D36 File Offset: 0x00027F36
		public bool SetAnimLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.AnimLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00029D4F File Offset: 0x00027F4F
		public bool DeleteAnimLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.AnimLogoDarkDdsFileName());
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00029D5C File Offset: 0x00027F5C
		public static string Logo512x128DdsFileName(int id)
		{
			if (FifaEnvironment.Year == 14)
			{
				return null;
			}
			return "data/ui/imgassets/league512x128/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00029D7F File Offset: 0x00027F7F
		public string Logo512x128TemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return null;
			}
			return "data/ui/imgassets/league512x128/light/l#.dds";
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00029D91 File Offset: 0x00027F91
		public string Logo512x128DdsFileName()
		{
			return League.Logo512x128DdsFileName(base.Id);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00029D9E File Offset: 0x00027F9E
		public Bitmap GetLogo512x128()
		{
			return FifaEnvironment.GetDdsArtasset(this.Logo512x128DdsFileName());
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00029DAB File Offset: 0x00027FAB
		public bool SetLogo512x128(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.Logo512x128TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00029DC4 File Offset: 0x00027FC4
		public bool DeleteLogo512x128()
		{
			return FifaEnvironment.DeleteFromZdata(this.Logo512x128DdsFileName());
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00029DD1 File Offset: 0x00027FD1
		public static string Logo512x128DarkDdsFileName(int id)
		{
			if (FifaEnvironment.Year == 14)
			{
				return null;
			}
			return "data/ui/imgassets/league512x128/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00029DF4 File Offset: 0x00027FF4
		public string Logo512x128DarkTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return null;
			}
			return "data/ui/imgassets/league512x128/dark/l#.dds";
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00029E06 File Offset: 0x00028006
		public string Logo512x128DarkDdsFileName()
		{
			return League.Logo512x128DarkDdsFileName(base.Id);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00029E13 File Offset: 0x00028013
		public Bitmap GetLogo512x128Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Logo512x128DarkDdsFileName());
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00029E20 File Offset: 0x00028020
		public bool SetLogo512x128Dark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.Logo512x128DarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00029E39 File Offset: 0x00028039
		public bool DeleteLogo512x128Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Logo512x128DarkDdsFileName());
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00029E46 File Offset: 0x00028046
		public static string TinyLogoDdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/leaguelogos_tiny/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/leaguelogos_tiny/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00029E7A File Offset: 0x0002807A
		public static string TinyLogoDdsFileName(int id)
		{
			return League.TinyLogoDdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00029E87 File Offset: 0x00028087
		public string TinyLogoTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/leaguelogos_tiny/l#.dds";
			}
			return "data/ui/imgassets/leaguelogos_tiny/light/l#.dds";
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00029E9D File Offset: 0x0002809D
		public string TinyLogoDdsFileName()
		{
			return League.TinyLogoDdsFileName(base.Id);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00029EAA File Offset: 0x000280AA
		public Bitmap GetTinyLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.TinyLogoDdsFileName());
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00029EB7 File Offset: 0x000280B7
		public bool SetTinyLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TinyLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00029ED0 File Offset: 0x000280D0
		public bool DeleteTinyLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.TinyLogoDdsFileName());
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00029EDD File Offset: 0x000280DD
		public static string TinyLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_tiny/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00029EF5 File Offset: 0x000280F5
		public string TinyLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_tiny/dark/l#.dds";
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00029EFC File Offset: 0x000280FC
		public string TinyLogoDarkDdsFileName()
		{
			return League.TinyLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00029F09 File Offset: 0x00028109
		public Bitmap GetTinyLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.TinyLogoDarkDdsFileName());
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00029F16 File Offset: 0x00028116
		public bool SetTinyLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TinyLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00029F2F File Offset: 0x0002812F
		public bool DeleteTinyLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.TinyLogoDarkDdsFileName());
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00029F3C File Offset: 0x0002813C
		public static string SmallLogoDdsFileName(int id)
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/leaguelogos_sm/l" + id.ToString() + ".dds";
			}
			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00029F5F File Offset: 0x0002815F
		public string SmallLogoTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/leaguelogos_sm/l#.dds";
			}
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00029F71 File Offset: 0x00028171
		public string SmallLogoDdsFileName()
		{
			return League.SmallLogoDdsFileName(base.Id);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00029F7E File Offset: 0x0002817E
		public Bitmap GetSmallLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.SmallLogoDdsFileName());
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00029F8B File Offset: 0x0002818B
		public bool SetSmallLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.SmallLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00029FA4 File Offset: 0x000281A4
		public bool DeleteSmallLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.SmallLogoDdsFileName());
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00029FB1 File Offset: 0x000281B1
		public static string SmallLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_sm/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00029FC9 File Offset: 0x000281C9
		public string SmallLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_sm/dark/l#.dds";
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00029FD0 File Offset: 0x000281D0
		public string SmallLogoDarkDdsFileName()
		{
			return League.SmallLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00029FDD File Offset: 0x000281DD
		public Bitmap GetSmallLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.SmallLogoDarkDdsFileName());
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00029FEA File Offset: 0x000281EA
		public bool SetSmallLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.SmallLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0002A003 File Offset: 0x00028203
		public bool DeleteSmallLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.SmallLogoDarkDdsFileName());
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0002A010 File Offset: 0x00028210
		public void SaveLeague(Record r)
		{
			r.IntField[FI.leagues_leagueid] = base.Id;
			r.StringField[FI.leagues_leaguename] = this.m_leaguename;
			r.IntField[FI.leagues_level] = this.m_level;
			r.IntField[FI.leagues_countryid] = this.m_countryid;
			r.IntField[FI.leagues_leaguetimeslice] = this.m_leaguetimeslice;
			r.IntField[FI.leagues_iswithintransferwindow] = (this.m_iswithintransferwindow ? 1 : 0);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0002A090 File Offset: 0x00028290
		public void SaveTeamLink(Record r, Team team, int artificialkey)
		{
			r.IntField[FI.leagueteamlinks_artificialkey] = artificialkey;
			r.IntField[FI.leagueteamlinks_leagueid] = base.Id;
			r.IntField[FI.leagueteamlinks_teamid] = team.Id;
			if (team.PrevLeague != null)
			{
				r.IntField[FI.leagueteamlinks_prevleagueid] = team.PrevLeague.Id;
				r.IntField[FI.leagueteamlinks_champion] = (team.IsChampion ? 1 : 0);
			}
			else
			{
				r.IntField[FI.leagueteamlinks_prevleagueid] = base.Id;
				r.IntField[FI.leagueteamlinks_champion] = 0;
			}
			r.IntField[FI.leagueteamlinks_previousyeartableposition] = team.previousyeartableposition;
			r.IntField[FI.leagueteamlinks_currenttableposition] = team.currenttableposition;
			r.IntField[FI.leagueteamlinks_teamshortform] = team.teamshortform;
			r.IntField[FI.leagueteamlinks_teamlongform] = team.teamlongform;
			r.IntField[FI.leagueteamlinks_teamform] = team.teamform;
			r.IntField[FI.leagueteamlinks_hasachievedobjective] = (team.hasachievedobjective ? 1 : 0);
			r.IntField[FI.leagueteamlinks_yettowin] = (team.yettowin ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenallcomps] = (team.unbeatenallcomps ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenaway] = (team.unbeatenaway ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenhome] = (team.unbeatenhome ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenleague] = (team.unbeatenleague ? 1 : 0);
			r.IntField[FI.leagueteamlinks_highestpossible] = team.highestpossible;
			r.IntField[FI.leagueteamlinks_highestprobable] = team.highestprobable;
			r.IntField[FI.leagueteamlinks_nummatchesplayed] = team.nummatchesplayed;
			r.IntField[FI.leagueteamlinks_gapresult] = team.gapresult;
			r.IntField[FI.leagueteamlinks_grouping] = team.grouping;
			r.IntField[FI.leagueteamlinks_objective] = team.objective;
			r.IntField[FI.leagueteamlinks_actualvsexpectations] = team.actualvsexpectations;
			r.IntField[FI.leagueteamlinks_lastgameresult] = team.lastgameresult;
			r.IntField[FI.leagueteamlinks_homega] = team.homega;
			r.IntField[FI.leagueteamlinks_homegf] = team.homegf;
			r.IntField[FI.leagueteamlinks_points] = team.points;
			r.IntField[FI.leagueteamlinks_awayga] = team.awayga;
			r.IntField[FI.leagueteamlinks_homewins] = team.secondarytable;
			r.IntField[FI.leagueteamlinks_homewins] = team.homewins;
			r.IntField[FI.leagueteamlinks_awaywins] = team.awaywins;
			r.IntField[FI.leagueteamlinks_homelosses] = team.homelosses;
			r.IntField[FI.leagueteamlinks_awaylosses] = team.awaylosses;
			r.IntField[FI.leagueteamlinks_awaydraws] = team.awaydraws;
			r.IntField[FI.leagueteamlinks_homedraws] = team.homedraws;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void SynchronizeLeague()
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0002A368 File Offset: 0x00028568
		public bool ContainsNationalTeams()
		{
			IEnumerator enumerator = this.m_PlayingTeams.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if (((Team)enumerator.Current).NationalTeam)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000E75 RID: 3701
		private string m_leaguename;

		// Token: 0x04000E76 RID: 3702
		private int m_level;

		// Token: 0x04000E77 RID: 3703
		private int m_countryid;

		// Token: 0x04000E78 RID: 3704
		private ELeaguePrestige m_Prestige;

		// Token: 0x04000E79 RID: 3705
		private Country m_Country;

		// Token: 0x04000E7A RID: 3706
		private int[] m_boardoutcomes = new int[5];

		// Token: 0x04000E7B RID: 3707
		private bool m_iswithintransferwindow;

		// Token: 0x04000E7C RID: 3708
		private int m_leaguetimeslice;

		// Token: 0x04000E7D RID: 3709
		private string m_ShortName;

		// Token: 0x04000E7E RID: 3710
		private string m_LongName;

		// Token: 0x04000E7F RID: 3711
		private TeamList m_PlayingTeams = new TeamList();

		// Token: 0x04000E80 RID: 3712
		private Trophy m_Trophy;
	}
}
