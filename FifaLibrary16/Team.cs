using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;

namespace FifaLibrary
{
	// Token: 0x02000080 RID: 128
	public class Team : IdObject
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x0003F100 File Offset: 0x0003D300
		public bool IsInTopLeague()
		{
			if (this.m_League == null)
			{
				return false;
			}
			for (int i = 0; i < Team.c_TopLeaguesId.Length; i++)
			{
				if (this.m_League.Id == Team.c_TopLeaguesId[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003F140 File Offset: 0x0003D340
		public bool IsFemale()
		{
			bool flag = false;
			if (this.m_Roster != null && this.m_Roster.Count > 0)
			{
				flag = this.m_Roster.GetBestPlayer().Player.Female;
			}
			return flag;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0003F17C File Offset: 0x0003D37C
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0003F184 File Offset: 0x0003D384
		public bool ImpatientBoard
		{
			get
			{
				return this.m_ImpatientBoard;
			}
			set
			{
				this.m_ImpatientBoard = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0003F18D File Offset: 0x0003D38D
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0003F195 File Offset: 0x0003D395
		public bool LoyalBoard
		{
			get
			{
				return this.m_LoyalBoard;
			}
			set
			{
				this.m_LoyalBoard = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0003F19E File Offset: 0x0003D39E
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0003F1A6 File Offset: 0x0003D3A6
		public bool SquadRotation
		{
			get
			{
				return this.m_SquadRotation;
			}
			set
			{
				this.m_SquadRotation = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0003F1AF File Offset: 0x0003D3AF
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0003F1B7 File Offset: 0x0003D3B7
		public bool ConsistentLineup
		{
			get
			{
				return this.m_ConsistentLineup;
			}
			set
			{
				this.m_ConsistentLineup = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0003F1C0 File Offset: 0x0003D3C0
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0003F1C8 File Offset: 0x0003D3C8
		public bool SwitchWingers
		{
			get
			{
				return this.m_SwitchWingers;
			}
			set
			{
				this.m_SwitchWingers = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0003F1D1 File Offset: 0x0003D3D1
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x0003F1D9 File Offset: 0x0003D3D9
		public bool CenterBacksSplit
		{
			get
			{
				return this.m_CenterBacksSplit;
			}
			set
			{
				this.m_CenterBacksSplit = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0003F1E2 File Offset: 0x0003D3E2
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0003F1EA File Offset: 0x0003D3EA
		public bool DefendLead
		{
			get
			{
				return this.m_DefendLead;
			}
			set
			{
				this.m_DefendLead = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0003F1F3 File Offset: 0x0003D3F3
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0003F1FB File Offset: 0x0003D3FB
		public bool KeepUpPressure
		{
			get
			{
				return this.m_KeepUpPressure;
			}
			set
			{
				this.m_KeepUpPressure = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0003F204 File Offset: 0x0003D404
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0003F20C File Offset: 0x0003D40C
		public bool MoreAttackingAtHome
		{
			get
			{
				return this.m_MoreAttackingAtHome;
			}
			set
			{
				this.m_MoreAttackingAtHome = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0003F215 File Offset: 0x0003D415
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0003F21D File Offset: 0x0003D41D
		public bool ShortOutBack
		{
			get
			{
				return this.m_ShortOutBack;
			}
			set
			{
				this.m_ShortOutBack = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0003F226 File Offset: 0x0003D426
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0003F22E File Offset: 0x0003D42E
		public int balltype
		{
			get
			{
				return this.m_balltype;
			}
			set
			{
				this.m_balltype = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0003F237 File Offset: 0x0003D437
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0003F23F File Offset: 0x0003D43F
		public int adboardid
		{
			get
			{
				return this.m_adboardid;
			}
			set
			{
				this.m_adboardid = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0003F248 File Offset: 0x0003D448
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x0003F250 File Offset: 0x0003D450
		public bool HasSpecifiAdboard
		{
			get
			{
				return this.m_HasSpecificAdboard;
			}
			set
			{
				this.m_HasSpecificAdboard = value;
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003F259 File Offset: 0x0003D459
		public static string RevModAdboardFileName(int id)
		{
			return Adboard.RevModTeamAdboardFileName(id);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003F261 File Offset: 0x0003D461
		public string RevModAdboardFileName()
		{
			return Adboard.RevModTeamAdboardFileName(base.Id);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003F26E File Offset: 0x0003D46E
		public Bitmap GetRevModAdboard()
		{
			return Adboard.GetRevModTeamAdboard(base.Id);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003F27B File Offset: 0x0003D47B
		public static string RevModNetFileName(int id)
		{
			return Net.RevModNetFileName(id);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003F283 File Offset: 0x0003D483
		public string RevModNetFileName()
		{
			return Net.RevModNetFileName(base.Id);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003F290 File Offset: 0x0003D490
		public Bitmap GetRevModNet()
		{
			return Net.GetRevModNet(base.Id);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003F29D File Offset: 0x0003D49D
		public static string RevModManagerTextureFileName(int id)
		{
			return Manager.RevModManagerTextureFileName(id);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003F2A5 File Offset: 0x0003D4A5
		public string RevModManagerTextureFileName()
		{
			return Manager.RevModManagerTextureFileName(base.Id);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003F2B2 File Offset: 0x0003D4B2
		public static string RevModManagerModleFileName(int id)
		{
			return Manager.RevModManagerModelFileName(id);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003F2BA File Offset: 0x0003D4BA
		public string RevModManagerModelFileName()
		{
			return Manager.RevModManagerModelFileName(base.Id);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003F2C7 File Offset: 0x0003D4C7
		public Rx3File GetRevModManagerModel()
		{
			return Manager.GetRevModManagerModel(base.Id);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0003F2D4 File Offset: 0x0003D4D4
		public Bitmap GetRevModManagerTexture()
		{
			return Manager.GetRevModManagerTextures(base.Id);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003F2E1 File Offset: 0x0003D4E1
		public static string RevModBallTextureFileName(int id)
		{
			return Ball.RevModTeamBallTextureFileName(id);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0003F2E9 File Offset: 0x0003D4E9
		public static string RevModBallModelFileName(int id)
		{
			return Ball.RevModTeamBallModelFileName(id);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0003F2F1 File Offset: 0x0003D4F1
		public string RevModBallTextureFileName()
		{
			return Ball.RevModTeamBallTextureFileName(base.Id);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003F2FE File Offset: 0x0003D4FE
		public string RevModBallModelFileName()
		{
			return Ball.RevModTeamBallModelFileName(base.Id);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003F30B File Offset: 0x0003D50B
		public Bitmap[] GetRevModBallTextures()
		{
			return Ball.GetRevModTeamBallTextures(base.Id);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0003F318 File Offset: 0x0003D518
		public bool SetRevModAdboard(Bitmap bitmap)
		{
			return Adboard.SetRevModTeamAdboard(base.Id, bitmap);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0003F326 File Offset: 0x0003D526
		public bool SetRevModAdboard(string rx3FileName)
		{
			return Adboard.SetRevModTeamAdboard(base.Id, rx3FileName);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0003F334 File Offset: 0x0003D534
		public bool SetRevModNet(Bitmap bitmap)
		{
			return Net.SetRevModNet(base.Id, bitmap);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0003F342 File Offset: 0x0003D542
		public bool SetRevModNet(string rx3FileName)
		{
			return Net.SetRevModNet(base.Id, rx3FileName);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0003F350 File Offset: 0x0003D550
		public bool SetRevModManagerTexture(Bitmap bitmap)
		{
			return Manager.SetRevModManagerTexture(base.Id, bitmap);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0003F350 File Offset: 0x0003D550
		public bool SetRevModManagerModel(Bitmap bitmap)
		{
			return Manager.SetRevModManagerTexture(base.Id, bitmap);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0003F35E File Offset: 0x0003D55E
		public bool SetRevModManagerTexture(string rx3FileName)
		{
			return Manager.SetRevModManagerTexture(base.Id, rx3FileName);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0003F36C File Offset: 0x0003D56C
		public bool SetRevModManagerModel(string rx3FileName)
		{
			return Manager.SetRevModManagerModel(base.Id, rx3FileName);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0003F37A File Offset: 0x0003D57A
		public bool SetRevModBallTextures(Bitmap[] bitmaps)
		{
			return Ball.SetRevModTeamBallTextures(base.Id, bitmaps);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0003F388 File Offset: 0x0003D588
		public bool SetRevModBallTextures(string rx3FileName)
		{
			return Ball.SetRevModTeamBallTextures(base.Id, rx3FileName);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0003F396 File Offset: 0x0003D596
		public bool SetRevModBallModel(string rx3FileName)
		{
			return Ball.SetRevModTeamBallModel(base.Id, rx3FileName);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0003F3A4 File Offset: 0x0003D5A4
		public bool ExportRevModBallTextures(string exportFolder)
		{
			return FifaEnvironment.ExportFileFromZdata(Ball.RevModTeamBallTextureFileName(base.Id), exportFolder);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0003F3B7 File Offset: 0x0003D5B7
		public bool DeleteRevModBallTextures()
		{
			return Ball.DeleteRevModTeamBallTextures(base.Id);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
		public Bitmap GetAdboard()
		{
			Bitmap bitmap = Adboard.GetAdboard(1000000 + base.Id);
			if (bitmap == null)
			{
				bitmap = Adboard.GetAdboard(this.adboardid);
				this.m_HasSpecificAdboard = false;
			}
			else
			{
				this.m_HasSpecificAdboard = true;
			}
			return bitmap;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0003F403 File Offset: 0x0003D603
		public bool SetAdboard(Bitmap bitmap)
		{
			if (this.m_HasSpecificAdboard)
			{
				return Adboard.SetAdboard(1000000 + base.Id, bitmap);
			}
			return Adboard.SetAdboard(this.adboardid, bitmap);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0003F42C File Offset: 0x0003D62C
		public bool CreateSpecificAdboard()
		{
			int num = 1000000 + base.Id;
			Bitmap bitmap = Adboard.GetAdboard(this.adboardid);
			int num2 = 0;
			while (num2 < 20 && bitmap == null)
			{
				bitmap = Adboard.GetAdboard(this.adboardid);
				num2++;
			}
			this.m_HasSpecificAdboard = true;
			return Adboard.SetAdboard(num, bitmap);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0003F47C File Offset: 0x0003D67C
		public bool DeleteSpecificAdboard()
		{
			int num = 1000000 + base.Id;
			this.m_HasSpecificAdboard = false;
			return Adboard.DeleteAdboard(num);
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003F496 File Offset: 0x0003D696
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0003F49E File Offset: 0x0003D69E
		public int stadiumid
		{
			get
			{
				return this.m_stadiumid;
			}
			set
			{
				this.m_stadiumid = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003F4A7 File Offset: 0x0003D6A7
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0003F4AF File Offset: 0x0003D6AF
		public Stadium Stadium
		{
			get
			{
				return this.m_Stadium;
			}
			set
			{
				this.m_Stadium = value;
				if (this.m_Stadium != null)
				{
					this.m_stadiumid = this.m_Stadium.Id;
				}
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0003F4D1 File Offset: 0x0003D6D1
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0003F4D9 File Offset: 0x0003D6D9
		public int rivalteam
		{
			get
			{
				return this.m_rivalteam;
			}
			set
			{
				this.m_rivalteam = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0003F4E2 File Offset: 0x0003D6E2
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x0003F4EA File Offset: 0x0003D6EA
		public Team RivalTeam
		{
			get
			{
				return this.m_RivalTeam;
			}
			set
			{
				this.m_RivalTeam = value;
				if (this.m_RivalTeam != null)
				{
					this.m_rivalteam = this.m_RivalTeam.Id;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0003F50C File Offset: 0x0003D70C
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0003F514 File Offset: 0x0003D714
		public int formationid
		{
			get
			{
				return this.m_formationid;
			}
			set
			{
				this.m_formationid = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003F51D File Offset: 0x0003D71D
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0003F525 File Offset: 0x0003D725
		public Formation Formation
		{
			get
			{
				return this.m_Formation;
			}
			set
			{
				this.m_Formation = value;
				if (this.m_Formation != null)
				{
					this.m_formationid = this.m_Formation.Id;
				}
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0003F547 File Offset: 0x0003D747
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0003F54F File Offset: 0x0003D74F
		public int captainid
		{
			get
			{
				return this.m_captainid;
			}
			set
			{
				this.m_captainid = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0003F558 File Offset: 0x0003D758
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0003F560 File Offset: 0x0003D760
		public int penaltytakerid
		{
			get
			{
				return this.m_penaltytakerid;
			}
			set
			{
				this.m_penaltytakerid = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0003F569 File Offset: 0x0003D769
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x0003F571 File Offset: 0x0003D771
		public int leftfreekicktakerid
		{
			get
			{
				return this.m_leftfreekicktakerid;
			}
			set
			{
				this.m_leftfreekicktakerid = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0003F57A File Offset: 0x0003D77A
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0003F582 File Offset: 0x0003D782
		public int rightfreekicktakerid
		{
			get
			{
				return this.m_rightfreekicktakerid;
			}
			set
			{
				this.m_rightfreekicktakerid = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0003F58B File Offset: 0x0003D78B
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0003F593 File Offset: 0x0003D793
		public int freekicktakerid
		{
			get
			{
				return this.m_freekicktakerid;
			}
			set
			{
				this.m_freekicktakerid = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0003F59C File Offset: 0x0003D79C
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
		public int longkicktakerid
		{
			get
			{
				return this.m_longkicktakerid;
			}
			set
			{
				this.m_longkicktakerid = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0003F5AD File Offset: 0x0003D7AD
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x0003F5B5 File Offset: 0x0003D7B5
		public int leftcornerkicktakerid
		{
			get
			{
				return this.m_leftcornerkicktakerid;
			}
			set
			{
				this.m_leftcornerkicktakerid = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0003F5BE File Offset: 0x0003D7BE
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0003F5C6 File Offset: 0x0003D7C6
		public int rightcornerkicktakerid
		{
			get
			{
				return this.m_rightcornerkicktakerid;
			}
			set
			{
				this.m_rightcornerkicktakerid = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0003F5CF File Offset: 0x0003D7CF
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0003F5D7 File Offset: 0x0003D7D7
		public string TeamNameFull
		{
			get
			{
				return this.m_TeamNameFull;
			}
			set
			{
				this.m_TeamNameFull = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
		public string TeamNameAbbr15
		{
			get
			{
				return this.m_TeamNameAbbr15;
			}
			set
			{
				this.m_TeamNameAbbr15 = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0003F5F1 File Offset: 0x0003D7F1
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0003F5F9 File Offset: 0x0003D7F9
		public string TeamNameAbbr10
		{
			get
			{
				return this.m_TeamNameAbbr10;
			}
			set
			{
				this.m_TeamNameAbbr10 = value;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0003F602 File Offset: 0x0003D802
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0003F60A File Offset: 0x0003D80A
		public string TeamNameAbbr3
		{
			get
			{
				return this.m_TeamNameAbbr3;
			}
			set
			{
				this.m_TeamNameAbbr3 = value;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0003F613 File Offset: 0x0003D813
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0003F61B File Offset: 0x0003D81B
		public string TeamNameAbbr7
		{
			get
			{
				return this.m_TeamNameAbbr7;
			}
			set
			{
				this.m_TeamNameAbbr7 = value;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0003F624 File Offset: 0x0003D824
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0003F62C File Offset: 0x0003D82C
		public string DatabaseName
		{
			get
			{
				return this.m_teamname;
			}
			set
			{
				this.m_teamname = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0003F635 File Offset: 0x0003D835
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x0003F63D File Offset: 0x0003D83D
		public int jerseytype
		{
			get
			{
				return this.m_jerseytype;
			}
			set
			{
				this.m_jerseytype = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0003F646 File Offset: 0x0003D846
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0003F64E File Offset: 0x0003D84E
		public int stafftracksuitcolorcode
		{
			get
			{
				return this.m_stafftracksuitcolorcode;
			}
			set
			{
				this.m_stafftracksuitcolorcode = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0003F657 File Offset: 0x0003D857
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x0003F65F File Offset: 0x0003D85F
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0003F668 File Offset: 0x0003D868
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x0003F670 File Offset: 0x0003D870
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0003F679 File Offset: 0x0003D879
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x0003F681 File Offset: 0x0003D881
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003F68A File Offset: 0x0003D88A
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0003F692 File Offset: 0x0003D892
		public int managerid
		{
			get
			{
				return this.m_managerid;
			}
			set
			{
				this.m_managerid = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0003F69B File Offset: 0x0003D89B
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0003F6A3 File Offset: 0x0003D8A3
		public int latitude
		{
			get
			{
				return this.m_latitude;
			}
			set
			{
				this.m_latitude = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0003F6AC File Offset: 0x0003D8AC
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0003F6B4 File Offset: 0x0003D8B4
		public int longitude
		{
			get
			{
				return this.m_longitude;
			}
			set
			{
				this.m_longitude = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0003F6BD File Offset: 0x0003D8BD
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0003F6C5 File Offset: 0x0003D8C5
		public int bodytypeid
		{
			get
			{
				return this.m_bodytypeid;
			}
			set
			{
				this.m_bodytypeid = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0003F6CE File Offset: 0x0003D8CE
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0003F6D6 File Offset: 0x0003D8D6
		public int suitvariationid
		{
			get
			{
				return this.m_suitvariationid;
			}
			set
			{
				this.m_suitvariationid = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0003F6DF File Offset: 0x0003D8DF
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0003F6E7 File Offset: 0x0003D8E7
		public int suittypeid
		{
			get
			{
				return this.m_suittypeid;
			}
			set
			{
				this.m_suittypeid = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x0003F6F8 File Offset: 0x0003D8F8
		public int personalityid
		{
			get
			{
				return this.m_personalityid;
			}
			set
			{
				this.m_personalityid = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0003F701 File Offset: 0x0003D901
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x0003F709 File Offset: 0x0003D909
		public int busdribbling
		{
			get
			{
				return this.m_busdribbling;
			}
			set
			{
				this.m_busdribbling = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0003F712 File Offset: 0x0003D912
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x0003F71A File Offset: 0x0003D91A
		public int trait1
		{
			get
			{
				return this.m_trait1;
			}
			set
			{
				this.m_trait1 = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0003F723 File Offset: 0x0003D923
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x0003F72B File Offset: 0x0003D92B
		public int utcoffset
		{
			get
			{
				return this.m_utcoffset;
			}
			set
			{
				this.m_utcoffset = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0003F734 File Offset: 0x0003D934
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x0003F73C File Offset: 0x0003D93C
		public int ethnicity
		{
			get
			{
				return this.m_ethnicity;
			}
			set
			{
				this.m_ethnicity = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0003F745 File Offset: 0x0003D945
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x0003F74D File Offset: 0x0003D94D
		public int assetid
		{
			get
			{
				return this.m_assetid;
			}
			set
			{
				this.m_assetid = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0003F756 File Offset: 0x0003D956
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0003F75E File Offset: 0x0003D95E
		public int transferbudget
		{
			get
			{
				return this.m_transferbudget;
			}
			set
			{
				this.m_transferbudget = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x0003F767 File Offset: 0x0003D967
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x0003F76F File Offset: 0x0003D96F
		public int internationalprestige
		{
			get
			{
				return this.m_internationalprestige;
			}
			set
			{
				this.m_internationalprestige = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0003F778 File Offset: 0x0003D978
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0003F780 File Offset: 0x0003D980
		public int domesticprestige
		{
			get
			{
				return this.m_domesticprestige;
			}
			set
			{
				this.m_domesticprestige = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0003F789 File Offset: 0x0003D989
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0003F791 File Offset: 0x0003D991
		public string stadiumcustomname
		{
			get
			{
				return this.m_stadiumcustomname;
			}
			set
			{
				this.m_stadiumcustomname = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0003F79A File Offset: 0x0003D99A
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0003F7A2 File Offset: 0x0003D9A2
		public string ManagerFirstName
		{
			get
			{
				return this.m_ManagerFirstName;
			}
			set
			{
				this.m_ManagerFirstName = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0003F7AB File Offset: 0x0003D9AB
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x0003F7B3 File Offset: 0x0003D9B3
		public string ManagerSurname
		{
			get
			{
				return this.m_ManagerSurname;
			}
			set
			{
				this.m_ManagerSurname = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0003F7C4 File Offset: 0x0003D9C4
		public int busbuildupspeed
		{
			get
			{
				return this.m_busbuildupspeed;
			}
			set
			{
				this.m_busbuildupspeed = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0003F7CD File Offset: 0x0003D9CD
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0003F7D5 File Offset: 0x0003D9D5
		public int buspassing
		{
			get
			{
				return this.m_buspassing;
			}
			set
			{
				this.m_buspassing = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0003F7DE File Offset: 0x0003D9DE
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0003F7E6 File Offset: 0x0003D9E6
		public int buspositioning
		{
			get
			{
				return this.m_buspositioning;
			}
			set
			{
				this.m_buspositioning = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0003F7EF File Offset: 0x0003D9EF
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x0003F7F7 File Offset: 0x0003D9F7
		public int ccpassing
		{
			get
			{
				return this.m_ccpassing;
			}
			set
			{
				this.m_ccpassing = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003F800 File Offset: 0x0003DA00
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0003F808 File Offset: 0x0003DA08
		public int cccrossing
		{
			get
			{
				return this.m_cccrossing;
			}
			set
			{
				this.m_cccrossing = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003F811 File Offset: 0x0003DA11
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x0003F819 File Offset: 0x0003DA19
		public int ccshooting
		{
			get
			{
				return this.m_ccshooting;
			}
			set
			{
				this.m_ccshooting = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003F822 File Offset: 0x0003DA22
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0003F82A File Offset: 0x0003DA2A
		public int ccpositioning
		{
			get
			{
				return this.m_ccpositioning;
			}
			set
			{
				this.m_ccpositioning = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0003F833 File Offset: 0x0003DA33
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x0003F83B File Offset: 0x0003DA3B
		public int defmentality
		{
			get
			{
				return this.m_defmentality;
			}
			set
			{
				this.m_defmentality = value;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0003F844 File Offset: 0x0003DA44
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0003F84C File Offset: 0x0003DA4C
		public int defaggression
		{
			get
			{
				return this.m_defaggression;
			}
			set
			{
				this.m_defaggression = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0003F855 File Offset: 0x0003DA55
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0003F85D File Offset: 0x0003DA5D
		public int defteamwidth
		{
			get
			{
				return this.m_defteamwidth;
			}
			set
			{
				this.m_defteamwidth = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0003F866 File Offset: 0x0003DA66
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0003F86E File Offset: 0x0003DA6E
		public int defdefenderline
		{
			get
			{
				return this.m_defdefenderline;
			}
			set
			{
				this.m_defdefenderline = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0003F877 File Offset: 0x0003DA77
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0003F87F File Offset: 0x0003DA7F
		public int midfieldrating
		{
			get
			{
				return this.m_midfieldrating;
			}
			set
			{
				this.m_midfieldrating = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0003F888 File Offset: 0x0003DA88
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0003F890 File Offset: 0x0003DA90
		public int defenserating
		{
			get
			{
				return this.m_defenserating;
			}
			set
			{
				this.m_defenserating = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0003F899 File Offset: 0x0003DA99
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0003F8A1 File Offset: 0x0003DAA1
		public int attackrating
		{
			get
			{
				return this.m_attackrating;
			}
			set
			{
				this.m_attackrating = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003F8AA File Offset: 0x0003DAAA
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0003F8B2 File Offset: 0x0003DAB2
		public int overallrating
		{
			get
			{
				return this.m_overallrating;
			}
			set
			{
				this.m_overallrating = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003F8BB File Offset: 0x0003DABB
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0003F8C3 File Offset: 0x0003DAC3
		public int matchdayoverallrating
		{
			get
			{
				return this.m_matchdayoverallrating;
			}
			set
			{
				this.m_matchdayoverallrating = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003F8CC File Offset: 0x0003DACC
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
		public int matchdaydefenserating
		{
			get
			{
				return this.m_matchdaydefenserating;
			}
			set
			{
				this.m_matchdaydefenserating = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003F8DD File Offset: 0x0003DADD
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0003F8E5 File Offset: 0x0003DAE5
		public int matchdaymidfieldrating
		{
			get
			{
				return this.m_matchdaymidfieldrating;
			}
			set
			{
				this.m_matchdaymidfieldrating = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003F8EE File Offset: 0x0003DAEE
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0003F8F6 File Offset: 0x0003DAF6
		public int matchdayattackrating
		{
			get
			{
				return this.m_matchdayattackrating;
			}
			set
			{
				this.m_matchdayattackrating = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003F8FF File Offset: 0x0003DAFF
		public Roster Roster
		{
			get
			{
				return this.m_Roster;
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003F907 File Offset: 0x0003DB07
		private void SetCountryAsNationalTeam(Country country)
		{
			this.m_Country = country;
			this.m_countryid_IfNationalTeam = country.Id;
			this.m_countryid_IfRowTeam = 0;
			this.m_countryid_IfLeagueTeam = 0;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003F92A File Offset: 0x0003DB2A
		private void SetCountryAsRowTeam(Country country)
		{
			if (country == null)
			{
				return;
			}
			this.m_Country = country;
			this.m_countryid_IfNationalTeam = 0;
			this.m_countryid_IfRowTeam = country.Id;
			this.m_countryid_IfLeagueTeam = 0;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0003F951 File Offset: 0x0003DB51
		private void SetCountryAsLeagueTeam(Country country)
		{
			this.m_Country = country;
			this.m_countryid_IfNationalTeam = 0;
			this.m_countryid_IfRowTeam = 0;
			this.m_countryid_IfLeagueTeam = country.Id;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0003F974 File Offset: 0x0003DB74
		private void ClearCountry()
		{
			this.m_Country = null;
			this.m_countryid_IfNationalTeam = 0;
			this.m_countryid_IfRowTeam = 0;
			this.m_countryid_IfLeagueTeam = 0;
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0003F992 File Offset: 0x0003DB92
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0003F99C File Offset: 0x0003DB9C
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				if (value == this.m_Country)
				{
					return;
				}
				if (this.IsNationalTeam())
				{
					if (this.m_Country != null)
					{
						this.m_Country.NationalTeam = null;
					}
					value.SetNationalTeam(this, base.Id);
					this.SetCountryAsNationalTeam(value);
					return;
				}
				if (value != null)
				{
					if (this.m_League == null)
					{
						this.SetCountryAsRowTeam(value);
						return;
					}
					if (value.Id == this.m_League.Country.Id)
					{
						this.SetCountryAsLeagueTeam(value);
						return;
					}
					this.SetCountryAsRowTeam(value);
					return;
				}
				else
				{
					if (this.m_League != null)
					{
						this.SetCountryAsLeagueTeam(this.m_League.Country);
						return;
					}
					this.ClearCountry();
					return;
				}
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003FA3F File Offset: 0x0003DC3F
		private void SetAsNationalTeam(Country country)
		{
			this.SetCountryAsNationalTeam(country);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0003FA48 File Offset: 0x0003DC48
		private void UnsetAsNationalTeam()
		{
			if (this.m_League != null && this.m_League.Country != null && this.m_Country == this.m_League.Country)
			{
				this.SetCountryAsLeagueTeam(this.m_Country);
			}
			this.SetCountryAsRowTeam(this.m_Country);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003FA95 File Offset: 0x0003DC95
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0003FA9D File Offset: 0x0003DC9D
		public bool NationalTeam
		{
			get
			{
				return this.IsNationalTeam();
			}
			set
			{
				if (value)
				{
					this.SetAsNationalTeam(this.m_Country);
					return;
				}
				this.UnsetAsNationalTeam();
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0003FAB5 File Offset: 0x0003DCB5
		public bool IsNationalTeam()
		{
			return this.m_countryid_IfNationalTeam != 0;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003FAC0 File Offset: 0x0003DCC0
		public bool IsRowTeam()
		{
			return !this.IsNationalTeam() && this.m_countryid_IfRowTeam > 0 && this.m_countryid_IfRowTeam != this.m_countryid_IfLeagueTeam;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
		public bool IsLeagueTeam()
		{
			return !this.IsNationalTeam() && !this.IsRowTeam() && this.m_countryid_IfLeagueTeam > 0;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0003FB04 File Offset: 0x0003DD04
		public bool IsClub()
		{
			return !this.IsNationalTeam() && base.Id != 111072 && base.Id != 111205 && base.Id != 112190 && base.Id != 111596 && base.Id != 111592;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003FB5F File Offset: 0x0003DD5F
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0003FB68 File Offset: 0x0003DD68
		public League League
		{
			get
			{
				return this.m_League;
			}
			set
			{
				if (value == null)
				{
					if (this.m_Country != null && this.IsLeagueTeam())
					{
						this.SetCountryAsRowTeam(this.m_Country);
					}
					this.m_League = League.GetDefaultLeague();
					this.m_leagueid = League.GetDefaultLeagueId();
					return;
				}
				this.m_League = value;
				this.m_leagueid = this.m_League.Id;
				if (this.m_League.Country != null && !this.IsNationalTeam())
				{
					if (this.IsRowTeam())
					{
						if (this.m_Country == this.m_League.Country)
						{
							this.SetCountryAsLeagueTeam(this.m_Country);
							return;
						}
					}
					else if (this.m_Country != null && this.m_Country != this.m_League.Country)
					{
						this.SetCountryAsRowTeam(this.m_Country);
					}
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003FC27 File Offset: 0x0003DE27
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0003FC2F File Offset: 0x0003DE2F
		public League PrevLeague
		{
			get
			{
				return this.m_PrevLeague;
			}
			set
			{
				if (value == null)
				{
					this.m_PrevLeague = null;
					this.m_prevleagueid = 0;
					return;
				}
				this.m_PrevLeague = value;
				this.m_prevleagueid = this.m_PrevLeague.Id;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0003FC5B File Offset: 0x0003DE5B
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0003FC63 File Offset: 0x0003DE63
		public bool IsChampion
		{
			get
			{
				return this.m_champion;
			}
			set
			{
				this.m_champion = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0003FC6C File Offset: 0x0003DE6C
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0003FC74 File Offset: 0x0003DE74
		public int previousyeartableposition
		{
			get
			{
				return this.m_previousyeartableposition;
			}
			set
			{
				this.m_previousyeartableposition = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0003FC7D File Offset: 0x0003DE7D
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0003FC85 File Offset: 0x0003DE85
		public int currenttableposition
		{
			get
			{
				return this.m_currenttableposition;
			}
			set
			{
				this.m_currenttableposition = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0003FC8E File Offset: 0x0003DE8E
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0003FC96 File Offset: 0x0003DE96
		public int teamshortform
		{
			get
			{
				return this.m_teamshortform;
			}
			set
			{
				this.m_teamshortform = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0003FC9F File Offset: 0x0003DE9F
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0003FCA7 File Offset: 0x0003DEA7
		public int teamlongform
		{
			get
			{
				return this.m_teamlongform;
			}
			set
			{
				this.m_teamlongform = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
		public int teamform
		{
			get
			{
				return this.m_teamform;
			}
			set
			{
				this.m_teamform = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0003FCC1 File Offset: 0x0003DEC1
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0003FCC9 File Offset: 0x0003DEC9
		public bool hasachievedobjective
		{
			get
			{
				return this.m_hasachievedobjective;
			}
			set
			{
				this.m_hasachievedobjective = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0003FCD2 File Offset: 0x0003DED2
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0003FCDA File Offset: 0x0003DEDA
		public bool yettowin
		{
			get
			{
				return this.m_yettowin;
			}
			set
			{
				this.m_yettowin = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0003FCE3 File Offset: 0x0003DEE3
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0003FCEB File Offset: 0x0003DEEB
		public bool unbeatenallcomps
		{
			get
			{
				return this.m_unbeatenallcomps;
			}
			set
			{
				this.m_unbeatenallcomps = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0003FCF4 File Offset: 0x0003DEF4
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x0003FCFC File Offset: 0x0003DEFC
		public bool unbeatenaway
		{
			get
			{
				return this.m_unbeatenaway;
			}
			set
			{
				this.m_unbeatenaway = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003FD05 File Offset: 0x0003DF05
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0003FD0D File Offset: 0x0003DF0D
		public bool unbeatenhome
		{
			get
			{
				return this.m_unbeatenhome;
			}
			set
			{
				this.m_unbeatenhome = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0003FD16 File Offset: 0x0003DF16
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0003FD1E File Offset: 0x0003DF1E
		public bool unbeatenleague
		{
			get
			{
				return this.m_unbeatenleague;
			}
			set
			{
				this.m_unbeatenleague = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0003FD27 File Offset: 0x0003DF27
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0003FD2F File Offset: 0x0003DF2F
		public int highestpossible
		{
			get
			{
				return this.m_highestpossible;
			}
			set
			{
				this.m_highestpossible = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0003FD38 File Offset: 0x0003DF38
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0003FD40 File Offset: 0x0003DF40
		public int highestprobable
		{
			get
			{
				return this.m_highestprobable;
			}
			set
			{
				this.m_highestprobable = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0003FD49 File Offset: 0x0003DF49
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0003FD51 File Offset: 0x0003DF51
		public int nummatchesplayed
		{
			get
			{
				return this.m_nummatchesplayed;
			}
			set
			{
				this.m_nummatchesplayed = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0003FD5A File Offset: 0x0003DF5A
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0003FD62 File Offset: 0x0003DF62
		public int gapresult
		{
			get
			{
				return this.m_gapresult;
			}
			set
			{
				this.m_gapresult = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0003FD6B File Offset: 0x0003DF6B
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0003FD73 File Offset: 0x0003DF73
		public int grouping
		{
			get
			{
				return this.m_grouping;
			}
			set
			{
				this.m_grouping = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0003FD7C File Offset: 0x0003DF7C
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0003FD84 File Offset: 0x0003DF84
		public int objective
		{
			get
			{
				return this.m_objective;
			}
			set
			{
				this.m_objective = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0003FD8D File Offset: 0x0003DF8D
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0003FD95 File Offset: 0x0003DF95
		public int actualvsexpectations
		{
			get
			{
				return this.m_actualvsexpectations;
			}
			set
			{
				this.m_actualvsexpectations = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0003FD9E File Offset: 0x0003DF9E
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0003FDA6 File Offset: 0x0003DFA6
		public int lastgameresult
		{
			get
			{
				return this.m_lastgameresult;
			}
			set
			{
				this.m_lastgameresult = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x0003FDAF File Offset: 0x0003DFAF
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0003FDB7 File Offset: 0x0003DFB7
		public int homega
		{
			get
			{
				return this.m_homega;
			}
			set
			{
				this.m_homega = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0003FDC0 File Offset: 0x0003DFC0
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
		public int homegf
		{
			get
			{
				return this.m_homegf;
			}
			set
			{
				this.m_homegf = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0003FDD1 File Offset: 0x0003DFD1
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0003FDD9 File Offset: 0x0003DFD9
		public int points
		{
			get
			{
				return this.m_points;
			}
			set
			{
				this.m_points = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0003FDE2 File Offset: 0x0003DFE2
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0003FDEA File Offset: 0x0003DFEA
		public int awayga
		{
			get
			{
				return this.m_awayga;
			}
			set
			{
				this.m_awayga = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0003FDF3 File Offset: 0x0003DFF3
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0003FDFB File Offset: 0x0003DFFB
		public int secondarytable
		{
			get
			{
				return this.m_secondarytable;
			}
			set
			{
				this.m_secondarytable = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0003FE04 File Offset: 0x0003E004
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0003FE0C File Offset: 0x0003E00C
		public int homewins
		{
			get
			{
				return this.m_homewins;
			}
			set
			{
				this.m_homewins = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0003FE15 File Offset: 0x0003E015
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x0003FE1D File Offset: 0x0003E01D
		public int awaywins
		{
			get
			{
				return this.m_awaywins;
			}
			set
			{
				this.m_awaywins = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0003FE26 File Offset: 0x0003E026
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0003FE2E File Offset: 0x0003E02E
		public int homelosses
		{
			get
			{
				return this.m_homelosses;
			}
			set
			{
				this.m_homelosses = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0003FE37 File Offset: 0x0003E037
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0003FE3F File Offset: 0x0003E03F
		public int awaylosses
		{
			get
			{
				return this.m_awaylosses;
			}
			set
			{
				this.m_awaylosses = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0003FE48 File Offset: 0x0003E048
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0003FE50 File Offset: 0x0003E050
		public int awaydraws
		{
			get
			{
				return this.m_awaydraws;
			}
			set
			{
				this.m_awaydraws = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0003FE59 File Offset: 0x0003E059
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0003FE61 File Offset: 0x0003E061
		public int homedraws
		{
			get
			{
				return this.m_homedraws;
			}
			set
			{
				this.m_homedraws = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0003FE6A File Offset: 0x0003E06A
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0003FE72 File Offset: 0x0003E072
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

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0003FE7B File Offset: 0x0003E07B
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0003FE83 File Offset: 0x0003E083
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

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0003FE8C File Offset: 0x0003E08C
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0003FE94 File Offset: 0x0003E094
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		public override string ToString()
		{
			if (this.DatabaseName.EndsWith(" X"))
			{
				return this.DatabaseName;
			}
			if (this.m_TeamNameFull != null && this.m_TeamNameFull != string.Empty)
			{
				return this.m_TeamNameFull;
			}
			if (this.m_teamname != null)
			{
				this.m_TeamNameFull = this.m_teamname;
				return this.m_teamname;
			}
			return string.Empty;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0003FF08 File Offset: 0x0003E108
		public Team(Record recTeams)
			: base(recTeams.IntField[FI.teams_teamid])
		{
			this.Load(recTeams);
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0003FF8C File Offset: 0x0003E18C
		public Team(int teamId)
		{
			base.Id = teamId;
			this.m_assetid = teamId;
			this.m_TeamNameFull = "Team " + teamId.ToString();
			this.InitNewTeam();
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00040028 File Offset: 0x0003E228
		public void SetNameAutomatically(string longName, int length)
		{
			if (length == 15)
			{
				if (this.m_TeamNameAbbr15 == null || (this.m_TeamNameAbbr15 != null && this.m_TeamNameAbbr15 == string.Empty) || this.m_TeamNameAbbr15.StartsWith("Team"))
				{
					if (longName.Length <= length)
					{
						this.m_TeamNameAbbr15 = longName;
						return;
					}
					this.m_TeamNameAbbr15 = longName.Substring(0, length - 1);
					if (!longName.Substring(length - 2, 2).Contains(" "))
					{
						this.m_TeamNameAbbr15 += ".";
						return;
					}
				}
			}
			else if (length == 10)
			{
				if (this.m_TeamNameAbbr10 == null || (this.m_TeamNameAbbr10 != null && this.m_TeamNameAbbr10 == string.Empty) || this.m_TeamNameAbbr10.StartsWith("Team"))
				{
					if (longName.Length <= length)
					{
						this.m_TeamNameAbbr10 = longName;
						return;
					}
					this.m_TeamNameAbbr10 = longName.Substring(0, length - 1);
					if (!longName.Substring(length - 2, 2).Contains(" "))
					{
						this.m_TeamNameAbbr10 += ".";
						return;
					}
				}
			}
			else if (length == 7)
			{
				if (this.m_TeamNameAbbr7 == null || (this.m_TeamNameAbbr7 != null && this.m_TeamNameAbbr7 == string.Empty) || this.m_TeamNameAbbr7.StartsWith("Team"))
				{
					if (longName.Length <= length)
					{
						this.m_TeamNameAbbr7 = longName;
						return;
					}
					this.m_TeamNameAbbr7 = longName.Substring(0, length - 1);
					if (!longName.Substring(length - 2, 2).Contains(" "))
					{
						this.m_TeamNameAbbr7 += ".";
						return;
					}
				}
			}
			else
			{
				if (length != 3)
				{
					return;
				}
				if (this.m_TeamNameAbbr3 == null || (this.m_TeamNameAbbr3 != null && this.m_TeamNameAbbr3 == string.Empty))
				{
					if (longName.Length <= length)
					{
						this.m_TeamNameAbbr3 = longName;
					}
					else
					{
						this.m_TeamNameAbbr3 = longName.Substring(0, length);
					}
					this.m_TeamNameAbbr3 = this.m_TeamNameAbbr3.ToUpper();
					return;
				}
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0004023C File Offset: 0x0003E43C
		public void InitNewTeam()
		{
			this.m_TeamNameAbbr10 = ((this.m_TeamNameFull.Length > 10) ? this.m_TeamNameFull.Substring(0, 10) : this.m_TeamNameFull);
			this.m_TeamNameAbbr15 = ((this.m_TeamNameFull.Length > 15) ? this.m_TeamNameFull.Substring(0, 15) : this.m_TeamNameFull);
			this.m_TeamNameAbbr7 = ((this.m_TeamNameFull.Length > 7) ? this.m_TeamNameFull.Substring(0, 7) : this.m_TeamNameFull);
			this.m_TeamNameAbbr3 = "XYZ";
			this.m_teamname = this.m_TeamNameFull;
			this.m_balltype = 1;
			this.m_adboardid = 1;
			this.m_Stadium = null;
			this.m_stadiumid = -1;
			this.m_genericbanner = false;
			this.m_jerseytype = 1;
			this.m_physioid_primary = 1;
			this.m_physioid_secondary = 2;
			this.m_teamcolor1r = 255;
			this.m_teamcolor1g = 255;
			this.m_teamcolor1b = 255;
			this.m_teamcolor2r = 0;
			this.m_teamcolor2g = 0;
			this.m_teamcolor2b = 0;
			this.m_teamcolor3r = 128;
			this.m_teamcolor3g = 128;
			this.m_teamcolor3b = 128;
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolor1r, this.m_teamcolor1g, this.m_teamcolor1b);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolor2r, this.m_teamcolor2g, this.m_teamcolor2b);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolor3r, this.m_teamcolor3g, this.m_teamcolor3b);
			this.m_form = 0;
			this.m_managerid = 8105;
			this.m_stadiumcustomname = null;
			this.m_ManagerSurname = null;
			this.m_ManagerFirstName = null;
			this.m_fancrowdhairskintexturecode = 0;
			this.m_stafftracksuitcolorcode = 0;
			for (int i = 0; i < 10; i++)
			{
				this.m_teamkitidList[i] = -1;
			}
			this.m_RivalTeam = null;
			this.m_rivalteam = 1;
			this.m_assetid = base.Id;
			this.m_transferbudget = 1000000;
			this.m_internationalprestige = 10;
			this.m_domesticprestige = 10;
			this.m_formationid = 0;
			this.m_busbuildupspeed = 50;
			this.m_buspassing = 50;
			this.m_buspositioning = 0;
			this.m_ccpassing = 50;
			this.m_cccrossing = 50;
			this.m_ccshooting = 50;
			this.m_ccpositioning = 0;
			this.m_defmentality = 50;
			this.m_defaggression = 50;
			this.m_defteamwidth = 50;
			this.m_defdefenderline = 0;
			this.m_captainid = 1;
			this.m_penaltytakerid = 1;
			this.m_freekicktakerid = 1;
			this.m_leftfreekicktakerid = 1;
			this.m_rightfreekicktakerid = 1;
			this.m_longkicktakerid = 1;
			this.m_leftcornerkicktakerid = 1;
			this.m_rightcornerkicktakerid = 1;
			this.PlayerCaptain = null;
			this.PlayerPenalty = null;
			this.PlayerFreeKick = null;
			this.PlayerLongKick = null;
			this.PlayerLeftCorner = null;
			this.PlayerRightCorner = null;
			this.m_numtransfersin = 0;
			this.m_genericint2 = -1;
			this.m_genericint1 = -1;
			this.m_latitude = 0;
			this.m_longitude = 0;
			this.m_utcoffset = 0;
			this.m_powid = -1;
			this.m_midfieldrating = 50;
			this.m_defenserating = 50;
			this.m_attackrating = 50;
			this.m_overallrating = 50;
			this.m_matchdayoverallrating = 50;
			this.m_matchdaydefenserating = 50;
			this.m_matchdaymidfieldrating = 50;
			this.m_matchdayattackrating = 50;
			this.m_suitvariationid = 0;
			this.m_suittypeid = 0;
			this.m_bodytypeid = 1;
			this.m_ethnicity = 2;
			this.m_personalityid = 0;
			this.m_countryid_IfNationalTeam = 0;
			this.m_countryid_IfRowTeam = 0;
			this.m_countryid_IfLeagueTeam = 0;
			this.m_Country = null;
			this.m_leagueid = 0;
			this.m_League = null;
			this.m_prevleagueid = 0;
			this.m_PrevLeague = null;
			this.m_champion = false;
			this.m_previousyeartableposition = 1;
			this.m_currenttableposition = 1;
			this.m_teamshortform = 50;
			this.m_teamlongform = 50;
			this.m_teamform = 0;
			this.m_hasachievedobjective = false;
			this.m_yettowin = false;
			this.m_unbeatenallcomps = false;
			this.m_unbeatenaway = false;
			this.m_unbeatenhome = false;
			this.m_unbeatenleague = false;
			this.m_highestpossible = 0;
			this.m_highestprobable = 0;
			this.m_nummatchesplayed = 0;
			this.m_gapresult = 0;
			this.m_grouping = 0;
			this.m_objective = 0;
			this.m_actualvsexpectations = 0;
			this.m_lastgameresult = 0;
			this.m_busdribbling = 50;
			this.m_trait1 = 0;
			this.m_ImpatientBoard = false;
			this.m_LoyalBoard = false;
			this.m_SquadRotation = false;
			this.m_ConsistentLineup = false;
			this.m_SwitchWingers = false;
			this.m_CenterBacksSplit = false;
			this.m_DefendLead = false;
			this.m_KeepUpPressure = false;
			this.m_MoreAttackingAtHome = false;
			this.m_ShortOutBack = false;
			this.m_homega = 0;
			this.m_homegf = 0;
			this.m_points = 0;
			this.m_awayga = 0;
			this.m_secondarytable = 0;
			this.m_homewins = 0;
			this.m_awaywins = 0;
			this.m_homelosses = 0;
			this.m_awaylosses = 0;
			this.m_awaydraws = 0;
			this.m_homedraws = 0;
			this.m_crestweight = 25;
			this.m_genericweight = 25;
			this.m_teamweight = 50;
			this.m_maxvariationsneg = 0;
			this.m_maxvariationspos = 0;
			this.m_maxvariationsstd = 0;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0004073C File Offset: 0x0003E93C
		public void Load17(Record r, TableDescriptor td)
		{
			this.m_assetid = base.Id;
			this.m_teamname = r.StringField[td.GetFieldIndex("teamname")];
			this.m_transferbudget = r.GetAndCheckIntField(td.GetFieldIndex("transferbudget"));
			this.m_domesticprestige = r.GetAndCheckIntField(td.GetFieldIndex("domesticprestige"));
			this.m_internationalprestige = r.GetAndCheckIntField(td.GetFieldIndex("internationalprestige"));
			this.m_rivalteam = r.GetAndCheckIntField(td.GetFieldIndex("rivalteam"));
			this.m_captainid = r.GetAndCheckIntField(td.GetFieldIndex("captainid"));
			this.m_penaltytakerid = r.GetAndCheckIntField(td.GetFieldIndex("penaltytakerid"));
			this.m_freekicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("freekicktakerid"));
			this.m_leftfreekicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("leftfreekicktakerid"));
			this.m_rightfreekicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("rightfreekicktakerid"));
			this.m_longkicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("longkicktakerid"));
			this.m_leftcornerkicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("leftcornerkicktakerid"));
			this.m_rightcornerkicktakerid = r.GetAndCheckIntField(td.GetFieldIndex("rightcornerkicktakerid"));
			this.m_adboardid = r.GetAndCheckIntField(td.GetFieldIndex("adboardid"));
			this.m_balltype = r.GetAndCheckIntField(td.GetFieldIndex("balltype"));
			this.m_genericbanner = r.GetAndCheckIntField(td.GetFieldIndex("genericbanner")) != 0;
			this.m_jerseytype = r.GetAndCheckIntField(td.GetFieldIndex("jerseytype"));
			this.m_fancrowdhairskintexturecode = r.GetAndCheckIntField(td.GetFieldIndex("fancrowdhairskintexturecode"));
			this.m_stafftracksuitcolorcode = r.GetAndCheckIntField(td.GetFieldIndex("stafftracksuitcolorcode"));
			this.m_busbuildupspeed = r.GetAndCheckIntField(td.GetFieldIndex("busbuildupspeed"));
			this.m_buspassing = r.GetAndCheckIntField(td.GetFieldIndex("buspassing"));
			if (FifaEnvironment.Year == 14)
			{
				this.m_buspositioning = r.GetAndCheckIntField(td.GetFieldIndex("buspositioning")) - 1;
				this.m_ccpositioning = r.GetAndCheckIntField(td.GetFieldIndex("ccpositioning")) - 1;
				this.m_defdefenderline = r.GetAndCheckIntField(td.GetFieldIndex("defdefenderline")) - 1;
			}
			else
			{
				this.m_buspositioning = r.GetAndCheckIntField(td.GetFieldIndex("buspositioning"));
				this.m_ccpositioning = r.GetAndCheckIntField(td.GetFieldIndex("ccpositioning"));
				this.m_defdefenderline = r.GetAndCheckIntField(td.GetFieldIndex("defdefenderline"));
			}
			this.m_busdribbling = r.GetAndCheckIntField(td.GetFieldIndex("busdribbling"));
			this.m_cccrossing = r.GetAndCheckIntField(td.GetFieldIndex("cccrossing"));
			this.m_ccpassing = r.GetAndCheckIntField(td.GetFieldIndex("ccpassing"));
			this.m_ccshooting = r.GetAndCheckIntField(td.GetFieldIndex("ccshooting"));
			this.m_defmentality = r.GetAndCheckIntField(td.GetFieldIndex("defmentality"));
			this.m_defaggression = r.GetAndCheckIntField(td.GetFieldIndex("defaggression"));
			this.m_defteamwidth = r.GetAndCheckIntField(td.GetFieldIndex("defteamwidth"));
			this.m_physioid_primary = r.GetAndCheckIntField(td.GetFieldIndex("physioid_primary"));
			this.m_physioid_secondary = r.GetAndCheckIntField(td.GetFieldIndex("physioid_secondary"));
			this.m_teamcolor1r = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor1r"));
			this.m_teamcolor1g = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor1g"));
			this.m_teamcolor1b = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor1b"));
			this.m_teamcolor2r = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor2r"));
			this.m_teamcolor2g = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor2g"));
			this.m_teamcolor2b = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor2b"));
			this.m_teamcolor3r = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor3r"));
			this.m_teamcolor3g = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor3g"));
			this.m_teamcolor3b = r.GetAndCheckIntField(td.GetFieldIndex("teamcolor3b"));
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolor1r, this.m_teamcolor1g, this.m_teamcolor1b);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolor2r, this.m_teamcolor2g, this.m_teamcolor2b);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolor3r, this.m_teamcolor3g, this.m_teamcolor3b);
			this.m_form = r.GetAndCheckIntField(td.GetFieldIndex("form"));
			this.m_latitude = r.GetAndCheckIntField(td.GetFieldIndex("latitude"));
			this.m_longitude = r.GetAndCheckIntField(td.GetFieldIndex("longitude"));
			this.m_utcoffset = r.GetAndCheckIntField(td.GetFieldIndex("utcoffset"));
			this.m_powid = -1;
			this.m_midfieldrating = r.GetAndCheckIntField(td.GetFieldIndex("midfieldrating"));
			this.m_defenserating = r.GetAndCheckIntField(td.GetFieldIndex("defenserating"));
			this.m_attackrating = r.GetAndCheckIntField(td.GetFieldIndex("attackrating"));
			this.m_overallrating = r.GetAndCheckIntField(td.GetFieldIndex("overallrating"));
			this.m_matchdayoverallrating = r.GetAndCheckIntField(td.GetFieldIndex("matchdayoverallrating"));
			this.m_matchdaydefenserating = r.GetAndCheckIntField(td.GetFieldIndex("matchdaydefenserating"));
			this.m_matchdaymidfieldrating = r.GetAndCheckIntField(td.GetFieldIndex("matchdaymidfieldrating"));
			this.m_matchdayattackrating = r.GetAndCheckIntField(td.GetFieldIndex("matchdayattackrating"));
			this.m_suitvariationid = r.GetAndCheckIntField(td.GetFieldIndex("suitvariationid"));
			this.m_suittypeid = r.GetAndCheckIntField(td.GetFieldIndex("suittypeid"));
			this.m_bodytypeid = r.GetAndCheckIntField(td.GetFieldIndex("bodytypeid"));
			this.m_ethnicity = r.GetAndCheckIntField(td.GetFieldIndex("ethnicity"));
			this.m_personalityid = r.GetAndCheckIntField(td.GetFieldIndex("personalityid"));
			this.m_trait1 = r.GetAndCheckIntField(td.GetFieldIndex("trait1"));
			this.m_ImpatientBoard = (this.m_trait1 & 1) != 0;
			this.m_LoyalBoard = (this.m_trait1 & 2) != 0;
			this.m_SquadRotation = (this.m_trait1 & 4) != 0;
			this.m_ConsistentLineup = (this.m_trait1 & 8) != 0;
			this.m_SwitchWingers = (this.m_trait1 & 16) != 0;
			this.m_CenterBacksSplit = (this.m_trait1 & 32) != 0;
			this.m_DefendLead = (this.m_trait1 & 64) != 0;
			this.m_KeepUpPressure = (this.m_trait1 & 128) != 0;
			this.m_MoreAttackingAtHome = (this.m_trait1 & 256) != 0;
			this.m_ShortOutBack = (this.m_trait1 & 512) != 0;
			this.m_numtransfersin = r.GetAndCheckIntField(td.GetFieldIndex("numtransfersin"));
			this.m_genericint2 = r.GetAndCheckIntField(td.GetFieldIndex("genericint1"));
			this.m_genericint1 = r.GetAndCheckIntField(td.GetFieldIndex("genericint2"));
			if (FifaEnvironment.Language != null)
			{
				this.m_TeamNameFull = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Full);
				this.m_TeamNameAbbr15 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr15);
				this.m_TeamNameAbbr10 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr10);
				this.m_TeamNameAbbr3 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr3);
				this.m_TeamNameAbbr7 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr7);
				if (this.m_TeamNameFull == null || this.m_TeamNameFull == string.Empty)
				{
					this.m_TeamNameFull = this.m_TeamNameAbbr10;
					return;
				}
			}
			else
			{
				this.m_TeamNameFull = string.Empty;
				this.m_TeamNameAbbr15 = string.Empty;
				this.m_TeamNameAbbr3 = string.Empty;
				this.m_TeamNameAbbr7 = string.Empty;
				this.m_TeamNameAbbr10 = string.Empty;
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00040F78 File Offset: 0x0003F178
		public void Load(Record r)
		{
			this.m_assetid = base.Id;
			this.m_teamname = r.StringField[FI.teams_teamname];
			this.m_transferbudget = r.GetAndCheckIntField(FI.teams_transferbudget);
			this.m_transferbudget = this.m_transferbudget / 1000 * 1000;
			this.m_domesticprestige = r.GetAndCheckIntField(FI.teams_domesticprestige);
			this.m_internationalprestige = r.GetAndCheckIntField(FI.teams_internationalprestige);
			this.m_rivalteam = r.GetAndCheckIntField(FI.teams_rivalteam);
			this.m_captainid = r.GetAndCheckIntField(FI.teams_captainid);
			this.m_penaltytakerid = r.GetAndCheckIntField(FI.teams_penaltytakerid);
			this.m_freekicktakerid = r.GetAndCheckIntField(FI.teams_freekicktakerid);
			if (FI.teams_leftfreekicktakerid >= 0)
			{
				this.m_leftfreekicktakerid = r.GetAndCheckIntField(FI.teams_leftfreekicktakerid);
			}
			if (FI.teams_rightfreekicktakerid >= 0)
			{
				this.m_rightfreekicktakerid = r.GetAndCheckIntField(FI.teams_rightfreekicktakerid);
			}
			this.m_longkicktakerid = r.GetAndCheckIntField(FI.teams_longkicktakerid);
			this.m_leftcornerkicktakerid = r.GetAndCheckIntField(FI.teams_leftcornerkicktakerid);
			this.m_rightcornerkicktakerid = r.GetAndCheckIntField(FI.teams_rightcornerkicktakerid);
			this.m_adboardid = r.GetAndCheckIntField(FI.teams_adboardid);
			this.m_balltype = r.GetAndCheckIntField(FI.teams_balltype);
			this.m_genericbanner = r.GetAndCheckIntField(FI.teams_genericbanner) != 0;
			this.m_jerseytype = r.GetAndCheckIntField(FI.teams_jerseytype);
			this.m_fancrowdhairskintexturecode = r.GetAndCheckIntField(FI.teams_fancrowdhairskintexturecode);
			this.m_stafftracksuitcolorcode = r.GetAndCheckIntField(FI.teams_stafftracksuitcolorcode);
			this.m_busbuildupspeed = r.GetAndCheckIntField(FI.teams_busbuildupspeed);
			this.m_buspassing = r.GetAndCheckIntField(FI.teams_buspassing);
			if (FifaEnvironment.Year == 14)
			{
				this.m_buspositioning = r.GetAndCheckIntField(FI.teams_buspositioning) - 1;
				this.m_ccpositioning = r.GetAndCheckIntField(FI.teams_ccpositioning) - 1;
				this.m_defdefenderline = r.GetAndCheckIntField(FI.teams_defdefenderline) - 1;
			}
			else
			{
				this.m_buspositioning = r.GetAndCheckIntField(FI.teams_buspositioning);
				this.m_ccpositioning = r.GetAndCheckIntField(FI.teams_ccpositioning);
				this.m_defdefenderline = r.GetAndCheckIntField(FI.teams_defdefenderline);
			}
			this.m_busdribbling = r.GetAndCheckIntField(FI.teams_busdribbling);
			this.m_cccrossing = r.GetAndCheckIntField(FI.teams_cccrossing);
			this.m_ccpassing = r.GetAndCheckIntField(FI.teams_ccpassing);
			this.m_ccshooting = r.GetAndCheckIntField(FI.teams_ccshooting);
			this.m_defmentality = r.GetAndCheckIntField(FI.teams_defmentality);
			this.m_defaggression = r.GetAndCheckIntField(FI.teams_defaggression);
			this.m_defteamwidth = r.GetAndCheckIntField(FI.teams_defteamwidth);
			this.m_physioid_primary = r.GetAndCheckIntField(FI.teams_physioid_primary);
			this.m_physioid_secondary = r.GetAndCheckIntField(FI.teams_physioid_secondary);
			this.m_teamcolor1r = r.GetAndCheckIntField(FI.teams_teamcolor1r);
			this.m_teamcolor1g = r.GetAndCheckIntField(FI.teams_teamcolor1g);
			this.m_teamcolor1b = r.GetAndCheckIntField(FI.teams_teamcolor1b);
			this.m_teamcolor2r = r.GetAndCheckIntField(FI.teams_teamcolor2r);
			this.m_teamcolor2g = r.GetAndCheckIntField(FI.teams_teamcolor2g);
			this.m_teamcolor2b = r.GetAndCheckIntField(FI.teams_teamcolor2b);
			this.m_teamcolor3r = r.GetAndCheckIntField(FI.teams_teamcolor3r);
			this.m_teamcolor3g = r.GetAndCheckIntField(FI.teams_teamcolor3g);
			this.m_teamcolor3b = r.GetAndCheckIntField(FI.teams_teamcolor3b);
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolor1r, this.m_teamcolor1g, this.m_teamcolor1b);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolor2r, this.m_teamcolor2g, this.m_teamcolor2b);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolor3r, this.m_teamcolor3g, this.m_teamcolor3b);
			this.m_form = r.GetAndCheckIntField(FI.teams_form);
			this.m_latitude = r.GetAndCheckIntField(FI.teams_latitude);
			this.m_longitude = r.GetAndCheckIntField(FI.teams_longitude);
			this.m_utcoffset = r.GetAndCheckIntField(FI.teams_utcoffset);
			this.m_powid = r.GetAndCheckIntField(FI.teams_powid);
			if (this.m_powid == 0)
			{
				this.m_powid = -1;
			}
			this.m_midfieldrating = r.GetAndCheckIntField(FI.teams_midfieldrating);
			this.m_defenserating = r.GetAndCheckIntField(FI.teams_defenserating);
			this.m_attackrating = r.GetAndCheckIntField(FI.teams_attackrating);
			this.m_overallrating = r.GetAndCheckIntField(FI.teams_overallrating);
			this.m_matchdayoverallrating = r.GetAndCheckIntField(FI.teams_matchdayoverallrating);
			this.m_matchdaydefenserating = r.GetAndCheckIntField(FI.teams_matchdaydefenserating);
			this.m_matchdaymidfieldrating = r.GetAndCheckIntField(FI.teams_matchdaymidfieldrating);
			this.m_matchdayattackrating = r.GetAndCheckIntField(FI.teams_matchdayattackrating);
			this.m_suitvariationid = r.GetAndCheckIntField(FI.teams_suitvariationid);
			this.m_suittypeid = r.GetAndCheckIntField(FI.teams_suittypeid);
			this.m_bodytypeid = r.GetAndCheckIntField(FI.teams_bodytypeid);
			this.m_ethnicity = r.GetAndCheckIntField(FI.teams_ethnicity);
			this.m_personalityid = r.GetAndCheckIntField(FI.teams_personalityid);
			this.m_trait1 = r.GetAndCheckIntField(FI.teams_trait1);
			this.m_ImpatientBoard = (this.m_trait1 & 1) != 0;
			this.m_LoyalBoard = (this.m_trait1 & 2) != 0;
			this.m_SquadRotation = (this.m_trait1 & 4) != 0;
			this.m_ConsistentLineup = (this.m_trait1 & 8) != 0;
			this.m_SwitchWingers = (this.m_trait1 & 16) != 0;
			this.m_CenterBacksSplit = (this.m_trait1 & 32) != 0;
			this.m_DefendLead = (this.m_trait1 & 64) != 0;
			this.m_KeepUpPressure = (this.m_trait1 & 128) != 0;
			this.m_MoreAttackingAtHome = (this.m_trait1 & 256) != 0;
			this.m_ShortOutBack = (this.m_trait1 & 512) != 0;
			this.m_numtransfersin = r.GetAndCheckIntField(FI.teams_numtransfersin);
			this.m_genericint2 = r.GetAndCheckIntField(FI.teams_genericint1);
			this.m_genericint1 = r.GetAndCheckIntField(FI.teams_genericint2);
			if (FifaEnvironment.Language != null)
			{
				this.m_TeamNameFull = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Full);
				this.m_TeamNameAbbr15 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr15);
				this.m_TeamNameAbbr10 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr10);
				this.m_TeamNameAbbr3 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr3);
				this.m_TeamNameAbbr7 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr7);
				if (this.m_TeamNameFull == null || this.m_TeamNameFull == string.Empty)
				{
					this.m_TeamNameFull = this.m_TeamNameAbbr10;
					return;
				}
			}
			else
			{
				this.m_TeamNameFull = string.Empty;
				this.m_TeamNameAbbr15 = string.Empty;
				this.m_TeamNameAbbr3 = string.Empty;
				this.m_TeamNameAbbr7 = string.Empty;
				this.m_TeamNameAbbr10 = string.Empty;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00041668 File Offset: 0x0003F868
		public void FillFromStadiumAssignments(Record r)
		{
			this.m_stadiumcustomname = r.StringField[FI.stadiumassignments_stadiumcustomname];
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0004167C File Offset: 0x0003F87C
		public void FillFromManager(Record r)
		{
			this.m_ManagerFirstName = r.StringField[FI.manager_firstname];
			this.m_ManagerSurname = r.StringField[FI.manager_surname];
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000416A2 File Offset: 0x0003F8A2
		public void FillFromTeamStadiumLinks(Record r)
		{
			this.m_stadiumid = r.GetAndCheckIntField(FI.teamstadiumlinks_stadiumid);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000416B8 File Offset: 0x0003F8B8
		public void FillFromTeamkits(Record r)
		{
			int andCheckIntField = r.GetAndCheckIntField(FI.teamkits_teamkittypetechid);
			if (andCheckIntField < this.m_teamkitidList.Length && r.GetAndCheckIntField(FI.teamkits_year) == 0)
			{
				this.m_teamkitidList[andCheckIntField] = r.GetAndCheckIntField(FI.teamkits_teamkitid);
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000416FC File Offset: 0x0003F8FC
		public void FillFromNewspicweights(Record r)
		{
			this.m_crestweight = r.GetAndCheckIntField(FI.career_newspicweights_crestweight);
			this.m_genericweight = r.GetAndCheckIntField(FI.career_newspicweights_genericweight);
			this.m_teamweight = r.GetAndCheckIntField(FI.career_newspicweights_teamweight);
			this.m_maxvariationsneg = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationsneg);
			this.m_maxvariationspos = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationspos);
			this.m_maxvariationsstd = r.GetAndCheckIntField(FI.career_newspicweights_maxvariationsstd);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0004176F File Offset: 0x0003F96F
		public void FillFromFormations(Record r)
		{
			this.m_formationid = r.GetAndCheckIntField(FI.formations_formationid);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00041782 File Offset: 0x0003F982
		public void FillFromTeamFormationLinks(Record r)
		{
			this.m_formationid = r.GetAndCheckIntField(FI.teamformationteamstylelinks_formationid);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00041795 File Offset: 0x0003F995
		public void FillFromNations(Record r)
		{
			this.m_countryid_IfNationalTeam = r.GetAndCheckIntField(FI.nations_nationid);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000417A8 File Offset: 0x0003F9A8
		public void FillFromTeamNationLinks(Record r)
		{
			this.m_countryid_IfNationalTeam = r.GetAndCheckIntField(FI.teamnationlinks_nationid);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000417BC File Offset: 0x0003F9BC
		public void FillFromLeagueTeamLinks(Record r)
		{
			this.m_leagueid = r.GetAndCheckIntField(FI.leagueteamlinks_leagueid);
			this.m_prevleagueid = r.GetAndCheckIntField(FI.leagueteamlinks_prevleagueid);
			this.m_champion = r.GetAndCheckIntField(FI.leagueteamlinks_champion) != 0;
			this.m_previousyeartableposition = r.GetAndCheckIntField(FI.leagueteamlinks_previousyeartableposition);
			this.m_currenttableposition = r.GetAndCheckIntField(FI.leagueteamlinks_currenttableposition);
			this.m_teamshortform = r.GetAndCheckIntField(FI.leagueteamlinks_teamshortform);
			this.m_teamlongform = r.GetAndCheckIntField(FI.leagueteamlinks_teamlongform);
			this.m_teamform = r.GetAndCheckIntField(FI.leagueteamlinks_teamform);
			this.m_hasachievedobjective = r.GetAndCheckIntField(FI.leagueteamlinks_hasachievedobjective) != 0;
			this.m_yettowin = r.GetAndCheckIntField(FI.leagueteamlinks_yettowin) != 0;
			this.m_unbeatenallcomps = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenallcomps) != 0;
			this.m_unbeatenaway = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenaway) != 0;
			this.m_unbeatenhome = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenhome) != 0;
			this.m_unbeatenleague = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenleague) != 0;
			this.m_highestpossible = r.GetAndCheckIntField(FI.leagueteamlinks_highestpossible);
			this.m_highestprobable = r.GetAndCheckIntField(FI.leagueteamlinks_highestprobable);
			this.m_nummatchesplayed = r.GetAndCheckIntField(FI.leagueteamlinks_nummatchesplayed);
			this.m_gapresult = r.GetAndCheckIntField(FI.leagueteamlinks_gapresult);
			this.m_grouping = r.GetAndCheckIntField(FI.leagueteamlinks_grouping);
			this.m_objective = r.GetAndCheckIntField(FI.leagueteamlinks_objective);
			this.m_actualvsexpectations = r.GetAndCheckIntField(FI.leagueteamlinks_actualvsexpectations);
			this.m_lastgameresult = r.GetAndCheckIntField(FI.leagueteamlinks_lastgameresult);
			this.m_homega = r.GetAndCheckIntField(FI.leagueteamlinks_homega);
			this.m_homegf = r.GetAndCheckIntField(FI.leagueteamlinks_homegf);
			this.m_points = r.GetAndCheckIntField(FI.leagueteamlinks_points);
			this.m_awayga = r.GetAndCheckIntField(FI.leagueteamlinks_awayga);
			this.m_secondarytable = r.GetAndCheckIntField(FI.leagueteamlinks_secondarytable);
			this.m_homewins = r.GetAndCheckIntField(FI.leagueteamlinks_homewins);
			this.m_awaywins = r.GetAndCheckIntField(FI.leagueteamlinks_awaywins);
			this.m_homelosses = r.GetAndCheckIntField(FI.leagueteamlinks_homelosses);
			this.m_awaylosses = r.GetAndCheckIntField(FI.leagueteamlinks_awaylosses);
			this.m_awaydraws = r.GetAndCheckIntField(FI.leagueteamlinks_awaydraws);
			this.m_homedraws = r.GetAndCheckIntField(FI.leagueteamlinks_homedraws);
			this.m_points = r.GetAndCheckIntField(FI.leagueteamlinks_points);
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00041A35 File Offset: 0x0003FC35
		public void FillFromRowTeamNationLinks(Record r)
		{
			this.m_countryid_IfRowTeam = r.GetAndCheckIntField(FI.rowteamnationlinks_nationid);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00041A48 File Offset: 0x0003FC48
		public void LinkBall(BallList ballList)
		{
			if (ballList == null)
			{
				return;
			}
			this.m_Ball = (Ball)ballList.SearchId(this.m_balltype);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00041A68 File Offset: 0x0003FC68
		public void LinkKits(KitList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_teamkitidList.Length; i++)
			{
				if (this.m_teamkitidList[i] >= 0)
				{
					Kit kit = (Kit)kitList.SearchId(this.m_teamkitidList[i]);
					this.m_KitList.Add(kit);
				}
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00041AB8 File Offset: 0x0003FCB8
		public void LinkStadium(StadiumList stadiumList)
		{
			if (stadiumList == null)
			{
				return;
			}
			this.m_Stadium = (Stadium)stadiumList.SearchId(this.m_stadiumid);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00041AD5 File Offset: 0x0003FCD5
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_RivalTeam = (Team)teamList.SearchId(this.m_rivalteam);
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00041AF4 File Offset: 0x0003FCF4
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			if (this.IsNationalTeam())
			{
				this.m_Country = (Country)countryList.SearchId(this.m_countryid_IfNationalTeam);
				if (this.m_Country != null && !this.IsFemale())
				{
					this.m_Country.SetNationalTeam(this, base.Id);
					return;
				}
			}
			else
			{
				if (this.IsRowTeam())
				{
					this.m_Country = (Country)countryList.SearchId(this.m_countryid_IfRowTeam);
					return;
				}
				if (this.m_League != null && this.m_League.Country != null)
				{
					this.SetCountryAsLeagueTeam(this.m_League.Country);
				}
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00041B8D File Offset: 0x0003FD8D
		public void LinkFormation(FormationList formationList)
		{
			if (formationList == null)
			{
				return;
			}
			this.m_Formation = (Formation)formationList.SearchId(this.m_formationid);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00041BAA File Offset: 0x0003FDAA
		public void LinkFormation(Formation formation)
		{
			this.m_Formation = formation;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00041BB4 File Offset: 0x0003FDB4
		public void LinkPlayer(PlayerList playerList)
		{
			if (playerList == null)
			{
				return;
			}
			this.PlayerCaptain = (Player)playerList.SearchId(this.m_captainid);
			this.PlayerFreeKick = (Player)playerList.SearchId(this.m_freekicktakerid);
			this.PlayerLeftFreeKick = (Player)playerList.SearchId(this.m_leftfreekicktakerid);
			this.PlayerRightFreeKick = (Player)playerList.SearchId(this.m_rightfreekicktakerid);
			this.PlayerLongKick = (Player)playerList.SearchId(this.m_longkicktakerid);
			this.PlayerPenalty = (Player)playerList.SearchId(this.m_penaltytakerid);
			this.PlayerLeftCorner = (Player)playerList.SearchId(this.m_leftcornerkicktakerid);
			this.PlayerRightCorner = (Player)playerList.SearchId(this.m_rightcornerkicktakerid);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00041C7D File Offset: 0x0003FE7D
		public void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			this.m_League = (League)leagueList.SearchId(this.m_leagueid);
			this.m_PrevLeague = (League)leagueList.SearchId(this.m_prevleagueid);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00041CB1 File Offset: 0x0003FEB1
		public bool IsPlayingInLeague(League league)
		{
			return this.m_leagueid == league.Id;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00041CC4 File Offset: 0x0003FEC4
		public void SaveTeam(Record r)
		{
			r.IntField[FI.teams_teamid] = base.Id;
			r.StringField[FI.teams_teamname] = this.m_teamname;
			r.IntField[FI.teams_balltype] = this.m_balltype;
			r.IntField[FI.teams_adboardid] = this.m_adboardid;
			r.IntField[FI.teams_genericbanner] = (this.m_genericbanner ? 1 : 0);
			r.IntField[FI.teams_jerseytype] = this.m_jerseytype;
			r.IntField[FI.teams_stafftracksuitcolorcode] = this.m_stafftracksuitcolorcode;
			r.IntField[FI.teams_fancrowdhairskintexturecode] = this.m_fancrowdhairskintexturecode;
			r.IntField[FI.teams_physioid_primary] = this.m_physioid_primary;
			r.IntField[FI.teams_physioid_secondary] = this.m_physioid_secondary;
			this.m_teamcolor1r = (int)this.m_TeamColor1.R;
			this.m_teamcolor1g = (int)this.m_TeamColor1.G;
			this.m_teamcolor1b = (int)this.m_TeamColor1.B;
			this.m_teamcolor2r = (int)this.m_TeamColor2.R;
			this.m_teamcolor2g = (int)this.m_TeamColor2.G;
			this.m_teamcolor2b = (int)this.m_TeamColor2.B;
			this.m_teamcolor3r = (int)this.m_TeamColor3.R;
			this.m_teamcolor3g = (int)this.m_TeamColor3.G;
			this.m_teamcolor3b = (int)this.m_TeamColor3.B;
			r.IntField[FI.teams_teamcolor1r] = this.m_teamcolor1r;
			r.IntField[FI.teams_teamcolor1g] = this.m_teamcolor1g;
			r.IntField[FI.teams_teamcolor1b] = this.m_teamcolor1b;
			r.IntField[FI.teams_teamcolor2r] = this.m_teamcolor2r;
			r.IntField[FI.teams_teamcolor2g] = this.m_teamcolor2g;
			r.IntField[FI.teams_teamcolor2b] = this.m_teamcolor2b;
			r.IntField[FI.teams_teamcolor3r] = this.m_teamcolor3r;
			r.IntField[FI.teams_teamcolor3g] = this.m_teamcolor3g;
			r.IntField[FI.teams_teamcolor3b] = this.m_teamcolor3b;
			r.IntField[FI.teams_form] = this.m_form;
			r.IntField[FI.teams_numtransfersin] = this.m_numtransfersin;
			r.IntField[FI.teams_genericint1] = this.m_genericint1;
			r.IntField[FI.teams_genericint2] = this.m_genericint2;
			r.IntField[FI.teams_rivalteam] = this.m_rivalteam;
			r.IntField[FI.teams_assetid] = this.m_assetid;
			r.IntField[FI.teams_transferbudget] = this.m_transferbudget;
			r.IntField[FI.teams_internationalprestige] = this.m_internationalprestige;
			r.IntField[FI.teams_domesticprestige] = this.m_domesticprestige;
			r.IntField[FI.teams_busbuildupspeed] = this.m_busbuildupspeed;
			r.IntField[FI.teams_buspassing] = this.m_buspassing;
			if (FifaEnvironment.Year == 14)
			{
				r.IntField[FI.teams_buspositioning] = this.m_buspositioning + 1;
				r.IntField[FI.teams_ccpositioning] = this.m_ccpositioning + 1;
				r.IntField[FI.teams_defdefenderline] = this.m_defdefenderline + 1;
			}
			else
			{
				r.IntField[FI.teams_buspositioning] = this.m_buspositioning;
				r.IntField[FI.teams_ccpositioning] = this.m_ccpositioning;
				r.IntField[FI.teams_defdefenderline] = this.m_defdefenderline;
			}
			r.IntField[FI.teams_busdribbling] = this.m_busdribbling;
			r.IntField[FI.teams_ccpassing] = this.m_ccpassing;
			r.IntField[FI.teams_cccrossing] = this.m_cccrossing;
			r.IntField[FI.teams_ccshooting] = this.m_ccshooting;
			r.IntField[FI.teams_defmentality] = this.m_defmentality;
			r.IntField[FI.teams_defaggression] = this.m_defaggression;
			r.IntField[FI.teams_defteamwidth] = this.m_defteamwidth;
			r.IntField[FI.teams_captainid] = this.m_captainid;
			r.IntField[FI.teams_penaltytakerid] = this.m_penaltytakerid;
			r.IntField[FI.teams_freekicktakerid] = this.m_freekicktakerid;
			if (FI.teams_leftfreekicktakerid >= 0)
			{
				r.IntField[FI.teams_leftfreekicktakerid] = this.m_leftfreekicktakerid;
			}
			if (FI.teams_rightfreekicktakerid >= 0)
			{
				r.IntField[FI.teams_rightfreekicktakerid] = this.m_rightfreekicktakerid;
			}
			r.IntField[FI.teams_longkicktakerid] = this.m_longkicktakerid;
			r.IntField[FI.teams_leftcornerkicktakerid] = this.m_leftcornerkicktakerid;
			r.IntField[FI.teams_rightcornerkicktakerid] = this.m_rightcornerkicktakerid;
			r.IntField[FI.teams_latitude] = this.m_latitude;
			r.IntField[FI.teams_longitude] = this.m_longitude;
			r.IntField[FI.teams_utcoffset] = this.m_utcoffset;
			int powid = this.m_powid;
			r.IntField[FI.teams_powid] = this.m_powid;
			r.IntField[FI.teams_midfieldrating] = this.m_midfieldrating;
			r.IntField[FI.teams_defenserating] = this.m_defenserating;
			r.IntField[FI.teams_attackrating] = this.m_attackrating;
			r.IntField[FI.teams_overallrating] = this.m_overallrating;
			r.IntField[FI.teams_matchdayoverallrating] = this.m_matchdayoverallrating;
			r.IntField[FI.teams_matchdaydefenserating] = this.m_matchdaydefenserating;
			r.IntField[FI.teams_matchdaymidfieldrating] = this.m_matchdaymidfieldrating;
			r.IntField[FI.teams_matchdayattackrating] = this.m_matchdayattackrating;
			r.IntField[FI.teams_suitvariationid] = this.m_suitvariationid;
			r.IntField[FI.teams_suittypeid] = this.m_suittypeid;
			r.IntField[FI.teams_bodytypeid] = this.m_bodytypeid;
			r.IntField[FI.teams_ethnicity] = this.m_ethnicity;
			r.IntField[FI.teams_personalityid] = this.m_personalityid;
			this.m_trait1 = 0;
			this.m_trait1 |= (this.m_ImpatientBoard ? 1 : 0);
			this.m_trait1 |= (this.m_LoyalBoard ? 2 : 0);
			this.m_trait1 |= (this.m_SquadRotation ? 4 : 0);
			this.m_trait1 |= (this.m_ConsistentLineup ? 8 : 0);
			this.m_trait1 |= (this.m_SwitchWingers ? 16 : 0);
			this.m_trait1 |= (this.m_CenterBacksSplit ? 32 : 0);
			this.m_trait1 |= (this.m_DefendLead ? 64 : 0);
			this.m_trait1 |= (this.m_KeepUpPressure ? 128 : 0);
			this.m_trait1 |= (this.m_MoreAttackingAtHome ? 256 : 0);
			this.m_trait1 |= (this.m_ShortOutBack ? 512 : 0);
			r.IntField[FI.teams_trait1] = this.m_trait1;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00042382 File Offset: 0x00040582
		public void SaveTeamStadiumLinks(Record r)
		{
			r.IntField[FI.teamstadiumlinks_teamid] = base.Id;
			r.IntField[FI.teamstadiumlinks_stadiumid] = this.m_stadiumid;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000423A8 File Offset: 0x000405A8
		public void SaveTeamNationLinks(Record r)
		{
			r.IntField[FI.teamnationlinks_teamid] = base.Id;
			r.IntField[FI.teamnationlinks_nationid] = this.m_countryid_IfNationalTeam;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000423CE File Offset: 0x000405CE
		public void SaveDefaultTeamSheet(Record r)
		{
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000423D4 File Offset: 0x000405D4
		public void SaveDefaultTeamData(Record r)
		{
			if (r == null)
			{
				return;
			}
			r.IntField[FI.defaultteamdata_teamid] = base.Id;
			r.IntField[FI.defaultteamdata_tacticid] = 0;
			r.IntField[FI.defaultteamdata_busbuildupspeed] = this.m_busbuildupspeed;
			r.IntField[FI.defaultteamdata_busdribbling] = this.m_busdribbling;
			r.IntField[FI.defaultteamdata_buspassing] = this.m_buspassing;
			r.IntField[FI.defaultteamdata_buspositioning] = this.m_buspositioning;
			r.IntField[FI.defaultteamdata_cccrossing] = this.m_cccrossing;
			r.IntField[FI.defaultteamdata_ccpassing] = this.m_ccpassing;
			r.IntField[FI.defaultteamdata_ccpositioning] = this.m_ccpositioning;
			r.IntField[FI.defaultteamdata_ccshooting] = this.m_ccshooting;
			r.IntField[FI.defaultteamdata_defaggression] = this.m_defaggression;
			r.IntField[FI.defaultteamdata_defdefenderline] = this.m_defdefenderline;
			r.IntField[FI.defaultteamdata_defmentality] = this.m_defmentality;
			r.IntField[FI.defaultteamdata_defteamwidth] = this.m_defteamwidth;
			if (this.m_Formation != null)
			{
				r.FloatField[FI.defaultteamdata_offset0x] = (float)this.m_Formation.PlayingRoles[0].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset0y] = (float)this.m_Formation.PlayingRoles[0].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction0_1] = this.m_Formation.PlayingRoles[0].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction0_2] = this.m_Formation.PlayingRoles[0].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position0] = this.m_Formation.PlayingRoles[0].Role.Id;
				r.FloatField[FI.defaultteamdata_offset1x] = (float)this.m_Formation.PlayingRoles[1].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset1y] = (float)this.m_Formation.PlayingRoles[1].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction1_1] = this.m_Formation.PlayingRoles[1].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction1_2] = this.m_Formation.PlayingRoles[1].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position1] = this.m_Formation.PlayingRoles[1].Role.Id;
				r.FloatField[FI.defaultteamdata_offset2x] = (float)this.m_Formation.PlayingRoles[2].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset2y] = (float)this.m_Formation.PlayingRoles[2].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction2_1] = this.m_Formation.PlayingRoles[2].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction2_2] = this.m_Formation.PlayingRoles[2].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position2] = this.m_Formation.PlayingRoles[2].Role.Id;
				r.FloatField[FI.defaultteamdata_offset3x] = (float)this.m_Formation.PlayingRoles[3].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset3y] = (float)this.m_Formation.PlayingRoles[3].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction3_1] = this.m_Formation.PlayingRoles[3].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction3_2] = this.m_Formation.PlayingRoles[3].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position3] = this.m_Formation.PlayingRoles[3].Role.Id;
				r.FloatField[FI.defaultteamdata_offset4x] = (float)this.m_Formation.PlayingRoles[4].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset4y] = (float)this.m_Formation.PlayingRoles[4].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction4_1] = this.m_Formation.PlayingRoles[4].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction4_2] = this.m_Formation.PlayingRoles[4].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position4] = this.m_Formation.PlayingRoles[4].Role.Id;
				r.FloatField[FI.defaultteamdata_offset5x] = (float)this.m_Formation.PlayingRoles[5].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset5y] = (float)this.m_Formation.PlayingRoles[5].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction5_1] = this.m_Formation.PlayingRoles[5].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction5_2] = this.m_Formation.PlayingRoles[5].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position5] = this.m_Formation.PlayingRoles[5].Role.Id;
				r.FloatField[FI.defaultteamdata_offset6x] = (float)this.m_Formation.PlayingRoles[6].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset6y] = (float)this.m_Formation.PlayingRoles[6].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction6_1] = this.m_Formation.PlayingRoles[6].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction6_2] = this.m_Formation.PlayingRoles[6].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position6] = this.m_Formation.PlayingRoles[6].Role.Id;
				r.FloatField[FI.defaultteamdata_offset7x] = (float)this.m_Formation.PlayingRoles[7].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset7y] = (float)this.m_Formation.PlayingRoles[7].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction7_1] = this.m_Formation.PlayingRoles[7].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction7_2] = this.m_Formation.PlayingRoles[7].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position7] = this.m_Formation.PlayingRoles[7].Role.Id;
				r.FloatField[FI.defaultteamdata_offset8x] = (float)this.m_Formation.PlayingRoles[8].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset8y] = (float)this.m_Formation.PlayingRoles[8].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction8_1] = this.m_Formation.PlayingRoles[8].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction8_2] = this.m_Formation.PlayingRoles[8].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position8] = this.m_Formation.PlayingRoles[8].Role.Id;
				r.FloatField[FI.defaultteamdata_offset9x] = (float)this.m_Formation.PlayingRoles[9].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset9y] = (float)this.m_Formation.PlayingRoles[9].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction9_1] = this.m_Formation.PlayingRoles[9].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction9_2] = this.m_Formation.PlayingRoles[9].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position9] = this.m_Formation.PlayingRoles[9].Role.Id;
				r.FloatField[FI.defaultteamdata_offset10x] = (float)this.m_Formation.PlayingRoles[10].OffsetX / 100f;
				r.FloatField[FI.defaultteamdata_offset10y] = (float)this.m_Formation.PlayingRoles[10].OffsetY / 100f;
				r.IntField[FI.defaultteamdata_playerinstruction10_1] = this.m_Formation.PlayingRoles[10].PlayerInstruction_1;
				r.IntField[FI.defaultteamdata_playerinstruction10_2] = this.m_Formation.PlayingRoles[10].PlayerInstruction_2;
				r.IntField[FI.defaultteamdata_position10] = this.m_Formation.PlayingRoles[10].Role.Id;
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00042C34 File Offset: 0x00040E34
		public void SaveDefaultTeamsheets(Record r)
		{
			if (r == null)
			{
				return;
			}
			r.IntField[FI.default_teamsheets_teamid] = base.Id;
			r.IntField[FI.default_teamsheets_tacticid] = 0;
			r.IntField[FI.default_teamsheets_busbuildupspeed] = this.m_busbuildupspeed;
			r.IntField[FI.default_teamsheets_busdribbling] = this.m_busdribbling;
			r.IntField[FI.default_teamsheets_buspassing] = this.m_buspassing;
			r.IntField[FI.default_teamsheets_buspositioning] = this.m_buspositioning;
			r.IntField[FI.default_teamsheets_cccrossing] = this.m_cccrossing;
			r.IntField[FI.default_teamsheets_ccpassing] = this.m_ccpassing;
			r.IntField[FI.default_teamsheets_ccpositioning] = this.m_ccpositioning;
			r.IntField[FI.default_teamsheets_ccshooting] = this.m_ccshooting;
			r.IntField[FI.default_teamsheets_defaggression] = this.m_defaggression;
			r.IntField[FI.default_teamsheets_defdefenderline] = this.m_defdefenderline;
			r.IntField[FI.default_teamsheets_defmentality] = this.m_defmentality;
			r.IntField[FI.default_teamsheets_defteamwidth] = this.m_defteamwidth;
			if (this.m_Formation != null)
			{
				r.FloatField[FI.default_teamsheets_offset0x] = (float)this.m_Formation.PlayingRoles[0].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset0y] = (float)this.m_Formation.PlayingRoles[0].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction0_1] = this.m_Formation.PlayingRoles[0].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position0] = this.m_Formation.PlayingRoles[0].Role.Id;
				r.FloatField[FI.default_teamsheets_offset1x] = (float)this.m_Formation.PlayingRoles[1].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset1y] = (float)this.m_Formation.PlayingRoles[1].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction1_1] = this.m_Formation.PlayingRoles[1].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position1] = this.m_Formation.PlayingRoles[1].Role.Id;
				r.FloatField[FI.default_teamsheets_offset2x] = (float)this.m_Formation.PlayingRoles[2].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset2y] = (float)this.m_Formation.PlayingRoles[2].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction2_1] = this.m_Formation.PlayingRoles[2].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position2] = this.m_Formation.PlayingRoles[2].Role.Id;
				r.FloatField[FI.default_teamsheets_offset3x] = (float)this.m_Formation.PlayingRoles[3].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset3y] = (float)this.m_Formation.PlayingRoles[3].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction3_1] = this.m_Formation.PlayingRoles[3].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position3] = this.m_Formation.PlayingRoles[3].Role.Id;
				r.FloatField[FI.default_teamsheets_offset4x] = (float)this.m_Formation.PlayingRoles[4].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset4y] = (float)this.m_Formation.PlayingRoles[4].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction4_1] = this.m_Formation.PlayingRoles[4].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position4] = this.m_Formation.PlayingRoles[4].Role.Id;
				r.FloatField[FI.default_teamsheets_offset5x] = (float)this.m_Formation.PlayingRoles[5].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset5y] = (float)this.m_Formation.PlayingRoles[5].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction5_1] = this.m_Formation.PlayingRoles[5].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position5] = this.m_Formation.PlayingRoles[5].Role.Id;
				r.FloatField[FI.default_teamsheets_offset6x] = (float)this.m_Formation.PlayingRoles[6].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset6y] = (float)this.m_Formation.PlayingRoles[6].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction6_1] = this.m_Formation.PlayingRoles[6].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position6] = this.m_Formation.PlayingRoles[6].Role.Id;
				r.FloatField[FI.default_teamsheets_offset7x] = (float)this.m_Formation.PlayingRoles[7].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset7y] = (float)this.m_Formation.PlayingRoles[7].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction7_1] = this.m_Formation.PlayingRoles[7].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position7] = this.m_Formation.PlayingRoles[7].Role.Id;
				r.FloatField[FI.default_teamsheets_offset8x] = (float)this.m_Formation.PlayingRoles[8].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset8y] = (float)this.m_Formation.PlayingRoles[8].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction8_1] = this.m_Formation.PlayingRoles[8].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position8] = this.m_Formation.PlayingRoles[8].Role.Id;
				r.FloatField[FI.default_teamsheets_offset9x] = (float)this.m_Formation.PlayingRoles[9].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset9y] = (float)this.m_Formation.PlayingRoles[9].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction9_1] = this.m_Formation.PlayingRoles[9].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position9] = this.m_Formation.PlayingRoles[9].Role.Id;
				r.FloatField[FI.default_teamsheets_offset10x] = (float)this.m_Formation.PlayingRoles[10].OffsetX / 100f;
				r.FloatField[FI.default_teamsheets_offset10y] = (float)this.m_Formation.PlayingRoles[10].OffsetY / 100f;
				r.IntField[FI.default_teamsheets_playerinstruction10_1] = this.m_Formation.PlayingRoles[10].PlayerInstruction_1;
				r.IntField[FI.default_teamsheets_position10] = this.m_Formation.PlayingRoles[10].Role.Id;
			}
			r.IntField[FI.default_teamsheets_captainid] = this.m_captainid;
			r.IntField[FI.default_teamsheets_freekicktakerid] = this.m_freekicktakerid;
			r.IntField[FI.default_teamsheets_leftcornerkicktakerid] = this.m_leftcornerkicktakerid;
			r.IntField[FI.default_teamsheets_leftfreekicktakerid] = this.m_leftfreekicktakerid;
			r.IntField[FI.default_teamsheets_longkicktakerid] = this.m_longkicktakerid;
			r.IntField[FI.default_teamsheets_penaltytakerid] = this.m_penaltytakerid;
			r.IntField[FI.default_teamsheets_rightcornerkicktakerid] = this.m_rightcornerkicktakerid;
			r.IntField[FI.default_teamsheets_rightfreekicktakerid] = this.m_rightfreekicktakerid;
			int[] array = new int[]
			{
				FI.default_teamsheets_playerid0,
				FI.default_teamsheets_playerid1,
				FI.default_teamsheets_playerid2,
				FI.default_teamsheets_playerid3,
				FI.default_teamsheets_playerid4,
				FI.default_teamsheets_playerid5,
				FI.default_teamsheets_playerid6,
				FI.default_teamsheets_playerid7,
				FI.default_teamsheets_playerid8,
				FI.default_teamsheets_playerid9,
				FI.default_teamsheets_playerid10,
				FI.default_teamsheets_playerid11,
				FI.default_teamsheets_playerid12,
				FI.default_teamsheets_playerid13,
				FI.default_teamsheets_playerid14,
				FI.default_teamsheets_playerid15,
				FI.default_teamsheets_playerid16,
				FI.default_teamsheets_playerid17,
				FI.default_teamsheets_playerid18,
				FI.default_teamsheets_playerid19,
				FI.default_teamsheets_playerid20,
				FI.default_teamsheets_playerid21,
				FI.default_teamsheets_playerid22,
				FI.default_teamsheets_playerid23,
				FI.default_teamsheets_playerid24,
				FI.default_teamsheets_playerid25,
				FI.default_teamsheets_playerid26,
				FI.default_teamsheets_playerid27,
				FI.default_teamsheets_playerid28,
				FI.default_teamsheets_playerid29,
				FI.default_teamsheets_playerid30,
				FI.default_teamsheets_playerid31,
				FI.default_teamsheets_playerid32,
				FI.default_teamsheets_playerid33,
				FI.default_teamsheets_playerid34,
				FI.default_teamsheets_playerid35,
				FI.default_teamsheets_playerid36,
				FI.default_teamsheets_playerid37,
				FI.default_teamsheets_playerid38,
				FI.default_teamsheets_playerid39,
				FI.default_teamsheets_playerid40,
				FI.default_teamsheets_playerid41
			};
			for (int i = 0; i < array.Length; i++)
			{
				TeamPlayer teamPlayer = null;
				if (i < this.m_Roster.Count)
				{
					teamPlayer = (TeamPlayer)this.m_Roster[i];
				}
				r.IntField[array[i]] = ((teamPlayer != null && teamPlayer.Player != null) ? teamPlayer.Player.Id : (-1));
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000435A4 File Offset: 0x000417A4
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Full, this.m_TeamNameFull);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr15, this.m_TeamNameAbbr15);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr10, this.m_TeamNameAbbr10);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr7, this.m_TeamNameAbbr7);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr3, this.m_TeamNameAbbr3);
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void SaveTeamCountry(Record r)
		{
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0004362B File Offset: 0x0004182B
		public void SaveStadiumAssignment(Record r)
		{
			r.IntField[FI.stadiumassignments_teamid] = base.Id;
			r.StringField[FI.stadiumassignments_stadiumcustomname] = this.m_stadiumcustomname;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00043651 File Offset: 0x00041851
		public void SaveManager(Record r)
		{
			r.IntField[FI.manager_teamid] = base.Id;
			r.StringField[FI.manager_firstname] = this.m_ManagerFirstName;
			r.StringField[FI.manager_surname] = this.m_ManagerSurname;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00043689 File Offset: 0x00041889
		public bool HasNewsPictures()
		{
			return this.m_maxvariationsneg + this.m_maxvariationspos + this.m_maxvariationsstd != 0;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000436A4 File Offset: 0x000418A4
		public void SaveNewspicweights(Record r)
		{
			r.IntField[FI.career_newspicweights_teamid] = base.Id;
			r.IntField[FI.career_newspicweights_maxvariationsneg] = this.m_maxvariationsneg;
			r.IntField[FI.career_newspicweights_maxvariationspos] = this.m_maxvariationspos;
			r.IntField[FI.career_newspicweights_maxvariationsstd] = this.m_maxvariationsstd;
			r.IntField[FI.career_newspicweights_crestweight] = this.m_crestweight;
			r.IntField[FI.career_newspicweights_genericweight] = this.m_genericweight;
			r.IntField[FI.career_newspicweights_teamweight] = this.m_teamweight;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00043730 File Offset: 0x00041930
		public static void SaveDefaultNewspicweights(Record r)
		{
			r.IntField[FI.career_newspicweights_teamid] = 0;
			r.IntField[FI.career_newspicweights_maxvariationsneg] = 0;
			r.IntField[FI.career_newspicweights_maxvariationspos] = 0;
			r.IntField[FI.career_newspicweights_maxvariationsstd] = 30;
			r.IntField[FI.career_newspicweights_crestweight] = 40;
			r.IntField[FI.career_newspicweights_genericweight] = 60;
			r.IntField[FI.career_newspicweights_teamweight] = 0;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0004379B File Offset: 0x0004199B
		public void SaveTeamFormationLinks(Record r)
		{
			r.IntField[FI.teamformationteamstylelinks_teamid] = base.Id;
			r.IntField[FI.teamformationteamstylelinks_formationid] = this.m_formationid;
			r.IntField[FI.teamformationteamstylelinks_teamstyleid] = 0;
			r.IntField[FI.teamformationteamstylelinks_cddl] = 0;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000437DB File Offset: 0x000419DB
		public void SaveRowTeamNationLinks(Record r)
		{
			r.IntField[FI.rowteamnationlinks_teamid] = base.Id;
			if (this.m_Country != null)
			{
				r.IntField[FI.rowteamnationlinks_nationid] = this.m_Country.Id;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0004380E File Offset: 0x00041A0E
		public string CrestTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/crest/l#.dds";
			}
			return "data/ui/imgassets/crest/light/l#.dds";
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00043824 File Offset: 0x00041A24
		public string CrestDdsFileName()
		{
			return Team.CrestDdsFileName(base.Id);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00043831 File Offset: 0x00041A31
		public static string CrestDdsFileName(int id)
		{
			return Team.CrestDdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0004383E File Offset: 0x00041A3E
		public static string CrestDdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/crest/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/crest/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00043872 File Offset: 0x00041A72
		public string CrestTemplateFileNameDark()
		{
			return "data/ui/imgassets/crest/dark/l#.dds";
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0004387C File Offset: 0x00041A7C
		public string CrestDdsFileNameDark()
		{
			return "data/ui/imgassets/crest/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000438A6 File Offset: 0x00041AA6
		public static string CrestDdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000438BE File Offset: 0x00041ABE
		public string Crest50TemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/crest50x50/l#.dds";
			}
			return "data/ui/imgassets/crest50x50/light/l#.dds";
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000438D4 File Offset: 0x00041AD4
		public static string Crest50DdsFileName(int id)
		{
			return Team.Crest50DdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000438E1 File Offset: 0x00041AE1
		public static string Crest50DdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/crest50x50/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/crest50x50/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00043915 File Offset: 0x00041B15
		public string Crest50DdsFileName()
		{
			return Team.Crest50DdsFileName(base.Id);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00043922 File Offset: 0x00041B22
		public string Crest50TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest50x50/dark/l#.dds";
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0004392C File Offset: 0x00041B2C
		public string Crest50DdsFileNameDark()
		{
			return "data/ui/imgassets/crest50x50/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00043956 File Offset: 0x00041B56
		public static string Crest50DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest50x50/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0004396E File Offset: 0x00041B6E
		public string Crest32TemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/crest32x32/l#.dds";
			}
			return "data/ui/imgassets/crest32x32/light/l#.dds";
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00043984 File Offset: 0x00041B84
		public string Crest32DdsFileName()
		{
			return Team.Crest32DdsFileName(base.Id);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00043991 File Offset: 0x00041B91
		public static string Crest32DdsFileName(int id)
		{
			return Team.Crest32DdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0004399E File Offset: 0x00041B9E
		public static string Crest32DdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/crest32x32/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/crest32x32/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000439D2 File Offset: 0x00041BD2
		public string Crest32TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest32x32/dark/l#.dds";
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000439DC File Offset: 0x00041BDC
		public string Crest32DdsFileNameDark()
		{
			return "data/ui/imgassets/crest32x32/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00043A06 File Offset: 0x00041C06
		public static string Crest32DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest32x32/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00043A1E File Offset: 0x00041C1E
		public string Crest16TemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data/ui/imgassets/crest16x16/l#.dds";
			}
			return "data/ui/imgassets/crest16x16/light/l#.dds";
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00043A34 File Offset: 0x00041C34
		public string Crest16DdsFileName()
		{
			return Team.Crest16DdsFileName(base.Id);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00043A41 File Offset: 0x00041C41
		public static string Crest16DdsFileName(int id)
		{
			return Team.Crest16DdsFileName(id, FifaEnvironment.Year);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00043A4E File Offset: 0x00041C4E
		public static string Crest16DdsFileName(int id, int year)
		{
			if (year == 14)
			{
				return "data/ui/imgassets/crest16x16/l" + id.ToString() + ".dds";
			}
			return "data/ui/imgassets/crest16x16/light/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00043A82 File Offset: 0x00041C82
		public string Crest16TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest16x16/dark/l#.dds";
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00043A8C File Offset: 0x00041C8C
		public string Crest16DdsFileNameDark()
		{
			return "data/ui/imgassets/crest16x16/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00043AB6 File Offset: 0x00041CB6
		public static string Crest16DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest16x16/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00043ACE File Offset: 0x00041CCE
		public Bitmap GetCrest()
		{
			return FifaEnvironment.GetDdsArtasset(this.CrestDdsFileName());
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00043ADB File Offset: 0x00041CDB
		public bool SetCrest(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.CrestTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00043AEF File Offset: 0x00041CEF
		public bool DeleteCrest()
		{
			return FifaEnvironment.DeleteFromZdata(this.CrestDdsFileName());
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00043AFC File Offset: 0x00041CFC
		public Bitmap GetCrest50()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest50DdsFileName());
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00043B09 File Offset: 0x00041D09
		public bool SetCrest50(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest50TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00043B1D File Offset: 0x00041D1D
		public bool DeleteCrest50()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest50DdsFileName());
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00043B2A File Offset: 0x00041D2A
		public Bitmap GetCrest32()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest32DdsFileName());
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00043B37 File Offset: 0x00041D37
		public bool SetCrest32(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest32TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00043B4B File Offset: 0x00041D4B
		public bool DeleteCrest32()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest32DdsFileName());
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00043B58 File Offset: 0x00041D58
		public Bitmap GetCrest16()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest16DdsFileName());
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00043B65 File Offset: 0x00041D65
		public bool SetCrest16(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest16TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00043B79 File Offset: 0x00041D79
		public bool DeleteCrest16()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest16DdsFileName());
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00043B86 File Offset: 0x00041D86
		public Bitmap GetCrestDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.CrestDdsFileNameDark());
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00043B93 File Offset: 0x00041D93
		public bool SetCrestDark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.CrestTemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00043BA7 File Offset: 0x00041DA7
		public bool DeleteCrestDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.CrestDdsFileNameDark());
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00043BB4 File Offset: 0x00041DB4
		public Bitmap GetCrest50Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest50DdsFileNameDark());
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00043BC1 File Offset: 0x00041DC1
		public bool SetCrest50Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest50TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00043BD5 File Offset: 0x00041DD5
		public bool DeleteCrest50Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest50DdsFileNameDark());
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00043BE2 File Offset: 0x00041DE2
		public Bitmap GetCrest32Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest32DdsFileNameDark());
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00043BEF File Offset: 0x00041DEF
		public bool SetCrest32Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest32TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00043C03 File Offset: 0x00041E03
		public bool DeleteCrest32Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest32DdsFileNameDark());
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00043C10 File Offset: 0x00041E10
		public Bitmap GetCrest16Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest16DdsFileNameDark());
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00043C1D File Offset: 0x00041E1D
		public bool SetCrest16Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest16TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00043C31 File Offset: 0x00041E31
		public bool DeleteCrest16Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest16DdsFileNameDark());
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00043C40 File Offset: 0x00041E40
		public bool SetAllCrests(Bitmap crestLogo)
		{
			if (crestLogo.Width != 256 || crestLogo.Width != 256)
			{
				return false;
			}
			this.SetCrest(crestLogo);
			this.SetCrestDark(crestLogo);
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Bitmap bitmap = new Bitmap(64, 64, PixelFormat.Format32bppPArgb);
			Bitmap bitmap2 = new Bitmap(32, 32, PixelFormat.Format32bppPArgb);
			Bitmap bitmap3 = new Bitmap(16, 16, PixelFormat.Format32bppPArgb);
			Rectangle rectangle2 = new Rectangle(0, 0, 50, 50);
			Rectangle rectangle3 = new Rectangle(0, 0, 32, 32);
			Rectangle rectangle4 = new Rectangle(0, 0, 16, 16);
			GraphicUtil.RemapRectangle(crestLogo, rectangle, bitmap, rectangle2);
			GraphicUtil.RemapRectangle(crestLogo, rectangle, bitmap2, rectangle3);
			GraphicUtil.RemapRectangle(crestLogo, rectangle, bitmap3, rectangle4);
			this.SetCrest16(bitmap3);
			this.SetCrest16Dark(bitmap3);
			this.SetCrest32(bitmap2);
			this.SetCrest32Dark(bitmap2);
			this.SetCrest50(bitmap);
			this.SetCrest50Dark(bitmap);
			return true;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00043D30 File Offset: 0x00041F30
		public string BannerFileName()
		{
			return "data/sceneassets/banner/banner_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00043D5A File Offset: 0x00041F5A
		public static string BannerFileName(int id)
		{
			return "data/sceneassets/banner/banner_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00043D72 File Offset: 0x00041F72
		public string BannerTemplateFileName()
		{
			return "data/sceneassets/banner/banner_#.rx3";
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00043D79 File Offset: 0x00041F79
		public Bitmap GetBanner()
		{
			return FifaEnvironment.GetBmpFromRx3(this.BannerFileName());
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00043D86 File Offset: 0x00041F86
		public bool SetBanner(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.BannerTemplateFileName(), base.Id, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00043D9B File Offset: 0x00041F9B
		public bool SetBanner(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.BannerFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00043DAB File Offset: 0x00041FAB
		public bool DeleteBanner()
		{
			return FifaEnvironment.DeleteFromZdata(this.BannerFileName());
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00043DB8 File Offset: 0x00041FB8
		public static string GenericFlagFileName(int style)
		{
			return "data/sceneassets/flag/gf" + style.ToString() + ".png";
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00043DD0 File Offset: 0x00041FD0
		public string FlagFileName()
		{
			return "data/sceneassets/flag/flag_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00043DFA File Offset: 0x00041FFA
		public static string FlagFileName(int id)
		{
			return "data/sceneassets/flag/flag_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00043E12 File Offset: 0x00042012
		public string FlagTemplateFileName()
		{
			return "data/sceneassets/flag/flag_#.rx3";
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00043E1C File Offset: 0x0004201C
		private Rx3Signatures FlagsSignature()
		{
			return new Rx3Signatures(350544, 22, new string[]
			{
				"flag_" + base.Id.ToString() + "_0",
				"flag_" + base.Id.ToString() + "_1",
				"flag_" + base.Id.ToString() + "_2",
				"flag_" + base.Id.ToString() + "_3"
			});
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00043EBD File Offset: 0x000420BD
		public Bitmap[] GetFlags()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.FlagFileName());
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00043ECA File Offset: 0x000420CA
		public bool SetFlags(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.FlagTemplateFileName(), base.Id, bitmaps, ECompressionMode.Chunkzip, this.FlagsSignature());
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00043EE5 File Offset: 0x000420E5
		public bool DeleteFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.FlagFileName());
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00043EF4 File Offset: 0x000420F4
		public bool SetFlags(string rx3FileName)
		{
			string text = this.FlagFileName();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00043F11 File Offset: 0x00042111
		public bool ExportFlags(string exportFolder)
		{
			return FifaEnvironment.ExportFileFromZdata(this.FlagFileName(), exportFolder);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00043F20 File Offset: 0x00042120
		public string ScarfFileName()
		{
			return "data/sceneassets/flag/scarf_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00043F4A File Offset: 0x0004214A
		public static string ScarfFileName(int id)
		{
			return "data/sceneassets/flag/scarf_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00043F62 File Offset: 0x00042162
		public string ScarfTemplateFileName()
		{
			return "data/sceneassets/flag/scarf_#.rx3";
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00043F6C File Offset: 0x0004216C
		private Rx3Signatures ScarfsSignature()
		{
			return new Rx3Signatures(350544, 22, new string[]
			{
				"flag_" + base.Id.ToString() + "_0",
				"flag_" + base.Id.ToString() + "_1",
				"flag_" + base.Id.ToString() + "_2",
				"flag_" + base.Id.ToString() + "_3"
			});
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0004400D File Offset: 0x0004220D
		public Bitmap[] GetScarfs()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.ScarfFileName(), false);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0004401B File Offset: 0x0004221B
		public bool SetScarfs(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.ScarfTemplateFileName(), base.Id, bitmaps, ECompressionMode.None, this.ScarfsSignature());
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00044036 File Offset: 0x00042236
		public bool DeleteScarf()
		{
			return FifaEnvironment.DeleteFromZdata(this.ScarfFileName());
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00044044 File Offset: 0x00042244
		public bool SetScarfs(string rx3FileName)
		{
			string text = this.ScarfFileName();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.None);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00044061 File Offset: 0x00042261
		public bool ExportScarfs(string exportFolder)
		{
			return FifaEnvironment.ExportFileFromZdata(this.ScarfFileName(), exportFolder);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00044070 File Offset: 0x00042270
		public void RemoveTeamPlayer(TeamPlayer teamPlayer)
		{
			this.m_Roster.Remove(teamPlayer);
			teamPlayer.Player.NotPlayFor(this);
			if (teamPlayer.position < 28)
			{
				this.AssignRoleToSubstitute((ERole)teamPlayer.position);
				this.AssignBench();
			}
			else if (teamPlayer.position == 28)
			{
				this.AssignBench();
			}
			if (this.PlayerCaptain == teamPlayer.Player)
			{
				this.AssignCaptain();
			}
			if (this.PlayerLeftFreeKick == teamPlayer.Player || this.PlayerRightFreeKick == teamPlayer.Player || this.PlayerFreeKick == teamPlayer.Player)
			{
				this.AssignFreeKick();
			}
			if (this.PlayerPenalty == teamPlayer.Player)
			{
				this.AssignPenalty();
			}
			if (this.PlayerLeftCorner == teamPlayer.Player)
			{
				this.AssignLeftCorner();
			}
			if (this.PlayerRightCorner == teamPlayer.Player)
			{
				this.AssignRightCorner();
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00044144 File Offset: 0x00042344
		public void RemoveTeamPlayer(Player player)
		{
			TeamPlayer teamPlayer = this.m_Roster.SearchTeamPlayer(player);
			if (teamPlayer != null)
			{
				this.RemoveTeamPlayer(teamPlayer);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00044168 File Offset: 0x00042368
		public void AssignRoles()
		{
			this.AssignRoles(this.m_Formation);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00044178 File Offset: 0x00042378
		public void AssignRoles(Formation formation)
		{
			Roster roster = new Roster(32);
			ERole[] array = new ERole[11];
			int num = 11;
			for (int i = 0; i < 11; i++)
			{
				array[i] = formation.PlayingRoles[i].Role.RoleId;
			}
			for (int j = 0; j < 7; j++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				ERole erole = teamPlayer.Player.ChooseRole(array, num);
				teamPlayer.position = (int)erole;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
				for (int k = 0; k < num; k++)
				{
					if (erole == array[k])
					{
						for (int l = k; l < num - 1; l++)
						{
							array[l] = array[l + 1];
						}
						num--;
					}
				}
			}
			for (int m = 0; m < num; m++)
			{
				ERole erole2 = array[m];
				TeamPlayer teamPlayer = this.m_Roster.GetRoleBestPlayer(erole2);
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = (int)erole2;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			for (int n = 0; n < 7; n++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = 28;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			for (int num2 = 0; num2 < 14; num2++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = 29;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			foreach (object obj in roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				this.m_Roster.Add(teamPlayer2);
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00044354 File Offset: 0x00042554
		public void AssignTitolarToRoles(Formation formation)
		{
			Roster roster = new Roster(32);
			ERole[] array = new ERole[11];
			int num = 11;
			for (int i = 0; i < 11; i++)
			{
				array[i] = formation.PlayingRoles[i].Role.RoleId;
			}
			for (int j = 0; j < 11; j++)
			{
				TeamPlayer bestTitolar = this.m_Roster.GetBestTitolar();
				if (bestTitolar == null)
				{
					break;
				}
				ERole erole = bestTitolar.Player.ChooseRole(array, num);
				bestTitolar.position = (int)erole;
				roster.Add(bestTitolar);
				this.m_Roster.Remove(bestTitolar);
				for (int k = 0; k < num; k++)
				{
					if (erole == array[k])
					{
						for (int l = k; l < num - 1; l++)
						{
							array[l] = array[l + 1];
						}
						num--;
					}
				}
			}
			foreach (object obj in roster)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				this.m_Roster.Add(teamPlayer);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00044478 File Offset: 0x00042678
		public void AssignRoleToSubstitute(ERole role)
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position >= 28)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(role);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			if (teamPlayer != null)
			{
				teamPlayer.position = (int)role;
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00044500 File Offset: 0x00042700
		public void AssignVacantRolesToSubstitute()
		{
			for (int i = 0; i < 11; i++)
			{
				PlayingRole playingRole = this.m_Formation.PlayingRoles[i];
				if (this.Roster.SearchTeamPlayer(playingRole.Role) == null)
				{
					this.AssignRoleToSubstitute(playingRole.Role.RoleId);
				}
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0004454C File Offset: 0x0004274C
		public void AssignBench()
		{
			int num = 0;
			IEnumerator enumerator = this.m_Roster.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if (((TeamPlayer)enumerator.Current).position == 28)
					{
						num++;
					}
				}
			}
			for (int i = num; i < 7; i++)
			{
				foreach (object obj in this.m_Roster)
				{
					TeamPlayer teamPlayer = (TeamPlayer)obj;
					if (teamPlayer.position == 29)
					{
						teamPlayer.position = 28;
						break;
					}
				}
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00044610 File Offset: 0x00042810
		public void AssignVacantSpecialPlayers()
		{
			if (this.m_Roster.SearchPlayer(this.m_captainid) == null)
			{
				this.AssignCaptain();
			}
			if (this.m_Roster.SearchPlayer(this.m_penaltytakerid) == null)
			{
				this.AssignPenalty();
			}
			if (this.m_Roster.SearchPlayer(this.m_leftfreekicktakerid) == null)
			{
				this.AssignLeftFreeKick();
			}
			if (this.m_Roster.SearchPlayer(this.m_rightfreekicktakerid) == null)
			{
				this.AssignRightFreeKick();
			}
			if (this.m_Roster.SearchPlayer(this.m_longkicktakerid) == null)
			{
				this.AssignLongFreeKick();
			}
			if (this.m_Roster.SearchPlayer(this.m_leftcornerkicktakerid) == null)
			{
				this.AssignLeftCorner();
			}
			if (this.m_Roster.SearchPlayer(this.m_rightcornerkicktakerid) == null)
			{
				this.AssignRightCorner();
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000446CC File Offset: 0x000428CC
		public void AssignCaptain()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.ComputeMeanAttributes(5);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerCaptain = teamPlayer.Player;
				this.m_captainid = this.PlayerCaptain.Id;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00044768 File Offset: 0x00042968
		public void AssignPenalty()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.ComputeMeanAttributes(3);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerPenalty = teamPlayer.Player;
				if (this.PlayerPenalty != null)
				{
					this.m_penaltytakerid = this.PlayerPenalty.Id;
				}
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004480C File Offset: 0x00042A0C
		public void AssignFreeKick()
		{
			this.AssignLeftFreeKick();
			this.AssignRightFreeKick();
			this.AssignLongFreeKick();
			this.m_freekicktakerid = this.m_longkicktakerid;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004482C File Offset: 0x00042A2C
		public void AssignRightFreeKick()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.freekickaccuracy + teamPlayer2.Player.curve + ((teamPlayer2.Player.preferredfoot == 1) ? 5 : 0);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerRightFreeKick = teamPlayer.Player;
				this.m_rightfreekicktakerid = this.PlayerRightFreeKick.Id;
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000448E8 File Offset: 0x00042AE8
		public void AssignLeftFreeKick()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.freekickaccuracy + teamPlayer2.Player.curve + ((teamPlayer2.Player.preferredfoot == 0) ? 5 : 0);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerLeftFreeKick = teamPlayer.Player;
				this.m_leftfreekicktakerid = this.PlayerLeftFreeKick.Id;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000449A4 File Offset: 0x00042BA4
		public void AssignLongFreeKick()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.freekickaccuracy + teamPlayer2.Player.longshots;
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerLongKick = teamPlayer.Player;
				this.m_longkicktakerid = this.PlayerLongKick.Id;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00044A4C File Offset: 0x00042C4C
		public void AssignLeftCorner()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int crossing = teamPlayer2.Player.crossing;
					if (crossing >= num)
					{
						teamPlayer = teamPlayer2;
						num = crossing;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerLeftCorner = teamPlayer.Player;
				this.m_leftcornerkicktakerid = this.PlayerLeftCorner.Id;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00044AE8 File Offset: 0x00042CE8
		public void AssignRightCorner()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int crossing = teamPlayer2.Player.crossing;
					if (crossing >= num)
					{
						teamPlayer = teamPlayer2;
						num = crossing;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerRightCorner = teamPlayer.Player;
				this.m_rightcornerkicktakerid = this.PlayerRightCorner.Id;
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00044B84 File Offset: 0x00042D84
		public void AddTeamPlayer(TeamPlayer teamPlayer)
		{
			teamPlayer.position = 29;
			teamPlayer.m_jerseynumber = this.m_Roster.GetFreeNumber();
			teamPlayer.Team = this;
			this.m_Roster.Add(teamPlayer);
			teamPlayer.Player.PlayFor(this);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00044BC0 File Offset: 0x00042DC0
		public TeamPlayer AddTeamPlayer(Player player, int jerseyNumber)
		{
			TeamPlayer teamPlayer = this.AddTeamPlayer(player);
			if (jerseyNumber != 0)
			{
				teamPlayer.jerseynumber = jerseyNumber;
			}
			return teamPlayer;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00044BE0 File Offset: 0x00042DE0
		public TeamPlayer AddTeamPlayer(Player player)
		{
			TeamPlayer teamPlayer = new TeamPlayer(player);
			this.AddTeamPlayer(teamPlayer);
			return teamPlayer;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00044BFC File Offset: 0x00042DFC
		public void FixPlayersWithTwoClubs(bool keppInThisTeam)
		{
			if (this.IsClub())
			{
				for (int i = 0; i < this.Roster.Count; i++)
				{
					Player player = ((TeamPlayer)this.Roster[i]).Player;
					bool flag = false;
					foreach (object obj in player.m_PlayingForTeams)
					{
						Team team = (Team)obj;
						if (team.IsClub() && team != this)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						for (int j = 0; j < player.m_PlayingForTeams.Count; j++)
						{
							Team team2 = (Team)player.m_PlayingForTeams[j];
							if (team2.IsClub() && team2 != this)
							{
								if (keppInThisTeam)
								{
									team2.RemoveTeamPlayer(player);
									break;
								}
								this.RemoveTeamPlayer(player);
								i--;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00044CFC File Offset: 0x00042EFC
		public Kit GetKit(int kitType)
		{
			return this.m_KitList.GetKit(base.Id, kitType);
		}

		// Token: 0x04001032 RID: 4146
		private static int[] c_TopLeaguesId = new int[] { 13, 16, 19, 31, 53, 341 };

		// Token: 0x04001033 RID: 4147
		private bool m_ImpatientBoard;

		// Token: 0x04001034 RID: 4148
		private bool m_LoyalBoard;

		// Token: 0x04001035 RID: 4149
		private bool m_SquadRotation;

		// Token: 0x04001036 RID: 4150
		private bool m_ConsistentLineup;

		// Token: 0x04001037 RID: 4151
		private bool m_SwitchWingers;

		// Token: 0x04001038 RID: 4152
		private bool m_CenterBacksSplit;

		// Token: 0x04001039 RID: 4153
		private bool m_DefendLead;

		// Token: 0x0400103A RID: 4154
		private bool m_KeepUpPressure;

		// Token: 0x0400103B RID: 4155
		private bool m_MoreAttackingAtHome;

		// Token: 0x0400103C RID: 4156
		private bool m_ShortOutBack;

		// Token: 0x0400103D RID: 4157
		private int m_balltype = 1;

		// Token: 0x0400103E RID: 4158
		private Ball m_Ball;

		// Token: 0x0400103F RID: 4159
		private int m_adboardid = 1;

		// Token: 0x04001040 RID: 4160
		private bool m_HasSpecificAdboard;

		// Token: 0x04001041 RID: 4161
		private int m_stadiumid = -1;

		// Token: 0x04001042 RID: 4162
		private Stadium m_Stadium;

		// Token: 0x04001043 RID: 4163
		private int m_rivalteam;

		// Token: 0x04001044 RID: 4164
		private Team m_RivalTeam;

		// Token: 0x04001045 RID: 4165
		private int m_formationid;

		// Token: 0x04001046 RID: 4166
		private Formation m_Formation;

		// Token: 0x04001047 RID: 4167
		private int m_captainid;

		// Token: 0x04001048 RID: 4168
		private int m_penaltytakerid;

		// Token: 0x04001049 RID: 4169
		private int m_leftfreekicktakerid;

		// Token: 0x0400104A RID: 4170
		private int m_rightfreekicktakerid;

		// Token: 0x0400104B RID: 4171
		private int m_freekicktakerid;

		// Token: 0x0400104C RID: 4172
		private int m_longkicktakerid;

		// Token: 0x0400104D RID: 4173
		private int m_leftcornerkicktakerid;

		// Token: 0x0400104E RID: 4174
		private int m_rightcornerkicktakerid;

		// Token: 0x0400104F RID: 4175
		public Player PlayerCaptain;

		// Token: 0x04001050 RID: 4176
		public Player PlayerPenalty;

		// Token: 0x04001051 RID: 4177
		public Player PlayerFreeKick;

		// Token: 0x04001052 RID: 4178
		public Player PlayerLeftFreeKick;

		// Token: 0x04001053 RID: 4179
		public Player PlayerRightFreeKick;

		// Token: 0x04001054 RID: 4180
		public Player PlayerLongKick;

		// Token: 0x04001055 RID: 4181
		public Player PlayerLeftCorner;

		// Token: 0x04001056 RID: 4182
		public Player PlayerRightCorner;

		// Token: 0x04001057 RID: 4183
		private string m_TeamNameFull;

		// Token: 0x04001058 RID: 4184
		private string m_TeamNameAbbr15;

		// Token: 0x04001059 RID: 4185
		private string m_TeamNameAbbr10;

		// Token: 0x0400105A RID: 4186
		private string m_TeamNameAbbr3;

		// Token: 0x0400105B RID: 4187
		private string m_TeamNameAbbr7;

		// Token: 0x0400105C RID: 4188
		private string m_teamname;

		// Token: 0x0400105D RID: 4189
		private int m_jerseytype;

		// Token: 0x0400105E RID: 4190
		private int m_fancrowdhairskintexturecode;

		// Token: 0x0400105F RID: 4191
		private int m_stafftracksuitcolorcode;

		// Token: 0x04001060 RID: 4192
		private int m_physioid_primary;

		// Token: 0x04001061 RID: 4193
		private int m_physioid_secondary;

		// Token: 0x04001062 RID: 4194
		private int m_teamcolor1r;

		// Token: 0x04001063 RID: 4195
		private int m_teamcolor1g;

		// Token: 0x04001064 RID: 4196
		private int m_teamcolor1b;

		// Token: 0x04001065 RID: 4197
		private Color m_TeamColor1;

		// Token: 0x04001066 RID: 4198
		private Color m_TeamColor2;

		// Token: 0x04001067 RID: 4199
		private Color m_TeamColor3;

		// Token: 0x04001068 RID: 4200
		private int m_teamcolor2r;

		// Token: 0x04001069 RID: 4201
		private int m_teamcolor2g;

		// Token: 0x0400106A RID: 4202
		private int m_teamcolor2b;

		// Token: 0x0400106B RID: 4203
		private int m_teamcolor3r;

		// Token: 0x0400106C RID: 4204
		private int m_teamcolor3g;

		// Token: 0x0400106D RID: 4205
		private int m_teamcolor3b;

		// Token: 0x0400106E RID: 4206
		private int m_form;

		// Token: 0x0400106F RID: 4207
		private int m_managerid;

		// Token: 0x04001070 RID: 4208
		private int m_latitude;

		// Token: 0x04001071 RID: 4209
		private int m_longitude;

		// Token: 0x04001072 RID: 4210
		private int m_bodytypeid;

		// Token: 0x04001073 RID: 4211
		private int m_suitvariationid;

		// Token: 0x04001074 RID: 4212
		private int m_suittypeid;

		// Token: 0x04001075 RID: 4213
		private int m_personalityid;

		// Token: 0x04001076 RID: 4214
		private int m_busdribbling;

		// Token: 0x04001077 RID: 4215
		private int m_trait1;

		// Token: 0x04001078 RID: 4216
		private int m_utcoffset;

		// Token: 0x04001079 RID: 4217
		private int m_ethnicity;

		// Token: 0x0400107A RID: 4218
		private int m_powid;

		// Token: 0x0400107B RID: 4219
		public bool m_genericbanner;

		// Token: 0x0400107C RID: 4220
		private int m_assetid;

		// Token: 0x0400107D RID: 4221
		private int m_transferbudget;

		// Token: 0x0400107E RID: 4222
		private int m_internationalprestige;

		// Token: 0x0400107F RID: 4223
		private int m_domesticprestige;

		// Token: 0x04001080 RID: 4224
		private int m_numtransfersin;

		// Token: 0x04001081 RID: 4225
		private string m_stadiumcustomname;

		// Token: 0x04001082 RID: 4226
		private string m_ManagerFirstName;

		// Token: 0x04001083 RID: 4227
		private string m_ManagerSurname;

		// Token: 0x04001084 RID: 4228
		private int m_busbuildupspeed;

		// Token: 0x04001085 RID: 4229
		private int m_buspassing;

		// Token: 0x04001086 RID: 4230
		private int m_buspositioning;

		// Token: 0x04001087 RID: 4231
		private int m_ccpassing;

		// Token: 0x04001088 RID: 4232
		private int m_cccrossing;

		// Token: 0x04001089 RID: 4233
		private int m_ccshooting;

		// Token: 0x0400108A RID: 4234
		private int m_ccpositioning;

		// Token: 0x0400108B RID: 4235
		private int m_defmentality;

		// Token: 0x0400108C RID: 4236
		private int m_defaggression;

		// Token: 0x0400108D RID: 4237
		private int m_defteamwidth;

		// Token: 0x0400108E RID: 4238
		private int m_defdefenderline;

		// Token: 0x0400108F RID: 4239
		private int m_genericint2;

		// Token: 0x04001090 RID: 4240
		private int m_genericint1;

		// Token: 0x04001091 RID: 4241
		private int m_midfieldrating;

		// Token: 0x04001092 RID: 4242
		private int m_defenserating;

		// Token: 0x04001093 RID: 4243
		private int m_attackrating;

		// Token: 0x04001094 RID: 4244
		private int m_overallrating;

		// Token: 0x04001095 RID: 4245
		private int m_matchdayoverallrating;

		// Token: 0x04001096 RID: 4246
		private int m_matchdaydefenserating;

		// Token: 0x04001097 RID: 4247
		private int m_matchdaymidfieldrating;

		// Token: 0x04001098 RID: 4248
		private int m_matchdayattackrating;

		// Token: 0x04001099 RID: 4249
		private Roster m_Roster = new Roster(32);

		// Token: 0x0400109A RID: 4250
		public int m_countryid_IfNationalTeam;

		// Token: 0x0400109B RID: 4251
		public int m_countryid_IfRowTeam;

		// Token: 0x0400109C RID: 4252
		public int m_countryid_IfLeagueTeam;

		// Token: 0x0400109D RID: 4253
		private Country m_Country;

		// Token: 0x0400109E RID: 4254
		private int m_leagueid;

		// Token: 0x0400109F RID: 4255
		private League m_League;

		// Token: 0x040010A0 RID: 4256
		private int m_prevleagueid;

		// Token: 0x040010A1 RID: 4257
		private League m_PrevLeague;

		// Token: 0x040010A2 RID: 4258
		private bool m_champion;

		// Token: 0x040010A3 RID: 4259
		private int m_previousyeartableposition;

		// Token: 0x040010A4 RID: 4260
		private int m_currenttableposition;

		// Token: 0x040010A5 RID: 4261
		private int m_teamshortform;

		// Token: 0x040010A6 RID: 4262
		private int m_teamlongform;

		// Token: 0x040010A7 RID: 4263
		private int m_teamform;

		// Token: 0x040010A8 RID: 4264
		private bool m_hasachievedobjective;

		// Token: 0x040010A9 RID: 4265
		private bool m_yettowin;

		// Token: 0x040010AA RID: 4266
		private bool m_unbeatenallcomps;

		// Token: 0x040010AB RID: 4267
		private bool m_unbeatenaway;

		// Token: 0x040010AC RID: 4268
		private bool m_unbeatenhome;

		// Token: 0x040010AD RID: 4269
		private bool m_unbeatenleague;

		// Token: 0x040010AE RID: 4270
		private int m_highestpossible;

		// Token: 0x040010AF RID: 4271
		private int m_highestprobable;

		// Token: 0x040010B0 RID: 4272
		private int m_nummatchesplayed;

		// Token: 0x040010B1 RID: 4273
		private int m_gapresult;

		// Token: 0x040010B2 RID: 4274
		private int m_grouping;

		// Token: 0x040010B3 RID: 4275
		private int m_objective;

		// Token: 0x040010B4 RID: 4276
		private int m_actualvsexpectations;

		// Token: 0x040010B5 RID: 4277
		private int m_lastgameresult;

		// Token: 0x040010B6 RID: 4278
		private int m_homega;

		// Token: 0x040010B7 RID: 4279
		private int m_homegf;

		// Token: 0x040010B8 RID: 4280
		private int m_points;

		// Token: 0x040010B9 RID: 4281
		private int m_awayga;

		// Token: 0x040010BA RID: 4282
		private int m_secondarytable;

		// Token: 0x040010BB RID: 4283
		private int m_homewins;

		// Token: 0x040010BC RID: 4284
		private int m_awaywins;

		// Token: 0x040010BD RID: 4285
		private int m_homelosses;

		// Token: 0x040010BE RID: 4286
		private int m_awaylosses;

		// Token: 0x040010BF RID: 4287
		private int m_awaydraws;

		// Token: 0x040010C0 RID: 4288
		private int m_homedraws;

		// Token: 0x040010C1 RID: 4289
		public KitList m_KitList = new KitList();

		// Token: 0x040010C2 RID: 4290
		private int[] m_teamkitidList = new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };

		// Token: 0x040010C3 RID: 4291
		private int m_crestweight = 25;

		// Token: 0x040010C4 RID: 4292
		private int m_genericweight = 25;

		// Token: 0x040010C5 RID: 4293
		private int m_teamweight = 50;

		// Token: 0x040010C6 RID: 4294
		private int m_maxvariationsneg;

		// Token: 0x040010C7 RID: 4295
		private int m_maxvariationspos;

		// Token: 0x040010C8 RID: 4296
		private int m_maxvariationsstd;
	}
}
