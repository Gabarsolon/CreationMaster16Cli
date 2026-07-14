using System;
using System.Data;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200002A RID: 42
	public class TableDescriptor
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000B66A File Offset: 0x0000986A
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000B672 File Offset: 0x00009872
		public char[] ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000B67B File Offset: 0x0000987B
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000B683 File Offset: 0x00009883
		public uint NBitRecords
		{
			get
			{
				return this.m_NBitRecords;
			}
			set
			{
				this.m_NBitRecords = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000B68C File Offset: 0x0000988C
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000B694 File Offset: 0x00009894
		public int NFields
		{
			get
			{
				return this.m_NFields;
			}
			set
			{
				this.m_NFields = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000B69D File Offset: 0x0000989D
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public FieldDescriptor[] FieldDescriptors
		{
			get
			{
				return this.m_FieldDescriptors;
			}
			set
			{
				this.m_FieldDescriptors = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000B6AE File Offset: 0x000098AE
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000B6B6 File Offset: 0x000098B6
		public HuffmannTree HuffmannTree
		{
			get
			{
				return this.m_HuffmannTree;
			}
			set
			{
				this.m_HuffmannTree = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000B6BF File Offset: 0x000098BF
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000B6C6 File Offset: 0x000098C6
		public static DataSet DescriptorDataSet
		{
			get
			{
				return TableDescriptor.s_DescriptorDataSet;
			}
			set
			{
				TableDescriptor.s_DescriptorDataSet = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000B6CE File Offset: 0x000098CE
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000B6D6 File Offset: 0x000098D6
		public string TableName
		{
			get
			{
				return this.m_TableName;
			}
			set
			{
				this.m_TableName = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000B6DF File Offset: 0x000098DF
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000B6E7 File Offset: 0x000098E7
		public string TableShortName
		{
			get
			{
				return this.m_TableShortName;
			}
			set
			{
				this.m_TableShortName = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000B6F0 File Offset: 0x000098F0
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public int RecordSize
		{
			get
			{
				return this.m_RecordSize;
			}
			set
			{
				this.m_RecordSize = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000B701 File Offset: 0x00009901
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000B709 File Offset: 0x00009909
		public int NKeyFields
		{
			get
			{
				return this.m_NKeyFields;
			}
			set
			{
				this.m_NKeyFields = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000B712 File Offset: 0x00009912
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000B71A File Offset: 0x0000991A
		public int[] KeyIndex
		{
			get
			{
				return this.m_KeyIndex;
			}
			set
			{
				this.m_KeyIndex = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000B723 File Offset: 0x00009923
		public int NFloatFields
		{
			get
			{
				return this.m_NFloatFields;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000B72B File Offset: 0x0000992B
		public int NStringFields
		{
			get
			{
				return this.m_NStringFields;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000B733 File Offset: 0x00009933
		public int NCompressedStringFields
		{
			get
			{
				return this.m_NCompressedStringFields;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000B73B File Offset: 0x0000993B
		public int NIntFields
		{
			get
			{
				return this.m_NIntFields;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000B743 File Offset: 0x00009943
		public int[] MinValues
		{
			get
			{
				return this.m_MinValues;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000B74B File Offset: 0x0000994B
		public int[] MaxValues
		{
			get
			{
				return this.m_MaxValues;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000B753 File Offset: 0x00009953
		public void SortFields()
		{
			if (this.m_FieldDescriptors == null)
			{
				return;
			}
			if (this.m_FieldDescriptors.Length >= 2)
			{
				Array.Sort(this.m_FieldDescriptors, TableDescriptor.s_FieldComparer);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B779 File Offset: 0x00009979
		public void LoadTableName(DbReader r)
		{
			this.m_ShortName = r.ReadChars(4);
			this.m_TableShortName = new string(this.m_ShortName);
			this.AssignXmlTableName();
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B7A0 File Offset: 0x000099A0
		public void LoadFieldDescriptors(DbReader r)
		{
			this.m_FieldDescriptors = new FieldDescriptor[this.m_NFields];
			this.m_NKeyFields = 0;
			this.m_NFloatFields = 0;
			this.m_NIntFields = 0;
			this.m_NStringFields = 0;
			this.m_NCompressedStringFields = 0;
			this.m_MinValues = new int[this.m_NFields];
			this.m_MaxValues = new int[this.m_NFields];
			this.m_KeyIndex = new int[4];
			for (int i = 0; i < this.m_NFields; i++)
			{
				this.m_FieldDescriptors[i] = new FieldDescriptor(this);
				this.m_FieldDescriptors[i].Load(r);
				this.m_FieldDescriptors[i].OrderInTheTable = i;
				this.m_FieldDescriptors[i].AssignXmlDescriptor(TableDescriptor.s_DescriptorDataSet);
				FieldDescriptor.EFieldTypes fieldType = this.m_FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NStringFields;
					this.m_NStringFields++;
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NIntFields;
					this.m_MinValues[this.m_NIntFields] = this.m_FieldDescriptors[i].RangeLow;
					this.m_MaxValues[this.m_NIntFields] = this.m_FieldDescriptors[i].RangeHigh;
					this.m_NIntFields++;
					break;
				case FieldDescriptor.EFieldTypes.Float:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NFloatFields;
					this.m_NFloatFields++;
					break;
				default:
					if (fieldType == FieldDescriptor.EFieldTypes.ShortCompressedString || fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
					{
						this.m_FieldDescriptors[i].TypeIndex = this.m_NCompressedStringFields;
						this.m_NCompressedStringFields++;
					}
					break;
				}
			}
			this.AssignXmlTableIndex();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000B968 File Offset: 0x00009B68
		public void SaveFieldDescriptors(BinaryWriter w)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				for (int j = 0; j < this.m_NFields; j++)
				{
					if (this.m_FieldDescriptors[j].OrderInTheTable == i)
					{
						this.m_FieldDescriptors[j].Save(w);
						break;
					}
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		private void AssignXmlTableName()
		{
			if (TableDescriptor.s_DescriptorDataSet != null)
			{
				int count = TableDescriptor.s_DescriptorDataSet.Tables["table"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = TableDescriptor.s_DescriptorDataSet.Tables["table"].Rows[i];
					if ((string)dataRow["shortname"] == this.m_TableShortName)
					{
						string text = (string)dataRow["name"];
						this.m_TableName = text;
						return;
					}
				}
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000BA50 File Offset: 0x00009C50
		private void AssignXmlTableIndex()
		{
			if (TableDescriptor.s_DescriptorDataSet != null)
			{
				int count = TableDescriptor.s_DescriptorDataSet.Tables["index"].Rows.Count;
				int count2 = TableDescriptor.s_DescriptorDataSet.Tables["indexfield"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = TableDescriptor.s_DescriptorDataSet.Tables["index"].Rows[i];
					if ((string)dataRow["tableshortname"] == this.m_TableShortName)
					{
						int num = (int)dataRow.ItemArray[0];
						for (int j = 0; j < count2; j++)
						{
							DataRow dataRow2 = TableDescriptor.s_DescriptorDataSet.Tables["indexfield"].Rows[j];
							if ((int)dataRow2[2] == num)
							{
								string text = (string)dataRow2[0];
								int num2 = 0;
								for (int k = 0; k < this.m_NFields; k++)
								{
									if (this.m_FieldDescriptors[k].FieldShortName == text)
									{
										int[] keyIndex = this.m_KeyIndex;
										int nkeyFields = this.m_NKeyFields;
										this.m_NKeyFields = nkeyFields + 1;
										keyIndex[nkeyFields] = num2;
										break;
									}
									if (this.m_FieldDescriptors[k].FieldType == FieldDescriptor.EFieldTypes.Integer)
									{
										num2++;
									}
								}
							}
						}
						return;
					}
				}
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		public FieldDescriptor GetFieldDescriptor(string longName)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				if (this.m_FieldDescriptors[i].FieldName == longName)
				{
					return this.m_FieldDescriptors[i];
				}
			}
			return null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000BC04 File Offset: 0x00009E04
		public int GetFieldIndex(string fieldName)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				if (fieldName == this.FieldDescriptors[i].FieldName)
				{
					return this.FieldDescriptors[i].TypeIndex;
				}
			}
			return -1;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000BC48 File Offset: 0x00009E48
		public void RecalculateFieldOffset()
		{
			int[] array = new int[this.NFields];
			int num = 0;
			uint num2 = 0U;
			do
			{
				uint num3 = this.m_NBitRecords;
				for (int i = 0; i < this.NFields; i++)
				{
					if ((long)this.FieldDescriptors[i].BitOffset >= (long)((ulong)num2) && (long)this.FieldDescriptors[i].BitOffset < (long)((ulong)num3))
					{
						array[num] = i;
						num3 = (uint)this.FieldDescriptors[i].BitOffset;
					}
				}
				num2 = num3 + 1U;
				num++;
			}
			while (num < this.NFields);
			num2 = 0U;
			int j = 0;
			while (j < this.NFields)
			{
				FieldDescriptor.EFieldTypes efieldTypes = this.FieldDescriptors[array[j]].FieldType;
				switch (efieldTypes)
				{
				case FieldDescriptor.EFieldTypes.String:
					if (num2 % 8U != 0U)
					{
						num2 = (num2 + 7U) & 4294967288U;
					}
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
				case FieldDescriptor.EFieldTypes.Integer:
					break;
				case FieldDescriptor.EFieldTypes.Float:
					goto IL_00BC;
				default:
					if (efieldTypes == FieldDescriptor.EFieldTypes.ShortCompressedString || efieldTypes == FieldDescriptor.EFieldTypes.LongCompressedString)
					{
						goto IL_00BC;
					}
					break;
				}
				IL_00D8:
				this.FieldDescriptors[array[j]].BitOffset = (int)num2;
				efieldTypes = this.FieldDescriptors[array[j]].FieldType;
				switch (efieldTypes)
				{
				case FieldDescriptor.EFieldTypes.String:
				case FieldDescriptor.EFieldTypes.Integer:
					num2 += (uint)this.FieldDescriptors[array[j]].Depth;
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Float:
					goto IL_0122;
				default:
					if (efieldTypes == FieldDescriptor.EFieldTypes.ShortCompressedString || efieldTypes == FieldDescriptor.EFieldTypes.LongCompressedString)
					{
						goto IL_0122;
					}
					break;
				}
				IL_013C:
				j++;
				continue;
				IL_0122:
				num2 += 32U;
				goto IL_013C;
				IL_00BC:
				if (num2 % 32U != 0U)
				{
					num2 = (num2 + 31U) & 4294967264U;
					goto IL_00D8;
				}
				goto IL_00D8;
			}
			int num4 = (int)((num2 + 7U) / 8U);
			if (num4 > this.m_RecordSize)
			{
				this.m_RecordSize = (num4 + 3) / 4 * 4;
				this.m_NBitRecords = (uint)(this.m_RecordSize * 8 - 1);
			}
		}

		// Token: 0x040000A7 RID: 167
		private char[] m_ShortName;

		// Token: 0x040000A8 RID: 168
		private uint m_NBitRecords;

		// Token: 0x040000A9 RID: 169
		private int m_NFields;

		// Token: 0x040000AA RID: 170
		private FieldDescriptor[] m_FieldDescriptors;

		// Token: 0x040000AB RID: 171
		private HuffmannTree m_HuffmannTree;

		// Token: 0x040000AC RID: 172
		private static DataSet s_DescriptorDataSet;

		// Token: 0x040000AD RID: 173
		private string m_TableName;

		// Token: 0x040000AE RID: 174
		private string m_TableShortName;

		// Token: 0x040000AF RID: 175
		private int m_RecordSize;

		// Token: 0x040000B0 RID: 176
		private int m_NKeyFields;

		// Token: 0x040000B1 RID: 177
		private int[] m_KeyIndex;

		// Token: 0x040000B2 RID: 178
		private int m_NFloatFields;

		// Token: 0x040000B3 RID: 179
		private int m_NStringFields;

		// Token: 0x040000B4 RID: 180
		private int m_NCompressedStringFields;

		// Token: 0x040000B5 RID: 181
		private int m_NIntFields;

		// Token: 0x040000B6 RID: 182
		private int[] m_MinValues;

		// Token: 0x040000B7 RID: 183
		private int[] m_MaxValues;

		// Token: 0x040000B8 RID: 184
		private static FieldComparer s_FieldComparer = new FieldComparer();
	}
}
