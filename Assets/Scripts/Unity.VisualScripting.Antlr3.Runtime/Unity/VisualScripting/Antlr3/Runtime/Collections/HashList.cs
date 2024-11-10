using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Collections
{
	public sealed class HashList : IDictionary, ICollection, IEnumerable
	{
		private sealed class HashListEnumerator : IDictionaryEnumerator, IEnumerator
		{
			internal enum EnumerationMode
			{
				Key = 0,
				Value = 1,
				Entry = 2
			}

			private HashList _hashList;

			private List<object> _orderList;

			private EnumerationMode _mode;

			private int _index;

			private int _version;

			private object _key;

			private object _value;

			public object Key => null;

			public object Value => null;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Current => null;

			internal HashListEnumerator()
			{
			}

			internal HashListEnumerator(HashList hashList, EnumerationMode mode)
			{
			}

			public void Reset()
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		private sealed class KeyCollection : ICollection, IEnumerable
		{
			private HashList _hashList;

			public bool IsSynchronized => false;

			public int Count => 0;

			public object SyncRoot => null;

			internal KeyCollection()
			{
			}

			internal KeyCollection(HashList hashList)
			{
			}

			public override string ToString()
			{
				return null;
			}

			public override bool Equals(object o)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public void CopyTo(Array array, int index)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		private sealed class ValueCollection : ICollection, IEnumerable
		{
			private HashList _hashList;

			public bool IsSynchronized => false;

			public int Count => 0;

			public object SyncRoot => null;

			internal ValueCollection()
			{
			}

			internal ValueCollection(HashList hashList)
			{
			}

			public override string ToString()
			{
				return null;
			}

			public void CopyTo(Array array, int index)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		private Hashtable _dictionary;

		private List<object> _insertionOrderList;

		private int _version;

		public bool IsReadOnly => false;

		public object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection Values => null;

		public ICollection Keys => null;

		public bool IsFixedSize => false;

		public bool IsSynchronized => false;

		public int Count => 0;

		public object SyncRoot => null;

		public HashList()
		{
		}

		public HashList(int capacity)
		{
		}

		public IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		public void Remove(object key)
		{
		}

		public bool Contains(object key)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void Add(object key, object value)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		private void CopyKeysTo(Array array, int index)
		{
		}

		private void CopyValuesTo(Array array, int index)
		{
		}
	}
}
