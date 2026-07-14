using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200001A RID: 26
	public partial class SquadForm : Form
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x0006097E File Offset: 0x0005EB7E
		public SquadForm(Trophy currentTrophy)
		{
			this.InitializeComponent();
			if (this.m_LastSelectedTrophy == null)
			{
				this.m_LastSelectedTrophy = currentTrophy;
			}
			this.Initialize();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000609A4 File Offset: 0x0005EBA4
		public void Initialize()
		{
			this.comboTrophy.Items.Clear();
			foreach (object obj in FifaEnvironment.CompetitionObjects)
			{
				Trophy trophy = (Trophy)obj;
				if (trophy.TypeNumber == 3)
				{
					this.comboTrophy.Items.Add(trophy);
				}
			}
			this.comboTrophy.SelectedItem = this.m_LastSelectedTrophy;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00060A34 File Offset: 0x0005EC34
		private void comboTrophy_SelectedIndexChanged(object sender, EventArgs e)
		{
			Trophy trophy = (Trophy)this.comboTrophy.SelectedItem;
			this.m_LastSelectedTrophy = trophy;
			this.treeTurns.Nodes.Clear();
			TreeNode treeNode = null;
			foreach (object obj in this.m_LastSelectedTrophy.Stages)
			{
				Stage stage = (Stage)obj;
				treeNode = this.treeTurns.Nodes.Add(stage.ToString());
				treeNode.Tag = stage;
				if (stage.Groups.Count > 1)
				{
					using (IEnumerator enumerator2 = stage.Groups.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							Group group = (Group)obj2;
							TreeNode treeNode2 = treeNode.Nodes.Add(group.ToString());
							treeNode2.Tag = group;
							foreach (object obj3 in group.Ranks)
							{
								Rank rank = (Rank)obj3;
								treeNode2.Nodes.Add(rank.ToString()).Tag = rank;
							}
						}
						continue;
					}
				}
				foreach (object obj4 in ((Group)stage.Groups[0]).Ranks)
				{
					Rank rank2 = (Rank)obj4;
					treeNode.Nodes.Add(rank2.ToString()).Tag = rank2;
				}
			}
			if (treeNode != null)
			{
				treeNode.Expand();
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00060C68 File Offset: 0x0005EE68
		private void treeTurns_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.treeTurns.SelectedNode.Tag.GetType().FullName == "FifaLibrary.Squad")
			{
				this.buttonOK.Enabled = true;
				this.m_Rank = (Rank)this.treeTurns.SelectedNode.Tag;
				return;
			}
			this.buttonOK.Enabled = false;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00060CD0 File Offset: 0x0005EED0
		private void treeTurns_DoubleClick(object sender, EventArgs e)
		{
			if (this.treeTurns.SelectedNode.Tag.GetType().FullName == "FifaLibrary.Squad")
			{
				this.buttonOK.Enabled = true;
				this.m_Rank = (Rank)this.treeTurns.SelectedNode.Tag;
				this.buttonOK.PerformClick();
				return;
			}
			this.buttonOK.Enabled = false;
		}

		// Token: 0x04000603 RID: 1539
		public Rank m_Rank;

		// Token: 0x04000604 RID: 1540
		private Trophy m_LastSelectedTrophy;
	}
}
