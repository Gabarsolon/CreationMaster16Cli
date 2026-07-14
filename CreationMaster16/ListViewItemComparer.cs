using System;
using System.Collections;
using System.Windows.Forms;

namespace CreationMaster
{
	// Token: 0x02000013 RID: 19
	internal class ListViewItemComparer : IComparer
	{
		// Token: 0x06000338 RID: 824 RVA: 0x000549B1 File Offset: 0x00052BB1
		public ListViewItemComparer()
		{
			this.col = 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000549C0 File Offset: 0x00052BC0
		public ListViewItemComparer(int column, SortOrder sortOrder)
		{
			this.col = column;
			this.m_SortOrder = sortOrder;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000549D8 File Offset: 0x00052BD8
		public int Compare(object x, object y)
		{
			if (this.m_SortOrder == SortOrder.Ascending)
			{
				return string.Compare(((ListViewItem)x).SubItems[this.col].Text, ((ListViewItem)y).SubItems[this.col].Text);
			}
			return string.Compare(((ListViewItem)y).SubItems[this.col].Text, ((ListViewItem)x).SubItems[this.col].Text);
		}

		// Token: 0x0400053E RID: 1342
		private int col;

		// Token: 0x0400053F RID: 1343
		private SortOrder m_SortOrder;
	}
}
