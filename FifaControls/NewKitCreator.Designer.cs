namespace FifaControls
{
	// Token: 0x02000011 RID: 17
	public partial class NewKitCreator : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000C970 File Offset: 0x0000AB70
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000C990 File Offset: 0x0000AB90
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.NewKitCreator));
			this.button1 = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.labelTeam = new global::System.Windows.Forms.Label();
			this.labelKitType = new global::System.Windows.Forms.Label();
			this.comboKitTypes = new global::System.Windows.Forms.ComboBox();
			this.comboTeams = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericYearTournament = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.numericYearTournament).BeginInit();
			base.SuspendLayout();
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new global::System.Drawing.Point(173, 144);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(48, 144);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.labelTeam.AutoSize = true;
			this.labelTeam.BackColor = global::System.Drawing.Color.Transparent;
			this.labelTeam.Location = new global::System.Drawing.Point(23, 31);
			this.labelTeam.Name = "labelTeam";
			this.labelTeam.Size = new global::System.Drawing.Size(34, 13);
			this.labelTeam.TabIndex = 9;
			this.labelTeam.Text = "Team";
			this.labelKitType.AutoSize = true;
			this.labelKitType.BackColor = global::System.Drawing.Color.Transparent;
			this.labelKitType.Location = new global::System.Drawing.Point(23, 63);
			this.labelKitType.Name = "labelKitType";
			this.labelKitType.Size = new global::System.Drawing.Size(42, 13);
			this.labelKitType.TabIndex = 10;
			this.labelKitType.Text = "Kit type";
			this.comboKitTypes.FormattingEnabled = true;
			this.comboKitTypes.Items.AddRange(new object[]
			{
				"Home", "Away", "Goalkeeper", "3rd Kit", "4th Kit", "Referee", "6th Kit", "7th Kit", "Home Goalkeeper (RevMod)", "Away Goalkeeper (RevMod)",
				"3rd Goalkeeper (RevMod)", "Home Training (RevMod)", "Away Training (RevMod)"
			});
			this.comboKitTypes.Location = new global::System.Drawing.Point(91, 60);
			this.comboKitTypes.Name = "comboKitTypes";
			this.comboKitTypes.Size = new global::System.Drawing.Size(178, 21);
			this.comboKitTypes.TabIndex = 11;
			this.comboKitTypes.SelectedIndexChanged += new global::System.EventHandler(this.comboKitTypes_SelectedIndexChanged);
			this.comboTeams.FormattingEnabled = true;
			this.comboTeams.Location = new global::System.Drawing.Point(91, 28);
			this.comboTeams.Name = "comboTeams";
			this.comboTeams.Size = new global::System.Drawing.Size(178, 21);
			this.comboTeams.TabIndex = 12;
			this.comboTeams.SelectedIndexChanged += new global::System.EventHandler(this.comboTeams_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Location = new global::System.Drawing.Point(23, 96);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(109, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Year \\ Tournament Id";
			this.numericYearTournament.Location = new global::System.Drawing.Point(140, 94);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericYearTournament;
			int[] array = new int[4];
			array[0] = 1000000;
			numericUpDown.Maximum = new decimal(array);
			this.numericYearTournament.Name = "numericYearTournament";
			this.numericYearTournament.Size = new global::System.Drawing.Size(129, 20);
			this.numericYearTournament.TabIndex = 14;
			this.numericYearTournament.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericYearTournament.ValueChanged += new global::System.EventHandler(this.numericYearTournament_ValueChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(300, 179);
			base.Controls.Add(this.numericYearTournament);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboTeams);
			base.Controls.Add(this.comboKitTypes);
			base.Controls.Add(this.labelKitType);
			base.Controls.Add(this.labelTeam);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "NewKitCreator";
			this.Text = "New Kit Selector";
			((global::System.ComponentModel.ISupportInitialize)this.numericYearTournament).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000D4 RID: 212
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label labelTeam;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label labelKitType;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ComboBox comboKitTypes;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.ComboBox comboTeams;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.NumericUpDown numericYearTournament;
	}
}
