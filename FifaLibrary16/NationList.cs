using System;

namespace FifaLibrary
{
	// Token: 0x0200008B RID: 139
	public class NationList : IdArrayList
	{
		// Token: 0x06000D68 RID: 3432 RVA: 0x0004AC01 File Offset: 0x00048E01
		public NationList()
			: base(typeof(Nation))
		{
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0004AC14 File Offset: 0x00048E14
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((Nation)obj).LinkCountry(countryList);
			}
		}
	}
}
