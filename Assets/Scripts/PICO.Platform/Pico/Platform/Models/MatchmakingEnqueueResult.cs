using System;

namespace Pico.Platform.Models
{
	public class MatchmakingEnqueueResult
	{
		public readonly MatchmakingAdminSnapshot AdminSnapshotOptional;

		public readonly uint AverageWait;

		public readonly uint MatchesInLastHourCount;

		public readonly uint MaxExpectedWait;

		public readonly string Pool;

		public readonly uint RecentMatchPercentage;

		public MatchmakingEnqueueResult(IntPtr o)
		{
		}
	}
}
