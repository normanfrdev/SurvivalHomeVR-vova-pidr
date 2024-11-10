using System;

namespace Pico.Platform.Models
{
	public class PresenceJoinIntent
	{
		public readonly string DeeplinkMessage;

		public readonly string DestinationApiName;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public readonly string Extra;

		public PresenceJoinIntent(IntPtr o)
		{
		}
	}
}
