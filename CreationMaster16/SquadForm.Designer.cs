namespace CreationMaster
{
	// Token: 0x0200001A RID: 26
	public partial class SquadForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060003CB RID: 971 RVA: 0x00060D42 File Offset: 0x0005EF42
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00060D64 File Offset: 0x0005EF64
		private void InitializeComponent()
		{
			this.panelBottom = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.treeTurns = new global::System.Windows.Forms.TreeView();
			this.comboTrophy = new global::System.Windows.Forms.ComboBox();
			this.panelBottom.SuspendLayout();
			base.SuspendLayout();
			this.panelBottom.Controls.Add(this.button1);
			this.panelBottom.Controls.Add(this.buttonOK);
			this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 441);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(304, 42);
			this.panelBottom.TabIndex = 5;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new global::System.Drawing.Point(178, 9);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Enabled = false;
			this.buttonOK.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.buttonOK.Location = new global::System.Drawing.Point(30, 9);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.treeTurns.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeTurns.Location = new global::System.Drawing.Point(0, 21);
			this.treeTurns.Name = "treeTurns";
			this.treeTurns.Size = new global::System.Drawing.Size(304, 462);
			this.treeTurns.TabIndex = 4;
			this.treeTurns.DoubleClick += new global::System.EventHandler(this.treeTurns_DoubleClick);
			this.treeTurns.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeTurns_AfterSelect);
			this.comboTrophy.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.comboTrophy.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTrophy.FormattingEnabled = true;
			this.comboTrophy.Location = new global::System.Drawing.Point(0, 0);
			this.comboTrophy.MaxDropDownItems = 16;
			this.comboTrophy.Name = "comboTournament";
			this.comboTrophy.Size = new global::System.Drawing.Size(304, 21);
			this.comboTrophy.Sorted = true;
			this.comboTrophy.TabIndex = 3;
			this.comboTrophy.SelectedIndexChanged += new global::System.EventHandler(this.comboTrophy_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(304, 483);
			base.Controls.Add(this.panelBottom);
			base.Controls.Add(this.treeTurns);
			base.Controls.Add(this.comboTrophy);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "SquadForm";
			this.Text = "Team Form";
			this.panelBottom.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000605 RID: 1541
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000606 RID: 1542
		private global::System.Windows.Forms.Panel panelBottom;

		// Token: 0x04000607 RID: 1543
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000608 RID: 1544
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000609 RID: 1545
		private global::System.Windows.Forms.TreeView treeTurns;

		// Token: 0x0400060A RID: 1546
		private global::System.Windows.Forms.ComboBox comboTrophy;
	}
}
