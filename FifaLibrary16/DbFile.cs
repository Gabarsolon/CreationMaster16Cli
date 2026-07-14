using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000029 RID: 41
	public class DbFile
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000A6ED File Offset: 0x000088ED
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000A6F5 File Offset: 0x000088F5
		public Table[] Table
		{
			get
			{
				return this.m_Table;
			}
			set
			{
				this.m_Table = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000A6FE File Offset: 0x000088FE
		public int NTables
		{
			get
			{
				return this.m_NTables;
			}
		}

		// Token: 0x1700005C RID: 92
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000A706 File Offset: 0x00008906
		public ToolStripProgressBar ProgressBar
		{
			set
			{
				this.m_ProgressBar = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000A70F File Offset: 0x0000890F
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000A717 File Offset: 0x00008917
		public string XmlFileName
		{
			get
			{
				return this.m_XmlFileName;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000A71F File Offset: 0x0000891F
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000A727 File Offset: 0x00008927
		public DataSet DescriptorDataSet
		{
			get
			{
				return this.m_DescriptorDataSet;
			}
			set
			{
				this.m_DescriptorDataSet = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000A730 File Offset: 0x00008930
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000A738 File Offset: 0x00008938
		public FifaPlatform Platform
		{
			get
			{
				return this.m_Platform;
			}
			set
			{
				this.m_Platform = value;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A741 File Offset: 0x00008941
		public DbFile()
		{
			this.m_FileName = null;
			this.m_XmlFileName = null;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000A765 File Offset: 0x00008965
		public DbFile(string dbFileName, string xmlFileName, ToolStripProgressBar toolStripProgressBar)
		{
			this.m_ProgressBar = toolStripProgressBar;
			this.m_FileName = dbFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
			this.Load();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A797 File Offset: 0x00008997
		public DbFile(string dbFileName, string xmlFileName)
		{
			this.m_ProgressBar = null;
			this.m_FileName = dbFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
			this.Load();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000A7CC File Offset: 0x000089CC
		public void ComputeAllCrc(DbReader r, DbWriter w)
		{
			long num = this.m_SignaturePosition;
			int num2 = (int)(this.m_CrcHeaderPosition - num);
			this.ComputeAndWriteCrc(r, w, num, num2);
			num += (long)(num2 + 4);
			num2 = (int)(this.m_CrcShortNamesPosition - num);
			this.ComputeAndWriteCrc(r, w, num, num2);
			for (int i = 0; i < this.m_NTables; i++)
			{
				num += (long)(num2 + 4);
				num2 = (int)(this.m_Table[i].CrcTableHeaderPosition - num);
				this.ComputeAndWriteCrc(r, w, num, num2);
				num += (long)(num2 + 4);
				num2 = (int)(this.m_Table[i].CrcRecordsPosition - num);
				this.ComputeAndWriteCrc(r, w, num, num2);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000A868 File Offset: 0x00008A68
		public bool ComputeAllCrc()
		{
			if (!File.Exists(this.m_FileName))
			{
				return false;
			}
			FileStream fileStream = new FileStream(this.m_FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			DbWriter dbWriter = new DbWriter(fileStream, this.m_Platform);
			DbReader dbReader = new DbReader(fileStream, this.m_Platform);
			this.ComputeAllCrc(dbReader, dbWriter);
			dbReader.Close();
			dbWriter.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		public int ComputeAndWriteCrc(DbReader r, DbWriter w, long offset, int count)
		{
			r.BaseStream.Seek(offset, SeekOrigin.Begin);
			int num = FifaUtil.ComputeCrcDb11(r.ReadBytes(count));
			w.Write(num);
			return num;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000A904 File Offset: 0x00008B04
		public bool LoadDb(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			this.m_FileName = fileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			DbReader dbReader = new DbReader(fileStream, FifaPlatform.PC);
			bool flag = this.LoadDb(dbReader, false);
			dbReader.Close();
			fileStream.Close();
			return flag;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000A948 File Offset: 0x00008B48
		public bool LoadDb(DbReader r, bool skipData)
		{
			bool flag = false;
			if (skipData)
			{
				while (r.BaseStream.Position <= r.BaseStream.Length - 4L)
				{
					if (r.ReadUInt32() == 134234692U)
					{
						flag = true;
						r.BaseStream.Position -= 4L;
						break;
					}
					r.BaseStream.Position -= 3L;
				}
				if (!flag)
				{
					return false;
				}
			}
			flag = true;
			this.m_SignaturePosition = r.BaseStream.Position;
			this.m_Signature = r.ReadChars(8);
			if (this.m_Signature[0] != 'D' || this.m_Signature[1] != 'B' || this.m_Signature[2] != '\0' || this.m_Signature[3] != '\b' || this.m_Signature[5] != '\0' || this.m_Signature[6] != '\0' || this.m_Signature[7] != '\0')
			{
				return false;
			}
			if (this.m_Signature[4] == '\0')
			{
				this.m_Platform = FifaPlatform.PC;
				r.Platform = this.m_Platform;
			}
			else
			{
				if (this.m_Signature[4] != '\u0001')
				{
					return false;
				}
				this.m_Platform = FifaPlatform.XBox;
				r.Platform = this.m_Platform;
			}
			this.m_FileLength = r.ReadInt32();
			if ((long)this.m_FileLength > r.BaseStream.Length)
			{
				return false;
			}
			r.ReadInt32();
			this.m_NTables = r.ReadInt32();
			this.m_TableOffset = new uint[this.m_NTables];
			TableDescriptor.DescriptorDataSet = this.m_DescriptorDataSet;
			this.m_Table = new Table[this.m_NTables];
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			this.m_CrcHeaderPosition = r.BaseStream.Position;
			this.m_CrcHeader = r.ReadUInt32();
			for (int i = 0; i < this.m_NTables; i++)
			{
				this.m_Table[i] = new Table();
				this.m_Table[i].LoadTableName(r);
				this.m_TableOffset[i] = r.ReadUInt32();
			}
			this.m_CrcShortNamesPosition = r.BaseStream.Position;
			this.m_CrcShortNames = r.ReadUInt32();
			long position = r.BaseStream.Position;
			for (int j = 0; j < this.m_NTables; j++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = j;
				}
				this.m_Table[j].Load(r, position + (long)((ulong)this.m_TableOffset[j]));
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return flag;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000ABB2 File Offset: 0x00008DB2
		public bool LoadDb()
		{
			return this.m_FileName != null && this.LoadDb(this.m_FileName);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000ABCA File Offset: 0x00008DCA
		public bool LoadXml(string xmlFileName)
		{
			if (!File.Exists(xmlFileName))
			{
				return false;
			}
			this.m_XmlFileName = xmlFileName;
			this.m_NeedToSaveXmlFile = false;
			this.m_DescriptorDataSet = new DataSet("XML_Descriptor");
			this.m_DescriptorDataSet.ReadXml(this.m_XmlFileName);
			return true;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000AC07 File Offset: 0x00008E07
		public bool LoadXml()
		{
			return this.m_XmlFileName != null && this.LoadXml(this.m_XmlFileName);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000AC1F File Offset: 0x00008E1F
		public bool Load()
		{
			return this.LoadXml() && this.LoadDb();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000AC34 File Offset: 0x00008E34
		public bool SaveDb(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
			DbWriter dbWriter = new DbWriter(fileStream, this.m_Platform);
			this.SaveDb(dbWriter);
			dbWriter.Close();
			fileStream.Close();
			this.ComputeAllCrc();
			return true;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000AC74 File Offset: 0x00008E74
		public bool SaveDb(DbWriter w)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			w.Write(this.m_Signature);
			long position = w.BaseStream.Position;
			w.Write(-1L);
			w.Write(this.m_NTables);
			this.m_CrcHeaderPosition = w.BaseStream.Position;
			w.Write(-1);
			long num = w.BaseStream.Position + 4L;
			for (int i = 0; i < this.m_NTables; i++)
			{
				w.Write(this.m_Table[i].TableDescriptor.ShortName);
				w.Write(-1);
			}
			this.m_CrcShortNamesPosition = w.BaseStream.Position;
			w.Write(-1);
			long position2 = w.BaseStream.Position;
			for (int j = 0; j < this.m_NTables; j++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = j;
				}
				this.m_TableOffset[j] = (uint)(w.BaseStream.Position - position2);
				this.m_Table[j].Save(w);
			}
			this.m_FileLength = (int)(w.BaseStream.Position - this.m_SignaturePosition);
			w.BaseStream.Position = position;
			w.Write(this.m_FileLength);
			w.Write(0);
			w.BaseStream.Position = num;
			for (int k = 0; k < this.m_NTables; k++)
			{
				w.Write(this.m_TableOffset[k]);
				w.BaseStream.Position += 4L;
			}
			w.Seek(0, SeekOrigin.End);
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return true;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000AE2B File Offset: 0x0000902B
		public bool SaveXml(string xmlFileName)
		{
			if (this.m_NeedToSaveXmlFile)
			{
				File.Copy(xmlFileName, xmlFileName + ".bak", true);
				this.m_DescriptorDataSet.WriteXml(xmlFileName, XmlWriteMode.IgnoreSchema);
			}
			this.m_NeedToSaveXmlFile = false;
			return true;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000AE5C File Offset: 0x0000905C
		public bool SaveXml()
		{
			return this.m_XmlFileName != null && this.SaveXml(this.m_XmlFileName);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000AE74 File Offset: 0x00009074
		public bool SaveDb()
		{
			return this.m_FileName != null && this.SaveDb(this.m_FileName);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000AE8C File Offset: 0x0000908C
		public void Document()
		{
			if (this.m_FileName == null)
			{
				return;
			}
			FileStream fileStream = new FileStream(Path.GetFullPath(this.m_FileName).Replace(".db", ".txt"), FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			for (int i = 0; i < this.m_NTables; i++)
			{
				string tableName = this.m_Table[i].TableDescriptor.TableName;
				streamWriter.WriteLine(string.Concat(new string[] { "static private string t_", tableName, " = \"", tableName, "\";" }));
			}
			for (int j = 0; j < this.m_NTables; j++)
			{
				string tableName2 = this.m_Table[j].TableDescriptor.TableName;
				streamWriter.WriteLine("static public int " + tableName2 + ";");
			}
			for (int k = 0; k < this.m_NTables; k++)
			{
				string tableName3 = this.m_Table[k].TableDescriptor.TableName;
				streamWriter.WriteLine(tableName3 + " = fifaDbFile.GetTableIndex(t_" + tableName3 + ");");
			}
			for (int l = 0; l < this.m_NTables; l++)
			{
				string tableName4 = this.m_Table[l].TableDescriptor.TableName;
				for (int m = 0; m < this.m_Table[l].TableDescriptor.NFields; m++)
				{
					string fieldName = this.m_Table[l].TableDescriptor.FieldDescriptors[m].FieldName;
					FieldDescriptor.EFieldTypes fieldType = this.m_Table[l].TableDescriptor.FieldDescriptors[m].FieldType;
					streamWriter.WriteLine(string.Concat(new string[] { "public static int ", tableName4, "_", fieldName, " = -1;" }));
				}
			}
			for (int n = 0; n < this.m_NTables; n++)
			{
				string tableName5 = this.m_Table[n].TableDescriptor.TableName;
				for (int num = 0; num < this.m_Table[n].TableDescriptor.NFields; num++)
				{
					string fieldName2 = this.m_Table[n].TableDescriptor.FieldDescriptors[num].FieldName;
					FieldDescriptor.EFieldTypes fieldType2 = this.m_Table[n].TableDescriptor.FieldDescriptors[num].FieldType;
					streamWriter.WriteLine(string.Concat(new string[]
					{
						tableName5,
						"_",
						fieldName2,
						" = ",
						this.m_Table[n].TableDescriptor.FieldDescriptors[num].TypeIndex.ToString(),
						"; //",
						fieldType2.ToString()
					}));
				}
			}
			streamWriter.Close();
			fileStream.Close();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000B170 File Offset: 0x00009370
		public DataSet ConvertToDataSet()
		{
			if (this.m_NTables == 0)
			{
				return null;
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			DataSet dataSet = new DataSet();
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				dataSet.Tables.Add(this.Table[i].ConvertToDataTable());
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return dataSet;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000B1F8 File Offset: 0x000093F8
		public void ConvertFromDataSet(DataSet dataSet)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				this.Table[i].ConvertFromDataTable(dataSet.Tables[i]);
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000B270 File Offset: 0x00009470
		public int GetTableIndex(string tableName)
		{
			for (int i = 0; i < this.NTables; i++)
			{
				if (this.Table[i].TableDescriptor.TableName == tableName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000B2AC File Offset: 0x000094AC
		public bool Expand()
		{
			bool flag = true;
			bool flag2 = this.ExpandTableField("formations", "formationid", 11);
			bool flag3 = flag && !flag2;
			this.RecalculateFieldOffset("formations");
			flag2 = this.ExpandTableField("teamformationteamstylelinks", "formationid", 11);
			bool flag4 = flag3 && !flag2;
			this.RecalculateFieldOffset("teamformationteamstylelinks");
			flag2 = this.ExpandTableField("temp_formations", "formationid", 11);
			bool flag5 = flag4 && !flag2;
			this.RecalculateFieldOffset("temp_formations");
			flag2 = this.ExpandTableField("customformations", "formationid", 11);
			bool flag6 = flag5 && !flag2;
			this.RecalculateFieldOffset("customformations");
			flag2 = this.ExpandTableField("teamsheets", "teamsheetid", 11);
			bool flag7 = flag6 && !flag2;
			this.RecalculateFieldOffset("teamsheetid");
			flag2 = this.ExpandTableField("playernames", "nameid", 16);
			bool flag8 = flag7 && !flag2;
			this.RecalculateFieldOffset("playernames");
			flag2 = this.ExpandTableField("career_lastnames", "lastname", 16);
			bool flag9 = flag8 && !flag2;
			this.RecalculateFieldOffset("career_lastnames");
			flag2 = this.ExpandTableField("career_firstnames", "firstname", 16);
			bool flag10 = flag9 && !flag2;
			this.RecalculateFieldOffset("career_firstnames");
			flag2 = this.ExpandTableField("career_commonnames", "firstname", 16);
			bool flag11 = flag10 && !flag2;
			flag2 = this.ExpandTableField("career_lastnames", "lastname", 16);
			bool flag12 = flag11 && !flag2;
			this.RecalculateFieldOffset("career_commonnames");
			flag2 = this.ExpandTableField("trainingteamplayernames", "nameid", 16);
			bool flag13 = flag12 && !flag2;
			this.RecalculateFieldOffset("trainingteamplayernames");
			flag2 = this.ExpandTableField("players", "firstnameid", 16);
			bool flag14 = flag13 && !flag2;
			flag2 = this.ExpandTableField("players", "lastnameid", 16);
			bool flag15 = flag14 && !flag2;
			flag2 = this.ExpandTableField("players", "commonnameid", 16);
			bool flag16 = flag15 && !flag2;
			flag2 = this.ExpandTableField("players", "playerjerseynameid", 16);
			bool flag17 = flag16 && !flag2;
			this.RecalculateFieldOffset("players");
			flag2 = this.ExpandTableField("trainingteamplayernames", "firstnameid", 16);
			bool flag18 = flag17 && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "lastnameid", 16);
			bool flag19 = flag18 && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "commonnameid", 16);
			bool flag20 = flag19 && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "playerjerseynameid", 16);
			bool flag21 = flag20 && !flag2;
			this.RecalculateFieldOffset("trainingteamplayernames");
			flag2 = this.ExpandTableField("referee", "refereeid", 10);
			bool flag22 = flag21 && !flag2;
			this.RecalculateFieldOffset("referee");
			flag2 = this.ExpandTableField("leaguerefereelinks", "refereeid", 10);
			bool flag23 = flag22 && !flag2;
			this.RecalculateFieldOffset("leaguerefereelinks");
			this.m_NeedToSaveXmlFile = true;
			return flag23;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000B5B8 File Offset: 0x000097B8
		private bool ExpandTableField(string tableName, string fieldName, int nBits)
		{
			Table table = this.GetTable(tableName);
			return table != null && table.ExpandField(fieldName, nBits);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000B5DC File Offset: 0x000097DC
		private bool ExpandTableField(string tableName, string fieldName, int nBits, int minValue)
		{
			Table table = this.GetTable(tableName);
			return table != null && table.ExpandField(fieldName, nBits, minValue);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B600 File Offset: 0x00009800
		private bool RecalculateFieldOffset(string tableName)
		{
			Table table = this.GetTable(tableName);
			if (table == null)
			{
				return false;
			}
			table.TableDescriptor.RecalculateFieldOffset();
			return true;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B628 File Offset: 0x00009828
		public Table GetTable(string longName)
		{
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_Table[i].TableDescriptor.TableName == longName)
				{
					return this.m_Table[i];
				}
			}
			return null;
		}

		// Token: 0x04000097 RID: 151
		protected char[] m_Signature;

		// Token: 0x04000098 RID: 152
		protected int m_FileLength;

		// Token: 0x04000099 RID: 153
		private long m_SignaturePosition;

		// Token: 0x0400009A RID: 154
		private uint m_CrcHeader;

		// Token: 0x0400009B RID: 155
		private long m_CrcHeaderPosition;

		// Token: 0x0400009C RID: 156
		private uint m_CrcShortNames;

		// Token: 0x0400009D RID: 157
		private long m_CrcShortNamesPosition;

		// Token: 0x0400009E RID: 158
		private uint[] m_TableOffset;

		// Token: 0x0400009F RID: 159
		private Table[] m_Table;

		// Token: 0x040000A0 RID: 160
		protected int m_NTables;

		// Token: 0x040000A1 RID: 161
		private ToolStripProgressBar m_ProgressBar;

		// Token: 0x040000A2 RID: 162
		protected string m_FileName;

		// Token: 0x040000A3 RID: 163
		protected string m_XmlFileName;

		// Token: 0x040000A4 RID: 164
		protected DataSet m_DescriptorDataSet;

		// Token: 0x040000A5 RID: 165
		private bool m_NeedToSaveXmlFile;

		// Token: 0x040000A6 RID: 166
		protected FifaPlatform m_Platform;
	}
}
