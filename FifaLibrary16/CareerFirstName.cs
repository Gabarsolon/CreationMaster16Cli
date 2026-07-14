using System;

namespace FifaLibrary
{
	// Token: 0x02000068 RID: 104
	public class CareerFirstName : IdObject
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00036FA4 File Offset: 0x000351A4
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00036FAC File Offset: 0x000351AC
		public string Text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00036FB5 File Offset: 0x000351B5
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00036FBD File Offset: 0x000351BD
		public int firstname
		{
			get
			{
				return this.m_firstname;
			}
			set
			{
				this.m_firstname = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00036FC6 File Offset: 0x000351C6
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00036FCE File Offset: 0x000351CE
		public int groupid
		{
			get
			{
				return this.m_groupid;
			}
			set
			{
				this.m_groupid = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00036FD7 File Offset: 0x000351D7
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00036FDE File Offset: 0x000351DE
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerFirstName.s_PlayerNames;
			}
			set
			{
				CareerFirstName.s_PlayerNames = value;
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00036FE6 File Offset: 0x000351E6
		public CareerFirstName(Record r)
			: base(r.IntField[FI.career_firstnames_firstnameid])
		{
			this.Load(r);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00037004 File Offset: 0x00035204
		public void Load(Record r)
		{
			this.m_firstname = r.IntField[FI.career_firstnames_firstname];
			this.m_groupid = r.IntField[FI.career_firstnames_groupid];
			if (CareerFirstName.s_PlayerNames == null || !CareerFirstName.s_PlayerNames.TryGetValue(this.m_firstname, out this.m_Text, true))
			{
				this.m_Text = string.Empty;
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00037060 File Offset: 0x00035260
		public void Save(Record r)
		{
			string text = null;
			CareerFirstName.s_PlayerNames.TryGetValue(this.m_firstname, out text, true);
			if (text != this.m_Text)
			{
				this.m_firstname = CareerFirstName.s_PlayerNames.GetKey(this.m_Text);
			}
			r.IntField[FI.career_firstnames_firstnameid] = base.Id;
			r.IntField[FI.career_firstnames_firstname] = this.m_firstname;
			r.IntField[FI.career_firstnames_groupid] = this.m_groupid;
		}

		// Token: 0x04000F5E RID: 3934
		private string m_Text;

		// Token: 0x04000F5F RID: 3935
		private int m_firstname;

		// Token: 0x04000F60 RID: 3936
		private int m_groupid;

		// Token: 0x04000F61 RID: 3937
		private static PlayerNames s_PlayerNames;
	}
}
