using System;

namespace FifaLibrary
{
	// Token: 0x02000006 RID: 6
	public class AdboardList : IdArrayList
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00002A50 File Offset: 0x00000C50
		public AdboardList()
			: base(typeof(Adboard))
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A62 File Offset: 0x00000C62
		public AdboardList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Adboard))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A7C File Offset: 0x00000C7C
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teams].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.teams_adboardid];
			base.MaxId = tableDescriptor.MaxValues[FI.teams_adboardid];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Adboard.AdboardFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Adboard adboard = new Adboard(i);
					this.Add(adboard);
				}
			}
		}
	}
}
