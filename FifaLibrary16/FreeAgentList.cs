using System;

namespace FifaLibrary
{
	// Token: 0x02000060 RID: 96
	public class FreeAgentList : IdArrayList
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x0002C20E File Offset: 0x0002A40E
		public FreeAgentList()
			: base(typeof(FreeAgent))
		{
			this.Clear();
			this.Add(new FreeAgent());
		}
	}
}
