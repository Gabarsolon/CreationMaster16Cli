using System;
using System.Collections;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000020 RID: 32
	public class FifaBigFile : FifaFile
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000077A6 File Offset: 0x000059A6
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000077AE File Offset: 0x000059AE
		public FifaFileHeader[] Headers
		{
			get
			{
				return this.m_Headers;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000077B6 File Offset: 0x000059B6
		public FifaFile[] Files
		{
			get
			{
				return this.m_Files;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000077C0 File Offset: 0x000059C0
		private int EstimateAlignement()
		{
			int num = 256;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				int num2 = FifaUtil.ComputeAlignementLong((long)((ulong)this.m_Headers[i].StartPosition));
				if (num2 < num)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007800 File Offset: 0x00005A00
		public FifaBigFile(FifaFile fifaFile)
			: base(fifaFile)
		{
			if (base.IsCompressed)
			{
				base.Decompress();
			}
			BinaryReader reader = base.GetReader();
			this.Load(reader);
			base.ReleaseReader(reader);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007844 File Offset: 0x00005A44
		public FifaBigFile(string fileName)
			: base(fileName, true)
		{
			if (base.IsCompressed)
			{
				base.Decompress();
			}
			BinaryReader reader = base.GetReader();
			this.Load(reader);
			base.ReleaseReader(reader);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00007888 File Offset: 0x00005A88
		private bool Load(BinaryReader r)
		{
			if (r == null)
			{
				return false;
			}
			if (r.BaseStream.Length < 16L)
			{
				return false;
			}
			char[] array = r.ReadChars(4);
			if (array[0] != 'B' || array[1] != 'I' || array[2] != 'G' || (array[3] != 'F' && array[3] != '4'))
			{
				return false;
			}
			this.m_TotalFileSize = r.ReadInt32();
			this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_HeaderSize = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Headers = new FifaFileHeader[this.m_NFiles];
			this.m_Files = new FifaFile[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_Headers[i] = new FifaFileHeader(this);
				this.m_Headers[i].Load(r);
			}
			if (this.m_HeaderSize == (int)r.BaseStream.Position + 8)
			{
				this.m_EndSignature = r.ReadBytes(8);
			}
			this.m_Alignement = this.EstimateAlignement();
			return true;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007988 File Offset: 0x00005B88
		public bool LoadArchivedFiles()
		{
			BinaryReader reader = base.GetReader();
			this.m_Files = new FifaFile[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_Files[i] = new FifaFile(this.m_Headers[i], reader);
			}
			base.ReleaseReader(reader);
			return true;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000079DC File Offset: 0x00005BDC
		public bool LoadArchivedFile(int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			BinaryReader reader = base.GetReader();
			this.m_Files[fileIndex] = new FifaFile(this.m_Headers[fileIndex], reader);
			base.ReleaseReader(reader);
			return true;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007A20 File Offset: 0x00005C20
		public FifaFile[] GetArchivedFiles(string searchPattern, bool useFullPath)
		{
			bool[] array = new bool[this.m_NFiles];
			int num = 0;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				string text = this.m_Headers[i].Name;
				if (!useFullPath)
				{
					text = Path.GetFileName(text);
				}
				if (array[i] = FifaUtil.CompareWildcardString(searchPattern, text))
				{
					num++;
				}
			}
			FifaFile[] array2 = new FifaFile[num];
			if (num == 0)
			{
				return array2;
			}
			BinaryReader binaryReader = null;
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (array[j] && this.m_Files[j] == null)
				{
					binaryReader = base.GetReader();
					break;
				}
			}
			num = 0;
			for (int k = 0; k < this.m_NFiles; k++)
			{
				if (array[k])
				{
					if (this.m_Files[k] == null)
					{
						this.m_Files[k] = new FifaFile(this.m_Headers[k], binaryReader);
					}
					array2[num++] = this.m_Files[k];
				}
			}
			if (binaryReader != null)
			{
				base.ReleaseReader(binaryReader);
			}
			return array2;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00007B1C File Offset: 0x00005D1C
		public string[] GetArchivedFileNames(string searchPattern, bool useFullPath)
		{
			bool[] array = new bool[this.m_NFiles];
			int num = 0;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				string text = this.m_Headers[i].Name;
				if (!useFullPath)
				{
					text = Path.GetFileName(text);
				}
				if (array[i] = FifaUtil.CompareWildcardString(searchPattern, text))
				{
					num++;
				}
			}
			string[] array2 = new string[num];
			num = 0;
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (array[j])
				{
					array2[num++] = this.m_Headers[j].Name;
				}
			}
			return array2;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00007BB4 File Offset: 0x00005DB4
		public FifaFile GetArchivedFile(string fileName, bool useFullPath)
		{
			FifaFile[] archivedFiles = this.GetArchivedFiles(fileName, useFullPath);
			if (archivedFiles.Length == 0)
			{
				return null;
			}
			if (archivedFiles.Length > 1)
			{
				return null;
			}
			return archivedFiles[0];
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00007BDC File Offset: 0x00005DDC
		public int GetArchivedFileIndex(string fileName, bool useFullPath)
		{
			if (!useFullPath)
			{
				fileName = Path.GetFileName(fileName);
			}
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (FifaUtil.CompareWildcardString(fileName, this.m_Headers[i].Name))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007C20 File Offset: 0x00005E20
		public FifaFile GetArchivedFile(int fileIndex)
		{
			if (fileIndex >= 0 && fileIndex < this.NFiles)
			{
				if (this.m_Files[fileIndex] == null)
				{
					BinaryReader reader = base.GetReader();
					this.m_Files[fileIndex] = new FifaFile(this.m_Headers[fileIndex], reader);
					base.ReleaseReader(reader);
				}
				return this.m_Files[fileIndex];
			}
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007C74 File Offset: 0x00005E74
		public bool Export(string fileName, string exportDir)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileName, true);
			return archivedFile != null && archivedFile.UncompressedSize != 0 && archivedFile.Export(exportDir);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public bool Export(int fileIndex, string exportDir)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileIndex);
			return archivedFile != null && archivedFile.UncompressedSize != 0 && archivedFile.Export(exportDir);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00007CCC File Offset: 0x00005ECC
		public bool Export(string[] fileNames, string exportDir)
		{
			bool flag = false;
			if (fileNames.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < fileNames.Length; i++)
			{
				bool flag2 = this.Export(fileNames[i], exportDir);
				flag = flag || flag2;
			}
			return flag;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00007D00 File Offset: 0x00005F00
		public void ImportReplacingFile(string path, int fileIndex)
		{
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			fileStream.Close();
			binaryReader.Close();
			FifaFile archivedFile = this.GetArchivedFile(fileIndex);
			if (archivedFile.CompressionMode == ECompressionMode.Chunkzip2)
			{
				this.m_Files[fileIndex] = new FifaFile(this, array, archivedFile.Name, ECompressionMode.None);
				return;
			}
			this.m_Files[fileIndex] = new FifaFile(this, array, archivedFile.Name, archivedFile.CompressionMode);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00007D80 File Offset: 0x00005F80
		public int ImportNewFile(string path, ECompressionMode compressionMode)
		{
			string fileName = Path.GetFileName(path);
			return this.ImportNewFileAs(path, fileName, compressionMode);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00007DA0 File Offset: 0x00005FA0
		public int ImportNewFileAs(string path, string archivedName, ECompressionMode compressionMode)
		{
			if (this.m_Files == null || this.m_Files.Length <= this.m_NFiles + 1)
			{
				this.Resize(this.m_NFiles + 32);
			}
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			fileStream.Close();
			binaryReader.Close();
			this.m_Files[this.m_NFiles] = new FifaFile(this, array, archivedName, compressionMode);
			this.m_NFiles++;
			return this.m_NFiles - 1;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00007E30 File Offset: 0x00006030
		public void ImportFile(string path, ECompressionMode compressionMode)
		{
			string fileName = Path.GetFileName(path);
			int archivedFileIndex = this.GetArchivedFileIndex(fileName, true);
			if (archivedFileIndex != -1)
			{
				this.ImportReplacingFile(path, archivedFileIndex);
				return;
			}
			this.ImportNewFile(path, compressionMode);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00007E64 File Offset: 0x00006064
		public void ImportFileAs(string path, string archivedName, ECompressionMode compressionMode)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(archivedName, true);
			if (archivedFileIndex != -1)
			{
				this.ImportReplacingFile(path, archivedFileIndex);
				return;
			}
			this.ImportNewFileAs(path, archivedName, compressionMode);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00007E94 File Offset: 0x00006094
		public void Resize(int nFiles)
		{
			if (this.m_NFiles == 0)
			{
				this.m_Files = new FifaFile[nFiles];
				return;
			}
			int nfiles = this.m_NFiles;
			FifaFile[] array = (FifaFile[])this.m_Files.Clone();
			this.m_Files = new FifaFile[nFiles];
			if (nFiles < this.m_NFiles)
			{
				Array.Copy(array, 0, this.m_Files, 0, nFiles);
			}
			if (nFiles > this.m_NFiles)
			{
				Array.Copy(array, 0, this.m_Files, 0, this.m_NFiles);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00007F14 File Offset: 0x00006114
		private int ComputeHeaderSize()
		{
			int num = 16;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				num += this.m_Headers[i].Name.Length + 1;
				num += 8;
			}
			this.m_HeaderSize = num;
			if (this.m_EndSignature != null)
			{
				this.m_HeaderSize += this.m_EndSignature.Length;
			}
			return FifaUtil.RoundUp(num, this.m_Alignement);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007F84 File Offset: 0x00006184
		public void Save()
		{
			BinaryReader binaryReader = null;
			BinaryWriter binaryWriter;
			if (this.NFiles == 0)
			{
				binaryWriter = base.GetWriter();
				binaryWriter.Write(0);
			}
			else
			{
				binaryWriter = base.GetWriter();
				binaryReader = base.GetReader();
				this.ComputeHeaderSize();
				binaryWriter.BaseStream.Position = (long)this.m_HeaderSize;
				for (int i = 0; i < this.m_NFiles; i++)
				{
					if (this.m_Files[i] == null)
					{
						this.m_Files[i] = new FifaFile(this.m_Headers[i], binaryReader);
					}
					this.m_Headers[i].StartPosition = (uint)binaryWriter.BaseStream.Position;
					this.m_Headers[i].Name = this.m_Files[i].Name;
					this.m_Files[i].Save(binaryWriter);
					if (this.m_Files[i].IsToCompress)
					{
						this.m_Headers[i].Size = this.m_Files[i].CompressedSize;
					}
					else
					{
						this.m_Headers[i].Size = this.m_Files[i].UncompressedSize;
					}
					int num = (int)binaryWriter.BaseStream.Position;
					num = FifaUtil.RoundUp(num, this.m_Alignement);
					binaryWriter.BaseStream.Position = (long)num;
				}
				this.m_TotalFileSize = (int)binaryWriter.BaseStream.Position;
				binaryWriter.Seek(0, SeekOrigin.Begin);
				binaryWriter.Write('B');
				binaryWriter.Write('I');
				binaryWriter.Write('G');
				binaryWriter.Write('4');
				binaryWriter.Write(this.m_TotalFileSize);
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_NFiles));
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_HeaderSize));
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Headers[j].Save(binaryWriter);
				}
				if (this.m_EndSignature != null)
				{
					binaryWriter.Write(this.m_EndSignature);
				}
			}
			base.ReleaseReader(binaryReader);
			base.ReleaseWriter(binaryWriter);
			if (base.Archive == null)
			{
				if (base.IsInMemory)
				{
					if (File.Exists(base.PhysicalName) && (File.GetAttributes(base.PhysicalName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
					{
						File.SetAttributes(base.PhysicalName, FileAttributes.Archive);
					}
					FileStream fileStream = new FileStream(base.PhysicalName, FileMode.Create, FileAccess.Write);
					new BinaryWriter(fileStream);
					base.Save(fileStream);
					fileStream.Close();
					return;
				}
			}
			else
			{
				base.Archive.Save();
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000081DC File Offset: 0x000063DC
		public void Sort()
		{
			string[] array = new string[this.m_NFiles];
			string[] array2 = new string[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				array[i] = this.Files[i].Name;
				array2[i] = this.Files[i].Name;
			}
			Array.Sort(array, this.m_Files, FifaBigFile.s_StringComparer);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008244 File Offset: 0x00006444
		public bool Delete(int index)
		{
			if (index >= this.m_NFiles)
			{
				return false;
			}
			this.m_NFiles--;
			for (int i = index; i < this.m_NFiles; i++)
			{
				this.m_Files[i] = this.m_Files[i + 1];
			}
			for (int j = index; j < this.m_NFiles; j++)
			{
				this.m_Headers[j] = this.m_Headers[j + 1];
			}
			return true;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000082B4 File Offset: 0x000064B4
		public bool Delete(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName, true);
			return archivedFileIndex >= 0 && this.Delete(archivedFileIndex);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000082D8 File Offset: 0x000064D8
		public bool Delete(FifaFile fifaFile)
		{
			string name = fifaFile.Name;
			return this.Delete(name);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000082F4 File Offset: 0x000064F4
		public int Delete(string[] fileNames)
		{
			int num = 0;
			for (int i = 0; i < fileNames.Length; i++)
			{
				if (this.Delete(fileNames[i]))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008324 File Offset: 0x00006524
		public void Rename(string originalName, string newName)
		{
			FifaFile archivedFile = this.GetArchivedFile(originalName, true);
			if (archivedFile != null)
			{
				archivedFile.Rename(newName);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008344 File Offset: 0x00006544
		public FifaFile GetFirstDds()
		{
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (this.m_Files[i] == null)
				{
					this.LoadArchivedFiles();
					break;
				}
			}
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (this.m_Files[j].IsDds())
				{
					return this.m_Files[j];
				}
			}
			return null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000083A0 File Offset: 0x000065A0
		public FifaFile GetDdsByName(string fileNameWithoutExtension)
		{
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (this.m_Files[i] == null)
				{
					this.LoadArchivedFiles();
					break;
				}
			}
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (this.m_Files[j].IsDds() && this.m_Files[j].Name == fileNameWithoutExtension)
				{
					return this.m_Files[j];
				}
			}
			return null;
		}

		// Token: 0x04000056 RID: 86
		private int m_TotalFileSize;

		// Token: 0x04000057 RID: 87
		private int m_NFiles;

		// Token: 0x04000058 RID: 88
		private int m_HeaderSize;

		// Token: 0x04000059 RID: 89
		private FifaFileHeader[] m_Headers;

		// Token: 0x0400005A RID: 90
		private static FifaBigFile.StringComparer s_StringComparer = new FifaBigFile.StringComparer();

		// Token: 0x0400005B RID: 91
		private FifaFile[] m_Files;

		// Token: 0x0400005C RID: 92
		private byte[] m_EndSignature;

		// Token: 0x0400005D RID: 93
		private int m_Alignement = 16;

		// Token: 0x020000A7 RID: 167
		public class StringComparer : IComparer
		{
			// Token: 0x06000F56 RID: 3926 RVA: 0x0005C838 File Offset: 0x0005AA38
			int IComparer.Compare(object x, object y)
			{
				string text = (string)x;
				string text2 = (string)y;
				return string.Compare(text, text2, StringComparison.Ordinal);
			}
		}
	}
}
