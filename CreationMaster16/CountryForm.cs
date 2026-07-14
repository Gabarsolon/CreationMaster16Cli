using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000011 RID: 17
	public partial class CountryForm : Form
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000490F0 File Offset: 0x000472F0
		public CountryForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectCountry);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateCountry);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteCountry);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshCountry);
			this.viewer2DFlag.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageFlag);
			this.viewer2DFlag.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteFlag);
			this.viewer2DFlag.ButtonStripVisible = true;
			this.viewer2DFlag.RemoveButton = true;
			this.viewer2DFlag512.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageFlag512);
			this.viewer2DFlag512.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteFlag512);
			this.viewer2DFlag512.ButtonStripVisible = true;
			this.viewer2DFlag512.RemoveButton = true;
			this.viewer2DMiniFlag.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMiniFlag);
			this.viewer2DMiniFlag.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMiniFlag);
			this.viewer2DMiniFlag.ButtonStripVisible = true;
			this.viewer2DMiniFlag.RemoveButton = true;
			this.viewer2DCardFlag.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCardFlag);
			this.viewer2DCardFlag.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteCardFlag);
			this.viewer2DCardFlag.ButtonStripVisible = true;
			this.viewer2DCardFlag.RemoveButton = true;
			this.viewer2DShape.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageShape);
			this.viewer2DShape.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteShape);
			this.viewer2DShape.ButtonStripVisible = true;
			this.viewer2DShape.RemoveButton = true;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000492E0 File Offset: 0x000474E0
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Countries;
			this.comboNationalTeam.Items.Clear();
			this.comboNationalTeam.BeginUpdate();
			this.comboNationalTeam.Items.Add(this.m_NotPresent);
			this.comboNationalTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			int num = FifaEnvironment.FifaDb.Table[TI.players].TableDescriptor.MaxValues[FI.players_nationality];
			if (num < 255)
			{
				num = 255;
			}
			this.numericCountryId.Maximum = num;
			this.comboNationalTeam.EndUpdate();
			this.pickUpControl.ObjectList = FifaEnvironment.Countries;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000493A4 File Offset: 0x000475A4
		public void ReloadCountry(Country country)
		{
			this.m_CurrentCountry = null;
			this.LoadCountry(country);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000493B4 File Offset: 0x000475B4
		public void LoadCountry(Country country)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentCountry == country)
			{
				return;
			}
			this.m_LockUserChanges = true;
			this.m_CurrentCountry = country;
			this.countryBindingSource.DataSource = this.m_CurrentCountry;
			this.viewer2DFlag.CurrentBitmap = this.m_CurrentCountry.GetFlag();
			this.viewer2DFlag512.CurrentBitmap = this.m_CurrentCountry.GetFlag512();
			this.viewer2DMiniFlag.CurrentBitmap = this.m_CurrentCountry.GetMiniFlag();
			this.viewer2DCardFlag.CurrentBitmap = this.m_CurrentCountry.GetCardFlag();
			this.viewer2DShape.CurrentBitmap = this.m_CurrentCountry.GetShape();
			this.pictureNationalTeam.BackgroundImage = ((this.m_CurrentCountry.NationalTeam != null) ? this.m_CurrentCountry.NationalTeam.GetCrest() : null);
			GC.Collect();
			this.m_LockUserChanges = false;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00049498 File Offset: 0x00047698
		private Country SelectCountry(object sender, object obj)
		{
			Country country = (Country)obj;
			this.Refresh();
			this.LoadCountry(country);
			return country;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000494BC File Offset: 0x000476BC
		private Country CreateCountry(object sender, object obj)
		{
			DialogResult dialogResult = this.m_NewIdCreator.ShowDialog();
			if (this.m_NewIdCreator.NewObject == null)
			{
				if (dialogResult == DialogResult.OK)
				{
					FifaEnvironment.UserMessages.ShowMessage(5060, this.m_NewIdCreator.NewId);
				}
				return null;
			}
			return (Country)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00049514 File Offset: 0x00047714
		private Country DeleteCountry(object sender, object obj)
		{
			Country country = (Country)obj;
			FifaEnvironment.Countries.DeleteCountry(country);
			FifaEnvironment.Language.RemoveCountryString(country.Id, Language.ECountryStringType.Full);
			return null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00049548 File Offset: 0x00047748
		private Country CloneCountry(object sender, object obj)
		{
			Country country = (Country)obj;
			return (Country)FifaEnvironment.Countries.CloneId(country);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0004956C File Offset: 0x0004776C
		public Country RefreshCountry(object sender, object obj)
		{
			this.Preset();
			this.ReloadCountry(this.m_CurrentCountry);
			return this.m_CurrentCountry;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00049586 File Offset: 0x00047786
		private bool ImportImageFlag(object sender, Bitmap bitmap)
		{
			return this.m_CurrentCountry.SetFlag(bitmap);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00049594 File Offset: 0x00047794
		private bool DeleteFlag(object sender)
		{
			return this.m_CurrentCountry.DeleteFlag();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000495A1 File Offset: 0x000477A1
		private bool ImportImageFlag512(object sender, Bitmap bitmap)
		{
			return this.m_CurrentCountry.SetFlag512(bitmap);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000495AF File Offset: 0x000477AF
		private bool DeleteFlag512(object sender)
		{
			return this.m_CurrentCountry.DeleteFlag512();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000495BC File Offset: 0x000477BC
		private bool ImportImageMiniFlag(object sender, Bitmap bitmap)
		{
			return this.m_CurrentCountry.SetMiniFlag(bitmap);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000495CA File Offset: 0x000477CA
		private bool DeleteMiniFlag(object sender)
		{
			return this.m_CurrentCountry.DeleteMiniFlag();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000495D7 File Offset: 0x000477D7
		private bool ImportImageCardFlag(object sender, Bitmap bitmap)
		{
			return this.m_CurrentCountry.SetCardFlag(bitmap);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000495E5 File Offset: 0x000477E5
		private bool DeleteCardFlag(object sender)
		{
			return this.m_CurrentCountry.DeleteCardFlag();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000495F2 File Offset: 0x000477F2
		private bool ImportImageShape(object sender, Bitmap bitmap)
		{
			return this.m_CurrentCountry.SetShape(bitmap);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00049600 File Offset: 0x00047800
		private bool DeleteShape(object sender)
		{
			return this.m_CurrentCountry.DeleteShape();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0004960D File Offset: 0x0004780D
		private void textLanguageName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			this.m_CurrentCountry.LanguageName = this.textLanguageName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentCountry);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00049640 File Offset: 0x00047840
		private void numericCountryId_ValueChanged(object sender, EventArgs e)
		{
			int num = (int)this.numericCountryId.Value;
			if (num == this.m_CurrentCountry.Id)
			{
				return;
			}
			if (FifaEnvironment.Countries.SearchId(num) == null)
			{
				FifaEnvironment.Countries.ChangeId(this.m_CurrentCountry, num);
				this.ReloadCountry(this.m_CurrentCountry);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericCountryId.Value = this.m_CurrentCountry.Id;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000496C4 File Offset: 0x000478C4
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Countries.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericCountryId.Value = newId;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00049704 File Offset: 0x00047904
		private void numericNationalTeam_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_IsNationalTeamLocked)
			{
				return;
			}
			this.m_IsNationalTeamLocked = true;
			int num = (int)this.numericNationalTeam.Value;
			Team team = (Team)FifaEnvironment.Teams.SearchId(num);
			if (team != null)
			{
				this.comboNationalTeam.SelectedItem = team;
			}
			else
			{
				this.comboNationalTeam.SelectedItem = this.m_NotPresent;
			}
			if (num == this.m_CurrentCountry.NationalTeamId)
			{
				this.m_IsNationalTeamLocked = false;
				return;
			}
			if (num > 0 && FifaEnvironment.Countries.SearchNationalTeamId(num) != null)
			{
				this.numericNationalTeam.Value = this.m_CurrentCountry.NationalTeamId;
				FifaEnvironment.UserMessages.ShowMessage(1014);
				this.m_IsNationalTeamLocked = false;
				return;
			}
			this.m_CurrentCountry.SetNationalTeam(team, num);
			this.pictureNationalTeam.BackgroundImage = ((team != null) ? team.GetCrest() : null);
			this.m_IsNationalTeamLocked = false;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000497EC File Offset: 0x000479EC
		private void comboNationalTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_IsNationalTeamLocked)
			{
				return;
			}
			this.m_IsNationalTeamLocked = true;
			int num;
			Team team;
			if (this.comboNationalTeam.SelectedItem.ToString() == this.m_NotPresent)
			{
				num = -1;
				team = null;
			}
			else
			{
				team = (Team)this.comboNationalTeam.SelectedItem;
				num = team.Id;
			}
			if (team == this.m_CurrentCountry.NationalTeam)
			{
				this.m_IsNationalTeamLocked = false;
				return;
			}
			if (num > 0 && FifaEnvironment.Countries.SearchNationalTeamId(num) != null)
			{
				this.comboNationalTeam.SelectedItem = this.m_CurrentCountry.NationalTeam;
				FifaEnvironment.UserMessages.ShowMessage(1014);
				this.m_IsNationalTeamLocked = false;
				return;
			}
			this.numericNationalTeam.Value = num;
			this.m_CurrentCountry.SetNationalTeam(team, num);
			this.pictureNationalTeam.BackgroundImage = ((team != null) ? team.GetCrest() : null);
			this.m_IsNationalTeamLocked = false;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000498D5 File Offset: 0x00047AD5
		private void pictureNationalTeam_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentCountry.NationalTeam != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentCountry.NationalTeam);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000498F9 File Offset: 0x00047AF9
		private void CountryForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void numericTeamPrestige_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonRandomize1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonRandomize2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonRandomiz23_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonRandomize4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonSpain_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonFrance_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonItaly_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonGermany_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonScotland_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonAustria_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonBrazil_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonCzech_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonKorea_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00049908 File Offset: 0x00047B08
		private void LoadAudio()
		{
			this.comboChants.SelectedIndex = this.m_CurrentCountry.ChantRegionIndex - 1;
			this.comboLanguage.SelectedIndex = this.m_CurrentCountry.PALanguageIndex;
			this.comboPlayerCall.SelectedIndex = this.m_CurrentCountry.PlayerCallPatchBankIndex;
			int crowdBedsRegionIndex = this.m_CurrentCountry.CrowdBedsRegionIndex;
			if (crowdBedsRegionIndex != 0)
			{
				if (crowdBedsRegionIndex != 8)
				{
					if (crowdBedsRegionIndex == 15)
					{
						this.comboCrowdType.SelectedIndex = 2;
					}
				}
				else
				{
					this.comboCrowdType.SelectedIndex = 1;
				}
			}
			else
			{
				this.comboCrowdType.SelectedIndex = 0;
			}
			this.checkCanWhistle.Checked = this.m_CurrentCountry.TeamCanWhistleIndex == 1;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000499B4 File Offset: 0x00047BB4
		private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_CurrentCountry.PALanguageIndex = this.comboLanguage.SelectedIndex;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000499CC File Offset: 0x00047BCC
		private void comboChants_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_CurrentCountry.ChantRegionIndex = this.comboChants.SelectedIndex + 1;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000499E8 File Offset: 0x00047BE8
		private void comboCrowdType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.comboCrowdType.SelectedIndex)
			{
			case 0:
				this.m_CurrentCountry.CrowdBedsRegionIndex = 0;
				return;
			case 1:
				this.m_CurrentCountry.CrowdBedsRegionIndex = 8;
				return;
			case 2:
				this.m_CurrentCountry.CrowdBedsRegionIndex = 15;
				return;
			default:
				return;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00049A3B File Offset: 0x00047C3B
		private void comboPlayerCall_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_CurrentCountry.PlayerCallPatchBankIndex = this.comboPlayerCall.SelectedIndex;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void comboPepper_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void checkTauntKeeper_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00049A53 File Offset: 0x00047C53
		private void checkCanWhistle_CheckedChanged(object sender, EventArgs e)
		{
			this.m_CurrentCountry.TeamCanWhistleIndex = (this.checkCanWhistle.Checked ? 1 : 0);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00049A71 File Offset: 0x00047C71
		private void textLanguageShortName_TextChanged(object sender, EventArgs e)
		{
			if (this.textLanguageShortName.Text.Length > 15)
			{
				this.textLanguageShortName.Text = this.textLanguageShortName.Text.Substring(0, 15);
			}
		}

		// Token: 0x04000475 RID: 1141
		private Country m_CurrentCountry;

		// Token: 0x04000476 RID: 1142
		private string m_NotPresent = "< Not Present >";

		// Token: 0x04000477 RID: 1143
		private bool m_IsNationalTeamLocked;

		// Token: 0x04000478 RID: 1144
		private bool m_IsLoaded;

		// Token: 0x04000479 RID: 1145
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x0400047A RID: 1146
		private static Random m_Randomizer = new Random();

		// Token: 0x0400047B RID: 1147
		private bool m_LockUserChanges;
	}
}
