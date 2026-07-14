using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x0200004B RID: 75
	public class IdObjectComparer : IComparer
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00026EE0 File Offset: 0x000250E0
		int IComparer.Compare(object x, object y)
		{
			return ((IdObject)x).Id - ((IdObject)y).Id;
		}
	}
}
