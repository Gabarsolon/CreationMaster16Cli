using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000008 RID: 8
	public partial class LeagueForm : Form
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x0001490C File Offset: 0x00012B0C
		public LeagueForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectLeague);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateLeague);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteLeague);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshLeague);
			this.viewer2DLeagueTinyLogo.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageLeagueTinyLogo);
			this.viewer2DLeagueTinyLogo.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteLeagueTinyLogo);
			this.viewer2DLeagueTinyLogo.ButtonStripVisible = true;
			this.viewer2DLeagueTinyLogo.RemoveButton = true;
			this.viewer2DLeagueAnimLogo.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageLeagueAnimLogo);
			this.viewer2DLeagueAnimLogo.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteLeagueAnimLogo);
			this.viewer2DLeagueAnimLogo.ButtonStripVisible = true;
			this.viewer2DLeagueAnimLogo.RemoveButton = true;
			this.viewer2DLeague512x128Logo.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageLeagueLogo512x128);
			this.viewer2DLeague512x128Logo.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteLeagueLogo512x128);
			this.viewer2DLeague512x128Logo.ButtonStripVisible = true;
			this.viewer2DLeague512x128Logo.RemoveButton = true;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00014A68 File Offset: 0x00012C68
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Leagues;
			this.buttonreplicateLeagueLogo512x128.Visible = (this.viewer2DLeague512x128Logo.Visible = FifaEnvironment.Year > 14);
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Countries
			};
			this.pickUpControl.FilterValues = array;
			this.numericLeagueId.Maximum = FifaEnvironment.Leagues.MaxId;
			this.RefreshComboBoxes();
			this.pickUpControl.ObjectList = FifaEnvironment.Leagues;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00014AF8 File Offset: 0x00012CF8
		public void RefreshComboBoxes()
		{
			if (this.comboTeamAvailable.Items.Count != FifaEnvironment.Teams.Count)
			{
				this.comboTeamAvailable.Items.Clear();
				this.comboTeamAvailable.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
			if (this.comboLeagueCountry.Items.Count != FifaEnvironment.Countries.Count + 1)
			{
				this.comboLeagueCountry.Items.Clear();
				this.comboLeagueCountry.Items.Add("None");
				this.comboLeagueCountry.Items.AddRange(FifaEnvironment.Countries.ToArray());
			}
			if (this.comboSwitchLeagues.Items.Count != FifaEnvironment.Leagues.Count + 1)
			{
				this.comboSwitchLeagues.Items.Clear();
				this.comboSwitchLeagues.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00014BF4 File Offset: 0x00012DF4
		private League SelectLeague(object sender, object obj)
		{
			League league = (League)obj;
			this.Refresh();
			this.LoadLeague(league);
			return league;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00014C18 File Offset: 0x00012E18
		private League CreateLeague(object sender, object obj)
		{
			DialogResult dialogResult = this.m_NewIdCreator.ShowDialog();
			if (this.m_NewIdCreator.NewObject == null)
			{
				if (dialogResult == DialogResult.OK)
				{
					FifaEnvironment.UserMessages.ShowMessage(5060, this.m_NewIdCreator.NewId);
				}
				return null;
			}
			League league = (League)this.m_NewIdCreator.NewObject;
			if (this.m_NewIdCreator.NewName != null && league != null)
			{
				league.leaguename = this.m_NewIdCreator.NewName;
				League league2 = league;
				league2.ShortName = league2.leaguename;
			}
			return league;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00014CA0 File Offset: 0x00012EA0
		private League DeleteLeague(object sender, object obj)
		{
			League league = (League)obj;
			FifaEnvironment.Leagues.DeleteLeague(league);
			this.m_CurrentLeague = null;
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00014CC7 File Offset: 0x00012EC7
		public League RefreshLeague(object sender, object obj)
		{
			this.Preset();
			this.ReloadLeague(this.m_CurrentLeague);
			return this.m_CurrentLeague;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00014CE1 File Offset: 0x00012EE1
		private bool ImportImageLeagueLogo512x128(object sender, Bitmap bitmap)
		{
			this.m_CurrentLeague.SetLogo512x128Dark(bitmap);
			return this.m_CurrentLeague.SetLogo512x128(bitmap);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00014CFC File Offset: 0x00012EFC
		private bool DeleteLeagueLogo512x128(object sender)
		{
			this.m_CurrentLeague.DeleteLogo512x128Dark();
			return this.m_CurrentLeague.DeleteLogo512x128();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00014D15 File Offset: 0x00012F15
		private bool ImportImageLeagueTinyLogo(object sender, Bitmap bitmap)
		{
			this.m_CurrentLeague.SetTinyLogoDark(bitmap);
			return this.m_CurrentLeague.SetTinyLogo(bitmap);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00014D30 File Offset: 0x00012F30
		private bool DeleteLeagueTinyLogo(object sender)
		{
			this.m_CurrentLeague.DeleteTinyLogoDark();
			return this.m_CurrentLeague.DeleteTinyLogo();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00014D49 File Offset: 0x00012F49
		private bool ImportImageLeagueAnimLogo(object sender, Bitmap bitmap)
		{
			this.m_CurrentLeague.SetAnimLogoDark(bitmap);
			return this.m_CurrentLeague.SetAnimLogo(bitmap);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00014D64 File Offset: 0x00012F64
		private bool DeleteLeagueAnimLogo(object sender)
		{
			return this.m_CurrentLeague.DeleteAnimLogo();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00014D71 File Offset: 0x00012F71
		private bool ImportImageLeagueSmallLogo(object sender, Bitmap bitmap)
		{
			this.m_CurrentLeague.SetSmallLogoDark(bitmap);
			return this.m_CurrentLeague.SetSmallLogo(bitmap);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00014D8C File Offset: 0x00012F8C
		private bool DeleteLeagueSmallLogo(object sender)
		{
			return this.m_CurrentLeague.DeleteSmallLogo();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00014D99 File Offset: 0x00012F99
		public void ReloadLeague(League league)
		{
			this.m_CurrentLeague = null;
			this.LoadLeague(league);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00014DAC File Offset: 0x00012FAC
		public void LoadLeague(League league)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentLeague == league)
			{
				return;
			}
			this.m_Locked = true;
			this.m_CurrentLeague = league;
			this.leagueBindingSource.DataSource = this.m_CurrentLeague;
			this.comboTeamAvailable.Text = "";
			this.numericLeagueId.Value = this.m_CurrentLeague.Id;
			if (this.m_CurrentLeague.Country == null)
			{
				this.comboLeagueCountry.SelectedIndex = 0;
			}
			else
			{
				this.comboLeagueCountry.SelectedItem = this.m_CurrentLeague.Country;
			}
			this.InitListViewPlayingTeams(league.PlayingTeams);
			this.viewer2DLeagueTinyLogo.CurrentBitmap = league.GetTinyLogo();
			this.viewer2DLeagueAnimLogo.CurrentBitmap = league.GetAnimLogo();
			this.viewer2DLeague512x128Logo.CurrentBitmap = league.GetLogo512x128();
			this.labelThisLeague.Text = league.ShortName;
			this.buttonSwitchLeagueIds.Enabled = this.comboSwitchLeagues.SelectedItem != null;
			this.comboLeaguePrestige.SelectedIndex = (int)this.m_CurrentLeague.Prestige;
			this.numericBoardOutcome1.Value = this.m_CurrentLeague.boardoutcomes[0];
			this.numericBoardOutcome2.Value = this.m_CurrentLeague.boardoutcomes[1];
			this.numericBoardOutcome3.Value = this.m_CurrentLeague.boardoutcomes[2];
			this.numericBoardOutcome4.Value = this.m_CurrentLeague.boardoutcomes[3];
			this.numericBoardOutcome5.Value = this.m_CurrentLeague.boardoutcomes[4];
			this.m_Locked = false;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00014F60 File Offset: 0x00013160
		private void InitListViewPlayingTeams(TeamList playingTeams)
		{
			this.listViewPlayingTeams.BeginUpdate();
			this.listViewPlayingTeams.Items.Clear();
			this.imageListTeamLogos.Images.Clear();
			for (int i = 0; i < playingTeams.Count; i++)
			{
				Team team = (Team)playingTeams[i];
				Bitmap bitmap = null;
				if (this.checkShowTeamLogo.Checked)
				{
					bitmap = team.GetCrest32();
				}
				if (bitmap != null)
				{
					this.imageListTeamLogos.Images.Add(team.ToString(), bitmap);
				}
				ListViewItem listViewItem = new ListViewItem(team.ToString());
				listViewItem.Tag = team;
				this.listViewPlayingTeams.Items.Add(listViewItem);
				this.listViewPlayingTeams.Items[i].ImageKey = team.ToString();
			}
			if (this.listViewPlayingTeams.Items.Count > 0)
			{
				this.listViewPlayingTeams.Items[0].Selected = true;
			}
			this.listViewPlayingTeams.EndUpdate();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00015062 File Offset: 0x00013262
		private void textLeagueShortName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentLeague.ShortName = this.textLeagueShortName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentLeague);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00015094 File Offset: 0x00013294
		private void textLeagueFullName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentLeague.LongName = this.textLeagueFullName.Text;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000150B8 File Offset: 0x000132B8
		private void numericLeagueId_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericLeagueId.Value;
			if (num == this.m_CurrentLeague.Id)
			{
				return;
			}
			if (FifaEnvironment.Leagues.SearchId(num) == null)
			{
				FifaEnvironment.Leagues.ChangeId(this.m_CurrentLeague, num);
				this.viewer2DLeagueTinyLogo.CurrentBitmap = this.m_CurrentLeague.GetTinyLogo();
				this.viewer2DLeagueAnimLogo.CurrentBitmap = this.m_CurrentLeague.GetAnimLogo();
				this.viewer2DLeague512x128Logo.CurrentBitmap = this.m_CurrentLeague.GetLogo512x128();
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericLeagueId.Value = this.m_CurrentLeague.Id;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001517C File Offset: 0x0001337C
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Leagues.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericLeagueId.Value = newId;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000151BA File Offset: 0x000133BA
		private void checkShowTeamLogo_CheckedChanged(object sender, EventArgs e)
		{
			this.InitListViewPlayingTeams(this.m_CurrentLeague.PlayingTeams);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000151D0 File Offset: 0x000133D0
		private int GetTeamIndex(Team team)
		{
			for (int i = 0; i < this.listViewPlayingTeams.Items.Count; i++)
			{
				if (this.listViewPlayingTeams.Items[i].Tag == team)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00015214 File Offset: 0x00013414
		private bool AddTeam()
		{
			if (this.comboTeamAvailable.SelectedItem == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(1000);
				return false;
			}
			Team team = (Team)this.comboTeamAvailable.SelectedItem;
			ListViewItem listViewItem = new ListViewItem(team.ToString(), team.ToString());
			listViewItem.Tag = team;
			if (this.GetTeamIndex(team) >= 0)
			{
				FifaEnvironment.UserMessages.ShowMessage(1001);
				return false;
			}
			if (this.checkShowTeamLogo.Checked)
			{
				Bitmap crest = team.GetCrest32();
				if (crest != null)
				{
					this.imageListTeamLogos.Images.Add(team.ToString(), crest);
				}
				if (crest != null)
				{
					this.imageListTeamLogos.Images.Add(team.ToString(), crest);
				}
			}
			this.listViewPlayingTeams.Items.Add(listViewItem);
			this.m_CurrentLeague.AddTeam(team);
			return true;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000152ED File Offset: 0x000134ED
		private void buttonAddTeam_Click(object sender, EventArgs e)
		{
			this.AddTeam();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000152F8 File Offset: 0x000134F8
		private bool RemoveTeam()
		{
			if (this.listViewPlayingTeams.SelectedItems.Count <= 0)
			{
				FifaEnvironment.UserMessages.ShowMessage(1002);
				return false;
			}
			Team team = (Team)this.listViewPlayingTeams.SelectedItems[0].Tag;
			if (team == null)
			{
				return false;
			}
			int teamIndex = this.GetTeamIndex(team);
			if (teamIndex < 0)
			{
				return false;
			}
			this.listViewPlayingTeams.Items.RemoveAt(teamIndex);
			this.imageListTeamLogos.Images.RemoveByKey(team.ToString());
			this.m_CurrentLeague.RemoveTeam(team);
			return true;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001538D File Offset: 0x0001358D
		private void buttonRemoveTeam_Click(object sender, EventArgs e)
		{
			this.RemoveTeam();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00015396 File Offset: 0x00013596
		private void buttonReplaceTeam_Click(object sender, EventArgs e)
		{
			if (!this.RemoveTeam())
			{
				return;
			}
			this.AddTeam();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000153A8 File Offset: 0x000135A8
		private void listViewPlayingTeams_DoubleClick(object sender, EventArgs e)
		{
			if (this.listViewPlayingTeams.SelectedItems.Count <= 0)
			{
				return;
			}
			Team team = (Team)this.listViewPlayingTeams.SelectedItems[0].Tag;
			if (team != null)
			{
				MainForm.CM.JumpTo(team);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000153F3 File Offset: 0x000135F3
		private void labelCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentLeague.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentLeague.Country);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00015417 File Offset: 0x00013617
		private void LeagueForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00015428 File Offset: 0x00013628
		private void comboLeagueCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeagueCountry.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboLeagueCountry.SelectedIndex == 0)
			{
				this.m_CurrentLeague.Country = null;
				return;
			}
			this.m_CurrentLeague.Country = (Country)this.comboLeagueCountry.SelectedItem;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001547C File Offset: 0x0001367C
		private void buttonreplicateLeagueTinyLogo_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DLeagueAnimLogo.CurrentBitmap;
			Bitmap bitmap = new Bitmap(256, 64, PixelFormat.Format32bppPArgb);
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Rectangle rectangle2 = new Rectangle(145, 0, 64, 64);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			this.m_CurrentLeague.SetTinyLogo(bitmap);
			this.m_CurrentLeague.SetTinyLogoDark(bitmap);
			this.viewer2DLeagueTinyLogo.CurrentBitmap = bitmap;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000154F8 File Offset: 0x000136F8
		private void buttonreplicateLeagueLogo512x128_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DLeagueAnimLogo.CurrentBitmap;
			Bitmap bitmap = new Bitmap(512, 128, PixelFormat.Format32bppPArgb);
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Rectangle rectangle2 = new Rectangle(192, 0, 128, 128);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			rectangle2 = new Rectangle(32, 0, 128, 128);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			rectangle2 = new Rectangle(352, 0, 128, 128);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			this.m_CurrentLeague.SetLogo512x128(bitmap);
			this.m_CurrentLeague.SetLogo512x128Dark(bitmap);
			this.viewer2DLeague512x128Logo.CurrentBitmap = bitmap;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000155BC File Offset: 0x000137BC
		private void buttonreplicateLeagueSmallLogo_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DLeagueAnimLogo.CurrentBitmap;
			Bitmap bitmap = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Rectangle rectangle2 = new Rectangle(25, 0, 150, 150);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			this.m_CurrentLeague.SetSmallLogo(bitmap);
			this.m_CurrentLeague.SetSmallLogoDark(bitmap);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00015632 File Offset: 0x00013832
		private void comboSwitchLeagues_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.buttonSwitchLeagueIds.Enabled = this.comboSwitchLeagues.SelectedItem != null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00015650 File Offset: 0x00013850
		private void buttonSwitchLeagueIds_Click(object sender, EventArgs e)
		{
			League league = (League)this.comboSwitchLeagues.SelectedItem;
			if (league == null || league == this.m_CurrentLeague)
			{
				return;
			}
			Bitmap animLogo = this.m_CurrentLeague.GetAnimLogo();
			Bitmap smallLogo = this.m_CurrentLeague.GetSmallLogo();
			Bitmap tinyLogo = this.m_CurrentLeague.GetTinyLogo();
			Bitmap animLogo2 = league.GetAnimLogo();
			Bitmap smallLogo2 = league.GetSmallLogo();
			Bitmap tinyLogo2 = league.GetTinyLogo();
			Trophy trophy = FifaEnvironment.CompetitionObjects.SearchTrophy(this.m_CurrentLeague.Id);
			Trophy trophy2 = FifaEnvironment.CompetitionObjects.SearchTrophy(league.Id);
			Bitmap bitmap = null;
			Bitmap bitmap2 = null;
			Bitmap[] array = null;
			string text = null;
			if (trophy != null)
			{
				bitmap = trophy.GetTrophy256();
				bitmap2 = trophy.GetTrophy128();
				array = trophy.GetTextures();
				text = trophy.ExportModelFile();
			}
			Bitmap bitmap3 = null;
			Bitmap bitmap4 = null;
			Bitmap[] array2 = null;
			string text2 = null;
			if (trophy2 != null)
			{
				bitmap3 = trophy2.GetTrophy256();
				bitmap4 = trophy2.GetTrophy128();
				array2 = trophy2.GetTextures();
				text2 = trophy2.ExportModelFile();
			}
			int id = this.m_CurrentLeague.Id;
			this.m_CurrentLeague.Id = league.Id;
			league.Id = id;
			this.m_CurrentLeague.SetAnimLogo(animLogo);
			this.m_CurrentLeague.SetAnimLogoDark(animLogo);
			this.m_CurrentLeague.SetSmallLogo(smallLogo);
			this.m_CurrentLeague.SetSmallLogoDark(smallLogo);
			this.m_CurrentLeague.SetTinyLogo(tinyLogo);
			this.m_CurrentLeague.SetTinyLogoDark(tinyLogo);
			league.SetAnimLogo(animLogo2);
			league.SetAnimLogoDark(animLogo2);
			league.SetSmallLogo(smallLogo2);
			league.SetSmallLogoDark(smallLogo2);
			league.SetTinyLogo(tinyLogo2);
			league.SetTinyLogoDark(tinyLogo2);
			if (trophy != null)
			{
				trophy.Settings.m_asset_id = league.Id;
				trophy.SetTrophy256(bitmap);
				trophy.SetTrophy128(bitmap2);
				trophy.Settings.m_asset_id = this.m_CurrentLeague.Id;
				trophy.TypeString = "C" + this.m_CurrentLeague.Id.ToString();
				trophy.Description = FifaEnvironment.Language.GetTournamentConventionalString(this.m_CurrentLeague.Id, Language.ETournamentStringType.Abbr15);
				trophy.SetTextures(array);
				trophy.SetModel(text);
			}
			if (trophy2 != null)
			{
				trophy2.Settings.m_asset_id = id;
				trophy2.SetTrophy256(bitmap3);
				trophy2.SetTrophy128(bitmap4);
				trophy2.Settings.m_asset_id = league.Id;
				trophy2.TypeString = "C" + league.Id.ToString();
				trophy2.Description = FifaEnvironment.Language.GetTournamentConventionalString(league.Id, Language.ETournamentStringType.Abbr15);
				trophy2.SetTextures(array2);
				trophy2.SetModel(text2);
			}
			this.numericLeagueId.Value = this.m_CurrentLeague.Id;
			MainForm.CM.m_TrophyForm.ReloadCompetitions();
			this.Preset();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00015944 File Offset: 0x00013B44
		private void buttonLeaguePlayerPlus_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.m_CurrentLeague.PlayingTeams)
			{
				foreach (object obj2 in ((Team)obj).Roster)
				{
					((TeamPlayer)obj2).Player.ChangeSkills(1);
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000159E4 File Offset: 0x00013BE4
		private void buttonLeaguePlayerMinus_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.m_CurrentLeague.PlayingTeams)
			{
				foreach (object obj2 in ((Team)obj).Roster)
				{
					((TeamPlayer)obj2).Player.ChangeSkills(-1);
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00015A84 File Offset: 0x00013C84
		private void numericBoardOutcome1_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentLeague.boardoutcomes[0] = (int)this.numericBoardOutcome1.Value;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00015AA3 File Offset: 0x00013CA3
		private void numericBoardOutcome2_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentLeague.boardoutcomes[1] = (int)this.numericBoardOutcome2.Value;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00015AC2 File Offset: 0x00013CC2
		private void numericBoardOutcome3_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentLeague.boardoutcomes[2] = (int)this.numericBoardOutcome3.Value;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00015AE1 File Offset: 0x00013CE1
		private void numericBoardOutcome4_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentLeague.boardoutcomes[3] = (int)this.numericBoardOutcome4.Value;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00015B00 File Offset: 0x00013D00
		private void numericBoardOutcome5_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentLeague.boardoutcomes[4] = (int)this.numericBoardOutcome5.Value;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00015B20 File Offset: 0x00013D20
		private void button1_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.TempFolder + "\\2017";
			foreach (object obj in FifaEnvironment.Kits)
			{
				Kit kit = (Kit)obj;
				Team team = kit.Team;
				if (team != null && team.League == this.m_CurrentLeague)
				{
					int kittype = kit.kittype;
					Bitmap[] kitTextures = kit.GetKitTextures();
					string text2 = string.Concat(new string[]
					{
						text,
						"\\j_",
						team.Id.ToString(),
						"_",
						kittype.ToString(),
						".png"
					});
					kitTextures[1].Save(text2, ImageFormat.Png);
					text2 = string.Concat(new string[]
					{
						text,
						"\\s_",
						team.Id.ToString(),
						"_",
						kittype.ToString(),
						".png"
					});
					kitTextures[3].Save(text2, ImageFormat.Png);
					for (int i = 0; i < kitTextures.Length; i++)
					{
						kitTextures[i].Dispose();
					}
				}
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00015C8C File Offset: 0x00013E8C
		private void comboLeaguePrestige_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboLeagueCountry.SelectedIndex >= 0)
			{
				this.m_CurrentLeague.Prestige = (ELeaguePrestige)this.comboLeaguePrestige.SelectedIndex;
			}
		}

		// Token: 0x04000144 RID: 324
		private League m_CurrentLeague;

		// Token: 0x04000145 RID: 325
		private bool m_IsLoaded;

		// Token: 0x04000146 RID: 326
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000147 RID: 327
		private bool m_Locked;
	}
}
