using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200001C RID: 28
	public partial class TeamForm : Form
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00066C90 File Offset: 0x00064E90
		public TeamForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectTeam);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateTeam);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteTeam);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshTeam);
			this.viewer2DCrestLarge.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCrest);
			this.viewer2DCrestLarge.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteCrest);
			this.viewer2DCrestLarge.ButtonStripVisible = true;
			this.viewer2DCrestLarge.RemoveButton = true;
			this.viewer2DCrest50.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCrest50);
			this.viewer2DCrest50.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteCrest50);
			this.viewer2DCrest50.ButtonStripVisible = true;
			this.viewer2DCrest50.RemoveButton = true;
			this.viewer2DCrest32.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCrest32);
			this.viewer2DCrest32.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteCrest32);
			this.viewer2DCrest32.ButtonStripVisible = true;
			this.viewer2DCrest32.RemoveButton = true;
			this.viewer2DCrest16.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageCrest16);
			this.viewer2DCrest16.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteCrest16);
			this.viewer2DCrest16.ButtonStripVisible = true;
			this.viewer2DCrest16.RemoveButton = true;
			this.viewer2DAdboards_0.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageAdboard_0);
			this.viewer2DAdboards_0.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteAdboard_0);
			this.viewer2DAdboards_0.ButtonStripVisible = true;
			this.viewer2DAdboards_0.FullSizeButton = true;
			this.viewer2DAdboards_0.RemoveButton = true;
			this.viewer2DAdboards_0.ShowButton = true;
			this.viewer2DAdboards_0.ShowButtonChecked = true;
			this.viewer2DBanners.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageBanners);
			this.viewer2DBanners.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteImageBanners);
			this.viewer2DBanners.ButtonStripVisible = true;
			this.viewer2DBanners.RemoveButton = true;
			this.multiViewer2DFlags15.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3Flags);
			this.multiViewer2DFlags15.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3Flags);
			this.multiViewer2DFlags15.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3Flags);
			this.multiViewer2DFlags15.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3Flags);
			this.viewer2DPhoto.ButtonStripVisible = true;
			this.viewer2DPhoto.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageMiniface);
			this.viewer2DPhoto.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteMiniface);
			this.viewer2DPhoto.ButtonStripVisible = true;
			this.viewer2DPhoto.RemoveButton = true;
			this.viewer2DPhoto.ShowButton = true;
			this.viewer2DPhoto.ShowButtonChecked = true;
			this.viewer2DTeamAdboard.ButtonStripVisible = true;
			this.viewer2DTeamAdboard.ImageImport = new Viewer2D.ImageImportHandler(this.ImportRevModAdboard);
			this.viewer2DTeamAdboard.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteRevModAdboard);
			this.viewer2DTeamNet.ButtonStripVisible = true;
			this.viewer2DTeamNet.ImageImport = new Viewer2D.ImageImportHandler(this.ImportRevModNet);
			this.viewer2DTeamNet.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteRevModNet);
			this.viewer2DTeamManager.ButtonStripVisible = true;
			this.viewer2DTeamManager.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageManager);
			this.viewer2DTeamManager.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteManager);
			this.multiViewer2DTeamScarf.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3Scarf);
			this.multiViewer2DTeamScarf.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3Scarf);
			this.multiViewer2DTeamScarf.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3Scarf);
			this.multiViewer2DTeamScarf.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3Scarf);
			this.multiViewer2DTeamBallTextures.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3BallTextures);
			this.multiViewer2DTeamBallTextures.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3BallTextures);
			this.multiViewer2DTeamBallTextures.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3BallTextures);
			this.multiViewer2DTeamBallTextures.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteRx3BallTextures);
			this.pickUpAvailablePlayers.FilterChanged = new PickUpControl.PickUpCallback(this.AvailablePlayersFilterChanged);
			this.m_WebPlayerTable.Columns.Add("name");
			this.m_WebPlayerTable.Columns.Add("surname");
			this.m_WebPlayerTable.Columns.Add("country");
			this.m_WebPlayerTable.Columns.Add("birthdate");
			this.m_WebPlayerTable.Columns.Add("role");
			this.m_WebPlayerTable.Columns.Add("height");
			this.m_WebPlayerTable.Columns.Add("weight");
			this.m_WebPlayerTable.Columns.Add("foot");
			this.m_WebPlayerTable.Columns.Add("team");
			this.m_WebPlayerTable.Columns.Add("number");
			this.m_WebPlayerTable.Columns.Add("since");
			this.m_WebPlayerTable.Columns.Add("contract");
			this.m_WebPlayerTable.Columns.Add("previousteam");
			this.m_WebPlayerTable.Columns.Add("loanedfrom");
			this.m_WebPlayerTable.Columns.Add("loanenddate");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000672E4 File Offset: 0x000654E4
		private void tableEditTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tableEditTeam.SelectedIndex >= 0)
			{
				this.UpdateCurrentPage();
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000672FC File Offset: 0x000654FC
		public void UpdateCurrentPage()
		{
			this.m_CurrentPage = this.tableEditTeam.SelectedTab;
			if (this.m_CurrentPage == this.pageTeamAdboard)
			{
				this.LoadAdboardPage();
				return;
			}
			if (this.m_CurrentPage == this.pageTeamFlags)
			{
				this.LoadFlagsPage();
				return;
			}
			if (this.m_CurrentPage == this.pageTeamGeneric)
			{
				this.LoadGenericPage();
				return;
			}
			if (this.m_CurrentPage == this.pageTeamRoster)
			{
				this.LoadRosterPage();
				return;
			}
			if (this.m_CurrentPage == this.pageTeamrevMod)
			{
				this.LoadRevModPage();
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00067382 File Offset: 0x00065582
		private bool ImportImageCrest(object sender, Bitmap bitmap)
		{
			this.m_CurrentTeam.SetCrestDark(bitmap);
			return this.m_CurrentTeam.SetCrest(bitmap);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0006739D File Offset: 0x0006559D
		private bool DeleteCrest(object sender)
		{
			return this.m_CurrentTeam.DeleteCrest();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000673AA File Offset: 0x000655AA
		private bool ImportImageCrest50(object sender, Bitmap bitmap)
		{
			this.m_CurrentTeam.SetCrest50Dark(bitmap);
			return this.m_CurrentTeam.SetCrest50(bitmap);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000673C5 File Offset: 0x000655C5
		private bool DeleteCrest50(object sender)
		{
			this.m_CurrentTeam.DeleteCrest50Dark();
			return this.m_CurrentTeam.DeleteCrest50();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000673DE File Offset: 0x000655DE
		private bool ImportImageCrest32(object sender, Bitmap bitmap)
		{
			this.m_CurrentTeam.SetCrest32Dark(bitmap);
			return this.m_CurrentTeam.SetCrest32(bitmap);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000673F9 File Offset: 0x000655F9
		private bool DeleteCrest32(object sender)
		{
			this.m_CurrentTeam.DeleteCrest32Dark();
			return this.m_CurrentTeam.DeleteCrest32();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00067412 File Offset: 0x00065612
		private bool ImportImageCrest16(object sender, Bitmap bitmap)
		{
			this.m_CurrentTeam.SetCrest16Dark(bitmap);
			return this.m_CurrentTeam.SetCrest16(bitmap);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0006742D File Offset: 0x0006562D
		private bool DeleteCrest16(object sender)
		{
			this.m_CurrentTeam.DeleteCrest16Dark();
			return this.m_CurrentTeam.DeleteCrest16();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00067446 File Offset: 0x00065646
		private bool ImportImageAdboard_0(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeam.SetAdboard(bitmap);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00067454 File Offset: 0x00065654
		private bool DeleteAdboard_0(object sender)
		{
			return Adboard.DeleteAdboard(this.m_CurrentTeam.adboardid);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00067466 File Offset: 0x00065666
		private bool ImportRevModAdboard(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeam.SetRevModAdboard(bitmap);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00067474 File Offset: 0x00065674
		private bool DeleteRevModAdboard(object sender)
		{
			return Adboard.DeleteRevModTeamAdboard(this.m_CurrentTeam.Id);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00067486 File Offset: 0x00065686
		private bool ImportRevModNet(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeam.SetRevModNet(bitmap);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00067494 File Offset: 0x00065694
		private bool DeleteRevModNet(object sender)
		{
			return Net.DeleteRevModNet(this.m_CurrentTeam.Id);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000674A6 File Offset: 0x000656A6
		private bool ImportImageBanners(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeam.SetBanner(bitmap);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000674B4 File Offset: 0x000656B4
		private bool DeleteImageBanners(object sender)
		{
			return this.m_CurrentTeam.DeleteBanner();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000674C1 File Offset: 0x000656C1
		private bool ImportRx3Flags(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentTeam.SetFlags(rx3FileName);
			if (flag)
			{
				this.LoadFlagsPage();
			}
			return flag;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000674D8 File Offset: 0x000656D8
		private bool ExportRx3Flags(object sender, string exportDir)
		{
			return this.m_CurrentTeam.ExportFlags(exportDir);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000674E6 File Offset: 0x000656E6
		private bool SaveRx3Flags(object sender, Bitmap[] bitmaps)
		{
			return this.m_CurrentTeam.SetFlags(bitmaps);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000674F4 File Offset: 0x000656F4
		private bool DeleteRx3Flags(object sender)
		{
			return this.m_CurrentTeam.DeleteFlag();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00067501 File Offset: 0x00065701
		private bool ImportRx3Scarf(object sender, string rx3FileName)
		{
			return this.m_CurrentTeam.SetScarfs(rx3FileName);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0006750F File Offset: 0x0006570F
		private bool ExportRx3Scarf(object sender, string exportDir)
		{
			return this.m_CurrentTeam.ExportScarfs(exportDir);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0006751D File Offset: 0x0006571D
		private bool SaveRx3Scarf(object sender, Bitmap[] bitmaps)
		{
			return this.m_CurrentTeam.SetScarfs(bitmaps);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0006752B File Offset: 0x0006572B
		private bool DeleteRx3Scarf(object sender)
		{
			return this.m_CurrentTeam.DeleteScarf();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00067538 File Offset: 0x00065738
		private bool ImportRx3BallTextures(object sender, string rx3FileName)
		{
			return this.m_CurrentTeam.SetRevModBallTextures(rx3FileName);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00067546 File Offset: 0x00065746
		private bool ExportRx3BallTextures(object sender, string exportDir)
		{
			return this.m_CurrentTeam.ExportRevModBallTextures(exportDir);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00067554 File Offset: 0x00065754
		private bool SaveRx3BallTextures(object sender, Bitmap[] bitmaps)
		{
			return this.m_CurrentTeam.SetRevModBallTextures(bitmaps);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00067562 File Offset: 0x00065762
		private bool DeleteRx3BallTextures(object sender)
		{
			return this.m_CurrentTeam.DeleteRevModBallTextures();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0006756F File Offset: 0x0006576F
		private bool ImportImageMiniface(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeamPlayer.Player.SetPhoto(bitmap);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00067582 File Offset: 0x00065782
		private bool DeleteMiniface(object sender)
		{
			return this.m_CurrentTeamPlayer.Player.DeletePhoto();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00067594 File Offset: 0x00065794
		private Team SelectTeam(object sender, object obj)
		{
			Team team = (Team)obj;
			this.Refresh();
			this.LoadTeam(team);
			return team;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000675B8 File Offset: 0x000657B8
		private Team CreateTeam(object sender, object obj)
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
			Team team = (Team)this.m_NewIdCreator.NewObject;
			if (this.m_NewIdCreator.NewName != null && team != null)
			{
				team.TeamNameFull = this.m_NewIdCreator.NewName;
				team.DatabaseName = this.m_NewIdCreator.NewName;
				if (team.TeamNameFull.Length > 15)
				{
					Team team2 = team;
					team2.TeamNameAbbr15 = team2.TeamNameFull.Substring(0, 15);
				}
				else
				{
					Team team3 = team;
					team3.TeamNameAbbr15 = team3.TeamNameFull;
				}
				if (team.TeamNameFull.Length > 10)
				{
					Team team4 = team;
					team4.TeamNameAbbr10 = team4.TeamNameFull.Substring(0, 10);
				}
				else
				{
					Team team5 = team;
					team5.TeamNameAbbr10 = team5.TeamNameFull;
				}
				if (team.TeamNameFull.Length > 3)
				{
					Team team6 = team;
					team6.TeamNameAbbr3 = team6.TeamNameFull.Substring(0, 3).ToUpper();
				}
				else
				{
					Team team7 = team;
					team7.TeamNameAbbr3 = team7.TeamNameFull;
				}
			}
			Formation formation = FifaEnvironment.Formations.CreateNewFormation();
			if (formation != null)
			{
				Formation formation2 = formation;
				formation2.formationfullname = formation2.Name;
				team.Formation = formation;
				team.formationid = formation.Id;
				formation.Team = team;
			}
			if (this.m_CurrentTeam != null)
			{
				team.Country = this.m_CurrentTeam.Country;
				team.adboardid = this.m_CurrentTeam.adboardid;
				team.balltype = this.m_CurrentTeam.balltype;
				team.Stadium = this.m_CurrentTeam.Stadium;
				team.RivalTeam = this.m_CurrentTeam.RivalTeam;
				team.latitude = this.m_CurrentTeam.latitude;
				team.longitude = this.m_CurrentTeam.longitude;
				team.utcoffset = this.m_CurrentTeam.utcoffset;
				team.highestpossible = this.m_CurrentTeam.highestpossible;
				team.highestprobable = this.m_CurrentTeam.highestprobable;
				team.objective = this.m_CurrentTeam.objective;
				team.previousyeartableposition = this.m_CurrentTeam.previousyeartableposition;
				team.transferbudget = this.m_CurrentTeam.transferbudget;
			}
			DialogResult dialogResult2 = FifaEnvironment.UserMessages.ShowMessage(15);
			if (dialogResult2 != DialogResult.No && dialogResult2 != DialogResult.Cancel)
			{
				new Player[32];
				TeamPlayer[] array = new TeamPlayer[32];
				int num = ((this.m_CurrentTeam.Roster.Count > 32) ? 32 : this.m_CurrentTeam.Roster.Count);
				for (int i = 0; i < num; i++)
				{
					TeamPlayer teamPlayer = (TeamPlayer)this.m_CurrentTeam.Roster[i];
					Player player = teamPlayer.Player;
					int newId = FifaEnvironment.Players.GetNewId();
					Player player2 = (Player)FifaEnvironment.Players.CloneId(player, newId);
					player2.headclasscode = 1;
					player2.firstname = "";
					player2.lastname = "Player_" + player2.Id.ToString();
					player2.commonname = "";
					player2.playerjerseyname = "";
					player2.commentaryid = 900000;
					player2.RandomizeAppearanceSameRace();
					array[i] = new TeamPlayer(player2);
					array[i].position = teamPlayer.position;
					array[i].jerseynumber = teamPlayer.jerseynumber;
					team.AddTeamPlayer(array[i]);
				}
				team.AssignRoles();
				team.AssignBench();
				team.AssignCaptain();
				team.AssignFreeKick();
				team.AssignPenalty();
				team.AssignLeftCorner();
				team.AssignRightCorner();
			}
			return team;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00067970 File Offset: 0x00065B70
		private Team DeleteTeam(object sender, object obj)
		{
			Team team = (Team)obj;
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(30);
			if (dialogResult == DialogResult.Cancel)
			{
				return team;
			}
			if (dialogResult != DialogResult.No && dialogResult != DialogResult.Cancel)
			{
				foreach (object obj2 in team.Roster)
				{
					TeamPlayer teamPlayer = (TeamPlayer)obj2;
					if (teamPlayer.Player.m_PlayingForTeams.Count <= 1)
					{
						FifaEnvironment.Players.RemoveId(teamPlayer.Player.Id);
					}
					else
					{
						teamPlayer.Player.NotPlayFor(team);
					}
				}
			}
			foreach (object obj3 in team.m_KitList)
			{
				Kit kit = (Kit)obj3;
				FifaEnvironment.Kits.RemoveId(kit);
			}
			if (team.League != null)
			{
				team.League.RemoveTeam(team);
			}
			FifaEnvironment.Teams.DeleteTeam(team);
			this.m_CurrentTeam = null;
			return null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00067A98 File Offset: 0x00065C98
		public Team RefreshTeam(object sender, object obj)
		{
			this.Preset();
			this.ReloadTeam(this.m_CurrentTeam);
			return this.m_CurrentTeam;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00067AB2 File Offset: 0x00065CB2
		public void ReloadTeam(Team team)
		{
			this.m_CurrentTeam = null;
			this.LoadTeam(team);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00067AC4 File Offset: 0x00065CC4
		public void LoadTeam(Team team)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			this.m_Locked = true;
			if (this.m_CurrentTeam == team && this.m_CurrentPage == this.tableEditTeam.SelectedTab)
			{
				return;
			}
			this.m_CurrentTeam = team;
			this.teamBindingSource.DataSource = this.m_CurrentTeam;
			this.UpdateCurrentPage();
			GC.Collect();
			this.m_Locked = false;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00067B28 File Offset: 0x00065D28
		public void LoadGenericPage()
		{
			this.numericTeamId.Value = this.m_CurrentTeam.Id;
			this.comboRivalTeam.SelectedItem = this.m_CurrentTeam.RivalTeam;
			this.checkIsNationalTeam.Checked = this.m_CurrentTeam.NationalTeam;
			this.comboObjective.SelectedIndex = this.m_CurrentTeam.objective;
			this.comboMaxOnjective.SelectedIndex = this.m_CurrentTeam.highestpossible;
			this.comboProbObjective.SelectedIndex = this.m_CurrentTeam.highestprobable;
			this.teamBindingSource.ResetBindings(false);
			this.viewer2DCrestLarge.CurrentBitmap = this.m_CurrentTeam.GetCrest();
			this.viewer2DCrest50.CurrentBitmap = this.m_CurrentTeam.GetCrest50();
			this.viewer2DCrest32.CurrentBitmap = this.m_CurrentTeam.GetCrest32();
			this.viewer2DCrest16.CurrentBitmap = this.m_CurrentTeam.GetCrest16();
			if (this.m_CurrentTeam.Stadium == null)
			{
				this.comboStadiums.Text = string.Empty;
			}
			if (this.m_CurrentTeam.Country == null)
			{
				this.comboTeamCountry.Text = string.Empty;
			}
			if (this.m_CurrentTeam.League == null)
			{
				this.comboTeamLeague.Text = string.Empty;
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00067C7C File Offset: 0x00065E7C
		public void LoadAdboardPage()
		{
			if (this.m_CurrentTeam == null)
			{
				this.viewer2DAdboards_0.CurrentBitmap = null;
				return;
			}
			this.m_LockUserChanges = true;
			this.viewer2DAdboards_0.CurrentBitmap = this.m_CurrentTeam.GetAdboard();
			this.checkHasSpecificAdboard.Checked = this.m_CurrentTeam.HasSpecifiAdboard;
			this.numericAdboards.Enabled = !this.m_CurrentTeam.HasSpecifiAdboard;
			this.numericAdboards.Value = this.m_CurrentTeam.adboardid;
			this.m_LockUserChanges = false;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00067D0C File Offset: 0x00065F0C
		public void LoadRevModPage()
		{
			this.viewer2DTeamAdboard.CurrentBitmap = this.m_CurrentTeam.GetRevModAdboard();
			this.viewer2DTeamManager.CurrentBitmap = this.m_CurrentTeam.GetRevModManagerTexture();
			this.Show3DManager();
			this.multiViewer2DTeamBallTextures.Bitmaps = this.m_CurrentTeam.GetRevModBallTextures();
			this.viewer2DTeamNet.CurrentBitmap = this.m_CurrentTeam.GetRevModNet();
			this.multiViewer2DTeamScarf.Bitmaps = this.m_CurrentTeam.GetScarfs();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00067D90 File Offset: 0x00065F90
		public void Show3DManager()
		{
			if (!this.buttonShow3DManager.Checked)
			{
				this.viewer3DTeamManager.ShowEmpty();
				return;
			}
			Bitmap currentBitmap = this.viewer2DTeamManager.CurrentBitmap;
			if (currentBitmap == null)
			{
				this.viewer3DTeamManager.ShowEmpty();
				return;
			}
			Rx3File revModManagerModel = Manager.GetRevModManagerModel(this.m_CurrentTeam.Id);
			if (currentBitmap == null || revModManagerModel == null)
			{
				this.viewer3DTeamManager.Clean(1);
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			Model3D model3D = new Model3D(revModManagerModel.Rx3IndexArrays[0], revModManagerModel.Rx3VertexArrays[0], currentBitmap);
			this.viewer3DTeamManager.Clean(1);
			this.viewer3DTeamManager.SetMesh(0, model3D);
			this.viewer3DTeamManager.Render();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00067E38 File Offset: 0x00066038
		public void LoadFlagsPage()
		{
			this.viewer2DBanners.CurrentBitmap = this.m_CurrentTeam.GetBanner();
			this.multiViewer2DFlags15.Bitmaps = this.m_CurrentTeam.GetFlags();
			this.pictureFlagRed.BackColor = this.m_CurrentTeam.TeamColor1;
			this.pictureFlagGreen.BackColor = this.m_CurrentTeam.TeamColor2;
			this.pictureFlagBlue.BackColor = this.m_CurrentTeam.TeamColor3;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00067EB4 File Offset: 0x000660B4
		public void LoadRosterPage()
		{
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster);
			this.m_CurrentFormation = this.m_CurrentTeam.Formation;
			this.m_BackupSpecificFormation = null;
			if (this.m_CurrentFormation == null)
			{
				this.m_CurrentFormation = FifaEnvironment.Formations.CreateNewFormation();
				this.m_CurrentFormation.LinkTeam(this.m_CurrentTeam);
				this.m_CurrentTeam.LinkFormation(this.m_CurrentFormation);
				this.m_CurrentTeam.AssignRoles();
				this.m_CurrentTeam.AssignCaptain();
				this.m_CurrentTeam.AssignFreeKick();
				this.m_CurrentTeam.AssignPenalty();
				this.m_CurrentTeam.AssignLeftCorner();
				this.m_CurrentTeam.AssignRightCorner();
			}
			this.m_LockUserChanges = true;
			if (this.m_CurrentFormation.IsGeneric())
			{
				this.radioUseGenericFormation.Checked = true;
				this.comboGenericFormations.SelectedItem = this.m_CurrentFormation;
			}
			else
			{
				this.radioUseSpecificFormation.Checked = true;
			}
			this.comboGenericFormations.Visible = this.radioUseGenericFormation.Checked;
			this.labelTeamFormationName.Text = this.m_CurrentFormation.ToString();
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			this.m_LockUserChanges = false;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000104DD File Offset: 0x0000E6DD
		public void LoadRosterGridPage()
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00067FEC File Offset: 0x000661EC
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Teams;
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Leagues,
				FifaEnvironment.Countries
			};
			this.pickUpControl.FilterValues = array;
			this.numericBall.Maximum = FifaEnvironment.FifaDb.Table[TI.teams].TableDescriptor.MaxValues[FI.teams_balltype];
			this.numericAdboards.Maximum = FifaEnvironment.FifaDb.Table[TI.teams].TableDescriptor.MaxValues[FI.teams_adboardid];
			this.numericTeamId.Maximum = FifaEnvironment.FifaDb.Table[TI.teams].TableDescriptor.MaxValues[FI.teams_teamid];
			this.teamListBindingSource.DataSource = FifaEnvironment.Teams;
			this.comboRivalTeam.DataSource = this.teamListBindingSource;
			this.teamListBindingSource.ResetBindings(false);
			this.stadiumListBindingSource.DataSource = FifaEnvironment.Stadiums;
			this.comboStadiums.DataSource = this.stadiumListBindingSource;
			this.stadiumListBindingSource.ResetBindings(false);
			this.countryListBindingSource.DataSource = FifaEnvironment.Countries;
			this.comboTeamCountry.DataSource = this.countryListBindingSource;
			this.countryListBindingSource.ResetBindings(false);
			this.leagueListBindingSource.DataSource = FifaEnvironment.Leagues;
			this.prevLeagueListBindingSource.DataSource = FifaEnvironment.Leagues;
			this.comboTeamLeague.DataSource = this.leagueListBindingSource;
			this.comboPrevLeague.DataSource = this.prevLeagueListBindingSource;
			this.leagueListBindingSource.ResetBindings(false);
			this.prevLeagueListBindingSource.ResetBindings(false);
			IdArrayList[] array2 = new IdArrayList[]
			{
				null,
				FifaEnvironment.Teams,
				FifaEnvironment.Countries,
				FifaEnvironment.Roles,
				FifaEnvironment.FreeAgents
			};
			this.pickUpAvailablePlayers.FilterValues = array2;
			this.pickUpAvailablePlayers.comboFilterValue.Width = 300;
			this.comboGenericFormations.Items.Clear();
			foreach (object obj in FifaEnvironment.Formations)
			{
				Formation formation = (Formation)obj;
				if (formation.IsGeneric() && formation.formations_issweeper == 0)
				{
					this.comboGenericFormations.Items.Add(formation);
				}
			}
			this.pickUpControl.ObjectList = FifaEnvironment.Teams;
			this.labelRightFreeKickText.Visible = FifaEnvironment.Year > 14;
			this.labelLeftFreeKickText.Visible = FifaEnvironment.Year > 14;
			this.labelLeftFreeKick.Visible = FifaEnvironment.Year > 14;
			this.labelRightFreeKick.Visible = FifaEnvironment.Year > 14;
			this.checkHasSpecificAdboard.Enabled = FifaEnvironment.Year > 14;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000682DC File Offset: 0x000664DC
		public void RefreshComboBoxes()
		{
			if (this.comboRivalTeam.Items.Count != FifaEnvironment.Teams.Count)
			{
				this.comboRivalTeam.Items.Clear();
				this.comboRivalTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0006832F File Offset: 0x0006652F
		private void TeamForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00068340 File Offset: 0x00066540
		private void numericTeamId_ValueChanged(object sender, EventArgs e)
		{
			int num = (int)this.numericTeamId.Value;
			if (num == this.m_CurrentTeam.Id)
			{
				return;
			}
			if (FifaEnvironment.Teams.SearchId(num) == null)
			{
				FifaEnvironment.Teams.ChangeId(this.m_CurrentTeam, num);
				this.m_CurrentTeam.assetid = num;
				this.m_CurrentTeam.m_KitList = new KitList();
				this.m_CurrentTeam.LinkKits(FifaEnvironment.Kits);
				foreach (object obj in this.m_CurrentTeam.m_KitList)
				{
					((Kit)obj).Team = this.m_CurrentTeam;
				}
				if (this.m_CurrentFormation != null)
				{
					this.m_CurrentFormation.Team = this.m_CurrentTeam;
				}
				this.LoadGenericPage();
				this.LoadFlagsPage();
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(1015);
			this.numericTeamId.Value = this.m_CurrentTeam.Id;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00068460 File Offset: 0x00066660
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.Teams.GetNewId();
			if (newId == -1)
			{
				FifaEnvironment.UserMessages.ShowMessage(5050);
				return;
			}
			this.numericTeamId.Value = newId;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000684A0 File Offset: 0x000666A0
		private void pictureTeamPrimColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamPrimColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamPrimColor.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor1 = this.colorDialog.Color;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000684FC File Offset: 0x000666FC
		private void pictureTeamSecColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamSecColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamSecColor.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor2 = this.colorDialog.Color;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00068558 File Offset: 0x00066758
		private void pictureTeamTerColor_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureTeamTerColor.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureTeamTerColor.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor3 = this.colorDialog.Color;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000685B4 File Offset: 0x000667B4
		private void numericAdboards_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.m_CurrentTeam == null)
			{
				this.viewer2DAdboards_0.CurrentBitmap = null;
				return;
			}
			this.m_CurrentTeam.adboardid = (int)this.numericAdboards.Value;
			this.viewer2DAdboards_0.CurrentBitmap = this.m_CurrentTeam.GetAdboard();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00068610 File Offset: 0x00066810
		private void InitListViewTeamPlayers(Roster roster)
		{
			this.InitListViewTeamPlayers(roster, null);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0006861C File Offset: 0x0006681C
		private void InitListViewTeamPlayers(Roster roster, TeamPlayer selectedTeamPlayer)
		{
			this.listViewTeamPlayers.BeginUpdate();
			this.listViewTeamPlayers.Items.Clear();
			for (int i = 0; i < roster.Count; i++)
			{
				TeamPlayer teamPlayer = (TeamPlayer)roster[i];
				string text = teamPlayer.m_jerseynumber.ToString();
				text = FifaUtil.PadBlanks(text, 2);
				ListViewItem listViewItem = new ListViewItem(teamPlayer.Player.Name);
				listViewItem.Tag = teamPlayer;
				listViewItem.SubItems.Add(teamPlayer.Player.firstname);
				listViewItem.SubItems.Add(teamPlayer.Player.contractvaliduntil.ToString());
				listViewItem.SubItems.Add(teamPlayer.Player.GetRoleAcronym());
				listViewItem.SubItems.Add(teamPlayer.Player.overallrating.ToString());
				listViewItem.SubItems.Add(text);
				this.listViewTeamPlayers.Items.Add(listViewItem);
			}
			if (selectedTeamPlayer == null)
			{
				if (this.listViewTeamPlayers.Items.Count > 0)
				{
					this.listViewTeamPlayers.Items[0].Selected = true;
				}
				else
				{
					this.m_CurrentTeamPlayer = null;
					this.CleanRosterTeamPlayer();
				}
			}
			else
			{
				for (int j = 0; j < this.listViewTeamPlayers.Items.Count; j++)
				{
					if (this.listViewTeamPlayers.Items[j].Tag == selectedTeamPlayer)
					{
						this.listViewTeamPlayers.Items[j].Selected = true;
					}
					else
					{
						this.listViewTeamPlayers.Items[j].Selected = false;
					}
				}
			}
			this.listViewTeamPlayers.EndUpdate();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000687D8 File Offset: 0x000669D8
		private void InitListViewPlayersAvailable(Team team, Country country, bool showFreeAgents)
		{
			if (this.m_AvailablePlayerLocked)
			{
				return;
			}
			this.m_AvailablePlayerLocked = true;
			bool flag = true;
			IComparer listViewItemSorter = this.listViewPlayersAvailable.ListViewItemSorter;
			this.listViewPlayersAvailable.ListViewItemSorter = null;
			this.listViewPlayersAvailable.BeginUpdate();
			this.listViewPlayersAvailable.Items.Clear();
			for (int i = 0; i < FifaEnvironment.Players.Count; i++)
			{
				Player player = (Player)FifaEnvironment.Players[i];
				if ((!flag || player.Id < 400000 || player.Id >= 500000) && (!showFreeAgents || player.m_PlayingForTeams.Count <= 0) && (team == null || player.IsPlayingFor(team)) && (country == null || player.Country == country))
				{
					ListViewItem listViewItem = new ListViewItem(player.Name);
					listViewItem.Tag = player;
					listViewItem.SubItems.Add(player.firstname);
					string roleAcronym = player.GetRoleAcronym();
					listViewItem.SubItems.Add(roleAcronym);
					int averageRoleAttribute = player.GetAverageRoleAttribute();
					listViewItem.SubItems.Add(averageRoleAttribute.ToString());
					this.listViewPlayersAvailable.Items.Add(listViewItem);
				}
			}
			if (this.listViewPlayersAvailable.Items.Count > 0)
			{
				this.listViewPlayersAvailable.Items[0].Selected = true;
			}
			this.listViewPlayersAvailable.EndUpdate();
			this.EnableRosterButtons();
			this.listViewPlayersAvailable.ListViewItemSorter = listViewItemSorter;
			this.m_AvailablePlayerLocked = false;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00068960 File Offset: 0x00066B60
		private void InitListViewPlayersAvailable(IdObject filterObject, bool excludeYoung)
		{
			if (this.m_AvailablePlayerLocked)
			{
				return;
			}
			this.m_AvailablePlayerLocked = true;
			IComparer listViewItemSorter = this.listViewPlayersAvailable.ListViewItemSorter;
			this.listViewPlayersAvailable.ListViewItemSorter = null;
			this.listViewPlayersAvailable.BeginUpdate();
			this.listViewPlayersAvailable.Items.Clear();
			PlayerList playerList = (PlayerList)FifaEnvironment.Players.Filter(filterObject);
			for (int i = 0; i < playerList.Count; i++)
			{
				Player player = (Player)playerList[i];
				int id = player.Id;
				if (player.Id <= 400000 || !excludeYoung)
				{
					ListViewItem listViewItem = new ListViewItem(player.Name);
					listViewItem.Tag = player;
					listViewItem.SubItems.Add(player.firstname);
					string roleAcronym = player.GetRoleAcronym();
					listViewItem.SubItems.Add(roleAcronym);
					int averageRoleAttribute = player.GetAverageRoleAttribute();
					listViewItem.SubItems.Add(averageRoleAttribute.ToString());
					this.listViewPlayersAvailable.Items.Add(listViewItem);
				}
			}
			if (this.listViewPlayersAvailable.Items.Count > 0)
			{
				this.listViewPlayersAvailable.Items[0].Selected = true;
			}
			this.listViewPlayersAvailable.EndUpdate();
			this.EnableRosterButtons();
			this.listViewPlayersAvailable.ListViewItemSorter = listViewItemSorter;
			this.m_AvailablePlayerLocked = false;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00068AC0 File Offset: 0x00066CC0
		private void EnableRosterButtons()
		{
			if (this.m_CurrentTeamPlayer != null)
			{
				this.buttonRosterLetFree.Enabled = true;
				if (this.m_CurrentAvailableTeam != null && this.m_CurrentAvailableTeam != this.m_CurrentTeam && this.m_CurrentAvailableTeam.Id != 0)
				{
					this.buttonTransferPlayer.Enabled = true;
					this.buttonLoanTo.Enabled = true;
				}
				else
				{
					this.buttonTransferPlayer.Enabled = false;
					this.buttonLoanTo.Enabled = false;
				}
			}
			else
			{
				this.buttonTransferPlayer.Enabled = false;
				this.buttonLoanTo.Enabled = false;
				this.buttonRosterLetFree.Enabled = false;
			}
			if (this.m_CurrentAvailablePlayer == null)
			{
				this.buttonTransferFrom.Enabled = false;
				this.buttonLoanFrom.Enabled = false;
				this.buttonCall.Enabled = false;
				return;
			}
			if (this.m_CurrentAvailablePlayer.IsPlayingFor(this.m_CurrentTeam))
			{
				this.buttonTransferFrom.Enabled = false;
				this.buttonLoanFrom.Enabled = false;
				this.buttonCall.Enabled = false;
				return;
			}
			this.buttonTransferFrom.Enabled = true;
			this.buttonLoanFrom.Enabled = true;
			this.buttonCall.Enabled = true;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00068BE8 File Offset: 0x00066DE8
		private void CleanRosterTeamPlayer()
		{
			this.labelRosterName.Text = string.Empty;
			this.comboRosterNumber.Items.Clear();
			this.comboRosterNumber.Text = string.Empty;
			this.numericRosterYear.Value = 2014m;
			this.viewer2DPhoto.CurrentBitmap = null;
			this.labelTeamPlayerStars.ImageIndex = 0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00068C54 File Offset: 0x00066E54
		private void buttonTransferFrom_Click(object sender, EventArgs e)
		{
			Team team = null;
			if (this.m_CurrentAvailableTeam != null)
			{
				team = this.m_CurrentAvailableTeam;
			}
			else
			{
				for (int i = 0; i < this.m_CurrentAvailablePlayer.m_PlayingForTeams.Count; i++)
				{
					Team team2 = (Team)this.m_CurrentAvailablePlayer.m_PlayingForTeams[i];
					if (!team2.NationalTeam)
					{
						team = team2;
						break;
					}
				}
			}
			if (team != null)
			{
				team.RemoveTeamPlayer(this.m_CurrentAvailablePlayer);
			}
			TeamPlayer teamPlayer = this.m_CurrentTeam.AddTeamPlayer(this.m_CurrentAvailablePlayer);
			this.m_CurrentAvailablePlayer.joindate = this.dateTransferPreset.Value;
			this.m_CurrentAvailablePlayer.IsLoaned = false;
			this.m_CurrentAvailablePlayer.TeamLoanedFrom = team;
			if (this.m_CurrentAvailablePlayer.contractvaliduntil < this.m_CurrentAvailablePlayer.joindate.Year + 1)
			{
				this.m_CurrentAvailablePlayer.contractvaliduntil = this.m_CurrentAvailablePlayer.joindate.Year + 1;
			}
			this.m_CurrentAvailablePlayer.PreviousTeam = team;
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster, teamPlayer);
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			if (this.m_CurrentAvailableTeam != null)
			{
				this.InitListViewPlayersAvailable(this.m_CurrentAvailableTeam, false);
			}
			this.EnableRosterButtons();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00068D90 File Offset: 0x00066F90
		private void buttonLoanFrom_Click(object sender, EventArgs e)
		{
			Team team = null;
			if (this.m_CurrentAvailableTeam != null)
			{
				team = this.m_CurrentAvailableTeam;
			}
			else
			{
				for (int i = 0; i < this.m_CurrentAvailablePlayer.m_PlayingForTeams.Count; i++)
				{
					Team team2 = (Team)this.m_CurrentAvailablePlayer.m_PlayingForTeams[i];
					if (!team2.NationalTeam)
					{
						team = team2;
						break;
					}
				}
			}
			if (team != null)
			{
				team.RemoveTeamPlayer(this.m_CurrentAvailablePlayer);
			}
			TeamPlayer teamPlayer = this.m_CurrentTeam.AddTeamPlayer(this.m_CurrentAvailablePlayer);
			this.m_CurrentAvailablePlayer.joindate = this.dateTransferPreset.Value;
			this.m_CurrentAvailablePlayer.loandateend = this.m_CurrentAvailablePlayer.joindate.AddDays(364.0);
			this.m_CurrentAvailablePlayer.TeamLoanedFrom = team;
			this.m_CurrentAvailablePlayer.IsLoaned = true;
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster, teamPlayer);
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			if (this.m_CurrentAvailableTeam != null)
			{
				this.InitListViewPlayersAvailable(this.m_CurrentAvailableTeam, false);
			}
			this.EnableRosterButtons();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00068EA4 File Offset: 0x000670A4
		private void buttonCall_Click(object sender, EventArgs e)
		{
			TeamPlayer teamPlayer = this.m_CurrentTeam.AddTeamPlayer(this.m_CurrentAvailablePlayer);
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster, teamPlayer);
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			this.EnableRosterButtons();
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00068EEC File Offset: 0x000670EC
		private void buttonRosterLetFree_Click(object sender, EventArgs e)
		{
			this.m_CurrentTeam.RemoveTeamPlayer(this.m_CurrentTeamPlayer);
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster);
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			this.EnableRosterButtons();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00068F28 File Offset: 0x00067128
		private void listViewTeamPlayers_DoubleClick(object sender, EventArgs e)
		{
			if (this.listViewTeamPlayers.SelectedItems.Count <= 0)
			{
				return;
			}
			TeamPlayer teamPlayer = (TeamPlayer)this.listViewTeamPlayers.SelectedItems[0].Tag;
			if (teamPlayer == null)
			{
				return;
			}
			Player player = teamPlayer.Player;
			if (player != null)
			{
				MainForm.CM.JumpTo(player);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00068F80 File Offset: 0x00067180
		private void listViewTeamPlayers_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewTeamPlayers.SelectedItems.Count <= 0)
			{
				return;
			}
			TeamPlayer teamPlayer = (TeamPlayer)this.listViewTeamPlayers.SelectedItems[0].Tag;
			if (this.m_CurrentTeamPlayer == teamPlayer)
			{
				return;
			}
			this.m_ChangeNumberFlag = false;
			this.m_CurrentTeamPlayer = teamPlayer;
			if (this.m_CurrentTeamPlayer != null)
			{
				this.comboRosterNumber.Items.Clear();
				this.comboRosterNumber.Items.Add(this.m_CurrentTeamPlayer.m_jerseynumber.ToString());
				string[] freeNumbers = this.m_CurrentTeam.Roster.GetFreeNumbers();
				this.comboRosterNumber.Items.AddRange(freeNumbers);
				this.comboRosterNumber.SelectedIndex = 0;
				this.m_Locked = true;
				this.labelRosterName.Text = this.m_CurrentTeamPlayer.Player.Name;
				this.numericRosterYear.Value = this.m_CurrentTeamPlayer.Player.contractvaliduntil;
				if (this.m_CurrentTeamPlayer.Player.joindate.Year == 1)
				{
					this.m_CurrentTeamPlayer.Player.joindate = new DateTime(2017, 7, 1);
				}
				this.dateJoiningDate.Value = this.m_CurrentTeamPlayer.Player.joindate;
				this.checkIsLoan.Checked = this.m_CurrentTeamPlayer.Player.IsLoaned;
				if (this.checkIsLoan.Checked)
				{
					if (this.m_CurrentTeamPlayer.Player.loandateend < this.dateLoanEnd.MinDate || this.m_CurrentTeamPlayer.Player.loandateend > this.dateLoanEnd.MaxDate)
					{
						this.m_CurrentTeamPlayer.Player.loandateend = this.m_CurrentTeamPlayer.Player.joindate.AddDays(364.0);
					}
					this.dateLoanEnd.Value = this.m_CurrentTeamPlayer.Player.loandateend;
					this.comboTeamLoanedFrom.SelectedItem = this.m_CurrentTeamPlayer.Player.TeamLoanedFrom;
				}
				else if (this.m_CurrentTeamPlayer.Player.PreviousTeam == null)
				{
					this.comboTeamPrevious.SelectedItem = this.m_CurrentTeamPlayer.Team;
				}
				else
				{
					this.comboTeamPrevious.SelectedItem = this.m_CurrentTeamPlayer.Player.PreviousTeam;
				}
				this.viewer2DPhoto.CurrentBitmap = this.m_CurrentTeamPlayer.Player.GetPhoto();
				int num = this.m_CurrentTeamPlayer.Player.GetAverageRoleAttribute();
				num = (num - 45) / 5;
				if (num < 0)
				{
					num = 0;
				}
				if (num > 9)
				{
					num = 9;
				}
				this.labelTeamPlayerStars.ImageIndex = num;
				this.EnableRosterButtons();
				this.m_Locked = false;
			}
			else
			{
				this.CleanRosterTeamPlayer();
				this.EnableRosterButtons();
			}
			this.m_ChangeNumberFlag = true;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00069260 File Offset: 0x00067460
		private void buttonTransferPlayer_Click(object sender, EventArgs e)
		{
			this.m_CurrentTeam.RemoveTeamPlayer(this.m_CurrentTeamPlayer);
			this.m_CurrentAvailableTeam.AddTeamPlayer(this.m_CurrentTeamPlayer);
			this.m_CurrentTeamPlayer.Player.joindate = this.dateTransferPreset.Value;
			this.m_CurrentTeamPlayer.Player.IsLoaned = false;
			this.m_CurrentTeamPlayer.Player.TeamLoanedFrom = this.m_CurrentTeam;
			if (this.m_CurrentTeamPlayer.Player.contractvaliduntil < this.m_CurrentTeamPlayer.Player.joindate.Year + 1)
			{
				this.m_CurrentTeamPlayer.Player.contractvaliduntil = this.m_CurrentTeamPlayer.Player.joindate.Year + 1;
			}
			this.m_CurrentTeamPlayer.Player.PreviousTeam = this.m_CurrentTeam;
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster);
			this.InitListViewPlayersAvailable(this.m_CurrentAvailableTeam, null, false);
			this.EnableRosterButtons();
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00069374 File Offset: 0x00067574
		private Team AvailablePlayersFilterChanged(object sender, object obj)
		{
			if (this.m_AvailablePlayerLocked)
			{
				return null;
			}
			this.m_CurrentAvailableTeam = null;
			if (obj != null && obj.GetType().Name == "Team")
			{
				Team team = (Team)obj;
				this.m_CurrentAvailableTeam = team;
			}
			this.InitListViewPlayersAvailable((IdObject)obj, false);
			return null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000693C8 File Offset: 0x000675C8
		private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView listView = (ListView)sender;
			SortOrder sortOrder;
			if (listView.Sorting == SortOrder.Ascending)
			{
				sortOrder = SortOrder.Descending;
			}
			else
			{
				sortOrder = SortOrder.Ascending;
			}
			listView.Sorting = sortOrder;
			listView.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00069404 File Offset: 0x00067604
		private void listViewPlayersAvailable_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewPlayersAvailable.SelectedItems.Count >= 1)
			{
				this.m_CurrentAvailablePlayer = (Player)this.listViewPlayersAvailable.SelectedItems[0].Tag;
				this.labelRosterNameFrom.Text = this.m_CurrentAvailablePlayer.Name;
				this.pictureAvailablePlayer.Image = this.m_CurrentAvailablePlayer.GetPhoto();
				int num = this.m_CurrentAvailablePlayer.GetAverageRoleAttribute();
				num = (num - 45) / 5;
				if (num < 0)
				{
					num = 0;
				}
				if (num > 9)
				{
					num = 9;
				}
				this.labelAvailablePlayerStars.ImageIndex = num;
				this.EnableRosterButtons();
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000694A8 File Offset: 0x000676A8
		private void listViewPlayersAvailable_DoubleClick(object sender, EventArgs e)
		{
			if (this.listViewPlayersAvailable.SelectedItems.Count <= 0)
			{
				return;
			}
			Player player = (Player)this.listViewPlayersAvailable.SelectedItems[0].Tag;
			if (player != null)
			{
				MainForm.CM.JumpTo(player);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000694F4 File Offset: 0x000676F4
		private void numericBall_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			this.m_CurrentTeam.balltype = (int)this.numericBall.Value;
			this.pictureBall.BackgroundImage = Ball.GetBallPicture(this.m_CurrentTeam.balltype);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00069540 File Offset: 0x00067740
		private void labelTeamCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentTeam.Country);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00069564 File Offset: 0x00067764
		private void labelTeamLeague_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.League != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentTeam.League);
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00069588 File Offset: 0x00067788
		private void labelTeamStadium_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.Stadium != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentTeam.Stadium);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000695AC File Offset: 0x000677AC
		private void labelOpponent_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.RivalTeam != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentTeam.RivalTeam);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000695D0 File Offset: 0x000677D0
		private void labelBall_DoubleClick(object sender, EventArgs e)
		{
			Ball ball = (Ball)FifaEnvironment.Balls.SearchId(this.m_CurrentTeam.balltype);
			if (ball != null)
			{
				MainForm.CM.JumpTo(ball);
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00069608 File Offset: 0x00067808
		private void comboRosterNumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this.m_ChangeNumberFlag)
			{
				return;
			}
			this.m_ChangeNumberFlag = false;
			string text = (string)this.comboRosterNumber.SelectedItem;
			int num = Convert.ToInt32(text);
			this.m_CurrentTeamPlayer.m_jerseynumber = num;
			this.listViewTeamPlayers.SelectedItems[0].SubItems[5].Text = FifaUtil.PadBlanks(text.ToString(), 2);
			this.m_ChangeNumberFlag = true;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00069680 File Offset: 0x00067880
		private void numericRosterYear_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeamPlayer == null)
			{
				return;
			}
			this.m_CurrentTeamPlayer.Player.contractvaliduntil = (int)this.numericRosterYear.Value;
			this.listViewTeamPlayers.SelectedItems[0].SubItems[2].Text = this.m_CurrentTeamPlayer.Player.contractvaliduntil.ToString();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void comboTeamCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000696EF File Offset: 0x000678EF
		private void dateJoiningDate_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeamPlayer == null)
			{
				return;
			}
			this.m_CurrentTeamPlayer.Player.joindate = this.dateJoiningDate.Value;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00069718 File Offset: 0x00067918
		private void InitVisualFormation(Roster roster)
		{
			Formation currentFormation = this.m_CurrentFormation;
			if (currentFormation != null)
			{
				this.labelPos0.Visible = currentFormation.IsRoleUsed(ERole.Goalkeeper);
				this.labelPos1.Visible = currentFormation.IsRoleUsed(ERole.Sweeper);
				this.labelPos2.Visible = currentFormation.IsRoleUsed(ERole.Right_Wing_Back);
				this.labelPos3.Visible = currentFormation.IsRoleUsed(ERole.Right_Back);
				this.labelPos4.Visible = currentFormation.IsRoleUsed(ERole.Right_Central_Back);
				this.labelPos5.Visible = currentFormation.IsRoleUsed(ERole.Central_Back);
				this.labelPos6.Visible = currentFormation.IsRoleUsed(ERole.Left_Central_Back);
				this.labelPos7.Visible = currentFormation.IsRoleUsed(ERole.Left_Back);
				this.labelPos8.Visible = currentFormation.IsRoleUsed(ERole.Left_Wing_Back);
				this.labelPos9.Visible = currentFormation.IsRoleUsed(ERole.Right_Defensive_Midfielder);
				this.labelPos10.Visible = currentFormation.IsRoleUsed(ERole.Central_Defensive_Midfielder);
				this.labelPos11.Visible = currentFormation.IsRoleUsed(ERole.Left_Defensive_Midfielder);
				this.labelPos12.Visible = currentFormation.IsRoleUsed(ERole.Right_Midfielder);
				this.labelPos13.Visible = currentFormation.IsRoleUsed(ERole.Right_Central_Midfielder);
				this.labelPos14.Visible = currentFormation.IsRoleUsed(ERole.Central_Midfielder);
				this.labelPos15.Visible = currentFormation.IsRoleUsed(ERole.Left_Central_Midfielder);
				this.labelPos16.Visible = currentFormation.IsRoleUsed(ERole.Left_Midfielder);
				this.labelPos17.Visible = currentFormation.IsRoleUsed(ERole.Right_Advanced_Midfielder);
				this.labelPos18.Visible = currentFormation.IsRoleUsed(ERole.Central_Advanced_Midfielder);
				this.labelPos19.Visible = currentFormation.IsRoleUsed(ERole.Left_Advanced_Midfielder);
				this.labelPos20.Visible = currentFormation.IsRoleUsed(ERole.Right_Forward);
				this.labelPos21.Visible = currentFormation.IsRoleUsed(ERole.Central_Forward);
				this.labelPos22.Visible = currentFormation.IsRoleUsed(ERole.Left_Forward);
				this.labelPos23.Visible = currentFormation.IsRoleUsed(ERole.Right_Wing);
				this.labelPos24.Visible = currentFormation.IsRoleUsed(ERole.Right_Striker);
				this.labelPos25.Visible = currentFormation.IsRoleUsed(ERole.Central_Striker);
				this.labelPos26.Visible = currentFormation.IsRoleUsed(ERole.Left_Striker);
				this.labelPos27.Visible = currentFormation.IsRoleUsed(ERole.Left_Wing);
				this.labelPos32A.Visible = true;
				this.labelPos32B.Visible = true;
				this.labelPos32C.Visible = true;
				this.labelPos32D.Visible = true;
				this.labelPos32E.Visible = true;
				this.labelPos32F.Visible = true;
				this.labelPos32G.Visible = true;
				this.labelPos33A.Visible = true;
				this.labelPos33B.Visible = true;
				this.labelPos33C.Visible = true;
				this.labelPos33D.Visible = true;
				this.labelPos33E.Visible = true;
				this.labelPos33F.Visible = true;
				this.labelPos33G.Visible = true;
				this.labelPos33H.Visible = true;
				this.labelPos33I.Visible = true;
				this.labelPos33J.Visible = true;
				this.labelPos33K.Visible = true;
				this.labelPos33L.Visible = true;
				this.labelPos33M.Visible = true;
				this.labelPos33N.Visible = true;
				this.labelPos33O.Visible = true;
				this.labelPos33P.Visible = true;
				this.labelPos33Q.Visible = true;
				this.labelPos33R.Visible = true;
				this.labelPos33S.Visible = true;
				this.labelPos33T.Visible = true;
				this.labelPos33U.Visible = true;
			}
			else
			{
				this.labelPos0.Visible = false;
				this.labelPos1.Visible = false;
				this.labelPos2.Visible = false;
				this.labelPos3.Visible = false;
				this.labelPos4.Visible = false;
				this.labelPos5.Visible = false;
				this.labelPos6.Visible = false;
				this.labelPos7.Visible = false;
				this.labelPos8.Visible = false;
				this.labelPos9.Visible = false;
				this.labelPos10.Visible = false;
				this.labelPos11.Visible = false;
				this.labelPos12.Visible = false;
				this.labelPos13.Visible = false;
				this.labelPos14.Visible = false;
				this.labelPos15.Visible = false;
				this.labelPos16.Visible = false;
				this.labelPos17.Visible = false;
				this.labelPos18.Visible = false;
				this.labelPos19.Visible = false;
				this.labelPos20.Visible = false;
				this.labelPos21.Visible = false;
				this.labelPos22.Visible = false;
				this.labelPos23.Visible = false;
				this.labelPos24.Visible = false;
				this.labelPos25.Visible = false;
				this.labelPos26.Visible = false;
				this.labelPos27.Visible = false;
				this.labelPos32A.Visible = false;
				this.labelPos32B.Visible = false;
				this.labelPos32C.Visible = false;
				this.labelPos32D.Visible = false;
				this.labelPos32E.Visible = false;
				this.labelPos32F.Visible = false;
				this.labelPos32G.Visible = false;
				this.labelPos33A.Visible = false;
				this.labelPos33B.Visible = false;
				this.labelPos33C.Visible = false;
				this.labelPos33D.Visible = false;
				this.labelPos33E.Visible = false;
				this.labelPos33F.Visible = false;
				this.labelPos33G.Visible = false;
				this.labelPos33H.Visible = false;
				this.labelPos33I.Visible = false;
				this.labelPos33J.Visible = false;
				this.labelPos33K.Visible = false;
				this.labelPos33L.Visible = false;
				this.labelPos33M.Visible = false;
				this.labelPos33N.Visible = false;
				this.labelPos33O.Visible = false;
				this.labelPos33P.Visible = false;
				this.labelPos33Q.Visible = false;
				this.labelPos33R.Visible = false;
				this.labelPos33S.Visible = false;
				this.labelPos33T.Visible = false;
				this.labelPos33U.Visible = false;
			}
			this.labelPos0.Text = (this.labelPos1.Text = (this.labelPos2.Text = (this.labelPos3.Text = (this.labelPos4.Text = (this.labelPos5.Text = (this.labelPos6.Text = (this.labelPos7.Text = (this.labelPos8.Text = (this.labelPos9.Text = (this.labelPos10.Text = (this.labelPos11.Text = (this.labelPos12.Text = (this.labelPos13.Text = (this.labelPos14.Text = (this.labelPos15.Text = (this.labelPos16.Text = (this.labelPos17.Text = (this.labelPos18.Text = (this.labelPos19.Text = (this.labelPos20.Text = (this.labelPos21.Text = (this.labelPos22.Text = (this.labelPos23.Text = (this.labelPos24.Text = (this.labelPos25.Text = (this.labelPos26.Text = (this.labelPos27.Text = (this.labelPos32A.Text = (this.labelPos32B.Text = (this.labelPos32C.Text = (this.labelPos32D.Text = (this.labelPos32E.Text = (this.labelPos32F.Text = (this.labelPos32G.Text = (this.labelPos33A.Text = (this.labelPos33B.Text = (this.labelPos33C.Text = (this.labelPos33D.Text = (this.labelPos33E.Text = (this.labelPos33F.Text = (this.labelPos33G.Text = (this.labelPos33H.Text = (this.labelPos33I.Text = (this.labelPos33J.Text = (this.labelPos33K.Text = (this.labelPos33L.Text = (this.labelPos33M.Text = (this.labelPos33N.Text = (this.labelPos33O.Text = (this.labelPos33P.Text = (this.labelPos33Q.Text = (this.labelPos33R.Text = (this.labelPos33S.Text = (this.labelPos33T.Text = (this.labelPos33U.Text = "______")))))))))))))))))))))))))))))))))))))))))))))))))))))));
			this.labelPos0.Tag = new TeamPlayer(ERole.Goalkeeper);
			this.labelPos1.Tag = new TeamPlayer(ERole.Sweeper);
			this.labelPos2.Tag = new TeamPlayer(ERole.Right_Wing_Back);
			this.labelPos3.Tag = new TeamPlayer(ERole.Right_Back);
			this.labelPos4.Tag = new TeamPlayer(ERole.Right_Central_Back);
			this.labelPos5.Tag = new TeamPlayer(ERole.Central_Back);
			this.labelPos6.Tag = new TeamPlayer(ERole.Left_Central_Back);
			this.labelPos7.Tag = new TeamPlayer(ERole.Left_Back);
			this.labelPos8.Tag = new TeamPlayer(ERole.Left_Wing_Back);
			this.labelPos9.Tag = new TeamPlayer(ERole.Right_Defensive_Midfielder);
			this.labelPos10.Tag = new TeamPlayer(ERole.Central_Defensive_Midfielder);
			this.labelPos11.Tag = new TeamPlayer(ERole.Left_Defensive_Midfielder);
			this.labelPos12.Tag = new TeamPlayer(ERole.Right_Midfielder);
			this.labelPos13.Tag = new TeamPlayer(ERole.Right_Central_Midfielder);
			this.labelPos14.Tag = new TeamPlayer(ERole.Central_Midfielder);
			this.labelPos15.Tag = new TeamPlayer(ERole.Left_Central_Midfielder);
			this.labelPos16.Tag = new TeamPlayer(ERole.Left_Midfielder);
			this.labelPos17.Tag = new TeamPlayer(ERole.Right_Advanced_Midfielder);
			this.labelPos18.Tag = new TeamPlayer(ERole.Central_Advanced_Midfielder);
			this.labelPos19.Tag = new TeamPlayer(ERole.Left_Advanced_Midfielder);
			this.labelPos20.Tag = new TeamPlayer(ERole.Right_Forward);
			this.labelPos21.Tag = new TeamPlayer(ERole.Central_Forward);
			this.labelPos22.Tag = new TeamPlayer(ERole.Left_Forward);
			this.labelPos23.Tag = new TeamPlayer(ERole.Right_Wing);
			this.labelPos24.Tag = new TeamPlayer(ERole.Right_Striker);
			this.labelPos25.Tag = new TeamPlayer(ERole.Central_Striker);
			this.labelPos26.Tag = new TeamPlayer(ERole.Left_Striker);
			this.labelPos27.Tag = new TeamPlayer(ERole.Left_Wing);
			this.labelPos32A.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32B.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32C.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32D.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32E.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32F.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos32G.Tag = new TeamPlayer(ERole.Substitute);
			this.labelPos33A.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33B.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33C.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33D.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33E.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33F.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33G.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33H.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33I.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33J.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33K.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33L.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33M.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33N.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33O.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33P.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33Q.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33R.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33S.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33T.Tag = new TeamPlayer(ERole.Tribune);
			this.labelPos33U.Tag = new TeamPlayer(ERole.Tribune);
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < roster.Count; i++)
			{
				TeamPlayer teamPlayer = (TeamPlayer)roster[i];
				switch (teamPlayer.position)
				{
				case 0:
					this.labelPos0.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos0.Visible = true;
					this.labelPos0.Tag = teamPlayer;
					break;
				case 1:
					this.labelPos1.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos1.Visible = true;
					this.labelPos1.Tag = teamPlayer;
					break;
				case 2:
					this.labelPos2.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos2.Visible = true;
					this.labelPos2.Tag = teamPlayer;
					break;
				case 3:
					this.labelPos3.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos3.Visible = true;
					this.labelPos3.Tag = teamPlayer;
					break;
				case 4:
					this.labelPos4.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos4.Visible = true;
					this.labelPos4.Tag = teamPlayer;
					break;
				case 5:
					this.labelPos5.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos5.Visible = true;
					this.labelPos5.Tag = teamPlayer;
					break;
				case 6:
					this.labelPos6.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos6.Visible = true;
					this.labelPos6.Tag = teamPlayer;
					break;
				case 7:
					this.labelPos7.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos7.Visible = true;
					this.labelPos7.Tag = teamPlayer;
					break;
				case 8:
					this.labelPos8.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos8.Visible = true;
					this.labelPos8.Tag = teamPlayer;
					break;
				case 9:
					this.labelPos9.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos9.Visible = true;
					this.labelPos9.Tag = teamPlayer;
					break;
				case 10:
					this.labelPos10.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos10.Visible = true;
					this.labelPos10.Tag = teamPlayer;
					break;
				case 11:
					this.labelPos11.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos11.Visible = true;
					this.labelPos11.Tag = teamPlayer;
					break;
				case 12:
					this.labelPos12.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos12.Visible = true;
					this.labelPos12.Tag = teamPlayer;
					break;
				case 13:
					this.labelPos13.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos13.Visible = true;
					this.labelPos13.Tag = teamPlayer;
					break;
				case 14:
					this.labelPos14.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos14.Visible = true;
					this.labelPos14.Tag = teamPlayer;
					break;
				case 15:
					this.labelPos15.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos15.Visible = true;
					this.labelPos15.Tag = teamPlayer;
					break;
				case 16:
					this.labelPos16.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos16.Visible = true;
					this.labelPos16.Tag = teamPlayer;
					break;
				case 17:
					this.labelPos17.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos17.Visible = true;
					this.labelPos17.Tag = teamPlayer;
					break;
				case 18:
					this.labelPos18.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos18.Visible = true;
					this.labelPos18.Tag = teamPlayer;
					break;
				case 19:
					this.labelPos19.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos19.Visible = true;
					this.labelPos19.Tag = teamPlayer;
					break;
				case 20:
					this.labelPos20.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos20.Visible = true;
					this.labelPos20.Tag = teamPlayer;
					break;
				case 21:
					this.labelPos21.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos21.Visible = true;
					this.labelPos21.Tag = teamPlayer;
					break;
				case 22:
					this.labelPos22.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos22.Visible = true;
					this.labelPos22.Tag = teamPlayer;
					break;
				case 23:
					this.labelPos23.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos23.Visible = true;
					this.labelPos23.Tag = teamPlayer;
					break;
				case 24:
					this.labelPos24.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos24.Visible = true;
					this.labelPos24.Tag = teamPlayer;
					break;
				case 25:
					this.labelPos25.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos25.Visible = true;
					this.labelPos25.Tag = teamPlayer;
					break;
				case 26:
					this.labelPos26.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos26.Visible = true;
					this.labelPos26.Tag = teamPlayer;
					break;
				case 27:
					this.labelPos27.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
					this.labelPos27.Visible = true;
					this.labelPos27.Tag = teamPlayer;
					break;
				case 28:
					switch (num)
					{
					case 0:
						this.labelPos32A.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32A.Visible = true;
						this.labelPos32A.Tag = teamPlayer;
						break;
					case 1:
						this.labelPos32B.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32B.Visible = true;
						this.labelPos32B.Tag = teamPlayer;
						break;
					case 2:
						this.labelPos32C.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32C.Visible = true;
						this.labelPos32C.Tag = teamPlayer;
						break;
					case 3:
						this.labelPos32D.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32D.Visible = true;
						this.labelPos32D.Tag = teamPlayer;
						break;
					case 4:
						this.labelPos32E.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32E.Visible = true;
						this.labelPos32E.Tag = teamPlayer;
						break;
					case 5:
						this.labelPos32F.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32F.Visible = true;
						this.labelPos32F.Tag = teamPlayer;
						break;
					case 6:
						this.labelPos32G.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos32G.Visible = true;
						this.labelPos32G.Tag = teamPlayer;
						break;
					case 7:
						teamPlayer.position = 29;
						num--;
						i--;
						break;
					}
					num++;
					break;
				case 29:
					switch (num2)
					{
					case 0:
						this.labelPos33A.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33A.Visible = true;
						this.labelPos33A.Tag = teamPlayer;
						break;
					case 1:
						this.labelPos33B.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33B.Visible = true;
						this.labelPos33B.Tag = teamPlayer;
						break;
					case 2:
						this.labelPos33C.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33C.Visible = true;
						this.labelPos33C.Tag = teamPlayer;
						break;
					case 3:
						this.labelPos33D.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33D.Visible = true;
						this.labelPos33D.Tag = teamPlayer;
						break;
					case 4:
						this.labelPos33E.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33E.Visible = true;
						this.labelPos33E.Tag = teamPlayer;
						break;
					case 5:
						this.labelPos33F.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33F.Visible = true;
						this.labelPos33F.Tag = teamPlayer;
						break;
					case 6:
						this.labelPos33G.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33G.Visible = true;
						this.labelPos33G.Tag = teamPlayer;
						break;
					case 7:
						this.labelPos33H.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33H.Visible = true;
						this.labelPos33H.Tag = teamPlayer;
						break;
					case 8:
						this.labelPos33I.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33I.Visible = true;
						this.labelPos33I.Tag = teamPlayer;
						break;
					case 9:
						this.labelPos33J.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33J.Visible = true;
						this.labelPos33J.Tag = teamPlayer;
						break;
					case 10:
						this.labelPos33K.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33K.Visible = true;
						this.labelPos33K.Tag = teamPlayer;
						break;
					case 11:
						this.labelPos33L.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33L.Visible = true;
						this.labelPos33L.Tag = teamPlayer;
						break;
					case 12:
						this.labelPos33M.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33M.Visible = true;
						this.labelPos33M.Tag = teamPlayer;
						break;
					case 13:
						this.labelPos33N.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33N.Visible = true;
						this.labelPos33N.Tag = teamPlayer;
						break;
					case 14:
						this.labelPos33O.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33O.Visible = true;
						this.labelPos33O.Tag = teamPlayer;
						break;
					case 15:
						this.labelPos33P.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33P.Visible = true;
						this.labelPos33P.Tag = teamPlayer;
						break;
					case 16:
						this.labelPos33Q.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33Q.Visible = true;
						this.labelPos33Q.Tag = teamPlayer;
						break;
					case 17:
						this.labelPos33R.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33R.Visible = true;
						this.labelPos33R.Tag = teamPlayer;
						break;
					case 18:
						this.labelPos33S.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33S.Visible = true;
						this.labelPos33S.Tag = teamPlayer;
						break;
					case 19:
						this.labelPos33T.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33T.Visible = true;
						this.labelPos33T.Tag = teamPlayer;
						break;
					case 20:
						this.labelPos33U.Text = teamPlayer.m_jerseynumber + "\n" + teamPlayer.Player.Name;
						this.labelPos33U.Visible = true;
						this.labelPos33U.Tag = teamPlayer;
						break;
					default:
						FifaEnvironment.UserMessages.ShowMessage(5021);
						break;
					}
					num2++;
					break;
				}
			}
			this.InitSpecialPlayers(this.m_CurrentTeam);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0006B674 File Offset: 0x00069874
		private void InitSpecialPlayers(Team team)
		{
			if (team == null)
			{
				return;
			}
			if (team.PlayerCaptain != null)
			{
				this.labelCaptain.Text = team.PlayerCaptain.Name;
			}
			else
			{
				this.labelCaptain.Text = "______";
			}
			if (team.PlayerPenalty != null)
			{
				this.labelPenalty.Text = team.PlayerPenalty.Name;
			}
			else
			{
				this.labelPenalty.Text = "______";
			}
			if (team.PlayerFreeKick != null)
			{
				this.labelFreeKick.Text = team.PlayerFreeKick.Name;
			}
			else
			{
				this.labelFreeKick.Text = "______";
			}
			if (FifaEnvironment.Year > 14)
			{
				if (team.PlayerRightFreeKick != null)
				{
					this.labelRightFreeKick.Text = team.PlayerRightFreeKick.Name;
				}
				else
				{
					this.labelRightFreeKick.Text = "______";
				}
				if (team.PlayerLeftFreeKick != null)
				{
					this.labelLeftFreeKick.Text = team.PlayerLeftFreeKick.Name;
				}
				else
				{
					this.labelLeftFreeKick.Text = "______";
				}
			}
			if (team.PlayerLongKick != null)
			{
				this.labelLongKick.Text = team.PlayerLongKick.Name;
			}
			else
			{
				this.labelLongKick.Text = "______";
			}
			if (team.PlayerLeftCorner != null)
			{
				this.labelLeftCorner.Text = team.PlayerLeftCorner.Name;
			}
			else
			{
				this.labelLeftCorner.Text = "______";
			}
			if (team.PlayerRightCorner != null)
			{
				this.labelRightCorner.Text = team.PlayerRightCorner.Name;
				return;
			}
			this.labelRightCorner.Text = "______";
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0006B80D File Offset: 0x00069A0D
		private void labelSpecial_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0006B818 File Offset: 0x00069A18
		private void labelSpecial_DragDrop(object sender, DragEventArgs e)
		{
			Label label = (Label)sender;
			TeamPlayer teamPlayer = (TeamPlayer)this.m_DraggedLabel.Tag;
			label.Text = teamPlayer.Player.Name;
			if (label == this.labelCaptain)
			{
				this.m_CurrentTeam.PlayerCaptain = teamPlayer.Player;
				this.m_CurrentTeam.captainid = this.m_CurrentTeam.PlayerCaptain.Id;
				return;
			}
			if (label == this.labelPenalty)
			{
				this.m_CurrentTeam.PlayerPenalty = teamPlayer.Player;
				this.m_CurrentTeam.penaltytakerid = this.m_CurrentTeam.PlayerPenalty.Id;
				return;
			}
			if (label == this.labelFreeKick)
			{
				this.m_CurrentTeam.PlayerFreeKick = teamPlayer.Player;
				this.m_CurrentTeam.freekicktakerid = this.m_CurrentTeam.PlayerFreeKick.Id;
				return;
			}
			if (label == this.labelLeftFreeKick)
			{
				this.m_CurrentTeam.PlayerLeftFreeKick = teamPlayer.Player;
				this.m_CurrentTeam.leftfreekicktakerid = this.m_CurrentTeam.PlayerLeftFreeKick.Id;
				return;
			}
			if (label == this.labelRightFreeKick)
			{
				this.m_CurrentTeam.PlayerRightFreeKick = teamPlayer.Player;
				this.m_CurrentTeam.rightfreekicktakerid = this.m_CurrentTeam.PlayerRightFreeKick.Id;
				return;
			}
			if (label == this.labelLongKick)
			{
				this.m_CurrentTeam.PlayerLongKick = teamPlayer.Player;
				this.m_CurrentTeam.longkicktakerid = this.m_CurrentTeam.PlayerLongKick.Id;
				return;
			}
			if (label == this.labelLeftCorner)
			{
				this.m_CurrentTeam.PlayerLeftCorner = teamPlayer.Player;
				this.m_CurrentTeam.leftcornerkicktakerid = this.m_CurrentTeam.PlayerLeftCorner.Id;
				return;
			}
			if (label == this.labelRightCorner)
			{
				this.m_CurrentTeam.PlayerRightCorner = teamPlayer.Player;
				this.m_CurrentTeam.rightcornerkicktakerid = this.m_CurrentTeam.PlayerRightCorner.Id;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0006BA00 File Offset: 0x00069C00
		private void labelPos_MouseDown(object sender, MouseEventArgs e)
		{
			Label label = (Label)sender;
			if (label.Text == "______")
			{
				return;
			}
			this.m_DraggedLabel = label;
			if (this.listViewTeamPlayers.SelectedItems.Count > 0)
			{
				this.listViewTeamPlayers.SelectedItems[0].Selected = false;
			}
			TeamPlayer teamPlayer = (TeamPlayer)this.m_DraggedLabel.Tag;
			for (int i = 0; i < this.listViewTeamPlayers.Items.Count; i++)
			{
				ListViewItem listViewItem = this.listViewTeamPlayers.Items[i];
				if (listViewItem.Tag == teamPlayer)
				{
					listViewItem.Selected = true;
					break;
				}
			}
			this.m_DraggedLabel.DoDragDrop(this.m_DraggedLabel.Text, DragDropEffects.Copy | DragDropEffects.Move);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0006BAC0 File Offset: 0x00069CC0
		private void labelPos_DragDrop(object sender, DragEventArgs e)
		{
			Label label = (Label)sender;
			TeamPlayer teamPlayer = (TeamPlayer)this.m_DraggedLabel.Tag;
			string text = this.m_DraggedLabel.Text;
			this.m_DraggedLabel.Text = label.Text;
			label.Text = text;
			TeamPlayer teamPlayer2 = (TeamPlayer)label.Tag;
			int position = teamPlayer.position;
			teamPlayer.position = teamPlayer2.position;
			teamPlayer2.position = position;
			TeamPlayer teamPlayer3 = teamPlayer;
			this.m_DraggedLabel.Tag = teamPlayer2;
			label.Tag = teamPlayer3;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0006BB44 File Offset: 0x00069D44
		private void labelPos_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0006BB50 File Offset: 0x00069D50
		private void listViewRoster_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView listView = (ListView)sender;
			SortOrder sortOrder;
			if (listView.Sorting == SortOrder.Ascending)
			{
				sortOrder = SortOrder.Descending;
			}
			else
			{
				sortOrder = SortOrder.Ascending;
			}
			listView.Sorting = sortOrder;
			listView.ListViewItemSorter = new ListViewItemComparer(e.Column, sortOrder);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0006BB8C File Offset: 0x00069D8C
		private void radioUseSpecificFormation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.radioUseSpecificFormation.Checked)
			{
				int newId = FifaEnvironment.Formations.GetNewId();
				if (newId < 0)
				{
					FifaEnvironment.UserMessages.ShowMessage(5043);
					this.radioUseGenericFormation.Checked = true;
					return;
				}
				Formation formation;
				if (this.m_BackupSpecificFormation != null)
				{
					formation = this.m_BackupSpecificFormation;
				}
				else
				{
					formation = this.m_CurrentFormation;
				}
				if (formation == null)
				{
					return;
				}
				Formation formation2 = (Formation)formation.Clone(newId);
				FifaEnvironment.Formations.InsertId(formation2);
				this.m_CurrentTeam.Formation = formation2;
				this.m_CurrentFormation = formation2;
				this.m_CurrentTeam.formationid = formation2.Id;
				this.m_CurrentFormation.Team = this.m_CurrentTeam;
				if (this.m_BackupSpecificFormation != null)
				{
					this.m_CurrentTeam.AssignTitolarToRoles(formation2);
				}
				this.InitVisualFormation(this.m_CurrentTeam.Roster);
				this.labelTeamFormationName.Text = this.m_CurrentFormation.ToString();
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0006BC88 File Offset: 0x00069E88
		private void radioUseGenericFormation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.radioUseGenericFormation.Checked)
			{
				if (this.m_CurrentFormation != null && !this.m_CurrentFormation.IsGeneric())
				{
					this.m_BackupSpecificFormation = this.m_CurrentFormation;
					FifaEnvironment.Formations.RemoveId(this.m_CurrentFormation);
				}
				if (this.comboGenericFormations.SelectedIndex < 0)
				{
					this.comboGenericFormations.SelectedIndex = 0;
				}
				Formation formation = (Formation)this.comboGenericFormations.SelectedItem;
				this.m_CurrentTeam.Formation = formation;
				this.m_CurrentFormation = formation;
				this.m_CurrentTeam.formationid = formation.Id;
				this.m_CurrentTeam.AssignTitolarToRoles(formation);
				this.InitVisualFormation(this.m_CurrentTeam.Roster);
				this.labelTeamFormationName.Text = this.m_CurrentFormation.ToString();
			}
			this.comboGenericFormations.Visible = this.radioUseGenericFormation.Checked;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0006BD78 File Offset: 0x00069F78
		private void comboGenericFormations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.comboGenericFormations.SelectedIndex < 0)
			{
				return;
			}
			Formation formation = (Formation)this.comboGenericFormations.SelectedItem;
			if (formation == null)
			{
				return;
			}
			if (formation == this.m_CurrentTeam.Formation)
			{
				return;
			}
			this.m_CurrentTeam.Formation = formation;
			this.m_CurrentFormation = formation;
			this.m_CurrentTeam.formationid = formation.Id;
			this.m_CurrentTeam.AssignTitolarToRoles(formation);
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
			this.labelTeamFormationName.Text = this.m_CurrentFormation.ToString();
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0006BE18 File Offset: 0x0006A018
		private void MovePicture(MouseEventArgs e, Label picture)
		{
			int num = e.X - 8;
			int num2 = e.Y - 8;
			this.m_LabelLocation.X = picture.Location.X + num;
			this.m_LabelLocation.Y = picture.Location.Y + num2;
			if (this.m_LabelLocation.X < this.m_BoundLeft)
			{
				this.m_LabelLocation.X = this.m_BoundLeft;
			}
			if (this.m_LabelLocation.X > this.m_BoundRight)
			{
				this.m_LabelLocation.X = this.m_BoundRight;
			}
			if (this.m_LabelLocation.Y < this.m_BoundTop)
			{
				this.m_LabelLocation.Y = this.m_BoundTop;
			}
			if (this.m_LabelLocation.Y > this.m_BoundBottom)
			{
				this.m_LabelLocation.Y = this.m_BoundBottom;
			}
			picture.Location = this.m_LabelLocation;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0006BF0C File Offset: 0x0006A10C
		private EPlayingDirection ClickToAttackRole(EventArgs e)
		{
			int x = ((MouseEventArgs)e).X;
			int y = ((MouseEventArgs)e).Y;
			EPlayingDirection eplayingDirection;
			if (x < 16)
			{
				if (y < 16)
				{
					eplayingDirection = EPlayingDirection.Right;
				}
				else if (y < 32)
				{
					eplayingDirection = EPlayingDirection.Right;
				}
				else
				{
					eplayingDirection = EPlayingDirection.DiagonalRight;
				}
			}
			else if (x < 32)
			{
				if (y < 16)
				{
					eplayingDirection = EPlayingDirection.Standing;
				}
				else if (y < 32)
				{
					eplayingDirection = EPlayingDirection.Standing;
				}
				else
				{
					eplayingDirection = EPlayingDirection.Stright;
				}
			}
			else if (y < 16)
			{
				eplayingDirection = EPlayingDirection.Left;
			}
			else if (y < 32)
			{
				eplayingDirection = EPlayingDirection.Left;
			}
			else
			{
				eplayingDirection = EPlayingDirection.DiagonalLeft;
			}
			return eplayingDirection;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0006BF7C File Offset: 0x0006A17C
		private EPlayingDirection ClickToDefenseRole(EventArgs e)
		{
			int x = ((MouseEventArgs)e).X;
			int y = ((MouseEventArgs)e).Y;
			EPlayingDirection eplayingDirection;
			if (x < 16)
			{
				if (y < 16)
				{
					eplayingDirection = EPlayingDirection.DiagonalRight;
				}
				else if (y < 32)
				{
					eplayingDirection = EPlayingDirection.Right;
				}
				else
				{
					eplayingDirection = EPlayingDirection.Right;
				}
			}
			else if (x < 32)
			{
				if (y < 16)
				{
					eplayingDirection = EPlayingDirection.Stright;
				}
				else if (y < 32)
				{
					eplayingDirection = EPlayingDirection.Standing;
				}
				else
				{
					eplayingDirection = EPlayingDirection.Standing;
				}
			}
			else if (y < 16)
			{
				eplayingDirection = EPlayingDirection.DiagonalLeft;
			}
			else if (y < 32)
			{
				eplayingDirection = EPlayingDirection.Left;
			}
			else
			{
				eplayingDirection = EPlayingDirection.Left;
			}
			return eplayingDirection;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0006BFEC File Offset: 0x0006A1EC
		private void buttonReplicateLogo_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DCrestLarge.CurrentBitmap;
			this.m_CurrentTeam.SetAllCrests(currentBitmap);
			this.viewer2DCrest50.CurrentBitmap = this.m_CurrentTeam.GetCrest16();
			this.viewer2DCrest50.CurrentBitmap = this.m_CurrentTeam.GetCrest32();
			this.viewer2DCrest50.CurrentBitmap = this.m_CurrentTeam.GetCrest50();
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0006C054 File Offset: 0x0006A254
		private void textStadiumName_TextChanged(object sender, EventArgs e)
		{
			if (this.textStadiumName.Text.Length > 30)
			{
				this.textStadiumName.Text = this.textStadiumName.Text.Substring(0, 30);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0006C088 File Offset: 0x0006A288
		private void comboTeamLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTeamLeague.SelectedItem == null)
			{
				this.comboTeamLeague.Text = string.Empty;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0006C0A7 File Offset: 0x0006A2A7
		private void comboPrevLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboPrevLeague.SelectedItem == null)
			{
				this.comboPrevLeague.Text = string.Empty;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0006C0C6 File Offset: 0x0006A2C6
		private void textShortTeamName_TextChanged(object sender, EventArgs e)
		{
			if (this.textShortTeamName.Text.Length > 10)
			{
				this.textShortTeamName.Text = this.textShortTeamName.Text.Substring(0, 10);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0006C0FA File Offset: 0x0006A2FA
		private void textTeamName7_TextChanged(object sender, EventArgs e)
		{
			if (this.textTeamName7.Text.Length > 7)
			{
				this.textTeamName7.Text = this.textTeamName7.Text.Substring(0, 7);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0006C12C File Offset: 0x0006A32C
		private void textStandardTeamName_TextChanged(object sender, EventArgs e)
		{
			if (this.textStandardTeamName.Text.Length > 15)
			{
				this.textStandardTeamName.Text = this.textStandardTeamName.Text.Substring(0, 15);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0006C160 File Offset: 0x0006A360
		private void comboRivalTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam != null)
			{
				Team team = (Team)this.comboRivalTeam.SelectedItem;
				if (team != this.m_CurrentTeam.RivalTeam)
				{
					this.m_CurrentTeam.RivalTeam = team;
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
		private void comboObjective_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam != null && this.comboObjective.SelectedIndex >= 0 && this.comboObjective.SelectedIndex != this.m_CurrentTeam.objective)
			{
				this.m_CurrentTeam.objective = this.comboObjective.SelectedIndex;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
		private void comboMaxOnjective_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam != null && this.comboMaxOnjective.SelectedIndex >= 0 && this.comboMaxOnjective.SelectedIndex != this.m_CurrentTeam.highestpossible)
			{
				this.m_CurrentTeam.highestpossible = this.comboMaxOnjective.SelectedIndex;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0006C248 File Offset: 0x0006A448
		private void comboProbObjective_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam != null && this.comboProbObjective.SelectedIndex >= 0 && this.comboProbObjective.SelectedIndex != this.m_CurrentTeam.highestprobable)
			{
				this.m_CurrentTeam.highestprobable = this.comboProbObjective.SelectedIndex;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0006C29C File Offset: 0x0006A49C
		private void buttonTeamPlayerPlus_Click(object sender, EventArgs e)
		{
			int num = this.listViewTeamPlayers.SelectedIndices[0];
			foreach (object obj in this.m_CurrentTeam.Roster)
			{
				((TeamPlayer)obj).Player.ChangeSkills(1);
			}
			this.LoadRosterPage();
			if (num >= 0)
			{
				this.listViewTeamPlayers.Items[num].Selected = true;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0006C330 File Offset: 0x0006A530
		private void buttonTeamPlayerMinus_Click(object sender, EventArgs e)
		{
			int num = this.listViewTeamPlayers.SelectedIndices[0];
			foreach (object obj in this.m_CurrentTeam.Roster)
			{
				((TeamPlayer)obj).Player.ChangeSkills(-1);
			}
			this.LoadRosterPage();
			if (num >= 0)
			{
				this.listViewTeamPlayers.Items[num].Selected = true;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0006C3C4 File Offset: 0x0006A5C4
		private void buttonPlusContract_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			if (this.m_CurrentTeam.Roster == null)
			{
				return;
			}
			int num = this.listViewTeamPlayers.SelectedIndices[0];
			foreach (object obj in this.m_CurrentTeam.Roster)
			{
				((TeamPlayer)obj).Player.contractvaliduntil++;
			}
			this.LoadRosterPage();
			if (num >= 0)
			{
				this.listViewTeamPlayers.Items[num].Selected = true;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0006C478 File Offset: 0x0006A678
		private void buttonMinusContract_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			if (this.m_CurrentTeam.Roster == null)
			{
				return;
			}
			int num = this.listViewTeamPlayers.SelectedIndices[0];
			foreach (object obj in this.m_CurrentTeam.Roster)
			{
				((TeamPlayer)obj).Player.contractvaliduntil--;
			}
			this.LoadRosterPage();
			if (num >= 0)
			{
				this.listViewTeamPlayers.Items[num].Selected = true;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0006C52C File Offset: 0x0006A72C
		private void labelFlag1_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
			int num;
			if (mouseEventArgs.Button != MouseButtons.Left)
			{
				if (mouseEventArgs.Button == MouseButtons.Right)
				{
					if (label.ImageIndex == 0)
					{
						Label label2 = label;
						label2.ImageIndex = label2.ImageList.Images.Count - 1;
						return;
					}
					Label label3 = label;
					num = label3.ImageIndex;
					label3.ImageIndex = num - 1;
				}
				return;
			}
			if (label.ImageIndex == label.ImageList.Images.Count - 1)
			{
				label.ImageIndex = 0;
				return;
			}
			Label label4 = label;
			num = label4.ImageIndex;
			label4.ImageIndex = num + 1;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0006C5C8 File Offset: 0x0006A7C8
		private void pictureFlagRed_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureFlagRed.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureFlagRed.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor1 = this.colorDialog.Color;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0006C624 File Offset: 0x0006A824
		private void pictureFlagGreen_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureFlagGreen.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureFlagGreen.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor2 = this.colorDialog.Color;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0006C680 File Offset: 0x0006A880
		private void pictureFlagBlue_Click(object sender, EventArgs e)
		{
			this.colorDialog.Color = this.pictureFlagBlue.BackColor;
			this.colorDialog.ShowDialog();
			this.pictureFlagBlue.BackColor = this.colorDialog.Color;
			this.m_CurrentTeam.TeamColor3 = this.colorDialog.Color;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0006C6DC File Offset: 0x0006A8DC
		private void buttonCreateFlags_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			Bitmap[] array = new Bitmap[4];
			Bitmap crest = this.m_CurrentTeam.GetCrest();
			new Rectangle(0, 0, 256, 256);
			Rectangle rectangle = new Rectangle(160, 32, 192, 192);
			int num = this.labelFlag1.ImageIndex + 1;
			string text = FifaEnvironment.LaunchDir + "\\Templates\\" + Team.GenericFlagFileName(num);
			array[0] = new Bitmap(text);
			GraphicUtil.ColorizeRGB(array[0], this.pictureFlagRed.BackColor, this.pictureFlagGreen.BackColor, this.pictureFlagBlue.BackColor, false);
			if (this.checkFlag1.Checked)
			{
				array[0] = GraphicUtil.Overlap(array[0], crest, rectangle);
			}
			num = this.labelFlag2.ImageIndex + 1;
			text = FifaEnvironment.LaunchDir + "\\Templates\\" + Team.GenericFlagFileName(num);
			array[1] = new Bitmap(text);
			GraphicUtil.ColorizeRGB(array[1], this.pictureFlagRed.BackColor, this.pictureFlagGreen.BackColor, this.pictureFlagBlue.BackColor, false);
			if (this.checkFlag2.Checked)
			{
				array[1] = GraphicUtil.Overlap(array[1], crest, rectangle);
			}
			rectangle = new Rectangle(32, 32, 192, 192);
			num = this.labelFlag3.ImageIndex + 1;
			text = FifaEnvironment.LaunchDir + "\\Templates\\" + Team.GenericFlagFileName(num);
			array[2] = new Bitmap(text);
			GraphicUtil.ColorizeRGB(array[2], this.pictureFlagRed.BackColor, this.pictureFlagGreen.BackColor, this.pictureFlagBlue.BackColor, false);
			if (this.checkFlag3.Checked)
			{
				array[2] = GraphicUtil.Overlap(array[2], crest, rectangle);
			}
			num = this.labelFlag4.ImageIndex + 1;
			text = FifaEnvironment.LaunchDir + "\\Templates\\" + Team.GenericFlagFileName(num);
			array[3] = new Bitmap(text);
			GraphicUtil.ColorizeRGB(array[3], this.pictureFlagRed.BackColor, this.pictureFlagGreen.BackColor, this.pictureFlagBlue.BackColor, false);
			if (this.checkFlag4.Checked)
			{
				array[3] = GraphicUtil.Overlap(array[3], crest, rectangle);
			}
			this.m_CurrentTeam.SetFlags(array);
			this.multiViewer2DFlags15.Bitmaps = this.m_CurrentTeam.GetFlags();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0006C937 File Offset: 0x0006AB37
		private void comboDEFLine_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool lockUserChanges = this.m_LockUserChanges;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0006C937 File Offset: 0x0006AB37
		private void comboBUSPositioning_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool lockUserChanges = this.m_LockUserChanges;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0006C937 File Offset: 0x0006AB37
		private void comboCCPositioning_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool lockUserChanges = this.m_LockUserChanges;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0006C940 File Offset: 0x0006AB40
		private void checkHasSpecificAdboard_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.checkHasSpecificAdboard.Checked)
			{
				this.m_CurrentTeam.CreateSpecificAdboard();
				return;
			}
			this.m_CurrentTeam.DeleteSpecificAdboard();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0006C971 File Offset: 0x0006AB71
		private void labelTeamFormationName_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.Formation != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentTeam.Formation);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0006C998 File Offset: 0x0006AB98
		private void labelStandardTeamName_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.TeamNameFull.Length > 15)
			{
				this.m_CurrentTeam.TeamNameAbbr15 = this.m_CurrentTeam.TeamNameFull.Substring(0, 15);
			}
			else
			{
				this.m_CurrentTeam.TeamNameAbbr15 = this.m_CurrentTeam.TeamNameFull;
			}
			this.textStandardTeamName.Text = this.m_CurrentTeam.TeamNameAbbr15;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0006CA08 File Offset: 0x0006AC08
		private void textShortTeamName_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.TeamNameFull.Length > 10)
			{
				this.m_CurrentTeam.TeamNameAbbr10 = this.m_CurrentTeam.TeamNameFull.Substring(0, 10);
			}
			else
			{
				this.m_CurrentTeam.TeamNameAbbr10 = this.m_CurrentTeam.TeamNameFull;
			}
			this.textShortTeamName.Text = this.m_CurrentTeam.TeamNameAbbr10;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0006CA78 File Offset: 0x0006AC78
		private void labelTeamName7_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam.TeamNameFull.Length > 7)
			{
				this.m_CurrentTeam.TeamNameAbbr7 = this.m_CurrentTeam.TeamNameFull.Substring(0, 7);
			}
			else
			{
				this.m_CurrentTeam.TeamNameAbbr7 = this.m_CurrentTeam.TeamNameFull;
			}
			this.textTeamName7.Text = this.m_CurrentTeam.TeamNameAbbr7;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0006CAE3 File Offset: 0x0006ACE3
		private void numericLatitude_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			this.m_CurrentTeam.latitude = (int)this.numericLatitude.Value;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0006CB09 File Offset: 0x0006AD09
		private void numericLongitude_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			this.m_CurrentTeam.longitude = (int)this.numericLongitude.Value;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0006CB2F File Offset: 0x0006AD2F
		private void numericUtcOffset_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			this.m_CurrentTeam.utcoffset = (int)this.numericUtcOffset.Value;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0006CB55 File Offset: 0x0006AD55
		private void buttonShow3DManager_Click(object sender, EventArgs e)
		{
			this.Show3DManager();
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0006CB60 File Offset: 0x0006AD60
		private void buttonImportModel3DTeamManager_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_TeamCurrentFolder, "Open 3D Manger Model file", "3D manager model files (*.rx3)|manager_*.rx3");
			if (text == null)
			{
				return;
			}
			Manager.SetRevModManagerModel(this.m_CurrentTeam.Id, text);
			this.Show3DManager();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		private void buttonExportModel3DTeamManager_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			string text = Manager.RevModManagerModelFileName(this.m_CurrentTeam.Id);
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_TeamCurrentFolder);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0006CBDF File Offset: 0x0006ADDF
		private void buttonDeleteModel3DTeamManager_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			Manager.DeleteRevModManagerModel(this.m_CurrentTeam.Id);
			this.Show3DManager();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0006CC01 File Offset: 0x0006AE01
		private bool ImportImageManager(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTeam != null && Manager.SetRevModManagerTexture(this.m_CurrentTeam.Id, bitmap);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0006CC1E File Offset: 0x0006AE1E
		private bool DeleteManager(object sender)
		{
			return this.m_CurrentTeam != null && Manager.DeleteRevModManagerTexture(this.m_CurrentTeam.Id);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0006CC3A File Offset: 0x0006AE3A
		private void buttonShow3DBall_Click(object sender, EventArgs e)
		{
			this.Show3DRevModBall();
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0006CC44 File Offset: 0x0006AE44
		public void Show3DRevModBall()
		{
			if (!this.buttonShow3DBall.Checked)
			{
				this.viewer3DTeamBall.ShowEmpty();
				return;
			}
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			Bitmap[] revModTeamBallTextures = Ball.GetRevModTeamBallTextures(this.m_CurrentTeam.Id);
			Bitmap bitmap = null;
			if (revModTeamBallTextures != null)
			{
				bitmap = GraphicUtil.EmbossBitmap(revModTeamBallTextures[0], revModTeamBallTextures[1]);
			}
			Rx3File revModTeamBallModel = Ball.GetRevModTeamBallModel(this.m_CurrentTeam.Id);
			if (bitmap == null || revModTeamBallModel == null)
			{
				this.viewer3DTeamBall.Clean(1);
				this.viewer3DTeamBall.Render();
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			Model3D model3D = new Model3D(revModTeamBallModel.Rx3IndexArrays[0], revModTeamBallModel.Rx3VertexArrays[0], bitmap);
			this.viewer3DTeamBall.Clean(1);
			this.viewer3DTeamBall.SetMesh(0, model3D);
			this.viewer3DTeamBall.Render();
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0006CD08 File Offset: 0x0006AF08
		private void buttonImport3DModelTeamBall_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_TeamCurrentFolder, "Open 3D Ball Model file", "3D ball model files (*.rx3)|ball_*.rx3");
			if (text == null)
			{
				return;
			}
			Ball.SetRevModTeamBallModel(this.m_CurrentTeam.Id, text);
			this.LoadRevModBall();
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0006CD50 File Offset: 0x0006AF50
		private void buttonExport3DModelTeamBall_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			string text = Ball.RevModTeamBallModelFileName(this.m_CurrentTeam.Id);
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_TeamCurrentFolder);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0006CD87 File Offset: 0x0006AF87
		private void buttonRemove3DModelTeamBall_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			Ball.DeleteRevModTeamBallModel(this.m_CurrentTeam.Id);
			this.LoadRevModBall();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0006CDA9 File Offset: 0x0006AFA9
		private void LoadRevModBall()
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			this.multiViewer2DTeamBallTextures.Bitmaps = Ball.GetRevModTeamBallTextures(this.m_CurrentTeam.Id);
			this.Show3DRevModBall();
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
		private void checkIsNationalTeam_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTeam == null)
			{
				return;
			}
			if (this.m_Locked)
			{
				return;
			}
			if (this.checkIsNationalTeam.Checked)
			{
				this.m_CurrentTeam.NationalTeam = true;
				if (this.m_CurrentTeam.Country != null && !this.m_CurrentTeam.IsFemale())
				{
					this.m_CurrentTeam.Country.SetNationalTeam(this.m_CurrentTeam, this.m_CurrentTeam.Id);
					return;
				}
			}
			else
			{
				this.m_CurrentTeam.NationalTeam = false;
				if (this.m_CurrentTeam.Country != null && !this.m_CurrentTeam.IsFemale())
				{
					this.m_CurrentTeam.Country.SetNationalTeam(null, 0);
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0006CE8C File Offset: 0x0006B08C
		private void buttonLoanTo_Click(object sender, EventArgs e)
		{
			this.m_CurrentTeam.RemoveTeamPlayer(this.m_CurrentTeamPlayer);
			this.m_CurrentAvailableTeam.AddTeamPlayer(this.m_CurrentTeamPlayer);
			this.m_CurrentTeamPlayer.Player.joindate = this.dateTransferPreset.Value;
			this.m_CurrentTeamPlayer.Player.TeamLoanedFrom = this.m_CurrentTeam;
			this.m_CurrentTeamPlayer.Player.loandateend = this.m_CurrentTeamPlayer.Player.joindate.AddDays(364.0);
			this.m_CurrentTeamPlayer.Player.IsLoaned = true;
			this.InitListViewTeamPlayers(this.m_CurrentTeam.Roster);
			this.InitListViewPlayersAvailable(this.m_CurrentAvailableTeam, null, false);
			this.EnableRosterButtons();
			this.InitVisualFormation(this.m_CurrentTeam.Roster);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0006CF64 File Offset: 0x0006B164
		private void labelHomeKit_DoubleClick(object sender, EventArgs e)
		{
			Kit kit = FifaEnvironment.Kits.GetKit(this.m_CurrentTeam.Id, 0);
			if (kit != null)
			{
				MainForm.CM.JumpTo(kit);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(3001);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0006CFA8 File Offset: 0x0006B1A8
		private void labelAwayKit_DoubleClick(object sender, EventArgs e)
		{
			Kit kit = FifaEnvironment.Kits.GetKit(this.m_CurrentTeam.Id, 1);
			if (kit != null)
			{
				MainForm.CM.JumpTo(kit);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(3001);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0006CFEC File Offset: 0x0006B1EC
		private void labelKeeprKit_DoubleClick(object sender, EventArgs e)
		{
			Kit kit = FifaEnvironment.Kits.GetKit(this.m_CurrentTeam.Id, 2);
			if (kit != null)
			{
				MainForm.CM.JumpTo(kit);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(3001);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0006D030 File Offset: 0x0006B230
		private void labelThirdKit_DoubleClick(object sender, EventArgs e)
		{
			Kit kit = FifaEnvironment.Kits.GetKit(this.m_CurrentTeam.Id, 3);
			if (kit != null)
			{
				MainForm.CM.JumpTo(kit);
				return;
			}
			FifaEnvironment.UserMessages.ShowMessage(3001);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0006D074 File Offset: 0x0006B274
		private void checkIsLoan_CheckedChanged(object sender, EventArgs e)
		{
			this.labelLoanEnd.Visible = this.checkIsLoan.Checked;
			this.labelLoanedFrom.Visible = this.checkIsLoan.Checked;
			this.dateLoanEnd.Visible = this.checkIsLoan.Checked;
			this.comboTeamLoanedFrom.Visible = this.checkIsLoan.Checked;
			if (this.m_Locked)
			{
				return;
			}
			Player player = this.m_CurrentTeamPlayer.Player;
			if (this.checkIsLoan.Checked)
			{
				player.IsLoaned = true;
				if (player.TeamLoanedFrom == null)
				{
					if (player.PreviousTeam != null)
					{
						Player player2 = player;
						player2.TeamLoanedFrom = player2.PreviousTeam;
					}
					else
					{
						player.TeamLoanedFrom = (Team)this.comboTeamLoanedFrom.SelectedItem;
					}
					this.comboTeamLoanedFrom.SelectedItem = player.TeamLoanedFrom;
				}
				DateTime loandateend = player.loandateend;
				return;
			}
			player.IsLoaned = false;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0006D158 File Offset: 0x0006B358
		private void comboTeamLoanedFrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentTeamPlayer == null)
			{
				return;
			}
			Player player = this.m_CurrentTeamPlayer.Player;
			if (player == null)
			{
				return;
			}
			if (this.comboTeamLoanedFrom.SelectedItem == null)
			{
				this.comboTeamLoanedFrom.Text = string.Empty;
				return;
			}
			player.TeamLoanedFrom = (Team)this.comboTeamLoanedFrom.SelectedItem;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0006D1BC File Offset: 0x0006B3BC
		private void dateLoanEnd_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			Player player = this.m_CurrentTeamPlayer.Player;
			if (player == null)
			{
				return;
			}
			player.loandateend = this.dateLoanEnd.Value;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0006D1F4 File Offset: 0x0006B3F4
		private void comboTeamPrevious_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentTeamPlayer == null)
			{
				return;
			}
			Player player = this.m_CurrentTeamPlayer.Player;
			if (player == null)
			{
				return;
			}
			Team team = (Team)this.comboTeamPrevious.SelectedItem;
			if (team == null)
			{
				return;
			}
			if (team != this.m_CurrentTeamPlayer.Team)
			{
				player.PreviousTeam = team;
				return;
			}
			player.PreviousTeam = null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0006D258 File Offset: 0x0006B458
		private void listViewTeamPlayers_KeyPress(object sender, KeyPressEventArgs e)
		{
			char keyChar = e.KeyChar;
			if (keyChar == '\r')
			{
				this.m_NewJerseyNum = -1;
				if (this.m_NewJerseyNumber != string.Empty)
				{
					if (this.m_NewJerseyNumber.Length > 2)
					{
						this.m_NewJerseyNumber = this.m_NewJerseyNumber.Substring(this.m_NewJerseyNumber.Length - 2);
					}
					this.m_NewJerseyNum = Convert.ToInt32(this.m_NewJerseyNumber);
					int jerseynumber = this.m_CurrentTeamPlayer.jerseynumber;
					TeamPlayer teamPlayer = this.m_CurrentTeam.Roster.IsNumberUsed(this.m_NewJerseyNum);
					for (int i = 0; i < this.listViewTeamPlayers.Items.Count; i++)
					{
						if (this.m_CurrentTeamPlayer == (TeamPlayer)this.listViewTeamPlayers.Items[i].Tag)
						{
							this.m_CurrentTeamPlayer.jerseynumber = this.m_NewJerseyNum;
							this.listViewTeamPlayers.Items[i].SubItems[5].Text = FifaUtil.PadBlanks(this.m_NewJerseyNumber, 2);
						}
						else if (teamPlayer == (TeamPlayer)this.listViewTeamPlayers.Items[i].Tag)
						{
							teamPlayer.jerseynumber = jerseynumber;
							this.listViewTeamPlayers.Items[i].SubItems[5].Text = FifaUtil.PadBlanks(teamPlayer.jerseynumber.ToString(), 2);
						}
					}
					this.m_NewJerseyNumber = string.Empty;
					return;
				}
			}
			else
			{
				if (keyChar >= '0' && keyChar <= '9')
				{
					this.m_NewJerseyNumber += keyChar.ToString();
					return;
				}
				if (keyChar == '+')
				{
					this.m_CurrentTeamPlayer.Player.ChangeSkills(1);
					this.listViewTeamPlayers.SelectedItems[0].SubItems[4].Text = this.m_CurrentTeamPlayer.Player.GetAverageRoleAttribute().ToString();
					return;
				}
				if (keyChar == '-')
				{
					this.m_CurrentTeamPlayer.Player.ChangeSkills(-1);
					this.listViewTeamPlayers.SelectedItems[0].SubItems[4].Text = this.m_CurrentTeamPlayer.Player.GetAverageRoleAttribute().ToString();
					return;
				}
				if (keyChar == '<')
				{
					this.numericRosterYear.Value = this.m_CurrentTeamPlayer.Player.contractvaliduntil - 1;
					return;
				}
				if (keyChar == '>')
				{
					this.numericRosterYear.Value = this.m_CurrentTeamPlayer.Player.contractvaliduntil + 1;
					return;
				}
				if (keyChar == '.')
				{
					this.m_CurrentTeamPlayer.State = this.m_CurrentTeamPlayer.State + 1;
					if (this.m_CurrentTeamPlayer.State == 2)
					{
						this.m_CurrentTeamPlayer.State = -1;
					}
					switch (this.m_CurrentTeamPlayer.State)
					{
					case -1:
						this.listViewTeamPlayers.SelectedItems[0].ForeColor = Color.Red;
						break;
					case 0:
						this.listViewTeamPlayers.SelectedItems[0].ForeColor = Color.Black;
						return;
					case 1:
						this.listViewTeamPlayers.SelectedItems[0].ForeColor = Color.Green;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
		private void buttonDeletePlayer_Click(object sender, EventArgs e)
		{
			if (this.listViewPlayersAvailable.SelectedItems.Count <= 0)
			{
				return;
			}
			Player player = (Player)this.listViewPlayersAvailable.SelectedItems[0].Tag;
			if (player != null)
			{
				FifaEnvironment.Players.DeletePlayer(player);
				this.listViewPlayersAvailable.Items.Remove(this.listViewPlayersAvailable.SelectedItems[0]);
				if (this.listViewPlayersAvailable.Items.Count > 0)
				{
					this.listViewPlayersAvailable.Items[0].Selected = true;
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0006D638 File Offset: 0x0006B838
		private void listViewTeamPlayers_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			string label = e.Label;
			this.m_CurrentTeamPlayer.Player.FastRename(label);
			e.CancelEdit = true;
			this.listViewTeamPlayers.SelectedItems[0].SubItems[0].Text = this.m_CurrentTeamPlayer.Player.Name;
			this.listViewTeamPlayers.SelectedItems[0].SubItems[1].Text = this.m_CurrentTeamPlayer.Player.firstname;
		}

		// Token: 0x04000673 RID: 1651
		public Team m_CurrentTeam;

		// Token: 0x04000674 RID: 1652
		private TabPage m_CurrentPage;

		// Token: 0x04000675 RID: 1653
		private Formation m_CurrentFormation;

		// Token: 0x04000676 RID: 1654
		private Formation m_BackupSpecificFormation;

		// Token: 0x04000677 RID: 1655
		private bool m_IsLoaded;

		// Token: 0x04000678 RID: 1656
		private bool m_Locked;

		// Token: 0x04000679 RID: 1657
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x0400067A RID: 1658
		private TeamPlayer m_CurrentTeamPlayer;

		// Token: 0x0400067B RID: 1659
		private Player m_CurrentAvailablePlayer;

		// Token: 0x0400067C RID: 1660
		private Team m_CurrentAvailableTeam;

		// Token: 0x0400067D RID: 1661
		private string m_TeamCurrentFolder = FifaEnvironment.ExportFolder;

		// Token: 0x0400067E RID: 1662
		private WebGrabber m_WebGrabber = new WebGrabber();

		// Token: 0x0400067F RID: 1663
		private bool m_AvailablePlayerLocked;

		// Token: 0x04000680 RID: 1664
		private bool m_ChangeNumberFlag;

		// Token: 0x04000681 RID: 1665
		private Label m_DraggedLabel;

		// Token: 0x04000682 RID: 1666
		private Point m_LabelLocation = new Point(0, 0);

		// Token: 0x04000683 RID: 1667
		private int m_BoundLeft;

		// Token: 0x04000684 RID: 1668
		private int m_BoundRight = 250;

		// Token: 0x04000685 RID: 1669
		private int m_BoundTop;

		// Token: 0x04000686 RID: 1670
		private int m_BoundBottom = 350;

		// Token: 0x04000687 RID: 1671
		private bool m_LockUserChanges;

		// Token: 0x04000688 RID: 1672
		private QuickEditPlayerPanel[] m_QuickPanels = new QuickEditPlayerPanel[40];

		// Token: 0x04000689 RID: 1673
		private DataTable m_WebPlayerTable = new DataTable("WebPlayer");

		// Token: 0x0400068A RID: 1674
		private DataTable m_WebTeamTable = new DataTable("WebTeam");

		// Token: 0x0400068B RID: 1675
		public string m_NewJerseyNumber = string.Empty;

		// Token: 0x0400068C RID: 1676
		public int m_NewJerseyNum = -1;
	}
}
