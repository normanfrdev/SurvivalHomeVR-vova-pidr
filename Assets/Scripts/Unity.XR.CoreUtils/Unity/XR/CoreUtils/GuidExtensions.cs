using System;

namespace Unity.XR.CoreUtils
{
	public static class GuidExtensions
	{
		public static void Decompose(this Guid guid, out ulong low, out ulong high)
		{
			low = default(ulong);
			high = default(ulong);
		}
	}
}
