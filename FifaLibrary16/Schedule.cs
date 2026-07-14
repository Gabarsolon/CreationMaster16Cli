using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000094 RID: 148
	public class Schedule
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0004DC47 File Offset: 0x0004BE47
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0004DC4F File Offset: 0x0004BE4F
		public int Leg
		{
			get
			{
				return this.m_Leg;
			}
			set
			{
				this.m_Leg = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0004DC58 File Offset: 0x0004BE58
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0004DC60 File Offset: 0x0004BE60
		public int MinGames
		{
			get
			{
				return this.m_MinGames;
			}
			set
			{
				this.m_MinGames = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0004DC69 File Offset: 0x0004BE69
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0004DC71 File Offset: 0x0004BE71
		public int MaxGames
		{
			get
			{
				return this.m_MaxGames;
			}
			set
			{
				this.m_MaxGames = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0004DC7A File Offset: 0x0004BE7A
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0004DC82 File Offset: 0x0004BE82
		public int Time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0004DC8B File Offset: 0x0004BE8B
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
		public int TimeIndex
		{
			get
			{
				return (this.m_Time / 100 - 12) * 4 + this.m_Time % 100 / 15;
			}
			set
			{
				this.m_Time = value / 4 * 100 + 1200;
				this.m_Time += value % 4 * 15;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0004DCCF File Offset: 0x0004BECF
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x0004DCD7 File Offset: 0x0004BED7
		public int Day
		{
			get
			{
				return this.m_Day;
			}
			set
			{
				this.m_Day = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0004DCE0 File Offset: 0x0004BEE0
		public int Year
		{
			get
			{
				return this.m_Year;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x0004DD58 File Offset: 0x0004BF58
		public DateTime Date
		{
			get
			{
				TimeSpan timeSpan = new TimeSpan(this.m_Day, this.m_Time / 100, this.m_Time % 100, 0);
				if (this.m_Day < 0)
				{
					return Schedule.s_BaseDate;
				}
				DateTime dateTime = Schedule.s_BaseDate.Add(timeSpan);
				dateTime.AddHours((double)(this.m_Time / 100));
				dateTime.AddMinutes((double)(this.m_Time % 100));
				return dateTime;
			}
			set
			{
				this.m_Day = (value - Schedule.s_BaseDate).Days;
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0004DD80 File Offset: 0x0004BF80
		public DateTime ConvertToDate(int gregorian)
		{
			DateTime dateTime = Schedule.s_BaseDate;
			if (gregorian < 0)
			{
				return dateTime;
			}
			return dateTime.AddDays((double)gregorian);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0004DDA4 File Offset: 0x0004BFA4
		public int ConvertFromDate(DateTime date)
		{
			DateTime dateTime = Schedule.s_BaseDate;
			return (date - dateTime).Days;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		public Schedule(Stage stage, int day, int leg, int minGames, int maxGames, int time)
		{
			this.m_Stage = stage;
			this.m_Leg = leg;
			this.m_MinGames = minGames;
			this.m_MaxGames = maxGames;
			this.m_Time = time;
			this.m_Day = day;
			this.m_Year = 2012;
			bool flag;
			string property = stage.Settings.GetProperty("schedule_year_start", 0, out flag);
			if (property != null)
			{
				this.m_Year = Convert.ToInt32(property);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0004DE38 File Offset: 0x0004C038
		public Schedule(Group group, int day, int leg, int minGames, int maxGames, int time)
		{
			this.m_Group = group;
			this.m_Leg = leg;
			this.m_MinGames = minGames;
			this.m_MaxGames = maxGames;
			this.m_Time = time;
			this.m_Day = day;
			this.m_Year = 2012;
			bool flag;
			string property = group.Settings.GetProperty("schedule_year_start", 0, out flag);
			if (property != null)
			{
				this.m_Year = Convert.ToInt32(property);
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		public Schedule(Schedule srcSchedule)
		{
			this.m_Day = srcSchedule.m_Day;
			this.m_Leg = srcSchedule.m_Leg;
			this.m_MinGames = srcSchedule.m_MinGames;
			this.m_MaxGames = srcSchedule.m_MaxGames;
			this.m_Time = srcSchedule.m_Time;
			this.m_Group = srcSchedule.m_Group;
			this.m_Stage = srcSchedule.m_Stage;
			this.m_Year = srcSchedule.m_Year;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0004DF1C File Offset: 0x0004C11C
		public bool SaveToSchedule(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text;
			if (this.m_Group != null)
			{
				text = this.m_Group.Id.ToString() + ",";
			}
			else
			{
				if (this.m_Stage == null)
				{
					return false;
				}
				text = this.m_Stage.Id.ToString() + ",";
			}
			text = string.Concat(new string[]
			{
				text,
				this.m_Day.ToString(),
				",",
				this.m_Leg.ToString(),
				",",
				this.m_MinGames.ToString(),
				",",
				this.m_MaxGames.ToString(),
				",",
				this.m_Time.ToString()
			});
			w.WriteLine(text);
			return true;
		}

		// Token: 0x0400111E RID: 4382
		private Stage m_Stage;

		// Token: 0x0400111F RID: 4383
		private Group m_Group;

		// Token: 0x04001120 RID: 4384
		private int m_Leg;

		// Token: 0x04001121 RID: 4385
		private int m_MinGames;

		// Token: 0x04001122 RID: 4386
		private int m_MaxGames;

		// Token: 0x04001123 RID: 4387
		private int m_Time;

		// Token: 0x04001124 RID: 4388
		private int m_Day;

		// Token: 0x04001125 RID: 4389
		private int m_Year;

		// Token: 0x04001126 RID: 4390
		public static DateTime s_BaseDate = new DateTime(2012, 12, 30, 0, 0, 0);
	}
}
