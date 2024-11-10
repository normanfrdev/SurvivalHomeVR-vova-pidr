using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class XArrayPool
	{
		public static T[] ToArrayPooled<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static void Free<T>(this T[] array)
		{
		}
	}
}
