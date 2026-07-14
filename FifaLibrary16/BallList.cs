using System;

namespace FifaLibrary
{
	// Token: 0x02000004 RID: 4
	public class BallList : IdArrayList
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002273 File Offset: 0x00000473
		public BallList()
			: base(typeof(Ball))
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002285 File Offset: 0x00000485
		public BallList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Ball))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022A0 File Offset: 0x000004A0
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			Table table = fifaDb.Table[TI.teamballs];
			TableDescriptor tableDescriptor = table.TableDescriptor;
			int num = tableDescriptor.MinValues[FI.teamballs_ballid];
			int num2 = tableDescriptor.MaxValues[FI.teamballs_ballid];
			this.Load(table, num, num2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000022E4 File Offset: 0x000004E4
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Ball[] array = new Ball[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new Ball(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002340 File Offset: 0x00000540
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamballs];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Ball ball = (Ball)obj;
				Record record = table.Records[num];
				num++;
				ball.SaveBall(record);
			}
		}
	}
}
