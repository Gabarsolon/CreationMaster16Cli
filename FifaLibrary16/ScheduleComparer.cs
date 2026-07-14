using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000095 RID: 149
	public class ScheduleComparer : IComparer
	{
		// Token: 0x06000E2D RID: 3629 RVA: 0x0004E018 File Offset: 0x0004C218
		int IComparer.Compare(object x, object y)
		{
			Schedule schedule = (Schedule)x;
			Schedule schedule2 = (Schedule)y;
			if (schedule.Day != schedule2.Day)
			{
				return schedule.Day - schedule2.Day;
			}
			return schedule.Time - schedule2.Time;
		}
	}
}
