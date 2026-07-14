using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000008 RID: 8
	public partial class QualifyRuleDialog : Form
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00006714 File Offset: 0x00004914
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000671C File Offset: 0x0000491C
		public Task QualifyRule
		{
			get
			{
				return this.m_QualifyRule;
			}
			set
			{
				this.m_QualifyRule = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000672C File Offset: 0x0000492C
		private void LoadToPanel()
		{
			this.Preset();
			this.m_Rule = this.m_QualifyRule.Rule;
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				this.m_League = this.m_QualifyRule.League;
				this.comboLeague.SelectedItem = this.m_League;
				this.radioRule4.Checked = true;
				break;
			case EQualifyingRule.FillFromLeagueInOrder:
				this.m_League = this.m_QualifyRule.League;
				this.comboLeague.SelectedItem = this.m_League;
				this.radioRule8.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTable:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.m_Number = this.m_QualifyRule.Parameter2;
				this.numericN.Value = this.m_Number;
				this.radioRule1.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTableBackup:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.m_Trophy2 = this.m_QualifyRule.Trophy2;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboTrophy2.SelectedItem = this.m_Trophy2;
				this.radioRule2.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.m_League = this.m_QualifyRule.League;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboLeague.SelectedItem = this.m_League;
				this.radioRule3.Checked = true;
				break;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				this.m_League = this.m_QualifyRule.League;
				this.comboLeague.SelectedItem = this.m_League;
				this.m_Number = this.m_QualifyRule.Parameter2;
				this.m_CountryLimitation = (uint)this.m_QualifyRule.Parameter3;
				this.numericN.Value = this.m_Number;
				this.numericCountryLimitation.Value = this.m_CountryLimitation;
				this.radioRule5.Checked = true;
				break;
			case EQualifyingRule.FillFromSpecialTeams:
				this.m_Number = this.m_QualifyRule.Parameter1;
				this.numericN.Value = this.m_Number;
				this.radioRule8.Checked = true;
				break;
			case EQualifyingRule.FillWithTeam:
				this.m_Team = this.m_QualifyRule.Team;
				this.comboTeam.SelectedItem = this.m_Team;
				this.m_Number = this.m_QualifyRule.Parameter1;
				this.numericN.Value = this.m_Number;
				this.radioRule7.Checked = true;
				break;
			}
			this.EnableRule();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006A00 File Offset: 0x00004C00
		public void Preset()
		{
			if (this.comboTrophy1.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy1.Items.Clear();
				this.comboTrophy1.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
			if (this.comboTrophy2.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy2.Items.Clear();
				this.comboTrophy2.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
			if (this.comboLeague.Items.Count != FifaEnvironment.Leagues.Count)
			{
				this.comboLeague.Items.Clear();
				this.comboLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
			if (this.comboTeam.Items.Count != FifaEnvironment.Teams.Count)
			{
				this.comboTeam.Items.Clear();
				this.comboTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006B39 File Offset: 0x00004D39
		public QualifyRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006B47 File Offset: 0x00004D47
		private void radioRule1_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTable;
			this.EnableRule();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006B56 File Offset: 0x00004D56
		private void radioRule2_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTableBackup;
			this.EnableRule();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006B65 File Offset: 0x00004D65
		private void radioRule3_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTableBackupLeague;
			this.EnableRule();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006B74 File Offset: 0x00004D74
		private void radioRule4_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeague;
			this.EnableRule();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006B83 File Offset: 0x00004D83
		private void radioRule5_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeagueMaxFromCountry;
			this.EnableRule();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006B92 File Offset: 0x00004D92
		private void radioRule6_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromSpecialTeams;
			this.EnableRule();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006BA1 File Offset: 0x00004DA1
		private void radioRule7_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillWithTeam;
			this.EnableRule();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006BB0 File Offset: 0x00004DB0
		private void radioRule8_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeagueInOrder;
			this.EnableRule();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006BC0 File Offset: 0x00004DC0
		private void EnableRule()
		{
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromLeagueInOrder:
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromCompTable:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				this.m_Trophy1 = (Trophy)this.comboTrophy1.SelectedItem;
				return;
			case EQualifyingRule.FillFromCompTableBackup:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboTrophy2.SelectedItem = this.m_Trophy2;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = true;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				this.comboLeague.SelectedItem = this.m_League;
				this.numericCountryLimitation.Value = this.m_CountryLimitation;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = true;
				return;
			case EQualifyingRule.FillFromSpecialTeams:
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillWithTeam:
				this.comboTeam.SelectedItem = this.m_Team;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = true;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006F5F File Offset: 0x0000515F
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTeam.SelectedItem != null)
			{
				this.m_Team = (Team)this.comboTeam.SelectedItem;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006F84 File Offset: 0x00005184
		private void numericN_ValueChanged(object sender, EventArgs e)
		{
			this.m_Number = (int)this.numericN.Value;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006F9C File Offset: 0x0000519C
		private void comboTrophy1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy1.SelectedItem != null)
			{
				this.m_Trophy1 = (Trophy)this.comboTrophy1.SelectedItem;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006FC1 File Offset: 0x000051C1
		private void comboLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague.SelectedItem != null)
			{
				this.m_League = (League)this.comboLeague.SelectedItem;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006FE6 File Offset: 0x000051E6
		private void comboTrophy2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy2.SelectedItem != null)
			{
				this.m_Trophy2 = (Trophy)this.comboTrophy2.SelectedItem;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000700C File Offset: 0x0000520C
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_QualifyRule.Rule = this.m_Rule;
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				if (this.m_League != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter2 = 0;
					this.m_QualifyRule.Parameter3 = 0;
					return;
				}
				break;
			case EQualifyingRule.FillFromLeagueInOrder:
				break;
			case EQualifyingRule.FillFromCompTable:
				if (this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_Number;
					this.m_QualifyRule.Parameter3 = 0;
					return;
				}
				break;
			case EQualifyingRule.FillFromCompTableBackup:
				if (this.m_Trophy2 != null && this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_Trophy2.Id;
					this.m_QualifyRule.Trophy2 = this.m_Trophy2;
					this.m_QualifyRule.Parameter3 = 1;
					return;
				}
				break;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				if (this.m_League != null && this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter3 = 1;
					return;
				}
				break;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				if (this.m_League != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter2 = this.m_Number;
					this.m_QualifyRule.Parameter3 = (int)this.m_CountryLimitation;
					return;
				}
				break;
			case EQualifyingRule.FillFromSpecialTeams:
				this.m_QualifyRule.Parameter1 = this.m_Number;
				this.m_QualifyRule.Parameter2 = 0;
				this.m_QualifyRule.Parameter3 = 0;
				return;
			case EQualifyingRule.FillWithTeam:
				if (this.m_Team != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Number;
					this.m_QualifyRule.Parameter2 = this.m_Team.Id;
					this.m_QualifyRule.Team = this.m_Team;
					this.m_QualifyRule.Parameter3 = 0;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000072A0 File Offset: 0x000054A0
		private void numericCountryLimitation_ValueChanged(object sender, EventArgs e)
		{
			this.m_CountryLimitation = (uint)this.numericCountryLimitation.Value;
		}

		// Token: 0x0400004A RID: 74
		private Task m_QualifyRule;

		// Token: 0x0400004B RID: 75
		private EQualifyingRule m_Rule;

		// Token: 0x0400004C RID: 76
		private Trophy m_Trophy1;

		// Token: 0x0400004D RID: 77
		private Trophy m_Trophy2;

		// Token: 0x0400004E RID: 78
		private League m_League;

		// Token: 0x0400004F RID: 79
		private Team m_Team;

		// Token: 0x04000050 RID: 80
		private int m_Number;

		// Token: 0x04000051 RID: 81
		private uint m_CountryLimitation;
	}
}
