using System;

namespace Pico.Platform.Models
{
	public class UserRoomList : MessageArray<UserRoom>
	{
		public UserRoomList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
