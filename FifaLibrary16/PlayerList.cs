using System;
using System.Collections;
using System.Text;

namespace FifaLibrary
{
	// Token: 0x02000066 RID: 102
	public class PlayerList : IdArrayList
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x0001FC19 File Offset: 0x0001DE19
		public PlayerList(Type type)
			: base(type)
		{
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0003579A File Offset: 0x0003399A
		public PlayerList(DbFile fifaDbFile)
			: base(typeof(Player))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000357B3 File Offset: 0x000339B3
		public PlayerList()
			: base(typeof(Player))
		{
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000357C8 File Offset: 0x000339C8
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.players];
			int num = 50000;
			int num2 = table.TableDescriptor.MaxValues[FI.players_playerid];
			this.Load(table, num, num2);
			table = fifaDbFile.Table[TI.playerloans];
			this.FillFromPlayerloans(table);
			table = fifaDbFile.Table[TI.previousteam];
			this.FillFromPreviousTeam(table);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00035830 File Offset: 0x00033A30
		public void FillFromPreviousTeam(Table t)
		{
			for (int i = 0; i < t.NValidRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.previousteam_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromPreviousTeam(record);
				}
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0003587C File Offset: 0x00033A7C
		public void FillFromPlayerloans(Table t)
		{
			for (int i = 0; i < t.NValidRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.playerloans_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromPlayerloans(record);
				}
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000358C8 File Offset: 0x00033AC8
		public void FillFromEditedPlayerNames(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.editedplayernames_playerid];
				Player player = (Player)base.SearchId(num);
				if (player != null)
				{
					player.FillFromEditedPlayerNames(record);
				}
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00035914 File Offset: 0x00033B14
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Player[] array = new Player[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new Player(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00035970 File Offset: 0x00033B70
		public Player MatchPlayerByNameBirthday(ref string firstName, ref string lastName, ref string commonName, DateTime birthdate)
		{
			Player player = null;
			bool flag = false;
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				if (firstName != null)
				{
					num2 = firstName.Length;
				}
				if (lastName != null)
				{
					num2 += lastName.Length;
				}
				if (commonName != null)
				{
					num2 += commonName.Length;
				}
				foreach (object obj in this)
				{
					Player player2 = (Player)obj;
					if (!(birthdate.Date != player2.birthdate.Date))
					{
						int num3 = 0;
						if (player2.commonname != string.Empty && player2.commonname == firstName + " " + lastName)
						{
							flag = true;
							commonName = player2.commonname;
						}
						if (!flag && commonName != null && commonName != string.Empty && player2.commonname != string.Empty)
						{
							if (commonName == player2.commonname)
							{
								flag = true;
							}
							int num4 = this.FuzzyMatchString(commonName, player2.commonname);
							num3 += num4;
						}
						if (!flag && firstName != null && firstName != string.Empty)
						{
							int num4 = this.FuzzyMatchString(firstName, player2.firstname);
							num3 += num4;
							if (num4 == 0)
							{
								continue;
							}
						}
						if (!flag && lastName != null && lastName != string.Empty)
						{
							int num4 = this.FuzzyMatchString(lastName, player2.lastname);
							num3 += num4;
							if (num4 == 0)
							{
								continue;
							}
						}
						if (flag || num3 == num2)
						{
							return player2;
						}
						if (num3 > num)
						{
							num = num3;
							player = player2;
						}
					}
				}
				if (player != null)
				{
					break;
				}
				int num5 = firstName.IndexOf(' ');
				bool flag2;
				if (num5 > 0)
				{
					lastName = firstName.Substring(num5 + 1) + " " + lastName;
					firstName = firstName.Substring(0, num5);
					flag2 = true;
				}
				else
				{
					flag2 = false;
				}
				if (!flag2)
				{
					return player;
				}
			}
			return player;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00035B84 File Offset: 0x00033D84
		public Player FindSimilarPlayer(Country country, DateTime birthdate)
		{
			Player player = null;
			int num = 100000;
			foreach (object obj in this)
			{
				Player player2 = (Player)obj;
				if (country == player2.Country)
				{
					int num2 = Math.Abs(birthdate.Year - player2.birthdate.Year) * 365;
					num2 += Math.Abs(birthdate.Month - player2.birthdate.Month) * 30;
					num2 += Math.Abs(birthdate.Day - player2.birthdate.Day);
					if (num2 != 0 && num2 < num)
					{
						num = num2;
						player = player2;
					}
				}
			}
			return player;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00035C64 File Offset: 0x00033E64
		private int FuzzyMatchString(string pattern, string actual)
		{
			if (pattern == actual)
			{
				return pattern.Length;
			}
			if (actual.StartsWith(pattern + " "))
			{
				return pattern.Length - 1;
			}
			if (actual.EndsWith(" " + pattern))
			{
				return pattern.Length - 1;
			}
			if (pattern.StartsWith(actual + " "))
			{
				return actual.Length;
			}
			if (pattern.EndsWith(" " + actual))
			{
				return actual.Length;
			}
			if (Math.Abs(pattern.Length - actual.Length) > 1)
			{
				return 0;
			}
			char[] array = pattern.ToCharArray();
			char[] array2 = new char[array.Length + 3];
			char[] array3 = actual.ToCharArray();
			for (int i = 0; i < array3.Length; i++)
			{
				array2[i] = array3[i];
			}
			int length = pattern.Length;
			int num = 0;
			int num2 = 0;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] != array2[j + num2])
				{
					if (j + 1 < array.Length && j + num2 + 1 < array2.Length && array[j + 1] == array2[j + num2 + 1])
					{
						num++;
					}
					else if (j + num2 + 1 < array2.Length && array[j] == array2[j + num2 + 1])
					{
						num++;
						num2++;
					}
					else if (j + 1 < array.Length && j + num2 < array2.Length && array[j + 1] == array2[j + num2])
					{
						num++;
						num2--;
					}
					else
					{
						if (j != array.Length - 1)
						{
							return 0;
						}
						num++;
					}
					if (num > 3)
					{
						return 0;
					}
				}
			}
			return length - num;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00035E14 File Offset: 0x00034014
		public Player FitPlayer(Player player)
		{
			foreach (object obj in this)
			{
				Player player2 = (Player)obj;
				if (player2.lastname == player.lastname)
				{
					if (player.firstname != null && player.firstname != "")
					{
						if (player2.firstname == player.firstname)
						{
							return player2;
						}
					}
					else if (player2.Id == player.Id)
					{
						return player2;
					}
				}
			}
			return null;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00035EBC File Offset: 0x000340BC
		public Player FitPlayer(string name, int id)
		{
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.ToString() == name)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00035F20 File Offset: 0x00034120
		public Player FitPlayer(string firstname, string lastname, DateTime birthdate)
		{
			firstname = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(firstname));
			lastname = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(lastname));
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (birthdate.Date == player.birthdate.Date)
				{
					string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(player.firstname));
					string string2 = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(player.lastname));
					if (firstname == @string && lastname == string2)
					{
						return player;
					}
				}
			}
			return null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00036028 File Offset: 0x00034228
		public PlayerList GetFreeAgent()
		{
			PlayerList playerList = new PlayerList();
			for (int i = 0; i < this.Count; i++)
			{
				Player player = (Player)this[i];
				if (player.IsFreeAgent())
				{
					playerList.Add(player);
				}
			}
			return playerList;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0003606C File Offset: 0x0003426C
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.players];
			table.ResizeRecords(this.Count);
			Table table2 = fifaDbFile.Table[TI.playerloans];
			Table table3 = fifaDbFile.Table[TI.previousteam];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				Record record = table.Records[num];
				if (player.m_assetid != 0)
				{
					num++;
					player.SavePlayer(record);
					if (player.IsLoaned)
					{
						num2++;
					}
					if (player.PreviousTeam != null)
					{
						num3++;
					}
				}
			}
			table2.ResizeRecords(num2);
			table3.ResizeRecords(num3);
			num = 0;
			int num4 = 0;
			foreach (object obj2 in this)
			{
				Player player2 = (Player)obj2;
				if (player2.IsLoaned)
				{
					Record record2 = table2.Records[num];
					num++;
					player2.SavePlayerloans(record2);
				}
				if (player2.PreviousTeam != null)
				{
					Record record3 = table3.Records[num4];
					num4++;
					player2.SavePreviousTeam(record3);
				}
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000361DC File Offset: 0x000343DC
		public ArrayList FindMissedFiles()
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.HasSpecificHeadModel)
				{
					if (!FifaEnvironment.FifaFat.IsArchivedFilePresent(player.SpecificFaceTextureFileName()))
					{
						arrayList.Add(string.Concat(new string[]
						{
							"Face #",
							player.Id.ToString(),
							" used by player ",
							player.ToString(),
							"\r\n"
						}));
					}
					if (!FifaEnvironment.FifaFat.IsArchivedFilePresent(player.SpecificHairTexturesFileName()))
					{
						arrayList.Add(string.Concat(new string[]
						{
							"Hair Textures #",
							player.Id.ToString(),
							" used by player ",
							player.ToString(),
							"\r\n"
						}));
					}
				}
			}
			return arrayList;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000362F0 File Offset: 0x000344F0
		public override IdArrayList Filter(IdObject filter)
		{
			if (filter == null)
			{
				return this;
			}
			PlayerList playerList = new PlayerList();
			if (filter.GetType().Name == "SameName")
			{
				for (int i = 0; i < this.Count; i++)
				{
					Player player = (Player)this[i];
					for (int j = i + 1; j < this.Count; j++)
					{
						Player player2 = (Player)this[j];
						if (player.firstnameid == player2.firstnameid && player.lastnameid == player2.lastnameid && player.birthdate == player2.birthdate)
						{
							playerList.Add(player);
							playerList.Add(player2);
						}
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "FreeAgent")
			{
				for (int k = 0; k < this.Count; k++)
				{
					Player player3 = (Player)this[k];
					if (player3.IsFreeAgent() && player3.Country.Id == 60)
					{
						playerList.Add(player3);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Team" || filter.GetType().Name == "CareerTeam")
			{
				Team team = (Team)filter;
				if (team != null)
				{
					for (int l = 0; l < this.Count; l++)
					{
						Player player4 = (Player)this[l];
						if (player4.IsPlayingFor(team))
						{
							playerList.Add(player4);
						}
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "MultiClub")
			{
				for (int m = 0; m < this.Count; m++)
				{
					Player player5 = (Player)this[m];
					if (player5.IsMultiClub())
					{
						playerList.Add(player5);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int n = 0; n < this.Count; n++)
				{
					Player player6 = (Player)this[n];
					if (player6.Country == country)
					{
						playerList.Add(player6);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "Role")
			{
				Role role = (Role)filter;
				for (int num = 0; num < this.Count; num++)
				{
					Player player7 = (Player)this[num];
					if (player7.preferredposition1 == role.Id)
					{
						playerList.Add(player7);
					}
				}
				return playerList;
			}
			if (filter.GetType().Name == "SpecificHead")
			{
				for (int num2 = 0; num2 < this.Count; num2++)
				{
					Player player8 = (Player)this[num2];
					if (player8.HasSpecificHeadModel)
					{
						playerList.Add(player8);
					}
				}
				return playerList;
			}
			return this;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000365D0 File Offset: 0x000347D0
		public override IdArrayList Filter(IdObject filter, bool excludeYoung)
		{
			ArrayList arrayList = (PlayerList)this.Filter(filter);
			PlayerList playerList = new PlayerList();
			foreach (object obj in arrayList)
			{
				Player player = (Player)obj;
				if (player.Id < 400000 || !excludeYoung)
				{
					playerList.Add(player);
				}
			}
			return playerList;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000202ED File Offset: 0x0001E4ED
		public bool DeletePlayer(Player player)
		{
			return base.RemoveId(player);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00036648 File Offset: 0x00034848
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				((Player)obj).LinkCountry(countryList);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0003669C File Offset: 0x0003489C
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				((Player)obj).LinkTeam(teamList);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000366F0 File Offset: 0x000348F0
		public int SetGenericAudio(string lastname, int commentaryid)
		{
			int num = 0;
			foreach (object obj in this)
			{
				Player player = (Player)obj;
				if (player.audioname == lastname)
				{
					player.commentaryid = commentaryid;
					num++;
				}
			}
			return num;
		}

		// Token: 0x020000BB RID: 187
		public class FreeAgent : IdObject
		{
			// Token: 0x06000FE6 RID: 4070 RVA: 0x0002C207 File Offset: 0x0002A407
			public override string ToString()
			{
				return "Free Agents";
			}
		}

		// Token: 0x020000BC RID: 188
		public class FreeAgentList : IdArrayList
		{
			// Token: 0x06000FE7 RID: 4071 RVA: 0x0005E100 File Offset: 0x0005C300
			public FreeAgentList()
				: base(typeof(PlayerList.FreeAgent))
			{
				this.Clear();
				this.Add(new PlayerList.FreeAgent());
			}
		}

		// Token: 0x020000BD RID: 189
		public class MultiClub : IdObject
		{
			// Token: 0x06000FE9 RID: 4073 RVA: 0x0002C232 File Offset: 0x0002A432
			public override string ToString()
			{
				return "Multi Clubs";
			}
		}

		// Token: 0x020000BE RID: 190
		public class MultiClubList : IdArrayList
		{
			// Token: 0x06000FEA RID: 4074 RVA: 0x0005E124 File Offset: 0x0005C324
			public MultiClubList()
				: base(typeof(PlayerList.MultiClub))
			{
				this.Clear();
				this.Add(new PlayerList.MultiClub());
			}
		}

		// Token: 0x020000BF RID: 191
		public class SpecificHead : IdObject
		{
			// Token: 0x06000FEC RID: 4076 RVA: 0x0002C25D File Offset: 0x0002A45D
			public override string ToString()
			{
				return "Specific Head";
			}
		}

		// Token: 0x020000C0 RID: 192
		public class SpecificHeadList : IdArrayList
		{
			// Token: 0x06000FED RID: 4077 RVA: 0x0005E148 File Offset: 0x0005C348
			public SpecificHeadList()
				: base(typeof(PlayerList.SpecificHead))
			{
				this.Clear();
				this.Add(new PlayerList.SpecificHead());
			}
		}
	}
}
