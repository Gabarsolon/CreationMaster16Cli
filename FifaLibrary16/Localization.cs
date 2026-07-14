using System;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000021 RID: 33
	public class Localization
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000841C File Offset: 0x0000661C
		public ResXResourceSet ResxSet
		{
			get
			{
				return this.m_ResxSet;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008424 File Offset: 0x00006624
		public Localization()
		{
			string currentDirectory = Environment.CurrentDirectory;
			string twoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			this.m_LanguageFileName = currentDirectory + "\\Language." + twoLetterISOLanguageName + ".resx";
			this.m_LanguageDefaultFileName = currentDirectory + "\\Language.resx";
			if (File.Exists(this.m_LanguageFileName))
			{
				this.m_ResxSet = new ResXResourceSet(this.m_LanguageFileName);
				return;
			}
			if (File.Exists(this.m_LanguageFileName))
			{
				this.m_ResxSet = new ResXResourceSet(this.m_LanguageDefaultFileName);
				return;
			}
			this.m_ResxSet = null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000084B8 File Offset: 0x000066B8
		public string GetString(string s)
		{
			if (this.m_ResxSet == null)
			{
				return s;
			}
			string text = "_" + s;
			return this.m_ResxSet.GetString(text);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000084E8 File Offset: 0x000066E8
		public void LocalizeControl(Control control)
		{
			string @string = this.GetString(control.Text);
			if (@string != null)
			{
				control.Text = @string;
			}
			if (control.GetType().Name == "ListView")
			{
				foreach (object obj in ((ListView)control).Columns)
				{
					ColumnHeader columnHeader = (ColumnHeader)obj;
					columnHeader.Text = this.GetString(columnHeader.Text);
				}
			}
			foreach (object obj2 in control.Controls)
			{
				Control control2 = (Control)obj2;
				this.LocalizeControl(control2);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000085CC File Offset: 0x000067CC
		public void LocalizeMenu(MenuStrip menu)
		{
			foreach (object obj in menu.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				this.LocalizeMenuItem(toolStripMenuItem);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008628 File Offset: 0x00006828
		public void LocalizeMenuItem(ToolStripMenuItem menuItem)
		{
			string @string = this.GetString(menuItem.Text);
			if (@string != null)
			{
				menuItem.Text = @string;
			}
			foreach (object obj in menuItem.DropDownItems)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				this.LocalizeMenuItem(toolStripMenuItem);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008698 File Offset: 0x00006898
		public void LocalizeToolStrip(ToolStrip toolStrip)
		{
			foreach (object obj in toolStrip.Items)
			{
				ToolStripItem toolStripItem = (ToolStripItem)obj;
				this.LocalizeToolStripItem(toolStripItem);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000086F4 File Offset: 0x000068F4
		public void LocalizeToolStripItem(ToolStripItem toolStripItem)
		{
			string text = this.GetString(toolStripItem.Text);
			if (text != null)
			{
				toolStripItem.Text = text;
			}
			text = this.GetString(toolStripItem.ToolTipText);
			if (text != null)
			{
				toolStripItem.ToolTipText = text;
			}
			try
			{
				foreach (object obj in ((ToolStripDropDownItem)toolStripItem).DropDownItems)
				{
					ToolStripItem toolStripItem2 = (ToolStripItem)obj;
					this.LocalizeToolStripItem(toolStripItem2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400005E RID: 94
		private string m_LanguageFileName;

		// Token: 0x0400005F RID: 95
		private string m_LanguageDefaultFileName;

		// Token: 0x04000060 RID: 96
		private ResXResourceSet m_ResxSet;
	}
}
