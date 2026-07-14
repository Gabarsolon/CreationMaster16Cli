using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200001B RID: 27
	public partial class StadiumForm : Form
	{
		// Token: 0x060003CD RID: 973 RVA: 0x000610EC File Offset: 0x0005F2EC
		public StadiumForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectStadium);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteStadium);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneStadium);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshStadium);
			this.viewer2DPreview.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImagePreview);
			this.viewer2DPreview.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeletePreview);
			this.viewer2DPreview.ButtonStripVisible = true;
			this.viewer2DPreview.RemoveButton = true;
			this.viewer2DPreviewLarge.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImagePreviewLarge);
			this.viewer2DPreviewLarge.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeletePreviewLarge);
			this.viewer2DPreviewLarge.ButtonStripVisible = true;
			this.viewer2DPreviewLarge.RemoveButton = true;
			this.viewer2DMowing.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMowing);
			this.viewer2DMowing.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMowing);
			this.viewer2DMowing.ButtonStripVisible = true;
			this.viewer2DMowing.RemoveButton = true;
			this.viewer2DNet.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageNet);
			this.viewer2DNet.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteNet);
			this.viewer2DNet.ButtonStripVisible = true;
			this.viewer2DNet.RemoveButton = true;
			this.viewer2DPolice.ButtonStripVisible = false;
			this.multiViewer2DTextures.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3StadiumTextures);
			this.multiViewer2DTextures.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3StadiumTextures);
			this.multiViewer2DTextures.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3StadiumTextures);
			this.multiViewer2DTextures.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3StadiumTextures);
			this.multiViewer2DTextures.ShowDeleteButton = true;
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DMowing.ImageSize = new Size(1024, 1024);
				this.viewer2DPolice.ImageSize = new Size(256, 256);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00061348 File Offset: 0x0005F548
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Stadiums;
			this.numericStadiumId.Maximum = FifaEnvironment.Stadiums.MaxId;
			this.numericMowing.Maximum = FifaEnvironment.FifaDb.Table[TI.stadiums].TableDescriptor.MaxValues[FI.stadiums_stadiummowpattern_code];
			this.numericNet.Maximum = FifaEnvironment.FifaDb.Table[TI.stadiums].TableDescriptor.MaxValues[FI.stadiums_stadiumgoalnetstyle];
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Countries
			};
			this.pickUpControl.FilterValues = array;
			this.RefreshComboBoxes();
			this.stadiumListBindingSource.DataSource = FifaEnvironment.Stadiums;
			this.pickUpControl.ObjectList = FifaEnvironment.Stadiums;
			if (FifaEnvironment.Year == 2014)
			{
				this.viewer2DMowing.ImageSize = new Size(1024, 1024);
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0006144C File Offset: 0x0005F64C
		public void RefreshComboBoxes()
		{
			if (this.comboCountry.Items.Count != FifaEnvironment.Countries.Count + 1)
			{
				this.comboCountry.Items.Clear();
				this.comboCountry.Items.Add("None");
				this.comboCountry.Items.AddRange(FifaEnvironment.Countries.ToArray());
			}
			if (this.comboHomeTeam.Items.Count != FifaEnvironment.Teams.Count + 1)
			{
				this.comboHomeTeam.Items.Clear();
				this.comboHomeTeam.Items.Add(this.m_Undefined);
				this.comboHomeTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00061516 File Offset: 0x0005F716
		private void StadiumForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00061528 File Offset: 0x0005F728
		private Stadium SelectStadium(object sender, object obj)
		{
			Stadium stadium = (Stadium)obj;
			this.Refresh();
			this.LoadStadium(stadium);
			return stadium;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0006154C File Offset: 0x0005F74C
		private Stadium DeleteStadium(object sender, object obj)
		{
			Stadium stadium = (Stadium)obj;
			FifaEnvironment.Stadiums.DeleteStadium(stadium);
			this.m_CurrentStadium = null;
			return null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00061574 File Offset: 0x0005F774
		private Stadium CloneStadium(object sender, object obj)
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
			Stadium stadium = (Stadium)obj;
			return (Stadium)FifaEnvironment.Stadiums.CloneId(stadium, this.m_NewIdCreator.NewObject);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000615DD File Offset: 0x0005F7DD
		public Stadium RefreshStadium(object sender, object obj)
		{
			this.Preset();
			this.ReloadStadium(this.m_CurrentStadium);
			return this.m_CurrentStadium;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000615F7 File Offset: 0x0005F7F7
		public void ReloadStadium(Stadium stadium)
		{
			this.m_CurrentStadium = null;
			this.LoadStadium(stadium);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00061608 File Offset: 0x0005F808
		private bool ImportImagePreview(object sender, Bitmap bitmap)
		{
			int num = this.CurrentPreviewTimeOfDay();
			return num >= 0 && this.m_CurrentStadium.SetPreview(num, bitmap);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00061630 File Offset: 0x0005F830
		private bool DeletePreview(object sender)
		{
			int num = this.CurrentPreviewTimeOfDay();
			return num >= 0 && this.m_CurrentStadium.DeletePreview(num);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00061658 File Offset: 0x0005F858
		private bool ImportImagePreviewLarge(object sender, Bitmap bitmap)
		{
			int num = this.CurrentPreviewTimeOfDay();
			return num >= 0 && this.m_CurrentStadium.SetPreviewLarge(num, bitmap);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00061680 File Offset: 0x0005F880
		private bool DeletePreviewLarge(object sender)
		{
			int num = this.CurrentPreviewTimeOfDay();
			return num >= 0 && this.m_CurrentStadium.DeletePreviewLarge(num);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000616A6 File Offset: 0x0005F8A6
		private bool ImportImageNet(object sender, Bitmap bitmap)
		{
			return this.m_CurrentStadium.SetNet(bitmap);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000616B4 File Offset: 0x0005F8B4
		private bool DeleteNet(object sender)
		{
			return this.m_CurrentStadium.DeleteNet();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000616C1 File Offset: 0x0005F8C1
		private bool ImportImageMowing(object sender, Bitmap bitmap)
		{
			return this.m_CurrentStadium.SetMowingPattern(bitmap);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000616CF File Offset: 0x0005F8CF
		private bool DeleteMowing(object sender)
		{
			return this.m_CurrentStadium.DeleteMowingPattern();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000616DC File Offset: 0x0005F8DC
		private bool ImportImagePolice(object sender, Bitmap bitmap)
		{
			return this.m_CurrentStadium.SetPolice(bitmap);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000616EA File Offset: 0x0005F8EA
		private bool DeletePolice(object sender)
		{
			return this.m_CurrentStadium.DeletePolice();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000616F8 File Offset: 0x0005F8F8
		private bool ExportRx3StadiumTextures(object sender, string exportDir)
		{
			int num = this.CurrentModelTimeOfDay();
			return num >= 0 && FifaEnvironment.ExportFileFromZdata(this.m_CurrentStadium.TexturesFileName(num), exportDir);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00061724 File Offset: 0x0005F924
		private bool SaveRx3StadiumTextures(object sender, Bitmap[] bitmaps)
		{
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				return false;
			}
			bool flag = this.m_CurrentStadium.SetTextures(num, bitmaps);
			if (flag)
			{
				this.ReloadStadium(this.m_CurrentStadium);
			}
			return flag;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0006175C File Offset: 0x0005F95C
		private bool ImportRx3StadiumTextures(object sender, string rx3FileName)
		{
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				return false;
			}
			bool flag = this.m_CurrentStadium.SetTextures(num, rx3FileName);
			if (flag)
			{
				this.ReloadStadium(this.m_CurrentStadium);
			}
			return flag;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00061794 File Offset: 0x0005F994
		private bool DeleteRx3StadiumTextures(object sender)
		{
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				return false;
			}
			bool flag = this.m_CurrentStadium.DeleteContainer(num);
			if (flag)
			{
				this.ReloadStadium(this.m_CurrentStadium);
			}
			return flag;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000617CC File Offset: 0x0005F9CC
		public void LoadStadium(Stadium stadium)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentStadium == stadium && this.m_CurrentPage == this.tabEsitStadium.SelectedTab)
			{
				return;
			}
			this.m_CurrentStadium = stadium;
			this.m_CurrentPage = this.tabEsitStadium.SelectedTab;
			if (this.m_CurrentPage == this.pageStadiumGeneral)
			{
				this.LoadStadiumGeneral();
				return;
			}
			if (this.m_CurrentPage == this.pageStadiumModel)
			{
				this.LoadStadiumModel();
				return;
			}
			if (this.m_CurrentPage == this.pageStadiumPreview)
			{
				this.LoadStadiumPreview();
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00061858 File Offset: 0x0005FA58
		public void LoadStadiumModel()
		{
			this.m_Locked = true;
			this.AdjustPreviewModelRadio();
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				this.multiViewer2DTextures.Bitmaps = null;
				this.multiViewer2DCoverMap.Bitmaps = null;
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.multiViewer2DTextures.Bitmaps = this.m_CurrentStadium.GetTextures(num);
			this.EnableCopyButtons();
			Cursor.Current = Cursors.Default;
			this.m_Locked = false;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000618D0 File Offset: 0x0005FAD0
		public void LoadStadiumPreview()
		{
			this.m_Locked = true;
			this.AdjustPreviewWeatherRadio();
			int num = this.CurrentPreviewTimeOfDay();
			if (num < 0)
			{
				this.viewer2DPreview.CurrentBitmap = null;
				this.viewer2DPreviewLarge.CurrentBitmap = null;
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.viewer2DPreview.CurrentBitmap = this.m_CurrentStadium.GetPreview(num);
			this.viewer2DPreviewLarge.CurrentBitmap = this.m_CurrentStadium.GetPreviewLarge(num);
			Cursor.Current = Cursors.Default;
			this.m_Locked = false;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00061958 File Offset: 0x0005FB58
		private int CurrentModelTimeOfDay()
		{
			int num = -1;
			if (this.radioModelClearDay.Checked)
			{
				num = 1;
			}
			if (this.radioModelNight.Checked)
			{
				num = 3;
			}
			return num;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00061988 File Offset: 0x0005FB88
		private int CurrentPreviewTimeOfDay()
		{
			int num = -1;
			if (this.radioPreviewClearDay.Checked)
			{
				num = 1;
			}
			if (this.radioPreviewNight.Checked)
			{
				num = 3;
			}
			if (this.radioPreviewOvercast.Checked)
			{
				num = 0;
			}
			if (this.radioPreviewSunset.Checked)
			{
				num = 4;
			}
			return num;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000619D4 File Offset: 0x0005FBD4
		private void AdjustPreviewWeatherRadio()
		{
			this.radioPreviewClearDay.Enabled = true;
			this.radioPreviewNight.Enabled = true;
			this.CurrentPreviewTimeOfDay();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000619F5 File Offset: 0x0005FBF5
		private void AdjustPreviewModelRadio()
		{
			this.radioPreviewClearDay.Enabled = true;
			this.radioPreviewNight.Enabled = true;
			this.CurrentModelTimeOfDay();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00061A18 File Offset: 0x0005FC18
		public void LoadStadiumGeneral()
		{
			this.m_Locked = true;
			this.textDatabaseStadiumName.Text = this.m_CurrentStadium.name;
			this.textLocalStadiumName.Text = this.m_CurrentStadium.LocalName;
			this.numericStadiumId.Value = this.m_CurrentStadium.Id;
			this.numericCapacity.Value = this.m_CurrentStadium.capacity;
			this.numericYearBuilt.Value = this.m_CurrentStadium.yearbuilt;
			this.numericCrowdColor.Value = this.m_CurrentStadium.seatcolor;
			this.checkOrientation.Checked = this.m_CurrentStadium.sectionfacedbydefault == 1;
			this.domainStadiumType.SelectedIndex = this.m_CurrentStadium.stadiumtype;
			this.numericEndLineDistance.Value = this.m_CurrentStadium.adboardendlinedistance;
			this.numericSideLineDistance.Value = this.m_CurrentStadium.adboardsidelinedistance;
			this.numericMowing.Value = this.m_CurrentStadium.MowingPatternId;
			this.numericNet.Value = this.m_CurrentStadium.NetColor;
			this.comboPolice.SelectedIndex = this.m_CurrentStadium.policetypecode;
			this.checkSunnyDay.Checked = this.m_CurrentStadium.HasSunnyDay();
			this.checkNight.Checked = this.m_CurrentStadium.HasNight();
			this.checkDeepNet.Checked = this.m_CurrentStadium.IsDeepNet;
			if (this.m_CurrentStadium.Country == null)
			{
				this.comboCountry.SelectedIndex = 0;
			}
			else
			{
				this.comboCountry.SelectedItem = this.m_CurrentStadium.Country;
			}
			this.comboDayWeather.SelectedIndex = this.m_CurrentStadium.GetWeather();
			if (this.m_CurrentStadium.hometeamid == 0 || this.m_CurrentStadium.HomeTeam == null)
			{
				this.comboHomeTeam.SelectedItem = this.m_Undefined;
				this.pictureHomeTeam.BackgroundImage = null;
			}
			else
			{
				this.comboHomeTeam.SelectedItem = this.m_CurrentStadium.HomeTeam;
				this.pictureHomeTeam.BackgroundImage = this.m_CurrentStadium.HomeTeam.GetCrest();
			}
			this.viewer2DPolice.CurrentBitmap = this.m_CurrentStadium.GetPolice();
			this.numericCameraHeight.Value = this.m_CurrentStadium.cameraheight;
			this.numericCameraZoom.Value = this.m_CurrentStadium.camerazoom;
			this.numericAdboardType.Value = this.m_CurrentStadium.adboardtype;
			this.numericTechZoneAwayMinX.Value = this.m_CurrentStadium.stadawaytechzoneminx;
			this.numericTechZoneAwayMaxX.Value = this.m_CurrentStadium.stadawaytechzonemaxx;
			this.numericTechZoneAwayMinZ.Value = this.m_CurrentStadium.stadawaytechzoneminz;
			this.numericTechZoneAwayMaxZ.Value = this.m_CurrentStadium.stadawaytechzonemaxz;
			this.numericTechZoneHomeMinX.Value = this.m_CurrentStadium.stadhometechzoneminx;
			this.numericTechZoneHomeMaxX.Value = this.m_CurrentStadium.stadhometechzonemaxx;
			this.numericTechZoneHomeMinZ.Value = this.m_CurrentStadium.stadhometechzoneminz;
			this.numericTechZoneHomeMaxZ.Value = this.m_CurrentStadium.stadhometechzonemaxz;
			this.checkIsLicensed.Checked = this.m_CurrentStadium.islicensed;
			this.m_Locked = false;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00061DC4 File Offset: 0x0005FFC4
		private void labelCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentStadium.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentStadium.Country);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00061DE8 File Offset: 0x0005FFE8
		private void textDatabaseStadiumName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.name = this.textDatabaseStadiumName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentStadium);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00061E1A File Offset: 0x0006001A
		private void textLocalStadiumName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.LocalName = this.textLocalStadiumName.Text;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00061E3B File Offset: 0x0006003B
		private void numericCapacity_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.capacity = (int)this.numericCapacity.Value;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00061E61 File Offset: 0x00060061
		private void numericYearBuilt_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.yearbuilt = (int)this.numericYearBuilt.Value;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00061E87 File Offset: 0x00060087
		private void domainStadiumType_SelectedItemChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadiumtype = this.domainStadiumType.SelectedIndex;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00061EA8 File Offset: 0x000600A8
		private void numericStadiumId_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericStadiumId.Value;
			if (num == this.m_CurrentStadium.Id)
			{
				return;
			}
			if (FifaEnvironment.Stadiums.SearchId(num) == null)
			{
				FifaEnvironment.Stadiums.ChangeId(this.m_CurrentStadium, num);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericStadiumId.Value = this.m_CurrentStadium.Id;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00061F2C File Offset: 0x0006012C
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Stadiums.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericStadiumId.Value = newId;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00061F6C File Offset: 0x0006016C
		private void comboHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboHomeTeam.SelectedIndex == 0)
			{
				this.m_CurrentStadium.hometeamid = 0;
				this.m_CurrentStadium.HomeTeam = null;
				this.pictureHomeTeam.BackgroundImage = null;
				return;
			}
			Team team = (Team)this.comboHomeTeam.SelectedItem;
			this.m_CurrentStadium.hometeamid = team.Id;
			this.m_CurrentStadium.HomeTeam = team;
			this.pictureHomeTeam.BackgroundImage = team.GetCrest();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00061FF4 File Offset: 0x000601F4
		private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboCountry.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboCountry.SelectedIndex == 0)
			{
				this.m_CurrentStadium.Country = null;
				return;
			}
			this.m_CurrentStadium.Country = (Country)this.comboCountry.SelectedItem;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0006204E File Offset: 0x0006024E
		private void numericCrowdColor_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.seatcolor = (int)this.numericCrowdColor.Value;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00062074 File Offset: 0x00060274
		private void numericEndLineDistance_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.adboardendlinedistance = (int)this.numericEndLineDistance.Value;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0006209A File Offset: 0x0006029A
		private void numericSideLineDistance_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.adboardsidelinedistance = (int)this.numericSideLineDistance.Value;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000620C0 File Offset: 0x000602C0
		private void numericMowing_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentStadium.MowingPatternId = (int)this.numericMowing.Value;
			this.viewer2DMowing.DisposeBitmap();
			this.viewer2DMowing.CurrentBitmap = this.m_CurrentStadium.GetMowingPattern();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000620FE File Offset: 0x000602FE
		private void numericNet_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentStadium.NetColor = (int)this.numericNet.Value;
			this.viewer2DNet.CurrentBitmap = this.m_CurrentStadium.GetNet();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00062131 File Offset: 0x00060331
		private void radioModelOvercast_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumModel();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00062131 File Offset: 0x00060331
		private void radioModelClearDay_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumModel();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00062131 File Offset: 0x00060331
		private void radioModelNight_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumModel();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00062131 File Offset: 0x00060331
		private void radioModelSunset_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumModel();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00062139 File Offset: 0x00060339
		private void tabEsitStadium_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.LoadStadium(this.m_CurrentStadium);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00062147 File Offset: 0x00060347
		private void checkDeepNet_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.IsDeepNet = this.checkDeepNet.Checked;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00062168 File Offset: 0x00060368
		private void checkOrientation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.sectionfacedbydefault = (this.checkOrientation.Checked ? 1 : 0);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0006218F File Offset: 0x0006038F
		private void comboDayWeather_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboDayWeather.SelectedIndex < 0)
			{
				return;
			}
			this.m_CurrentStadium.SetWeather(this.comboDayWeather.SelectedIndex);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000621BF File Offset: 0x000603BF
		private void checkSunnyDay_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.SetSunnyDay(this.checkSunnyDay.Checked);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000621E0 File Offset: 0x000603E0
		private void checkNight_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.SetNight(this.checkNight.Checked);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00062204 File Offset: 0x00060404
		private void comboPolice_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStadium.policetypecode != this.comboPolice.SelectedIndex)
			{
				this.m_CurrentStadium.policetypecode = this.comboPolice.SelectedIndex;
				this.viewer2DPolice.CurrentBitmap = this.m_CurrentStadium.GetPolice();
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00062260 File Offset: 0x00060460
		private void EnableCopyButtons()
		{
			this.m_CopyStadium = (Stadium)this.comboStadiumLights.SelectedItem;
			int num = this.CurrentModelTimeOfDay();
			bool flag = this.m_CopyStadium != null;
			if (flag)
			{
				flag = FifaEnvironment.IsFilePresent(Stadium.GlaresLightFileNames(this.m_CopyStadium.Id, num)[0]);
			}
			if (flag)
			{
				flag = flag && FifaEnvironment.IsFilePresent(Stadium.CrowdFileName(this.m_CopyStadium.Id, num));
			}
			if (flag)
			{
				flag = flag && FifaEnvironment.IsFilePresent(Stadium.RadiosityFileName(this.m_CopyStadium.Id));
			}
			this.buttonCopyCrowd.Enabled = flag;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000622FB File Offset: 0x000604FB
		private void comboStadiumLights_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.EnableCopyButtons();
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00062304 File Offset: 0x00060504
		private void buttonCopyCrowd_Click(object sender, EventArgs e)
		{
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				return;
			}
			if (this.m_CopyStadium != null)
			{
				this.m_CopyStadium.CloneCrowd(this.m_CurrentStadium.Id, num);
				this.m_CopyStadium.CloneGlares(this.m_CurrentStadium.Id, num);
				this.m_CopyStadium.CloneRadiosity(this.m_CurrentStadium.Id);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0006236C File Offset: 0x0006056C
		private void buttonCopyLights_Click(object sender, EventArgs e)
		{
			int num = this.CurrentModelTimeOfDay();
			if (num < 0)
			{
				return;
			}
			if (this.m_CopyStadium != null)
			{
				this.m_CopyStadium.CloneGlares(this.m_CurrentStadium.Id, num);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000623A5 File Offset: 0x000605A5
		private void pictureHomeTeam_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentStadium.HomeTeam != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentStadium.HomeTeam);
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000623C9 File Offset: 0x000605C9
		private void radioPreviewOvercast_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumPreview();
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000623C9 File Offset: 0x000605C9
		private void radioPreviewClearDay_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumPreview();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000623C9 File Offset: 0x000605C9
		private void radioPreviewlNight_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumPreview();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000623C9 File Offset: 0x000605C9
		private void radioPreviewSunset_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadStadiumPreview();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000623D1 File Offset: 0x000605D1
		private void numericCameraHeight_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.cameraheight = (int)this.numericCameraHeight.Value;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000623F7 File Offset: 0x000605F7
		private void numericCameraZoom_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.camerazoom = (int)this.numericCameraZoom.Value;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0006241D File Offset: 0x0006061D
		private void numericAdboardType_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.adboardtype = (int)this.numericAdboardType.Value;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00062443 File Offset: 0x00060643
		private void checkIsLicensed_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.islicensed = this.checkIsLicensed.Checked;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00062464 File Offset: 0x00060664
		private void numericTechZoneHomeMinX_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadhometechzoneminx = (int)this.numericTechZoneHomeMinX.Value;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0006248A File Offset: 0x0006068A
		private void numericTechZoneHomeMaxX_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadhometechzonemaxx = (int)this.numericTechZoneHomeMaxX.Value;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000624B0 File Offset: 0x000606B0
		private void numericTechZoneHomeMinZ_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadhometechzoneminz = (int)this.numericTechZoneHomeMinZ.Value;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000624D6 File Offset: 0x000606D6
		private void numericTechZoneHomeMaxZ_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadhometechzonemaxz = (int)this.numericTechZoneHomeMaxZ.Value;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000624FC File Offset: 0x000606FC
		private void numericTechZoneAwayMinX_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadawaytechzoneminx = (int)this.numericTechZoneAwayMinX.Value;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00062522 File Offset: 0x00060722
		private void numericTechZoneAwayMaxX_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadawaytechzonemaxx = (int)this.numericTechZoneAwayMaxX.Value;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00062548 File Offset: 0x00060748
		private void numericTechZoneAwayMinZ_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadawaytechzoneminz = (int)this.numericTechZoneAwayMinZ.Value;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0006256E File Offset: 0x0006076E
		private void numericTechZoneAwayMaxZ_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStadium.stadawaytechzonemaxz = (int)this.numericTechZoneAwayMaxZ.Value;
		}

		// Token: 0x0400060B RID: 1547
		private Stadium m_CurrentStadium;

		// Token: 0x0400060C RID: 1548
		private Stadium m_CopyStadium;

		// Token: 0x0400060D RID: 1549
		private TabPage m_CurrentPage;

		// Token: 0x0400060E RID: 1550
		private bool m_IsLoaded;

		// Token: 0x0400060F RID: 1551
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000610 RID: 1552
		private string m_Undefined = "< Undefined >";

		// Token: 0x04000611 RID: 1553
		private bool m_Locked;
	}
}
