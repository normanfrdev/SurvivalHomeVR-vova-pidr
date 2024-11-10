using System;

namespace Pico.Platform.Models
{
	public class RtcRoomMessageReceived
	{
		public readonly string UserId;

		public readonly string Message;

		public readonly string RoomId;

		public RtcRoomMessageReceived(IntPtr o)
		{
		}
	}
}
