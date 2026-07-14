using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200007C RID: 124
	public class Rx3Vertex
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0003BAE7 File Offset: 0x00039CE7
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0003BAEE File Offset: 0x00039CEE
		public static Rx3Vertex.EFloatType FloatType
		{
			get
			{
				return Rx3Vertex.s_FloatType;
			}
			set
			{
				Rx3Vertex.s_FloatType = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003BAF6 File Offset: 0x00039CF6
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0003BAFE File Offset: 0x00039CFE
		public float X
		{
			get
			{
				return this.m_X;
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003BB07 File Offset: 0x00039D07
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x0003BB0F File Offset: 0x00039D0F
		public float Y
		{
			get
			{
				return this.m_Y;
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0003BB18 File Offset: 0x00039D18
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x0003BB20 File Offset: 0x00039D20
		public float Z
		{
			get
			{
				return this.m_Z;
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0003BB29 File Offset: 0x00039D29
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0003BB31 File Offset: 0x00039D31
		public float U
		{
			get
			{
				return this.m_U;
			}
			set
			{
				this.m_U = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0003BB3A File Offset: 0x00039D3A
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0003BB42 File Offset: 0x00039D42
		public float V
		{
			get
			{
				return this.m_V;
			}
			set
			{
				this.m_V = value;
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0003BB4C File Offset: 0x00039D4C
		public Rx3Vertex(BinaryReader r, int vertexSize)
		{
			this.m_VertexSize = vertexSize;
			if (this.m_VertexSize == 20)
			{
				this.Load20_ShortFloat(r);
			}
			if (this.m_VertexSize == 24)
			{
				this.Load24_ShortFloat(r);
			}
			if (this.m_VertexSize == 28)
			{
				this.Load28_ShortFloat(r);
			}
			if (this.m_VertexSize == 32)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load32_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load32_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 36)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load36_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load36_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 40)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load40_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load40_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 44)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load44_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load44_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 48)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load48_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load48_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 52 && Rx3Vertex.s_FloatType != Rx3Vertex.EFloatType.Float16 && Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
			{
				this.Load52_LongFloat(r);
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0003BCA4 File Offset: 0x00039EA4
		public bool Load24_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0003BD90 File Offset: 0x00039F90
		public bool Load20_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0003BE54 File Offset: 0x0003A054
		public bool Load28_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003BF64 File Offset: 0x0003A164
		public bool Load32_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0003C09C File Offset: 0x0003A29C
		public bool Load32_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0003C18C File Offset: 0x0003A38C
		public bool Load36_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[11] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[12] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0003C2EC File Offset: 0x0003A4EC
		public bool Load36_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
		public bool Load40_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[11] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[12] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[13] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[14] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0003C540 File Offset: 0x0003A740
		public bool Load40_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			this.m_Unknown[7] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0003C61C File Offset: 0x0003A81C
		public bool Load44_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[11] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[12] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[13] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[14] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[15] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[16] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		public bool Load44_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = r.ReadSingle();
			this.m_Unknown[1] = r.ReadSingle();
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = r.ReadSingle();
			this.m_Unknown[3] = r.ReadSingle();
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0003C884 File Offset: 0x0003AA84
		public bool Load48_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[11] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[12] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[13] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[14] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[15] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[16] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[17] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[18] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		public bool Load48_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = r.ReadSingle();
			this.m_Unknown[1] = r.ReadSingle();
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = r.ReadSingle();
			this.m_Unknown[3] = r.ReadSingle();
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			this.m_Unknown[7] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0003CB24 File Offset: 0x0003AD24
		public bool Load52_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = (this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16()));
			this.m_V = (this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16()));
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[8] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[9] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[10] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[11] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[12] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[13] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[14] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[15] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[16] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[17] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[18] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[19] = FifaUtil.ConvertToFloat(r.ReadInt16());
			if (this.m_U >= 0f && this.m_U <= 1f && this.m_V >= 0f)
			{
				float v = this.m_V;
			}
			return true;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0003CD24 File Offset: 0x0003AF24
		public bool Save(BinaryWriter w)
		{
			if (this.m_VertexSize == 20)
			{
				this.Save20_ShortFloat(w);
			}
			if (this.m_VertexSize == 32)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save32_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save32_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 36)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save36_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save36_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 40)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save40_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save40_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 44)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save44_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save44_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 48)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save48_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save48_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 52)
			{
				this.Save52_LongFloat(w);
			}
			return true;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0003CE30 File Offset: 0x0003B030
		public bool Save20_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(14, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0003CE7C File Offset: 0x0003B07C
		public bool Save32_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(26, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		public bool Save32_LongFloat(BinaryWriter w)
		{
			w.Write(-this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(20, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0003CEFC File Offset: 0x0003B0FC
		public bool Save36_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(30, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0003CF48 File Offset: 0x0003B148
		public bool Save36_LongFloat(BinaryWriter w)
		{
			w.Write(-this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(24, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0003CF7C File Offset: 0x0003B17C
		public bool Save40_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(34, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		public bool Save40_LongFloat(BinaryWriter w)
		{
			w.Write(this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(28, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0003CFFC File Offset: 0x0003B1FC
		public bool Save44_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(38, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0003D048 File Offset: 0x0003B248
		public bool Save44_LongFloat(BinaryWriter w)
		{
			w.Write(-this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(32, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0003D07C File Offset: 0x0003B27C
		public bool Save48_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(-this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(42, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		public bool Save48_LongFloat(BinaryWriter w)
		{
			w.Write(-this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(36, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0003D0FA File Offset: 0x0003B2FA
		public bool Save52_LongFloat(BinaryWriter w)
		{
			w.Write(-this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(40, SeekOrigin.Current);
			return true;
		}

		// Token: 0x04000FEB RID: 4075
		private static Rx3Vertex.EFloatType s_FloatType;

		// Token: 0x04000FEC RID: 4076
		private int m_VertexSize;

		// Token: 0x04000FED RID: 4077
		private float m_X;

		// Token: 0x04000FEE RID: 4078
		private float m_Y;

		// Token: 0x04000FEF RID: 4079
		private float m_Z;

		// Token: 0x04000FF0 RID: 4080
		private float m_U;

		// Token: 0x04000FF1 RID: 4081
		private float m_V;

		// Token: 0x04000FF2 RID: 4082
		private float[] m_Unknown = new float[20];

		// Token: 0x020000C4 RID: 196
		public enum EFloatType
		{
			// Token: 0x0400128A RID: 4746
			Float16,
			// Token: 0x0400128B RID: 4747
			Float32
		}
	}
}
