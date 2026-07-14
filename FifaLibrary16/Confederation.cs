using System;

namespace FifaLibrary
{
	// Token: 0x02000088 RID: 136
	public class Confederation : Compobj
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x0004A564 File Offset: 0x00048764
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x0004A56C File Offset: 0x0004876C
		public World World
		{
			get
			{
				return this.m_World;
			}
			set
			{
				this.m_World = value;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0004A575 File Offset: 0x00048775
		public Confederation(int id, string typeString, string description, Compobj parentObj)
			: base(id, 1, typeString, description, parentObj)
		{
			this.m_Nations = new NationList();
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0004A59C File Offset: 0x0004879C
		public bool AddTrophy(int assetId)
		{
			if (assetId >= 1000)
			{
				return false;
			}
			int count = base.Trophies.Count;
			string text = "C" + assetId.ToString();
			string text2 = "TrophyName_Abbr15_" + assetId.ToString();
			Trophy trophy = new Trophy(FifaEnvironment.CompetitionObjects.GetNewId(), text, text2, this);
			if (trophy == null)
			{
				return false;
			}
			base.Trophies.Add(trophy);
			FifaEnvironment.CompetitionObjects.Add(trophy);
			trophy.AddStage();
			return true;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0004A61C File Offset: 0x0004881C
		public bool RemoveTrophy(int trophyId)
		{
			if (this.m_Trophies.Count < 1)
			{
				return false;
			}
			Trophy trophy = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(trophyId);
			if (trophy == null)
			{
				return false;
			}
			this.m_Trophies.Remove(trophy);
			FifaEnvironment.CompetitionObjects.Remove(trophy);
			trophy.RemoveAllStages();
			return true;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0004A670 File Offset: 0x00048870
		public bool AddNation(Country country)
		{
			int count = base.Nations.Count;
			string text = country.DatabaseName.Substring(0, 4);
			string text2 = "NationName_" + country.Id.ToString();
			Nation nation = new Nation(FifaEnvironment.CompetitionObjects.GetNewId(), text, text2, this);
			if (nation == null)
			{
				return false;
			}
			base.Nations.Add(nation);
			FifaEnvironment.CompetitionObjects.Add(nation);
			return true;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0004A6E4 File Offset: 0x000488E4
		public bool RemoveNation()
		{
			if (this.m_Nations.Count < 1)
			{
				return false;
			}
			Nation nation = (Nation)this.m_Nations[this.m_Nations.Count - 1];
			this.m_Nations.Remove(nation);
			FifaEnvironment.CompetitionObjects.Remove(nation);
			nation.RemoveAllTrophies();
			return true;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0004A740 File Offset: 0x00048940
		public bool RemoveAllNations()
		{
			int count = this.m_Nations.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveNation();
			}
			return true;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public override void Normalize()
		{
		}

		// Token: 0x040010F4 RID: 4340
		private World m_World;
	}
}
