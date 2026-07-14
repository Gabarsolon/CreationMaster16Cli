using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x0200002F RID: 47
	public class RecordComparer : IComparer
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0000E574 File Offset: 0x0000C774
		int IComparer.Compare(object x, object y)
		{
			Record record = (Record)x;
			Record record2 = (Record)y;
			TableDescriptor tableDescriptor = record.TableDescriptor;
			int i = 0;
			while (i < tableDescriptor.NKeyFields)
			{
				int num = tableDescriptor.KeyIndex[i];
				if (record.IntField[num] != record2.IntField[num])
				{
					if (record.IntField[num] <= record2.IntField[num])
					{
						return -1;
					}
					return 1;
				}
				else
				{
					i++;
				}
			}
			return 0;
		}
	}
}
