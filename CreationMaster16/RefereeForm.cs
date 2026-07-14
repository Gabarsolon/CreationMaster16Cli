using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000018 RID: 24
	public partial class RefereeForm : Form
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00057578 File Offset: 0x00055778
		public RefereeForm()
		{
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
			this.comboShaven.Items.Clear();
			for (int m = 0; m < GenericHead.c_ShavenModels.Length; m++)
			{
				this.comboShaven.Items.Add(GenericHead.c_ShavenModels[m].ToString());
			}
			this.comboVeryShort.Items.Clear();
			for (int n = 0; n < GenericHead.c_VeryShortModels.Length; n++)
			{
				this.comboVeryShort.Items.Add(GenericHead.c_VeryShortModels[n].ToString());
			}
			this.comboShort.Items.Clear();
			for (int num = 0; num < GenericHead.c_ShortModels.Length; num++)
			{
				this.comboShort.Items.Add(GenericHead.c_ShortModels[num].ToString());
			}
			this.comboModern.Items.Clear();
			for (int num2 = 0; num2 < GenericHead.c_ModernModels.Length; num2++)
			{
				this.comboModern.Items.Add(GenericHead.c_ModernModels[num2].ToString());
			}
			this.comboMedium.Items.Clear();
			for (int num3 = 0; num3 < GenericHead.c_MediumModels.Length; num3++)
			{
				this.comboMedium.Items.Add(GenericHead.c_MediumModels[num3].ToString());
			}
			this.comboLong.Items.Clear();
			for (int num4 = 0; num4 < GenericHead.c_LongModels.Length; num4++)
			{
				this.comboLong.Items.Add(GenericHead.c_LongModels[num4].ToString());
			}
			this.comboAfro.Items.Clear();
			for (int num5 = 0; num5 < GenericHead.c_AfroModels.Length; num5++)
			{
				this.comboAfro.Items.Add(GenericHead.c_AfroModels[num5].ToString());
			}
			this.comboHeadband.Items.Clear();
			for (int num6 = 0; num6 < GenericHead.c_HeadbendModels.Length; num6++)
			{
				this.comboHeadband.Items.Add(GenericHead.c_HeadbendModels[num6].ToString());
			}
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectReferee);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateReferee);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteReferee);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneReferee);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshReferee);
			this.pickUpControl.combo.Sorted = false;
			this.viewer2DShoes.ButtonStripVisible = false;
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DPlayerGui.ShowButton = true;
			this.viewer2DPlayerGui.ShowButtonChecked = false;
			this.viewer2DPlayerGui.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMiniface);
			this.viewer2DPlayerGui.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMiniface);
			this.viewer2DPlayerGui.ButtonStripVisible = true;
			this.viewer2DPlayerGui.RemoveButton = true;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00057A08 File Offset: 0x00055C08
		private Referee SelectReferee(object sender, object obj)
		{
			Referee referee = (Referee)obj;
			this.LoadReferee(referee);
			return referee;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00057A24 File Offset: 0x00055C24
		private Referee CreateReferee(object sender, object obj)
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
			return (Referee)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00057A7C File Offset: 0x00055C7C
		private Referee DeleteReferee(object sender, object obj)
		{
			Referee referee = (Referee)obj;
			FifaEnvironment.Referees.DeleteReferee(referee);
			return null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00057A9C File Offset: 0x00055C9C
		private Referee CloneReferee(object sender, object obj)
		{
			Referee referee = (Referee)obj;
			return (Referee)FifaEnvironment.Referees.CloneId(referee);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00057AC0 File Offset: 0x00055CC0
		public Referee RefreshReferee(object sender, object obj)
		{
			this.Preset();
			this.ReloadReferee(this.m_CurrentReferee);
			return this.m_CurrentReferee;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00057ADA File Offset: 0x00055CDA
		public void ReloadReferee(Referee referee)
		{
			this.m_CurrentReferee = null;
			this.LoadReferee(referee);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00057AEC File Offset: 0x00055CEC
		public void LoadReferee(Referee referee)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentReferee == referee)
			{
				return;
			}
			this.m_Locked = true;
			this.m_CurrentReferee = referee;
			this.refereeBindingSource.DataSource = this.m_CurrentReferee;
			this.Refresh();
			this.LoadRefereeInfo();
			this.LoadRefereeFace();
			this.m_Locked = false;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00057B44 File Offset: 0x00055D44
		private void LoadRefereeInfo()
		{
			this.m_Locked = true;
			this.numericRefereeId.Value = this.m_CurrentReferee.Id;
			if (this.m_CurrentReferee.Leagues[0] == null)
			{
				this.comboLeague0.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague0.SelectedItem = this.m_CurrentReferee.Leagues[0];
			}
			if (this.m_CurrentReferee.Leagues[1] == null)
			{
				this.comboLeague1.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague1.SelectedItem = this.m_CurrentReferee.Leagues[1];
			}
			if (this.m_CurrentReferee.Leagues[2] == null)
			{
				this.comboLeague2.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague2.SelectedItem = this.m_CurrentReferee.Leagues[2];
			}
			if (this.m_CurrentReferee.Leagues[3] == null)
			{
				this.comboLeague3.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague3.SelectedItem = this.m_CurrentReferee.Leagues[3];
			}
			if (this.m_CurrentReferee.Leagues[4] == null)
			{
				this.comboLeague4.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague4.SelectedItem = this.m_CurrentReferee.Leagues[4];
			}
			if (this.m_CurrentReferee.Leagues[5] == null)
			{
				this.comboLeague5.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague5.SelectedItem = this.m_CurrentReferee.Leagues[5];
			}
			if (this.m_CurrentReferee.Leagues[6] == null)
			{
				this.comboLeague6.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague6.SelectedItem = this.m_CurrentReferee.Leagues[6];
			}
			if (this.m_CurrentReferee.Leagues[7] == null)
			{
				this.comboLeague7.SelectedIndex = 0;
			}
			else
			{
				this.comboLeague7.SelectedItem = this.m_CurrentReferee.Leagues[7];
			}
			this.numericShoesBrand.Value = this.m_CurrentReferee.shoetypecode;
			this.numericShoesDesign.Value = this.m_CurrentReferee.shoedesigncode;
			this.pictureColorShoes1.BackColor = Shoes.GetGenericColor(this.m_CurrentReferee.shoecolorcode1);
			this.pictureColorShoes2.BackColor = Shoes.GetGenericColor(this.m_CurrentReferee.shoecolorcode2);
			if (this.m_CurrentReferee.shoetypecode == 0)
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
			this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(this.m_CurrentReferee.shoetypecode, this.m_CurrentReferee.shoedesigncode);
			this.m_Locked = false;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00057E1C File Offset: 0x0005601C
		public void Preset()
		{
			Kit.Prepare3DModels();
			this.m_NewIdCreator.IdList = FifaEnvironment.Referees;
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Countries,
				FifaEnvironment.Leagues
			};
			this.pickUpControl.FilterValues = array;
			this.numericShoesBrand.Maximum = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_shoetypecode];
			this.numericRefereeId.Maximum = FifaEnvironment.FifaDb.Table[TI.referee].TableDescriptor.MaxValues[FI.referee_refereeid];
			this.comboLeague0.Items.Clear();
			this.comboLeague0.BeginUpdate();
			this.comboLeague0.Items.Add(this.m_NotPresent);
			this.comboLeague0.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague0.EndUpdate();
			this.comboLeague1.Items.Clear();
			this.comboLeague1.BeginUpdate();
			this.comboLeague1.Items.Add(this.m_NotPresent);
			this.comboLeague1.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague1.EndUpdate();
			this.comboLeague2.Items.Clear();
			this.comboLeague2.BeginUpdate();
			this.comboLeague2.Items.Add(this.m_NotPresent);
			this.comboLeague2.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague2.EndUpdate();
			this.comboLeague3.Items.Clear();
			this.comboLeague3.BeginUpdate();
			this.comboLeague3.Items.Add(this.m_NotPresent);
			this.comboLeague3.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague3.EndUpdate();
			this.comboLeague4.Items.Clear();
			this.comboLeague4.BeginUpdate();
			this.comboLeague4.Items.Add(this.m_NotPresent);
			this.comboLeague4.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague4.EndUpdate();
			this.comboLeague5.Items.Clear();
			this.comboLeague5.BeginUpdate();
			this.comboLeague5.Items.Add(this.m_NotPresent);
			this.comboLeague5.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague5.EndUpdate();
			this.comboLeague6.Items.Clear();
			this.comboLeague6.BeginUpdate();
			this.comboLeague6.Items.Add(this.m_NotPresent);
			this.comboLeague6.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague6.EndUpdate();
			this.comboLeague7.Items.Clear();
			this.comboLeague7.BeginUpdate();
			this.comboLeague7.Items.Add(this.m_NotPresent);
			this.comboLeague7.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			this.comboLeague7.EndUpdate();
			this.countryListBindingSource.DataSource = FifaEnvironment.Countries;
			this.viewer2DPlayerGui.Visible = FifaEnvironment.Year == 14;
			this.toolPhoto.Visible = FifaEnvironment.Year == 14;
			this.pickUpControl.ObjectList = FifaEnvironment.Referees;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000581C8 File Offset: 0x000563C8
		private void numericRefereeId_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentReferee == null)
			{
				return;
			}
			int num = (int)this.numericRefereeId.Value;
			if (num == this.m_CurrentReferee.Id)
			{
				return;
			}
			if (FifaEnvironment.Referees.SearchId(num) == null)
			{
				FifaEnvironment.Referees.ChangeId(this.m_CurrentReferee, num);
				this.m_CurrentReferee.Id = num;
				this.m_CurrentReferee.CleanFaceTexture();
				this.m_CurrentReferee.CleanHairTextures();
				this.LoadRefereeFace();
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericRefereeId.Value = this.m_CurrentReferee.Id;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00058274 File Offset: 0x00056474
		private void LoadRefereeFace()
		{
			this.m_GenericAppearanceSema = false;
			GenericHead.EHeadModelSet eheadModelSet = GenericHead.GetModelSet(this.m_CurrentReferee.headtypecode);
			if (eheadModelSet == GenericHead.EHeadModelSet.Unknown)
			{
				eheadModelSet = GenericHead.EHeadModelSet.Caucasic;
				this.m_CurrentReferee.headtypecode = GenericHead.GetModelId(eheadModelSet, 0);
			}
			int modelSetIndex = GenericHead.GetModelSetIndex(eheadModelSet, this.m_CurrentReferee.headtypecode);
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
			}
			GenericHead.EHairModelSet hairModelSet = GenericHead.GetHairModelSet(this.m_CurrentReferee.hairtypecode);
			int hairModelSetIndex = GenericHead.GetHairModelSetIndex(hairModelSet, this.m_CurrentReferee.hairtypecode);
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
			}
			this.domainFacialHair.SelectedIndex = this.m_CurrentReferee.facialhairtypecode;
			this.domainHairColor.SelectedIndex = this.m_CurrentReferee.haircolorcode;
			this.comboSideburns.SelectedIndex = this.m_CurrentReferee.sideburnscode;
			this.comboSkintype.SelectedIndex = this.m_CurrentReferee.skintypecode;
			this.comboSkinColor.SelectedIndex = this.m_CurrentReferee.skintonecode - 1;
			this.comboEyescolor.SelectedIndex = this.m_CurrentReferee.eyecolorcode - 1;
			this.comboEyeBow.SelectedIndex = this.m_CurrentReferee.eyebrowcode;
			this.comboFacialHairColor.SelectedIndex = this.m_CurrentReferee.facialhaircolorcode;
			this.m_GenericAppearanceSema = true;
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DPlayerGui.CurrentBitmap = this.m_CurrentReferee.GetPhoto();
			}
			this.UpdateAndShowHead3D();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00058548 File Offset: 0x00056748
		private void toolPhoto_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = this.viewer3D.Photo();
			int height = bitmap.Height;
			int width = bitmap.Width;
			int num = ((width < height * 17 / 16) ? width : (height * 5 / 4));
			int num2 = (width - num) / 2;
			Rectangle rectangle = new Rectangle(num2, 0, num, height);
			Rectangle rectangle2 = new Rectangle(0, 10, 256, 190);
			Bitmap bitmap2 = GraphicUtil.MakeAutoTransparent(bitmap);
			Bitmap bitmap3 = new Bitmap(256, 256, PixelFormat.Format32bppArgb);
			GraphicUtil.RemapRectangle(bitmap2, rectangle, bitmap3, rectangle2);
			this.m_CurrentReferee.SetPhoto(bitmap3);
			this.viewer2DPlayerGui.CurrentBitmap = bitmap3;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000585E7 File Offset: 0x000567E7
		private bool ImportImageMiniface(object sender, Bitmap bitmap)
		{
			return this.m_CurrentReferee.SetPhoto(bitmap);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000585F5 File Offset: 0x000567F5
		private bool DeleteMiniface(object sender)
		{
			return this.m_CurrentReferee.DeletePhoto();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00058604 File Offset: 0x00056804
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Referees.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericRefereeId.Value = newId;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00058642 File Offset: 0x00056842
		private void labelCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentReferee.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentReferee.Country);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00058666 File Offset: 0x00056866
		private void RefereeForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00058678 File Offset: 0x00056878
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
				if (this.m_CurrentReferee.headtypecode != GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex])
				{
					this.m_CurrentReferee.headtypecode = GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
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

		// Token: 0x06000372 RID: 882 RVA: 0x00058738 File Offset: 0x00056938
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
				if (this.m_CurrentReferee.headtypecode != GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex])
				{
					this.m_CurrentReferee.headtypecode = GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
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

		// Token: 0x06000373 RID: 883 RVA: 0x000587F8 File Offset: 0x000569F8
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
				if (this.m_CurrentReferee.headtypecode != GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex])
				{
					this.m_CurrentReferee.headtypecode = GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
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

		// Token: 0x06000374 RID: 884 RVA: 0x000588B8 File Offset: 0x00056AB8
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
				if (this.m_CurrentReferee.headtypecode != GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex])
				{
					this.m_CurrentReferee.headtypecode = GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
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

		// Token: 0x06000375 RID: 885 RVA: 0x00058978 File Offset: 0x00056B78
		private void UpdateAndShowHead3D()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap faceTexture = this.m_CurrentReferee.GetFaceTexture();
			Bitmap eyesTexture = this.m_CurrentReferee.GetEyesTexture();
			Rx3File headModel = this.m_CurrentReferee.GetHeadModel();
			if (headModel == null)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Player.s_Model3DHead = new Model3D(headModel.Rx3IndexArrays[0], headModel.Rx3VertexArrays[0], faceTexture);
			Player.s_Model3DEyes = new Model3D(headModel.Rx3IndexArrays[1], headModel.Rx3VertexArrays[1], eyesTexture);
			Player.s_Model3DHairPart4 = null;
			Player.s_Model3DHairPart5 = null;
			if (headModel.Rx3VertexArrays[0].nVertex > headModel.Rx3VertexArrays[1].nVertex)
			{
				Player.s_Model3DHead = new Model3D(headModel.Rx3IndexArrays[0], headModel.Rx3VertexArrays[0], faceTexture);
				Player.s_Model3DEyes = new Model3D(headModel.Rx3IndexArrays[1], headModel.Rx3VertexArrays[1], eyesTexture);
			}
			else
			{
				Player.s_Model3DHead = new Model3D(headModel.Rx3IndexArrays[0], headModel.Rx3VertexArrays[0], eyesTexture);
				Player.s_Model3DEyes = new Model3D(headModel.Rx3IndexArrays[1], headModel.Rx3VertexArrays[1], faceTexture);
			}
			Rx3File hairModel = this.m_CurrentReferee.GetHairModel();
			if (hairModel != null)
			{
				Bitmap bitmap = this.m_CurrentReferee.GetHairColorTexture();
				Bitmap hairAlfaTexture = this.m_CurrentReferee.GetHairAlfaTexture();
				Bitmap bitmap2 = null;
				Bitmap bitmap3 = null;
				if (bitmap != null && hairAlfaTexture != null)
				{
					bitmap = GraphicUtil.ResizeBitmap(bitmap, hairAlfaTexture.Width, hairAlfaTexture.Height, InterpolationMode.Bilinear);
					bitmap2 = (Bitmap)GraphicUtil.CanvasSizeBitmapCentered(bitmap, hairAlfaTexture.Width, hairAlfaTexture.Height).Clone();
					GraphicUtil.GetAlfaFromChannel(bitmap2, hairAlfaTexture, 4 - this.m_HairAlfaChannel);
					bitmap3 = (Bitmap)GraphicUtil.CanvasSizeBitmapCentered(bitmap, hairAlfaTexture.Width, hairAlfaTexture.Height).Clone();
					GraphicUtil.GetAlfaFromChannel(bitmap3, hairAlfaTexture, this.m_HairAlfaChannel);
				}
				Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
				if (hairModel.HairAlfaFlag == 53 || hairModel.HairAlfaFlag == 54 || hairModel.HairAlfaFlag == 58)
				{
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap3);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap2);
					}
				}
				else if (hairModel.HairAlfaFlag == 50)
				{
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap2);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap3);
					}
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Unexpected Hair Format");
					Player.s_Model3DHairPart4 = new Model3D(hairModel.Rx3IndexArrays[0], hairModel.Rx3VertexArrays[0], bitmap3);
					if (hairModel.Rx3IndexArrays.Length > 1)
					{
						Player.s_Model3DHairPart5 = new Model3D(hairModel.Rx3IndexArrays[1], hairModel.Rx3VertexArrays[1], bitmap2);
					}
				}
			}
			this.ShowHead3D();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00058C74 File Offset: 0x00056E74
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
			Kit kit = FifaEnvironment.Kits.GetKit(6004, 5);
			if (kit != null)
			{
				Bitmap bitmap = GraphicUtil.EmbossBitmap(kit.GetKitTextures()[1], Kit.s_JerseyWrinkle);
				Kit.s_JerseyModel3D[kit.jerseyCollar].TextureBitmap = bitmap;
			}
			if (kit != null)
			{
				num++;
			}
			this.viewer3D.Clean(num);
			int num2 = 0;
			if (kit != null)
			{
				this.viewer3D.SetMesh(num2++, Kit.s_JerseyModel3D[kit.jerseyCollar]);
			}
			this.viewer3D.SetMesh(num2++, Player.s_Model3DHead);
			this.viewer3D.SetMesh(num2++, Player.s_Model3DEyes);
			if (Player.s_Model3DHairPart4 != null)
			{
				this.viewer3D.SetMesh(num2++, Player.s_Model3DHairPart4, false);
			}
			if (Player.s_Model3DHairPart5 != null)
			{
				this.viewer3D.SetMesh(num2++, Player.s_Model3DHairPart5, false);
			}
			this.viewer3D.Render();
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00058D73 File Offset: 0x00056F73
		private void radioButtonAfro_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_AfroModels);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00058D81 File Offset: 0x00056F81
		private void radioButtonLong_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_LongModels);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00058D8F File Offset: 0x00056F8F
		private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_MediumModels);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00058D9D File Offset: 0x00056F9D
		private void radioShaven_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ShavenModels);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00058DAB File Offset: 0x00056FAB
		private void radioModern_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ModernModels);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00058DB9 File Offset: 0x00056FB9
		private void radioVeryShort_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_VeryShortModels);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00058DC7 File Offset: 0x00056FC7
		private void radioShort_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_ShortModels);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00058DD5 File Offset: 0x00056FD5
		private void radioHeadband_CheckedChanged(object sender, EventArgs e)
		{
			this.radioHair_CheckedChanged(sender, GenericHead.c_HeadbendModels);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00058DE4 File Offset: 0x00056FE4
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
				if (this.m_CurrentReferee.hairtypecode != hairMap[comboBox.SelectedIndex])
				{
					this.m_CurrentReferee.hairtypecode = hairMap[comboBox.SelectedIndex];
					if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
					{
						this.m_CurrentReferee.CleanHairTextures();
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

		// Token: 0x06000380 RID: 896 RVA: 0x00058E90 File Offset: 0x00057090
		private void comboAsiaticModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboAsiaticModels.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.headtypecode = GenericHead.c_AsiaticModels[this.comboAsiaticModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00058EF0 File Offset: 0x000570F0
		private void comboAfricanModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboAfricanModels.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.headtypecode = GenericHead.c_AfricanModels[this.comboAfricanModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00058F50 File Offset: 0x00057150
		private void comboCaucasicModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboCaucasicModels.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.headtypecode = GenericHead.c_CaucasicModels[this.comboCaucasicModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00058FB0 File Offset: 0x000571B0
		private void comboLatinModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboLatinModels.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.headtypecode = GenericHead.c_LatinModels[this.comboLatinModels.SelectedIndex];
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHeadModel();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0005900D File Offset: 0x0005720D
		private void comboHeadband_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_HeadbendModels);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0005901C File Offset: 0x0005721C
		private void comboHair_SelectedIndexChanged(object sender, int[] hairMap)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (this.m_GenericAppearanceSema && comboBox.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.hairtypecode = hairMap[comboBox.SelectedIndex];
				if (this.m_GenericAppearanceSema && this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHair();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0005907A File Offset: 0x0005727A
		private void comboAfro_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_AfroModels);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00059088 File Offset: 0x00057288
		private void comboLong_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_LongModels);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00059096 File Offset: 0x00057296
		private void comboMedium_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_MediumModels);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000590A4 File Offset: 0x000572A4
		private void comboModern_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ModernModels);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000590B2 File Offset: 0x000572B2
		private void comboShaven_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ShavenModels);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000590C0 File Offset: 0x000572C0
		private void comboShort_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_ShortModels);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000590CE File Offset: 0x000572CE
		private void comboVeryShort_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboHair_SelectedIndexChanged(sender, GenericHead.c_VeryShortModels);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000590DC File Offset: 0x000572DC
		private void domainHairColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema)
			{
				this.m_CurrentReferee.haircolorcode = this.domainHairColor.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanHairTextures();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0005911A File Offset: 0x0005731A
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.UpdateAndShowHead3D();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00059124 File Offset: 0x00057324
		private void comboSkintype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboSkintype.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.skintypecode = this.comboSkintype.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0005917C File Offset: 0x0005737C
		private void comboSkinColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboSkinColor.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.skintonecode = this.comboSkinColor.SelectedIndex + 1;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000591D8 File Offset: 0x000573D8
		private void comboEyescolor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboEyescolor.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.eyecolorcode = this.comboEyescolor.SelectedIndex + 1;
				this.m_CurrentReferee.CleanEyesTexture();
				if (this.buttonShow3DModel.Checked)
				{
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00059231 File Offset: 0x00057431
		private void domainFacialHair_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema)
			{
				this.m_CurrentReferee.facialhairtypecode = this.domainFacialHair.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00059270 File Offset: 0x00057470
		private void comboFacialHairColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboFacialHairColor.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.facialhaircolorcode = this.comboFacialHairColor.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000592C8 File Offset: 0x000574C8
		private void comboSideburns_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboSideburns.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.sideburnscode = this.comboSideburns.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00059320 File Offset: 0x00057520
		private void comboEyeBow_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_GenericAppearanceSema && this.comboEyeBow.SelectedIndex >= 0)
			{
				this.m_CurrentReferee.eyebrowcode = this.comboEyeBow.SelectedIndex;
				if (this.buttonShow3DModel.Checked)
				{
					this.m_CurrentReferee.CleanFaceTexture();
					this.UpdateAndShowHead3D();
				}
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonRandomizeIdentity_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00059378 File Offset: 0x00057578
		private void buttonRandomizeAppearance_Click(object sender, EventArgs e)
		{
			if (this.radioButtonAfrican.Checked)
			{
				this.m_CurrentReferee.RandomizeAfricanAppearance();
			}
			else if (this.radioButtonAsiatic.Checked)
			{
				this.m_CurrentReferee.RandomizeAsiaticAppearance();
			}
			else if (this.radioButtonCaucasic.Checked)
			{
				this.m_CurrentReferee.RandomizeCaucasianAppearance();
			}
			else if (this.radioButtonLatin.Checked)
			{
				this.m_CurrentReferee.RandomizeLatinAppearance();
			}
			this.m_CurrentReferee.CleanAllHead();
			this.LoadRefereeFace();
			this.m_GenericAppearanceSema = true;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00059403 File Offset: 0x00057603
		private void buttonSwitchRenderingMode_Click(object sender, EventArgs e)
		{
			this.m_HairAlfaChannel = 4 - this.m_HairAlfaChannel;
			this.UpdateAndShowHead3D();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00059419 File Offset: 0x00057619
		private void textFirstName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentReferee.firstname = this.textFirstName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentReferee);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0005944B File Offset: 0x0005764B
		private void textSurname_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentReferee.surname = this.textSurname.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentReferee);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00059480 File Offset: 0x00057680
		private void comboLeague0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague0.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[0] = null;
				this.m_CurrentReferee.leagueids[0] = 0;
				return;
			}
			League league = (League)this.comboLeague0.SelectedItem;
			this.m_CurrentReferee.Leagues[0] = league;
			this.m_CurrentReferee.leagueids[0] = league.Id;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000594EC File Offset: 0x000576EC
		private void comboLeague1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague1.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[1] = null;
				this.m_CurrentReferee.leagueids[1] = 0;
				return;
			}
			League league = (League)this.comboLeague1.SelectedItem;
			this.m_CurrentReferee.Leagues[1] = league;
			this.m_CurrentReferee.leagueids[1] = league.Id;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00059558 File Offset: 0x00057758
		private void comboLeague2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague2.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[2] = null;
				this.m_CurrentReferee.leagueids[2] = 0;
				return;
			}
			League league = (League)this.comboLeague2.SelectedItem;
			this.m_CurrentReferee.Leagues[2] = league;
			this.m_CurrentReferee.leagueids[2] = league.Id;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000595C4 File Offset: 0x000577C4
		private void comboLeague3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague3.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[3] = null;
				this.m_CurrentReferee.leagueids[3] = 0;
				return;
			}
			League league = (League)this.comboLeague3.SelectedItem;
			this.m_CurrentReferee.Leagues[3] = league;
			this.m_CurrentReferee.leagueids[3] = league.Id;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00059630 File Offset: 0x00057830
		private void comboLeague4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague4.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[4] = null;
				this.m_CurrentReferee.leagueids[4] = 0;
				return;
			}
			League league = (League)this.comboLeague4.SelectedItem;
			this.m_CurrentReferee.Leagues[4] = league;
			this.m_CurrentReferee.leagueids[4] = league.Id;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0005969C File Offset: 0x0005789C
		private void comboLeague5_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague5.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[5] = null;
				this.m_CurrentReferee.leagueids[5] = 0;
				return;
			}
			League league = (League)this.comboLeague5.SelectedItem;
			this.m_CurrentReferee.Leagues[5] = league;
			this.m_CurrentReferee.leagueids[5] = league.Id;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00059708 File Offset: 0x00057908
		private void comboLeague6_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague6.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[6] = null;
				this.m_CurrentReferee.leagueids[6] = 0;
				return;
			}
			League league = (League)this.comboLeague6.SelectedItem;
			this.m_CurrentReferee.Leagues[6] = league;
			this.m_CurrentReferee.leagueids[6] = league.Id;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00059774 File Offset: 0x00057974
		private void comboLeague7_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague7.SelectedIndex == 0)
			{
				this.m_CurrentReferee.Leagues[7] = null;
				this.m_CurrentReferee.leagueids[7] = 0;
				return;
			}
			League league = (League)this.comboLeague7.SelectedItem;
			this.m_CurrentReferee.Leagues[7] = league;
			this.m_CurrentReferee.leagueids[7] = league.Id;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000597E0 File Offset: 0x000579E0
		private void labelShoes_DoubleClick(object sender, EventArgs e)
		{
			Shoes shoes = (Shoes)FifaEnvironment.Shoes.SearchId(this.m_CurrentReferee.shoetypecode);
			if (shoes != null)
			{
				MainForm.CM.JumpTo(shoes);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00059818 File Offset: 0x00057A18
		private void numericShoesBrand_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericShoesBrand.Value;
			if (num == 0)
			{
				this.m_CurrentReferee.shoetypecode = num;
				this.m_CurrentReferee.shoecolorcode1 = 0;
				this.m_CurrentReferee.shoecolorcode2 = 15;
				this.pictureColorShoes1.BackColor = Shoes.ShoesColorPalette[this.m_CurrentReferee.shoecolorcode1];
				this.pictureColorShoes2.BackColor = Shoes.ShoesColorPalette[this.m_CurrentReferee.shoecolorcode2];
				this.numericShoesDesign.Enabled = true;
				this.pictureColorShoes1.Enabled = true;
				this.pictureColorShoes2.Enabled = true;
			}
			else
			{
				this.m_CurrentReferee.shoetypecode = num;
				this.numericShoesDesign.Enabled = false;
				this.pictureColorShoes1.Enabled = false;
				this.pictureColorShoes2.Enabled = false;
				this.pictureColorShoes1.BackColor = Color.Transparent;
				this.pictureColorShoes2.BackColor = Color.Transparent;
				this.m_CurrentReferee.shoedesigncode = 0;
				this.m_CurrentReferee.shoecolorcode1 = 30;
				this.m_CurrentReferee.shoecolorcode2 = 31;
				this.numericShoesDesign.Value = 0m;
			}
			this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(num, 0);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0005996C File Offset: 0x00057B6C
		private void numericShoesDesign_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericShoesDesign.Value;
			this.m_CurrentReferee.shoedesigncode = num;
			if (this.m_CurrentReferee.shoetypecode == 0)
			{
				this.viewer2DShoes.CurrentBitmap = Shoes.GetShoesColorTexture(0, num);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000599C0 File Offset: 0x00057BC0
		private void pictureColorShoes1_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(Shoes.ShoesColorPalette, this.m_CurrentReferee.shoecolorcode1);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentReferee.shoecolorcode1 = colorSelector.SelectedIndex;
				this.pictureColorShoes1.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00059A14 File Offset: 0x00057C14
		private void pictureColorShoes2_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(Shoes.ShoesColorPalette, this.m_CurrentReferee.shoecolorcode2);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentReferee.shoecolorcode2 = colorSelector.SelectedIndex;
				this.pictureColorShoes2.BackColor = colorSelector.SelectedColor;
			}
			colorSelector.Dispose();
		}

		// Token: 0x04000575 RID: 1397
		private Referee m_CurrentReferee;

		// Token: 0x04000576 RID: 1398
		private string m_RefereeCurrentFolder = FifaEnvironment.ExportFolder;

		// Token: 0x04000577 RID: 1399
		private string m_NotPresent = "< None >";

		// Token: 0x04000578 RID: 1400
		private bool m_IsLoaded;

		// Token: 0x04000579 RID: 1401
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x0400057A RID: 1402
		private bool m_GenericAppearanceSema = true;

		// Token: 0x0400057B RID: 1403
		private bool m_Locked;

		// Token: 0x0400057C RID: 1404
		private int m_HairAlfaChannel = 1;
	}
}
