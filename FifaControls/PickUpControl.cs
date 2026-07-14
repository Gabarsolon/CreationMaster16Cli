using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000012 RID: 18
	public class PickUpControl : UserControl
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000CF6A File Offset: 0x0000B16A
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000CF72 File Offset: 0x0000B172
		[Category("User")]
		[Description("Array List to show")]
		public IdArrayList ObjectList
		{
			get
			{
				return this.m_ObjectList;
			}
			set
			{
				object selectedItem = this.combo.SelectedItem;
				this.m_ObjectList = value;
				if (this.m_ObjectList != null)
				{
					this.FilterObjects();
					return;
				}
				this.combo.Items.Clear();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000CFAE File Offset: 0x0000B1AE
		[Category("User")]
		[Description("Enable the main selection combo box")]
		public bool MainSelectionEnabled
		{
			get
			{
				return this.m_MainSelectionEnabled;
			}
			set
			{
				this.m_MainSelectionEnabled = value;
				this.combo.Visible = value;
				this.separatorBegin.Visible = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000CFCF File Offset: 0x0000B1CF
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000CFD7 File Offset: 0x0000B1D7
		[Category("User")]
		[Description("Enable the filter tools")]
		public bool FilterEnabled
		{
			get
			{
				return this.m_FilterEnabled;
			}
			set
			{
				this.m_FilterEnabled = value;
				this.labelFilter.Visible = value;
				this.comboFilterBy.Visible = value;
				this.comboFilterValue.Visible = value;
				this.separatorFilter.Visible = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000D010 File Offset: 0x0000B210
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000D018 File Offset: 0x0000B218
		[Category("User")]
		[Description("Enable the Young Players chack")]
		public bool YoungPlayersEnabled
		{
			get
			{
				return this.m_YoungPlayersEnabled;
			}
			set
			{
				this.m_YoungPlayersEnabled = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000D021 File Offset: 0x0000B221
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000D02C File Offset: 0x0000B22C
		[Category("User")]
		[Description("Enable the search tools")]
		public bool SearchEnabled
		{
			get
			{
				return this.m_SearchEnabled;
			}
			set
			{
				this.m_SearchEnabled = value;
				this.buttonSearchContain.Visible = value;
				this.buttonSearchExactly.Visible = value;
				this.buttonSearchStart.Visible = value;
				this.textSearch.Visible = value;
				this.buttonCaseSensitive.Visible = value;
				this.separatorSearch.Visible = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000D088 File Offset: 0x0000B288
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000D090 File Offset: 0x0000B290
		[Category("User")]
		[Description("Enable the create button")]
		public bool CreateButtonEnabled
		{
			get
			{
				return this.m_CreateButtonEnabled;
			}
			set
			{
				this.m_CreateButtonEnabled = value;
				this.buttonNew.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000D0C9 File Offset: 0x0000B2C9
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000D0D1 File Offset: 0x0000B2D1
		[Category("User")]
		[Description("Enable the create button")]
		public bool RemoveButtonEnabled
		{
			get
			{
				return this.m_RemoveButtonEnabled;
			}
			set
			{
				this.m_RemoveButtonEnabled = value;
				this.buttonRemove.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000D10A File Offset: 0x0000B30A
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000D112 File Offset: 0x0000B312
		[Category("User")]
		[Description("Enable the create button")]
		public bool CloneButtonEnabled
		{
			get
			{
				return this.m_CloneButtonEnabled;
			}
			set
			{
				this.m_CloneButtonEnabled = value;
				this.buttonClone.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000D14B File Offset: 0x0000B34B
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000D153 File Offset: 0x0000B353
		[Category("User")]
		[Description("Enable the refresh button")]
		public bool RefreshButtonEnabled
		{
			get
			{
				return this.m_RefreshButtonEnabled;
			}
			set
			{
				this.m_RefreshButtonEnabled = value;
				this.buttonRefresh.Visible = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000D168 File Offset: 0x0000B368
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000D170 File Offset: 0x0000B370
		[Category("User")]
		[Description("Enable the wizard button")]
		public bool WizardButtonEnabled
		{
			get
			{
				return this.m_WizardButtonEnabled;
			}
			set
			{
				this.m_WizardButtonEnabled = value;
				this.buttonWizard.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000D1A9 File Offset: 0x0000B3A9
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		[Category("User")]
		[Description("Filter by list")]
		public string[] FilterByList
		{
			get
			{
				return this.m_FilterByList;
			}
			set
			{
				this.m_FilterByList = value;
				this.comboFilterBy.Items.Clear();
				if (this.m_FilterByList != null)
				{
					this.comboFilterBy.Items.AddRange(this.m_FilterByList);
					this.comboFilterBy.SelectedIndex = 0;
					this.m_FilterIndex = new int[this.m_FilterByList.Length];
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000D215 File Offset: 0x0000B415
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000D21D File Offset: 0x0000B41D
		[Category("User")]
		[Description("Filter values")]
		public IdArrayList[] FilterValues
		{
			get
			{
				return this.m_FilterValues;
			}
			set
			{
				this.m_FilterValues = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000D226 File Offset: 0x0000B426
		public object FoundObject
		{
			get
			{
				return this.m_FoundObject;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000D22E File Offset: 0x0000B42E
		public bool HasFound
		{
			get
			{
				return this.m_HasFound;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000D236 File Offset: 0x0000B436
		public bool IsCaseSensitive
		{
			get
			{
				return this.m_CaseSensitive;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000D23E File Offset: 0x0000B43E
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000D246 File Offset: 0x0000B446
		public int CurrentIndex
		{
			get
			{
				return this.m_CurrentSearchIndex;
			}
			set
			{
				this.m_CurrentSearchIndex = value;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000D250 File Offset: 0x0000B450
		public PickUpControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		public void SwitchObject(IdObject idObject)
		{
			this.m_SwitchSema = true;
			int num = this.combo.Items.IndexOf(idObject);
			if (num >= 0)
			{
				this.combo.Items.RemoveAt(num);
				this.combo.Items.Insert(num, idObject);
				this.combo.SelectedItem = idObject;
			}
			this.m_SwitchSema = false;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000D308 File Offset: 0x0000B508
		private void combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_SwitchSema)
			{
				return;
			}
			this.m_CurrentObject = this.combo.SelectedIndex;
			if (this.SelectObject != null && this.combo.SelectedItem != null)
			{
				Cursor.Current = Cursors.WaitCursor;
				this.SelectObject(sender, this.combo.SelectedItem);
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000D370 File Offset: 0x0000B570
		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (this.CreateObject != null)
			{
				IdObject idObject = this.CreateObject(sender, e);
				if (idObject != null)
				{
					this.combo.Items.Add(idObject);
					this.combo.SelectedItem = idObject;
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			IdObject idObject = (IdObject)this.combo.SelectedItem;
			IdObject idObject2 = null;
			int num = this.combo.Items.IndexOf(idObject);
			if (idObject != null)
			{
				if (this.DeleteObject != null)
				{
					idObject2 = this.DeleteObject(sender, idObject);
				}
				if (idObject2 == null)
				{
					this.combo.Items.RemoveAt(num);
					if (num < this.combo.Items.Count)
					{
						this.combo.SelectedIndex = num;
						return;
					}
					if (this.combo.Items.Count > 0)
					{
						this.combo.SelectedIndex = this.combo.Items.Count - 1;
					}
				}
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000D464 File Offset: 0x0000B664
		private void buttonClone_Click(object sender, EventArgs e)
		{
			if (this.CloneObject != null)
			{
				IdObject idObject = (IdObject)this.combo.SelectedItem;
				if (idObject != null)
				{
					IdObject idObject2 = this.CloneObject(sender, idObject);
					if (idObject2 != null)
					{
						this.combo.Items.Add(idObject2);
						this.combo.SelectedItem = idObject2;
					}
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		private void buttonCaseSensitive_Click(object sender, EventArgs e)
		{
			this.m_CaseSensitive = this.buttonCaseSensitive.Checked;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000D4CF File Offset: 0x0000B6CF
		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				this.Search();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D4E2 File Offset: 0x0000B6E2
		private void buttonSearchExact_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchExact;
			this.Search();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000D4F2 File Offset: 0x0000B6F2
		private void buttonSearchStart_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchStarting;
			this.Search();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D502 File Offset: 0x0000B702
		private void buttonSearchContain_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchContaining;
			this.Search();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D514 File Offset: 0x0000B714
		public bool Search()
		{
			this.m_Pattern = this.textSearch.Text;
			if (!this.IsCaseSensitive)
			{
				this.m_Pattern = this.m_Pattern.ToLower();
			}
			int num = this.m_CurrentSearchIndex;
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
				case PickUpControl.SearchMode.SearchExact:
					this.m_HasFound = text.ToString().Equals(this.m_Pattern);
					break;
				case PickUpControl.SearchMode.SearchStarting:
					this.m_HasFound = text.ToString().StartsWith(this.m_Pattern);
					break;
				case PickUpControl.SearchMode.SearchContaining:
					this.m_HasFound = text.Contains(this.m_Pattern);
					break;
				}
				if (this.m_HasFound)
				{
					break;
				}
				if (num == this.m_CurrentSearchIndex)
				{
					goto IL_011E;
				}
				num++;
				if (num == this.m_ObjectList.Count)
				{
					num = 0;
				}
			}
			this.m_FoundObject = this.m_ObjectList[num];
			this.m_CurrentSearchIndex = num;
			this.combo.SelectedItem = this.m_FoundObject;
			return true;
			IL_011E:
			this.m_FoundObject = null;
			return false;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D648 File Offset: 0x0000B848
		private void comboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboFilterBy.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboFilterBy.SelectedIndex == 0)
			{
				this.comboFilterValue.Items.Clear();
				this.comboFilterValue.Enabled = false;
				this.combo.Items.Clear();
				if (this.FilterChanged != null)
				{
					this.FilterChanged(sender, null);
				}
				this.FilterObjects();
				this.m_CurrentFilterBy = 0;
				return;
			}
			int selectedIndex = this.comboFilterBy.SelectedIndex;
			this.comboFilterValue.Items.Clear();
			if (this.m_FilterValues[selectedIndex] != null)
			{
				this.comboFilterValue.Items.AddRange(this.m_FilterValues[selectedIndex].ToArray());
				this.comboFilterValue.Enabled = true;
				if (this.m_FilterIndex[selectedIndex] < this.comboFilterValue.Items.Count)
				{
					this.comboFilterValue.SelectedIndex = this.m_FilterIndex[selectedIndex];
				}
				else
				{
					this.m_FilterIndex[selectedIndex] = 0;
					this.comboFilterValue.SelectedIndex = this.m_FilterIndex[selectedIndex];
				}
			}
			if (this.FilterChanged != null)
			{
				this.FilterChanged(sender, this.comboFilterValue.SelectedItem);
			}
			this.m_CurrentFilterBy = this.comboFilterBy.SelectedIndex;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D78C File Offset: 0x0000B98C
		private void comboFilterValue_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboFilterBy.SelectedIndex;
			if (selectedIndex == this.m_CurrentFilterBy && (this.comboFilterValue.SelectedIndex < 0 || this.comboFilterValue.SelectedIndex == this.m_FilterIndex[selectedIndex]))
			{
				return;
			}
			this.m_FilterIndex[selectedIndex] = this.comboFilterValue.SelectedIndex;
			if (this.FilterChanged != null)
			{
				this.FilterChanged(sender, this.comboFilterValue.SelectedItem);
			}
			this.FilterObjects();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000D80C File Offset: 0x0000BA0C
		private void FilterObjects()
		{
			if (this.m_ObjectList != null)
			{
				object selectedItem = this.combo.SelectedItem;
				IdArrayList idArrayList = this.m_ObjectList.Filter((IdObject)this.comboFilterValue.SelectedItem);
				this.combo.BeginUpdate();
				this.combo.Items.Clear();
				this.combo.Items.AddRange(idArrayList.ToArray());
				this.combo.EndUpdate();
				if (selectedItem != null)
				{
					this.combo.SelectedItem = selectedItem;
				}
				if (this.combo.SelectedIndex < 0)
				{
					if (this.combo.Items.Count != 0)
					{
						this.combo.SelectedIndex = 0;
						return;
					}
					this.combo.Text = string.Empty;
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		private void buttonWizard_Click(object sender, EventArgs e)
		{
			if (this.WizardObject != null)
			{
				IdObject idObject = this.WizardObject(sender, e);
				if (idObject != null)
				{
					this.combo.Items.Add(idObject);
					this.combo.SelectedItem = idObject;
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D918 File Offset: 0x0000BB18
		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			if (this.RefreshObject != null)
			{
				this.RefreshObject(sender, e);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000D930 File Offset: 0x0000BB30
		private void buttonYoungPlayer_CheckedChanged(object sender, EventArgs e)
		{
			this.FilterObjects();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000D938 File Offset: 0x0000BB38
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000D958 File Offset: 0x0000BB58
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PickUpControl));
			this.toolStrip = new ToolStrip();
			this.separatorBegin = new ToolStripSeparator();
			this.combo = new ToolStripComboBox();
			this.buttonRefresh = new ToolStripButton();
			this.separatorSearch = new ToolStripSeparator();
			this.buttonCaseSensitive = new ToolStripButton();
			this.textSearch = new ToolStripTextBox();
			this.buttonSearchExactly = new ToolStripButton();
			this.buttonSearchStart = new ToolStripButton();
			this.buttonSearchContain = new ToolStripButton();
			this.separatorButtons = new ToolStripSeparator();
			this.buttonNew = new ToolStripButton();
			this.buttonRemove = new ToolStripButton();
			this.buttonClone = new ToolStripButton();
			this.buttonWizard = new ToolStripButton();
			this.separatorFilter = new ToolStripSeparator();
			this.labelFilter = new ToolStripLabel();
			this.comboFilterBy = new ToolStripComboBox();
			this.comboFilterValue = new ToolStripComboBox();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.AllowItemReorder = true;
			this.toolStrip.BackColor = SystemColors.Control;
			this.toolStrip.BackgroundImage = (Image)componentResourceManager.GetObject("toolStrip.BackgroundImage");
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[]
			{
				this.separatorBegin, this.combo, this.buttonRefresh, this.separatorSearch, this.buttonCaseSensitive, this.textSearch, this.buttonSearchExactly, this.buttonSearchStart, this.buttonSearchContain, this.separatorButtons,
				this.buttonNew, this.buttonRemove, this.buttonClone, this.buttonWizard, this.separatorFilter, this.labelFilter, this.comboFilterBy, this.comboFilterValue
			});
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(920, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			this.separatorBegin.Name = "separatorBegin";
			this.separatorBegin.Size = new Size(6, 25);
			this.combo.DropDownHeight = 256;
			this.combo.IntegralHeight = false;
			this.combo.MaxDropDownItems = 16;
			this.combo.Name = "combo";
			this.combo.Size = new Size(200, 25);
			this.combo.Sorted = true;
			this.combo.SelectedIndexChanged += this.combo_SelectedIndexChanged;
			this.buttonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRefresh.Image = (Image)componentResourceManager.GetObject("buttonRefresh.Image");
			this.buttonRefresh.ImageTransparentColor = Color.Magenta;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new Size(23, 22);
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += this.buttonRefresh_Click;
			this.separatorSearch.Name = "separatorSearch";
			this.separatorSearch.Size = new Size(6, 25);
			this.buttonCaseSensitive.CheckOnClick = true;
			this.buttonCaseSensitive.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonCaseSensitive.Image = (Image)componentResourceManager.GetObject("buttonCaseSensitive.Image");
			this.buttonCaseSensitive.ImageTransparentColor = Color.Magenta;
			this.buttonCaseSensitive.Name = "buttonCaseSensitive";
			this.buttonCaseSensitive.Size = new Size(23, 22);
			this.buttonCaseSensitive.Text = "Case sensitive";
			this.buttonCaseSensitive.Click += this.buttonCaseSensitive_Click;
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new Size(150, 25);
			this.textSearch.KeyDown += this.textBox_KeyDown;
			this.buttonSearchExactly.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchExactly.Image = (Image)componentResourceManager.GetObject("buttonSearchExactly.Image");
			this.buttonSearchExactly.ImageTransparentColor = Color.Magenta;
			this.buttonSearchExactly.Name = "buttonSearchExactly";
			this.buttonSearchExactly.Size = new Size(23, 22);
			this.buttonSearchExactly.Text = "Search Exactly";
			this.buttonSearchExactly.Click += this.buttonSearchExact_Click;
			this.buttonSearchStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchStart.Image = (Image)componentResourceManager.GetObject("buttonSearchStart.Image");
			this.buttonSearchStart.ImageTransparentColor = Color.Magenta;
			this.buttonSearchStart.Name = "buttonSearchStart";
			this.buttonSearchStart.Size = new Size(23, 22);
			this.buttonSearchStart.Text = "Search if starts";
			this.buttonSearchStart.Click += this.buttonSearchStart_Click;
			this.buttonSearchContain.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchContain.Image = (Image)componentResourceManager.GetObject("buttonSearchContain.Image");
			this.buttonSearchContain.ImageTransparentColor = Color.Magenta;
			this.buttonSearchContain.Name = "buttonSearchContain";
			this.buttonSearchContain.Size = new Size(23, 22);
			this.buttonSearchContain.Text = "Search if contains";
			this.buttonSearchContain.Click += this.buttonSearchContain_Click;
			this.separatorButtons.Name = "separatorButtons";
			this.separatorButtons.Size = new Size(6, 25);
			this.buttonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonNew.Image = (Image)componentResourceManager.GetObject("buttonNew.Image");
			this.buttonNew.ImageTransparentColor = Color.Magenta;
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new Size(23, 22);
			this.buttonNew.Text = "Create";
			this.buttonNew.Click += this.buttonNew_Click;
			this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemove.Image = (Image)componentResourceManager.GetObject("buttonRemove.Image");
			this.buttonRemove.ImageTransparentColor = Color.Magenta;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new Size(23, 22);
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.Click += this.buttonDelete_Click;
			this.buttonClone.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonClone.Image = (Image)componentResourceManager.GetObject("buttonClone.Image");
			this.buttonClone.ImageTransparentColor = Color.Magenta;
			this.buttonClone.Name = "buttonClone";
			this.buttonClone.Size = new Size(23, 22);
			this.buttonClone.Text = "Clone";
			this.buttonClone.Click += this.buttonClone_Click;
			this.buttonWizard.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonWizard.Image = (Image)componentResourceManager.GetObject("buttonWizard.Image");
			this.buttonWizard.ImageTransparentColor = Color.Magenta;
			this.buttonWizard.Name = "buttonWizard";
			this.buttonWizard.Size = new Size(23, 22);
			this.buttonWizard.Text = "Wizard";
			this.buttonWizard.Visible = false;
			this.buttonWizard.Click += this.buttonWizard_Click;
			this.separatorFilter.Name = "separatorFilter";
			this.separatorFilter.Size = new Size(6, 25);
			this.separatorFilter.Visible = false;
			this.labelFilter.Name = "labelFilter";
			this.labelFilter.Size = new Size(33, 22);
			this.labelFilter.Text = "Filter";
			this.labelFilter.Visible = false;
			this.comboFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboFilterBy.Name = "comboFilterBy";
			this.comboFilterBy.Size = new Size(120, 25);
			this.comboFilterBy.Visible = false;
			this.comboFilterBy.SelectedIndexChanged += this.comboFilterBy_SelectedIndexChanged;
			this.comboFilterValue.Name = "comboFilterValue";
			this.comboFilterValue.Size = new Size(160, 25);
			this.comboFilterValue.Sorted = true;
			this.comboFilterValue.Visible = false;
			this.comboFilterValue.SelectedIndexChanged += this.comboFilterValue_SelectedIndexChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.Controls.Add(this.toolStrip);
			base.Name = "PickUpControl";
			base.Size = new Size(920, 25);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000DD RID: 221
		private IdArrayList m_ObjectList;

		// Token: 0x040000DE RID: 222
		private bool m_MainSelectionEnabled = true;

		// Token: 0x040000DF RID: 223
		private bool m_FilterEnabled;

		// Token: 0x040000E0 RID: 224
		private bool m_YoungPlayersEnabled;

		// Token: 0x040000E1 RID: 225
		private bool m_SearchEnabled = true;

		// Token: 0x040000E2 RID: 226
		private bool m_CreateButtonEnabled = true;

		// Token: 0x040000E3 RID: 227
		private bool m_RemoveButtonEnabled = true;

		// Token: 0x040000E4 RID: 228
		private bool m_CloneButtonEnabled = true;

		// Token: 0x040000E5 RID: 229
		private bool m_RefreshButtonEnabled = true;

		// Token: 0x040000E6 RID: 230
		private bool m_WizardButtonEnabled;

		// Token: 0x040000E7 RID: 231
		private string[] m_FilterByList;

		// Token: 0x040000E8 RID: 232
		private IdArrayList[] m_FilterValues;

		// Token: 0x040000E9 RID: 233
		private int[] m_FilterIndex;

		// Token: 0x040000EA RID: 234
		[Category("User")]
		[Description("Handle selected object change.")]
		public PickUpControl.PickUpCallback SelectObject;

		// Token: 0x040000EB RID: 235
		public PickUpControl.PickUpCallback CreateObject;

		// Token: 0x040000EC RID: 236
		public PickUpControl.PickUpCallback DeleteObject;

		// Token: 0x040000ED RID: 237
		public PickUpControl.PickUpCallback CloneObject;

		// Token: 0x040000EE RID: 238
		public PickUpControl.PickUpCallback FilterChanged;

		// Token: 0x040000EF RID: 239
		public PickUpControl.PickUpCallback WizardObject;

		// Token: 0x040000F0 RID: 240
		public PickUpControl.PickUpCallback RefreshObject;

		// Token: 0x040000F1 RID: 241
		private bool m_SwitchSema;

		// Token: 0x040000F2 RID: 242
		private int m_CurrentObject = -1;

		// Token: 0x040000F3 RID: 243
		private int m_CurrentFilterBy = -1;

		// Token: 0x040000F4 RID: 244
		private object m_FoundObject;

		// Token: 0x040000F5 RID: 245
		private bool m_HasFound;

		// Token: 0x040000F6 RID: 246
		private bool m_CaseSensitive;

		// Token: 0x040000F7 RID: 247
		private int m_CurrentSearchIndex;

		// Token: 0x040000F8 RID: 248
		private string m_Pattern;

		// Token: 0x040000F9 RID: 249
		private PickUpControl.SearchMode m_SearchMode = PickUpControl.SearchMode.SearchContaining;

		// Token: 0x040000FA RID: 250
		private IContainer components;

		// Token: 0x040000FB RID: 251
		private ToolStrip toolStrip;

		// Token: 0x040000FC RID: 252
		private ToolStripSeparator separatorBegin;

		// Token: 0x040000FD RID: 253
		private ToolStripSeparator separatorSearch;

		// Token: 0x040000FE RID: 254
		private ToolStripSeparator separatorButtons;

		// Token: 0x040000FF RID: 255
		public ToolStripComboBox combo;

		// Token: 0x04000100 RID: 256
		public ToolStripButton buttonCaseSensitive;

		// Token: 0x04000101 RID: 257
		public ToolStripTextBox textSearch;

		// Token: 0x04000102 RID: 258
		public ToolStripButton buttonSearchContain;

		// Token: 0x04000103 RID: 259
		public ToolStripButton buttonSearchExactly;

		// Token: 0x04000104 RID: 260
		public ToolStripButton buttonSearchStart;

		// Token: 0x04000105 RID: 261
		public ToolStripButton buttonNew;

		// Token: 0x04000106 RID: 262
		public ToolStripButton buttonRemove;

		// Token: 0x04000107 RID: 263
		public ToolStripButton buttonClone;

		// Token: 0x04000108 RID: 264
		public ToolStripLabel labelFilter;

		// Token: 0x04000109 RID: 265
		public ToolStripComboBox comboFilterBy;

		// Token: 0x0400010A RID: 266
		public ToolStripComboBox comboFilterValue;

		// Token: 0x0400010B RID: 267
		public ToolStripSeparator separatorFilter;

		// Token: 0x0400010C RID: 268
		private ToolStripButton buttonWizard;

		// Token: 0x0400010D RID: 269
		private ToolStripButton buttonRefresh;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060001C6 RID: 454
		public delegate IdObject PickUpCallback(object sender, object obj);

		// Token: 0x02000029 RID: 41
		private enum SearchMode
		{
			// Token: 0x040001D5 RID: 469
			SearchExact,
			// Token: 0x040001D6 RID: 470
			SearchStarting,
			// Token: 0x040001D7 RID: 471
			SearchContaining
		}
	}
}
