namespace FifaControls
{
	// Token: 0x02000010 RID: 16
	public partial class NewIdCreator : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000C031 File Offset: 0x0000A231
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000C050 File Offset: 0x0000A250
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.NewIdCreator));
			this.radioAuto = new global::System.Windows.Forms.RadioButton();
			this.radioSpacificId = new global::System.Windows.Forms.RadioButton();
			this.radioCms = new global::System.Windows.Forms.RadioButton();
			this.treeViewCms = new global::System.Windows.Forms.TreeView();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.numericSpecificId = new global::System.Windows.Forms.NumericUpDown();
			this.textCms = new global::System.Windows.Forms.TextBox();
			this.labelMinMax = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericSpecificId).BeginInit();
			base.SuspendLayout();
			this.radioAuto.AutoSize = true;
			this.radioAuto.BackColor = global::System.Drawing.Color.Transparent;
			this.radioAuto.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.radioAuto.Checked = true;
			this.radioAuto.Location = new global::System.Drawing.Point(0, 5);
			this.radioAuto.Name = "radioAuto";
			this.radioAuto.Padding = new global::System.Windows.Forms.Padding(10, 0, 0, 0);
			this.radioAuto.Size = new global::System.Drawing.Size(82, 17);
			this.radioAuto.TabIndex = 0;
			this.radioAuto.TabStop = true;
			this.radioAuto.Text = "Automatic";
			this.radioAuto.UseVisualStyleBackColor = false;
			this.radioAuto.CheckedChanged += new global::System.EventHandler(this.radioAuto_CheckedChanged);
			this.radioSpacificId.AutoSize = true;
			this.radioSpacificId.BackColor = global::System.Drawing.Color.Transparent;
			this.radioSpacificId.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.radioSpacificId.Location = new global::System.Drawing.Point(0, 31);
			this.radioSpacificId.Name = "radioSpacificId";
			this.radioSpacificId.Padding = new global::System.Windows.Forms.Padding(10, 0, 0, 0);
			this.radioSpacificId.Size = new global::System.Drawing.Size(85, 17);
			this.radioSpacificId.TabIndex = 1;
			this.radioSpacificId.Text = "Specific Id";
			this.radioSpacificId.UseVisualStyleBackColor = false;
			this.radioSpacificId.CheckedChanged += new global::System.EventHandler(this.radioSpacificId_CheckedChanged);
			this.radioCms.BackColor = global::System.Drawing.Color.Transparent;
			this.radioCms.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.radioCms.Enabled = false;
			this.radioCms.Location = new global::System.Drawing.Point(26, 122);
			this.radioCms.Name = "radioCms";
			this.radioCms.Padding = new global::System.Windows.Forms.Padding(10, 0, 0, 0);
			this.radioCms.Size = new global::System.Drawing.Size(232, 24);
			this.radioCms.TabIndex = 2;
			this.radioCms.Text = "Browse CMS";
			this.radioCms.UseVisualStyleBackColor = false;
			this.radioCms.Visible = false;
			this.radioCms.CheckedChanged += new global::System.EventHandler(this.radioCms_CheckedChanged);
			this.treeViewCms.Location = new global::System.Drawing.Point(53, 170);
			this.treeViewCms.Name = "treeViewCms";
			this.treeViewCms.Size = new global::System.Drawing.Size(194, 49);
			this.treeViewCms.TabIndex = 3;
			this.treeViewCms.Visible = false;
			this.treeViewCms.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeViewCms_AfterSelect);
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(36, 66);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new global::System.Drawing.Point(169, 66);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.numericSpecificId.Location = new global::System.Drawing.Point(102, 29);
			this.numericSpecificId.Name = "numericSpecificId";
			this.numericSpecificId.Size = new global::System.Drawing.Size(87, 20);
			this.numericSpecificId.TabIndex = 6;
			this.numericSpecificId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericSpecificId.ValueChanged += new global::System.EventHandler(this.numericSpecificId_ValueChanged);
			this.textCms.BackColor = global::System.Drawing.Color.White;
			this.textCms.Location = new global::System.Drawing.Point(116, 122);
			this.textCms.Name = "textCms";
			this.textCms.ReadOnly = true;
			this.textCms.Size = new global::System.Drawing.Size(97, 20);
			this.textCms.TabIndex = 7;
			this.textCms.Visible = false;
			this.labelMinMax.AutoSize = true;
			this.labelMinMax.BackColor = global::System.Drawing.Color.Transparent;
			this.labelMinMax.Location = new global::System.Drawing.Point(195, 33);
			this.labelMinMax.Name = "labelMinMax";
			this.labelMinMax.Size = new global::System.Drawing.Size(82, 13);
			this.labelMinMax.TabIndex = 8;
			this.labelMinMax.Text = "50000 - 300000";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(293, 103);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.labelMinMax);
			base.Controls.Add(this.buttonOK);
			base.Controls.Add(this.textCms);
			base.Controls.Add(this.numericSpecificId);
			base.Controls.Add(this.treeViewCms);
			base.Controls.Add(this.radioCms);
			base.Controls.Add(this.radioSpacificId);
			base.Controls.Add(this.radioAuto);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "NewIdCreator";
			this.Text = "New Id Selector";
			((global::System.ComponentModel.ISupportInitialize)this.numericSpecificId).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C2 RID: 194
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.RadioButton radioAuto;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.RadioButton radioSpacificId;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.RadioButton radioCms;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.TreeView treeViewCms;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.NumericUpDown numericSpecificId;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.TextBox textCms;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label labelMinMax;
	}
}
