using System;

namespace Pico.Platform.Models
{
	public class SubscriptionStatus
	{
		public readonly string SKU;

		public readonly string OuterId;

		public readonly DateTime StartTime;

		public readonly DateTime EndTime;

		public readonly PeriodType PeriodType;

		public readonly EntitlementStatus EntitlementStatus;

		public readonly CancelReason CancelReason;

		public readonly bool IsFreeTrial;

		public readonly int NextPeriod;

		public SubscriptionStatus(IntPtr o)
		{
		}
	}
}
