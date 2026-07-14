using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FifaLibrary
{
	// Token: 0x02000025 RID: 37
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("CmsDataSet")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class CmsDataSet : DataSet
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00009AC0 File Offset: 0x00007CC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CmsDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009B14 File Offset: 0x00007D14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected CmsDataSet(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["CmsDataTable"] != null)
				{
					base.Tables.Add(new CmsDataSet.CmsDataTableDataTable(dataSet.Tables["CmsDataTable"]));
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00009C71 File Offset: 0x00007E71
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public CmsDataSet.CmsDataTableDataTable CmsDataTable
		{
			get
			{
				return this.tableCmsDataTable;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00009C79 File Offset: 0x00007E79
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00009C81 File Offset: 0x00007E81
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00009C8A File Offset: 0x00007E8A
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00009C92 File Offset: 0x00007E92
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

		// Token: 0x06000257 RID: 599 RVA: 0x00009C9A File Offset: 0x00007E9A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009CAE File Offset: 0x00007EAE
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			CmsDataSet cmsDataSet = (CmsDataSet)base.Clone();
			cmsDataSet.InitVars();
			cmsDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return cmsDataSet;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009CD0 File Offset: 0x00007ED0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["CmsDataTable"] != null)
				{
					base.Tables.Add(new CmsDataSet.CmsDataTableDataTable(dataSet.Tables["CmsDataTable"]));
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

		// Token: 0x0600025C RID: 604 RVA: 0x00009D98 File Offset: 0x00007F98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00009DCC File Offset: 0x00007FCC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00009DD5 File Offset: 0x00007FD5
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableCmsDataTable = (CmsDataSet.CmsDataTableDataTable)base.Tables["CmsDataTable"];
			if (initTable && this.tableCmsDataTable != null)
			{
				this.tableCmsDataTable.InitVars();
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009E08 File Offset: 0x00008008
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "CmsDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/CmsDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableCmsDataTable = new CmsDataSet.CmsDataTableDataTable();
			base.Tables.Add(this.tableCmsDataTable);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeCmsDataTable()
		{
			return false;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009E60 File Offset: 0x00008060
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009E74 File Offset: 0x00008074
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			CmsDataSet cmsDataSet = new CmsDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = cmsDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = cmsDataSet.GetSchemaSerializable();
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

		// Token: 0x0400008C RID: 140
		private CmsDataSet.CmsDataTableDataTable tableCmsDataTable;

		// Token: 0x0400008D RID: 141
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x06000F59 RID: 3929
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void CmsDataTableRowChangeEventHandler(object sender, CmsDataSet.CmsDataTableRowChangeEvent e);

		// Token: 0x020000AA RID: 170
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CmsDataTableDataTable : TypedTableBase<CmsDataSet.CmsDataTableRow>
		{
			// Token: 0x06000F5C RID: 3932 RVA: 0x0005C859 File Offset: 0x0005AA59
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataTableDataTable()
			{
				base.TableName = "CmsDataTable";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000F5D RID: 3933 RVA: 0x0005C880 File Offset: 0x0005AA80
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CmsDataTableDataTable(DataTable table)
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

			// Token: 0x06000F5E RID: 3934 RVA: 0x0005C928 File Offset: 0x0005AB28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected CmsDataTableDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0005C938 File Offset: 0x0005AB38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GroupColumn
			{
				get
				{
					return this.columnGroup;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0005C940 File Offset: 0x0005AB40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0005C948 File Offset: 0x0005AB48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0005C950 File Offset: 0x0005AB50
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

			// Token: 0x1700033E RID: 830
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow this[int index]
			{
				get
				{
					return (CmsDataSet.CmsDataTableRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x06000F64 RID: 3940 RVA: 0x0005C970 File Offset: 0x0005AB70
			// (remove) Token: 0x06000F65 RID: 3941 RVA: 0x0005C9A8 File Offset: 0x0005ABA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000F66 RID: 3942 RVA: 0x0005C9E0 File Offset: 0x0005ABE0
			// (remove) Token: 0x06000F67 RID: 3943 RVA: 0x0005CA18 File Offset: 0x0005AC18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x06000F68 RID: 3944 RVA: 0x0005CA50 File Offset: 0x0005AC50
			// (remove) Token: 0x06000F69 RID: 3945 RVA: 0x0005CA88 File Offset: 0x0005AC88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x06000F6A RID: 3946 RVA: 0x0005CAC0 File Offset: 0x0005ACC0
			// (remove) Token: 0x06000F6B RID: 3947 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowDeleted;

			// Token: 0x06000F6C RID: 3948 RVA: 0x0005CB2D File Offset: 0x0005AD2D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddCmsDataTableRow(CmsDataSet.CmsDataTableRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000F6D RID: 3949 RVA: 0x0005CB3C File Offset: 0x0005AD3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow AddCmsDataTableRow(string Group, string Name, int Id)
			{
				CmsDataSet.CmsDataTableRow cmsDataTableRow = (CmsDataSet.CmsDataTableRow)base.NewRow();
				object[] array = new object[] { Group, Name, Id };
				cmsDataTableRow.ItemArray = array;
				base.Rows.Add(cmsDataTableRow);
				return cmsDataTableRow;
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x0005CB81 File Offset: 0x0005AD81
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CmsDataSet.CmsDataTableDataTable cmsDataTableDataTable = (CmsDataSet.CmsDataTableDataTable)base.Clone();
				cmsDataTableDataTable.InitVars();
				return cmsDataTableDataTable;
			}

			// Token: 0x06000F6F RID: 3951 RVA: 0x0005CB94 File Offset: 0x0005AD94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CmsDataSet.CmsDataTableDataTable();
			}

			// Token: 0x06000F70 RID: 3952 RVA: 0x0005CB9C File Offset: 0x0005AD9C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnGroup = base.Columns["Group"];
				this.columnName = base.Columns["Name"];
				this.columnId = base.Columns["Id"];
			}

			// Token: 0x06000F71 RID: 3953 RVA: 0x0005CBEC File Offset: 0x0005ADEC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnGroup = new DataColumn("Group", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroup);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
			}

			// Token: 0x06000F72 RID: 3954 RVA: 0x0005CC80 File Offset: 0x0005AE80
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow NewCmsDataTableRow()
			{
				return (CmsDataSet.CmsDataTableRow)base.NewRow();
			}

			// Token: 0x06000F73 RID: 3955 RVA: 0x0005CC8D File Offset: 0x0005AE8D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CmsDataSet.CmsDataTableRow(builder);
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x0005CC95 File Offset: 0x0005AE95
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CmsDataSet.CmsDataTableRow);
			}

			// Token: 0x06000F75 RID: 3957 RVA: 0x0005CCA1 File Offset: 0x0005AEA1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CmsDataTableRowChanged != null)
				{
					this.CmsDataTableRowChanged(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000F76 RID: 3958 RVA: 0x0005CCD4 File Offset: 0x0005AED4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CmsDataTableRowChanging != null)
				{
					this.CmsDataTableRowChanging(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000F77 RID: 3959 RVA: 0x0005CD07 File Offset: 0x0005AF07
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CmsDataTableRowDeleted != null)
				{
					this.CmsDataTableRowDeleted(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000F78 RID: 3960 RVA: 0x0005CD3A File Offset: 0x0005AF3A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CmsDataTableRowDeleting != null)
				{
					this.CmsDataTableRowDeleting(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000F79 RID: 3961 RVA: 0x0005CD6D File Offset: 0x0005AF6D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveCmsDataTableRow(CmsDataSet.CmsDataTableRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000F7A RID: 3962 RVA: 0x0005CD7C File Offset: 0x0005AF7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CmsDataSet cmsDataSet = new CmsDataSet();
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
				xmlSchemaAttribute.FixedValue = cmsDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CmsDataTableDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = cmsDataSet.GetSchemaSerializable();
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

			// Token: 0x0400123E RID: 4670
			private DataColumn columnGroup;

			// Token: 0x0400123F RID: 4671
			private DataColumn columnName;

			// Token: 0x04001240 RID: 4672
			private DataColumn columnId;
		}

		// Token: 0x020000AB RID: 171
		public class CmsDataTableRow : DataRow
		{
			// Token: 0x06000F7B RID: 3963 RVA: 0x0005CF70 File Offset: 0x0005B170
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CmsDataTableRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableCmsDataTable = (CmsDataSet.CmsDataTableDataTable)base.Table;
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0005CF8C File Offset: 0x0005B18C
			// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0005CFD0 File Offset: 0x0005B1D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Group
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCmsDataTable.GroupColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Group' in table 'CmsDataTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCmsDataTable.GroupColumn] = value;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0005CFE4 File Offset: 0x0005B1E4
			// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0005D028 File Offset: 0x0005B228
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCmsDataTable.NameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'CmsDataTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCmsDataTable.NameColumn] = value;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0005D03C File Offset: 0x0005B23C
			// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0005D080 File Offset: 0x0005B280
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					int num;
					try
					{
						num = (int)base[this.tableCmsDataTable.IdColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Id' in table 'CmsDataTable' is DBNull.", ex);
					}
					return num;
				}
				set
				{
					base[this.tableCmsDataTable.IdColumn] = value;
				}
			}

			// Token: 0x06000F82 RID: 3970 RVA: 0x0005D099 File Offset: 0x0005B299
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsGroupNull()
			{
				return base.IsNull(this.tableCmsDataTable.GroupColumn);
			}

			// Token: 0x06000F83 RID: 3971 RVA: 0x0005D0AC File Offset: 0x0005B2AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetGroupNull()
			{
				base[this.tableCmsDataTable.GroupColumn] = Convert.DBNull;
			}

			// Token: 0x06000F84 RID: 3972 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.tableCmsDataTable.NameColumn);
			}

			// Token: 0x06000F85 RID: 3973 RVA: 0x0005D0D7 File Offset: 0x0005B2D7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.tableCmsDataTable.NameColumn] = Convert.DBNull;
			}

			// Token: 0x06000F86 RID: 3974 RVA: 0x0005D0EF File Offset: 0x0005B2EF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdNull()
			{
				return base.IsNull(this.tableCmsDataTable.IdColumn);
			}

			// Token: 0x06000F87 RID: 3975 RVA: 0x0005D102 File Offset: 0x0005B302
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdNull()
			{
				base[this.tableCmsDataTable.IdColumn] = Convert.DBNull;
			}

			// Token: 0x04001245 RID: 4677
			private CmsDataSet.CmsDataTableDataTable tableCmsDataTable;
		}

		// Token: 0x020000AC RID: 172
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class CmsDataTableRowChangeEvent : EventArgs
		{
			// Token: 0x06000F88 RID: 3976 RVA: 0x0005D11A File Offset: 0x0005B31A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataTableRowChangeEvent(CmsDataSet.CmsDataTableRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0005D130 File Offset: 0x0005B330
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0005D138 File Offset: 0x0005B338
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04001246 RID: 4678
			private CmsDataSet.CmsDataTableRow eventRow;

			// Token: 0x04001247 RID: 4679
			private DataRowAction eventAction;
		}
	}
}
