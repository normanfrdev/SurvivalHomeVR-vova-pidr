using System;

namespace Pico.Platform.Models
{
	public class Product
	{
		public readonly string Description;

		public readonly string DetailDescription;

		public readonly string Price;

		public readonly string Currency;

		public readonly string Name;

		public readonly string SKU;

		public readonly string Icon;

		public readonly AddonsType AddonsType;

		public readonly PeriodType PeriodType;

		public readonly PeriodType TrialPeriodUnit;

		public readonly int TrialPeriodValue;

		public readonly string OriginalPrice;

		public readonly string OuterId;

		public readonly bool IsContinuous;

		public Product(IntPtr o)
		{
		}
	}
}
