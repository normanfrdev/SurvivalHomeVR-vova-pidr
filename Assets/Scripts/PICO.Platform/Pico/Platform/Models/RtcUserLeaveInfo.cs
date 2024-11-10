using System;

namespace Pico.Platform.Models
{
	public class RtcUserLeaveInfo
	{
		public readonly string UserId;

		public readonly RtcUserLeaveReasonType OfflineReason;

		public readonly string RoomId;

		public RtcUserLeaveInfo(IntPtr o)
		{
		}
	}
}
