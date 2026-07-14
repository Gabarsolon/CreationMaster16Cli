using System;

namespace FifaLibrary
{
	// Token: 0x02000008 RID: 8
	public class NumberFontList : IdArrayList
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002CC6 File Offset: 0x00000EC6
		public NumberFontList()
			: base(typeof(NumberFont))
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public NumberFontList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(NumberFont))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teamkits].TableDescriptor;
			int num = 1;
			int num2 = tableDescriptor.MaxValues[FI.teamkits_numberfonttype];
			int num3 = 0;
			int num4 = 19;
			base.MinId = num * (num4 + 1) + num3;
			base.MaxId = num2 * (num4 + 1) + num4;
			this.Clear();
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					string text = NumberFont.NumberFontFileName(i, j);
					if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
					{
						NumberFont numberFont = new NumberFont(i * (num4 + 1) + j);
						this.Add(numberFont);
					}
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002DA0 File Offset: 0x00000FA0
		public new NumberFont CreateNewId(int proposedId)
		{
			int num = -1;
			if (base.SearchId(proposedId) == null)
			{
				num = proposedId;
			}
			if (num < 0)
			{
				for (int i = 20 + proposedId % 20; i <= base.MaxId; i += 20)
				{
					if (base.SearchId(i) == null)
					{
						num = i;
						break;
					}
				}
			}
			if (num < 0)
			{
				return null;
			}
			NumberFont numberFont = new NumberFont(num);
			base.InsertId(numberFont);
			return numberFont;
		}
	}
}
