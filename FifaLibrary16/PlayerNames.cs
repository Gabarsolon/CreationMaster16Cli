using System;

namespace FifaLibrary
{
	// Token: 0x0200005B RID: 91
	public class PlayerNames : IdArrayList
	{
		// Token: 0x060006B3 RID: 1715 RVA: 0x0002BAB0 File Offset: 0x00029CB0
		public PlayerNames(DbFile fifaDbFile)
			: base(typeof(PlayerName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0002BACC File Offset: 0x00029CCC
		public PlayerNames(Table playerNamesTable)
			: base(typeof(PlayerName))
		{
			int num = 0;
			int num2 = playerNamesTable.TableDescriptor.MaxValues[FI.playernames_nameid];
			if (num2 < 32767)
			{
				num2 = 32767;
			}
			this.Load(playerNamesTable, num, num2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002BB14 File Offset: 0x00029D14
		public PlayerNames()
			: base(typeof(PlayerName))
		{
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002BB28 File Offset: 0x00029D28
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playernames];
			int num = 0;
			int num2 = table.TableDescriptor.MaxValues[FI.playernames_nameid];
			if (num2 < 32767)
			{
				num2 = 32767;
			}
			this.Load(table, num, num2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0002BB70 File Offset: 0x00029D70
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			PlayerName[] array = new PlayerName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new PlayerName(table.Records[i]);
				string text = PlayerNames.Normalize(array[i].Text);
				if (array[i].Text != text)
				{
					array[i].Text = text;
				}
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playernames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.IsUsed || playerName.IsOriginal)
				{
					Record record = table.Records[num];
					num++;
					playerName.SavePlayerName(record);
				}
			}
			table.ResizeRecords(num);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0002BC90 File Offset: 0x00029E90
		public bool TryGetValue(int id, out string name, bool isUsed)
		{
			PlayerName playerName = (PlayerName)base.SearchId(id);
			if (playerName != null)
			{
				name = playerName.Text;
				playerName.IsUsed = isUsed;
				return true;
			}
			name = null;
			return false;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		public bool TryGetValue(int id, out string name, out int commentaryid, bool isUsed)
		{
			PlayerName playerName = (PlayerName)base.SearchId(id);
			if (playerName != null)
			{
				name = playerName.Text;
				commentaryid = playerName.CommentaryId;
				playerName.IsUsed = isUsed;
				return true;
			}
			name = null;
			commentaryid = 900000;
			return false;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002BD08 File Offset: 0x00029F08
		public bool SetCommentaryId(int nameid, int commentaryid)
		{
			PlayerName playerName = (PlayerName)base.SearchId(nameid);
			if (playerName != null)
			{
				playerName.CommentaryId = commentaryid;
				return true;
			}
			return false;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002BD30 File Offset: 0x00029F30
		public void ClearUsedFlags()
		{
			foreach (object obj in this)
			{
				((PlayerName)obj).IsUsed = false;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0002BD84 File Offset: 0x00029F84
		public void SetUsedFlags()
		{
			foreach (object obj in this)
			{
				((PlayerName)obj).IsUsed = true;
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002BDD8 File Offset: 0x00029FD8
		public int GetCommentaryIdFromName(string text)
		{
			string text2 = PlayerNames.Normalize(text);
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text2)
				{
					return playerName.CommentaryId;
				}
			}
			return 900000;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002BE50 File Offset: 0x0002A050
		public PlayerName SearchName(string text)
		{
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text)
				{
					return playerName;
				}
			}
			return null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		public int GetKey(string text, int commentaryId)
		{
			string text2 = PlayerNames.Normalize(text);
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text2)
				{
					playerName.IsUsed = true;
					if (playerName.CommentaryId != commentaryId && commentaryId >= 0)
					{
						playerName.CommentaryId = commentaryId;
					}
					return playerName.Id;
				}
			}
			int newId = this.GetNewId();
			if (newId >= 0)
			{
				PlayerName playerName2 = new PlayerName(newId, text2, true);
				if (commentaryId >= 0)
				{
					playerName2.CommentaryId = commentaryId;
				}
				else
				{
					playerName2.CommentaryId = 900000;
				}
				base.InsertId(playerName2);
				return newId;
			}
			return 0;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0002BF80 File Offset: 0x0002A180
		public int GetKey(string text)
		{
			string text2 = PlayerNames.Normalize(text);
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text2)
				{
					playerName.IsUsed = true;
					return playerName.Id;
				}
			}
			int newId = this.GetNewId();
			if (newId >= 0)
			{
				PlayerName playerName2 = new PlayerName(newId, text2, true);
				base.InsertId(playerName2);
				return newId;
			}
			return 0;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0002C01C File Offset: 0x0002A21C
		public static string Normalize(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}
			if (text.Length <= 0)
			{
				return text;
			}
			string text2 = text;
			string text3 = text2;
			if (text3 == text3.ToUpper() && text2.IndexOfAny(PlayerNames.c_NoLetters) < 0 && text2.Length > 3)
			{
				text2 = text2.Substring(0, 1).ToUpper() + text2.Substring(1, text2.Length - 1).ToLower();
			}
			if (text2.Length == 0)
			{
				return string.Empty;
			}
			string text4 = text2;
			if (text4 == text4.ToLower())
			{
				text2 = text2.Substring(0, 1).ToUpper() + text2.Substring(1, text2.Length - 1);
			}
			return text2;
		}

		// Token: 0x04000E92 RID: 3730
		private static char[] c_NoLetters = new char[] { ' ', '.', '-', '\'' };
	}
}
