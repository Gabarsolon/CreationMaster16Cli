using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000003 RID: 3
	public partial class AdvanceRuleDialog : Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000289C File Offset: 0x00000A9C
		public AdvanceRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000028AA File Offset: 0x00000AAA
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000028B2 File Offset: 0x00000AB2
		public Rank Rule
		{
			get
			{
				return this.m_Rule;
			}
			set
			{
				this.m_Rule = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028C4 File Offset: 0x00000AC4
		public void Preset()
		{
			if (this.comboTrophy.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy.Items.Clear();
				this.comboTrophy.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002924 File Offset: 0x00000B24
		private void LoadToPanel()
		{
			this.Preset();
			Group group = null;
			if (this.m_Rule.MoveFrom != null)
			{
				group = this.m_Rule.MoveFrom.Group;
				if (group != null)
				{
					this.m_Trophy = group.ParentTrophy;
				}
			}
			if (group == null)
			{
				group = this.m_Rule.Group;
			}
			if (this.m_Trophy == null)
			{
				this.m_Trophy = this.m_Rule.Group.ParentTrophy;
			}
			this.comboTrophy.SelectedItem = this.m_Trophy;
			this.comboStage.Items.Clear();
			foreach (object obj in this.m_Trophy.Stages)
			{
				Stage stage = (Stage)obj;
				this.comboStage.Items.Add(stage);
			}
			if (group != null)
			{
				this.m_Stage = group.ParentStage;
			}
			else
			{
				this.m_Stage = this.m_Rule.Group.ParentStage;
			}
			this.comboStage.SelectedItem = this.m_Stage;
			this.comboGroup.Items.Clear();
			foreach (object obj2 in this.m_Stage.Groups)
			{
				Group group2 = (Group)obj2;
				this.comboGroup.Items.Add(group2);
			}
			this.m_Group = group;
			this.comboGroup.SelectedItem = group;
			this.comboTeam.Items.Clear();
			foreach (object obj3 in this.m_Group.Ranks)
			{
				Rank rank = (Rank)obj3;
				this.comboTeam.Items.Add(rank);
			}
			this.comboTeam.SelectedItem = this.m_Rule.MoveFrom;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002B48 File Offset: 0x00000D48
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

		// Token: 0x06000012 RID: 18 RVA: 0x00002BF8 File Offset: 0x00000DF8
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
				if (this.m_Stage.Groups.Count >= 1)
				{
					this.comboGroup.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002CBC File Offset: 0x00000EBC
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

		// Token: 0x06000014 RID: 20 RVA: 0x00002D6C File Offset: 0x00000F6C
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_Rule.MoveFrom = (Rank)this.comboTeam.SelectedItem;
		}

		// Token: 0x0400000B RID: 11
		private Rank m_Rule;

		// Token: 0x0400000C RID: 12
		private Trophy m_Trophy;

		// Token: 0x0400000D RID: 13
		private Stage m_Stage;

		// Token: 0x0400000E RID: 14
		private Group m_Group;
	}
}
