using System;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class ManualPool<T> where T : class
	{
		private static readonly object @lock;

		private static readonly Stack<T> free;

		private static readonly HashSet<T> busy;

		public static T New(Func<T> constructor)
		{
			return null;
		}

		public static void Free(T item)
		{
		}
	}
}
