using System;

namespace Pico.Platform.Models
{
	public class LaunchDetails
	{
		public readonly LaunchType LaunchType;

		public readonly string DeeplinkMessage;

		public readonly string DestinationApiName;

		public readonly string LobbySessionID;

		public readonly string MatchSessionID;

		public readonly string Extra;

		public readonly ulong RoomID;

		public readonly ulong ChallengeID;

		public readonly string TrackingID;

		public LaunchDetails(IntPtr o)
		{
		}
	}
}
