using System;

namespace Pico.Platform.Models
{
	public class Purchase
	{
		public readonly DateTime ExpirationTime;

		public readonly DateTime GrantTime;

		public readonly string ID;

		public readonly string SKU;

		public readonly string Icon;

		public readonly AddonsType AddonsType;

		public readonly string OuterId;

		public readonly PeriodType CurrentPeriodType;

		public readonly PeriodType NextPeriodType;

		public readonly DateTime NextPayTime;

		public readonly DiscountType DiscountType;

		public readonly string OrderComment;

		public Purchase(IntPtr o)
		{
		}
	}
}
