using System;

namespace Pico.Platform
{
	public class TimeUtil
	{
		public static DateTime UnixEpoch;

		public static int GetUtcSeconds()
		{
			return 0;
		}

		public static long GetUtcMilliSeconds()
		{
			return 0L;
		}

		public static int DateTimeToSeconds(DateTime t)
		{
			return 0;
		}

		public static long DateTimeToMilliSeconds(DateTime t)
		{
			return 0L;
		}

		public static DateTime MilliSecondsToDateTime(long milliSeconds)
		{
			return default(DateTime);
		}

		public static DateTime SecondsToDateTime(long seconds)
		{
			return default(DateTime);
		}
	}
}
