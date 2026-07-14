using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008C RID: 140
	public class Trophy : Compobj
	{
		// Token: 0x06000D6A RID: 3434 RVA: 0x0004AC68 File Offset: 0x00048E68
		public override string ToString()
		{
			if (this.m_LongName != null && this.m_LongName != string.Empty)
			{
				return this.m_LongName;
			}
			if (this.m_ShortName != null && this.m_ShortName != string.Empty)
			{
				return this.m_ShortName;
			}
			return "Trophy n. " + base.Settings.m_asset_id.ToString();
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0004ACD1 File Offset: 0x00048ED1
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0004ACD9 File Offset: 0x00048ED9
		public int ballid
		{
			get
			{
				return this.m_ballid;
			}
			set
			{
				this.m_ballid = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0004ACE2 File Offset: 0x00048EE2
		public Nation Nation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 2)
				{
					return (Nation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0004A89F File Offset: 0x00048A9F
		public Confederation Confederation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 1)
				{
					return (Confederation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0004ACFF File Offset: 0x00048EFF
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x0004AD07 File Offset: 0x00048F07
		public string ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0004AD10 File Offset: 0x00048F10
		public bool SetLanguageName(string languageName)
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				FifaEnvironment.Language.SetString(base.Description, languageName);
				return true;
			}
			return false;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0004AD35 File Offset: 0x00048F35
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0004AD3D File Offset: 0x00048F3D
		public string LongName
		{
			get
			{
				return this.m_LongName;
			}
			set
			{
				this.m_LongName = value;
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0004AD48 File Offset: 0x00048F48
		public override void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			if (base.Settings.m_info_league_promo >= 0)
			{
				base.Settings.LeaguePromo = (League)leagueList.SearchId(base.Settings.m_info_league_promo);
			}
			else
			{
				base.Settings.LeaguePromo = null;
			}
			if (base.Settings.m_info_league_releg >= 0)
			{
				base.Settings.LeagueReleg = (League)leagueList.SearchId(base.Settings.m_info_league_releg);
				return;
			}
			base.Settings.LeagueReleg = null;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0004ADD4 File Offset: 0x00048FD4
		public override void LinkTeam(TeamList teamList)
		{
			for (int i = 0; i < this.m_InitTeamArray.Length; i++)
			{
				if (this.m_InitTeamArray[i] != null)
				{
					this.m_InitTeamArray[i].LinkTeam(teamList);
				}
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0004AE0C File Offset: 0x0004900C
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0004AE14 File Offset: 0x00049014
		public InitTeam[] InitTeamArray
		{
			get
			{
				return this.m_InitTeamArray;
			}
			set
			{
				this.m_InitTeamArray = value;
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0004AE20 File Offset: 0x00049020
		public Trophy(int id, string typeString, string description, Compobj parentObj)
			: base(id, 3, typeString, description, parentObj)
		{
			this.m_Stages = new StageList();
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0004AE74 File Offset: 0x00049074
		public void FillFromCompetition(Table t)
		{
			this.m_ballid = -1;
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				if (record.GetAndCheckIntField(FI.competition_competitionid) == base.Settings.m_asset_id)
				{
					this.m_ballid = record.GetAndCheckIntField(FI.competition_ballid);
					return;
				}
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0004AECC File Offset: 0x000490CC
		public void SaveCompetition(Record r)
		{
			if (this.m_ballid >= 0)
			{
				r.IntField[FI.competition_competitionid] = base.Settings.m_asset_id;
				r.IntField[FI.competition_ballid] = this.m_ballid;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0004AF00 File Offset: 0x00049100
		public override bool SaveToInitteams(StreamWriter w)
		{
			for (int i = 0; i < this.m_NEndTasks; i++)
			{
				Task task = this.m_EndTask[i];
				if (task.Action == "UpdateTable")
				{
					int num = task.Parameter3 - 1;
					InitTeam initTeam = this.m_InitTeamArray[num];
					if (initTeam != null)
					{
						string text;
						if (initTeam.teamid >= 0)
						{
							text = string.Concat(new string[]
							{
								base.Id.ToString(),
								",",
								num.ToString(),
								",",
								initTeam.teamid.ToString()
							});
						}
						else
						{
							text = base.Id.ToString() + "," + num.ToString() + ",-1";
						}
						w.WriteLine(text);
					}
				}
			}
			return true;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0004AFE4 File Offset: 0x000491E4
		public override bool SaveToCompids(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text = base.Id.ToString();
			w.WriteLine(text);
			return true;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0004B010 File Offset: 0x00049210
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
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

		// Token: 0x06000D7E RID: 3454 RVA: 0x0004B064 File Offset: 0x00049264
		public static int AutoAsset()
		{
			for (int i = 1; i < 9999; i++)
			{
				bool flag = false;
				IEnumerator enumerator = FifaEnvironment.CompetitionObjects.GetEnumerator(); using (enumerator as IDisposable)
				{
					while (enumerator.MoveNext())
					{
						if (((Compobj)enumerator.Current).Settings.m_asset_id == i)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					IEnumerator enumerator2 = FifaEnvironment.Leagues.GetEnumerator(); using (enumerator2 as IDisposable)
					{
						while (enumerator2.MoveNext())
						{
							if (((League)enumerator2.Current).Id == i)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						return i;
					}
				}
			}
			return 0;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0004B134 File Offset: 0x00049334
		public override bool FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				string text = base.TypeString.Substring(1);
				int num;
				try
				{
					num = Convert.ToInt32(text);
				}
				catch
				{
					this.m_ShortName = string.Empty;
					this.m_LongName = string.Empty;
					return false;
				}
				this.m_ShortName = FifaEnvironment.Language.GetTournamentString(num, Language.ETournamentStringType.Abbr15);
				this.m_LongName = FifaEnvironment.Language.GetTournamentString(num, Language.ETournamentStringType.Full);
				if (this.m_LongName == null && this.m_ShortName == null)
				{
					this.m_ShortName = FifaEnvironment.Language.GetString(base.Description);
				}
				if (this.m_LongName == null)
				{
					this.m_LongName = string.Empty;
				}
				if (this.m_ShortName == null)
				{
					this.m_ShortName = string.Empty;
				}
				if (this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
				}
				if (!(this.m_ShortName == string.Empty))
				{
					return true;
				}
				if (this.m_LongName.Length > 15)
				{
					this.m_ShortName = this.m_LongName.Substring(0, 15);
					return true;
				}
				this.m_ShortName = this.m_LongName;
				return true;
			}
			this.m_ShortName = string.Empty;
			this.m_LongName = string.Empty;
			return true;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0004B27C File Offset: 0x0004947C
		public override bool SaveToLanguage()
		{
			int num = Convert.ToInt32(base.TypeString.Substring(1));
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetTournamentString(num, Language.ETournamentStringType.Abbr15, this.m_ShortName);
				FifaEnvironment.Language.SetTournamentString(num, Language.ETournamentStringType.Full, this.m_LongName);
				return true;
			}
			return false;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0004B2CC File Offset: 0x000494CC
		public bool InsertStage(int stageIndex)
		{
			if (stageIndex > base.Stages.Count)
			{
				return false;
			}
			string text = "S" + (stageIndex + 1).ToString();
			Stage stage = new Stage(FifaEnvironment.CompetitionObjects.GetNewId(), text, "FCE_Setup_Stage", this);
			if (stage == null)
			{
				return false;
			}
			stage.Settings.m_match_stagetype = "SETUP";
			base.Stages.Insert(stageIndex, stage);
			FifaEnvironment.CompetitionObjects.Add(stage);
			for (int i = 0; i < base.Stages.Count; i++)
			{
				text = "S" + (i + 1).ToString();
				((Stage)base.Stages[i]).TypeString = text;
			}
			return true;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0004B388 File Offset: 0x00049588
		public bool RemoveStage(Stage stage)
		{
			int num = base.Stages.IndexOf(stage);
			if (num < 0)
			{
				return false;
			}
			this.RemoveStage(num);
			return true;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0004B3B4 File Offset: 0x000495B4
		public bool RemoveStage(int stageIndex)
		{
			if (stageIndex > base.Stages.Count)
			{
				return false;
			}
			Stage stage = (Stage)base.Stages[stageIndex];
			base.Stages.RemoveAt(stageIndex);
			FifaEnvironment.CompetitionObjects.RemoveId(stage);
			for (int i = 0; i < base.Stages.Count; i++)
			{
				string text = "S" + (i + 1).ToString();
				((Stage)base.Stages[i]).TypeString = text;
			}
			return true;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0004B440 File Offset: 0x00049640
		public bool AddStage()
		{
			string text = "S" + (base.Stages.Count + 1).ToString();
			Stage stage = new Stage(FifaEnvironment.CompetitionObjects.GetNewId(), text, string.Empty, this);
			if (stage == null)
			{
				return false;
			}
			base.Stages.Add(stage);
			FifaEnvironment.CompetitionObjects.Add(stage);
			return true;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0004B4A4 File Offset: 0x000496A4
		public bool RemoveStage()
		{
			if (base.Stages.Count < 1)
			{
				return false;
			}
			Stage stage = (Stage)base.Stages[base.Stages.Count - 1];
			base.Stages.Remove(stage);
			FifaEnvironment.CompetitionObjects.Remove(stage);
			stage.RemoveAllGroups();
			return true;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0004B500 File Offset: 0x00049700
		public bool RemoveAllStages()
		{
			int count = base.Stages.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveStage();
			}
			return true;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0004B530 File Offset: 0x00049730
		public override void Normalize()
		{
			if (base.Settings.m_match_matchsituation != null)
			{
				foreach (object obj in this.m_Stages)
				{
					Stage stage = (Stage)obj;
					if (stage.Settings.m_match_stagetype != "SETUP" && stage.Settings.m_match_matchsituation == null)
					{
						stage.Settings.m_match_matchsituation = base.Settings.m_match_matchsituation;
					}
				}
				base.Settings.m_match_matchsituation = null;
			}
			if (base.Settings.m_N_endruleko1leg != 0)
			{
				foreach (object obj2 in this.m_Stages)
				{
					Stage stage2 = (Stage)obj2;
					if (stage2.Settings.m_match_stagetype != "SETUP")
					{
						for (int i = 0; i < base.Settings.m_N_endruleko1leg; i++)
						{
							if (base.Settings.m_match_endruleko1leg[i] != null && stage2.Settings.m_match_endruleko1leg[i] == null)
							{
								stage2.Settings.m_match_endruleko1leg[i] = base.Settings.m_match_endruleko1leg[i];
							}
						}
					}
				}
				for (int j = 0; j < base.Settings.m_N_endruleko1leg; j++)
				{
					base.Settings.m_match_endruleko1leg[j] = null;
				}
				base.Settings.m_N_endruleko1leg = 0;
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void LinkTaskGroup()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0004B6CC File Offset: 0x000498CC
		public override void LinkCompetitions()
		{
			Trophy trophyCompdependency = base.Settings.TrophyCompdependency;
			Trophy trophyForcecomp = base.Settings.TrophyForcecomp;
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkTrophy(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkTrophy(this);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0004B730 File Offset: 0x00049930
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

		// Token: 0x06000D8B RID: 3467 RVA: 0x0004B7E8 File Offset: 0x000499E8
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

		// Token: 0x06000D8C RID: 3468 RVA: 0x0004B864 File Offset: 0x00049A64
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

		// Token: 0x06000D8D RID: 3469 RVA: 0x0004B964 File Offset: 0x00049B64
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0004B990 File Offset: 0x00049B90
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

		// Token: 0x06000D8F RID: 3471 RVA: 0x0004BA24 File Offset: 0x00049C24
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0004BA4D File Offset: 0x00049C4D
		public bool RemoveTask(Task task)
		{
			return this.RemoveTask(task.When, task.Action, task.Parameter1, task.Parameter2, task.Parameter3);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0004BA73 File Offset: 0x00049C73
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

		// Token: 0x06000D92 RID: 3474 RVA: 0x0004BAB0 File Offset: 0x00049CB0
		public bool ReplaceTask(Task currentTask, Task newTask)
		{
			int num = this.SearchTaskIndex(currentTask.When, currentTask.Action, currentTask.Parameter1, currentTask.Parameter2, currentTask.Parameter3);
			return num >= 0 && this.ReplaceTask(newTask, num);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004BAF0 File Offset: 0x00049CF0
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

		// Token: 0x06000D94 RID: 3476 RVA: 0x0004BB24 File Offset: 0x00049D24
		public void CopyTasks(Trophy newTrophy, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newTrophy.AddTask(this.m_StartTask[i].CopyTask(newTrophy, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newTrophy.AddTask(this.m_EndTask[j].CopyTask(newTrophy, targetLeague));
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0004BB7F File Offset: 0x00049D7F
		public static string TrophyDdsFileName(int id)
		{
			return "data/ui/imgassets/trophy/t" + id.ToString() + ".dds";
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0004BB97 File Offset: 0x00049D97
		public string TrophyTemplateFileName()
		{
			return "data/ui/imgassets/trophy/t#.dds";
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0004BB9E File Offset: 0x00049D9E
		public string TrophyDdsFileName()
		{
			return Trophy.TrophyDdsFileName(base.Settings.m_asset_id);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0004BBB0 File Offset: 0x00049DB0
		public Bitmap GetTrophy()
		{
			return FifaEnvironment.GetDdsArtasset(this.TrophyDdsFileName());
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0004BBBD File Offset: 0x00049DBD
		public bool SetTrophy(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TrophyTemplateFileName(), base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0004BBDB File Offset: 0x00049DDB
		public bool DeleteTrophy()
		{
			return FifaEnvironment.DeleteFromZdata(this.TrophyDdsFileName());
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		public Bitmap GetAdboard()
		{
			return Adboard.GetRevModTournamentAdboard(base.Settings.m_asset_id);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0004BBFA File Offset: 0x00049DFA
		public bool SetAdboard(Bitmap bitmap)
		{
			return bitmap != null && Adboard.SetRevModTournamentAdboard(base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0004BC12 File Offset: 0x00049E12
		public bool DeleteAdboard()
		{
			return Adboard.DeleteRevModTournamentAdboard(base.Settings.m_asset_id);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0004BC24 File Offset: 0x00049E24
		private static string PitchDressingFileName(int assetId)
		{
			return "data/sceneassets/tournament/tournament_" + assetId.ToString() + "_0.rx3";
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0004BC3C File Offset: 0x00049E3C
		public Bitmap GetPitchDressing()
		{
			return FifaEnvironment.GetBmpFromRx3(Trophy.PitchDressingFileName(base.Settings.m_asset_id), false);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0004BC54 File Offset: 0x00049E54
		public bool SetPitchDressing(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/tournament/tournament_#_0.rx3", base.Settings.m_asset_id, bitmap, ECompressionMode.None, Trophy.PitchDressingSignature(base.Settings.m_asset_id));
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0004BC7D File Offset: 0x00049E7D
		public bool DeletePitchDressing()
		{
			return FifaEnvironment.DeleteFromZdata(Trophy.PitchDressingFileName(base.Settings.m_asset_id));
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0004BC94 File Offset: 0x00049E94
		public static Rx3Signatures PitchDressingSignature(int id)
		{
			return new Rx3Signatures(349856, 32, new string[] { "tournament_" + id.ToString() });
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0004BCC9 File Offset: 0x00049EC9
		public static string TrophyDdsFileName256(int id)
		{
			return "data/ui/imgassets/trophy256x256/t" + id.ToString() + ".dds";
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0004BCE1 File Offset: 0x00049EE1
		public string TrophyTemplateFileName256()
		{
			return "data/ui/imgassets/trophy256x256/t#.dds";
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0004BCE8 File Offset: 0x00049EE8
		public string TrophyDdsFileName256()
		{
			return Trophy.TrophyDdsFileName256(base.Settings.m_asset_id);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0004BCFA File Offset: 0x00049EFA
		public Bitmap GetTrophy256()
		{
			return FifaEnvironment.GetDdsArtasset(this.TrophyDdsFileName256());
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0004BD07 File Offset: 0x00049F07
		public bool SetTrophy256(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TrophyTemplateFileName256(), base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0004BD25 File Offset: 0x00049F25
		public bool DeleteTrophy256()
		{
			return FifaEnvironment.DeleteFromZdata(this.TrophyDdsFileName256());
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0004BD32 File Offset: 0x00049F32
		public static string TrophyDdsFileName128(int id)
		{
			return "data/ui/imgassets/trophy128x128/t" + id.ToString() + ".dds";
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0004BD4A File Offset: 0x00049F4A
		public string TrophyTemplateFileName128()
		{
			return "data/ui/imgassets/trophy128x128/t#.dds";
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0004BD51 File Offset: 0x00049F51
		public string TrophyDdsFileName128()
		{
			return Trophy.TrophyDdsFileName128(base.Settings.m_asset_id);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0004BD63 File Offset: 0x00049F63
		public Bitmap GetTrophy128()
		{
			return FifaEnvironment.GetDdsArtasset(this.TrophyDdsFileName128());
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0004BD70 File Offset: 0x00049F70
		public bool SetTrophy128(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TrophyTemplateFileName128(), base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0004BD8E File Offset: 0x00049F8E
		public bool DeleteTrophy128()
		{
			return FifaEnvironment.DeleteFromZdata(this.TrophyDdsFileName128());
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0004BD9B File Offset: 0x00049F9B
		public static string TexturesFileName(int id)
		{
			return "data/sceneassets/trophy/trophy_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0004BDB3 File Offset: 0x00049FB3
		public string TexturesFileName()
		{
			return Trophy.TexturesFileName(base.Settings.m_asset_id);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0004BDC5 File Offset: 0x00049FC5
		public string TexturesTemplateFileName()
		{
			return "data/sceneassets/trophy/trophy_#_textures.rx3";
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0004BDCC File Offset: 0x00049FCC
		public Bitmap[] GetTextures()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.TexturesFileName());
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0004BDD9 File Offset: 0x00049FD9
		public bool SetTextures(Bitmap[] bitmaps)
		{
			return bitmaps != null && FifaEnvironment.ImportBmpsIntoZdata(this.TexturesTemplateFileName(), base.Settings.m_asset_id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0004BDF8 File Offset: 0x00049FF8
		public bool SetTextures(string rx3FileName)
		{
			return rx3FileName != null && FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.TexturesFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0004BE0D File Offset: 0x0004A00D
		public bool DeleteContainer(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.TexturesFileName());
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004BE1A File Offset: 0x0004A01A
		public static string ModelFileName(int trophyId)
		{
			return "data/sceneassets/trophy/trophy_" + trophyId.ToString() + ".rx3";
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0004BE32 File Offset: 0x0004A032
		public string ModelFileName()
		{
			return Trophy.ModelFileName(base.Settings.m_asset_id);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0004BE44 File Offset: 0x0004A044
		public string ModelTemplateFileName()
		{
			return "data/sceneassets/trophy/trophy_#.rx3";
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0004BE4B File Offset: 0x0004A04B
		public Rx3File GetModel()
		{
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			return FifaEnvironment.GetRx3FromZdata(this.ModelFileName());
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0004BE5E File Offset: 0x0004A05E
		public string ExportModelFile()
		{
			if (FifaEnvironment.ExportFileFromZdata(this.ModelFileName(), FifaEnvironment.ExportFolder))
			{
				return FifaEnvironment.ExportFolder + "\\" + this.ModelFileName();
			}
			return null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0004BE89 File Offset: 0x0004A089
		public bool SetModel(string rx3FileName)
		{
			return rx3FileName != null && FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0004BE9E File Offset: 0x0004A09E
		public bool DeleteModel()
		{
			return FifaEnvironment.DeleteFromZdata(this.ModelFileName());
		}

		// Token: 0x04001102 RID: 4354
		private int m_ballid = -1;

		// Token: 0x04001103 RID: 4355
		private string m_ShortName;

		// Token: 0x04001104 RID: 4356
		private string m_LongName;

		// Token: 0x04001105 RID: 4357
		private InitTeam[] m_InitTeamArray = new InitTeam[24];

		// Token: 0x04001106 RID: 4358
		public Task[] m_StartTask = new Task[24];

		// Token: 0x04001107 RID: 4359
		public int m_NStartTasks;

		// Token: 0x04001108 RID: 4360
		public Task[] m_EndTask = new Task[24];

		// Token: 0x04001109 RID: 4361
		public int m_NEndTasks;
	}
}
