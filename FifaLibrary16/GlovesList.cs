using System;

namespace FifaLibrary
{
	// Token: 0x02000017 RID: 23
	public class GlovesList : IdArrayList
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000049B3 File Offset: 0x00002BB3
		public GlovesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Gloves))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000049D0 File Offset: 0x00002BD0
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.players].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.players_gkglovetypecode];
			base.MaxId = tableDescriptor.MaxValues[FI.players_gkglovetypecode];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Gloves.GlovesFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Gloves gloves = new Gloves(i);
					this.Add(gloves);
				}
			}
		}
	}
}
