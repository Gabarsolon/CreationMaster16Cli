using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000005 RID: 5
	public class Ball : IdObject
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000023C0 File Offset: 0x000005C0
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000023C8 File Offset: 0x000005C8
		public bool IsLicensed
		{
			get
			{
				return this.m_IsLicensed;
			}
			set
			{
				this.m_IsLicensed = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000023D1 File Offset: 0x000005D1
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000023D9 File Offset: 0x000005D9
		public bool IsAvailable
		{
			get
			{
				return this.m_IsAvailable;
			}
			set
			{
				this.m_IsAvailable = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000023E2 File Offset: 0x000005E2
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000023EA File Offset: 0x000005EA
		public bool IsEmbargoed
		{
			get
			{
				return this.m_IsEmbargoed;
			}
			set
			{
				this.m_IsEmbargoed = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023F3 File Offset: 0x000005F3
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000023FB File Offset: 0x000005FB
		public int powid
		{
			get
			{
				return this.m_powid;
			}
			set
			{
				this.m_powid = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002404 File Offset: 0x00000604
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000240C File Offset: 0x0000060C
		public string Name
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002431 File Offset: 0x00000631
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002439 File Offset: 0x00000639
		public bool IsGeneric
		{
			get
			{
				return this.m_IsGeneric;
			}
			set
			{
				if (value != this.m_IsGeneric)
				{
					FifaEnvironment.Language.RemoveBallName(base.Id);
					FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, value);
				}
				this.m_IsGeneric = value;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002474 File Offset: 0x00000674
		public Ball(int ballId)
			: base(ballId)
		{
			this.m_LanguageName = FifaEnvironment.Language.GetBallName(base.Id, out this.m_IsGeneric);
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = "Ball n." + base.Id.ToString();
				this.m_IsGeneric = false;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
			this.m_IsLicensed = false;
			this.m_IsAvailable = true;
			this.m_IsEmbargoed = false;
			this.m_powid = -1;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000250C File Offset: 0x0000070C
		public Ball(Record r)
			: base(r.IntField[FI.teamballs_ballid])
		{
			this.m_LanguageName = FifaEnvironment.Language.GetBallName(base.Id, out this.m_IsGeneric);
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = "Ball n." + base.Id.ToString();
				this.m_IsGeneric = false;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
			this.m_IsLicensed = r.GetAndCheckIntField(FI.teamballs_islicensed) != 0;
			this.m_IsAvailable = r.GetAndCheckIntField(FI.teamballs_isavailableinstore) != 0;
			this.m_IsEmbargoed = r.GetAndCheckIntField(FI.teamballs_isembargoed) != 0;
			this.m_powid = r.GetAndCheckIntField(FI.teamballs_powid);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000025E8 File Offset: 0x000007E8
		public void SaveBall(Record r)
		{
			r.IntField[FI.teamballs_ballid] = base.Id;
			r.IntField[FI.teamballs_islicensed] = (this.m_IsLicensed ? 1 : 0);
			r.IntField[FI.teamballs_isavailableinstore] = (this.m_IsAvailable ? 1 : 0);
			r.IntField[FI.teamballs_isembargoed] = 0;
			r.IntField[FI.teamballs_powid] = -1;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002404 File Offset: 0x00000604
		public override string ToString()
		{
			return this.m_LanguageName;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002651 File Offset: 0x00000851
		public static string BallTextureFileName(int ballId)
		{
			return "data/sceneassets/ball/ball_" + ballId.ToString() + "_textures.rx3";
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002669 File Offset: 0x00000869
		public static string RevModTeamBallTextureFileName(int teamId)
		{
			return "data/sceneassets/ball/specificball_" + teamId.ToString() + "_0_0_textures.rx3";
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002681 File Offset: 0x00000881
		public static string RevModTrophyBallTextureFileName(int assetId)
		{
			return "data/sceneassets/ball/specificball_0_" + assetId.ToString() + "_0_textures.rx3";
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002699 File Offset: 0x00000899
		public string BallTextureFileName()
		{
			return Ball.BallTextureFileName(base.Id);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026A6 File Offset: 0x000008A6
		public static Bitmap GetBallTexture(int ballId)
		{
			return FifaEnvironment.GetBmpFromRx3(Ball.BallTextureFileName(ballId), 0);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000026B4 File Offset: 0x000008B4
		public Bitmap GetBallTexture()
		{
			return Ball.GetBallTexture(base.Id);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000026C1 File Offset: 0x000008C1
		public static Bitmap[] GetBallTextures(int ballId)
		{
			return FifaEnvironment.GetBmpsFromRx3(Ball.BallTextureFileName(ballId));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000026CE File Offset: 0x000008CE
		public static Bitmap[] GetRevModTeamBallTextures(int teamId)
		{
			return FifaEnvironment.GetBmpsFromRx3(Ball.RevModTeamBallTextureFileName(teamId), false);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000026DC File Offset: 0x000008DC
		public static Bitmap[] GetRevModTrophyBallTextures(int tournamentAssetId)
		{
			return FifaEnvironment.GetBmpsFromRx3(Ball.RevModTrophyBallTextureFileName(tournamentAssetId), false);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000026EA File Offset: 0x000008EA
		public Bitmap[] GetBallTextures()
		{
			return Ball.GetBallTextures(base.Id);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000026F7 File Offset: 0x000008F7
		public static string BallTextureTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data\\sceneassets\\ball\\2014_ball_#_textures.rx3";
			}
			return "data\\sceneassets\\ball\\ball_#_textures.rx3";
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000270D File Offset: 0x0000090D
		public static bool SetBallTextures(int ballId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(Ball.BallTextureTemplateFileName(), ballId, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000271C File Offset: 0x0000091C
		public static bool SetRevModTeamBallTextures(int teamId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data\\sceneassets\\ball\\specificball_#_0_0_textures.rx3", teamId, bitmaps, ECompressionMode.None);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000272B File Offset: 0x0000092B
		public static bool SetRevModTrophyBallTextures(int assetId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data\\sceneassets\\ball\\specificball_0_#_0_textures.rx3", assetId, bitmaps, ECompressionMode.None);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000273A File Offset: 0x0000093A
		public bool SetBallTextures(Bitmap[] bitmaps)
		{
			return Ball.SetBallTextures(base.Id, bitmaps);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002748 File Offset: 0x00000948
		public static bool SetBallTextures(int ballId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.BallTextureFileName(ballId), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002758 File Offset: 0x00000958
		public static bool SetRevModTeamBallTextures(int teamId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.RevModTeamBallTextureFileName(teamId), false, ECompressionMode.None);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002768 File Offset: 0x00000968
		public static bool SetRevModTrophyBallTextures(int assetId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.RevModTrophyBallTextureFileName(assetId), false, ECompressionMode.None);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002778 File Offset: 0x00000978
		public bool SetBallTextures(string srcFileName)
		{
			return Ball.SetBallTextures(base.Id, srcFileName);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002786 File Offset: 0x00000986
		public bool DeleteBallTextures()
		{
			return FifaEnvironment.DeleteFromZdata(this.BallTextureFileName());
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002793 File Offset: 0x00000993
		public static bool DeleteRevModTrophyBallTextures(int assetId)
		{
			return FifaEnvironment.DeleteFromZdata(Ball.RevModTrophyBallTextureFileName(assetId));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000027A0 File Offset: 0x000009A0
		public static bool DeleteRevModTeamBallTextures(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Ball.RevModTeamBallTextureFileName(teamId));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000027AD File Offset: 0x000009AD
		public static string BallPictureTemplateBigFileName()
		{
			return "data/ui/artassets/settingsimg/ball_#.big";
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000027B4 File Offset: 0x000009B4
		public static string BallPictureTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000027BB File Offset: 0x000009BB
		public static string BallPictureBigFileName(int ballId)
		{
			return "data/ui/artassets/settingsimg/ball_" + ballId.ToString() + ".big";
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000027D3 File Offset: 0x000009D3
		public string BallPictureBigFileName()
		{
			return Ball.BallPictureBigFileName(base.Id);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000027E0 File Offset: 0x000009E0
		public static Bitmap GetBallPicture(int ballId)
		{
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.GetArtasset(Ball.BallPictureBigFileName(ballId));
			}
			return FifaEnvironment.GetDdsArtasset(Ball.BallDdsFileName(ballId));
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002802 File Offset: 0x00000A02
		public Bitmap GetBallPicture()
		{
			return Ball.GetBallPicture(base.Id);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000280F File Offset: 0x00000A0F
		public bool DeleteBallPicture()
		{
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.DeleteFromZdata(this.BallPictureBigFileName());
			}
			return FifaEnvironment.DeleteFromZdata(this.BallDdsFileName());
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002831 File Offset: 0x00000A31
		public static bool SetBallPicture(int ballId, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			if (FifaEnvironment.Year == 14)
			{
				return FifaEnvironment.SetArtasset(Ball.BallPictureTemplateBigFileName(), Ball.BallPictureTemplateDdsName(), ballId, bitmap);
			}
			return FifaEnvironment.SetDdsArtasset(Ball.BallDdsTemplateFileName(), ballId, bitmap);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000285F File Offset: 0x00000A5F
		public bool SetBallPicture(Bitmap bitmap)
		{
			return Ball.SetBallPicture(base.Id, bitmap);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000286D File Offset: 0x00000A6D
		public static string BallDdsFileName(int id)
		{
			return "data/ui/imgassets/settingsimg/ball_" + id.ToString() + ".dds";
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002885 File Offset: 0x00000A85
		public static string BallDdsTemplateFileName()
		{
			return "data/ui/imgassets/settingsimg/ball_#.dds";
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000288C File Offset: 0x00000A8C
		public string BallDdsFileName()
		{
			return Ball.BallDdsFileName(base.Id);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002899 File Offset: 0x00000A99
		public static string BallModelFileName(int ballId)
		{
			return "data/sceneassets/ball/ball_" + ballId.ToString() + ".rx3";
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000028B1 File Offset: 0x00000AB1
		public static string RevModTeamBallModelFileName(int teamId)
		{
			return "data/sceneassets/ball/specificball_" + teamId.ToString() + "_0_0.rx3";
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000028C9 File Offset: 0x00000AC9
		public static string RevModTrophyBallModelFileName(int assetId)
		{
			return "data/sceneassets/ball/specificball_0_" + assetId.ToString() + "_0.rx3";
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000028E1 File Offset: 0x00000AE1
		public string BallModelFileName()
		{
			return Ball.BallModelFileName(base.Id);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000028EE File Offset: 0x00000AEE
		public static string BallModelTemplateFileName()
		{
			return "data/sceneassets/ball/ball_#.rx3";
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000028F5 File Offset: 0x00000AF5
		public static Rx3File GetBallModel(int ballId)
		{
			string text = Ball.BallModelFileName(ballId);
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002908 File Offset: 0x00000B08
		public static Rx3File GetRevModTrophyBallModel(int assetId)
		{
			return FifaEnvironment.GetRx3FromZdata(Ball.RevModTrophyBallModelFileName(assetId), false);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002916 File Offset: 0x00000B16
		public static Rx3File GetRevModTeamBallModel(int teamId)
		{
			return FifaEnvironment.GetRx3FromZdata(Ball.RevModTeamBallModelFileName(teamId), false);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002924 File Offset: 0x00000B24
		public Rx3File GetBallModel()
		{
			return Ball.GetBallModel(base.Id);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002931 File Offset: 0x00000B31
		public static bool SetBallModel(int ballId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.BallModelFileName(ballId), false, ECompressionMode.Chunkzip, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002942 File Offset: 0x00000B42
		public static bool SetRevModTrophyBallModel(int assetId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.RevModTrophyBallModelFileName(assetId), false, ECompressionMode.None, null);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002953 File Offset: 0x00000B53
		public static bool SetRevModTeamBallModel(int teamId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.RevModTeamBallModelFileName(teamId), false, ECompressionMode.None, null);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002964 File Offset: 0x00000B64
		public bool SetBallModel(string srcFileName)
		{
			return Ball.SetBallModel(base.Id, srcFileName);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002972 File Offset: 0x00000B72
		public bool DeleteBallModel()
		{
			return FifaEnvironment.DeleteFromZdata(this.BallModelFileName());
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000297F File Offset: 0x00000B7F
		public static bool DeleteRevModTrophyBallModel(int assetId)
		{
			return FifaEnvironment.DeleteFromZdata(Ball.RevModTrophyBallModelFileName(assetId));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000298C File Offset: 0x00000B8C
		public static bool DeleteRevModTeamBallModel(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Ball.RevModTeamBallModelFileName(teamId));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002999 File Offset: 0x00000B99
		public bool DeleteBall()
		{
			this.DeleteBallTextures();
			this.DeleteBallModel();
			this.DeleteBallPicture();
			return true;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000029B4 File Offset: 0x00000BB4
		public override IdObject Clone(int newId)
		{
			Ball ball = (Ball)base.Clone(newId);
			if (ball != null)
			{
				ball.Name = "Ball n." + newId.ToString();
				FifaEnvironment.CloneIntoZdata(Ball.BallTextureFileName(base.Id), Ball.BallTextureFileName(newId));
				FifaEnvironment.CloneIntoZdata(Ball.BallModelFileName(base.Id), Ball.BallModelFileName(newId));
				if (FifaEnvironment.Year == 14)
				{
					FifaEnvironment.CloneIntoZdata(Ball.BallPictureBigFileName(base.Id), Ball.BallPictureBigFileName(newId));
				}
				else
				{
					FifaEnvironment.CloneIntoZdata(Ball.BallDdsFileName(base.Id), Ball.BallDdsFileName(newId));
				}
			}
			return ball;
		}

		// Token: 0x04000002 RID: 2
		private bool m_IsLicensed;

		// Token: 0x04000003 RID: 3
		private bool m_IsAvailable;

		// Token: 0x04000004 RID: 4
		private bool m_IsEmbargoed;

		// Token: 0x04000005 RID: 5
		private int m_powid;

		// Token: 0x04000006 RID: 6
		private string m_LanguageName;

		// Token: 0x04000007 RID: 7
		private bool m_IsGeneric;
	}
}
