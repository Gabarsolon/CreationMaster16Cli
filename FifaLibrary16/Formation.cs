using System;

namespace FifaLibrary
{
	// Token: 0x0200003D RID: 61
	public class Formation : IdObject
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001EF8A File Offset: 0x0001D18A
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0001EF92 File Offset: 0x0001D192
		public PlayingRole[] PlayingRoles
		{
			get
			{
				return this.m_PlayingRoles;
			}
			set
			{
				this.m_PlayingRoles = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001EF9B File Offset: 0x0001D19B
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0001EFA3 File Offset: 0x0001D1A3
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				if (this.m_Team != null)
				{
					this.m_teamid = this.m_Team.Id;
					return;
				}
				this.m_teamid = -1;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001EFCD File Offset: 0x0001D1CD
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0001EFD5 File Offset: 0x0001D1D5
		public string formationname
		{
			get
			{
				return this.m_formationname;
			}
			set
			{
				this.m_formationname = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001EFDE File Offset: 0x0001D1DE
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0001EFE6 File Offset: 0x0001D1E6
		public string formationfullname
		{
			get
			{
				return this.m_formationfullname;
			}
			set
			{
				this.m_formationfullname = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001EFEF File Offset: 0x0001D1EF
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0001EFF7 File Offset: 0x0001D1F7
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
			set
			{
				this.m_teamid = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001F000 File Offset: 0x0001D200
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0001F008 File Offset: 0x0001D208
		public int relativeformationid
		{
			get
			{
				return this.m_relativeformationid;
			}
			set
			{
				this.m_relativeformationid = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001F011 File Offset: 0x0001D211
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0001F019 File Offset: 0x0001D219
		public int formations_issweeper
		{
			get
			{
				return this.m_formations_issweeper;
			}
			set
			{
				this.m_formations_issweeper = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001F022 File Offset: 0x0001D222
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0001F02A File Offset: 0x0001D22A
		public int offensiverating
		{
			get
			{
				return this.m_offensiverating;
			}
			set
			{
				this.m_offensiverating = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001F033 File Offset: 0x0001D233
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0001F03B File Offset: 0x0001D23B
		public int formationfullnameid
		{
			get
			{
				return this.m_formationfullnameid;
			}
			set
			{
				this.m_formationfullnameid = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001F044 File Offset: 0x0001D244
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0001F04C File Offset: 0x0001D24C
		public int formationaudioid
		{
			get
			{
				return this.m_formationaudioid;
			}
			set
			{
				this.m_formationaudioid = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001F055 File Offset: 0x0001D255
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0001F05D File Offset: 0x0001D25D
		public float defenders
		{
			get
			{
				return this.m_defenders;
			}
			set
			{
				this.m_defenders = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001F066 File Offset: 0x0001D266
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0001F06E File Offset: 0x0001D26E
		public float midfielders
		{
			get
			{
				return this.m_midfielders;
			}
			set
			{
				this.m_midfielders = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001F077 File Offset: 0x0001D277
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0001F07F File Offset: 0x0001D27F
		public float attackers
		{
			get
			{
				return this.m_attackers;
			}
			set
			{
				this.m_attackers = value;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001F088 File Offset: 0x0001D288
		public bool IsGeneric()
		{
			return this.m_teamid == -1;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0001EFCD File Offset: 0x0001D1CD
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x0001F093 File Offset: 0x0001D293
		public string Name
		{
			get
			{
				return this.m_formationname;
			}
			set
			{
				if (value != null)
				{
					this.m_formationname = value;
					return;
				}
				this.m_formationname = string.Empty;
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001F0AB File Offset: 0x0001D2AB
		public override string ToString()
		{
			if (this.m_teamid > 0 && this.m_Team != null)
			{
				return this.m_Team.DatabaseName + " " + this.m_formationname;
			}
			return this.m_formationname;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
		public Formation(int formationid)
			: base(formationid)
		{
			base.Id = formationid;
			this.InitNewFormation();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001F10C File Offset: 0x0001D30C
		public bool ReInitialize(Formation formation)
		{
			if (formation == null)
			{
				return false;
			}
			this.m_formationname = formation.m_formationname;
			this.m_formationfullname = formation.m_formationfullname;
			this.m_relativeformationid = formation.m_relativeformationid;
			this.m_formations_issweeper = formation.m_formations_issweeper;
			this.m_offensiverating = formation.m_offensiverating;
			this.m_formationfullnameid = formation.m_formationfullnameid;
			this.m_defenders = formation.m_defenders;
			this.m_midfielders = formation.m_midfielders;
			this.m_attackers = formation.m_attackers;
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].ReInitialize(formation.m_PlayingRoles[i]);
			}
			return true;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		public bool LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return false;
			}
			if (this.m_teamid == -1)
			{
				return true;
			}
			this.m_Team = (Team)teamList.SearchId(this.m_teamid);
			return this.m_Team != null && this.m_Team.formationid == base.Id;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001F204 File Offset: 0x0001D404
		private void InitNewFormation()
		{
			this.m_formationname = "4-4-2";
			this.m_formationfullname = string.Empty;
			this.m_formationaudioid = 10;
			this.m_teamid = -1;
			this.m_relativeformationid = 24;
			this.m_formations_issweeper = 0;
			this.m_offensiverating = 1;
			this.m_formationfullnameid = -1;
			this.m_defenders = 4f;
			this.m_midfielders = 4f;
			this.m_attackers = 2f;
			this.m_PlayingRoles[0] = new PlayingRole((Role)FifaEnvironment.Roles[0]);
			this.m_PlayingRoles[1] = new PlayingRole((Role)FifaEnvironment.Roles[3]);
			this.m_PlayingRoles[2] = new PlayingRole((Role)FifaEnvironment.Roles[4]);
			this.m_PlayingRoles[3] = new PlayingRole((Role)FifaEnvironment.Roles[6]);
			this.m_PlayingRoles[4] = new PlayingRole((Role)FifaEnvironment.Roles[7]);
			this.m_PlayingRoles[5] = new PlayingRole((Role)FifaEnvironment.Roles[12]);
			this.m_PlayingRoles[6] = new PlayingRole((Role)FifaEnvironment.Roles[13]);
			this.m_PlayingRoles[7] = new PlayingRole((Role)FifaEnvironment.Roles[15]);
			this.m_PlayingRoles[8] = new PlayingRole((Role)FifaEnvironment.Roles[16]);
			this.m_PlayingRoles[9] = new PlayingRole((Role)FifaEnvironment.Roles[24]);
			this.m_PlayingRoles[10] = new PlayingRole((Role)FifaEnvironment.Roles[26]);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001F3BB File Offset: 0x0001D5BB
		public Formation(Record r)
			: base(r.IntField[FI.formations_formationid])
		{
			this.Load(r);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001F3E4 File Offset: 0x0001D5E4
		public override IdObject Clone(int newId)
		{
			Formation formation = (Formation)base.Clone(newId);
			formation.m_PlayingRoles = new PlayingRole[11];
			for (int i = 0; i < 11; i++)
			{
				int id = this.m_PlayingRoles[i].Id;
				PlayingRole playingRole = (PlayingRole)this.m_PlayingRoles[i].Clone(id);
				formation.m_PlayingRoles[i] = playingRole;
			}
			formation.m_formationname = "=" + formation.m_formationname;
			formation.m_Team = null;
			return formation;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001F464 File Offset: 0x0001D664
		public void Load17(Record r)
		{
			TableDescriptor tableDescriptor = r.TableDescriptor;
			this.m_formationname = r.StringField[tableDescriptor.GetFieldIndex("formationname")];
			this.m_teamid = r.IntField[tableDescriptor.GetFieldIndex("teamid")];
			this.m_offensiverating = r.IntField[tableDescriptor.GetFieldIndex("offensiverating")];
			this.m_formationfullnameid = r.IntField[tableDescriptor.GetFieldIndex("formationfullnameid")];
			this.m_formationaudioid = r.IntField[tableDescriptor.GetFieldIndex("formationaudioid")];
			this.m_defenders = r.FloatField[tableDescriptor.GetFieldIndex("defenders")];
			this.m_midfielders = r.FloatField[tableDescriptor.GetFieldIndex("midfielders")];
			this.m_attackers = r.FloatField[tableDescriptor.GetFieldIndex("attackers")];
			this.m_PlayingRoles[0] = new PlayingRole(r, 0, tableDescriptor.GetFieldIndex("position0"));
			this.m_PlayingRoles[1] = new PlayingRole(r, 1, tableDescriptor.GetFieldIndex("position1"));
			this.m_PlayingRoles[2] = new PlayingRole(r, 2, tableDescriptor.GetFieldIndex("position2"));
			this.m_PlayingRoles[3] = new PlayingRole(r, 3, tableDescriptor.GetFieldIndex("position3"));
			this.m_PlayingRoles[4] = new PlayingRole(r, 4, tableDescriptor.GetFieldIndex("position4"));
			this.m_PlayingRoles[5] = new PlayingRole(r, 5, tableDescriptor.GetFieldIndex("position5"));
			this.m_PlayingRoles[6] = new PlayingRole(r, 6, tableDescriptor.GetFieldIndex("position6"));
			this.m_PlayingRoles[7] = new PlayingRole(r, 7, tableDescriptor.GetFieldIndex("position7"));
			this.m_PlayingRoles[8] = new PlayingRole(r, 8, tableDescriptor.GetFieldIndex("position8"));
			this.m_PlayingRoles[9] = new PlayingRole(r, 9, tableDescriptor.GetFieldIndex("position9"));
			this.m_PlayingRoles[10] = new PlayingRole(r, 10, tableDescriptor.GetFieldIndex("position10"));
			if (this.m_formationfullnameid != -1)
			{
				if (FifaEnvironment.Language != null)
				{
					this.m_formationfullname = FifaEnvironment.Language.GetFormationString(this.m_formationfullnameid);
				}
			}
			else
			{
				this.m_formationfullname = this.m_formationname;
			}
			if (this.m_formationfullname == null || this.m_formationfullname == string.Empty)
			{
				this.m_formationfullname = this.m_formationname;
			}
			if (this.m_teamid == -1 && this.m_formationfullnameid == -1)
			{
				FifaEnvironment.Language.GetFreeFormationFullNameId();
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001F6D4 File Offset: 0x0001D8D4
		public void Load(Record r)
		{
			this.m_formationname = r.StringField[FI.formations_formationname];
			this.m_teamid = r.IntField[FI.formations_teamid];
			this.m_offensiverating = r.IntField[FI.formations_offensiverating];
			this.m_formationfullnameid = r.IntField[FI.formations_formationfullnameid];
			if (FI.formations_formationaudioid != -1)
			{
				this.m_formationaudioid = r.IntField[FI.formations_formationaudioid];
			}
			this.m_defenders = r.FloatField[FI.formations_defenders];
			this.m_midfielders = r.FloatField[FI.formations_midfielders];
			this.m_attackers = r.FloatField[FI.formations_attackers];
			this.m_PlayingRoles[0] = new PlayingRole(r, 0, FI.formations_position0);
			this.m_PlayingRoles[1] = new PlayingRole(r, 1, FI.formations_position1);
			this.m_PlayingRoles[2] = new PlayingRole(r, 2, FI.formations_position2);
			this.m_PlayingRoles[3] = new PlayingRole(r, 3, FI.formations_position3);
			this.m_PlayingRoles[4] = new PlayingRole(r, 4, FI.formations_position4);
			this.m_PlayingRoles[5] = new PlayingRole(r, 5, FI.formations_position5);
			this.m_PlayingRoles[6] = new PlayingRole(r, 6, FI.formations_position6);
			this.m_PlayingRoles[7] = new PlayingRole(r, 7, FI.formations_position7);
			this.m_PlayingRoles[8] = new PlayingRole(r, 8, FI.formations_position8);
			this.m_PlayingRoles[9] = new PlayingRole(r, 9, FI.formations_position9);
			this.m_PlayingRoles[10] = new PlayingRole(r, 10, FI.formations_position10);
			if (this.m_formationfullnameid != -1)
			{
				if (FifaEnvironment.Language != null)
				{
					this.m_formationfullname = FifaEnvironment.Language.GetFormationString(this.m_formationfullnameid);
				}
			}
			else
			{
				this.m_formationfullname = this.m_formationname;
			}
			if (this.m_formationfullname == null || this.m_formationfullname == string.Empty)
			{
				this.m_formationfullname = this.m_formationname;
			}
			if (this.m_teamid == -1)
			{
				int formationfullnameid = this.m_formationfullnameid;
			}
			if (this.m_teamid >= 0)
			{
				this.m_formationfullnameid = -1;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		public void Save(Record r)
		{
			r.IntField[FI.formations_formationid] = base.Id;
			r.StringField[FI.formations_formationname] = this.m_formationname;
			r.IntField[FI.formations_formationaudioid] = this.m_formationaudioid;
			if (this.m_Team != null)
			{
				r.IntField[FI.formations_teamid] = this.m_Team.Id;
				r.IntField[FI.formations_formationfullnameid] = -1;
			}
			else
			{
				r.IntField[FI.formations_teamid] = -1;
				if (this.m_formationname == this.m_formationfullname && this.m_formationname.Length == 5)
				{
					r.IntField[FI.formations_formationfullnameid] = -1;
				}
				else
				{
					r.IntField[FI.formations_formationfullnameid] = this.m_formationfullnameid;
				}
			}
			r.IntField[FI.formations_offensiverating] = this.m_offensiverating;
			r.FloatField[FI.formations_defenders] = this.m_defenders;
			r.FloatField[FI.formations_midfielders] = this.m_midfielders;
			r.FloatField[FI.formations_attackers] = this.m_attackers;
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].Save(r, i);
			}
			this.SaveLanguage();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001FA02 File Offset: 0x0001DC02
		public void SaveLanguage()
		{
			if (this.m_formationfullnameid != -1 && FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetFormationString(this.m_formationfullnameid, this.m_formationfullname);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001FA2A File Offset: 0x0001DC2A
		public static string RoleToString(ERole role)
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString((int)role);
			}
			return string.Empty;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001FA44 File Offset: 0x0001DC44
		public int ComputeDistance(Formation formation)
		{
			int num = 0;
			for (int i = 0; i < 11; i++)
			{
				num += Math.Abs(this.m_PlayingRoles[i].Role.RoleId - formation.PlayingRoles[i].Role.RoleId);
			}
			return num;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001FA90 File Offset: 0x0001DC90
		public int ComputeSimilarity(Formation formation)
		{
			int num = 0;
			int[] array = new int[11];
			bool[] array2 = new bool[11];
			for (int i = 0; i < 11; i++)
			{
				array[i] = 1;
				array2[i] = false;
			}
			for (int j = 0; j < 11; j++)
			{
				array[j] = 1;
				for (int k = 0; k < 11; k++)
				{
					if (this.m_PlayingRoles[j].Role.RoleId == formation.PlayingRoles[k].Role.RoleId)
					{
						array[j] = 0;
						array2[k] = true;
						break;
					}
				}
			}
			for (int l = 0; l < 11; l++)
			{
				if (array[l] != 0)
				{
					for (int m = 0; m < 11; m++)
					{
						if (!array2[m])
						{
							array2[m] = true;
							num += Math.Abs(this.m_PlayingRoles[l].Role.RoleId - formation.PlayingRoles[m].Role.RoleId);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001FB82 File Offset: 0x0001DD82
		public void LinkTeam(Team team)
		{
			if (team != null)
			{
				this.Team = team;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001FB90 File Offset: 0x0001DD90
		public void LinkRoles(RoleList roleList)
		{
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].LinkRole(roleList);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		public bool IsRoleUsed(ERole eRole)
		{
			for (int i = 0; i < 11; i++)
			{
				Role role = this.m_PlayingRoles[i].Role;
				if (this.m_PlayingRoles[i].Role != null && this.m_PlayingRoles[i].Role.RoleId == eRole)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000DE1 RID: 3553
		private PlayingRole[] m_PlayingRoles = new PlayingRole[11];

		// Token: 0x04000DE2 RID: 3554
		private Team m_Team;

		// Token: 0x04000DE3 RID: 3555
		private string m_formationname;

		// Token: 0x04000DE4 RID: 3556
		private string m_formationfullname;

		// Token: 0x04000DE5 RID: 3557
		private int m_teamid;

		// Token: 0x04000DE6 RID: 3558
		private int m_relativeformationid;

		// Token: 0x04000DE7 RID: 3559
		private int m_formations_issweeper;

		// Token: 0x04000DE8 RID: 3560
		private int m_offensiverating;

		// Token: 0x04000DE9 RID: 3561
		private int m_formationfullnameid;

		// Token: 0x04000DEA RID: 3562
		private int m_formationaudioid;

		// Token: 0x04000DEB RID: 3563
		private float m_defenders;

		// Token: 0x04000DEC RID: 3564
		private float m_midfielders;

		// Token: 0x04000DED RID: 3565
		private float m_attackers;
	}
}
