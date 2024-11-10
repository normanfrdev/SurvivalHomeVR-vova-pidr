using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class XHashSetPool
	{
		public static HashSet<T> ToHashSetPooled<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static void Free<T>(this HashSet<T> hashSet)
		{
		}
	}
}
