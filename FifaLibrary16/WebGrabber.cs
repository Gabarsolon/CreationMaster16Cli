using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x020000A3 RID: 163
	public class WebGrabber
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x000593D5 File Offset: 0x000575D5
		public DataTable WebTable
		{
			get
			{
				return this.m_WebTable;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000593DD File Offset: 0x000575DD
		public bool CanExtractWebTeam
		{
			get
			{
				return this.m_CanExtractWebTeam;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000593E5 File Offset: 0x000575E5
		public bool CanExtractWebPlayer
		{
			get
			{
				return this.m_CanExtractWebPlayer;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000593ED File Offset: 0x000575ED
		public WebGrabber.EWebSiteDomain WebSiteDomain
		{
			get
			{
				return this.m_WebSiteDomain;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000593F5 File Offset: 0x000575F5
		public Bitmap Picture
		{
			get
			{
				return this.m_PlayerPicture;
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00059400 File Offset: 0x00057600
		public WebGrabber()
		{
			this.m_WebTable.Columns.Add("type");
			this.m_WebTable.Columns.Add("id");
			this.m_WebTable.Columns.Add("name");
			this.m_WebTable.Columns.Add("firstname");
			this.m_WebTable.Columns.Add("lastname");
			this.m_WebTable.Columns.Add("commonname");
			this.m_WebTable.Columns.Add("country");
			this.m_WebTable.Columns.Add("birthdate");
			this.m_WebTable.Columns.Add("age");
			this.m_WebTable.Columns.Add("role");
			this.m_WebTable.Columns.Add("height");
			this.m_WebTable.Columns.Add("weight");
			this.m_WebTable.Columns.Add("foot");
			this.m_WebTable.Columns.Add("team");
			this.m_WebTable.Columns.Add("number");
			this.m_WebTable.Columns.Add("since");
			this.m_WebTable.Columns.Add("contract");
			this.m_WebTable.Columns.Add("previousteam");
			this.m_WebTable.Columns.Add("loanedfrom");
			this.m_WebTable.Columns.Add("loanenddate");
			this.m_WebTable.Columns.Add("marketvalue");
			this.m_WebTable.Columns.Add("stadium");
			this.m_WebTable.Columns.Add("seats");
			this.m_WebTable.Columns.Add("managername");
			this.m_WebTable.Columns.Add("managersurname");
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0005964C File Offset: 0x0005784C
		public bool Sync(string webDocumentTitle)
		{
			bool flag = false;
			bool flag2 = webDocumentTitle.Contains("(Detailed view)") && webDocumentTitle.Contains("Detailed squad");
			bool flag3 = webDocumentTitle.Contains("Results, fixtures, squad, statistics, photos, videos and news - Soccerway");
			if ((flag2 || flag3) != this.m_CanExtractWebTeam)
			{
				this.m_CanExtractWebTeam = flag2 || flag3;
				if (flag2)
				{
					this.m_WebSiteDomain = WebGrabber.EWebSiteDomain.Transfermrkt;
				}
				if (flag3)
				{
					this.m_WebSiteDomain = WebGrabber.EWebSiteDomain.Soccerway;
				}
				flag = true;
			}
			bool flag4 = webDocumentTitle.Contains("Profile with news, career statistics and history - Soccerway");
			bool flag5 = webDocumentTitle.Contains("Player Profile");
			if ((flag4 || flag5) != this.m_CanExtractWebPlayer)
			{
				this.m_CanExtractWebPlayer = flag4 || flag5;
				if (flag4)
				{
					this.m_WebSiteDomain = WebGrabber.EWebSiteDomain.Soccerway;
				}
				if (flag5)
				{
					this.m_WebSiteDomain = WebGrabber.EWebSiteDomain.Transfermrkt;
				}
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00059700 File Offset: 0x00057900
		public string ExtractTeamNameFromWebTitle(string webDocumentTitle)
		{
			int num = webDocumentTitle.LastIndexOf('-');
			string text = string.Empty;
			if (num >= 3)
			{
				text = webDocumentTitle.Substring(0, num - 1);
			}
			return text;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00059730 File Offset: 0x00057930
		public string ExtractPlayerNameFromWebTitle(string webDocumentTitle)
		{
			int num = webDocumentTitle.LastIndexOf('-');
			string text = string.Empty;
			if (num >= 3)
			{
				text = webDocumentTitle.Substring(0, num - 1);
			}
			return text;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0005975E File Offset: 0x0005795E
		public bool ExtractInfoFromWeb(HtmlDocument webPage)
		{
			if (this.m_CanExtractWebPlayer)
			{
				return this.ExtractPlayerInfoFromWeb(webPage);
			}
			return this.m_CanExtractWebTeam && this.ExtractRosterInfoFromWeb(webPage);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00059784 File Offset: 0x00057984
		public bool ExtractRosterInfoFromWeb(HtmlDocument webPage)
		{
			WebGrabber.EWebSiteDomain webSiteDomain = this.m_WebSiteDomain;
			bool flag = false;
			if (webSiteDomain == WebGrabber.EWebSiteDomain.Soccerway)
			{
				flag = this.ExtractRosterInfoFromSoccerway(webPage);
			}
			else if (webSiteDomain == WebGrabber.EWebSiteDomain.Transfermrkt)
			{
				flag = this.ExtractRosterInfoFromTransfermrkt(webPage);
			}
			return flag;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00009CCD File Offset: 0x00007ECD
		private bool ExtractRosterInfoFromSoccerway(HtmlDocument webPage)
		{
			return false;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000597B8 File Offset: 0x000579B8
		private void SplitPlayerName(string nameSurname, DataRow webDataRow)
		{
			int num = nameSurname.IndexOf(' ');
			if (num < 0 || webDataRow["country"].ToString().Contains("Korea"))
			{
				webDataRow["commonname"] = nameSurname;
				return;
			}
			int num2 = nameSurname.LastIndexOf(' ');
			string text;
			string text2;
			if (num2 == num)
			{
				text = nameSurname.Substring(0, num);
				webDataRow["firstname"] = text;
				text2 = nameSurname.Substring(num + 1);
				webDataRow["lastname"] = text2;
				return;
			}
			if (nameSurname.Substring(num, num2 - num + 1).ToLower() == " da " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " das " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " la " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " le " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " de " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " del " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " di " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " ten " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " van der " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " van de " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " van " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " st. " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " el " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " al " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " de la " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " mac " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " mc " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " von " || nameSurname.Substring(num, num2 - num + 1).ToLower() == " ben ")
			{
				text = nameSurname.Substring(0, num);
				webDataRow["firstname"] = text;
				text2 = nameSurname.Substring(num + 1);
				webDataRow["lastname"] = text2;
				return;
			}
			text = nameSurname.Substring(0, num2);
			webDataRow["firstname"] = text;
			text2 = nameSurname.Substring(num2 + 1);
			webDataRow["lastname"] = text2;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00059AE0 File Offset: 0x00057CE0
		public bool ExtractRosterInfoFromTransfermrkt(HtmlDocument webPage)
		{
			HtmlElementCollection htmlElementCollection = webPage.GetElementsByTagName("span");
			this.m_WebTable.Rows.Clear();
			DataRow dataRow = this.m_WebTable.NewRow();
			string text = this.ExtractTeamNameFromWebTitle(webPage.Title);
			if (this.m_PlayerPicture != null)
			{
				this.m_PlayerPicture.Dispose();
				this.m_PlayerPicture = null;
			}
			dataRow["name"] = text;
			dataRow["type"] = "Team";
			Team team = FifaEnvironment.Teams.MatchByname(text);
			if (team != null)
			{
				dataRow["id"] = team.Id.ToString();
			}
			else
			{
				int newId = FifaEnvironment.Teams.GetNewId();
				if (newId != -1)
				{
					dataRow["id"] = newId.ToString();
				}
			}
			int num = FifaEnvironment.Players.GetNewId();
			int i = 0;
			while (i < htmlElementCollection.Count)
			{
				HtmlElement htmlElement = htmlElementCollection[i];
				if (htmlElement.OuterText != null && htmlElement.OuterText.Contains("Stadium"))
				{
					if (htmlElementCollection[i + 1].Children.Count <= 0)
					{
						break;
					}
					if (htmlElementCollection[i + 1].Children.Count > 0)
					{
						dataRow["stadium"] = htmlElementCollection[i + 1].Children[0].OuterText;
					}
					if (htmlElementCollection[i + 1].Children.Count > 1)
					{
						dataRow["seats"] = htmlElementCollection[i + 1].Children[1].OuterText;
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			this.m_WebTable.Rows.Add(dataRow);
			Bitmap bitmap = this.SearchImageContaining(webPage, "wappen/head");
			int num2 = bitmap.Width * 256 / bitmap.Height;
			this.m_PlayerPicture = GraphicUtil.ResizeBitmap(bitmap, num2, 256, InterpolationMode.HighQualityBicubic);
			this.m_PlayerPicture = GraphicUtil.CanvasSizeBitmap(this.m_PlayerPicture, 256, 256);
			htmlElementCollection = webPage.GetElementsByTagName("table");
			foreach (object obj in htmlElementCollection)
			{
				HtmlElement htmlElement2 = (HtmlElement)obj;
				if (htmlElement2.OuterText.StartsWith("\r\n\r\n#\r\n\r\n\r\nPlayer(s)\r\n\r\n\r\nborn/age\r\n\r\nNat.\r\n\r\n\r\nHeight\r\n\r\n\r\nFoot\r\n\r\n\r\nIn the team since\r\n\r\nbefore\r\n\r\n\r\nContract until\r\n\r\n\r\nMarket value"))
				{
					if (htmlElement2.Children.Count < 2)
					{
						return false;
					}
					HtmlElement htmlElement3 = htmlElement2.Children[1];
					int count = htmlElement3.Children.Count;
					for (int j = 0; j < count; j++)
					{
						HtmlElement htmlElement4 = htmlElement3.Children[j];
						string outerText = htmlElement4.Children[0].OuterText;
						string text2 = string.Empty;
						HtmlElementCollection htmlElementCollection2 = htmlElement4.Children[1].GetElementsByTagName("A");
						int count2 = htmlElementCollection2.Count;
						text2 = htmlElementCollection2[count2 - 2].OuterText;
						string text3 = string.Empty;
						string text4 = string.Empty;
						string text5;
						int num3;
						if (htmlElementCollection2[0].InnerHtml.Contains("Loaned from: "))
						{
							text5 = htmlElementCollection2[0].InnerHtml;
							num3 = text5.IndexOf("Loaned from: ");
							text5 = text5.Substring(num3 + 13);
							num3 = text5.IndexOf(';');
							text5 = text5.Substring(0, num3);
							text3 = text5;
							text5 = htmlElementCollection2[0].InnerHtml;
							num3 = text5.IndexOf("return on: ");
							text5 = text5.Substring(num3 + 11);
							num3 = text5.IndexOf('"');
							text5 = text5.Substring(0, num3);
							text4 = text5;
						}
						htmlElementCollection2 = htmlElement4.Children[1].GetElementsByTagName("TD");
						int count3 = htmlElementCollection2.Count;
						string outerText2 = htmlElementCollection2[count3 - 1].OuterText;
						string text6 = string.Empty;
						text5 = htmlElement4.Children[2].OuterText;
						num3 = text5.IndexOf('(');
						text6 = text5.Substring(0, num3 - 1);
						string text7 = text5.Substring(num3 + 1, 2);
						text5 = htmlElement4.Children[3].InnerHtml;
						string text8 = string.Empty;
						int num4 = text5.IndexOf('"');
						if (num4 >= 0)
						{
							text5 = text5.Substring(num4 + 1);
							int num5 = text5.IndexOf('"');
							if (num5 >= 1)
							{
								text8 = text5.Substring(0, num5);
							}
						}
						string text9 = htmlElement4.Children[4].OuterText;
						text9 = text9.Replace(".", string.Empty);
						text9 = text9.Replace(",", string.Empty);
						text9 = text9.Replace(" ", string.Empty);
						text9 = text9.Replace("m", string.Empty);
						string outerText3 = htmlElement4.Children[5].OuterText;
						string outerText4 = htmlElement4.Children[6].OuterText;
						string text10 = string.Empty;
						text5 = htmlElement4.Children[7].InnerHtml;
						if (text5 != null)
						{
							num4 = text5.IndexOf("alt=");
							if (num4 >= 0)
							{
								text5 = text5.Substring(num4 + 5);
								int num6 = text5.IndexOf('"');
								if (num6 >= 1)
								{
									text10 = text5.Substring(0, num6);
								}
							}
						}
						string outerText5 = htmlElement4.Children[8].OuterText;
						string outerText6 = htmlElement4.Children[9].OuterText;
						dataRow = this.m_WebTable.NewRow();
						dataRow["name"] = text2;
						dataRow["type"] = "Player";
						dataRow["birthdate"] = text6;
						dataRow["age"] = text7;
						DateTime dateTime = FifaUtil.ConvertToDate(text6);
						dataRow["country"] = text8;
						dataRow["role"] = outerText2;
						dataRow["height"] = text9;
						dataRow["foot"] = outerText3;
						dataRow["number"] = outerText;
						dataRow["team"] = text;
						dataRow["since"] = outerText4;
						dataRow["contract"] = outerText5;
						dataRow["previousteam"] = text10;
						dataRow["loanedfrom"] = text3;
						dataRow["loanenddate"] = text4;
						dataRow["marketvalue"] = outerText6;
						this.SplitPlayerName(text2, dataRow);
						string text11 = dataRow["commonname"].ToString();
						string text12 = dataRow["firstname"].ToString();
						string text13 = dataRow["lastname"].ToString();
						Player player = FifaEnvironment.Players.MatchPlayerByNameBirthday(ref text12, ref text13, ref text11, dateTime);
						dataRow["commonname"] = text11;
						dataRow["firstname"] = text12;
						dataRow["lastname"] = text13;
						if (player != null)
						{
							dataRow["id"] = player.Id.ToString();
						}
						else
						{
							dataRow["id"] = num.ToString();
							num = FifaEnvironment.Players.GetNextId(num + 1);
						}
						this.m_WebTable.Rows.Add(dataRow);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0005A27C File Offset: 0x0005847C
		public bool ExtractPlayerInfoFromTransfermrkt(HtmlDocument webPage)
		{
			HtmlElementCollection elementsByTagName = webPage.GetElementsByTagName("table");
			string text = null;
			string text2 = null;
			string text3 = null;
			DateTime dateTime = default(DateTime);
			bool flag = false;
			string text4 = this.ExtractPlayerNameFromWebTitle(webPage.Title);
			this.m_WebTable.Rows.Clear();
			DataRow dataRow = this.m_WebTable.NewRow();
			dataRow["name"] = text4;
			dataRow["type"] = "Player";
			for (int i = 0; i < elementsByTagName.Count; i++)
			{
				HtmlElement htmlElement = elementsByTagName[i];
				if (htmlElement.Children[0].OuterText.Contains("Date of birth:"))
				{
					flag = true;
					HtmlElement htmlElement2 = htmlElement.Children[0];
					for (int j = 0; j < htmlElement2.Children.Count; j++)
					{
						string outerText = htmlElement2.Children[j].Children[0].OuterText;
						string text5 = htmlElement2.Children[j].Children[1].OuterText;
						text5 = text5.Replace("\t", "");
						text5 = text5.Trim();
						uint num = FifaUtil.ComputeStringHash(outerText);
						if (num <= 1154282761U)
						{
							if (num <= 531694587U)
							{
								if (num != 262196659U)
								{
									if (num == 531694587U)
									{
										if (outerText == "Weight ")
										{
											dataRow["weight"] = text5;
										}
									}
								}
								else if (outerText == "Contract until:")
								{
									dataRow["contract"] = text5;
								}
							}
							else if (num != 576125320U)
							{
								if (num != 760999072U)
								{
									if (num == 1154282761U)
									{
										if (outerText == "Nationality:")
										{
											int num2 = text5.IndexOf('\r');
											if (num2 >= 0)
											{
												text5 = text5.Substring(0, num2);
											}
											dataRow["country"] = text5;
										}
									}
								}
								else if (outerText == "Last name ")
								{
									dataRow["lastname"] = text5;
									text2 = text5;
								}
							}
							else if (outerText == "Height:")
							{
								text5 = text5.Replace(".", string.Empty);
								text5 = text5.Replace(",", string.Empty);
								text5 = text5.Replace(" ", string.Empty);
								text5 = text5.Replace("m", string.Empty);
								dataRow["height"] = text5;
							}
						}
						else if (num <= 2654926128U)
						{
							if (num != 1517086830U)
							{
								if (num != 2654609465U)
								{
									if (num == 2654926128U)
									{
										if (outerText == "Position:")
										{
											dataRow["role"] = text5;
										}
									}
								}
								else if (outerText == "Foot:")
								{
									dataRow["foot"] = text5;
								}
							}
							else if (outerText == "In the team since:")
							{
								dataRow["since"] = text5;
							}
						}
						else if (num != 3232163015U)
						{
							if (num != 3505601650U)
							{
								if (num == 3961941544U)
								{
									if (outerText == "First name ")
									{
										dataRow["firstname"] = text5;
										text = text5;
									}
								}
							}
							else if (outerText == "Age:")
							{
								dataRow["age"] = text5;
							}
						}
						else if (outerText == "Date of birth:")
						{
							dataRow["birthdate"] = text5;
							dateTime = FifaUtil.ConvertToDate(text5);
						}
					}
				}
			}
			if (flag)
			{
				this.SplitPlayerName(text4, dataRow);
				text3 = dataRow["commonname"].ToString();
				text = dataRow["firstname"].ToString();
				text2 = dataRow["lastname"].ToString();
				Player player = FifaEnvironment.Players.MatchPlayerByNameBirthday(ref text, ref text2, ref text3, dateTime);
				dataRow["commonname"] = text3;
				dataRow["firstname"] = text;
				dataRow["lastname"] = text2;
				if (player != null)
				{
					dataRow["id"] = player.Id.ToString();
				}
				else
				{
					dataRow["id"] = FifaEnvironment.Players.GetNewId().ToString();
				}
				this.m_WebTable.Rows.Add(dataRow);
				Bitmap bitmap = this.SearchImageContaining(webPage, "portrait", "spielerfotos");
				if (bitmap != null)
				{
					int num3 = bitmap.Width * 128 / bitmap.Height;
					this.m_PlayerPicture = GraphicUtil.ResizeBitmap(bitmap, num3, 128, InterpolationMode.HighQualityBicubic);
					this.m_PlayerPicture = GraphicUtil.CanvasSizeBitmap(this.m_PlayerPicture, 128, 128);
				}
				else
				{
					this.m_PlayerPicture = null;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0005A7E3 File Offset: 0x000589E3
		private Bitmap SearchImageContaining(HtmlDocument webPage, string caption1)
		{
			return this.SearchImageContaining(webPage, caption1, "default");
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0005A7F4 File Offset: 0x000589F4
		private Bitmap SearchImageContaining(HtmlDocument webPage, string caption1, string caption2)
		{
			int num;
			for (int i = 0; i < webPage.Images.Count; i = num + 1)
			{
				string attribute = webPage.Images[i].GetAttribute("src");
				if (attribute != null && (attribute.Contains(caption1) || attribute.Contains(caption2)) && !attribute.Contains("default"))
				{
					Uri uri = new Uri(attribute);
					return (Bitmap)this.DownloadImage(uri);
				}
				num = i;
			}
			return null;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0005A86D File Offset: 0x00058A6D
		public Image DownloadImage(Uri url)
		{
			return Image.FromStream(new MemoryStream(new WebClient().DownloadData(url)));
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0005A884 File Offset: 0x00058A84
		public bool ExtractPlayerInfoFromSoccerway(HtmlDocument webPage)
		{
			HtmlElementCollection elementsByTagName = webPage.GetElementsByTagName("dl");
			if (elementsByTagName.Count == 1)
			{
				HtmlElement htmlElement = elementsByTagName[0];
				this.m_WebTable.Rows.Clear();
				DataRow dataRow = this.m_WebTable.NewRow();
				string text = null;
				string text2 = null;
				string text3 = null;
				DateTime dateTime = default(DateTime);
				for (int i = 0; i < htmlElement.Children.Count; i += 2)
				{
					string outerText = htmlElement.Children[i].OuterText;
					string outerText2 = htmlElement.Children[i + 1].OuterText;
					uint num = FifaUtil.ComputeStringHash(outerText);
					if (num <= 986506571U)
					{
						if (num <= 531694587U)
						{
							if (num != 207017702U)
							{
								if (num == 531694587U)
								{
									if (outerText == "Weight ")
									{
										outerText2.Replace("kg", "").Trim();
										dataRow["weight"] = outerText2;
									}
								}
							}
							else if (outerText == "Height ")
							{
								string text4 = outerText2.Replace("cm", "");
								text4 = text4.Trim();
								dataRow["height"] = text4;
							}
						}
						else if (num != 760999072U)
						{
							if (num == 986506571U)
							{
								if (outerText == "Nationality ")
								{
									dataRow["country"] = outerText2.Trim();
								}
							}
						}
						else if (outerText == "Last name ")
						{
							text2 = outerText2.Trim();
							dataRow["lastname"] = text2;
						}
					}
					else if (num <= 2863055397U)
					{
						if (num != 2554260414U)
						{
							if (num == 2863055397U)
							{
								if (outerText == "Date of birth ")
								{
									dataRow["birthdate"] = outerText2.Trim();
									dateTime = FifaUtil.ConvertToDate(outerText2);
								}
							}
						}
						else if (outerText == "Position ")
						{
							dataRow["role"] = outerText2.Trim();
						}
					}
					else if (num != 3023717083U)
					{
						if (num != 3874709268U)
						{
							if (num == 3961941544U)
							{
								if (outerText == "First name ")
								{
									text = outerText2.Trim();
									dataRow["firstname"] = text;
								}
							}
						}
						else if (outerText == "Age ")
						{
							outerText2.Trim();
							dataRow["age"] = outerText2;
						}
					}
					else if (outerText == "Foot ")
					{
						dataRow["foot"] = outerText2.Trim();
					}
				}
				dataRow["name"] = text + " " + text2;
				dataRow["type"] = "Player";
				text3 = dataRow["commonname"].ToString();
				Player player = FifaEnvironment.Players.MatchPlayerByNameBirthday(ref text, ref text2, ref text3, dateTime);
				dataRow["commonname"] = text3;
				dataRow["firstname"] = text;
				dataRow["lastname"] = text2;
				if (player != null)
				{
					dataRow["id"] = player.Id.ToString();
				}
				else
				{
					dataRow["id"] = FifaEnvironment.Players.GetNewId().ToString();
				}
				this.m_WebTable.Rows.Add(dataRow);
				this.m_PlayerPicture = this.SearchImageContaining(webPage, "150x150");
				this.m_PlayerPicture = GraphicUtil.MakeAutoTransparent(this.m_PlayerPicture);
				this.m_PlayerPicture = GraphicUtil.ResizeBitmap(this.m_PlayerPicture, 128, 128, InterpolationMode.HighQualityBicubic);
				return true;
			}
			return false;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0005AC88 File Offset: 0x00058E88
		public bool ExtractPlayerInfoFromWeb(HtmlDocument webPage)
		{
			WebGrabber.EWebSiteDomain webSiteDomain = this.m_WebSiteDomain;
			bool flag;
			if (webSiteDomain != WebGrabber.EWebSiteDomain.Transfermrkt)
			{
				flag = webSiteDomain == WebGrabber.EWebSiteDomain.Soccerway && this.ExtractPlayerInfoFromSoccerway(webPage);
			}
			else
			{
				flag = this.ExtractPlayerInfoFromTransfermrkt(webPage);
			}
			return flag;
		}

		// Token: 0x040011EA RID: 4586
		private DataTable m_WebTable = new DataTable("PlayerWebData");

		// Token: 0x040011EB RID: 4587
		private bool m_CanExtractWebTeam;

		// Token: 0x040011EC RID: 4588
		private bool m_CanExtractWebPlayer;

		// Token: 0x040011ED RID: 4589
		private WebGrabber.EWebSiteDomain m_WebSiteDomain;

		// Token: 0x040011EE RID: 4590
		private Bitmap m_PlayerPicture;

		// Token: 0x020000C7 RID: 199
		public enum EWebSiteDomain
		{
			// Token: 0x04001296 RID: 4758
			None,
			// Token: 0x04001297 RID: 4759
			Transfermrkt,
			// Token: 0x04001298 RID: 4760
			Soccerway
		}
	}
}
