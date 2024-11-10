using System;

namespace Pico.Platform.Models
{
	public class RoomInviteNotificationList : MessageArray<RoomInviteNotification>
	{
		public readonly int TotalCount;

		public RoomInviteNotificationList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
