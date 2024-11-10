using System;

namespace Pico.Platform.Models
{
	public class MatchmakingRoom
	{
		public readonly Room Room;

		public readonly uint PingTime;

		public readonly bool HasPingTime;

		public MatchmakingRoom(IntPtr o)
		{
		}
	}
}
