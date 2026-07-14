using System;

namespace FifaLibrary
{
	// Token: 0x0200003B RID: 59
	public class RoleList : IdArrayList
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x0001DBE1 File Offset: 0x0001BDE1
		public RoleList()
			: base(typeof(Role))
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001DBF3 File Offset: 0x0001BDF3
		public RoleList(DbFile fifaDbFile)
			: base(typeof(Role))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		public RoleList(Table boundingBoxTable)
			: base(typeof(Role))
		{
			this.Load(boundingBoxTable);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001DC28 File Offset: 0x0001BE28
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.fieldpositionboundingboxes];
			this.Load(table);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001DC50 File Offset: 0x0001BE50
		public void Load(Table boundingBoxTable)
		{
			base.MinId = 0;
			base.MaxId = 32;
			this.Clear();
			for (int i = 0; i < boundingBoxTable.NRecords; i++)
			{
				Role role = new Role(boundingBoxTable.Records[i]);
				this.Add(role);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		public void Save(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.fieldpositionboundingboxes];
			int num = 0;
			foreach (object obj in this)
			{
				Role role = (Role)obj;
				Record record = table.Records[num];
				num++;
				role.Save(record);
			}
		}
	}
}
