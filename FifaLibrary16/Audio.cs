using System;
using System.Data;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000019 RID: 25
	public class Audio
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004AB6 File Offset: 0x00002CB6
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00004AC0 File Offset: 0x00002CC0
		public string StandardLanguage
		{
			get
			{
				return this.m_StandardLanguage;
			}
			set
			{
				this.m_StandardLanguage = value;
				if (this.m_StandardLanguage == null)
				{
					this.m_XmlFileName = null;
					this.m_SbrFileName = null;
					this.m_SbsFileName = null;
					this.m_BigFileName = null;
					return;
				}
				this.m_XmlFileName = string.Concat(new string[] { "audiodata/speechdata/", this.m_StandardLanguage, "/", this.m_StandardLanguage, ".xml" });
				this.m_SbrFileName = string.Concat(new string[] { "audiodata/speechdata/", this.m_StandardLanguage, "/", this.m_StandardLanguage, "_bank.sbr" });
				this.m_SbsFileName = string.Concat(new string[] { "audiodata/speechdata/", this.m_StandardLanguage, "/", this.m_StandardLanguage, "_bank.sbs" });
				this.m_BigFileName = this.m_StandardLanguage + ".big";
				this.m_BhFileName = this.m_StandardLanguage + ".bh";
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00004BD6 File Offset: 0x00002DD6
		public string XmlFileName
		{
			get
			{
				return this.m_XmlFileName;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00004BDE File Offset: 0x00002DDE
		public string SbrFileName
		{
			get
			{
				return this.m_SbrFileName;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public string SbsFileName
		{
			get
			{
				return this.m_SbsFileName;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004BEE File Offset: 0x00002DEE
		public string BigFileName
		{
			get
			{
				return this.m_BigFileName;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00004BF6 File Offset: 0x00002DF6
		public string BhFileName
		{
			get
			{
				return this.m_BhFileName;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00004BFE File Offset: 0x00002DFE
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00004C06 File Offset: 0x00002E06
		public DataSet DescriptorDataSet
		{
			get
			{
				return this.m_AudioXmlDataSet;
			}
			set
			{
				this.m_AudioXmlDataSet = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00004C0F File Offset: 0x00002E0F
		public SbrFile SbrFile
		{
			get
			{
				return this.m_SbrFile;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004C18 File Offset: 0x00002E18
		public bool IsAudioExtracted()
		{
			if (this.m_StandardLanguage == null)
			{
				return false;
			}
			if (!File.Exists(FifaEnvironment.GameDir + this.XmlFileName))
			{
				return false;
			}
			if (!File.Exists(FifaEnvironment.GameDir + this.SbrFileName))
			{
				return false;
			}
			if (!File.Exists(FifaEnvironment.GameDir + this.SbsFileName))
			{
				return false;
			}
			FifaEnvironment.FifaFat.HideFile(this.XmlFileName);
			FifaEnvironment.FifaFat.HideFile(this.SbrFileName);
			FifaEnvironment.FifaFat.HideFile(this.SbsFileName);
			return true;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004CAE File Offset: 0x00002EAE
		public bool IsAudioPresent()
		{
			return this.m_StandardLanguage != null && File.Exists(FifaEnvironment.GameDir + this.BigFileName);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public bool ExtractAudio()
		{
			return this.m_StandardLanguage != null && this.IsAudioPresent() && FifaEnvironment.FifaFat.ExtractFile(this.XmlFileName) && FifaEnvironment.FifaFat.ExtractFile(this.SbrFileName) && FifaEnvironment.FifaFat.ExtractFile(this.SbsFileName);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004D34 File Offset: 0x00002F34
		public bool LoadXml()
		{
			string text = FifaEnvironment.GameDir + this.m_XmlFileName;
			if (!File.Exists(text))
			{
				return false;
			}
			this.m_AudioXmlDataSet = new DataSet();
			this.m_AudioXmlDataSet.ReadXml(text);
			DataTable dataTable = this.m_AudioXmlDataSet.Tables["SampleGroup"];
			string text2 = "pSIMPLE_SURNAME";
			string text3 = "pPLAYER_NAMES";
			string text4 = null;
			string text5 = null;
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				DataRow dataRow = dataTable.Rows[i];
				if (dataRow["Name"].ToString() == text2)
				{
					text4 = dataRow["SampleGroupKey"].ToString();
				}
				if (dataRow["Name"].ToString() == text3)
				{
					text5 = dataRow["SampleGroupKey"].ToString();
				}
			}
			if (text4 != null)
			{
				this.m_SimpleSurnameKey = Convert.ToUInt32(text4, 16);
			}
			if (text5 != null)
			{
				this.m_PlayerNamesKey = Convert.ToUInt32(text5, 16);
			}
			return text4 != null && text5 != null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004E4E File Offset: 0x0000304E
		public bool LoadSbr()
		{
			this.m_SbrFile = new SbrFile(this.m_SbrFileName);
			return this.m_SbrFile.Load();
		}

		// Token: 0x04000022 RID: 34
		private string m_StandardLanguage;

		// Token: 0x04000023 RID: 35
		private string m_XmlFileName;

		// Token: 0x04000024 RID: 36
		private string m_SbrFileName;

		// Token: 0x04000025 RID: 37
		private string m_SbsFileName;

		// Token: 0x04000026 RID: 38
		private string m_BigFileName;

		// Token: 0x04000027 RID: 39
		private string m_BhFileName;

		// Token: 0x04000028 RID: 40
		private DataSet m_AudioXmlDataSet;

		// Token: 0x04000029 RID: 41
		private uint m_SimpleSurnameKey;

		// Token: 0x0400002A RID: 42
		private uint m_PlayerNamesKey;

		// Token: 0x0400002B RID: 43
		private SbrFile m_SbrFile;
	}
}
