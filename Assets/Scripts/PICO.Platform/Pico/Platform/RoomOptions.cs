using System;

namespace Pico.Platform
{
	public class RoomOptions
	{
		private IntPtr Handle;

		public void SetDataStore(string key, string value)
		{
		}

		public void ClearDataStore()
		{
		}

		public void SetExcludeRecentlyMet(bool value)
		{
		}

		public void SetMaxUserResults(uint value)
		{
		}

		public void SetRoomId(ulong value)
		{
		}

		public void SetRoomName(string roomName)
		{
		}

		public void SetPassword(string password)
		{
		}

		public void SetTurnOffUpdates(bool value)
		{
		}

		public static explicit operator IntPtr(RoomOptions roomOptions)
		{
			return (IntPtr)0;
		}

		~RoomOptions()
		{
		}

		public IntPtr GetHandle()
		{
			return (IntPtr)0;
		}
	}
}
