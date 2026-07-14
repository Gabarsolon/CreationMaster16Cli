using System;

namespace FifaLibrary
{
	// Token: 0x0200003E RID: 62
	public class FormationList : IdArrayList
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x0001FC07 File Offset: 0x0001DE07
		public FormationList()
			: base(typeof(Formation))
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001FC19 File Offset: 0x0001DE19
		public FormationList(Type type)
			: base(type)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001FC22 File Offset: 0x0001DE22
		public FormationList(DbFile fifaDbFile)
			: base(typeof(Formation))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001FC3B File Offset: 0x0001DE3B
		public FormationList(Table formationsTable, int minId, int maxId)
			: base(typeof(Formation))
		{
			this.Load(formationsTable, minId, maxId);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001FC58 File Offset: 0x0001DE58
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.formations];
			int num = table.TableDescriptor.MaxValues[FI.formations_formationid];
			int num2 = 1;
			this.Load(table, num2, num);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001FC94 File Offset: 0x0001DE94
		private void Load(Table formationsTable, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				Formation formation = new Formation(formationsTable.Records[i]);
				this.Add(formation);
			}
			base.SortId();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
		public void Save(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.formations];
			this.Save(table);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		public void Save(Table formationsTable)
		{
			formationsTable.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				Record record = formationsTable.Records[num];
				num++;
				formation.Save(record);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001FD7C File Offset: 0x0001DF7C
		public void LinkTeam(TeamList teamList)
		{
			for (int i = 0; i < this.Count; i++)
			{
				Formation formation = (Formation)this[i];
				if (!formation.LinkTeam(teamList))
				{
					base.RemoveId(formation);
					i--;
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001FDBC File Offset: 0x0001DFBC
		public Formation SearchByTeamId(int teamId)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				if (formation.teamid == teamId)
				{
					return formation;
				}
			}
			return null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001FE1C File Offset: 0x0001E01C
		public Formation GetNearestFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeDistance(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			return formation2;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001FE90 File Offset: 0x0001E090
		public Formation GetClosestFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeSimilarity(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			return formation2;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001FF04 File Offset: 0x0001E104
		public Formation GetExactFormation(Formation formation)
		{
			int num = 384;
			Formation formation2 = null;
			foreach (object obj in this)
			{
				Formation formation3 = (Formation)obj;
				if (formation3 != formation)
				{
					int num2 = formation.ComputeDistance(formation3);
					if (num2 < num)
					{
						num = num2;
						formation2 = formation3;
					}
				}
			}
			if (num != 0)
			{
				return null;
			}
			return formation2;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001FF7C File Offset: 0x0001E17C
		public Formation FitFormationByTeamId(int teamid)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				if (formation.teamid == teamid)
				{
					return formation;
				}
			}
			return null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		public Formation FitFormation(string name, int id)
		{
			foreach (object obj in this)
			{
				Formation formation = (Formation)obj;
				if (formation.ToString() == name)
				{
					return formation;
				}
				if (formation.Team != null)
				{
					string text = formation.Team.DatabaseName + " ";
					if (name.StartsWith(text))
					{
						bool flag = true;
						for (int i = text.Length; i < name.Length; i++)
						{
							if (name[i] != '-' && name[i] != '(' && name[i] != ')' && name[i] != 'S' && name[i] != 'W' && (name[i] < '0' || name[i] > '9'))
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							return formation;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000200F4 File Offset: 0x0001E2F4
		public void LinkRoles(RoleList roleList)
		{
			foreach (object obj in this)
			{
				((Formation)obj).LinkRoles(roleList);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00020148 File Offset: 0x0001E348
		public Formation CreateNewFormation(int newId)
		{
			if (base.SearchId(newId) != null)
			{
				return null;
			}
			Formation formation = (Formation)base.CreateNewId(newId);
			base.InsertId(formation);
			return formation;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00020178 File Offset: 0x0001E378
		public Formation CreateNewFormation()
		{
			int newId = this.GetNewId();
			return (Formation)base.CreateNewId(newId);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00020198 File Offset: 0x0001E398
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			FormationList formationList = new FormationList();
			if (filter.GetType().Name == "League")
			{
				League league = (League)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Formation formation = (Formation)this[i];
					if (formation.Team != null && formation.Team.League == league)
					{
						formationList.Add(formation);
					}
				}
				return formationList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int j = 0; j < this.Count; j++)
				{
					Formation formation2 = (Formation)this[j];
					if (formation2.Team != null && formation2.Team.Country == country)
					{
						formationList.Add(formation2);
					}
				}
				return formationList;
			}
			if (filter.GetType().Name == "Team" || filter.GetType().Name == "CareerTeam")
			{
				Team team = (Team)filter;
				for (int k = 0; k < this.Count; k++)
				{
					Formation formation3 = (Formation)this[k];
					if (formation3.Team != null && formation3.Team == team)
					{
						formationList.Add(formation3);
					}
				}
				return formationList;
			}
			return this;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000202ED File Offset: 0x0001E4ED
		public bool DeleteFormation(Formation formation)
		{
			return base.RemoveId(formation);
		}
	}
}
