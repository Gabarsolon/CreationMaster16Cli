using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000019 RID: 25
	public partial class ShoesForm : Form
	{
		// Token: 0x060003AA RID: 938 RVA: 0x0005F418 File Offset: 0x0005D618
		public ShoesForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectShoes);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateShoes);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteShoes);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneShoes);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshShoes);
			this.pickUpControl.combo.Sorted = false;
			this.multiViewer2DShoesColor.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3ShoesColor);
			this.multiViewer2DShoesColor.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3ShoesColor);
			this.multiViewer2DShoesColor.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveBitmapShoesColor);
			this.multiViewer2DShoesColor.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteShoesColor);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0005F52E File Offset: 0x0005D72E
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Shoes;
			this.pickUpControl.ObjectList = FifaEnvironment.Shoes;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0005F550 File Offset: 0x0005D750
		private Shoes SelectShoes(object sender, object obj)
		{
			Shoes shoes = (Shoes)obj;
			this.Refresh();
			this.LoadShoes(shoes);
			return shoes;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0005F574 File Offset: 0x0005D774
		private Shoes CreateShoes(object sender, object obj)
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
			return (Shoes)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0005F5CC File Offset: 0x0005D7CC
		private Shoes DeleteShoes(object sender, object obj)
		{
			Shoes shoes = (Shoes)obj;
			Shoes.DeleteShoes(shoes.Id, 0);
			FifaEnvironment.Shoes.RemoveId(shoes);
			return null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0005F5FC File Offset: 0x0005D7FC
		private Shoes CloneShoes(object sender, object obj)
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
			Shoes shoes = (Shoes)obj;
			return (Shoes)FifaEnvironment.Shoes.CloneId(shoes, this.m_NewIdCreator.NewObject);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0005F665 File Offset: 0x0005D865
		public Shoes RefreshShoes(object sender, object obj)
		{
			this.Preset();
			this.ReloadShoes(this.m_CurrentShoes);
			return this.m_CurrentShoes;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0005F680 File Offset: 0x0005D880
		private bool SaveBitmapShoesColor(object sender, Bitmap[] bitmaps)
		{
			int num = (int)this.numericShoesColor.Value;
			bool flag = Shoes.SetShoesTextures(this.m_CurrentShoes.Id, num, bitmaps);
			this.ReloadShoes(this.m_CurrentShoes);
			return flag;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0005F6BC File Offset: 0x0005D8BC
		private bool ExportRx3ShoesColor(object sender, string exportDir)
		{
			int num = (int)this.numericShoesColor.Value;
			return Shoes.ExportShoesTextures(this.m_CurrentShoes.Id, num, exportDir);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0005F6EC File Offset: 0x0005D8EC
		private bool ImportRx3ShoesColor(object sender, string rx3FileName)
		{
			int num = (int)this.numericShoesColor.Value;
			bool flag = Shoes.ImportShoesTextures(this.m_CurrentShoes.Id, num, rx3FileName);
			if (flag)
			{
				this.ReloadShoes(this.m_CurrentShoes);
			}
			return flag;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0005F72C File Offset: 0x0005D92C
		private bool DeleteShoesColor(object sender)
		{
			int num = (int)this.numericShoesColor.Value;
			bool flag = Shoes.DeleteShoesTextures(this.m_CurrentShoes.Id, num);
			if (flag)
			{
				this.ReloadShoes(this.m_CurrentShoes);
			}
			return flag;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0005F76C File Offset: 0x0005D96C
		private void LoadShoes(Shoes shoes)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentShoes == shoes)
			{
				return;
			}
			this.m_CurrentShoes = shoes;
			Bitmap[] array = new Bitmap[3];
			int num;
			if (this.m_CurrentShoes.Id == 0)
			{
				this.numericShoesColor.Enabled = true;
				num = (int)this.numericShoesColor.Value;
			}
			else
			{
				this.numericShoesColor.Enabled = false;
				this.numericShoesColor.Value = 0m;
				num = 0;
			}
			array = Shoes.GetShoesTextures(shoes.Id, num);
			this.multiViewer2DShoesColor.Bitmaps = array;
			this.textShoesName.Text = this.m_CurrentShoes.Name;
			this.textShoesType.Text = this.m_CurrentShoes.Id.ToString();
			this.checkIsAvailableInStore.Checked = this.m_CurrentShoes.IsAvailableinStore;
			this.checkShoesGender.Checked = this.m_CurrentShoes.IsGender;
			if (this.m_CurrentShoes.powid == -1)
			{
				this.textShoesShopPackage.Text = "Not in the shop";
			}
			else
			{
				this.textShoesShopPackage.Text = "Shop Package n. " + this.m_CurrentShoes.powid.ToString();
			}
			this.Show3DShoes();
			GC.Collect();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
		private void ReloadShoes(Shoes shoes)
		{
			this.m_CurrentShoes = null;
			this.LoadShoes(shoes);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		public void Show3DShoes()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			int num = (int)this.numericShoesColor.Value;
			Bitmap[] shoesTextures = Shoes.GetShoesTextures(this.m_CurrentShoes.Id, num);
			if (shoesTextures == null)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap bitmap = GraphicUtil.EmbossBitmap(shoesTextures[0], shoesTextures[1]);
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			Rx3File shoesModel = Shoes.GetShoesModel(this.m_CurrentShoes.Id);
			if (bitmap == null || shoesModel == null)
			{
				this.viewer3D.Clean(1);
				return;
			}
			Model3D model3D = new Model3D(shoesModel.Rx3IndexArrays[0], shoesModel.Rx3VertexArrays[0], bitmap);
			this.viewer3D.Clean(2);
			this.viewer3D.SetMesh(0, model3D);
			this.viewer3D.Render();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0005F98B File Offset: 0x0005DB8B
		private void ShoesForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0005F99C File Offset: 0x0005DB9C
		private void buttonExportNear3DModel_Click(object sender, EventArgs e)
		{
			string text = Shoes.ShoesModelFileName(this.m_CurrentShoes.Id);
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_ShoesCurrentFolder);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0005F9CA File Offset: 0x0005DBCA
		private void buttonRemoveNear3DModel_Click(object sender, EventArgs e)
		{
			Shoes.DeleteShoesModel(this.m_CurrentShoes.Id);
			this.ReloadShoes(this.m_CurrentShoes);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0005F9E9 File Offset: 0x0005DBE9
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DShoes();
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0005F9F1 File Offset: 0x0005DBF1
		private void numericShoesColor_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentShoes.Id == 0)
			{
				this.ReloadShoes(this.m_CurrentShoes);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		private void buttonExport3DModel_Click(object sender, EventArgs e)
		{
			string text = Shoes.ShoesModelFileName(this.m_CurrentShoes.Id);
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_ShoesCurrentFolder);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0005FA3C File Offset: 0x0005DC3C
		private void buttonImport3DModel_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_ShoesCurrentFolder, "Open 3D Shoes Model file", "3D shoes model files (*.rx3)|shoe_*.rx3");
			if (text == null)
			{
				return;
			}
			Shoes.SetShoesModel(this.m_CurrentShoes.Id, text);
			this.ReloadShoes(this.m_CurrentShoes);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0005F9CA File Offset: 0x0005DBCA
		private void buttonRemove3DModel_Click(object sender, EventArgs e)
		{
			Shoes.DeleteShoesModel(this.m_CurrentShoes.Id);
			this.ReloadShoes(this.m_CurrentShoes);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0005FA81 File Offset: 0x0005DC81
		private void textShoesName_TextChanged(object sender, EventArgs e)
		{
			if (this.textShoesName.Text != this.m_CurrentShoes.Name)
			{
				this.m_CurrentShoes.Name = this.textShoesName.Text;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0005FAB6 File Offset: 0x0005DCB6
		private void checkIsAvailableInStore_CheckedChanged(object sender, EventArgs e)
		{
			this.m_CurrentShoes.IsAvailableinStore = this.checkIsAvailableInStore.Checked;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0005FACE File Offset: 0x0005DCCE
		private void checkShoesGender_CheckedChanged(object sender, EventArgs e)
		{
			this.m_CurrentShoes.IsGender = this.checkShoesGender.Checked;
		}

		// Token: 0x040005E8 RID: 1512
		private Shoes m_CurrentShoes;

		// Token: 0x040005E9 RID: 1513
		private bool m_IsLoaded;

		// Token: 0x040005EA RID: 1514
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x040005EB RID: 1515
		private string m_ShoesCurrentFolder = FifaEnvironment.ExportFolder;
	}
}
