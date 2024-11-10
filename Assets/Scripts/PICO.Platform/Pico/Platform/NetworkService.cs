using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class NetworkService
	{
		public static Packet ReadPacket()
		{
			return null;
		}

		public static bool SendPacket(string userId, byte[] bytes)
		{
			return false;
		}

		public static bool SendPacket(string userId, byte[] bytes, bool reliable)
		{
			return false;
		}

		public static bool SendPacketToCurrentRoom(byte[] bytes)
		{
			return false;
		}

		public static bool SendPacketToCurrentRoom(byte[] bytes, bool reliable)
		{
			return false;
		}

		public static void SetPlatformGameInitializeAsynchronousCallback(Message<GameInitializeResult>.Handler handler)
		{
		}

		public static void SetNotification_Game_ConnectionEventCallback(Message<GameConnectionEvent>.Handler handler)
		{
		}

		public static void SetNotification_Game_Request_FailedCallback(Message<GameRequestFailedReason>.Handler handler)
		{
		}

		public static void SetNotification_Game_StateResetCallback(Message.Handler handler)
		{
		}
	}
}
