using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FifaLibrary
{
	// Token: 0x02000057 RID: 87
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("Messages")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class Messages : DataSet
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x0002AE58 File Offset: 0x00029058
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Messages()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002AEAC File Offset: 0x000290AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Messages(SerializationInfo info, StreamingContext context)
			: base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += collectionChangeEventHandler;
				this.Relations.CollectionChanged += collectionChangeEventHandler;
				return;
			}
			string text = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
				if (dataSet.Tables["DataTableMex"] != null)
				{
					base.Tables.Add(new Messages.DataTableMexDataTable(dataSet.Tables["DataTableMex"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler collectionChangeEventHandler2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler2;
			this.Relations.CollectionChanged += collectionChangeEventHandler2;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002B009 File Offset: 0x00029209
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Messages.DataTableMexDataTable DataTableMex
		{
			get
			{
				return this.tableDataTableMex;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0002B011 File Offset: 0x00029211
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0002B019 File Offset: 0x00029219
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00009C8A File Offset: 0x00007E8A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00009C92 File Offset: 0x00007E92
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002B022 File Offset: 0x00029222
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002B036 File Offset: 0x00029236
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			Messages messages = (Messages)base.Clone();
			messages.InitVars();
			messages.SchemaSerializationMode = this.SchemaSerializationMode;
			return messages;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002B058 File Offset: 0x00029258
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTableMex"] != null)
				{
					base.Tables.Add(new Messages.DataTableMexDataTable(dataSet.Tables["DataTableMex"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
				return;
			}
			base.ReadXml(reader);
			this.InitVars();
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002B120 File Offset: 0x00029320
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002B154 File Offset: 0x00029354
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002B15D File Offset: 0x0002935D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableDataTableMex = (Messages.DataTableMexDataTable)base.Tables["DataTableMex"];
			if (initTable && this.tableDataTableMex != null)
			{
				this.tableDataTableMex.InitVars();
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002B190 File Offset: 0x00029390
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "Messages";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/Messages.xsd";
			base.Locale = new CultureInfo("");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDataTableMex = new Messages.DataTableMexDataTable();
			base.Tables.Add(this.tableDataTableMex);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTableMex()
		{
			return false;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002B1F8 File Offset: 0x000293F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002B20C File Offset: 0x0002940C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Messages messages = new Messages();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = messages.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = messages.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		// Token: 0x04000E8E RID: 3726
		private Messages.DataTableMexDataTable tableDataTableMex;

		// Token: 0x04000E8F RID: 3727
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x06000F8C RID: 3980
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTableMexRowChangeEventHandler(object sender, Messages.DataTableMexRowChangeEvent e);

		// Token: 0x020000B4 RID: 180
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTableMexDataTable : TypedTableBase<Messages.DataTableMexRow>
		{
			// Token: 0x06000F8F RID: 3983 RVA: 0x0005D140 File Offset: 0x0005B340
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableMexDataTable()
			{
				base.TableName = "DataTableMex";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000F90 RID: 3984 RVA: 0x0005D168 File Offset: 0x0005B368
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableMexDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000F91 RID: 3985 RVA: 0x0005D210 File Offset: 0x0005B410
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTableMexDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0005D220 File Offset: 0x0005B420
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MexIdColumn
			{
				get
				{
					return this.columnMexId;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x06000F93 RID: 3987 RVA: 0x0005D228 File Offset: 0x0005B428
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MexTextColumn
			{
				get
				{
					return this.columnMexText;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06000F94 RID: 3988 RVA: 0x0005D230 File Offset: 0x0005B430
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MexSuppressedColumn
			{
				get
				{
					return this.columnMexSuppressed;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0005C950 File Offset: 0x0005AB50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000348 RID: 840
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow this[int index]
			{
				get
				{
					return (Messages.DataTableMexRow)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x06000F97 RID: 3991 RVA: 0x0005D24C File Offset: 0x0005B44C
			// (remove) Token: 0x06000F98 RID: 3992 RVA: 0x0005D284 File Offset: 0x0005B484
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x06000F99 RID: 3993 RVA: 0x0005D2BC File Offset: 0x0005B4BC
			// (remove) Token: 0x06000F9A RID: 3994 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x06000F9B RID: 3995 RVA: 0x0005D32C File Offset: 0x0005B52C
			// (remove) Token: 0x06000F9C RID: 3996 RVA: 0x0005D364 File Offset: 0x0005B564
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x06000F9D RID: 3997 RVA: 0x0005D39C File Offset: 0x0005B59C
			// (remove) Token: 0x06000F9E RID: 3998 RVA: 0x0005D3D4 File Offset: 0x0005B5D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowDeleted;

			// Token: 0x06000F9F RID: 3999 RVA: 0x0005CB2D File Offset: 0x0005AD2D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTableMexRow(Messages.DataTableMexRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x0005D40C File Offset: 0x0005B60C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow AddDataTableMexRow(int MexId, string MexText, bool MexSuppressed)
			{
				Messages.DataTableMexRow dataTableMexRow = (Messages.DataTableMexRow)base.NewRow();
				object[] array = new object[] { MexId, MexText, MexSuppressed };
				dataTableMexRow.ItemArray = array;
				base.Rows.Add(dataTableMexRow);
				return dataTableMexRow;
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x0005D456 File Offset: 0x0005B656
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Messages.DataTableMexDataTable dataTableMexDataTable = (Messages.DataTableMexDataTable)base.Clone();
				dataTableMexDataTable.InitVars();
				return dataTableMexDataTable;
			}

			// Token: 0x06000FA2 RID: 4002 RVA: 0x0005D469 File Offset: 0x0005B669
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Messages.DataTableMexDataTable();
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x0005D470 File Offset: 0x0005B670
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnMexId = base.Columns["MexId"];
				this.columnMexText = base.Columns["MexText"];
				this.columnMexSuppressed = base.Columns["MexSuppressed"];
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnMexId = new DataColumn("MexId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnMexId);
				this.columnMexText = new DataColumn("MexText", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMexText);
				this.columnMexSuppressed = new DataColumn("MexSuppressed", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnMexSuppressed);
				this.columnMexId.AllowDBNull = false;
				this.columnMexText.AllowDBNull = false;
				this.columnMexSuppressed.AllowDBNull = false;
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x0005D578 File Offset: 0x0005B778
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow NewDataTableMexRow()
			{
				return (Messages.DataTableMexRow)base.NewRow();
			}

			// Token: 0x06000FA6 RID: 4006 RVA: 0x0005D585 File Offset: 0x0005B785
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Messages.DataTableMexRow(builder);
			}

			// Token: 0x06000FA7 RID: 4007 RVA: 0x0005D58D File Offset: 0x0005B78D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Messages.DataTableMexRow);
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x0005D599 File Offset: 0x0005B799
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DataTableMexRowChanged != null)
				{
					this.DataTableMexRowChanged(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FA9 RID: 4009 RVA: 0x0005D5CC File Offset: 0x0005B7CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DataTableMexRowChanging != null)
				{
					this.DataTableMexRowChanging(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FAA RID: 4010 RVA: 0x0005D5FF File Offset: 0x0005B7FF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DataTableMexRowDeleted != null)
				{
					this.DataTableMexRowDeleted(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FAB RID: 4011 RVA: 0x0005D632 File Offset: 0x0005B832
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DataTableMexRowDeleting != null)
				{
					this.DataTableMexRowDeleting(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FAC RID: 4012 RVA: 0x0005CD6D File Offset: 0x0005AF6D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTableMexRow(Messages.DataTableMexRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x0005D668 File Offset: 0x0005B868
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Messages messages = new Messages();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = messages.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTableMexDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = messages.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04001261 RID: 4705
			private DataColumn columnMexId;

			// Token: 0x04001262 RID: 4706
			private DataColumn columnMexText;

			// Token: 0x04001263 RID: 4707
			private DataColumn columnMexSuppressed;
		}

		// Token: 0x020000B5 RID: 181
		public class DataTableMexRow : DataRow
		{
			// Token: 0x06000FAE RID: 4014 RVA: 0x0005D85C File Offset: 0x0005BA5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableMexRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDataTableMex = (Messages.DataTableMexDataTable)base.Table;
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0005D876 File Offset: 0x0005BA76
			// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x0005D88E File Offset: 0x0005BA8E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int MexId
			{
				get
				{
					return (int)base[this.tableDataTableMex.MexIdColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexIdColumn] = value;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0005D8A7 File Offset: 0x0005BAA7
			// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0005D8BF File Offset: 0x0005BABF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string MexText
			{
				get
				{
					return (string)base[this.tableDataTableMex.MexTextColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexTextColumn] = value;
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0005D8D3 File Offset: 0x0005BAD3
			// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0005D8EB File Offset: 0x0005BAEB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool MexSuppressed
			{
				get
				{
					return (bool)base[this.tableDataTableMex.MexSuppressedColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexSuppressedColumn] = value;
				}
			}

			// Token: 0x04001268 RID: 4712
			private Messages.DataTableMexDataTable tableDataTableMex;
		}

		// Token: 0x020000B6 RID: 182
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTableMexRowChangeEvent : EventArgs
		{
			// Token: 0x06000FB5 RID: 4021 RVA: 0x0005D904 File Offset: 0x0005BB04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableMexRowChangeEvent(Messages.DataTableMexRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0005D91A File Offset: 0x0005BB1A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0005D922 File Offset: 0x0005BB22
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04001269 RID: 4713
			private Messages.DataTableMexRow eventRow;

			// Token: 0x0400126A RID: 4714
			private DataRowAction eventAction;
		}
	}
}
