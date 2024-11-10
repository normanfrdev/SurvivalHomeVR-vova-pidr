using System;

namespace Pico.Platform.Models
{
	public class AchievementProgressList : MessageArray<AchievementProgress>
	{
		public readonly ulong TotalSize;

		public AchievementProgressList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
