using System;

namespace Pico.Platform.Models
{
	public class AchievementDefinitionList : MessageArray<AchievementDefinition>
	{
		public readonly ulong TotalSize;

		public AchievementDefinitionList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
