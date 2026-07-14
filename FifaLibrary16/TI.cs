using System;

namespace FifaLibrary
{
	// Token: 0x02000031 RID: 49
	public class TI
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0000E620 File Offset: 0x0000C820
		public static bool InitTI(DbFile fifaDbFile)
		{
			bool flag = true;
			TI.BigAttendance = fifaDbFile.GetTableIndex(TI.t_BigAttendance);
			TI.MatchIntensity = fifaDbFile.GetTableIndex(TI.t_MatchIntensity);
			TI.NoAttendance = fifaDbFile.GetTableIndex(TI.t_NoAttendance);
			TI.assetcryptokeys = fifaDbFile.GetTableIndex(TI.t_assetcryptokeys);
			TI.attributeprefpositionformula = fifaDbFile.GetTableIndex(TI.t_attributeprefpositionformula);
			TI.audionation = fifaDbFile.GetTableIndex(TI.t_audionation);
			TI.audiostadium = fifaDbFile.GetTableIndex(TI.t_audiostadium);
			TI.career_blacklist = fifaDbFile.GetTableIndex(TI.t_career_blacklist);
			TI.career_boardoutcomes = fifaDbFile.GetTableIndex(TI.t_career_boardoutcomes);
			TI.career_calendar = fifaDbFile.GetTableIndex(TI.t_career_calendar);
			TI.career_clinchedobjectives = fifaDbFile.GetTableIndex(TI.t_career_clinchedobjectives);
			TI.career_commonnames = fifaDbFile.GetTableIndex(TI.t_career_commonnames);
			TI.career_competitionprogress = fifaDbFile.GetTableIndex(TI.t_career_competitionprogress);
			TI.career_firstnames = fifaDbFile.GetTableIndex(TI.t_career_firstnames);
			TI.career_growthcurveinfo = fifaDbFile.GetTableIndex(TI.t_career_growthcurveinfo);
			TI.career_lastnames = fifaDbFile.GetTableIndex(TI.t_career_lastnames);
			TI.career_leagueballs = fifaDbFile.GetTableIndex(TI.t_career_leagueballs);
			TI.career_loanbuy = fifaDbFile.GetTableIndex(TI.t_career_loanbuy);
			TI.career_managerawards = fifaDbFile.GetTableIndex(TI.t_career_managerawards);
			TI.career_managerhistory = fifaDbFile.GetTableIndex(TI.t_career_managerhistory);
			TI.career_managerinfo = fifaDbFile.GetTableIndex(TI.t_career_managerinfo);
			TI.career_managerpref = fifaDbFile.GetTableIndex(TI.t_career_managerpref);
			TI.career_namesgroups = fifaDbFile.GetTableIndex(TI.t_career_namesgroups);
			TI.career_news = fifaDbFile.GetTableIndex(TI.t_career_news);
			TI.career_newsban = fifaDbFile.GetTableIndex(TI.t_career_newsban);
			TI.career_newspicweights = fifaDbFile.GetTableIndex(TI.t_career_newspicweights);
			TI.career_playasplayer = fifaDbFile.GetTableIndex(TI.t_career_playasplayer);
			TI.career_playasplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_playasplayerhistory);
			TI.career_playerawards = fifaDbFile.GetTableIndex(TI.t_career_playerawards);
			TI.career_playerbonusper = fifaDbFile.GetTableIndex(TI.t_career_playerbonusper);
			TI.career_playercontract = fifaDbFile.GetTableIndex(TI.t_career_playercontract);
			TI.career_playergrowthhistory = fifaDbFile.GetTableIndex(TI.t_career_playergrowthhistory);
			TI.career_playergrowthupdates = fifaDbFile.GetTableIndex(TI.t_career_playergrowthupdates);
			TI.career_playergrowthuserseason = fifaDbFile.GetTableIndex(TI.t_career_playergrowthuserseason);
			TI.career_playermatchratinghistory = fifaDbFile.GetTableIndex(TI.t_career_playermatchratinghistory);
			TI.career_precontract = fifaDbFile.GetTableIndex(TI.t_career_precontract);
			TI.career_regenplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_regenplayerattributes);
			TI.career_scoutmission = fifaDbFile.GetTableIndex(TI.t_career_scoutmission);
			TI.career_scouts = fifaDbFile.GetTableIndex(TI.t_career_scouts);
			TI.career_squadranking = fifaDbFile.GetTableIndex(TI.t_career_squadranking);
			TI.career_teamofweek = fifaDbFile.GetTableIndex(TI.t_career_teamofweek);
			TI.career_transferlist = fifaDbFile.GetTableIndex(TI.t_career_transferlist);
			TI.career_transferoffer = fifaDbFile.GetTableIndex(TI.t_career_transferoffer);
			TI.career_trophies = fifaDbFile.GetTableIndex(TI.t_career_trophies);
			TI.career_users = fifaDbFile.GetTableIndex(TI.t_career_users);
			TI.career_youthplayerattributes = fifaDbFile.GetTableIndex(TI.t_career_youthplayerattributes);
			TI.career_youthplayerhistory = fifaDbFile.GetTableIndex(TI.t_career_youthplayerhistory);
			TI.career_youthplayers = fifaDbFile.GetTableIndex(TI.t_career_youthplayers);
			TI.celebrations = fifaDbFile.GetTableIndex(TI.t_celebrations);
			TI.clubcommentarynames = fifaDbFile.GetTableIndex(TI.t_clubcommentarynames);
			TI.cmeventhistory = fifaDbFile.GetTableIndex(TI.t_cmeventhistory);
			TI.cmteameventhistory = fifaDbFile.GetTableIndex(TI.t_cmteameventhistory);
			TI.commentarynames = fifaDbFile.GetTableIndex(TI.t_commentarynames);
			TI.competition = fifaDbFile.GetTableIndex(TI.t_competition);
			TI.createplayer = fifaDbFile.GetTableIndex(TI.t_createplayer);
			TI.createplayerpositiontemplates = fifaDbFile.GetTableIndex(TI.t_createplayerpositiontemplates);
			TI.createplayerviews = fifaDbFile.GetTableIndex(TI.t_createplayerviews);
			TI.customformations = fifaDbFile.GetTableIndex(TI.t_customformations);
			TI.customteamstyles = fifaDbFile.GetTableIndex(TI.t_customteamstyles);
			TI.cz_assets = fifaDbFile.GetTableIndex(TI.t_cz_assets);
			TI.cz_leagues = fifaDbFile.GetTableIndex(TI.t_cz_leagues);
			TI.cz_players = fifaDbFile.GetTableIndex(TI.t_cz_players);
			TI.cz_teamkits = fifaDbFile.GetTableIndex(TI.t_cz_teamkits);
			TI.cz_teams = fifaDbFile.GetTableIndex(TI.t_cz_teams);
			TI.dcplayernames = fifaDbFile.GetTableIndex(TI.t_dcplayernames);
			TI.dlcballs = fifaDbFile.GetTableIndex(TI.t_dlcballs);
			TI.dlcboots = fifaDbFile.GetTableIndex(TI.t_dlcboots);
			TI.dna = fifaDbFile.GetTableIndex(TI.t_dna);
			TI.defaultteamdata = fifaDbFile.GetTableIndex(TI.t_defaultteamdata);
			TI.default_teamsheets = fifaDbFile.GetTableIndex(TI.t_default_teamsheets);
			TI.eatrax = fifaDbFile.GetTableIndex(TI.t_eatrax);
			TI.editedplayernames = fifaDbFile.GetTableIndex(TI.t_editedplayernames);
			TI.factory_teams = fifaDbFile.GetTableIndex(TI.t_factory_teams);
			TI.fieldpositionboundingboxes = fifaDbFile.GetTableIndex(TI.t_fieldpositionboundingboxes);
			TI.fifaGameSettings = fifaDbFile.GetTableIndex(TI.t_fifaGameSettings);
			TI.fixtures = fifaDbFile.GetTableIndex(TI.t_fixtures);
			TI.formations = fifaDbFile.GetTableIndex(TI.t_formations);
			TI.leaguerefereelinks = fifaDbFile.GetTableIndex(TI.t_leaguerefereelinks);
			TI.leagues = fifaDbFile.GetTableIndex(TI.t_leagues);
			TI.leagueteamlinks = fifaDbFile.GetTableIndex(TI.t_leagueteamlinks);
			TI.manager = fifaDbFile.GetTableIndex(TI.t_manager);
			TI.mls_fixtures = fifaDbFile.GetTableIndex(TI.t_mls_fixtures);
			TI.nations = fifaDbFile.GetTableIndex(TI.t_nations);
			TI.persistent_events = fifaDbFile.GetTableIndex(TI.t_persistent_events);
			TI.physio = fifaDbFile.GetTableIndex(TI.t_physio);
			TI.player_grudgelove = fifaDbFile.GetTableIndex(TI.t_player_grudgelove);
			TI.player_stats = fifaDbFile.GetTableIndex(TI.t_player_stats);
			TI.playerboots = fifaDbFile.GetTableIndex(TI.t_playerboots);
			TI.playerformdiff = fifaDbFile.GetTableIndex(TI.t_playerformdiff);
			TI.playerloans = fifaDbFile.GetTableIndex(TI.t_playerloans);
			TI.playernames = fifaDbFile.GetTableIndex(TI.t_playernames);
			TI.players = fifaDbFile.GetTableIndex(TI.t_players);
			TI.previousteam = fifaDbFile.GetTableIndex(TI.t_previousteam);
			TI.referee = fifaDbFile.GetTableIndex(TI.t_referee);
			TI.restrictedplayers = fifaDbFile.GetTableIndex(TI.t_restrictedplayers);
			TI.rivals = fifaDbFile.GetTableIndex(TI.t_rivals);
			TI.rowteamnationlinks = fifaDbFile.GetTableIndex(TI.t_rowteamnationlinks);
			TI.shoecolors = fifaDbFile.GetTableIndex(TI.t_shoecolors);
			TI.songplaylistlinks = fifaDbFile.GetTableIndex(TI.t_songplaylistlinks);
			TI.stadiumassignments = fifaDbFile.GetTableIndex(TI.t_stadiumassignments);
			TI.stadiums = fifaDbFile.GetTableIndex(TI.t_stadiums);
			TI.starratingboundaries = fifaDbFile.GetTableIndex(TI.t_starratingboundaries);
			TI.stories = fifaDbFile.GetTableIndex(TI.t_stories);
			TI.team_lookup = fifaDbFile.GetTableIndex(TI.t_team_lookup);
			TI.teamballs = fifaDbFile.GetTableIndex(TI.t_teamballs);
			TI.teamformationteamstylelinks = fifaDbFile.GetTableIndex(TI.t_teamformationteamstylelinks);
			TI.teamformdiff = fifaDbFile.GetTableIndex(TI.t_teamformdiff);
			TI.teamkits = fifaDbFile.GetTableIndex(TI.t_teamkits);
			TI.teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_teamplayerlinks);
			TI.teams = fifaDbFile.GetTableIndex(TI.t_teams);
			TI.teamstadiumlinks = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinks);
			TI.teamnationlinks = fifaDbFile.GetTableIndex(TI.t_teamnationlinks);
			TI.teamstadiumlinkscache = fifaDbFile.GetTableIndex(TI.t_teamstadiumlinkscache);
			TI.temp_arenacreateplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenacreateplayer);
			TI.temp_arenaplayer = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayer);
			TI.temp_arenaplayername = fifaDbFile.GetTableIndex(TI.t_temp_arenaplayername);
			TI.temp_arenateam = fifaDbFile.GetTableIndex(TI.t_temp_arenateam);
			TI.temp_arenateamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_arenateamplayerlinks);
			TI.temp_createplayer = fifaDbFile.GetTableIndex(TI.t_temp_createplayer);
			TI.temp_formations = fifaDbFile.GetTableIndex(TI.t_temp_formations);
			TI.temp_players = fifaDbFile.GetTableIndex(TI.t_temp_players);
			TI.temp_teamplayerlinks = fifaDbFile.GetTableIndex(TI.t_temp_teamplayerlinks);
			TI.temp_teams = fifaDbFile.GetTableIndex(TI.t_temp_teams);
			TI.trainingteamplayerlinks = fifaDbFile.GetTableIndex(TI.t_trainingteamplayerlinks);
			TI.trainingteamplayernames = fifaDbFile.GetTableIndex(TI.t_trainingteamplayernames);
			TI.trainingteamplayers = fifaDbFile.GetTableIndex(TI.t_trainingteamplayers);
			TI.transactionhistory = fifaDbFile.GetTableIndex(TI.t_transactionhistory);
			TI.version = fifaDbFile.GetTableIndex(TI.t_version);
			TI.videos = fifaDbFile.GetTableIndex(TI.t_videos);
			return flag;
		}

		// Token: 0x040000E2 RID: 226
		private static string t_balls = "balls";

		// Token: 0x040000E3 RID: 227
		private static string t_career_extraplayerinfo = "career_extraplayerinfo";

		// Token: 0x040000E4 RID: 228
		private static string t_career_matchexperience = "career_matchexperience";

		// Token: 0x040000E5 RID: 229
		private static string t_career_suspensions = "career_suspensions";

		// Token: 0x040000E6 RID: 230
		private static string t_career_youthplayersattributes = "career_youthplayerattributes";

		// Token: 0x040000E7 RID: 231
		private static string t_career_youthplayershistory = "career_youthplayerhistory";

		// Token: 0x040000E8 RID: 232
		private static string t_formupdate = "formupdate";

		// Token: 0x040000E9 RID: 233
		private static string t_career_fixtureinfo = "career_fixtureinfo";

		// Token: 0x040000EA RID: 234
		private static string t_fce_activeteams = "fce_activeteams";

		// Token: 0x040000EB RID: 235
		private static string t_fce_weathersettings = "fce_weathersettings";

		// Token: 0x040000EC RID: 236
		private static string t_fce_statistics = "fce_statistics";

		// Token: 0x040000ED RID: 237
		private static string t_fce_standings = "fce_standings";

		// Token: 0x040000EE RID: 238
		private static string t_fce_stageadvance = "fce_stageadvance";

		// Token: 0x040000EF RID: 239
		private static string t_fce_settings = "fce_settings";

		// Token: 0x040000F0 RID: 240
		private static string t_fce_scriptfunctions = "fce_scriptfunctions";

		// Token: 0x040000F1 RID: 241
		private static string t_fce_scheduleinfo = "fce_scheduleinfo";

		// Token: 0x040000F2 RID: 242
		private static string t_fce_fixtures = "fce_fixtures";

		// Token: 0x040000F3 RID: 243
		private static string t_fce_competitionteams = "fce_competitionteams";

		// Token: 0x040000F4 RID: 244
		private static string t_fce_competitioninfo = "fce_competitioninfo";

		// Token: 0x040000F5 RID: 245
		private static string t_fce_compavgs = "fce_compavgs";

		// Token: 0x040000F6 RID: 246
		private static string t_fce_advancement = "fce_advancement";

		// Token: 0x040000F7 RID: 247
		private static string t_player_growth_experience_points = "player_growth_experience_points";

		// Token: 0x040000F8 RID: 248
		private static string t_player_career = "player_career";

		// Token: 0x040000F9 RID: 249
		private static string t_experiencepoints = "experiencepoints";

		// Token: 0x040000FA RID: 250
		private static string t_finalstadiums = "finalstadiums";

		// Token: 0x040000FB RID: 251
		private static string t_tourn_team_manager = "tourn_team_manager";

		// Token: 0x040000FC RID: 252
		private static string t_tourn_settings = "tourn_settings";

		// Token: 0x040000FD RID: 253
		private static string t_tourn_rtsg = "tourn_rtsg";

		// Token: 0x040000FE RID: 254
		private static string t_tourn_manager_settings = "tourn_manager_settings";

		// Token: 0x040000FF RID: 255
		private static string t_tourn_licensed_stages = "tourn_licensed_stages";

		// Token: 0x04000100 RID: 256
		private static string t_tourn_licensed = "tourn_licensed";

		// Token: 0x04000101 RID: 257
		private static string t_specialteams = "specialteams";

		// Token: 0x04000102 RID: 258
		private static string t_achievements = "achievements";

		// Token: 0x04000103 RID: 259
		private static string t_fifaUnlockables = "fifaUnlockables";

		// Token: 0x04000104 RID: 260
		private static string t_usability = "usability";

		// Token: 0x04000105 RID: 261
		private static string t_usability_functions = "usability_functions";

		// Token: 0x04000106 RID: 262
		private static string t_virtualleagues = "virtualleagues";

		// Token: 0x04000107 RID: 263
		private static string t_BigAttendance = "BigAttendance";

		// Token: 0x04000108 RID: 264
		private static string t_MatchIntensity = "MatchIntensity";

		// Token: 0x04000109 RID: 265
		private static string t_NoAttendance = "NoAttendance";

		// Token: 0x0400010A RID: 266
		private static string t_assetcryptokeys = "assetcryptokeys";

		// Token: 0x0400010B RID: 267
		private static string t_attributeprefpositionformula = "attributeprefpositionformula";

		// Token: 0x0400010C RID: 268
		private static string t_audionation = "audionation";

		// Token: 0x0400010D RID: 269
		private static string t_audiostadium = "audiostadium";

		// Token: 0x0400010E RID: 270
		private static string t_career_blacklist = "career_blacklist";

		// Token: 0x0400010F RID: 271
		private static string t_career_boardoutcomes = "career_boardoutcomes";

		// Token: 0x04000110 RID: 272
		private static string t_career_calendar = "career_calendar";

		// Token: 0x04000111 RID: 273
		private static string t_career_clinchedobjectives = "career_clinchedobjectives";

		// Token: 0x04000112 RID: 274
		private static string t_career_commonnames = "career_commonnames";

		// Token: 0x04000113 RID: 275
		private static string t_career_competitionprogress = "career_competitionprogress";

		// Token: 0x04000114 RID: 276
		private static string t_career_firstnames = "career_firstnames";

		// Token: 0x04000115 RID: 277
		private static string t_career_growthcurveinfo = "career_growthcurveinfo";

		// Token: 0x04000116 RID: 278
		private static string t_career_lastnames = "career_lastnames";

		// Token: 0x04000117 RID: 279
		private static string t_career_leagueballs = "career_leagueballs";

		// Token: 0x04000118 RID: 280
		private static string t_career_loanbuy = "career_loanbuy";

		// Token: 0x04000119 RID: 281
		private static string t_career_managerawards = "career_managerawards";

		// Token: 0x0400011A RID: 282
		private static string t_career_managerhistory = "career_managerhistory";

		// Token: 0x0400011B RID: 283
		private static string t_career_managerinfo = "career_managerinfo";

		// Token: 0x0400011C RID: 284
		private static string t_career_managerpref = "career_managerpref";

		// Token: 0x0400011D RID: 285
		private static string t_career_namesgroups = "career_namesgroups";

		// Token: 0x0400011E RID: 286
		private static string t_career_news = "career_news";

		// Token: 0x0400011F RID: 287
		private static string t_career_newsban = "career_newsban";

		// Token: 0x04000120 RID: 288
		private static string t_career_newspicweights = "career_newspicweights";

		// Token: 0x04000121 RID: 289
		private static string t_career_playasplayer = "career_playasplayer";

		// Token: 0x04000122 RID: 290
		private static string t_career_playasplayerhistory = "career_playasplayerhistory";

		// Token: 0x04000123 RID: 291
		private static string t_career_playerawards = "career_playerawards";

		// Token: 0x04000124 RID: 292
		private static string t_career_playerbonusper = "career_playerbonusper";

		// Token: 0x04000125 RID: 293
		private static string t_career_playercontract = "career_playercontract";

		// Token: 0x04000126 RID: 294
		private static string t_career_playergrowthhistory = "career_playergrowthhistory";

		// Token: 0x04000127 RID: 295
		private static string t_career_playergrowthupdates = "career_playergrowthupdates";

		// Token: 0x04000128 RID: 296
		private static string t_career_playergrowthuserseason = "career_playergrowthuserseason";

		// Token: 0x04000129 RID: 297
		private static string t_career_playermatchratinghistory = "career_playermatchratinghistory";

		// Token: 0x0400012A RID: 298
		private static string t_career_precontract = "career_precontract";

		// Token: 0x0400012B RID: 299
		private static string t_career_regenplayerattributes = "career_regenplayerattributes";

		// Token: 0x0400012C RID: 300
		private static string t_career_scoutmission = "career_scoutmission";

		// Token: 0x0400012D RID: 301
		private static string t_career_scouts = "career_scouts";

		// Token: 0x0400012E RID: 302
		private static string t_career_squadranking = "career_squadranking";

		// Token: 0x0400012F RID: 303
		private static string t_career_teamofweek = "career_teamofweek";

		// Token: 0x04000130 RID: 304
		private static string t_career_transferlist = "career_transferlist";

		// Token: 0x04000131 RID: 305
		private static string t_career_transferoffer = "career_transferoffer";

		// Token: 0x04000132 RID: 306
		private static string t_career_trophies = "career_trophies";

		// Token: 0x04000133 RID: 307
		private static string t_career_users = "career_users";

		// Token: 0x04000134 RID: 308
		private static string t_career_youthplayerattributes = "career_youthplayerattributes";

		// Token: 0x04000135 RID: 309
		private static string t_career_youthplayerhistory = "career_youthplayerhistory";

		// Token: 0x04000136 RID: 310
		private static string t_career_youthplayers = "career_youthplayers";

		// Token: 0x04000137 RID: 311
		private static string t_celebrations = "celebrations";

		// Token: 0x04000138 RID: 312
		private static string t_clubcommentarynames = "clubcommentarynames";

		// Token: 0x04000139 RID: 313
		private static string t_cmeventhistory = "cmeventhistory";

		// Token: 0x0400013A RID: 314
		private static string t_cmteameventhistory = "cmteameventhistory";

		// Token: 0x0400013B RID: 315
		private static string t_commentarynames = "commentarynames";

		// Token: 0x0400013C RID: 316
		private static string t_competition = "competition";

		// Token: 0x0400013D RID: 317
		private static string t_createplayer = "createplayer";

		// Token: 0x0400013E RID: 318
		private static string t_createplayerpositiontemplates = "createplayerpositiontemplates";

		// Token: 0x0400013F RID: 319
		private static string t_createplayerviews = "createplayerviews";

		// Token: 0x04000140 RID: 320
		private static string t_customformations = "customformations";

		// Token: 0x04000141 RID: 321
		private static string t_customteamstyles = "customteamstyles";

		// Token: 0x04000142 RID: 322
		private static string t_cz_assets = "cz_assets";

		// Token: 0x04000143 RID: 323
		private static string t_cz_leagues = "cz_leagues";

		// Token: 0x04000144 RID: 324
		private static string t_cz_players = "cz_players";

		// Token: 0x04000145 RID: 325
		private static string t_cz_teamkits = "cz_teamkits";

		// Token: 0x04000146 RID: 326
		private static string t_cz_teams = "cz_teams";

		// Token: 0x04000147 RID: 327
		private static string t_dcplayernames = "dcplayernames";

		// Token: 0x04000148 RID: 328
		private static string t_dlcballs = "dlcballs";

		// Token: 0x04000149 RID: 329
		private static string t_dlcboots = "dlcboots";

		// Token: 0x0400014A RID: 330
		private static string t_dna = "dna";

		// Token: 0x0400014B RID: 331
		private static string t_defaultteamdata = "defaultteamdata";

		// Token: 0x0400014C RID: 332
		private static string t_default_teamsheets = "default_teamsheets";

		// Token: 0x0400014D RID: 333
		private static string t_eatrax = "eatrax";

		// Token: 0x0400014E RID: 334
		private static string t_editedplayernames = "editedplayernames";

		// Token: 0x0400014F RID: 335
		private static string t_factory_teams = "factory_teams";

		// Token: 0x04000150 RID: 336
		private static string t_fieldpositionboundingboxes = "fieldpositionboundingboxes";

		// Token: 0x04000151 RID: 337
		private static string t_fifaGameSettings = "fifaGameSettings";

		// Token: 0x04000152 RID: 338
		private static string t_fixtures = "fixtures";

		// Token: 0x04000153 RID: 339
		private static string t_formations = "formations";

		// Token: 0x04000154 RID: 340
		private static string t_leaguerefereelinks = "leaguerefereelinks";

		// Token: 0x04000155 RID: 341
		private static string t_leagues = "leagues";

		// Token: 0x04000156 RID: 342
		private static string t_leagueteamlinks = "leagueteamlinks";

		// Token: 0x04000157 RID: 343
		private static string t_manager = "manager";

		// Token: 0x04000158 RID: 344
		private static string t_mls_fixtures = "mls_fixtures";

		// Token: 0x04000159 RID: 345
		private static string t_nations = "nations";

		// Token: 0x0400015A RID: 346
		private static string t_persistent_events = "persistent_events";

		// Token: 0x0400015B RID: 347
		private static string t_physio = "physio";

		// Token: 0x0400015C RID: 348
		private static string t_player_grudgelove = "player_grudgelove";

		// Token: 0x0400015D RID: 349
		private static string t_player_stats = "player_stats";

		// Token: 0x0400015E RID: 350
		private static string t_playerboots = "playerboots";

		// Token: 0x0400015F RID: 351
		private static string t_playerformdiff = "playerformdiff";

		// Token: 0x04000160 RID: 352
		private static string t_playerloans = "playerloans";

		// Token: 0x04000161 RID: 353
		private static string t_playernames = "playernames";

		// Token: 0x04000162 RID: 354
		private static string t_players = "players";

		// Token: 0x04000163 RID: 355
		private static string t_previousteam = "previousteam";

		// Token: 0x04000164 RID: 356
		private static string t_referee = "referee";

		// Token: 0x04000165 RID: 357
		private static string t_restrictedplayers = "restrictedplayers";

		// Token: 0x04000166 RID: 358
		private static string t_rivals = "rivals";

		// Token: 0x04000167 RID: 359
		private static string t_rowteamnationlinks = "rowteamnationlinks";

		// Token: 0x04000168 RID: 360
		private static string t_shoecolors = "shoecolors";

		// Token: 0x04000169 RID: 361
		private static string t_songplaylistlinks = "songplaylistlinks";

		// Token: 0x0400016A RID: 362
		private static string t_stadiumassignments = "stadiumassignments";

		// Token: 0x0400016B RID: 363
		private static string t_stadiums = "stadiums";

		// Token: 0x0400016C RID: 364
		private static string t_starratingboundaries = "starratingboundaries";

		// Token: 0x0400016D RID: 365
		private static string t_stories = "stories";

		// Token: 0x0400016E RID: 366
		private static string t_team_lookup = "team_lookup";

		// Token: 0x0400016F RID: 367
		private static string t_teamballs = "teamballs";

		// Token: 0x04000170 RID: 368
		private static string t_teamformationteamstylelinks = "teamformationteamstylelinks";

		// Token: 0x04000171 RID: 369
		private static string t_teamformdiff = "teamformdiff";

		// Token: 0x04000172 RID: 370
		private static string t_teamkits = "teamkits";

		// Token: 0x04000173 RID: 371
		private static string t_teamplayerlinks = "teamplayerlinks";

		// Token: 0x04000174 RID: 372
		private static string t_teams = "teams";

		// Token: 0x04000175 RID: 373
		private static string t_teamstadiumlinks = "teamstadiumlinks";

		// Token: 0x04000176 RID: 374
		private static string t_teamnationlinks = "teamnationlinks";

		// Token: 0x04000177 RID: 375
		private static string t_teamstadiumlinkscache = "teamstadiumlinkscache";

		// Token: 0x04000178 RID: 376
		private static string t_temp_arenacreateplayer = "temp_arenacreateplayer";

		// Token: 0x04000179 RID: 377
		private static string t_temp_arenaplayer = "temp_arenaplayer";

		// Token: 0x0400017A RID: 378
		private static string t_temp_arenaplayername = "temp_arenaplayername";

		// Token: 0x0400017B RID: 379
		private static string t_temp_arenateam = "temp_arenateam";

		// Token: 0x0400017C RID: 380
		private static string t_temp_arenateamplayerlinks = "temp_arenateamplayerlinks";

		// Token: 0x0400017D RID: 381
		private static string t_temp_createplayer = "temp_createplayer";

		// Token: 0x0400017E RID: 382
		private static string t_temp_formations = "temp_formations";

		// Token: 0x0400017F RID: 383
		private static string t_temp_players = "temp_players";

		// Token: 0x04000180 RID: 384
		private static string t_temp_teamplayerlinks = "temp_teamplayerlinks";

		// Token: 0x04000181 RID: 385
		private static string t_temp_teams = "temp_teams";

		// Token: 0x04000182 RID: 386
		private static string t_trainingteamplayerlinks = "trainingteamplayerlinks";

		// Token: 0x04000183 RID: 387
		private static string t_trainingteamplayernames = "trainingteamplayernames";

		// Token: 0x04000184 RID: 388
		private static string t_trainingteamplayers = "trainingteamplayers";

		// Token: 0x04000185 RID: 389
		private static string t_transactionhistory = "transactionhistory";

		// Token: 0x04000186 RID: 390
		private static string t_version = "version";

		// Token: 0x04000187 RID: 391
		private static string t_videos = "videos";

		// Token: 0x04000188 RID: 392
		public static int lang = 0;

		// Token: 0x04000189 RID: 393
		public static int balls;

		// Token: 0x0400018A RID: 394
		public static int career_extraplayerinfo;

		// Token: 0x0400018B RID: 395
		public static int career_matchexperience;

		// Token: 0x0400018C RID: 396
		public static int career_suspensions;

		// Token: 0x0400018D RID: 397
		public static int formupdate;

		// Token: 0x0400018E RID: 398
		public static int career_fixtureinfo;

		// Token: 0x0400018F RID: 399
		public static int fce_activeteams;

		// Token: 0x04000190 RID: 400
		public static int fce_weathersettings;

		// Token: 0x04000191 RID: 401
		public static int fce_statistics;

		// Token: 0x04000192 RID: 402
		public static int fce_standings;

		// Token: 0x04000193 RID: 403
		public static int fce_stageadvance;

		// Token: 0x04000194 RID: 404
		public static int fce_settings;

		// Token: 0x04000195 RID: 405
		public static int fce_scriptfunctions;

		// Token: 0x04000196 RID: 406
		public static int fce_scheduleinfo;

		// Token: 0x04000197 RID: 407
		public static int fce_fixtures;

		// Token: 0x04000198 RID: 408
		public static int fce_competitionteams;

		// Token: 0x04000199 RID: 409
		public static int fce_competitioninfo;

		// Token: 0x0400019A RID: 410
		public static int fce_compavgs;

		// Token: 0x0400019B RID: 411
		public static int fce_advancement;

		// Token: 0x0400019C RID: 412
		public static int player_growth_experience_points;

		// Token: 0x0400019D RID: 413
		public static int player_career;

		// Token: 0x0400019E RID: 414
		public static int experiencepoints;

		// Token: 0x0400019F RID: 415
		public static int finalstadiums;

		// Token: 0x040001A0 RID: 416
		public static int tourn_team_manager;

		// Token: 0x040001A1 RID: 417
		public static int tourn_settings;

		// Token: 0x040001A2 RID: 418
		public static int tourn_rtsg;

		// Token: 0x040001A3 RID: 419
		public static int tourn_manager_settings;

		// Token: 0x040001A4 RID: 420
		public static int tourn_licensed_stages;

		// Token: 0x040001A5 RID: 421
		public static int tourn_licensed;

		// Token: 0x040001A6 RID: 422
		public static int specialteams;

		// Token: 0x040001A7 RID: 423
		public static int achievements;

		// Token: 0x040001A8 RID: 424
		public static int fifaUnlockables;

		// Token: 0x040001A9 RID: 425
		public static int usability;

		// Token: 0x040001AA RID: 426
		public static int usability_functions;

		// Token: 0x040001AB RID: 427
		public static int virtualleagues;

		// Token: 0x040001AC RID: 428
		public static int BigAttendance;

		// Token: 0x040001AD RID: 429
		public static int MatchIntensity;

		// Token: 0x040001AE RID: 430
		public static int NoAttendance;

		// Token: 0x040001AF RID: 431
		public static int assetcryptokeys;

		// Token: 0x040001B0 RID: 432
		public static int attributeprefpositionformula;

		// Token: 0x040001B1 RID: 433
		public static int audionation;

		// Token: 0x040001B2 RID: 434
		public static int audiostadium;

		// Token: 0x040001B3 RID: 435
		public static int career_blacklist;

		// Token: 0x040001B4 RID: 436
		public static int career_boardoutcomes;

		// Token: 0x040001B5 RID: 437
		public static int career_calendar;

		// Token: 0x040001B6 RID: 438
		public static int career_clinchedobjectives;

		// Token: 0x040001B7 RID: 439
		public static int career_commonnames;

		// Token: 0x040001B8 RID: 440
		public static int career_competitionprogress;

		// Token: 0x040001B9 RID: 441
		public static int career_firstnames;

		// Token: 0x040001BA RID: 442
		public static int career_growthcurveinfo;

		// Token: 0x040001BB RID: 443
		public static int career_lastnames;

		// Token: 0x040001BC RID: 444
		public static int career_leagueballs;

		// Token: 0x040001BD RID: 445
		public static int career_loanbuy;

		// Token: 0x040001BE RID: 446
		public static int career_managerawards;

		// Token: 0x040001BF RID: 447
		public static int career_managerhistory;

		// Token: 0x040001C0 RID: 448
		public static int career_managerinfo;

		// Token: 0x040001C1 RID: 449
		public static int career_managerpref;

		// Token: 0x040001C2 RID: 450
		public static int career_namesgroups;

		// Token: 0x040001C3 RID: 451
		public static int career_news;

		// Token: 0x040001C4 RID: 452
		public static int career_newsban;

		// Token: 0x040001C5 RID: 453
		public static int career_newspicweights;

		// Token: 0x040001C6 RID: 454
		public static int career_playasplayer;

		// Token: 0x040001C7 RID: 455
		public static int career_playasplayerhistory;

		// Token: 0x040001C8 RID: 456
		public static int career_playerawards;

		// Token: 0x040001C9 RID: 457
		public static int career_playerbonusper;

		// Token: 0x040001CA RID: 458
		public static int career_playercontract;

		// Token: 0x040001CB RID: 459
		public static int career_playergrowthhistory;

		// Token: 0x040001CC RID: 460
		public static int career_playergrowthupdates;

		// Token: 0x040001CD RID: 461
		public static int career_playergrowthuserseason;

		// Token: 0x040001CE RID: 462
		public static int career_playermatchratinghistory;

		// Token: 0x040001CF RID: 463
		public static int career_precontract;

		// Token: 0x040001D0 RID: 464
		public static int career_regenplayerattributes;

		// Token: 0x040001D1 RID: 465
		public static int career_scoutmission;

		// Token: 0x040001D2 RID: 466
		public static int career_scouts;

		// Token: 0x040001D3 RID: 467
		public static int career_squadranking;

		// Token: 0x040001D4 RID: 468
		public static int career_teamofweek;

		// Token: 0x040001D5 RID: 469
		public static int career_transferlist;

		// Token: 0x040001D6 RID: 470
		public static int career_transferoffer;

		// Token: 0x040001D7 RID: 471
		public static int career_trophies;

		// Token: 0x040001D8 RID: 472
		public static int career_users;

		// Token: 0x040001D9 RID: 473
		public static int career_youthplayerattributes;

		// Token: 0x040001DA RID: 474
		public static int career_youthplayerhistory;

		// Token: 0x040001DB RID: 475
		public static int career_youthplayers;

		// Token: 0x040001DC RID: 476
		public static int celebrations;

		// Token: 0x040001DD RID: 477
		public static int clubcommentarynames;

		// Token: 0x040001DE RID: 478
		public static int cmeventhistory;

		// Token: 0x040001DF RID: 479
		public static int cmteameventhistory;

		// Token: 0x040001E0 RID: 480
		public static int commentarynames;

		// Token: 0x040001E1 RID: 481
		public static int competition;

		// Token: 0x040001E2 RID: 482
		public static int createplayer;

		// Token: 0x040001E3 RID: 483
		public static int createplayerpositiontemplates;

		// Token: 0x040001E4 RID: 484
		public static int createplayerviews;

		// Token: 0x040001E5 RID: 485
		public static int customformations;

		// Token: 0x040001E6 RID: 486
		public static int customteamstyles;

		// Token: 0x040001E7 RID: 487
		public static int cz_assets;

		// Token: 0x040001E8 RID: 488
		public static int cz_leagues;

		// Token: 0x040001E9 RID: 489
		public static int cz_players;

		// Token: 0x040001EA RID: 490
		public static int cz_teamkits;

		// Token: 0x040001EB RID: 491
		public static int cz_teams;

		// Token: 0x040001EC RID: 492
		public static int dcplayernames;

		// Token: 0x040001ED RID: 493
		public static int dlcballs;

		// Token: 0x040001EE RID: 494
		public static int dlcboots;

		// Token: 0x040001EF RID: 495
		public static int dna;

		// Token: 0x040001F0 RID: 496
		public static int eatrax;

		// Token: 0x040001F1 RID: 497
		public static int editedplayernames;

		// Token: 0x040001F2 RID: 498
		public static int factory_teams;

		// Token: 0x040001F3 RID: 499
		public static int fieldpositionboundingboxes;

		// Token: 0x040001F4 RID: 500
		public static int fifaGameSettings;

		// Token: 0x040001F5 RID: 501
		public static int fixtures;

		// Token: 0x040001F6 RID: 502
		public static int formations;

		// Token: 0x040001F7 RID: 503
		public static int leaguerefereelinks;

		// Token: 0x040001F8 RID: 504
		public static int leagues;

		// Token: 0x040001F9 RID: 505
		public static int leagueteamlinks;

		// Token: 0x040001FA RID: 506
		public static int manager;

		// Token: 0x040001FB RID: 507
		public static int mls_fixtures;

		// Token: 0x040001FC RID: 508
		public static int nations;

		// Token: 0x040001FD RID: 509
		public static int persistent_events;

		// Token: 0x040001FE RID: 510
		public static int physio;

		// Token: 0x040001FF RID: 511
		public static int player_grudgelove;

		// Token: 0x04000200 RID: 512
		public static int player_stats;

		// Token: 0x04000201 RID: 513
		public static int playerboots;

		// Token: 0x04000202 RID: 514
		public static int playerformdiff;

		// Token: 0x04000203 RID: 515
		public static int playerloans;

		// Token: 0x04000204 RID: 516
		public static int playernames;

		// Token: 0x04000205 RID: 517
		public static int players;

		// Token: 0x04000206 RID: 518
		public static int previousteam;

		// Token: 0x04000207 RID: 519
		public static int referee;

		// Token: 0x04000208 RID: 520
		public static int restrictedplayers;

		// Token: 0x04000209 RID: 521
		public static int rivals;

		// Token: 0x0400020A RID: 522
		public static int rowteamnationlinks;

		// Token: 0x0400020B RID: 523
		public static int shoecolors;

		// Token: 0x0400020C RID: 524
		public static int songplaylistlinks;

		// Token: 0x0400020D RID: 525
		public static int stadiumassignments;

		// Token: 0x0400020E RID: 526
		public static int stadiums;

		// Token: 0x0400020F RID: 527
		public static int starratingboundaries;

		// Token: 0x04000210 RID: 528
		public static int stories;

		// Token: 0x04000211 RID: 529
		public static int team_lookup;

		// Token: 0x04000212 RID: 530
		public static int teamballs;

		// Token: 0x04000213 RID: 531
		public static int teamformationteamstylelinks;

		// Token: 0x04000214 RID: 532
		public static int teamformdiff;

		// Token: 0x04000215 RID: 533
		public static int teamkits;

		// Token: 0x04000216 RID: 534
		public static int teamplayerlinks;

		// Token: 0x04000217 RID: 535
		public static int teamnationlinks;

		// Token: 0x04000218 RID: 536
		public static int teams;

		// Token: 0x04000219 RID: 537
		public static int teamstadiumlinks;

		// Token: 0x0400021A RID: 538
		public static int teamstadiumlinkscache;

		// Token: 0x0400021B RID: 539
		public static int temp_arenacreateplayer;

		// Token: 0x0400021C RID: 540
		public static int temp_arenaplayer;

		// Token: 0x0400021D RID: 541
		public static int temp_arenaplayername;

		// Token: 0x0400021E RID: 542
		public static int temp_arenateam;

		// Token: 0x0400021F RID: 543
		public static int temp_arenateamplayerlinks;

		// Token: 0x04000220 RID: 544
		public static int temp_createplayer;

		// Token: 0x04000221 RID: 545
		public static int temp_formations;

		// Token: 0x04000222 RID: 546
		public static int temp_players;

		// Token: 0x04000223 RID: 547
		public static int temp_teamplayerlinks;

		// Token: 0x04000224 RID: 548
		public static int temp_teams;

		// Token: 0x04000225 RID: 549
		public static int trainingteamplayerlinks;

		// Token: 0x04000226 RID: 550
		public static int trainingteamplayernames;

		// Token: 0x04000227 RID: 551
		public static int trainingteamplayers;

		// Token: 0x04000228 RID: 552
		public static int transactionhistory;

		// Token: 0x04000229 RID: 553
		public static int version;

		// Token: 0x0400022A RID: 554
		public static int videos;

		// Token: 0x0400022B RID: 555
		public static int defaultteamdata = -1;

		// Token: 0x0400022C RID: 556
		public static int default_teamsheets = -1;
	}
}
