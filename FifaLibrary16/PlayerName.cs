using System;

namespace FifaLibrary
{
	// Token: 0x0200005C RID: 92
	public class PlayerName : IdObject
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0002C0E2 File Offset: 0x0002A2E2
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0002C0EA File Offset: 0x0002A2EA
		public string Text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0002C0F3 File Offset: 0x0002A2F3
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x0002C0FB File Offset: 0x0002A2FB
		public bool IsOriginal
		{
			get
			{
				return this.m_IsOriginal;
			}
			set
			{
				this.m_IsOriginal = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002C104 File Offset: 0x0002A304
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0002C10C File Offset: 0x0002A30C
		public bool IsUsed
		{
			get
			{
				return this.m_IsUsed;
			}
			set
			{
				this.m_IsUsed = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0002C115 File Offset: 0x0002A315
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0002C11D File Offset: 0x0002A31D
		public int CommentaryId
		{
			get
			{
				return this.m_CommentaryId;
			}
			set
			{
				this.m_CommentaryId = value;
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002C126 File Offset: 0x0002A326
		public PlayerName(Record r)
			: base(r.IntField[FI.playernames_nameid])
		{
			this.Load(r);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002C141 File Offset: 0x0002A341
		public PlayerName(int id, string text, bool isUsed)
		{
			base.Id = id;
			this.m_Text = text;
			this.m_IsUsed = isUsed;
			this.m_IsOriginal = false;
			this.m_CommentaryId = 900000;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0002C170 File Offset: 0x0002A370
		public void Load(Record r)
		{
			this.m_Text = r.CompressedString[FI.playernames_name];
			this.m_CommentaryId = r.IntField[FI.playernames_commentaryid];
			this.m_IsUsed = false;
			this.m_IsOriginal = false;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0002C1A4 File Offset: 0x0002A3A4
		public void SavePlayerName(Record r)
		{
			r.IntField[FI.playernames_nameid] = base.Id;
			r.CompressedString[FI.playernames_name] = this.Text;
			r.IntField[FI.playernames_commentaryid] = this.m_CommentaryId;
		}

		// Token: 0x04000E93 RID: 3731
		private string m_Text;

		// Token: 0x04000E94 RID: 3732
		private bool m_IsOriginal;

		// Token: 0x04000E95 RID: 3733
		private bool m_IsUsed;

		// Token: 0x04000E96 RID: 3734
		private int m_CommentaryId;
	}
}
