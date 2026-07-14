using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000043 RID: 67
	public class ImageDir
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0002081F File Offset: 0x0001EA1F
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00020827 File Offset: 0x0001EA27
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00020830 File Offset: 0x0001EA30
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00020838 File Offset: 0x0001EA38
		public int Offset
		{
			get
			{
				return this.m_Offset;
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00020841 File Offset: 0x0001EA41
		public ImageDir(BinaryReader r)
		{
			this.m_Name = new string(r.ReadChars(4));
			this.m_Offset = r.ReadInt32();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00020868 File Offset: 0x0001EA68
		public void Save(BinaryWriter w)
		{
			char[] array = this.m_Name.ToCharArray();
			w.Write((byte)array[0]);
			w.Write((byte)array[1]);
			w.Write((byte)array[2]);
			w.Write((byte)array[3]);
			w.Write(this.m_Offset);
		}

		// Token: 0x04000E04 RID: 3588
		private string m_Name;

		// Token: 0x04000E05 RID: 3589
		private int m_Offset;
	}
}
