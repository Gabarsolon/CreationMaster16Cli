using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000B RID: 11
	public class ViewCompetitionSetting : UserControl
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00009B23 File Offset: 0x00007D23
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00009B2C File Offset: 0x00007D2C
		[Category("User")]
		[Description("Settings")]
		public CompetitionSettings Settings
		{
			get
			{
				return this.m_CompetitionSettings;
			}
			set
			{
				this.m_CompetitionSettings = value;
				if (this.m_CompetitionSettings != null)
				{
					this.textBox.Text = this.m_CompetitionSettings.GetProperty(this.m_Description, this.m_Index, out this.m_IsSpecific);
					this.check.Checked = this.m_IsSpecific;
					return;
				}
				this.textBox.Text = string.Empty;
				this.check.Checked = false;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00009B9E File Offset: 0x00007D9E
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00009BA6 File Offset: 0x00007DA6
		[Category("User")]
		[Description("Index")]
		public int Index
		{
			get
			{
				return this.m_Index;
			}
			set
			{
				this.m_Index = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00009BAF File Offset: 0x00007DAF
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00009BB7 File Offset: 0x00007DB7
		[Category("User")]
		[Description("Description")]
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
				this.label.Text = this.m_Description;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009BD1 File Offset: 0x00007DD1
		public ViewCompetitionSetting()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009BE0 File Offset: 0x00007DE0
		private void check_CheckedChanged(object sender, EventArgs e)
		{
			if (this.check.Checked)
			{
				this.label.BackColor = Color.LightGreen;
				this.label.ForeColor = Color.Black;
				this.textBox.Enabled = true;
				return;
			}
			this.m_CompetitionSettings.UnsetProperty(this.m_Description);
			this.textBox.Text = this.m_CompetitionSettings.GetProperty(this.m_Description, this.m_Index, out this.m_IsSpecific);
			this.textBox.Enabled = false;
			this.label.BackColor = Color.Gray;
			this.label.BackColor = Color.DarkGray;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009C8C File Offset: 0x00007E8C
		private void textBox_TextChanged(object sender, EventArgs e)
		{
			bool @checked = this.check.Checked;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009C9A File Offset: 0x00007E9A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009CBC File Offset: 0x00007EBC
		private void InitializeComponent()
		{
			this.check = new CheckBox();
			this.label = new Label();
			this.textBox = new TextBox();
			base.SuspendLayout();
			this.check.AutoSize = true;
			this.check.Dock = DockStyle.Left;
			this.check.Location = new Point(0, 0);
			this.check.Name = "check";
			this.check.Size = new Size(15, 20);
			this.check.TabIndex = 0;
			this.check.UseVisualStyleBackColor = true;
			this.check.CheckedChanged += this.check_CheckedChanged;
			this.label.BackColor = Color.Transparent;
			this.label.Dock = DockStyle.Fill;
			this.label.Location = new Point(15, 0);
			this.label.Name = "label";
			this.label.Size = new Size(368, 20);
			this.label.TabIndex = 1;
			this.label.Text = "Description";
			this.label.TextAlign = ContentAlignment.MiddleLeft;
			this.textBox.Dock = DockStyle.Right;
			this.textBox.Location = new Point(266, 0);
			this.textBox.Name = "textBox";
			this.textBox.Size = new Size(117, 20);
			this.textBox.TabIndex = 2;
			this.textBox.TextAlign = HorizontalAlignment.Center;
			this.textBox.TextChanged += this.textBox_TextChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.textBox);
			base.Controls.Add(this.label);
			base.Controls.Add(this.check);
			base.Name = "CompetitionSetting";
			base.Size = new Size(383, 20);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000082 RID: 130
		private CompetitionSettings m_CompetitionSettings;

		// Token: 0x04000083 RID: 131
		private string m_Description;

		// Token: 0x04000084 RID: 132
		private int m_Index;

		// Token: 0x04000085 RID: 133
		private bool m_IsSpecific;

		// Token: 0x04000086 RID: 134
		private IContainer components;

		// Token: 0x04000087 RID: 135
		private CheckBox check;

		// Token: 0x04000088 RID: 136
		public Label label;

		// Token: 0x04000089 RID: 137
		public TextBox textBox;
	}
}
