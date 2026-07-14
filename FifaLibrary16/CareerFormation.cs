using System;

namespace FifaLibrary
{
	// Token: 0x0200003F RID: 63
	public class CareerFormation : Formation
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000202FF File Offset: 0x0001E4FF
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000202F6 File Offset: 0x0001E4F6
		public bool IsInCareer
		{
			get
			{
				return this.m_IsInCareer;
			}
			set
			{
				this.m_IsInCareer = value;
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00020307 File Offset: 0x0001E507
		public CareerFormation(Record r)
			: base(r)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00020310 File Offset: 0x0001E510
		public CareerFormation(int formationid)
			: base(formationid)
		{
		}

		// Token: 0x04000DEE RID: 3566
		private bool m_IsInCareer;
	}
}
