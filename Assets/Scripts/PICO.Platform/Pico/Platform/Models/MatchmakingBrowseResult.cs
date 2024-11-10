using System;

namespace Pico.Platform.Models
{
	public class MatchmakingBrowseResult
	{
		public readonly MatchmakingEnqueueResult EnqueueResult;

		public readonly MatchmakingRoomList MatchmakingRooms;

		public MatchmakingBrowseResult(IntPtr o)
		{
		}
	}
}
