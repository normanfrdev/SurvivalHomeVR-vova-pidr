using System;

namespace Pico.Platform.Models
{
	public class MatchmakingRoomList : MessageArray<MatchmakingRoom>
	{
		public readonly int TotalCount;

		public MatchmakingRoomList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
