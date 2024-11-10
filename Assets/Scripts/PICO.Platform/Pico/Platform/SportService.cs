using System;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class SportService
	{
		public static Task<SportUserInfo> GetUserInfo()
		{
			return null;
		}

		public static Task<SportDailySummaryList> GetDailySummary(DateTime beginTime, DateTime endTime)
		{
			return null;
		}

		public static Task<SportSummary> GetSummary(DateTime beginTime, DateTime endTime)
		{
			return null;
		}
	}
}
