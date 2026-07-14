using System;
using System.IO;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x0200007B RID: 123
	public class Rx3VertexArray
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003B883 File Offset: 0x00039A83
		public int nVertex
		{
			get
			{
				return this.m_nVertex;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0003B88B File Offset: 0x00039A8B
		public int VertexSize
		{
			get
			{
				return this.m_VertexSize;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003B893 File Offset: 0x00039A93
		public Rx3Vertex[] Vertexes
		{
			get
			{
				return this.m_Vertex;
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0003B89B File Offset: 0x00039A9B
		public Rx3VertexArray(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0003B8B4 File Offset: 0x00039AB4
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_nVertex = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_VertexSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown = r.ReadInt32();
				this.m_Vertex = new Rx3Vertex[this.m_nVertex];
				for (int i = 0; i < this.m_nVertex; i++)
				{
					this.m_Vertex[i] = new Rx3Vertex(r, this.m_VertexSize);
				}
			}
			else
			{
				this.m_Size = r.ReadInt32();
				this.m_nVertex = r.ReadInt32();
				this.m_VertexSize = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_Vertex = new Rx3Vertex[this.m_nVertex];
				for (int j = 0; j < this.m_nVertex; j++)
				{
					this.m_Vertex[j] = new Rx3Vertex(r, this.m_VertexSize);
				}
			}
			return true;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0003B9A8 File Offset: 0x00039BA8
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_nVertex));
				w.Write(FifaUtil.SwapEndian(this.m_VertexSize));
				w.Write(this.m_Unknown);
				for (int i = 0; i < this.m_nVertex; i++)
				{
					this.m_Vertex[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_Size);
				w.Write(this.m_nVertex);
				w.Write(this.m_VertexSize);
				w.Write(this.m_Unknown);
				for (int j = 0; j < this.m_nVertex; j++)
				{
					this.m_Vertex[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0003BA70 File Offset: 0x00039C70
		public bool SetVertex(CustomVertex.PositionNormalTextured[] newVertexes)
		{
			if (this.m_nVertex != newVertexes.Length)
			{
				return false;
			}
			for (int i = 0; i < this.m_nVertex; i++)
			{
				this.m_Vertex[i].X = newVertexes[i].X;
				this.m_Vertex[i].Y = newVertexes[i].Y;
				this.m_Vertex[i].Z = newVertexes[i].Z;
			}
			return true;
		}

		// Token: 0x04000FE5 RID: 4069
		private int m_Size;

		// Token: 0x04000FE6 RID: 4070
		private int m_nVertex;

		// Token: 0x04000FE7 RID: 4071
		private int m_VertexSize;

		// Token: 0x04000FE8 RID: 4072
		private int m_Unknown;

		// Token: 0x04000FE9 RID: 4073
		private Rx3Vertex[] m_Vertex;

		// Token: 0x04000FEA RID: 4074
		private bool m_SwapEndian;
	}
}
