using System;

namespace Pico.Platform.Models
{
	public class EntitlementCheckResult
	{
		public readonly bool HasEntitlement;

		public readonly int StatusCode;

		public readonly string StatusMessage;

		public EntitlementCheckResult(IntPtr o)
		{
		}
	}
}
