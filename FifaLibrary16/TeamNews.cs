using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000016 RID: 22
	public class TeamNews : IdObject
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004741 File Offset: 0x00002941
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00004749 File Offset: 0x00002949
		public int maxvariationsneg
		{
			get
			{
				return this.m_maxvariationsneg;
			}
			set
			{
				this.m_maxvariationsneg = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004752 File Offset: 0x00002952
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000475A File Offset: 0x0000295A
		public int maxvariationspos
		{
			get
			{
				return this.m_maxvariationspos;
			}
			set
			{
				this.m_maxvariationspos = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004763 File Offset: 0x00002963
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000476B File Offset: 0x0000296B
		public int maxvariationsstd
		{
			get
			{
				return this.m_maxvariationsstd;
			}
			set
			{
				this.m_maxvariationsstd = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004774 File Offset: 0x00002974
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000477C File Offset: 0x0000297C
		public int teamId
		{
			get
			{
				return this.m_teamId;
			}
			set
			{
				this.m_teamId = value;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004785 File Offset: 0x00002985
		public TeamNews(int teamId)
			: base(teamId)
		{
			this.m_crestweight = 25;
			this.m_genericweight = 25;
			this.m_teamweight = 50;
			this.m_maxvariationsneg = 0;
			this.m_maxvariationspos = 0;
			this.m_maxvariationsstd = 0;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000047BC File Offset: 0x000029BC
		public TeamNews(Record r)
			: base(r.IntField[FI.career_newspicweights_teamid])
		{
			this.m_crestweight = r.GetAndCheckIntField(FI.career_newspicweights_crestweight);
			this.m_genericweight = r.GetAndCheckIntField(FI.career_newspicweights_genericweight);
			this.m_teamweight = r.GetAndCheckIntField(FI.career_newspicweights_teamweight);
			this.m_maxvariationsneg = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationsneg);
			this.m_maxvariationspos = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationspos);
			this.m_maxvariationsstd = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationsstd);
			this.m_teamId = r.GetAndCheckIntField(FI.career_newspicweights_teamid);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004854 File Offset: 0x00002A54
		public void Save(Record r)
		{
			r.IntField[FI.career_newspicweights_teamid] = base.Id;
			r.IntField[FI.career_newspicweights_crestweight] = this.m_crestweight;
			r.IntField[FI.career_newspicweights_genericweight] = this.m_genericweight;
			r.IntField[FI.career_newspicweights_teamweight] = this.m_teamweight;
			r.IntField[FI.career_newspicweights_maxvariationsneg] = this.m_maxvariationsneg;
			r.IntField[FI.career_newspicweights_maxvariationspos] = this.m_maxvariationspos;
			r.IntField[FI.career_newspicweights_maxvariationsstd] = this.m_maxvariationsstd;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000048E0 File Offset: 0x00002AE0
		public static string TeamNewsDdsFileName(int teamid, int newsType, int order)
		{
			return string.Concat(new string[]
			{
				"data/ui/imgassets/cmnews/nw_",
				teamid.ToString(),
				"_",
				newsType.ToString(),
				"_",
				order.ToString(),
				".dds"
			});
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004936 File Offset: 0x00002B36
		public static Bitmap GetTeamNews(int teamid, int newsType, int order)
		{
			return FifaEnvironment.GetDdsArtasset(TeamNews.TeamNewsDdsFileName(teamid, newsType, order));
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004945 File Offset: 0x00002B45
		public static string TeamNewsDdsTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/cmnews/2014_nw_#_%_@.dds";
			}
			return "data/ui/imgassets/cmnews/nw_#_%_@.dds";
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000495C File Offset: 0x00002B5C
		public static bool SetTeamNews(int teamid, int newsType, int order, Bitmap bitmap)
		{
			int[] array = new int[3];
			string[] array2 = new string[3];
			array[0] = teamid;
			array[1] = newsType;
			array[2] = order;
			array2[0] = (array2[1] = (array2[2] = "D"));
			return FifaEnvironment.SetDdsArtasset(TeamNews.TeamNewsDdsTemplateFileName(), array, bitmap, array2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000049A4 File Offset: 0x00002BA4
		public static bool DeleteTeamNews(int teamid, int newsType, int order)
		{
			return FifaEnvironment.DeleteFromZdata(TeamNews.TeamNewsDdsFileName(teamid, newsType, order));
		}

		// Token: 0x0400001B RID: 27
		private int m_crestweight;

		// Token: 0x0400001C RID: 28
		private int m_genericweight;

		// Token: 0x0400001D RID: 29
		private int m_teamweight;

		// Token: 0x0400001E RID: 30
		private int m_maxvariationsneg;

		// Token: 0x0400001F RID: 31
		private int m_maxvariationspos;

		// Token: 0x04000020 RID: 32
		private int m_maxvariationsstd;

		// Token: 0x04000021 RID: 33
		private int m_teamId;
	}
}
