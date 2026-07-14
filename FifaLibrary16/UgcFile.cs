using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x0200009E RID: 158
	public class UgcFile
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00053598 File Offset: 0x00051798
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000535A0 File Offset: 0x000517A0
		public UgcDirEntry[] UgcDir
		{
			get
			{
				return this.m_UgcDir;
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000535A8 File Offset: 0x000517A8
		public UgcFile(string fileName)
		{
			this.Load(fileName);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000535C0 File Offset: 0x000517C0
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			if (fileStream == null)
			{
				return false;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			this.m_BinaryReader = binaryReader;
			return binaryReader != null && this.Load(binaryReader);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000535F8 File Offset: 0x000517F8
		public bool Load(BinaryReader r)
		{
			r.BaseStream.Position = 0L;
			r.ReadBytes(56);
			this.m_NFiles = r.ReadInt32() + 1;
			this.m_UgcDir = new UgcDirEntry[this.m_NFiles];
			r.ReadInt32();
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_UgcDir[i] = new UgcDirEntry(r);
			}
			return true;
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00053664 File Offset: 0x00051864
		public bool Extract(int fileIndex, string outputFolder)
		{
			if (fileIndex < 0)
			{
				return false;
			}
			if (fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BinaryReader.BaseStream.Position = (long)((ulong)(this.m_UgcDir[fileIndex].Offset + 44U));
			if (this.m_UgcDir[fileIndex].FileName == null || this.m_UgcDir[fileIndex].FileName == string.Empty)
			{
				return false;
			}
			string text = outputFolder + "\\" + this.m_UgcDir[fileIndex].ToString();
			if (this.m_UgcDir[fileIndex].IsPng())
			{
				return this.ExtractPng(this.m_BinaryReader, text);
			}
			return this.ExtractDb(this.m_BinaryReader, text);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00053710 File Offset: 0x00051910
		public bool ExtractPng(BinaryReader r, string outputFileName)
		{
			byte[] array = new byte[8];
			int num = 0;
			array[0] = 73;
			array[1] = 69;
			array[2] = 78;
			array[3] = 68;
			array[4] = 174;
			array[5] = 66;
			array[6] = 96;
			array[7] = 130;
			FileStream fileStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write);
			if (fileStream == null)
			{
				return false;
			}
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (binaryWriter == null)
			{
				return false;
			}
			do
			{
				byte b = r.ReadByte();
				if (b == array[num])
				{
					num++;
				}
				else
				{
					num = 0;
				}
				binaryWriter.Write(b);
			}
			while (num != array.Length);
			fileStream.Close();
			binaryWriter.Close();
			return true;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000537A0 File Offset: 0x000519A0
		public bool ExtractDb(BinaryReader r, string outputFileName)
		{
			FileStream fileStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write);
			if (fileStream == null)
			{
				return false;
			}
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (binaryWriter == null)
			{
				return false;
			}
			binaryWriter.Write(r.ReadBytes(8));
			int num = r.ReadInt32();
			binaryWriter.Write(num);
			num -= 12;
			for (int i = 0; i < num; i++)
			{
				byte b = r.ReadByte();
				binaryWriter.Write(b);
			}
			fileStream.Close();
			binaryWriter.Close();
			return true;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00053810 File Offset: 0x00051A10
		public void ImportKitGraphics(string xmlFileName, ToolStripStatusLabel statusBar)
		{
			DbFile dbFile = new DbFile(FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString(), xmlFileName);
			Table table = dbFile.GetTable("teams");
			dbFile.GetTable("cz_leagues");
			Table table2 = dbFile.GetTable("cz_teamkits");
			Table table3 = dbFile.GetTable("cz_teams");
			Team[] array = new Team[table.NValidRecords];
			for (int i = 0; i < table.NValidRecords; i++)
			{
				Record record = table.Records[i];
				record.GetAndCheckIntField(FI.teams_assetid);
				int andCheckIntField = record.GetAndCheckIntField(FI.teams_teamid);
				Team team = FifaEnvironment.Teams.FitTeam(record.StringField[FI.teams_teamname], 0);
				if (team != null)
				{
					if (statusBar != null)
					{
						statusBar.Text = "Importing Team: " + team.DatabaseName;
						statusBar.Owner.Refresh();
					}
					array[i] = team;
					Bitmap bitmap = null;
					Bitmap bitmap2 = null;
					int j = 0;
					while (j < table3.NValidRecords)
					{
						Record record2 = table3.Records[j];
						if (record2.GetAndCheckIntField(FI.cz_teams_teamid) == andCheckIntField)
						{
							int andCheckIntField2 = record2.GetAndCheckIntField(FI.cz_teams_hascrestimage);
							int andCheckIntField3 = record2.GetAndCheckIntField(FI.cz_teams_hassponsorimage);
							string text = FifaEnvironment.TempFolder + "\\" + andCheckIntField2.ToString() + ".png";
							if (File.Exists(text))
							{
								bitmap = new Bitmap(text);
							}
							text = FifaEnvironment.TempFolder + "\\" + andCheckIntField3.ToString() + ".png";
							if (File.Exists(text))
							{
								bitmap2 = new Bitmap(text);
								break;
							}
							break;
						}
						else
						{
							j++;
						}
					}
					int assetid = array[i].assetid;
					for (int k = 0; k < table2.NValidRecords; k++)
					{
						Record record3 = table2.Records[k];
						int andCheckIntField4 = record3.GetAndCheckIntField(FI.cz_teamkits_kitid);
						int andCheckIntField5 = record3.GetAndCheckIntField(FI.cz_teamkits_teamid);
						int andCheckIntField6 = record3.GetAndCheckIntField(FI.cz_teamkits_kittypeid);
						string text2 = Kit.KitTextureFileName(andCheckIntField4, 0, 0);
						if (andCheckIntField == andCheckIntField5)
						{
							Kit kit = FifaEnvironment.Kits.GetKit(team.Id, andCheckIntField6);
							if (kit == null)
							{
								kit = new Kit(FifaEnvironment.Kits.GetNewId(), team.Id, andCheckIntField6);
								FifaEnvironment.Kits.Add(kit);
								kit.LinkTeam(FifaEnvironment.Teams);
							}
							kit.jerseyBackName = record3.IntField[FI.cz_teamkits_jerseybacknameplacementcode] != 0;
							kit.jerseyNameFontCase = record3.IntField[FI.cz_teamkits_jerseybacknamefontcase];
							kit.jerseyNameFont = record3.IntField[FI.cz_teamkits_jerseynamefonttype];
							int num = record3.IntField[FI.cz_teamkits_jerseynamecolorr];
							int num2 = record3.IntField[FI.cz_teamkits_jerseynamecolorg];
							int num3 = record3.IntField[FI.cz_teamkits_jerseynamecolorb];
							kit.JerseyNameColor = Color.FromArgb(255, num, num2, num3);
							kit.jerseyNameLayout = record3.IntField[FI.cz_teamkits_jerseynamelayouttype];
							kit.jerseyNumberFont = record3.IntField[FI.cz_teamkits_numberfonttype];
							kit.jerseyNumberColor = record3.IntField[FI.cz_teamkits_numbercolor];
							kit.shortsNumberColor = record3.IntField[FI.cz_teamkits_shortsnumbercolor];
							kit.shortsNumberFont = record3.IntField[FI.cz_teamkits_shortsnumberfonttype];
							kit.shortsNumber = true;
							kit.jerseyCollar = 0;
							num = record3.IntField[FI.cz_teamkits_jerseycolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolorprimb];
							Color color = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_jerseycolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolorsecb];
							Color color2 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_jerseycolortertr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolortertg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolortertb];
							Color color3 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolorprimb];
							Color color4 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolorsecb];
							Color color5 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolortertr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolortertg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolortertb];
							Color color6 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolorprimb];
							Color color7 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolorsecb];
							Color color8 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolortertr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolortertg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolortertb];
							Color color9 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sponsorcolourr];
							num2 = record3.IntField[FI.cz_teamkits_sponsorcolourg];
							num3 = record3.IntField[FI.cz_teamkits_sponsorcolourb];
							Color color10 = Color.FromArgb(255, num, num2, num3);
							float num4 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorl];
							float num5 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorr];
							float num6 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsort];
							float num7 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorb];
							Kit.KitTextureFileName(team.Id, andCheckIntField6, 0);
							Kit kit2 = FifaEnvironment.Kits.GetKit(andCheckIntField4, 0);
							if (kit2 != null)
							{
								kit.jerseyCollar = kit2.jerseyCollar;
							}
							if (kit2 != null)
							{
								Bitmap miniKit = kit2.GetMiniKit(0);
								string text3 = FifaEnvironment.TempFolder + "\\" + text2;
								FifaEnvironment.ExportFileFromZdata(text2, FifaEnvironment.TempFolder);
								kit.ImportKitTextures(text3);
								Bitmap[] kitTextures = kit.GetKitTextures();
								if (bitmap != null)
								{
									kitTextures[0] = (Bitmap)bitmap.Clone();
								}
								else
								{
									kitTextures[0] = null;
								}
								GraphicUtil.ColorizeRGB(kitTextures[1], color, color2, color3, 0, 1024);
								if (miniKit != null)
								{
									GraphicUtil.PrepareToColorize(miniKit, 25, 231);
									GraphicUtil.ColorizeRGB(miniKit, color, color2, color3, 25, 231);
								}
								if (bitmap2 != null && kitTextures[1] != null)
								{
									Bitmap bitmap3;
									if (color10.R != 225 || color10.G != 225 || color10.B != 225)
									{
										bitmap3 = GraphicUtil.ColorizeWhite(bitmap2, color10);
									}
									else
									{
										bitmap3 = bitmap2;
									}
									int num8 = (int)((double)num4 * 1024.0);
									int num9 = (int)((double)num6 * 1024.0);
									int num10 = (int)((double)num5 * 1024.0) - num8;
									int num11 = (int)((double)num7 * 1024.0) - num9;
									Rectangle rectangle = new Rectangle(num8, num9, num10, num11);
									kitTextures[1] = GraphicUtil.Overlap(kitTextures[1], bitmap3, rectangle);
								}
								GraphicUtil.ColorizeRGB(kitTextures[3], color7, color8, color9, 0, 194);
								GraphicUtil.ColorizeRGB(kitTextures[3], color4, color5, color6, 194, 512);
								kit.SetKitTextures(kitTextures);
								if (miniKit != null)
								{
									kit.SetMiniKit(miniKit);
								}
							}
						}
					}
				}
			}
			if (statusBar != null)
			{
				statusBar.Text = "Importing complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00054008 File Offset: 0x00052208
		public void Import(string xmlFileName, bool useGraphics, ToolStripStatusLabel statusBar)
		{
			DbFile dbFile = new DbFile(FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString(), xmlFileName);
			Table table = dbFile.GetTable("leagueteamlinks");
			Table table2 = dbFile.GetTable("leagues");
			Table table3 = dbFile.GetTable("stadiumassignments");
			Table table4 = dbFile.GetTable("teamstadiumlinks");
			Table table5 = dbFile.GetTable("teamplayerlinks");
			Table table6 = dbFile.GetTable("formations");
			Table table7 = dbFile.GetTable("teams");
			Table table8 = dbFile.GetTable("editedplayernames");
			Table table9 = dbFile.GetTable("players");
			dbFile.GetTable("cz_leagues");
			Table table10 = dbFile.GetTable("cz_teamkits");
			Table table11 = dbFile.GetTable("cz_teams");
			Table table12 = dbFile.GetTable("cz_players");
			Table table13 = dbFile.GetTable("cz_assets");
			League[] array = new League[table2.NValidRecords];
			Team[] array2 = new Team[table7.NValidRecords];
			Player[] array3 = new Player[table9.NValidRecords];
			if (statusBar != null)
			{
				statusBar.Text = "Importing ...";
				statusBar.Owner.Refresh();
			}
			int[] array4 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				array4[i] = 0;
			}
			for (int j = 0; j < table9.NValidRecords; j++)
			{
				Record record = table9.Records[j];
				array4[record.IntField[FI.players_nationality]]++;
			}
			int num = 0;
			int num2 = 216;
			for (int k = 0; k < 256; k++)
			{
				if (array4[k] > num)
				{
					num = array4[k];
					num2 = k;
				}
			}
			Country country = FifaEnvironment.Countries.SearchCountry(num2);
			int num3 = 400;
			for (int l = 0; l < table2.NValidRecords; l++)
			{
				League league = FifaEnvironment.Leagues.FitLeague(table2.Records[l].StringField[FI.leagues_leaguename], 0);
				int andCheckIntField = table2.Records[l].GetAndCheckIntField(FI.leagues_leagueid);
				if (league != null && country.Id != 216 && league.Country != country)
				{
					league = null;
				}
				bool flag;
				if (league == null)
				{
					num3 = FifaEnvironment.Leagues.GetNextId(num3);
					league = new League(table2.Records[l]);
					flag = false;
				}
				else
				{
					league.RemoveAllTeams();
					flag = true;
					array[andCheckIntField - 385] = league;
				}
				if (league.Id >= 385 && league.Id <= 389)
				{
					array[league.Id - 385] = league;
					league.Id = num3;
					if (league.leaguename.Length > 15)
					{
						League league2 = league;
						league2.ShortName = league2.leaguename.Substring(0, 15);
					}
					else
					{
						League league3 = league;
						league3.ShortName = league3.leaguename;
					}
					League league4 = league;
					league4.LongName = league4.leaguename;
					league.Country = country;
					if (!flag)
					{
						FifaEnvironment.Leagues.InsertId(league);
					}
					if (useGraphics)
					{
						for (int m = 0; m < table13.NValidRecords; m++)
						{
							Record record2 = table13.Records[m];
							if (record2.GetAndCheckIntField(FI.cz_assets_dbid) == 385 + l)
							{
								int andCheckIntField2 = record2.GetAndCheckIntField(FI.cz_assets_crestid);
								string text = FifaEnvironment.TempFolder + "\\" + andCheckIntField2.ToString() + ".png";
								if (File.Exists(text))
								{
									Bitmap bitmap = new Bitmap(text);
									Bitmap bitmap2 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
									Bitmap bitmap3 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
									Bitmap bitmap4 = new Bitmap(256, 64, PixelFormat.Format32bppPArgb);
									Rectangle rectangle = new Rectangle(0, 0, 128, 128);
									Rectangle rectangle2 = new Rectangle(32, 32, 192, 192);
									Rectangle rectangle3 = new Rectangle(25, 0, 150, 150);
									Rectangle rectangle4 = new Rectangle(145, 4, 56, 56);
									GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap2, rectangle2);
									GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap3, rectangle3);
									GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap4, rectangle4);
									array[l].SetAnimLogo(bitmap2);
									array[l].SetAnimLogoDark(bitmap2);
									array[l].SetSmallLogo(bitmap3);
									array[l].SetSmallLogoDark(bitmap3);
									array[l].SetTinyLogo(bitmap4);
									array[l].SetTinyLogoDark(bitmap4);
									break;
								}
							}
						}
					}
				}
			}
			int num4 = 130020;
			for (int n = 0; n < table7.NValidRecords; n++)
			{
				Record record3 = table7.Records[n];
				int num5 = record3.GetAndCheckIntField(FI.teams_assetid);
				int andCheckIntField3 = record3.GetAndCheckIntField(FI.teams_teamid);
				Team team = null;
				bool flag2 = false;
				if (num5 != 33554432)
				{
					team = (Team)FifaEnvironment.Teams.SearchId(num5);
					if (team != null)
					{
						team.Roster.ResetToEmpty();
						flag2 = true;
					}
				}
				if (team == null)
				{
					team = FifaEnvironment.Teams.FitTeam(record3.StringField[FI.teams_teamname], 0);
					if (team != null && country.Id != 216 && team.Country != country)
					{
						team = null;
					}
					if (team != null)
					{
						team.Roster.ResetToEmpty();
					}
					flag2 = team != null;
				}
				if (team == null)
				{
					num4 = FifaEnvironment.Teams.GetNextId(num4);
					team = new Team(table7.Records[n]);
					team.Id = num4;
					team.Country = country;
					FifaEnvironment.Teams.InsertId(team);
				}
				if (statusBar != null)
				{
					statusBar.Text = "Importing Team: " + team.DatabaseName;
					statusBar.Owner.Refresh();
				}
				array2[n] = team;
				team.assetid = andCheckIntField3;
				Team team2 = team;
				team2.TeamNameFull = team2.DatabaseName;
				if (team.DatabaseName.Length > 15)
				{
					Team team3 = team;
					team3.TeamNameAbbr15 = team3.DatabaseName.Substring(0, 15);
				}
				else
				{
					Team team4 = team;
					team4.TeamNameAbbr15 = team4.DatabaseName;
				}
				if (team.DatabaseName.Length > 10)
				{
					Team team5 = team;
					team5.TeamNameAbbr10 = team5.DatabaseName.Substring(0, 10);
				}
				else
				{
					Team team6 = team;
					team6.TeamNameAbbr10 = team6.DatabaseName;
				}
				if (!flag2)
				{
					num5 = array2[n].assetid;
					Bitmap bitmap5 = null;
					Bitmap bitmap6 = null;
					if (useGraphics)
					{
						int num6 = 0;
						while (num6 < table11.NValidRecords)
						{
							Record record4 = table11.Records[num6];
							if (record4.GetAndCheckIntField(FI.cz_teams_teamid) == num5)
							{
								int andCheckIntField4 = record4.GetAndCheckIntField(FI.cz_teams_hascrestimage);
								int andCheckIntField5 = record4.GetAndCheckIntField(FI.cz_teams_hassponsorimage);
								string text2 = FifaEnvironment.TempFolder + "\\" + andCheckIntField4.ToString() + ".png";
								if (File.Exists(text2))
								{
									bitmap5 = new Bitmap(text2);
									Rectangle rectangle5 = new Rectangle(0, 0, 128, 128);
									Bitmap bitmap7 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
									Bitmap bitmap8 = new Bitmap(128, 128, PixelFormat.Format32bppPArgb);
									Bitmap bitmap9 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
									Bitmap bitmap10 = new Bitmap(64, 64, PixelFormat.Format32bppPArgb);
									Bitmap bitmap11 = new Bitmap(32, 32, PixelFormat.Format32bppPArgb);
									Bitmap bitmap12 = new Bitmap(16, 16, PixelFormat.Format32bppPArgb);
									Rectangle rectangle6 = new Rectangle(0, 0, 150, 150);
									Rectangle rectangle7 = new Rectangle(0, 0, 102, 102);
									Rectangle rectangle8 = new Rectangle(0, 0, 256, 256);
									Rectangle rectangle9 = new Rectangle(0, 0, 50, 50);
									Rectangle rectangle10 = new Rectangle(0, 0, 32, 32);
									Rectangle rectangle11 = new Rectangle(0, 0, 16, 16);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap7, rectangle6);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap8, rectangle7);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap9, rectangle8);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap10, rectangle9);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap11, rectangle10);
									GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap12, rectangle11);
									array2[n].SetCrest(bitmap9);
									array2[n].SetCrest16(bitmap12);
									array2[n].SetCrest32(bitmap11);
									array2[n].SetCrest50(bitmap10);
									array2[n].SetCrestDark(bitmap9);
									array2[n].SetCrest16Dark(bitmap12);
									array2[n].SetCrest32Dark(bitmap11);
									array2[n].SetCrest50Dark(bitmap10);
								}
								text2 = FifaEnvironment.TempFolder + "\\" + andCheckIntField5.ToString() + ".png";
								if (File.Exists(text2))
								{
									bitmap6 = new Bitmap(text2);
									break;
								}
								break;
							}
							else
							{
								num6++;
							}
						}
					}
					for (int num7 = 0; num7 < table10.NValidRecords; num7++)
					{
						Record record5 = table10.Records[num7];
						int andCheckIntField6 = record5.GetAndCheckIntField(FI.cz_teamkits_kitid);
						int andCheckIntField7 = record5.GetAndCheckIntField(FI.cz_teamkits_teamid);
						int andCheckIntField8 = record5.GetAndCheckIntField(FI.cz_teamkits_kittypeid);
						string text3 = Kit.KitTextureFileName(andCheckIntField6, 0, 0);
						if (team.assetid == andCheckIntField7)
						{
							Kit kit = new Kit(FifaEnvironment.Kits.GetNewId(), team.Id, andCheckIntField8);
							FifaEnvironment.Kits.Add(kit);
							kit.LinkTeam(FifaEnvironment.Teams);
							kit.jerseyBackName = record5.IntField[FI.cz_teamkits_jerseybacknameplacementcode] != 0;
							kit.jerseyNameFontCase = record5.IntField[FI.cz_teamkits_jerseybacknamefontcase];
							kit.jerseyNameFont = record5.IntField[FI.cz_teamkits_jerseynamefonttype];
							int num8 = record5.IntField[FI.cz_teamkits_jerseynamecolorr];
							int num9 = record5.IntField[FI.cz_teamkits_jerseynamecolorg];
							int num10 = record5.IntField[FI.cz_teamkits_jerseynamecolorb];
							kit.JerseyNameColor = Color.FromArgb(255, num8, num9, num10);
							kit.jerseyNameLayout = record5.IntField[FI.cz_teamkits_jerseynamelayouttype];
							kit.jerseyNumberFont = record5.IntField[FI.cz_teamkits_numberfonttype];
							kit.jerseyNumberColor = record5.IntField[FI.cz_teamkits_numbercolor];
							kit.shortsNumberColor = record5.IntField[FI.cz_teamkits_shortsnumbercolor];
							kit.shortsNumberFont = record5.IntField[FI.cz_teamkits_shortsnumberfonttype];
							kit.shortsNumber = true;
							kit.jerseyCollar = 0;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolorprimb];
							Color color = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor1 = color;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolorsecb];
							Color color2 = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor2 = color2;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolortertr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolortertg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolortertb];
							Color color3 = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor3 = color3;
							num8 = record5.IntField[FI.cz_teamkits_shortcolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolorprimb];
							Color color4 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_shortcolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolorsecb];
							Color color5 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_shortcolortertr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolortertg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolortertb];
							Color color6 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolorprimb];
							Color color7 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolorsecb];
							Color color8 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolortertr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolortertg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolortertb];
							Color color9 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sponsorcolourr];
							num9 = record5.IntField[FI.cz_teamkits_sponsorcolourg];
							num10 = record5.IntField[FI.cz_teamkits_sponsorcolourb];
							Color color10 = Color.FromArgb(255, num8, num9, num10);
							float num11 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorl];
							float num12 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorr];
							float num13 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsort];
							float num14 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorb];
							Kit.KitTextureFileName(team.Id, andCheckIntField8, 0);
							Kit kit2 = FifaEnvironment.Kits.GetKit(andCheckIntField6, 0);
							if (kit2 != null)
							{
								kit.jerseyCollar = kit2.jerseyCollar;
							}
							if (useGraphics && kit2 != null)
							{
								Bitmap miniKit = kit2.GetMiniKit(0);
								string text4 = FifaEnvironment.TempFolder + "\\" + text3;
								FifaEnvironment.ExportFileFromZdata(text3, FifaEnvironment.TempFolder);
								kit.ImportKitTextures(text4);
								Bitmap[] kitTextures = kit.GetKitTextures();
								if (bitmap5 != null)
								{
									kitTextures[0] = (Bitmap)bitmap5.Clone();
								}
								else
								{
									kitTextures[0] = null;
								}
								GraphicUtil.ColorizeRGB(kitTextures[1], color, color2, color3, 0, 1024);
								if (miniKit != null)
								{
									GraphicUtil.PrepareToColorize(miniKit, 25, 231);
									GraphicUtil.ColorizeRGB(miniKit, color, color2, color3, 25, 231);
								}
								if (bitmap6 != null && kitTextures[1] != null)
								{
									Bitmap bitmap13;
									if (color10.R != 225 || color10.G != 225 || color10.B != 225)
									{
										bitmap13 = GraphicUtil.ColorizeWhite(bitmap6, color10);
									}
									else
									{
										bitmap13 = bitmap6;
									}
									int num15 = (int)((double)num11 * 1024.0);
									int num16 = (int)((double)num13 * 1024.0);
									int num17 = (int)((double)num12 * 1024.0) - num15;
									int num18 = (int)((double)num14 * 1024.0) - num16;
									Rectangle rectangle12 = new Rectangle(num15, num16, num17, num18);
									kitTextures[1] = GraphicUtil.Overlap(kitTextures[1], bitmap13, rectangle12);
								}
								GraphicUtil.ColorizeRGB(kitTextures[3], color7, color8, color9, 0, 194);
								GraphicUtil.ColorizeRGB(kitTextures[3], color4, color5, color6, 194, 512);
								kit.SetKitTextures(kitTextures);
								if (miniKit != null)
								{
									kit.SetMiniKit(miniKit);
								}
							}
						}
					}
				}
			}
			for (int num19 = 0; num19 < array2.Length; num19++)
			{
				for (int num20 = 0; num20 < array2.Length; num20++)
				{
					if (array2[num19].rivalteam == array2[num20].assetid)
					{
						array2[num19].RivalTeam = array2[num20];
						break;
					}
				}
				if (array2[num19].RivalTeam == null)
				{
					array2[num19].RivalTeam = (Team)FifaEnvironment.Teams.SearchId(array2[num19].rivalteam);
				}
				if (array2[num19].RivalTeam == null)
				{
					array2[num19].RivalTeam = array2[0];
				}
			}
			for (int num21 = 0; num21 < table3.NValidRecords; num21++)
			{
				Record record6 = table3.Records[num21];
				int andCheckIntField9 = record6.GetAndCheckIntField(FI.stadiumassignments_teamid);
				for (int num22 = 0; num22 < array2.Length; num22++)
				{
					if (array2[num22].assetid == andCheckIntField9)
					{
						array2[num22].stadiumcustomname = record6.GetAndCheckStringField(FI.stadiumassignments_stadiumcustomname);
						break;
					}
				}
			}
			for (int num23 = 0; num23 < table4.NValidRecords; num23++)
			{
				Record record7 = table4.Records[num23];
				int andCheckIntField10 = record7.GetAndCheckIntField(FI.teamstadiumlinks_teamid);
				for (int num24 = 0; num24 < array2.Length; num24++)
				{
					if (array2[num24].assetid == andCheckIntField10)
					{
						array2[num24].stadiumid = record7.GetAndCheckIntField(FI.teamstadiumlinks_stadiumid);
						array2[num24].LinkStadium(FifaEnvironment.Stadiums);
						break;
					}
				}
			}
			for (int num25 = 0; num25 < table11.NValidRecords; num25++)
			{
				Record record8 = table11.Records[num25];
				int andCheckIntField11 = record8.GetAndCheckIntField(FI.cz_teams_teamid);
				for (int num26 = 0; num26 < array2.Length; num26++)
				{
					if (array2[num26].assetid == andCheckIntField11)
					{
						array2[num26].TeamNameAbbr3 = record8.GetAndCheckStringField(FI.cz_teams_teamabbrev3);
						break;
					}
				}
			}
			for (int num27 = 0; num27 < table6.NValidRecords; num27++)
			{
				Record record9 = table6.Records[num27];
				Formation formation = new Formation(record9);
				Formation formation2 = FifaEnvironment.GenericFormations.GetExactFormation(formation);
				if (formation2 == null)
				{
					int newId = FifaEnvironment.Formations.GetNewId();
					formation.Id = newId;
					formation.teamid = -1;
					FifaEnvironment.Formations.InsertId(formation);
					FifaEnvironment.GenericFormations.InsertId(formation);
					formation2 = formation;
				}
				int andCheckIntField12 = record9.GetAndCheckIntField(FI.formations_teamid);
				for (int num28 = 0; num28 < array2.Length; num28++)
				{
					if (array2[num28].assetid == andCheckIntField12)
					{
						array2[num28].Formation = formation2;
						array2[num28].formationid = formation2.Id;
						break;
					}
				}
			}
			statusBar.Text = "Importing Players ...";
			int num29 = 230000;
			for (int num30 = 0; num30 < table9.NValidRecords; num30++)
			{
				Record record10 = table9.Records[num30];
				int andCheckIntField13 = record10.GetAndCheckIntField(FI.players_playerid);
				int num31 = 0;
				for (int num32 = 0; num32 < table12.NValidRecords; num32++)
				{
					Record record11 = table12.Records[num32];
					if (record11.GetAndCheckIntField(FI.cz_players_playerid) == andCheckIntField13)
					{
						num31 = record11.GetAndCheckIntField(FI.cz_players_assetid);
						break;
					}
				}
				Player player = null;
				bool flag3 = false;
				if (num31 != 0)
				{
					player = (Player)FifaEnvironment.Players.SearchId(num31);
					if (player != null)
					{
						flag3 = true;
					}
				}
				if (player == null)
				{
					DateTime dateTime = FifaUtil.ConvertToDate(record10.GetAndCheckIntField(FI.players_birthdate));
					string text5 = null;
					string text6 = null;
					string text7 = null;
					string text8 = null;
					int num33 = 0;
					while (num33 < table8.NValidRecords)
					{
						Record record12 = table8.Records[num33];
						if (record12.IntField[FI.editedplayernames_playerid] == andCheckIntField13)
						{
							text5 = record12.GetAndCheckStringField(FI.editedplayernames_firstname);
							text6 = record12.GetAndCheckStringField(FI.editedplayernames_surname);
							text7 = record12.GetAndCheckStringField(FI.editedplayernames_commonname);
							if (text7.Contains(text6))
							{
								text7 = null;
							}
							text8 = record12.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
							if (text8 != text6 && text8.Contains(text6))
							{
								text8 = text6;
								break;
							}
							break;
						}
						else
						{
							num33++;
						}
					}
					player = FifaEnvironment.Players.FitPlayer(text5, text6, dateTime);
					if (player == null)
					{
						if (num31 != 0)
						{
							player = new Player(table9.Records[num30]);
							player.Id = num31;
						}
						else
						{
							num29 = FifaEnvironment.Players.GetNextId(num29);
							player = new Player(table9.Records[num30]);
							player.Id = num29;
						}
						player.firstname = text5;
						player.lastname = text6;
						player.commonname = text7;
						player.playerjerseyname = text8;
						FifaEnvironment.Players.InsertId(player);
						player.LinkCountry(FifaEnvironment.Countries);
					}
				}
				if (flag3)
				{
					foreach (object obj in player.m_PlayingForTeams)
					{
						Team team7 = (Team)obj;
						if (team7.Id == 111592)
						{
							player.NotPlayFor(team7);
							break;
						}
					}
				}
				array3[num30] = player;
				player.m_assetid = andCheckIntField13;
			}
			for (int num34 = 0; num34 < table.NValidRecords; num34++)
			{
				Record record13 = table.Records[num34];
				int andCheckIntField14 = record13.GetAndCheckIntField(FI.leagueteamlinks_leagueid);
				int andCheckIntField15 = record13.GetAndCheckIntField(FI.leagueteamlinks_teamid);
				League league5 = null;
				if (andCheckIntField14 == 384)
				{
					league5 = League.GetDefaultLeague();
				}
				else if (andCheckIntField14 >= 385 && andCheckIntField14 <= 389)
				{
					league5 = array[andCheckIntField14 - 385];
				}
				if (league5 != null)
				{
					for (int num35 = 0; num35 < array2.Length; num35++)
					{
						if (array2[num35].assetid == andCheckIntField15)
						{
							league5.AddTeam(array2[num35]);
							break;
						}
					}
				}
			}
			for (int num36 = 0; num36 < table5.NValidRecords; num36++)
			{
				Record record14 = table5.Records[num36];
				int andCheckIntField16 = record14.GetAndCheckIntField(FI.teamplayerlinks_playerid);
				int andCheckIntField17 = record14.GetAndCheckIntField(FI.teamplayerlinks_teamid);
				for (int num37 = 0; num37 < array3.Length; num37++)
				{
					if (array3[num37].m_assetid == andCheckIntField16)
					{
						int num38 = 0;
						while (num38 < array2.Length)
						{
							if (array2[num38].assetid == andCheckIntField17)
							{
								array3[num37].PlayFor(array2[num38]);
								TeamPlayer teamPlayer = new TeamPlayer(record14, array3[num37], array2[num38]);
								array2[num38].Roster.Add(teamPlayer);
								if (array2[num38].captainid == array3[num37].m_assetid)
								{
									array2[num38].PlayerCaptain = array3[num37];
									array2[num38].captainid = array3[num37].Id;
								}
								if (array2[num38].freekicktakerid == array3[num37].m_assetid)
								{
									array2[num38].PlayerFreeKick = array3[num37];
									array2[num38].freekicktakerid = array3[num37].Id;
								}
								if (array2[num38].leftcornerkicktakerid == array3[num37].m_assetid)
								{
									array2[num38].PlayerLeftCorner = array3[num37];
									array2[num38].leftcornerkicktakerid = array3[num37].Id;
								}
								if (array2[num38].longkicktakerid == array3[num37].m_assetid)
								{
									array2[num38].PlayerLongKick = array3[num37];
									array2[num38].longkicktakerid = array3[num37].Id;
								}
								if (array2[num38].penaltytakerid == array3[num37].m_assetid)
								{
									array2[num38].PlayerPenalty = array3[num37];
									array2[num38].penaltytakerid = array3[num37].Id;
								}
								if (array2[num38].rightcornerkicktakerid == array3[num37].m_assetid)
								{
									array2[num38].PlayerRightCorner = array3[num37];
									array2[num38].rightcornerkicktakerid = array3[num37].Id;
									break;
								}
								break;
							}
							else
							{
								num38++;
							}
						}
						break;
					}
				}
			}
			for (int num39 = 0; num39 < array3.Length; num39++)
			{
				array3[num39].m_assetid = array3[num39].Id;
			}
			for (int num40 = 0; num40 < array2.Length; num40++)
			{
				array2[num40].assetid = array2[num40].Id;
			}
			if (statusBar != null)
			{
				statusBar.Text = "Importing complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00055764 File Offset: 0x00053964
		public void ImportPlayers(string xmlFileName, bool useGraphics, ToolStripStatusLabel statusBar)
		{
			DbFile dbFile = new DbFile(FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString(), xmlFileName);
			Table table = dbFile.GetTable("editedplayernames");
			Table table2 = dbFile.GetTable("players");
			Table table3 = dbFile.GetTable("cz_players");
			dbFile.GetTable("cz_assets");
			Player[] array = new Player[table2.NValidRecords];
			if (statusBar != null)
			{
				statusBar.Text = "Importing ...";
				statusBar.Owner.Refresh();
			}
			int[] array2 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				array2[i] = 0;
			}
			for (int j = 0; j < table2.NValidRecords; j++)
			{
				Record record = table2.Records[j];
				array2[record.IntField[FI.players_nationality]]++;
			}
			int num = 0;
			int num2 = 216;
			for (int k = 0; k < 256; k++)
			{
				if (array2[k] > num)
				{
					num = array2[k];
					num2 = k;
				}
			}
			FifaEnvironment.Countries.SearchCountry(num2);
			statusBar.Text = "Importing Players ...";
			int num3 = 230000;
			for (int l = 0; l < table2.NValidRecords; l++)
			{
				Record record2 = table2.Records[l];
				int andCheckIntField = record2.GetAndCheckIntField(FI.players_playerid);
				int num4 = 0;
				for (int m = 0; m < table3.NValidRecords; m++)
				{
					Record record3 = table3.Records[m];
					if (record3.GetAndCheckIntField(FI.cz_players_playerid) == andCheckIntField)
					{
						num4 = record3.GetAndCheckIntField(FI.cz_players_assetid);
						break;
					}
				}
				Player player = null;
				if (num4 != 0)
				{
					player = (Player)FifaEnvironment.Players.SearchId(num4);
				}
				if (player == null)
				{
					DateTime dateTime = FifaUtil.ConvertToDate(record2.GetAndCheckIntField(FI.players_birthdate));
					string text = null;
					string text2 = null;
					string text3 = null;
					string text4 = null;
					int n = 0;
					while (n < table.NValidRecords)
					{
						Record record4 = table.Records[n];
						if (record4.IntField[FI.editedplayernames_playerid] == andCheckIntField)
						{
							text = record4.GetAndCheckStringField(FI.editedplayernames_firstname);
							text2 = record4.GetAndCheckStringField(FI.editedplayernames_surname);
							text3 = record4.GetAndCheckStringField(FI.editedplayernames_commonname);
							if (text3.Contains(text2))
							{
								text3 = null;
							}
							text4 = record4.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
							if (text4 != text2 && text4.Contains(text2))
							{
								text4 = text2;
								break;
							}
							break;
						}
						else
						{
							n++;
						}
					}
					player = FifaEnvironment.Players.FitPlayer(text, text2, dateTime);
					if (player == null)
					{
						if (num4 != 0)
						{
							player = new Player(table2.Records[l]);
							player.Id = num4;
						}
						else
						{
							num3 = FifaEnvironment.Players.GetNextId(num3);
							player = new Player(table2.Records[l]);
							player.Id = num3;
						}
						player.firstname = text;
						player.lastname = text2;
						player.commonname = text3;
						player.playerjerseyname = text4;
						FifaEnvironment.Players.InsertId(player);
						player.LinkCountry(FifaEnvironment.Countries);
					}
				}
				array[l] = player;
				player.m_assetid = andCheckIntField;
			}
			for (int num5 = 0; num5 < array.Length; num5++)
			{
				array[num5].m_assetid = array[num5].Id;
			}
			if (statusBar != null)
			{
				statusBar.Text = "Importing complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00055AD4 File Offset: 0x00053CD4
		public void UpdateRosters(string xmlFileName, bool useKitGraphics, ToolStripStatusLabel statusBar)
		{
			DbFile dbFile = new DbFile(FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString(), xmlFileName);
			dbFile.GetTable("leagueteamlinks");
			Table table = dbFile.GetTable("leagues");
			dbFile.GetTable("stadiumassignments");
			dbFile.GetTable("teamstadiumlinks");
			Table table2 = dbFile.GetTable("teamplayerlinks");
			Table table3 = dbFile.GetTable("formations");
			Table table4 = dbFile.GetTable("teams");
			Table table5 = dbFile.GetTable("editedplayernames");
			Table table6 = dbFile.GetTable("players");
			dbFile.GetTable("cz_leagues");
			dbFile.GetTable("cz_teamkits");
			dbFile.GetTable("cz_teams");
			Table table7 = dbFile.GetTable("cz_players");
			dbFile.GetTable("cz_assets");
			Team[] array = new Team[table4.NValidRecords];
			Player[] array2 = new Player[table6.NValidRecords];
			if (statusBar != null)
			{
				statusBar.Text = "Updating ...";
				statusBar.Owner.Refresh();
			}
			int[] array3 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				array3[i] = 0;
			}
			for (int j = 0; j < table6.NValidRecords; j++)
			{
				Record record = table6.Records[j];
				array3[record.IntField[FI.players_nationality]]++;
			}
			int num = 0;
			int num2 = 216;
			for (int k = 0; k < 256; k++)
			{
				if (array3[k] > num)
				{
					num = array3[k];
					num2 = k;
				}
			}
			Country country = FifaEnvironment.Countries.SearchCountry(num2);
			int num3 = 0;
			for (int l = 0; l < table4.NValidRecords; l++)
			{
				Record record2 = table4.Records[l];
				int andCheckIntField = record2.GetAndCheckIntField(FI.teams_assetid);
				int andCheckIntField2 = record2.GetAndCheckIntField(FI.teams_teamid);
				Team team = null;
				if (andCheckIntField != 33554432)
				{
					team = (Team)FifaEnvironment.Teams.SearchId(andCheckIntField);
					if (team != null)
					{
						team.Roster.ResetToEmpty();
					}
				}
				if (team == null)
				{
					team = FifaEnvironment.Teams.FitTeam(record2.StringField[FI.teams_teamname], 0);
					if (team != null && country.Id != 216 && team.Country != country)
					{
						team = null;
					}
					if (team != null)
					{
						team.Roster.ResetToEmpty();
					}
				}
				if (team != null)
				{
					array[num3++] = team;
					team.assetid = andCheckIntField2;
				}
			}
			for (int m = 0; m < table3.NValidRecords; m++)
			{
				Record record3 = table3.Records[m];
				int andCheckIntField3 = record3.GetAndCheckIntField(FI.formations_teamid);
				for (int n = 0; n < num3; n++)
				{
					if (array[n].assetid == andCheckIntField3)
					{
						Formation formation = new Formation(record3);
						Formation formation2 = FifaEnvironment.GenericFormations.GetExactFormation(formation);
						if (formation2 == null)
						{
							int newId = FifaEnvironment.Formations.GetNewId();
							formation.Id = newId;
							formation.teamid = -1;
							FifaEnvironment.Formations.InsertId(formation);
							FifaEnvironment.GenericFormations.InsertId(formation);
							formation2 = formation;
						}
						array[n].Formation = formation2;
						array[n].formationid = formation2.Id;
						break;
					}
				}
			}
			statusBar.Text = "Updating Players ...";
			int num4 = 230000;
			int num5 = 0;
			for (int num6 = 0; num6 < table6.NValidRecords; num6++)
			{
				Record record4 = table6.Records[num6];
				int andCheckIntField4 = record4.GetAndCheckIntField(FI.players_playerid);
				bool flag = false;
				for (int num7 = 0; num7 < table2.NValidRecords; num7++)
				{
					Record record5 = table2.Records[num7];
					if (andCheckIntField4 == record5.GetAndCheckIntField(FI.teamplayerlinks_playerid))
					{
						int andCheckIntField5 = record5.GetAndCheckIntField(FI.teamplayerlinks_teamid);
						for (int num8 = 0; num8 < num3; num8++)
						{
							if (array[num8].assetid == andCheckIntField5)
							{
								flag = true;
								break;
							}
						}
						break;
					}
				}
				if (flag)
				{
					DateTime dateTime = FifaUtil.ConvertToDate(record4.GetAndCheckIntField(FI.players_birthdate));
					string text = null;
					string text2 = null;
					string text3 = null;
					string text4 = null;
					int num9 = 0;
					for (int num10 = 0; num10 < table7.NValidRecords; num10++)
					{
						Record record6 = table7.Records[num10];
						if (record6.GetAndCheckIntField(FI.cz_players_playerid) == andCheckIntField4)
						{
							num9 = record6.GetAndCheckIntField(FI.cz_players_assetid);
							break;
						}
					}
					Player player = null;
					if (num9 != 0)
					{
						player = (Player)FifaEnvironment.Players.SearchId(num9);
					}
					if (player == null)
					{
						int num11 = 0;
						while (num11 < table5.NValidRecords)
						{
							Record record7 = table5.Records[num11];
							if (record7.IntField[FI.editedplayernames_playerid] == andCheckIntField4)
							{
								text = record7.GetAndCheckStringField(FI.editedplayernames_firstname);
								text2 = record7.GetAndCheckStringField(FI.editedplayernames_surname);
								text3 = record7.GetAndCheckStringField(FI.editedplayernames_commonname);
								if (text3.Contains(text2))
								{
									text3 = null;
								}
								text4 = record7.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
								if (text4 != text2 && text4.Contains(text2))
								{
									text4 = text2;
									break;
								}
								break;
							}
							else
							{
								num11++;
							}
						}
						player = FifaEnvironment.Players.FitPlayer(text, text2, dateTime);
						if (player == null)
						{
							num4 = FifaEnvironment.Players.GetNextId(num4);
							player = new Player(table6.Records[num6]);
							player.Id = num4;
							player.firstname = text;
							player.lastname = text2;
							player.commonname = text3;
							player.playerjerseyname = text4;
							FifaEnvironment.Players.InsertId(player);
							player.LinkCountry(FifaEnvironment.Countries);
						}
					}
					array2[num5++] = player;
					player.m_assetid = andCheckIntField4;
				}
			}
			for (int num12 = 0; num12 < table2.NValidRecords; num12++)
			{
				Record record8 = table2.Records[num12];
				int andCheckIntField6 = record8.GetAndCheckIntField(FI.teamplayerlinks_playerid);
				int andCheckIntField7 = record8.GetAndCheckIntField(FI.teamplayerlinks_teamid);
				for (int num13 = 0; num13 < num5; num13++)
				{
					if (array2[num13].m_assetid == andCheckIntField6)
					{
						int num14 = 0;
						while (num14 < num3)
						{
							if (array[num14].assetid == andCheckIntField7)
							{
								array2[num13].PlayFor(array[num14]);
								TeamPlayer teamPlayer = new TeamPlayer(record8, array2[num13], array[num14]);
								array[num14].Roster.Add(teamPlayer);
								if (array[num14].captainid == array2[num13].m_assetid)
								{
									array[num14].PlayerCaptain = array2[num13];
									array[num14].captainid = array2[num13].Id;
								}
								if (array[num14].freekicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerFreeKick = array2[num13];
									array[num14].freekicktakerid = array2[num13].Id;
								}
								if (array[num14].leftfreekicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerLeftFreeKick = array2[num13];
									array[num14].leftfreekicktakerid = array2[num13].Id;
								}
								if (array[num14].rightfreekicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerRightFreeKick = array2[num13];
									array[num14].rightfreekicktakerid = array2[num13].Id;
								}
								if (array[num14].leftcornerkicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerLeftCorner = array2[num13];
									array[num14].leftcornerkicktakerid = array2[num13].Id;
								}
								if (array[num14].longkicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerLongKick = array2[num13];
									array[num14].longkicktakerid = array2[num13].Id;
								}
								if (array[num14].penaltytakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerPenalty = array2[num13];
									array[num14].penaltytakerid = array2[num13].Id;
								}
								if (array[num14].rightcornerkicktakerid == array2[num13].m_assetid)
								{
									array[num14].PlayerRightCorner = array2[num13];
									array[num14].rightcornerkicktakerid = array2[num13].Id;
									break;
								}
								break;
							}
							else
							{
								num14++;
							}
						}
						break;
					}
				}
			}
			for (int num15 = 0; num15 < array2.Length; num15++)
			{
				array2[num15].m_assetid = array2[num15].Id;
			}
			for (int num16 = 0; num16 < array.Length; num16++)
			{
				array[num16].assetid = array[num16].Id;
			}
			if (statusBar != null)
			{
				statusBar.Text = "Update complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x040011B4 RID: 4532
		private int m_NFiles = -1;

		// Token: 0x040011B5 RID: 4533
		private UgcDirEntry[] m_UgcDir;

		// Token: 0x040011B6 RID: 4534
		private BinaryReader m_BinaryReader;
	}
}
