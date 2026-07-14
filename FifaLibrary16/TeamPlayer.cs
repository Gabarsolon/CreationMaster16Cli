using System;

namespace FifaLibrary
{
	// Token: 0x02000082 RID: 130
	public class TeamPlayer
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00045D48 File Offset: 0x00043F48
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00045D50 File Offset: 0x00043F50
		public int jerseynumber
		{
			get
			{
				return this.m_jerseynumber;
			}
			set
			{
				this.m_jerseynumber = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00045D59 File Offset: 0x00043F59
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00045D61 File Offset: 0x00043F61
		public int position
		{
			get
			{
				return this.m_position;
			}
			set
			{
				this.m_position = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00045D6A File Offset: 0x00043F6A
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00045D72 File Offset: 0x00043F72
		public Player Player
		{
			get
			{
				return this.m_Player;
			}
			set
			{
				this.m_Player = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00045D7B File Offset: 0x00043F7B
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00045D83 File Offset: 0x00043F83
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

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00045D8C File Offset: 0x00043F8C
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00045D94 File Offset: 0x00043F94
		public int State
		{
			get
			{
				return this.m_State;
			}
			set
			{
				this.m_State = value;
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00045DA0 File Offset: 0x00043FA0
		public TeamPlayer(Record r, Player player, Team team)
		{
			this.m_jerseynumber = r.GetAndCheckIntField(FI.teamplayerlinks_jerseynumber);
			this.m_position = r.GetAndCheckIntField(FI.teamplayerlinks_position);
			this.m_Player = player;
			this.m_Team = team;
			this.m_leaguegoals = r.GetAndCheckIntField(FI.teamplayerlinks_leaguegoals);
			this.m_leagueappearances = r.GetAndCheckIntField(FI.teamplayerlinks_leagueappearances);
			this.m_leaguegoalsprevmatch = r.GetAndCheckIntField(FI.teamplayerlinks_leaguegoalsprevmatch);
			this.m_leaguegoalsprevthreematches = r.GetAndCheckIntField(FI.teamplayerlinks_leaguegoalsprevthreematches);
			this.m_prevform = r.GetAndCheckIntField(FI.teamplayerlinks_prevform);
			this.m_form = r.GetAndCheckIntField(FI.teamplayerlinks_form);
			this.m_isamongtopscorers = r.GetAndCheckIntField(FI.teamplayerlinks_isamongtopscorers) != 0;
			this.m_isamongtopscorersinteam = r.GetAndCheckIntField(FI.teamplayerlinks_isamongtopscorersinteam) != 0;
			this.m_istopscorer = r.GetAndCheckIntField(FI.teamplayerlinks_istopscorer) != 0;
			this.m_injury = r.GetAndCheckIntField(FI.teamplayerlinks_injury);
			this.m_yellows = r.GetAndCheckIntField(FI.teamplayerlinks_yellows);
			this.m_reds = r.GetAndCheckIntField(FI.teamplayerlinks_reds);
			this.m_State = 0;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00045EC0 File Offset: 0x000440C0
		public TeamPlayer(Player player)
		{
			this.m_jerseynumber = 99;
			this.m_position = player.preferredposition1;
			this.m_Player = player;
			this.m_leaguegoals = 0;
			this.m_isamongtopscorers = false;
			this.m_isamongtopscorersinteam = false;
			this.m_istopscorer = false;
			this.m_yellows = 0;
			this.m_reds = 0;
			this.m_injury = 0;
			this.m_leagueappearances = 0;
			this.m_form = 3;
			this.m_prevform = 3;
			this.m_State = 0;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00045F3C File Offset: 0x0004413C
		public TeamPlayer(ERole role)
		{
			this.m_jerseynumber = 0;
			this.m_position = (int)role;
			this.m_Player = null;
			this.m_Team = null;
			this.m_leaguegoals = 0;
			this.m_isamongtopscorers = false;
			this.m_isamongtopscorersinteam = false;
			this.m_istopscorer = false;
			this.m_yellows = 0;
			this.m_reds = 0;
			this.m_injury = 0;
			this.m_leagueappearances = 0;
			this.m_form = 3;
			this.m_prevform = 3;
			this.m_State = 0;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00045FB8 File Offset: 0x000441B8
		public void Save(Record r, int artificialkey)
		{
			if (this.m_Player == null)
			{
				return;
			}
			if (this.m_Team == null)
			{
				return;
			}
			r.IntField[FI.teamplayerlinks_artificialkey] = artificialkey;
			r.IntField[FI.teamplayerlinks_teamid] = this.m_Team.Id;
			r.IntField[FI.teamplayerlinks_playerid] = this.m_Player.Id;
			r.IntField[FI.teamplayerlinks_jerseynumber] = this.m_jerseynumber;
			r.IntField[FI.teamplayerlinks_position] = this.m_position;
			r.IntField[FI.teamplayerlinks_leaguegoals] = this.m_leaguegoals;
			r.IntField[FI.teamplayerlinks_leagueappearances] = this.m_leagueappearances;
			r.IntField[FI.teamplayerlinks_leaguegoalsprevthreematches] = this.m_leaguegoalsprevthreematches;
			r.IntField[FI.teamplayerlinks_leaguegoalsprevmatch] = this.m_leaguegoalsprevmatch;
			r.IntField[FI.teamplayerlinks_prevform] = (this.m_prevform = r.GetAndCheckIntField(FI.teamplayerlinks_prevform));
			r.IntField[FI.teamplayerlinks_form] = (this.m_form = r.GetAndCheckIntField(FI.teamplayerlinks_form));
			r.IntField[FI.teamplayerlinks_isamongtopscorers] = (this.m_isamongtopscorers ? 1 : 0);
			r.IntField[FI.teamplayerlinks_isamongtopscorersinteam] = (this.m_isamongtopscorersinteam ? 1 : 0);
			r.IntField[FI.teamplayerlinks_istopscorer] = (this.m_istopscorer ? 1 : 0);
			r.IntField[FI.teamplayerlinks_injury] = this.m_injury;
			r.IntField[FI.teamplayerlinks_yellows] = this.m_yellows;
			r.IntField[FI.teamplayerlinks_reds] = this.m_reds;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0004613C File Offset: 0x0004433C
		public override string ToString()
		{
			return this.m_jerseynumber.ToString() + " " + ((this.m_Player != null) ? this.m_Player.ToString() : string.Empty);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00046170 File Offset: 0x00044370
		public int AssignFreeNumber(int guessNumber)
		{
			int jerseynumber = this.m_jerseynumber;
			int num = ((guessNumber > jerseynumber) ? 1 : (-1));
			this.m_jerseynumber = this.RecursiveNumber(jerseynumber, num);
			return this.m_jerseynumber;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000461A1 File Offset: 0x000443A1
		private int RecursiveNumber(int number, int step)
		{
			if (!this.m_Team.Roster.IsNumberFree(number))
			{
				if (number == 99)
				{
					number = 1;
				}
				else if (number == 1)
				{
					number = 99;
				}
				else
				{
					number += step;
				}
				return this.RecursiveNumber(number, step);
			}
			return number;
		}

		// Token: 0x040010CA RID: 4298
		public int m_jerseynumber;

		// Token: 0x040010CB RID: 4299
		private int m_position;

		// Token: 0x040010CC RID: 4300
		private Player m_Player;

		// Token: 0x040010CD RID: 4301
		private Team m_Team;

		// Token: 0x040010CE RID: 4302
		private int m_leaguegoals;

		// Token: 0x040010CF RID: 4303
		private bool m_isamongtopscorers;

		// Token: 0x040010D0 RID: 4304
		private int m_yellows;

		// Token: 0x040010D1 RID: 4305
		private int m_reds;

		// Token: 0x040010D2 RID: 4306
		private bool m_isamongtopscorersinteam;

		// Token: 0x040010D3 RID: 4307
		private int m_injury;

		// Token: 0x040010D4 RID: 4308
		private int m_leagueappearances;

		// Token: 0x040010D5 RID: 4309
		private int m_leaguegoalsprevmatch;

		// Token: 0x040010D6 RID: 4310
		private int m_leaguegoalsprevthreematches;

		// Token: 0x040010D7 RID: 4311
		private bool m_istopscorer;

		// Token: 0x040010D8 RID: 4312
		private int m_form;

		// Token: 0x040010D9 RID: 4313
		private int m_prevform;

		// Token: 0x040010DA RID: 4314
		private int m_State;
	}
}
