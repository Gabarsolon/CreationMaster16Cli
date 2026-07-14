using System;
using Microsoft.Win32;

namespace FifaLibrary
{
	// Token: 0x02000070 RID: 112
	public class RegistryInfo
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x00039498 File Offset: 0x00037698
		private static string GetString(string year, string key)
		{
			string text = null;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(year);
			if (registryKey != null)
			{
				text = (string)registryKey.GetValue(key);
				if (text.EndsWith("\\"))
				{
					text = text.Substring(0, text.Length - 1);
				}
				registryKey.Close();
			}
			return text;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000394E8 File Offset: 0x000376E8
		public static string GetLatestFifaInstalled()
		{
			for (int i = 20; i >= 10; i--)
			{
				string text = "SOFTWARE\\EA SPORTS\\FIFA " + i.ToString();
				if (RegistryInfo.GetString(text, "Install Dir") != null)
				{
					return text;
				}
				text = "SOFTWARE\\Wow6432Node\\EA SPORTS\\FIFA " + i.ToString();
				if (RegistryInfo.GetString(text, "Install Dir") != null)
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00039548 File Offset: 0x00037748
		public static string[] GetAllFifaInstalled()
		{
			int num = 0;
			string[] subKeyNames = Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA SPORTS").GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (!subKeyNames[i].StartsWith("FIFA"))
				{
					subKeyNames[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			string[] array = new string[num];
			num = 0;
			for (int j = 0; j < subKeyNames.Length; j++)
			{
				if (subKeyNames[j] != null)
				{
					array[num++] = subKeyNames[j];
				}
			}
			return array;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000395C5 File Offset: 0x000377C5
		public static string GetFifaKey(int year)
		{
			return "SOFTWARE\\EA SPORTS\\FIFA " + year.ToString();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000395D8 File Offset: 0x000377D8
		public static bool IsFifaInstalled(string game)
		{
			return RegistryInfo.GetString(game, "Install Dir") != null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000395E8 File Offset: 0x000377E8
		public static string GetInstallDir(string game)
		{
			string text = RegistryInfo.GetString(game, "Install Dir");
			if (text != null && text.EndsWith("\\"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00039624 File Offset: 0x00037824
		public static string GetFolder(string game)
		{
			return RegistryInfo.GetString(game, "Folder");
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00039631 File Offset: 0x00037831
		public static string GetLocale(string game)
		{
			return RegistryInfo.GetString(game, "Locale");
		}
	}
}
