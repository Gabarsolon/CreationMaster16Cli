using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x020000A0 RID: 160
	public partial class UserMessage : Form
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x00056418 File Offset: 0x00054618
		public UserMessage()
		{
			this.InitializeComponent();
			string currentDirectory = Environment.CurrentDirectory;
			string text = CultureInfo.CurrentUICulture.Name.Substring(0, 2);
			string text2 = currentDirectory + "\\" + text;
			this.m_XmlFileName = null;
			if (Directory.Exists(text2))
			{
				string text3 = text2 + "\\Messages.xml";
				if (File.Exists(text3))
				{
					this.m_XmlFileName = text3;
				}
			}
			if (this.m_XmlFileName == null)
			{
				this.m_XmlFileName = currentDirectory + "\\Messages.xml";
			}
			if (File.Exists(this.m_XmlFileName))
			{
				this.setMessages.ReadXml(this.m_XmlFileName);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x000564B8 File Offset: 0x000546B8
		public DialogResult ShowMessage(int id)
		{
			string text = null;
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = text;
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00056558 File Offset: 0x00054758
		public DialogResult ShowMessage(int id, int reference)
		{
			string text = null;
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = text + " Reference: " + reference.ToString();
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00056608 File Offset: 0x00054808
		private void SetUpLook(int id)
		{
			if (id < 1000)
			{
				this.textErrorNumber.Text = "Please select your choice";
				this.pictureBox.Image = this.imageList.Images[3];
			}
			else if (id < 3000)
			{
				this.textErrorNumber.Text = "Warning: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[1];
			}
			else if (id < 5000)
			{
				this.textErrorNumber.Text = "Info: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[2];
			}
			else if (id < 15000)
			{
				this.textErrorNumber.Text = "Error: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[0];
			}
			else
			{
				this.textErrorNumber.Text = "Info";
				this.pictureBox.Image = this.imageList.Images[2];
			}
			this.checkSuppressMessage.Visible = id < 10000;
			this.checkSuppressMessage.Checked = false;
			this.buttonOK.Visible = id >= 1000;
			this.buttonNo.Visible = id < 1000;
			this.buttonYes.Visible = id < 1000;
			this.buttonCancel.Visible = id < 1000;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000567B4 File Offset: 0x000549B4
		public DialogResult ShowMessage(int id, string messageText)
		{
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					string mexText = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = messageText;
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00056850 File Offset: 0x00054A50
		public DialogResult ShowMessage(int id, string messageText, bool merge)
		{
			if (!merge)
			{
				return this.ShowMessage(id, messageText);
			}
			string text = null;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					this.m_CurrentIndex = i;
					break;
				}
			}
			return this.ShowMessage(id, text + "\r\n" + messageText);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000568D4 File Offset: 0x00054AD4
		public void EnableMessages(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId < 10000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00056944 File Offset: 0x00054B44
		public void EnableWarnings(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId < 5000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x000569B4 File Offset: 0x00054BB4
		public void EnableErrors(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId >= 5000 && this.setMessages.DataTableMex[i].MexId < 10000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00006DE3 File Offset: 0x00004FE3
		private void checkSuppressMessage_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00056A41 File Offset: 0x00054C41
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00056A41 File Offset: 0x00054C41
		private void buttonYes_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00056A41 File Offset: 0x00054C41
		private void buttonNo_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x040011B9 RID: 4537
		private int m_CurrentIndex;

		// Token: 0x040011BA RID: 4538
		private string m_XmlFileName;
	}
}
