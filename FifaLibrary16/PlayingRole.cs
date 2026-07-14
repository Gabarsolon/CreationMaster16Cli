using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200003C RID: 60
	public class PlayingRole : IdObject
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001DD14 File Offset: 0x0001BF14
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		public Role Role
		{
			get
			{
				return this.m_Role;
			}
			set
			{
				this.m_Role = value;
				base.Id = this.m_Role.Id;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001DD36 File Offset: 0x0001BF36
		public static int GetDefaultInstruction(int roleid)
		{
			if (roleid >= 0 && roleid < PlayingRole.c_DefaultInstrucion.Length)
			{
				return PlayingRole.c_DefaultInstrucion[roleid];
			}
			return 0;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001DD4F File Offset: 0x0001BF4F
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0001DD57 File Offset: 0x0001BF57
		public int OffsetX
		{
			get
			{
				return this.m_OffsetX;
			}
			set
			{
				this.m_OffsetX = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001DD60 File Offset: 0x0001BF60
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0001DD68 File Offset: 0x0001BF68
		public int OffsetY
		{
			get
			{
				return this.m_OffsetY;
			}
			set
			{
				this.m_OffsetY = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001DD71 File Offset: 0x0001BF71
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0001DD79 File Offset: 0x0001BF79
		public int PlayerInstruction_1
		{
			get
			{
				return this.m_PlayerInstruction_1;
			}
			set
			{
				this.m_PlayerInstruction_1 = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001DD82 File Offset: 0x0001BF82
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0001DD8A File Offset: 0x0001BF8A
		public int PlayerInstruction_2
		{
			get
			{
				return this.m_PlayerInstruction_2;
			}
			set
			{
				this.m_PlayerInstruction_2 = value;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001DD93 File Offset: 0x0001BF93
		public PlayingRole(Record r, int roleOrder, int fieldIndex)
			: base(r.GetAndCheckIntField(fieldIndex))
		{
			this.Load(r, roleOrder);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001DDAC File Offset: 0x0001BFAC
		public PlayingRole(Role role)
			: base(role.Id)
		{
			Point center = role.GetCenter();
			this.m_Role = role;
			this.m_OffsetX = center.X;
			this.m_OffsetY = center.Y;
			this.m_PlayerInstruction_1 = PlayingRole.c_DefaultInstrucion[(int)role.RoleId];
			this.m_PlayerInstruction_2 = PlayingRole.c_DefaultInstrucion[(int)role.RoleId];
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001DE14 File Offset: 0x0001C014
		public bool ReInitialize(PlayingRole playingRole)
		{
			if (playingRole == null)
			{
				return false;
			}
			this.m_Role = playingRole.Role;
			this.m_RoleId = playingRole.m_RoleId;
			this.m_OffsetX = playingRole.m_OffsetX;
			this.m_OffsetY = playingRole.m_OffsetY;
			this.m_PlayerInstruction_1 = playingRole.m_PlayerInstruction_1;
			this.m_PlayerInstruction_2 = playingRole.m_PlayerInstruction_2;
			return true;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001DE6F File Offset: 0x0001C06F
		public override string ToString()
		{
			return this.Role.ToString();
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001DE7C File Offset: 0x0001C07C
		public void LinkRole(RoleList roleList)
		{
			this.m_Role = (Role)roleList.SearchId(this.m_RoleId);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001DE98 File Offset: 0x0001C098
		public void Load(Record r, int i)
		{
			TableDescriptor tableDescriptor = r.TableDescriptor;
			base.Id = i;
			switch (i)
			{
			case 0:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position0"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset0x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset0y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction0_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction0_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction0_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction0_2"));
				}
				break;
			case 1:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position1"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset1x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset1y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction1_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction1_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction1_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction1_2"));
				}
				break;
			case 2:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position2"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset2x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset2y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction2_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction2_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction2_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction2_2"));
				}
				break;
			case 3:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position3"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset3x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset3y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction3_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction3_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction3_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction3_2"));
				}
				break;
			case 4:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position4"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset4x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset4y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction4_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction4_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction4_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction4_2"));
				}
				break;
			case 5:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position5"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset5x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset5y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction5_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction5_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction5_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction5_2"));
				}
				break;
			case 6:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position6"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset6x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset6y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction6_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction6_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction6_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction6_2"));
				}
				break;
			case 7:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position7"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset7x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset7y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction7_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction7_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction7_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction7_2"));
				}
				break;
			case 8:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position8"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset8x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset8y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction8_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction8_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction8_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction8_2"));
				}
				break;
			case 9:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position9"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset9x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset9y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction9_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction9_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction9_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction9_2"));
				}
				break;
			case 10:
				this.m_RoleId = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("position10"));
				this.m_OffsetX = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset10x")] * 100f);
				this.m_OffsetY = (int)(r.FloatField[tableDescriptor.GetFieldIndex("offset10y")] * 100f);
				if (tableDescriptor.GetFieldIndex("playerinstruction10_1") >= 0)
				{
					this.m_PlayerInstruction_1 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction10_1"));
				}
				if (tableDescriptor.GetFieldIndex("playerinstruction10_2") >= 0)
				{
					this.m_PlayerInstruction_2 = r.GetAndCheckIntField(tableDescriptor.GetFieldIndex("playerinstruction10_2"));
				}
				break;
			}
			this.LinkRole(FifaEnvironment.Roles);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001E61C File Offset: 0x0001C81C
		public void Save(Record r, int i)
		{
			switch (i)
			{
			case 0:
				r.IntField[FI.formations_position0] = this.m_Role.Id;
				r.FloatField[FI.formations_offset0x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset0y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction0_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction0_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction0_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction0_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 1:
				r.IntField[FI.formations_position1] = this.m_Role.Id;
				r.FloatField[FI.formations_offset1x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset1y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction1_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction1_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction1_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction1_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 2:
				r.IntField[FI.formations_position2] = this.m_Role.Id;
				r.FloatField[FI.formations_offset2x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset2y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction2_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction2_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction2_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction2_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 3:
				r.IntField[FI.formations_position3] = this.m_Role.Id;
				r.FloatField[FI.formations_offset3x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset3y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction3_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction3_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction3_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction3_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 4:
				r.IntField[FI.formations_position4] = this.m_Role.Id;
				r.FloatField[FI.formations_offset4x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset4y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction4_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction4_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction4_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction4_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 5:
				r.IntField[FI.formations_position5] = this.m_Role.Id;
				r.FloatField[FI.formations_offset5x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset5y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction5_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction5_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction5_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction5_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 6:
				r.IntField[FI.formations_position6] = this.m_Role.Id;
				r.FloatField[FI.formations_offset6x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset6y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction6_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction6_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction6_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction6_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 7:
				r.IntField[FI.formations_position7] = this.m_Role.Id;
				r.FloatField[FI.formations_offset7x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset7y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction7_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction7_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction7_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction7_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 8:
				r.IntField[FI.formations_position8] = this.m_Role.Id;
				r.FloatField[FI.formations_offset8x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset8y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction8_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction8_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction8_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction8_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 9:
				r.IntField[FI.formations_position9] = this.m_Role.Id;
				r.FloatField[FI.formations_offset9x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset9y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction9_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction9_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction9_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction9_2] = this.m_PlayerInstruction_2;
					return;
				}
				break;
			case 10:
				r.IntField[FI.formations_position10] = this.m_Role.Id;
				r.FloatField[FI.formations_offset10x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset10y] = (float)this.m_OffsetY / 100f;
				if (FI.formations_playerinstruction10_1 >= 0)
				{
					r.IntField[FI.formations_playerinstruction10_1] = this.m_PlayerInstruction_1;
				}
				if (FI.formations_playerinstruction10_2 >= 0)
				{
					r.IntField[FI.formations_playerinstruction10_2] = this.m_PlayerInstruction_2;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x04000DD1 RID: 3537
		private int m_RoleId;

		// Token: 0x04000DD2 RID: 3538
		private Role m_Role;

		// Token: 0x04000DD3 RID: 3539
		public EPlayingDirection OffDirection0;

		// Token: 0x04000DD4 RID: 3540
		public EPlayingDirection DefDirection0;

		// Token: 0x04000DD5 RID: 3541
		public EPlayingIntensity OffIntensity;

		// Token: 0x04000DD6 RID: 3542
		public EPlayingIntensity DefIntensity;

		// Token: 0x04000DD7 RID: 3543
		private static int[] c_DefaultInstrucion = new int[]
		{
			0, 16, 8, 8, 16, 16, 16, 8, 8, 320,
			320, 320, 2394112, 134220032, 134220032, 134220032, 2394112, 134252544, 134252544, 134252544,
			294920, 294920, 294920, 2394112, 294920, 294920, 294920, 2394112, 0, 0
		};

		// Token: 0x04000DD8 RID: 3544
		public static int[] c_InstrucionNumber = new int[]
		{
			0, 0, 1, 1, 1, 1, 1, 1, 1, 2,
			2, 2, 4, 3, 3, 3, 4, 3, 3, 3,
			3, 3, 3, 4, 3, 3, 3, 4, 0, 0
		};

		// Token: 0x04000DD9 RID: 3545
		public static int[,] c_InstrucionSetSelection = new int[,]
		{
			{ -1, -1, -1, -1, -1 },
			{ 2, -1, -1, -1, -1 },
			{ 0, -1, -1, -1, -1 },
			{ 1, -1, -1, -1, -1 },
			{ 2, -1, -1, -1, -1 },
			{ 2, -1, -1, -1, -1 },
			{ 2, -1, -1, -1, -1 },
			{ 1, -1, -1, -1, -1 },
			{ 0, -1, -1, -1, -1 },
			{ 4, 3, -1, -1, -1 },
			{ 4, 3, -1, -1, -1 },
			{ 4, 3, -1, -1, -1 },
			{ 6, 5, 7, 8, 9 },
			{ 3, 5, 9, -1, -1 },
			{ 3, 5, 9, -1, -1 },
			{ 3, 5, 9, -1, -1 },
			{ 6, 5, 7, 8, 9 },
			{ 6, 5, 9, -1, -1 },
			{ 6, 5, 9, -1, -1 },
			{ 6, 5, 9, -1, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 6, 5, 7, 8, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 12, 10, 11, -1, -1 },
			{ 6, 5, 7, 8, -1 },
			{ -1, -1, -1, -1, -1 },
			{ -1, -1, -1, -1, -1 }
		};

		// Token: 0x04000DDA RID: 3546
		public static int[][] c_InstrucionSet = new int[][]
		{
			new int[] { 2, 3 },
			new int[] { 2, 3, 4 },
			new int[] { 0, 1, 4 },
			new int[] { 4, 8, 9 },
			new int[] { 5, 6, 7 },
			new int[] { 10, 11, 12 },
			new int[] { 14, 15, 16 },
			new int[] { 17, 18, 19 },
			new int[] { 20, 21, 22 },
			new int[] { 13, 27 },
			new int[] { 18, 24, 25 },
			new int[] { 3, 20, 26, 28 },
			new int[] { 5, 15, 23 }
		};

		// Token: 0x04000DDB RID: 3547
		public static string[] c_InstructionDescription = new string[]
		{
			"Occasionally make forward runs when the opportunity arises", "Go up front in the last few minutes of a match if losing", "Make forward runs as much as possible", "Occasionally make forward runs when the opportunity arises", "Never make forward runs while on attack", "Split the opposition and cut out the passing lanes", "Keep your shape and stay in position to defend", "Mark up tight and stick with your opponent", "Occasionally make forward runs when the opportunity arises", "Join the attack and make runs beyond the striker(s)",
			"Make runs into the penalty area in crossing situations", "Run into the penalty area or stay on the edge in crossing situations", "Stay on the edge of the penalty area in crossing situations", "Take a free role and roam the attacking third", "Always try to track back and support the defence", "Come back to support the defence when needed", "Do not come back to support the defence", "Make cutting runs to the inside from out wide", "Stay wide or cut inside depending on the situation", "Always try to stay wide and close to the line",
			"Make forward runs in behind the defence", "Make forward runs or come short depending on the situation", "Come short and ask for the ball to feet", "Apply pressure on the back line", "Make runs to wide areas of the pitch", "Stay in central areas of the pitch", "Back into an opponent and ask for the ball to feet", "Stay in your formation position when attacking", "Occasionally make forward runs when the opportunity arises", "Description 29",
			"Play as Goalkeeper", "Description 31"
		};

		// Token: 0x04000DDC RID: 3548
		public static string[] c_InstructionCaption = new string[]
		{
			"Join The Attack", "Play As Striker", "Always Overlap", "Balanced Attack-3", "Stay Back While Attacking", "Cut Passing Lanes", "Balanced Defense", "Man Mark", "Balanced Attack-8", "Get Forward",
			"Get Into The Box For Cross", "Balanced Crossing Runs", "Stay On Edge Of Box For Cross", "Free Roam", "Come Back On Defence", "Basic Defence Support", "Stay Forward", "Cut Inside", "Balanced Width", "Stay Wide",
			"Get In Behind", "Balanced Support", "Come Short", "Press Back Line", "Drift Wide", "Stay Central", "Target Man", "Stick To Position", "Balanced Attack-28", "Instruction 29",
			"Instruction 30", "Instruction 31"
		};

		// Token: 0x04000DDD RID: 3549
		public int m_OffsetX;

		// Token: 0x04000DDE RID: 3550
		public int m_OffsetY;

		// Token: 0x04000DDF RID: 3551
		private int m_PlayerInstruction_1;

		// Token: 0x04000DE0 RID: 3552
		private int m_PlayerInstruction_2;
	}
}
