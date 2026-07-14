using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200003A RID: 58
	public class Role : IdObject
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001D689 File Offset: 0x0001B889
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0001D691 File Offset: 0x0001B891
		public ERole RoleId
		{
			get
			{
				return (ERole)base.Id;
			}
			set
			{
				base.Id = (int)value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001D69A File Offset: 0x0001B89A
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0001D6A2 File Offset: 0x0001B8A2
		public int Xmin
		{
			get
			{
				return this.m_Xmin;
			}
			set
			{
				this.m_Xmin = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001D6AB File Offset: 0x0001B8AB
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0001D6B3 File Offset: 0x0001B8B3
		public int Xmax
		{
			get
			{
				return this.m_Xmax;
			}
			set
			{
				this.m_Xmax = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001D6BC File Offset: 0x0001B8BC
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
		public int Ymin
		{
			get
			{
				return this.m_Ymin;
			}
			set
			{
				this.m_Ymin = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001D6CD File Offset: 0x0001B8CD
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0001D6D5 File Offset: 0x0001B8D5
		public int Ymax
		{
			get
			{
				return this.m_Ymax;
			}
			set
			{
				this.m_Ymax = value;
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002B03 File Offset: 0x00000D03
		public Role(ERole eRole)
			: base((int)eRole)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002B03 File Offset: 0x00000D03
		public Role(int roleId)
			: base(roleId)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		public override string ToString()
		{
			string text = string.Empty;
			if (FifaEnvironment.Language != null)
			{
				text = FifaEnvironment.Language.GetRoleShortString(base.Id) + " - ";
			}
			switch (this.RoleId)
			{
			case ERole.Goalkeeper:
				return text + "Goalkeeper";
			case ERole.Sweeper:
				return text + "Sweeper";
			case ERole.Right_Wing_Back:
				return text + "Right Wing Back";
			case ERole.Right_Back:
				return text + "Right Back";
			case ERole.Right_Central_Back:
				return text + "Right Central Back";
			case ERole.Central_Back:
				return text + "Central Back";
			case ERole.Left_Central_Back:
				return text + "Left Central Back";
			case ERole.Left_Back:
				return text + "Left Back";
			case ERole.Left_Wing_Back:
				return text + "Left Wing Back";
			case ERole.Right_Defensive_Midfielder:
				return text + "Right Defensive Midfielder";
			case ERole.Central_Defensive_Midfielder:
				return text + "Central Defensive Midfielder";
			case ERole.Left_Defensive_Midfielder:
				return text + "Left Defensive Midfielder";
			case ERole.Right_Midfielder:
				return text + "Right Midfielder";
			case ERole.Right_Central_Midfielder:
				return text + "Right Central Midfielder";
			case ERole.Central_Midfielder:
				return text + "Central Midfielder";
			case ERole.Left_Central_Midfielder:
				return text + "Left Central Midfielder";
			case ERole.Left_Midfielder:
				return text + "Left Midfielder";
			case ERole.Right_Advanced_Midfielder:
				return text + "Right Advanced Midfielder";
			case ERole.Central_Advanced_Midfielder:
				return text + "Central Advanced Midfielder";
			case ERole.Left_Advanced_Midfielder:
				return text + "Left Advanced Midfielder";
			case ERole.Right_Forward:
				return text + "Right Forward";
			case ERole.Central_Forward:
				return text + "Central Forward";
			case ERole.Left_Forward:
				return text + "Left Forward";
			case ERole.Right_Wing:
				return text + "Right Wing";
			case ERole.Right_Striker:
				return text + "Right Striker";
			case ERole.Central_Striker:
				return text + "Central Striker";
			case ERole.Left_Striker:
				return text + "Left Striker";
			case ERole.Left_Wing:
				return text + "Left Wing";
			case ERole.Substitute:
				return text + "Substitute";
			case ERole.Tribune:
				return text + "Tribune";
			default:
				return string.Empty;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001D90C File Offset: 0x0001BB0C
		public string ToShortString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleShortString(base.Id);
			}
			return string.Empty;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001D92B File Offset: 0x0001BB2B
		public string ToLongString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString(base.Id);
			}
			return string.Empty;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001D94A File Offset: 0x0001BB4A
		public void SetShortString(string shortName)
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetRoleShortString(base.Id, shortName);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001D964 File Offset: 0x0001BB64
		public Role(Record r)
			: base(r.IntField[r.TableDescriptor.GetFieldIndex("positionid")])
		{
			this.Load(r);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001D98C File Offset: 0x0001BB8C
		public void Load(Record r)
		{
			float num = r.FloatField[FI.fieldpositionboundingboxes_pointx0];
			float num2 = r.FloatField[FI.fieldpositionboundingboxes_pointx1];
			float num3 = r.FloatField[FI.fieldpositionboundingboxes_pointx2];
			float num4 = r.FloatField[FI.fieldpositionboundingboxes_pointx3];
			float num5 = r.FloatField[FI.fieldpositionboundingboxes_pointy0];
			float num6 = r.FloatField[FI.fieldpositionboundingboxes_pointy1];
			float num7 = r.FloatField[FI.fieldpositionboundingboxes_pointy2];
			float num8 = r.FloatField[FI.fieldpositionboundingboxes_pointy3];
			this.m_Xmin = Convert.ToInt32(Math.Min(Math.Min(num, num2), Math.Min(num3, num4)) * 100f);
			this.m_Xmax = Convert.ToInt32(Math.Max(Math.Max(num, num2), Math.Max(num3, num4)) * 100f);
			this.m_Ymin = Convert.ToInt32(Math.Min(Math.Min(num5, num6), Math.Min(num7, num8)) * 100f);
			this.m_Ymax = Convert.ToInt32(Math.Max(Math.Max(num5, num6), Math.Max(num7, num8)) * 100f);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
		public void Save(Record r)
		{
			r.IntField[FI.fieldpositionboundingboxes_positionid] = base.Id;
			r.FloatField[FI.fieldpositionboundingboxes_pointx0] = (float)this.m_Xmin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy0] = (float)this.m_Ymin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx1] = (float)this.m_Xmin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy1] = (float)this.m_Ymax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx2] = (float)this.m_Xmax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy2] = (float)this.m_Ymax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx3] = (float)this.m_Xmax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy3] = (float)this.m_Ymin / 100f;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001DB87 File Offset: 0x0001BD87
		public Point GetCenter()
		{
			return new Point((this.m_Xmax + this.m_Xmin) / 2, (this.m_Ymax + this.m_Ymin) / 2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001DBAC File Offset: 0x0001BDAC
		public static ERole ConvertToERole(string s)
		{
			for (int i = 0; i < 29; i++)
			{
				ERole erole = (ERole)i;
				if (erole.ToString() == s)
				{
					return erole;
				}
			}
			return ERole.Tribune;
		}

		// Token: 0x04000DCD RID: 3533
		private int m_Xmin;

		// Token: 0x04000DCE RID: 3534
		private int m_Xmax;

		// Token: 0x04000DCF RID: 3535
		private int m_Ymin;

		// Token: 0x04000DD0 RID: 3536
		private int m_Ymax;
	}
}
