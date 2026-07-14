using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000002 RID: 2
	public partial class BallForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public BallForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectBall);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateBall);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteBall);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneBall);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshBall);
			this.multiViewer2DTextures.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3BallTextures);
			this.multiViewer2DTextures.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3BallTextures);
			this.multiViewer2DTextures.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3BallTextures);
			this.multiViewer2DTextures.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3BallTextures);
			this.viewer2DBallPicture.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageBallPicture);
			this.viewer2DBallPicture.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageBallPicture);
			this.viewer2DBallPicture.ButtonStripVisible = true;
			this.viewer2DBallPicture.RemoveButton = true;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021A4 File Offset: 0x000003A4
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Balls;
			this.pickUpControl.ObjectList = FifaEnvironment.Balls;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021C6 File Offset: 0x000003C6
		private bool ImportImageTextures(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentBall.SetBallTextures(bitmaps);
			this.ReloadBall(this.m_CurrentBall);
			return flag;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021E0 File Offset: 0x000003E0
		private bool ExportFshTexture(object sender)
		{
			return FifaEnvironment.AskAndExportFromZdata(this.m_CurrentBall.BallTextureFileName(), ref this.m_BallCurrentFolder);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F8 File Offset: 0x000003F8
		private bool DeleteTexture(object sender)
		{
			bool flag = this.m_CurrentBall.DeleteBallTextures();
			this.ReloadBall(this.m_CurrentBall);
			return flag;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002211 File Offset: 0x00000411
		private void ReloadBall(Ball ball)
		{
			this.m_CurrentBall = null;
			this.LoadBall(ball);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002224 File Offset: 0x00000424
		private void LoadBall(Ball ball)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentBall == ball)
			{
				return;
			}
			this.m_CurrentBall = ball;
			this.ballBindingSource.DataSource = this.m_CurrentBall;
			this.multiViewer2DTextures.Bitmaps = this.m_CurrentBall.GetBallTextures();
			this.viewer2DBallPicture.CurrentBitmap = this.m_CurrentBall.GetBallPicture();
			this.Show3DBall();
			GC.Collect();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002294 File Offset: 0x00000494
		public void Show3DBall()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap[] ballTextures = this.m_CurrentBall.GetBallTextures();
			Bitmap bitmap = null;
			if (ballTextures != null)
			{
				bitmap = GraphicUtil.EmbossBitmap(ballTextures[0], ballTextures[1]);
			}
			Rx3File ballModel = this.m_CurrentBall.GetBallModel();
			if (bitmap == null || ballModel == null)
			{
				this.viewer3D.Clean(1);
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			Model3D model3D = new Model3D(ballModel.Rx3IndexArrays[0], ballModel.Rx3VertexArrays[0], bitmap);
			this.viewer3D.Clean(1);
			this.viewer3D.SetMesh(0, model3D);
			this.viewer3D.Render();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002337 File Offset: 0x00000537
		private bool ImportImageBallPicture(object sender, Bitmap bitmap)
		{
			return this.m_CurrentBall.SetBallPicture(bitmap);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002345 File Offset: 0x00000545
		private bool DeleteImageBallPicture(object sender)
		{
			return this.m_CurrentBall.DeleteBallPicture();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002352 File Offset: 0x00000552
		private bool ExportRx3BallTextures(object sender, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(this.m_CurrentBall.BallTextureFileName(), exportDir);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002365 File Offset: 0x00000565
		private bool SaveRx3BallTextures(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentBall.SetBallTextures(bitmaps);
			if (flag)
			{
				this.ReloadBall(this.m_CurrentBall);
			}
			return flag;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002382 File Offset: 0x00000582
		private bool ImportRx3BallTextures(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentBall.SetBallTextures(rx3FileName);
			if (flag)
			{
				this.ReloadBall(this.m_CurrentBall);
			}
			return flag;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000239F File Offset: 0x0000059F
		private bool DeleteRx3BallTextures(object sender)
		{
			bool flag = this.m_CurrentBall.DeleteBallTextures();
			if (flag)
			{
				this.ReloadBall(this.m_CurrentBall);
			}
			return flag;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023BC File Offset: 0x000005BC
		private Ball SelectBall(object sender, object obj)
		{
			Ball ball = (Ball)obj;
			this.Refresh();
			this.LoadBall(ball);
			return ball;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023E0 File Offset: 0x000005E0
		private Ball CreateBall(object sender, object obj)
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
			return (Ball)this.m_NewIdCreator.NewObject;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002438 File Offset: 0x00000638
		private Ball DeleteBall(object sender, object obj)
		{
			Ball ball = (Ball)obj;
			ball.DeleteBall();
			FifaEnvironment.Balls.RemoveId(ball);
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002460 File Offset: 0x00000660
		private Ball CloneBall(object sender, object obj)
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
			Ball ball = (Ball)obj;
			return (Ball)FifaEnvironment.Balls.CloneId(ball, this.m_NewIdCreator.NewObject);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024C9 File Offset: 0x000006C9
		public Ball RefreshBall(object sender, object obj)
		{
			this.Preset();
			this.ReloadBall(this.m_CurrentBall);
			return this.m_CurrentBall;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024E4 File Offset: 0x000006E4
		private void buttonImportNear3DModel_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_BallCurrentFolder, "Open 3D Ball Model file", "3D ball model files (*.rx3)|ball_*.rx3");
			if (text == null)
			{
				return;
			}
			this.m_CurrentBall.SetBallModel(text);
			this.ReloadBall(this.m_CurrentBall);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002524 File Offset: 0x00000724
		private void buttonExportNear3DModel_Click(object sender, EventArgs e)
		{
			string text = this.m_CurrentBall.BallModelFileName();
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_BallCurrentFolder);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000254D File Offset: 0x0000074D
		private void buttonRemoveNear3DModel_Click(object sender, EventArgs e)
		{
			this.m_CurrentBall.DeleteBallModel();
			this.ReloadBall(this.m_CurrentBall);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002567 File Offset: 0x00000767
		private void BallForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002576 File Offset: 0x00000776
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DBall();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000257E File Offset: 0x0000077E
		private void textBalllName_TextChanged(object sender, EventArgs e)
		{
			this.m_CurrentBall.Name = this.textBalllName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentBall);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025A8 File Offset: 0x000007A8
		private void buttonCamera_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = this.viewer3D.Photo();
			int height = bitmap.Height;
			int width = bitmap.Width;
			if (width < height)
			{
				return;
			}
			int num = height;
			int num2 = num - num / 12;
			int num3 = num2;
			int num4 = (width - num3) / 2;
			int num5 = (height - num2) / 2;
			Rectangle rectangle = new Rectangle(num4, num5, num3, num2);
			Rectangle rectangle2 = new Rectangle(73, 0, 177, 177);
			bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
			Bitmap bitmap2 = new Bitmap(512, 256, PixelFormat.Format32bppArgb);
			GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap2, rectangle2);
			Bitmap bitmap3 = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\BallShadow.png");
			GraphicUtil.DrawOver(bitmap2, bitmap3);
			this.m_CurrentBall.SetBallPicture(bitmap2);
			this.viewer2DBallPicture.CurrentBitmap = bitmap2;
		}

		// Token: 0x04000001 RID: 1
		private Ball m_CurrentBall;

		// Token: 0x04000002 RID: 2
		private bool m_IsLoaded;

		// Token: 0x04000003 RID: 3
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000004 RID: 4
		private string m_BallCurrentFolder = FifaEnvironment.ExportFolder;
	}
}
