using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace FifaControls
{
	// Token: 0x02000019 RID: 25
	public class Viewer3D : UserControl
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000107F7 File Offset: 0x0000E9F7
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000107FF File Offset: 0x0000E9FF
		public bool[] ZbufferRenderState
		{
			get
			{
				return this.m_ZbufferRenderState;
			}
			set
			{
				this.m_ZbufferRenderState = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00010808 File Offset: 0x0000EA08
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00010810 File Offset: 0x0000EA10
		public float RotationYCoeff
		{
			get
			{
				return this.m_RotationYCoeff;
			}
			set
			{
				this.m_RotationYCoeff = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00010819 File Offset: 0x0000EA19
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00010821 File Offset: 0x0000EA21
		public float ViewX
		{
			get
			{
				return this.m_StartViewX;
			}
			set
			{
				this.m_ViewX = value;
				this.m_StartViewX = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00010831 File Offset: 0x0000EA31
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00010839 File Offset: 0x0000EA39
		public float ViewY
		{
			get
			{
				return this.m_StartViewY;
			}
			set
			{
				this.m_ViewY = value;
				this.m_StartViewY = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00010849 File Offset: 0x0000EA49
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00010851 File Offset: 0x0000EA51
		public float ViewZ
		{
			get
			{
				return this.m_StartViewZ;
			}
			set
			{
				this.m_ViewZ = value;
				this.m_StartViewZ = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00010861 File Offset: 0x0000EA61
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00010869 File Offset: 0x0000EA69
		public float RotationX
		{
			get
			{
				return this.m_StartRotationX;
			}
			set
			{
				this.m_RotationX = value;
				this.m_StartRotationX = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00010879 File Offset: 0x0000EA79
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00010881 File Offset: 0x0000EA81
		public float RotationY
		{
			get
			{
				return this.m_StartRotationY;
			}
			set
			{
				this.m_RotationY = value;
				this.m_StartRotationY = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00010891 File Offset: 0x0000EA91
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00010899 File Offset: 0x0000EA99
		public float LightDirectionZ
		{
			get
			{
				return this.m_LightDirectionZ;
			}
			set
			{
				this.m_LightDirectionZ = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000108A2 File Offset: 0x0000EAA2
		// (set) Token: 0x0600016D RID: 365 RVA: 0x000108AA File Offset: 0x0000EAAA
		public float LightDirectionY
		{
			get
			{
				return this.m_LightDirectionY;
			}
			set
			{
				this.m_LightDirectionY = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000108B3 File Offset: 0x0000EAB3
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000108BB File Offset: 0x0000EABB
		public float LightDirectionX
		{
			get
			{
				return this.m_LightDirectionX;
			}
			set
			{
				this.m_LightDirectionX = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000108C4 File Offset: 0x0000EAC4
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000108CC File Offset: 0x0000EACC
		public float LightX
		{
			get
			{
				return this.m_LightX;
			}
			set
			{
				this.m_LightX = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000108D5 File Offset: 0x0000EAD5
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000108DD File Offset: 0x0000EADD
		public float LightY
		{
			get
			{
				return this.m_LightY;
			}
			set
			{
				this.m_LightY = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000108E6 File Offset: 0x0000EAE6
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000108EE File Offset: 0x0000EAEE
		public float LightZ
		{
			get
			{
				return this.m_LightZ;
			}
			set
			{
				this.m_LightZ = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000108F7 File Offset: 0x0000EAF7
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000108FF File Offset: 0x0000EAFF
		public Color AmbientColor
		{
			get
			{
				return this.m_AmbientColor;
			}
			set
			{
				this.m_AmbientColor = value;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00010908 File Offset: 0x0000EB08
		public Viewer3D()
		{
			this.InitializeComponent();
			if (!this.InitializeHardwareGraphics())
			{
				this.InitializeSoftwareGraphics();
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00010988 File Offset: 0x0000EB88
		public bool InitializeHardwareGraphics()
		{
			try
			{
				this.m_PresentParams.Windowed = true;
				this.m_PresentParams.SwapEffect = SwapEffect.Discard;
				this.m_PresentParams.EnableAutoDepthStencil = true;
				this.m_PresentParams.AutoDepthStencilFormat = DepthFormat.D16;
				this.m_Device = new Device(0, DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing, new PresentParameters[] { this.m_PresentParams });
				this.m_Device.DeviceReset += this.OnResetDevice;
				this.OnResetDevice(this.m_Device, null);
				this.pause = false;
			}
			catch (DirectXException)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00010A2C File Offset: 0x0000EC2C
		public bool InitializeSoftwareGraphics()
		{
			try
			{
				this.m_PresentParams.Windowed = true;
				this.m_PresentParams.SwapEffect = SwapEffect.Discard;
				this.m_PresentParams.EnableAutoDepthStencil = true;
				this.m_PresentParams.AutoDepthStencilFormat = DepthFormat.D16;
				this.m_Device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing | CreateFlags.FpuPreserve, new PresentParameters[] { this.m_PresentParams });
				this.m_Device.DeviceReset += this.OnResetDevice;
				this.OnResetDevice(this.m_Device, null);
				this.pause = false;
			}
			catch (DirectXException)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		public void ShowEmpty()
		{
			this.m_Materials = null;
			this.Render();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00010AE0 File Offset: 0x0000ECE0
		public void Show3D(string xFileName)
		{
			try
			{
				this.m_XFileName = Path.GetFileName(xFileName);
				this.m_XFilePath = Path.GetDirectoryName(xFileName);
				string currentDirectory = Environment.CurrentDirectory;
				Directory.SetCurrentDirectory(this.m_XFilePath);
				if (this.m_XFileMesh != null)
				{
					this.m_XFileMesh.Dispose();
				}
				if (this.m_ExtendedMaterials != null && this.m_Textures != null)
				{
					for (int i = 0; i < this.m_ExtendedMaterials.Length; i++)
					{
						if (this.m_Textures[i] != null)
						{
							this.m_Textures[i].Dispose();
						}
					}
				}
				this.m_XFileMesh = Mesh.FromFile(this.m_XFileName, MeshFlags.Managed, this.m_Device, out this.m_ExtendedMaterials);
				this.m_Textures = new Texture[this.m_ExtendedMaterials.Length];
				this.m_Materials = new Material[this.m_ExtendedMaterials.Length];
				for (int j = 0; j < this.m_ExtendedMaterials.Length; j++)
				{
					this.m_Materials[j] = this.m_ExtendedMaterials[j].Material3D;
					this.m_Materials[j].Ambient = this.m_Materials[j].Diffuse;
					if (this.m_Textures[j] != null)
					{
						this.m_Textures[j].Dispose();
					}
					this.m_Textures[j] = TextureLoader.FromFile(this.m_Device, this.m_ExtendedMaterials[j].TextureFilename);
				}
				this.Render();
				Directory.SetCurrentDirectory(currentDirectory);
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00010C94 File Offset: 0x0000EE94
		public void Show3D(Bitmap bitmap, int partIndex)
		{
			if (partIndex < 0 || partIndex >= this.m_Textures.Length)
			{
				return;
			}
			try
			{
				this.m_Textures[partIndex] = Texture.FromBitmap(this.m_Device, bitmap, Usage.Points, Pool.Default);
				this.m_Textures[partIndex].Dispose();
				this.Render();
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00010D08 File Offset: 0x0000EF08
		public void Show3D(Bitmap bitmap)
		{
			try
			{
				Texture texture = new Texture(this.m_Device, bitmap, Usage.RenderTarget, Pool.Managed);
				for (int i = 0; i < this.m_Textures.Length; i++)
				{
					this.m_Textures[i] = texture;
				}
				this.Render();
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00010D70 File Offset: 0x0000EF70
		private void OnResetDevice(object sender, EventArgs e)
		{
			this.m_Device.RenderState.ZBufferEnable = true;
			this.m_Device.RenderState.ZBufferFunction = Compare.Less;
			this.m_Device.RenderState.ZBufferWriteEnable = true;
			this.m_Device.RenderState.AlphaBlendEnable = true;
			this.m_Device.RenderState.AlphaTestEnable = false;
			this.m_Device.RenderState.AlphaFunction = Compare.Always;
			this.m_Device.RenderState.BlendOperation = BlendOperation.Add;
			this.m_Device.RenderState.SourceBlend = Blend.SourceAlpha;
			this.m_Device.RenderState.DestinationBlend = Blend.InvSourceAlpha;
			this.m_Device.RenderState.AlphaBlendOperation = BlendOperation.Max;
			this.m_Device.RenderState.AlphaSourceBlend = Blend.One;
			this.m_Device.RenderState.AlphaDestinationBlend = Blend.One;
			this.m_Device.RenderState.StencilEnable = false;
			this.m_Device.RenderState.FillMode = FillMode.Solid;
			this.m_Device.RenderState.CullMode = Cull.None;
			this.m_Device.RenderState.SpecularEnable = false;
			this.m_Device.RenderState.SpecularMaterialSource = ColorSource.Material;
			this.m_Device.RenderState.Ambient = this.m_AmbientColor;
			this.m_Device.Lights[0].Type = LightType.Directional;
			this.m_Device.Lights[0].Position = new Vector3(this.m_LightX, this.m_LightY, this.m_LightZ);
			this.m_Device.Lights[0].Diffuse = Color.White;
			this.m_Device.Lights[0].Direction = new Vector3(this.m_LightDirectionX, this.m_LightDirectionY, this.m_LightDirectionZ);
			this.m_Device.Lights[0].Enabled = true;
			this.m_Device.RenderState.Lighting = true;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00010F68 File Offset: 0x0000F168
		private void SetupMatrices()
		{
			this.m_Device.Transform.World = Matrix.RotationYawPitchRoll(this.m_RotationY, this.m_RotationX, 0f);
			this.m_Device.Transform.View = Matrix.LookAtLH(new Vector3(this.m_ViewX, this.m_ViewY, this.m_ViewZ), new Vector3(this.m_ViewX, this.m_ViewY, 0f), new Vector3(0f, 1f, 0f));
			float num = (float)base.Width / (float)base.Height;
			this.m_Device.Transform.Projection = Matrix.PerspectiveFovLH(0.7853982f, num, 1f, 1000f);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00011028 File Offset: 0x0000F228
		public void Render()
		{
			if (this.m_Device == null)
			{
				return;
			}
			if (this.pause)
			{
				return;
			}
			try
			{
				this.m_Device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Gray, 1f, 0);
				this.m_Device.Lights[0].Type = LightType.Directional;
				this.m_Device.Lights[0].Position = new Vector3(this.m_LightX, this.m_LightY, this.m_LightZ);
				this.m_Device.Lights[0].Diffuse = Color.White;
				this.m_Device.Lights[0].Direction = new Vector3(this.m_LightDirectionX, this.m_LightDirectionY, this.m_LightDirectionZ);
				this.m_Device.Lights[0].Enabled = true;
				this.m_Device.RenderState.Ambient = this.m_AmbientColor;
				this.m_Device.BeginScene();
				this.SetupMatrices();
				if (this.m_XFileMesh != null && this.m_Materials != null)
				{
					this.m_Device.RenderState.ZBufferWriteEnable = true;
					for (int i = 0; i < this.m_Materials.Length; i++)
					{
						int num = i;
						this.m_Device.Material = this.m_Materials[num];
						this.m_Device.SetTexture(0, this.m_Textures[num]);
						if (this.m_Materials.Length == 6 && (i == 4 || i == 5))
						{
							this.m_Device.RenderState.ZBufferWriteEnable = false;
						}
						this.m_XFileMesh.DrawSubset(num);
					}
				}
				if (this.m_Meshes != null && this.m_Materials != null)
				{
					for (int j = 0; j < this.m_Meshes.Length; j++)
					{
						this.m_Device.RenderState.ZBufferWriteEnable = this.m_ZbufferRenderState[j];
						if (this.m_Meshes[j] != null)
						{
							this.m_Device.Material = this.m_Materials[j];
							this.m_Device.SetTexture(0, this.m_Textures[j]);
							this.m_Meshes[j].DrawSubset(0);
						}
					}
				}
				this.m_Device.EndScene();
				this.m_Device.Present();
			}
			catch (DirectXException)
			{
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00011288 File Offset: 0x0000F488
		private void Viewer3D_MouseDown(object sender, MouseEventArgs e)
		{
			MouseButtons button = e.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.m_MouseState = 4;
						this.m_MouseX = e.X;
						this.m_MouseY = e.Y;
					}
				}
				else
				{
					this.m_MouseState = 2;
					this.m_MouseX = e.X;
					this.m_MouseY = e.Y;
				}
			}
			else
			{
				this.m_MouseState = 1;
				this.m_MouseX = e.X;
				this.m_MouseY = e.Y;
			}
			this.Render();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001131D File Offset: 0x0000F51D
		private void Viewer3D_MouseUp(object sender, MouseEventArgs e)
		{
			this.m_MouseState = 0;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00011328 File Offset: 0x0000F528
		private void Viewer3D_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.m_MouseState == 0)
			{
				int delta = e.Delta;
				return;
			}
			bool flag = false;
			switch (this.m_MouseState)
			{
			case 0:
				return;
			case 1:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_RotationY -= (float)num * 0.01f;
				while (this.m_RotationY < 0f)
				{
					this.m_RotationY += 6.28f;
				}
				while (this.m_RotationY > 6.28f)
				{
					this.m_RotationY -= 6.28f;
				}
				this.m_RotationX += (float)num2 * this.m_RotationYCoeff;
				while (this.m_RotationX < 0f)
				{
					this.m_RotationX += 6.28f;
				}
				while (this.m_RotationX > 6.28f)
				{
					this.m_RotationX -= 6.28f;
				}
				flag = true;
				break;
			}
			case 2:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_ViewZ -= (float)num2 * 0.2f;
				if (this.m_ViewZ < -1000f)
				{
					this.m_ViewZ = -1000f;
				}
				if (this.m_ViewZ > 1000f)
				{
					this.m_ViewZ = 1000f;
				}
				flag = true;
				break;
			}
			case 4:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_ViewX += (float)num * 0.2f;
				if (this.m_ViewX < -1000f)
				{
					this.m_ViewX = -1000f;
				}
				if (this.m_ViewX > 1000f)
				{
					this.m_ViewX = 1000f;
				}
				this.m_ViewY += (float)num2 * 0.2f;
				if (this.m_ViewY < -1000f)
				{
					this.m_ViewY = -1000f;
				}
				if (this.m_ViewY > 1000f)
				{
					this.m_ViewY = 1000f;
				}
				flag = true;
				break;
			}
			}
			this.m_MouseX = e.X;
			this.m_MouseY = e.Y;
			if (flag)
			{
				this.Render();
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00011574 File Offset: 0x0000F774
		private void Viewer3D_DoubleClick(object sender, EventArgs e)
		{
			this.m_RotationY = this.m_StartRotationY;
			this.m_RotationX = this.m_StartRotationX;
			this.m_ViewX = this.m_StartViewX;
			this.m_ViewY = this.m_StartViewY;
			this.m_ViewZ = this.m_StartViewZ;
			this.Render();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000115C4 File Offset: 0x0000F7C4
		public Bitmap Photo()
		{
			Bitmap bitmap2;
			try
			{
				Surface backBuffer = this.m_Device.GetBackBuffer(0, 0, BackBufferType.Mono);
				Bitmap bitmap = new Bitmap(SurfaceLoader.SaveToStream(ImageFileFormat.Bmp, backBuffer));
				backBuffer.Dispose();
				bitmap2 = bitmap;
			}
			catch
			{
				bitmap2 = null;
			}
			return bitmap2;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001160C File Offset: 0x0000F80C
		public void Clean(int nMeshes)
		{
			if (this.m_XFileMesh != null)
			{
				this.m_XFileMesh.Dispose();
				this.m_XFileMesh = null;
			}
			if (this.m_Textures != null)
			{
				for (int i = 0; i < this.m_Textures.Length; i++)
				{
					if (this.m_Textures[i] != null)
					{
						this.m_Textures[i].Dispose();
					}
				}
				this.m_Textures = null;
			}
			if (this.m_Meshes != null)
			{
				for (int j = 0; j < this.m_Meshes.Length; j++)
				{
					if (this.m_Meshes[j] != null)
					{
						this.m_Meshes[j].Dispose();
					}
				}
			}
			this.m_Meshes = new Mesh[nMeshes];
			if (nMeshes != 0)
			{
				this.m_Textures = new Texture[nMeshes];
				this.m_Materials = new Material[nMeshes];
				this.m_ZbufferRenderState = new bool[nMeshes];
				for (int k = 0; k < nMeshes; k++)
				{
					this.m_ZbufferRenderState[k] = true;
					this.m_Materials[k].Ambient = Color.FromArgb(0, 255, 255, 255);
					this.m_Materials[k].Diffuse = Color.FromArgb(0, 255, 255, 255);
					this.m_Materials[k].Specular = Color.FromArgb(0, 255, 255, 255);
				}
			}
			this.CleanBoundingBox();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00011776 File Offset: 0x0000F976
		public void SetMesh(int meshIndex, Model3D model3D)
		{
			this.SetMesh(meshIndex, model3D, true);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00011784 File Offset: 0x0000F984
		public void SetMesh(int meshIndex, Model3D model3D, bool zBufferState)
		{
			try
			{
				this.UpdateBoundingBox(model3D.Vertex);
				this.m_Meshes[meshIndex] = new Mesh(model3D.NFaces, model3D.NVertex, MeshFlags.Managed, VertexFormats.PositionNormal | VertexFormats.Texture1, this.m_Device);
				this.m_Meshes[meshIndex].SetIndexBufferData(model3D.Index, LockFlags.None);
				this.m_Meshes[meshIndex].SetVertexBufferData(model3D.Vertex, LockFlags.None);
				Texture texture = Texture.FromBitmap(this.m_Device, model3D.TextureBitmap, Usage.None, Pool.Managed);
				this.m_Textures[meshIndex] = texture;
				this.m_ZbufferRenderState[meshIndex] = zBufferState;
			}
			catch
			{
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001182C File Offset: 0x0000FA2C
		private void UpdateBoundingBox(CustomVertex.PositionNormalTextured[] Vertex)
		{
			for (int i = 0; i < Vertex.Length; i++)
			{
				if (Vertex[i].X < this.m_MinX)
				{
					this.m_MinX = Vertex[i].X;
				}
				if (Vertex[i].X > this.m_MaxX)
				{
					this.m_MaxX = Vertex[i].X;
				}
				if (Vertex[i].Y < this.m_MinY)
				{
					this.m_MinY = Vertex[i].Y;
				}
				if (Vertex[i].Y > this.m_MaxY)
				{
					this.m_MaxY = Vertex[i].Y;
				}
				if (Vertex[i].Z < this.m_MinZ)
				{
					this.m_MinZ = Vertex[i].Z;
				}
				if (Vertex[i].Z > this.m_MaxZ)
				{
					this.m_MaxZ = Vertex[i].Z;
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00011934 File Offset: 0x0000FB34
		private void CleanBoundingBox()
		{
			this.m_MinX = float.MaxValue;
			this.m_MinY = float.MaxValue;
			this.m_MinZ = float.MaxValue;
			this.m_MaxX = float.MinValue;
			this.m_MaxY = float.MinValue;
			this.m_MaxZ = float.MinValue;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00011984 File Offset: 0x0000FB84
		private void AutoView()
		{
			this.m_ViewX = (this.m_MinX + this.m_MaxX) / 2f;
			this.m_ViewY = (this.m_MinY + this.m_MaxY) / 2f;
			this.m_ViewZ = this.m_MaxZ * 3f;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000119D5 File Offset: 0x0000FBD5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000119F4 File Offset: 0x0000FBF4
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Gray;
			base.BorderStyle = BorderStyle.Fixed3D;
			base.Name = "Viewer3D";
			base.Size = new Size(305, 284);
			base.DoubleClick += this.Viewer3D_DoubleClick;
			base.MouseDown += this.Viewer3D_MouseDown;
			base.MouseMove += this.Viewer3D_MouseMove;
			base.MouseUp += this.Viewer3D_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x0400014A RID: 330
		private Device m_Device;

		// Token: 0x0400014B RID: 331
		private PresentParameters m_PresentParams = new PresentParameters();

		// Token: 0x0400014C RID: 332
		private Mesh m_XFileMesh;

		// Token: 0x0400014D RID: 333
		private Mesh[] m_Meshes;

		// Token: 0x0400014E RID: 334
		private Texture[] m_Textures;

		// Token: 0x0400014F RID: 335
		private Material[] m_Materials;

		// Token: 0x04000150 RID: 336
		private ExtendedMaterial[] m_ExtendedMaterials;

		// Token: 0x04000151 RID: 337
		private bool[] m_ZbufferRenderState;

		// Token: 0x04000152 RID: 338
		private bool pause;

		// Token: 0x04000153 RID: 339
		private int m_MouseState;

		// Token: 0x04000154 RID: 340
		private float m_RotationY;

		// Token: 0x04000155 RID: 341
		private float m_RotationX;

		// Token: 0x04000156 RID: 342
		private float m_ViewX;

		// Token: 0x04000157 RID: 343
		private float m_ViewY = 100f;

		// Token: 0x04000158 RID: 344
		private float m_ViewZ = 100f;

		// Token: 0x04000159 RID: 345
		private float m_LightDirectionX;

		// Token: 0x0400015A RID: 346
		private float m_LightDirectionY;

		// Token: 0x0400015B RID: 347
		private float m_LightDirectionZ;

		// Token: 0x0400015C RID: 348
		private float m_StartViewX;

		// Token: 0x0400015D RID: 349
		private float m_StartViewY = 100f;

		// Token: 0x0400015E RID: 350
		private float m_StartViewZ = 100f;

		// Token: 0x0400015F RID: 351
		private float m_StartRotationY;

		// Token: 0x04000160 RID: 352
		private float m_StartRotationX;

		// Token: 0x04000161 RID: 353
		private float m_LightX;

		// Token: 0x04000162 RID: 354
		private float m_LightY = 100f;

		// Token: 0x04000163 RID: 355
		private float m_LightZ = 100f;

		// Token: 0x04000164 RID: 356
		private float m_MinX;

		// Token: 0x04000165 RID: 357
		private float m_MinY;

		// Token: 0x04000166 RID: 358
		private float m_MinZ;

		// Token: 0x04000167 RID: 359
		private float m_MaxX;

		// Token: 0x04000168 RID: 360
		private float m_MaxY;

		// Token: 0x04000169 RID: 361
		private float m_MaxZ;

		// Token: 0x0400016A RID: 362
		private float m_RotationYCoeff = 0.01f;

		// Token: 0x0400016B RID: 363
		private string m_XFileName;

		// Token: 0x0400016C RID: 364
		private string m_XFilePath;

		// Token: 0x0400016D RID: 365
		private Color m_AmbientColor;

		// Token: 0x0400016E RID: 366
		private int m_MouseX;

		// Token: 0x0400016F RID: 367
		private int m_MouseY;

		// Token: 0x04000170 RID: 368
		private IContainer components;
	}
}
