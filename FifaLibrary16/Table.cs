using System;
using System.Data;

namespace FifaLibrary
{
	// Token: 0x0200002D RID: 45
	public class Table
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000C541 File Offset: 0x0000A741
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000C549 File Offset: 0x0000A749
		public int Unknown00
		{
			get
			{
				return this.m_Unknown00;
			}
			set
			{
				this.m_Unknown00 = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000C552 File Offset: 0x0000A752
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000C55A File Offset: 0x0000A75A
		public uint CompressedStringLength
		{
			get
			{
				return this.m_CompressedStringLength;
			}
			set
			{
				this.m_CompressedStringLength = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000C563 File Offset: 0x0000A763
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0000C56B File Offset: 0x0000A76B
		public int Unknown14
		{
			get
			{
				return this.m_Unknown14;
			}
			set
			{
				this.m_Unknown14 = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000C574 File Offset: 0x0000A774
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000C57C File Offset: 0x0000A77C
		public int Unknown1C
		{
			get
			{
				return this.m_Unknown1C;
			}
			set
			{
				this.m_Unknown1C = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000C585 File Offset: 0x0000A785
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000C58D File Offset: 0x0000A78D
		public uint CrcTableHeader
		{
			get
			{
				return this.m_CrcTableHeader;
			}
			set
			{
				this.m_CrcTableHeader = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000C596 File Offset: 0x0000A796
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000C59E File Offset: 0x0000A79E
		public long CrcTableHeaderPosition
		{
			get
			{
				return this.m_CrcTableHeaderPosition;
			}
			set
			{
				this.m_CrcTableHeaderPosition = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000C5A7 File Offset: 0x0000A7A7
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000C5AF File Offset: 0x0000A7AF
		public uint CrcRecords
		{
			get
			{
				return this.m_CrcRecords;
			}
			set
			{
				this.m_CrcRecords = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public long CrcRecordsPosition
		{
			get
			{
				return this.m_CrcRecordsPosition;
			}
			set
			{
				this.m_CrcRecordsPosition = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000C5C9 File Offset: 0x0000A7C9
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000C5D1 File Offset: 0x0000A7D1
		public int NRecords
		{
			get
			{
				return this.m_NRecords;
			}
			set
			{
				this.m_NRecords = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000C5DA File Offset: 0x0000A7DA
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000C5E2 File Offset: 0x0000A7E2
		public int NValidRecords
		{
			get
			{
				return this.m_NValidRecords;
			}
			set
			{
				this.m_NValidRecords = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000C5EB File Offset: 0x0000A7EB
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000C5F3 File Offset: 0x0000A7F3
		public Record[] Records
		{
			get
			{
				return this.m_Records;
			}
			set
			{
				this.m_Records = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000C604 File Offset: 0x0000A804
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

		// Token: 0x0600030C RID: 780 RVA: 0x0000C60D File Offset: 0x0000A80D
		public Table()
		{
			this.m_TableDescriptor = new TableDescriptor();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000C620 File Offset: 0x0000A820
		public Table(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000C62F File Offset: 0x0000A82F
		public void LoadTableName(DbReader r)
		{
			this.m_TableDescriptor.LoadTableName(r);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000C640 File Offset: 0x0000A840
		public bool Load(DbReader r, long offset)
		{
			bool flag = true;
			r.BaseStream.Position = offset;
			this.m_Unknown00 = r.ReadInt32();
			this.m_TableDescriptor.RecordSize = r.ReadInt32();
			this.m_TableDescriptor.NBitRecords = r.ReadUInt32();
			this.m_CompressedStringLength = r.ReadUInt32();
			this.m_NRecords = (int)r.ReadUInt16();
			this.m_NValidRecords = (int)r.ReadUInt16();
			this.m_Unknown14 = r.ReadInt32();
			this.m_TableDescriptor.NFields = (int)r.ReadByte();
			r.ReadBytes(3);
			this.m_Unknown1C = r.ReadInt32();
			this.m_CrcTableHeaderPosition = r.BaseStream.Position;
			this.m_CrcTableHeader = r.ReadUInt32();
			this.m_TableDescriptor.LoadFieldDescriptors(r);
			this.m_TableDescriptor.SortFields();
			if (this.m_NRecords > 0)
			{
				this.m_Records = new Record[this.m_NRecords];
				Record.HuffmannTreeSize = int.MaxValue;
				for (int i = 0; i < this.m_NRecords; i++)
				{
					this.m_Records[i] = new Record(this.m_TableDescriptor);
					bool flag2 = this.m_Records[i].Load(r);
					flag = flag && flag2;
				}
				if (this.m_TableDescriptor.NCompressedStringFields > 0)
				{
					long position = r.BaseStream.Position;
					int num = Record.HuffmannTreeSize / 4;
					this.m_TableDescriptor.HuffmannTree = new HuffmannTree(num);
					this.m_TableDescriptor.HuffmannTree.Load(r);
					for (int j = 0; j < this.m_NRecords; j++)
					{
						r.BaseStream.Position = position;
						this.m_Records[j].LoadCompressedStrings(r);
					}
					r.BaseStream.Position = (long)((ulong)this.m_CompressedStringLength + (ulong)position);
				}
			}
			this.m_CrcRecordsPosition = r.BaseStream.Position;
			this.m_CrcRecords = r.ReadUInt32();
			return flag;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000C81C File Offset: 0x0000AA1C
		public void Save(DbWriter w)
		{
			w.Write(this.m_Unknown00);
			w.Write(this.m_TableDescriptor.RecordSize);
			w.Write(this.m_TableDescriptor.NBitRecords);
			long position = w.BaseStream.Position;
			if (this.m_TableDescriptor.NCompressedStringFields == 0)
			{
				w.Write(0);
			}
			else
			{
				w.Write(-1);
			}
			w.Write((ushort)this.m_NRecords);
			w.Write((ushort)this.m_NValidRecords);
			w.Write(this.m_Unknown14);
			w.Write((byte)this.m_TableDescriptor.NFields);
			w.Write(0);
			w.Write(0);
			w.Write(this.m_Unknown1C);
			this.m_CrcTableHeaderPosition = w.BaseStream.Position;
			w.Write(-1);
			this.m_TableDescriptor.SaveFieldDescriptors(w);
			long num = w.BaseStream.Position + (long)(this.m_NRecords * this.m_TableDescriptor.RecordSize);
			int num2 = 0;
			if (this.m_TableDescriptor.HuffmannTree != null)
			{
				num2 = this.m_TableDescriptor.HuffmannTree.Size;
			}
			if (this.m_NRecords > 0)
			{
				for (int i = 0; i < this.m_NValidRecords; i++)
				{
					num2 = this.m_Records[i].Save(w, num, num2);
				}
				for (int j = this.m_NValidRecords; j < this.m_NRecords; j++)
				{
					this.m_Records[j].Fill(w);
				}
				if (this.m_TableDescriptor.HuffmannTree != null)
				{
					w.BaseStream.Position = position;
					this.m_CompressedStringLength = (uint)num2;
					w.Write(num2);
					w.BaseStream.Position = num;
					this.m_TableDescriptor.HuffmannTree.Save(w);
				}
				num2 = FifaUtil.RoundUp(num2, 8);
				this.m_CrcRecordsPosition = num + (long)num2;
				w.BaseStream.Position = this.m_CrcRecordsPosition;
				w.Write(-1);
				return;
			}
			this.m_CrcRecordsPosition = w.BaseStream.Position;
			w.Write(-1);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000CA14 File Offset: 0x0000AC14
		public void SortByKeys()
		{
			if (this.m_TableDescriptor.KeyIndex.Length == 0)
			{
				return;
			}
			if (this.m_NRecords >= 2)
			{
				Array.Sort(this.m_Records, Table.s_RecordComparer);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000CA40 File Offset: 0x0000AC40
		public void SortByKeys(int keyIndex)
		{
			if (this.m_TableDescriptor.KeyIndex.Length == 0)
			{
				return;
			}
			int num = this.m_TableDescriptor.KeyIndex[0];
			this.m_TableDescriptor.KeyIndex[0] = keyIndex;
			if (this.m_TableDescriptor.NKeyFields == 0)
			{
				this.m_TableDescriptor.NKeyFields = 1;
			}
			if (this.m_NRecords >= 2)
			{
				Array.Sort(this.m_Records, Table.s_RecordComparer);
			}
			this.m_TableDescriptor.KeyIndex[0] = num;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		public Record SearchByKeys(Record r)
		{
			if (this.m_Records == null || r == null)
			{
				return null;
			}
			int num = Array.BinarySearch(this.m_Records, r, Table.s_RecordComparer);
			if (num >= 0)
			{
				return this.m_Records[num];
			}
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		public string SearchStringByKey(int key)
		{
			Record record = new Record(this.m_TableDescriptor);
			record.KeyField[0] = key;
			int num = Array.BinarySearch(this.m_Records, record, Table.s_RecordComparer);
			if (num >= 0)
			{
				return this.m_Records[num].StringField[0];
			}
			return null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000CB40 File Offset: 0x0000AD40
		public void ExchangeRecords(int i, int j)
		{
			Record record = new Record(this.m_TableDescriptor);
			record = this.m_Records[i];
			this.m_Records[i] = this.m_Records[j];
			this.m_Records[j] = record;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		public Record[] ResizeRecords(int nRecords)
		{
			int num = 0;
			if (this.m_Records != null)
			{
				num = this.m_Records.Length;
				Array.Resize<Record>(ref this.m_Records, nRecords);
			}
			else
			{
				this.m_Records = new Record[nRecords];
			}
			if (num < nRecords)
			{
				for (int i = num; i < nRecords; i++)
				{
					this.m_Records[i] = new Record(this.m_TableDescriptor);
				}
			}
			this.m_NRecords = nRecords;
			this.m_NValidRecords = nRecords;
			return this.m_Records;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		public bool ExpandField(string fieldName, int nBits)
		{
			FieldDescriptor fieldDescriptor = this.m_TableDescriptor.GetFieldDescriptor(fieldName);
			return fieldDescriptor != null && fieldDescriptor.Expand(nBits);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000CC18 File Offset: 0x0000AE18
		public bool ExpandField(string fieldName, int nBits, int minValue)
		{
			FieldDescriptor fieldDescriptor = this.m_TableDescriptor.GetFieldDescriptor(fieldName);
			return fieldDescriptor != null && fieldDescriptor.Expand(nBits, minValue);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public DataTable ConvertToDataTable()
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			for (int i = 0; i < this.m_NRecords; i++)
			{
				dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
			}
			return dataTable;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000CC80 File Offset: 0x0000AE80
		public DataTable ConvertToDataTable(int[] keys, string fieldName)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			int fieldIndex = this.m_TableDescriptor.GetFieldIndex(fieldName);
			Array.Sort<int>(keys);
			this.SortByKeys(fieldIndex);
			int num = 0;
			int i = num;
			int num2 = 0;
			while (num2 < keys.Length && i < this.m_NRecords)
			{
				i = num;
				while (i < this.m_NRecords)
				{
					if (this.Records[i].IntField[fieldIndex] >= keys[num2])
					{
						if (this.Records[i].IntField[fieldIndex] == keys[num2])
						{
							dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
							num = i + 1;
							break;
						}
						num = i;
						num2++;
						break;
					}
					else
					{
						i++;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000CD34 File Offset: 0x0000AF34
		public DataTable ConvertToDataTableUsingRtsg(int[] keys, string fieldName)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			int fieldIndex = this.m_TableDescriptor.GetFieldIndex(fieldName);
			Array.Sort<int>(keys);
			for (int i = 0; i < this.m_NRecords; i++)
			{
				int num = (this.Records[i].IntField[fieldIndex] >> 20) & 4095;
				for (int j = 0; j < keys.Length; j++)
				{
					if (keys[j] == num)
					{
						dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
						break;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		public DataTable ConvertToDataTableUsingIntField(int[] keys, int intFieldIndex)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			Array.Sort<int>(keys);
			for (int i = 0; i < this.m_NRecords; i++)
			{
				for (int j = 0; j < keys.Length; j++)
				{
					if (keys[j] == this.Records[i].IntField[intFieldIndex])
					{
						dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
						break;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000CE28 File Offset: 0x0000B028
		public DataTable CreateEmptyDataTable()
		{
			int num = 0;
			float num2 = 1f;
			object obj = "string";
			Type type = num.GetType();
			Type type2 = num2.GetType();
			Type type3 = obj.GetType();
			DataTable dataTable = new DataTable(this.m_TableDescriptor.TableName);
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type2);
					break;
				default:
					if (fieldType != FieldDescriptor.EFieldTypes.ShortCompressedString)
					{
						if (fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
						{
							dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
						}
					}
					else
					{
						dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
					}
					break;
				}
			}
			return dataTable;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000CF8C File Offset: 0x0000B18C
		public void ConvertFromDataTable(DataTable dataTable)
		{
			this.m_NRecords = dataTable.Rows.Count;
			this.m_NValidRecords = this.m_NRecords;
			if (this.Records != null)
			{
				this.ResizeRecords(this.m_NRecords);
			}
			else
			{
				this.Records = new Record[this.m_NRecords];
				for (int i = 0; i < this.m_NRecords; i++)
				{
					this.Records[i] = new Record(this.m_TableDescriptor);
				}
			}
			for (int j = 0; j < this.m_NRecords; j++)
			{
				this.Records[j].ConvertFromDataRow(dataTable.Rows[j]);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000D02C File Offset: 0x0000B22C
		public void ConvertFromDataTableFrom15To16(DataTable dataTable)
		{
			this.m_NRecords = dataTable.Rows.Count;
			this.m_NValidRecords = this.m_NRecords;
			if (this.Records != null)
			{
				this.ResizeRecords(this.m_NRecords);
			}
			else
			{
				this.Records = new Record[this.m_NRecords];
				for (int i = 0; i < this.m_NRecords; i++)
				{
					this.Records[i] = new Record(this.m_TableDescriptor);
				}
			}
			for (int j = 0; j < this.m_NRecords; j++)
			{
				this.Records[j].ConvertFromDataRowFrom15To16(dataTable.Rows[j]);
			}
		}

		// Token: 0x040000CB RID: 203
		private int m_Unknown00;

		// Token: 0x040000CC RID: 204
		private uint m_CompressedStringLength;

		// Token: 0x040000CD RID: 205
		private int m_Unknown14;

		// Token: 0x040000CE RID: 206
		private int m_Unknown1C;

		// Token: 0x040000CF RID: 207
		private uint m_CrcTableHeader;

		// Token: 0x040000D0 RID: 208
		private long m_CrcTableHeaderPosition;

		// Token: 0x040000D1 RID: 209
		private uint m_CrcRecords;

		// Token: 0x040000D2 RID: 210
		private long m_CrcRecordsPosition;

		// Token: 0x040000D3 RID: 211
		private int m_NRecords;

		// Token: 0x040000D4 RID: 212
		private int m_NValidRecords;

		// Token: 0x040000D5 RID: 213
		private static RecordComparer s_RecordComparer = new RecordComparer();

		// Token: 0x040000D6 RID: 214
		protected Record[] m_Records;

		// Token: 0x040000D7 RID: 215
		private TableDescriptor m_TableDescriptor;
	}
}
