using System;

namespace Pico.Platform
{
	public class RtcGetTokenOptions
	{
		private IntPtr Handle;

		public void SetUserId(string value)
		{
		}

		public void SetRoomId(string value)
		{
		}

		public void SetTtl(int value)
		{
		}

		public void SetPrivileges(RtcPrivilege key, int value)
		{
		}

		public void ClearPrivileges()
		{
		}

		public static explicit operator IntPtr(RtcGetTokenOptions options)
		{
			return (IntPtr)0;
		}

		~RtcGetTokenOptions()
		{
		}
	}
}
