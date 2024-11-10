using System;
using System.Collections.Generic;

namespace Pico.Platform.Models
{
	public class Room
	{
		public readonly Dictionary<string, string> DataStore;

		public readonly string Description;

		public readonly ulong RoomId;

		public readonly bool IsMembershipLocked;

		public readonly RoomJoinPolicy RoomJoinPolicy;

		public readonly RoomJoinability RoomJoinability;

		public readonly uint MaxUsers;

		public readonly User OwnerOptional;

		public readonly RoomType RoomType;

		public readonly UserList UsersOptional;

		public readonly string Name;

		public readonly uint PlayerNumber;

		public Room(IntPtr o)
		{
		}
	}
}
