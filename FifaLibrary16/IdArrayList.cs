using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x0200004C RID: 76
	public class IdArrayList : ArrayList
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00026EF9 File Offset: 0x000250F9
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00026F01 File Offset: 0x00025101
		public int MinId
		{
			get
			{
				return this.m_MinId;
			}
			set
			{
				this.m_MinId = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00026F0A File Offset: 0x0002510A
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00026F12 File Offset: 0x00025112
		public int MaxId
		{
			get
			{
				return this.m_MaxId;
			}
			set
			{
				this.m_MaxId = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00026F1B File Offset: 0x0002511B
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00026F23 File Offset: 0x00025123
		public Type ObjectType
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

		// Token: 0x06000539 RID: 1337 RVA: 0x00026F2C File Offset: 0x0002512C
		public IdArrayList(Type type, int minId, int maxId)
		{
			this.m_Type = type;
			this.m_MinId = minId;
			this.m_MaxId = maxId;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00026F54 File Offset: 0x00025154
		public IdArrayList(Type type)
		{
			this.m_Type = type;
			this.m_MinId = 0;
			this.m_MaxId = -1;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00026F7C File Offset: 0x0002517C
		public IdArrayList(int minId, int maxId)
		{
			this.m_Type = typeof(IdObject);
			this.m_MinId = minId;
			this.m_MaxId = maxId;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00026FAD File Offset: 0x000251AD
		public IdArrayList()
		{
			this.m_Type = typeof(IdObject);
			this.m_MinId = -1;
			this.m_MaxId = 0;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00026FE0 File Offset: 0x000251E0
		public bool InsertId(IdObject idObject)
		{
			if (idObject == null)
			{
				return false;
			}
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num < 0)
			{
				num = ~num;
				this.Insert(num, idObject);
				return true;
			}
			return false;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00027014 File Offset: 0x00025214
		public bool RemoveId(IdObject idObject)
		{
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num < 0 && this.Count < 10000)
			{
				this.Sort(this.m_Comparer);
				num = this.BinarySearch(idObject, this.m_Comparer);
			}
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00027068 File Offset: 0x00025268
		public bool RemoveId(int id)
		{
			IdObject idObject = new IdObject(id);
			return this.RemoveId(idObject);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00027083 File Offset: 0x00025283
		public void SortId()
		{
			this.Sort(this.m_Comparer);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00027091 File Offset: 0x00025291
		public bool DeleteId(IdObject idObject)
		{
			return this.RemoveId(idObject) && idObject.Delete();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000270A4 File Offset: 0x000252A4
		public IdObject SearchId(int id)
		{
			IdObject idObject = new IdObject(id);
			return this.SearchId(idObject);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000270C0 File Offset: 0x000252C0
		public IdObject SearchId(IdObject idObject)
		{
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num >= 0)
			{
				return (IdObject)this[num];
			}
			return null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000270F0 File Offset: 0x000252F0
		public bool ChangeId(IdObject idObject, int newId)
		{
			int id = idObject.Id;
			if (!this.RemoveId(idObject))
			{
				return false;
			}
			idObject.Id = newId;
			if (!this.InsertId(idObject))
			{
				idObject.Id = id;
				this.InsertId(idObject);
				return false;
			}
			return true;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00027134 File Offset: 0x00025334
		public virtual int GetNewId()
		{
			int num = -1;
			for (int i = this.m_MinId; i <= this.m_MaxId; i++)
			{
				if (this.SearchId(i) == null)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00027168 File Offset: 0x00025368
		public virtual int GetNextId(int minId)
		{
			int num = -1;
			for (int i = minId; i <= this.m_MaxId; i++)
			{
				if (this.SearchId(i) == null)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00027198 File Offset: 0x00025398
		public IdObject CreateNewId()
		{
			int newId = this.GetNewId();
			if (newId < 0)
			{
				return null;
			}
			IdObject idObject = IdObject.Create(this.m_Type, newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000271C8 File Offset: 0x000253C8
		public IdObject CreateNewId(int newId)
		{
			if (this.SearchId(newId) != null)
			{
				return null;
			}
			IdObject idObject = IdObject.Create(this.m_Type, newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000271F8 File Offset: 0x000253F8
		public IdObject CloneId(IdObject srcIdObject)
		{
			int newId = this.GetNewId();
			if (newId < 0)
			{
				return null;
			}
			IdObject idObject = srcIdObject.Clone(newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00027224 File Offset: 0x00025424
		public IdObject CloneId(int srcId)
		{
			IdObject idObject = this.SearchId(srcId);
			if (idObject == null)
			{
				return null;
			}
			return this.CloneId(idObject);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00027248 File Offset: 0x00025448
		public IdObject CloneId(IdObject srcIdObject, int newId)
		{
			IdObject idObject = srcIdObject.Clone(newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00027268 File Offset: 0x00025468
		public IdObject CloneId(IdObject srcIdObject, IdObject newObject)
		{
			IdObject idObject = srcIdObject.Clone(newObject.Id);
			this.RemoveId(newObject);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00027293 File Offset: 0x00025493
		public virtual IdArrayList Filter(IdObject filterValue)
		{
			return this;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00027293 File Offset: 0x00025493
		public virtual IdArrayList Filter(IdObject filterValue, bool flag)
		{
			return this;
		}

		// Token: 0x04000E2E RID: 3630
		private int m_MinId;

		// Token: 0x04000E2F RID: 3631
		private int m_MaxId;

		// Token: 0x04000E30 RID: 3632
		private Type m_Type;

		// Token: 0x04000E31 RID: 3633
		private IdObjectComparer m_Comparer = new IdObjectComparer();
	}
}
