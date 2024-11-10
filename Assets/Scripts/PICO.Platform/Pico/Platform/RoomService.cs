using System.Collections.Generic;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class RoomService
	{
		public static RoomOptions GetCreatePrivateRoomOptions(Dictionary<string, string> dataStore)
		{
			return null;
		}

		public static RoomOptions GetJoinOrCreateNamedRoomOptions(Dictionary<string, string> dataStore, string name, string password)
		{
			return null;
		}

		public static Task<RoomList> GetNamedRooms(int pageIndex, int pageSize)
		{
			return null;
		}

		public static Task<Room> JoinOrCreateNamedRoom(RoomJoinPolicy joinPolicy, bool createIfNotExist, uint maxUsers, RoomOptions options)
		{
			return null;
		}

		public static Task LaunchInvitableUserFlow(ulong roomID)
		{
			return null;
		}

		public static Task<Room> UpdateDataStore(ulong roomId, Dictionary<string, string> data)
		{
			return null;
		}

		public static Task<Room> CreateAndJoinPrivate2(RoomJoinPolicy policy, uint maxUsers, RoomOptions roomOptions)
		{
			return null;
		}

		public static Task<Room> Get(ulong roomId)
		{
			return null;
		}

		public static Task<Room> GetCurrent()
		{
			return null;
		}

		public static Task<Room> GetCurrentForUser(string userId)
		{
			return null;
		}

		public static Task<UserList> GetInvitableUsers2(RoomOptions roomOptions = null)
		{
			return null;
		}

		public static Task<RoomList> GetModeratedRooms(int index, int size)
		{
			return null;
		}

		public static Task<Room> InviteUser(ulong roomId, string token)
		{
			return null;
		}

		public static Task<Room> Join2(ulong roomId, RoomOptions options)
		{
			return null;
		}

		public static Task<Room> KickUser(ulong roomId, string userId, int kickDuration)
		{
			return null;
		}

		public static Task<Room> Leave(ulong roomId)
		{
			return null;
		}

		public static Task<Room> SetDescription(ulong roomId, string description)
		{
			return null;
		}

		public static Task<Room> UpdateMembershipLockStatus(ulong roomId, RoomMembershipLockStatus membershipLockStatus)
		{
			return null;
		}

		public static Task UpdateOwner(ulong roomId, string userId)
		{
			return null;
		}

		public static Task<Room> UpdatePrivateRoomJoinPolicy(ulong roomId, RoomJoinPolicy policy)
		{
			return null;
		}

		public static void SetRoomInviteAcceptedNotificationCallback(Message<string>.Handler handler)
		{
		}

		public static void SetUpdateNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetKickUserNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetSetDescriptionNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetUpdateDataStoreNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetLeaveNotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetJoin2NotificationCallback(Message<Room>.Handler handler)
		{
		}

		public static void SetUpdateOwnerNotificationCallback(Message.Handler handler)
		{
		}

		public static void SetUpdateMembershipLockStatusNotificationCallback(Message<Room>.Handler handler)
		{
		}
	}
}
