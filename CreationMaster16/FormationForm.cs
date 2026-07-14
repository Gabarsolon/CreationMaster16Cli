using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace CreationMaster
{
	// Token: 0x02000005 RID: 5
	public partial class FormationForm : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000079A4 File Offset: 0x00005BA4
		public FormationForm()
		{
			this.InitializeComponent();
			this.pickUpControl.SelectObject = new PickUpControl.PickUpCallback(this.SelectFormation);
			this.pickUpControl.CreateObject = new PickUpControl.PickUpCallback(this.CreateFormation);
			this.pickUpControl.DeleteObject = new PickUpControl.PickUpCallback(this.DeleteFormation);
			this.pickUpControl.CloneObject = new PickUpControl.PickUpCallback(this.CloneFormation);
			this.pickUpControl.RefreshObject = new PickUpControl.PickUpCallback(this.RefreshFormation);
			this.pickUpControl.combo.Sorted = false;
			for (int i = 0; i <= 10; i++)
			{
				this.m_LabelPos[i] = new Label();
				this.m_LabelPos[i].AutoSize = false;
				this.m_LabelPos[i].Location = new Point(118, (i + 4) * 20);
				this.m_LabelPos[i].ImageList = this.imageListPlayers;
				this.m_LabelPos[i].ImageIndex = i;
				this.m_LabelPos[i].Width = 16;
				this.m_LabelPos[i].Height = 16;
				this.m_LabelPos[i].Cursor = Cursors.Hand;
				this.m_LabelPos[i].MouseUp += this.MouseUpService;
				this.m_LabelPos[i].MouseMove += this.MouseMoveService;
				this.m_LabelPos[i].MouseDown += this.MouseDownService;
				this.pagePosition.Controls.Add(this.m_LabelPos[i]);
			}
			for (int j = 0; j <= 10; j++)
			{
				this.m_LabelArrowAtt1[j] = new Label();
				this.m_LabelArrowAtt1[j].AutoSize = false;
				this.m_LabelArrowAtt1[j].Location = new Point(50 + j * 10, (j + 1) * 20);
				this.m_LabelArrowAtt1[j].ImageList = this.imageListArrows;
				this.m_LabelArrowAtt1[j].ImageIndex = 0;
				this.m_LabelArrowAtt1[j].Width = 48;
				this.m_LabelArrowAtt1[j].Height = 48;
				this.m_LabelArrowAtt1[j].ForeColor = Color.Black;
				this.m_LabelArrowAtt1[j].Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
				this.m_LabelArrowAtt1[j].Text = (j + 1).ToString();
				this.m_LabelArrowAtt1[j].TextAlign = ContentAlignment.MiddleCenter;
				this.m_LabelArrowAtt1[j].Cursor = Cursors.Hand;
			}
			for (int k = 0; k <= 10; k++)
			{
				this.m_LabelArrowDef1[k] = new Label();
				this.m_LabelArrowDef1[k].AutoSize = false;
				this.m_LabelArrowDef1[k].Location = new Point(50 + k * 10, (k + 1) * 20);
				this.m_LabelArrowDef1[k].ImageList = this.imageListArrows;
				this.m_LabelArrowDef1[k].ImageIndex = 0;
				this.m_LabelArrowDef1[k].Width = 48;
				this.m_LabelArrowDef1[k].Height = 48;
				this.m_LabelArrowDef1[k].ForeColor = Color.Black;
				this.m_LabelArrowDef1[k].Text = (k + 1).ToString();
				this.m_LabelArrowDef1[k].Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
				this.m_LabelArrowDef1[k].TextAlign = ContentAlignment.MiddleCenter;
				this.m_LabelArrowDef1[k].Cursor = Cursors.Hand;
			}
			this.m_ComboPlayerInstructions[0, 0] = null;
			this.m_ComboPlayerInstructions[0, 1] = null;
			this.m_ComboPlayerInstructions[0, 2] = null;
			this.m_ComboPlayerInstructions[0, 3] = null;
			this.m_ComboPlayerInstructions[1, 0] = this.comboPI_10;
			this.m_ComboPlayerInstructions[1, 1] = this.comboPI_11;
			this.m_ComboPlayerInstructions[1, 2] = this.comboPI_12;
			this.m_ComboPlayerInstructions[1, 3] = this.comboPI_13;
			this.m_ComboPlayerInstructions[1, 4] = this.comboPI_14;
			this.m_ComboPlayerInstructions[2, 0] = this.comboPI_20;
			this.m_ComboPlayerInstructions[2, 1] = this.comboPI_21;
			this.m_ComboPlayerInstructions[2, 2] = this.comboPI_22;
			this.m_ComboPlayerInstructions[2, 3] = this.comboPI_23;
			this.m_ComboPlayerInstructions[2, 4] = this.comboPI_24;
			this.m_ComboPlayerInstructions[3, 0] = this.comboPI_30;
			this.m_ComboPlayerInstructions[3, 1] = this.comboPI_31;
			this.m_ComboPlayerInstructions[3, 2] = this.comboPI_32;
			this.m_ComboPlayerInstructions[3, 3] = this.comboPI_33;
			this.m_ComboPlayerInstructions[3, 4] = this.comboPI_34;
			this.m_ComboPlayerInstructions[4, 0] = this.comboPI_40;
			this.m_ComboPlayerInstructions[4, 1] = this.comboPI_41;
			this.m_ComboPlayerInstructions[4, 2] = this.comboPI_42;
			this.m_ComboPlayerInstructions[4, 3] = this.comboPI_43;
			this.m_ComboPlayerInstructions[4, 4] = this.comboPI_44;
			this.m_ComboPlayerInstructions[5, 0] = this.comboPI_50;
			this.m_ComboPlayerInstructions[5, 1] = this.comboPI_51;
			this.m_ComboPlayerInstructions[5, 2] = this.comboPI_52;
			this.m_ComboPlayerInstructions[5, 3] = this.comboPI_53;
			this.m_ComboPlayerInstructions[5, 4] = this.comboPI_54;
			this.m_ComboPlayerInstructions[6, 0] = this.comboPI_60;
			this.m_ComboPlayerInstructions[6, 1] = this.comboPI_61;
			this.m_ComboPlayerInstructions[6, 2] = this.comboPI_62;
			this.m_ComboPlayerInstructions[6, 3] = this.comboPI_63;
			this.m_ComboPlayerInstructions[6, 4] = this.comboPI_64;
			this.m_ComboPlayerInstructions[7, 0] = this.comboPI_70;
			this.m_ComboPlayerInstructions[7, 1] = this.comboPI_71;
			this.m_ComboPlayerInstructions[7, 2] = this.comboPI_72;
			this.m_ComboPlayerInstructions[7, 3] = this.comboPI_73;
			this.m_ComboPlayerInstructions[7, 4] = this.comboPI_74;
			this.m_ComboPlayerInstructions[8, 0] = this.comboPI_80;
			this.m_ComboPlayerInstructions[8, 1] = this.comboPI_81;
			this.m_ComboPlayerInstructions[8, 2] = this.comboPI_82;
			this.m_ComboPlayerInstructions[8, 3] = this.comboPI_83;
			this.m_ComboPlayerInstructions[8, 4] = this.comboPI_84;
			this.m_ComboPlayerInstructions[9, 0] = this.comboPI_90;
			this.m_ComboPlayerInstructions[9, 1] = this.comboPI_91;
			this.m_ComboPlayerInstructions[9, 2] = this.comboPI_92;
			this.m_ComboPlayerInstructions[9, 3] = this.comboPI_93;
			this.m_ComboPlayerInstructions[9, 4] = this.comboPI_94;
			this.m_ComboPlayerInstructions[10, 0] = this.comboPI_100;
			this.m_ComboPlayerInstructions[10, 1] = this.comboPI_101;
			this.m_ComboPlayerInstructions[10, 2] = this.comboPI_102;
			this.m_ComboPlayerInstructions[10, 3] = this.comboPI_103;
			this.m_ComboPlayerInstructions[10, 4] = this.comboPI_104;
			this.m_ComboInterceptions[0] = null;
			this.m_ComboInterceptions[1] = this.comboInterceptions_1;
			this.m_ComboInterceptions[2] = this.comboInterceptions_2;
			this.m_ComboInterceptions[3] = this.comboInterceptions_3;
			this.m_ComboInterceptions[4] = this.comboInterceptions_4;
			this.m_ComboInterceptions[5] = this.comboInterceptions_5;
			this.m_ComboInterceptions[6] = this.comboInterceptions_6;
			this.m_ComboInterceptions[7] = this.comboInterceptions_7;
			this.m_ComboInterceptions[8] = this.comboInterceptions_8;
			this.m_ComboInterceptions[9] = this.comboInterceptions_9;
			this.m_ComboInterceptions[10] = this.comboInterceptions_10;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00008228 File Offset: 0x00006428
		private void FormationForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008237 File Offset: 0x00006437
		private Formation SelectFormation(object sender, object obj)
		{
			this.Refresh();
			this.LoadFormation((Formation)obj);
			return (Formation)obj;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008254 File Offset: 0x00006454
		private Formation CreateFormation(object sender, object obj)
		{
			DialogResult dialogResult = this.m_NewIdCreator.ShowDialog();
			if (this.m_NewIdCreator.NewObject == null)
			{
				if (dialogResult == DialogResult.OK)
				{
					FifaEnvironment.UserMessages.ShowMessage(5060, this.m_NewIdCreator.NewId);
				}
				return null;
			}
			Formation formation = (Formation)this.m_NewIdCreator.NewObject;
			if (this.m_NewIdCreator.NewName != null && formation != null)
			{
				formation.Name = this.m_NewIdCreator.NewName;
			}
			return formation;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000082D0 File Offset: 0x000064D0
		private Formation CloneFormation(object sender, object obj)
		{
			Formation formation = (Formation)obj;
			int newId = FifaEnvironment.Formations.GetNewId();
			return (Formation)FifaEnvironment.Formations.CloneId(formation, newId);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008300 File Offset: 0x00006500
		private Formation DeleteFormation(object sender, object obj)
		{
			Formation formation = (Formation)obj;
			FifaEnvironment.Formations.RemoveId(formation);
			this.m_CurrentFormation = null;
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00008328 File Offset: 0x00006528
		public Formation RefreshFormation(object sender, object obj)
		{
			this.Preset();
			this.ReloadFormation(this.m_CurrentFormation);
			return this.m_CurrentFormation;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00008342 File Offset: 0x00006542
		public void ReloadFormation(Formation formation)
		{
			this.m_CurrentFormation = null;
			this.LoadFormation(formation);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00008354 File Offset: 0x00006554
		public void LoadFormation(Formation formation)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			this.m_LockUserChanges = true;
			if (this.m_CurrentFormation == formation)
			{
				return;
			}
			this.m_CurrentFormation = formation;
			this.m_PositioningFlag = true;
			for (int i = 0; i < 11; i++)
			{
				this.m_LabelPos[i].Tag = this.m_CurrentFormation.PlayingRoles[i];
				this.m_LabelArrowAtt1[i].Tag = this.m_CurrentFormation.PlayingRoles[i];
				this.m_LabelArrowDef1[i].Tag = this.m_CurrentFormation.PlayingRoles[i];
				this.PutLabelsOnField(i);
			}
			this.comboBox1.SelectedItem = formation.PlayingRoles[0].Role;
			this.comboBox2.SelectedItem = formation.PlayingRoles[1].Role;
			this.comboBox3.SelectedItem = formation.PlayingRoles[2].Role;
			this.comboBox4.SelectedItem = formation.PlayingRoles[3].Role;
			this.comboBox5.SelectedItem = formation.PlayingRoles[4].Role;
			this.comboBox6.SelectedItem = formation.PlayingRoles[5].Role;
			this.comboBox7.SelectedItem = formation.PlayingRoles[6].Role;
			this.comboBox8.SelectedItem = formation.PlayingRoles[7].Role;
			this.comboBox9.SelectedItem = formation.PlayingRoles[8].Role;
			this.comboBox10.SelectedItem = formation.PlayingRoles[9].Role;
			this.comboBox11.SelectedItem = formation.PlayingRoles[10].Role;
			this.m_PositioningFlag = false;
			this.checkIsSweeper.Checked = formation.formations_issweeper != 0;
			this.textName.Text = formation.Name;
			if (this.m_CurrentFormation.teamid < 0)
			{
				this.textFullName.Text = this.m_CurrentFormation.formationfullname;
				this.textFullName.Visible = true;
				this.labelFullName.Visible = true;
			}
			else
			{
				this.textFullName.Text = string.Empty;
				this.textFullName.Visible = false;
				this.labelFullName.Visible = false;
			}
			this.comboOffensiveRating.SelectedIndex = formation.offensiverating;
			this.comboFormationAudio.SelectedIndex = formation.formationaudioid;
			this.labelAssignTeam.Text = ((formation.Team != null) ? formation.Team.ToString() : "Generic");
			if (FifaEnvironment.Year != 14)
			{
				for (int j = 1; j < 11; j++)
				{
					this.ShowPlayerInstruction(j);
				}
			}
			this.m_LockUserChanges = false;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000085F4 File Offset: 0x000067F4
		private void ShowPlayerInstruction(int playerIndex)
		{
			int id = this.m_CurrentFormation.PlayingRoles[playerIndex].Role.Id;
			int num = PlayingRole.c_InstrucionNumber[id];
			for (int i = 0; i < 5; i++)
			{
				this.m_ComboPlayerInstructions[playerIndex, i].Visible = i < num;
				this.m_ComboPlayerInstructions[playerIndex, i].Items.Clear();
			}
			for (int j = 0; j < num; j++)
			{
				int num2 = PlayingRole.c_InstrucionSetSelection[id, j];
				this.m_ComboPlayerInstructions[playerIndex, j].Tag = num2;
				for (int k = 0; k < PlayingRole.c_InstrucionSet[num2].Length; k++)
				{
					int num3 = PlayingRole.c_InstrucionSet[num2][k];
					string text = PlayingRole.c_InstructionCaption[num3];
					this.m_ComboPlayerInstructions[playerIndex, j].Items.Add(text);
					if ((this.m_CurrentFormation.PlayingRoles[playerIndex].PlayerInstruction_1 & (1 << num3)) != 0)
					{
						this.m_ComboPlayerInstructions[playerIndex, j].SelectedIndex = k;
					}
				}
			}
			switch (this.m_CurrentFormation.PlayingRoles[playerIndex].PlayerInstruction_2)
			{
			case 1:
				this.m_ComboInterceptions[playerIndex].SelectedIndex = 0;
				return;
			case 2:
				this.m_ComboInterceptions[playerIndex].SelectedIndex = 1;
				return;
			case 3:
				break;
			case 4:
				this.m_ComboInterceptions[playerIndex].SelectedIndex = 2;
				break;
			default:
				return;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008768 File Offset: 0x00006968
		private void ComboRoleSelectedIndexChanged(object sender, int i)
		{
			if (this.m_PositioningFlag)
			{
				return;
			}
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox.SelectedIndex >= 0)
			{
				Role role = (Role)comboBox.SelectedItem;
				Role role2 = this.m_CurrentFormation.PlayingRoles[i].Role;
				this.m_CurrentFormation.PlayingRoles[i].Role = role;
				this.m_CurrentFormation.PlayingRoles[i].PlayerInstruction_1 = PlayingRole.GetDefaultInstruction(role.Id);
				Point center = role.GetCenter();
				this.m_CurrentFormation.PlayingRoles[i].OffsetX = center.X;
				this.m_CurrentFormation.PlayingRoles[i].OffsetY = center.Y;
				this.PutLabelsOnField(i);
				foreach (object obj in FifaEnvironment.Teams)
				{
					Team team = (Team)obj;
					if (team.Formation == this.m_CurrentFormation)
					{
						team.Roster.ChangeRole(role2, role);
					}
				}
				this.ShowPlayerInstruction(i);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008890 File Offset: 0x00006A90
		private void comboInstruction_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_PositioningFlag)
			{
				return;
			}
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox.SelectedIndex < 0)
			{
				return;
			}
			int num = -1;
			int num2 = -1;
			for (int i = 0; i < 11; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (this.m_ComboPlayerInstructions[i, j] == comboBox)
					{
						num = i;
						num2 = j;
					}
				}
			}
			if (num > 0 && num2 >= 0)
			{
				int id = this.m_CurrentFormation.PlayingRoles[num].Role.Id;
				int num3 = PlayingRole.c_InstrucionSetSelection[id, num2];
				int num4 = PlayingRole.c_InstrucionSet[num3][comboBox.SelectedIndex];
				for (int k = 0; k < PlayingRole.c_InstrucionSet[num3].Length; k++)
				{
					int num5 = PlayingRole.c_InstrucionSet[num3][k];
					if (num5 == num4)
					{
						this.m_CurrentFormation.PlayingRoles[num].PlayerInstruction_1 |= 1 << num5;
					}
					else
					{
						this.m_CurrentFormation.PlayingRoles[num].PlayerInstruction_1 &= ~(1 << num5);
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000089A4 File Offset: 0x00006BA4
		private void comboInterceptions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_PositioningFlag)
			{
				return;
			}
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox.SelectedIndex < 0)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < 11; i++)
			{
				if (this.m_ComboInterceptions[i] == comboBox)
				{
					num = i;
				}
			}
			if (num > 0)
			{
				this.m_CurrentFormation.PlayingRoles[num].PlayerInstruction_2 = 1 << comboBox.SelectedIndex;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00008A08 File Offset: 0x00006C08
		private void textName_TextChanged(object sender, EventArgs e)
		{
			this.m_CurrentFormation.Name = this.textName.Text;
			this.pickUpControl.SwitchObject(this.m_CurrentFormation);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008A31 File Offset: 0x00006C31
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 1);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008A3B File Offset: 0x00006C3B
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008A45 File Offset: 0x00006C45
		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 3);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008A4F File Offset: 0x00006C4F
		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 4);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008A59 File Offset: 0x00006C59
		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 5);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008A63 File Offset: 0x00006C63
		private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 6);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008A6D File Offset: 0x00006C6D
		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 7);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008A77 File Offset: 0x00006C77
		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 8);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008A81 File Offset: 0x00006C81
		private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 9);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008A8C File Offset: 0x00006C8C
		private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ComboRoleSelectedIndexChanged(sender, 10);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008A98 File Offset: 0x00006C98
		public void Preset()
		{
			this.m_NewIdCreator.IdList = FifaEnvironment.Formations;
			IdArrayList[] array = new IdArrayList[]
			{
				null,
				FifaEnvironment.Leagues,
				FifaEnvironment.Countries,
				FifaEnvironment.Teams
			};
			this.pickUpControl.FilterValues = array;
			this.comboBox1.Items.Clear();
			this.comboBox1.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox2.Items.Clear();
			this.comboBox2.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox3.Items.Clear();
			this.comboBox3.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox4.Items.Clear();
			this.comboBox4.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox5.Items.Clear();
			this.comboBox5.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox6.Items.Clear();
			this.comboBox6.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox7.Items.Clear();
			this.comboBox7.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox8.Items.Clear();
			this.comboBox8.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox9.Items.Clear();
			this.comboBox9.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox10.Items.Clear();
			this.comboBox10.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboBox11.Items.Clear();
			this.comboBox11.Items.AddRange(FifaEnvironment.Roles.ToArray());
			this.comboFormation.Items.Clear();
			foreach (object obj in FifaEnvironment.Formations)
			{
				Formation formation = (Formation)obj;
				if (formation.IsGeneric())
				{
					this.comboFormation.Items.Add(formation);
				}
			}
			this.pickUpControl.ObjectList = FifaEnvironment.Formations;
			this.groupInstructions.Visible = FifaEnvironment.Year != 14;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008D48 File Offset: 0x00006F48
		private void PutLabelsOnField(int i)
		{
			int num = this.m_CurrentFormation.PlayingRoles[i].OffsetX;
			int num2 = this.m_CurrentFormation.PlayingRoles[i].OffsetY;
			num = this.OffsetToFieldX(num);
			num2 = this.OffsetToFieldY(num2);
			this.m_LabelPos[i].Location = new Point(num, num2);
			num -= 16;
			num2 -= 16;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00008DA9 File Offset: 0x00006FA9
		private int FieldXToOffset(int x)
		{
			return (250 - (x + 8)) * 2 / 5;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008DB8 File Offset: 0x00006FB8
		private int FieldYToOffset(int y)
		{
			return (y + 8) * 2 / 7;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008DC1 File Offset: 0x00006FC1
		private int OffsetToFieldX(int x)
		{
			return 250 - (x * 2 + x / 2) - 8;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008DD2 File Offset: 0x00006FD2
		private int OffsetToFieldY(int y)
		{
			return y * 3 + y / 2 - 8;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008DE0 File Offset: 0x00006FE0
		private void MouseUpService(object sender, MouseEventArgs e)
		{
			int x = this.m_MovingLabel.Location.X;
			int y = this.m_MovingLabel.Location.Y;
			this.m_MovingLabel = null;
			if (this.m_MovingLabelIndex >= 0)
			{
				this.m_CurrentFormation.PlayingRoles[this.m_MovingLabelIndex].m_OffsetX = this.FieldXToOffset(x);
				this.m_CurrentFormation.PlayingRoles[this.m_MovingLabelIndex].m_OffsetY = this.FieldYToOffset(y);
				this.PutLabelsOnField(this.m_MovingLabelIndex);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008E6D File Offset: 0x0000706D
		private void MouseMoveService(object sender, MouseEventArgs e)
		{
			if (this.m_MovingLabel != null)
			{
				this.MovePicture(e, this.m_MovingLabel);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008E84 File Offset: 0x00007084
		private void MouseDownService(object sender, MouseEventArgs e)
		{
			this.m_MovingLabel = (Label)sender;
			this.m_MovingLabelIndex = -1;
			for (int i = 0; i < 11; i++)
			{
				if (this.m_MovingLabel == this.m_LabelPos[i])
				{
					this.m_MovingLabelIndex = i;
					this.m_BoundRight = this.OffsetToFieldX(this.m_CurrentFormation.PlayingRoles[i].Role.Xmin);
					this.m_BoundLeft = this.OffsetToFieldX(this.m_CurrentFormation.PlayingRoles[i].Role.Xmax);
					this.m_BoundTop = this.OffsetToFieldY(this.m_CurrentFormation.PlayingRoles[i].Role.Ymin);
					this.m_BoundBottom = this.OffsetToFieldY(this.m_CurrentFormation.PlayingRoles[i].Role.Ymax);
					return;
				}
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008F60 File Offset: 0x00007160
		private void MovePicture(MouseEventArgs e, Label picture)
		{
			int num = e.X - 8;
			int num2 = e.Y - 8;
			this.m_LabelLocation.X = picture.Location.X + num;
			this.m_LabelLocation.Y = picture.Location.Y + num2;
			if (this.m_LabelLocation.X < this.m_BoundLeft)
			{
				this.m_LabelLocation.X = this.m_BoundLeft;
			}
			if (this.m_LabelLocation.X > this.m_BoundRight)
			{
				this.m_LabelLocation.X = this.m_BoundRight;
			}
			if (this.m_LabelLocation.Y < this.m_BoundTop)
			{
				this.m_LabelLocation.Y = this.m_BoundTop;
			}
			if (this.m_LabelLocation.Y > this.m_BoundBottom)
			{
				this.m_LabelLocation.Y = this.m_BoundBottom;
			}
			picture.Location = this.m_LabelLocation;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009054 File Offset: 0x00007254
		private void buttonPresetFormation_Click(object sender, EventArgs e)
		{
			Formation formation = (Formation)this.comboFormation.SelectedItem;
			if (formation != null)
			{
				this.m_CurrentFormation.ReInitialize(formation);
			}
			if (this.m_CurrentFormation.Team != null)
			{
				this.m_CurrentFormation.Team.AssignTitolarToRoles(this.m_CurrentFormation);
			}
			this.ReloadFormation(this.m_CurrentFormation);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000090B1 File Offset: 0x000072B1
		private void checkIsSweeper_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			this.m_CurrentFormation.formations_issweeper = (this.checkIsSweeper.Checked ? 1 : 0);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000090D8 File Offset: 0x000072D8
		private void comboOffensiveRating_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboOffensiveRating.SelectedIndex >= 0)
			{
				this.m_CurrentFormation.offensiverating = this.comboOffensiveRating.SelectedIndex;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000090FE File Offset: 0x000072FE
		private void labelAssignTeam_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentFormation.Team != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentFormation.Team);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00009122 File Offset: 0x00007322
		private void comboFormationAudio_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboFormationAudio.SelectedIndex >= 0)
			{
				this.m_CurrentFormation.formationaudioid = this.comboFormationAudio.SelectedIndex;
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00009148 File Offset: 0x00007348
		private void textFullName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_LockUserChanges)
			{
				return;
			}
			if (this.m_CurrentFormation.teamid < 0)
			{
				this.m_CurrentFormation.formationfullname = this.textFullName.Text;
				if (this.m_CurrentFormation.formationfullnameid == -1)
				{
					this.m_CurrentFormation.formationfullnameid = FifaEnvironment.Language.GetFreeFormationFullNameId();
					if (this.m_CurrentFormation.formationfullnameid != -1)
					{
						FifaEnvironment.Language.SetFormationString(this.m_CurrentFormation.formationfullnameid, this.m_CurrentFormation.formationfullname);
					}
				}
			}
		}

		// Token: 0x0400005F RID: 95
		private Formation m_CurrentFormation;

		// Token: 0x04000060 RID: 96
		private bool m_LockUserChanges;

		// Token: 0x04000061 RID: 97
		private bool m_IsLoaded;

		// Token: 0x04000062 RID: 98
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000063 RID: 99
		private bool m_PositioningFlag;

		// Token: 0x04000064 RID: 100
		private Label[] m_LabelPos = new Label[11];

		// Token: 0x04000065 RID: 101
		private Label[] m_LabelArrowAtt1 = new Label[11];

		// Token: 0x04000066 RID: 102
		private Label[] m_LabelArrowDef1 = new Label[11];

		// Token: 0x04000067 RID: 103
		private Label m_MovingLabel;

		// Token: 0x04000068 RID: 104
		private int m_MovingLabelIndex;

		// Token: 0x04000069 RID: 105
		private int m_BoundLeft;

		// Token: 0x0400006A RID: 106
		private int m_BoundRight = 250;

		// Token: 0x0400006B RID: 107
		private int m_BoundTop;

		// Token: 0x0400006C RID: 108
		private int m_BoundBottom = 350;

		// Token: 0x0400006D RID: 109
		private Point m_LabelLocation = new Point(0, 0);

		// Token: 0x0400006E RID: 110
		private ComboBox[,] m_ComboPlayerInstructions = new ComboBox[11, 5];

		// Token: 0x0400006F RID: 111
		private ComboBox[] m_ComboInterceptions = new ComboBox[11];
	}
}
