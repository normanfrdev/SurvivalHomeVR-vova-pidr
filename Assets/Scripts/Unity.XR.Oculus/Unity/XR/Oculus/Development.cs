namespace Unity.XR.Oculus
{
	public static class Development
	{
		private enum UserDeveloperModeSettingCache
		{
			NoUserSettingCached = 0,
			UserSettingFalse = 1,
			UserSettingTrue = 2
		}

		private static UserDeveloperModeSettingCache s_CachedMode;

		public static void TrySetDeveloperMode(bool active)
		{
		}

		internal static void OverrideDeveloperModeStart()
		{
		}

		internal static void OverrideDeveloperModeStop()
		{
		}
	}
}
