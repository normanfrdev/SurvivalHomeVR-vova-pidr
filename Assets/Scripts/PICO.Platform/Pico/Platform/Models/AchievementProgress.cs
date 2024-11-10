using System;

namespace Pico.Platform.Models
{
	public class AchievementProgress
	{
		public readonly ulong ID;

		public readonly string Bitfield;

		public readonly long Count;

		public readonly bool IsUnlocked;

		public readonly string Name;

		public readonly DateTime UnlockTime;

		public readonly byte[] ExtraData;

		public AchievementProgress(IntPtr o)
		{
		}
	}
}
