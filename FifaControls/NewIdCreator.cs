using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000010 RID: 16
	public partial class NewIdCreator : Form
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000BD07 File Offset: 0x00009F07
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000BD0F File Offset: 0x00009F0F
		public IdObject NewObject
		{
			get
			{
				return this.m_NewObject;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000BD17 File Offset: 0x00009F17
		public string NewName
		{
			get
			{
				return this.m_NewName;
			}
		}

		// Token: 0x1700001F RID: 31
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000BD20 File Offset: 0x00009F20
		public IdArrayList IdList
		{
			set
			{
				this.m_IdArrayList = value;
				if (this.m_IdArrayList != null)
				{
					this.numericSpecificId.Minimum = this.m_IdArrayList.MinId;
					this.numericSpecificId.Maximum = this.m_IdArrayList.MaxId;
					this.labelMinMax.Text = this.m_IdArrayList.MinId.ToString() + " - " + this.m_IdArrayList.MaxId.ToString();
					if (this.numericSpecificId.Value < this.numericSpecificId.Minimum)
					{
						this.numericSpecificId.Value = this.numericSpecificId.Minimum;
						return;
					}
					if (this.numericSpecificId.Value > this.numericSpecificId.Maximum)
					{
						this.numericSpecificId.Value = this.numericSpecificId.Maximum;
						return;
					}
				}
				else
				{
					this.numericSpecificId.Minimum = -1m;
					this.numericSpecificId.Maximum = -1m;
					this.numericSpecificId.Value = -1m;
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000BE48 File Offset: 0x0000A048
		public NewIdCreator()
		{
			this.InitializeComponent();
			this.numericSpecificId.Enabled = this.radioSpacificId.Checked;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000BE80 File Offset: 0x0000A080
		private void radioSpacificId_CheckedChanged(object sender, EventArgs e)
		{
			this.numericSpecificId.Enabled = this.radioSpacificId.Checked;
			if (this.radioSpacificId.Checked)
			{
				this.m_NewId = (int)this.numericSpecificId.Value;
				this.m_NewName = null;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000BECD File Offset: 0x0000A0CD
		private void radioAuto_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioAuto.Checked)
			{
				this.m_NewId = -1;
				this.m_NewName = null;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000BEEA File Offset: 0x0000A0EA
		private void numericSpecificId_ValueChanged(object sender, EventArgs e)
		{
			if (this.radioSpacificId.Checked)
			{
				this.m_NewId = (int)this.numericSpecificId.Value;
				this.m_NewName = null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000BF16 File Offset: 0x0000A116
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.m_IdArrayList == null)
			{
				this.m_NewObject = null;
				return;
			}
			this.m_NewObject = ((this.m_NewId < 0) ? this.m_IdArrayList.CreateNewId() : this.m_IdArrayList.CreateNewId(this.m_NewId));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000BF55 File Offset: 0x0000A155
		private void button1_Click(object sender, EventArgs e)
		{
			this.m_NewObject = null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000BF60 File Offset: 0x0000A160
		private void radioCms_CheckedChanged(object sender, EventArgs e)
		{
			this.textCms.Enabled = this.radioCms.Checked;
			this.treeViewCms.Enabled = this.radioCms.Checked;
			if (this.radioCms.Checked)
			{
				this.treeViewCms_AfterSelect(null, null);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		private void treeViewCms_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode selectedNode = this.treeViewCms.SelectedNode;
			if (selectedNode == null)
			{
				this.m_NewId = -1;
				this.textCms.Text = string.Empty;
				this.m_NewName = null;
				return;
			}
			if (selectedNode.Level == 1)
			{
				this.m_NewId = Convert.ToInt32(this.treeViewCms.SelectedNode.Tag);
				this.textCms.Text = selectedNode.Text;
				this.m_NewName = this.textCms.Text;
			}
		}

		// Token: 0x040000BC RID: 188
		private int m_NewId = -1;

		// Token: 0x040000BD RID: 189
		private IdObject m_NewObject;

		// Token: 0x040000BE RID: 190
		public string m_NewName;

		// Token: 0x040000BF RID: 191
		private string m_CmsFileName;

		// Token: 0x040000C0 RID: 192
		private CmsDataSet m_CmsDataSet = new CmsDataSet();

		// Token: 0x040000C1 RID: 193
		private IdArrayList m_IdArrayList;
	}
}
