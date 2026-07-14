using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;

namespace CreationMaster
{
	// Token: 0x0200000D RID: 13
	public partial class PatchCreatorForm : Form
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0001B62C File Offset: 0x0001982C
		public PatchCreatorForm()
		{
			this.InitializeComponent();
			this.m_TempFolder = FifaEnvironment.TempFolder + "\\Patch";
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001B67C File Offset: 0x0001987C
		private void comboPatchType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.listSource.BeginUpdate();
			this.statusLabel.Text = "Loading ...";
			this.listSource.Items.Clear();
			PatchCreatorForm.EPatchType selectedIndex = (PatchCreatorForm.EPatchType)this.comboPatchType.SelectedIndex;
			this.listSource.Sorted = true;
			switch (selectedIndex)
			{
			case PatchCreatorForm.EPatchType.Country:
				this.listSource.Items.AddRange(FifaEnvironment.Countries.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Country;
				this.tabPatchOptions.SelectedTab = this.pageCountryOptions;
				break;
			case PatchCreatorForm.EPatchType.League:
				this.listSource.Items.AddRange(FifaEnvironment.Leagues.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.League;
				this.tabPatchOptions.SelectedTab = this.pageLeagueOptions;
				break;
			case PatchCreatorForm.EPatchType.Team:
				this.listSource.Items.AddRange(FifaEnvironment.Teams.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Team;
				this.tabPatchOptions.SelectedTab = this.pageTeamOptions;
				break;
			case PatchCreatorForm.EPatchType.Player:
				this.listSource.Items.AddRange(FifaEnvironment.Players.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Player;
				this.tabPatchOptions.SelectedTab = this.pagePlayerOptions;
				break;
			case PatchCreatorForm.EPatchType.Kit:
				this.listSource.Items.AddRange(FifaEnvironment.Kits.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Kit;
				this.tabPatchOptions.SelectedTab = this.pageKitOptions;
				break;
			case PatchCreatorForm.EPatchType.Referee:
				this.listSource.Items.AddRange(FifaEnvironment.Referees.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Referee;
				this.tabPatchOptions.SelectedTab = this.pageRefereeOptions;
				break;
			case PatchCreatorForm.EPatchType.Stadium:
				this.listSource.Items.AddRange(FifaEnvironment.Stadiums.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Stadium;
				this.tabPatchOptions.SelectedTab = this.pageStadiumOptions;
				break;
			case PatchCreatorForm.EPatchType.Formation:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.Formations.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Formation;
				break;
			case PatchCreatorForm.EPatchType.Ball:
				this.listSource.Items.AddRange(FifaEnvironment.Balls.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Ball;
				this.tabPatchOptions.SelectedTab = this.pageTeamOptions;
				break;
			case PatchCreatorForm.EPatchType.Adboard:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.Adboards.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Adboard;
				this.tabPatchOptions.SelectedTab = this.pageTeamOptions;
				break;
			case PatchCreatorForm.EPatchType.NumberFont:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.NumberFonts.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.NumberFont;
				this.tabPatchOptions.SelectedTab = this.pageTeamOptions;
				break;
			case PatchCreatorForm.EPatchType.NameFont:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.NameFonts.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.NameFont;
				this.tabPatchOptions.SelectedTab = this.pageTeamOptions;
				break;
			case PatchCreatorForm.EPatchType.Shoes:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.Shoes.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Shoes;
				this.tabPatchOptions.SelectedTab = this.pagePlayerOptions;
				break;
			case PatchCreatorForm.EPatchType.GKGloves:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.GkGloves.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.GKGloves;
				this.tabPatchOptions.SelectedTab = this.pagePlayerOptions;
				break;
			case PatchCreatorForm.EPatchType.Net:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.Nets.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.Net;
				this.tabPatchOptions.SelectedTab = this.pageStadiumOptions;
				break;
			case PatchCreatorForm.EPatchType.MowingPattern:
				this.listSource.Sorted = false;
				this.listSource.Items.AddRange(FifaEnvironment.MowingPatterns.ToArray());
				this.m_PatchType = PatchCreatorForm.EPatchType.MowingPattern;
				this.tabPatchOptions.SelectedTab = this.pageStadiumOptions;
				break;
			}
			this.listSource.EndUpdate();
			this.statusLabel.Text = "Ready";
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (this.listSource.SelectedItems.Count <= 0)
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			switch (this.m_PatchType)
			{
			case PatchCreatorForm.EPatchType.Country:
				goto IL_0140;
			case PatchCreatorForm.EPatchType.League:
				goto IL_00FA;
			case PatchCreatorForm.EPatchType.Team:
				break;
			case PatchCreatorForm.EPatchType.Player:
			{
				using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Player player = (Player)obj;
						this.AddToPatchList(player);
					}
					goto IL_04C8;
				}
				break;
			}
			case PatchCreatorForm.EPatchType.Kit:
				goto IL_0485;
			case PatchCreatorForm.EPatchType.Referee:
				goto IL_01CC;
			case PatchCreatorForm.EPatchType.Stadium:
				goto IL_0186;
			case PatchCreatorForm.EPatchType.Formation:
				goto IL_0212;
			case PatchCreatorForm.EPatchType.Ball:
				goto IL_0258;
			case PatchCreatorForm.EPatchType.Adboard:
				goto IL_029E;
			case PatchCreatorForm.EPatchType.NumberFont:
				goto IL_02E4;
			case PatchCreatorForm.EPatchType.NameFont:
				goto IL_032A;
			case PatchCreatorForm.EPatchType.Shoes:
				goto IL_03B6;
			case PatchCreatorForm.EPatchType.GKGloves:
				goto IL_03FC;
			case PatchCreatorForm.EPatchType.Net:
				goto IL_0370;
			case PatchCreatorForm.EPatchType.MowingPattern:
				goto IL_0442;
			default:
				goto IL_04C8;
			}
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					Team team = (Team)obj2;
					this.AddToPatchList(team);
				}
				goto IL_04C8;
			}
			IL_00FA:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj3 = enumerator.Current;
					League league = (League)obj3;
					this.AddToPatchList(league);
				}
				goto IL_04C8;
			}
			IL_0140:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj4 = enumerator.Current;
					Country country = (Country)obj4;
					this.AddToPatchList(country);
				}
				goto IL_04C8;
			}
			IL_0186:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj5 = enumerator.Current;
					Stadium stadium = (Stadium)obj5;
					this.AddToPatchList(stadium);
				}
				goto IL_04C8;
			}
			IL_01CC:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj6 = enumerator.Current;
					Referee referee = (Referee)obj6;
					this.AddToPatchList(referee);
				}
				goto IL_04C8;
			}
			IL_0212:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj7 = enumerator.Current;
					Formation formation = (Formation)obj7;
					this.AddToPatchList(formation);
				}
				goto IL_04C8;
			}
			IL_0258:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj8 = enumerator.Current;
					Ball ball = (Ball)obj8;
					this.AddToPatchList(ball);
				}
				goto IL_04C8;
			}
			IL_029E:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj9 = enumerator.Current;
					Adboard adboard = (Adboard)obj9;
					this.AddToPatchList(adboard);
				}
				goto IL_04C8;
			}
			IL_02E4:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj10 = enumerator.Current;
					NumberFont numberFont = (NumberFont)obj10;
					this.AddToPatchList(numberFont);
				}
				goto IL_04C8;
			}
			IL_032A:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj11 = enumerator.Current;
					NameFont nameFont = (NameFont)obj11;
					this.AddToPatchList(nameFont);
				}
				goto IL_04C8;
			}
			IL_0370:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj12 = enumerator.Current;
					Net net = (Net)obj12;
					this.AddToPatchList(net);
				}
				goto IL_04C8;
			}
			IL_03B6:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj13 = enumerator.Current;
					Shoes shoes = (Shoes)obj13;
					this.AddToPatchList(shoes);
				}
				goto IL_04C8;
			}
			IL_03FC:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj14 = enumerator.Current;
					GkGloves gkGloves = (GkGloves)obj14;
					this.AddToPatchList(gkGloves);
				}
				goto IL_04C8;
			}
			IL_0442:
			using (IEnumerator enumerator = this.listSource.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj15 = enumerator.Current;
					MowingPattern mowingPattern = (MowingPattern)obj15;
					this.AddToPatchList(mowingPattern);
				}
				goto IL_04C8;
			}
			IL_0485:
			foreach (object obj16 in this.listSource.SelectedItems)
			{
				Kit kit = (Kit)obj16;
				this.AddToPatchList(kit);
			}
			IL_04C8:
			Cursor.Current = Cursors.Default;
			this.statusLabel.Text = "Ready";
			this.statusBar.Refresh();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		private ListViewItem WriteToPatchList(IdObject obj)
		{
			return this.WriteToPatchList(obj, obj.Id, obj.ToString(), null);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001C0C6 File Offset: 0x0001A2C6
		private ListViewItem WriteToPatchList(IdObject obj, string name)
		{
			return this.WriteToPatchList(obj, obj.Id, name, null);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		private ListViewItem WriteToPatchList(IdObject obj, int id, string name, string comment)
		{
			if (obj == null)
			{
				return null;
			}
			foreach (object obj2 in this.listViewDest.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj2;
				if (obj == listViewItem.Tag)
				{
					return null;
				}
			}
			string[] array = new string[]
			{
				null,
				obj.GetType().Name,
				id.ToString(),
				name
			};
			array[0] = comment;
			ListViewItem listViewItem2 = new ListViewItem(array);
			listViewItem2.Tag = obj;
			this.listViewDest.Items.Add(listViewItem2);
			this.statusLabel.Text = "Adding " + name;
			this.statusBar.Refresh();
			return listViewItem2;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
		private ListViewItem AddToPatchList(string desc)
		{
			if (desc == null)
			{
				return null;
			}
			foreach (object obj in this.listViewDest.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (desc == listViewItem.Tag.ToString())
				{
					return null;
				}
			}
			string[] array = new string[4];
			int num = desc.IndexOf(' ');
			array[1] = ((num > 0) ? desc.Substring(0, num) : desc);
			array[3] = desc;
			int num2 = desc.LastIndexOf(' ');
			array[2] = desc.Substring(num2);
			array[0] = null;
			ListViewItem listViewItem2 = new ListViewItem(array);
			listViewItem2.Tag = desc;
			this.listViewDest.Items.Add(listViewItem2);
			return listViewItem2;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001C28C File Offset: 0x0001A48C
		private void AddToPatchList(League league)
		{
			if (league == null)
			{
				return;
			}
			this.WriteToPatchList(league, league.leaguename);
			if (this.checkLeagueLinkedTeams.Checked)
			{
				foreach (object obj in league.PlayingTeams)
				{
					Team team = (Team)obj;
					this.AddToPatchList(team);
				}
			}
			if (this.checkLeagueReferees.Checked)
			{
				foreach (object obj2 in FifaEnvironment.Referees)
				{
					Referee referee = (Referee)obj2;
					if (referee.IsInLeague(league))
					{
						this.AddToPatchList(referee);
					}
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001C364 File Offset: 0x0001A564
		private void AddToPatchList(Team team)
		{
			if (team == null)
			{
				return;
			}
			this.WriteToPatchList(team, team.DatabaseName);
			if (this.checkTeamKits.Checked)
			{
				foreach (object obj in team.m_KitList)
				{
					Kit kit = (Kit)obj;
					this.AddToPatchList(kit);
				}
			}
			if (this.checkTeamFormation.Checked)
			{
				Formation formation = (Formation)FifaEnvironment.Formations.SearchId(team.formationid);
				this.AddToPatchList(formation);
			}
			if (this.checkTeamAdboard.Checked)
			{
				Adboard adboard = (Adboard)FifaEnvironment.Adboards.SearchId(team.adboardid);
				this.AddToPatchList(adboard);
			}
			if (this.checkTeamBall.Checked)
			{
				Ball ball = (Ball)FifaEnvironment.Balls.SearchId(team.balltype);
				this.AddToPatchList(ball);
			}
			if (this.checkTeamStadium.Checked)
			{
				Stadium stadium = (Stadium)FifaEnvironment.Stadiums.SearchId(team.Stadium);
				this.AddToPatchList(stadium);
			}
			if (this.checkTeamLinkedPlayers.Checked)
			{
				foreach (object obj2 in team.Roster)
				{
					TeamPlayer teamPlayer = (TeamPlayer)obj2;
					this.AddToPatchList(teamPlayer.Player);
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		private void AddToPatchList(Player player)
		{
			if (player == null)
			{
				return;
			}
			this.WriteToPatchList(player);
			if (this.checkPlayerShoes.Checked)
			{
				Shoes shoes = (Shoes)FifaEnvironment.Shoes.SearchId(player.shoetypecode);
				this.AddToPatchList(shoes);
			}
			if (this.checkPlayerGloves.Checked)
			{
				GkGloves gkGloves = (GkGloves)FifaEnvironment.GkGloves.SearchId(player.gkglovetypecode);
				this.AddToPatchList(gkGloves);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001C555 File Offset: 0x0001A755
		private void AddToPatchList(Shoes shoes)
		{
			if (shoes == null)
			{
				return;
			}
			if (shoes.Id == 0)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(Shoes.ShoesTexturesFileName(shoes.Id, 0)))
			{
				return;
			}
			this.WriteToPatchList(shoes);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001C58D File Offset: 0x0001A78D
		private void AddToPatchList(Ball ball)
		{
			if (ball == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(ball.BallTextureFileName()))
			{
				return;
			}
			this.WriteToPatchList(ball);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001C5B6 File Offset: 0x0001A7B6
		private void AddToPatchList(Adboard adboard)
		{
			if (adboard == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(Adboard.AdboardFileName(adboard.Id)))
			{
				return;
			}
			this.WriteToPatchList(adboard);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		private void AddToPatchList(Kit kit)
		{
			if (kit == null)
			{
				return;
			}
			if (kit.year != 0)
			{
				return;
			}
			if (kit.Team != null)
			{
				this.WriteToPatchList(kit, kit.Team.Id * 10 + kit.kittype, kit.ToString(), null);
			}
			else
			{
				this.WriteToPatchList(kit, kit.teamid * 10 + kit.kittype, kit.ToString(), null);
			}
			if (this.checkKitNumbers.Checked)
			{
				NumberFont numberFont = (NumberFont)FifaEnvironment.NumberFonts.SearchId(kit.jerseyNumberFont * 20 + kit.jerseyNumberColor);
				this.AddToPatchList(numberFont);
				numberFont = (NumberFont)FifaEnvironment.NumberFonts.SearchId(kit.shortsNumberFont * 20 + kit.shortsNumberColor);
				this.AddToPatchList(numberFont);
			}
			if (this.checkKitNameFonts.Checked)
			{
				NameFont nameFont = (NameFont)FifaEnvironment.NameFonts.SearchId(kit.jerseyNameFont);
				this.AddToPatchList(nameFont);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		private void AddToPatchList(Stadium stadium)
		{
			if (stadium == null)
			{
				return;
			}
			this.WriteToPatchList(stadium, stadium.DatabaseString());
			if (this.checkStadiumNet.Checked)
			{
				Net net = (Net)FifaEnvironment.Nets.SearchId(stadium.NetColor);
				this.AddToPatchList(net);
			}
			if (this.checkStadiumMowingPattern.Checked)
			{
				int mowingPatternId = stadium.MowingPatternId;
				MowingPattern mowingPattern = (MowingPattern)FifaEnvironment.MowingPatterns.SearchId(mowingPatternId);
				this.AddToPatchList(mowingPattern);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001C748 File Offset: 0x0001A948
		private void AddToPatchList(Referee referee)
		{
			if (referee == null)
			{
				return;
			}
			this.WriteToPatchList(referee);
			if (this.checkPlayerShoes.Checked)
			{
				Shoes shoes = (Shoes)FifaEnvironment.Shoes.SearchId(referee.shoetypecode);
				this.AddToPatchList(shoes);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001C78B File Offset: 0x0001A98B
		private void AddToPatchList(Formation formation)
		{
			if (formation == null)
			{
				return;
			}
			this.WriteToPatchList(formation);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001C79C File Offset: 0x0001A99C
		private void AddToPatchList(Country country)
		{
			if (country == null)
			{
				return;
			}
			this.WriteToPatchList(country, country.DatabaseName);
			if (this.checkCountryLeagues.Checked)
			{
				foreach (object obj in FifaEnvironment.Leagues)
				{
					League league = (League)obj;
					if (league.Country == country)
					{
						this.AddToPatchList(league);
					}
				}
			}
			if (this.checkContrynationalTeam.Checked && country.NationalTeam != null)
			{
				this.AddToPatchList(country.NationalTeam);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001C840 File Offset: 0x0001AA40
		private void AddToPatchList(NameFont nameFont)
		{
			if (nameFont == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(NameFont.NameFontFileName(nameFont.Id)))
			{
				return;
			}
			this.WriteToPatchList(nameFont);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001C86E File Offset: 0x0001AA6E
		private void AddToPatchList(NumberFont numberFont)
		{
			if (numberFont == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(numberFont.NumberFontFileName()))
			{
				return;
			}
			this.WriteToPatchList(numberFont);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001C897 File Offset: 0x0001AA97
		private void AddToPatchList(Net net)
		{
			if (net == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(Net.NetFileName(net.Id)))
			{
				return;
			}
			this.WriteToPatchList(net);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0001C8C5 File Offset: 0x0001AAC5
		private void AddToPatchList(MowingPattern mowingPattern)
		{
			if (mowingPattern == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(MowingPattern.MowingPatternFileName(mowingPattern.Id)))
			{
				return;
			}
			this.WriteToPatchList(mowingPattern);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001C8F3 File Offset: 0x0001AAF3
		private void AddToPatchList(GkGloves gloves)
		{
			if (gloves == null)
			{
				return;
			}
			if (this.radioIncludePatched.Checked && !FifaEnvironment.IsPatched(GkGloves.GkGlovesTextureFileName(gloves.Id)))
			{
				return;
			}
			this.WriteToPatchList(gloves);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0001C924 File Offset: 0x0001AB24
		private void buttonRemoveObject_Click(object sender, EventArgs e)
		{
			int count = this.listViewDest.SelectedItems.Count;
			for (int i = 0; i < count; i++)
			{
				this.listViewDest.Items.Remove(this.listViewDest.SelectedItems[0]);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0001C96F File Offset: 0x0001AB6F
		private void buttonExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0001C977 File Offset: 0x0001AB77
		private void buttonCreatePatch_Click(object sender, EventArgs e)
		{
			this.CreatePatch();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001C980 File Offset: 0x0001AB80
		private void CreatePatch()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "cmp files (*.cmp)|*.cmp";
			saveFileDialog.InitialDirectory = FifaEnvironment.TempFolder;
			saveFileDialog.FileName = this.textPatchName.Text;
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.Title = "Save Creation Master Patch";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return;
			}
			string fileName = saveFileDialog.FileName;
			saveFileDialog.Dispose();
			Cursor.Current = Cursors.WaitCursor;
			this.Refresh();
			this.m_FifaDataSet.DataSetName = "FIFA16";
			this.m_LangDataSet.DataSetName = "LANG16";
			this.m_FifaDataSet.Tables.Clear();
			this.m_LangDataSet.Tables.Clear();
			this.m_PatchDataSet.Tables[0].Clear();
			DataRow dataRow = this.m_PatchDataSet.Tables[0].NewRow();
			dataRow[0] = this.textPatchName.Text;
			dataRow[1] = this.textPatchVersion.Text;
			dataRow[2] = this.textDescription.Text;
			dataRow[3] = "";
			this.m_PatchDataSet.Tables[0].Rows.Add(dataRow);
			this.m_PatchDataSet.Tables[1].Clear();
			foreach (object obj in this.listViewDest.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				DataRow dataRow2 = this.m_PatchDataSet.Tables[1].NewRow();
				dataRow2[0] = listViewItem.SubItems[0].Text;
				dataRow2[1] = listViewItem.SubItems[1].Text;
				dataRow2[2] = listViewItem.SubItems[2].Text;
				dataRow2[3] = listViewItem.SubItems[3].Text;
				this.m_PatchDataSet.Tables[1].Rows.Add(dataRow2);
			}
			this.CreateKeysArrays();
			this.m_LanguageTable = FifaEnvironment.LangDb.Table[TI.lang].ConvertToDataTable(this.m_LanguageKeys, "hashid");
			this.m_LangDataSet.Tables.Add(this.m_LanguageTable);
			if (this.m_PlayerKeys.Length != 0 && this.checkPlayerDatabase.Checked)
			{
				this.m_PlayersTable = FifaEnvironment.FifaDb.Table[TI.players].ConvertToDataTable(this.m_PlayerKeys, "playerid");
				this.m_FifaDataSet.Tables.Add(this.m_PlayersTable);
				this.m_PlayernamesTable = FifaEnvironment.FifaDb.Table[TI.playernames].ConvertToDataTable(this.m_PlayerNameKeys, "nameid");
				this.m_FifaDataSet.Tables.Add(this.m_PlayernamesTable);
				this.m_PlayerLoansTable = FifaEnvironment.FifaDb.Table[TI.playerloans].ConvertToDataTable(this.m_PlayerNameKeys, "playerid");
				this.m_FifaDataSet.Tables.Add(this.m_PlayerLoansTable);
			}
			if (this.m_TeamKeys.Length != 0 && this.checkTeamDatabase.Checked)
			{
				this.m_TeamsTable = FifaEnvironment.FifaDb.Table[TI.teams].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamsTable);
				this.m_RowTeamNationLinksTable = FifaEnvironment.FifaDb.Table[TI.rowteamnationlinks].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_RowTeamNationLinksTable);
				this.m_TeamNationLinksTable = FifaEnvironment.FifaDb.Table[TI.teamnationlinks].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamNationLinksTable);
				this.m_TeamplayerlinksTable = FifaEnvironment.FifaDb.Table[TI.teamplayerlinks].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamplayerlinksTable);
				this.m_TeamStadiumLinksTable = FifaEnvironment.FifaDb.Table[TI.teamstadiumlinks].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamStadiumLinksTable);
				this.m_TeamFormationTeamStyleLinksTable = FifaEnvironment.FifaDb.Table[TI.teamformationteamstylelinks].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamFormationTeamStyleLinksTable);
				this.m_StadiumAssignmentsTable = FifaEnvironment.FifaDb.Table[TI.stadiumassignments].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_StadiumAssignmentsTable);
				this.m_ManagerTable = FifaEnvironment.FifaDb.Table[TI.manager].ConvertToDataTable(this.m_TeamKeys, "teamid");
				this.m_FifaDataSet.Tables.Add(this.m_ManagerTable);
			}
			if (this.checkKitDatabase.Checked)
			{
				this.m_TeamkitsTable = FifaEnvironment.FifaDb.Table[TI.teamkits].ConvertToDataTable(this.m_KitKeys, "teamkitid");
				this.m_FifaDataSet.Tables.Add(this.m_TeamkitsTable);
			}
			if (this.m_LeagueKeys.Length != 0 && this.checkLeagueDatabase.Checked)
			{
				this.m_LeaguesTable = FifaEnvironment.FifaDb.Table[TI.leagues].ConvertToDataTable(this.m_LeagueKeys, "leagueid");
				this.m_FifaDataSet.Tables.Add(this.m_LeaguesTable);
				this.m_BoardOutcomesTable = FifaEnvironment.FifaDb.Table[TI.career_boardoutcomes].ConvertToDataTable(this.m_LeagueKeys, "leagueid");
				this.m_FifaDataSet.Tables.Add(this.m_BoardOutcomesTable);
				if (this.checkLeagueLinkedTeams.Checked)
				{
					this.m_LeagueTeamLinksTable = FifaEnvironment.FifaDb.Table[TI.leagueteamlinks].ConvertToDataTable(this.m_LeagueKeys, "leagueid");
					this.m_FifaDataSet.Tables.Add(this.m_LeagueTeamLinksTable);
				}
			}
			if (this.m_CountryKeys.Length != 0 && this.checkCountryDatabase.Checked)
			{
				this.m_NationsTable = FifaEnvironment.FifaDb.Table[TI.nations].ConvertToDataTable(this.m_CountryKeys, "nationid");
				this.m_FifaDataSet.Tables.Add(this.m_NationsTable);
				this.m_AudionationsTable = FifaEnvironment.FifaDb.Table[TI.audionation].ConvertToDataTable(this.m_CountryKeys, "nationid");
				this.m_FifaDataSet.Tables.Add(this.m_AudionationsTable);
			}
			if (this.m_RefereeKeys.Length != 0 && this.checkRefereeDatabase.Checked)
			{
				this.m_RefereesTable = FifaEnvironment.FifaDb.Table[TI.referee].ConvertToDataTable(this.m_RefereeKeys, "refereeid");
				this.m_FifaDataSet.Tables.Add(this.m_RefereesTable);
			}
			if (this.m_StadiumKeys.Length != 0 && this.checkStadiumDatabase.Checked)
			{
				this.m_StadiumsTable = FifaEnvironment.FifaDb.Table[TI.stadiums].ConvertToDataTable(this.m_StadiumKeys, "stadiumid");
				this.m_FifaDataSet.Tables.Add(this.m_StadiumsTable);
			}
			if (this.m_FormationKeys.Length != 0)
			{
				this.m_FormationsTable = FifaEnvironment.FifaDb.Table[TI.formations].ConvertToDataTable(this.m_FormationKeys, "formationid");
				this.m_FifaDataSet.Tables.Add(this.m_FormationsTable);
			}
			if (Directory.Exists(this.m_TempFolder))
			{
				Directory.Delete(this.m_TempFolder, true);
			}
			Directory.CreateDirectory(this.m_TempFolder);
			this.statusLabel.Text = "Saving XML files...";
			this.statusBar.Refresh();
			this.m_PatchDataSet.WriteXml(this.m_TempFolder + "\\patch.xml");
			this.m_FifaDataSet.WriteXml(this.m_TempFolder + "\\fifa.xml");
			this.m_LangDataSet.WriteXml(this.m_TempFolder + "\\lang.xml");
			foreach (object obj2 in this.listViewDest.Items)
			{
				ListViewItem listViewItem2 = (ListViewItem)obj2;
				object tag = listViewItem2.Tag;
				string text = listViewItem2.Tag.GetType().Name;
				this.statusLabel.Text = "Saving " + listViewItem2.SubItems[3].Text;
				this.statusBar.Refresh();
				if (text == "Player")
				{
					Player player = (Player)tag;
					if (this.checkPlayerHead.Checked && player.HasSpecificHeadModel)
					{
						this.CheckAndExport(player.SpecificFaceTextureFileName());
						this.CheckAndExport(player.SpecificHairTexturesFileName());
						this.CheckAndExport(player.SpecificHeadModelFileName());
						this.CheckAndExport(player.SpecificHairModelFileName());
						this.CheckAndExport(player.SpecificHairLodModelFileName());
						this.CheckAndExport(player.TattoTextureFileName());
					}
					if (this.checkPlayerMiniface.Checked)
					{
						this.CheckAndExport(player.SpecificPhotoDdsFileName());
					}
				}
				else if (text == "Team")
				{
					Team team = (Team)tag;
					if (this.checkTeamGuiLogo.Checked)
					{
						this.CheckAndExport(team.CrestDdsFileName());
						this.CheckAndExport(team.Crest50DdsFileName());
						this.CheckAndExport(team.Crest32DdsFileName());
						this.CheckAndExport(team.Crest16DdsFileName());
					}
					if (this.checkTeamGuiBanner.Checked)
					{
						this.CheckAndExport(team.BannerFileName());
					}
					if (this.checkTeamFlags.Checked)
					{
						this.CheckAndExport(team.FlagFileName());
						this.CheckAndExport(team.ScarfFileName());
						this.CheckAndExport(team.RevModAdboardFileName());
						this.CheckAndExport(team.RevModBallModelFileName());
						this.CheckAndExport(team.RevModBallTextureFileName());
						this.CheckAndExport(team.RevModNetFileName());
						this.CheckAndExport(team.RevModManagerModelFileName());
						this.CheckAndExport(team.RevModManagerTextureFileName());
					}
				}
				else if (text == "Kit")
				{
					Kit kit = (Kit)tag;
					if (this.checkKitTextures.Checked)
					{
						this.CheckAndExport(kit.KitTextureFileName());
					}
					if (this.checkKitMinikits.Checked)
					{
						this.CheckAndExport(kit.MiniKitDdsFileName());
					}
				}
				else if (text == "League")
				{
					League league = (League)tag;
					if (this.checkLeagueLogo.Checked)
					{
						this.CheckAndExport(league.TinyLogoDdsFileName());
						this.CheckAndExport(league.SmallLogoDdsFileName());
						this.CheckAndExport(league.AnimLogoDdsFileName());
						this.CheckAndExport(league.Logo512x128DdsFileName());
					}
				}
				else if (text == "Country")
				{
					Country country = (Country)tag;
					if (this.checkCountryFlag.Checked)
					{
						this.CheckAndExport(country.FlagBigFileName());
					}
					if (this.checkCountryMap.Checked)
					{
						this.CheckAndExport(country.ShapeFileName());
					}
					if (this.checkCountryFlag512x512.Checked)
					{
						this.CheckAndExport(country.Flag512DdsFileName());
					}
					if (this.checkCountryCardFlag.Checked)
					{
						this.CheckAndExport(country.CardFlagBigFileName());
					}
					if (this.checkCountryMiniFlag.Checked)
					{
						this.CheckAndExport(country.MiniFlagBigFileName());
					}
				}
				else if (text == "Stadium")
				{
					Stadium stadium = (Stadium)tag;
					if (this.checkStadiumModel.Checked)
					{
						this.CheckAndExport(stadium.ModelFileName());
						this.CheckAndExport(stadium.RadiosityFileName());
						if (stadium.HasSunnyDay())
						{
							this.CheckAndExport(stadium.TexturesFileName(1));
							this.CheckAndExport(stadium.CrowdFileName(1));
						}
						if (stadium.HasNight())
						{
							this.CheckAndExport(stadium.TexturesFileName(3));
							this.CheckAndExport(stadium.CrowdFileName(3));
						}
					}
					if (this.checkStadiumPreview.Checked)
					{
						this.CheckAndExport(stadium.PreviewBigFileName(1));
						this.CheckAndExport(stadium.PreviewLargeBigFileName(1));
						this.CheckAndExport(stadium.PreviewBigFileName(3));
						this.CheckAndExport(stadium.PreviewLargeBigFileName(3));
					}
				}
				else if (text == "Referee")
				{
					Referee referee = (Referee)tag;
					if (this.checkRefereeMiniFace.Checked && FifaEnvironment.Year == 14)
					{
						this.CheckAndExport(referee.PhotoBigFileName());
					}
				}
				else
				{
					text = listViewItem2.SubItems[1].Text;
					int num = Convert.ToInt32(listViewItem2.SubItems[2].Text);
					if (text == "Ball")
					{
						this.CheckAndExport(Ball.BallModelFileName(num));
						this.CheckAndExport(Ball.BallTextureFileName(num));
						if (FifaEnvironment.Year == 14)
						{
							this.CheckAndExport(Ball.BallPictureBigFileName(num));
						}
						else
						{
							this.CheckAndExport(Ball.BallDdsFileName(num));
						}
					}
					else if (text == "Adboard")
					{
						this.CheckAndExport(Adboard.AdboardFileName(num));
					}
					else if (text == "Shoes")
					{
						this.CheckAndExport(Shoes.ShoesTexturesFileName(num, 0));
						this.CheckAndExport(Shoes.ShoesModelFileName(num));
					}
					else if (text == "Net")
					{
						this.CheckAndExport(Net.NetFileName(num));
					}
					else if (text == "MowingPattern")
					{
						this.CheckAndExport(MowingPattern.MowingPatternFileName(num));
					}
					else if (text == "GkGloves")
					{
						this.CheckAndExport(GkGloves.GkGlovesTextureFileName(num));
					}
					else if (text == "NumberFont")
					{
						int num2 = num / 20;
						int num3 = num - num2 * 20;
						this.CheckAndExport(NumberFont.NumberFontFileName(num2, num3));
					}
					else if (text == "NameFont")
					{
						this.CheckAndExport(NameFont.NameFontFileName(num));
					}
				}
			}
			ZipOutputStream zipOutputStream = new ZipOutputStream(File.Create(fileName));
			zipOutputStream.SetLevel(8);
			string[] files = Directory.GetFiles(this.m_TempFolder, "*.*", SearchOption.AllDirectories);
			if (files == null)
			{
				return;
			}
			int num4 = this.m_TempFolder.Length + 1;
			for (int i = 0; i < files.Length; i++)
			{
				string text2 = files[i];
				string text3 = text2.Substring(num4);
				FileStream fileStream = File.OpenRead(text2);
				this.AddStreamToZip(zipOutputStream, fileStream, text3);
				fileStream.Close();
				this.statusLabel.Text = "Zipping " + (files.Length - i).ToString();
				this.statusBar.Refresh();
			}
			zipOutputStream.Finish();
			zipOutputStream.Close();
			Cursor.Current = Cursors.Default;
			this.statusLabel.Text = "Ready";
			this.statusBar.Refresh();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001D91C File Offset: 0x0001BB1C
		private void CheckAndExport(string fileName)
		{
			if (this.radioIncludeOriginal.Checked || FifaEnvironment.IsPatched(fileName))
			{
				FifaEnvironment.ExportFileFromZdata(fileName, this.m_TempFolder);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001D940 File Offset: 0x0001BB40
		private void CreateKeysArrays()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			foreach (object obj in this.listViewDest.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				object tag = listViewItem.Tag;
				string name = listViewItem.Tag.GetType().Name;
				if (name == "Player")
				{
					num4++;
					num5 += 4;
				}
				else if (name == "Team")
				{
					num3++;
					num10 += 5;
				}
				else if (name == "Kit")
				{
					num6++;
				}
				else if (name == "League")
				{
					num2++;
					num10 += 2;
				}
				else if (name == "Country")
				{
					num++;
					num10++;
				}
				else if (name == "Stadium")
				{
					num8++;
					num10++;
				}
				else if (name == "Referee")
				{
					num7++;
				}
				else if (name == "Formation")
				{
					num9++;
				}
				else if (name == "Ball")
				{
					num10++;
				}
			}
			this.m_PlayerKeys = new int[num4];
			this.m_PlayerNameKeys = new int[num5];
			this.m_TeamKeys = new int[num3];
			this.m_KitKeys = new int[num6];
			this.m_LeagueKeys = new int[num2];
			this.m_CountryKeys = new int[num];
			this.m_RefereeKeys = new int[num7];
			this.m_StadiumKeys = new int[num8];
			this.m_FormationKeys = new int[num9];
			this.m_LanguageKeys = new int[num10];
			num = 0;
			num2 = 0;
			num3 = 0;
			num4 = 0;
			num5 = 0;
			num6 = 0;
			num7 = 0;
			num8 = 0;
			num9 = 0;
			num10 = 0;
			foreach (object obj2 in this.listViewDest.Items)
			{
				ListViewItem listViewItem2 = (ListViewItem)obj2;
				object tag2 = listViewItem2.Tag;
				string name2 = listViewItem2.Tag.GetType().Name;
				if (name2 == "Player")
				{
					Player player = (Player)tag2;
					this.m_PlayerKeys[num4++] = player.Id;
					this.m_PlayerNameKeys[num5++] = player.firstnameid;
					this.m_PlayerNameKeys[num5++] = player.lastnameid;
					this.m_PlayerNameKeys[num5++] = player.commonnameid;
					this.m_PlayerNameKeys[num5++] = player.playerjerseynameid;
				}
				else if (name2 == "Team")
				{
					Team team = (Team)tag2;
					this.m_TeamKeys[num3++] = team.Id;
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetTeamHash(team.Id, Language.ETeamStringType.Full);
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetTeamHash(team.Id, Language.ETeamStringType.Abbr10);
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetTeamHash(team.Id, Language.ETeamStringType.Abbr15);
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetTeamHash(team.Id, Language.ETeamStringType.Abbr7);
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetTeamHash(team.Id, Language.ETeamStringType.Abbr3);
				}
				else if (name2 == "Kit")
				{
					Kit kit = (Kit)tag2;
					this.m_KitKeys[num6++] = kit.Id;
				}
				else if (name2 == "League")
				{
					League league = (League)tag2;
					this.m_LeagueKeys[num2++] = league.Id;
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetLeagueHash(league.Id, Language.ELeagueStringType.Abbr15);
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetLeagueHash(league.Id, Language.ELeagueStringType.Full);
				}
				else if (name2 == "Country")
				{
					Country country = (Country)tag2;
					this.m_CountryKeys[num++] = country.Id;
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetCountryHash(country.Id, Language.ECountryStringType.Full);
				}
				else if (name2 == "Stadium")
				{
					Stadium stadium = (Stadium)tag2;
					this.m_StadiumKeys[num8++] = stadium.Id;
					this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetStadiumHash(stadium.Id);
				}
				else if (name2 == "Referee")
				{
					Referee referee = (Referee)tag2;
					this.m_RefereeKeys[num7++] = referee.Id;
				}
				else if (!(name2 == "Sponsor"))
				{
					if (name2 == "Formation")
					{
						Formation formation = (Formation)tag2;
						this.m_FormationKeys[num9++] = formation.Id;
					}
					else if (name2 == "Ball")
					{
						Ball ball = (Ball)tag2;
						this.m_LanguageKeys[num10++] = (int)FifaEnvironment.Language.GetBallHash(ball.Id);
					}
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001DF08 File Offset: 0x0001C108
		private bool AddStreamToZip(ZipOutputStream zip, Stream inputStream, string fileName)
		{
			if (inputStream == null)
			{
				return false;
			}
			Crc32 crc = new Crc32();
			byte[] array = new byte[inputStream.Length];
			inputStream.Read(array, 0, array.Length);
			ZipEntry zipEntry = new ZipEntry(fileName);
			zipEntry.DateTime = DateTime.Now;
			zipEntry.Size = inputStream.Length;
			crc.Reset();
			crc.Update(array);
			zipEntry.Crc = crc.Value;
			zip.PutNextEntry(zipEntry);
			zip.Write(array, 0, array.Length);
			return true;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001DF84 File Offset: 0x0001C184
		private void OpenPatch()
		{
			this.openFileDialog.CheckFileExists = true;
			this.openFileDialog.Title = "Open Creation Master Patch file";
			this.openFileDialog.Filter = "Creation Master Patch (*.cmp)|*.cmp";
			this.openFileDialog.FilterIndex = 1;
			this.openFileDialog.Multiselect = false;
			if (this.openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = this.openFileDialog.FileName;
			if (!File.Exists(fileName))
			{
				return;
			}
			this.Refresh();
			Cursor.Current = Cursors.WaitCursor;
			if (Directory.Exists(this.m_TempFolder))
			{
				Directory.Delete(this.m_TempFolder, true);
			}
			Directory.CreateDirectory(this.m_TempFolder);
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			new ZipFile(fileName);
			ZipInputStream zipInputStream = new ZipInputStream(fileStream);
			this.ZipExtractAllFiles(zipInputStream, this.m_TempFolder);
			zipInputStream.Close();
			this.m_PatchDataSet.Clear();
			this.m_PatchDataSet.ReadXml(this.m_TempFolder + "\\Patch.xml");
			DataRow dataRow = this.m_PatchDataSet.PatchIdentity.Rows[0];
			this.textDescription.Text = (string)dataRow["Description"];
			this.textPatchName.Text = (string)dataRow["Name"];
			this.textPatchVersion.Text = (string)dataRow["Version"];
			this.checkCMSCompatible.Checked = (string)dataRow["CMS"] == "CMS 14";
			this.listViewDest.Items.Clear();
			foreach (object obj in this.m_PatchDataSet.PatchElements.Rows)
			{
				DataRow dataRow2 = (DataRow)obj;
				string[] array = new string[]
				{
					null,
					(string)dataRow2.ItemArray[1],
					(string)dataRow2.ItemArray[2],
					(string)dataRow2.ItemArray[3]
				};
				array[0] = (string)dataRow2.ItemArray[0];
				string text = array[1];
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 2284071160U)
				{
					if (num <= 589941036U)
					{
						if (num <= 477166624U)
						{
							if (num != 83164785U)
							{
								if (num == 477166624U)
								{
									if (text == "Player")
									{
										Player player = (Player)FifaEnvironment.Players.SearchId(Convert.ToInt32(array[2]));
										if (player != null)
										{
											this.WriteToPatchList(player, player.Id, array[3], array[0]);
										}
									}
								}
							}
							else if (text == "Country")
							{
								Country country = (Country)FifaEnvironment.Countries.SearchId(Convert.ToInt32(array[2]));
								if (country != null)
								{
									this.WriteToPatchList(country, country.Id, array[3], array[0]);
								}
							}
						}
						else if (num != 503435085U)
						{
							if (num == 589941036U)
							{
								if (text == "Team")
								{
									Team team = (Team)FifaEnvironment.Teams.SearchId(Convert.ToInt32(array[2]));
									if (team != null)
									{
										this.WriteToPatchList(team, team.Id, array[3], array[0]);
									}
								}
							}
						}
						else if (text == "NumberFont")
						{
							NumberFont numberFont = (NumberFont)FifaEnvironment.NumberFonts.SearchId(Convert.ToInt32(array[2]));
							if (numberFont != null)
							{
								this.WriteToPatchList(numberFont, numberFont.Id, array[3], array[0]);
							}
						}
					}
					else if (num <= 1489107955U)
					{
						if (num != 851336175U)
						{
							if (num == 1489107955U)
							{
								if (text == "Shoes")
								{
									Shoes shoes = (Shoes)FifaEnvironment.Shoes.SearchId(Convert.ToInt32(array[2]));
									if (shoes != null)
									{
										this.WriteToPatchList(shoes, shoes.Id, array[3], array[0]);
									}
								}
							}
						}
						else if (text == "Referee")
						{
							Referee referee = (Referee)FifaEnvironment.Referees.SearchId(Convert.ToInt32(array[2]));
							if (referee != null)
							{
								this.WriteToPatchList(referee, referee.Id, array[3], array[0]);
							}
						}
					}
					else if (num != 1584582000U)
					{
						if (num == 2284071160U)
						{
							if (text == "Net")
							{
								Net net = (Net)FifaEnvironment.Nets.SearchId(Convert.ToInt32(array[2]));
								if (net != null)
								{
									this.WriteToPatchList(net, net.Id, array[3], array[0]);
								}
							}
						}
					}
					else if (text == "League")
					{
						League league = (League)FifaEnvironment.Leagues.SearchId(Convert.ToInt32(array[2]));
						if (league != null)
						{
							this.WriteToPatchList(league, league.Id, array[3], array[0]);
						}
					}
				}
				else if (num <= 3256015449U)
				{
					if (num <= 2961892748U)
					{
						if (num != 2607824260U)
						{
							if (num == 2961892748U)
							{
								if (text == "Formation")
								{
									Formation formation = (Formation)FifaEnvironment.Formations.SearchId(Convert.ToInt32(array[2]));
									if (formation != null)
									{
										this.WriteToPatchList(formation, formation.Id, array[3], array[0]);
									}
								}
							}
						}
						else if (text == "Ball")
						{
							Ball ball = (Ball)FifaEnvironment.Balls.SearchId(Convert.ToInt32(array[2]));
							if (ball != null)
							{
								this.WriteToPatchList(ball, ball.Id, array[3], array[0]);
							}
						}
					}
					else if (num != 2997197560U)
					{
						if (num == 3256015449U)
						{
							if (text == "GkGloves")
							{
								GkGloves gkGloves = (GkGloves)FifaEnvironment.GkGloves.SearchId(Convert.ToInt32(array[2]));
								if (gkGloves != null)
								{
									this.WriteToPatchList(gkGloves, gkGloves.Id, array[3], array[0]);
								}
							}
						}
					}
					else if (text == "Adboard")
					{
						Adboard adboard = (Adboard)FifaEnvironment.Adboards.SearchId(Convert.ToInt32(array[2]));
						if (adboard != null)
						{
							this.WriteToPatchList(adboard, adboard.Id, array[3], array[0]);
						}
					}
				}
				else if (num <= 3566549328U)
				{
					if (num != 3523001303U)
					{
						if (num == 3566549328U)
						{
							if (text == "MowingPattern")
							{
								MowingPattern mowingPattern = (MowingPattern)FifaEnvironment.MowingPatterns.SearchId(Convert.ToInt32(array[2]));
								if (mowingPattern != null)
								{
									this.WriteToPatchList(mowingPattern, mowingPattern.Id, array[3], array[0]);
								}
							}
						}
					}
					else if (text == "Kit")
					{
						Kit kit = (Kit)FifaEnvironment.Kits.SearchId(Convert.ToInt32(array[2]));
						if (kit != null)
						{
							this.WriteToPatchList(kit, kit.Id, array[3], array[0]);
						}
					}
				}
				else if (num != 3762777929U)
				{
					if (num == 3807074343U)
					{
						if (text == "NameFont")
						{
							NameFont nameFont = (NameFont)FifaEnvironment.NameFonts.SearchId(Convert.ToInt32(array[2]));
							if (nameFont != null)
							{
								this.WriteToPatchList(nameFont, nameFont.Id, array[3], array[0]);
							}
						}
					}
				}
				else if (!(text == "Sponsor"))
				{
				}
			}
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0001E808 File Offset: 0x0001CA08
		private void buttonOpenPatch_Click(object sender, EventArgs e)
		{
			this.OpenPatch();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001E810 File Offset: 0x0001CA10
		private void ZipExtractAllFiles(ZipInputStream zip, string exportFolder)
		{
			ZipEntry nextEntry;
			while ((nextEntry = zip.GetNextEntry()) != null)
			{
				this.ZipExtractSingleFile(zip, nextEntry, exportFolder);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001E834 File Offset: 0x0001CA34
		private void ZipExtractSingleFile(ZipInputStream zip, ZipEntry zipEntry, string exportFolder)
		{
			string text = exportFolder + "\\" + Path.GetDirectoryName(zipEntry.Name);
			if (Path.GetFileName(zipEntry.Name) != string.Empty)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				FileStream fileStream = File.Create(exportFolder + "\\" + zipEntry.Name);
				byte[] array = new byte[2048];
				for (;;)
				{
					int num = zip.Read(array, 0, array.Length);
					if (num <= 0)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
				fileStream.Close();
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001E8C7 File Offset: 0x0001CAC7
		private void buttonNewPatch_Click(object sender, EventArgs e)
		{
			this.InitPatchCreatorForm();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001E8D0 File Offset: 0x0001CAD0
		private void InitPatchCreatorForm()
		{
			this.listViewDest.Items.Clear();
			this.textDescription.Text = string.Empty;
			this.textPatchName.Text = string.Empty;
			this.textPatchVersion.Text = string.Empty;
			this.checkCMSCompatible.Checked = false;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001C96F File Offset: 0x0001AB6F
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001E8C7 File Offset: 0x0001CAC7
		private void newPatchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.InitPatchCreatorForm();
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001C977 File Offset: 0x0001AB77
		private void createPatchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CreatePatch();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001E808 File Offset: 0x0001CA08
		private void openPatchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenPatch();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void buttonAddFile_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040001BC RID: 444
		private string m_TempFolder;

		// Token: 0x040001BD RID: 445
		private PatchCreatorForm.EPatchType m_PatchType;

		// Token: 0x040001BE RID: 446
		private DataSet m_FifaDataSet = new DataSet("FIFA14");

		// Token: 0x040001BF RID: 447
		private DataSet m_LangDataSet = new DataSet("LANG14");

		// Token: 0x040001C0 RID: 448
		private int[] m_PlayerKeys;

		// Token: 0x040001C1 RID: 449
		private int[] m_PlayerNameKeys;

		// Token: 0x040001C2 RID: 450
		private int[] m_TeamKeys;

		// Token: 0x040001C3 RID: 451
		private int[] m_KitKeys;

		// Token: 0x040001C4 RID: 452
		private int[] m_LeagueKeys;

		// Token: 0x040001C5 RID: 453
		private int[] m_CountryKeys;

		// Token: 0x040001C6 RID: 454
		private int[] m_RefereeKeys;

		// Token: 0x040001C7 RID: 455
		private int[] m_StadiumKeys;

		// Token: 0x040001C8 RID: 456
		private int[] m_FormationKeys;

		// Token: 0x040001C9 RID: 457
		private int[] m_LanguageKeys;

		// Token: 0x040001CA RID: 458
		private DataTable m_PlayersTable;

		// Token: 0x040001CB RID: 459
		private DataTable m_PlayernamesTable;

		// Token: 0x040001CC RID: 460
		private DataTable m_PlayerLoansTable;

		// Token: 0x040001CD RID: 461
		private DataTable m_TeamsTable;

		// Token: 0x040001CE RID: 462
		private DataTable m_TeamkitsTable;

		// Token: 0x040001CF RID: 463
		private DataTable m_TeamplayerlinksTable;

		// Token: 0x040001D0 RID: 464
		private DataTable m_LeaguesTable;

		// Token: 0x040001D1 RID: 465
		private DataTable m_BoardOutcomesTable;

		// Token: 0x040001D2 RID: 466
		private DataTable m_LeagueTeamLinksTable;

		// Token: 0x040001D3 RID: 467
		private DataTable m_NationsTable;

		// Token: 0x040001D4 RID: 468
		private DataTable m_AudionationsTable;

		// Token: 0x040001D5 RID: 469
		private DataTable m_TeamStadiumLinksTable;

		// Token: 0x040001D6 RID: 470
		private DataTable m_TeamFormationTeamStyleLinksTable;

		// Token: 0x040001D7 RID: 471
		private DataTable m_RowTeamNationLinksTable;

		// Token: 0x040001D8 RID: 472
		private DataTable m_TeamNationLinksTable;

		// Token: 0x040001D9 RID: 473
		private DataTable m_RefereesTable;

		// Token: 0x040001DA RID: 474
		private DataTable m_StadiumsTable;

		// Token: 0x040001DB RID: 475
		private DataTable m_StadiumAssignmentsTable;

		// Token: 0x040001DC RID: 476
		private DataTable m_ManagerTable;

		// Token: 0x040001DD RID: 477
		private DataTable m_FormationsTable;

		// Token: 0x040001DE RID: 478
		private DataTable m_LanguageTable;

		// Token: 0x0200002D RID: 45
		public enum EPatchType
		{
			// Token: 0x04000A64 RID: 2660
			Country,
			// Token: 0x04000A65 RID: 2661
			League,
			// Token: 0x04000A66 RID: 2662
			Team,
			// Token: 0x04000A67 RID: 2663
			Player,
			// Token: 0x04000A68 RID: 2664
			Kit,
			// Token: 0x04000A69 RID: 2665
			Referee,
			// Token: 0x04000A6A RID: 2666
			Stadium,
			// Token: 0x04000A6B RID: 2667
			Formation,
			// Token: 0x04000A6C RID: 2668
			Ball,
			// Token: 0x04000A6D RID: 2669
			Adboard,
			// Token: 0x04000A6E RID: 2670
			NumberFont,
			// Token: 0x04000A6F RID: 2671
			NameFont,
			// Token: 0x04000A70 RID: 2672
			Shoes,
			// Token: 0x04000A71 RID: 2673
			GKGloves,
			// Token: 0x04000A72 RID: 2674
			Net,
			// Token: 0x04000A73 RID: 2675
			MowingPattern
		}
	}
}
