using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class AchievementsService
	{
		public static Task<AchievementUpdate> AddCount(string name, long count, byte[] extraData)
		{
			return null;
		}

		public static Task<AchievementUpdate> AddFields(string name, string fields, byte[] extraData)
		{
			return null;
		}

		public static Task<AchievementDefinitionList> GetAllDefinitions(int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<AchievementProgressList> GetAllProgress(int pageIdx, int pageSize)
		{
			return null;
		}

		public static Task<AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			return null;
		}

		public static Task<AchievementProgressList> GetProgressByName(string[] names)
		{
			return null;
		}

		public static Task<AchievementUpdate> Unlock(string name, byte[] extraData)
		{
			return null;
		}
	}
}
