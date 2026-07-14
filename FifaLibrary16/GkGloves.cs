using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000002 RID: 2
	public class GkGloves : IdObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static Model3D GkGlovesModel
		{
			get
			{
				return GkGloves.s_GkGlovesModel;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public void Set3DModelTexture(Bitmap bitmaps)
		{
			if (GkGloves.s_GkGlovesModel != null)
			{
				GkGloves.s_GkGlovesModel.TextureBitmap = bitmaps;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		public GkGloves(int gkglovesId)
			: base(gkglovesId)
		{
			if (GkGloves.s_GkGlovesModel == null)
			{
				Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
				Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(GkGloves.GkGlovesModelFileName(1));
				GkGloves.s_GkGlovesModel = new Model3D(rx3FromZdata.Rx3IndexArrays[0], rx3FromZdata.Rx3VertexArrays[0], null);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020B4 File Offset: 0x000002B4
		public override string ToString()
		{
			return "GK Gloves n. " + base.Id.ToString();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020D9 File Offset: 0x000002D9
		public static string GkGlovesTextureFileName(int gkglovesId)
		{
			return "data/sceneassets/gkglove/gkglove_" + gkglovesId.ToString() + "_textures.rx3";
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020F1 File Offset: 0x000002F1
		public static Bitmap[] GetGkGlovesTextures(int gkglovesId)
		{
			return FifaEnvironment.GetBmpsFromRx3(GkGloves.GkGlovesTextureFileName(gkglovesId));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020FE File Offset: 0x000002FE
		public static string GkGloveTextureTemplateFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return "data\\sceneassets\\gkglove\\2014_gkglove_#_textures.rx3";
			}
			return "data\\sceneassets\\gkglove\\gkglove_#_textures.rx3";
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002114 File Offset: 0x00000314
		public static bool SetGkGlovesTextures(int gkglovesId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(GkGloves.GkGloveTextureTemplateFileName(), gkglovesId, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002124 File Offset: 0x00000324
		public static bool SetGkGlovesTextures(int gkglovesId, string rx3FileName)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002141 File Offset: 0x00000341
		public static bool ExportGkGlovesTextures(int gkglovesId, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(GkGloves.GkGlovesTextureFileName(gkglovesId), exportDir);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000214F File Offset: 0x0000034F
		public static bool DeleteGkGlovesTextures(int gkglovesId)
		{
			return FifaEnvironment.DeleteFromZdata(GkGloves.GkGlovesTextureFileName(gkglovesId));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000215C File Offset: 0x0000035C
		public static string GkGlovesModelFileName(int id)
		{
			return "data/sceneassets/gkglove/gkglove_" + id.ToString() + ".rx3";
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002174 File Offset: 0x00000374
		public static Rx3File GetGkGlovesModel(int gkglovesId)
		{
			return FifaEnvironment.GetRx3FromZdata(GkGloves.GkGlovesTextureFileName(gkglovesId));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002181 File Offset: 0x00000381
		public override IdObject Clone(int newId)
		{
			GkGloves gkGloves = (GkGloves)base.Clone(newId);
			if (gkGloves != null)
			{
				FifaEnvironment.CloneIntoZdata(GkGloves.GkGlovesTextureFileName(base.Id), GkGloves.GkGlovesTextureFileName(newId));
				FifaEnvironment.CloneIntoZdata(GkGloves.GkGlovesModelFileName(base.Id), GkGloves.GkGlovesModelFileName(newId));
			}
			return gkGloves;
		}

		// Token: 0x04000001 RID: 1
		private static Model3D s_GkGlovesModel;
	}
}
