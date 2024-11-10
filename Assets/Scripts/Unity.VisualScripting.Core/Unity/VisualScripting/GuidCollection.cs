using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Unity.VisualScripting
{
	public class GuidCollection<T> : KeyedCollection<Guid, T>, IKeyedCollection<Guid, T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : IIdentifiable
	{
		protected override Guid GetKeyForItem(T item)
		{
			return default(Guid);
		}

		protected override void InsertItem(int index, T item)
		{
		}

		protected override void SetItem(int index, T item)
		{
		}

		public new bool TryGetValue(Guid key, out T value)
		{
			value = default(T);
			return false;
		}

		public GuidCollection()
		{
			((KeyedCollection<TKey, TItem>)(object)this)._002Ector();
		}

		T IKeyedCollection<Guid, T>.get_Item(Guid key)
		{
			return default(T);
		}

		bool IKeyedCollection<Guid, T>.Contains(Guid key)
		{
			return false;
		}

		bool IKeyedCollection<Guid, T>.Remove(Guid key)
		{
			return false;
		}
	}
}
