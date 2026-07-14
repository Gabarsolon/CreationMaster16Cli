using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000004 RID: 4
	public partial class GameGraphicForm : Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public GameGraphicForm()
		{
			this.InitializeComponent();
			this.viewer2DMessi.ButtonStripVisible = true;
			this.viewer2DMessi.RemoveButton = false;
			this.viewer2DFifa.ButtonStripVisible = true;
			this.viewer2DFifa.RemoveButton = false;
			this.multiViewerMenuPictures.AutoTransparency = false;
			this.multiViewerMenuPictures.FullSizeButton = true;
			this.multiViewerMenuPictures.ShowButton = true;
			this.multiViewerMenuPictures.ShowDeleteButton = true;
			this.multiViewerMenuPictures.CheckBitmapSize = true;
			this.multiViewerMenuPictures.FixedSize = false;
			this.multiViewerMenuPictures.buttonSave.Visible = false;
			this.multiViewerMenuPictures.LabelText = "Menu";
			this.multiViewerMenuPictures.buttonImportRx3.Visible = false;
			this.multiViewerMenuPictures.buttonExportRx3.Visible = false;
			this.multiViewerMenuPictures.Rx3DeleteDelegate = new MultiViewer2D.Rx3DeleteHandler(this.DeleteBitmapMenu);
			this.multiViewerMenuPictures.BitmapUpdateDelegate = new MultiViewer2D.BitmapUpdateHandler(this.SaveBitmapMenu);
			this.multiViewerIcons.AutoTransparency = false;
			this.multiViewerIcons.FullSizeButton = true;
			this.multiViewerIcons.ShowButton = true;
			this.multiViewerIcons.ShowDeleteButton = true;
			this.multiViewerIcons.CheckBitmapSize = true;
			this.multiViewerIcons.FixedSize = false;
			this.multiViewerIcons.buttonSave.Visible = false;
			this.multiViewerIcons.LabelText = "Icons";
			this.multiViewerIcons.buttonImportRx3.Visible = false;
			this.multiViewerIcons.buttonExportRx3.Visible = false;
			this.viewer2DIcons.ImageImport = new Viewer2D.ImageImportHandler(this.ImportIcon);
			this.viewer2DIcons.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteIcon);
			this.viewer2DIcons.ButtonStripVisible = true;
			this.viewer2DIcons.RemoveButton = true;
			GameGraphicForm.SetupFileNames();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005DD0 File Offset: 0x00003FD0
		private void GameGraphicForm_Load(object sender, EventArgs e)
		{
			this.LoadGameGraphics();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005DD8 File Offset: 0x00003FD8
		public static void SetupFileNames()
		{
			GameGraphicForm.s_FileNames[0] = "data/ui/imgassets/tiles/mainhub/continuecareer.dds";
			GameGraphicForm.s_FileNames[1] = "data/ui/imgassets/tiles/mainhub/continuecareerlarge.dds";
			GameGraphicForm.s_FileNames[2] = "data/ui/imgassets/tiles/mainhub/coopseasons.dds";
			GameGraphicForm.s_FileNames[3] = "data/ui/imgassets/tiles/mainhub/coopseasonslarge.dds";
			GameGraphicForm.s_FileNames[4] = "data/ui/imgassets/tiles/mainhub/createwomentournament.dds";
			GameGraphicForm.s_FileNames[5] = "data/ui/imgassets/tiles/mainhub/customtournament.dds";
			GameGraphicForm.s_FileNames[6] = "data/ui/imgassets/tiles/mainhub/easfc_logo_bg_204.dds";
			GameGraphicForm.s_FileNames[7] = "data/ui/imgassets/tiles/mainhub/easfc_logo_bg_418.dds";
			GameGraphicForm.s_FileNames[8] = "data/ui/imgassets/tiles/mainhub/eatv_offline.dds";
			GameGraphicForm.s_FileNames[9] = "data/ui/imgassets/tiles/mainhub/editplayers.dds";
			GameGraphicForm.s_FileNames[10] = "data/ui/imgassets/tiles/mainhub/flt_disconnected.dds";
			GameGraphicForm.s_FileNames[11] = "data/ui/imgassets/tiles/mainhub/kickoff.dds";
			GameGraphicForm.s_FileNames[12] = "data/ui/imgassets/tiles/mainhub/kickofflarge0.dds";
			GameGraphicForm.s_FileNames[13] = "data/ui/imgassets/tiles/mainhub/loadcareer.dds";
			GameGraphicForm.s_FileNames[14] = "data/ui/imgassets/tiles/mainhub/loadtournamentlarge.dds";
			GameGraphicForm.s_FileNames[15] = "data/ui/imgassets/tiles/mainhub/loadwomentournament.dds";
			GameGraphicForm.s_FileNames[16] = "data/ui/imgassets/tiles/mainhub/loadwomentournamentlarge.dds";
			GameGraphicForm.s_FileNames[17] = "data/ui/imgassets/tiles/mainhub/newcareer.dds";
			GameGraphicForm.s_FileNames[18] = "data/ui/imgassets/tiles/mainhub/newtournament.dds";
			GameGraphicForm.s_FileNames[19] = "data/ui/imgassets/tiles/mainhub/onlinefriendlieslarge.dds";
			GameGraphicForm.s_FileNames[20] = "data/ui/imgassets/tiles/mainhub/practicearena.dds";
			GameGraphicForm.s_FileNames[21] = "data/ui/imgassets/tiles/mainhub/proclubs.dds";
			GameGraphicForm.s_FileNames[22] = "data/ui/imgassets/tiles/mainhub/proclubslarge.dds";
			GameGraphicForm.s_FileNames[23] = "data/ui/imgassets/tiles/mainhub/seasons.dds";
			GameGraphicForm.s_FileNames[24] = "data/ui/imgassets/tiles/mainhub/seasonslarge.dds";
			GameGraphicForm.s_FileNames[25] = "data/ui/imgassets/tiles/mainhub/skillgames.dds";
			GameGraphicForm.s_FileNames[26] = "data/ui/imgassets/tiles/mainhub/skgameslarge.dds";
			GameGraphicForm.s_FileNames[27] = "data/ui/imgassets/tiles/careerhub/calendar_med.dds";
			GameGraphicForm.s_FileNames[28] = "data/ui/imgassets/tiles/careerhub/contracts_medtall.dds";
			GameGraphicForm.s_FileNames[29] = "data/ui/imgassets/tiles/careerhub/endofseason_med.dds";
			GameGraphicForm.s_FileNames[30] = "data/ui/imgassets/tiles/careerhub/otherleagues_med.dds";
			GameGraphicForm.s_FileNames[31] = "data/ui/imgassets/tiles/careerhub/playerstats_med.dds";
			GameGraphicForm.s_FileNames[32] = "data/ui/imgassets/tiles/careerhub/searchplayers_medtall.dds";
			GameGraphicForm.s_FileNames[33] = "data/ui/imgassets/tiles/careerhub/sellplayers_medtall.dds";
			GameGraphicForm.s_FileNames[34] = "data/ui/imgassets/tiles/careerhub/teamstats_med.dds";
			GameGraphicForm.s_FileNames[35] = "data/ui/imgassets/tiles/careerhub/teamstats_medtall.dds";
			GameGraphicForm.s_FileNames[36] = "data/ui/imgassets/tiles/careerhub/topscorers_medtall.dds";
			GameGraphicForm.s_FileNames[37] = "data/ui/imgassets/tiles/careerhub/trainerintro_lrg.dds";
			GameGraphicForm.s_FileNames[38] = "data/ui/imgassets/tiles/careerhub/youthacademy_medtall.dds";
			GameGraphicForm.s_FileNames[39] = "data/ui/imgassets/tiles/careerhub/youthscouts_medtall.dds";
			GameGraphicForm.s_FileNames[40] = "data/ui/imgassets/tiles/careerhub/shortlist_medtall.dds";
			GameGraphicForm.s_FileNames[41] = "data/ui/imgassets/tiles/careerhub/scoutinginstructions_medtall.dds";
			GameGraphicForm.s_FileNames[42] = "data/ui/imgassets/tiles/careerhub/transfernegotiations_medtall.dds";
			GameGraphicForm.s_TemplateNames[0] = "data/ui/imgassets/tiles/mainhub/menu_576x204.dds";
			GameGraphicForm.s_TemplateNames[1] = "data/ui/imgassets/tiles/mainhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[2] = "data/ui/imgassets/tiles/mainhub/menu_544x204.dds";
			GameGraphicForm.s_TemplateNames[3] = "data/ui/imgassets/tiles/mainhub/menu_772x420.dds";
			GameGraphicForm.s_TemplateNames[4] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[5] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[6] = "data/ui/imgassets/tiles/mainhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[7] = "data/ui/imgassets/tiles/mainhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[8] = "data/ui/imgassets/tiles/mainhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[9] = "data/ui/imgassets/tiles/mainhub/menu_420x204.dds";
			GameGraphicForm.s_TemplateNames[10] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[11] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[12] = "data/ui/imgassets/tiles/mainhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[13] = "data/ui/imgassets/tiles/mainhub/menu_544x204.dds";
			GameGraphicForm.s_TemplateNames[14] = "data/ui/imgassets/tiles/mainhub/menu_656x420.dds";
			GameGraphicForm.s_TemplateNames[15] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[16] = "data/ui/imgassets/tiles/mainhub/menu_776x420.dds";
			GameGraphicForm.s_TemplateNames[17] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[18] = "data/ui/imgassets/tiles/mainhub/menu_600x204.dds";
			GameGraphicForm.s_TemplateNames[19] = "data/ui/imgassets/tiles/mainhub/menu_772x420.dds";
			GameGraphicForm.s_TemplateNames[20] = "data/ui/imgassets/tiles/mainhub/menu_596x204.dds";
			GameGraphicForm.s_TemplateNames[21] = "data/ui/imgassets/tiles/mainhub/menu_544x204.dds";
			GameGraphicForm.s_TemplateNames[22] = "data/ui/imgassets/tiles/mainhub/menu_672x204.dds";
			GameGraphicForm.s_TemplateNames[23] = "data/ui/imgassets/tiles/mainhub/menu_604x204.dds";
			GameGraphicForm.s_TemplateNames[24] = "data/ui/imgassets/tiles/mainhub/menu_680x420.dds";
			GameGraphicForm.s_TemplateNames[25] = "data/ui/imgassets/tiles/mainhub/menu_596x204.dds";
			GameGraphicForm.s_TemplateNames[26] = "data/ui/imgassets/tiles/mainhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[27] = "data/ui/imgassets/tiles/careerhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[28] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[29] = "data/ui/imgassets/tiles/careerhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[30] = "data/ui/imgassets/tiles/careerhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[31] = "data/ui/imgassets/tiles/careerhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[32] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[33] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[34] = "data/ui/imgassets/tiles/careerhub/menu_848x204.dds";
			GameGraphicForm.s_TemplateNames[35] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[36] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[37] = "data/ui/imgassets/tiles/careerhub/menu_848x420.dds";
			GameGraphicForm.s_TemplateNames[38] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[39] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[40] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[41] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_TemplateNames[42] = "data/ui/imgassets/tiles/careerhub/menu_420x420.dds";
			GameGraphicForm.s_IconNames[0] = "data/ui/imgassets/tileicons/ti_accomplishments_small_active.dds";
			GameGraphicForm.s_IconNames[1] = "data/ui/imgassets/tileicons/ti_accomplishments_small_nonactive.dds";
			GameGraphicForm.s_IconNames[2] = "data/ui/imgassets/tileicons/ti_age_sml_active.dds";
			GameGraphicForm.s_IconNames[3] = "data/ui/imgassets/tileicons/ti_age_sml_nonactive.dds";
			GameGraphicForm.s_IconNames[4] = "data/ui/imgassets/tileicons/ti_basiccontrolspc_active.dds";
			GameGraphicForm.s_IconNames[5] = "data/ui/imgassets/tileicons/ti_basiccontrolspc_nonactive.dds";
			GameGraphicForm.s_IconNames[6] = "data/ui/imgassets/tileicons/ti_basiccontrolsps4_active.dds";
			GameGraphicForm.s_IconNames[7] = "data/ui/imgassets/tileicons/ti_basiccontrolsps4_nonactive.dds";
			GameGraphicForm.s_IconNames[8] = "data/ui/imgassets/tileicons/ti_basiccontrolsxbox_active.dds";
			GameGraphicForm.s_IconNames[9] = "data/ui/imgassets/tileicons/ti_basiccontrolsxbox_nonactive.dds";
			GameGraphicForm.s_IconNames[10] = "data/ui/imgassets/tileicons/ti_basiccontrols_square_active.dds";
			GameGraphicForm.s_IconNames[11] = "data/ui/imgassets/tileicons/ti_basiccontrols_square_nonactive.dds";
			GameGraphicForm.s_IconNames[12] = "data/ui/imgassets/tileicons/ti_browsejobs_small_active.dds";
			GameGraphicForm.s_IconNames[13] = "data/ui/imgassets/tileicons/ti_browsejobs_small_nonactive.dds";
			GameGraphicForm.s_IconNames[14] = "data/ui/imgassets/tileicons/ti_calendar_small_active.dds";
			GameGraphicForm.s_IconNames[15] = "data/ui/imgassets/tileicons/ti_calendar_small_nonactive.dds";
			GameGraphicForm.s_IconNames[16] = "data/ui/imgassets/tileicons/ti_catalogue_square_active.dds";
			GameGraphicForm.s_IconNames[17] = "data/ui/imgassets/tileicons/ti_catalogue_square_nonactive.dds";
			GameGraphicForm.s_IconNames[18] = "data/ui/imgassets/tileicons/ti_celebrations_square_active.dds";
			GameGraphicForm.s_IconNames[19] = "data/ui/imgassets/tileicons/ti_celebrations_square_nonactive.dds";
			GameGraphicForm.s_IconNames[20] = "data/ui/imgassets/tileicons/ti_combosettings_square_active.dds";
			GameGraphicForm.s_IconNames[21] = "data/ui/imgassets/tileicons/ti_combosettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[22] = "data/ui/imgassets/tileicons/ti_contract_sml_active.dds";
			GameGraphicForm.s_IconNames[23] = "data/ui/imgassets/tileicons/ti_contract_sml_nonactive.dds";
			GameGraphicForm.s_IconNames[24] = "data/ui/imgassets/tileicons/ti_controllersettingspc_active.dds";
			GameGraphicForm.s_IconNames[25] = "data/ui/imgassets/tileicons/ti_controllersettingspc_nonactive.dds";
			GameGraphicForm.s_IconNames[26] = "data/ui/imgassets/tileicons/ti_controllersettingsps4_active.dds";
			GameGraphicForm.s_IconNames[27] = "data/ui/imgassets/tileicons/ti_controllersettingsps4_nonactive.dds";
			GameGraphicForm.s_IconNames[28] = "data/ui/imgassets/tileicons/ti_controllersettingsxbox_active.dds";
			GameGraphicForm.s_IconNames[29] = "data/ui/imgassets/tileicons/ti_controllersettingsxbox_nonactive.dds";
			GameGraphicForm.s_IconNames[30] = "data/ui/imgassets/tileicons/ti_createplayer_square_active.dds";
			GameGraphicForm.s_IconNames[31] = "data/ui/imgassets/tileicons/ti_createplayer_square_nonactive.dds";
			GameGraphicForm.s_IconNames[32] = "data/ui/imgassets/tileicons/ti_credits_square_active.dds";
			GameGraphicForm.s_IconNames[33] = "data/ui/imgassets/tileicons/ti_credits_square_nonactive.dds";
			GameGraphicForm.s_IconNames[34] = "data/ui/imgassets/tileicons/ti_deleteplayer_square_active.dds";
			GameGraphicForm.s_IconNames[35] = "data/ui/imgassets/tileicons/ti_deleteplayer_square_nonactive.dds";
			GameGraphicForm.s_IconNames[36] = "data/ui/imgassets/tileicons/ti_delete_square_active.dds";
			GameGraphicForm.s_IconNames[37] = "data/ui/imgassets/tileicons/ti_delete_square_nonactive.dds";
			GameGraphicForm.s_IconNames[38] = "data/ui/imgassets/tileicons/ti_disconnected_half_active.dds";
			GameGraphicForm.s_IconNames[39] = "data/ui/imgassets/tileicons/ti_disconnected_half_nonactive.dds";
			GameGraphicForm.s_IconNames[40] = "data/ui/imgassets/tileicons/ti_downloadupdates_square_active.dds";
			GameGraphicForm.s_IconNames[41] = "data/ui/imgassets/tileicons/ti_downloadupdates_square_nonactive.dds";
			GameGraphicForm.s_IconNames[42] = "data/ui/imgassets/tileicons/ti_eaaccountsettings_half_active.dds";
			GameGraphicForm.s_IconNames[43] = "data/ui/imgassets/tileicons/ti_eaaccountsettings_half_nonactive.dds";
			GameGraphicForm.s_IconNames[44] = "data/ui/imgassets/tileicons/ti_eaaccountsettings_square_active.dds";
			GameGraphicForm.s_IconNames[45] = "data/ui/imgassets/tileicons/ti_eaaccountsettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[46] = "data/ui/imgassets/tileicons/ti_easfc_logo_small_active.dds";
			GameGraphicForm.s_IconNames[47] = "data/ui/imgassets/tileicons/ti_easfc_logo_small_nonactive.dds";
			GameGraphicForm.s_IconNames[48] = "data/ui/imgassets/tileicons/ti_easportstrax_square_active.dds";
			GameGraphicForm.s_IconNames[49] = "data/ui/imgassets/tileicons/ti_easportstrax_square_nonactive.dds";
			GameGraphicForm.s_IconNames[50] = "data/ui/imgassets/tileicons/ti_editplayereasfclock_small_active.dds";
			GameGraphicForm.s_IconNames[51] = "data/ui/imgassets/tileicons/ti_editplayereasfclock_small_nonactive.dds";
			GameGraphicForm.s_IconNames[52] = "data/ui/imgassets/tileicons/ti_editplayers_small_active.dds";
			GameGraphicForm.s_IconNames[53] = "data/ui/imgassets/tileicons/ti_editplayers_small_nonactive.dds";
			GameGraphicForm.s_IconNames[54] = "data/ui/imgassets/tileicons/ti_editplayer_med_active.dds";
			GameGraphicForm.s_IconNames[55] = "data/ui/imgassets/tileicons/ti_editplayer_med_nonactive.dds";
			GameGraphicForm.s_IconNames[56] = "data/ui/imgassets/tileicons/ti_editplayer_square_active.dds";
			GameGraphicForm.s_IconNames[57] = "data/ui/imgassets/tileicons/ti_editplayer_square_nonactive.dds";
			GameGraphicForm.s_IconNames[58] = "data/ui/imgassets/tileicons/ti_editteams_square_active.dds";
			GameGraphicForm.s_IconNames[59] = "data/ui/imgassets/tileicons/ti_editteams_square_nonactive.dds";
			GameGraphicForm.s_IconNames[60] = "data/ui/imgassets/tileicons/ti_endmatchasdraw_med_active.dds";
			GameGraphicForm.s_IconNames[61] = "data/ui/imgassets/tileicons/ti_endmatchasdraw_med_nonactive.dds";
			GameGraphicForm.s_IconNames[62] = "data/ui/imgassets/tileicons/ti_enduserlicenseagreement_square_active.dds";
			GameGraphicForm.s_IconNames[63] = "data/ui/imgassets/tileicons/ti_enduserlicenseagreement_square_nonactive.dds";
			GameGraphicForm.s_IconNames[64] = "data/ui/imgassets/tileicons/ti_finances_med_active.dds";
			GameGraphicForm.s_IconNames[65] = "data/ui/imgassets/tileicons/ti_finances_med_nonactive.dds";
			GameGraphicForm.s_IconNames[66] = "data/ui/imgassets/tileicons/ti_fixtures_medtall_active.dds";
			GameGraphicForm.s_IconNames[67] = "data/ui/imgassets/tileicons/ti_fixtures_medtall_nonactive.dds";
			GameGraphicForm.s_IconNames[68] = "data/ui/imgassets/tileicons/ti_fixtures_small_active.dds";
			GameGraphicForm.s_IconNames[69] = "data/ui/imgassets/tileicons/ti_fixtures_small_nonactive.dds";
			GameGraphicForm.s_IconNames[70] = "data/ui/imgassets/tileicons/ti_formationsettings_square_active.dds";
			GameGraphicForm.s_IconNames[71] = "data/ui/imgassets/tileicons/ti_formationsettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[72] = "data/ui/imgassets/tileicons/ti_friendliesplaymatch_sml_active.dds";
			GameGraphicForm.s_IconNames[73] = "data/ui/imgassets/tileicons/ti_friendliesplaymatch_sml_nonactive.dds";
			GameGraphicForm.s_IconNames[74] = "data/ui/imgassets/tileicons/ti_gameplayassistance_active.dds";
			GameGraphicForm.s_IconNames[75] = "data/ui/imgassets/tileicons/ti_gameplayassistance_nonactive.dds";
			GameGraphicForm.s_IconNames[76] = "data/ui/imgassets/tileicons/ti_gameplayassistance_square_active.dds";
			GameGraphicForm.s_IconNames[77] = "data/ui/imgassets/tileicons/ti_gameplayassistance_square_nonactive.dds";
			GameGraphicForm.s_IconNames[78] = "data/ui/imgassets/tileicons/ti_gamesettings_square_active.dds";
			GameGraphicForm.s_IconNames[79] = "data/ui/imgassets/tileicons/ti_gamesettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[80] = "data/ui/imgassets/tileicons/ti_globaltransfernetwork_med_active.dds";
			GameGraphicForm.s_IconNames[81] = "data/ui/imgassets/tileicons/ti_globaltransfernetwork_med_nonactive.dds";
			GameGraphicForm.s_IconNames[82] = "data/ui/imgassets/tileicons/ti_goalcelebrations_square_active.dds";
			GameGraphicForm.s_IconNames[83] = "data/ui/imgassets/tileicons/ti_goalcelebrations_square_nonactive.dds";
			GameGraphicForm.s_IconNames[84] = "data/ui/imgassets/tileicons/ti_help_small_active.dds";
			GameGraphicForm.s_IconNames[85] = "data/ui/imgassets/tileicons/ti_help_small_nonactive.dds";
			GameGraphicForm.s_IconNames[86] = "data/ui/imgassets/tileicons/ti_help_square_active.dds";
			GameGraphicForm.s_IconNames[87] = "data/ui/imgassets/tileicons/ti_help_square_nonactive.dds";
			GameGraphicForm.s_IconNames[88] = "data/ui/imgassets/tileicons/ti_injurylist_small_active.dds";
			GameGraphicForm.s_IconNames[89] = "data/ui/imgassets/tileicons/ti_injurylist_small_nonactive.dds";
			GameGraphicForm.s_IconNames[90] = "data/ui/imgassets/tileicons/ti_instantreplay_small_active.dds";
			GameGraphicForm.s_IconNames[91] = "data/ui/imgassets/tileicons/ti_instantreplay_small_nonactive.dds";
			GameGraphicForm.s_IconNames[92] = "data/ui/imgassets/tileicons/ti_kinectsettings_square_active.dds";
			GameGraphicForm.s_IconNames[93] = "data/ui/imgassets/tileicons/ti_kinectsettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[94] = "data/ui/imgassets/tileicons/ti_kitnumbers_small_active.dds";
			GameGraphicForm.s_IconNames[95] = "data/ui/imgassets/tileicons/ti_kitnumbers_small_nonactive.dds";
			GameGraphicForm.s_IconNames[96] = "data/ui/imgassets/tileicons/ti_leaguetable_medtall_active.dds";
			GameGraphicForm.s_IconNames[97] = "data/ui/imgassets/tileicons/ti_leaguetable_medtall_nonactive.dds";
			GameGraphicForm.s_IconNames[98] = "data/ui/imgassets/tileicons/ti_loadfifaprofile_square_active.dds";
			GameGraphicForm.s_IconNames[99] = "data/ui/imgassets/tileicons/ti_loadfifaprofile_square_nonactive.dds";
			GameGraphicForm.s_IconNames[100] = "data/ui/imgassets/tileicons/ti_loadsquads_square_active.dds";
			GameGraphicForm.s_IconNames[101] = "data/ui/imgassets/tileicons/ti_loadsquads_square_nonactive.dds";
			GameGraphicForm.s_IconNames[102] = "data/ui/imgassets/tileicons/ti_matchdetails_med_active.dds";
			GameGraphicForm.s_IconNames[103] = "data/ui/imgassets/tileicons/ti_matchdetails_med_nonactive.dds";
			GameGraphicForm.s_IconNames[104] = "data/ui/imgassets/tileicons/ti_matchhighlights_small_active.dds";
			GameGraphicForm.s_IconNames[105] = "data/ui/imgassets/tileicons/ti_matchhighlights_small_nonactive.dds";
			GameGraphicForm.s_IconNames[106] = "data/ui/imgassets/tileicons/ti_matchmakingsettings_longmedium_active.dds";
			GameGraphicForm.s_IconNames[107] = "data/ui/imgassets/tileicons/ti_matchmakingsettings_longmedium_nonactive.dds";
			GameGraphicForm.s_IconNames[108] = "data/ui/imgassets/tileicons/ti_mutualquit_small_active.dds";
			GameGraphicForm.s_IconNames[109] = "data/ui/imgassets/tileicons/ti_mutualquit_small_nonactive.dds";
			GameGraphicForm.s_IconNames[110] = "data/ui/imgassets/tileicons/ti_myactions_small_active.dds";
			GameGraphicForm.s_IconNames[111] = "data/ui/imgassets/tileicons/ti_myactions_small_nonactive.dds";
			GameGraphicForm.s_IconNames[112] = "data/ui/imgassets/tileicons/ti_mycareer_small_active.dds";
			GameGraphicForm.s_IconNames[113] = "data/ui/imgassets/tileicons/ti_mycareer_small_nonactive.dds";
			GameGraphicForm.s_IconNames[114] = "data/ui/imgassets/tileicons/ti_nationalsquads_small_active.dds";
			GameGraphicForm.s_IconNames[115] = "data/ui/imgassets/tileicons/ti_nationalsquads_small_nonactive.dds";
			GameGraphicForm.s_IconNames[116] = "data/ui/imgassets/tileicons/ti_nationalsquads_square_active.dds";
			GameGraphicForm.s_IconNames[117] = "data/ui/imgassets/tileicons/ti_nationalsquads_square_nonactive.dds";
			GameGraphicForm.s_IconNames[118] = "data/ui/imgassets/tileicons/ti_natlsquadselection_small_active.dds";
			GameGraphicForm.s_IconNames[119] = "data/ui/imgassets/tileicons/ti_natlsquadselection_small_nonactive.dds";
			GameGraphicForm.s_IconNames[120] = "data/ui/imgassets/tileicons/ti_natlteamjoboffers_small_active.dds";
			GameGraphicForm.s_IconNames[121] = "data/ui/imgassets/tileicons/ti_natlteamjoboffers_small_nonactive.dds";
			GameGraphicForm.s_IconNames[122] = "data/ui/imgassets/tileicons/ti_nextmatch_small_active.dds";
			GameGraphicForm.s_IconNames[123] = "data/ui/imgassets/tileicons/ti_nextmatch_small_nonactive.dds";
			GameGraphicForm.s_IconNames[124] = "data/ui/imgassets/tileicons/ti_objectives_small_active.dds";
			GameGraphicForm.s_IconNames[125] = "data/ui/imgassets/tileicons/ti_objectives_small_nonactive.dds";
			GameGraphicForm.s_IconNames[126] = "data/ui/imgassets/tileicons/ti_onlinesettings_square_active.dds";
			GameGraphicForm.s_IconNames[127] = "data/ui/imgassets/tileicons/ti_onlinesettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[128] = "data/ui/imgassets/tileicons/ti_penalties_med_active.dds";
			GameGraphicForm.s_IconNames[129] = "data/ui/imgassets/tileicons/ti_penalties_med_nonactive.dds";
			GameGraphicForm.s_IconNames[130] = "data/ui/imgassets/tileicons/ti_playerratings_med_active.dds";
			GameGraphicForm.s_IconNames[131] = "data/ui/imgassets/tileicons/ti_playerratings_med_nonactive.dds";
			GameGraphicForm.s_IconNames[132] = "data/ui/imgassets/tileicons/ti_privacysettings_longmedium_active.dds";
			GameGraphicForm.s_IconNames[133] = "data/ui/imgassets/tileicons/ti_privacysettings_longmedium_nonactive.dds";
			GameGraphicForm.s_IconNames[134] = "data/ui/imgassets/tileicons/ti_privacysettings_square_active.dds";
			GameGraphicForm.s_IconNames[135] = "data/ui/imgassets/tileicons/ti_privacysettings_square_nonactive.dds";
			GameGraphicForm.s_IconNames[136] = "data/ui/imgassets/tileicons/ti_profile_square_active.dds";
			GameGraphicForm.s_IconNames[137] = "data/ui/imgassets/tileicons/ti_profile_square_nonactive.dds";
			GameGraphicForm.s_IconNames[138] = "data/ui/imgassets/tileicons/ti_psvr_square_active.dds";
			GameGraphicForm.s_IconNames[139] = "data/ui/imgassets/tileicons/ti_psvr_square_nonactive.dds";
			GameGraphicForm.s_IconNames[140] = "data/ui/imgassets/tileicons/ti_quit_small_active.dds";
			GameGraphicForm.s_IconNames[141] = "data/ui/imgassets/tileicons/ti_quit_small_nonactive.dds";
			GameGraphicForm.s_IconNames[142] = "data/ui/imgassets/tileicons/ti_remoteplay_longmedium.dds";
			GameGraphicForm.s_IconNames[143] = "data/ui/imgassets/tileicons/ti_remoteplay_small_active.dds";
			GameGraphicForm.s_IconNames[144] = "data/ui/imgassets/tileicons/ti_remoteplay_small_nonactive.dds";
			GameGraphicForm.s_IconNames[145] = "data/ui/imgassets/tileicons/ti_requestfunds_small_active.dds";
			GameGraphicForm.s_IconNames[146] = "data/ui/imgassets/tileicons/ti_requestfunds_small_nonactive.dds";
			GameGraphicForm.s_IconNames[147] = "data/ui/imgassets/tileicons/ti_requestsub_small_active.dds";
			GameGraphicForm.s_IconNames[148] = "data/ui/imgassets/tileicons/ti_requestsub_small_nonactive.dds";
			GameGraphicForm.s_IconNames[149] = "data/ui/imgassets/tileicons/ti_resetallsquads_square_active.dds";
			GameGraphicForm.s_IconNames[150] = "data/ui/imgassets/tileicons/ti_resetallsquads_square_nonactive.dds";
			GameGraphicForm.s_IconNames[151] = "data/ui/imgassets/tileicons/ti_resetofsquads_square_active.dds";
			GameGraphicForm.s_IconNames[152] = "data/ui/imgassets/tileicons/ti_resetofsquads_square_nonactive.dds";
			GameGraphicForm.s_IconNames[153] = "data/ui/imgassets/tileicons/ti_resignnatlteam_small_active.dds";
			GameGraphicForm.s_IconNames[154] = "data/ui/imgassets/tileicons/ti_resignnatlteam_small_nonactive.dds";
			GameGraphicForm.s_IconNames[155] = "data/ui/imgassets/tileicons/ti_restartlocked_small_active.dds";
			GameGraphicForm.s_IconNames[156] = "data/ui/imgassets/tileicons/ti_restartlocked_small_nonactive.dds";
			GameGraphicForm.s_IconNames[157] = "data/ui/imgassets/tileicons/ti_restartwithnewteams_small_active.dds";
			GameGraphicForm.s_IconNames[158] = "data/ui/imgassets/tileicons/ti_restartwithnewteams_small_nonactive.dds";
			GameGraphicForm.s_IconNames[159] = "data/ui/imgassets/tileicons/ti_restart_small_active.dds";
			GameGraphicForm.s_IconNames[160] = "data/ui/imgassets/tileicons/ti_restart_small_nonactive.dds";
			GameGraphicForm.s_IconNames[161] = "data/ui/imgassets/tileicons/ti_resumematch_small_active.dds";
			GameGraphicForm.s_IconNames[162] = "data/ui/imgassets/tileicons/ti_resumematch_small_nonactive.dds";
			GameGraphicForm.s_IconNames[163] = "data/ui/imgassets/tileicons/ti_savefifaprofile_square_active.dds";
			GameGraphicForm.s_IconNames[164] = "data/ui/imgassets/tileicons/ti_savefifaprofile_square_nonactive.dds";
			GameGraphicForm.s_IconNames[165] = "data/ui/imgassets/tileicons/ti_savesquads_square_active.dds";
			GameGraphicForm.s_IconNames[166] = "data/ui/imgassets/tileicons/ti_savesquads_square_nonactive.dds";
			GameGraphicForm.s_IconNames[167] = "data/ui/imgassets/tileicons/ti_searchclubs_med_active.dds";
			GameGraphicForm.s_IconNames[168] = "data/ui/imgassets/tileicons/ti_searchclubs_med_nonactive.dds";
			GameGraphicForm.s_IconNames[169] = "data/ui/imgassets/tileicons/ti_selectkeeperarena_square_active.dds";
			GameGraphicForm.s_IconNames[170] = "data/ui/imgassets/tileicons/ti_selectkeeperarena_square_nonactive.dds";
			GameGraphicForm.s_IconNames[171] = "data/ui/imgassets/tileicons/ti_selectplayerarena_square_active.dds";
			GameGraphicForm.s_IconNames[172] = "data/ui/imgassets/tileicons/ti_selectplayerarena_square_nonactive.dds";
			GameGraphicForm.s_IconNames[173] = "data/ui/imgassets/tileicons/ti_selectsidespc_active.dds";
			GameGraphicForm.s_IconNames[174] = "data/ui/imgassets/tileicons/ti_selectsidespc_nonactive.dds";
			GameGraphicForm.s_IconNames[175] = "data/ui/imgassets/tileicons/ti_selectsidesps4_active.dds";
			GameGraphicForm.s_IconNames[176] = "data/ui/imgassets/tileicons/ti_selectsidesps4_nonactive.dds";
			GameGraphicForm.s_IconNames[177] = "data/ui/imgassets/tileicons/ti_selectsidesxbox_active.dds";
			GameGraphicForm.s_IconNames[178] = "data/ui/imgassets/tileicons/ti_selectsidesxbox_nonactive.dds";
			GameGraphicForm.s_IconNames[179] = "data/ui/imgassets/tileicons/ti_settings_smallw_active.dds";
			GameGraphicForm.s_IconNames[180] = "data/ui/imgassets/tileicons/ti_settings_smallw_nonactive.dds";
			GameGraphicForm.s_IconNames[181] = "data/ui/imgassets/tileicons/ti_settings_small_active.dds";
			GameGraphicForm.s_IconNames[182] = "data/ui/imgassets/tileicons/ti_settings_small_nonactive.dds";
			GameGraphicForm.s_IconNames[183] = "data/ui/imgassets/tileicons/ti_simmatch_smallw_active.dds";
			GameGraphicForm.s_IconNames[184] = "data/ui/imgassets/tileicons/ti_simmatch_smallw_nonactive.dds";
			GameGraphicForm.s_IconNames[185] = "data/ui/imgassets/tileicons/ti_simmatch_small_active.dds";
			GameGraphicForm.s_IconNames[186] = "data/ui/imgassets/tileicons/ti_simmatch_small_nonactive.dds";
			GameGraphicForm.s_IconNames[187] = "data/ui/imgassets/tileicons/ti_simmatch_sml_active.dds";
			GameGraphicForm.s_IconNames[188] = "data/ui/imgassets/tileicons/ti_simmatch_sml_nonactive.dds";
			GameGraphicForm.s_IconNames[189] = "data/ui/imgassets/tileicons/ti_skillmoves_square_active.dds";
			GameGraphicForm.s_IconNames[190] = "data/ui/imgassets/tileicons/ti_skillmoves_square_nonactive.dds";
			GameGraphicForm.s_IconNames[191] = "data/ui/imgassets/tileicons/ti_squadranking_small_active.dds";
			GameGraphicForm.s_IconNames[192] = "data/ui/imgassets/tileicons/ti_squadranking_small_nonactive.dds";
			GameGraphicForm.s_IconNames[193] = "data/ui/imgassets/tileicons/ti_squadranks_small_active.dds";
			GameGraphicForm.s_IconNames[194] = "data/ui/imgassets/tileicons/ti_squadranks_small_nonactive.dds";
			GameGraphicForm.s_IconNames[195] = "data/ui/imgassets/tileicons/ti_squadreport_small_active.dds";
			GameGraphicForm.s_IconNames[196] = "data/ui/imgassets/tileicons/ti_squadreport_small_nonactive.dds";
			GameGraphicForm.s_IconNames[197] = "data/ui/imgassets/tileicons/ti_stadiums_square_active.dds";
			GameGraphicForm.s_IconNames[198] = "data/ui/imgassets/tileicons/ti_stadiums_square_nonactive.dds";
			GameGraphicForm.s_IconNames[199] = "data/ui/imgassets/tileicons/ti_teamsheets_smallw_active.dds";
			GameGraphicForm.s_IconNames[200] = "data/ui/imgassets/tileicons/ti_teamsheets_smallw_nonactive.dds";
			GameGraphicForm.s_IconNames[201] = "data/ui/imgassets/tileicons/ti_teamsheets_small_active.dds";
			GameGraphicForm.s_IconNames[202] = "data/ui/imgassets/tileicons/ti_teamsheets_small_nonactive.dds";
			GameGraphicForm.s_IconNames[203] = "data/ui/imgassets/tileicons/ti_teamsheets_square_active.dds";
			GameGraphicForm.s_IconNames[204] = "data/ui/imgassets/tileicons/ti_teamsheets_square_nonactive.dds";
			GameGraphicForm.s_IconNames[205] = "data/ui/imgassets/tileicons/ti_teamstats_small_active.dds";
			GameGraphicForm.s_IconNames[206] = "data/ui/imgassets/tileicons/ti_teamstats_small_nonactive.dds";
			GameGraphicForm.s_IconNames[207] = "data/ui/imgassets/tileicons/ti_topscorers_medtall_active.dds";
			GameGraphicForm.s_IconNames[208] = "data/ui/imgassets/tileicons/ti_topscorers_medtall_nonactive.dds";
			GameGraphicForm.s_IconNames[209] = "data/ui/imgassets/tileicons/ti_trainer_small_active.dds";
			GameGraphicForm.s_IconNames[210] = "data/ui/imgassets/tileicons/ti_trainer_small_nonactive.dds";
			GameGraphicForm.s_IconNames[211] = "data/ui/imgassets/tileicons/ti_videocalibration_square_active.dds";
			GameGraphicForm.s_IconNames[212] = "data/ui/imgassets/tileicons/ti_videocalibration_square_nonactive.dds";
			GameGraphicForm.s_IconNames[213] = "data/ui/imgassets/tileicons/ti_voicerecognitionhelp_square_active.dds";
			GameGraphicForm.s_IconNames[214] = "data/ui/imgassets/tileicons/ti_voicerecognitionhelp_square_nonactive.dds";
			GameGraphicForm.s_IconNames[215] = "data/ui/imgassets/tileicons/ti_xboxonehelp_small_active.dds";
			GameGraphicForm.s_IconNames[216] = "data/ui/imgassets/tileicons/ti_xboxonehelp_small_nonactive.dds";
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006E38 File Offset: 0x00005038
		private void LoadGameGraphics()
		{
			Cursor.Current = Cursors.WaitCursor;
			this.viewer2DMessi.CurrentBitmap = FifaEnvironment.GetArtasset("data/ui/game/screens/bootflow/pressstart.big", "2");
			this.viewer2DFifa.CurrentBitmap = FifaEnvironment.GetArtasset("data/ui/game/screens/bootflow/pressstart.big", "5");
			for (int i = 0; i < GameGraphicForm.s_FileNames.Length; i++)
			{
				GameGraphicForm.s_MenuBitmaps[i] = FifaEnvironment.GetDdsArtasset(GameGraphicForm.s_FileNames[i]);
			}
			this.multiViewerMenuPictures.Bitmaps = GameGraphicForm.s_MenuBitmaps;
			this.LoadIcon(0);
			Cursor.Current = Cursors.Default;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006ECC File Offset: 0x000050CC
		private bool SaveBitmapMenu(object sender)
		{
			Bitmap bitmap = (Bitmap)this.multiViewerMenuPictures.pictureBox.BackgroundImage;
			int num = (int)this.multiViewerMenuPictures.numeric.Value - 1;
			return FifaEnvironment.SetDdsArtasset(GameGraphicForm.s_TemplateNames[num], GameGraphicForm.s_FileNames[num], bitmap);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006F1C File Offset: 0x0000511C
		private bool DeleteBitmapMenu(object sender)
		{
			int num = (int)this.multiViewerMenuPictures.numeric.Value - 1;
			return FifaEnvironment.DeleteFromZdata(GameGraphicForm.s_FileNames[num]);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006F50 File Offset: 0x00005150
		private void buttonSaveStartGraphics_Click(object sender, EventArgs e)
		{
			FifaEnvironment.SetArtasset("data/ui/game/screens/bootflow/pressstart#.big", new string[] { "2", "5" }, "data/ui/game/screens/bootflow/pressstart.big", new Bitmap[]
			{
				this.viewer2DMessi.CurrentBitmap,
				this.viewer2DFifa.CurrentBitmap
			});
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006FAC File Offset: 0x000051AC
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			int num = (int)this.numericIcons.Value;
			this.LoadIcon(num);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006FD1 File Offset: 0x000051D1
		private void LoadIcon(int ix)
		{
			this.viewer2DIcons.CurrentBitmap = FifaEnvironment.GetDdsArtasset(GameGraphicForm.s_IconNames[ix]);
			this.labelTextIcons.Text = Path.GetFileName(GameGraphicForm.s_IconNames[ix]);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007004 File Offset: 0x00005204
		private bool ImportIcon(object sender, Bitmap bitmap)
		{
			int num = (int)this.numericIcons.Value;
			Bitmap bitmap2 = GraphicUtil.CanvasSizeBitmap(bitmap, 260, 260);
			return FifaEnvironment.SetDdsArtasset("data/ui/imgassets/tileicons/ti_#.dds", GameGraphicForm.s_IconNames[num], bitmap2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007048 File Offset: 0x00005248
		private bool DeleteIcon(object sender)
		{
			int num = (int)this.numericIcons.Value;
			return FifaEnvironment.DeleteFromZdata(GameGraphicForm.s_IconNames[num]);
		}

		// Token: 0x0400004F RID: 79
		public GameGraphicForm.BitmapUpdateHandler BitmapUpdateDelegate;

		// Token: 0x04000050 RID: 80
		private static string[] s_FileNames = new string[43];

		// Token: 0x04000051 RID: 81
		private static string[] s_TemplateNames = new string[43];

		// Token: 0x04000052 RID: 82
		private static string[] s_IconNames = new string[217];

		// Token: 0x04000053 RID: 83
		private static Bitmap[] s_MenuBitmaps = new Bitmap[43];

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x060005F3 RID: 1523
		public delegate bool BitmapUpdateHandler(object sender);
	}
}
