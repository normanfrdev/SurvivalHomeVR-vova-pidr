using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class DictionaryPool<TKey, TValue>
	{
		private static readonly object @lock;

		private static readonly Stack<Dictionary<TKey, TValue>> free;

		private static readonly HashSet<Dictionary<TKey, TValue>> busy;

		public static Dictionary<TKey, TValue> New(Dictionary<TKey, TValue> source = null)
		{
			return null;
		}

		public static void Free(Dictionary<TKey, TValue> dictionary)
		{
		}
	}
}
