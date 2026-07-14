using System;

namespace FifaLibrary
{
	// Token: 0x0200006D RID: 109
	public class CareerCommonNameList : IdArrayList
	{
		// Token: 0x0600090D RID: 2317 RVA: 0x000376A0 File Offset: 0x000358A0
		public CareerCommonNameList(DbFile fifaDbFile)
			: base(typeof(CareerCommonName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000376B9 File Offset: 0x000358B9
		public CareerCommonNameList(Table careerCommonNamesTable)
			: base(typeof(CareerCommonName))
		{
			this.Load(careerCommonNamesTable);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000376D4 File Offset: 0x000358D4
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_commonnames];
			this.Load(table);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000376F8 File Offset: 0x000358F8
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_commonnames_commonnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_commonnames_commonnameid];
			CareerCommonName[] array = new CareerCommonName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerCommonName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00037774 File Offset: 0x00035974
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_commonnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerCommonName careerCommonName = (CareerCommonName)obj;
				Record record = table.Records[num];
				num++;
				careerCommonName.Save(record);
			}
		}
	}
}
