using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x02000065 RID: 101
	public class Player : IdObject
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002C288 File Offset: 0x0002A488
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0002C28F File Offset: 0x0002A48F
		public static PlayerNames PlayerNames
		{
			get
			{
				return Player.s_PlayerNames;
			}
			set
			{
				Player.s_PlayerNames = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002C297 File Offset: 0x0002A497
		public bool HasSpecificHeadModel
		{
			get
			{
				return this.m_headclasscode == 0;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002C2A2 File Offset: 0x0002A4A2
		public Bitmap EyesTextureBitmap
		{
			get
			{
				return this.m_EyesTextureBitmap;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0002C2AA File Offset: 0x0002A4AA
		public Bitmap[] FaceTextureBitmap
		{
			get
			{
				return this.m_FaceTextureBitmaps;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0002C2B2 File Offset: 0x0002A4B2
		public Bitmap HairColorTextureBitmap
		{
			get
			{
				return this.m_HairColorTextureBitmap;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0002C2BA File Offset: 0x0002A4BA
		public Bitmap HairAlfaTextureBitmap
		{
			get
			{
				return this.m_HairAlfaTextureBitmap;
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0002C2C2 File Offset: 0x0002A4C2
		public Team IsInTopLeague()
		{
			return this.m_PlayingForTeams.IsInTopLeague();
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0002C2CF File Offset: 0x0002A4CF
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0002C2D7 File Offset: 0x0002A4D7
		public string firstname
		{
			get
			{
				return this.m_firstname;
			}
			set
			{
				this.m_firstname = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x0002C2E8 File Offset: 0x0002A4E8
		public string lastname
		{
			get
			{
				return this.m_lastname;
			}
			set
			{
				this.m_lastname = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0002C2F1 File Offset: 0x0002A4F1
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0002C2F9 File Offset: 0x0002A4F9
		public string audioname
		{
			get
			{
				return this.m_audioname;
			}
			set
			{
				this.m_audioname = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0002C302 File Offset: 0x0002A502
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x0002C30A File Offset: 0x0002A50A
		public int commentaryid
		{
			get
			{
				return this.m_commentaryid;
			}
			set
			{
				this.m_commentaryid = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0002C313 File Offset: 0x0002A513
		public string Name
		{
			get
			{
				if (this.m_commonname != null && this.m_commonname != string.Empty)
				{
					return this.m_commonname;
				}
				return this.m_lastname;
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0002C33C File Offset: 0x0002A53C
		public string FastRename(string newName)
		{
			string text = " ";
			string text2 = null;
			string text3 = null;
			if (newName == null)
			{
				return null;
			}
			if (newName.Contains(text))
			{
				int num = newName.IndexOf(' ');
				text2 = newName.Substring(0, num);
				text3 = newName.Substring(num + 1);
				newName = null;
			}
			if (newName == null)
			{
				this.m_firstname = text2;
				this.m_commonname = string.Empty;
				this.m_lastname = text3;
				this.m_playerjerseyname = text3;
				this.m_audioname = text3;
				this.m_commentaryid = -1;
				return text3;
			}
			if (this.m_commonname != null && this.m_commonname != string.Empty)
			{
				string commonname = this.m_commonname;
				this.m_commonname = newName;
				this.m_playerjerseyname = this.m_commonname;
				this.m_audioname = this.m_commonname;
				this.m_commentaryid = -1;
				if (this.m_firstname == commonname)
				{
					this.m_firstname = this.m_commonname;
				}
				if (this.m_lastname == commonname)
				{
					this.m_lastname = this.m_commonname;
				}
				return this.m_commonname;
			}
			string lastname = this.m_lastname;
			this.m_lastname = newName;
			this.m_commonname = string.Empty;
			this.m_playerjerseyname = this.m_lastname;
			this.m_audioname = this.m_lastname;
			this.m_commentaryid = -1;
			return this.m_lastname;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0002C476 File Offset: 0x0002A676
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0002C47E File Offset: 0x0002A67E
		public string commonname
		{
			get
			{
				return this.m_commonname;
			}
			set
			{
				this.m_commonname = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002C487 File Offset: 0x0002A687
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0002C48F File Offset: 0x0002A68F
		public string playerjerseyname
		{
			get
			{
				return this.m_playerjerseyname;
			}
			set
			{
				this.m_playerjerseyname = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0002C498 File Offset: 0x0002A698
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		public int firstnameid
		{
			get
			{
				return this.m_firstnameid;
			}
			set
			{
				this.m_firstnameid = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0002C4A9 File Offset: 0x0002A6A9
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0002C4B1 File Offset: 0x0002A6B1
		public int lastnameid
		{
			get
			{
				return this.m_lastnameid;
			}
			set
			{
				this.m_lastnameid = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0002C4BA File Offset: 0x0002A6BA
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0002C4C2 File Offset: 0x0002A6C2
		public int commonnameid
		{
			get
			{
				return this.m_commonnameid;
			}
			set
			{
				this.m_commonnameid = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0002C4CB File Offset: 0x0002A6CB
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0002C4D3 File Offset: 0x0002A6D3
		public int playerjerseynameid
		{
			get
			{
				return this.m_playerjerseynameid;
			}
			set
			{
				this.m_playerjerseynameid = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		public DateTime birthdate
		{
			get
			{
				return this.m_birthdate;
			}
			set
			{
				this.m_birthdate = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002C4ED File Offset: 0x0002A6ED
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0002C4F5 File Offset: 0x0002A6F5
		public DateTime joindate
		{
			get
			{
				return this.m_playerjointeamdate;
			}
			set
			{
				this.m_playerjointeamdate = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0002C4FE File Offset: 0x0002A6FE
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0002C506 File Offset: 0x0002A706
		public int contractvaliduntil
		{
			get
			{
				return this.m_contractvaliduntil;
			}
			set
			{
				this.m_contractvaliduntil = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0002C50F File Offset: 0x0002A70F
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0002C517 File Offset: 0x0002A717
		public int height
		{
			get
			{
				return this.m_height;
			}
			set
			{
				this.m_height = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0002C520 File Offset: 0x0002A720
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0002C528 File Offset: 0x0002A728
		public int weight
		{
			get
			{
				return this.m_weight;
			}
			set
			{
				this.m_weight = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0002C531 File Offset: 0x0002A731
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0002C539 File Offset: 0x0002A739
		public int nationality
		{
			get
			{
				return this.m_nationality;
			}
			set
			{
				this.m_nationality = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0002C542 File Offset: 0x0002A742
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0002C54A File Offset: 0x0002A74A
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				if (this.m_Country != null)
				{
					this.m_nationality = this.Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0002C574 File Offset: 0x0002A774
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0002C57C File Offset: 0x0002A77C
		public int eyecolorcode
		{
			get
			{
				return this.m_eyecolorcode;
			}
			set
			{
				this.m_eyecolorcode = value;
				this.m_EyesTextureBitmap = null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0002C58C File Offset: 0x0002A78C
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x0002C594 File Offset: 0x0002A794
		public int eyebrowcode
		{
			get
			{
				return this.m_eyebrowcode;
			}
			set
			{
				this.m_eyebrowcode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0002C5A4 File Offset: 0x0002A7A4
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		public int bodytypecode
		{
			get
			{
				return this.m_bodytypecode;
			}
			set
			{
				this.m_bodytypecode = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0002C5B5 File Offset: 0x0002A7B5
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0002C5BD File Offset: 0x0002A7BD
		public int hairtypecode
		{
			get
			{
				return this.m_hairtypecode;
			}
			set
			{
				this.m_hairtypecode = value;
				this.m_HairModelFile = null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0002C5CD File Offset: 0x0002A7CD
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0002C5D5 File Offset: 0x0002A7D5
		public int headtypecode
		{
			get
			{
				return this.m_headtypecode;
			}
			set
			{
				this.m_headtypecode = value;
				this.m_HeadModelFile = null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0002C5E5 File Offset: 0x0002A7E5
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0002C5ED File Offset: 0x0002A7ED
		public int headclasscode
		{
			get
			{
				return this.m_headclasscode;
			}
			set
			{
				this.m_headclasscode = value;
				this.m_HairAlfaTextureBitmap = null;
				this.m_HairColorTextureBitmap = null;
				this.m_FaceTextureBitmaps = null;
				this.m_EyesTextureBitmap = null;
				this.m_HeadModelFile = null;
				this.m_HairModelFile = null;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002C620 File Offset: 0x0002A820
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0002C628 File Offset: 0x0002A828
		public int haircolorcode
		{
			get
			{
				return this.m_haircolorcode;
			}
			set
			{
				this.m_haircolorcode = value;
				this.m_HairColorTextureBitmap = null;
				this.m_HairAlfaTextureBitmap = null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002C63F File Offset: 0x0002A83F
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0002C647 File Offset: 0x0002A847
		public int facialhairtypecode
		{
			get
			{
				return this.m_facialhairtypecode;
			}
			set
			{
				this.m_facialhairtypecode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002C657 File Offset: 0x0002A857
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0002C65F File Offset: 0x0002A85F
		public int facialhaircolorcode
		{
			get
			{
				return this.m_facialhaircolorcode;
			}
			set
			{
				this.m_facialhaircolorcode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002C66F File Offset: 0x0002A86F
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0002C677 File Offset: 0x0002A877
		public int sideburnscode
		{
			get
			{
				return this.m_sideburnscode;
			}
			set
			{
				this.m_sideburnscode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0002C687 File Offset: 0x0002A887
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0002C68F File Offset: 0x0002A88F
		public int skintypecode
		{
			get
			{
				return this.m_skintypecode;
			}
			set
			{
				this.m_skintypecode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0002C69F File Offset: 0x0002A89F
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0002C6A7 File Offset: 0x0002A8A7
		public int skintonecode
		{
			get
			{
				return this.m_skintonecode;
			}
			set
			{
				this.m_skintonecode = value;
				this.m_FaceTextureBitmaps = null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0002C6B7 File Offset: 0x0002A8B7
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0002C6BF File Offset: 0x0002A8BF
		public int jerseysleevelengthcode
		{
			get
			{
				return this.m_jerseysleevelengthcode;
			}
			set
			{
				this.m_jerseysleevelengthcode = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		public int jerseystylecode
		{
			get
			{
				return this.m_jerseystylecode;
			}
			set
			{
				this.m_jerseystylecode = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002C6D9 File Offset: 0x0002A8D9
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0002C6E1 File Offset: 0x0002A8E1
		public int hasseasonaljersey
		{
			get
			{
				return this.m_hasseasonaljersey;
			}
			set
			{
				this.m_hasseasonaljersey = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0002C6EA File Offset: 0x0002A8EA
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0002C6F2 File Offset: 0x0002A8F2
		public int animfreekickstartposcode
		{
			get
			{
				return this.m_animfreekickstartposcode;
			}
			set
			{
				this.m_animfreekickstartposcode = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0002C6FB File Offset: 0x0002A8FB
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0002C703 File Offset: 0x0002A903
		public int animpenaltieskickstylecode
		{
			get
			{
				return this.m_animpenaltieskickstylecode;
			}
			set
			{
				this.m_animpenaltieskickstylecode = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0002C70C File Offset: 0x0002A90C
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0002C714 File Offset: 0x0002A914
		public int animpenaltiesmotionstylecode
		{
			get
			{
				return this.m_animpenaltiesmotionstylecode;
			}
			set
			{
				this.m_animpenaltiesmotionstylecode = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002C71D File Offset: 0x0002A91D
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0002C725 File Offset: 0x0002A925
		public int animpenaltiesstartposcode
		{
			get
			{
				return this.m_animpenaltiesstartposcode;
			}
			set
			{
				this.m_animpenaltiesstartposcode = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002C72E File Offset: 0x0002A92E
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0002C736 File Offset: 0x0002A936
		public int accessorycode1
		{
			get
			{
				return this.m_accessorycode1;
			}
			set
			{
				this.m_accessorycode1 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002C73F File Offset: 0x0002A93F
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0002C747 File Offset: 0x0002A947
		public int accessorycolourcode1
		{
			get
			{
				return this.m_accessorycolourcode1;
			}
			set
			{
				this.m_accessorycolourcode1 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002C750 File Offset: 0x0002A950
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0002C758 File Offset: 0x0002A958
		public int accessorycode2
		{
			get
			{
				return this.m_accessorycode2;
			}
			set
			{
				this.m_accessorycode2 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0002C761 File Offset: 0x0002A961
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0002C769 File Offset: 0x0002A969
		public int accessorycolourcode2
		{
			get
			{
				return this.m_accessorycolourcode2;
			}
			set
			{
				this.m_accessorycolourcode2 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0002C772 File Offset: 0x0002A972
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0002C77A File Offset: 0x0002A97A
		public int accessorycode3
		{
			get
			{
				return this.m_accessorycode3;
			}
			set
			{
				this.m_accessorycode3 = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002C783 File Offset: 0x0002A983
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0002C78B File Offset: 0x0002A98B
		public int accessorycolourcode3
		{
			get
			{
				return this.m_accessorycolourcode3;
			}
			set
			{
				this.m_accessorycolourcode3 = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0002C794 File Offset: 0x0002A994
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0002C79C File Offset: 0x0002A99C
		public int accessorycode4
		{
			get
			{
				return this.m_accessorycode4;
			}
			set
			{
				this.m_accessorycode4 = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0002C7A5 File Offset: 0x0002A9A5
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0002C7AD File Offset: 0x0002A9AD
		public int accessorycolourcode4
		{
			get
			{
				return this.m_accessorycolourcode4;
			}
			set
			{
				this.m_accessorycolourcode4 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0002C7B6 File Offset: 0x0002A9B6
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0002C7BE File Offset: 0x0002A9BE
		public int shoetypecode
		{
			get
			{
				return this.m_shoetypecode;
			}
			set
			{
				this.m_shoetypecode = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0002C7C7 File Offset: 0x0002A9C7
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0002C7CF File Offset: 0x0002A9CF
		public int shoedesigncode
		{
			get
			{
				return this.m_shoedesigncode;
			}
			set
			{
				this.m_shoedesigncode = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		public int shoecolorcode1
		{
			get
			{
				return this.m_shoecolorcode1;
			}
			set
			{
				this.m_shoecolorcode1 = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0002C7E9 File Offset: 0x0002A9E9
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0002C7F1 File Offset: 0x0002A9F1
		public int shoecolorcode2
		{
			get
			{
				return this.m_shoecolorcode2;
			}
			set
			{
				this.m_shoecolorcode2 = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0002C7FA File Offset: 0x0002A9FA
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0002C802 File Offset: 0x0002AA02
		public int preferredposition1
		{
			get
			{
				return this.m_preferredposition1;
			}
			set
			{
				this.m_preferredposition1 = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0002C80B File Offset: 0x0002AA0B
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0002C813 File Offset: 0x0002AA13
		public int preferredposition2
		{
			get
			{
				return this.m_preferredposition2;
			}
			set
			{
				this.m_preferredposition2 = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0002C81C File Offset: 0x0002AA1C
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0002C824 File Offset: 0x0002AA24
		public int preferredposition3
		{
			get
			{
				return this.m_preferredposition3;
			}
			set
			{
				this.m_preferredposition3 = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0002C82D File Offset: 0x0002AA2D
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0002C835 File Offset: 0x0002AA35
		public int preferredposition4
		{
			get
			{
				return this.m_preferredposition4;
			}
			set
			{
				this.m_preferredposition4 = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0002C83E File Offset: 0x0002AA3E
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0002C846 File Offset: 0x0002AA46
		public int preferredfoot
		{
			get
			{
				return this.m_preferredfoot;
			}
			set
			{
				this.m_preferredfoot = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0002C84F File Offset: 0x0002AA4F
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0002C859 File Offset: 0x0002AA59
		public int weakfootabilitytypecode
		{
			get
			{
				return this.m_weakfootabilitytypecode - 1;
			}
			set
			{
				this.m_weakfootabilitytypecode = value + 1;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0002C864 File Offset: 0x0002AA64
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0002C86C File Offset: 0x0002AA6C
		public int acceleration
		{
			get
			{
				return this.m_acceleration;
			}
			set
			{
				this.m_acceleration = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0002C875 File Offset: 0x0002AA75
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0002C87D File Offset: 0x0002AA7D
		public int aggression
		{
			get
			{
				return this.m_aggression;
			}
			set
			{
				this.m_aggression = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0002C886 File Offset: 0x0002AA86
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0002C88E File Offset: 0x0002AA8E
		public int gkglovetypecode
		{
			get
			{
				return this.m_gkglovetypecode;
			}
			set
			{
				this.m_gkglovetypecode = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0002C897 File Offset: 0x0002AA97
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0002C89F File Offset: 0x0002AA9F
		public int agility
		{
			get
			{
				return this.m_agility;
			}
			set
			{
				this.m_agility = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		public int balance
		{
			get
			{
				return this.m_balance;
			}
			set
			{
				this.m_balance = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0002C8B9 File Offset: 0x0002AAB9
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0002C8C1 File Offset: 0x0002AAC1
		public int gkkicking
		{
			get
			{
				return this.m_gkkicking;
			}
			set
			{
				this.m_gkkicking = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0002C8CA File Offset: 0x0002AACA
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0002C8D2 File Offset: 0x0002AAD2
		public int gkkickstyle
		{
			get
			{
				return this.m_gkkickstyle;
			}
			set
			{
				this.m_gkkickstyle = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0002C8DB File Offset: 0x0002AADB
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0002C8E3 File Offset: 0x0002AAE3
		public int jumping
		{
			get
			{
				return this.m_jumping;
			}
			set
			{
				this.m_jumping = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		public int penalties
		{
			get
			{
				return this.m_penalties;
			}
			set
			{
				this.m_penalties = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0002C8FD File Offset: 0x0002AAFD
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0002C905 File Offset: 0x0002AB05
		public int vision
		{
			get
			{
				return this.m_vision;
			}
			set
			{
				this.m_vision = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0002C90E File Offset: 0x0002AB0E
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0002C916 File Offset: 0x0002AB16
		public int volleys
		{
			get
			{
				return this.m_volleys;
			}
			set
			{
				this.m_volleys = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0002C91F File Offset: 0x0002AB1F
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0002C927 File Offset: 0x0002AB27
		public int skillmoves
		{
			get
			{
				return this.m_skillmoves;
			}
			set
			{
				this.m_skillmoves = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002C930 File Offset: 0x0002AB30
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0002C938 File Offset: 0x0002AB38
		public int usercaneditname
		{
			get
			{
				return this.m_usercaneditname;
			}
			set
			{
				this.m_usercaneditname = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0002C941 File Offset: 0x0002AB41
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0002C949 File Offset: 0x0002AB49
		public int sprintspeed
		{
			get
			{
				return this.m_sprintspeed;
			}
			set
			{
				this.m_sprintspeed = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002C952 File Offset: 0x0002AB52
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0002C95A File Offset: 0x0002AB5A
		public int stamina
		{
			get
			{
				return this.m_stamina;
			}
			set
			{
				this.m_stamina = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0002C963 File Offset: 0x0002AB63
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0002C96B File Offset: 0x0002AB6B
		public int strength
		{
			get
			{
				return this.m_strength;
			}
			set
			{
				this.m_strength = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002C974 File Offset: 0x0002AB74
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0002C97C File Offset: 0x0002AB7C
		public int marking
		{
			get
			{
				return this.m_marking;
			}
			set
			{
				this.m_marking = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0002C985 File Offset: 0x0002AB85
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0002C98D File Offset: 0x0002AB8D
		public int standingtackle
		{
			get
			{
				return this.m_standingtackle;
			}
			set
			{
				this.m_standingtackle = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002C996 File Offset: 0x0002AB96
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0002C99E File Offset: 0x0002AB9E
		public int slidingtackle
		{
			get
			{
				return this.m_slidingtackle;
			}
			set
			{
				this.m_slidingtackle = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002C9A7 File Offset: 0x0002ABA7
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0002C9AF File Offset: 0x0002ABAF
		public int ballcontrol
		{
			get
			{
				return this.m_ballcontrol;
			}
			set
			{
				this.m_ballcontrol = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0002C9C0 File Offset: 0x0002ABC0
		public int dribbling
		{
			get
			{
				return this.m_dribbling;
			}
			set
			{
				this.m_dribbling = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0002C9C9 File Offset: 0x0002ABC9
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0002C9D1 File Offset: 0x0002ABD1
		public int crossing
		{
			get
			{
				return this.m_crossing;
			}
			set
			{
				this.m_crossing = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0002C9DA File Offset: 0x0002ABDA
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0002C9E2 File Offset: 0x0002ABE2
		public int headingaccuracy
		{
			get
			{
				return this.m_headingaccuracy;
			}
			set
			{
				this.m_headingaccuracy = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0002C9EB File Offset: 0x0002ABEB
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0002C9F3 File Offset: 0x0002ABF3
		public int shortpassing
		{
			get
			{
				return this.m_shortpassing;
			}
			set
			{
				this.m_shortpassing = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002C9FC File Offset: 0x0002ABFC
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0002CA04 File Offset: 0x0002AC04
		public int longpassing
		{
			get
			{
				return this.m_longpassing;
			}
			set
			{
				this.m_longpassing = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0002CA0D File Offset: 0x0002AC0D
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0002CA15 File Offset: 0x0002AC15
		public int longshots
		{
			get
			{
				return this.m_longshots;
			}
			set
			{
				this.m_longshots = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0002CA1E File Offset: 0x0002AC1E
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0002CA26 File Offset: 0x0002AC26
		public int finishing
		{
			get
			{
				return this.m_finishing;
			}
			set
			{
				this.m_finishing = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002CA2F File Offset: 0x0002AC2F
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0002CA37 File Offset: 0x0002AC37
		public int shotpower
		{
			get
			{
				return this.m_shotpower;
			}
			set
			{
				this.m_shotpower = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0002CA40 File Offset: 0x0002AC40
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0002CA48 File Offset: 0x0002AC48
		public int reactions
		{
			get
			{
				return this.m_reactions;
			}
			set
			{
				this.m_reactions = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0002CA51 File Offset: 0x0002AC51
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0002CA59 File Offset: 0x0002AC59
		public int gkreflexes
		{
			get
			{
				return this.m_gkreflexes;
			}
			set
			{
				this.m_gkreflexes = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0002CA62 File Offset: 0x0002AC62
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0002CA6A File Offset: 0x0002AC6A
		public int gkhandling
		{
			get
			{
				return this.m_gkhandling;
			}
			set
			{
				this.m_gkhandling = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0002CA73 File Offset: 0x0002AC73
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0002CA7B File Offset: 0x0002AC7B
		public int gkdiving
		{
			get
			{
				return this.m_gkdiving;
			}
			set
			{
				this.m_gkdiving = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x0002CA84 File Offset: 0x0002AC84
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		public int gkpositioning
		{
			get
			{
				return this.m_gkpositioning;
			}
			set
			{
				this.m_gkpositioning = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0002CA95 File Offset: 0x0002AC95
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0002CA9D File Offset: 0x0002AC9D
		public int freekickaccuracy
		{
			get
			{
				return this.m_freekickaccuracy;
			}
			set
			{
				this.m_freekickaccuracy = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0002CAA6 File Offset: 0x0002ACA6
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0002CAAE File Offset: 0x0002ACAE
		public int potential
		{
			get
			{
				return this.m_potential;
			}
			set
			{
				this.m_potential = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0002CAB7 File Offset: 0x0002ACB7
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0002CABF File Offset: 0x0002ACBF
		public int positioning
		{
			get
			{
				return this.m_positioning;
			}
			set
			{
				this.m_positioning = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		public int overallrating
		{
			get
			{
				return this.m_overallrating;
			}
			set
			{
				this.m_overallrating = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0002CAD9 File Offset: 0x0002ACD9
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0002CAE1 File Offset: 0x0002ACE1
		public bool Inflexible
		{
			get
			{
				return this.m_Inflexible;
			}
			set
			{
				this.m_Inflexible = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0002CAEA File Offset: 0x0002ACEA
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0002CAF2 File Offset: 0x0002ACF2
		public bool GkOneOnOne
		{
			get
			{
				return this.m_GkOneOnOne;
			}
			set
			{
				this.m_GkOneOnOne = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0002CAFB File Offset: 0x0002ACFB
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0002CB03 File Offset: 0x0002AD03
		public bool CrowdFavorite
		{
			get
			{
				return this.m_CrowdFavorite;
			}
			set
			{
				this.m_CrowdFavorite = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0002CB0C File Offset: 0x0002AD0C
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0002CB14 File Offset: 0x0002AD14
		public bool SecondWind
		{
			get
			{
				return this.m_SecondWind;
			}
			set
			{
				this.m_SecondWind = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0002CB1D File Offset: 0x0002AD1D
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0002CB25 File Offset: 0x0002AD25
		public bool AcrobaticClearance
		{
			get
			{
				return this.m_AcrobaticClearance;
			}
			set
			{
				this.m_AcrobaticClearance = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0002CB2E File Offset: 0x0002AD2E
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0002CB36 File Offset: 0x0002AD36
		public bool Longthrows
		{
			get
			{
				return this.m_Longthrows;
			}
			set
			{
				this.m_Longthrows = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0002CB3F File Offset: 0x0002AD3F
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x0002CB47 File Offset: 0x0002AD47
		public bool PowerfulFreeKicks
		{
			get
			{
				return this.m_PowerfulFreeKicks;
			}
			set
			{
				this.m_PowerfulFreeKicks = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0002CB50 File Offset: 0x0002AD50
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x0002CB58 File Offset: 0x0002AD58
		public bool Diver
		{
			get
			{
				return this.m_Diver;
			}
			set
			{
				this.m_Diver = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002CB61 File Offset: 0x0002AD61
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0002CB69 File Offset: 0x0002AD69
		public bool InjuryFree
		{
			get
			{
				return this.m_InjuryFree;
			}
			set
			{
				this.m_InjuryFree = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0002CB72 File Offset: 0x0002AD72
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x0002CB7A File Offset: 0x0002AD7A
		public bool InjuryProne
		{
			get
			{
				return this.m_InjuryProne;
			}
			set
			{
				this.m_InjuryProne = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002CB83 File Offset: 0x0002AD83
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0002CB8B File Offset: 0x0002AD8B
		public bool AvoidsWeakFoot
		{
			get
			{
				return this.m_AvoidsWeakFoot;
			}
			set
			{
				this.m_AvoidsWeakFoot = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0002CB94 File Offset: 0x0002AD94
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0002CB9C File Offset: 0x0002AD9C
		public bool Divesintotackles
		{
			get
			{
				return this.m_Divesintotackles;
			}
			set
			{
				this.m_Divesintotackles = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0002CBA5 File Offset: 0x0002ADA5
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0002CBAD File Offset: 0x0002ADAD
		public bool BeatDefensiveLine
		{
			get
			{
				return this.m_BeatDefensiveLine;
			}
			set
			{
				this.m_BeatDefensiveLine = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0002CBB6 File Offset: 0x0002ADB6
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0002CBBE File Offset: 0x0002ADBE
		public bool Selfish
		{
			get
			{
				return this.m_Selfish;
			}
			set
			{
				this.m_Selfish = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0002CBC7 File Offset: 0x0002ADC7
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0002CBCF File Offset: 0x0002ADCF
		public bool Leadership
		{
			get
			{
				return this.m_Leadership;
			}
			set
			{
				this.m_Leadership = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		public bool ArguesWithOfficials
		{
			get
			{
				return this.m_ArguesWithOfficials;
			}
			set
			{
				this.m_ArguesWithOfficials = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0002CBE9 File Offset: 0x0002ADE9
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0002CBF1 File Offset: 0x0002ADF1
		public bool Earlycrosser
		{
			get
			{
				return this.m_Earlycrosser;
			}
			set
			{
				this.m_Earlycrosser = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x0002CBFA File Offset: 0x0002ADFA
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0002CC02 File Offset: 0x0002AE02
		public bool FinesseShot
		{
			get
			{
				return this.m_FinesseShot;
			}
			set
			{
				this.m_FinesseShot = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0002CC0B File Offset: 0x0002AE0B
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0002CC13 File Offset: 0x0002AE13
		public bool Flair
		{
			get
			{
				return this.m_Flair;
			}
			set
			{
				this.m_Flair = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0002CC1C File Offset: 0x0002AE1C
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0002CC24 File Offset: 0x0002AE24
		public bool LongPasser
		{
			get
			{
				return this.m_LongPasser;
			}
			set
			{
				this.m_LongPasser = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0002CC2D File Offset: 0x0002AE2D
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0002CC35 File Offset: 0x0002AE35
		public bool LongShotTaker
		{
			get
			{
				return this.m_LongShotTaker;
			}
			set
			{
				this.m_LongShotTaker = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002CC3E File Offset: 0x0002AE3E
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0002CC46 File Offset: 0x0002AE46
		public bool Technicaldribbler
		{
			get
			{
				return this.m_Technicaldribbler;
			}
			set
			{
				this.m_Technicaldribbler = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0002CC4F File Offset: 0x0002AE4F
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0002CC57 File Offset: 0x0002AE57
		public bool Playmaker
		{
			get
			{
				return this.m_Playmaker;
			}
			set
			{
				this.m_Playmaker = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0002CC60 File Offset: 0x0002AE60
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0002CC68 File Offset: 0x0002AE68
		public bool Pushesupforcorners
		{
			get
			{
				return this.m_Pushesupforcorners;
			}
			set
			{
				this.m_Pushesupforcorners = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0002CC71 File Offset: 0x0002AE71
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0002CC79 File Offset: 0x0002AE79
		public bool Puncher
		{
			get
			{
				return this.m_Puncher;
			}
			set
			{
				this.m_Puncher = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0002CC82 File Offset: 0x0002AE82
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0002CC8A File Offset: 0x0002AE8A
		public bool GkLongThrower
		{
			get
			{
				return this.m_GkLongThrower;
			}
			set
			{
				this.m_GkLongThrower = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0002CC93 File Offset: 0x0002AE93
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0002CC9B File Offset: 0x0002AE9B
		public bool PowerHeader
		{
			get
			{
				return this.m_PowerHeader;
			}
			set
			{
				this.m_PowerHeader = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002CCA4 File Offset: 0x0002AEA4
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0002CCAC File Offset: 0x0002AEAC
		public bool GiantThrow
		{
			get
			{
				return this.m_GiantThrow;
			}
			set
			{
				this.m_GiantThrow = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0002CCB5 File Offset: 0x0002AEB5
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0002CCBD File Offset: 0x0002AEBD
		public bool OutsideFootShot
		{
			get
			{
				return this.m_OutsideFootShot;
			}
			set
			{
				this.m_OutsideFootShot = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002CCC6 File Offset: 0x0002AEC6
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0002CCCE File Offset: 0x0002AECE
		public bool SwervePasser
		{
			get
			{
				return this.m_SwervePasser;
			}
			set
			{
				this.m_SwervePasser = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0002CCD7 File Offset: 0x0002AED7
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0002CCDF File Offset: 0x0002AEDF
		public bool HighClubIdentification
		{
			get
			{
				return this.m_HighClubIdentification;
			}
			set
			{
				this.m_HighClubIdentification = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		public bool TeamPlayer
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0002CCF9 File Offset: 0x0002AEF9
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0002CD01 File Offset: 0x0002AF01
		public bool FancyFeet
		{
			get
			{
				return this.m_FancyFeet;
			}
			set
			{
				this.m_FancyFeet = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0002CD0A File Offset: 0x0002AF0A
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0002CD12 File Offset: 0x0002AF12
		public bool FancyPasses
		{
			get
			{
				return this.m_FancyPasses;
			}
			set
			{
				this.m_FancyPasses = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0002CD1B File Offset: 0x0002AF1B
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0002CD23 File Offset: 0x0002AF23
		public bool FancyFlicks
		{
			get
			{
				return this.m_FancyFlicks;
			}
			set
			{
				this.m_FancyFlicks = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0002CD34 File Offset: 0x0002AF34
		public bool StutterPenalty
		{
			get
			{
				return this.m_StutterPenalty;
			}
			set
			{
				this.m_StutterPenalty = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0002CD3D File Offset: 0x0002AF3D
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0002CD45 File Offset: 0x0002AF45
		public bool ChipperPenalty
		{
			get
			{
				return this.m_ChipperPenalty;
			}
			set
			{
				this.m_ChipperPenalty = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0002CD4E File Offset: 0x0002AF4E
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0002CD56 File Offset: 0x0002AF56
		public bool BycicleKick
		{
			get
			{
				return this.m_BycicleKick;
			}
			set
			{
				this.m_BycicleKick = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0002CD5F File Offset: 0x0002AF5F
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x0002CD67 File Offset: 0x0002AF67
		public bool DivingHeader
		{
			get
			{
				return this.m_DivingHeader;
			}
			set
			{
				this.m_DivingHeader = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0002CD70 File Offset: 0x0002AF70
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0002CD78 File Offset: 0x0002AF78
		public bool DrivenPass
		{
			get
			{
				return this.m_DrivenPass;
			}
			set
			{
				this.m_DrivenPass = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0002CD81 File Offset: 0x0002AF81
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0002CD89 File Offset: 0x0002AF89
		public bool GkFlatKick
		{
			get
			{
				return this.m_GkFlatKick;
			}
			set
			{
				this.m_GkFlatKick = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0002CD92 File Offset: 0x0002AF92
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0002CD9A File Offset: 0x0002AF9A
		public int curve
		{
			get
			{
				return this.m_curve;
			}
			set
			{
				this.m_curve = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0002CDA3 File Offset: 0x0002AFA3
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0002CDAB File Offset: 0x0002AFAB
		public int internationalrep
		{
			get
			{
				return this.m_internationalrep;
			}
			set
			{
				this.m_internationalrep = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		public bool Female
		{
			get
			{
				return this.m_gender;
			}
			set
			{
				this.m_gender = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0002CDC5 File Offset: 0x0002AFC5
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		public bool Male
		{
			get
			{
				return !this.m_gender;
			}
			set
			{
				this.m_gender = !value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0002CDDC File Offset: 0x0002AFDC
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
		public int emotion
		{
			get
			{
				return this.m_emotion;
			}
			set
			{
				this.m_emotion = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002CDED File Offset: 0x0002AFED
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0002CDF5 File Offset: 0x0002AFF5
		public int finishingcode1
		{
			get
			{
				return this.m_finishingcode1;
			}
			set
			{
				this.m_finishingcode1 = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x0002CDFE File Offset: 0x0002AFFE
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0002CE06 File Offset: 0x0002B006
		public int finishingcode2
		{
			get
			{
				return this.m_finishingcode2;
			}
			set
			{
				this.m_finishingcode2 = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0002CE0F File Offset: 0x0002B00F
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0002CE17 File Offset: 0x0002B017
		public int runningcode1
		{
			get
			{
				return this.m_runningcode1;
			}
			set
			{
				this.m_runningcode1 = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002CE20 File Offset: 0x0002B020
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0002CE28 File Offset: 0x0002B028
		public int runningcode2
		{
			get
			{
				return this.m_runningcode2;
			}
			set
			{
				this.m_runningcode2 = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0002CE31 File Offset: 0x0002B031
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0002CE39 File Offset: 0x0002B039
		public int gksavetype
		{
			get
			{
				return this.m_gksavetype;
			}
			set
			{
				this.m_gksavetype = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0002CE42 File Offset: 0x0002B042
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0002CE4A File Offset: 0x0002B04A
		public int faceposercode
		{
			get
			{
				return this.m_faceposercode;
			}
			set
			{
				this.m_faceposercode = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0002CE53 File Offset: 0x0002B053
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0002CE5B File Offset: 0x0002B05B
		public int isretiring
		{
			get
			{
				return this.m_isretiring;
			}
			set
			{
				this.m_isretiring = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0002CE64 File Offset: 0x0002B064
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0002CE6C File Offset: 0x0002B06C
		public int socklengthcode
		{
			get
			{
				return this.m_socklengthcode;
			}
			set
			{
				this.m_socklengthcode = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0002CE75 File Offset: 0x0002B075
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x0002CE7D File Offset: 0x0002B07D
		public bool hashighqualityhead
		{
			get
			{
				return this.m_hashighqualityhead;
			}
			set
			{
				this.m_hashighqualityhead = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0002CE86 File Offset: 0x0002B086
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0002CE8E File Offset: 0x0002B08E
		public int attackingworkrate
		{
			get
			{
				return this.m_attackingworkrate;
			}
			set
			{
				this.m_attackingworkrate = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0002CE97 File Offset: 0x0002B097
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x0002CE9F File Offset: 0x0002B09F
		public int defensiveworkrate
		{
			get
			{
				return this.m_defensiveworkrate;
			}
			set
			{
				this.m_defensiveworkrate = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0002CEA8 File Offset: 0x0002B0A8
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		public bool TrainingPants
		{
			get
			{
				return this.m_shortstyle;
			}
			set
			{
				this.m_shortstyle = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0002CEB9 File Offset: 0x0002B0B9
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0002CEC1 File Offset: 0x0002B0C1
		public int interceptions
		{
			get
			{
				return this.m_interceptions;
			}
			set
			{
				this.m_interceptions = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0002CECA File Offset: 0x0002B0CA
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0002CED2 File Offset: 0x0002B0D2
		public bool jerseyfit
		{
			get
			{
				return this.m_jerseyfit;
			}
			set
			{
				this.m_jerseyfit = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002CEDB File Offset: 0x0002B0DB
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0002CEE3 File Offset: 0x0002B0E3
		public int preferredNumber
		{
			get
			{
				return this.m_preferredNumber;
			}
			set
			{
				this.m_preferredNumber = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0002CEEC File Offset: 0x0002B0EC
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		public Team TeamLoanedFrom
		{
			get
			{
				return this.m_TeamLoanedFrom;
			}
			set
			{
				this.m_TeamLoanedFrom = value;
				this.m_teamidloanedfrom = ((this.m_TeamLoanedFrom != null) ? this.m_TeamLoanedFrom.Id : 0);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0002CF19 File Offset: 0x0002B119
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0002CF21 File Offset: 0x0002B121
		public Team PreviousTeam
		{
			get
			{
				return this.m_PreviousTeam;
			}
			set
			{
				this.m_PreviousTeam = value;
				this.m_previousteamid = ((this.m_PreviousTeam != null) ? this.m_PreviousTeam.Id : 0);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0002CF46 File Offset: 0x0002B146
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0002CF4E File Offset: 0x0002B14E
		public bool IsLoaned
		{
			get
			{
				return this.m_IsLoaned;
			}
			set
			{
				this.m_IsLoaned = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x0002CF57 File Offset: 0x0002B157
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0002CF5F File Offset: 0x0002B15F
		public DateTime loandateend
		{
			get
			{
				return this.m_loandateend;
			}
			set
			{
				this.m_loandateend = value;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0002CF68 File Offset: 0x0002B168
		public string WabName()
		{
			if (this.m_commonname != null && this.m_commonname != string.Empty)
			{
				return this.m_commonname;
			}
			if (this.m_firstname != null && this.m_firstname != string.Empty)
			{
				return this.m_firstname + " " + this.m_lastname;
			}
			return this.m_lastname;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		public override string ToString()
		{
			if (this.m_commonname != null && this.m_commonname != string.Empty)
			{
				return this.m_commonname;
			}
			if (this.m_firstname != null && this.m_firstname != string.Empty)
			{
				return this.m_lastname + " " + this.m_firstname;
			}
			return this.m_lastname + " [" + base.Id.ToString() + "]";
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0002D052 File Offset: 0x0002B252
		public Player(Record r)
			: base(r.IntField[FI.players_playerid])
		{
			this.Load(r);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0002D078 File Offset: 0x0002B278
		public void UpdateNamesAndCommentary()
		{
			this.m_commentaryid = 900000;
			if (!Player.PlayerNames.TryGetValue(this.m_firstnameid, out this.m_firstname, true))
			{
				this.m_firstname = string.Empty;
			}
			int num;
			if (!Player.PlayerNames.TryGetValue(this.m_lastnameid, out this.m_lastname, out num, true))
			{
				this.m_lastname = string.Empty;
			}
			int num2;
			if (!Player.PlayerNames.TryGetValue(this.m_commonnameid, out this.m_commonname, out num2, true))
			{
				this.m_commonname = string.Empty;
			}
			if (this.m_commonname != string.Empty)
			{
				this.m_commentaryid = num2;
				this.m_audioname = this.m_commonname;
			}
			else if (this.m_lastname != string.Empty)
			{
				this.m_commentaryid = num;
				this.m_audioname = this.m_lastname;
			}
			else
			{
				this.m_commentaryid = 900000;
				this.m_audioname = string.Empty;
			}
			if (!Player.PlayerNames.TryGetValue(this.m_playerjerseynameid, out this.m_playerjerseyname, true))
			{
				this.m_playerjerseyname = string.Empty;
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002D188 File Offset: 0x0002B388
		public void Load(Record r)
		{
			this.m_headclasscode = r.GetAndCheckIntField(FI.players_headclasscode);
			this.m_firstnameid = r.IntField[FI.players_firstnameid];
			this.m_lastnameid = r.IntField[FI.players_lastnameid];
			this.m_commonnameid = r.IntField[FI.players_commonnameid];
			this.m_playerjerseynameid = r.IntField[FI.players_playerjerseynameid];
			this.UpdateNamesAndCommentary();
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_birthdate));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_playerjointeamdate = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_playerjointeamdate));
			this.m_contractvaliduntil = r.GetAndCheckIntField(FI.players_contractvaliduntil);
			this.m_height = r.GetAndCheckIntField(FI.players_height);
			this.m_weight = r.GetAndCheckIntField(FI.players_weight);
			this.m_preferredposition1 = r.GetAndCheckIntField(FI.players_preferredposition1);
			this.m_preferredposition2 = r.GetAndCheckIntField(FI.players_preferredposition2);
			this.m_preferredposition3 = r.GetAndCheckIntField(FI.players_preferredposition3);
			this.m_preferredposition4 = r.GetAndCheckIntField(FI.players_preferredposition4);
			this.m_preferredfoot = r.GetAndCheckIntField(FI.players_preferredfoot) - 1;
			this.m_bodytypecode = r.GetAndCheckIntField(FI.players_bodytypecode) - 1;
			this.m_shoecolorcode1 = r.GetAndCheckIntField(FI.players_shoecolorcode1);
			this.m_shoetypecode = r.GetAndCheckIntField(FI.players_shoetypecode);
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(FI.players_jerseysleevelengthcode);
			this.m_eyecolorcode = r.GetAndCheckIntField(FI.players_eyecolorcode);
			this.m_eyebrowcode = r.GetAndCheckIntField(FI.players_eyebrowcode);
			this.m_facialhairtypecode = r.GetAndCheckIntField(FI.players_facialhairtypecode);
			this.m_facialhaircolorcode = r.GetAndCheckIntField(FI.players_facialhaircolorcode);
			this.m_hairtypecode = r.GetAndCheckIntField(FI.players_hairtypecode);
			this.m_haircolorcode = r.GetAndCheckIntField(FI.players_haircolorcode);
			this.m_headtypecode = r.GetAndCheckIntField(FI.players_headtypecode);
			this.m_sideburnscode = r.GetAndCheckIntField(FI.players_sideburnscode);
			this.m_skintypecode = r.GetAndCheckIntField(FI.players_skintypecode);
			this.m_skintonecode = r.GetAndCheckIntField(FI.players_skintonecode);
			this.m_overallrating = r.GetAndCheckIntField(FI.players_overallrating);
			this.m_jerseystylecode = r.GetAndCheckIntField(FI.players_jerseystylecode);
			this.m_hasseasonaljersey = r.GetAndCheckIntField(FI.players_hasseasonaljersey);
			this.m_animfreekickstartposcode = r.GetAndCheckIntField(FI.players_animfreekickstartposcode);
			this.m_animpenaltieskickstylecode = r.GetAndCheckIntField(FI.players_animpenaltieskickstylecode);
			this.m_animpenaltiesmotionstylecode = r.GetAndCheckIntField(FI.players_animpenaltiesmotionstylecode);
			this.m_animpenaltiesstartposcode = r.GetAndCheckIntField(FI.players_animpenaltiesstartposcode);
			this.m_accessorycode1 = r.GetAndCheckIntField(FI.players_accessorycode1);
			this.m_accessorycolourcode1 = r.GetAndCheckIntField(FI.players_accessorycolourcode1);
			this.m_accessorycode2 = r.GetAndCheckIntField(FI.players_accessorycode2);
			this.m_accessorycolourcode2 = r.GetAndCheckIntField(FI.players_accessorycolourcode2);
			this.m_accessorycode3 = r.GetAndCheckIntField(FI.players_accessorycode3);
			this.m_accessorycolourcode3 = r.GetAndCheckIntField(FI.players_accessorycolourcode3);
			this.m_accessorycode4 = r.GetAndCheckIntField(FI.players_accessorycode4);
			this.m_accessorycolourcode4 = r.GetAndCheckIntField(FI.players_accessorycolourcode4);
			this.m_acceleration = r.GetAndCheckIntField(FI.players_acceleration);
			this.m_aggression = r.GetAndCheckIntField(FI.players_aggression);
			this.m_ballcontrol = r.GetAndCheckIntField(FI.players_ballcontrol);
			this.m_crossing = r.GetAndCheckIntField(FI.players_crossing);
			this.m_dribbling = r.GetAndCheckIntField(FI.players_dribbling);
			this.m_finishing = r.GetAndCheckIntField(FI.players_finishing);
			this.m_freekickaccuracy = r.GetAndCheckIntField(FI.players_freekickaccuracy);
			this.m_headingaccuracy = r.GetAndCheckIntField(FI.players_headingaccuracy);
			this.m_longpassing = r.GetAndCheckIntField(FI.players_longpassing);
			this.m_longshots = r.GetAndCheckIntField(FI.players_longshots);
			this.m_marking = r.GetAndCheckIntField(FI.players_marking);
			this.m_positioning = r.GetAndCheckIntField(FI.players_positioning);
			this.m_potential = r.GetAndCheckIntField(FI.players_potential);
			this.m_reactions = r.GetAndCheckIntField(FI.players_reactions);
			this.m_shortpassing = r.GetAndCheckIntField(FI.players_shortpassing);
			this.m_shotpower = r.GetAndCheckIntField(FI.players_shotpower);
			this.m_sprintspeed = r.GetAndCheckIntField(FI.players_sprintspeed);
			this.m_stamina = r.GetAndCheckIntField(FI.players_stamina);
			this.m_strength = r.GetAndCheckIntField(FI.players_strength);
			this.m_standingtackle = r.GetAndCheckIntField(FI.players_standingtackle);
			this.m_slidingtackle = r.GetAndCheckIntField(FI.players_slidingtackle);
			this.m_gkdiving = r.GetAndCheckIntField(FI.players_gkdiving);
			this.m_gkpositioning = r.GetAndCheckIntField(FI.players_gkpositioning);
			this.m_gkhandling = r.GetAndCheckIntField(FI.players_gkhandling);
			this.m_gkreflexes = r.GetAndCheckIntField(FI.players_gkreflexes);
			this.m_gkglovetypecode = r.GetAndCheckIntField(FI.players_gkglovetypecode);
			this.m_agility = r.GetAndCheckIntField(FI.players_agility);
			this.m_balance = r.GetAndCheckIntField(FI.players_balance);
			this.m_gkkicking = r.GetAndCheckIntField(FI.players_gkkicking);
			this.m_gkkickstyle = r.GetAndCheckIntField(FI.players_gkkickstyle);
			this.m_jumping = r.GetAndCheckIntField(FI.players_jumping);
			this.m_penalties = r.GetAndCheckIntField(FI.players_penalties);
			this.m_vision = r.GetAndCheckIntField(FI.players_vision);
			this.m_volleys = r.GetAndCheckIntField(FI.players_volleys);
			this.m_gender = r.GetAndCheckIntField(FI.players_gender) != 0;
			this.m_emotion = r.GetAndCheckIntField(FI.players_emotion);
			this.m_skillmoves = r.GetAndCheckIntField(FI.players_skillmoves) + 1;
			this.m_usercaneditname = r.GetAndCheckIntField(FI.players_usercaneditname);
			this.m_finishingcode1 = r.GetAndCheckIntField(FI.players_finishingcode1);
			this.m_finishingcode2 = r.GetAndCheckIntField(FI.players_finishingcode2);
			this.m_runningcode1 = r.GetAndCheckIntField(FI.players_runningcode1);
			this.m_runningcode2 = r.GetAndCheckIntField(FI.players_runningcode2);
			this.m_gksavetype = r.GetAndCheckIntField(FI.players_gksavetype);
			this.m_faceposercode = r.GetAndCheckIntField(FI.players_faceposercode);
			this.m_isretiring = r.GetAndCheckIntField(FI.players_isretiring);
			this.m_socklengthcode = r.GetAndCheckIntField(FI.players_socklengthcode);
			this.m_hashighqualityhead = r.GetAndCheckIntField(FI.players_hashighqualityhead) != 0;
			this.m_attackingworkrate = r.GetAndCheckIntField(FI.players_attackingworkrate);
			this.m_defensiveworkrate = r.GetAndCheckIntField(FI.players_defensiveworkrate);
			this.m_shortstyle = r.GetAndCheckIntField(FI.players_shortstyle) != 0;
			int andCheckIntField = r.GetAndCheckIntField(FI.players_trait1);
			this.m_Inflexible = (andCheckIntField & 1) != 0;
			this.m_Longthrows = (andCheckIntField & 2) != 0;
			this.m_PowerfulFreeKicks = (andCheckIntField & 4) != 0;
			this.m_Diver = (andCheckIntField & 8) != 0;
			this.m_InjuryProne = (andCheckIntField & 16) != 0;
			this.m_InjuryFree = (andCheckIntField & 32) != 0;
			this.m_AvoidsWeakFoot = (andCheckIntField & 64) != 0;
			this.m_Divesintotackles = (andCheckIntField & 128) != 0;
			this.m_BeatDefensiveLine = (andCheckIntField & 256) != 0;
			this.m_Selfish = (andCheckIntField & 512) != 0;
			this.m_Leadership = (andCheckIntField & 1024) != 0;
			this.m_ArguesWithOfficials = (andCheckIntField & 2048) != 0;
			this.m_Earlycrosser = (andCheckIntField & 4096) != 0;
			this.m_FinesseShot = (andCheckIntField & 8192) != 0;
			this.m_Flair = (andCheckIntField & 16384) != 0;
			this.m_LongPasser = (andCheckIntField & 32768) != 0;
			this.m_LongShotTaker = (andCheckIntField & 65536) != 0;
			this.m_Technicaldribbler = (andCheckIntField & 131072) != 0;
			this.m_Playmaker = (andCheckIntField & 262144) != 0;
			this.m_Pushesupforcorners = (andCheckIntField & 524288) != 0;
			this.m_Puncher = (andCheckIntField & 1048576) != 0;
			this.m_GkLongThrower = (andCheckIntField & 2097152) != 0;
			this.m_PowerHeader = (andCheckIntField & 4194304) != 0;
			this.m_GkOneOnOne = (andCheckIntField & 8388608) != 0;
			this.m_GiantThrow = (andCheckIntField & 16777216) != 0;
			this.m_OutsideFootShot = (andCheckIntField & 33554432) != 0;
			this.m_CrowdFavorite = (andCheckIntField & 67108864) != 0;
			this.m_SwervePasser = (andCheckIntField & 134217728) != 0;
			this.m_SecondWind = (andCheckIntField & 268435456) != 0;
			this.m_AcrobaticClearance = (andCheckIntField & 536870912) != 0;
			int andCheckIntField2 = r.GetAndCheckIntField(FI.players_trait2);
			this.m_FancyFeet = (andCheckIntField2 & 1) != 0;
			this.m_FancyPasses = (andCheckIntField2 & 2) != 0;
			this.m_FancyFlicks = (andCheckIntField2 & 4) != 0;
			this.m_StutterPenalty = (andCheckIntField2 & 8) != 0;
			this.m_ChipperPenalty = (andCheckIntField2 & 16) != 0;
			this.m_BycicleKick = (andCheckIntField2 & 32) != 0;
			this.m_DivingHeader = (andCheckIntField2 & 64) != 0;
			this.m_DrivenPass = (andCheckIntField2 & 128) != 0;
			this.m_GkFlatKick = (andCheckIntField2 & 256) != 0;
			this.m_HighClubIdentification = (andCheckIntField2 & 512) != 0;
			this.m_TeamPlayer = (andCheckIntField2 & 1024) != 0;
			this.m_assetid = base.Id;
			this.m_nationality = r.GetAndCheckIntField(FI.players_nationality);
			this.m_weakfootabilitytypecode = r.GetAndCheckIntField(FI.players_weakfootabilitytypecode);
			this.m_curve = r.GetAndCheckIntField(FI.players_curve);
			this.m_internationalrep = r.GetAndCheckIntField(FI.players_internationalrep) - 1;
			this.m_interceptions = r.GetAndCheckIntField(FI.players_interceptions);
			this.m_shoecolorcode2 = r.GetAndCheckIntField(FI.players_shoecolorcode2);
			this.m_jerseyfit = r.GetAndCheckIntField(FI.players_jerseyfit) != 0;
			this.m_shoedesigncode = r.GetAndCheckIntField(FI.players_shoedesigncode);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002DBAC File Offset: 0x0002BDAC
		public void UpdateFromOnlineRecord(Record r)
		{
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_birthdate));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_playerjointeamdate = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_playerjointeamdate));
			this.m_contractvaliduntil = r.GetAndCheckIntField(FI.players_contractvaliduntil);
			this.m_height = r.GetAndCheckIntField(FI.players_height);
			this.m_weight = r.GetAndCheckIntField(FI.players_weight);
			this.m_preferredposition1 = r.GetAndCheckIntField(FI.players_preferredposition1);
			this.m_preferredposition2 = r.GetAndCheckIntField(FI.players_preferredposition2);
			this.m_preferredposition3 = r.GetAndCheckIntField(FI.players_preferredposition3);
			this.m_preferredposition4 = r.GetAndCheckIntField(FI.players_preferredposition4);
			this.m_preferredfoot = r.GetAndCheckIntField(FI.players_preferredfoot) - 1;
			this.m_bodytypecode = r.GetAndCheckIntField(FI.players_bodytypecode) - 1;
			this.m_shoecolorcode1 = r.GetAndCheckIntField(FI.players_shoecolorcode1);
			this.m_shoetypecode = r.GetAndCheckIntField(FI.players_shoetypecode);
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(FI.players_jerseysleevelengthcode);
			this.m_eyecolorcode = r.GetAndCheckIntField(FI.players_eyecolorcode);
			this.m_eyebrowcode = r.GetAndCheckIntField(FI.players_eyebrowcode);
			this.m_facialhairtypecode = r.GetAndCheckIntField(FI.players_facialhairtypecode);
			this.m_facialhaircolorcode = r.GetAndCheckIntField(FI.players_facialhaircolorcode);
			this.m_hairtypecode = r.GetAndCheckIntField(FI.players_hairtypecode);
			this.m_haircolorcode = r.GetAndCheckIntField(FI.players_haircolorcode);
			this.m_headtypecode = r.GetAndCheckIntField(FI.players_headtypecode);
			this.m_sideburnscode = r.GetAndCheckIntField(FI.players_sideburnscode);
			this.m_skintypecode = r.GetAndCheckIntField(FI.players_skintypecode);
			this.m_skintonecode = r.GetAndCheckIntField(FI.players_skintonecode);
			this.m_overallrating = r.GetAndCheckIntField(FI.players_overallrating);
			this.m_jerseystylecode = r.GetAndCheckIntField(FI.players_jerseystylecode);
			this.m_hasseasonaljersey = r.GetAndCheckIntField(FI.players_hasseasonaljersey);
			this.m_animfreekickstartposcode = r.GetAndCheckIntField(FI.players_animfreekickstartposcode);
			this.m_animpenaltieskickstylecode = r.GetAndCheckIntField(FI.players_animpenaltieskickstylecode);
			this.m_animpenaltiesmotionstylecode = r.GetAndCheckIntField(FI.players_animpenaltiesmotionstylecode);
			this.m_animpenaltiesstartposcode = r.GetAndCheckIntField(FI.players_animpenaltiesstartposcode);
			this.m_accessorycode1 = r.GetAndCheckIntField(FI.players_accessorycode1);
			this.m_accessorycolourcode1 = r.GetAndCheckIntField(FI.players_accessorycolourcode1);
			this.m_accessorycode2 = r.GetAndCheckIntField(FI.players_accessorycode2);
			this.m_accessorycolourcode2 = r.GetAndCheckIntField(FI.players_accessorycolourcode2);
			this.m_accessorycode3 = r.GetAndCheckIntField(FI.players_accessorycode3);
			this.m_accessorycolourcode3 = r.GetAndCheckIntField(FI.players_accessorycolourcode3);
			this.m_accessorycode4 = r.GetAndCheckIntField(FI.players_accessorycode4);
			this.m_accessorycolourcode4 = r.GetAndCheckIntField(FI.players_accessorycolourcode4);
			this.m_acceleration = r.GetAndCheckIntField(FI.players_acceleration);
			this.m_aggression = r.GetAndCheckIntField(FI.players_aggression);
			this.m_ballcontrol = r.GetAndCheckIntField(FI.players_ballcontrol);
			this.m_crossing = r.GetAndCheckIntField(FI.players_crossing);
			this.m_dribbling = r.GetAndCheckIntField(FI.players_dribbling);
			this.m_finishing = r.GetAndCheckIntField(FI.players_finishing);
			this.m_freekickaccuracy = r.GetAndCheckIntField(FI.players_freekickaccuracy);
			this.m_headingaccuracy = r.GetAndCheckIntField(FI.players_headingaccuracy);
			this.m_longpassing = r.GetAndCheckIntField(FI.players_longpassing);
			this.m_longshots = r.GetAndCheckIntField(FI.players_longshots);
			this.m_marking = r.GetAndCheckIntField(FI.players_marking);
			this.m_positioning = r.GetAndCheckIntField(FI.players_positioning);
			this.m_potential = r.GetAndCheckIntField(FI.players_potential);
			this.m_reactions = r.GetAndCheckIntField(FI.players_reactions);
			this.m_shortpassing = r.GetAndCheckIntField(FI.players_shortpassing);
			this.m_shotpower = r.GetAndCheckIntField(FI.players_shotpower);
			this.m_sprintspeed = r.GetAndCheckIntField(FI.players_sprintspeed);
			this.m_stamina = r.GetAndCheckIntField(FI.players_stamina);
			this.m_strength = r.GetAndCheckIntField(FI.players_strength);
			this.m_standingtackle = r.GetAndCheckIntField(FI.players_standingtackle);
			this.m_slidingtackle = r.GetAndCheckIntField(FI.players_slidingtackle);
			this.m_gkdiving = r.GetAndCheckIntField(FI.players_gkdiving);
			this.m_gkpositioning = r.GetAndCheckIntField(FI.players_gkpositioning);
			this.m_gkhandling = r.GetAndCheckIntField(FI.players_gkhandling);
			this.m_gkreflexes = r.GetAndCheckIntField(FI.players_gkreflexes);
			this.m_gkglovetypecode = r.GetAndCheckIntField(FI.players_gkglovetypecode);
			this.m_agility = r.GetAndCheckIntField(FI.players_agility);
			this.m_balance = r.GetAndCheckIntField(FI.players_balance);
			this.m_gkkicking = r.GetAndCheckIntField(FI.players_gkkicking);
			this.m_gkkickstyle = r.GetAndCheckIntField(FI.players_gkkickstyle);
			this.m_jumping = r.GetAndCheckIntField(FI.players_jumping);
			this.m_penalties = r.GetAndCheckIntField(FI.players_penalties);
			this.m_vision = r.GetAndCheckIntField(FI.players_vision);
			this.m_volleys = r.GetAndCheckIntField(FI.players_volleys);
			this.m_gender = r.GetAndCheckIntField(FI.players_gender) != 0;
			this.m_emotion = r.GetAndCheckIntField(FI.players_emotion);
			this.m_skillmoves = r.GetAndCheckIntField(FI.players_skillmoves) + 1;
			this.m_usercaneditname = r.GetAndCheckIntField(FI.players_usercaneditname);
			this.m_finishingcode1 = r.GetAndCheckIntField(FI.players_finishingcode1);
			this.m_finishingcode2 = r.GetAndCheckIntField(FI.players_finishingcode2);
			this.m_runningcode1 = r.GetAndCheckIntField(FI.players_runningcode1);
			this.m_runningcode2 = r.GetAndCheckIntField(FI.players_runningcode2);
			this.m_gksavetype = r.GetAndCheckIntField(FI.players_gksavetype);
			this.m_faceposercode = r.GetAndCheckIntField(FI.players_faceposercode);
			this.m_isretiring = r.GetAndCheckIntField(FI.players_isretiring);
			this.m_socklengthcode = r.GetAndCheckIntField(FI.players_socklengthcode);
			this.m_hashighqualityhead = r.GetAndCheckIntField(FI.players_hashighqualityhead) != 0;
			this.m_attackingworkrate = r.GetAndCheckIntField(FI.players_attackingworkrate);
			this.m_defensiveworkrate = r.GetAndCheckIntField(FI.players_defensiveworkrate);
			this.m_shortstyle = r.GetAndCheckIntField(FI.players_shortstyle) != 0;
			int andCheckIntField = r.GetAndCheckIntField(FI.players_trait1);
			this.m_Inflexible = (andCheckIntField & 1) != 0;
			this.m_Longthrows = (andCheckIntField & 2) != 0;
			this.m_PowerfulFreeKicks = (andCheckIntField & 4) != 0;
			this.m_Diver = (andCheckIntField & 8) != 0;
			this.m_InjuryProne = (andCheckIntField & 16) != 0;
			this.m_InjuryFree = (andCheckIntField & 32) != 0;
			this.m_AvoidsWeakFoot = (andCheckIntField & 64) != 0;
			this.m_Divesintotackles = (andCheckIntField & 128) != 0;
			this.m_BeatDefensiveLine = (andCheckIntField & 256) != 0;
			this.m_Selfish = (andCheckIntField & 512) != 0;
			this.m_Leadership = (andCheckIntField & 1024) != 0;
			this.m_ArguesWithOfficials = (andCheckIntField & 2048) != 0;
			this.m_Earlycrosser = (andCheckIntField & 4096) != 0;
			this.m_FinesseShot = (andCheckIntField & 8192) != 0;
			this.m_Flair = (andCheckIntField & 16384) != 0;
			this.m_LongPasser = (andCheckIntField & 32768) != 0;
			this.m_LongShotTaker = (andCheckIntField & 65536) != 0;
			this.m_Technicaldribbler = (andCheckIntField & 131072) != 0;
			this.m_Playmaker = (andCheckIntField & 262144) != 0;
			this.m_Pushesupforcorners = (andCheckIntField & 524288) != 0;
			this.m_Puncher = (andCheckIntField & 1048576) != 0;
			this.m_GkLongThrower = (andCheckIntField & 2097152) != 0;
			this.m_PowerHeader = (andCheckIntField & 4194304) != 0;
			this.m_GkOneOnOne = (andCheckIntField & 8388608) != 0;
			this.m_GiantThrow = (andCheckIntField & 16777216) != 0;
			this.m_OutsideFootShot = (andCheckIntField & 33554432) != 0;
			this.m_CrowdFavorite = (andCheckIntField & 67108864) != 0;
			this.m_SwervePasser = (andCheckIntField & 134217728) != 0;
			this.m_SecondWind = (andCheckIntField & 268435456) != 0;
			this.m_AcrobaticClearance = (andCheckIntField & 536870912) != 0;
			int andCheckIntField2 = r.GetAndCheckIntField(FI.players_trait2);
			this.m_FancyFeet = (andCheckIntField2 & 1) != 0;
			this.m_FancyPasses = (andCheckIntField2 & 2) != 0;
			this.m_FancyFlicks = (andCheckIntField2 & 4) != 0;
			this.m_StutterPenalty = (andCheckIntField2 & 8) != 0;
			this.m_ChipperPenalty = (andCheckIntField2 & 16) != 0;
			this.m_BycicleKick = (andCheckIntField2 & 32) != 0;
			this.m_DivingHeader = (andCheckIntField2 & 64) != 0;
			this.m_DrivenPass = (andCheckIntField2 & 128) != 0;
			this.m_GkFlatKick = (andCheckIntField2 & 256) != 0;
			this.m_HighClubIdentification = (andCheckIntField2 & 512) != 0;
			this.m_TeamPlayer = (andCheckIntField2 & 1024) != 0;
			this.m_assetid = base.Id;
			this.m_nationality = r.GetAndCheckIntField(FI.players_nationality);
			this.m_weakfootabilitytypecode = r.GetAndCheckIntField(FI.players_weakfootabilitytypecode);
			this.m_curve = r.GetAndCheckIntField(FI.players_curve);
			this.m_internationalrep = r.GetAndCheckIntField(FI.players_internationalrep) - 1;
			this.m_interceptions = r.GetAndCheckIntField(FI.players_interceptions);
			this.m_shoecolorcode2 = r.GetAndCheckIntField(FI.players_shoecolorcode2);
			this.m_jerseyfit = r.GetAndCheckIntField(FI.players_jerseyfit) != 0;
			this.m_shoedesigncode = r.GetAndCheckIntField(FI.players_shoedesigncode);
			this.m_IsLoaned = false;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002E578 File Offset: 0x0002C778
		public void UpdateFromOnlineRecord17(Record r, TableDescriptor td)
		{
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(td.GetFieldIndex("birthdate")));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_playerjointeamdate = FifaUtil.ConvertToDate(r.GetAndCheckIntField(td.GetFieldIndex("playerjointeamdate")));
			this.m_contractvaliduntil = r.GetAndCheckIntField(td.GetFieldIndex("contractvaliduntil"));
			this.m_height = r.GetAndCheckIntField(td.GetFieldIndex("height"));
			this.m_weight = r.GetAndCheckIntField(td.GetFieldIndex("weight"));
			this.m_preferredposition1 = r.GetAndCheckIntField(td.GetFieldIndex("preferredposition1"));
			this.m_preferredposition2 = r.GetAndCheckIntField(td.GetFieldIndex("preferredposition2"));
			this.m_preferredposition3 = r.GetAndCheckIntField(td.GetFieldIndex("preferredposition3"));
			this.m_preferredposition4 = r.GetAndCheckIntField(td.GetFieldIndex("preferredposition4"));
			this.m_preferredfoot = r.GetAndCheckIntField(td.GetFieldIndex("preferredfoot")) - 1;
			this.m_bodytypecode = r.GetAndCheckIntField(td.GetFieldIndex("bodytypecode")) - 1;
			this.m_shoecolorcode1 = r.GetAndCheckIntField(td.GetFieldIndex("shoecolorcode1"));
			this.m_shoetypecode = r.GetAndCheckIntField(td.GetFieldIndex("shoetypecode"));
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(td.GetFieldIndex("jerseysleevelengthcode"));
			this.m_eyecolorcode = r.GetAndCheckIntField(td.GetFieldIndex("eyecolorcode"));
			this.m_eyebrowcode = r.GetAndCheckIntField(td.GetFieldIndex("eyebrowcode"));
			this.m_facialhairtypecode = r.GetAndCheckIntField(td.GetFieldIndex("facialhairtypecode"));
			if (this.m_facialhairtypecode == 16)
			{
				this.m_facialhairtypecode = 0;
			}
			else if (this.m_facialhairtypecode == 17)
			{
				this.m_facialhairtypecode = 9;
			}
			this.m_facialhaircolorcode = r.GetAndCheckIntField(td.GetFieldIndex("facialhaircolorcode"));
			this.m_hairtypecode = r.GetAndCheckIntField(td.GetFieldIndex("hairtypecode"));
			if (this.m_hairtypecode >= 125)
			{
				switch (this.m_hairtypecode)
				{
				case 125:
					this.m_hairtypecode = 20;
					break;
				case 126:
					this.m_hairtypecode = 509;
					break;
				case 127:
					this.m_hairtypecode = 107;
					break;
				case 128:
					this.m_hairtypecode = 14;
					break;
				case 129:
					this.m_hairtypecode = 115;
					break;
				case 130:
					this.m_hairtypecode = 509;
					break;
				case 131:
					this.m_hairtypecode = 514;
					break;
				case 132:
					this.m_hairtypecode = 120;
					break;
				case 133:
					this.m_hairtypecode = 119;
					break;
				case 134:
					this.m_hairtypecode = 77;
					break;
				case 135:
					this.m_hairtypecode = 42;
					break;
				case 136:
					this.m_hairtypecode = 95;
					break;
				case 137:
					this.m_hairtypecode = 78;
					break;
				case 138:
					this.m_hairtypecode = 101;
					break;
				case 139:
					this.m_hairtypecode = 67;
					break;
				case 140:
					this.m_hairtypecode = 42;
					break;
				case 141:
					this.m_hairtypecode = 115;
					break;
				case 142:
					this.m_hairtypecode = 116;
					break;
				case 143:
					this.m_hairtypecode = 108;
					break;
				case 144:
					this.m_hairtypecode = 122;
					break;
				case 145:
					this.m_hairtypecode = 58;
					break;
				case 146:
					this.m_hairtypecode = 64;
					break;
				case 147:
					this.m_hairtypecode = 39;
					break;
				case 148:
					this.m_hairtypecode = 90;
					break;
				case 149:
					this.m_hairtypecode = 118;
					break;
				case 150:
					this.m_hairtypecode = 114;
					break;
				case 151:
					this.m_hairtypecode = 78;
					break;
				}
			}
			this.m_haircolorcode = r.GetAndCheckIntField(td.GetFieldIndex("haircolorcode"));
			if (this.m_haircolorcode == 13)
			{
				this.m_facialhairtypecode = 3;
			}
			this.m_headtypecode = r.GetAndCheckIntField(td.GetFieldIndex("headtypecode"));
			if (this.m_headtypecode >= 533 && this.m_headtypecode <= 547)
			{
				this.m_headtypecode = Player.m_Randomizer.Next(500, 533);
			}
			if (this.m_headtypecode >= 533 && this.m_headtypecode <= 547)
			{
				this.m_headtypecode = Player.m_Randomizer.Next(500, 533);
			}
			this.m_sideburnscode = r.GetAndCheckIntField(td.GetFieldIndex("sideburnscode"));
			this.m_skintypecode = r.GetAndCheckIntField(td.GetFieldIndex("skintypecode"));
			this.m_skintonecode = r.GetAndCheckIntField(td.GetFieldIndex("skintonecode"));
			this.m_overallrating = r.GetAndCheckIntField(td.GetFieldIndex("overallrating"));
			this.m_jerseystylecode = r.GetAndCheckIntField(td.GetFieldIndex("jerseystylecode"));
			this.m_hasseasonaljersey = r.GetAndCheckIntField(td.GetFieldIndex("hasseasonaljersey"));
			this.m_animfreekickstartposcode = r.GetAndCheckIntField(td.GetFieldIndex("animfreekickstartposcode"));
			this.m_animpenaltieskickstylecode = r.GetAndCheckIntField(td.GetFieldIndex("animpenaltieskickstylecode"));
			this.m_animpenaltiesmotionstylecode = r.GetAndCheckIntField(td.GetFieldIndex("animpenaltiesmotionstylecode"));
			this.m_animpenaltiesstartposcode = r.GetAndCheckIntField(td.GetFieldIndex("animpenaltiesstartposcode"));
			this.m_accessorycode1 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycode1"));
			this.m_accessorycolourcode1 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycolourcode1"));
			this.m_accessorycode2 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycode2"));
			this.m_accessorycolourcode2 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycolourcode2"));
			this.m_accessorycode3 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycode3"));
			this.m_accessorycolourcode3 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycolourcode3"));
			this.m_accessorycode4 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycode4"));
			this.m_accessorycolourcode4 = r.GetAndCheckIntField(td.GetFieldIndex("accessorycolourcode4"));
			this.m_acceleration = r.GetAndCheckIntField(td.GetFieldIndex("acceleration"));
			this.m_aggression = r.GetAndCheckIntField(td.GetFieldIndex("aggression"));
			this.m_ballcontrol = r.GetAndCheckIntField(td.GetFieldIndex("ballcontrol"));
			this.m_crossing = r.GetAndCheckIntField(td.GetFieldIndex("crossing"));
			this.m_dribbling = r.GetAndCheckIntField(td.GetFieldIndex("dribbling"));
			this.m_finishing = r.GetAndCheckIntField(td.GetFieldIndex("finishing"));
			this.m_freekickaccuracy = r.GetAndCheckIntField(td.GetFieldIndex("freekickaccuracy"));
			this.m_headingaccuracy = r.GetAndCheckIntField(td.GetFieldIndex("headingaccuracy"));
			this.m_longpassing = r.GetAndCheckIntField(td.GetFieldIndex("longpassing"));
			this.m_longshots = r.GetAndCheckIntField(td.GetFieldIndex("longshots"));
			this.m_marking = r.GetAndCheckIntField(td.GetFieldIndex("marking"));
			this.m_positioning = r.GetAndCheckIntField(td.GetFieldIndex("positioning"));
			this.m_potential = r.GetAndCheckIntField(td.GetFieldIndex("potential"));
			this.m_reactions = r.GetAndCheckIntField(td.GetFieldIndex("reactions"));
			this.m_shortpassing = r.GetAndCheckIntField(td.GetFieldIndex("shortpassing"));
			this.m_shotpower = r.GetAndCheckIntField(td.GetFieldIndex("shotpower"));
			this.m_sprintspeed = r.GetAndCheckIntField(td.GetFieldIndex("sprintspeed"));
			this.m_stamina = r.GetAndCheckIntField(td.GetFieldIndex("stamina"));
			this.m_strength = r.GetAndCheckIntField(td.GetFieldIndex("strength"));
			this.m_standingtackle = r.GetAndCheckIntField(td.GetFieldIndex("standingtackle"));
			this.m_slidingtackle = r.GetAndCheckIntField(td.GetFieldIndex("slidingtackle"));
			this.m_gkdiving = r.GetAndCheckIntField(td.GetFieldIndex("gkdiving"));
			this.m_gkpositioning = r.GetAndCheckIntField(td.GetFieldIndex("gkpositioning"));
			this.m_gkhandling = r.GetAndCheckIntField(td.GetFieldIndex("gkhandling"));
			this.m_gkreflexes = r.GetAndCheckIntField(td.GetFieldIndex("gkreflexes"));
			this.m_gkglovetypecode = r.GetAndCheckIntField(td.GetFieldIndex("gkglovetypecode"));
			this.m_agility = r.GetAndCheckIntField(td.GetFieldIndex("agility"));
			this.m_balance = r.GetAndCheckIntField(td.GetFieldIndex("balance"));
			this.m_gkkicking = r.GetAndCheckIntField(td.GetFieldIndex("gkkicking"));
			this.m_gkkickstyle = r.GetAndCheckIntField(td.GetFieldIndex("gkkickstyle"));
			this.m_jumping = r.GetAndCheckIntField(td.GetFieldIndex("jumping"));
			this.m_penalties = r.GetAndCheckIntField(td.GetFieldIndex("penalties"));
			this.m_vision = r.GetAndCheckIntField(td.GetFieldIndex("vision"));
			this.m_volleys = r.GetAndCheckIntField(td.GetFieldIndex("volleys"));
			this.m_gender = r.GetAndCheckIntField(td.GetFieldIndex("gender")) != 0;
			this.m_emotion = r.GetAndCheckIntField(td.GetFieldIndex("emotion"));
			this.m_skillmoves = r.GetAndCheckIntField(td.GetFieldIndex("skillmoves")) + 1;
			this.m_usercaneditname = r.GetAndCheckIntField(td.GetFieldIndex("usercaneditname"));
			this.m_finishingcode1 = r.GetAndCheckIntField(td.GetFieldIndex("finishingcode1"));
			this.m_finishingcode2 = r.GetAndCheckIntField(td.GetFieldIndex("finishingcode2"));
			this.m_runningcode1 = r.GetAndCheckIntField(td.GetFieldIndex("runningcode1"));
			this.m_runningcode2 = r.GetAndCheckIntField(td.GetFieldIndex("runningcode2"));
			this.m_gksavetype = r.GetAndCheckIntField(td.GetFieldIndex("gksavetype"));
			this.m_faceposercode = r.GetAndCheckIntField(td.GetFieldIndex("faceposercode"));
			this.m_isretiring = r.GetAndCheckIntField(td.GetFieldIndex("isretiring"));
			this.m_socklengthcode = r.GetAndCheckIntField(td.GetFieldIndex("socklengthcode"));
			this.m_hashighqualityhead = r.GetAndCheckIntField(td.GetFieldIndex("hashighqualityhead")) != 0;
			this.m_attackingworkrate = r.GetAndCheckIntField(td.GetFieldIndex("attackingworkrate"));
			this.m_defensiveworkrate = r.GetAndCheckIntField(td.GetFieldIndex("defensiveworkrate"));
			this.m_shortstyle = r.GetAndCheckIntField(td.GetFieldIndex("shortstyle")) != 0;
			int andCheckIntField = r.GetAndCheckIntField(td.GetFieldIndex("trait1"));
			this.m_Inflexible = (andCheckIntField & 1) != 0;
			this.m_Longthrows = (andCheckIntField & 2) != 0;
			this.m_PowerfulFreeKicks = (andCheckIntField & 4) != 0;
			this.m_Diver = (andCheckIntField & 8) != 0;
			this.m_InjuryProne = (andCheckIntField & 16) != 0;
			this.m_InjuryFree = (andCheckIntField & 32) != 0;
			this.m_AvoidsWeakFoot = (andCheckIntField & 64) != 0;
			this.m_Divesintotackles = (andCheckIntField & 128) != 0;
			this.m_BeatDefensiveLine = (andCheckIntField & 256) != 0;
			this.m_Selfish = (andCheckIntField & 512) != 0;
			this.m_Leadership = (andCheckIntField & 1024) != 0;
			this.m_ArguesWithOfficials = (andCheckIntField & 2048) != 0;
			this.m_Earlycrosser = (andCheckIntField & 4096) != 0;
			this.m_FinesseShot = (andCheckIntField & 8192) != 0;
			this.m_Flair = (andCheckIntField & 16384) != 0;
			this.m_LongPasser = (andCheckIntField & 32768) != 0;
			this.m_LongShotTaker = (andCheckIntField & 65536) != 0;
			this.m_Technicaldribbler = (andCheckIntField & 131072) != 0;
			this.m_Playmaker = (andCheckIntField & 262144) != 0;
			this.m_Pushesupforcorners = (andCheckIntField & 524288) != 0;
			this.m_Puncher = (andCheckIntField & 1048576) != 0;
			this.m_GkLongThrower = (andCheckIntField & 2097152) != 0;
			this.m_PowerHeader = (andCheckIntField & 4194304) != 0;
			this.m_GkOneOnOne = (andCheckIntField & 8388608) != 0;
			this.m_GiantThrow = (andCheckIntField & 16777216) != 0;
			this.m_OutsideFootShot = (andCheckIntField & 33554432) != 0;
			this.m_CrowdFavorite = (andCheckIntField & 67108864) != 0;
			this.m_SwervePasser = (andCheckIntField & 134217728) != 0;
			this.m_SecondWind = (andCheckIntField & 268435456) != 0;
			this.m_AcrobaticClearance = (andCheckIntField & 536870912) != 0;
			int andCheckIntField2 = r.GetAndCheckIntField(td.GetFieldIndex("trait2"));
			this.m_FancyFeet = (andCheckIntField2 & 1) != 0;
			this.m_FancyPasses = (andCheckIntField2 & 2) != 0;
			this.m_FancyFlicks = (andCheckIntField2 & 4) != 0;
			this.m_StutterPenalty = (andCheckIntField2 & 8) != 0;
			this.m_ChipperPenalty = (andCheckIntField2 & 16) != 0;
			this.m_BycicleKick = (andCheckIntField2 & 32) != 0;
			this.m_DivingHeader = (andCheckIntField2 & 64) != 0;
			this.m_DrivenPass = (andCheckIntField2 & 128) != 0;
			this.m_GkFlatKick = (andCheckIntField2 & 256) != 0;
			this.m_HighClubIdentification = (andCheckIntField2 & 512) != 0;
			this.m_TeamPlayer = (andCheckIntField2 & 1024) != 0;
			this.m_assetid = base.Id;
			this.m_nationality = r.GetAndCheckIntField(td.GetFieldIndex("nationality"));
			this.m_weakfootabilitytypecode = r.GetAndCheckIntField(td.GetFieldIndex("weakfootabilitytypecode"));
			this.m_curve = r.GetAndCheckIntField(td.GetFieldIndex("curve"));
			this.m_internationalrep = r.GetAndCheckIntField(td.GetFieldIndex("internationalrep")) - 1;
			this.m_interceptions = r.GetAndCheckIntField(td.GetFieldIndex("interceptions"));
			this.m_shoecolorcode2 = r.GetAndCheckIntField(td.GetFieldIndex("shoecolorcode2"));
			this.m_jerseyfit = r.GetAndCheckIntField(td.GetFieldIndex("jerseyfit")) != 0;
			this.m_shoedesigncode = r.GetAndCheckIntField(td.GetFieldIndex("shoedesigncode"));
			this.m_IsLoaned = false;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0002F3FF File Offset: 0x0002D5FF
		public void FillFromPlayerloans(Record r)
		{
			this.m_teamidloanedfrom = r.GetAndCheckIntField(FI.playerloans_teamidloanedfrom);
			this.m_loandateend = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.playerloans_loandateend));
			this.m_IsLoaned = true;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0002F42F File Offset: 0x0002D62F
		public void FillFromPreviousTeam(Record r)
		{
			this.m_previousteamid = r.GetAndCheckIntField(FI.previousteam_previousteamid);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0002F444 File Offset: 0x0002D644
		public void FillFromEditedPlayerNames(Record r)
		{
			this.m_firstname = r.GetAndCheckStringField(FI.editedplayernames_firstname);
			this.m_lastname = r.GetAndCheckStringField(FI.editedplayernames_surname);
			this.m_commonname = r.GetAndCheckStringField(FI.editedplayernames_commonname);
			this.m_playerjerseyname = r.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
			this.m_IsLoaned = true;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0002F49C File Offset: 0x0002D69C
		public void SavePlayerloans(Record r)
		{
			r.IntField[FI.playerloans_playerid] = base.Id;
			r.IntField[FI.playerloans_teamidloanedfrom] = this.m_teamidloanedfrom;
			r.IntField[FI.playerloans_loandateend] = FifaUtil.ConvertFromDate(this.m_loandateend);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0002F4D9 File Offset: 0x0002D6D9
		public void SavePreviousTeam(Record r)
		{
			r.IntField[FI.previousteam_playerid] = base.Id;
			r.IntField[FI.previousteam_previousteamid] = this.m_previousteamid;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002F500 File Offset: 0x0002D700
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_nationality);
			if (this.m_Country == null)
			{
				if (countryList.Count > 0)
				{
					this.m_Country = (Country)countryList[0];
					this.m_nationality = this.m_Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002F564 File Offset: 0x0002D764
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			if (this.m_teamidloanedfrom != 0)
			{
				this.m_TeamLoanedFrom = (Team)teamList.SearchId(this.m_teamidloanedfrom);
				if (this.m_TeamLoanedFrom == null)
				{
					this.m_teamidloanedfrom = 0;
				}
			}
			if (this.m_previousteamid != 0)
			{
				this.m_PreviousTeam = (Team)teamList.SearchId(this.m_previousteamid);
				if (this.m_PreviousTeam == null)
				{
					this.m_previousteamid = 0;
				}
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		public void SearchCountry()
		{
			if (FifaEnvironment.Countries == null)
			{
				this.m_Country = null;
				return;
			}
			this.m_Country = (Country)FifaEnvironment.Countries.SearchId(this.m_nationality);
			if (this.m_Country == null)
			{
				if (FifaEnvironment.Countries.Count > 0)
				{
					this.m_Country = (Country)FifaEnvironment.Countries[0];
					this.m_nationality = this.m_Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00006DE3 File Offset: 0x00004FE3
		public void SearchWouldTeams()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0002F650 File Offset: 0x0002D850
		public void InitNewPlayer()
		{
			this.m_firstname = string.Empty;
			this.m_lastname = "New Player";
			this.m_commentaryid = 900000;
			this.m_commonname = string.Empty;
			this.m_playerjerseyname = "New Player";
			this.m_playerjerseynameid = 0;
			this.m_firstnameid = 0;
			this.m_commonnameid = 0;
			this.m_lastnameid = 0;
			this.m_birthdate = new DateTime(1980, 6, 15);
			this.m_playerjointeamdate = new DateTime(2014, 1, 1);
			this.m_contractvaliduntil = 2017;
			this.m_height = 180;
			this.m_weight = 80;
			this.m_preferredposition1 = 0;
			this.m_preferredposition2 = -1;
			this.m_preferredposition3 = -1;
			this.m_preferredposition4 = -1;
			this.m_preferredfoot = 0;
			this.m_jerseysleevelengthcode = 0;
			this.m_jerseystylecode = 0;
			this.m_hasseasonaljersey = 0;
			this.m_animfreekickstartposcode = 0;
			this.m_animpenaltieskickstylecode = 0;
			this.m_animpenaltiesmotionstylecode = 0;
			this.m_animpenaltiesstartposcode = 0;
			this.m_accessorycode1 = 0;
			this.m_accessorycolourcode1 = 1;
			this.m_accessorycode2 = 0;
			this.m_accessorycolourcode2 = 1;
			this.m_accessorycode3 = 0;
			this.m_accessorycolourcode3 = 1;
			this.m_accessorycode4 = 0;
			this.m_accessorycolourcode4 = 1;
			this.m_acceleration = 50;
			this.m_aggression = 50;
			this.m_sprintspeed = 50;
			this.m_stamina = 50;
			this.m_strength = 50;
			this.m_marking = 50;
			this.m_standingtackle = 50;
			this.m_slidingtackle = 50;
			this.m_ballcontrol = 50;
			this.m_dribbling = 50;
			this.m_crossing = 50;
			this.m_headingaccuracy = 50;
			this.m_shortpassing = 50;
			this.m_longpassing = 50;
			this.m_longshots = 50;
			this.m_finishing = 50;
			this.m_shotpower = 50;
			this.m_reactions = 50;
			this.m_gkreflexes = 50;
			this.m_gkglovetypecode = 0;
			this.m_agility = 50;
			this.m_balance = 50;
			this.m_gkkicking = 50;
			this.m_gkkickstyle = 0;
			this.m_jumping = 50;
			this.m_penalties = 50;
			this.m_vision = 50;
			this.m_volleys = 50;
			this.m_skillmoves = 1;
			this.m_usercaneditname = 0;
			this.m_gkhandling = 50;
			this.m_gkdiving = 50;
			this.m_gkpositioning = 50;
			this.m_freekickaccuracy = 50;
			this.m_positioning = 50;
			this.m_InjuryFree = false;
			this.m_HighClubIdentification = false;
			this.m_TeamPlayer = false;
			this.m_Leadership = false;
			this.m_ArguesWithOfficials = false;
			this.m_AvoidsWeakFoot = false;
			this.m_InjuryProne = false;
			this.m_Puncher = false;
			this.m_Pushesupforcorners = false;
			this.m_Technicaldribbler = false;
			this.m_Selfish = false;
			this.m_Playmaker = false;
			this.m_Diver = false;
			this.m_Divesintotackles = false;
			this.m_LongShotTaker = false;
			this.m_Earlycrosser = false;
			this.m_Inflexible = false;
			this.m_GkOneOnOne = false;
			this.m_Longthrows = false;
			this.m_OutsideFootShot = false;
			this.m_LongPasser = false;
			this.m_GiantThrow = false;
			this.m_Flair = false;
			this.m_PowerfulFreeKicks = false;
			this.m_FinesseShot = false;
			this.m_PowerHeader = false;
			this.m_SwervePasser = false;
			this.m_BeatDefensiveLine = false;
			this.m_GkLongThrower = false;
			this.m_CrowdFavorite = false;
			this.m_SecondWind = false;
			this.m_AcrobaticClearance = false;
			this.m_FancyFeet = false;
			this.m_FancyPasses = false;
			this.m_FancyFlicks = false;
			this.m_StutterPenalty = false;
			this.m_ChipperPenalty = false;
			this.m_BycicleKick = false;
			this.m_DivingHeader = false;
			this.m_DrivenPass = false;
			this.m_GkFlatKick = false;
			this.m_assetid = base.Id;
			this.m_potential = 50;
			this.m_nationality = 0;
			this.SearchCountry();
			this.m_bodytypecode = 1;
			this.m_weakfootabilitytypecode = 3;
			this.m_curve = 50;
			this.m_internationalrep = 2;
			this.m_eyecolorcode = 1;
			this.m_eyebrowcode = 0;
			this.m_hairtypecode = 1;
			this.m_headtypecode = 1;
			this.m_headclasscode = 1;
			this.m_haircolorcode = 1;
			this.m_facialhairtypecode = 0;
			this.m_facialhaircolorcode = 0;
			this.m_sideburnscode = 1;
			this.m_skintypecode = 0;
			this.m_skintonecode = 2;
			this.m_shoecolorcode1 = 1;
			this.m_shoetypecode = 0;
			this.m_overallrating = 50;
			this.m_finishingcode1 = 0;
			this.m_finishingcode2 = 0;
			this.m_runningcode1 = 0;
			this.m_runningcode2 = 0;
			this.m_gksavetype = 0;
			this.m_faceposercode = 0;
			this.m_isretiring = 0;
			this.m_socklengthcode = 0;
			this.m_hashighqualityhead = false;
			this.m_gender = false;
			this.m_emotion = 3;
			this.m_attackingworkrate = 0;
			this.m_defensiveworkrate = 0;
			this.m_shortstyle = false;
			this.m_interceptions = 50;
			this.m_shoecolorcode2 = 31;
			this.m_jerseyfit = false;
			this.m_shoedesigncode = 0;
			this.m_preferredNumber = 0;
			this.m_IsLoaned = false;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002FAE1 File Offset: 0x0002DCE1
		public Player(int playerId)
			: base(playerId)
		{
			base.Id = playerId;
			this.InitNewPlayer();
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0002FB04 File Offset: 0x0002DD04
		public override IdObject Clone(int playerid)
		{
			Player player = (Player)base.Clone(playerid);
			player.m_lastname = "Player_" + player.Id.ToString();
			Player player2 = player;
			player2.m_commentaryid = player2.m_commentaryid;
			player.m_firstname = string.Empty;
			player.m_assetid = playerid;
			player.m_PlayingForTeams = new TeamList();
			player.m_HasSpecificPhoto = false;
			player.m_HeadModelFile = null;
			player.m_HairModelFile = null;
			player.m_FaceTextureBitmaps = null;
			player.m_HairColorTextureBitmap = null;
			player.m_HairAlfaTextureBitmap = null;
			return player;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002FB90 File Offset: 0x0002DD90
		public Player Copy(Player clone)
		{
			clone.m_birthdate = this.m_birthdate;
			clone.m_playerjointeamdate = this.m_playerjointeamdate;
			clone.m_contractvaliduntil = this.m_contractvaliduntil;
			clone.m_nationality = this.m_nationality;
			clone.m_Country = this.m_Country;
			clone.m_height = this.m_height;
			clone.m_weight = this.m_weight;
			clone.m_bodytypecode = this.m_bodytypecode;
			clone.m_jerseysleevelengthcode = this.m_jerseysleevelengthcode;
			clone.m_jerseystylecode = this.m_jerseystylecode;
			clone.m_hasseasonaljersey = this.m_hasseasonaljersey;
			clone.m_animfreekickstartposcode = this.m_animfreekickstartposcode;
			clone.m_animpenaltieskickstylecode = this.m_animpenaltieskickstylecode;
			clone.m_animpenaltiesmotionstylecode = this.m_animpenaltiesmotionstylecode;
			clone.m_animpenaltiesstartposcode = this.m_animpenaltiesstartposcode;
			clone.m_accessorycode1 = this.m_accessorycode1;
			clone.m_accessorycolourcode1 = this.m_accessorycolourcode1;
			clone.m_accessorycode2 = this.m_accessorycode2;
			clone.m_accessorycolourcode2 = this.m_accessorycolourcode2;
			clone.m_accessorycode3 = this.m_accessorycode3;
			clone.m_accessorycolourcode3 = this.m_accessorycolourcode3;
			clone.m_accessorycode4 = this.m_accessorycode4;
			clone.m_accessorycolourcode4 = this.m_accessorycolourcode4;
			clone.m_preferredposition1 = this.m_preferredposition1;
			clone.m_preferredposition2 = this.m_preferredposition2;
			clone.m_preferredposition3 = this.m_preferredposition3;
			clone.m_preferredposition4 = this.m_preferredposition4;
			clone.m_preferredfoot = this.m_preferredfoot;
			clone.m_weakfootabilitytypecode = this.m_weakfootabilitytypecode;
			clone.m_acceleration = this.m_acceleration;
			clone.m_aggression = this.m_aggression;
			clone.m_sprintspeed = this.m_sprintspeed;
			clone.m_stamina = this.m_stamina;
			clone.m_strength = this.m_strength;
			clone.m_marking = this.m_marking;
			clone.m_interceptions = this.m_interceptions;
			clone.m_standingtackle = this.m_standingtackle;
			clone.m_slidingtackle = this.m_slidingtackle;
			clone.m_ballcontrol = this.m_ballcontrol;
			clone.m_dribbling = this.m_dribbling;
			clone.m_crossing = this.m_crossing;
			clone.m_headingaccuracy = this.m_headingaccuracy;
			clone.m_shortpassing = this.m_shortpassing;
			clone.m_longpassing = this.m_longpassing;
			clone.m_longshots = this.m_longshots;
			clone.m_finishing = this.m_finishing;
			clone.m_shotpower = this.m_shotpower;
			clone.m_reactions = this.m_reactions;
			clone.m_gkreflexes = this.m_gkreflexes;
			clone.m_gkglovetypecode = this.m_gkglovetypecode;
			clone.m_agility = this.m_agility;
			clone.m_balance = this.m_balance;
			clone.m_gkkicking = this.m_gkkicking;
			clone.m_gkkickstyle = this.m_gkkickstyle;
			clone.m_jumping = this.m_jumping;
			clone.m_penalties = this.m_penalties;
			clone.m_vision = this.m_vision;
			clone.m_volleys = this.m_volleys;
			clone.m_skillmoves = this.m_skillmoves;
			clone.m_usercaneditname = this.m_usercaneditname;
			clone.m_gkhandling = this.m_gkhandling;
			clone.m_gkdiving = this.m_gkdiving;
			clone.m_gkpositioning = this.m_gkpositioning;
			clone.m_positioning = this.m_positioning;
			clone.m_freekickaccuracy = this.m_freekickaccuracy;
			clone.m_potential = this.m_potential;
			clone.m_InjuryFree = this.m_InjuryFree;
			clone.m_HighClubIdentification = this.m_HighClubIdentification;
			clone.m_TeamPlayer = this.m_TeamPlayer;
			clone.m_Leadership = this.m_Leadership;
			clone.m_ArguesWithOfficials = this.m_ArguesWithOfficials;
			clone.m_AvoidsWeakFoot = this.m_AvoidsWeakFoot;
			clone.m_InjuryProne = this.m_InjuryProne;
			clone.m_Puncher = this.m_Puncher;
			clone.m_Pushesupforcorners = this.m_Pushesupforcorners;
			clone.m_Technicaldribbler = this.m_Technicaldribbler;
			clone.m_Selfish = this.m_Selfish;
			clone.m_Playmaker = this.m_Playmaker;
			clone.m_Diver = this.m_Diver;
			clone.m_Divesintotackles = this.m_Divesintotackles;
			clone.m_LongShotTaker = this.m_LongShotTaker;
			clone.m_Earlycrosser = this.m_Earlycrosser;
			clone.m_Inflexible = this.m_Inflexible;
			clone.m_GkOneOnOne = this.m_GkOneOnOne;
			clone.m_Longthrows = this.m_Longthrows;
			clone.m_OutsideFootShot = this.m_OutsideFootShot;
			clone.m_LongPasser = this.m_LongPasser;
			clone.m_GiantThrow = this.m_GiantThrow;
			clone.m_Flair = this.m_Flair;
			clone.m_PowerfulFreeKicks = this.m_PowerfulFreeKicks;
			clone.m_FinesseShot = this.m_FinesseShot;
			clone.m_PowerHeader = this.m_PowerHeader;
			clone.m_SwervePasser = this.m_SwervePasser;
			clone.m_BeatDefensiveLine = this.m_BeatDefensiveLine;
			clone.m_GkLongThrower = this.m_GkLongThrower;
			clone.m_FancyFeet = this.m_FancyFeet;
			clone.m_FancyPasses = this.m_FancyPasses;
			clone.m_FancyFlicks = this.m_FancyFlicks;
			clone.m_StutterPenalty = this.m_StutterPenalty;
			clone.m_ChipperPenalty = this.m_ChipperPenalty;
			clone.m_BycicleKick = this.m_BycicleKick;
			clone.m_DivingHeader = this.m_DivingHeader;
			clone.m_DrivenPass = this.m_DrivenPass;
			clone.m_GkFlatKick = this.m_GkFlatKick;
			clone.m_curve = this.m_curve;
			clone.m_internationalrep = this.m_internationalrep + 1;
			clone.m_eyecolorcode = this.m_eyecolorcode;
			clone.m_eyebrowcode = this.m_eyebrowcode;
			clone.m_hairtypecode = this.m_hairtypecode;
			clone.m_headtypecode = this.m_headtypecode;
			clone.m_headclasscode = 1;
			clone.m_haircolorcode = this.m_haircolorcode;
			clone.m_facialhairtypecode = this.m_facialhairtypecode;
			clone.m_facialhaircolorcode = this.m_facialhaircolorcode;
			clone.m_sideburnscode = this.m_sideburnscode;
			clone.m_skintypecode = this.m_skintypecode;
			clone.m_skintonecode = this.m_skintonecode;
			clone.m_shoecolorcode1 = this.m_shoecolorcode1;
			clone.m_shoecolorcode2 = this.m_shoecolorcode2;
			clone.m_shoetypecode = this.m_shoetypecode;
			clone.m_shoedesigncode = this.m_shoedesigncode;
			clone.m_overallrating = this.m_overallrating;
			clone.m_HasSpecificPhoto = false;
			return clone;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0003015A File Offset: 0x0002E35A
		public string SpecificFaceTextureFileName()
		{
			return Player.SpecificFaceTextureFileName(base.Id);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00030167 File Offset: 0x0002E367
		public static string SpecificFaceTextureFileName(int id)
		{
			return "data/sceneassets/faces/face_" + id.ToString() + "_0_0_0_0_0_0_0_0_textures.rx3";
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00030180 File Offset: 0x0002E380
		public string GenericFaceTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/skin_",
				this.m_skintonecode.ToString(),
				"_",
				this.m_skintypecode.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000301CC File Offset: 0x0002E3CC
		public string GenericSkinTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/skin_",
				this.m_skintonecode.ToString(),
				"_",
				this.m_skintypecode.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00030218 File Offset: 0x0002E418
		public static string GenericSkinTextureFileName(int skintone, int skintype)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/skin_",
				skintone.ToString(),
				"_",
				skintype.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00030254 File Offset: 0x0002E454
		public string GenericBearTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/beard_",
				this.m_skintonecode.ToString(),
				"_",
				this.m_facialhairtypecode.ToString(),
				"_",
				this.m_facialhaircolorcode.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000302B8 File Offset: 0x0002E4B8
		public static string GenericBearTextureFileName(int skintone, int facialhairtype, int facialhaircolor)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/beard_",
				skintone.ToString(),
				"_",
				facialhairtype.ToString(),
				"_",
				facialhaircolor.ToString(),
				".rx3"
			});
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00030310 File Offset: 0x0002E510
		public string GenericBrowTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/brow_",
				this.m_skintonecode.ToString(),
				"_",
				this.m_eyebrowcode.ToString(),
				"_",
				this.m_facialhaircolorcode.ToString(),
				".rx3"
			});
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00030374 File Offset: 0x0002E574
		public static string GenericBrowTextureFileName(int skintone, int eyebrow, int facialhaircolor)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/brow_",
				skintone.ToString(),
				"_",
				eyebrow.ToString(),
				"_",
				facialhaircolor.ToString(),
				".rx3"
			});
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000303CC File Offset: 0x0002E5CC
		public string GenericSideburnTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/genheadtex/brow_",
				this.m_skintonecode.ToString(),
				"_",
				this.m_sideburnscode.ToString(),
				"_",
				this.m_facialhaircolorcode.ToString(),
				".rx3"
			});
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00030430 File Offset: 0x0002E630
		public string SpecificFaceTextureTemplateName()
		{
			int num = 2;
			if (this.m_FaceTextureBitmaps != null)
			{
				num = this.m_FaceTextureBitmaps.Length;
			}
			switch (num)
			{
			case 3:
				File.Copy(FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face3_#_0_0_0_0_0_0_0_0_textures.rx3", FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face_#_0_0_0_0_0_0_0_0_textures.rx3", true);
				goto IL_0099;
			case 4:
				File.Copy(FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face4_#_0_0_0_0_0_0_0_0_textures.rx3", FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face_#_0_0_0_0_0_0_0_0_textures.rx3", true);
				goto IL_0099;
			}
			File.Copy(FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face2_#_0_0_0_0_0_0_0_0_textures.rx3", FifaEnvironment.LaunchDir + "/Templates/data/sceneassets/faces/face_#_0_0_0_0_0_0_0_0_textures.rx3", true);
			IL_0099:
			return "data/sceneassets/faces/face_#_0_0_0_0_0_0_0_0_textures.rx3";
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000304DB File Offset: 0x0002E6DB
		public string GenericHeadModelFileName()
		{
			return "data/sceneassets/heads/head_" + this.m_headtypecode.ToString() + "_1.rx3";
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000304F7 File Offset: 0x0002E6F7
		public string GenericHeadModelTemplateName()
		{
			return "data/sceneassets/heads/head_#_1.rx3";
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000304FE File Offset: 0x0002E6FE
		public string SpecificHeadModelFileName()
		{
			return Player.SpecificHeadModelFileName(base.Id);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0003050B File Offset: 0x0002E70B
		public static string SpecificHeadModelFileName(int id)
		{
			return "data/sceneassets/heads/head_" + id.ToString() + "_0.rx3";
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00030523 File Offset: 0x0002E723
		public string GenericHairModelFileName()
		{
			return this.GenericHairModelFileName(this.m_hairtypecode);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00030531 File Offset: 0x0002E731
		public string GenericHairModelFileName(int hairtypecode)
		{
			return "data/sceneassets/hair/hair_" + hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00030549 File Offset: 0x0002E749
		public static string GenericHairLodModelFileName(int hairtypecode)
		{
			return "data/sceneassets/hairlod/hairlod_" + hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00030561 File Offset: 0x0002E761
		public string GenericHairLodModelFileName()
		{
			return Player.GenericHairLodModelFileName(this.m_hairtypecode);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0003056E File Offset: 0x0002E76E
		public static string SpecificHairLodModelFileName(int id)
		{
			return "data/sceneassets/hairlod/hairlod_" + id.ToString() + "_0_0.rx3";
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00030586 File Offset: 0x0002E786
		public string SpecificHairLodModelFileName()
		{
			return Player.SpecificHairLodModelFileName(base.Id);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00030593 File Offset: 0x0002E793
		public string GenericHairModelTemplateName()
		{
			return "data/sceneassets/hair/hair_#_1_0.rx3";
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0003059A File Offset: 0x0002E79A
		public string SpecificHairModelFileName()
		{
			return Player.SpecificHairModelFileName(base.Id);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000305A7 File Offset: 0x0002E7A7
		public static string SpecificHairModelFileName(int id)
		{
			return "data/sceneassets/hair/hair_" + id.ToString() + "_0_0.rx3";
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000305BF File Offset: 0x0002E7BF
		public string HeadModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHeadModelFileName();
			}
			return this.GenericHeadModelFileName();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000305D6 File Offset: 0x0002E7D6
		public string HairModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHairModelFileName();
			}
			return this.GenericHairModelFileName();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x000305ED File Offset: 0x0002E7ED
		public string HairLodModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHairLodModelFileName();
			}
			return this.GenericHairLodModelFileName();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00030604 File Offset: 0x0002E804
		public string FaceTextureFileName()
		{
			if (this.HasSpecificHeadModel)
			{
				return this.SpecificFaceTextureFileName();
			}
			return this.GenericFaceTextureFileName();
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0003061B File Offset: 0x0002E81B
		public string SpecificEyesTextureFileName()
		{
			if (FifaEnvironment.Year == 14)
			{
				return Player.SpecificEyesTextureFileName(base.Id);
			}
			return null;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00030633 File Offset: 0x0002E833
		public static string SpecificEyesTextureFileName(int id)
		{
			return "data/sceneassets/heads/eyes_" + id.ToString() + "_0_textures.rx3";
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0003064B File Offset: 0x0002E84B
		public string SpecificEyesTextureTemplateName()
		{
			return "data/sceneassets/heads/eyes_#_0_textures.rx3";
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00030652 File Offset: 0x0002E852
		public string GenericEyesTextureFileName()
		{
			return "data/sceneassets/heads/eyes_" + this.m_eyecolorcode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0003066E File Offset: 0x0002E86E
		public string SkinTextureTemplateName()
		{
			return "data/sceneassets/body/skin_#_0_textures.rx3";
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00030675 File Offset: 0x0002E875
		public string RevModSkinTextureTemplateName()
		{
			return "data/sceneassets/body/playerskin_#_textures.rx3";
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0003067C File Offset: 0x0002E87C
		public string SkinTextureFileName()
		{
			return string.Concat(new object[]
			{
				"data/sceneassets/body/skin_",
				this.m_skintonecode.ToString(),
				"_",
				this.Female ? 1 : 0,
				"_textures.rx3"
			});
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000306D0 File Offset: 0x0002E8D0
		public string TattoTextureFileName()
		{
			return "data/sceneassets/tattoo/tattoo_" + base.Id.ToString() + "_0.rx3";
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000306FC File Offset: 0x0002E8FC
		public string RevModSkinTextureFileName()
		{
			return "data/sceneassets/body/playerskin_" + base.Id.ToString() + "_textures.rx3";
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00030726 File Offset: 0x0002E926
		public string SpecificPhotoTemplateFileName()
		{
			return "data/ui/imgassets/heads/p#.dds";
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00030730 File Offset: 0x0002E930
		public string SpecificPhotoDdsFileName()
		{
			return "data/ui/imgassets/heads/p" + base.Id.ToString() + ".dds";
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003075A File Offset: 0x0002E95A
		public static string SpecificPhotoDdsFileName(int id)
		{
			return "data/ui/imgassets/heads/p" + id.ToString() + ".dds";
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00030774 File Offset: 0x0002E974
		public bool IsPlayingFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				return false;
			}
			IEnumerator enumerator = this.m_PlayingForTeams.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if ((Team)enumerator.Current == team)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000307DC File Offset: 0x0002E9DC
		public void PlayFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				this.m_PlayingForTeams = new TeamList();
			}
			IEnumerator enumerator = this.m_PlayingForTeams.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if ((Team)enumerator.Current == team)
					{
						return;
					}
				}
			}
			this.m_PlayingForTeams.Add(team);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00030854 File Offset: 0x0002EA54
		public void NotPlayFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				return;
			}
			IEnumerator enumerator = this.m_PlayingForTeams.GetEnumerator(); using (enumerator as IDisposable)
			{
				while (enumerator.MoveNext())
				{
					if ((Team)enumerator.Current == team)
					{
						this.m_PlayingForTeams.Remove(team);
						return;
					}
				}
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000308C0 File Offset: 0x0002EAC0
		public bool IsFreeAgent()
		{
			int num = 0;
			if (this.m_PlayingForTeams != null)
			{
				IEnumerator enumerator = this.m_PlayingForTeams.GetEnumerator(); using (enumerator as IDisposable)
				{
					while (enumerator.MoveNext())
					{
						if (((Team)enumerator.Current).IsClub())
						{
							num++;
						}
					}
				}
			}
			return num == 0;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003092C File Offset: 0x0002EB2C
		public bool IsMultiClub()
		{
			int num = 0;
			if (this.m_PlayingForTeams != null)
			{
				IEnumerator enumerator = this.m_PlayingForTeams.GetEnumerator(); using (enumerator as IDisposable)
				{
					while (enumerator.MoveNext())
					{
						if (((Team)enumerator.Current).IsClub())
						{
							num++;
						}
					}
				}
			}
			return num > 1;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00030998 File Offset: 0x0002EB98
		public Team GetClub()
		{
			if (this.m_PlayingForTeams != null)
			{
				foreach (object obj in this.m_PlayingForTeams)
				{
					Team team = (Team)obj;
					if (team.IsClub())
					{
						return team;
					}
				}
			}
			return null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00030A04 File Offset: 0x0002EC04
		public Bitmap GetPhoto()
		{
			Bitmap bitmap = FifaEnvironment.Get2dHead(this.SpecificPhotoDdsFileName());
			this.m_HasSpecificPhoto = bitmap != null;
			return bitmap;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00030A28 File Offset: 0x0002EC28
		public int EstimateSkills(float marketValue, int age, ERole role)
		{
			float[] array;
			switch (role)
			{
			case ERole.Goalkeeper:
				array = Player.c_MarketValuesGoalkeeper;
				goto IL_009E;
			case ERole.Right_Wing_Back:
			case ERole.Right_Back:
			case ERole.Central_Back:
			case ERole.Left_Back:
			case ERole.Left_Wing_Back:
				array = Player.c_MarketValuesDefender;
				goto IL_009E;
			case ERole.Central_Defensive_Midfielder:
			case ERole.Right_Midfielder:
			case ERole.Central_Midfielder:
			case ERole.Left_Midfielder:
				array = Player.c_MarketValuesDefender;
				goto IL_009E;
			case ERole.Central_Advanced_Midfielder:
			case ERole.Central_Forward:
			case ERole.Right_Wing:
			case ERole.Central_Striker:
			case ERole.Left_Wing:
				array = Player.c_MarketValuesDefender;
				goto IL_009E;
			}
			array = Player.c_MarketValuesGoalkeeper;
			IL_009E:
			int num = 50;
			int num2 = 0;
			while (num2 < array.Length && marketValue >= array[num2])
			{
				num++;
				num2++;
			}
			if (age < 21)
			{
				num -= 4;
			}
			else if (age >= 21 && age <= 24)
			{
				num -= 2;
			}
			else if (age >= 31 && age <= 35)
			{
				num += 2;
			}
			return num;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00030B18 File Offset: 0x0002ED18
		public int EstimateBody()
		{
			int num = this.height - 100 - this.weight;
			if (this.height <= 173)
			{
				if (num > 4)
				{
					this.m_bodytypecode = 7;
				}
				else if (num > 2)
				{
					this.m_bodytypecode = 8;
				}
				else
				{
					this.m_bodytypecode = 9;
				}
			}
			else if (this.height <= 184)
			{
				if (num > 8)
				{
					this.m_bodytypecode = 1;
				}
				else if (num > 4)
				{
					this.m_bodytypecode = 2;
				}
				else
				{
					this.m_bodytypecode = 3;
				}
			}
			else if (num > 9)
			{
				this.m_bodytypecode = 4;
			}
			else if (num > 5)
			{
				this.m_bodytypecode = 5;
			}
			else
			{
				this.m_bodytypecode = 6;
			}
			return this.m_bodytypecode;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00030BBF File Offset: 0x0002EDBF
		public bool SetPhoto(Bitmap bitmap)
		{
			return FifaEnvironment.Set2dHead(this.SpecificPhotoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00030BD3 File Offset: 0x0002EDD3
		public bool DeletePhoto()
		{
			return FifaEnvironment.Delete2dHead(this.SpecificPhotoDdsFileName());
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		private void ChangeHairColor(Bitmap bitmap, int color)
		{
			int num = 128;
			int num2 = 128;
			int num3 = 128;
			switch (color)
			{
			case 1:
				num = 64;
				num2 = 64;
				num3 = 64;
				break;
			case 2:
				num = 92;
				num2 = 92;
				num3 = 92;
				break;
			case 3:
				return;
			case 4:
				num = 160;
				num2 = 180;
				num3 = 128;
				break;
			case 5:
				num = 170;
				num2 = 128;
				num3 = 128;
				break;
			case 6:
				num = 192;
				num2 = 256;
				num3 = 256;
				break;
			case 7:
				num = 128;
				num2 = 150;
				num3 = 150;
				break;
			}
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 128; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					if (pixel.R != 128 || pixel.G != 128 || pixel.B != 128)
					{
						int num4 = (int)pixel.R * num / 128;
						int num5 = (int)pixel.G * num2 / 128;
						int num6 = (int)pixel.B * num3 / 128;
						if (num4 > 255)
						{
							num4 = 255;
						}
						if (num5 > 255)
						{
							num5 = 255;
						}
						if (num6 > 255)
						{
							num6 = 255;
						}
						if (color == 6)
						{
							num5 = (num4 = num6);
						}
						bitmap.SetPixel(i, j, Color.FromArgb(255, num4, num5, num6));
					}
				}
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00030D7C File Offset: 0x0002EF7C
		private void OverlapBitmaps(Bitmap lowerBitmap, Bitmap upperBitmap)
		{
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 128; j++)
				{
					Color pixel = upperBitmap.GetPixel(i, j);
					if (pixel.R != 128 || pixel.G != 128 || pixel.B != 128)
					{
						lowerBitmap.SetPixel(i, j, pixel);
					}
				}
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00030DE8 File Offset: 0x0002EFE8
		public void ChangeId()
		{
			this.m_assetid = base.Id;
			this.headclasscode = (FifaEnvironment.IsFilePresent(this.SpecificHeadModelFileName()) ? 0 : 1);
			this.m_FaceTextureBitmaps = null;
			this.m_HairColorTextureBitmap = null;
			this.m_HairAlfaTextureBitmap = null;
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00030E34 File Offset: 0x0002F034
		public void CleanFaceTextures()
		{
			if (this.m_FaceTextureBitmaps != null)
			{
				for (int i = 0; i < this.m_FaceTextureBitmaps.Length; i++)
				{
					if (this.m_FaceTextureBitmaps[i] != null)
					{
						this.m_FaceTextureBitmaps[i].Dispose();
					}
				}
			}
			this.m_FaceTextureBitmaps = null;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00030E7A File Offset: 0x0002F07A
		public Bitmap GetFaceTexture()
		{
			if (this.m_FaceTextureBitmaps != null)
			{
				return this.m_FaceTextureBitmaps[0];
			}
			this.GetFaceTextures();
			if (this.m_FaceTextureBitmaps != null)
			{
				return this.m_FaceTextureBitmaps[0];
			}
			return null;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00030EA6 File Offset: 0x0002F0A6
		public static int GetFaceTexturesNumber()
		{
			if (FifaEnvironment.Year == 14)
			{
				return 1;
			}
			if (FifaEnvironment.Year == 15)
			{
				return 2;
			}
			if (FifaEnvironment.Year == 16)
			{
				return 4;
			}
			return 0;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00030ECA File Offset: 0x0002F0CA
		public int GetFaceTexturesNumber16()
		{
			if (this.m_FaceTextureBitmaps != null)
			{
				return this.m_FaceTextureBitmaps.Length;
			}
			return 0;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00030EE0 File Offset: 0x0002F0E0
		public Bitmap[] GetFaceTextures()
		{
			if (this.m_FaceTextureBitmaps != null)
			{
				return this.m_FaceTextureBitmaps;
			}
			if (this.HasSpecificHeadModel)
			{
				string text = this.SpecificFaceTextureFileName();
				this.m_FaceTextureBitmaps = FifaEnvironment.GetBmpsFromRx3(text, this.HasSpecificHeadModel);
			}
			else
			{
				this.m_FaceTextureBitmaps = new Bitmap[2];
				this.m_FaceTextureBitmaps[0] = this.BuildGenericFaceTexture();
				this.m_FaceTextureBitmaps[1] = null;
			}
			return this.m_FaceTextureBitmaps;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00030F4C File Offset: 0x0002F14C
		private Bitmap BuildGenericFaceTexture()
		{
			Bitmap bitmap = FifaEnvironment.GetBmpFromRx3(this.GenericSkinTextureFileName());
			if (bitmap == null)
			{
				return null;
			}
			Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
			Bitmap bitmap2 = FifaEnvironment.GetBmpFromRx3(this.GenericBearTextureFileName());
			if (bitmap2 == null)
			{
				return null;
			}
			bitmap = GraphicUtil.Overlap(bitmap, bitmap2, rectangle);
			bitmap2 = FifaEnvironment.GetBmpFromRx3(this.GenericBrowTextureFileName());
			if (bitmap2 == null)
			{
				return null;
			}
			return GraphicUtil.Overlap(bitmap, bitmap2, rectangle);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		public bool SetFaceTextures(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.SpecificFaceTextureTemplateName(), base.Id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00030FC9 File Offset: 0x0002F1C9
		public bool SetFaceTextures(string rx3FileName)
		{
			this.CleanFaceTextures();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificFaceTextureFileName(), false, ECompressionMode.Chunkzip, null);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00030FE0 File Offset: 0x0002F1E0
		public bool DeleteFaceTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificFaceTextureFileName());
			if (flag)
			{
				this.m_FaceTextureBitmaps = null;
			}
			return flag;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00031011 File Offset: 0x0002F211
		public bool SetSkinTextures(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.RevModSkinTextureTemplateName(), base.Id, bitmap, ECompressionMode.Chunkzip, this.SkinSignature());
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0003102C File Offset: 0x0002F22C
		public Bitmap GetSkinTexture()
		{
			Bitmap bitmap = FifaEnvironment.GetBmpFromRx3(this.RevModSkinTextureFileName(), 0);
			if (bitmap == null)
			{
				bitmap = FifaEnvironment.GetBmpFromRx3(this.SkinTextureFileName(), 0);
			}
			return bitmap;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0003105A File Offset: 0x0002F25A
		public bool DeleteSkinTexture()
		{
			return FifaEnvironment.DeleteFromZdata(this.RevModSkinTextureFileName());
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00031068 File Offset: 0x0002F268
		private Rx3Signatures SkinSignature()
		{
			return new Rx3Signatures(175072, 24, new string[] { "body_" + this.m_skintonecode.ToString() + "_cm.Raster" });
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000310A6 File Offset: 0x0002F2A6
		public bool SetTattoos(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.TattoTextureFileName(), base.Id, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000310BB File Offset: 0x0002F2BB
		public Bitmap GetTattoos()
		{
			return FifaEnvironment.GetBmpFromRx3(this.TattoTextureFileName(), 0);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000310C9 File Offset: 0x0002F2C9
		public bool DeleteTattoos()
		{
			return FifaEnvironment.DeleteFromZdata(this.TattoTextureFileName());
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000310D6 File Offset: 0x0002F2D6
		public bool SetRevModSkinTextures(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data\\sceneassets\\body\\playerskin_#_textures.rx3", base.Id, bitmap, ECompressionMode.None, this.RevModSkinSignature());
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000310F0 File Offset: 0x0002F2F0
		public Bitmap GetRevModSkinTexture()
		{
			return FifaEnvironment.GetBmpFromRx3(this.RevModSkinTextureFileName(), false);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0003105A File Offset: 0x0002F25A
		public bool DeleteRevModSkinTexture()
		{
			return FifaEnvironment.DeleteFromZdata(this.RevModSkinTextureFileName());
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00031100 File Offset: 0x0002F300
		private Rx3Signatures RevModSkinSignature()
		{
			return new Rx3Signatures(175072, 24, new string[] { "body_" + this.m_skintonecode.ToString() + "_cm.Raster" });
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00031140 File Offset: 0x0002F340
		public Bitmap GetEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				return this.m_EyesTextureBitmap;
			}
			string text;
			if (this.HasSpecificHeadModel)
			{
				if (FifaEnvironment.Year == 14)
				{
					text = this.SpecificEyesTextureFileName();
				}
				else
				{
					text = this.GenericEyesTextureFileName();
				}
			}
			else
			{
				text = this.GenericEyesTextureFileName();
			}
			this.m_EyesTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_EyesTextureBitmap;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0003119C File Offset: 0x0002F39C
		private Rx3Signatures EyesSignature()
		{
			return new Rx3Signatures(11200, 24, new string[] { "eyes_" + base.Id.ToString() + "_0_cm.Raster" });
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000311E0 File Offset: 0x0002F3E0
		public bool SetEyesTextures(Bitmap bitmap)
		{
			if (FifaEnvironment.Year != 14)
			{
				return false;
			}
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanEyesTexture();
			return FifaEnvironment.ImportBmpsIntoZdata(this.SpecificEyesTextureTemplateName(), base.Id, bitmap, ECompressionMode.Chunkzip, this.EyesSignature());
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00031234 File Offset: 0x0002F434
		public bool SetEyesTextures(string rx3FileName)
		{
			if (FifaEnvironment.Year != 14)
			{
				return false;
			}
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanEyesTexture();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificEyesTextureFileName(), false, ECompressionMode.Chunkzip, this.EyesSignature());
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00031280 File Offset: 0x0002F480
		public void CleanEyesTexture()
		{
			Bitmap eyesTextureBitmap = this.m_EyesTextureBitmap;
			this.m_EyesTextureBitmap = null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00031290 File Offset: 0x0002F490
		public bool DeleteEyesTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificEyesTextureFileName());
			if (flag)
			{
				this.m_EyesTextureBitmap = null;
			}
			return flag;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000312C1 File Offset: 0x0002F4C1
		public string HairTexturesFileName()
		{
			if (this.m_headclasscode == 0)
			{
				return this.SpecificHairTexturesFileName();
			}
			return this.GenericHairTexturesFileName();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000312D8 File Offset: 0x0002F4D8
		public string SpecificHairTexturesFileName()
		{
			return Player.SpecificHairTexturesFileName(base.Id);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000312E5 File Offset: 0x0002F4E5
		public static string SpecificHairTexturesFileName(int id)
		{
			return "data/sceneassets/hair/hair_" + id.ToString() + "_0_textures.rx3";
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000312FD File Offset: 0x0002F4FD
		public string GenericHairTexturesFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00031319 File Offset: 0x0002F519
		public string HairTexturesTemplateName()
		{
			return "data/sceneassets/hair/hair_#_0_textures.rx3";
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00031320 File Offset: 0x0002F520
		public void CleanHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				this.m_HairAlfaTextureBitmap.Dispose();
			}
			this.m_HairAlfaTextureBitmap = null;
			if (this.m_HairColorTextureBitmap != null)
			{
				this.m_HairColorTextureBitmap.Dispose();
			}
			this.m_HairColorTextureBitmap = null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00031358 File Offset: 0x0002F558
		public Bitmap GetGenericHairColorTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				return this.m_HairColorTextureBitmap;
			}
			Bitmap[] bmpsFromRx = FifaEnvironment.GetBmpsFromRx3(this.GenericHairTexturesFileName());
			if (bmpsFromRx != null)
			{
				return GraphicUtil.MultiplyColorToBitmap(bmpsFromRx[1], Player.s_GenericColors[this.m_haircolorcode], Player.s_GenericColorsDivisor, false);
			}
			return null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000313A4 File Offset: 0x0002F5A4
		public Bitmap[] GetHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null)
			{
				return new Bitmap[] { this.m_HairAlfaTextureBitmap, this.m_HairColorTextureBitmap };
			}
			Bitmap[] array;
			if (this.HasSpecificHeadModel)
			{
				array = FifaEnvironment.GetBmpsFromRx3(this.SpecificHairTexturesFileName(), false);
				if (array != null)
				{
					this.m_HairAlfaTextureBitmap = array[0];
					this.m_HairColorTextureBitmap = array[1];
				}
				else
				{
					this.m_HairAlfaTextureBitmap = null;
					this.m_HairColorTextureBitmap = null;
				}
			}
			else
			{
				array = FifaEnvironment.GetBmpsFromRx3(this.GenericHairTexturesFileName());
				if (array != null)
				{
					this.m_HairAlfaTextureBitmap = array[0];
					this.m_HairColorTextureBitmap = GraphicUtil.MultiplyColorToBitmap(array[1], Player.s_GenericColors[this.m_haircolorcode], Player.s_GenericColorsDivisor, false);
				}
				else
				{
					this.m_HairColorTextureBitmap = null;
				}
			}
			return array;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00031461 File Offset: 0x0002F661
		public bool SetHairTextures(Bitmap[] bitmaps)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			return FifaEnvironment.ImportBmpsIntoZdata(this.HairTexturesTemplateName(), base.Id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00031490 File Offset: 0x0002F690
		public bool SetHairTextures(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairTexturesFileName(), false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000314A0 File Offset: 0x0002F6A0
		public bool DeleteHairTextures()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificHairTexturesFileName());
			if (flag)
			{
				this.m_HairColorTextureBitmap = null;
				this.m_HairAlfaTextureBitmap = null;
			}
			return flag;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000314D8 File Offset: 0x0002F6D8
		public Bitmap GetHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				return this.m_HairColorTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairColorTextureBitmap;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000314F6 File Offset: 0x0002F6F6
		public Bitmap GetHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				return this.m_HairAlfaTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairAlfaTextureBitmap;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00031514 File Offset: 0x0002F714
		public Rx3File GetHeadModel()
		{
			if (this.m_HeadModelFile != null)
			{
				return this.m_HeadModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			if (this.m_headclasscode == 0)
			{
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHeadModelFileName());
			}
			else
			{
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHeadModelFileName());
			}
			return this.m_HeadModelFile;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00031568 File Offset: 0x0002F768
		public bool SetHeadModel(string rx3FileName)
		{
			rx3FileName = this.ConvertHeadModel(rx3FileName);
			if (rx3FileName == null)
			{
				return false;
			}
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHeadModelFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.CleanHeadModel();
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHeadModelFileName());
			}
			return flag;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000315A0 File Offset: 0x0002F7A0
		private string ConvertHeadModel(string rx3FileName)
		{
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			Rx3File rx3File = new Rx3File();
			rx3File.Load(rx3FileName);
			int num = 0;
			string text = FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\heads\\head_16_0.rx3";
			for (int i = 0; i < rx3File.Rx3Headers.NFiles; i++)
			{
				if (rx3File.Rx3FileDescriptors[i].IsVertexVector())
				{
					if (rx3File.Rx3FileDescriptors[i].Size == 6352)
					{
						num |= 1;
					}
					if (rx3File.Rx3FileDescriptors[i].Size == 6880)
					{
						num |= 2;
					}
					if (rx3File.Rx3FileDescriptors[i].Size == 151552)
					{
						num |= 4;
					}
					if (rx3File.Rx3FileDescriptors[i].Size == 101040)
					{
						num |= 8;
					}
				}
			}
			switch (num)
			{
			case 5:
			{
				DialogResult dialogResult = FifaEnvironment.UserMessages.ShowMessage(32);
				if (dialogResult != DialogResult.Yes && dialogResult != DialogResult.OK)
				{
					return null;
				}
				if (this.ImportHeadModelFromOtherFifa(rx3File))
				{
					return text;
				}
				return null;
			}
			case 6:
				return rx3FileName;
			}
			FifaEnvironment.UserMessages.ShowMessage(1037);
			return null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000316CC File Offset: 0x0002F8CC
		private bool ImportHeadModelFromOtherFifa(Rx3File rx3File)
		{
			string text = FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\heads\\head_16_1.rx3";
			string text2 = FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\heads\\head_16_0.rx3";
			File.Copy(text, text2, true);
			Rx3File rx3File2 = new Rx3File();
			rx3File2.Load(text2);
			Rx3RawData rx3RawData = new Rx3RawData(rx3File.FileName);
			new Rx3RawData(text2);
			int nfiles = rx3RawData.Rx3Headers.NFiles;
			for (int i = 0; i < rx3File2.Rx3VertexArrays.Length; i++)
			{
				for (int j = 0; j < rx3File.Rx3VertexArrays.Length; j++)
				{
					if (rx3File2.Rx3VertexArrays[i].nVertex == 3157 && rx3File.Rx3VertexArrays[j].nVertex == 3157)
					{
						for (int k = 0; k < rx3File2.Rx3VertexArrays[i].nVertex; k++)
						{
							float num = float.MaxValue;
							int num2 = -1;
							for (int l = 0; l < rx3File2.Rx3VertexArrays[i].nVertex; l++)
							{
								float num3 = (rx3File2.Rx3VertexArrays[i].Vertexes[k].U - rx3File.Rx3VertexArrays[j].Vertexes[l].U) * (rx3File2.Rx3VertexArrays[i].Vertexes[k].U - rx3File.Rx3VertexArrays[j].Vertexes[l].U) + (rx3File2.Rx3VertexArrays[i].Vertexes[k].V - rx3File.Rx3VertexArrays[j].Vertexes[l].V) * (rx3File2.Rx3VertexArrays[i].Vertexes[k].V - rx3File.Rx3VertexArrays[j].Vertexes[l].V);
								if (num3 < num)
								{
									num = num3;
									num2 = l;
								}
							}
							if (num2 != -1)
							{
								rx3File2.Rx3VertexArrays[i].Vertexes[k].X = rx3File.Rx3VertexArrays[j].Vertexes[num2].X;
								rx3File2.Rx3VertexArrays[i].Vertexes[k].Y = rx3File.Rx3VertexArrays[j].Vertexes[num2].Y;
								rx3File2.Rx3VertexArrays[i].Vertexes[k].Z = rx3File.Rx3VertexArrays[j].Vertexes[num2].Z;
							}
						}
					}
					if (rx3File2.Rx3VertexArrays[i].nVertex == 132 && rx3File.Rx3VertexArrays[j].nVertex == 132)
					{
						int num4 = 0;
						int num5 = 0;
						float num6 = 0f;
						float num7 = 0f;
						float num8 = 0f;
						float num9 = 0f;
						float num10 = 0f;
						float num11 = 0f;
						for (int m = 0; m < 132; m++)
						{
							if (rx3File2.Rx3VertexArrays[i].Vertexes[m].X > 0f)
							{
								num6 += rx3File2.Rx3VertexArrays[i].Vertexes[m].X;
								num7 += rx3File2.Rx3VertexArrays[i].Vertexes[m].Y;
								num8 += rx3File2.Rx3VertexArrays[i].Vertexes[m].Z;
								num4++;
							}
							else
							{
								num9 += rx3File2.Rx3VertexArrays[i].Vertexes[m].X;
								num10 += rx3File2.Rx3VertexArrays[i].Vertexes[m].Y;
								num11 += rx3File2.Rx3VertexArrays[i].Vertexes[m].Z;
								num5++;
							}
						}
						num6 /= (float)num4;
						num7 /= (float)num4;
						num8 /= (float)num4;
						num9 /= (float)num5;
						num10 /= (float)num5;
						num11 /= (float)num5;
						int num12 = 0;
						int num13 = 0;
						float num14 = 0f;
						float num15 = 0f;
						float num16 = 0f;
						float num17 = 0f;
						float num18 = 0f;
						float num19 = 0f;
						for (int n = 0; n < 132; n++)
						{
							if (rx3File.Rx3VertexArrays[j].Vertexes[n].X > 0f)
							{
								num14 += rx3File.Rx3VertexArrays[j].Vertexes[n].X;
								num15 += rx3File.Rx3VertexArrays[j].Vertexes[n].Y;
								num16 += rx3File.Rx3VertexArrays[j].Vertexes[n].Z;
								num12++;
							}
							else
							{
								num17 += rx3File.Rx3VertexArrays[j].Vertexes[n].X;
								num18 += rx3File.Rx3VertexArrays[j].Vertexes[n].Y;
								num19 += rx3File.Rx3VertexArrays[j].Vertexes[n].Z;
								num13++;
							}
						}
						num14 /= (float)num12;
						num15 /= (float)num12;
						num16 /= (float)num12;
						num17 /= (float)num13;
						num18 /= (float)num13;
						num19 /= (float)num13;
						float num20 = num14 - num6;
						float num21 = num15 - num7;
						float num22 = num16 - num8;
						float num23 = num17 - num9;
						float num24 = num18 - num10;
						float num25 = num19 - num11;
						for (int num26 = 0; num26 < 132; num26++)
						{
							if (rx3File2.Rx3VertexArrays[i].Vertexes[num26].X > 0f)
							{
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].X += num20;
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].Y += num21;
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].Z += num22;
							}
							else
							{
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].X += num23;
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].Y += num24;
								rx3File2.Rx3VertexArrays[i].Vertexes[num26].Z += num25;
							}
						}
					}
				}
			}
			rx3File2.Save(text2, false, true);
			return true;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00031CE9 File Offset: 0x0002FEE9
		public bool DeleteHeadModel()
		{
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificHeadModelFileName());
			if (flag)
			{
				this.m_HeadModelFile = null;
			}
			return flag;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00031D00 File Offset: 0x0002FF00
		public void CleanHeadModel()
		{
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00031D09 File Offset: 0x0002FF09
		public void CleanHead()
		{
			this.CleanFaceTextures();
			this.CleanEyesTexture();
			this.CleanHeadModel();
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00031D20 File Offset: 0x0002FF20
		public Rx3File GetHairModel()
		{
			if (this.m_HairModelFile != null)
			{
				return this.m_HairModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			if (this.m_headclasscode == 0)
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHairModelFileName(), false);
			}
			else
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHairModelFileName());
			}
			return this.m_HairModelFile;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00031D75 File Offset: 0x0002FF75
		public bool SetHairLodModel(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairLodModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00031D9F File Offset: 0x0002FF9F
		public bool SetHairModel(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairModelFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHairModelFileName());
			}
			return flag;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00031DE0 File Offset: 0x0002FFE0
		public bool UpdateHairVertex(CustomVertex.PositionNormalTextured[] newVertex4, CustomVertex.PositionNormalTextured[] newVertex5)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			FifaEnvironment.FifaFat.ExtractFile(this.SpecificHairModelFileName());
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			this.m_HairModelFile = new Rx3File();
			this.m_HairModelFile.Load(FifaEnvironment.GameDir + this.SpecificHairModelFileName());
			if (this.m_HairModelFile.Rx3VertexArrays == null)
			{
				return false;
			}
			if (newVertex4 != null && this.m_HairModelFile.Rx3VertexArrays.Length >= 1 && this.m_HairModelFile.Rx3VertexArrays[0] != null)
			{
				this.m_HairModelFile.Rx3VertexArrays[0].SetVertex(newVertex4);
			}
			if (newVertex5 != null && this.m_HairModelFile.Rx3VertexArrays.Length >= 2 && this.m_HairModelFile.Rx3VertexArrays[1] != null)
			{
				this.m_HairModelFile.Rx3VertexArrays[1].SetVertex(newVertex5);
			}
			this.m_HairModelFile.Save(FifaEnvironment.GameDir + this.SpecificHairModelFileName(), false, true);
			return true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00031EE0 File Offset: 0x000300E0
		public bool UpdateHeadVertex(CustomVertex.PositionNormalTextured[] newVertexHead, CustomVertex.PositionNormalTextured[] newVertexEyes)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			FifaEnvironment.FifaFat.ExtractFile(this.SpecificHeadModelFileName());
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			this.m_HeadModelFile = new Rx3File();
			this.m_HeadModelFile.Load(FifaEnvironment.GameDir + this.SpecificHeadModelFileName());
			if (this.m_HeadModelFile.Rx3VertexArrays == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_HeadModelFile.Rx3VertexArrays.Length; i++)
			{
				if (this.m_HeadModelFile.Rx3VertexArrays[i].nVertex == newVertexHead.Length)
				{
					this.m_HeadModelFile.Rx3VertexArrays[i].SetVertex(newVertexHead);
				}
				else if (this.m_HeadModelFile.Rx3VertexArrays[i].nVertex == newVertexEyes.Length)
				{
					this.m_HeadModelFile.Rx3VertexArrays[i].SetVertex(newVertexEyes);
				}
			}
			this.m_HeadModelFile.Save(FifaEnvironment.GameDir + this.SpecificHeadModelFileName(), false, true);
			return true;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00031FE3 File Offset: 0x000301E3
		public bool DeleteHairModel()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificHairModelFileName());
			if (flag)
			{
				this.m_HairModelFile = null;
			}
			return flag;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00032014 File Offset: 0x00030214
		public bool DeleteHairLodModel()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			return FifaEnvironment.DeleteFromZdata(this.SpecificHairLodModelFileName());
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0003203B File Offset: 0x0003023B
		public void CleanHairModel()
		{
			this.m_HairModelFile = null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00032044 File Offset: 0x00030244
		public void CleanHair()
		{
			this.CleanHairModel();
			this.CleanHairTextures();
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00032052 File Offset: 0x00030252
		public void CleanAllHead()
		{
			this.CleanHair();
			this.CleanHead();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00032060 File Offset: 0x00030260
		public bool SetHairTextures(Bitmap colorBitmap, Bitmap alfaBitmap)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			return this.SetHairTextures(new Bitmap[] { alfaBitmap, colorBitmap });
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000320A0 File Offset: 0x000302A0
		public void SavePlayer(Record r)
		{
			string text = null;
			Player.s_PlayerNames.TryGetValue(this.m_firstnameid, out text, true);
			if (text != this.m_firstname)
			{
				this.m_firstnameid = Player.s_PlayerNames.GetKey(this.m_firstname);
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_lastnameid, out text, true);
			if (text != this.m_lastname)
			{
				this.m_lastnameid = Player.s_PlayerNames.GetKey(this.m_lastname, this.m_commentaryid);
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_commonnameid, out text, true);
			if (text != this.m_commonname)
			{
				this.m_commonnameid = Player.s_PlayerNames.GetKey(this.m_commonname);
			}
			if (this.m_commentaryid > 900000)
			{
				if (this.m_audioname == this.m_commonname)
				{
					Player.s_PlayerNames.SetCommentaryId(this.m_commonnameid, this.m_commentaryid);
				}
				else if (this.m_audioname == this.m_lastname)
				{
					Player.s_PlayerNames.SetCommentaryId(this.m_lastnameid, this.m_commentaryid);
				}
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_playerjerseynameid, out text, true);
			if (text != this.m_playerjerseyname)
			{
				this.m_playerjerseynameid = Player.s_PlayerNames.GetKey(this.m_playerjerseyname);
			}
			r.IntField[FI.players_playerid] = base.Id;
			r.IntField[FI.players_firstnameid] = this.m_firstnameid;
			r.IntField[FI.players_lastnameid] = this.m_lastnameid;
			r.IntField[FI.players_commonnameid] = this.m_commonnameid;
			r.IntField[FI.players_playerjerseynameid] = this.m_playerjerseynameid;
			r.IntField[FI.players_birthdate] = FifaUtil.ConvertFromDate(this.m_birthdate);
			r.IntField[FI.players_playerjointeamdate] = FifaUtil.ConvertFromDate(this.m_playerjointeamdate);
			r.IntField[FI.players_contractvaliduntil] = this.m_contractvaliduntil;
			r.IntField[FI.players_height] = this.m_height;
			r.IntField[FI.players_weight] = this.m_weight;
			r.IntField[FI.players_preferredposition1] = this.m_preferredposition1;
			r.IntField[FI.players_preferredposition2] = this.m_preferredposition2;
			r.IntField[FI.players_preferredposition3] = this.m_preferredposition3;
			r.IntField[FI.players_preferredposition4] = this.m_preferredposition4;
			r.IntField[FI.players_preferredfoot] = this.m_preferredfoot + 1;
			r.IntField[FI.players_jerseysleevelengthcode] = this.m_jerseysleevelengthcode;
			r.IntField[FI.players_jerseystylecode] = this.m_jerseystylecode;
			r.IntField[FI.players_hasseasonaljersey] = this.m_hasseasonaljersey;
			r.IntField[FI.players_animfreekickstartposcode] = this.m_animfreekickstartposcode;
			r.IntField[FI.players_animpenaltieskickstylecode] = this.m_animpenaltieskickstylecode;
			r.IntField[FI.players_animpenaltiesmotionstylecode] = this.m_animpenaltiesmotionstylecode;
			r.IntField[FI.players_animpenaltiesstartposcode] = this.m_animpenaltiesstartposcode;
			r.IntField[FI.players_accessorycode1] = this.m_accessorycode1;
			r.IntField[FI.players_accessorycolourcode1] = this.m_accessorycolourcode1;
			r.IntField[FI.players_accessorycode2] = this.m_accessorycode2;
			r.IntField[FI.players_accessorycolourcode2] = this.m_accessorycolourcode2;
			r.IntField[FI.players_accessorycode3] = this.m_accessorycode3;
			r.IntField[FI.players_accessorycolourcode3] = this.m_accessorycolourcode3;
			r.IntField[FI.players_accessorycode4] = this.m_accessorycode4;
			r.IntField[FI.players_accessorycolourcode4] = this.m_accessorycolourcode4;
			r.IntField[FI.players_acceleration] = this.m_acceleration;
			r.IntField[FI.players_aggression] = this.m_aggression;
			r.IntField[FI.players_sprintspeed] = this.m_sprintspeed;
			r.IntField[FI.players_stamina] = this.m_stamina;
			r.IntField[FI.players_strength] = this.m_strength;
			r.IntField[FI.players_marking] = this.m_marking;
			r.IntField[FI.players_standingtackle] = this.m_standingtackle;
			r.IntField[FI.players_slidingtackle] = this.m_slidingtackle;
			r.IntField[FI.players_ballcontrol] = this.m_ballcontrol;
			r.IntField[FI.players_dribbling] = this.m_dribbling;
			r.IntField[FI.players_crossing] = this.m_crossing;
			r.IntField[FI.players_headingaccuracy] = this.m_headingaccuracy;
			r.IntField[FI.players_shortpassing] = this.m_shortpassing;
			r.IntField[FI.players_longpassing] = this.m_longpassing;
			r.IntField[FI.players_longshots] = this.m_longshots;
			r.IntField[FI.players_finishing] = this.m_finishing;
			r.IntField[FI.players_shotpower] = this.m_shotpower;
			r.IntField[FI.players_reactions] = this.m_reactions;
			r.IntField[FI.players_gkreflexes] = this.m_gkreflexes;
			r.IntField[FI.players_gkglovetypecode] = this.m_gkglovetypecode;
			r.IntField[FI.players_agility] = this.m_agility;
			r.IntField[FI.players_balance] = this.m_balance;
			r.IntField[FI.players_gkkicking] = this.m_gkkicking;
			r.IntField[FI.players_gkkickstyle] = this.m_gkkickstyle;
			r.IntField[FI.players_jumping] = this.m_jumping;
			r.IntField[FI.players_penalties] = this.m_penalties;
			r.IntField[FI.players_vision] = this.m_vision;
			r.IntField[FI.players_volleys] = this.m_volleys;
			r.IntField[FI.players_skillmoves] = this.m_skillmoves - 1;
			r.IntField[FI.players_usercaneditname] = this.m_usercaneditname;
			r.IntField[FI.players_gender] = (this.m_gender ? 1 : 0);
			r.IntField[FI.players_emotion] = this.m_emotion;
			r.IntField[FI.players_gkhandling] = this.m_gkhandling;
			r.IntField[FI.players_gkdiving] = this.m_gkdiving;
			r.IntField[FI.players_gkpositioning] = this.m_gkpositioning;
			r.IntField[FI.players_positioning] = this.m_positioning;
			r.IntField[FI.players_potential] = this.m_potential;
			r.IntField[FI.players_freekickaccuracy] = this.m_freekickaccuracy;
			r.IntField[FI.players_nationality] = this.m_nationality;
			r.IntField[FI.players_finishingcode1] = this.m_finishingcode1;
			r.IntField[FI.players_finishingcode2] = this.m_finishingcode2;
			r.IntField[FI.players_runningcode1] = this.m_runningcode1;
			r.IntField[FI.players_runningcode2] = this.m_runningcode2;
			r.IntField[FI.players_gksavetype] = this.m_gksavetype;
			r.IntField[FI.players_faceposercode] = this.m_faceposercode;
			r.IntField[FI.players_isretiring] = this.m_isretiring;
			r.IntField[FI.players_socklengthcode] = this.m_socklengthcode;
			r.IntField[FI.players_hashighqualityhead] = (this.m_hashighqualityhead ? 1 : 0);
			r.IntField[FI.players_attackingworkrate] = this.m_attackingworkrate;
			r.IntField[FI.players_defensiveworkrate] = this.m_defensiveworkrate;
			r.IntField[FI.players_shortstyle] = (this.m_shortstyle ? 1 : 0);
			int num = 0;
			num |= (this.m_Inflexible ? 1 : 0);
			num |= (this.m_Longthrows ? 2 : 0);
			num |= (this.m_PowerfulFreeKicks ? 4 : 0);
			num |= (this.m_Diver ? 8 : 0);
			num |= (this.m_InjuryProne ? 16 : 0);
			num |= (this.m_InjuryFree ? 32 : 0);
			num |= (this.m_AvoidsWeakFoot ? 64 : 0);
			num |= (this.m_Divesintotackles ? 128 : 0);
			num |= (this.m_BeatDefensiveLine ? 256 : 0);
			num |= (this.m_Selfish ? 512 : 0);
			num |= (this.m_Leadership ? 1024 : 0);
			num |= (this.m_ArguesWithOfficials ? 2048 : 0);
			num |= (this.m_Earlycrosser ? 4096 : 0);
			num |= (this.m_FinesseShot ? 8192 : 0);
			num |= (this.m_Flair ? 16384 : 0);
			num |= (this.m_LongPasser ? 32768 : 0);
			num |= (this.m_LongShotTaker ? 65536 : 0);
			num |= (this.m_Technicaldribbler ? 131072 : 0);
			num |= (this.m_Playmaker ? 262144 : 0);
			num |= (this.m_Pushesupforcorners ? 524288 : 0);
			num |= (this.m_Puncher ? 1048576 : 0);
			num |= (this.m_GkLongThrower ? 2097152 : 0);
			num |= (this.m_PowerHeader ? 4194304 : 0);
			num |= (this.m_GkOneOnOne ? 8388608 : 0);
			num |= (this.m_GiantThrow ? 16777216 : 0);
			num |= (this.m_OutsideFootShot ? 33554432 : 0);
			num |= (this.m_CrowdFavorite ? 67108864 : 0);
			num |= (this.m_SwervePasser ? 134217728 : 0);
			num |= (this.m_SecondWind ? 268435456 : 0);
			num |= (this.m_AcrobaticClearance ? 536870912 : 0);
			num |= (r.IntField[FI.players_trait1] = num);
			int num2 = 0;
			num2 |= (this.m_FancyFeet ? 1 : 0);
			num2 |= (this.m_FancyPasses ? 2 : 0);
			num2 |= (this.m_FancyFlicks ? 4 : 0);
			num2 |= (this.m_StutterPenalty ? 8 : 0);
			num2 |= (this.m_ChipperPenalty ? 16 : 0);
			num2 |= (this.m_BycicleKick ? 32 : 0);
			num2 |= (this.m_DivingHeader ? 64 : 0);
			num2 |= (this.m_DrivenPass ? 128 : 0);
			num2 |= (this.m_GkFlatKick ? 256 : 0);
			num2 |= (this.m_HighClubIdentification ? 512 : 0);
			num2 |= (this.m_TeamPlayer ? 1024 : 0);
			r.IntField[FI.players_trait2] = num2;
			r.IntField[FI.players_bodytypecode] = this.m_bodytypecode + 1;
			r.IntField[FI.players_weakfootabilitytypecode] = this.m_weakfootabilitytypecode;
			r.IntField[FI.players_curve] = this.m_curve;
			r.IntField[FI.players_internationalrep] = this.m_internationalrep + 1;
			r.IntField[FI.players_eyecolorcode] = this.m_eyecolorcode;
			r.IntField[FI.players_eyebrowcode] = this.m_eyebrowcode;
			r.IntField[FI.players_hairtypecode] = this.m_hairtypecode;
			r.IntField[FI.players_headtypecode] = this.m_headtypecode;
			r.IntField[FI.players_headclasscode] = this.m_headclasscode;
			r.IntField[FI.players_haircolorcode] = this.m_haircolorcode;
			r.IntField[FI.players_facialhairtypecode] = this.m_facialhairtypecode;
			r.IntField[FI.players_facialhaircolorcode] = this.m_facialhaircolorcode;
			r.IntField[FI.players_sideburnscode] = 0;
			r.IntField[FI.players_skintypecode] = this.m_skintypecode;
			r.IntField[FI.players_skintonecode] = this.m_skintonecode;
			r.IntField[FI.players_shoecolorcode1] = this.m_shoecolorcode1;
			r.IntField[FI.players_shoetypecode] = this.m_shoetypecode;
			r.IntField[FI.players_overallrating] = this.m_overallrating;
			r.IntField[FI.players_interceptions] = this.m_interceptions;
			r.IntField[FI.players_shoecolorcode2] = this.m_shoecolorcode2;
			r.IntField[FI.players_jerseyfit] = (this.m_jerseyfit ? 1 : 0);
			r.IntField[FI.players_shoedesigncode] = this.m_shoedesigncode;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00032C60 File Offset: 0x00030E60
		public int RandomizeWeight()
		{
			int num = this.m_height - 110;
			Random randomizer = Player.m_Randomizer;
			int num2 = num;
			this.m_weight = randomizer.Next(num2, num2 + 11);
			return this.m_weight;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00032C94 File Offset: 0x00030E94
		public bool RandomizeSkillsAround(int overall, int error)
		{
			if (overall < 10 || overall > 99)
			{
				return false;
			}
			int num = Player.s_MeanLevels.Length - 1;
			for (int i = 0; i < Player.s_MeanLevels.Length; i++)
			{
				if (overall <= Player.s_MeanLevels[i])
				{
					num = i;
					break;
				}
			}
			do
			{
				this.RandomizeAttributes(num);
			}
			while (this.m_overallrating < overall - error || this.m_overallrating > overall + error);
			return true;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00032CF8 File Offset: 0x00030EF8
		public bool RandomizeSkillsExactly(int overall)
		{
			if (overall < 10 || overall > 99)
			{
				return false;
			}
			int num = Player.s_MeanLevels.Length - 1;
			for (int i = 0; i < Player.s_MeanLevels.Length; i++)
			{
				if (overall <= Player.s_MeanLevels[i])
				{
					num = i;
					break;
				}
			}
			this.RandomizeAttributes(num);
			if (overall != this.m_overallrating)
			{
				this.ChangeSkills(overall - this.m_overallrating);
			}
			return true;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00032D5C File Offset: 0x00030F5C
		public void RandomizeAttributes(int level)
		{
			int num = Player.s_MeanLevels[level];
			int preferredposition = this.m_preferredposition1;
			int num2 = Player.c_Attributes[preferredposition, 0] * num / 100;
			num2 = FifaUtil.Limit(num2, 11, 90);
			int num3 = Player.c_Attributes[preferredposition, 1] * num / 100;
			num3 = FifaUtil.Limit(num3, 11, 90);
			int num4 = Player.c_Attributes[preferredposition, 2] * num / 100;
			num4 = FifaUtil.Limit(num4, 11, 90);
			int num5 = Player.c_Attributes[preferredposition, 3] * num / 100;
			num5 = FifaUtil.Limit(num5, 11, 90);
			this.m_gkreflexes = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkdiving = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkpositioning = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkhandling = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkkicking = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			int num6 = 20 + level * 8 + (this.m_height - 175) * 2;
			if (num6 > 90)
			{
				num6 = 90;
			}
			if (num6 < 20)
			{
				num6 = 20;
			}
			this.m_headingaccuracy = Player.m_Randomizer.Next(num6 - 10, num6 + 10);
			this.m_marking = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_interceptions = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_standingtackle = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_slidingtackle = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_aggression = Player.m_Randomizer.Next(num3 - 10, num3 + 10);
			this.m_shortpassing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_longpassing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_crossing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_ballcontrol = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_vision = Player.m_Randomizer.Next(num4 - 10, num4 + 10);
			this.m_weakfootabilitytypecode = Player.m_Randomizer.Next(1, 6);
			this.m_curve = Player.m_Randomizer.Next(num4 - 10, num4 + 10);
			this.m_finishing = Player.m_Randomizer.Next(num5 - 7, num5 + 7);
			this.m_shotpower = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_longshots = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_dribbling = Player.m_Randomizer.Next(num5 - 7, num5 + 7);
			this.m_volleys = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_penalties = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_positioning = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			int num7 = 25 + level * 9;
			int num8 = 35 + level * 9;
			int num9 = 72 + level * 4;
			this.m_acceleration = Player.m_Randomizer.Next(num7, num9);
			this.m_sprintspeed = Player.m_Randomizer.Next(num7, num9);
			this.m_stamina = Player.m_Randomizer.Next(num7, num9);
			this.m_strength = Player.m_Randomizer.Next(num7, num9);
			this.m_freekickaccuracy = Player.m_Randomizer.Next(num8 - 10, num8 + 10);
			this.m_reactions = Player.m_Randomizer.Next(num8 - 10, num8 + 10);
			this.m_agility = Player.m_Randomizer.Next(num8 - 10, num8 + 10);
			this.m_balance = Player.m_Randomizer.Next(num8 - 10, num8 + 10);
			this.m_jumping = Player.m_Randomizer.Next(num8 - 10, num8 + 10);
			this.m_overallrating = this.GetAverageRoleAttribute();
			int num10 = 2000 + FifaEnvironment.Year - this.m_birthdate.Year;
			if (num10 > 30)
			{
				this.m_potential = this.m_overallrating;
			}
			else
			{
				if (num10 < 16)
				{
					num10 = 16;
				}
				if (num10 > 25)
				{
					num10 = 25;
				}
				num7 = 1 + (25 - num10) / 1;
				num9 = 5 + (25 - num10) * 4;
				this.m_potential = Player.m_Randomizer.Next(this.m_overallrating + num7, this.m_overallrating + num9);
				if (this.m_potential > 96)
				{
					this.m_potential = 96;
				}
			}
			this.m_InjuryFree = Player.m_Randomizer.Next(0, 100) <= 5;
			if (this.m_InjuryFree)
			{
				this.m_InjuryProne = false;
			}
			else
			{
				this.m_InjuryProne = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			if (level >= 4)
			{
				this.m_Leadership = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			this.m_ArguesWithOfficials = Player.m_Randomizer.Next(0, 100) <= 5;
			this.m_AvoidsWeakFoot = Player.m_Randomizer.Next(0, 100) <= 5;
			if (this.m_preferredposition1 == 0)
			{
				this.m_Pushesupforcorners = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Puncher = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_GkLongThrower = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_gksavetype = ((Player.m_Randomizer.Next(0, 100) <= 20) ? 1 : 0);
				this.m_GkOneOnOne = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			else
			{
				if (num5 >= 75)
				{
					this.m_Selfish = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				if (num4 >= 70)
				{
					this.m_Playmaker = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				else
				{
					this.m_Playmaker = false;
				}
				this.m_Diver = Player.m_Randomizer.Next(0, 100) <= 5;
				if (preferredposition < 12)
				{
					this.m_Divesintotackles = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				this.m_LongShotTaker = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Earlycrosser = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_LongPasser = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Longthrows = Player.m_Randomizer.Next(0, 100) <= 2;
				this.m_Inflexible = Player.m_Randomizer.Next(0, 100) <= 2;
				if (this.m_dribbling > 75)
				{
					this.m_Technicaldribbler = Player.m_Randomizer.Next(0, 100) <= this.m_dribbling - 70;
				}
				if (this.m_curve > 75)
				{
					this.m_OutsideFootShot = Player.m_Randomizer.Next(0, 100) <= this.m_curve - 70;
				}
				if (num4 >= 80 || num5 >= 85)
				{
					this.m_Flair = Player.m_Randomizer.Next(0, 100) <= 10;
					this.m_FinesseShot = Player.m_Randomizer.Next(0, 100) <= 10;
				}
				this.m_PowerfulFreeKicks = Player.m_Randomizer.Next(0, 100) <= 5;
				if ((double)this.m_height > 1.85)
				{
					this.m_PowerHeader = Player.m_Randomizer.Next(0, 100) <= this.m_height - 180;
				}
				this.m_BeatDefensiveLine = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			this.m_animfreekickstartposcode = Player.m_Randomizer.Next(0, 10);
			this.m_animpenaltieskickstylecode = Player.m_Randomizer.Next(0, 3);
			this.m_animpenaltiesmotionstylecode = Player.m_Randomizer.Next(0, 7);
			this.m_animpenaltiesstartposcode = Player.m_Randomizer.Next(0, 9);
			int num11 = level - 1;
			this.m_internationalrep = ((num11 < 1) ? 1 : num11);
			this.m_overallrating = this.GetAverageRoleAttribute();
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00033580 File Offset: 0x00031780
		public void RandomizeIdentity()
		{
			this.m_height = Player.m_Randomizer.Next(165, 196);
			this.m_bodytypecode = Player.m_Randomizer.Next(0, 3);
			this.m_weight = this.m_height - 110 + this.m_bodytypecode * 5 + Player.m_Randomizer.Next(0, 5);
			this.m_preferredfoot = ((Player.m_Randomizer.Next(0, 100) < 10) ? 1 : 0);
			this.m_weakfootabilitytypecode = Player.m_Randomizer.Next(1, 6);
			this.m_jerseysleevelengthcode = ((Player.m_Randomizer.Next(0, 100) < 5) ? 1 : 0);
			this.m_jerseystylecode = ((Player.m_Randomizer.Next(0, 100) < 10) ? 1 : 0);
			this.m_hasseasonaljersey = ((Player.m_Randomizer.Next(0, 100) < 40) ? 1 : 0);
			int num = Player.m_Randomizer.Next(1, 7665);
			this.m_birthdate = new DateTime(1974, 1, 1) + new TimeSpan(num, 0, 0, 0);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003368C File Offset: 0x0003188C
		public void RandomizeAppearanceSameRace()
		{
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < GenericHead.c_CaucasicModels.Length; i++)
			{
				if (GenericHead.c_CaucasicModels[i] == this.m_headtypecode)
				{
					this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < GenericHead.c_AfricanModels.Length; j++)
				{
					if (GenericHead.c_AfricanModels[j] == this.m_headtypecode)
					{
						this.m_headtypecode = GenericHead.c_AfricanModels[Player.m_Randomizer.Next(0, GenericHead.c_AfricanModels.Length)];
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				for (int k = 0; k < GenericHead.c_AsiaticModels.Length; k++)
				{
					if (GenericHead.c_AsiaticModels[k] == this.m_headtypecode)
					{
						this.m_headtypecode = GenericHead.c_AsiaticModels[Player.m_Randomizer.Next(0, GenericHead.c_AsiaticModels.Length)];
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				for (int l = 0; l < GenericHead.c_LatinModels.Length; l++)
				{
					if (GenericHead.c_LatinModels[l] == this.m_headtypecode)
					{
						this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
						break;
					}
				}
			}
			for (int m = 0; m < GenericHead.c_ShavenModels.Length; m++)
			{
				if (GenericHead.c_ShavenModels[m] == this.m_hairtypecode)
				{
					this.m_hairtypecode = GenericHead.c_ShavenModels[Player.m_Randomizer.Next(0, GenericHead.c_ShavenModels.Length)];
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				for (int n = 0; n < GenericHead.c_VeryShortModels.Length; n++)
				{
					if (GenericHead.c_VeryShortModels[n] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_VeryShortModels[Player.m_Randomizer.Next(0, GenericHead.c_VeryShortModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num = 0; num < GenericHead.c_ShortModels.Length; num++)
				{
					if (GenericHead.c_ShortModels[num] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_ShortModels[Player.m_Randomizer.Next(0, GenericHead.c_ShortModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num2 = 0; num2 < GenericHead.c_ModernModels.Length; num2++)
				{
					if (GenericHead.c_ModernModels[num2] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_ModernModels[Player.m_Randomizer.Next(0, GenericHead.c_ModernModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num3 = 0; num3 < GenericHead.c_MediumModels.Length; num3++)
				{
					if (GenericHead.c_MediumModels[num3] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_MediumModels[Player.m_Randomizer.Next(0, GenericHead.c_MediumModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num4 = 0; num4 < GenericHead.c_LongModels.Length; num4++)
				{
					if (GenericHead.c_LongModels[num4] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_LongModels[Player.m_Randomizer.Next(0, GenericHead.c_LongModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num5 = 0; num5 < GenericHead.c_HeadbendModels.Length; num5++)
				{
					if (GenericHead.c_HeadbendModels[num5] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_HeadbendModels[Player.m_Randomizer.Next(0, GenericHead.c_HeadbendModels.Length)];
						flag2 = true;
						break;
					}
				}
			}
			if (!flag2)
			{
				for (int num6 = 0; num6 < GenericHead.c_AfroModels.Length; num6++)
				{
					if (GenericHead.c_AfroModels[num6] == this.m_hairtypecode)
					{
						this.m_hairtypecode = GenericHead.c_AfroModels[Player.m_Randomizer.Next(0, GenericHead.c_AfroModels.Length)];
						return;
					}
				}
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00033A24 File Offset: 0x00031C24
		public void RandomizeAppearanceSimilarTo(Player similarPlayer)
		{
			this.m_headtypecode = similarPlayer.headtypecode;
			this.m_hairtypecode = similarPlayer.hairtypecode;
			this.m_haircolorcode = similarPlayer.m_haircolorcode;
			this.m_facialhaircolorcode = similarPlayer.m_facialhaircolorcode;
			this.m_facialhairtypecode = similarPlayer.m_facialhairtypecode;
			this.m_skintonecode = similarPlayer.m_skintonecode;
			this.m_skintypecode = similarPlayer.m_skintypecode;
			this.m_eyebrowcode = similarPlayer.m_eyebrowcode;
			this.m_eyecolorcode = similarPlayer.m_eyecolorcode;
			this.RandomizeAppearanceSameRace();
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00033AA4 File Offset: 0x00031CA4
		public void RandomizeCaucasianAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 125);
			this.m_haircolorcode = Player.m_Randomizer.Next(0, 8);
			this.m_sideburnscode = 0;
			this.m_skintonecode = Player.m_Randomizer.Next(1, 5);
			if (this.m_skintonecode == 1)
			{
				this.m_skintonecode = 2;
			}
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 2;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(1, 11);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 20);
			if (this.m_facialhairtypecode == 13 || this.m_facialhairtypecode > 15)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00033BD4 File Offset: 0x00031DD4
		public void RandomizeAsiaticAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 9)
			{
				this.m_headtypecode = GenericHead.c_AsiaticModels[Player.m_Randomizer.Next(0, GenericHead.c_AsiaticModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 125);
			this.m_haircolorcode = Player.m_Randomizer.Next(1, 6);
			if (this.m_haircolorcode == 3)
			{
				this.m_haircolorcode = 1;
			}
			this.m_sideburnscode = 0;
			this.m_skintonecode = Player.m_Randomizer.Next(3, 7);
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 4;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 11);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 20);
			if (this.m_facialhairtypecode == 11 || this.m_facialhairtypecode == 13 || this.m_facialhairtypecode > 15)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00033D0C File Offset: 0x00031F0C
		public void RandomizeAfricanAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_AfricanModels[Player.m_Randomizer.Next(0, GenericHead.c_AfricanModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 125);
			this.m_haircolorcode = 1;
			this.m_sideburnscode = 0;
			this.m_skintonecode = Player.m_Randomizer.Next(6, 11);
			if (this.m_skintonecode == 7)
			{
				this.m_skintonecode = 8;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 5);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 20);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 15)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00033E20 File Offset: 0x00032020
		public void RandomizeLatinAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 125);
			this.m_haircolorcode = 1;
			this.m_sideburnscode = 0;
			this.m_skintonecode = Player.m_Randomizer.Next(4, 7);
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 11);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 20);
			if (this.m_facialhairtypecode == 13 || this.m_facialhairtypecode > 15)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00033F24 File Offset: 0x00032124
		public int ComputeMeanAttributes(int type)
		{
			switch (type)
			{
			case 0:
				return (this.m_gkpositioning + this.m_gkdiving + this.m_gkreflexes + this.m_gkhandling + this.m_gkkicking) / 5;
			case 1:
				return (this.m_aggression + this.m_standingtackle + this.m_slidingtackle + this.m_marking + this.m_interceptions) / 5;
			case 2:
				return (this.m_crossing + this.m_shortpassing + this.m_longpassing + this.m_ballcontrol + this.m_vision + this.m_curve) / 6;
			case 3:
				return (this.m_finishing + this.m_shotpower + this.m_longshots + this.m_dribbling + this.m_headingaccuracy + this.m_volleys) / 6;
			case 4:
				return (this.m_acceleration + this.m_sprintspeed + this.m_stamina + this.m_strength + this.m_agility + this.m_jumping + this.m_reactions + this.m_balance) / 8;
			case 5:
				return (this.m_potential + this.m_positioning) / 2;
			case 6:
				return (this.m_freekickaccuracy + this.m_penalties) / 2;
			default:
				return 0;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00034058 File Offset: 0x00032258
		public void IncreaseAllAttributes()
		{
			this.m_gkpositioning += ((this.m_gkpositioning < 99) ? 1 : 0);
			this.m_gkdiving += ((this.m_gkdiving < 99) ? 1 : 0);
			this.m_gkreflexes += ((this.m_gkreflexes < 99) ? 1 : 0);
			this.m_gkhandling += ((this.m_gkhandling < 99) ? 1 : 0);
			this.m_gkkicking += ((this.m_gkkicking < 99) ? 1 : 0);
			this.m_aggression += ((this.m_aggression < 99) ? 1 : 0);
			this.m_standingtackle += ((this.m_standingtackle < 99) ? 1 : 0);
			this.m_slidingtackle += ((this.m_slidingtackle < 99) ? 1 : 0);
			this.m_marking += ((this.m_marking < 99) ? 1 : 0);
			this.m_interceptions += ((this.m_interceptions < 99) ? 1 : 0);
			this.m_crossing += ((this.m_crossing < 99) ? 1 : 0);
			this.m_shortpassing += ((this.m_shortpassing < 99) ? 1 : 0);
			this.m_longpassing += ((this.m_longpassing < 99) ? 1 : 0);
			this.m_ballcontrol += ((this.m_ballcontrol < 99) ? 1 : 0);
			this.m_vision += ((this.m_vision < 99) ? 1 : 0);
			this.m_curve += ((this.m_curve < 99) ? 1 : 0);
			this.m_finishing += ((this.m_finishing < 99) ? 1 : 0);
			this.m_shotpower += ((this.m_shotpower < 99) ? 1 : 0);
			this.m_longshots += ((this.m_longshots < 99) ? 1 : 0);
			this.m_dribbling += ((this.m_dribbling < 99) ? 1 : 0);
			this.m_headingaccuracy += ((this.m_headingaccuracy < 99) ? 1 : 0);
			this.m_volleys += ((this.m_volleys < 99) ? 1 : 0);
			this.m_acceleration += ((this.m_acceleration < 99) ? 1 : 0);
			this.m_sprintspeed += ((this.m_sprintspeed < 99) ? 1 : 0);
			this.m_stamina += ((this.m_stamina < 99) ? 1 : 0);
			this.m_strength += ((this.m_strength < 99) ? 1 : 0);
			this.m_agility += ((this.m_agility < 99) ? 1 : 0);
			this.m_jumping += ((this.m_jumping < 99) ? 1 : 0);
			this.m_reactions += ((this.m_reactions < 99) ? 1 : 0);
			this.m_balance += ((this.m_balance < 99) ? 1 : 0);
			this.m_potential += ((this.m_potential < 99) ? 1 : 0);
			this.m_positioning += ((this.m_positioning < 99) ? 1 : 0);
			this.m_freekickaccuracy += ((this.m_freekickaccuracy < 99) ? 1 : 0);
			this.m_penalties += ((this.m_penalties < 99) ? 1 : 0);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000343FC File Offset: 0x000325FC
		public void DecreaseAllAttributes()
		{
			this.m_gkpositioning -= ((this.m_gkpositioning > 9) ? 1 : 0);
			this.m_gkdiving -= ((this.m_gkdiving > 9) ? 1 : 0);
			this.m_gkreflexes -= ((this.m_gkreflexes > 9) ? 1 : 0);
			this.m_gkhandling -= ((this.m_gkhandling > 9) ? 1 : 0);
			this.m_gkkicking -= ((this.m_gkkicking > 9) ? 1 : 0);
			this.m_aggression -= ((this.m_aggression > 9) ? 1 : 0);
			this.m_standingtackle -= ((this.m_standingtackle > 9) ? 1 : 0);
			this.m_slidingtackle -= ((this.m_slidingtackle > 9) ? 1 : 0);
			this.m_marking -= ((this.m_marking > 9) ? 1 : 0);
			this.m_interceptions -= ((this.m_interceptions > 9) ? 1 : 0);
			this.m_crossing -= ((this.m_crossing > 9) ? 1 : 0);
			this.m_shortpassing -= ((this.m_shortpassing > 9) ? 1 : 0);
			this.m_longpassing -= ((this.m_longpassing > 9) ? 1 : 0);
			this.m_ballcontrol -= ((this.m_ballcontrol > 9) ? 1 : 0);
			this.m_vision -= ((this.m_vision > 9) ? 1 : 0);
			this.m_curve -= ((this.m_curve > 9) ? 1 : 0);
			this.m_finishing -= ((this.m_finishing > 9) ? 1 : 0);
			this.m_shotpower -= ((this.m_shotpower > 9) ? 1 : 0);
			this.m_longshots -= ((this.m_longshots > 9) ? 1 : 0);
			this.m_dribbling -= ((this.m_dribbling > 9) ? 1 : 0);
			this.m_headingaccuracy -= ((this.m_headingaccuracy > 9) ? 1 : 0);
			this.m_volleys -= ((this.m_volleys > 9) ? 1 : 0);
			this.m_acceleration -= ((this.m_acceleration > 9) ? 1 : 0);
			this.m_sprintspeed -= ((this.m_sprintspeed > 9) ? 1 : 0);
			this.m_stamina -= ((this.m_stamina > 9) ? 1 : 0);
			this.m_strength -= ((this.m_strength > 9) ? 1 : 0);
			this.m_agility -= ((this.m_agility > 9) ? 1 : 0);
			this.m_jumping -= ((this.m_jumping > 9) ? 1 : 0);
			this.m_reactions -= ((this.m_reactions > 9) ? 1 : 0);
			this.m_balance -= ((this.m_balance > 9) ? 1 : 0);
			this.m_potential -= ((this.m_potential > 9) ? 1 : 0);
			this.m_positioning -= ((this.m_positioning > 9) ? 1 : 0);
			this.m_freekickaccuracy -= ((this.m_freekickaccuracy > 9) ? 1 : 0);
			this.m_penalties -= ((this.m_penalties > 9) ? 1 : 0);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000347A0 File Offset: 0x000329A0
		public int GetAverageRoleAttribute()
		{
			int num;
			switch (this.m_preferredposition1)
			{
			case 0:
				num = (this.m_gkreflexes * 21 + this.m_gkhandling * 21 + this.m_gkdiving * 21 + this.m_gkpositioning * 21 + this.m_gkkicking * 5 + this.m_reactions * 11 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 1:
				num = (this.m_interceptions * 20 + this.m_standingtackle * 14 + this.m_marking * 12 + this.m_slidingtackle * 12 + this.m_headingaccuracy * 8 + this.m_ballcontrol * 7 + this.m_shortpassing * 6 + this.m_reactions * 6 + this.m_vision * 6 + this.m_longpassing * 5 + this.m_aggression * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 2:
			case 8:
				num = (this.m_acceleration * 4 + this.m_sprintspeed * 6 + this.m_stamina * 10 + this.m_reactions * 8 + this.m_interceptions * 12 + this.m_ballcontrol * 8 + this.m_crossing * 12 + this.m_dribbling * 4 + this.m_shortpassing * 10 + this.m_marking * 7 + this.m_standingtackle * 8 + this.m_slidingtackle * 11 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 3:
			case 7:
				num = (this.m_acceleration * 5 + this.m_sprintspeed * 7 + this.m_stamina * 8 + this.m_reactions * 8 + this.m_ballcontrol * 7 + this.m_interceptions * 12 + this.m_crossing * 9 + this.m_headingaccuracy * 4 + this.m_shortpassing * 7 + this.m_marking * 8 + this.m_standingtackle * 11 + this.m_slidingtackle * 14 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 4:
			case 5:
			case 6:
				num = (this.m_sprintspeed * 2 + this.m_jumping * 3 + this.m_strength * 10 + this.m_reactions * 5 + this.m_aggression * 7 + this.m_interceptions * 13 + this.m_ballcontrol * 4 + this.m_headingaccuracy * 10 + this.m_shortpassing * 5 + this.m_marking * 14 + this.m_standingtackle * 17 + this.m_slidingtackle * 10 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 9:
			case 10:
			case 11:
				num = (this.m_stamina * 6 + this.m_strength * 4 + this.m_reactions * 7 + this.m_aggression * 5 + this.m_interceptions * 14 + this.m_vision * 4 + this.m_ballcontrol * 10 + this.m_longpassing * 10 + this.m_shortpassing * 14 + this.m_marking * 9 + this.m_standingtackle * 12 + this.m_slidingtackle * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 12:
			case 16:
				num = (this.m_acceleration * 7 + this.m_sprintspeed * 6 + this.m_stamina * 5 + this.m_reactions * 7 + this.m_positioning * 8 + this.m_vision * 7 + this.m_ballcontrol * 13 + this.m_crossing * 10 + this.m_dribbling * 15 + this.m_finishing * 6 + this.m_longpassing * 5 + this.m_shortpassing * 11 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 13:
			case 14:
			case 15:
				num = (this.m_stamina * 6 + this.m_reactions * 8 + this.m_interceptions * 5 + this.m_positioning * 6 + this.m_vision * 13 + this.m_ballcontrol * 14 + this.m_dribbling * 7 + this.m_finishing * 2 + this.m_longpassing * 13 + this.m_shortpassing * 17 + this.m_longshots * 4 + this.m_strength * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 17:
			case 18:
			case 19:
				num = (this.m_acceleration * 4 + this.m_sprintspeed * 3 + this.m_agility * 3 + this.m_reactions * 7 + this.m_positioning * 9 + this.m_vision * 14 + this.m_ballcontrol * 15 + this.m_dribbling * 13 + this.m_finishing * 7 + this.m_longpassing * 4 + this.m_shortpassing * 16 + this.m_longshots * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 20:
			case 21:
			case 22:
				num = (this.m_acceleration * 5 + this.m_sprintspeed * 5 + this.m_reactions * 9 + this.m_positioning * 13 + this.m_vision * 8 + this.m_ballcontrol * 15 + this.m_dribbling * 14 + this.m_finishing * 11 + this.m_headingaccuracy * 2 + this.m_shortpassing * 9 + this.m_shotpower * 5 + this.m_longshots * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 23:
			case 27:
				num = (this.m_acceleration * 7 + this.m_sprintspeed * 6 + this.m_agility * 3 + this.m_reactions * 7 + this.m_positioning * 9 + this.m_vision * 6 + this.m_ballcontrol * 14 + this.m_crossing * 9 + this.m_dribbling * 16 + this.m_finishing * 10 + this.m_shortpassing * 9 + this.m_longshots * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 24:
			case 25:
			case 26:
				num = (this.m_acceleration * 4 + this.m_sprintspeed * 5 + this.m_strength * 5 + this.m_reactions * 8 + this.m_positioning * 13 + this.m_ballcontrol * 10 + this.m_dribbling * 7 + this.m_finishing * 18 + this.m_headingaccuracy * 10 + this.m_shortpassing * 5 + this.m_shotpower * 10 + this.m_longshots * 3 + this.m_volleys * 2 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			default:
				return 0;
			}
			switch (this.m_internationalrep + 1)
			{
			case 3:
				if (num > 50)
				{
					num++;
				}
				break;
			case 4:
				if (num > 68)
				{
					num += 2;
				}
				else if (num > 34)
				{
					num++;
				}
				break;
			case 5:
				if (num > 77)
				{
					num += 3;
				}
				else if (num > 51)
				{
					num += 2;
				}
				else if (num > 25)
				{
					num++;
				}
				break;
			}
			return num;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00034EB4 File Offset: 0x000330B4
		public int GetRolePerformance(ERole requestedRole)
		{
			int preferredposition = this.m_preferredposition1;
			return this.GetAverageRoleAttribute() * Player.c_RolesMap[preferredposition, (int)requestedRole] / 100;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00034EE0 File Offset: 0x000330E0
		public ERole ChooseRole(ERole[] availableRoles, int nRoles)
		{
			ERole erole = ERole.Tribune;
			int num = -1;
			for (int i = 0; i < nRoles; i++)
			{
				int rolePerformance = this.GetRolePerformance(availableRoles[i]);
				if (rolePerformance > num)
				{
					erole = availableRoles[i];
					num = rolePerformance;
				}
			}
			if ((this.m_preferredposition1 == 0 && erole != ERole.Goalkeeper) || (this.m_preferredposition1 != 0 && erole == ERole.Goalkeeper))
			{
				return ERole.Tribune;
			}
			return erole;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00034F2C File Offset: 0x0003312C
		public string GetRoleAcronym()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleShortString(this.m_preferredposition1);
			}
			return string.Empty;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00034F4B File Offset: 0x0003314B
		public string GetRoleString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString(this.m_preferredposition1);
			}
			return string.Empty;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00034F6C File Offset: 0x0003316C
		public void BuildHairPartsTextures()
		{
			if (this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null)
			{
				GraphicUtil.GetAlfaFromChannel((Bitmap)this.m_HairColorTextureBitmap.Clone(), this.m_HairAlfaTextureBitmap, 2);
				GraphicUtil.GetAlfaFromChannel((Bitmap)this.m_HairColorTextureBitmap.Clone(), this.m_HairAlfaTextureBitmap, 1);
				return;
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00034FD4 File Offset: 0x000331D4
		public bool CreateHead3D(string xFileName)
		{
			this.BuildHairPartsTextures();
			Rx3File rx3File = this.GetHeadModel();
			if (this.m_FaceTextureBitmaps == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_FaceTextureBitmaps[0]);
			if (this.m_EyesTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_EyesTextureBitmap);
			rx3File = this.GetHairModel();
			if (this.m_FaceTextureBitmaps == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_HairColorTextureBitmap);
			return true;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00035074 File Offset: 0x00033274
		public void ChangeSkills(int delta)
		{
			if (delta == 0)
			{
				return;
			}
			this.m_acceleration = this.ChangeSkill(this.m_acceleration, delta);
			this.m_aggression = this.ChangeSkill(this.m_aggression, delta);
			this.m_agility = this.ChangeSkill(this.m_agility, delta);
			this.m_balance = this.ChangeSkill(this.m_balance, delta);
			this.m_ballcontrol = this.ChangeSkill(this.m_ballcontrol, delta);
			this.m_crossing = this.ChangeSkill(this.m_crossing, delta);
			this.m_curve = this.ChangeSkill(this.m_curve, delta);
			this.m_dribbling = this.ChangeSkill(this.m_dribbling, delta);
			this.m_finishing = this.ChangeSkill(this.m_finishing, delta);
			this.m_freekickaccuracy = this.ChangeSkill(this.m_freekickaccuracy, delta);
			this.m_gkdiving = this.ChangeSkill(this.m_gkdiving, delta);
			this.m_gkhandling = this.ChangeSkill(this.m_gkhandling, delta);
			this.m_gkkicking = this.ChangeSkill(this.m_gkkicking, delta);
			this.m_gkpositioning = this.ChangeSkill(this.m_gkpositioning, delta);
			this.m_gkreflexes = this.ChangeSkill(this.m_gkreflexes, delta);
			this.m_interceptions = this.ChangeSkill(this.m_interceptions, delta);
			this.m_jumping = this.ChangeSkill(this.m_jumping, delta);
			this.m_longpassing = this.ChangeSkill(this.m_longpassing, delta);
			this.m_longshots = this.ChangeSkill(this.m_longshots, delta);
			this.m_marking = this.ChangeSkill(this.m_marking, delta);
			this.m_overallrating = this.ChangeSkill(this.m_overallrating, delta);
			this.m_penalties = this.ChangeSkill(this.m_penalties, delta);
			this.m_positioning = this.ChangeSkill(this.m_positioning, delta);
			this.m_potential = this.ChangeSkill(this.m_potential, delta);
			this.m_reactions = this.ChangeSkill(this.m_reactions, delta);
			this.m_shortpassing = this.ChangeSkill(this.m_shortpassing, delta);
			this.m_shotpower = this.ChangeSkill(this.m_shotpower, delta);
			this.m_sprintspeed = this.ChangeSkill(this.m_sprintspeed, delta);
			this.m_stamina = this.ChangeSkill(this.m_stamina, delta);
			this.m_standingtackle = this.ChangeSkill(this.m_standingtackle, delta);
			this.m_strength = this.ChangeSkill(this.m_strength, delta);
			this.m_vision = this.ChangeSkill(this.m_vision, delta);
			this.m_volleys = this.ChangeSkill(this.m_volleys, delta);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000352F8 File Offset: 0x000334F8
		private int ChangeSkill(int skillValue, int delta)
		{
			if (skillValue + delta < 10)
			{
				return 10;
			}
			if (skillValue + delta > 99)
			{
				return 99;
			}
			return skillValue + delta;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00035314 File Offset: 0x00033514
		public void UpdatePlayername(Table dcplayernamesTable, Table originalPlayernamesTable)
		{
			if (this.firstnameid >= 29000)
			{
				this.firstname = this.GetDcPlayername(dcplayernamesTable, this.firstnameid);
			}
			else
			{
				this.firstname = this.GetPlayerName(originalPlayernamesTable, this.firstnameid);
			}
			if (this.lastnameid >= 29000)
			{
				this.lastname = this.GetDcPlayername(dcplayernamesTable, this.lastnameid);
			}
			else
			{
				this.lastname = this.GetPlayerName(originalPlayernamesTable, this.lastnameid);
			}
			if (this.commonnameid >= 29000)
			{
				this.commonname = this.GetDcPlayername(dcplayernamesTable, this.commonnameid);
			}
			else
			{
				this.commonname = this.GetPlayerName(originalPlayernamesTable, this.commonnameid);
			}
			if (this.playerjerseynameid >= 29000)
			{
				this.playerjerseyname = this.GetDcPlayername(dcplayernamesTable, this.playerjerseynameid);
				return;
			}
			this.playerjerseyname = this.GetPlayerName(originalPlayernamesTable, this.playerjerseynameid);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000353F4 File Offset: 0x000335F4
		private string GetDcPlayername(Table dcplayernamesTable, int nameId)
		{
			if (nameId >= 29000)
			{
				for (int i = 0; i < dcplayernamesTable.NValidRecords; i++)
				{
					Record record = dcplayernamesTable.Records[i];
					if (nameId == record.IntField[FI.dcplayernames_nameid])
					{
						return record.StringField[FI.dcplayernames_name];
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00035444 File Offset: 0x00033644
		private string GetPlayerName(Table playernamesTable, int nameId)
		{
			if (nameId < 29000)
			{
				for (int i = 0; i < playernamesTable.NValidRecords; i++)
				{
					Record record = playernamesTable.Records[i];
					if (nameId == record.IntField[FI.playernames_nameid])
					{
						return record.CompressedString[FI.playernames_name];
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00035494 File Offset: 0x00033694
		public void ConvertFaceTexturesFrom15To16()
		{
			if (this.m_headclasscode == 1)
			{
				return;
			}
			this.GetFaceTextures();
			if (this.m_FaceTextureBitmaps[0].Width != 1024 || this.m_FaceTextureBitmaps[0].Height != 1024 || this.m_FaceTextureBitmaps.Length != 2)
			{
				Bitmap[] array = new Bitmap[2];
				if (this.m_FaceTextureBitmaps[0].Width != 1024 || this.m_FaceTextureBitmaps[0].Height != 1024)
				{
					array[0] = GraphicUtil.ResizeBitmap(this.m_FaceTextureBitmaps[0], 1024, 1024, InterpolationMode.HighQualityBicubic);
				}
				else
				{
					array[0] = (Bitmap)this.m_FaceTextureBitmaps[0].Clone();
				}
				if (this.m_FaceTextureBitmaps.Length != 2)
				{
					array[1] = new Bitmap(1024, 1024, PixelFormat.Format32bppArgb);
				}
				else
				{
					array[1] = (Bitmap)this.m_FaceTextureBitmaps[1].Clone();
				}
				this.SetFaceTextures(array);
			}
		}

		// Token: 0x04000E97 RID: 3735
		private static int[,] c_RolesMap = new int[,]
		{
			{
				100, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0
			},
			{
				0, 100, 30, 85, 90, 95, 90, 85, 80, 50,
				50, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 50, 100, 80, 70, 50, 50, 50, 75, 5,
				5, 5, 50, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 80, 50, 100, 95, 90, 85, 80, 50, 50,
				50, 30, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 85, 40, 95, 100, 95, 90, 85, 50, 50,
				50, 30, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 90, 30, 90, 95, 100, 95, 90, 30, 50,
				50, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 85, 20, 85, 90, 95, 100, 95, 60, 30,
				30, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 80, 20, 80, 85, 90, 95, 100, 70, 30,
				30, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 50, 75, 70, 50, 50, 70, 80, 100, 5,
				5, 5, 5, 5, 5, 5, 50, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 20, 15, 10, 5, 5, 5, 5, 100,
				90, 85, 90, 85, 80, 75, 70, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 10, 15, 20, 10, 5, 5, 5, 95,
				100, 95, 80, 85, 90, 85, 80, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 10, 15, 20, 15, 10, 85,
				90, 100, 70, 75, 80, 95, 90, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 85,
				70, 60, 100, 95, 90, 85, 80, 90, 70, 70,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 90,
				70, 60, 95, 100, 95, 90, 85, 85, 80, 75,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 80,
				90, 80, 90, 95, 100, 95, 90, 80, 90, 80,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 60,
				80, 90, 85, 90, 95, 100, 95, 75, 80, 85,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 40, 5, 5, 5, 5, 30, 70, 60,
				70, 80, 80, 85, 90, 95, 100, 70, 70, 90,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 75, 80, 75, 70, 65, 100, 95, 90,
				90, 85, 80, 60, 20, 20, 20, 20
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 70, 75, 80, 75, 70, 95, 100, 95,
				85, 90, 85, 20, 20, 30, 20, 20
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 65, 70, 75, 80, 75, 90, 95, 100,
				80, 85, 90, 20, 20, 20, 20, 60
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 55, 55, 50,
				100, 95, 90, 70, 100, 95, 90, 55
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 50, 60, 50,
				95, 100, 95, 50, 95, 100, 95, 50
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 50, 55, 55,
				90, 95, 100, 55, 90, 95, 100, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 50, 10, 5, 10, 15, 60, 40, 40,
				60, 50, 50, 100, 90, 80, 85, 95
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 70, 100, 95, 95, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 60, 95, 100, 95, 60
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 70, 95, 95, 100, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 50, 40, 40, 60,
				50, 50, 60, 95, 85, 80, 90, 100
			}
		};

		// Token: 0x04000E98 RID: 3736
		private static int[] c_GenericModels = new int[]
		{
			0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
			10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
			20, 21, 22, 23, 24, 25, 2000, 2001, 2002, 2003,
			2004, 2005, 2006, 2007, 2008, 2009, 2010, 2012, 2013, 2014,
			3500, 3501, 3502, 3503, 3504, 3505, 4000, 4001, 4002, 4003,
			500, 501, 502, 503, 504, 505, 506, 507, 508, 509,
			510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
			520, 521, 522, 1500, 1501, 1502, 1503, 1504, 1505, 1506,
			1507, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516,
			1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526,
			1527, 1528, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507,
			2508, 2509, 2510, 2511, 2512, 1000, 1001, 1002, 1003, 1004,
			1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014,
			1015, 1016, 1017, 1018, 3000, 3001, 3002, 3003, 3004, 3005,
			4500, 4501, 4502, 5000, 5001, 5002, 5003
		};

		// Token: 0x04000E99 RID: 3737
		private static int[,] c_Attributes = new int[,]
		{
			{ 99, 20, 20, 20 },
			{ 20, 99, 70, 50 },
			{ 20, 90, 70, 50 },
			{ 20, 95, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 95, 75, 50 },
			{ 20, 90, 70, 50 },
			{ 20, 90, 90, 70 },
			{ 20, 90, 90, 70 },
			{ 20, 90, 90, 70 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 70, 90, 95 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 70, 90, 95 }
		};

		// Token: 0x04000E9A RID: 3738
		public static Color[] s_GenericColors = new Color[]
		{
			Color.FromArgb(180, 156, 114),
			Color.FromArgb(32, 32, 32),
			Color.FromArgb(135, 126, 100),
			Color.FromArgb(42, 35, 24),
			Color.FromArgb(168, 160, 128),
			Color.FromArgb(111, 91, 69),
			Color.FromArgb(75, 63, 49),
			Color.FromArgb(120, 85, 58),
			Color.FromArgb(160, 162, 155),
			Color.FromArgb(110, 115, 121),
			Color.FromArgb(77, 115, 70),
			Color.FromArgb(51, 80, 126),
			Color.FromArgb(110, 40, 30)
		};

		// Token: 0x04000E9B RID: 3739
		public static int s_GenericColorsDivisor = 96;

		// Token: 0x04000E9C RID: 3740
		private static Random m_Randomizer = new Random();

		// Token: 0x04000E9D RID: 3741
		private static PlayerNames s_PlayerNames = null;

		// Token: 0x04000E9E RID: 3742
		private Bitmap m_EyesTextureBitmap;

		// Token: 0x04000E9F RID: 3743
		private Bitmap[] m_FaceTextureBitmaps;

		// Token: 0x04000EA0 RID: 3744
		private Bitmap m_HairColorTextureBitmap;

		// Token: 0x04000EA1 RID: 3745
		private Bitmap m_HairAlfaTextureBitmap;

		// Token: 0x04000EA2 RID: 3746
		private Rx3File m_HeadModelFile;

		// Token: 0x04000EA3 RID: 3747
		private Rx3File m_HairModelFile;

		// Token: 0x04000EA4 RID: 3748
		public static Model3D s_Model3DHead = null;

		// Token: 0x04000EA5 RID: 3749
		public static Model3D s_Model3DEyes = null;

		// Token: 0x04000EA6 RID: 3750
		public static Model3D s_Model3DHairPart4 = null;

		// Token: 0x04000EA7 RID: 3751
		public static Model3D s_Model3DHairPart5 = null;

		// Token: 0x04000EA8 RID: 3752
		public bool m_HasSpecificPhoto;

		// Token: 0x04000EA9 RID: 3753
		public TeamList m_PlayingForTeams = new TeamList();

		// Token: 0x04000EAA RID: 3754
		public int m_assetid;

		// Token: 0x04000EAB RID: 3755
		private string m_firstname;

		// Token: 0x04000EAC RID: 3756
		private string m_lastname;

		// Token: 0x04000EAD RID: 3757
		private string m_audioname;

		// Token: 0x04000EAE RID: 3758
		private int m_commentaryid;

		// Token: 0x04000EAF RID: 3759
		public string m_commonname;

		// Token: 0x04000EB0 RID: 3760
		public string m_playerjerseyname;

		// Token: 0x04000EB1 RID: 3761
		private int m_firstnameid;

		// Token: 0x04000EB2 RID: 3762
		private int m_lastnameid;

		// Token: 0x04000EB3 RID: 3763
		private int m_commonnameid;

		// Token: 0x04000EB4 RID: 3764
		private int m_playerjerseynameid;

		// Token: 0x04000EB5 RID: 3765
		private DateTime m_birthdate;

		// Token: 0x04000EB6 RID: 3766
		public DateTime m_playerjointeamdate;

		// Token: 0x04000EB7 RID: 3767
		private int m_contractvaliduntil;

		// Token: 0x04000EB8 RID: 3768
		private int m_height;

		// Token: 0x04000EB9 RID: 3769
		private int m_weight;

		// Token: 0x04000EBA RID: 3770
		private int m_nationality;

		// Token: 0x04000EBB RID: 3771
		private Country m_Country;

		// Token: 0x04000EBC RID: 3772
		private int m_eyecolorcode;

		// Token: 0x04000EBD RID: 3773
		private int m_eyebrowcode;

		// Token: 0x04000EBE RID: 3774
		private int m_bodytypecode;

		// Token: 0x04000EBF RID: 3775
		private int m_hairtypecode;

		// Token: 0x04000EC0 RID: 3776
		private int m_headtypecode;

		// Token: 0x04000EC1 RID: 3777
		private int m_headclasscode;

		// Token: 0x04000EC2 RID: 3778
		private int m_haircolorcode;

		// Token: 0x04000EC3 RID: 3779
		private int m_facialhairtypecode;

		// Token: 0x04000EC4 RID: 3780
		private int m_facialhaircolorcode;

		// Token: 0x04000EC5 RID: 3781
		private int m_sideburnscode;

		// Token: 0x04000EC6 RID: 3782
		private int m_skintypecode;

		// Token: 0x04000EC7 RID: 3783
		private int m_skintonecode;

		// Token: 0x04000EC8 RID: 3784
		private int m_jerseysleevelengthcode;

		// Token: 0x04000EC9 RID: 3785
		private int m_jerseystylecode;

		// Token: 0x04000ECA RID: 3786
		private int m_hasseasonaljersey;

		// Token: 0x04000ECB RID: 3787
		private int m_animfreekickstartposcode;

		// Token: 0x04000ECC RID: 3788
		private int m_animpenaltieskickstylecode;

		// Token: 0x04000ECD RID: 3789
		private int m_animpenaltiesmotionstylecode;

		// Token: 0x04000ECE RID: 3790
		private int m_animpenaltiesstartposcode;

		// Token: 0x04000ECF RID: 3791
		private int m_accessorycode1;

		// Token: 0x04000ED0 RID: 3792
		private int m_accessorycolourcode1;

		// Token: 0x04000ED1 RID: 3793
		private int m_accessorycode2;

		// Token: 0x04000ED2 RID: 3794
		private int m_accessorycolourcode2;

		// Token: 0x04000ED3 RID: 3795
		private int m_accessorycode3;

		// Token: 0x04000ED4 RID: 3796
		private int m_accessorycolourcode3;

		// Token: 0x04000ED5 RID: 3797
		private int m_accessorycode4;

		// Token: 0x04000ED6 RID: 3798
		private int m_accessorycolourcode4;

		// Token: 0x04000ED7 RID: 3799
		private int m_shoetypecode;

		// Token: 0x04000ED8 RID: 3800
		private int m_shoedesigncode;

		// Token: 0x04000ED9 RID: 3801
		private int m_shoecolorcode1;

		// Token: 0x04000EDA RID: 3802
		private int m_shoecolorcode2;

		// Token: 0x04000EDB RID: 3803
		private int m_preferredposition1;

		// Token: 0x04000EDC RID: 3804
		private int m_preferredposition2;

		// Token: 0x04000EDD RID: 3805
		private int m_preferredposition3;

		// Token: 0x04000EDE RID: 3806
		private int m_preferredposition4;

		// Token: 0x04000EDF RID: 3807
		private int m_preferredfoot;

		// Token: 0x04000EE0 RID: 3808
		private int m_weakfootabilitytypecode;

		// Token: 0x04000EE1 RID: 3809
		private int m_acceleration;

		// Token: 0x04000EE2 RID: 3810
		private int m_aggression;

		// Token: 0x04000EE3 RID: 3811
		private int m_gkglovetypecode;

		// Token: 0x04000EE4 RID: 3812
		private int m_agility;

		// Token: 0x04000EE5 RID: 3813
		private int m_balance;

		// Token: 0x04000EE6 RID: 3814
		private int m_gkkicking;

		// Token: 0x04000EE7 RID: 3815
		private int m_gkkickstyle;

		// Token: 0x04000EE8 RID: 3816
		private int m_jumping;

		// Token: 0x04000EE9 RID: 3817
		private int m_penalties;

		// Token: 0x04000EEA RID: 3818
		private int m_vision;

		// Token: 0x04000EEB RID: 3819
		private int m_volleys;

		// Token: 0x04000EEC RID: 3820
		private int m_skillmoves;

		// Token: 0x04000EED RID: 3821
		private int m_usercaneditname;

		// Token: 0x04000EEE RID: 3822
		private int m_sprintspeed;

		// Token: 0x04000EEF RID: 3823
		private int m_stamina;

		// Token: 0x04000EF0 RID: 3824
		private int m_strength;

		// Token: 0x04000EF1 RID: 3825
		private int m_marking;

		// Token: 0x04000EF2 RID: 3826
		private int m_standingtackle;

		// Token: 0x04000EF3 RID: 3827
		private int m_slidingtackle;

		// Token: 0x04000EF4 RID: 3828
		private int m_ballcontrol;

		// Token: 0x04000EF5 RID: 3829
		private int m_dribbling;

		// Token: 0x04000EF6 RID: 3830
		private int m_crossing;

		// Token: 0x04000EF7 RID: 3831
		private int m_headingaccuracy;

		// Token: 0x04000EF8 RID: 3832
		private int m_shortpassing;

		// Token: 0x04000EF9 RID: 3833
		private int m_longpassing;

		// Token: 0x04000EFA RID: 3834
		private int m_longshots;

		// Token: 0x04000EFB RID: 3835
		private int m_finishing;

		// Token: 0x04000EFC RID: 3836
		private int m_shotpower;

		// Token: 0x04000EFD RID: 3837
		private int m_reactions;

		// Token: 0x04000EFE RID: 3838
		private int m_gkreflexes;

		// Token: 0x04000EFF RID: 3839
		private int m_gkhandling;

		// Token: 0x04000F00 RID: 3840
		private int m_gkdiving;

		// Token: 0x04000F01 RID: 3841
		private int m_gkpositioning;

		// Token: 0x04000F02 RID: 3842
		private int m_freekickaccuracy;

		// Token: 0x04000F03 RID: 3843
		private int m_potential;

		// Token: 0x04000F04 RID: 3844
		private int m_positioning;

		// Token: 0x04000F05 RID: 3845
		private int m_overallrating;

		// Token: 0x04000F06 RID: 3846
		private bool m_Inflexible;

		// Token: 0x04000F07 RID: 3847
		private bool m_GkOneOnOne;

		// Token: 0x04000F08 RID: 3848
		private bool m_CrowdFavorite;

		// Token: 0x04000F09 RID: 3849
		private bool m_SecondWind;

		// Token: 0x04000F0A RID: 3850
		private bool m_AcrobaticClearance;

		// Token: 0x04000F0B RID: 3851
		private bool m_Longthrows;

		// Token: 0x04000F0C RID: 3852
		private bool m_PowerfulFreeKicks;

		// Token: 0x04000F0D RID: 3853
		private bool m_Diver;

		// Token: 0x04000F0E RID: 3854
		private bool m_InjuryFree;

		// Token: 0x04000F0F RID: 3855
		private bool m_InjuryProne;

		// Token: 0x04000F10 RID: 3856
		private bool m_AvoidsWeakFoot;

		// Token: 0x04000F11 RID: 3857
		private bool m_Divesintotackles;

		// Token: 0x04000F12 RID: 3858
		private bool m_BeatDefensiveLine;

		// Token: 0x04000F13 RID: 3859
		private bool m_Selfish;

		// Token: 0x04000F14 RID: 3860
		private bool m_Leadership;

		// Token: 0x04000F15 RID: 3861
		private bool m_ArguesWithOfficials;

		// Token: 0x04000F16 RID: 3862
		private bool m_Earlycrosser;

		// Token: 0x04000F17 RID: 3863
		private bool m_FinesseShot;

		// Token: 0x04000F18 RID: 3864
		private bool m_Flair;

		// Token: 0x04000F19 RID: 3865
		private bool m_LongPasser;

		// Token: 0x04000F1A RID: 3866
		private bool m_LongShotTaker;

		// Token: 0x04000F1B RID: 3867
		private bool m_Technicaldribbler;

		// Token: 0x04000F1C RID: 3868
		private bool m_Playmaker;

		// Token: 0x04000F1D RID: 3869
		private bool m_Pushesupforcorners;

		// Token: 0x04000F1E RID: 3870
		private bool m_Puncher;

		// Token: 0x04000F1F RID: 3871
		private bool m_GkLongThrower;

		// Token: 0x04000F20 RID: 3872
		private bool m_PowerHeader;

		// Token: 0x04000F21 RID: 3873
		private bool m_GiantThrow;

		// Token: 0x04000F22 RID: 3874
		private bool m_OutsideFootShot;

		// Token: 0x04000F23 RID: 3875
		private bool m_SwervePasser;

		// Token: 0x04000F24 RID: 3876
		private bool m_HighClubIdentification;

		// Token: 0x04000F25 RID: 3877
		private bool m_TeamPlayer;

		// Token: 0x04000F26 RID: 3878
		private bool m_FancyFeet;

		// Token: 0x04000F27 RID: 3879
		private bool m_FancyPasses;

		// Token: 0x04000F28 RID: 3880
		private bool m_FancyFlicks;

		// Token: 0x04000F29 RID: 3881
		private bool m_StutterPenalty;

		// Token: 0x04000F2A RID: 3882
		private bool m_ChipperPenalty;

		// Token: 0x04000F2B RID: 3883
		private bool m_BycicleKick;

		// Token: 0x04000F2C RID: 3884
		private bool m_DivingHeader;

		// Token: 0x04000F2D RID: 3885
		private bool m_DrivenPass;

		// Token: 0x04000F2E RID: 3886
		private bool m_GkFlatKick;

		// Token: 0x04000F2F RID: 3887
		private int m_curve;

		// Token: 0x04000F30 RID: 3888
		private int m_internationalrep;

		// Token: 0x04000F31 RID: 3889
		private bool m_gender;

		// Token: 0x04000F32 RID: 3890
		private int m_emotion;

		// Token: 0x04000F33 RID: 3891
		private int m_finishingcode1;

		// Token: 0x04000F34 RID: 3892
		private int m_finishingcode2;

		// Token: 0x04000F35 RID: 3893
		private int m_runningcode1;

		// Token: 0x04000F36 RID: 3894
		private int m_runningcode2;

		// Token: 0x04000F37 RID: 3895
		private int m_gksavetype;

		// Token: 0x04000F38 RID: 3896
		private int m_faceposercode;

		// Token: 0x04000F39 RID: 3897
		private int m_isretiring;

		// Token: 0x04000F3A RID: 3898
		private int m_socklengthcode;

		// Token: 0x04000F3B RID: 3899
		private bool m_hashighqualityhead;

		// Token: 0x04000F3C RID: 3900
		private int m_attackingworkrate;

		// Token: 0x04000F3D RID: 3901
		private int m_defensiveworkrate;

		// Token: 0x04000F3E RID: 3902
		private bool m_shortstyle;

		// Token: 0x04000F3F RID: 3903
		private int m_interceptions;

		// Token: 0x04000F40 RID: 3904
		private bool m_jerseyfit;

		// Token: 0x04000F41 RID: 3905
		private int m_preferredNumber;

		// Token: 0x04000F42 RID: 3906
		private int m_teamidloanedfrom;

		// Token: 0x04000F43 RID: 3907
		private Team m_TeamLoanedFrom;

		// Token: 0x04000F44 RID: 3908
		private int m_previousteamid;

		// Token: 0x04000F45 RID: 3909
		private Team m_PreviousTeam;

		// Token: 0x04000F46 RID: 3910
		private bool m_IsLoaned;

		// Token: 0x04000F47 RID: 3911
		private DateTime m_loandateend;

		// Token: 0x04000F48 RID: 3912
		private static float[] c_MarketValuesGoalkeeper = new float[]
		{
			0.01f, 0.02f, 0.03f, 0.04f, 0.05f, 0.06f, 0.07f, 0.075f, 0.08f, 0.09f,
			0.1f, 0.15f, 0.2f, 0.25f, 0.3f, 0.35f, 0.4f, 0.45f, 0.5f, 0.75f,
			1f, 1.25f, 1.5f, 2f, 2.75f, 3.5f, 4.25f, 5f, 5.5f, 6f,
			7f, 8f, 10f, 14f, 18f, 20f, 22f, 24f, 32f, 40f
		};

		// Token: 0x04000F49 RID: 3913
		private static float[] c_MarketValuesDefender = new float[]
		{
			0.01f, 0.02f, 0.025f, 0.03f, 0.04f, 0.05f, 0.06f, 0.075f, 0.085f, 0.1f,
			0.125f, 0.15f, 0.2f, 0.25f, 0.33f, 0.41f, 0.5f, 0.625f, 0.75f, 0.825f,
			1f, 1.5f, 2f, 2.7f, 3.4f, 4f, 5f, 6f, 7f, 8f,
			10f, 14f, 20f, 24f, 28f, 32f, 36f, 40f, 50f, 60f
		};

		// Token: 0x04000F4A RID: 3914
		private static float[] c_MarketValuesMidfielder = new float[]
		{
			0.01f, 0.02f, 0.025f, 0.03f, 0.04f, 0.05f, 0.06f, 0.075f, 0.085f, 0.1f,
			0.075f, 0.1f, 0.15f, 0.25f, 0.35f, 0.5f, 0.65f, 0.825f, 1f, 1.25f,
			1.5f, 2f, 3f, 4f, 5f, 6f, 8f, 10f, 15f, 8f,
			20f, 25f, 30f, 33f, 37f, 50f, 60f, 65f, 75f, 90f
		};

		// Token: 0x04000F4B RID: 3915
		private static float[] c_MarketValuesAttacker = new float[]
		{
			0.01f, 0.02f, 0.025f, 0.03f, 0.04f, 0.05f, 0.06f, 0.07f, 0.08f, 0.09f,
			0.1f, 0.125f, 0.15f, 0.2f, 0.25f, 0.35f, 0.5f, 0.75f, 1f, 1.25f,
			1.5f, 2f, 2.75f, 3.5f, 4f, 6f, 8f, 10f, 12f, 15f,
			20f, 25f, 30f, 35f, 40f, 50f, 65f, 80f, 90f, 99f
		};

		// Token: 0x04000F4C RID: 3916
		private static int[] s_MeanLevels = new int[] { 52, 59, 66, 72, 77, 82, 88 };
	}
}
