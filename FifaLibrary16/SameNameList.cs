using System;

namespace FifaLibrary
{
	// Token: 0x0200005E RID: 94
	public class SameNameList : IdArrayList
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x0002C1E3 File Offset: 0x0002A3E3
		public SameNameList()
			: base(typeof(SameName))
		{
			this.Clear();
			this.Add(new SameName());
		}
	}
}
