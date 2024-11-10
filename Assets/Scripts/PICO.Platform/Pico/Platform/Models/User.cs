using System;

namespace Pico.Platform.Models
{
	public class User
	{
		public readonly string DisplayName;

		public readonly string ImageUrl;

		public readonly string SmallImageUrl;

		public readonly string ID;

		public readonly UserPresenceStatus PresenceStatus;

		public readonly Gender Gender;

		public readonly string Presence;

		public readonly string PresenceDeeplinkMessage;

		public readonly string PresenceDestinationApiName;

		public readonly string PresenceLobbySessionId;

		public readonly string PresenceMatchSessionId;

		public readonly string PresenceExtra;

		public readonly bool PresenceIsJoinable;

		public readonly string InviteToken;

		public readonly string StoreRegion;

		public User(IntPtr obj)
		{
		}
	}
}
