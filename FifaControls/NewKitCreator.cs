using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000011 RID: 17
	public partial class NewKitCreator : Form
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000C6F6 File Offset: 0x0000A8F6
		public NewKitCreator()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000C70B File Offset: 0x0000A90B
		public Kit NewKit
		{
			get
			{
				return this.m_NewKit;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000C713 File Offset: 0x0000A913
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000C71C File Offset: 0x0000A91C
		public Kit SourceKit
		{
			set
			{
				this.m_SourceKit = value;
				this.m_Team = this.m_SourceKit.Team;
				this.m_KitType = this.m_SourceKit.kittype;
				this.comboTeams.SelectedItem = this.Team;
				int num = 0;
				for (int i = 0; i < NewKitCreator.s_KitTypeMap.Length; i++)
				{
					if (this.m_KitType == NewKitCreator.s_KitTypeMap[i])
					{
						num = i;
						break;
					}
				}
				this.comboKitTypes.SelectedIndex = num;
				this.numericYearTournament.Value = this.m_SourceKit.year;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000C7B1 File Offset: 0x0000A9B1
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000C7B9 File Offset: 0x0000A9B9
		public int KitType
		{
			get
			{
				return this.m_KitType;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
		public int YearTournamentId
		{
			get
			{
				return this.m_YearTournamentId;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
		public void SetTeams(TeamList teamList)
		{
			this.comboTeams.Items.Clear();
			this.comboTeams.Items.AddRange(teamList.ToArray());
		}

		// Token: 0x17000026 RID: 38
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000C7F1 File Offset: 0x0000A9F1
		public KitList KitList
		{
			set
			{
				this.m_KitList = value;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.m_KitList == null)
			{
				this.m_NewKit = null;
				return;
			}
			int num = 0;
			if (this.m_Team != null)
			{
				num = this.m_Team.Id;
			}
			if (this.m_KitList.Exists(num, this.m_KitType, this.m_YearTournamentId))
			{
				this.m_NewKit = null;
				return;
			}
			this.m_NewKit = (Kit)this.m_KitList.CloneId(this.m_SourceKit);
			if (this.m_NewKit != null)
			{
				this.m_NewKit.Team = this.m_Team;
				this.m_NewKit.kittype = this.m_KitType;
				this.m_NewKit.year = this.m_YearTournamentId;
				this.m_SourceKit.CloneTextures(this.m_NewKit);
				if (this.m_SourceKit.Positions != null)
				{
					for (int i = 0; i < this.m_SourceKit.Positions.Length; i++)
					{
						this.m_NewKit.Positions[i] = this.m_SourceKit.Positions[i];
					}
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		private void comboTeams_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTeams.SelectedItem != null)
			{
				this.m_Team = (Team)this.comboTeams.SelectedItem;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000C924 File Offset: 0x0000AB24
		private void comboKitTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboKitTypes.SelectedIndex >= 0)
			{
				int selectedIndex = this.comboKitTypes.SelectedIndex;
				this.m_KitType = NewKitCreator.s_KitTypeMap[selectedIndex];
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000C958 File Offset: 0x0000AB58
		private void numericYearTournament_ValueChanged(object sender, EventArgs e)
		{
			this.m_YearTournamentId = (int)this.numericYearTournament.Value;
		}

		// Token: 0x040000CC RID: 204
		private static int[] s_KitTypeMap = new int[]
		{
			0, 1, 2, 3, 4, 5, 6, 7, 30, 31,
			32, 93, 94
		};

		// Token: 0x040000CD RID: 205
		private Kit m_NewKit;

		// Token: 0x040000CE RID: 206
		private int m_NewId = -1;

		// Token: 0x040000CF RID: 207
		private Kit m_SourceKit;

		// Token: 0x040000D0 RID: 208
		private Team m_Team;

		// Token: 0x040000D1 RID: 209
		private int m_KitType;

		// Token: 0x040000D2 RID: 210
		private int m_YearTournamentId;

		// Token: 0x040000D3 RID: 211
		private KitList m_KitList;
	}
}
