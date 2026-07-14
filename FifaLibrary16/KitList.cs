using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000050 RID: 80
	public class KitList : IdArrayList
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x00028375 File Offset: 0x00026575
		public KitList()
			: base(typeof(Kit))
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001FC19 File Offset: 0x0001DE19
		public KitList(Type type)
			: base(type)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00028387 File Offset: 0x00026587
		public KitList(DbFile fifaDbFile)
			: base(typeof(Kit))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000283A0 File Offset: 0x000265A0
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamkits];
			int num = table.TableDescriptor.MinValues[FI.teamkits_teamkitid];
			int num2 = table.TableDescriptor.MaxValues[FI.teamkits_teamkitid];
			this.Load(table, num, num2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000283E8 File Offset: 0x000265E8
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Kit kit = new Kit(t.Records[i]);
				bool flag = false;
				while (base.SearchId(kit) != null)
				{
					kit.Id--;
					flag = true;
				}
				this.Add(kit);
				if (flag)
				{
					base.SortId();
				}
			}
			base.SortId();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002845C File Offset: 0x0002665C
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamkits];
			table.ResizeRecords(this.Count);
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				Record record = table.Records[num];
				kit.SaveKit(record, num2);
				num++;
				num2++;
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000284E4 File Offset: 0x000266E4
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((Kit)obj).LinkTeam(teamList);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00028538 File Offset: 0x00026738
		public bool IsJerseyFontUsed(int jerseyFontId)
		{
			IEnumerator enumerator = this.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if (((Kit)enumerator.Current).jerseyNumberFont == jerseyFontId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00028594 File Offset: 0x00026794
		public Kit GetKit(int teamId, int kitType)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.teamid == teamId && kit.kittype == kitType)
				{
					return kit;
				}
			}
			return null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000285FC File Offset: 0x000267FC
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			KitList kitList = new KitList();
			if (filter.GetType().Name == "Team")
			{
				Team team = (Team)filter;
				if (team != null)
				{
					for (int i = 0; i < this.Count; i++)
					{
						Kit kit = (Kit)this[i];
						if (kit.Team == team)
						{
							kitList.Add(kit);
						}
					}
				}
				return kitList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Kit kit2 = (Kit)this[j];
					if (kit2.Team != null && kit2.Team.Country == country)
					{
						kitList.Add(kit2);
					}
				}
				return kitList;
			}
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int k = 0; k < this.Count; k++)
				{
					Kit kit3 = (Kit)this[k];
					if (kit3.Team != null && kit3.Team.League == league)
					{
						kitList.Add(kit3);
					}
				}
				return kitList;
			}
			return this;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00028738 File Offset: 0x00026938
		public bool Exists(int teamid, int kittype, int year)
		{
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.teamid == teamid && kit.kittype == kittype && kit.year == year)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000091A7 File Offset: 0x000073A7
		public void DeleteKit(Kit kit)
		{
			base.RemoveId(kit);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000287A8 File Offset: 0x000269A8
		public Kit FitKit(string name, int id)
		{
			name = name.Substring(0, name.IndexOf('('));
			int num = id / 10;
			int num2 = id - num * 10;
			foreach (object obj in this)
			{
				Kit kit = (Kit)obj;
				if (kit.teamid == num && kit.kittype == num2)
				{
					return kit;
				}
				string text = kit.ToString();
				text = text.Substring(0, text.IndexOf('('));
				if (text == name)
				{
					return kit;
				}
			}
			return null;
		}
	}
}
