using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class NonNullableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
	{
		private readonly List<T> list;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		object IList.this[int index]
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

		public bool IsFixedSize => false;

		public NonNullableList()
		{
		}

		public NonNullableList(int capacity)
		{
		}

		public NonNullableList(IEnumerable<T> collection)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public void Add(T item)
		{
		}

		public int Add(object value)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public bool Contains(object value)
		{
			return false;
		}

		public int IndexOf(object value)
		{
			return 0;
		}

		public void Insert(int index, object value)
		{
		}

		public void Remove(object value)
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void AddRange(IEnumerable<T> collection)
		{
		}
	}
}
