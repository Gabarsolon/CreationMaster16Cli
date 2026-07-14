using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000071 RID: 113
	public class Rx3RawData
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003963E File Offset: 0x0003783E
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00039646 File Offset: 0x00037846
		public bool IsFifa14
		{
			get
			{
				return this.m_IsFifa14;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0003964E File Offset: 0x0003784E
		public byte[][] RawData
		{
			get
			{
				return this.m_RawData;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00039656 File Offset: 0x00037856
		public Rx3Header Rx3Headers
		{
			get
			{
				return this.m_Rx3Header;
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0003965E File Offset: 0x0003785E
		public Rx3RawData(string fileName)
		{
			this.m_FileName = fileName;
			this.Load(fileName);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00039675 File Offset: 0x00037875
		public Rx3FileDescriptor[] Rx3FileDescriptors
		{
			get
			{
				return this.m_Rx3FileDescriptors;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00039680 File Offset: 0x00037880
		public bool Load(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000396C4 File Offset: 0x000378C4
		public bool Load(BinaryReader r)
		{
			string text = new string(r.ReadChars(4));
			if (text == "Rx3l" || text == "RX3l")
			{
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_Rx3bPosition = 0;
				this.m_SwapEndian = false;
				this.m_IsFifa14 = true;
			}
			else if (text != "RX3b")
			{
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_Rx3bPosition = 0;
				this.m_SwapEndian = true;
				this.m_IsFifa14 = false;
			}
			else
			{
				r.BaseStream.Position = 68L;
				this.m_Rx3bPosition = FifaUtil.SwapEndian(r.ReadInt32());
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_Preface = r.ReadBytes(this.m_Rx3bPosition);
				this.m_SwapEndian = true;
				this.m_IsFifa14 = false;
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
			this.m_RawData = new byte[this.m_Rx3Header.NFiles][];
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				this.m_RawData[j] = r.ReadBytes(this.m_Rx3FileDescriptors[j].Size);
			}
			return true;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0003984C File Offset: 0x00037A4C
		public bool SetRawData(int index, byte[] rawData)
		{
			int num = rawData.Length;
			int size = this.m_Rx3FileDescriptors[index].Size;
			this.m_Rx3FileDescriptors[index].Size = num;
			int num2 = num - size;
			for (int i = index + 1; i < this.m_Rx3FileDescriptors.Length; i++)
			{
				this.m_Rx3FileDescriptors[i].Offset += num2;
			}
			this.m_RawData[index] = rawData;
			this.m_Rx3Header.SizeOf_ += num2;
			return true;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000398C4 File Offset: 0x00037AC4
		public bool Save(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			fileStream.Close();
			binaryWriter.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00039900 File Offset: 0x00037B00
		public virtual bool Save(BinaryWriter w)
		{
			this.m_Rx3Header.Save(w);
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i].Save(w);
			}
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				w.Write(this.m_RawData[j]);
			}
			return true;
		}

		// Token: 0x04000FA3 RID: 4003
		private string m_FileName;

		// Token: 0x04000FA4 RID: 4004
		private bool m_IsFifa14;

		// Token: 0x04000FA5 RID: 4005
		private int m_Rx3bPosition;

		// Token: 0x04000FA6 RID: 4006
		private byte[] m_Preface;

		// Token: 0x04000FA7 RID: 4007
		private byte[][] m_RawData;

		// Token: 0x04000FA8 RID: 4008
		private Rx3Header m_Rx3Header;

		// Token: 0x04000FA9 RID: 4009
		private bool m_SwapEndian;

		// Token: 0x04000FAA RID: 4010
		private Rx3FileDescriptor[] m_Rx3FileDescriptors;
	}
}
