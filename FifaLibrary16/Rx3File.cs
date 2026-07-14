using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000072 RID: 114
	public class Rx3File
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00039964 File Offset: 0x00037B64
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0003996C File Offset: 0x00037B6C
		public float[] Positions
		{
			get
			{
				return this.m_Positions;
			}
			set
			{
				this.m_Positions = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00039975 File Offset: 0x00037B75
		public Rx3Header Rx3Headers
		{
			get
			{
				return this.m_Rx3Header;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003997D File Offset: 0x00037B7D
		public bool SwapEndian
		{
			get
			{
				return this.m_SwapEndian;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00039985 File Offset: 0x00037B85
		public bool IsFifa12
		{
			get
			{
				return this.m_IsFifa12;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0003998D File Offset: 0x00037B8D
		public bool IsFifa11
		{
			get
			{
				return !this.m_IsFifa12;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00039998 File Offset: 0x00037B98
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000399A0 File Offset: 0x00037BA0
		public int HairAlfaFlag
		{
			get
			{
				return this.m_AlfaFlag;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x000399A8 File Offset: 0x00037BA8
		public Rx3FileDescriptor[] Rx3FileDescriptors
		{
			get
			{
				return this.m_Rx3FileDescriptors;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000399B0 File Offset: 0x00037BB0
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000399B8 File Offset: 0x00037BB8
		public Rx3Signatures Signatures
		{
			get
			{
				return this.m_Rx3Signatures;
			}
			set
			{
				this.m_Rx3Signatures = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000399C1 File Offset: 0x00037BC1
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000399C9 File Offset: 0x00037BC9
		public Rx3ImageDirectory Rx3ImageDirectory
		{
			get
			{
				return this.m_Rx3ImageDirectory;
			}
			set
			{
				this.m_Rx3ImageDirectory = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000399D2 File Offset: 0x00037BD2
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000399DA File Offset: 0x00037BDA
		public Rx3ModelDirectory Rx3ModelDirectory
		{
			get
			{
				return this.m_Rx3ModelDirectory;
			}
			set
			{
				this.m_Rx3ModelDirectory = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000399E3 File Offset: 0x00037BE3
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000399EB File Offset: 0x00037BEB
		public Rx3Image[] Images
		{
			get
			{
				return this.m_Rx3Images;
			}
			set
			{
				this.m_Rx3Images = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000399F4 File Offset: 0x00037BF4
		public Rx3IndexArray[] Rx3IndexArrays
		{
			get
			{
				return this.m_Rx3IndexArrays;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x000399FC File Offset: 0x00037BFC
		public Rx3VertexArray[] Rx3VertexArrays
		{
			get
			{
				return this.m_Rx3VertexArrays;
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00039A04 File Offset: 0x00037C04
		public bool Load(FifaFile fifaFile)
		{
			if (fifaFile.IsCompressed)
			{
				fifaFile.Decompress();
			}
			BinaryReader reader = fifaFile.GetReader();
			bool flag = this.Load(reader);
			fifaFile.ReleaseReader(reader);
			return flag;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00039A38 File Offset: 0x00037C38
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00039A74 File Offset: 0x00037C74
		public bool Save(string fileName, bool saveBitmaps, bool saveVertex)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter, saveBitmaps, saveVertex);
			fileStream.Close();
			binaryWriter.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00039AB0 File Offset: 0x00037CB0
		public virtual bool Load(BinaryReader r)
		{
			string text = new string(r.ReadChars(4));
			if (text == "RX3b")
			{
				this.m_IsFifa12 = true;
				this.m_SwapEndian = true;
				r.BaseStream.Position -= 4L;
			}
			else if (text == "RX3l")
			{
				this.m_IsFifa12 = true;
				this.m_SwapEndian = false;
				r.BaseStream.Position -= 4L;
			}
			else
			{
				this.m_IsFifa12 = false;
				this.m_SwapEndian = true;
				r.BaseStream.Position = 68L;
				this.m_Rx3bPosition = FifaUtil.SwapEndian(r.ReadInt32());
				r.BaseStream.Position = (long)this.m_Rx3bPosition;
			}
			this.m_Rx3Header = new Rx3Header(r, this.m_SwapEndian);
			if (this.m_Rx3Header.NFiles == 0)
			{
				return false;
			}
			this.m_Rx3FileDescriptors = new Rx3FileDescriptor[this.m_Rx3Header.NFiles];
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i] = new Rx3FileDescriptor(r, this.m_SwapEndian);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				r.BaseStream.Position = (long)this.m_Rx3FileDescriptors[j].Offset;
				uint signature = this.m_Rx3FileDescriptors[j].Signature;
				if (signature <= 685399266U)
				{
					if (signature <= 191347397U)
					{
						if (signature <= 5798561U)
						{
							if (signature != 5798132U)
							{
								if (signature != 5798561U)
								{
									return false;
								}
								this.m_Rx3VertexArrays[num3++] = new Rx3VertexArray(r, this.m_SwapEndian);
							}
							else
							{
								this.m_Rx3IndexArrays[num2++] = new Rx3IndexArray(r, this.m_SwapEndian);
							}
						}
						else if (signature != 123459928U && signature != 191347397U)
						{
							return false;
						}
					}
					else if (signature <= 255353250U)
					{
						if (signature != 230948820U && signature != 255353250U)
						{
							return false;
						}
					}
					else if (signature != 341785025U)
					{
						if (signature != 582139446U)
						{
							if (signature != 685399266U)
							{
								return false;
							}
						}
						else
						{
							this.m_Rx3ModelDirectory = new Rx3ModelDirectory(r, this.m_SwapEndian);
							this.m_Rx3IndexArrays = new Rx3IndexArray[this.m_Rx3ModelDirectory.NFiles];
							this.m_Rx3VertexArrays = new Rx3VertexArray[this.m_Rx3ModelDirectory.NFiles];
						}
					}
				}
				else if (signature <= 2116321516U)
				{
					if (signature <= 1285267122U)
					{
						if (signature != 899336811U)
						{
							if (signature != 1285267122U)
							{
								return false;
							}
							r.ReadBytes(20);
							this.m_AlfaFlag = (int)r.ReadByte();
						}
					}
					else if (signature != 1808827868U)
					{
						if (signature != 2047566042U)
						{
							if (signature != 2116321516U)
							{
								return false;
							}
						}
						else
						{
							this.m_Rx3Images[num] = new Rx3Image(r, this.m_SwapEndian);
							num++;
						}
					}
					else
					{
						this.m_Rx3ImageDirectory = new Rx3ImageDirectory(r, this.m_SwapEndian);
						this.m_Rx3Images = new Rx3Image[this.m_Rx3ImageDirectory.NFiles];
					}
				}
				else if (signature <= 3566041216U)
				{
					if (signature != 3263271920U && signature != 3566041216U)
					{
						return false;
					}
				}
				else if (signature != 3751472158U)
				{
					if (signature != 4116388378U)
					{
						if (signature != 4185470741U)
						{
							return false;
						}
					}
					else
					{
						this.LoadPositions(r);
					}
				}
			}
			return true;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00039E50 File Offset: 0x00038050
		private void LoadPositions(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				r.ReadBytes(29);
				this.m_Positions[0] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[1] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[2] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[3] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(11);
				this.m_Positions[4] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[5] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[6] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[7] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(12);
				this.m_Positions[8] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[9] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[10] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[11] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(5);
				this.m_Positions[12] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[13] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[14] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[15] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(15);
				this.m_Positions[16] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[17] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[18] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[19] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(16);
				this.m_Positions[20] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[21] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[22] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[23] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(13);
				this.m_Positions[24] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[25] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[26] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[27] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(7);
				this.m_Positions[28] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[29] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[30] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[31] = FifaUtil.SwapAndConvertToFloat(r);
				return;
			}
			r.ReadBytes(29);
			this.m_Positions[0] = r.ReadSingle();
			this.m_Positions[1] = r.ReadSingle();
			this.m_Positions[2] = r.ReadSingle();
			this.m_Positions[3] = r.ReadSingle();
			r.ReadBytes(11);
			this.m_Positions[4] = r.ReadSingle();
			this.m_Positions[5] = r.ReadSingle();
			this.m_Positions[6] = r.ReadSingle();
			this.m_Positions[7] = r.ReadSingle();
			r.ReadBytes(12);
			this.m_Positions[8] = r.ReadSingle();
			this.m_Positions[9] = r.ReadSingle();
			this.m_Positions[10] = r.ReadSingle();
			this.m_Positions[11] = r.ReadSingle();
			r.ReadBytes(5);
			this.m_Positions[12] = r.ReadSingle();
			this.m_Positions[13] = r.ReadSingle();
			this.m_Positions[14] = r.ReadSingle();
			this.m_Positions[15] = r.ReadSingle();
			r.ReadBytes(15);
			this.m_Positions[16] = r.ReadSingle();
			this.m_Positions[17] = r.ReadSingle();
			this.m_Positions[18] = r.ReadSingle();
			this.m_Positions[19] = r.ReadSingle();
			r.ReadBytes(16);
			this.m_Positions[20] = r.ReadSingle();
			this.m_Positions[21] = r.ReadSingle();
			this.m_Positions[22] = r.ReadSingle();
			this.m_Positions[23] = r.ReadSingle();
			r.ReadBytes(13);
			this.m_Positions[24] = r.ReadSingle();
			this.m_Positions[25] = r.ReadSingle();
			this.m_Positions[26] = r.ReadSingle();
			this.m_Positions[27] = r.ReadSingle();
			r.ReadBytes(7);
			this.m_Positions[28] = r.ReadSingle();
			this.m_Positions[29] = r.ReadSingle();
			this.m_Positions[30] = r.ReadSingle();
			this.m_Positions[31] = r.ReadSingle();
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0003A2A4 File Offset: 0x000384A4
		private void SavePositions(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Seek(29, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[0]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[1]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[2]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[3]);
				w.Seek(11, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[4]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[5]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[6]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[7]);
				w.Seek(12, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[8]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[9]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[10]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[11]);
				w.Seek(5, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[12]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[13]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[14]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[15]);
				w.Seek(15, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[16]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[17]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[18]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[19]);
				w.Seek(16, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[20]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[21]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[22]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[23]);
				w.Seek(13, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[24]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[25]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[26]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[27]);
				w.Seek(7, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[28]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[29]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[30]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[31]);
				return;
			}
			w.Seek(29, SeekOrigin.Current);
			w.Write(this.m_Positions[0]);
			w.Write(this.m_Positions[1]);
			w.Write(this.m_Positions[2]);
			w.Write(this.m_Positions[3]);
			w.Seek(11, SeekOrigin.Current);
			w.Write(this.m_Positions[4]);
			w.Write(this.m_Positions[5]);
			w.Write(this.m_Positions[6]);
			w.Write(this.m_Positions[7]);
			w.Seek(12, SeekOrigin.Current);
			w.Write(this.m_Positions[8]);
			w.Write(this.m_Positions[9]);
			w.Write(this.m_Positions[10]);
			w.Write(this.m_Positions[11]);
			w.Seek(5, SeekOrigin.Current);
			w.Write(this.m_Positions[12]);
			w.Write(this.m_Positions[13]);
			w.Write(this.m_Positions[14]);
			w.Write(this.m_Positions[15]);
			w.Seek(15, SeekOrigin.Current);
			w.Write(this.m_Positions[16]);
			w.Write(this.m_Positions[17]);
			w.Write(this.m_Positions[18]);
			w.Write(this.m_Positions[19]);
			w.Seek(16, SeekOrigin.Current);
			w.Write(this.m_Positions[20]);
			w.Write(this.m_Positions[21]);
			w.Write(this.m_Positions[22]);
			w.Write(this.m_Positions[23]);
			w.Seek(13, SeekOrigin.Current);
			w.Write(this.m_Positions[24]);
			w.Write(this.m_Positions[25]);
			w.Write(this.m_Positions[26]);
			w.Write(this.m_Positions[27]);
			w.Seek(7, SeekOrigin.Current);
			w.Write(this.m_Positions[28]);
			w.Write(this.m_Positions[29]);
			w.Write(this.m_Positions[30]);
			w.Write(this.m_Positions[31]);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0003A708 File Offset: 0x00038908
		public virtual bool Save(BinaryWriter w, bool saveBitmaps, bool saveVertex)
		{
			if (this.m_Rx3Signatures != null)
			{
				this.m_Rx3Signatures.Save(w);
			}
			w.BaseStream.Position = (long)this.m_Rx3bPosition;
			this.m_Rx3Header.Save(w);
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i].Save(w);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				w.BaseStream.Position = (long)this.m_Rx3FileDescriptors[j].Offset;
				uint signature = this.m_Rx3FileDescriptors[j].Signature;
				if (signature <= 255353250U)
				{
					if (signature != 5798132U)
					{
						if (signature != 5798561U)
						{
							if (signature != 255353250U)
							{
							}
						}
						else if (saveVertex)
						{
							this.m_Rx3VertexArrays[num2++].Save(w);
						}
					}
					else if (saveVertex)
					{
						this.m_Rx3IndexArrays[num3++].Save(w);
					}
				}
				else if (signature <= 1808827868U)
				{
					if (signature != 582139446U && signature != 1808827868U)
					{
					}
				}
				else if (signature != 2047566042U)
				{
					if (signature == 4116388378U)
					{
						this.SavePositions(w);
					}
				}
				else if (saveBitmaps)
				{
					this.m_Rx3Images[num].Save(w);
					num++;
				}
			}
			return true;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0003A86C File Offset: 0x00038A6C
		public Bitmap[] GetBitmaps()
		{
			Bitmap[] array = new Bitmap[this.m_Rx3Images.Length];
			for (int i = 0; i < this.m_Rx3Images.Length; i++)
			{
				array[i] = this.m_Rx3Images[i].GetBitmap();
			}
			return array;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0003A8AC File Offset: 0x00038AAC
		public bool ReplaceBitmaps(Bitmap[] bitmaps)
		{
			bool flag = true;
			int num = ((bitmaps.Length < this.m_Rx3Images.Length) ? bitmaps.Length : this.m_Rx3Images.Length);
			for (int i = 0; i < num; i++)
			{
				if (bitmaps[i] != null)
				{
					bool flag2 = this.m_Rx3Images[i].SetBitmap(bitmaps[i]);
					flag = flag && flag2;
				}
			}
			return flag;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0003A900 File Offset: 0x00038B00
		public bool CreateXFiles(string baseFileName)
		{
			if (this.m_Rx3IndexArrays.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < this.m_Rx3IndexArrays.Length; i++)
			{
				Model3D model3D = new Model3D();
				model3D.Initialize(this.m_Rx3IndexArrays[i], this.m_Rx3VertexArrays[i]);
				string text = baseFileName + i.ToString() + ".X";
				Application.CurrentCulture = new CultureInfo("en-us");
				FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.WriteLine("xof 0303txt 0032");
				model3D.SaveXFile(streamWriter);
				streamWriter.Close();
				fileStream.Close();
			}
			return true;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003A994 File Offset: 0x00038B94
		public bool ConvertKitFrom11(Rx3File sourceRx3File)
		{
			return !this.IsFifa11 && !sourceRx3File.IsFifa12;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0003A9AB File Offset: 0x00038BAB
		public bool ConvertKitFrom12(Rx3File sourceRx3File)
		{
			return !this.IsFifa12 && !sourceRx3File.IsFifa11;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0003A9C2 File Offset: 0x00038BC2
		public bool ConvertKit(Rx3File sourceRx3File)
		{
			if (this.IsFifa12)
			{
				return this.ConvertKitFrom11(sourceRx3File);
			}
			return this.ConvertKitFrom12(sourceRx3File);
		}

		// Token: 0x04000FAB RID: 4011
		private float[] m_Positions = new float[32];

		// Token: 0x04000FAC RID: 4012
		private int m_Rx3bPosition;

		// Token: 0x04000FAD RID: 4013
		private Rx3Header m_Rx3Header;

		// Token: 0x04000FAE RID: 4014
		private bool m_SwapEndian;

		// Token: 0x04000FAF RID: 4015
		private bool m_IsFifa12;

		// Token: 0x04000FB0 RID: 4016
		private string m_FileName;

		// Token: 0x04000FB1 RID: 4017
		private int m_AlfaFlag;

		// Token: 0x04000FB2 RID: 4018
		private Rx3FileDescriptor[] m_Rx3FileDescriptors;

		// Token: 0x04000FB3 RID: 4019
		private Rx3Signatures m_Rx3Signatures;

		// Token: 0x04000FB4 RID: 4020
		private Rx3ImageDirectory m_Rx3ImageDirectory;

		// Token: 0x04000FB5 RID: 4021
		private Rx3ModelDirectory m_Rx3ModelDirectory;

		// Token: 0x04000FB6 RID: 4022
		private Rx3Image[] m_Rx3Images;

		// Token: 0x04000FB7 RID: 4023
		private Rx3IndexArray[] m_Rx3IndexArrays;

		// Token: 0x04000FB8 RID: 4024
		private Rx3VertexArray[] m_Rx3VertexArrays;
	}
}
