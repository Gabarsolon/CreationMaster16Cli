namespace CreationMaster
{
	// Token: 0x02000016 RID: 22
	public partial class WebBrowserForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00054DC5 File Offset: 0x00052FC5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00054DE4 File Offset: 0x00052FE4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::CreationMaster.WebBrowserForm));
			this.toolStripWeb = new global::System.Windows.Forms.ToolStrip();
			this.buttonTm = new global::System.Windows.Forms.ToolStripButton();
			this.buttonSw = new global::System.Windows.Forms.ToolStripButton();
			this.buttonBack = new global::System.Windows.Forms.ToolStripButton();
			this.buttonForward = new global::System.Windows.Forms.ToolStripButton();
			this.buttonImportWeb = new global::System.Windows.Forms.ToolStripButton();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.buttonReload = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripWeb.SuspendLayout();
			base.SuspendLayout();
			this.toolStripWeb.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.buttonTm, this.buttonSw, this.buttonBack, this.buttonForward, this.buttonReload, this.buttonImportWeb });
			this.toolStripWeb.Location = new global::System.Drawing.Point(0, 0);
			this.toolStripWeb.Name = "toolStripWeb";
			this.toolStripWeb.Size = new global::System.Drawing.Size(1010, 55);
			this.toolStripWeb.TabIndex = 1;
			this.toolStripWeb.Text = "toolStrip1";
			this.buttonTm.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonTm.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonTm.Image");
			this.buttonTm.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonTm.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonTm.Name = "buttonTm";
			this.buttonTm.Size = new global::System.Drawing.Size(52, 52);
			this.buttonTm.Text = "Connect to Tranfermrkt";
			this.buttonTm.Click += new global::System.EventHandler(this.buttonTransfermrkt_Click);
			this.buttonSw.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSw.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSw.Image");
			this.buttonSw.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonSw.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonSw.Name = "buttonSw";
			this.buttonSw.Size = new global::System.Drawing.Size(52, 52);
			this.buttonSw.Text = "Connect to Soccerway";
			this.buttonSw.Visible = false;
			this.buttonSw.Click += new global::System.EventHandler(this.buttonSoccerway_Click);
			this.buttonBack.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonBack.Enabled = false;
			this.buttonBack.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonBack.Image");
			this.buttonBack.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonBack.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new global::System.Drawing.Size(52, 52);
			this.buttonBack.Text = "Navigate Back";
			this.buttonBack.Click += new global::System.EventHandler(this.buttonBack_Click);
			this.buttonForward.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonForward.Enabled = false;
			this.buttonForward.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonForward.Image");
			this.buttonForward.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonForward.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonForward.Name = "buttonForward";
			this.buttonForward.Size = new global::System.Drawing.Size(52, 52);
			this.buttonForward.Text = "Navigate Forward";
			this.buttonForward.Click += new global::System.EventHandler(this.buttonForward_Click);
			this.buttonImportWeb.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonImportWeb.Enabled = false;
			this.buttonImportWeb.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonImportWeb.Image");
			this.buttonImportWeb.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonImportWeb.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonImportWeb.Name = "buttonImportWeb";
			this.buttonImportWeb.Size = new global::System.Drawing.Size(52, 52);
			this.buttonImportWeb.Text = "Import from Web";
			this.buttonImportWeb.Click += new global::System.EventHandler(this.buttonImportTeamAs_Click);
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(0, 55);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new global::System.Drawing.Size(1010, 688);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.Url = new global::System.Uri("", global::System.UriKind.Relative);
			this.webBrowser1.Navigated += new global::System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
			this.webBrowser1.ProgressChanged += new global::System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
			this.buttonReload.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonReload.Enabled = false;
			this.buttonReload.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonReload.Image");
			this.buttonReload.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonReload.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new global::System.Drawing.Size(52, 52);
			this.buttonReload.Text = "Reload";
			this.buttonReload.Click += new global::System.EventHandler(this.toolStripButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1010, 743);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.toolStripWeb);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "WebBrowserForm";
			this.Text = "Web Browser";
			this.toolStripWeb.ResumeLayout(false);
			this.toolStripWeb.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000545 RID: 1349
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000546 RID: 1350
		private global::System.Windows.Forms.ToolStrip toolStripWeb;

		// Token: 0x04000547 RID: 1351
		private global::System.Windows.Forms.ToolStripButton buttonTm;

		// Token: 0x04000548 RID: 1352
		private global::System.Windows.Forms.ToolStripButton buttonSw;

		// Token: 0x04000549 RID: 1353
		private global::System.Windows.Forms.ToolStripButton buttonBack;

		// Token: 0x0400054A RID: 1354
		private global::System.Windows.Forms.ToolStripButton buttonForward;

		// Token: 0x0400054B RID: 1355
		private global::System.Windows.Forms.ToolStripButton buttonImportWeb;

		// Token: 0x0400054C RID: 1356
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x0400054D RID: 1357
		private global::System.Windows.Forms.ToolStripButton buttonReload;
	}
}
