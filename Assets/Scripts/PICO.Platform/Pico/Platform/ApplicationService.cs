using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class ApplicationService
	{
		public static Task<string> LaunchApp(string packageName, ApplicationOptions options = null)
		{
			return null;
		}

		public static Task<string> LaunchAppByAppId(string appId, ApplicationOptions options = null)
		{
			return null;
		}

		public static Task<string> LaunchStore()
		{
			return null;
		}

		public static Task<ApplicationVersion> GetVersion()
		{
			return null;
		}

		public static LaunchDetails GetLaunchDetails()
		{
			return null;
		}

		public static SystemInfo GetSystemInfo()
		{
			return null;
		}

		public static void LogDeeplinkResult(string trackId, LaunchResult result)
		{
		}

		public static void SetLaunchIntentChangedCallback(Message<string>.Handler callback)
		{
		}
	}
}
