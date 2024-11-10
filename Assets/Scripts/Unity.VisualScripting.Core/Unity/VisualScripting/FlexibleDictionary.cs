using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class FlexibleDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		public new TValue this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public FlexibleDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}
}
