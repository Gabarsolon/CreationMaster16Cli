using System;

namespace FifaLibrary
{
	// Token: 0x0200000C RID: 12
	public class NetList : IdArrayList
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000330F File Offset: 0x0000150F
		public NetList()
			: base(typeof(Net))
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003321 File Offset: 0x00001521
		public NetList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Net))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000333C File Offset: 0x0000153C
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.stadiums].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.stadiums_stadiumgoalnetstyle];
			base.MaxId = tableDescriptor.MaxValues[FI.stadiums_stadiumgoalnetstyle];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Net.NetFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Net net = new Net(i);
					this.Add(net);
				}
			}
		}
	}
}
