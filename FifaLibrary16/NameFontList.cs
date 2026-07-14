using System;

namespace FifaLibrary
{
	// Token: 0x0200000A RID: 10
	public class NameFontList : IdArrayList
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000031A1 File Offset: 0x000013A1
		public NameFontList()
			: base(typeof(NameFont))
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000031B3 File Offset: 0x000013B3
		public NameFontList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(NameFont))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000031D0 File Offset: 0x000013D0
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teamkits].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.teamkits_jerseynamefonttype];
			base.MaxId = tableDescriptor.MaxValues[FI.teamkits_jerseynamefonttype];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = NameFont.NameFontFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					NameFont nameFont = new NameFont(i);
					this.Add(nameFont);
				}
			}
		}
	}
}
