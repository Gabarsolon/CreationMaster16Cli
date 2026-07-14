namespace CreationMaster
{
	// Token: 0x02000015 RID: 21
	public partial class UgcForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00054A8A File Offset: 0x00052C8A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00054AAC File Offset: 0x00052CAC
		private void InitializeComponent()
		{
			this.buttonImport = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.buttonImport.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonImport.Location = new global::System.Drawing.Point(133, 334);
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new global::System.Drawing.Size(75, 23);
			this.buttonImport.TabIndex = 0;
			this.buttonImport.Text = "Import";
			this.buttonImport.UseVisualStyleBackColor = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(561, 333);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(764, 389);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonImport);
			base.Name = "UgcForm";
			this.Text = "UgcForm";
			base.ResumeLayout(false);
		}

		// Token: 0x04000540 RID: 1344
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.Forms.Button buttonImport;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Forms.Button buttonCancel;
	}
}
