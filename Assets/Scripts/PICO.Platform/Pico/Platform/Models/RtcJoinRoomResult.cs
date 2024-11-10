using System;

namespace Pico.Platform.Models
{
	public class RtcJoinRoomResult
	{
		public readonly string RoomId;

		public readonly string UserId;

		public readonly int ErrorCode;

		public readonly int Elapsed;

		public readonly RtcJoinRoomType JoinType;

		public RtcJoinRoomResult(IntPtr o)
		{
		}
	}
}
