using System;
using System.Collections.Generic;
using System.Text;

namespace FifaLibrary
{
	// Token: 0x0200005A RID: 90
	public class NameDictionary : Dictionary<int, string>
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x0002B840 File Offset: 0x00029A40
		public NameDictionary(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.commentarynames];
			this.Load(table);
			Table table2 = fifaDbFile.Table[TI.playernames];
			this.FillFromPlayernames(table2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002B87C File Offset: 0x00029A7C
		public void Load(Table commentaryNamesTable)
		{
			base.Clear();
			for (int i = 0; i < commentaryNamesTable.NRecords; i++)
			{
				Record record = commentaryNamesTable.Records[i];
				int num = record.IntField[FI.commentarynames_commentaryid];
				if (!base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.commentarynames_commentarystring];
					string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(text));
					if (@string.Length > 0)
					{
						char c = @string.ToUpper()[0];
					}
					base.Add(num, text);
				}
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002B908 File Offset: 0x00029B08
		public void FillFromPlayernames(Table playernamesTable)
		{
			for (int i = 0; i < playernamesTable.NRecords; i++)
			{
				Record record = playernamesTable.Records[i];
				int num = record.IntField[FI.playernames_commentaryid];
				if (num != 900000 && !base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.playernames_name];
					string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(text));
					if (@string.Length > 0)
					{
						char c = @string.ToUpper()[0];
					}
					base.Add(num, @string);
				}
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002B998 File Offset: 0x00029B98
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.commentarynames];
			this.Save(table);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002B9BC File Offset: 0x00029BBC
		public void Save(Table commentaryNamesTable)
		{
			commentaryNamesTable.ResizeRecords(base.Count);
			commentaryNamesTable.NValidRecords = base.Count;
			int num = 0;
			foreach (KeyValuePair<int, string> keyValuePair in this)
			{
				Record record = commentaryNamesTable.Records[num];
				num++;
				string value = keyValuePair.Value;
				char c = 'Z';
				string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(value));
				if (@string.Length > 0)
				{
					c = @string.ToUpper()[0];
				}
				record.IntField[FI.commentarynames_commentarystartingletter] = (int)(c - 'A' + '\u0001');
				record.IntField[FI.commentarynames_commentaryid] = keyValuePair.Key;
				record.IntField[FI.commentarynames_commentarypreview] = 1;
				record.CompressedString[FI.commentarynames_commentarystring] = value;
			}
		}
	}
}
