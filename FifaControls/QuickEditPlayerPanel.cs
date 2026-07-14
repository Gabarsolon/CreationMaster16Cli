using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000009 RID: 9
	public class QuickEditPlayerPanel : UserControl
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00007D98 File Offset: 0x00005F98
		public void SetTeams(object[] teams)
		{
			this.comboLoaningTeam.Items.Clear();
			this.comboLoaningTeam.Items.AddRange(teams);
			this.comboPrevTeam.Items.Clear();
			this.comboPrevTeam.Items.Add(string.Empty);
			this.comboPrevTeam.Items.AddRange(teams);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007DFD File Offset: 0x00005FFD
		public void SetCountries(object[] countries)
		{
			this.comboCountry.Items.Clear();
			this.comboCountry.Items.AddRange(countries);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007E20 File Offset: 0x00006020
		private int ConvertRole(ERole preferredRole)
		{
			switch (preferredRole)
			{
			case ERole.Goalkeeper:
				return 0;
			case ERole.Sweeper:
			case ERole.Central_Back:
				return 3;
			case ERole.Right_Wing_Back:
				return 1;
			case ERole.Right_Back:
			case ERole.Right_Central_Back:
				return 2;
			case ERole.Left_Central_Back:
			case ERole.Left_Back:
				return 4;
			case ERole.Left_Wing_Back:
				return 5;
			case ERole.Right_Defensive_Midfielder:
			case ERole.Central_Defensive_Midfielder:
			case ERole.Left_Defensive_Midfielder:
				return 6;
			case ERole.Right_Midfielder:
				return 7;
			case ERole.Central_Midfielder:
				return 8;
			case ERole.Left_Midfielder:
				return 9;
			case ERole.Right_Advanced_Midfielder:
			case ERole.Central_Advanced_Midfielder:
			case ERole.Left_Advanced_Midfielder:
				return 10;
			case ERole.Right_Forward:
			case ERole.Central_Forward:
			case ERole.Left_Forward:
				return 11;
			case ERole.Right_Wing:
				return 12;
			case ERole.Right_Striker:
			case ERole.Central_Striker:
			case ERole.Left_Striker:
				return 13;
			case ERole.Left_Wing:
				return 14;
			}
			return 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007ECC File Offset: 0x000060CC
		public new void Load(TeamPlayer teamPlayer)
		{
			this.m_TeamPlayer = teamPlayer;
			this.m_CurrentPlayer = teamPlayer.Player;
			this.m_Locked = true;
			this.comboJerseyNumber.SelectedIndex = this.m_TeamPlayer.jerseynumber - 1;
			this.textFirstName.Text = this.m_CurrentPlayer.firstname;
			this.textSurname.Text = this.m_CurrentPlayer.lastname;
			this.textCommonName.Text = this.m_CurrentPlayer.commonname;
			this.textJerseyName.Text = this.m_CurrentPlayer.playerjerseyname;
			this.dateBirthDate.Value = this.m_CurrentPlayer.birthdate;
			this.comboCountry.SelectedItem = this.m_CurrentPlayer.Country;
			this.numericOverall.Value = this.m_CurrentPlayer.overallrating;
			this.numericContract.Value = this.m_CurrentPlayer.contractvaliduntil;
			this.checkLoan.Checked = this.m_CurrentPlayer.IsLoaned;
			if (this.m_CurrentPlayer.IsLoaned)
			{
				this.dateLoanEnd.Value = this.m_CurrentPlayer.loandateend;
				this.comboLoaningTeam.SelectedItem = this.m_CurrentPlayer.TeamLoanedFrom;
				this.dateLoanEnd.Visible = true;
				this.comboLoaningTeam.Visible = true;
			}
			else
			{
				this.dateLoanEnd.Visible = false;
				this.comboLoaningTeam.Visible = false;
			}
			this.dateJoin.Value = this.m_CurrentPlayer.joindate;
			this.comboPrevTeam.SelectedItem = this.m_CurrentPlayer.PreviousTeam;
			ERole preferredposition = (ERole)this.m_CurrentPlayer.preferredposition1;
			this.comboRole.SelectedIndex = this.ConvertRole(preferredposition);
			this.m_Locked = false;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00008097 File Offset: 0x00006297
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000809F File Offset: 0x0000629F
		public TeamPlayer TeamPlayer
		{
			get
			{
				return this.m_TeamPlayer;
			}
			set
			{
				this.m_TeamPlayer = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000080A8 File Offset: 0x000062A8
		public Player Player
		{
			get
			{
				return this.m_TeamPlayer.Player;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000080B5 File Offset: 0x000062B5
		public QuickEditPlayerPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000080C3 File Offset: 0x000062C3
		private void comboJerseyNumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_TeamPlayer.jerseynumber = this.comboJerseyNumber.SelectedIndex + 1;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000080E6 File Offset: 0x000062E6
		private void textFirstName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.firstname = this.textFirstName.Text;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008107 File Offset: 0x00006307
		private void textSurname_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.FastRename(this.textSurname.Text);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000812C File Offset: 0x0000632C
		private void textCommonName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.commonname = this.textCommonName.Text;
			this.m_CurrentPlayer.audioname = this.m_CurrentPlayer.commonname;
			this.m_CurrentPlayer.commentaryid = -1;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000817A File Offset: 0x0000637A
		private void textJerseyName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.commonname = this.textCommonName.Text;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000819B File Offset: 0x0000639B
		private void dateBirthDate_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.playerjerseyname = this.textJerseyName.Text;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000081BC File Offset: 0x000063BC
		private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.Country = (Country)this.comboCountry.SelectedItem;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000081E2 File Offset: 0x000063E2
		private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool locked = this.m_Locked;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000081EC File Offset: 0x000063EC
		private void numericOverall_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericOverall.Value;
			int averageRoleAttribute = this.m_CurrentPlayer.GetAverageRoleAttribute();
			if (averageRoleAttribute < num)
			{
				for (int i = averageRoleAttribute; i < num; i++)
				{
					this.m_CurrentPlayer.IncreaseAllAttributes();
				}
				return;
			}
			for (int j = averageRoleAttribute; j > num; j--)
			{
				this.m_CurrentPlayer.DecreaseAllAttributes();
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008252 File Offset: 0x00006452
		private void numericContract_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.contractvaliduntil = (int)this.numericContract.Value;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00008278 File Offset: 0x00006478
		private void checkLoan_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.checkLoan.Checked)
			{
				this.dateLoanEnd.Visible = true;
				this.comboLoaningTeam.Visible = true;
				this.m_CurrentPlayer.IsLoaned = true;
				return;
			}
			this.dateLoanEnd.Visible = false;
			this.comboLoaningTeam.Visible = false;
			this.m_CurrentPlayer.IsLoaned = false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000082E4 File Offset: 0x000064E4
		private void dateLoanEnd_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.loandateend = this.dateLoanEnd.Value;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008305 File Offset: 0x00006505
		private void comboLoaningTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.TeamLoanedFrom = (Team)this.comboLoaningTeam.SelectedItem;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000832B File Offset: 0x0000652B
		private void dateJoin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentPlayer.joindate = this.dateJoin.Value;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000834C File Offset: 0x0000654C
		private void comboPrevTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPrevTeam.SelectedIndex == 0)
			{
				this.m_CurrentPlayer.PreviousTeam = null;
				return;
			}
			this.m_CurrentPlayer.PreviousTeam = (Team)this.comboPrevTeam.SelectedItem;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000838C File Offset: 0x0000658C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000083AC File Offset: 0x000065AC
		private void InitializeComponent()
		{
			this.comboJerseyNumber = new ComboBox();
			this.textFirstName = new TextBox();
			this.textSurname = new TextBox();
			this.textJerseyName = new TextBox();
			this.textCommonName = new TextBox();
			this.comboCountry = new ComboBox();
			this.dateBirthDate = new DateTimePicker();
			this.comboRole = new ComboBox();
			this.numericOverall = new NumericUpDown();
			this.numericContract = new NumericUpDown();
			this.dateJoin = new DateTimePicker();
			this.dateLoanEnd = new DateTimePicker();
			this.comboLoaningTeam = new ComboBox();
			this.comboPrevTeam = new ComboBox();
			this.checkLoan = new CheckBox();
			((ISupportInitialize)this.numericOverall).BeginInit();
			((ISupportInitialize)this.numericContract).BeginInit();
			base.SuspendLayout();
			this.comboJerseyNumber.FormattingEnabled = true;
			this.comboJerseyNumber.Items.AddRange(new object[]
			{
				"1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
				"11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
				"21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
				"31", "32", "33", "34", "35", "36", "37", "38", "39", "40",
				"41", "42", "43", "44", "45", "46", "47", "48", "49", "50",
				"51", "52", "53", "54", "55", "56", "57", "58", "59", "60",
				"61", "62", "63", "64", "65", "66", "67", "68", "69", "70",
				"71", "72", "73", "74", "75", "76", "77", "78", "79", "80",
				"81", "82", "83", "84", "85", "86", "87", "88", "89", "90",
				"91", "92", "93", "94", "95", "96", "97", "98", "99"
			});
			this.comboJerseyNumber.Location = new Point(1, 0);
			this.comboJerseyNumber.Name = "comboJerseyNumber";
			this.comboJerseyNumber.Size = new Size(44, 21);
			this.comboJerseyNumber.TabIndex = 166;
			this.comboJerseyNumber.Text = "88";
			this.comboJerseyNumber.SelectedIndexChanged += this.comboJerseyNumber_SelectedIndexChanged;
			this.textFirstName.Location = new Point(46, 0);
			this.textFirstName.Name = "textFirstName";
			this.textFirstName.Size = new Size(110, 20);
			this.textFirstName.TabIndex = 167;
			this.textFirstName.TextChanged += this.textFirstName_TextChanged;
			this.textSurname.Location = new Point(157, 0);
			this.textSurname.Name = "textSurname";
			this.textSurname.Size = new Size(110, 20);
			this.textSurname.TabIndex = 168;
			this.textSurname.TextChanged += this.textSurname_TextChanged;
			this.textJerseyName.Location = new Point(379, 0);
			this.textJerseyName.Name = "textJerseyName";
			this.textJerseyName.Size = new Size(110, 20);
			this.textJerseyName.TabIndex = 170;
			this.textJerseyName.TextChanged += this.textJerseyName_TextChanged;
			this.textCommonName.Location = new Point(268, 0);
			this.textCommonName.Name = "textCommonName";
			this.textCommonName.Size = new Size(110, 20);
			this.textCommonName.TabIndex = 169;
			this.textCommonName.TextChanged += this.textCommonName_TextChanged;
			this.comboCountry.ItemHeight = 13;
			this.comboCountry.Location = new Point(571, 0);
			this.comboCountry.MaxLength = 32767;
			this.comboCountry.Name = "comboCountry";
			this.comboCountry.Size = new Size(105, 21);
			this.comboCountry.TabIndex = 172;
			this.comboCountry.SelectedIndexChanged += this.comboCountry_SelectedIndexChanged;
			this.dateBirthDate.Format = DateTimePickerFormat.Short;
			this.dateBirthDate.Location = new Point(490, 0);
			this.dateBirthDate.MaxDate = new DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.dateBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateBirthDate.Name = "dateBirthDate";
			this.dateBirthDate.Size = new Size(80, 20);
			this.dateBirthDate.TabIndex = 171;
			this.dateBirthDate.Value = new DateTime(2006, 12, 31, 0, 0, 0, 0);
			this.dateBirthDate.ValueChanged += this.dateBirthDate_ValueChanged;
			this.comboRole.FormattingEnabled = true;
			this.comboRole.Items.AddRange(new object[]
			{
				"GK", "RWB", "RB", "CB", "LB", "LWB", "CDM", "RM", "CM", "LM",
				"CAM", "CF", "RW", "CS", "LW"
			});
			this.comboRole.Location = new Point(677, 0);
			this.comboRole.Margin = new Padding(2, 2, 2, 2);
			this.comboRole.Name = "comboRole";
			this.comboRole.Size = new Size(63, 21);
			this.comboRole.TabIndex = 173;
			this.comboRole.SelectedIndexChanged += this.comboRole_SelectedIndexChanged;
			this.numericOverall.Location = new Point(741, 0);
			this.numericOverall.Margin = new Padding(2, 2, 2, 2);
			NumericUpDown numericUpDown = this.numericOverall;
			int[] array = new int[4];
			array[0] = 99;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numericOverall;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericOverall.Name = "numericOverall";
			this.numericOverall.Size = new Size(43, 20);
			this.numericOverall.TabIndex = 174;
			this.numericOverall.TextAlign = HorizontalAlignment.Center;
			NumericUpDown numericUpDown3 = this.numericOverall;
			int[] array3 = new int[4];
			array3[0] = 99;
			numericUpDown3.Value = new decimal(array3);
			this.numericOverall.ValueChanged += this.numericOverall_ValueChanged;
			this.numericContract.Location = new Point(785, 0);
			this.numericContract.Margin = new Padding(2, 2, 2, 2);
			NumericUpDown numericUpDown4 = this.numericContract;
			int[] array4 = new int[4];
			array4[0] = 2030;
			numericUpDown4.Maximum = new decimal(array4);
			NumericUpDown numericUpDown5 = this.numericContract;
			int[] array5 = new int[4];
			array5[0] = 2015;
			numericUpDown5.Minimum = new decimal(array5);
			this.numericContract.Name = "numericContract";
			this.numericContract.Size = new Size(55, 20);
			this.numericContract.TabIndex = 175;
			this.numericContract.TextAlign = HorizontalAlignment.Center;
			NumericUpDown numericUpDown6 = this.numericContract;
			int[] array6 = new int[4];
			array6[0] = 2015;
			numericUpDown6.Value = new decimal(array6);
			this.numericContract.ValueChanged += this.numericContract_ValueChanged;
			this.dateJoin.Format = DateTimePickerFormat.Short;
			this.dateJoin.Location = new Point(1095, 0);
			this.dateJoin.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.dateJoin.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateJoin.Name = "dateJoin";
			this.dateJoin.Size = new Size(80, 20);
			this.dateJoin.TabIndex = 176;
			this.dateJoin.Value = new DateTime(2016, 7, 1, 0, 0, 0, 0);
			this.dateJoin.ValueChanged += this.dateJoin_ValueChanged;
			this.dateLoanEnd.Format = DateTimePickerFormat.Short;
			this.dateLoanEnd.Location = new Point(863, 0);
			this.dateLoanEnd.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
			this.dateLoanEnd.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateLoanEnd.Name = "dateLoanEnd";
			this.dateLoanEnd.Size = new Size(80, 20);
			this.dateLoanEnd.TabIndex = 177;
			this.dateLoanEnd.Value = new DateTime(2017, 6, 30, 0, 0, 0, 0);
			this.dateLoanEnd.ValueChanged += this.dateLoanEnd_ValueChanged;
			this.comboLoaningTeam.ItemHeight = 13;
			this.comboLoaningTeam.Location = new Point(944, 0);
			this.comboLoaningTeam.MaxLength = 32767;
			this.comboLoaningTeam.Name = "comboLoaningTeam";
			this.comboLoaningTeam.Size = new Size(150, 21);
			this.comboLoaningTeam.TabIndex = 178;
			this.comboLoaningTeam.SelectedIndexChanged += this.comboLoaningTeam_SelectedIndexChanged;
			this.comboPrevTeam.ItemHeight = 13;
			this.comboPrevTeam.Location = new Point(1176, 0);
			this.comboPrevTeam.MaxLength = 32767;
			this.comboPrevTeam.Name = "comboPrevTeam";
			this.comboPrevTeam.Size = new Size(150, 21);
			this.comboPrevTeam.TabIndex = 180;
			this.comboPrevTeam.SelectedIndexChanged += this.comboPrevTeam_SelectedIndexChanged;
			this.checkLoan.Location = new Point(845, 1);
			this.checkLoan.Margin = new Padding(2, 2, 2, 2);
			this.checkLoan.Name = "checkLoan";
			this.checkLoan.Size = new Size(13, 20);
			this.checkLoan.TabIndex = 181;
			this.checkLoan.UseVisualStyleBackColor = true;
			this.checkLoan.CheckedChanged += this.checkLoan_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.checkLoan);
			base.Controls.Add(this.dateJoin);
			base.Controls.Add(this.dateLoanEnd);
			base.Controls.Add(this.comboLoaningTeam);
			base.Controls.Add(this.comboPrevTeam);
			base.Controls.Add(this.numericContract);
			base.Controls.Add(this.numericOverall);
			base.Controls.Add(this.comboRole);
			base.Controls.Add(this.comboCountry);
			base.Controls.Add(this.dateBirthDate);
			base.Controls.Add(this.textFirstName);
			base.Controls.Add(this.textSurname);
			base.Controls.Add(this.textJerseyName);
			base.Controls.Add(this.textCommonName);
			base.Controls.Add(this.comboJerseyNumber);
			base.Margin = new Padding(2, 2, 2, 2);
			base.Name = "QuickEditPlayerPanel";
			base.Size = new Size(1357, 22);
			((ISupportInitialize)this.numericOverall).EndInit();
			((ISupportInitialize)this.numericContract).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000063 RID: 99
		private bool m_Locked;

		// Token: 0x04000064 RID: 100
		private TeamPlayer m_TeamPlayer;

		// Token: 0x04000065 RID: 101
		private Player m_CurrentPlayer;

		// Token: 0x04000066 RID: 102
		private IContainer components;

		// Token: 0x04000067 RID: 103
		private ComboBox comboJerseyNumber;

		// Token: 0x04000068 RID: 104
		private TextBox textFirstName;

		// Token: 0x04000069 RID: 105
		private TextBox textSurname;

		// Token: 0x0400006A RID: 106
		private TextBox textJerseyName;

		// Token: 0x0400006B RID: 107
		private TextBox textCommonName;

		// Token: 0x0400006C RID: 108
		private ComboBox comboCountry;

		// Token: 0x0400006D RID: 109
		private DateTimePicker dateBirthDate;

		// Token: 0x0400006E RID: 110
		private ComboBox comboRole;

		// Token: 0x0400006F RID: 111
		private NumericUpDown numericOverall;

		// Token: 0x04000070 RID: 112
		private NumericUpDown numericContract;

		// Token: 0x04000071 RID: 113
		private DateTimePicker dateJoin;

		// Token: 0x04000072 RID: 114
		private DateTimePicker dateLoanEnd;

		// Token: 0x04000073 RID: 115
		private ComboBox comboLoaningTeam;

		// Token: 0x04000074 RID: 116
		private ComboBox comboPrevTeam;

		// Token: 0x04000075 RID: 117
		private CheckBox checkLoan;
	}
}
