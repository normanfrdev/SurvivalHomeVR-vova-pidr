using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class HashSetPool<T>
	{
		private static readonly object @lock;

		private static readonly Stack<HashSet<T>> free;

		private static readonly HashSet<HashSet<T>> busy;

		public static HashSet<T> New()
		{
			return null;
		}

		public static void Free(HashSet<T> hashSet)
		{
		}
	}
}
