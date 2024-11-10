namespace Unity.XR.PXR
{
	public class PLog
	{
		public enum LogLevel
		{
			LogFatal = 1,
			LogError = 2,
			LogWarn = 3,
			LogInfo = 4,
			LogDebug = 5,
			LogVerbose = 6
		}

		public static LogLevel logLevel;

		public static void v(string tag, string message)
		{
		}

		public static void d(string tag, string message)
		{
		}

		public static void i(string tag, string message)
		{
		}

		public static void w(string tag, string message)
		{
		}

		public static void e(string tag, string message)
		{
		}

		public static void f(string tag, string message)
		{
		}
	}
}
