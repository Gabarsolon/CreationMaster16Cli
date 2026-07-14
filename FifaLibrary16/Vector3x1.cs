using System;

namespace FifaLibrary
{
	// Token: 0x02000056 RID: 86
	public class Vector3x1
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002ADC6 File Offset: 0x00028FC6
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x0002ADBD File Offset: 0x00028FBD
		public float X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0002ADD7 File Offset: 0x00028FD7
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0002ADCE File Offset: 0x00028FCE
		public float Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002ADE8 File Offset: 0x00028FE8
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0002ADDF File Offset: 0x00028FDF
		public float Z
		{
			get
			{
				return this.z;
			}
			set
			{
				this.z = value;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002ADF0 File Offset: 0x00028FF0
		public Vector3x1(float c0, float c1, float c2)
		{
			this.x = c0;
			this.y = c1;
			this.z = c2;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002AE0D File Offset: 0x0002900D
		public Vector3x1(int c0, int c1, int c2)
		{
			this.x = (float)c0;
			this.y = (float)c1;
			this.z = (float)c2;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002AE2D File Offset: 0x0002902D
		public Vector3x1()
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
		}

		// Token: 0x04000E8B RID: 3723
		private float x;

		// Token: 0x04000E8C RID: 3724
		private float y;

		// Token: 0x04000E8D RID: 3725
		private float z;
	}
}
