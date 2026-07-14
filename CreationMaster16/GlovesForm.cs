using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000006 RID: 6
	public partial class GlovesForm : Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000D914 File Offset: 0x0000BB14
		public GlovesForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectGkGloves);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateGkGloves);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteGkGloves);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneGkGloves);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshGkGloves);
			this.multiViewer2DGkGloves.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3GkGloves);
			this.multiViewer2DGkGloves.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3GkGloves);
			this.multiViewer2DGkGloves.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveBitmapGkGloves);
			this.multiViewer2DGkGloves.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3GkGloves);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000DA0E File Offset: 0x0000BC0E
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.GkGloves;
			this.pickUpControl.ObjectList = FifaEnvironment.GkGloves;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000DA30 File Offset: 0x0000BC30
		private GkGloves SelectGkGloves(object sender, object obj)
		{
			GkGloves gkGloves = (GkGloves)obj;
			this.Refresh();
			this.LoadGkGloves(gkGloves);
			return gkGloves;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000DA54 File Offset: 0x0000BC54
		private GkGloves CreateGkGloves(object sender, object obj)
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
			return (GkGloves)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		private GkGloves DeleteGkGloves(object sender, object obj)
		{
			GkGloves gkGloves = (GkGloves)obj;
			GkGloves.DeleteGkGlovesTextures(gkGloves.Id);
			FifaEnvironment.GkGloves.RemoveId(gkGloves);
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000DADC File Offset: 0x0000BCDC
		private GkGloves CloneGkGloves(object sender, object obj)
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
			GkGloves gkGloves = (GkGloves)obj;
			return (GkGloves)FifaEnvironment.GkGloves.CloneId(gkGloves, this.m_NewIdCreator.NewObject);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000DB45 File Offset: 0x0000BD45
		public GkGloves RefreshGkGloves(object sender, object obj)
		{
			this.Preset();
			this.ReloadGkGloves(this.m_CurrentGkGloves);
			return this.m_CurrentGkGloves;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000DB60 File Offset: 0x0000BD60
		private void LoadGkGloves(GkGloves gkgloves)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentGkGloves == gkgloves)
			{
				return;
			}
			this.m_CurrentGkGloves = gkgloves;
			Bitmap[] gkGlovesTextures = GkGloves.GetGkGlovesTextures(gkgloves.Id);
			this.multiViewer2DGkGloves.Bitmaps = gkGlovesTextures;
			this.Show3DGkGloves();
			GC.Collect();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000DBAA File Offset: 0x0000BDAA
		private void ReloadGkGloves(GkGloves gkgloves)
		{
			this.m_CurrentGkGloves = null;
			this.LoadGkGloves(gkgloves);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public void Show3DGkGloves()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap[] gkGlovesTextures = GkGloves.GetGkGlovesTextures(this.m_CurrentGkGloves.Id);
			Bitmap bitmap = GraphicUtil.EmbossBitmap(gkGlovesTextures[0], gkGlovesTextures[1]);
			if (bitmap == null || GkGloves.GkGlovesModel == null)
			{
				this.viewer3D.Clean(1);
				return;
			}
			GkGloves.GkGlovesModel.TextureBitmap = bitmap;
			this.viewer3D.Clean(1);
			this.viewer3D.SetMesh(0, GkGloves.GkGlovesModel);
			this.viewer3D.Render();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000DC49 File Offset: 0x0000BE49
		private bool SaveBitmapGkGloves(object sender, Bitmap[] bitmaps)
		{
			bool flag = GkGloves.SetGkGlovesTextures(this.m_CurrentGkGloves.Id, bitmaps);
			this.ReloadGkGloves(this.m_CurrentGkGloves);
			return flag;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000DC68 File Offset: 0x0000BE68
		private bool ExportRx3GkGloves(object sender, string exportDir)
		{
			return GkGloves.ExportGkGlovesTextures(this.m_CurrentGkGloves.Id, exportDir);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000DC7B File Offset: 0x0000BE7B
		private bool ImportRx3GkGloves(object sender, string rx3FileName)
		{
			bool flag = GkGloves.SetGkGlovesTextures(this.m_CurrentGkGloves.Id, rx3FileName);
			if (flag)
			{
				this.ReloadGkGloves(this.m_CurrentGkGloves);
			}
			return flag;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000DC9D File Offset: 0x0000BE9D
		private bool DeleteRx3GkGloves(object sender)
		{
			bool flag = GkGloves.DeleteGkGlovesTextures(this.m_CurrentGkGloves.Id);
			if (flag)
			{
				this.ReloadGkGloves(this.m_CurrentGkGloves);
			}
			return flag;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000DCBE File Offset: 0x0000BEBE
		private void GkGlovesForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000DCCD File Offset: 0x0000BECD
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DGkGloves();
		}

		// Token: 0x040000DB RID: 219
		private GkGloves m_CurrentGkGloves;

		// Token: 0x040000DC RID: 220
		private bool m_IsLoaded;

		// Token: 0x040000DD RID: 221
		private NewIdCreator m_NewIdCreator = new NewIdCreator();
	}
}
