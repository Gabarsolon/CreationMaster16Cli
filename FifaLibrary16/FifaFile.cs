using System;
using System.Diagnostics;
using System.IO;
using zlib;

namespace FifaLibrary
{
	// Token: 0x0200001F RID: 31
	public class FifaFile
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000575A File Offset: 0x0000395A
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00005762 File Offset: 0x00003962
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000575A File Offset: 0x0000395A
		public override string ToString()
		{
			return this.m_Name;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000576B File Offset: 0x0000396B
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00005773 File Offset: 0x00003973
		public string PhysicalName
		{
			get
			{
				return this.m_PhysicalName;
			}
			set
			{
				this.m_PhysicalName = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000577C File Offset: 0x0000397C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00005784 File Offset: 0x00003984
		public uint StartPosition
		{
			get
			{
				return this.m_StartPosition;
			}
			set
			{
				this.m_StartPosition = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000578D File Offset: 0x0000398D
		public int CompressedSize
		{
			get
			{
				return this.m_CompressedSize;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00005795 File Offset: 0x00003995
		public int UncompressedSize
		{
			get
			{
				return this.m_UncompressedSize;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000579D File Offset: 0x0000399D
		public int BlockInflatedSize
		{
			get
			{
				return this.m_MaxBlockUncompressedSize;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000057A5 File Offset: 0x000039A5
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000057AD File Offset: 0x000039AD
		public ECompressionMode CompressionMode
		{
			get
			{
				return this.m_RequiredCompression;
			}
			set
			{
				this.m_RequiredCompression = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000057B6 File Offset: 0x000039B6
		public bool IsToCompress
		{
			get
			{
				return this.m_RequiredCompression > ECompressionMode.None;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000057C1 File Offset: 0x000039C1
		public bool IsCompressed
		{
			get
			{
				return this.m_CurrentCompression > ECompressionMode.None;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000057CC File Offset: 0x000039CC
		public bool IsArchived
		{
			get
			{
				return this.m_IsArchived;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000057D4 File Offset: 0x000039D4
		public FifaBigFile Archive
		{
			get
			{
				return this.m_Archive;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000057DC File Offset: 0x000039DC
		public bool IsInMemory
		{
			get
			{
				return this.m_IsInMemory;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000057E4 File Offset: 0x000039E4
		public bool IsAnArchive
		{
			get
			{
				return this.m_IsAnArchive;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000057EC File Offset: 0x000039EC
		public FifaFile(FifaBigFile archive, byte[] buffer, string name, ECompressionMode compressionMode)
		{
			this.Load(archive, buffer, name, compressionMode);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005800 File Offset: 0x00003A00
		private void Load(FifaBigFile archive, byte[] buffer, string name, ECompressionMode compressionMode)
		{
			this.m_Archive = archive;
			this.m_IsArchived = false;
			this.m_IsInMemory = true;
			this.m_ReadMemoryStream = new MemoryStream(buffer);
			this.m_PhysicalName = null;
			this.m_StartPosition = 0U;
			this.m_Name = name;
			string extension = Path.GetExtension(name);
			extension.ToLower();
			if (extension == ".big")
			{
				this.m_IsAnArchive = true;
			}
			else
			{
				this.m_IsAnArchive = false;
			}
			this.m_RequiredCompression = compressionMode;
			this.m_CurrentCompression = ECompressionMode.None;
			this.m_UncompressedSize = buffer.Length;
			if (this.IsToCompress)
			{
				this.m_CompressedSize = -1;
				return;
			}
			this.m_CompressedSize = this.m_UncompressedSize;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000058A0 File Offset: 0x00003AA0
		public FifaFile(FifaFile fifaFile)
		{
			this.Load(fifaFile);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000058B0 File Offset: 0x00003AB0
		private void Load(FifaFile fifaFile)
		{
			this.m_Name = fifaFile.Name;
			this.m_Archive = fifaFile.Archive;
			this.m_IsArchived = fifaFile.IsArchived;
			this.m_IsInMemory = fifaFile.IsInMemory;
			this.m_PhysicalName = fifaFile.PhysicalName;
			this.m_StartPosition = fifaFile.StartPosition;
			this.m_IsAnArchive = true;
			this.m_RequiredCompression = fifaFile.m_RequiredCompression;
			this.m_CurrentCompression = fifaFile.m_CurrentCompression;
			this.m_CompressedSize = fifaFile.CompressedSize;
			this.m_UncompressedSize = fifaFile.UncompressedSize;
			this.m_ReadMemoryStream = fifaFile.m_ReadMemoryStream;
			this.m_WriteMemoryStream = fifaFile.m_WriteMemoryStream;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005954 File Offset: 0x00003B54
		public FifaFile(string path, bool isAnArchive)
		{
			this.Load(path, isAnArchive);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005964 File Offset: 0x00003B64
		private void Load(string path, bool isAnArchive)
		{
			this.m_Archive = null;
			this.m_IsArchived = false;
			this.m_IsInMemory = false;
			this.m_PhysicalName = path;
			this.m_StartPosition = 0U;
			this.m_Name = Path.GetFileName(path);
			this.m_IsAnArchive = isAnArchive;
			BinaryReader reader = this.GetReader();
			if (reader == null)
			{
				return;
			}
			int num = (int)reader.BaseStream.Length;
			this.m_CompressedSize = (this.m_UncompressedSize = num);
			this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.None);
			this.CheckCompressionMode(reader);
			this.ReleaseReader(reader);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000059EE File Offset: 0x00003BEE
		public FifaFile(FifaFileHeader header, BinaryReader r)
		{
			this.Load(header.BigFile, header.StartPosition, header.Size, header.Name, false, r);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005A18 File Offset: 0x00003C18
		private void Load(FifaBigFile archive, uint startPosition, int size, string name, bool isAnArchive, BinaryReader r)
		{
			this.m_Name = name;
			this.m_Archive = archive;
			this.m_IsArchived = true;
			this.m_IsInMemory = archive.IsInMemory;
			this.m_PhysicalName = this.m_Archive.PhysicalName;
			this.m_StartPosition = startPosition;
			this.m_IsAnArchive = isAnArchive;
			this.m_UncompressedSize = size;
			this.m_CompressedSize = size;
			this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.Unknown);
			if (size == 0)
			{
				this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.None);
				return;
			}
			if (r == null)
			{
				r = this.m_Archive.GetReader();
				r.BaseStream.Position += (long)((ulong)startPosition);
				this.CheckCompressionMode(r);
				this.ReleaseReader(r);
				return;
			}
			if (this.m_Archive != null)
			{
				r.BaseStream.Position = (long)((ulong)(this.m_Archive.StartPosition + startPosition));
			}
			else
			{
				r.BaseStream.Position = (long)((ulong)startPosition);
			}
			this.CheckCompressionMode(r);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005B10 File Offset: 0x00003D10
		public void Save(Stream outputStream)
		{
			long position = outputStream.Position;
			if (this.IsToCompress && !this.IsCompressed)
			{
				this.Compress(outputStream);
			}
			else if (!this.IsToCompress && this.IsCompressed)
			{
				this.Decompress(outputStream);
			}
			else
			{
				BinaryReader reader = this.GetReader();
				int i = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
				int num = 1048576;
				while (i > num)
				{
					outputStream.Write(reader.ReadBytes(num), 0, num);
					i -= num;
				}
				outputStream.Write(reader.ReadBytes(i), 0, i);
				this.ReleaseReader(reader);
			}
			if (this.m_Archive != null)
			{
				this.m_PhysicalName = this.m_Archive.PhysicalName;
				this.m_IsArchived = true;
			}
			this.m_StartPosition = (uint)position;
			this.m_ReadMemoryStream = null;
			this.m_WriteMemoryStream = null;
			this.m_IsInMemory = false;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public void Save(BinaryWriter w)
		{
			Stream baseStream = w.BaseStream;
			this.Save(baseStream);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005C04 File Offset: 0x00003E04
		private ECompressionMode CheckCompressionMode(BinaryReader r)
		{
			if (r.BaseStream.Length < 8L)
			{
				return ECompressionMode.None;
			}
			long position = r.BaseStream.Position;
			byte[] array = r.ReadBytes(8);
			if (array[0] == 16 && array[1] == 251)
			{
				this.m_CurrentCompression = ECompressionMode.Compressed_10FB;
				this.m_RequiredCompression = this.m_CurrentCompression;
				this.m_UncompressedSize = ((int)array[2] << 16) + ((int)array[3] << 8) + (int)array[4];
			}
			else
			{
				char[] array2 = new char[8];
				for (int i = 0; i < 8; i++)
				{
					array2[i] = (char)array[i];
				}
				string text = new string(array2);
				if (text.StartsWith("EASF"))
				{
					this.m_CompressedSize = ((int)array[4] << 24) + ((int)array[5] << 16) + ((int)array[6] << 8) + (int)array[7];
					r.ReadBytes(8);
					this.m_CurrentCompression = ECompressionMode.EASF;
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
				else if (text == "chunkzip")
				{
					this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
					this.m_CurrentCompression = ECompressionMode.Chunkzip;
					if (this.m_UncompressedSize == 2)
					{
						this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						this.m_CurrentCompression = ECompressionMode.Chunkzip2;
						this.m_RequiredCompression = this.m_CurrentCompression;
					}
					else
					{
						this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						this.m_RequiredCompression = this.m_CurrentCompression;
					}
				}
				else if (text == "chunkref")
				{
					this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
					if (this.m_UncompressedSize == 2)
					{
						this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						this.m_CurrentCompression = ECompressionMode.Chunkref2;
					}
					else
					{
						FifaUtil.SwapEndian(r.ReadInt32());
						FifaUtil.SwapEndian(r.ReadInt32());
						array = r.ReadBytes(8);
						if (array[0] == 16 && array[1] == 251)
						{
							this.m_CurrentCompression = ECompressionMode.Chunkref;
							this.m_RequiredCompression = this.m_CurrentCompression;
							this.m_UncompressedSize = ((int)array[2] << 16) + ((int)array[3] << 8) + (int)array[4];
						}
						else
						{
							this.m_CurrentCompression = ECompressionMode.Unknown;
						}
					}
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
				else if (text == "chunlzma")
				{
					this.m_CurrentCompression = ECompressionMode.Chunklzma;
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
				else
				{
					this.m_CurrentCompression = ECompressionMode.None;
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
			}
			r.BaseStream.Position = position;
			return this.m_CurrentCompression;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005EDC File Offset: 0x000040DC
		public bool IsDds()
		{
			if (Path.GetExtension(this.m_Name) == string.Empty)
			{
				BinaryReader reader = this.GetReader();
				if (this.CompressedSize >= 16)
				{
					byte[] array = reader.ReadBytes(16);
					if ((array[6] == 68 && array[7] == 68 && array[8] == 83) || (array[0] == 68 && array[1] == 68 && array[2] == 83))
					{
						return true;
					}
				}
				this.ReleaseReader(reader);
			}
			return false;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005F50 File Offset: 0x00004150
		public bool Decompress(Stream outputStream)
		{
			if (this.m_CurrentCompression == ECompressionMode.None || this.m_CurrentCompression == ECompressionMode.Unknown)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return false;
			}
			if (this.m_IsArchived)
			{
				this.m_Archive.Decompress();
			}
			switch (this.m_CurrentCompression)
			{
			case ECompressionMode.Compressed_10FB:
				this.Uncompress_10FB(outputStream);
				break;
			case ECompressionMode.Chunkzip:
				this.UnChunkzip(outputStream);
				break;
			case ECompressionMode.Chunkzip2:
				this.UnChunkZip2(outputStream);
				break;
			case ECompressionMode.Chunkref:
				this.UnChunkref(outputStream);
				break;
			case ECompressionMode.Chunkref2:
				this.UnChunkref2(outputStream);
				break;
			case ECompressionMode.EASF:
				this.UnEASF(outputStream);
				break;
			case ECompressionMode.Chunklzma:
				this.UnChunklzma(outputStream);
				break;
			}
			return true;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000600C File Offset: 0x0000420C
		public bool Decompress()
		{
			if (this.m_CurrentCompression == ECompressionMode.None)
			{
				return false;
			}
			this.m_ReadMemoryStream = new MemoryStream(this.m_UncompressedSize);
			bool flag = this.Decompress(this.m_ReadMemoryStream);
			if (flag)
			{
				this.m_CurrentCompression = ECompressionMode.None;
				this.m_IsArchived = false;
				this.m_IsInMemory = true;
				this.m_StartPosition = 0U;
			}
			return flag;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006060 File Offset: 0x00004260
		public bool Compress(Stream outputStream)
		{
			if (this.m_CurrentCompression != ECompressionMode.None)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return true;
			}
			if (this.m_CurrentCompression == this.m_RequiredCompression)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return true;
			}
			switch (this.m_RequiredCompression)
			{
			case ECompressionMode.Compressed_10FB:
				this.Compress_10FB(outputStream);
				break;
			case ECompressionMode.Chunkzip:
				this.Chunkzip(outputStream);
				break;
			case ECompressionMode.Chunkref:
				this.Chunkref(outputStream, this.m_UncompressedSize);
				break;
			}
			return true;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000060F4 File Offset: 0x000042F4
		public BinaryReader GetReader()
		{
			BinaryReader binaryReader = null;
			if (this.m_IsInMemory)
			{
				if (this.m_ReadMemoryStream != null)
				{
					binaryReader = new BinaryReader(this.m_ReadMemoryStream);
					binaryReader.BaseStream.Position = (long)((ulong)this.m_StartPosition);
				}
				else
				{
					if (this.m_Archive == null)
					{
						return null;
					}
					binaryReader = this.m_Archive.GetReader();
					binaryReader.BaseStream.Position = (long)((ulong)this.m_StartPosition);
				}
			}
			else if (File.Exists(this.m_PhysicalName))
			{
				binaryReader = new BinaryReader(new FileStream(this.m_PhysicalName, FileMode.Open, FileAccess.Read));
				binaryReader.BaseStream.Position = (long)((ulong)this.m_StartPosition);
				if (this.m_Archive != null)
				{
					binaryReader.BaseStream.Position += (long)((ulong)this.m_Archive.StartPosition);
				}
			}
			return binaryReader;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000061B9 File Offset: 0x000043B9
		public void ReleaseReader(BinaryReader r)
		{
			if (r != null && !this.m_IsInMemory)
			{
				r.BaseStream.Close();
				r.Close();
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000061D8 File Offset: 0x000043D8
		public StreamReader GetStreamReader()
		{
			if (this.m_ReadMemoryStream != null)
			{
				return new StreamReader(this.m_ReadMemoryStream);
			}
			StreamReader streamReader;
			if (this.m_Archive != null)
			{
				streamReader = this.m_Archive.GetStreamReader();
			}
			else
			{
				streamReader = new StreamReader(this.m_PhysicalName);
			}
			streamReader.BaseStream.Position += (long)((ulong)this.m_StartPosition);
			if (this.IsCompressed)
			{
				this.m_ReadMemoryStream = new MemoryStream();
				this.Decompress(this.m_ReadMemoryStream);
				this.m_ReadMemoryStream.Seek(0L, SeekOrigin.Begin);
				this.m_StartPosition = 0U;
				this.m_IsInMemory = true;
				return new StreamReader(this.m_ReadMemoryStream);
			}
			return streamReader;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000627E File Offset: 0x0000447E
		public void ReleaseStreamReader(StreamReader r)
		{
			if (!this.m_IsInMemory)
			{
				r.BaseStream.Close();
				r.Close();
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006299 File Offset: 0x00004499
		protected StreamWriter GetStreamWriter(ECompressionMode compressionMode)
		{
			this.m_WriteMemoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			this.m_CurrentCompression = compressionMode;
			return streamWriter;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000062C8 File Offset: 0x000044C8
		protected bool ReleaseStreamWriter(StreamWriter w)
		{
			w.Flush();
			this.m_CompressedSize = (this.m_UncompressedSize = (int)this.m_WriteMemoryStream.Length);
			if (this.m_IsInMemory)
			{
				if (!this.IsCompressed)
				{
					if (this.IsToCompress)
					{
						byte[] array = this.Compress_10FB(this.m_WriteMemoryStream.GetBuffer());
						if (array == null)
						{
							this.m_CurrentCompression = ECompressionMode.None;
							this.m_RequiredCompression = ECompressionMode.None;
							this.m_CompressedSize = this.m_UncompressedSize;
							return false;
						}
						this.m_RequiredCompression = ECompressionMode.Compressed_10FB;
						this.m_CompressedSize = array.Length;
					}
				}
				else if (!this.IsToCompress)
				{
					byte[] array2 = FifaFile.Uncompress_10FB(this.m_WriteMemoryStream.GetBuffer());
					if (array2 == null)
					{
						this.m_CurrentCompression = ECompressionMode.None;
						this.m_RequiredCompression = ECompressionMode.None;
						this.m_UncompressedSize = this.m_CompressedSize;
						return false;
					}
					this.m_RequiredCompression = ECompressionMode.None;
					this.m_UncompressedSize = array2.Length;
				}
				this.m_ReadMemoryStream = this.m_WriteMemoryStream;
				this.m_StartPosition = 0U;
			}
			else
			{
				w.Close();
				if (File.Exists(this.PhysicalName + ".tmp"))
				{
					File.Delete(this.PhysicalName);
					File.Move(this.PhysicalName + ".tmp", this.PhysicalName);
				}
			}
			return true;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000063F8 File Offset: 0x000045F8
		private byte[] Read()
		{
			BinaryReader reader = this.GetReader();
			int num = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
			byte[] array = reader.ReadBytes(num);
			this.ReleaseReader(reader);
			return array;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006434 File Offset: 0x00004634
		protected BinaryWriter GetWriter(int size, ECompressionMode compressionMode)
		{
			this.m_WriteMemoryStream = new MemoryStream(size);
			BinaryWriter binaryWriter = new BinaryWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			this.m_CurrentCompression = compressionMode;
			if (this.m_CurrentCompression != ECompressionMode.None)
			{
				this.m_CompressedSize = size;
				this.m_UncompressedSize = -1;
				return binaryWriter;
			}
			this.m_UncompressedSize = size;
			this.m_CompressedSize = -1;
			return binaryWriter;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006494 File Offset: 0x00004694
		public BinaryWriter GetWriter()
		{
			if (this.m_Archive == null && this.m_PhysicalName != null)
			{
				BinaryWriter binaryWriter = new BinaryWriter(new FileStream(this.m_PhysicalName + ".temp", FileMode.Create));
				this.m_IsInMemory = false;
				this.m_IsArchived = false;
				return binaryWriter;
			}
			this.m_WriteMemoryStream = new MemoryStream();
			BinaryWriter binaryWriter2 = new BinaryWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			return binaryWriter2;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006500 File Offset: 0x00004700
		public bool ReleaseWriter(BinaryWriter w)
		{
			if (this.m_IsInMemory)
			{
				if (!this.IsCompressed)
				{
					this.m_CompressedSize = -1;
					this.m_UncompressedSize = (int)this.m_WriteMemoryStream.Length;
				}
				else
				{
					this.m_UncompressedSize = -1;
					this.m_CompressedSize = (int)this.m_WriteMemoryStream.Length;
				}
				this.m_ReadMemoryStream = this.m_WriteMemoryStream;
				this.m_StartPosition = 0U;
			}
			else
			{
				w.Close();
				if ((File.GetAttributes(this.PhysicalName) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(this.PhysicalName, FileAttributes.Archive);
				}
				File.Delete(this.m_PhysicalName);
				File.Move(this.m_PhysicalName + ".temp", this.m_PhysicalName);
			}
			return true;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000065B0 File Offset: 0x000047B0
		public bool Export(string exportDir)
		{
			return this.Export(exportDir, true);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000065BC File Offset: 0x000047BC
		public bool Export(string exportDir, bool decompressionAllowed)
		{
			if (this.m_Name.StartsWith("C:"))
			{
				return false;
			}
			string text = exportDir + "\\" + this.m_Name;
			string directoryName = Path.GetDirectoryName(text);
			Path.GetExtension(text);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (this.IsCompressed && decompressionAllowed)
			{
				this.Decompress();
			}
			BinaryReader reader = this.GetReader();
			int num = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
			binaryWriter.Write(reader.ReadBytes(num));
			binaryWriter.Close();
			fileStream.Close();
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00006668 File Offset: 0x00004868
		public void Rename(string name)
		{
			this.m_Name = name;
			if (this.Archive == null)
			{
				string text = Path.GetDirectoryName(this.m_PhysicalName) + "\\" + name;
				File.Move(this.m_PhysicalName, text);
				this.m_PhysicalName = text;
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000066AE File Offset: 0x000048AE
		public bool SetCompressionMode(ECompressionMode compressionMode)
		{
			if (this.m_CurrentCompression == compressionMode)
			{
				return true;
			}
			if (this.m_CurrentCompression != ECompressionMode.None && compressionMode != ECompressionMode.None)
			{
				return false;
			}
			if (this.m_CurrentCompression == ECompressionMode.None && compressionMode != ECompressionMode.None)
			{
				this.m_RequiredCompression = compressionMode;
				this.m_CompressedSize = -1;
				return true;
			}
			return false;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000066E4 File Offset: 0x000048E4
		private bool Uncompress_10FB(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			byte[] array = FifaFile.Uncompress_10FB(this.Read());
			if (array != null)
			{
				outputStream.Write(array, 0, this.m_UncompressedSize);
				this.m_UncompressedSize = array.Length;
				return true;
			}
			return false;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00006728 File Offset: 0x00004928
		private bool UnChunkref(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			if (new string(reader.ReadChars(8)) != "chunkref")
			{
				return false;
			}
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			int num = 20;
			do
			{
				int num2 = FifaUtil.SwapEndian(reader.ReadInt32());
				num += 4 + num2;
				byte[] array = FifaFile.Uncompress_10FB(reader.ReadBytes(num2));
				outputStream.Write(array, 0, array.Length);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000067BC File Offset: 0x000049BC
		private bool UnChunkref2(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			if (new string(reader.ReadChars(8)) != "chunkref")
			{
				return false;
			}
			reader.ReadInt32();
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			int num = FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			byte[] array = FifaFile.Uncompress_10FB(reader.ReadBytes(num));
			outputStream.Write(array, 0, array.Length);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000686C File Offset: 0x00004A6C
		private bool UnChunkZip2(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			if (new string(reader.ReadChars(8)) != "chunkzip")
			{
				return false;
			}
			reader.ReadInt32();
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			int num = 40;
			do
			{
				num += 8;
				int num2 = FifaUtil.RoundUp(num, 16) - num;
				if (num2 > 0)
				{
					reader.ReadBytes(num2);
					num += num2;
				}
				int num3 = FifaUtil.SwapEndian(reader.ReadInt32());
				reader.ReadInt32();
				num += num3;
				this.InflateBlock2(reader.BaseStream, outputStream, num3);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006954 File Offset: 0x00004B54
		private bool UnChunkzip(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			if (new string(reader.ReadChars(8)) != "chunkzip")
			{
				return false;
			}
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			int num = 16;
			do
			{
				int num2 = FifaUtil.SwapEndian(reader.ReadInt32());
				num += 4 + num2;
				this.InflateBlock(reader.BaseStream, outputStream, num2);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000069E4 File Offset: 0x00004BE4
		private bool UnEASF(Stream outputStream)
		{
			this.Export(FifaEnvironment.ExportFolder, false);
			string text = FifaEnvironment.ExportFolder + "\\" + this.Name;
			text = text.Replace("/", "\\");
			if (!File.Exists(text))
			{
				return false;
			}
			if (text != null)
			{
				FifaFile.s_ProcessUnEASF.StartInfo.WorkingDirectory = FifaEnvironment.LaunchDir;
				FifaFile.s_ProcessUnEASF.StartInfo.FileName = "fifa16_decryptor";
				FifaFile.s_ProcessUnEASF.StartInfo.CreateNoWindow = true;
				FifaFile.s_ProcessUnEASF.StartInfo.UseShellExecute = false;
				FifaFile.s_ProcessUnEASF.StartInfo.Arguments = "\"" + text + "\"";
				FifaFile.s_ProcessUnEASF.StartInfo.RedirectStandardOutput = false;
				FifaFile.s_ProcessUnEASF.Start();
				FifaFile.s_ProcessUnEASF.WaitForExit();
			}
			string text2 = Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(text);
			text2 = text2 + "_decrypted" + Path.GetExtension(text);
			if (!File.Exists(text2))
			{
				return false;
			}
			File.Delete(text);
			File.Move(text2, text);
			FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
			int num = (int)new FileInfo(text).Length;
			byte[] array = new byte[num];
			fileStream.Read(array, 0, num);
			outputStream.Write(array, 0, num);
			fileStream.Close();
			return true;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006B38 File Offset: 0x00004D38
		private bool UnChunklzma(Stream outputStream)
		{
			this.Export(FifaEnvironment.ExportFolder, false);
			string text = FifaEnvironment.ExportFolder + "\\" + this.Name;
			if (!File.Exists(text))
			{
				return false;
			}
			if (text != null)
			{
				FifaFile.s_ProcessUnchunklzma.StartInfo.WorkingDirectory = FifaEnvironment.LaunchDir;
				FifaFile.s_ProcessUnchunklzma.StartInfo.FileName = "un_chunlzma";
				FifaFile.s_ProcessUnchunklzma.StartInfo.CreateNoWindow = true;
				FifaFile.s_ProcessUnchunklzma.StartInfo.UseShellExecute = false;
				FifaFile.s_ProcessUnchunklzma.StartInfo.Arguments = text;
				FifaFile.s_ProcessUnchunklzma.StartInfo.RedirectStandardOutput = false;
				FifaFile.s_ProcessUnchunklzma.Start();
				FifaFile.s_ProcessUnchunklzma.WaitForExit();
			}
			string text2 = Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(text);
			text2 = text2 + "_decompressed" + Path.GetExtension(text);
			if (!File.Exists(text2))
			{
				return false;
			}
			File.Delete(text);
			File.Move(text2, text);
			FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
			int num = (int)new FileInfo(text).Length;
			this.m_UncompressedSize = num;
			byte[] array = new byte[num];
			fileStream.Read(array, 0, num);
			outputStream.Write(array, 0, num);
			fileStream.Close();
			File.Delete(text2);
			return true;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006C74 File Offset: 0x00004E74
		private void Compress_10FB(Stream outputStream)
		{
			byte[] array = this.Read();
			byte[] array2 = this.Compress_10FB(array);
			this.m_CompressedSize = array2.Length;
			this.m_CurrentCompression = ECompressionMode.Compressed_10FB;
			outputStream.Write(array2, 0, array2.Length);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006CAB File Offset: 0x00004EAB
		private void Chunkzip(Stream outputStream)
		{
			this.Chunkzip(outputStream, this.m_UncompressedSize);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006CBC File Offset: 0x00004EBC
		private void Chunkzip(Stream outputStream, int uncompressedSize)
		{
			BinaryReader reader = this.GetReader();
			this.m_UncompressedSize = uncompressedSize;
			this.m_MaxBlockUncompressedSize = 184320;
			BinaryWriter binaryWriter = new BinaryWriter(outputStream);
			long position = outputStream.Position;
			binaryWriter.Write('c');
			binaryWriter.Write('h');
			binaryWriter.Write('u');
			binaryWriter.Write('n');
			binaryWriter.Write('k');
			binaryWriter.Write('z');
			binaryWriter.Write('i');
			binaryWriter.Write('p');
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_MaxBlockUncompressedSize));
			int num = 0;
			do
			{
				int num2 = (int)outputStream.Position;
				binaryWriter.Write(-1);
				int num3 = this.m_MaxBlockUncompressedSize;
				if (this.m_UncompressedSize - num < this.m_MaxBlockUncompressedSize)
				{
					num3 = this.m_UncompressedSize - num;
				}
				num += num3;
				int num4 = this.DeflateBlock(reader.BaseStream, outputStream, num3);
				int num5 = (int)outputStream.Position;
				outputStream.Position = (long)num2;
				binaryWriter.Write(FifaUtil.SwapEndian(num4));
				outputStream.Position = (long)num5;
			}
			while (num < this.m_UncompressedSize);
			this.ReleaseReader(reader);
			this.m_CompressedSize = (int)(outputStream.Position - position);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006DE3 File Offset: 0x00004FE3
		private void Chunkref2(Stream outputStream, int uncompressedSize)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006DE5 File Offset: 0x00004FE5
		private void Chunkref(Stream outputStream)
		{
			this.Chunkref(outputStream, this.m_UncompressedSize);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006DF4 File Offset: 0x00004FF4
		private void Chunkref(Stream outputStream, int uncompressedSize)
		{
			BinaryReader reader = this.GetReader();
			BinaryWriter binaryWriter = new BinaryWriter(outputStream);
			this.m_UncompressedSize = uncompressedSize;
			this.m_MaxBlockUncompressedSize = 235520;
			long position = outputStream.Position;
			binaryWriter.Write('c');
			binaryWriter.Write('h');
			binaryWriter.Write('u');
			binaryWriter.Write('n');
			binaryWriter.Write('k');
			binaryWriter.Write('r');
			binaryWriter.Write('e');
			binaryWriter.Write('f');
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_MaxBlockUncompressedSize));
			int num = 0;
			do
			{
				int num2 = (int)outputStream.Position;
				binaryWriter.Write(-1);
				int num3 = this.m_MaxBlockUncompressedSize;
				if (this.m_UncompressedSize - num < this.m_MaxBlockUncompressedSize)
				{
					num3 = this.m_UncompressedSize - num;
				}
				num += num3;
				byte[] array = reader.ReadBytes(num3);
				byte[] array2 = this.Compress_10FB(array);
				int num4 = array2.Length;
				outputStream.Write(array2, 0, num4);
				long position2 = outputStream.Position;
				outputStream.Position = (long)num2;
				binaryWriter.Write(FifaUtil.SwapEndian(num4));
				outputStream.Position = position2;
			}
			while (num < this.m_UncompressedSize);
			this.ReleaseReader(reader);
			this.m_CompressedSize = (int)(outputStream.Position - position);
			this.m_CurrentCompression = ECompressionMode.Chunkref;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006F38 File Offset: 0x00005138
		private void InflateBlock(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream);
			try
			{
				FifaFile.CopyStream(inputStream, zoutputStream, blockCompressedSize);
			}
			finally
			{
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00006F68 File Offset: 0x00005168
		private void InflateBlock2(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream);
			try
			{
				FifaFile.CopyStream2(inputStream, zoutputStream, blockCompressedSize);
			}
			finally
			{
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00006F98 File Offset: 0x00005198
		private int DeflateBlock(Stream inputStream, Stream outputStream, int blockUncompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream, -1);
			long position = outputStream.Position;
			try
			{
				FifaFile.CopyStream(inputStream, zoutputStream, blockUncompressedSize);
			}
			finally
			{
			}
			return (int)(outputStream.Position - position);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00006FD8 File Offset: 0x000051D8
		private int Uncompress_10FB_Block(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			if (blockCompressedSize == 0)
			{
				return 0;
			}
			byte[] array = new byte[blockCompressedSize];
			inputStream.Read(array, 0, blockCompressedSize);
			byte[] array2 = FifaFile.Uncompress_10FB(array);
			outputStream.Write(array2, 0, array2.Length);
			return array2.Length;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007010 File Offset: 0x00005210
		private int Compress_10FB_Block(Stream inputStream, Stream outputStream, int blockUncompressedSize)
		{
			if (blockUncompressedSize == 0)
			{
				return 0;
			}
			byte[] array = new byte[blockUncompressedSize];
			inputStream.Read(array, 0, blockUncompressedSize);
			byte[] array2 = this.Compress_10FB(array);
			outputStream.Write(array2, 0, array2.Length);
			return array2.Length;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000704C File Offset: 0x0000524C
		private static byte[] Uncompress_10FB(byte[] inputBuffer)
		{
			int num = 0;
			int num2 = 0;
			int num3 = inputBuffer.Length;
			if (num3 < 8)
			{
				return null;
			}
			int num4 = ((int)inputBuffer[2] << 16) + ((int)inputBuffer[3] << 8) + (int)inputBuffer[4];
			if (num4 > num3 * 128)
			{
				return null;
			}
			byte[] array = new byte[num4];
			int num5;
			if ((inputBuffer[0] & 1) == 1)
			{
				num5 = 8;
			}
			else
			{
				num5 = 5;
			}
			int num6 = 0;
			while (num5 < num3 && inputBuffer[num5] < 252)
			{
				byte b = inputBuffer[num5++];
				int num7;
				int num8;
				if ((b & 128) == 0)
				{
					if (num5 + 1 >= num3)
					{
						num2 = 3;
						break;
					}
					num7 = (int)(b & 3);
					num8 = ((b & 28) >> 2) + 3;
					num = (b >> 5 << 8) + (int)inputBuffer[num5++] + 1;
				}
				else if ((b & 64) == 0)
				{
					if (num5 + 2 >= num3)
					{
						num2 = 4;
						break;
					}
					byte b2 = inputBuffer[num5++];
					num7 = (b2 >> 6) & 3;
					num8 = (int)((b & 63) + 4);
					num = (int)(b2 & 63) * 256 + (int)inputBuffer[num5++] + 1;
				}
				else if ((b & 32) == 0)
				{
					if (num5 + 3 >= num3)
					{
						num2 = 5;
						break;
					}
					num7 = (int)(b & 3);
					byte b3 = inputBuffer[num5++];
					num = ((int)(b & 16) << 12) + 256 * (int)b3 + (int)inputBuffer[num5++] + 1;
					num8 = ((b >> 2) & 3) * 256 + (int)inputBuffer[num5++] + 5;
				}
				else
				{
					num7 = (int)((b & 31) * 4 + 4);
					num8 = 0;
				}
				if (num5 + num7 >= num3)
				{
					num2 = 6;
					break;
				}
				if (num6 + num7 + num8 > num4)
				{
					num2 = 7;
					break;
				}
				if (num6 + num7 - num < 0)
				{
					num2 = 8;
					break;
				}
				for (int i = 0; i < num7; i++)
				{
					array[num6++] = inputBuffer[num5++];
				}
				for (int j = 0; j < num8; j++)
				{
					array[num6] = array[num6 - num];
					num6++;
				}
			}
			if (num5 < num3 && num6 < num4)
			{
				int num9 = (int)(inputBuffer[num5] & 3);
				if (num5 + num9 >= num3)
				{
					num2 = 9;
					num9 = 0;
				}
				if (num6 + num9 > num4)
				{
					num2 = 10;
					num9 = 0;
				}
				for (int k = 0; k < num9; k++)
				{
					num5++;
					array[num6] = inputBuffer[num5];
					num6++;
				}
			}
			if (num2 != 0 || num6 != num4)
			{
				return null;
			}
			return array;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007290 File Offset: 0x00005490
		private byte[] Compress_10FB(byte[] inputBuffer)
		{
			int num = 0;
			int[] array = new int[131072];
			for (int i = 0; i < 131072; i++)
			{
				array[i] = -1;
			}
			int[,] array2 = new int[256, 256];
			for (int j = 0; j < 256; j++)
			{
				for (int k = 0; k < 256; k++)
				{
					array2[j, k] = -1;
				}
			}
			int num2 = inputBuffer.Length;
			byte[] array3 = new byte[num2 + 1000];
			array3[0] = 16;
			array3[1] = 251;
			array3[2] = (byte)(num2 >> 16);
			array3[3] = (byte)((num2 >> 8) & 255);
			array3[4] = (byte)(num2 & 255);
			int num3 = 5;
			int l = 0;
			int num4 = 0;
			int num9;
			while (l < num2 - 1)
			{
				byte b = inputBuffer[l];
				byte b2 = inputBuffer[l + 1];
				int num5 = array2[(int)b, (int)b2];
				array[l & 131071] = num5;
				array2[(int)b, (int)b2] = l;
				if (l >= num)
				{
					int num6 = 0;
					int num7 = 0;
					int num8 = 0;
					while (num5 >= 0 && l - num5 < 131072 && num8++ < 100)
					{
						num9 = 2;
						int num10 = num4 + 2;
						if (num10 >= num2)
						{
							break;
						}
						int num11 = num5 + 2;
						bool flag = false;
						while (inputBuffer[num10++] == inputBuffer[num11++] && num9 < 1028)
						{
							num9++;
							if (num10 == num2)
							{
								flag = true;
								break;
							}
						}
						if (num9 > num6)
						{
							num6 = num9;
							num7 = l - num5;
						}
						if (flag || num9 == 1028)
						{
							break;
						}
						num5 = array[num5 & 131071];
					}
					if (num6 > num2 - l)
					{
						num6 = l - num2;
					}
					if (num6 <= 2)
					{
						num6 = 0;
					}
					if (num6 == 3 && num7 > 1024)
					{
						num6 = 0;
					}
					if (num6 == 4 && num7 > 16384)
					{
						num6 = 0;
					}
					if (num6 != 0)
					{
						while (l - num >= 4)
						{
							num9 = (l - num) / 4 - 1;
							if (num9 > 27)
							{
								num9 = 27;
							}
							array3[num3++] = (byte)(224 + num9);
							num9 = 4 * num9 + 4;
							for (int m = 0; m < num9; m++)
							{
								array3[num3 + m] = inputBuffer[num + m];
							}
							num += num9;
							num3 += num9;
						}
						num9 = l - num;
						if (num6 <= 10 && num7 <= 1024)
						{
							array3[num3++] = (byte)((num7 - 1 >> 8 << 5) + (num6 - 3 << 2) + num9);
							array3[num3++] = (byte)((num7 - 1) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
						else if (num6 <= 67 && num7 <= 16384)
						{
							array3[num3++] = (byte)(128 + (num6 - 4));
							array3[num3++] = (byte)((num9 << 6) + (num7 - 1 >> 8));
							array3[num3++] = (byte)((num7 - 1) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
						else if (num6 <= 1028 && num7 < 131072)
						{
							num7--;
							array3[num3++] = (byte)(192 + (num7 >> 16 << 4) + (num6 - 5 >> 8 << 2) + num9);
							array3[num3++] = (byte)((num7 >> 8) & 255);
							array3[num3++] = (byte)(num7 & 255);
							array3[num3++] = (byte)((num6 - 5) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
					}
				}
				l++;
				num4++;
			}
			l = num2;
			while (l - num >= 4)
			{
				num9 = (l - num) / 4 - 1;
				if (num9 > 27)
				{
					num9 = 27;
				}
				array3[num3++] = (byte)(224 + num9);
				num9 = 4 * num9 + 4;
				for (int n = 0; n < num9; n++)
				{
					array3[num3 + n] = inputBuffer[num + n];
				}
				num += num9;
				num3 += num9;
			}
			num9 = l - num;
			array3[num3++] = (byte)(252 + num9);
			while (num9-- != 0)
			{
				array3[num3++] = inputBuffer[num++];
			}
			if (num != num2)
			{
				return null;
			}
			byte[] array4 = new byte[num3];
			for (int num12 = 0; num12 < num3; num12++)
			{
				array4[num12] = array3[num12];
			}
			return array4;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007714 File Offset: 0x00005914
		private static void CopyStream(Stream inputStream, ZOutputStream outputStream, int size)
		{
			int num = 0;
			byte[] array = new byte[size + num];
			inputStream.Read(array, num, size);
			outputStream.Write(array, 0, size + num);
			outputStream.finish();
			outputStream.Flush();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007750 File Offset: 0x00005950
		private static void CopyStream2(Stream inputStream, ZOutputStream outputStream, int size)
		{
			int num = 2;
			byte[] array = new byte[size + num];
			array[0] = 120;
			array[1] = 218;
			inputStream.Read(array, num, size);
			outputStream.Write(array, 0, size + num);
			outputStream.Flush();
		}

		// Token: 0x04000046 RID: 70
		private static Process s_ProcessUnchunklzma = new Process();

		// Token: 0x04000047 RID: 71
		private static Process s_ProcessUnEASF = new Process();

		// Token: 0x04000048 RID: 72
		private string m_Name;

		// Token: 0x04000049 RID: 73
		private string m_PhysicalName;

		// Token: 0x0400004A RID: 74
		private uint m_StartPosition;

		// Token: 0x0400004B RID: 75
		private MemoryStream m_ReadMemoryStream;

		// Token: 0x0400004C RID: 76
		private MemoryStream m_WriteMemoryStream;

		// Token: 0x0400004D RID: 77
		private int m_CompressedSize;

		// Token: 0x0400004E RID: 78
		private int m_UncompressedSize;

		// Token: 0x0400004F RID: 79
		private int m_MaxBlockUncompressedSize;

		// Token: 0x04000050 RID: 80
		private ECompressionMode m_RequiredCompression;

		// Token: 0x04000051 RID: 81
		private ECompressionMode m_CurrentCompression;

		// Token: 0x04000052 RID: 82
		private bool m_IsArchived;

		// Token: 0x04000053 RID: 83
		private FifaBigFile m_Archive;

		// Token: 0x04000054 RID: 84
		private bool m_IsInMemory;

		// Token: 0x04000055 RID: 85
		private bool m_IsAnArchive;
	}
}
