using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000005 RID: 5
	public partial class ColorSelector : Form
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000369C File Offset: 0x0000189C
		public Color SelectedColor
		{
			get
			{
				return this.m_SelectedColor;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000036A4 File Offset: 0x000018A4
		public int SelectedIndex
		{
			get
			{
				return this.m_SelectedIndex;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000036AC File Offset: 0x000018AC
		public ColorSelector(Color[] palette, int selectedIndex)
		{
			this.InitializeComponent();
			this.m_Palette = palette;
			if (selectedIndex < 0 || selectedIndex >= palette.Length)
			{
				selectedIndex = 0;
			}
			this.m_SelectedColor = this.m_Palette[selectedIndex];
			this.pictureSelectedColor.BackColor = this.m_SelectedColor;
			base.Height = 20 * ((palette.Length - 1) / 8) + 110;
			this.buttonOK.Location = new Point(16, base.Height - 72);
			this.buttonCancel.Location = new Point(104, base.Height - 72);
			int num = 32;
			int num2 = 8;
			this.m_RadioButtons = new RadioButton[palette.Length];
			for (int i = 0; i < palette.Length; i++)
			{
				this.m_RadioButtons[i] = new RadioButton();
				this.m_RadioButtons[i].Location = new Point(num, num2);
				num += 20;
				if ((i + 1) % 8 == 0)
				{
					num = 32;
					num2 += 20;
				}
				this.m_RadioButtons[i].BackColor = palette[i];
				if (palette[i] == Color.Transparent)
				{
					this.m_RadioButtons[i].BackgroundImage = this.pictureBoxHidden.BackgroundImage;
				}
				if (i == selectedIndex)
				{
					this.m_RadioButtons[i].Checked = true;
				}
				this.m_RadioButtons[i].Appearance = Appearance.Button;
				this.m_RadioButtons[i].Text = string.Empty;
				this.m_RadioButtons[i].Width = (this.m_RadioButtons[i].Height = 18);
				this.m_RadioButtons[i].Visible = true;
				this.m_RadioButtons[i].CheckedChanged += this.radio_CheckedChanged;
				base.Controls.Add(this.m_RadioButtons[i]);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003A64 File Offset: 0x00001C64
		private void radio_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			if (radioButton.Checked)
			{
				this.pictureSelectedColor.BackColor = radioButton.BackColor;
				this.m_SelectedColor = radioButton.BackColor;
				if (this.m_SelectedColor == Color.Transparent)
				{
					this.pictureSelectedColor.BackgroundImage = this.pictureBoxHidden.BackgroundImage;
				}
				else
				{
					this.pictureSelectedColor.BackgroundImage = null;
				}
				for (int i = 0; i < this.m_Palette.Length; i++)
				{
					if (this.pictureSelectedColor.BackColor == this.m_RadioButtons[i].BackColor)
					{
						this.m_SelectedIndex = i;
						return;
					}
				}
			}
		}

		// Token: 0x04000024 RID: 36
		private Color m_SelectedColor;

		// Token: 0x04000025 RID: 37
		private Color[] m_Palette;

		// Token: 0x04000026 RID: 38
		private int m_SelectedIndex;

		// Token: 0x04000028 RID: 40
		private RadioButton[] m_RadioButtons;
	}
}
