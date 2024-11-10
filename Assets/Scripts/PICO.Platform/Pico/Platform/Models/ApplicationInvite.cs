using System;

namespace Pico.Platform.Models
{
	public class ApplicationInvite
	{
		public readonly Destination Destination;

		public readonly User Recipient;

		public readonly ulong ID;

		public readonly bool IsActive;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public ApplicationInvite(IntPtr o)
		{
		}
	}
}
