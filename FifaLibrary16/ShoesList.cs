using System;

namespace FifaLibrary
{
	// Token: 0x02000010 RID: 16
	public class ShoesList : IdArrayList
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00003A85 File Offset: 0x00001C85
		public ShoesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Shoes))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			Table table = fifaDb.Table[TI.playerboots];
			TableDescriptor tableDescriptor = table.TableDescriptor;
			int num = tableDescriptor.MinValues[FI.playerboots_shoetype];
			int num2 = tableDescriptor.MaxValues[FI.playerboots_shoetype];
			this.Load(table, num, num2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.m_HasGenericShoes = false;
			Shoes[] array = new Shoes[table.NRecords];
			this.Clear();
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < table.NRecords; i++)
			{
				Shoes shoes = new Shoes(table.Records[i]);
				if (shoes.Id != 0 || !this.m_HasGenericShoes)
				{
					array[num++] = shoes;
					if (shoes.Id == 0)
					{
						this.m_HasGenericShoes = true;
						ShoesList.s_GenericShoes[num2++] = shoes;
					}
				}
				else if (num2 < ShoesList.s_GenericShoes.Length)
				{
					ShoesList.s_GenericShoes[num2++] = shoes;
				}
			}
			Shoes[] array2 = new Shoes[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[j];
			}
			this.AddRange(array2);
			base.SortId();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playerboots];
			table.ResizeRecords(this.Count - 1 + ShoesList.s_GenericShoes.Length);
			int num = 0;
			foreach (Shoes shoes in ShoesList.s_GenericShoes)
			{
				Record record = table.Records[num];
				num++;
				if (shoes != null)
				{
					shoes.SaveShoes(record);
				}
			}
			foreach (object obj in this)
			{
				Shoes shoes2 = (Shoes)obj;
				if (shoes2.Id != 0)
				{
					Record record2 = table.Records[num];
					num++;
					shoes2.SaveShoes(record2);
				}
			}
		}

		// Token: 0x0400000B RID: 11
		private bool m_HasGenericShoes;

		// Token: 0x0400000C RID: 12
		public static Shoes[] s_GenericShoes = new Shoes[23];
	}
}
