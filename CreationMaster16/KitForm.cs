using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000007 RID: 7
	public partial class KitForm : Form
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000E458 File Offset: 0x0000C658
		public KitForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.m_FontGraphics = this.pictureFont.CreateGraphics();
			this.m_FontGraphics.Clear(Color.White);
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectKit);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteKit);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneKit);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshKit);
			this.viewer2DMinikit.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMinikit);
			this.viewer2DMinikit.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMinikit);
			this.viewer2DMinikit.ButtonStripVisible = true;
			this.viewer2DMinikit.RemoveButton = true;
			this.viewer2DMinikit.FullSizeButton = true;
			this.multiViewer2DKit.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3Kit);
			this.multiViewer2DKit.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3Kit);
			this.multiViewer2DKit.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveBitmapsKit);
			this.multiViewer2DKit.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3Kit);
			this.multiViewer2DKit.FullSizeButton = true;
			this.multiViewer2DJerseyNumbers.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3JerseyNumbers);
			this.multiViewer2DJerseyNumbers.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3JerseyNumbers);
			this.multiViewer2DJerseyNumbers.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveBitmapsJerseyNumbers);
			this.multiViewer2DJerseyNumbers.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3JerseyNumbers);
			this.multiViewer2DJerseyNumbers.ShowDeleteButton = true;
			this.multiViewer2DShortsNumbers.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3ShortsNumbers);
			this.multiViewer2DShortsNumbers.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3ShortsNumbers);
			this.multiViewer2DShortsNumbers.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveBitmapsShortsNumbers);
			this.multiViewer2DShortsNumbers.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3ShortsNumbers);
			this.multiViewer2DShortsNumbers.ShowDeleteButton = true;
			for (int i = 0; i < 32; i++)
			{
				this.m_CopyPosition[i] = 0f;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		private FontFamily LoadFontFamily(string fileName, out PrivateFontCollection _myFonts)
		{
			_myFonts = new PrivateFontCollection();
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			IntPtr intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
			_myFonts.AddMemoryFont(intPtr, array.Length);
			return _myFonts.Families[0];
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000E722 File Offset: 0x0000C922
		public Kit RefreshKit(object sender, object obj)
		{
			this.Preset();
			this.ReloadKit(this.m_CurrentKit);
			return this.m_CurrentKit;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000E73C File Offset: 0x0000C93C
		public void Preset()
		{
			Kit.Prepare3DModels();
			this.m_NewKitCreator.SetTeams(FifaEnvironment.Teams);
			this.m_NewKitCreator.KitList = FifaEnvironment.Kits;
			Table table = FifaEnvironment.FifaDb.Table[TI.teamkits];
			this.numericShortsNumberFont.Maximum = table.TableDescriptor.MaxValues[FI.teamkits_shortsnumberfonttype];
			this.numericJerseyNumberFont.Maximum = table.TableDescriptor.MaxValues[FI.teamkits_numberfonttype];
			this.numericNameFont.Maximum = table.TableDescriptor.MaxValues[FI.teamkits_jerseynamefonttype];
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Teams,
				FifaEnvironment.Leagues,
				FifaEnvironment.Countries
			};
			this.pickUpControl.FilterValues = array;
			this.teamListBindingSource.DataSource = FifaEnvironment.Teams;
			this.comboTeam.DataSource = this.teamListBindingSource;
			this.pickUpControl.ObjectList = FifaEnvironment.Kits;
			this.checkIsFitting.Visible = FifaEnvironment.Year > 14;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000E858 File Offset: 0x0000CA58
		private Kit SelectKit(object sender, object obj)
		{
			Kit kit = (Kit)obj;
			this.LoadKit(kit);
			return kit;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000E874 File Offset: 0x0000CA74
		private Kit CloneKit(object sender, object obj)
		{
			this.m_NewKitCreator.SetTeams(FifaEnvironment.Teams);
			this.m_NewKitCreator.SourceKit = this.m_CurrentKit;
			DialogResult dialogResult = this.m_NewKitCreator.ShowDialog();
			if (this.m_NewKitCreator.NewKit == null)
			{
				if (dialogResult == DialogResult.OK)
				{
					FifaEnvironment.UserMessages.ShowMessage(5060, this.m_NewKitCreator.NewId);
				}
				return null;
			}
			((Kit)obj).CloneTextures(this.m_NewKitCreator.NewKit);
			return this.m_NewKitCreator.NewKit;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E900 File Offset: 0x0000CB00
		private Kit DeleteKit(object sender, object obj)
		{
			Kit kit = (Kit)obj;
			Team team = this.m_CurrentKit.Team;
			if (team != null)
			{
				team.m_KitList.Remove(kit);
			}
			FifaEnvironment.Kits.DeleteKit(kit);
			this.m_CurrentKit = null;
			return null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000E944 File Offset: 0x0000CB44
		public void LoadKit(Kit kit)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentKit == kit)
			{
				return;
			}
			this.m_UpdatingLock = true;
			this.m_CurrentKit = kit;
			this.kitBindingSource.DataSource = this.m_CurrentKit;
			if (this.multiViewer2DKit.buttonShow.Checked)
			{
				this.multiViewer2DKit.Bitmaps = this.m_CurrentKit.GetKitTextures();
			}
			this.multiViewer2DJerseyNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor);
			this.multiViewer2DShortsNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor);
			this.viewer2DMinikit.CurrentBitmap = this.m_CurrentKit.GetMiniKit();
			this.pictureJerseyNumberColor.BackColor = KitForm.c_ColorPalette[this.m_CurrentKit.jerseyNumberColor];
			this.pictureShortsNumberColor.BackColor = KitForm.c_ColorPalette[this.m_CurrentKit.shortsNumberColor];
			this.labelCollarImage.ImageIndex = kit.jerseyCollar;
			this.LoadPositions();
			this.Show3DKit();
			this.ShowFont();
			this.m_UpdatingLock = false;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000EA78 File Offset: 0x0000CC78
		public void LoadPositions()
		{
			this.m_PositionsLock = true;
			if (this.m_CurrentKit.Positions == null)
			{
				this.EnablePositions(false);
				return;
			}
			if (this.buttonBackName.Checked)
			{
				this.VerifyAndLoadPositions(12);
			}
			else if (this.buttonBackNumber.Checked)
			{
				this.VerifyAndLoadPositions(4);
			}
			else if (this.buttonNameCurvature.Checked)
			{
				this.numericLeft.Value = (decimal)this.m_CurrentKit.Positions[17];
				this.numericTop.Value = (decimal)this.m_CurrentKit.Positions[21];
				this.numericRight.Value = 0m;
				this.numericBottom.Value = 0m;
				this.EnablePositions(true);
			}
			else if (this.buttonFrontNumber.Checked)
			{
				this.VerifyAndLoadPositions(8);
			}
			else if (this.buttonJerseyBadge.Checked)
			{
				this.VerifyAndLoadPositions(0);
			}
			else if (this.buttonShortsBadge.Checked)
			{
				this.VerifyAndLoadPositions(24);
			}
			else if (this.buttonShortsNumber.Checked)
			{
				this.VerifyAndLoadPositions(28);
			}
			else
			{
				this.EnablePositions(false);
			}
			this.m_PositionsLock = false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		public void VerifyAndLoadPositions(int startingIndex)
		{
			if (this.m_CurrentKit.Positions[startingIndex] < 0f)
			{
				this.m_CurrentKit.Positions[startingIndex] = 0f;
			}
			if (this.m_CurrentKit.Positions[startingIndex] > 1f)
			{
				this.m_CurrentKit.Positions[startingIndex] = 1f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 1] < 0f)
			{
				this.m_CurrentKit.Positions[startingIndex + 1] = 0f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 1] > 1f)
			{
				this.m_CurrentKit.Positions[startingIndex + 1] = 1f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 2] < 0f)
			{
				this.m_CurrentKit.Positions[startingIndex + 2] = 0f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 2] > 1f)
			{
				this.m_CurrentKit.Positions[startingIndex + 2] = 1f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 3] < 0f)
			{
				this.m_CurrentKit.Positions[startingIndex + 3] = 0f;
			}
			if (this.m_CurrentKit.Positions[startingIndex + 3] > 1f)
			{
				this.m_CurrentKit.Positions[startingIndex + 3] = 1f;
			}
			this.numericLeft.Value = (decimal)this.m_CurrentKit.Positions[startingIndex];
			this.numericTop.Value = (decimal)this.m_CurrentKit.Positions[startingIndex + 1];
			this.numericRight.Value = (decimal)this.m_CurrentKit.Positions[startingIndex + 2];
			this.numericBottom.Value = (decimal)this.m_CurrentKit.Positions[startingIndex + 3];
			this.EnablePositions(true);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000ED88 File Offset: 0x0000CF88
		public void ChangePositions()
		{
			if (this.m_PositionsLock)
			{
				return;
			}
			if (!this.multiViewer2DKit.buttonSave.Enabled)
			{
				this.multiViewer2DKit.buttonSave.Enabled = true;
			}
			if (this.buttonBackName.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[12];
					this.m_CurrentKit.Positions[12] += num;
					this.m_CurrentKit.Positions[14] += num;
					num = (float)this.numericTop.Value - this.m_CurrentKit.Positions[13];
					this.m_CurrentKit.Positions[13] += num;
					this.m_CurrentKit.Positions[15] += num;
				}
				else
				{
					this.m_CurrentKit.Positions[12] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[13] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[14] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[15] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonBackNumber.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num2 = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[4];
					this.m_CurrentKit.Positions[4] += num2;
					this.m_CurrentKit.Positions[6] += num2;
					num2 = (float)this.numericTop.Value - this.m_CurrentKit.Positions[5];
					this.m_CurrentKit.Positions[5] += num2;
					this.m_CurrentKit.Positions[7] += num2;
				}
				else
				{
					this.m_CurrentKit.Positions[4] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[5] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[6] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[7] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonNameCurvature.Checked)
			{
				this.m_CurrentKit.Positions[17] = (float)this.numericLeft.Value;
				this.m_CurrentKit.Positions[21] = (float)this.numericTop.Value;
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonFrontNumber.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num3 = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[8];
					this.m_CurrentKit.Positions[8] += num3;
					this.m_CurrentKit.Positions[10] += num3;
					num3 = (float)this.numericTop.Value - this.m_CurrentKit.Positions[9];
					this.m_CurrentKit.Positions[9] += num3;
					this.m_CurrentKit.Positions[11] += num3;
				}
				else
				{
					this.m_CurrentKit.Positions[8] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[9] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[10] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[11] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonJerseyBadge.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num4 = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[0];
					this.m_CurrentKit.Positions[0] += num4;
					this.m_CurrentKit.Positions[2] += num4;
					num4 = (float)this.numericTop.Value - this.m_CurrentKit.Positions[1];
					this.m_CurrentKit.Positions[1] += num4;
					this.m_CurrentKit.Positions[3] += num4;
				}
				else
				{
					this.m_CurrentKit.Positions[0] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[1] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[2] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[3] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonShortsBadge.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num5 = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[24];
					this.m_CurrentKit.Positions[24] += num5;
					this.m_CurrentKit.Positions[26] += num5;
					num5 = (float)this.numericTop.Value - this.m_CurrentKit.Positions[25];
					this.m_CurrentKit.Positions[25] += num5;
					this.m_CurrentKit.Positions[27] += num5;
				}
				else
				{
					this.m_CurrentKit.Positions[24] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[25] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[26] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[27] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
				return;
			}
			if (this.buttonShortsNumber.Checked)
			{
				if (this.checkLink.Checked)
				{
					float num6 = (float)this.numericLeft.Value - this.m_CurrentKit.Positions[28];
					this.m_CurrentKit.Positions[28] += num6;
					this.m_CurrentKit.Positions[30] += num6;
					num6 = (float)this.numericTop.Value - this.m_CurrentKit.Positions[29];
					this.m_CurrentKit.Positions[29] += num6;
					this.m_CurrentKit.Positions[31] += num6;
				}
				else
				{
					this.m_CurrentKit.Positions[28] = (float)this.numericLeft.Value;
					this.m_CurrentKit.Positions[29] = (float)this.numericTop.Value;
					this.m_CurrentKit.Positions[30] = (float)this.numericRight.Value;
					this.m_CurrentKit.Positions[31] = (float)this.numericBottom.Value;
				}
				this.CheckPositions();
				this.LoadPositions();
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public void CheckPositions()
		{
			for (int i = 0; i < 32; i++)
			{
				if ((double)this.m_CurrentKit.Positions[i] < 0.0)
				{
					this.m_CurrentKit.Positions[i] = 0f;
				}
				if ((double)this.m_CurrentKit.Positions[i] > 1.0)
				{
					this.m_CurrentKit.Positions[i] = 1f;
				}
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000F634 File Offset: 0x0000D834
		private void EnablePositions(bool enabled)
		{
			if (!enabled)
			{
				this.numericLeft.Enabled = enabled;
				this.numericTop.Enabled = enabled;
				this.numericRight.Enabled = enabled;
				this.numericBottom.Enabled = enabled;
				return;
			}
			if (this.checkLink.Checked || this.buttonNameCurvature.Checked)
			{
				this.numericLeft.Enabled = enabled;
				this.numericTop.Enabled = enabled;
				this.numericRight.Enabled = !enabled;
				this.numericBottom.Enabled = !enabled;
				return;
			}
			this.numericLeft.Enabled = enabled;
			this.numericTop.Enabled = enabled;
			this.numericRight.Enabled = enabled;
			this.numericBottom.Enabled = enabled;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000F6F6 File Offset: 0x0000D8F6
		public void ReloadKit(Kit kit)
		{
			this.m_CurrentKit = null;
			this.LoadKit(kit);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000F706 File Offset: 0x0000D906
		private void KitForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000F715 File Offset: 0x0000D915
		private bool ImportImageMinikit(object sender, Bitmap bitmap)
		{
			return this.m_CurrentKit.SetMiniKit(bitmap);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000F723 File Offset: 0x0000D923
		private bool DeleteMinikit(object sender)
		{
			return this.m_CurrentKit.DeleteMiniKit();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000F730 File Offset: 0x0000D930
		private bool SaveBitmapsKit(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentKit.SetKitTextures(bitmaps);
			this.ReloadKit(this.m_CurrentKit);
			return flag;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000F74A File Offset: 0x0000D94A
		private bool ExportRx3Kit(object sender, string exportDir)
		{
			return this.m_CurrentKit.ExportKitTextures(exportDir);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000F758 File Offset: 0x0000D958
		private bool ImportRx3Kit(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentKit.ImportKitTextures(rx3FileName);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000F775 File Offset: 0x0000D975
		private bool DeleteRx3Kit(object sender)
		{
			bool flag = this.m_CurrentKit.DeleteKitTextures();
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000F791 File Offset: 0x0000D991
		private bool SaveBitmapsJerseyNumbers(object sender, Bitmap[] bitmaps)
		{
			bool flag = NumberFont.SetNumberFont(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor, bitmaps);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000F7BE File Offset: 0x0000D9BE
		private bool ExportRx3JerseyNumbers(object sender, string exportDir)
		{
			return NumberFont.Export(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor, exportDir);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		private bool ImportRx3JerseyNumbers(object sender, string rx3FileName)
		{
			bool flag = NumberFont.Import(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor, rx3FileName);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000F809 File Offset: 0x0000DA09
		private bool DeleteRx3JerseyNumbers(object sender)
		{
			bool flag = NumberFont.Delete(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000F835 File Offset: 0x0000DA35
		private bool SaveBitmapsShortsNumbers(object sender, Bitmap[] bitmaps)
		{
			bool flag = NumberFont.SetNumberFont(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor, bitmaps);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000F862 File Offset: 0x0000DA62
		private bool ExportRx3ShortsNumbers(object sender, string exportDir)
		{
			return NumberFont.Export(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor, exportDir);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000F880 File Offset: 0x0000DA80
		private bool ImportRx3ShortsNumbers(object sender, string rx3FileName)
		{
			bool flag = NumberFont.Import(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor, rx3FileName);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000F8AD File Offset: 0x0000DAAD
		private bool DeleteRx3ShortsNumbers(object sender)
		{
			bool flag = NumberFont.Delete(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor);
			if (flag)
			{
				this.ReloadKit(this.m_CurrentKit);
			}
			return flag;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000F8DC File Offset: 0x0000DADC
		public void Show3DKit()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap[] kitTextures = this.m_CurrentKit.GetKitTextures();
			if (kitTextures == null)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			Bitmap bitmap = null;
			Bitmap bitmap2 = null;
			if (kitTextures != null)
			{
				bitmap = kitTextures[1];
				bitmap2 = kitTextures[3];
			}
			Rectangle rectangle = new Rectangle((int)((float)bitmap2.Width * this.m_CurrentKit.Positions[24]), (int)((float)bitmap2.Height * this.m_CurrentKit.Positions[25]), (int)((float)bitmap2.Width * (this.m_CurrentKit.Positions[26] - this.m_CurrentKit.Positions[24])), (int)((float)bitmap2.Height * (this.m_CurrentKit.Positions[27] - this.m_CurrentKit.Positions[25])));
			if (rectangle.Width > 0 && rectangle.Height > 0)
			{
				bitmap2 = GraphicUtil.Overlap(bitmap2, kitTextures[0], rectangle);
			}
			Rectangle rectangle2 = new Rectangle((int)((float)bitmap.Width * this.m_CurrentKit.Positions[0]), (int)((float)bitmap.Height * this.m_CurrentKit.Positions[1]), (int)((float)bitmap.Width * (this.m_CurrentKit.Positions[2] - this.m_CurrentKit.Positions[0])), (int)((float)bitmap.Height * (this.m_CurrentKit.Positions[3] - this.m_CurrentKit.Positions[1])));
			if (rectangle2.Width > 0 && rectangle2.Height > 0)
			{
				bitmap = GraphicUtil.Overlap(bitmap, kitTextures[0], rectangle2);
			}
			if (this.buttonShowNumbers3D.Checked && this.m_CurrentKit.jerseyBackName)
			{
				Bitmap bitmap3 = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\PlayerName.png");
				if (bitmap3 != null)
				{
					bitmap3 = GraphicUtil.ColorizeWhite(bitmap3, this.pictureNameColor.BackColor);
					Rectangle rectangle3 = new Rectangle((int)((float)bitmap.Width * this.m_CurrentKit.Positions[14]), (int)((float)bitmap.Height * this.m_CurrentKit.Positions[15]), (int)((float)bitmap.Width * (this.m_CurrentKit.Positions[12] - this.m_CurrentKit.Positions[14])), (int)((float)bitmap.Height * (this.m_CurrentKit.Positions[13] - this.m_CurrentKit.Positions[15])));
					if (rectangle3.Width > 0 && rectangle3.Height > 0)
					{
						bitmap = GraphicUtil.Overlap(bitmap, bitmap3, rectangle3);
					}
				}
			}
			if (this.buttonShowNumbers3D.Checked)
			{
				if (this.multiViewer2DShortsNumbers.GetCurrentBitmap() != null && this.m_CurrentKit.shortsNumber)
				{
					int num = (int)((float)bitmap2.Width * this.m_CurrentKit.Positions[28]);
					int num2 = (int)((float)bitmap2.Height * this.m_CurrentKit.Positions[29]);
					int num3 = (int)((float)bitmap2.Width * (this.m_CurrentKit.Positions[30] - this.m_CurrentKit.Positions[28]));
					int num4 = (int)((float)bitmap2.Height * (this.m_CurrentKit.Positions[31] - this.m_CurrentKit.Positions[29]));
					Bitmap bitmap4 = (Bitmap)this.multiViewer2DShortsNumbers.GetCurrentBitmap().Clone();
					rectangle = new Rectangle(num, num2, num3 / 2, num4);
					if (bitmap4 != null && rectangle.Width > 0 && rectangle.Height > 0)
					{
						bitmap2 = GraphicUtil.Overlap(bitmap2, bitmap4, rectangle);
					}
					rectangle = new Rectangle(num + num3 / 2, num2, num3 / 2, num4);
					if (bitmap4 != null && rectangle.Width > 0 && rectangle.Height > 0)
					{
						bitmap2 = GraphicUtil.Overlap(bitmap2, bitmap4, rectangle);
					}
				}
				if (this.multiViewer2DJerseyNumbers.GetCurrentBitmap() != null)
				{
					int num5 = (int)((float)bitmap.Width * this.m_CurrentKit.Positions[8]);
					int num6 = (int)((float)bitmap.Height * this.m_CurrentKit.Positions[9]);
					int num7 = (int)((float)bitmap.Width * (this.m_CurrentKit.Positions[10] - this.m_CurrentKit.Positions[8]));
					int num8 = (int)((float)bitmap.Height * (this.m_CurrentKit.Positions[11] - this.m_CurrentKit.Positions[9]));
					Bitmap bitmap4 = (Bitmap)this.multiViewer2DJerseyNumbers.GetCurrentBitmap().Clone();
					if (this.m_CurrentKit.jerseyFrontNumber)
					{
						rectangle2 = new Rectangle(num5, num6, num7 / 2, num8);
						if (bitmap4 != null && rectangle2.Width > 0 && rectangle2.Height > 0)
						{
							bitmap = GraphicUtil.Overlap(bitmap, bitmap4, rectangle2);
						}
						rectangle2 = new Rectangle(num5 + num7 / 2, num6, num7 / 2, num8);
						if (bitmap4 != null && rectangle2.Width > 0 && rectangle2.Height > 0)
						{
							bitmap = GraphicUtil.Overlap(bitmap, bitmap4, rectangle2);
						}
					}
					num5 = (int)((float)bitmap.Width * this.m_CurrentKit.Positions[6]);
					num6 = (int)((float)bitmap.Height * this.m_CurrentKit.Positions[7]);
					num7 = (int)((float)bitmap.Width * (this.m_CurrentKit.Positions[4] - this.m_CurrentKit.Positions[6]));
					num8 = (int)((float)bitmap.Height * (this.m_CurrentKit.Positions[5] - this.m_CurrentKit.Positions[7]));
					bitmap4.RotateFlip(RotateFlipType.Rotate180FlipNone);
					rectangle2 = new Rectangle(num5, num6, num7 / 2, num8);
					if (bitmap4 != null && rectangle2.Width > 0 && rectangle2.Height > 0)
					{
						bitmap = GraphicUtil.Overlap(bitmap, bitmap4, rectangle2);
					}
					rectangle2 = new Rectangle(num5 + num7 / 2, num6, num7 / 2, num8);
					if (bitmap4 != null && rectangle2.Width > 0 && rectangle2.Height > 0)
					{
						bitmap = GraphicUtil.Overlap(bitmap, bitmap4, rectangle2);
					}
				}
			}
			this.viewer3D.Clean(3);
			bitmap = GraphicUtil.EmbossBitmap(bitmap, Kit.s_JerseyWrinkle);
			if (Kit.s_JerseyModel3D[this.m_CurrentKit.jerseyCollar] != null)
			{
				Kit.s_JerseyModel3D[this.m_CurrentKit.jerseyCollar].TextureBitmap = bitmap;
				this.viewer3D.SetMesh(0, Kit.s_JerseyModel3D[this.m_CurrentKit.jerseyCollar]);
			}
			bitmap2 = GraphicUtil.EmbossBitmap(bitmap2, Kit.s_ShortsWrinkle);
			if (Kit.s_ShortsModel3D != null)
			{
				Kit.s_ShortsModel3D.TextureBitmap = bitmap2;
				this.viewer3D.SetMesh(1, Kit.s_ShortsModel3D);
			}
			if (Kit.s_SocksModel3D != null)
			{
				Kit.s_SocksModel3D.TextureBitmap = bitmap2;
				this.viewer3D.SetMesh(2, Kit.s_SocksModel3D);
			}
			this.viewer3D.Render();
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000FF71 File Offset: 0x0000E171
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DKit();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000FF79 File Offset: 0x0000E179
		private void numericCollar_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentKit.jerseyCollar = (int)this.numericCollar.Value;
			this.labelCollarImage.ImageIndex = this.m_CurrentKit.jerseyCollar;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000FFAC File Offset: 0x0000E1AC
		private void pictureNameColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureNameColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureNameColor.BackColor = this.colorDialog.Color;
			this.m_CurrentKit.JerseyNameColor = this.colorDialog.Color;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00010008 File Offset: 0x0000E208
		private void pictureJerseyNumberColor_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(KitForm.c_ColorPalette, this.m_CurrentKit.jerseyNumberColor);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentKit.jerseyNumberColor = colorSelector.SelectedIndex;
				this.pictureJerseyNumberColor.BackColor = colorSelector.SelectedColor;
				if (!this.m_UpdatingLock)
				{
					this.m_UpdatingLock = true;
					this.multiViewer2DJerseyNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor);
					this.m_UpdatingLock = false;
				}
			}
			colorSelector.Dispose();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00010098 File Offset: 0x0000E298
		private void pictureShortsNumberColor_Click(object sender, EventArgs e)
		{
			ColorSelector colorSelector = new ColorSelector(KitForm.c_ColorPalette, this.m_CurrentKit.shortsNumberColor);
			if (colorSelector.ShowDialog() == DialogResult.OK)
			{
				this.m_CurrentKit.shortsNumberColor = colorSelector.SelectedIndex;
				this.pictureShortsNumberColor.BackColor = colorSelector.SelectedColor;
				if (!this.m_UpdatingLock)
				{
					this.m_UpdatingLock = true;
					this.multiViewer2DShortsNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor);
					this.m_UpdatingLock = false;
				}
			}
			colorSelector.Dispose();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00010128 File Offset: 0x0000E328
		private void pictureTeamPrimColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamPrimColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamPrimColor.BackColor = this.colorDialog.Color;
			this.m_CurrentKit.TeamColor1 = this.colorDialog.Color;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00010184 File Offset: 0x0000E384
		private void pictureTeamSecColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamSecColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamSecColor.BackColor = this.colorDialog.Color;
			this.m_CurrentKit.TeamColor2 = this.colorDialog.Color;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000101E0 File Offset: 0x0000E3E0
		private void pictureTeamTerColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamTerColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamTerColor.BackColor = this.colorDialog.Color;
			this.m_CurrentKit.TeamColor3 = this.colorDialog.Color;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001023C File Offset: 0x0000E43C
		private void numericJerseyNumberFont_ValueChanged(object sender, EventArgs e)
		{
			if (!this.m_UpdatingLock)
			{
				this.m_UpdatingLock = true;
				this.m_CurrentKit.jerseyNumberFont = (int)this.numericJerseyNumberFont.Value;
				this.multiViewer2DJerseyNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.jerseyNumberFont, this.m_CurrentKit.jerseyNumberColor);
				this.m_UpdatingLock = false;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000102A0 File Offset: 0x0000E4A0
		private void numericShortsNumberFont_ValueChanged(object sender, EventArgs e)
		{
			if (!this.m_UpdatingLock)
			{
				this.m_UpdatingLock = true;
				this.m_CurrentKit.shortsNumberFont = (int)this.numericShortsNumberFont.Value;
				this.multiViewer2DShortsNumbers.Bitmaps = NumberFont.GetNumberFont(this.m_CurrentKit.shortsNumberFont, this.m_CurrentKit.shortsNumberColor);
				this.m_UpdatingLock = false;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00010304 File Offset: 0x0000E504
		private void buttonCamera_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = this.viewer3D.Photo();
			int num = bitmap.Height * 3 / 4;
			int width = bitmap.Width;
			int num2 = ((width < num * 6 / 6) ? width : (num * 6 / 6));
			int num3 = (width - num2) / 2;
			Rectangle rectangle = new Rectangle(num3, 0, num2, num);
			Rectangle rectangle2 = new Rectangle(22, 22, 212, 212);
			Bitmap bitmap2 = GraphicUtil.MakeAutoTransparent(bitmap);
			Bitmap bitmap3 = new Bitmap(256, 256, PixelFormat.Format32bppArgb);
			GraphicUtil.RemapRectangle(bitmap2, rectangle, bitmap3, rectangle2);
			this.m_CurrentKit.SetMiniKit(bitmap3);
			this.viewer2DMinikit.CurrentBitmap = bitmap3;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000103A6 File Offset: 0x0000E5A6
		private void radioPosition_Click(object sender, EventArgs e)
		{
			if (((RadioButton)sender).Checked)
			{
				this.LoadPositions();
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000103BB File Offset: 0x0000E5BB
		private void numericPositions_ValueChanged(object sender, EventArgs e)
		{
			this.ChangePositions();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000103C3 File Offset: 0x0000E5C3
		private void checkLink_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadPositions();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000103CC File Offset: 0x0000E5CC
		private void buttonPositions_Click(object sender, EventArgs e)
		{
			ToolStripButton toolStripButton = (ToolStripButton)sender;
			if (!toolStripButton.Checked)
			{
				return;
			}
			if (this.buttonBackName.Checked && this.buttonBackName != toolStripButton)
			{
				this.buttonBackName.Checked = false;
			}
			if (this.buttonBackNumber.Checked && this.buttonBackNumber != toolStripButton)
			{
				this.buttonBackNumber.Checked = false;
			}
			if (this.buttonFrontNumber.Checked && this.buttonFrontNumber != toolStripButton)
			{
				this.buttonFrontNumber.Checked = false;
			}
			if (this.buttonJerseyBadge.Checked && this.buttonJerseyBadge != toolStripButton)
			{
				this.buttonJerseyBadge.Checked = false;
			}
			if (this.buttonNameCurvature.Checked && this.buttonNameCurvature != toolStripButton)
			{
				this.buttonNameCurvature.Checked = false;
			}
			if (this.buttonShortsBadge.Checked && this.buttonShortsBadge != toolStripButton)
			{
				this.buttonShortsBadge.Checked = false;
			}
			if (this.buttonShortsNumber.Checked && this.buttonShortsNumber != toolStripButton)
			{
				this.buttonShortsNumber.Checked = false;
			}
			this.LoadPositions();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonSavePositions_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000FF71 File Offset: 0x0000E171
		private void buttonRefresh3D_Click(object sender, EventArgs e)
		{
			this.Show3DKit();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000FF71 File Offset: 0x0000E171
		private void buttonShowNumbers3D_Click(object sender, EventArgs e)
		{
			this.Show3DKit();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000104E0 File Offset: 0x0000E6E0
		private void ShowFont()
		{
			int num = (int)this.numericNameFont.Value;
			string text = FifaEnvironment.ExportFolder + "\\" + NameFont.NameFontFileName(num);
			Font font = null;
			if (!NameFont.Export(num, FifaEnvironment.ExportFolder))
			{
				this.m_FontGraphics.Clear(Color.White);
				return;
			}
			FontFamily fontFamily = this.LoadFontFamily(text, out this.m_FontCollection);
			if (fontFamily.IsStyleAvailable(FontStyle.Regular))
			{
				font = new Font(fontFamily, 15f, FontStyle.Regular);
			}
			else if (fontFamily.IsStyleAvailable(FontStyle.Bold))
			{
				font = new Font(fontFamily, 15f, FontStyle.Bold);
			}
			else if (fontFamily.IsStyleAvailable(FontStyle.Italic))
			{
				font = new Font(fontFamily, 15f, FontStyle.Italic);
			}
			else if (fontFamily.IsStyleAvailable(FontStyle.Strikeout))
			{
				font = new Font(fontFamily, 15f, FontStyle.Strikeout);
			}
			else if (fontFamily.IsStyleAvailable(FontStyle.Underline))
			{
				font = new Font(fontFamily, 15f, FontStyle.Underline);
			}
			string text2 = fontFamily.Name + "\r\n";
			text2 += "abcdefghijklmnopqrstuvwxyz\r\nABCDEFGHIJKLMNOPQRSTUVWXYZ";
			if (font != null)
			{
				this.m_FontGraphics.Clear(Color.White);
				this.m_FontGraphics.DrawString(text2, font, this.m_FontBrush, 0f, 0f);
				return;
			}
			this.m_FontGraphics.Clear(Color.White);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00010630 File Offset: 0x0000E830
		private void buttonPreviewNameFont_Click(object sender, EventArgs e)
		{
			int num = (int)this.numericNameFont.Value;
			string text = FifaEnvironment.ExportFolder + "\\" + NameFont.NameFontFileName(num);
			bool flag = true;
			if (!FifaUtil.IsFileLocked(text))
			{
				flag = NameFont.Export(num, FifaEnvironment.ExportFolder);
			}
			if (flag && text != null)
			{
				this.processFontView.StartInfo.WorkingDirectory = FifaEnvironment.LaunchDir;
				this.processFontView.StartInfo.FileName = "fontview";
				this.processFontView.StartInfo.CreateNoWindow = true;
				this.processFontView.StartInfo.UseShellExecute = false;
				this.processFontView.StartInfo.Arguments = text;
				this.processFontView.StartInfo.RedirectStandardOutput = false;
				this.processFontView.Start();
				this.processFontView.WaitForExit();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0001070C File Offset: 0x0000E90C
		private void buttonImportNameFont_Click(object sender, EventArgs e)
		{
			int num = (int)this.numericNameFont.Value;
			string text = FifaEnvironment.BrowseAndCheckTtf(ref this.m_FontnameCurrentFolder);
			if (text != null)
			{
				NameFont.Import(num, text);
				this.ShowFont();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00010747 File Offset: 0x0000E947
		private void buttonExportNameFont_Click(object sender, EventArgs e)
		{
			NameFont.Export((int)this.numericNameFont.Value, FifaEnvironment.ExportFolder);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00010764 File Offset: 0x0000E964
		private void buttonDeleteNameFont_Click(object sender, EventArgs e)
		{
			NameFont.Delete((int)this.numericNameFont.Value);
			this.ShowFont();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00010782 File Offset: 0x0000E982
		private void checkFrontNumber_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_UpdatingLock)
			{
				return;
			}
			this.m_CurrentKit.jerseyFrontNumber = this.checkFrontNumber.Checked;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000107A3 File Offset: 0x0000E9A3
		private void checkShortsNumber_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_UpdatingLock)
			{
				return;
			}
			this.m_CurrentKit.shortsNumber = this.checkShortsNumber.Checked;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000107C4 File Offset: 0x0000E9C4
		private void checkHasBackname_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_UpdatingLock)
			{
				return;
			}
			this.m_CurrentKit.jerseyBackName = this.checkHasBackname.Checked;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000107E8 File Offset: 0x0000E9E8
		private void buttonCopyPositions_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 32; i++)
			{
				this.m_CopyPosition[i] = this.m_CurrentKit.Positions[i];
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00010818 File Offset: 0x0000EA18
		private void buttonPastePositions_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 32; i++)
			{
				this.m_CurrentKit.Positions[i] = this.m_CopyPosition[i];
			}
			this.LoadPositions();
			if (!this.multiViewer2DKit.buttonSave.Enabled)
			{
				this.multiViewer2DKit.buttonSave.Enabled = true;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00010870 File Offset: 0x0000EA70
		private void labelTeam_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentKit.Team != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentKit.Team);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00010894 File Offset: 0x0000EA94
		private void buttonShowFont_Click(object sender, EventArgs e)
		{
			this.fontDialog.ShowDialog();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000108A4 File Offset: 0x0000EAA4
		private void numericNameFont_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_UpdatingLock)
			{
				return;
			}
			this.ShowFont();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000108B8 File Offset: 0x0000EAB8
		private void buttonExportAllKits_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = FifaEnvironment.ExportFolder;
			folderBrowserDialog.Description = "Select the export folder";
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				folderBrowserDialog.Dispose();
				return;
			}
			string selectedPath = folderBrowserDialog.SelectedPath;
			folderBrowserDialog.Dispose();
			int num = 1;
			for (int i = 0; i < this.pickUpControl.combo.Items.Count; i++)
			{
				Kit kit = (Kit)this.pickUpControl.combo.Items[i];
				if (num > 0)
				{
					Bitmap[] kitTextures = kit.GetKitTextures();
					if (kitTextures != null)
					{
						string text = selectedPath + "\\j_" + num.ToString("0000") + ".png";
						string text2 = selectedPath + "\\s_" + num.ToString("0000") + ".png";
						kitTextures[1].Save(text);
						kitTextures[3].Save(text2);
						kit.DisposeKitTextures();
						for (int j = 0; j < kitTextures.Length; j++)
						{
							kitTextures[j].Dispose();
						}
					}
				}
				num++;
				if (num % 100 == 0)
				{
					GC.Collect();
				}
			}
		}

		// Token: 0x040000E7 RID: 231
		private PrivateFontCollection m_FontCollection;

		// Token: 0x040000E8 RID: 232
		private Graphics m_FontGraphics;

		// Token: 0x040000E9 RID: 233
		private SolidBrush m_FontBrush = new SolidBrush(Color.Black);

		// Token: 0x040000EA RID: 234
		private Kit m_CurrentKit;

		// Token: 0x040000EB RID: 235
		private bool m_IsLoaded;

		// Token: 0x040000EC RID: 236
		private NewKitCreator m_NewKitCreator = new NewKitCreator();

		// Token: 0x040000ED RID: 237
		private string m_FontnameCurrentFolder = FifaEnvironment.ExportFolder;

		// Token: 0x040000EE RID: 238
		private float[] m_CopyPosition = new float[32];

		// Token: 0x040000EF RID: 239
		private bool m_UpdatingLock;

		// Token: 0x040000F0 RID: 240
		private bool m_PositionsLock;

		// Token: 0x040000F1 RID: 241
		private static Color[] c_ColorPalette = new Color[]
		{
			Color.Transparent,
			Color.White,
			Color.Black,
			Color.Blue,
			Color.Red,
			Color.Yellow,
			Color.Green,
			Color.Orange,
			Color.DarkViolet,
			Color.FromArgb(90, 60, 30),
			Color.Pink,
			Color.DarkRed,
			Color.LightSkyBlue,
			Color.DarkBlue,
			Color.Gray,
			Color.FromArgb(200, 200, 100),
			Color.FromArgb(160, 140, 85),
			Color.Gold,
			Color.OrangeRed,
			Color.ForestGreen
		};
	}
}
