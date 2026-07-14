using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000085 RID: 133
	public class Compobj : IdObject
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x00046964 File Offset: 0x00044B64
		public override string ToString()
		{
			return this.m_TypeString;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0004696C File Offset: 0x00044B6C
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00046974 File Offset: 0x00044B74
		public Compobj ParentObj
		{
			get
			{
				return this.m_ParentObj;
			}
			set
			{
				this.m_ParentObj = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0004697D File Offset: 0x00044B7D
		public ConfederationList Confederations
		{
			get
			{
				return this.m_Confederations;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00046985 File Offset: 0x00044B85
		public NationList Nations
		{
			get
			{
				return this.m_Nations;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0004698D File Offset: 0x00044B8D
		public TrophyList Trophies
		{
			get
			{
				return this.m_Trophies;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x00046995 File Offset: 0x00044B95
		public StageList Stages
		{
			get
			{
				return this.m_Stages;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0004699D File Offset: 0x00044B9D
		public GroupList Groups
		{
			get
			{
				return this.m_Groups;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000469A5 File Offset: 0x00044BA5
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000469AD File Offset: 0x00044BAD
		public int TypeNumber
		{
			get
			{
				return this.m_TypeNumber;
			}
			set
			{
				this.m_TypeNumber = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00046964 File Offset: 0x00044B64
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000469B6 File Offset: 0x00044BB6
		public string TypeString
		{
			get
			{
				return this.m_TypeString;
			}
			set
			{
				this.m_TypeString = value;
			}
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x000469BF File Offset: 0x00044BBF
		public bool IsWorld()
		{
			return this.m_TypeNumber == 0;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000469CA File Offset: 0x00044BCA
		public bool IsConfederation()
		{
			return this.m_TypeNumber == 1;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000469D5 File Offset: 0x00044BD5
		public bool IsNation()
		{
			return this.m_TypeNumber == 2;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000469E0 File Offset: 0x00044BE0
		public bool IsTrophy()
		{
			return this.m_TypeNumber == 3;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000469EB File Offset: 0x00044BEB
		public bool IsStage()
		{
			return this.m_TypeNumber == 4;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000469F6 File Offset: 0x00044BF6
		public bool IsGroup()
		{
			return this.m_TypeNumber == 5;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00046A01 File Offset: 0x00044C01
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x00046A09 File Offset: 0x00044C09
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00046A12 File Offset: 0x00044C12
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x00046A1A File Offset: 0x00044C1A
		public CompetitionSettings Settings
		{
			get
			{
				return this.m_CompetitionSettings;
			}
			set
			{
				this.m_CompetitionSettings = value;
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00046A23 File Offset: 0x00044C23
		public Compobj(int id, int typeNumber, string typeString, string description, Compobj parentObj)
			: base(id)
		{
			this.m_TypeString = typeString;
			this.m_TypeNumber = typeNumber;
			this.m_Description = description;
			this.m_ParentObj = parentObj;
			this.m_CompetitionSettings = new CompetitionSettings(this);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00046A58 File Offset: 0x00044C58
		public bool AddChild(Compobj childObject)
		{
			switch (childObject.TypeNumber)
			{
			case 1:
				this.m_Confederations.InsertId(childObject);
				break;
			case 2:
				this.m_Nations.InsertId(childObject);
				break;
			case 3:
				this.m_Trophies.InsertId(childObject);
				break;
			case 4:
				this.m_Stages.InsertId(childObject);
				break;
			case 5:
				this.m_Groups.InsertId(childObject);
				break;
			}
			return true;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00046AD6 File Offset: 0x00044CD6
		public void SetProperty(string property, string val)
		{
			this.m_CompetitionSettings.LoadProperty(property, val);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00046AE8 File Offset: 0x00044CE8
		public int Renumber(int id)
		{
			base.Id = id;
			id++;
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						id = trophy.Renumber(id);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					id = ((Confederation)obj2).Renumber(id);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					id = nation.Renumber(id);
					nation.Settings.m_rule_suspension = nation.Id;
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					id = stage.Renumber(id);
					stage.Settings.UpdateIdUsingStageReference();
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					id = ((Group)obj5).Renumber(id);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						id = trophy2.Renumber(id);
					}
				}
			}
			return id;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00046D3C File Offset: 0x00044F3C
		public bool SaveToCompobj(StreamWriter w)
		{
			int num = ((this.ParentObj != null) ? this.ParentObj.Id : (-1));
			string text = string.Concat(new object[]
			{
				base.Id.ToString(),
				",",
				this.m_TypeNumber,
				",",
				this.m_TypeString,
				",",
				this.m_Description,
				",",
				num
			});
			w.WriteLine(text);
			return true;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00046DD0 File Offset: 0x00044FD0
		public bool SaveRecursivelyToCompobj(StreamWriter w)
		{
			this.SaveToCompobj(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToCompobj(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToCompobj(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToCompids(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00046FF8 File Offset: 0x000451F8
		public bool SaveRecursivelyToCompids(StreamWriter w)
		{
			this.SaveToCompids(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToCompids(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToCompids(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToCompids(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj4 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj4;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToCompids(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00047180 File Offset: 0x00045380
		public bool SaveToSettings(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			this.m_CompetitionSettings.SaveToSettings(base.Id, w);
			return true;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0004719C File Offset: 0x0004539C
		public bool SaveRecursivelyToSettings(StreamWriter w)
		{
			this.SaveToSettings(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToSettings(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToSettings(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToStandings(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000473C4 File Offset: 0x000455C4
		public bool SaveRecursivelyToStandings(StreamWriter w)
		{
			this.SaveToStandings(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToStandings(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToStandings(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToTasks(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000475EC File Offset: 0x000457EC
		public bool SaveRecursivelyToTasks(StreamWriter w)
		{
			this.SaveToTasks(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToTasks(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToTasks(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToAdvancement(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00047814 File Offset: 0x00045A14
		public bool SaveRecursivelyToAdvancement(StreamWriter w)
		{
			this.SaveToAdvancement(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToAdvancement(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToAdvancement(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToSchedule(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00047A3C File Offset: 0x00045C3C
		public bool SaveRecursivelyToSchedule(StreamWriter w)
		{
			this.SaveToSchedule(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToSchedule(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToSchedule(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToWeather(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00047C64 File Offset: 0x00045E64
		public bool SaveRecursivelyToWeather(StreamWriter w)
		{
			this.SaveToWeather(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToWeather(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToWeather(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToInitteams(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00047E8C File Offset: 0x0004608C
		public bool SaveRecursivelyToInitteams(StreamWriter w)
		{
			this.SaveToInitteams(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToInitteams(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					((Confederation)obj2).SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					((Nation)obj3).SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					((Stage)obj4).SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					((Group)obj5).SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToInitteams(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool FillFromLanguage()
		{
			return false;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00009CCD File Offset: 0x00007ECD
		public virtual bool SaveToLanguage()
		{
			return false;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void LinkLeague(LeagueList leagueList)
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void LinkTeam(TeamList teamList)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void LinkCountry(CountryList countryList)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void LinkStadium(StadiumList countryList)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void LinkCompetitions()
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public virtual void Normalize()
		{
		}

		// Token: 0x040010DC RID: 4316
		private Compobj m_ParentObj;

		// Token: 0x040010DD RID: 4317
		protected ConfederationList m_Confederations;

		// Token: 0x040010DE RID: 4318
		protected NationList m_Nations;

		// Token: 0x040010DF RID: 4319
		protected TrophyList m_Trophies;

		// Token: 0x040010E0 RID: 4320
		protected StageList m_Stages;

		// Token: 0x040010E1 RID: 4321
		protected GroupList m_Groups;

		// Token: 0x040010E2 RID: 4322
		private int m_TypeNumber;

		// Token: 0x040010E3 RID: 4323
		private string m_TypeString;

		// Token: 0x040010E4 RID: 4324
		private string m_Description;

		// Token: 0x040010E5 RID: 4325
		private CompetitionSettings m_CompetitionSettings;
	}
}
