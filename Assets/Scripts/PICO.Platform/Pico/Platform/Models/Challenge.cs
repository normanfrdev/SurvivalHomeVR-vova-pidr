using System;

namespace Pico.Platform.Models
{
	public class Challenge
	{
		public readonly ChallengeCreationType CreationType;

		public readonly ulong ID;

		public readonly DateTime StartDate;

		public readonly DateTime EndDate;

		public readonly UserList ParticipantsOptional;

		public readonly UserList InvitedUsersOptional;

		public readonly Leaderboard Leaderboard;

		public readonly string Title;

		public readonly ChallengeVisibility Visibility;

		public Challenge(IntPtr o)
		{
		}
	}
}
