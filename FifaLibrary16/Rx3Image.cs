using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000079 RID: 121
	public class Rx3Image
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0003B3BA File Offset: 0x000395BA
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x0003B3C2 File Offset: 0x000395C2
		public Rx3ImageHeader Header
		{
			get
			{
				return this.m_Header;
			}
			set
			{
				this.m_Header = value;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0003B3CB File Offset: 0x000395CB
		public Bitmap GetBitmap()
		{
			return this.m_MipMapImage[0].Bitmap;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0003B3DA File Offset: 0x000395DA
		public Bitmap GetBitmap(int mipMapLevel)
		{
			if (mipMapLevel >= this.m_MipMapImage.Length)
			{
				return null;
			}
			return this.m_MipMapImage[mipMapLevel].Bitmap;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0003B3F8 File Offset: 0x000395F8
		public bool SetBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			if (bitmap.Width != (int)this.m_Header.Width || bitmap.Width != (int)this.m_Header.Width)
			{
				return false;
			}
			Bitmap bitmap2 = bitmap;
			this.m_MipMapImage[0].Bitmap = bitmap2;
			for (int i = 1; i < (int)this.m_Header.NMipMaps; i++)
			{
				bitmap2 = GraphicUtil.ReduceBitmap(bitmap2);
				this.m_MipMapImage[i].Bitmap = bitmap2;
			}
			return true;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0003B46E File Offset: 0x0003966E
		public Rx3Image(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.m_Header = new Rx3ImageHeader(r, this.m_SwapEndian);
			this.Load(r);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0003B498 File Offset: 0x00039698
		public bool Load(BinaryReader r)
		{
			this.m_MipMapImage = new MipMap[(int)this.m_Header.NMipMaps];
			int num = (int)this.m_Header.Width;
			int num2 = (int)this.m_Header.Height;
			for (int i = 0; i < (int)this.m_Header.NMipMaps; i++)
			{
				this.m_MipMapImage[i] = new MipMap(num, num2, this.m_Header.ImageType, this.m_SwapEndian);
				this.m_MipMapImage[i].Load(r);
				num /= 2;
				num2 /= 2;
			}
			return true;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0003B524 File Offset: 0x00039724
		public bool Save(BinaryWriter w)
		{
			this.m_Header.Save(w);
			for (int i = 0; i < (int)this.m_Header.NMipMaps; i++)
			{
				this.m_MipMapImage[i].Save(w);
			}
			return true;
		}

		// Token: 0x04000FD9 RID: 4057
		private Rx3ImageHeader m_Header;

		// Token: 0x04000FDA RID: 4058
		private MipMap[] m_MipMapImage;

		// Token: 0x04000FDB RID: 4059
		private bool m_SwapEndian;
	}
}
