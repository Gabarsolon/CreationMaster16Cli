using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000003 RID: 3
	public partial class AudioForm : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003840 File Offset: 0x00001A40
		public AudioForm()
		{
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectPlayerAudio);
			this.viewer2DPhoto.ButtonStripVisible = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003890 File Offset: 0x00001A90
		public void Preset()
		{
			IdArrayList[] array = new IdArrayList[5];
			array[0] = null;
			array[1] = FifaEnvironment.Teams;
			array[2] = FifaEnvironment.Countries;
			array[3] = FifaEnvironment.FreeAgents;
			this.pickUpControl.FilterValues = array;
			this.pickUpControl.ObjectList = FifaEnvironment.Players;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000038DC File Offset: 0x00001ADC
		private void AudioForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
			this.LoadNameDictionary();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000038F4 File Offset: 0x00001AF4
		public void LoadPlayerAudio(Player player)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			this.m_CurrentPlayer = player;
			this.textKnownAs.Text = this.m_CurrentPlayer.audioname;
			this.textPlayerId.Text = this.m_CurrentPlayer.Id.ToString();
			string text = null;
			FifaEnvironment.NameDictionary.TryGetValue(this.m_CurrentPlayer.Id, out text);
			if (text != null)
			{
				this.textSurnameSoundId.Text = this.m_CurrentPlayer.Id.ToString();
			}
			else if (text == null)
			{
				FifaEnvironment.NameDictionary.TryGetValue(this.m_CurrentPlayer.commentaryid, out text);
				if (text != null)
				{
					this.textSurnameSoundId.Text = this.m_CurrentPlayer.commentaryid.ToString();
				}
				else
				{
					this.textSurnameSoundId.Text = "Not Assigned";
				}
			}
			this.textAudioName.Text = text;
			this.viewer2DPhoto.CurrentBitmap = this.m_CurrentPlayer.GetPhoto();
			this.textFirstName.Text = this.m_CurrentPlayer.firstname;
			this.textSurname.Text = this.m_CurrentPlayer.lastname;
			this.textCommonName.Text = this.m_CurrentPlayer.commonname;
			this.EnableDictionaryButtons();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003A3C File Offset: 0x00001C3C
		public void LoadNameDictionary()
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			this.listViewNameDictionary.BeginUpdate();
			this.listViewNameDictionary.Items.Clear();
			foreach (KeyValuePair<int, string> keyValuePair in FifaEnvironment.NameDictionary)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				ListViewItem listViewItem = new ListViewItem(key.ToString().PadLeft(6));
				listViewItem.SubItems.Add(value);
				listViewItem.Tag = keyValuePair;
				this.listViewNameDictionary.Items.Add(listViewItem);
			}
			this.listViewNameDictionary.EndUpdate();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003B08 File Offset: 0x00001D08
		private Player SelectPlayerAudio(object sender, object obj)
		{
			Player player = (Player)obj;
			this.LoadPlayerAudio(player);
			return player;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003B24 File Offset: 0x00001D24
		private void listViewNameDictionary_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView listView = (ListView)sender;
			SortOrder sortOrder;
			if (listView.Sorting == SortOrder.Ascending)
			{
				sortOrder = SortOrder.Descending;
			}
			else
			{
				sortOrder = SortOrder.Ascending;
			}
			listView.Sorting = sortOrder;
			listView.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
			this.KeepSelectedNameVisible();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003B66 File Offset: 0x00001D66
		private void listViewNameDictionary_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewNameDictionary.SelectedItems.Count > 0)
			{
				this.ShowSelectedNameDictionary();
				this.EnableDictionaryButtons();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003B88 File Offset: 0x00001D88
		private void numericNameDictionary_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentDictionaryKey == (int)this.numericNameDictionary.Value)
			{
				return;
			}
			this.m_CurrentDictionaryKey = (int)this.numericNameDictionary.Value;
			if (!this.SelectNameDictionaryItem(this.m_CurrentDictionaryKey))
			{
				this.textNameDictionary.Text = "<Unknown>";
			}
			else
			{
				this.KeepSelectedNameVisible();
			}
			this.EnableDictionaryButtons();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003BF0 File Offset: 0x00001DF0
		private void textNameDictionary_TextChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentDictionaryName == this.textNameDictionary.Text)
			{
				return;
			}
			this.m_CurrentDictionaryName = this.textNameDictionary.Text;
			this.EnableDictionaryButtons();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003C24 File Offset: 0x00001E24
		private void EnableDictionaryButtons()
		{
			this.buttonSearchSurnameId.Enabled = (this.buttonDeleteSound.Enabled = this.m_CurrentPlayer.commentaryid > 900000);
			if (this.m_CurrentDictionaryKey == 900000)
			{
				this.buttonReplaceName.Enabled = false;
				this.buttonRemoveName.Enabled = false;
				this.buttonAddName.Enabled = false;
				this.buttonSetSound.Enabled = false;
				return;
			}
			if (FifaEnvironment.NameDictionary.ContainsKey(this.m_CurrentDictionaryKey))
			{
				this.buttonRemoveName.Enabled = true;
				this.buttonAddName.Enabled = false;
				string text;
				if (FifaEnvironment.NameDictionary.TryGetValue(this.m_CurrentDictionaryKey, out text))
				{
					if (text == this.m_CurrentDictionaryName)
					{
						this.buttonReplaceName.Enabled = false;
						this.buttonSetSound.Enabled = this.m_CurrentDictionaryKey > 900000;
						return;
					}
					this.buttonReplaceName.Enabled = true;
					this.buttonSetSound.Enabled = false;
					return;
				}
			}
			else
			{
				this.buttonRemoveName.Enabled = false;
				this.buttonReplaceName.Enabled = false;
				this.buttonAddName.Enabled = true;
				this.buttonSetSound.Enabled = false;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003D54 File Offset: 0x00001F54
		private bool SelectNameDictionaryItem(int commentaryid)
		{
			if (this.listViewNameDictionary.SelectedItems.Count > 0)
			{
				this.listViewNameDictionary.SelectedItems[0].Selected = false;
			}
			for (int i = 0; i < this.listViewNameDictionary.Items.Count; i++)
			{
				if (((KeyValuePair<int, string>)this.listViewNameDictionary.Items[i].Tag).Key == commentaryid)
				{
					this.listViewNameDictionary.Items[i].Selected = true;
					if (i > 8)
					{
						this.listViewNameDictionary.TopItem = this.listViewNameDictionary.Items[i - 8];
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003E08 File Offset: 0x00002008
		private void KeepSelectedNameVisible()
		{
			if (this.listViewNameDictionary.SelectedItems.Count > 0)
			{
				int num = this.listViewNameDictionary.SelectedIndices[0];
				if (num > 8)
				{
					this.listViewNameDictionary.TopItem = this.listViewNameDictionary.Items[num - 8];
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003E5C File Offset: 0x0000205C
		private void ShowSelectedNameDictionary()
		{
			if (this.listViewNameDictionary.SelectedItems.Count > 0)
			{
				this.m_SelectedDictionaryName = (KeyValuePair<int, string>)this.listViewNameDictionary.SelectedItems[0].Tag;
				this.m_CurrentDictionaryKey = this.m_SelectedDictionaryName.Key;
				this.m_CurrentDictionaryName = this.m_SelectedDictionaryName.Value;
				this.numericNameDictionary.Value = this.m_CurrentDictionaryKey;
				this.textNameDictionary.Text = this.m_CurrentDictionaryName;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003EE6 File Offset: 0x000020E6
		private void buttonFindNameExact_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = AudioForm.SearchMode.SearchExact;
			this.Search();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003EF6 File Offset: 0x000020F6
		private void buttonFindNameStart_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = AudioForm.SearchMode.SearchStarting;
			this.Search();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003F06 File Offset: 0x00002106
		private void buttonFindNameAny_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = AudioForm.SearchMode.SearchContaining;
			this.Search();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003F18 File Offset: 0x00002118
		public bool Search()
		{
			bool flag = false;
			if (this.textSearchNameDictionary.Text == null || this.textSearchNameDictionary.Text == string.Empty)
			{
				return false;
			}
			this.m_Pattern = this.textSearchNameDictionary.Text;
			this.m_Pattern = this.m_Pattern.ToLower();
			int num = this.m_CurrentSearchIndex;
			num++;
			if (num >= this.listViewNameDictionary.Items.Count)
			{
				num = 0;
			}
			KeyValuePair<int, string> keyValuePair;
			for (;;)
			{
				keyValuePair = (KeyValuePair<int, string>)this.listViewNameDictionary.Items[num].Tag;
				string text = keyValuePair.Value;
				text = text.ToLower();
				switch (this.m_SearchMode)
				{
				case AudioForm.SearchMode.SearchExact:
					flag = text.ToString().Equals(this.m_Pattern);
					break;
				case AudioForm.SearchMode.SearchStarting:
					flag = text.ToString().StartsWith(this.m_Pattern);
					break;
				case AudioForm.SearchMode.SearchContaining:
					flag = text.Contains(this.m_Pattern);
					break;
				}
				if (flag)
				{
					break;
				}
				if (num == this.m_CurrentSearchIndex)
				{
					return false;
				}
				num++;
				if (num == this.listViewNameDictionary.Items.Count)
				{
					num = 0;
				}
			}
			this.m_CurrentSearchIndex = num;
			this.numericNameDictionary.Value = keyValuePair.Key;
			return true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000405C File Offset: 0x0000225C
		private void buttonAddName_Click(object sender, EventArgs e)
		{
			FifaEnvironment.NameDictionary.Add(this.m_CurrentDictionaryKey, this.m_CurrentDictionaryName);
			ListViewItem listViewItem = new ListViewItem(this.m_CurrentDictionaryKey.ToString().PadLeft(6));
			listViewItem.SubItems.Add(this.m_CurrentDictionaryName);
			KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(this.m_CurrentDictionaryKey, this.m_CurrentDictionaryName);
			listViewItem.Tag = keyValuePair;
			this.listViewNameDictionary.Items.Add(listViewItem);
			this.SelectNameDictionaryItem(this.m_CurrentDictionaryKey);
			this.EnableDictionaryButtons();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000040EC File Offset: 0x000022EC
		private void buttonRemoveName_Click(object sender, EventArgs e)
		{
			FifaEnvironment.NameDictionary.Remove(this.m_CurrentDictionaryKey);
			for (int i = 0; i < this.listViewNameDictionary.Items.Count; i++)
			{
				if (((KeyValuePair<int, string>)this.listViewNameDictionary.Items[i].Tag).Key == this.m_CurrentDictionaryKey)
				{
					this.listViewNameDictionary.Items.RemoveAt(i);
					this.EnableDictionaryButtons();
					return;
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004168 File Offset: 0x00002368
		private void buttonReplaceName_Click(object sender, EventArgs e)
		{
			FifaEnvironment.NameDictionary.Remove(this.m_CurrentDictionaryKey);
			FifaEnvironment.NameDictionary.Add(this.m_CurrentDictionaryKey, this.m_CurrentDictionaryName);
			for (int i = 0; i < this.listViewNameDictionary.Items.Count; i++)
			{
				if (((KeyValuePair<int, string>)this.listViewNameDictionary.Items[i].Tag).Key == this.m_CurrentDictionaryKey)
				{
					this.listViewNameDictionary.Items[i].SubItems[1].Text = this.m_CurrentDictionaryName;
					this.EnableDictionaryButtons();
					return;
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004210 File Offset: 0x00002410
		private void buttonSearchPlayerId_Click(object sender, EventArgs e)
		{
			this.numericNameDictionary.Value = this.m_CurrentPlayer.Id;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000422D File Offset: 0x0000242D
		private void buttonSearchSurnameId_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentPlayer.commentaryid == 900000)
			{
				return;
			}
			this.numericNameDictionary.Value = this.m_CurrentPlayer.commentaryid;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000425D File Offset: 0x0000245D
		private void buttonDeleteSound_Click(object sender, EventArgs e)
		{
			FifaEnvironment.Players.SetGenericAudio(this.m_CurrentPlayer.audioname, 900000);
			this.LoadPlayerAudio(this.m_CurrentPlayer);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004286 File Offset: 0x00002486
		private void buttonSetSound_Click(object sender, EventArgs e)
		{
			FifaEnvironment.Players.SetGenericAudio(this.m_CurrentPlayer.audioname, this.m_CurrentDictionaryKey);
			this.LoadPlayerAudio(this.m_CurrentPlayer);
		}

		// Token: 0x0400001D RID: 29
		private bool m_IsLoaded;

		// Token: 0x0400001E RID: 30
		public Player m_CurrentPlayer;

		// Token: 0x0400001F RID: 31
		private KeyValuePair<int, string> m_SelectedDictionaryName;

		// Token: 0x04000020 RID: 32
		private int m_CurrentDictionaryKey = 900000;

		// Token: 0x04000021 RID: 33
		private string m_CurrentDictionaryName;

		// Token: 0x04000022 RID: 34
		private AudioForm.SearchMode m_SearchMode = AudioForm.SearchMode.SearchContaining;

		// Token: 0x04000023 RID: 35
		private string m_Pattern;

		// Token: 0x04000024 RID: 36
		private int m_CurrentSearchIndex;

		// Token: 0x02000023 RID: 35
		private enum SearchMode
		{
			// Token: 0x04000A48 RID: 2632
			SearchExact,
			// Token: 0x04000A49 RID: 2633
			SearchStarting,
			// Token: 0x04000A4A RID: 2634
			SearchContaining
		}
	}
}
