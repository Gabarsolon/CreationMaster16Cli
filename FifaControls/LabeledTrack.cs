using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200000D RID: 13
	public class LabeledTrack : UserControl
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000A1C7 File Offset: 0x000083C7
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Category("User")]
		[Description("Label")]
		public string LabelText
		{
			get
			{
				return this.m_LabelText;
			}
			set
			{
				this.m_LabelText = value;
				if (value.Contains(" "))
				{
					value.Replace(' ', '-');
				}
				this.label.Text = this.m_LabelText + " " + this.track.Value.ToString();
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000A22A File Offset: 0x0000842A
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000A237 File Offset: 0x00008437
		[Category("User")]
		[Description("Value")]
		public int Value
		{
			get
			{
				return this.track.Value;
			}
			set
			{
				this.track.Value = value;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000A245 File Offset: 0x00008445
		public LabeledTrack()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000A260 File Offset: 0x00008460
		private void track_ValueChanged(object sender, EventArgs e)
		{
			this.label.Text = this.m_LabelText + " " + this.track.Value.ToString();
			if (this.ValueChanged != null)
			{
				this.ValueChanged(sender, this.track.Value);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000A2BA File Offset: 0x000084BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000A2DC File Offset: 0x000084DC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LabeledTrack));
			this.label = new Label();
			this.track = new TrackBar();
			((ISupportInitialize)this.track).BeginInit();
			base.SuspendLayout();
			this.label.BackColor = SystemColors.Control;
			this.label.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
			this.label.ForeColor = Color.Yellow;
			this.label.Image = (Image)componentResourceManager.GetObject("label.Image");
			this.label.ImeMode = ImeMode.NoControl;
			this.label.Location = new Point(1, -1);
			this.label.Name = "label";
			this.label.Size = new Size(100, 16);
			this.label.TabIndex = 90;
			this.label.Text = "Name";
			this.label.TextAlign = ContentAlignment.MiddleCenter;
			this.track.BackColor = SystemColors.Control;
			this.track.Cursor = Cursors.Default;
			this.track.ImeMode = ImeMode.NoControl;
			this.track.LargeChange = 10;
			this.track.Location = new Point(-7, 6);
			this.track.Maximum = 99;
			this.track.Minimum = 1;
			this.track.Name = "track";
			this.track.Size = new Size(116, 45);
			this.track.TabIndex = 89;
			this.track.TickFrequency = 10;
			this.track.Value = 99;
			this.track.ValueChanged += this.track_ValueChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label);
			base.Controls.Add(this.track);
			base.Name = "LabeledTrack";
			base.Size = new Size(104, 45);
			((ISupportInitialize)this.track).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008E RID: 142
		private string m_LabelText = string.Empty;

		// Token: 0x0400008F RID: 143
		public LabeledTrack.ValueChangedHandler ValueChanged;

		// Token: 0x04000090 RID: 144
		private IContainer components;

		// Token: 0x04000091 RID: 145
		private Label label;

		// Token: 0x04000092 RID: 146
		private TrackBar track;

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060001A2 RID: 418
		public delegate void ValueChangedHandler(object sender, int value);
	}
}
