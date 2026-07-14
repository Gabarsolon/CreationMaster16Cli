using System;

namespace FifaLibrary
{
	// Token: 0x0200004D RID: 77
	public class IdString : IdObject
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00027296 File Offset: 0x00025496
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0002729E File Offset: 0x0002549E
		public string String
		{
			get
			{
				return this.String;
			}
			set
			{
				this.String = value;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002B03 File Offset: 0x00000D03
		public IdString(int id)
			: base(id)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000272A7 File Offset: 0x000254A7
		public IdString(int id, string value)
			: base(id)
		{
			this.m_String = value;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000272B7 File Offset: 0x000254B7
		public override string ToString()
		{
			return this.m_String;
		}

		// Token: 0x04000E32 RID: 3634
		private string m_String;
	}
}
