using System;

namespace Pico.Platform
{
	public class MatchmakingOptions
	{
		private IntPtr Handle;

		public void SetCreateRoomDataStore(string key, string value)
		{
		}

		public void ClearCreateRoomDataStore()
		{
		}

		public void SetCreateRoomJoinPolicy(RoomJoinPolicy value)
		{
		}

		public void SetCreateRoomMaxUsers(uint value)
		{
		}

		public void SetEnqueueDataSettings(string key, int value)
		{
		}

		public void SetEnqueueDataSettings(string key, double value)
		{
		}

		public void SetEnqueueDataSettings(string key, string value)
		{
		}

		public void ClearEnqueueDataSettings()
		{
		}

		public void SetEnqueueIsDebug(bool value)
		{
		}

		public void SetEnqueueQueryKey(string value)
		{
		}

		public static explicit operator IntPtr(MatchmakingOptions matchmakingOptions)
		{
			return (IntPtr)0;
		}

		~MatchmakingOptions()
		{
		}

		public IntPtr GetHandle()
		{
			return (IntPtr)0;
		}
	}
}
