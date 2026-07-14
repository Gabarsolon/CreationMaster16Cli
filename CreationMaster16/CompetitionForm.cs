using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;

namespace CreationMaster
{
	// Token: 0x0200001E RID: 30
	public partial class CompetitionForm : Form
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00080E78 File Offset: 0x0007F078
		public CompetitionForm()
		{
			base.Visible = false;
			this.InitializeComponent();
			for (int i = this.m_QRLabels.Length - 1; i >= 0; i--)
			{
				this.m_QRLabels[i] = new Label();
				this.m_QRLabels[i].Location = new Point(2, 58 + 20 * i);
				this.m_QRLabels[i].Name = "labelQR" + i.ToString();
				this.m_QRLabels[i].Text = "labelQR" + i.ToString();
				this.m_QRLabels[i].Size = new Size(480, 19);
				this.m_QRLabels[i].Dock = DockStyle.None;
				this.m_QRLabels[i].BorderStyle = BorderStyle.None;
				this.m_QRLabels[i].Cursor = Cursors.Hand;
				this.panelQualificationRules.Controls.Add(this.m_QRLabels[i]);
				this.m_QRLabels[i].Click += this.labelQR_Click;
			}
			for (int j = this.m_AdvanceLabels.Length - 1; j >= 0; j--)
			{
				this.m_AdvanceLabels[j] = new Label();
				this.m_AdvanceLabels[j].Location = new Point(4, 28 + 20 * j);
				this.m_AdvanceLabels[j].Name = "labelAdvancemenet" + j.ToString();
				this.m_AdvanceLabels[j].Text = "label advancement " + j.ToString();
				this.m_AdvanceLabels[j].Size = new Size(120, 19);
				this.m_AdvanceLabels[j].Dock = DockStyle.Top;
				this.m_AdvanceLabels[j].Cursor = Cursors.Hand;
				this.panelAdvancement.Controls.Add(this.m_AdvanceLabels[j]);
				this.m_AdvanceLabels[j].Click += this.labelAdvance_Click;
			}
			this.m_UpdateTableLabels[0] = this.labelUpdateTable1;
			this.m_UpdateTableLabels[1] = this.labelUpdateTable2;
			this.m_UpdateTableLabels[2] = this.labelUpdateTable3;
			this.m_UpdateTableLabels[3] = this.labelUpdateTable4;
			this.m_UpdateTableLabels[4] = this.labelUpdateTable5;
			this.m_UpdateTableLabels[5] = this.labelUpdateTable6;
			this.m_UpdateTableLabels[6] = this.labelUpdateTable7;
			this.m_UpdateTableLabels[7] = this.labelUpdateTable8;
			this.m_UpdateTableLabels[8] = this.labelUpdateTable9;
			this.m_UpdateTableLabels[9] = this.labelUpdateTable10;
			this.m_UpdateTableLabels[10] = this.labelUpdateTable11;
			this.m_UpdateTableLabels[11] = this.labelUpdateTable12;
			this.m_UpdateTableLabels[12] = this.labelUpdateTable13;
			this.m_UpdateTableLabels[13] = this.labelUpdateTable14;
			this.m_UpdateTableLabels[14] = this.labelUpdateTable15;
			this.m_UpdateTableLabels[15] = this.labelUpdateTable16;
			this.m_UpdateTableLabels[16] = this.labelUpdateTable17;
			this.m_UpdateTableLabels[17] = this.labelUpdateTable18;
			this.m_UpdateTableLabels[18] = this.labelUpdateTable19;
			this.m_UpdateTableLabels[19] = this.labelUpdateTable20;
			this.m_UpdateTableLabels[20] = this.labelUpdateTable21;
			this.m_UpdateTableLabels[21] = this.labelUpdateTable22;
			this.m_UpdateTableLabels[22] = this.labelUpdateTable23;
			this.m_UpdateTableLabels[23] = this.labelUpdateTable24;
			this.m_SpecialTeamCombos[0] = this.comboSpecialTeam1;
			this.m_SpecialTeamCombos[1] = this.comboSpecialTeam2;
			this.m_SpecialTeamCombos[2] = this.comboSpecialTeam3;
			this.m_SpecialTeamCombos[3] = this.comboSpecialTeam4;
			this.m_StadiumCombos[0] = this.comboStadium1;
			this.m_StadiumCombos[1] = this.comboStadium2;
			this.m_StadiumCombos[2] = this.comboStadium3;
			this.m_StadiumCombos[3] = this.comboStadium4;
			this.m_StadiumCombos[4] = this.comboStadium5;
			this.m_StadiumCombos[5] = this.comboStadium6;
			this.m_StadiumCombos[6] = this.comboStadium7;
			this.m_StadiumCombos[7] = this.comboStadium8;
			this.m_StadiumCombos[8] = this.comboStadium9;
			this.m_StadiumCombos[9] = this.comboStadium10;
			this.m_StadiumCombos[10] = this.comboStadium11;
			this.m_StadiumCombos[11] = this.comboStadium12;
			this.m_OvercastProb[0] = this.numericUpDown1;
			this.m_SnowProb[0] = this.numericUpDown2;
			this.m_RainProb[0] = this.numericUpDown3;
			this.m_OvercastProb[1] = this.numericUpDown4;
			this.m_SnowProb[1] = this.numericUpDown5;
			this.m_RainProb[1] = this.numericUpDown6;
			this.m_OvercastProb[2] = this.numericUpDown7;
			this.m_SnowProb[2] = this.numericUpDown8;
			this.m_RainProb[2] = this.numericUpDown9;
			this.m_OvercastProb[3] = this.numericUpDown10;
			this.m_SnowProb[3] = this.numericUpDown11;
			this.m_RainProb[3] = this.numericUpDown12;
			this.m_OvercastProb[4] = this.numericUpDown13;
			this.m_SnowProb[4] = this.numericUpDown14;
			this.m_RainProb[4] = this.numericUpDown15;
			this.m_OvercastProb[5] = this.numericUpDown16;
			this.m_SnowProb[5] = this.numericUpDown17;
			this.m_RainProb[5] = this.numericUpDown18;
			this.m_OvercastProb[6] = this.numericUpDown19;
			this.m_SnowProb[6] = this.numericUpDown20;
			this.m_RainProb[6] = this.numericUpDown21;
			this.m_OvercastProb[7] = this.numericUpDown22;
			this.m_SnowProb[7] = this.numericUpDown23;
			this.m_RainProb[7] = this.numericUpDown24;
			this.m_OvercastProb[8] = this.numericUpDown25;
			this.m_SnowProb[8] = this.numericUpDown26;
			this.m_RainProb[8] = this.numericUpDown27;
			this.m_OvercastProb[9] = this.numericUpDown28;
			this.m_SnowProb[9] = this.numericUpDown29;
			this.m_RainProb[9] = this.numericUpDown30;
			this.m_OvercastProb[10] = this.numericUpDown31;
			this.m_SnowProb[10] = this.numericUpDown32;
			this.m_RainProb[10] = this.numericUpDown33;
			this.m_OvercastProb[11] = this.numericUpDown34;
			this.m_SnowProb[11] = this.numericUpDown35;
			this.m_RainProb[11] = this.numericUpDown36;
			this.m_ClearProb[11] = this.numericUpDown37;
			this.m_ClearProb[10] = this.numericUpDown38;
			this.m_ClearProb[9] = this.numericUpDown39;
			this.m_ClearProb[8] = this.numericUpDown40;
			this.m_ClearProb[7] = this.numericUpDown41;
			this.m_ClearProb[6] = this.numericUpDown42;
			this.m_ClearProb[5] = this.numericUpDown43;
			this.m_ClearProb[4] = this.numericUpDown44;
			this.m_ClearProb[3] = this.numericUpDown45;
			this.m_ClearProb[2] = this.numericUpDown46;
			this.m_ClearProb[1] = this.numericUpDown47;
			this.m_ClearProb[0] = this.numericUpDown48;
			this.m_HazyProb[11] = this.numericUpDown49;
			this.m_HazyProb[10] = this.numericUpDown50;
			this.m_HazyProb[9] = this.numericUpDown51;
			this.m_HazyProb[8] = this.numericUpDown52;
			this.m_HazyProb[7] = this.numericUpDown53;
			this.m_HazyProb[6] = this.numericUpDown54;
			this.m_HazyProb[5] = this.numericUpDown55;
			this.m_HazyProb[4] = this.numericUpDown56;
			this.m_HazyProb[3] = this.numericUpDown57;
			this.m_HazyProb[2] = this.numericUpDown58;
			this.m_HazyProb[1] = this.numericUpDown59;
			this.m_HazyProb[0] = this.numericUpDown60;
			this.m_CloudyProb[11] = this.numericUpDown61;
			this.m_CloudyProb[10] = this.numericUpDown62;
			this.m_CloudyProb[9] = this.numericUpDown63;
			this.m_CloudyProb[8] = this.numericUpDown64;
			this.m_CloudyProb[7] = this.numericUpDown65;
			this.m_CloudyProb[6] = this.numericUpDown66;
			this.m_CloudyProb[5] = this.numericUpDown67;
			this.m_CloudyProb[4] = this.numericUpDown68;
			this.m_CloudyProb[3] = this.numericUpDown69;
			this.m_CloudyProb[2] = this.numericUpDown70;
			this.m_CloudyProb[1] = this.numericUpDown71;
			this.m_CloudyProb[0] = this.numericUpDown72;
			this.m_FoggyProb[11] = this.numericUpDown73;
			this.m_FoggyProb[10] = this.numericUpDown74;
			this.m_FoggyProb[9] = this.numericUpDown75;
			this.m_FoggyProb[8] = this.numericUpDown76;
			this.m_FoggyProb[7] = this.numericUpDown77;
			this.m_FoggyProb[6] = this.numericUpDown78;
			this.m_FoggyProb[5] = this.numericUpDown79;
			this.m_FoggyProb[4] = this.numericUpDown80;
			this.m_FoggyProb[3] = this.numericUpDown81;
			this.m_FoggyProb[2] = this.numericUpDown82;
			this.m_FoggyProb[1] = this.numericUpDown83;
			this.m_FoggyProb[0] = this.numericUpDown84;
			this.m_ShowersProb[11] = this.numericUpDown85;
			this.m_ShowersProb[10] = this.numericUpDown86;
			this.m_ShowersProb[9] = this.numericUpDown87;
			this.m_ShowersProb[8] = this.numericUpDown88;
			this.m_ShowersProb[7] = this.numericUpDown89;
			this.m_ShowersProb[6] = this.numericUpDown90;
			this.m_ShowersProb[5] = this.numericUpDown91;
			this.m_ShowersProb[4] = this.numericUpDown92;
			this.m_ShowersProb[3] = this.numericUpDown93;
			this.m_ShowersProb[2] = this.numericUpDown94;
			this.m_ShowersProb[1] = this.numericUpDown95;
			this.m_ShowersProb[0] = this.numericUpDown96;
			this.m_FlurriesProb[11] = this.numericUpDown97;
			this.m_FlurriesProb[10] = this.numericUpDown98;
			this.m_FlurriesProb[9] = this.numericUpDown99;
			this.m_FlurriesProb[8] = this.numericUpDown100;
			this.m_FlurriesProb[7] = this.numericUpDown101;
			this.m_FlurriesProb[6] = this.numericUpDown102;
			this.m_FlurriesProb[5] = this.numericUpDown103;
			this.m_FlurriesProb[4] = this.numericUpDown104;
			this.m_FlurriesProb[3] = this.numericUpDown105;
			this.m_FlurriesProb[2] = this.numericUpDown106;
			this.m_FlurriesProb[1] = this.numericUpDown107;
			this.m_FlurriesProb[0] = this.numericUpDown108;
			for (int k = 0; k < 12; k++)
			{
				this.m_OvercastProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_SnowProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_RainProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_ClearProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_HazyProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_CloudyProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_FoggyProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_ShowersProb[k].ValueChanged += this.weatherProb_ValueChanged;
				this.m_FlurriesProb[k].ValueChanged += this.weatherProb_ValueChanged;
			}
			this.m_NightTime[0] = this.comboBox1;
			this.m_SunsetTime[0] = this.comboBox2;
			this.m_NightTime[1] = this.comboBox3;
			this.m_SunsetTime[1] = this.comboBox4;
			this.m_NightTime[2] = this.comboBox5;
			this.m_SunsetTime[2] = this.comboBox6;
			this.m_NightTime[3] = this.comboBox7;
			this.m_SunsetTime[3] = this.comboBox8;
			this.m_NightTime[4] = this.comboBox9;
			this.m_SunsetTime[4] = this.comboBox10;
			this.m_NightTime[5] = this.comboBox11;
			this.m_SunsetTime[5] = this.comboBox12;
			this.m_NightTime[6] = this.comboBox13;
			this.m_SunsetTime[6] = this.comboBox14;
			this.m_NightTime[7] = this.comboBox15;
			this.m_SunsetTime[7] = this.comboBox16;
			this.m_NightTime[8] = this.comboBox17;
			this.m_SunsetTime[8] = this.comboBox18;
			this.m_NightTime[9] = this.comboBox19;
			this.m_SunsetTime[9] = this.comboBox20;
			this.m_NightTime[10] = this.comboBox21;
			this.m_SunsetTime[10] = this.comboBox22;
			this.m_NightTime[11] = this.comboBox23;
			this.m_SunsetTime[11] = this.comboBox24;
			for (int l = 0; l < 12; l++)
			{
				this.m_NightTime[l].SelectedIndexChanged += this.dayTime_SelectedIndexChanged;
				this.m_SunsetTime[l].SelectedIndexChanged += this.dayTime_SelectedIndexChanged;
			}
			this.m_InitTeamPanel[0] = this.panelInitTeam1;
			this.m_InitTeamPanel[1] = this.panelInitTeam2;
			this.m_InitTeamPanel[2] = this.panelInitTeam3;
			this.m_InitTeamPanel[3] = this.panelInitTeam4;
			this.m_InitTeamPanel[4] = this.panelInitTeam5;
			this.m_InitTeamPanel[5] = this.panelInitTeam6;
			this.m_InitTeamPanel[6] = this.panelInitTeam7;
			this.m_InitTeamPanel[7] = this.panelInitTeam8;
			this.m_InitTeamPanel[8] = this.panelInitTeam9;
			this.m_InitTeamPanel[9] = this.panelInitTeam10;
			this.m_InitTeamPanel[10] = this.panelInitTeam11;
			this.m_InitTeamPanel[11] = this.panelInitTeam12;
			this.m_InitTeamPanel[12] = this.panelInitTeam13;
			this.m_InitTeamPanel[13] = this.panelInitTeam14;
			this.m_InitTeamPanel[14] = this.panelInitTeam15;
			this.m_InitTeamPanel[15] = this.panelInitTeam16;
			this.m_InitTeamPanel[16] = this.panelInitTeam17;
			this.m_InitTeamPanel[17] = this.panelInitTeam18;
			this.m_InitTeamPanel[18] = this.panelInitTeam19;
			this.m_InitTeamPanel[19] = this.panelInitTeam20;
			this.m_InitTeamPanel[20] = this.panelInitTeam21;
			this.m_InitTeamPanel[21] = this.panelInitTeam22;
			this.m_InitTeamPanel[22] = this.panelInitTeam23;
			this.m_InitTeamPanel[23] = this.panelInitTeam24;
			this.m_InitTeamCombo[0] = this.comboInitTeam1;
			this.m_InitTeamCombo[1] = this.comboInitTeam2;
			this.m_InitTeamCombo[2] = this.comboInitTeam3;
			this.m_InitTeamCombo[3] = this.comboInitTeam4;
			this.m_InitTeamCombo[4] = this.comboInitTeam5;
			this.m_InitTeamCombo[5] = this.comboInitTeam6;
			this.m_InitTeamCombo[6] = this.comboInitTeam7;
			this.m_InitTeamCombo[7] = this.comboInitTeam8;
			this.m_InitTeamCombo[8] = this.comboInitTeam9;
			this.m_InitTeamCombo[9] = this.comboInitTeam10;
			this.m_InitTeamCombo[10] = this.comboInitTeam11;
			this.m_InitTeamCombo[11] = this.comboInitTeam12;
			this.m_InitTeamCombo[12] = this.comboInitTeam13;
			this.m_InitTeamCombo[13] = this.comboInitTeam14;
			this.m_InitTeamCombo[14] = this.comboInitTeam15;
			this.m_InitTeamCombo[15] = this.comboInitTeam16;
			this.m_InitTeamCombo[16] = this.comboInitTeam17;
			this.m_InitTeamCombo[17] = this.comboInitTeam18;
			this.m_InitTeamCombo[18] = this.comboInitTeam19;
			this.m_InitTeamCombo[19] = this.comboInitTeam20;
			this.m_InitTeamCombo[20] = this.comboInitTeam21;
			this.m_InitTeamCombo[21] = this.comboInitTeam22;
			this.m_InitTeamCombo[22] = this.comboInitTeam23;
			this.m_InitTeamCombo[23] = this.comboInitTeam24;
			for (int m = 0; m < this.m_InitTeamCombo.Length; m++)
			{
				this.m_InitTeamCombo[m].SelectedIndexChanged += this.comboInitTeam_SelectedIndexChanged;
			}
			for (int n = 0; n < 24; n++)
			{
				this.m_InitTeamPanel[n].Visible = false;
			}
			this.viewer2DTrophy.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageTrophy);
			this.viewer2DTrophy.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteTrophy);
			this.viewer2DTrophy.ButtonStripVisible = true;
			this.viewer2DTrophy.RemoveButton = true;
			this.viewer2DTrophy256.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageTrophy256);
			this.viewer2DTrophy256.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteTrophy256);
			this.viewer2DTrophy256.ButtonStripVisible = true;
			this.viewer2DTrophy256.RemoveButton = true;
			this.viewer2DTrophy128.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageTrophySmall);
			this.viewer2DTrophy128.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteTrophySmall);
			this.viewer2DTrophy128.ButtonStripVisible = true;
			this.viewer2DTrophy128.RemoveButton = true;
			this.multiViewer2DTextures.Rx3ExportDelegate = new MultiViewer2D.Rx3ExportHandler(this.ExportRx3TrophyTextures);
			this.multiViewer2DTextures.Rx3ImportDelegate = new MultiViewer2D.Rx3ImportHandler(this.ImportRx3TrophyTextures);
			this.multiViewer2DTextures.Rx3SaveDelegate = new MultiViewer2D.Rx3SaveHandler(this.SaveRx3TrophyTextures);
			this.viewer2DTournamentAdboard.ButtonStripVisible = true;
			this.viewer2DTournamentAdboard.FullSizeButton = true;
			this.viewer2DTournamentAdboard.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImageAdboard);
			this.viewer2DTournamentAdboard.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeleteTrophyAdboard);
			this.viewer2DPitchDressing.ButtonStripVisible = true;
			this.viewer2DPitchDressing.FullSizeButton = true;
			this.viewer2DPitchDressing.RemoveButton = true;
			this.viewer2DPitchDressing.ImageImport = new Viewer2D.ImageImportHandler(this.ImportImagePitchDressing);
			this.viewer2DPitchDressing.ImageDelete = new Viewer2D.ImageDeleteHandler(this.DeletePitchDressing);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000219B File Offset: 0x0000039B
		public void Clean()
		{
			base.Visible = false;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00082120 File Offset: 0x00080320
		private Trophy SelectTrophy(object sender, object obj)
		{
			Trophy trophy = (Trophy)obj;
			this.Refresh();
			this.LoadTrophy(trophy);
			return trophy;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00082142 File Offset: 0x00080342
		private bool ImportImageTrophy(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTrophy.SetTrophy(bitmap);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00082150 File Offset: 0x00080350
		private bool DeleteTrophy(object sender)
		{
			return this.m_CurrentTrophy.DeleteTrophy();
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0008215D File Offset: 0x0008035D
		private bool ImportImageAdboard(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTrophy.SetAdboard(bitmap);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0008216B File Offset: 0x0008036B
		private bool DeleteTrophyAdboard(object sender)
		{
			return this.m_CurrentTrophy.DeleteAdboard();
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00082178 File Offset: 0x00080378
		private bool ImportImagePitchDressing(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTrophy.SetPitchDressing(bitmap);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00082186 File Offset: 0x00080386
		private bool DeletePitchDressing(object sender)
		{
			return this.m_CurrentTrophy.DeletePitchDressing();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00082193 File Offset: 0x00080393
		private bool ImportImageTrophy256(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTrophy.SetTrophy256(bitmap);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000821A1 File Offset: 0x000803A1
		private bool DeleteTrophy256(object sender)
		{
			return this.m_CurrentTrophy.DeleteTrophy256();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000821AE File Offset: 0x000803AE
		private bool ImportImageTrophySmall(object sender, Bitmap bitmap)
		{
			return this.m_CurrentTrophy.SetTrophy128(bitmap);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000821BC File Offset: 0x000803BC
		private bool DeleteTrophySmall(object sender)
		{
			return this.m_CurrentTrophy.DeleteTrophy128();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000821C9 File Offset: 0x000803C9
		private bool ExportRx3TrophyTextures(object sender, string exportDir)
		{
			return FifaEnvironment.ExportFileFromZdata(this.m_CurrentTrophy.TexturesFileName(), exportDir);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000821DC File Offset: 0x000803DC
		private bool SaveRx3TrophyTextures(object sender, Bitmap[] bitmaps)
		{
			bool flag = this.m_CurrentTrophy.SetTextures(bitmaps);
			if (flag)
			{
				this.ReloadTrophy(this.m_CurrentTrophy);
			}
			return flag;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000821F9 File Offset: 0x000803F9
		private bool ImportRx3TrophyTextures(object sender, string rx3FileName)
		{
			bool flag = this.m_CurrentTrophy.SetTextures(rx3FileName);
			if (flag)
			{
				this.ReloadTrophy(this.m_CurrentTrophy);
			}
			return flag;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00082216 File Offset: 0x00080416
		private bool ImportImageTextures(object sender, Bitmap[] bitmaps)
		{
			if (this.m_CurrentTrophy == null)
			{
				return false;
			}
			bool flag = Ball.SetRevModTrophyBallTextures(this.m_CurrentTrophy.Settings.m_asset_id, bitmaps);
			this.LoadRevModBall();
			return flag;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0008223E File Offset: 0x0008043E
		private bool ExportFshTexture(object sender)
		{
			return this.m_CurrentTrophy != null && FifaEnvironment.AskAndExportFromZdata(Ball.RevModTrophyBallTextureFileName(this.m_CurrentTrophy.Settings.m_asset_id), ref this.m_TrophyCurrentFolder);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0008226A File Offset: 0x0008046A
		private bool DeleteTexture(object sender)
		{
			if (this.m_CurrentTrophy == null)
			{
				return false;
			}
			bool flag = Ball.DeleteRevModTrophyBallTextures(this.m_CurrentTrophy.Settings.m_asset_id);
			this.LoadRevModBall();
			return flag;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00082294 File Offset: 0x00080494
		private void buttonImportRevModBall3DModel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_TrophyCurrentFolder, "Open 3D Ball Model file", "3D ball model files (*.rx3)|ball_*.rx3");
			if (text == null)
			{
				return;
			}
			Ball.SetRevModTrophyBallModel(this.m_CurrentTrophy.Settings.m_asset_id, text);
			this.LoadRevModBall();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000822E4 File Offset: 0x000804E4
		private void buttonExportRevModBall3DModel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			string text = Ball.RevModTrophyBallModelFileName(this.m_CurrentTrophy.Settings.m_asset_id);
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_TrophyCurrentFolder);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00082320 File Offset: 0x00080520
		private void buttonRemoveRevModBall3DModel_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			Ball.DeleteRevModTrophyBallModel(this.m_CurrentTrophy.Settings.m_asset_id);
			this.LoadRevModBall();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00082347 File Offset: 0x00080547
		private void buttonShowRevModBall3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DRevModBall();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00082350 File Offset: 0x00080550
		public void Show3DRevModBall()
		{
			if (!this.buttonShow3DBall.Checked)
			{
				this.viewer3DTournamentBall.ShowEmpty();
				return;
			}
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			Bitmap[] revModTrophyBallTextures = Ball.GetRevModTrophyBallTextures(this.m_CurrentTrophy.Settings.m_asset_id);
			Bitmap bitmap = null;
			if (revModTrophyBallTextures != null)
			{
				bitmap = GraphicUtil.EmbossBitmap(revModTrophyBallTextures[0], revModTrophyBallTextures[1]);
			}
			Rx3File revModTrophyBallModel = Ball.GetRevModTrophyBallModel(this.m_CurrentTrophy.Settings.m_asset_id);
			if (bitmap == null || revModTrophyBallModel == null)
			{
				this.viewer3DTournamentBall.Clean(1);
				this.viewer3DTournamentBall.Render();
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			Model3D model3D = new Model3D(revModTrophyBallModel.Rx3IndexArrays[0], revModTrophyBallModel.Rx3VertexArrays[0], bitmap);
			this.viewer3DTournamentBall.Clean(1);
			this.viewer3DTournamentBall.SetMesh(0, model3D);
			this.viewer3DTournamentBall.Render();
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0008241B File Offset: 0x0008061B
		private void LoadRevModBall()
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			this.multiViewer2DTournamentBallTextures.Bitmaps = Ball.GetRevModTrophyBallTextures(this.m_CurrentTrophy.Settings.m_asset_id);
			this.Show3DRevModBall();
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00082455 File Offset: 0x00080655
		public void LoadCompetitions()
		{
			this.WorldStructureToPanel();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0008245D File Offset: 0x0008065D
		public void LoadTrophy(Trophy trophy)
		{
			if (!this.m_IsLoaded)
			{
				return;
			}
			if (this.m_CurrentTrophy == trophy)
			{
				return;
			}
			this.m_Locked = true;
			this.m_CurrentTrophy = trophy;
			this.m_Locked = false;
			this.TrophyToPanel();
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00082490 File Offset: 0x00080690
		public void Preset()
		{
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DTrophy128.Visible = true;
				this.viewer2DTrophy.Visible = false;
				this.buttonReplicateTrophy128.Visible = true;
				this.buttonReplicateTropy.Visible = false;
			}
			else
			{
				this.viewer2DTrophy128.Visible = false;
				this.viewer2DTrophy.Visible = true;
				this.buttonReplicateTrophy128.Visible = false;
				this.buttonReplicateTropy.Visible = true;
			}
			this.m_NewIdCreator.IdList = FifaEnvironment.CompetitionObjects.Trophies;
			Schedule.s_BaseDate = new DateTime(2014, 12, 28, 0, 0, 0);
			if (this.comboCountry.Items.Count != FifaEnvironment.Countries.Count)
			{
				this.comboCountry.Items.Clear();
				this.comboCountry.Items.AddRange(FifaEnvironment.Countries.ToArray());
			}
			if (this.comboPromotionLeague.Items.Count != FifaEnvironment.Leagues.Count + 1)
			{
				this.comboPromotionLeague.Items.Clear();
				this.comboPromotionLeague.Items.Add("None");
				this.comboPromotionLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
			if (this.comboRelegationLeague.Items.Count != FifaEnvironment.Leagues.Count + 1)
			{
				this.comboRelegationLeague.Items.Clear();
				this.comboRelegationLeague.Items.Add("None");
				this.comboRelegationLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
			if (this.comboTargetLeague.Items.Count != FifaEnvironment.Leagues.Count + 1)
			{
				this.comboTargetLeague.Items.Clear();
				this.comboTargetLeague.Items.Add("None");
				this.comboTargetLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
				this.comboTargetLeague.SelectedIndex = 0;
			}
			if (this.comboLeagueStats.Items.Count != FifaEnvironment.Leagues.Count + 1)
			{
				this.comboLeagueStats.Items.Clear();
				this.comboLeagueStats.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
			if (this.comboSpecialTeam1.Items.Count != FifaEnvironment.Teams.Count + 1)
			{
				for (int i = 0; i < 4; i++)
				{
					this.m_SpecialTeamCombos[i].Items.Clear();
					this.m_SpecialTeamCombos[i].Items.Add("<None>");
					this.m_SpecialTeamCombos[i].Items.AddRange(FifaEnvironment.Teams.ToArray());
				}
			}
			if (this.comboStadium1.Items.Count != FifaEnvironment.Stadiums.Count)
			{
				for (int j = 0; j < 12; j++)
				{
					this.m_StadiumCombos[j].Items.Clear();
					this.m_StadiumCombos[j].Items.Add("<Auto>");
					this.m_StadiumCombos[j].Items.AddRange(FifaEnvironment.Stadiums.ToArray());
				}
			}
			if (this.comboSchedForce.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboSchedForce.Items.Clear();
				this.comboSchedForce.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
			if (this.comboLanguageKey.Items.Count != CompobjList.s_Descriptions.Count)
			{
				this.comboLanguageKey.Items.Clear();
				this.comboLanguageKey.Items.AddRange(CompobjList.s_Descriptions.ToArray());
			}
			if (this.m_InitTeamCombo[0].Items.Count != FifaEnvironment.Teams.Count + 1)
			{
				for (int k = 0; k < this.m_InitTeamCombo.Length; k++)
				{
					this.m_InitTeamCombo[k].Items.Clear();
					this.m_InitTeamCombo[k].Items.Add("<Unknown>");
					this.m_InitTeamCombo[k].Items.AddRange(FifaEnvironment.Teams.ToArray());
				}
			}
			this.m_Competitions = FifaEnvironment.CompetitionObjects;
			this.m_CurrentWorld = this.m_Competitions.World;
			this.numericBall.Maximum = FifaEnvironment.FifaDb.Table[TI.teamballs].TableDescriptor.MaxValues[FI.teamballs_ballid];
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00082921 File Offset: 0x00080B21
		private void CompetitionsForm_Load(object sender, EventArgs e)
		{
			this.m_IsLoaded = true;
			this.Preset();
			this.LoadCompetitions();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00082936 File Offset: 0x00080B36
		public void ReloadCompetitions()
		{
			this.Preset();
			this.CompetitionToPanel();
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00082944 File Offset: 0x00080B44
		public void ReloadTrophy(Trophy trophy)
		{
			this.m_CurrentTrophy = null;
			this.LoadTrophy(trophy);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00082954 File Offset: 0x00080B54
		public void WorldStructureToPanel()
		{
			this.treeWorld.Nodes.Clear();
			TreeNode treeNode = this.treeWorld.Nodes.Add(this.m_CurrentWorld.ToString());
			treeNode.Tag = this.m_CurrentWorld;
			treeNode.ForeColor = Color.Black;
			foreach (object obj in this.m_CurrentWorld.Trophies)
			{
				Trophy trophy = (Trophy)obj;
				TreeNode treeNode2 = treeNode.Nodes.Add(trophy.ToString());
				treeNode2.Tag = trophy;
				treeNode2.ForeColor = Color.DarkGreen;
				foreach (object obj2 in trophy.Stages)
				{
					Stage stage = (Stage)obj2;
					TreeNode treeNode3 = treeNode2.Nodes.Add(stage.ToString());
					treeNode3.Tag = stage;
					treeNode3.ForeColor = Color.Magenta;
					foreach (object obj3 in stage.Groups)
					{
						Group group = (Group)obj3;
						TreeNode treeNode4 = treeNode3.Nodes.Add(group.ToString());
						treeNode4.Tag = group;
						treeNode4.ForeColor = Color.Brown;
					}
				}
			}
			foreach (object obj4 in this.m_CurrentWorld.Confederations)
			{
				Confederation confederation = (Confederation)obj4;
				TreeNode treeNode5 = treeNode.Nodes.Add(confederation.ToString());
				treeNode5.Tag = confederation;
				treeNode5.ForeColor = Color.Red;
				foreach (object obj5 in confederation.Trophies)
				{
					Trophy trophy2 = (Trophy)obj5;
					TreeNode treeNode6 = treeNode5.Nodes.Add(trophy2.ToString());
					treeNode6.Tag = trophy2;
					treeNode6.ForeColor = Color.DarkGreen;
					foreach (object obj6 in trophy2.Stages)
					{
						Stage stage2 = (Stage)obj6;
						TreeNode treeNode7 = treeNode6.Nodes.Add(stage2.ToString());
						treeNode7.Tag = stage2;
						treeNode7.ForeColor = Color.Magenta;
						foreach (object obj7 in stage2.Groups)
						{
							Group group2 = (Group)obj7;
							TreeNode treeNode8 = treeNode7.Nodes.Add(group2.ToString());
							treeNode8.Tag = group2;
							treeNode8.ForeColor = Color.Brown;
							foreach (object obj8 in group2.Groups)
							{
								Group group3 = (Group)obj8;
								TreeNode treeNode9 = treeNode8.Nodes.Add(group3.ToString());
								treeNode9.Tag = group3;
								treeNode9.ForeColor = Color.Brown;
							}
						}
					}
				}
				foreach (object obj9 in confederation.Nations)
				{
					Nation nation = (Nation)obj9;
					TreeNode treeNode10 = treeNode5.Nodes.Add(nation.ToString());
					treeNode10.Tag = nation;
					treeNode10.ForeColor = Color.Blue;
					foreach (object obj10 in nation.Trophies)
					{
						Trophy trophy3 = (Trophy)obj10;
						TreeNode treeNode11 = treeNode10.Nodes.Add(trophy3.ToString());
						treeNode11.Tag = trophy3;
						treeNode11.ForeColor = Color.DarkGreen;
						foreach (object obj11 in trophy3.Stages)
						{
							Stage stage3 = (Stage)obj11;
							TreeNode treeNode12 = treeNode11.Nodes.Add(stage3.ToString());
							treeNode12.Tag = stage3;
							treeNode12.ForeColor = Color.Magenta;
							foreach (object obj12 in stage3.Groups)
							{
								Group group4 = (Group)obj12;
								TreeNode treeNode13 = treeNode12.Nodes.Add(group4.ToString());
								treeNode13.Tag = group4;
								treeNode13.ForeColor = Color.Brown;
								foreach (object obj13 in group4.Groups)
								{
									Group group5 = (Group)obj13;
									TreeNode treeNode14 = treeNode13.Nodes.Add(group5.ToString());
									treeNode14.Tag = group5;
									treeNode14.ForeColor = Color.Brown;
								}
							}
						}
					}
				}
			}
			this.treeWorld.SelectedNode = this.treeWorld.Nodes[0];
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00083068 File Offset: 0x00081268
		public void WorldToPanel()
		{
			this.panelCompObj.Enabled = true;
			this.textUniqueId.Text = this.m_CurrentWorld.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentWorld.TypeString;
			this.textLanguageKey.Text = this.m_CurrentWorld.Description;
			this.textLanguageName.Text = this.m_CurrentWorld.Description;
			this.textFourCharName.Enabled = false;
			this.textLanguageKey.Enabled = false;
			this.textLanguageName.Enabled = false;
			this.comboLanguageKey.Visible = false;
			this.numericStartYear.Value = this.m_CurrentWorld.Settings.m_schedule_year_start;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00083134 File Offset: 0x00081334
		public void ConfederationToPanel()
		{
			if (this.m_CurrentConfederation == null)
			{
				this.panelCompObj.Enabled = false;
				this.groupConfederation.Visible = false;
				return;
			}
			this.m_Locked = true;
			this.groupConfederation.Visible = true;
			this.panelCompObj.Enabled = true;
			this.textUniqueId.Text = this.m_CurrentConfederation.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentConfederation.TypeString;
			this.textLanguageKey.Text = this.m_CurrentConfederation.Description;
			this.textLanguageName.Text = string.Empty;
			this.textFourCharName.Enabled = false;
			this.textLanguageKey.Enabled = false;
			this.textLanguageName.Enabled = false;
			this.comboLanguageKey.Visible = false;
			this.groupConfederation.Text = "Confederation: " + this.m_CurrentConfederation.ToString();
			bool flag;
			this.comboConfederationStartingMonth.Text = this.m_CurrentConfederation.Settings.GetProperty("schedule_seasonstartmonth", 0, out flag);
			this.m_Locked = false;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00083258 File Offset: 0x00081458
		public void NationToPanel()
		{
			this.m_Locked = true;
			if (this.m_CurrentNation == null)
			{
				this.panelCompObj.Enabled = false;
				this.groupNation.Visible = false;
				return;
			}
			this.groupNation.Visible = true;
			this.panelCompObj.Enabled = true;
			this.textUniqueId.Text = this.m_CurrentNation.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentNation.TypeString;
			this.textLanguageKey.Text = this.m_CurrentNation.Description;
			if (this.m_CurrentNation.Country != null)
			{
				this.textLanguageName.Text = this.m_CurrentNation.Country.LanguageName;
			}
			else
			{
				this.textLanguageName.Text = null;
			}
			this.textFourCharName.Enabled = true;
			this.textLanguageKey.Enabled = false;
			this.textLanguageName.Enabled = false;
			this.comboLanguageKey.Visible = false;
			this.groupNation.Text = "Nation: " + this.m_CurrentNation.ToString();
			this.comboCountry.SelectedItem = this.m_CurrentNation.Country;
			if (this.m_CurrentNation.Country == null)
			{
				this.comboCountry.Text = string.Empty;
			}
			this.comboNationStartMonth.Visible = true;
			bool flag;
			this.comboNationStartMonth.Text = this.m_CurrentNation.Settings.GetProperty("schedule_seasonstartmonth", 0, out flag);
			this.numericNationYellowsStored.Visible = true;
			int num = Convert.ToInt32(this.m_CurrentNation.Settings.GetProperty("rule_numyellowstored", 0, out flag));
			if (num < (int)this.numericNationYellowsStored.Minimum)
			{
				num = (int)this.numericNationYellowsStored.Minimum;
				this.m_CurrentNation.Settings.SetProperty("rule_numyellowstored", 0, num.ToString());
			}
			this.numericNationYellowsStored.Value = Convert.ToInt32(this.m_CurrentNation.Settings.GetProperty("rule_numyellowstored", 0, out flag));
			flag = this.m_CurrentNation.Settings.m_StandingsSort >= 0;
			this.comboNationStandingsRules.Visible = flag;
			if (flag)
			{
				this.comboNationStandingsRules.SelectedIndex = this.m_CurrentNation.Settings.m_StandingsSort;
			}
			this.checkNationStandingsRules.Checked = flag;
			int i = 0;
			while (i < 12)
			{
				this.m_ClearProb[i].Value = this.m_CurrentNation.ClearProb[i];
				this.m_HazyProb[i].Value = this.m_CurrentNation.HazyProb[i];
				this.m_CloudyProb[i].Value = this.m_CurrentNation.CloudyProb[i];
				this.m_OvercastProb[i].Value = this.m_CurrentNation.OvercastProb[i];
				this.m_FoggyProb[i].Value = this.m_CurrentNation.FoggyProb[i];
				this.m_RainProb[i].Value = this.m_CurrentNation.RainProb[i];
				this.m_ShowersProb[i].Value = this.m_CurrentNation.ShowersProb[i];
				this.m_FlurriesProb[i].Value = this.m_CurrentNation.FlurriesProb[i];
				this.m_SnowProb[i].Value = this.m_CurrentNation.SnowProb[i];
				int num2 = this.m_CurrentNation.SunsetTime[i];
				if (num2 <= 1800)
				{
					if (num2 <= 1630)
					{
						if (num2 == 1600)
						{
							goto IL_0417;
						}
						if (num2 != 1630)
						{
							goto IL_0417;
						}
						this.m_SunsetTime[i].SelectedIndex = 1;
					}
					else if (num2 != 1700)
					{
						if (num2 != 1730)
						{
							if (num2 != 1800)
							{
								goto IL_0417;
							}
							this.m_SunsetTime[i].SelectedIndex = 4;
						}
						else
						{
							this.m_SunsetTime[i].SelectedIndex = 3;
						}
					}
					else
					{
						this.m_SunsetTime[i].SelectedIndex = 2;
					}
				}
				else if (num2 <= 1930)
				{
					if (num2 != 1830)
					{
						if (num2 != 1900)
						{
							if (num2 != 1930)
							{
								goto IL_0417;
							}
							this.m_SunsetTime[i].SelectedIndex = 7;
						}
						else
						{
							this.m_SunsetTime[i].SelectedIndex = 6;
						}
					}
					else
					{
						this.m_SunsetTime[i].SelectedIndex = 5;
					}
				}
				else if (num2 != 2000)
				{
					if (num2 != 2030)
					{
						if (num2 != 2100)
						{
							goto IL_0417;
						}
						this.m_SunsetTime[i].SelectedIndex = 10;
					}
					else
					{
						this.m_SunsetTime[i].SelectedIndex = 9;
					}
				}
				else
				{
					this.m_SunsetTime[i].SelectedIndex = 8;
				}
				IL_04D0:
				num2 = this.m_CurrentNation.DarkTime[i];
				if (num2 <= 1800)
				{
					if (num2 <= 1630)
					{
						if (num2 != 1600)
						{
							if (num2 == 1630)
							{
								this.m_NightTime[i].SelectedIndex = 1;
							}
						}
						else
						{
							this.m_NightTime[i].SelectedIndex = 0;
						}
					}
					else if (num2 != 1700)
					{
						if (num2 != 1730)
						{
							if (num2 == 1800)
							{
								this.m_NightTime[i].SelectedIndex = 4;
							}
						}
						else
						{
							this.m_NightTime[i].SelectedIndex = 3;
						}
					}
					else
					{
						this.m_NightTime[i].SelectedIndex = 2;
					}
				}
				else if (num2 <= 1930)
				{
					if (num2 != 1830)
					{
						if (num2 != 1900)
						{
							if (num2 == 1930)
							{
								this.m_NightTime[i].SelectedIndex = 7;
							}
						}
						else
						{
							this.m_NightTime[i].SelectedIndex = 6;
						}
					}
					else
					{
						this.m_NightTime[i].SelectedIndex = 5;
					}
				}
				else if (num2 != 2000)
				{
					if (num2 != 2030)
					{
						if (num2 == 2100)
						{
							this.m_NightTime[i].SelectedIndex = 10;
						}
					}
					else
					{
						this.m_NightTime[i].SelectedIndex = 9;
					}
				}
				else
				{
					this.m_NightTime[i].SelectedIndex = 8;
				}
				i++;
				continue;
				IL_0417:
				this.m_SunsetTime[i].SelectedIndex = 0;
				goto IL_04D0;
			}
			this.m_Locked = false;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000838B4 File Offset: 0x00081AB4
		public void StageToPanel()
		{
			if (this.m_CurrentStage == null)
			{
				this.panelCompObj.Enabled = false;
				this.groupStage.Visible = false;
				return;
			}
			this.m_Locked = true;
			this.groupStage.Visible = true;
			this.panelCompObj.Enabled = true;
			this.textUniqueId.Text = this.m_CurrentStage.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentStage.TypeString;
			this.textLanguageKey.Text = this.m_CurrentStage.Description;
			this.textLanguageName.Text = this.m_CurrentStage.GetLanguageName();
			this.comboLanguageKey.SelectedItem = this.m_CurrentStage.Description;
			this.textFourCharName.Enabled = true;
			this.textLanguageKey.Enabled = true;
			this.textLanguageName.Enabled = true;
			this.comboLanguageKey.Visible = true;
			this.comboStageType.Text = this.m_CurrentStage.Settings.m_match_stagetype;
			bool flag = this.m_CurrentStage.Settings.m_StandingsSort >= 0;
			this.comboStageStandingRules.Visible = flag;
			if (flag)
			{
				this.comboStageStandingRules.SelectedIndex = this.m_CurrentStage.Settings.m_StandingsSort;
			}
			this.checkStageStandingsRules.Checked = flag;
			if (this.m_CurrentStage.Settings.Advance_standingskeep != -1)
			{
				this.numericStandingKeep.Value = this.m_CurrentStage.Settings.Advance_standingskeep;
			}
			this.checkStandingKeep.Checked = this.m_CurrentStage.Settings.Advance_standingskeep != -1;
			this.numericStandingKeep.Visible = this.checkStandingKeep.Checked;
			if (this.m_CurrentStage.Settings.Advance_standingsrank != -1)
			{
				this.numericStandingsRank.Value = this.m_CurrentStage.Settings.Advance_standingsrank;
			}
			this.checkStandingsRank.Checked = this.m_CurrentStage.Settings.Advance_standingsrank != -1;
			this.numericStandingsRank.Visible = this.checkStandingsRank.Checked;
			if (this.m_CurrentStage.Settings.m_match_stagetype != "SETUP")
			{
				this.groupSetupStage.Visible = false;
				this.groupPlayStage.Visible = true;
				this.comboMatchSituation.Text = this.m_CurrentStage.Settings.m_match_matchsituation;
				this.checkMatchReplay.Checked = this.m_CurrentStage.Settings.m_schedule_matchreplay != -1;
				this.numericPrizeMoney.Value = this.m_CurrentStage.Settings.m_info_prize_money;
				this.numericMoneyDrop.Value = this.m_CurrentStage.Settings.m_info_prize_money_drop;
				this.checkCanUseFancards.Checked = this.m_CurrentStage.Settings.m_match_canusefancards == "on";
				this.checkMaxteamsgroup.Checked = this.m_CurrentStage.Settings.m_advance_maxteamsgroup != -1;
				this.numericStageRef.Visible = this.checkMaxteamsgroup.Checked;
				this.numericStageRef.Value = this.m_CurrentStage.Settings.Advance_maxteamsstageref;
				this.checkMaxteamsassoc.Checked = this.m_CurrentStage.Settings.m_advance_maxteamsassoc != -1;
				this.checkClausuraSchedule.Checked = this.m_CurrentStage.Settings.m_schedule_reversed != -1;
				this.checkRandomDrawEvent.Checked = this.m_CurrentStage.Settings.m_advance_random_draw_event != -1;
				bool flag2 = this.m_CurrentStage.Settings.m_EndRuleKo1Leg != -1;
				this.comboSpecialKo1Rule.Visible = flag2;
				if (flag2)
				{
					this.comboSpecialKo1Rule.SelectedIndex = this.m_CurrentStage.Settings.m_EndRuleKo1Leg;
				}
				this.checkSpecialKo1Rule.Checked = flag2;
				flag2 = this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 != -1;
				this.comboSpecialKo2Rule.Visible = flag2;
				if (flag2)
				{
					this.comboSpecialKo2Rule.SelectedIndex = this.m_CurrentStage.Settings.m_EndRuleKo2Leg2;
				}
				this.checkSpecialKo2Rule.Checked = flag2;
				this.numericRegularSeason.Visible = this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 == 3;
				if (this.numericRegularSeason.Visible)
				{
					this.numericRegularSeason.Value = this.m_CurrentStage.Settings.Standings_checkrank;
				}
				for (int i = 0; i < 12; i++)
				{
					Stadium stadium = null;
					if (this.m_CurrentStage.Settings.m_match_stadium != null && this.m_CurrentStage.Settings.m_match_stadium[i] > 0)
					{
						stadium = (Stadium)FifaEnvironment.Stadiums.SearchId(this.m_CurrentStage.Settings.m_match_stadium[i]);
						if (stadium != null)
						{
							this.m_StadiumCombos[i].SelectedItem = stadium;
						}
					}
					if (stadium == null)
					{
						this.m_StadiumCombos[i].SelectedIndex = 0;
					}
				}
				this.treeStageSchedule.Nodes.Clear();
				this.groupStageScheduleDetails.Visible = false;
				this.buttonStageAddTime.Enabled = false;
				this.buttonStageRemoveTime.Enabled = false;
				this.buttonDeleteStageLeg.Enabled = false;
				for (int j = 1; j < 46; j++)
				{
					Schedule[] legSchedule = this.m_CurrentStage.GetLegSchedule(j);
					if (legSchedule == null)
					{
						break;
					}
					TreeNode treeNode = this.treeStageSchedule.Nodes.Add("Leg " + j.ToString());
					treeNode.ForeColor = Color.DarkGreen;
					for (int k = 0; k < legSchedule.Length; k++)
					{
						treeNode.Nodes.Add(legSchedule[k].Date.ToString("f")).Tag = legSchedule[k];
					}
				}
			}
			else
			{
				this.groupSetupStage.Visible = true;
				this.groupPlayStage.Visible = false;
				this.checkRandomDraw.Checked = this.m_CurrentStage.Settings.m_advance_randomdraw != -1;
				this.checkCalccompavgs.Checked = this.m_CurrentStage.Settings.m_advance_calccompavgs != -1;
				for (int l = 0; l < 4; l++)
				{
					Team team = null;
					if (this.m_CurrentStage.Settings.m_info_special_team_id[l] != 0)
					{
						team = (Team)FifaEnvironment.Teams.SearchId(this.m_CurrentStage.Settings.m_info_special_team_id[l]);
						if (team != null)
						{
							this.m_SpecialTeamCombos[l].SelectedItem = team;
						}
					}
					if (team == null)
					{
						this.m_SpecialTeamCombos[l].SelectedIndex = 0;
					}
				}
			}
			this.checkKeepPointsPercentage.Checked = this.m_CurrentStage.Settings.Advance_pointskeep != -1;
			this.numericKeepPointsPercentage.Visible = this.checkKeepPointsPercentage.Checked;
			this.numericKeepPointsStageRef.Visible = this.checkKeepPointsPercentage.Checked;
			if (this.m_CurrentStage.Settings.m_advance_pointskeeppercentage != -1)
			{
				this.numericKeepPointsPercentage.Value = this.m_CurrentStage.Settings.m_advance_pointskeeppercentage;
			}
			if (this.m_CurrentStage.Settings.Advance_pointskeep != -1)
			{
				this.numericKeepPointsStageRef.Value = this.m_CurrentStage.Settings.Advance_pointskeep;
			}
			this.groupLeaguetasks.Visible = this.m_CurrentStage.Settings.m_match_matchsituation == "LEAGUE";
			if (this.m_CurrentStage.Settings.m_match_matchsituation == "LEAGUE")
			{
				Task task = this.m_CurrentStage.SearchTask("start", "ClearLeagueStats", -1, -1, -1);
				League league = null;
				this.checkClearLeagueStats.Checked = task != null;
				if (task != null)
				{
					league = task.League;
				}
				task = this.m_CurrentStage.SearchTask("end", "UpdateLeagueStats", -1, -1, -1);
				this.checkUpdateLeagueStats.Checked = task != null;
				if (task != null)
				{
					league = task.League;
				}
				task = this.m_CurrentStage.SearchTask("end", "UpdateLeagueTable", -1, -1, -1);
				this.checkUpdateLeagueTable.Checked = task != null;
				if (task != null)
				{
					league = task.League;
				}
				if (league != null)
				{
					this.comboLeagueStats.SelectedItem = league;
				}
				this.comboLeagueStats.Visible = this.checkClearLeagueStats.Checked || this.checkUpdateLeagueStats.Checked || this.checkUpdateLeagueTable.Checked;
			}
			this.m_Locked = false;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00084178 File Offset: 0x00082378
		public void GroupToPanel()
		{
			if (this.m_CurrentGroup == null)
			{
				this.panelCompObj.Enabled = false;
				this.groupGroup.Visible = false;
				return;
			}
			this.m_Locked = true;
			this.groupGroup.Visible = true;
			this.panelCompObj.Enabled = true;
			this.textUniqueId.Text = this.m_CurrentGroup.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentGroup.TypeString;
			this.textLanguageKey.Text = this.m_CurrentGroup.Description;
			this.textLanguageName.Text = this.m_CurrentGroup.LanguageName;
			this.textFourCharName.Enabled = true;
			this.textLanguageKey.Enabled = true;
			this.textLanguageName.Enabled = true;
			this.comboLanguageKey.Visible = false;
			this.numericNTeams.Value = this.m_CurrentGroup.Ranks.Count - 1;
			Stage parentStage = this.m_CurrentGroup.ParentStage;
			Trophy trophy = parentStage.Trophy;
			int i = 0;
			if (parentStage.TypeString == "S1")
			{
				this.panelQualificationRules.Visible = true;
				this.panelAdvancement.Visible = false;
				this.groupRules.Text = "Qualification Rules";
				for (int j = 0; j < this.m_CurrentGroup.m_NStartTasks; j++)
				{
					this.m_QRLabels[i].Text = this.m_CurrentGroup.m_StartTask[j].ToString();
					this.m_QRLabels[i].Tag = this.m_CurrentGroup.m_StartTask[j];
					this.m_QRLabels[i].Enabled = true;
					i++;
				}
				while (i < this.m_QRLabels.Length)
				{
					this.m_QRLabels[i].Enabled = false;
					this.m_QRLabels[i].Text = string.Empty;
					i++;
				}
			}
			else
			{
				this.panelQualificationRules.Visible = false;
				this.panelAdvancement.Visible = true;
				this.groupRules.Text = "Advancement Rules";
				for (int k = 1; k < this.m_CurrentGroup.Ranks.Count; k++)
				{
					Rank rank = (Rank)this.m_CurrentGroup.Ranks[k];
					this.m_AdvanceLabels[k - 1].Text = rank.GetFromRankString();
					this.m_AdvanceLabels[k - 1].Visible = true;
					this.m_AdvanceLabels[k - 1].Tag = rank;
				}
				for (int l = this.m_CurrentGroup.Ranks.Count - 1; l < this.m_AdvanceLabels.Length; l++)
				{
					this.m_AdvanceLabels[l].Visible = false;
				}
			}
			if (parentStage.Settings.m_match_stagetype == "LEAGUE")
			{
				this.groupInfoColors.Visible = true;
				this.checkInfoColorChamp.Checked = this.m_CurrentGroup.Settings.m_info_color_slot_champ == 1;
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotChampCup(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorChampions.Checked = false;
					this.numericColorChampionsMin.Visible = false;
					this.numericColorChampionsMax.Visible = false;
				}
				else
				{
					this.checkInfoColorChampions.Checked = true;
					this.numericColorChampionsMin.Visible = true;
					this.numericColorChampionsMax.Visible = true;
					this.numericColorChampionsMin.Value = num;
					this.numericColorChampionsMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotEuroLeague(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorEuropa.Checked = false;
					this.numericColorEuropaMin.Visible = false;
					this.numericColorEuropaMax.Visible = false;
				}
				else
				{
					this.checkInfoColorEuropa.Checked = true;
					this.numericColorEuropaMin.Visible = true;
					this.numericColorEuropaMax.Visible = true;
					this.numericColorEuropaMin.Value = num;
					this.numericColorEuropaMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotReleg(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorRelegation.Checked = false;
					this.numericColorRelegationMin.Visible = false;
					this.numericColorRelegationMax.Visible = false;
				}
				else
				{
					this.checkInfoColorRelegation.Checked = true;
					this.numericColorRelegationMin.Visible = true;
					this.numericColorRelegationMax.Visible = true;
					this.numericColorRelegationMin.Value = num;
					this.numericColorRelegationMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotRelegPoss(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorPossibleRelegation.Checked = false;
					this.numericColorPossibleRelegationMin.Visible = false;
					this.numericColorPossibleRelegationMax.Visible = false;
				}
				else
				{
					this.checkInfoColorPossibleRelegation.Checked = true;
					this.numericColorPossibleRelegationMin.Visible = true;
					this.numericColorPossibleRelegationMax.Visible = true;
					this.numericColorPossibleRelegationMin.Value = num;
					this.numericColorPossibleRelegationMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotPromo(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorPromotion.Checked = false;
					this.numericColorPromotionMin.Visible = false;
					this.numericColorPromotionMax.Visible = false;
				}
				else
				{
					this.checkInfoColorPromotion.Checked = true;
					this.numericColorPromotionMin.Visible = true;
					this.numericColorPromotionMax.Visible = true;
					this.numericColorPromotionMin.Value = num;
					this.numericColorPromotionMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotPromoPoss(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorPossiblePromotion.Checked = false;
					this.numericColorPossiblePromotionMin.Visible = false;
					this.numericColorPossiblePromotionMax.Visible = false;
				}
				else
				{
					this.checkInfoColorPossiblePromotion.Checked = true;
					this.numericColorPossiblePromotionMin.Visible = true;
					this.numericColorPossiblePromotionMax.Visible = true;
					this.numericColorPossiblePromotionMin.Value = num;
					this.numericColorPossiblePromotionMax.Value = num2;
				}
				this.m_CurrentGroup.Settings.GetInfoColorSlotAdvGroup(out num, out num2);
				if (num == -1 || num2 == -1)
				{
					this.checkInfoColorAdvance.Checked = false;
					this.numericColorAdvanceMin.Visible = false;
					this.numericColorAdvanceMax.Visible = false;
				}
				else
				{
					this.checkInfoColorAdvance.Checked = true;
					this.numericColorAdvanceMin.Visible = true;
					this.numericColorAdvanceMax.Visible = true;
					this.numericColorAdvanceMin.Value = num;
					this.numericColorAdvanceMax.Value = num2;
				}
			}
			else
			{
				this.groupInfoColors.Visible = false;
			}
			if (parentStage.Settings.m_match_stagetype == "SETUP")
			{
				this.groupPlayGroup.Visible = false;
				this.groupSlots.Visible = false;
				this.groupGroupScheduke.Visible = false;
			}
			else
			{
				this.groupPlayGroup.Visible = true;
				this.groupGroupScheduke.Visible = true;
				if (this.m_CurrentGroup.Settings.m_num_games <= 0)
				{
					this.m_CurrentGroup.Settings.m_num_games = 1;
				}
				this.numericNumGames.Value = this.m_CurrentGroup.Settings.m_num_games;
				this.treeGroupSchedule.Nodes.Clear();
				this.groupGroupScheduleDetails.Visible = false;
				this.buttonGroupAddTime.Enabled = false;
				this.buttonGroupRemoveTime.Enabled = false;
				this.buttonRemoveGroupLeg.Enabled = false;
				for (int m = 1; m < 46; m++)
				{
					Schedule[] legSchedule = this.m_CurrentGroup.GetLegSchedule(m);
					if (legSchedule != null)
					{
						TreeNode treeNode = this.treeGroupSchedule.Nodes.Add("Leg " + m.ToString());
						treeNode.ForeColor = Color.DarkGreen;
						for (int n = 0; n < legSchedule.Length; n++)
						{
							treeNode.Nodes.Add(legSchedule[n].Date.ToString("f")).Tag = legSchedule[n];
						}
					}
				}
				this.groupSlots.Visible = true;
				this.checkInfoChamp.Checked = this.m_CurrentGroup.Settings.m_info_slot_champ == 1;
				int num3;
				int num4;
				this.m_CurrentGroup.Settings.GetInfoSlotReleg(out num3, out num4);
				if (num3 == -1 || num4 == -1)
				{
					this.checkInfoRelegation.Checked = false;
					this.numericRelegationMin.Visible = false;
					this.numericRelegationMax.Visible = false;
				}
				else
				{
					this.checkInfoRelegation.Checked = true;
					this.numericRelegationMin.Visible = true;
					this.numericRelegationMax.Visible = true;
					this.numericRelegationMin.Value = num3;
					this.numericRelegationMax.Value = num4;
				}
				this.m_CurrentGroup.Settings.GetInfoSlotRelegPoss(out num3, out num4);
				if (num3 == -1 || num4 == -1)
				{
					this.checkInfoPossibleRelegation.Checked = false;
					this.numericPossibleRelegationMin.Visible = false;
					this.numericPossibleRelegationMax.Visible = false;
				}
				else
				{
					this.checkInfoPossibleRelegation.Checked = true;
					this.numericPossibleRelegationMin.Visible = true;
					this.numericPossibleRelegationMax.Visible = true;
					this.numericPossibleRelegationMin.Value = num3;
					this.numericPossibleRelegationMax.Value = num4;
				}
				this.m_CurrentGroup.Settings.GetInfoSlotPromo(out num3, out num4);
				if (num3 == -1 || num4 == -1)
				{
					this.checkInfoPromotion.Checked = false;
					this.numericPromotionMin.Visible = false;
					this.numericPromotionMax.Visible = false;
				}
				else
				{
					this.checkInfoPromotion.Checked = true;
					this.numericPromotionMin.Visible = true;
					this.numericPromotionMax.Visible = true;
					this.numericPromotionMin.Value = num3;
					this.numericPromotionMax.Value = num4;
				}
				this.m_CurrentGroup.Settings.GetInfoSlotPromoPoss(out num3, out num4);
				if (num3 == -1 || num4 == -1)
				{
					this.checkInfoPossiblePromotion.Checked = false;
					this.numericPossiblePromotionMin.Visible = false;
					this.numericPossiblePromotionMax.Visible = false;
				}
				else
				{
					this.checkInfoPossiblePromotion.Checked = true;
					this.numericPossiblePromotionMin.Visible = true;
					this.numericPossiblePromotionMax.Visible = true;
					this.numericPossiblePromotionMin.Value = num3;
					this.numericPossiblePromotionMax.Value = num4;
				}
			}
			this.m_Locked = false;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00084C30 File Offset: 0x00082E30
		public void TrophyStructureToPanel()
		{
			if (this.m_CurrentTrophy == null)
			{
				this.groupTrophy.Visible = false;
				return;
			}
			this.groupTrophy.Visible = true;
			this.groupTrophy.Text = this.m_CurrentTrophy.ShortName;
			this.textTrophyLongName.Text = this.m_CurrentTrophy.LongName;
			this.textTrophyShortName.Text = this.m_CurrentTrophy.ShortName;
			this.numericAssetId.Value = this.m_CurrentTrophy.Settings.m_asset_id;
			this.numericBall.Value = this.m_CurrentTrophy.ballid;
			if (this.m_CurrentTrophy.ballid >= 0)
			{
				this.pictureBall.BackgroundImage = Ball.GetBallPicture(this.m_CurrentTrophy.ballid);
			}
			else
			{
				this.pictureBall.BackgroundImage = null;
			}
			this.comboCompetitionType.SelectedItem = this.m_CurrentTrophy.Settings.m_comp_type;
			this.checkScheduleConflicts.Checked = this.m_CurrentTrophy.Settings.m_schedule_checkconflict == 1;
			bool flag = this.m_CurrentTrophy.Settings.TrophyForcecomp != null;
			this.comboSchedForce.Visible = flag;
			if (flag)
			{
				this.comboSchedForce.SelectedItem = this.m_CurrentTrophy.Settings.TrophyForcecomp;
			}
			this.checkForceSchedule.Checked = flag;
			this.checkScheduleUseDates.Checked = this.m_CurrentTrophy.Settings.m_schedule_use_dates_comp != -1;
			flag = this.m_CurrentTrophy.Settings.m_match_matchimportance != -1;
			if (!flag)
			{
				this.m_CurrentTrophy.Settings.m_match_matchimportance = 25;
			}
			this.numericImportance.Value = this.m_CurrentTrophy.Settings.m_match_matchimportance;
			flag = this.m_CurrentTrophy.Settings.LeaguePromo != null;
			this.comboPromotionLeague.Visible = flag;
			if (flag)
			{
				this.comboPromotionLeague.SelectedItem = this.m_CurrentTrophy.Settings.LeaguePromo;
			}
			this.checkPromotionLeague.Checked = flag;
			flag = this.m_CurrentTrophy.Settings.LeagueReleg != null;
			this.comboRelegationLeague.Visible = flag;
			if (flag)
			{
				this.comboRelegationLeague.SelectedItem = this.m_CurrentTrophy.Settings.LeagueReleg;
			}
			this.checkRelegationLeague.Checked = flag;
			flag = this.m_CurrentTrophy.Settings.m_rule_numsubsbench != -1;
			this.radioBench5Players.Checked = flag;
			this.radioBench7Players.Checked = !flag;
			flag = this.m_CurrentTrophy.Settings.m_StandingsSort >= 0;
			this.comboTrophyStandingRules.Visible = flag;
			if (flag)
			{
				this.comboTrophyStandingRules.SelectedIndex = this.m_CurrentTrophy.Settings.m_StandingsSort;
			}
			this.checkTrophyStandingsRules.Checked = flag;
			if (this.m_CurrentTrophy.Settings.m_comp_type == "INTERCUP" || this.m_CurrentTrophy.Settings.m_comp_type == "INTERQUAL")
			{
				this.groupInternationalschedule.Visible = true;
				this.numericInternationalFirstYear.Value = this.m_CurrentTrophy.Settings.m_schedule_year_start;
				this.numericInternationalPeriodicity.Value = this.m_CurrentTrophy.Settings.m_schedule_year_offset;
				this.comboNationStartMonth.Visible = true;
				this.comboTrophyStartMonth.Text = this.m_CurrentTrophy.Settings.GetProperty("schedule_seasonstartmonth", 0, out flag);
				return;
			}
			this.groupInternationalschedule.Visible = false;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00084FD8 File Offset: 0x000831D8
		public void TrophyGraphicsToPanel()
		{
			this.viewer2DTrophy256.CurrentBitmap = this.m_CurrentTrophy.GetTrophy256();
			if (FifaEnvironment.Year == 14)
			{
				this.viewer2DTrophy128.CurrentBitmap = this.m_CurrentTrophy.GetTrophy128();
			}
			else
			{
				this.viewer2DTrophy.CurrentBitmap = this.m_CurrentTrophy.GetTrophy();
			}
			this.multiViewer2DTextures.Bitmaps = this.m_CurrentTrophy.GetTextures();
			this.Show3DTrophy();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0008504E File Offset: 0x0008324E
		public void TrophyPitchDressToPanel()
		{
			if (this.m_CurrentTrophy == null)
			{
				this.viewer2DPitchDressing.CurrentBitmap = null;
				return;
			}
			this.viewer2DPitchDressing.CurrentBitmap = this.m_CurrentTrophy.GetPitchDressing();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0008507B File Offset: 0x0008327B
		public void TrophyRevModToPanel()
		{
			if (this.m_CurrentTrophy == null)
			{
				this.viewer2DTournamentAdboard.CurrentBitmap = null;
				return;
			}
			this.viewer2DTournamentAdboard.CurrentBitmap = this.m_CurrentTrophy.GetAdboard();
			this.LoadRevModBall();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000850B0 File Offset: 0x000832B0
		public void TrophyRankingToPanel()
		{
			this.m_NUpdateTableLabels = 0;
			for (int i = 0; i < 24; i++)
			{
				Task task = this.m_CurrentTrophy.SearchTask("end", "UpdateTable", -1, -1, i + 1);
				if (task == null)
				{
					break;
				}
				this.m_UpdateTableLabels[i].Text = task.ToString();
				this.m_UpdateTableLabels[i].Tag = task;
				this.m_NUpdateTableLabels++;
			}
			this.numericUpdateTableEntries.Value = this.m_NUpdateTableLabels;
			for (int j = 0; j < 24; j++)
			{
				this.m_InitTeamPanel[j].Visible = j < this.m_NUpdateTableLabels;
			}
			for (int k = 0; k < this.m_NUpdateTableLabels; k++)
			{
				InitTeam initTeam = this.m_CurrentTrophy.InitTeamArray[k];
				Team team = null;
				if (initTeam != null)
				{
					team = initTeam.Team;
				}
				if (team != null)
				{
					this.m_InitTeamCombo[k].SelectedItem = initTeam.Team;
				}
				else
				{
					this.m_InitTeamCombo[k].SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000851B4 File Offset: 0x000833B4
		public void TrophyToPanel()
		{
			if (this.m_CurrentTrophy == null)
			{
				this.panelCompObj.Enabled = false;
				this.groupTrophy.Visible = false;
				this.groupGraphics.Visible = false;
				this.groupInitTeams.Visible = false;
				return;
			}
			this.m_Locked = true;
			this.panelCompObj.Enabled = true;
			this.groupTrophy.Visible = true;
			this.groupGraphics.Visible = true;
			this.groupInitTeams.Visible = true;
			this.textUniqueId.Text = this.m_CurrentTrophy.Id.ToString();
			this.textFourCharName.Text = this.m_CurrentTrophy.TypeString;
			this.textLanguageKey.Text = this.m_CurrentTrophy.Description;
			this.textLanguageName.Text = this.m_CurrentTrophy.ShortName;
			this.textFourCharName.Enabled = true;
			this.textLanguageKey.Enabled = false;
			this.textLanguageName.Enabled = false;
			this.comboLanguageKey.Visible = false;
			this.checkLowCelebrationLevel.Checked = this.m_CurrentTrophy.Settings.m_match_celebrationlevel == "LOW";
			if (this.tabTrophy.SelectedIndex == 0)
			{
				this.TrophyStructureToPanel();
			}
			else if (this.tabTrophy.SelectedIndex == 1)
			{
				this.TrophyRankingToPanel();
			}
			else if (this.tabTrophy.SelectedIndex == 2)
			{
				this.TrophyGraphicsToPanel();
			}
			else if (this.tabTrophy.SelectedIndex == 3)
			{
				this.TrophyPitchDressToPanel();
			}
			else if (this.tabTrophy.SelectedIndex == 4)
			{
				this.TrophyRevModToPanel();
			}
			this.m_Locked = false;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00085358 File Offset: 0x00083558
		public void Show3DTrophy()
		{
			if (!this.buttonShow3DModel.Checked)
			{
				this.viewer3D.ShowEmpty();
				return;
			}
			Bitmap[] textures = this.m_CurrentTrophy.GetTextures();
			Bitmap bitmap = null;
			if (textures != null)
			{
				bitmap = GraphicUtil.EmbossBitmap(textures[0], textures[1]);
			}
			Rx3File model = this.m_CurrentTrophy.GetModel();
			if (bitmap == null || model == null)
			{
				this.viewer3D.Clean(1);
				return;
			}
			Rx3IndexArray.TriangleListType = Rx3IndexArray.ETriangleListType.InvertEven;
			this.viewer3D.Clean(model.Rx3VertexArrays.Length);
			for (int i = 0; i < model.Rx3VertexArrays.Length; i++)
			{
				Model3D model3D = new Model3D(model.Rx3IndexArrays[i], model.Rx3VertexArrays[i], bitmap);
				this.viewer3D.SetMesh(i, model3D);
			}
			this.viewer3D.Render();
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00085418 File Offset: 0x00083618
		private void treeWorld_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.treeWorld.SelectedNode == null)
			{
				return;
			}
			this.m_CurrentCompobj = (Compobj)this.treeWorld.SelectedNode.Tag;
			if (!this.m_LockTree)
			{
				this.m_LockTree = true;
				if (this.m_CurrentCompobj.IsGroup())
				{
					this.m_CurrentGroup = (Group)this.treeWorld.SelectedNode.Tag;
					this.m_CurrentStage = this.m_CurrentGroup.ParentStage;
					this.m_CurrentTrophy = this.m_CurrentStage.Trophy;
					this.m_CurrentNation = this.m_CurrentTrophy.Nation;
					if (this.m_CurrentNation != null)
					{
						this.m_CurrentConfederation = this.m_CurrentNation.Confederation;
					}
					else
					{
						this.m_CurrentConfederation = this.m_CurrentTrophy.Confederation;
					}
					if (this.tabCompetitions.SelectedTab == this.pageGroup)
					{
						this.GroupToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageGroup;
					this.treeWorld.Select();
				}
				else if (this.m_CurrentCompobj.IsStage())
				{
					this.m_CurrentStage = (Stage)this.treeWorld.SelectedNode.Tag;
					this.m_CurrentGroup = null;
					this.m_CurrentTrophy = this.m_CurrentStage.Trophy;
					this.m_CurrentNation = this.m_CurrentTrophy.Nation;
					if (this.m_CurrentNation != null)
					{
						this.m_CurrentConfederation = this.m_CurrentNation.Confederation;
					}
					else
					{
						this.m_CurrentConfederation = this.m_CurrentTrophy.Confederation;
					}
					if (this.tabCompetitions.SelectedTab == this.pageStage)
					{
						this.StageToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageStage;
					this.treeWorld.Select();
				}
				else if (this.m_CurrentCompobj.IsTrophy())
				{
					this.m_CurrentTrophy = (Trophy)this.treeWorld.SelectedNode.Tag;
					this.m_CurrentStage = null;
					this.m_CurrentGroup = null;
					this.m_CurrentNation = this.m_CurrentTrophy.Nation;
					if (this.m_CurrentNation != null)
					{
						this.m_CurrentConfederation = this.m_CurrentNation.Confederation;
					}
					else
					{
						this.m_CurrentConfederation = this.m_CurrentTrophy.Confederation;
					}
					if (this.tabCompetitions.SelectedTab == this.pageTrophy)
					{
						this.TrophyToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageTrophy;
					this.treeWorld.Select();
				}
				else if (this.m_CurrentCompobj.IsNation())
				{
					this.m_CurrentNation = (Nation)this.treeWorld.SelectedNode.Tag;
					this.m_CurrentTrophy = null;
					this.m_CurrentStage = null;
					this.m_CurrentGroup = null;
					this.m_CurrentConfederation = this.m_CurrentNation.Confederation;
					if (this.tabCompetitions.SelectedTab == this.pageNation)
					{
						this.NationToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageNation;
					this.treeWorld.Select();
				}
				else if (this.m_CurrentCompobj.IsConfederation())
				{
					this.m_CurrentConfederation = (Confederation)this.treeWorld.SelectedNode.Tag;
					this.m_CurrentNation = null;
					this.m_CurrentTrophy = null;
					this.m_CurrentStage = null;
					this.m_CurrentGroup = null;
					if (this.tabCompetitions.SelectedTab == this.pageConfederation)
					{
						this.ConfederationToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageConfederation;
					this.treeWorld.Select();
				}
				else if (this.m_CurrentCompobj.IsWorld())
				{
					this.m_CurrentConfederation = null;
					this.m_CurrentNation = null;
					this.m_CurrentTrophy = null;
					this.m_CurrentStage = null;
					this.m_CurrentGroup = null;
					if (this.tabCompetitions.SelectedTab == this.pageWorld)
					{
						this.WorldToPanel();
					}
					this.tabCompetitions.SelectedTab = this.pageWorld;
					this.treeWorld.Select();
				}
				this.m_LockTree = false;
			}
			this.EnableToolWorld();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00085803 File Offset: 0x00083A03
		private void comboConfederationStartingMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboConfederationStartingMonth.SelectedItem == null)
			{
				return;
			}
			this.m_CurrentConfederation.Settings.m_schedule_seasonstartmonth = (string)this.comboConfederationStartingMonth.SelectedItem;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0008583C File Offset: 0x00083A3C
		private void comboNationStartMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboNationStartMonth.SelectedItem != null)
			{
				this.m_CurrentNation.Settings.m_schedule_seasonstartmonth = (string)this.comboNationStartMonth.SelectedItem;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00085874 File Offset: 0x00083A74
		private void numericYellowsStored_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentNation.Settings.m_rule_numyellowstored = (int)this.numericNationYellowsStored.Value;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000858A0 File Offset: 0x00083AA0
		private void checkNationStandingsRules_CheckedChanged(object sender, EventArgs e)
		{
			this.comboNationStandingsRules.Visible = this.checkNationStandingsRules.Checked;
			if (this.checkNationStandingsRules.Checked)
			{
				this.m_CurrentNation.Settings.m_StandingsSort = this.comboNationStandingsRules.SelectedIndex;
				return;
			}
			this.m_CurrentNation.Settings.m_StandingsSort = -1;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000858FD File Offset: 0x00083AFD
		private void comboNationStandingsRules_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentNation.Settings.m_StandingsSort = this.comboNationStandingsRules.SelectedIndex;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00085924 File Offset: 0x00083B24
		private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboCountry.SelectedItem != null)
			{
				Country country = (Country)this.comboCountry.SelectedItem;
				if (this.m_CurrentNation.Country != country && country != null)
				{
					this.m_CurrentNation.Country = country;
					this.m_CurrentNation.Description = FifaEnvironment.Language.GetCountryConventionalString(country.Id, Language.ECountryStringType.Full);
					this.NationToPanel();
				}
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00085997 File Offset: 0x00083B97
		private void textTrophyLongName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.LongName = this.textTrophyLongName.Text;
			this.treeWorld.SelectedNode.Text = this.m_CurrentTrophy.ToString();
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000859D4 File Offset: 0x00083BD4
		private void textTrophyShortName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.ShortName = this.textTrophyShortName.Text;
			this.treeWorld.SelectedNode.Text = this.m_CurrentTrophy.ToString();
			this.textLanguageName.Text = this.m_CurrentTrophy.ShortName;
			this.m_CurrentTrophy.SetLanguageName(this.m_CurrentTrophy.ShortName);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00085A48 File Offset: 0x00083C48
		private void buttonGetId_Click(object sender, EventArgs e)
		{
			this.numericAssetId.Value = Trophy.AutoAsset();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00085A60 File Offset: 0x00083C60
		private void numericAssetId_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericAssetId.Value;
			if (num == this.m_CurrentTrophy.Settings.m_asset_id)
			{
				return;
			}
			this.m_Locked = true;
			if (num != 993)
			{
				foreach (object obj in FifaEnvironment.CompetitionObjects)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.IsTrophy() && compobj.Settings.m_asset_id == num)
					{
						FifaEnvironment.UserMessages.ShowMessage(1015);
						this.numericAssetId.Value = this.m_CurrentTrophy.Settings.m_asset_id;
						this.m_Locked = false;
						return;
					}
				}
			}
			this.m_CurrentTrophy.Settings.m_asset_id = num;
			if (num != 993)
			{
				this.m_CurrentTrophy.Description = FifaEnvironment.Language.GetTournamentConventionalString(num, Language.ETournamentStringType.Abbr15);
				this.textLanguageKey.Text = this.m_CurrentTrophy.Description;
				string text = "C" + this.m_CurrentTrophy.Settings.m_asset_id.ToString();
				this.textFourCharName.Text = text;
			}
			this.TrophyGraphicsToPanel();
			this.m_Locked = false;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00085BC4 File Offset: 0x00083DC4
		private void comboCompetitionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentTrophy.Settings.m_comp_type == (string)this.comboCompetitionType.SelectedItem)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_comp_type = (string)this.comboCompetitionType.SelectedItem;
			this.TrophyToPanel();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00085C28 File Offset: 0x00083E28
		private void numericImportance_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_match_matchimportance = (int)this.numericImportance.Value;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00085C54 File Offset: 0x00083E54
		private void comboPromotionLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboPromotionLeague.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboPromotionLeague.SelectedIndex == 0)
			{
				this.m_CurrentTrophy.Settings.LeaguePromo = null;
				return;
			}
			this.m_CurrentTrophy.Settings.LeaguePromo = (League)this.comboPromotionLeague.SelectedItem;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00085CB8 File Offset: 0x00083EB8
		private void comboRelegationLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboRelegationLeague.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboRelegationLeague.SelectedIndex == 0)
			{
				this.m_CurrentTrophy.Settings.LeagueReleg = null;
				return;
			}
			this.m_CurrentTrophy.Settings.LeagueReleg = (League)this.comboRelegationLeague.SelectedItem;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00085D1C File Offset: 0x00083F1C
		private void checkForceSchedule_CheckedChanged(object sender, EventArgs e)
		{
			this.comboSchedForce.Visible = this.checkForceSchedule.Checked;
			if (this.checkForceSchedule.Checked)
			{
				if (this.comboSchedForce.SelectedItem == null)
				{
					this.comboSchedForce.SelectedItem = this.comboSchedForce.Items[0];
				}
				this.m_CurrentTrophy.Settings.TrophyForcecomp = (Trophy)this.comboSchedForce.SelectedItem;
				return;
			}
			this.m_CurrentTrophy.Settings.TrophyForcecomp = null;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00085DA8 File Offset: 0x00083FA8
		private void checkTrophyStandingsRules_CheckedChanged(object sender, EventArgs e)
		{
			this.comboTrophyStandingRules.Visible = this.checkTrophyStandingsRules.Checked;
			if (this.checkTrophyStandingsRules.Checked)
			{
				this.m_CurrentTrophy.Settings.m_StandingsSort = this.comboTrophyStandingRules.SelectedIndex;
				return;
			}
			this.m_CurrentTrophy.Settings.m_StandingsSort = -1;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00085E05 File Offset: 0x00084005
		private void comboTrophyStandingRules_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboTrophyStandingRules.SelectedIndex >= 0)
			{
				this.m_CurrentTrophy.Settings.m_StandingsSort = this.comboTrophyStandingRules.SelectedIndex;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00085E39 File Offset: 0x00084039
		private void comboSchedForce_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboSchedForce.SelectedItem == null)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.TrophyForcecomp = (Trophy)this.comboSchedForce.SelectedItem;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00085E74 File Offset: 0x00084074
		private void checkPromotionLeague_CheckedChanged(object sender, EventArgs e)
		{
			this.comboPromotionLeague.Visible = this.checkPromotionLeague.Checked;
			if (this.checkPromotionLeague.Checked)
			{
				this.m_CurrentTrophy.Settings.LeaguePromo = (League)this.comboPromotionLeague.SelectedItem;
				return;
			}
			this.m_CurrentTrophy.Settings.LeaguePromo = null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00085ED8 File Offset: 0x000840D8
		private void checkRelegationLeague_CheckedChanged(object sender, EventArgs e)
		{
			this.comboRelegationLeague.Visible = this.checkRelegationLeague.Checked;
			if (this.checkRelegationLeague.Checked)
			{
				this.m_CurrentTrophy.Settings.LeagueReleg = (League)this.comboRelegationLeague.SelectedItem;
				return;
			}
			this.m_CurrentTrophy.Settings.LeagueReleg = null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00085F3A File Offset: 0x0008413A
		private void checkScheduleConflicts_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_schedule_checkconflict = (this.checkScheduleConflicts.Checked ? 1 : (-1));
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00085F66 File Offset: 0x00084166
		private void radioBench5Players_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.radioBench5Players.Checked)
			{
				this.m_CurrentTrophy.Settings.m_rule_numsubsbench = 5;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00085F8F File Offset: 0x0008418F
		private void radioBench7Players_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.radioBench7Players.Checked)
			{
				this.m_CurrentTrophy.Settings.m_rule_numsubsbench = -1;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00085FB8 File Offset: 0x000841B8
		private void comboStageType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboStageType.SelectedItem != null)
			{
				this.m_CurrentStage.Settings.m_match_stagetype = (string)this.comboStageType.SelectedItem;
				this.StageToPanel();
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00085FF8 File Offset: 0x000841F8
		private void comboMatchSituation_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboStageType.SelectedItem != null)
			{
				this.m_CurrentStage.Settings.m_match_matchsituation = (string)this.comboMatchSituation.SelectedItem;
				this.m_CurrentStage.Settings.m_schedule_matchreplay = ((this.m_CurrentStage.Settings.m_match_matchsituation == "REPLAY") ? 1 : (-1));
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0008606B File Offset: 0x0008426B
		private void numericPrizeMoney_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_info_prize_money = (int)this.numericPrizeMoney.Value;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00086096 File Offset: 0x00084296
		private void numericMoneyDrop_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_info_prize_money_drop = (int)this.numericMoneyDrop.Value;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000860C1 File Offset: 0x000842C1
		private void numericStartYear_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentWorld.Settings.m_schedule_year_start = (int)this.numericStartYear.Value;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000860EC File Offset: 0x000842EC
		private void numericNumGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentStage.Settings.m_num_games = (int)this.numericNumGames.Value;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0008610E File Offset: 0x0008430E
		private void comboSpecialTeam1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.SetSpecialTeam(0);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00086120 File Offset: 0x00084320
		private void comboSpecialTeam2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.SetSpecialTeam(1);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00086132 File Offset: 0x00084332
		private void comboSpecialTeam3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.SetSpecialTeam(2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00086144 File Offset: 0x00084344
		private void comboSpecialTeam4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.SetSpecialTeam(3);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00086158 File Offset: 0x00084358
		private void SetSpecialTeam(int index)
		{
			if (this.m_SpecialTeamCombos[index].SelectedIndex == 0)
			{
				this.m_CurrentStage.Settings.m_info_special_team_id[index] = -1;
				return;
			}
			Team team = (Team)this.m_SpecialTeamCombos[index].SelectedItem;
			this.m_CurrentStage.Settings.m_info_special_team_id[index] = team.Id;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000861B4 File Offset: 0x000843B4
		private void SetMatchStadium(int index)
		{
			if (this.m_StadiumCombos[index].SelectedIndex == 0)
			{
				if (this.m_CurrentStage.Settings.m_match_stadium != null)
				{
					this.m_CurrentStage.Settings.m_match_stadium[index] = -1;
					return;
				}
			}
			else
			{
				Stadium stadium = (Stadium)this.m_StadiumCombos[index].SelectedItem;
				if (stadium != null && (this.m_CurrentStage.Settings.m_match_stadium == null || this.m_CurrentStage.Settings.m_match_stadium[index] != stadium.Id))
				{
					this.m_CurrentStage.Settings.SetProperty("match_stadium", index, stadium.Id.ToString());
				}
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0008625C File Offset: 0x0008445C
		private void comboStadium1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(0);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00086265 File Offset: 0x00084465
		private void comboStadium2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(1);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0008626E File Offset: 0x0008446E
		private void comboStadium3_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00086277 File Offset: 0x00084477
		private void comboStadium4_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(3);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00086280 File Offset: 0x00084480
		private void comboStadium5_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(4);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00086289 File Offset: 0x00084489
		private void comboStadium6_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(5);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00086292 File Offset: 0x00084492
		private void comboStadium7_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(6);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0008629B File Offset: 0x0008449B
		private void comboStadium8_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(7);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000862A4 File Offset: 0x000844A4
		private void comboStadium9_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(8);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000862AD File Offset: 0x000844AD
		private void comboStadium10_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(9);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000862B7 File Offset: 0x000844B7
		private void comboStadium11_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(10);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000862C1 File Offset: 0x000844C1
		private void comboStadium12_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetMatchStadium(11);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000862CC File Offset: 0x000844CC
		private void checkMaxteamsgroup_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_maxteamsgroup = (this.checkMaxteamsgroup.Checked ? 1 : (-1));
			this.numericStageRef.Visible = this.checkMaxteamsgroup.Checked;
			if (this.m_CurrentStage.Settings.m_advance_maxteamsgroup == -1)
			{
				this.m_CurrentStage.Settings.Advance_maxteamsstageref = -1;
				return;
			}
			this.numericStageRef.Value = this.m_CurrentStage.Settings.Advance_maxteamsstageref;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00086360 File Offset: 0x00084560
		private void checkStandingKeep_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.Advance_standingskeep = (this.checkStandingKeep.Checked ? ((int)this.numericStandingKeep.Value) : (-1));
			this.numericStandingKeep.Visible = this.checkStandingKeep.Checked;
			this.m_CurrentStage.Settings.Advance_standingskeep = (this.checkStandingKeep.Checked ? ((int)this.numericStandingKeep.Value) : (-1));
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000863EC File Offset: 0x000845EC
		private void checkKeepPointsPercentage_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericKeepPointsPercentage.Visible = this.checkKeepPointsPercentage.Checked;
			this.numericKeepPointsStageRef.Visible = this.checkKeepPointsPercentage.Checked;
			if (this.checkKeepPointsPercentage.Checked == (this.m_CurrentStage.Settings.Advance_pointskeep != -1))
			{
				return;
			}
			if (!this.checkKeepPointsPercentage.Checked)
			{
				this.m_CurrentStage.Settings.Advance_pointskeep = -1;
				this.m_CurrentStage.Settings.m_advance_pointskeeppercentage = -1;
				return;
			}
			this.m_CurrentStage.Settings.Advance_pointskeep = this.m_CurrentStage.Id;
			this.m_CurrentStage.Settings.m_advance_pointskeeppercentage = 50;
			this.numericKeepPointsPercentage.Value = 50m;
			this.numericKeepPointsStageRef.Value = this.m_CurrentStage.Id;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000864DC File Offset: 0x000846DC
		private void numericStandingKeep_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStage.Settings.Advance_standingskeep != (int)this.numericStandingKeep.Value)
			{
				this.m_CurrentStage.Settings.Advance_standingskeep = (this.checkStandingKeep.Checked ? ((int)this.numericStandingKeep.Value) : (-1));
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00086544 File Offset: 0x00084744
		private void numericKeepPointsPercentage_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_pointskeeppercentage = (this.checkKeepPointsPercentage.Checked ? ((int)this.numericKeepPointsPercentage.Value) : (-1));
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00086580 File Offset: 0x00084780
		private void checkSpecialKo1Rule_CheckedChanged(object sender, EventArgs e)
		{
			this.comboSpecialKo1Rule.Visible = this.checkSpecialKo1Rule.Checked;
			if (this.checkSpecialKo1Rule.Checked)
			{
				this.m_CurrentStage.Settings.m_EndRuleKo1Leg = this.comboSpecialKo1Rule.SelectedIndex;
				return;
			}
			this.m_CurrentStage.Settings.m_EndRuleKo1Leg = -1;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000865E0 File Offset: 0x000847E0
		private void checkSpecialKo2Rule_CheckedChanged(object sender, EventArgs e)
		{
			this.comboSpecialKo2Rule.Visible = this.checkSpecialKo2Rule.Checked;
			if (this.checkSpecialKo2Rule.Checked)
			{
				this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 = this.comboSpecialKo2Rule.SelectedIndex;
				return;
			}
			this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 = -1;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0008663D File Offset: 0x0008483D
		private void comboSpecialKo1Rule_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboSpecialKo1Rule.SelectedIndex >= 0)
			{
				this.m_CurrentStage.Settings.m_EndRuleKo1Leg = this.comboSpecialKo1Rule.SelectedIndex;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00086674 File Offset: 0x00084874
		private void comboSpecialKo2Rule_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboSpecialKo2Rule.SelectedIndex >= 0)
			{
				this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 = this.comboSpecialKo2Rule.SelectedIndex;
				this.numericRegularSeason.Visible = this.m_CurrentStage.Settings.m_EndRuleKo2Leg2 == 3;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000866D4 File Offset: 0x000848D4
		private void numericRegularSeason_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStage.Settings.Standings_checkrank != (int)this.numericRegularSeason.Value)
			{
				this.m_CurrentStage.Settings.Standings_checkrank = (int)this.numericRegularSeason.Value;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0008672C File Offset: 0x0008492C
		private void checkStandingsRank_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.Advance_standingsrank = (this.checkStandingsRank.Checked ? ((int)this.numericStandingsRank.Value) : (-1));
			this.numericStandingsRank.Visible = this.checkStandingsRank.Checked;
			this.m_CurrentStage.Settings.Advance_standingsrank = (this.checkStandingsRank.Checked ? ((int)this.numericStandingsRank.Value) : (-1));
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000867B8 File Offset: 0x000849B8
		private void numericStandingsRank_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStage.Settings.Advance_standingsrank != (int)this.numericStandingsRank.Value)
			{
				this.m_CurrentStage.Settings.Advance_standingsrank = (this.checkStandingsRank.Checked ? ((int)this.numericStandingsRank.Value) : (-1));
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00086820 File Offset: 0x00084A20
		private void checkInfoColorChamp_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentGroup.Settings.m_info_color_slot_champ = (this.checkInfoColorChamp.Checked ? 1 : (-1));
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0008684C File Offset: 0x00084A4C
		private void numericColorChampionsMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorChampionsMin.Value;
			int num2 = (int)this.numericColorChampionsMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotChampCup(out num3, out num4);
			if (num == num3)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotChampCup(num, num2))
			{
				this.numericColorChampionsMin.Value = num3;
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000868C4 File Offset: 0x00084AC4
		private void numericColorChampionsMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorChampionsMin.Value;
			int num2 = (int)this.numericColorChampionsMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotChampCup(out num3, out num4);
			if (num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotChampCup(num, num2))
			{
				this.numericColorChampionsMax.Value = num4;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0008693C File Offset: 0x00084B3C
		private void numericColorEuropaMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorEuropaMin.Value;
			int num2 = (int)this.numericColorEuropaMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotEuroLeague(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotEuroLeague(num, num2))
			{
				this.numericColorEuropaMin.Value = num3;
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000869B8 File Offset: 0x00084BB8
		private void numericColorEuropaMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorEuropaMin.Value;
			int num2 = (int)this.numericColorEuropaMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotEuroLeague(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotEuroLeague(num, num2))
			{
				this.numericColorEuropaMax.Value = num4;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00086A34 File Offset: 0x00084C34
		private void numericColorPossibleRelegationMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPossibleRelegationMin.Value;
			int num2 = (int)this.numericColorPossibleRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotRelegPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotRelegPoss(num, num2))
			{
				this.numericColorPossibleRelegationMin.Value = num3;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00086AB0 File Offset: 0x00084CB0
		private void numericColorPossibleRelegationMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPossibleRelegationMin.Value;
			int num2 = (int)this.numericColorPossibleRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotRelegPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotRelegPoss(num, num2))
			{
				this.numericColorPossibleRelegationMax.Value = num4;
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00086B2C File Offset: 0x00084D2C
		private void numericColorRelegationMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorRelegationMin.Value;
			int num2 = (int)this.numericColorRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotReleg(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotReleg(num, num2))
			{
				this.numericColorRelegationMin.Value = num3;
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00086BA8 File Offset: 0x00084DA8
		private void numericColorRelegationMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorRelegationMin.Value;
			int num2 = (int)this.numericColorRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotReleg(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotReleg(num, num2))
			{
				this.numericColorRelegationMax.Value = num4;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00086C24 File Offset: 0x00084E24
		private void numericColorPromotionMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPromotionMin.Value;
			int num2 = (int)this.numericColorPromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotPromo(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotPromo(num, num2))
			{
				this.numericColorPromotionMin.Value = num3;
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00086CA0 File Offset: 0x00084EA0
		private void numericColorPromotionMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPromotionMin.Value;
			int num2 = (int)this.numericColorPromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotPromo(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotPromo(num, num2))
			{
				this.numericColorPromotionMax.Value = num4;
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00086D1C File Offset: 0x00084F1C
		private void numericColorPossiblePromotionMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPossiblePromotionMin.Value;
			int num2 = (int)this.numericColorPossiblePromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotPromoPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotPromoPoss(num, num2))
			{
				this.numericColorPossiblePromotionMin.Value = num3;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00086D98 File Offset: 0x00084F98
		private void numericColorPossiblePromotionMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorPossiblePromotionMin.Value;
			int num2 = (int)this.numericColorPossiblePromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotPromoPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotPromoPoss(num, num2))
			{
				this.numericColorPossiblePromotionMax.Value = num4;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00086E14 File Offset: 0x00085014
		private void numericColorAdvanceMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorAdvanceMin.Value;
			int num2 = (int)this.numericColorAdvanceMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotAdvGroup(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotAdvGroup(num, num2))
			{
				this.numericColorAdvanceMin.Value = num3;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00086E90 File Offset: 0x00085090
		private void numericColorAdvanceMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericColorAdvanceMin.Value;
			int num2 = (int)this.numericColorAdvanceMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoColorSlotAdvGroup(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoColorSlotAdvGroup(num, num2))
			{
				this.numericColorAdvanceMax.Value = num4;
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00086F0C File Offset: 0x0008510C
		private void checkInfoColorChampions_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorChampionsMin.Visible = (this.numericColorChampionsMax.Visible = this.checkInfoColorChampions.Checked);
			if (this.checkInfoColorChampions.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotChampCup(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorChampionsMax.Value = num;
				this.numericColorChampionsMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotChampCup(num3, num4);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00086FB0 File Offset: 0x000851B0
		private void checkInfoColorEuropa_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorEuropaMin.Visible = (this.numericColorEuropaMax.Visible = this.checkInfoColorEuropa.Checked);
			if (this.checkInfoColorEuropa.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotEuroLeague(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorEuropaMin.Value = num;
				this.numericColorEuropaMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotEuroLeague(num3, num4);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00087054 File Offset: 0x00085254
		private void checkInfoColorPossibleRelegation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorPossibleRelegationMin.Visible = (this.numericColorPossibleRelegationMax.Visible = this.checkInfoColorPossibleRelegation.Checked);
			if (this.checkInfoColorPossibleRelegation.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotRelegPoss(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorPossibleRelegationMin.Value = num;
				this.numericColorPossibleRelegationMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotRelegPoss(num3, num4);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000870F8 File Offset: 0x000852F8
		private void checkInfoColorRelegation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorRelegationMin.Visible = (this.numericColorRelegationMax.Visible = this.checkInfoColorRelegation.Checked);
			if (this.checkInfoColorRelegation.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotReleg(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorRelegationMin.Value = num;
				this.numericColorRelegationMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotReleg(num3, num4);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0008719C File Offset: 0x0008539C
		private void checkInfoColorPromotion_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorPromotionMin.Visible = (this.numericColorPromotionMax.Visible = this.checkInfoColorPromotion.Checked);
			if (this.checkInfoColorPromotion.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotPromo(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorPromotionMin.Value = num;
				this.numericColorPromotionMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotPromo(num3, num4);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00087240 File Offset: 0x00085440
		private void checkInfoColorPossiblePromotion_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorPossiblePromotionMin.Visible = (this.numericColorPossiblePromotionMax.Visible = this.checkInfoColorPossiblePromotion.Checked);
			if (this.checkInfoColorPossiblePromotion.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotPromoPoss(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorPossiblePromotionMin.Value = num;
				this.numericColorPossiblePromotionMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotPromoPoss(num3, num4);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000872E4 File Offset: 0x000854E4
		private void checkInfoColorAdvance_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericColorAdvanceMin.Visible = (this.numericColorAdvanceMax.Visible = this.checkInfoColorAdvance.Checked);
			if (this.checkInfoColorAdvance.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoColorSlotAdvGroup(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericColorAdvanceMin.Value = num;
				this.numericColorAdvanceMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoColorSlotAdvGroup(num3, num4);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00087388 File Offset: 0x00085588
		private void labelQR_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			Task task = (Task)label.Tag;
			this.m_QualifyRuleDialog.QualifyRule = task;
			if (this.m_QualifyRuleDialog.ShowDialog() == DialogResult.OK)
			{
				label.Tag = task;
				label.Text = task.ToString();
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000873D8 File Offset: 0x000855D8
		private void labelAdvance_Click(object sender, EventArgs e)
		{
			Rank rank = (Rank)((Label)sender).Tag;
			Rank rank2 = new Rank(rank.Group, rank.Id);
			rank2.MoveFrom = rank.MoveFrom;
			this.m_AdvanceRuleDialog.Rule = rank2;
			if (this.m_AdvanceRuleDialog.ShowDialog() == DialogResult.OK)
			{
				if (rank2.MoveFrom != rank.MoveFrom)
				{
					if (rank.MoveFrom != null && rank.MoveFrom.Id != 0)
					{
						rank.MoveFrom.MoveTo = null;
					}
					if (rank2.MoveFrom.Id != 0)
					{
						if (rank2.MoveFrom.MoveTo == null)
						{
							rank2.MoveFrom.MoveTo = rank;
						}
						else
						{
							rank2.MoveFrom.MoveTo.MoveFrom = null;
							rank2.MoveFrom.MoveTo = rank;
						}
					}
					rank.MoveFrom = rank2.MoveFrom;
				}
				this.GroupToPanel();
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000874B8 File Offset: 0x000856B8
		private void textLanguageKey_TextChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentCompobj == null)
			{
				return;
			}
			if (this.m_CurrentCompobj.IsTrophy())
			{
				this.m_CurrentTrophy.Description = this.textLanguageKey.Text;
				return;
			}
			if (this.m_CurrentCompobj.IsGroup())
			{
				this.m_CurrentGroup.Description = this.textLanguageKey.Text;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00087518 File Offset: 0x00085718
		private void textFourCharName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentCompobj == null)
			{
				return;
			}
			if (this.m_CurrentCompobj.TypeString == this.textFourCharName.Text)
			{
				return;
			}
			if (this.textFourCharName.Text.Length > 5)
			{
				this.textFourCharName.Text = this.textFourCharName.Text.Substring(0, 5);
				return;
			}
			this.m_CurrentCompobj.TypeString = this.textFourCharName.Text;
			if (this.m_CurrentCompobj.IsNation())
			{
				this.treeWorld.SelectedNode.Text = this.m_CurrentCompobj.TypeString;
			}
			if (this.m_CurrentCompobj.IsGroup())
			{
				this.treeWorld.SelectedNode.Text = this.m_CurrentCompobj.TypeString;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000875E4 File Offset: 0x000857E4
		private TreeNode SelectWorldTreeNode(Compobj compobj)
		{
			if (compobj == null)
			{
				this.treeWorld.SelectedNode = null;
				return null;
			}
			TreeNode treeNode = this.RecusiveSearchNode(this.treeWorld.TopNode, compobj);
			this.treeWorld.SelectedNode = treeNode;
			return treeNode;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00087624 File Offset: 0x00085824
		private TreeNode RecusiveSearchNode(TreeNode node, Compobj compobj)
		{
			if ((Compobj)node.Tag == compobj)
			{
				return node;
			}
			foreach (object obj in node.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				TreeNode treeNode2 = this.RecusiveSearchNode(treeNode, compobj);
				if (treeNode2 != null)
				{
					return treeNode2;
				}
			}
			return null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0008769C File Offset: 0x0008589C
		private void textLanguageName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentCompobj == null)
			{
				return;
			}
			if (this.m_CurrentCompobj.IsTrophy())
			{
				this.m_CurrentTrophy.ShortName = this.textLanguageName.Text;
				return;
			}
			if (this.m_CurrentCompobj.IsStage())
			{
				if (this.m_CurrentStage.GetLanguageName() != this.textLanguageName.Text)
				{
					this.m_CurrentStage.SetLanguageName(this.textLanguageName.Text);
				}
				string text = this.m_CurrentStage.ToString();
				if (this.treeWorld.SelectedNode.Text != text)
				{
					this.treeWorld.SelectedNode.Text = text;
					return;
				}
			}
			else if (this.m_CurrentCompobj.IsGroup())
			{
				this.m_CurrentGroup.LanguageName = this.textLanguageName.Text;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00087770 File Offset: 0x00085970
		private void comboLanguageKey_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLanguageKey.SelectedItem != null && this.comboLanguageKey.SelectedItem.ToString() != this.m_CurrentStage.Description)
			{
				this.m_CurrentStage.Description = (string)this.comboLanguageKey.SelectedItem;
				string @string = FifaEnvironment.Language.GetString(this.m_CurrentStage.Description);
				this.textLanguageName.Text = @string;
				this.treeWorld.SelectedNode.Text = this.m_CurrentStage.ToString();
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00087804 File Offset: 0x00085A04
		private void buttonCopyWeather_Click(object sender, EventArgs e)
		{
			this.m_ClipboardNation = this.m_CurrentNation;
			this.buttonPasteWeather.Enabled = true;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00087820 File Offset: 0x00085A20
		private void buttonPasteWeather_Click(object sender, EventArgs e)
		{
			if (this.m_ClipboardNation != null)
			{
				for (int i = 0; i < 12; i++)
				{
					this.m_CurrentNation.ClearProb[i] = this.m_ClipboardNation.ClearProb[i];
					this.m_CurrentNation.HazyProb[i] = this.m_ClipboardNation.HazyProb[i];
					this.m_CurrentNation.CloudyProb[i] = this.m_ClipboardNation.CloudyProb[i];
					this.m_CurrentNation.RainProb[i] = this.m_ClipboardNation.RainProb[i];
					this.m_CurrentNation.ShowersProb[i] = this.m_ClipboardNation.ShowersProb[i];
					this.m_CurrentNation.SnowProb[i] = this.m_ClipboardNation.SnowProb[i];
					this.m_CurrentNation.FlurriesProb[i] = this.m_ClipboardNation.FlurriesProb[i];
					this.m_CurrentNation.OvercastProb[i] = this.m_ClipboardNation.OvercastProb[i];
					this.m_CurrentNation.FoggyProb[i] = this.m_ClipboardNation.FoggyProb[i];
					this.m_CurrentNation.SunsetTime[i] = this.m_ClipboardNation.SunsetTime[i];
					this.m_CurrentNation.DarkTime[i] = this.m_ClipboardNation.DarkTime[i];
				}
				this.NationToPanel();
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00087970 File Offset: 0x00085B70
		private void weatherProb_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			int i = 0;
			while (i < 12)
			{
				if (numericUpDown == this.m_HazyProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.HazyProb[i] = (int)this.m_HazyProb[i].Value;
						return;
					}
					this.m_HazyProb[i].Value = this.m_CurrentNation.HazyProb[i];
					return;
				}
				else if (numericUpDown == this.m_CloudyProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.CloudyProb[i] = (int)this.m_CloudyProb[i].Value;
						return;
					}
					this.m_CloudyProb[i].Value = this.m_CurrentNation.CloudyProb[i];
					return;
				}
				else if (numericUpDown == this.m_OvercastProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.OvercastProb[i] = (int)this.m_OvercastProb[i].Value;
						return;
					}
					this.m_OvercastProb[i].Value = this.m_CurrentNation.OvercastProb[i];
					return;
				}
				else if (numericUpDown == this.m_FoggyProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.FoggyProb[i] = (int)this.m_FoggyProb[i].Value;
						return;
					}
					this.m_FoggyProb[i].Value = this.m_CurrentNation.FoggyProb[i];
					return;
				}
				else if (numericUpDown == this.m_RainProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.RainProb[i] = (int)this.m_RainProb[i].Value;
						return;
					}
					this.m_RainProb[i].Value = this.m_CurrentNation.RainProb[i];
					return;
				}
				else if (numericUpDown == this.m_ShowersProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.ShowersProb[i] = (int)this.m_ShowersProb[i].Value;
						return;
					}
					this.m_ShowersProb[i].Value = this.m_CurrentNation.ShowersProb[i];
					return;
				}
				else if (numericUpDown == this.m_FlurriesProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.FlurriesProb[i] = (int)this.m_FlurriesProb[i].Value;
						return;
					}
					this.m_FlurriesProb[i].Value = this.m_CurrentNation.FlurriesProb[i];
					return;
				}
				else if (numericUpDown == this.m_SnowProb[i])
				{
					if (this.ComputeClearProb(i))
					{
						this.m_CurrentNation.SnowProb[i] = (int)this.m_SnowProb[i].Value;
						return;
					}
					this.m_SnowProb[i].Value = this.m_CurrentNation.SnowProb[i];
					return;
				}
				else
				{
					if (numericUpDown == this.m_ClearProb[i])
					{
						this.m_CurrentNation.ClearProb[i] = (int)this.m_ClearProb[i].Value;
						return;
					}
					i++;
				}
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00087C6C File Offset: 0x00085E6C
		private bool ComputeClearProb(int month)
		{
			int num = (int)(this.m_HazyProb[month].Value + this.m_CloudyProb[month].Value + this.m_OvercastProb[month].Value + this.m_FoggyProb[month].Value + this.m_RainProb[month].Value + this.m_ShowersProb[month].Value + this.m_FlurriesProb[month].Value + this.m_SnowProb[month].Value);
			int num2 = 100 - num;
			if (num2 >= 0)
			{
				this.m_ClearProb[month].Value = num2;
				return true;
			}
			return false;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00087D2C File Offset: 0x00085F2C
		private void dayTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			for (int i = 0; i < 12; i++)
			{
				if (comboBox == this.m_SunsetTime[i])
				{
					switch (comboBox.SelectedIndex)
					{
					case 0:
						this.m_CurrentNation.SunsetTime[i] = 1600;
						break;
					case 1:
						this.m_CurrentNation.SunsetTime[i] = 1630;
						break;
					case 2:
						this.m_CurrentNation.SunsetTime[i] = 1700;
						break;
					case 3:
						this.m_CurrentNation.SunsetTime[i] = 1730;
						break;
					case 4:
						this.m_CurrentNation.SunsetTime[i] = 1800;
						break;
					case 5:
						this.m_CurrentNation.SunsetTime[i] = 1830;
						break;
					case 6:
						this.m_CurrentNation.SunsetTime[i] = 1900;
						break;
					case 7:
						this.m_CurrentNation.SunsetTime[i] = 1930;
						break;
					case 8:
						this.m_CurrentNation.SunsetTime[i] = 2000;
						break;
					case 9:
						this.m_CurrentNation.SunsetTime[i] = 2030;
						break;
					case 10:
						this.m_CurrentNation.SunsetTime[i] = 2100;
						break;
					}
				}
				else if (comboBox == this.m_NightTime[i])
				{
					switch (comboBox.SelectedIndex)
					{
					case 0:
						this.m_CurrentNation.DarkTime[i] = 1600;
						break;
					case 1:
						this.m_CurrentNation.DarkTime[i] = 1630;
						break;
					case 2:
						this.m_CurrentNation.DarkTime[i] = 1700;
						break;
					case 3:
						this.m_CurrentNation.DarkTime[i] = 1730;
						break;
					case 4:
						this.m_CurrentNation.DarkTime[i] = 1800;
						break;
					case 5:
						this.m_CurrentNation.DarkTime[i] = 1830;
						break;
					case 6:
						this.m_CurrentNation.DarkTime[i] = 1900;
						break;
					case 7:
						this.m_CurrentNation.DarkTime[i] = 1930;
						break;
					case 8:
						this.m_CurrentNation.DarkTime[i] = 2000;
						break;
					case 9:
						this.m_CurrentNation.DarkTime[i] = 2030;
						break;
					case 10:
						this.m_CurrentNation.DarkTime[i] = 2100;
						break;
					}
				}
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00087FD0 File Offset: 0x000861D0
		private void treeStageSchedule_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.treeStageSchedule.SelectedNode == null)
			{
				return;
			}
			if (this.treeStageSchedule.SelectedNode.Tag == null)
			{
				this.groupStageScheduleDetails.Visible = false;
				this.buttonStageAddTime.Enabled = false;
				this.buttonStageRemoveTime.Enabled = false;
				this.buttonDeleteStageLeg.Enabled = false;
				return;
			}
			this.m_CurrentStageSchedule = (Schedule)this.treeStageSchedule.SelectedNode.Tag;
			this.buttonDeleteStageLeg.Enabled = true;
			this.StageScheduleToPanel();
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0008805C File Offset: 0x0008625C
		private void StageScheduleToPanel()
		{
			this.groupStageScheduleDetails.Visible = true;
			this.buttonStageAddTime.Enabled = true;
			this.buttonStageRemoveTime.Enabled = true;
			this.dateStagePicker.Value = this.m_CurrentStageSchedule.Date;
			this.numericStageMinGames.Value = this.m_CurrentStageSchedule.MinGames;
			this.numericStageMaxGames.Value = this.m_CurrentStageSchedule.MaxGames;
			if (this.m_CurrentStageSchedule.TimeIndex < 0)
			{
				this.m_CurrentStageSchedule.TimeIndex = 1;
			}
			this.comboStageTime.SelectedIndex = this.m_CurrentStageSchedule.TimeIndex;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00088109 File Offset: 0x00086309
		private void numericStageMinGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentStageSchedule.MinGames = (int)this.numericStageMinGames.Value;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00088126 File Offset: 0x00086326
		private void numericStageMaxGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentStageSchedule.MaxGames = (int)this.numericStageMaxGames.Value;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00088144 File Offset: 0x00086344
		private void comboStageTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboStageTime.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboStageTime.SelectedIndex == this.m_CurrentStageSchedule.TimeIndex)
			{
				return;
			}
			this.m_CurrentStageSchedule.TimeIndex = this.comboStageTime.SelectedIndex;
			this.treeStageSchedule.SelectedNode.Text = this.m_CurrentStageSchedule.Date.ToString("f");
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000881B8 File Offset: 0x000863B8
		private void dateStagePicker_ValueChanged(object sender, EventArgs e)
		{
			if (this.dateStagePicker.Value == this.m_CurrentStageSchedule.Date)
			{
				return;
			}
			this.m_CurrentStageSchedule.Date = this.dateStagePicker.Value;
			this.treeStageSchedule.SelectedNode.Text = this.m_CurrentStageSchedule.Date.ToString("f");
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00088224 File Offset: 0x00086424
		private void GroupScheduleToPanel()
		{
			this.groupGroupScheduleDetails.Visible = true;
			this.buttonGroupAddTime.Enabled = true;
			this.buttonGroupRemoveTime.Enabled = true;
			this.dateGroupPicker.Value = this.m_CurrentGroupSchedule.Date;
			this.numericGroupMinGames.Value = this.m_CurrentGroupSchedule.MinGames;
			this.numericGroupMaxGames.Value = this.m_CurrentGroupSchedule.MaxGames;
			this.comboGroupTime.SelectedIndex = this.m_CurrentGroupSchedule.TimeIndex;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000882B8 File Offset: 0x000864B8
		private void dateGroupPicker_ValueChanged(object sender, EventArgs e)
		{
			if (this.dateGroupPicker.Value == this.m_CurrentGroupSchedule.Date)
			{
				return;
			}
			this.m_CurrentGroupSchedule.Date = this.dateGroupPicker.Value;
			this.treeGroupSchedule.SelectedNode.Text = this.m_CurrentGroupSchedule.Date.ToString("f");
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00088324 File Offset: 0x00086524
		private void comboGroupTime_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboGroupTime.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboGroupTime.SelectedIndex == this.m_CurrentGroupSchedule.TimeIndex)
			{
				return;
			}
			this.m_CurrentGroupSchedule.TimeIndex = this.comboGroupTime.SelectedIndex;
			this.treeGroupSchedule.SelectedNode.Text = this.m_CurrentGroupSchedule.Date.ToString("f");
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00088397 File Offset: 0x00086597
		private void numericGroupMinGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentGroupSchedule.MinGames = (int)this.numericGroupMinGames.Value;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000883B4 File Offset: 0x000865B4
		private void numericGroupMaxGames_ValueChanged(object sender, EventArgs e)
		{
			this.m_CurrentGroupSchedule.MaxGames = (int)this.numericGroupMaxGames.Value;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000883D4 File Offset: 0x000865D4
		private void treeGroupSchedule_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (this.treeGroupSchedule.SelectedNode == null)
			{
				return;
			}
			if (this.treeGroupSchedule.SelectedNode.Tag == null)
			{
				this.groupGroupScheduleDetails.Visible = false;
				this.buttonGroupAddTime.Enabled = false;
				this.buttonGroupRemoveTime.Enabled = false;
				this.buttonRemoveGroupLeg.Enabled = false;
				return;
			}
			this.m_CurrentGroupSchedule = (Schedule)this.treeGroupSchedule.SelectedNode.Tag;
			this.buttonRemoveGroupLeg.Enabled = true;
			this.GroupScheduleToPanel();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00088460 File Offset: 0x00086660
		private void comboInitTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			for (int i = 0; i < 24; i++)
			{
				if (comboBox == this.m_InitTeamCombo[i])
				{
					InitTeam initTeam = this.m_CurrentTrophy.InitTeamArray[i];
					if (initTeam == null)
					{
						initTeam = new InitTeam(i, -1);
						this.m_CurrentTrophy.InitTeamArray[i] = initTeam;
					}
					if (initTeam != null)
					{
						if (comboBox.SelectedIndex == 0)
						{
							initTeam.Team = null;
						}
						else
						{
							initTeam.Team = (Team)comboBox.SelectedItem;
						}
					}
				}
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000884D8 File Offset: 0x000866D8
		private void numericNTeams_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentGroup == null)
			{
				return;
			}
			if (this.numericNTeams.Value == this.m_CurrentGroup.Ranks.Count - 1)
			{
				return;
			}
			if (this.numericNTeams.Value >= this.m_CurrentGroup.Ranks.Count)
			{
				int num = this.m_CurrentGroup.Ranks.Count;
				while (num <= this.numericNTeams.Value)
				{
					this.m_CurrentGroup.AddRank();
					num++;
				}
			}
			else
			{
				int num2 = this.m_CurrentGroup.Ranks.Count - 1;
				while (num2 > this.numericNTeams.Value)
				{
					this.m_CurrentGroup.RemoveRank();
					num2--;
				}
			}
			this.GroupToPanel();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000885C8 File Offset: 0x000867C8
		private void numericNumGames_ValueChanged_1(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentGroup.Settings.m_num_games = (int)this.numericNumGames.Value;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000885F4 File Offset: 0x000867F4
		private void EnableToolWorld()
		{
			if (this.m_CurrentCompobj == null || this.m_CurrentCompobj.IsWorld())
			{
				this.buttonAddNatiom.Visible = false;
				this.buttonDeleteNation.Visible = false;
				this.buttonAddTrophy.Visible = true;
				this.buttonPasteTrophy.Visible = true;
				this.comboTargetLeague.Visible = true;
				this.buttonCopyTrophy.Visible = false;
				this.buttonDeleteTrophy.Visible = false;
				this.buttonAddStage.Visible = false;
				this.buttonDeleteStage.Visible = false;
				this.buttonAddGroup.Visible = false;
				this.buttonDeleteGroup.Visible = false;
				this.buttonLoadPatch.Visible = true;
				this.buttonCreatePatch.Visible = false;
				return;
			}
			if (this.m_CurrentCompobj.IsConfederation())
			{
				this.buttonAddNatiom.Visible = true;
				this.buttonDeleteNation.Visible = false;
				this.buttonAddTrophy.Visible = true;
				this.buttonPasteTrophy.Visible = true;
				this.comboTargetLeague.Visible = true;
				this.buttonCopyTrophy.Visible = false;
				this.buttonDeleteTrophy.Visible = false;
				this.buttonAddStage.Visible = false;
				this.buttonDeleteStage.Visible = false;
				this.buttonAddGroup.Visible = false;
				this.buttonDeleteGroup.Visible = false;
				this.buttonLoadPatch.Visible = true;
				this.buttonCreatePatch.Visible = true;
				return;
			}
			if (this.m_CurrentCompobj.IsNation())
			{
				this.buttonAddNatiom.Visible = false;
				this.buttonDeleteNation.Visible = true;
				this.buttonAddTrophy.Visible = true;
				this.buttonPasteTrophy.Visible = true;
				this.comboTargetLeague.Visible = true;
				this.buttonCopyTrophy.Visible = false;
				this.buttonDeleteTrophy.Visible = false;
				this.buttonAddStage.Visible = false;
				this.buttonDeleteStage.Visible = false;
				this.buttonAddGroup.Visible = false;
				this.buttonDeleteGroup.Visible = false;
				this.buttonLoadPatch.Visible = true;
				this.buttonCreatePatch.Visible = true;
				return;
			}
			if (this.m_CurrentCompobj.IsTrophy())
			{
				this.buttonAddNatiom.Visible = false;
				this.buttonDeleteNation.Visible = false;
				this.buttonAddTrophy.Visible = false;
				this.buttonPasteTrophy.Visible = false;
				this.comboTargetLeague.Visible = false;
				this.buttonCopyTrophy.Visible = true;
				this.buttonDeleteTrophy.Visible = true;
				this.buttonAddStage.Visible = false;
				this.buttonDeleteStage.Visible = false;
				this.buttonAddGroup.Visible = false;
				this.buttonDeleteGroup.Visible = false;
				this.buttonLoadPatch.Visible = false;
				this.buttonCreatePatch.Visible = true;
				return;
			}
			if (this.m_CurrentCompobj.IsStage())
			{
				this.buttonAddNatiom.Visible = false;
				this.buttonDeleteNation.Visible = false;
				this.buttonAddTrophy.Visible = false;
				this.buttonPasteTrophy.Visible = false;
				this.comboTargetLeague.Visible = false;
				this.buttonCopyTrophy.Visible = false;
				this.buttonDeleteTrophy.Visible = false;
				this.buttonAddStage.Visible = true;
				this.buttonDeleteStage.Visible = true;
				this.buttonAddGroup.Visible = false;
				this.buttonDeleteGroup.Visible = false;
				this.buttonLoadPatch.Visible = false;
				this.buttonCreatePatch.Visible = false;
				return;
			}
			if (this.m_CurrentCompobj.IsGroup())
			{
				this.buttonAddNatiom.Visible = false;
				this.buttonDeleteNation.Visible = false;
				this.buttonAddTrophy.Visible = false;
				this.buttonPasteTrophy.Visible = false;
				this.comboTargetLeague.Visible = false;
				this.buttonCopyTrophy.Visible = false;
				this.buttonDeleteTrophy.Visible = false;
				this.buttonAddStage.Visible = false;
				this.buttonDeleteStage.Visible = false;
				this.buttonAddGroup.Visible = true;
				this.buttonDeleteGroup.Visible = true;
				this.buttonLoadPatch.Visible = false;
				this.buttonCreatePatch.Visible = false;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00088A16 File Offset: 0x00086C16
		private void labelDatabaseCountry_DoubleClick(object sender, EventArgs e)
		{
			if (this.m_CurrentNation.Country != null)
			{
				MainForm.CM.JumpTo(this.m_CurrentNation.Country);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00088A3C File Offset: 0x00086C3C
		private void buttonAddNatiom_Click(object sender, EventArgs e)
		{
			Nation nation = new Nation(FifaEnvironment.CompetitionObjects.GetNewId(), "COUN", "NationName_XXX", this.m_CurrentConfederation);
			this.m_CurrentConfederation.Nations.Add(nation);
			FifaEnvironment.CompetitionObjects.Add(nation);
			nation.Settings.m_schedule_seasonstartmonth = this.m_CurrentConfederation.Settings.m_schedule_seasonstartmonth;
			nation.Settings.m_rule_numyellowstored = 3;
			TreeNode treeNode = this.treeWorld.SelectedNode.Nodes.Add(nation.ToString());
			treeNode.Tag = nation;
			treeNode.ForeColor = Color.Blue;
			this.treeWorld.SelectedNode = treeNode;
			this.treeWorld.Refresh();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00088AF4 File Offset: 0x00086CF4
		private void buttonDeleteNation_Click(object sender, EventArgs e)
		{
			this.m_CurrentConfederation = (Confederation)this.m_CurrentNation.ParentObj;
			foreach (object obj in this.m_CurrentNation.Trophies)
			{
				Trophy trophy = (Trophy)obj;
				foreach (object obj2 in trophy.Stages)
				{
					Stage stage = (Stage)obj2;
					foreach (object obj3 in stage.Groups)
					{
						Group group = (Group)obj3;
						this.m_Competitions.RemoveId(group);
					}
					this.m_Competitions.RemoveId(stage);
				}
				this.m_Competitions.RemoveId(trophy);
			}
			this.m_CurrentConfederation.Nations.RemoveId(this.m_CurrentNation);
			this.treeWorld.SelectedNode.Remove();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00088C48 File Offset: 0x00086E48
		private void buttonAddTrophy_Click(object sender, EventArgs e)
		{
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			int num = Trophy.AutoAsset();
			string tournamentConventionalString = FifaEnvironment.Language.GetTournamentConventionalString(num, Language.ETournamentStringType.Abbr15);
			string text = "C" + num.ToString();
			Trophy trophy = new Trophy(newId, text, tournamentConventionalString, this.m_CurrentCompobj);
			this.m_CurrentCompobj.Trophies.Add(trophy);
			this.m_Competitions.Add(trophy);
			trophy.Settings.m_asset_id = num;
			trophy.Settings.m_rule_numsubsbench = 5;
			trophy.Settings.m_match_matchimportance = 25;
			trophy.Settings.m_comp_type = "LEAGUE";
			if (!trophy.InsertStage(0))
			{
				return;
			}
			Stage stage = (Stage)trophy.Stages[0];
			stage.InsertGroup(0);
			Group group = (Group)stage.Groups[0];
			TreeNode treeNode = this.treeWorld.SelectedNode.Nodes.Add(trophy.ToString());
			treeNode.Tag = trophy;
			treeNode.ForeColor = Color.DarkGreen;
			TreeNode treeNode2 = treeNode.Nodes.Add(stage.ToString());
			treeNode2.Tag = stage;
			treeNode2.ForeColor = Color.Magenta;
			TreeNode treeNode3 = treeNode2.Nodes.Add(group.ToString());
			treeNode3.Tag = group;
			treeNode3.ForeColor = Color.DarkRed;
			this.treeWorld.SelectedNode = treeNode;
			this.Preset();
			this.treeWorld.Refresh();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00088DB8 File Offset: 0x00086FB8
		private void buttonDeleteTrophy_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentTrophy.ParentObj.IsConfederation())
			{
				this.m_CurrentConfederation = (Confederation)this.m_CurrentTrophy.ParentObj;
				this.m_CurrentConfederation.Trophies.RemoveId(this.m_CurrentTrophy);
			}
			else if (this.m_CurrentTrophy.ParentObj.IsNation())
			{
				this.m_CurrentNation = (Nation)this.m_CurrentTrophy.ParentObj;
				this.m_CurrentNation.Trophies.RemoveId(this.m_CurrentTrophy);
			}
			else if (this.m_CurrentTrophy.ParentObj.IsWorld())
			{
				this.m_CurrentWorld.Trophies.RemoveId(this.m_CurrentTrophy);
			}
			foreach (object obj in this.m_CurrentTrophy.Stages)
			{
				Stage stage = (Stage)obj;
				foreach (object obj2 in stage.Groups)
				{
					Group group = (Group)obj2;
					this.m_Competitions.RemoveId(group);
				}
				this.m_Competitions.RemoveId(stage);
			}
			this.m_Competitions.RemoveId(this.m_CurrentTrophy);
			this.treeWorld.SelectedNode.Remove();
			this.Preset();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00088F44 File Offset: 0x00087144
		private Stage CreateFirstStage(Trophy parentTrophy)
		{
			if (!parentTrophy.InsertStage(0))
			{
				return null;
			}
			return (Stage)parentTrophy.Stages[0];
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00088F64 File Offset: 0x00087164
		private Group CreateFirstGroup(Stage parentStage)
		{
			Group group = new Group(FifaEnvironment.CompetitionObjects.GetNewId(), "G1", "FCE_Setup_Group", parentStage);
			parentStage.Groups.Add(group);
			FifaEnvironment.CompetitionObjects.Add(group);
			group.Settings.m_num_games = 1;
			return group;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00088FB4 File Offset: 0x000871B4
		private void buttonAddStage_Click(object sender, EventArgs e)
		{
			int num = this.m_CurrentTrophy.Stages.IndexOf(this.m_CurrentStage);
			if (num < 0)
			{
				return;
			}
			num++;
			if (!this.m_CurrentTrophy.InsertStage(num))
			{
				return;
			}
			this.m_CurrentStage = (Stage)this.m_CurrentTrophy.Stages[num];
			this.m_Competitions.Add(this.m_CurrentStage);
			this.m_CurrentStage.InsertGroup(0);
			Group group = (Group)this.m_CurrentStage.Groups[0];
			this.m_Competitions.Add(group);
			TreeNode treeNode = this.treeWorld.SelectedNode.Parent.Nodes.Insert(num, this.m_CurrentStage.ToString());
			treeNode.ForeColor = Color.Magenta;
			treeNode.Tag = this.m_CurrentStage;
			TreeNode treeNode2 = treeNode.Nodes.Add(group.ToString());
			treeNode2.Tag = group;
			treeNode2.ForeColor = Color.DarkRed;
			this.treeWorld.SelectedNode = treeNode;
			this.Preset();
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000890C4 File Offset: 0x000872C4
		private void buttonDeleteStage_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.m_CurrentStage.Groups)
			{
				Group group = (Group)obj;
				for (int i = 1; i < group.Ranks.Count; i++)
				{
					Rank rank = (Rank)group.Ranks[i];
					if (rank.MoveFrom != null)
					{
						rank.MoveFrom.MoveTo = null;
					}
					if (rank.MoveTo != null)
					{
						rank.MoveTo.MoveFrom = null;
					}
				}
				this.m_Competitions.RemoveId(group);
			}
			this.m_Competitions.RemoveId(this.m_CurrentStage);
			this.m_CurrentTrophy.RemoveStage(this.m_CurrentStage);
			this.treeWorld.SelectedNode.Remove();
			this.Preset();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000891B8 File Offset: 0x000873B8
		private void checkCalccompavgs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_calccompavgs = (this.checkCalccompavgs.Checked ? 1 : (-1));
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000891E4 File Offset: 0x000873E4
		private void checkRandomDraw_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_randomdraw = (this.checkRandomDraw.Checked ? 1 : (-1));
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00089210 File Offset: 0x00087410
		private void buttonAddGroup_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup == null)
			{
				return;
			}
			this.m_ClipboardGroup = this.m_CurrentGroup;
			int num = this.m_CurrentStage.Groups.IndexOf(this.m_CurrentGroup);
			if (num < 0)
			{
				return;
			}
			num++;
			if (!this.m_CurrentStage.InsertGroup(num))
			{
				return;
			}
			this.m_CurrentGroup = (Group)this.m_CurrentStage.Groups[num];
			this.m_Competitions.Add(this.m_CurrentGroup);
			for (int i = 1; i < this.m_ClipboardGroup.Ranks.Count; i++)
			{
				Rank rank = new Rank(this.m_CurrentGroup, i);
				Rank rank2 = (Rank)this.m_ClipboardGroup.Ranks[i];
				if (rank2.MoveFrom != null && rank2.MoveFrom.Id == 0)
				{
					rank.MoveFrom = rank2.MoveFrom;
				}
				this.m_CurrentGroup.Ranks.Add(rank);
			}
			this.m_CurrentGroup.Settings.m_num_games = this.m_ClipboardGroup.Settings.m_num_games;
			TreeNode treeNode = this.treeWorld.SelectedNode.Parent.Nodes.Insert(num, this.m_CurrentGroup.ToString());
			treeNode.ForeColor = Color.Brown;
			treeNode.Tag = this.m_CurrentGroup;
			this.treeWorld.SelectedNode = treeNode;
			foreach (object obj in this.treeWorld.SelectedNode.Parent.Nodes)
			{
				TreeNode treeNode2 = (TreeNode)obj;
				treeNode2.Text = ((Group)treeNode2.Tag).ToString();
			}
			this.Preset();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x000893E4 File Offset: 0x000875E4
		private void buttonDeleteGroup_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup == null)
			{
				return;
			}
			for (int i = 1; i < this.m_CurrentGroup.Ranks.Count; i++)
			{
				Rank rank = (Rank)this.m_CurrentGroup.Ranks[i];
				if (rank.MoveFrom != null)
				{
					rank.MoveFrom.MoveTo = null;
				}
				if (rank.MoveTo != null)
				{
					rank.MoveTo.MoveFrom = null;
				}
			}
			this.m_CurrentStage.RemoveGroup(this.m_CurrentGroup);
			this.m_Competitions.RemoveId(this.m_CurrentGroup);
			TreeNode parent = this.treeWorld.SelectedNode.Parent;
			this.treeWorld.SelectedNode.Remove();
			foreach (object obj in parent.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				treeNode.Text = ((Group)treeNode.Tag).ToString();
			}
			this.Preset();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000894F8 File Offset: 0x000876F8
		private void buttonCopyTrophy_Click(object sender, EventArgs e)
		{
			this.m_ClipboardTrophy = this.m_CurrentTrophy;
			this.buttonPasteTrophy.Enabled = this.m_ClipboardTrophy != null;
			this.comboTargetLeague.Enabled = this.buttonPasteTrophy.Enabled;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00089530 File Offset: 0x00087730
		private void buttonPasteTrophy_Click(object sender, EventArgs e)
		{
			if (this.m_ClipboardTrophy == null)
			{
				return;
			}
			bool flag = false;
			if (this.m_ClipboardTrophy.Stages != null && ((Stage)this.m_ClipboardTrophy.Stages[0]).Settings.m_match_stagetype == "LEAGUE")
			{
				flag = true;
			}
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			League league = null;
			if (this.comboTargetLeague.SelectedIndex > 0)
			{
				league = (League)this.comboTargetLeague.SelectedItem;
			}
			int num;
			if (flag && league != null)
			{
				num = league.Id;
			}
			else
			{
				num = Trophy.AutoAsset();
			}
			string tournamentConventionalString = FifaEnvironment.Language.GetTournamentConventionalString(num, Language.ETournamentStringType.Abbr15);
			string text = "C" + num.ToString();
			Trophy trophy = new Trophy(newId, text, tournamentConventionalString, this.m_CurrentCompobj);
			this.m_CurrentCompobj.Trophies.Add(trophy);
			this.m_Competitions.Add(trophy);
			trophy.Settings.m_asset_id = num;
			trophy.Settings.m_rule_numsubsbench = this.m_ClipboardTrophy.Settings.m_rule_numsubsbench;
			trophy.Settings.m_match_matchimportance = this.m_ClipboardTrophy.Settings.m_match_matchimportance;
			trophy.Settings.m_comp_type = this.m_ClipboardTrophy.Settings.m_comp_type;
			trophy.Settings.m_StandingsSort = this.m_ClipboardTrophy.Settings.m_StandingsSort;
			trophy.Settings.m_schedule_checkconflict = this.m_ClipboardTrophy.Settings.m_schedule_checkconflict;
			trophy.Settings.TrophyCompdependency = this.m_ClipboardTrophy.Settings.TrophyCompdependency;
			trophy.Settings.TrophyForcecomp = this.m_ClipboardTrophy.Settings.TrophyForcecomp;
			trophy.Settings.LeaguePromo = this.m_ClipboardTrophy.Settings.LeaguePromo;
			trophy.Settings.LeagueReleg = this.m_ClipboardTrophy.Settings.LeagueReleg;
			TreeNode treeNode = this.treeWorld.SelectedNode.Nodes.Add(trophy.ToString());
			treeNode.Tag = trophy;
			treeNode.ForeColor = Color.DarkGreen;
			for (int i = 0; i < this.m_ClipboardTrophy.Stages.Count; i++)
			{
				trophy.AddStage();
				Stage stage = (Stage)trophy.Stages[i];
				Stage stage2 = (Stage)this.m_ClipboardTrophy.Stages[i];
				if (stage2.Schedules != null)
				{
					foreach (object obj in stage2.Schedules)
					{
						Schedule schedule = (Schedule)obj;
						Schedule schedule2 = new Schedule(stage, schedule.Day, schedule.Leg, schedule.MinGames, schedule.MaxGames, schedule.Time);
						stage.AddSchedule(schedule2);
					}
				}
				stage.Description = stage2.Description;
				stage.Settings.m_match_stagetype = stage2.Settings.m_match_stagetype;
				stage.Settings.m_match_matchsituation = stage2.Settings.m_match_matchsituation;
				stage.Settings.m_schedule_matchreplay = stage2.Settings.m_schedule_matchreplay;
				stage.Settings.m_info_prize_money = stage2.Settings.m_info_prize_money;
				stage.Settings.m_info_prize_money_drop = stage2.Settings.m_info_prize_money_drop;
				stage.Settings.m_advance_maxteamsassoc = stage2.Settings.m_advance_maxteamsassoc;
				stage.Settings.m_advance_maxteamsgroup = stage2.Settings.m_advance_maxteamsgroup;
				stage.Settings.m_schedule_reversed = stage2.Settings.m_schedule_reversed;
				stage.Settings.Advance_standingskeep = stage2.Settings.Advance_standingskeep;
				stage.Settings.Advance_pointskeep = stage2.Settings.Advance_pointskeep;
				stage.Settings.m_advance_pointskeeppercentage = stage2.Settings.m_advance_pointskeeppercentage;
				stage.Settings.Advance_standingsrank = stage2.Settings.Advance_standingsrank;
				stage.Settings.m_EndRuleKo1Leg = stage2.Settings.m_EndRuleKo1Leg;
				stage.Settings.m_EndRuleKo2Leg2 = stage2.Settings.m_EndRuleKo2Leg2;
				stage.Settings.Standings_checkrank = stage2.Settings.Standings_checkrank;
				stage.Settings.m_advance_randomdraw = stage2.Settings.m_advance_randomdraw;
				stage.Settings.m_advance_calccompavgs = stage2.Settings.m_advance_calccompavgs;
				stage2.CopyTasks(stage, league);
				TreeNode treeNode2 = treeNode.Nodes.Add(stage.ToString());
				treeNode2.Tag = stage;
				treeNode2.ForeColor = Color.Magenta;
				for (int j = 0; j < stage2.Groups.Count; j++)
				{
					stage.InsertGroup(j);
					Group group = (Group)stage.Groups[j];
					Group group2 = (Group)stage2.Groups[j];
					TreeNode treeNode3 = treeNode2.Nodes.Add(group.ToString());
					treeNode3.Tag = group;
					treeNode3.ForeColor = Color.DarkRed;
					if (group2.Schedules != null)
					{
						foreach (object obj2 in group2.Schedules)
						{
							Schedule schedule3 = (Schedule)obj2;
							Schedule schedule4 = new Schedule(group, schedule3.Day, schedule3.Leg, schedule3.MinGames, schedule3.MaxGames, schedule3.Time);
							group.AddSchedule(schedule4);
						}
					}
					group.Description = group2.Description;
					for (int k = 1; k < group2.Ranks.Count; k++)
					{
						group.AddRank();
						Rank rank = (Rank)group2.Ranks[k];
						Rank rank2 = (Rank)group.Ranks[k];
					}
					group.Settings.m_num_games = group2.Settings.m_num_games;
					group.Settings.m_StandingsSort = group2.Settings.m_StandingsSort;
					group.Settings.m_info_color_slot_champ = group2.Settings.m_info_color_slot_champ;
					group.Settings.m_info_slot_champ = group2.Settings.m_info_slot_champ;
					int num2;
					int num3;
					group2.Settings.GetInfoColorSlotChampCup(out num2, out num3);
					group.Settings.SetInfoColorSlotChampCup(num2, num3);
					group2.Settings.GetInfoColorSlotEuroLeague(out num2, out num3);
					group.Settings.SetInfoColorSlotEuroLeague(num2, num3);
					group2.Settings.GetInfoColorSlotRelegPoss(out num2, out num3);
					group.Settings.SetInfoColorSlotRelegPoss(num2, num3);
					group2.Settings.GetInfoColorSlotReleg(out num2, out num3);
					group.Settings.SetInfoColorSlotReleg(num2, num3);
					group2.Settings.GetInfoColorSlotPromo(out num2, out num3);
					group.Settings.SetInfoColorSlotPromo(num2, num3);
					group2.Settings.GetInfoColorSlotPromoPoss(out num2, out num3);
					group.Settings.SetInfoColorSlotPromoPoss(num2, num3);
					group2.Settings.GetInfoColorSlotAdvGroup(out num2, out num3);
					group.Settings.SetInfoColorSlotAdvGroup(num2, num3);
					group2.Settings.GetInfoSlotRelegPoss(out num2, out num3);
					group.Settings.SetInfoSlotRelegPoss(num2, num3);
					group2.Settings.GetInfoSlotReleg(out num2, out num3);
					group.Settings.SetInfoSlotReleg(num2, num3);
					group2.Settings.GetInfoSlotPromo(out num2, out num3);
					group.Settings.SetInfoSlotPromo(num2, num3);
					group2.Settings.GetInfoSlotPromoPoss(out num2, out num3);
					group.Settings.SetInfoSlotPromoPoss(num2, num3);
					group2.CopyTasks(group, league);
				}
			}
			this.m_ClipboardTrophy.CopyTasks(trophy, league);
			trophy.LinkCompetitions();
			for (int l = 0; l < this.m_ClipboardTrophy.Stages.Count; l++)
			{
				Stage stage3 = (Stage)trophy.Stages[l];
				Stage stage4 = (Stage)this.m_ClipboardTrophy.Stages[l];
				stage3.LinkCompetitions();
				for (int m = 0; m < stage4.Groups.Count; m++)
				{
					Group group3 = (Group)stage3.Groups[m];
					Group group4 = (Group)stage4.Groups[m];
					group3.LinkCompetitions();
					for (int n = 1; n < group4.Ranks.Count; n++)
					{
						Rank rank3 = (Rank)group4.Ranks[n];
						Rank rank4 = (Rank)group3.Ranks[n];
						if (rank3.MoveFrom != null)
						{
							int num4 = rank3.MoveFrom.Group.Id - rank3.Group.Id;
							int num5 = rank4.Group.Id + num4;
							Compobj compobj = (Compobj)this.m_Competitions.SearchId(num5);
							if (compobj.IsGroup())
							{
								Group group5 = (Group)compobj;
								if (group5 != null && group5.Ranks.Count > rank3.MoveFrom.Id)
								{
									rank4.MoveFrom = (Rank)group5.Ranks[rank3.MoveFrom.Id];
								}
							}
						}
						if (rank3.MoveTo != null)
						{
							int num6 = rank3.MoveTo.Group.Id - rank3.Group.Id;
							int num7 = rank4.Group.Id + num6;
							Compobj compobj2 = (Compobj)this.m_Competitions.SearchId(num7);
							if (compobj2 != null && compobj2.IsGroup())
							{
								Group group6 = (Group)compobj2;
								if (group6 != null)
								{
									rank4.MoveTo = (Rank)group6.Ranks[rank3.MoveTo.Id];
								}
							}
						}
					}
				}
			}
			this.treeWorld.SelectedNode = treeNode;
			this.Preset();
			this.treeWorld.Refresh();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00089FA0 File Offset: 0x000881A0
		private void buttonCopyStageCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStage.NSchedule != 0)
			{
				this.m_ClipboardStageForSchedule = this.m_CurrentStage;
				this.m_ClipboardGroupForSchedule = null;
				this.buttonPasteStageCalendar.Enabled = true;
				this.buttonPasteGroupCalendar.Enabled = true;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00089FDC File Offset: 0x000881DC
		private void buttonPasteStageCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_ClipboardStageForSchedule != null && this.m_CurrentStage != this.m_ClipboardStageForSchedule)
			{
				this.m_CurrentStage.RemoveAllSchedules();
				foreach (object obj in this.m_ClipboardStageForSchedule.Schedules)
				{
					Schedule schedule = (Schedule)obj;
					int day = schedule.Day;
					int leg = schedule.Leg;
					int minGames = schedule.MinGames;
					int maxGames = schedule.MaxGames;
					int time = schedule.Time;
					Schedule schedule2 = new Schedule(this.m_CurrentStage, day, leg, minGames, maxGames, time);
					this.m_CurrentStage.AddSchedule(schedule2);
				}
				this.StageToPanel();
				return;
			}
			if (this.m_ClipboardGroupForSchedule != null && this.m_ClipboardGroupForSchedule.NSchedule != 0)
			{
				this.m_CurrentStage.RemoveAllSchedules();
				foreach (object obj2 in this.m_ClipboardGroupForSchedule.Schedules)
				{
					Schedule schedule3 = (Schedule)obj2;
					int day2 = schedule3.Day;
					int leg2 = schedule3.Leg;
					int minGames2 = schedule3.MinGames;
					int maxGames2 = schedule3.MaxGames;
					int time2 = schedule3.Time;
					Schedule schedule4 = new Schedule(this.m_CurrentStage, day2, leg2, minGames2, maxGames2, time2);
					this.m_CurrentStage.AddSchedule(schedule4);
				}
				this.StageToPanel();
				return;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0008A16C File Offset: 0x0008836C
		private void buttonNewStageLeg_Click(object sender, EventArgs e)
		{
			int num = 7;
			if (this.m_CurrentStageSchedule == null || this.m_CurrentStage.Schedules == null || this.m_CurrentStage.Schedules.Count == 0)
			{
				this.m_CurrentStageSchedule = this.m_CurrentStage.AppendLeg(num);
			}
			else
			{
				this.m_CurrentStageSchedule = this.m_CurrentStage.Schedules.DuplicatetLeg(this.m_CurrentStageSchedule.Leg, num);
			}
			this.StageToPanel();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0008A1DE File Offset: 0x000883DE
		private void buttonDeleteStageLeg_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStageSchedule == null)
			{
				return;
			}
			this.m_CurrentStage.Schedules.RemoveLeg(this.m_CurrentStageSchedule.Leg);
			this.m_CurrentStageSchedule = null;
			this.StageToPanel();
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0008A212 File Offset: 0x00088412
		private void buttonStageAddTime_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStage != null && this.m_CurrentStageSchedule != null)
			{
				this.m_CurrentStage.CloneSchedule(this.m_CurrentStageSchedule, 100);
				this.StageToPanel();
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0008A23D File Offset: 0x0008843D
		private void buttonStageRemoveTime_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStage != null && this.m_CurrentStageSchedule != null)
			{
				this.m_CurrentStage.DeleteSchedule(this.m_CurrentStageSchedule);
				this.m_CurrentStageSchedule = null;
				this.StageToPanel();
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0008A26D File Offset: 0x0008846D
		private void buttonCopyGroupCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup.NSchedule > 0)
			{
				this.m_ClipboardStageForSchedule = null;
				this.m_ClipboardGroupForSchedule = this.m_CurrentGroup;
				this.buttonPasteStageCalendar.Enabled = true;
				this.buttonPasteGroupCalendar.Enabled = true;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0008A2A8 File Offset: 0x000884A8
		private void buttonPasteGroupCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_ClipboardStageForSchedule != null && this.m_ClipboardStageForSchedule.NSchedule != 0)
			{
				this.m_CurrentGroup.RemoveAllSchedules();
				foreach (object obj in this.m_ClipboardStageForSchedule.Schedules)
				{
					Schedule schedule = (Schedule)obj;
					int day = schedule.Day;
					int leg = schedule.Leg;
					int minGames = schedule.MinGames;
					int maxGames = schedule.MaxGames;
					int time = schedule.Time;
					Schedule schedule2 = new Schedule(this.m_CurrentGroup, day, leg, minGames, maxGames, time);
					this.m_CurrentGroup.AddSchedule(schedule2);
				}
				this.GroupToPanel();
				return;
			}
			if (this.m_ClipboardGroupForSchedule != null && this.m_ClipboardGroupForSchedule != this.m_CurrentGroup)
			{
				this.m_CurrentGroup.RemoveAllSchedules();
				foreach (object obj2 in this.m_ClipboardGroupForSchedule.Schedules)
				{
					Schedule schedule3 = (Schedule)obj2;
					int day2 = schedule3.Day;
					int leg2 = schedule3.Leg;
					int minGames2 = schedule3.MinGames;
					int maxGames2 = schedule3.MaxGames;
					int time2 = schedule3.Time;
					Schedule schedule4 = new Schedule(this.m_CurrentGroup, day2, leg2, minGames2, maxGames2, time2);
					this.m_CurrentGroup.AddSchedule(schedule4);
				}
				this.GroupToPanel();
				return;
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0008A438 File Offset: 0x00088638
		private void buttonGroupAddTime_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup != null && this.m_CurrentGroupSchedule != null)
			{
				this.m_CurrentGroup.CloneSchedule(this.m_CurrentGroupSchedule, 100);
				this.GroupToPanel();
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0008A463 File Offset: 0x00088663
		private void buttonGroupRemoveTime_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup != null && this.m_CurrentGroupSchedule != null)
			{
				this.m_CurrentGroup.DeleteSchedule(this.m_CurrentGroupSchedule);
				this.m_CurrentGroupSchedule = null;
				this.GroupToPanel();
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0008A494 File Offset: 0x00088694
		private void buttonAddRule_Click(object sender, EventArgs e)
		{
			Task task = new Task("start", "", this.m_CurrentGroup.Id, 0, 0, 0);
			task.Group = this.m_CurrentGroup;
			this.m_CurrentGroup.AddTask(task);
			this.GroupToPanel();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0008A4DE File Offset: 0x000886DE
		private void buttonRemoveRule_Click(object sender, EventArgs e)
		{
			this.m_CurrentGroup.RemoveLastTask("start");
			this.GroupToPanel();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0008A4F7 File Offset: 0x000886F7
		private void checkInfoChamp_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentGroup.Settings.m_info_slot_champ = (this.checkInfoChamp.Checked ? 1 : (-1));
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0008A524 File Offset: 0x00088724
		private void checkInfoPossibleRelegation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericPossibleRelegationMin.Visible = (this.numericPossibleRelegationMax.Visible = this.checkInfoPossibleRelegation.Checked);
			if (this.checkInfoPossibleRelegation.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoSlotRelegPoss(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericPossibleRelegationMin.Value = num;
				this.numericPossibleRelegationMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoSlotRelegPoss(num3, num4);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0008A5C8 File Offset: 0x000887C8
		private void checkInfoRelegation_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericRelegationMin.Visible = (this.numericRelegationMax.Visible = this.checkInfoRelegation.Checked);
			if (this.checkInfoRelegation.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoSlotReleg(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericRelegationMin.Value = num;
				this.numericRelegationMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoSlotReleg(num3, num4);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0008A66C File Offset: 0x0008886C
		private void checkInfoPromotion_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericPromotionMin.Visible = (this.numericPromotionMax.Visible = this.checkInfoPromotion.Checked);
			if (this.checkInfoPromotion.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoSlotPromo(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericPromotionMin.Value = num;
				this.numericPromotionMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoSlotPromo(num3, num4);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0008A710 File Offset: 0x00088910
		private void checkInfoPossiblePromotion_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.numericPossiblePromotionMin.Visible = (this.numericPossiblePromotionMax.Visible = this.checkInfoPossiblePromotion.Checked);
			if (this.checkInfoPossiblePromotion.Checked)
			{
				int num;
				int num2;
				this.m_CurrentGroup.Settings.GetInfoSlotPromoPoss(out num, out num2);
				if (num <= 0 || num2 <= 0)
				{
					num2 = (num = 1);
				}
				this.numericPossiblePromotionMin.Value = num;
				this.numericPossiblePromotionMax.Value = num2;
				return;
			}
			int num3 = -1;
			int num4 = -1;
			this.m_CurrentGroup.Settings.SetInfoSlotPromoPoss(num3, num4);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0008A7B4 File Offset: 0x000889B4
		private void numericPossibleRelegationMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPossibleRelegationMin.Value;
			int num2 = (int)this.numericPossibleRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotRelegPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotRelegPoss(num, num2))
			{
				this.numericPossibleRelegationMin.Value = num3;
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0008A830 File Offset: 0x00088A30
		private void numericRelegationMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericRelegationMin.Value;
			int num2 = (int)this.numericRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotReleg(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotReleg(num, num2))
			{
				this.numericRelegationMin.Value = num3;
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0008A8AC File Offset: 0x00088AAC
		private void numericPromotionMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPromotionMin.Value;
			int num2 = (int)this.numericPromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotPromo(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotPromo(num, num2))
			{
				this.numericPromotionMin.Value = num3;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0008A928 File Offset: 0x00088B28
		private void numericPossiblePromotionMin_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPossiblePromotionMin.Value;
			int num2 = (int)this.numericPossiblePromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotPromoPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotPromoPoss(num, num2))
			{
				this.numericPossiblePromotionMin.Value = num3;
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0008A9A4 File Offset: 0x00088BA4
		private void numericPossibleRelegationMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPossibleRelegationMin.Value;
			int num2 = (int)this.numericPossibleRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotRelegPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotRelegPoss(num, num2))
			{
				this.numericPossibleRelegationMax.Value = num4;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0008AA20 File Offset: 0x00088C20
		private void numericRelegationMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericRelegationMin.Value;
			int num2 = (int)this.numericRelegationMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotReleg(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotReleg(num, num2))
			{
				this.numericRelegationMax.Value = num4;
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0008AA9C File Offset: 0x00088C9C
		private void numericPromotionMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPromotionMin.Value;
			int num2 = (int)this.numericPromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotPromo(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotPromo(num, num2))
			{
				this.numericPromotionMax.Value = num4;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0008AB18 File Offset: 0x00088D18
		private void numericPossiblePromotionMax_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			int num = (int)this.numericPossiblePromotionMin.Value;
			int num2 = (int)this.numericPossiblePromotionMax.Value;
			int num3;
			int num4;
			this.m_CurrentGroup.Settings.GetInfoSlotPromoPoss(out num3, out num4);
			if (num == num3 && num2 == num4)
			{
				return;
			}
			if (!this.m_CurrentGroup.Settings.SetInfoSlotPromoPoss(num, num2))
			{
				this.numericPossiblePromotionMax.Value = num4;
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0008AB92 File Offset: 0x00088D92
		private void buttonCleanGroupCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup != null)
			{
				this.m_CurrentGroup.RemoveAllSchedules();
				this.GroupToPanel();
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0008ABAE File Offset: 0x00088DAE
		private void buttonCleanStageCalendar_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStage != null)
			{
				this.m_CurrentStage.RemoveAllSchedules();
				this.StageToPanel();
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0008ABCC File Offset: 0x00088DCC
		private void buttonNewGroupLeg_Click(object sender, EventArgs e)
		{
			int num = 7;
			if (this.m_CurrentGroupSchedule == null || this.m_CurrentGroup.Schedules.Count == 0)
			{
				this.m_CurrentGroupSchedule = this.m_CurrentGroup.AppendLeg(num);
			}
			else
			{
				this.m_CurrentGroupSchedule = this.m_CurrentGroup.Schedules.DuplicatetLeg(this.m_CurrentGroupSchedule.Leg, num);
			}
			this.GroupToPanel();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0008AC31 File Offset: 0x00088E31
		private void buttonRemoveGroupLeg_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroupSchedule == null)
			{
				return;
			}
			this.m_CurrentGroup.Schedules.RemoveLeg(this.m_CurrentGroupSchedule.Leg);
			this.m_CurrentGroupSchedule = null;
			this.GroupToPanel();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0008AC65 File Offset: 0x00088E65
		private void checkMatchReplay_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_schedule_matchreplay = (this.checkMatchReplay.Checked ? 1 : (-1));
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0008AC91 File Offset: 0x00088E91
		private void checkMaxteamsassoc_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_maxteamsassoc = (this.checkMaxteamsassoc.Checked ? 1 : (-1));
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0008ACC0 File Offset: 0x00088EC0
		private void numericStageRef_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStage.Settings.Advance_maxteamsstageref != (int)this.numericStageRef.Value)
			{
				this.m_CurrentStage.Settings.Advance_maxteamsstageref = (int)this.numericStageRef.Value;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0008AD18 File Offset: 0x00088F18
		private void checkClausuraSchedule_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_schedule_reversed = (this.checkClausuraSchedule.Checked ? 1 : (-1));
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0008AD44 File Offset: 0x00088F44
		private void probUpDown_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			string text = (string)numericUpDown.Tag;
			if (text == null)
			{
				return;
			}
			int num = Convert.ToInt32(text.Substring(1));
			if (text.StartsWith("R"))
			{
				this.m_CurrentNation.RainProb[num] = (int)numericUpDown.Value;
				return;
			}
			if (text.StartsWith("S"))
			{
				this.m_CurrentNation.SnowProb[num] = (int)numericUpDown.Value;
				return;
			}
			if (text.StartsWith("O"))
			{
				this.m_CurrentNation.OvercastProb[num] = (int)numericUpDown.Value;
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0008ADF0 File Offset: 0x00088FF0
		private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			ComboBox comboBox = (ComboBox)sender;
			string text = (string)comboBox.Tag;
			if (text == null)
			{
				return;
			}
			int num = Convert.ToInt32(text.Substring(1));
			if (text.StartsWith("U"))
			{
				this.m_CurrentNation.SunsetTime[num] = this.ConvertIndexToTime(comboBox.SelectedIndex);
				return;
			}
			if (text.StartsWith("N"))
			{
				this.m_CurrentNation.DarkTime[num] = this.ConvertIndexToTime(comboBox.SelectedIndex);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0008AE78 File Offset: 0x00089078
		private int ConvertIndexToTime(int index)
		{
			switch (index)
			{
			case 0:
				return 1600;
			case 1:
				return 1630;
			case 2:
				return 1700;
			case 3:
				return 1730;
			case 4:
				return 1800;
			case 5:
				return 1830;
			case 6:
				return 1900;
			case 7:
				return 1930;
			case 8:
				return 2000;
			case 9:
				return 2030;
			case 10:
				return 2100;
			default:
				return 0;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0008AEFC File Offset: 0x000890FC
		private void numericBall_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentTrophy == null)
			{
				return;
			}
			this.m_CurrentTrophy.ballid = (int)this.numericBall.Value;
			int num = (int)this.numericBall.Value;
			if (num >= 0)
			{
				this.pictureBall.BackgroundImage = Ball.GetBallPicture(num);
				return;
			}
			this.pictureBall.BackgroundImage = null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0008AF6C File Offset: 0x0008916C
		private void buttonReplicateTrophy128_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DTrophy256.CurrentBitmap;
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Bitmap bitmap = new Bitmap(128, 128, PixelFormat.Format32bppPArgb);
			Rectangle rectangle2 = new Rectangle(0, 0, 128, 128);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			this.m_CurrentTrophy.SetTrophy128(bitmap);
			this.viewer2DTrophy128.CurrentBitmap = bitmap;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0008AFE0 File Offset: 0x000891E0
		private void buttonShow3DModel_Click(object sender, EventArgs e)
		{
			this.Show3DTrophy();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0008AFE8 File Offset: 0x000891E8
		private void buttonImport3DModel_Click(object sender, EventArgs e)
		{
			string text = FifaEnvironment.BrowseAndCheckModel(ref this.m_TrophyCurrentFolder, "Open 3D Trophy Model file", "3D trophy model files (*.rx3)|trophy_*.rx3");
			if (text == null)
			{
				return;
			}
			this.m_CurrentTrophy.SetModel(text);
			this.ReloadTrophy(this.m_CurrentTrophy);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0008B028 File Offset: 0x00089228
		private void buttonExport3DModel_Click(object sender, EventArgs e)
		{
			string text = this.m_CurrentTrophy.ModelFileName();
			if (text != null)
			{
				FifaEnvironment.AskAndExportFromZdata(text, ref this.m_TrophyCurrentFolder);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0008B051 File Offset: 0x00089251
		private void buttonRemove3DModel_Click(object sender, EventArgs e)
		{
			this.m_CurrentTrophy.DeleteModel();
			this.ReloadTrophy(this.m_CurrentTrophy);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0008B06B File Offset: 0x0008926B
		private void tabTrophy_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ReloadTrophy(this.m_CurrentTrophy);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0008B07C File Offset: 0x0008927C
		private void labelUpdateTable_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			int num = -1;
			Task task = (Task)label.Tag;
			for (int i = 0; i < this.m_UpdateTableLabels.Length; i++)
			{
				if (label == this.m_UpdateTableLabels[i])
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return;
			}
			Rank rank;
			if (task != null && task.Group != null && task.Group.Ranks != null && task.Parameter2 < task.Group.Ranks.Count)
			{
				rank = (Rank)task.Group.Ranks[task.Parameter2];
			}
			else
			{
				rank = new Rank((Group)((Stage)this.m_CurrentTrophy.Stages[0]).Groups[0], 1);
			}
			this.m_RankingRuleDialog.Rank = rank;
			if (this.m_RankingRuleDialog.ShowDialog() == DialogResult.OK)
			{
				Task task2 = new Task("end", "UpdateTable", this.m_CurrentTrophy.Id, this.m_RankingRuleDialog.Rank.Group.Id, this.m_RankingRuleDialog.Rank.Id, num + 1);
				task2.LinkTrophy(this.m_CurrentTrophy);
				task2.Group = this.m_RankingRuleDialog.Rank.Group;
				label.Tag = task2;
				if (task == null)
				{
					this.m_CurrentTrophy.AddTask(task2);
				}
				else
				{
					this.m_CurrentTrophy.ReplaceTask(task, task2);
				}
			}
			this.TrophyRankingToPanel();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0008B200 File Offset: 0x00089400
		private void numericUpdateTableEntries_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.numericUpdateTableEntries.Value == this.m_NUpdateTableLabels)
			{
				return;
			}
			for (int i = 0; i < 24; i++)
			{
				this.m_InitTeamPanel[i].Visible = i < this.numericUpdateTableEntries.Value;
			}
			int num = (int)this.numericUpdateTableEntries.Value;
			if (num < this.m_NUpdateTableLabels)
			{
				for (int j = num; j < this.m_NUpdateTableLabels; j++)
				{
					Task task = (Task)this.m_UpdateTableLabels[j].Tag;
					if (task != null)
					{
						this.m_CurrentTrophy.RemoveTask(task);
						this.m_UpdateTableLabels[j].Tag = null;
						this.m_UpdateTableLabels[j].Text = null;
					}
				}
			}
			else
			{
				for (int k = this.m_NUpdateTableLabels; k < num; k++)
				{
					this.m_UpdateTableLabels[k].Tag = null;
					this.m_UpdateTableLabels[k].Text = null;
				}
			}
			this.m_NUpdateTableLabels = num;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0008B30A File Offset: 0x0008950A
		private void numericInternationalFirstYear_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_schedule_year_start = (int)this.numericInternationalFirstYear.Value;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0008B335 File Offset: 0x00089535
		private void numericInternationalPeriodicity_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_schedule_year_offset = (int)this.numericInternationalPeriodicity.Value;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0008B360 File Offset: 0x00089560
		private void checkClearLeagueStats_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.comboLeagueStats.Visible = this.checkClearLeagueStats.Checked || this.checkUpdateLeagueStats.Checked || this.checkUpdateLeagueTable.Checked;
			if (this.checkClearLeagueStats.Checked)
			{
				League league = (League)this.comboLeagueStats.SelectedItem;
				if (league != null)
				{
					Task task = new Task("start", "ClearLeagueStats", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num = this.m_CurrentStage.SearchTaskIndex("start", "ClearLeagueStats", -1, -1, -1);
					if (num >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num);
						return;
					}
					this.m_CurrentStage.AddTask(task);
					return;
				}
			}
			else
			{
				this.m_CurrentStage.RemoveTask("start", "ClearLeagueStats", -1, -1, -1);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0008B454 File Offset: 0x00089654
		private void checkUpdateLeagueStats_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.comboLeagueStats.Visible = this.checkClearLeagueStats.Checked || this.checkUpdateLeagueStats.Checked || this.checkUpdateLeagueTable.Checked;
			if (this.checkUpdateLeagueStats.Checked)
			{
				League league = (League)this.comboLeagueStats.SelectedItem;
				if (league != null)
				{
					Task task = new Task("end", "UpdateLeagueStats", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num = this.m_CurrentStage.SearchTaskIndex("end", "UpdateLeagueStats", -1, -1, -1);
					if (num >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num);
						return;
					}
					this.m_CurrentStage.AddTask(task);
					return;
				}
			}
			else
			{
				this.m_CurrentStage.RemoveTask("end", "UpdateLeagueStats", -1, -1, -1);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0008B548 File Offset: 0x00089748
		private void checkUpdateLeagueTable_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.comboLeagueStats.Visible = this.checkClearLeagueStats.Checked || this.checkUpdateLeagueStats.Checked || this.checkUpdateLeagueTable.Checked;
			if (this.checkUpdateLeagueTable.Checked)
			{
				League league = (League)this.comboLeagueStats.SelectedItem;
				if (league != null)
				{
					Task task = new Task("end", "UpdateLeagueTable", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num = this.m_CurrentStage.SearchTaskIndex("end", "UpdateLeagueTable", -1, -1, -1);
					if (num >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num);
						return;
					}
					this.m_CurrentStage.AddTask(task);
					return;
				}
			}
			else
			{
				this.m_CurrentStage.RemoveTask("end", "UpdateLeagueTable", -1, -1, -1);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0008B63C File Offset: 0x0008983C
		private void comboLeagueStats_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			League league = (League)this.comboLeagueStats.SelectedItem;
			if (league != null)
			{
				if (this.checkClearLeagueStats.Checked)
				{
					Task task = new Task("start", "ClearLeagueStats", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num = this.m_CurrentStage.SearchTaskIndex("start", "ClearLeagueStats", -1, -1, -1);
					if (num >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num);
					}
					else
					{
						this.m_CurrentStage.AddTask(task);
					}
				}
				else
				{
					this.m_CurrentStage.RemoveTask("start", "ClearLeagueStats", -1, -1, -1);
				}
				if (this.checkUpdateLeagueStats.Checked)
				{
					Task task = new Task("end", "UpdateLeagueStats", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num2 = this.m_CurrentStage.SearchTaskIndex("end", "UpdateLeagueStats", -1, -1, -1);
					if (num2 >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num2);
					}
					else
					{
						this.m_CurrentStage.AddTask(task);
					}
				}
				else
				{
					this.m_CurrentStage.RemoveTask("end", "UpdateLeagueStats", -1, -1, -1);
				}
				if (this.checkUpdateLeagueTable.Checked)
				{
					Task task = new Task("end", "UpdateLeagueTable", this.m_CurrentStage.Id, league.Id, 0, 0);
					task.LinkStage(this.m_CurrentStage);
					int num3 = this.m_CurrentStage.SearchTaskIndex("end", "UpdateLeagueTable", -1, -1, -1);
					if (num3 >= 0)
					{
						this.m_CurrentStage.ReplaceTask(task, num3);
						return;
					}
					this.m_CurrentStage.AddTask(task);
					return;
				}
				else
				{
					this.m_CurrentStage.RemoveTask("end", "UpdateLeagueTable", -1, -1, -1);
				}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0008B820 File Offset: 0x00089A20
		private void checkStageStandingsRules_CheckedChanged(object sender, EventArgs e)
		{
			this.comboStageStandingRules.Visible = this.checkStageStandingsRules.Checked;
			if (this.checkStageStandingsRules.Checked)
			{
				this.m_CurrentStage.Settings.m_StandingsSort = this.comboStageStandingRules.SelectedIndex;
				return;
			}
			this.m_CurrentStage.Settings.m_StandingsSort = -1;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0008B87D File Offset: 0x00089A7D
		private void comboStageStandingRules_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboStageStandingRules.SelectedIndex >= 0)
			{
				this.m_CurrentStage.Settings.m_StandingsSort = this.comboStageStandingRules.SelectedIndex;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0008B8B1 File Offset: 0x00089AB1
		private void comboTrophyStartMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.comboTrophyStartMonth.SelectedItem != null)
			{
				this.m_CurrentTrophy.Settings.m_schedule_seasonstartmonth = (string)this.comboTrophyStartMonth.SelectedItem;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0008B8E9 File Offset: 0x00089AE9
		private void checkRandomDrawEvent_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_advance_random_draw_event = (this.checkRandomDrawEvent.Checked ? 1 : (-1));
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0008B918 File Offset: 0x00089B18
		private void tabCompetitions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this.m_LockTree)
			{
				this.m_LockTree = true;
				if (this.tabCompetitions.SelectedTab == this.pageWorld)
				{
					this.SelectWorldTreeNode(this.m_CurrentWorld);
				}
				else if (this.tabCompetitions.SelectedTab == this.pageConfederation)
				{
					this.SelectWorldTreeNode(this.m_CurrentConfederation);
				}
				else if (this.tabCompetitions.SelectedTab == this.pageNation)
				{
					this.SelectWorldTreeNode(this.m_CurrentNation);
				}
				else if (this.tabCompetitions.SelectedTab == this.pageTrophy)
				{
					this.SelectWorldTreeNode(this.m_CurrentTrophy);
				}
				else if (this.tabCompetitions.SelectedTab == this.pageStage)
				{
					this.SelectWorldTreeNode(this.m_CurrentStage);
				}
				else if (this.tabCompetitions.SelectedTab == this.pageGroup)
				{
					this.SelectWorldTreeNode(this.m_CurrentGroup);
				}
				this.m_LockTree = false;
			}
			this.CompetitionToPanel();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0008BA14 File Offset: 0x00089C14
		private void CompetitionToPanel()
		{
			if (this.tabCompetitions.SelectedTab == this.pageWorld)
			{
				this.WorldToPanel();
				return;
			}
			if (this.tabCompetitions.SelectedTab == this.pageConfederation)
			{
				this.ConfederationToPanel();
				return;
			}
			if (this.tabCompetitions.SelectedTab == this.pageNation)
			{
				this.NationToPanel();
				return;
			}
			if (this.tabCompetitions.SelectedTab == this.pageTrophy)
			{
				this.TrophyToPanel();
				return;
			}
			if (this.tabCompetitions.SelectedTab == this.pageStage)
			{
				this.StageToPanel();
				return;
			}
			if (this.tabCompetitions.SelectedTab == this.pageGroup)
			{
				this.GroupToPanel();
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0008BABC File Offset: 0x00089CBC
		private void buttongroupSortLegs_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentGroup != null && this.m_CurrentGroup.Schedules != null)
			{
				this.m_CurrentGroup.Schedules.RenumberLegs();
				this.GroupToPanel();
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0008BAE9 File Offset: 0x00089CE9
		private void buttonStageSortLegs_Click(object sender, EventArgs e)
		{
			if (this.m_CurrentStage != null && this.m_CurrentStage.Schedules != null)
			{
				this.m_CurrentStage.Schedules.RenumberLegs();
				this.StageToPanel();
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0008BB18 File Offset: 0x00089D18
		private void checkScheduleUseDates_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.checkScheduleUseDates.Checked == (this.m_CurrentTrophy.Settings.m_schedule_use_dates_comp != -1))
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_schedule_use_dates_comp = (this.checkScheduleUseDates.Checked ? FifaEnvironment.CompetitionObjects.GetInternationalFriendlyId() : (-1));
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0008BB7C File Offset: 0x00089D7C
		private void numericKeepPointsStageRef_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			if (this.m_CurrentStage.Settings.Advance_pointskeep != (int)this.numericKeepPointsStageRef.Value)
			{
				this.m_CurrentStage.Settings.Advance_pointskeep = (int)this.numericKeepPointsStageRef.Value;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0008BBD4 File Offset: 0x00089DD4
		private void buttonReplicateTropy_Click(object sender, EventArgs e)
		{
			Bitmap currentBitmap = this.viewer2DTrophy256.CurrentBitmap;
			Rectangle rectangle = new Rectangle(0, 0, 256, 256);
			Bitmap bitmap = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
			Rectangle rectangle2 = new Rectangle(0, 0, 192, 192);
			GraphicUtil.RemapRectangle(currentBitmap, rectangle, bitmap, rectangle2);
			this.m_CurrentTrophy.SetTrophy(bitmap);
			this.viewer2DTrophy.CurrentBitmap = bitmap;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0008BC48 File Offset: 0x00089E48
		private void checkLowCelebrationLevel_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentTrophy.Settings.m_match_celebrationlevel = (this.checkLowCelebrationLevel.Checked ? "LOW" : null);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0008BC78 File Offset: 0x00089E78
		private void checkCanUseFancards_CheckedChanged(object sender, EventArgs e)
		{
			if (this.m_Locked)
			{
				return;
			}
			this.m_CurrentStage.Settings.m_match_canusefancards = (this.checkCanUseFancards.Checked ? "on" : null);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0008BCA8 File Offset: 0x00089EA8
		private void buttonCreatePatch_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(33);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "cmc files (*.cmc)|*.cmc";
			saveFileDialog.InitialDirectory = FifaEnvironment.TempFolder;
			saveFileDialog.FileName = this.m_CurrentCompobj.ToString();
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.Title = "Save Creation Master Competition-Patch";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return;
			}
			this.m_PatchFileName = saveFileDialog.FileName;
			saveFileDialog.Dispose();
			this.m_TempFolder = FifaEnvironment.TempFolder + "\\Patch\\";
			if (Directory.Exists(this.m_TempFolder))
			{
				Directory.Delete(this.m_TempFolder, true);
				while (Directory.Exists(this.m_TempFolder))
				{
				}
			}
			Directory.CreateDirectory(this.m_TempFolder);
			this.m_PatchCompetitionFileNames = CompobjList.GetFileNames();
			this.m_PatchStreamWriters = new StreamWriter[this.m_PatchCompetitionFileNames.Length];
			for (int i = 0; i < this.m_PatchCompetitionFileNames.Length; i++)
			{
				this.m_PatchCompetitionFileNames[i] = this.m_TempFolder + Path.GetFileName(this.m_PatchCompetitionFileNames[i]);
				this.m_PatchStreamWriters[i] = new StreamWriter(this.m_PatchCompetitionFileNames[i]);
			}
			if (this.m_CurrentCompobj.IsNation())
			{
				this.CreateNationPatch();
			}
			else if (this.m_CurrentCompobj.IsTrophy())
			{
				this.CreateTrophyPatch();
			}
			else if (this.m_CurrentCompobj.IsConfederation())
			{
				this.CreateConfederationPatch();
			}
			for (int j = 0; j < this.m_PatchStreamWriters.Length; j++)
			{
				this.m_PatchStreamWriters[j].Close();
			}
			ZipOutputStream zipOutputStream = new ZipOutputStream(File.Create(this.m_PatchFileName));
			zipOutputStream.SetLevel(8);
			string[] files = Directory.GetFiles(this.m_TempFolder, "*.*", SearchOption.AllDirectories);
			if (files == null)
			{
				return;
			}
			int length = this.m_TempFolder.Length;
			foreach (string text in files)
			{
				string text2 = text.Substring(length);
				FileStream fileStream = File.OpenRead(text);
				this.AddStreamToZip(zipOutputStream, fileStream, text2);
				fileStream.Close();
			}
			zipOutputStream.Finish();
			zipOutputStream.Close();
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0008BEC4 File Offset: 0x0008A0C4
		private void buttonLoadPatch_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(33);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Title = "Open Creation Master Competition-Patch file";
			openFileDialog.Filter = "Creation Master Competition-Patch (*.cmc)|*.cmc";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return;
			}
			string fileName = openFileDialog.FileName;
			openFileDialog.Dispose();
			if (!File.Exists(fileName))
			{
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			this.m_TempFolder = FifaEnvironment.TempFolder + "\\Patch\\";
			if (Directory.Exists(this.m_TempFolder))
			{
				Directory.Delete(this.m_TempFolder, true);
			}
			Directory.CreateDirectory(this.m_TempFolder);
			Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			new ZipFile(fileName);
			ZipInputStream zipInputStream = new ZipInputStream(stream);
			this.ZipExtractAllFiles(zipInputStream, this.m_TempFolder);
			zipInputStream.Close();
			this.m_PatchCompetitionFileNames = CompobjList.GetFileNames();
			for (int i = 0; i < this.m_PatchCompetitionFileNames.Length; i++)
			{
				this.m_PatchCompetitionFileNames[i] = this.m_TempFolder + Path.GetFileName(this.m_PatchCompetitionFileNames[i]);
			}
			CompobjList compobjList = new CompobjList();
			if (compobjList.LoadFromCompobj(this.m_PatchCompetitionFileNames[0], this.m_CurrentCompobj))
			{
				compobjList.LoadFromSettings(this.m_PatchCompetitionFileNames[1]);
				compobjList.LoadFromStandings(this.m_PatchCompetitionFileNames[2]);
				compobjList.LoadFromAdvancement(this.m_PatchCompetitionFileNames[3]);
				compobjList.LoadFromSchedule(this.m_PatchCompetitionFileNames[4]);
				compobjList.LoadFromWeather(this.m_PatchCompetitionFileNames[5]);
				compobjList.LoadFromTasks(this.m_PatchCompetitionFileNames[6]);
				compobjList.LoadFromInitteams(this.m_PatchCompetitionFileNames[7]);
				compobjList.LoadFromInternationals(this.m_PatchCompetitionFileNames[9]);
				compobjList.Link();
				this.m_CurrentWorld.Renumber(0);
				for (int j = 0; j < compobjList.Count; j++)
				{
					FifaEnvironment.CompetitionObjects.Add(compobjList[j]);
				}
				this.WorldStructureToPanel();
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0008C0D4 File Offset: 0x0008A2D4
		private void CreateConfederationPatch()
		{
			this.m_CurrentConfederation.SaveRecursivelyToCompobj(this.m_PatchStreamWriters[0]);
			this.m_CurrentConfederation.SaveRecursivelyToSettings(this.m_PatchStreamWriters[1]);
			this.m_CurrentConfederation.SaveRecursivelyToStandings(this.m_PatchStreamWriters[2]);
			this.m_CurrentConfederation.SaveRecursivelyToAdvancement(this.m_PatchStreamWriters[3]);
			this.m_CurrentConfederation.SaveRecursivelyToSchedule(this.m_PatchStreamWriters[4]);
			this.m_CurrentConfederation.SaveRecursivelyToWeather(this.m_PatchStreamWriters[5]);
			this.m_CurrentConfederation.SaveRecursivelyToTasks(this.m_PatchStreamWriters[6]);
			this.m_CurrentConfederation.SaveRecursivelyToInitteams(this.m_PatchStreamWriters[7]);
			this.m_CurrentConfederation.SaveRecursivelyToCompids(this.m_PatchStreamWriters[8]);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0008C198 File Offset: 0x0008A398
		private void CreateNationPatch()
		{
			this.m_CurrentNation.SaveRecursivelyToCompobj(this.m_PatchStreamWriters[0]);
			this.m_CurrentNation.SaveRecursivelyToSettings(this.m_PatchStreamWriters[1]);
			this.m_CurrentNation.SaveRecursivelyToStandings(this.m_PatchStreamWriters[2]);
			this.m_CurrentNation.SaveRecursivelyToAdvancement(this.m_PatchStreamWriters[3]);
			this.m_CurrentNation.SaveRecursivelyToSchedule(this.m_PatchStreamWriters[4]);
			this.m_CurrentNation.SaveRecursivelyToWeather(this.m_PatchStreamWriters[5]);
			this.m_CurrentNation.SaveRecursivelyToTasks(this.m_PatchStreamWriters[6]);
			this.m_CurrentNation.SaveRecursivelyToInitteams(this.m_PatchStreamWriters[7]);
			this.m_CurrentNation.SaveRecursivelyToCompids(this.m_PatchStreamWriters[8]);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0008C25C File Offset: 0x0008A45C
		private void CreateTrophyPatch()
		{
			this.m_CurrentTrophy.SaveRecursivelyToCompobj(this.m_PatchStreamWriters[0]);
			this.m_CurrentTrophy.SaveRecursivelyToSettings(this.m_PatchStreamWriters[1]);
			this.m_CurrentTrophy.SaveRecursivelyToStandings(this.m_PatchStreamWriters[2]);
			this.m_CurrentTrophy.SaveRecursivelyToAdvancement(this.m_PatchStreamWriters[3]);
			this.m_CurrentTrophy.SaveRecursivelyToSchedule(this.m_PatchStreamWriters[4]);
			this.m_CurrentTrophy.SaveRecursivelyToWeather(this.m_PatchStreamWriters[5]);
			this.m_CurrentTrophy.SaveRecursivelyToTasks(this.m_PatchStreamWriters[6]);
			this.m_CurrentTrophy.SaveRecursivelyToInitteams(this.m_PatchStreamWriters[7]);
			this.m_CurrentTrophy.SaveRecursivelyToCompids(this.m_PatchStreamWriters[8]);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void LoadNationPatch()
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000104DD File Offset: 0x0000E6DD
		private void LoadTrophyPatch()
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0008C320 File Offset: 0x0008A520
		private bool AddStreamToZip(ZipOutputStream zip, Stream inputStream, string fileName)
		{
			if (inputStream == null)
			{
				return false;
			}
			Crc32 crc = new Crc32();
			byte[] array = new byte[inputStream.Length];
			inputStream.Read(array, 0, array.Length);
			ZipEntry zipEntry = new ZipEntry(fileName);
			zipEntry.DateTime = DateTime.Now;
			zipEntry.Size = inputStream.Length;
			crc.Reset();
			crc.Update(array);
			zipEntry.Crc = crc.Value;
			zip.PutNextEntry(zipEntry);
			zip.Write(array, 0, array.Length);
			return true;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0008C39C File Offset: 0x0008A59C
		private void ZipExtractAllFiles(ZipInputStream zip, string exportFolder)
		{
			ZipEntry nextEntry;
			while ((nextEntry = zip.GetNextEntry()) != null)
			{
				this.ZipExtractSingleFile(zip, nextEntry, exportFolder);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0008C3C0 File Offset: 0x0008A5C0
		private void ZipExtractSingleFile(ZipInputStream zip, ZipEntry zipEntry, string exportFolder)
		{
			string text = exportFolder + "\\" + Path.GetDirectoryName(zipEntry.Name);
			if (Path.GetFileName(zipEntry.Name) != string.Empty)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				FileStream fileStream = File.Create(exportFolder + "\\" + zipEntry.Name);
				byte[] array = new byte[2048];
				for (;;)
				{
					int num = zip.Read(array, 0, array.Length);
					if (num <= 0)
					{
						break;
					}
					fileStream.Write(array, 0, num);
				}
				fileStream.Close();
			}
		}

		// Token: 0x040007FA RID: 2042
		private bool m_IsLoaded;

		// Token: 0x040007FB RID: 2043
		private CompobjList m_Competitions;

		// Token: 0x040007FC RID: 2044
		private World m_CurrentWorld;

		// Token: 0x040007FD RID: 2045
		private Confederation m_CurrentConfederation;

		// Token: 0x040007FE RID: 2046
		private Nation m_CurrentNation;

		// Token: 0x040007FF RID: 2047
		private Trophy m_CurrentTrophy;

		// Token: 0x04000800 RID: 2048
		private Trophy m_ClipboardTrophy;

		// Token: 0x04000801 RID: 2049
		private Stage m_CurrentStage;

		// Token: 0x04000802 RID: 2050
		private Group m_CurrentGroup;

		// Token: 0x04000803 RID: 2051
		private Compobj m_CurrentCompobj;

		// Token: 0x04000804 RID: 2052
		private Schedule m_CurrentStageSchedule;

		// Token: 0x04000805 RID: 2053
		private Schedule m_CurrentGroupSchedule;

		// Token: 0x04000806 RID: 2054
		private NewIdCreator m_NewIdCreator = new NewIdCreator();

		// Token: 0x04000807 RID: 2055
		private bool m_Locked;

		// Token: 0x04000808 RID: 2056
		private bool m_LockTree;

		// Token: 0x04000809 RID: 2057
		private Label[] m_QRLabels = new Label[64];

		// Token: 0x0400080A RID: 2058
		private Label[] m_AdvanceLabels = new Label[78];

		// Token: 0x0400080B RID: 2059
		private Label[] m_UpdateTableLabels = new Label[24];

		// Token: 0x0400080C RID: 2060
		private int m_NUpdateTableLabels;

		// Token: 0x0400080D RID: 2061
		private ComboBox[] m_SpecialTeamCombos = new ComboBox[4];

		// Token: 0x0400080E RID: 2062
		private ComboBox[] m_StadiumCombos = new ComboBox[12];

		// Token: 0x0400080F RID: 2063
		private QualifyRuleDialog m_QualifyRuleDialog = new QualifyRuleDialog();

		// Token: 0x04000810 RID: 2064
		private AdvanceRuleDialog m_AdvanceRuleDialog = new AdvanceRuleDialog();

		// Token: 0x04000811 RID: 2065
		private RankingRuleDialog m_RankingRuleDialog = new RankingRuleDialog();

		// Token: 0x04000812 RID: 2066
		private NumericUpDown[] m_RainProb = new NumericUpDown[12];

		// Token: 0x04000813 RID: 2067
		private NumericUpDown[] m_SnowProb = new NumericUpDown[12];

		// Token: 0x04000814 RID: 2068
		private NumericUpDown[] m_OvercastProb = new NumericUpDown[12];

		// Token: 0x04000815 RID: 2069
		private NumericUpDown[] m_ClearProb = new NumericUpDown[12];

		// Token: 0x04000816 RID: 2070
		private NumericUpDown[] m_HazyProb = new NumericUpDown[12];

		// Token: 0x04000817 RID: 2071
		private NumericUpDown[] m_CloudyProb = new NumericUpDown[12];

		// Token: 0x04000818 RID: 2072
		private NumericUpDown[] m_FoggyProb = new NumericUpDown[12];

		// Token: 0x04000819 RID: 2073
		private NumericUpDown[] m_ShowersProb = new NumericUpDown[12];

		// Token: 0x0400081A RID: 2074
		private NumericUpDown[] m_FlurriesProb = new NumericUpDown[12];

		// Token: 0x0400081B RID: 2075
		private ComboBox[] m_SunsetTime = new ComboBox[12];

		// Token: 0x0400081C RID: 2076
		private ComboBox[] m_NightTime = new ComboBox[12];

		// Token: 0x0400081D RID: 2077
		private Panel[] m_InitTeamPanel = new Panel[24];

		// Token: 0x0400081E RID: 2078
		private ComboBox[] m_InitTeamCombo = new ComboBox[24];

		// Token: 0x0400081F RID: 2079
		private Nation m_ClipboardNation;

		// Token: 0x04000820 RID: 2080
		private Stage m_ClipboardStageForSchedule;

		// Token: 0x04000821 RID: 2081
		private Group m_ClipboardGroupForSchedule;

		// Token: 0x04000822 RID: 2082
		private Group m_ClipboardGroup;

		// Token: 0x04000823 RID: 2083
		private string m_TrophyCurrentFolder = FifaEnvironment.ExportFolder;

		// Token: 0x04000824 RID: 2084
		private string m_TempFolder;

		// Token: 0x04000825 RID: 2085
		private string m_PatchFileName;

		// Token: 0x04000826 RID: 2086
		private string[] m_PatchCompetitionFileNames;

		// Token: 0x04000827 RID: 2087
		private StreamWriter[] m_PatchStreamWriters;

		// Token: 0x04000828 RID: 2088
		private StreamReader[] m_PatchStreamReaders;
	}
}
