using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class ChallengesService
	{
		public static Task<Challenge> Invite(ulong challengeID, string[] userID)
		{
			return null;
		}

		public static Task<Challenge> Get(ulong challengeID)
		{
			return null;
		}

		public static Task<ChallengeEntryList> GetEntries(ulong challengeID, LeaderboardFilterType filter, LeaderboardStartAt startAt, int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<ChallengeEntryList> GetEntriesAfterRank(ulong challengeID, ulong afterRank, int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<ChallengeEntryList> GetEntriesByIds(ulong challengeID, LeaderboardStartAt startAt, string[] userIDs, int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<ChallengeList> GetList(ChallengeOptions challengeOptions, int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<Challenge> Join(ulong challengeID)
		{
			return null;
		}

		public static Task<Challenge> Leave(ulong challengeID)
		{
			return null;
		}

		public static Task LaunchInvitableUserFlow(ulong challengeID)
		{
			return null;
		}

		public static void SetChallengeInviteAcceptedOrLaunchAppNotificationCallback(Message<string>.Handler handler)
		{
		}
	}
}
