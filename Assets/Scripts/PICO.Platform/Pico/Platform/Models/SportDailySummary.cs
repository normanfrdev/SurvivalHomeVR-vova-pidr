using System;

namespace Pico.Platform.Models
{
	public class SportDailySummary
	{
		public readonly long Id;

		public readonly DateTime Date;

		public readonly int DurationInSeconds;

		public readonly int PlanDurationInMinutes;

		public readonly double Calorie;

		public readonly double PlanCalorie;

		public SportDailySummary(IntPtr o)
		{
		}
	}
}
