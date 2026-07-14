using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000009 RID: 9
	public class NumberFont : IdObject
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00002DF9 File Offset: 0x00000FF9
		public NumberFont(int fontId)
			: base(fontId)
		{
			this.ComputeStyleAndColor(fontId);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002E09 File Offset: 0x00001009
		private void ComputeStyleAndColor(int fontId)
		{
			this.m_Style = fontId / NumberFont.s_MaxColors;
			this.m_Color = fontId - this.m_Style * NumberFont.s_MaxColors;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002E2C File Offset: 0x0000102C
		public override string ToString()
		{
			FifaUtil.PadBlanks(base.Id.ToString(), 3);
			string text = "Font n. " + this.m_Style + " ";
			switch (this.m_Color)
			{
			case 0:
				text += "Transparent";
				break;
			case 1:
				text += "White";
				break;
			case 2:
				text += "Black";
				break;
			case 3:
				text += "Blue";
				break;
			case 4:
				text += "Red";
				break;
			case 5:
				text += "Yellow";
				break;
			case 6:
				text += "Green";
				break;
			case 7:
				text += "Orange";
				break;
			case 8:
				text += "Violet";
				break;
			case 9:
				text += "Brown";
				break;
			case 10:
				text += "Pink";
				break;
			case 11:
				text += "Dark Red";
				break;
			case 12:
				text += "Cyano";
				break;
			case 13:
				text += "Dark Blue";
				break;
			case 14:
				text += "Gray";
				break;
			case 15:
				text += "Pale Green";
				break;
			case 16:
				text += "Dark Gold";
				break;
			case 17:
				text += "Gold";
				break;
			case 18:
				text += "Light Red";
				break;
			case 19:
				text += "Dark Green";
				break;
			default:
				text += this.m_Color.ToString();
				break;
			}
			return text;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000301A File Offset: 0x0000121A
		public static void Clone(int oldStyle, int oldColor, int newStyle, int newColor)
		{
			FifaEnvironment.CloneIntoZdata(NumberFont.NumberFontFileName(oldStyle, oldColor), NumberFont.NumberFontFileName(newStyle, newColor));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003030 File Offset: 0x00001230
		public static string NumberFontFileName(int styleId, int colorId)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/kitnumbers/kitnumbers_",
				styleId.ToString(),
				"_",
				colorId.ToString(),
				".rx3"
			});
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003069 File Offset: 0x00001269
		public string NumberFontFileName()
		{
			return NumberFont.NumberFontFileName(this.m_Style, this.m_Color);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000307C File Offset: 0x0000127C
		public static string NumberFontTemplateName()
		{
			return "data/sceneassets/kitnumbers/kitnumbers_#_%.rx3";
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003084 File Offset: 0x00001284
		public static Rx3Signatures NumberFontSignature(int id, int colorId)
		{
			string[] array = new string[10];
			for (int i = 0; i < 10; i++)
			{
				array[i] = string.Concat(new string[]
				{
					"numbers_",
					id.ToString(),
					"_",
					colorId.ToString(),
					"_",
					i.ToString()
				});
			}
			return new Rx3Signatures(439280, 24, array);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000030F7 File Offset: 0x000012F7
		public static Rx3File GetNumberFontRx3(int style, int color)
		{
			return FifaEnvironment.GetRx3FromZdata(NumberFont.NumberFontFileName(style, color));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003105 File Offset: 0x00001305
		public static Bitmap[] GetNumberFont(int style, int color)
		{
			return FifaEnvironment.GetBmpsFromRx3(NumberFont.NumberFontFileName(style, color));
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003114 File Offset: 0x00001314
		public static bool SetNumberFont(int style, int color, Bitmap[] bitmaps)
		{
			int[] array = new int[] { style, color };
			return FifaEnvironment.ImportBmpsIntoZdata(NumberFont.NumberFontTemplateName(), array, bitmaps, ECompressionMode.Chunkzip, NumberFont.NumberFontSignature(style, color));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003144 File Offset: 0x00001344
		public static bool SetNumberFont(int style, int color, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, NumberFont.NumberFontFileName(style, color), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003155 File Offset: 0x00001355
		public static bool Delete(int style, int color)
		{
			return FifaEnvironment.DeleteFromZdata(NumberFont.NumberFontFileName(style, color));
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003164 File Offset: 0x00001364
		public static bool Import(int style, int color, string rx3FileName)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip, NumberFont.NumberFontSignature(style, color));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003189 File Offset: 0x00001389
		public static bool Export(int style, int color, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(NumberFont.NumberFontFileName(style, color), exportDir);
		}

		// Token: 0x04000008 RID: 8
		private static int s_MaxColors = 20;

		// Token: 0x04000009 RID: 9
		private int m_Style;

		// Token: 0x0400000A RID: 10
		private int m_Color;
	}
}
