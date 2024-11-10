using System;

namespace Pico.Platform
{
	public class RtcRoomOptions
	{
		public string RoomId;

		private IntPtr Handle;

		public void SetRoomProfileType(RtcRoomProfileType value)
		{
		}

		public void SetIsAutoSubscribeAudio(bool value)
		{
		}

		public void SetRoomId(string value)
		{
		}

		public void SetUserId(string value)
		{
		}

		public void SetUserExtra(string value)
		{
		}

		public void SetToken(string value)
		{
		}

		public static explicit operator IntPtr(RtcRoomOptions options)
		{
			return (IntPtr)0;
		}

		~RtcRoomOptions()
		{
		}
	}
}
