using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class ArrayPool<T>
	{
		private static readonly object @lock;

		private static readonly Dictionary<int, Stack<T[]>> free;

		private static readonly HashSet<T[]> busy;

		public static T[] New(int length)
		{
			return null;
		}

		public static void Free(T[] array)
		{
		}
	}
}
