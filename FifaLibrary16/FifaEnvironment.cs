using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000035 RID: 53
	public class FifaEnvironment
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00019DB2 File Offset: 0x00017FB2
		public static FifaFat FifaFat
		{
			get
			{
				return FifaEnvironment.m_FifaFat;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00019DB9 File Offset: 0x00017FB9
		public static CareerFile CareerFile
		{
			get
			{
				return FifaEnvironment.m_CareerFile;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00019DC0 File Offset: 0x00017FC0
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00019DC7 File Offset: 0x00017FC7
		public static string CareerFileName
		{
			get
			{
				return FifaEnvironment.m_CareerFileName;
			}
			set
			{
				FifaEnvironment.m_CareerFileName = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00019DCF File Offset: 0x00017FCF
		public static CareerFile TournamentFile
		{
			get
			{
				return FifaEnvironment.m_TournamentFile;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00019DD6 File Offset: 0x00017FD6
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00019DDD File Offset: 0x00017FDD
		public static string TournamentFileName
		{
			get
			{
				return FifaEnvironment.m_TournamentFileName;
			}
			set
			{
				FifaEnvironment.m_TournamentFileName = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00019DE5 File Offset: 0x00017FE5
		public static CareerFile MyTeamsFile
		{
			get
			{
				return FifaEnvironment.m_MyTeamsFile;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00019DEC File Offset: 0x00017FEC
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00019DF3 File Offset: 0x00017FF3
		public static string MyTeamsFileName
		{
			get
			{
				return FifaEnvironment.m_MyTeamsFileName;
			}
			set
			{
				FifaEnvironment.m_MyTeamsFileName = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00019DFB File Offset: 0x00017FFB
		public static DbFile OriginalFifaDb
		{
			get
			{
				return FifaEnvironment.m_OriginalFifaDb;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00019E02 File Offset: 0x00018002
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00019E09 File Offset: 0x00018009
		public static bool IsRevModInstalled
		{
			get
			{
				return FifaEnvironment.m_IsRevModInstalled;
			}
			set
			{
				FifaEnvironment.m_IsRevModInstalled = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00019E11 File Offset: 0x00018011
		public static DbFile FifaDb
		{
			get
			{
				return FifaEnvironment.m_FifaDb;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00019E18 File Offset: 0x00018018
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00019E1F File Offset: 0x0001801F
		public static string FifaDbFileName
		{
			get
			{
				return FifaEnvironment.m_FifaDbFileName;
			}
			set
			{
				FifaEnvironment.m_FifaDbFileName = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00019E27 File Offset: 0x00018027
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00019E2E File Offset: 0x0001802E
		public static string FifaXmlFileName
		{
			get
			{
				return FifaEnvironment.m_FifaXmlFileName;
			}
			set
			{
				FifaEnvironment.m_FifaXmlFileName = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00019E36 File Offset: 0x00018036
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00019E3D File Offset: 0x0001803D
		public static string FifaDbPartialFileName
		{
			get
			{
				return FifaEnvironment.m_FifaDbPartialFileName;
			}
			set
			{
				FifaEnvironment.m_FifaDbPartialFileName = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00019E45 File Offset: 0x00018045
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00019E4C File Offset: 0x0001804C
		public static string FifaXmlPartialFileName
		{
			get
			{
				return FifaEnvironment.m_FifaXmlPartialFileName;
			}
			set
			{
				FifaEnvironment.m_FifaXmlPartialFileName = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00019E54 File Offset: 0x00018054
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00019E5B File Offset: 0x0001805B
		public static int Year
		{
			get
			{
				return FifaEnvironment.m_Year;
			}
			set
			{
				FifaEnvironment.m_Year = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00019E63 File Offset: 0x00018063
		public static DbFile LangDb
		{
			get
			{
				return FifaEnvironment.m_LangDb;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00019E6A File Offset: 0x0001806A
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00019E71 File Offset: 0x00018071
		public static string LangDbFileName
		{
			get
			{
				return FifaEnvironment.m_LangDbFileName;
			}
			set
			{
				FifaEnvironment.m_LangDbFileName = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00019E79 File Offset: 0x00018079
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00019E80 File Offset: 0x00018080
		public static string LangXmlFileName
		{
			get
			{
				return FifaEnvironment.m_LangXmlFileName;
			}
			set
			{
				FifaEnvironment.m_LangXmlFileName = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00019E88 File Offset: 0x00018088
		public static Language Language
		{
			get
			{
				return FifaEnvironment.m_Language;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00019E8F File Offset: 0x0001808F
		public static string RootDir
		{
			get
			{
				return FifaEnvironment.m_RootDir;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00019E96 File Offset: 0x00018096
		public static string GameDir
		{
			get
			{
				return FifaEnvironment.m_GameDir;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00019E9D File Offset: 0x0001809D
		public static string ExportFolder
		{
			get
			{
				return FifaEnvironment.m_ExportFolder;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00019EA4 File Offset: 0x000180A4
		public static string TempFolder
		{
			get
			{
				return FifaEnvironment.m_TempFolder;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00019EAB File Offset: 0x000180AB
		public static string LaunchDir
		{
			get
			{
				return FifaEnvironment.m_LaunchDir;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00019EB2 File Offset: 0x000180B2
		public static UserMessage UserMessages
		{
			get
			{
				return FifaEnvironment.m_UserMessages;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00019EB9 File Offset: 0x000180B9
		public static UserOptions UserOptions
		{
			get
			{
				return FifaEnvironment.m_UserOptions;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00019EC0 File Offset: 0x000180C0
		public static CountryList Countries
		{
			get
			{
				return FifaEnvironment.s_CountryList;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00019EC7 File Offset: 0x000180C7
		public static LeagueList Leagues
		{
			get
			{
				return FifaEnvironment.s_LeagueList;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00019ECE File Offset: 0x000180CE
		public static TeamList Teams
		{
			get
			{
				return FifaEnvironment.s_TeamList;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00019ED5 File Offset: 0x000180D5
		public static FreeAgentList FreeAgents
		{
			get
			{
				return FifaEnvironment.s_FreeAgentList;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00019EDC File Offset: 0x000180DC
		public static PlayerList Players
		{
			get
			{
				return FifaEnvironment.s_PlayerList;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00019EE3 File Offset: 0x000180E3
		public static PlayerNames OriginalPlayerNamesList
		{
			get
			{
				return FifaEnvironment.s_OriginalPlayerNamesList;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00019EEA File Offset: 0x000180EA
		public static PlayerNames PlayerNamesList
		{
			get
			{
				return FifaEnvironment.s_PlayerNamesList;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00019EF1 File Offset: 0x000180F1
		public static NameDictionary NameDictionary
		{
			get
			{
				return FifaEnvironment.s_NameDictionary;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00019EF8 File Offset: 0x000180F8
		public static CareerFirstNameList CareerFirstNameList
		{
			get
			{
				return FifaEnvironment.s_CareerFirstNameList;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00019EFF File Offset: 0x000180FF
		public static CareerLastNameList CareerLastNameList
		{
			get
			{
				return FifaEnvironment.s_CareerLastNameList;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00019F06 File Offset: 0x00018106
		public static CareerCommonNameList CareerCommonNameList
		{
			get
			{
				return FifaEnvironment.s_CareerCommonNameList;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00019F0D File Offset: 0x0001810D
		public static StadiumList Stadiums
		{
			get
			{
				return FifaEnvironment.s_StadiumList;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00019F14 File Offset: 0x00018114
		public static RefereeList Referees
		{
			get
			{
				return FifaEnvironment.s_RefereeList;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00019F1B File Offset: 0x0001811B
		public static KitList Kits
		{
			get
			{
				return FifaEnvironment.s_KitList;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00019F22 File Offset: 0x00018122
		public static CompobjList CompetitionObjects
		{
			get
			{
				return FifaEnvironment.s_CompetitionObjects;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00019F29 File Offset: 0x00018129
		public static FormationList Formations
		{
			get
			{
				return FifaEnvironment.s_FormationList;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00019F30 File Offset: 0x00018130
		public static FormationList GenericFormations
		{
			get
			{
				return FifaEnvironment.s_GenericFormationList;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00019F37 File Offset: 0x00018137
		public static RoleList Roles
		{
			get
			{
				return FifaEnvironment.s_RoleList;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00019F3E File Offset: 0x0001813E
		public static BallList Balls
		{
			get
			{
				if (FifaEnvironment.s_BallList == null)
				{
					FifaEnvironment.s_BallList = new BallList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_BallList;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00019F60 File Offset: 0x00018160
		public static AdboardList Adboards
		{
			get
			{
				if (FifaEnvironment.s_AdboardList == null)
				{
					FifaEnvironment.s_AdboardList = new AdboardList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_AdboardList;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00019F82 File Offset: 0x00018182
		public static ShoesList Shoes
		{
			get
			{
				if (FifaEnvironment.s_ShoesList == null)
				{
					FifaEnvironment.s_ShoesList = new ShoesList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_ShoesList;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00019FA4 File Offset: 0x000181A4
		public static GkGlovesList GkGloves
		{
			get
			{
				if (FifaEnvironment.s_GkGlovesList == null)
				{
					FifaEnvironment.s_GkGlovesList = new GkGlovesList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_GkGlovesList;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00019FC6 File Offset: 0x000181C6
		public static NetList Nets
		{
			get
			{
				if (FifaEnvironment.s_NetList == null)
				{
					FifaEnvironment.s_NetList = new NetList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NetList;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00019FE8 File Offset: 0x000181E8
		public static MowingPatternList MowingPatterns
		{
			get
			{
				if (FifaEnvironment.s_MowingPatternList == null)
				{
					FifaEnvironment.s_MowingPatternList = new MowingPatternList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_MowingPatternList;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001A00A File Offset: 0x0001820A
		public static NumberFontList NumberFonts
		{
			get
			{
				if (FifaEnvironment.s_NumberFontList == null)
				{
					FifaEnvironment.s_NumberFontList = new NumberFontList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NumberFontList;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0001A02C File Offset: 0x0001822C
		public static NameFontList NameFonts
		{
			get
			{
				if (FifaEnvironment.s_NameFontList == null)
				{
					FifaEnvironment.s_NameFontList = new NameFontList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NameFontList;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001A050 File Offset: 0x00018250
		public static void InitializeLaunchFolder()
		{
			int num = Environment.CommandLine.IndexOf(".exe");
			for (int i = num; i >= 0; i--)
			{
				if (Environment.CommandLine[i] == '\\')
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				FifaEnvironment.m_LaunchDir = Environment.CommandLine.Substring(1, num - 1);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001A0A3 File Offset: 0x000182A3
		public static bool InitializeDefault()
		{
			FifaEnvironment.InitializeLaunchFolder();
			return true;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001A0AC File Offset: 0x000182AC
		private static bool Initialize14(string rootDir)
		{
			if (FifaEnvironment.m_UserMessages == null)
			{
				FifaEnvironment.m_UserMessages = new UserMessage();
			}
			if (FifaEnvironment.m_UserOptions == null)
			{
				FifaEnvironment.m_UserOptions = new UserOptions();
			}
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_LangDb = null;
			FifaEnvironment.InitializeLaunchFolder();
			FifaEnvironment.m_Year = 14;
			FifaEnvironment.m_GameKey = RegistryInfo.GetFifaKey(FifaEnvironment.m_Year);
			if (rootDir == null)
			{
				if (!RegistryInfo.IsFifaInstalled(FifaEnvironment.m_GameKey))
				{
					return false;
				}
				FifaEnvironment.m_RootDir = RegistryInfo.GetInstallDir(FifaEnvironment.m_GameKey);
			}
			else
			{
				FifaEnvironment.m_RootDir = rootDir;
			}
			FifaEnvironment.m_GameDir = FifaEnvironment.m_RootDir + "\\Game\\";
			FifaEnvironment.m_FifaDbPartialFileName = "data/db/fifa_ng_db.db";
			FifaEnvironment.m_FifaDbFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaDbPartialFileName;
			FifaEnvironment.m_FifaXmlPartialFileName = "data/db/fifa_ng_db-meta.xml";
			FifaEnvironment.m_FifaXmlFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaXmlPartialFileName;
			FifaEnvironment.m_LangDbFileName = FifaEnvironment.GetLanguageDbFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_LangXmlFileName = FifaEnvironment.GetLanguageXmlFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			FifaEnvironment.m_TempFolder += "\\FM_temp";
			FifaEnvironment.m_ExportFolder = (FifaEnvironment.m_UserOptions.m_AutoExportFolder ? FifaEnvironment.m_TempFolder : FifaEnvironment.m_UserOptions.m_ExportFolder);
			if (!Directory.Exists(FifaEnvironment.m_TempFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			if (!Directory.Exists(FifaEnvironment.m_ExportFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			FifaEnvironment.s_NameFontList = null;
			FifaEnvironment.s_NumberFontList = null;
			FifaEnvironment.s_MowingPatternList = null;
			FifaEnvironment.s_NetList = null;
			FifaEnvironment.s_GkGlovesList = null;
			FifaEnvironment.s_ShoesList = null;
			FifaEnvironment.s_AdboardList = null;
			FifaEnvironment.s_BallList = null;
			FifaEnvironment.s_ShoesList = null;
			return true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001A244 File Offset: 0x00018444
		private static bool Initialize15(string rootDir)
		{
			if (FifaEnvironment.m_UserMessages == null)
			{
				FifaEnvironment.m_UserMessages = new UserMessage();
			}
			if (FifaEnvironment.m_UserOptions == null)
			{
				FifaEnvironment.m_UserOptions = new UserOptions();
			}
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_LangDb = null;
			FifaEnvironment.InitializeLaunchFolder();
			FifaEnvironment.m_Year = 15;
			FifaEnvironment.m_GameKey = RegistryInfo.GetFifaKey(FifaEnvironment.m_Year);
			if (rootDir == null)
			{
				if (!RegistryInfo.IsFifaInstalled(FifaEnvironment.m_GameKey))
				{
					return false;
				}
				FifaEnvironment.m_RootDir = RegistryInfo.GetInstallDir(FifaEnvironment.m_GameKey);
			}
			else
			{
				FifaEnvironment.m_RootDir = rootDir;
			}
			FifaEnvironment.m_GameDir = FifaEnvironment.m_RootDir + "\\";
			FifaEnvironment.m_FifaDbPartialFileName = "data/db/fifa_ng_db.db";
			FifaEnvironment.m_FifaDbFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaDbPartialFileName;
			FifaEnvironment.m_FifaXmlPartialFileName = "data/db/fifa_ng_db-meta.xml";
			FifaEnvironment.m_FifaXmlFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaXmlPartialFileName;
			FifaEnvironment.m_LangDbFileName = FifaEnvironment.GetLanguageDbFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_LangXmlFileName = FifaEnvironment.GetLanguageXmlFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			FifaEnvironment.m_TempFolder += "\\FM_temp";
			FifaEnvironment.m_ExportFolder = (FifaEnvironment.m_UserOptions.m_AutoExportFolder ? FifaEnvironment.m_TempFolder : FifaEnvironment.m_UserOptions.m_ExportFolder);
			if (!Directory.Exists(FifaEnvironment.m_TempFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			if (!Directory.Exists(FifaEnvironment.m_ExportFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			FifaEnvironment.s_NameFontList = null;
			FifaEnvironment.s_NumberFontList = null;
			FifaEnvironment.s_MowingPatternList = null;
			FifaEnvironment.s_NetList = null;
			FifaEnvironment.s_GkGlovesList = null;
			FifaEnvironment.s_ShoesList = null;
			FifaEnvironment.s_AdboardList = null;
			FifaEnvironment.s_BallList = null;
			FifaEnvironment.s_ShoesList = null;
			return true;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001A3DC File Offset: 0x000185DC
		private static bool Initialize16(string rootDir)
		{
			if (FifaEnvironment.m_UserMessages == null)
			{
				FifaEnvironment.m_UserMessages = new UserMessage();
			}
			if (FifaEnvironment.m_UserOptions == null)
			{
				FifaEnvironment.m_UserOptions = new UserOptions();
			}
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_LangDb = null;
			FifaEnvironment.m_IsRevModInstalled = false;
			FifaEnvironment.InitializeLaunchFolder();
			FifaEnvironment.m_Year = 16;
			FifaEnvironment.m_GameKey = RegistryInfo.GetFifaKey(FifaEnvironment.m_Year);
			if (rootDir == null)
			{
				if (!RegistryInfo.IsFifaInstalled(FifaEnvironment.m_GameKey))
				{
					return false;
				}
				FifaEnvironment.m_RootDir = RegistryInfo.GetInstallDir(FifaEnvironment.m_GameKey);
			}
			else
			{
				FifaEnvironment.m_RootDir = rootDir;
			}
			FifaEnvironment.m_GameDir = FifaEnvironment.m_RootDir + "\\";
			FifaEnvironment.m_FifaDbPartialFileName = "data/db/fifa_ng_db.db";
			FifaEnvironment.m_FifaDbFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaDbPartialFileName;
			FifaEnvironment.m_FifaXmlPartialFileName = "data/db/fifa_ng_db-meta.xml";
			FifaEnvironment.m_FifaXmlFileName = FifaEnvironment.m_GameDir + FifaEnvironment.m_FifaXmlPartialFileName;
			FifaEnvironment.m_LangDbFileName = FifaEnvironment.GetLanguageDbFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_LangXmlFileName = FifaEnvironment.GetLanguageXmlFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			FifaEnvironment.m_TempFolder += "\\FM_temp";
			FifaEnvironment.m_ExportFolder = (FifaEnvironment.m_UserOptions.m_AutoExportFolder ? FifaEnvironment.m_TempFolder : FifaEnvironment.m_UserOptions.m_ExportFolder);
			if (!Directory.Exists(FifaEnvironment.m_TempFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			if (!Directory.Exists(FifaEnvironment.m_ExportFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			FifaEnvironment.s_NameFontList = null;
			FifaEnvironment.s_NumberFontList = null;
			FifaEnvironment.s_MowingPatternList = null;
			FifaEnvironment.s_NetList = null;
			FifaEnvironment.s_GkGlovesList = null;
			FifaEnvironment.s_ShoesList = null;
			FifaEnvironment.s_AdboardList = null;
			FifaEnvironment.s_BallList = null;
			FifaEnvironment.s_ShoesList = null;
			return true;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001A57A File Offset: 0x0001877A
		public static bool Initialize(int year, string rootDir)
		{
			if (year == 14)
			{
				return FifaEnvironment.Initialize14(rootDir);
			}
			if (year == 15)
			{
				return FifaEnvironment.Initialize15(rootDir);
			}
			return year == 16 && FifaEnvironment.Initialize16(rootDir);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001A5A4 File Offset: 0x000187A4
		public static string GetLanguageDbFilename(string game)
		{
			string gameDir = FifaEnvironment.m_GameDir;
			string locale = RegistryInfo.GetLocale(game);
			return gameDir + "data\\loc\\" + FifaEnvironment.ConvertLanguageToFileName(locale) + ".db";
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001A5D8 File Offset: 0x000187D8
		public static string GetLanguageXmlFilename(string game)
		{
			string gameDir = FifaEnvironment.m_GameDir;
			string locale = RegistryInfo.GetLocale(game);
			return gameDir + "data\\loc\\" + FifaEnvironment.ConvertLanguageToFileName(locale) + "-meta.xml";
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001A60C File Offset: 0x0001880C
		private static string ConvertLanguageToFileName(string locale)
		{
			string text = "eng_us";
			if (locale != null && locale != string.Empty)
			{
				if (locale.StartsWith("it"))
				{
					text = "ita_it";
				}
				else if (locale.StartsWith("sa"))
				{
					text = "ara_sa";
				}
				else if (locale.StartsWith("cz"))
				{
					text = "cze_cz";
				}
				else if (locale.StartsWith("dk"))
				{
					text = "dan_dk";
				}
				else if (locale.StartsWith("nl"))
				{
					text = "dut_nl";
				}
				else if (locale.StartsWith("en"))
				{
					text = "eng_us";
				}
				else if (locale.StartsWith("fr"))
				{
					text = "fre_fr";
				}
				else if (locale.StartsWith("de"))
				{
					text = "ger_de";
				}
				else if (locale.StartsWith("hu"))
				{
					text = "hun_hu";
				}
				else if (locale.StartsWith("jp"))
				{
					text = "jpn_jp";
				}
				else if (locale.StartsWith("kr"))
				{
					text = "kor_kr";
				}
				else if (locale.StartsWith("no"))
				{
					text = "nor_no";
				}
				else if (locale.StartsWith("pl"))
				{
					text = "pol_pl";
				}
				else if (locale.StartsWith("pt"))
				{
					text = "por_pt";
				}
				else if (locale.StartsWith("br"))
				{
					text = "por_br";
				}
				else if (locale.StartsWith("ru"))
				{
					text = "rus_ru";
				}
				else if (locale.StartsWith("es"))
				{
					text = "spa_es";
				}
				else if (locale.StartsWith("mx"))
				{
					text = "spa_mx";
				}
				else if (locale.StartsWith("se"))
				{
					text = "swe_se";
				}
				else
				{
					text = "eng_us";
				}
			}
			return text;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001A7F2 File Offset: 0x000189F2
		public static string GetEnglishFilename(string game)
		{
			return FifaEnvironment.m_GameDir + "\\data\\loc\\eng_us.db";
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001A803 File Offset: 0x00018A03
		public static string GetEnglishXmlFilename(string game)
		{
			return FifaEnvironment.m_GameDir + "\\data\\loc\\eng_us-meta.xml";
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001A814 File Offset: 0x00018A14
		public static void Close()
		{
			if (FifaEnvironment.s_AdboardList != null)
			{
				FifaEnvironment.s_AdboardList.Clear();
			}
			if (FifaEnvironment.s_BallList != null)
			{
				FifaEnvironment.s_BallList.Clear();
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Clear();
			}
			if (FifaEnvironment.s_CountryList != null)
			{
				FifaEnvironment.s_CountryList.Clear();
			}
			if (FifaEnvironment.s_FormationList != null)
			{
				FifaEnvironment.s_FormationList.Clear();
			}
			if (FifaEnvironment.s_GenericFormationList != null)
			{
				FifaEnvironment.s_GenericFormationList.Clear();
			}
			if (FifaEnvironment.s_FreeAgentList != null)
			{
				FifaEnvironment.s_FreeAgentList.Clear();
			}
			if (FifaEnvironment.s_NumberFontList != null)
			{
				FifaEnvironment.s_NumberFontList.Clear();
			}
			if (FifaEnvironment.s_NameFontList != null)
			{
				FifaEnvironment.s_NameFontList.Clear();
			}
			if (FifaEnvironment.s_KitList != null)
			{
				FifaEnvironment.s_KitList.Clear();
			}
			if (FifaEnvironment.s_LeagueList != null)
			{
				FifaEnvironment.s_LeagueList.Clear();
			}
			if (FifaEnvironment.s_NetList != null)
			{
				FifaEnvironment.s_NetList.Clear();
			}
			if (FifaEnvironment.s_MowingPatternList != null)
			{
				FifaEnvironment.s_MowingPatternList.Clear();
			}
			if (FifaEnvironment.s_PlayerList != null)
			{
				FifaEnvironment.s_PlayerList.Clear();
			}
			if (FifaEnvironment.s_PlayerNamesList != null)
			{
				FifaEnvironment.s_PlayerNamesList.Clear();
			}
			if (FifaEnvironment.s_NameDictionary != null)
			{
				FifaEnvironment.s_NameDictionary.Clear();
			}
			if (FifaEnvironment.s_CareerFirstNameList != null)
			{
				FifaEnvironment.s_CareerFirstNameList.Clear();
			}
			if (FifaEnvironment.s_CareerLastNameList != null)
			{
				FifaEnvironment.s_CareerLastNameList.Clear();
			}
			if (FifaEnvironment.s_CareerCommonNameList != null)
			{
				FifaEnvironment.s_CareerCommonNameList.Clear();
			}
			if (FifaEnvironment.s_RefereeList != null)
			{
				FifaEnvironment.s_RefereeList.Clear();
			}
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Clear();
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Clear();
			}
			if (FifaEnvironment.s_GkGlovesList != null)
			{
				FifaEnvironment.s_GkGlovesList.Clear();
			}
			if (FifaEnvironment.s_StadiumList != null)
			{
				FifaEnvironment.s_StadiumList.Clear();
			}
			if (FifaEnvironment.s_TeamList != null)
			{
				FifaEnvironment.s_TeamList.Clear();
			}
			if (FifaEnvironment.s_CompetitionObjects != null)
			{
				FifaEnvironment.s_CompetitionObjects.Clear();
			}
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_CareerFile = null;
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_LangDb = null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		public static bool Open(ToolStripStatusLabel statusBar)
		{
			FifaEnvironment.m_Status = statusBar;
			if (FifaEnvironment.m_FifaFat == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening data#.big files";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				if (!FifaEnvironment.OpenFat())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_FifaDb == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening main database";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				FifaEnvironment.ExtractMainDatabase();
				if (!FifaEnvironment.OpenFifaDb())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_LangDb == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening language database";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				FifaEnvironment.ExtractLangDatabase();
				if (!FifaEnvironment.OpenLangDb())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_Year == 14)
			{
				string text = FifaEnvironment.m_LaunchDir + "\\Templates\\2014\\" + FifaEnvironment.m_FifaDbPartialFileName;
				string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\2014\\" + FifaEnvironment.m_FifaXmlPartialFileName;
				FifaEnvironment.m_OriginalFifaDb = new DbFile(text, text2);
			}
			else if (FifaEnvironment.m_Year == 15)
			{
				string text3 = FifaEnvironment.m_LaunchDir + "\\Templates\\2015\\" + FifaEnvironment.m_FifaDbPartialFileName;
				string text4 = FifaEnvironment.m_LaunchDir + "\\Templates\\2015\\" + FifaEnvironment.m_FifaXmlPartialFileName;
				FifaEnvironment.m_OriginalFifaDb = new DbFile(text3, text4);
			}
			else
			{
				string text5 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + FifaEnvironment.m_FifaDbPartialFileName;
				string text6 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + FifaEnvironment.m_FifaXmlPartialFileName;
				if (File.Exists(text5) && File.Exists(text6))
				{
					FifaEnvironment.m_OriginalFifaDb = new DbFile(text5, text6);
				}
			}
			FifaEnvironment.ExtractCompetitionFiles();
			if (File.Exists(FifaEnvironment.m_GameDir + FifaEnvironment.s_RevModFileNames[0]))
			{
				FifaEnvironment.m_IsRevModInstalled = true;
			}
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Loading...";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.LoadLists();
			foreach (Record record in FifaEnvironment.m_OriginalFifaDb.Table[TI.rowteamnationlinks].Records)
			{
				int andCheckIntField = record.GetAndCheckIntField(FI.rowteamnationlinks_nationid);
				int andCheckIntField2 = record.GetAndCheckIntField(FI.rowteamnationlinks_teamid);
				Team team = (Team)FifaEnvironment.s_TeamList.SearchId(andCheckIntField2);
				if (team != null && (team.Country == null || team.Country.Id != andCheckIntField))
				{
					team.Country = (Country)FifaEnvironment.s_CountryList.SearchId(andCheckIntField);
				}
			}
			Table table = FifaEnvironment.m_OriginalFifaDb.Table[TI.playerboots];
			int num = 0;
			Record[] array = table.Records;
			for (int i = 0; i < array.Length; i++)
			{
				Shoes shoes = new Shoes(array[i]);
				if (shoes.Id == 0 && num < 23)
				{
					ShoesList.s_GenericShoes[num++] = shoes;
				}
			}
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Ready";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			return true;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0001ACD4 File Offset: 0x00018ED4
		public static bool Save(ToolStripStatusLabel statusBar)
		{
			FifaEnvironment.m_Status = statusBar;
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving lists";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveLists();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving main database";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveFifaDb();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving language";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveLangDb();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving big files";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.m_FifaFat.Save();
			return true;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001AD98 File Offset: 0x00018F98
		public static bool OpenFat()
		{
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaFat = FifaFat.Create(FifaEnvironment.m_GameDir);
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10003);
				return false;
			}
			FifaEnvironment.m_FifaFat.SaveOption = FifaFat.EFifaFatSaveOption.SaveOnCommand;
			FifaEnvironment.m_FifaFat.ResetDefaultZdata();
			return true;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001ADEC File Offset: 0x00018FEC
		public static bool ExtractMainDatabase()
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			if (FifaEnvironment.m_Year == 14)
			{
				while (FifaEnvironment.m_FifaFat.IsArchivedFilePresent(FifaEnvironment.m_FifaDbPartialFileName))
				{
					if (!flag)
					{
						flag = FifaEnvironment.m_FifaFat.ExtractFile(FifaEnvironment.m_FifaDbPartialFileName);
					}
					else
					{
						FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.m_FifaDbPartialFileName);
					}
				}
				while (FifaEnvironment.m_FifaFat.IsArchivedFilePresent(FifaEnvironment.m_FifaXmlPartialFileName))
				{
					if (!flag2)
					{
						flag2 = FifaEnvironment.m_FifaFat.ExtractFile(FifaEnvironment.m_FifaXmlPartialFileName);
					}
					else
					{
						FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.m_FifaXmlPartialFileName);
					}
				}
			}
			else if (FifaEnvironment.m_Year == 15)
			{
				string directoryName = Path.GetDirectoryName(FifaEnvironment.m_FifaDbFileName);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				if (!File.Exists(FifaEnvironment.m_FifaDbFileName))
				{
					File.Copy(FifaEnvironment.m_LaunchDir + "\\Templates\\2015\\data\\db\\fifa_ng_db.db", FifaEnvironment.m_FifaDbFileName);
				}
				if (!File.Exists(FifaEnvironment.m_FifaXmlFileName))
				{
					File.Copy(FifaEnvironment.m_LaunchDir + "\\Templates\\2015\\data\\db\\fifa_ng_db-meta.xml", FifaEnvironment.m_FifaXmlFileName);
				}
				BhFile bhFile = FifaEnvironment.m_FifaFat.GetBhFile(17);
				if (bhFile != null)
				{
					if (!bhFile.IsHidden(47))
					{
						bhFile.Hide(47);
					}
					if (!bhFile.IsHidden(48))
					{
						bhFile.Hide(48);
					}
				}
			}
			else if (FifaEnvironment.m_Year == 16)
			{
				string directoryName2 = Path.GetDirectoryName(FifaEnvironment.m_FifaDbFileName);
				if (!Directory.Exists(directoryName2))
				{
					Directory.CreateDirectory(directoryName2);
				}
				if (!File.Exists(FifaEnvironment.m_FifaDbFileName))
				{
					File.Copy(FifaEnvironment.m_LaunchDir + "\\Templates\\data\\db\\fifa_ng_db.db", FifaEnvironment.m_FifaDbFileName);
				}
				if (!File.Exists(FifaEnvironment.m_FifaXmlFileName))
				{
					File.Copy(FifaEnvironment.m_LaunchDir + "\\Templates\\data\\db\\fifa_ng_db-meta.xml", FifaEnvironment.m_FifaXmlFileName);
				}
				FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.m_FifaDbPartialFileName);
				FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.m_FifaXmlPartialFileName);
			}
			return flag && flag2;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001AFCC File Offset: 0x000191CC
		public static bool ExtractLangDatabase()
		{
			string text = FifaEnvironment.m_GameDir + "data\\loc\\locale.big";
			string gameDir = FifaEnvironment.m_GameDir;
			FifaBigFile fifaBigFile = new FifaBigFile(text);
			string[] archivedFileNames = fifaBigFile.GetArchivedFileNames("*.db", true);
			string[] archivedFileNames2 = fifaBigFile.GetArchivedFileNames("*.xml", true);
			bool flag = fifaBigFile.Export(archivedFileNames, gameDir);
			if (flag)
			{
				fifaBigFile.Delete(archivedFileNames);
			}
			bool flag2 = fifaBigFile.Export(archivedFileNames2, gameDir);
			if (flag2)
			{
				fifaBigFile.Delete(archivedFileNames2);
			}
			if (flag || flag2)
			{
				fifaBigFile.Save();
			}
			return flag || flag2;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001B048 File Offset: 0x00019248
		public static bool ExtractCompetitionFiles()
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			string[] fileNames = CompobjList.GetFileNames();
			bool flag = false;
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\";
			for (int i = 0; i < fileNames.Length; i++)
			{
				string text2 = FifaEnvironment.m_GameDir + fileNames[i];
				if (!File.Exists(text2))
				{
					string directoryName = Path.GetDirectoryName(text2);
					if (!Directory.Exists(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					File.Copy(text + fileNames[i], text2, true);
					FifaEnvironment.m_FifaFat.HideFile(fileNames[i]);
					flag = true;
				}
				else
				{
					FifaEnvironment.m_FifaFat.HideFile(fileNames[i]);
				}
			}
			return flag;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001B0E8 File Offset: 0x000192E8
		public static bool ExtractRevModFiles()
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(31);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return false;
			}
			bool flag = false;
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\";
			for (int i = 0; i < FifaEnvironment.s_RevModFileNames.Length; i++)
			{
				FifaEnvironment.m_IsRevModInstalled = true;
				string text2 = FifaEnvironment.m_GameDir + FifaEnvironment.s_RevModFileNames[i];
				string directoryName = Path.GetDirectoryName(text2);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				if (!File.Exists(text2))
				{
					File.Copy(text + FifaEnvironment.s_RevModFileNames[i], text2, true);
					FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.s_RevModFileNames[i]);
					flag = true;
				}
				else
				{
					FifaEnvironment.m_FifaFat.HideFile(FifaEnvironment.s_RevModFileNames[i]);
				}
			}
			FifaEnvironment.m_IsRevModInstalled = true;
			FifaEnvironment.m_UserMessages.ShowMessage(15008);
			return flag;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001B1CC File Offset: 0x000193CC
		public static bool OpenFifaDb()
		{
			FifaEnvironment.m_FifaDb = null;
			if (FifaEnvironment.m_FifaDbFileName != null && FifaEnvironment.m_FifaXmlFileName != null && File.Exists(FifaEnvironment.m_FifaDbFileName) && File.Exists(FifaEnvironment.m_FifaXmlFileName))
			{
				FifaEnvironment.m_FifaDb = new DbFile(FifaEnvironment.m_FifaDbFileName, FifaEnvironment.m_FifaXmlFileName);
			}
			if (FifaEnvironment.m_FifaDb == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10000);
				return false;
			}
			if (FifaEnvironment.m_Year == 14)
			{
				TI.InitTI(FifaEnvironment.m_FifaDb);
				FI.InitFI(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.m_Year == 15)
			{
				TI.InitTI(FifaEnvironment.m_FifaDb);
				FI.InitFI(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.m_Year == 16)
			{
				TI.InitTI(FifaEnvironment.m_FifaDb);
				FI.InitFI(FifaEnvironment.m_FifaDb);
			}
			return FifaEnvironment.m_FifaDb != null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001B294 File Offset: 0x00019494
		public static bool OpenLangDb()
		{
			FifaEnvironment.m_LangDb = null;
			if (FifaEnvironment.m_LangDbFileName != null && FifaEnvironment.m_LangXmlFileName != null && File.Exists(FifaEnvironment.m_LangDbFileName) && File.Exists(FifaEnvironment.m_LangXmlFileName))
			{
				FifaEnvironment.m_LangDb = new DbFile(FifaEnvironment.m_LangDbFileName, FifaEnvironment.m_LangXmlFileName);
			}
			if (FifaEnvironment.m_LangDb != null)
			{
				FifaEnvironment.m_Language = new Language(FifaEnvironment.m_LangDb.Table[TI.lang]);
			}
			return FifaEnvironment.m_LangDb != null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001B30A File Offset: 0x0001950A
		public static void SaveFifaDb()
		{
			File.Copy(FifaEnvironment.m_FifaDbFileName, FifaEnvironment.m_FifaDbFileName + ".bak", true);
			FifaEnvironment.m_FifaDb.SaveDb(FifaEnvironment.m_FifaDbFileName);
			FifaEnvironment.m_FifaDb.SaveXml(FifaEnvironment.m_FifaXmlFileName);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001B348 File Offset: 0x00019548
		public static void SaveLangDb()
		{
			File.Copy(FifaEnvironment.m_LangDbFileName, FifaEnvironment.m_LangDbFileName + ".bak", true);
			FifaEnvironment.m_Language.Save(FifaEnvironment.m_LangDb.Table[TI.lang]);
			FifaEnvironment.m_LangDb.SaveDb(FifaEnvironment.m_LangDbFileName);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001B39C File Offset: 0x0001959C
		public static Rx3File GetRx3FromZdata(string rx3FileName, bool verbose)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			Rx3File rx3File = null;
			FifaFile fifaFile = FifaEnvironment.m_FifaFat.GetArchivedFile(rx3FileName);
			if (fifaFile != null)
			{
				if (fifaFile.IsCompressed)
				{
					fifaFile.Decompress();
				}
				BinaryReader reader = fifaFile.GetReader();
				rx3File = new Rx3File();
				rx3File.Load(reader);
				fifaFile.ReleaseReader(reader);
			}
			else
			{
				string text = FifaEnvironment.m_GameDir + rx3FileName;
				if (File.Exists(text))
				{
					fifaFile = new FifaFile(text, false);
					if (fifaFile != null)
					{
						rx3File = new Rx3File();
						rx3File.Load(fifaFile);
					}
				}
			}
			if (rx3File == null && verbose)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, rx3FileName, true);
				return null;
			}
			return rx3File;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001B43A File Offset: 0x0001963A
		public static Rx3File GetRx3FromZdata(string rx3FileName)
		{
			return FifaEnvironment.GetRx3FromZdata(rx3FileName, true);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001B444 File Offset: 0x00019644
		public static KitFile GetKitFromZdata(string rx3FileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			KitFile kitFile = null;
			FifaFile fifaFile = FifaEnvironment.m_FifaFat.GetArchivedFile(rx3FileName);
			if (fifaFile != null)
			{
				if (fifaFile.IsCompressed)
				{
					fifaFile.Decompress();
				}
				BinaryReader reader = fifaFile.GetReader();
				kitFile = new KitFile();
				kitFile.Load(reader);
				fifaFile.ReleaseReader(reader);
			}
			else
			{
				string text = FifaEnvironment.m_GameDir + rx3FileName;
				if (File.Exists(text))
				{
					fifaFile = new FifaFile(text, false);
					if (fifaFile != null)
					{
						kitFile = new KitFile();
						kitFile.Load(fifaFile);
					}
				}
			}
			if (kitFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, rx3FileName, true);
				return null;
			}
			return kitFile;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001B4DD File Offset: 0x000196DD
		public static bool IsFilePresent(string fileName)
		{
			return FifaEnvironment.m_FifaFat != null && (FifaEnvironment.m_FifaFat.IsArchivedFilePresent(fileName) || File.Exists(FifaEnvironment.m_GameDir + fileName));
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001B50C File Offset: 0x0001970C
		public static Bitmap GetBmpFromRx3(string rx3FileName, int imageIndex)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName, false);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images.Length > imageIndex && imageIndex >= 0)
			{
				return rx3FromZdata.Images[imageIndex].GetBitmap();
			}
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001B544 File Offset: 0x00019744
		public static Bitmap[] GetBmpsFromRx3(string rx3FileName, bool verbose)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName, verbose);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images != null && rx3FromZdata.Images.Length != 0)
			{
				return rx3FromZdata.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001B577 File Offset: 0x00019777
		public static Bitmap[] GetBmpsFromRx3(string rx3FileName)
		{
			return FifaEnvironment.GetBmpsFromRx3(rx3FileName, true);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001B580 File Offset: 0x00019780
		public static Bitmap[] GetBitmapsFromRx3File(string rx3FileName)
		{
			if (rx3FileName == null)
			{
				return null;
			}
			if (!File.Exists(rx3FileName))
			{
				return null;
			}
			Rx3File rx3File = new Rx3File();
			if (!rx3File.Load(rx3FileName))
			{
				return null;
			}
			if (rx3File.Images.Length != 0)
			{
				return rx3File.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001B5C0 File Offset: 0x000197C0
		public static Bitmap[] GetKitFromRx3(string rx3FileName, out float[] positions)
		{
			KitFile kitFromZdata = FifaEnvironment.GetKitFromZdata(rx3FileName);
			if (kitFromZdata == null)
			{
				positions = null;
				return null;
			}
			positions = kitFromZdata.Positions;
			if (kitFromZdata.Images.Length != 0)
			{
				return kitFromZdata.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001B5F8 File Offset: 0x000197F8
		public static Bitmap GetBmpFromRx3(string rx3FileName, bool verbose)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName, verbose);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images.Length != 0)
			{
				return rx3FromZdata.Images[0].GetBitmap();
			}
			return null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001B62A File Offset: 0x0001982A
		public static Bitmap GetBmpFromRx3(string rx3FileName)
		{
			return FifaEnvironment.GetBmpFromRx3(rx3FileName, true);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001B634 File Offset: 0x00019834
		public static Bitmap GetArtasset(string bigFileName)
		{
			FifaBigFile bigFromZdata = FifaEnvironment.GetBigFromZdata(bigFileName);
			if (bigFromZdata == null)
			{
				return null;
			}
			FifaFile firstDds = bigFromZdata.GetFirstDds();
			if (firstDds == null)
			{
				return null;
			}
			return new DdsFile(firstDds).GetBitmap();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001B664 File Offset: 0x00019864
		public static Bitmap GetArtasset(string bigFileName, string ddsFileName)
		{
			FifaBigFile bigFromZdata = FifaEnvironment.GetBigFromZdata(bigFileName);
			if (bigFromZdata == null)
			{
				return null;
			}
			FifaFile ddsByName = bigFromZdata.GetDdsByName(ddsFileName);
			if (ddsByName == null)
			{
				return null;
			}
			return new DdsFile(ddsByName).GetBitmap();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001B698 File Offset: 0x00019898
		public static Bitmap GetDdsArtasset(string ddsFileName)
		{
			FifaFile fileFromZdata = FifaEnvironment.GetFileFromZdata(ddsFileName);
			if (fileFromZdata == null)
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(fileFromZdata);
			if (fileFromZdata == null)
			{
				return null;
			}
			return ddsFile.GetBitmap();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001B6C3 File Offset: 0x000198C3
		public static Bitmap GetBitmapFromDdsFile(string ddsFileName)
		{
			if (ddsFileName == null)
			{
				return null;
			}
			if (!File.Exists(ddsFileName))
			{
				return null;
			}
			return new DdsFile(ddsFileName).GetBitmap();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001B6E0 File Offset: 0x000198E0
		public static Bitmap GetBitmapFromBigFile(string bigFileName)
		{
			if (bigFileName == null)
			{
				return null;
			}
			if (!File.Exists(bigFileName))
			{
				return null;
			}
			FifaBigFile fifaBigFile = new FifaBigFile(bigFileName);
			if (fifaBigFile == null)
			{
				return null;
			}
			FifaFile firstDds = fifaBigFile.GetFirstDds();
			if (firstDds == null)
			{
				return null;
			}
			return new DdsFile(firstDds).GetBitmap();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001B71F File Offset: 0x0001991F
		public static Bitmap Get2dHead(string ddsFileName)
		{
			return FifaEnvironment.GetDdsArtasset(ddsFileName);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001B728 File Offset: 0x00019928
		private static FifaBigFile GetBigFromZdata(string bigFileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			FifaBigFile fifaBigFile = null;
			FifaFile archivedFile = FifaEnvironment.m_FifaFat.GetArchivedFile(bigFileName);
			if (archivedFile != null)
			{
				if (archivedFile.IsCompressed)
				{
					archivedFile.Decompress();
				}
				fifaBigFile = new FifaBigFile(archivedFile);
			}
			else
			{
				string text = FifaEnvironment.m_GameDir + bigFileName;
				if (File.Exists(text))
				{
					fifaBigFile = new FifaBigFile(text);
				}
			}
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, bigFileName, true);
				return null;
			}
			return fifaBigFile;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001B79C File Offset: 0x0001999C
		public static bool SetArtasset(string templateBigName, string ddsName, int id, Bitmap bitmap)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, id, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001B7C8 File Offset: 0x000199C8
		public static bool SetArtasset(string templateBigName, string[] ddsNames, string fileBigName, Bitmap[] bitmaps)
		{
			string text = FifaEnvironment.CreateMultipleAssetFromTemplate(templateBigName, ddsNames, fileBigName, bitmaps);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public static bool SetArtasset(string templateBigName, string ddsName, int[] ids, Bitmap bitmap)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, ids, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001B820 File Offset: 0x00019A20
		public static bool SetArtasset(string templateBigName, string ddsName, int[] ids, Bitmap bitmap, string[] format)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, ids, bitmap, format);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001B84C File Offset: 0x00019A4C
		public static bool SetDdsArtasset(string templateDdsName, int id, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, id, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001B87C File Offset: 0x00019A7C
		public static bool SetDdsArtasset(string templateDdsName, string newDdsName, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, newDdsName, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001B8AC File Offset: 0x00019AAC
		public static bool SetDdsArtasset(string templateDdsName, int[] ids, Bitmap bitmap, string[] format)
		{
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, ids, bitmap, format);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001B8D5 File Offset: 0x00019AD5
		public static bool Set2dHead(string templateDdsName, int id, Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(templateDdsName, id, bitmap);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001B8DF File Offset: 0x00019ADF
		public static bool Delete2dHead(string fileName)
		{
			return FifaEnvironment.DeleteFromZdata(fileName);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int id, Bitmap bitmap)
		{
			string text = null;
			Path.GetDirectoryName(templateBigName);
			string text2 = templateBigName.Replace("#", (id >= 0) ? id.ToString(text) : "");
			text2 = text2.Replace("2014_", "");
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text2, bitmap);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001B938 File Offset: 0x00019B38
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int[] ids, Bitmap bitmap)
		{
			string text = null;
			Path.GetDirectoryName(templateBigName);
			string text2 = templateBigName.Replace("#", (ids[0] >= 0) ? ids[0].ToString(text) : "");
			text2 = text2.Replace("%", ids[1].ToString(text));
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text2, bitmap);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001B998 File Offset: 0x00019B98
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int[] ids, Bitmap bitmap, string[] format)
		{
			Path.GetDirectoryName(templateBigName);
			string text = templateBigName.Replace("#", (ids[0] >= 0) ? ids[0].ToString(format[0]) : "");
			text = text.Replace("%", ids[1].ToString(format[1]));
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text, bitmap);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001B9FC File Offset: 0x00019BFC
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, string newBigFileName, Bitmap bitmap)
		{
			string directoryName = Path.GetDirectoryName(templateBigName);
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateBigName;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + newBigFileName;
			if (!File.Exists(text))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5026);
				return null;
			}
			File.Copy(text, text2, true);
			FifaBigFile fifaBigFile = new FifaBigFile(text2);
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			fifaBigFile.LoadArchivedFiles();
			FifaFile archivedFile = fifaBigFile.GetArchivedFile(ddsName, true);
			if (archivedFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			if (archivedFile.IsCompressed)
			{
				archivedFile.Decompress();
			}
			DdsFile ddsFile = new DdsFile(archivedFile);
			if (ddsFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.ReplaceBitmap(bitmap);
			BinaryWriter writer = archivedFile.GetWriter();
			if (writer == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.Save(writer);
			archivedFile.ReleaseWriter(writer);
			fifaBigFile.Save();
			string text3 = FifaEnvironment.m_GameDir + directoryName + "\\";
			string text4 = text3 + Path.GetFileName(newBigFileName);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			File.Copy(text2, text4, true);
			if (!text2.Contains("#"))
			{
				File.Delete(text2);
			}
			return newBigFileName;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001BB58 File Offset: 0x00019D58
		private static string CreateMultipleAssetFromTemplate(string templateBigName, string[] ddsNames, string newBigFileName, Bitmap[] bitmaps)
		{
			if (ddsNames.Length != bitmaps.Length)
			{
				return null;
			}
			string directoryName = Path.GetDirectoryName(templateBigName);
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateBigName;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + newBigFileName;
			if (!File.Exists(text))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5026);
				return null;
			}
			File.Copy(text, text2, true);
			FifaBigFile fifaBigFile = new FifaBigFile(text2);
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			fifaBigFile.LoadArchivedFiles();
			for (int i = 0; i < ddsNames.Length; i++)
			{
				FifaFile archivedFile = fifaBigFile.GetArchivedFile(ddsNames[i], true);
				if (archivedFile != null)
				{
					if (archivedFile.IsCompressed)
					{
						archivedFile.Decompress();
					}
					DdsFile ddsFile = new DdsFile(archivedFile);
					if (ddsFile != null)
					{
						ddsFile.ReplaceBitmap(bitmaps[i]);
						BinaryWriter writer = archivedFile.GetWriter();
						if (writer != null)
						{
							ddsFile.Save(writer);
							archivedFile.ReleaseWriter(writer);
						}
					}
				}
			}
			fifaBigFile.Save();
			string text3 = FifaEnvironment.m_GameDir + directoryName + "\\";
			string text4 = text3 + Path.GetFileName(newBigFileName);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			File.Copy(text2, text4, true);
			if (!text2.Contains("#"))
			{
				File.Delete(text2);
			}
			return newBigFileName;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int id, Bitmap bitmap)
		{
			if (templateDdsName == null)
			{
				return null;
			}
			Path.GetDirectoryName(templateDdsName);
			string text = templateDdsName.Replace("#", id.ToString());
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, text, bitmap);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int id, Bitmap bitmap, string[] format)
		{
			int[] array = new int[2];
			array[0] = id;
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, array, bitmap, format);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int[] ids, Bitmap bitmap, string[] format)
		{
			Path.GetDirectoryName(templateDdsName);
			string text = templateDdsName.Replace("2014_", "");
			text = text.Replace("#", ids[0].ToString(format[0]));
			if (ids.Length >= 2)
			{
				text = text.Replace("%", ids[1].ToString(format[1]));
			}
			if (ids.Length >= 3)
			{
				text = text.Replace("@", ids[2].ToString(format[2]));
			}
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, text, bitmap);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001BD84 File Offset: 0x00019F84
		private static string CreateDdsAssetFromTemplate(string templateDdsName, string newDdsFileName, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return null;
			}
			string directoryName = Path.GetDirectoryName(templateDdsName);
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateDdsName;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + newDdsFileName;
			if (!File.Exists(text))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5026);
				return null;
			}
			File.Copy(text, text2, true);
			DdsFile ddsFile = new DdsFile(text2);
			if (ddsFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.ReplaceBitmap(bitmap);
			ddsFile.Save(text2);
			string text3 = FifaEnvironment.m_GameDir + directoryName + "\\";
			string text4 = text3 + Path.GetFileName(newDdsFileName);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			File.Copy(text2, text4, true);
			if (!text2.Contains("#"))
			{
				File.Delete(text2);
			}
			return newDdsFileName;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001BE5B File Offset: 0x0001A05B
		public static bool IsPatched(string fileName)
		{
			return File.Exists(FifaEnvironment.m_GameDir + fileName);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001BE70 File Offset: 0x0001A070
		public static FifaFile GetFileFromZdata(string fileName)
		{
			if (FifaEnvironment.m_FifaFat == null || fileName == null)
			{
				return null;
			}
			FifaFile archivedFile = FifaEnvironment.m_FifaFat.GetArchivedFile(fileName);
			if (archivedFile != null)
			{
				return archivedFile;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			if (File.Exists(text))
			{
				return new FifaFile(text, false);
			}
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		public static bool ExportFileFromZdata(string fileName, string path)
		{
			if (FifaEnvironment.m_FifaFat == null || fileName == null)
			{
				return false;
			}
			bool flag = FifaEnvironment.m_FifaFat.ExportFile(fileName, path);
			if (flag)
			{
				return true;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			string text2 = path + "\\" + fileName;
			if (File.Exists(text) && text != text2)
			{
				string directoryName = Path.GetDirectoryName(text2);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(text, text2, true);
				return true;
			}
			FifaEnvironment.m_UserMessages.ShowMessage(1028, " " + fileName, true);
			return flag;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001BF50 File Offset: 0x0001A150
		public static bool ExportTtfFromZdata(string fileName, string path)
		{
			if (FifaEnvironment.m_FifaFat == null || fileName == null)
			{
				return false;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			string text2 = path + "\\" + fileName;
			if (File.Exists(text))
			{
				if (text != text2)
				{
					File.Copy(text, text2, true);
				}
				return true;
			}
			FifaEnvironment.m_UserMessages.ShowMessage(1028, " " + fileName, true);
			return false;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		public static bool AskAndExportFromZdata(string fileName, ref string path)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = path;
			folderBrowserDialog.Description = "Select the export folder";
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				folderBrowserDialog.Dispose();
				return false;
			}
			path = folderBrowserDialog.SelectedPath;
			folderBrowserDialog.Dispose();
			return FifaEnvironment.ExportFileFromZdata(fileName, path);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001C02C File Offset: 0x0001A22C
		public static bool ImportKitIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, float[] kitPositions)
		{
			if (templateRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateRx3Name;
			string text2 = templateRx3Name;
			string text3 = text;
			if (text3.Contains("2014_"))
			{
				text2 = text2.Replace("2014_", "");
				text3 = text3.Replace("2014_", "");
			}
			if (ids.Length != 0)
			{
				text2 = text2.Replace("#", ids[0].ToString());
				text3 = text3.Replace("#", ids[0].ToString());
			}
			if (ids.Length > 1)
			{
				text2 = text2.Replace("%", ids[1].ToString());
				text3 = text3.Replace("%", ids[1].ToString());
			}
			if (ids.Length > 2)
			{
				text2 = text2.Replace("@", ids[2].ToString());
				text3 = text3.Replace("@", ids[2].ToString());
			}
			else
			{
				text2 = text2.Replace("@", "0");
				text3 = text3.Replace("@", "0");
			}
			if (text != text3)
			{
				File.Copy(text, text3, true);
			}
			KitFile kitFile = new KitFile();
			kitFile.Load(text3);
			if (kitFile.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			kitFile.ReplaceBitmaps(bitmaps);
			kitFile.Positions = kitPositions;
			kitFile.Save(text3, true, false);
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text3, text2, true, ECompressionMode.Chunkzip);
			if (!flag)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10007);
			}
			return flag;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		public static bool ImportBmpsIntoStadium(string stadiumRx3Name, Bitmap[] bitmaps)
		{
			if (stadiumRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_GameDir + stadiumRx3Name;
			if (!File.Exists(text) && !FifaEnvironment.m_FifaFat.ExtractFile(stadiumRx3Name))
			{
				return false;
			}
			Rx3File rx3File = new Rx3File();
			rx3File.Load(text);
			if (rx3File.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			rx3File.ReplaceBitmaps(bitmaps);
			rx3File.Save(text, true, false);
			return true;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001C29C File Offset: 0x0001A49C
		public static bool ImportBmpsIntoZdata(string templateRx3Name, string rx3FileName, Bitmap[] bitmaps, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			if (templateRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateRx3Name;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + rx3FileName;
			if (text != text2)
			{
				File.Copy(text, text2, true);
			}
			Rx3File rx3File = new Rx3File();
			rx3File.Load(text2);
			rx3File.ReplaceBitmaps(bitmaps);
			rx3File.Signatures = signatures;
			rx3File.Save(text2, true, false);
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text2, rx3FileName, true, compressionMode);
			if (!flag)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10007);
			}
			return flag;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001C35C File Offset: 0x0001A55C
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			if (templateRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateRx3Name;
			string text2 = templateRx3Name;
			string text3 = text;
			if (text3.Contains("2014_"))
			{
				text2 = text2.Replace("2014_", "");
				text3 = text3.Replace("2014_", "");
			}
			if (ids.Length != 0)
			{
				text2 = text2.Replace("#", ids[0].ToString());
				text3 = text3.Replace("#", ids[0].ToString());
			}
			if (ids.Length > 1)
			{
				text2 = text2.Replace("%", ids[1].ToString());
				text3 = text3.Replace("%", ids[1].ToString());
			}
			if (text != text3)
			{
				File.Copy(text, text3, true);
			}
			Rx3File rx3File = new Rx3File();
			rx3File.Load(text3);
			if (rx3File.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			rx3File.ReplaceBitmaps(bitmaps);
			rx3File.Signatures = signatures;
			rx3File.Save(text3, true, false);
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text3, text2, true, compressionMode);
			if (!flag)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10007);
			}
			return flag;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001C4C7 File Offset: 0x0001A6C7
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, ids, bitmaps, compressionMode, null);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap bitmap, ECompressionMode compressionMode)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, array, compressionMode, null);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001C504 File Offset: 0x0001A704
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap bitmap, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, array, compressionMode, signatures);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001C534 File Offset: 0x0001A734
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap[] bitmaps, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, bitmaps, compressionMode, null);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001C558 File Offset: 0x0001A758
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap[] bitmaps, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, bitmaps, compressionMode, signatures);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001C57C File Offset: 0x0001A77C
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap bitmap, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, ids, new Bitmap[] { bitmap }, compressionMode, null);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap bitmap, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, ids, new Bitmap[] { bitmap }, compressionMode, signatures);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001C5C3 File Offset: 0x0001A7C3
		public static bool ImportFileIntoZdataAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(fileName, archivedName, delete, compressionMode, null);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		public static bool ImportFileIntoZdataAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (!File.Exists(fileName))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10011);
				return false;
			}
			if (FifaEnvironment.m_UserOptions.m_SaveZdataInFolder)
			{
				string text = FifaEnvironment.m_GameDir + archivedName;
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(fileName, text, true);
				if (signatures != null)
				{
					FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.ReadWrite);
					BinaryWriter binaryWriter = new BinaryWriter(fileStream);
					signatures.Save(binaryWriter);
					binaryWriter.Close();
					fileStream.Close();
				}
				if (delete)
				{
					File.Delete(fileName);
				}
				FifaEnvironment.m_FifaFat.HideFile(archivedName);
				return true;
			}
			return FifaEnvironment.m_FifaFat.ImportFileAs(fileName, archivedName, delete, compressionMode);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		public static bool ImportTtfIntoZdataAs(string fileName, string archivedName, bool delete)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (!File.Exists(fileName))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10011);
				return false;
			}
			if (FifaEnvironment.m_UserOptions.m_SaveZdataInFolder)
			{
				string text = FifaEnvironment.m_GameDir + archivedName;
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(fileName, text, true);
				if (delete)
				{
					File.Delete(fileName);
				}
				FifaEnvironment.m_FifaFat.HideFile(archivedName);
				return true;
			}
			return false;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
		public static bool DeleteFromZdata(string fileName)
		{
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			if (File.Exists(text))
			{
				File.Delete(text);
				FifaEnvironment.m_FifaFat.RestoreFile(fileName);
				return true;
			}
			return FifaEnvironment.m_FifaFat.HideFile(fileName);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001C880 File Offset: 0x0001AA80
		public static bool CloneIntoZdata(string srcFileName, string destFileName)
		{
			string text = FifaEnvironment.m_TempFolder + "\\";
			if (!FifaEnvironment.ExportFileFromZdata(srcFileName, FifaEnvironment.m_TempFolder))
			{
				return false;
			}
			string text2 = text + srcFileName;
			if (!File.Exists(text2))
			{
				return false;
			}
			ECompressionMode compressionMode = FifaEnvironment.m_FifaFat.GetCompressionMode(srcFileName);
			return FifaEnvironment.ImportFileIntoZdataAs(text2, destFileName, true, compressionMode);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001C8DC File Offset: 0x0001AADC
		public static bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			saveFileDialog.InitialDirectory = FifaEnvironment.m_ExportFolder;
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.Title = "Save picture as .bmp or .png";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return false;
			}
			string extension = Path.GetExtension(saveFileDialog.FileName);
			ImageFormat imageFormat;
			if (extension.ToLower() == ".bmp")
			{
				imageFormat = ImageFormat.Bmp;
				Color pixel = bitmap.GetPixel(0, 0);
				for (int i = bitmap.Width - 1; i >= 0; i--)
				{
					for (int j = bitmap.Height - 1; j >= 0; j--)
					{
						if (bitmap.GetPixel(i, j).A < 192)
						{
							bitmap.SetPixel(i, j, pixel);
						}
					}
				}
			}
			else
			{
				if (!(extension.ToLower() == ".png"))
				{
					FifaEnvironment.m_UserMessages.ShowMessage(5034);
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			bitmap.Save(saveFileDialog.FileName, imageFormat);
			saveFileDialog.Dispose();
			return true;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001C9F0 File Offset: 0x0001ABF0
		public static Bitmap BrowseAndCheckBitmap(int width, int height, int sizeMultiplier, int transparentMode)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = FifaEnvironment.m_ExportFolder;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open Image File";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			openFileDialog.Dispose();
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10006);
				return null;
			}
			if (bitmap.Width != width || bitmap.Height != height)
			{
				if (sizeMultiplier != 1)
				{
					if (sizeMultiplier == 2)
					{
						width *= 2;
						height *= 2;
					}
				}
				else
				{
					int num = width;
					width = num + num / 2;
					int num2 = height;
					height = num2 + num2 / 2;
				}
				if (bitmap.Width != width || bitmap.Height != height)
				{
					FifaEnvironment.m_UserMessages.ShowMessage(5015);
					return null;
				}
			}
			if (transparentMode != 0 && Path.GetExtension(fileName).ToLower() == ".bmp")
			{
				Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
				Color pixel = bitmap.GetPixel(0, 0);
				Color color = Color.FromArgb(0, 0, 0, 0);
				for (int i = 0; i < bitmap.Width; i++)
				{
					for (int j = 0; j < bitmap.Height; j++)
					{
						Color pixel2 = bitmap.GetPixel(i, j);
						if (pixel2 == pixel)
						{
							bitmap2.SetPixel(i, j, color);
						}
						else
						{
							bitmap2.SetPixel(i, j, pixel2);
						}
					}
				}
				return bitmap2;
			}
			return bitmap;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		public static string BrowseAndCheckModel(ref string path, string title, string filter)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = path;
			openFileDialog.Filter = filter;
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = title;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			path = Path.GetFullPath(fileName);
			openFileDialog.Dispose();
			return fileName;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001CC18 File Offset: 0x0001AE18
		public static string BrowseAndCheckTtf(ref string path)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = path;
			openFileDialog.Filter = "Font files(*.ttf)|*.ttf";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open font file";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			path = Path.GetFullPath(fileName);
			openFileDialog.Dispose();
			return fileName;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001CC9C File Offset: 0x0001AE9C
		public static void LoadLists(EFifaObjects fifaObjects)
		{
			FifaFat fifaFat = FifaEnvironment.m_FifaFat;
			if (FifaEnvironment.m_FifaDb != null)
			{
				if ((fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RoleList = new RoleList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaFormation) != (EFifaObjects)0)
				{
					FifaEnvironment.s_FormationList = new FormationList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_GenericFormationList = new FormationList();
					foreach (object obj in FifaEnvironment.s_FormationList)
					{
						Formation formation = (Formation)obj;
						if (formation.IsGeneric())
						{
							FifaEnvironment.s_GenericFormationList.Add(formation);
						}
					}
				}
				if ((fifaObjects & EFifaObjects.FifaCountry) != (EFifaObjects)0)
				{
					FifaEnvironment.s_CountryList = new CountryList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaKit) != (EFifaObjects)0)
				{
					FifaEnvironment.s_KitList = new KitList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaReferee) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RefereeList = new RefereeList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
				{
					FifaEnvironment.s_LeagueList = new LeagueList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaTeam) != (EFifaObjects)0)
				{
					FifaEnvironment.s_TeamList = new TeamList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_FreeAgentList = new FreeAgentList();
					FifaEnvironment.s_TeamList.LinkOpponent(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_RefereeList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_RefereeList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_RefereeList != null && FifaEnvironment.s_LeagueList != null)
				{
					FifaEnvironment.s_RefereeList.LinkLeague(FifaEnvironment.s_LeagueList);
				}
				if (FifaEnvironment.s_KitList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_TeamList.LinkKits(FifaEnvironment.s_KitList);
					FifaEnvironment.s_KitList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_LeagueList.FillFromLeagueTeamLinks(FifaEnvironment.m_FifaDb.Table[TI.leagueteamlinks]);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_LeagueList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_BallList != null)
				{
					FifaEnvironment.s_LeagueList.LinkBall(FifaEnvironment.s_BallList);
				}
				if ((fifaObjects & EFifaObjects.FifaPlayer) != (EFifaObjects)0)
				{
					FifaEnvironment.s_PlayerNamesList = new PlayerNames(FifaEnvironment.m_FifaDb);
					if (FifaEnvironment.m_OriginalFifaDb != null)
					{
						FifaEnvironment.s_OriginalPlayerNamesList = new PlayerNames(FifaEnvironment.m_OriginalFifaDb);
					}
					Player.PlayerNames = FifaEnvironment.s_PlayerNamesList;
					FifaEnvironment.s_NameDictionary = new NameDictionary(FifaEnvironment.m_FifaDb);
					CareerFirstName.PlayerNames = FifaEnvironment.s_PlayerNamesList;
					CareerLastName.PlayerNames = FifaEnvironment.s_PlayerNamesList;
					CareerCommonName.PlayerNames = FifaEnvironment.s_PlayerNamesList;
					FifaEnvironment.s_PlayerList = new PlayerList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_CareerFirstNameList = new CareerFirstNameList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_CareerLastNameList = new CareerLastNameList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_CareerCommonNameList = new CareerCommonNameList(FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_PlayerList != null)
				{
					FifaEnvironment.s_TeamList.FillFromTeamPlayerLinks(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_TeamList.LinkPlayer(FifaEnvironment.s_PlayerList);
				}
				if (FifaEnvironment.s_PlayerList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_PlayerList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_PlayerList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_PlayerList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_TeamList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_CountryList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_FormationList != null)
				{
					FifaEnvironment.s_TeamList.LinkFormation(FifaEnvironment.s_FormationList);
					FifaEnvironment.s_FormationList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if ((fifaObjects & EFifaObjects.FifaStadium) != (EFifaObjects)0)
				{
					FifaEnvironment.s_StadiumList = new StadiumList(FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_StadiumList != null)
				{
					FifaEnvironment.s_TeamList.LinkStadiums(FifaEnvironment.s_StadiumList);
					FifaEnvironment.s_StadiumList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_CountryList != null && FifaEnvironment.s_StadiumList != null)
				{
					FifaEnvironment.s_StadiumList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_LeagueList != null)
				{
					FifaEnvironment.s_TeamList.LinkLeague(FifaEnvironment.s_LeagueList);
				}
				if ((fifaObjects & EFifaObjects.FifaTournament) != (EFifaObjects)0)
				{
					FifaEnvironment.s_CompetitionObjects = new CompobjList(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_CompetitionObjects != null)
				{
					FifaEnvironment.s_CompetitionObjects.Link();
				}
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		public static void LoadLists()
		{
			FifaEnvironment.LoadLists(EFifaObjects.FifaAdboard | EFifaObjects.FifaBall | EFifaObjects.FifaColor | EFifaObjects.FifaCountry | EFifaObjects.FifaFormation | EFifaObjects.FifaGrass | EFifaObjects.FifaJerseyFont | EFifaObjects.FifaKit | EFifaObjects.FifaLeague | EFifaObjects.FifaNet | EFifaObjects.FifaPlayer | EFifaObjects.FifaReferee | EFifaObjects.FifaRole | EFifaObjects.FifaShoes | EFifaObjects.FifaShortsFont | EFifaObjects.FifaSponsor | EFifaObjects.FifaStadium | EFifaObjects.FifaTeam | EFifaObjects.FifaTournament | EFifaObjects.FifaReward | EFifaObjects.FifaMowingPattern | EFifaObjects.FifaWeather);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0001D124 File Offset: 0x0001B324
		public static void SaveLists()
		{
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_FormationList != null)
			{
				FifaEnvironment.s_FormationList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CountryList != null)
			{
				FifaEnvironment.s_CountryList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_KitList != null)
			{
				FifaEnvironment.s_KitList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_RefereeList != null)
			{
				FifaEnvironment.s_RefereeList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_LeagueList != null)
			{
				FifaEnvironment.s_LeagueList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_TeamList != null)
			{
				FifaEnvironment.s_TeamList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_PlayerList != null)
			{
				FifaEnvironment.s_PlayerNamesList.ClearUsedFlags();
				FifaEnvironment.s_PlayerList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerFirstNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerLastNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerCommonNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_PlayerNamesList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_NameDictionary.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_StadiumList != null)
			{
				FifaEnvironment.s_StadiumList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CompetitionObjects != null)
			{
				FifaEnvironment.s_CompetitionObjects.Save(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_BallList != null)
			{
				FifaEnvironment.s_BallList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001D294 File Offset: 0x0001B494
		public static void SaveLists(EFifaObjects fifaObjects)
		{
			if (FifaEnvironment.s_RoleList != null && (fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_FormationList != null && (fifaObjects & EFifaObjects.FifaFormation) != (EFifaObjects)0)
			{
				FifaEnvironment.s_FormationList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CountryList != null && (fifaObjects & EFifaObjects.FifaCountry) != (EFifaObjects)0)
			{
				FifaEnvironment.s_CountryList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_KitList != null && (fifaObjects & EFifaObjects.FifaKit) != (EFifaObjects)0)
			{
				FifaEnvironment.s_KitList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_RefereeList != null && (fifaObjects & EFifaObjects.FifaReferee) != (EFifaObjects)0)
			{
				FifaEnvironment.s_RefereeList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_LeagueList != null && (fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
			{
				FifaEnvironment.s_LeagueList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_TeamList != null && (fifaObjects & EFifaObjects.FifaTeam) != (EFifaObjects)0)
			{
				FifaEnvironment.s_TeamList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_PlayerList != null && (fifaObjects & EFifaObjects.FifaPlayer) != (EFifaObjects)0)
			{
				FifaEnvironment.s_PlayerNamesList.ClearUsedFlags();
				FifaEnvironment.s_PlayerList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerFirstNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerLastNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_CareerCommonNameList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_PlayerNamesList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_NameDictionary.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_StadiumList != null && (fifaObjects & EFifaObjects.FifaStadium) != (EFifaObjects)0)
			{
				FifaEnvironment.s_StadiumList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CompetitionObjects != null && (fifaObjects & EFifaObjects.FifaTournament) != (EFifaObjects)0)
			{
				FifaEnvironment.s_CompetitionObjects.Save(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_BallList != null && (fifaObjects & EFifaObjects.FifaBall) != (EFifaObjects)0)
			{
				FifaEnvironment.s_BallList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_ShoesList != null && (fifaObjects & EFifaObjects.FifaShoes) != (EFifaObjects)0)
			{
				FifaEnvironment.s_ShoesList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001D456 File Offset: 0x0001B656
		public static void SaveCareerLists()
		{
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001D470 File Offset: 0x0001B670
		public static ArrayList FindMissedFiles()
		{
			ArrayList arrayList = new ArrayList();
			if (arrayList.Count == 0)
			{
				arrayList.Add("No missed files found.");
			}
			else
			{
				arrayList.Add(arrayList.Count.ToString() + " missed files found.");
			}
			return arrayList;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0001D4B9 File Offset: 0x0001B6B9
		public static void LoadCareerLists(EFifaObjects fifaObjects)
		{
			FifaFat fifaFat = FifaEnvironment.m_FifaFat;
			if (FifaEnvironment.m_CareerFile != null)
			{
				if ((fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RoleList = new RoleList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
				{
					FifaEnvironment.s_LeagueList = new LeagueList(FifaEnvironment.m_FifaDb);
				}
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001D4F4 File Offset: 0x0001B6F4
		public static void ShowOptions()
		{
			if (FifaEnvironment.m_UserOptions.ShowOptions() == DialogResult.OK)
			{
				if (FifaEnvironment.m_UserOptions.m_AutoExportFolder)
				{
					FifaEnvironment.m_ExportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					return;
				}
				FifaEnvironment.m_ExportFolder = FifaEnvironment.m_UserOptions.m_ExportFolder;
			}
		}

		// Token: 0x04000D50 RID: 3408
		private static ToolStripStatusLabel m_Status = null;

		// Token: 0x04000D51 RID: 3409
		private static FifaFat m_FifaFat;

		// Token: 0x04000D52 RID: 3410
		private static CareerFile m_CareerFile;

		// Token: 0x04000D53 RID: 3411
		private static string m_CareerFileName;

		// Token: 0x04000D54 RID: 3412
		private static CareerFile m_TournamentFile;

		// Token: 0x04000D55 RID: 3413
		private static string m_TournamentFileName;

		// Token: 0x04000D56 RID: 3414
		private static CareerFile m_MyTeamsFile;

		// Token: 0x04000D57 RID: 3415
		private static string m_MyTeamsFileName;

		// Token: 0x04000D58 RID: 3416
		private static DbFile m_OriginalFifaDb;

		// Token: 0x04000D59 RID: 3417
		private static bool m_IsRevModInstalled;

		// Token: 0x04000D5A RID: 3418
		private static DbFile m_FifaDb;

		// Token: 0x04000D5B RID: 3419
		private static string m_FifaDbFileName;

		// Token: 0x04000D5C RID: 3420
		private static string m_FifaXmlFileName;

		// Token: 0x04000D5D RID: 3421
		private static string m_FifaDbPartialFileName;

		// Token: 0x04000D5E RID: 3422
		private static string m_FifaXmlPartialFileName;

		// Token: 0x04000D5F RID: 3423
		private static int m_Year;

		// Token: 0x04000D60 RID: 3424
		private static string m_GameKey = null;

		// Token: 0x04000D61 RID: 3425
		private static DbFile m_LangDb;

		// Token: 0x04000D62 RID: 3426
		private static string m_LangDbFileName;

		// Token: 0x04000D63 RID: 3427
		private static string m_LangXmlFileName;

		// Token: 0x04000D64 RID: 3428
		private static Language m_Language = null;

		// Token: 0x04000D65 RID: 3429
		private static string m_RootDir;

		// Token: 0x04000D66 RID: 3430
		private static string m_GameDir;

		// Token: 0x04000D67 RID: 3431
		private static string m_ExportFolder;

		// Token: 0x04000D68 RID: 3432
		private static string m_TempFolder;

		// Token: 0x04000D69 RID: 3433
		private static string m_LaunchDir;

		// Token: 0x04000D6A RID: 3434
		private static UserMessage m_UserMessages;

		// Token: 0x04000D6B RID: 3435
		private static UserOptions m_UserOptions;

		// Token: 0x04000D6C RID: 3436
		private static bool m_NeedToSaveMiniHeads = false;

		// Token: 0x04000D6D RID: 3437
		private static CountryList s_CountryList = null;

		// Token: 0x04000D6E RID: 3438
		private static LeagueList s_LeagueList = null;

		// Token: 0x04000D6F RID: 3439
		private static TeamList s_TeamList = null;

		// Token: 0x04000D70 RID: 3440
		private static FreeAgentList s_FreeAgentList = null;

		// Token: 0x04000D71 RID: 3441
		private static PlayerList s_PlayerList = null;

		// Token: 0x04000D72 RID: 3442
		private static PlayerNames s_OriginalPlayerNamesList = null;

		// Token: 0x04000D73 RID: 3443
		private static PlayerNames s_PlayerNamesList = null;

		// Token: 0x04000D74 RID: 3444
		private static NameDictionary s_NameDictionary = null;

		// Token: 0x04000D75 RID: 3445
		private static CareerFirstNameList s_CareerFirstNameList = null;

		// Token: 0x04000D76 RID: 3446
		private static CareerLastNameList s_CareerLastNameList = null;

		// Token: 0x04000D77 RID: 3447
		private static CareerCommonNameList s_CareerCommonNameList = null;

		// Token: 0x04000D78 RID: 3448
		private static StadiumList s_StadiumList = null;

		// Token: 0x04000D79 RID: 3449
		private static RefereeList s_RefereeList = null;

		// Token: 0x04000D7A RID: 3450
		private static KitList s_KitList = null;

		// Token: 0x04000D7B RID: 3451
		private static CompobjList s_CompetitionObjects = null;

		// Token: 0x04000D7C RID: 3452
		private static FormationList s_FormationList = null;

		// Token: 0x04000D7D RID: 3453
		private static FormationList s_GenericFormationList = null;

		// Token: 0x04000D7E RID: 3454
		private static RoleList s_RoleList = null;

		// Token: 0x04000D7F RID: 3455
		private static BallList s_BallList = null;

		// Token: 0x04000D80 RID: 3456
		private static AdboardList s_AdboardList = null;

		// Token: 0x04000D81 RID: 3457
		private static ShoesList s_ShoesList = null;

		// Token: 0x04000D82 RID: 3458
		private static GkGlovesList s_GkGlovesList = null;

		// Token: 0x04000D83 RID: 3459
		private static NetList s_NetList = null;

		// Token: 0x04000D84 RID: 3460
		private static MowingPatternList s_MowingPatternList = null;

		// Token: 0x04000D85 RID: 3461
		private static NumberFontList s_NumberFontList = null;

		// Token: 0x04000D86 RID: 3462
		private static NameFontList s_NameFontList = null;

		// Token: 0x04000D87 RID: 3463
		private static string[] s_RevModFileNames = new string[]
		{
			"data/fifarna/lua/assets.lua", "data/fifarna/lua/assets/accessory.lua", "data/fifarna/lua/assets/ball.lua", "data/fifarna/lua/assets/cornerflags.lua", "data/fifarna/lua/assets/crowd.lua", "data/fifarna/lua/assets/fancards.lua", "data/fifarna/lua/assets/goalnet.lua", "data/fifarna/lua/assets/grass.lua", "data/fifarna/lua/assets/player.lua", "data/fifarna/lua/assets/rm_common.lua",
			"data/fifarna/lua/assets/sle.lua", "data/fifarna/lua/assets/stadium.lua", "data/fifarna/lua/assets/trophy.lua", "data/fifarna/lua/assets/wipe3D.lua", "data/fifarna/lua/assignments/general.lua", "data/sceneassets/kit/kit_7000_93_0.rx3", "data/sceneassets/kit/kit_7000_94_0.rx3"
		};
	}
}
