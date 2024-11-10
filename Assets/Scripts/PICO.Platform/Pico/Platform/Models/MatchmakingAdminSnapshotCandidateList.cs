using System;

namespace Pico.Platform.Models
{
	public class MatchmakingAdminSnapshotCandidateList : MessageArray<MatchmakingAdminSnapshotCandidate>
	{
		public readonly ulong TotalCount;

		public MatchmakingAdminSnapshotCandidateList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
