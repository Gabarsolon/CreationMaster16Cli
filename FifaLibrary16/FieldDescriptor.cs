using System;
using System.Data;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200002B RID: 43
	public class FieldDescriptor
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000BDDF File Offset: 0x00009FDF
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000BDE7 File Offset: 0x00009FE7
		public TableDescriptor TableDescriptor
		{
			get
			{
				return this.m_TableDescriptor;
			}
			set
			{
				this.m_TableDescriptor = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		public FieldDescriptor.EFieldTypes FieldType
		{
			get
			{
				return this.m_FieldType;
			}
			set
			{
				this.m_FieldType = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000BE01 File Offset: 0x0000A001
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000BE09 File Offset: 0x0000A009
		public int BitOffset
		{
			get
			{
				return this.m_BitOffset;
			}
			set
			{
				this.m_BitOffset = value;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000BE12 File Offset: 0x0000A012
		public FieldDescriptor(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000BE21 File Offset: 0x0000A021
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000BE29 File Offset: 0x0000A029
		public int Depth
		{
			get
			{
				return this.m_Depth;
			}
			set
			{
				this.m_Depth = value;
				this.m_Mask = (int)((1L << this.m_Depth) - 1L);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000BE48 File Offset: 0x0000A048
		public int Mask
		{
			get
			{
				return this.m_Mask;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000BE58 File Offset: 0x0000A058
		public string FieldShortName
		{
			get
			{
				return this.m_FieldShortName;
			}
			set
			{
				this.m_FieldShortName = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000BE61 File Offset: 0x0000A061
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000BE69 File Offset: 0x0000A069
		public string FieldName
		{
			get
			{
				return this.m_FieldName;
			}
			set
			{
				this.m_FieldName = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000BE72 File Offset: 0x0000A072
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000BE7A File Offset: 0x0000A07A
		public int RangeLow
		{
			get
			{
				return this.m_RangeLow;
			}
			set
			{
				this.m_RangeLow = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000BE83 File Offset: 0x0000A083
		public int RangeHigh
		{
			get
			{
				return this.m_RangeHigh;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000BE8B File Offset: 0x0000A08B
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000BE93 File Offset: 0x0000A093
		public int TypeIndex
		{
			get
			{
				return this.m_TypeIndex;
			}
			set
			{
				this.m_TypeIndex = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000BE9C File Offset: 0x0000A09C
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
		public int OrderInTheTable
		{
			get
			{
				return this.m_OrderInTheTable;
			}
			set
			{
				this.m_OrderInTheTable = value;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public void Load(DbReader r)
		{
			this.m_FieldType = (FieldDescriptor.EFieldTypes)r.ReadInt32();
			this.m_BitOffset = r.ReadInt32();
			this.m_ShortName = r.ReadBytes(4);
			this.m_Depth = r.ReadInt32();
			this.m_FieldShortName = FifaUtil.ConvertBytesToString(this.m_ShortName);
			this.m_FieldName = this.m_FieldShortName;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000BF0B File Offset: 0x0000A10B
		public void Save(BinaryWriter w)
		{
			w.Write((int)this.m_FieldType);
			w.Write(this.m_BitOffset);
			w.Write(this.m_ShortName);
			w.Write(this.m_Depth);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000BF40 File Offset: 0x0000A140
		public void AssignXmlDescriptor(DataSet descriptorDataSet)
		{
			if (descriptorDataSet != null)
			{
				int count = descriptorDataSet.Tables["field"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = descriptorDataSet.Tables["field"].Rows[i];
					if (this.m_FieldShortName == (string)dataRow["shortname"])
					{
						int num = (int)dataRow["fields_Id"];
						int num2 = (int)descriptorDataSet.Tables["fields"].Rows[num]["table_Id"];
						if ((string)descriptorDataSet.Tables["table"].Rows[num2]["shortname"] == this.m_TableDescriptor.TableShortName)
						{
							this.m_FieldName = (string)dataRow["name"];
							this.m_RangeLow = Convert.ToInt32((string)dataRow["rangelow"]);
							this.m_RangeHigh = Convert.ToInt32((string)dataRow["rangehigh"]);
							this.m_XmlDataRow = dataRow;
							return;
						}
					}
				}
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000C08C File Offset: 0x0000A28C
		public bool Expand(int depth)
		{
			if (depth < this.m_Depth)
			{
				return false;
			}
			if (depth > this.m_Depth)
			{
				int depth2 = this.m_Depth;
				this.m_Depth = depth;
				this.m_XmlDataRow["depth"] = this.m_Depth.ToString();
			}
			int num = 1 << this.m_Depth;
			this.m_RangeHigh = this.m_RangeLow + num - 1;
			this.m_XmlDataRow["rangehigh"] = this.m_RangeHigh.ToString();
			return true;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000C10E File Offset: 0x0000A30E
		public bool Expand(int depth, int minValue)
		{
			this.m_RangeLow = minValue;
			this.m_XmlDataRow["rangelow"] = this.m_RangeLow.ToString();
			return this.Expand(depth);
		}

		// Token: 0x040000B9 RID: 185
		private DataRow m_XmlDataRow;

		// Token: 0x040000BA RID: 186
		private TableDescriptor m_TableDescriptor;

		// Token: 0x040000BB RID: 187
		private FieldDescriptor.EFieldTypes m_FieldType;

		// Token: 0x040000BC RID: 188
		private int m_BitOffset;

		// Token: 0x040000BD RID: 189
		private byte[] m_ShortName;

		// Token: 0x040000BE RID: 190
		private int m_Depth;

		// Token: 0x040000BF RID: 191
		private int m_Mask;

		// Token: 0x040000C0 RID: 192
		private string m_FieldShortName;

		// Token: 0x040000C1 RID: 193
		private string m_FieldName;

		// Token: 0x040000C2 RID: 194
		private int m_RangeLow;

		// Token: 0x040000C3 RID: 195
		private int m_RangeHigh;

		// Token: 0x040000C4 RID: 196
		private int m_TypeIndex;

		// Token: 0x040000C5 RID: 197
		private int m_OrderInTheTable;

		// Token: 0x020000AD RID: 173
		public enum EFieldTypes
		{
			// Token: 0x04001249 RID: 4681
			String,
			// Token: 0x0400124A RID: 4682
			Integer = 3,
			// Token: 0x0400124B RID: 4683
			Float,
			// Token: 0x0400124C RID: 4684
			ShortCompressedString = 13,
			// Token: 0x0400124D RID: 4685
			LongCompressedString
		}
	}
}
