using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000004 RID: 4
	public partial class CmsBrowser : Form
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000031D2 File Offset: 0x000013D2
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000031DA File Offset: 0x000013DA
		public string NewName
		{
			get
			{
				return this.m_NewName;
			}
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000031E4 File Offset: 0x000013E4
		public string CmsFileName
		{
			set
			{
				this.m_CmsFileName = value;
				if (File.Exists(this.m_CmsFileName))
				{
					this.m_CmsDataSet.Tables.Clear();
					this.m_CmsDataSet.Relations.Clear();
					this.m_CmsDataSet.ReadXml(this.m_CmsFileName);
					this.treeViewCms.Nodes.Clear();
					string text = string.Empty;
					TreeNode treeNode = null;
					foreach (object obj in this.m_CmsDataSet.Tables["CmsDataTable"].Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (dataRow["Group"].ToString() != text)
						{
							text = dataRow["Group"].ToString();
							treeNode = this.treeViewCms.Nodes.Add(text);
						}
						treeNode.Nodes.Add(dataRow["Name"].ToString()).Tag = dataRow["Id"];
					}
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003314 File Offset: 0x00001514
		public CmsBrowser()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003334 File Offset: 0x00001534
		private void treeViewCms_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode selectedNode = this.treeViewCms.SelectedNode;
			if (selectedNode == null)
			{
				this.m_NewId = -1;
				this.m_NewName = null;
				return;
			}
			if (selectedNode.Level == 1)
			{
				this.m_NewId = Convert.ToInt32(this.treeViewCms.SelectedNode.Tag);
				this.m_NewName = selectedNode.Text;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000338F File Offset: 0x0000158F
		private void treeViewCms_DoubleClick(object sender, EventArgs e)
		{
			this.buttonOK.PerformClick();
		}

		// Token: 0x04000017 RID: 23
		private int m_NewId = -1;

		// Token: 0x04000018 RID: 24
		public string m_NewName;

		// Token: 0x04000019 RID: 25
		private string m_CmsFileName;

		// Token: 0x0400001A RID: 26
		private CmsDataSet m_CmsDataSet = new CmsDataSet();
	}
}
