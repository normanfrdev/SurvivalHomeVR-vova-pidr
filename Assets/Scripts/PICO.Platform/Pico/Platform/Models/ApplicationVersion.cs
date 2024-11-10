using System;

namespace Pico.Platform.Models
{
	public class ApplicationVersion
	{
		public readonly long CurrentCode;

		public readonly string CurrentName;

		public readonly long LatestCode;

		public readonly string LatestName;

		public ApplicationVersion(IntPtr o)
		{
		}
	}
}
