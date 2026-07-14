using System;
using System.Data;
using System.Globalization;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200002E RID: 46
	public class Record
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		public int[] CompressedStringOffset
		{
			get
			{
				return this.m_CompressedStringOffset;
			}
			set
			{
				this.m_CompressedStringOffset = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000D0E9 File Offset: 0x0000B2E9
		// (set) Token: 0x06000324 RID: 804 RVA: 0x0000D0F1 File Offset: 0x0000B2F1
		public int[] CompressedStringFieldIndex
		{
			get
			{
				return this.m_CompressedStringFieldIndex;
			}
			set
			{
				this.m_CompressedStringFieldIndex = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000D0FA File Offset: 0x0000B2FA
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000D102 File Offset: 0x0000B302
		public string[] CompressedString
		{
			get
			{
				return this.m_CompressedString;
			}
			set
			{
				this.m_CompressedString = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000D10B File Offset: 0x0000B30B
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000D112 File Offset: 0x0000B312
		public static int HuffmannTreeSize
		{
			get
			{
				return Record.m_HuffmannTreeSize;
			}
			set
			{
				Record.m_HuffmannTreeSize = value;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000D11C File Offset: 0x0000B31C
		public int GetIntField(string fieldName)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					return this.m_IntField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
			}
			return 0;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000D174 File Offset: 0x0000B374
		public bool SetField(string fieldName, int value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					this.m_IntField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		public float GetFloatField(string fieldName)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					return this.m_FloatField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
			}
			return float.NaN;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000D22C File Offset: 0x0000B42C
		public bool SetField(string fieldName, float value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					this.m_FloatField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000D288 File Offset: 0x0000B488
		public string GetStringField(string fieldName)
		{
			int i = 0;
			while (i < this.TableDescriptor.NFields)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					if (this.TableDescriptor.FieldDescriptors[i].FieldType == FieldDescriptor.EFieldTypes.String)
					{
						return this.m_StringField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
					}
					return this.m_CompressedString[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
				else
				{
					i++;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000D314 File Offset: 0x0000B514
		public bool SetField(string fieldName, string value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					if (this.TableDescriptor.FieldDescriptors[i].FieldType == FieldDescriptor.EFieldTypes.String)
					{
						this.m_StringField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					}
					else
					{
						this.m_CompressedString[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000D39E File Offset: 0x0000B59E
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0000D3A6 File Offset: 0x0000B5A6
		public int[] KeyField
		{
			get
			{
				return this.m_KeyField;
			}
			set
			{
				this.m_KeyField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000D3AF File Offset: 0x0000B5AF
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000D3B7 File Offset: 0x0000B5B7
		public float[] FloatField
		{
			get
			{
				return this.m_FloatField;
			}
			set
			{
				this.m_FloatField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		public int[] PtrToStringField
		{
			get
			{
				return this.m_PtrToStringField;
			}
			set
			{
				this.m_PtrToStringField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000D3D1 File Offset: 0x0000B5D1
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0000D3D9 File Offset: 0x0000B5D9
		public int[] IntField
		{
			get
			{
				return this.m_IntField;
			}
			set
			{
				this.m_IntField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000D3E2 File Offset: 0x0000B5E2
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0000D3EA File Offset: 0x0000B5EA
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000D3F3 File Offset: 0x0000B5F3
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000D3FB File Offset: 0x0000B5FB
		public string[] StringField
		{
			get
			{
				return this.m_StringField;
			}
			set
			{
				this.m_StringField = value;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000D404 File Offset: 0x0000B604
		public Record(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				this.m_KeyField = new int[this.m_TableDescriptor.NKeyFields];
			}
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				this.m_FloatField = new float[this.m_TableDescriptor.NFloatFields];
			}
			if (this.m_TableDescriptor.NStringFields > 0)
			{
				this.m_PtrToStringField = new int[this.m_TableDescriptor.NStringFields];
				this.m_StringField = new string[this.m_TableDescriptor.NStringFields];
			}
			if (this.m_TableDescriptor.NCompressedStringFields > 0)
			{
				this.m_CompressedStringOffset = new int[this.m_TableDescriptor.NCompressedStringFields];
				this.m_CompressedString = new string[this.m_TableDescriptor.NCompressedStringFields];
				this.m_CompressedStringFieldIndex = new int[this.m_TableDescriptor.NCompressedStringFields];
			}
			if (this.m_TableDescriptor.NIntFields > 0)
			{
				this.m_IntField = new int[this.m_TableDescriptor.NIntFields];
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000D514 File Offset: 0x0000B714
		public void LoadKeyFields(DbReader r)
		{
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NKeyFields; i++)
				{
					this.m_KeyField[i] = r.ReadInt32();
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000D554 File Offset: 0x0000B754
		public void LoadFloatFields(DbReader r)
		{
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NFloatFields; i++)
				{
					this.m_FloatField[i] = r.ReadSingle();
				}
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000D594 File Offset: 0x0000B794
		public void LoadStringFields(DbReader r)
		{
			if (this.m_TableDescriptor.NStringFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NStringFields; i++)
				{
					this.m_PtrToStringField[i] = r.ReadInt32();
					this.m_StringField[i] = FifaUtil.ReadString(r, this.m_PtrToStringField[i]);
				}
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public bool LoadIntFields(DbReader r)
		{
			int num = 0;
			byte b = 0;
			bool flag = true;
			int num2 = 0;
			for (int i = 0; i < this.m_TableDescriptor.NIntFields; i++)
			{
				int num3 = FifaUtil.ComputeBitUsed((uint)(this.m_TableDescriptor.MaxValues[i] - this.m_TableDescriptor.MinValues[i]));
				if (num3 == 32)
				{
					this.m_IntField[i] = r.ReadInt32();
				}
				else
				{
					int num4 = 0;
					uint num5 = 0U;
					while ((ulong)num5 < (ulong)((long)num3))
					{
						if (num == 0)
						{
							b = r.ReadByte();
							num = 8;
							num2++;
						}
						num4 *= 2;
						if (((int)b & (1 << num - 1)) != 0)
						{
							num4++;
						}
						num--;
						num5 += 1U;
					}
					this.m_IntField[i] = num4 + this.m_TableDescriptor.MinValues[i];
					bool flag2 = this.m_IntField[i] <= this.m_TableDescriptor.MaxValues[i];
				}
			}
			return flag;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public bool LoadCompressedStrings(DbReader r)
		{
			long position = r.BaseStream.Position;
			for (int i = 0; i < this.m_TableDescriptor.NCompressedStringFields; i++)
			{
				int num = this.m_CompressedStringFieldIndex[i];
				short num2 = 0;
				if (this.m_CompressedStringOffset[i] != -1)
				{
					r.BaseStream.Position = position + (long)this.m_CompressedStringOffset[i];
					FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[num].FieldType;
					if (fieldType != FieldDescriptor.EFieldTypes.ShortCompressedString)
					{
						if (fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
						{
							num2 = r.ReadInt16();
							num2 = FifaUtil.SwapEndian(num2);
						}
					}
					else
					{
						num2 = (short)r.ReadByte();
					}
				}
				this.m_CompressedString[i] = this.m_TableDescriptor.HuffmannTree.ReadString(r, (int)num2);
			}
			return true;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000D790 File Offset: 0x0000B990
		public bool Load(DbReader r)
		{
			long position = r.BaseStream.Position;
			int recordSize = this.m_TableDescriptor.RecordSize;
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int num = this.m_TableDescriptor.FieldDescriptors[i].BitOffset / 8;
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
				{
					r.Align(position + (long)num);
					int num2 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
					this.m_StringField[typeIndex] = FifaUtil.ReadNullPaddedString(r, num2);
					break;
				}
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					this.m_IntField[typeIndex] = r.PopInteger(this.m_TableDescriptor.FieldDescriptors[i]);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					r.Align(position + (long)num);
					this.m_FloatField[typeIndex] = r.ReadSingle();
					break;
				default:
					if (fieldType == FieldDescriptor.EFieldTypes.ShortCompressedString || fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
					{
						r.Align(position + (long)num);
						int num3 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
						int num4 = r.ReadInt32();
						this.m_CompressedStringOffset[typeIndex] = num4;
						this.m_CompressedStringFieldIndex[typeIndex] = i;
						if (num4 != -1 && num4 < Record.m_HuffmannTreeSize)
						{
							Record.m_HuffmannTreeSize = num4;
						}
						if (i < this.m_TableDescriptor.NFields - 1 && this.m_TableDescriptor.FieldDescriptors[i + 1].BitOffset != 32)
						{
							r.Align(position + (long)(this.m_TableDescriptor.FieldDescriptors[i + 1].BitOffset / 8));
						}
					}
					break;
				}
			}
			r.Align(position + (long)recordSize);
			return true;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000D958 File Offset: 0x0000BB58
		public void Fill(DbWriter w)
		{
			for (int i = 0; i < this.m_TableDescriptor.RecordSize; i++)
			{
				w.Write(205);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000D988 File Offset: 0x0000BB88
		public int Save(DbWriter w, long compressedStringBasePosition, int compressedStringOffset)
		{
			long position = w.BaseStream.Position;
			long num = position + (long)this.m_TableDescriptor.RecordSize;
			int recordSize = this.m_TableDescriptor.RecordSize;
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int num2 = this.m_TableDescriptor.FieldDescriptors[i].BitOffset / 8;
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
				{
					w.WritePendingByte();
					w.BaseStream.Position = position + (long)num2;
					int num3 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
					FifaUtil.WriteNullPaddedString(w, this.m_StringField[typeIndex], num3);
					break;
				}
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					w.PushInteger(this.m_IntField[typeIndex], this.m_TableDescriptor.FieldDescriptors[i]);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					w.WritePendingByte();
					w.BaseStream.Position = position + (long)num2;
					w.Write(this.m_FloatField[typeIndex]);
					break;
				default:
					if (fieldType != FieldDescriptor.EFieldTypes.ShortCompressedString)
					{
						if (fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
						{
							w.WritePendingByte();
							w.BaseStream.Position = position + (long)num2;
							if (this.m_CompressedString[typeIndex] == string.Empty)
							{
								w.Write(-1);
							}
							else
							{
								w.Write(compressedStringOffset);
							}
							w.BaseStream.Position = compressedStringBasePosition + (long)compressedStringOffset;
							compressedStringOffset += this.m_TableDescriptor.HuffmannTree.WriteString(w, this.m_CompressedString[typeIndex], true);
							w.BaseStream.Position = position + (long)num2 + 4L;
						}
					}
					else
					{
						w.WritePendingByte();
						w.BaseStream.Position = position + (long)num2;
						if (this.m_CompressedString[typeIndex] == string.Empty)
						{
							w.Write(-1);
						}
						else
						{
							w.Write(compressedStringOffset);
						}
						w.BaseStream.Position = compressedStringBasePosition + (long)compressedStringOffset;
						compressedStringOffset += this.m_TableDescriptor.HuffmannTree.WriteString(w, this.m_CompressedString[typeIndex], false);
						w.BaseStream.Position = position + (long)num2 + 4L;
					}
					break;
				}
			}
			w.WritePendingByte();
			w.Align(num);
			return compressedStringOffset;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		public void SaveKeyFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NKeyFields; i++)
				{
					w.Write(this.m_KeyField[i]);
				}
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000DC18 File Offset: 0x0000BE18
		public void SaveFloatFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NFloatFields; i++)
				{
					w.Write(this.m_FloatField[i]);
				}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000DC58 File Offset: 0x0000BE58
		public void SaveIntFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NIntFields > 0)
			{
				int num = 8;
				byte b = 0;
				for (int i = 0; i < this.m_TableDescriptor.NIntFields; i++)
				{
					int num2 = FifaUtil.ComputeBitUsed((uint)(this.m_TableDescriptor.MaxValues[i] - this.m_TableDescriptor.MinValues[i]));
					if (num2 == 32)
					{
						w.Write(this.m_IntField[i]);
					}
					else
					{
						int num3 = this.m_IntField[i] - this.m_TableDescriptor.MinValues[i];
						for (int j = num2 - 1; j >= 0; j--)
						{
							b *= 2;
							if ((num3 & (1 << j)) != 0)
							{
								b += 1;
							}
							num--;
							if (num == 0)
							{
								w.Write(b);
								num = 8;
								b = 0;
							}
						}
					}
				}
				if (num != 8)
				{
					b = (byte)(b << num);
					w.Write(b);
				}
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000DD34 File Offset: 0x0000BF34
		public object[] ConvertToDataRow()
		{
			object[] array = new object[this.m_TableDescriptor.NFields];
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					array[i] = this.m_StringField[typeIndex];
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					array[i] = this.m_IntField[typeIndex];
					break;
				case FieldDescriptor.EFieldTypes.Float:
					array[i] = this.m_FloatField[typeIndex];
					break;
				default:
					if (fieldType == FieldDescriptor.EFieldTypes.ShortCompressedString || fieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
					{
						array[i] = this.m_CompressedString[typeIndex];
					}
					break;
				}
			}
			return array;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		public void ConvertFromDataRow(DataRow dataRow)
		{
			for (int i = 0; i < dataRow.Table.Columns.Count; i++)
			{
				string columnName = dataRow.Table.Columns[i].ColumnName;
				int j = 0;
				while (j < this.m_TableDescriptor.FieldDescriptors.Length)
				{
					if (this.m_TableDescriptor.FieldDescriptors[j].FieldName == columnName)
					{
						int typeIndex = this.m_TableDescriptor.FieldDescriptors[j].TypeIndex;
						FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[j].FieldType;
						switch (fieldType)
						{
						case FieldDescriptor.EFieldTypes.String:
							this.m_StringField[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
							goto IL_010E;
						case (FieldDescriptor.EFieldTypes)1:
						case (FieldDescriptor.EFieldTypes)2:
							goto IL_010E;
						case FieldDescriptor.EFieldTypes.Integer:
						{
							int num = Convert.ToInt32(dataRow.ItemArray[i]);
							this.m_IntField[typeIndex] = num;
							goto IL_010E;
						}
						case FieldDescriptor.EFieldTypes.Float:
							this.m_FloatField[typeIndex] = Convert.ToSingle(dataRow.ItemArray[i], NumberFormatInfo.InvariantInfo);
							goto IL_010E;
						default:
							if (fieldType != FieldDescriptor.EFieldTypes.ShortCompressedString && fieldType != FieldDescriptor.EFieldTypes.LongCompressedString)
							{
								goto IL_010E;
							}
							this.m_CompressedString[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
							goto IL_010E;
						}
					}
					else
					{
						j++;
					}
				}
				IL_010E:;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000DF30 File Offset: 0x0000C130
		private int GetDataRowIndex(DataRow dataRow, string fieldName)
		{
			for (int i = 0; i < dataRow.Table.Columns.Count; i++)
			{
				if (dataRow.Table.Columns[i].ColumnName == fieldName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000DF7C File Offset: 0x0000C17C
		private int GetDataRowIntValue(DataRow dataRow, string fieldName)
		{
			for (int i = 0; i < dataRow.Table.Columns.Count; i++)
			{
				if (dataRow.Table.Columns[i].ColumnName == fieldName)
				{
					return Convert.ToInt32(dataRow.ItemArray[i]);
				}
			}
			return 0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000DFD4 File Offset: 0x0000C1D4
		public void ConvertFromDataRowFrom15To16(DataRow dataRow)
		{
			if (dataRow.Table.TableName == "formations")
			{
				this.SetField("playerinstruction0_2", 2);
				this.SetField("playerinstruction1_2", 2);
				this.SetField("playerinstruction2_2", 2);
				this.SetField("playerinstruction3_2", 2);
				this.SetField("playerinstruction4_2", 2);
				this.SetField("playerinstruction5_2", 2);
				this.SetField("playerinstruction6_2", 2);
				this.SetField("playerinstruction7_2", 2);
				this.SetField("playerinstruction8_2", 2);
				this.SetField("playerinstruction9_2", 2);
				this.SetField("playerinstruction10_2", 2);
				this.SetField("playerinstruction0_1", this.GetDataRowIntValue(dataRow, "playerinstruction0"));
				this.SetField("playerinstruction1_1", this.GetDataRowIntValue(dataRow, "playerinstruction1"));
				this.SetField("playerinstruction2_1", this.GetDataRowIntValue(dataRow, "playerinstruction2"));
				this.SetField("playerinstruction3_1", this.GetDataRowIntValue(dataRow, "playerinstruction3"));
				this.SetField("playerinstruction4_1", this.GetDataRowIntValue(dataRow, "playerinstruction4"));
				this.SetField("playerinstruction5_1", this.GetDataRowIntValue(dataRow, "playerinstruction5"));
				this.SetField("playerinstruction6_1", this.GetDataRowIntValue(dataRow, "playerinstruction6"));
				this.SetField("playerinstruction7_1", this.GetDataRowIntValue(dataRow, "playerinstruction7"));
				this.SetField("playerinstruction8_1", this.GetDataRowIntValue(dataRow, "playerinstruction8"));
				this.SetField("playerinstruction9_1", this.GetDataRowIntValue(dataRow, "playerinstruction9"));
				this.SetField("playerinstruction10_1", this.GetDataRowIntValue(dataRow, "playerinstruction10"));
			}
			for (int i = 0; i < dataRow.Table.Columns.Count; i++)
			{
				string columnName = dataRow.Table.Columns[i].ColumnName;
				int j = 0;
				while (j < this.m_TableDescriptor.FieldDescriptors.Length)
				{
					if (this.m_TableDescriptor.FieldDescriptors[j].FieldName == columnName)
					{
						int typeIndex = this.m_TableDescriptor.FieldDescriptors[j].TypeIndex;
						FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[j].FieldType;
						switch (fieldType)
						{
						case FieldDescriptor.EFieldTypes.String:
							this.m_StringField[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
							goto IL_02D7;
						case (FieldDescriptor.EFieldTypes)1:
						case (FieldDescriptor.EFieldTypes)2:
							goto IL_02D7;
						case FieldDescriptor.EFieldTypes.Integer:
						{
							int num = Convert.ToInt32(dataRow.ItemArray[i]);
							this.m_IntField[typeIndex] = num;
							goto IL_02D7;
						}
						case FieldDescriptor.EFieldTypes.Float:
							this.m_FloatField[typeIndex] = Convert.ToSingle(dataRow.ItemArray[i], NumberFormatInfo.InvariantInfo);
							goto IL_02D7;
						default:
							if (fieldType != FieldDescriptor.EFieldTypes.ShortCompressedString && fieldType != FieldDescriptor.EFieldTypes.LongCompressedString)
							{
								goto IL_02D7;
							}
							this.m_CompressedString[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
							goto IL_02D7;
						}
					}
					else
					{
						j++;
					}
				}
				IL_02D7:;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		public bool IsEmptyDataRow(DataRow dataRow)
		{
			int nkeyFields = this.m_TableDescriptor.NKeyFields;
			int nstringFields = this.m_TableDescriptor.NStringFields;
			int nfloatFields = this.m_TableDescriptor.NFloatFields;
			int nintFields = this.m_TableDescriptor.NIntFields;
			int num = nkeyFields + nstringFields + nfloatFields + nintFields;
			int num2 = 0;
			for (int i = 0; i < nkeyFields; i++)
			{
				this.m_KeyField[i] = Convert.ToInt32(dataRow.ItemArray[num2++]);
				if (this.m_KeyField[i] != 0)
				{
					return false;
				}
			}
			for (int j = 0; j < nfloatFields; j++)
			{
				this.m_FloatField[j] = (float)Convert.ToDouble(dataRow.ItemArray[num2++]);
				if ((double)this.m_FloatField[j] != 0.0)
				{
					return false;
				}
			}
			for (int k = 0; k < nstringFields; k++)
			{
				if (dataRow.ItemArray[num2] == DBNull.Value)
				{
					this.m_StringField[k] = string.Empty;
					num2++;
				}
				else
				{
					this.m_StringField[k] = (string)dataRow.ItemArray[num2++];
				}
				if (!string.IsNullOrEmpty(this.m_StringField[k]))
				{
					return false;
				}
			}
			for (int l = 0; l < nintFields; l++)
			{
				if (num2 < dataRow.ItemArray.Length)
				{
					this.m_IntField[l] = Convert.ToInt32(dataRow.ItemArray[num2++]);
					if (this.m_IntField[l] != 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000E448 File Offset: 0x0000C648
		public int GetAndCheckIntField(int index)
		{
			if (index < 0 || index >= this.m_IntField.Length)
			{
				return 0;
			}
			int num = this.m_IntField[index];
			if (this.m_TableDescriptor.MinValues[index] > this.m_TableDescriptor.MaxValues[index])
			{
				return num;
			}
			if (num < this.m_TableDescriptor.MinValues[index])
			{
				return this.m_TableDescriptor.MinValues[index];
			}
			if (num > this.m_TableDescriptor.MaxValues[index])
			{
				return this.m_TableDescriptor.MaxValues[index];
			}
			return num;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000E4CA File Offset: 0x0000C6CA
		public string GetAndCheckStringField(int index)
		{
			if (index < 0 || index >= this.m_StringField.Length)
			{
				return null;
			}
			return this.m_StringField[index];
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000E4E8 File Offset: 0x0000C6E8
		public int GetAndCheckExtendedIntField(int index)
		{
			if (index < 0 || index >= this.m_IntField.Length)
			{
				return 0;
			}
			int num = this.m_IntField[index];
			if (this.m_TableDescriptor.MinValues[index] > this.m_TableDescriptor.MaxValues[index])
			{
				return num;
			}
			int num2 = this.m_TableDescriptor.MinValues[index];
			int num3 = this.m_TableDescriptor.MaxValues[index];
			uint num4 = (uint)(num3 - num2);
			if (num4 != 0U)
			{
				int num5 = FifaUtil.ComputeBitUsed(num4);
				num3 = num2 + (1 << num5) - 1;
			}
			if (num < num2)
			{
				return num2;
			}
			if (num > num3)
			{
				return num3;
			}
			return num;
		}

		// Token: 0x040000D8 RID: 216
		private int[] m_CompressedStringOffset;

		// Token: 0x040000D9 RID: 217
		private int[] m_CompressedStringFieldIndex;

		// Token: 0x040000DA RID: 218
		private string[] m_CompressedString;

		// Token: 0x040000DB RID: 219
		private static int m_HuffmannTreeSize;

		// Token: 0x040000DC RID: 220
		private int[] m_KeyField;

		// Token: 0x040000DD RID: 221
		private float[] m_FloatField;

		// Token: 0x040000DE RID: 222
		private int[] m_PtrToStringField;

		// Token: 0x040000DF RID: 223
		private int[] m_IntField;

		// Token: 0x040000E0 RID: 224
		private TableDescriptor m_TableDescriptor;

		// Token: 0x040000E1 RID: 225
		private string[] m_StringField;
	}
}
