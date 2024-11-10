using System;

namespace Pico.Platform.Models
{
	public class RtcRoomStats
	{
		public readonly int TotalDuration;

		public readonly int UserCount;

		public readonly string RoomId;

		public RtcRoomStats(IntPtr o)
		{
		}
	}
}
