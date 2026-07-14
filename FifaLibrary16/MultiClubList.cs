using System;

namespace FifaLibrary
{
	// Token: 0x02000062 RID: 98
	public class MultiClubList : IdArrayList
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x0002C239 File Offset: 0x0002A439
		public MultiClubList()
			: base(typeof(MultiClub))
		{
			this.Clear();
			this.Add(new MultiClub());
		}
	}
}
