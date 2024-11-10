using System;

namespace Pico.Platform.Models
{
	public class ChallengeOptions
	{
		private IntPtr Handle;

		public void SetEndDate(DateTime value)
		{
		}

		public void SetIncludeActiveChallenges(bool value)
		{
		}

		public void SetIncludeFutureChallenges(bool value)
		{
		}

		public void SetIncludePastChallenges(bool value)
		{
		}

		public void SetLeaderboardName(string value)
		{
		}

		public void SetStartDate(DateTime value)
		{
		}

		public void SetTitle(string value)
		{
		}

		public void SetViewerFilter(ChallengeViewerFilter value)
		{
		}

		public void SetVisibility(ChallengeVisibility value)
		{
		}

		public static explicit operator IntPtr(ChallengeOptions options)
		{
			return (IntPtr)0;
		}

		~ChallengeOptions()
		{
		}

		public IntPtr GetHandle()
		{
			return (IntPtr)0;
		}
	}
}
