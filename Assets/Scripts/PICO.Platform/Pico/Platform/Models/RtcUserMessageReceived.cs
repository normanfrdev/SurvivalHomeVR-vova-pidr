using System;

namespace Pico.Platform.Models
{
	public class RtcUserMessageReceived
	{
		public readonly string UserId;

		public readonly string Message;

		public readonly string RoomId;

		public RtcUserMessageReceived(IntPtr o)
		{
		}
	}
}
