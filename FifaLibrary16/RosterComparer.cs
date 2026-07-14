using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000083 RID: 131
	public class RosterComparer : IComparer
	{
		// Token: 0x06000CB4 RID: 3252 RVA: 0x000461DC File Offset: 0x000443DC
		int IComparer.Compare(object x, object y)
		{
			TeamPlayer teamPlayer = (TeamPlayer)x;
			TeamPlayer teamPlayer2 = (TeamPlayer)y;
			if (teamPlayer.position != teamPlayer2.position)
			{
				return teamPlayer.position - teamPlayer2.position;
			}
			return teamPlayer.Player.preferredposition1 - teamPlayer2.Player.preferredposition1;
		}
	}
}
