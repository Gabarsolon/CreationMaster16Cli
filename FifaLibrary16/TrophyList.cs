using System;

namespace FifaLibrary
{
	// Token: 0x0200008D RID: 141
	public class TrophyList : IdArrayList
	{
		// Token: 0x06000DBD RID: 3517 RVA: 0x0004BEAB File Offset: 0x0004A0AB
		public TrophyList()
			: base(typeof(Trophy))
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0004BEC0 File Offset: 0x0004A0C0
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				((Trophy)obj).LinkLeague(leagueList);
			}
		}
	}
}
