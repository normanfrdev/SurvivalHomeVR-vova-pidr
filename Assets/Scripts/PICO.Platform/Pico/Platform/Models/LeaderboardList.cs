using System;

namespace Pico.Platform.Models
{
	public class LeaderboardList : MessageArray<Leaderboard>
	{
		public readonly ulong TotalCount;

		public LeaderboardList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
