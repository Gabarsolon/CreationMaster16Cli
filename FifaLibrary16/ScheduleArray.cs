using System;
using System.Collections;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000096 RID: 150
	public class ScheduleArray : ArrayList
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x0004E05C File Offset: 0x0004C25C
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x0004E064 File Offset: 0x0004C264
		public Schedule[] Schedules
		{
			get
			{
				return this.m_Schedules;
			}
			set
			{
				this.m_Schedules = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0004E06D File Offset: 0x0004C26D
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x0004E075 File Offset: 0x0004C275
		public int NSchedules
		{
			get
			{
				return this.m_NSchedules;
			}
			set
			{
				this.m_NSchedules = value;
			}
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0004E07E File Offset: 0x0004C27E
		public ScheduleArray(int length)
		{
			this.m_NSchedules = 0;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0004E090 File Offset: 0x0004C290
		public Schedule[] GetLegSchedule(int legId)
		{
			int num = 0;
			IEnumerator enumerator = this.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if (((Schedule)enumerator.Current).Leg == legId)
					{
						num++;
					}
				}
			}
			if (num == 0)
			{
				return null;
			}
			Schedule[] array = new Schedule[num];
			num = 0;
			foreach (object obj in this)
			{
				Schedule schedule = (Schedule)obj;
				if (schedule.Leg == legId)
				{
					array[num++] = schedule;
				}
			}
			return array;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0004E14C File Offset: 0x0004C34C
		public void RenumberLegs()
		{
			this.Sort(ScheduleArray.m_Comparer);
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Schedule schedule = (Schedule)obj;
				int leg = schedule.Leg;
				if (num2 != leg)
				{
					num2 = leg;
					num++;
				}
				schedule.Leg = num;
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		public Schedule DuplicatetLeg(int legId, int dayDelay)
		{
			Schedule[] legSchedule = this.GetLegSchedule(legId);
			if (legSchedule == null)
			{
				return null;
			}
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				if (((Schedule)this[i]).Leg == legId)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 == 0)
			{
				return null;
			}
			num += num2;
			Schedule schedule = null;
			for (int j = legSchedule.Length - 1; j >= 0; j--)
			{
				schedule = new Schedule(legSchedule[j]);
				schedule.Day += dayDelay;
				this.Insert(num, schedule);
			}
			for (int k = num; k < this.Count; k++)
			{
				Schedule schedule2 = (Schedule)this[k];
				int leg = schedule2.Leg;
				schedule2.Leg = leg + 1;
			}
			return schedule;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0004E28C File Offset: 0x0004C48C
		public bool RemoveLeg(int legId)
		{
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				if (((Schedule)this[i]).Leg == legId)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 > 0)
			{
				this.RemoveRange(num, num2);
				for (int i = num; i < this.Count; i++)
				{
					Schedule schedule = (Schedule)this[i];
					int leg = schedule.Leg;
					schedule.Leg = leg - 1;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0004E308 File Offset: 0x0004C508
		public bool AddScheduleToLeg(Schedule schedule)
		{
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				if (((Schedule)this[i]).Leg == schedule.Leg)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 > 0)
			{
				this.Insert(num + num2, schedule);
				return true;
			}
			return false;
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0004E360 File Offset: 0x0004C560
		public bool DeleteSchedule(Schedule schedule)
		{
			for (int i = 0; i < this.Count; i++)
			{
				Schedule schedule2 = (Schedule)this[i];
				if (schedule2.Leg == schedule.Leg && schedule2.Day == schedule.Day && schedule2.Time == schedule.Time && schedule2.MinGames == schedule.MinGames && schedule2.MaxGames == schedule.MaxGames)
				{
					bool flag = true;
					if (i > 0)
					{
						Schedule schedule3 = (Schedule)this[i - 1];
						if (schedule.Leg == schedule3.Leg)
						{
							flag = false;
						}
					}
					if (i < this.Count - 1)
					{
						Schedule schedule4 = (Schedule)this[i + 1];
						if (schedule.Leg == schedule4.Leg)
						{
							flag = false;
						}
					}
					if (flag)
					{
						this.RemoveLeg(schedule.Leg);
					}
					else
					{
						this.RemoveAt(i);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0004E44D File Offset: 0x0004C64D
		public void AddSchedule(Schedule schedule)
		{
			this.Add(schedule);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0004E458 File Offset: 0x0004C658
		public Schedule[] GetLastLegSchedule()
		{
			if (this.Count <= 0)
			{
				return null;
			}
			int leg = ((Schedule)this[this.Count - 1]).Leg;
			return this.GetLegSchedule(leg);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0004E490 File Offset: 0x0004C690
		public bool RemoveLastLeg()
		{
			if (this.Count <= 0)
			{
				return false;
			}
			int leg = ((Schedule)this[this.Count - 1]).Leg;
			return this.RemoveLeg(leg);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		public Schedule AppendLeg(Compobj compobj, int dayDelay)
		{
			if (this.Count > 0)
			{
				Schedule[] lastLegSchedule = this.GetLastLegSchedule();
				Schedule schedule = null;
				for (int i = 0; i < lastLegSchedule.Length; i++)
				{
					schedule = new Schedule(lastLegSchedule[i]);
					schedule.Leg++;
					schedule.Day += dayDelay;
					this.AddSchedule(schedule);
				}
				return schedule;
			}
			if (compobj.IsGroup())
			{
				Schedule schedule2 = new Schedule((Group)compobj, 215, 1, 1, 1, 1500);
				this.AddSchedule(schedule2);
				return schedule2;
			}
			if (compobj.IsStage())
			{
				Schedule schedule3 = new Schedule((Stage)compobj, 215, 1, 1, 1, 1500);
				this.AddSchedule(schedule3);
				return schedule3;
			}
			return null;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0004E580 File Offset: 0x0004C780
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			Schedule schedule = new Schedule(originalSchedule);
			schedule.Time += timeDelay;
			this.AddScheduleToLeg(schedule);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		public bool SaveToSchedule(StreamWriter w)
		{
			foreach (object obj in this)
			{
				((Schedule)obj).SaveToSchedule(w);
			}
			return true;
		}

		// Token: 0x04001127 RID: 4391
		private Schedule[] m_Schedules;

		// Token: 0x04001128 RID: 4392
		private int m_NSchedules;

		// Token: 0x04001129 RID: 4393
		private static ScheduleComparer m_Comparer = new ScheduleComparer();
	}
}
