using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000018 RID: 24
	public class Viewer2D : UserControl
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000F893 File Offset: 0x0000DA93
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000F89B File Offset: 0x0000DA9B
		[Category("User")]
		[Description("Image Size.")]
		public Size ImageSize
		{
			get
			{
				return this.m_ImageSize;
			}
			set
			{
				this.m_ImageSize = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000F8AC File Offset: 0x0000DAAC
		[Category("User")]
		[Description("Image Alternative Size Multiplier.")]
		public Viewer2D.SizeMultiplier ImageSizeMultiplier
		{
			get
			{
				return this.m_ImageSizeMultiplier;
			}
			set
			{
				this.m_ImageSizeMultiplier = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000F8B5 File Offset: 0x0000DAB5
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000F8BD File Offset: 0x0000DABD
		[Category("User")]
		[Description("Auto Transparency.")]
		public bool AutoTransparency
		{
			get
			{
				return this.m_AutoTransparency;
			}
			set
			{
				this.m_AutoTransparency = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000F8C6 File Offset: 0x0000DAC6
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000F8D3 File Offset: 0x0000DAD3
		[Category("User")]
		[Description("Full Size Button Visible.")]
		public bool FullSizeButton
		{
			get
			{
				return this.buttonFullSize.Visible;
			}
			set
			{
				this.buttonFullSize.Visible = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000F8E1 File Offset: 0x0000DAE1
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000F8EE File Offset: 0x0000DAEE
		[Category("User")]
		[Description("Remove Button Visible.")]
		public bool RemoveButton
		{
			get
			{
				return this.buttonRemove.Visible;
			}
			set
			{
				this.buttonRemove.Visible = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000F909 File Offset: 0x0000DB09
		[Category("User")]
		[Description("Show Button Visible.")]
		public bool ShowButton
		{
			get
			{
				return this.buttonShow.Visible;
			}
			set
			{
				this.buttonShow.Visible = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000F917 File Offset: 0x0000DB17
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000F924 File Offset: 0x0000DB24
		[Category("User")]
		[Description("Show Button Checked.")]
		public bool ShowButtonChecked
		{
			get
			{
				return this.buttonShow.Checked;
			}
			set
			{
				this.buttonShow.Checked = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000F932 File Offset: 0x0000DB32
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000F93F File Offset: 0x0000DB3F
		[Category("User")]
		[Description("Button strip visible.")]
		public bool ButtonStripVisible
		{
			get
			{
				return this.toolStrip.Visible;
			}
			set
			{
				this.toolStrip.Visible = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000F94D File Offset: 0x0000DB4D
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000F955 File Offset: 0x0000DB55
		[Category("User")]
		[Description("Extended Format")]
		public bool ExtendedFormat
		{
			get
			{
				return this.m_ExtendedFormat;
			}
			set
			{
				this.m_ExtendedFormat = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000F95E File Offset: 0x0000DB5E
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000F966 File Offset: 0x0000DB66
		public Bitmap CurrentBitmap
		{
			get
			{
				return this.m_Bitmap;
			}
			set
			{
				this.m_Bitmap = value;
				if (this.buttonShow.Checked)
				{
					this.picture.BackgroundImage = value;
					this.EnableButtons();
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000F98E File Offset: 0x0000DB8E
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000F99B File Offset: 0x0000DB9B
		[Category("User")]
		[Description("Image Layout.")]
		public ImageLayout ImageLayout
		{
			get
			{
				return this.picture.BackgroundImageLayout;
			}
			set
			{
				this.picture.BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000F9A9 File Offset: 0x0000DBA9
		public string CurrentFolder
		{
			set
			{
				this.m_InitialDirectory = value;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000F9B2 File Offset: 0x0000DBB2
		public Viewer2D()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000F9CC File Offset: 0x0000DBCC
		private void buttonImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000F9CC File Offset: 0x0000DBCC
		private void menuImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		private void ImportImage()
		{
			Bitmap bitmap = this.BrowseAndCheckBitmap();
			if (bitmap == null)
			{
				return;
			}
			if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				bitmap = GraphicUtil.Get32bitBitmap(bitmap);
			}
			if (this.ImageImport != null && !this.ImageImport(this, bitmap))
			{
				return;
			}
			this.CurrentBitmap = bitmap;
			this.Refresh();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000FA28 File Offset: 0x0000DC28
		private Bitmap BrowseAndCheckBitmap()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = this.m_InitialDirectory;
			openFileDialog.RestoreDirectory = true;
			if (this.m_ExtendedFormat)
			{
				openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
			}
			else
			{
				openFileDialog.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			}
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open Image File";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			this.m_InitialDirectory = Path.GetDirectoryName(fileName);
			openFileDialog.Dispose();
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				return null;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			int num = this.m_ImageSize.Width;
			int num2 = this.m_ImageSize.Height;
			if (bitmap.Width != num || bitmap.Height != num2)
			{
				switch (this.m_ImageSizeMultiplier)
				{
				case Viewer2D.SizeMultiplier.OneAndHalf:
				{
					int num3 = num;
					num = num3 + num3 / 2;
					int num4 = num2;
					num2 = num4 + num4 / 2;
					break;
				}
				case Viewer2D.SizeMultiplier.Double:
					num *= 2;
					num2 *= 2;
					break;
				case Viewer2D.SizeMultiplier.Half:
					num /= 2;
					num2 /= 2;
					break;
				case Viewer2D.SizeMultiplier.Kit:
					if ((bitmap.Width == 512 && bitmap.Height == 512) || (bitmap.Width == 768 && bitmap.Height == 768) || (bitmap.Width == 1024 && bitmap.Height == 1024))
					{
						num = bitmap.Width;
						num2 = bitmap.Height;
					}
					break;
				case Viewer2D.SizeMultiplier.MiniFace:
					num = bitmap.Width;
					num2 = bitmap.Height;
					if (bitmap.PixelFormat != PixelFormat.Format24bppRgb && bitmap.PixelFormat != PixelFormat.Format32bppArgb && bitmap.PixelFormat != PixelFormat.Format8bppIndexed)
					{
						return null;
					}
					num = 128;
					num2 = 128;
					bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
					bitmap = GraphicUtil.ResizeBitmap(bitmap, 128, 128, InterpolationMode.HighQualityBilinear);
					break;
				case Viewer2D.SizeMultiplier.Auto256:
					num = bitmap.Width;
					num2 = bitmap.Height;
					if (num != 256 || num2 != 256)
					{
						if (bitmap.PixelFormat == PixelFormat.Format32bppArgb)
						{
							num = 256;
							num2 = 256;
							bitmap = GraphicUtil.ResizeBitmap(bitmap, 256, 256, InterpolationMode.HighQualityBilinear);
						}
						else if (bitmap.PixelFormat == PixelFormat.Format24bppRgb)
						{
							num = 256;
							num2 = 256;
							bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
							bitmap = GraphicUtil.ResizeBitmap(bitmap, 256, 256, InterpolationMode.HighQualityBilinear);
						}
					}
					break;
				}
				if (this.m_ImageSizeMultiplier != Viewer2D.SizeMultiplier.Free && (bitmap.Width != num || bitmap.Height != num2))
				{
					Cursor.Current = Cursors.Default;
					FifaEnvironment.UserMessages.ShowMessage(5015);
					return null;
				}
			}
			if (this.m_AutoTransparency && Path.GetExtension(fileName).ToLower() == ".bmp")
			{
				bitmap = GraphicUtil.MakeAutoTransparent(bitmap);
			}
			Cursor.Current = Cursors.Default;
			return bitmap;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		private void buttonRemove_Click(object sender, EventArgs e)
		{
			this.RemoveImage();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000FD24 File Offset: 0x0000DF24
		private void RemoveImage()
		{
			this.picture.BackgroundImage = null;
			this.CurrentBitmap = null;
			if (this.ImageDelete != null)
			{
				this.ImageDelete(this);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.ExportImage();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000FD56 File Offset: 0x0000DF56
		private void ExportImage()
		{
			this.AskAndSaveBitmap(this.m_Bitmap);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000FD68 File Offset: 0x0000DF68
		private bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			saveFileDialog.InitialDirectory = this.m_InitialDirectory;
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.Title = "Save picture as .bmp or .png";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return false;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			string extension = Path.GetExtension(saveFileDialog.FileName);
			this.m_InitialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
			ImageFormat imageFormat;
			if (extension.ToLower() == ".bmp")
			{
				imageFormat = ImageFormat.Bmp;
				Color pixel = bitmap.GetPixel(0, 0);
				for (int i = bitmap.Width - 1; i >= 0; i--)
				{
					for (int j = bitmap.Height - 1; j >= 0; j--)
					{
						if (bitmap.GetPixel(i, j).A < 192)
						{
							bitmap.SetPixel(i, j, pixel);
						}
					}
				}
			}
			else
			{
				if (!(extension.ToLower() == ".png"))
				{
					Cursor.Current = Cursors.Default;
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			string fileName = saveFileDialog.FileName;
			bitmap.Save(saveFileDialog.FileName, imageFormat);
			saveFileDialog.Dispose();
			Cursor.Current = Cursors.Default;
			return true;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		public void DisposeBitmap()
		{
			if (this.picture.BackgroundImage != null)
			{
				this.picture.BackgroundImage.Dispose();
				this.picture.BackgroundImage = null;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		private void buttonFullSize_Click(object sender, EventArgs e)
		{
			if (this.m_Bitmap != null)
			{
				Viewer2D.s_FullSizeViewer.SetImage(this.m_Bitmap);
				Viewer2D.s_FullSizeViewer.ShowDialog();
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000FEFD File Offset: 0x0000E0FD
		private void buttonShow_Click(object sender, EventArgs e)
		{
			this.EnableButtons();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000FF08 File Offset: 0x0000E108
		private void EnableButtons()
		{
			bool flag = this.buttonShow.Checked && this.m_Bitmap != null;
			this.buttonExportImage.Enabled = flag;
			this.buttonFullSize.Enabled = flag;
			this.buttonRemove.Enabled = flag;
			if (!flag)
			{
				this.textSize.Text = string.Empty;
				this.picture.BackgroundImage = null;
			}
			else
			{
				this.textSize.Text = this.m_Bitmap.Width.ToString() + " x " + this.m_Bitmap.Height.ToString();
				this.picture.BackgroundImage = this.m_Bitmap;
			}
			this.picture.Enabled = this.buttonShow.Checked;
			this.buttonImportImage.Enabled = true;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000FFE2 File Offset: 0x0000E1E2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00010004 File Offset: 0x0000E204
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Viewer2D));
			this.picture = new PictureBox();
			this.contextMenuStrip = new ContextMenuStrip(this.components);
			this.importImageToolStripMenuItem = new ToolStripMenuItem();
			this.exportImageToolStripMenuItem = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.toolStrip = new ToolStrip();
			this.buttonShow = new ToolStripButton();
			this.buttonImportImage = new ToolStripButton();
			this.buttonExportImage = new ToolStripButton();
			this.buttonFullSize = new ToolStripButton();
			this.buttonRemove = new ToolStripButton();
			this.textSize = new ToolStripTextBox();
			this.openFileDialog = new OpenFileDialog();
			((ISupportInitialize)this.picture).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.picture.BackColor = SystemColors.Control;
			this.picture.BackgroundImageLayout = ImageLayout.None;
			this.picture.BorderStyle = BorderStyle.FixedSingle;
			this.picture.ContextMenuStrip = this.contextMenuStrip;
			this.picture.Dock = DockStyle.Fill;
			this.picture.Location = new Point(0, 0);
			this.picture.Name = "picture";
			this.picture.Size = new Size(197, 187);
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			this.contextMenuStrip.Items.AddRange(new ToolStripItem[] { this.importImageToolStripMenuItem, this.exportImageToolStripMenuItem, this.removeToolStripMenuItem });
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new Size(147, 70);
			this.importImageToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("importImageToolStripMenuItem.Image");
			this.importImageToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.importImageToolStripMenuItem.Name = "importImageToolStripMenuItem";
			this.importImageToolStripMenuItem.Size = new Size(146, 22);
			this.importImageToolStripMenuItem.Text = "Import Image";
			this.importImageToolStripMenuItem.Click += this.buttonImportImage_Click;
			this.exportImageToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("exportImageToolStripMenuItem.Image");
			this.exportImageToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
			this.exportImageToolStripMenuItem.Size = new Size(146, 22);
			this.exportImageToolStripMenuItem.Text = "Export Image";
			this.exportImageToolStripMenuItem.Click += this.buttonExportImage_Click;
			this.removeToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("removeToolStripMenuItem.Image");
			this.removeToolStripMenuItem.ImageTransparentColor = Color.Fuchsia;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new Size(146, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += this.buttonRemove_Click;
			this.toolStrip.Dock = DockStyle.Bottom;
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[] { this.buttonShow, this.buttonImportImage, this.buttonExportImage, this.buttonFullSize, this.buttonRemove, this.textSize });
			this.toolStrip.Location = new Point(0, 187);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(197, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			this.buttonShow.Checked = true;
			this.buttonShow.CheckOnClick = true;
			this.buttonShow.CheckState = CheckState.Checked;
			this.buttonShow.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonShow.Image = (Image)componentResourceManager.GetObject("buttonShow.Image");
			this.buttonShow.ImageTransparentColor = Color.Magenta;
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new Size(23, 22);
			this.buttonShow.Text = "Show / Hide";
			this.buttonShow.Click += this.buttonShow_Click;
			this.buttonImportImage.AutoSize = false;
			this.buttonImportImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonImportImage.Image = (Image)componentResourceManager.GetObject("buttonImportImage.Image");
			this.buttonImportImage.ImageTransparentColor = Color.Magenta;
			this.buttonImportImage.Name = "buttonImportImage";
			this.buttonImportImage.Size = new Size(20, 22);
			this.buttonImportImage.Text = "Import Image";
			this.buttonImportImage.Click += this.buttonImportImage_Click;
			this.buttonExportImage.AutoSize = false;
			this.buttonExportImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonExportImage.Image = (Image)componentResourceManager.GetObject("buttonExportImage.Image");
			this.buttonExportImage.ImageTransparentColor = Color.Magenta;
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new Size(20, 22);
			this.buttonExportImage.Text = "Export Image";
			this.buttonExportImage.Click += this.buttonExportImage_Click;
			this.buttonFullSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonFullSize.Image = (Image)componentResourceManager.GetObject("buttonFullSize.Image");
			this.buttonFullSize.ImageTransparentColor = Color.Magenta;
			this.buttonFullSize.Name = "buttonFullSize";
			this.buttonFullSize.Size = new Size(23, 22);
			this.buttonFullSize.Text = "View Full Size";
			this.buttonFullSize.Visible = false;
			this.buttonFullSize.Click += this.buttonFullSize_Click;
			this.buttonRemove.AutoSize = false;
			this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemove.Image = (Image)componentResourceManager.GetObject("buttonRemove.Image");
			this.buttonRemove.ImageTransparentColor = Color.Magenta;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new Size(20, 22);
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.Visible = false;
			this.buttonRemove.Click += this.buttonRemove_Click;
			this.textSize.BackColor = Color.White;
			this.textSize.Name = "textSize";
			this.textSize.ReadOnly = true;
			this.textSize.Size = new Size(65, 25);
			this.textSize.Text = "1024 x 1024";
			this.textSize.TextBoxTextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.picture);
			base.Controls.Add(this.toolStrip);
			base.Name = "Viewer2D";
			base.Size = new Size(197, 212);
			((ISupportInitialize)this.picture).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000133 RID: 307
		private Size m_ImageSize;

		// Token: 0x04000134 RID: 308
		private Viewer2D.SizeMultiplier m_ImageSizeMultiplier;

		// Token: 0x04000135 RID: 309
		private bool m_AutoTransparency;

		// Token: 0x04000136 RID: 310
		private bool m_ExtendedFormat;

		// Token: 0x04000137 RID: 311
		private Bitmap m_Bitmap;

		// Token: 0x04000138 RID: 312
		private string m_InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x04000139 RID: 313
		public Viewer2D.ImageImportHandler ImageImport;

		// Token: 0x0400013A RID: 314
		public Viewer2D.ImageDeleteHandler ImageDelete;

		// Token: 0x0400013B RID: 315
		private static FullSizeViewer s_FullSizeViewer = new FullSizeViewer();

		// Token: 0x0400013C RID: 316
		private IContainer components;

		// Token: 0x0400013D RID: 317
		public PictureBox picture;

		// Token: 0x0400013E RID: 318
		private ToolStrip toolStrip;

		// Token: 0x0400013F RID: 319
		private ToolStripTextBox textSize;

		// Token: 0x04000140 RID: 320
		private OpenFileDialog openFileDialog;

		// Token: 0x04000141 RID: 321
		public ToolStripButton buttonImportImage;

		// Token: 0x04000142 RID: 322
		public ToolStripButton buttonExportImage;

		// Token: 0x04000143 RID: 323
		public ToolStripButton buttonRemove;

		// Token: 0x04000144 RID: 324
		public ToolStripButton buttonFullSize;

		// Token: 0x04000145 RID: 325
		private ToolStripButton buttonShow;

		// Token: 0x04000146 RID: 326
		private ContextMenuStrip contextMenuStrip;

		// Token: 0x04000147 RID: 327
		private ToolStripMenuItem importImageToolStripMenuItem;

		// Token: 0x04000148 RID: 328
		private ToolStripMenuItem exportImageToolStripMenuItem;

		// Token: 0x04000149 RID: 329
		private ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x0200002D RID: 45
		public enum SizeMultiplier
		{
			// Token: 0x040001DD RID: 477
			None,
			// Token: 0x040001DE RID: 478
			OneAndHalf,
			// Token: 0x040001DF RID: 479
			Double,
			// Token: 0x040001E0 RID: 480
			Half,
			// Token: 0x040001E1 RID: 481
			Kit,
			// Token: 0x040001E2 RID: 482
			MiniFace,
			// Token: 0x040001E3 RID: 483
			Auto256,
			// Token: 0x040001E4 RID: 484
			Free
		}

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060001D2 RID: 466
		public delegate bool ImageImportHandler(object sender, Bitmap bitmap);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001D6 RID: 470
		public delegate bool ImageDeleteHandler(object sender);
	}
}
