using System;

namespace Pico.Platform.Models
{
	public class LeaderboardEntry
	{
		public readonly string DisplayScore;

		public readonly byte[] ExtraData;

		public readonly ulong ID;

		public readonly int Rank;

		public readonly long Score;

		public readonly SupplementaryMetric SupplementaryMetricOptional;

		public readonly DateTime Timestamp;

		public readonly User User;

		public LeaderboardEntry(IntPtr o)
		{
		}
	}
}
