using System;

namespace Pico.Platform.Models
{
	public class RtcMessageSendResult
	{
		public readonly long MessageId;

		public readonly int Error;

		public readonly string RoomId;

		public RtcMessageSendResult(IntPtr o)
		{
		}
	}
}
