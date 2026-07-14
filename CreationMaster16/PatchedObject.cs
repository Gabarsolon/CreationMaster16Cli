using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x0200000F RID: 15
	public class PatchedObject
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0002AF84 File Offset: 0x00029184
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0002AF8C File Offset: 0x0002918C
		public string Type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0002AF95 File Offset: 0x00029195
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0002AF9D File Offset: 0x0002919D
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0002AFA6 File Offset: 0x000291A6
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0002AFAE File Offset: 0x000291AE
		public int Id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0002AFB7 File Offset: 0x000291B7
		public int ImportId
		{
			get
			{
				return this.m_ImportId;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0002AFBF File Offset: 0x000291BF
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0002AFC7 File Offset: 0x000291C7
		public object ReplacedObject
		{
			get
			{
				return this.m_ReplacedObject;
			}
			set
			{
				this.m_ReplacedObject = value;
				if (this.IsUsedFittingObject() && this.m_ReplacedObject != null)
				{
					this.m_ImportId = ((IdObject)this.m_ReplacedObject).Id;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0002AFF6 File Offset: 0x000291F6
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0002AFFE File Offset: 0x000291FE
		public object NewObject
		{
			get
			{
				return this.m_NewObject;
			}
			set
			{
				this.m_NewObject = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0002B007 File Offset: 0x00029207
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0002B00F File Offset: 0x0002920F
		public object CmsObject
		{
			get
			{
				return this.m_CmsObject;
			}
			set
			{
				this.m_CmsObject = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0002B018 File Offset: 0x00029218
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0002B020 File Offset: 0x00029220
		public bool Imported
		{
			get
			{
				return this.m_Imported;
			}
			set
			{
				this.m_Imported = value;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002B02C File Offset: 0x0002922C
		public static void SetLanguageDataSet(DataSet langDataSet)
		{
			if (langDataSet.DataSetName == "LANG14" || langDataSet.DataSetName == "LANG15" || langDataSet.DataSetName == "LANG16")
			{
				DataTable dataTable = langDataSet.Tables["LanguageStrings"];
				PatchedObject.s_LangTable = null;
				if (dataTable != null)
				{
					PatchedObject.s_LangTable = new Table(FifaEnvironment.LangDb.Table[TI.lang].TableDescriptor);
					PatchedObject.s_LangTable.ConvertFromDataTable(dataTable);
					if (PatchedObject.s_LangTable != null)
					{
						PatchedObject.s_Language = new Language(PatchedObject.s_LangTable);
					}
				}
				return;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002B0CC File Offset: 0x000292CC
		private static DataRow ConvertDefaultDataRowFromPreviousFifa(DataRow previousFifaDataRow, DataRow fifaDataRow)
		{
			for (int i = 0; i < previousFifaDataRow.ItemArray.Length; i++)
			{
				string columnName = previousFifaDataRow.Table.Columns[i].ColumnName;
				if (fifaDataRow.Table.Columns.Contains(columnName))
				{
					fifaDataRow[columnName] = previousFifaDataRow[i];
				}
			}
			return fifaDataRow;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002B128 File Offset: 0x00029328
		public static void ConvertDataTableFromPreviousFifa(DataTable previousFifaDataTable)
		{
			foreach (object obj in previousFifaDataTable.Rows)
			{
				PatchedObject.ConvertDataRowFromPreviousFifa((DataRow)obj);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002B180 File Offset: 0x00029380
		public static void ConvertDataRowFromPreviousFifa(DataRow previousFifaDataRow)
		{
			string tableName = previousFifaDataRow.Table.TableName;
			tableName == "players";
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0002B1A8 File Offset: 0x000293A8
		public static void ConvertPlayersFromPreviousFifa(DataRow playersPreviousDataRow)
		{
			DataRow dataRow = PatchedObject.s_Fifa12DataSet.Tables["players"].NewRow();
			PatchedObject.ConvertDefaultDataRowFromPreviousFifa(playersPreviousDataRow, dataRow);
			Record record = new Record(FifaEnvironment.FifaDb.Table[TI.players].TableDescriptor);
			record.ConvertFromDataRow(dataRow);
			record.IntField[FI.players_playerid] = (int)playersPreviousDataRow["playerid"];
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0002B214 File Offset: 0x00029414
		public static bool SetFifaDataSet(DataSet fifaDataSet)
		{
			if (fifaDataSet.DataSetName == "FIFA16")
			{
				PatchedObject.s_FifaDataSet = fifaDataSet;
				PatchedObject.s_NationsTable = PatchedObject.ConvertTable("nations", TI.nations);
				PatchedObject.s_TeamsTable = PatchedObject.ConvertTable("teams", TI.teams);
				PatchedObject.s_TeamplayerlinksTable = PatchedObject.ConvertTable("teamplayerlinks", TI.teamplayerlinks);
				PatchedObject.s_TeamstadiumlinksTable = PatchedObject.ConvertTable("teamstadiumlinks", TI.teamstadiumlinks);
				PatchedObject.s_TeamformationteamstylelinkTable = PatchedObject.ConvertTable("teamformationteamstylelinks", TI.teamformationteamstylelinks);
				PatchedObject.s_StadiumassignmentsTable = PatchedObject.ConvertTable("stadiumassignments", TI.stadiumassignments);
				PatchedObject.s_ManagerTable = PatchedObject.ConvertTable("manager", TI.manager);
				PatchedObject.s_TeamkitsTable = PatchedObject.ConvertTable("teamkits", TI.teamkits);
				PatchedObject.s_RowteamnationlinksTable = PatchedObject.ConvertTable("rowteamnationlinks", TI.rowteamnationlinks);
				PatchedObject.s_TeamnationlinksTable = PatchedObject.ConvertTable("teamnationlinks", TI.teamnationlinks);
				PatchedObject.s_FormationsTable = PatchedObject.ConvertTable("formations", TI.formations);
				PatchedObject.s_LeaguesTable = PatchedObject.ConvertTable("leagues", TI.leagues);
				PatchedObject.s_BoardOutcomesTable = PatchedObject.ConvertTable("career_boardoutcomes", TI.career_boardoutcomes);
				PatchedObject.s_LeagueteamlinksTable = PatchedObject.ConvertTable("leagueteamlinks", TI.leagueteamlinks);
				PatchedObject.s_PlayersTable = PatchedObject.ConvertTable("players", TI.players);
				PatchedObject.s_RefereeTable = PatchedObject.ConvertTable("referee", TI.referee);
				PatchedObject.s_StadiumsTable = PatchedObject.ConvertTable("stadiums", TI.stadiums);
				PatchedObject.s_PlayernamesTable = PatchedObject.ConvertTable("playernames", TI.playernames);
				if (PatchedObject.s_PlayernamesTable != null && PatchedObject.s_PlayernamesTable.Records.Length != 0)
				{
					PatchedObject.s_PlayerNames = new PlayerNames(PatchedObject.s_PlayernamesTable);
				}
				return true;
			}
			if (fifaDataSet.DataSetName == "FIFA15" || fifaDataSet.DataSetName == "FIFA14")
			{
				PatchedObject.s_FifaDataSet = fifaDataSet;
				PatchedObject.s_NationsTable = PatchedObject.ConvertTable("nations", TI.nations);
				PatchedObject.s_TeamsTable = PatchedObject.ConvertTable("teams", TI.teams);
				PatchedObject.s_TeamplayerlinksTable = PatchedObject.ConvertTableFrom15To16("teamplayerlinks", TI.teamplayerlinks);
				PatchedObject.s_TeamstadiumlinksTable = PatchedObject.ConvertTable("teamstadiumlinks", TI.teamstadiumlinks);
				PatchedObject.s_TeamformationteamstylelinkTable = PatchedObject.ConvertTable("teamformationteamstylelinks", TI.teamformationteamstylelinks);
				PatchedObject.s_StadiumassignmentsTable = PatchedObject.ConvertTable("stadiumassignments", TI.stadiumassignments);
				PatchedObject.s_ManagerTable = PatchedObject.ConvertTable("manager", TI.manager);
				PatchedObject.s_TeamkitsTable = PatchedObject.ConvertTable("teamkits", TI.teamkits);
				PatchedObject.s_RowteamnationlinksTable = PatchedObject.ConvertTable("rowteamnationlinks", TI.rowteamnationlinks);
				PatchedObject.s_TeamnationlinksTable = PatchedObject.ConvertTable("teamnationlinks", TI.teamnationlinks);
				PatchedObject.s_FormationsTable = PatchedObject.ConvertTableFrom15To16("formations", TI.formations);
				PatchedObject.s_LeaguesTable = PatchedObject.ConvertTable("leagues", TI.leagues);
				PatchedObject.s_BoardOutcomesTable = PatchedObject.ConvertTable("career_boardoutcomes", TI.career_boardoutcomes);
				PatchedObject.s_LeagueteamlinksTable = PatchedObject.ConvertTableFrom15To16("leagueteamlinks", TI.leagueteamlinks);
				PatchedObject.s_PlayersTable = PatchedObject.ConvertTableFrom15To16("players", TI.players);
				PatchedObject.s_RefereeTable = PatchedObject.ConvertTableFrom15To16("referee", TI.referee);
				PatchedObject.s_StadiumsTable = PatchedObject.ConvertTableFrom15To16("stadiums", TI.stadiums);
				PatchedObject.s_PlayernamesTable = PatchedObject.ConvertTable("playernames", TI.playernames);
				if (PatchedObject.s_PlayernamesTable != null && PatchedObject.s_PlayernamesTable.Records.Length != 0)
				{
					PatchedObject.s_PlayerNames = new PlayerNames(PatchedObject.s_PlayernamesTable);
				}
				return true;
			}
			FifaEnvironment.UserMessages.ShowMessage(1032);
			return false;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0002B594 File Offset: 0x00029794
		private static void ConvertTablesFrom14to15()
		{
			if (PatchedObject.s_TeamsTable != null)
			{
				for (int i = 0; i < PatchedObject.s_TeamsTable.Records.Length; i++)
				{
					Record record = PatchedObject.s_TeamsTable.Records[i];
					record.IntField[FI.teams_rightfreekicktakerid] = record.IntField[FI.teams_freekicktakerid];
					record.IntField[FI.teams_leftfreekicktakerid] = record.IntField[FI.teams_freekicktakerid];
				}
			}
			if (PatchedObject.s_FormationsTable != null)
			{
				for (int j = 0; j < PatchedObject.s_FormationsTable.Records.Length; j++)
				{
					Record record2 = PatchedObject.s_FormationsTable.Records[j];
					int num = record2.IntField[FI.formations_position0];
					record2.IntField[FI.formations_playerinstruction0_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position1];
					record2.IntField[FI.formations_playerinstruction1_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position2];
					record2.IntField[FI.formations_playerinstruction2_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position3];
					record2.IntField[FI.formations_playerinstruction3_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position4];
					record2.IntField[FI.formations_playerinstruction4_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position5];
					record2.IntField[FI.formations_playerinstruction5_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position6];
					record2.IntField[FI.formations_playerinstruction6_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position7];
					record2.IntField[FI.formations_playerinstruction7_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position8];
					record2.IntField[FI.formations_playerinstruction8_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position9];
					record2.IntField[FI.formations_playerinstruction9_1] = PlayingRole.GetDefaultInstruction(num);
					num = record2.IntField[FI.formations_position10];
					record2.IntField[FI.formations_playerinstruction10_1] = PlayingRole.GetDefaultInstruction(num);
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002B784 File Offset: 0x00029984
		private static void ConvertTablesFrom15to16()
		{
			if (PatchedObject.s_TeamsTable != null)
			{
				for (int i = 0; i < PatchedObject.s_TeamsTable.Records.Length; i++)
				{
				}
			}
			if (PatchedObject.s_FormationsTable != null)
			{
				for (int j = 0; j < PatchedObject.s_FormationsTable.Records.Length; j++)
				{
					Record record = PatchedObject.s_FormationsTable.Records[j];
					int num = record.IntField[FI.formations_position0];
					record.IntField[FI.formations_playerinstruction0_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position1];
					record.IntField[FI.formations_playerinstruction1_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position2];
					record.IntField[FI.formations_playerinstruction2_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position3];
					record.IntField[FI.formations_playerinstruction3_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position4];
					record.IntField[FI.formations_playerinstruction4_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position5];
					record.IntField[FI.formations_playerinstruction5_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position6];
					record.IntField[FI.formations_playerinstruction6_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position7];
					record.IntField[FI.formations_playerinstruction7_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position8];
					record.IntField[FI.formations_playerinstruction8_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position9];
					record.IntField[FI.formations_playerinstruction9_1] = PlayingRole.GetDefaultInstruction(num);
					num = record.IntField[FI.formations_position10];
					record.IntField[FI.formations_playerinstruction10_1] = PlayingRole.GetDefaultInstruction(num);
				}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000104DD File Offset: 0x0000E6DD
		private static void ConvertTablesFrom15to14()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002B938 File Offset: 0x00029B38
		private static Table ConvertTable(string tableName, int tableIndex)
		{
			if (PatchedObject.s_FifaDataSet == null)
			{
				return null;
			}
			PatchedObject.s_FifaDataSet.Locale = new CultureInfo(CultureInfo.InvariantCulture.LCID);
			DataTable dataTable = PatchedObject.s_FifaDataSet.Tables[tableName];
			if (dataTable == null)
			{
				return null;
			}
			Table table = new Table(FifaEnvironment.FifaDb.Table[tableIndex].TableDescriptor);
			table.ConvertFromDataTable(dataTable);
			return table;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002B99C File Offset: 0x00029B9C
		private static Table ConvertTableFrom15To16(string tableName, int tableIndex)
		{
			if (PatchedObject.s_FifaDataSet == null)
			{
				return null;
			}
			PatchedObject.s_FifaDataSet.Locale = new CultureInfo(CultureInfo.InvariantCulture.LCID);
			DataTable dataTable = PatchedObject.s_FifaDataSet.Tables[tableName];
			if (dataTable == null)
			{
				return null;
			}
			Table table = new Table(FifaEnvironment.FifaDb.Table[tableIndex].TableDescriptor);
			table.ConvertFromDataTableFrom15To16(dataTable);
			return table;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002B9FE File Offset: 0x00029BFE
		private static DataTable ConvertDataTableFromPreviousFifa(string tableName, int tableIndex)
		{
			return PatchedObject.ConvertDataTableFromPreviousFifa(tableName, tableName, tableIndex);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0002BA08 File Offset: 0x00029C08
		private static DataTable ConvertDataTableFromPreviousFifa(string oldTableName, string newTableName, int newTableIndex)
		{
			if (PatchedObject.s_FifaDataSet == null)
			{
				return null;
			}
			if (!PatchedObject.s_Fifa12DataSet.Tables.Contains(newTableName))
			{
				return null;
			}
			DataTable dataTable = PatchedObject.s_FifaDataSet.Tables[oldTableName];
			PatchedObject.s_Fifa12DataSet.Tables[newTableName].Clear();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				DataRow dataRow2 = PatchedObject.s_Fifa12DataSet.Tables[newTableName].NewRow();
				PatchedObject.ConvertDefaultDataRowFromPreviousFifa(dataRow, dataRow2);
				PatchedObject.s_Fifa12DataSet.Tables[newTableName].Rows.Add(dataRow2);
			}
			return PatchedObject.s_Fifa12DataSet.Tables[newTableName];
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0002BAE4 File Offset: 0x00029CE4
		public static void Initialize()
		{
			PatchedObject.s_PlayerCount = 0;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0002BAEC File Offset: 0x00029CEC
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0002BAF4 File Offset: 0x00029CF4
		public PatchedObject.EUsedObject UsedObject
		{
			get
			{
				return this.m_UsedObject;
			}
			set
			{
				this.m_UsedObject = value;
				switch (this.m_UsedObject)
				{
				case PatchedObject.EUsedObject.UseCms:
					this.m_ImportId = ((IdObject)this.m_CmsObject).Id;
					return;
				case PatchedObject.EUsedObject.UseNew:
					this.m_ImportId = ((IdObject)this.m_NewObject).Id;
					return;
				case PatchedObject.EUsedObject.UseFitting:
					this.m_ImportId = ((IdObject)this.m_ReplacedObject).Id;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0002BB68 File Offset: 0x00029D68
		public bool IsUsedUndefinedObject()
		{
			return this.m_UsedObject == PatchedObject.EUsedObject.Undefined;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0002BB73 File Offset: 0x00029D73
		public bool IsUsedNewObject()
		{
			return this.m_UsedObject == PatchedObject.EUsedObject.UseNew;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0002BB7E File Offset: 0x00029D7E
		public bool IsUsedCmsObject()
		{
			return this.m_UsedObject == PatchedObject.EUsedObject.UseCms;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0002BB89 File Offset: 0x00029D89
		public bool IsUsedFittingObject()
		{
			return this.m_UsedObject == PatchedObject.EUsedObject.UseFitting;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0002BB94 File Offset: 0x00029D94
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0002BB9C File Offset: 0x00029D9C
		public bool IsCmsNew
		{
			get
			{
				return this.m_IsCmsNew;
			}
			set
			{
				this.m_IsCmsNew = value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0002BBA5 File Offset: 0x00029DA5
		private bool IsObjectUsedNew()
		{
			return this.m_UsedObject == PatchedObject.EUsedObject.UseNew || (this.m_UsedObject == PatchedObject.EUsedObject.UseCms && this.IsCmsNew);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0002BBC3 File Offset: 0x00029DC3
		public PatchedObject(string type, string name, int id)
		{
			this.m_Type = type;
			this.m_Name = name;
			this.m_Id = id;
			this.m_Imported = false;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0002BBE7 File Offset: 0x00029DE7
		public void UseReplacedObject()
		{
			this.UsedObject = PatchedObject.EUsedObject.UseFitting;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		public void UsePatchId()
		{
			this.UsedObject = PatchedObject.EUsedObject.UseCms;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0002BBF9 File Offset: 0x00029DF9
		public void UseNewObject()
		{
			if (this.m_NewObject != null)
			{
				this.UsedObject = PatchedObject.EUsedObject.UseNew;
				return;
			}
			if (this.AssignAutoNewObject())
			{
				this.UsedObject = PatchedObject.EUsedObject.UseNew;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0002BC1C File Offset: 0x00029E1C
		private void RemoveObject(object toBeRemovedObject)
		{
			if (this.m_Type == "Player")
			{
				FifaEnvironment.Players.RemoveId((Player)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "Team")
			{
				FifaEnvironment.Teams.RemoveId((Team)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "League")
			{
				FifaEnvironment.Leagues.RemoveId((League)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "Country")
			{
				FifaEnvironment.Countries.RemoveId((Country)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "Stadium")
			{
				FifaEnvironment.Stadiums.RemoveId((Stadium)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "Referee")
			{
				FifaEnvironment.Referees.RemoveId((Referee)toBeRemovedObject);
				return;
			}
			if (this.m_Type == "Formation")
			{
				FifaEnvironment.Formations.RemoveId((Formation)toBeRemovedObject);
				return;
			}
			if (!(this.m_Type == "Sponsor"))
			{
				if (this.m_Type == "Ball")
				{
					FifaEnvironment.Balls.RemoveId((Ball)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "Adboard")
				{
					FifaEnvironment.Adboards.RemoveId((Adboard)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "NumberFont")
				{
					FifaEnvironment.NumberFonts.RemoveId((NumberFont)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "NameFont")
				{
					FifaEnvironment.NameFonts.RemoveId((NameFont)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "Shoes")
				{
					FifaEnvironment.Shoes.RemoveId((Shoes)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "Net")
				{
					FifaEnvironment.Nets.RemoveId((Net)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "Grass")
				{
					FifaEnvironment.GkGloves.RemoveId((GkGloves)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "MowingPatterns")
				{
					FifaEnvironment.MowingPatterns.RemoveId((MowingPattern)toBeRemovedObject);
					return;
				}
				if (this.m_Type == "Kit")
				{
					FifaEnvironment.Kits.RemoveId((Kit)toBeRemovedObject);
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0002BE7D File Offset: 0x0002A07D
		public void RemoveNewObject()
		{
			if (this.m_NewObject != null)
			{
				this.RemoveObject(this.m_NewObject);
			}
			if (this.IsCmsNew && this.m_CmsObject != null)
			{
				this.RemoveObject(this.m_CmsObject);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		public void RemoveNewObjectIfUnused()
		{
			object usedObject = this.GetUsedObject();
			if (usedObject != this.m_NewObject && this.m_NewObject != null)
			{
				this.RemoveObject(this.m_NewObject);
			}
			if (usedObject != this.m_CmsObject && this.m_CmsObject != null && this.IsCmsNew)
			{
				this.RemoveObject(this.m_CmsObject);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0002BF04 File Offset: 0x0002A104
		public void RemoveNewObjectIfNotImported()
		{
			object usedObject = this.GetUsedObject();
			if (this.m_Imported)
			{
				if (usedObject != this.m_NewObject && this.m_NewObject != null)
				{
					this.RemoveObject(this.m_NewObject);
				}
				if (usedObject != this.m_CmsObject && this.m_CmsObject != null && this.IsCmsNew)
				{
					this.RemoveObject(this.m_CmsObject);
					return;
				}
			}
			else
			{
				if (this.m_NewObject != null)
				{
					this.RemoveObject(this.m_NewObject);
				}
				if (this.m_CmsObject != null && this.IsCmsNew)
				{
					this.RemoveObject(this.m_CmsObject);
				}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0002BF93 File Offset: 0x0002A193
		public Color GetColor()
		{
			if (!this.IsObjectUsedNew())
			{
				return Color.Red;
			}
			if (this.m_NewObject != null || this.m_CmsObject != null)
			{
				return Color.Green;
			}
			return Color.Gray;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0002BFBE File Offset: 0x0002A1BE
		private IdObject CreateNewObject()
		{
			return this.CreateNewObject(-1);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		private IdObject CreateNewObject(int id)
		{
			IdObject idObject = null;
			if (this.m_Type == "Player")
			{
				idObject = ((id == -1) ? FifaEnvironment.Players.CreateNewId() : FifaEnvironment.Players.CreateNewId(id));
			}
			else if (this.m_Type == "Team")
			{
				idObject = ((id == -1) ? FifaEnvironment.Teams.CreateNewId() : FifaEnvironment.Teams.CreateNewId(id));
			}
			else if (this.m_Type == "League")
			{
				idObject = ((id == -1) ? FifaEnvironment.Leagues.CreateNewId() : FifaEnvironment.Leagues.CreateNewId(id));
			}
			else if (this.m_Type == "Country")
			{
				idObject = ((id == -1) ? FifaEnvironment.Countries.CreateNewId() : FifaEnvironment.Countries.CreateNewId(id));
			}
			else if (this.m_Type == "Stadium")
			{
				idObject = ((id == -1) ? FifaEnvironment.Stadiums.CreateNewId() : FifaEnvironment.Stadiums.CreateNewId(id));
			}
			else if (this.m_Type == "Referee")
			{
				idObject = ((id == -1) ? FifaEnvironment.Referees.CreateNewId() : FifaEnvironment.Referees.CreateNewId(id));
			}
			else if (this.m_Type == "Formation")
			{
				idObject = FifaEnvironment.Formations.CreateNewId();
			}
			else if (this.m_Type == "Ball")
			{
				idObject = ((id == -1) ? FifaEnvironment.Balls.CreateNewId() : FifaEnvironment.Balls.CreateNewId(id));
			}
			else if (this.m_Type == "Adboard")
			{
				idObject = ((id == -1) ? FifaEnvironment.Adboards.CreateNewId() : FifaEnvironment.Adboards.CreateNewId(id));
			}
			else if (this.m_Type == "NumberFont")
			{
				idObject = ((id == -1) ? FifaEnvironment.NumberFonts.CreateNewId() : FifaEnvironment.NumberFonts.CreateNewId(id));
			}
			else if (this.m_Type == "NameFont")
			{
				idObject = ((id == -1) ? FifaEnvironment.NameFonts.CreateNewId() : FifaEnvironment.NameFonts.CreateNewId(id));
			}
			else if (this.m_Type == "Shoes")
			{
				idObject = ((id == -1) ? FifaEnvironment.Shoes.CreateNewId() : FifaEnvironment.Shoes.CreateNewId(id));
			}
			else if (this.m_Type == "Net")
			{
				idObject = ((id == -1) ? FifaEnvironment.Nets.CreateNewId() : FifaEnvironment.Nets.CreateNewId(id));
			}
			else if (this.m_Type == "GkGloves")
			{
				idObject = ((id == -1) ? FifaEnvironment.GkGloves.CreateNewId() : FifaEnvironment.GkGloves.CreateNewId(id));
			}
			else if (this.m_Type == "MowingPattern")
			{
				idObject = ((id == -1) ? FifaEnvironment.MowingPatterns.CreateNewId() : FifaEnvironment.MowingPatterns.CreateNewId(id));
			}
			else if (this.m_Type == "Kit")
			{
				idObject = FifaEnvironment.Kits.CreateNewId();
				int num = this.m_Id / 10;
				((Kit)idObject).teamid = num;
				((Kit)idObject).kittype = this.m_Id - 10 * num;
			}
			if (idObject == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(5043);
			}
			return idObject;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0002C31A File Offset: 0x0002A51A
		private bool AssignAutoNewObject()
		{
			if (this.IsCmsNew)
			{
				this.m_NewObject = this.m_CmsObject;
			}
			else
			{
				this.m_NewObject = this.CreateNewObject();
			}
			return this.m_NewObject != null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002C348 File Offset: 0x0002A548
		private bool AssignFittingObject()
		{
			if (this.m_Type == "Player")
			{
				this.m_ReplacedObject = FifaEnvironment.Players.FitPlayer(this.m_Name, this.m_Id);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Players.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Players[0];
				}
			}
			else if (this.m_Type == "Team")
			{
				this.m_ReplacedObject = FifaEnvironment.Teams.FitTeam(this.m_Name, this.m_Id);
				PatchedObject.s_LastLoadedTeamId = this.m_Id;
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Teams.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Teams[0];
				}
			}
			else if (this.m_Type == "League")
			{
				this.m_ReplacedObject = FifaEnvironment.Leagues.FitLeague(this.m_Name, this.m_Id);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Leagues.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Leagues[0];
				}
			}
			else if (this.m_Type == "Country")
			{
				this.m_ReplacedObject = FifaEnvironment.Countries.FitCountry(this.m_Name, this.m_Id);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Countries.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Countries[0];
				}
			}
			else if (this.m_Type == "Stadium")
			{
				this.m_ReplacedObject = FifaEnvironment.Stadiums.FitStadium(this.m_Name, this.m_Id);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Stadiums.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Stadiums[0];
				}
			}
			else if (this.m_Type == "Referee")
			{
				this.m_ReplacedObject = FifaEnvironment.Referees.FitReferee(this.m_Name, this.m_Id);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Referees.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Referees[0];
				}
			}
			else if (this.m_Type == "Formation")
			{
				this.m_ReplacedObject = FifaEnvironment.Formations.FitFormationByTeamId(PatchedObject.s_LastLoadedTeamId);
				if (this.m_ReplacedObject != null)
				{
					this.UsedObject = PatchedObject.EUsedObject.UseFitting;
				}
				if (this.m_ReplacedObject == null && FifaEnvironment.Formations.Count > 0)
				{
					this.m_ReplacedObject = FifaEnvironment.Formations[0];
				}
			}
			else if (!(this.m_Type == "Sponsor"))
			{
				if (this.m_Type == "Kit")
				{
					this.m_ReplacedObject = FifaEnvironment.Kits.FitKit(this.m_Name, this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.Kits.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.Kits[0];
					}
				}
				else if (this.m_Type == "Ball")
				{
					this.m_ReplacedObject = FifaEnvironment.Balls.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.Balls.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.Balls[0];
					}
				}
				else if (this.m_Type == "Adboard")
				{
					this.m_ReplacedObject = FifaEnvironment.Adboards.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.Adboards.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.Adboards[0];
					}
				}
				else if (this.m_Type == "NumberFont")
				{
					this.m_ReplacedObject = FifaEnvironment.NumberFonts.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.NumberFonts.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.NumberFonts[0];
					}
				}
				else if (this.m_Type == "NameFont")
				{
					this.m_ReplacedObject = FifaEnvironment.NameFonts.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.NameFonts.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.NameFonts[0];
					}
				}
				else if (this.m_Type == "Shoes")
				{
					this.m_ReplacedObject = FifaEnvironment.Shoes.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.Shoes.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.Shoes[0];
					}
				}
				else if (this.m_Type == "Net")
				{
					this.m_ReplacedObject = FifaEnvironment.Nets.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.Nets.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.Nets[0];
					}
				}
				else if (this.m_Type == "GkGloves")
				{
					this.m_ReplacedObject = FifaEnvironment.GkGloves.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.GkGloves.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.GkGloves[0];
					}
				}
				else if (this.m_Type == "MowingPattern")
				{
					this.m_ReplacedObject = FifaEnvironment.MowingPatterns.SearchId(this.m_Id);
					if (this.m_ReplacedObject != null)
					{
						this.UsedObject = PatchedObject.EUsedObject.UseFitting;
					}
					if (this.m_ReplacedObject == null && FifaEnvironment.MowingPatterns.Count > 0)
					{
						this.m_ReplacedObject = FifaEnvironment.MowingPatterns[0];
					}
				}
			}
			return this.m_ReplacedObject != null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0002CA14 File Offset: 0x0002AC14
		public bool AssignCmsReplacedObject()
		{
			if (this.m_Type == "Player")
			{
				this.m_CmsObject = FifaEnvironment.Players.SearchId(this.Id);
			}
			else if (this.m_Type == "Team")
			{
				this.m_CmsObject = FifaEnvironment.Teams.SearchId(this.Id);
			}
			else if (this.m_Type == "League")
			{
				this.m_CmsObject = FifaEnvironment.Leagues.SearchId(this.Id);
			}
			else if (this.m_Type == "Country")
			{
				this.m_CmsObject = FifaEnvironment.Countries.SearchId(this.Id);
			}
			else if (this.m_Type == "Stadium")
			{
				this.m_CmsObject = FifaEnvironment.Stadiums.SearchId(this.Id);
			}
			else if (this.m_Type == "Referee")
			{
				this.m_CmsObject = FifaEnvironment.Referees.SearchId(this.Id);
			}
			else if (this.m_Type == "Formation")
			{
				if (((Formation)this.m_ReplacedObject).teamid >= 1)
				{
					this.m_CmsObject = this.m_ReplacedObject;
				}
				else
				{
					this.m_CmsObject = null;
				}
			}
			else if (this.m_Type == "Ball")
			{
				this.m_CmsObject = FifaEnvironment.Balls.SearchId(this.Id);
			}
			else if (this.m_Type == "Adboard")
			{
				this.m_CmsObject = FifaEnvironment.Adboards.SearchId(this.Id);
			}
			else if (this.m_Type == "NumberFont")
			{
				this.m_CmsObject = FifaEnvironment.NumberFonts.SearchId(this.Id);
			}
			else if (this.m_Type == "NameFont")
			{
				this.m_CmsObject = FifaEnvironment.NameFonts.SearchId(this.Id);
			}
			else if (this.m_Type == "Shoes")
			{
				this.m_CmsObject = FifaEnvironment.Shoes.SearchId(this.Id);
			}
			else if (this.m_Type == "Net")
			{
				this.m_CmsObject = FifaEnvironment.Nets.SearchId(this.Id);
			}
			else if (this.m_Type == "GkGloves")
			{
				this.m_CmsObject = FifaEnvironment.GkGloves.SearchId(this.Id);
			}
			else if (this.m_Type == "MowingPattern")
			{
				this.m_CmsObject = FifaEnvironment.MowingPatterns.SearchId(this.Id);
			}
			else if (this.m_Type == "Kit")
			{
				this.m_CmsObject = null;
			}
			this.IsCmsNew = this.m_CmsObject == null;
			this.m_UsedObject = PatchedObject.EUsedObject.UseCms;
			return !this.IsCmsNew;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002CD08 File Offset: 0x0002AF08
		public bool AssignNewCmsObject()
		{
			if (this.IsCmsNew)
			{
				this.m_CmsObject = this.CreateNewObject(this.Id);
			}
			if (this.m_CmsObject != null)
			{
				this.UsedObject = PatchedObject.EUsedObject.UseCms;
			}
			return this.m_CmsObject != null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0002CD3C File Offset: 0x0002AF3C
		public void AssignReplacedObject()
		{
			this.AssignFittingObject();
			this.AssignCmsReplacedObject();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0002CD4C File Offset: 0x0002AF4C
		public void AssignNewObject()
		{
			if (this.IsUsedUndefinedObject() && this.AssignAutoNewObject())
			{
				this.UsedObject = PatchedObject.EUsedObject.UseNew;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0002CD68 File Offset: 0x0002AF68
		public object GetUsedObject()
		{
			switch (this.UsedObject)
			{
			case PatchedObject.EUsedObject.UseCms:
				return this.m_CmsObject;
			case PatchedObject.EUsedObject.UseFitting:
				return this.m_ReplacedObject;
			}
			return this.m_NewObject;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		public string GetObjectType()
		{
			switch (this.UsedObject)
			{
			case PatchedObject.EUsedObject.UseCms:
				return this.m_CmsObject.GetType().Name;
			case PatchedObject.EUsedObject.UseNew:
				return this.m_NewObject.GetType().Name;
			case PatchedObject.EUsedObject.UseFitting:
				return this.m_ReplacedObject.GetType().Name;
			default:
				return null;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0002CE08 File Offset: 0x0002B008
		public Player ImportWebPlayer(DataRow webData, Team importingTeam)
		{
			Player player = (Player)this.GetUsedObject();
			bool flag = this.IsObjectUsedNew();
			player.commonname = webData["commonname"].ToString();
			if (player.commonname != string.Empty)
			{
				if (webData["firstname"].ToString() != string.Empty)
				{
					player.firstname = webData["firstname"].ToString();
				}
				if (webData["lastname"].ToString() != string.Empty)
				{
					player.lastname = webData["lastname"].ToString();
				}
				Player player2 = player;
				player2.playerjerseyname = player2.commonname;
			}
			else
			{
				player.firstname = webData["firstname"].ToString();
				player.lastname = webData["lastname"].ToString();
				Player player3 = player;
				player3.playerjerseyname = player3.lastname;
			}
			string text = webData["birthdate"].ToString().Replace("\t", "");
			if (text != string.Empty)
			{
				try
				{
					DateTime dateTime = FifaUtil.ConvertToDate(text);
					player.birthdate = dateTime;
				}
				catch
				{
				}
			}
			if (player.birthdate.Year == 1)
			{
				return null;
			}
			if (webData["height"].ToString() != string.Empty)
			{
				try
				{
					player.height = Convert.ToInt32(webData["height"].ToString());
				}
				catch
				{
				}
			}
			if (webData["weight"].ToString() != string.Empty)
			{
				try
				{
					player.weight = Convert.ToInt32(webData["weight"].ToString());
				}
				catch
				{
				}
			}
			if (webData["country"].ToString() != string.Empty)
			{
				try
				{
					Country country = FifaEnvironment.Countries.SearchCountryByDatabaseName(webData["country"].ToString());
					if (country != null)
					{
						player.Country = country;
					}
				}
				catch
				{
				}
			}
			if (webData["role"].ToString() != string.Empty)
			{
				try
				{
					string text2 = webData["role"].ToString();
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
					if (num <= 2583355998U)
					{
						if (num <= 832685564U)
						{
							if (num <= 288805942U)
							{
								if (num != 11022654U)
								{
									if (num != 280303765U)
									{
										if (num != 288805942U)
										{
											goto IL_0799;
										}
										if (!(text2 == "Defence - Right-Back"))
										{
											goto IL_0799;
										}
									}
									else
									{
										if (!(text2 == "Right Midfield"))
										{
											goto IL_0799;
										}
										goto IL_0755;
									}
								}
								else
								{
									if (!(text2 == "Centre-Back"))
									{
										goto IL_0799;
									}
									goto IL_0726;
								}
							}
							else if (num <= 389230065U)
							{
								if (num != 294475028U)
								{
									if (num != 389230065U)
									{
										goto IL_0799;
									}
									if (!(text2 == "Secondary Striker"))
									{
										goto IL_0799;
									}
									goto IL_0791;
								}
								else
								{
									if (!(text2 == "Striker - Left Wing"))
									{
										goto IL_0799;
									}
									goto IL_0773;
								}
							}
							else if (num != 766865887U)
							{
								if (num != 832685564U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Midfielder"))
								{
									goto IL_0799;
								}
								goto IL_074B;
							}
							else
							{
								if (!(text2 == "Keeper"))
								{
									goto IL_0799;
								}
								goto IL_071D;
							}
						}
						else if (num <= 1528885251U)
						{
							if (num <= 1138346864U)
							{
								if (num != 1078963746U)
								{
									if (num != 1138346864U)
									{
										goto IL_0799;
									}
									if (!(text2 == "Left-Back"))
									{
										goto IL_0799;
									}
									goto IL_072F;
								}
								else
								{
									if (!(text2 == "Left - Back"))
									{
										goto IL_0799;
									}
									goto IL_072F;
								}
							}
							else if (num != 1343432955U)
							{
								if (num != 1528885251U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Right-Back"))
								{
									goto IL_0799;
								}
							}
							else
							{
								if (!(text2 == "Left Wing"))
								{
									goto IL_0799;
								}
								goto IL_0773;
							}
						}
						else if (num <= 1720979454U)
						{
							if (num != 1711405095U)
							{
								if (num != 1720979454U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Centre-Forward"))
								{
									goto IL_0799;
								}
								goto IL_0787;
							}
							else
							{
								if (!(text2 == "Midfield"))
								{
									goto IL_0799;
								}
								goto IL_074B;
							}
						}
						else if (num != 1849509725U)
						{
							if (num != 2583355998U)
							{
								goto IL_0799;
							}
							if (!(text2 == "Left Midfield"))
							{
								goto IL_0799;
							}
							goto IL_075F;
						}
						else
						{
							if (!(text2 == "Striker - Right Wing"))
							{
								goto IL_0799;
							}
							goto IL_077D;
						}
						player.preferredposition1 = 3;
						goto IL_0799;
						IL_0773:
						player.preferredposition1 = 27;
						goto IL_0799;
					}
					if (num <= 3702370312U)
					{
						if (num <= 3329873125U)
						{
							if (num <= 2949383079U)
							{
								if (num != 2774676816U)
								{
									if (num != 2949383079U)
									{
										goto IL_0799;
									}
									if (!(text2 == "Striker"))
									{
										goto IL_0799;
									}
									goto IL_0787;
								}
								else
								{
									if (!(text2 == "Right Wing"))
									{
										goto IL_0799;
									}
									goto IL_077D;
								}
							}
							else if (num != 3127865362U)
							{
								if (num != 3329873125U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Midfield - Defensive Midfield"))
								{
									goto IL_0799;
								}
							}
							else
							{
								if (!(text2 == "Striker - Secondary Striker"))
								{
									goto IL_0799;
								}
								goto IL_0791;
							}
						}
						else if (num <= 3618469369U)
						{
							if (num != 3538832922U)
							{
								if (num != 3618469369U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Midfield - Central Midfield"))
								{
									goto IL_0799;
								}
								goto IL_074B;
							}
							else
							{
								if (!(text2 == "Defender"))
								{
									goto IL_0799;
								}
								goto IL_0726;
							}
						}
						else if (num != 3698293435U)
						{
							if (num != 3702370312U)
							{
								goto IL_0799;
							}
							if (!(text2 == "Goalkeeper"))
							{
								goto IL_0799;
							}
							goto IL_071D;
						}
						else
						{
							if (!(text2 == "Attacking Midfield"))
							{
								goto IL_0799;
							}
							goto IL_0769;
						}
					}
					else if (num <= 3869853720U)
					{
						if (num <= 3756183648U)
						{
							if (num != 3746951757U)
							{
								if (num != 3756183648U)
								{
									goto IL_0799;
								}
								if (!(text2 == "Central Midfield"))
								{
									goto IL_0799;
								}
								goto IL_074B;
							}
							else
							{
								if (!(text2 == "Defence - Centre-Back"))
								{
									goto IL_0799;
								}
								goto IL_0726;
							}
						}
						else if (num != 3768987583U)
						{
							if (num != 3869853720U)
							{
								goto IL_0799;
							}
							if (!(text2 == "Defensive Midfield"))
							{
								goto IL_0799;
							}
						}
						else
						{
							if (!(text2 == "Striker - Centre-Forward"))
							{
								goto IL_0799;
							}
							goto IL_0787;
						}
					}
					else if (num <= 3937777075U)
					{
						if (num != 3910001169U)
						{
							if (num != 3937777075U)
							{
								goto IL_0799;
							}
							if (!(text2 == "Defence - Left-Back"))
							{
								goto IL_0799;
							}
							goto IL_072F;
						}
						else
						{
							if (!(text2 == "Midfield - Left Midfield"))
							{
								goto IL_0799;
							}
							goto IL_075F;
						}
					}
					else if (num != 4205337568U)
					{
						if (num != 4285640490U)
						{
							goto IL_0799;
						}
						if (!(text2 == "Midfield - Attacking Midfield"))
						{
							goto IL_0799;
						}
						goto IL_0769;
					}
					else
					{
						if (!(text2 == "Midfield - Right Midfield"))
						{
							goto IL_0799;
						}
						goto IL_0755;
					}
					player.preferredposition1 = 10;
					goto IL_0799;
					IL_0769:
					player.preferredposition1 = 18;
					goto IL_0799;
					IL_071D:
					player.preferredposition1 = 0;
					goto IL_0799;
					IL_0726:
					player.preferredposition1 = 5;
					goto IL_0799;
					IL_072F:
					player.preferredposition1 = 7;
					goto IL_0799;
					IL_074B:
					player.preferredposition1 = 14;
					goto IL_0799;
					IL_0755:
					player.preferredposition1 = 12;
					goto IL_0799;
					IL_075F:
					player.preferredposition1 = 16;
					goto IL_0799;
					IL_077D:
					player.preferredposition1 = 23;
					goto IL_0799;
					IL_0787:
					player.preferredposition1 = 25;
					goto IL_0799;
					IL_0791:
					player.preferredposition1 = 21;
					IL_0799:;
				}
				catch
				{
				}
			}
			if (webData["foot"].ToString() != string.Empty)
			{
				try
				{
					string text2 = webData["foot"].ToString();
					if (!(text2 == "both"))
					{
						if (!(text2 == "left"))
						{
							if (text2 == "right" || text2 == "-")
							{
								player.preferredfoot = 0;
								player.weakfootabilitytypecode = 3;
							}
						}
						else
						{
							player.preferredfoot = 1;
							player.weakfootabilitytypecode = 3;
						}
					}
					else
					{
						player.preferredfoot = 1;
						player.weakfootabilitytypecode = 5;
					}
				}
				catch
				{
				}
			}
			if (webData["since"].ToString() != string.Empty)
			{
				DateTime dateTime2 = new DateTime(2017, 7, 1);
				try
				{
					if (!webData["since"].ToString().Contains('-'))
					{
						dateTime2 = FifaUtil.ConvertToDate(webData["since"].ToString());
					}
				}
				catch
				{
				}
				player.joindate = dateTime2;
			}
			bool flag2 = true;
			if (webData["contract"].ToString() != string.Empty && webData["contract"].ToString() != "-")
			{
				try
				{
					player.contractvaliduntil = FifaUtil.ConvertToDate(webData["contract"].ToString()).Year;
					flag2 = false;
				}
				catch
				{
				}
			}
			if (flag2)
			{
				DateTime joindate = player.joindate;
				int num2 = Convert.ToInt32(webData["age"].ToString());
				Player player4 = player;
				player4.contractvaliduntil = player4.joindate.Year + 2;
				if (num2 <= 21)
				{
					player.contractvaliduntil += 3;
				}
				else if (num2 <= 24)
				{
					player.contractvaliduntil += 2;
				}
				else if (num2 <= 27)
				{
					player.contractvaliduntil++;
				}
				if (player.contractvaliduntil < 2018)
				{
					player.contractvaliduntil = 2018;
				}
			}
			if (webData["previousteam"].ToString() != string.Empty)
			{
				try
				{
					Team team = FifaEnvironment.Teams.MatchByname(webData["previousteam"].ToString());
					if (team != null && team != importingTeam)
					{
						player.PreviousTeam = team;
					}
				}
				catch
				{
				}
			}
			if (webData["loanedfrom"].ToString() != string.Empty)
			{
				try
				{
					Team team2 = FifaEnvironment.Teams.MatchByname(webData["loanedfrom"].ToString());
					if (team2 != null)
					{
						player.TeamLoanedFrom = team2;
						player.IsLoaned = true;
					}
					goto IL_0A4C;
				}
				catch
				{
					goto IL_0A4C;
				}
			}
			if (player.IsLoaned)
			{
				player.TeamLoanedFrom = null;
				player.IsLoaned = false;
			}
			IL_0A4C:
			if (webData["loanenddate"].ToString() != string.Empty)
			{
				try
				{
					DateTime dateTime3 = FifaUtil.ConvertToDate(webData["loanenddate"].ToString());
					player.loandateend = dateTime3;
					if (player.contractvaliduntil <= player.loandateend.Year)
					{
						player.contractvaliduntil++;
					}
				}
				catch
				{
				}
			}
			if (webData["number"].ToString() != string.Empty)
			{
				try
				{
					int num3 = Convert.ToInt32(webData["number"].ToString());
					player.preferredNumber = num3;
				}
				catch
				{
				}
			}
			if (flag)
			{
				float num4 = 0.025f;
				if (webData["marketvalue"].ToString() != string.Empty && !webData["marketvalue"].ToString().Contains('-'))
				{
					string text3 = webData["marketvalue"].ToString();
					int num5 = text3.IndexOf(' ');
					string text4 = text3.Substring(0, num5);
					string text5 = text3.Substring(num5 + 1, 1);
					try
					{
						num4 = Convert.ToSingle(text4);
					}
					catch
					{
						text4 = text4.Replace(',', '.');
						num4 = Convert.ToSingle(text4);
					}
					if (text5 == "T")
					{
						num4 /= 1000f;
					}
					else
					{
						text5 == "M";
					}
				}
				int num6 = Convert.ToInt32(webData["age"].ToString());
				int num7 = player.EstimateSkills(num4, num6, (ERole)player.preferredposition1);
				player.RandomizeSkillsAround(num7, 2);
				if (webData["weight"].ToString() == string.Empty)
				{
					player.RandomizeWeight();
				}
				player.EstimateBody();
				Player player5 = FifaEnvironment.Players.FindSimilarPlayer(player.Country, player.birthdate);
				if (player5 != null)
				{
					player.RandomizeAppearanceSimilarTo(player5);
				}
			}
			this.m_Imported = true;
			return player;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0002DB8C File Offset: 0x0002BD8C
		private int EstimateSkills(int age, int marketValue, ERole role)
		{
			if (age <= 19 || age <= 22 || age <= 25 || age <= 27 || age > 30)
			{
			}
			return 60;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0002DBB0 File Offset: 0x0002BDB0
		public Team ImportWebTeam(DataRow webData)
		{
			Team team = (Team)this.GetUsedObject();
			bool flag = this.IsObjectUsedNew();
			team.DatabaseName = webData["name"].ToString();
			if (flag)
			{
				if (webData["name"].ToString() != string.Empty)
				{
					Team team2 = team;
					team2.TeamNameFull = team2.DatabaseName;
					Team team3 = team;
					team3.SetNameAutomatically(team3.TeamNameFull, 15);
					Team team4 = team;
					team4.SetNameAutomatically(team4.TeamNameAbbr15, 10);
					Team team5 = team;
					team5.SetNameAutomatically(team5.TeamNameAbbr10, 7);
					Team team6 = team;
					team6.SetNameAutomatically(team6.TeamNameAbbr7, 3);
				}
				team.Formation = FifaEnvironment.Formations.CreateNewFormation();
				team.Formation.Team = team;
			}
			if (webData["stadium"].ToString() != string.Empty)
			{
				try
				{
					team.stadiumcustomname = webData["stadium"].ToString();
				}
				catch
				{
				}
			}
			this.m_Imported = true;
			return team;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		public void Import()
		{
			if (this.m_Type == "Player")
			{
				this.ImportPlayer();
				return;
			}
			if (this.m_Type == "Team")
			{
				this.ImportTeam();
				return;
			}
			if (this.m_Type == "League")
			{
				this.ImportLeague();
				return;
			}
			if (this.m_Type == "Country")
			{
				this.ImportCountry();
				return;
			}
			if (this.m_Type == "Stadium")
			{
				this.ImportStadium();
				return;
			}
			if (this.m_Type == "Referee")
			{
				this.ImportReferee();
				return;
			}
			if (this.m_Type == "Formation")
			{
				this.ImportFormation();
				return;
			}
			if (this.m_Type == "Ball")
			{
				this.ImportBall();
				return;
			}
			if (this.m_Type == "Adboard")
			{
				this.ImportAdboard();
				return;
			}
			if (this.m_Type == "NumberFont")
			{
				this.ImportNumberFont();
				return;
			}
			if (this.m_Type == "NameFont")
			{
				this.ImportNameFont();
				return;
			}
			if (this.m_Type == "Shoes")
			{
				this.ImportShoes();
				return;
			}
			if (this.m_Type == "Net")
			{
				this.ImportNet();
				return;
			}
			if (this.m_Type == "MowingPattern")
			{
				this.ImportMowingPattern();
				return;
			}
			if (this.m_Type == "Kit")
			{
				this.ImportKit();
				return;
			}
			if (this.m_Type == "GkGloves")
			{
				this.ImportGkGloves();
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0002DE4C File Offset: 0x0002C04C
		private void ImportKit()
		{
			Kit kit = (Kit)this.GetUsedObject();
			if (kit == null)
			{
				return;
			}
			int num = this.m_Id / 10;
			int num2 = this.m_Id - 10 * num;
			if (MainForm.m_PatchLoaderForm.checkKits.Checked)
			{
				if (PatchedObject.s_TeamkitsTable != null)
				{
					Record[] records = PatchedObject.s_TeamkitsTable.Records;
					int i = 0;
					while (i < records.Length)
					{
						Record record = records[i];
						if (record.IntField[FI.teamkits_teamtechid] == num && record.IntField[FI.teamkits_teamkittypetechid] == num2)
						{
							kit.Load(record);
							kit.Id = this.m_ImportId;
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								kit.teamid = MainForm.m_PatchLoaderForm.CrossReference("Team", num);
							}
							kit.LinkTeam(FifaEnvironment.Teams);
							if (kit.Team != null)
							{
								kit.Team.m_KitList.Add(kit);
								kit.Team.LinkKits(FifaEnvironment.Kits);
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
				string text = Kit.KitTextureFileName(num, kit.kittype, 0);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					kit.SetKitTextures(text);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkMinikits.Checked)
			{
				string text2 = Kit.MiniKitDdsFileName(num, kit.kittype, 0);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					Bitmap bitmapFromDdsFile = FifaEnvironment.GetBitmapFromDdsFile(text2);
					kit.SetMiniKit(bitmapFromDdsFile);
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		private void ImportStadium()
		{
			Stadium stadium = (Stadium)this.GetUsedObject();
			if (stadium == null)
			{
				return;
			}
			if (MainForm.m_PatchLoaderForm.checkStadiumDatabase.Checked)
			{
				if (PatchedObject.s_StadiumsTable != null)
				{
					foreach (Record record in PatchedObject.s_StadiumsTable.Records)
					{
						if (record.IntField[FI.stadiums_stadiumid] == this.m_Id)
						{
							stadium.Load(record);
							Stadium stadium2 = stadium;
							stadium2.LocalName = stadium2.name;
							if (PatchedObject.s_CountryCrossReferenceRequired)
							{
								stadium.countrycode = MainForm.m_PatchLoaderForm.CrossReference("Country", record.IntField[FI.stadiums_countrycode]);
							}
							stadium.LinkCountry(FifaEnvironment.Countries);
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								stadium.hometeamid = MainForm.m_PatchLoaderForm.CrossReference("Team", stadium.hometeamid);
							}
							stadium.LinkTeam(FifaEnvironment.Teams);
							break;
						}
					}
				}
				this.m_Imported = true;
			}
			if (MainForm.m_PatchLoaderForm.checkStadiumPreview.Checked)
			{
				for (int j = 0; j <= 4; j++)
				{
					if (j != 2)
					{
						string text = Stadium.PreviewBigFileName(this.m_Id, j);
						text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
						if (File.Exists(text))
						{
							Bitmap bitmapFromBigFile = FifaEnvironment.GetBitmapFromBigFile(text);
							stadium.SetPreview(j, bitmapFromBigFile);
						}
						text = Stadium.PreviewLargeBigFileName(this.m_Id, j);
						text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
						if (File.Exists(text))
						{
							Bitmap bitmapFromBigFile2 = FifaEnvironment.GetBitmapFromBigFile(text);
							stadium.SetPreviewLarge(j, bitmapFromBigFile2);
						}
					}
				}
			}
			if (MainForm.m_PatchLoaderForm.checkStadiumModel.Checked)
			{
				string text2 = Stadium.ModelFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					stadium.SetModel(text2);
				}
				text2 = Stadium.RadiosityFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					stadium.SetRadiosity(text2);
				}
				for (int k = 0; k <= 4; k++)
				{
					if (k != 2)
					{
						text2 = Stadium.TexturesFileName(this.m_Id, k);
						text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
						if (File.Exists(text2))
						{
							stadium.SetTextures(k, text2);
						}
						text2 = Stadium.CrowdFileName(this.m_Id, k);
						text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
						if (File.Exists(text2))
						{
							stadium.SetCrowd(k, text2);
						}
						string[] array = Stadium.GlaresLightFileNames(this.m_Id, k);
						for (int l = 0; l < array.Length; l++)
						{
							array[l] = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + array[l];
						}
						stadium.SetGlaresLight(array, k);
					}
				}
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0002E2EC File Offset: 0x0002C4EC
		private void ImportPlayer()
		{
			Player player = (Player)this.GetUsedObject();
			if (player == null)
			{
				return;
			}
			if (PatchedObject.s_PlayersTable != null)
			{
				if (PatchedObject.s_PlayerCount >= PatchedObject.s_PlayersTable.Records.Length)
				{
					PatchedObject.s_PlayerCount = 0;
				}
				int num = PatchedObject.s_PlayerCount;
				for (int i = 0; i < PatchedObject.s_PlayersTable.Records.Length; i++)
				{
					Record record = PatchedObject.s_PlayersTable.Records[num];
					if (record.IntField[FI.players_playerid] == this.m_Id)
					{
						PatchedObject.s_PlayerCount = num + 1;
						player.Load(record);
						if (PatchedObject.s_PlayerNames != null)
						{
							string text;
							player.firstname = (PatchedObject.s_PlayerNames.TryGetValue(player.firstnameid, out text, true) ? text : string.Empty);
							player.lastname = (PatchedObject.s_PlayerNames.TryGetValue(player.lastnameid, out text, true) ? text : string.Empty);
							player.commonname = (PatchedObject.s_PlayerNames.TryGetValue(player.commonnameid, out text, true) ? text : string.Empty);
							player.playerjerseyname = (PatchedObject.s_PlayerNames.TryGetValue(player.playerjerseynameid, out text, true) ? text : string.Empty);
						}
						else
						{
							player.firstname = string.Empty;
							player.lastname = "Player " + player.Id.ToString();
							player.commonname = string.Empty;
							player.playerjerseyname = string.Empty;
						}
						if (PatchedObject.s_ShoesCrossReferenceRequired)
						{
							player.shoetypecode = MainForm.m_PatchLoaderForm.CrossReference("Shoes", player.shoetypecode);
						}
						if (PatchedObject.s_CountryCrossReferenceRequired)
						{
							player.nationality = MainForm.m_PatchLoaderForm.CrossReference("Country", player.nationality);
						}
						player.LinkCountry(FifaEnvironment.Countries);
						player.IsLoaned = false;
						break;
					}
					num++;
					if (num == PatchedObject.s_PlayersTable.Records.Length)
					{
						num = 0;
					}
				}
			}
			if (MainForm.m_PatchLoaderForm.checkPlayerHead.Checked)
			{
				string text2;
				if (FifaEnvironment.Year == 14)
				{
					text2 = Player.SpecificEyesTextureFileName(this.m_Id);
					text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
					if (File.Exists(text2))
					{
						player.SetEyesTextures(text2);
					}
				}
				text2 = Player.SpecificFaceTextureFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					player.SetFaceTextures(text2);
					if (FifaEnvironment.Year == 15)
					{
						player.ConvertFaceTexturesFrom15To16();
					}
				}
				text2 = Player.SpecificHeadModelFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					player.SetHeadModel(text2);
				}
				text2 = Player.SpecificHairTexturesFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					player.SetHairTextures(text2);
				}
				text2 = Player.SpecificHairModelFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					player.SetHairModel(text2);
				}
				text2 = Player.SpecificHairLodModelFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					player.SetHairLodModel(text2);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkPlayerMiniface.Checked)
			{
				string text2 = Player.SpecificPhotoDdsFileName(this.m_Id);
				text2 = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text2;
				if (File.Exists(text2))
				{
					Bitmap bitmapFromDdsFile = FifaEnvironment.GetBitmapFromDdsFile(text2);
					player.SetPhoto(bitmapFromDdsFile);
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0002E67C File Offset: 0x0002C87C
		private void ImportTeam()
		{
			Team team = (Team)this.GetUsedObject();
			if (team == null)
			{
				return;
			}
			if (MainForm.m_PatchLoaderForm.checkTeamDatabase.Checked)
			{
				if (PatchedObject.s_TeamsTable != null)
				{
					Record[] array = PatchedObject.s_TeamsTable.Records;
					int i = 0;
					while (i < array.Length)
					{
						Record record = array[i];
						if (record.IntField[FI.teams_teamid] == this.m_Id)
						{
							team.Load(record);
							if (PatchedObject.s_BallCrossReferenceRequired)
							{
								team.balltype = MainForm.m_PatchLoaderForm.CrossReference("Ball", team.balltype);
							}
							if (PatchedObject.s_AdboardCrossReferenceRequired)
							{
								team.adboardid = MainForm.m_PatchLoaderForm.CrossReference("Adboard", team.adboardid);
							}
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								team.rivalteam = MainForm.m_PatchLoaderForm.CrossReference("Team", team.rivalteam);
							}
							team.LinkTeam(FifaEnvironment.Teams);
							if (!PatchedObject.s_PlayerCrossReferenceRequired)
							{
								break;
							}
							team.captainid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.captainid);
							team.penaltytakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.penaltytakerid);
							team.freekicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.freekicktakerid);
							team.longkicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.longkicktakerid);
							team.leftcornerkicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.leftcornerkicktakerid);
							team.rightcornerkicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.rightcornerkicktakerid);
							if (FifaEnvironment.Year > 14)
							{
								team.leftfreekicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.leftfreekicktakerid);
								team.rightcornerkicktakerid = MainForm.m_PatchLoaderForm.CrossReference("Player", team.rightcornerkicktakerid);
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
				if (PatchedObject.s_TeamstadiumlinksTable != null)
				{
					foreach (Record record2 in PatchedObject.s_TeamstadiumlinksTable.Records)
					{
						if (record2.IntField[FI.teamstadiumlinks_teamid] == this.m_Id)
						{
							team.FillFromTeamStadiumLinks(record2);
							team.stadiumid = MainForm.m_PatchLoaderForm.CrossReference("Stadium", record2.IntField[FI.teamstadiumlinks_stadiumid]);
							team.LinkStadium(FifaEnvironment.Stadiums);
							break;
						}
					}
				}
				if (PatchedObject.s_StadiumassignmentsTable != null)
				{
					foreach (Record record3 in PatchedObject.s_StadiumassignmentsTable.Records)
					{
						if (record3.IntField[FI.stadiumassignments_teamid] == this.m_Id)
						{
							team.FillFromStadiumAssignments(record3);
							break;
						}
					}
				}
				if (PatchedObject.s_ManagerTable != null)
				{
					foreach (Record record4 in PatchedObject.s_ManagerTable.Records)
					{
						if (record4.IntField[FI.manager_teamid] == this.m_Id)
						{
							team.FillFromManager(record4);
							break;
						}
					}
				}
				if (PatchedObject.s_TeamformationteamstylelinkTable != null)
				{
					foreach (Record record5 in PatchedObject.s_TeamformationteamstylelinkTable.Records)
					{
						if (record5.IntField[FI.teamformationteamstylelinks_teamid] == this.m_Id)
						{
							team.FillFromTeamFormationLinks(record5);
							team.formationid = MainForm.m_PatchLoaderForm.CrossReference("Formation", record5.IntField[FI.teamformationteamstylelinks_formationid]);
							team.LinkFormation(FifaEnvironment.Formations);
							break;
						}
					}
				}
				if (PatchedObject.s_TeamplayerlinksTable != null)
				{
					team.Roster.ResetToEmpty();
					foreach (Record record6 in PatchedObject.s_TeamplayerlinksTable.Records)
					{
						if (record6.IntField[FI.teamplayerlinks_teamid] == this.m_Id)
						{
							int num = record6.IntField[FI.teamplayerlinks_playerid];
							if (PatchedObject.s_PlayerCrossReferenceRequired)
							{
								num = MainForm.m_PatchLoaderForm.CrossReference("Player", num);
							}
							Player player = (Player)FifaEnvironment.Players.SearchId(num);
							if (player != null)
							{
								player.PlayFor(team);
								TeamPlayer teamPlayer = new TeamPlayer(record6, player, team);
								if (teamPlayer != null)
								{
									team.Roster.Add(teamPlayer);
								}
								team.LinkPlayer(FifaEnvironment.Players);
							}
						}
					}
					if (team.IsClub())
					{
						for (int j = 0; j < team.Roster.Count; j++)
						{
							Player player2 = ((TeamPlayer)team.Roster[j]).Player;
							bool flag = false;
							foreach (object obj in player2.m_PlayingForTeams)
							{
								Team team2 = (Team)obj;
								if (team2.IsClub() && team2 != team)
								{
									flag = true;
									break;
								}
							}
							if (flag)
							{
								for (int k = 0; k < player2.m_PlayingForTeams.Count; k++)
								{
									Team team3 = (Team)player2.m_PlayingForTeams[k];
									if (team3.IsClub() && team3 != team)
									{
										if (MainForm.m_PatchLoaderForm.radioTransferToNewTeam.Checked)
										{
											team3.RemoveTeamPlayer(player2);
											break;
										}
										if (MainForm.m_PatchLoaderForm.radioLeaveInExistingTeam.Checked)
										{
											team.RemoveTeamPlayer(player2);
											j--;
										}
									}
								}
							}
						}
					}
				}
				if (PatchedObject.s_TeamNationLinksTable != null)
				{
					foreach (Record record7 in PatchedObject.s_TeamNationLinksTable.Records)
					{
						if (record7.IntField[FI.teamnationlinks_teamid] == this.m_Id)
						{
							team.FillFromTeamNationLinks(record7);
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								team.m_countryid_IfNationalTeam = MainForm.m_PatchLoaderForm.CrossReference("Team", team.m_countryid_IfNationalTeam);
							}
							team.LinkCountry(FifaEnvironment.Countries);
							break;
						}
					}
				}
				if (PatchedObject.s_RowteamnationlinksTable != null)
				{
					Record[] array = PatchedObject.s_RowteamnationlinksTable.Records;
					int i = 0;
					while (i < array.Length)
					{
						Record record8 = array[i];
						if (record8.IntField[FI.rowteamnationlinks_teamid] == this.m_Id)
						{
							team.FillFromRowTeamNationLinks(record8);
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								team.m_countryid_IfRowTeam = MainForm.m_PatchLoaderForm.CrossReference("Team", team.m_countryid_IfRowTeam);
							}
							if (team.League == null)
							{
								team.LinkCountry(FifaEnvironment.Countries);
								League.GetDefaultLeague().AddTeam(team);
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
				if (team.Country == null)
				{
					League league = team.League;
				}
				if (PatchedObject.s_Language != null)
				{
					team.TeamNameFull = PatchedObject.s_Language.GetTeamString(this.m_Id, Language.ETeamStringType.Full);
					team.TeamNameAbbr15 = PatchedObject.s_Language.GetTeamString(this.m_Id, Language.ETeamStringType.Abbr15);
					team.TeamNameAbbr10 = PatchedObject.s_Language.GetTeamString(this.m_Id, Language.ETeamStringType.Abbr10);
					team.TeamNameAbbr7 = PatchedObject.s_Language.GetTeamString(this.m_Id, Language.ETeamStringType.Abbr7);
					team.TeamNameAbbr3 = PatchedObject.s_Language.GetTeamString(this.m_Id, Language.ETeamStringType.Abbr3);
				}
				Team team4 = team;
				team4.SetNameAutomatically(team4.TeamNameFull, 15);
				Team team5 = team;
				team5.SetNameAutomatically(team5.TeamNameAbbr15, 10);
				Team team6 = team;
				team6.SetNameAutomatically(team6.TeamNameAbbr10, 7);
				Team team7 = team;
				team7.SetNameAutomatically(team7.TeamNameAbbr7, 3);
			}
			if (MainForm.m_PatchLoaderForm.checkTeamLogo.Checked)
			{
				string text = Team.CrestDdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile = FifaEnvironment.GetBitmapFromDdsFile(text);
					team.SetCrest(bitmapFromDdsFile);
					team.SetCrestDark(bitmapFromDdsFile);
				}
				text = Team.Crest50DdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile2 = FifaEnvironment.GetBitmapFromDdsFile(text);
					team.SetCrest50(bitmapFromDdsFile2);
					team.SetCrest50Dark(bitmapFromDdsFile2);
				}
				text = Team.Crest32DdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile3 = FifaEnvironment.GetBitmapFromDdsFile(text);
					team.SetCrest32(bitmapFromDdsFile3);
					team.SetCrest32Dark(bitmapFromDdsFile3);
				}
				text = Team.Crest16DdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile4 = FifaEnvironment.GetBitmapFromDdsFile(text);
					team.SetCrest16(bitmapFromDdsFile4);
					team.SetCrest16Dark(bitmapFromDdsFile4);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkTeamBanner.Checked)
			{
				string text = Team.BannerFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetBanner(text);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkTeamFlags.Checked)
			{
				string text = Team.FlagFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetFlags(text);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkTeamFlags.Checked)
			{
				string text = Team.ScarfFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetScarfs(text);
				}
				text = Team.RevModAdboardFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModAdboard(text);
				}
				text = Team.RevModBallModelFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModBallModel(text);
				}
				text = Team.RevModBallTextureFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModBallTextures(text);
				}
				text = Team.RevModNetFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModNet(text);
				}
				text = Team.RevModManagerModleFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModManagerModel(text);
				}
				text = Team.RevModManagerTextureFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					team.SetRevModManagerTexture(text);
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0002F0A8 File Offset: 0x0002D2A8
		public int ConvertFormationTo08(int id07)
		{
			if (id07 <= 20)
			{
				int num = PatchedObject.c_FormationSwitchTable[id07];
				if (FifaEnvironment.Formations.SearchId(num) != null)
				{
					return num;
				}
			}
			return FifaEnvironment.Formations.GetNewId();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0002F0DC File Offset: 0x0002D2DC
		private void ImportLeague()
		{
			League league = (League)this.GetUsedObject();
			if (league == null)
			{
				return;
			}
			if (MainForm.m_PatchLoaderForm.checkLeagueDatabase.Checked)
			{
				if (PatchedObject.s_LeaguesTable != null)
				{
					Record[] array = PatchedObject.s_LeaguesTable.Records;
					int i = 0;
					while (i < array.Length)
					{
						Record record = array[i];
						if (record.IntField[FI.leagues_leagueid] == this.m_Id)
						{
							league.Load(record);
							if (PatchedObject.s_CountryCrossReferenceRequired)
							{
								league.countryid = MainForm.m_PatchLoaderForm.CrossReference("Country", record.IntField[FI.leagues_countryid]);
							}
							league.LinkCountry(FifaEnvironment.Countries);
							if (PatchedObject.s_Language != null)
							{
								league.ShortName = PatchedObject.s_Language.GetLeagueString(this.m_Id, Language.ELeagueStringType.Abbr15);
								league.LongName = PatchedObject.s_Language.GetLeagueString(this.m_Id, Language.ELeagueStringType.Full);
								if (league.LongName == null)
								{
									League league2 = league;
									league2.LongName = league2.ShortName;
								}
								if (league.ShortName == null)
								{
									League league3 = league;
									league3.ShortName = league3.LongName;
								}
							}
							if (league.LongName == null)
							{
								League league4 = league;
								league4.LongName = league4.leaguename;
							}
							if (league.ShortName == null)
							{
								League league5 = league;
								league5.ShortName = league5.leaguename;
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
				if (PatchedObject.s_BoardOutcomesTable != null)
				{
					foreach (Record record2 in PatchedObject.s_BoardOutcomesTable.Records)
					{
						if (record2.IntField[FI.career_boardoutcomes_leagueid] == this.m_Id)
						{
							league.FillFromBoardOutcomes(record2);
						}
					}
				}
				if (PatchedObject.s_LeagueteamlinksTable != null)
				{
					league.PlayingTeams.Clear();
					foreach (Record record3 in PatchedObject.s_LeagueteamlinksTable.Records)
					{
						if (record3.IntField[FI.leagueteamlinks_leagueid] == this.m_Id)
						{
							int num = record3.IntField[FI.leagueteamlinks_teamid];
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								num = MainForm.m_PatchLoaderForm.CrossReference("Team", num);
							}
							Team team = (Team)FifaEnvironment.Teams.SearchId(num);
							if (team != null)
							{
								team.FillFromLeagueTeamLinks(record3);
								league.PlayingTeams.InsertId(team);
								if (team.League != null && team.League != league)
								{
									team.League.RemoveTeam(team);
								}
								team.League = league;
								if (team.Country == null)
								{
									team.Country = league.Country;
								}
								team.LinkLeague(FifaEnvironment.Leagues);
							}
						}
					}
				}
			}
			if (MainForm.m_PatchLoaderForm.checkLeagueLogo.Checked)
			{
				string text = League.TinyLogoDdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile = FifaEnvironment.GetBitmapFromDdsFile(text);
					league.SetTinyLogo(bitmapFromDdsFile);
					league.SetTinyLogoDark(bitmapFromDdsFile);
				}
				text = League.AnimLogoDdsFileName(this.m_Id, MainForm.m_PatchLoaderForm.PatchYear);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile2 = FifaEnvironment.GetBitmapFromDdsFile(text);
					league.SetAnimLogo(bitmapFromDdsFile2);
					league.SetAnimLogoDark(bitmapFromDdsFile2);
				}
				text = League.SmallLogoDdsFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile3 = FifaEnvironment.GetBitmapFromDdsFile(text);
					league.SetSmallLogo(bitmapFromDdsFile3);
					league.SetSmallLogoDark(bitmapFromDdsFile3);
				}
				text = League.Logo512x128DdsFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile4 = FifaEnvironment.GetBitmapFromDdsFile(text);
					league.SetLogo512x128(bitmapFromDdsFile4);
					league.SetLogo512x128Dark(bitmapFromDdsFile4);
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0002F49C File Offset: 0x0002D69C
		private void ImportCountry()
		{
			Country country = (Country)this.GetUsedObject();
			if (country == null)
			{
				return;
			}
			if (MainForm.m_PatchLoaderForm.checkCountryDatabase.Checked)
			{
				if (PatchedObject.s_NationsTable != null)
				{
					foreach (Record record in PatchedObject.s_NationsTable.Records)
					{
						if (record.IntField[FI.nations_nationid] == this.m_Id)
						{
							country.Load(record);
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								country.NationalTeamId = MainForm.m_PatchLoaderForm.CrossReference("Team", country.NationalTeamId);
							}
							country.LinkTeam(FifaEnvironment.Teams);
							break;
						}
					}
					if (PatchedObject.s_Language != null)
					{
						string countryString = PatchedObject.s_Language.GetCountryString(this.m_Id, Language.ECountryStringType.Full);
						if (countryString != null)
						{
							country.LanguageName = countryString;
						}
					}
				}
				this.m_Imported = true;
			}
			if (MainForm.m_PatchLoaderForm.checkCountryFlag.Checked)
			{
				string text = Country.FlagBigFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromBigFile = FifaEnvironment.GetBitmapFromBigFile(text);
					country.SetFlag(bitmapFromBigFile);
				}
				text = Country.MiniFlagBigFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromBigFile2 = FifaEnvironment.GetBitmapFromBigFile(text);
					country.SetMiniFlag(bitmapFromBigFile2);
				}
				text = Country.CardFlagBigFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromBigFile3 = FifaEnvironment.GetBitmapFromBigFile(text);
					country.SetCardFlag(bitmapFromBigFile3);
				}
				text = Country.Flag512DdsFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile = FifaEnvironment.GetBitmapFromDdsFile(text);
					country.SetFlag512(bitmapFromDdsFile);
				}
			}
			if (MainForm.m_PatchLoaderForm.checkCountryMap.Checked)
			{
				string text = Country.ShapeFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					Bitmap bitmapFromDdsFile2 = FifaEnvironment.GetBitmapFromDdsFile(text);
					country.SetShape(bitmapFromDdsFile2);
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0002F6C4 File Offset: 0x0002D8C4
		private void ImportReferee()
		{
			Referee referee = (Referee)this.GetUsedObject();
			if (referee == null)
			{
				return;
			}
			if (PatchedObject.s_RefereeTable != null)
			{
				foreach (Record record in PatchedObject.s_RefereeTable.Records)
				{
					if (record.IntField[FI.referee_refereeid] == this.m_Id)
					{
						referee.Load(record);
						referee.LinkLeague(FifaEnvironment.Leagues);
						if (PatchedObject.s_CountryCrossReferenceRequired)
						{
							referee.nationalitycode = MainForm.m_PatchLoaderForm.CrossReference("Country", referee.nationalitycode);
						}
						referee.LinkCountry(FifaEnvironment.Countries);
						break;
					}
					if (FifaEnvironment.Year == 14 && MainForm.m_PatchLoaderForm.PatchYear == 14)
					{
						string text = Referee.PhotoBigFileName(this.m_Id);
						text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
						if (File.Exists(text))
						{
							Bitmap bitmapFromBigFile = FifaEnvironment.GetBitmapFromBigFile(text);
							referee.SetPhoto(bitmapFromBigFile);
						}
					}
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0002F7C4 File Offset: 0x0002D9C4
		private void ImportFormation()
		{
			Formation formation = (Formation)this.GetUsedObject();
			if (formation == null)
			{
				return;
			}
			if (PatchedObject.s_FormationsTable != null)
			{
				foreach (Record record in PatchedObject.s_FormationsTable.Records)
				{
					if (record.IntField[FI.formations_formationid] == this.m_Id)
					{
						formation.Load(record);
						if (formation.teamid != -1)
						{
							if (PatchedObject.s_TeamCrossReferenceRequired)
							{
								formation.teamid = MainForm.m_PatchLoaderForm.CrossReference("Team", formation.teamid);
							}
							formation.LinkTeam(FifaEnvironment.Teams);
							if (formation.Team != null)
							{
								formation.Team.formationid = formation.Id;
								formation.Team.LinkFormation(FifaEnvironment.Formations);
							}
						}
						formation.LinkRoles(FifaEnvironment.Roles);
						break;
					}
				}
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0002F8A0 File Offset: 0x0002DAA0
		private void ImportBall()
		{
			Ball ball = (Ball)this.GetUsedObject();
			if (ball == null)
			{
				return;
			}
			string text = Ball.BallTextureFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				ball.SetBallTextures(text);
			}
			text = Ball.BallModelFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				ball.SetBallModel(text);
			}
			Bitmap bitmap = null;
			if (MainForm.m_PatchLoaderForm.PatchYear == 14)
			{
				text = Ball.BallPictureBigFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					bitmap = FifaEnvironment.GetBitmapFromBigFile(text);
				}
			}
			else
			{
				text = Ball.BallDdsFileName(this.m_Id);
				text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
				if (File.Exists(text))
				{
					bitmap = FifaEnvironment.GetBitmapFromDdsFile(text);
				}
			}
			if (bitmap != null)
			{
				ball.SetBallPicture(bitmap);
			}
			if (PatchedObject.s_Language != null)
			{
				bool flag;
				ball.Name = PatchedObject.s_Language.GetBallName(this.m_Id, out flag);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0002F9C8 File Offset: 0x0002DBC8
		private void ImportAdboard()
		{
			Adboard adboard = (Adboard)this.GetUsedObject();
			if (adboard == null)
			{
				return;
			}
			string text = Adboard.AdboardFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				Adboard.SetAdboard(adboard.Id, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0002FA24 File Offset: 0x0002DC24
		private void ImportNumberFont()
		{
			if ((NumberFont)this.GetUsedObject() == null)
			{
				return;
			}
			int num = this.m_Id / 20;
			int num2 = this.m_Id - 20 * num;
			string text = NumberFont.NumberFontFileName(num, num2);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				num = this.m_ImportId / 20;
				num2 = this.m_ImportId - 20 * num;
				NumberFont.SetNumberFont(num, num2, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0002FAA4 File Offset: 0x0002DCA4
		private void ImportNameFont()
		{
			if ((NameFont)this.GetUsedObject() == null)
			{
				return;
			}
			string text = NameFont.NameFontFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				NameFont.Import(this.m_ImportId, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0002FB00 File Offset: 0x0002DD00
		private void ImportShoes()
		{
			if ((Shoes)this.GetUsedObject() == null)
			{
				return;
			}
			string text = Shoes.ShoesTexturesFileName(this.m_Id, 0);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				Shoes.SetShoesTextures(this.m_ImportId, 0, text);
			}
			text = Shoes.ShoesModelFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				Shoes.SetShoesModel(this.m_ImportId, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0002FB94 File Offset: 0x0002DD94
		private void ImportNet()
		{
			if ((Net)this.GetUsedObject() == null)
			{
				return;
			}
			string text = Net.NetFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				Net.SetNet(this.m_ImportId, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		private void ImportGkGloves()
		{
			if ((GkGloves)this.GetUsedObject() == null)
			{
				return;
			}
			string text = GkGloves.GkGlovesTextureFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				GkGloves.SetGkGlovesTextures(this.m_ImportId, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0002FC4C File Offset: 0x0002DE4C
		private void ImportMowingPattern()
		{
			if ((MowingPattern)this.GetUsedObject() == null)
			{
				return;
			}
			string text = MowingPattern.MowingPatternFileName(this.m_Id);
			text = MainForm.m_PatchLoaderForm.m_TempFolder + "\\" + text;
			if (File.Exists(text))
			{
				MowingPattern.SetMowingPattern(this.m_ImportId, text);
			}
			this.m_Imported = true;
		}

		// Token: 0x040002D3 RID: 723
		public static bool s_RefereeKitNotLoaded;

		// Token: 0x040002D4 RID: 724
		private static int s_PlayerCount;

		// Token: 0x040002D5 RID: 725
		public static bool s_TeamCrossReferenceRequired;

		// Token: 0x040002D6 RID: 726
		public static bool s_PlayerCrossReferenceRequired;

		// Token: 0x040002D7 RID: 727
		public static bool s_CountryCrossReferenceRequired;

		// Token: 0x040002D8 RID: 728
		public static bool s_ShoesCrossReferenceRequired;

		// Token: 0x040002D9 RID: 729
		public static bool s_BallCrossReferenceRequired;

		// Token: 0x040002DA RID: 730
		public static bool s_AdboardCrossReferenceRequired;

		// Token: 0x040002DB RID: 731
		private static Language s_Language = null;

		// Token: 0x040002DC RID: 732
		private static DataSet s_FifaDataSet = null;

		// Token: 0x040002DD RID: 733
		private static Table s_LangTable = null;

		// Token: 0x040002DE RID: 734
		private static Table s_NationsTable = null;

		// Token: 0x040002DF RID: 735
		private static Table s_TeamsTable = null;

		// Token: 0x040002E0 RID: 736
		private static Table s_TeamplayerlinksTable = null;

		// Token: 0x040002E1 RID: 737
		private static Table s_TeamNationLinksTable = null;

		// Token: 0x040002E2 RID: 738
		private static Table s_TeamstadiumlinksTable = null;

		// Token: 0x040002E3 RID: 739
		private static Table s_TeamformationteamstylelinkTable = null;

		// Token: 0x040002E4 RID: 740
		private static Table s_StadiumassignmentsTable = null;

		// Token: 0x040002E5 RID: 741
		private static Table s_ManagerTable = null;

		// Token: 0x040002E6 RID: 742
		private static Table s_TeamkitsTable = null;

		// Token: 0x040002E7 RID: 743
		private static Table s_RowteamnationlinksTable = null;

		// Token: 0x040002E8 RID: 744
		private static Table s_TeamnationlinksTable = null;

		// Token: 0x040002E9 RID: 745
		private static Table s_FormationsTable = null;

		// Token: 0x040002EA RID: 746
		private static Table s_LeaguesTable = null;

		// Token: 0x040002EB RID: 747
		private static Table s_BoardOutcomesTable = null;

		// Token: 0x040002EC RID: 748
		private static Table s_LeagueteamlinksTable = null;

		// Token: 0x040002ED RID: 749
		private static Table s_PlayernamesTable = null;

		// Token: 0x040002EE RID: 750
		private static Table s_PlayersTable = null;

		// Token: 0x040002EF RID: 751
		private static Table s_RefereeTable = null;

		// Token: 0x040002F0 RID: 752
		private static Table s_StadiumsTable = null;

		// Token: 0x040002F1 RID: 753
		private static PlayerNames s_PlayerNames = null;

		// Token: 0x040002F2 RID: 754
		private static DataSet s_Fifa12DataSet = null;

		// Token: 0x040002F3 RID: 755
		private string m_Type;

		// Token: 0x040002F4 RID: 756
		private string m_Name;

		// Token: 0x040002F5 RID: 757
		private int m_Id;

		// Token: 0x040002F6 RID: 758
		private int m_ImportId;

		// Token: 0x040002F7 RID: 759
		private object m_ReplacedObject;

		// Token: 0x040002F8 RID: 760
		private object m_NewObject;

		// Token: 0x040002F9 RID: 761
		private object m_CmsObject;

		// Token: 0x040002FA RID: 762
		private bool m_Imported;

		// Token: 0x040002FB RID: 763
		private PatchedObject.EUsedObject m_UsedObject;

		// Token: 0x040002FC RID: 764
		private bool m_IsCmsNew;

		// Token: 0x040002FD RID: 765
		private static int s_LastLoadedTeamId = -1;

		// Token: 0x040002FE RID: 766
		private static int[] c_FormationSwitchTable = new int[]
		{
			801, 806, 808, 808, 808, 809, 803, 805, 802, 803,
			805, 804, 801, 801, 805, 806, 807, 806, 807, 801,
			801
		};

		// Token: 0x0200002E RID: 46
		public enum EUsedObject
		{
			// Token: 0x04000A75 RID: 2677
			Undefined,
			// Token: 0x04000A76 RID: 2678
			UseCms,
			// Token: 0x04000A77 RID: 2679
			UseNew,
			// Token: 0x04000A78 RID: 2680
			UseFitting
		}
	}
}
