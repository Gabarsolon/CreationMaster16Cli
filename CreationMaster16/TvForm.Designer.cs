namespace CreationMaster
{
	// Token: 0x0200001F RID: 31
	public partial class TvForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000A3E15 File Offset: 0x000A2015
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000A3E34 File Offset: 0x000A2034
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.TvForm));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(1165, 798);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "TvForm";
			this.Text = "TvForm";
			base.ResumeLayout(false);
		}

		// Token: 0x04000A3D RID: 2621
		private global::System.ComponentModel.IContainer components;
	}
}
