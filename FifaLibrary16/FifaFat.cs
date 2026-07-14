using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000034 RID: 52
	public class FifaFat
	{
		// Token: 0x1700009C RID: 156
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000193B7 File Offset: 0x000175B7
		public ToolStripProgressBar ProgressBar
		{
			set
			{
				this.m_ProgressBar = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000193C0 File Offset: 0x000175C0
		public string GamePath
		{
			get
			{
				return this.m_GamePath;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000193C8 File Offset: 0x000175C8
		public BhFile GetBhFile(int index)
		{
			if (index < 0 || index >= this.m_NBigFiles)
			{
				return null;
			}
			return this.m_BhFiles[index];
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000193E4 File Offset: 0x000175E4
		public FifaBigFile GetBigFile(int index)
		{
			if (index < 0 || index >= this.m_NBigFiles)
			{
				return null;
			}
			if (this.m_BigFiles[index] != null)
			{
				return this.m_BigFiles[index];
			}
			this.m_BigFiles[index] = new FifaBigFile(this.m_BigFileNames[index]);
			return this.m_BigFiles[index];
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00019430 File Offset: 0x00017630
		public int NBigFiles
		{
			get
			{
				return this.m_NBigFiles;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00019438 File Offset: 0x00017638
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00019440 File Offset: 0x00017640
		public FifaFat.EFifaFatSaveOption SaveOption
		{
			get
			{
				return this.m_SaveOption;
			}
			set
			{
				this.m_SaveOption = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00019449 File Offset: 0x00017649
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00019451 File Offset: 0x00017651
		public int Min_Zdata
		{
			get
			{
				return this.m_MinZdata;
			}
			set
			{
				this.m_MinZdata = value;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001945A File Offset: 0x0001765A
		public static FifaFat Create(string gamePath)
		{
			if (!Directory.Exists(gamePath))
			{
				return null;
			}
			FifaFat fifaFat = new FifaFat();
			fifaFat.m_GamePath = gamePath;
			fifaFat.Load();
			fifaFat.m_SaveOption = FifaFat.EFifaFatSaveOption.SaveAlways;
			return fifaFat;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00019480 File Offset: 0x00017680
		private void LoadBigFromFolder(string folder)
		{
			if (!Directory.Exists(folder))
			{
				return;
			}
			string[] files = Directory.GetFiles(folder, "*.big");
			if (files == null)
			{
				return;
			}
			foreach (string text in files)
			{
				string text2 = text;
				string text3 = folder + Path.GetFileNameWithoutExtension(text) + ".bh";
				if (File.Exists(text2))
				{
					this.m_BigFileNames[this.m_NBigFiles] = text2;
					this.m_BhFileNames[this.m_NBigFiles] = text3;
					if (File.Exists(text3))
					{
						this.m_BhFiles[this.m_NBigFiles] = new BhFile(text3);
					}
					else
					{
						this.m_BigFiles[this.m_NBigFiles] = new FifaBigFile(text2);
						if (this.m_BhFiles[this.m_NBigFiles] == null)
						{
							this.m_BigFiles[this.m_NBigFiles].LoadArchivedFiles();
							this.m_BhFiles[this.m_NBigFiles] = new BhFile(this.m_BigFiles[this.m_NBigFiles], true);
						}
					}
					this.m_NBigFiles++;
				}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00019584 File Offset: 0x00017784
		private void Load()
		{
			this.m_NBigFiles = 0;
			string text = this.m_GamePath;
			this.LoadBigFromFolder(text);
			text = this.m_GamePath + "data\\ui\\imgAssets\\heads\\";
			this.LoadBigFromFolder(text);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000195C0 File Offset: 0x000177C0
		public void Save()
		{
			for (int i = 0; i <= this.m_NBigFiles; i++)
			{
				if (this.m_NeedToSaveBig[i])
				{
					this.GetBigFile(i).Save();
				}
				if (this.m_BhFiles[i] != null)
				{
					this.m_BhFiles[i].Save();
				}
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001960C File Offset: 0x0001780C
		public void RegenerateAllBh(bool hideExternalFiles)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NBigFiles;
				this.m_ProgressBar.Value = 0;
			}
			for (int i = 0; i < this.m_NBigFiles; i++)
			{
				string bigFileNameByIndex = this.GetBigFileNameByIndex(i);
				if (File.Exists(bigFileNameByIndex))
				{
					BhFile.Regenerate(bigFileNameByIndex, hideExternalFiles);
					if (this.m_ProgressBar != null)
					{
						this.m_ProgressBar.Value = i;
					}
				}
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			this.Load();
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00019694 File Offset: 0x00017894
		public bool IsArchivedFilePresent(string fileName)
		{
			return this.GetArchivingBhFileIndex(fileName) >= 0;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000196A3 File Offset: 0x000178A3
		public bool IsPhisycalFilePresent(string fileName)
		{
			return File.Exists(this.m_GamePath + fileName);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000196B8 File Offset: 0x000178B8
		public bool IsHeadFilePresent(string fileName)
		{
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				if (this.m_BhFileNames[i].Contains("heads") && this.m_BhFiles[i].GetArchivedFileIndex(fileName) >= 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00019700 File Offset: 0x00017900
		public string GetBigFileNameByIndex(int index)
		{
			if (index < this.m_NBigFiles)
			{
				return this.m_BigFileNames[index];
			}
			return null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00019715 File Offset: 0x00017915
		public string GetBhFileName(int bigIndex)
		{
			return this.m_GamePath + "data" + bigIndex.ToString() + ".bh";
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00019733 File Offset: 0x00017933
		public string GetBigFileName(int bigIndex)
		{
			return this.m_GamePath + "data" + bigIndex.ToString() + ".big";
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00019751 File Offset: 0x00017951
		public static string GetBhFileName(int bigIndex, string rootPath)
		{
			return rootPath + "data" + bigIndex.ToString() + ".bh";
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001976A File Offset: 0x0001796A
		public static string GetBigFileName(int bigIndex, string rootPath)
		{
			return rootPath + "\\Game\\data" + bigIndex.ToString() + ".big";
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00019784 File Offset: 0x00017984
		public FifaFile GetArchivedFile(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				if (this.m_BhFiles[i] != null)
				{
					int archivedFileIndex = this.m_BhFiles[i].GetArchivedFileIndex(num);
					if (archivedFileIndex >= 0)
					{
						return this.GetBigFile(i).GetArchivedFile(archivedFileIndex);
					}
				}
			}
			return null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000197D8 File Offset: 0x000179D8
		public bool DeleteFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			if (archivedFileIndex < 0)
			{
				return false;
			}
			this.GetBigFile(archivingBhFileIndex).Delete(archivedFileIndex);
			this.m_BhFiles[archivingBhFileIndex].Delete(archivedFileIndex);
			if (this.m_SaveOption == FifaFat.EFifaFatSaveOption.SaveAlways)
			{
				this.GetBigFile(archivingBhFileIndex).Save();
				this.m_BhFiles[archivingBhFileIndex].Save();
			}
			else
			{
				this.m_NeedToSaveBig[archivingBhFileIndex] = true;
			}
			return true;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00019854 File Offset: 0x00017A54
		public bool HideFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			return this.m_BhFiles[archivingBhFileIndex].Hide(archivedFileIndex);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001988C File Offset: 0x00017A8C
		public bool RestoreFile(string fileName)
		{
			int num;
			int archivingBigFileIndex = this.GetArchivingBigFileIndex(fileName, out num);
			return archivingBigFileIndex >= 0 && this.m_BhFiles[archivingBigFileIndex].Restore(fileName, num);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000198B8 File Offset: 0x00017AB8
		public bool ExportFile(string fileName, string exportDir)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			return this.GetBigFile(archivingBhFileIndex).Export(archivedFileIndex, exportDir);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000198F0 File Offset: 0x00017AF0
		public bool ExportFile(string fileName)
		{
			return this.ExportFile(fileName, this.m_GamePath);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00019900 File Offset: 0x00017B00
		public bool ExtractFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			bool flag = this.GetBigFile(archivingBhFileIndex).Export(archivedFileIndex, this.m_GamePath);
			if (flag)
			{
				flag = this.m_BhFiles[archivingBhFileIndex].Hide(archivedFileIndex);
			}
			return flag;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00019954 File Offset: 0x00017B54
		public bool ImportFileAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			int num = this.m_DeafultDataIndex;
			if (num < 0)
			{
				num = this.GetArchivingBhFileIndex(archivedName);
				if (num < 0)
				{
					num = this.GetAvailableBigFileIndex();
				}
			}
			if (num < 0)
			{
				return false;
			}
			this.GetBigFile(num).ImportFileAs(fileName, archivedName, compressionMode);
			if (this.m_SaveOption == FifaFat.EFifaFatSaveOption.SaveAlways)
			{
				this.GetBigFile(num).Save();
				this.m_BhFiles[num] = new BhFile(this.GetBigFile(num), true);
				this.m_BhFiles[num].Save();
			}
			else
			{
				this.m_BhFiles[num] = new BhFile(this.GetBigFile(num), true);
				this.m_NeedToSaveBig[num] = true;
			}
			if (delete)
			{
				File.Delete(fileName);
			}
			return true;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00019A18 File Offset: 0x00017C18
		public bool ImportFile(string fileName, bool delete, ECompressionMode compressionMode)
		{
			string fileName2 = Path.GetFileName(fileName);
			return this.ImportFileAs(fileName, fileName2, delete, compressionMode);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00019A38 File Offset: 0x00017C38
		public ECompressionMode GetCompressionMode(string fileName)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileName);
			if (archivedFile == null)
			{
				return ECompressionMode.None;
			}
			return archivedFile.CompressionMode;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00019A58 File Offset: 0x00017C58
		private FifaBigFile GetArchivingBigFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex >= 0)
			{
				return this.GetBigFile(archivingBhFileIndex);
			}
			return null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00019A7C File Offset: 0x00017C7C
		private int GetArchivingBhFileIndex(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				if (this.m_BhFiles[i] != null && this.m_BhFiles[i].IsArchivedFilePresent(num))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00019AC0 File Offset: 0x00017CC0
		private int GetArchivingBigFileIndex(string fileName, out int fileIndex)
		{
			fileIndex = -1;
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				fileIndex = this.GetBigFile(i).GetArchivedFileIndex(fileName, true);
				if (fileIndex >= 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00019AFC File Offset: 0x00017CFC
		private FifaBigFile GetAvailableBigFile()
		{
			int availableBigFileIndex = this.GetAvailableBigFileIndex();
			if (availableBigFileIndex < 0)
			{
				return null;
			}
			return this.GetBigFile(availableBigFileIndex);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00019B20 File Offset: 0x00017D20
		private int GetAvailableBigFileIndex()
		{
			for (int i = this.m_MinZdata; i < 100; i++)
			{
				if (this.m_BigFiles[i] == null)
				{
					this.CreateNewBigFile(i);
					return i;
				}
				if (this.m_BigFiles[i].NFiles < 500)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00019B6C File Offset: 0x00017D6C
		public void CreateNewBigFile(int index)
		{
			string bigFileName = this.GetBigFileName(index);
			FileStream fileStream = new FileStream(bigFileName, FileMode.Create, FileAccess.Write);
			fileStream.WriteByte(0);
			fileStream.Close();
			this.m_BigFiles[index] = new FifaBigFile(bigFileName);
			this.m_BhFiles[index] = new BhFile(this.m_BigFiles[index], false);
			this.m_NeedToSaveBig[index] = false;
			if (index > this.m_NBigFiles)
			{
				this.m_NBigFiles = index;
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00019BD2 File Offset: 0x00017DD2
		public void ResetDefaultZdata()
		{
			this.m_DeafultDataIndex = -1;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00019BDC File Offset: 0x00017DDC
		public ArrayList FindDuplicatedFiles()
		{
			ArrayList arrayList = new ArrayList();
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = 100;
			}
			int num = 0;
			for (int i = 0; i < 100; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				if (this.m_BhFiles[i] != null)
				{
					for (int j = 0; j < this.m_BhFiles[i].NFiles; j++)
					{
						ulong hash = this.m_BhFiles[i].GetHash(j);
						for (int k = i + 1; k < 100; k++)
						{
							if (this.m_BhFiles[k] != null && this.m_BhFiles[k].GetArchivedFileIndex(hash) >= 0)
							{
								num++;
								FifaBigFile fifaBigFile = new FifaBigFile(this.GetBigFileName(i));
								FifaFile fifaFile = fifaBigFile.Files[j];
								string text = string.Concat(new string[]
								{
									fifaFile.Name,
									" is duplicated in ",
									fifaBigFile.Name,
									" and ",
									Path.GetFileName(this.GetBigFileName(k)),
									"\r\n"
								});
								arrayList.Add(text);
							}
						}
					}
				}
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			if (num == 0)
			{
				arrayList.Add("No duplicated files found.");
			}
			else
			{
				arrayList.Add(num.ToString() + " duplicated files found.");
			}
			return arrayList;
		}

		// Token: 0x04000D45 RID: 3397
		private ToolStripProgressBar m_ProgressBar;

		// Token: 0x04000D46 RID: 3398
		private string m_GamePath;

		// Token: 0x04000D47 RID: 3399
		private BhFile[] m_BhFiles = new BhFile[100];

		// Token: 0x04000D48 RID: 3400
		private FifaBigFile[] m_BigFiles = new FifaBigFile[100];

		// Token: 0x04000D49 RID: 3401
		private bool[] m_NeedToSaveBig = new bool[100];

		// Token: 0x04000D4A RID: 3402
		private string[] m_BigFileNames = new string[100];

		// Token: 0x04000D4B RID: 3403
		private string[] m_BhFileNames = new string[100];

		// Token: 0x04000D4C RID: 3404
		private int m_NBigFiles;

		// Token: 0x04000D4D RID: 3405
		private FifaFat.EFifaFatSaveOption m_SaveOption;

		// Token: 0x04000D4E RID: 3406
		private int m_MinZdata = 8;

		// Token: 0x04000D4F RID: 3407
		private int m_DeafultDataIndex = -1;

		// Token: 0x020000AE RID: 174
		public enum EFifaFatSaveOption
		{
			// Token: 0x0400124F RID: 4687
			SaveAlways,
			// Token: 0x04001250 RID: 4688
			SaveOnCommand
		}
	}
}
