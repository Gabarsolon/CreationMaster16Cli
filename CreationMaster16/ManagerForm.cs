using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000009 RID: 9
	public partial class ManagerForm : Form
	{
		// Token: 0x060000FB RID: 251 RVA: 0x000184B8 File Offset: 0x000166B8
		public ManagerForm()
		{
			this.InitializeComponent();
			this.viewer2DManager.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageManager);
			this.viewer2DManager.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteManager);
			this.viewer2DManager.ButtonStripVisible = true;
			this.viewer2DManager.RemoveButton = true;
			if (this.comboManagerBodyType.SelectedIndex < 0)
			{
				this.comboManagerBodyType.SelectedIndex = 0;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00018538 File Offset: 0x00016738
		private void ShowManager()
		{
			this.viewer2DManager.CurrentBitmap = Manager.GetManagerTextures(this.m_CurrentDress, this.m_CurrentSkin, this.m_CurrentColor, this.m_CurrentCoat);
			this.Show3DManager();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00018568 File Offset: 0x00016768
		private void LoadManager()
		{
			this.ShowManager();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00018570 File Offset: 0x00016770
		private void numericManager3_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentColor = (int)this.numericManagerColor.Value;
			this.ShowManager();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001858E File Offset: 0x0001678E
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DManager();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00018598 File Offset: 0x00016798
		public void Show3DManager()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap currentBitmap = this.viewer2DManager.CurrentBitmap;
			if (currentBitmap == null)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Rx3File managerModel = Manager.GetManagerModel(this.m_CurrentDress, this.m_Body, this.m_CurrentCoat);
			if (currentBitmap == null || managerModel == null)
			{
				this.viewer3D.Clean(1);
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			Model3D model3D = new Model3D(managerModel.Rx3IndexArrays[0], managerModel.Rx3VertexArrays[0], currentBitmap);
			this.viewer3D.Clean(1);
			this.viewer3D.SetMesh(0, model3D);
			this.viewer3D.Render();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00018645 File Offset: 0x00016845
		private void comboManagerSkin_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_CurrentSkin = this.comboManagerSkin.SelectedIndex + 1;
			this.ShowManager();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00018660 File Offset: 0x00016860
		private void comboManagerDress_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_CurrentDress = this.comboManagerDress.SelectedIndex;
			this.ShowManager();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00018679 File Offset: 0x00016879
		private void checkManagerCoat_CheckedChanged(object sender, EventArgs e)
		{
			this.m_CurrentCoat = (this.checkManagerCoat.Checked ? 1 : 0);
			this.ShowManager();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00018698 File Offset: 0x00016898
		private bool ImportImageManager(object sender, Bitmap bitmap)
		{
			return Manager.SetManager(this.m_CurrentDress, this.m_CurrentSkin, this.m_CurrentColor, this.m_CurrentCoat, bitmap);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000186B8 File Offset: 0x000168B8
		private bool DeleteManager(object sender)
		{
			return Manager.DeleteManagerTexture(this.m_CurrentDress, this.m_CurrentSkin, this.m_CurrentColor, this.m_CurrentCoat);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000186D7 File Offset: 0x000168D7
		private void comboManagerBodyType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboManagerBodyType.SelectedIndex < 0)
			{
				return;
			}
			this.m_Body = this.comboManagerBodyType.SelectedIndex;
			this.ShowManager();
		}

		// Token: 0x04000184 RID: 388
		private int m_CurrentSkin = 2;

		// Token: 0x04000185 RID: 389
		private int m_CurrentDress;

		// Token: 0x04000186 RID: 390
		private int m_CurrentColor;

		// Token: 0x04000187 RID: 391
		private int m_CurrentCoat;

		// Token: 0x04000188 RID: 392
		private int m_Body;
	}
}
