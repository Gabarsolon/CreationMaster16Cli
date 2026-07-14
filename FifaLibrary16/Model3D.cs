using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x020000A4 RID: 164
	public class Model3D
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x0005ACC3 File Offset: 0x00058EC3
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x0005ACBA File Offset: 0x00058EBA
		public string TextureFileName
		{
			get
			{
				return this.m_TextureFileName;
			}
			set
			{
				this.m_TextureFileName = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0005ACCB File Offset: 0x00058ECB
		public Bitmap TextureBitmap
		{
			get
			{
				return this.m_TextureBitmap;
			}
			set
			{
				this.m_TextureBitmap = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0005ACDC File Offset: 0x00058EDC
		public int NVertex
		{
			get
			{
				return this.m_NVertex;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0005ACE4 File Offset: 0x00058EE4
		public int NIndex
		{
			get
			{
				return this.m_NIndex;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0005ACEC File Offset: 0x00058EEC
		public CustomVertex.PositionNormalTextured[] Vertex
		{
			get
			{
				return this.m_Vertex;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x0005ACF4 File Offset: 0x00058EF4
		public short[] Index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x0005ACFC File Offset: 0x00058EFC
		public int NFaces
		{
			get
			{
				return this.m_NFaces;
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00004648 File Offset: 0x00002848
		public Model3D()
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0005AD04 File Offset: 0x00058F04
		public Model3D(Rx3IndexArray indexArray, Rx3VertexArray vertexArray)
		{
			this.Initialize(indexArray, vertexArray);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0005AD14 File Offset: 0x00058F14
		public Model3D(Rx3IndexArray indexArray, Rx3VertexArray vertexArray, Bitmap textureBitmap)
		{
			this.Initialize(indexArray, vertexArray);
			this.m_TextureBitmap = textureBitmap;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0005AD2B File Offset: 0x00058F2B
		public void Initialize(Rx3IndexArray indexArray, Rx3VertexArray vertexArray)
		{
			this.SetVertexArray(vertexArray);
			this.SetIndexArray(indexArray);
			this.ComputeNormals();
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0005AD44 File Offset: 0x00058F44
		private void SetIndexArray(Rx3IndexArray indexArray)
		{
			this.m_NIndex = indexArray.NIndex;
			this.m_NOriginalIndex = this.m_NIndex;
			this.m_IndexStream = indexArray.IndexStream;
			this.m_NFaces = indexArray.nFaces;
			this.m_IsTriangleList = indexArray.IsTriangleList;
			if (!this.m_IsTriangleList)
			{
				this.m_Index = new short[this.m_NIndex];
				for (int i = 0; i < this.m_NIndex; i += 3)
				{
					this.m_Index[i] = this.m_IndexStream[i];
					this.m_Index[i + 1] = this.m_IndexStream[i + 1];
					this.m_Index[i + 2] = this.m_IndexStream[i + 2];
				}
				return;
			}
			this.m_Index = new short[this.m_NFaces * 3];
			int num = 0;
			int num2 = ((Rx3IndexArray.TriangleListType == Rx3IndexArray.ETriangleListType.InvertOdd) ? 1 : 0);
			for (int j = 0; j < this.m_NIndex - 2; j++)
			{
				short num3 = this.m_IndexStream[j];
				short num4 = this.m_IndexStream[j + 1];
				short num5 = this.m_IndexStream[j + 2];
				if ((int)num3 > this.m_NVertex || (int)num4 > this.m_NVertex || (int)num5 > this.m_NVertex || num3 < 0 || num4 < 0 || num5 < 0)
				{
					break;
				}
				if (num3 != num4 && num4 != num5 && num3 != num5)
				{
					if ((j & 1) == num2)
					{
						this.m_Index[num++] = num3;
						this.m_Index[num++] = num4;
						this.m_Index[num++] = num5;
					}
					else
					{
						this.m_Index[num++] = num3;
						this.m_Index[num++] = num5;
						this.m_Index[num++] = num4;
					}
				}
			}
			this.m_NIndex = this.m_NFaces * 3;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0005AF08 File Offset: 0x00059108
		private void SetVertexArray(Rx3VertexArray vertexArray)
		{
			this.m_NVertex = vertexArray.nVertex;
			this.m_NOriginalVertex = this.m_NVertex;
			this.m_Vertex = new CustomVertex.PositionNormalTextured[this.m_NVertex];
			for (int i = 0; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = vertexArray.Vertexes[i].X;
				this.m_Vertex[i].Y = vertexArray.Vertexes[i].Y;
				this.m_Vertex[i].Z = vertexArray.Vertexes[i].Z;
				this.m_Vertex[i].Tu = vertexArray.Vertexes[i].U;
				this.m_Vertex[i].Tv = vertexArray.Vertexes[i].V;
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0005AFEC File Offset: 0x000591EC
		public Model3D Clone()
		{
			Model3D model3D = (Model3D)base.MemberwiseClone();
			model3D.m_Index = (short[])this.m_Index.Clone();
			model3D.m_IndexStream = (short[])this.m_IndexStream.Clone();
			model3D.m_Vertex = (CustomVertex.PositionNormalTextured[])this.m_Vertex.Clone();
			return model3D;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0005B048 File Offset: 0x00059248
		private void ComputeNormals()
		{
			Vector3[] array = new Vector3[this.m_NVertex];
			int[] array2 = new int[this.m_NVertex];
			for (int i = 0; i < this.m_NFaces; i++)
			{
				int num = (int)this.m_Index[i * 3];
				int num2 = (int)this.m_Index[i * 3 + 1];
				int num3 = (int)this.m_Index[i * 3 + 2];
				Vector3 vector = new Vector3(this.m_Vertex[num].X, this.m_Vertex[num].Y, this.m_Vertex[num].Z);
				Vector3 vector2 = new Vector3(this.m_Vertex[num2].X, this.m_Vertex[num2].Y, this.m_Vertex[num2].Z);
				Vector3 vector3 = new Vector3(this.m_Vertex[num3].X, this.m_Vertex[num3].Y, this.m_Vertex[num3].Z);
				Vector3 vector4 = Vector3.Subtract(vector2, vector);
				Vector3 vector5 = Vector3.Normalize(Vector3.Cross(Vector3.Subtract(vector3, vector), vector4));
				array[num] = Vector3.Add(array[num], vector5);
				array[num2] = Vector3.Add(array[num2], vector5);
				array[num3] = Vector3.Add(array[num3], vector5);
				array2[num]++;
				array2[num2]++;
				array2[num3]++;
			}
			for (int j = 0; j < this.m_NVertex; j++)
			{
				Vector3 vector6 = Vector3.Scale(array[j], 1f / (float)array2[j]);
				this.m_Vertex[j].Nx = vector6.X;
				this.m_Vertex[j].Ny = vector6.Y;
				this.m_Vertex[j].Nz = vector6.Z;
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0005B260 File Offset: 0x00059460
		public bool CanMerge(Model3D model)
		{
			return model == null || (this.m_NOriginalVertex >= model.NVertex && this.m_NOriginalIndex >= model.NIndex);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0005B288 File Offset: 0x00059488
		public static bool CanMorphing(Model3D model1, Model3D model2)
		{
			return model1 != null && model2 != null && model1.NVertex == model2.NVertex;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0005B2A3 File Offset: 0x000594A3
		public bool CanMorphing(Model3D model2)
		{
			return Model3D.CanMorphing(this, model2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0005B2AC File Offset: 0x000594AC
		public bool Merge(Model3D model)
		{
			if (!this.CanMerge(model))
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (model != null)
			{
				num = model.NVertex;
				num2 = model.NIndex;
				num3 = model.NFaces;
			}
			for (int i = num; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = 0f;
				this.m_Vertex[i].Y = 0f;
				this.m_Vertex[i].Z = 0f;
				this.m_Vertex[i].Nx = 0f;
				this.m_Vertex[i].Ny = 0f;
				this.m_Vertex[i].Nz = 0f;
				this.m_Vertex[i].Tu = 0f;
				this.m_Vertex[i].Tv = 0f;
			}
			this.m_NVertex = num;
			for (int j = 0; j < this.m_NVertex; j++)
			{
				this.m_Vertex[j].X = model.Vertex[j].X;
				this.m_Vertex[j].Y = model.Vertex[j].Y;
				this.m_Vertex[j].Z = model.Vertex[j].Z;
				this.m_Vertex[j].Nx = model.Vertex[j].Nx;
				this.m_Vertex[j].Ny = model.Vertex[j].Ny;
				this.m_Vertex[j].Nz = model.Vertex[j].Nz;
				this.m_Vertex[j].Tu = model.Vertex[j].Tu;
				this.m_Vertex[j].Tv = model.Vertex[j].Tv;
			}
			for (int k = num2; k < this.m_NIndex; k++)
			{
				this.m_IndexStream[k] = 0;
			}
			this.m_NIndex = num2;
			for (int l = 0; l < this.m_NIndex; l++)
			{
				this.m_IndexStream[l] = model.m_IndexStream[l];
			}
			if (num3 < this.m_NFaces)
			{
				for (int m = num3 * 3; m < this.m_NFaces * 3; m++)
				{
					this.m_Index[m] = 0;
				}
			}
			else
			{
				Array.Resize<short>(ref this.m_Index, num3 * 3);
			}
			this.m_NFaces = num3;
			for (int n = 0; n < this.m_NFaces * 3; n++)
			{
				this.m_Index[n] = model.m_Index[n];
			}
			return true;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0005B5A8 File Offset: 0x000597A8
		public bool Morphing(Model3D model, float percent)
		{
			if (!this.CanMorphing(model))
			{
				return false;
			}
			float num = 1f - percent;
			this.m_NVertex = model.NVertex;
			for (int i = 0; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = this.m_Vertex[i].X * num + model.Vertex[i].X * percent;
				this.m_Vertex[i].Y = this.m_Vertex[i].Y * num + model.Vertex[i].Y * percent;
				this.m_Vertex[i].Z = this.m_Vertex[i].Z * num + model.Vertex[i].Z * percent;
				this.m_Vertex[i].Tu = this.m_Vertex[i].Tu * num + model.Vertex[i].Tu * percent;
				this.m_Vertex[i].Tv = this.m_Vertex[i].Tv * num + model.Vertex[i].Tv * percent;
			}
			return true;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0005B704 File Offset: 0x00059904
		public bool Morphing(Model3D model1, Model3D model2, float percent)
		{
			if (!Model3D.CanMorphing(model1, model2))
			{
				return false;
			}
			if (!this.CanMorphing(model1))
			{
				return false;
			}
			float num = 1f - percent;
			int num2 = this.m_NVertex;
			if (model1.NVertex < num2)
			{
				num2 = model1.NVertex;
			}
			if (model2.NVertex < num2)
			{
				num2 = model2.NVertex;
			}
			this.m_NVertex = num2;
			for (int i = 0; i < num2; i++)
			{
				this.m_Vertex[i].X = model1.m_Vertex[i].X * num + model2.Vertex[i].X * percent;
				this.m_Vertex[i].Y = model1.m_Vertex[i].Y * num + model2.Vertex[i].Y * percent;
				this.m_Vertex[i].Z = model1.m_Vertex[i].Z * num + model2.Vertex[i].Z * percent;
				this.m_Vertex[i].Tu = model1.m_Vertex[i].Tu * num + model2.Vertex[i].Tu * percent;
				this.m_Vertex[i].Tv = model1.m_Vertex[i].Tv * num + model2.Vertex[i].Tv * percent;
			}
			return true;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x0005B888 File Offset: 0x00059A88
		public bool MorphingThroughUV(Model3D model1, Model3D model2, float percent)
		{
			return this.MorphingThroughUV(model1, model2, percent, null);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x0005B894 File Offset: 0x00059A94
		public bool MorphingThroughUV(Model3D model1, Model3D model2, float percent, Bitmap mask)
		{
			float num = 1f - percent;
			float num2 = percent;
			if (model1.NVertex >= 3157 && model2.NVertex >= 3157 && this.NVertex >= 3157)
			{
				for (int i = 0; i < this.NVertex; i++)
				{
					if (mask != null)
					{
						int num3 = (int)(this.Vertex[i].Tu * (float)mask.Width);
						int num4 = (int)(this.Vertex[i].Tv * (float)mask.Height);
						num2 = (float)mask.GetPixel(num3, num4).R * percent / 255f;
						num = 1f - num2;
					}
					float num5 = float.MaxValue;
					int num6 = -1;
					for (int j = 0; j < model1.NVertex; j++)
					{
						float num7 = (this.Vertex[i].Tu - model1.Vertex[j].Tu) * (this.Vertex[i].Tu - model1.Vertex[j].Tu) + (this.Vertex[i].Tv - model1.Vertex[j].Tv) * (this.Vertex[i].Tv - model1.Vertex[j].Tv);
						if (num7 < num5)
						{
							num5 = num7;
							num6 = j;
						}
					}
					num5 = float.MaxValue;
					int num8 = -1;
					for (int k = 0; k < model2.NVertex; k++)
					{
						float num9 = (this.Vertex[i].Tu - model2.Vertex[k].Tu) * (this.Vertex[i].Tu - model2.Vertex[k].Tu) + (this.Vertex[i].Tv - model2.Vertex[k].Tv) * (this.Vertex[i].Tv - model2.Vertex[k].Tv);
						if (num9 < num5)
						{
							num5 = num9;
							num8 = k;
						}
					}
					if (num6 != -1 && num8 != -1)
					{
						this.Vertex[i].X = model1.Vertex[num6].X * num + model2.Vertex[num8].X * num2;
						this.Vertex[i].Y = model1.Vertex[num6].Y * num + model2.Vertex[num8].Y * num2;
						this.Vertex[i].Z = model1.Vertex[num6].Z * num + model2.Vertex[num8].Z * num2;
					}
				}
			}
			else
			{
				if (model1.NVertex != 132 || model2.NVertex != 132 || this.NVertex != 132)
				{
					return false;
				}
				for (int l = 0; l < this.NVertex; l++)
				{
					float num5 = float.MaxValue;
					int num6 = -1;
					for (int m = 0; m < model1.NVertex; m++)
					{
						if (this.Vertex[l].X * model1.Vertex[m].X > 0f)
						{
							float num10 = (this.Vertex[l].Tu - model1.Vertex[m].Tu) * (this.Vertex[l].Tu - model1.Vertex[m].Tu) + (this.Vertex[l].Tv - model1.Vertex[m].Tv) * (this.Vertex[l].Tv - model1.Vertex[m].Tv);
							if (num10 < num5)
							{
								num5 = num10;
								num6 = m;
							}
						}
					}
					num5 = float.MaxValue;
					int num8 = -1;
					for (int n = 0; n < model2.NVertex; n++)
					{
						if (this.Vertex[l].X * model2.Vertex[n].X > 0f)
						{
							float num11 = (this.Vertex[l].Tu - model2.Vertex[n].Tu) * (this.Vertex[l].Tu - model2.Vertex[n].Tu) + (this.Vertex[l].Tv - model2.Vertex[n].Tv) * (this.Vertex[l].Tv - model2.Vertex[n].Tv);
							if (num11 < num5)
							{
								num5 = num11;
								num8 = n;
							}
						}
					}
					if (num6 != -1 && num8 != -1)
					{
						this.Vertex[l].X = model1.Vertex[num6].X * num + model2.Vertex[num8].X * num2;
						this.Vertex[l].Y = model1.Vertex[num6].Y * num + model2.Vertex[num8].Y * num2;
						this.Vertex[l].Z = model1.Vertex[num6].Z * num + model2.Vertex[num8].Z * num2;
					}
				}
			}
			return true;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		public void MoveForward()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Z = vertex[num].Z + 0.1f;
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0005BEE4 File Offset: 0x0005A0E4
		public void MoveBack()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Z = vertex[num].Z - 0.1f;
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0005BF1C File Offset: 0x0005A11C
		public void MoveUp()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Y = vertex[num].Y + 0.1f;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x0005BF54 File Offset: 0x0005A154
		public void MoveDown()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Y = vertex[num].Y - 0.1f;
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0005BF8C File Offset: 0x0005A18C
		public void MoveLeft()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X + 0.1f;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0005BFC4 File Offset: 0x0005A1C4
		public void MoveRight()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X - 0.1f;
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0005BFFC File Offset: 0x0005A1FC
		public void MakeCloser()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				if (this.m_Vertex[i].X > 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
					int num = i;
					vertex[num].X = vertex[num].X - 0.1f;
				}
				else if (this.m_Vertex[i].X < 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
					int num2 = i;
					vertex2[num2].X = vertex2[num2].X + 0.1f;
				}
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0005C080 File Offset: 0x0005A280
		public void MakeWider()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				if (this.m_Vertex[i].X > 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
					int num = i;
					vertex[num].X = vertex[num].X + 0.1f;
				}
				else if (this.m_Vertex[i].X < 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
					int num2 = i;
					vertex2[num2].X = vertex2[num2].X - 0.1f;
				}
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0005C104 File Offset: 0x0005A304
		public void SaveXFile(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			this.SaveXFile(streamWriter);
			streamWriter.Close();
			fileStream.Close();
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0005C134 File Offset: 0x0005A334
		public void SaveXFile(StreamWriter w)
		{
			if (this.m_NVertex <= 0)
			{
				return;
			}
			w.WriteLine("xof 0303txt 0032");
			w.WriteLine("Mesh {");
			w.WriteLine(" {0};", this.m_NVertex);
			for (int i = 0; i < this.m_NVertex - 1; i++)
			{
				w.WriteLine(" {0:F6};{1:F6};{2:F6};,", this.m_Vertex[i].X, this.m_Vertex[i].Y, this.m_Vertex[i].Z);
			}
			w.WriteLine(" {0:F6};{1:F6};{2:F6};;", this.m_Vertex[this.m_NVertex - 1].X, this.m_Vertex[this.m_NVertex - 1].Y, this.m_Vertex[this.m_NVertex - 1].Z);
			w.WriteLine(" {0};", this.m_NFaces);
			for (int j = 0; j < this.m_NFaces - 1; j++)
			{
				w.WriteLine(" 3;{0},{1},{2};,", this.m_Index[j * 3 + 0], this.m_Index[j * 3 + 1], this.m_Index[j * 3 + 2]);
			}
			w.WriteLine(" 3;{0},{1},{2};;", this.m_Index[(this.m_NFaces - 1) * 3 + 0], this.m_Index[(this.m_NFaces - 1) * 3 + 1], this.m_Index[(this.m_NFaces - 1) * 3 + 2]);
			w.WriteLine(" MeshNormals {");
			w.WriteLine("  {0};", this.m_NVertex);
			for (int k = 0; k < this.m_NVertex - 1; k++)
			{
				w.WriteLine("  {0:F6};{1:F6};{2:F6};,", this.m_Vertex[k].Nx, this.m_Vertex[k].Ny, this.m_Vertex[k].Nz);
			}
			w.WriteLine("  {0:F6};{1:F6};{2:F6};;", this.m_Vertex[this.m_NVertex - 1].Nx, this.m_Vertex[this.m_NVertex - 1].Ny, this.m_Vertex[this.m_NVertex - 1].Nz);
			w.WriteLine(" {0};", this.m_NFaces);
			for (int l = 0; l < this.m_NFaces - 1; l++)
			{
				w.WriteLine("  3;{0},{1},{2};,", this.m_Index[l * 3 + 0], this.m_Index[l * 3 + 1], this.m_Index[l * 3 + 2]);
			}
			w.WriteLine("  3;{0},{1},{2};;", this.m_Index[(this.m_NFaces - 1) * 3 + 0], this.m_Index[(this.m_NFaces - 1) * 3 + 1], this.m_Index[(this.m_NFaces - 1) * 3 + 2]);
			w.WriteLine(" }");
			w.WriteLine(" MeshTextureCoords {");
			w.WriteLine("  {0};", this.m_NVertex);
			for (int m = 0; m < this.m_NVertex - 1; m++)
			{
				w.WriteLine("  {0:F6};{1:F6};,", this.m_Vertex[m].Tu, this.m_Vertex[m].Tv);
			}
			w.WriteLine("  {0:F6};{1:F6};;", this.m_Vertex[this.m_NVertex - 1].Tu, this.m_Vertex[this.m_NVertex - 1].Tv);
			w.WriteLine(" }");
			w.WriteLine(" MeshMaterialList {");
			w.WriteLine("  1;");
			w.WriteLine("  {0};", this.m_NFaces);
			for (int n = 0; n < this.m_NFaces - 1; n++)
			{
				w.WriteLine("  0,");
			}
			w.WriteLine("  0;");
			w.WriteLine("  Material {");
			w.WriteLine("   1.000000;1.000000;1.000000;0.000000;;");
			w.WriteLine("   0.000000;");
			w.WriteLine("   0.000000;0.000000;0.000000;;");
			w.WriteLine("   0.000000;0.000000;0.000000;;");
			w.WriteLine("   TextureFilename {");
			w.WriteLine("   \"" + this.m_TextureFileName + "\";");
			w.WriteLine("   }");
			w.WriteLine("  }");
			w.WriteLine(" }");
			w.WriteLine("}");
			this.m_TextureBitmap.Save(this.m_TextureFileName, ImageFormat.Png);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0005C654 File Offset: 0x0005A854
		public void OffsetVertex(int offsetX, int offsetY, int offsetZ)
		{
			if (this.m_Vertex == null)
			{
				return;
			}
			if (this.m_Vertex.Length < this.m_NOriginalVertex)
			{
				return;
			}
			for (int i = 0; i < this.m_NOriginalVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X - (float)offsetX;
				CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
				int num2 = i;
				vertex2[num2].Y = vertex2[num2].Y - (float)offsetY;
				CustomVertex.PositionNormalTextured[] vertex3 = this.m_Vertex;
				int num3 = i;
				vertex3[num3].Z = vertex3[num3].Z - (float)offsetZ;
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
		public void Morphing(int[] points, Vector3 symmetryPoint, Vector3 delta)
		{
			foreach (int num in points)
			{
				if (num >= 0 && num < this.NVertex)
				{
					if (this.Vertex[num].X < symmetryPoint.X)
					{
						CustomVertex.PositionNormalTextured[] vertex = this.Vertex;
						int num2 = num;
						vertex[num2].X = vertex[num2].X - delta.X;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex2 = this.Vertex;
						int num3 = num;
						vertex2[num3].X = vertex2[num3].X + delta.X;
					}
					if (this.Vertex[num].Y < symmetryPoint.Y)
					{
						CustomVertex.PositionNormalTextured[] vertex3 = this.Vertex;
						int num4 = num;
						vertex3[num4].Y = vertex3[num4].Y - delta.Y;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex4 = this.Vertex;
						int num5 = num;
						vertex4[num5].Y = vertex4[num5].Y + delta.Y;
					}
					if (this.Vertex[num].Z < symmetryPoint.Z)
					{
						CustomVertex.PositionNormalTextured[] vertex5 = this.Vertex;
						int num6 = num;
						vertex5[num6].Z = vertex5[num6].Z - delta.Z;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex6 = this.Vertex;
						int num7 = num;
						vertex6[num7].Z = vertex6[num7].Z + delta.Z;
					}
				}
			}
		}

		// Token: 0x040011EF RID: 4591
		private string m_TextureFileName;

		// Token: 0x040011F0 RID: 4592
		private Bitmap m_TextureBitmap;

		// Token: 0x040011F1 RID: 4593
		private int m_NVertex;

		// Token: 0x040011F2 RID: 4594
		private int m_NOriginalVertex;

		// Token: 0x040011F3 RID: 4595
		private int m_NIndex;

		// Token: 0x040011F4 RID: 4596
		private int m_NOriginalIndex;

		// Token: 0x040011F5 RID: 4597
		private bool m_IsTriangleList;

		// Token: 0x040011F6 RID: 4598
		private CustomVertex.PositionNormalTextured[] m_Vertex;

		// Token: 0x040011F7 RID: 4599
		private short[] m_Index;

		// Token: 0x040011F8 RID: 4600
		private short[] m_IndexStream;

		// Token: 0x040011F9 RID: 4601
		private int m_NFaces;
	}
}
