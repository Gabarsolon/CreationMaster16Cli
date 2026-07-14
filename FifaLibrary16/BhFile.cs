using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200001B RID: 27
	public class BhFile
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00004F1A File Offset: 0x0000311A
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004F24 File Offset: 0x00003124
		private bool Load(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			this.m_BhName = fileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			if (binaryReader.BaseStream.Length < 16L)
			{
				return false;
			}
			char[] array = binaryReader.ReadChars(4);
			if (array[0] != 'V' || array[1] != 'i' || array[2] != 'V' || array[3] != '4')
			{
				binaryReader.Close();
				fileStream.Close();
				return false;
			}
			this.m_TotalFileSize = binaryReader.ReadInt32();
			this.m_NFiles = FifaUtil.SwapEndian(binaryReader.ReadInt32());
			FifaUtil.SwapEndian(binaryReader.ReadInt32());
			this.m_BhFileReference = new BhFileReference[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_BhFileReference[i] = new BhFileReference();
				this.m_BhFileReference[i].Load(binaryReader);
			}
			if (binaryReader.BaseStream.Position <= binaryReader.BaseStream.Length - 4L)
			{
				this.m_TotalBigFileSize = FifaUtil.SwapEndian(binaryReader.ReadInt32());
			}
			binaryReader.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005038 File Offset: 0x00003238
		public bool Load(FifaBigFile bigFile, bool hideExternalFiles)
		{
			string text;
			if (FifaEnvironment.Year == 14)
			{
				int num = bigFile.PhysicalName.IndexOf("\\Game\\", 0, StringComparison.InvariantCultureIgnoreCase);
				if (num >= 0)
				{
					text = bigFile.PhysicalName.Substring(0, num + 6);
				}
				else
				{
					text = Path.GetDirectoryName(bigFile.PhysicalName) + "\\";
				}
			}
			else
			{
				int num = bigFile.PhysicalName.IndexOf("\\FIFA 16\\", 0, StringComparison.InvariantCultureIgnoreCase);
				if (num >= 0)
				{
					text = bigFile.PhysicalName.Substring(0, num + 9);
				}
				else
				{
					text = Path.GetDirectoryName(bigFile.PhysicalName) + "\\";
				}
			}
			this.m_BhName = Path.GetDirectoryName(bigFile.PhysicalName) + "\\" + Path.GetFileNameWithoutExtension(bigFile.PhysicalName) + ".bh";
			this.m_NFiles = bigFile.NFiles;
			if (this.m_BhName.Contains("FIFA 11"))
			{
				this.m_TotalFileSize = 16 + (this.m_NFiles + 1) * 20;
			}
			else
			{
				this.m_TotalFileSize = 16 + this.m_NFiles * 20;
			}
			this.m_BhFileReference = new BhFileReference[this.m_NFiles];
			this.m_TotalBigFileSize = bigFile.UncompressedSize;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				uint startPosition = bigFile.Headers[i].StartPosition;
				int size = bigFile.Headers[i].Size;
				if (bigFile.Files[i] == null)
				{
					bigFile.LoadArchivedFile(i);
				}
				int num2;
				if (bigFile.Files[i].CompressionMode == ECompressionMode.Compressed_10FB)
				{
					num2 = bigFile.Files[i].UncompressedSize;
				}
				else
				{
					num2 = 0;
				}
				string name = bigFile.Headers[i].Name;
				this.m_BhFileReference[i] = new BhFileReference(startPosition, size, num2, name);
				if (hideExternalFiles && File.Exists(text + name))
				{
					this.m_BhFileReference[i].Hide();
				}
			}
			return true;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005210 File Offset: 0x00003410
		public bool Hide(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName);
			return this.Hide(archivedFileIndex);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000522C File Offset: 0x0000342C
		public bool Hide(int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BhFileReference[fileIndex].Hide();
			return true;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000524B File Offset: 0x0000344B
		public bool IsHidden(int fileIndex)
		{
			return fileIndex >= 0 && fileIndex < this.m_NFiles && this.m_BhFileReference[fileIndex].IsHidden();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000526C File Offset: 0x0000346C
		public bool IsHidden(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName);
			return this.IsHidden(archivedFileIndex);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005288 File Offset: 0x00003488
		public bool Restore(string fileName, int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BhFileReference[fileIndex].Restore(fileName);
			return true;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000052A8 File Offset: 0x000034A8
		public BhFile(FifaBigFile bigFile, bool hideExternalFiles)
		{
			this.Load(bigFile, hideExternalFiles);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000052B9 File Offset: 0x000034B9
		public BhFile(string fileName)
		{
			if (this.Load(fileName))
			{
				this.m_BhName = fileName;
				return;
			}
			this.Reset();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000052D8 File Offset: 0x000034D8
		private void Reset()
		{
			this.m_TotalFileSize = 0;
			this.m_NFiles = 0;
			this.m_BhFileReference = null;
			this.m_BhName = null;
			this.m_TotalBigFileSize = 0;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000052FD File Offset: 0x000034FD
		public static void Regenerate(FifaBigFile bigFile, bool hideExternalFiles)
		{
			new BhFile(bigFile, hideExternalFiles).Save();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000530C File Offset: 0x0000350C
		public static void Regenerate(string bigFileName, bool hideExternalFiles)
		{
			FifaBigFile fifaBigFile = new FifaBigFile(bigFileName);
			if (fifaBigFile == null)
			{
				return;
			}
			fifaBigFile.LoadArchivedFiles();
			BhFile.Regenerate(fifaBigFile, hideExternalFiles);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005334 File Offset: 0x00003534
		public bool Save()
		{
			string bhName = this.m_BhName;
			if (this.m_BhName == null)
			{
				return false;
			}
			if (File.Exists(bhName) && (File.GetAttributes(bhName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(bhName, FileAttributes.Archive);
			}
			FileStream fileStream = new FileStream(bhName, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (this.m_NFiles == 0)
			{
				binaryWriter.Write(0);
			}
			else
			{
				binaryWriter.Write(86);
				binaryWriter.Write(105);
				binaryWriter.Write(86);
				binaryWriter.Write(52);
				binaryWriter.Write(this.m_TotalFileSize);
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_NFiles));
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_TotalFileSize));
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_BhFileReference[i].Save(binaryWriter);
				}
			}
			binaryWriter.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000540C File Offset: 0x0000360C
		private bool SaveEmptyReference(BinaryWriter w)
		{
			for (int i = 0; i < 4; i++)
			{
				w.Write(0);
			}
			return true;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005430 File Offset: 0x00003630
		public int GetArchivedFileIndex(ulong hash)
		{
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (this.m_BhFileReference[i].Hash == hash)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005464 File Offset: 0x00003664
		public int GetArchivedFileIndex(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			return this.GetArchivedFileIndex(num);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000547F File Offset: 0x0000367F
		public ulong GetHash(int fileIndex)
		{
			if (fileIndex < this.m_NFiles)
			{
				return this.m_BhFileReference[fileIndex].Hash;
			}
			return 0UL;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000549C File Offset: 0x0000369C
		public bool IsArchivedFilePresent(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			return this.GetArchivedFileIndex(num) >= 0;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000054BD File Offset: 0x000036BD
		public bool IsArchivedFilePresent(ulong hash)
		{
			return this.GetArchivedFileIndex(hash) >= 0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000054CC File Offset: 0x000036CC
		public bool Delete(int index)
		{
			if (index >= this.m_NFiles)
			{
				return false;
			}
			this.m_NFiles--;
			for (int i = index; i < this.m_NFiles; i++)
			{
				this.m_BhFileReference[i] = this.m_BhFileReference[i + 1];
			}
			this.m_TotalFileSize -= 20;
			return true;
		}

		// Token: 0x0400002F RID: 47
		private int m_TotalFileSize;

		// Token: 0x04000030 RID: 48
		private int m_NFiles;

		// Token: 0x04000031 RID: 49
		private BhFileReference[] m_BhFileReference;

		// Token: 0x04000032 RID: 50
		private string m_BhName;

		// Token: 0x04000033 RID: 51
		private int m_TotalBigFileSize;
	}
}
