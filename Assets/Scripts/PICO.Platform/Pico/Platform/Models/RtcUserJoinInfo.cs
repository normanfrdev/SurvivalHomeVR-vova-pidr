using System;

namespace Pico.Platform.Models
{
	public class RtcUserJoinInfo
	{
		public readonly string UserId;

		public readonly string UserExtra;

		public readonly int Elapsed;

		public readonly string RoomId;

		public RtcUserJoinInfo(IntPtr o)
		{
		}
	}
}
