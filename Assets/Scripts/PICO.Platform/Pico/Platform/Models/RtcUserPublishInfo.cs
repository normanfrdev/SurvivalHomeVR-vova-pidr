using System;

namespace Pico.Platform.Models
{
	public class RtcUserPublishInfo
	{
		public readonly string UserId;

		public readonly RtcMediaStreamType MediaStreamType;

		public readonly string RoomId;

		public RtcUserPublishInfo(IntPtr o)
		{
		}
	}
}
