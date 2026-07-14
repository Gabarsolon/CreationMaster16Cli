using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000007 RID: 7
	public class Adboard : IdObject
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002B03 File Offset: 0x00000D03
		public Adboard(int adboardId)
			: base(adboardId)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002B0C File Offset: 0x00000D0C
		public override IdObject Clone(int newId)
		{
			Adboard adboard = (Adboard)base.Clone(newId);
			if (adboard != null)
			{
				FifaEnvironment.CloneIntoZdata(Adboard.AdboardFileName(base.Id), Adboard.AdboardFileName(newId));
			}
			return adboard;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002B34 File Offset: 0x00000D34
		public override string ToString()
		{
			string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
			return "Adboard n. " + text;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002B61 File Offset: 0x00000D61
		public static string AdboardFileName(int adboardid)
		{
			return "data/sceneassets/adboard/adboard_" + adboardid.ToString() + "_0.rx3";
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002B79 File Offset: 0x00000D79
		public static string RevModTeamAdboardFileName(int teamId)
		{
			return "data/sceneassets/adboard/specificadboard_" + teamId.ToString() + "_0_0_0.rx3";
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002B91 File Offset: 0x00000D91
		public static string RevModTornamentAdboardFileName(int tournamentAssetId)
		{
			return "data/sceneassets/adboard/specificadboard_0_" + tournamentAssetId.ToString() + "_0_0.rx3";
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002BAC File Offset: 0x00000DAC
		public static Bitmap GetAdboard(int adboardId)
		{
			string text = Adboard.AdboardFileName(adboardId);
			bool flag = adboardId <= 1000000;
			return FifaEnvironment.GetBmpFromRx3(text, flag);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public static Bitmap GetRevModTeamAdboard(int teamId)
		{
			return FifaEnvironment.GetBmpFromRx3(Adboard.RevModTeamAdboardFileName(teamId), false);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002BDF File Offset: 0x00000DDF
		public static bool SetRevModTeamAdboard(int teamId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/adboard/specificadboard_#_0_0_0.rx3", teamId, bitmap, ECompressionMode.None);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public static bool SetRevModTeamAdboard(int adboardId, string srcFileName)
		{
			string text = Adboard.RevModTeamAdboardFileName(adboardId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002C0D File Offset: 0x00000E0D
		public static bool SetRevModTournamentAdboard(int tournamentId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/adboard/specificadboard_0_#_0_0.rx3", tournamentId, bitmap, ECompressionMode.None);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002C1C File Offset: 0x00000E1C
		public static bool SetRevModTournamentAdboard(int adboardId, string srcFileName)
		{
			string text = Adboard.RevModTornamentAdboardFileName(adboardId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002C39 File Offset: 0x00000E39
		public static Bitmap GetRevModTournamentAdboard(int tournamentAssetId)
		{
			return FifaEnvironment.GetBmpFromRx3(Adboard.RevModTornamentAdboardFileName(tournamentAssetId), false);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002C47 File Offset: 0x00000E47
		public Bitmap GetAdboard()
		{
			return Adboard.GetAdboard(base.Id);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C54 File Offset: 0x00000E54
		public static bool SetAdboard(int adboardId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/adboard/adboard_#_0.rx3", adboardId, bitmap, ECompressionMode.Chunkref);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002C63 File Offset: 0x00000E63
		public bool SetAdboard(Bitmap bitmap)
		{
			return Adboard.SetAdboard(base.Id, bitmap);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002C74 File Offset: 0x00000E74
		public static bool SetAdboard(int adboardId, string srcFileName)
		{
			string text = Adboard.AdboardFileName(adboardId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002C91 File Offset: 0x00000E91
		public bool SetAdboard(string srcFileName)
		{
			return Adboard.SetAdboard(base.Id, srcFileName);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002C9F File Offset: 0x00000E9F
		public static bool DeleteAdboard(int adboardId)
		{
			return FifaEnvironment.DeleteFromZdata(Adboard.AdboardFileName(adboardId));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002CAC File Offset: 0x00000EAC
		public static bool DeleteRevModTeamAdboard(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Adboard.RevModTeamAdboardFileName(teamId));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002CB9 File Offset: 0x00000EB9
		public static bool DeleteRevModTournamentAdboard(int tournamentId)
		{
			return FifaEnvironment.DeleteFromZdata(Adboard.RevModTornamentAdboardFileName(tournamentId));
		}
	}
}
