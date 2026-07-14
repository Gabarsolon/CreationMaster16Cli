using System;

namespace FifaLibrary
{
	// Token: 0x0200007F RID: 127
	public class StadiumList : IdArrayList
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0003EE22 File Offset: 0x0003D022
		public StadiumList()
			: base(typeof(Stadium))
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0003EE34 File Offset: 0x0003D034
		public StadiumList(DbFile fifaDbFile)
			: base(typeof(Stadium))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0003EE50 File Offset: 0x0003D050
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.teamstadiumlinks];
			int num = table.TableDescriptor.MinValues[FI.teamstadiumlinks_stadiumid];
			int num2 = table.TableDescriptor.MaxValues[FI.teamstadiumlinks_stadiumid];
			table = FifaEnvironment.FifaDb.Table[TI.stadiums];
			this.Load(table, num, num2);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003EEAC File Offset: 0x0003D0AC
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Stadium stadium = new Stadium(t.Records[i]);
				this.Add(stadium);
			}
			base.SortId();
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003EEFC File Offset: 0x0003D0FC
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((Stadium)obj).LinkTeam(teamList);
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0003EF50 File Offset: 0x0003D150
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((Stadium)obj).LinkCountry(countryList);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.stadiums];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				Record record = table.Records[num];
				num++;
				stadium.SaveStadium(record);
				stadium.SaveLangTable();
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteStadium(Stadium stadium)
		{
			base.RemoveId(stadium);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0003F028 File Offset: 0x0003D228
		public Stadium FitStadium(string name, int id)
		{
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				if (stadium.name == name || stadium.LocalName == name)
				{
					return stadium;
				}
			}
			return null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0003F098 File Offset: 0x0003D298
		public override IdArrayList Filter(IdObject filter)
		{
			StadiumList stadiumList = new StadiumList();
			if (filter == null)
			{
				return this;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Stadium stadium = (Stadium)this[i];
					if (stadium.Country == country)
					{
						stadiumList.Add(stadium);
					}
				}
				return stadiumList;
			}
			return this;
		}
	}
}
