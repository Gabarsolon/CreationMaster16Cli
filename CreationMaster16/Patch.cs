using System;
using System.CodeDom.Compiler;
using System.Collections;
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

namespace CreationMaster
{
	// Token: 0x0200000C RID: 12
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("Patch")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class Patch : DataSet
	{
		// Token: 0x06000129 RID: 297 RVA: 0x0001B060 File Offset: 0x00019260
		[DebuggerNonUserCode]
		public Patch()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0001B0B4 File Offset: 0x000192B4
		[DebuggerNonUserCode]
		protected Patch(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["PatchIdentity"] != null)
				{
					base.Tables.Add(new Patch.PatchIdentityDataTable(dataSet.Tables["PatchIdentity"]));
				}
				if (dataSet.Tables["PatchElements"] != null)
				{
					base.Tables.Add(new Patch.PatchElementsDataTable(dataSet.Tables["PatchElements"]));
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0001B243 File Offset: 0x00019443
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Patch.PatchIdentityDataTable PatchIdentity
		{
			get
			{
				return this.tablePatchIdentity;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0001B24B File Offset: 0x0001944B
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Patch.PatchElementsDataTable PatchElements
		{
			get
			{
				return this.tablePatchElements;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0001B253 File Offset: 0x00019453
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0001B25B File Offset: 0x0001945B
		[DebuggerNonUserCode]
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

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0001B264 File Offset: 0x00019464
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0001B26C File Offset: 0x0001946C
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001B274 File Offset: 0x00019474
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0001B288 File Offset: 0x00019488
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			Patch patch = (Patch)base.Clone();
			patch.InitVars();
			patch.SchemaSerializationMode = this.SchemaSerializationMode;
			return patch;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0001B2A7 File Offset: 0x000194A7
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001B2A7 File Offset: 0x000194A7
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001B2AC File Offset: 0x000194AC
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["PatchIdentity"] != null)
				{
					base.Tables.Add(new Patch.PatchIdentityDataTable(dataSet.Tables["PatchIdentity"]));
				}
				if (dataSet.Tables["PatchElements"] != null)
				{
					base.Tables.Add(new Patch.PatchElementsDataTable(dataSet.Tables["PatchElements"]));
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

		// Token: 0x06000136 RID: 310 RVA: 0x0001B3A4 File Offset: 0x000195A4
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001B3E4 File Offset: 0x000195E4
		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tablePatchIdentity = (Patch.PatchIdentityDataTable)base.Tables["PatchIdentity"];
			if (initTable && this.tablePatchIdentity != null)
			{
				this.tablePatchIdentity.InitVars();
			}
			this.tablePatchElements = (Patch.PatchElementsDataTable)base.Tables["PatchElements"];
			if (initTable && this.tablePatchElements != null)
			{
				this.tablePatchElements.InitVars();
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001B454 File Offset: 0x00019654
		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "Patch";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/Patch.xsd";
			base.Locale = new CultureInfo("");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tablePatchIdentity = new Patch.PatchIdentityDataTable();
			base.Tables.Add(this.tablePatchIdentity);
			this.tablePatchElements = new Patch.PatchElementsDataTable();
			base.Tables.Add(this.tablePatchElements);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001B2A7 File Offset: 0x000194A7
		[DebuggerNonUserCode]
		private bool ShouldSerializePatchIdentity()
		{
			return false;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001B2A7 File Offset: 0x000194A7
		[DebuggerNonUserCode]
		private bool ShouldSerializePatchElements()
		{
			return false;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001B4D8 File Offset: 0x000196D8
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001B4EC File Offset: 0x000196EC
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Patch patch = new Patch();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = patch.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = patch.GetSchemaSerializable();
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

		// Token: 0x040001B9 RID: 441
		private Patch.PatchIdentityDataTable tablePatchIdentity;

		// Token: 0x040001BA RID: 442
		private Patch.PatchElementsDataTable tablePatchElements;

		// Token: 0x040001BB RID: 443
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060005F7 RID: 1527
		public delegate void PatchIdentityRowChangeEventHandler(object sender, Patch.PatchIdentityRowChangeEvent e);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060005FB RID: 1531
		public delegate void PatchElementsRowChangeEventHandler(object sender, Patch.PatchElementsRowChangeEvent e);

		// Token: 0x02000027 RID: 39
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class PatchIdentityDataTable : DataTable, IEnumerable
		{
			// Token: 0x060005FE RID: 1534 RVA: 0x000A400C File Offset: 0x000A220C
			[DebuggerNonUserCode]
			public PatchIdentityDataTable()
			{
				base.TableName = "PatchIdentity";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x000A4034 File Offset: 0x000A2234
			[DebuggerNonUserCode]
			internal PatchIdentityDataTable(DataTable table)
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

			// Token: 0x06000600 RID: 1536 RVA: 0x000A40DC File Offset: 0x000A22DC
			[DebuggerNonUserCode]
			protected PatchIdentityDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000601 RID: 1537 RVA: 0x000A40EC File Offset: 0x000A22EC
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000602 RID: 1538 RVA: 0x000A40F4 File Offset: 0x000A22F4
			[DebuggerNonUserCode]
			public DataColumn VersionColumn
			{
				get
				{
					return this.columnVersion;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000603 RID: 1539 RVA: 0x000A40FC File Offset: 0x000A22FC
			[DebuggerNonUserCode]
			public DataColumn DescriptionColumn
			{
				get
				{
					return this.columnDescription;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000604 RID: 1540 RVA: 0x000A4104 File Offset: 0x000A2304
			[DebuggerNonUserCode]
			public DataColumn ChecksumColumn
			{
				get
				{
					return this.columnChecksum;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000605 RID: 1541 RVA: 0x000A410C File Offset: 0x000A230C
			[DebuggerNonUserCode]
			public DataColumn CMSColumn
			{
				get
				{
					return this.columnCMS;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000606 RID: 1542 RVA: 0x000A4114 File Offset: 0x000A2314
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700002D RID: 45
			[DebuggerNonUserCode]
			public Patch.PatchIdentityRow this[int index]
			{
				get
				{
					return (Patch.PatchIdentityRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x06000608 RID: 1544 RVA: 0x000A4134 File Offset: 0x000A2334
			// (remove) Token: 0x06000609 RID: 1545 RVA: 0x000A416C File Offset: 0x000A236C
			public event Patch.PatchIdentityRowChangeEventHandler PatchIdentityRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x0600060A RID: 1546 RVA: 0x000A41A4 File Offset: 0x000A23A4
			// (remove) Token: 0x0600060B RID: 1547 RVA: 0x000A41DC File Offset: 0x000A23DC
			public event Patch.PatchIdentityRowChangeEventHandler PatchIdentityRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x0600060C RID: 1548 RVA: 0x000A4214 File Offset: 0x000A2414
			// (remove) Token: 0x0600060D RID: 1549 RVA: 0x000A424C File Offset: 0x000A244C
			public event Patch.PatchIdentityRowChangeEventHandler PatchIdentityRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x0600060E RID: 1550 RVA: 0x000A4284 File Offset: 0x000A2484
			// (remove) Token: 0x0600060F RID: 1551 RVA: 0x000A42BC File Offset: 0x000A24BC
			public event Patch.PatchIdentityRowChangeEventHandler PatchIdentityRowDeleted;

			// Token: 0x06000610 RID: 1552 RVA: 0x000A42F1 File Offset: 0x000A24F1
			[DebuggerNonUserCode]
			public void AddPatchIdentityRow(Patch.PatchIdentityRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x000A4300 File Offset: 0x000A2500
			[DebuggerNonUserCode]
			public Patch.PatchIdentityRow AddPatchIdentityRow(string Name, string Version, string Description, int Checksum, string CMS)
			{
				Patch.PatchIdentityRow patchIdentityRow = (Patch.PatchIdentityRow)base.NewRow();
				object[] array = new object[] { Name, Version, Description, Checksum, CMS };
				patchIdentityRow.ItemArray = array;
				base.Rows.Add(patchIdentityRow);
				return patchIdentityRow;
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x000A434F File Offset: 0x000A254F
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x000A435C File Offset: 0x000A255C
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Patch.PatchIdentityDataTable patchIdentityDataTable = (Patch.PatchIdentityDataTable)base.Clone();
				patchIdentityDataTable.InitVars();
				return patchIdentityDataTable;
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x000A436F File Offset: 0x000A256F
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Patch.PatchIdentityDataTable();
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x000A4378 File Offset: 0x000A2578
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnName = base.Columns["Name"];
				this.columnVersion = base.Columns["Version"];
				this.columnDescription = base.Columns["Description"];
				this.columnChecksum = base.Columns["Checksum"];
				this.columnCMS = base.Columns["CMS"];
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x000A43F4 File Offset: 0x000A25F4
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnVersion = new DataColumn("Version", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnVersion);
				this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescription);
				this.columnCMS = new DataColumn("CMS", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCMS);
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x000A44B5 File Offset: 0x000A26B5
			[DebuggerNonUserCode]
			public Patch.PatchIdentityRow NewPatchIdentityRow()
			{
				return (Patch.PatchIdentityRow)base.NewRow();
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x000A44C2 File Offset: 0x000A26C2
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Patch.PatchIdentityRow(builder);
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x000A44CA File Offset: 0x000A26CA
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Patch.PatchIdentityRow);
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x000A44D6 File Offset: 0x000A26D6
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.PatchIdentityRowChanged != null)
				{
					this.PatchIdentityRowChanged(this, new Patch.PatchIdentityRowChangeEvent((Patch.PatchIdentityRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x000A4509 File Offset: 0x000A2709
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.PatchIdentityRowChanging != null)
				{
					this.PatchIdentityRowChanging(this, new Patch.PatchIdentityRowChangeEvent((Patch.PatchIdentityRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x000A453C File Offset: 0x000A273C
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.PatchIdentityRowDeleted != null)
				{
					this.PatchIdentityRowDeleted(this, new Patch.PatchIdentityRowChangeEvent((Patch.PatchIdentityRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x000A456F File Offset: 0x000A276F
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.PatchIdentityRowDeleting != null)
				{
					this.PatchIdentityRowDeleting(this, new Patch.PatchIdentityRowChangeEvent((Patch.PatchIdentityRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x000A45A2 File Offset: 0x000A27A2
			[DebuggerNonUserCode]
			public void RemovePatchIdentityRow(Patch.PatchIdentityRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x000A45B0 File Offset: 0x000A27B0
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Patch patch = new Patch();
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
				xmlSchemaAttribute.FixedValue = patch.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "PatchIdentityDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = patch.GetSchemaSerializable();
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

			// Token: 0x04000A4B RID: 2635
			private DataColumn columnName;

			// Token: 0x04000A4C RID: 2636
			private DataColumn columnVersion;

			// Token: 0x04000A4D RID: 2637
			private DataColumn columnDescription;

			// Token: 0x04000A4E RID: 2638
			private DataColumn columnChecksum;

			// Token: 0x04000A4F RID: 2639
			private DataColumn columnCMS;
		}

		// Token: 0x02000028 RID: 40
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class PatchElementsDataTable : DataTable, IEnumerable
		{
			// Token: 0x06000620 RID: 1568 RVA: 0x000A47A4 File Offset: 0x000A29A4
			[DebuggerNonUserCode]
			public PatchElementsDataTable()
			{
				base.TableName = "PatchElements";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x000A47CC File Offset: 0x000A29CC
			[DebuggerNonUserCode]
			internal PatchElementsDataTable(DataTable table)
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

			// Token: 0x06000622 RID: 1570 RVA: 0x000A4874 File Offset: 0x000A2A74
			[DebuggerNonUserCode]
			protected PatchElementsDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000623 RID: 1571 RVA: 0x000A4884 File Offset: 0x000A2A84
			[DebuggerNonUserCode]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000624 RID: 1572 RVA: 0x000A488C File Offset: 0x000A2A8C
			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000625 RID: 1573 RVA: 0x000A4894 File Offset: 0x000A2A94
			[DebuggerNonUserCode]
			public DataColumn IDColumn
			{
				get
				{
					return this.columnID;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000626 RID: 1574 RVA: 0x000A489C File Offset: 0x000A2A9C
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x000A48A4 File Offset: 0x000A2AA4
			[DebuggerNonUserCode]
			public DataColumn ChecksumColumn
			{
				get
				{
					return this.columnChecksum;
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000628 RID: 1576 RVA: 0x000A4114 File Offset: 0x000A2314
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000034 RID: 52
			[DebuggerNonUserCode]
			public Patch.PatchElementsRow this[int index]
			{
				get
				{
					return (Patch.PatchElementsRow)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x0600062A RID: 1578 RVA: 0x000A48C0 File Offset: 0x000A2AC0
			// (remove) Token: 0x0600062B RID: 1579 RVA: 0x000A48F8 File Offset: 0x000A2AF8
			public event Patch.PatchElementsRowChangeEventHandler PatchElementsRowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x0600062C RID: 1580 RVA: 0x000A4930 File Offset: 0x000A2B30
			// (remove) Token: 0x0600062D RID: 1581 RVA: 0x000A4968 File Offset: 0x000A2B68
			public event Patch.PatchElementsRowChangeEventHandler PatchElementsRowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x0600062E RID: 1582 RVA: 0x000A49A0 File Offset: 0x000A2BA0
			// (remove) Token: 0x0600062F RID: 1583 RVA: 0x000A49D8 File Offset: 0x000A2BD8
			public event Patch.PatchElementsRowChangeEventHandler PatchElementsRowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x06000630 RID: 1584 RVA: 0x000A4A10 File Offset: 0x000A2C10
			// (remove) Token: 0x06000631 RID: 1585 RVA: 0x000A4A48 File Offset: 0x000A2C48
			public event Patch.PatchElementsRowChangeEventHandler PatchElementsRowDeleted;

			// Token: 0x06000632 RID: 1586 RVA: 0x000A42F1 File Offset: 0x000A24F1
			[DebuggerNonUserCode]
			public void AddPatchElementsRow(Patch.PatchElementsRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x000A4A80 File Offset: 0x000A2C80
			[DebuggerNonUserCode]
			public Patch.PatchElementsRow AddPatchElementsRow(string Comment, string Type, string ID, string Name, int Checksum)
			{
				Patch.PatchElementsRow patchElementsRow = (Patch.PatchElementsRow)base.NewRow();
				object[] array = new object[] { Comment, Type, ID, Name, Checksum };
				patchElementsRow.ItemArray = array;
				base.Rows.Add(patchElementsRow);
				return patchElementsRow;
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x000A434F File Offset: 0x000A254F
			[DebuggerNonUserCode]
			public virtual IEnumerator GetEnumerator()
			{
				return base.Rows.GetEnumerator();
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x000A4ACF File Offset: 0x000A2CCF
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Patch.PatchElementsDataTable patchElementsDataTable = (Patch.PatchElementsDataTable)base.Clone();
				patchElementsDataTable.InitVars();
				return patchElementsDataTable;
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x000A4AE2 File Offset: 0x000A2CE2
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new Patch.PatchElementsDataTable();
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x000A4AEC File Offset: 0x000A2CEC
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnComment = base.Columns["Comment"];
				this.columnType = base.Columns["Type"];
				this.columnID = base.Columns["ID"];
				this.columnName = base.Columns["Name"];
				this.columnChecksum = base.Columns["Checksum"];
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x000A4B68 File Offset: 0x000A2D68
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnType = new DataColumn("Type", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnID = new DataColumn("ID", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnID);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnChecksum = new DataColumn("Checksum", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnChecksum);
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x000A4C56 File Offset: 0x000A2E56
			[DebuggerNonUserCode]
			public Patch.PatchElementsRow NewPatchElementsRow()
			{
				return (Patch.PatchElementsRow)base.NewRow();
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x000A4C63 File Offset: 0x000A2E63
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Patch.PatchElementsRow(builder);
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x000A4C6B File Offset: 0x000A2E6B
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Patch.PatchElementsRow);
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x000A4C77 File Offset: 0x000A2E77
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.PatchElementsRowChanged != null)
				{
					this.PatchElementsRowChanged(this, new Patch.PatchElementsRowChangeEvent((Patch.PatchElementsRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x000A4CAA File Offset: 0x000A2EAA
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.PatchElementsRowChanging != null)
				{
					this.PatchElementsRowChanging(this, new Patch.PatchElementsRowChangeEvent((Patch.PatchElementsRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x000A4CDD File Offset: 0x000A2EDD
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.PatchElementsRowDeleted != null)
				{
					this.PatchElementsRowDeleted(this, new Patch.PatchElementsRowChangeEvent((Patch.PatchElementsRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x000A4D10 File Offset: 0x000A2F10
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.PatchElementsRowDeleting != null)
				{
					this.PatchElementsRowDeleting(this, new Patch.PatchElementsRowChangeEvent((Patch.PatchElementsRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x000A45A2 File Offset: 0x000A27A2
			[DebuggerNonUserCode]
			public void RemovePatchElementsRow(Patch.PatchElementsRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x000A4D44 File Offset: 0x000A2F44
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Patch patch = new Patch();
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
				xmlSchemaAttribute.FixedValue = patch.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "PatchElementsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = patch.GetSchemaSerializable();
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

			// Token: 0x04000A54 RID: 2644
			private DataColumn columnComment;

			// Token: 0x04000A55 RID: 2645
			private DataColumn columnType;

			// Token: 0x04000A56 RID: 2646
			private DataColumn columnID;

			// Token: 0x04000A57 RID: 2647
			private DataColumn columnName;

			// Token: 0x04000A58 RID: 2648
			private DataColumn columnChecksum;
		}

		// Token: 0x02000029 RID: 41
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class PatchIdentityRow : DataRow
		{
			// Token: 0x06000642 RID: 1602 RVA: 0x000A4F38 File Offset: 0x000A3138
			[DebuggerNonUserCode]
			internal PatchIdentityRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tablePatchIdentity = (Patch.PatchIdentityDataTable)base.Table;
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000643 RID: 1603 RVA: 0x000A4F54 File Offset: 0x000A3154
			// (set) Token: 0x06000644 RID: 1604 RVA: 0x000A4F98 File Offset: 0x000A3198
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchIdentity.NameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'PatchIdentity' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchIdentity.NameColumn] = value;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000645 RID: 1605 RVA: 0x000A4FAC File Offset: 0x000A31AC
			// (set) Token: 0x06000646 RID: 1606 RVA: 0x000A4FF0 File Offset: 0x000A31F0
			[DebuggerNonUserCode]
			public string Version
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchIdentity.VersionColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Version' in table 'PatchIdentity' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchIdentity.VersionColumn] = value;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x000A5004 File Offset: 0x000A3204
			// (set) Token: 0x06000648 RID: 1608 RVA: 0x000A5048 File Offset: 0x000A3248
			[DebuggerNonUserCode]
			public string Description
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchIdentity.DescriptionColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Description' in table 'PatchIdentity' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchIdentity.DescriptionColumn] = value;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x000A505C File Offset: 0x000A325C
			// (set) Token: 0x0600064A RID: 1610 RVA: 0x000A50A0 File Offset: 0x000A32A0
			[DebuggerNonUserCode]
			public int Checksum
			{
				get
				{
					int num;
					try
					{
						num = (int)base[this.tablePatchIdentity.ChecksumColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Checksum' in table 'PatchIdentity' is DBNull.", ex);
					}
					return num;
				}
				set
				{
					base[this.tablePatchIdentity.ChecksumColumn] = value;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x000A50B9 File Offset: 0x000A32B9
			// (set) Token: 0x0600064C RID: 1612 RVA: 0x000A50DF File Offset: 0x000A32DF
			[DebuggerNonUserCode]
			public string CMS
			{
				get
				{
					if (this.IsCMSNull())
					{
						return string.Empty;
					}
					return (string)base[this.tablePatchIdentity.CMSColumn];
				}
				set
				{
					base[this.tablePatchIdentity.CMSColumn] = value;
				}
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x000A50F3 File Offset: 0x000A32F3
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.tablePatchIdentity.NameColumn);
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x000A5106 File Offset: 0x000A3306
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.tablePatchIdentity.NameColumn] = Convert.DBNull;
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x000A511E File Offset: 0x000A331E
			[DebuggerNonUserCode]
			public bool IsVersionNull()
			{
				return base.IsNull(this.tablePatchIdentity.VersionColumn);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x000A5131 File Offset: 0x000A3331
			[DebuggerNonUserCode]
			public void SetVersionNull()
			{
				base[this.tablePatchIdentity.VersionColumn] = Convert.DBNull;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x000A5149 File Offset: 0x000A3349
			[DebuggerNonUserCode]
			public bool IsDescriptionNull()
			{
				return base.IsNull(this.tablePatchIdentity.DescriptionColumn);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x000A515C File Offset: 0x000A335C
			[DebuggerNonUserCode]
			public void SetDescriptionNull()
			{
				base[this.tablePatchIdentity.DescriptionColumn] = Convert.DBNull;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x000A5174 File Offset: 0x000A3374
			[DebuggerNonUserCode]
			public bool IsChecksumNull()
			{
				return base.IsNull(this.tablePatchIdentity.ChecksumColumn);
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x000A5187 File Offset: 0x000A3387
			[DebuggerNonUserCode]
			public void SetChecksumNull()
			{
				base[this.tablePatchIdentity.ChecksumColumn] = Convert.DBNull;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x000A519F File Offset: 0x000A339F
			[DebuggerNonUserCode]
			public bool IsCMSNull()
			{
				return base.IsNull(this.tablePatchIdentity.CMSColumn);
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x000A51B2 File Offset: 0x000A33B2
			[DebuggerNonUserCode]
			public void SetCMSNull()
			{
				base[this.tablePatchIdentity.CMSColumn] = Convert.DBNull;
			}

			// Token: 0x04000A5D RID: 2653
			private Patch.PatchIdentityDataTable tablePatchIdentity;
		}

		// Token: 0x0200002A RID: 42
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class PatchElementsRow : DataRow
		{
			// Token: 0x06000657 RID: 1623 RVA: 0x000A51CA File Offset: 0x000A33CA
			[DebuggerNonUserCode]
			internal PatchElementsRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tablePatchElements = (Patch.PatchElementsDataTable)base.Table;
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000658 RID: 1624 RVA: 0x000A51E4 File Offset: 0x000A33E4
			// (set) Token: 0x06000659 RID: 1625 RVA: 0x000A5228 File Offset: 0x000A3428
			[DebuggerNonUserCode]
			public string Comment
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchElements.CommentColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Comment' in table 'PatchElements' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchElements.CommentColumn] = value;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x0600065A RID: 1626 RVA: 0x000A523C File Offset: 0x000A343C
			// (set) Token: 0x0600065B RID: 1627 RVA: 0x000A5280 File Offset: 0x000A3480
			[DebuggerNonUserCode]
			public string Type
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchElements.TypeColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Type' in table 'PatchElements' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchElements.TypeColumn] = value;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600065C RID: 1628 RVA: 0x000A5294 File Offset: 0x000A3494
			// (set) Token: 0x0600065D RID: 1629 RVA: 0x000A52BA File Offset: 0x000A34BA
			[DebuggerNonUserCode]
			public string ID
			{
				get
				{
					if (this.IsIDNull())
					{
						return string.Empty;
					}
					return (string)base[this.tablePatchElements.IDColumn];
				}
				set
				{
					base[this.tablePatchElements.IDColumn] = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600065E RID: 1630 RVA: 0x000A52D0 File Offset: 0x000A34D0
			// (set) Token: 0x0600065F RID: 1631 RVA: 0x000A5314 File Offset: 0x000A3514
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tablePatchElements.NameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'PatchElements' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tablePatchElements.NameColumn] = value;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000660 RID: 1632 RVA: 0x000A5328 File Offset: 0x000A3528
			// (set) Token: 0x06000661 RID: 1633 RVA: 0x000A536C File Offset: 0x000A356C
			[DebuggerNonUserCode]
			public int Checksum
			{
				get
				{
					int num;
					try
					{
						num = (int)base[this.tablePatchElements.ChecksumColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Checksum' in table 'PatchElements' is DBNull.", ex);
					}
					return num;
				}
				set
				{
					base[this.tablePatchElements.ChecksumColumn] = value;
				}
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x000A5385 File Offset: 0x000A3585
			[DebuggerNonUserCode]
			public bool IsCommentNull()
			{
				return base.IsNull(this.tablePatchElements.CommentColumn);
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x000A5398 File Offset: 0x000A3598
			[DebuggerNonUserCode]
			public void SetCommentNull()
			{
				base[this.tablePatchElements.CommentColumn] = Convert.DBNull;
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x000A53B0 File Offset: 0x000A35B0
			[DebuggerNonUserCode]
			public bool IsTypeNull()
			{
				return base.IsNull(this.tablePatchElements.TypeColumn);
			}

			// Token: 0x06000665 RID: 1637 RVA: 0x000A53C3 File Offset: 0x000A35C3
			[DebuggerNonUserCode]
			public void SetTypeNull()
			{
				base[this.tablePatchElements.TypeColumn] = Convert.DBNull;
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x000A53DB File Offset: 0x000A35DB
			[DebuggerNonUserCode]
			public bool IsIDNull()
			{
				return base.IsNull(this.tablePatchElements.IDColumn);
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x000A53EE File Offset: 0x000A35EE
			[DebuggerNonUserCode]
			public void SetIDNull()
			{
				base[this.tablePatchElements.IDColumn] = Convert.DBNull;
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x000A5406 File Offset: 0x000A3606
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.tablePatchElements.NameColumn);
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000A5419 File Offset: 0x000A3619
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.tablePatchElements.NameColumn] = Convert.DBNull;
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x000A5431 File Offset: 0x000A3631
			[DebuggerNonUserCode]
			public bool IsChecksumNull()
			{
				return base.IsNull(this.tablePatchElements.ChecksumColumn);
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x000A5444 File Offset: 0x000A3644
			[DebuggerNonUserCode]
			public void SetChecksumNull()
			{
				base[this.tablePatchElements.ChecksumColumn] = Convert.DBNull;
			}

			// Token: 0x04000A5E RID: 2654
			private Patch.PatchElementsDataTable tablePatchElements;
		}

		// Token: 0x0200002B RID: 43
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class PatchIdentityRowChangeEvent : EventArgs
		{
			// Token: 0x0600066C RID: 1644 RVA: 0x000A545C File Offset: 0x000A365C
			[DebuggerNonUserCode]
			public PatchIdentityRowChangeEvent(Patch.PatchIdentityRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600066D RID: 1645 RVA: 0x000A5472 File Offset: 0x000A3672
			[DebuggerNonUserCode]
			public Patch.PatchIdentityRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x000A547A File Offset: 0x000A367A
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000A5F RID: 2655
			private Patch.PatchIdentityRow eventRow;

			// Token: 0x04000A60 RID: 2656
			private DataRowAction eventAction;
		}

		// Token: 0x0200002C RID: 44
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")]
		public class PatchElementsRowChangeEvent : EventArgs
		{
			// Token: 0x0600066F RID: 1647 RVA: 0x000A5482 File Offset: 0x000A3682
			[DebuggerNonUserCode]
			public PatchElementsRowChangeEvent(Patch.PatchElementsRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000670 RID: 1648 RVA: 0x000A5498 File Offset: 0x000A3698
			[DebuggerNonUserCode]
			public Patch.PatchElementsRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000671 RID: 1649 RVA: 0x000A54A0 File Offset: 0x000A36A0
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000A61 RID: 2657
			private Patch.PatchElementsRow eventRow;

			// Token: 0x04000A62 RID: 2658
			private DataRowAction eventAction;
		}
	}
}
