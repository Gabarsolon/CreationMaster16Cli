using System;

namespace FifaLibrary
{
	// Token: 0x0200006C RID: 108
	public class CareerLastNameList : IdArrayList
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x0003754C File Offset: 0x0003574C
		public CareerLastNameList(DbFile fifaDbFile)
			: base(typeof(CareerLastName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00037565 File Offset: 0x00035765
		public CareerLastNameList(Table careerLastNamesTable, PlayerNames playerNames)
			: base(typeof(CareerLastName))
		{
			this.Load(careerLastNamesTable);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00037580 File Offset: 0x00035780
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_lastnames];
			this.Load(table);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000375A4 File Offset: 0x000357A4
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_lastnames_lastnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_lastnames_lastnameid];
			CareerLastName[] array = new CareerLastName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerLastName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00037620 File Offset: 0x00035820
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_lastnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerLastName careerLastName = (CareerLastName)obj;
				Record record = table.Records[num];
				num++;
				careerLastName.Save(record);
			}
		}
	}
}
