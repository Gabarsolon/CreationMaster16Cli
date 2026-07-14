using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008A RID: 138
	public class Nation : Compobj
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0004A77F File Offset: 0x0004897F
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0004A787 File Offset: 0x00048987
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				base.Settings.m_nation_id = ((this.m_Country != null) ? this.m_Country.Id : (-1));
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004A7B1 File Offset: 0x000489B1
		public override void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(base.Settings.m_nation_id);
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x0004A7D3 File Offset: 0x000489D3
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0004A7DB File Offset: 0x000489DB
		public int[] ClearProb
		{
			get
			{
				return this.m_ClearProb;
			}
			set
			{
				this.m_ClearProb = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0004A7E4 File Offset: 0x000489E4
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0004A7EC File Offset: 0x000489EC
		public int[] HazyProb
		{
			get
			{
				return this.m_HazyProb;
			}
			set
			{
				this.m_HazyProb = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0004A7F5 File Offset: 0x000489F5
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0004A7FD File Offset: 0x000489FD
		public int[] CloudyProb
		{
			get
			{
				return this.m_CloudyProb;
			}
			set
			{
				this.m_CloudyProb = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004A806 File Offset: 0x00048A06
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0004A80E File Offset: 0x00048A0E
		public int[] DryProb
		{
			get
			{
				return this.m_DryProb;
			}
			set
			{
				this.m_DryProb = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0004A817 File Offset: 0x00048A17
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x0004A81F File Offset: 0x00048A1F
		public int[] RainProb
		{
			get
			{
				return this.m_RainProb;
			}
			set
			{
				this.m_RainProb = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0004A828 File Offset: 0x00048A28
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x0004A830 File Offset: 0x00048A30
		public int[] ShowersProb
		{
			get
			{
				return this.m_ShowersProb;
			}
			set
			{
				this.m_ShowersProb = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0004A839 File Offset: 0x00048A39
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x0004A841 File Offset: 0x00048A41
		public int[] SnowProb
		{
			get
			{
				return this.m_SnowProb;
			}
			set
			{
				this.m_SnowProb = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0004A84A File Offset: 0x00048A4A
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0004A852 File Offset: 0x00048A52
		public int[] FlurriesProb
		{
			get
			{
				return this.m_FlurriesProb;
			}
			set
			{
				this.m_FlurriesProb = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0004A85B File Offset: 0x00048A5B
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x0004A863 File Offset: 0x00048A63
		public int[] OvercastProb
		{
			get
			{
				return this.m_OvercastProb;
			}
			set
			{
				this.m_OvercastProb = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0004A86C File Offset: 0x00048A6C
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x0004A874 File Offset: 0x00048A74
		public int[] FoggyProb
		{
			get
			{
				return this.m_FoggyProb;
			}
			set
			{
				this.m_FoggyProb = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0004A87D File Offset: 0x00048A7D
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0004A885 File Offset: 0x00048A85
		public int[] SunsetTime
		{
			get
			{
				return this.m_SunsetTime;
			}
			set
			{
				this.m_SunsetTime = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0004A88E File Offset: 0x00048A8E
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0004A896 File Offset: 0x00048A96
		public int[] DarkTime
		{
			get
			{
				return this.m_DarkTime;
			}
			set
			{
				this.m_DarkTime = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0004A89F File Offset: 0x00048A9F
		public Confederation Confederation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 1)
				{
					return (Confederation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0004A8BC File Offset: 0x00048ABC
		public Nation(int id, string typeString, string description, Compobj parentObj)
			: base(id, 2, typeString, description, parentObj)
		{
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004A97C File Offset: 0x00048B7C
		public override bool SaveToWeather(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			for (int i = 0; i < 12; i++)
			{
				if (this.m_ClearProb[i] + this.m_HazyProb[i] + this.m_CloudyProb[i] + this.m_RainProb[i] + this.m_ShowersProb[i] + this.m_SnowProb[i] + this.m_FlurriesProb[i] + this.m_OvercastProb[i] + this.m_FoggyProb[i] == 100)
				{
					string text = string.Concat(new string[]
					{
						base.Id.ToString(),
						",",
						(i + 1).ToString(),
						",",
						this.m_ClearProb[i].ToString(),
						",",
						this.m_HazyProb[i].ToString(),
						",",
						this.m_CloudyProb[i].ToString(),
						",",
						this.m_RainProb[i].ToString(),
						",",
						this.m_ShowersProb[i].ToString(),
						",",
						this.m_SnowProb[i].ToString(),
						",",
						this.m_FlurriesProb[i].ToString(),
						",",
						this.m_OvercastProb[i].ToString(),
						",",
						this.m_FoggyProb[i].ToString(),
						",",
						this.m_SunsetTime[i].ToString(),
						",",
						this.m_DarkTime[i].ToString()
					});
					w.WriteLine(text);
				}
			}
			return true;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004AB78 File Offset: 0x00048D78
		public bool RemoveTrophy()
		{
			if (this.m_Trophies.Count < 1)
			{
				return false;
			}
			Trophy trophy = (Trophy)this.m_Trophies[this.m_Trophies.Count - 1];
			this.m_Trophies.Remove(trophy);
			FifaEnvironment.CompetitionObjects.Remove(trophy);
			trophy.RemoveAllStages();
			return true;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0004ABD4 File Offset: 0x00048DD4
		public bool RemoveAllTrophies()
		{
			int count = this.m_Trophies.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveTrophy();
			}
			return true;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public override void Normalize()
		{
		}

		// Token: 0x040010F5 RID: 4341
		private Country m_Country;

		// Token: 0x040010F6 RID: 4342
		private int[] m_ClearProb = new int[12];

		// Token: 0x040010F7 RID: 4343
		private int[] m_HazyProb = new int[12];

		// Token: 0x040010F8 RID: 4344
		private int[] m_CloudyProb = new int[12];

		// Token: 0x040010F9 RID: 4345
		private int[] m_DryProb = new int[12];

		// Token: 0x040010FA RID: 4346
		private int[] m_RainProb = new int[12];

		// Token: 0x040010FB RID: 4347
		private int[] m_ShowersProb = new int[12];

		// Token: 0x040010FC RID: 4348
		private int[] m_SnowProb = new int[12];

		// Token: 0x040010FD RID: 4349
		private int[] m_FlurriesProb = new int[12];

		// Token: 0x040010FE RID: 4350
		private int[] m_OvercastProb = new int[12];

		// Token: 0x040010FF RID: 4351
		private int[] m_FoggyProb = new int[12];

		// Token: 0x04001100 RID: 4352
		private int[] m_SunsetTime = new int[12];

		// Token: 0x04001101 RID: 4353
		private int[] m_DarkTime = new int[12];
	}
}
