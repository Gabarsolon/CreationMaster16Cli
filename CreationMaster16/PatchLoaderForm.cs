using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;
using ICSharpCode.SharpZipLib.Zip;

namespace CreationMaster
{
	// Token: 0x0200000E RID: 14
	public partial class PatchLoaderForm : Form
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000225A2 File Offset: 0x000207A2
		public int PatchYear
		{
			get
			{
				return this.m_PatchYear;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000225AA File Offset: 0x000207AA
		public bool IsLastObjectCrossReferenced
		{
			get
			{
				return this.m_IsLastObjectCrossReferenced;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000225B4 File Offset: 0x000207B4
		public PatchLoaderForm()
		{
			this.InitializeComponent();
			this.m_FifaDataSet.Locale = CultureInfo.InvariantCulture;
			this.m_LangDataSet.Locale = CultureInfo.InvariantCulture;
			this.m_PatchDataSet.Locale = CultureInfo.InvariantCulture;
			this.InitPatchLoaderForm();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0002262E File Offset: 0x0002082E
		private void buttonLoadPatch_Click(object sender, EventArgs e)
		{
			this.OpenPatch();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00022638 File Offset: 0x00020838
		private void OpenPatch()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Title = "Open Creation Master Patch file";
			openFileDialog.Filter = "Creation Master Patch (*.cmp)|*.cmp";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return;
			}
			string fileName = openFileDialog.FileName;
			openFileDialog.Dispose();
			if (!File.Exists(fileName))
			{
				return;
			}
			this.Refresh();
			Cursor.Current = Cursors.WaitCursor;
			if (Directory.Exists(this.m_TempFolder))
			{
				Directory.Delete(this.m_TempFolder, true);
			}
			Directory.CreateDirectory(this.m_TempFolder);
			Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			new ZipFile(fileName);
			ZipInputStream zipInputStream = new ZipInputStream(stream);
			this.ZipExtractAllFiles(zipInputStream, this.m_TempFolder);
			zipInputStream.Close();
			bool flag = this.OpenCM12();
			this.buttonImportPatch.Enabled = flag;
			this.importToolStripMenuItem.Enabled = flag;
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0002262E File Offset: 0x0002082E
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenPatch();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00022724 File Offset: 0x00020924
		private void ZipExtractSingleFile(ZipInputStream zip, ZipEntry zipEntry, string exportFolder)
		{
			string text = exportFolder + "\\" + Path.GetDirectoryName(zipEntry.Name);
			if (Path.GetFileName(zipEntry.Name) != string.Empty)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				FileStream fileStream = File.Create(exportFolder + "\\" + zipEntry.Name);
				byte[] array = new byte[2048];
				for (;;)
				{
					int num = zip.Read(array, 0, array.Length);
					if (num <= 0)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
				fileStream.Close();
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000227B8 File Offset: 0x000209B8
		private void ZipExtractAllFiles(ZipInputStream zip, string exportFolder)
		{
			ZipEntry nextEntry;
			while ((nextEntry = zip.GetNextEntry()) != null)
			{
				this.ZipExtractSingleFile(zip, nextEntry, exportFolder);
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000227DC File Offset: 0x000209DC
		private void RemoveAllNewObjects()
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((PatchedObject)((ListViewItem)obj).Tag).RemoveNewObject();
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00022844 File Offset: 0x00020A44
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

		// Token: 0x06000173 RID: 371 RVA: 0x000228BC File Offset: 0x00020ABC
		private bool OpenCM12()
		{
			this.statusLabel.Text = "Loading...";
			this.statusBar.Refresh();
			this.m_FifaDataSet.Locale = CultureInfo.InvariantCulture;
			this.m_LangDataSet.Locale = CultureInfo.InvariantCulture;
			this.m_PatchDataSet.Locale = CultureInfo.InvariantCulture;
			this.m_PatchDataSet.Tables.Clear();
			this.m_FifaDataSet.Tables.Clear();
			this.m_LangDataSet.Tables.Clear();
			this.m_PatchDataSet.ReadXml(this.m_TempFolder + "\\Patch.xml");
			this.m_FifaDataSet.ReadXml(this.m_TempFolder + "\\fifa.xml");
			this.m_LangDataSet.ReadXml(this.m_TempFolder + "\\lang.xml");
			if (this.m_FifaDataSet.DataSetName != "FIFA14" && this.m_FifaDataSet.DataSetName != "FIFA15" && this.m_FifaDataSet.DataSetName != "FIFA16")
			{
				FifaEnvironment.UserMessages.ShowMessage(1032);
				return false;
			}
			if (this.m_FifaDataSet.DataSetName == "FIFA14")
			{
				this.m_PatchYear = 14;
			}
			else if (this.m_FifaDataSet.DataSetName == "FIFA15")
			{
				this.m_PatchYear = 15;
			}
			else if (this.m_FifaDataSet.DataSetName == "FIFA16")
			{
				this.m_PatchYear = 16;
			}
			this.comboReplaceTeam.Items.Clear();
			this.comboReplaceTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			this.comboReplaceTeam.Sorted = true;
			this.comboReplacePlayer.Items.Clear();
			this.comboReplacePlayer.Items.AddRange(FifaEnvironment.Players.ToArray());
			this.comboReplacePlayer.Sorted = true;
			this.comboReplaceLeague.Items.Clear();
			this.comboReplaceLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboReplaceLeague.Sorted = true;
			this.comboReplaceCountry.Items.Clear();
			this.comboReplaceCountry.Items.AddRange(FifaEnvironment.Countries.ToArray());
			this.comboReplaceCountry.Sorted = true;
			this.comboReplaceStadium.Items.Clear();
			this.comboReplaceStadium.Items.AddRange(FifaEnvironment.Stadiums.ToArray());
			this.comboReplaceStadium.Sorted = true;
			this.comboReplaceReferee.Items.Clear();
			this.comboReplaceReferee.Items.AddRange(FifaEnvironment.Referees.ToArray());
			this.comboReplaceReferee.Sorted = true;
			this.comboReplaceFormation.Items.Clear();
			this.comboReplaceFormation.Items.AddRange(FifaEnvironment.Formations.ToArray());
			this.comboReplaceBall.Items.Clear();
			this.comboReplaceBall.Items.AddRange(FifaEnvironment.Balls.ToArray());
			this.comboReplaceAdboard.Items.Clear();
			this.comboReplaceAdboard.Items.AddRange(FifaEnvironment.Adboards.ToArray());
			this.comboReplaceNumberFont.Items.Clear();
			this.comboReplaceNumberFont.Items.AddRange(FifaEnvironment.NumberFonts.ToArray());
			this.comboReplaceNamesFont.Items.Clear();
			this.comboReplaceNamesFont.Items.AddRange(FifaEnvironment.NameFonts.ToArray());
			this.comboReplaceShoes.Items.Clear();
			this.comboReplaceShoes.Items.AddRange(FifaEnvironment.Shoes.ToArray());
			this.comboReplaceNet.Items.Clear();
			this.comboReplaceNet.Items.AddRange(FifaEnvironment.Nets.ToArray());
			this.comboReplaceGkGloves.Items.Clear();
			this.comboReplaceGkGloves.Items.AddRange(FifaEnvironment.GkGloves.ToArray());
			this.comboReplaceMowingPattern.Items.Clear();
			this.comboReplaceMowingPattern.Items.AddRange(FifaEnvironment.MowingPatterns.ToArray());
			this.comboReplaceKit.Items.Clear();
			this.comboReplaceKit.Items.AddRange(FifaEnvironment.Kits.ToArray());
			this.labelDetails.Text = "Patch created for " + this.m_FifaDataSet.DataSetName;
			this.panelLeft.Enabled = true;
			this.panelRight.Enabled = true;
			this.textPatchName.Text = (string)this.m_PatchDataSet.Tables["PatchIdentity"].Rows[0].ItemArray[0];
			this.textPatchVersion.Text = (string)this.m_PatchDataSet.Tables["PatchIdentity"].Rows[0].ItemArray[1];
			this.textDescription.Text = (string)this.m_PatchDataSet.Tables["PatchIdentity"].Rows[0].ItemArray[2];
			string text = (string)this.m_PatchDataSet.Tables["PatchIdentity"].Rows[0].ItemArray[3];
			if (text != null && text != string.Empty)
			{
				this.m_PatchDatabaseVersion = Convert.ToInt32(text);
			}
			else
			{
				this.m_PatchDatabaseVersion = 0;
			}
			this.listViewPatch.Items.Clear();
			foreach (object obj in this.m_PatchDataSet.Tables["PatchElements"].Rows)
			{
				DataRow dataRow = (DataRow)obj;
				int num = dataRow.ItemArray.Length;
				string[] array = new string[]
				{
					null,
					null,
					null,
					null,
					(string)dataRow.ItemArray[0]
				};
				array[3] = string.Empty;
				array[1] = (string)dataRow.ItemArray[1];
				array[2] = (string)dataRow.ItemArray[2];
				array[0] = (string)dataRow.ItemArray[3];
				int num2 = Convert.ToInt32(array[2]);
				PatchedObject patchedObject = new PatchedObject(array[1], array[0], num2);
				patchedObject.AssignReplacedObject();
				ListViewItem listViewItem = new ListViewItem(array);
				listViewItem.Tag = patchedObject;
				this.listViewPatch.Items.Add(listViewItem);
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
				listViewItem2.Checked = listViewItem2.ForeColor == Color.Green;
				listViewItem2.SubItems[3] = new ListViewItem.ListViewSubItem(listViewItem2, patchedObject2.ImportId.ToString());
			}
			this.statusLabel.Text = "Ready";
			this.statusBar.Refresh();
			return true;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00023094 File Offset: 0x00021294
		public bool IsItemChecked(string type, string name)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				if (patchedObject.GetObjectType() == type && patchedObject.Name == name)
				{
					return listViewItem.Checked;
				}
			}
			return false;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00023124 File Offset: 0x00021324
		private void InitPatchLoaderForm()
		{
			this.m_TempFolder = FifaEnvironment.TempFolder + "\\Patch";
			this.listViewPatch.Items.Clear();
			this.buttonImportPatch.Enabled = false;
			this.panelGraphicGroups.Visible = false;
			this.tabPreview.Visible = false;
			this.stripButtonPreview.Checked = false;
			this.labelDetails.Text = string.Empty;
			this.textPatchName.Text = string.Empty;
			this.textPatchVersion.Text = string.Empty;
			this.textDescription.Text = string.Empty;
			this.viewer2D.CurrentBitmap = null;
			this.multiViewer2D.Bitmaps = null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000231E0 File Offset: 0x000213E0
		public int CrossReference(string type, int id)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				PatchedObject patchedObject = (PatchedObject)((ListViewItem)obj).Tag;
				if (patchedObject.Id == id && patchedObject.GetObjectType() == type)
				{
					this.m_IsLastObjectCrossReferenced = true;
					return patchedObject.ImportId;
				}
			}
			this.m_IsLastObjectCrossReferenced = false;
			return id;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00023274 File Offset: 0x00021474
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
			this.SelectViewerRadio();
			this.Preview();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00023320 File Offset: 0x00021520
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

		// Token: 0x06000179 RID: 377 RVA: 0x000233CC File Offset: 0x000215CC
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
			if (this.comboReplaceLeague.Visible = type == "League" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceLeague.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceCountry.Visible = type == "Country" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceCountry.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceStadium.Visible = type == "Stadium" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceStadium.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceReferee.Visible = type == "Referee" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceReferee.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceFormation.Visible = type == "Formation" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceFormation.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceSponsor.Visible = type == "Sponsor" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceSponsor.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceBall.Visible = type == "Ball" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceBall.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceAdboard.Visible = type == "Adboard" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceAdboard.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceNumberFont.Visible = type == "NumberFont" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceNumberFont.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceNamesFont.Visible = type == "NameFont" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceNamesFont.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceShoes.Visible = type == "Shoes" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceShoes.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceNet.Visible = type == "Net" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceNet.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceGkGloves.Visible = type == "GkGloves" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceGkGloves.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceMowingPattern.Visible = type == "MowingPattern" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceMowingPattern.SelectedItem = patchedObject.ReplacedObject;
			}
			if (this.comboReplaceKit.Visible = type == "Kit" && patchedObject.IsUsedFittingObject())
			{
				this.comboReplaceKit.SelectedItem = patchedObject.ReplacedObject;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00023798 File Offset: 0x00021998
		private void SelectViewerRadio()
		{
			string text = this.listViewPatch.SelectedItems[0].SubItems[1].Text;
			this.groupPlayer.Visible = text == "Player";
			this.groupTeam.Visible = text == "Team";
			this.groupLeague.Visible = text == "League";
			this.groupStadium.Visible = text == "Stadium";
			this.groupCountry.Visible = text == "Country";
			this.groupBall.Visible = text == "Ball";
			this.groupShoes.Visible = text == "Shoes";
			this.groupAdboards.Visible = text == "Adboard";
			this.groupKit.Visible = text == "Kit";
			if (this.stripButtonPreview.Checked)
			{
				this.Preview();
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000238A0 File Offset: 0x00021AA0
		private void radioViewer_CheckedChanged(object sender, EventArgs e)
		{
			if (!((RadioButton)sender).Checked)
			{
				return;
			}
			this.Preview();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000238B8 File Offset: 0x00021AB8
		private void buttonSelectAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((ListViewItem)obj).Checked = true;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00023914 File Offset: 0x00021B14
		private void buttonDeselectAll_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((ListViewItem)obj).Checked = false;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00023970 File Offset: 0x00021B70
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
				listViewItem.SubItems[3] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00023A2C File Offset: 0x00021C2C
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
				listViewItem.SubItems[3] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00023AB8 File Offset: 0x00021CB8
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
				listViewItem.SubItems[3] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
				this.UpdateComboReplace(patchedObject);
				this.UpdateTextCms(patchedObject);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00023B44 File Offset: 0x00021D44
		private void stripButtonPreview_Click(object sender, EventArgs e)
		{
			if (!this.stripButtonPreview.Checked)
			{
				this.tabPreview.Visible = false;
				this.panelGraphicGroups.Visible = false;
				return;
			}
			this.tabPreview.Visible = true;
			this.panelGraphicGroups.Visible = true;
			this.Preview();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00023B98 File Offset: 0x00021D98
		private void Preview()
		{
			if (!this.stripButtonPreview.Checked)
			{
				this.tabPreview.Visible = false;
				return;
			}
			if (this.listViewPatch.SelectedItems.Count <= 0)
			{
				return;
			}
			ListViewItem listViewItem = this.listViewPatch.SelectedItems[0];
			string text = listViewItem.SubItems[1].Text;
			int num = Convert.ToInt32(listViewItem.SubItems[2].Text);
			if (text == "Country")
			{
				if (this.radioCountryMainFlag.Checked)
				{
					string text2 = this.m_TempFolder + "\\" + Country.FlagBigFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowBigFile(text2);
					return;
				}
				if (this.radioCountryMiniflag.Checked)
				{
					string text2 = this.m_TempFolder + "\\" + Country.MiniFlagBigFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowBigFile(text2);
					return;
				}
				if (this.radioCountryCard.Checked)
				{
					string text2 = this.m_TempFolder + "\\" + Country.CardFlagBigFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowBigFile(text2);
					return;
				}
				if (this.radioCountryFlag512x512.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Country.Flag512DdsFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioCountryCard.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Country.ShapeFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
			}
			else if (text == "League")
			{
				if (this.radioLeagueTinyLogo.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + League.TinyLogoDdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioLeagueAnimLogo.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + League.AnimLogoDdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioLeagueSmallLogo.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + League.SmallLogoDdsFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioLeagueLogo512x128.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + League.Logo512x128DdsFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
			}
			else if (text == "Team")
			{
				if (this.radioTeamBanners.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Team.BannerFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioTeamFlags.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Team.FlagFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioTeamCrestLarge.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Team.CrestDdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioTeamCrest50.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Team.Crest50DdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioTeamCrest32.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Team.Crest32DdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
				if (this.radioTeamCrest16.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Team.Crest16DdsFileName(num, this.m_PatchYear);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
			}
			else if (text == "Player")
			{
				if (this.radioEyesTexture.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Player.SpecificEyesTextureFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioFaceTexture.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Player.SpecificFaceTextureFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioHairTextures.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Player.SpecificHairTexturesFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioMiniHead.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Player.SpecificPhotoDdsFileName(num);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
			}
			else if (text == "Kit")
			{
				int num2 = num / 10;
				int num3 = num - 10 * num2;
				if (this.radioKitKit.Checked)
				{
					string text4 = this.m_TempFolder + "\\" + Kit.KitTextureFileName(num2, num3, 0);
					this.ShowRx3File(text4);
					return;
				}
				if (this.radioKitMinikit.Checked)
				{
					string text3 = this.m_TempFolder + "\\" + Kit.MiniKitDdsFileName(num2, num3, 0);
					this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
					this.ShowDdsFile(text3);
					return;
				}
			}
			else
			{
				if (text == "NumberFont")
				{
					int num4 = num / 20;
					int num5 = num - 20 * num4;
					string text4 = this.m_TempFolder + "\\" + NumberFont.NumberFontFileName(num4, num5);
					this.ShowRx3File(text4);
					return;
				}
				if (text == "Net")
				{
					string text4 = this.m_TempFolder + "\\" + Net.NetFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (text == "MowingPattern")
				{
					string text4 = this.m_TempFolder + "\\" + MowingPattern.MowingPatternFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (text == "Adboard")
				{
					string text4 = this.m_TempFolder + "\\" + Adboard.AdboardFileName(num);
					this.ShowRx3File(text4);
					return;
				}
				if (text == "Shoes")
				{
					string text4 = this.m_TempFolder + "\\" + Shoes.ShoesTexturesFileName(num, 0);
					this.ShowRx3File(text4);
					return;
				}
				if (text == "Ball")
				{
					if (this.radioBallTexture.Checked)
					{
						string text4 = this.m_TempFolder + "\\" + Ball.BallTextureFileName(num);
						this.ShowRx3File(text4);
						return;
					}
					if (this.radioBallPreview.Checked && FifaEnvironment.Year == 14)
					{
						string text2 = this.m_TempFolder + "\\" + Ball.BallPictureBigFileName(num);
						this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Center;
						this.ShowBigFile(text2);
						return;
					}
				}
				else if (text == "Stadium")
				{
					int num6 = 0;
					if (this.radioStadiumGuiOvercast.Checked)
					{
						num6 = 0;
					}
					if (this.radioStadiumGuiClearDay.Checked)
					{
						num6 = 1;
					}
					if (this.radioStadiumGuiNight.Checked)
					{
						num6 = 3;
					}
					if (this.radioStadiumGuiSunset.Checked)
					{
						num6 = 4;
					}
					if (this.radioStadium3D.Checked)
					{
						if (num6 == 1 || num6 == 3)
						{
							string text4 = this.m_TempFolder + "\\" + Stadium.TexturesFileName(num, num6);
							this.ShowRx3File(text4);
							return;
						}
					}
					else if (this.radioStadiumPreview.Checked)
					{
						string text2 = this.m_TempFolder + "\\" + Stadium.PreviewBigFileName(num, num6);
						this.viewer2D.picture.BackgroundImageLayout = ImageLayout.Zoom;
						this.ShowBigFile(text2);
						return;
					}
				}
				else if (!(text == "Sponsor"))
				{
					if (text == "GkGloves")
					{
						string text4 = this.m_TempFolder + "\\" + GkGloves.GkGlovesTextureFileName(num);
						this.ShowRx3File(text4);
						return;
					}
					this.tabPreview.Visible = false;
				}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000243E6 File Offset: 0x000225E6
		private void ShowBigFile(string bigFileName)
		{
			this.tabPreview.SelectedIndex = 0;
			this.viewer2D.CurrentBitmap = FifaEnvironment.GetBitmapFromBigFile(bigFileName);
			this.tabPreview.Visible = this.viewer2D.CurrentBitmap != null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0002441E File Offset: 0x0002261E
		private void ShowDdsFile(string ddsFileName)
		{
			this.tabPreview.SelectedIndex = 0;
			this.viewer2D.CurrentBitmap = FifaEnvironment.GetBitmapFromDdsFile(ddsFileName);
			this.tabPreview.Visible = this.viewer2D.CurrentBitmap != null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00024456 File Offset: 0x00022656
		private void ShowRx3File(string rx3FileName)
		{
			this.tabPreview.SelectedIndex = 1;
			this.multiViewer2D.Bitmaps = FifaEnvironment.GetBitmapsFromRx3File(rx3FileName);
			this.tabPreview.Visible = this.multiViewer2D.Bitmaps != null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002448E File Offset: 0x0002268E
		private void PatchLoaderForm_Load(object sender, EventArgs e)
		{
			this.InitPatchLoaderForm();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00024496 File Offset: 0x00022696
		private void buttonImportPatch_Click(object sender, EventArgs e)
		{
			this.ImportPatch();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00024496 File Offset: 0x00022696
		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ImportPatch();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000244A0 File Offset: 0x000226A0
		private void ImportPatch()
		{
			this.RemoveAllUnusedObjects();
			PatchedObject.Initialize();
			PatchedObject.SetLanguageDataSet(this.m_LangDataSet);
			if (!PatchedObject.SetFifaDataSet(this.m_FifaDataSet))
			{
				return;
			}
			PatchedObject.s_PlayerCrossReferenceRequired = false;
			PatchedObject.s_TeamCrossReferenceRequired = false;
			PatchedObject.s_CountryCrossReferenceRequired = false;
			PatchedObject.s_ShoesCrossReferenceRequired = false;
			PatchedObject.s_AdboardCrossReferenceRequired = false;
			PatchedObject.s_BallCrossReferenceRequired = false;
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				PatchedObject patchedObject = (PatchedObject)listViewItem.Tag;
				if (listViewItem.Checked && patchedObject.ImportId != patchedObject.Id)
				{
					if (patchedObject.Type == "Player")
					{
						PatchedObject.s_PlayerCrossReferenceRequired = true;
					}
					else if (patchedObject.Type == "Team")
					{
						PatchedObject.s_TeamCrossReferenceRequired = true;
					}
					else if (patchedObject.Type == "Shoes")
					{
						PatchedObject.s_ShoesCrossReferenceRequired = true;
					}
					else if (patchedObject.Type == "Country")
					{
						PatchedObject.s_CountryCrossReferenceRequired = true;
					}
					else if (patchedObject.Type == "Ball")
					{
						PatchedObject.s_BallCrossReferenceRequired = true;
					}
					else if (patchedObject.Type == "Adboard")
					{
						PatchedObject.s_AdboardCrossReferenceRequired = true;
					}
				}
			}
			foreach (object obj2 in this.listViewPatch.Items)
			{
				ListViewItem listViewItem2 = (ListViewItem)obj2;
				PatchedObject patchedObject2 = (PatchedObject)listViewItem2.Tag;
				if (listViewItem2.Checked)
				{
					this.statusLabel.Text = "Importing " + patchedObject2.Name;
					this.statusBar.Refresh();
					patchedObject2.Import();
				}
			}
			if (this.m_FifaDataSet.DataSetName == "FIFA15" || this.m_FifaDataSet.DataSetName == "FIFA14")
			{
				foreach (object obj3 in this.listViewPatch.Items)
				{
					ListViewItem listViewItem3 = (ListViewItem)obj3;
					PatchedObject patchedObject3 = (PatchedObject)listViewItem3.Tag;
					if (listViewItem3.Checked && patchedObject3.Type == "Team")
					{
						Team team = null;
						switch (patchedObject3.UsedObject)
						{
						case PatchedObject.EUsedObject.UseCms:
							team = (Team)patchedObject3.CmsObject;
							break;
						case PatchedObject.EUsedObject.UseNew:
							team = (Team)patchedObject3.NewObject;
							break;
						case PatchedObject.EUsedObject.UseFitting:
							team = (Team)patchedObject3.ReplacedObject;
							break;
						}
						if (team != null && team.Formation != null && team.Formation.IsGeneric())
						{
							Formation formation = (Formation)FifaEnvironment.Formations.CloneId(team.Formation.Id);
							formation.Team = team;
							team.Formation = formation;
						}
					}
				}
				foreach (object obj4 in this.listViewPatch.Items)
				{
					ListViewItem listViewItem4 = (ListViewItem)obj4;
					PatchedObject patchedObject4 = (PatchedObject)listViewItem4.Tag;
					if (listViewItem4.Checked && patchedObject4.Type == "Formation")
					{
						Formation formation2 = null;
						PatchedObject.EUsedObject usedObject = patchedObject4.UsedObject;
						if (usedObject != PatchedObject.EUsedObject.UseCms)
						{
							if (usedObject == PatchedObject.EUsedObject.UseNew)
							{
								formation2 = (Formation)patchedObject4.NewObject;
							}
						}
						else
						{
							formation2 = (Formation)patchedObject4.CmsObject;
						}
						if (formation2 != null && formation2.IsGeneric())
						{
							FifaEnvironment.Formations.DeleteFormation(formation2);
						}
					}
				}
			}
			FifaEnvironment.UserMessages.ShowMessage(15005);
			base.Close();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001C96F File Offset: 0x0001AB6F
		private void buttonExitCreator_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000248A8 File Offset: 0x00022AA8
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RemoveAllNewObjects();
			base.Close();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000248B8 File Offset: 0x00022AB8
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
			listViewItem.SubItems[3] = new ListViewItem.ListViewSubItem(listViewItem, patchedObject.ImportId.ToString());
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002492C File Offset: 0x00022B2C
		private void buttonSelectNewObjects_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				listViewItem.Checked = listViewItem.ForeColor == Color.Green;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002499C File Offset: 0x00022B9C
		private void PatchLoaderForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.RemoveNewObjectsNotImported();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000249A4 File Offset: 0x00022BA4
		private void RemoveNewObjectsNotImported()
		{
			foreach (object obj in this.listViewPatch.Items)
			{
				((PatchedObject)((ListViewItem)obj).Tag).RemoveNewObjectIfNotImported();
			}
		}

		// Token: 0x0400023E RID: 574
		public string m_TempFolder;

		// Token: 0x0400023F RID: 575
		private DataSet m_FifaDataSet = new DataSet("FIFA16");

		// Token: 0x04000240 RID: 576
		private DataSet m_LangDataSet = new DataSet("LANG16");

		// Token: 0x04000241 RID: 577
		private Patch m_PatchDataSet = new Patch();

		// Token: 0x04000242 RID: 578
		private int m_PatchYear;

		// Token: 0x04000243 RID: 579
		private int m_PatchDatabaseVersion;

		// Token: 0x04000244 RID: 580
		private bool m_IsLastObjectCrossReferenced;

		// Token: 0x04000245 RID: 581
		private PatchedObject m_CurrentPatchedObject;
	}
}
