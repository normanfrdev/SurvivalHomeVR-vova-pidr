using System;

namespace Pico.Platform.Models
{
	public class RtcUserUnPublishInfo
	{
		public readonly string UserId;

		public readonly RtcMediaStreamType MediaStreamType;

		public readonly RtcStreamRemoveReason Reason;

		public readonly string RoomId;

		public RtcUserUnPublishInfo(IntPtr o)
		{
		}
	}
}
