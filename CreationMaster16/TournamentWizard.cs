using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CreationMaster
{
	// Token: 0x0200001D RID: 29
	public partial class TournamentWizard : Form
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0007DD50 File Offset: 0x0007BF50
		public int TournamentStructure
		{
			get
			{
				return this.m_TournamentStructure;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0007DD58 File Offset: 0x0007BF58
		public int LeagueGames
		{
			get
			{
				return this.m_LeagueGames;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0007DD60 File Offset: 0x0007BF60
		public int PreliminaryGames
		{
			get
			{
				return this.m_PreliminaryGames;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0007DD68 File Offset: 0x0007BF68
		public int GroupGames
		{
			get
			{
				return this.m_GroupGames;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0007DD70 File Offset: 0x0007BF70
		public int KnockOutGames
		{
			get
			{
				return this.m_KnockOutGames;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0007DD78 File Offset: 0x0007BF78
		public int FinalGames
		{
			get
			{
				return this.m_FinalGames;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0007DD80 File Offset: 0x0007BF80
		public int NTeams
		{
			get
			{
				return this.m_NTeams;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0007DD88 File Offset: 0x0007BF88
		public int NPreliminaryTeams
		{
			get
			{
				return this.m_NPreliminaryTeams;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0007DD90 File Offset: 0x0007BF90
		public int NKnockOutTeams
		{
			get
			{
				return this.m_NKnockOutTeams;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0007DD98 File Offset: 0x0007BF98
		public int NTeamsInGroups
		{
			get
			{
				return this.m_NTeamsInGroups;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		public int NGroups
		{
			get
			{
				return this.m_NGroups;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0007DDA8 File Offset: 0x0007BFA8
		public int NTeamsPerGroup
		{
			get
			{
				return this.m_NTeamsPerGroup;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0007DDB0 File Offset: 0x0007BFB0
		public TournamentWizard()
		{
			this.InitializeComponent();
			this.m_NTeams = 3;
			this.m_TournamentStructure = 0;
			this.m_LeagueGames = 1;
			this.m_NKnockOutTeams = 2;
			this.m_KnockOutGames = 1;
			this.m_FinalGames = 1;
			this.m_NGroups = 1;
			this.m_NTeamsPerGroup = 0;
			this.m_GroupGames = 1;
			this.m_NPreliminaryTeams = 0;
			this.m_PreliminaryGames = 2;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0007DE16 File Offset: 0x0007C016
		private void numericNTeams_ValueChanged(object sender, EventArgs e)
		{
			this.m_NTeams = (int)this.numericNTeams.Value;
			this.InitOptions();
			this.ToPanel();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0007DE3A File Offset: 0x0007C03A
		private void ToPanel()
		{
			this.RadioToPanel();
			this.OptionsToPanel();
			this.OkButtonToPanel();
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0007DE50 File Offset: 0x0007C050
		private void RadioToPanel()
		{
			if (this.numericNTeams.Value >= 3m && this.numericNTeams.Value <= 24m)
			{
				this.radioLeague.Enabled = true;
			}
			else
			{
				this.radioLeague.Enabled = false;
				this.radioLeague.Checked = false;
			}
			if (this.numericNTeams.Value == 2m || this.numericNTeams.Value == 4m || this.numericNTeams.Value == 8m || this.numericNTeams.Value == 16m || this.numericNTeams.Value == 32m || this.numericNTeams.Value == 64m)
			{
				this.radioKO.Enabled = true;
			}
			else
			{
				this.radioKO.Enabled = false;
				this.radioKO.Checked = false;
			}
			if (this.numericNTeams.Value >= 3m)
			{
				if (this.numericNTeams.Value <= 16m || (((int)this.numericNTeams.Value & 1) == 0 && this.numericNTeams.Value <= 32m) || (((int)this.numericNTeams.Value & 3) == 0 && this.numericNTeams.Value <= 64m))
				{
					this.radioGKO.Enabled = true;
				}
				else
				{
					this.radioGKO.Enabled = false;
					this.radioGKO.Checked = false;
				}
			}
			else
			{
				this.radioGKO.Enabled = false;
				this.radioGKO.Checked = false;
			}
			if (this.numericNTeams.Value >= 3m && this.numericNTeams.Value != 4m && this.numericNTeams.Value != 8m && this.numericNTeams.Value != 16m && this.numericNTeams.Value != 32m && this.numericNTeams.Value != 64m)
			{
				this.radioPKO.Enabled = true;
			}
			else
			{
				this.radioPKO.Enabled = false;
				this.radioPKO.Checked = false;
			}
			if (this.numericNTeams.Value > 8m && this.numericNTeams.Value != 16m && this.numericNTeams.Value != 32m && this.numericNTeams.Value != 64m)
			{
				this.radioPGKO.Enabled = true;
				return;
			}
			this.radioPGKO.Enabled = false;
			this.radioPGKO.Checked = false;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0007E180 File Offset: 0x0007C380
		private void OkButtonToPanel()
		{
			if (this.radioLeague.Checked || this.radioKO.Checked || this.radioPKO.Checked || this.radioGKO.Checked || this.radioPGKO.Checked || this.radioWC2006.Checked || this.radioEuro2008.Checked || this.radioEuro2004.Checked)
			{
				this.buttonOK.Enabled = true;
				return;
			}
			this.buttonOK.Enabled = false;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0007E210 File Offset: 0x0007C410
		private void OptionsToPanel()
		{
			if (this.radioKO.Checked || this.radioGKO.Checked || this.radioPKO.Checked || this.radioPGKO.Checked)
			{
				this.groupKO.Enabled = (this.groupKO.Visible = true);
				this.KOToPanel();
			}
			else
			{
				this.groupKO.Visible = false;
			}
			if (this.radioPKO.Checked || this.radioPGKO.Checked)
			{
				this.groupPreliminary.Enabled = (this.groupPreliminary.Visible = true);
				this.PreliminaryToPanel();
			}
			else
			{
				this.groupPreliminary.Visible = false;
			}
			if (this.radioGKO.Checked || this.radioPGKO.Checked)
			{
				this.groupGroups.Enabled = (this.groupGroups.Visible = true);
				this.GroupToPanel();
			}
			else
			{
				this.groupGroups.Visible = false;
			}
			if (this.radioLeague.Checked)
			{
				this.groupLeague.Visible = true;
				this.LeagueToPanel();
			}
			else
			{
				this.groupLeague.Visible = false;
			}
			if (this.radioWC2006.Checked || this.radioEuro2008.Checked || this.radioEuro2004.Checked)
			{
				this.groupQualification.Visible = true;
				this.groupGroups.Visible = false;
				this.groupKO.Visible = false;
				this.groupGroups.Enabled = false;
				this.groupKO.Enabled = false;
				return;
			}
			this.groupQualification.Visible = false;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0007E3AC File Offset: 0x0007C5AC
		private void GroupToPanel()
		{
			this.domainNGroups.SelectedItem = this.m_NGroups.ToString();
			this.domainNGroups.Text = this.m_NGroups.ToString();
			this.numericTeamsPerGroup.Value = this.m_NTeamsPerGroup;
			this.numericGamesPerGroup.Value = this.m_GroupGames;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0007E414 File Offset: 0x0007C614
		private void KOToPanel()
		{
			this.domainNTeamsKO.SelectedItem = this.m_NKnockOutTeams.ToString();
			this.domainNTeamsKO.Text = this.m_NKnockOutTeams.ToString();
			this.numericFinalGames.Value = this.m_FinalGames;
			this.numericKOGames.Value = this.m_KnockOutGames;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0007E479 File Offset: 0x0007C679
		private void PreliminaryToPanel()
		{
			this.numericPrelimGames.Value = this.m_PreliminaryGames;
			this.numericPreliminaryTeams.Value = this.m_NPreliminaryTeams;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0007E4A7 File Offset: 0x0007C6A7
		private void LeagueToPanel()
		{
			this.numericLeagueGames.Value = this.m_LeagueGames;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0007E4BF File Offset: 0x0007C6BF
		private void InitOptions()
		{
			this.InitGroupsOptions();
			this.InitKnockOutOptions();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0007E4D0 File Offset: 0x0007C6D0
		private void InitGroupsOptions()
		{
			int tournamentStructure = this.m_TournamentStructure;
			if (tournamentStructure == 3)
			{
				this.domainNGroups.Items.Clear();
				this.m_NTeamsInGroups = this.m_NTeams;
				if (this.m_NTeamsInGroups % 16 == 0 && this.m_NTeamsInGroups >= 48)
				{
					this.domainNGroups.Items.Add("16");
					this.m_NGroups = 16;
				}
				if (this.m_NTeamsInGroups % 8 == 0 && this.m_NTeamsInGroups >= 24)
				{
					this.domainNGroups.Items.Add("8");
					this.m_NGroups = 8;
				}
				if (this.m_NTeamsInGroups % 4 == 0 && this.m_NTeamsInGroups >= 12 && this.m_NTeamsInGroups <= 64)
				{
					this.domainNGroups.Items.Add("4");
					this.m_NGroups = 4;
				}
				if (this.m_NTeamsInGroups % 2 == 0 && this.m_NTeamsInGroups >= 6 && this.m_NTeamsInGroups <= 32)
				{
					this.domainNGroups.Items.Add("2");
					this.m_NGroups = 2;
				}
				if (this.m_NTeamsInGroups <= 16)
				{
					this.domainNGroups.Items.Add("1");
					this.m_NGroups = 1;
				}
				this.domainNGroups.SelectedItem = this.m_NGroups.ToString();
				this.m_NTeamsPerGroup = this.m_NTeamsInGroups / this.m_NGroups;
				return;
			}
			if (tournamentStructure != 4)
			{
				return;
			}
			this.m_NTeamsInGroups = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)this.m_NTeams - 1.0, 2.0)));
			this.domainNGroups.Items.Clear();
			if (this.m_NTeamsInGroups % 8 == 0 && this.m_NTeamsInGroups >= 24)
			{
				this.domainNGroups.Items.Add("8");
				this.m_NGroups = 8;
			}
			if (this.m_NTeamsInGroups % 4 == 0 && this.m_NTeamsInGroups >= 12 && this.m_NTeamsInGroups <= 64)
			{
				this.domainNGroups.Items.Add("4");
				this.m_NGroups = 4;
			}
			if (this.m_NTeamsInGroups % 2 == 0 && this.m_NTeamsInGroups >= 6 && this.m_NTeamsInGroups <= 32)
			{
				this.domainNGroups.Items.Add("2");
				this.m_NGroups = 2;
			}
			if (this.m_NTeamsInGroups <= 16)
			{
				this.domainNGroups.Items.Add("1");
				this.m_NGroups = 1;
			}
			this.domainNGroups.SelectedItem = this.m_NGroups.ToString();
			this.m_NTeamsPerGroup = this.m_NTeamsInGroups / this.m_NGroups;
			this.m_NPreliminaryTeams = (this.m_NTeams - this.m_NTeamsInGroups) * 2;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0007E78C File Offset: 0x0007C98C
		private void InitKnockOutOptions()
		{
			switch (this.m_TournamentStructure)
			{
			case 0:
				break;
			case 1:
			case 2:
				this.m_NKnockOutTeams = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)this.numericNTeams.Value, 2.0)));
				this.domainNTeamsKO.Items.Clear();
				this.domainNTeamsKO.Items.Add(this.m_NKnockOutTeams.ToString());
				this.domainNTeamsKO.Enabled = false;
				this.domainNTeamsKO.SelectedItem = this.m_NKnockOutTeams.ToString();
				this.m_NPreliminaryTeams = (this.m_NTeams - this.m_NKnockOutTeams) * 2;
				return;
			case 3:
			{
				int num = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)this.m_NTeams - 1.0, 2.0)));
				this.domainNTeamsKO.Items.Clear();
				if (num >= 32 && 32 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("32");
				}
				if (num >= 16 && 16 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("16");
				}
				if (num >= 8 && 8 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("8");
				}
				if (num >= 4 && 4 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("4");
				}
				if (num >= 2 && 2 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("2");
				}
				this.domainNTeamsKO.Enabled = true;
				this.m_NKnockOutTeams = this.m_NGroups * 2;
				this.domainNTeamsKO.SelectedItem = this.m_NKnockOutTeams.ToString();
				return;
			}
			case 4:
			{
				int num2 = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)(this.m_NTeamsInGroups - 1), 2.0)));
				this.domainNTeamsKO.Items.Clear();
				if (num2 >= 32 && 32 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("32");
				}
				if (num2 >= 16 && 16 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("16");
				}
				if (num2 >= 8 && 8 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("8");
				}
				if (num2 >= 4 && 4 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("4");
				}
				if (num2 >= 2 && 2 >= this.m_NGroups)
				{
					this.domainNTeamsKO.Items.Add("2");
				}
				this.domainNTeamsKO.Enabled = true;
				this.m_NKnockOutTeams = this.m_NGroups * 2;
				this.domainNTeamsKO.SelectedItem = this.m_NKnockOutTeams.ToString();
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0007EA9C File Offset: 0x0007CC9C
		private void InitKOToPanel()
		{
			if (this.m_TournamentStructure == 1 || this.m_TournamentStructure == 2)
			{
				this.m_NKnockOutTeams = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)this.numericNTeams.Value, 2.0)));
				this.domainNTeamsKO.Enabled = true;
				this.domainNTeamsKO.Items.Clear();
				this.domainNTeamsKO.Items.Add(this.m_NKnockOutTeams.ToString());
				this.domainNTeamsKO.SelectedIndex = 0;
				this.m_NPreliminaryTeams = (this.m_NTeams - this.m_NKnockOutTeams) * 2;
				this.KOToPanel();
				if (this.m_TournamentStructure == 2)
				{
					this.PreliminaryToPanel();
					return;
				}
			}
			else
			{
				if (this.m_TournamentStructure == 3)
				{
					this.m_NKnockOutTeams = (int)Math.Pow(2.0, Math.Floor(Math.Log((double)this.m_NTeams - 1.0, 2.0)));
					this.domainNTeamsKO.Items.Clear();
					if (this.m_NKnockOutTeams >= 2 && 2 > this.m_NGroups)
					{
						this.domainNTeamsKO.Items.Add("2");
					}
					if (this.m_NKnockOutTeams >= 4 && 4 > this.m_NGroups)
					{
						this.domainNTeamsKO.Items.Add("4");
					}
					if (this.m_NKnockOutTeams >= 8 && 8 > this.m_NGroups)
					{
						this.domainNTeamsKO.Items.Add("8");
					}
					if (this.m_NKnockOutTeams >= 16 && 16 > this.m_NGroups)
					{
						this.domainNTeamsKO.Items.Add("16");
					}
					if (this.m_NKnockOutTeams >= 32 && 32 > this.m_NGroups)
					{
						this.domainNTeamsKO.Items.Add("32");
					}
					this.domainNTeamsKO.SelectedIndex = 0;
					this.domainNTeamsKO.Enabled = true;
					this.KOToPanel();
					return;
				}
				int tournamentStructure = this.m_TournamentStructure;
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
		private void InitGroupsToPanel()
		{
			if (this.m_TournamentStructure == 3)
			{
				this.domainNGroups.Items.Clear();
				if (this.m_NTeams <= 16)
				{
					this.domainNGroups.Items.Add("1");
				}
				if (this.m_NTeams % 2 == 0 && this.m_NTeams >= 6)
				{
					this.domainNGroups.Items.Add("2");
				}
				if (this.m_NTeams % 4 == 0 && this.m_NTeams >= 12)
				{
					this.domainNGroups.Items.Add("4");
				}
				if (this.m_NTeams % 8 == 0 && this.m_NTeams >= 24)
				{
					this.domainNGroups.Items.Add("8");
				}
				this.domainNGroups.SelectedIndex = 0;
				this.numericTeamsPerGroup.Enabled = false;
				this.GroupToPanel();
				return;
			}
			int tournamentStructure = this.m_TournamentStructure;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0007EDA2 File Offset: 0x0007CFA2
		private void radioLeague_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioLeague.Checked)
			{
				this.m_TournamentStructure = 0;
				this.ToPanel();
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007EDBE File Offset: 0x0007CFBE
		private void radioKO_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioKO.Checked)
			{
				this.m_TournamentStructure = 1;
				this.InitKnockOutOptions();
				this.ToPanel();
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		private void radioPKO_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioPKO.Checked)
			{
				this.m_TournamentStructure = 2;
				this.InitKnockOutOptions();
				this.ToPanel();
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0007EE02 File Offset: 0x0007D002
		private void radioGKO_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioGKO.Checked)
			{
				this.m_TournamentStructure = 3;
				this.InitGroupsOptions();
				this.InitKnockOutOptions();
				this.ToPanel();
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0007EE2A File Offset: 0x0007D02A
		private void radioPGKO_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioPGKO.Checked)
			{
				this.m_TournamentStructure = 4;
				this.InitGroupsOptions();
				this.InitKnockOutOptions();
				this.ToPanel();
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0007EE52 File Offset: 0x0007D052
		private void radioWC2006_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioWC2006.Checked)
			{
				this.m_TournamentStructure = 5;
				this.ToPanel();
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0007EE6E File Offset: 0x0007D06E
		private void radioEuro2004_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioEuro2004.Checked)
			{
				this.m_TournamentStructure = 7;
				this.ToPanel();
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0007EE8A File Offset: 0x0007D08A
		private void radioEuro2008_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioEuro2008.Checked)
			{
				this.m_TournamentStructure = 6;
				this.ToPanel();
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0007EEA8 File Offset: 0x0007D0A8
		private void domainNTeamsKO_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.domainNTeamsKO.SelectedItem != null)
			{
				string text = this.domainNTeamsKO.SelectedItem.ToString();
				if (text == "2")
				{
					this.m_NKnockOutTeams = 2;
				}
				if (text == "4")
				{
					this.m_NKnockOutTeams = 4;
				}
				if (text == "8")
				{
					this.m_NKnockOutTeams = 8;
				}
				if (text == "16")
				{
					this.m_NKnockOutTeams = 16;
				}
				if (text == "32")
				{
					this.m_NKnockOutTeams = 32;
				}
				if (text == "64")
				{
					this.m_NKnockOutTeams = 64;
				}
				if (this.m_TournamentStructure == 2)
				{
					this.m_NPreliminaryTeams = (this.m_NTeams - this.m_NKnockOutTeams) * 2;
				}
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0007EF70 File Offset: 0x0007D170
		private void domainNGroups_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.domainNGroups.SelectedItem != null)
			{
				string text = this.domainNGroups.SelectedItem.ToString();
				if (text == "1")
				{
					this.m_NGroups = 1;
				}
				if (text == "2")
				{
					this.m_NGroups = 2;
				}
				if (text == "4")
				{
					this.m_NGroups = 4;
				}
				if (text == "8")
				{
					this.m_NGroups = 8;
				}
				if (text == "16")
				{
					this.m_NGroups = 16;
				}
				this.InitKnockOutOptions();
				if (this.m_TournamentStructure == 3)
				{
					this.m_NTeamsPerGroup = this.m_NTeamsInGroups / this.m_NGroups;
					this.GroupToPanel();
					this.KOToPanel();
				}
				if (this.m_TournamentStructure == 4)
				{
					this.m_NTeamsPerGroup = this.m_NTeamsInGroups / this.m_NGroups;
					this.m_NPreliminaryTeams = (this.m_NTeams - this.m_NTeamsInGroups) * 2;
					this.GroupToPanel();
					this.KOToPanel();
					this.PreliminaryToPanel();
				}
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0007F072 File Offset: 0x0007D272
		private void numericPrelimGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_PreliminaryGames = (int)this.numericPrelimGames.Value;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0007F08A File Offset: 0x0007D28A
		private void numericGamesPerGroup_ValueChanged(object sender, EventArgs e)
		{
			this.m_GroupGames = (int)this.numericGamesPerGroup.Value;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0007F0A2 File Offset: 0x0007D2A2
		private void numericKOGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_KnockOutGames = (int)this.numericKOGames.Value;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0007F0BA File Offset: 0x0007D2BA
		private void numericFinalGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_FinalGames = (int)this.numericFinalGames.Value;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0007F0D2 File Offset: 0x0007D2D2
		private void numericLeagueGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_LeagueGames = (int)this.numericLeagueGames.Value;
		}

		// Token: 0x040007C8 RID: 1992
		private int m_TournamentStructure;

		// Token: 0x040007C9 RID: 1993
		private int m_LeagueGames;

		// Token: 0x040007CA RID: 1994
		private int m_PreliminaryGames;

		// Token: 0x040007CB RID: 1995
		private int m_GroupGames;

		// Token: 0x040007CC RID: 1996
		private int m_KnockOutGames;

		// Token: 0x040007CD RID: 1997
		private int m_FinalGames;

		// Token: 0x040007CE RID: 1998
		private int m_NTeams;

		// Token: 0x040007CF RID: 1999
		private int m_NPreliminaryTeams;

		// Token: 0x040007D0 RID: 2000
		private int m_NKnockOutTeams;

		// Token: 0x040007D1 RID: 2001
		private int m_NTeamsInGroups;

		// Token: 0x040007D2 RID: 2002
		private int m_NGroups;

		// Token: 0x040007D3 RID: 2003
		private int m_NTeamsPerGroup;
	}
}
