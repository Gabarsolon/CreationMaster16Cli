using System;

namespace FifaLibrary
{
	// Token: 0x02000003 RID: 3
	public class GkGlovesList : IdArrayList
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000021C0 File Offset: 0x000003C0
		public GkGlovesList()
			: base(typeof(GkGloves))
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021D2 File Offset: 0x000003D2
		public GkGlovesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(GkGloves))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021EC File Offset: 0x000003EC
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.players].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.players_gkglovetypecode];
			base.MaxId = tableDescriptor.MaxValues[FI.players_gkglovetypecode];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = GkGloves.GkGlovesTextureFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					GkGloves gkGloves = new GkGloves(i);
					base.InsertId(gkGloves);
				}
			}
		}
	}
}
