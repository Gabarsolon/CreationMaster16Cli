using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000086 RID: 134
	public class CompobjList : IdArrayList
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x000480B4 File Offset: 0x000462B4
		public CompobjList()
			: base(typeof(Compobj))
		{
			base.MinId = 0;
			base.MaxId = 99999;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000480D8 File Offset: 0x000462D8
		public CompobjList(string path, DbFile dbFile)
			: base(typeof(Compobj))
		{
			base.MinId = 0;
			base.MaxId = 99999;
			this.Load(path, dbFile);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00048104 File Offset: 0x00046304
		public static string[] GetFileNames()
		{
			CompobjList.s_FileNames[0] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/compobj.txt";
			CompobjList.s_FileNames[1] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/settings.txt";
			CompobjList.s_FileNames[2] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/standings.txt";
			CompobjList.s_FileNames[3] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/advancement.txt";
			CompobjList.s_FileNames[4] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/schedule.txt";
			CompobjList.s_FileNames[5] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/weather.txt";
			CompobjList.s_FileNames[6] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/tasks.txt";
			CompobjList.s_FileNames[7] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/initteams.txt";
			CompobjList.s_FileNames[8] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/compids.txt";
			CompobjList.s_FileNames[9] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/internationals.txt";
			return CompobjList.s_FileNames;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00048190 File Offset: 0x00046390
		public TrophyList Trophies
		{
			get
			{
				TrophyList trophyList = new TrophyList();
				foreach (object obj in this)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.IsTrophy())
					{
						trophyList.Add(compobj);
					}
				}
				return trophyList;
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000481F4 File Offset: 0x000463F4
		public void Load(string path, DbFile fifaDbFile)
		{
			this.Clear();
			bool flag = false;
			for (int i = 0; i < CompobjList.s_FileNames.Length; i++)
			{
				if (!File.Exists(path + CompobjList.s_FileNames[0]))
				{
					flag = true;
				}
			}
			if (flag)
			{
				FifaEnvironment.ExtractCompetitionFiles();
			}
			this.LoadFromCompobj(path + CompobjList.s_FileNames[0]);
			this.LoadFromSettings(path + CompobjList.s_FileNames[1]);
			this.LoadFromStandings(path + CompobjList.s_FileNames[2]);
			this.LoadFromAdvancement(path + CompobjList.s_FileNames[3]);
			this.LoadFromSchedule(path + CompobjList.s_FileNames[4]);
			this.LoadFromWeather(path + CompobjList.s_FileNames[5]);
			this.LoadFromTasks(path + CompobjList.s_FileNames[6]);
			this.LoadFromInitteams(path + CompobjList.s_FileNames[7]);
			this.LoadFromInternationals(path + CompobjList.s_FileNames[9]);
			this.FillFromLanguage();
			Table table = fifaDbFile.Table[TI.competition];
			this.FillFromCompetition(table);
			this.Normalize();
			this.CollectDescriptions();
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00048327 File Offset: 0x00046527
		public bool LoadFromCompobj(string fileName)
		{
			return this.LoadFromCompobj(fileName, null);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00048334 File Offset: 0x00046534
		public bool LoadFromCompobj(string fileName, Compobj parentObject)
		{
			bool flag = true;
			bool flag2 = false;
			Compobj compobj = null;
			if (!File.Exists(fileName))
			{
				return false;
			}
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 5)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					string text2 = array2[2];
					string text3 = array2[3];
					Convert.ToInt32(array2[4]);
					switch (num2)
					{
					case 0:
					{
						World world = new World(num, text2, text3);
						base.InsertId(world);
						break;
					}
					case 1:
					{
						Compobj compobj2 = new Confederation(num, text2, text3, null);
						base.InsertId(compobj2);
						break;
					}
					case 2:
					{
						Compobj compobj2 = new Nation(num, text2, text3, null);
						base.InsertId(compobj2);
						break;
					}
					case 3:
					{
						Compobj compobj2 = new Trophy(num, text2, text3, null);
						base.InsertId(compobj2);
						break;
					}
					case 4:
					{
						Compobj compobj2 = new Stage(num, text2, text3, null);
						base.InsertId(compobj2);
						break;
					}
					case 5:
					{
						Compobj compobj2 = new Group(num, text2, text3, null);
						base.InsertId(compobj2);
						break;
					}
					}
				}
			}
			streamReader.BaseStream.Seek(0L, SeekOrigin.Begin);
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array3 = text.Split(array);
				if (array3.Length == 5)
				{
					int num3 = Convert.ToInt32(array3[0]);
					Convert.ToInt32(array3[1]);
					string text4 = array3[2];
					string text5 = array3[3];
					int num4 = Convert.ToInt32(array3[4]);
					if (num4 != -1)
					{
						Compobj compobj3 = (Compobj)base.SearchId(num3);
						Compobj compobj4 = (Compobj)base.SearchId(num4);
						if (compobj4 == null)
						{
							compobj4 = parentObject;
							if (!compobj3.IsConfederation())
							{
								goto IL_0230;
							}
							if (compobj4.IsWorld())
							{
								IEnumerator enumerator = compobj4.Confederations.GetEnumerator(); using (enumerator as IDisposable)
								{
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										Confederation confederation = (Confederation)obj;
										if (compobj3.TypeString == confederation.TypeString)
										{
											compobj = confederation;
										}
									}
									goto IL_0300;
								}
								goto IL_0230;
							}
							flag = false;
							IL_0300:
							if (!flag)
							{
								FifaEnvironment.UserMessages.ShowMessage(1038);
								flag2 = true;
								goto IL_0339;
							}
							DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(34, compobj3.TypeString, true);
							if (dialogResult == DialogResult.Yes || dialogResult == DialogResult.OK)
							{
								flag2 = false;
								goto IL_0339;
							}
							goto IL_0339;
							IL_0230:
							if (compobj3.IsNation())
							{
								if (!compobj4.IsConfederation())
								{
									flag = false;
									goto IL_0300;
								}
								IEnumerator enumerator = compobj4.Nations.GetEnumerator(); using (enumerator as IDisposable)
								{
									while (enumerator.MoveNext())
									{
										object obj2 = enumerator.Current;
										Nation nation = (Nation)obj2;
										if (compobj3.TypeString == nation.TypeString)
										{
											compobj = nation;
										}
									}
									goto IL_0300;
								}
							}
							if (compobj3.IsTrophy())
							{
								IEnumerator enumerator = compobj4.Trophies.GetEnumerator(); using (enumerator as IDisposable)
								{
									while (enumerator.MoveNext())
									{
										object obj3 = enumerator.Current;
										Trophy trophy = (Trophy)obj3;
										if (compobj3.TypeString == trophy.TypeString)
										{
											compobj = trophy;
										}
									}
									goto IL_0300;
								}
							}
							flag = false;
							goto IL_0300;
						}
						IL_0339:
						if (flag2)
						{
							break;
						}
						if (compobj3 != null && compobj4 != null)
						{
							if (compobj == null)
							{
								compobj3.ParentObj = compobj4;
								compobj4.AddChild(compobj3);
							}
							else if (compobj3.IsConfederation())
							{
								compobj4.Confederations.RemoveId(compobj);
								compobj3.ParentObj = compobj4;
								compobj4.AddChild(compobj3);
								compobj = null;
							}
							else if (compobj3.IsNation())
							{
								compobj4.Nations.RemoveId(compobj);
								compobj3.ParentObj = compobj4;
								compobj4.AddChild(compobj3);
								compobj = null;
							}
							else if (compobj3.IsTrophy())
							{
								compobj4.Trophies.RemoveId(compobj);
								compobj3.ParentObj = compobj4;
								compobj4.AddChild(compobj3);
								compobj = null;
							}
						}
						else
						{
							FifaEnvironment.UserMessages.ShowMessage(5064);
							flag = false;
						}
					}
				}
			}
			streamReader.Close();
			return flag;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00048784 File Offset: 0x00046984
		public bool LoadFromSettings(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[1];
			char[] array2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			array[0] = ',';
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array3 = text.Split(array);
				if (array3.Length == 3)
				{
					int num = Convert.ToInt32(array3[0]);
					string text2 = array3[1];
					array3[2].IndexOfAny(array2);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null)
					{
						compobj.SetProperty(array3[1], array3[2]);
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00048818 File Offset: 0x00046A18
		public bool LoadFromStandings(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 2)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj == null)
					{
						FifaEnvironment.UserMessages.ShowMessage(5064);
					}
					else if (compobj.IsGroup())
					{
						Group group = (Group)compobj;
						if (group != null)
						{
							Rank rank = new Rank(group, num2 + 1);
							group.Ranks.Add(rank);
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000488D0 File Offset: 0x00046AD0
		public bool LoadFromSchedule(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 6)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					int num5 = Convert.ToInt32(array2[4]);
					int num6 = Convert.ToInt32(array2[5]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null)
					{
						if (compobj.IsStage())
						{
							Stage stage = (Stage)base.SearchId(num);
							if (stage != null)
							{
								Schedule schedule = new Schedule(stage, num2, num3, num4, num5, num6);
								stage.AddSchedule(schedule);
							}
						}
						else if (compobj.IsGroup())
						{
							Group group = (Group)base.SearchId(num);
							if (group != null)
							{
								Schedule schedule2 = new Schedule(group, num2, num3, num4, num5, num6);
								group.AddSchedule(schedule2);
							}
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000489E4 File Offset: 0x00046BE4
		public bool LoadFromWeather(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 13)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					int num5 = Convert.ToInt32(array2[4]);
					int num6 = Convert.ToInt32(array2[9]);
					int num7 = Convert.ToInt32(array2[10]);
					int num8 = Convert.ToInt32(array2[5]);
					int num9 = Convert.ToInt32(array2[6]);
					int num10 = Convert.ToInt32(array2[7]);
					int num11 = Convert.ToInt32(array2[8]);
					int num12 = Convert.ToInt32(array2[11]);
					int num13 = Convert.ToInt32(array2[12]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null)
					{
						if (compobj.IsNation())
						{
							Nation nation = (Nation)base.SearchId(num);
							if (nation != null && num2 >= 1 && num2 <= 12)
							{
								num2--;
								nation.ClearProb[num2] = num3;
								nation.HazyProb[num2] = num4;
								nation.CloudyProb[num2] = num5;
								nation.RainProb[num2] = num8;
								nation.ShowersProb[num2] = num9;
								nation.SnowProb[num2] = num10;
								nation.FlurriesProb[num2] = num11;
								nation.OvercastProb[num2] = num6;
								nation.FoggyProb[num2] = num7;
								nation.SunsetTime[num2] = num12;
								nation.DarkTime[num2] = num13;
							}
						}
						else if (compobj.IsWorld())
						{
							World world = (World)base.SearchId(num);
							if (world != null && num2 >= 1 && num2 <= 12)
							{
								num2--;
								world.ClearProb[num2] = num3;
								world.HazyProb[num2] = num4;
								world.CloudyProb[num2] = num5;
								world.RainProb[num2] = num8;
								world.ShowersProb[num2] = num9;
								world.SnowProb[num2] = num10;
								world.FlurriesProb[num2] = num11;
								world.OvercastProb[num2] = num6;
								world.FoggyProb[num2] = num7;
								world.SunsetTime[num2] = num12;
								world.DarkTime[num2] = num13;
							}
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00048C54 File Offset: 0x00046E54
		public bool LoadFromTasks(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 7)
				{
					int num = Convert.ToInt32(array2[0]);
					string text2 = array2[1];
					string text3 = array2[2];
					int num2 = Convert.ToInt32(array2[3]);
					int num3 = Convert.ToInt32(array2[4]);
					int num4 = Convert.ToInt32(array2[5]);
					int num5 = Convert.ToInt32(array2[6]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null && compobj.IsTrophy())
					{
						Trophy trophy = (Trophy)compobj;
						if (trophy != null)
						{
							Task task = new Task(text2, text3, num2, num3, num4, num5);
							compobj = (Compobj)base.SearchId(num2);
							if (compobj.IsGroup())
							{
								((Group)compobj).AddTask(task);
							}
							else if (compobj.IsStage())
							{
								((Stage)compobj).AddTask(task);
							}
							else if (compobj.IsTrophy())
							{
								trophy = (Trophy)compobj;
								if (trophy != null)
								{
									compobj = (Compobj)base.SearchId(num3);
									if (compobj != null && compobj.IsGroup())
									{
										task.Group = (Group)compobj;
									}
									trophy.AddTask(task);
								}
							}
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00048DB4 File Offset: 0x00046FB4
		public bool LoadFromInitteams(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 3)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null && compobj.IsTrophy())
					{
						Trophy trophy = (Trophy)compobj;
						if (trophy != null)
						{
							InitTeam initTeam = new InitTeam(num2, num3);
							trophy.InitTeamArray[num2] = initTeam;
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00048E5C File Offset: 0x0004705C
		public bool LoadFromAdvancement(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 4)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					IdObject idObject = base.SearchId(num);
					Group group = ((idObject != null) ? ((Group)idObject) : null);
					idObject = base.SearchId(num3);
					Group group2 = ((idObject != null) ? ((Group)idObject) : null);
					if (group != null && group2 != null)
					{
						Rank rank = (Rank)group.Ranks.SearchId(num2);
						Rank rank2 = (Rank)group2.Ranks.SearchId(num4);
						if (rank != null && rank2 != null)
						{
							if (rank.Id != 0)
							{
								rank.MoveTo = rank2;
							}
							rank2.MoveFrom = rank;
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00048F60 File Offset: 0x00047160
		public bool LoadFromInternationals(string fileName)
		{
			bool flag = false;
			bool flag2 = true;
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',', '[', ']' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 3)
				{
					if (array2[1] == "TIER_AND_OBJECTIVES")
					{
						flag = true;
						flag2 = true;
					}
					else if (array2[1] == "LEAGUE_RANKINGS")
					{
						flag = true;
						flag2 = false;
					}
					else
					{
						flag = false;
					}
				}
				else if (flag)
				{
					if (flag2)
					{
						if (array2.Length == 8)
						{
							int num = Convert.ToInt32(array2[0]);
							int num2 = Convert.ToInt32(array2[1]);
							Convert.ToInt32(array2[2]);
							Convert.ToInt32(array2[3]);
							string text2 = array2[5];
							string text3 = array2[7];
							Country country = FifaEnvironment.Countries.SearchCountry(num2);
							if (country != null)
							{
								if (text2 == "N/A")
								{
									country.WorldCupTarget = 0;
								}
								else if (text2 == "WIN")
								{
									country.WorldCupTarget = 1;
								}
								else if (text2 == "FINAL")
								{
									country.WorldCupTarget = 2;
								}
								else if (text2 == "SEMI")
								{
									country.WorldCupTarget = 3;
								}
								else if (text2 == "QUARTER")
								{
									country.WorldCupTarget = 4;
								}
								else if (text2 == "KNOCKOUT")
								{
									country.WorldCupTarget = 5;
								}
								else if (text2 == "QUALIFY")
								{
									country.WorldCupTarget = 6;
								}
								if (text3 == "N/A")
								{
									country.ContinentalCupTarget = 0;
								}
								else if (text3 == "WIN")
								{
									country.ContinentalCupTarget = 1;
								}
								else if (text3 == "FINAL")
								{
									country.ContinentalCupTarget = 2;
								}
								else if (text3 == "SEMI")
								{
									country.ContinentalCupTarget = 3;
								}
								else if (text3 == "QUARTER")
								{
									country.ContinentalCupTarget = 4;
								}
								else if (text3 == "KNOCKOUT")
								{
									country.ContinentalCupTarget = 5;
								}
								else if (text3 == "QUALIFY")
								{
									country.ContinentalCupTarget = 6;
								}
								country.Level = num;
							}
						}
					}
					else if (array2.Length == 6)
					{
						int num3 = Convert.ToInt32(array2[0]);
						Convert.ToInt32(array2[1]);
						Convert.ToInt32(array2[2]);
						Convert.ToInt32(array2[3]);
						Convert.ToInt32(array2[4]);
						Convert.ToInt32(array2[5]);
						League league = FifaEnvironment.Leagues.SearchLeague(num3);
						if (league != null)
						{
							string text4 = text.Substring(array2[0].Length + 1);
							uint num4 = FifaUtil.ComputeStringHash(text4);
							if (num4 <= 2234794523U)
							{
								if (num4 <= 1970364470U)
								{
									if (num4 != 1305537742U)
									{
										if (num4 != 1460485720U)
										{
											if (num4 == 1970364470U)
											{
												if (text4 == "7,-1,-1,-1,-1")
												{
													league.Prestige = ELeaguePrestige.Australia_Sweden_England3_England4_Ireland;
													continue;
												}
											}
										}
										else if (text4 == "5,6,7,7,-1")
										{
											league.Prestige = ELeaguePrestige.USA_Chile;
											continue;
										}
									}
									else if (text4 == "4,5,6,7,7")
									{
										league.Prestige = ELeaguePrestige.Holland;
										continue;
									}
								}
								else if (num4 != 2129932955U)
								{
									if (num4 != 2148291656U)
									{
										if (num4 == 2234794523U)
										{
											if (text4 == "5,6,7,7,7")
											{
												league.Prestige = ELeaguePrestige.Belgium_Germany2_Colombia;
												continue;
											}
										}
									}
									else if (text4 == "4,6,7,7,7")
									{
										league.Prestige = ELeaguePrestige.Mexico_England2;
										continue;
									}
								}
								else if (text4 == "7,7,-1,-1,-1")
								{
									league.Prestige = ELeaguePrestige.Poland_Austria_Korea;
									continue;
								}
							}
							else if (num4 <= 2921754667U)
							{
								if (num4 != 2651456879U)
								{
									if (num4 != 2695781357U)
									{
										if (num4 == 2921754667U)
										{
											if (text4 == "5,6,7,-1,-1")
											{
												league.Prestige = ELeaguePrestige.Scotland_Italy2_Spain2;
												continue;
											}
										}
									}
									else if (text4 == "2,4,5,6,7")
									{
										league.Prestige = ELeaguePrestige.Argentina_Brazil;
										continue;
									}
								}
								else if (text4 == "3,5,6,7,7")
								{
									league.Prestige = ELeaguePrestige.Russia_Portugal_Turkey;
									continue;
								}
							}
							else if (num4 != 3662982323U)
							{
								if (num4 != 3715874358U)
								{
									if (num4 == 3747291754U)
									{
										if (text4 == "1,2,3,4,7")
										{
											league.Prestige = ELeaguePrestige.England_Spain_Germany_Italy;
											continue;
										}
									}
								}
								else if (text4 == "6,7,-1,-1,-1")
								{
									league.Prestige = ELeaguePrestige.France2_Denmark_Norway_Switzerland;
									continue;
								}
							}
							else if (text4 == "2,3,4,6,7")
							{
								league.Prestige = ELeaguePrestige.France;
								continue;
							}
							league.Prestige = ELeaguePrestige.Undefined;
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0004946C File Offset: 0x0004766C
		private bool FillFromLanguage()
		{
			foreach (object obj in this)
			{
				((Compobj)obj).FillFromLanguage();
			}
			return true;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000494C0 File Offset: 0x000476C0
		public bool FillFromCompetition(Table t)
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy())
				{
					((Trophy)compobj).FillFromCompetition(t);
				}
			}
			return true;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00049524 File Offset: 0x00047724
		private bool SaveToLanguage()
		{
			foreach (object obj in this)
			{
				((Compobj)obj).SaveToLanguage();
			}
			return true;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00049578 File Offset: 0x00047778
		private bool SaveToCompetition(Table t)
		{
			int num = 0;
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy() && ((Trophy)compobj).ballid >= 0)
				{
					num++;
				}
			}
			t.ResizeRecords(num);
			num = 0;
			foreach (object obj2 in this)
			{
				Compobj compobj2 = (Compobj)obj2;
				if (compobj2.IsTrophy())
				{
					Trophy trophy = (Trophy)compobj2;
					if (trophy.ballid >= 0)
					{
						Record record = t.Records[num];
						trophy.SaveCompetition(record);
						num++;
					}
				}
			}
			t.SortByKeys();
			return true;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00049664 File Offset: 0x00047864
		public string[] GetFceDescriptors()
		{
			int num = 0;
			string[] array = new string[256];
			if (FifaEnvironment.LangDb == null)
			{
				return null;
			}
			Table table = FifaEnvironment.LangDb.Table[0];
			if (table == null)
			{
				return null;
			}
			for (int i = 0; i < table.NRecords; i++)
			{
				string text = table.Records[i].CompressedString[FI.language_stringid];
				if (text.StartsWith("FCE_") && num < array.Length)
				{
					array[num++] = text;
				}
			}
			string[] array2 = new string[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[j];
			}
			return array2;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00049704 File Offset: 0x00047904
		private void CollectDescriptions()
		{
			CompobjList.s_Descriptions.Clear();
			string[] fceDescriptors = this.GetFceDescriptors();
			CompobjList.s_Descriptions.AddRange(fceDescriptors);
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsStage() && !compobj.Description.StartsWith("FCE_") && !CompobjList.s_Descriptions.Contains(compobj.Description))
				{
					CompobjList.s_Descriptions.Add(compobj.Description);
				}
			}
			CompobjList.s_Descriptions.Sort();
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x000497B4 File Offset: 0x000479B4
		public World World
		{
			get
			{
				foreach (object obj in this)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.IsWorld())
					{
						return (World)compobj;
					}
				}
				return null;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00049818 File Offset: 0x00047A18
		public void Save(string path, DbFile fifaDbFile)
		{
			this.Renumber();
			this.SaveToCompobj(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\compobj.txt");
			this.SaveToCompids(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\compids.txt");
			this.SaveToSettings(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\settings.txt");
			this.SaveToStandings(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\standings.txt");
			this.SaveToAdvancement(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\advancement.txt");
			this.SaveToSchedule(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\schedule.txt");
			this.SaveToWeather(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\weather.txt");
			this.SaveToTasks(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\tasks.txt");
			this.SaveToInitteams(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\initteams.txt");
			this.SaveToInternationals(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\internationals.txt");
			this.SaveToLanguage();
			Table table = fifaDbFile.Table[TI.competition];
			this.SaveToCompetition(table);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000498FC File Offset: 0x00047AFC
		public int Renumber()
		{
			if (this.World != null)
			{
				return this.World.Renumber(0);
			}
			return 0;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00049914 File Offset: 0x00047B14
		private bool SaveToCompobj(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToCompobj(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00049960 File Offset: 0x00047B60
		private bool SaveToCompids(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			if (!File.Exists(fileName))
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToCompids(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000499B4 File Offset: 0x00047BB4
		private bool SaveToSettings(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToSettings(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00049A00 File Offset: 0x00047C00
		private bool SaveToStandings(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToStandings(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00049A4C File Offset: 0x00047C4C
		private bool SaveToAdvancement(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToAdvancement(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00049A98 File Offset: 0x00047C98
		private bool SaveToSchedule(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToSchedule(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00049AE4 File Offset: 0x00047CE4
		private bool SaveToWeather(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToWeather(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00049B30 File Offset: 0x00047D30
		private bool SaveToInitteams(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToInitteams(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00049B7C File Offset: 0x00047D7C
		private bool SaveToInternationals(string fileName)
		{
			int num = 0;
			char[] array = new char[] { ',', '[', ']' };
			if (!File.Exists(fileName))
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamReader streamReader = new StreamReader(fileName + ".bak");
			if (streamReader == null)
			{
				return false;
			}
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 3)
				{
					if (array2[1] == "TIER_AND_OBJECTIVES")
					{
						streamWriter.WriteLine(text);
						num = 1;
						IEnumerator enumerator = FifaEnvironment.Countries.GetEnumerator(); using (enumerator as IDisposable)
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								Country country = (Country)obj;
								if (country.NationalTeam != null)
								{
									int level = country.Level;
									int id = country.Id;
									int id2 = country.NationalTeam.Id;
									int num2 = country.Confederation + 1;
									string text2 = this.CupTarget(country.WorldCupTarget);
									string text3 = this.CupTarget(country.ContinentalCupTarget);
									text = string.Concat(new string[]
									{
										level.ToString(),
										",",
										id.ToString(),
										",",
										id2.ToString(),
										",",
										num2.ToString(),
										",",
										text2,
										",",
										text2,
										",",
										text3,
										",",
										text3
									});
									streamWriter.WriteLine(text);
								}
							}
							continue;
						}
					}
					if (array2[1] == "LEAGUE_RANKINGS")
					{
						streamWriter.WriteLine("\r\n");
						streamWriter.WriteLine(text);
						num = 1;
						IEnumerator enumerator = FifaEnvironment.Leagues.GetEnumerator(); using (enumerator as IDisposable)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								League league = (League)obj2;
								text = league.Id.ToString() + ",";
								switch (league.Prestige)
								{
								case ELeaguePrestige.England_Spain_Germany_Italy:
									text += "1,2,3,4,7";
									break;
								case ELeaguePrestige.France:
									text += "2,3,4,6,7";
									break;
								case ELeaguePrestige.Argentina_Brazil:
									text += "2,4,5,6,7";
									break;
								case ELeaguePrestige.Russia_Portugal_Turkey:
									text += "3,5,6,7,7";
									break;
								case ELeaguePrestige.Holland:
									text += "4,5,6,7,7";
									break;
								case ELeaguePrestige.Mexico_England2:
									text += "4,6,7,7,7";
									break;
								case ELeaguePrestige.Belgium_Germany2_Colombia:
									text += "5,6,7,7,7";
									break;
								case ELeaguePrestige.USA_Chile:
									text += "5,6,7,7,-1";
									break;
								case ELeaguePrestige.Scotland_Italy2_Spain2:
									text += "5,6,7,-1,-1";
									break;
								case ELeaguePrestige.France2_Denmark_Norway_Switzerland:
									text += "6,7,-1,-1,-1";
									break;
								case ELeaguePrestige.Poland_Austria_Korea:
									text += "7,7,-1,-1,-1";
									break;
								case ELeaguePrestige.Australia_Sweden_England3_England4_Ireland:
									text += "7,-1,-1,-1,-1";
									break;
								}
								if (league.Prestige != ELeaguePrestige.Undefined)
								{
									streamWriter.WriteLine(text);
								}
							}
							continue;
						}
					}
					if (num == 1)
					{
						streamWriter.WriteLine();
						num = 2;
					}
				}
				if (num != 1)
				{
					streamWriter.WriteLine(text);
				}
			}
			streamReader.Close();
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00049F38 File Offset: 0x00048138
		private string CupTarget(int index)
		{
			switch (index)
			{
			case 1:
				return "WIN";
			case 2:
				return "FINAL";
			case 3:
				return "SEMI";
			case 4:
				return "QUARTER";
			case 5:
				return "KNOCKOUT";
			case 6:
				return "QUALIFY";
			}
			return "N/A";
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00049F94 File Offset: 0x00048194
		private bool SaveToTasks(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToTasks(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00049FE0 File Offset: 0x000481E0
		public void Link()
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy())
				{
					compobj.LinkLeague(FifaEnvironment.Leagues);
					compobj.LinkTeam(FifaEnvironment.Teams);
					compobj.LinkCompetitions();
				}
				if (compobj.IsNation())
				{
					compobj.LinkCountry(FifaEnvironment.Countries);
				}
				if (compobj.IsStage())
				{
					compobj.LinkStadium(FifaEnvironment.Stadiums);
					compobj.LinkCompetitions();
				}
				if (compobj.IsGroup())
				{
					compobj.LinkCompetitions();
				}
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0004A08C File Offset: 0x0004828C
		private void Normalize()
		{
			foreach (object obj in this)
			{
				((Compobj)obj).Normalize();
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0004A0E0 File Offset: 0x000482E0
		public Trophy SearchTrophy(int assetId)
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy() && compobj.Settings.m_asset_id == assetId)
				{
					return (Trophy)compobj;
				}
			}
			return null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0004A150 File Offset: 0x00048350
		public int GetInternationalFriendlyId()
		{
			foreach (object obj in this.Trophies)
			{
				Trophy trophy = (Trophy)obj;
				if (trophy.Settings.m_comp_type == "INTERFRIENDLY")
				{
					return trophy.Id;
				}
			}
			return -1;
		}

		// Token: 0x040010E6 RID: 4326
		private static string[] s_FileNames = new string[10];

		// Token: 0x040010E7 RID: 4327
		public static ArrayList s_Descriptions = new ArrayList();
	}
}
