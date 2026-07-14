using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200006E RID: 110
	public class Referee : IdObject
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x000377F4 File Offset: 0x000359F4
		public Bitmap EyesTextureBitmap
		{
			get
			{
				return this.m_EyesTextureBitmap;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x000377FC File Offset: 0x000359FC
		public Bitmap FaceTextureBitmap
		{
			get
			{
				return this.m_FaceTextureBitmap;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00037804 File Offset: 0x00035A04
		public Bitmap HairColorTextureBitmap
		{
			get
			{
				return this.m_HairColorTextureBitmap;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0003780C File Offset: 0x00035A0C
		public Bitmap HairAlfaTextureBitmap
		{
			get
			{
				return this.m_HairAlfaTextureBitmap;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00037814 File Offset: 0x00035A14
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0003781C File Offset: 0x00035A1C
		public string firstname
		{
			get
			{
				return this.m_firstname;
			}
			set
			{
				this.m_firstname = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00037825 File Offset: 0x00035A25
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x0003782D File Offset: 0x00035A2D
		public string surname
		{
			get
			{
				return this.m_surname;
			}
			set
			{
				this.m_surname = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00037836 File Offset: 0x00035A36
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0003783E File Offset: 0x00035A3E
		public DateTime birthdate
		{
			get
			{
				return this.m_birthdate;
			}
			set
			{
				this.m_birthdate = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00037847 File Offset: 0x00035A47
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0003784F File Offset: 0x00035A4F
		public bool Female
		{
			get
			{
				return this.m_gender;
			}
			set
			{
				this.m_gender = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00037858 File Offset: 0x00035A58
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00037863 File Offset: 0x00035A63
		public bool Male
		{
			get
			{
				return !this.m_gender;
			}
			set
			{
				this.m_gender = !value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0003786F File Offset: 0x00035A6F
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00037877 File Offset: 0x00035A77
		public int nationalitycode
		{
			get
			{
				return this.m_nationalitycode;
			}
			set
			{
				this.m_nationalitycode = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00037880 File Offset: 0x00035A80
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00037888 File Offset: 0x00035A88
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				if (this.m_Country != null)
				{
					this.m_nationalitycode = this.m_Country.Id;
				}
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x000378AA File Offset: 0x00035AAA
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x000378B2 File Offset: 0x00035AB2
		public int[] leagueids
		{
			get
			{
				return this.m_leagueids;
			}
			set
			{
				this.m_leagueids = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x000378BB File Offset: 0x00035ABB
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000378C3 File Offset: 0x00035AC3
		public League[] Leagues
		{
			get
			{
				return this.m_Leagues;
			}
			set
			{
				this.m_Leagues = value;
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000378CC File Offset: 0x00035ACC
		public void SetLeague(int id)
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] == id)
				{
					return;
				}
			}
			for (int j = 0; j < this.m_Leagues.Length; j++)
			{
				if (this.m_leagueids[j] == 0)
				{
					this.m_leagueids[j] = id;
					return;
				}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00037920 File Offset: 0x00035B20
		public int CntLeagues()
		{
			int num = 0;
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00037954 File Offset: 0x00035B54
		public int GetMainLeague()
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					return this.m_leagueids[i];
				}
			}
			return 1;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00037988 File Offset: 0x00035B88
		public bool IsInLeague(League league)
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.Leagues[i] == league)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x000379B6 File Offset: 0x00035BB6
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x000379BE File Offset: 0x00035BBE
		public int height
		{
			get
			{
				return this.m_height;
			}
			set
			{
				this.m_height = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x000379C7 File Offset: 0x00035BC7
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x000379CF File Offset: 0x00035BCF
		public int weight
		{
			get
			{
				return this.m_weight;
			}
			set
			{
				this.m_weight = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x000379D8 File Offset: 0x00035BD8
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x000379E0 File Offset: 0x00035BE0
		public int eyecolorcode
		{
			get
			{
				return this.m_eyecolorcode;
			}
			set
			{
				this.m_eyecolorcode = value;
				this.m_EyesTextureBitmap = null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x000379F0 File Offset: 0x00035BF0
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x000379F8 File Offset: 0x00035BF8
		public int eyebrowcode
		{
			get
			{
				return this.m_eyebrowcode;
			}
			set
			{
				this.m_eyebrowcode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00037A08 File Offset: 0x00035C08
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00037A10 File Offset: 0x00035C10
		public int stylecode
		{
			get
			{
				return this.m_stylecode;
			}
			set
			{
				this.m_stylecode = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00037A19 File Offset: 0x00035C19
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00037A21 File Offset: 0x00035C21
		public int cardstrictness
		{
			get
			{
				return this.m_cardstrictness;
			}
			set
			{
				this.m_cardstrictness = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00037A2A File Offset: 0x00035C2A
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00037A32 File Offset: 0x00035C32
		public int foulstrictness
		{
			get
			{
				return this.m_foulstrictness;
			}
			set
			{
				this.m_foulstrictness = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00037A3B File Offset: 0x00035C3B
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00037A43 File Offset: 0x00035C43
		public int bodytypecode
		{
			get
			{
				return this.m_bodytypecode;
			}
			set
			{
				this.m_bodytypecode = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00037A4C File Offset: 0x00035C4C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00037A54 File Offset: 0x00035C54
		public int hairtypecode
		{
			get
			{
				return this.m_hairtypecode;
			}
			set
			{
				this.m_hairtypecode = value;
				this.m_HairModelFile = null;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00037A64 File Offset: 0x00035C64
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00037A6C File Offset: 0x00035C6C
		public int headtypecode
		{
			get
			{
				return this.m_headtypecode;
			}
			set
			{
				this.m_headtypecode = value;
				this.m_HeadModelFile = null;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00037A7C File Offset: 0x00035C7C
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00037A84 File Offset: 0x00035C84
		public int haircolorcode
		{
			get
			{
				return this.m_haircolorcode;
			}
			set
			{
				this.m_haircolorcode = value;
				this.m_HairColorTextureBitmap = null;
				this.m_HairAlfaTextureBitmap = null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00037A9B File Offset: 0x00035C9B
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00037AA3 File Offset: 0x00035CA3
		public int facialhairtypecode
		{
			get
			{
				return this.m_facialhairtypecode;
			}
			set
			{
				this.m_facialhairtypecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00037AB3 File Offset: 0x00035CB3
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00037ABB File Offset: 0x00035CBB
		public int facialhaircolorcode
		{
			get
			{
				return this.m_facialhaircolorcode;
			}
			set
			{
				this.m_facialhaircolorcode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00037ACB File Offset: 0x00035CCB
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00037AD3 File Offset: 0x00035CD3
		public int sideburnscode
		{
			get
			{
				return this.m_sideburnscode;
			}
			set
			{
				this.m_sideburnscode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00037AE3 File Offset: 0x00035CE3
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00037AEB File Offset: 0x00035CEB
		public int skintypecode
		{
			get
			{
				return this.m_skintypecode;
			}
			set
			{
				this.m_skintypecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00037AFB File Offset: 0x00035CFB
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00037B03 File Offset: 0x00035D03
		public int skintonecode
		{
			get
			{
				return this.m_skintonecode;
			}
			set
			{
				this.m_skintonecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00037B13 File Offset: 0x00035D13
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x00037B1B File Offset: 0x00035D1B
		public int jerseysleevelengthcode
		{
			get
			{
				return this.m_jerseysleevelengthcode;
			}
			set
			{
				this.m_jerseysleevelengthcode = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00037B24 File Offset: 0x00035D24
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00037B2C File Offset: 0x00035D2C
		public int shoedesigncode
		{
			get
			{
				return this.m_shoedesigncode;
			}
			set
			{
				this.m_shoedesigncode = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00037B35 File Offset: 0x00035D35
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00037B3D File Offset: 0x00035D3D
		public int shoecolorcode1
		{
			get
			{
				return this.m_shoecolorcode1;
			}
			set
			{
				this.m_shoecolorcode1 = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00037B46 File Offset: 0x00035D46
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00037B4E File Offset: 0x00035D4E
		public int shoecolorcode2
		{
			get
			{
				return this.m_shoecolorcode2;
			}
			set
			{
				this.m_shoecolorcode2 = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00037B57 File Offset: 0x00035D57
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00037B5F File Offset: 0x00035D5F
		public int shoetypecode
		{
			get
			{
				return this.m_shoetypecode;
			}
			set
			{
				this.m_shoetypecode = value;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00037B68 File Offset: 0x00035D68
		public Referee(Record r)
			: base(r.IntField[FI.referee_refereeid])
		{
			this.Load(r);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00037BE0 File Offset: 0x00035DE0
		public Referee(int refereeid)
			: base(refereeid)
		{
			int newRefereeHeadId = FifaEnvironment.Referees.GetNewRefereeHeadId();
			this.m_refereeheadid_unused = ((newRefereeHeadId > -1000) ? (-1000) : newRefereeHeadId);
			this.m_firstname = "";
			this.m_surname = "Referee " + base.Id.ToString();
			this.m_birthdate = new DateTime(1970, 6, 15);
			this.m_nationalitycode = 0;
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				this.m_leagueids[i] = 0;
				this.m_Leagues[i] = null;
			}
			this.m_height = 180;
			this.m_weight = 75;
			this.m_bodytypecode = 1;
			this.m_shoedesigncode = 0;
			this.m_shoecolorcode1 = 30;
			this.m_shoecolorcode2 = 31;
			this.m_shoetypecode = 72;
			this.m_jerseysleevelengthcode = 0;
			this.m_eyecolorcode = 1;
			this.m_eyebrowcode = 0;
			this.m_facialhairtypecode = 0;
			this.m_facialhaircolorcode = 0;
			this.m_hairtypecode = 0;
			this.m_haircolorcode = 0;
			this.m_headtypecode = 1;
			this.m_headclasscode = 1;
			this.m_sideburnscode = 0;
			this.m_skintypecode = 0;
			this.m_skintonecode = 2;
			this.m_gender = false;
			this.m_stylecode = 1;
			this.m_cardstrictness = 1;
			this.m_foulstrictness = 1;
			this.m_homecitycode = 5;
			this.m_sockheightcode = 0;
			this.m_haireffecttypecode = 0;
			this.m_hairlinecode = 0;
			this.m_hairpartcode = 0;
			this.m_hairstateid = 0;
			this.m_hairvariationid = 0;
			this.m_sweatid = 0;
			this.m_wrinkleid = 0;
			this.m_proxyhaircolorid = 1;
			this.m_proxyheadclass = 1;
			this.m_isreal = 0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00037DCC File Offset: 0x00035FCC
		public void Load(Record r)
		{
			this.m_firstname = r.StringField[FI.referee_firstname];
			this.m_surname = r.StringField[FI.referee_surname];
			this.m_nationalitycode = r.GetAndCheckIntField(FI.referee_nationalitycode);
			int andCheckIntField = r.GetAndCheckIntField(FI.referee_leagueid);
			this.SetLeague(andCheckIntField);
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.referee_birthdate));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_height = r.GetAndCheckIntField(FI.referee_height);
			this.m_weight = r.GetAndCheckIntField(FI.referee_weight);
			this.m_bodytypecode = r.GetAndCheckIntField(FI.referee_bodytypecode) - 1;
			this.m_shoedesigncode = r.GetAndCheckIntField(FI.referee_shoedesigncode);
			this.m_shoecolorcode1 = r.GetAndCheckIntField(FI.referee_shoecolorcode1);
			this.m_shoecolorcode2 = r.GetAndCheckIntField(FI.referee_shoecolorcode2);
			this.m_shoetypecode = r.GetAndCheckIntField(FI.referee_shoetypecode);
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(FI.referee_jerseysleevelengthcode);
			this.m_eyecolorcode = r.GetAndCheckIntField(FI.referee_eyecolorcode);
			this.m_eyebrowcode = r.GetAndCheckIntField(FI.referee_eyebrowcode);
			this.m_facialhairtypecode = r.GetAndCheckIntField(FI.referee_facialhairtypecode);
			this.m_facialhaircolorcode = r.GetAndCheckIntField(FI.referee_facialhaircolorcode);
			this.m_hairtypecode = r.GetAndCheckIntField(FI.referee_hairtypecode);
			this.m_haircolorcode = r.GetAndCheckIntField(FI.referee_haircolorcode);
			this.m_headtypecode = r.GetAndCheckIntField(FI.referee_headtypecode);
			this.m_headclasscode = r.GetAndCheckIntField(FI.referee_headclasscode);
			this.m_sideburnscode = r.GetAndCheckIntField(FI.referee_sideburnscode);
			this.m_skintypecode = r.GetAndCheckIntField(FI.referee_skintypecode);
			this.m_skintonecode = r.GetAndCheckIntField(FI.referee_skintonecode);
			this.m_stylecode = r.GetAndCheckIntField(FI.referee_stylecode);
			this.m_cardstrictness = r.GetAndCheckIntField(FI.referee_cardstrictness);
			this.m_foulstrictness = r.GetAndCheckIntField(FI.referee_foulstrictness);
			this.m_homecitycode = r.GetAndCheckIntField(FI.referee_homecitycode);
			this.m_sockheightcode = r.GetAndCheckIntField(FI.referee_sockheightcode);
			this.m_haireffecttypecode = r.GetAndCheckIntField(FI.referee_haireffecttypecode);
			this.m_hairlinecode = r.GetAndCheckIntField(FI.referee_hairlinecode);
			this.m_hairpartcode = r.GetAndCheckIntField(FI.referee_hairpartcode);
			this.m_hairstateid = r.GetAndCheckIntField(FI.referee_hairstateid);
			this.m_hairvariationid = r.GetAndCheckIntField(FI.referee_hairvariationid);
			this.m_sweatid = r.GetAndCheckIntField(FI.referee_sweatid);
			this.m_wrinkleid = r.GetAndCheckIntField(FI.referee_wrinkleid);
			this.m_proxyhaircolorid = r.GetAndCheckIntField(FI.referee_proxyhaircolorid);
			this.m_proxyheadclass = r.GetAndCheckIntField(FI.referee_proxyheadclass);
			this.m_gender = r.GetAndCheckIntField(FI.referee_gender) != 0;
			if (FI.referee_isreal >= 0)
			{
				this.m_isreal = r.GetAndCheckIntField(FI.referee_isreal);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000380B8 File Offset: 0x000362B8
		public void FillFromLeagueRefereeLinks(Record r)
		{
			int andCheckIntField = r.GetAndCheckIntField(FI.leaguerefereelinks_leagueid);
			this.SetLeague(andCheckIntField);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000380D8 File Offset: 0x000362D8
		public override string ToString()
		{
			return this.m_surname + " " + this.m_firstname;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000380F0 File Offset: 0x000362F0
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_nationalitycode);
			if (this.m_Country == null)
			{
				if (countryList.Count > 0)
				{
					this.m_Country = (Country)countryList[0];
					this.m_nationalitycode = this.m_Country.Id;
					return;
				}
				this.m_nationalitycode = 0;
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00038154 File Offset: 0x00036354
		public void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					this.m_Leagues[i] = (League)leagueList.SearchId(this.m_leagueids[i]);
					if (this.m_Leagues[i] == null)
					{
						this.m_leagueids[i] = 0;
						this.m_Leagues[i] = null;
					}
				}
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000381B9 File Offset: 0x000363B9
		public string GenericHairModelFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000381D8 File Offset: 0x000363D8
		public string GenericFaceTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/faces/face_0_1_0_",
				this.m_eyebrowcode.ToString(),
				"_",
				this.m_sideburnscode.ToString(),
				"_",
				this.m_facialhaircolorcode.ToString(),
				"_",
				this.m_facialhairtypecode.ToString(),
				"_",
				this.m_skintypecode.ToString(),
				"_",
				this.m_skintonecode.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00038281 File Offset: 0x00036481
		public string GenericHeadModelFileName()
		{
			return "data/sceneassets/heads/head_" + this.m_headtypecode.ToString() + "_1.rx3";
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000382A0 File Offset: 0x000364A0
		public override IdObject Clone(int refereeid)
		{
			Referee referee = (Referee)base.Clone(refereeid);
			if (referee == null)
			{
				return null;
			}
			referee.m_refereeheadid_unused = this.m_refereeheadid_unused;
			referee.m_firstname = "";
			referee.m_surname = "Referee " + referee.Id.ToString();
			return referee;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000382F5 File Offset: 0x000364F5
		public void CleanFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				this.m_FaceTextureBitmap.Dispose();
			}
			this.m_FaceTextureBitmap = null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00038311 File Offset: 0x00036511
		public Bitmap GetFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				return this.m_FaceTextureBitmap;
			}
			this.m_FaceTextureBitmap = this.BuildGenericFaceTexture();
			return this.m_FaceTextureBitmap;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00038334 File Offset: 0x00036534
		private Bitmap BuildGenericFaceTexture()
		{
			Bitmap bitmap = FifaEnvironment.GetBmpFromRx3(Player.GenericSkinTextureFileName(this.m_skintonecode, this.m_skintypecode));
			if (bitmap == null)
			{
				return null;
			}
			Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
			Bitmap bitmap2 = FifaEnvironment.GetBmpFromRx3(Player.GenericBearTextureFileName(this.m_skintonecode, this.m_facialhairtypecode, this.m_facialhaircolorcode));
			if (bitmap2 == null)
			{
				return null;
			}
			bitmap = GraphicUtil.Overlap(bitmap, bitmap2, rectangle);
			bitmap2 = FifaEnvironment.GetBmpFromRx3(Player.GenericBrowTextureFileName(this.m_skintonecode, this.m_eyebrowcode, this.m_facialhaircolorcode));
			if (bitmap2 == null)
			{
				return null;
			}
			return GraphicUtil.Overlap(bitmap, bitmap2, rectangle);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000383C9 File Offset: 0x000365C9
		public string GenericEyesTextureFileName()
		{
			return "data/sceneassets/heads/eyes_" + this.m_eyecolorcode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000383E8 File Offset: 0x000365E8
		public Bitmap GetEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				return this.m_EyesTextureBitmap;
			}
			string text = this.GenericEyesTextureFileName();
			this.m_EyesTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_EyesTextureBitmap;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00038420 File Offset: 0x00036620
		public void CleanEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				this.m_EyesTextureBitmap.Dispose();
			}
			this.m_EyesTextureBitmap = null;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0003843C File Offset: 0x0003663C
		public string GenericHairColorTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/hair/haircolour_",
				this.m_hairtypecode.ToString(),
				"_0_",
				this.m_haircolorcode.ToString(),
				"_0_1_textures.rx3"
			});
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00038488 File Offset: 0x00036688
		public void CleanHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				this.m_HairColorTextureBitmap.Dispose();
			}
			this.m_HairColorTextureBitmap = null;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000384A4 File Offset: 0x000366A4
		public Bitmap GetHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				return this.m_HairColorTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairColorTextureBitmap;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000384C2 File Offset: 0x000366C2
		public string GenericHairTexturesFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000384E0 File Offset: 0x000366E0
		public Bitmap[] GetHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null)
			{
				return new Bitmap[] { this.m_HairAlfaTextureBitmap, this.m_HairColorTextureBitmap };
			}
			Bitmap[] bmpsFromRx = FifaEnvironment.GetBmpsFromRx3(this.GenericHairTexturesFileName());
			this.m_HairAlfaTextureBitmap = bmpsFromRx[0];
			this.m_HairColorTextureBitmap = GraphicUtil.MultiplyColorToBitmap(bmpsFromRx[1], Player.s_GenericColors[this.m_haircolorcode], Player.s_GenericColorsDivisor, false);
			return bmpsFromRx;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00038552 File Offset: 0x00036752
		public void CleanHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				this.m_HairAlfaTextureBitmap.Dispose();
			}
			this.m_HairAlfaTextureBitmap = null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0003856E File Offset: 0x0003676E
		public Bitmap GetHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				return this.m_HairAlfaTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairAlfaTextureBitmap;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0003858C File Offset: 0x0003678C
		public void CleanHairTextures()
		{
			this.CleanHairColorTexture();
			this.CleanHairAlfaTexture();
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0003859A File Offset: 0x0003679A
		public string GenericHairAlfaTextureFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_0_1_textures.rx3";
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000385B6 File Offset: 0x000367B6
		public Rx3File GetHeadModel()
		{
			if (this.m_HeadModelFile != null)
			{
				return this.m_HeadModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHeadModelFileName());
			return this.m_HeadModelFile;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000385E4 File Offset: 0x000367E4
		public void CleanHeadModel()
		{
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000385ED File Offset: 0x000367ED
		public void CleanHead()
		{
			this.CleanFaceTexture();
			this.CleanEyesTexture();
			this.CleanHeadModel();
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00038601 File Offset: 0x00036801
		public Rx3File GetHairModel()
		{
			if (this.m_HairModelFile != null)
			{
				return this.m_HairModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHairModelFileName());
			return this.m_HairModelFile;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0003862F File Offset: 0x0003682F
		public void CleanHairModel()
		{
			this.m_HairModelFile = null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00038638 File Offset: 0x00036838
		public void CleanHair()
		{
			this.CleanHairModel();
			this.CleanHairTextures();
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00038646 File Offset: 0x00036846
		public void CleanAllHead()
		{
			this.CleanHair();
			this.CleanHead();
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00038654 File Offset: 0x00036854
		public static string PhotoBigFileName(int refereeId)
		{
			return "data/ui/artassets/referee/ref_" + refereeId.ToString() + ".big";
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0003866C File Offset: 0x0003686C
		public string PhotoBigFileName()
		{
			return Referee.PhotoBigFileName(base.Id);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00038679 File Offset: 0x00036879
		public string PhotoTemplateFileName()
		{
			return "data/ui/artassets/referee/ref_#.big";
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000027B4 File Offset: 0x000009B4
		public string PhotoDdsFileName()
		{
			return "2";
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00038680 File Offset: 0x00036880
		public Bitmap GetPhoto()
		{
			return FifaEnvironment.GetArtasset(this.PhotoBigFileName());
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0003868D File Offset: 0x0003688D
		public bool SetPhoto(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(this.PhotoTemplateFileName(), this.PhotoDdsFileName(), base.Id, bitmap);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000386A7 File Offset: 0x000368A7
		public bool DeletePhoto()
		{
			return FifaEnvironment.DeleteFromZdata(this.PhotoBigFileName());
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000386B4 File Offset: 0x000368B4
		public void SaveReferee(Record r)
		{
			r.IntField[FI.referee_refereeid] = base.Id;
			r.IntField[FI.referee_birthdate] = FifaUtil.ConvertFromDate(this.m_birthdate);
			r.StringField[FI.referee_firstname] = this.m_firstname;
			r.StringField[FI.referee_surname] = this.m_surname;
			r.StringField[FI.referee_firstname] = this.m_firstname;
			r.StringField[FI.referee_surname] = this.m_surname;
			r.IntField[FI.referee_nationalitycode] = this.m_nationalitycode;
			r.IntField[FI.referee_leagueid] = this.GetMainLeague();
			r.IntField[FI.referee_height] = this.m_height;
			r.IntField[FI.referee_weight] = this.m_weight;
			r.IntField[FI.referee_bodytypecode] = this.m_bodytypecode + 1;
			r.IntField[FI.referee_shoedesigncode] = this.m_shoedesigncode;
			r.IntField[FI.referee_shoecolorcode1] = this.m_shoecolorcode1;
			r.IntField[FI.referee_shoecolorcode2] = this.m_shoecolorcode2;
			r.IntField[FI.referee_shoetypecode] = this.m_shoetypecode;
			r.IntField[FI.referee_jerseysleevelengthcode] = this.m_jerseysleevelengthcode;
			r.IntField[FI.referee_eyecolorcode] = this.m_eyecolorcode;
			r.IntField[FI.referee_eyebrowcode] = this.m_eyebrowcode;
			r.IntField[FI.referee_facialhairtypecode] = this.m_facialhairtypecode;
			r.IntField[FI.referee_facialhaircolorcode] = this.m_facialhaircolorcode;
			r.IntField[FI.referee_hairtypecode] = this.m_hairtypecode;
			r.IntField[FI.referee_haircolorcode] = this.m_haircolorcode;
			r.IntField[FI.referee_headtypecode] = this.m_headtypecode;
			r.IntField[FI.referee_headclasscode] = this.m_headclasscode;
			r.IntField[FI.referee_sideburnscode] = 0;
			r.IntField[FI.referee_skintypecode] = this.m_skintypecode;
			r.IntField[FI.referee_skintonecode] = this.m_skintonecode;
			r.IntField[FI.referee_stylecode] = this.m_stylecode;
			r.IntField[FI.referee_cardstrictness] = this.m_cardstrictness;
			r.IntField[FI.referee_foulstrictness] = this.m_foulstrictness;
			r.IntField[FI.referee_homecitycode] = this.m_homecitycode;
			r.IntField[FI.referee_sockheightcode] = this.m_sockheightcode;
			r.IntField[FI.referee_haireffecttypecode] = this.m_haireffecttypecode;
			r.IntField[FI.referee_hairlinecode] = this.m_hairlinecode;
			r.IntField[FI.referee_hairpartcode] = this.m_hairpartcode;
			r.IntField[FI.referee_hairstateid] = this.m_hairstateid;
			r.IntField[FI.referee_hairvariationid] = this.m_hairvariationid;
			r.IntField[FI.referee_sweatid] = this.m_sweatid;
			r.IntField[FI.referee_wrinkleid] = this.m_wrinkleid;
			r.IntField[FI.referee_proxyhaircolorid] = this.m_proxyhaircolorid;
			r.IntField[FI.referee_proxyheadclass] = this.m_proxyheadclass;
			r.IntField[FI.referee_gender] = (this.m_gender ? 1 : 0);
			if (FI.referee_isreal >= 0)
			{
				r.IntField[FI.referee_isreal] = this.m_isreal;
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000389D7 File Offset: 0x00036BD7
		public void SaveLeagueRefereeLinks(Record r, int index)
		{
			r.IntField[FI.leaguerefereelinks_refereeid] = base.Id;
			r.IntField[FI.leaguerefereelinks_leagueid] = this.m_leagueids[index];
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00038A00 File Offset: 0x00036C00
		public void BuildHairPartsTextures()
		{
			if (this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null)
			{
				GraphicUtil.GetAlfaFromChannel((Bitmap)this.m_HairColorTextureBitmap.Clone(), this.m_HairAlfaTextureBitmap, 2);
				GraphicUtil.GetAlfaFromChannel((Bitmap)this.m_HairColorTextureBitmap.Clone(), this.m_HairAlfaTextureBitmap, 1);
				return;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00038A68 File Offset: 0x00036C68
		public bool CreateHead3D(string xFileName)
		{
			this.BuildHairPartsTextures();
			Rx3File rx3File = this.GetHeadModel();
			if (this.m_FaceTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_FaceTextureBitmap);
			if (this.m_EyesTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_EyesTextureBitmap);
			rx3File = this.GetHairModel();
			if (this.m_FaceTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_HairColorTextureBitmap);
			return true;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00038B08 File Offset: 0x00036D08
		public void RandomizeCaucasianAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = Referee.m_Randomizer.Next(0, 8);
			this.m_sideburnscode = 0;
			this.m_skintonecode = Referee.m_Randomizer.Next(1, 5);
			if (this.m_skintonecode == 1)
			{
				this.m_skintonecode = 2;
			}
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 2;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(1, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00038C38 File Offset: 0x00036E38
		public void RandomizeAsiaticAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 9)
			{
				this.m_headtypecode = GenericHead.c_AsiaticModels[Referee.m_Randomizer.Next(0, GenericHead.c_AsiaticModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = Referee.m_Randomizer.Next(1, 6);
			if (this.m_haircolorcode == 2 || this.m_haircolorcode == 4)
			{
				this.m_haircolorcode = 1;
			}
			if (this.m_haircolorcode == 3)
			{
				this.m_haircolorcode = 1;
			}
			this.m_sideburnscode = 0;
			this.m_skintonecode = Referee.m_Randomizer.Next(2, 7);
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 4;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00038D70 File Offset: 0x00036F70
		public void RandomizeAfricanAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_AfricanModels[Referee.m_Randomizer.Next(0, GenericHead.c_AfricanModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = 1;
			this.m_sideburnscode = 0;
			this.m_skintonecode = Referee.m_Randomizer.Next(6, 11);
			if (this.m_skintonecode == 7)
			{
				this.m_skintonecode = 8;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 5);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00038E84 File Offset: 0x00037084
		public void RandomizeLatinAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = 1;
			this.m_sideburnscode = 0;
			this.m_skintonecode = Referee.m_Randomizer.Next(4, 7);
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x04000F6C RID: 3948
		private static int c_MaxNLeagues = 8;

		// Token: 0x04000F6D RID: 3949
		private Bitmap m_EyesTextureBitmap;

		// Token: 0x04000F6E RID: 3950
		private Bitmap m_FaceTextureBitmap;

		// Token: 0x04000F6F RID: 3951
		private Bitmap m_HairColorTextureBitmap;

		// Token: 0x04000F70 RID: 3952
		private Bitmap m_HairAlfaTextureBitmap;

		// Token: 0x04000F71 RID: 3953
		private Rx3File m_HeadModelFile;

		// Token: 0x04000F72 RID: 3954
		private Rx3File m_HairModelFile;

		// Token: 0x04000F73 RID: 3955
		private string m_firstname;

		// Token: 0x04000F74 RID: 3956
		private string m_surname;

		// Token: 0x04000F75 RID: 3957
		private DateTime m_birthdate;

		// Token: 0x04000F76 RID: 3958
		private bool m_gender;

		// Token: 0x04000F77 RID: 3959
		public int m_refereeheadid_unused;

		// Token: 0x04000F78 RID: 3960
		public bool m_isinternationalreferee;

		// Token: 0x04000F79 RID: 3961
		private int m_nationalitycode;

		// Token: 0x04000F7A RID: 3962
		private Country m_Country;

		// Token: 0x04000F7B RID: 3963
		private int[] m_leagueids = new int[Referee.c_MaxNLeagues];

		// Token: 0x04000F7C RID: 3964
		private League[] m_Leagues = new League[Referee.c_MaxNLeagues];

		// Token: 0x04000F7D RID: 3965
		private int m_height;

		// Token: 0x04000F7E RID: 3966
		private int m_weight;

		// Token: 0x04000F7F RID: 3967
		private int m_eyecolorcode;

		// Token: 0x04000F80 RID: 3968
		private int m_eyebrowcode;

		// Token: 0x04000F81 RID: 3969
		private int m_stylecode;

		// Token: 0x04000F82 RID: 3970
		private int m_cardstrictness;

		// Token: 0x04000F83 RID: 3971
		private int m_foulstrictness;

		// Token: 0x04000F84 RID: 3972
		private int m_homecitycode;

		// Token: 0x04000F85 RID: 3973
		private int m_sockheightcode;

		// Token: 0x04000F86 RID: 3974
		private int m_haireffecttypecode;

		// Token: 0x04000F87 RID: 3975
		private int m_hairlinecode;

		// Token: 0x04000F88 RID: 3976
		private int m_hairpartcode;

		// Token: 0x04000F89 RID: 3977
		private int m_hairstateid;

		// Token: 0x04000F8A RID: 3978
		private int m_hairvariationid;

		// Token: 0x04000F8B RID: 3979
		private int m_sweatid;

		// Token: 0x04000F8C RID: 3980
		private int m_wrinkleid;

		// Token: 0x04000F8D RID: 3981
		private int m_proxyhaircolorid;

		// Token: 0x04000F8E RID: 3982
		private int m_proxyheadclass;

		// Token: 0x04000F8F RID: 3983
		private int m_isreal;

		// Token: 0x04000F90 RID: 3984
		private static Random m_Randomizer = new Random();

		// Token: 0x04000F91 RID: 3985
		private int m_bodytypecode;

		// Token: 0x04000F92 RID: 3986
		private int m_hairtypecode;

		// Token: 0x04000F93 RID: 3987
		private int m_headtypecode;

		// Token: 0x04000F94 RID: 3988
		private int m_headclasscode;

		// Token: 0x04000F95 RID: 3989
		private int m_haircolorcode;

		// Token: 0x04000F96 RID: 3990
		private int m_facialhairtypecode;

		// Token: 0x04000F97 RID: 3991
		private int m_facialhaircolorcode;

		// Token: 0x04000F98 RID: 3992
		private int m_sideburnscode;

		// Token: 0x04000F99 RID: 3993
		private int m_skintypecode;

		// Token: 0x04000F9A RID: 3994
		private int m_skintonecode;

		// Token: 0x04000F9B RID: 3995
		private int m_jerseysleevelengthcode;

		// Token: 0x04000F9C RID: 3996
		private int m_shoedesigncode;

		// Token: 0x04000F9D RID: 3997
		private int m_shoecolorcode1;

		// Token: 0x04000F9E RID: 3998
		private int m_shoecolorcode2;

		// Token: 0x04000F9F RID: 3999
		private int m_shoetypecode;

		// Token: 0x04000FA0 RID: 4000
		private int[] c_HairToFacial = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };

		// Token: 0x04000FA1 RID: 4001
		private int[] c_RefereHair = new int[]
		{
			0, 1, 2, 8, 13, 14, 16, 19, 20, 21,
			22, 23, 24, 25, 26, 28, 29, 30, 31, 32,
			35, 36, 37, 38, 40, 41, 43, 45, 46, 47,
			54, 57, 58, 59, 62, 64, 65, 66, 67, 69,
			70, 72, 73, 74, 75, 77, 78, 82, 83, 85,
			86, 87, 88, 89, 90, 92, 93, 95, 98, 99,
			100, 101, 102, 103, 104, 105, 106, 107, 108
		};
	}
}
