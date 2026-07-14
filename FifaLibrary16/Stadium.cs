using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200007E RID: 126
	public class Stadium : IdObject
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0003D228 File Offset: 0x0003B428
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0003D230 File Offset: 0x0003B430
		public string name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0003D239 File Offset: 0x0003B439
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0003D241 File Offset: 0x0003B441
		public int countrycode
		{
			get
			{
				return this.m_countrycode;
			}
			set
			{
				this.m_countrycode = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0003D24A File Offset: 0x0003B44A
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0003D252 File Offset: 0x0003B452
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
					this.m_countrycode = this.m_Country.Id;
					return;
				}
				this.m_countrycode = 0;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0003D27C File Offset: 0x0003B47C
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x0003D284 File Offset: 0x0003B484
		public int policetypecode
		{
			get
			{
				return this.m_policetypecode;
			}
			set
			{
				this.m_policetypecode = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0003D28D File Offset: 0x0003B48D
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x0003D295 File Offset: 0x0003B495
		public int sectionfacedbydefault
		{
			get
			{
				return this.m_sectionfacedbydefault;
			}
			set
			{
				this.m_sectionfacedbydefault = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0003D29E File Offset: 0x0003B49E
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0003D2A6 File Offset: 0x0003B4A6
		public int hometeamid
		{
			get
			{
				return this.m_hometeamid;
			}
			set
			{
				this.m_hometeamid = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0003D2AF File Offset: 0x0003B4AF
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0003D2B7 File Offset: 0x0003B4B7
		public Team HomeTeam
		{
			get
			{
				return this.m_HomeTeam;
			}
			set
			{
				this.m_HomeTeam = value;
				if (this.m_HomeTeam != null)
				{
					this.m_hometeamid = this.m_HomeTeam.Id;
					return;
				}
				this.m_hometeamid = 0;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0003D2E1 File Offset: 0x0003B4E1
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x0003D2E9 File Offset: 0x0003B4E9
		public int capacity
		{
			get
			{
				return this.m_capacity;
			}
			set
			{
				this.m_capacity = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0003D2F2 File Offset: 0x0003B4F2
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0003D2FA File Offset: 0x0003B4FA
		public int yearbuilt
		{
			get
			{
				return this.m_yearbuilt;
			}
			set
			{
				this.m_yearbuilt = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0003D303 File Offset: 0x0003B503
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0003D30B File Offset: 0x0003B50B
		public int seatcolor
		{
			get
			{
				return this.m_seatcolor;
			}
			set
			{
				this.m_seatcolor = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0003D314 File Offset: 0x0003B514
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0003D31C File Offset: 0x0003B51C
		public int stadiumtype
		{
			get
			{
				return this.m_stadiumtype;
			}
			set
			{
				this.m_stadiumtype = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0003D325 File Offset: 0x0003B525
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0003D32D File Offset: 0x0003B52D
		public int NetColor
		{
			get
			{
				return this.m_stadiumgoalnetstyle;
			}
			set
			{
				this.m_stadiumgoalnetstyle = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0003D336 File Offset: 0x0003B536
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0003D345 File Offset: 0x0003B545
		public bool IsDeepNet
		{
			get
			{
				return this.m_stadiumgloalnetdepth == 320;
			}
			set
			{
				this.m_stadiumgloalnetdepth = (value ? 320 : 229);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0003D35C File Offset: 0x0003B55C
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x0003D364 File Offset: 0x0003B564
		public int MowingPatternId
		{
			get
			{
				return this.m_stadiummowpattern_code;
			}
			set
			{
				this.m_stadiummowpattern_code = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0003D36D File Offset: 0x0003B56D
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x0003D375 File Offset: 0x0003B575
		public int adboardendlinedistance
		{
			get
			{
				return this.m_adboardendlinedistance;
			}
			set
			{
				this.m_adboardendlinedistance = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003D37E File Offset: 0x0003B57E
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x0003D386 File Offset: 0x0003B586
		public int adboardsidelinedistance
		{
			get
			{
				return this.m_adboardsidelinedistance;
			}
			set
			{
				this.m_adboardsidelinedistance = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0003D38F File Offset: 0x0003B58F
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x0003D397 File Offset: 0x0003B597
		public int adboardtype
		{
			get
			{
				return this.m_adboardtype;
			}
			set
			{
				this.m_adboardtype = value;
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00009CCD File Offset: 0x00007ECD
		public bool HasCloudyDay()
		{
			return false;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0003D3A0 File Offset: 0x0003B5A0
		public void SetCloudyDay(bool enable)
		{
			this.SetTimeOfDay(enable, this.HasSunnyDay(), this.HasNight(), this.HasSunset());
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0003D3BB File Offset: 0x0003B5BB
		public void SetSunnyDay(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), enable, this.HasNight(), this.HasSunset());
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0003D3D6 File Offset: 0x0003B5D6
		public void SetNight(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), this.HasSunnyDay(), enable, this.HasSunset());
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0003D3F1 File Offset: 0x0003B5F1
		public void SetSunset(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), this.HasSunnyDay(), this.HasNight(), enable);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0003D40C File Offset: 0x0003B60C
		private void SetTimeOfDay(bool hasCloudyDay, bool hasSunnyDay, bool hasNight, bool hasSunset)
		{
			int num = this.GetWeather();
			if (num == 2)
			{
				num = 3;
			}
			int num2 = 0;
			if (hasCloudyDay)
			{
				this.m_timeofday[num2] = 0;
				this.m_todweather[num2] = num;
				num2++;
			}
			if (hasSunnyDay)
			{
				this.m_timeofday[num2] = 1;
				this.m_todweather[num2] = 0;
				num2++;
			}
			if (hasNight)
			{
				this.m_timeofday[num2] = 3;
				this.m_todweather[num2] = num;
				num2++;
			}
			if (hasSunset)
			{
				this.m_timeofday[num2] = 4;
				this.m_todweather[num2] = 0;
				num2++;
			}
			for (int i = num2; i < 4; i++)
			{
				this.m_timeofday[i] = 5;
				this.m_todweather[i] = 0;
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0003D4AC File Offset: 0x0003B6AC
		public bool HasSunnyDay()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
		public bool HasNight()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00009CCD File Offset: 0x00007ECD
		public bool HasSunset()
		{
			return false;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0003D4FC File Offset: 0x0003B6FC
		public int GetWeather()
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				if (this.m_todweather[i] != 5 && this.m_todweather[i] > num)
				{
					num = this.m_todweather[i];
				}
			}
			if (num == 3)
			{
				num = 2;
			}
			return num;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0003D540 File Offset: 0x0003B740
		public void SetWeather(int weather)
		{
			if (weather == 2)
			{
				weather = 3;
			}
			for (int i = 0; i < 4; i++)
			{
				this.m_todweather[i] = ((this.m_timeofday[i] == 1 || this.m_timeofday[i] == 3) ? weather : 0);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0003D582 File Offset: 0x0003B782
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0003D58A File Offset: 0x0003B78A
		public int stadiumgoalnettype
		{
			get
			{
				return this.m_stadiumgoalnettype;
			}
			set
			{
				this.m_stadiumgoalnettype = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0003D593 File Offset: 0x0003B793
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0003D59B File Offset: 0x0003B79B
		public int stadiumgoalnetpattern
		{
			get
			{
				return this.m_stadiumgoalnetpattern;
			}
			set
			{
				this.m_stadiumgoalnetpattern = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003D5A4 File Offset: 0x0003B7A4
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0003D5AC File Offset: 0x0003B7AC
		public int stadiumgoalnettension
		{
			get
			{
				return this.m_stadiumgoalnettension;
			}
			set
			{
				this.m_stadiumgoalnettension = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0003D5B5 File Offset: 0x0003B7B5
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0003D5BD File Offset: 0x0003B7BD
		public int cameraheight
		{
			get
			{
				return this.m_cameraheight;
			}
			set
			{
				this.m_cameraheight = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0003D5C6 File Offset: 0x0003B7C6
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x0003D5CE File Offset: 0x0003B7CE
		public int camerazoom
		{
			get
			{
				return this.m_camerazoom;
			}
			set
			{
				this.m_camerazoom = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0003D5D7 File Offset: 0x0003B7D7
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0003D5DF File Offset: 0x0003B7DF
		public string LocalName
		{
			get
			{
				return this.m_LocalName;
			}
			set
			{
				this.m_LocalName = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0003D5E8 File Offset: 0x0003B7E8
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0003D5F3 File Offset: 0x0003B7F3
		public bool islicensed
		{
			get
			{
				return this.m_islicensed != 0;
			}
			set
			{
				this.m_islicensed = (value ? 1 : 0);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0003D602 File Offset: 0x0003B802
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0003D60A File Offset: 0x0003B80A
		public int stadhometechzoneminx
		{
			get
			{
				return this.m_stadhometechzoneminx;
			}
			set
			{
				this.m_stadhometechzoneminx = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0003D613 File Offset: 0x0003B813
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0003D61B File Offset: 0x0003B81B
		public int stadhometechzonemaxx
		{
			get
			{
				return this.m_stadhometechzonemaxx;
			}
			set
			{
				this.m_stadhometechzonemaxx = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0003D624 File Offset: 0x0003B824
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0003D62C File Offset: 0x0003B82C
		public int stadhometechzoneminz
		{
			get
			{
				return this.m_stadhometechzoneminz;
			}
			set
			{
				this.m_stadhometechzoneminz = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0003D635 File Offset: 0x0003B835
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0003D63D File Offset: 0x0003B83D
		public int stadhometechzonemaxz
		{
			get
			{
				return this.m_stadhometechzonemaxz;
			}
			set
			{
				this.m_stadhometechzonemaxz = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0003D646 File Offset: 0x0003B846
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0003D64E File Offset: 0x0003B84E
		public int stadawaytechzoneminx
		{
			get
			{
				return this.m_stadawaytechzoneminx;
			}
			set
			{
				this.m_stadawaytechzoneminx = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0003D657 File Offset: 0x0003B857
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x0003D65F File Offset: 0x0003B85F
		public int stadawaytechzonemaxx
		{
			get
			{
				return this.m_stadawaytechzonemaxx;
			}
			set
			{
				this.m_stadawaytechzonemaxx = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0003D668 File Offset: 0x0003B868
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x0003D670 File Offset: 0x0003B870
		public int stadawaytechzoneminz
		{
			get
			{
				return this.m_stadawaytechzoneminz;
			}
			set
			{
				this.m_stadawaytechzoneminz = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0003D679 File Offset: 0x0003B879
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0003D681 File Offset: 0x0003B881
		public int stadawaytechzonemaxz
		{
			get
			{
				return this.m_stadawaytechzonemaxz;
			}
			set
			{
				this.m_stadawaytechzonemaxz = value;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0003D68C File Offset: 0x0003B88C
		public Stadium(int stadiumid)
			: base(stadiumid)
		{
			this.m_name = "Stadium " + stadiumid.ToString();
			this.m_LocalName = this.m_name;
			this.m_seatcolor = 1;
			this.m_yearbuilt = 1950;
			this.m_countrycode = 0;
			this.m_policetypecode = 1;
			this.m_sectionfacedbydefault = 0;
			this.m_hometeamid = 0;
			this.m_capacity = 10000;
			this.m_stadiumtype = 0;
			this.m_stadiumgoalnetstyle = 0;
			this.m_stadiumgoalnetpattern = 0;
			this.m_stadiumgloalnetdepth = 229;
			this.m_stadiumgoalnetlength = 250;
			this.m_stadiumgoalnetwidth = 744;
			this.m_stadiummowpattern_code = 0;
			this.m_stadiumpitchlength = 10500;
			this.m_stadiumpitchwidth = 6800;
			this.m_adboardendlinedistance = 500;
			this.m_adboardsidelinedistance = 500;
			this.m_adboardtype = 0;
			for (int i = 0; i < 4; i++)
			{
				this.m_timeofday[i] = 0;
				this.m_todweather[i] = 0;
			}
			this.m_dlc = 0;
			this.m_stadiumgoalnettype = 0;
			this.m_stadiumgoalnettension = 0;
			this.m_cameraheight = 15;
			this.m_camerazoom = 9;
			this.m_genericrank = -1;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0003D7CE File Offset: 0x0003B9CE
		public Stadium(Record r)
			: base(r.IntField[FI.stadiums_stadiumid])
		{
			this.Load(r);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0003D804 File Offset: 0x0003BA04
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			if (this.m_countrycode == 0)
			{
				this.m_Country = null;
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_countrycode);
			if (this.m_Country == null)
			{
				this.m_countrycode = 0;
				return;
			}
			this.m_countrycode = this.m_Country.Id;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0003D860 File Offset: 0x0003BA60
		public void Load(Record r)
		{
			this.m_name = r.StringField[FI.stadiums_name];
			this.m_countrycode = r.GetAndCheckIntField(FI.stadiums_countrycode);
			this.m_hometeamid = r.GetAndCheckIntField(FI.stadiums_hometeamid);
			this.m_HomeTeam = null;
			this.m_capacity = r.GetAndCheckIntField(FI.stadiums_capacity);
			this.m_policetypecode = r.GetAndCheckIntField(FI.stadiums_policetypecode);
			this.m_seatcolor = r.GetAndCheckIntField(FI.stadiums_seatcolor);
			this.m_sectionfacedbydefault = r.GetAndCheckIntField(FI.stadiums_sectionfacedbydefault);
			this.m_stadiumgoalnetstyle = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetstyle);
			this.m_stadiumgloalnetdepth = r.GetAndCheckIntField(FI.stadiums_stadiumgloalnetdepth);
			this.m_stadiumgoalnetlength = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetlength);
			this.m_stadiumgoalnetwidth = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetwidth);
			this.m_stadiummowpattern_code = r.GetAndCheckIntField(FI.stadiums_stadiummowpattern_code);
			this.m_stadiumpitchlength = r.GetAndCheckIntField(FI.stadiums_stadiumpitchlength);
			this.m_stadiumpitchwidth = r.GetAndCheckIntField(FI.stadiums_stadiumpitchwidth);
			this.m_adboardendlinedistance = r.GetAndCheckIntField(FI.stadiums_adboardendlinedistance);
			this.m_adboardsidelinedistance = r.GetAndCheckIntField(FI.stadiums_adboardsidelinedistance);
			this.m_timeofday[0] = r.GetAndCheckIntField(FI.stadiums_timeofday1);
			this.m_timeofday[1] = r.GetAndCheckIntField(FI.stadiums_timeofday2);
			this.m_timeofday[2] = r.GetAndCheckIntField(FI.stadiums_timeofday3);
			this.m_timeofday[3] = r.GetAndCheckIntField(FI.stadiums_timeofday4);
			this.m_todweather[0] = r.GetAndCheckIntField(FI.stadiums_tod1weather);
			this.m_todweather[1] = r.GetAndCheckIntField(FI.stadiums_tod2weather);
			this.m_todweather[2] = r.GetAndCheckIntField(FI.stadiums_tod3weather);
			this.m_todweather[3] = r.GetAndCheckIntField(FI.stadiums_tod4weather);
			this.m_dlc = r.GetAndCheckIntField(FI.stadiums_dlc);
			this.m_stadiumgoalnettype = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnettype);
			if (FI.stadiums_stadiumgoalnetpattern >= 0)
			{
				this.m_stadiumgoalnetpattern = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetpattern);
			}
			this.m_stadiumgoalnettension = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnettension);
			this.m_cameraheight = r.GetAndCheckIntField(FI.stadiums_cameraheight);
			this.m_camerazoom = r.GetAndCheckIntField(FI.stadiums_camerazoom);
			this.m_stadiumtype = r.GetAndCheckIntField(FI.stadiums_stadiumtype);
			if (this.m_stadiumtype > 1)
			{
				this.m_stadiumtype = 1;
			}
			this.m_yearbuilt = r.GetAndCheckIntField(FI.stadiums_yearbuilt);
			this.m_islicensed = r.GetAndCheckIntField(FI.stadiums_islicensed);
			this.m_stadhometechzonemaxz = r.GetAndCheckIntField(FI.stadiums_stadhometechzonemaxz);
			this.m_stadawaytechzonemaxx = r.GetAndCheckIntField(FI.stadiums_stadawaytechzonemaxx);
			this.m_stadhometechzonemaxx = r.GetAndCheckIntField(FI.stadiums_stadhometechzonemaxx);
			this.m_stadawaytechzoneminz = r.GetAndCheckIntField(FI.stadiums_stadawaytechzoneminz);
			this.m_stadhometechzoneminx = r.GetAndCheckIntField(FI.stadiums_stadhometechzoneminx);
			this.m_stadhometechzoneminz = r.GetAndCheckIntField(FI.stadiums_stadhometechzoneminz);
			this.m_stadawaytechzonemaxz = r.GetAndCheckIntField(FI.stadiums_stadawaytechzonemaxz);
			this.m_stadawaytechzoneminx = r.GetAndCheckIntField(FI.stadiums_stadawaytechzoneminx);
			if (FifaEnvironment.Language != null)
			{
				this.m_LocalName = FifaEnvironment.Language.GetStadiumName(base.Id);
			}
			else
			{
				this.m_LocalName = string.Empty;
			}
			this.m_upgradetier = r.GetAndCheckIntField(FI.stadiums_upgradetier);
			this.m_upgradestyle = r.GetAndCheckIntField(FI.stadiums_upgradestyle);
			this.m_iseditable = r.GetAndCheckIntField(FI.stadiums_iseditable);
			this.m_isdynamic = r.GetAndCheckIntField(FI.stadiums_isdynamic);
			this.m_genericrank = r.GetAndCheckIntField(FI.stadiums_genericrank);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
		public override string ToString()
		{
			if (this.m_name != null && this.m_name != string.Empty)
			{
				return this.m_name;
			}
			return "Stadium n. " + base.Id.ToString();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0003D228 File Offset: 0x0003B428
		public string DatabaseString()
		{
			return this.m_name;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0003DC1E File Offset: 0x0003BE1E
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_HomeTeam = (Team)teamList.SearchId(this.m_hometeamid);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0003DC3C File Offset: 0x0003BE3C
		public override IdObject Clone(int stadiumid)
		{
			Stadium stadium = (Stadium)base.Clone(stadiumid);
			stadium.m_name = "Stadium " + stadiumid.ToString();
			stadium.m_LocalName = stadium.m_name;
			this.CloneModel(stadiumid);
			this.ClonePreview(stadiumid, 1);
			this.ClonePreview(stadiumid, 3);
			if (this.HasSunnyDay())
			{
				this.CloneTextures(stadiumid, 1);
				this.CloneCrowd(stadiumid, 1);
				this.CloneGlares(stadiumid, 1);
			}
			if (this.HasNight())
			{
				this.CloneTextures(stadiumid, 3);
				this.CloneCrowd(stadiumid, 3);
				this.CloneGlares(stadiumid, 3);
			}
			this.CloneRadiosity(stadiumid);
			return stadium;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0003DCDB File Offset: 0x0003BEDB
		private void CloneTextures(int newId, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.TexturesFileName(timeofday), Stadium.TexturesFileName(newId, timeofday));
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0003DCF1 File Offset: 0x0003BEF1
		private void ClonePreview(int newId, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(Stadium.PreviewBigFileName(base.Id, timeofday), Stadium.PreviewBigFileName(newId, timeofday));
			FifaEnvironment.CloneIntoZdata(Stadium.PreviewLargeBigFileName(base.Id, timeofday), Stadium.PreviewLargeBigFileName(newId, timeofday));
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0003DD25 File Offset: 0x0003BF25
		private void CloneModel(int newId)
		{
			FifaEnvironment.CloneIntoZdata(Stadium.ModelFileName(base.Id), Stadium.ModelFileName(newId));
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0003DD3E File Offset: 0x0003BF3E
		public Bitmap GetNet()
		{
			return Net.GetNet(this.m_stadiumgoalnetstyle);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0003DD4B File Offset: 0x0003BF4B
		public bool SetNet(Bitmap bitmap)
		{
			return Net.SetNet(this.m_stadiumgoalnetstyle, bitmap);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003DD59 File Offset: 0x0003BF59
		public bool SetNet(string rx3FileName)
		{
			return Net.SetNet(this.m_stadiumgoalnetstyle, rx3FileName);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0003DD67 File Offset: 0x0003BF67
		public bool DeleteNet()
		{
			return Net.DeleteNet(this.m_stadiumgoalnetstyle);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0003DD74 File Offset: 0x0003BF74
		public Bitmap GetPolice()
		{
			if (this.m_policetypecode == 0)
			{
				return null;
			}
			return Police.GetPolice(this.m_policetypecode, 0);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		public bool SetPolice(Bitmap bitmap)
		{
			return this.m_policetypecode != 0 && Police.SetPolice(this.m_policetypecode, 0, bitmap) && Police.SetPolice(this.m_policetypecode, 1, bitmap);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003DDB6 File Offset: 0x0003BFB6
		public bool DeletePolice()
		{
			return this.m_policetypecode != 0 && Police.DeletePolice(this.m_policetypecode, 0) && Police.DeletePolice(this.m_policetypecode, 1);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003DDDE File Offset: 0x0003BFDE
		public Bitmap GetMowingPattern()
		{
			return MowingPattern.GetMowingPattern(this.m_stadiummowpattern_code);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003DDEB File Offset: 0x0003BFEB
		public bool SetMowingPattern(Bitmap bitmap)
		{
			return MowingPattern.SetMowingPattern(this.m_stadiummowpattern_code, bitmap);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003DDF9 File Offset: 0x0003BFF9
		public bool SetMowingPattern(string rx3FileName)
		{
			return MowingPattern.SetMowingPattern(this.m_stadiummowpattern_code, rx3FileName);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003DE07 File Offset: 0x0003C007
		public bool DeleteMowingPattern()
		{
			return MowingPattern.DeleteMowingPattern(this.m_stadiummowpattern_code);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003DE14 File Offset: 0x0003C014
		public void SaveStadium(Record r)
		{
			r.IntField[FI.stadiums_stadiumid] = base.Id;
			r.StringField[FI.stadiums_name] = this.m_name;
			r.IntField[FI.stadiums_countrycode] = this.m_countrycode;
			r.IntField[FI.stadiums_hometeamid] = this.m_hometeamid;
			r.IntField[FI.stadiums_capacity] = this.m_capacity;
			r.IntField[FI.stadiums_policetypecode] = this.m_policetypecode;
			r.IntField[FI.stadiums_seatcolor] = this.m_seatcolor;
			r.IntField[FI.stadiums_sectionfacedbydefault] = this.m_sectionfacedbydefault;
			r.IntField[FI.stadiums_stadiumgoalnetstyle] = this.m_stadiumgoalnetstyle;
			r.IntField[FI.stadiums_stadiumgloalnetdepth] = this.m_stadiumgloalnetdepth;
			r.IntField[FI.stadiums_stadiumgoalnetlength] = this.m_stadiumgoalnetlength;
			r.IntField[FI.stadiums_stadiumgoalnetwidth] = this.m_stadiumgoalnetwidth;
			r.IntField[FI.stadiums_stadiummowpattern_code] = this.m_stadiummowpattern_code;
			r.IntField[FI.stadiums_stadiumpitchlength] = this.m_stadiumpitchlength;
			r.IntField[FI.stadiums_stadiumpitchwidth] = this.m_stadiumpitchwidth;
			r.IntField[FI.stadiums_adboardendlinedistance] = this.m_adboardendlinedistance;
			r.IntField[FI.stadiums_adboardsidelinedistance] = this.m_adboardsidelinedistance;
			r.IntField[FI.stadiums_timeofday1] = this.m_timeofday[0];
			r.IntField[FI.stadiums_timeofday2] = this.m_timeofday[1];
			r.IntField[FI.stadiums_timeofday3] = this.m_timeofday[2];
			r.IntField[FI.stadiums_timeofday4] = this.m_timeofday[3];
			r.IntField[FI.stadiums_tod1weather] = this.m_todweather[0];
			r.IntField[FI.stadiums_tod2weather] = this.m_todweather[1];
			r.IntField[FI.stadiums_tod3weather] = this.m_todweather[2];
			r.IntField[FI.stadiums_tod4weather] = this.m_todweather[3];
			r.IntField[FI.stadiums_dlc] = this.m_dlc;
			r.IntField[FI.stadiums_stadiumtype] = this.m_stadiumtype;
			r.IntField[FI.stadiums_yearbuilt] = this.m_yearbuilt;
			r.IntField[FI.stadiums_stadiumgoalnettype] = this.m_stadiumgoalnettype;
			if (FI.stadiums_stadiumgoalnetpattern >= 0)
			{
				r.IntField[FI.stadiums_stadiumgoalnetpattern] = this.m_stadiumgoalnetpattern;
			}
			r.IntField[FI.stadiums_stadiumgoalnettension] = this.m_stadiumgoalnettension;
			r.IntField[FI.stadiums_cameraheight] = this.m_cameraheight;
			r.IntField[FI.stadiums_camerazoom] = this.m_camerazoom;
			r.IntField[FI.stadiums_upgradetier] = this.m_upgradetier;
			r.IntField[FI.stadiums_upgradestyle] = this.m_upgradestyle;
			r.IntField[FI.stadiums_iseditable] = this.m_iseditable;
			r.IntField[FI.stadiums_isdynamic] = this.m_isdynamic;
			r.IntField[FI.stadiums_genericrank] = this.m_genericrank;
			r.IntField[FI.stadiums_islicensed] = this.m_islicensed;
			r.IntField[FI.stadiums_stadhometechzonemaxz] = this.m_stadhometechzonemaxz;
			r.IntField[FI.stadiums_stadawaytechzonemaxx] = this.m_stadawaytechzonemaxx;
			r.IntField[FI.stadiums_stadhometechzonemaxx] = this.m_stadhometechzonemaxx;
			r.IntField[FI.stadiums_stadawaytechzoneminz] = this.m_stadawaytechzoneminz;
			r.IntField[FI.stadiums_stadhometechzoneminx] = this.m_stadhometechzoneminx;
			r.IntField[FI.stadiums_stadhometechzoneminz] = this.m_stadhometechzoneminz;
			r.IntField[FI.stadiums_stadawaytechzonemaxz] = this.m_stadawaytechzonemaxz;
			r.IntField[FI.stadiums_stadawaytechzoneminx] = this.m_stadawaytechzoneminx;
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetStadiumName(base.Id, this.m_LocalName);
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetStadiumName(base.Id, this.m_LocalName);
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003E1C3 File Offset: 0x0003C3C3
		public static string PreviewBigFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadium/stadium_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		public string PreviewBigFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadium/stadium_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003E247 File Offset: 0x0003C447
		public string PreviewTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/stadium/2014_stadium_#_%.big";
			}
			return "data/ui/artassets/stadium/stadium_#_%.big";
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000027B4 File Offset: 0x000009B4
		public string PreviewDdsFileName()
		{
			return "2";
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003E25D File Offset: 0x0003C45D
		public Bitmap GetPreview(int timeofday)
		{
			return FifaEnvironment.GetArtasset(this.PreviewBigFileName(timeofday));
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0003E26C File Offset: 0x0003C46C
		public bool SetPreview(int timeofday, Bitmap bitmap)
		{
			int[] array = new int[] { base.Id, timeofday };
			return FifaEnvironment.SetArtasset(this.PreviewTemplateFileName(), this.PreviewDdsFileName(), array, bitmap);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0003E2A0 File Offset: 0x0003C4A0
		public bool DeletePreview(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.PreviewBigFileName(timeofday));
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0003E2AE File Offset: 0x0003C4AE
		private void CloneTimeOfDayPreview(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.PreviewBigFileName(timeofday), this.PreviewBigFileName(newTimeOfDay));
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003E2C4 File Offset: 0x0003C4C4
		public static string PreviewLargeBigFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadiumsbig/st_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003E300 File Offset: 0x0003C500
		public string PreviewLargeBigFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadiumsbig/st_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003E34B File Offset: 0x0003C54B
		public string PreviewLargeTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/artassets/stadiumsbig/2014_st_#_%.big";
			}
			return "data/ui/artassets/stadiumsbig/st_#_%.big";
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000027B4 File Offset: 0x000009B4
		public string PreviewLargeDdsFileName()
		{
			return "2";
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003E361 File Offset: 0x0003C561
		public Bitmap GetPreviewLarge(int timeofday)
		{
			return FifaEnvironment.GetArtasset(this.PreviewLargeBigFileName(timeofday));
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003E370 File Offset: 0x0003C570
		public bool SetPreviewLarge(int timeofday, Bitmap bitmap)
		{
			int[] array = new int[] { base.Id, timeofday };
			return FifaEnvironment.SetArtasset(this.PreviewLargeTemplateFileName(), this.PreviewLargeDdsFileName(), array, bitmap);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003E3A4 File Offset: 0x0003C5A4
		public bool DeletePreviewLarge(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.PreviewLargeBigFileName(timeofday));
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0003E3B2 File Offset: 0x0003C5B2
		private void CloneTimeOfDayPreviewLarge(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.PreviewLargeBigFileName(timeofday), this.PreviewLargeBigFileName(newTimeOfDay));
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		public static string TexturesFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/stadium/stadium_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0003E404 File Offset: 0x0003C604
		public string TexturesFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/stadium/stadium_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0003E44F File Offset: 0x0003C64F
		public string TexturesTemplateFileName()
		{
			return "data/sceneassets/stadium/stadium_#_%_textures.rx3";
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0003E456 File Offset: 0x0003C656
		public Bitmap[] GetTextures(int timeofday)
		{
			return FifaEnvironment.GetBmpsFromRx3(this.TexturesFileName(timeofday));
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0003E464 File Offset: 0x0003C664
		public bool SetTextures(int timeofday, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoStadium(this.TexturesFileName(timeofday), bitmaps);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0003E473 File Offset: 0x0003C673
		public bool SetTextures(int timeofday, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.TexturesFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0003E484 File Offset: 0x0003C684
		public bool DeleteContainer(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.TexturesFileName(timeofday));
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003E492 File Offset: 0x0003C692
		public static string ModelFileName(int stadiumid)
		{
			return "data/sceneassets/stadium/stadium_" + stadiumid.ToString() + ".rx3";
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0003E4AC File Offset: 0x0003C6AC
		public string ModelFileName()
		{
			return "data/sceneassets/stadium/stadium_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0003E4D6 File Offset: 0x0003C6D6
		public string ModelTemplateFileName()
		{
			return "data/sceneassets/stadium/stadium_#.rx3";
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003E4DD File Offset: 0x0003C6DD
		public Rx3File GetModel()
		{
			return FifaEnvironment.GetRx3FromZdata(this.ModelFileName());
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0003E4EA File Offset: 0x0003C6EA
		public bool SetModel(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003E4FA File Offset: 0x0003C6FA
		public bool DeleteModel(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.ModelFileName());
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003E507 File Offset: 0x0003C707
		public static string CrowdFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/crowdplacement/crowd_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".dat"
			});
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0003E540 File Offset: 0x0003C740
		public string CrowdFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/crowdplacement/crowd_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".dat"
			});
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0003E58B File Offset: 0x0003C78B
		public bool CloneCrowd(int newId, int timeofday)
		{
			return FifaEnvironment.CloneIntoZdata(this.CrowdFileName(timeofday), Stadium.CrowdFileName(newId, timeofday));
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003E5A0 File Offset: 0x0003C7A0
		public bool SetCrowd(int timeofday, string datFileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(datFileName, this.CrowdFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003E5B1 File Offset: 0x0003C7B1
		public void CloneTimeOfDayCrowd(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.CrowdFileName(timeofday), this.CrowdFileName(newTimeOfDay));
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003E5C7 File Offset: 0x0003C7C7
		public static string RadiosityFileName(int stadiumid)
		{
			return "data/sceneassets/radiosity/stadium_" + stadiumid.ToString() + ".rad";
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		public string RadiosityFileName()
		{
			return "data/sceneassets/radiosity/stadium_" + base.Id.ToString() + ".rad";
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003E60A File Offset: 0x0003C80A
		public bool CloneRadiosity(int newId)
		{
			return FifaEnvironment.CloneIntoZdata(this.RadiosityFileName(), Stadium.RadiosityFileName(newId));
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0003E61D File Offset: 0x0003C81D
		public bool SetRadiosity(string radFileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(radFileName, this.RadiosityFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003E630 File Offset: 0x0003C830
		public static string[] GlaresLightFileNames(int stadiumid, int timeofday)
		{
			string[] array;
			if (FifaEnvironment.Year == 14)
			{
				array = new string[]
				{
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_0.lnx",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_0.rx3",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_1.lnx",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_1.rx3",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_3.lnx",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_3.rx3",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_4.lnx",
					"data/sceneassets/fx/glares_" + stadiumid.ToString() + "_4.rx3"
				};
			}
			else
			{
				array = new string[]
				{
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_0.lnx"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_0.rx3"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_1.lnx"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_1.rx3"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_2.lnx"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_2.rx3"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_3.lnx"
					}),
					string.Concat(new string[]
					{
						"data/sceneassets/fx/glares_",
						stadiumid.ToString(),
						"_",
						timeofday.ToString(),
						"_3.rx3"
					})
				};
			}
			return array;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003E8F8 File Offset: 0x0003CAF8
		public static string[] GlaresLightFileNames(int stadiumId)
		{
			return new string[]
			{
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_0.lnx",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_0.rx3",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_1.lnx",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_1.rx3",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_3.lnx",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_3.rx3",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_4.lnx",
				"data/sceneassets/fx/glares_" + stadiumId.ToString() + "_4.rx3"
			};
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003E9D4 File Offset: 0x0003CBD4
		public string[] GlaresLightFileNames()
		{
			return new string[]
			{
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_0.lnx",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_0.rx3",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_1.lnx",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_1.rx3",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_3.lnx",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_3.rx3",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_4.lnx",
				"data/sceneassets/fx/glares_" + base.Id.ToString() + "_4.rx3"
			};
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003EAE8 File Offset: 0x0003CCE8
		public bool CloneGlares(int newId)
		{
			string[] array = Stadium.GlaresLightFileNames(base.Id);
			string[] array2 = Stadium.GlaresLightFileNames(newId);
			string text = FifaEnvironment.GameDir + Path.GetDirectoryName(array2[0]);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (Path.GetExtension(array[i]).ToLower() == ".lnx")
				{
					string text2 = FifaEnvironment.TempFolder + "\\" + array[i];
					string text3 = "glares_" + base.Id.ToString() + "_";
					string text4 = "glares_" + newId.ToString() + "_";
					if (FifaEnvironment.ExportFileFromZdata(array[i], FifaEnvironment.TempFolder))
					{
						StreamWriter streamWriter = new StreamWriter(FifaEnvironment.GameDir + array2[i]);
						StreamReader streamReader = new StreamReader(text2);
						bool flag = false;
						string text5;
						while ((text5 = streamReader.ReadLine()) != null)
						{
							if (!flag && text5.Contains(text3))
							{
								text5 = text5.Replace(text3, text4);
								flag = true;
							}
							streamWriter.WriteLine(text5);
						}
						streamReader.Close();
						streamWriter.Close();
					}
				}
				else
				{
					FifaEnvironment.CloneIntoZdata(array[i], array2[i]);
				}
			}
			return true;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		public bool CloneGlares(int newId, int timeofday)
		{
			string[] array = Stadium.GlaresLightFileNames(base.Id, timeofday);
			string[] array2 = Stadium.GlaresLightFileNames(newId, timeofday);
			string text = FifaEnvironment.GameDir + Path.GetDirectoryName(array2[0]);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (Path.GetExtension(array[i]).ToLower() == ".lnx")
				{
					string text2 = FifaEnvironment.TempFolder + "\\" + array[i];
					string text3 = "glares_" + base.Id.ToString() + "_";
					string text4 = "glares_" + newId.ToString() + "_";
					if (FifaEnvironment.ExportFileFromZdata(array[i], FifaEnvironment.TempFolder))
					{
						StreamWriter streamWriter = new StreamWriter(FifaEnvironment.GameDir + array2[i]);
						StreamReader streamReader = new StreamReader(text2);
						bool flag = false;
						string text5;
						while ((text5 = streamReader.ReadLine()) != null)
						{
							if (!flag && text5.Contains(text3))
							{
								text5 = text5.Replace(text3, text4);
								flag = true;
							}
							streamWriter.WriteLine(text5);
						}
						streamReader.Close();
						streamWriter.Close();
					}
				}
				else
				{
					FifaEnvironment.CloneIntoZdata(array[i], array2[i]);
				}
			}
			return true;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003ED74 File Offset: 0x0003CF74
		public bool SetGlaresLight(string[] sourceFileNames, int timeofday)
		{
			string[] array = Stadium.GlaresLightFileNames(base.Id, timeofday);
			bool flag = true;
			if (sourceFileNames.Length != array.Length)
			{
				return false;
			}
			for (int i = 0; i < sourceFileNames.Length; i++)
			{
				flag = File.Exists(sourceFileNames[i]) && flag && FifaEnvironment.ImportFileIntoZdataAs(sourceFileNames[i], array[i], false, ECompressionMode.Chunkzip);
			}
			return flag;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003EDCC File Offset: 0x0003CFCC
		public bool SetGlaresLight(string[] sourceFileNames)
		{
			string[] array = Stadium.GlaresLightFileNames(base.Id);
			bool flag = true;
			if (sourceFileNames.Length != array.Length)
			{
				return false;
			}
			for (int i = 0; i < sourceFileNames.Length; i++)
			{
				flag = File.Exists(sourceFileNames[i]) && flag && FifaEnvironment.ImportFileIntoZdataAs(sourceFileNames[i], array[i], false, ECompressionMode.Chunkzip);
			}
			return flag;
		}

		// Token: 0x04000FF6 RID: 4086
		private string m_name;

		// Token: 0x04000FF7 RID: 4087
		private int m_countrycode;

		// Token: 0x04000FF8 RID: 4088
		private Country m_Country;

		// Token: 0x04000FF9 RID: 4089
		private int m_policetypecode;

		// Token: 0x04000FFA RID: 4090
		private int m_sectionfacedbydefault;

		// Token: 0x04000FFB RID: 4091
		private int m_hometeamid;

		// Token: 0x04000FFC RID: 4092
		private Team m_HomeTeam;

		// Token: 0x04000FFD RID: 4093
		private int m_capacity;

		// Token: 0x04000FFE RID: 4094
		private int m_yearbuilt;

		// Token: 0x04000FFF RID: 4095
		private int m_seatcolor;

		// Token: 0x04001000 RID: 4096
		private int m_stadiumtype;

		// Token: 0x04001001 RID: 4097
		private int m_stadiumgoalnetstyle;

		// Token: 0x04001002 RID: 4098
		private int m_stadiumgloalnetdepth;

		// Token: 0x04001003 RID: 4099
		private int m_stadiumgoalnetlength;

		// Token: 0x04001004 RID: 4100
		private int m_stadiumgoalnetwidth;

		// Token: 0x04001005 RID: 4101
		private int m_stadiummowpattern_code;

		// Token: 0x04001006 RID: 4102
		private int m_stadiumpitchlength;

		// Token: 0x04001007 RID: 4103
		private int m_stadiumpitchwidth;

		// Token: 0x04001008 RID: 4104
		private int m_adboardendlinedistance;

		// Token: 0x04001009 RID: 4105
		private int m_adboardsidelinedistance;

		// Token: 0x0400100A RID: 4106
		private int m_adboardtype;

		// Token: 0x0400100B RID: 4107
		private int[] m_timeofday = new int[4];

		// Token: 0x0400100C RID: 4108
		private int[] m_todweather = new int[4];

		// Token: 0x0400100D RID: 4109
		private int m_dlc;

		// Token: 0x0400100E RID: 4110
		private int m_stadiumgoalnettype;

		// Token: 0x0400100F RID: 4111
		private int m_stadiumgoalnetpattern;

		// Token: 0x04001010 RID: 4112
		private int m_stadiumgoalnettension;

		// Token: 0x04001011 RID: 4113
		private int m_cameraheight;

		// Token: 0x04001012 RID: 4114
		private int m_camerazoom;

		// Token: 0x04001013 RID: 4115
		private string m_LocalName;

		// Token: 0x04001014 RID: 4116
		private int m_managerhometopleftx;

		// Token: 0x04001015 RID: 4117
		private int m_managerhometoplefty;

		// Token: 0x04001016 RID: 4118
		private int m_managerhomebotrightx;

		// Token: 0x04001017 RID: 4119
		private int m_managerhomebotrighty;

		// Token: 0x04001018 RID: 4120
		private int m_managerawaytoplefty;

		// Token: 0x04001019 RID: 4121
		private int m_managerawaytopleftx;

		// Token: 0x0400101A RID: 4122
		private int m_managerawaybotrightx;

		// Token: 0x0400101B RID: 4123
		private int m_managerawaybotrighty;

		// Token: 0x0400101C RID: 4124
		private int m_subshometopleftx;

		// Token: 0x0400101D RID: 4125
		private int m_subshometoplefty;

		// Token: 0x0400101E RID: 4126
		private int m_subshomebotrightx;

		// Token: 0x0400101F RID: 4127
		private int m_subshomebotrighty;

		// Token: 0x04001020 RID: 4128
		private int m_subsawaytopleftx;

		// Token: 0x04001021 RID: 4129
		private int m_subsawaytoplefty;

		// Token: 0x04001022 RID: 4130
		private int m_subsawaybotrightx;

		// Token: 0x04001023 RID: 4131
		private int m_subsawaybotrighty;

		// Token: 0x04001024 RID: 4132
		private int m_upgradetier;

		// Token: 0x04001025 RID: 4133
		private int m_upgradestyle;

		// Token: 0x04001026 RID: 4134
		private int m_iseditable;

		// Token: 0x04001027 RID: 4135
		private int m_isdynamic;

		// Token: 0x04001028 RID: 4136
		private int m_genericrank;

		// Token: 0x04001029 RID: 4137
		private int m_islicensed;

		// Token: 0x0400102A RID: 4138
		private int m_stadhometechzoneminx;

		// Token: 0x0400102B RID: 4139
		private int m_stadhometechzonemaxx;

		// Token: 0x0400102C RID: 4140
		private int m_stadhometechzoneminz;

		// Token: 0x0400102D RID: 4141
		private int m_stadhometechzonemaxz;

		// Token: 0x0400102E RID: 4142
		private int m_stadawaytechzoneminx;

		// Token: 0x0400102F RID: 4143
		private int m_stadawaytechzonemaxx;

		// Token: 0x04001030 RID: 4144
		private int m_stadawaytechzoneminz;

		// Token: 0x04001031 RID: 4145
		private int m_stadawaytechzonemaxz;

		// Token: 0x020000C5 RID: 197
		public enum ETimeOfDay
		{
			// Token: 0x0400128D RID: 4749
			Cloudy,
			// Token: 0x0400128E RID: 4750
			Sunny,
			// Token: 0x0400128F RID: 4751
			Night = 3,
			// Token: 0x04001290 RID: 4752
			Sunset
		}

		// Token: 0x020000C6 RID: 198
		public enum EWeather
		{
			// Token: 0x04001292 RID: 4754
			Dry,
			// Token: 0x04001293 RID: 4755
			CanRain,
			// Token: 0x04001294 RID: 4756
			CanSnow = 3
		}
	}
}
