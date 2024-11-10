using System;

namespace Pico.Platform.Models
{
	public class AchievementDefinition
	{
		public readonly AchievementType Type;

		public readonly string Name;

		public readonly uint BitfieldLength;

		public readonly long Target;

		public readonly string Description;

		public readonly string Title;

		public readonly bool IsArchived;

		public readonly bool IsSecret;

		public readonly ulong ID;

		public readonly string UnlockedDescription;

		public readonly AchievementWritePolicy WritePolicy;

		public readonly string LockedImageURL;

		public readonly string UnlockedImageURL;

		public AchievementDefinition(IntPtr o)
		{
		}
	}
}
