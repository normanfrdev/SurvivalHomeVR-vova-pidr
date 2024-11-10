using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class DebugDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
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

		public string label
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool debug
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Count => 0;

		object ICollection.SyncRoot => null;

		bool ICollection.IsSynchronized => false;

		ICollection IDictionary.Values => null;

		bool IDictionary.IsReadOnly => false;

		bool IDictionary.IsFixedSize => false;

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		public ICollection<TKey> Keys => null;

		ICollection IDictionary.Keys => null;

		public ICollection<TValue> Values => null;

		void ICollection.CopyTo(Array array, int index)
		{
		}

		private void Debug(string message)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void IDictionary.Remove(object key)
		{
		}

		bool IDictionary.Contains(object key)
		{
			return false;
		}

		void IDictionary.Add(object key, object value)
		{
		}

		public void Clear()
		{
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public void Add(TKey key, TValue value)
		{
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
	}
}
