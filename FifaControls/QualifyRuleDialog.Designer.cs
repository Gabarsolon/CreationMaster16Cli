namespace FifaControls
{
	// Token: 0x02000008 RID: 8
	public partial class QualifyRuleDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000072B8 File Offset: 0x000054B8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000072D8 File Offset: 0x000054D8
		private void InitializeComponent()
		{
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.radioRule1 = new global::System.Windows.Forms.RadioButton();
			this.radioRule2 = new global::System.Windows.Forms.RadioButton();
			this.radioRule3 = new global::System.Windows.Forms.RadioButton();
			this.radioRule4 = new global::System.Windows.Forms.RadioButton();
			this.radioRule5 = new global::System.Windows.Forms.RadioButton();
			this.radioRule6 = new global::System.Windows.Forms.RadioButton();
			this.radioRule7 = new global::System.Windows.Forms.RadioButton();
			this.comboTrophy1 = new global::System.Windows.Forms.ComboBox();
			this.comboTrophy2 = new global::System.Windows.Forms.ComboBox();
			this.comboLeague = new global::System.Windows.Forms.ComboBox();
			this.numericN = new global::System.Windows.Forms.NumericUpDown();
			this.comboTeam = new global::System.Windows.Forms.ComboBox();
			this.numericCountryLimitation = new global::System.Windows.Forms.NumericUpDown();
			this.radioRule8 = new global::System.Windows.Forms.RadioButton();
			((global::System.ComponentModel.ISupportInitialize)this.numericN).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCountryLimitation).BeginInit();
			base.SuspendLayout();
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(89, 258);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(327, 258);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.radioRule1.AutoSize = true;
			this.radioRule1.Location = new global::System.Drawing.Point(12, 12);
			this.radioRule1.Name = "radioRule1";
			this.radioRule1.Size = new global::System.Drawing.Size(193, 17);
			this.radioRule1.TabIndex = 2;
			this.radioRule1.TabStop = true;
			this.radioRule1.Text = "Get the Best N Team(s) of a Trophy";
			this.radioRule1.UseVisualStyleBackColor = true;
			this.radioRule1.CheckedChanged += new global::System.EventHandler(this.radioRule1_CheckedChanged);
			this.radioRule2.AutoSize = true;
			this.radioRule2.Location = new global::System.Drawing.Point(12, 35);
			this.radioRule2.Name = "radioRule2";
			this.radioRule2.Size = new global::System.Drawing.Size(303, 17);
			this.radioRule2.TabIndex = 5;
			this.radioRule2.TabStop = true;
			this.radioRule2.Text = "Get the Winner of a Trophy or a Team from another Trophy";
			this.radioRule2.UseVisualStyleBackColor = true;
			this.radioRule2.CheckedChanged += new global::System.EventHandler(this.radioRule2_CheckedChanged);
			this.radioRule3.AutoSize = true;
			this.radioRule3.Location = new global::System.Drawing.Point(12, 58);
			this.radioRule3.Name = "radioRule3";
			this.radioRule3.Size = new global::System.Drawing.Size(276, 17);
			this.radioRule3.TabIndex = 7;
			this.radioRule3.TabStop = true;
			this.radioRule3.Text = "Get the Winner of a Trophy or a Team from a League";
			this.radioRule3.UseVisualStyleBackColor = true;
			this.radioRule3.CheckedChanged += new global::System.EventHandler(this.radioRule3_CheckedChanged);
			this.radioRule4.AutoSize = true;
			this.radioRule4.Location = new global::System.Drawing.Point(12, 81);
			this.radioRule4.Name = "radioRule4";
			this.radioRule4.Size = new global::System.Drawing.Size(166, 17);
			this.radioRule4.TabIndex = 9;
			this.radioRule4.TabStop = true;
			this.radioRule4.Text = "Get the Teams from a League";
			this.radioRule4.UseVisualStyleBackColor = true;
			this.radioRule4.CheckedChanged += new global::System.EventHandler(this.radioRule4_CheckedChanged);
			this.radioRule5.AutoSize = true;
			this.radioRule5.Location = new global::System.Drawing.Point(12, 130);
			this.radioRule5.Name = "radioRule5";
			this.radioRule5.Size = new global::System.Drawing.Size(270, 17);
			this.radioRule5.TabIndex = 9;
			this.radioRule5.TabStop = true;
			this.radioRule5.Text = "Get Team(s) from a League with Country limitation to";
			this.radioRule5.UseVisualStyleBackColor = true;
			this.radioRule5.CheckedChanged += new global::System.EventHandler(this.radioRule5_CheckedChanged);
			this.radioRule6.AutoSize = true;
			this.radioRule6.Location = new global::System.Drawing.Point(12, 153);
			this.radioRule6.Name = "radioRule6";
			this.radioRule6.Size = new global::System.Drawing.Size(226, 17);
			this.radioRule6.TabIndex = 11;
			this.radioRule6.TabStop = true;
			this.radioRule6.Text = "Get N Teams from \"Special Teams Group\"";
			this.radioRule6.UseVisualStyleBackColor = true;
			this.radioRule6.CheckedChanged += new global::System.EventHandler(this.radioRule6_CheckedChanged);
			this.radioRule7.AutoSize = true;
			this.radioRule7.Location = new global::System.Drawing.Point(12, 176);
			this.radioRule7.Name = "radioRule7";
			this.radioRule7.Size = new global::System.Drawing.Size(209, 17);
			this.radioRule7.TabIndex = 13;
			this.radioRule7.TabStop = true;
			this.radioRule7.Text = "Get a specific Team in a given Position";
			this.radioRule7.UseVisualStyleBackColor = true;
			this.radioRule7.CheckedChanged += new global::System.EventHandler(this.radioRule7_CheckedChanged);
			this.comboTrophy1.FormattingEnabled = true;
			this.comboTrophy1.Location = new global::System.Drawing.Point(12, 215);
			this.comboTrophy1.Name = "comboTrophy1";
			this.comboTrophy1.Size = new global::System.Drawing.Size(205, 21);
			this.comboTrophy1.TabIndex = 14;
			this.comboTrophy1.SelectedIndexChanged += new global::System.EventHandler(this.comboTrophy1_SelectedIndexChanged);
			this.comboTrophy2.FormattingEnabled = true;
			this.comboTrophy2.Location = new global::System.Drawing.Point(294, 214);
			this.comboTrophy2.Name = "comboTrophy2";
			this.comboTrophy2.Size = new global::System.Drawing.Size(205, 21);
			this.comboTrophy2.TabIndex = 15;
			this.comboTrophy2.SelectedIndexChanged += new global::System.EventHandler(this.comboTrophy2_SelectedIndexChanged);
			this.comboLeague.FormattingEnabled = true;
			this.comboLeague.Location = new global::System.Drawing.Point(294, 214);
			this.comboLeague.Name = "comboLeague";
			this.comboLeague.Size = new global::System.Drawing.Size(205, 21);
			this.comboLeague.TabIndex = 16;
			this.comboLeague.SelectedIndexChanged += new global::System.EventHandler(this.comboLeague_SelectedIndexChanged);
			this.numericN.Location = new global::System.Drawing.Point(222, 215);
			this.numericN.Name = "numericN";
			this.numericN.Size = new global::System.Drawing.Size(66, 20);
			this.numericN.TabIndex = 17;
			this.numericN.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericN.ValueChanged += new global::System.EventHandler(this.numericN_ValueChanged);
			this.comboTeam.FormattingEnabled = true;
			this.comboTeam.Location = new global::System.Drawing.Point(12, 215);
			this.comboTeam.Name = "comboTeam";
			this.comboTeam.Size = new global::System.Drawing.Size(204, 21);
			this.comboTeam.TabIndex = 18;
			this.comboTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboTeam_SelectedIndexChanged);
			this.numericCountryLimitation.Location = new global::System.Drawing.Point(288, 129);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericCountryLimitation;
			int[] array = new int[4];
			array[0] = 8;
			numericUpDown.Maximum = new decimal(array);
			this.numericCountryLimitation.Name = "numericCountryLimitation";
			this.numericCountryLimitation.Size = new global::System.Drawing.Size(85, 20);
			this.numericCountryLimitation.TabIndex = 19;
			this.numericCountryLimitation.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericCountryLimitation;
			int[] array2 = new int[4];
			array2[0] = 4;
			numericUpDown2.Value = new decimal(array2);
			this.numericCountryLimitation.ValueChanged += new global::System.EventHandler(this.numericCountryLimitation_ValueChanged);
			this.radioRule8.AutoSize = true;
			this.radioRule8.Location = new global::System.Drawing.Point(12, 104);
			this.radioRule8.Name = "radioRule8";
			this.radioRule8.Size = new global::System.Drawing.Size(204, 17);
			this.radioRule8.TabIndex = 20;
			this.radioRule8.TabStop = true;
			this.radioRule8.Text = "Get the Teams from a League in order";
			this.radioRule8.UseVisualStyleBackColor = true;
			this.radioRule8.CheckedChanged += new global::System.EventHandler(this.radioRule8_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(512, 301);
			base.Controls.Add(this.radioRule8);
			base.Controls.Add(this.numericCountryLimitation);
			base.Controls.Add(this.comboTeam);
			base.Controls.Add(this.numericN);
			base.Controls.Add(this.comboLeague);
			base.Controls.Add(this.comboTrophy2);
			base.Controls.Add(this.comboTrophy1);
			base.Controls.Add(this.radioRule7);
			base.Controls.Add(this.radioRule6);
			base.Controls.Add(this.radioRule5);
			base.Controls.Add(this.radioRule4);
			base.Controls.Add(this.radioRule3);
			base.Controls.Add(this.radioRule2);
			base.Controls.Add(this.radioRule1);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "QualifyRuleDialog";
			this.Text = "Qualification Rule";
			((global::System.ComponentModel.ISupportInitialize)this.numericN).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericCountryLimitation).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000052 RID: 82
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.RadioButton radioRule1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.RadioButton radioRule2;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.RadioButton radioRule3;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.RadioButton radioRule4;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.RadioButton radioRule5;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.RadioButton radioRule6;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.RadioButton radioRule7;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ComboBox comboTrophy1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ComboBox comboTrophy2;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ComboBox comboLeague;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.NumericUpDown numericN;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ComboBox comboTeam;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.NumericUpDown numericCountryLimitation;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.RadioButton radioRule8;
	}
}
