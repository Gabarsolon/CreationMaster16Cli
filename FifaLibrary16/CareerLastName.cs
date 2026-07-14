using System;

namespace FifaLibrary
{
	// Token: 0x02000069 RID: 105
	public class CareerLastName : IdObject
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000370DD File Offset: 0x000352DD
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000370E5 File Offset: 0x000352E5
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

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000370EE File Offset: 0x000352EE
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000370F6 File Offset: 0x000352F6
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

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000370FF File Offset: 0x000352FF
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00037107 File Offset: 0x00035307
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00037110 File Offset: 0x00035310
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00037117 File Offset: 0x00035317
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerLastName.s_PlayerNames;
			}
			set
			{
				CareerLastName.s_PlayerNames = value;
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0003711F File Offset: 0x0003531F
		public CareerLastName(Record r)
			: base(r.IntField[FI.career_lastnames_lastnameid])
		{
			this.Load(r);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0003713C File Offset: 0x0003533C
		public void Load(Record r)
		{
			this.m_lastname = r.IntField[FI.career_lastnames_lastname];
			this.m_groupid = r.IntField[FI.career_firstnames_groupid];
			if (CareerLastName.s_PlayerNames == null || !CareerLastName.s_PlayerNames.TryGetValue(this.m_lastname, out this.m_Text, true))
			{
				this.m_Text = string.Empty;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00037198 File Offset: 0x00035398
		public void Save(Record r)
		{
			string text = null;
			CareerLastName.s_PlayerNames.TryGetValue(this.m_lastname, out text, true);
			if (text != this.m_Text)
			{
				this.m_lastname = CareerLastName.s_PlayerNames.GetKey(this.m_Text);
			}
			r.IntField[FI.career_lastnames_lastnameid] = base.Id;
			r.IntField[FI.career_lastnames_lastname] = this.m_lastname;
			r.IntField[FI.career_lastnames_groupid] = this.m_groupid;
		}

		// Token: 0x04000F62 RID: 3938
		private string m_Text;

		// Token: 0x04000F63 RID: 3939
		private int m_lastname;

		// Token: 0x04000F64 RID: 3940
		private int m_groupid;

		// Token: 0x04000F65 RID: 3941
		private static PlayerNames s_PlayerNames;
	}
}
