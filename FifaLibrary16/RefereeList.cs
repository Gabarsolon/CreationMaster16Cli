using System;

namespace FifaLibrary
{
	// Token: 0x0200006F RID: 111
	public class RefereeList : IdArrayList
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x00038F99 File Offset: 0x00037199
		public RefereeList()
			: base(typeof(Referee))
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00038FAB File Offset: 0x000371AB
		public RefereeList(DbFile fifaDbFile)
			: base(typeof(Referee))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00038FC4 File Offset: 0x000371C4
		public void Load(DbFile fifaDbFile)
		{
			int num = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MinValues[FI.referee_refereeid];
			int num2 = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_refereeid];
			Table table = fifaDbFile.Table[TI.referee];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.leaguerefereelinks];
			this.FillFromLeagueRefereeLinks(table);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00039040 File Offset: 0x00037240
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Referee referee = new Referee(t.Records[i]);
				this.Add(referee);
			}
			base.SortId();
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00039090 File Offset: 0x00037290
		public void FillFromLeagueRefereeLinks(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.leaguerefereelinks_refereeid];
				Referee referee = (Referee)base.SearchId(num);
				if (referee != null)
				{
					referee.FillFromLeagueRefereeLinks(record);
				}
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000390DC File Offset: 0x000372DC
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.referee];
			table.ResizeRecords(this.Count);
			Table table2 = fifaDbFile.Table[TI.leaguerefereelinks];
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				Record record = table.Records[num2];
				referee.SaveReferee(record);
				num2++;
				num += referee.CntLeagues();
			}
			table2.ResizeRecords(num);
			int num3 = 0;
			foreach (object obj2 in this)
			{
				Referee referee2 = (Referee)obj2;
				for (int i = 0; i < referee2.Leagues.Length; i++)
				{
					if (referee2.Leagues[i] != null)
					{
						Record record2 = table2.Records[num3];
						referee2.SaveLeagueRefereeLinks(record2, i);
						num3++;
					}
				}
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0003920C File Offset: 0x0003740C
		public int GetNewRefereeHeadId()
		{
			int num = 0;
			int num2 = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MinValues[FI.referee_refereeid];
			for (int i = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_refereeid]; i >= num2; i--)
			{
				bool flag = false;
				foreach (object obj in this)
				{
					Referee referee = (Referee)obj;
					if (i == referee.Id)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000392C8 File Offset: 0x000374C8
		public Referee FitReferee(string name, int id)
		{
			foreach (object obj in this)
			{
				Referee referee = (Referee)obj;
				if (referee.ToString() == name)
				{
					return referee;
				}
			}
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteReferee(Referee referee)
		{
			base.RemoveId(referee);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0003932C File Offset: 0x0003752C
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((Referee)obj).LinkCountry(countryList);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00039380 File Offset: 0x00037580
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				((Referee)obj).LinkLeague(leagueList);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000393D4 File Offset: 0x000375D4
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			RefereeList refereeList = new RefereeList();
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Referee referee = (Referee)this[i];
					if (referee.Country == country)
					{
						refereeList.Add(referee);
					}
				}
				return refereeList;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Referee referee2 = (Referee)this[j];
					if (referee2.IsInLeague(league))
					{
						refereeList.Add(referee2);
					}
				}
				return refereeList;
			}
			return this;
		}

		// Token: 0x04000FA2 RID: 4002
		public static KitList s_RefereeKits;
	}
}
