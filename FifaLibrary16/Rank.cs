using System;

namespace FifaLibrary
{
	// Token: 0x02000092 RID: 146
	public class Rank : IdObject
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0004D6A9 File Offset: 0x0004B8A9
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x0004D6B1 File Offset: 0x0004B8B1
		public Group Group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0004D6BA File Offset: 0x0004B8BA
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0004D6C2 File Offset: 0x0004B8C2
		public Rank MoveFrom
		{
			get
			{
				return this.m_MoveFrom;
			}
			set
			{
				this.m_MoveFrom = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0004D6CB File Offset: 0x0004B8CB
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0004D6D3 File Offset: 0x0004B8D3
		public Rank MoveTo
		{
			get
			{
				return this.m_MoveTo;
			}
			set
			{
				this.m_MoveTo = value;
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0004D6DC File Offset: 0x0004B8DC
		public Rank(Group group, int orderId)
		{
			base.Id = orderId;
			this.m_Group = group;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0004D6F4 File Offset: 0x0004B8F4
		public override string ToString()
		{
			Stage parentStage = this.m_Group.ParentStage;
			Trophy trophy = parentStage.Trophy;
			string text;
			if (base.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					base.Id.ToString(),
					" of ",
					parentStage.ToString(),
					" / ",
					this.m_Group.ToString(),
					" of ",
					trophy.ToString()
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					"A team from ",
					parentStage.ToString(),
					" / ",
					this.m_Group.ToString(),
					" of ",
					trophy.ToString()
				});
			}
			return text;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0004D7C4 File Offset: 0x0004B9C4
		public string GetFromRankString()
		{
			if (this.m_MoveFrom == null || this.m_MoveFrom.Group == null)
			{
				return "To be defined";
			}
			if (!FifaEnvironment.CompetitionObjects.Contains(this.m_MoveFrom.Group))
			{
				this.m_MoveFrom = null;
				return "To be defined";
			}
			if (this.m_MoveTo != null && !FifaEnvironment.CompetitionObjects.Contains(this.m_MoveTo.Group))
			{
				this.m_MoveTo = null;
			}
			IdObject trophy = this.m_Group.ParentStage.Trophy;
			Trophy trophy2 = this.m_MoveFrom.Group.ParentStage.Trophy;
			string text;
			if (trophy.Id != trophy2.Id)
			{
				if (this.m_MoveFrom.Id != 0)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_MoveFrom.Id.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveFrom.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"A team from ",
						this.m_MoveFrom.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveFrom.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
			}
			else if (this.m_MoveFrom.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					this.m_MoveFrom.Id.ToString(),
					" of ",
					this.m_MoveFrom.Group.ParentStage.ToString(),
					" / ",
					this.m_MoveFrom.Group.ToString()
				});
			}
			else
			{
				text = "A team from " + this.m_MoveFrom.Group.ParentStage.ToString() + " / " + this.m_MoveFrom.Group.ToString();
			}
			return text;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0004DA28 File Offset: 0x0004BC28
		public string GetToRankString()
		{
			if (this.m_MoveTo == null)
			{
				return "Undefined";
			}
			IdObject trophy = this.m_Group.ParentStage.Trophy;
			Trophy trophy2 = this.m_MoveTo.Group.ParentStage.Trophy;
			string text;
			if (trophy.Id != trophy2.Id)
			{
				if (this.m_MoveFrom.Id != 0)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_MoveTo.Id.ToString(),
						" fof ",
						this.m_MoveTo.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveTo.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"A team from ",
						this.m_MoveTo.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveTo.Group.ToString(),
						" of ",
						this.m_MoveTo.Group.ParentStage.Trophy.ToString()
					});
				}
			}
			else if (this.m_MoveFrom.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					this.m_MoveTo.Id.ToString(),
					" of ",
					this.m_MoveTo.Group.ParentStage.ToString(),
					" / ",
					this.m_MoveTo.Group.ToString()
				});
			}
			else
			{
				text = "A team from " + this.m_MoveTo.Group.ParentStage.ToString() + " / " + this.m_MoveTo.Group.ToString();
			}
			return text;
		}

		// Token: 0x0400111B RID: 4379
		private Group m_Group;

		// Token: 0x0400111C RID: 4380
		private Rank m_MoveFrom;

		// Token: 0x0400111D RID: 4381
		private Rank m_MoveTo;
	}
}
