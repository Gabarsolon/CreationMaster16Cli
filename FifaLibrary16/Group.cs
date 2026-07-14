using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000090 RID: 144
	public class Group : Compobj
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004C984 File Offset: 0x0004AB84
		public override string ToString()
		{
			if (this.m_LanguageName != null && this.m_LanguageName != string.Empty)
			{
				return this.m_LanguageName;
			}
			if (base.Description == null || !(base.Description != string.Empty) || !(base.Description != " "))
			{
				return base.TypeString;
			}
			if (!base.Description.StartsWith("FCE_"))
			{
				return base.Description.Replace('_', ' ');
			}
			return base.Description.Substring(4).Replace('_', ' ');
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0004CA1C File Offset: 0x0004AC1C
		public Stage ParentStage
		{
			get
			{
				if (base.ParentObj.IsStage())
				{
					return (Stage)base.ParentObj;
				}
				if (base.ParentObj.IsGroup() && base.ParentObj.ParentObj.IsStage())
				{
					return (Stage)base.ParentObj.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0004CA73 File Offset: 0x0004AC73
		public Trophy ParentTrophy
		{
			get
			{
				if (this.ParentStage.ParentObj.IsTrophy())
				{
					return (Trophy)this.ParentStage.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0004CA99 File Offset: 0x0004AC99
		public GroupList SubGroups
		{
			get
			{
				return this.m_SubGroups;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0004CAA1 File Offset: 0x0004ACA1
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0004CAA9 File Offset: 0x0004ACA9
		public ScheduleArray Schedules
		{
			get
			{
				return this.m_Schedule;
			}
			set
			{
				this.m_Schedule = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0004CAB2 File Offset: 0x0004ACB2
		public int NSchedule
		{
			get
			{
				return this.m_Schedule.Count;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0004CABF File Offset: 0x0004ACBF
		public RankList Ranks
		{
			get
			{
				return this.m_Ranks;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0004CAC7 File Offset: 0x0004ACC7
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x0004CACF File Offset: 0x0004ACCF
		public string LanguageName
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0004CAD8 File Offset: 0x0004ACD8
		public Group(int id, string typeString, string description, Compobj parentObj)
			: base(id, 5, typeString, description, parentObj)
		{
			this.m_ConventionalDescription = description;
			this.m_Ranks = new RankList();
			Rank rank = new Rank(this, 0);
			this.m_Ranks.Add(rank);
			this.m_Groups = new GroupList();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0004CB23 File Offset: 0x0004AD23
		public void AddSchedule(Schedule schedule)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(256);
				this.m_NSchedule = 0;
			}
			this.m_Schedule.AddSchedule(schedule);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0004CB50 File Offset: 0x0004AD50
		public Schedule[] GetLegSchedule(int legId)
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLegSchedule(legId);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0004CB68 File Offset: 0x0004AD68
		public Schedule[] GetLastLegSchedule()
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLastLegSchedule();
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0004CB7F File Offset: 0x0004AD7F
		public bool RemoveLastLeg()
		{
			return this.m_Schedule != null && this.m_Schedule.RemoveLastLeg();
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0004CB96 File Offset: 0x0004AD96
		public Schedule AppendLeg(int dayDelay)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(8);
			}
			return this.m_Schedule.AppendLeg(this, dayDelay);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0004CBB9 File Offset: 0x0004ADB9
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.CloneSchedule(originalSchedule, timeDelay);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0004CBD1 File Offset: 0x0004ADD1
		public void DeleteSchedule(Schedule originalSchedule)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.DeleteSchedule(originalSchedule);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0004CBEC File Offset: 0x0004ADEC
		public override bool SaveToStandings(StreamWriter w)
		{
			for (int i = 1; i < this.m_Ranks.Count; i++)
			{
				Rank rank = (Rank)this.m_Ranks[i];
				string text = base.Id.ToString() + "," + (rank.Id - 1).ToString();
				w.WriteLine(text);
			}
			return true;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0004CC54 File Offset: 0x0004AE54
		public override bool SaveToAdvancement(StreamWriter w)
		{
			for (int i = 1; i < this.m_Ranks.Count; i++)
			{
				Rank rank = (Rank)this.m_Ranks[i];
				if (rank.MoveFrom != null)
				{
					string text = string.Concat(new string[]
					{
						rank.MoveFrom.Group.Id.ToString(),
						",",
						rank.MoveFrom.Id.ToString(),
						",",
						base.Id.ToString(),
						",",
						rank.Id.ToString()
					});
					w.WriteLine(text);
				}
			}
			return true;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0004CD16 File Offset: 0x0004AF16
		public override bool SaveToSchedule(StreamWriter w)
		{
			return this.m_Schedule != null && this.m_Schedule.SaveToSchedule(w);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0004CD30 File Offset: 0x0004AF30
		public override void LinkCompetitions()
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkGroup(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkGroup(this);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0004CD7C File Offset: 0x0004AF7C
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.ParentTrophy == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].SaveToTasks(w);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].SaveToTasks(w);
			}
			return true;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0004CDDC File Offset: 0x0004AFDC
		public override bool FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				if (this.m_ConventionalDescription != null && this.m_ConventionalDescription != string.Empty && this.m_ConventionalDescription != " ")
				{
					this.m_LanguageName = FifaEnvironment.Language.GetString(this.m_ConventionalDescription);
					if (this.m_LanguageName == null)
					{
						this.m_LanguageName = this.m_ConventionalDescription;
					}
				}
			}
			else
			{
				this.m_LanguageName = string.Empty;
			}
			return true;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0004CE54 File Offset: 0x0004B054
		public override bool SaveToLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetString(this.m_ConventionalDescription, this.m_LanguageName);
				return true;
			}
			return false;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0004CE78 File Offset: 0x0004B078
		public bool AddRank()
		{
			int count = this.m_Ranks.Count;
			Rank rank = new Rank(this, count);
			if (rank == null)
			{
				return false;
			}
			this.m_Ranks.Add(rank);
			return true;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0004CEAC File Offset: 0x0004B0AC
		public bool RemoveRank()
		{
			if (this.m_Ranks.Count < 1)
			{
				return false;
			}
			Rank rank = (Rank)this.m_Ranks[this.m_Ranks.Count - 1];
			this.m_Ranks.Remove(rank);
			return true;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0004CEF4 File Offset: 0x0004B0F4
		public bool RemoveAllRanks()
		{
			int count = this.m_Ranks.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveRank();
			}
			return true;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0004CF24 File Offset: 0x0004B124
		public override void Normalize()
		{
			Stage stage = null;
			if (base.Settings.Advance_pointskeep != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.Advance_pointskeep == -1)
				{
					stage.Settings.Advance_pointskeep = base.Settings.Advance_pointskeep;
				}
				base.Settings.Advance_pointskeep = -1;
			}
			if (base.Settings.m_advance_pointskeeppercentage != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_advance_pointskeeppercentage == -1)
				{
					stage.Settings.m_advance_pointskeeppercentage = base.Settings.m_advance_pointskeeppercentage;
				}
				base.Settings.m_advance_pointskeeppercentage = -1;
			}
			if (base.Settings.Advance_standingsrank != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.Advance_standingsrank == -1)
				{
					stage.Settings.Advance_standingsrank = base.Settings.Advance_standingsrank;
				}
				base.Settings.Advance_standingsrank = -1;
			}
			if (base.Settings.m_info_prize_money != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_info_prize_money == -1)
				{
					stage.Settings.m_info_prize_money = base.Settings.m_info_prize_money;
				}
				base.Settings.m_info_prize_money = -1;
			}
			if (base.Settings.m_match_canusefancards != null)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_match_canusefancards == null)
				{
					stage.Settings.m_match_canusefancards = base.Settings.m_match_canusefancards;
				}
				base.Settings.m_match_canusefancards = null;
			}
			if (base.Settings.m_match_stadium != null && base.Settings.m_match_stadium.Length != 0)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_match_stadium == null || stage.Settings.m_match_stadium.Length == 0)
				{
					stage.Settings.m_match_stadium = new int[12];
					for (int i = 0; i < stage.Settings.m_match_stadium.Length; i++)
					{
						stage.Settings.m_match_stadium[i] = -1;
					}
					for (int j = 0; j < base.Settings.m_match_stadium.Length; j++)
					{
						stage.Settings.m_match_stadium[j] = base.Settings.m_match_stadium[j];
					}
				}
				for (int k = 0; k < base.Settings.m_match_stadium.Length; k++)
				{
					base.Settings.m_match_stadium[k] = -1;
				}
			}
			if (base.Settings.m_StandingsSort != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_StandingsSort == -1)
				{
					stage.Settings.m_StandingsSort = base.Settings.m_StandingsSort;
				}
				base.Settings.m_StandingsSort = -1;
			}
			if (base.ParentObj.IsStage())
			{
				stage = (Stage)base.ParentObj;
				for (int l = 0; l < this.m_NEndTasks; l++)
				{
					if (this.m_EndTask[l].Action == "UpdateLeagueTable")
					{
						stage.AddTask(this.m_EndTask[l]);
						this.RemoveTask(this.m_EndTask[l].When, l);
						return;
					}
				}
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0004D290 File Offset: 0x0004B490
		public bool RemoveAllSchedules()
		{
			if (this.m_Schedule == null)
			{
				return false;
			}
			this.m_Schedule.Clear();
			return true;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0004D2A8 File Offset: 0x0004B4A8
		public bool AddTask(Task action)
		{
			if (action.When == "start")
			{
				if (this.m_NStartTasks == 0)
				{
					this.m_StartTask = new Task[48];
				}
				if (this.m_NStartTasks < this.m_StartTask.Length)
				{
					this.m_StartTask[this.m_NStartTasks] = action;
					this.m_NStartTasks++;
					return true;
				}
				return false;
			}
			else
			{
				if (!(action.When == "end"))
				{
					return false;
				}
				if (this.m_NEndTasks == 0)
				{
					this.m_EndTask = new Task[24];
				}
				if (this.m_NEndTasks < this.m_EndTask.Length)
				{
					this.m_EndTask[this.m_NEndTasks] = action;
					this.m_NEndTasks++;
					return true;
				}
				return false;
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004D364 File Offset: 0x0004B564
		public bool RemoveLastTask(string when)
		{
			if (when == "start")
			{
				if (this.m_NStartTasks > 0)
				{
					this.m_NStartTasks--;
					this.m_StartTask[this.m_NStartTasks] = null;
					return true;
				}
				return false;
			}
			else
			{
				if (!(when == "end"))
				{
					return false;
				}
				if (this.m_NEndTasks > 0)
				{
					this.m_NEndTasks--;
					this.m_EndTask[this.m_NEndTasks] = null;
					return true;
				}
				return false;
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		public int SearchTaskIndex(string when, string action, int par1, int par2, int par3)
		{
			if (when == "start")
			{
				for (int i = 0; i < this.m_NStartTasks; i++)
				{
					if ((action == null || this.m_StartTask[i].Action == action) && (par1 < 0 || this.m_StartTask[i].Parameter1 == par1) && (par2 < 0 || this.m_StartTask[i].Parameter2 == par2) && (par3 < 0 || this.m_StartTask[i].Parameter3 == par3))
					{
						return i;
					}
				}
			}
			else if (when == "end")
			{
				for (int j = 0; j < this.m_NEndTasks; j++)
				{
					if ((action == null || this.m_EndTask[j].Action == action) && (par1 < 0 || this.m_EndTask[j].Parameter1 == par1) && (par2 < 0 || this.m_EndTask[j].Parameter2 == par2) && (par3 < 0 || this.m_EndTask[j].Parameter3 == par3))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004D4E0 File Offset: 0x0004B6E0
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004D50C File Offset: 0x0004B70C
		public bool RemoveTask(string when, int index)
		{
			if (when == "start")
			{
				if (index < this.m_NStartTasks)
				{
					this.m_NStartTasks--;
					for (int i = index; i < this.m_NStartTasks; i++)
					{
						this.m_StartTask[i] = this.m_StartTask[i + 1];
					}
					return true;
				}
			}
			else if (index < this.m_NEndTasks)
			{
				this.m_NEndTasks--;
				for (int j = index; j < this.m_NEndTasks; j++)
				{
					this.m_EndTask[j] = this.m_EndTask[j + 1];
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004D5A0 File Offset: 0x0004B7A0
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0004D5C9 File Offset: 0x0004B7C9
		public bool ReplaceTask(Task task, int index)
		{
			if (task.When == "start")
			{
				if (index < this.m_NStartTasks)
				{
					this.m_StartTask[index] = task;
					return true;
				}
			}
			else if (index < this.m_NEndTasks)
			{
				this.m_EndTask[index] = task;
				return true;
			}
			return false;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0004D606 File Offset: 0x0004B806
		public Task GetTask(string when, int index)
		{
			if (when == "start")
			{
				if (index < this.m_NStartTasks)
				{
					return this.m_StartTask[index];
				}
			}
			else if (index < this.m_NEndTasks)
			{
				return this.m_EndTask[index];
			}
			return null;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0004D63C File Offset: 0x0004B83C
		public void CopyTasks(Group newGroup, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newGroup.AddTask(this.m_StartTask[i].CopyTask(newGroup, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newGroup.AddTask(this.m_EndTask[j].CopyTask(newGroup, targetLeague));
			}
		}

		// Token: 0x04001111 RID: 4369
		private GroupList m_SubGroups;

		// Token: 0x04001112 RID: 4370
		private ScheduleArray m_Schedule;

		// Token: 0x04001113 RID: 4371
		private int m_NSchedule;

		// Token: 0x04001114 RID: 4372
		private RankList m_Ranks;

		// Token: 0x04001115 RID: 4373
		private string m_ConventionalDescription;

		// Token: 0x04001116 RID: 4374
		private string m_LanguageName;

		// Token: 0x04001117 RID: 4375
		public Task[] m_StartTask;

		// Token: 0x04001118 RID: 4376
		public int m_NStartTasks;

		// Token: 0x04001119 RID: 4377
		public Task[] m_EndTask;

		// Token: 0x0400111A RID: 4378
		public int m_NEndTasks;
	}
}
