using System;

namespace FifaLibrary
{
	// Token: 0x02000040 RID: 64
	public class CareerFormationList : FormationList
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x00020319 File Offset: 0x0001E519
		public CareerFormationList(CareerFile careerFile)
			: base(typeof(CareerFormation))
		{
			this.Load(careerFile);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void Load(CareerFile careerFile)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00020334 File Offset: 0x0001E534
		private void Load(Table formationsTable, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				CareerFormation careerFormation = new CareerFormation(formationsTable.Records[i]);
				this.Add(careerFormation);
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002037C File Offset: 0x0001E57C
		private void AdditionalLoad(Table formationsTable)
		{
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				CareerFormation careerFormation = new CareerFormation(formationsTable.Records[i]);
				careerFormation.IsInCareer = true;
				CareerFormation careerFormation2 = (CareerFormation)base.SearchId(careerFormation);
				if (careerFormation2 != null)
				{
					base.RemoveId(careerFormation2);
				}
				base.InsertId(careerFormation);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void Save(DbFile dbFile, CareerFile careerFile)
		{
		}
	}
}
