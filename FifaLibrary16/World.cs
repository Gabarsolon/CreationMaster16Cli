using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000087 RID: 135
	public class World : Compobj
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x0004A1E0 File Offset: 0x000483E0
		public World(int id, string typeString, string description)
			: base(id, 0, typeString, description, null)
		{
			this.m_Confederations = new ConfederationList();
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0004A2AA File Offset: 0x000484AA
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0004A2B2 File Offset: 0x000484B2
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0004A2BB File Offset: 0x000484BB
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0004A2C3 File Offset: 0x000484C3
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0004A2CC File Offset: 0x000484CC
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0004A2D4 File Offset: 0x000484D4
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0004A2DD File Offset: 0x000484DD
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x0004A2E5 File Offset: 0x000484E5
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

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x0004A2EE File Offset: 0x000484EE
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x0004A2F6 File Offset: 0x000484F6
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

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0004A2FF File Offset: 0x000484FF
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x0004A307 File Offset: 0x00048507
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

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0004A310 File Offset: 0x00048510
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x0004A318 File Offset: 0x00048518
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

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0004A321 File Offset: 0x00048521
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0004A329 File Offset: 0x00048529
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0004A332 File Offset: 0x00048532
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0004A33A File Offset: 0x0004853A
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

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0004A343 File Offset: 0x00048543
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0004A34B File Offset: 0x0004854B
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0004A354 File Offset: 0x00048554
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x0004A35C File Offset: 0x0004855C
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

		// Token: 0x06000D3C RID: 3388 RVA: 0x0004A368 File Offset: 0x00048568
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

		// Token: 0x040010E8 RID: 4328
		private int[] m_DryProb = new int[12];

		// Token: 0x040010E9 RID: 4329
		private int[] m_ClearProb = new int[12];

		// Token: 0x040010EA RID: 4330
		private int[] m_HazyProb = new int[12];

		// Token: 0x040010EB RID: 4331
		private int[] m_CloudyProb = new int[12];

		// Token: 0x040010EC RID: 4332
		private int[] m_RainProb = new int[12];

		// Token: 0x040010ED RID: 4333
		private int[] m_ShowersProb = new int[12];

		// Token: 0x040010EE RID: 4334
		private int[] m_SnowProb = new int[12];

		// Token: 0x040010EF RID: 4335
		private int[] m_FlurriesProb = new int[12];

		// Token: 0x040010F0 RID: 4336
		private int[] m_OvercastProb = new int[12];

		// Token: 0x040010F1 RID: 4337
		private int[] m_FoggyProb = new int[12];

		// Token: 0x040010F2 RID: 4338
		private int[] m_SunsetTime = new int[12];

		// Token: 0x040010F3 RID: 4339
		private int[] m_DarkTime = new int[12];
	}
}
