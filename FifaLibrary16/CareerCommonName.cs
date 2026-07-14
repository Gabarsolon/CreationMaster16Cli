using System;

namespace FifaLibrary
{
	// Token: 0x0200006A RID: 106
	public class CareerCommonName : IdObject
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00037215 File Offset: 0x00035415
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0003721D File Offset: 0x0003541D
		public string Text1
		{
			get
			{
				return this.m_Text1;
			}
			set
			{
				this.m_Text1 = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00037226 File Offset: 0x00035426
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0003722E File Offset: 0x0003542E
		public string Text2
		{
			get
			{
				return this.m_Text2;
			}
			set
			{
				this.m_Text2 = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00037237 File Offset: 0x00035437
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0003723F File Offset: 0x0003543F
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

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00037248 File Offset: 0x00035448
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00037250 File Offset: 0x00035450
		public int lastname
		{
			get
			{
				return this.m_lastname;
			}
			set
			{
				this.m_lastname = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00037259 File Offset: 0x00035459
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00037261 File Offset: 0x00035461
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

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0003726A File Offset: 0x0003546A
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00037271 File Offset: 0x00035471
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerCommonName.s_PlayerNames;
			}
			set
			{
				CareerCommonName.s_PlayerNames = value;
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00037279 File Offset: 0x00035479
		public CareerCommonName(Record r)
			: base(r.IntField[FI.career_commonnames_commonnameid])
		{
			this.Load(r);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00037294 File Offset: 0x00035494
		public void Load(Record r)
		{
			this.m_firstname = r.IntField[FI.career_commonnames_firstname];
			this.m_lastname = r.IntField[FI.career_commonnames_lastname];
			this.m_groupid = r.IntField[FI.career_commonnames_groupid];
			if (CareerCommonName.s_PlayerNames == null || !CareerCommonName.s_PlayerNames.TryGetValue(this.m_firstname, out this.m_Text1, true))
			{
				this.m_Text1 = string.Empty;
			}
			if (CareerCommonName.s_PlayerNames == null || !CareerCommonName.s_PlayerNames.TryGetValue(this.m_lastname, out this.m_Text2, true))
			{
				this.m_Text2 = string.Empty;
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00037330 File Offset: 0x00035530
		public void Save(Record r)
		{
			string text = null;
			CareerCommonName.s_PlayerNames.TryGetValue(this.m_firstname, out text, true);
			if (text != this.m_Text1)
			{
				this.m_firstname = CareerCommonName.s_PlayerNames.GetKey(this.m_Text1);
			}
			CareerCommonName.s_PlayerNames.TryGetValue(this.m_lastname, out text, true);
			if (text != this.m_Text2)
			{
				this.m_lastname = CareerCommonName.s_PlayerNames.GetKey(this.m_Text2);
			}
			r.IntField[FI.career_commonnames_commonnameid] = base.Id;
			r.IntField[FI.career_commonnames_firstname] = this.m_firstname;
			r.IntField[FI.career_commonnames_lastname] = this.m_lastname;
			r.IntField[FI.career_commonnames_groupid] = this.m_groupid;
		}

		// Token: 0x04000F66 RID: 3942
		private string m_Text1;

		// Token: 0x04000F67 RID: 3943
		private string m_Text2;

		// Token: 0x04000F68 RID: 3944
		private int m_firstname;

		// Token: 0x04000F69 RID: 3945
		private int m_lastname;

		// Token: 0x04000F6A RID: 3946
		private int m_groupid;

		// Token: 0x04000F6B RID: 3947
		private static PlayerNames s_PlayerNames;
	}
}
