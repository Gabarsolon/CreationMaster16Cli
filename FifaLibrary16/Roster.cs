using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000084 RID: 132
	public class Roster : ArrayList
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x0004622A File Offset: 0x0004442A
		public void SortRoster()
		{
			this.Sort(this.m_Comparer);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00046238 File Offset: 0x00044438
		public Roster(int capacity)
		{
			this.Capacity = capacity;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00046254 File Offset: 0x00044454
		public Player SearchPlayer(int playerid)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (playerid == ((TeamPlayer)this[i]).Player.Id)
				{
					return ((TeamPlayer)this[i]).Player;
				}
			}
			return null;
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000462A0 File Offset: 0x000444A0
		public TeamPlayer SearchTeamPlayer(Player player)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (player == teamPlayer.Player)
				{
					return teamPlayer;
				}
			}
			return null;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00046300 File Offset: 0x00044500
		public int GetTeamPosition(Player player)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (player == teamPlayer.Player)
				{
					return teamPlayer.position;
				}
			}
			return 29;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00046364 File Offset: 0x00044564
		public int GetTeamPosition(int playerId)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (playerId == teamPlayer.Player.Id)
				{
					return teamPlayer.position;
				}
			}
			return 29;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000463CC File Offset: 0x000445CC
		public TeamPlayer SearchTeamPlayer(Role role)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (role.Id == teamPlayer.position)
				{
					return teamPlayer;
				}
			}
			return null;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00046430 File Offset: 0x00044630
		public TeamPlayer GetRoleBestPlayer(ERole requestedRole)
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(requestedRole);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000464A0 File Offset: 0x000446A0
		public TeamPlayer GetRoleBestTitolar(ERole requestedRole)
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null && teamPlayer2.position < 28)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(requestedRole);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0004651C File Offset: 0x0004471C
		public TeamPlayer GetBestTitolar()
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null && teamPlayer2.position < 28)
				{
					int overallrating = teamPlayer2.Player.overallrating;
					if (overallrating > num)
					{
						num = overallrating;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00046598 File Offset: 0x00044798
		public TeamPlayer GetBestPlayer()
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null)
				{
					int averageRoleAttribute = teamPlayer2.Player.GetAverageRoleAttribute();
					if (averageRoleAttribute > num)
					{
						num = averageRoleAttribute;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00046608 File Offset: 0x00044808
		public bool IsNumberFree(int n)
		{
			if (n < 1 || n > 99)
			{
				return false;
			}
			IEnumerator enumerator = this.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if (((TeamPlayer)enumerator.Current).m_jerseynumber == n)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00046670 File Offset: 0x00044870
		public TeamPlayer IsNumberUsed(int n)
		{
			if (n < 1 || n > 99)
			{
				return null;
			}
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (teamPlayer.m_jerseynumber == n)
				{
					return teamPlayer;
				}
			}
			return null;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000466D8 File Offset: 0x000448D8
		public int GetFreeNumber()
		{
			for (int i = 1; i < 99; i++)
			{
				if (this.IsNumberFree(i))
				{
					return i;
				}
			}
			return 99;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00046700 File Offset: 0x00044900
		public string[] GetFreeNumbers()
		{
			string[] array = new string[99];
			int num = 0;
			for (int i = 1; i < 100; i++)
			{
				if (this.IsNumberFree(i))
				{
					array[num] = i.ToString();
					num++;
				}
			}
			Array.Resize<string>(ref array, num);
			return array;
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00046744 File Offset: 0x00044944
		public void ChangeRole(Role oldRole, Role newRole)
		{
			TeamPlayer teamPlayer = this.SearchTeamPlayer(oldRole);
			if (teamPlayer != null)
			{
				teamPlayer.position = newRole.Id;
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00046768 File Offset: 0x00044968
		public int EstimateOverall()
		{
			int[] array = new int[17];
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				array[i] = 0;
			}
			foreach (object obj in this)
			{
				int overallrating = ((TeamPlayer)obj).Player.overallrating;
				int j = 0;
				while (j < 16)
				{
					if (overallrating > array[j])
					{
						for (int k = num; k > j; k--)
						{
							array[k] = array[k - 1];
						}
						array[j] = overallrating;
						if (num < 16)
						{
							num++;
							break;
						}
						break;
					}
					else
					{
						j++;
					}
				}
			}
			int num2 = 0;
			for (int l = 0; l < num; l++)
			{
				num2 += array[l];
			}
			if (num != 0)
			{
				num2 /= num;
			}
			else
			{
				num2 = 50;
			}
			return num2;
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00046850 File Offset: 0x00044A50
		public void ResetToEmpty()
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				teamPlayer.Player.NotPlayFor(teamPlayer.Team);
			}
			this.Clear();
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000468B4 File Offset: 0x00044AB4
		public void PresetToEmpty(Formation formation, Player[] players)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				teamPlayer.Player.NotPlayFor(teamPlayer.Team);
			}
			this.Clear();
			foreach (Player player in players)
			{
				TeamPlayer teamPlayer2 = new TeamPlayer(player);
				if (player.preferredNumber != 0)
				{
					teamPlayer2.jerseynumber = player.preferredNumber;
				}
				else
				{
					teamPlayer2.jerseynumber = this.GetFreeNumber();
				}
			}
		}

		// Token: 0x040010DB RID: 4315
		private RosterComparer m_Comparer = new RosterComparer();
	}
}
