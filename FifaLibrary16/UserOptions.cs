using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x020000A1 RID: 161
	public partial class UserOptions : Form
	{
		// Token: 0x06000EC8 RID: 3784 RVA: 0x00056EB0 File Offset: 0x000550B0
		public UserOptions()
		{
			this.InitializeComponent();
			string currentDirectory = Environment.CurrentDirectory;
			this.m_XmlFileName = currentDirectory + "\\Options.xml";
			if (!File.Exists(this.m_XmlFileName))
			{
				return;
			}
			this.optionsSet.ReadXml(this.m_XmlFileName);
			this.LoadOptions();
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00056F37 File Offset: 0x00055137
		public DialogResult ShowOptions()
		{
			this.LoadOptions();
			return base.ShowDialog();
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00056F48 File Offset: 0x00055148
		private void LoadOptions()
		{
			for (int i = 0; i < this.optionsSet.DataTableOpt.Count; i++)
			{
				string option = this.optionsSet.DataTableOpt[i].Option;
				string value = this.optionsSet.DataTableOpt[i].Value;
				int num;
				try
				{
					num = Convert.ToInt32(value);
				}
				catch
				{
					num = 0;
				}
				bool flag = num != 0;
				string @default = this.optionsSet.DataTableOpt[i].Default;
				if (option == "ExportFolderAuto")
				{
					this.checkAutoExportFolder.Checked = flag;
					this.m_AutoExportFolder = flag;
					this.textExportFolder.Enabled = !flag;
					this.buttonBrowseExportFolder.Enabled = !flag;
				}
				else if (option == "ExportFolder")
				{
					this.textExportFolder.Text = value;
					this.m_ExportFolder = value;
				}
				else if (option == "DatabaseEditing")
				{
					this.checkSaveDb.Checked = flag;
					this.m_SaveDatabase = flag;
				}
				else if (option == "ZdataEditing")
				{
					this.checkSaveZdata.Checked = flag;
					this.m_SaveZdata = flag;
				}
				else if (option == "GuiEditing")
				{
					this.checkSaveGui.Checked = flag;
					this.m_SaveGui = flag;
				}
				else if (option == "AutoZdata")
				{
					this.radioAutoZdata.Checked = flag;
					this.m_AutoZdata = flag;
					if (this.m_AutoZdata)
					{
						this.m_SpecificZdata = false;
						this.m_SaveZdataInFolder = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "SpecificZdata")
				{
					this.radioSpecificZdata.Checked = flag;
					this.m_SpecificZdata = flag;
					if (this.m_SpecificZdata)
					{
						this.m_AutoZdata = false;
						this.m_SaveZdataInFolder = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "SaveZdataInFolder")
				{
					this.radioZdataSaveFolder.Checked = flag;
					this.m_SaveZdataInFolder = flag;
					if (this.m_SaveZdataInFolder)
					{
						this.m_AutoZdata = false;
						this.m_SpecificZdata = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "ZdataNumber")
				{
					this.numericZdata.Value = num;
					this.m_ZdataNumber = num;
				}
				else if (option == "SaveGuiInArchive")
				{
					this.radioGuiSaveArchive.Checked = flag;
					this.m_SaveGuiInArchive = flag;
					this.m_SaveGuiInFolder = !flag;
				}
				else if (option == "SaveGuiInFolder")
				{
					this.radioGuiSaveFolder.Checked = flag;
					this.m_SaveGuiInArchive = !flag;
					this.m_SaveGuiInFolder = flag;
				}
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00057230 File Offset: 0x00055430
		private void buttonBrowseExportFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select the export folder";
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				folderBrowserDialog.Dispose();
				return;
			}
			this.textExportFolder.Text = folderBrowserDialog.SelectedPath;
			this.m_ExportFolder = this.textExportFolder.Text;
			folderBrowserDialog.Dispose();
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0005728D File Offset: 0x0005548D
		private void checkEditDb_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveDatabase = this.checkSaveDb.Checked;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000572A0 File Offset: 0x000554A0
		private void textExportFolder_TextChanged(object sender, EventArgs e)
		{
			this.m_ExportFolder = this.textExportFolder.Text;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000572B3 File Offset: 0x000554B3
		private void checkEditZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveZdata = this.checkSaveZdata.Checked;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000572C6 File Offset: 0x000554C6
		private void checkEditGui_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGui = this.checkSaveGui.Checked;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000572D9 File Offset: 0x000554D9
		private void radioAutoZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_AutoZdata = this.radioAutoZdata.Checked;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000572EC File Offset: 0x000554EC
		private void radioSpecificZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SpecificZdata = this.radioSpecificZdata.Checked;
			this.numericZdata.Enabled = this.radioSpecificZdata.Checked;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00057315 File Offset: 0x00055515
		private void numericZdata_ValueChanged(object sender, EventArgs e)
		{
			this.m_ZdataNumber = (int)this.numericZdata.Value;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0005732D File Offset: 0x0005552D
		private void radioGuiSaveArchive_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGuiInArchive = this.radioGuiSaveArchive.Checked;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00057340 File Offset: 0x00055540
		private void radioGuiSaveFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGuiInFolder = this.radioGuiSaveFolder.Checked;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00057354 File Offset: 0x00055554
		private void SaveOptions()
		{
			for (int i = 0; i < this.optionsSet.DataTableOpt.Count; i++)
			{
				string option = this.optionsSet.DataTableOpt[i].Option;
				if (option == "ExportFolderAuto")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_AutoExportFolder ? "1" : "0");
				}
				else if (option == "ExportFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = this.m_ExportFolder;
				}
				else if (option == "DatabaseEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveDatabase ? "1" : "0");
				}
				else if (option == "ZdataEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveZdata ? "1" : "0");
				}
				else if (option == "GuiEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGui ? "1" : "0");
				}
				else if (option == "AutoZdata")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_AutoZdata ? "1" : "0");
				}
				else if (option == "SpecificZdata")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SpecificZdata ? "1" : "0");
				}
				else if (option == "ZdataNumber")
				{
					this.optionsSet.DataTableOpt[i].Value = this.m_ZdataNumber.ToString();
				}
				else if (option == "SaveZdataInFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveZdataInFolder ? "1" : "0");
				}
				else if (option == "SaveGuiInArchive")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGuiInArchive ? "1" : "0");
				}
				else if (option == "SaveGuiInFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGuiInFolder ? "1" : "0");
				}
			}
			this.optionsSet.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0005761C File Offset: 0x0005581C
		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.SaveOptions();
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00057624 File Offset: 0x00055824
		private void checkAutoExportFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_AutoExportFolder = this.checkAutoExportFolder.Checked;
			this.textExportFolder.Enabled = !this.checkAutoExportFolder.Checked;
			this.buttonBrowseExportFolder.Enabled = !this.checkAutoExportFolder.Checked;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0005761C File Offset: 0x0005581C
		private void UserOptions_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveOptions();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00057674 File Offset: 0x00055874
		private void radioZdataSaveFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveZdataInFolder = this.radioZdataSaveFolder.Checked;
		}

		// Token: 0x040011C6 RID: 4550
		private string m_XmlFileName;

		// Token: 0x040011C7 RID: 4551
		public bool m_AutoExportFolder = true;

		// Token: 0x040011C8 RID: 4552
		public string m_ExportFolder;

		// Token: 0x040011C9 RID: 4553
		public bool m_SaveDatabase = true;

		// Token: 0x040011CA RID: 4554
		public bool m_SaveGui = true;

		// Token: 0x040011CB RID: 4555
		public bool m_SaveZdata = true;

		// Token: 0x040011CC RID: 4556
		public bool m_AutoZdata = true;

		// Token: 0x040011CD RID: 4557
		public bool m_SpecificZdata;

		// Token: 0x040011CE RID: 4558
		public bool m_SaveZdataInFolder = true;

		// Token: 0x040011CF RID: 4559
		public int m_ZdataNumber;

		// Token: 0x040011D0 RID: 4560
		public bool m_SaveGuiInArchive;

		// Token: 0x040011D1 RID: 4561
		public bool m_SaveGuiInFolder = true;
	}
}
