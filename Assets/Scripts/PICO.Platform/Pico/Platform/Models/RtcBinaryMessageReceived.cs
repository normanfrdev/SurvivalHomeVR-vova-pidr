using System;

namespace Pico.Platform.Models
{
	public class RtcBinaryMessageReceived
	{
		public readonly string UserId;

		public readonly byte[] Data;

		public readonly string RoomId;

		public RtcBinaryMessageReceived(IntPtr o)
		{
		}
	}
}
