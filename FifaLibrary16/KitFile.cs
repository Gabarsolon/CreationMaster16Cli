using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200004E RID: 78
	public class KitFile : Rx3File
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x000272BF File Offset: 0x000254BF
		public override bool Load(BinaryReader r)
		{
			return base.Load(r);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000272C8 File Offset: 0x000254C8
		public override bool Save(BinaryWriter w, bool saveBitmaps, bool saveVertex)
		{
			return base.Save(w, true, false);
		}
	}
}
