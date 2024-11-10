using System;

namespace Pico.Platform.Models
{
	public class RoomInviteNotification
	{
		public readonly ulong ID;

		public readonly ulong RoomID;

		public readonly string SenderID;

		public readonly DateTime SentTime;

		public RoomInviteNotification(IntPtr o)
		{
		}
	}
}
