using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200001A RID: 26
	public class SbrFile
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00004E6C File Offset: 0x0000306C
		public int Length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004E74 File Offset: 0x00003074
		public string SbrFileName
		{
			get
			{
				return this.m_SbrFileName;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004648 File Offset: 0x00002848
		public SbrFile()
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004E7C File Offset: 0x0000307C
		public SbrFile(string sbrFileName)
		{
			this.m_SbrFileName = sbrFileName;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004E8C File Offset: 0x0000308C
		public bool Load()
		{
			string text = FifaEnvironment.GameDir + this.m_SbrFileName;
			if (!File.Exists(text))
			{
				return false;
			}
			FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
			if (fileStream == null)
			{
				return false;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			if (binaryReader == null)
			{
				return false;
			}
			this.m_Signature = binaryReader.ReadChars(4);
			if (this.m_Signature[0] != 'S' || this.m_Signature[1] != 'B' || this.m_Signature[2] != 'l' || this.m_Signature[3] != 'e')
			{
				return false;
			}
			this.m_Length = binaryReader.ReadInt32();
			return true;
		}

		// Token: 0x0400002C RID: 44
		private int m_Length;

		// Token: 0x0400002D RID: 45
		private string m_SbrFileName;

		// Token: 0x0400002E RID: 46
		protected char[] m_Signature;
	}
}
