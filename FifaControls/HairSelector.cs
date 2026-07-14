using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000006 RID: 6
	public partial class HairSelector : Form
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00003B18 File Offset: 0x00001D18
		public int HairType
		{
			get
			{
				return this.m_HairType;
			}
			set
			{
				this.m_HairType = value;
				this.labelHairFrontSelected.ImageIndex = this.m_HairType;
				this.labelHairSideSelected.ImageIndex = this.m_HairType;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003B44 File Offset: 0x00001D44
		public void Sort()
		{
			int num = 64;
			for (int i = 0; i < 125; i++)
			{
				int num2 = this.m_HairSorting[i];
				int num3 = i / 14;
				int num4 = i % 14;
				this.m_PicturBox[num2].Location = new Point(num4 * num, 2 + num3 * num);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003B90 File Offset: 0x00001D90
		public HairSelector()
		{
			this.InitializeComponent();
			int num = 64;
			for (int i = 0; i < 125; i++)
			{
				int num2 = this.m_HairSorting[i];
				int num3 = num2 / 14;
				int num4 = num2 % 14;
				this.m_PicturBox[i] = new PictureBox();
				this.m_PicturBox[i].Name = "pictureBox" + i.ToString();
				this.m_PicturBox[i].Text = "pictureBox" + i.ToString();
				Control control = this.m_PicturBox[i];
				int num5 = num;
				control.Size = new Size(num5, num5);
				this.m_PicturBox[i].Dock = DockStyle.None;
				this.m_PicturBox[i].BorderStyle = BorderStyle.Fixed3D;
				this.m_PicturBox[i].Cursor = Cursors.Default;
				if (i < this.imageListHairSide.Images.Count)
				{
					this.m_PicturBox[i].BackgroundImage = this.imageListHairSide.Images[i];
					this.m_PicturBox[i].BackgroundImageLayout = ImageLayout.Zoom;
				}
				this.m_PicturBox[i].MouseEnter += this.pictureBox_MouseEnter;
				this.m_PicturBox[i].Click += this.pictureBox_Click;
				base.Controls.Add(this.m_PicturBox[i]);
			}
			this.Sort();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003D14 File Offset: 0x00001F14
		private void pictureBox_MouseEnter(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			int num = Convert.ToInt32(pictureBox.Name.Substring(10, pictureBox.Name.Length - 10));
			this.labelHairFrontCurrent.ImageIndex = num;
			this.labelHairSideCurrent.ImageIndex = num;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003D64 File Offset: 0x00001F64
		private void pictureBox_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			int num = Convert.ToInt32(pictureBox.Name.Substring(10, pictureBox.Name.Length - 10));
			this.labelHairFrontSelected.ImageIndex = num;
			this.labelHairSideSelected.ImageIndex = num;
			this.m_HairType = num;
		}

		// Token: 0x04000029 RID: 41
		private PictureBox[] m_PicturBox = new PictureBox[125];

		// Token: 0x0400002A RID: 42
		private int[] m_HairSorting = new int[]
		{
			0, 41, 25, 1, 26, 46, 43, 29, 120, 72,
			92, 47, 114, 112, 117, 28, 86, 16, 113, 45,
			65, 60, 63, 88, 123, 21, 2, 77, 40, 31,
			17, 115, 122, 105, 100, 82, 75, 89, 19, 102,
			106, 54, 36, 30, 93, 57, 66, 32, 124, 18,
			119, 42, 78, 111, 118, 67, 14, 68, 37, 90,
			39, 61, 101, 64, 70, 15, 24, 94, 121, 38,
			107, 116, 58, 104, 108, 83, 98, 23, 95, 20,
			62, 85, 69, 35, 13, 59, 34, 10, 74, 73,
			103, 99, 12, 55, 9, 22, 87, 52, 79, 51,
			8, 44, 56, 84, 80, 91, 81, 76, 49, 33,
			11, 97, 27, 96, 3, 71, 4, 110, 109, 5,
			6, 53, 7, 48, 50
		};

		// Token: 0x0400002B RID: 43
		private int m_LastId = -1;

		// Token: 0x0400002C RID: 44
		private int m_HairType;
	}
}
