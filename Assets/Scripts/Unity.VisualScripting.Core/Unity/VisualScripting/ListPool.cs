using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class ListPool<T>
	{
		private static readonly object @lock;

		private static readonly Stack<List<T>> free;

		private static readonly HashSet<List<T>> busy;

		public static List<T> New()
		{
			return null;
		}

		public static void Free(List<T> list)
		{
		}
	}
}
