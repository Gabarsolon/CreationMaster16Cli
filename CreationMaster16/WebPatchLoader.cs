using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000017 RID: 23
	public partial class WebPatchLoader : Form
	{
		// Token: 0x0600034A RID: 842 RVA: 0x000553F4 File Offset: 0x000535F4
		public WebPatchLoader()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00055404 File Offset: 0x00053604
		public new bool Load(DataTable dataTable, Bitmap picture)
		{
			this.m_WebData = dataTable;
			this.m_Picture = picture;
			this.pictureBox.BackgroundImage = this.m_Picture;
			this.comboReplaceTeam.Items.Clear();
			this.comboReplaceTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			this.comboReplaceTeam.Sorted = true;
			this.comboReplacePlayer.Items.Clear();
			this.comboReplacePlayer.Items.AddRange(FifaEnvironment.Players.ToArray());
			this.comboReplacePlayer.Sorted = true;
			this.listViewPatch.Items.Clear();
			foreach (object obj in this.m_WebData.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				string[] array = new string[]
				{
					(string)dataRow["name"],
					(string)dataRow["type"],
					(string)dataRow["id"]
				};
				int num = Convert.ToInt32(array[2]);
				PatchedObject patchedObject = new PatchedObject(array[1], array[0], num);
				patchedObject.AssignReplacedObject();
				ListViewItem listViewItem = new ListViewItem(array);
				listViewItem.Tag = patchedObject;
				listViewItem.ForeColor = patchedObject.GetColor();
				listViewItem.Checked = true;
				this.listViewPatch.Items.Add(listViewItem);
			}
			if (this.listViewPatch.Items[0].SubItems[1].Text == "Team")
			{
				this.checkTeamLogo.Visible = true;
				this.groupMinifaceOptions.Visible = false;
			}
			else if (this.listViewPatch.Items[0].SubItems[1].Text == "Player")
			{
				this.checkTeamLogo.Visible = false;
				this.groupMinifaceOptions.Visible = true;
			}
			else
			{
				this.checkTeamLogo.Visible = false;
				this.groupMinifaceOptions.Visible = false;
			}
			foreach (object obj2 in this.listViewPatch.Items)
			{
				((PatchedObject)((ListViewItem)obj2).Tag).AssignNewCmsObject();
			}
			foreach (object obj3 in this.listViewPatch.Items)
			{
				ListViewItem listViewItem2 = (ListViewItem)obj3;
				PatchedObject patchedObject2 = (PatchedObject)listViewItem2.Tag;
				patchedObject2.AssignNewObject();
				listViewItem2.ForeColor = patchedObject2.GetColor();
				listViewItem2.SubItems[2] = new ListViewItem.ListViewSubItem(listViewItem2, patchedObject2.ImportId.ToString());
			}
			this.listViewPatch.Items[0].Selected = true;
			this.buttonImportPatch.Enabled = true;
			return true;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001C96F File Offset: 0x0001AB6F
		private void buttonExitCreator_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0005574C File Offset: 0x0005394C
		private void RemoveNewObjectsNotImported()
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((PatchedObject)((ListViewItem)obj).Tag).RemoveNewObjectIfNotImported();
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000557B4 File Offset: 0x000539B4
		private void RemoveAllUnusedObjects()
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				if (!listViewItem.Checked)
				{
					patchedObject.RemoveNewObject();
				}
				else
				{
					patchedObject.RemoveNewObjectIfUnused();
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0005582C File Offset: 0x00053A2C
		private void buttonSelectAllObjects_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((ListViewItem)obj).Checked = true;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00055888 File Offset: 0x00053A88
		private void buttonSelectNewObjects_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Checked = listViewItem.ForeColor == Color.Green;
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000558F8 File Offset: 0x00053AF8
		private void buttonDeselectAllObjects_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((ListViewItem)obj).Checked = false;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00055954 File Offset: 0x00053B54
		private void listViewPatch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewPatch.SelectedItems.Count <= 0)
			{
				return;
			}
			ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
			this.m_CurrentPatchedObject = (PatchedObject)listViewItem.Tag;
			this.radioCreateItem.Checked = this.m_CurrentPatchedObject.IsUsedNewObject();
			this.radioReplaceItem.Checked = this.m_CurrentPatchedObject.IsUsedFittingObject();
			this.radioCmsItem.Checked = this.m_CurrentPatchedObject.IsUsedCmsObject();
			this.UpdateComboReplace(this.m_CurrentPatchedObject);
			this.UpdateTextCms(this.m_CurrentPatchedObject);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000559F4 File Offset: 0x00053BF4
		private void radioCreateItem_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioCreateItem.Checked)
			{
				if (this.listViewPatch.SelectedItems.Count <= 0)
				{
					return;
				}
				ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				patchedObject.UseNewObject();
				if (!patchedObject.IsUsedNewObject())
				{
					this.radioCreateItem.Checked = false;
					this.radioCmsItem.Checked = false;
					this.radioReplaceItem.Checked = true;
				}
				listViewItem.ForeColor = patchedObject.GetColor();
				listViewItem.SubItems[2] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00055AB0 File Offset: 0x00053CB0
		private void radioUsePatchItem_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioCmsItem.Checked)
			{
				if (this.listViewPatch.SelectedItems.Count <= 0)
				{
					return;
				}
				ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				patchedObject.UsePatchId();
				listViewItem.ForeColor = patchedObject.GetColor();
				listViewItem.SubItems[2] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00055B3C File Offset: 0x00053D3C
		private void radioReplaceItem_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioReplaceItem.Checked)
			{
				if (this.listViewPatch.SelectedItems.Count <= 0)
				{
					return;
				}
				ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				patchedObject.UseReplacedObject();
				listViewItem.ForeColor = patchedObject.GetColor();
				listViewItem.SubItems[2] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00055BC8 File Offset: 0x00053DC8
		private void comboReplace_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewPatch.SelectedItems.Count <= 0)
			{
				return;
			}
			ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
			PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
			ComboBox comboBox = (ComboBox)sender;
			patchedObject.ReplacedObject = comboBox.SelectedItem;
			listViewItem.SubItems[2] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00055C3C File Offset: 0x00053E3C
		private void UpdateComboReplace(PatchedObject patchedObject)
		{
			string type = patchedObject.Type;
			int id = patchedObject.Id;
			object replacedObject = patchedObject.ReplacedObject;
			if (this.comboReplacePlayer.Visible = type == "Player" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplacePlayer.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceTeam.Visible = type == "Team" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceTeam.SelectedItem = patchedObject.ReplacedObject;
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00055CCC File Offset: 0x00053ECC
		private void UpdateTextCms(PatchedObject patchedObject)
		{
			if (patchedObject.IsUsedCmsObject())
			{
				this.textCmsReplaced.Text = patchedObject.CmsObject.ToString();
				this.textCmsReplaced.Visible = !patchedObject.IsCmsNew;
				this.labelCmsCreated.Visible = patchedObject.IsCmsNew;
				this.labelCmsCreated.Text = "Create with id = " + patchedObject.ImportId;
				this.labelCmsReplaced.Visible = !patchedObject.IsCmsNew;
				return;
			}
			this.textCmsReplaced.Visible = false;
			this.labelCmsCreated.Visible = false;
			this.labelCmsReplaced.Visible = false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00055D75 File Offset: 0x00053F75
		private void WebPatchLoader_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.RemoveNewObjectsNotImported();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00055D7D File Offset: 0x00053F7D
		private void buttonImportPatch_Click(object sender, EventArgs e)
		{
			this.ImportWebPatch();
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00055D88 File Offset: 0x00053F88
		private void ImportWebPatch()
		{
			this.RemoveAllUnusedObjects();
			Team team = null;
			Player[] array = new Player[this.listViewPatch.Items.Count];
			int i = 0;
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				int index = listViewItem.Index;
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				if (listViewItem.Checked)
				{
					if (patchedObject.Type == "Team")
					{
						team = patchedObject.ImportWebTeam(this.m_WebData.Rows[index]);
					}
					else if (patchedObject.Type == "Player")
					{
						array[i] = patchedObject.ImportWebPlayer(this.m_WebData.Rows[index], team);
						if (array[i] != null)
						{
							i++;
						}
						else
						{
							this.listViewPatch.Items[index].Checked = false;
						}
					}
				}
			}
			int num = i;
			if (array.Length == 1)
			{
				if (this.radioMinifaceAlways.Checked)
				{
					array[0].SetPhoto(this.m_Picture);
				}
				else if (this.radioMinifaceNotPresent.Checked && array[0].GetPhoto() == null)
				{
					array[0].SetPhoto(this.m_Picture);
				}
			}
			if (team != null)
			{
				if (team.Formation == null)
				{
					Formation formation = FifaEnvironment.Formations.CreateNewFormation();
					team.Formation = formation;
				}
				for (int j = 0; j < num; j++)
				{
					TeamPlayer teamPlayer = team.Roster.SearchTeamPlayer(array[j]);
					if (teamPlayer == null)
					{
						teamPlayer = team.AddTeamPlayer(array[j]);
					}
					if (teamPlayer != null && array[j].preferredNumber != 0)
					{
						teamPlayer.jerseynumber = array[j].preferredNumber;
					}
				}
				for (int k = 0; k < team.Roster.Count; k++)
				{
					TeamPlayer teamPlayer2 = (TeamPlayer)team.Roster[k];
					int id = teamPlayer2.Player.Id;
					bool flag = false;
					for (i = 0; i < num; i++)
					{
						if (id == array[i].Id)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						team.RemoveTeamPlayer(teamPlayer2);
						k--;
					}
				}
				team.FixPlayersWithTwoClubs(true);
				team.AssignVacantRolesToSubstitute();
				team.AssignVacantSpecialPlayers();
				team.AssignBench();
				if (this.checkTeamLogo.Checked)
				{
					team.SetCrest(this.m_Picture);
					team.SetCrestDark(this.m_Picture);
				}
			}
			FifaEnvironment.UserMessages.ShowMessage(15005);
			base.Close();
		}

		// Token: 0x0400054E RID: 1358
		private DataTable m_WebData;

		// Token: 0x0400054F RID: 1359
		private Bitmap m_Picture;

		// Token: 0x04000550 RID: 1360
		private PatchedObject m_CurrentPatchedObject;
	}
}
