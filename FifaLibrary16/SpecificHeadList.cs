using System;

namespace FifaLibrary
{
	// Token: 0x02000064 RID: 100
	public class SpecificHeadList : IdArrayList
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x0002C264 File Offset: 0x0002A464
		public SpecificHeadList()
			: base(typeof(SpecificHead))
		{
			this.Clear();
			this.Add(new SpecificHead());
		}
	}
}
