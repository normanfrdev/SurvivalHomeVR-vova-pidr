using System.Collections.Generic;

namespace Unity.XR.CoreUtils
{
	public static class HashSetExtensions
	{
		public static void ExceptWithNonAlloc<T>(this HashSet<T> self, HashSet<T> other)
		{
		}

		public static T First<T>(this HashSet<T> set)
		{
			return default(T);
		}
	}
}
