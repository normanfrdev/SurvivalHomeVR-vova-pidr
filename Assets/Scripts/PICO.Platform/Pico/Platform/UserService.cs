using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class UserService
	{
		public static Task<string> GetAccessToken()
		{
			return null;
		}

		public static Task<OrgScopedID> GetOrgScopedID(string userID)
		{
			return null;
		}

		public static Task<User> GetLoggedInUser()
		{
			return null;
		}

		public static Task<User> Get(string userId)
		{
			return null;
		}

		public static Task<UserList> GetFriends()
		{
			return null;
		}

		public static Task<UserRelationResult> GetUserRelations(string[] userIds)
		{
			return null;
		}

		public static Task<LaunchFriendResult> LaunchFriendRequestFlow(string userId)
		{
			return null;
		}

		public static Task<UserRoomList> GetFriendsAndRooms()
		{
			return null;
		}

		public static Task<UserRoomList> GetNextUserAndRoomListPage(UserRoomList list)
		{
			return null;
		}

		public static Task<UserList> GetNextUserListPage(UserList list)
		{
			return null;
		}

		public static Task<PermissionResult> GetAuthorizedPermissions()
		{
			return null;
		}

		public static Task<PermissionResult> RequestUserPermissions(params string[] permissionList)
		{
			return null;
		}

		public static Task<EntitlementCheckResult> EntitlementCheck(bool killApp = true)
		{
			return null;
		}

		public static Task<string> GetIdToken()
		{
			return null;
		}
	}
}
