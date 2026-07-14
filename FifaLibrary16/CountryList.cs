using System;

namespace FifaLibrary
{
	// Token: 0x02000023 RID: 35
	public class CountryList : IdArrayList
	{
		// Token: 0x06000238 RID: 568 RVA: 0x000090C5 File Offset: 0x000072C5
		public CountryList()
			: base(typeof(Country))
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000090D7 File Offset: 0x000072D7
		public CountryList(DbFile fifaDbFile)
			: base(typeof(Country))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000090F0 File Offset: 0x000072F0
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.nations];
			int num = table.TableDescriptor.MinValues[FI.nations_nationid];
			int num2 = table.TableDescriptor.MaxValues[FI.nations_nationid];
			Table table2 = FifaEnvironment.FifaDb.Table[TI.nations];
			this.Load(table2, num, num2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000914C File Offset: 0x0000734C
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Country[] array = new Country[t.NRecords];
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				array[i] = new Country(t.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteCountry(Country country)
		{
			base.RemoveId(country);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000091B1 File Offset: 0x000073B1
		public Country SearchCountry(int countryid)
		{
			return (Country)base.SearchId(countryid);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000091C0 File Offset: 0x000073C0
		public Country SearchCountry(string countryString)
		{
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				if (countryString == country.ToString())
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00009224 File Offset: 0x00007424
		public Country SearchCountryByDatabaseName(string countryString)
		{
			if (countryString.Contains("Bosnia"))
			{
				return this.SearchCountry(8);
			}
			if (countryString.Contains("Macedonia"))
			{
				return this.SearchCountry(19);
			}
			if (countryString == "Ireland")
			{
				return this.SearchCountry(25);
			}
			if (countryString == "Curacao")
			{
				return this.SearchCountry(34);
			}
			if (countryString == "Netherlands")
			{
				return this.SearchCountry(34);
			}
			if (countryString.Contains("Verde"))
			{
				return this.SearchCountry(104);
			}
			if (countryString.Contains("voire"))
			{
				return this.SearchCountry(108);
			}
			if (countryString.Contains("China"))
			{
				return this.SearchCountry(155);
			}
			if (countryString.Contains("Korea, North"))
			{
				return this.SearchCountry(166);
			}
			if (countryString.Contains("Korea, South"))
			{
				return this.SearchCountry(167);
			}
			if (countryString.Contains("aledon"))
			{
				return this.SearchCountry(215);
			}
			if (countryString == "French Guiana")
			{
				return this.SearchCountry(79);
			}
			if (countryString.Contains("Gambia"))
			{
				return this.SearchCountry(116);
			}
			if (countryString.Contains("Martinique"))
			{
				return this.SearchCountry(18);
			}
			if (countryString.Contains("Guadeloupe"))
			{
				return this.SearchCountry(18);
			}
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				if (countryString == country.DatabaseString())
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000093DC File Offset: 0x000075DC
		public Country SearchNationalTeamId(int nationalTeamId)
		{
			if (nationalTeamId == 3145)
			{
				return (Country)base.SearchId(34);
			}
			if (nationalTeamId == 1800)
			{
				return null;
			}
			for (int i = 0; i < this.Count; i++)
			{
				Country country = (Country)this[i];
				if (nationalTeamId == country.NationalTeamId)
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009434 File Offset: 0x00007634
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.nations];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				Record record = table.Records[num];
				country.SaveCountry(record);
				country.SaveLangTable();
				num++;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000094B8 File Offset: 0x000076B8
		public void FillFromAudionation(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				int num = t.Records[i].IntField[FI.audionation_nationid];
				Country country = (Country)base.SearchId(num);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000094F8 File Offset: 0x000076F8
		public Country FitCountry(string name, int id)
		{
			string text = name.ToLower();
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				if (country.Fit(text, id))
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009560 File Offset: 0x00007760
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((Country)obj).LinkTeam(teamList);
			}
		}
	}
}
