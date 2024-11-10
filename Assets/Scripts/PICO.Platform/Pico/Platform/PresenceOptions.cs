using System;

namespace Pico.Platform
{
	public class PresenceOptions
	{
		private IntPtr Handle;

		public void SetDestinationApiName(string value)
		{
		}

		public void SetIsJoinable(bool value)
		{
		}

		public void SetLobbySessionId(string value)
		{
		}

		public void SetMatchSessionId(string value)
		{
		}

		public void SetExtra(string value)
		{
		}

		public static explicit operator IntPtr(PresenceOptions options)
		{
			return (IntPtr)0;
		}

		~PresenceOptions()
		{
		}
	}
}
