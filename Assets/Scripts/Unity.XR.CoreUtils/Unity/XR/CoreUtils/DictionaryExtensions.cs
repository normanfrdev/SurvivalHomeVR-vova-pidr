using System.Collections.Generic;

namespace Unity.XR.CoreUtils
{
	public static class DictionaryExtensions
	{
		public static KeyValuePair<TKey, TValue> First<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
		{
			return default(KeyValuePair<TKey, TValue>);
		}
	}
}
