using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000F RID: 15
	public class MultiViewer2D : UserControl
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000A9E0 File Offset: 0x00008BE0
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000A9E9 File Offset: 0x00008BE9
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000A9F1 File Offset: 0x00008BF1
		[Category("User")]
		[Description("Check for bitmap size.")]
		public bool CheckBitmapSize
		{
			get
			{
				return this.m_CheckBitmapSize;
			}
			set
			{
				this.m_CheckBitmapSize = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000A9FA File Offset: 0x00008BFA
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000AA07 File Offset: 0x00008C07
		[Category("User")]
		[Description("Label text.")]
		public string LabelText
		{
			get
			{
				return this.label.Text;
			}
			set
			{
				this.label.Text = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000AA15 File Offset: 0x00008C15
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000AA22 File Offset: 0x00008C22
		[Category("User")]
		[Description("Show Delete Button.")]
		public bool ShowDeleteButton
		{
			get
			{
				return this.buttonRemoveRx3.Visible;
			}
			set
			{
				this.buttonRemoveRx3.Visible = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000AA30 File Offset: 0x00008C30
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000AA3D File Offset: 0x00008C3D
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000AA4B File Offset: 0x00008C4B
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000AA58 File Offset: 0x00008C58
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000AA66 File Offset: 0x00008C66
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000AA6E File Offset: 0x00008C6E
		[Category("User")]
		[Description("Fixed size.")]
		public bool FixedSize
		{
			get
			{
				return this.m_FixedSize;
			}
			set
			{
				this.m_FixedSize = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000AA77 File Offset: 0x00008C77
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000AA80 File Offset: 0x00008C80
		[Category("User")]
		[Description("Bitmaps.")]
		public Bitmap[] Bitmaps
		{
			get
			{
				return this.m_Bitmaps;
			}
			set
			{
				this.m_Bitmaps = value;
				if (this.m_Bitmaps != null)
				{
					this.numeric.Maximum = this.m_Bitmaps.Length;
					this.labelOf.Text = "/" + this.m_Bitmaps.Length.ToString();
					if (this.m_CurrentIndex >= this.m_Bitmaps.Length)
					{
						this.m_CurrentIndex = 0;
					}
					else
					{
						this.numeric_ValueChanged(null, null);
					}
				}
				else
				{
					this.m_CurrentIndex = 0;
					this.numeric_ValueChanged(null, null);
				}
				this.m_NeedToSave = false;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000AB14 File Offset: 0x00008D14
		public void Redraw()
		{
			this.m_CurrentIndex = (int)this.numeric.Value - 1;
			if (this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null && this.buttonShow.Checked)
			{
				this.pictureBox.BackgroundImage = this.m_Bitmaps[this.m_CurrentIndex];
				this.textSize.Text = this.m_Bitmaps[this.m_CurrentIndex].Width + " x " + this.m_Bitmaps[this.m_CurrentIndex].Height;
				this.AdjustImageLayout();
				return;
			}
			this.pictureBox.BackgroundImage = null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000ABCB File Offset: 0x00008DCB
		public Bitmap GetCurrentBitmap()
		{
			if (this.m_Bitmaps != null && this.m_CurrentIndex < this.m_Bitmaps.Length)
			{
				return this.m_Bitmaps[this.m_CurrentIndex];
			}
			return null;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000ABFC File Offset: 0x00008DFC
		private string InitialDirectory
		{
			get
			{
				return this.m_InitialDirectory;
			}
			set
			{
				this.folderBrowserDialog.SelectedPath = value;
				this.openFileDialogBmp.InitialDirectory = value;
				this.openFileDialogRx3.InitialDirectory = value;
				this.saveFileDialogBmp.InitialDirectory = value;
				this.m_InitialDirectory = value;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000AC35 File Offset: 0x00008E35
		public MultiViewer2D()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000AC4F File Offset: 0x00008E4F
		private void numeric_ValueChanged(object sender, EventArgs e)
		{
			this.Redraw();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000AC57 File Offset: 0x00008E57
		private void buttonImportImage_Click(object sender, EventArgs e)
		{
			this.ImportImage();
			if (this.BitmapUpdateDelegate != null)
			{
				this.BitmapUpdateDelegate(sender);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000AC74 File Offset: 0x00008E74
		private void ImportImage()
		{
			Bitmap bitmap = this.BrowseAndCheckBitmap();
			this.Refresh();
			if (bitmap == null)
			{
				return;
			}
			this.pictureBox.BackgroundImage = bitmap;
			this.m_NeedToSave = true;
			this.buttonSave.Enabled = true;
			if (this.m_Bitmaps == null)
			{
				this.m_Bitmaps = new Bitmap[(int)this.numeric.Maximum];
			}
			this.m_Bitmaps[this.m_CurrentIndex] = bitmap;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		private Bitmap BrowseAndCheckBitmap()
		{
			this.openFileDialogBmp.CheckFileExists = true;
			this.openFileDialogBmp.Multiselect = false;
			this.openFileDialogBmp.InitialDirectory = this.m_InitialDirectory;
			this.openFileDialogBmp.RestoreDirectory = true;
			this.openFileDialogBmp.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			this.openFileDialogBmp.FilterIndex = 1;
			this.openFileDialogBmp.Title = "Open Image File";
			if (this.openFileDialogBmp.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			string fileName = this.openFileDialogBmp.FileName;
			this.InitialDirectory = Path.GetDirectoryName(fileName);
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				return null;
			}
			Cursor.Current = Cursors.WaitCursor;
			base.FindForm().Refresh();
			if (this.m_CheckBitmapSize && this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null && this.m_CurrentIndex >= 0 && this.m_CurrentIndex < this.m_Bitmaps.Length)
			{
				int width = this.m_Bitmaps[this.m_CurrentIndex].Width;
				int height = this.m_Bitmaps[this.m_CurrentIndex].Height;
				if ((bitmap.Width != width || bitmap.Height != height) && (bitmap.Width != width || bitmap.Height != height))
				{
					Cursor.Current = Cursors.Default;
					FifaEnvironment.UserMessages.ShowMessage(5015);
					return null;
				}
			}
			if (this.m_AutoTransparency && Path.GetExtension(fileName).ToLower() == ".bmp")
			{
				Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
				Color pixel = bitmap.GetPixel(0, 0);
				Color color = Color.FromArgb(0, 0, 0, 0);
				for (int i = 0; i < bitmap.Width; i++)
				{
					for (int j = 0; j < bitmap.Height; j++)
					{
						Color pixel2 = bitmap.GetPixel(i, j);
						if (pixel2 == pixel)
						{
							bitmap2.SetPixel(i, j, color);
						}
						else
						{
							bitmap2.SetPixel(i, j, pixel2);
						}
					}
				}
				Cursor.Current = Cursors.Default;
				return bitmap2;
			}
			Cursor.Current = Cursors.Default;
			return bitmap;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000AF06 File Offset: 0x00009106
		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.ExportImage();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000AF0E File Offset: 0x0000910E
		private void ExportImage()
		{
			this.AskAndSaveBitmap((Bitmap)this.pictureBox.BackgroundImage);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000AF28 File Offset: 0x00009128
		private bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			this.saveFileDialogBmp.InitialDirectory = this.m_InitialDirectory;
			if (this.saveFileDialogBmp.ShowDialog() != DialogResult.OK)
			{
				return false;
			}
			string extension = Path.GetExtension(this.saveFileDialogBmp.FileName);
			this.InitialDirectory = Path.GetDirectoryName(this.saveFileDialogBmp.FileName);
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
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			bitmap.Save(this.saveFileDialogBmp.FileName, imageFormat);
			return true;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000B021 File Offset: 0x00009221
		private void buttonImportFsh_Click(object sender, EventArgs e)
		{
			this.ImportRx3();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000B02C File Offset: 0x0000922C
		private void ImportRx3()
		{
			string text = this.BrowseRx3();
			if (text == null)
			{
				return;
			}
			if (this.Rx3ImportDelegate != null)
			{
				this.Rx3ImportDelegate(this, text);
			}
			this.m_NeedToSave = false;
			this.buttonSave.Enabled = false;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000B070 File Offset: 0x00009270
		private string BrowseRx3()
		{
			this.openFileDialogRx3.InitialDirectory = this.m_InitialDirectory;
			if (this.openFileDialogRx3.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			string fileName = this.openFileDialogRx3.FileName;
			this.InitialDirectory = Path.GetDirectoryName(fileName);
			return fileName;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000B0B8 File Offset: 0x000092B8
		private string BrowseExportingFolder()
		{
			this.folderBrowserDialog.Description = "Select the export folder";
			this.folderBrowserDialog.ShowNewFolderButton = true;
			if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				this.folderBrowserDialog.Dispose();
				return null;
			}
			return this.folderBrowserDialog.SelectedPath;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B107 File Offset: 0x00009307
		private void buttonExportRx3_Click(object sender, EventArgs e)
		{
			this.ExportRx3File();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000B110 File Offset: 0x00009310
		private void ExportRx3File()
		{
			string text = this.BrowseExportingFolder();
			if (text == null)
			{
				return;
			}
			if (this.Rx3ExportDelegate != null)
			{
				this.Rx3ExportDelegate(this, text);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000B140 File Offset: 0x00009340
		private void buttonSave_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (this.Rx3SaveDelegate != null)
			{
				this.Rx3SaveDelegate(sender, this.m_Bitmaps);
			}
			this.m_NeedToSave = false;
			this.buttonSave.Enabled = false;
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000B18F File Offset: 0x0000938F
		private void MultiViewer2D_Resize(object sender, EventArgs e)
		{
			this.AdjustImageLayout();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000B198 File Offset: 0x00009398
		private void AdjustImageLayout()
		{
			int num = 128;
			int num2 = 128;
			if (this.m_Bitmaps != null && this.m_Bitmaps[this.m_CurrentIndex] != null)
			{
				num = this.m_Bitmaps[this.m_CurrentIndex].Width;
				num2 = this.m_Bitmaps[this.m_CurrentIndex].Height;
			}
			if (this.pictureBox.Width < num || this.pictureBox.Height < num2)
			{
				this.pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
				return;
			}
			this.pictureBox.BackgroundImageLayout = ImageLayout.Center;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000B223 File Offset: 0x00009423
		private void buttonFullSize_Click(object sender, EventArgs e)
		{
			if (this.m_Bitmaps[this.m_CurrentIndex] != null)
			{
				MultiViewer2D.s_FullSizeViewer.SetImage(this.m_Bitmaps[this.m_CurrentIndex]);
				MultiViewer2D.s_FullSizeViewer.ShowDialog();
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000B258 File Offset: 0x00009458
		private void buttonRemoveRx3_Click(object sender, EventArgs e)
		{
			this.m_Bitmaps = null;
			this.pictureBox.BackgroundImage = null;
			this.m_CurrentIndex = 0;
			this.numeric.Value = 1m;
			if (this.Rx3DeleteDelegate != null)
			{
				this.Rx3DeleteDelegate(this);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B2A4 File Offset: 0x000094A4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B2C4 File Offset: 0x000094C4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MultiViewer2D));
			this.label = new Label();
			this.numeric = new NumericUpDown();
			this.toolStrip = new ToolStrip();
			this.buttonShow = new ToolStripButton();
			this.buttonSave = new ToolStripButton();
			this.buttonImportImage = new ToolStripButton();
			this.buttonExportImage = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.buttonImportRx3 = new ToolStripButton();
			this.buttonExportRx3 = new ToolStripButton();
			this.buttonRemoveRx3 = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.buttonFullSize = new ToolStripButton();
			this.textSize = new ToolStripTextBox();
			this.pictureBox = new PictureBox();
			this.folderBrowserDialog = new FolderBrowserDialog();
			this.openFileDialogBmp = new OpenFileDialog();
			this.openFileDialogRx3 = new OpenFileDialog();
			this.saveFileDialogBmp = new SaveFileDialog();
			this.labelOf = new Label();
			((ISupportInitialize)this.numeric).BeginInit();
			this.toolStrip.SuspendLayout();
			((ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.label.Dock = DockStyle.Top;
			this.label.Location = new Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new Size(257, 20);
			this.label.TabIndex = 0;
			this.label.Text = "Image n.";
			this.label.TextAlign = ContentAlignment.MiddleLeft;
			this.numeric.Location = new Point(49, 0);
			NumericUpDown numericUpDown = this.numeric;
			int[] array = new int[4];
			array[0] = 1;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numeric;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numeric.Name = "numeric";
			this.numeric.Size = new Size(54, 22);
			this.numeric.TabIndex = 1;
			this.numeric.TextAlign = HorizontalAlignment.Center;
			NumericUpDown numericUpDown3 = this.numeric;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.numeric.ValueChanged += this.numeric_ValueChanged;
			this.toolStrip.Dock = DockStyle.Bottom;
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[]
			{
				this.buttonShow, this.buttonSave, this.buttonImportImage, this.buttonExportImage, this.toolStripSeparator1, this.buttonImportRx3, this.buttonExportRx3, this.buttonRemoveRx3, this.toolStripSeparator2, this.buttonFullSize,
				this.textSize
			});
			this.toolStrip.Location = new Point(0, 246);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(257, 27);
			this.toolStrip.TabIndex = 2;
			this.buttonShow.Checked = true;
			this.buttonShow.CheckOnClick = true;
			this.buttonShow.CheckState = CheckState.Checked;
			this.buttonShow.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonShow.Image = (Image)componentResourceManager.GetObject("buttonShow.Image");
			this.buttonShow.ImageTransparentColor = Color.Magenta;
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new Size(23, 24);
			this.buttonShow.Text = "Show \\ Hide";
			this.buttonShow.Visible = false;
			this.buttonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSave.Enabled = false;
			this.buttonSave.Image = (Image)componentResourceManager.GetObject("buttonSave.Image");
			this.buttonSave.ImageTransparentColor = Color.Magenta;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new Size(23, 24);
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += this.buttonSave_Click;
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
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(6, 27);
			this.buttonImportRx3.AutoSize = false;
			this.buttonImportRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonImportRx3.Image = (Image)componentResourceManager.GetObject("buttonImportRx3.Image");
			this.buttonImportRx3.ImageTransparentColor = Color.Magenta;
			this.buttonImportRx3.Name = "buttonImportRx3";
			this.buttonImportRx3.Size = new Size(20, 22);
			this.buttonImportRx3.Text = "Import Rx3";
			this.buttonImportRx3.Click += this.buttonImportFsh_Click;
			this.buttonExportRx3.AutoSize = false;
			this.buttonExportRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonExportRx3.Image = (Image)componentResourceManager.GetObject("buttonExportRx3.Image");
			this.buttonExportRx3.ImageTransparentColor = Color.Magenta;
			this.buttonExportRx3.Name = "buttonExportRx3";
			this.buttonExportRx3.Size = new Size(20, 22);
			this.buttonExportRx3.Text = "Export as Rx3";
			this.buttonExportRx3.Click += this.buttonExportRx3_Click;
			this.buttonRemoveRx3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemoveRx3.Image = (Image)componentResourceManager.GetObject("buttonRemoveRx3.Image");
			this.buttonRemoveRx3.ImageTransparentColor = Color.Magenta;
			this.buttonRemoveRx3.Name = "buttonRemoveRx3";
			this.buttonRemoveRx3.Size = new Size(23, 24);
			this.buttonRemoveRx3.Text = "Remove";
			this.buttonRemoveRx3.Click += this.buttonRemoveRx3_Click;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(6, 27);
			this.buttonFullSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonFullSize.Image = (Image)componentResourceManager.GetObject("buttonFullSize.Image");
			this.buttonFullSize.ImageTransparentColor = Color.Magenta;
			this.buttonFullSize.Name = "buttonFullSize";
			this.buttonFullSize.Size = new Size(23, 24);
			this.buttonFullSize.Text = "View Full Size";
			this.buttonFullSize.Visible = false;
			this.buttonFullSize.Click += this.buttonFullSize_Click;
			this.textSize.BackColor = Color.White;
			this.textSize.Name = "textSize";
			this.textSize.ReadOnly = true;
			this.textSize.Size = new Size(70, 27);
			this.textSize.Text = "1024 x 1024";
			this.textSize.TextBoxTextAlign = HorizontalAlignment.Center;
			this.pictureBox.BackgroundImageLayout = ImageLayout.Center;
			this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
			this.pictureBox.Dock = DockStyle.Fill;
			this.pictureBox.Location = new Point(0, 20);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new Size(257, 226);
			this.pictureBox.TabIndex = 3;
			this.pictureBox.TabStop = false;
			this.openFileDialogBmp.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			this.openFileDialogBmp.Title = "Open Image File";
			this.openFileDialogRx3.Filter = "rx3 files (*.rx3)|*.rx3";
			this.openFileDialogRx3.Title = "Open rx3 file";
			this.saveFileDialogBmp.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			this.saveFileDialogBmp.FilterIndex = 2;
			this.saveFileDialogBmp.Title = "Save image as .bmp or .png";
			this.labelOf.AutoSize = true;
			this.labelOf.Location = new Point(107, 4);
			this.labelOf.Name = "labelOf";
			this.labelOf.Size = new Size(24, 17);
			this.labelOf.TabIndex = 4;
			this.labelOf.Text = "of ";
			base.Controls.Add(this.labelOf);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(this.numeric);
			base.Controls.Add(this.label);
			base.Name = "MultiViewer2D";
			base.Size = new Size(257, 273);
			base.Resize += this.MultiViewer2D_Resize;
			((ISupportInitialize)this.numeric).EndInit();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009A RID: 154
		private static FullSizeViewer s_FullSizeViewer = new FullSizeViewer();

		// Token: 0x0400009B RID: 155
		private bool m_AutoTransparency;

		// Token: 0x0400009C RID: 156
		private bool m_CheckBitmapSize;

		// Token: 0x0400009D RID: 157
		private bool m_FixedSize;

		// Token: 0x0400009E RID: 158
		public MultiViewer2D.Rx3SaveHandler Rx3SaveDelegate;

		// Token: 0x0400009F RID: 159
		public MultiViewer2D.Rx3ExportHandler Rx3ExportDelegate;

		// Token: 0x040000A0 RID: 160
		public MultiViewer2D.Rx3ImportHandler Rx3ImportDelegate;

		// Token: 0x040000A1 RID: 161
		public MultiViewer2D.Rx3DeleteHandler Rx3DeleteDelegate;

		// Token: 0x040000A2 RID: 162
		public MultiViewer2D.BitmapUpdateHandler BitmapUpdateDelegate;

		// Token: 0x040000A3 RID: 163
		private int m_CurrentIndex;

		// Token: 0x040000A4 RID: 164
		private Bitmap[] m_Bitmaps;

		// Token: 0x040000A5 RID: 165
		private bool m_NeedToSave;

		// Token: 0x040000A6 RID: 166
		private string m_InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x040000A7 RID: 167
		private IContainer components;

		// Token: 0x040000A8 RID: 168
		private Label label;

		// Token: 0x040000A9 RID: 169
		private ToolStrip toolStrip;

		// Token: 0x040000AA RID: 170
		public ToolStripButton buttonImportImage;

		// Token: 0x040000AB RID: 171
		public ToolStripButton buttonExportImage;

		// Token: 0x040000AC RID: 172
		public ToolStripButton buttonImportRx3;

		// Token: 0x040000AD RID: 173
		public ToolStripButton buttonExportRx3;

		// Token: 0x040000AE RID: 174
		private ToolStripTextBox textSize;

		// Token: 0x040000AF RID: 175
		public PictureBox pictureBox;

		// Token: 0x040000B0 RID: 176
		public ToolStripButton buttonSave;

		// Token: 0x040000B1 RID: 177
		private FolderBrowserDialog folderBrowserDialog;

		// Token: 0x040000B2 RID: 178
		private OpenFileDialog openFileDialogBmp;

		// Token: 0x040000B3 RID: 179
		private OpenFileDialog openFileDialogRx3;

		// Token: 0x040000B4 RID: 180
		private SaveFileDialog saveFileDialogBmp;

		// Token: 0x040000B5 RID: 181
		private Label labelOf;

		// Token: 0x040000B6 RID: 182
		private ToolStripButton buttonRemoveRx3;

		// Token: 0x040000B7 RID: 183
		public ToolStripButton buttonFullSize;

		// Token: 0x040000B8 RID: 184
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000B9 RID: 185
		private ToolStripSeparator toolStripSeparator2;

		// Token: 0x040000BA RID: 186
		public ToolStripButton buttonShow;

		// Token: 0x040000BB RID: 187
		public NumericUpDown numeric;

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060001B2 RID: 434
		public delegate bool Rx3SaveHandler(object sender, Bitmap[] bitmaps);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060001B6 RID: 438
		public delegate bool Rx3ImportHandler(object sender, string rx3FileName);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060001BA RID: 442
		public delegate bool Rx3ExportHandler(object sender, string exportDir);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060001BE RID: 446
		public delegate bool Rx3DeleteHandler(object sender);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060001C2 RID: 450
		public delegate bool BitmapUpdateHandler(object sender);
	}
}
