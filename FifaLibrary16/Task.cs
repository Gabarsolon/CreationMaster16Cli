using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000097 RID: 151
	public class Task
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0004E60C File Offset: 0x0004C80C
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0004E614 File Offset: 0x0004C814
		public string When
		{
			get
			{
				return this.m_When;
			}
			set
			{
				this.m_When = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0004E61D File Offset: 0x0004C81D
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x0004E625 File Offset: 0x0004C825
		public string Action
		{
			get
			{
				return this.m_Action;
			}
			set
			{
				this.m_Action = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0004E62E File Offset: 0x0004C82E
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0004E636 File Offset: 0x0004C836
		public EQualifyingRule Rule
		{
			get
			{
				return this.m_Rule;
			}
			set
			{
				this.m_Rule = value;
				this.m_Action = this.m_Rule.ToString();
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0004E656 File Offset: 0x0004C856
		public int GroupId
		{
			get
			{
				return this.m_TargetCompObjId;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004E65E File Offset: 0x0004C85E
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0004E666 File Offset: 0x0004C866
		public int Parameter1
		{
			get
			{
				return this.m_Parameter1;
			}
			set
			{
				this.m_Parameter1 = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0004E66F File Offset: 0x0004C86F
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0004E677 File Offset: 0x0004C877
		public int Parameter2
		{
			get
			{
				return this.m_Parameter2;
			}
			set
			{
				this.m_Parameter2 = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0004E680 File Offset: 0x0004C880
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x0004E688 File Offset: 0x0004C888
		public int Parameter3
		{
			get
			{
				return this.m_Parameter3;
			}
			set
			{
				this.m_Parameter3 = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0004E691 File Offset: 0x0004C891
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0004E699 File Offset: 0x0004C899
		public Group Group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
				this.m_TargetCompObjId = this.m_Group.Id;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0004E6B3 File Offset: 0x0004C8B3
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x0004E6BB File Offset: 0x0004C8BB
		public Stage Stage
		{
			get
			{
				return this.m_Stage;
			}
			set
			{
				this.m_Stage = value;
				this.m_TargetCompObjId = this.m_Stage.Id;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0004E6D5 File Offset: 0x0004C8D5
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x0004E6DD File Offset: 0x0004C8DD
		public Trophy Trophy
		{
			get
			{
				return this.m_Trophy;
			}
			set
			{
				this.m_Trophy = value;
				this.m_TargetCompObjId = this.m_Trophy.Id;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0004E6F7 File Offset: 0x0004C8F7
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x0004E6FF File Offset: 0x0004C8FF
		public Trophy Trophy1
		{
			get
			{
				return this.m_Trophy1;
			}
			set
			{
				this.m_Trophy1 = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0004E708 File Offset: 0x0004C908
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x0004E710 File Offset: 0x0004C910
		public Trophy Trophy2
		{
			get
			{
				return this.m_Trophy2;
			}
			set
			{
				this.m_Trophy2 = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0004E719 File Offset: 0x0004C919
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0004E721 File Offset: 0x0004C921
		public League League
		{
			get
			{
				return this.m_League;
			}
			set
			{
				this.m_League = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0004E72A File Offset: 0x0004C92A
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0004E732 File Offset: 0x0004C932
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0004E73B File Offset: 0x0004C93B
		public Task(string when, string action, int targetCompObjId, int par1, int par2, int par3)
		{
			this.m_When = when;
			this.m_Action = action;
			this.m_TargetCompObjId = targetCompObjId;
			this.m_Parameter1 = par1;
			this.m_Parameter2 = par2;
			this.m_Parameter3 = par3;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0004E770 File Offset: 0x0004C970
		public Task(Task currentTask)
		{
			this.m_When = currentTask.m_When;
			this.m_Action = currentTask.m_Action;
			this.m_TargetCompObjId = currentTask.m_TargetCompObjId;
			this.m_Parameter1 = currentTask.m_Parameter1;
			this.m_Parameter2 = currentTask.m_Parameter2;
			this.m_Parameter3 = currentTask.m_Parameter3;
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0004E7CB File Offset: 0x0004C9CB
		public void LinkCompetitions(Compobj ownerCompobj)
		{
			if (ownerCompobj.IsGroup())
			{
				this.LinkGroup((Group)ownerCompobj);
				return;
			}
			if (ownerCompobj.IsStage())
			{
				this.LinkStage((Stage)ownerCompobj);
				return;
			}
			if (ownerCompobj.IsTrophy())
			{
				this.LinkTrophy((Trophy)ownerCompobj);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0004E80C File Offset: 0x0004CA0C
		public void LinkGroup(Group ownerGroup)
		{
			this.m_Group = ownerGroup;
			this.m_TargetCompObjId = ownerGroup.Id;
			if (this.m_Action == "FillFromCompTable")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTable;
				Compobj compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj != null && compobj.IsTrophy())
				{
					this.m_Trophy1 = (Trophy)compobj;
				}
				else
				{
					this.m_Trophy1 = null;
				}
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromCompTableBackup")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTableBackup;
				Compobj compobj2 = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj2 != null && compobj2.IsTrophy())
				{
					this.m_Trophy1 = (Trophy)compobj2;
				}
				else
				{
					this.m_Trophy1 = null;
				}
				compobj2 = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter2);
				if (compobj2 != null && compobj2.IsTrophy())
				{
					this.m_Trophy2 = (Trophy)compobj2;
				}
				else
				{
					this.m_Trophy2 = null;
				}
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromCompTableBackupLeague")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTableBackupLeague;
				Compobj compobj3 = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj3 != null && compobj3.IsTrophy())
				{
					this.m_Trophy1 = (Trophy)compobj3;
				}
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter2);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromLeague")
			{
				this.m_Rule = EQualifyingRule.FillFromLeague;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromLeagueMaxFromCountry")
			{
				this.m_Rule = EQualifyingRule.FillFromLeagueMaxFromCountry;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromSpecialTeams")
			{
				this.m_Rule = EQualifyingRule.FillFromSpecialTeams;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillWithTeam")
			{
				this.m_Rule = EQualifyingRule.FillWithTeam;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				Team team = (Team)FifaEnvironment.Teams.SearchId(this.m_Parameter2);
				this.m_Team = team;
				return;
			}
			if (this.m_Action == "FillFromLeagueInOrder")
			{
				this.m_Rule = EQualifyingRule.FillFromLeagueInOrder;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		public void LinkStage(Stage ownerStage)
		{
			this.m_Stage = ownerStage;
			this.m_TargetCompObjId = ownerStage.Id;
			if (this.m_Action == "UpdateLeagueTable")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "UpdateLeagueStats")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "ClearLeagueStats")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0004EBF8 File Offset: 0x0004CDF8
		public void LinkTrophy(Trophy ownerTrophy)
		{
			this.m_Trophy = ownerTrophy;
			this.m_TargetCompObjId = ownerTrophy.Id;
			if (this.m_Action == "UpdateTable")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				Compobj compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj != null && compobj.IsGroup())
				{
					this.m_Group = (Group)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				}
			}
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		public override string ToString()
		{
			string text = "To be defined";
			if (this.m_Action == "UpdateTable")
			{
				if (this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_Parameter2.ToString(),
						" of ",
						this.m_Group.ParentStage.ToString(),
						" - ",
						this.m_Group.ToString()
					});
				}
			}
			else if (this.m_Action == "ClearLeagueStats")
			{
				if (this.m_League != null)
				{
					text = "Clear Stats of league: " + this.m_League.ToString();
				}
			}
			else if (this.m_Action == "UpdateLeagueTable")
			{
				if (this.m_League != null)
				{
					text = "Update Table of league: " + this.m_League.ToString();
				}
			}
			else if (this.m_Action == "UpdateLeagueStats")
			{
				if (this.m_League != null)
				{
					text = "Update Stats of league: " + this.m_League.ToString();
				}
			}
			else
			{
				switch (this.m_Rule)
				{
				case EQualifyingRule.FillFromLeague:
					if (this.m_League != null)
					{
						text = "Get teams from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromLeagueInOrder:
					if (this.m_League != null)
					{
						text = "Get teams in order from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTable:
					if (this.m_Trophy1 != null)
					{
						if (this.m_Parameter2 == 1)
						{
							text = "Get winner of " + this.m_Trophy1.ToString();
						}
						else
						{
							text = "Get best " + this.m_Parameter2.ToString() + " teams of " + this.m_Trophy1.ToString();
						}
						this.m_Parameter1 = this.m_Trophy1.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTableBackup:
					if (this.m_Trophy1 != null && this.m_Trophy2 != null)
					{
						text = "Get winner of " + this.m_Trophy1.ToString() + " or a team from " + this.m_Trophy2.ToString();
						this.m_Parameter1 = this.m_Trophy1.Id;
						this.m_Parameter2 = this.m_Trophy2.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTableBackupLeague:
					if (this.m_Trophy1 != null && this.m_League != null)
					{
						text = "Get winner of " + this.m_Trophy1.ToString() + " or a team from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_Trophy1.Id;
						this.m_Parameter2 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromLeagueMaxFromCountry:
					if (this.m_League != null)
					{
						text = string.Concat(new string[]
						{
							"Get up to ",
							this.m_Parameter2.ToString(),
							" team(s) from league: ",
							this.m_League.ToString(),
							" (max ",
							this.m_Parameter3.ToString(),
							")"
						});
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromSpecialTeams:
					text = "Get " + this.m_Parameter1.ToString() + " team(s) from Special Teams Group";
					break;
				case EQualifyingRule.FillWithTeam:
					if (this.m_Team != null)
					{
						text = "Get Specific Team: " + this.m_Team.ToString();
						if (this.m_Parameter1 != 0)
						{
							text = text + " at position " + this.m_Parameter1.ToString();
						}
						this.m_Parameter2 = this.m_Team.Id;
					}
					break;
				}
			}
			return text;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0004F06C File Offset: 0x0004D26C
		public bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text = null;
			if (this.m_When == "start")
			{
				if (this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Group.ParentTrophy.Id.ToString(),
						",start,",
						this.m_Action,
						",",
						this.m_Group.Id.ToString(),
						","
					});
				}
				else if (this.m_Stage != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Stage.Trophy.Id.ToString(),
						",start,",
						this.m_Action,
						",",
						this.m_Stage.Id.ToString(),
						","
					});
				}
				if (this.m_Action == "FillFromCompTable")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromCompTableBackup")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						(this.m_Trophy2 != null) ? this.m_Trophy2.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromCompTableBackupLeague")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeague")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeagueMaxFromCountry")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromSpecialTeams")
				{
					text = string.Concat(new string[]
					{
						text,
						this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillWithTeam")
				{
					text = string.Concat(new string[]
					{
						text,
						this.m_Parameter1.ToString(),
						",",
						(this.m_Team != null) ? this.m_Team.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeagueInOrder")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "ClearLeagueStats")
				{
					text = string.Concat(new string[]
					{
						text,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
			}
			else if (this.m_Action == "UpdateTable")
			{
				if (this.m_Trophy != null && this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Trophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Trophy.Id.ToString(),
						",",
						this.m_Group.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else if (this.m_Action == "UpdateLeagueTable")
			{
				FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks() UpdateLeagueTable unexpected");
				if (this.m_Stage != null)
				{
					if (this.m_League != null)
					{
						text = string.Concat(new string[]
						{
							this.m_Stage.Trophy.Id.ToString(),
							",end,",
							this.m_Action,
							",",
							this.m_Stage.Id.ToString(),
							",",
							this.m_League.Id.ToString(),
							",",
							this.m_Parameter2.ToString(),
							",",
							this.m_Parameter3.ToString()
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							this.m_Stage.Trophy.Id.ToString(),
							",end,",
							this.m_Action,
							",",
							this.m_Stage.Id.ToString(),
							",",
							this.m_Parameter1.ToString(),
							",",
							this.m_Parameter2.ToString(),
							",",
							this.m_Parameter3.ToString()
						});
					}
				}
				else if (this.m_Group != null && this.m_League != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Group.ParentTrophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Group.ParentStage.Id.ToString(),
						",",
						this.m_League.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else if (this.m_Action == "UpdateLeagueStats")
			{
				if (this.m_Stage != null && this.m_League != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Stage.Trophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Stage.Id.ToString(),
						",",
						this.m_League.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else
			{
				FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
			}
			w.WriteLine(text);
			return true;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0004FA48 File Offset: 0x0004DC48
		public Task CopyTask(Compobj newTargetObj, League targetLeague)
		{
			Task task = new Task(this);
			task.m_TargetCompObjId = newTargetObj.Id;
			if (!(this.m_Action == "FillFromCompTable") && !(this.m_Action == "FillFromCompTableBackup"))
			{
				if (this.m_Action == "FillFromCompTableBackupLeague")
				{
					if (targetLeague != null)
					{
						task.Parameter2 = targetLeague.Id;
					}
				}
				else if (this.m_Action == "FillFromLeague")
				{
					if (targetLeague != null)
					{
						task.Parameter1 = targetLeague.Id;
					}
				}
				else if (this.m_Action == "FillFromLeagueMaxFromCountry")
				{
					if (targetLeague != null)
					{
						task.Parameter1 = targetLeague.Id;
					}
				}
				else if (!(this.m_Action == "FillFromSpecialTeams") && !(this.m_Action == "FillWithTeam"))
				{
					if (this.m_Action == "FillFromLeagueInOrder")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateLeagueTable")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateLeagueStats")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "ClearLeagueStats")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateTable")
					{
						task.Parameter1 = this.Parameter1 + task.m_TargetCompObjId - this.m_TargetCompObjId;
					}
				}
			}
			if (newTargetObj.IsTrophy())
			{
				task.LinkTrophy((Trophy)newTargetObj);
			}
			else if (newTargetObj.IsStage())
			{
				task.LinkStage((Stage)newTargetObj);
			}
			else if (newTargetObj.IsGroup())
			{
				task.LinkGroup((Group)newTargetObj);
			}
			return task;
		}

		// Token: 0x0400112A RID: 4394
		private string m_When;

		// Token: 0x0400112B RID: 4395
		private string m_Action;

		// Token: 0x0400112C RID: 4396
		private EQualifyingRule m_Rule;

		// Token: 0x0400112D RID: 4397
		private int m_TargetCompObjId;

		// Token: 0x0400112E RID: 4398
		private int m_Parameter1;

		// Token: 0x0400112F RID: 4399
		private int m_Parameter2;

		// Token: 0x04001130 RID: 4400
		private int m_Parameter3;

		// Token: 0x04001131 RID: 4401
		private Group m_Group;

		// Token: 0x04001132 RID: 4402
		private Stage m_Stage;

		// Token: 0x04001133 RID: 4403
		private Trophy m_Trophy;

		// Token: 0x04001134 RID: 4404
		private Trophy m_Trophy1;

		// Token: 0x04001135 RID: 4405
		private Trophy m_Trophy2;

		// Token: 0x04001136 RID: 4406
		private League m_League;

		// Token: 0x04001137 RID: 4407
		private Team m_Team;
	}
}
