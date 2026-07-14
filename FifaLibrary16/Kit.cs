using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200004F RID: 79
	public class Kit : IdObject
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000272DB File Offset: 0x000254DB
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000272E3 File Offset: 0x000254E3
		public float[] Positions
		{
			get
			{
				return this.m_Positions;
			}
			set
			{
				this.m_Positions = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000272EC File Offset: 0x000254EC
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000272F4 File Offset: 0x000254F4
		public bool hasadvertisingkit
		{
			get
			{
				return this.m_hasadvertisingkit;
			}
			set
			{
				this.m_hasadvertisingkit = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000272FD File Offset: 0x000254FD
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00027305 File Offset: 0x00025505
		public bool jerseyBackName
		{
			get
			{
				return this.m_jerseybacknameplacementcode;
			}
			set
			{
				this.m_jerseybacknameplacementcode = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0002730E File Offset: 0x0002550E
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00027316 File Offset: 0x00025516
		public bool jerseyFrontNumber
		{
			get
			{
				return this.m_jerseyfrontnumberplacementcode;
			}
			set
			{
				this.m_jerseyfrontnumberplacementcode = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0002731F File Offset: 0x0002551F
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00027327 File Offset: 0x00025527
		public bool shortsNumber
		{
			get
			{
				return this.m_shortsnumberplacementcode;
			}
			set
			{
				this.m_shortsnumberplacementcode = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00027330 File Offset: 0x00025530
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00027338 File Offset: 0x00025538
		public int jerseyCollar
		{
			get
			{
				return this.m_jerseycollargeometrytype;
			}
			set
			{
				this.m_jerseycollargeometrytype = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00027341 File Offset: 0x00025541
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00027349 File Offset: 0x00025549
		public int jerseyNameFontCase
		{
			get
			{
				return this.m_jerseybacknamefontcase;
			}
			set
			{
				this.m_jerseybacknamefontcase = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00027352 File Offset: 0x00025552
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0002735A File Offset: 0x0002555A
		public int jerseyNameFont
		{
			get
			{
				return this.m_jerseynamefonttype;
			}
			set
			{
				this.m_jerseynamefonttype = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00027363 File Offset: 0x00025563
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0002736B File Offset: 0x0002556B
		public int jerseyNumberFont
		{
			get
			{
				return this.m_numberfonttype;
			}
			set
			{
				this.m_numberfonttype = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00027374 File Offset: 0x00025574
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0002737C File Offset: 0x0002557C
		public int jerseyNumberColor
		{
			get
			{
				return this.m_numbercolor;
			}
			set
			{
				this.m_numbercolor = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00027385 File Offset: 0x00025585
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0002738D File Offset: 0x0002558D
		public int shortsNumberFont
		{
			get
			{
				return this.m_shortsnumberfonttype;
			}
			set
			{
				this.m_shortsnumberfonttype = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00027396 File Offset: 0x00025596
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x0002739E File Offset: 0x0002559E
		public int shortsNumberColor
		{
			get
			{
				return this.m_shortsnumbercolor;
			}
			set
			{
				this.m_shortsnumbercolor = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000273A7 File Offset: 0x000255A7
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000273AF File Offset: 0x000255AF
		public Color JerseyNameColor
		{
			get
			{
				return this.m_JerseyNameColor;
			}
			set
			{
				this.m_JerseyNameColor = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000273B8 File Offset: 0x000255B8
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000273C0 File Offset: 0x000255C0
		public Color TeamColor1
		{
			get
			{
				return this.m_TeamColor1;
			}
			set
			{
				this.m_TeamColor1 = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000273C9 File Offset: 0x000255C9
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000273D1 File Offset: 0x000255D1
		public Color TeamColor2
		{
			get
			{
				return this.m_TeamColor2;
			}
			set
			{
				this.m_TeamColor2 = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000273DA File Offset: 0x000255DA
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000273E2 File Offset: 0x000255E2
		public Color TeamColor3
		{
			get
			{
				return this.m_TeamColor3;
			}
			set
			{
				this.m_TeamColor3 = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000273EB File Offset: 0x000255EB
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x000273F3 File Offset: 0x000255F3
		public int jerseyNameLayout
		{
			get
			{
				return this.m_jerseynamelayouttype;
			}
			set
			{
				this.m_jerseynamelayouttype = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x000273FC File Offset: 0x000255FC
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00027404 File Offset: 0x00025604
		public bool jerseyfit
		{
			get
			{
				return this.m_jerseyfit;
			}
			set
			{
				this.m_jerseyfit = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0002740D File Offset: 0x0002560D
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00027415 File Offset: 0x00025615
		public int year
		{
			get
			{
				return this.m_year;
			}
			set
			{
				this.m_year = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0002741E File Offset: 0x0002561E
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00027426 File Offset: 0x00025626
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
			set
			{
				this.m_teamid = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0002742F File Offset: 0x0002562F
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00027437 File Offset: 0x00025637
		public int kittype
		{
			get
			{
				return this.m_kittype;
			}
			set
			{
				this.m_kittype = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00027440 File Offset: 0x00025640
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00027448 File Offset: 0x00025648
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				if (this.m_Team != null)
				{
					this.m_teamid = this.Team.Id;
				}
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0002746A File Offset: 0x0002566A
		public Kit(int kitid, int teamid, int kittype)
		{
			this.m_teamid = teamid;
			this.m_kittype = kittype;
			base.Id = kitid;
			this.InitNewKit();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0002749A File Offset: 0x0002569A
		public Kit(int kitid)
		{
			this.m_teamid = 0;
			this.m_kittype = 0;
			base.Id = kitid;
			this.InitNewKit();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000274CA File Offset: 0x000256CA
		public Kit(Record r)
		{
			this.Load(r);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000274E8 File Offset: 0x000256E8
		public static void Prepare3DModels()
		{
			if (Kit.s_JerseyWrinkle != null)
			{
				return;
			}
			Kit.s_JerseyWrinkle = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\JerseyBump0.png");
			Kit.s_ShortsWrinkle = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\ShortsBump.png");
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			Rx3File rx3File;
			for (int i = 0; i < Kit.s_JerseyModel3D.Length; i++)
			{
				if (FifaEnvironment.Year == 16)
				{
					rx3File = FifaEnvironment.GetRx3FromZdata("data/sceneassets/body/jersey_1_" + i.ToString() + "_0_0_0_0_0.rx3");
				}
				else
				{
					rx3File = FifaEnvironment.GetRx3FromZdata("data/sceneassets/body/jersey_1_" + i.ToString() + "_0_0_0_0.rx3");
				}
				if (rx3File != null)
				{
					Kit.s_JerseyModel3D[i] = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
				}
			}
			if (FifaEnvironment.Year == 16)
			{
				rx3File = FifaEnvironment.GetRx3FromZdata("data/sceneassets/body/shorts_1_0_0.rx3");
			}
			else
			{
				rx3File = FifaEnvironment.GetRx3FromZdata("\\Templates\\data\\sceneassets\\body\\shorts_1_0.rx3");
			}
			if (rx3File != null)
			{
				Kit.s_ShortsModel3D = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
			}
			if (FifaEnvironment.Year == 16)
			{
				rx3File = FifaEnvironment.GetRx3FromZdata("data/sceneassets/body/sock_1_0_0.rx3");
			}
			else
			{
				rx3File = FifaEnvironment.GetRx3FromZdata("data/sceneassets/body/sock_1_0.rx3");
			}
			if (rx3File != null)
			{
				Kit.s_SocksModel3D = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00027628 File Offset: 0x00025828
		public override string ToString()
		{
			string text;
			if (this.m_Team != null)
			{
				text = this.m_Team.DatabaseName;
			}
			else
			{
				text = "Kit " + this.m_teamid.ToString();
			}
			string text2 = string.Empty;
			int kittype = this.m_kittype;
			if (kittype <= 32)
			{
				switch (kittype)
				{
				case 0:
					text2 = " Home";
					goto IL_00E5;
				case 1:
					text2 = " Away";
					goto IL_00E5;
				case 2:
					text2 = " GK";
					goto IL_00E5;
				case 3:
					text2 = " Third";
					goto IL_00E5;
				case 4:
					break;
				case 5:
					text2 = " Referee";
					goto IL_00E5;
				default:
					switch (kittype)
					{
					case 30:
						text2 = " GK Home";
						goto IL_00E5;
					case 31:
						text2 = " GK Away";
						goto IL_00E5;
					case 32:
						text2 = " GK 3rd";
						goto IL_00E5;
					}
					break;
				}
			}
			else
			{
				if (kittype == 93)
				{
					text2 = " Training Home";
					goto IL_00E5;
				}
				if (kittype == 94)
				{
					text2 = " Training Away";
					goto IL_00E5;
				}
			}
			text2 = " Type" + this.m_kittype.ToString();
			IL_00E5:
			text += text2;
			if (this.m_year != 0)
			{
				text = text + " " + this.year.ToString();
			}
			return text + " (" + base.Id.ToString() + ")";
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00027764 File Offset: 0x00025964
		public static int KitId(int teamid, int kittype)
		{
			return teamid * 10 + kittype;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0002776C File Offset: 0x0002596C
		public void InitNewKit()
		{
			this.m_hasadvertisingkit = true;
			this.m_jerseybacknameplacementcode = true;
			this.m_jerseyfrontnumberplacementcode = false;
			this.m_shortsnumberplacementcode = false;
			this.m_jerseycollargeometrytype = 0;
			this.m_jerseybacknamefontcase = 0;
			this.m_jerseynamefonttype = 0;
			this.m_numberfonttype = 0;
			this.m_numbercolor = 0;
			this.m_shortsnumberfonttype = 0;
			this.m_shortsnumbercolor = 0;
			this.m_jerseynamecolorr = 0;
			this.m_jerseynamecolorg = 0;
			this.m_jerseynamecolorb = 0;
			this.m_teamcolorprimr = 0;
			this.m_teamcolorprimg = 0;
			this.m_teamcolorprimb = 0;
			this.m_teamcolorsecr = 0;
			this.m_teamcolorsecg = 0;
			this.m_teamcolorsecb = 0;
			this.m_teamcolortertr = 0;
			this.m_teamcolortertg = 0;
			this.m_teamcolortertb = 0;
			this.m_isinheritbasedetailmap = 0;
			this.m_jerseyshapestyle = 0;
			this.m_jerseynamelayouttype = 0;
			this.m_jerseyrenderingdetailmaptype = 0;
			this.m_renderingmaterialtype = 0;
			this.m_shortsrenderingdetailmaptype = 0;
			this.m_dlc = 0;
			this.m_jerseyfit = false;
			this.m_year = 0;
			this.m_powid = -1;
			this.m_islocked = 0;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00027868 File Offset: 0x00025A68
		public bool CloneTextures(Kit clone)
		{
			if (clone != null)
			{
				clone.m_KitTextures = null;
				FifaEnvironment.CloneIntoZdata(this.KitTextureFileName(), Kit.KitTextureFileName(clone.teamid, clone.kittype, clone.year));
				FifaEnvironment.CloneIntoZdata(this.MiniKitDdsFileName(), Kit.MiniKitDdsFileName(clone.teamid, clone.kittype, clone.year));
				return true;
			}
			return false;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000278C8 File Offset: 0x00025AC8
		public void Load(Record r)
		{
			base.Id = r.IntField[FI.teamkits_teamkitid];
			this.m_teamid = r.IntField[FI.teamkits_teamtechid];
			this.m_kittype = r.IntField[FI.teamkits_teamkittypetechid];
			if (this.m_kittype > 10)
			{
				this.m_kittype = 10;
			}
			this.m_hasadvertisingkit = r.IntField[FI.teamkits_hasadvertisingkit] != 0;
			this.m_jerseybacknameplacementcode = r.IntField[FI.teamkits_jerseybacknameplacementcode] != 0;
			this.m_jerseyfrontnumberplacementcode = r.IntField[FI.teamkits_jerseyfrontnumberplacementcode] != 0;
			this.m_shortsnumberplacementcode = r.IntField[FI.teamkits_shortsnumberplacementcode] != 0;
			this.m_jerseycollargeometrytype = r.IntField[FI.teamkits_jerseycollargeometrytype];
			this.m_jerseybacknamefontcase = r.IntField[FI.teamkits_jerseybacknamefontcase];
			this.m_jerseynamefonttype = r.IntField[FI.teamkits_jerseynamefonttype];
			this.m_numberfonttype = r.IntField[FI.teamkits_numberfonttype];
			this.m_numbercolor = ((FI.teamkits_numbercolor >= 0) ? r.IntField[FI.teamkits_numbercolor] : 0);
			this.m_shortsnumberfonttype = r.IntField[FI.teamkits_shortsnumberfonttype];
			this.m_shortsnumbercolor = ((FI.teamkits_shortsnumbercolor >= 0) ? r.IntField[FI.teamkits_shortsnumbercolor] : 0);
			this.m_jerseynamecolorr = r.IntField[FI.teamkits_jerseynamecolorr];
			this.m_jerseynamecolorg = r.IntField[FI.teamkits_jerseynamecolorg];
			this.m_jerseynamecolorb = r.IntField[FI.teamkits_jerseynamecolorb];
			this.m_JerseyNameColor = Color.FromArgb(255, this.m_jerseynamecolorr, this.m_jerseynamecolorg, this.m_jerseynamecolorb);
			this.m_teamcolorprimr = r.IntField[FI.teamkits_teamcolorprimr];
			this.m_teamcolorprimg = r.IntField[FI.teamkits_teamcolorprimg];
			this.m_teamcolorprimb = r.IntField[FI.teamkits_teamcolorprimb];
			this.m_teamcolorsecr = r.IntField[FI.teamkits_teamcolorsecr];
			this.m_teamcolorsecg = r.IntField[FI.teamkits_teamcolorsecg];
			this.m_teamcolorsecb = r.IntField[FI.teamkits_teamcolorsecb];
			this.m_teamcolortertr = r.IntField[FI.teamkits_teamcolortertr];
			this.m_teamcolortertg = r.IntField[FI.teamkits_teamcolortertg];
			this.m_teamcolortertb = r.IntField[FI.teamkits_teamcolortertb];
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolorprimr, this.m_teamcolorprimg, this.m_teamcolorprimb);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolorsecr, this.m_teamcolorsecg, this.m_teamcolorsecb);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolortertr, this.m_teamcolortertg, this.m_teamcolortertb);
			this.m_isinheritbasedetailmap = r.IntField[FI.teamkits_isinheritbasedetailmap];
			this.m_jerseyshapestyle = r.IntField[FI.teamkits_jerseyshapestyle];
			this.m_jerseynamelayouttype = r.IntField[FI.teamkits_jerseynamelayouttype];
			this.m_jerseyrenderingdetailmaptype = r.IntField[FI.teamkits_jerseyrenderingdetailmaptype];
			this.m_renderingmaterialtype = r.IntField[FI.teamkits_renderingmaterialtype];
			this.m_shortsrenderingdetailmaptype = r.IntField[FI.teamkits_shortsrenderingdetailmaptype];
			this.m_dlc = r.IntField[FI.teamkits_dlc];
			if (FI.teamkits_jerseyfit >= 0)
			{
				this.m_jerseyfit = r.IntField[FI.teamkits_jerseyfit] != 0;
			}
			this.m_year = r.IntField[FI.teamkits_year];
			this.m_powid = r.IntField[FI.teamkits_powid];
			this.m_islocked = r.IntField[FI.teamkits_islocked];
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00027C38 File Offset: 0x00025E38
		public void LinkTeam(TeamList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			Team team = (Team)kitList.SearchId(this.m_teamid);
			if (team == null)
			{
				return;
			}
			this.m_Team = team;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00027C68 File Offset: 0x00025E68
		public void SaveKit(Record r, int artificialKey)
		{
			r.IntField[FI.teamkits_teamkitid] = artificialKey;
			r.IntField[FI.teamkits_teamtechid] = this.m_teamid;
			r.IntField[FI.teamkits_teamkittypetechid] = this.m_kittype;
			r.IntField[FI.teamkits_hasadvertisingkit] = (this.m_hasadvertisingkit ? 1 : 0);
			r.IntField[FI.teamkits_jerseybacknameplacementcode] = (this.m_jerseybacknameplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_jerseyfrontnumberplacementcode] = (this.m_jerseyfrontnumberplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_shortsnumberplacementcode] = (this.m_shortsnumberplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_jerseycollargeometrytype] = this.m_jerseycollargeometrytype;
			r.IntField[FI.teamkits_jerseybacknamefontcase] = this.m_jerseybacknamefontcase;
			r.IntField[FI.teamkits_jerseynamefonttype] = this.m_jerseynamefonttype;
			r.IntField[FI.teamkits_numberfonttype] = this.m_numberfonttype;
			r.IntField[FI.teamkits_numbercolor] = this.m_numbercolor;
			r.IntField[FI.teamkits_shortsnumberfonttype] = this.m_shortsnumberfonttype;
			r.IntField[FI.teamkits_shortsnumbercolor] = this.m_shortsnumbercolor;
			this.m_jerseynamecolorr = (int)this.m_JerseyNameColor.R;
			this.m_jerseynamecolorg = (int)this.m_JerseyNameColor.G;
			this.m_jerseynamecolorb = (int)this.m_JerseyNameColor.B;
			r.IntField[FI.teamkits_jerseynamecolorr] = this.m_jerseynamecolorr;
			r.IntField[FI.teamkits_jerseynamecolorg] = this.m_jerseynamecolorg;
			r.IntField[FI.teamkits_jerseynamecolorb] = this.m_jerseynamecolorb;
			this.m_teamcolorprimr = (int)this.m_TeamColor1.R;
			this.m_teamcolorprimg = (int)this.m_TeamColor1.G;
			this.m_teamcolorprimb = (int)this.m_TeamColor1.B;
			this.m_teamcolorsecr = (int)this.m_TeamColor2.R;
			this.m_teamcolorsecg = (int)this.m_TeamColor2.G;
			this.m_teamcolorsecb = (int)this.m_TeamColor2.B;
			this.m_teamcolortertr = (int)this.m_TeamColor3.R;
			this.m_teamcolortertg = (int)this.m_TeamColor3.G;
			this.m_teamcolortertb = (int)this.m_TeamColor3.B;
			r.IntField[FI.teamkits_teamcolorprimr] = this.m_teamcolorprimr;
			r.IntField[FI.teamkits_teamcolorprimg] = this.m_teamcolorprimg;
			r.IntField[FI.teamkits_teamcolorprimb] = this.m_teamcolorprimb;
			r.IntField[FI.teamkits_teamcolorsecr] = this.m_teamcolorsecr;
			r.IntField[FI.teamkits_teamcolorsecg] = this.m_teamcolorsecg;
			r.IntField[FI.teamkits_teamcolorsecb] = this.m_teamcolorsecb;
			r.IntField[FI.teamkits_teamcolortertr] = this.m_teamcolortertr;
			r.IntField[FI.teamkits_teamcolortertg] = this.m_teamcolortertg;
			r.IntField[FI.teamkits_teamcolortertb] = this.m_teamcolortertb;
			r.IntField[FI.teamkits_isinheritbasedetailmap] = this.m_isinheritbasedetailmap;
			r.IntField[FI.teamkits_jerseyshapestyle] = this.m_jerseyshapestyle;
			r.IntField[FI.teamkits_jerseynamelayouttype] = this.m_jerseynamelayouttype;
			r.IntField[FI.teamkits_jerseyrenderingdetailmaptype] = this.m_jerseyrenderingdetailmaptype;
			r.IntField[FI.teamkits_renderingmaterialtype] = this.m_renderingmaterialtype;
			r.IntField[FI.teamkits_shortsrenderingdetailmaptype] = this.m_shortsrenderingdetailmaptype;
			r.IntField[FI.teamkits_dlc] = this.m_dlc;
			if (FI.teamkits_jerseyfit >= 0)
			{
				r.IntField[FI.teamkits_jerseyfit] = (this.m_jerseyfit ? 1 : 0);
			}
			r.IntField[FI.teamkits_year] = this.m_year;
			r.IntField[FI.teamkits_islocked] = 0;
			r.IntField[FI.teamkits_powid] = -1;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00027FF2 File Offset: 0x000261F2
		public string MiniKitDdsFileName()
		{
			return Kit.MiniKitDdsFileName(this.m_teamid, this.m_kittype, this.m_year);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002800C File Offset: 0x0002620C
		public static string MiniKitDdsFileName(int teamid, int kittype, int year)
		{
			return string.Concat(new string[]
			{
				"data/ui/imgassets/kits/j",
				kittype.ToString(),
				"_",
				teamid.ToString(),
				"_",
				year.ToString(),
				".dds"
			});
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00028062 File Offset: 0x00026262
		public string MiniKitTemplateFileName()
		{
			return "data/ui/imgassets/kits/j#_%_0.dds";
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00028069 File Offset: 0x00026269
		public Bitmap GetMiniKit()
		{
			return FifaEnvironment.GetDdsArtasset(this.MiniKitDdsFileName());
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00028076 File Offset: 0x00026276
		public Bitmap GetMiniKit(int kitType)
		{
			return FifaEnvironment.GetDdsArtasset(Kit.MiniKitDdsFileName(this.m_teamid, kitType, 0));
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002808C File Offset: 0x0002628C
		public bool SetMiniKit(Bitmap bitmap)
		{
			int[] array = new int[] { this.m_kittype, this.m_teamid };
			string[] array2 = new string[]
			{
				string.Empty,
				string.Empty
			};
			return FifaEnvironment.SetDdsArtasset(this.MiniKitTemplateFileName(), array, bitmap, array2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000280D7 File Offset: 0x000262D7
		public bool DeleteMiniKit()
		{
			return FifaEnvironment.DeleteFromZdata(this.MiniKitDdsFileName());
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000280E4 File Offset: 0x000262E4
		public string KitTextureFileName()
		{
			return Kit.KitTextureFileName(this.m_teamid, this.m_kittype, this.m_year);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00028100 File Offset: 0x00026300
		public static string KitTextureFileName(int teamid, int kittype, int year)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/kit/kit_",
				teamid.ToString(),
				"_",
				kittype.ToString(),
				"_",
				year.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00028156 File Offset: 0x00026356
		public string KitTextureTemplateName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data\\sceneassets\\kit\\2014_kit_#_%_@.rx3";
			}
			return "data\\sceneassets\\kit\\kit_#_%_@.rx3";
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002816C File Offset: 0x0002636C
		public Bitmap[] GetKitTextures()
		{
			if (this.m_KitTextures != null)
			{
				return this.m_KitTextures;
			}
			string text = this.KitTextureFileName();
			this.m_KitTextures = FifaEnvironment.GetKitFromRx3(text, out this.m_Positions);
			return this.m_KitTextures;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000281A8 File Offset: 0x000263A8
		public bool SetKitTextures(Bitmap[] bitmaps)
		{
			this.m_KitTextures = bitmaps;
			int[] array = new int[] { this.m_teamid, this.m_kittype, this.m_year };
			return FifaEnvironment.ImportKitIntoZdata(this.KitTextureTemplateName(), array, bitmaps, this.m_Positions);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000281F1 File Offset: 0x000263F1
		public bool SetKitTextures(string rx3FileName)
		{
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.KitTextureFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.m_KitTextures = null;
				this.GetKitTextures();
			}
			return flag;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00028212 File Offset: 0x00026412
		public bool DeleteKitTextures()
		{
			bool flag = FifaEnvironment.DeleteFromZdata(this.KitTextureFileName());
			if (flag)
			{
				this.m_KitTextures = null;
			}
			return flag;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0002822C File Offset: 0x0002642C
		public void DisposeKitTextures()
		{
			if (this.m_KitTextures != null)
			{
				for (int i = 0; i < this.m_KitTextures.Length; i++)
				{
					if (this.m_KitTextures[i] != null)
					{
						this.m_KitTextures[i].Dispose();
					}
				}
				this.m_KitTextures = null;
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00028272 File Offset: 0x00026472
		public bool ImportKitTextures(string rx3FileName)
		{
			return this.SetKitTextures(rx3FileName);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002827B File Offset: 0x0002647B
		public bool ExportKitTextures(string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(this.KitTextureFileName(), exportDir);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00028289 File Offset: 0x00026489
		public Bitmap[] GetJerseyFont()
		{
			return NumberFont.GetNumberFont(this.m_numberfonttype, this.m_numbercolor);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0002829C File Offset: 0x0002649C
		public bool SetJerseyFont(Bitmap[] bitmaps)
		{
			return NumberFont.SetNumberFont(this.m_numberfonttype, this.m_numbercolor, bitmaps);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000282B0 File Offset: 0x000264B0
		public bool SetJerseyFont(string rx3FileName)
		{
			return NumberFont.SetNumberFont(this.m_numberfonttype, this.m_numbercolor, rx3FileName);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000282C4 File Offset: 0x000264C4
		public bool DeleteJerseyFont()
		{
			return NumberFont.Delete(this.m_numberfonttype, this.m_numbercolor);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000282D7 File Offset: 0x000264D7
		public static Bitmap ApplyJerseyShadowedTexture(Bitmap originalTexture)
		{
			if (Kit.s_JerseyShadow == null)
			{
				Kit.s_JerseyShadow = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\JerseyShadow.png");
			}
			if (Kit.s_JerseyShadow == null)
			{
				return originalTexture;
			}
			return GraphicUtil.EmbossBitmap(originalTexture, Kit.s_JerseyShadow);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0002830D File Offset: 0x0002650D
		public static Bitmap ApplyShortsShadowedTexture(Bitmap originalTexture)
		{
			if (Kit.s_ShortsShadow == null)
			{
				Kit.s_ShortsShadow = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\ShortsShadow.png");
			}
			if (Kit.s_ShortsShadow == null)
			{
				return originalTexture;
			}
			return GraphicUtil.EmbossBitmap(originalTexture, Kit.s_ShortsShadow);
		}

		// Token: 0x04000E33 RID: 3635
		public static Bitmap s_JerseyWrinkle = null;

		// Token: 0x04000E34 RID: 3636
		public static Bitmap s_ShortsWrinkle = null;

		// Token: 0x04000E35 RID: 3637
		public static Model3D[] s_JerseyModel3D = new Model3D[22];

		// Token: 0x04000E36 RID: 3638
		public static Model3D s_ShortsModel3D = null;

		// Token: 0x04000E37 RID: 3639
		public static Model3D s_SocksModel3D = null;

		// Token: 0x04000E38 RID: 3640
		private float[] m_Positions = new float[32];

		// Token: 0x04000E39 RID: 3641
		private Bitmap[] m_KitTextures;

		// Token: 0x04000E3A RID: 3642
		private bool m_hasadvertisingkit;

		// Token: 0x04000E3B RID: 3643
		private bool m_jerseybacknameplacementcode;

		// Token: 0x04000E3C RID: 3644
		private bool m_jerseyfrontnumberplacementcode;

		// Token: 0x04000E3D RID: 3645
		private bool m_shortsnumberplacementcode;

		// Token: 0x04000E3E RID: 3646
		private int m_jerseycollargeometrytype;

		// Token: 0x04000E3F RID: 3647
		private int m_jerseybacknamefontcase;

		// Token: 0x04000E40 RID: 3648
		private int m_jerseynamefonttype;

		// Token: 0x04000E41 RID: 3649
		private int m_numberfonttype;

		// Token: 0x04000E42 RID: 3650
		private int m_numbercolor;

		// Token: 0x04000E43 RID: 3651
		private int m_shortsnumberfonttype;

		// Token: 0x04000E44 RID: 3652
		private int m_shortsnumbercolor;

		// Token: 0x04000E45 RID: 3653
		private int m_jerseynamecolorr;

		// Token: 0x04000E46 RID: 3654
		private int m_jerseynamecolorg;

		// Token: 0x04000E47 RID: 3655
		private int m_jerseynamecolorb;

		// Token: 0x04000E48 RID: 3656
		private Color m_JerseyNameColor;

		// Token: 0x04000E49 RID: 3657
		private int m_teamcolorprimr;

		// Token: 0x04000E4A RID: 3658
		private int m_teamcolorprimg;

		// Token: 0x04000E4B RID: 3659
		private int m_teamcolorprimb;

		// Token: 0x04000E4C RID: 3660
		private int m_teamcolorsecr;

		// Token: 0x04000E4D RID: 3661
		private int m_teamcolorsecg;

		// Token: 0x04000E4E RID: 3662
		private int m_teamcolorsecb;

		// Token: 0x04000E4F RID: 3663
		private int m_teamcolortertr;

		// Token: 0x04000E50 RID: 3664
		private int m_teamcolortertg;

		// Token: 0x04000E51 RID: 3665
		private int m_teamcolortertb;

		// Token: 0x04000E52 RID: 3666
		private Color m_TeamColor1;

		// Token: 0x04000E53 RID: 3667
		private Color m_TeamColor2;

		// Token: 0x04000E54 RID: 3668
		private Color m_TeamColor3;

		// Token: 0x04000E55 RID: 3669
		private int m_jerseynamelayouttype;

		// Token: 0x04000E56 RID: 3670
		private int m_isinheritbasedetailmap;

		// Token: 0x04000E57 RID: 3671
		private int m_jerseyshapestyle;

		// Token: 0x04000E58 RID: 3672
		private int m_jerseyrenderingdetailmaptype;

		// Token: 0x04000E59 RID: 3673
		private int m_renderingmaterialtype;

		// Token: 0x04000E5A RID: 3674
		private int m_shortsrenderingdetailmaptype;

		// Token: 0x04000E5B RID: 3675
		private int m_dlc;

		// Token: 0x04000E5C RID: 3676
		private bool m_jerseyfit;

		// Token: 0x04000E5D RID: 3677
		private int m_year;

		// Token: 0x04000E5E RID: 3678
		private int m_powid;

		// Token: 0x04000E5F RID: 3679
		private int m_islocked;

		// Token: 0x04000E60 RID: 3680
		private int m_teamid;

		// Token: 0x04000E61 RID: 3681
		private int m_kittype;

		// Token: 0x04000E62 RID: 3682
		private Team m_Team;

		// Token: 0x04000E63 RID: 3683
		private static Bitmap s_JerseyShadow = null;

		// Token: 0x04000E64 RID: 3684
		private static Bitmap s_ShortsShadow = null;
	}
}
