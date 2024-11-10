using System;

namespace Pico.Platform.Models
{
	public class MatchmakingAdminSnapshot
	{
		public readonly MatchmakingAdminSnapshotCandidateList CandidateList;

		public readonly double MyCurrentThreshold;

		public MatchmakingAdminSnapshot(IntPtr o)
		{
		}
	}
}
