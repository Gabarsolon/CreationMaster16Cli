using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200000D RID: 13
	public class Net : IdObject
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002B03 File Offset: 0x00000D03
		public Net(int netId)
			: base(netId)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000033C3 File Offset: 0x000015C3
		public override IdObject Clone(int newId)
		{
			Net net = (Net)base.Clone(newId);
			if (net != null)
			{
				FifaEnvironment.CloneIntoZdata(Net.NetFileName(base.Id), Net.NetFileName(newId));
			}
			return net;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000033EC File Offset: 0x000015EC
		public override string ToString()
		{
			string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
			return "Net n. " + text;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003419 File Offset: 0x00001619
		public static string NetFileName(int netid)
		{
			return "data/sceneassets/goalnet/netcolor_" + netid.ToString() + "_textures.rx3";
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003431 File Offset: 0x00001631
		public static string RevModNetFileName(int teamId)
		{
			return "data/sceneassets/goalnet/specificnetcolor_" + teamId.ToString() + "_0_textures.rx3";
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003449 File Offset: 0x00001649
		public static Bitmap GetNet(int netId)
		{
			return FifaEnvironment.GetBmpFromRx3(Net.NetFileName(netId), 0);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003457 File Offset: 0x00001657
		public static Bitmap GetRevModNet(int teamId)
		{
			return FifaEnvironment.GetBmpFromRx3(Net.RevModNetFileName(teamId), 0);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003465 File Offset: 0x00001665
		public static bool SetNet(int netId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/goalnet/netcolor_#_textures.rx3", netId, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003474 File Offset: 0x00001674
		public static bool SetRevModNet(int teamId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/goalnet/specificnetcolor_#_0_textures.rx3", teamId, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003484 File Offset: 0x00001684
		public static bool SetRevModNet(int netId, string srcFileName)
		{
			string text = Net.RevModNetFileName(netId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000034A4 File Offset: 0x000016A4
		public static bool SetNet(int netId, string srcFileName)
		{
			string text = Net.NetFileName(netId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000034C1 File Offset: 0x000016C1
		public static bool DeleteNet(int netId)
		{
			return FifaEnvironment.DeleteFromZdata(Net.NetFileName(netId));
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000034CE File Offset: 0x000016CE
		public static bool DeleteRevModNet(int teamId)
		{
			return FifaEnvironment.DeleteFromZdata(Net.RevModNetFileName(teamId));
		}
	}
}
