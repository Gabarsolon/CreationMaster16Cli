using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200009D RID: 157
	public class CompetitionSettings
	{
		// Token: 0x06000E6C RID: 3692 RVA: 0x0004FD08 File Offset: 0x0004DF08
		public void GetInfoColorSlotChampCup(out int min, out int max)
		{
			if (this.m_N_info_color_slot_champ_cup == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_champ_cup[0];
			max = this.m_info_color_slot_champ_cup[this.m_N_info_color_slot_champ_cup - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0004FD50 File Offset: 0x0004DF50
		public bool SetInfoColorSlotChampCup(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_champ_cup = 0;
				this.m_info_color_slot_champ_cup[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_champ_cup.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_champ_cup[i] = min + i;
					this.m_N_info_color_slot_champ_cup = i + 1;
				}
				else
				{
					this.m_info_color_slot_champ_cup[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0004FDB4 File Offset: 0x0004DFB4
		public void GetInfoColorSlotEuroLeague(out int min, out int max)
		{
			if (this.m_N_info_color_slot_euro_league == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_euro_league[0];
			max = this.m_info_color_slot_euro_league[this.m_N_info_color_slot_euro_league - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0004FDFC File Offset: 0x0004DFFC
		public bool SetInfoColorSlotEuroLeague(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_euro_league = 0;
				this.m_info_color_slot_euro_league[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_euro_league.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_euro_league[i] = min + i;
					this.m_N_info_color_slot_euro_league = i + 1;
				}
				else
				{
					this.m_info_color_slot_euro_league[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0004FE60 File Offset: 0x0004E060
		public void GetInfoColorSlotPromo(out int min, out int max)
		{
			if (this.m_N_info_color_slot_promo == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_promo[0];
			max = this.m_info_color_slot_promo[this.m_N_info_color_slot_promo - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public bool SetInfoColorSlotPromo(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_promo = 0;
				this.m_info_color_slot_promo[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_promo.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_promo[i] = min + i;
					this.m_N_info_color_slot_promo = i + 1;
				}
				else
				{
					this.m_info_color_slot_promo[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0004FF0C File Offset: 0x0004E10C
		public void GetInfoColorSlotPromoPoss(out int min, out int max)
		{
			if (this.m_N_info_color_slot_promo_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_promo_poss[0];
			max = this.m_info_color_slot_promo_poss[this.m_N_info_color_slot_promo_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0004FF54 File Offset: 0x0004E154
		public bool SetInfoColorSlotPromoPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_promo_poss = 0;
				this.m_info_color_slot_promo_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_promo_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_promo_poss[i] = min + i;
					this.m_N_info_color_slot_promo_poss = i + 1;
				}
				else
				{
					this.m_info_color_slot_promo_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		public void GetInfoColorSlotReleg(out int min, out int max)
		{
			if (this.m_N_info_color_slot_releg == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_releg[0];
			max = this.m_info_color_slot_releg[this.m_N_info_color_slot_releg - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00050000 File Offset: 0x0004E200
		public bool SetInfoColorSlotReleg(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_releg = 0;
				this.m_info_color_slot_releg[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_releg.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_releg[i] = min + i;
					this.m_N_info_color_slot_releg = i + 1;
				}
				else
				{
					this.m_info_color_slot_releg[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00050064 File Offset: 0x0004E264
		public void GetInfoColorSlotRelegPoss(out int min, out int max)
		{
			if (this.m_N_info_color_slot_releg_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_releg_poss[0];
			max = this.m_info_color_slot_releg_poss[this.m_N_info_color_slot_releg_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000500AC File Offset: 0x0004E2AC
		public bool SetInfoColorSlotRelegPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_releg_poss = 0;
				this.m_info_color_slot_releg_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_releg_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_releg_poss[i] = min + i;
					this.m_N_info_color_slot_releg_poss = i + 1;
				}
				else
				{
					this.m_info_color_slot_releg_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00050110 File Offset: 0x0004E310
		public void GetInfoColorSlotAdvGroup(out int min, out int max)
		{
			if (this.m_N_info_color_slot_adv_group == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_color_slot_adv_group[0];
			max = this.m_info_color_slot_adv_group[this.m_N_info_color_slot_adv_group - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00050158 File Offset: 0x0004E358
		public bool SetInfoColorSlotAdvGroup(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_color_slot_adv_group = 0;
				this.m_info_color_slot_adv_group[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_color_slot_adv_group.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_color_slot_adv_group[i] = min + i;
					this.m_N_info_color_slot_adv_group = i + 1;
				}
				else
				{
					this.m_info_color_slot_adv_group[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000501BC File Offset: 0x0004E3BC
		public void GetInfoSlotPromo(out int min, out int max)
		{
			if (this.m_N_info_slot_promo == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_promo[0];
			max = this.m_info_slot_promo[this.m_N_info_slot_promo - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00050204 File Offset: 0x0004E404
		public bool SetInfoSlotPromo(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_promo = 0;
				this.m_info_slot_promo[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_promo.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_promo[i] = min + i;
					this.m_N_info_slot_promo = i + 1;
				}
				else
				{
					this.m_info_slot_promo[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00050268 File Offset: 0x0004E468
		public void GetInfoSlotPromoPoss(out int min, out int max)
		{
			if (this.m_N_info_slot_promo_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_promo_poss[0];
			max = this.m_info_slot_promo_poss[this.m_N_info_slot_promo_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000502B0 File Offset: 0x0004E4B0
		public bool SetInfoSlotPromoPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_promo_poss = 0;
				this.m_info_slot_promo_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_promo_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_promo_poss[i] = min + i;
					this.m_N_info_slot_promo_poss = i + 1;
				}
				else
				{
					this.m_info_slot_promo_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00050314 File Offset: 0x0004E514
		public void GetInfoSlotReleg(out int min, out int max)
		{
			if (this.m_N_info_slot_releg == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_releg[0];
			max = this.m_info_slot_releg[this.m_N_info_slot_releg - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0005035C File Offset: 0x0004E55C
		public bool SetInfoSlotReleg(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_releg = 0;
				this.m_info_slot_releg[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_releg.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_releg[i] = min + i;
					this.m_N_info_slot_releg = i + 1;
				}
				else
				{
					this.m_info_slot_releg[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000503C0 File Offset: 0x0004E5C0
		public void GetInfoSlotRelegPoss(out int min, out int max)
		{
			if (this.m_N_info_slot_releg_poss == 0)
			{
				min = -1;
				max = -1;
				return;
			}
			min = this.m_info_slot_releg_poss[0];
			max = this.m_info_slot_releg_poss[this.m_N_info_slot_releg_poss - 1];
			if (min > max)
			{
				int num = min;
				min = max;
				max = num;
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00050408 File Offset: 0x0004E608
		public bool SetInfoSlotRelegPoss(int min, int max)
		{
			if (min == -1 || max == -1 || min > max)
			{
				this.m_N_info_slot_releg_poss = 0;
				this.m_info_slot_releg_poss[0] = -1;
				return true;
			}
			for (int i = 0; i < this.m_info_slot_releg_poss.Length; i++)
			{
				if (min + i <= max)
				{
					this.m_info_slot_releg_poss[i] = min + i;
					this.m_N_info_slot_releg_poss = i + 1;
				}
				else
				{
					this.m_info_slot_releg_poss[i] = -1;
				}
			}
			return true;
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0005046C File Offset: 0x0004E66C
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x000504A0 File Offset: 0x0004E6A0
		public Trophy TrophyCompdependency
		{
			get
			{
				if (this.m_TrophyCompdependency == null && this.m_schedule_compdependency != -1)
				{
					this.m_TrophyCompdependency = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_schedule_compdependency);
				}
				return this.m_TrophyCompdependency;
			}
			set
			{
				this.m_TrophyCompdependency = value;
				this.m_schedule_compdependency = ((this.m_TrophyCompdependency != null) ? this.m_TrophyCompdependency.Id : (-1));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000504C8 File Offset: 0x0004E6C8
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00050515 File Offset: 0x0004E715
		public Trophy TrophyForcecomp
		{
			get
			{
				if (this.m_TrophyForcecomp == null && this.m_schedule_forcecomp != -1)
				{
					IdObject idObject = FifaEnvironment.CompetitionObjects.SearchId(this.m_schedule_forcecomp);
					if (idObject != null)
					{
						this.m_TrophyForcecomp = (Trophy)idObject;
					}
					else
					{
						this.m_TrophyForcecomp = null;
					}
				}
				return this.m_TrophyForcecomp;
			}
			set
			{
				this.m_TrophyForcecomp = value;
				this.m_schedule_forcecomp = ((this.m_TrophyForcecomp != null) ? this.m_TrophyForcecomp.Id : (-1));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0005053A File Offset: 0x0004E73A
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00050542 File Offset: 0x0004E742
		public int Advance_pointskeep
		{
			get
			{
				return this.m_advance_pointskeep;
			}
			set
			{
				this.m_advance_pointskeep = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00050551 File Offset: 0x0004E751
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00050559 File Offset: 0x0004E759
		public int Advance_maxteamsstageref
		{
			get
			{
				return this.m_advance_maxteamsstageref;
			}
			set
			{
				this.m_advance_maxteamsstageref = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00050568 File Offset: 0x0004E768
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00050570 File Offset: 0x0004E770
		public int Advance_standingskeep
		{
			get
			{
				return this.m_advance_standingskeep;
			}
			set
			{
				this.m_advance_standingskeep = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0005057F File Offset: 0x0004E77F
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00050587 File Offset: 0x0004E787
		public int Advance_standingsrank
		{
			get
			{
				return this.m_advance_standingsrank;
			}
			set
			{
				this.m_advance_standingsrank = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00050596 File Offset: 0x0004E796
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0005059E File Offset: 0x0004E79E
		public int Standings_checkrank
		{
			get
			{
				return this.m_standings_checkrank;
			}
			set
			{
				this.m_standings_checkrank = value;
				this.UpdateStageReferenceUsingId();
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x000505AD File Offset: 0x0004E7AD
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x000505B5 File Offset: 0x0004E7B5
		public League LeaguePromo
		{
			get
			{
				return this.m_LeaguePromo;
			}
			set
			{
				this.m_LeaguePromo = value;
				this.m_info_league_promo = ((this.m_LeaguePromo != null) ? this.m_LeaguePromo.Id : (-1));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000505DA File Offset: 0x0004E7DA
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x000505E2 File Offset: 0x0004E7E2
		public League LeagueReleg
		{
			get
			{
				return this.m_LeagueReleg;
			}
			set
			{
				this.m_LeagueReleg = value;
				this.m_info_league_releg = ((this.m_LeagueReleg != null) ? this.m_LeagueReleg.Id : (-1));
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00050608 File Offset: 0x0004E808
		public CompetitionSettings(Compobj compobj)
		{
			this.m_OwnerCompObj = compobj;
			if (compobj.ParentObj != null)
			{
				this.m_ParentSettings = compobj.ParentObj.Settings;
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00050854 File Offset: 0x0004EA54
		public void SetProperty(string property, int index, string val)
		{
			if (index == 0)
			{
				this.LoadProperty(property, val);
				return;
			}
			if (property == "match_endruleko1leg")
			{
				if (index < this.m_match_endruleko1leg.Length)
				{
					this.m_match_endruleko1leg[index] = val;
					return;
				}
			}
			else if (property == "match_endruleko2leg2")
			{
				if (index < this.m_match_endruleko2leg2.Length)
				{
					this.m_match_endruleko2leg2[index] = val;
					return;
				}
			}
			else if (property == "standings_sort")
			{
				if (index < this.m_standings_sort.Length)
				{
					this.m_standings_sort[index] = val;
					return;
				}
			}
			else if (property == "info_slot_promo")
			{
				if (index < this.m_info_slot_promo.Length)
				{
					this.m_info_slot_promo[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (index < this.m_info_slot_promo_poss.Length)
				{
					this.m_info_slot_promo_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_releg")
			{
				if (index < this.m_info_slot_releg.Length)
				{
					this.m_info_slot_releg[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (index < this.m_info_slot_releg_poss.Length)
				{
					this.m_info_slot_releg_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (index < this.m_info_color_slot_champ_cup.Length)
				{
					this.m_info_color_slot_champ_cup[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (index < this.m_info_color_slot_euro_league.Length)
				{
					this.m_info_color_slot_euro_league[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (index < this.m_info_color_slot_promo.Length)
				{
					this.m_info_color_slot_promo[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (index < this.m_info_color_slot_promo_poss.Length)
				{
					this.m_info_color_slot_promo_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (index < this.m_info_color_slot_releg.Length)
				{
					this.m_info_color_slot_releg[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (index < this.m_info_color_slot_releg_poss.Length)
				{
					this.m_info_color_slot_releg_poss[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "match_stadium")
			{
				if (this.m_match_stadium == null)
				{
					this.m_match_stadium = new int[12];
					for (int i = 0; i < this.m_match_stadium.Length; i++)
					{
						this.m_match_stadium[i] = -1;
					}
				}
				if (index < this.m_match_stadium.Length)
				{
					this.m_match_stadium[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_color_slot_adv_group")
			{
				if (index < this.m_info_color_slot_adv_group.Length)
				{
					this.m_info_color_slot_adv_group[index] = Convert.ToInt32(val);
					return;
				}
			}
			else if (property == "info_special_team_id" && index < this.m_info_special_team_id.Length)
			{
				this.m_info_special_team_id[index] = Convert.ToInt32(val);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00050B28 File Offset: 0x0004ED28
		public void UpdateIdUsingStageReference()
		{
			this.m_advance_maxteamsstageref = ((this.m_StageAdvanceMaxteamsStageRef != null) ? this.m_StageAdvanceMaxteamsStageRef.Id : (-1));
			this.m_advance_standingskeep = ((this.m_StageAdvanceStandingsKeep != null) ? this.m_StageAdvanceStandingsKeep.Id : (-1));
			this.m_advance_standingsrank = ((this.m_StageAdvanceStandingsRank != null) ? this.m_StageAdvanceStandingsRank.Id : (-1));
			this.m_standings_checkrank = ((this.m_StageStandingsCheckRank != null) ? this.m_StageStandingsCheckRank.Id : (-1));
			this.m_advance_pointskeep = ((this.m_StageAdvancePointsKeep != null) ? this.m_StageAdvancePointsKeep.Id : (-1));
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00050BC4 File Offset: 0x0004EDC4
		public void UpdateStageReferenceUsingId()
		{
			if (FifaEnvironment.CompetitionObjects == null)
			{
				return;
			}
			Compobj compobj;
			if (this.m_standings_checkrank == -1)
			{
				this.m_StageStandingsCheckRank = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_standings_checkrank);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageStandingsCheckRank = (Stage)compobj;
				}
				else
				{
					this.m_StageStandingsCheckRank = null;
				}
			}
			if (this.m_advance_standingsrank == -1)
			{
				this.m_StageAdvanceStandingsRank = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_standingsrank);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageAdvanceStandingsRank = (Stage)compobj;
				}
				else
				{
					this.m_StageAdvanceStandingsRank = null;
				}
			}
			if (this.m_advance_standingskeep == -1)
			{
				this.m_StageAdvanceStandingsKeep = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_standingskeep);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageAdvanceStandingsKeep = (Stage)compobj;
				}
				else
				{
					this.m_StageAdvanceStandingsKeep = null;
				}
			}
			if (this.m_advance_pointskeep == -1)
			{
				this.m_StageAdvancePointsKeep = null;
			}
			else
			{
				compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_pointskeep);
				if (compobj != null && compobj.IsStage())
				{
					this.m_StageAdvancePointsKeep = (Stage)compobj;
				}
				else
				{
					this.m_StageAdvancePointsKeep = null;
				}
			}
			if (this.m_advance_maxteamsstageref == -1)
			{
				this.m_StageAdvanceMaxteamsStageRef = null;
				return;
			}
			compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_advance_maxteamsstageref);
			if (compobj != null && compobj.IsStage())
			{
				this.m_StageAdvanceMaxteamsStageRef = (Stage)compobj;
				return;
			}
			this.m_StageAdvanceMaxteamsStageRef = null;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00050D44 File Offset: 0x0004EF44
		public bool IsStringProperty(string property)
		{
			return property == "comp_type" || property == "rule_bookings" || property == "rule_offsides" || property == "rule_injuries" || property == "match_stagetype" || property == "match_matchsituation" || property == "match_endruleleague" || property == "match_endruleko1leg" || property == "match_endruleko2leg1" || property == "match_endruleko2leg2" || property == "match_endrulefriendly" || property == "match_canusefancards" || property == "standings_sort" || property == "schedule_seasonstartmonth";
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00050E24 File Offset: 0x0004F024
		public int IsMultipleProperty(string property)
		{
			if (property == "match_endruleko1leg")
			{
				return this.m_match_endruleko1leg.Length;
			}
			if (property == "match_endruleko2leg2")
			{
				return this.m_match_endruleko2leg2.Length;
			}
			if (property == "standings_sort")
			{
				return this.m_standings_sort.Length;
			}
			if (property == "info_slot_promo")
			{
				return this.m_info_slot_promo.Length;
			}
			if (property == "info_slot_promo_poss")
			{
				return this.m_info_slot_promo_poss.Length;
			}
			if (property == "info_slot_releg")
			{
				return this.m_info_slot_releg.Length;
			}
			if (property == "info_slot_releg_poss")
			{
				return this.m_info_slot_releg_poss.Length;
			}
			if (property == "info_color_slot_champ_cup")
			{
				return this.m_info_color_slot_champ_cup.Length;
			}
			if (property == "info_color_slot_euro_league")
			{
				return this.m_info_color_slot_euro_league.Length;
			}
			if (property == "info_color_slot_promo")
			{
				return this.m_info_color_slot_promo.Length;
			}
			if (property == "info_color_slot_promo_poss")
			{
				return this.m_info_color_slot_promo_poss.Length;
			}
			if (property == "info_color_slot_releg")
			{
				return this.m_info_color_slot_releg.Length;
			}
			if (property == "info_color_slot_releg_poss")
			{
				return this.m_info_color_slot_releg_poss.Length;
			}
			if (property == "match_stadium")
			{
				return this.m_match_stadium.Length;
			}
			if (property == "info_color_slot_adv_group")
			{
				return this.m_info_color_slot_adv_group.Length;
			}
			if (property == "info_special_team_id")
			{
				return this.m_info_special_team_id.Length;
			}
			return 1;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00050F94 File Offset: 0x0004F194
		public string GetProperty(string property, int index, out bool isSpecific)
		{
			string text = this.GetSpecificProperty(property, index);
			isSpecific = false;
			if (text != null && text != "-1")
			{
				isSpecific = true;
				return text;
			}
			if (this.m_ParentSettings != null)
			{
				bool flag;
				text = this.m_ParentSettings.GetProperty(property, index, out flag);
			}
			if (text == null)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00050FE4 File Offset: 0x0004F1E4
		public void LoadProperty(string property, string val)
		{
			if (property == "comp_type")
			{
				this.m_comp_type = val;
				return;
			}
			if (property == "rule_bookings")
			{
				this.m_rule_bookings = val;
				return;
			}
			if (property == "rule_offsides")
			{
				this.m_rule_offsides = val;
				return;
			}
			if (property == "rule_injuries")
			{
				this.m_rule_injuries = val;
				return;
			}
			if (property == "rule_numsubsbench")
			{
				this.m_rule_numsubsbench = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numsubsmatch")
			{
				this.m_rule_numsubsmatch = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_suspension")
			{
				this.m_rule_suspension = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numyellowstored")
			{
				this.m_rule_numyellowstored = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanredmax")
			{
				this.m_rule_numgamesbanredmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanredmin")
			{
				this.m_rule_numgamesbanredmin = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbandoubleyellowmax")
			{
				this.m_rule_numgamesbandoubleyellowmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbandoubleyellowmin")
			{
				this.m_rule_numgamesbandoubleyellowmin = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanyellowsmax")
			{
				this.m_rule_numgamesbanyellowsmax = Convert.ToInt32(val);
				return;
			}
			if (property == "rule_numgamesbanyellowsmin")
			{
				this.m_rule_numgamesbanyellowsmin = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointswin")
			{
				this.m_standings_pointswin = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointsdraw")
			{
				this.m_standings_pointsdraw = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_pointsloss")
			{
				this.m_standings_pointsloss = Convert.ToInt32(val);
				return;
			}
			if (property == "match_matchimportance")
			{
				this.m_match_matchimportance = Convert.ToInt32(val);
				return;
			}
			if (property == "match_stagetype")
			{
				this.m_match_stagetype = val;
				return;
			}
			if (property == "match_matchsituation")
			{
				this.m_match_matchsituation = val;
				return;
			}
			if (property == "nation_id")
			{
				this.m_nation_id = Convert.ToInt32(val);
				return;
			}
			if (property == "asset_id")
			{
				this.m_asset_id = Convert.ToInt32(val);
				return;
			}
			if (property == "match_endruleleague")
			{
				this.m_match_endruleleague = val;
				return;
			}
			if (property == "match_endruleko1leg")
			{
				this.m_match_endruleko1leg[this.m_N_endruleko1leg] = val;
				this.m_N_endruleko1leg++;
				this.m_EndRuleKo1Leg = CompetitionSettings.GetKo1Rule(this.m_match_endruleko1leg);
				return;
			}
			if (property == "match_endruleko2leg1")
			{
				this.m_match_endruleko2leg1 = val;
				return;
			}
			if (property == "match_endruleko2leg2")
			{
				this.m_match_endruleko2leg2[this.m_N_endruleko2leg2] = val;
				this.m_N_endruleko2leg2++;
				this.m_EndRuleKo2Leg2 = CompetitionSettings.GetKo2Rule(this.m_match_endruleko2leg2);
				return;
			}
			if (property == "match_endrulefriendly")
			{
				this.m_match_endrulefriendly = val;
				return;
			}
			if (property == "match_canusefancards")
			{
				this.m_match_canusefancards = val;
				return;
			}
			if (property == "match_celebrationlevel")
			{
				this.m_match_celebrationlevel = val;
				return;
			}
			if (property == "info_prize_money")
			{
				this.m_info_prize_money = Convert.ToInt32(val);
				return;
			}
			if (property == "info_prize_money_drop")
			{
				this.m_info_prize_money_drop = Convert.ToInt32(val);
				return;
			}
			if (property == "standings_sort")
			{
				this.m_standings_sort[this.m_N_standings_sort] = val;
				this.m_N_standings_sort++;
				this.m_StandingsSort = CompetitionSettings.GetStandingRule(this.m_standings_sort);
				return;
			}
			if (property == "schedule_seasonstartmonth")
			{
				this.m_schedule_seasonstartmonth = val;
				return;
			}
			if (property == "schedule_year_start")
			{
				this.m_schedule_year_start = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_year_offset")
			{
				this.m_schedule_year_offset = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_friendlydaysbetweenmin")
			{
				this.m_schedule_friendlydaysbetweenmin = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_friendlydaysbefore")
			{
				this.m_schedule_friendlydaysbefore = Convert.ToInt32(val);
				return;
			}
			if (property == "schedule_use_dates_comp")
			{
				this.m_schedule_use_dates_comp = Convert.ToInt32(val);
				return;
			}
			if (property == "info_slot_champ")
			{
				this.m_info_slot_champ = Convert.ToInt32(val);
				return;
			}
			if (property == "info_color_slot_champ")
			{
				this.m_info_color_slot_champ = Convert.ToInt32(val);
				return;
			}
			if (property == "info_slot_promo")
			{
				if (this.m_info_slot_promo == null)
				{
					this.m_info_slot_promo = new int[4];
				}
				if (this.m_N_info_slot_promo < this.m_info_slot_promo.Length)
				{
					this.m_info_slot_promo[this.m_N_info_slot_promo] = Convert.ToInt32(val);
					this.m_N_info_slot_promo++;
					return;
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (this.m_info_slot_promo_poss == null)
				{
					this.m_info_slot_promo_poss = new int[4];
				}
				if (this.m_N_info_slot_promo_poss < this.m_info_slot_promo_poss.Length)
				{
					this.m_info_slot_promo_poss[this.m_N_info_slot_promo_poss] = Convert.ToInt32(val);
					this.m_N_info_slot_promo_poss++;
					return;
				}
			}
			else if (property == "info_slot_releg")
			{
				if (this.m_info_slot_releg == null)
				{
					this.m_info_slot_releg = new int[4];
				}
				if (this.m_N_info_slot_releg < this.m_info_slot_releg.Length)
				{
					this.m_info_slot_releg[this.m_N_info_slot_releg] = Convert.ToInt32(val);
					this.m_N_info_slot_releg++;
					return;
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (this.m_info_slot_releg_poss == null)
				{
					this.m_info_slot_releg_poss = new int[4];
				}
				if (this.m_N_info_slot_releg_poss < this.m_info_slot_releg_poss.Length)
				{
					this.m_info_slot_releg_poss[this.m_N_info_slot_releg_poss] = Convert.ToInt32(val);
					this.m_N_info_slot_releg_poss++;
					return;
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (this.m_info_color_slot_champ_cup == null)
				{
					this.m_info_color_slot_champ_cup = new int[3];
				}
				if (this.m_N_info_color_slot_champ_cup < this.m_info_color_slot_champ_cup.Length)
				{
					this.m_info_color_slot_champ_cup[this.m_N_info_color_slot_champ_cup] = Convert.ToInt32(val);
					this.m_N_info_color_slot_champ_cup++;
					return;
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (this.m_info_color_slot_euro_league == null)
				{
					this.m_info_color_slot_euro_league = new int[4];
				}
				if (this.m_N_info_color_slot_euro_league < this.m_info_color_slot_euro_league.Length)
				{
					this.m_info_color_slot_euro_league[this.m_N_info_color_slot_euro_league] = Convert.ToInt32(val);
					this.m_N_info_color_slot_euro_league++;
					return;
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (this.m_info_color_slot_promo == null)
				{
					this.m_info_color_slot_promo = new int[4];
				}
				if (this.m_N_info_color_slot_promo < this.m_info_color_slot_promo.Length)
				{
					this.m_info_color_slot_promo[this.m_N_info_color_slot_promo] = Convert.ToInt32(val);
					this.m_N_info_color_slot_promo++;
					return;
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (this.m_info_color_slot_promo_poss == null)
				{
					this.m_info_color_slot_promo_poss = new int[4];
				}
				if (this.m_N_info_color_slot_promo_poss < this.m_info_color_slot_promo_poss.Length)
				{
					this.m_info_color_slot_promo_poss[this.m_N_info_color_slot_promo_poss] = Convert.ToInt32(val);
					this.m_N_info_color_slot_promo_poss++;
					return;
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (this.m_info_color_slot_releg == null)
				{
					this.m_info_color_slot_releg = new int[4];
				}
				if (this.m_N_info_color_slot_releg < this.m_info_color_slot_releg.Length)
				{
					this.m_info_color_slot_releg[this.m_N_info_color_slot_releg] = Convert.ToInt32(val);
					this.m_N_info_color_slot_releg++;
					return;
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (this.m_info_color_slot_releg_poss == null)
				{
					this.m_info_color_slot_releg_poss = new int[4];
				}
				if (this.m_N_info_color_slot_releg_poss < this.m_info_color_slot_releg_poss.Length)
				{
					this.m_info_color_slot_releg_poss[this.m_N_info_color_slot_releg_poss] = Convert.ToInt32(val);
					this.m_N_info_color_slot_releg_poss++;
					return;
				}
			}
			else
			{
				if (property == "num_games")
				{
					this.m_num_games = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_pointskeep")
				{
					this.m_advance_pointskeep = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_pointskeeppercentage")
				{
					this.m_advance_pointskeeppercentage = Convert.ToInt32(val);
					return;
				}
				if (property == "advance_matchupkeep")
				{
					this.m_advance_matchupkeep = Convert.ToInt32(val);
					return;
				}
				if (property == "match_stadium")
				{
					if (this.m_match_stadium == null)
					{
						this.m_match_stadium = new int[12];
						for (int i = 0; i < this.m_match_stadium.Length; i++)
						{
							this.m_match_stadium[i] = -1;
						}
						this.m_N_match_stadium = 0;
					}
					if (this.m_N_match_stadium < this.m_match_stadium.Length)
					{
						this.m_match_stadium[this.m_N_match_stadium] = Convert.ToInt32(val);
						this.m_N_match_stadium++;
						return;
					}
				}
				else if (property == "info_color_slot_adv_group")
				{
					if (this.m_info_color_slot_adv_group == null)
					{
						this.m_info_color_slot_adv_group = new int[8];
					}
					if (this.m_N_info_color_slot_adv_group < this.m_info_color_slot_adv_group.Length)
					{
						this.m_info_color_slot_adv_group[this.m_N_info_color_slot_adv_group] = Convert.ToInt32(val);
						this.m_N_info_color_slot_adv_group++;
						return;
					}
				}
				else
				{
					if (property == "advance_standingsrank")
					{
						this.Advance_standingsrank = Convert.ToInt32(val);
						return;
					}
					if (property == "asset_id")
					{
						this.m_asset_id = Convert.ToInt32(val);
						return;
					}
					if (property == "rule_numsubsmatch")
					{
						this.m_rule_numsubsmatch = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_checkconflict")
					{
						this.m_schedule_checkconflict = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_compdependency")
					{
						this.m_schedule_compdependency = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_internationaldependency")
					{
						this.m_schedule_internationaldependency = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_forcecomp")
					{
						this.m_schedule_forcecomp = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_teamcompdependency")
					{
						this.m_advance_teamcompdependency = Convert.ToInt32(val);
						return;
					}
					if (property == "info_league_promo")
					{
						this.m_info_league_promo = Convert.ToInt32(val);
						return;
					}
					if (property == "info_league_releg")
					{
						this.m_info_league_releg = Convert.ToInt32(val);
						return;
					}
					if (property == "info_special_team_id" && this.m_N_info_special_team_id < this.m_info_special_team_id.Length)
					{
						this.m_info_special_team_id[this.m_N_info_special_team_id] = Convert.ToInt32(val);
						this.m_N_info_special_team_id++;
						return;
					}
					if (property == "advance_random_draw_event")
					{
						this.m_advance_random_draw_event = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_randomdraw")
					{
						this.m_advance_randomdraw = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_calccompavgs")
					{
						this.m_advance_calccompavgs = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsassoc")
					{
						this.m_advance_maxteamsassoc = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsgroup")
					{
						this.m_advance_maxteamsgroup = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_maxteamsstageref")
					{
						this.Advance_maxteamsstageref = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_standingskeep")
					{
						this.Advance_standingskeep = Convert.ToInt32(val);
						return;
					}
					if (property == "advance_standingsrank")
					{
						this.Advance_standingsrank = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_matchreplay")
					{
						this.m_schedule_matchreplay = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_reversed")
					{
						this.m_schedule_reversed = Convert.ToInt32(val);
						return;
					}
					if (property == "schedule_year_real")
					{
						this.m_schedule_year_real = Convert.ToInt32(val);
						return;
					}
					if (property == "standings_checkrank")
					{
						this.Standings_checkrank = Convert.ToInt32(val);
					}
				}
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00051B38 File Offset: 0x0004FD38
		public string GetSpecificProperty(string property, int index)
		{
			if (property == "comp_type")
			{
				return this.m_comp_type;
			}
			if (property == "rule_bookings")
			{
				return this.m_rule_bookings;
			}
			if (property == "rule_offsides")
			{
				return this.m_rule_offsides;
			}
			if (property == "rule_injuries")
			{
				return this.m_rule_injuries;
			}
			if (property == "rule_numsubsbench")
			{
				return this.m_rule_numsubsbench.ToString();
			}
			if (property == "rule_numsubsmatch")
			{
				return this.m_rule_numsubsmatch.ToString();
			}
			if (property == "rule_suspension")
			{
				return this.m_rule_suspension.ToString();
			}
			if (property == "rule_numyellowstored")
			{
				return this.m_rule_numyellowstored.ToString();
			}
			if (property == "rule_numgamesbanredmax")
			{
				return this.m_rule_numgamesbanredmax.ToString();
			}
			if (property == "rule_numgamesbanredmin")
			{
				return this.m_rule_numgamesbanredmin.ToString();
			}
			if (property == "rule_numgamesbandoubleyellowmax")
			{
				return this.m_rule_numgamesbandoubleyellowmax.ToString();
			}
			if (property == "rule_numgamesbandoubleyellowmin")
			{
				return this.m_rule_numgamesbandoubleyellowmin.ToString();
			}
			if (property == "rule_numgamesbanyellowsmax")
			{
				return this.m_rule_numgamesbanyellowsmax.ToString();
			}
			if (property == "rule_numgamesbanyellowsmin")
			{
				return this.m_rule_numgamesbanyellowsmin.ToString();
			}
			if (property == "standings_pointswin")
			{
				return this.m_standings_pointswin.ToString();
			}
			if (property == "standings_pointsdraw")
			{
				return this.m_standings_pointsdraw.ToString();
			}
			if (property == "standings_pointsloss")
			{
				return this.m_standings_pointsloss.ToString();
			}
			if (property == "match_matchimportance")
			{
				return this.m_match_matchimportance.ToString();
			}
			if (property == "match_stagetype")
			{
				return this.m_match_stagetype;
			}
			if (property == "match_matchsituation")
			{
				return this.m_match_matchsituation;
			}
			if (property == "nation_id")
			{
				return this.m_nation_id.ToString();
			}
			if (property == "asset_id")
			{
				return this.m_asset_id.ToString();
			}
			if (property == "match_endruleleague")
			{
				return this.m_match_endruleleague;
			}
			if (property == "match_endruleko1leg")
			{
				return this.m_match_endruleko1leg[this.m_N_endruleko1leg];
			}
			if (property == "match_endruleko2leg1")
			{
				return this.m_match_endruleko2leg1;
			}
			if (property == "match_endruleko2leg2")
			{
				return this.m_match_endruleko2leg2[index];
			}
			if (property == "match_endrulefriendly")
			{
				return this.m_match_endrulefriendly;
			}
			if (property == "match_canusefancards")
			{
				return this.m_match_canusefancards;
			}
			if (property == "match_celebrationlevel")
			{
				return this.m_match_celebrationlevel;
			}
			if (property == "info_prize_money")
			{
				return this.m_info_prize_money.ToString();
			}
			if (property == "info_prize_money_drop")
			{
				return this.m_info_prize_money_drop.ToString();
			}
			if (property == "standings_sort")
			{
				return this.m_standings_sort[index];
			}
			if (property == "schedule_seasonstartmonth")
			{
				return this.m_schedule_seasonstartmonth;
			}
			if (property == "schedule_year_start")
			{
				return this.m_schedule_year_start.ToString();
			}
			if (property == "schedule_year_offset")
			{
				return this.m_schedule_year_offset.ToString();
			}
			if (property == "schedule_friendlydaysbetweenmin")
			{
				return this.m_schedule_friendlydaysbetweenmin.ToString();
			}
			if (property == "schedule_friendlydaysbefore")
			{
				return this.m_schedule_friendlydaysbetweenmin.ToString();
			}
			if (property == "schedule_use_dates_comp")
			{
				return this.m_schedule_use_dates_comp.ToString();
			}
			if (property == "info_slot_champ")
			{
				return this.m_info_slot_champ.ToString();
			}
			if (property == "info_color_slot_champ")
			{
				return this.m_info_color_slot_champ.ToString();
			}
			if (property == "info_slot_promo")
			{
				if (this.m_N_info_slot_promo < this.m_info_slot_promo.Length)
				{
					return this.m_info_slot_promo[index].ToString();
				}
			}
			else if (property == "info_slot_promo_poss")
			{
				if (this.m_N_info_slot_promo_poss < this.m_info_slot_promo_poss.Length)
				{
					return this.m_info_slot_promo_poss[index].ToString();
				}
			}
			else if (property == "info_slot_releg")
			{
				if (this.m_N_info_slot_releg < this.m_info_slot_releg.Length)
				{
					return this.m_info_slot_releg[index].ToString();
				}
			}
			else if (property == "info_slot_releg_poss")
			{
				if (this.m_N_info_slot_releg_poss < this.m_info_slot_releg_poss.Length)
				{
					return this.m_info_slot_releg_poss[index].ToString();
				}
			}
			else if (property == "info_color_slot_champ_cup")
			{
				if (this.m_N_info_color_slot_champ_cup < this.m_info_color_slot_champ_cup.Length)
				{
					return this.m_info_color_slot_champ_cup[index].ToString();
				}
			}
			else if (property == "info_color_slot_euro_league")
			{
				if (this.m_N_info_color_slot_euro_league < this.m_info_color_slot_euro_league.Length)
				{
					return this.m_info_color_slot_euro_league[index].ToString();
				}
			}
			else if (property == "info_color_slot_promo")
			{
				if (this.m_N_info_color_slot_promo < this.m_info_color_slot_promo.Length)
				{
					return this.m_info_color_slot_promo[index].ToString();
				}
			}
			else if (property == "info_color_slot_promo_poss")
			{
				if (this.m_N_info_color_slot_promo_poss < this.m_info_color_slot_promo_poss.Length)
				{
					return this.m_info_color_slot_promo_poss[index].ToString();
				}
			}
			else if (property == "info_color_slot_releg")
			{
				if (this.m_N_info_color_slot_releg < this.m_info_color_slot_releg.Length)
				{
					return this.m_info_color_slot_releg[index].ToString();
				}
			}
			else if (property == "info_color_slot_releg_poss")
			{
				if (this.m_N_info_color_slot_releg_poss < this.m_info_color_slot_releg_poss.Length)
				{
					return this.m_info_color_slot_releg_poss[index].ToString();
				}
			}
			else
			{
				if (property == "num_games")
				{
					return this.m_num_games.ToString();
				}
				if (property == "advance_pointskeep")
				{
					return this.m_advance_pointskeep.ToString();
				}
				if (property == "advance_pointskeeppercentage")
				{
					return this.m_advance_pointskeeppercentage.ToString();
				}
				if (property == "advance_matchupkeep")
				{
					return this.m_advance_matchupkeep.ToString();
				}
				if (property == "match_stadium")
				{
					if (index < this.m_match_stadium.Length)
					{
						return this.m_match_stadium[index].ToString();
					}
				}
				else if (property == "info_color_slot_adv_group")
				{
					if (this.m_N_info_color_slot_adv_group < this.m_info_color_slot_adv_group.Length)
					{
						return this.m_info_color_slot_adv_group[index].ToString();
					}
				}
				else if (property == "advance_standingsrank")
				{
					return this.m_advance_standingsrank.ToString();
				}
			}
			if (property == "asset_id")
			{
				return this.m_asset_id.ToString();
			}
			if (property == "rule_numsubsmatch")
			{
				return this.m_rule_numsubsmatch.ToString();
			}
			if (property == "schedule_checkconflict")
			{
				return this.m_schedule_checkconflict.ToString();
			}
			if (property == "schedule_compdependency")
			{
				return this.m_schedule_compdependency.ToString();
			}
			if (property == "schedule_internationaldependency")
			{
				return this.m_schedule_internationaldependency.ToString();
			}
			if (property == "schedule_forcecomp")
			{
				return this.m_schedule_forcecomp.ToString();
			}
			if (property == "advance_teamcompdependency")
			{
				return this.m_advance_teamcompdependency.ToString();
			}
			if (property == "info_league_promo")
			{
				return this.m_info_league_promo.ToString();
			}
			if (property == "info_league_releg")
			{
				return this.m_info_league_releg.ToString();
			}
			if (property == "info_special_team_id")
			{
				return this.m_info_special_team_id[index].ToString();
			}
			if (property == "advance_random_draw_rvrny")
			{
				return this.m_advance_random_draw_event.ToString();
			}
			if (property == "advance_randomdraw")
			{
				return this.m_advance_randomdraw.ToString();
			}
			if (property == "advance_calccompavgs")
			{
				return this.m_advance_calccompavgs.ToString();
			}
			if (property == "advance_maxteamsassoc")
			{
				return this.m_advance_maxteamsassoc.ToString();
			}
			if (property == "advance_maxteamsgroup")
			{
				return this.m_advance_maxteamsgroup.ToString();
			}
			if (property == "advance_maxteamsstageref")
			{
				return this.m_advance_maxteamsstageref.ToString();
			}
			if (property == "advance_standingskeep")
			{
				return this.m_advance_standingskeep.ToString();
			}
			if (property == "advance_standingsrank")
			{
				return this.m_advance_standingsrank.ToString();
			}
			if (property == "schedule_matchreplay")
			{
				return this.m_schedule_matchreplay.ToString();
			}
			if (property == "schedule_reversed")
			{
				return this.m_schedule_reversed.ToString();
			}
			if (property == "schedule_year_real")
			{
				return this.m_schedule_year_real.ToString();
			}
			if (property == "standings_checkrank")
			{
				return this.m_standings_checkrank.ToString();
			}
			return null;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000523E4 File Offset: 0x000505E4
		public bool SaveToSettings(int id, StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.m_asset_id != -1)
			{
				string text = id + ",asset_id," + this.m_asset_id;
				w.WriteLine(text);
			}
			if (this.m_comp_type != null)
			{
				string text = id + ",comp_type," + this.m_comp_type;
				w.WriteLine(text);
			}
			if (this.m_nation_id != -1)
			{
				string text = id + ",nation_id," + this.m_nation_id;
				w.WriteLine(text);
			}
			if (this.m_rule_bookings != null)
			{
				string text = id + ",rule_bookings," + this.m_rule_bookings;
				w.WriteLine(text);
			}
			if (this.m_rule_offsides != null)
			{
				string text = id + ",rule_offsides," + this.m_rule_offsides;
				w.WriteLine(text);
			}
			if (this.m_rule_injuries != null)
			{
				string text = id + ",rule_injuries," + this.m_rule_injuries;
				w.WriteLine(text);
			}
			if (this.m_rule_numsubsbench != -1)
			{
				string text = id + ",rule_numsubsbench," + this.m_rule_numsubsbench;
				w.WriteLine(text);
			}
			if (this.m_rule_numsubsmatch != -1)
			{
				string text = id + ",rule_numsubsmatch," + this.m_rule_numsubsmatch;
				w.WriteLine(text);
			}
			if (this.m_rule_suspension != -1)
			{
				string text = id + ",rule_suspension," + this.m_rule_suspension;
				w.WriteLine(text);
			}
			if (this.m_rule_numyellowstored != -1)
			{
				string text = id + ",rule_numyellowstored," + this.m_rule_numyellowstored;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanredmax != -1)
			{
				string text = id + ",rule_numgamesbanredmax," + this.m_rule_numgamesbanredmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanredmin != -1)
			{
				string text = id + ",rule_numgamesbanredmin," + this.m_rule_numgamesbanredmin;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbandoubleyellowmax != -1)
			{
				string text = id + ",rule_numgamesbandoubleyellowmax," + this.m_rule_numgamesbandoubleyellowmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbandoubleyellowmin != -1)
			{
				string text = id + ",rule_numgamesbandoubleyellowmin," + this.m_rule_numgamesbandoubleyellowmin;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanyellowsmax != -1)
			{
				string text = id + ",rule_numgamesbanyellowsmax," + this.m_rule_numgamesbanyellowsmax;
				w.WriteLine(text);
			}
			if (this.m_rule_numgamesbanyellowsmin != -1)
			{
				string text = id + ",rule_numgamesbanyellowsmin," + this.m_rule_numgamesbanyellowsmin;
				w.WriteLine(text);
			}
			if (this.m_standings_pointswin != -1)
			{
				string text = id + ",standings_pointswin," + this.m_standings_pointswin;
				w.WriteLine(text);
			}
			if (this.m_standings_pointsdraw != -1)
			{
				string text = id + ",standings_pointsdraw," + this.m_standings_pointsdraw;
				w.WriteLine(text);
			}
			if (this.m_standings_pointsloss != -1)
			{
				string text = id + ",standings_pointsloss," + this.m_standings_pointsloss;
				w.WriteLine(text);
			}
			if (this.m_standings_checkrank != -1)
			{
				string text = id + ",standings_checkrank," + this.m_standings_checkrank;
				w.WriteLine(text);
			}
			if (this.m_schedule_seasonstartmonth != null)
			{
				string text = id + ",schedule_seasonstartmonth," + this.m_schedule_seasonstartmonth;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_start != -1)
			{
				string text = id + ",schedule_year_start," + this.m_schedule_year_start;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_offset != -1)
			{
				string text = id + ",schedule_year_offset," + this.m_schedule_year_offset;
				w.WriteLine(text);
			}
			if (this.m_schedule_friendlydaysbetweenmin != -1)
			{
				string text = id + ",schedule_friendlydaysbetweenmin," + this.m_schedule_friendlydaysbetweenmin;
				w.WriteLine(text);
			}
			if (this.m_schedule_friendlydaysbefore != -1)
			{
				string text = id + ",schedule_friendlydaysbefore," + this.m_schedule_friendlydaysbefore;
				w.WriteLine(text);
			}
			if (this.m_schedule_internationaldependency != -1)
			{
				string text = id + ",schedule_internationaldependency," + this.m_schedule_internationaldependency;
				w.WriteLine(text);
			}
			if (this.m_schedule_use_dates_comp != -1)
			{
				int internationalFriendlyId = FifaEnvironment.CompetitionObjects.GetInternationalFriendlyId();
				if (internationalFriendlyId != -1)
				{
					string text = id + ",schedule_use_dates_comp," + internationalFriendlyId;
					w.WriteLine(text);
				}
			}
			if (this.m_schedule_checkconflict == 1)
			{
				string text = id + ",schedule_checkconflict," + this.m_schedule_checkconflict;
				w.WriteLine(text);
			}
			if (this.TrophyCompdependency != null)
			{
				string text = id + ",schedule_compdependency," + this.m_TrophyCompdependency.Id;
				w.WriteLine(text);
			}
			if (this.TrophyForcecomp != null)
			{
				string text = id + ",schedule_forcecomp," + this.m_TrophyForcecomp.Id;
				w.WriteLine(text);
			}
			if (this.m_schedule_matchreplay != -1)
			{
				string text = id + ",schedule_matchreplay," + this.m_schedule_matchreplay;
				w.WriteLine(text);
			}
			if (this.m_schedule_reversed != -1)
			{
				string text = id + ",schedule_reversed," + this.m_schedule_reversed;
				w.WriteLine(text);
			}
			if (this.m_schedule_year_real != -1)
			{
				string text = id + ",schedule_year_real," + this.m_schedule_year_real;
				w.WriteLine(text);
			}
			if (this.m_match_matchimportance != -1)
			{
				string text = id + ",match_matchimportance," + this.m_match_matchimportance;
				w.WriteLine(text);
			}
			if (this.m_match_stagetype != null)
			{
				string text = id + ",match_stagetype," + this.m_match_stagetype;
				w.WriteLine(text);
			}
			if (this.m_match_matchsituation != null)
			{
				string text = id + ",match_matchsituation," + this.m_match_matchsituation;
				w.WriteLine(text);
			}
			if (this.m_match_endruleleague != null)
			{
				string text = id + ",match_endruleleague," + this.m_match_endruleleague;
				w.WriteLine(text);
			}
			this.m_N_endruleko1leg = CompetitionSettings.SetKo1Rule(this.m_EndRuleKo1Leg, ref this.m_match_endruleko1leg);
			for (int i = 0; i < this.m_N_endruleko1leg; i++)
			{
				string text = id + ",match_endruleko1leg," + this.m_match_endruleko1leg[i];
				w.WriteLine(text);
			}
			if (this.m_match_endruleko2leg1 != null)
			{
				string text = id + ",match_endruleko2leg1," + this.m_match_endruleko2leg1;
				w.WriteLine(text);
			}
			this.m_N_endruleko2leg2 = CompetitionSettings.SetKo2Rule(this.m_EndRuleKo2Leg2, ref this.m_match_endruleko2leg2);
			for (int j = 0; j < this.m_N_endruleko2leg2; j++)
			{
				string text = id + ",match_endruleko2leg2," + this.m_match_endruleko2leg2[j];
				w.WriteLine(text);
			}
			if (this.m_match_endrulefriendly != null)
			{
				string text = id + ",match_endrulefriendly," + this.m_match_endrulefriendly;
				w.WriteLine(text);
			}
			if (this.m_match_canusefancards == "on")
			{
				string text = id + ",match_canusefancards," + this.m_match_canusefancards;
				w.WriteLine(text);
			}
			if (this.m_match_celebrationlevel == "LOW")
			{
				string text = id + ",match_celebrationlevel," + this.m_match_celebrationlevel;
				w.WriteLine(text);
			}
			if (this.m_match_stadium != null)
			{
				for (int k = 0; k < this.m_match_stadium.Length; k++)
				{
					if (this.m_match_stadium[k] >= 0)
					{
						string text = id + ",match_stadium," + this.m_match_stadium[k];
						w.WriteLine(text);
					}
				}
			}
			if (this.m_info_prize_money != -1)
			{
				string text = id + ",info_prize_money," + this.m_info_prize_money;
				w.WriteLine(text);
			}
			if (this.m_info_prize_money_drop != -1)
			{
				string text = id + ",info_prize_money_drop," + this.m_info_prize_money_drop;
				w.WriteLine(text);
			}
			this.m_N_standings_sort = CompetitionSettings.SetStandingRule(this.m_StandingsSort, ref this.m_standings_sort);
			for (int l = 0; l < this.m_N_standings_sort; l++)
			{
				string text = id + ",standings_sort," + this.m_standings_sort[l];
				w.WriteLine(text);
			}
			if (this.m_num_games != -1)
			{
				string text = id + ",num_games," + this.m_num_games;
				w.WriteLine(text);
			}
			if (this.m_info_color_slot_champ != -1)
			{
				string text = id + ",info_color_slot_champ," + this.m_info_color_slot_champ;
				w.WriteLine(text);
			}
			for (int m = 0; m < this.m_N_info_color_slot_champ_cup; m++)
			{
				string text = id + ",info_color_slot_champ_cup," + this.m_info_color_slot_champ_cup[m];
				w.WriteLine(text);
			}
			for (int n = 0; n < this.m_N_info_color_slot_euro_league; n++)
			{
				string text = id + ",info_color_slot_euro_league," + this.m_info_color_slot_euro_league[n];
				w.WriteLine(text);
			}
			for (int num = 0; num < this.m_N_info_color_slot_promo; num++)
			{
				string text = id + ",info_color_slot_promo," + this.m_info_color_slot_promo[num];
				w.WriteLine(text);
			}
			for (int num2 = 0; num2 < this.m_N_info_color_slot_promo_poss; num2++)
			{
				string text = id + ",info_color_slot_promo_poss," + this.m_info_color_slot_promo_poss[num2];
				w.WriteLine(text);
			}
			for (int num3 = 0; num3 < this.m_N_info_color_slot_releg; num3++)
			{
				string text = id + ",info_color_slot_releg," + this.m_info_color_slot_releg[num3];
				w.WriteLine(text);
			}
			for (int num4 = 0; num4 < this.m_N_info_color_slot_releg_poss; num4++)
			{
				string text = id + ",info_color_slot_releg_poss," + this.m_info_color_slot_releg_poss[num4];
				w.WriteLine(text);
			}
			for (int num5 = 0; num5 < this.m_N_info_color_slot_adv_group; num5++)
			{
				string text = id + ",info_color_slot_adv_group," + this.m_info_color_slot_adv_group[num5];
				w.WriteLine(text);
			}
			if (this.m_info_slot_champ != -1)
			{
				string text = id + ",info_slot_champ," + this.m_info_slot_champ;
				w.WriteLine(text);
			}
			for (int num6 = 0; num6 < this.m_N_info_slot_promo; num6++)
			{
				string text = id + ",info_slot_promo," + this.m_info_slot_promo[num6];
				w.WriteLine(text);
			}
			for (int num7 = 0; num7 < this.m_N_info_slot_promo_poss; num7++)
			{
				string text = id + ",info_slot_promo_poss," + this.m_info_slot_promo_poss[num7];
				w.WriteLine(text);
			}
			for (int num8 = 0; num8 < this.m_N_info_slot_releg; num8++)
			{
				string text = id + ",info_slot_releg," + this.m_info_slot_releg[num8];
				w.WriteLine(text);
			}
			for (int num9 = 0; num9 < this.m_N_info_slot_releg_poss; num9++)
			{
				string text = id + ",info_slot_releg_poss," + this.m_info_slot_releg_poss[num9];
				w.WriteLine(text);
			}
			if (this.m_info_league_promo != -1)
			{
				string text = id + ",info_league_promo," + this.m_info_league_promo;
				w.WriteLine(text);
			}
			if (this.m_info_league_releg != -1)
			{
				string text = id + ",info_league_releg," + this.m_info_league_releg;
				w.WriteLine(text);
			}
			for (int num10 = 0; num10 < this.m_N_info_special_team_id; num10++)
			{
				if (this.m_info_special_team_id[num10] >= 0)
				{
					string text = id + ",info_special_team_id," + this.m_info_special_team_id[num10];
					w.WriteLine(text);
				}
			}
			if (this.m_advance_pointskeep != -1)
			{
				string text = id + ",advance_pointskeep," + this.m_advance_pointskeep;
				w.WriteLine(text);
			}
			if (this.m_advance_pointskeeppercentage != -1)
			{
				string text = id + ",advance_pointskeeppercentage," + this.m_advance_pointskeeppercentage;
				w.WriteLine(text);
			}
			if (this.m_advance_matchupkeep != -1)
			{
				string text = id + ",advance_matchupkeep," + this.m_advance_matchupkeep;
				w.WriteLine(text);
			}
			if (this.m_advance_standingsrank != -1)
			{
				string text = id + ",advance_standingsrank," + this.m_advance_standingsrank;
				w.WriteLine(text);
			}
			if (this.m_advance_random_draw_event != -1)
			{
				string text = id + ",advance_random_draw_event," + this.m_advance_random_draw_event;
				w.WriteLine(text);
			}
			if (this.m_advance_randomdraw != -1)
			{
				string text = id + ",advance_randomdraw," + this.m_advance_randomdraw;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsassoc != -1)
			{
				string text = id + ",advance_maxteamsassoc," + this.m_advance_maxteamsassoc;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsgroup != -1)
			{
				string text = id + ",advance_maxteamsgroup," + this.m_advance_maxteamsgroup;
				w.WriteLine(text);
			}
			if (this.m_advance_maxteamsstageref != -1)
			{
				string text = id + ",advance_maxteamsstageref," + this.m_advance_maxteamsstageref;
				w.WriteLine(text);
			}
			if (this.m_advance_calccompavgs != -1)
			{
				string text = id + ",advance_calccompavgs," + this.m_advance_calccompavgs;
				w.WriteLine(text);
			}
			if (this.m_advance_standingskeep != -1)
			{
				string text = id + ",advance_standingskeep," + this.m_advance_standingskeep;
				w.WriteLine(text);
			}
			if (this.m_advance_teamcompdependency != -1)
			{
				string text = id + ",advance_teamcompdependency," + this.m_advance_teamcompdependency;
				w.WriteLine(text);
			}
			return true;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00053224 File Offset: 0x00051424
		public static int GetStandingRule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (rules[0] == "POINTS")
			{
				if (rules[1] == "GOALDIFF")
				{
					if (rules[3] == "H2HPOINTS")
					{
						return 5;
					}
					return 0;
				}
				else
				{
					if (rules[1] == "WINS")
					{
						return 1;
					}
					if (rules[1] == "H2HPOINTS")
					{
						return 2;
					}
					return 0;
				}
			}
			else
			{
				if (rules[0] == "TEAMRATING")
				{
					return 3;
				}
				if (rules[0] == "PREVRANK")
				{
					return 4;
				}
				return 0;
			}
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000532B0 File Offset: 0x000514B0
		public static int SetStandingRule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "POINTS";
				rules[1] = "WINS";
				rules[2] = "GOALDIFF";
				rules[3] = "GOALSFOR";
				return 4;
			case 2:
				rules[0] = "POINTS";
				rules[1] = "H2HPOINTS";
				rules[3] = "H2HGOALDIFF";
				rules[3] = "H2HGOALSFOR";
				rules[4] = "GOALDIFF";
				rules[5] = "GOALSFOR";
				return 6;
			case 3:
				rules[0] = "TEAMRATING";
				return 1;
			case 4:
				rules[0] = "PREVRANK";
				return 1;
			case 5:
				rules[0] = "POINTS";
				rules[1] = "GOALDIFF";
				rules[2] = "GOALSFOR";
				rules[3] = "H2HPOINTS";
				return 4;
			}
			rules[0] = "POINTS";
			rules[1] = "GOALDIFF";
			rules[2] = "GOALSFOR";
			rules[3] = "WINS";
			return 4;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000533A4 File Offset: 0x000515A4
		public static int GetKo1Rule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (rules[0] == "ET")
			{
				if (rules[1] == "PENS")
				{
					return 0;
				}
			}
			else
			{
				if (rules[0] == "PENS")
				{
					return 1;
				}
				if (rules[0] == "END")
				{
					return 2;
				}
			}
			return -1;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000533FC File Offset: 0x000515FC
		public static int SetKo1Rule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "PENS";
				return 1;
			case 2:
				rules[0] = "END";
				return 1;
			}
			rules[0] = "ET";
			rules[1] = "PENS";
			return 2;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00053450 File Offset: 0x00051650
		public static int GetKo2Rule(string[] rules)
		{
			if (rules == null)
			{
				return -1;
			}
			if (!(rules[0] == "AGG"))
			{
				return -1;
			}
			if (rules[1] == "AWAY")
			{
				return 0;
			}
			if (rules[1] == "ET")
			{
				return 1;
			}
			if (rules[1] == "PENS")
			{
				return 2;
			}
			return 3;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000534A8 File Offset: 0x000516A8
		public static int SetKo2Rule(int rulesId, ref string[] rules)
		{
			switch (rulesId)
			{
			case -1:
				return 0;
			case 1:
				rules[0] = "AGG";
				rules[1] = "ET";
				rules[2] = "PENS";
				return 3;
			case 2:
				rules[0] = "AGG";
				rules[1] = "PENS";
				return 2;
			case 3:
				rules[0] = "AGG";
				return 1;
			}
			rules[0] = "AGG";
			rules[1] = "AWAY";
			rules[2] = "ET";
			rules[3] = "ET_AWAY";
			rules[4] = "PENS";
			return 5;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00053540 File Offset: 0x00051740
		public void UnsetProperty(string property)
		{
			int num = this.IsMultipleProperty(property);
			if (num <= 1)
			{
				this.UnsetProperty(property, 0);
				return;
			}
			for (int i = 0; i < num; i++)
			{
				this.UnsetProperty(property, i);
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00053576 File Offset: 0x00051776
		private void UnsetProperty(string property, int index)
		{
			if (this.IsStringProperty(property))
			{
				this.SetProperty(property, index, null);
				return;
			}
			this.SetProperty(property, index, "-1");
		}

		// Token: 0x0400114A RID: 4426
		private Compobj m_OwnerCompObj;

		// Token: 0x0400114B RID: 4427
		public CompetitionSettings m_ParentSettings;

		// Token: 0x0400114C RID: 4428
		public string m_comp_type;

		// Token: 0x0400114D RID: 4429
		public int m_nation_id = -1;

		// Token: 0x0400114E RID: 4430
		public int m_asset_id = -1;

		// Token: 0x0400114F RID: 4431
		public string m_rule_bookings;

		// Token: 0x04001150 RID: 4432
		public string m_rule_offsides;

		// Token: 0x04001151 RID: 4433
		public string m_rule_injuries;

		// Token: 0x04001152 RID: 4434
		public int m_rule_numsubsbench = -1;

		// Token: 0x04001153 RID: 4435
		public int m_rule_numsubsmatch = -1;

		// Token: 0x04001154 RID: 4436
		public int m_rule_suspension = -1;

		// Token: 0x04001155 RID: 4437
		public int m_rule_numyellowstored = -1;

		// Token: 0x04001156 RID: 4438
		public int m_rule_numgamesbanredmax = -1;

		// Token: 0x04001157 RID: 4439
		public int m_rule_numgamesbanredmin = -1;

		// Token: 0x04001158 RID: 4440
		public int m_rule_numgamesbandoubleyellowmax = -1;

		// Token: 0x04001159 RID: 4441
		public int m_rule_numgamesbandoubleyellowmin = -1;

		// Token: 0x0400115A RID: 4442
		public int m_rule_numgamesbanyellowsmax = -1;

		// Token: 0x0400115B RID: 4443
		public int m_rule_numgamesbanyellowsmin = -1;

		// Token: 0x0400115C RID: 4444
		public int m_standings_pointswin = -1;

		// Token: 0x0400115D RID: 4445
		public int m_standings_pointsdraw = -1;

		// Token: 0x0400115E RID: 4446
		public int m_standings_pointsloss = -1;

		// Token: 0x0400115F RID: 4447
		public string[] m_standings_sort = new string[6];

		// Token: 0x04001160 RID: 4448
		public int m_N_standings_sort;

		// Token: 0x04001161 RID: 4449
		public int m_StandingsSort = -1;

		// Token: 0x04001162 RID: 4450
		private Stage m_StageAdvanceMaxteamsStageRef;

		// Token: 0x04001163 RID: 4451
		private Stage m_StageAdvanceStandingsKeep;

		// Token: 0x04001164 RID: 4452
		private Stage m_StageAdvanceStandingsRank;

		// Token: 0x04001165 RID: 4453
		private Stage m_StageStandingsCheckRank;

		// Token: 0x04001166 RID: 4454
		private Stage m_StageAdvancePointsKeep;

		// Token: 0x04001167 RID: 4455
		public int m_match_matchimportance = -1;

		// Token: 0x04001168 RID: 4456
		public string m_match_stagetype;

		// Token: 0x04001169 RID: 4457
		public string m_match_matchsituation;

		// Token: 0x0400116A RID: 4458
		public string m_match_endruleleague;

		// Token: 0x0400116B RID: 4459
		public string[] m_match_endruleko1leg = new string[6];

		// Token: 0x0400116C RID: 4460
		public int m_N_endruleko1leg;

		// Token: 0x0400116D RID: 4461
		public int m_EndRuleKo1Leg = -1;

		// Token: 0x0400116E RID: 4462
		public string m_match_endruleko2leg1;

		// Token: 0x0400116F RID: 4463
		public string[] m_match_endruleko2leg2 = new string[6];

		// Token: 0x04001170 RID: 4464
		public int m_EndRuleKo2Leg2 = -1;

		// Token: 0x04001171 RID: 4465
		public int m_N_endruleko2leg2;

		// Token: 0x04001172 RID: 4466
		public string m_match_endrulefriendly;

		// Token: 0x04001173 RID: 4467
		public string m_match_canusefancards;

		// Token: 0x04001174 RID: 4468
		public string m_match_celebrationlevel;

		// Token: 0x04001175 RID: 4469
		public int[] m_match_stadium;

		// Token: 0x04001176 RID: 4470
		public int m_N_match_stadium;

		// Token: 0x04001177 RID: 4471
		public int m_info_prize_money = -1;

		// Token: 0x04001178 RID: 4472
		public int m_info_prize_money_drop = -1;

		// Token: 0x04001179 RID: 4473
		public int m_info_color_slot_champ = -1;

		// Token: 0x0400117A RID: 4474
		public int[] m_info_color_slot_champ_cup = new int[4];

		// Token: 0x0400117B RID: 4475
		public int m_N_info_color_slot_champ_cup;

		// Token: 0x0400117C RID: 4476
		public int[] m_info_color_slot_euro_league = new int[4];

		// Token: 0x0400117D RID: 4477
		public int m_N_info_color_slot_euro_league;

		// Token: 0x0400117E RID: 4478
		public int[] m_info_color_slot_promo = new int[4];

		// Token: 0x0400117F RID: 4479
		public int m_N_info_color_slot_promo;

		// Token: 0x04001180 RID: 4480
		public int[] m_info_color_slot_promo_poss = new int[4];

		// Token: 0x04001181 RID: 4481
		public int m_N_info_color_slot_promo_poss;

		// Token: 0x04001182 RID: 4482
		public int[] m_info_color_slot_releg = new int[4];

		// Token: 0x04001183 RID: 4483
		public int m_N_info_color_slot_releg;

		// Token: 0x04001184 RID: 4484
		public int[] m_info_color_slot_releg_poss = new int[4];

		// Token: 0x04001185 RID: 4485
		public int m_N_info_color_slot_releg_poss;

		// Token: 0x04001186 RID: 4486
		public int[] m_info_color_slot_adv_group = new int[8];

		// Token: 0x04001187 RID: 4487
		public int m_N_info_color_slot_adv_group;

		// Token: 0x04001188 RID: 4488
		public int m_info_slot_champ = -1;

		// Token: 0x04001189 RID: 4489
		public int[] m_info_slot_promo = new int[4];

		// Token: 0x0400118A RID: 4490
		public int m_N_info_slot_promo;

		// Token: 0x0400118B RID: 4491
		public int[] m_info_slot_promo_poss = new int[4];

		// Token: 0x0400118C RID: 4492
		public int m_N_info_slot_promo_poss;

		// Token: 0x0400118D RID: 4493
		public int[] m_info_slot_releg = new int[4];

		// Token: 0x0400118E RID: 4494
		public int m_N_info_slot_releg;

		// Token: 0x0400118F RID: 4495
		public int[] m_info_slot_releg_poss = new int[4];

		// Token: 0x04001190 RID: 4496
		public int m_N_info_slot_releg_poss;

		// Token: 0x04001191 RID: 4497
		public int m_info_league_promo = -1;

		// Token: 0x04001192 RID: 4498
		public int m_info_league_releg = -1;

		// Token: 0x04001193 RID: 4499
		public int[] m_info_special_team_id = new int[8];

		// Token: 0x04001194 RID: 4500
		public int m_N_info_special_team_id;

		// Token: 0x04001195 RID: 4501
		public string m_schedule_seasonstartmonth;

		// Token: 0x04001196 RID: 4502
		public int m_schedule_year_start = -1;

		// Token: 0x04001197 RID: 4503
		public int m_schedule_year_offset = -1;

		// Token: 0x04001198 RID: 4504
		public int m_schedule_friendlydaysbetweenmin = -1;

		// Token: 0x04001199 RID: 4505
		public int m_schedule_friendlydaysbefore = -1;

		// Token: 0x0400119A RID: 4506
		public int m_schedule_checkconflict = -1;

		// Token: 0x0400119B RID: 4507
		private int m_schedule_compdependency = -1;

		// Token: 0x0400119C RID: 4508
		private int m_schedule_forcecomp = -1;

		// Token: 0x0400119D RID: 4509
		public int m_schedule_use_dates_comp = -1;

		// Token: 0x0400119E RID: 4510
		private int m_schedule_internationaldependency = -1;

		// Token: 0x0400119F RID: 4511
		private Trophy m_TrophyCompdependency;

		// Token: 0x040011A0 RID: 4512
		private Trophy m_TrophyForcecomp;

		// Token: 0x040011A1 RID: 4513
		public int m_schedule_matchreplay = -1;

		// Token: 0x040011A2 RID: 4514
		public int m_schedule_reversed = -1;

		// Token: 0x040011A3 RID: 4515
		public int m_schedule_year_real = -1;

		// Token: 0x040011A4 RID: 4516
		public int m_num_games = -1;

		// Token: 0x040011A5 RID: 4517
		private int m_advance_pointskeep = -1;

		// Token: 0x040011A6 RID: 4518
		public int m_advance_pointskeeppercentage = -1;

		// Token: 0x040011A7 RID: 4519
		public int m_advance_matchupkeep = -1;

		// Token: 0x040011A8 RID: 4520
		public int m_advance_random_draw_event = -1;

		// Token: 0x040011A9 RID: 4521
		public int m_advance_randomdraw = -1;

		// Token: 0x040011AA RID: 4522
		public int m_advance_calccompavgs = -1;

		// Token: 0x040011AB RID: 4523
		public int m_advance_maxteamsassoc = -1;

		// Token: 0x040011AC RID: 4524
		public int m_advance_maxteamsgroup = -1;

		// Token: 0x040011AD RID: 4525
		private int m_advance_maxteamsstageref = -1;

		// Token: 0x040011AE RID: 4526
		private int m_advance_standingskeep = -1;

		// Token: 0x040011AF RID: 4527
		private int m_advance_standingsrank = -1;

		// Token: 0x040011B0 RID: 4528
		private int m_standings_checkrank = -1;

		// Token: 0x040011B1 RID: 4529
		public int m_advance_teamcompdependency = -1;

		// Token: 0x040011B2 RID: 4530
		private League m_LeaguePromo;

		// Token: 0x040011B3 RID: 4531
		private League m_LeagueReleg;
	}
}
