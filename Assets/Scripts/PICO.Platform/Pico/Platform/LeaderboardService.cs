using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class LeaderboardService
	{
		public static Task<LeaderboardList> Get(string leaderboardName)
		{
			return null;
		}

		public static Task<LeaderboardEntryList> GetEntries(string leaderboardName, int pageSize, int pageIdx, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return null;
		}

		public static Task<LeaderboardEntryList> GetEntriesAfterRank(string leaderboardName, int pageSize, int pageIdx, ulong afterRank)
		{
			return null;
		}

		public static Task<LeaderboardEntryList> GetEntriesByIds(string leaderboardName, int pageSize, int pageIdx, LeaderboardStartAt startAt, string[] userIDs)
		{
			return null;
		}

		public static Task<bool> WriteEntry(string leaderboardName, long score, byte[] extraData = null, bool forceUpdate = false)
		{
			return null;
		}

		public static Task<bool> WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, byte[] extraData = null, bool forceUpdate = false)
		{
			return null;
		}
	}
}
