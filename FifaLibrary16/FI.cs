using System;

namespace FifaLibrary
{
	// Token: 0x02000032 RID: 50
	public class FI
	{
		// Token: 0x06000357 RID: 855 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public static void InitFIAsFIFA12()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		public static void InitFI(DbFile fifaDb)
		{
			FI.language_hashid = 0;
			FI.language_stringid = 1;
			FI.language_sourcetext = 0;
			Table table = fifaDb.GetTable("teamstadiumlinks");
			if (table != null)
			{
				FI.teamstadiumlinks_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.teamstadiumlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("teams");
			if (table != null)
			{
				FI.teams_trait1 = table.TableDescriptor.GetFieldIndex("trait1");
				FI.teams_busdribbling = table.TableDescriptor.GetFieldIndex("busdribbling");
				FI.teams_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.teams_balltype = table.TableDescriptor.GetFieldIndex("balltype");
				FI.teams_teamcolor1g = table.TableDescriptor.GetFieldIndex("teamcolor1g");
				FI.teams_teamcolor1r = table.TableDescriptor.GetFieldIndex("teamcolor1r");
				FI.teams_teamcolor2b = table.TableDescriptor.GetFieldIndex("teamcolor2b");
				FI.teams_teamcolor2r = table.TableDescriptor.GetFieldIndex("teamcolor2r");
				FI.teams_teamcolor3r = table.TableDescriptor.GetFieldIndex("teamcolor3r");
				FI.teams_teamcolor1b = table.TableDescriptor.GetFieldIndex("teamcolor1b");
				FI.teams_latitude = table.TableDescriptor.GetFieldIndex("latitude");
				FI.teams_teamcolor3g = table.TableDescriptor.GetFieldIndex("teamcolor3g");
				FI.teams_teamcolor2g = table.TableDescriptor.GetFieldIndex("teamcolor2g");
				FI.teams_teamname = table.TableDescriptor.GetFieldIndex("teamname");
				FI.teams_adboardid = table.TableDescriptor.GetFieldIndex("adboardid");
				FI.teams_teamcolor3b = table.TableDescriptor.GetFieldIndex("teamcolor3b");
				FI.teams_defmentality = table.TableDescriptor.GetFieldIndex("defmentality");
				FI.teams_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teams_physioid_secondary = table.TableDescriptor.GetFieldIndex("physioid_secondary");
				FI.teams_domesticprestige = table.TableDescriptor.GetFieldIndex("domesticprestige");
				FI.teams_genericint2 = table.TableDescriptor.GetFieldIndex("genericint2");
				FI.teams_jerseytype = table.TableDescriptor.GetFieldIndex("jerseytype");
				FI.teams_rivalteam = table.TableDescriptor.GetFieldIndex("rivalteam");
				FI.teams_midfieldrating = table.TableDescriptor.GetFieldIndex("midfieldrating");
				FI.teams_matchdayoverallrating = table.TableDescriptor.GetFieldIndex("matchdayoverallrating");
				FI.teams_matchdaymidfieldrating = table.TableDescriptor.GetFieldIndex("matchdaymidfieldrating");
				FI.teams_attackrating = table.TableDescriptor.GetFieldIndex("attackrating");
				FI.teams_physioid_primary = table.TableDescriptor.GetFieldIndex("physioid_primary");
				FI.teams_longitude = table.TableDescriptor.GetFieldIndex("longitude");
				FI.teams_buspassing = table.TableDescriptor.GetFieldIndex("buspassing");
				FI.teams_matchdaydefenserating = table.TableDescriptor.GetFieldIndex("matchdaydefenserating");
				FI.teams_defenserating = table.TableDescriptor.GetFieldIndex("defenserating");
				FI.teams_defteamwidth = table.TableDescriptor.GetFieldIndex("defteamwidth");
				FI.teams_longkicktakerid = table.TableDescriptor.GetFieldIndex("longkicktakerid");
				FI.teams_bodytypeid = table.TableDescriptor.GetFieldIndex("bodytypeid");
				FI.teams_rightcornerkicktakerid = table.TableDescriptor.GetFieldIndex("rightcornerkicktakerid");
				FI.teams_suitvariationid = table.TableDescriptor.GetFieldIndex("suitvariationid");
				FI.teams_defaggression = table.TableDescriptor.GetFieldIndex("defaggression");
				FI.teams_ethnicity = table.TableDescriptor.GetFieldIndex("ethnicity");
				FI.teams_leftcornerkicktakerid = table.TableDescriptor.GetFieldIndex("leftcornerkicktakerid");
				FI.teams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teams_fancrowdhairskintexturecode = table.TableDescriptor.GetFieldIndex("fancrowdhairskintexturecode");
				FI.teams_suittypeid = table.TableDescriptor.GetFieldIndex("suittypeid");
				FI.teams_numtransfersin = table.TableDescriptor.GetFieldIndex("numtransfersin");
				FI.teams_captainid = table.TableDescriptor.GetFieldIndex("captainid");
				FI.teams_personalityid = table.TableDescriptor.GetFieldIndex("personalityid");
				FI.teams_genericbanner = table.TableDescriptor.GetFieldIndex("genericbanner");
				FI.teams_buspositioning = table.TableDescriptor.GetFieldIndex("buspositioning");
				FI.teams_stafftracksuitcolorcode = table.TableDescriptor.GetFieldIndex("stafftracksuitcolorcode");
				FI.teams_ccpositioning = table.TableDescriptor.GetFieldIndex("ccpositioning");
				FI.teams_busbuildupspeed = table.TableDescriptor.GetFieldIndex("busbuildupspeed");
				FI.teams_transferbudget = table.TableDescriptor.GetFieldIndex("transferbudget");
				FI.teams_ccshooting = table.TableDescriptor.GetFieldIndex("ccshooting");
				FI.teams_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.teams_ccpassing = table.TableDescriptor.GetFieldIndex("ccpassing");
				FI.teams_utcoffset = table.TableDescriptor.GetFieldIndex("utcoffset");
				FI.teams_penaltytakerid = table.TableDescriptor.GetFieldIndex("penaltytakerid");
				FI.teams_freekicktakerid = table.TableDescriptor.GetFieldIndex("freekicktakerid");
				FI.teams_leftfreekicktakerid = table.TableDescriptor.GetFieldIndex("leftfreekicktakerid");
				FI.teams_rightfreekicktakerid = table.TableDescriptor.GetFieldIndex("rightfreekicktakerid");
				FI.teams_defdefenderline = table.TableDescriptor.GetFieldIndex("defdefenderline");
				FI.teams_internationalprestige = table.TableDescriptor.GetFieldIndex("internationalprestige");
				FI.teams_form = table.TableDescriptor.GetFieldIndex("form");
				FI.teams_genericint1 = table.TableDescriptor.GetFieldIndex("genericint1");
				FI.teams_cccrossing = table.TableDescriptor.GetFieldIndex("cccrossing");
				FI.teams_matchdayattackrating = table.TableDescriptor.GetFieldIndex("matchdayattackrating");
			}
			table = fifaDb.GetTable("teamplayerlinks");
			if (table != null)
			{
				FI.teamplayerlinks_leaguegoals = table.TableDescriptor.GetFieldIndex("leaguegoals");
				FI.teamplayerlinks_isamongtopscorers = table.TableDescriptor.GetFieldIndex("isamongtopscorers");
				FI.teamplayerlinks_yellows = table.TableDescriptor.GetFieldIndex("yellows");
				FI.teamplayerlinks_isamongtopscorersinteam = table.TableDescriptor.GetFieldIndex("isamongtopscorersinteam");
				FI.teamplayerlinks_jerseynumber = table.TableDescriptor.GetFieldIndex("jerseynumber");
				FI.teamplayerlinks_position = table.TableDescriptor.GetFieldIndex("position");
				FI.teamplayerlinks_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.teamplayerlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teamplayerlinks_injury = table.TableDescriptor.GetFieldIndex("injury");
				FI.teamplayerlinks_leagueappearances = table.TableDescriptor.GetFieldIndex("leagueappearances");
				FI.teamplayerlinks_leaguegoalsprevthreematches = table.TableDescriptor.GetFieldIndex("leaguegoalsprevthreematches");
				FI.teamplayerlinks_leaguegoalsprevmatch = table.TableDescriptor.GetFieldIndex("leaguegoalsprevmatch");
				FI.teamplayerlinks_prevform = table.TableDescriptor.GetFieldIndex("prevform");
				FI.teamplayerlinks_istopscorer = table.TableDescriptor.GetFieldIndex("istopscorer");
				FI.teamplayerlinks_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.teamplayerlinks_form = table.TableDescriptor.GetFieldIndex("form");
				FI.teamplayerlinks_reds = table.TableDescriptor.GetFieldIndex("reds");
			}
			table = fifaDb.GetTable("teamformationteamstylelinks");
			if (table != null)
			{
				FI.teamformationteamstylelinks_cddl = table.TableDescriptor.GetFieldIndex("cddl");
				FI.teamformationteamstylelinks_formationid = table.TableDescriptor.GetFieldIndex("formationid");
				FI.teamformationteamstylelinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.teamformationteamstylelinks_teamstyleid = table.TableDescriptor.GetFieldIndex("teamstyleid");
			}
			table = fifaDb.GetTable("teamkits");
			if (table != null)
			{
				FI.teamkits_shortsnumberplacementcode = table.TableDescriptor.GetFieldIndex("shortsnumberplacementcode");
				FI.teamkits_teamcolorsecb = table.TableDescriptor.GetFieldIndex("teamcolorsecb");
				FI.teamkits_shortsrenderingdetailmaptype = table.TableDescriptor.GetFieldIndex("shortsrenderingdetailmaptype");
				FI.teamkits_jerseyfrontnumberplacementcode = table.TableDescriptor.GetFieldIndex("jerseyfrontnumberplacementcode");
				FI.teamkits_teamcolorprimg = table.TableDescriptor.GetFieldIndex("teamcolorprimg");
				FI.teamkits_numberfonttype = table.TableDescriptor.GetFieldIndex("numberfonttype");
				FI.teamkits_teamcolortertb = table.TableDescriptor.GetFieldIndex("teamcolortertb");
				FI.teamkits_jerseynamefonttype = table.TableDescriptor.GetFieldIndex("jerseynamefonttype");
				FI.teamkits_jerseynamelayouttype = table.TableDescriptor.GetFieldIndex("jerseynamelayouttype");
				FI.teamkits_shortsnumbercolor = table.TableDescriptor.GetFieldIndex("shortsnumbercolor");
				FI.teamkits_jerseyshapestyle = table.TableDescriptor.GetFieldIndex("jerseyshapestyle");
				FI.teamkits_jerseybacknameplacementcode = table.TableDescriptor.GetFieldIndex("jerseybacknameplacementcode");
				FI.teamkits_teamcolorprimr = table.TableDescriptor.GetFieldIndex("teamcolorprimr");
				FI.teamkits_jerseynamecolorg = table.TableDescriptor.GetFieldIndex("jerseynamecolorg");
				FI.teamkits_teamcolorsecg = table.TableDescriptor.GetFieldIndex("teamcolorsecg");
				FI.teamkits_teamcolortertr = table.TableDescriptor.GetFieldIndex("teamcolortertr");
				FI.teamkits_renderingmaterialtype = table.TableDescriptor.GetFieldIndex("renderingmaterialtype");
				FI.teamkits_teamcolorsecr = table.TableDescriptor.GetFieldIndex("teamcolorsecr");
				FI.teamkits_jerseycollargeometrytype = table.TableDescriptor.GetFieldIndex("jerseycollargeometrytype");
				FI.teamkits_jerseynamecolorr = table.TableDescriptor.GetFieldIndex("jerseynamecolorr");
				FI.teamkits_numbercolor = table.TableDescriptor.GetFieldIndex("numbercolor");
				FI.teamkits_teamcolorprimb = table.TableDescriptor.GetFieldIndex("teamcolorprimb");
				FI.teamkits_jerseyrenderingdetailmaptype = table.TableDescriptor.GetFieldIndex("jerseyrenderingdetailmaptype");
				FI.teamkits_shortsnumberfonttype = table.TableDescriptor.GetFieldIndex("shortsnumberfonttype");
				FI.teamkits_jerseynamecolorb = table.TableDescriptor.GetFieldIndex("jerseynamecolorb");
				FI.teamkits_teamcolortertg = table.TableDescriptor.GetFieldIndex("teamcolortertg");
				FI.teamkits_jerseybacknamefontcase = table.TableDescriptor.GetFieldIndex("jerseybacknamefontcase");
				FI.teamkits_teamkittypetechid = table.TableDescriptor.GetFieldIndex("teamkittypetechid");
				FI.teamkits_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teamkits_isinheritbasedetailmap = table.TableDescriptor.GetFieldIndex("isinheritbasedetailmap");
				FI.teamkits_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.teamkits_teamkitid = table.TableDescriptor.GetFieldIndex("teamkitid");
				FI.teamkits_year = table.TableDescriptor.GetFieldIndex("year");
				FI.teamkits_teamtechid = table.TableDescriptor.GetFieldIndex("teamtechid");
				FI.teamkits_hasadvertisingkit = table.TableDescriptor.GetFieldIndex("hasadvertisingkit");
				FI.teamkits_dlc = table.TableDescriptor.GetFieldIndex("dlc");
				FI.teamkits_jerseyfit = table.TableDescriptor.GetFieldIndex("jerseyfit");
			}
			table = fifaDb.GetTable("teamballs");
			if (table != null)
			{
				FI.teamballs_ballid = table.TableDescriptor.GetFieldIndex("ballid");
				FI.teamballs_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.teamballs_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.teamballs_isembargoed = table.TableDescriptor.GetFieldIndex("isembargoed");
				FI.teamballs_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
			}
			table = fifaDb.GetTable("playerboots");
			if (table != null)
			{
				FI.playerboots_isadidas = table.TableDescriptor.GetFieldIndex("isadidas");
				FI.playerboots_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
				FI.playerboots_isembargoed = table.TableDescriptor.GetFieldIndex("isembargoed");
				FI.playerboots_gender = table.TableDescriptor.GetFieldIndex("gender");
				FI.playerboots_islegacy = table.TableDescriptor.GetFieldIndex("islegacy");
				FI.playerboots_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.playerboots_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.playerboots_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.playerboots_shoecolor1 = table.TableDescriptor.GetFieldIndex("shoecolor1");
				FI.playerboots_shoecolor2 = table.TableDescriptor.GetFieldIndex("shoecolor2");
				FI.playerboots_shoedesign = table.TableDescriptor.GetFieldIndex("shoedesign");
				FI.playerboots_shoetype = table.TableDescriptor.GetFieldIndex("shoetype");
			}
			table = fifaDb.GetTable("stadiums");
			if (table != null)
			{
				FI.stadiums_yearbuilt = table.TableDescriptor.GetFieldIndex("yearbuilt");
				FI.stadiums_name = table.TableDescriptor.GetFieldIndex("name");
				FI.stadiums_timeofday3 = table.TableDescriptor.GetFieldIndex("timeofday3");
				FI.stadiums_adboardsidelinedistance = table.TableDescriptor.GetFieldIndex("adboardsidelinedistance");
				FI.stadiums_stadiumgloalnetdepth = table.TableDescriptor.GetFieldIndex("stadiumgloalnetdepth");
				FI.stadiums_hometeamid = table.TableDescriptor.GetFieldIndex("hometeamid");
				FI.stadiums_capacity = table.TableDescriptor.GetFieldIndex("capacity");
				FI.stadiums_seatcolor = table.TableDescriptor.GetFieldIndex("seatcolor");
				FI.stadiums_sectionfacedbydefault = table.TableDescriptor.GetFieldIndex("sectionfacedbydefault");
				FI.stadiums_policetypecode = table.TableDescriptor.GetFieldIndex("policetypecode");
				FI.stadiums_timeofday4 = table.TableDescriptor.GetFieldIndex("timeofday4");
				FI.stadiums_stadiumpitchlength = table.TableDescriptor.GetFieldIndex("stadiumpitchlength");
				FI.stadiums_stadiumgoalnetstyle = table.TableDescriptor.GetFieldIndex("stadiumgoalnetstyle");
				FI.stadiums_upgradetier = table.TableDescriptor.GetFieldIndex("upgradetier");
				FI.stadiums_tod4weather = table.TableDescriptor.GetFieldIndex("tod4weather");
				FI.stadiums_countrycode = table.TableDescriptor.GetFieldIndex("countrycode");
				FI.stadiums_stadiummowpattern_code = table.TableDescriptor.GetFieldIndex("stadiummowpattern_code");
				FI.stadiums_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.stadiums_cameraheight = table.TableDescriptor.GetFieldIndex("cameraheight");
				FI.stadiums_stadiumgoalnettype = table.TableDescriptor.GetFieldIndex("stadiumgoalnettype");
				FI.stadiums_stadiumpitchwidth = table.TableDescriptor.GetFieldIndex("stadiumpitchwidth");
				FI.stadiums_stadiumtype = table.TableDescriptor.GetFieldIndex("stadiumtype");
				FI.stadiums_stadiumgoalnettension = table.TableDescriptor.GetFieldIndex("stadiumgoalnettension");
				FI.stadiums_tod1weather = table.TableDescriptor.GetFieldIndex("tod1weather");
				FI.stadiums_dlc = table.TableDescriptor.GetFieldIndex("dlc");
				FI.stadiums_tod2weather = table.TableDescriptor.GetFieldIndex("tod2weather");
				FI.stadiums_camerazoom = table.TableDescriptor.GetFieldIndex("camerazoom");
				FI.stadiums_adboardendlinedistance = table.TableDescriptor.GetFieldIndex("adboardendlinedistance");
				FI.stadiums_iseditable = table.TableDescriptor.GetFieldIndex("iseditable");
				FI.stadiums_isdynamic = table.TableDescriptor.GetFieldIndex("isdynamic");
				FI.stadiums_tod3weather = table.TableDescriptor.GetFieldIndex("tod3weather");
				FI.stadiums_upgradestyle = table.TableDescriptor.GetFieldIndex("upgradestyle");
				FI.stadiums_genericrank = table.TableDescriptor.GetFieldIndex("genericrank");
				FI.stadiums_timeofday1 = table.TableDescriptor.GetFieldIndex("timeofday1");
				FI.stadiums_timeofday2 = table.TableDescriptor.GetFieldIndex("timeofday2");
				FI.stadiums_stadiumgoalnetwidth = table.TableDescriptor.GetFieldIndex("stadiumgoalnetwidth");
				FI.stadiums_stadiumgoalnetpattern = table.TableDescriptor.GetFieldIndex("stadiumgoalnetpattern");
				FI.stadiums_adboardtype = table.TableDescriptor.GetFieldIndex("adboardtype");
				FI.stadiums_stadiumgoalnetlength = table.TableDescriptor.GetFieldIndex("stadiumgoalnetlength");
				FI.stadiums_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.stadiums_stadhometechzonemaxz = table.TableDescriptor.GetFieldIndex("stadhometechzonemaxz");
				FI.stadiums_stadawaytechzonemaxx = table.TableDescriptor.GetFieldIndex("stadawaytechzonemaxx");
				FI.stadiums_stadhometechzonemaxx = table.TableDescriptor.GetFieldIndex("stadhometechzonemaxx");
				FI.stadiums_stadawaytechzoneminz = table.TableDescriptor.GetFieldIndex("stadawaytechzoneminz");
				FI.stadiums_stadhometechzoneminx = table.TableDescriptor.GetFieldIndex("stadhometechzoneminx");
				FI.stadiums_stadhometechzoneminz = table.TableDescriptor.GetFieldIndex("stadhometechzoneminz");
				FI.stadiums_stadawaytechzonemaxz = table.TableDescriptor.GetFieldIndex("stadawaytechzonemaxz");
				FI.stadiums_stadawaytechzoneminx = table.TableDescriptor.GetFieldIndex("stadawaytechzoneminx");
			}
			table = fifaDb.GetTable("shoecolors");
			if (table != null)
			{
				FI.shoecolors_blue = table.TableDescriptor.GetFieldIndex("blue");
				FI.shoecolors_green = table.TableDescriptor.GetFieldIndex("green");
				FI.shoecolors_red = table.TableDescriptor.GetFieldIndex("red");
				FI.shoecolors_colorid = table.TableDescriptor.GetFieldIndex("colorid");
			}
			table = fifaDb.GetTable("rowteamnationlinks");
			if (table != null)
			{
				FI.rowteamnationlinks_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.rowteamnationlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("rivals");
			if (table != null)
			{
				FI.rivals_rivaltype = table.TableDescriptor.GetFieldIndex("rivaltype");
				FI.rivals_teamid2 = table.TableDescriptor.GetFieldIndex("teamid2");
				FI.rivals_teamid1 = table.TableDescriptor.GetFieldIndex("teamid1");
			}
			table = fifaDb.GetTable("referee");
			if (table != null)
			{
				FI.referee_birthdate = table.TableDescriptor.GetFieldIndex("birthdate");
				FI.referee_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.referee_shoetypecode = table.TableDescriptor.GetFieldIndex("shoetypecode");
				FI.referee_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.referee_nationalitycode = table.TableDescriptor.GetFieldIndex("nationalitycode");
				FI.referee_haircolorcode = table.TableDescriptor.GetFieldIndex("haircolorcode");
				FI.referee_facialhairtypecode = table.TableDescriptor.GetFieldIndex("facialhairtypecode");
				FI.referee_hairtypecode = table.TableDescriptor.GetFieldIndex("hairtypecode");
				FI.referee_cardstrictness = table.TableDescriptor.GetFieldIndex("cardstrictness");
				FI.referee_shoecolorcode2 = table.TableDescriptor.GetFieldIndex("shoecolorcode2");
				FI.referee_stylecode = table.TableDescriptor.GetFieldIndex("stylecode");
				FI.referee_proxyhaircolorid = table.TableDescriptor.GetFieldIndex("proxyhaircolorid");
				FI.referee_headtypecode = table.TableDescriptor.GetFieldIndex("headtypecode");
				FI.referee_foulstrictness = table.TableDescriptor.GetFieldIndex("foulstrictness");
				FI.referee_height = table.TableDescriptor.GetFieldIndex("height");
				FI.referee_hairstateid = table.TableDescriptor.GetFieldIndex("hairstateid");
				FI.referee_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.referee_sockheightcode = table.TableDescriptor.GetFieldIndex("sockheightcode");
				FI.referee_weight = table.TableDescriptor.GetFieldIndex("weight");
				FI.referee_proxyheadclass = table.TableDescriptor.GetFieldIndex("proxyheadclass");
				FI.referee_eyebrowcode = table.TableDescriptor.GetFieldIndex("eyebrowcode");
				FI.referee_gender = table.TableDescriptor.GetFieldIndex("gender");
				FI.referee_eyecolorcode = table.TableDescriptor.GetFieldIndex("eyecolorcode");
				FI.referee_jerseysleevelengthcode = table.TableDescriptor.GetFieldIndex("jerseysleevelengthcode");
				FI.referee_hairlinecode = table.TableDescriptor.GetFieldIndex("hairlinecode");
				FI.referee_headclasscode = table.TableDescriptor.GetFieldIndex("headclasscode");
				FI.referee_haireffecttypecode = table.TableDescriptor.GetFieldIndex("haireffecttypecode");
				FI.referee_sideburnscode = table.TableDescriptor.GetFieldIndex("sideburnscode");
				FI.referee_skintypecode = table.TableDescriptor.GetFieldIndex("skintypecode");
				FI.referee_hairpartcode = table.TableDescriptor.GetFieldIndex("hairpartcode");
				FI.referee_sweatid = table.TableDescriptor.GetFieldIndex("sweatid");
				FI.referee_skintonecode = table.TableDescriptor.GetFieldIndex("skintonecode");
				FI.referee_hairvariationid = table.TableDescriptor.GetFieldIndex("hairvariationid");
				FI.referee_refereeid = table.TableDescriptor.GetFieldIndex("refereeid");
				FI.referee_homecitycode = table.TableDescriptor.GetFieldIndex("homecitycode");
				FI.referee_shoedesigncode = table.TableDescriptor.GetFieldIndex("shoedesigncode");
				FI.referee_shoecolorcode1 = table.TableDescriptor.GetFieldIndex("shoecolorcode1");
				FI.referee_bodytypecode = table.TableDescriptor.GetFieldIndex("bodytypecode");
				FI.referee_wrinkleid = table.TableDescriptor.GetFieldIndex("wrinkleid");
				FI.referee_facialhaircolorcode = table.TableDescriptor.GetFieldIndex("facialhaircolorcode");
				FI.referee_isreal = table.TableDescriptor.GetFieldIndex("isreal");
			}
			table = fifaDb.GetTable("previousteam");
			if (table != null)
			{
				FI.previousteam_previousteamid = table.TableDescriptor.GetFieldIndex("previousteamid");
				FI.previousteam_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("players");
			if (table != null)
			{
				FI.players_birthdate = table.TableDescriptor.GetFieldIndex("birthdate");
				FI.players_playerjointeamdate = table.TableDescriptor.GetFieldIndex("playerjointeamdate");
				FI.players_shoetypecode = table.TableDescriptor.GetFieldIndex("shoetypecode");
				FI.players_haircolorcode = table.TableDescriptor.GetFieldIndex("haircolorcode");
				FI.players_facialhairtypecode = table.TableDescriptor.GetFieldIndex("facialhairtypecode");
				FI.players_curve = table.TableDescriptor.GetFieldIndex("curve");
				FI.players_jerseystylecode = table.TableDescriptor.GetFieldIndex("jerseystylecode");
				FI.players_agility = table.TableDescriptor.GetFieldIndex("agility");
				FI.players_accessorycode4 = table.TableDescriptor.GetFieldIndex("accessorycode4");
				FI.players_gksavetype = table.TableDescriptor.GetFieldIndex("gksavetype");
				FI.players_positioning = table.TableDescriptor.GetFieldIndex("positioning");
				FI.players_hairtypecode = table.TableDescriptor.GetFieldIndex("hairtypecode");
				FI.players_standingtackle = table.TableDescriptor.GetFieldIndex("standingtackle");
				FI.players_faceposercode = table.TableDescriptor.GetFieldIndex("faceposercode");
				FI.players_preferredposition3 = table.TableDescriptor.GetFieldIndex("preferredposition3");
				FI.players_longpassing = table.TableDescriptor.GetFieldIndex("longpassing");
				FI.players_penalties = table.TableDescriptor.GetFieldIndex("penalties");
				FI.players_animfreekickstartposcode = table.TableDescriptor.GetFieldIndex("animfreekickstartposcode");
				FI.players_animpenaltieskickstylecode = table.TableDescriptor.GetFieldIndex("animpenaltieskickstylecode");
				FI.players_isretiring = table.TableDescriptor.GetFieldIndex("isretiring");
				FI.players_longshots = table.TableDescriptor.GetFieldIndex("longshots");
				FI.players_gkdiving = table.TableDescriptor.GetFieldIndex("gkdiving");
				FI.players_interceptions = table.TableDescriptor.GetFieldIndex("interceptions");
				FI.players_shoecolorcode2 = table.TableDescriptor.GetFieldIndex("shoecolorcode2");
				FI.players_crossing = table.TableDescriptor.GetFieldIndex("crossing");
				FI.players_potential = table.TableDescriptor.GetFieldIndex("potential");
				FI.players_gkreflexes = table.TableDescriptor.GetFieldIndex("gkreflexes");
				FI.players_finishingcode1 = table.TableDescriptor.GetFieldIndex("finishingcode1");
				FI.players_reactions = table.TableDescriptor.GetFieldIndex("reactions");
				FI.players_vision = table.TableDescriptor.GetFieldIndex("vision");
				FI.players_contractvaliduntil = table.TableDescriptor.GetFieldIndex("contractvaliduntil");
				FI.players_finishing = table.TableDescriptor.GetFieldIndex("finishing");
				FI.players_dribbling = table.TableDescriptor.GetFieldIndex("dribbling");
				FI.players_slidingtackle = table.TableDescriptor.GetFieldIndex("slidingtackle");
				FI.players_accessorycode3 = table.TableDescriptor.GetFieldIndex("accessorycode3");
				FI.players_accessorycolourcode1 = table.TableDescriptor.GetFieldIndex("accessorycolourcode1");
				FI.players_headtypecode = table.TableDescriptor.GetFieldIndex("headtypecode");
				FI.players_firstnameid = table.TableDescriptor.GetFieldIndex("firstnameid");
				FI.players_sprintspeed = table.TableDescriptor.GetFieldIndex("sprintspeed");
				FI.players_height = table.TableDescriptor.GetFieldIndex("height");
				FI.players_hasseasonaljersey = table.TableDescriptor.GetFieldIndex("hasseasonaljersey");
				FI.players_preferredposition2 = table.TableDescriptor.GetFieldIndex("preferredposition2");
				FI.players_strength = table.TableDescriptor.GetFieldIndex("strength");
				FI.players_preferredposition1 = table.TableDescriptor.GetFieldIndex("preferredposition1");
				FI.players_ballcontrol = table.TableDescriptor.GetFieldIndex("ballcontrol");
				FI.players_shotpower = table.TableDescriptor.GetFieldIndex("shotpower");
				FI.players_trait1 = table.TableDescriptor.GetFieldIndex("trait1");
				FI.players_socklengthcode = table.TableDescriptor.GetFieldIndex("socklengthcode");
				FI.players_weight = table.TableDescriptor.GetFieldIndex("weight");
				FI.players_hashighqualityhead = table.TableDescriptor.GetFieldIndex("hashighqualityhead");
				FI.players_gkglovetypecode = table.TableDescriptor.GetFieldIndex("gkglovetypecode");
				FI.players_balance = table.TableDescriptor.GetFieldIndex("balance");
				FI.players_gkkicking = table.TableDescriptor.GetFieldIndex("gkkicking");
				FI.players_lastnameid = table.TableDescriptor.GetFieldIndex("lastnameid");
				FI.players_internationalrep = table.TableDescriptor.GetFieldIndex("internationalrep");
				FI.players_animpenaltiesmotionstylecode = table.TableDescriptor.GetFieldIndex("animpenaltiesmotionstylecode");
				FI.players_shortpassing = table.TableDescriptor.GetFieldIndex("shortpassing");
				FI.players_freekickaccuracy = table.TableDescriptor.GetFieldIndex("freekickaccuracy");
				FI.players_skillmoves = table.TableDescriptor.GetFieldIndex("skillmoves");
				FI.players_usercaneditname = table.TableDescriptor.GetFieldIndex("usercaneditname");
				FI.players_attackingworkrate = table.TableDescriptor.GetFieldIndex("attackingworkrate");
				FI.players_finishingcode2 = table.TableDescriptor.GetFieldIndex("finishingcode2");
				FI.players_aggression = table.TableDescriptor.GetFieldIndex("aggression");
				FI.players_acceleration = table.TableDescriptor.GetFieldIndex("acceleration");
				FI.players_headingaccuracy = table.TableDescriptor.GetFieldIndex("headingaccuracy");
				FI.players_eyebrowcode = table.TableDescriptor.GetFieldIndex("eyebrowcode");
				FI.players_runningcode2 = table.TableDescriptor.GetFieldIndex("runningcode2");
				FI.players_gkhandling = table.TableDescriptor.GetFieldIndex("gkhandling");
				FI.players_eyecolorcode = table.TableDescriptor.GetFieldIndex("eyecolorcode");
				FI.players_jerseysleevelengthcode = table.TableDescriptor.GetFieldIndex("jerseysleevelengthcode");
				FI.players_accessorycolourcode3 = table.TableDescriptor.GetFieldIndex("accessorycolourcode3");
				FI.players_accessorycode1 = table.TableDescriptor.GetFieldIndex("accessorycode1");
				FI.players_headclasscode = table.TableDescriptor.GetFieldIndex("headclasscode");
				FI.players_defensiveworkrate = table.TableDescriptor.GetFieldIndex("defensiveworkrate");
				FI.players_nationality = table.TableDescriptor.GetFieldIndex("nationality");
				FI.players_preferredfoot = table.TableDescriptor.GetFieldIndex("preferredfoot");
				FI.players_sideburnscode = table.TableDescriptor.GetFieldIndex("sideburnscode");
				FI.players_weakfootabilitytypecode = table.TableDescriptor.GetFieldIndex("weakfootabilitytypecode");
				FI.players_jumping = table.TableDescriptor.GetFieldIndex("jumping");
				FI.players_skintypecode = table.TableDescriptor.GetFieldIndex("skintypecode");
				FI.players_gkkickstyle = table.TableDescriptor.GetFieldIndex("gkkickstyle");
				FI.players_stamina = table.TableDescriptor.GetFieldIndex("stamina");
				FI.players_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.players_marking = table.TableDescriptor.GetFieldIndex("marking");
				FI.players_accessorycolourcode4 = table.TableDescriptor.GetFieldIndex("accessorycolourcode4");
				FI.players_gkpositioning = table.TableDescriptor.GetFieldIndex("gkpositioning");
				FI.players_trait2 = table.TableDescriptor.GetFieldIndex("trait2");
				FI.players_skintonecode = table.TableDescriptor.GetFieldIndex("skintonecode");
				FI.players_shortstyle = table.TableDescriptor.GetFieldIndex("shortstyle");
				FI.players_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.players_jerseyfit = table.TableDescriptor.GetFieldIndex("jerseyfit");
				FI.players_accessorycode2 = table.TableDescriptor.GetFieldIndex("accessorycode2");
				FI.players_shoedesigncode = table.TableDescriptor.GetFieldIndex("shoedesigncode");
				FI.players_playerjerseynameid = table.TableDescriptor.GetFieldIndex("playerjerseynameid");
				FI.players_shoecolorcode1 = table.TableDescriptor.GetFieldIndex("shoecolorcode1");
				FI.players_commonnameid = table.TableDescriptor.GetFieldIndex("commonnameid");
				FI.players_bodytypecode = table.TableDescriptor.GetFieldIndex("bodytypecode");
				FI.players_animpenaltiesstartposcode = table.TableDescriptor.GetFieldIndex("animpenaltiesstartposcode");
				FI.players_runningcode1 = table.TableDescriptor.GetFieldIndex("runningcode1");
				FI.players_preferredposition4 = table.TableDescriptor.GetFieldIndex("preferredposition4");
				FI.players_volleys = table.TableDescriptor.GetFieldIndex("volleys");
				FI.players_gender = table.TableDescriptor.GetFieldIndex("gender");
				FI.players_emotion = table.TableDescriptor.GetFieldIndex("emotion");
				FI.players_accessorycolourcode2 = table.TableDescriptor.GetFieldIndex("accessorycolourcode2");
				FI.players_facialhaircolorcode = table.TableDescriptor.GetFieldIndex("facialhaircolorcode");
			}
			table = fifaDb.GetTable("playernames");
			if (table != null)
			{
				FI.playernames_name = table.TableDescriptor.GetFieldIndex("name");
				FI.playernames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.playernames_nameid = table.TableDescriptor.GetFieldIndex("nameid");
			}
			table = fifaDb.GetTable("dcplayernames");
			if (table != null)
			{
				FI.dcplayernames_name = table.TableDescriptor.GetFieldIndex("name");
				FI.dcplayernames_nameid = table.TableDescriptor.GetFieldIndex("nameid");
			}
			table = fifaDb.GetTable("playerloans");
			if (table != null)
			{
				FI.playerloans_loandateend = table.TableDescriptor.GetFieldIndex("loandateend");
				FI.playerloans_teamidloanedfrom = table.TableDescriptor.GetFieldIndex("teamidloanedfrom");
				FI.playerloans_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("playerboots");
			if (table != null)
			{
				FI.playerboots_shoetype = table.TableDescriptor.GetFieldIndex("shoetype");
				FI.playerboots_powid = table.TableDescriptor.GetFieldIndex("powid");
				FI.playerboots_islocked = table.TableDescriptor.GetFieldIndex("islocked");
				FI.playerboots_islegacy = table.TableDescriptor.GetFieldIndex("islegacy");
				FI.playerboots_shoecolor1 = table.TableDescriptor.GetFieldIndex("shoecolor1");
				FI.playerboots_islicensed = table.TableDescriptor.GetFieldIndex("islicensed");
				FI.playerboots_isavailableinstore = table.TableDescriptor.GetFieldIndex("isavailableinstore");
				FI.playerboots_isadidas = table.TableDescriptor.GetFieldIndex("isadidas");
				FI.playerboots_shoedesign = table.TableDescriptor.GetFieldIndex("shoedesign");
				FI.playerboots_shoecolor2 = table.TableDescriptor.GetFieldIndex("shoecolor2");
			}
			table = fifaDb.GetTable("player_grudgelove");
			if (table != null)
			{
				FI.player_grudgelove_level_of_emotion = table.TableDescriptor.GetFieldIndex("level_of_emotion");
				FI.player_grudgelove_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.player_grudgelove_emotional_teamid = table.TableDescriptor.GetFieldIndex("emotional_teamid");
			}
			table = fifaDb.GetTable("nations");
			if (table != null)
			{
				FI.nations_nationname = table.TableDescriptor.GetFieldIndex("nationname");
				FI.nations_isocountrycode = table.TableDescriptor.GetFieldIndex("isocountrycode");
				FI.nations_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.nations_confederation = table.TableDescriptor.GetFieldIndex("confederation");
				FI.nations_top_tier = table.TableDescriptor.GetFieldIndex("top_tier");
				FI.nations_nationstartingfirstletter = table.TableDescriptor.GetFieldIndex("nationstartingfirstletter");
			}
			table = fifaDb.GetTable("teamnationlinks");
			if (table != null)
			{
				FI.teamnationlinks_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.teamnationlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("manager");
			if (table != null)
			{
				FI.manager_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.manager_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.manager_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("leagueteamlinks");
			if (table != null)
			{
				FI.leagueteamlinks_homega = table.TableDescriptor.GetFieldIndex("homega");
				FI.leagueteamlinks_homegf = table.TableDescriptor.GetFieldIndex("homegf");
				FI.leagueteamlinks_points = table.TableDescriptor.GetFieldIndex("points");
				FI.leagueteamlinks_awayga = table.TableDescriptor.GetFieldIndex("awayga");
				FI.leagueteamlinks_awaygf = table.TableDescriptor.GetFieldIndex("awaygf");
				FI.leagueteamlinks_teamshortform = table.TableDescriptor.GetFieldIndex("teamshortform");
				FI.leagueteamlinks_hasachievedobjective = table.TableDescriptor.GetFieldIndex("hasachievedobjective");
				FI.leagueteamlinks_secondarytable = table.TableDescriptor.GetFieldIndex("secondarytable");
				FI.leagueteamlinks_yettowin = table.TableDescriptor.GetFieldIndex("yettowin");
				FI.leagueteamlinks_unbeatenallcomps = table.TableDescriptor.GetFieldIndex("unbeatenallcomps");
				FI.leagueteamlinks_unbeatenleague = table.TableDescriptor.GetFieldIndex("unbeatenleague");
				FI.leagueteamlinks_champion = table.TableDescriptor.GetFieldIndex("champion");
				FI.leagueteamlinks_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leagueteamlinks_prevleagueid = table.TableDescriptor.GetFieldIndex("prevleagueid");
				FI.leagueteamlinks_previousyeartableposition = table.TableDescriptor.GetFieldIndex("previousyeartableposition");
				FI.leagueteamlinks_highestpossible = table.TableDescriptor.GetFieldIndex("highestpossible");
				FI.leagueteamlinks_teamform = table.TableDescriptor.GetFieldIndex("teamform");
				FI.leagueteamlinks_highestprobable = table.TableDescriptor.GetFieldIndex("highestprobable");
				FI.leagueteamlinks_homewins = table.TableDescriptor.GetFieldIndex("homewins");
				FI.leagueteamlinks_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.leagueteamlinks_nummatchesplayed = table.TableDescriptor.GetFieldIndex("nummatchesplayed");
				FI.leagueteamlinks_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.leagueteamlinks_gapresult = table.TableDescriptor.GetFieldIndex("gapresult");
				FI.leagueteamlinks_grouping = table.TableDescriptor.GetFieldIndex("grouping");
				FI.leagueteamlinks_currenttableposition = table.TableDescriptor.GetFieldIndex("currenttableposition");
				FI.leagueteamlinks_awaywins = table.TableDescriptor.GetFieldIndex("awaywins");
				FI.leagueteamlinks_objective = table.TableDescriptor.GetFieldIndex("objective");
				FI.leagueteamlinks_actualvsexpectations = table.TableDescriptor.GetFieldIndex("actualvsexpectations");
				FI.leagueteamlinks_homelosses = table.TableDescriptor.GetFieldIndex("homelosses");
				FI.leagueteamlinks_unbeatenhome = table.TableDescriptor.GetFieldIndex("unbeatenhome");
				FI.leagueteamlinks_lastgameresult = table.TableDescriptor.GetFieldIndex("lastgameresult");
				FI.leagueteamlinks_unbeatenaway = table.TableDescriptor.GetFieldIndex("unbeatenaway");
				FI.leagueteamlinks_awaylosses = table.TableDescriptor.GetFieldIndex("awaylosses");
				FI.leagueteamlinks_awaydraws = table.TableDescriptor.GetFieldIndex("awaydraws");
				FI.leagueteamlinks_homedraws = table.TableDescriptor.GetFieldIndex("homedraws");
				FI.leagueteamlinks_teamlongform = table.TableDescriptor.GetFieldIndex("teamlongform");
			}
			table = fifaDb.GetTable("leagues");
			if (table != null)
			{
				FI.leagues_countryid = table.TableDescriptor.GetFieldIndex("countryid");
				FI.leagues_leaguename = table.TableDescriptor.GetFieldIndex("leaguename");
				FI.leagues_level = table.TableDescriptor.GetFieldIndex("level");
				FI.leagues_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leagues_leaguetimeslice = table.TableDescriptor.GetFieldIndex("leaguetimeslice");
				FI.leagues_iswithintransferwindow = table.TableDescriptor.GetFieldIndex("iswithintransferwindow");
			}
			table = fifaDb.GetTable("leaguerefereelinks");
			if (table != null)
			{
				FI.leaguerefereelinks_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.leaguerefereelinks_refereeid = table.TableDescriptor.GetFieldIndex("refereeid");
			}
			table = fifaDb.GetTable("formupdate");
			if (table != null)
			{
				FI.formupdate_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.formupdate_position = table.TableDescriptor.GetFieldIndex("position");
				FI.formupdate_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.formupdate_formaudio = table.TableDescriptor.GetFieldIndex("formaudio");
				FI.formupdate_prevform = table.TableDescriptor.GetFieldIndex("prevform");
				FI.formupdate_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.formupdate_overallrating = table.TableDescriptor.GetFieldIndex("overallrating");
				FI.formupdate_form = table.TableDescriptor.GetFieldIndex("form");
			}
			table = fifaDb.GetTable("formations");
			if (table != null)
			{
				FI.formations_offset6x = table.TableDescriptor.GetFieldIndex("offset6x");
				FI.formations_offset5y = table.TableDescriptor.GetFieldIndex("offset5y");
				FI.formations_offset10x = table.TableDescriptor.GetFieldIndex("offset10x");
				FI.formations_offset2x = table.TableDescriptor.GetFieldIndex("offset2x");
				FI.formations_defenders = table.TableDescriptor.GetFieldIndex("defenders");
				FI.formations_offset2y = table.TableDescriptor.GetFieldIndex("offset2y");
				FI.formations_offset6y = table.TableDescriptor.GetFieldIndex("offset6y");
				FI.formations_offset7x = table.TableDescriptor.GetFieldIndex("offset7x");
				FI.formations_offset3x = table.TableDescriptor.GetFieldIndex("offset3x");
				FI.formations_offset8x = table.TableDescriptor.GetFieldIndex("offset8x");
				FI.formations_offset10y = table.TableDescriptor.GetFieldIndex("offset10y");
				FI.formations_offset3y = table.TableDescriptor.GetFieldIndex("offset3y");
				FI.formations_offset4x = table.TableDescriptor.GetFieldIndex("offset4x");
				FI.formations_offset7y = table.TableDescriptor.GetFieldIndex("offset7y");
				FI.formations_offset0x = table.TableDescriptor.GetFieldIndex("offset0x");
				FI.formations_offset8y = table.TableDescriptor.GetFieldIndex("offset8y");
				FI.formations_attackers = table.TableDescriptor.GetFieldIndex("attackers");
				FI.formations_offset9x = table.TableDescriptor.GetFieldIndex("offset9x");
				FI.formations_midfielders = table.TableDescriptor.GetFieldIndex("midfielders");
				FI.formations_offset5x = table.TableDescriptor.GetFieldIndex("offset5x");
				FI.formations_offset0y = table.TableDescriptor.GetFieldIndex("offset0y");
				FI.formations_offset1x = table.TableDescriptor.GetFieldIndex("offset1x");
				FI.formations_offset4y = table.TableDescriptor.GetFieldIndex("offset4y");
				FI.formations_offset9y = table.TableDescriptor.GetFieldIndex("offset9y");
				FI.formations_offset1y = table.TableDescriptor.GetFieldIndex("offset1y");
				FI.formations_formationaudioid = table.TableDescriptor.GetFieldIndex("formationaudioid");
				FI.formations_formationname = table.TableDescriptor.GetFieldIndex("formationname");
				FI.formations_position10 = table.TableDescriptor.GetFieldIndex("position10");
				FI.formations_position6 = table.TableDescriptor.GetFieldIndex("position6");
				FI.formations_offensiverating = table.TableDescriptor.GetFieldIndex("offensiverating");
				FI.formations_position8 = table.TableDescriptor.GetFieldIndex("position8");
				FI.formations_position5 = table.TableDescriptor.GetFieldIndex("position5");
				FI.formations_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.formations_position2 = table.TableDescriptor.GetFieldIndex("position2");
				FI.formations_formationid = table.TableDescriptor.GetFieldIndex("formationid");
				FI.formations_position4 = table.TableDescriptor.GetFieldIndex("position4");
				FI.formations_position3 = table.TableDescriptor.GetFieldIndex("position3");
				FI.formations_formationfullnameid = table.TableDescriptor.GetFieldIndex("formationfullnameid");
				FI.formations_position0 = table.TableDescriptor.GetFieldIndex("position0");
				FI.formations_position9 = table.TableDescriptor.GetFieldIndex("position9");
				FI.formations_position7 = table.TableDescriptor.GetFieldIndex("position7");
				FI.formations_position1 = table.TableDescriptor.GetFieldIndex("position1");
				FI.formations_playerinstruction0 = table.TableDescriptor.GetFieldIndex("playerinstruction0");
				FI.formations_playerinstruction1 = table.TableDescriptor.GetFieldIndex("playerinstruction1");
				FI.formations_playerinstruction2 = table.TableDescriptor.GetFieldIndex("playerinstruction2");
				FI.formations_playerinstruction3 = table.TableDescriptor.GetFieldIndex("playerinstruction3");
				FI.formations_playerinstruction4 = table.TableDescriptor.GetFieldIndex("playerinstruction4");
				FI.formations_playerinstruction5 = table.TableDescriptor.GetFieldIndex("playerinstruction5");
				FI.formations_playerinstruction6 = table.TableDescriptor.GetFieldIndex("playerinstruction6");
				FI.formations_playerinstruction7 = table.TableDescriptor.GetFieldIndex("playerinstruction7");
				FI.formations_playerinstruction8 = table.TableDescriptor.GetFieldIndex("playerinstruction8");
				FI.formations_playerinstruction9 = table.TableDescriptor.GetFieldIndex("playerinstruction9");
				FI.formations_playerinstruction10 = table.TableDescriptor.GetFieldIndex("playerinstruction10");
				FI.formations_playerinstruction0_1 = table.TableDescriptor.GetFieldIndex("playerinstruction0_1");
				FI.formations_playerinstruction1_1 = table.TableDescriptor.GetFieldIndex("playerinstruction1_1");
				FI.formations_playerinstruction2_1 = table.TableDescriptor.GetFieldIndex("playerinstruction2_1");
				FI.formations_playerinstruction3_1 = table.TableDescriptor.GetFieldIndex("playerinstruction3_1");
				FI.formations_playerinstruction4_1 = table.TableDescriptor.GetFieldIndex("playerinstruction4_1");
				FI.formations_playerinstruction5_1 = table.TableDescriptor.GetFieldIndex("playerinstruction5_1");
				FI.formations_playerinstruction6_1 = table.TableDescriptor.GetFieldIndex("playerinstruction6_1");
				FI.formations_playerinstruction7_1 = table.TableDescriptor.GetFieldIndex("playerinstruction7_1");
				FI.formations_playerinstruction8_1 = table.TableDescriptor.GetFieldIndex("playerinstruction8_1");
				FI.formations_playerinstruction9_1 = table.TableDescriptor.GetFieldIndex("playerinstruction9_1");
				FI.formations_playerinstruction10_1 = table.TableDescriptor.GetFieldIndex("playerinstruction10_1");
				FI.formations_playerinstruction0_2 = table.TableDescriptor.GetFieldIndex("playerinstruction0_2");
				FI.formations_playerinstruction1_2 = table.TableDescriptor.GetFieldIndex("playerinstruction1_2");
				FI.formations_playerinstruction2_2 = table.TableDescriptor.GetFieldIndex("playerinstruction2_2");
				FI.formations_playerinstruction3_2 = table.TableDescriptor.GetFieldIndex("playerinstruction3_2");
				FI.formations_playerinstruction4_2 = table.TableDescriptor.GetFieldIndex("playerinstruction4_2");
				FI.formations_playerinstruction5_2 = table.TableDescriptor.GetFieldIndex("playerinstruction5_2");
				FI.formations_playerinstruction6_2 = table.TableDescriptor.GetFieldIndex("playerinstruction6_2");
				FI.formations_playerinstruction7_2 = table.TableDescriptor.GetFieldIndex("playerinstruction7_2");
				FI.formations_playerinstruction8_2 = table.TableDescriptor.GetFieldIndex("playerinstruction8_2");
				FI.formations_playerinstruction9_2 = table.TableDescriptor.GetFieldIndex("playerinstruction9_2");
				FI.formations_playerinstruction10_2 = table.TableDescriptor.GetFieldIndex("playerinstruction10_2");
				FI.formations_attackingdirection_0 = table.TableDescriptor.GetFieldIndex("attackingdirection_0");
				FI.formations_attackingdirection_1 = table.TableDescriptor.GetFieldIndex("attackingdirection_1");
				FI.formations_attackingdirection_2 = table.TableDescriptor.GetFieldIndex("attackingdirection_2");
				FI.formations_attackingdirection_3 = table.TableDescriptor.GetFieldIndex("attackingdirection_3");
				FI.formations_attackingdirection_4 = table.TableDescriptor.GetFieldIndex("attackingdirection_4");
				FI.formations_attackingdirection_5 = table.TableDescriptor.GetFieldIndex("attackingdirection_5");
				FI.formations_attackingdirection_6 = table.TableDescriptor.GetFieldIndex("attackingdirection_6");
				FI.formations_attackingdirection_7 = table.TableDescriptor.GetFieldIndex("attackingdirection_7");
				FI.formations_attackingdirection_8 = table.TableDescriptor.GetFieldIndex("attackingdirection_8");
				FI.formations_attackingdirection_9 = table.TableDescriptor.GetFieldIndex("attackingdirection_9");
				FI.formations_attackingdirection_10 = table.TableDescriptor.GetFieldIndex("attackingdirection_10");
				FI.formations_defensivedirection_0 = table.TableDescriptor.GetFieldIndex("defensivedirection_0");
				FI.formations_defensivedirection_1 = table.TableDescriptor.GetFieldIndex("defensivedirection_1");
				FI.formations_defensivedirection_2 = table.TableDescriptor.GetFieldIndex("defensivedirection_2");
				FI.formations_defensivedirection_3 = table.TableDescriptor.GetFieldIndex("defensivedirection_3");
				FI.formations_defensivedirection_4 = table.TableDescriptor.GetFieldIndex("defensivedirection_4");
				FI.formations_defensivedirection_5 = table.TableDescriptor.GetFieldIndex("defensivedirection_5");
				FI.formations_defensivedirection_6 = table.TableDescriptor.GetFieldIndex("defensivedirection_6");
				FI.formations_defensivedirection_7 = table.TableDescriptor.GetFieldIndex("defensivedirection_7");
				FI.formations_defensivedirection_8 = table.TableDescriptor.GetFieldIndex("defensivedirection_8");
				FI.formations_defensivedirection_9 = table.TableDescriptor.GetFieldIndex("defensivedirection_9");
				FI.formations_defensivedirection_10 = table.TableDescriptor.GetFieldIndex("defensivedirection_10");
			}
			table = fifaDb.GetTable("defaultteamdata");
			if (table != null)
			{
				FI.defaultteamdata_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.defaultteamdata_busbuildupspeed = table.TableDescriptor.GetFieldIndex("busbuildupspeed");
				FI.defaultteamdata_busdribbling = table.TableDescriptor.GetFieldIndex("busdribbling");
				FI.defaultteamdata_buspassing = table.TableDescriptor.GetFieldIndex("buspassing");
				FI.defaultteamdata_buspositioning = table.TableDescriptor.GetFieldIndex("buspositioning");
				FI.defaultteamdata_cccrossing = table.TableDescriptor.GetFieldIndex("cccrossing");
				FI.defaultteamdata_ccpassing = table.TableDescriptor.GetFieldIndex("ccpassing");
				FI.defaultteamdata_ccpositioning = table.TableDescriptor.GetFieldIndex("ccpositioning");
				FI.defaultteamdata_ccshooting = table.TableDescriptor.GetFieldIndex("ccshooting");
				FI.defaultteamdata_defaggression = table.TableDescriptor.GetFieldIndex("defaggression");
				FI.defaultteamdata_defdefenderline = table.TableDescriptor.GetFieldIndex("defdefenderline");
				FI.defaultteamdata_defmentality = table.TableDescriptor.GetFieldIndex("defmentality");
				FI.defaultteamdata_defteamwidth = table.TableDescriptor.GetFieldIndex("defteamwidth");
				FI.defaultteamdata_tacticid = table.TableDescriptor.GetFieldIndex("tacticid");
				FI.defaultteamdata_offset0x = table.TableDescriptor.GetFieldIndex("offset0x");
				FI.defaultteamdata_offset0y = table.TableDescriptor.GetFieldIndex("offset0y");
				FI.defaultteamdata_playerinstruction0_1 = table.TableDescriptor.GetFieldIndex("playerinstruction0_1");
				FI.defaultteamdata_playerinstruction0_2 = table.TableDescriptor.GetFieldIndex("playerinstruction0_2");
				FI.defaultteamdata_position0 = table.TableDescriptor.GetFieldIndex("position0");
				FI.defaultteamdata_offset1x = table.TableDescriptor.GetFieldIndex("offset1x");
				FI.defaultteamdata_offset1y = table.TableDescriptor.GetFieldIndex("offset1y");
				FI.defaultteamdata_playerinstruction1_1 = table.TableDescriptor.GetFieldIndex("playerinstruction1_1");
				FI.defaultteamdata_playerinstruction1_2 = table.TableDescriptor.GetFieldIndex("playerinstruction1_2");
				FI.defaultteamdata_position1 = table.TableDescriptor.GetFieldIndex("position1");
				FI.defaultteamdata_offset2x = table.TableDescriptor.GetFieldIndex("offset2x");
				FI.defaultteamdata_offset2y = table.TableDescriptor.GetFieldIndex("offset2y");
				FI.defaultteamdata_playerinstruction2_1 = table.TableDescriptor.GetFieldIndex("playerinstruction2_1");
				FI.defaultteamdata_playerinstruction2_2 = table.TableDescriptor.GetFieldIndex("playerinstruction2_2");
				FI.defaultteamdata_position2 = table.TableDescriptor.GetFieldIndex("position2");
				FI.defaultteamdata_offset3x = table.TableDescriptor.GetFieldIndex("offset3x");
				FI.defaultteamdata_offset3y = table.TableDescriptor.GetFieldIndex("offset3y");
				FI.defaultteamdata_playerinstruction3_1 = table.TableDescriptor.GetFieldIndex("playerinstruction3_1");
				FI.defaultteamdata_playerinstruction3_2 = table.TableDescriptor.GetFieldIndex("playerinstruction3_2");
				FI.defaultteamdata_position3 = table.TableDescriptor.GetFieldIndex("position3");
				FI.defaultteamdata_offset4x = table.TableDescriptor.GetFieldIndex("offset4x");
				FI.defaultteamdata_offset4y = table.TableDescriptor.GetFieldIndex("offset4y");
				FI.defaultteamdata_playerinstruction4_1 = table.TableDescriptor.GetFieldIndex("playerinstruction4_1");
				FI.defaultteamdata_playerinstruction4_2 = table.TableDescriptor.GetFieldIndex("playerinstruction4_2");
				FI.defaultteamdata_position4 = table.TableDescriptor.GetFieldIndex("position4");
				FI.defaultteamdata_offset5x = table.TableDescriptor.GetFieldIndex("offset5x");
				FI.defaultteamdata_offset5y = table.TableDescriptor.GetFieldIndex("offset5y");
				FI.defaultteamdata_playerinstruction5_1 = table.TableDescriptor.GetFieldIndex("playerinstruction5_1");
				FI.defaultteamdata_playerinstruction5_2 = table.TableDescriptor.GetFieldIndex("playerinstruction5_2");
				FI.defaultteamdata_position5 = table.TableDescriptor.GetFieldIndex("position5");
				FI.defaultteamdata_offset6x = table.TableDescriptor.GetFieldIndex("offset6x");
				FI.defaultteamdata_offset6y = table.TableDescriptor.GetFieldIndex("offset6y");
				FI.defaultteamdata_playerinstruction6_1 = table.TableDescriptor.GetFieldIndex("playerinstruction6_1");
				FI.defaultteamdata_playerinstruction6_2 = table.TableDescriptor.GetFieldIndex("playerinstruction6_2");
				FI.defaultteamdata_position6 = table.TableDescriptor.GetFieldIndex("position6");
				FI.defaultteamdata_offset7x = table.TableDescriptor.GetFieldIndex("offset7x");
				FI.defaultteamdata_offset7y = table.TableDescriptor.GetFieldIndex("offset7y");
				FI.defaultteamdata_playerinstruction7_1 = table.TableDescriptor.GetFieldIndex("playerinstruction7_1");
				FI.defaultteamdata_playerinstruction7_2 = table.TableDescriptor.GetFieldIndex("playerinstruction7_2");
				FI.defaultteamdata_position7 = table.TableDescriptor.GetFieldIndex("position7");
				FI.defaultteamdata_offset8x = table.TableDescriptor.GetFieldIndex("offset8x");
				FI.defaultteamdata_offset8y = table.TableDescriptor.GetFieldIndex("offset8y");
				FI.defaultteamdata_playerinstruction8_1 = table.TableDescriptor.GetFieldIndex("playerinstruction8_1");
				FI.defaultteamdata_playerinstruction8_2 = table.TableDescriptor.GetFieldIndex("playerinstruction8_2");
				FI.defaultteamdata_position8 = table.TableDescriptor.GetFieldIndex("position8");
				FI.defaultteamdata_offset9x = table.TableDescriptor.GetFieldIndex("offset9x");
				FI.defaultteamdata_offset9y = table.TableDescriptor.GetFieldIndex("offset9y");
				FI.defaultteamdata_playerinstruction9_1 = table.TableDescriptor.GetFieldIndex("playerinstruction9_1");
				FI.defaultteamdata_playerinstruction9_2 = table.TableDescriptor.GetFieldIndex("playerinstruction9_2");
				FI.defaultteamdata_position9 = table.TableDescriptor.GetFieldIndex("position9");
				FI.defaultteamdata_offset10x = table.TableDescriptor.GetFieldIndex("offset10x");
				FI.defaultteamdata_playerinstruction10_1 = table.TableDescriptor.GetFieldIndex("playerinstruction10_1");
				FI.defaultteamdata_playerinstruction10_2 = table.TableDescriptor.GetFieldIndex("playerinstruction10_2");
				FI.defaultteamdata_offset10y = table.TableDescriptor.GetFieldIndex("offset10y");
				FI.defaultteamdata_position10 = table.TableDescriptor.GetFieldIndex("position10");
			}
			table = fifaDb.GetTable("default_teamsheets");
			if (table != null)
			{
				FI.default_teamsheets_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.default_teamsheets_tacticid = table.TableDescriptor.GetFieldIndex("tacticid");
				FI.default_teamsheets_busbuildupspeed = table.TableDescriptor.GetFieldIndex("busbuildupspeed");
				FI.default_teamsheets_busdribbling = table.TableDescriptor.GetFieldIndex("busdribbling");
				FI.default_teamsheets_buspassing = table.TableDescriptor.GetFieldIndex("buspassing");
				FI.default_teamsheets_buspositioning = table.TableDescriptor.GetFieldIndex("buspositioning");
				FI.default_teamsheets_cccrossing = table.TableDescriptor.GetFieldIndex("cccrossing");
				FI.default_teamsheets_ccpassing = table.TableDescriptor.GetFieldIndex("ccpassing");
				FI.default_teamsheets_ccpositioning = table.TableDescriptor.GetFieldIndex("ccpositioning");
				FI.default_teamsheets_ccshooting = table.TableDescriptor.GetFieldIndex("ccshooting");
				FI.default_teamsheets_defaggression = table.TableDescriptor.GetFieldIndex("defaggression");
				FI.default_teamsheets_defdefenderline = table.TableDescriptor.GetFieldIndex("defdefenderline");
				FI.default_teamsheets_defmentality = table.TableDescriptor.GetFieldIndex("defmentality");
				FI.default_teamsheets_defteamwidth = table.TableDescriptor.GetFieldIndex("defteamwidth");
				FI.default_teamsheets_offset0x = table.TableDescriptor.GetFieldIndex("offset0x");
				FI.default_teamsheets_offset0y = table.TableDescriptor.GetFieldIndex("offset0y");
				FI.default_teamsheets_playerinstruction0_1 = table.TableDescriptor.GetFieldIndex("playerinstruction0_1");
				FI.default_teamsheets_playerinstruction0_2 = table.TableDescriptor.GetFieldIndex("playerinstruction0_2");
				FI.default_teamsheets_position0 = table.TableDescriptor.GetFieldIndex("position0");
				FI.default_teamsheets_offset1x = table.TableDescriptor.GetFieldIndex("offset1x");
				FI.default_teamsheets_offset1y = table.TableDescriptor.GetFieldIndex("offset1y");
				FI.default_teamsheets_playerinstruction1_1 = table.TableDescriptor.GetFieldIndex("playerinstruction1_1");
				FI.default_teamsheets_playerinstruction1_2 = table.TableDescriptor.GetFieldIndex("playerinstruction1_2");
				FI.default_teamsheets_position1 = table.TableDescriptor.GetFieldIndex("position1");
				FI.default_teamsheets_offset2x = table.TableDescriptor.GetFieldIndex("offset2x");
				FI.default_teamsheets_offset2y = table.TableDescriptor.GetFieldIndex("offset2y");
				FI.default_teamsheets_playerinstruction2_1 = table.TableDescriptor.GetFieldIndex("playerinstruction2_1");
				FI.default_teamsheets_playerinstruction2_2 = table.TableDescriptor.GetFieldIndex("playerinstruction2_2");
				FI.default_teamsheets_position2 = table.TableDescriptor.GetFieldIndex("position2");
				FI.default_teamsheets_offset3x = table.TableDescriptor.GetFieldIndex("offset3x");
				FI.default_teamsheets_offset3y = table.TableDescriptor.GetFieldIndex("offset3y");
				FI.default_teamsheets_playerinstruction3_1 = table.TableDescriptor.GetFieldIndex("playerinstruction3_1");
				FI.default_teamsheets_playerinstruction3_2 = table.TableDescriptor.GetFieldIndex("playerinstruction3_2");
				FI.default_teamsheets_position3 = table.TableDescriptor.GetFieldIndex("position3");
				FI.default_teamsheets_offset4x = table.TableDescriptor.GetFieldIndex("offset4x");
				FI.default_teamsheets_offset4y = table.TableDescriptor.GetFieldIndex("offset4y");
				FI.default_teamsheets_playerinstruction4_1 = table.TableDescriptor.GetFieldIndex("playerinstruction4_1");
				FI.default_teamsheets_playerinstruction4_2 = table.TableDescriptor.GetFieldIndex("playerinstruction4_2");
				FI.default_teamsheets_position4 = table.TableDescriptor.GetFieldIndex("position4");
				FI.default_teamsheets_offset5x = table.TableDescriptor.GetFieldIndex("offset5x");
				FI.default_teamsheets_offset5y = table.TableDescriptor.GetFieldIndex("offset5y");
				FI.default_teamsheets_playerinstruction5_1 = table.TableDescriptor.GetFieldIndex("playerinstruction5_1");
				FI.default_teamsheets_playerinstruction5_2 = table.TableDescriptor.GetFieldIndex("playerinstruction5_2");
				FI.default_teamsheets_position5 = table.TableDescriptor.GetFieldIndex("position5");
				FI.default_teamsheets_offset6x = table.TableDescriptor.GetFieldIndex("offset6x");
				FI.default_teamsheets_offset6y = table.TableDescriptor.GetFieldIndex("offset6y");
				FI.default_teamsheets_playerinstruction6_1 = table.TableDescriptor.GetFieldIndex("playerinstruction6_1");
				FI.default_teamsheets_playerinstruction6_2 = table.TableDescriptor.GetFieldIndex("playerinstruction6_2");
				FI.default_teamsheets_position6 = table.TableDescriptor.GetFieldIndex("position6");
				FI.default_teamsheets_offset7x = table.TableDescriptor.GetFieldIndex("offset7x");
				FI.default_teamsheets_offset7y = table.TableDescriptor.GetFieldIndex("offset7y");
				FI.default_teamsheets_playerinstruction7_1 = table.TableDescriptor.GetFieldIndex("playerinstruction7_1");
				FI.default_teamsheets_playerinstruction7_2 = table.TableDescriptor.GetFieldIndex("playerinstruction7_2");
				FI.default_teamsheets_position7 = table.TableDescriptor.GetFieldIndex("position7");
				FI.default_teamsheets_offset8x = table.TableDescriptor.GetFieldIndex("offset8x");
				FI.default_teamsheets_offset8y = table.TableDescriptor.GetFieldIndex("offset8y");
				FI.default_teamsheets_playerinstruction8_1 = table.TableDescriptor.GetFieldIndex("playerinstruction8_1");
				FI.default_teamsheets_playerinstruction8_2 = table.TableDescriptor.GetFieldIndex("playerinstruction8_2");
				FI.default_teamsheets_position8 = table.TableDescriptor.GetFieldIndex("position8");
				FI.default_teamsheets_offset9x = table.TableDescriptor.GetFieldIndex("offset9x");
				FI.default_teamsheets_offset9y = table.TableDescriptor.GetFieldIndex("offset9y");
				FI.default_teamsheets_playerinstruction9_1 = table.TableDescriptor.GetFieldIndex("playerinstruction9_1");
				FI.default_teamsheets_playerinstruction9_2 = table.TableDescriptor.GetFieldIndex("playerinstruction9_2");
				FI.default_teamsheets_position9 = table.TableDescriptor.GetFieldIndex("position9");
				FI.default_teamsheets_offset10x = table.TableDescriptor.GetFieldIndex("offset10x");
				FI.default_teamsheets_offset10y = table.TableDescriptor.GetFieldIndex("offset10y");
				FI.default_teamsheets_playerinstruction10_1 = table.TableDescriptor.GetFieldIndex("playerinstruction10_1");
				FI.default_teamsheets_playerinstruction10_2 = table.TableDescriptor.GetFieldIndex("playerinstruction10_2");
				FI.default_teamsheets_position10 = table.TableDescriptor.GetFieldIndex("position10");
				FI.default_teamsheets_playerid0 = table.TableDescriptor.GetFieldIndex("playerid0");
				FI.default_teamsheets_playerid1 = table.TableDescriptor.GetFieldIndex("playerid1");
				FI.default_teamsheets_playerid2 = table.TableDescriptor.GetFieldIndex("playerid2");
				FI.default_teamsheets_playerid3 = table.TableDescriptor.GetFieldIndex("playerid3");
				FI.default_teamsheets_playerid4 = table.TableDescriptor.GetFieldIndex("playerid4");
				FI.default_teamsheets_playerid5 = table.TableDescriptor.GetFieldIndex("playerid5");
				FI.default_teamsheets_playerid6 = table.TableDescriptor.GetFieldIndex("playerid6");
				FI.default_teamsheets_playerid7 = table.TableDescriptor.GetFieldIndex("playerid7");
				FI.default_teamsheets_playerid8 = table.TableDescriptor.GetFieldIndex("playerid8");
				FI.default_teamsheets_playerid9 = table.TableDescriptor.GetFieldIndex("playerid9");
				FI.default_teamsheets_playerid10 = table.TableDescriptor.GetFieldIndex("playerid10");
				FI.default_teamsheets_playerid11 = table.TableDescriptor.GetFieldIndex("playerid11");
				FI.default_teamsheets_playerid12 = table.TableDescriptor.GetFieldIndex("playerid12");
				FI.default_teamsheets_playerid13 = table.TableDescriptor.GetFieldIndex("playerid13");
				FI.default_teamsheets_playerid14 = table.TableDescriptor.GetFieldIndex("playerid14");
				FI.default_teamsheets_playerid15 = table.TableDescriptor.GetFieldIndex("playerid15");
				FI.default_teamsheets_playerid16 = table.TableDescriptor.GetFieldIndex("playerid16");
				FI.default_teamsheets_playerid17 = table.TableDescriptor.GetFieldIndex("playerid17");
				FI.default_teamsheets_playerid18 = table.TableDescriptor.GetFieldIndex("playerid18");
				FI.default_teamsheets_playerid19 = table.TableDescriptor.GetFieldIndex("playerid19");
				FI.default_teamsheets_playerid20 = table.TableDescriptor.GetFieldIndex("playerid20");
				FI.default_teamsheets_playerid21 = table.TableDescriptor.GetFieldIndex("playerid21");
				FI.default_teamsheets_playerid22 = table.TableDescriptor.GetFieldIndex("playerid22");
				FI.default_teamsheets_playerid23 = table.TableDescriptor.GetFieldIndex("playerid23");
				FI.default_teamsheets_playerid24 = table.TableDescriptor.GetFieldIndex("playerid24");
				FI.default_teamsheets_playerid25 = table.TableDescriptor.GetFieldIndex("playerid25");
				FI.default_teamsheets_playerid26 = table.TableDescriptor.GetFieldIndex("playerid26");
				FI.default_teamsheets_playerid27 = table.TableDescriptor.GetFieldIndex("playerid27");
				FI.default_teamsheets_playerid28 = table.TableDescriptor.GetFieldIndex("playerid28");
				FI.default_teamsheets_playerid29 = table.TableDescriptor.GetFieldIndex("playerid29");
				FI.default_teamsheets_playerid30 = table.TableDescriptor.GetFieldIndex("playerid30");
				FI.default_teamsheets_playerid31 = table.TableDescriptor.GetFieldIndex("playerid31");
				FI.default_teamsheets_playerid32 = table.TableDescriptor.GetFieldIndex("playerid32");
				FI.default_teamsheets_playerid33 = table.TableDescriptor.GetFieldIndex("playerid33");
				FI.default_teamsheets_playerid34 = table.TableDescriptor.GetFieldIndex("playerid34");
				FI.default_teamsheets_playerid35 = table.TableDescriptor.GetFieldIndex("playerid35");
				FI.default_teamsheets_playerid36 = table.TableDescriptor.GetFieldIndex("playerid36");
				FI.default_teamsheets_playerid37 = table.TableDescriptor.GetFieldIndex("playerid37");
				FI.default_teamsheets_playerid38 = table.TableDescriptor.GetFieldIndex("playerid38");
				FI.default_teamsheets_playerid39 = table.TableDescriptor.GetFieldIndex("playerid39");
				FI.default_teamsheets_playerid40 = table.TableDescriptor.GetFieldIndex("playerid40");
				FI.default_teamsheets_playerid41 = table.TableDescriptor.GetFieldIndex("playerid41");
				FI.default_teamsheets_freekicktakerid = table.TableDescriptor.GetFieldIndex("freekicktakerid");
				FI.default_teamsheets_leftcornerkicktakerid = table.TableDescriptor.GetFieldIndex("leftcornerkicktakerid");
				FI.default_teamsheets_leftfreekicktakerid = table.TableDescriptor.GetFieldIndex("leftfreekicktakerid");
				FI.default_teamsheets_longkicktakerid = table.TableDescriptor.GetFieldIndex("longkicktakerid");
				FI.default_teamsheets_captainid = table.TableDescriptor.GetFieldIndex("captainid");
				FI.default_teamsheets_rightcornerkicktakerid = table.TableDescriptor.GetFieldIndex("rightcornerkicktakerid");
				FI.default_teamsheets_rightfreekicktakerid = table.TableDescriptor.GetFieldIndex("rightfreekicktakerid");
				FI.default_teamsheets_penaltytakerid = table.TableDescriptor.GetFieldIndex("penaltytakerid");
			}
			table = fifaDb.GetTable("fieldpositionboundingboxes");
			if (table != null)
			{
				FI.fieldpositionboundingboxes_pointy1 = table.TableDescriptor.GetFieldIndex("pointy1");
				FI.fieldpositionboundingboxes_pointx1 = table.TableDescriptor.GetFieldIndex("pointx1");
				FI.fieldpositionboundingboxes_pointy0 = table.TableDescriptor.GetFieldIndex("pointy0");
				FI.fieldpositionboundingboxes_pointy3 = table.TableDescriptor.GetFieldIndex("pointy3");
				FI.fieldpositionboundingboxes_pointy2 = table.TableDescriptor.GetFieldIndex("pointy2");
				FI.fieldpositionboundingboxes_pointx0 = table.TableDescriptor.GetFieldIndex("pointx0");
				FI.fieldpositionboundingboxes_pointx3 = table.TableDescriptor.GetFieldIndex("pointx3");
				FI.fieldpositionboundingboxes_pointx2 = table.TableDescriptor.GetFieldIndex("pointx2");
				FI.fieldpositionboundingboxes_positionid = table.TableDescriptor.GetFieldIndex("positionid");
			}
			table = fifaDb.GetTable("editedplayernames");
			if (table != null)
			{
				FI.editedplayernames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.editedplayernames_commonname = table.TableDescriptor.GetFieldIndex("commonname");
				FI.editedplayernames_playerjerseyname = table.TableDescriptor.GetFieldIndex("playerjerseyname");
				FI.editedplayernames_surname = table.TableDescriptor.GetFieldIndex("surname");
				FI.editedplayernames_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("competition");
			if (table != null)
			{
				FI.competition_ballid = table.TableDescriptor.GetFieldIndex("ballid");
				FI.competition_competitionid = table.TableDescriptor.GetFieldIndex("competitionid");
			}
			table = fifaDb.GetTable("career_lastnames");
			if (table != null)
			{
				FI.career_lastnames_lastname = table.TableDescriptor.GetFieldIndex("lastname");
				FI.career_lastnames_lastnameid = table.TableDescriptor.GetFieldIndex("lastnameid");
				FI.career_lastnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("career_firstnames");
			if (table != null)
			{
				FI.career_firstnames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.career_firstnames_firstnameid = table.TableDescriptor.GetFieldIndex("firstnameid");
				FI.career_firstnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("career_commonnames");
			if (table != null)
			{
				FI.career_commonnames_firstname = table.TableDescriptor.GetFieldIndex("firstname");
				FI.career_commonnames_lastname = table.TableDescriptor.GetFieldIndex("lastname");
				FI.career_commonnames_commonnameid = table.TableDescriptor.GetFieldIndex("commonnameid");
				FI.career_commonnames_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("attributeprefpositionformula");
			if (table != null)
			{
				FI.attributeprefpositionformula_attribute = table.TableDescriptor.GetFieldIndex("attribute");
				FI.attributeprefpositionformula_position = table.TableDescriptor.GetFieldIndex("position");
				FI.attributeprefpositionformula_percentage = table.TableDescriptor.GetFieldIndex("percentage");
			}
			table = fifaDb.GetTable("audionation");
			if (table != null)
			{
				FI.audionation_nationid = table.TableDescriptor.GetFieldIndex("nationid");
				FI.audionation_PALanguageIndex = table.TableDescriptor.GetFieldIndex("palanguageindex");
				FI.audionation_DefaultCommLang = table.TableDescriptor.GetFieldIndex("defaultcommlang");
				FI.audionation_CrowdBedsRegionIndex = table.TableDescriptor.GetFieldIndex("crowdbedsregionindex");
				FI.audionation_WhistlesRegionIndex = table.TableDescriptor.GetFieldIndex("whistlesregionindex");
				FI.audionation_AmbienceRegionIndex = table.TableDescriptor.GetFieldIndex("ambienceregionindex");
				FI.audionation_PlayerCallPatchBankIndex = table.TableDescriptor.GetFieldIndex("playercallpatchbankindex");
				FI.audionation_HecklesRegionIndex = table.TableDescriptor.GetFieldIndex("hecklesregionindex");
				FI.audionation_ChantRegionIndex = table.TableDescriptor.GetFieldIndex("chantregionindex");
				FI.audionation_TeamCanWhistleIndex = table.TableDescriptor.GetFieldIndex("teamcanwhistleindex");
				FI.audionation_ReactionsRegionIndex = table.TableDescriptor.GetFieldIndex("reactionsregionindex");
			}
			table = fifaDb.GetTable("audiostadium");
			if (table != null)
			{
				FI.audiostadium_stadiumid = table.TableDescriptor.GetFieldIndex("stadiumid");
				FI.audiostadium_stadiumpalanguageindex = table.TableDescriptor.GetFieldIndex("stadiumpalanguageindex");
			}
			table = fifaDb.GetTable("career_boardoutcomes");
			if (table != null)
			{
				FI.career_boardoutcomes_outcome3 = table.TableDescriptor.GetFieldIndex("outcome3");
				FI.career_boardoutcomes_outcome4 = table.TableDescriptor.GetFieldIndex("outcome4");
				FI.career_boardoutcomes_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.career_boardoutcomes_outcome1 = table.TableDescriptor.GetFieldIndex("outcome1");
				FI.career_boardoutcomes_outcome2 = table.TableDescriptor.GetFieldIndex("outcome2");
				FI.career_boardoutcomes_outcome5 = table.TableDescriptor.GetFieldIndex("outcome5");
			}
			table = fifaDb.GetTable("career_leagueballs");
			if (table != null)
			{
				FI.career_leagueballs_balltype = table.TableDescriptor.GetFieldIndex("balltype");
				FI.career_leagueballs_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
			}
			table = fifaDb.GetTable("clubcommentarynames");
			if (table != null)
			{
				FI.clubcommentarynames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.clubcommentarynames_commentarystartingletter = table.TableDescriptor.GetFieldIndex("commentarystartingletter");
			}
			table = fifaDb.GetTable("commentarynames");
			if (table != null)
			{
				FI.commentarynames_commentarystring = table.TableDescriptor.GetFieldIndex("commentarystring");
				FI.commentarynames_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.commentarynames_commentarystartingletter = table.TableDescriptor.GetFieldIndex("commentarystartingletter");
				FI.commentarynames_commentarypreview = table.TableDescriptor.GetFieldIndex("commentarypreview");
			}
			table = fifaDb.GetTable("cz_assets");
			if (table != null)
			{
				FI.cz_assets_crestid = table.TableDescriptor.GetFieldIndex("crestid");
				FI.cz_assets_dbid = table.TableDescriptor.GetFieldIndex("dbid");
				FI.cz_assets_publishdate = table.TableDescriptor.GetFieldIndex("publishdate");
				FI.cz_assets_rating = table.TableDescriptor.GetFieldIndex("rating");
				FI.cz_assets_kitid = table.TableDescriptor.GetFieldIndex("kitid");
				FI.cz_assets_xms_media_id = table.TableDescriptor.GetFieldIndex("xms_media_id");
				FI.cz_assets_type = table.TableDescriptor.GetFieldIndex("type");
				FI.cz_assets_author = table.TableDescriptor.GetFieldIndex("author");
				FI.cz_assets_assetname = table.TableDescriptor.GetFieldIndex("assetname");
				FI.cz_assets_assetyear = table.TableDescriptor.GetFieldIndex("assetyear");
				FI.cz_assets_playerposition = table.TableDescriptor.GetFieldIndex("playerposition");
				FI.cz_assets_version = table.TableDescriptor.GetFieldIndex("version");
			}
			table = fifaDb.GetTable("cz_teams");
			if (table != null)
			{
				FI.cz_teams_hascrestimage = table.TableDescriptor.GetFieldIndex("hascrestimage");
				FI.cz_teams_hassponsorimage = table.TableDescriptor.GetFieldIndex("hassponsorimage");
				FI.cz_teams_teamabbrev3 = table.TableDescriptor.GetFieldIndex("teamabbrev3");
				FI.cz_teams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.cz_teams_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
			}
			table = fifaDb.GetTable("cz_teamkits");
			if (table != null)
			{
				FI.cz_teamkits_hotspotjerseyfrontsponsorr = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorr");
				FI.cz_teamkits_hotspotjerseyfrontsponsorb = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorb");
				FI.cz_teamkits_hotspotjerseyfrontsponsorl = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsorl");
				FI.cz_teamkits_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.cz_teamkits_hotspotjerseyfrontsponsort = table.TableDescriptor.GetFieldIndex("hotspotjerseyfrontsponsort");
				FI.cz_teamkits_sockscolortertr = table.TableDescriptor.GetFieldIndex("sockscolortertr");
				FI.cz_teamkits_jerseycolorprimg = table.TableDescriptor.GetFieldIndex("jerseycolorprimg");
				FI.cz_teamkits_jerseycolortertg = table.TableDescriptor.GetFieldIndex("jerseycolortertg");
				FI.cz_teamkits_sponsorcolourg = table.TableDescriptor.GetFieldIndex("sponsorcolourg");
				FI.cz_teamkits_sockscolorsecb = table.TableDescriptor.GetFieldIndex("sockscolorsecb");
				FI.cz_teamkits_sponsorcolourr = table.TableDescriptor.GetFieldIndex("sponsorcolourr");
				FI.cz_teamkits_sockscolortertg = table.TableDescriptor.GetFieldIndex("sockscolortertg");
				FI.cz_teamkits_shortcolorsecb = table.TableDescriptor.GetFieldIndex("shortcolorsecb");
				FI.cz_teamkits_shortcolortertg = table.TableDescriptor.GetFieldIndex("shortcolortertg");
				FI.cz_teamkits_numberfonttype = table.TableDescriptor.GetFieldIndex("numberfonttype");
				FI.cz_teamkits_shortcolorprimb = table.TableDescriptor.GetFieldIndex("shortcolorprimb");
				FI.cz_teamkits_jerseycolorsecr = table.TableDescriptor.GetFieldIndex("jerseycolorsecr");
				FI.cz_teamkits_jerseynamefonttype = table.TableDescriptor.GetFieldIndex("jerseynamefonttype");
				FI.cz_teamkits_jerseynamelayouttype = table.TableDescriptor.GetFieldIndex("jerseynamelayouttype");
				FI.cz_teamkits_jerseycolortertb = table.TableDescriptor.GetFieldIndex("jerseycolortertb");
				FI.cz_teamkits_shortsnumbercolor = table.TableDescriptor.GetFieldIndex("shortsnumbercolor");
				FI.cz_teamkits_jerseyshapestyle = table.TableDescriptor.GetFieldIndex("jerseyshapestyle");
				FI.cz_teamkits_shortcolortertr = table.TableDescriptor.GetFieldIndex("shortcolortertr");
				FI.cz_teamkits_shortcolorsecr = table.TableDescriptor.GetFieldIndex("shortcolorsecr");
				FI.cz_teamkits_jerseynamecolorg = table.TableDescriptor.GetFieldIndex("jerseynamecolorg");
				FI.cz_teamkits_jerseycolorprimr = table.TableDescriptor.GetFieldIndex("jerseycolorprimr");
				FI.cz_teamkits_sponsorcolourb = table.TableDescriptor.GetFieldIndex("sponsorcolourb");
				FI.cz_teamkits_sockscolorsecg = table.TableDescriptor.GetFieldIndex("sockscolorsecg");
				FI.cz_teamkits_jerseycolorsecb = table.TableDescriptor.GetFieldIndex("jerseycolorsecb");
				FI.cz_teamkits_sockscolorprimg = table.TableDescriptor.GetFieldIndex("sockscolorprimg");
				FI.cz_teamkits_shortcolorprimr = table.TableDescriptor.GetFieldIndex("shortcolorprimr");
				FI.cz_teamkits_jerseycolortertr = table.TableDescriptor.GetFieldIndex("jerseycolortertr");
				FI.cz_teamkits_shortcolorsecg = table.TableDescriptor.GetFieldIndex("shortcolorsecg");
				FI.cz_teamkits_jerseycolorprimb = table.TableDescriptor.GetFieldIndex("jerseycolorprimb");
				FI.cz_teamkits_sockscolorprimr = table.TableDescriptor.GetFieldIndex("sockscolorprimr");
				FI.cz_teamkits_sockscolorsecr = table.TableDescriptor.GetFieldIndex("sockscolorsecr");
				FI.cz_teamkits_shortcolortertb = table.TableDescriptor.GetFieldIndex("shortcolortertb");
				FI.cz_teamkits_jerseynamecolorr = table.TableDescriptor.GetFieldIndex("jerseynamecolorr");
				FI.cz_teamkits_numbercolor = table.TableDescriptor.GetFieldIndex("numbercolor");
				FI.cz_teamkits_sockscolorprimb = table.TableDescriptor.GetFieldIndex("sockscolorprimb");
				FI.cz_teamkits_jerseycolorsecg = table.TableDescriptor.GetFieldIndex("jerseycolorsecg");
				FI.cz_teamkits_shortsnumberfonttype = table.TableDescriptor.GetFieldIndex("shortsnumberfonttype");
				FI.cz_teamkits_jerseynamecolorb = table.TableDescriptor.GetFieldIndex("jerseynamecolorb");
				FI.cz_teamkits_shortcolorprimg = table.TableDescriptor.GetFieldIndex("shortcolorprimg");
				FI.cz_teamkits_sockscolortertb = table.TableDescriptor.GetFieldIndex("sockscolortertb");
				FI.cz_teamkits_jerseybacknamefontcase = table.TableDescriptor.GetFieldIndex("jerseybacknamefontcase");
				FI.cz_teamkits_hassponsor = table.TableDescriptor.GetFieldIndex("hassponsor");
				FI.cz_teamkits_jerseybacknameplacementcode = table.TableDescriptor.GetFieldIndex("jerseybacknameplacementcode");
				FI.cz_teamkits_artificialkey = table.TableDescriptor.GetFieldIndex("artificialkey");
				FI.cz_teamkits_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.cz_teamkits_kitid = table.TableDescriptor.GetFieldIndex("kitid");
				FI.cz_teamkits_kittypeid = table.TableDescriptor.GetFieldIndex("kittypeid");
			}
			table = fifaDb.GetTable("cz_players");
			if (table != null)
			{
				FI.cz_players_assetid = table.TableDescriptor.GetFieldIndex("assetid");
				FI.cz_players_commentaryid = table.TableDescriptor.GetFieldIndex("commentaryid");
				FI.cz_players_playerid = table.TableDescriptor.GetFieldIndex("playerid");
			}
			table = fifaDb.GetTable("cz_leagues");
			if (table != null)
			{
				FI.cz_leagues_overlaybgcolour3r = table.TableDescriptor.GetFieldIndex("overlaybgcolour3r");
				FI.cz_leagues_tournamentballid = table.TableDescriptor.GetFieldIndex("tournamentballid");
				FI.cz_leagues_overlaytextcolour3r = table.TableDescriptor.GetFieldIndex("overlaytextcolour3r");
				FI.cz_leagues_overlaytextcolour1g = table.TableDescriptor.GetFieldIndex("overlaytextcolour1g");
				FI.cz_leagues_overlaytextcolour3b = table.TableDescriptor.GetFieldIndex("overlaytextcolour3b");
				FI.cz_leagues_overlaybgcolour1g = table.TableDescriptor.GetFieldIndex("overlaybgcolour1g");
				FI.cz_leagues_championcupslotallotment = table.TableDescriptor.GetFieldIndex("championcupslotallotment");
				FI.cz_leagues_overlaybgcolour3b = table.TableDescriptor.GetFieldIndex("overlaybgcolour3b");
				FI.cz_leagues_finalstadiumid = table.TableDescriptor.GetFieldIndex("finalstadiumid");
				FI.cz_leagues_overlaytextcolour2b = table.TableDescriptor.GetFieldIndex("overlaytextcolour2b");
				FI.cz_leagues_overlaybgcolour1r = table.TableDescriptor.GetFieldIndex("overlaybgcolour1r");
				FI.cz_leagues_overlaybgcolour2b = table.TableDescriptor.GetFieldIndex("overlaybgcolour2b");
				FI.cz_leagues_overlaytextcolour1r = table.TableDescriptor.GetFieldIndex("overlaytextcolour1r");
				FI.cz_leagues_overlaytextcolour3g = table.TableDescriptor.GetFieldIndex("overlaytextcolour3g");
				FI.cz_leagues_overlaytextcolour1b = table.TableDescriptor.GetFieldIndex("overlaytextcolour1b");
				FI.cz_leagues_overlaybgcolour3g = table.TableDescriptor.GetFieldIndex("overlaybgcolour3g");
				FI.cz_leagues_overlaybgcolour1b = table.TableDescriptor.GetFieldIndex("overlaybgcolour1b");
				FI.cz_leagues_overlaybgcolour2r = table.TableDescriptor.GetFieldIndex("overlaybgcolour2r");
				FI.cz_leagues_overlaytextcolour2g = table.TableDescriptor.GetFieldIndex("overlaytextcolour2g");
				FI.cz_leagues_eurocupslotallotment = table.TableDescriptor.GetFieldIndex("eurocupslotallotment");
				FI.cz_leagues_overlaytextcolour2r = table.TableDescriptor.GetFieldIndex("overlaytextcolour2r");
				FI.cz_leagues_overlaybgcolour2g = table.TableDescriptor.GetFieldIndex("overlaybgcolour2g");
				FI.cz_leagues_leaguedescription = table.TableDescriptor.GetFieldIndex("leaguedescription");
				FI.cz_leagues_leaguetype = table.TableDescriptor.GetFieldIndex("leaguetype");
				FI.cz_leagues_numteams = table.TableDescriptor.GetFieldIndex("numteams");
				FI.cz_leagues_trophyid = table.TableDescriptor.GetFieldIndex("trophyid");
				FI.cz_leagues_teamadvancingpergroup = table.TableDescriptor.GetFieldIndex("teamadvancingpergroup");
				FI.cz_leagues_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.cz_leagues_fixturevsgroup = table.TableDescriptor.GetFieldIndex("fixturevsgroup");
				FI.cz_leagues_teampergroup = table.TableDescriptor.GetFieldIndex("teampergroup");
				FI.cz_leagues_finalmatchlegs = table.TableDescriptor.GetFieldIndex("finalmatchlegs");
				FI.cz_leagues_fixturevseachteam = table.TableDescriptor.GetFieldIndex("fixturevseachteam");
				FI.cz_leagues_subonbench = table.TableDescriptor.GetFieldIndex("subonbench");
			}
			table = fifaDb.GetTable("fce_activeteams");
			if (table != null)
			{
				FI.fce_activeteams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_activeteams_userid = table.TableDescriptor.GetFieldIndex("userid");
			}
			table = fifaDb.GetTable("fce_weathersettings");
			if (table != null)
			{
				FI.fce_weathersettings_weatherid = table.TableDescriptor.GetFieldIndex("weatherid");
				FI.fce_weathersettings_rainpct = table.TableDescriptor.GetFieldIndex("rainpct");
				FI.fce_weathersettings_snowpct = table.TableDescriptor.GetFieldIndex("snowpct");
				FI.fce_weathersettings_clearpct = table.TableDescriptor.GetFieldIndex("clearpct");
				FI.fce_weathersettings_quarter = table.TableDescriptor.GetFieldIndex("quarter");
				FI.fce_weathersettings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_weathersettings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_statistics");
			if (table != null)
			{
				FI.fce_statistics_goals = table.TableDescriptor.GetFieldIndex("goals");
				FI.fce_statistics_saves = table.TableDescriptor.GetFieldIndex("saves");
				FI.fce_statistics_shots = table.TableDescriptor.GetFieldIndex("shots");
				FI.fce_statistics_goalsconceded = table.TableDescriptor.GetFieldIndex("goalsconceded");
				FI.fce_statistics_totalreds = table.TableDescriptor.GetFieldIndex("totalreds");
				FI.fce_statistics_manofmatch = table.TableDescriptor.GetFieldIndex("manofmatch");
				FI.fce_statistics_minutes = table.TableDescriptor.GetFieldIndex("minutes");
				FI.fce_statistics_appearances = table.TableDescriptor.GetFieldIndex("appearances");
				FI.fce_statistics_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_statistics_assists = table.TableDescriptor.GetFieldIndex("assists");
				FI.fce_statistics_matchratings = table.TableDescriptor.GetFieldIndex("matchratings");
				FI.fce_statistics_cleansheets = table.TableDescriptor.GetFieldIndex("cleansheets");
				FI.fce_statistics_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_statistics_totalyellows = table.TableDescriptor.GetFieldIndex("totalyellows");
				FI.fce_statistics_statisticsid = table.TableDescriptor.GetFieldIndex("statisticsid");
				FI.fce_statistics_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.fce_statistics_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_standings");
			if (table != null)
			{
				FI.fce_standings_homegoalsfor = table.TableDescriptor.GetFieldIndex("homegoalsfor");
				FI.fce_standings_teamindex = table.TableDescriptor.GetFieldIndex("teamindex");
				FI.fce_standings_standingsid = table.TableDescriptor.GetFieldIndex("standingsid");
				FI.fce_standings_homegoalsagainst = table.TableDescriptor.GetFieldIndex("homegoalsagainst");
				FI.fce_standings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_standings_homewins = table.TableDescriptor.GetFieldIndex("homewins");
				FI.fce_standings_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_standings_awaywins = table.TableDescriptor.GetFieldIndex("awaywins");
				FI.fce_standings_points = table.TableDescriptor.GetFieldIndex("points");
				FI.fce_standings_awaygoalsfor = table.TableDescriptor.GetFieldIndex("awaygoalsfor");
				FI.fce_standings_homelosses = table.TableDescriptor.GetFieldIndex("homelosses");
				FI.fce_standings_awaygoalsagainst = table.TableDescriptor.GetFieldIndex("awaygoalsagainst");
				FI.fce_standings_awaylosses = table.TableDescriptor.GetFieldIndex("awaylosses");
				FI.fce_standings_awaydraws = table.TableDescriptor.GetFieldIndex("awaydraws");
				FI.fce_standings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_standings_homedraws = table.TableDescriptor.GetFieldIndex("homedraws");
			}
			table = fifaDb.GetTable("fce_settings");
			if (table != null)
			{
				FI.fce_settings_settingvalue = table.TableDescriptor.GetFieldIndex("settingvalue");
				FI.fce_settings_settingenumid = table.TableDescriptor.GetFieldIndex("settingenumid");
				FI.fce_settings_settingid = table.TableDescriptor.GetFieldIndex("settingid");
				FI.fce_settings_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_settings_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_stageadvance");
			if (table != null)
			{
				FI.fce_stageadvance_actiondate = table.TableDescriptor.GetFieldIndex("actiondate");
				FI.fce_stageadvance_active = table.TableDescriptor.GetFieldIndex("active");
				FI.fce_stageadvance_stageindex = table.TableDescriptor.GetFieldIndex("stageindex");
				FI.fce_stageadvance_randomnumber = table.TableDescriptor.GetFieldIndex("randomnumber");
				FI.fce_stageadvance_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_stageadvance_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_stageadvance_stageadvanceid = table.TableDescriptor.GetFieldIndex("stageadvanceid");
			}
			table = fifaDb.GetTable("fce_scriptfunctions");
			if (table != null)
			{
				FI.fce_scriptfunctions_scriptfuncid = table.TableDescriptor.GetFieldIndex("scriptfuncid");
				FI.fce_scriptfunctions_funcparam1 = table.TableDescriptor.GetFieldIndex("funcparam1");
				FI.fce_scriptfunctions_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_scriptfunctions_funcparam2 = table.TableDescriptor.GetFieldIndex("funcparam2");
				FI.fce_scriptfunctions_targetcompid = table.TableDescriptor.GetFieldIndex("targetcompid");
				FI.fce_scriptfunctions_funcparam3 = table.TableDescriptor.GetFieldIndex("funcparam3");
				FI.fce_scriptfunctions_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_scriptfunctions_functype = table.TableDescriptor.GetFieldIndex("functype");
			}
			table = fifaDb.GetTable("fce_scheduleinfo");
			if (table != null)
			{
				FI.fce_scheduleinfo_time = table.TableDescriptor.GetFieldIndex("time");
				FI.fce_scheduleinfo_dayofweek = table.TableDescriptor.GetFieldIndex("dayofweek");
				FI.fce_scheduleinfo_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_scheduleinfo_chance = table.TableDescriptor.GetFieldIndex("chance");
				FI.fce_scheduleinfo_priority = table.TableDescriptor.GetFieldIndex("priority");
				FI.fce_scheduleinfo_inuse = table.TableDescriptor.GetFieldIndex("inuse");
				FI.fce_scheduleinfo_scheduleinfoid = table.TableDescriptor.GetFieldIndex("scheduleinfoid");
			}
			table = fifaDb.GetTable("fce_fixtures");
			if (table != null)
			{
				FI.fce_fixtures_time = table.TableDescriptor.GetFieldIndex("time");
				FI.fce_fixtures_homescore = table.TableDescriptor.GetFieldIndex("homescore");
				FI.fce_fixtures_awayscore = table.TableDescriptor.GetFieldIndex("awayscore");
				FI.fce_fixtures_gamecompletion = table.TableDescriptor.GetFieldIndex("gamecompletion");
				FI.fce_fixtures_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_fixtures_date = table.TableDescriptor.GetFieldIndex("date");
				FI.fce_fixtures_fixtureid = table.TableDescriptor.GetFieldIndex("fixtureid");
				FI.fce_fixtures_awaystandingid = table.TableDescriptor.GetFieldIndex("awaystandingid");
				FI.fce_fixtures_homestandingid = table.TableDescriptor.GetFieldIndex("homestandingid");
				FI.fce_fixtures_awaypens = table.TableDescriptor.GetFieldIndex("awaypens");
				FI.fce_fixtures_homepens = table.TableDescriptor.GetFieldIndex("homepens");
				FI.fce_fixtures_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_competitionteams");
			if (table != null)
			{
				FI.fce_competitionteams_teamindex = table.TableDescriptor.GetFieldIndex("teamindex");
				FI.fce_competitionteams_compteamid = table.TableDescriptor.GetFieldIndex("compteamid");
				FI.fce_competitionteams_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_competitionteams_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.fce_competitionteams_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_competitioninfo");
			if (table != null)
			{
				FI.fce_competitioninfo_compobjshortdesc = table.TableDescriptor.GetFieldIndex("compobjshortdesc");
				FI.fce_competitioninfo_compobjdesc = table.TableDescriptor.GetFieldIndex("compobjdesc");
				FI.fce_competitioninfo_compparentid = table.TableDescriptor.GetFieldIndex("compparentid");
				FI.fce_competitioninfo_comptype = table.TableDescriptor.GetFieldIndex("comptype");
				FI.fce_competitioninfo_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_competitioninfo_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("fce_compavgs");
			if (table != null)
			{
				FI.fce_compavgs_mid = table.TableDescriptor.GetFieldIndex("mid");
				FI.fce_compavgs_ovr = table.TableDescriptor.GetFieldIndex("ovr");
				FI.fce_compavgs_def = table.TableDescriptor.GetFieldIndex("def");
				FI.fce_compavgs_compid = table.TableDescriptor.GetFieldIndex("compid");
				FI.fce_compavgs_gk = table.TableDescriptor.GetFieldIndex("gk");
				FI.fce_compavgs_att = table.TableDescriptor.GetFieldIndex("att");
			}
			table = fifaDb.GetTable("fce_advancement");
			if (table != null)
			{
				FI.fce_advancement_fromcompid = table.TableDescriptor.GetFieldIndex("fromcompid");
				FI.fce_advancement_fromteamindex = table.TableDescriptor.GetFieldIndex("fromteamindex");
				FI.fce_advancement_tocompid = table.TableDescriptor.GetFieldIndex("tocompid");
				FI.fce_advancement_advancementid = table.TableDescriptor.GetFieldIndex("advancementid");
				FI.fce_advancement_toteamindex = table.TableDescriptor.GetFieldIndex("toteamindex");
				FI.fce_advancement_inuse = table.TableDescriptor.GetFieldIndex("inuse");
			}
			table = fifaDb.GetTable("career_newspicweights");
			if (table != null)
			{
				FI.career_newspicweights_maxvariationspos = table.TableDescriptor.GetFieldIndex("maxvariationspos");
				FI.career_newspicweights_maxvariationsstd = table.TableDescriptor.GetFieldIndex("maxvariationsstd");
				FI.career_newspicweights_maxvariationsneg = table.TableDescriptor.GetFieldIndex("maxvariationsneg");
				FI.career_newspicweights_crestweight = table.TableDescriptor.GetFieldIndex("crestweight");
				FI.career_newspicweights_teamweight = table.TableDescriptor.GetFieldIndex("teamweight");
				FI.career_newspicweights_teamid = table.TableDescriptor.GetFieldIndex("teamid");
				FI.career_newspicweights_genericweight = table.TableDescriptor.GetFieldIndex("genericweight");
			}
			table = fifaDb.GetTable("finalstadiums");
			if (table != null)
			{
				FI.finalstadiums_leagueid = table.TableDescriptor.GetFieldIndex("leagueid");
				FI.finalstadiums_final_stadium = table.TableDescriptor.GetFieldIndex("final_stadium");
			}
			table = fifaDb.GetTable("tourn_licensed_stages");
			if (table != null)
			{
				FI.tourn_licensed_stages_lt_numlegs = table.TableDescriptor.GetFieldIndex("lt_numlegs");
				FI.tourn_licensed_stages_lt_league3 = table.TableDescriptor.GetFieldIndex("lt_league3");
				FI.tourn_licensed_stages_lt_stage_num = table.TableDescriptor.GetFieldIndex("lt_stage_num");
				FI.tourn_licensed_stages_lt_id = table.TableDescriptor.GetFieldIndex("lt_id");
				FI.tourn_licensed_stages_lt_league2 = table.TableDescriptor.GetFieldIndex("lt_league2");
				FI.tourn_licensed_stages_lt_league4 = table.TableDescriptor.GetFieldIndex("lt_league4");
				FI.tourn_licensed_stages_lt_num_teams_in_stage = table.TableDescriptor.GetFieldIndex("lt_num_teams_in_stage");
				FI.tourn_licensed_stages_lt_league5 = table.TableDescriptor.GetFieldIndex("lt_league5");
				FI.tourn_licensed_stages_lt_drawtype = table.TableDescriptor.GetFieldIndex("lt_drawtype");
				FI.tourn_licensed_stages_lt_league6 = table.TableDescriptor.GetFieldIndex("lt_league6");
				FI.tourn_licensed_stages_lt_league1 = table.TableDescriptor.GetFieldIndex("lt_league1");
				FI.tourn_licensed_stages_lt_num_bye_teams = table.TableDescriptor.GetFieldIndex("lt_num_bye_teams");
			}
			table = fifaDb.GetTable("tourn_licensed");
			if (table != null)
			{
				FI.tourn_licensed_lt_num_teams_to_advance = table.TableDescriptor.GetFieldIndex("lt_num_teams_to_advance");
				FI.tourn_licensed_lt_id = table.TableDescriptor.GetFieldIndex("lt_id");
				FI.tourn_licensed_lt_away_goal_rules = table.TableDescriptor.GetFieldIndex("lt_away_goal_rules");
				FI.tourn_licensed_lt_num_stages = table.TableDescriptor.GetFieldIndex("lt_num_stages");
				FI.tourn_licensed_lt_yellow_card_rule = table.TableDescriptor.GetFieldIndex("lt_yellow_card_rule");
				FI.tourn_licensed_lt_num_unique_teams = table.TableDescriptor.GetFieldIndex("lt_num_unique_teams");
				FI.tourn_licensed_lt_tourn_type = table.TableDescriptor.GetFieldIndex("lt_tourn_type");
				FI.tourn_licensed_lt_country = table.TableDescriptor.GetFieldIndex("lt_country");
				FI.tourn_licensed_lt_redcard_ban = table.TableDescriptor.GetFieldIndex("lt_redcard_ban");
				FI.tourn_licensed_lt_num_teams_per_group = table.TableDescriptor.GetFieldIndex("lt_num_teams_per_group");
				FI.tourn_licensed_lt_starting_subs = table.TableDescriptor.GetFieldIndex("lt_starting_subs");
				FI.tourn_licensed_lt_assetid = table.TableDescriptor.GetFieldIndex("lt_assetid");
				FI.tourn_licensed_lt_first_stage_is_KO = table.TableDescriptor.GetFieldIndex("lt_first_stage_is_KO");
			}
			table = fifaDb.GetTable("stadiumassignments");
			if (table != null)
			{
				FI.stadiumassignments_stadiumcustomname = table.TableDescriptor.GetFieldIndex("stadiumcustomname");
				FI.stadiumassignments_teamid = table.TableDescriptor.GetFieldIndex("teamid");
			}
			table = fifaDb.GetTable("career_namesgroups");
			if (table != null)
			{
				FI.career_namesgroups_nationality = table.TableDescriptor.GetFieldIndex("nationality");
				FI.career_namesgroups_groupid = table.TableDescriptor.GetFieldIndex("groupid");
			}
			table = fifaDb.GetTable("playerloans");
			if (table != null)
			{
				FI.playerloans_playerid = table.TableDescriptor.GetFieldIndex("playerid");
				FI.playerloans_teamidloanedfrom = table.TableDescriptor.GetFieldIndex("teamidloanedfrom");
				FI.playerloans_loandateend = table.TableDescriptor.GetFieldIndex("loandateend");
			}
		}

		// Token: 0x0400022D RID: 557
		public static int language_hashid = 0;

		// Token: 0x0400022E RID: 558
		public static int language_stringid = 0;

		// Token: 0x0400022F RID: 559
		public static int language_sourcetext = 1;

		// Token: 0x04000230 RID: 560
		public static int fixtures_fixturedate = -1;

		// Token: 0x04000231 RID: 561
		public static int fixtures_fixtureid = -1;

		// Token: 0x04000232 RID: 562
		public static int fixtures_textid_gameotw = -1;

		// Token: 0x04000233 RID: 563
		public static int fixtures_hometeamid = -1;

		// Token: 0x04000234 RID: 564
		public static int fixtures_hometeamskill = -1;

		// Token: 0x04000235 RID: 565
		public static int fixtures_legno = -1;

		// Token: 0x04000236 RID: 566
		public static int fixtures_awayteamskill = -1;

		// Token: 0x04000237 RID: 567
		public static int fixtures_stageofcompetition = -1;

		// Token: 0x04000238 RID: 568
		public static int fixtures_competitionid = -1;

		// Token: 0x04000239 RID: 569
		public static int fixtures_stadiumid = -1;

		// Token: 0x0400023A RID: 570
		public static int fixtures_currawayprevscore = -1;

		// Token: 0x0400023B RID: 571
		public static int fixtures_drawmode = -1;

		// Token: 0x0400023C RID: 572
		public static int fixtures_competitiontype = -1;

		// Token: 0x0400023D RID: 573
		public static int fixtures_matchimportance = -1;

		// Token: 0x0400023E RID: 574
		public static int fixtures_multipleleg = -1;

		// Token: 0x0400023F RID: 575
		public static int fixtures_livegametype = -1;

		// Token: 0x04000240 RID: 576
		public static int fixtures_currhomeprevscore = -1;

		// Token: 0x04000241 RID: 577
		public static int fixtures_fixturetime = -1;

		// Token: 0x04000242 RID: 578
		public static int fixtures_awayteamid = -1;

		// Token: 0x04000243 RID: 579
		public static int player_stats_rt = -1;

		// Token: 0x04000244 RID: 580
		public static int player_stats_frmcode = -1;

		// Token: 0x04000245 RID: 581
		public static int player_stats_goals = -1;

		// Token: 0x04000246 RID: 582
		public static int player_stats_goals_cup = -1;

		// Token: 0x04000247 RID: 583
		public static int player_stats_goals_conceded = -1;

		// Token: 0x04000248 RID: 584
		public static int player_stats_injury_duration = -1;

		// Token: 0x04000249 RID: 585
		public static int player_stats_momentum_value = -1;

		// Token: 0x0400024A RID: 586
		public static int player_stats_saves = -1;

		// Token: 0x0400024B RID: 587
		public static int player_stats_red_cards_international = -1;

		// Token: 0x0400024C RID: 588
		public static int player_stats_gk_shots_on_target = -1;

		// Token: 0x0400024D RID: 589
		public static int player_stats_appearances_cup = -1;

		// Token: 0x0400024E RID: 590
		public static int player_stats_frm = -1;

		// Token: 0x0400024F RID: 591
		public static int player_stats_total_reds = -1;

		// Token: 0x04000250 RID: 592
		public static int player_stats_games_played_at_position = -1;

		// Token: 0x04000251 RID: 593
		public static int player_stats_match_rating = -1;

		// Token: 0x04000252 RID: 594
		public static int player_stats_injury_end_date = -1;

		// Token: 0x04000253 RID: 595
		public static int player_stats_red_cards = -1;

		// Token: 0x04000254 RID: 596
		public static int player_stats_appearances = -1;

		// Token: 0x04000255 RID: 597
		public static int player_stats_suspended = -1;

		// Token: 0x04000256 RID: 598
		public static int player_stats_shots_on_goal = -1;

		// Token: 0x04000257 RID: 599
		public static int player_stats_suspended_international = -1;

		// Token: 0x04000258 RID: 600
		public static int player_stats_assists = -1;

		// Token: 0x04000259 RID: 601
		public static int player_stats_man_of_the_match = -1;

		// Token: 0x0400025A RID: 602
		public static int player_stats_teamid = -1;

		// Token: 0x0400025B RID: 603
		public static int player_stats_rating = -1;

		// Token: 0x0400025C RID: 604
		public static int player_stats_yellow_cards = -1;

		// Token: 0x0400025D RID: 605
		public static int player_stats_total_yellows = -1;

		// Token: 0x0400025E RID: 606
		public static int player_stats_transfer_done = -1;

		// Token: 0x0400025F RID: 607
		public static int player_stats_playerid = -1;

		// Token: 0x04000260 RID: 608
		public static int player_stats_injury_type = -1;

		// Token: 0x04000261 RID: 609
		public static int player_stats_clean_sheets = -1;

		// Token: 0x04000262 RID: 610
		public static int player_stats_morale = -1;

		// Token: 0x04000263 RID: 611
		public static int player_stats_yellow_cards_international = -1;

		// Token: 0x04000264 RID: 612
		public static int player_stats_fatigue = -1;

		// Token: 0x04000265 RID: 613
		public static int team_lookup_move_from_tsgt = -1;

		// Token: 0x04000266 RID: 614
		public static int team_lookup_rtsgt = -1;

		// Token: 0x04000267 RID: 615
		public static int team_lookup_final_ranking = -1;

		// Token: 0x04000268 RID: 616
		public static int team_lookup_away_num_wins = -1;

		// Token: 0x04000269 RID: 617
		public static int team_lookup_num_goals_for = -1;

		// Token: 0x0400026A RID: 618
		public static int team_lookup_away_num_losses = -1;

		// Token: 0x0400026B RID: 619
		public static int team_lookup_num_draws = -1;

		// Token: 0x0400026C RID: 620
		public static int team_lookup_num_wins = -1;

		// Token: 0x0400026D RID: 621
		public static int team_lookup_goals_for_home = -1;

		// Token: 0x0400026E RID: 622
		public static int team_lookup_goals_for_away = -1;

		// Token: 0x0400026F RID: 623
		public static int team_lookup_goals_against_home = -1;

		// Token: 0x04000270 RID: 624
		public static int team_lookup_goals_against_away = -1;

		// Token: 0x04000271 RID: 625
		public static int team_lookup_num_yellow_cards = -1;

		// Token: 0x04000272 RID: 626
		public static int team_lookup_num_losses = -1;

		// Token: 0x04000273 RID: 627
		public static int team_lookup_teamid = -1;

		// Token: 0x04000274 RID: 628
		public static int team_lookup_outcome = -1;

		// Token: 0x04000275 RID: 629
		public static int team_lookup_away_num_draws = -1;

		// Token: 0x04000276 RID: 630
		public static int team_lookup_points = -1;

		// Token: 0x04000277 RID: 631
		public static int team_lookup_played = -1;

		// Token: 0x04000278 RID: 632
		public static int team_lookup_num_goals_against = -1;

		// Token: 0x04000279 RID: 633
		public static int team_lookup_num_clean_sheets = -1;

		// Token: 0x0400027A RID: 634
		public static int team_lookup_num_red_cards = -1;

		// Token: 0x0400027B RID: 635
		public static int team_lookup_goal_diff = -1;

		// Token: 0x0400027C RID: 636
		public static int assetcryptokeys_key = -1;

		// Token: 0x0400027D RID: 637
		public static int assetcryptokeys_keyid = -1;

		// Token: 0x0400027E RID: 638
		public static int assetcryptokeys_artificialkey = -1;

		// Token: 0x0400027F RID: 639
		public static int version_exportdate = -1;

		// Token: 0x04000280 RID: 640
		public static int version_schema = -1;

		// Token: 0x04000281 RID: 641
		public static int version_isonline = -1;

		// Token: 0x04000282 RID: 642
		public static int version_minor = -1;

		// Token: 0x04000283 RID: 643
		public static int version_artificialkey = -1;

		// Token: 0x04000284 RID: 644
		public static int version_major = -1;

		// Token: 0x04000285 RID: 645
		public static int transactionhistory_movedto = -1;

		// Token: 0x04000286 RID: 646
		public static int transactionhistory_teamid = -1;

		// Token: 0x04000287 RID: 647
		public static int transactionhistory_playerid = -1;

		// Token: 0x04000288 RID: 648
		public static int trainingteamplayers_birthdate = -1;

		// Token: 0x04000289 RID: 649
		public static int trainingteamplayers_playerjointeamdate = -1;

		// Token: 0x0400028A RID: 650
		public static int trainingteamplayers_shoetypecode = -1;

		// Token: 0x0400028B RID: 651
		public static int trainingteamplayers_haircolorcode = -1;

		// Token: 0x0400028C RID: 652
		public static int trainingteamplayers_facialhairtypecode = -1;

		// Token: 0x0400028D RID: 653
		public static int trainingteamplayers_curve = -1;

		// Token: 0x0400028E RID: 654
		public static int trainingteamplayers_jerseystylecode = -1;

		// Token: 0x0400028F RID: 655
		public static int trainingteamplayers_agility = -1;

		// Token: 0x04000290 RID: 656
		public static int trainingteamplayers_accessorycode4 = -1;

		// Token: 0x04000291 RID: 657
		public static int trainingteamplayers_gksavetype = -1;

		// Token: 0x04000292 RID: 658
		public static int trainingteamplayers_positioning = -1;

		// Token: 0x04000293 RID: 659
		public static int trainingteamplayers_hairtypecode = -1;

		// Token: 0x04000294 RID: 660
		public static int trainingteamplayers_standingtackle = -1;

		// Token: 0x04000295 RID: 661
		public static int trainingteamplayers_faceposercode = -1;

		// Token: 0x04000296 RID: 662
		public static int trainingteamplayers_preferredposition3 = -1;

		// Token: 0x04000297 RID: 663
		public static int trainingteamplayers_longpassing = -1;

		// Token: 0x04000298 RID: 664
		public static int trainingteamplayers_penalties = -1;

		// Token: 0x04000299 RID: 665
		public static int trainingteamplayers_animfreekickstartposcode = -1;

		// Token: 0x0400029A RID: 666
		public static int trainingteamplayers_animpenaltieskickstylecode = -1;

		// Token: 0x0400029B RID: 667
		public static int trainingteamplayers_isretiring = -1;

		// Token: 0x0400029C RID: 668
		public static int trainingteamplayers_longshots = -1;

		// Token: 0x0400029D RID: 669
		public static int trainingteamplayers_gkdiving = -1;

		// Token: 0x0400029E RID: 670
		public static int trainingteamplayers_interceptions = -1;

		// Token: 0x0400029F RID: 671
		public static int trainingteamplayers_shoecolorcode2 = -1;

		// Token: 0x040002A0 RID: 672
		public static int trainingteamplayers_crossing = -1;

		// Token: 0x040002A1 RID: 673
		public static int trainingteamplayers_potential = -1;

		// Token: 0x040002A2 RID: 674
		public static int trainingteamplayers_gkreflexes = -1;

		// Token: 0x040002A3 RID: 675
		public static int trainingteamplayers_finishingcode1 = -1;

		// Token: 0x040002A4 RID: 676
		public static int trainingteamplayers_reactions = -1;

		// Token: 0x040002A5 RID: 677
		public static int trainingteamplayers_vision = -1;

		// Token: 0x040002A6 RID: 678
		public static int trainingteamplayers_contractvaliduntil = -1;

		// Token: 0x040002A7 RID: 679
		public static int trainingteamplayers_finishing = -1;

		// Token: 0x040002A8 RID: 680
		public static int trainingteamplayers_dribbling = -1;

		// Token: 0x040002A9 RID: 681
		public static int trainingteamplayers_slidingtackle = -1;

		// Token: 0x040002AA RID: 682
		public static int trainingteamplayers_accessorycode3 = -1;

		// Token: 0x040002AB RID: 683
		public static int trainingteamplayers_accessorycolourcode1 = -1;

		// Token: 0x040002AC RID: 684
		public static int trainingteamplayers_headtypecode = -1;

		// Token: 0x040002AD RID: 685
		public static int trainingteamplayers_firstnameid = -1;

		// Token: 0x040002AE RID: 686
		public static int trainingteamplayers_sprintspeed = -1;

		// Token: 0x040002AF RID: 687
		public static int trainingteamplayers_height = -1;

		// Token: 0x040002B0 RID: 688
		public static int trainingteamplayers_hasseasonaljersey = -1;

		// Token: 0x040002B1 RID: 689
		public static int trainingteamplayers_preferredposition2 = -1;

		// Token: 0x040002B2 RID: 690
		public static int trainingteamplayers_strength = -1;

		// Token: 0x040002B3 RID: 691
		public static int trainingteamplayers_preferredposition1 = -1;

		// Token: 0x040002B4 RID: 692
		public static int trainingteamplayers_ballcontrol = -1;

		// Token: 0x040002B5 RID: 693
		public static int trainingteamplayers_shotpower = -1;

		// Token: 0x040002B6 RID: 694
		public static int trainingteamplayers_trait1 = -1;

		// Token: 0x040002B7 RID: 695
		public static int trainingteamplayers_socklengthcode = -1;

		// Token: 0x040002B8 RID: 696
		public static int trainingteamplayers_weight = -1;

		// Token: 0x040002B9 RID: 697
		public static int trainingteamplayers_hashighqualityhead = -1;

		// Token: 0x040002BA RID: 698
		public static int trainingteamplayers_gkglovetypecode = -1;

		// Token: 0x040002BB RID: 699
		public static int trainingteamplayers_balance = -1;

		// Token: 0x040002BC RID: 700
		public static int trainingteamplayers_gkkicking = -1;

		// Token: 0x040002BD RID: 701
		public static int trainingteamplayers_lastnameid = -1;

		// Token: 0x040002BE RID: 702
		public static int trainingteamplayers_internationalrep = -1;

		// Token: 0x040002BF RID: 703
		public static int trainingteamplayers_animpenaltiesmotionstylecode = -1;

		// Token: 0x040002C0 RID: 704
		public static int trainingteamplayers_shortpassing = -1;

		// Token: 0x040002C1 RID: 705
		public static int trainingteamplayers_freekickaccuracy = -1;

		// Token: 0x040002C2 RID: 706
		public static int trainingteamplayers_skillmoves = -1;

		// Token: 0x040002C3 RID: 707
		public static int trainingteamplayers_usercaneditname = -1;

		// Token: 0x040002C4 RID: 708
		public static int trainingteamplayers_attackingworkrate = -1;

		// Token: 0x040002C5 RID: 709
		public static int trainingteamplayers_finishingcode2 = -1;

		// Token: 0x040002C6 RID: 710
		public static int trainingteamplayers_aggression = -1;

		// Token: 0x040002C7 RID: 711
		public static int trainingteamplayers_acceleration = -1;

		// Token: 0x040002C8 RID: 712
		public static int trainingteamplayers_headingaccuracy = -1;

		// Token: 0x040002C9 RID: 713
		public static int trainingteamplayers_eyebrowcode = -1;

		// Token: 0x040002CA RID: 714
		public static int trainingteamplayers_runningcode2 = -1;

		// Token: 0x040002CB RID: 715
		public static int trainingteamplayers_gkhandling = -1;

		// Token: 0x040002CC RID: 716
		public static int trainingteamplayers_eyecolorcode = -1;

		// Token: 0x040002CD RID: 717
		public static int trainingteamplayers_jerseysleevelengthcode = -1;

		// Token: 0x040002CE RID: 718
		public static int trainingteamplayers_accessorycolourcode3 = -1;

		// Token: 0x040002CF RID: 719
		public static int trainingteamplayers_accessorycode1 = -1;

		// Token: 0x040002D0 RID: 720
		public static int trainingteamplayers_headclasscode = -1;

		// Token: 0x040002D1 RID: 721
		public static int trainingteamplayers_defensiveworkrate = -1;

		// Token: 0x040002D2 RID: 722
		public static int trainingteamplayers_nationality = -1;

		// Token: 0x040002D3 RID: 723
		public static int trainingteamplayers_preferredfoot = -1;

		// Token: 0x040002D4 RID: 724
		public static int trainingteamplayers_sideburnscode = -1;

		// Token: 0x040002D5 RID: 725
		public static int trainingteamplayers_weakfootabilitytypecode = -1;

		// Token: 0x040002D6 RID: 726
		public static int trainingteamplayers_jumping = -1;

		// Token: 0x040002D7 RID: 727
		public static int trainingteamplayers_skintypecode = -1;

		// Token: 0x040002D8 RID: 728
		public static int trainingteamplayers_gkkickstyle = -1;

		// Token: 0x040002D9 RID: 729
		public static int trainingteamplayers_stamina = -1;

		// Token: 0x040002DA RID: 730
		public static int trainingteamplayers_playerid = -1;

		// Token: 0x040002DB RID: 731
		public static int trainingteamplayers_marking = -1;

		// Token: 0x040002DC RID: 732
		public static int trainingteamplayers_accessorycolourcode4 = -1;

		// Token: 0x040002DD RID: 733
		public static int trainingteamplayers_gkpositioning = -1;

		// Token: 0x040002DE RID: 734
		public static int trainingteamplayers_trait2 = -1;

		// Token: 0x040002DF RID: 735
		public static int trainingteamplayers_skintonecode = -1;

		// Token: 0x040002E0 RID: 736
		public static int trainingteamplayers_shortstyle = -1;

		// Token: 0x040002E1 RID: 737
		public static int trainingteamplayers_overallrating = -1;

		// Token: 0x040002E2 RID: 738
		public static int trainingteamplayers_jerseyfit = -1;

		// Token: 0x040002E3 RID: 739
		public static int trainingteamplayers_accessorycode2 = -1;

		// Token: 0x040002E4 RID: 740
		public static int trainingteamplayers_shoedesigncode = -1;

		// Token: 0x040002E5 RID: 741
		public static int trainingteamplayers_playerjerseynameid = -1;

		// Token: 0x040002E6 RID: 742
		public static int trainingteamplayers_shoecolorcode1 = -1;

		// Token: 0x040002E7 RID: 743
		public static int trainingteamplayers_commonnameid = -1;

		// Token: 0x040002E8 RID: 744
		public static int trainingteamplayers_bodytypecode = -1;

		// Token: 0x040002E9 RID: 745
		public static int trainingteamplayers_animpenaltiesstartposcode = -1;

		// Token: 0x040002EA RID: 746
		public static int trainingteamplayers_runningcode1 = -1;

		// Token: 0x040002EB RID: 747
		public static int trainingteamplayers_preferredposition4 = -1;

		// Token: 0x040002EC RID: 748
		public static int trainingteamplayers_volleys = -1;

		// Token: 0x040002ED RID: 749
		public static int trainingteamplayers_accessorycolourcode2 = -1;

		// Token: 0x040002EE RID: 750
		public static int trainingteamplayers_facialhaircolorcode = -1;

		// Token: 0x040002EF RID: 751
		public static int trainingteamplayernames_name = -1;

		// Token: 0x040002F0 RID: 752
		public static int trainingteamplayernames_commentaryid = -1;

		// Token: 0x040002F1 RID: 753
		public static int trainingteamplayernames_nameid = -1;

		// Token: 0x040002F2 RID: 754
		public static int trainingteamplayerlinks_jerseynumber = -1;

		// Token: 0x040002F3 RID: 755
		public static int trainingteamplayerlinks_position = -1;

		// Token: 0x040002F4 RID: 756
		public static int trainingteamplayerlinks_playerid = -1;

		// Token: 0x040002F5 RID: 757
		public static int temp_teams_assetid = -1;

		// Token: 0x040002F6 RID: 758
		public static int temp_teams_balltype = -1;

		// Token: 0x040002F7 RID: 759
		public static int temp_teams_teamcolor1g = -1;

		// Token: 0x040002F8 RID: 760
		public static int temp_teams_teamcolor1r = -1;

		// Token: 0x040002F9 RID: 761
		public static int temp_teams_teamcolor2b = -1;

		// Token: 0x040002FA RID: 762
		public static int temp_teams_teamcolor2r = -1;

		// Token: 0x040002FB RID: 763
		public static int temp_teams_teamcolor3r = -1;

		// Token: 0x040002FC RID: 764
		public static int temp_teams_teamcolor1b = -1;

		// Token: 0x040002FD RID: 765
		public static int temp_teams_latitude = -1;

		// Token: 0x040002FE RID: 766
		public static int temp_teams_teamcolor3g = -1;

		// Token: 0x040002FF RID: 767
		public static int temp_teams_teamcolor2g = -1;

		// Token: 0x04000300 RID: 768
		public static int temp_teams_teamname = -1;

		// Token: 0x04000301 RID: 769
		public static int temp_teams_adboardid = -1;

		// Token: 0x04000302 RID: 770
		public static int temp_teams_teamcolor3b = -1;

		// Token: 0x04000303 RID: 771
		public static int temp_teams_defmentality = -1;

		// Token: 0x04000304 RID: 772
		public static int temp_teams_powid = -1;

		// Token: 0x04000305 RID: 773
		public static int temp_teams_physioid_secondary = -1;

		// Token: 0x04000306 RID: 774
		public static int temp_teams_domesticprestige = -1;

		// Token: 0x04000307 RID: 775
		public static int temp_teams_genericint2 = -1;

		// Token: 0x04000308 RID: 776
		public static int temp_teams_jerseytype = -1;

		// Token: 0x04000309 RID: 777
		public static int temp_teams_rivalteam = -1;

		// Token: 0x0400030A RID: 778
		public static int temp_teams_midfieldrating = -1;

		// Token: 0x0400030B RID: 779
		public static int temp_teams_matchdayoverallrating = -1;

		// Token: 0x0400030C RID: 780
		public static int temp_teams_matchdaymidfieldrating = -1;

		// Token: 0x0400030D RID: 781
		public static int temp_teams_attackrating = -1;

		// Token: 0x0400030E RID: 782
		public static int temp_teams_physioid_primary = -1;

		// Token: 0x0400030F RID: 783
		public static int temp_teams_longitude = -1;

		// Token: 0x04000310 RID: 784
		public static int temp_teams_buspassing = -1;

		// Token: 0x04000311 RID: 785
		public static int temp_teams_matchdaydefenserating = -1;

		// Token: 0x04000312 RID: 786
		public static int temp_teams_defenserating = -1;

		// Token: 0x04000313 RID: 787
		public static int temp_teams_defteamwidth = -1;

		// Token: 0x04000314 RID: 788
		public static int temp_teams_longkicktakerid = -1;

		// Token: 0x04000315 RID: 789
		public static int temp_teams_bodytypeid = -1;

		// Token: 0x04000316 RID: 790
		public static int temp_teams_rightcornerkicktakerid = -1;

		// Token: 0x04000317 RID: 791
		public static int temp_teams_suitvariationid = -1;

		// Token: 0x04000318 RID: 792
		public static int temp_teams_defaggression = -1;

		// Token: 0x04000319 RID: 793
		public static int temp_teams_ethnicity = -1;

		// Token: 0x0400031A RID: 794
		public static int temp_teams_leftcornerkicktakerid = -1;

		// Token: 0x0400031B RID: 795
		public static int temp_teams_teamid = -1;

		// Token: 0x0400031C RID: 796
		public static int temp_teams_fancrowdhairskintexturecode = -1;

		// Token: 0x0400031D RID: 797
		public static int temp_teams_suittypeid = -1;

		// Token: 0x0400031E RID: 798
		public static int temp_teams_numtransfersin = -1;

		// Token: 0x0400031F RID: 799
		public static int temp_teams_captainid = -1;

		// Token: 0x04000320 RID: 800
		public static int temp_teams_personalityid = -1;

		// Token: 0x04000321 RID: 801
		public static int temp_teams_genericbanner = -1;

		// Token: 0x04000322 RID: 802
		public static int temp_teams_buspositioning = -1;

		// Token: 0x04000323 RID: 803
		public static int temp_teams_stafftracksuitcolorcode = -1;

		// Token: 0x04000324 RID: 804
		public static int temp_teams_ccpositioning = -1;

		// Token: 0x04000325 RID: 805
		public static int temp_teams_busbuildupspeed = -1;

		// Token: 0x04000326 RID: 806
		public static int temp_teams_transferbudget = -1;

		// Token: 0x04000327 RID: 807
		public static int temp_teams_ccshooting = -1;

		// Token: 0x04000328 RID: 808
		public static int temp_teams_overallrating = -1;

		// Token: 0x04000329 RID: 809
		public static int temp_teams_ccpassing = -1;

		// Token: 0x0400032A RID: 810
		public static int temp_teams_utcoffset = -1;

		// Token: 0x0400032B RID: 811
		public static int temp_teams_penaltytakerid = -1;

		// Token: 0x0400032C RID: 812
		public static int temp_teams_freekicktakerid = -1;

		// Token: 0x0400032D RID: 813
		public static int temp_teams_defdefenderline = -1;

		// Token: 0x0400032E RID: 814
		public static int temp_teams_internationalprestige = -1;

		// Token: 0x0400032F RID: 815
		public static int temp_teams_form = -1;

		// Token: 0x04000330 RID: 816
		public static int temp_teams_genericint1 = -1;

		// Token: 0x04000331 RID: 817
		public static int temp_teams_cccrossing = -1;

		// Token: 0x04000332 RID: 818
		public static int temp_teams_matchdayattackrating = -1;

		// Token: 0x04000333 RID: 819
		public static int temp_teamplayerlinks_leaguegoals = -1;

		// Token: 0x04000334 RID: 820
		public static int temp_teamplayerlinks_isamongtopscorers = -1;

		// Token: 0x04000335 RID: 821
		public static int temp_teamplayerlinks_yellows = -1;

		// Token: 0x04000336 RID: 822
		public static int temp_teamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x04000337 RID: 823
		public static int temp_teamplayerlinks_jerseynumber = -1;

		// Token: 0x04000338 RID: 824
		public static int temp_teamplayerlinks_position = -1;

		// Token: 0x04000339 RID: 825
		public static int temp_teamplayerlinks_artificialkey = -1;

		// Token: 0x0400033A RID: 826
		public static int temp_teamplayerlinks_teamid = -1;

		// Token: 0x0400033B RID: 827
		public static int temp_teamplayerlinks_injury = -1;

		// Token: 0x0400033C RID: 828
		public static int temp_teamplayerlinks_leagueappearances = -1;

		// Token: 0x0400033D RID: 829
		public static int temp_teamplayerlinks_prevform = -1;

		// Token: 0x0400033E RID: 830
		public static int temp_teamplayerlinks_istopscorer = -1;

		// Token: 0x0400033F RID: 831
		public static int temp_teamplayerlinks_playerid = -1;

		// Token: 0x04000340 RID: 832
		public static int temp_teamplayerlinks_form = -1;

		// Token: 0x04000341 RID: 833
		public static int temp_teamplayerlinks_reds = -1;

		// Token: 0x04000342 RID: 834
		public static int temp_players_birthdate = -1;

		// Token: 0x04000343 RID: 835
		public static int temp_players_playerjointeamdate = -1;

		// Token: 0x04000344 RID: 836
		public static int temp_players_shoetypecode = -1;

		// Token: 0x04000345 RID: 837
		public static int temp_players_haircolorcode = -1;

		// Token: 0x04000346 RID: 838
		public static int temp_players_facialhairtypecode = -1;

		// Token: 0x04000347 RID: 839
		public static int temp_players_curve = -1;

		// Token: 0x04000348 RID: 840
		public static int temp_players_jerseystylecode = -1;

		// Token: 0x04000349 RID: 841
		public static int temp_players_agility = -1;

		// Token: 0x0400034A RID: 842
		public static int temp_players_accessorycode4 = -1;

		// Token: 0x0400034B RID: 843
		public static int temp_players_gksavetype = -1;

		// Token: 0x0400034C RID: 844
		public static int temp_players_positioning = -1;

		// Token: 0x0400034D RID: 845
		public static int temp_players_hairtypecode = -1;

		// Token: 0x0400034E RID: 846
		public static int temp_players_standingtackle = -1;

		// Token: 0x0400034F RID: 847
		public static int temp_players_faceposercode = -1;

		// Token: 0x04000350 RID: 848
		public static int temp_players_preferredposition3 = -1;

		// Token: 0x04000351 RID: 849
		public static int temp_players_longpassing = -1;

		// Token: 0x04000352 RID: 850
		public static int temp_players_penalties = -1;

		// Token: 0x04000353 RID: 851
		public static int temp_players_animfreekickstartposcode = -1;

		// Token: 0x04000354 RID: 852
		public static int temp_players_animpenaltieskickstylecode = -1;

		// Token: 0x04000355 RID: 853
		public static int temp_players_isretiring = -1;

		// Token: 0x04000356 RID: 854
		public static int temp_players_longshots = -1;

		// Token: 0x04000357 RID: 855
		public static int temp_players_gkdiving = -1;

		// Token: 0x04000358 RID: 856
		public static int temp_players_interceptions = -1;

		// Token: 0x04000359 RID: 857
		public static int temp_players_shoecolorcode2 = -1;

		// Token: 0x0400035A RID: 858
		public static int temp_players_crossing = -1;

		// Token: 0x0400035B RID: 859
		public static int temp_players_potential = -1;

		// Token: 0x0400035C RID: 860
		public static int temp_players_gkreflexes = -1;

		// Token: 0x0400035D RID: 861
		public static int temp_players_finishingcode1 = -1;

		// Token: 0x0400035E RID: 862
		public static int temp_players_reactions = -1;

		// Token: 0x0400035F RID: 863
		public static int temp_players_vision = -1;

		// Token: 0x04000360 RID: 864
		public static int temp_players_contractvaliduntil = -1;

		// Token: 0x04000361 RID: 865
		public static int temp_players_finishing = -1;

		// Token: 0x04000362 RID: 866
		public static int temp_players_dribbling = -1;

		// Token: 0x04000363 RID: 867
		public static int temp_players_slidingtackle = -1;

		// Token: 0x04000364 RID: 868
		public static int temp_players_accessorycode3 = -1;

		// Token: 0x04000365 RID: 869
		public static int temp_players_accessorycolourcode1 = -1;

		// Token: 0x04000366 RID: 870
		public static int temp_players_headtypecode = -1;

		// Token: 0x04000367 RID: 871
		public static int temp_players_firstnameid = -1;

		// Token: 0x04000368 RID: 872
		public static int temp_players_sprintspeed = -1;

		// Token: 0x04000369 RID: 873
		public static int temp_players_height = -1;

		// Token: 0x0400036A RID: 874
		public static int temp_players_hasseasonaljersey = -1;

		// Token: 0x0400036B RID: 875
		public static int temp_players_preferredposition2 = -1;

		// Token: 0x0400036C RID: 876
		public static int temp_players_strength = -1;

		// Token: 0x0400036D RID: 877
		public static int temp_players_preferredposition1 = -1;

		// Token: 0x0400036E RID: 878
		public static int temp_players_ballcontrol = -1;

		// Token: 0x0400036F RID: 879
		public static int temp_players_shotpower = -1;

		// Token: 0x04000370 RID: 880
		public static int temp_players_trait1 = -1;

		// Token: 0x04000371 RID: 881
		public static int temp_players_socklengthcode = -1;

		// Token: 0x04000372 RID: 882
		public static int temp_players_weight = -1;

		// Token: 0x04000373 RID: 883
		public static int temp_players_hashighqualityhead = -1;

		// Token: 0x04000374 RID: 884
		public static int temp_players_gkglovetypecode = -1;

		// Token: 0x04000375 RID: 885
		public static int temp_players_balance = -1;

		// Token: 0x04000376 RID: 886
		public static int temp_players_gkkicking = -1;

		// Token: 0x04000377 RID: 887
		public static int temp_players_lastnameid = -1;

		// Token: 0x04000378 RID: 888
		public static int temp_players_internationalrep = -1;

		// Token: 0x04000379 RID: 889
		public static int temp_players_animpenaltiesmotionstylecode = -1;

		// Token: 0x0400037A RID: 890
		public static int temp_players_shortpassing = -1;

		// Token: 0x0400037B RID: 891
		public static int temp_players_freekickaccuracy = -1;

		// Token: 0x0400037C RID: 892
		public static int temp_players_skillmoves = -1;

		// Token: 0x0400037D RID: 893
		public static int temp_players_usercaneditname = -1;

		// Token: 0x0400037E RID: 894
		public static int temp_players_attackingworkrate = -1;

		// Token: 0x0400037F RID: 895
		public static int temp_players_finishingcode2 = -1;

		// Token: 0x04000380 RID: 896
		public static int temp_players_aggression = -1;

		// Token: 0x04000381 RID: 897
		public static int temp_players_acceleration = -1;

		// Token: 0x04000382 RID: 898
		public static int temp_players_headingaccuracy = -1;

		// Token: 0x04000383 RID: 899
		public static int temp_players_eyebrowcode = -1;

		// Token: 0x04000384 RID: 900
		public static int temp_players_runningcode2 = -1;

		// Token: 0x04000385 RID: 901
		public static int temp_players_gkhandling = -1;

		// Token: 0x04000386 RID: 902
		public static int temp_players_eyecolorcode = -1;

		// Token: 0x04000387 RID: 903
		public static int temp_players_jerseysleevelengthcode = -1;

		// Token: 0x04000388 RID: 904
		public static int temp_players_accessorycolourcode3 = -1;

		// Token: 0x04000389 RID: 905
		public static int temp_players_accessorycode1 = -1;

		// Token: 0x0400038A RID: 906
		public static int temp_players_headclasscode = -1;

		// Token: 0x0400038B RID: 907
		public static int temp_players_defensiveworkrate = -1;

		// Token: 0x0400038C RID: 908
		public static int temp_players_nationality = -1;

		// Token: 0x0400038D RID: 909
		public static int temp_players_preferredfoot = -1;

		// Token: 0x0400038E RID: 910
		public static int temp_players_sideburnscode = -1;

		// Token: 0x0400038F RID: 911
		public static int temp_players_weakfootabilitytypecode = -1;

		// Token: 0x04000390 RID: 912
		public static int temp_players_jumping = -1;

		// Token: 0x04000391 RID: 913
		public static int temp_players_skintypecode = -1;

		// Token: 0x04000392 RID: 914
		public static int temp_players_gkkickstyle = -1;

		// Token: 0x04000393 RID: 915
		public static int temp_players_stamina = -1;

		// Token: 0x04000394 RID: 916
		public static int temp_players_playerid = -1;

		// Token: 0x04000395 RID: 917
		public static int temp_players_marking = -1;

		// Token: 0x04000396 RID: 918
		public static int temp_players_accessorycolourcode4 = -1;

		// Token: 0x04000397 RID: 919
		public static int temp_players_gkpositioning = -1;

		// Token: 0x04000398 RID: 920
		public static int temp_players_trait2 = -1;

		// Token: 0x04000399 RID: 921
		public static int temp_players_skintonecode = -1;

		// Token: 0x0400039A RID: 922
		public static int temp_players_shortstyle = -1;

		// Token: 0x0400039B RID: 923
		public static int temp_players_overallrating = -1;

		// Token: 0x0400039C RID: 924
		public static int temp_players_jerseyfit = -1;

		// Token: 0x0400039D RID: 925
		public static int temp_players_accessorycode2 = -1;

		// Token: 0x0400039E RID: 926
		public static int temp_players_shoedesigncode = -1;

		// Token: 0x0400039F RID: 927
		public static int temp_players_playerjerseynameid = -1;

		// Token: 0x040003A0 RID: 928
		public static int temp_players_shoecolorcode1 = -1;

		// Token: 0x040003A1 RID: 929
		public static int temp_players_commonnameid = -1;

		// Token: 0x040003A2 RID: 930
		public static int temp_players_bodytypecode = -1;

		// Token: 0x040003A3 RID: 931
		public static int temp_players_animpenaltiesstartposcode = -1;

		// Token: 0x040003A4 RID: 932
		public static int temp_players_runningcode1 = -1;

		// Token: 0x040003A5 RID: 933
		public static int temp_players_preferredposition4 = -1;

		// Token: 0x040003A6 RID: 934
		public static int temp_players_volleys = -1;

		// Token: 0x040003A7 RID: 935
		public static int temp_players_accessorycolourcode2 = -1;

		// Token: 0x040003A8 RID: 936
		public static int temp_players_facialhaircolorcode = -1;

		// Token: 0x040003A9 RID: 937
		public static int temp_formations_offset6x = -1;

		// Token: 0x040003AA RID: 938
		public static int temp_formations_offset5y = -1;

		// Token: 0x040003AB RID: 939
		public static int temp_formations_offset10x = -1;

		// Token: 0x040003AC RID: 940
		public static int temp_formations_offset2x = -1;

		// Token: 0x040003AD RID: 941
		public static int temp_formations_defenders = -1;

		// Token: 0x040003AE RID: 942
		public static int temp_formations_offset2y = -1;

		// Token: 0x040003AF RID: 943
		public static int temp_formations_offset6y = -1;

		// Token: 0x040003B0 RID: 944
		public static int temp_formations_offset7x = -1;

		// Token: 0x040003B1 RID: 945
		public static int temp_formations_offset3x = -1;

		// Token: 0x040003B2 RID: 946
		public static int temp_formations_offset8x = -1;

		// Token: 0x040003B3 RID: 947
		public static int temp_formations_offset10y = -1;

		// Token: 0x040003B4 RID: 948
		public static int temp_formations_offset3y = -1;

		// Token: 0x040003B5 RID: 949
		public static int temp_formations_offset4x = -1;

		// Token: 0x040003B6 RID: 950
		public static int temp_formations_offset7y = -1;

		// Token: 0x040003B7 RID: 951
		public static int temp_formations_offset0x = -1;

		// Token: 0x040003B8 RID: 952
		public static int temp_formations_offset8y = -1;

		// Token: 0x040003B9 RID: 953
		public static int temp_formations_attackers = -1;

		// Token: 0x040003BA RID: 954
		public static int temp_formations_offset9x = -1;

		// Token: 0x040003BB RID: 955
		public static int temp_formations_midfielders = -1;

		// Token: 0x040003BC RID: 956
		public static int temp_formations_offset5x = -1;

		// Token: 0x040003BD RID: 957
		public static int temp_formations_offset0y = -1;

		// Token: 0x040003BE RID: 958
		public static int temp_formations_offset1x = -1;

		// Token: 0x040003BF RID: 959
		public static int temp_formations_offset4y = -1;

		// Token: 0x040003C0 RID: 960
		public static int temp_formations_offset9y = -1;

		// Token: 0x040003C1 RID: 961
		public static int temp_formations_offset1y = -1;

		// Token: 0x040003C2 RID: 962
		public static int temp_formations_formationname = -1;

		// Token: 0x040003C3 RID: 963
		public static int temp_formations_attackingdirection_0 = -1;

		// Token: 0x040003C4 RID: 964
		public static int temp_formations_attackingrole_5 = -1;

		// Token: 0x040003C5 RID: 965
		public static int temp_formations_position10 = -1;

		// Token: 0x040003C6 RID: 966
		public static int temp_formations_attackingdirection_7 = -1;

		// Token: 0x040003C7 RID: 967
		public static int temp_formations_defensivedirection_0 = -1;

		// Token: 0x040003C8 RID: 968
		public static int temp_formations_defensivedirection_9 = -1;

		// Token: 0x040003C9 RID: 969
		public static int temp_formations_defensivedirection_8 = -1;

		// Token: 0x040003CA RID: 970
		public static int temp_formations_attackingdirection_9 = -1;

		// Token: 0x040003CB RID: 971
		public static int temp_formations_position6 = -1;

		// Token: 0x040003CC RID: 972
		public static int temp_formations_attackingrole_4 = -1;

		// Token: 0x040003CD RID: 973
		public static int temp_formations_offensiverating = -1;

		// Token: 0x040003CE RID: 974
		public static int temp_formations_attackingrole_2 = -1;

		// Token: 0x040003CF RID: 975
		public static int temp_formations_attackingdirection_1 = -1;

		// Token: 0x040003D0 RID: 976
		public static int temp_formations_position8 = -1;

		// Token: 0x040003D1 RID: 977
		public static int temp_formations_defensiverole_4 = -1;

		// Token: 0x040003D2 RID: 978
		public static int temp_formations_attackingdirection_10 = -1;

		// Token: 0x040003D3 RID: 979
		public static int temp_formations_defensivedirection_6 = -1;

		// Token: 0x040003D4 RID: 980
		public static int temp_formations_attackingdirection_8 = -1;

		// Token: 0x040003D5 RID: 981
		public static int temp_formations_attackingrole_3 = -1;

		// Token: 0x040003D6 RID: 982
		public static int temp_formations_defensiverole_3 = -1;

		// Token: 0x040003D7 RID: 983
		public static int temp_formations_attackingrole_0 = -1;

		// Token: 0x040003D8 RID: 984
		public static int temp_formations_defensivedirection_1 = -1;

		// Token: 0x040003D9 RID: 985
		public static int temp_formations_attackingdirection_5 = -1;

		// Token: 0x040003DA RID: 986
		public static int temp_formations_defensivedirection_2 = -1;

		// Token: 0x040003DB RID: 987
		public static int temp_formations_attackingdirection_6 = -1;

		// Token: 0x040003DC RID: 988
		public static int temp_formations_position5 = -1;

		// Token: 0x040003DD RID: 989
		public static int temp_formations_attackingrole_7 = -1;

		// Token: 0x040003DE RID: 990
		public static int temp_formations_defensiverole_5 = -1;

		// Token: 0x040003DF RID: 991
		public static int temp_formations_defensivedirection_10 = -1;

		// Token: 0x040003E0 RID: 992
		public static int temp_formations_defensivedirection_3 = -1;

		// Token: 0x040003E1 RID: 993
		public static int temp_formations_defensivedirection_5 = -1;

		// Token: 0x040003E2 RID: 994
		public static int temp_formations_issweeper = -1;

		// Token: 0x040003E3 RID: 995
		public static int temp_formations_attackingdirection_2 = -1;

		// Token: 0x040003E4 RID: 996
		public static int temp_formations_attackingdirection_4 = -1;

		// Token: 0x040003E5 RID: 997
		public static int temp_formations_attackingrole_9 = -1;

		// Token: 0x040003E6 RID: 998
		public static int temp_formations_defensiverole_2 = -1;

		// Token: 0x040003E7 RID: 999
		public static int temp_formations_attackingdirection_3 = -1;

		// Token: 0x040003E8 RID: 1000
		public static int temp_formations_attackingrole_8 = -1;

		// Token: 0x040003E9 RID: 1001
		public static int temp_formations_attackingrole_1 = -1;

		// Token: 0x040003EA RID: 1002
		public static int temp_formations_defensiverole_10 = -1;

		// Token: 0x040003EB RID: 1003
		public static int temp_formations_defensiverole_1 = -1;

		// Token: 0x040003EC RID: 1004
		public static int temp_formations_teamid = -1;

		// Token: 0x040003ED RID: 1005
		public static int temp_formations_position2 = -1;

		// Token: 0x040003EE RID: 1006
		public static int temp_formations_defensivedirection_4 = -1;

		// Token: 0x040003EF RID: 1007
		public static int temp_formations_formationid = -1;

		// Token: 0x040003F0 RID: 1008
		public static int temp_formations_defensiverole_8 = -1;

		// Token: 0x040003F1 RID: 1009
		public static int temp_formations_attackingrole_6 = -1;

		// Token: 0x040003F2 RID: 1010
		public static int temp_formations_relativeformationid = -1;

		// Token: 0x040003F3 RID: 1011
		public static int temp_formations_defensiverole_0 = -1;

		// Token: 0x040003F4 RID: 1012
		public static int temp_formations_defensiverole_6 = -1;

		// Token: 0x040003F5 RID: 1013
		public static int temp_formations_position4 = -1;

		// Token: 0x040003F6 RID: 1014
		public static int temp_formations_attackingrole_10 = -1;

		// Token: 0x040003F7 RID: 1015
		public static int temp_formations_position3 = -1;

		// Token: 0x040003F8 RID: 1016
		public static int temp_formations_defensiverole_7 = -1;

		// Token: 0x040003F9 RID: 1017
		public static int temp_formations_formationfullnameid = -1;

		// Token: 0x040003FA RID: 1018
		public static int temp_formations_defensiverole_9 = -1;

		// Token: 0x040003FB RID: 1019
		public static int temp_formations_position0 = -1;

		// Token: 0x040003FC RID: 1020
		public static int temp_formations_position9 = -1;

		// Token: 0x040003FD RID: 1021
		public static int temp_formations_position7 = -1;

		// Token: 0x040003FE RID: 1022
		public static int temp_formations_position1 = -1;

		// Token: 0x040003FF RID: 1023
		public static int temp_formations_defensivedirection_7 = -1;

		// Token: 0x04000400 RID: 1024
		public static int temp_arenateamplayerlinks_leaguegoals = -1;

		// Token: 0x04000401 RID: 1025
		public static int temp_arenateamplayerlinks_isamongtopscorers = -1;

		// Token: 0x04000402 RID: 1026
		public static int temp_arenateamplayerlinks_yellows = -1;

		// Token: 0x04000403 RID: 1027
		public static int temp_arenateamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x04000404 RID: 1028
		public static int temp_arenateamplayerlinks_jerseynumber = -1;

		// Token: 0x04000405 RID: 1029
		public static int temp_arenateamplayerlinks_position = -1;

		// Token: 0x04000406 RID: 1030
		public static int temp_arenateamplayerlinks_artificialkey = -1;

		// Token: 0x04000407 RID: 1031
		public static int temp_arenateamplayerlinks_teamid = -1;

		// Token: 0x04000408 RID: 1032
		public static int temp_arenateamplayerlinks_injury = -1;

		// Token: 0x04000409 RID: 1033
		public static int temp_arenateamplayerlinks_leagueappearances = -1;

		// Token: 0x0400040A RID: 1034
		public static int temp_arenateamplayerlinks_prevform = -1;

		// Token: 0x0400040B RID: 1035
		public static int temp_arenateamplayerlinks_istopscorer = -1;

		// Token: 0x0400040C RID: 1036
		public static int temp_arenateamplayerlinks_playerid = -1;

		// Token: 0x0400040D RID: 1037
		public static int temp_arenateamplayerlinks_form = -1;

		// Token: 0x0400040E RID: 1038
		public static int temp_arenateamplayerlinks_reds = -1;

		// Token: 0x0400040F RID: 1039
		public static int temp_arenateam_assetid = -1;

		// Token: 0x04000410 RID: 1040
		public static int temp_arenateam_balltype = -1;

		// Token: 0x04000411 RID: 1041
		public static int temp_arenateam_teamcolor1g = -1;

		// Token: 0x04000412 RID: 1042
		public static int temp_arenateam_teamcolor1r = -1;

		// Token: 0x04000413 RID: 1043
		public static int temp_arenateam_teamcolor2b = -1;

		// Token: 0x04000414 RID: 1044
		public static int temp_arenateam_teamcolor2r = -1;

		// Token: 0x04000415 RID: 1045
		public static int temp_arenateam_teamcolor3r = -1;

		// Token: 0x04000416 RID: 1046
		public static int temp_arenateam_teamcolor1b = -1;

		// Token: 0x04000417 RID: 1047
		public static int temp_arenateam_latitude = -1;

		// Token: 0x04000418 RID: 1048
		public static int temp_arenateam_teamcolor3g = -1;

		// Token: 0x04000419 RID: 1049
		public static int temp_arenateam_teamcolor2g = -1;

		// Token: 0x0400041A RID: 1050
		public static int temp_arenateam_teamname = -1;

		// Token: 0x0400041B RID: 1051
		public static int temp_arenateam_adboardid = -1;

		// Token: 0x0400041C RID: 1052
		public static int temp_arenateam_teamcolor3b = -1;

		// Token: 0x0400041D RID: 1053
		public static int temp_arenateam_defmentality = -1;

		// Token: 0x0400041E RID: 1054
		public static int temp_arenateam_powid = -1;

		// Token: 0x0400041F RID: 1055
		public static int temp_arenateam_physioid_secondary = -1;

		// Token: 0x04000420 RID: 1056
		public static int temp_arenateam_domesticprestige = -1;

		// Token: 0x04000421 RID: 1057
		public static int temp_arenateam_genericint2 = -1;

		// Token: 0x04000422 RID: 1058
		public static int temp_arenateam_jerseytype = -1;

		// Token: 0x04000423 RID: 1059
		public static int temp_arenateam_rivalteam = -1;

		// Token: 0x04000424 RID: 1060
		public static int temp_arenateam_midfieldrating = -1;

		// Token: 0x04000425 RID: 1061
		public static int temp_arenateam_matchdayoverallrating = -1;

		// Token: 0x04000426 RID: 1062
		public static int temp_arenateam_matchdaymidfieldrating = -1;

		// Token: 0x04000427 RID: 1063
		public static int temp_arenateam_attackrating = -1;

		// Token: 0x04000428 RID: 1064
		public static int temp_arenateam_physioid_primary = -1;

		// Token: 0x04000429 RID: 1065
		public static int temp_arenateam_longitude = -1;

		// Token: 0x0400042A RID: 1066
		public static int temp_arenateam_buspassing = -1;

		// Token: 0x0400042B RID: 1067
		public static int temp_arenateam_matchdaydefenserating = -1;

		// Token: 0x0400042C RID: 1068
		public static int temp_arenateam_defenserating = -1;

		// Token: 0x0400042D RID: 1069
		public static int temp_arenateam_defteamwidth = -1;

		// Token: 0x0400042E RID: 1070
		public static int temp_arenateam_longkicktakerid = -1;

		// Token: 0x0400042F RID: 1071
		public static int temp_arenateam_bodytypeid = -1;

		// Token: 0x04000430 RID: 1072
		public static int temp_arenateam_rightcornerkicktakerid = -1;

		// Token: 0x04000431 RID: 1073
		public static int temp_arenateam_suitvariationid = -1;

		// Token: 0x04000432 RID: 1074
		public static int temp_arenateam_defaggression = -1;

		// Token: 0x04000433 RID: 1075
		public static int temp_arenateam_ethnicity = -1;

		// Token: 0x04000434 RID: 1076
		public static int temp_arenateam_leftcornerkicktakerid = -1;

		// Token: 0x04000435 RID: 1077
		public static int temp_arenateam_teamid = -1;

		// Token: 0x04000436 RID: 1078
		public static int temp_arenateam_fancrowdhairskintexturecode = -1;

		// Token: 0x04000437 RID: 1079
		public static int temp_arenateam_suittypeid = -1;

		// Token: 0x04000438 RID: 1080
		public static int temp_arenateam_numtransfersin = -1;

		// Token: 0x04000439 RID: 1081
		public static int temp_arenateam_captainid = -1;

		// Token: 0x0400043A RID: 1082
		public static int temp_arenateam_personalityid = -1;

		// Token: 0x0400043B RID: 1083
		public static int temp_arenateam_genericbanner = -1;

		// Token: 0x0400043C RID: 1084
		public static int temp_arenateam_buspositioning = -1;

		// Token: 0x0400043D RID: 1085
		public static int temp_arenateam_stafftracksuitcolorcode = -1;

		// Token: 0x0400043E RID: 1086
		public static int temp_arenateam_ccpositioning = -1;

		// Token: 0x0400043F RID: 1087
		public static int temp_arenateam_busbuildupspeed = -1;

		// Token: 0x04000440 RID: 1088
		public static int temp_arenateam_transferbudget = -1;

		// Token: 0x04000441 RID: 1089
		public static int temp_arenateam_ccshooting = -1;

		// Token: 0x04000442 RID: 1090
		public static int temp_arenateam_overallrating = -1;

		// Token: 0x04000443 RID: 1091
		public static int temp_arenateam_ccpassing = -1;

		// Token: 0x04000444 RID: 1092
		public static int temp_arenateam_utcoffset = -1;

		// Token: 0x04000445 RID: 1093
		public static int temp_arenateam_penaltytakerid = -1;

		// Token: 0x04000446 RID: 1094
		public static int temp_arenateam_freekicktakerid = -1;

		// Token: 0x04000447 RID: 1095
		public static int temp_arenateam_defdefenderline = -1;

		// Token: 0x04000448 RID: 1096
		public static int temp_arenateam_internationalprestige = -1;

		// Token: 0x04000449 RID: 1097
		public static int temp_arenateam_form = -1;

		// Token: 0x0400044A RID: 1098
		public static int temp_arenateam_genericint1 = -1;

		// Token: 0x0400044B RID: 1099
		public static int temp_arenateam_cccrossing = -1;

		// Token: 0x0400044C RID: 1100
		public static int temp_arenateam_matchdayattackrating = -1;

		// Token: 0x0400044D RID: 1101
		public static int temp_arenaplayername_firstname = -1;

		// Token: 0x0400044E RID: 1102
		public static int temp_arenaplayername_commonname = -1;

		// Token: 0x0400044F RID: 1103
		public static int temp_arenaplayername_playerjerseyname = -1;

		// Token: 0x04000450 RID: 1104
		public static int temp_arenaplayername_surname = -1;

		// Token: 0x04000451 RID: 1105
		public static int temp_arenaplayername_playerid = -1;

		// Token: 0x04000452 RID: 1106
		public static int temp_arenaplayer_birthdate = -1;

		// Token: 0x04000453 RID: 1107
		public static int temp_arenaplayer_playerjointeamdate = -1;

		// Token: 0x04000454 RID: 1108
		public static int temp_arenaplayer_shoetypecode = -1;

		// Token: 0x04000455 RID: 1109
		public static int temp_arenaplayer_haircolorcode = -1;

		// Token: 0x04000456 RID: 1110
		public static int temp_arenaplayer_facialhairtypecode = -1;

		// Token: 0x04000457 RID: 1111
		public static int temp_arenaplayer_curve = -1;

		// Token: 0x04000458 RID: 1112
		public static int temp_arenaplayer_jerseystylecode = -1;

		// Token: 0x04000459 RID: 1113
		public static int temp_arenaplayer_agility = -1;

		// Token: 0x0400045A RID: 1114
		public static int temp_arenaplayer_accessorycode4 = -1;

		// Token: 0x0400045B RID: 1115
		public static int temp_arenaplayer_gksavetype = -1;

		// Token: 0x0400045C RID: 1116
		public static int temp_arenaplayer_positioning = -1;

		// Token: 0x0400045D RID: 1117
		public static int temp_arenaplayer_hairtypecode = -1;

		// Token: 0x0400045E RID: 1118
		public static int temp_arenaplayer_standingtackle = -1;

		// Token: 0x0400045F RID: 1119
		public static int temp_arenaplayer_faceposercode = -1;

		// Token: 0x04000460 RID: 1120
		public static int temp_arenaplayer_preferredposition3 = -1;

		// Token: 0x04000461 RID: 1121
		public static int temp_arenaplayer_longpassing = -1;

		// Token: 0x04000462 RID: 1122
		public static int temp_arenaplayer_penalties = -1;

		// Token: 0x04000463 RID: 1123
		public static int temp_arenaplayer_animfreekickstartposcode = -1;

		// Token: 0x04000464 RID: 1124
		public static int temp_arenaplayer_animpenaltieskickstylecode = -1;

		// Token: 0x04000465 RID: 1125
		public static int temp_arenaplayer_isretiring = -1;

		// Token: 0x04000466 RID: 1126
		public static int temp_arenaplayer_longshots = -1;

		// Token: 0x04000467 RID: 1127
		public static int temp_arenaplayer_gkdiving = -1;

		// Token: 0x04000468 RID: 1128
		public static int temp_arenaplayer_interceptions = -1;

		// Token: 0x04000469 RID: 1129
		public static int temp_arenaplayer_shoecolorcode2 = -1;

		// Token: 0x0400046A RID: 1130
		public static int temp_arenaplayer_crossing = -1;

		// Token: 0x0400046B RID: 1131
		public static int temp_arenaplayer_potential = -1;

		// Token: 0x0400046C RID: 1132
		public static int temp_arenaplayer_gkreflexes = -1;

		// Token: 0x0400046D RID: 1133
		public static int temp_arenaplayer_finishingcode1 = -1;

		// Token: 0x0400046E RID: 1134
		public static int temp_arenaplayer_reactions = -1;

		// Token: 0x0400046F RID: 1135
		public static int temp_arenaplayer_vision = -1;

		// Token: 0x04000470 RID: 1136
		public static int temp_arenaplayer_contractvaliduntil = -1;

		// Token: 0x04000471 RID: 1137
		public static int temp_arenaplayer_finishing = -1;

		// Token: 0x04000472 RID: 1138
		public static int temp_arenaplayer_dribbling = -1;

		// Token: 0x04000473 RID: 1139
		public static int temp_arenaplayer_slidingtackle = -1;

		// Token: 0x04000474 RID: 1140
		public static int temp_arenaplayer_accessorycode3 = -1;

		// Token: 0x04000475 RID: 1141
		public static int temp_arenaplayer_accessorycolourcode1 = -1;

		// Token: 0x04000476 RID: 1142
		public static int temp_arenaplayer_headtypecode = -1;

		// Token: 0x04000477 RID: 1143
		public static int temp_arenaplayer_firstnameid = -1;

		// Token: 0x04000478 RID: 1144
		public static int temp_arenaplayer_sprintspeed = -1;

		// Token: 0x04000479 RID: 1145
		public static int temp_arenaplayer_height = -1;

		// Token: 0x0400047A RID: 1146
		public static int temp_arenaplayer_hasseasonaljersey = -1;

		// Token: 0x0400047B RID: 1147
		public static int temp_arenaplayer_preferredposition2 = -1;

		// Token: 0x0400047C RID: 1148
		public static int temp_arenaplayer_strength = -1;

		// Token: 0x0400047D RID: 1149
		public static int temp_arenaplayer_preferredposition1 = -1;

		// Token: 0x0400047E RID: 1150
		public static int temp_arenaplayer_ballcontrol = -1;

		// Token: 0x0400047F RID: 1151
		public static int temp_arenaplayer_shotpower = -1;

		// Token: 0x04000480 RID: 1152
		public static int temp_arenaplayer_trait1 = -1;

		// Token: 0x04000481 RID: 1153
		public static int temp_arenaplayer_socklengthcode = -1;

		// Token: 0x04000482 RID: 1154
		public static int temp_arenaplayer_weight = -1;

		// Token: 0x04000483 RID: 1155
		public static int temp_arenaplayer_hashighqualityhead = -1;

		// Token: 0x04000484 RID: 1156
		public static int temp_arenaplayer_gkglovetypecode = -1;

		// Token: 0x04000485 RID: 1157
		public static int temp_arenaplayer_balance = -1;

		// Token: 0x04000486 RID: 1158
		public static int temp_arenaplayer_gkkicking = -1;

		// Token: 0x04000487 RID: 1159
		public static int temp_arenaplayer_lastnameid = -1;

		// Token: 0x04000488 RID: 1160
		public static int temp_arenaplayer_internationalrep = -1;

		// Token: 0x04000489 RID: 1161
		public static int temp_arenaplayer_animpenaltiesmotionstylecode = -1;

		// Token: 0x0400048A RID: 1162
		public static int temp_arenaplayer_shortpassing = -1;

		// Token: 0x0400048B RID: 1163
		public static int temp_arenaplayer_freekickaccuracy = -1;

		// Token: 0x0400048C RID: 1164
		public static int temp_arenaplayer_skillmoves = -1;

		// Token: 0x0400048D RID: 1165
		public static int temp_arenaplayer_usercaneditname = -1;

		// Token: 0x0400048E RID: 1166
		public static int temp_arenaplayer_attackingworkrate = -1;

		// Token: 0x0400048F RID: 1167
		public static int temp_arenaplayer_finishingcode2 = -1;

		// Token: 0x04000490 RID: 1168
		public static int temp_arenaplayer_aggression = -1;

		// Token: 0x04000491 RID: 1169
		public static int temp_arenaplayer_acceleration = -1;

		// Token: 0x04000492 RID: 1170
		public static int temp_arenaplayer_headingaccuracy = -1;

		// Token: 0x04000493 RID: 1171
		public static int temp_arenaplayer_eyebrowcode = -1;

		// Token: 0x04000494 RID: 1172
		public static int temp_arenaplayer_runningcode2 = -1;

		// Token: 0x04000495 RID: 1173
		public static int temp_arenaplayer_gkhandling = -1;

		// Token: 0x04000496 RID: 1174
		public static int temp_arenaplayer_eyecolorcode = -1;

		// Token: 0x04000497 RID: 1175
		public static int temp_arenaplayer_jerseysleevelengthcode = -1;

		// Token: 0x04000498 RID: 1176
		public static int temp_arenaplayer_accessorycolourcode3 = -1;

		// Token: 0x04000499 RID: 1177
		public static int temp_arenaplayer_accessorycode1 = -1;

		// Token: 0x0400049A RID: 1178
		public static int temp_arenaplayer_headclasscode = -1;

		// Token: 0x0400049B RID: 1179
		public static int temp_arenaplayer_defensiveworkrate = -1;

		// Token: 0x0400049C RID: 1180
		public static int temp_arenaplayer_nationality = -1;

		// Token: 0x0400049D RID: 1181
		public static int temp_arenaplayer_preferredfoot = -1;

		// Token: 0x0400049E RID: 1182
		public static int temp_arenaplayer_sideburnscode = -1;

		// Token: 0x0400049F RID: 1183
		public static int temp_arenaplayer_weakfootabilitytypecode = -1;

		// Token: 0x040004A0 RID: 1184
		public static int temp_arenaplayer_jumping = -1;

		// Token: 0x040004A1 RID: 1185
		public static int temp_arenaplayer_skintypecode = -1;

		// Token: 0x040004A2 RID: 1186
		public static int temp_arenaplayer_gkkickstyle = -1;

		// Token: 0x040004A3 RID: 1187
		public static int temp_arenaplayer_stamina = -1;

		// Token: 0x040004A4 RID: 1188
		public static int temp_arenaplayer_playerid = -1;

		// Token: 0x040004A5 RID: 1189
		public static int temp_arenaplayer_marking = -1;

		// Token: 0x040004A6 RID: 1190
		public static int temp_arenaplayer_accessorycolourcode4 = -1;

		// Token: 0x040004A7 RID: 1191
		public static int temp_arenaplayer_gkpositioning = -1;

		// Token: 0x040004A8 RID: 1192
		public static int temp_arenaplayer_trait2 = -1;

		// Token: 0x040004A9 RID: 1193
		public static int temp_arenaplayer_skintonecode = -1;

		// Token: 0x040004AA RID: 1194
		public static int temp_arenaplayer_shortstyle = -1;

		// Token: 0x040004AB RID: 1195
		public static int temp_arenaplayer_overallrating = -1;

		// Token: 0x040004AC RID: 1196
		public static int temp_arenaplayer_jerseyfit = -1;

		// Token: 0x040004AD RID: 1197
		public static int temp_arenaplayer_accessorycode2 = -1;

		// Token: 0x040004AE RID: 1198
		public static int temp_arenaplayer_shoedesigncode = -1;

		// Token: 0x040004AF RID: 1199
		public static int temp_arenaplayer_playerjerseynameid = -1;

		// Token: 0x040004B0 RID: 1200
		public static int temp_arenaplayer_shoecolorcode1 = -1;

		// Token: 0x040004B1 RID: 1201
		public static int temp_arenaplayer_commonnameid = -1;

		// Token: 0x040004B2 RID: 1202
		public static int temp_arenaplayer_bodytypecode = -1;

		// Token: 0x040004B3 RID: 1203
		public static int temp_arenaplayer_animpenaltiesstartposcode = -1;

		// Token: 0x040004B4 RID: 1204
		public static int temp_arenaplayer_runningcode1 = -1;

		// Token: 0x040004B5 RID: 1205
		public static int temp_arenaplayer_preferredposition4 = -1;

		// Token: 0x040004B6 RID: 1206
		public static int temp_arenaplayer_volleys = -1;

		// Token: 0x040004B7 RID: 1207
		public static int temp_arenaplayer_accessorycolourcode2 = -1;

		// Token: 0x040004B8 RID: 1208
		public static int temp_arenaplayer_facialhaircolorcode = -1;

		// Token: 0x040004B9 RID: 1209
		public static int teamstadiumlinks_stadiumid = -1;

		// Token: 0x040004BA RID: 1210
		public static int teamstadiumlinks_teamid = -1;

		// Token: 0x040004BB RID: 1211
		public static int teams_assetid = -1;

		// Token: 0x040004BC RID: 1212
		public static int teams_balltype = -1;

		// Token: 0x040004BD RID: 1213
		public static int teams_teamcolor1g = -1;

		// Token: 0x040004BE RID: 1214
		public static int teams_teamcolor1r = -1;

		// Token: 0x040004BF RID: 1215
		public static int teams_teamcolor2b = -1;

		// Token: 0x040004C0 RID: 1216
		public static int teams_teamcolor2r = -1;

		// Token: 0x040004C1 RID: 1217
		public static int teams_teamcolor3r = -1;

		// Token: 0x040004C2 RID: 1218
		public static int teams_teamcolor1b = -1;

		// Token: 0x040004C3 RID: 1219
		public static int teams_latitude = -1;

		// Token: 0x040004C4 RID: 1220
		public static int teams_teamcolor3g = -1;

		// Token: 0x040004C5 RID: 1221
		public static int teams_teamcolor2g = -1;

		// Token: 0x040004C6 RID: 1222
		public static int teams_teamname = -1;

		// Token: 0x040004C7 RID: 1223
		public static int teams_adboardid = -1;

		// Token: 0x040004C8 RID: 1224
		public static int teams_teamcolor3b = -1;

		// Token: 0x040004C9 RID: 1225
		public static int teams_defmentality = -1;

		// Token: 0x040004CA RID: 1226
		public static int teams_powid = -1;

		// Token: 0x040004CB RID: 1227
		public static int teams_physioid_secondary = -1;

		// Token: 0x040004CC RID: 1228
		public static int teams_domesticprestige = -1;

		// Token: 0x040004CD RID: 1229
		public static int teams_genericint2 = -1;

		// Token: 0x040004CE RID: 1230
		public static int teams_jerseytype = -1;

		// Token: 0x040004CF RID: 1231
		public static int teams_rivalteam = -1;

		// Token: 0x040004D0 RID: 1232
		public static int teams_midfieldrating = -1;

		// Token: 0x040004D1 RID: 1233
		public static int teams_matchdayoverallrating = -1;

		// Token: 0x040004D2 RID: 1234
		public static int teams_matchdaymidfieldrating = -1;

		// Token: 0x040004D3 RID: 1235
		public static int teams_attackrating = -1;

		// Token: 0x040004D4 RID: 1236
		public static int teams_physioid_primary = -1;

		// Token: 0x040004D5 RID: 1237
		public static int teams_longitude = -1;

		// Token: 0x040004D6 RID: 1238
		public static int teams_buspassing = -1;

		// Token: 0x040004D7 RID: 1239
		public static int teams_matchdaydefenserating = -1;

		// Token: 0x040004D8 RID: 1240
		public static int teams_defenserating = -1;

		// Token: 0x040004D9 RID: 1241
		public static int teams_defteamwidth = -1;

		// Token: 0x040004DA RID: 1242
		public static int teams_longkicktakerid = -1;

		// Token: 0x040004DB RID: 1243
		public static int teams_bodytypeid = -1;

		// Token: 0x040004DC RID: 1244
		public static int teams_rightcornerkicktakerid = -1;

		// Token: 0x040004DD RID: 1245
		public static int teams_suitvariationid = -1;

		// Token: 0x040004DE RID: 1246
		public static int teams_defaggression = -1;

		// Token: 0x040004DF RID: 1247
		public static int teams_ethnicity = -1;

		// Token: 0x040004E0 RID: 1248
		public static int teams_leftcornerkicktakerid = -1;

		// Token: 0x040004E1 RID: 1249
		public static int teams_teamid = -1;

		// Token: 0x040004E2 RID: 1250
		public static int teams_fancrowdhairskintexturecode = -1;

		// Token: 0x040004E3 RID: 1251
		public static int teams_suittypeid = -1;

		// Token: 0x040004E4 RID: 1252
		public static int teams_numtransfersin = -1;

		// Token: 0x040004E5 RID: 1253
		public static int teams_captainid = -1;

		// Token: 0x040004E6 RID: 1254
		public static int teams_personalityid = -1;

		// Token: 0x040004E7 RID: 1255
		public static int teams_genericbanner = -1;

		// Token: 0x040004E8 RID: 1256
		public static int teams_buspositioning = -1;

		// Token: 0x040004E9 RID: 1257
		public static int teams_stafftracksuitcolorcode = -1;

		// Token: 0x040004EA RID: 1258
		public static int teams_ccpositioning = -1;

		// Token: 0x040004EB RID: 1259
		public static int teams_busbuildupspeed = -1;

		// Token: 0x040004EC RID: 1260
		public static int teams_transferbudget = -1;

		// Token: 0x040004ED RID: 1261
		public static int teams_ccshooting = -1;

		// Token: 0x040004EE RID: 1262
		public static int teams_overallrating = -1;

		// Token: 0x040004EF RID: 1263
		public static int teams_ccpassing = -1;

		// Token: 0x040004F0 RID: 1264
		public static int teams_utcoffset = -1;

		// Token: 0x040004F1 RID: 1265
		public static int teams_penaltytakerid = -1;

		// Token: 0x040004F2 RID: 1266
		public static int teams_freekicktakerid = -1;

		// Token: 0x040004F3 RID: 1267
		public static int teams_leftfreekicktakerid = -1;

		// Token: 0x040004F4 RID: 1268
		public static int teams_rightfreekicktakerid = -1;

		// Token: 0x040004F5 RID: 1269
		public static int teams_defdefenderline = -1;

		// Token: 0x040004F6 RID: 1270
		public static int teams_internationalprestige = -1;

		// Token: 0x040004F7 RID: 1271
		public static int teams_form = -1;

		// Token: 0x040004F8 RID: 1272
		public static int teams_genericint1 = -1;

		// Token: 0x040004F9 RID: 1273
		public static int teams_cccrossing = -1;

		// Token: 0x040004FA RID: 1274
		public static int teams_matchdayattackrating = -1;

		// Token: 0x040004FB RID: 1275
		public static int teams_trait1 = -1;

		// Token: 0x040004FC RID: 1276
		public static int teams_busdribbling = -1;

		// Token: 0x040004FD RID: 1277
		public static int teamplayerlinks_leaguegoals = -1;

		// Token: 0x040004FE RID: 1278
		public static int teamplayerlinks_isamongtopscorers = -1;

		// Token: 0x040004FF RID: 1279
		public static int teamplayerlinks_yellows = -1;

		// Token: 0x04000500 RID: 1280
		public static int teamplayerlinks_isamongtopscorersinteam = -1;

		// Token: 0x04000501 RID: 1281
		public static int teamplayerlinks_jerseynumber = -1;

		// Token: 0x04000502 RID: 1282
		public static int teamplayerlinks_position = -1;

		// Token: 0x04000503 RID: 1283
		public static int teamplayerlinks_artificialkey = -1;

		// Token: 0x04000504 RID: 1284
		public static int teamplayerlinks_teamid = -1;

		// Token: 0x04000505 RID: 1285
		public static int teamplayerlinks_injury = -1;

		// Token: 0x04000506 RID: 1286
		public static int teamplayerlinks_leagueappearances = -1;

		// Token: 0x04000507 RID: 1287
		public static int teamplayerlinks_leaguegoalsprevthreematches = -1;

		// Token: 0x04000508 RID: 1288
		public static int teamplayerlinks_leaguegoalsprevmatch = -1;

		// Token: 0x04000509 RID: 1289
		public static int teamplayerlinks_prevform = -1;

		// Token: 0x0400050A RID: 1290
		public static int teamplayerlinks_istopscorer = -1;

		// Token: 0x0400050B RID: 1291
		public static int teamplayerlinks_playerid = -1;

		// Token: 0x0400050C RID: 1292
		public static int teamplayerlinks_form = -1;

		// Token: 0x0400050D RID: 1293
		public static int teamplayerlinks_reds = -1;

		// Token: 0x0400050E RID: 1294
		public static int teamkits_shortsnumberplacementcode = -1;

		// Token: 0x0400050F RID: 1295
		public static int teamkits_teamcolorsecb = -1;

		// Token: 0x04000510 RID: 1296
		public static int teamkits_shortsrenderingdetailmaptype = -1;

		// Token: 0x04000511 RID: 1297
		public static int teamkits_jerseyfrontnumberplacementcode = -1;

		// Token: 0x04000512 RID: 1298
		public static int teamkits_teamcolorprimg = -1;

		// Token: 0x04000513 RID: 1299
		public static int teamkits_numberfonttype = -1;

		// Token: 0x04000514 RID: 1300
		public static int teamkits_teamcolortertb = -1;

		// Token: 0x04000515 RID: 1301
		public static int teamkits_jerseynamefonttype = -1;

		// Token: 0x04000516 RID: 1302
		public static int teamkits_jerseynamelayouttype = -1;

		// Token: 0x04000517 RID: 1303
		public static int teamkits_shortsnumbercolor = -1;

		// Token: 0x04000518 RID: 1304
		public static int teamkits_jerseyshapestyle = -1;

		// Token: 0x04000519 RID: 1305
		public static int teamkits_jerseybacknameplacementcode = -1;

		// Token: 0x0400051A RID: 1306
		public static int teamkits_teamcolorprimr = -1;

		// Token: 0x0400051B RID: 1307
		public static int teamkits_jerseynamecolorg = -1;

		// Token: 0x0400051C RID: 1308
		public static int teamkits_teamcolorsecg = -1;

		// Token: 0x0400051D RID: 1309
		public static int teamkits_teamcolortertr = -1;

		// Token: 0x0400051E RID: 1310
		public static int teamkits_renderingmaterialtype = -1;

		// Token: 0x0400051F RID: 1311
		public static int teamkits_teamcolorsecr = -1;

		// Token: 0x04000520 RID: 1312
		public static int teamkits_jerseycollargeometrytype = -1;

		// Token: 0x04000521 RID: 1313
		public static int teamkits_jerseynamecolorr = -1;

		// Token: 0x04000522 RID: 1314
		public static int teamkits_numbercolor = -1;

		// Token: 0x04000523 RID: 1315
		public static int teamkits_teamcolorprimb = -1;

		// Token: 0x04000524 RID: 1316
		public static int teamkits_jerseyrenderingdetailmaptype = -1;

		// Token: 0x04000525 RID: 1317
		public static int teamkits_shortsnumberfonttype = -1;

		// Token: 0x04000526 RID: 1318
		public static int teamkits_jerseynamecolorb = -1;

		// Token: 0x04000527 RID: 1319
		public static int teamkits_teamcolortertg = -1;

		// Token: 0x04000528 RID: 1320
		public static int teamkits_jerseybacknamefontcase = -1;

		// Token: 0x04000529 RID: 1321
		public static int teamkits_teamkittypetechid = -1;

		// Token: 0x0400052A RID: 1322
		public static int teamkits_powid = -1;

		// Token: 0x0400052B RID: 1323
		public static int teamkits_isinheritbasedetailmap = -1;

		// Token: 0x0400052C RID: 1324
		public static int teamkits_islocked = -1;

		// Token: 0x0400052D RID: 1325
		public static int teamkits_teamkitid = -1;

		// Token: 0x0400052E RID: 1326
		public static int teamkits_year = -1;

		// Token: 0x0400052F RID: 1327
		public static int teamkits_teamtechid = -1;

		// Token: 0x04000530 RID: 1328
		public static int teamkits_hasadvertisingkit = -1;

		// Token: 0x04000531 RID: 1329
		public static int teamkits_dlc = -1;

		// Token: 0x04000532 RID: 1330
		public static int teamkits_jerseyfit = -1;

		// Token: 0x04000533 RID: 1331
		public static int teamformdiff_overallratingdiff = -1;

		// Token: 0x04000534 RID: 1332
		public static int teamformdiff_olddefenserating = -1;

		// Token: 0x04000535 RID: 1333
		public static int teamformdiff_newoverallrating = -1;

		// Token: 0x04000536 RID: 1334
		public static int teamformdiff_oldoverallrating = -1;

		// Token: 0x04000537 RID: 1335
		public static int teamformdiff_oldattackrating = -1;

		// Token: 0x04000538 RID: 1336
		public static int teamformdiff_oldmidfieldrating = -1;

		// Token: 0x04000539 RID: 1337
		public static int teamformdiff_newdefenserating = -1;

		// Token: 0x0400053A RID: 1338
		public static int teamformdiff_teamid = -1;

		// Token: 0x0400053B RID: 1339
		public static int teamformdiff_newattackrating = -1;

		// Token: 0x0400053C RID: 1340
		public static int teamformdiff_newmidfieldrating = -1;

		// Token: 0x0400053D RID: 1341
		public static int teamballs_ballid = -1;

		// Token: 0x0400053E RID: 1342
		public static int teamballs_powid = -1;

		// Token: 0x0400053F RID: 1343
		public static int teamballs_islicensed = -1;

		// Token: 0x04000540 RID: 1344
		public static int teamballs_isavailableinstore = -1;

		// Token: 0x04000541 RID: 1345
		public static int teamballs_isembargoed = -1;

		// Token: 0x04000542 RID: 1346
		public static int stories_target_fixture = -1;

		// Token: 0x04000543 RID: 1347
		public static int stories_audioid = -1;

		// Token: 0x04000544 RID: 1348
		public static int stories_entity_id = -1;

		// Token: 0x04000545 RID: 1349
		public static int stories_chance = -1;

		// Token: 0x04000546 RID: 1350
		public static int stories_priority = -1;

		// Token: 0x04000547 RID: 1351
		public static int stories_entity_type = -1;

		// Token: 0x04000548 RID: 1352
		public static int stories_storyid = -1;

		// Token: 0x04000549 RID: 1353
		public static int starratingboundaries_stars = -1;

		// Token: 0x0400054A RID: 1354
		public static int starratingboundaries_starratingfrom = -1;

		// Token: 0x0400054B RID: 1355
		public static int starratingboundaries_starratingto = -1;

		// Token: 0x0400054C RID: 1356
		public static int stadiums_yearbuilt = -1;

		// Token: 0x0400054D RID: 1357
		public static int stadiums_name = -1;

		// Token: 0x0400054E RID: 1358
		public static int stadiums_timeofday3 = -1;

		// Token: 0x0400054F RID: 1359
		public static int stadiums_adboardsidelinedistance = -1;

		// Token: 0x04000550 RID: 1360
		public static int stadiums_stadiumgloalnetdepth = -1;

		// Token: 0x04000551 RID: 1361
		public static int stadiums_hometeamid = -1;

		// Token: 0x04000552 RID: 1362
		public static int stadiums_capacity = -1;

		// Token: 0x04000553 RID: 1363
		public static int stadiums_seatcolor = -1;

		// Token: 0x04000554 RID: 1364
		public static int stadiums_sectionfacedbydefault = -1;

		// Token: 0x04000555 RID: 1365
		public static int stadiums_policetypecode = -1;

		// Token: 0x04000556 RID: 1366
		public static int stadiums_timeofday4 = -1;

		// Token: 0x04000557 RID: 1367
		public static int stadiums_stadiumpitchlength = -1;

		// Token: 0x04000558 RID: 1368
		public static int stadiums_stadiumgoalnetstyle = -1;

		// Token: 0x04000559 RID: 1369
		public static int stadiums_stadiumgoalnetpattern = -1;

		// Token: 0x0400055A RID: 1370
		public static int stadiums_adboardtype = -1;

		// Token: 0x0400055B RID: 1371
		public static int stadiums_upgradetier = -1;

		// Token: 0x0400055C RID: 1372
		public static int stadiums_tod4weather = -1;

		// Token: 0x0400055D RID: 1373
		public static int stadiums_countrycode = -1;

		// Token: 0x0400055E RID: 1374
		public static int stadiums_stadiummowpattern_code = -1;

		// Token: 0x0400055F RID: 1375
		public static int stadiums_stadiumid = -1;

		// Token: 0x04000560 RID: 1376
		public static int stadiums_cameraheight = -1;

		// Token: 0x04000561 RID: 1377
		public static int stadiums_stadiumgoalnettype = -1;

		// Token: 0x04000562 RID: 1378
		public static int stadiums_stadiumpitchwidth = -1;

		// Token: 0x04000563 RID: 1379
		public static int stadiums_stadiumtype = -1;

		// Token: 0x04000564 RID: 1380
		public static int stadiums_stadiumgoalnettension = -1;

		// Token: 0x04000565 RID: 1381
		public static int stadiums_tod1weather = -1;

		// Token: 0x04000566 RID: 1382
		public static int stadiums_dlc = -1;

		// Token: 0x04000567 RID: 1383
		public static int stadiums_tod2weather = -1;

		// Token: 0x04000568 RID: 1384
		public static int stadiums_camerazoom = -1;

		// Token: 0x04000569 RID: 1385
		public static int stadiums_adboardendlinedistance = -1;

		// Token: 0x0400056A RID: 1386
		public static int stadiums_iseditable = -1;

		// Token: 0x0400056B RID: 1387
		public static int stadiums_isdynamic = -1;

		// Token: 0x0400056C RID: 1388
		public static int stadiums_tod3weather = -1;

		// Token: 0x0400056D RID: 1389
		public static int stadiums_upgradestyle = -1;

		// Token: 0x0400056E RID: 1390
		public static int stadiums_genericrank = -1;

		// Token: 0x0400056F RID: 1391
		public static int stadiums_timeofday1 = -1;

		// Token: 0x04000570 RID: 1392
		public static int stadiums_timeofday2 = -1;

		// Token: 0x04000571 RID: 1393
		public static int stadiums_stadiumgoalnetwidth = -1;

		// Token: 0x04000572 RID: 1394
		public static int stadiums_stadiumgoalnetlength = -1;

		// Token: 0x04000573 RID: 1395
		public static int stadiums_islicensed = -1;

		// Token: 0x04000574 RID: 1396
		public static int stadiums_stadhometechzonemaxz = -1;

		// Token: 0x04000575 RID: 1397
		public static int stadiums_stadawaytechzonemaxx = -1;

		// Token: 0x04000576 RID: 1398
		public static int stadiums_stadhometechzonemaxx = -1;

		// Token: 0x04000577 RID: 1399
		public static int stadiums_stadawaytechzoneminz = -1;

		// Token: 0x04000578 RID: 1400
		public static int stadiums_stadhometechzoneminx = -1;

		// Token: 0x04000579 RID: 1401
		public static int stadiums_stadhometechzoneminz = -1;

		// Token: 0x0400057A RID: 1402
		public static int stadiums_stadawaytechzonemaxz = -1;

		// Token: 0x0400057B RID: 1403
		public static int stadiums_stadawaytechzoneminx = -1;

		// Token: 0x0400057C RID: 1404
		public static int shoecolors_blue = -1;

		// Token: 0x0400057D RID: 1405
		public static int shoecolors_green = -1;

		// Token: 0x0400057E RID: 1406
		public static int shoecolors_red = -1;

		// Token: 0x0400057F RID: 1407
		public static int shoecolors_colorid = -1;

		// Token: 0x04000580 RID: 1408
		public static int rowteamnationlinks_nationid = -1;

		// Token: 0x04000581 RID: 1409
		public static int rowteamnationlinks_teamid = -1;

		// Token: 0x04000582 RID: 1410
		public static int rivals_rivaltype = -1;

		// Token: 0x04000583 RID: 1411
		public static int rivals_teamid2 = -1;

		// Token: 0x04000584 RID: 1412
		public static int rivals_teamid1 = -1;

		// Token: 0x04000585 RID: 1413
		public static int restrictedplayers_fixtureid = -1;

		// Token: 0x04000586 RID: 1414
		public static int restrictedplayers_reason = -1;

		// Token: 0x04000587 RID: 1415
		public static int restrictedplayers_replacementplayerid = -1;

		// Token: 0x04000588 RID: 1416
		public static int restrictedplayers_teamid = -1;

		// Token: 0x04000589 RID: 1417
		public static int restrictedplayers_playerid = -1;

		// Token: 0x0400058A RID: 1418
		public static int referee_birthdate = -1;

		// Token: 0x0400058B RID: 1419
		public static int referee_firstname = -1;

		// Token: 0x0400058C RID: 1420
		public static int referee_shoetypecode = -1;

		// Token: 0x0400058D RID: 1421
		public static int referee_surname = -1;

		// Token: 0x0400058E RID: 1422
		public static int referee_nationalitycode = -1;

		// Token: 0x0400058F RID: 1423
		public static int referee_haircolorcode = -1;

		// Token: 0x04000590 RID: 1424
		public static int referee_facialhairtypecode = -1;

		// Token: 0x04000591 RID: 1425
		public static int referee_hairtypecode = -1;

		// Token: 0x04000592 RID: 1426
		public static int referee_cardstrictness = -1;

		// Token: 0x04000593 RID: 1427
		public static int referee_shoecolorcode2 = -1;

		// Token: 0x04000594 RID: 1428
		public static int referee_stylecode = -1;

		// Token: 0x04000595 RID: 1429
		public static int referee_proxyhaircolorid = -1;

		// Token: 0x04000596 RID: 1430
		public static int referee_headtypecode = -1;

		// Token: 0x04000597 RID: 1431
		public static int referee_foulstrictness = -1;

		// Token: 0x04000598 RID: 1432
		public static int referee_height = -1;

		// Token: 0x04000599 RID: 1433
		public static int referee_hairstateid = -1;

		// Token: 0x0400059A RID: 1434
		public static int referee_leagueid = -1;

		// Token: 0x0400059B RID: 1435
		public static int referee_sockheightcode = -1;

		// Token: 0x0400059C RID: 1436
		public static int referee_weight = -1;

		// Token: 0x0400059D RID: 1437
		public static int referee_proxyheadclass = -1;

		// Token: 0x0400059E RID: 1438
		public static int referee_gender = -1;

		// Token: 0x0400059F RID: 1439
		public static int referee_eyebrowcode = -1;

		// Token: 0x040005A0 RID: 1440
		public static int referee_eyecolorcode = -1;

		// Token: 0x040005A1 RID: 1441
		public static int referee_jerseysleevelengthcode = -1;

		// Token: 0x040005A2 RID: 1442
		public static int referee_hairlinecode = -1;

		// Token: 0x040005A3 RID: 1443
		public static int referee_headclasscode = -1;

		// Token: 0x040005A4 RID: 1444
		public static int referee_haireffecttypecode = -1;

		// Token: 0x040005A5 RID: 1445
		public static int referee_sideburnscode = -1;

		// Token: 0x040005A6 RID: 1446
		public static int referee_skintypecode = -1;

		// Token: 0x040005A7 RID: 1447
		public static int referee_hairpartcode = -1;

		// Token: 0x040005A8 RID: 1448
		public static int referee_sweatid = -1;

		// Token: 0x040005A9 RID: 1449
		public static int referee_skintonecode = -1;

		// Token: 0x040005AA RID: 1450
		public static int referee_hairvariationid = -1;

		// Token: 0x040005AB RID: 1451
		public static int referee_refereeid = -1;

		// Token: 0x040005AC RID: 1452
		public static int referee_homecitycode = -1;

		// Token: 0x040005AD RID: 1453
		public static int referee_shoedesigncode = -1;

		// Token: 0x040005AE RID: 1454
		public static int referee_shoecolorcode1 = -1;

		// Token: 0x040005AF RID: 1455
		public static int referee_bodytypecode = -1;

		// Token: 0x040005B0 RID: 1456
		public static int referee_wrinkleid = -1;

		// Token: 0x040005B1 RID: 1457
		public static int referee_facialhaircolorcode = -1;

		// Token: 0x040005B2 RID: 1458
		public static int referee_isreal = -1;

		// Token: 0x040005B3 RID: 1459
		public static int previousteam_previousteamid = -1;

		// Token: 0x040005B4 RID: 1460
		public static int previousteam_playerid = -1;

		// Token: 0x040005B5 RID: 1461
		public static int players_birthdate = -1;

		// Token: 0x040005B6 RID: 1462
		public static int players_playerjointeamdate = -1;

		// Token: 0x040005B7 RID: 1463
		public static int players_shoetypecode = -1;

		// Token: 0x040005B8 RID: 1464
		public static int players_haircolorcode = -1;

		// Token: 0x040005B9 RID: 1465
		public static int players_facialhairtypecode = -1;

		// Token: 0x040005BA RID: 1466
		public static int players_curve = -1;

		// Token: 0x040005BB RID: 1467
		public static int players_jerseystylecode = -1;

		// Token: 0x040005BC RID: 1468
		public static int players_agility = -1;

		// Token: 0x040005BD RID: 1469
		public static int players_accessorycode4 = -1;

		// Token: 0x040005BE RID: 1470
		public static int players_gksavetype = -1;

		// Token: 0x040005BF RID: 1471
		public static int players_positioning = -1;

		// Token: 0x040005C0 RID: 1472
		public static int players_hairtypecode = -1;

		// Token: 0x040005C1 RID: 1473
		public static int players_standingtackle = -1;

		// Token: 0x040005C2 RID: 1474
		public static int players_faceposercode = -1;

		// Token: 0x040005C3 RID: 1475
		public static int players_preferredposition3 = -1;

		// Token: 0x040005C4 RID: 1476
		public static int players_longpassing = -1;

		// Token: 0x040005C5 RID: 1477
		public static int players_penalties = -1;

		// Token: 0x040005C6 RID: 1478
		public static int players_animfreekickstartposcode = -1;

		// Token: 0x040005C7 RID: 1479
		public static int players_animpenaltieskickstylecode = -1;

		// Token: 0x040005C8 RID: 1480
		public static int players_isretiring = -1;

		// Token: 0x040005C9 RID: 1481
		public static int players_longshots = -1;

		// Token: 0x040005CA RID: 1482
		public static int players_gkdiving = -1;

		// Token: 0x040005CB RID: 1483
		public static int players_interceptions = -1;

		// Token: 0x040005CC RID: 1484
		public static int players_shoecolorcode2 = -1;

		// Token: 0x040005CD RID: 1485
		public static int players_crossing = -1;

		// Token: 0x040005CE RID: 1486
		public static int players_potential = -1;

		// Token: 0x040005CF RID: 1487
		public static int players_gkreflexes = -1;

		// Token: 0x040005D0 RID: 1488
		public static int players_finishingcode1 = -1;

		// Token: 0x040005D1 RID: 1489
		public static int players_reactions = -1;

		// Token: 0x040005D2 RID: 1490
		public static int players_vision = -1;

		// Token: 0x040005D3 RID: 1491
		public static int players_contractvaliduntil = -1;

		// Token: 0x040005D4 RID: 1492
		public static int players_finishing = -1;

		// Token: 0x040005D5 RID: 1493
		public static int players_dribbling = -1;

		// Token: 0x040005D6 RID: 1494
		public static int players_slidingtackle = -1;

		// Token: 0x040005D7 RID: 1495
		public static int players_accessorycode3 = -1;

		// Token: 0x040005D8 RID: 1496
		public static int players_accessorycolourcode1 = -1;

		// Token: 0x040005D9 RID: 1497
		public static int players_headtypecode = -1;

		// Token: 0x040005DA RID: 1498
		public static int players_firstnameid = -1;

		// Token: 0x040005DB RID: 1499
		public static int players_sprintspeed = -1;

		// Token: 0x040005DC RID: 1500
		public static int players_height = -1;

		// Token: 0x040005DD RID: 1501
		public static int players_hasseasonaljersey = -1;

		// Token: 0x040005DE RID: 1502
		public static int players_preferredposition2 = -1;

		// Token: 0x040005DF RID: 1503
		public static int players_strength = -1;

		// Token: 0x040005E0 RID: 1504
		public static int players_preferredposition1 = -1;

		// Token: 0x040005E1 RID: 1505
		public static int players_ballcontrol = -1;

		// Token: 0x040005E2 RID: 1506
		public static int players_shotpower = -1;

		// Token: 0x040005E3 RID: 1507
		public static int players_trait1 = -1;

		// Token: 0x040005E4 RID: 1508
		public static int players_socklengthcode = -1;

		// Token: 0x040005E5 RID: 1509
		public static int players_weight = -1;

		// Token: 0x040005E6 RID: 1510
		public static int players_hashighqualityhead = -1;

		// Token: 0x040005E7 RID: 1511
		public static int players_gkglovetypecode = -1;

		// Token: 0x040005E8 RID: 1512
		public static int players_balance = -1;

		// Token: 0x040005E9 RID: 1513
		public static int players_gkkicking = -1;

		// Token: 0x040005EA RID: 1514
		public static int players_lastnameid = -1;

		// Token: 0x040005EB RID: 1515
		public static int players_internationalrep = -1;

		// Token: 0x040005EC RID: 1516
		public static int players_animpenaltiesmotionstylecode = -1;

		// Token: 0x040005ED RID: 1517
		public static int players_shortpassing = -1;

		// Token: 0x040005EE RID: 1518
		public static int players_freekickaccuracy = -1;

		// Token: 0x040005EF RID: 1519
		public static int players_skillmoves = -1;

		// Token: 0x040005F0 RID: 1520
		public static int players_usercaneditname = -1;

		// Token: 0x040005F1 RID: 1521
		public static int players_attackingworkrate = -1;

		// Token: 0x040005F2 RID: 1522
		public static int players_finishingcode2 = -1;

		// Token: 0x040005F3 RID: 1523
		public static int players_aggression = -1;

		// Token: 0x040005F4 RID: 1524
		public static int players_acceleration = -1;

		// Token: 0x040005F5 RID: 1525
		public static int players_headingaccuracy = -1;

		// Token: 0x040005F6 RID: 1526
		public static int players_eyebrowcode = -1;

		// Token: 0x040005F7 RID: 1527
		public static int players_runningcode2 = -1;

		// Token: 0x040005F8 RID: 1528
		public static int players_gkhandling = -1;

		// Token: 0x040005F9 RID: 1529
		public static int players_eyecolorcode = -1;

		// Token: 0x040005FA RID: 1530
		public static int players_jerseysleevelengthcode = -1;

		// Token: 0x040005FB RID: 1531
		public static int players_accessorycolourcode3 = -1;

		// Token: 0x040005FC RID: 1532
		public static int players_accessorycode1 = -1;

		// Token: 0x040005FD RID: 1533
		public static int players_headclasscode = -1;

		// Token: 0x040005FE RID: 1534
		public static int players_defensiveworkrate = -1;

		// Token: 0x040005FF RID: 1535
		public static int players_nationality = -1;

		// Token: 0x04000600 RID: 1536
		public static int players_preferredfoot = -1;

		// Token: 0x04000601 RID: 1537
		public static int players_sideburnscode = -1;

		// Token: 0x04000602 RID: 1538
		public static int players_weakfootabilitytypecode = -1;

		// Token: 0x04000603 RID: 1539
		public static int players_jumping = -1;

		// Token: 0x04000604 RID: 1540
		public static int players_skintypecode = -1;

		// Token: 0x04000605 RID: 1541
		public static int players_gkkickstyle = -1;

		// Token: 0x04000606 RID: 1542
		public static int players_stamina = -1;

		// Token: 0x04000607 RID: 1543
		public static int players_playerid = -1;

		// Token: 0x04000608 RID: 1544
		public static int players_marking = -1;

		// Token: 0x04000609 RID: 1545
		public static int players_accessorycolourcode4 = -1;

		// Token: 0x0400060A RID: 1546
		public static int players_gkpositioning = -1;

		// Token: 0x0400060B RID: 1547
		public static int players_trait2 = -1;

		// Token: 0x0400060C RID: 1548
		public static int players_skintonecode = -1;

		// Token: 0x0400060D RID: 1549
		public static int players_shortstyle = -1;

		// Token: 0x0400060E RID: 1550
		public static int players_overallrating = -1;

		// Token: 0x0400060F RID: 1551
		public static int players_jerseyfit = -1;

		// Token: 0x04000610 RID: 1552
		public static int players_accessorycode2 = -1;

		// Token: 0x04000611 RID: 1553
		public static int players_shoedesigncode = -1;

		// Token: 0x04000612 RID: 1554
		public static int players_playerjerseynameid = -1;

		// Token: 0x04000613 RID: 1555
		public static int players_shoecolorcode1 = -1;

		// Token: 0x04000614 RID: 1556
		public static int players_commonnameid = -1;

		// Token: 0x04000615 RID: 1557
		public static int players_bodytypecode = -1;

		// Token: 0x04000616 RID: 1558
		public static int players_animpenaltiesstartposcode = -1;

		// Token: 0x04000617 RID: 1559
		public static int players_runningcode1 = -1;

		// Token: 0x04000618 RID: 1560
		public static int players_preferredposition4 = -1;

		// Token: 0x04000619 RID: 1561
		public static int players_volleys = -1;

		// Token: 0x0400061A RID: 1562
		public static int players_gender = -1;

		// Token: 0x0400061B RID: 1563
		public static int players_emotion = -1;

		// Token: 0x0400061C RID: 1564
		public static int players_accessorycolourcode2 = -1;

		// Token: 0x0400061D RID: 1565
		public static int players_facialhaircolorcode = -1;

		// Token: 0x0400061E RID: 1566
		public static int playernames_name = -1;

		// Token: 0x0400061F RID: 1567
		public static int playernames_commentaryid = -1;

		// Token: 0x04000620 RID: 1568
		public static int playernames_nameid = -1;

		// Token: 0x04000621 RID: 1569
		public static int dcplayernames_name = -1;

		// Token: 0x04000622 RID: 1570
		public static int dcplayernames_nameid = -1;

		// Token: 0x04000623 RID: 1571
		public static int playerloans_loandateend = -1;

		// Token: 0x04000624 RID: 1572
		public static int playerloans_teamidloanedfrom = -1;

		// Token: 0x04000625 RID: 1573
		public static int playerloans_playerid = -1;

		// Token: 0x04000626 RID: 1574
		public static int playerformdiff_overallratingdiff = -1;

		// Token: 0x04000627 RID: 1575
		public static int playerformdiff_newoverallrating = -1;

		// Token: 0x04000628 RID: 1576
		public static int playerformdiff_oldoverallrating = -1;

		// Token: 0x04000629 RID: 1577
		public static int playerformdiff_teamid = -1;

		// Token: 0x0400062A RID: 1578
		public static int playerformdiff_playerid = -1;

		// Token: 0x0400062B RID: 1579
		public static int playerboots_shoetype = -1;

		// Token: 0x0400062C RID: 1580
		public static int playerboots_powid = -1;

		// Token: 0x0400062D RID: 1581
		public static int playerboots_islocked = -1;

		// Token: 0x0400062E RID: 1582
		public static int playerboots_islegacy = -1;

		// Token: 0x0400062F RID: 1583
		public static int playerboots_isembargoed = -1;

		// Token: 0x04000630 RID: 1584
		public static int playerboots_gender = -1;

		// Token: 0x04000631 RID: 1585
		public static int playerboots_shoecolor1 = -1;

		// Token: 0x04000632 RID: 1586
		public static int playerboots_islicensed = -1;

		// Token: 0x04000633 RID: 1587
		public static int playerboots_isavailableinstore = -1;

		// Token: 0x04000634 RID: 1588
		public static int playerboots_isadidas = -1;

		// Token: 0x04000635 RID: 1589
		public static int playerboots_shoedesign = -1;

		// Token: 0x04000636 RID: 1590
		public static int playerboots_shoecolor2 = -1;

		// Token: 0x04000637 RID: 1591
		public static int player_grudgelove_level_of_emotion = -1;

		// Token: 0x04000638 RID: 1592
		public static int player_grudgelove_playerid = -1;

		// Token: 0x04000639 RID: 1593
		public static int player_grudgelove_emotional_teamid = -1;

		// Token: 0x0400063A RID: 1594
		public static int physio_birthdate = -1;

		// Token: 0x0400063B RID: 1595
		public static int physio_firstname = -1;

		// Token: 0x0400063C RID: 1596
		public static int physio_surname = -1;

		// Token: 0x0400063D RID: 1597
		public static int physio_haircolorcode = -1;

		// Token: 0x0400063E RID: 1598
		public static int physio_facialhairtypecode = -1;

		// Token: 0x0400063F RID: 1599
		public static int physio_hairtypecode = -1;

		// Token: 0x04000640 RID: 1600
		public static int physio_headtypecode = -1;

		// Token: 0x04000641 RID: 1601
		public static int physio_eyebrowcode = -1;

		// Token: 0x04000642 RID: 1602
		public static int physio_eyecolorcode = -1;

		// Token: 0x04000643 RID: 1603
		public static int physio_physioid = -1;

		// Token: 0x04000644 RID: 1604
		public static int physio_headclasscode = -1;

		// Token: 0x04000645 RID: 1605
		public static int physio_haireffecttypecode = -1;

		// Token: 0x04000646 RID: 1606
		public static int physio_skintonecode = -1;

		// Token: 0x04000647 RID: 1607
		public static int physio_nationalitycode = -1;

		// Token: 0x04000648 RID: 1608
		public static int physio_bodytypecode = -1;

		// Token: 0x04000649 RID: 1609
		public static int physio_facialhaircolorcode = -1;

		// Token: 0x0400064A RID: 1610
		public static int teamnationlinks_nationid = -1;

		// Token: 0x0400064B RID: 1611
		public static int teamnationlinks_teamid = -1;

		// Token: 0x0400064C RID: 1612
		public static int nations_nationname = -1;

		// Token: 0x0400064D RID: 1613
		public static int nations_nationid = -1;

		// Token: 0x0400064E RID: 1614
		public static int nations_confederation = -1;

		// Token: 0x0400064F RID: 1615
		public static int nations_top_tier = -1;

		// Token: 0x04000650 RID: 1616
		public static int nations_nationstartingfirstletter = -1;

		// Token: 0x04000651 RID: 1617
		public static int nations_isocountrycode = -1;

		// Token: 0x04000652 RID: 1618
		public static int nations_teamid = -1;

		// Token: 0x04000653 RID: 1619
		public static int manager_firstname = -1;

		// Token: 0x04000654 RID: 1620
		public static int manager_surname = -1;

		// Token: 0x04000655 RID: 1621
		public static int manager_teamid = -1;

		// Token: 0x04000656 RID: 1622
		public static int leagueteamlinks_teamshortform = -1;

		// Token: 0x04000657 RID: 1623
		public static int leagueteamlinks_hasachievedobjective = -1;

		// Token: 0x04000658 RID: 1624
		public static int leagueteamlinks_yettowin = -1;

		// Token: 0x04000659 RID: 1625
		public static int leagueteamlinks_unbeatenallcomps = -1;

		// Token: 0x0400065A RID: 1626
		public static int leagueteamlinks_unbeatenleague = -1;

		// Token: 0x0400065B RID: 1627
		public static int leagueteamlinks_champion = -1;

		// Token: 0x0400065C RID: 1628
		public static int leagueteamlinks_leagueid = -1;

		// Token: 0x0400065D RID: 1629
		public static int leagueteamlinks_prevleagueid = -1;

		// Token: 0x0400065E RID: 1630
		public static int leagueteamlinks_previousyeartableposition = -1;

		// Token: 0x0400065F RID: 1631
		public static int leagueteamlinks_highestpossible = -1;

		// Token: 0x04000660 RID: 1632
		public static int leagueteamlinks_teamform = -1;

		// Token: 0x04000661 RID: 1633
		public static int leagueteamlinks_highestprobable = -1;

		// Token: 0x04000662 RID: 1634
		public static int leagueteamlinks_artificialkey = -1;

		// Token: 0x04000663 RID: 1635
		public static int leagueteamlinks_nummatchesplayed = -1;

		// Token: 0x04000664 RID: 1636
		public static int leagueteamlinks_teamid = -1;

		// Token: 0x04000665 RID: 1637
		public static int leagueteamlinks_gapresult = -1;

		// Token: 0x04000666 RID: 1638
		public static int leagueteamlinks_grouping = -1;

		// Token: 0x04000667 RID: 1639
		public static int leagueteamlinks_currenttableposition = -1;

		// Token: 0x04000668 RID: 1640
		public static int leagueteamlinks_objective = -1;

		// Token: 0x04000669 RID: 1641
		public static int leagueteamlinks_actualvsexpectations = -1;

		// Token: 0x0400066A RID: 1642
		public static int leagueteamlinks_unbeatenhome = -1;

		// Token: 0x0400066B RID: 1643
		public static int leagueteamlinks_lastgameresult = -1;

		// Token: 0x0400066C RID: 1644
		public static int leagueteamlinks_unbeatenaway = -1;

		// Token: 0x0400066D RID: 1645
		public static int leagueteamlinks_teamlongform = -1;

		// Token: 0x0400066E RID: 1646
		public static int leagueteamlinks_homega = -1;

		// Token: 0x0400066F RID: 1647
		public static int leagueteamlinks_homegf = -1;

		// Token: 0x04000670 RID: 1648
		public static int leagueteamlinks_points = -1;

		// Token: 0x04000671 RID: 1649
		public static int leagueteamlinks_awayga = -1;

		// Token: 0x04000672 RID: 1650
		public static int leagueteamlinks_awaygf = -1;

		// Token: 0x04000673 RID: 1651
		public static int leagueteamlinks_secondarytable = -1;

		// Token: 0x04000674 RID: 1652
		public static int leagueteamlinks_homewins = -1;

		// Token: 0x04000675 RID: 1653
		public static int leagueteamlinks_awaywins = -1;

		// Token: 0x04000676 RID: 1654
		public static int leagueteamlinks_homelosses = -1;

		// Token: 0x04000677 RID: 1655
		public static int leagueteamlinks_awaylosses = -1;

		// Token: 0x04000678 RID: 1656
		public static int leagueteamlinks_awaydraws = -1;

		// Token: 0x04000679 RID: 1657
		public static int leagueteamlinks_homedraws = -1;

		// Token: 0x0400067A RID: 1658
		public static int leagues_countryid = -1;

		// Token: 0x0400067B RID: 1659
		public static int leagues_leaguename = -1;

		// Token: 0x0400067C RID: 1660
		public static int leagues_level = -1;

		// Token: 0x0400067D RID: 1661
		public static int leagues_leagueid = -1;

		// Token: 0x0400067E RID: 1662
		public static int leagues_leaguetimeslice = -1;

		// Token: 0x0400067F RID: 1663
		public static int leagues_iswithintransferwindow = -1;

		// Token: 0x04000680 RID: 1664
		public static int leaguerefereelinks_leagueid = -1;

		// Token: 0x04000681 RID: 1665
		public static int leaguerefereelinks_refereeid = -1;

		// Token: 0x04000682 RID: 1666
		public static int formupdate_leagueid = -1;

		// Token: 0x04000683 RID: 1667
		public static int formupdate_position = -1;

		// Token: 0x04000684 RID: 1668
		public static int formupdate_teamid = -1;

		// Token: 0x04000685 RID: 1669
		public static int formupdate_formaudio = -1;

		// Token: 0x04000686 RID: 1670
		public static int formupdate_prevform = -1;

		// Token: 0x04000687 RID: 1671
		public static int formupdate_playerid = -1;

		// Token: 0x04000688 RID: 1672
		public static int formupdate_overallrating = -1;

		// Token: 0x04000689 RID: 1673
		public static int formupdate_form = -1;

		// Token: 0x0400068A RID: 1674
		public static int formations_attackers = -1;

		// Token: 0x0400068B RID: 1675
		public static int formations_attackingdirection_0 = -1;

		// Token: 0x0400068C RID: 1676
		public static int formations_attackingdirection_1 = -1;

		// Token: 0x0400068D RID: 1677
		public static int formations_attackingdirection_10 = -1;

		// Token: 0x0400068E RID: 1678
		public static int formations_attackingdirection_2 = -1;

		// Token: 0x0400068F RID: 1679
		public static int formations_attackingdirection_3 = -1;

		// Token: 0x04000690 RID: 1680
		public static int formations_attackingdirection_4 = -1;

		// Token: 0x04000691 RID: 1681
		public static int formations_attackingdirection_5 = -1;

		// Token: 0x04000692 RID: 1682
		public static int formations_attackingdirection_6 = -1;

		// Token: 0x04000693 RID: 1683
		public static int formations_attackingdirection_7 = -1;

		// Token: 0x04000694 RID: 1684
		public static int formations_attackingdirection_8 = -1;

		// Token: 0x04000695 RID: 1685
		public static int formations_attackingdirection_9 = -1;

		// Token: 0x04000696 RID: 1686
		public static int formations_attackingrole_0 = -1;

		// Token: 0x04000697 RID: 1687
		public static int formations_attackingrole_1 = -1;

		// Token: 0x04000698 RID: 1688
		public static int formations_attackingrole_10 = -1;

		// Token: 0x04000699 RID: 1689
		public static int formations_attackingrole_2 = -1;

		// Token: 0x0400069A RID: 1690
		public static int formations_attackingrole_3 = -1;

		// Token: 0x0400069B RID: 1691
		public static int formations_attackingrole_4 = -1;

		// Token: 0x0400069C RID: 1692
		public static int formations_attackingrole_5 = -1;

		// Token: 0x0400069D RID: 1693
		public static int formations_attackingrole_6 = -1;

		// Token: 0x0400069E RID: 1694
		public static int formations_attackingrole_7 = -1;

		// Token: 0x0400069F RID: 1695
		public static int formations_attackingrole_8 = -1;

		// Token: 0x040006A0 RID: 1696
		public static int formations_attackingrole_9 = -1;

		// Token: 0x040006A1 RID: 1697
		public static int formations_defenders = -1;

		// Token: 0x040006A2 RID: 1698
		public static int formations_defensivedirection_0 = -1;

		// Token: 0x040006A3 RID: 1699
		public static int formations_defensivedirection_1 = -1;

		// Token: 0x040006A4 RID: 1700
		public static int formations_defensivedirection_10 = -1;

		// Token: 0x040006A5 RID: 1701
		public static int formations_defensivedirection_2 = -1;

		// Token: 0x040006A6 RID: 1702
		public static int formations_defensivedirection_3 = -1;

		// Token: 0x040006A7 RID: 1703
		public static int formations_defensivedirection_4 = -1;

		// Token: 0x040006A8 RID: 1704
		public static int formations_defensivedirection_5 = -1;

		// Token: 0x040006A9 RID: 1705
		public static int formations_defensivedirection_6 = -1;

		// Token: 0x040006AA RID: 1706
		public static int formations_defensivedirection_7 = -1;

		// Token: 0x040006AB RID: 1707
		public static int formations_defensivedirection_8 = -1;

		// Token: 0x040006AC RID: 1708
		public static int formations_defensivedirection_9 = -1;

		// Token: 0x040006AD RID: 1709
		public static int formations_defensiverole_0 = -1;

		// Token: 0x040006AE RID: 1710
		public static int formations_defensiverole_1 = -1;

		// Token: 0x040006AF RID: 1711
		public static int formations_defensiverole_10 = -1;

		// Token: 0x040006B0 RID: 1712
		public static int formations_defensiverole_2 = -1;

		// Token: 0x040006B1 RID: 1713
		public static int formations_defensiverole_3 = -1;

		// Token: 0x040006B2 RID: 1714
		public static int formations_defensiverole_4 = -1;

		// Token: 0x040006B3 RID: 1715
		public static int formations_defensiverole_5 = -1;

		// Token: 0x040006B4 RID: 1716
		public static int formations_defensiverole_6 = -1;

		// Token: 0x040006B5 RID: 1717
		public static int formations_defensiverole_7 = -1;

		// Token: 0x040006B6 RID: 1718
		public static int formations_defensiverole_8 = -1;

		// Token: 0x040006B7 RID: 1719
		public static int formations_defensiverole_9 = -1;

		// Token: 0x040006B8 RID: 1720
		public static int formations_formationaudioid = -1;

		// Token: 0x040006B9 RID: 1721
		public static int formations_formationfullnameid = -1;

		// Token: 0x040006BA RID: 1722
		public static int formations_formationid = -1;

		// Token: 0x040006BB RID: 1723
		public static int formations_formationname = -1;

		// Token: 0x040006BC RID: 1724
		public static int formations_midfielders = -1;

		// Token: 0x040006BD RID: 1725
		public static int formations_offensiverating = -1;

		// Token: 0x040006BE RID: 1726
		public static int formations_offset0x = -1;

		// Token: 0x040006BF RID: 1727
		public static int formations_offset0y = -1;

		// Token: 0x040006C0 RID: 1728
		public static int formations_offset10x = -1;

		// Token: 0x040006C1 RID: 1729
		public static int formations_offset10y = -1;

		// Token: 0x040006C2 RID: 1730
		public static int formations_offset1x = -1;

		// Token: 0x040006C3 RID: 1731
		public static int formations_offset1y = -1;

		// Token: 0x040006C4 RID: 1732
		public static int formations_offset2x = -1;

		// Token: 0x040006C5 RID: 1733
		public static int formations_offset2y = -1;

		// Token: 0x040006C6 RID: 1734
		public static int formations_offset3x = -1;

		// Token: 0x040006C7 RID: 1735
		public static int formations_offset3y = -1;

		// Token: 0x040006C8 RID: 1736
		public static int formations_offset4x = -1;

		// Token: 0x040006C9 RID: 1737
		public static int formations_offset4y = -1;

		// Token: 0x040006CA RID: 1738
		public static int formations_offset5x = -1;

		// Token: 0x040006CB RID: 1739
		public static int formations_offset5y = -1;

		// Token: 0x040006CC RID: 1740
		public static int formations_offset6x = -1;

		// Token: 0x040006CD RID: 1741
		public static int formations_offset6y = -1;

		// Token: 0x040006CE RID: 1742
		public static int formations_offset7x = -1;

		// Token: 0x040006CF RID: 1743
		public static int formations_offset7y = -1;

		// Token: 0x040006D0 RID: 1744
		public static int formations_offset8x = -1;

		// Token: 0x040006D1 RID: 1745
		public static int formations_offset8y = -1;

		// Token: 0x040006D2 RID: 1746
		public static int formations_offset9x = -1;

		// Token: 0x040006D3 RID: 1747
		public static int formations_offset9y = -1;

		// Token: 0x040006D4 RID: 1748
		public static int formations_playerinstruction0 = -1;

		// Token: 0x040006D5 RID: 1749
		public static int formations_playerinstruction1 = -1;

		// Token: 0x040006D6 RID: 1750
		public static int formations_playerinstruction2 = -1;

		// Token: 0x040006D7 RID: 1751
		public static int formations_playerinstruction3 = -1;

		// Token: 0x040006D8 RID: 1752
		public static int formations_playerinstruction4 = -1;

		// Token: 0x040006D9 RID: 1753
		public static int formations_playerinstruction5 = -1;

		// Token: 0x040006DA RID: 1754
		public static int formations_playerinstruction6 = -1;

		// Token: 0x040006DB RID: 1755
		public static int formations_playerinstruction7 = -1;

		// Token: 0x040006DC RID: 1756
		public static int formations_playerinstruction8 = -1;

		// Token: 0x040006DD RID: 1757
		public static int formations_playerinstruction9 = -1;

		// Token: 0x040006DE RID: 1758
		public static int formations_playerinstruction10 = -1;

		// Token: 0x040006DF RID: 1759
		public static int formations_playerinstruction0_1 = -1;

		// Token: 0x040006E0 RID: 1760
		public static int formations_playerinstruction1_1 = -1;

		// Token: 0x040006E1 RID: 1761
		public static int formations_playerinstruction2_1 = -1;

		// Token: 0x040006E2 RID: 1762
		public static int formations_playerinstruction3_1 = -1;

		// Token: 0x040006E3 RID: 1763
		public static int formations_playerinstruction4_1 = -1;

		// Token: 0x040006E4 RID: 1764
		public static int formations_playerinstruction5_1 = -1;

		// Token: 0x040006E5 RID: 1765
		public static int formations_playerinstruction6_1 = -1;

		// Token: 0x040006E6 RID: 1766
		public static int formations_playerinstruction7_1 = -1;

		// Token: 0x040006E7 RID: 1767
		public static int formations_playerinstruction8_1 = -1;

		// Token: 0x040006E8 RID: 1768
		public static int formations_playerinstruction9_1 = -1;

		// Token: 0x040006E9 RID: 1769
		public static int formations_playerinstruction10_1 = -1;

		// Token: 0x040006EA RID: 1770
		public static int formations_playerinstruction0_2 = -1;

		// Token: 0x040006EB RID: 1771
		public static int formations_playerinstruction1_2 = -1;

		// Token: 0x040006EC RID: 1772
		public static int formations_playerinstruction2_2 = -1;

		// Token: 0x040006ED RID: 1773
		public static int formations_playerinstruction3_2 = -1;

		// Token: 0x040006EE RID: 1774
		public static int formations_playerinstruction4_2 = -1;

		// Token: 0x040006EF RID: 1775
		public static int formations_playerinstruction5_2 = -1;

		// Token: 0x040006F0 RID: 1776
		public static int formations_playerinstruction6_2 = -1;

		// Token: 0x040006F1 RID: 1777
		public static int formations_playerinstruction7_2 = -1;

		// Token: 0x040006F2 RID: 1778
		public static int formations_playerinstruction8_2 = -1;

		// Token: 0x040006F3 RID: 1779
		public static int formations_playerinstruction9_2 = -1;

		// Token: 0x040006F4 RID: 1780
		public static int formations_playerinstruction10_2 = -1;

		// Token: 0x040006F5 RID: 1781
		public static int formations_position0 = -1;

		// Token: 0x040006F6 RID: 1782
		public static int formations_position1 = -1;

		// Token: 0x040006F7 RID: 1783
		public static int formations_position2 = -1;

		// Token: 0x040006F8 RID: 1784
		public static int formations_position3 = -1;

		// Token: 0x040006F9 RID: 1785
		public static int formations_position4 = -1;

		// Token: 0x040006FA RID: 1786
		public static int formations_position5 = -1;

		// Token: 0x040006FB RID: 1787
		public static int formations_position6 = -1;

		// Token: 0x040006FC RID: 1788
		public static int formations_position7 = -1;

		// Token: 0x040006FD RID: 1789
		public static int formations_position8 = -1;

		// Token: 0x040006FE RID: 1790
		public static int formations_position9 = -1;

		// Token: 0x040006FF RID: 1791
		public static int formations_position10 = -1;

		// Token: 0x04000700 RID: 1792
		public static int formations_teamid = -1;

		// Token: 0x04000701 RID: 1793
		public static int fieldpositionboundingboxes_pointy1 = -1;

		// Token: 0x04000702 RID: 1794
		public static int fieldpositionboundingboxes_pointx1 = -1;

		// Token: 0x04000703 RID: 1795
		public static int fieldpositionboundingboxes_pointy0 = -1;

		// Token: 0x04000704 RID: 1796
		public static int fieldpositionboundingboxes_pointy3 = -1;

		// Token: 0x04000705 RID: 1797
		public static int fieldpositionboundingboxes_pointy2 = -1;

		// Token: 0x04000706 RID: 1798
		public static int fieldpositionboundingboxes_pointx0 = -1;

		// Token: 0x04000707 RID: 1799
		public static int fieldpositionboundingboxes_pointx3 = -1;

		// Token: 0x04000708 RID: 1800
		public static int fieldpositionboundingboxes_pointx2 = -1;

		// Token: 0x04000709 RID: 1801
		public static int fieldpositionboundingboxes_positionid = -1;

		// Token: 0x0400070A RID: 1802
		public static int editedplayernames_firstname = -1;

		// Token: 0x0400070B RID: 1803
		public static int editedplayernames_commonname = -1;

		// Token: 0x0400070C RID: 1804
		public static int editedplayernames_playerjerseyname = -1;

		// Token: 0x0400070D RID: 1805
		public static int editedplayernames_surname = -1;

		// Token: 0x0400070E RID: 1806
		public static int editedplayernames_playerid = -1;

		// Token: 0x0400070F RID: 1807
		public static int dna_dna = -1;

		// Token: 0x04000710 RID: 1808
		public static int dna_playerid = -1;

		// Token: 0x04000711 RID: 1809
		public static int defaultteamdata_teamid = -1;

		// Token: 0x04000712 RID: 1810
		public static int defaultteamdata_busbuildupspeed = -1;

		// Token: 0x04000713 RID: 1811
		public static int defaultteamdata_busdribbling = -1;

		// Token: 0x04000714 RID: 1812
		public static int defaultteamdata_buspassing = -1;

		// Token: 0x04000715 RID: 1813
		public static int defaultteamdata_buspositioning = -1;

		// Token: 0x04000716 RID: 1814
		public static int defaultteamdata_cccrossing = -1;

		// Token: 0x04000717 RID: 1815
		public static int defaultteamdata_ccpassing = -1;

		// Token: 0x04000718 RID: 1816
		public static int defaultteamdata_ccpositioning = -1;

		// Token: 0x04000719 RID: 1817
		public static int defaultteamdata_ccshooting = -1;

		// Token: 0x0400071A RID: 1818
		public static int defaultteamdata_defaggression = -1;

		// Token: 0x0400071B RID: 1819
		public static int defaultteamdata_defdefenderline = -1;

		// Token: 0x0400071C RID: 1820
		public static int defaultteamdata_defmentality = -1;

		// Token: 0x0400071D RID: 1821
		public static int defaultteamdata_defteamwidth = -1;

		// Token: 0x0400071E RID: 1822
		public static int defaultteamdata_tacticid = -1;

		// Token: 0x0400071F RID: 1823
		public static int defaultteamdata_offset0x = -1;

		// Token: 0x04000720 RID: 1824
		public static int defaultteamdata_offset0y = -1;

		// Token: 0x04000721 RID: 1825
		public static int defaultteamdata_playerinstruction0_1 = -1;

		// Token: 0x04000722 RID: 1826
		public static int defaultteamdata_playerinstruction0_2 = -1;

		// Token: 0x04000723 RID: 1827
		public static int defaultteamdata_position0 = -1;

		// Token: 0x04000724 RID: 1828
		public static int defaultteamdata_offset1x = -1;

		// Token: 0x04000725 RID: 1829
		public static int defaultteamdata_offset1y = -1;

		// Token: 0x04000726 RID: 1830
		public static int defaultteamdata_playerinstruction1_1 = -1;

		// Token: 0x04000727 RID: 1831
		public static int defaultteamdata_playerinstruction1_2 = -1;

		// Token: 0x04000728 RID: 1832
		public static int defaultteamdata_position1 = -1;

		// Token: 0x04000729 RID: 1833
		public static int defaultteamdata_offset2x = -1;

		// Token: 0x0400072A RID: 1834
		public static int defaultteamdata_offset2y = -1;

		// Token: 0x0400072B RID: 1835
		public static int defaultteamdata_playerinstruction2_1 = -1;

		// Token: 0x0400072C RID: 1836
		public static int defaultteamdata_playerinstruction2_2 = -1;

		// Token: 0x0400072D RID: 1837
		public static int defaultteamdata_position2 = -1;

		// Token: 0x0400072E RID: 1838
		public static int defaultteamdata_offset3x = -1;

		// Token: 0x0400072F RID: 1839
		public static int defaultteamdata_offset3y = -1;

		// Token: 0x04000730 RID: 1840
		public static int defaultteamdata_playerinstruction3_1 = -1;

		// Token: 0x04000731 RID: 1841
		public static int defaultteamdata_playerinstruction3_2 = -1;

		// Token: 0x04000732 RID: 1842
		public static int defaultteamdata_position3 = -1;

		// Token: 0x04000733 RID: 1843
		public static int defaultteamdata_offset4x = -1;

		// Token: 0x04000734 RID: 1844
		public static int defaultteamdata_offset4y = -1;

		// Token: 0x04000735 RID: 1845
		public static int defaultteamdata_playerinstruction4_1 = -1;

		// Token: 0x04000736 RID: 1846
		public static int defaultteamdata_playerinstruction4_2 = -1;

		// Token: 0x04000737 RID: 1847
		public static int defaultteamdata_position4 = -1;

		// Token: 0x04000738 RID: 1848
		public static int defaultteamdata_offset5x = -1;

		// Token: 0x04000739 RID: 1849
		public static int defaultteamdata_offset5y = -1;

		// Token: 0x0400073A RID: 1850
		public static int defaultteamdata_playerinstruction5_1 = -1;

		// Token: 0x0400073B RID: 1851
		public static int defaultteamdata_playerinstruction5_2 = -1;

		// Token: 0x0400073C RID: 1852
		public static int defaultteamdata_position5 = -1;

		// Token: 0x0400073D RID: 1853
		public static int defaultteamdata_offset6x = -1;

		// Token: 0x0400073E RID: 1854
		public static int defaultteamdata_offset6y = -1;

		// Token: 0x0400073F RID: 1855
		public static int defaultteamdata_playerinstruction6_1 = -1;

		// Token: 0x04000740 RID: 1856
		public static int defaultteamdata_playerinstruction6_2 = -1;

		// Token: 0x04000741 RID: 1857
		public static int defaultteamdata_position6 = -1;

		// Token: 0x04000742 RID: 1858
		public static int defaultteamdata_offset7x = -1;

		// Token: 0x04000743 RID: 1859
		public static int defaultteamdata_offset7y = -1;

		// Token: 0x04000744 RID: 1860
		public static int defaultteamdata_playerinstruction7_1 = -1;

		// Token: 0x04000745 RID: 1861
		public static int defaultteamdata_playerinstruction7_2 = -1;

		// Token: 0x04000746 RID: 1862
		public static int defaultteamdata_position7 = -1;

		// Token: 0x04000747 RID: 1863
		public static int defaultteamdata_offset8x = -1;

		// Token: 0x04000748 RID: 1864
		public static int defaultteamdata_offset8y = -1;

		// Token: 0x04000749 RID: 1865
		public static int defaultteamdata_playerinstruction8_1 = -1;

		// Token: 0x0400074A RID: 1866
		public static int defaultteamdata_playerinstruction8_2 = -1;

		// Token: 0x0400074B RID: 1867
		public static int defaultteamdata_position8 = -1;

		// Token: 0x0400074C RID: 1868
		public static int defaultteamdata_offset9x = -1;

		// Token: 0x0400074D RID: 1869
		public static int defaultteamdata_offset9y = -1;

		// Token: 0x0400074E RID: 1870
		public static int defaultteamdata_playerinstruction9_1 = -1;

		// Token: 0x0400074F RID: 1871
		public static int defaultteamdata_playerinstruction9_2 = -1;

		// Token: 0x04000750 RID: 1872
		public static int defaultteamdata_position9 = -1;

		// Token: 0x04000751 RID: 1873
		public static int defaultteamdata_offset10x = -1;

		// Token: 0x04000752 RID: 1874
		public static int defaultteamdata_offset10y = -1;

		// Token: 0x04000753 RID: 1875
		public static int defaultteamdata_playerinstruction10_1 = -1;

		// Token: 0x04000754 RID: 1876
		public static int defaultteamdata_playerinstruction10_2 = -1;

		// Token: 0x04000755 RID: 1877
		public static int defaultteamdata_position10 = -1;

		// Token: 0x04000756 RID: 1878
		public static int default_teamsheets_teamid = -1;

		// Token: 0x04000757 RID: 1879
		public static int default_teamsheets_busbuildupspeed = -1;

		// Token: 0x04000758 RID: 1880
		public static int default_teamsheets_busdribbling = -1;

		// Token: 0x04000759 RID: 1881
		public static int default_teamsheets_buspassing = -1;

		// Token: 0x0400075A RID: 1882
		public static int default_teamsheets_buspositioning = -1;

		// Token: 0x0400075B RID: 1883
		public static int default_teamsheets_cccrossing = -1;

		// Token: 0x0400075C RID: 1884
		public static int default_teamsheets_ccpassing = -1;

		// Token: 0x0400075D RID: 1885
		public static int default_teamsheets_ccpositioning = -1;

		// Token: 0x0400075E RID: 1886
		public static int default_teamsheets_ccshooting = -1;

		// Token: 0x0400075F RID: 1887
		public static int default_teamsheets_defaggression = -1;

		// Token: 0x04000760 RID: 1888
		public static int default_teamsheets_defdefenderline = -1;

		// Token: 0x04000761 RID: 1889
		public static int default_teamsheets_defmentality = -1;

		// Token: 0x04000762 RID: 1890
		public static int default_teamsheets_defteamwidth = -1;

		// Token: 0x04000763 RID: 1891
		public static int default_teamsheets_tacticid = -1;

		// Token: 0x04000764 RID: 1892
		public static int default_teamsheets_offset0x = -1;

		// Token: 0x04000765 RID: 1893
		public static int default_teamsheets_offset0y = -1;

		// Token: 0x04000766 RID: 1894
		public static int default_teamsheets_playerinstruction0_1 = -1;

		// Token: 0x04000767 RID: 1895
		public static int default_teamsheets_position0 = -1;

		// Token: 0x04000768 RID: 1896
		public static int default_teamsheets_offset1x = -1;

		// Token: 0x04000769 RID: 1897
		public static int default_teamsheets_offset1y = -1;

		// Token: 0x0400076A RID: 1898
		public static int default_teamsheets_playerinstruction1_1 = -1;

		// Token: 0x0400076B RID: 1899
		public static int default_teamsheets_position1 = -1;

		// Token: 0x0400076C RID: 1900
		public static int default_teamsheets_offset2x = -1;

		// Token: 0x0400076D RID: 1901
		public static int default_teamsheets_offset2y = -1;

		// Token: 0x0400076E RID: 1902
		public static int default_teamsheets_playerinstruction2_1 = -1;

		// Token: 0x0400076F RID: 1903
		public static int default_teamsheets_position2 = -1;

		// Token: 0x04000770 RID: 1904
		public static int default_teamsheets_offset3x = -1;

		// Token: 0x04000771 RID: 1905
		public static int default_teamsheets_offset3y = -1;

		// Token: 0x04000772 RID: 1906
		public static int default_teamsheets_playerinstruction3_1 = -1;

		// Token: 0x04000773 RID: 1907
		public static int default_teamsheets_position3 = -1;

		// Token: 0x04000774 RID: 1908
		public static int default_teamsheets_offset4x = -1;

		// Token: 0x04000775 RID: 1909
		public static int default_teamsheets_offset4y = -1;

		// Token: 0x04000776 RID: 1910
		public static int default_teamsheets_playerinstruction4_1 = -1;

		// Token: 0x04000777 RID: 1911
		public static int default_teamsheets_position4 = -1;

		// Token: 0x04000778 RID: 1912
		public static int default_teamsheets_offset5x = -1;

		// Token: 0x04000779 RID: 1913
		public static int default_teamsheets_offset5y = -1;

		// Token: 0x0400077A RID: 1914
		public static int default_teamsheets_playerinstruction5_1 = -1;

		// Token: 0x0400077B RID: 1915
		public static int default_teamsheets_position5 = -1;

		// Token: 0x0400077C RID: 1916
		public static int default_teamsheets_offset6x = -1;

		// Token: 0x0400077D RID: 1917
		public static int default_teamsheets_offset6y = -1;

		// Token: 0x0400077E RID: 1918
		public static int default_teamsheets_playerinstruction6_1 = -1;

		// Token: 0x0400077F RID: 1919
		public static int default_teamsheets_position6 = -1;

		// Token: 0x04000780 RID: 1920
		public static int default_teamsheets_offset7x = -1;

		// Token: 0x04000781 RID: 1921
		public static int default_teamsheets_offset7y = -1;

		// Token: 0x04000782 RID: 1922
		public static int default_teamsheets_playerinstruction7_1 = -1;

		// Token: 0x04000783 RID: 1923
		public static int default_teamsheets_position7 = -1;

		// Token: 0x04000784 RID: 1924
		public static int default_teamsheets_offset8x = -1;

		// Token: 0x04000785 RID: 1925
		public static int default_teamsheets_offset8y = -1;

		// Token: 0x04000786 RID: 1926
		public static int default_teamsheets_playerinstruction8_1 = -1;

		// Token: 0x04000787 RID: 1927
		public static int default_teamsheets_position8 = -1;

		// Token: 0x04000788 RID: 1928
		public static int default_teamsheets_offset9x = -1;

		// Token: 0x04000789 RID: 1929
		public static int default_teamsheets_offset9y = -1;

		// Token: 0x0400078A RID: 1930
		public static int default_teamsheets_playerinstruction9_1 = -1;

		// Token: 0x0400078B RID: 1931
		public static int default_teamsheets_position9 = -1;

		// Token: 0x0400078C RID: 1932
		public static int default_teamsheets_offset10x = -1;

		// Token: 0x0400078D RID: 1933
		public static int default_teamsheets_offset10y = -1;

		// Token: 0x0400078E RID: 1934
		public static int default_teamsheets_playerinstruction10_1 = -1;

		// Token: 0x0400078F RID: 1935
		public static int default_teamsheets_position10 = -1;

		// Token: 0x04000790 RID: 1936
		public static int default_teamsheets_playerid0 = -1;

		// Token: 0x04000791 RID: 1937
		public static int default_teamsheets_playerid1 = -1;

		// Token: 0x04000792 RID: 1938
		public static int default_teamsheets_playerid2 = -1;

		// Token: 0x04000793 RID: 1939
		public static int default_teamsheets_playerid3 = -1;

		// Token: 0x04000794 RID: 1940
		public static int default_teamsheets_playerid4 = -1;

		// Token: 0x04000795 RID: 1941
		public static int default_teamsheets_playerid5 = -1;

		// Token: 0x04000796 RID: 1942
		public static int default_teamsheets_playerid6 = -1;

		// Token: 0x04000797 RID: 1943
		public static int default_teamsheets_playerid7 = -1;

		// Token: 0x04000798 RID: 1944
		public static int default_teamsheets_playerid8 = -1;

		// Token: 0x04000799 RID: 1945
		public static int default_teamsheets_playerid9 = -1;

		// Token: 0x0400079A RID: 1946
		public static int default_teamsheets_playerid10 = -1;

		// Token: 0x0400079B RID: 1947
		public static int default_teamsheets_playerid11 = -1;

		// Token: 0x0400079C RID: 1948
		public static int default_teamsheets_playerid12 = -1;

		// Token: 0x0400079D RID: 1949
		public static int default_teamsheets_playerid13 = -1;

		// Token: 0x0400079E RID: 1950
		public static int default_teamsheets_playerid14 = -1;

		// Token: 0x0400079F RID: 1951
		public static int default_teamsheets_playerid15 = -1;

		// Token: 0x040007A0 RID: 1952
		public static int default_teamsheets_playerid16 = -1;

		// Token: 0x040007A1 RID: 1953
		public static int default_teamsheets_playerid17 = -1;

		// Token: 0x040007A2 RID: 1954
		public static int default_teamsheets_playerid18 = -1;

		// Token: 0x040007A3 RID: 1955
		public static int default_teamsheets_playerid19 = -1;

		// Token: 0x040007A4 RID: 1956
		public static int default_teamsheets_playerid20 = -1;

		// Token: 0x040007A5 RID: 1957
		public static int default_teamsheets_playerid21 = -1;

		// Token: 0x040007A6 RID: 1958
		public static int default_teamsheets_playerid22 = -1;

		// Token: 0x040007A7 RID: 1959
		public static int default_teamsheets_playerid23 = -1;

		// Token: 0x040007A8 RID: 1960
		public static int default_teamsheets_playerid24 = -1;

		// Token: 0x040007A9 RID: 1961
		public static int default_teamsheets_playerid25 = -1;

		// Token: 0x040007AA RID: 1962
		public static int default_teamsheets_playerid26 = -1;

		// Token: 0x040007AB RID: 1963
		public static int default_teamsheets_playerid27 = -1;

		// Token: 0x040007AC RID: 1964
		public static int default_teamsheets_playerid28 = -1;

		// Token: 0x040007AD RID: 1965
		public static int default_teamsheets_playerid29 = -1;

		// Token: 0x040007AE RID: 1966
		public static int default_teamsheets_playerid30 = -1;

		// Token: 0x040007AF RID: 1967
		public static int default_teamsheets_playerid31 = -1;

		// Token: 0x040007B0 RID: 1968
		public static int default_teamsheets_playerid32 = -1;

		// Token: 0x040007B1 RID: 1969
		public static int default_teamsheets_playerid33 = -1;

		// Token: 0x040007B2 RID: 1970
		public static int default_teamsheets_playerid34 = -1;

		// Token: 0x040007B3 RID: 1971
		public static int default_teamsheets_playerid35 = -1;

		// Token: 0x040007B4 RID: 1972
		public static int default_teamsheets_playerid36 = -1;

		// Token: 0x040007B5 RID: 1973
		public static int default_teamsheets_playerid37 = -1;

		// Token: 0x040007B6 RID: 1974
		public static int default_teamsheets_playerid38 = -1;

		// Token: 0x040007B7 RID: 1975
		public static int default_teamsheets_playerid39 = -1;

		// Token: 0x040007B8 RID: 1976
		public static int default_teamsheets_playerid40 = -1;

		// Token: 0x040007B9 RID: 1977
		public static int default_teamsheets_playerid41 = -1;

		// Token: 0x040007BA RID: 1978
		public static int default_teamsheets_freekicktakerid = -1;

		// Token: 0x040007BB RID: 1979
		public static int default_teamsheets_leftcornerkicktakerid = -1;

		// Token: 0x040007BC RID: 1980
		public static int default_teamsheets_leftfreekicktakerid = -1;

		// Token: 0x040007BD RID: 1981
		public static int default_teamsheets_longkicktakerid = -1;

		// Token: 0x040007BE RID: 1982
		public static int default_teamsheets_captainid = -1;

		// Token: 0x040007BF RID: 1983
		public static int default_teamsheets_rightcornerkicktakerid = -1;

		// Token: 0x040007C0 RID: 1984
		public static int default_teamsheets_rightfreekicktakerid = -1;

		// Token: 0x040007C1 RID: 1985
		public static int default_teamsheets_penaltytakerid = -1;

		// Token: 0x040007C2 RID: 1986
		public static int default_teamsheets_playerinstruction0_2 = -1;

		// Token: 0x040007C3 RID: 1987
		public static int default_teamsheets_playerinstruction1_2 = -1;

		// Token: 0x040007C4 RID: 1988
		public static int default_teamsheets_playerinstruction2_2 = -1;

		// Token: 0x040007C5 RID: 1989
		public static int default_teamsheets_playerinstruction3_2 = -1;

		// Token: 0x040007C6 RID: 1990
		public static int default_teamsheets_playerinstruction4_2 = -1;

		// Token: 0x040007C7 RID: 1991
		public static int default_teamsheets_playerinstruction5_2 = -1;

		// Token: 0x040007C8 RID: 1992
		public static int default_teamsheets_playerinstruction6_2 = -1;

		// Token: 0x040007C9 RID: 1993
		public static int default_teamsheets_playerinstruction7_2 = -1;

		// Token: 0x040007CA RID: 1994
		public static int default_teamsheets_playerinstruction8_2 = -1;

		// Token: 0x040007CB RID: 1995
		public static int default_teamsheets_playerinstruction9_2 = -1;

		// Token: 0x040007CC RID: 1996
		public static int default_teamsheets_playerinstruction10_2 = -1;

		// Token: 0x040007CD RID: 1997
		public static int customformations_offset6x = -1;

		// Token: 0x040007CE RID: 1998
		public static int customformations_offset5y = -1;

		// Token: 0x040007CF RID: 1999
		public static int customformations_offset10x = -1;

		// Token: 0x040007D0 RID: 2000
		public static int customformations_offset2x = -1;

		// Token: 0x040007D1 RID: 2001
		public static int customformations_defenders = -1;

		// Token: 0x040007D2 RID: 2002
		public static int customformations_offset2y = -1;

		// Token: 0x040007D3 RID: 2003
		public static int customformations_offset6y = -1;

		// Token: 0x040007D4 RID: 2004
		public static int customformations_offset7x = -1;

		// Token: 0x040007D5 RID: 2005
		public static int customformations_offset3x = -1;

		// Token: 0x040007D6 RID: 2006
		public static int customformations_offset8x = -1;

		// Token: 0x040007D7 RID: 2007
		public static int customformations_offset10y = -1;

		// Token: 0x040007D8 RID: 2008
		public static int customformations_offset3y = -1;

		// Token: 0x040007D9 RID: 2009
		public static int customformations_offset4x = -1;

		// Token: 0x040007DA RID: 2010
		public static int customformations_offset7y = -1;

		// Token: 0x040007DB RID: 2011
		public static int customformations_offset0x = -1;

		// Token: 0x040007DC RID: 2012
		public static int customformations_offset8y = -1;

		// Token: 0x040007DD RID: 2013
		public static int customformations_attackers = -1;

		// Token: 0x040007DE RID: 2014
		public static int customformations_offset9x = -1;

		// Token: 0x040007DF RID: 2015
		public static int customformations_midfielders = -1;

		// Token: 0x040007E0 RID: 2016
		public static int customformations_offset5x = -1;

		// Token: 0x040007E1 RID: 2017
		public static int customformations_offset0y = -1;

		// Token: 0x040007E2 RID: 2018
		public static int customformations_offset1x = -1;

		// Token: 0x040007E3 RID: 2019
		public static int customformations_offset4y = -1;

		// Token: 0x040007E4 RID: 2020
		public static int customformations_offset9y = -1;

		// Token: 0x040007E5 RID: 2021
		public static int customformations_offset1y = -1;

		// Token: 0x040007E6 RID: 2022
		public static int customformations_formationname = -1;

		// Token: 0x040007E7 RID: 2023
		public static int customformations_attackingdirection_0 = -1;

		// Token: 0x040007E8 RID: 2024
		public static int customformations_attackingrole_5 = -1;

		// Token: 0x040007E9 RID: 2025
		public static int customformations_position10 = -1;

		// Token: 0x040007EA RID: 2026
		public static int customformations_attackingdirection_7 = -1;

		// Token: 0x040007EB RID: 2027
		public static int customformations_defensivedirection_0 = -1;

		// Token: 0x040007EC RID: 2028
		public static int customformations_defensivedirection_9 = -1;

		// Token: 0x040007ED RID: 2029
		public static int customformations_defensivedirection_8 = -1;

		// Token: 0x040007EE RID: 2030
		public static int customformations_attackingdirection_9 = -1;

		// Token: 0x040007EF RID: 2031
		public static int customformations_position6 = -1;

		// Token: 0x040007F0 RID: 2032
		public static int customformations_attackingrole_4 = -1;

		// Token: 0x040007F1 RID: 2033
		public static int customformations_offensiverating = -1;

		// Token: 0x040007F2 RID: 2034
		public static int customformations_attackingrole_2 = -1;

		// Token: 0x040007F3 RID: 2035
		public static int customformations_attackingdirection_1 = -1;

		// Token: 0x040007F4 RID: 2036
		public static int customformations_position8 = -1;

		// Token: 0x040007F5 RID: 2037
		public static int customformations_defensiverole_4 = -1;

		// Token: 0x040007F6 RID: 2038
		public static int customformations_attackingdirection_10 = -1;

		// Token: 0x040007F7 RID: 2039
		public static int customformations_defensivedirection_6 = -1;

		// Token: 0x040007F8 RID: 2040
		public static int customformations_attackingdirection_8 = -1;

		// Token: 0x040007F9 RID: 2041
		public static int customformations_attackingrole_3 = -1;

		// Token: 0x040007FA RID: 2042
		public static int customformations_defensiverole_3 = -1;

		// Token: 0x040007FB RID: 2043
		public static int customformations_attackingrole_0 = -1;

		// Token: 0x040007FC RID: 2044
		public static int customformations_defensivedirection_1 = -1;

		// Token: 0x040007FD RID: 2045
		public static int customformations_attackingdirection_5 = -1;

		// Token: 0x040007FE RID: 2046
		public static int customformations_defensivedirection_2 = -1;

		// Token: 0x040007FF RID: 2047
		public static int customformations_attackingdirection_6 = -1;

		// Token: 0x04000800 RID: 2048
		public static int customformations_position5 = -1;

		// Token: 0x04000801 RID: 2049
		public static int customformations_attackingrole_7 = -1;

		// Token: 0x04000802 RID: 2050
		public static int customformations_defensiverole_5 = -1;

		// Token: 0x04000803 RID: 2051
		public static int customformations_defensivedirection_10 = -1;

		// Token: 0x04000804 RID: 2052
		public static int customformations_defensivedirection_3 = -1;

		// Token: 0x04000805 RID: 2053
		public static int customformations_defensivedirection_5 = -1;

		// Token: 0x04000806 RID: 2054
		public static int customformations_issweeper = -1;

		// Token: 0x04000807 RID: 2055
		public static int customformations_attackingdirection_2 = -1;

		// Token: 0x04000808 RID: 2056
		public static int customformations_attackingdirection_4 = -1;

		// Token: 0x04000809 RID: 2057
		public static int customformations_attackingrole_9 = -1;

		// Token: 0x0400080A RID: 2058
		public static int customformations_defensiverole_2 = -1;

		// Token: 0x0400080B RID: 2059
		public static int customformations_attackingdirection_3 = -1;

		// Token: 0x0400080C RID: 2060
		public static int customformations_attackingrole_8 = -1;

		// Token: 0x0400080D RID: 2061
		public static int customformations_attackingrole_1 = -1;

		// Token: 0x0400080E RID: 2062
		public static int customformations_defensiverole_10 = -1;

		// Token: 0x0400080F RID: 2063
		public static int customformations_defensiverole_1 = -1;

		// Token: 0x04000810 RID: 2064
		public static int customformations_teamid = -1;

		// Token: 0x04000811 RID: 2065
		public static int customformations_position2 = -1;

		// Token: 0x04000812 RID: 2066
		public static int customformations_defensivedirection_4 = -1;

		// Token: 0x04000813 RID: 2067
		public static int customformations_formationid = -1;

		// Token: 0x04000814 RID: 2068
		public static int customformations_defensiverole_8 = -1;

		// Token: 0x04000815 RID: 2069
		public static int customformations_attackingrole_6 = -1;

		// Token: 0x04000816 RID: 2070
		public static int customformations_relativeformationid = -1;

		// Token: 0x04000817 RID: 2071
		public static int customformations_defensiverole_0 = -1;

		// Token: 0x04000818 RID: 2072
		public static int customformations_defensiverole_6 = -1;

		// Token: 0x04000819 RID: 2073
		public static int customformations_position4 = -1;

		// Token: 0x0400081A RID: 2074
		public static int customformations_attackingrole_10 = -1;

		// Token: 0x0400081B RID: 2075
		public static int customformations_position3 = -1;

		// Token: 0x0400081C RID: 2076
		public static int customformations_defensiverole_7 = -1;

		// Token: 0x0400081D RID: 2077
		public static int customformations_formationfullnameid = -1;

		// Token: 0x0400081E RID: 2078
		public static int customformations_defensiverole_9 = -1;

		// Token: 0x0400081F RID: 2079
		public static int customformations_position0 = -1;

		// Token: 0x04000820 RID: 2080
		public static int customformations_position9 = -1;

		// Token: 0x04000821 RID: 2081
		public static int customformations_position7 = -1;

		// Token: 0x04000822 RID: 2082
		public static int customformations_position1 = -1;

		// Token: 0x04000823 RID: 2083
		public static int customformations_defensivedirection_7 = -1;

		// Token: 0x04000824 RID: 2084
		public static int competition_ballid = -1;

		// Token: 0x04000825 RID: 2085
		public static int competition_competitionid = -1;

		// Token: 0x04000826 RID: 2086
		public static int career_lastnames_lastname = -1;

		// Token: 0x04000827 RID: 2087
		public static int career_lastnames_lastnameid = -1;

		// Token: 0x04000828 RID: 2088
		public static int career_lastnames_groupid = -1;

		// Token: 0x04000829 RID: 2089
		public static int career_firstnames_firstname = -1;

		// Token: 0x0400082A RID: 2090
		public static int career_firstnames_firstnameid = -1;

		// Token: 0x0400082B RID: 2091
		public static int career_firstnames_groupid = -1;

		// Token: 0x0400082C RID: 2092
		public static int career_commonnames_firstname = -1;

		// Token: 0x0400082D RID: 2093
		public static int career_commonnames_lastname = -1;

		// Token: 0x0400082E RID: 2094
		public static int career_commonnames_commonnameid = -1;

		// Token: 0x0400082F RID: 2095
		public static int career_commonnames_groupid = -1;

		// Token: 0x04000830 RID: 2096
		public static int attributeprefpositionformula_attribute = -1;

		// Token: 0x04000831 RID: 2097
		public static int attributeprefpositionformula_position = -1;

		// Token: 0x04000832 RID: 2098
		public static int attributeprefpositionformula_percentage = -1;

		// Token: 0x04000833 RID: 2099
		public static int audionation_nationid = -1;

		// Token: 0x04000834 RID: 2100
		public static int audionation_PALanguageIndex = -1;

		// Token: 0x04000835 RID: 2101
		public static int audionation_DefaultCommLang = -1;

		// Token: 0x04000836 RID: 2102
		public static int audionation_CrowdBedsRegionIndex = -1;

		// Token: 0x04000837 RID: 2103
		public static int audionation_WhistlesRegionIndex = -1;

		// Token: 0x04000838 RID: 2104
		public static int audionation_AmbienceRegionIndex = -1;

		// Token: 0x04000839 RID: 2105
		public static int audionation_PlayerCallPatchBankIndex = -1;

		// Token: 0x0400083A RID: 2106
		public static int audionation_HecklesRegionIndex = -1;

		// Token: 0x0400083B RID: 2107
		public static int audionation_ChantRegionIndex = -1;

		// Token: 0x0400083C RID: 2108
		public static int audionation_TeamCanWhistleIndex = -1;

		// Token: 0x0400083D RID: 2109
		public static int audionation_ReactionsRegionIndex = -1;

		// Token: 0x0400083E RID: 2110
		public static int NoAttendance_Max = -1;

		// Token: 0x0400083F RID: 2111
		public static int NoAttendance_Emotion = -1;

		// Token: 0x04000840 RID: 2112
		public static int NoAttendance_Min = -1;

		// Token: 0x04000841 RID: 2113
		public static int MatchIntensity_ScoreDiff = -1;

		// Token: 0x04000842 RID: 2114
		public static int MatchIntensity_time60 = -1;

		// Token: 0x04000843 RID: 2115
		public static int MatchIntensity_time90 = -1;

		// Token: 0x04000844 RID: 2116
		public static int MatchIntensity_time120 = -1;

		// Token: 0x04000845 RID: 2117
		public static int MatchIntensity_time75 = -1;

		// Token: 0x04000846 RID: 2118
		public static int MatchIntensity_time45 = -1;

		// Token: 0x04000847 RID: 2119
		public static int MatchIntensity_time30 = -1;

		// Token: 0x04000848 RID: 2120
		public static int MatchIntensity_time15 = -1;

		// Token: 0x04000849 RID: 2121
		public static int BigAttendance_Max = -1;

		// Token: 0x0400084A RID: 2122
		public static int BigAttendance_Emotion = -1;

		// Token: 0x0400084B RID: 2123
		public static int BigAttendance_Min = -1;

		// Token: 0x0400084C RID: 2124
		public static int audiostadium_stadiumid = -1;

		// Token: 0x0400084D RID: 2125
		public static int audiostadium_audioindex = -1;

		// Token: 0x0400084E RID: 2126
		public static int audiostadium_stadiumpalanguageindex = -1;

		// Token: 0x0400084F RID: 2127
		public static int career_managerawards_count = -1;

		// Token: 0x04000850 RID: 2128
		public static int career_managerawards_season = -1;

		// Token: 0x04000851 RID: 2129
		public static int career_managerawards_compobjid = -1;

		// Token: 0x04000852 RID: 2130
		public static int career_managerawards_artificialkey = -1;

		// Token: 0x04000853 RID: 2131
		public static int career_managerawards_teamid = -1;

		// Token: 0x04000854 RID: 2132
		public static int career_managerawards_typeid = -1;

		// Token: 0x04000855 RID: 2133
		public static int career_teamofweek_artificialkey = -1;

		// Token: 0x04000856 RID: 2134
		public static int career_teamofweek_matchrating = -1;

		// Token: 0x04000857 RID: 2135
		public static int career_teamofweek_weekswon = -1;

		// Token: 0x04000858 RID: 2136
		public static int career_teamofweek_month = -1;

		// Token: 0x04000859 RID: 2137
		public static int career_teamofweek_playerid = -1;

		// Token: 0x0400085A RID: 2138
		public static int career_playerawards_season = -1;

		// Token: 0x0400085B RID: 2139
		public static int career_playerawards_compobjid = -1;

		// Token: 0x0400085C RID: 2140
		public static int career_playerawards_count = -1;

		// Token: 0x0400085D RID: 2141
		public static int career_playerawards_artificialkey = -1;

		// Token: 0x0400085E RID: 2142
		public static int career_playerawards_teamid = -1;

		// Token: 0x0400085F RID: 2143
		public static int career_playerawards_playerid = -1;

		// Token: 0x04000860 RID: 2144
		public static int career_playerawards_typeid = -1;

		// Token: 0x04000861 RID: 2145
		public static int career_calendar_transferwindowend1 = -1;

		// Token: 0x04000862 RID: 2146
		public static int career_calendar_transferwindowstart1 = -1;

		// Token: 0x04000863 RID: 2147
		public static int career_calendar_transferwindowend2 = -1;

		// Token: 0x04000864 RID: 2148
		public static int career_calendar_setupdate = -1;

		// Token: 0x04000865 RID: 2149
		public static int career_calendar_dateid = -1;

		// Token: 0x04000866 RID: 2150
		public static int career_calendar_enddate = -1;

		// Token: 0x04000867 RID: 2151
		public static int career_calendar_currdate = -1;

		// Token: 0x04000868 RID: 2152
		public static int career_calendar_startdate = -1;

		// Token: 0x04000869 RID: 2153
		public static int career_calendar_transferwindowstart2 = -1;

		// Token: 0x0400086A RID: 2154
		public static int career_squadranking_curroverall = -1;

		// Token: 0x0400086B RID: 2155
		public static int career_squadranking_playerid = -1;

		// Token: 0x0400086C RID: 2156
		public static int career_squadranking_lastoverall = -1;

		// Token: 0x0400086D RID: 2157
		public static int career_playermatchratinghistory_minsplayed = -1;

		// Token: 0x0400086E RID: 2158
		public static int career_playermatchratinghistory_date = -1;

		// Token: 0x0400086F RID: 2159
		public static int career_playermatchratinghistory_artificialkey = -1;

		// Token: 0x04000870 RID: 2160
		public static int career_playermatchratinghistory_rating = -1;

		// Token: 0x04000871 RID: 2161
		public static int career_playermatchratinghistory_playerid = -1;

		// Token: 0x04000872 RID: 2162
		public static int career_fixtureinfo_homeprevscore = -1;

		// Token: 0x04000873 RID: 2163
		public static int career_fixtureinfo_hometeamid = -1;

		// Token: 0x04000874 RID: 2164
		public static int career_fixtureinfo_totalmatches = -1;

		// Token: 0x04000875 RID: 2165
		public static int career_fixtureinfo_stagecompobjid = -1;

		// Token: 0x04000876 RID: 2166
		public static int career_fixtureinfo_subsonbench = -1;

		// Token: 0x04000877 RID: 2167
		public static int career_fixtureinfo_pitchwear = -1;

		// Token: 0x04000878 RID: 2168
		public static int career_fixtureinfo_assetid = -1;

		// Token: 0x04000879 RID: 2169
		public static int career_fixtureinfo_stadiumid = -1;

		// Token: 0x0400087A RID: 2170
		public static int career_fixtureinfo_matchsituation = -1;

		// Token: 0x0400087B RID: 2171
		public static int career_fixtureinfo_fixturedate = -1;

		// Token: 0x0400087C RID: 2172
		public static int career_fixtureinfo_suspensioncompobjid = -1;

		// Token: 0x0400087D RID: 2173
		public static int career_fixtureinfo_numgamesdoubleyellowbanmin = -1;

		// Token: 0x0400087E RID: 2174
		public static int career_fixtureinfo_neutralstadium = -1;

		// Token: 0x0400087F RID: 2175
		public static int career_fixtureinfo_compobjid = -1;

		// Token: 0x04000880 RID: 2176
		public static int career_fixtureinfo_offsides = -1;

		// Token: 0x04000881 RID: 2177
		public static int career_fixtureinfo_comptype = -1;

		// Token: 0x04000882 RID: 2178
		public static int career_fixtureinfo_numgamesdoubleyellowbanmax = -1;

		// Token: 0x04000883 RID: 2179
		public static int career_fixtureinfo_weathertype = -1;

		// Token: 0x04000884 RID: 2180
		public static int career_fixtureinfo_subsavailable = -1;

		// Token: 0x04000885 RID: 2181
		public static int career_fixtureinfo_matchimportance = -1;

		// Token: 0x04000886 RID: 2182
		public static int career_fixtureinfo_awayprevscore = -1;

		// Token: 0x04000887 RID: 2183
		public static int career_fixtureinfo_matchnumber = -1;

		// Token: 0x04000888 RID: 2184
		public static int career_fixtureinfo_fixtureid = -1;

		// Token: 0x04000889 RID: 2185
		public static int career_fixtureinfo_numyellowsforban = -1;

		// Token: 0x0400088A RID: 2186
		public static int career_fixtureinfo_injuries = -1;

		// Token: 0x0400088B RID: 2187
		public static int career_fixtureinfo_matchsetupflags = -1;

		// Token: 0x0400088C RID: 2188
		public static int career_fixtureinfo_timeofday = -1;

		// Token: 0x0400088D RID: 2189
		public static int career_fixtureinfo_fixturetime = -1;

		// Token: 0x0400088E RID: 2190
		public static int career_fixtureinfo_numgamesyellowbanmax = -1;

		// Token: 0x0400088F RID: 2191
		public static int career_fixtureinfo_awayteamid = -1;

		// Token: 0x04000890 RID: 2192
		public static int career_fixtureinfo_bookings = -1;

		// Token: 0x04000891 RID: 2193
		public static int career_fixtureinfo_numgamesredbanmax = -1;

		// Token: 0x04000892 RID: 2194
		public static int career_fixtureinfo_numgamesyellowbanmin = -1;

		// Token: 0x04000893 RID: 2195
		public static int career_fixtureinfo_userid = -1;

		// Token: 0x04000894 RID: 2196
		public static int career_fixtureinfo_matchtype = -1;

		// Token: 0x04000895 RID: 2197
		public static int career_fixtureinfo_numgamesredbanmin = -1;

		// Token: 0x04000896 RID: 2198
		public static int career_fixtureinfo_fixtureinfoid = -1;

		// Token: 0x04000897 RID: 2199
		public static int career_clinchedobjectives_predictedclinchfordrawflags = -1;

		// Token: 0x04000898 RID: 2200
		public static int career_clinchedobjectives_clinchedobjectivesflags = -1;

		// Token: 0x04000899 RID: 2201
		public static int career_clinchedobjectives_predictedclinchforwinflags = -1;

		// Token: 0x0400089A RID: 2202
		public static int career_clinchedobjectives_teamid = -1;

		// Token: 0x0400089B RID: 2203
		public static int career_clinchedobjectives_predictedclinchforlossflags = -1;

		// Token: 0x0400089C RID: 2204
		public static int cmeventhistory_artificialkey = -1;

		// Token: 0x0400089D RID: 2205
		public static int cmeventhistory_teamId = -1;

		// Token: 0x0400089E RID: 2206
		public static int cmeventhistory_eventId = -1;

		// Token: 0x0400089F RID: 2207
		public static int cmeventhistory_playerId = -1;

		// Token: 0x040008A0 RID: 2208
		public static int cmeventhistory_daysfromstart = -1;

		// Token: 0x040008A1 RID: 2209
		public static int cmteameventhistory_artificialkey = -1;

		// Token: 0x040008A2 RID: 2210
		public static int cmteameventhistory_teamId = -1;

		// Token: 0x040008A3 RID: 2211
		public static int cmteameventhistory_eventId = -1;

		// Token: 0x040008A4 RID: 2212
		public static int cmteameventhistory_daysfromstart = -1;

		// Token: 0x040008A5 RID: 2213
		public static int career_boardoutcomes_outcome3 = -1;

		// Token: 0x040008A6 RID: 2214
		public static int career_boardoutcomes_outcome4 = -1;

		// Token: 0x040008A7 RID: 2215
		public static int career_boardoutcomes_leagueid = -1;

		// Token: 0x040008A8 RID: 2216
		public static int career_boardoutcomes_outcome1 = -1;

		// Token: 0x040008A9 RID: 2217
		public static int career_boardoutcomes_outcome2 = -1;

		// Token: 0x040008AA RID: 2218
		public static int career_boardoutcomes_outcome5 = -1;

		// Token: 0x040008AB RID: 2219
		public static int career_users_firstname = -1;

		// Token: 0x040008AC RID: 2220
		public static int career_users_surname = -1;

		// Token: 0x040008AD RID: 2221
		public static int career_users_agentname = -1;

		// Token: 0x040008AE RID: 2222
		public static int career_users_nationalityid = -1;

		// Token: 0x040008AF RID: 2223
		public static int career_users_goalnews = -1;

		// Token: 0x040008B0 RID: 2224
		public static int career_users_playertype = -1;

		// Token: 0x040008B1 RID: 2225
		public static int career_users_nationalteamid = -1;

		// Token: 0x040008B2 RID: 2226
		public static int career_users_leagueseasonmessagesent = -1;

		// Token: 0x040008B3 RID: 2227
		public static int career_users_sponsorid = -1;

		// Token: 0x040008B4 RID: 2228
		public static int career_users_leagueid = -1;

		// Token: 0x040008B5 RID: 2229
		public static int career_users_clubteamid = -1;

		// Token: 0x040008B6 RID: 2230
		public static int career_users_wage = -1;

		// Token: 0x040008B7 RID: 2231
		public static int career_users_primarycompobjid = -1;

		// Token: 0x040008B8 RID: 2232
		public static int career_users_seasoncount = -1;

		// Token: 0x040008B9 RID: 2233
		public static int career_users_usertype = -1;

		// Token: 0x040008BA RID: 2234
		public static int career_users_userid = -1;

		// Token: 0x040008BB RID: 2235
		public static int career_trophies_season = -1;

		// Token: 0x040008BC RID: 2236
		public static int career_trophies_flags = -1;

		// Token: 0x040008BD RID: 2237
		public static int career_trophies_userid = -1;

		// Token: 0x040008BE RID: 2238
		public static int career_managerpref_currency = -1;

		// Token: 0x040008BF RID: 2239
		public static int career_managerpref_matchdifficulty = -1;

		// Token: 0x040008C0 RID: 2240
		public static int career_managerpref_playasaiteam = -1;

		// Token: 0x040008C1 RID: 2241
		public static int career_managerpref_bonuspercentage = -1;

		// Token: 0x040008C2 RID: 2242
		public static int career_managerpref_boardfinancialstrictness = -1;

		// Token: 0x040008C3 RID: 2243
		public static int career_managerpref_usedsquad = -1;

		// Token: 0x040008C4 RID: 2244
		public static int career_managerpref_stadiumid = -1;

		// Token: 0x040008C5 RID: 2245
		public static int career_managerpref_halflength = -1;

		// Token: 0x040008C6 RID: 2246
		public static int career_managerpref_managerprefid = -1;

		// Token: 0x040008C7 RID: 2247
		public static int career_managerpref_wagebudget = -1;

		// Token: 0x040008C8 RID: 2248
		public static int career_managerpref_boardaidifficulty = -1;

		// Token: 0x040008C9 RID: 2249
		public static int career_managerpref_startofseasontransferbudget = -1;

		// Token: 0x040008CA RID: 2250
		public static int career_managerpref_transferbudget = -1;

		// Token: 0x040008CB RID: 2251
		public static int career_managerpref_startofseasonwagebudget = -1;

		// Token: 0x040008CC RID: 2252
		public static int career_managerpref_startofseasonplayerwages = -1;

		// Token: 0x040008CD RID: 2253
		public static int career_managerinfo_biglossoppscore = -1;

		// Token: 0x040008CE RID: 2254
		public static int career_managerinfo_bigwinoppscore = -1;

		// Token: 0x040008CF RID: 2255
		public static int career_managerinfo_biglossuserscore = -1;

		// Token: 0x040008D0 RID: 2256
		public static int career_managerinfo_bigwinuserscore = -1;

		// Token: 0x040008D1 RID: 2257
		public static int career_managerinfo_seasonobjective3 = -1;

		// Token: 0x040008D2 RID: 2258
		public static int career_managerinfo_bigwindate = -1;

		// Token: 0x040008D3 RID: 2259
		public static int career_managerinfo_bigwinoppteamid = -1;

		// Token: 0x040008D4 RID: 2260
		public static int career_managerinfo_biglossdate = -1;

		// Token: 0x040008D5 RID: 2261
		public static int career_managerinfo_seasonobjectiveresult1 = -1;

		// Token: 0x040008D6 RID: 2262
		public static int career_managerinfo_seasonobjectiveresult2 = -1;

		// Token: 0x040008D7 RID: 2263
		public static int career_managerinfo_totalearnings = -1;

		// Token: 0x040008D8 RID: 2264
		public static int career_managerinfo_clubteamid = -1;

		// Token: 0x040008D9 RID: 2265
		public static int career_managerinfo_biglossuserteamid = -1;

		// Token: 0x040008DA RID: 2266
		public static int career_managerinfo_wage = -1;

		// Token: 0x040008DB RID: 2267
		public static int career_managerinfo_bigwinuserteamid = -1;

		// Token: 0x040008DC RID: 2268
		public static int career_managerinfo_losingstreak = -1;

		// Token: 0x040008DD RID: 2269
		public static int career_managerinfo_seasonobjectiveresult3 = -1;

		// Token: 0x040008DE RID: 2270
		public static int career_managerinfo_playersreleasedthisseason = -1;

		// Token: 0x040008DF RID: 2271
		public static int career_managerinfo_biglossoppteamid = -1;

		// Token: 0x040008E0 RID: 2272
		public static int career_managerinfo_seasonobjective1 = -1;

		// Token: 0x040008E1 RID: 2273
		public static int career_managerinfo_internationalteamid = -1;

		// Token: 0x040008E2 RID: 2274
		public static int career_managerinfo_managerreputation = -1;

		// Token: 0x040008E3 RID: 2275
		public static int career_managerinfo_seasonobjective2 = -1;

		// Token: 0x040008E4 RID: 2276
		public static int career_managerinfo_boardconfidence = -1;

		// Token: 0x040008E5 RID: 2277
		public static int career_managerinfo_userid = -1;

		// Token: 0x040008E6 RID: 2278
		public static int career_managerhistory_draws = -1;

		// Token: 0x040008E7 RID: 2279
		public static int career_managerhistory_losses = -1;

		// Token: 0x040008E8 RID: 2280
		public static int career_managerhistory_wins = -1;

		// Token: 0x040008E9 RID: 2281
		public static int career_managerhistory_games_played = -1;

		// Token: 0x040008EA RID: 2282
		public static int career_managerhistory_bigbuyplayername = -1;

		// Token: 0x040008EB RID: 2283
		public static int career_managerhistory_bigsellplayername = -1;

		// Token: 0x040008EC RID: 2284
		public static int career_managerhistory_leagueobjectiveresult = -1;

		// Token: 0x040008ED RID: 2285
		public static int career_managerhistory_continentalcuptrophies = -1;

		// Token: 0x040008EE RID: 2286
		public static int career_managerhistory_season = -1;

		// Token: 0x040008EF RID: 2287
		public static int career_managerhistory_bigsellamount = -1;

		// Token: 0x040008F0 RID: 2288
		public static int career_managerhistory_leaguetrophies = -1;

		// Token: 0x040008F1 RID: 2289
		public static int career_managerhistory_domestic_cup_result = -1;

		// Token: 0x040008F2 RID: 2290
		public static int career_managerhistory_domesticcuptrophies = -1;

		// Token: 0x040008F3 RID: 2291
		public static int career_managerhistory_leagueid = -1;

		// Token: 0x040008F4 RID: 2292
		public static int career_managerhistory_bigbuyamount = -1;

		// Token: 0x040008F5 RID: 2293
		public static int career_managerhistory_leagueobjective = -1;

		// Token: 0x040008F6 RID: 2294
		public static int career_managerhistory_domestic_cup_objective = -1;

		// Token: 0x040008F7 RID: 2295
		public static int career_managerhistory_europe_cup_objective = -1;

		// Token: 0x040008F8 RID: 2296
		public static int career_managerhistory_artificialkey = -1;

		// Token: 0x040008F9 RID: 2297
		public static int career_managerhistory_teamid = -1;

		// Token: 0x040008FA RID: 2298
		public static int career_managerhistory_goals_for = -1;

		// Token: 0x040008FB RID: 2299
		public static int career_managerhistory_points = -1;

		// Token: 0x040008FC RID: 2300
		public static int career_managerhistory_tableposition = -1;

		// Token: 0x040008FD RID: 2301
		public static int career_managerhistory_forfeits = -1;

		// Token: 0x040008FE RID: 2302
		public static int career_managerhistory_goals_against = -1;

		// Token: 0x040008FF RID: 2303
		public static int career_managerhistory_europe_cup_result = -1;

		// Token: 0x04000900 RID: 2304
		public static int career_leagueballs_balltype = -1;

		// Token: 0x04000901 RID: 2305
		public static int career_leagueballs_leagueid = -1;

		// Token: 0x04000902 RID: 2306
		public static int career_competitionprogress_compshortname = -1;

		// Token: 0x04000903 RID: 2307
		public static int career_competitionprogress_artificialkey = -1;

		// Token: 0x04000904 RID: 2308
		public static int career_competitionprogress_cup_objective_result = -1;

		// Token: 0x04000905 RID: 2309
		public static int career_competitionprogress_stageid = -1;

		// Token: 0x04000906 RID: 2310
		public static int career_competitionprogress_season = -1;

		// Token: 0x04000907 RID: 2311
		public static int career_competitionprogress_compobjid = -1;

		// Token: 0x04000908 RID: 2312
		public static int career_competitionprogress_teamid = -1;

		// Token: 0x04000909 RID: 2313
		public static int career_competitionprogress_hasteamwon = -1;

		// Token: 0x0400090A RID: 2314
		public static int career_newspicweights_teamid = -1;

		// Token: 0x0400090B RID: 2315
		public static int career_newspicweights_crestweight = -1;

		// Token: 0x0400090C RID: 2316
		public static int career_newspicweights_genericweight = -1;

		// Token: 0x0400090D RID: 2317
		public static int career_newspicweights_teamweight = -1;

		// Token: 0x0400090E RID: 2318
		public static int career_newspicweights_maxvariationsneg = -1;

		// Token: 0x0400090F RID: 2319
		public static int career_newspicweights_maxvariationspos = -1;

		// Token: 0x04000910 RID: 2320
		public static int career_newspicweights_maxvariationsstd = -1;

		// Token: 0x04000911 RID: 2321
		public static int clubcommentarynames_commentaryid = -1;

		// Token: 0x04000912 RID: 2322
		public static int clubcommentarynames_commentarystartingletter = -1;

		// Token: 0x04000913 RID: 2323
		public static int createplayerviews_attributeid = -1;

		// Token: 0x04000914 RID: 2324
		public static int createplayerviews_mainviewid = -1;

		// Token: 0x04000915 RID: 2325
		public static int createplayerpositiontemplates_attributeid = -1;

		// Token: 0x04000916 RID: 2326
		public static int createplayerpositiontemplates_attributevalue = -1;

		// Token: 0x04000917 RID: 2327
		public static int createplayerpositiontemplates_positionid = -1;

		// Token: 0x04000918 RID: 2328
		public static int createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000919 RID: 2329
		public static int createplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x0400091A RID: 2330
		public static int createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x0400091B RID: 2331
		public static int createplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x0400091C RID: 2332
		public static int createplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x0400091D RID: 2333
		public static int createplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x0400091E RID: 2334
		public static int createplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x0400091F RID: 2335
		public static int createplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000920 RID: 2336
		public static int createplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000921 RID: 2337
		public static int createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000922 RID: 2338
		public static int createplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000923 RID: 2339
		public static int createplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000924 RID: 2340
		public static int createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000925 RID: 2341
		public static int createplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000926 RID: 2342
		public static int createplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000927 RID: 2343
		public static int createplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000928 RID: 2344
		public static int createplayer_skincolor = -1;

		// Token: 0x04000929 RID: 2345
		public static int createplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x0400092A RID: 2346
		public static int createplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x0400092B RID: 2347
		public static int createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x0400092C RID: 2348
		public static int createplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x0400092D RID: 2349
		public static int createplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x0400092E RID: 2350
		public static int createplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x0400092F RID: 2351
		public static int createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000930 RID: 2352
		public static int createplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000931 RID: 2353
		public static int createplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000932 RID: 2354
		public static int createplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000933 RID: 2355
		public static int createplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000934 RID: 2356
		public static int createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000935 RID: 2357
		public static int createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000936 RID: 2358
		public static int createplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000937 RID: 2359
		public static int createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000938 RID: 2360
		public static int createplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000939 RID: 2361
		public static int createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x0400093A RID: 2362
		public static int createplayer_personaid = -1;

		// Token: 0x0400093B RID: 2363
		public static int createplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x0400093C RID: 2364
		public static int createplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x0400093D RID: 2365
		public static int createplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x0400093E RID: 2366
		public static int createplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x0400093F RID: 2367
		public static int createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000940 RID: 2368
		public static int createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000941 RID: 2369
		public static int createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000942 RID: 2370
		public static int createplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000943 RID: 2371
		public static int createplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000944 RID: 2372
		public static int createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000945 RID: 2373
		public static int createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000946 RID: 2374
		public static int createplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000947 RID: 2375
		public static int createplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000948 RID: 2376
		public static int createplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000949 RID: 2377
		public static int createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x0400094A RID: 2378
		public static int createplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x0400094B RID: 2379
		public static int createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x0400094C RID: 2380
		public static int createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x0400094D RID: 2381
		public static int createplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x0400094E RID: 2382
		public static int createplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x0400094F RID: 2383
		public static int createplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000950 RID: 2384
		public static int createplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000951 RID: 2385
		public static int createplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000952 RID: 2386
		public static int createplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000953 RID: 2387
		public static int createplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000954 RID: 2388
		public static int createplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000955 RID: 2389
		public static int createplayer_cpattributename_hair_style = -1;

		// Token: 0x04000956 RID: 2390
		public static int createplayer_create_originalplayerid = -1;

		// Token: 0x04000957 RID: 2391
		public static int createplayer_create_playerid = -1;

		// Token: 0x04000958 RID: 2392
		public static int createplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000959 RID: 2393
		public static int createplayer_celebrationid = -1;

		// Token: 0x0400095A RID: 2394
		public static int createplayer_cpattributename_brow_style = -1;

		// Token: 0x0400095B RID: 2395
		public static int createplayer_cpattributename_eye_colour = -1;

		// Token: 0x0400095C RID: 2396
		public static int createplayer_create_artificialkey = -1;

		// Token: 0x0400095D RID: 2397
		public static int createplayer_commentaryid = -1;

		// Token: 0x0400095E RID: 2398
		public static int createplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x0400095F RID: 2399
		public static int createplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000960 RID: 2400
		public static int createplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000961 RID: 2401
		public static int commentarynames_commentarystring = -1;

		// Token: 0x04000962 RID: 2402
		public static int commentarynames_commentaryid = -1;

		// Token: 0x04000963 RID: 2403
		public static int commentarynames_commentarystartingletter = -1;

		// Token: 0x04000964 RID: 2404
		public static int commentarynames_commentarypreview = -1;

		// Token: 0x04000965 RID: 2405
		public static int cz_assets_crestid = -1;

		// Token: 0x04000966 RID: 2406
		public static int cz_assets_dbid = -1;

		// Token: 0x04000967 RID: 2407
		public static int cz_assets_publishdate = -1;

		// Token: 0x04000968 RID: 2408
		public static int cz_assets_rating = -1;

		// Token: 0x04000969 RID: 2409
		public static int cz_assets_kitid = -1;

		// Token: 0x0400096A RID: 2410
		public static int cz_assets_xms_media_id = -1;

		// Token: 0x0400096B RID: 2411
		public static int cz_assets_type = -1;

		// Token: 0x0400096C RID: 2412
		public static int cz_assets_author = -1;

		// Token: 0x0400096D RID: 2413
		public static int cz_assets_assetname = -1;

		// Token: 0x0400096E RID: 2414
		public static int cz_assets_assetyear = -1;

		// Token: 0x0400096F RID: 2415
		public static int cz_assets_playerposition = -1;

		// Token: 0x04000970 RID: 2416
		public static int cz_assets_version = -1;

		// Token: 0x04000971 RID: 2417
		public static int cz_teams_hascrestimage = -1;

		// Token: 0x04000972 RID: 2418
		public static int cz_teams_hassponsorimage = -1;

		// Token: 0x04000973 RID: 2419
		public static int cz_teams_teamabbrev3 = -1;

		// Token: 0x04000974 RID: 2420
		public static int cz_teams_teamid = -1;

		// Token: 0x04000975 RID: 2421
		public static int cz_teams_commentaryid = -1;

		// Token: 0x04000976 RID: 2422
		public static int cz_teamkits_hotspotjerseyfrontsponsorr = -1;

		// Token: 0x04000977 RID: 2423
		public static int cz_teamkits_hotspotjerseyfrontsponsorb = -1;

		// Token: 0x04000978 RID: 2424
		public static int cz_teamkits_hotspotjerseyfrontsponsorl = -1;

		// Token: 0x04000979 RID: 2425
		public static int cz_teamkits_assetid = -1;

		// Token: 0x0400097A RID: 2426
		public static int cz_teamkits_hotspotjerseyfrontsponsort = -1;

		// Token: 0x0400097B RID: 2427
		public static int cz_teamkits_sockscolortertr = -1;

		// Token: 0x0400097C RID: 2428
		public static int cz_teamkits_jerseycolorprimg = -1;

		// Token: 0x0400097D RID: 2429
		public static int cz_teamkits_jerseycolortertg = -1;

		// Token: 0x0400097E RID: 2430
		public static int cz_teamkits_sponsorcolourg = -1;

		// Token: 0x0400097F RID: 2431
		public static int cz_teamkits_sockscolorsecb = -1;

		// Token: 0x04000980 RID: 2432
		public static int cz_teamkits_sponsorcolourr = -1;

		// Token: 0x04000981 RID: 2433
		public static int cz_teamkits_sockscolortertg = -1;

		// Token: 0x04000982 RID: 2434
		public static int cz_teamkits_shortcolorsecb = -1;

		// Token: 0x04000983 RID: 2435
		public static int cz_teamkits_shortcolortertg = -1;

		// Token: 0x04000984 RID: 2436
		public static int cz_teamkits_numberfonttype = -1;

		// Token: 0x04000985 RID: 2437
		public static int cz_teamkits_shortcolorprimb = -1;

		// Token: 0x04000986 RID: 2438
		public static int cz_teamkits_jerseycolorsecr = -1;

		// Token: 0x04000987 RID: 2439
		public static int cz_teamkits_jerseynamefonttype = -1;

		// Token: 0x04000988 RID: 2440
		public static int cz_teamkits_jerseynamelayouttype = -1;

		// Token: 0x04000989 RID: 2441
		public static int cz_teamkits_jerseycolortertb = -1;

		// Token: 0x0400098A RID: 2442
		public static int cz_teamkits_shortsnumbercolor = -1;

		// Token: 0x0400098B RID: 2443
		public static int cz_teamkits_jerseyshapestyle = -1;

		// Token: 0x0400098C RID: 2444
		public static int cz_teamkits_shortcolortertr = -1;

		// Token: 0x0400098D RID: 2445
		public static int cz_teamkits_shortcolorsecr = -1;

		// Token: 0x0400098E RID: 2446
		public static int cz_teamkits_jerseynamecolorg = -1;

		// Token: 0x0400098F RID: 2447
		public static int cz_teamkits_jerseycolorprimr = -1;

		// Token: 0x04000990 RID: 2448
		public static int cz_teamkits_sponsorcolourb = -1;

		// Token: 0x04000991 RID: 2449
		public static int cz_teamkits_sockscolorsecg = -1;

		// Token: 0x04000992 RID: 2450
		public static int cz_teamkits_jerseycolorsecb = -1;

		// Token: 0x04000993 RID: 2451
		public static int cz_teamkits_sockscolorprimg = -1;

		// Token: 0x04000994 RID: 2452
		public static int cz_teamkits_shortcolorprimr = -1;

		// Token: 0x04000995 RID: 2453
		public static int cz_teamkits_jerseycolortertr = -1;

		// Token: 0x04000996 RID: 2454
		public static int cz_teamkits_shortcolorsecg = -1;

		// Token: 0x04000997 RID: 2455
		public static int cz_teamkits_jerseycolorprimb = -1;

		// Token: 0x04000998 RID: 2456
		public static int cz_teamkits_sockscolorprimr = -1;

		// Token: 0x04000999 RID: 2457
		public static int cz_teamkits_sockscolorsecr = -1;

		// Token: 0x0400099A RID: 2458
		public static int cz_teamkits_shortcolortertb = -1;

		// Token: 0x0400099B RID: 2459
		public static int cz_teamkits_jerseynamecolorr = -1;

		// Token: 0x0400099C RID: 2460
		public static int cz_teamkits_numbercolor = -1;

		// Token: 0x0400099D RID: 2461
		public static int cz_teamkits_sockscolorprimb = -1;

		// Token: 0x0400099E RID: 2462
		public static int cz_teamkits_jerseycolorsecg = -1;

		// Token: 0x0400099F RID: 2463
		public static int cz_teamkits_shortsnumberfonttype = -1;

		// Token: 0x040009A0 RID: 2464
		public static int cz_teamkits_jerseynamecolorb = -1;

		// Token: 0x040009A1 RID: 2465
		public static int cz_teamkits_shortcolorprimg = -1;

		// Token: 0x040009A2 RID: 2466
		public static int cz_teamkits_sockscolortertb = -1;

		// Token: 0x040009A3 RID: 2467
		public static int cz_teamkits_jerseybacknamefontcase = -1;

		// Token: 0x040009A4 RID: 2468
		public static int cz_teamkits_hassponsor = -1;

		// Token: 0x040009A5 RID: 2469
		public static int cz_teamkits_jerseybacknameplacementcode = -1;

		// Token: 0x040009A6 RID: 2470
		public static int cz_teamkits_artificialkey = -1;

		// Token: 0x040009A7 RID: 2471
		public static int cz_teamkits_teamid = -1;

		// Token: 0x040009A8 RID: 2472
		public static int cz_teamkits_kitid = -1;

		// Token: 0x040009A9 RID: 2473
		public static int cz_teamkits_kittypeid = -1;

		// Token: 0x040009AA RID: 2474
		public static int cz_players_assetid = -1;

		// Token: 0x040009AB RID: 2475
		public static int cz_players_commentaryid = -1;

		// Token: 0x040009AC RID: 2476
		public static int cz_players_playerid = -1;

		// Token: 0x040009AD RID: 2477
		public static int cz_leagues_overlaybgcolour3r = -1;

		// Token: 0x040009AE RID: 2478
		public static int cz_leagues_tournamentballid = -1;

		// Token: 0x040009AF RID: 2479
		public static int cz_leagues_overlaytextcolour3r = -1;

		// Token: 0x040009B0 RID: 2480
		public static int cz_leagues_overlaytextcolour1g = -1;

		// Token: 0x040009B1 RID: 2481
		public static int cz_leagues_overlaytextcolour3b = -1;

		// Token: 0x040009B2 RID: 2482
		public static int cz_leagues_overlaybgcolour1g = -1;

		// Token: 0x040009B3 RID: 2483
		public static int cz_leagues_championcupslotallotment = -1;

		// Token: 0x040009B4 RID: 2484
		public static int cz_leagues_overlaybgcolour3b = -1;

		// Token: 0x040009B5 RID: 2485
		public static int cz_leagues_finalstadiumid = -1;

		// Token: 0x040009B6 RID: 2486
		public static int cz_leagues_overlaytextcolour2b = -1;

		// Token: 0x040009B7 RID: 2487
		public static int cz_leagues_overlaybgcolour1r = -1;

		// Token: 0x040009B8 RID: 2488
		public static int cz_leagues_overlaybgcolour2b = -1;

		// Token: 0x040009B9 RID: 2489
		public static int cz_leagues_overlaytextcolour1r = -1;

		// Token: 0x040009BA RID: 2490
		public static int cz_leagues_overlaytextcolour3g = -1;

		// Token: 0x040009BB RID: 2491
		public static int cz_leagues_overlaytextcolour1b = -1;

		// Token: 0x040009BC RID: 2492
		public static int cz_leagues_overlaybgcolour3g = -1;

		// Token: 0x040009BD RID: 2493
		public static int cz_leagues_overlaybgcolour1b = -1;

		// Token: 0x040009BE RID: 2494
		public static int cz_leagues_overlaybgcolour2r = -1;

		// Token: 0x040009BF RID: 2495
		public static int cz_leagues_overlaytextcolour2g = -1;

		// Token: 0x040009C0 RID: 2496
		public static int cz_leagues_eurocupslotallotment = -1;

		// Token: 0x040009C1 RID: 2497
		public static int cz_leagues_overlaytextcolour2r = -1;

		// Token: 0x040009C2 RID: 2498
		public static int cz_leagues_overlaybgcolour2g = -1;

		// Token: 0x040009C3 RID: 2499
		public static int cz_leagues_leaguedescription = -1;

		// Token: 0x040009C4 RID: 2500
		public static int cz_leagues_leaguetype = -1;

		// Token: 0x040009C5 RID: 2501
		public static int cz_leagues_numteams = -1;

		// Token: 0x040009C6 RID: 2502
		public static int cz_leagues_trophyid = -1;

		// Token: 0x040009C7 RID: 2503
		public static int cz_leagues_teamadvancingpergroup = -1;

		// Token: 0x040009C8 RID: 2504
		public static int cz_leagues_leagueid = -1;

		// Token: 0x040009C9 RID: 2505
		public static int cz_leagues_fixturevsgroup = -1;

		// Token: 0x040009CA RID: 2506
		public static int cz_leagues_teampergroup = -1;

		// Token: 0x040009CB RID: 2507
		public static int cz_leagues_finalmatchlegs = -1;

		// Token: 0x040009CC RID: 2508
		public static int cz_leagues_fixturevseachteam = -1;

		// Token: 0x040009CD RID: 2509
		public static int cz_leagues_subonbench = -1;

		// Token: 0x040009CE RID: 2510
		public static int dlcballs_name = -1;

		// Token: 0x040009CF RID: 2511
		public static int dlcballs_assetid = -1;

		// Token: 0x040009D0 RID: 2512
		public static int teamstadiumlinkscache_stadiumid = -1;

		// Token: 0x040009D1 RID: 2513
		public static int teamstadiumlinkscache_teamid = -1;

		// Token: 0x040009D2 RID: 2514
		public static int dlcboots_name = -1;

		// Token: 0x040009D3 RID: 2515
		public static int dlcboots_assetid = -1;

		// Token: 0x040009D4 RID: 2516
		public static int eatrax_album = -1;

		// Token: 0x040009D5 RID: 2517
		public static int eatrax_songname = -1;

		// Token: 0x040009D6 RID: 2518
		public static int eatrax_artist = -1;

		// Token: 0x040009D7 RID: 2519
		public static int eatrax_songid = -1;

		// Token: 0x040009D8 RID: 2520
		public static int eatrax_intro = -1;

		// Token: 0x040009D9 RID: 2521
		public static int songplaylistlinks_songid = -1;

		// Token: 0x040009DA RID: 2522
		public static int songplaylistlinks_playlistid = -1;

		// Token: 0x040009DB RID: 2523
		public static int songplaylistlinks_unlocked = -1;

		// Token: 0x040009DC RID: 2524
		public static int songplaylistlinks_artificialkey = -1;

		// Token: 0x040009DD RID: 2525
		public static int celebrations_celebrationid = -1;

		// Token: 0x040009DE RID: 2526
		public static int videos_countrycode = -1;

		// Token: 0x040009DF RID: 2527
		public static int videos_languagecode = -1;

		// Token: 0x040009E0 RID: 2528
		public static int videos_videoid = -1;

		// Token: 0x040009E1 RID: 2529
		public static int videos_artificialkey = -1;

		// Token: 0x040009E2 RID: 2530
		public static int fce_activeteams_teamid = -1;

		// Token: 0x040009E3 RID: 2531
		public static int fce_activeteams_userid = -1;

		// Token: 0x040009E4 RID: 2532
		public static int fce_weathersettings_weatherid = -1;

		// Token: 0x040009E5 RID: 2533
		public static int fce_weathersettings_rainpct = -1;

		// Token: 0x040009E6 RID: 2534
		public static int fce_weathersettings_snowpct = -1;

		// Token: 0x040009E7 RID: 2535
		public static int fce_weathersettings_clearpct = -1;

		// Token: 0x040009E8 RID: 2536
		public static int fce_weathersettings_quarter = -1;

		// Token: 0x040009E9 RID: 2537
		public static int fce_weathersettings_compid = -1;

		// Token: 0x040009EA RID: 2538
		public static int fce_weathersettings_inuse = -1;

		// Token: 0x040009EB RID: 2539
		public static int fce_statistics_goals = -1;

		// Token: 0x040009EC RID: 2540
		public static int fce_statistics_saves = -1;

		// Token: 0x040009ED RID: 2541
		public static int fce_statistics_shots = -1;

		// Token: 0x040009EE RID: 2542
		public static int fce_statistics_goalsconceded = -1;

		// Token: 0x040009EF RID: 2543
		public static int fce_statistics_totalreds = -1;

		// Token: 0x040009F0 RID: 2544
		public static int fce_statistics_manofmatch = -1;

		// Token: 0x040009F1 RID: 2545
		public static int fce_statistics_minutes = -1;

		// Token: 0x040009F2 RID: 2546
		public static int fce_statistics_appearances = -1;

		// Token: 0x040009F3 RID: 2547
		public static int fce_statistics_compid = -1;

		// Token: 0x040009F4 RID: 2548
		public static int fce_statistics_assists = -1;

		// Token: 0x040009F5 RID: 2549
		public static int fce_statistics_matchratings = -1;

		// Token: 0x040009F6 RID: 2550
		public static int fce_statistics_cleansheets = -1;

		// Token: 0x040009F7 RID: 2551
		public static int fce_statistics_teamid = -1;

		// Token: 0x040009F8 RID: 2552
		public static int fce_statistics_totalyellows = -1;

		// Token: 0x040009F9 RID: 2553
		public static int fce_statistics_statisticsid = -1;

		// Token: 0x040009FA RID: 2554
		public static int fce_statistics_playerid = -1;

		// Token: 0x040009FB RID: 2555
		public static int fce_statistics_inuse = -1;

		// Token: 0x040009FC RID: 2556
		public static int fce_standings_homegoalsfor = -1;

		// Token: 0x040009FD RID: 2557
		public static int fce_standings_teamindex = -1;

		// Token: 0x040009FE RID: 2558
		public static int fce_standings_standingsid = -1;

		// Token: 0x040009FF RID: 2559
		public static int fce_standings_homegoalsagainst = -1;

		// Token: 0x04000A00 RID: 2560
		public static int fce_standings_compid = -1;

		// Token: 0x04000A01 RID: 2561
		public static int fce_standings_homewins = -1;

		// Token: 0x04000A02 RID: 2562
		public static int fce_standings_teamid = -1;

		// Token: 0x04000A03 RID: 2563
		public static int fce_standings_awaywins = -1;

		// Token: 0x04000A04 RID: 2564
		public static int fce_standings_points = -1;

		// Token: 0x04000A05 RID: 2565
		public static int fce_standings_awaygoalsfor = -1;

		// Token: 0x04000A06 RID: 2566
		public static int fce_standings_homelosses = -1;

		// Token: 0x04000A07 RID: 2567
		public static int fce_standings_awaygoalsagainst = -1;

		// Token: 0x04000A08 RID: 2568
		public static int fce_standings_awaylosses = -1;

		// Token: 0x04000A09 RID: 2569
		public static int fce_standings_awaydraws = -1;

		// Token: 0x04000A0A RID: 2570
		public static int fce_standings_inuse = -1;

		// Token: 0x04000A0B RID: 2571
		public static int fce_standings_homedraws = -1;

		// Token: 0x04000A0C RID: 2572
		public static int fce_stageadvance_actiondate = -1;

		// Token: 0x04000A0D RID: 2573
		public static int fce_stageadvance_active = -1;

		// Token: 0x04000A0E RID: 2574
		public static int fce_stageadvance_stageindex = -1;

		// Token: 0x04000A0F RID: 2575
		public static int fce_stageadvance_randomnumber = -1;

		// Token: 0x04000A10 RID: 2576
		public static int fce_stageadvance_compid = -1;

		// Token: 0x04000A11 RID: 2577
		public static int fce_stageadvance_inuse = -1;

		// Token: 0x04000A12 RID: 2578
		public static int fce_stageadvance_stageadvanceid = -1;

		// Token: 0x04000A13 RID: 2579
		public static int fce_settings_settingvalue = -1;

		// Token: 0x04000A14 RID: 2580
		public static int fce_settings_settingenumid = -1;

		// Token: 0x04000A15 RID: 2581
		public static int fce_settings_settingid = -1;

		// Token: 0x04000A16 RID: 2582
		public static int fce_settings_compid = -1;

		// Token: 0x04000A17 RID: 2583
		public static int fce_settings_inuse = -1;

		// Token: 0x04000A18 RID: 2584
		public static int fce_scriptfunctions_scriptfuncid = -1;

		// Token: 0x04000A19 RID: 2585
		public static int fce_scriptfunctions_funcparam1 = -1;

		// Token: 0x04000A1A RID: 2586
		public static int fce_scriptfunctions_compid = -1;

		// Token: 0x04000A1B RID: 2587
		public static int fce_scriptfunctions_funcparam2 = -1;

		// Token: 0x04000A1C RID: 2588
		public static int fce_scriptfunctions_targetcompid = -1;

		// Token: 0x04000A1D RID: 2589
		public static int fce_scriptfunctions_funcparam3 = -1;

		// Token: 0x04000A1E RID: 2590
		public static int fce_scriptfunctions_inuse = -1;

		// Token: 0x04000A1F RID: 2591
		public static int fce_scriptfunctions_functype = -1;

		// Token: 0x04000A20 RID: 2592
		public static int fce_scheduleinfo_time = -1;

		// Token: 0x04000A21 RID: 2593
		public static int fce_scheduleinfo_dayofweek = -1;

		// Token: 0x04000A22 RID: 2594
		public static int fce_scheduleinfo_compid = -1;

		// Token: 0x04000A23 RID: 2595
		public static int fce_scheduleinfo_chance = -1;

		// Token: 0x04000A24 RID: 2596
		public static int fce_scheduleinfo_priority = -1;

		// Token: 0x04000A25 RID: 2597
		public static int fce_scheduleinfo_inuse = -1;

		// Token: 0x04000A26 RID: 2598
		public static int fce_scheduleinfo_scheduleinfoid = -1;

		// Token: 0x04000A27 RID: 2599
		public static int fce_fixtures_time = -1;

		// Token: 0x04000A28 RID: 2600
		public static int fce_fixtures_homescore = -1;

		// Token: 0x04000A29 RID: 2601
		public static int fce_fixtures_awayscore = -1;

		// Token: 0x04000A2A RID: 2602
		public static int fce_fixtures_gamecompletion = -1;

		// Token: 0x04000A2B RID: 2603
		public static int fce_fixtures_compid = -1;

		// Token: 0x04000A2C RID: 2604
		public static int fce_fixtures_date = -1;

		// Token: 0x04000A2D RID: 2605
		public static int fce_fixtures_fixtureid = -1;

		// Token: 0x04000A2E RID: 2606
		public static int fce_fixtures_awaystandingid = -1;

		// Token: 0x04000A2F RID: 2607
		public static int fce_fixtures_homestandingid = -1;

		// Token: 0x04000A30 RID: 2608
		public static int fce_fixtures_awaypens = -1;

		// Token: 0x04000A31 RID: 2609
		public static int fce_fixtures_homepens = -1;

		// Token: 0x04000A32 RID: 2610
		public static int fce_fixtures_inuse = -1;

		// Token: 0x04000A33 RID: 2611
		public static int fce_competitionteams_teamindex = -1;

		// Token: 0x04000A34 RID: 2612
		public static int fce_competitionteams_compteamid = -1;

		// Token: 0x04000A35 RID: 2613
		public static int fce_competitionteams_compid = -1;

		// Token: 0x04000A36 RID: 2614
		public static int fce_competitionteams_teamid = -1;

		// Token: 0x04000A37 RID: 2615
		public static int fce_competitionteams_inuse = -1;

		// Token: 0x04000A38 RID: 2616
		public static int fce_competitioninfo_compobjshortdesc = -1;

		// Token: 0x04000A39 RID: 2617
		public static int fce_competitioninfo_compobjdesc = -1;

		// Token: 0x04000A3A RID: 2618
		public static int fce_competitioninfo_compparentid = -1;

		// Token: 0x04000A3B RID: 2619
		public static int fce_competitioninfo_comptype = -1;

		// Token: 0x04000A3C RID: 2620
		public static int fce_competitioninfo_compid = -1;

		// Token: 0x04000A3D RID: 2621
		public static int fce_competitioninfo_inuse = -1;

		// Token: 0x04000A3E RID: 2622
		public static int fce_compavgs_mid = -1;

		// Token: 0x04000A3F RID: 2623
		public static int fce_compavgs_ovr = -1;

		// Token: 0x04000A40 RID: 2624
		public static int fce_compavgs_def = -1;

		// Token: 0x04000A41 RID: 2625
		public static int fce_compavgs_compid = -1;

		// Token: 0x04000A42 RID: 2626
		public static int fce_compavgs_gk = -1;

		// Token: 0x04000A43 RID: 2627
		public static int fce_compavgs_att = -1;

		// Token: 0x04000A44 RID: 2628
		public static int fce_advancement_fromcompid = -1;

		// Token: 0x04000A45 RID: 2629
		public static int fce_advancement_fromteamindex = -1;

		// Token: 0x04000A46 RID: 2630
		public static int fce_advancement_tocompid = -1;

		// Token: 0x04000A47 RID: 2631
		public static int fce_advancement_advancementid = -1;

		// Token: 0x04000A48 RID: 2632
		public static int fce_advancement_toteamindex = -1;

		// Token: 0x04000A49 RID: 2633
		public static int fce_advancement_inuse = -1;

		// Token: 0x04000A4A RID: 2634
		public static int fifaGameSettings_IonCameraZPosition = -1;

		// Token: 0x04000A4B RID: 2635
		public static int fifaGameSettings_GcAccelerationUser = -1;

		// Token: 0x04000A4C RID: 2636
		public static int fifaGameSettings_CamOTP = -1;

		// Token: 0x04000A4D RID: 2637
		public static int fifaGameSettings_FirstBoot = -1;

		// Token: 0x04000A4E RID: 2638
		public static int fifaGameSettings_GcSprintSpeedCpu = -1;

		// Token: 0x04000A4F RID: 2639
		public static int fifaGameSettings_GcGkAbilityUser = -1;

		// Token: 0x04000A50 RID: 2640
		public static int fifaGameSettings_GcShotErrorCpu = -1;

		// Token: 0x04000A51 RID: 2641
		public static int fifaGameSettings_KinCustomMentalityCmd = -1;

		// Token: 0x04000A52 RID: 2642
		public static int fifaGameSettings_GcPosLineWidthCpu = -1;

		// Token: 0x04000A53 RID: 2643
		public static int fifaGameSettings_GoalNews = -1;

		// Token: 0x04000A54 RID: 2644
		public static int fifaGameSettings_Penalties = -1;

		// Token: 0x04000A55 RID: 2645
		public static int fifaGameSettings_GcPassErrorUser = -1;

		// Token: 0x04000A56 RID: 2646
		public static int fifaGameSettings_GenericSetting0 = -1;

		// Token: 0x04000A57 RID: 2647
		public static int fifaGameSettings_Camera = -1;

		// Token: 0x04000A58 RID: 2648
		public static int fifaGameSettings_PAVolume = -1;

		// Token: 0x04000A59 RID: 2649
		public static int fifaGameSettings_Vibration = -1;

		// Token: 0x04000A5A RID: 2650
		public static int fifaGameSettings_KinCustomFormation = -1;

		// Token: 0x04000A5B RID: 2651
		public static int fifaGameSettings_SubsOnBench = -1;

		// Token: 0x04000A5C RID: 2652
		public static int fifaGameSettings_CamHeight = -1;

		// Token: 0x04000A5D RID: 2653
		public static int fifaGameSettings_DifficultyLevel = -1;

		// Token: 0x04000A5E RID: 2654
		public static int fifaGameSettings_PitchWear = -1;

		// Token: 0x04000A5F RID: 2655
		public static int fifaGameSettings_KinCustomFormationCmd = -1;

		// Token: 0x04000A60 RID: 2656
		public static int fifaGameSettings_MowPattern = -1;

		// Token: 0x04000A61 RID: 2657
		public static int fifaGameSettings_GcPosDefensiveLineHeightCpu = -1;

		// Token: 0x04000A62 RID: 2658
		public static int fifaGameSettings_Ball = -1;

		// Token: 0x04000A63 RID: 2659
		public static int fifaGameSettings_Handball = -1;

		// Token: 0x04000A64 RID: 2660
		public static int fifaGameSettings_GameSettingsContext = -1;

		// Token: 0x04000A65 RID: 2661
		public static int fifaGameSettings_GcTrapErrorUser = -1;

		// Token: 0x04000A66 RID: 2662
		public static int fifaGameSettings_GcPosRunFrequencyCpu = -1;

		// Token: 0x04000A67 RID: 2663
		public static int fifaGameSettings_KinCustomMentality = -1;

		// Token: 0x04000A68 RID: 2664
		public static int fifaGameSettings_Season = -1;

		// Token: 0x04000A69 RID: 2665
		public static int fifaGameSettings_MM_DifficultyLevel = -1;

		// Token: 0x04000A6A RID: 2666
		public static int fifaGameSettings_FIWC_Ball = -1;

		// Token: 0x04000A6B RID: 2667
		public static int fifaGameSettings_UserMusicVolume = -1;

		// Token: 0x04000A6C RID: 2668
		public static int fifaGameSettings_PerformanceBar = -1;

		// Token: 0x04000A6D RID: 2669
		public static int fifaGameSettings_MusicVolume = -1;

		// Token: 0x04000A6E RID: 2670
		public static int fifaGameSettings_GcPosFullbackPositioningUser = -1;

		// Token: 0x04000A6F RID: 2671
		public static int fifaGameSettings_KinFormation5 = -1;

		// Token: 0x04000A70 RID: 2672
		public static int fifaGameSettings_GcPosLineLengthCpu = -1;

		// Token: 0x04000A71 RID: 2673
		public static int fifaGameSettings_GcPassSpeedCpu = -1;

		// Token: 0x04000A72 RID: 2674
		public static int fifaGameSettings_KinCustomFutFormation = -1;

		// Token: 0x04000A73 RID: 2675
		public static int fifaGameSettings_GcInjurySeverityUser = -1;

		// Token: 0x04000A74 RID: 2676
		public static int fifaGameSettings_KinFutFormation2 = -1;

		// Token: 0x04000A75 RID: 2677
		public static int fifaGameSettings_KinFormation2 = -1;

		// Token: 0x04000A76 RID: 2678
		public static int fifaGameSettings_GcTrapErrorCpu = -1;

		// Token: 0x04000A77 RID: 2679
		public static int fifaGameSettings_KinFutFormation1 = -1;

		// Token: 0x04000A78 RID: 2680
		public static int fifaGameSettings_GcShotSpeedUser = -1;

		// Token: 0x04000A79 RID: 2681
		public static int fifaGameSettings_GcInjuryFrequencyUser = -1;

		// Token: 0x04000A7A RID: 2682
		public static int fifaGameSettings_StartUpTutorial = -1;

		// Token: 0x04000A7B RID: 2683
		public static int fifaGameSettings_MovDifficultyLevel = -1;

		// Token: 0x04000A7C RID: 2684
		public static int fifaGameSettings_GcPowerBarUser = -1;

		// Token: 0x04000A7D RID: 2685
		public static int fifaGameSettings_KinComboCommand = -1;

		// Token: 0x04000A7E RID: 2686
		public static int fifaGameSettings_KinCustomTacticCmd = -1;

		// Token: 0x04000A7F RID: 2687
		public static int fifaGameSettings_GcSprintSpeedUser = -1;

		// Token: 0x04000A80 RID: 2688
		public static int fifaGameSettings_KinComboFormation = -1;

		// Token: 0x04000A81 RID: 2689
		public static int fifaGameSettings_GcShotSpeedCpu = -1;

		// Token: 0x04000A82 RID: 2690
		public static int fifaGameSettings_NetShape = -1;

		// Token: 0x04000A83 RID: 2691
		public static int fifaGameSettings_UgcAllowed = -1;

		// Token: 0x04000A84 RID: 2692
		public static int fifaGameSettings_Contrast = -1;

		// Token: 0x04000A85 RID: 2693
		public static int fifaGameSettings_TimeScoreDisplay = -1;

		// Token: 0x04000A86 RID: 2694
		public static int fifaGameSettings_GcPassErrorCpu = -1;

		// Token: 0x04000A87 RID: 2695
		public static int fifaGameSettings_RadarOrientation = -1;

		// Token: 0x04000A88 RID: 2696
		public static int fifaGameSettings_KinComboFutFormation = -1;

		// Token: 0x04000A89 RID: 2697
		public static int fifaGameSettings_IPI = -1;

		// Token: 0x04000A8A RID: 2698
		public static int fifaGameSettings_CommentaryVolume = -1;

		// Token: 0x04000A8B RID: 2699
		public static int fifaGameSettings_FavoriteTeam = -1;

		// Token: 0x04000A8C RID: 2700
		public static int fifaGameSettings_MenuMusicVolume = -1;

		// Token: 0x04000A8D RID: 2701
		public static int fifaGameSettings_GcGkAbilityCpu = -1;

		// Token: 0x04000A8E RID: 2702
		public static int fifaGameSettings_KinFormation4 = -1;

		// Token: 0x04000A8F RID: 2703
		public static int fifaGameSettings_Offsides = -1;

		// Token: 0x04000A90 RID: 2704
		public static int fifaGameSettings_CamProSpeed = -1;

		// Token: 0x04000A91 RID: 2705
		public static int fifaGameSettings_GameSettingsPK = -1;

		// Token: 0x04000A92 RID: 2706
		public static int fifaGameSettings_HalfLength = -1;

		// Token: 0x04000A93 RID: 2707
		public static int fifaGameSettings_KinFutFormation5 = -1;

		// Token: 0x04000A94 RID: 2708
		public static int fifaGameSettings_CommentaryTeam = -1;

		// Token: 0x04000A95 RID: 2709
		public static int fifaGameSettings_GcPosFullbackPositioningCpu = -1;

		// Token: 0x04000A96 RID: 2710
		public static int fifaGameSettings_PosIndicator = -1;

		// Token: 0x04000A97 RID: 2711
		public static int fifaGameSettings_CamSingle = -1;

		// Token: 0x04000A98 RID: 2712
		public static int fifaGameSettings_NumOfSubs = -1;

		// Token: 0x04000A99 RID: 2713
		public static int fifaGameSettings_GcPassSpeedUser = -1;

		// Token: 0x04000A9A RID: 2714
		public static int fifaGameSettings_CamBeAPro = -1;

		// Token: 0x04000A9B RID: 2715
		public static int fifaGameSettings_BallTrailIndicator = -1;

		// Token: 0x04000A9C RID: 2716
		public static int fifaGameSettings_CamProSwing = -1;

		// Token: 0x04000A9D RID: 2717
		public static int fifaGameSettings_NetTension = -1;

		// Token: 0x04000A9E RID: 2718
		public static int fifaGameSettings_UserChantsVolume = -1;

		// Token: 0x04000A9F RID: 2719
		public static int fifaGameSettings_CrowdVolume = -1;

		// Token: 0x04000AA0 RID: 2720
		public static int fifaGameSettings_DynamicTimeOfDay = -1;

		// Token: 0x04000AA1 RID: 2721
		public static int fifaGameSettings_CamProZoom = -1;

		// Token: 0x04000AA2 RID: 2722
		public static int fifaGameSettings_AutoSave = -1;

		// Token: 0x04000AA3 RID: 2723
		public static int fifaGameSettings_KinFormation3 = -1;

		// Token: 0x04000AA4 RID: 2724
		public static int fifaGameSettings_KinFutFormation3 = -1;

		// Token: 0x04000AA5 RID: 2725
		public static int fifaGameSettings_GcInjuryFrequencyCpu = -1;

		// Token: 0x04000AA6 RID: 2726
		public static int fifaGameSettings_NIB = -1;

		// Token: 0x04000AA7 RID: 2727
		public static int fifaGameSettings_GcPosDefensiveLineHeightUser = -1;

		// Token: 0x04000AA8 RID: 2728
		public static int fifaGameSettings_ThreatIndicator = -1;

		// Token: 0x04000AA9 RID: 2729
		public static int fifaGameSettings_PlayerCalls = -1;

		// Token: 0x04000AAA RID: 2730
		public static int fifaGameSettings_Injuries = -1;

		// Token: 0x04000AAB RID: 2731
		public static int fifaGameSettings_CamZoomHeightEnable = -1;

		// Token: 0x04000AAC RID: 2732
		public static int fifaGameSettings_StadiumNameInfo = -1;

		// Token: 0x04000AAD RID: 2733
		public static int fifaGameSettings_KinFutFormation4 = -1;

		// Token: 0x04000AAE RID: 2734
		public static int fifaGameSettings_CamZoom = -1;

		// Token: 0x04000AAF RID: 2735
		public static int fifaGameSettings_CamMulti = -1;

		// Token: 0x04000AB0 RID: 2736
		public static int fifaGameSettings_KinRefereeHearing = -1;

		// Token: 0x04000AB1 RID: 2737
		public static int fifaGameSettings_AwayAutoSwitch = -1;

		// Token: 0x04000AB2 RID: 2738
		public static int fifaGameSettings_AudioSetup = -1;

		// Token: 0x04000AB3 RID: 2739
		public static int fifaGameSettings_Weather = -1;

		// Token: 0x04000AB4 RID: 2740
		public static int fifaGameSettings_GcInjurySeverityCpu = -1;

		// Token: 0x04000AB5 RID: 2741
		public static int fifaGameSettings_Avatar = -1;

		// Token: 0x04000AB6 RID: 2742
		public static int fifaGameSettings_Referee_ID = -1;

		// Token: 0x04000AB7 RID: 2743
		public static int fifaGameSettings_Radar = -1;

		// Token: 0x04000AB8 RID: 2744
		public static int fifaGameSettings_HomeAutoSwitch = -1;

		// Token: 0x04000AB9 RID: 2745
		public static int fifaGameSettings_CPUPlayerStatus = -1;

		// Token: 0x04000ABA RID: 2746
		public static int fifaGameSettings_Brightness = -1;

		// Token: 0x04000ABB RID: 2747
		public static int fifaGameSettings_KinFormation1 = -1;

		// Token: 0x04000ABC RID: 2748
		public static int fifaGameSettings_BallFutureTrajectoryIndicator = -1;

		// Token: 0x04000ABD RID: 2749
		public static int fifaGameSettings_GenericSetting2 = -1;

		// Token: 0x04000ABE RID: 2750
		public static int fifaGameSettings_TimeOfDay = -1;

		// Token: 0x04000ABF RID: 2751
		public static int fifaGameSettings_ExtraTime = -1;

		// Token: 0x04000AC0 RID: 2752
		public static int fifaGameSettings_lm_LoungeStadium = -1;

		// Token: 0x04000AC1 RID: 2753
		public static int fifaGameSettings_KinSpeechRecognition = -1;

		// Token: 0x04000AC2 RID: 2754
		public static int fifaGameSettings_KinComboMentality = -1;

		// Token: 0x04000AC3 RID: 2755
		public static int fifaGameSettings_NIBState = -1;

		// Token: 0x04000AC4 RID: 2756
		public static int fifaGameSettings_Bookings = -1;

		// Token: 0x04000AC5 RID: 2757
		public static int fifaGameSettings_GcPosLineLengthUser = -1;

		// Token: 0x04000AC6 RID: 2758
		public static int fifaGameSettings_GcPosLineWidthUser = -1;

		// Token: 0x04000AC7 RID: 2759
		public static int fifaGameSettings_GenericSetting1 = -1;

		// Token: 0x04000AC8 RID: 2760
		public static int fifaGameSettings_GcShotErrorUser = -1;

		// Token: 0x04000AC9 RID: 2761
		public static int fifaGameSettings_CommentaryLanguage = -1;

		// Token: 0x04000ACA RID: 2762
		public static int fifaGameSettings_GcAccelerationCpu = -1;

		// Token: 0x04000ACB RID: 2763
		public static int fifaGameSettings_GcPosRunFrequencyUser = -1;

		// Token: 0x04000ACC RID: 2764
		public static int fifaGameSettings_KinCustomTactic = -1;

		// Token: 0x04000ACD RID: 2765
		public static int fifaGameSettings_KinComboTactic = -1;

		// Token: 0x04000ACE RID: 2766
		public static int fifaGameSettings_PlayerStatusBar = -1;

		// Token: 0x04000ACF RID: 2767
		public static int fifaGameSettings_GcPosMarkingUser = -1;

		// Token: 0x04000AD0 RID: 2768
		public static int fifaGameSettings_RadarLocation = -1;

		// Token: 0x04000AD1 RID: 2769
		public static int fifaGameSettings_OwnOnlineGamerTag = -1;

		// Token: 0x04000AD2 RID: 2770
		public static int fifaGameSettings_GameFXVolume = -1;

		// Token: 0x04000AD3 RID: 2771
		public static int fifaGameSettings_GcPosMarkingCpu = -1;

		// Token: 0x04000AD4 RID: 2772
		public static int fifaGameSettings_CamBeAKeeper = -1;

		// Token: 0x04000AD5 RID: 2773
		public static int fifaGameSettings_lm_MatchUpSetting = -1;

		// Token: 0x04000AD6 RID: 2774
		public static int fifaGameSettings_GameSpeed = -1;

		// Token: 0x04000AD7 RID: 2775
		public static int fifaGameSettings_ShootSwitching = -1;

		// Token: 0x04000AD8 RID: 2776
		public static int fifaGameSettings_MovAssistedPathFinding = -1;

		// Token: 0x04000AD9 RID: 2777
		public static int mls_fixtures_fixture_id = -1;

		// Token: 0x04000ADA RID: 2778
		public static int mls_fixtures_rtsg = -1;

		// Token: 0x04000ADB RID: 2779
		public static int mls_fixtures_away_id = -1;

		// Token: 0x04000ADC RID: 2780
		public static int mls_fixtures_home_score = -1;

		// Token: 0x04000ADD RID: 2781
		public static int mls_fixtures_date = -1;

		// Token: 0x04000ADE RID: 2782
		public static int mls_fixtures_game_flags = -1;

		// Token: 0x04000ADF RID: 2783
		public static int mls_fixtures_away_score = -1;

		// Token: 0x04000AE0 RID: 2784
		public static int mls_fixtures_home_id = -1;

		// Token: 0x04000AE1 RID: 2785
		public static int customteamstyles_defmentality = -1;

		// Token: 0x04000AE2 RID: 2786
		public static int customteamstyles_teamstyleid = -1;

		// Token: 0x04000AE3 RID: 2787
		public static int customteamstyles_basestyle = -1;

		// Token: 0x04000AE4 RID: 2788
		public static int customteamstyles_buspassing = -1;

		// Token: 0x04000AE5 RID: 2789
		public static int customteamstyles_defteamwidth = -1;

		// Token: 0x04000AE6 RID: 2790
		public static int customteamstyles_defaggression = -1;

		// Token: 0x04000AE7 RID: 2791
		public static int customteamstyles_buspositioning = -1;

		// Token: 0x04000AE8 RID: 2792
		public static int customteamstyles_ccpositioning = -1;

		// Token: 0x04000AE9 RID: 2793
		public static int customteamstyles_busbuildupspeed = -1;

		// Token: 0x04000AEA RID: 2794
		public static int customteamstyles_ccshooting = -1;

		// Token: 0x04000AEB RID: 2795
		public static int customteamstyles_ccpassing = -1;

		// Token: 0x04000AEC RID: 2796
		public static int customteamstyles_defdefenderline = -1;

		// Token: 0x04000AED RID: 2797
		public static int customteamstyles_cccrossing = -1;

		// Token: 0x04000AEE RID: 2798
		public static int teamformationteamstylelinks_teamstyleid = -1;

		// Token: 0x04000AEF RID: 2799
		public static int teamformationteamstylelinks_teamid = -1;

		// Token: 0x04000AF0 RID: 2800
		public static int teamformationteamstylelinks_formationid = -1;

		// Token: 0x04000AF1 RID: 2801
		public static int teamformationteamstylelinks_cddl = -1;

		// Token: 0x04000AF2 RID: 2802
		public static int career_news_body = -1;

		// Token: 0x04000AF3 RID: 2803
		public static int career_news_image = -1;

		// Token: 0x04000AF4 RID: 2804
		public static int career_news_title = -1;

		// Token: 0x04000AF5 RID: 2805
		public static int career_news_importance = -1;

		// Token: 0x04000AF6 RID: 2806
		public static int career_news_date = -1;

		// Token: 0x04000AF7 RID: 2807
		public static int career_news_teamid = -1;

		// Token: 0x04000AF8 RID: 2808
		public static int career_news_playerid = -1;

		// Token: 0x04000AF9 RID: 2809
		public static int career_news_crest = -1;

		// Token: 0x04000AFA RID: 2810
		public static int career_news_newsid = -1;

		// Token: 0x04000AFB RID: 2811
		public static int career_news_emotion = -1;

		// Token: 0x04000AFC RID: 2812
		public static int career_news_type = -1;

		// Token: 0x04000AFD RID: 2813
		public static int career_newsban_artificialkey = -1;

		// Token: 0x04000AFE RID: 2814
		public static int career_newsban_newstype = -1;

		// Token: 0x04000AFF RID: 2815
		public static int career_newsban_compobjid = -1;

		// Token: 0x04000B00 RID: 2816
		public static int career_newsban_teamid = -1;

		// Token: 0x04000B01 RID: 2817
		public static int persistent_events_MiscValue = -1;

		// Token: 0x04000B02 RID: 2818
		public static int persistent_events_Team2Id = -1;

		// Token: 0x04000B03 RID: 2819
		public static int persistent_events_Id = -1;

		// Token: 0x04000B04 RID: 2820
		public static int persistent_events_CompObjId = -1;

		// Token: 0x04000B05 RID: 2821
		public static int persistent_events_EventId = -1;

		// Token: 0x04000B06 RID: 2822
		public static int persistent_events_Team1Id = -1;

		// Token: 0x04000B07 RID: 2823
		public static int persistent_events_EventDate = -1;

		// Token: 0x04000B08 RID: 2824
		public static int persistent_events_Player1Id = -1;

		// Token: 0x04000B09 RID: 2825
		public static int career_playasplayer_numwithdrawrequests = -1;

		// Token: 0x04000B0A RID: 2826
		public static int career_playasplayer_numconsecclubbenched = -1;

		// Token: 0x04000B0B RID: 2827
		public static int career_playasplayer_lastwithdrawdate = -1;

		// Token: 0x04000B0C RID: 2828
		public static int career_playasplayer_playedlastmatch = -1;

		// Token: 0x04000B0D RID: 2829
		public static int career_playasplayer_numtransferrequests = -1;

		// Token: 0x04000B0E RID: 2830
		public static int career_playasplayer_requestactiondays = -1;

		// Token: 0x04000B0F RID: 2831
		public static int career_playasplayer_position = -1;

		// Token: 0x04000B10 RID: 2832
		public static int career_playasplayer_playerrequest = -1;

		// Token: 0x04000B11 RID: 2833
		public static int career_playasplayer_numloanrequests = -1;

		// Token: 0x04000B12 RID: 2834
		public static int career_playasplayer_numconsecnatbenched = -1;

		// Token: 0x04000B13 RID: 2835
		public static int career_playasplayer_playerid = -1;

		// Token: 0x04000B14 RID: 2836
		public static int career_playasplayer_userid = -1;

		// Token: 0x04000B15 RID: 2837
		public static int career_playerbonusper_bonus_per_15 = -1;

		// Token: 0x04000B16 RID: 2838
		public static int career_playerbonusper_clubleveltype = -1;

		// Token: 0x04000B17 RID: 2839
		public static int career_playerbonusper_bonus_per_5 = -1;

		// Token: 0x04000B18 RID: 2840
		public static int career_playerbonusper_bonus_per_20 = -1;

		// Token: 0x04000B19 RID: 2841
		public static int career_playerbonusper_bonus_per_0 = -1;

		// Token: 0x04000B1A RID: 2842
		public static int career_playerbonusper_bonus_per_10 = -1;

		// Token: 0x04000B1B RID: 2843
		public static int career_playasplayerhistory_goals = -1;

		// Token: 0x04000B1C RID: 2844
		public static int career_playasplayerhistory_saves = -1;

		// Token: 0x04000B1D RID: 2845
		public static int career_playasplayerhistory_totaltackles = -1;

		// Token: 0x04000B1E RID: 2846
		public static int career_playasplayerhistory_tacklesontarget = -1;

		// Token: 0x04000B1F RID: 2847
		public static int career_playasplayerhistory_totalshots = -1;

		// Token: 0x04000B20 RID: 2848
		public static int career_playasplayerhistory_totalpasses = -1;

		// Token: 0x04000B21 RID: 2849
		public static int career_playasplayerhistory_motm = -1;

		// Token: 0x04000B22 RID: 2850
		public static int career_playasplayerhistory_fouls = -1;

		// Token: 0x04000B23 RID: 2851
		public static int career_playasplayerhistory_saveattemps = -1;

		// Token: 0x04000B24 RID: 2852
		public static int career_playasplayerhistory_shotsontarget = -1;

		// Token: 0x04000B25 RID: 2853
		public static int career_playasplayerhistory_passesontarget = -1;

		// Token: 0x04000B26 RID: 2854
		public static int career_playasplayerhistory_continentalcuptrophies = -1;

		// Token: 0x04000B27 RID: 2855
		public static int career_playasplayerhistory_totalreds = -1;

		// Token: 0x04000B28 RID: 2856
		public static int career_playasplayerhistory_draws = -1;

		// Token: 0x04000B29 RID: 2857
		public static int career_playasplayerhistory_season = -1;

		// Token: 0x04000B2A RID: 2858
		public static int career_playasplayerhistory_leaguetrophies = -1;

		// Token: 0x04000B2B RID: 2859
		public static int career_playasplayerhistory_loses = -1;

		// Token: 0x04000B2C RID: 2860
		public static int career_playasplayerhistory_playasplayerhistoryid = -1;

		// Token: 0x04000B2D RID: 2861
		public static int career_playasplayerhistory_domesticcuptrophies = -1;

		// Token: 0x04000B2E RID: 2862
		public static int career_playasplayerhistory_wins = -1;

		// Token: 0x04000B2F RID: 2863
		public static int career_playasplayerhistory_leagueid = -1;

		// Token: 0x04000B30 RID: 2864
		public static int career_playasplayerhistory_appearances = -1;

		// Token: 0x04000B31 RID: 2865
		public static int career_playasplayerhistory_overall = -1;

		// Token: 0x04000B32 RID: 2866
		public static int career_playasplayerhistory_wage = -1;

		// Token: 0x04000B33 RID: 2867
		public static int career_playasplayerhistory_value = -1;

		// Token: 0x04000B34 RID: 2868
		public static int career_playasplayerhistory_assists = -1;

		// Token: 0x04000B35 RID: 2869
		public static int career_playasplayerhistory_matchratings = -1;

		// Token: 0x04000B36 RID: 2870
		public static int career_playasplayerhistory_cleansheets = -1;

		// Token: 0x04000B37 RID: 2871
		public static int career_playasplayerhistory_position = -1;

		// Token: 0x04000B38 RID: 2872
		public static int career_playasplayerhistory_goalsconceded = -1;

		// Token: 0x04000B39 RID: 2873
		public static int career_playasplayerhistory_teamid = -1;

		// Token: 0x04000B3A RID: 2874
		public static int career_playasplayerhistory_totalyellows = -1;

		// Token: 0x04000B3B RID: 2875
		public static int career_playasplayerhistory_clublevel = -1;

		// Token: 0x04000B3C RID: 2876
		public static int career_playasplayerhistory_tableposition = -1;

		// Token: 0x04000B3D RID: 2877
		public static int career_playasplayerhistory_userid = -1;

		// Token: 0x04000B3E RID: 2878
		public static int career_growthcurveinfo_physicalcurveid = -1;

		// Token: 0x04000B3F RID: 2879
		public static int career_growthcurveinfo_physicalcurveoffset = -1;

		// Token: 0x04000B40 RID: 2880
		public static int career_growthcurveinfo_mentalcurveid = -1;

		// Token: 0x04000B41 RID: 2881
		public static int career_growthcurveinfo_skillcurveoffset = -1;

		// Token: 0x04000B42 RID: 2882
		public static int career_growthcurveinfo_mentalcurveoffset = -1;

		// Token: 0x04000B43 RID: 2883
		public static int career_growthcurveinfo_playerid = -1;

		// Token: 0x04000B44 RID: 2884
		public static int career_growthcurveinfo_skillcurveid = -1;

		// Token: 0x04000B45 RID: 2885
		public static int player_growth_experience_points_skill_xp = -1;

		// Token: 0x04000B46 RID: 2886
		public static int player_growth_experience_points_potential = -1;

		// Token: 0x04000B47 RID: 2887
		public static int player_growth_experience_points_mental_xp = -1;

		// Token: 0x04000B48 RID: 2888
		public static int player_growth_experience_points_physical_xp = -1;

		// Token: 0x04000B49 RID: 2889
		public static int player_growth_experience_points_playerid = -1;

		// Token: 0x04000B4A RID: 2890
		public static int player_career_season_num = -1;

		// Token: 0x04000B4B RID: 2891
		public static int player_career_overall = -1;

		// Token: 0x04000B4C RID: 2892
		public static int player_career_artificialkey = -1;

		// Token: 0x04000B4D RID: 2893
		public static int player_career_playerid = -1;

		// Token: 0x04000B4E RID: 2894
		public static int experiencepoints_createplayer_xp = -1;

		// Token: 0x04000B4F RID: 2895
		public static int experiencepoints_playerid = -1;

		// Token: 0x04000B50 RID: 2896
		public static int career_playergrowthuserseason_curve = -1;

		// Token: 0x04000B51 RID: 2897
		public static int career_playergrowthuserseason_agility = -1;

		// Token: 0x04000B52 RID: 2898
		public static int career_playergrowthuserseason_positioning = -1;

		// Token: 0x04000B53 RID: 2899
		public static int career_playergrowthuserseason_standingtackle = -1;

		// Token: 0x04000B54 RID: 2900
		public static int career_playergrowthuserseason_longpassing = -1;

		// Token: 0x04000B55 RID: 2901
		public static int career_playergrowthuserseason_penalties = -1;

		// Token: 0x04000B56 RID: 2902
		public static int career_playergrowthuserseason_longshots = -1;

		// Token: 0x04000B57 RID: 2903
		public static int career_playergrowthuserseason_gkdiving = -1;

		// Token: 0x04000B58 RID: 2904
		public static int career_playergrowthuserseason_interceptions = -1;

		// Token: 0x04000B59 RID: 2905
		public static int career_playergrowthuserseason_crossing = -1;

		// Token: 0x04000B5A RID: 2906
		public static int career_playergrowthuserseason_gkreflexes = -1;

		// Token: 0x04000B5B RID: 2907
		public static int career_playergrowthuserseason_reactions = -1;

		// Token: 0x04000B5C RID: 2908
		public static int career_playergrowthuserseason_vision = -1;

		// Token: 0x04000B5D RID: 2909
		public static int career_playergrowthuserseason_finishing = -1;

		// Token: 0x04000B5E RID: 2910
		public static int career_playergrowthuserseason_dribspeed = -1;

		// Token: 0x04000B5F RID: 2911
		public static int career_playergrowthuserseason_dribbling = -1;

		// Token: 0x04000B60 RID: 2912
		public static int career_playergrowthuserseason_slidingtackle = -1;

		// Token: 0x04000B61 RID: 2913
		public static int career_playergrowthuserseason_sprintspeed = -1;

		// Token: 0x04000B62 RID: 2914
		public static int career_playergrowthuserseason_strength = -1;

		// Token: 0x04000B63 RID: 2915
		public static int career_playergrowthuserseason_ballcontrol = -1;

		// Token: 0x04000B64 RID: 2916
		public static int career_playergrowthuserseason_shotpower = -1;

		// Token: 0x04000B65 RID: 2917
		public static int career_playergrowthuserseason_balance = -1;

		// Token: 0x04000B66 RID: 2918
		public static int career_playergrowthuserseason_gkkicking = -1;

		// Token: 0x04000B67 RID: 2919
		public static int career_playergrowthuserseason_shortpassing = -1;

		// Token: 0x04000B68 RID: 2920
		public static int career_playergrowthuserseason_freekickaccuracy = -1;

		// Token: 0x04000B69 RID: 2921
		public static int career_playergrowthuserseason_aggression = -1;

		// Token: 0x04000B6A RID: 2922
		public static int career_playergrowthuserseason_acceleration = -1;

		// Token: 0x04000B6B RID: 2923
		public static int career_playergrowthuserseason_headingaccuracy = -1;

		// Token: 0x04000B6C RID: 2924
		public static int career_playergrowthuserseason_gkhandling = -1;

		// Token: 0x04000B6D RID: 2925
		public static int career_playergrowthuserseason_jumping = -1;

		// Token: 0x04000B6E RID: 2926
		public static int career_playergrowthuserseason_stamina = -1;

		// Token: 0x04000B6F RID: 2927
		public static int career_playergrowthuserseason_playerid = -1;

		// Token: 0x04000B70 RID: 2928
		public static int career_playergrowthuserseason_marking = -1;

		// Token: 0x04000B71 RID: 2929
		public static int career_playergrowthuserseason_gkpositioning = -1;

		// Token: 0x04000B72 RID: 2930
		public static int career_playergrowthuserseason_volleys = -1;

		// Token: 0x04000B73 RID: 2931
		public static int career_playergrowthupdates_notifygrowth = -1;

		// Token: 0x04000B74 RID: 2932
		public static int career_playergrowthupdates_playerid = -1;

		// Token: 0x04000B75 RID: 2933
		public static int career_playergrowthhistory_startingoverall = -1;

		// Token: 0x04000B76 RID: 2934
		public static int career_playergrowthhistory_startingage = -1;

		// Token: 0x04000B77 RID: 2935
		public static int career_playergrowthhistory_playerid = -1;

		// Token: 0x04000B78 RID: 2936
		public static int finalstadiums_leagueid = -1;

		// Token: 0x04000B79 RID: 2937
		public static int finalstadiums_final_stadium = -1;

		// Token: 0x04000B7A RID: 2938
		public static int tourn_team_manager_rt = -1;

		// Token: 0x04000B7B RID: 2939
		public static int tourn_team_manager_teamid = -1;

		// Token: 0x04000B7C RID: 2940
		public static int tourn_team_manager_outcome = -1;

		// Token: 0x04000B7D RID: 2941
		public static int tourn_team_manager_points = -1;

		// Token: 0x04000B7E RID: 2942
		public static int tourn_settings_setting_value = -1;

		// Token: 0x04000B7F RID: 2943
		public static int tourn_settings_setting_code = -1;

		// Token: 0x04000B80 RID: 2944
		public static int tourn_settings_setting_id = -1;

		// Token: 0x04000B81 RID: 2945
		public static int tourn_rtsg_rtsg = -1;

		// Token: 0x04000B82 RID: 2946
		public static int tourn_rtsg_tournid = -1;

		// Token: 0x04000B83 RID: 2947
		public static int tourn_manager_settings_mLastSimulatedUserFixture = -1;

		// Token: 0x04000B84 RID: 2948
		public static int tourn_manager_settings_setting_4 = -1;

		// Token: 0x04000B85 RID: 2949
		public static int tourn_manager_settings_setting_7 = -1;

		// Token: 0x04000B86 RID: 2950
		public static int tourn_manager_settings_TournamentName = -1;

		// Token: 0x04000B87 RID: 2951
		public static int tourn_manager_settings_setting_9 = -1;

		// Token: 0x04000B88 RID: 2952
		public static int tourn_manager_settings_setting_0 = -1;

		// Token: 0x04000B89 RID: 2953
		public static int tourn_manager_settings_setting_18 = -1;

		// Token: 0x04000B8A RID: 2954
		public static int tourn_manager_settings_setting_8 = -1;

		// Token: 0x04000B8B RID: 2955
		public static int tourn_manager_settings_setting_6 = -1;

		// Token: 0x04000B8C RID: 2956
		public static int tourn_manager_settings_setting_16 = -1;

		// Token: 0x04000B8D RID: 2957
		public static int tourn_manager_settings_setting_11 = -1;

		// Token: 0x04000B8E RID: 2958
		public static int tourn_manager_settings_setting_17 = -1;

		// Token: 0x04000B8F RID: 2959
		public static int tourn_manager_settings_setting_1 = -1;

		// Token: 0x04000B90 RID: 2960
		public static int tourn_manager_settings_setting_13 = -1;

		// Token: 0x04000B91 RID: 2961
		public static int tourn_manager_settings_setting_10 = -1;

		// Token: 0x04000B92 RID: 2962
		public static int tourn_manager_settings_setting_14 = -1;

		// Token: 0x04000B93 RID: 2963
		public static int tourn_manager_settings_setting_2 = -1;

		// Token: 0x04000B94 RID: 2964
		public static int tourn_manager_settings_setting_12 = -1;

		// Token: 0x04000B95 RID: 2965
		public static int tourn_manager_settings_setting_5 = -1;

		// Token: 0x04000B96 RID: 2966
		public static int tourn_manager_settings_setting_3 = -1;

		// Token: 0x04000B97 RID: 2967
		public static int tourn_manager_settings_setting_15 = -1;

		// Token: 0x04000B98 RID: 2968
		public static int tourn_manager_settings_NumTeamsInTournament = -1;

		// Token: 0x04000B99 RID: 2969
		public static int tourn_manager_settings_TournamentStarted = -1;

		// Token: 0x04000B9A RID: 2970
		public static int tourn_manager_settings_IsSimulating = -1;

		// Token: 0x04000B9B RID: 2971
		public static int tourn_manager_settings_setting_id = -1;

		// Token: 0x04000B9C RID: 2972
		public static int tourn_manager_settings_ActiveTournamentID = -1;

		// Token: 0x04000B9D RID: 2973
		public static int tourn_licensed_stages_lt_numlegs = -1;

		// Token: 0x04000B9E RID: 2974
		public static int tourn_licensed_stages_lt_league3 = -1;

		// Token: 0x04000B9F RID: 2975
		public static int tourn_licensed_stages_lt_stage_num = -1;

		// Token: 0x04000BA0 RID: 2976
		public static int tourn_licensed_stages_lt_id = -1;

		// Token: 0x04000BA1 RID: 2977
		public static int tourn_licensed_stages_lt_league2 = -1;

		// Token: 0x04000BA2 RID: 2978
		public static int tourn_licensed_stages_lt_league4 = -1;

		// Token: 0x04000BA3 RID: 2979
		public static int tourn_licensed_stages_lt_num_teams_in_stage = -1;

		// Token: 0x04000BA4 RID: 2980
		public static int tourn_licensed_stages_lt_league5 = -1;

		// Token: 0x04000BA5 RID: 2981
		public static int tourn_licensed_stages_lt_drawtype = -1;

		// Token: 0x04000BA6 RID: 2982
		public static int tourn_licensed_stages_lt_league6 = -1;

		// Token: 0x04000BA7 RID: 2983
		public static int tourn_licensed_stages_lt_league1 = -1;

		// Token: 0x04000BA8 RID: 2984
		public static int tourn_licensed_stages_lt_num_bye_teams = -1;

		// Token: 0x04000BA9 RID: 2985
		public static int tourn_licensed_lt_num_teams_to_advance = -1;

		// Token: 0x04000BAA RID: 2986
		public static int tourn_licensed_lt_id = -1;

		// Token: 0x04000BAB RID: 2987
		public static int tourn_licensed_lt_away_goal_rules = -1;

		// Token: 0x04000BAC RID: 2988
		public static int tourn_licensed_lt_num_stages = -1;

		// Token: 0x04000BAD RID: 2989
		public static int tourn_licensed_lt_yellow_card_rule = -1;

		// Token: 0x04000BAE RID: 2990
		public static int tourn_licensed_lt_num_unique_teams = -1;

		// Token: 0x04000BAF RID: 2991
		public static int tourn_licensed_lt_tourn_type = -1;

		// Token: 0x04000BB0 RID: 2992
		public static int tourn_licensed_lt_country = -1;

		// Token: 0x04000BB1 RID: 2993
		public static int tourn_licensed_lt_redcard_ban = -1;

		// Token: 0x04000BB2 RID: 2994
		public static int tourn_licensed_lt_num_teams_per_group = -1;

		// Token: 0x04000BB3 RID: 2995
		public static int tourn_licensed_lt_starting_subs = -1;

		// Token: 0x04000BB4 RID: 2996
		public static int tourn_licensed_lt_assetid = -1;

		// Token: 0x04000BB5 RID: 2997
		public static int tourn_licensed_lt_first_stage_is_KO = -1;

		// Token: 0x04000BB6 RID: 2998
		public static int specialteams_teamtype = -1;

		// Token: 0x04000BB7 RID: 2999
		public static int specialteams_originalteamid = -1;

		// Token: 0x04000BB8 RID: 3000
		public static int specialteams_teamid = -1;

		// Token: 0x04000BB9 RID: 3001
		public static int stadiumassignments_stadiumcustomname = -1;

		// Token: 0x04000BBA RID: 3002
		public static int stadiumassignments_teamid = -1;

		// Token: 0x04000BBB RID: 3003
		public static int factory_teams_assetid = -1;

		// Token: 0x04000BBC RID: 3004
		public static int factory_teams_balltype = -1;

		// Token: 0x04000BBD RID: 3005
		public static int factory_teams_teamcolor1g = -1;

		// Token: 0x04000BBE RID: 3006
		public static int factory_teams_teamcolor1r = -1;

		// Token: 0x04000BBF RID: 3007
		public static int factory_teams_teamcolor2b = -1;

		// Token: 0x04000BC0 RID: 3008
		public static int factory_teams_teamcolor2r = -1;

		// Token: 0x04000BC1 RID: 3009
		public static int factory_teams_teamcolor3r = -1;

		// Token: 0x04000BC2 RID: 3010
		public static int factory_teams_teamcolor1b = -1;

		// Token: 0x04000BC3 RID: 3011
		public static int factory_teams_latitude = -1;

		// Token: 0x04000BC4 RID: 3012
		public static int factory_teams_teamcolor3g = -1;

		// Token: 0x04000BC5 RID: 3013
		public static int factory_teams_teamcolor2g = -1;

		// Token: 0x04000BC6 RID: 3014
		public static int factory_teams_teamname = -1;

		// Token: 0x04000BC7 RID: 3015
		public static int factory_teams_adboardid = -1;

		// Token: 0x04000BC8 RID: 3016
		public static int factory_teams_teamcolor3b = -1;

		// Token: 0x04000BC9 RID: 3017
		public static int factory_teams_defmentality = -1;

		// Token: 0x04000BCA RID: 3018
		public static int factory_teams_powid = -1;

		// Token: 0x04000BCB RID: 3019
		public static int factory_teams_physioid_secondary = -1;

		// Token: 0x04000BCC RID: 3020
		public static int factory_teams_domesticprestige = -1;

		// Token: 0x04000BCD RID: 3021
		public static int factory_teams_genericint2 = -1;

		// Token: 0x04000BCE RID: 3022
		public static int factory_teams_jerseytype = -1;

		// Token: 0x04000BCF RID: 3023
		public static int factory_teams_rivalteam = -1;

		// Token: 0x04000BD0 RID: 3024
		public static int factory_teams_midfieldrating = -1;

		// Token: 0x04000BD1 RID: 3025
		public static int factory_teams_matchdayoverallrating = -1;

		// Token: 0x04000BD2 RID: 3026
		public static int factory_teams_matchdaymidfieldrating = -1;

		// Token: 0x04000BD3 RID: 3027
		public static int factory_teams_attackrating = -1;

		// Token: 0x04000BD4 RID: 3028
		public static int factory_teams_physioid_primary = -1;

		// Token: 0x04000BD5 RID: 3029
		public static int factory_teams_longitude = -1;

		// Token: 0x04000BD6 RID: 3030
		public static int factory_teams_buspassing = -1;

		// Token: 0x04000BD7 RID: 3031
		public static int factory_teams_matchdaydefenserating = -1;

		// Token: 0x04000BD8 RID: 3032
		public static int factory_teams_defenserating = -1;

		// Token: 0x04000BD9 RID: 3033
		public static int factory_teams_defteamwidth = -1;

		// Token: 0x04000BDA RID: 3034
		public static int factory_teams_longkicktakerid = -1;

		// Token: 0x04000BDB RID: 3035
		public static int factory_teams_bodytypeid = -1;

		// Token: 0x04000BDC RID: 3036
		public static int factory_teams_rightcornerkicktakerid = -1;

		// Token: 0x04000BDD RID: 3037
		public static int factory_teams_suitvariationid = -1;

		// Token: 0x04000BDE RID: 3038
		public static int factory_teams_defaggression = -1;

		// Token: 0x04000BDF RID: 3039
		public static int factory_teams_ethnicity = -1;

		// Token: 0x04000BE0 RID: 3040
		public static int factory_teams_leftcornerkicktakerid = -1;

		// Token: 0x04000BE1 RID: 3041
		public static int factory_teams_teamid = -1;

		// Token: 0x04000BE2 RID: 3042
		public static int factory_teams_fancrowdhairskintexturecode = -1;

		// Token: 0x04000BE3 RID: 3043
		public static int factory_teams_suittypeid = -1;

		// Token: 0x04000BE4 RID: 3044
		public static int factory_teams_numtransfersin = -1;

		// Token: 0x04000BE5 RID: 3045
		public static int factory_teams_captainid = -1;

		// Token: 0x04000BE6 RID: 3046
		public static int factory_teams_personalityid = -1;

		// Token: 0x04000BE7 RID: 3047
		public static int factory_teams_genericbanner = -1;

		// Token: 0x04000BE8 RID: 3048
		public static int factory_teams_buspositioning = -1;

		// Token: 0x04000BE9 RID: 3049
		public static int factory_teams_stafftracksuitcolorcode = -1;

		// Token: 0x04000BEA RID: 3050
		public static int factory_teams_ccpositioning = -1;

		// Token: 0x04000BEB RID: 3051
		public static int factory_teams_busbuildupspeed = -1;

		// Token: 0x04000BEC RID: 3052
		public static int factory_teams_transferbudget = -1;

		// Token: 0x04000BED RID: 3053
		public static int factory_teams_ccshooting = -1;

		// Token: 0x04000BEE RID: 3054
		public static int factory_teams_overallrating = -1;

		// Token: 0x04000BEF RID: 3055
		public static int factory_teams_ccpassing = -1;

		// Token: 0x04000BF0 RID: 3056
		public static int factory_teams_utcoffset = -1;

		// Token: 0x04000BF1 RID: 3057
		public static int factory_teams_penaltytakerid = -1;

		// Token: 0x04000BF2 RID: 3058
		public static int factory_teams_freekicktakerid = -1;

		// Token: 0x04000BF3 RID: 3059
		public static int factory_teams_defdefenderline = -1;

		// Token: 0x04000BF4 RID: 3060
		public static int factory_teams_internationalprestige = -1;

		// Token: 0x04000BF5 RID: 3061
		public static int factory_teams_form = -1;

		// Token: 0x04000BF6 RID: 3062
		public static int factory_teams_genericint1 = -1;

		// Token: 0x04000BF7 RID: 3063
		public static int factory_teams_cccrossing = -1;

		// Token: 0x04000BF8 RID: 3064
		public static int factory_teams_matchdayattackrating = -1;

		// Token: 0x04000BF9 RID: 3065
		public static int temp_createplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000BFA RID: 3066
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x04000BFB RID: 3067
		public static int temp_createplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x04000BFC RID: 3068
		public static int temp_createplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x04000BFD RID: 3069
		public static int temp_createplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x04000BFE RID: 3070
		public static int temp_createplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x04000BFF RID: 3071
		public static int temp_createplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x04000C00 RID: 3072
		public static int temp_createplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000C01 RID: 3073
		public static int temp_createplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000C02 RID: 3074
		public static int temp_createplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000C03 RID: 3075
		public static int temp_createplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000C04 RID: 3076
		public static int temp_createplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000C05 RID: 3077
		public static int temp_createplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000C06 RID: 3078
		public static int temp_createplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000C07 RID: 3079
		public static int temp_createplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000C08 RID: 3080
		public static int temp_createplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000C09 RID: 3081
		public static int temp_createplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x04000C0A RID: 3082
		public static int temp_createplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x04000C0B RID: 3083
		public static int temp_createplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x04000C0C RID: 3084
		public static int temp_createplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x04000C0D RID: 3085
		public static int temp_createplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x04000C0E RID: 3086
		public static int temp_createplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x04000C0F RID: 3087
		public static int temp_createplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000C10 RID: 3088
		public static int temp_createplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000C11 RID: 3089
		public static int temp_createplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000C12 RID: 3090
		public static int temp_createplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000C13 RID: 3091
		public static int temp_createplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000C14 RID: 3092
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000C15 RID: 3093
		public static int temp_createplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000C16 RID: 3094
		public static int temp_createplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000C17 RID: 3095
		public static int temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000C18 RID: 3096
		public static int temp_createplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000C19 RID: 3097
		public static int temp_createplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x04000C1A RID: 3098
		public static int temp_createplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x04000C1B RID: 3099
		public static int temp_createplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x04000C1C RID: 3100
		public static int temp_createplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x04000C1D RID: 3101
		public static int temp_createplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x04000C1E RID: 3102
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000C1F RID: 3103
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000C20 RID: 3104
		public static int temp_createplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000C21 RID: 3105
		public static int temp_createplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000C22 RID: 3106
		public static int temp_createplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000C23 RID: 3107
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000C24 RID: 3108
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000C25 RID: 3109
		public static int temp_createplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000C26 RID: 3110
		public static int temp_createplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000C27 RID: 3111
		public static int temp_createplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000C28 RID: 3112
		public static int temp_createplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x04000C29 RID: 3113
		public static int temp_createplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x04000C2A RID: 3114
		public static int temp_createplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x04000C2B RID: 3115
		public static int temp_createplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x04000C2C RID: 3116
		public static int temp_createplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x04000C2D RID: 3117
		public static int temp_createplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x04000C2E RID: 3118
		public static int temp_createplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000C2F RID: 3119
		public static int temp_createplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000C30 RID: 3120
		public static int temp_createplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000C31 RID: 3121
		public static int temp_createplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000C32 RID: 3122
		public static int temp_createplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000C33 RID: 3123
		public static int temp_createplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000C34 RID: 3124
		public static int temp_createplayer_create_originalplayerid = -1;

		// Token: 0x04000C35 RID: 3125
		public static int temp_createplayer_create_playerid = -1;

		// Token: 0x04000C36 RID: 3126
		public static int temp_createplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000C37 RID: 3127
		public static int temp_createplayer_cpattributename_hair_style = -1;

		// Token: 0x04000C38 RID: 3128
		public static int temp_createplayer_celebrationid = -1;

		// Token: 0x04000C39 RID: 3129
		public static int temp_createplayer_cpattributename_brow_style = -1;

		// Token: 0x04000C3A RID: 3130
		public static int temp_createplayer_cpattributename_eye_colour = -1;

		// Token: 0x04000C3B RID: 3131
		public static int temp_createplayer_create_artificialkey = -1;

		// Token: 0x04000C3C RID: 3132
		public static int temp_createplayer_commentaryid = -1;

		// Token: 0x04000C3D RID: 3133
		public static int temp_createplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x04000C3E RID: 3134
		public static int temp_createplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000C3F RID: 3135
		public static int temp_createplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000C40 RID: 3136
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_protrusion_lsx = -1;

		// Token: 0x04000C41 RID: 3137
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_folds_lsy = -1;

		// Token: 0x04000C42 RID: 3138
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_protrusion_rsx = -1;

		// Token: 0x04000C43 RID: 3139
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrildetail_height_lsy = -1;

		// Token: 0x04000C44 RID: 3140
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_protrusion_rsx = -1;

		// Token: 0x04000C45 RID: 3141
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_tilt_lsy = -1;

		// Token: 0x04000C46 RID: 3142
		public static int temp_arenacreateplayer_cpmorphcomposite_earplacement_height_lsy = -1;

		// Token: 0x04000C47 RID: 3143
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekplacement_position_lsy = -1;

		// Token: 0x04000C48 RID: 3144
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_shape_rsx = -1;

		// Token: 0x04000C49 RID: 3145
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_shape_lsx = -1;

		// Token: 0x04000C4A RID: 3146
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_height_lsy = -1;

		// Token: 0x04000C4B RID: 3147
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_bite_rsy = -1;

		// Token: 0x04000C4C RID: 3148
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekstyle_blemishes_rsx = -1;

		// Token: 0x04000C4D RID: 3149
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrils_height_lsy = -1;

		// Token: 0x04000C4E RID: 3150
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthblemishes_lsx = -1;

		// Token: 0x04000C4F RID: 3151
		public static int temp_arenacreateplayer_cpmorphcomposite_earstyle_lobe_lsx = -1;

		// Token: 0x04000C50 RID: 3152
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_width_lsx = -1;

		// Token: 0x04000C51 RID: 3153
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_tilt_rsy = -1;

		// Token: 0x04000C52 RID: 3154
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipshape_rsy = -1;

		// Token: 0x04000C53 RID: 3155
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_thickness_rsy = -1;

		// Token: 0x04000C54 RID: 3156
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_lsy = -1;

		// Token: 0x04000C55 RID: 3157
		public static int temp_arenacreateplayer_cpmorphcomposite_eyeshape_seperation_lsx = -1;

		// Token: 0x04000C56 RID: 3158
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_tipprotrusion_rsx = -1;

		// Token: 0x04000C57 RID: 3159
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekplacement_width_lsx = -1;

		// Token: 0x04000C58 RID: 3160
		public static int temp_arenacreateplayer_cpmorphcomposite_laughlinedarkness_lsx = -1;

		// Token: 0x04000C59 RID: 3161
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_position_lsy = -1;

		// Token: 0x04000C5A RID: 3162
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_protrusion_rsx = -1;

		// Token: 0x04000C5B RID: 3163
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_lowerlid_lsx = -1;

		// Token: 0x04000C5C RID: 3164
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_upperlip_thickness_lsy = -1;

		// Token: 0x04000C5D RID: 3165
		public static int temp_arenacreateplayer_cpmorphcomposite_noseprofile_shape_lsy = -1;

		// Token: 0x04000C5E RID: 3166
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsy = -1;

		// Token: 0x04000C5F RID: 3167
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_width_lsx = -1;

		// Token: 0x04000C60 RID: 3168
		public static int temp_arenacreateplayer_cpmorphcomposite_nosestyle_nosestyle_lsx = -1;

		// Token: 0x04000C61 RID: 3169
		public static int temp_arenacreateplayer_cpmorphcomposite_mouthposition_position_lsy = -1;

		// Token: 0x04000C62 RID: 3170
		public static int temp_arenacreateplayer_cpmorphcomposite_earplacement_protrusion_lsx = -1;

		// Token: 0x04000C63 RID: 3171
		public static int temp_arenacreateplayer_cpmorphcomposite_dimpledarkness_lsx = -1;

		// Token: 0x04000C64 RID: 3172
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_rsx = -1;

		// Token: 0x04000C65 RID: 3173
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_protrusion_rsy = -1;

		// Token: 0x04000C66 RID: 3174
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_lipdimple_rsx = -1;

		// Token: 0x04000C67 RID: 3175
		public static int temp_arenacreateplayer_cpmorphcomposite_lips_lowerlip_thickness_rsx = -1;

		// Token: 0x04000C68 RID: 3176
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_position_lsy = -1;

		// Token: 0x04000C69 RID: 3177
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_postion_lsy = -1;

		// Token: 0x04000C6A RID: 3178
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_updown_lsy = -1;

		// Token: 0x04000C6B RID: 3179
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_protrusion_rsx = -1;

		// Token: 0x04000C6C RID: 3180
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_seperation_lsx = -1;

		// Token: 0x04000C6D RID: 3181
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_bulk_rsx = -1;

		// Token: 0x04000C6E RID: 3182
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_width_lsx = -1;

		// Token: 0x04000C6F RID: 3183
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail1_symmetry_lsx = -1;

		// Token: 0x04000C70 RID: 3184
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrils_width_lsx = -1;

		// Token: 0x04000C71 RID: 3185
		public static int temp_arenacreateplayer_cpmorphcomposite_eyedetail2_upperlid_lsy = -1;

		// Token: 0x04000C72 RID: 3186
		public static int temp_arenacreateplayer_cpmorphcomposite_lipstyle_corners_leftright_lsx = -1;

		// Token: 0x04000C73 RID: 3187
		public static int temp_arenacreateplayer_cpmorphcomposite_browplacement_tilt_lsx = -1;

		// Token: 0x04000C74 RID: 3188
		public static int temp_arenacreateplayer_cpmorphcomposite_jaw_width_lsx = -1;

		// Token: 0x04000C75 RID: 3189
		public static int temp_arenacreateplayer_cpmorphcomposite_browshape_thickness_rsy = -1;

		// Token: 0x04000C76 RID: 3190
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_protrusion_rsx = -1;

		// Token: 0x04000C77 RID: 3191
		public static int temp_arenacreateplayer_cpmorphcomposite_noseplacement_position_rsy = -1;

		// Token: 0x04000C78 RID: 3192
		public static int temp_arenacreateplayer_cpmorphcomposite_nostrildetail_width_lsx = -1;

		// Token: 0x04000C79 RID: 3193
		public static int temp_arenacreateplayer_cpmorphcomposite_cheekstyle_style_lsx = -1;

		// Token: 0x04000C7A RID: 3194
		public static int temp_arenacreateplayer_cpmorhpcomposite_chin_deatil_rsy = -1;

		// Token: 0x04000C7B RID: 3195
		public static int temp_arenacreateplayer_create_originalplayerid = -1;

		// Token: 0x04000C7C RID: 3196
		public static int temp_arenacreateplayer_create_playerid = -1;

		// Token: 0x04000C7D RID: 3197
		public static int temp_arenacreateplayer_cpattributename_hair_colour = -1;

		// Token: 0x04000C7E RID: 3198
		public static int temp_arenacreateplayer_cpattributename_hair_style = -1;

		// Token: 0x04000C7F RID: 3199
		public static int temp_arenacreateplayer_celebrationid = -1;

		// Token: 0x04000C80 RID: 3200
		public static int temp_arenacreateplayer_cpattributename_brow_style = -1;

		// Token: 0x04000C81 RID: 3201
		public static int temp_arenacreateplayer_cpattributename_eye_colour = -1;

		// Token: 0x04000C82 RID: 3202
		public static int temp_arenacreateplayer_create_artificialkey = -1;

		// Token: 0x04000C83 RID: 3203
		public static int temp_arenacreateplayer_commentaryid = -1;

		// Token: 0x04000C84 RID: 3204
		public static int temp_arenacreateplayer_cpattributename_facial_hair_style = -1;

		// Token: 0x04000C85 RID: 3205
		public static int temp_arenacreateplayer_cpattributename_brow_colour = -1;

		// Token: 0x04000C86 RID: 3206
		public static int temp_arenacreateplayer_cpattributename_facial_hair_colour = -1;

		// Token: 0x04000C87 RID: 3207
		public static int career_blacklist_permanent = -1;

		// Token: 0x04000C88 RID: 3208
		public static int career_blacklist_playerid = -1;

		// Token: 0x04000C89 RID: 3209
		public static int career_transferoffer_startdate = -1;

		// Token: 0x04000C8A RID: 3210
		public static int career_transferoffer_date = -1;

		// Token: 0x04000C8B RID: 3211
		public static int career_transferoffer_offerteamid = -1;

		// Token: 0x04000C8C RID: 3212
		public static int career_transferoffer_approachreason = -1;

		// Token: 0x04000C8D RID: 3213
		public static int career_transferoffer_offerid = -1;

		// Token: 0x04000C8E RID: 3214
		public static int career_transferoffer_stage = -1;

		// Token: 0x04000C8F RID: 3215
		public static int career_transferoffer_isCPUTransfer = -1;

		// Token: 0x04000C90 RID: 3216
		public static int career_transferoffer_exchangeplayerid = -1;

		// Token: 0x04000C91 RID: 3217
		public static int career_transferoffer_offeredfee = -1;

		// Token: 0x04000C92 RID: 3218
		public static int career_transferoffer_counteroffers = -1;

		// Token: 0x04000C93 RID: 3219
		public static int career_transferoffer_offeredwage = -1;

		// Token: 0x04000C94 RID: 3220
		public static int career_transferoffer_currentcontractlength = -1;

		// Token: 0x04000C95 RID: 3221
		public static int career_transferoffer_result = -1;

		// Token: 0x04000C96 RID: 3222
		public static int career_transferoffer_desiredFee = -1;

		// Token: 0x04000C97 RID: 3223
		public static int career_transferoffer_isloanbuy = -1;

		// Token: 0x04000C98 RID: 3224
		public static int career_transferoffer_teamid = -1;

		// Token: 0x04000C99 RID: 3225
		public static int career_transferoffer_offeredcontracttype = -1;

		// Token: 0x04000C9A RID: 3226
		public static int career_transferoffer_valuation = -1;

		// Token: 0x04000C9B RID: 3227
		public static int career_transferoffer_snipedteamid = -1;

		// Token: 0x04000C9C RID: 3228
		public static int career_transferoffer_playerid = -1;

		// Token: 0x04000C9D RID: 3229
		public static int career_transferoffer_squadrole = -1;

		// Token: 0x04000C9E RID: 3230
		public static int career_transferoffer_issnipe = -1;

		// Token: 0x04000C9F RID: 3231
		public static int career_transferoffer_transferwindow = -1;

		// Token: 0x04000CA0 RID: 3232
		public static int career_transferoffer_isloan = -1;

		// Token: 0x04000CA1 RID: 3233
		public static int career_transferoffer_offeredbonus = -1;

		// Token: 0x04000CA2 RID: 3234
		public static int career_transferlist_leagueid = -1;

		// Token: 0x04000CA3 RID: 3235
		public static int career_transferlist_preferredposition1 = -1;

		// Token: 0x04000CA4 RID: 3236
		public static int career_transferlist_pitcharea = -1;

		// Token: 0x04000CA5 RID: 3237
		public static int career_transferlist_teamid = -1;

		// Token: 0x04000CA6 RID: 3238
		public static int career_transferlist_playerid = -1;

		// Token: 0x04000CA7 RID: 3239
		public static int career_transferlist_overallrating = -1;

		// Token: 0x04000CA8 RID: 3240
		public static int career_transferlist_potentialtype = -1;

		// Token: 0x04000CA9 RID: 3241
		public static int career_playercontract_offered_wage = -1;

		// Token: 0x04000CAA RID: 3242
		public static int career_playercontract_salary_demand = -1;

		// Token: 0x04000CAB RID: 3243
		public static int career_playercontract_offered_bonus = -1;

		// Token: 0x04000CAC RID: 3244
		public static int career_playercontract_contract_status = -1;

		// Token: 0x04000CAD RID: 3245
		public static int career_playercontract_contract_status_change_date = -1;

		// Token: 0x04000CAE RID: 3246
		public static int career_playercontract_wage = -1;

		// Token: 0x04000CAF RID: 3247
		public static int career_playercontract_extension_years = -1;

		// Token: 0x04000CB0 RID: 3248
		public static int career_playercontract_teamid = -1;

		// Token: 0x04000CB1 RID: 3249
		public static int career_playercontract_negotiation_status = -1;

		// Token: 0x04000CB2 RID: 3250
		public static int career_playercontract_bonus = -1;

		// Token: 0x04000CB3 RID: 3251
		public static int career_playercontract_negotiation_date = -1;

		// Token: 0x04000CB4 RID: 3252
		public static int career_playercontract_playerid = -1;

		// Token: 0x04000CB5 RID: 3253
		public static int career_loanbuy_future_fee = -1;

		// Token: 0x04000CB6 RID: 3254
		public static int career_loanbuy_stage = -1;

		// Token: 0x04000CB7 RID: 3255
		public static int career_loanbuy_playerid = -1;

		// Token: 0x04000CB8 RID: 3256
		public static int achievements_orderAchieved = -1;

		// Token: 0x04000CB9 RID: 3257
		public static int achievements_isDisplayed = -1;

		// Token: 0x04000CBA RID: 3258
		public static int achievements_achievementID = -1;

		// Token: 0x04000CBB RID: 3259
		public static int achievements_isAchieved = -1;

		// Token: 0x04000CBC RID: 3260
		public static int fifaUnlockables_AccompString = -1;

		// Token: 0x04000CBD RID: 3261
		public static int fifaUnlockables_TournString = -1;

		// Token: 0x04000CBE RID: 3262
		public static int fifaUnlockables_TeamString = -1;

		// Token: 0x04000CBF RID: 3263
		public static int fifaUnlockables_UnlockableString = -1;

		// Token: 0x04000CC0 RID: 3264
		public static int fifaUnlockables_ItemId = -1;

		// Token: 0x04000CC1 RID: 3265
		public static int fifaUnlockables_ItemType = -1;

		// Token: 0x04000CC2 RID: 3266
		public static int fifaUnlockables_AssetId = -1;

		// Token: 0x04000CC3 RID: 3267
		public static int fifaUnlockables_KOTeams = -1;

		// Token: 0x04000CC4 RID: 3268
		public static int fifaUnlockables_UnlockableID = -1;

		// Token: 0x04000CC5 RID: 3269
		public static int fifaUnlockables_Price = -1;

		// Token: 0x04000CC6 RID: 3270
		public static int fifaUnlockables_Locked = -1;

		// Token: 0x04000CC7 RID: 3271
		public static int usability_title = -1;

		// Token: 0x04000CC8 RID: 3272
		public static int usability_body_text = -1;

		// Token: 0x04000CC9 RID: 3273
		public static int usability_usability_id = -1;

		// Token: 0x04000CCA RID: 3274
		public static int usability_button_3 = -1;

		// Token: 0x04000CCB RID: 3275
		public static int usability_button_4 = -1;

		// Token: 0x04000CCC RID: 3276
		public static int usability_button_1 = -1;

		// Token: 0x04000CCD RID: 3277
		public static int usability_difficulty = -1;

		// Token: 0x04000CCE RID: 3278
		public static int usability_button_2 = -1;

		// Token: 0x04000CCF RID: 3279
		public static int usability_type = -1;

		// Token: 0x04000CD0 RID: 3280
		public static int usability_functions_funct_text = -1;

		// Token: 0x04000CD1 RID: 3281
		public static int usability_functions_action_cnt = -1;

		// Token: 0x04000CD2 RID: 3282
		public static int usability_functions_button_id = -1;

		// Token: 0x04000CD3 RID: 3283
		public static int usability_functions_arrow = -1;

		// Token: 0x04000CD4 RID: 3284
		public static int usability_functions_funct = -1;

		// Token: 0x04000CD5 RID: 3285
		public static int virtualleagues_name = -1;

		// Token: 0x04000CD6 RID: 3286
		public static int virtualleagues_id = -1;

		// Token: 0x04000CD7 RID: 3287
		public static int virtualleagues_dbleagueid = -1;

		// Token: 0x04000CD8 RID: 3288
		public static int career_namesgroups_nationality = -1;

		// Token: 0x04000CD9 RID: 3289
		public static int career_namesgroups_groupid = -1;

		// Token: 0x04000CDA RID: 3290
		public static int career_youthplayers_playertier = -1;

		// Token: 0x04000CDB RID: 3291
		public static int career_youthplayers_playertype = -1;

		// Token: 0x04000CDC RID: 3292
		public static int career_youthplayers_swinglowpotential = -1;

		// Token: 0x04000CDD RID: 3293
		public static int career_youthplayers_potentialvariance = -1;

		// Token: 0x04000CDE RID: 3294
		public static int career_youthplayers_playerid = -1;

		// Token: 0x04000CDF RID: 3295
		public static int career_youthplayers_monthsinsquad = -1;

		// Token: 0x04000CE0 RID: 3296
		public static int career_youthplayerhistory_goals = -1;

		// Token: 0x04000CE1 RID: 3297
		public static int career_youthplayerhistory_appearances = -1;

		// Token: 0x04000CE2 RID: 3298
		public static int career_youthplayerhistory_playerid = -1;

		// Token: 0x04000CE3 RID: 3299
		public static int career_youthplayerattributes_playertier = -1;

		// Token: 0x04000CE4 RID: 3300
		public static int career_youthplayerattributes_curve = -1;

		// Token: 0x04000CE5 RID: 3301
		public static int career_youthplayerattributes_agility = -1;

		// Token: 0x04000CE6 RID: 3302
		public static int career_youthplayerattributes_positioning = -1;

		// Token: 0x04000CE7 RID: 3303
		public static int career_youthplayerattributes_playertype = -1;

		// Token: 0x04000CE8 RID: 3304
		public static int career_youthplayerattributes_standingtackle = -1;

		// Token: 0x04000CE9 RID: 3305
		public static int career_youthplayerattributes_longpassing = -1;

		// Token: 0x04000CEA RID: 3306
		public static int career_youthplayerattributes_penalties = -1;

		// Token: 0x04000CEB RID: 3307
		public static int career_youthplayerattributes_longshots = -1;

		// Token: 0x04000CEC RID: 3308
		public static int career_youthplayerattributes_gkdiving = -1;

		// Token: 0x04000CED RID: 3309
		public static int career_youthplayerattributes_interceptions = -1;

		// Token: 0x04000CEE RID: 3310
		public static int career_youthplayerattributes_crossing = -1;

		// Token: 0x04000CEF RID: 3311
		public static int career_youthplayerattributes_potential = -1;

		// Token: 0x04000CF0 RID: 3312
		public static int career_youthplayerattributes_gkreflexes = -1;

		// Token: 0x04000CF1 RID: 3313
		public static int career_youthplayerattributes_reactions = -1;

		// Token: 0x04000CF2 RID: 3314
		public static int career_youthplayerattributes_vision = -1;

		// Token: 0x04000CF3 RID: 3315
		public static int career_youthplayerattributes_finishing = -1;

		// Token: 0x04000CF4 RID: 3316
		public static int career_youthplayerattributes_dribbling = -1;

		// Token: 0x04000CF5 RID: 3317
		public static int career_youthplayerattributes_slidingtackle = -1;

		// Token: 0x04000CF6 RID: 3318
		public static int career_youthplayerattributes_sprintspeed = -1;

		// Token: 0x04000CF7 RID: 3319
		public static int career_youthplayerattributes_age = -1;

		// Token: 0x04000CF8 RID: 3320
		public static int career_youthplayerattributes_strength = -1;

		// Token: 0x04000CF9 RID: 3321
		public static int career_youthplayerattributes_ballcontrol = -1;

		// Token: 0x04000CFA RID: 3322
		public static int career_youthplayerattributes_shotpower = -1;

		// Token: 0x04000CFB RID: 3323
		public static int career_youthplayerattributes_balance = -1;

		// Token: 0x04000CFC RID: 3324
		public static int career_youthplayerattributes_gkkicking = -1;

		// Token: 0x04000CFD RID: 3325
		public static int career_youthplayerattributes_shortpassing = -1;

		// Token: 0x04000CFE RID: 3326
		public static int career_youthplayerattributes_freekickaccuracy = -1;

		// Token: 0x04000CFF RID: 3327
		public static int career_youthplayerattributes_aggression = -1;

		// Token: 0x04000D00 RID: 3328
		public static int career_youthplayerattributes_acceleration = -1;

		// Token: 0x04000D01 RID: 3329
		public static int career_youthplayerattributes_headingaccuracy = -1;

		// Token: 0x04000D02 RID: 3330
		public static int career_youthplayerattributes_gkhandling = -1;

		// Token: 0x04000D03 RID: 3331
		public static int career_youthplayerattributes_jumping = -1;

		// Token: 0x04000D04 RID: 3332
		public static int career_youthplayerattributes_stamina = -1;

		// Token: 0x04000D05 RID: 3333
		public static int career_youthplayerattributes_marking = -1;

		// Token: 0x04000D06 RID: 3334
		public static int career_youthplayerattributes_gkpositioning = -1;

		// Token: 0x04000D07 RID: 3335
		public static int career_youthplayerattributes_volleys = -1;

		// Token: 0x04000D08 RID: 3336
		public static int career_scouts_firstname = -1;

		// Token: 0x04000D09 RID: 3337
		public static int career_scouts_lastname = -1;

		// Token: 0x04000D0A RID: 3338
		public static int career_scouts_regionid = -1;

		// Token: 0x04000D0B RID: 3339
		public static int career_scouts_state = -1;

		// Token: 0x04000D0C RID: 3340
		public static int career_scouts_knowledge = -1;

		// Token: 0x04000D0D RID: 3341
		public static int career_scouts_nationality = -1;

		// Token: 0x04000D0E RID: 3342
		public static int career_scouts_scoutid = -1;

		// Token: 0x04000D0F RID: 3343
		public static int career_scouts_experience = -1;

		// Token: 0x04000D10 RID: 3344
		public static int career_scoutmission_playertype = -1;

		// Token: 0x04000D11 RID: 3345
		public static int career_scoutmission_durationid = -1;

		// Token: 0x04000D12 RID: 3346
		public static int career_scoutmission_returningdate = -1;

		// Token: 0x04000D13 RID: 3347
		public static int career_scoutmission_nationality = -1;

		// Token: 0x04000D14 RID: 3348
		public static int career_scoutmission_scoutid = -1;

		// Token: 0x04000D15 RID: 3349
		public static int career_regenplayerattributes_curve = -1;

		// Token: 0x04000D16 RID: 3350
		public static int career_regenplayerattributes_agility = -1;

		// Token: 0x04000D17 RID: 3351
		public static int career_regenplayerattributes_positioning = -1;

		// Token: 0x04000D18 RID: 3352
		public static int career_regenplayerattributes_standingtackle = -1;

		// Token: 0x04000D19 RID: 3353
		public static int career_regenplayerattributes_longpassing = -1;

		// Token: 0x04000D1A RID: 3354
		public static int career_regenplayerattributes_penalties = -1;

		// Token: 0x04000D1B RID: 3355
		public static int career_regenplayerattributes_longshots = -1;

		// Token: 0x04000D1C RID: 3356
		public static int career_regenplayerattributes_gkdiving = -1;

		// Token: 0x04000D1D RID: 3357
		public static int career_regenplayerattributes_interceptions = -1;

		// Token: 0x04000D1E RID: 3358
		public static int career_regenplayerattributes_crossing = -1;

		// Token: 0x04000D1F RID: 3359
		public static int career_regenplayerattributes_gkreflexes = -1;

		// Token: 0x04000D20 RID: 3360
		public static int career_regenplayerattributes_reactions = -1;

		// Token: 0x04000D21 RID: 3361
		public static int career_regenplayerattributes_vision = -1;

		// Token: 0x04000D22 RID: 3362
		public static int career_regenplayerattributes_finishing = -1;

		// Token: 0x04000D23 RID: 3363
		public static int career_regenplayerattributes_dribbling = -1;

		// Token: 0x04000D24 RID: 3364
		public static int career_regenplayerattributes_slidingtackle = -1;

		// Token: 0x04000D25 RID: 3365
		public static int career_regenplayerattributes_sprintspeed = -1;

		// Token: 0x04000D26 RID: 3366
		public static int career_regenplayerattributes_age = -1;

		// Token: 0x04000D27 RID: 3367
		public static int career_regenplayerattributes_strength = -1;

		// Token: 0x04000D28 RID: 3368
		public static int career_regenplayerattributes_ballcontrol = -1;

		// Token: 0x04000D29 RID: 3369
		public static int career_regenplayerattributes_shotpower = -1;

		// Token: 0x04000D2A RID: 3370
		public static int career_regenplayerattributes_overall = -1;

		// Token: 0x04000D2B RID: 3371
		public static int career_regenplayerattributes_balance = -1;

		// Token: 0x04000D2C RID: 3372
		public static int career_regenplayerattributes_gkkicking = -1;

		// Token: 0x04000D2D RID: 3373
		public static int career_regenplayerattributes_shortpassing = -1;

		// Token: 0x04000D2E RID: 3374
		public static int career_regenplayerattributes_freekickaccuracy = -1;

		// Token: 0x04000D2F RID: 3375
		public static int career_regenplayerattributes_aggression = -1;

		// Token: 0x04000D30 RID: 3376
		public static int career_regenplayerattributes_acceleration = -1;

		// Token: 0x04000D31 RID: 3377
		public static int career_regenplayerattributes_headingaccuracy = -1;

		// Token: 0x04000D32 RID: 3378
		public static int career_regenplayerattributes_gkhandling = -1;

		// Token: 0x04000D33 RID: 3379
		public static int career_regenplayerattributes_jumping = -1;

		// Token: 0x04000D34 RID: 3380
		public static int career_regenplayerattributes_stamina = -1;

		// Token: 0x04000D35 RID: 3381
		public static int career_regenplayerattributes_marking = -1;

		// Token: 0x04000D36 RID: 3382
		public static int career_regenplayerattributes_gkpositioning = -1;

		// Token: 0x04000D37 RID: 3383
		public static int career_regenplayerattributes_playerposgroup = -1;

		// Token: 0x04000D38 RID: 3384
		public static int career_regenplayerattributes_volleys = -1;
	}
}
