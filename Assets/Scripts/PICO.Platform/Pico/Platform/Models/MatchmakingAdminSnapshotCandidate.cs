using System;

namespace Pico.Platform.Models
{
	public class MatchmakingAdminSnapshotCandidate
	{
		public readonly bool CanMatch;

		public readonly double MyTotalScore;

		public readonly double TheirCurrentThreshold;

		public MatchmakingAdminSnapshotCandidate(IntPtr o)
		{
		}
	}
}
