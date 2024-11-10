using System;

namespace Pico.Platform.Models
{
	public class Leaderboard
	{
		public readonly string ApiName;

		public readonly ulong ID;

		public readonly Destination DestinationOptional;

		public Leaderboard(IntPtr o)
		{
		}
	}
}
