using System;

namespace Pico.Platform.Models
{
	public class RtcRemoteStreamKey
	{
		public readonly string RoomId;

		public readonly string UserId;

		public readonly RtcStreamIndex RtcStreamIndex;

		public RtcRemoteStreamKey(IntPtr o)
		{
		}
	}
}
