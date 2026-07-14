using System;

namespace FifaLibrary
{
	// Token: 0x02000054 RID: 84
	public class LeagueList : IdArrayList
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x0002A3C8 File Offset: 0x000285C8
		public LeagueList()
			: base(typeof(League))
		{
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002A3DA File Offset: 0x000285DA
		public LeagueList(DbFile fifaDbFile)
			: base(typeof(League))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002A3F4 File Offset: 0x000285F4
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.leagues];
			int num = 1;
			int num2 = table.TableDescriptor.MaxValues[FI.leagues_leagueid];
			Table table2 = FifaEnvironment.FifaDb.Table[TI.leagues];
			this.Load(table2, num, num2);
			table2 = fifaDbFile.Table[TI.career_boardoutcomes];
			this.FillFromBoardOutcomes(table2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002A454 File Offset: 0x00028654
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				League league = new League(t.Records[i]);
				this.Add(league);
			}
			base.SortId();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0002A4A4 File Offset: 0x000286A4
		public void FillFromBoardOutcomes(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.career_boardoutcomes_leagueid];
				League league = (League)base.SearchId(num);
				if (league != null)
				{
					league.FillFromBoardOutcomes(record);
				}
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002A4F0 File Offset: 0x000286F0
		public League AddNewLeague()
		{
			int num = Trophy.AutoAsset();
			if (num < 0)
			{
				return null;
			}
			return (League)base.CreateNewId(num);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteLeague(League league)
		{
			base.RemoveId(league);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002A518 File Offset: 0x00028718
		public void FillFromLeagueTeamLinks(DbFile fifaDbFile)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			Table table = fifaDbFile.Table[TI.leagueteamlinks];
			this.FillFromLeagueTeamLinks(table);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002A544 File Offset: 0x00028744
		public void FillFromLeagueTeamLinks(Table leagueteamlinksTable)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			for (int i = 0; i < leagueteamlinksTable.NRecords; i++)
			{
				Record record = leagueteamlinksTable.Records[i];
				int num = record.IntField[FI.leagueteamlinks_teamid];
				int num2 = record.IntField[FI.leagueteamlinks_leagueid];
				Team team = (Team)FifaEnvironment.Teams.SearchId(num);
				if (team == null)
				{
					FifaEnvironment.UserMessages.ShowMessage(5022, num);
				}
				else
				{
					League league = (League)base.SearchId(num2);
					if (league == null)
					{
						FifaEnvironment.UserMessages.ShowMessage(5023, num2);
					}
					else
					{
						league.LinkTeam(team);
						team.League = league;
					}
				}
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002A5F3 File Offset: 0x000287F3
		public League SearchLeague(int leagueid)
		{
			return (League)base.SearchId(leagueid);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002A604 File Offset: 0x00028804
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.leagues];
			Table table2 = fifaDbFile.Table[TI.leagueteamlinks];
			Table table3 = fifaDbFile.Table[TI.career_boardoutcomes];
			table.ResizeRecords(this.Count);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this)
			{
				League league = (League)obj;
				Record record = table.Records[num2];
				num2++;
				league.SaveLeague(record);
				num += league.PlayingTeams.Count;
				if (league.boardoutcomes[0] != 0)
				{
					num3++;
				}
			}
			table2.ResizeRecords(num);
			table3.ResizeRecords(num3);
			int num4 = 0;
			num2 = 0;
			int num5 = 0;
			foreach (object obj2 in this)
			{
				League league2 = (League)obj2;
				foreach (object obj3 in league2.PlayingTeams)
				{
					Team team = (Team)obj3;
					Record record2 = table2.Records[num2];
					league2.SaveTeamLink(record2, team, num4);
					num4++;
					num2++;
				}
				if (league2.boardoutcomes[0] != 0)
				{
					Record record3 = table3.Records[num5];
					league2.SaveBoardOutcomes(record3);
					num5++;
				}
			}
			foreach (object obj4 in this)
			{
				League league3 = (League)obj4;
				int id = league3.Id;
				if (FifaEnvironment.Language != null)
				{
					FifaEnvironment.Language.SetLeagueString(id, Language.ELeagueStringType.Abbr15, league3.ShortName);
					FifaEnvironment.Language.SetLeagueString(id, Language.ELeagueStringType.Full, league3.LongName);
				}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0002A844 File Offset: 0x00028A44
		public League FitLeague(string name, int id)
		{
			foreach (object obj in this)
			{
				League league = (League)obj;
				if (league.leaguename == name || league.ShortName == name || league.LongName == name)
				{
					return league;
				}
			}
			return null;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0002A8C4 File Offset: 0x00028AC4
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			LeagueList leagueList = new LeagueList();
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					League league = (League)this[i];
					if (league.Country == country)
					{
						leagueList.Add(league);
					}
				}
				return leagueList;
			}
			return this;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002A92C File Offset: 0x00028B2C
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((League)obj).LinkCountry(countryList);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002A980 File Offset: 0x00028B80
		public void LinkBall(BallList ballList)
		{
			if (ballList == null)
			{
				return;
			}
			foreach (object obj in this)
			{
				((Team)obj).LinkBall(ballList);
			}
		}
	}
}
