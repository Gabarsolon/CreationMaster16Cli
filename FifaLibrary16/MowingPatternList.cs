using System;

namespace FifaLibrary
{
	// Token: 0x02000012 RID: 18
	public class MowingPatternList : IdArrayList
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00004472 File Offset: 0x00002672
		public MowingPatternList()
			: base(typeof(MowingPattern))
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004484 File Offset: 0x00002684
		public MowingPatternList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(MowingPattern))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000044A0 File Offset: 0x000026A0
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.stadiums].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.stadiums_stadiummowpattern_code];
			base.MaxId = tableDescriptor.MaxValues[FI.stadiums_stadiummowpattern_code];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = MowingPattern.MowingPatternFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					MowingPattern mowingPattern = new MowingPattern(i);
					this.Add(mowingPattern);
				}
			}
		}
	}
}
