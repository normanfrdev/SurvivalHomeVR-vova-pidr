using System;

namespace Pico.Platform
{
	public class InviteOptions
	{
		private IntPtr Handle;

		public void AddSuggestedUser(string ele)
		{
		}

		public void ClearSuggestedUsers()
		{
		}

		public static explicit operator IntPtr(InviteOptions options)
		{
			return (IntPtr)0;
		}

		~InviteOptions()
		{
		}
	}
}
