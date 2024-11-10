using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class MergedKeyedCollection<TKey, TItem> : IMergedCollection<TItem>, ICollection<TItem>, IEnumerable<TItem>, IEnumerable
	{
		public struct Enumerator : IEnumerator<TItem>, IEnumerator, IDisposable
		{
			private Dictionary<Type, IKeyedCollection<TKey, TItem>>.Enumerator collectionsEnumerator;

			private TItem currentItem;

			private IKeyedCollection<TKey, TItem> currentCollection;

			private int indexInCurrentCollection;

			private bool exceeded;

			public TItem Current => default(TItem);

			object IEnumerator.Current => null;

			public Enumerator(MergedKeyedCollection<TKey, TItem> merged)
			{
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		protected readonly Dictionary<Type, IKeyedCollection<TKey, TItem>> collections;

		protected readonly Dictionary<Type, IKeyedCollection<TKey, TItem>> collectionsLookup;

		public TItem this[TKey key] => default(TItem);

		public int Count => 0;

		public bool IsReadOnly => false;

		public bool Includes<TSubItem>() where TSubItem : TItem
		{
			return false;
		}

		public bool Includes(Type elementType)
		{
			return false;
		}

		public IKeyedCollection<TKey, TSubItem> ForType<TSubItem>() where TSubItem : TItem
		{
			return null;
		}

		public virtual void Include<TSubItem>(IKeyedCollection<TKey, TSubItem> collection) where TSubItem : TItem
		{
		}

		protected IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item)
		{
			return null;
		}

		protected IKeyedCollection<TKey, TItem> GetCollectionForType(Type type, bool throwOnFail = true)
		{
			return null;
		}

		protected IKeyedCollection<TKey, TItem> GetCollectionForKey(TKey key, bool throwOnFail = true)
		{
			return null;
		}

		public bool TryGetValue(TKey key, out TItem value)
		{
			value = default(TItem);
			return false;
		}

		public virtual void Add(TItem item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TItem item)
		{
			return false;
		}

		public bool Remove(TItem item)
		{
			return false;
		}

		public void CopyTo(TItem[] array, int arrayIndex)
		{
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
		{
			return null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
}
