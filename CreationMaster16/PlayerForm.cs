using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;
using Microsoft.DirectX.Direct3D;

namespace CreationMaster
{
	// Token: 0x02000010 RID: 16
	public partial class PlayerForm : Form
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0002FD64 File Offset: 0x0002DF64
		public PlayerForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.comboLatinModels.Items.Clear();
			for (int i = 0; i < GenericHead.c_LatinModels.Length; i++)
			{
				this.comboLatinModels.Items.Add(GenericHead.c_LatinModels[i].ToString());
			}
			this.comboCaucasicModels.Items.Clear();
			for (int j = 0; j < GenericHead.c_CaucasicModels.Length; j++)
			{
				this.comboCaucasicModels.Items.Add(GenericHead.c_CaucasicModels[j].ToString());
			}
			this.comboAfricanModels.Items.Clear();
			for (int k = 0; k < GenericHead.c_AfricanModels.Length; k++)
			{
				this.comboAfricanModels.Items.Add(GenericHead.c_AfricanModels[k].ToString());
			}
			this.comboAsiaticModels.Items.Clear();
			for (int l = 0; l < GenericHead.c_AsiaticModels.Length; l++)
			{
				this.comboAsiaticModels.Items.Add(GenericHead.c_AsiaticModels[l].ToString());
			}
			this.comboFemaleModels.Items.Clear();
			for (int m = 0; m < GenericHead.c_FemaleModels.Length; m++)
			{
				this.comboFemaleModels.Items.Add(GenericHead.c_FemaleModels[m].ToString());
			}
			this.comboShaven.Items.Clear();
			for (int n = 0; n < GenericHead.c_ShavenModels.Length; n++)
			{
				this.comboShaven.Items.Add(GenericHead.c_ShavenModels[n].ToString());
			}
			this.comboVeryShort.Items.Clear();
			for (int num = 0; num < GenericHead.c_VeryShortModels.Length; num++)
			{
				this.comboVeryShort.Items.Add(GenericHead.c_VeryShortModels[num].ToString());
			}
			this.comboShort.Items.Clear();
			for (int num2 = 0; num2 < GenericHead.c_ShortModels.Length; num2++)
			{
				this.comboShort.Items.Add(GenericHead.c_ShortModels[num2].ToString());
			}
			this.comboModern.Items.Clear();
			for (int num3 = 0; num3 < GenericHead.c_ModernModels.Length; num3++)
			{
				this.comboModern.Items.Add(GenericHead.c_ModernModels[num3].ToString());
			}
			this.comboMedium.Items.Clear();
			for (int num4 = 0; num4 < GenericHead.c_MediumModels.Length; num4++)
			{
				this.comboMedium.Items.Add(GenericHead.c_MediumModels[num4].ToString());
			}
			this.comboLong.Items.Clear();
			for (int num5 = 0; num5 < GenericHead.c_LongModels.Length; num5++)
			{
				this.comboLong.Items.Add(GenericHead.c_LongModels[num5].ToString());
			}
			this.comboAfro.Items.Clear();
			for (int num6 = 0; num6 < GenericHead.c_AfroModels.Length; num6++)
			{
				this.comboAfro.Items.Add(GenericHead.c_AfroModels[num6].ToString());
			}
			this.comboHeadband.Items.Clear();
			for (int num7 = 0; num7 < GenericHead.c_HeadbendModels.Length; num7++)
			{
				this.comboHeadband.Items.Add(GenericHead.c_HeadbendModels[num7].ToString());
			}
			this.comboFemaleHair.Items.Clear();
			for (int num8 = 0; num8 < GenericHead.c_FemaleHairModels.Length; num8++)
			{
				this.comboFemaleHair.Items.Add(GenericHead.c_FemaleHairModels[num8].ToString());
			}
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectPlayer);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreatePlayer);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeletePlayer);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.ClonePlayer);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshPlayer);
			this.pickUpControl.combo.Sorted = false;
			this.viewer2DPhoto.ButtonStripVisible = true;
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DShoes.ButtonStripVisible = false;
			this.viewer2DEyeTexture.ButtonStripVisible = true;
			this.viewer2DEyeTexture.ShowButton = true;
			this.viewer2DEyeTexture.ShowButtonChecked = true;
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DShoes.ButtonStripVisible = false;
			this.viewer2DEyeTexture.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageEye);
			this.viewer2DEyeTexture.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageEye);
			this.viewer2DEyeTexture.ButtonStripVisible = true;
			this.viewer2DEyeTexture.RemoveButton = true;
			this.viewer2DSkinTexture.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageSkin);
			this.viewer2DSkinTexture.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageSkin);
			this.viewer2DSkinTexture.ButtonStripVisible = true;
			this.viewer2DSkinTexture.RemoveButton = true;
			this.viewer2DSkinTexture.ShowButton = true;
			this.viewer2DSkinTexture.ShowButtonChecked = true;
			this.viewer2DSkinTexture.FullSizeButton = true;
			this.multiViewerHair.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3HairTextures);
			this.multiViewerHair.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3HairTextures);
			this.multiViewerHair.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3HairTextures);
			this.multiViewerHair.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3HairTextures);
			this.multiViewerHair.ShowDeleteButton = true;
			this.multiViewerHair.FullSizeButton = true;
			this.multiViewerFace.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3FaceTextures);
			this.multiViewerFace.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3FaceTextures);
			this.multiViewerFace.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3FaceTextures);
			this.multiViewerFace.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3FaceTextures);
			this.multiViewerFace.ShowDeleteButton = true;
			this.multiViewerFace.FullSizeButton = true;
			this.viewer2DPlayerGui.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMiniface);
			this.viewer2DPlayerGui.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMiniface);
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DPlayerGui.RemoveButton = true;
			this.viewer2DPhoto.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMiniface);
			this.viewer2DPhoto.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMiniface);
			this.viewer2DPhoto.ButtonStripVisible = true;
			this.viewer2DPhoto.RemoveButton = true;
			this.viewer2DPhoto.ShowButton = true;
			this.viewer2DPhoto.ShowButtonChecked = true;
			this.viewer2DPlayerGui.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageTattoo);
			this.viewer2DPlayerGui.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteTattoo);
			this.viewer2DTattoos.ButtonStripVisible = true;
			this.viewer2DTattoos.RemoveButton = true;
			this.viewer2DTattoos.FullSizeButton = true;
			this.viewer2DTattoos.ShowButton = true;
			this.viewer2DTattoos.ShowButtonChecked = true;
			this.tool3D.Visible = true;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00030534 File Offset: 0x0002E734
		private Player CreatePlayer(object sender, object obj)
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
			return (Player)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0003058C File Offset: 0x0002E78C
		private Player DeletePlayer(object sender, object obj)
		{
			Player player = (Player)obj;
			while (player.m_PlayingForTeams.Count > 0)
			{
				((Team)player.m_PlayingForTeams[0]).RemoveTeamPlayer(player);
			}
			FifaEnvironment.Players.DeletePlayer(player);
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000305D4 File Offset: 0x0002E7D4
		private Player ClonePlayer(object sender, object obj)
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
			Player player = (Player)obj;
			Player player2 = (Player)FifaEnvironment.Players.CloneId(player, this.m_NewIdCreator.NewObject);
			player2.RandomizeAppearanceSameRace();
			return player2;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00030643 File Offset: 0x0002E843
		public Player RefreshPlayer(object sender, object obj)
		{
			this.m_CurrentPlayer.CleanAllHead();
			this.Preset();
			this.ReloadPlayer(this.m_CurrentPlayer);
			return this.m_CurrentPlayer;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00030668 File Offset: 0x0002E868
		private bool ImportImageEye(object sender, Bitmap bitmap)
		{
			bool flag = this.m_CurrentPlayer.SetEyesTextures(bitmap);
			if (flag)
			{
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0003067F File Offset: 0x0002E87F
		private bool DeleteImageEye(object sender)
		{
			return this.m_CurrentPlayer.DeleteEyesTexture();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0003068C File Offset: 0x0002E88C
		private bool ImportImageSkin(object sender, Bitmap bitmap)
		{
			bool flag = this.m_CurrentPlayer.SetSkinTextures(bitmap);
			if (flag)
			{
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000306A3 File Offset: 0x0002E8A3
		private bool DeleteImageSkin(object sender)
		{
			return this.m_CurrentPlayer.DeleteSkinTexture();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000306B0 File Offset: 0x0002E8B0
		private bool ExportRx3HairTextures(object sender, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(this.m_CurrentPlayer.HairTexturesFileName(), exportDir);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000306C4 File Offset: 0x0002E8C4
		private bool SaveRx3HairTextures(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentPlayer.SetHairTextures(bitmaps);
			if (flag)
			{
				this.m_CurrentPlayer.CleanHairTextures();
				this.multiViewerHair.Bitmaps = this.m_CurrentPlayer.GetHairTextures();
				this.multiViewerHair.Enabled = true;
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00030713 File Offset: 0x0002E913
		private bool ImportRx3HairTextures(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentPlayer.SetHairTextures(rx3FileName);
			if (flag)
			{
				this.m_CurrentPlayer.CleanHairTextures();
				this.multiViewerHair.Bitmaps = this.m_CurrentPlayer.GetHairTextures();
				this.multiViewerHair.Enabled = true;
			}
			return flag;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00030751 File Offset: 0x0002E951
		private bool DeleteRx3HairTextures(object sender)
		{
			return this.m_CurrentPlayer.DeleteHairTextures();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00030760 File Offset: 0x0002E960
		private bool ExportRx3FaceTextures(object sender, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(this.m_CurrentPlayer.FaceTextureFileName(), exportDir);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00030773 File Offset: 0x0002E973
		private bool SaveRx3FaceTextures(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentPlayer.SetFaceTextures(bitmaps);
			if (flag)
			{
				this.m_CurrentPlayer.CleanFaceTextures();
				this.GetAndShowFaceTexture();
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0003079B File Offset: 0x0002E99B
		private bool ImportRx3FaceTextures(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentPlayer.SetFaceTextures(rx3FileName);
			if (flag)
			{
				this.m_CurrentPlayer.CleanFaceTextures();
				this.GetAndShowFaceTexture();
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000307C3 File Offset: 0x0002E9C3
		private bool DeleteRx3FaceTextures(object sender)
		{
			bool flag = this.m_CurrentPlayer.DeleteFaceTexture();
			if (flag)
			{
				this.GetAndShowFaceTexture();
				this.UpdateAndShowHead3D();
			}
			return flag;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000307DF File Offset: 0x0002E9DF
		private bool ImportImageMiniface(object sender, Bitmap bitmap)
		{
			return this.m_CurrentPlayer.SetPhoto(bitmap);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000307ED File Offset: 0x0002E9ED
		private bool DeleteMiniface(object sender)
		{
			return this.m_CurrentPlayer.DeletePhoto();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000307FA File Offset: 0x0002E9FA
		private bool ImportImageTattoo(object sender, Bitmap bitmap)
		{
			return this.m_CurrentPlayer.SetTattoos(bitmap);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00030808 File Offset: 0x0002EA08
		private bool DeleteTattoo(object sender)
		{
			return this.m_CurrentPlayer.DeleteTattoos();
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00030818 File Offset: 0x0002EA18
		private Player SelectPlayer(object sender, object obj)
		{
			Player player = (Player)obj;
			this.LoadPlayer(player);
			return player;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00030834 File Offset: 0x0002EA34
		public void ReloadPlayer(Player player)
		{
			this.m_CurrentPlayer = null;
			this.LoadPlayer(player);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00030844 File Offset: 0x0002EA44
		public void LoadPlayer(Player player)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentPlayer == player && this.m_CurrentPage == this.tabEditPlayer.SelectedTab)
			{
				return;
			}
			this.m_Locked = true;
			this.m_CurrentPlayer = player;
			this.buttonSaveHair.Enabled = false;
			this.playerBindingSource.DataSource = this.m_CurrentPlayer;
			this.playerBindingSource.ResetBindings(false);
			this.m_CurrentPage = this.tabEditPlayer.SelectedTab;
			if (this.m_CurrentPage == this.pageInfo)
			{
				this.LoadPlayerInfo();
			}
			else if (this.m_CurrentPage == this.pageSkills)
			{
				this.LoadPlayerSkills();
			}
			else if (this.m_CurrentPage == this.pageFace)
			{
				this.LoadPlayerFace();
			}
			this.m_Locked = false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00030908 File Offset: 0x0002EB08
		private void LoadPlayerInfo()
		{
			this.numericPlayerId.Value = this.m_CurrentPlayer.Id;
			if (this.viewer2DPhoto.ShowButton)
			{
				this.viewer2DPhoto.CurrentBitmap = this.m_CurrentPlayer.GetPhoto();
			}
			else
			{
				this.viewer2DPhoto.CurrentBitmap = null;
			}
			this.InitListViewPlayingTeams(this.m_CurrentPlayer.m_PlayingForTeams);
			this.pictureColorAcc1.BackColor = PlayerForm.c_AccPalette[this.m_CurrentPlayer.accessorycolourcode1];
			this.pictureColorAcc2.BackColor = PlayerForm.c_AccPalette[this.m_CurrentPlayer.accessorycolourcode2];
			this.pictureColorAcc3.BackColor = PlayerForm.c_AccPalette[this.m_CurrentPlayer.accessorycolourcode3];
			this.pictureColorAcc4.BackColor = PlayerForm.c_AccPalette[this.m_CurrentPlayer.accessorycolourcode4];
			this.comboPreferredPosition1.SelectedIndex = this.m_CurrentPlayer.preferredposition1 + 1;
			this.comboPreferredPosition2.SelectedIndex = this.m_CurrentPlayer.preferredposition2 + 1;
			this.comboPreferredPosition3.SelectedIndex = this.m_CurrentPlayer.preferredposition3 + 1;
			this.comboPreferredPosition4.SelectedIndex = this.m_CurrentPlayer.preferredposition4 + 1;
			this.numericShoesBrand.Value = this.m_CurrentPlayer.shoetypecode;
			this.numericShoesDesign.Value = this.m_CurrentPlayer.shoedesigncode;
			this.pictureColorShoes1.BackColor = Shoes.GetGenericColor(this.m_CurrentPlayer.shoecolorcode1);
			this.pictureColorShoes2.BackColor = Shoes.GetGenericColor(this.m_CurrentPlayer.shoecolorcode2);
			if (this.m_CurrentPlayer.shoetypecode == 0)
			{
				this.numericShoesDesign.Enabled = true;
				this.pictureColorShoes1.Enabled = true;
				this.pictureColorShoes2.Enabled = true;
			}
			else
			{
				this.numericShoesDesign.Enabled = false;
				this.pictureColorShoes1.Enabled = false;
				this.pictureColorShoes2.Enabled = false;
				this.numericShoesDesign.Value = 0m;
			}
			this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(this.m_CurrentPlayer.shoetypecode, this.m_CurrentPlayer.shoedesigncode);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00030B4C File Offset: 0x0002ED4C
		private void LoadPlayerSkills()
		{
			this.m_OverallSema = false;
			this.numericRandomize.Value = this.m_CurrentPlayer.GetAverageRoleAttribute();
			this.m_OverallSema = true;
			this.labelSkillsStars.ImageIndex = this.m_CurrentPlayer.skillmoves - 1;
			this.playerBindingSource.ResetBindings(false);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00030BA8 File Offset: 0x0002EDA8
		public void Preset()
		{
			Kit.Prepare3DModels();
			this.m_NewIdCreator.IdList = FifaEnvironment.Players;
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Teams,
				FifaEnvironment.Countries,
				FifaEnvironment.FreeAgents,
				new MultiClubList(),
				new SameNameList(),
				new SpecificHeadList()
			};
			this.pickUpControl.FilterValues = array;
			this.numericShoesBrand.Maximum = FifaEnvironment.FifaDb.Table[TI.players].TableDescriptor.MaxValues[FI.players_shoetypecode];
			this.numericPlayerId.Maximum = FifaEnvironment.FifaDb.Table[TI.teams].TableDescriptor.MaxValues[FI.teams_captainid];
			this.numericSkinTone.Maximum = FifaEnvironment.FifaDb.Table[TI.players].TableDescriptor.MaxValues[FI.players_skintonecode];
			int year = FifaEnvironment.Year;
			this.countryListBindingSource.DataSource = FifaEnvironment.Countries;
			this.teamListBindingSource.DataSource = FifaEnvironment.Teams;
			this.pickUpControl.ObjectList = FifaEnvironment.Players;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00030CDC File Offset: 0x0002EEDC
		private void InitListViewPlayingTeams(TeamList playingTeams)
		{
			this.listViewPlayingTeams.BeginUpdate();
			this.listViewPlayingTeams.Items.Clear();
			this.imageListTeamLogos.Images.Clear();
			for (int i = 0; i < playingTeams.Count; i++)
			{
				Team team = (Team)playingTeams[i];
				Bitmap crest = team.GetCrest32();
				if (crest != null)
				{
					this.imageListTeamLogos.Images.Add(team.ToString(), crest);
				}
				ListViewItem listViewItem = new ListViewItem(team.ToString());
				listViewItem.Tag = team;
				this.listViewPlayingTeams.Items.Add(listViewItem);
				this.listViewPlayingTeams.Items[i].ImageKey = team.ToString();
			}
			if (this.listViewPlayingTeams.Items.Count > 0)
			{
				this.listViewPlayingTeams.Items[0].Selected = true;
			}
			this.listViewPlayingTeams.EndUpdate();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00030DCB File Offset: 0x0002EFCB
		private void PlayerForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00030DDC File Offset: 0x0002EFDC
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Players.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericPlayerId.Value = newId;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00030E1A File Offset: 0x0002F01A
		private void buttonRandomizeIdentity_Click(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.RandomizeIdentity();
			this.LoadPlayer(this.m_CurrentPlayer);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00030E33 File Offset: 0x0002F033
		private void labelCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentPlayer.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentPlayer.Country);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00030E58 File Offset: 0x0002F058
		private void labelShoes_DoubleClick(object sender, EventArgs e)
		{
			Shoes shoes = (Shoes)FifaEnvironment.Shoes.SearchId(this.m_CurrentPlayer.shoetypecode);
			if (shoes != null)
			{
				MainForm.CM.JumpTo(shoes);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00030E90 File Offset: 0x0002F090
		private void numericPlayerId_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPlayerId.Value;
			if (num == this.m_CurrentPlayer.Id)
			{
				return;
			}
			if (FifaEnvironment.Players.SearchId(num) == null)
			{
				FifaEnvironment.Players.ChangeId(this.m_CurrentPlayer, num);
				this.m_CurrentPlayer.ChangeId();
				this.m_CurrentPlayer.m_assetid = num;
				this.m_CurrentPlayer.CleanFaceTextures();
				this.m_CurrentPlayer.CleanHairTextures();
				this.LoadPlayerFace();
				this.viewer2DPhoto.CurrentBitmap = this.m_CurrentPlayer.GetPhoto();
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericPlayerId.Value = this.m_CurrentPlayer.Id;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00030F5C File Offset: 0x0002F15C
		private void numericShoesBrand_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericShoesBrand.Value;
			if (num == 0)
			{
				this.m_CurrentPlayer.shoetypecode = num;
				this.m_CurrentPlayer.shoecolorcode1 = 0;
				this.m_CurrentPlayer.shoecolorcode2 = 15;
				this.pictureColorShoes1.BackColor = Shoes.ShoesColorPalette[this.m_CurrentPlayer.shoecolorcode1];
				this.pictureColorShoes2.BackColor = Shoes.ShoesColorPalette[this.m_CurrentPlayer.shoecolorcode2];
				this.numericShoesDesign.Enabled = true;
				this.pictureColorShoes1.Enabled = true;
				this.pictureColorShoes2.Enabled = true;
			}
			else
			{
				this.m_CurrentPlayer.shoetypecode = num;
				this.numericShoesDesign.Enabled = false;
				this.pictureColorShoes1.Enabled = false;
				this.pictureColorShoes2.Enabled = false;
				this.pictureColorShoes1.BackColor = Color.Transparent;
				this.pictureColorShoes2.BackColor = Color.Transparent;
				this.m_CurrentPlayer.shoedesigncode = 0;
				this.m_CurrentPlayer.shoecolorcode1 = 30;
				this.m_CurrentPlayer.shoecolorcode2 = 31;
				this.numericShoesDesign.Value = 0m;
			}
			this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(num, 0);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000310B0 File Offset: 0x0002F2B0
		private void numericShoesDesign_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericShoesDesign.Value;
			this.m_CurrentPlayer.shoedesigncode = num;
			if (this.m_CurrentPlayer.shoetypecode == 0)
			{
				this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(0, num);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00031104 File Offset: 0x0002F304
		private void pictureColorAcc1_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(PlayerForm.c_AccPalette, this.m_CurrentPlayer.accessorycolourcode1);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.accessorycolourcode1 = colorSelector.SelectedIndex;
				this.pictureColorAcc1.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00031158 File Offset: 0x0002F358
		private void pictureColorAcc2_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(PlayerForm.c_AccPalette, this.m_CurrentPlayer.accessorycolourcode2);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.accessorycolourcode2 = colorSelector.SelectedIndex;
				this.pictureColorAcc2.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000311AC File Offset: 0x0002F3AC
		private void pictureColorAcc3_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(PlayerForm.c_AccPalette, this.m_CurrentPlayer.accessorycolourcode3);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.accessorycolourcode3 = colorSelector.SelectedIndex;
				this.pictureColorAcc3.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00031200 File Offset: 0x0002F400
		private void pictureColorAcc4_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(PlayerForm.c_AccPalette, this.m_CurrentPlayer.accessorycolourcode4);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.accessorycolourcode4 = colorSelector.SelectedIndex;
				this.pictureColorAcc4.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00031254 File Offset: 0x0002F454
		private void trackReflexes_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.gkreflexes = this.trackReflexes.Value;
			this.labelReflexes.Text = this.labelReflexes.Text.Substring(0, this.labelReflexes.Text.IndexOf(' '));
			Label label = this.labelReflexes;
			label.Text = label.Text + " " + this.m_CurrentPlayer.gkreflexes.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericGoalkeeperSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00031308 File Offset: 0x0002F508
		private void trackHandling_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.gkhandling = this.trackHandling.Value;
			this.labelHandling.Text = this.labelHandling.Text.Substring(0, this.labelHandling.Text.IndexOf(' '));
			Label label = this.labelHandling;
			label.Text = label.Text + " " + this.m_CurrentPlayer.gkhandling.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericGoalkeeperSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000313BC File Offset: 0x0002F5BC
		private void trackDiving_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.gkdiving = this.trackDiving.Value;
			this.labelDiving.Text = this.labelDiving.Text.Substring(0, this.labelDiving.Text.IndexOf(' '));
			Label label = this.labelDiving;
			label.Text = label.Text + " " + this.m_CurrentPlayer.gkdiving.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericGoalkeeperSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00031470 File Offset: 0x0002F670
		private void trackPositioning_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.gkpositioning = this.trackPositioning.Value;
			this.labelPositioning.Text = this.labelPositioning.Text.Substring(0, this.labelPositioning.Text.IndexOf(' '));
			Label label = this.labelPositioning;
			label.Text = label.Text + " " + this.m_CurrentPlayer.gkpositioning.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericGoalkeeperSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00031524 File Offset: 0x0002F724
		private void trackGkKick_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.gkkicking = this.trackGkKicking.Value;
			this.labelGkKick.Text = this.labelGkKick.Text.Substring(0, this.labelGkKick.Text.IndexOf(' '));
			Label label = this.labelGkKick;
			label.Text = label.Text + " " + this.m_CurrentPlayer.gkkicking.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericGoalkeeperSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000315D8 File Offset: 0x0002F7D8
		private void trackMarking_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.marking = this.trackMarking.Value;
			this.labelMarking.Text = this.labelMarking.Text.Substring(0, this.labelMarking.Text.IndexOf(' '));
			Label label = this.labelMarking;
			label.Text = label.Text + " " + this.m_CurrentPlayer.marking.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericDefensiveSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0003168C File Offset: 0x0002F88C
		private void trackTackling_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.standingtackle = this.trackTackling.Value;
			this.labelTackling.Text = this.labelTackling.Text.Substring(0, this.labelTackling.Text.IndexOf(' '));
			Label label = this.labelTackling;
			label.Text = label.Text + " " + this.m_CurrentPlayer.standingtackle.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericDefensiveSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00031740 File Offset: 0x0002F940
		private void trackSliding_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.slidingtackle = this.trackSliding.Value;
			this.labelSliding.Text = this.labelSliding.Text.Substring(0, this.labelSliding.Text.IndexOf(' '));
			Label label = this.labelSliding;
			label.Text = label.Text + " " + this.m_CurrentPlayer.slidingtackle.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericDefensiveSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000317F4 File Offset: 0x0002F9F4
		private void trackAggression_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.aggression = this.trackAggression.Value;
			this.labelAggression.Text = this.labelAggression.Text.Substring(0, this.labelAggression.Text.IndexOf(' '));
			Label label = this.labelAggression;
			label.Text = label.Text + " " + this.m_CurrentPlayer.aggression.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericDefensiveSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000318A8 File Offset: 0x0002FAA8
		private void trackShortPassing_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.shortpassing = this.trackShortPassing.Value;
			this.labelShortPassing.Text = this.labelShortPassing.Text.Substring(0, this.labelShortPassing.Text.IndexOf(' '));
			Label label = this.labelShortPassing;
			label.Text = label.Text + " " + this.m_CurrentPlayer.shortpassing.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0003195C File Offset: 0x0002FB5C
		private void trackLongPassing_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.longpassing = this.trackLongPassing.Value;
			this.labelLongPassing.Text = this.labelLongPassing.Text.Substring(0, this.labelLongPassing.Text.IndexOf(' '));
			Label label = this.labelLongPassing;
			label.Text = label.Text + " " + this.m_CurrentPlayer.longpassing.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00031A10 File Offset: 0x0002FC10
		private void trackCrossing_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.crossing = this.trackCrossing.Value;
			this.labelCrossing.Text = this.labelCrossing.Text.Substring(0, this.labelCrossing.Text.IndexOf(' '));
			Label label = this.labelCrossing;
			label.Text = label.Text + " " + this.m_CurrentPlayer.crossing.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00031AC4 File Offset: 0x0002FCC4
		private void trackBallControl_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.ballcontrol = this.trackBallControl.Value;
			this.labelBallControl.Text = this.labelBallControl.Text.Substring(0, this.labelBallControl.Text.IndexOf(' '));
			Label label = this.labelBallControl;
			label.Text = label.Text + " " + this.m_CurrentPlayer.ballcontrol.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00031B78 File Offset: 0x0002FD78
		private void trackVision_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.vision = this.trackVision.Value;
			this.labelVision.Text = this.labelVision.Text.Substring(0, this.labelVision.Text.IndexOf(' '));
			Label label = this.labelVision;
			label.Text = label.Text + " " + this.m_CurrentPlayer.vision.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00031C2C File Offset: 0x0002FE2C
		private void trackCurve_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.curve = this.trackCurve.Value;
			this.labelCurve.Text = this.labelCurve.Text.Substring(0, this.labelCurve.Text.IndexOf(' '));
			Label label = this.labelCurve;
			label.Text = label.Text + " " + this.m_CurrentPlayer.curve.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMidfielderSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00031CE0 File Offset: 0x0002FEE0
		private void trackHeading_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.headingaccuracy = this.trackHeading.Value;
			this.labelHeading.Text = this.labelHeading.Text.Substring(0, this.labelHeading.Text.IndexOf(' '));
			Label label = this.labelHeading;
			label.Text = label.Text + " " + this.m_CurrentPlayer.headingaccuracy.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00031D94 File Offset: 0x0002FF94
		private void trackFinishing_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.finishing = this.trackFinishing.Value;
			this.labelFinishing.Text = this.labelFinishing.Text.Substring(0, this.labelFinishing.Text.IndexOf(' '));
			Label label = this.labelFinishing;
			label.Text = label.Text + " " + this.m_CurrentPlayer.finishing.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00031E48 File Offset: 0x00030048
		private void trackShotPower_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.shotpower = this.trackShotPower.Value;
			this.labelShotPower.Text = this.labelShotPower.Text.Substring(0, this.labelShotPower.Text.IndexOf(' '));
			Label label = this.labelShotPower;
			label.Text = label.Text + " " + this.m_CurrentPlayer.shotpower.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00031EFC File Offset: 0x000300FC
		private void trackLongShot_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.longshots = this.trackLongShot.Value;
			this.labelLongShot.Text = this.labelLongShot.Text.Substring(0, this.labelLongShot.Text.IndexOf(' '));
			Label label = this.labelLongShot;
			label.Text = label.Text + " " + this.m_CurrentPlayer.longshots.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00031FB0 File Offset: 0x000301B0
		private void trackFreeKick_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.freekickaccuracy = this.trackFreeKick.Value;
			this.labelFreeKick.Text = this.labelFreeKick.Text.Substring(0, this.labelFreeKick.Text.IndexOf(' '));
			Label label = this.labelFreeKick;
			label.Text = label.Text + " " + this.m_CurrentPlayer.freekickaccuracy.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericFreeKickSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(6);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00032064 File Offset: 0x00030264
		private void trackDribbling_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.dribbling = this.trackDribbling.Value;
			this.labelDribbling.Text = this.labelDribbling.Text.Substring(0, this.labelDribbling.Text.IndexOf(' '));
			Label label = this.labelDribbling;
			label.Text = label.Text + " " + this.m_CurrentPlayer.dribbling.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00032118 File Offset: 0x00030318
		private void trackPenalties_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.penalties = this.trackPenalties.Value;
			this.labelPenalties.Text = this.labelPenalties.Text.Substring(0, this.labelPenalties.Text.IndexOf(' '));
			Label label = this.labelPenalties;
			label.Text = label.Text + " " + this.m_CurrentPlayer.penalties.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericFreeKickSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(6);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000321CC File Offset: 0x000303CC
		private void trackVolley_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.volleys = this.trackVolley.Value;
			this.labelVolley.Text = this.labelVolley.Text.Substring(0, this.labelVolley.Text.IndexOf(' '));
			Label label = this.labelVolley;
			label.Text = label.Text + " " + this.m_CurrentPlayer.volleys.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericAttackingSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00032280 File Offset: 0x00030480
		private void trackAcceleration_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.acceleration = this.trackAcceleration.Value;
			this.labelAcceleration.Text = this.labelAcceleration.Text.Substring(0, this.labelAcceleration.Text.IndexOf(' '));
			Label label = this.labelAcceleration;
			label.Text = label.Text + " " + this.m_CurrentPlayer.acceleration.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00032334 File Offset: 0x00030534
		private void trackSprintSpeed_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.sprintspeed = this.trackSprintSpeed.Value;
			this.labelSprintSpeed.Text = this.labelSprintSpeed.Text.Substring(0, this.labelSprintSpeed.Text.IndexOf(' '));
			Label label = this.labelSprintSpeed;
			label.Text = label.Text + " " + this.m_CurrentPlayer.sprintspeed.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000323E8 File Offset: 0x000305E8
		private void trackStamina_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.stamina = this.trackStamina.Value;
			this.labelStamina.Text = this.labelStamina.Text.Substring(0, this.labelStamina.Text.IndexOf(' '));
			Label label = this.labelStamina;
			label.Text = label.Text + " " + this.m_CurrentPlayer.stamina.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0003249C File Offset: 0x0003069C
		private void trackStrength_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.strength = this.trackStrength.Value;
			this.labelStrength.Text = this.labelStrength.Text.Substring(0, this.labelStrength.Text.IndexOf(' '));
			Label label = this.labelStrength;
			label.Text = label.Text + " " + this.m_CurrentPlayer.strength.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00032550 File Offset: 0x00030750
		private void trackAgility_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.agility = this.trackAgility.Value;
			this.labelAgility.Text = this.labelAgility.Text.Substring(0, this.labelAgility.Text.IndexOf(' '));
			Label label = this.labelAgility;
			label.Text = label.Text + " " + this.m_CurrentPlayer.agility.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00032604 File Offset: 0x00030804
		private void trackJumping_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.jumping = this.trackJumping.Value;
			this.labelJumping.Text = this.labelJumping.Text.Substring(0, this.labelJumping.Text.IndexOf(' '));
			Label label = this.labelJumping;
			label.Text = label.Text + " " + this.m_CurrentPlayer.jumping.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000326B8 File Offset: 0x000308B8
		private void trackReactions_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.reactions = this.trackReactions.Value;
			this.labelReactions.Text = this.labelReactions.Text.Substring(0, this.labelReactions.Text.IndexOf(' '));
			Label label = this.labelReactions;
			label.Text = label.Text + " " + this.m_CurrentPlayer.reactions.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0003276C File Offset: 0x0003096C
		private void trackPotential_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.potential = this.trackPotential.Value;
			this.labelPotential.Text = this.labelPotential.Text.Substring(0, this.labelPotential.Text.IndexOf(' '));
			Label label = this.labelPotential;
			label.Text = label.Text + " " + this.m_CurrentPlayer.potential.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMentalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(5);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00032820 File Offset: 0x00030A20
		private void trackPlayerPositioning_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.positioning = this.trackPlayerPositioning.Value;
			this.labelPlayerPositioning.Text = this.labelPlayerPositioning.Text.Substring(0, this.labelPlayerPositioning.Text.IndexOf(' '));
			Label label = this.labelPlayerPositioning;
			label.Text = label.Text + " " + this.m_CurrentPlayer.positioning.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericMentalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(5);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000328D4 File Offset: 0x00030AD4
		private void trackBalance_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.balance = this.trackBalance.Value;
			this.labelBalance.Text = this.labelBalance.Text.Substring(0, this.labelBalance.Text.IndexOf(' '));
			Label label = this.labelBalance;
			label.Text = label.Text + " " + this.m_CurrentPlayer.balance.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericPhysicalSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00032988 File Offset: 0x00030B88
		private void trackOverallrating_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.overallrating = this.trackOverallrating.Value;
			this.labelOverallrating.Text = this.labelOverallrating.Text.Substring(0, this.labelOverallrating.Text.IndexOf(' '));
			Label label = this.labelOverallrating;
			label.Text = label.Text + " " + this.m_CurrentPlayer.overallrating.ToString();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00032A0C File Offset: 0x00030C0C
		private void RandomizeAttributes(int level)
		{
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(13);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			this.m_CurrentPlayer.RandomizeAttributes(level);
			this.LoadPlayerSkills();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00032A41 File Offset: 0x00030C41
		private void buttonRandomPoor_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(0);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00032A4A File Offset: 0x00030C4A
		private void buttonRandomBelowAvg_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(1);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00032A53 File Offset: 0x00030C53
		private void buttonRandomAverage_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00032A5C File Offset: 0x00030C5C
		private void buttonRandomAboveAvg_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(3);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00032A65 File Offset: 0x00030C65
		private void buttonRandomGood_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(4);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00032A6E File Offset: 0x00030C6E
		private void buttonRandomVeryGood_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(5);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00032A77 File Offset: 0x00030C77
		private void buttonRandomSuperstar_Click(object sender, EventArgs e)
		{
			this.RandomizeAttributes(6);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00032A80 File Offset: 0x00030C80
		private void numericOverall_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_OverallSema)
			{
				this.m_OverallSema = false;
				int num = (int)this.numericRandomize.Value;
				int averageRoleAttribute = this.m_CurrentPlayer.GetAverageRoleAttribute();
				int num2 = num - averageRoleAttribute;
				if (num2 == 0)
				{
					return;
				}
				if (this.numericGoalkeeperSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericGoalkeeperSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericDefensiveSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericDefensiveSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericMidfielderSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericMidfielderSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericAttackingSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericAttackingSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericPhysicalSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericPhysicalSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericMentalSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericMentalSkills;
					numericUpDown.Value += num2;
				}
				if (this.numericFreeKickSkills.Value + num2 < 100m && this.numericGoalkeeperSkills.Value + num2 > 0m)
				{
					NumericUpDown numericUpDown = this.numericFreeKickSkills;
					numericUpDown.Value += num2;
				}
			}
			this.trackOverallrating.Value = (int)this.numericRandomize.Value;
			this.m_OverallSema = true;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00032DA0 File Offset: 0x00030FA0
		private void numericGoalkeeperSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericGoalkeeperSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(0);
				int num3 = num - num2;
				int num4 = this.trackPositioning.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackPositioning.Value = num4;
				num4 = this.trackDiving.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackDiving.Value = num4;
				num4 = this.trackHandling.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackHandling.Value = num4;
				num4 = this.trackReflexes.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackReflexes.Value = num4;
				num4 = this.trackGkKicking.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackGkKicking.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00032EC4 File Offset: 0x000310C4
		private void numericDefensiveSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericDefensiveSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				int num3 = num - num2;
				int num4 = this.trackAggression.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackAggression.Value = num4;
				num4 = this.trackTackling.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackTackling.Value = num4;
				num4 = this.trackSliding.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackSliding.Value = num4;
				num4 = this.trackMarking.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackMarking.Value = num4;
				num4 = this.trackInterception.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackInterception.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00032FE8 File Offset: 0x000311E8
		private void numericMidfielderSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericMidfielderSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(2);
				int num3 = num - num2;
				int num4 = this.trackShortPassing.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackShortPassing.Value = num4;
				num4 = this.trackLongPassing.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackLongPassing.Value = num4;
				num4 = this.trackCrossing.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackCrossing.Value = num4;
				num4 = this.trackBallControl.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackBallControl.Value = num4;
				num4 = this.trackVision.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackVision.Value = num4;
				num4 = this.trackCurve.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackCurve.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00033138 File Offset: 0x00031338
		private void numericAttackingSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericAttackingSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(3);
				int num3 = num - num2;
				int num4 = this.trackFinishing.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackFinishing.Value = num4;
				num4 = this.trackShotPower.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackShotPower.Value = num4;
				num4 = this.trackLongShot.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackLongShot.Value = num4;
				num4 = this.trackDribbling.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackDribbling.Value = num4;
				num4 = this.trackVolley.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackVolley.Value = num4;
				num4 = this.trackHeading.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackHeading.Value = num4;
				num4 = this.trackFreeKick.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackFreeKick.Value = num4;
				num4 = this.trackPenalties.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackPenalties.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000332E0 File Offset: 0x000314E0
		private void numericFreeKickSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericFreeKickSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(6);
				int num3 = num - num2;
				int num4 = this.trackFreeKick.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackFreeKick.Value = num4;
				num4 = this.trackPenalties.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackPenalties.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00033380 File Offset: 0x00031580
		private void numericGenericSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericPhysicalSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(4);
				int num3 = num - num2;
				int num4 = this.trackAcceleration.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackAcceleration.Value = num4;
				num4 = this.trackSprintSpeed.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackSprintSpeed.Value = num4;
				num4 = this.trackStamina.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackStamina.Value = num4;
				num4 = this.trackStrength.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackStrength.Value = num4;
				num4 = this.trackAgility.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackAgility.Value = num4;
				num4 = this.trackJumping.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackJumping.Value = num4;
				num4 = this.trackReactions.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackReactions.Value = num4;
				num4 = this.trackBalance.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackBalance.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00033528 File Offset: 0x00031728
		private void numericMentalSkills_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				int num = (int)this.numericMentalSkills.Value;
				int num2 = this.m_CurrentPlayer.ComputeMeanAttributes(5);
				int num3 = num - num2;
				int num4 = this.trackPotential.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackPotential.Value = num4;
				num4 = this.trackPlayerPositioning.Value + num3;
				num4 = ((num4 < 1) ? 1 : ((num4 > 99) ? 99 : num4));
				this.trackPlayerPositioning.Value = num4;
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000335C6 File Offset: 0x000317C6
		private void tabEditPlayer_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadPlayer(this.m_CurrentPlayer);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000335D4 File Offset: 0x000317D4
		private void LoadPlayerFace()
		{
			this.m_GenericAppearanceSema = false;
			this.checkHasGenericFace.Checked = this.m_CurrentPlayer.headclasscode != 0;
			this.groupHairModel.Enabled = this.checkHasGenericFace.Checked;
			this.groupHeadModel.Enabled = this.checkHasGenericFace.Checked;
			this.groupGenericFaceType.Enabled = this.checkHasGenericFace.Checked;
			this.groupSpecifiHeadControls.Enabled = !this.checkHasGenericFace.Checked;
			this.buttonRgbHair.Visible = !this.checkHasGenericFace.Checked && this.checkShowTexures.Checked;
			this.numericSkinTone.Value = this.m_CurrentPlayer.skintonecode;
			this.SetSkinLabel(this.m_CurrentPlayer.skintonecode);
			GenericHead.EHeadModelSet eheadModelSet = GenericHead.GetModelSet(this.m_CurrentPlayer.headtypecode);
			if (eheadModelSet == GenericHead.EHeadModelSet.Unknown)
			{
				eheadModelSet = GenericHead.EHeadModelSet.Caucasic;
				this.m_CurrentPlayer.headtypecode = GenericHead.GetModelId(eheadModelSet, 0);
			}
			int modelSetIndex = GenericHead.GetModelSetIndex(eheadModelSet, this.m_CurrentPlayer.headtypecode);
			switch (eheadModelSet)
			{
			case GenericHead.EHeadModelSet.African:
				this.comboAfricanModels.SelectedIndex = modelSetIndex;
				this.radioButtonAfrican.Checked = true;
				break;
			case GenericHead.EHeadModelSet.Asiatic:
				this.comboAsiaticModels.SelectedIndex = modelSetIndex;
				this.radioButtonAsiatic.Checked = true;
				break;
			case GenericHead.EHeadModelSet.Caucasic:
				this.comboCaucasicModels.SelectedIndex = modelSetIndex;
				this.radioButtonCaucasic.Checked = true;
				break;
			case GenericHead.EHeadModelSet.Latin:
				this.comboLatinModels.SelectedIndex = modelSetIndex;
				this.radioButtonLatin.Checked = true;
				break;
			case GenericHead.EHeadModelSet.Female:
				this.comboFemaleModels.SelectedIndex = modelSetIndex;
				this.radioButtonFemale.Checked = true;
				break;
			}
			GenericHead.EHairModelSet hairModelSet = GenericHead.GetHairModelSet(this.m_CurrentPlayer.hairtypecode);
			int hairModelSetIndex = GenericHead.GetHairModelSetIndex(hairModelSet, this.m_CurrentPlayer.hairtypecode);
			switch (hairModelSet)
			{
			case GenericHead.EHairModelSet.Shaven:
				this.comboShaven.SelectedIndex = hairModelSetIndex;
				this.radioShaven.Checked = true;
				break;
			case GenericHead.EHairModelSet.VeryShort:
				this.comboVeryShort.SelectedIndex = hairModelSetIndex;
				this.radioVeryShort.Checked = true;
				break;
			case GenericHead.EHairModelSet.Short:
				this.comboShort.SelectedIndex = hairModelSetIndex;
				this.radioShort.Checked = true;
				break;
			case GenericHead.EHairModelSet.Modern:
				this.comboModern.SelectedIndex = hairModelSetIndex;
				this.radioModern.Checked = true;
				break;
			case GenericHead.EHairModelSet.Medium:
				this.comboMedium.SelectedIndex = hairModelSetIndex;
				this.radioMedium.Checked = true;
				break;
			case GenericHead.EHairModelSet.Long:
				this.comboLong.SelectedIndex = hairModelSetIndex;
				this.radioLong.Checked = true;
				break;
			case GenericHead.EHairModelSet.Afro:
				this.comboAfro.SelectedIndex = hairModelSetIndex;
				this.radioAfro.Checked = true;
				break;
			case GenericHead.EHairModelSet.Headbend:
				this.comboHeadband.SelectedIndex = hairModelSetIndex;
				this.radioHeadband.Checked = true;
				break;
			case GenericHead.EHairModelSet.FemaleHair:
				this.comboFemaleHair.SelectedIndex = hairModelSetIndex;
				this.radioButtonFemaleHair.Checked = true;
				break;
			}
			this.domainFacialHair.SelectedIndex = this.m_CurrentPlayer.facialhairtypecode;
			this.domainHairColor.SelectedIndex = this.m_CurrentPlayer.haircolorcode;
			this.comboSideburns.SelectedIndex = this.m_CurrentPlayer.sideburnscode;
			this.comboSkintype.SelectedIndex = this.m_CurrentPlayer.skintypecode;
			this.comboEyescolor.SelectedIndex = this.m_CurrentPlayer.eyecolorcode - 1;
			this.comboEyeBow.SelectedIndex = this.m_CurrentPlayer.eyebrowcode;
			this.comboFaceposer.SelectedIndex = this.m_CurrentPlayer.faceposercode;
			this.comboFacialHairColor.SelectedIndex = this.m_CurrentPlayer.facialhaircolorcode;
			this.m_GenericAppearanceSema = true;
			this.viewer2DPlayerGui.CurrentBitmap = this.m_CurrentPlayer.GetPhoto();
			this.GetAndShowTextures();
			this.UpdateAndShowHead3D();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000339AC File Offset: 0x00031BAC
		private void radioButtonAsiatic_CheckedChanged(object sender, EventArgs e)
		{
			if (this.comboAsiaticModels.SelectedIndex < 0)
			{
				this.comboAsiaticModels.SelectedIndex = 0;
			}
			this.comboAsiaticModels.Visible = this.radioButtonAsiatic.Checked;
			if (this.radioButtonAsiatic.Checked)
			{
				this.radioButtonAsiatic.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.headtypecode != GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex])
				{
					this.m_CurrentPlayer.headtypecode = GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				this.radioButtonAsiatic.BackColor = Color.Transparent;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00033A7C File Offset: 0x00031C7C
		private void radioButtonCaucasic_CheckedChanged(object sender, EventArgs e)
		{
			if (this.comboCaucasicModels.SelectedIndex < 0)
			{
				this.comboCaucasicModels.SelectedIndex = 0;
			}
			this.comboCaucasicModels.Visible = this.radioButtonCaucasic.Checked;
			if (this.radioButtonCaucasic.Checked)
			{
				this.radioButtonCaucasic.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.headtypecode != GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex])
				{
					this.m_CurrentPlayer.headtypecode = GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				this.radioButtonCaucasic.BackColor = Color.Transparent;
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00033B4C File Offset: 0x00031D4C
		private void radioButtonAfrican_CheckedChanged(object sender, EventArgs e)
		{
			if (this.comboAfricanModels.SelectedIndex < 0)
			{
				this.comboAfricanModels.SelectedIndex = 0;
			}
			this.comboAfricanModels.Visible = this.radioButtonAfrican.Checked;
			if (this.radioButtonAfrican.Checked)
			{
				this.radioButtonAfrican.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.headtypecode != GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex])
				{
					this.m_CurrentPlayer.headtypecode = GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				this.radioButtonAfrican.BackColor = Color.Transparent;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00033C1C File Offset: 0x00031E1C
		private void radioButtonLatin_CheckedChanged(object sender, EventArgs e)
		{
			if (this.comboLatinModels.SelectedIndex < 0)
			{
				this.comboLatinModels.SelectedIndex = 0;
			}
			this.comboLatinModels.Visible = this.radioButtonLatin.Checked;
			if (this.radioButtonLatin.Checked)
			{
				this.radioButtonLatin.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.headtypecode != GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex])
				{
					this.m_CurrentPlayer.headtypecode = GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				this.radioButtonLatin.BackColor = Color.Transparent;
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00033CEC File Offset: 0x00031EEC
		private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (this.comboFemaleModels.SelectedIndex < 0)
			{
				this.comboFemaleModels.SelectedIndex = 0;
			}
			this.comboFemaleModels.Visible = this.radioButtonFemale.Checked;
			if (this.radioButtonFemale.Checked)
			{
				this.radioButtonFemale.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.headtypecode != GenericHead.c_FemaleModels[this.comboFemaleModels.SelectedIndex])
				{
					this.m_CurrentPlayer.headtypecode = GenericHead.c_FemaleModels[this.comboFemaleModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				this.radioButtonFemale.BackColor = Color.Transparent;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00033DBC File Offset: 0x00031FBC
		private void comboAsiaticModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboAsiaticModels.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.headtypecode = GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00033E28 File Offset: 0x00032028
		private void comboAfricanModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboAfricanModels.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.headtypecode = GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00033E94 File Offset: 0x00032094
		private void comboCaucasicModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboCaucasicModels.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.headtypecode = GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00033F00 File Offset: 0x00032100
		private void comboLatinModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboLatinModels.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.headtypecode = GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00033F6C File Offset: 0x0003216C
		private void comboFemaleModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboFemaleModels.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.headtypecode = GenericHead.c_FemaleModels[this.comboFemaleModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00033FD6 File Offset: 0x000321D6
		private void radioButtonAfro_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_AfroModels);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00033FE4 File Offset: 0x000321E4
		private void radioButtonLong_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_LongModels);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00033FF2 File Offset: 0x000321F2
		private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_MediumModels);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00034000 File Offset: 0x00032200
		private void radioShaven_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ShavenModels);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0003400E File Offset: 0x0003220E
		private void radioModern_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ModernModels);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0003401C File Offset: 0x0003221C
		private void radioVeryShort_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_VeryShortModels);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0003402A File Offset: 0x0003222A
		private void radioShort_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ShortModels);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00034038 File Offset: 0x00032238
		private void radioHeadband_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_HeadbendModels);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00034046 File Offset: 0x00032246
		private void radioButtonFemaleHair_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_FemaleHairModels);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00034054 File Offset: 0x00032254
		private void radioHair_CheckedChanged(object sender, int[] hairMap)
		{
			RadioButton radioButton = (RadioButton)sender;
			ComboBox comboBox = (ComboBox)radioButton.Tag;
			if (comboBox.SelectedIndex < 0)
			{
				comboBox.SelectedIndex = 0;
			}
			comboBox.Visible = radioButton.Checked;
			if (radioButton.Checked)
			{
				radioButton.BackColor = Color.LightSkyBlue;
				if (this.m_CurrentPlayer.hairtypecode != hairMap[comboBox.SelectedIndex])
				{
					this.m_CurrentPlayer.hairtypecode = hairMap[comboBox.SelectedIndex];
					if (this.m_GenericAppearanceSema && (this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
					{
						this.m_CurrentPlayer.CleanHairTextures();
						this.GetAndShowHairTexture();
						this.UpdateAndShowHead3D();
						return;
					}
				}
			}
			else
			{
				radioButton.BackColor = Color.Transparent;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0003411D File Offset: 0x0003231D
		private void comboHeadband_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_HeadbendModels);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0003412B File Offset: 0x0003232B
		private void comboFemaleHair_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_FemaleHairModels);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0003413C File Offset: 0x0003233C
		private void comboHair_SelectedIndexChanged(object sender, int[] hairMap)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (this.m_GenericAppearanceSema && comboBox.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.hairtypecode = hairMap[comboBox.SelectedIndex];
				if (this.m_GenericAppearanceSema && (this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHair();
					this.GetAndShowHairTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000341BA File Offset: 0x000323BA
		private void comboAfro_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_AfroModels);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000341C8 File Offset: 0x000323C8
		private void comboLong_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_LongModels);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000341D6 File Offset: 0x000323D6
		private void comboMedium_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_MediumModels);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000341E4 File Offset: 0x000323E4
		private void comboModern_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ModernModels);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000341F2 File Offset: 0x000323F2
		private void comboShaven_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ShavenModels);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00034200 File Offset: 0x00032400
		private void comboShort_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ShortModels);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0003420E File Offset: 0x0003240E
		private void comboVeryShort_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_VeryShortModels);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0003421C File Offset: 0x0003241C
		private void EnableTool3DButtons()
		{
			if (this.m_CurrentPlayer != null)
			{
				this.buttonImport3DHairModel.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonRemoveHairModel.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairDown.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairAhead.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairBack.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairUp.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairLeft.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMoveHairRight.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMakeHairCloser.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonMakeHairWider.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
				this.buttonRemove3DHeadModel.Enabled = this.m_CurrentPlayer.HasSpecificHeadModel;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00034328 File Offset: 0x00032528
		private void UpdateAndShowHead3D()
		{
			this.EnableTool3DButtons();
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap faceTexture = this.m_CurrentPlayer.GetFaceTexture();
			Bitmap eyesTexture = this.m_CurrentPlayer.GetEyesTexture();
			Rx3File headModel = this.m_CurrentPlayer.GetHeadModel();
			if (headModel == null)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Player.s_Model3DHead = null;
			Player.s_Model3DEyes = null;
			Player.s_Model3DHairPart4 = null;
			Player.s_Model3DHairPart5 = null;
			if (headModel.Rx3VertexArrays[0].nVertex > headModel.Rx3VertexArrays[1].nVertex)
			{
				Player.s_Model3DHead = new Model3D(headModel.Rx3IndexArrays[0], headModel.Rx3VertexArrays[0], faceTexture);
				Player.s_Model3DEyes = new Model3D(headModel.Rx3IndexArrays[1], headModel.Rx3VertexArrays[1], eyesTexture);
			}
			else
			{
				Player.s_Model3DHead = new Model3D(headModel.Rx3IndexArrays[1], headModel.Rx3VertexArrays[1], faceTexture);
				Player.s_Model3DEyes = new Model3D(headModel.Rx3IndexArrays[0], headModel.Rx3VertexArrays[0], eyesTexture);
			}
			Rx3File hairModel = this.m_CurrentPlayer.GetHairModel();
			if (hairModel != null)
			{
				Bitmap hairColorTexture = this.m_CurrentPlayer.GetHairColorTexture();
				Bitmap genericHairColorTexture = this.m_CurrentPlayer.GetGenericHairColorTexture();
				Bitmap hairAlfaTexture = this.m_CurrentPlayer.GetHairAlfaTexture();
				Bitmap bitmap = null;
				Bitmap bitmap2 = null;
				if (hairAlfaTexture != null)
				{
					int num = hairColorTexture.Width / hairAlfaTexture.Width;
					int num2 = hairColorTexture.Height / hairAlfaTexture.Height;
					if (genericHairColorTexture != null)
					{
						bitmap = (Bitmap)GraphicUtil.CanvasSizeBitmapCentered(hairColorTexture, hairAlfaTexture.Width, hairAlfaTexture.Height).Clone();
						GraphicUtil.GetAlfaFromChannel(bitmap, hairAlfaTexture, 4 - this.m_HairAlfaChannel);
					}
					if (hairColorTexture != null)
					{
						bitmap2 = (Bitmap)GraphicUtil.CanvasSizeBitmapCentered(hairColorTexture, hairAlfaTexture.Width, hairAlfaTexture.Height).Clone();
						GraphicUtil.GetAlfaFromChannel(bitmap2, hairAlfaTexture, this.m_HairAlfaChannel);
					}
				}
				Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
				if (hairModel.HairAlfaFlag == 53 || hairModel.HairAlfaFlag == 54 || hairModel.HairAlfaFlag == 58)
				{
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap2);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap);
					}
				}
				else if (hairModel.HairAlfaFlag == 50)
				{
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap2);
					}
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Unexpected Hair Format");
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap2);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap);
					}
				}
			}
			this.ShowHead3D();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00034618 File Offset: 0x00032818
		private void ShowHead3D()
		{
			int num = 2;
			if (Player.s_Model3DHairPart4 != null)
			{
				num = 3;
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				num = 4;
			}
			Kit kit = null;
			if (this.buttonShowJesey.Checked && this.m_CurrentPlayer.m_PlayingForTeams.Count > 0)
			{
				Team team = (Team)this.m_CurrentPlayer.m_PlayingForTeams[0];
				int num2 = ((this.m_CurrentPlayer.preferredposition1 != 0) ? 0 : 2);
				if (num2 == 2 && team.m_KitList.Count < 3)
				{
					kit = FifaEnvironment.Kits.GetKit(5000 + (team.Id & 15), 2);
				}
				else
				{
					for (int i = 0; i < team.m_KitList.Count; i++)
					{
						kit = (Kit)team.m_KitList[i];
						if (kit.kittype == num2 && kit.year == 0)
						{
							break;
						}
					}
				}
				if (kit != null)
				{
					Bitmap[] kitTextures = kit.GetKitTextures();
					if (kitTextures != null)
					{
						Bitmap bitmap = GraphicUtil.EmbossBitmap(kitTextures[1], Kit.s_JerseyWrinkle);
						Kit.s_JerseyModel3D[kit.jerseyCollar].TextureBitmap = bitmap;
					}
				}
			}
			if (kit != null)
			{
				num++;
			}
			this.viewer3D.Clean(num);
			int num3 = 0;
			if (kit != null)
			{
				this.viewer3D.SetMesh(num3++, Kit.s_JerseyModel3D[kit.jerseyCollar]);
			}
			this.viewer3D.SetMesh(num3++, Player.s_Model3DHead);
			this.viewer3D.SetMesh(num3++, Player.s_Model3DEyes);
			if (Player.s_Model3DHairPart4 != null)
			{
				this.viewer3D.SetMesh(num3++, Player.s_Model3DHairPart4, false);
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				this.viewer3D.SetMesh(num3++, Player.s_Model3DHairPart5, false);
			}
			this.viewer3D.Render();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000347CF File Offset: 0x000329CF
		private void GetAndShowTextures()
		{
			this.GetAndShowFaceTexture();
			this.GetAndShowHairTexture();
			this.GetAndShowSkinTexture();
			this.GetAndShowEyeTexture();
			this.GetAndShowTattoosTexture();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000347F0 File Offset: 0x000329F0
		private void GetAndShowSkinTexture()
		{
			if (this.checkShowTexures.Checked && this.viewer2DSkinTexture.ShowButtonChecked)
			{
				this.viewer2DSkinTexture.CurrentBitmap = this.m_CurrentPlayer.GetSkinTexture();
				this.viewer2DSkinTexture.Enabled = true;
				return;
			}
			this.viewer2DSkinTexture.CurrentBitmap = null;
			this.viewer2DSkinTexture.Enabled = false;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00034854 File Offset: 0x00032A54
		private void GetAndShowTattoosTexture()
		{
			if (this.checkShowTexures.Checked && this.m_CurrentPlayer.HasSpecificHeadModel && this.viewer2DTattoos.ShowButtonChecked)
			{
				this.viewer2DTattoos.CurrentBitmap = this.m_CurrentPlayer.GetTattoos();
				this.viewer2DTattoos.Enabled = true;
				return;
			}
			this.viewer2DTattoos.CurrentBitmap = null;
			this.viewer2DTattoos.Enabled = false;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000348C4 File Offset: 0x00032AC4
		private void GetAndShowEyeTexture()
		{
			if (this.checkShowTexures.Checked && this.viewer2DEyeTexture.ShowButtonChecked)
			{
				this.viewer2DEyeTexture.CurrentBitmap = this.m_CurrentPlayer.GetEyesTexture();
				this.viewer2DEyeTexture.Enabled = true;
				return;
			}
			this.viewer2DEyeTexture.CurrentBitmap = null;
			this.viewer2DEyeTexture.Enabled = false;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00034928 File Offset: 0x00032B28
		private void GetAndShowFaceTexture()
		{
			if (!this.checkShowTexures.Checked || !this.m_CurrentPlayer.HasSpecificHeadModel)
			{
				this.multiViewerFace.Bitmaps = null;
				this.multiViewerFace.Enabled = false;
				return;
			}
			Bitmap[] faceTextures = this.m_CurrentPlayer.GetFaceTextures();
			if (faceTextures != null)
			{
				Bitmap[] array = new Bitmap[faceTextures.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (faceTextures != null)
					{
						if (faceTextures.Length > i && faceTextures[i] != null)
						{
							array[i] = (Bitmap)this.m_CurrentPlayer.GetFaceTextures()[i].Clone();
						}
						else
						{
							array[i] = null;
						}
					}
					else
					{
						array[i] = null;
					}
				}
				this.multiViewerFace.Bitmaps = array;
				this.multiViewerFace.Enabled = true;
				return;
			}
			this.multiViewerFace.Bitmaps = null;
			this.multiViewerFace.Enabled = true;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000349FC File Offset: 0x00032BFC
		private void GetAndShowHairTexture()
		{
			if (this.checkShowTexures.Checked)
			{
				Bitmap[] array = new Bitmap[2];
				for (int i = 0; i < array.Length; i++)
				{
					if (this.m_CurrentPlayer.GetHairTextures() != null)
					{
						array[i] = (Bitmap)this.m_CurrentPlayer.GetHairTextures()[i].Clone();
					}
					else
					{
						array[i] = null;
					}
				}
				this.multiViewerHair.Bitmaps = array;
				this.multiViewerHair.Enabled = true;
				this.buttonRgbHair.Visible = !this.checkHasGenericFace.Checked;
				return;
			}
			this.multiViewerHair.Bitmaps = null;
			this.multiViewerHair.Enabled = false;
			this.buttonRgbHair.Visible = false;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00034AB0 File Offset: 0x00032CB0
		private void domainHairColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema)
			{
				this.m_CurrentPlayer.haircolorcode = this.domainHairColor.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanHairTextures();
					this.GetAndShowHairTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00034B1C File Offset: 0x00032D1C
		private void comboSkintype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboSkintype.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.skintypecode = this.comboSkintype.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanFaceTextures();
					this.GetAndShowFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00034B94 File Offset: 0x00032D94
		private void comboEyescolor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboEyescolor.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.eyecolorcode = this.comboEyescolor.SelectedIndex + 1;
				this.m_CurrentPlayer.CleanEyesTexture();
				this.GetAndShowEyeTexture();
				if (this.buttonShow3DModel.Checked)
				{
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00034BF4 File Offset: 0x00032DF4
		private void domainFacialHair_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema)
			{
				this.m_CurrentPlayer.facialhairtypecode = this.domainFacialHair.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanFaceTextures();
					this.GetAndShowFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00034C60 File Offset: 0x00032E60
		private void comboFacialHairColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboFacialHairColor.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.facialhaircolorcode = this.comboFacialHairColor.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanFaceTextures();
					this.GetAndShowFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00034CD8 File Offset: 0x00032ED8
		private void comboSideburns_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboSideburns.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.sideburnscode = this.comboSideburns.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanFaceTextures();
					this.GetAndShowFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00034D50 File Offset: 0x00032F50
		private void comboEyeBow_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboEyeBow.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.eyebrowcode = this.comboEyeBow.SelectedIndex;
				if ((this.buttonShow3DModel.Checked || this.checkShowTexures.Checked) && !this.m_CurrentPlayer.HasSpecificHeadModel)
				{
					this.m_CurrentPlayer.CleanFaceTextures();
					this.GetAndShowFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00034DC7 File Offset: 0x00032FC7
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.UpdateAndShowHead3D();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00034DCF File Offset: 0x00032FCF
		private void checkShowTexures_CheckedChanged(object sender, EventArgs e)
		{
			this.GetAndShowTextures();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00034DD8 File Offset: 0x00032FD8
		private void buttonRandomizeAppearance_Click(object sender, EventArgs e)
		{
			if (this.radioButtonAfrican.Checked)
			{
				this.m_CurrentPlayer.RandomizeAfricanAppearance();
			}
			else if (this.radioButtonAsiatic.Checked)
			{
				this.m_CurrentPlayer.RandomizeAsiaticAppearance();
			}
			else if (this.radioButtonCaucasic.Checked)
			{
				this.m_CurrentPlayer.RandomizeCaucasianAppearance();
			}
			else if (this.radioButtonLatin.Checked)
			{
				this.m_CurrentPlayer.RandomizeLatinAppearance();
			}
			this.m_CurrentPlayer.CleanAllHead();
			this.LoadPlayerFace();
			this.m_GenericAppearanceSema = true;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00034E64 File Offset: 0x00033064
		private void checkHasGenericFace_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			bool @checked = this.checkHasGenericFace.Checked;
			this.m_CurrentPlayer.headclasscode = (@checked ? 1 : 0);
			this.groupHairModel.Enabled = @checked;
			this.groupHeadModel.Enabled = @checked;
			this.groupGenericFaceType.Enabled = @checked;
			this.groupSpecifiHeadControls.Enabled = !@checked;
			this.buttonRgbHair.Visible = !@checked && this.checkShowTexures.Checked;
			this.LoadPlayerFace();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00034EED File Offset: 0x000330ED
		private void checkUsingrevMod_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkHasGenericFace.Checked;
			bool checked2 = this.checkUsingRevMod.Checked;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00034F08 File Offset: 0x00033108
		private void buttonImport3DHairModels_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_PlayerCurrentFolder, "Open 3D-Near Hair Model file", "3D-Near hair model files (*.rx3)|hair_*.rx3");
			if (text == null)
			{
				return;
			}
			this.m_CurrentPlayer.SetHairModel(text);
			text = FifaEnvironment.BrowseAndCheckModel(ref this.m_PlayerCurrentFolder, "Open 3D-Far Hair Model file", "3D-Far hair model files (*.rx3)|hairlod_*.rx3");
			if (text == null)
			{
				return;
			}
			this.m_CurrentPlayer.SetHairLodModel(text);
			this.m_CurrentPlayer.CleanHairModel();
			this.LoadPlayerFace();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00034F74 File Offset: 0x00033174
		private void buttonExport3DHairModels_Click(object sender, EventArgs e)
		{
			string text = this.m_CurrentPlayer.HairModelFileName();
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_PlayerCurrentFolder);
			}
			text = this.m_CurrentPlayer.HairLodModelFileName();
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_PlayerCurrentFolder);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00034FBC File Offset: 0x000331BC
		private void buttonRemove3DModel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentPlayer.HasSpecificHeadModel)
			{
				DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(10);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return;
				}
				this.m_CurrentPlayer.DeleteHeadModel();
				this.LoadPlayerFace();
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00035000 File Offset: 0x00033200
		private void buttonImport3DHeadModel_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_PlayerCurrentFolder, "Open 3D Head Model file", "3D head model files (*.rx3)|head_*.rx3");
			if (text == null)
			{
				return;
			}
			this.m_CurrentPlayer.CleanHead();
			this.m_CurrentPlayer.SetHeadModel(text);
			this.LoadPlayerFace();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00035048 File Offset: 0x00033248
		private void buttonExport3DHeadModel_Click(object sender, EventArgs e)
		{
			string text = this.m_CurrentPlayer.HeadModelFileName();
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_PlayerCurrentFolder);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00035071 File Offset: 0x00033271
		private void comboPreferredPosition1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPreferredPosition1.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.preferredposition1 = this.comboPreferredPosition1.SelectedIndex - 1;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000350A2 File Offset: 0x000332A2
		private void comboPreferredPosition2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPreferredPosition2.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.preferredposition2 = this.comboPreferredPosition2.SelectedIndex - 1;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000350D3 File Offset: 0x000332D3
		private void comboPreferredPosition3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPreferredPosition3.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.preferredposition3 = this.comboPreferredPosition3.SelectedIndex - 1;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00035104 File Offset: 0x00033304
		private void comboPreferredPosition4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPreferredPosition4.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.preferredposition4 = this.comboPreferredPosition4.SelectedIndex - 1;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00035135 File Offset: 0x00033335
		private void numericSkillMoves_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.labelSkillsStars.ImageIndex = (int)this.numericSkillMoves.Value - 1;
			this.m_CurrentPlayer.skillmoves = this.labelSkillsStars.ImageIndex;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00035174 File Offset: 0x00033374
		private void toolPhoto_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = this.viewer3D.Photo();
			int num = bitmap.Height * 85 / 100;
			int width = bitmap.Width;
			int num2 = ((width < num) ? width : num);
			int num3 = (width - num2) / 2;
			Rectangle rectangle = new Rectangle(num3, 0, num2, num);
			Rectangle rectangle2 = new Rectangle(0, 0, 128, 128);
			Bitmap bitmap2 = GraphicUtil.MakeAutoTransparent(bitmap);
			Bitmap bitmap3 = new Bitmap(128, 128, PixelFormat.Format32bppArgb);
			GraphicUtil.RemapRectangle(bitmap2, rectangle, bitmap3, rectangle2);
			this.m_CurrentPlayer.SetPhoto(bitmap3);
			this.viewer2DPlayerGui.CurrentBitmap = bitmap3;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00035210 File Offset: 0x00033410
		private void labelGkGloves_DoubleClick(object sender, EventArgs e)
		{
			GkGloves gkGloves = (GkGloves)FifaEnvironment.GkGloves.SearchId(this.m_CurrentPlayer.gkglovetypecode);
			if (gkGloves != null)
			{
				MainForm.CM.JumpTo(gkGloves);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00035246 File Offset: 0x00033446
		private void buttonSwitchRenderingMode_Click(object sender, EventArgs e)
		{
			this.m_HairAlfaChannel = 4 - this.m_HairAlfaChannel;
			this.UpdateAndShowHead3D();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0003525C File Offset: 0x0003345C
		private void buttonAhead_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveForward();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveForward();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00035292 File Offset: 0x00033492
		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveBack();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveBack();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000352C8 File Offset: 0x000334C8
		private void buttonUp_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveUp();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveUp();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000352FE File Offset: 0x000334FE
		private void buttonDown_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveDown();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveDown();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00035334 File Offset: 0x00033534
		private void buttonSaveHair_Click(object sender, EventArgs e)
		{
			CustomVertex.PositionNormalTextured[] array = null;
			CustomVertex.PositionNormalTextured[] array2 = null;
			if (Player.s_Model3DHairPart4 != null)
			{
				array = Player.s_Model3DHairPart4.Vertex;
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				array2 = Player.s_Model3DHairPart5.Vertex;
			}
			this.m_CurrentPlayer.UpdateHairVertex(array, array2);
			this.buttonSaveHair.Enabled = false;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00035384 File Offset: 0x00033584
		private void buttonRemoveHairModel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentPlayer.HasSpecificHeadModel)
			{
				DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(10);
				if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
				{
					return;
				}
				this.m_CurrentPlayer.DeleteHairModel();
				this.m_CurrentPlayer.DeleteHairLodModel();
				this.LoadPlayerFace();
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000353D4 File Offset: 0x000335D4
		private void textFirstName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.textFirstName.Text.Trim();
			this.m_CurrentPlayer.firstname = this.textFirstName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentPlayer);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00035424 File Offset: 0x00033624
		private void textSurname_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.lastname = this.textSurname.Text;
			if (this.m_CurrentPlayer.commonname == string.Empty)
			{
				this.m_CurrentPlayer.audioname = this.m_CurrentPlayer.lastname;
				this.m_CurrentPlayer.commentaryid = -1;
			}
			this.pickUpControl.SwitchObject(this.m_CurrentPlayer);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0003549C File Offset: 0x0003369C
		private void textCommonName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.commonname = this.textCommonName.Text;
			this.m_CurrentPlayer.audioname = this.m_CurrentPlayer.commonname;
			this.m_CurrentPlayer.commentaryid = -1;
			this.pickUpControl.SwitchObject(this.m_CurrentPlayer);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000354FB File Offset: 0x000336FB
		private void buttonShowJesey_Click(object sender, EventArgs e)
		{
			this.ShowHead3D();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00035504 File Offset: 0x00033704
		private void listViewPlayingTeams_DoubleClick(object sender, EventArgs e)
		{
			if (this.listViewPlayingTeams.SelectedItems.Count <= 0)
			{
				return;
			}
			Team team = (Team)this.listViewPlayingTeams.SelectedItems[0].Tag;
			if (team != null)
			{
				MainForm.CM.JumpTo(team);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00035550 File Offset: 0x00033750
		private void SetSkinLabel(int skintone)
		{
			switch (skintone)
			{
			case 1:
				this.labelSkinColorInfo.Text = "Light Pink";
				return;
			case 2:
				this.labelSkinColorInfo.Text = "Pink";
				return;
			case 3:
				this.labelSkinColorInfo.Text = "Dark Pink";
				return;
			case 4:
				this.labelSkinColorInfo.Text = "Light Yellow";
				return;
			case 5:
				this.labelSkinColorInfo.Text = "Medium Yellow";
				return;
			case 6:
				this.labelSkinColorInfo.Text = "Dark Yellow";
				return;
			case 7:
				this.labelSkinColorInfo.Text = "Light Brown";
				return;
			case 8:
				this.labelSkinColorInfo.Text = "Medium Brown";
				return;
			case 9:
				this.labelSkinColorInfo.Text = "Dark Brown";
				return;
			case 10:
				this.labelSkinColorInfo.Text = "Very Dark Brown";
				return;
			default:
				this.labelSkinColorInfo.Text = "Special";
				return;
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0003564C File Offset: 0x0003384C
		private void numericSkinTone_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericSkinTone.Value;
			this.m_CurrentPlayer.skintonecode = num;
			this.SetSkinLabel(num);
			this.GetAndShowSkinTexture();
			if (!this.m_CurrentPlayer.HasSpecificHeadModel)
			{
				this.m_CurrentPlayer.CleanFaceTextures();
				this.GetAndShowFaceTexture();
				if (this.buttonShow3DModel.Checked)
				{
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000356C0 File Offset: 0x000338C0
		private void buttonRgbHair_Click(object sender, EventArgs e)
		{
			if (this.multiViewerHair.Bitmaps == null)
			{
				return;
			}
			Bitmap bitmap = this.multiViewerHair.Bitmaps[1];
			if (bitmap == null)
			{
				return;
			}
			ModifyHairColor modifyHairColor = new ModifyHairColor(bitmap);
			if (modifyHairColor.ShowDialog() == DialogResult.OK)
			{
				this.multiViewerHair.Bitmaps[1] = modifyHairColor.Bitmap;
				this.multiViewerHair.buttonSave.Enabled = true;
			}
			modifyHairColor.Dispose();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00035728 File Offset: 0x00033928
		private void checkIsLoan_CheckedChanged(object sender, EventArgs e)
		{
			this.groupIsLoan.Visible = this.checkIsLoan.Checked;
			if (this.m_Locked)
			{
				return;
			}
			if (this.checkIsLoan.Checked)
			{
				this.m_CurrentPlayer.IsLoaned = true;
				if (this.m_CurrentPlayer.TeamLoanedFrom == null)
				{
					if (this.m_CurrentPlayer.PreviousTeam != null)
					{
						this.m_CurrentPlayer.TeamLoanedFrom = this.m_CurrentPlayer.PreviousTeam;
					}
					else
					{
						this.m_CurrentPlayer.TeamLoanedFrom = (Team)this.comboTeamLoanedFrom.SelectedItem;
					}
					this.comboTeamLoanedFrom.SelectedItem = this.m_CurrentPlayer.TeamLoanedFrom;
				}
				DateTime loandateend = this.m_CurrentPlayer.loandateend;
				return;
			}
			this.m_CurrentPlayer.IsLoaned = false;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000357E9 File Offset: 0x000339E9
		private void comboTeamLoanedFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboTeamLoanedFrom.SelectedItem == null)
			{
				this.comboTeamLoanedFrom.Text = string.Empty;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00035814 File Offset: 0x00033A14
		private void pictureColorShoes1_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(Shoes.ShoesColorPalette, this.m_CurrentPlayer.shoecolorcode1);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.shoecolorcode1 = colorSelector.SelectedIndex;
				this.pictureColorShoes1.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00035868 File Offset: 0x00033A68
		private void pictureColorShoes2_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(Shoes.ShoesColorPalette, this.m_CurrentPlayer.shoecolorcode2);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentPlayer.shoecolorcode2 = colorSelector.SelectedIndex;
				this.pictureColorShoes2.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000358BC File Offset: 0x00033ABC
		private void trackInterception_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentPlayer.interceptions = this.trackInterception.Value;
			this.labelInterception.Text = this.labelInterception.Text.Substring(0, this.labelInterception.Text.IndexOf(' '));
			Label label = this.labelInterception;
			label.Text = label.Text + " " + this.m_CurrentPlayer.interceptions.ToString();
			if (this.m_AttributesSema)
			{
				this.m_AttributesSema = false;
				this.numericDefensiveSkills.Value = this.m_CurrentPlayer.ComputeMeanAttributes(1);
				this.m_AttributesSema = true;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0003596F File Offset: 0x00033B6F
		private void buttonMoveHairLeft_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveLeft();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveLeft();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000359A5 File Offset: 0x00033BA5
		private void buttonMoveHairRight_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MoveRight();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MoveRight();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000359DB File Offset: 0x00033BDB
		private void buttonMakeHairCloser_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MakeCloser();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MakeCloser();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00035A11 File Offset: 0x00033C11
		private void buttonMakeHairWider_Click(object sender, EventArgs e)
		{
			if (Player.s_Model3DHairPart4 != null)
			{
				Player.s_Model3DHairPart4.MakeWider();
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				Player.s_Model3DHairPart5.MakeWider();
			}
			this.buttonSaveHair.Enabled = true;
			this.ShowHead3D();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00035A48 File Offset: 0x00033C48
		private void buttonHairSelection_Click(object sender, EventArgs e)
		{
			this.m_HairSelector.HairType = this.m_CurrentPlayer.hairtypecode;
			if (this.m_HairSelector.ShowDialog() == DialogResult.OK && this.m_CurrentPlayer.hairtypecode != this.m_HairSelector.HairType)
			{
				this.m_CurrentPlayer.hairtypecode = this.m_HairSelector.HairType;
				this.m_CurrentPlayer.CleanHair();
				this.LoadPlayerFace();
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00035AB8 File Offset: 0x00033CB8
		private void comboFaceposer_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboFaceposer.SelectedIndex >= 0)
			{
				this.m_CurrentPlayer.faceposercode = this.comboFaceposer.SelectedIndex;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00035AE7 File Offset: 0x00033CE7
		private void textJerseyName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.playerjerseyname = this.textJerseyName.Text;
		}

		// Token: 0x040002FF RID: 767
		public Player m_CurrentPlayer;

		// Token: 0x04000300 RID: 768
		private TabPage m_CurrentPage;

		// Token: 0x04000301 RID: 769
		private string m_PlayerCurrentFolder = FifaEnvironment.ExportFolder;

		// Token: 0x04000302 RID: 770
		private bool m_IsLoaded;

		// Token: 0x04000303 RID: 771
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000304 RID: 772
		private HairSelector m_HairSelector = new HairSelector();

		// Token: 0x04000305 RID: 773
		private bool m_AttributesSema = true;

		// Token: 0x04000306 RID: 774
		private bool m_OverallSema = true;

		// Token: 0x04000307 RID: 775
		private bool m_GenericAppearanceSema = true;

		// Token: 0x04000308 RID: 776
		private bool m_Locked;

		// Token: 0x04000309 RID: 777
		private int m_HairAlfaChannel = 1;

		// Token: 0x0400030A RID: 778
		private static Color[] c_AccPalette = new Color[]
		{
			Color.White,
			Color.Black,
			Color.Blue,
			Color.Red,
			Color.Yellow,
			Color.Green,
			Color.Orange,
			Color.Purple,
			Color.Brown,
			Color.Pink,
			Color.Maroon,
			Color.LightBlue,
			Color.Navy,
			Color.Gray
		};

		// Token: 0x0400030B RID: 779
		private static Color[] c_GlovesPalette = new Color[]
		{
			Color.White,
			Color.Black,
			Color.Yellow,
			Color.Red,
			Color.Navy
		};
	}
}
