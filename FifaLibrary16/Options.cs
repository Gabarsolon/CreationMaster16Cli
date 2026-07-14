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
	// Token: 0x02000059 RID: 89
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("Options")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class Options : DataSet
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x0002B34C File Offset: 0x0002954C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Options()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002B3A0 File Offset: 0x000295A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Options(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["DataTableOpt"] != null)
				{
					base.Tables.Add(new Options.DataTableOptDataTable(dataSet.Tables["DataTableOpt"]));
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0002B4FD File Offset: 0x000296FD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Options.DataTableOptDataTable DataTableOpt
		{
			get
			{
				return this.tableDataTableOpt;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0002B505 File Offset: 0x00029705
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0002B50D File Offset: 0x0002970D
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00009C8A File Offset: 0x00007E8A
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00009C92 File Offset: 0x00007E92
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

		// Token: 0x060006A2 RID: 1698 RVA: 0x0002B516 File Offset: 0x00029716
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0002B52A File Offset: 0x0002972A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			Options options = (Options)base.Clone();
			options.InitVars();
			options.SchemaSerializationMode = this.SchemaSerializationMode;
			return options;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002B54C File Offset: 0x0002974C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTableOpt"] != null)
				{
					base.Tables.Add(new Options.DataTableOptDataTable(dataSet.Tables["DataTableOpt"]));
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

		// Token: 0x060006A7 RID: 1703 RVA: 0x0002B614 File Offset: 0x00029814
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0002B648 File Offset: 0x00029848
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002B651 File Offset: 0x00029851
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableDataTableOpt = (Options.DataTableOptDataTable)base.Tables["DataTableOpt"];
			if (initTable && this.tableDataTableOpt != null)
			{
				this.tableDataTableOpt.InitVars();
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002B684 File Offset: 0x00029884
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "Options";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/Options.xsd";
			base.Locale = new CultureInfo("");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDataTableOpt = new Options.DataTableOptDataTable();
			base.Tables.Add(this.tableDataTableOpt);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00009CCD File Offset: 0x00007ECD
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTableOpt()
		{
			return false;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0002B6EC File Offset: 0x000298EC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0002B700 File Offset: 0x00029900
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Options options = new Options();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = options.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = options.GetSchemaSerializable();
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

		// Token: 0x04000E90 RID: 3728
		private Options.DataTableOptDataTable tableDataTableOpt;

		// Token: 0x04000E91 RID: 3729
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000FB9 RID: 4025
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTableOptRowChangeEventHandler(object sender, Options.DataTableOptRowChangeEvent e);

		// Token: 0x020000B8 RID: 184
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTableOptDataTable : TypedTableBase<Options.DataTableOptRow>
		{
			// Token: 0x06000FBC RID: 4028 RVA: 0x0005D92A File Offset: 0x0005BB2A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableOptDataTable()
			{
				base.TableName = "DataTableOpt";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000FBD RID: 4029 RVA: 0x0005D950 File Offset: 0x0005BB50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableOptDataTable(DataTable table)
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

			// Token: 0x06000FBE RID: 4030 RVA: 0x0005D9F8 File Offset: 0x0005BBF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTableOptDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0005DA08 File Offset: 0x0005BC08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OptionColumn
			{
				get
				{
					return this.columnOption;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0005DA10 File Offset: 0x0005BC10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x0005DA18 File Offset: 0x0005BC18
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DefaultColumn
			{
				get
				{
					return this.columnDefault;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0005C950 File Offset: 0x0005AB50
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

			// Token: 0x17000352 RID: 850
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Options.DataTableOptRow this[int index]
			{
				get
				{
					return (Options.DataTableOptRow)base.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x06000FC4 RID: 4036 RVA: 0x0005DA34 File Offset: 0x0005BC34
			// (remove) Token: 0x06000FC5 RID: 4037 RVA: 0x0005DA6C File Offset: 0x0005BC6C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x06000FC6 RID: 4038 RVA: 0x0005DAA4 File Offset: 0x0005BCA4
			// (remove) Token: 0x06000FC7 RID: 4039 RVA: 0x0005DADC File Offset: 0x0005BCDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x06000FC8 RID: 4040 RVA: 0x0005DB14 File Offset: 0x0005BD14
			// (remove) Token: 0x06000FC9 RID: 4041 RVA: 0x0005DB4C File Offset: 0x0005BD4C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x06000FCA RID: 4042 RVA: 0x0005DB84 File Offset: 0x0005BD84
			// (remove) Token: 0x06000FCB RID: 4043 RVA: 0x0005DBBC File Offset: 0x0005BDBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowDeleted;

			// Token: 0x06000FCC RID: 4044 RVA: 0x0005CB2D File Offset: 0x0005AD2D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTableOptRow(Options.DataTableOptRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000FCD RID: 4045 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Options.DataTableOptRow AddDataTableOptRow(string Option, string Value, string Default)
			{
				Options.DataTableOptRow dataTableOptRow = (Options.DataTableOptRow)base.NewRow();
				object[] array = new object[] { Option, Value, Default };
				dataTableOptRow.ItemArray = array;
				base.Rows.Add(dataTableOptRow);
				return dataTableOptRow;
			}

			// Token: 0x06000FCE RID: 4046 RVA: 0x0005DC34 File Offset: 0x0005BE34
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				Options.DataTableOptDataTable dataTableOptDataTable = (Options.DataTableOptDataTable)base.Clone();
				dataTableOptDataTable.InitVars();
				return dataTableOptDataTable;
			}

			// Token: 0x06000FCF RID: 4047 RVA: 0x0005DC47 File Offset: 0x0005BE47
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Options.DataTableOptDataTable();
			}

			// Token: 0x06000FD0 RID: 4048 RVA: 0x0005DC50 File Offset: 0x0005BE50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnOption = base.Columns["Option"];
				this.columnValue = base.Columns["Value"];
				this.columnDefault = base.Columns["Default"];
			}

			// Token: 0x06000FD1 RID: 4049 RVA: 0x0005DCA0 File Offset: 0x0005BEA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnOption = new DataColumn("Option", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOption);
				this.columnValue = new DataColumn("Value", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnDefault = new DataColumn("Default", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDefault);
				this.columnOption.AllowDBNull = false;
				this.columnValue.AllowDBNull = false;
				this.columnDefault.AllowDBNull = false;
			}

			// Token: 0x06000FD2 RID: 4050 RVA: 0x0005DD58 File Offset: 0x0005BF58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Options.DataTableOptRow NewDataTableOptRow()
			{
				return (Options.DataTableOptRow)base.NewRow();
			}

			// Token: 0x06000FD3 RID: 4051 RVA: 0x0005DD65 File Offset: 0x0005BF65
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Options.DataTableOptRow(builder);
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x0005DD6D File Offset: 0x0005BF6D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(Options.DataTableOptRow);
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x0005DD79 File Offset: 0x0005BF79
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DataTableOptRowChanged != null)
				{
					this.DataTableOptRowChanged(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FD6 RID: 4054 RVA: 0x0005DDAC File Offset: 0x0005BFAC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DataTableOptRowChanging != null)
				{
					this.DataTableOptRowChanging(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x0005DDDF File Offset: 0x0005BFDF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DataTableOptRowDeleted != null)
				{
					this.DataTableOptRowDeleted(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FD8 RID: 4056 RVA: 0x0005DE12 File Offset: 0x0005C012
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DataTableOptRowDeleting != null)
				{
					this.DataTableOptRowDeleting(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000FD9 RID: 4057 RVA: 0x0005CD6D File Offset: 0x0005AF6D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTableOptRow(Options.DataTableOptRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000FDA RID: 4058 RVA: 0x0005DE48 File Offset: 0x0005C048
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Options options = new Options();
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
				xmlSchemaAttribute.FixedValue = options.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTableOptDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = options.GetSchemaSerializable();
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

			// Token: 0x0400126B RID: 4715
			private DataColumn columnOption;

			// Token: 0x0400126C RID: 4716
			private DataColumn columnValue;

			// Token: 0x0400126D RID: 4717
			private DataColumn columnDefault;
		}

		// Token: 0x020000B9 RID: 185
		public class DataTableOptRow : DataRow
		{
			// Token: 0x06000FDB RID: 4059 RVA: 0x0005E03C File Offset: 0x0005C23C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableOptRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDataTableOpt = (Options.DataTableOptDataTable)base.Table;
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0005E056 File Offset: 0x0005C256
			// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0005E06E File Offset: 0x0005C26E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Option
			{
				get
				{
					return (string)base[this.tableDataTableOpt.OptionColumn];
				}
				set
				{
					base[this.tableDataTableOpt.OptionColumn] = value;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0005E082 File Offset: 0x0005C282
			// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0005E09A File Offset: 0x0005C29A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value
			{
				get
				{
					return (string)base[this.tableDataTableOpt.ValueColumn];
				}
				set
				{
					base[this.tableDataTableOpt.ValueColumn] = value;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0005E0AE File Offset: 0x0005C2AE
			// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0005E0C6 File Offset: 0x0005C2C6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Default
			{
				get
				{
					return (string)base[this.tableDataTableOpt.DefaultColumn];
				}
				set
				{
					base[this.tableDataTableOpt.DefaultColumn] = value;
				}
			}

			// Token: 0x04001272 RID: 4722
			private Options.DataTableOptDataTable tableDataTableOpt;
		}

		// Token: 0x020000BA RID: 186
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTableOptRowChangeEvent : EventArgs
		{
			// Token: 0x06000FE2 RID: 4066 RVA: 0x0005E0DA File Offset: 0x0005C2DA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableOptRowChangeEvent(Options.DataTableOptRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0005E0F0 File Offset: 0x0005C2F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Options.DataTableOptRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0005E0F8 File Offset: 0x0005C2F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04001273 RID: 4723
			private Options.DataTableOptRow eventRow;

			// Token: 0x04001274 RID: 4724
			private DataRowAction eventAction;
		}
	}
}
