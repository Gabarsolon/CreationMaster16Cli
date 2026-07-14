using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000030 RID: 48
	public class FieldComparer : IComparer
	{
		// Token: 0x06000352 RID: 850 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		int IComparer.Compare(object x, object y)
		{
			FieldDescriptor fieldDescriptor = (FieldDescriptor)x;
			FieldDescriptor fieldDescriptor2 = (FieldDescriptor)y;
			if (fieldDescriptor.BitOffset == fieldDescriptor2.BitOffset)
			{
				return 0;
			}
			if (fieldDescriptor.BitOffset <= fieldDescriptor2.BitOffset)
			{
				return -1;
			}
			return 1;
		}
	}
}
