using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000A RID: 10
	public partial class RankingRuleDialog : Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000926D File Offset: 0x0000746D
		public RankingRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000927B File Offset: 0x0000747B
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00009283 File Offset: 0x00007483
		public Rank Rank
		{
			get
			{
				return this.m_Rank;
			}
			set
			{
				this.m_Rank = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009294 File Offset: 0x00007494
		public void Preset()
		{
			if (this.comboTrophy.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy.Items.Clear();
				this.comboTrophy.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000092F4 File Offset: 0x000074F4
		private void LoadToPanel()
		{
			this.Preset();
			Group group = null;
			group = this.m_Rank.Group;
			if (group == null)
			{
				return;
			}
			this.m_Trophy = group.ParentTrophy;
			if (this.m_Trophy == null)
			{
				return;
			}
			this.comboTrophy.SelectedItem = this.m_Trophy;
			this.comboStage.Items.Clear();
			foreach (object obj in this.m_Trophy.Stages)
			{
				Stage stage = (Stage)obj;
				this.comboStage.Items.Add(stage);
			}
			this.m_Stage = this.m_Rank.Group.ParentStage;
			this.comboStage.SelectedItem = this.m_Stage;
			this.comboGroup.Items.Clear();
			foreach (object obj2 in this.m_Stage.Groups)
			{
				Group group2 = (Group)obj2;
				this.comboGroup.Items.Add(group2);
			}
			this.m_Group = group;
			this.comboGroup.SelectedItem = this.m_Group;
			this.comboTeam.Items.Clear();
			for (int i = 1; i < this.m_Group.Ranks.Count; i++)
			{
				this.comboTeam.Items.Add(this.m_Group.Ranks[i]);
			}
			this.comboTeam.SelectedItem = this.m_Rank;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000094B8 File Offset: 0x000076B8
		private void comboTrophy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy.SelectedItem != this.m_Trophy)
			{
				this.m_Trophy = (Trophy)this.comboTrophy.SelectedItem;
				this.comboStage.Items.Clear();
				foreach (object obj in this.m_Trophy.Stages)
				{
					Stage stage = (Stage)obj;
					this.comboStage.Items.Add(stage);
				}
				this.comboStage.SelectedIndex = 0;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009568 File Offset: 0x00007768
		private void comboStage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboStage.SelectedItem != this.m_Stage)
			{
				this.m_Stage = (Stage)this.comboStage.SelectedItem;
				this.comboGroup.Items.Clear();
				foreach (object obj in this.m_Stage.Groups)
				{
					Group group = (Group)obj;
					this.comboGroup.Items.Add(group);
				}
				this.comboGroup.SelectedIndex = 0;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00009618 File Offset: 0x00007818
		private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboGroup.SelectedItem != this.m_Group)
			{
				this.m_Group = (Group)this.comboGroup.SelectedItem;
				this.comboTeam.Items.Clear();
				foreach (object obj in this.m_Group.Ranks)
				{
					Rank rank = (Rank)obj;
					this.comboTeam.Items.Add(rank);
				}
				this.comboTeam.SelectedIndex = 0;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000096C8 File Offset: 0x000078C8
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_Rank = (Rank)this.comboTeam.SelectedItem;
		}

		// Token: 0x04000076 RID: 118
		private Rank m_Rank;

		// Token: 0x04000077 RID: 119
		private Trophy m_Trophy;

		// Token: 0x04000078 RID: 120
		private Stage m_Stage;

		// Token: 0x04000079 RID: 121
		private Group m_Group;
	}
}
