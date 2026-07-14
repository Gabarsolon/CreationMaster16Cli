using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008E RID: 142
	public class Stage : Compobj
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x0004BF14 File Offset: 0x0004A114
		public override string ToString()
		{
			string languageName = this.GetLanguageName();
			if (languageName != null && languageName != string.Empty)
			{
				return languageName;
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0004BFA4 File Offset: 0x0004A1A4
		public Trophy Trophy
		{
			get
			{
				if (base.ParentObj.TypeNumber == 3)
				{
					return (Trophy)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0004BFC1 File Offset: 0x0004A1C1
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x0004BFC9 File Offset: 0x0004A1C9
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0004BFD2 File Offset: 0x0004A1D2
		public int NSchedule
		{
			get
			{
				return this.m_Schedule.Count;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0004BFDF File Offset: 0x0004A1DF
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0004BFE7 File Offset: 0x0004A1E7
		public string ConventionalDescription
		{
			get
			{
				return this.m_ConventionalDescription;
			}
			set
			{
				this.m_ConventionalDescription = value;
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0004BFF0 File Offset: 0x0004A1F0
		public Stage(int id, string typeString, string description, Compobj parentObj)
			: base(id, 4, typeString, description, parentObj)
		{
			this.m_Groups = new GroupList();
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0004C00C File Offset: 0x0004A20C
		public override void LinkCompetitions()
		{
			base.Settings.UpdateStageReferenceUsingId();
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkStage(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkStage(this);
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0004C062 File Offset: 0x0004A262
		public void AddSchedule(Schedule schedule)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(256);
			}
			this.m_Schedule.AddSchedule(schedule);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0004C088 File Offset: 0x0004A288
		public Schedule[] GetLegSchedule(int legId)
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLegSchedule(legId);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		public Schedule[] GetLastLegSchedule()
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLastLegSchedule();
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0004C0B7 File Offset: 0x0004A2B7
		public bool RemoveLastLeg()
		{
			return this.m_Schedule != null && this.m_Schedule.RemoveLastLeg();
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0004C0CE File Offset: 0x0004A2CE
		public Schedule AppendLeg(int dayDelay)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(48);
			}
			return this.m_Schedule.AppendLeg(this, dayDelay);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0004C0F2 File Offset: 0x0004A2F2
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.CloneSchedule(originalSchedule, timeDelay);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0004C10A File Offset: 0x0004A30A
		public void DeleteSchedule(Schedule originalSchedule)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.DeleteSchedule(originalSchedule);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0004C122 File Offset: 0x0004A322
		public override bool SaveToSchedule(StreamWriter w)
		{
			return this.m_Schedule != null && this.m_Schedule.SaveToSchedule(w);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0004C13C File Offset: 0x0004A33C
		public string GetLanguageName()
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				string text = FifaEnvironment.Language.GetString(base.Description);
				if (text == null)
				{
					text = string.Empty;
				}
				return text;
			}
			return string.Empty;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0004AD10 File Offset: 0x00048F10
		public bool SetLanguageName(string languageName)
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				FifaEnvironment.Language.SetString(base.Description, languageName);
				return true;
			}
			return false;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0004C17C File Offset: 0x0004A37C
		public bool InsertGroup(int groupIndex)
		{
			if (groupIndex > base.Groups.Count)
			{
				return false;
			}
			string text = "G" + (groupIndex + 1).ToString();
			Group group = new Group(FifaEnvironment.CompetitionObjects.GetNewId(), text, " ", this);
			if (group == null)
			{
				return false;
			}
			base.Groups.Insert(groupIndex, group);
			FifaEnvironment.CompetitionObjects.Add(group);
			for (int i = 0; i < base.Groups.Count; i++)
			{
				text = "G" + (i + 1).ToString();
				((Group)base.Groups[i]).TypeString = text;
			}
			return true;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0004C228 File Offset: 0x0004A428
		public bool RemoveGroup(Group group)
		{
			int num = base.Groups.IndexOf(group);
			if (num < 0)
			{
				return false;
			}
			this.RemoveGroup(num);
			return true;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0004C254 File Offset: 0x0004A454
		public bool RemoveGroup(int groupIndex)
		{
			if (groupIndex > base.Groups.Count)
			{
				return false;
			}
			Group group = (Group)base.Groups[groupIndex];
			base.Groups.RemoveAt(groupIndex);
			FifaEnvironment.CompetitionObjects.RemoveId(group);
			for (int i = 0; i < base.Groups.Count; i++)
			{
				string text = "G" + (i + 1).ToString();
				((Group)base.Groups[i]).TypeString = text;
			}
			return true;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0004C2E0 File Offset: 0x0004A4E0
		public bool RemoveAllGroups()
		{
			int count = base.Groups.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveGroup(0);
			}
			return true;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0004C30E File Offset: 0x0004A50E
		public bool RemoveAllSchedules()
		{
			if (this.m_Schedule == null)
			{
				return false;
			}
			this.m_Schedule.Clear();
			return true;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public new void LinkStadium(StadiumList stadiumList)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004C328 File Offset: 0x0004A528
		public override void Normalize()
		{
			if (base.Settings.m_match_matchimportance != -1 && this.Trophy != null)
			{
				if (this.Trophy.Settings.m_match_matchimportance == -1)
				{
					this.Trophy.Settings.m_match_matchimportance = base.Settings.m_match_matchimportance;
				}
				base.Settings.m_match_matchimportance = -1;
			}
			if (base.Settings.m_N_info_color_slot_adv_group != 0 && base.Groups != null)
			{
				foreach (object obj in base.Groups)
				{
					Group group = (Group)obj;
					if (group.Settings.m_N_info_color_slot_adv_group == 0)
					{
						group.Settings.m_info_color_slot_adv_group = new int[8];
						for (int i = 0; i < base.Settings.m_N_info_color_slot_adv_group; i++)
						{
							group.Settings.m_info_color_slot_adv_group[i] = base.Settings.m_info_color_slot_adv_group[i];
						}
						group.Settings.m_N_info_color_slot_adv_group = base.Settings.m_N_info_color_slot_adv_group;
					}
				}
				base.Settings.m_N_info_color_slot_adv_group = 0;
			}
			if (base.Settings.m_match_stagetype == null)
			{
				base.Settings.m_match_stagetype = "LEAGUE";
			}
			if (base.Settings.m_match_stagetype != "SETUP" && base.Settings.m_match_matchsituation == null)
			{
				base.Settings.m_match_matchsituation = "LEAGUE";
			}
			if (base.Settings.m_num_games != -1)
			{
				foreach (object obj2 in base.Groups)
				{
					Group group2 = (Group)obj2;
					if (group2.Settings.m_num_games == -1)
					{
						group2.Settings.m_num_games = base.Settings.m_num_games;
					}
				}
				base.Settings.m_num_games = -1;
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0004C528 File Offset: 0x0004A728
		public bool AddTask(Task action)
		{
			if (action.When == "start")
			{
				if (this.m_NStartTasks == 0)
				{
					this.m_StartTask = new Task[24];
				}
				if (this.m_NStartTasks < this.m_StartTask.Length)
				{
					this.m_StartTask[this.m_NStartTasks] = action;
					this.m_NStartTasks++;
					return true;
				}
			}
			else if (action.When == "end")
			{
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
			}
			return false;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004C5E0 File Offset: 0x0004A7E0
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

		// Token: 0x06000DDB RID: 3547 RVA: 0x0004C65C File Offset: 0x0004A85C
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

		// Token: 0x06000DDC RID: 3548 RVA: 0x0004C75C File Offset: 0x0004A95C
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0004C788 File Offset: 0x0004A988
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

		// Token: 0x06000DDE RID: 3550 RVA: 0x0004C81C File Offset: 0x0004AA1C
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0004C845 File Offset: 0x0004AA45
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0004C882 File Offset: 0x0004AA82
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004C8B8 File Offset: 0x0004AAB8
		public void CopyTasks(Stage newStage, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newStage.AddTask(this.m_StartTask[i].CopyTask(newStage, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newStage.AddTask(this.m_EndTask[j].CopyTask(newStage, targetLeague));
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004C914 File Offset: 0x0004AB14
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.Trophy == null)
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

		// Token: 0x0400110A RID: 4362
		private ScheduleArray m_Schedule;

		// Token: 0x0400110B RID: 4363
		private int m_NSchedule;

		// Token: 0x0400110C RID: 4364
		private string m_ConventionalDescription;

		// Token: 0x0400110D RID: 4365
		private Task[] m_StartTask;

		// Token: 0x0400110E RID: 4366
		private int m_NStartTasks;

		// Token: 0x0400110F RID: 4367
		private Task[] m_EndTask;

		// Token: 0x04001110 RID: 4368
		private int m_NEndTasks;
	}
}
