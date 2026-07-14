using System;

namespace FifaLibrary
{
	// Token: 0x02000055 RID: 85
	public class Matrix3x3
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		public float Determinant
		{
			get
			{
				return this.m_Determinant;
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		public Matrix3x3(float c00, float c01, float c02, float c10, float c11, float c12, float c20, float c21, float c22)
		{
			this.a = c00;
			this.b = c01;
			this.c = c02;
			this.d = c10;
			this.e = c11;
			this.f = c12;
			this.g = c20;
			this.h = c21;
			this.i = c22;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002AA38 File Offset: 0x00028C38
		public Matrix3x3(int c00, int c01, int c02, int c10, int c11, int c12, int c20, int c21, int c22)
		{
			this.a = (float)c00;
			this.b = (float)c01;
			this.c = (float)c02;
			this.d = (float)c10;
			this.e = (float)c11;
			this.f = (float)c12;
			this.g = (float)c20;
			this.h = (float)c21;
			this.i = (float)c22;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002AA9C File Offset: 0x00028C9C
		public float ComputeDeterminant()
		{
			this.m_Determinant = this.a * (this.e * this.i - this.f * this.h) - this.b * (this.i * this.d - this.f * this.g) + this.c * (this.d * this.h - this.e * this.g);
			return this.m_Determinant;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0002AB20 File Offset: 0x00028D20
		public Matrix3x3 Invert()
		{
			this.ComputeDeterminant();
			if (this.m_Determinant != 0f)
			{
				float num = (this.e * this.i - this.f * this.h) / this.m_Determinant;
				float num2 = (this.f * this.g - this.d * this.i) / this.m_Determinant;
				float num3 = (this.d * this.h - this.e * this.g) / this.m_Determinant;
				float num4 = (this.c * this.h - this.b * this.i) / this.m_Determinant;
				float num5 = (this.a * this.i - this.c * this.g) / this.m_Determinant;
				float num6 = (this.b * this.g - this.a * this.h) / this.m_Determinant;
				float num7 = (this.b * this.f - this.c * this.e) / this.m_Determinant;
				float num8 = (this.c * this.d - this.a * this.f) / this.m_Determinant;
				float num9 = (this.a * this.e - this.b * this.d) / this.m_Determinant;
				return new Matrix3x3(num, num2, num3, num4, num5, num6, num7, num8, num9);
			}
			return null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0002AC98 File Offset: 0x00028E98
		public Vector3x1 PostMultiply(Vector3x1 v)
		{
			float num = this.a * v.X + this.b * v.Y + this.c * v.Z;
			float num2 = this.d * v.X + this.e * v.Y + this.f * v.Z;
			float num3 = this.g * v.X + this.h * v.Y + this.i * v.Z;
			return new Vector3x1(num, num2, num3);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002AD2C File Offset: 0x00028F2C
		public Vector3x1 PreMultiply(Vector3x1 v)
		{
			float num = this.a * v.X + this.d * v.Y + this.g * v.Z;
			float num2 = this.b * v.X + this.e * v.Y + this.h * v.Z;
			float num3 = this.c * v.X + this.f * v.Y + this.i * v.Z;
			return new Vector3x1(num, num2, num3);
		}

		// Token: 0x04000E81 RID: 3713
		private float a;

		// Token: 0x04000E82 RID: 3714
		private float b;

		// Token: 0x04000E83 RID: 3715
		private float c;

		// Token: 0x04000E84 RID: 3716
		private float d;

		// Token: 0x04000E85 RID: 3717
		private float e;

		// Token: 0x04000E86 RID: 3718
		private float f;

		// Token: 0x04000E87 RID: 3719
		private float g;

		// Token: 0x04000E88 RID: 3720
		private float h;

		// Token: 0x04000E89 RID: 3721
		private float i;

		// Token: 0x04000E8A RID: 3722
		private float m_Determinant;
	}
}
