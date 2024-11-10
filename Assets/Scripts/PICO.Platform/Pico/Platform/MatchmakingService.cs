using System.Collections.Generic;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class MatchmakingService
	{
		public static Task ReportResultsInsecure(ulong roomId, Dictionary<string, int> data)
		{
			return null;
		}

		public static Task<MatchmakingStats> GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach = MatchmakingStatApproach.Trailing)
		{
			return null;
		}

		public static Task<MatchmakingBrowseResult> Browse2(string pool, MatchmakingOptions matchmakingOptions = null)
		{
			return null;
		}

		public static Task<MatchmakingBrowseResult> Browse2ForCustomPage(string pool, MatchmakingOptions matchmakingOptions = null, int pageIndex = 0, int pageSize = 5)
		{
			return null;
		}

		public static Task Cancel()
		{
			return null;
		}

		public static Task<MatchmakingEnqueueResultAndRoom> CreateAndEnqueueRoom2(string pool, MatchmakingOptions matchmakingOptions = null)
		{
			return null;
		}

		public static Task<MatchmakingEnqueueResult> Enqueue2(string pool, MatchmakingOptions matchmakingOptions = null)
		{
			return null;
		}

		public static Task<MatchmakingAdminSnapshot> GetAdminSnapshot()
		{
			return null;
		}

		public static Task StartMatch(ulong roomId)
		{
			return null;
		}

		public static void SetMatchFoundNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetCancel2NotificationCallback(Message.Handler handler)
		{
		}
	}
}
