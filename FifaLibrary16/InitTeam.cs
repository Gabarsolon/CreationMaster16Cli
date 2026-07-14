using System;

namespace FifaLibrary
{
	// Token: 0x02000098 RID: 152
	public class InitTeam : IdObject
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0004FC39 File Offset: 0x0004DE39
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0004FC41 File Offset: 0x0004DE41
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x0004FC49 File Offset: 0x0004DE49
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				this.m_teamid = ((this.m_Team != null) ? this.m_Team.Id : (-1));
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0004FC6E File Offset: 0x0004DE6E
		public InitTeam(int orderId, int teamId)
		{
			base.Id = orderId;
			this.m_teamid = teamId;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0004FC84 File Offset: 0x0004DE84
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_Team = (Team)teamList.SearchId(this.m_teamid);
		}

		// Token: 0x04001138 RID: 4408
		private int m_teamid;

		// Token: 0x04001139 RID: 4409
		private Team m_Team;
	}
}
