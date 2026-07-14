using System;

namespace FifaLibrary
{
	// Token: 0x02000099 RID: 153
	public class InitTeamList : IdArrayList
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0004FCA1 File Offset: 0x0004DEA1
		public InitTeamList()
			: base(typeof(InitTeam))
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0004FCB4 File Offset: 0x0004DEB4
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((InitTeam)obj).LinkTeam(teamList);
			}
		}
	}
}
