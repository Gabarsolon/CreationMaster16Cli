using System;

namespace FifaLibrary
{
	// Token: 0x0200006B RID: 107
	public class CareerFirstNameList : IdArrayList
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x000373F7 File Offset: 0x000355F7
		public CareerFirstNameList(DbFile fifaDbFile)
			: base(typeof(CareerFirstName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00037410 File Offset: 0x00035610
		public CareerFirstNameList(Table careerFirstNamesTable)
			: base(typeof(CareerFirstName))
		{
			this.Load(careerFirstNamesTable);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0003742C File Offset: 0x0003562C
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_firstnames];
			this.Load(table);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00037450 File Offset: 0x00035650
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_firstnames_firstnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_firstnames_firstnameid];
			CareerFirstName[] array = new CareerFirstName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerFirstName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000374CC File Offset: 0x000356CC
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_firstnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerFirstName careerFirstName = (CareerFirstName)obj;
				Record record = table.Records[num];
				num++;
				careerFirstName.Save(record);
			}
		}
	}
}
