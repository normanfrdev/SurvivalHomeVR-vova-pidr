using System;

namespace Pico.Platform.Models
{
	public class SportSummary
	{
		public readonly int DurationInSeconds;

		public readonly double Calorie;

		public readonly DateTime StartTime;

		public readonly DateTime EndTime;

		public SportSummary(IntPtr o)
		{
		}
	}
}
