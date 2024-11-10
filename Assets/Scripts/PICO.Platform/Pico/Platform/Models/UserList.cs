using System;

namespace Pico.Platform.Models
{
	public class UserList : MessageArray<User>
	{
		public UserList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
