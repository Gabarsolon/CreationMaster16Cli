using System;

namespace FifaLibrary
{
	// Token: 0x02000081 RID: 129
	public class TeamList : IdArrayList
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x0001FC19 File Offset: 0x0001DE19
		public TeamList(Type teamType)
			: base(teamType)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00044D28 File Offset: 0x00042F28
		public TeamList()
			: base(typeof(Team))
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00044D3A File Offset: 0x00042F3A
		public TeamList(DbFile fifaDbFile)
			: base(typeof(Team))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00044D54 File Offset: 0x00042F54
		public void Load(DbFile fifaDbFile)
		{
			int num = 130020;
			int num2 = 200000;
			Table table = fifaDbFile.Table[TI.teams];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.stadiumassignments];
			this.FillFromStadiumAssignments(table);
			table = fifaDbFile.Table[TI.manager];
			this.FillFromManager(table);
			table = fifaDbFile.Table[TI.teamstadiumlinks];
			this.FillFromTeamStadiumLinks(table);
			table = fifaDbFile.Table[TI.teamkits];
			this.FillFromTeamkits(table);
			table = fifaDbFile.Table[TI.career_newspicweights];
			this.FillFromNewspicweights(table);
			table = fifaDbFile.Table[TI.teamformationteamstylelinks];
			this.FillFromTeamFormationLinks(table);
			table = fifaDbFile.Table[TI.formations];
			this.FillFromFormations(table);
			table = fifaDbFile.Table[TI.leagueteamlinks];
			this.FillFromLeagueTeamLinks(table);
			table = fifaDbFile.Table[TI.rowteamnationlinks];
			this.FillFromRowTeamNationLinks(table);
			if (TI.teamnationlinks >= 0)
			{
				table = fifaDbFile.Table[TI.teamnationlinks];
				this.FillFromTeamNationLinks(table);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00044E54 File Offset: 0x00043054
		private void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Team[] array = new Team[t.NRecords];
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				array[i] = new Team(t.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00044EB0 File Offset: 0x000430B0
		public void FillFromStadiumAssignments(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.stadiumassignments_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromStadiumAssignments(record);
				}
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00044EFC File Offset: 0x000430FC
		public void FillFromManager(Table t)
		{
			for (int i = 0; i < t.NValidRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.manager_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromManager(record);
				}
			}
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00044F48 File Offset: 0x00043148
		public void FillFromTeamStadiumLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamstadiumlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamStadiumLinks(record);
				}
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00044F94 File Offset: 0x00043194
		public void FillFromTeamkits(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamkits_teamtechid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamkits(record);
				}
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00044FE0 File Offset: 0x000431E0
		public void FillFromNewspicweights(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.career_newspicweights_teamid];
				if (num != 0)
				{
					Team team = (Team)base.SearchId(num);
					if (team != null)
					{
						team.FillFromNewspicweights(record);
					}
				}
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00045030 File Offset: 0x00043230
		public void FillFromFormations(Table t)
		{
			int fieldIndex = t.TableDescriptor.GetFieldIndex("teamid");
			for (int i = 0; i < t.NValidRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[fieldIndex];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromFormations(record);
				}
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0004508C File Offset: 0x0004328C
		public void FillFromTeamFormationLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamformationteamstylelinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamFormationLinks(record);
				}
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000450D8 File Offset: 0x000432D8
		public void FillFromTeamNationLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamnationlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromTeamNationLinks(record);
				}
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00045124 File Offset: 0x00043324
		public void FillFromLeagueTeamLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.leagueteamlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromLeagueTeamLinks(record);
				}
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00045170 File Offset: 0x00043370
		public void FillFromRivals(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.rivals_teamid1];
				Team team = (Team)base.SearchId(num);
				int num2 = record.IntField[FI.rivals_teamid2];
				Team team2 = (Team)base.SearchId(num2);
				if (team != null)
				{
				}
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000451D0 File Offset: 0x000433D0
		public void FillFromRowTeamNationLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.rowteamnationlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team != null)
				{
					team.FillFromRowTeamNationLinks(record);
				}
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0004521C File Offset: 0x0004341C
		public void FillFromTeamPlayerLinks(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamplayerlinks];
			this.FillFromTeamPlayerLinks(table);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00045240 File Offset: 0x00043440
		public void FillFromTeamPlayerLinks(Table t)
		{
			if (FifaEnvironment.Players == null)
			{
				return;
			}
			for (int i = 0; i < t.NValidRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.teamplayerlinks_teamid];
				Team team = (Team)base.SearchId(num);
				if (team == null)
				{
					FifaEnvironment.UserMessages.ShowMessage(5016, num);
				}
				else
				{
					int num2 = record.IntField[FI.teamplayerlinks_playerid];
					Player player = (Player)FifaEnvironment.Players.SearchId(num2);
					if (player == null)
					{
						FifaEnvironment.UserMessages.ShowMessage(5017, num2);
					}
					else
					{
						player.PlayFor(team);
						TeamPlayer teamPlayer = new TeamPlayer(record, player, team);
						team.Roster.Add(teamPlayer);
					}
				}
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00045300 File Offset: 0x00043500
		public void LinkKits(KitList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			foreach (object obj in this)
			{
				((Team)obj).LinkKits(kitList);
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00045358 File Offset: 0x00043558
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x000453B0 File Offset: 0x000435B0
		public void LinkStadiums(StadiumList stadiumList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkStadium(stadiumList);
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00045404 File Offset: 0x00043604
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkLeague(leagueList);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00045458 File Offset: 0x00043658
		public void LinkOpponent(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkTeam(teamList);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x000454AC File Offset: 0x000436AC
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkCountry(countryList);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00045500 File Offset: 0x00043700
		public void LinkFormation(FormationList formationList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkFormation(formationList);
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00045554 File Offset: 0x00043754
		public void LinkPlayer(PlayerList playerList)
		{
			foreach (object obj in this)
			{
				((Team)obj).LinkPlayer(playerList);
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000455A8 File Offset: 0x000437A8
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teams];
			Table table2 = fifaDbFile.Table[TI.teamstadiumlinks];
			Table table3 = fifaDbFile.Table[TI.teamnationlinks];
			Table table4 = fifaDbFile.Table[TI.stadiumassignments];
			Table table5 = fifaDbFile.Table[TI.manager];
			Table table6 = fifaDbFile.Table[TI.rowteamnationlinks];
			Table table7 = fifaDbFile.Table[TI.teamplayerlinks];
			Table table8 = fifaDbFile.Table[TI.teamformationteamstylelinks];
			Table table9 = fifaDbFile.Table[TI.career_newspicweights];
			Table table10 = null;
			if (TI.defaultteamdata >= 0)
			{
				table10 = fifaDbFile.Table[TI.defaultteamdata];
			}
			Table table11 = null;
			if (TI.default_teamsheets >= 0)
			{
				table11 = fifaDbFile.Table[TI.default_teamsheets];
			}
			table.ResizeRecords(this.Count);
			if (table10 != null)
			{
				table10.ResizeRecords(this.Count);
			}
			if (table11 != null)
			{
				table11.ResizeRecords(this.Count);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				Record record = table.Records[num9];
				Record record2 = null;
				if (table10 != null)
				{
					record2 = table10.Records[num9];
				}
				Record record3 = null;
				if (table11 != null)
				{
					record3 = table11.Records[num9];
				}
				num9++;
				team.SaveTeam(record);
				team.Roster.SortRoster();
				team.SaveDefaultTeamData(record2);
				team.SaveDefaultTeamsheets(record3);
				team.SaveLangTable();
				num += team.Roster.Count;
				if (team.stadiumcustomname != null)
				{
					num2++;
				}
				if (team.stadiumid >= 0)
				{
					num3++;
				}
				if (team.ManagerSurname != null)
				{
					num7++;
				}
				if (team.Formation != null && team.Formation.IsGeneric())
				{
					num6++;
				}
				if (team.NationalTeam)
				{
					num5++;
				}
				else if (team.IsRowTeam())
				{
					num4++;
				}
				if (team.HasNewsPictures())
				{
					num8++;
				}
			}
			table7.ResizeRecords(num);
			table4.ResizeRecords(num2);
			table6.ResizeRecords(num4);
			table3.ResizeRecords(num5);
			table8.ResizeRecords(num6);
			table5.ResizeRecords(num7);
			table9.ResizeRecords(num8 + 1);
			table2.ResizeRecords(num3);
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			int num17 = 1;
			Team.SaveDefaultNewspicweights(table9.Records[0]);
			int num18 = 0;
			foreach (object obj2 in this)
			{
				Team team2 = (Team)obj2;
				foreach (object obj3 in team2.Roster)
				{
					TeamPlayer teamPlayer = (TeamPlayer)obj3;
					Record record4 = table7.Records[num10];
					num10++;
					teamPlayer.Save(record4, num18);
					num18++;
				}
				if (team2.NationalTeam)
				{
					Record record5 = table3.Records[num11];
					num11++;
					team2.SaveTeamNationLinks(record5);
				}
				else if (team2.IsRowTeam())
				{
					Record record6 = table6.Records[num13];
					num13++;
					team2.SaveRowTeamNationLinks(record6);
				}
				if (team2.stadiumcustomname != null)
				{
					Record record7 = table4.Records[num12];
					num12++;
					team2.SaveStadiumAssignment(record7);
				}
				if (team2.Formation != null && team2.Formation.IsGeneric())
				{
					Record record8 = table8.Records[num14];
					num14++;
					team2.SaveTeamFormationLinks(record8);
				}
				if (team2.ManagerSurname != null)
				{
					Record record9 = table5.Records[num15];
					num15++;
					team2.SaveManager(record9);
				}
				if (team2.HasNewsPictures())
				{
					Record record10 = table9.Records[num17];
					num17++;
					team2.SaveNewspicweights(record10);
				}
				if (team2.stadiumid >= 0)
				{
					Record record11 = table2.Records[num16];
					team2.SaveTeamStadiumLinks(record11);
					num16++;
				}
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00045A44 File Offset: 0x00043C44
		public override IdArrayList Filter(IdObject filter)
		{
			TeamList teamList = new TeamList();
			if (filter == null)
			{
				return this;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Team team = (Team)this[i];
					if (team.League == league)
					{
						teamList.Add(team);
					}
				}
				return teamList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Team team2 = (Team)this[j];
					if (team2.Country == country)
					{
						teamList.Add(team2);
					}
				}
				return teamList;
			}
			return this;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteTeam(Team team)
		{
			base.RemoveId(team);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00045B08 File Offset: 0x00043D08
		public Team SearchTeamByCountr(Country country, bool club)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				if (team.Country == country)
				{
					if (club && team.IsClub())
					{
						return team;
					}
					if (!club && team.IsNationalTeam())
					{
						return team;
					}
				}
			}
			return null;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00045B80 File Offset: 0x00043D80
		public Team FitTeam(string name, int id)
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				if (team.DatabaseName == name)
				{
					return team;
				}
			}
			return null;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00045BE4 File Offset: 0x00043DE4
		public Team IsInTopLeague()
		{
			foreach (object obj in this)
			{
				Team team = (Team)obj;
				if (team.IsInTopLeague())
				{
					return team;
				}
			}
			return null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00045C40 File Offset: 0x00043E40
		public Team MatchByname(string matchName)
		{
			string[] array = matchName.Split(TeamList.s_Separators);
			int num = 0;
			Team team = null;
			if (matchName == "Inter Milan")
			{
				matchName = "Inter";
			}
			foreach (object obj in this)
			{
				Team team2 = (Team)obj;
				string[] array2 = team2.DatabaseName.Split(TeamList.s_Separators);
				int num2 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j].Length > 2 && array[i].Length > 2 && array2[j] == array[i])
						{
							num2++;
						}
					}
				}
				if (num2 > num)
				{
					team = team2;
					num = num2;
				}
			}
			return team;
		}

		// Token: 0x040010C9 RID: 4297
		private static char[] s_Separators = new char[] { ' ', '.', '-' };
	}
}
