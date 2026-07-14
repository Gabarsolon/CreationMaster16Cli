using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200001C RID: 28
	public class WeatherSelector : UserControl
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00015FD6 File Offset: 0x000141D6
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00015FE4 File Offset: 0x000141E4
		[Category("User")]
		[Description("Header")]
		public string Header
		{
			get
			{
				return this.labelText.Text;
			}
			set
			{
				this.labelText.Text = value;
				if (this.labelText.Text == "Jan")
				{
					this.month = 0;
					return;
				}
				if (this.labelText.Text == "Feb")
				{
					this.month = 1;
					return;
				}
				if (this.labelText.Text == "Mar")
				{
					this.month = 2;
					return;
				}
				if (this.labelText.Text == "Apr")
				{
					this.month = 3;
					return;
				}
				if (this.labelText.Text == "May")
				{
					this.month = 4;
					return;
				}
				if (this.labelText.Text == "Jun")
				{
					this.month = 5;
					return;
				}
				if (this.labelText.Text == "Jul")
				{
					this.month = 6;
					return;
				}
				if (this.labelText.Text == "Aug")
				{
					this.month = 7;
					return;
				}
				if (this.labelText.Text == "Sep")
				{
					this.month = 8;
					return;
				}
				if (this.labelText.Text == "Oct")
				{
					this.month = 9;
					return;
				}
				if (this.labelText.Text == "Nov")
				{
					this.month = 10;
					return;
				}
				if (this.labelText.Text == "Dec")
				{
					this.month = 11;
				}
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00016173 File Offset: 0x00014373
		public WeatherSelector()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00016188 File Offset: 0x00014388
		private void label1_Click(object sender, EventArgs e)
		{
			if (((MouseEventArgs)e).Button == MouseButtons.Left)
			{
				if (this.labelPicture.ImageIndex < 4)
				{
					Label label = this.labelPicture;
					int num = label.ImageIndex;
					label.ImageIndex = num + 1;
				}
				else
				{
					this.labelPicture.ImageIndex = 0;
				}
			}
			else if (this.labelPicture.ImageIndex > 0)
			{
				Label label2 = this.labelPicture;
				int num = label2.ImageIndex;
				label2.ImageIndex = num - 1;
			}
			else
			{
				this.labelPicture.ImageIndex = 4;
			}
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, this.Value, this.month);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0001622B File Offset: 0x0001442B
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00016238 File Offset: 0x00014438
		public int Value
		{
			get
			{
				return this.labelPicture.ImageIndex;
			}
			set
			{
				if (value < 0)
				{
					this.labelPicture.ImageIndex = 0;
					return;
				}
				if (value > 4)
				{
					this.labelPicture.ImageIndex = 4;
					return;
				}
				this.labelPicture.ImageIndex = value;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00016268 File Offset: 0x00014468
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00016288 File Offset: 0x00014488
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WeatherSelector));
			this.labelPicture = new Label();
			this.imageListWeather = new ImageList(this.components);
			this.labelText = new Label();
			base.SuspendLayout();
			this.labelPicture.BorderStyle = BorderStyle.Fixed3D;
			this.labelPicture.Dock = DockStyle.Bottom;
			this.labelPicture.ImageIndex = 0;
			this.labelPicture.ImageList = this.imageListWeather;
			this.labelPicture.Location = new Point(0, 15);
			this.labelPicture.Name = "labelPicture";
			this.labelPicture.Size = new Size(40, 30);
			this.labelPicture.TabIndex = 2;
			this.labelPicture.Click += this.label1_Click;
			this.imageListWeather.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListWeather.ImageStream");
			this.imageListWeather.TransparentColor = Color.Transparent;
			this.imageListWeather.Images.SetKeyName(0, "Weather_0.PNG");
			this.imageListWeather.Images.SetKeyName(1, "Weather_1.PNG");
			this.imageListWeather.Images.SetKeyName(2, "Weather_2.PNG");
			this.imageListWeather.Images.SetKeyName(3, "Weather_3.PNG");
			this.imageListWeather.Images.SetKeyName(4, "Weather_4.PNG");
			this.labelText.BorderStyle = BorderStyle.FixedSingle;
			this.labelText.Dock = DockStyle.Top;
			this.labelText.Location = new Point(0, 0);
			this.labelText.Name = "labelText";
			this.labelText.Size = new Size(40, 15);
			this.labelText.TabIndex = 3;
			this.labelText.Text = "TEX";
			this.labelText.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.labelPicture);
			base.Controls.Add(this.labelText);
			base.Name = "WeatherSelector";
			base.Size = new Size(40, 45);
			base.ResumeLayout(false);
		}

		// Token: 0x040001CA RID: 458
		private int month = -1;

		// Token: 0x040001CB RID: 459
		public WeatherSelector.WeatherEventHandler ValueChanged;

		// Token: 0x040001CC RID: 460
		private IContainer components;

		// Token: 0x040001CD RID: 461
		private Label labelPicture;

		// Token: 0x040001CE RID: 462
		private ImageList imageListWeather;

		// Token: 0x040001CF RID: 463
		public Label labelText;

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001DA RID: 474
		public delegate void WeatherEventHandler(object sender, int value, int month);
	}
}
