using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class NonNullableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
	{
		private readonly Dictionary<TKey, TValue> dictionary;

		public TValue this[TKey key]
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		object IDictionary.this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		public bool IsReadOnly => false;

		public ICollection<TKey> Keys => null;

		ICollection IDictionary.Values => null;

		ICollection IDictionary.Keys => null;

		public ICollection<TValue> Values => null;

		public bool IsFixedSize => false;

		public NonNullableDictionary()
		{
		}

		public NonNullableDictionary(int capacity)
		{
		}

		public NonNullableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public NonNullableDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		public NonNullableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		public NonNullableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Add(object key, object value)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		public void Remove(object key)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
