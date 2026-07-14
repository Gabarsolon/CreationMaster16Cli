using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000017 RID: 23
	public class SearchTool : UserControl
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000F260 File Offset: 0x0000D460
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000F26D File Offset: 0x0000D46D
		[Category("User")]
		[Description("Width of the text box.")]
		public int TextWidth
		{
			get
			{
				return this.textBox.Width;
			}
			set
			{
				this.textBox.Size = new Size(value, this.textBox.Height);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000F28B File Offset: 0x0000D48B
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000F293 File Offset: 0x0000D493
		public ArrayList ObjectList
		{
			get
			{
				return this.m_ObjectList;
			}
			set
			{
				this.m_ObjectList = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000F29C File Offset: 0x0000D49C
		public object FoundObject
		{
			get
			{
				return this.m_FoundObject;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		public bool HasFound
		{
			get
			{
				return this.m_HasFound;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public bool IsCaseSensitive
		{
			get
			{
				return this.m_CaseSensitive;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public int CurrentIndex
		{
			get
			{
				return this.m_CurrentIndex;
			}
			set
			{
				this.m_CurrentIndex = value;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000F2C5 File Offset: 0x0000D4C5
		public SearchTool()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000F2DA File Offset: 0x0000D4DA
		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				this.Search();
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000F2ED File Offset: 0x0000D4ED
		private void buttonSearchExact_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchExact;
			this.Search();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000F2FD File Offset: 0x0000D4FD
		private void buttonSearchStart_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchStarting;
			this.Search();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000F30D File Offset: 0x0000D50D
		private void buttonSearchContain_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchContaining;
			this.Search();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000F320 File Offset: 0x0000D520
		public bool Search()
		{
			this.m_Pattern = this.textBox.Text;
			if (!this.IsCaseSensitive)
			{
				this.m_Pattern = this.m_Pattern.ToLower();
			}
			int num = this.m_CurrentIndex;
			num++;
			if (num == this.m_ObjectList.Count)
			{
				num = 0;
			}
			for (;;)
			{
				string text = this.m_ObjectList[num].ToString();
				if (!this.IsCaseSensitive)
				{
					text = text.ToLower();
				}
				switch (this.m_SearchMode)
				{
				case SearchTool.SearchMode.SearchExact:
					this.m_HasFound = text.ToString().Equals(this.m_Pattern);
					break;
				case SearchTool.SearchMode.SearchStarting:
					this.m_HasFound = text.ToString().StartsWith(this.m_Pattern);
					break;
				case SearchTool.SearchMode.SearchContaining:
					this.m_HasFound = text.Contains(this.m_Pattern);
					break;
				}
				if (this.m_HasFound)
				{
					break;
				}
				if (num == this.m_CurrentIndex)
				{
					goto IL_0127;
				}
				num++;
				if (num == this.m_ObjectList.Count)
				{
					num = 0;
				}
			}
			this.m_FoundObject = this.m_ObjectList[num];
			this.m_CurrentIndex = num;
			if (this.CallBack != null)
			{
				this.CallBack(this, this.m_FoundObject);
			}
			return true;
			IL_0127:
			this.m_FoundObject = null;
			this.CallBack(this, null);
			return false;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000F469 File Offset: 0x0000D669
		private void buttonCaseSensitive_Click(object sender, EventArgs e)
		{
			this.m_CaseSensitive = this.buttonCaseSensitive.Checked;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000F47C File Offset: 0x0000D67C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000F49C File Offset: 0x0000D69C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SearchTool));
			this.toolStrip = new ToolStrip();
			this.textBox = new ToolStripTextBox();
			this.buttonCaseSensitive = new ToolStripButton();
			this.buttonSearchContain = new ToolStripButton();
			this.buttonSearchStart = new ToolStripButton();
			this.buttonSearchExact = new ToolStripButton();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[] { this.buttonCaseSensitive, this.textBox, this.buttonSearchExact, this.buttonSearchStart, this.buttonSearchContain });
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(345, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.textBox.Name = "textBox";
			this.textBox.Size = new Size(200, 25);
			this.textBox.ToolTipText = "Type the string to search";
			this.textBox.KeyDown += this.textBox_KeyDown;
			this.buttonCaseSensitive.CheckOnClick = true;
			this.buttonCaseSensitive.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonCaseSensitive.Image = (Image)componentResourceManager.GetObject("buttonCaseSensitive.Image");
			this.buttonCaseSensitive.ImageTransparentColor = Color.Magenta;
			this.buttonCaseSensitive.Name = "buttonCaseSensitive";
			this.buttonCaseSensitive.RightToLeft = RightToLeft.No;
			this.buttonCaseSensitive.Size = new Size(23, 22);
			this.buttonCaseSensitive.ToolTipText = "case sensitive search";
			this.buttonCaseSensitive.Click += this.buttonCaseSensitive_Click;
			this.buttonSearchContain.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchContain.Image = (Image)componentResourceManager.GetObject("buttonSearchContain.Image");
			this.buttonSearchContain.ImageTransparentColor = Color.Magenta;
			this.buttonSearchContain.Name = "buttonSearchContain";
			this.buttonSearchContain.Size = new Size(23, 22);
			this.buttonSearchContain.Text = "Search if contains";
			this.buttonSearchContain.Click += this.buttonSearchContain_Click;
			this.buttonSearchStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchStart.Image = (Image)componentResourceManager.GetObject("buttonSearchStart.Image");
			this.buttonSearchStart.ImageTransparentColor = Color.Magenta;
			this.buttonSearchStart.Name = "buttonSearchStart";
			this.buttonSearchStart.Size = new Size(23, 22);
			this.buttonSearchStart.Text = "Search if starts with";
			this.buttonSearchStart.Click += this.buttonSearchStart_Click;
			this.buttonSearchExact.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchExact.Image = (Image)componentResourceManager.GetObject("buttonSearchExact.Image");
			this.buttonSearchExact.ImageTransparentColor = Color.Magenta;
			this.buttonSearchExact.Name = "buttonSearchExact";
			this.buttonSearchExact.Size = new Size(23, 22);
			this.buttonSearchExact.Text = "Search exactly";
			this.buttonSearchExact.Click += this.buttonSearchExact_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoSize = true;
			base.Controls.Add(this.toolStrip);
			base.Name = "SearchTool";
			base.Size = new Size(345, 25);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000124 RID: 292
		private ArrayList m_ObjectList;

		// Token: 0x04000125 RID: 293
		private object m_FoundObject;

		// Token: 0x04000126 RID: 294
		private bool m_HasFound;

		// Token: 0x04000127 RID: 295
		private bool m_CaseSensitive;

		// Token: 0x04000128 RID: 296
		private int m_CurrentIndex;

		// Token: 0x04000129 RID: 297
		private string m_Pattern;

		// Token: 0x0400012A RID: 298
		private SearchTool.SearchMode m_SearchMode = SearchTool.SearchMode.SearchContaining;

		// Token: 0x0400012B RID: 299
		[Category("Event")]
		[Description("Search done.")]
		public SearchTool.SearchEventHandler CallBack;

		// Token: 0x0400012C RID: 300
		private IContainer components;

		// Token: 0x0400012D RID: 301
		private ToolStrip toolStrip;

		// Token: 0x0400012E RID: 302
		public ToolStripTextBox textBox;

		// Token: 0x0400012F RID: 303
		public ToolStripButton buttonSearchExact;

		// Token: 0x04000130 RID: 304
		public ToolStripButton buttonSearchStart;

		// Token: 0x04000131 RID: 305
		public ToolStripButton buttonSearchContain;

		// Token: 0x04000132 RID: 306
		public ToolStripButton buttonCaseSensitive;

		// Token: 0x0200002B RID: 43
		private enum SearchMode
		{
			// Token: 0x040001D9 RID: 473
			SearchExact,
			// Token: 0x040001DA RID: 474
			SearchStarting,
			// Token: 0x040001DB RID: 475
			SearchContaining
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060001CE RID: 462
		public delegate void SearchEventHandler(object sender, object obj);
	}
}
