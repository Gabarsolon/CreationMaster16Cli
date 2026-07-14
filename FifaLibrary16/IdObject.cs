using System;
using System.Reflection;

namespace FifaLibrary
{
	// Token: 0x0200004A RID: 74
	public class IdObject
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00026E4A File Offset: 0x0002504A
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00026E52 File Offset: 0x00025052
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

		// Token: 0x0600052C RID: 1324 RVA: 0x00026E5B File Offset: 0x0002505B
		public IdObject()
		{
			this.m_Id = -1;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00026E6A File Offset: 0x0002506A
		public IdObject(int id)
		{
			this.m_Id = id;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00026E79 File Offset: 0x00025079
		public virtual IdObject Clone(int newId)
		{
			IdObject idObject = (IdObject)base.MemberwiseClone();
			idObject.Id = newId;
			return idObject;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00026E8D File Offset: 0x0002508D
		public virtual bool Delete()
		{
			return true;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00026E90 File Offset: 0x00025090
		public static IdObject Create(Type type, int newId)
		{
			Type[] array = new Type[] { typeof(int) };
			object[] array2 = new object[] { newId };
			ConstructorInfo constructor = type.GetConstructor(array);
			if (constructor == null)
			{
				return null;
			}
			return (IdObject)constructor.Invoke(array2);
		}

		// Token: 0x04000E2D RID: 3629
		private int m_Id;
	}
}
