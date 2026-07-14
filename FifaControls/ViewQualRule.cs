using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200001A RID: 26
	public class ViewQualRule : UserControl
	{
		// Token: 0x0600018F RID: 399 RVA: 0x00011AA4 File Offset: 0x0000FCA4
		public ViewQualRule()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00011AB2 File Offset: 0x0000FCB2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		private void InitializeComponent()
		{
			this.comboRule = new ComboBox();
			this.comboTrophy = new ComboBox();
			this.comboLeague1 = new ComboBox();
			this.comboTropht2 = new ComboBox();
			this.comboTeam = new ComboBox();
			this.numeric = new NumericUpDown();
			((ISupportInitialize)this.numeric).BeginInit();
			base.SuspendLayout();
			this.comboRule.FormattingEnabled = true;
			this.comboRule.Items.AddRange(new object[] { "Fill From League", "Fill From League with Country Limit", "Fill From Competition ", "Fill From Competition with Backup Rule", "Fill From Competition with  Backup League", "Fill with  Specific Team", "Fill with  Special Team" });
			this.comboRule.Location = new Point(5, 2);
			this.comboRule.Name = "comboRule";
			this.comboRule.Size = new Size(161, 21);
			this.comboRule.TabIndex = 0;
			this.comboTrophy.FormattingEnabled = true;
			this.comboTrophy.Location = new Point(172, 1);
			this.comboTrophy.Name = "comboTrophy";
			this.comboTrophy.Size = new Size(121, 21);
			this.comboTrophy.TabIndex = 1;
			this.comboLeague1.FormattingEnabled = true;
			this.comboLeague1.Location = new Point(299, 1);
			this.comboLeague1.Name = "comboLeague1";
			this.comboLeague1.Size = new Size(121, 21);
			this.comboLeague1.TabIndex = 2;
			this.comboTropht2.FormattingEnabled = true;
			this.comboTropht2.Location = new Point(426, 1);
			this.comboTropht2.Name = "comboTropht2";
			this.comboTropht2.Size = new Size(121, 21);
			this.comboTropht2.TabIndex = 3;
			this.comboTeam.FormattingEnabled = true;
			this.comboTeam.Location = new Point(553, 1);
			this.comboTeam.Name = "comboTeam";
			this.comboTeam.Size = new Size(121, 21);
			this.comboTeam.TabIndex = 4;
			this.numeric.Location = new Point(680, 1);
			this.numeric.Name = "numeric";
			this.numeric.Size = new Size(75, 20);
			this.numeric.TabIndex = 5;
			this.numeric.TextAlign = HorizontalAlignment.Center;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.numeric);
			base.Controls.Add(this.comboTeam);
			base.Controls.Add(this.comboTropht2);
			base.Controls.Add(this.comboLeague1);
			base.Controls.Add(this.comboTrophy);
			base.Controls.Add(this.comboRule);
			base.Name = "ViewQualRule";
			base.Size = new Size(784, 23);
			((ISupportInitialize)this.numeric).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000171 RID: 369
		private IContainer components;

		// Token: 0x04000172 RID: 370
		private ComboBox comboRule;

		// Token: 0x04000173 RID: 371
		private ComboBox comboTrophy;

		// Token: 0x04000174 RID: 372
		private ComboBox comboLeague1;

		// Token: 0x04000175 RID: 373
		private ComboBox comboTropht2;

		// Token: 0x04000176 RID: 374
		private ComboBox comboTeam;

		// Token: 0x04000177 RID: 375
		private NumericUpDown numeric;
	}
}
