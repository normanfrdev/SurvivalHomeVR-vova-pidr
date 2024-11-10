using System;

namespace Pico.Platform.Models
{
	public class SportUserInfo
	{
		public readonly Gender Gender;

		public readonly DateTime Birthday;

		public readonly int Stature;

		public readonly int Weight;

		public readonly int SportLevel;

		public readonly int DailyDurationInMinutes;

		public readonly int DaysPerWeek;

		public readonly SportTarget SportTarget;

		public SportUserInfo(IntPtr o)
		{
		}
	}
}
