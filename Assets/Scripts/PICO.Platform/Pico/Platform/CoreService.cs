namespace Pico.Platform
{
	public static class CoreService
	{
		public static bool Initialized;

		public static string NotInitializedError;

		public static bool IsInitialized()
		{
			return false;
		}

		public static string GetAppID(string appId = null)
		{
			return null;
		}

		public static Task<PlatformInitializeResult> AsyncInitialize(string appId = null)
		{
			return null;
		}

		public static void Initialize(string appId = null)
		{
		}

		public static Task<GameInitializeResult> GameInitialize(string accessToken)
		{
			return null;
		}

		public static Task<GameInitializeResult> GameInitialize()
		{
			return null;
		}

		public static bool GameUninitialize()
		{
			return false;
		}
	}
}
