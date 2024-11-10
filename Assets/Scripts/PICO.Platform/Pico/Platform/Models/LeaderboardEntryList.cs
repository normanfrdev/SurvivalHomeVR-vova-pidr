using System;

namespace Pico.Platform.Models
{
	public class LeaderboardEntryList : MessageArray<LeaderboardEntry>
	{
		public readonly ulong TotalCount;

		public LeaderboardEntryList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
