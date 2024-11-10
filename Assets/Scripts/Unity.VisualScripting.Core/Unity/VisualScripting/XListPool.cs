using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class XListPool
	{
		public static List<T> ToListPooled<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static void Free<T>(this List<T> list)
		{
		}
	}
}
