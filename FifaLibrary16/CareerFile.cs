using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000033 RID: 51
	public class CareerFile
	{
		// Token: 0x17000095 RID: 149
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00018F80 File Offset: 0x00017180
		public ToolStripProgressBar ProgressBar
		{
			set
			{
				this.m_ProgressBar = value;
				for (int i = 0; i < this.m_NDatabases; i++)
				{
					this.m_Database[i].ProgressBar = this.m_ProgressBar;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00018FB8 File Offset: 0x000171B8
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00018FC0 File Offset: 0x000171C0
		public string XmlFileName
		{
			get
			{
				return this.m_XmlFileName;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00018FC8 File Offset: 0x000171C8
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00018FD0 File Offset: 0x000171D0
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00018FD9 File Offset: 0x000171D9
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00018FE1 File Offset: 0x000171E1
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00018FEA File Offset: 0x000171EA
		public DbFile[] Databases
		{
			get
			{
				return this.m_Database;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00018FF2 File Offset: 0x000171F2
		public int NDatabases
		{
			get
			{
				return this.m_NDatabases;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00018FFA File Offset: 0x000171FA
		public CareerFile(string careerFileName, string xmlFileName, ToolStripProgressBar progressBar)
		{
			this.m_ProgressBar = progressBar;
			this.m_FileName = careerFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.Load();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00019031 File Offset: 0x00017231
		public CareerFile(string careerFileName, string xmlFileName)
		{
			this.m_ProgressBar = null;
			this.m_FileName = careerFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.Load();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00019068 File Offset: 0x00017268
		public bool Load()
		{
			return this.LoadXml() && this.LoadEA(this.m_FileName);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00019080 File Offset: 0x00017280
		public bool LoadXml(string xmlFileName)
		{
			if (!File.Exists(xmlFileName))
			{
				return false;
			}
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = new DataSet("XML_Descriptor");
			this.m_DescriptorDataSet.ReadXml(this.m_XmlFileName);
			return true;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000190B6 File Offset: 0x000172B6
		public bool LoadXml()
		{
			return this.m_XmlFileName != null && this.LoadXml(this.m_XmlFileName);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000190D0 File Offset: 0x000172D0
		public bool LoadEA(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			DbReader dbReader = new DbReader(fileStream, FifaPlatform.PC);
			this.m_HeaderSignature = dbReader.ReadChars(16);
			this.m_CrcEaHeaderPosition = dbReader.BaseStream.Position;
			this.m_CrcEaHeader = dbReader.ReadUInt32();
			this.m_CryptArea = dbReader.ReadBytes(24);
			while (dbReader.BaseStream.Position < dbReader.BaseStream.Length)
			{
				this.m_Database[this.m_NDatabases] = new DbFile();
				this.m_Database[this.m_NDatabases].ProgressBar = this.m_ProgressBar;
				this.m_Database[this.m_NDatabases].DescriptorDataSet = this.m_DescriptorDataSet;
				if (!this.m_Database[this.m_NDatabases].LoadDb(dbReader, true))
				{
					break;
				}
				this.m_NDatabases++;
			}
			dbReader.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000191B4 File Offset: 0x000173B4
		public bool SaveEa(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
			DbWriter dbWriter = new DbWriter(fileStream, this.m_Platform);
			DbReader dbReader = new DbReader(fileStream, this.m_Platform);
			dbWriter.Write(this.m_HeaderSignature);
			dbWriter.Write(-1);
			dbWriter.Write(this.m_CryptArea);
			for (int i = 0; i < this.m_NDatabases; i++)
			{
				this.m_Database[i].SaveDb(dbWriter);
			}
			for (int j = 0; j < this.m_NDatabases; j++)
			{
				this.m_Database[j].ComputeAllCrc(dbReader, dbWriter);
			}
			dbReader.Close();
			dbWriter.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001925C File Offset: 0x0001745C
		private uint ComputeCrc(BinaryReader r, int offset, int size)
		{
			uint num = uint.MaxValue;
			r.BaseStream.Position = (long)offset;
			for (int i = 0; i < size; i++)
			{
				byte b = r.ReadByte();
				num = CareerFile.s_CrcTable[(int)(((num >> 24) ^ (uint)b) & 255U)] ^ (num << 8);
			}
			return num ^ uint.MaxValue;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000192A8 File Offset: 0x000174A8
		private uint ComputeChecksum24(BinaryReader r)
		{
			r.BaseStream.Position = 0L;
			uint num = (uint)r.ReadByte();
			num <<= 8;
			num |= (uint)r.ReadByte();
			num <<= 8;
			num |= (uint)r.ReadByte();
			num <<= 8;
			num |= (uint)r.ReadByte();
			num ^= uint.MaxValue;
			for (int i = 20; i > 0; i--)
			{
				byte b = r.ReadByte();
				uint num2 = CareerFile.s_CrcTable[(int)(num >> 24)];
				num <<= 8;
				num |= (uint)b;
				num ^= num2;
			}
			return num ^ uint.MaxValue;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00019324 File Offset: 0x00017524
		public void ConvertFromDataSet(DataSet[] dataSet)
		{
			if (dataSet.Length != this.m_NDatabases)
			{
				return;
			}
			for (int i = 0; i < this.m_NDatabases; i++)
			{
				this.m_Database[i].ConvertFromDataSet(dataSet[i]);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00019360 File Offset: 0x00017560
		public DataSet[] ConvertToDataSet()
		{
			DataSet[] array = new DataSet[this.m_NDatabases];
			for (int i = 0; i < this.m_NDatabases; i++)
			{
				array[i] = this.m_Database[i].ConvertToDataSet();
			}
			return array;
		}

		// Token: 0x04000D39 RID: 3385
		private ToolStripProgressBar m_ProgressBar;

		// Token: 0x04000D3A RID: 3386
		protected string m_FileName;

		// Token: 0x04000D3B RID: 3387
		protected string m_XmlFileName;

		// Token: 0x04000D3C RID: 3388
		protected DataSet m_DescriptorDataSet;

		// Token: 0x04000D3D RID: 3389
		protected FifaPlatform m_Platform;

		// Token: 0x04000D3E RID: 3390
		private char[] m_HeaderSignature;

		// Token: 0x04000D3F RID: 3391
		private byte[] m_CryptArea;

		// Token: 0x04000D40 RID: 3392
		private uint m_CrcEaHeader;

		// Token: 0x04000D41 RID: 3393
		private long m_CrcEaHeaderPosition;

		// Token: 0x04000D42 RID: 3394
		private DbFile[] m_Database = new DbFile[4];

		// Token: 0x04000D43 RID: 3395
		private int m_NDatabases;

		// Token: 0x04000D44 RID: 3396
		private static uint[] s_CrcTable = new uint[]
		{
			0U, 79764919U, 159529838U, 222504665U, 319059676U, 398814059U, 445009330U, 507990021U, 638119352U, 583659535U,
			797628118U, 726387553U, 890018660U, 835552979U, 1015980042U, 944750013U, 1276238704U, 1221641927U, 1167319070U, 1095957929U,
			1595256236U, 1540665371U, 1452775106U, 1381403509U, 1780037320U, 1859660671U, 1671105958U, 1733955601U, 2031960084U, 2111593891U,
			1889500026U, 1952343757U, 2552477408U, 2632100695U, 2443283854U, 2506133561U, 2334638140U, 2414271883U, 2191915858U, 2254759653U,
			3190512472U, 3135915759U, 3081330742U, 3009969537U, 2905550212U, 2850959411U, 2762807018U, 2691435357U, 3560074640U, 3505614887U,
			3719321342U, 3648080713U, 3342211916U, 3287746299U, 3467911202U, 3396681109U, 4063920168U, 4143685023U, 4223187782U, 4286162673U,
			3779000052U, 3858754371U, 3904687514U, 3967668269U, 881225847U, 809987520U, 1023691545U, 969234094U, 662832811U, 591600412U,
			771767749U, 717299826U, 311336399U, 374308984U, 453813921U, 533576470U, 25881363U, 88864420U, 134795389U, 214552010U,
			2023205639U, 2086057648U, 1897238633U, 1976864222U, 1804852699U, 1867694188U, 1645340341U, 1724971778U, 1587496639U, 1516133128U,
			1461550545U, 1406951526U, 1302016099U, 1230646740U, 1142491917U, 1087903418U, 2896545431U, 2825181984U, 2770861561U, 2716262478U,
			3215044683U, 3143675388U, 3055782693U, 3001194130U, 2326604591U, 2389456536U, 2200899649U, 2280525302U, 2578013683U, 2640855108U,
			2418763421U, 2498394922U, 3769900519U, 3832873040U, 3912640137U, 3992402750U, 4088425275U, 4151408268U, 4197601365U, 4277358050U,
			3334271071U, 3263032808U, 3476998961U, 3422541446U, 3585640067U, 3514407732U, 3694837229U, 3640369242U, 1762451694U, 1842216281U,
			1619975040U, 1682949687U, 2047383090U, 2127137669U, 1938468188U, 2001449195U, 1325665622U, 1271206113U, 1183200824U, 1111960463U,
			1543535498U, 1489069629U, 1434599652U, 1363369299U, 622672798U, 568075817U, 748617968U, 677256519U, 907627842U, 853037301U,
			1067152940U, 995781531U, 51762726U, 131386257U, 177728840U, 240578815U, 269590778U, 349224269U, 429104020U, 491947555U,
			4046411278U, 4126034873U, 4172115296U, 4234965207U, 3794477266U, 3874110821U, 3953728444U, 4016571915U, 3609705398U, 3555108353U,
			3735388376U, 3664026991U, 3290680682U, 3236090077U, 3449943556U, 3378572211U, 3174993278U, 3120533705U, 3032266256U, 2961025959U,
			2923101090U, 2868635157U, 2813903052U, 2742672763U, 2604032198U, 2683796849U, 2461293480U, 2524268063U, 2284983834U, 2364738477U,
			2175806836U, 2238787779U, 1569362073U, 1498123566U, 1409854455U, 1355396672U, 1317987909U, 1246755826U, 1192025387U, 1137557660U,
			2072149281U, 2135122070U, 1912620623U, 1992383480U, 1753615357U, 1816598090U, 1627664531U, 1707420964U, 295390185U, 358241886U,
			404320391U, 483945776U, 43990325U, 106832002U, 186451547U, 266083308U, 932423249U, 861060070U, 1041341759U, 986742920U,
			613929101U, 542559546U, 756411363U, 701822548U, 3316196985U, 3244833742U, 3425377559U, 3370778784U, 3601682597U, 3530312978U,
			3744426955U, 3689838204U, 3819031489U, 3881883254U, 3928223919U, 4007849240U, 4037393693U, 4100235434U, 4180117107U, 4259748804U,
			2310601993U, 2373574846U, 2151335527U, 2231098320U, 2596047829U, 2659030626U, 2470359227U, 2550115596U, 2947551409U, 2876312838U,
			2788305887U, 2733848168U, 3165939309U, 3094707162U, 3040238851U, 2985771188U
		};
	}
}
