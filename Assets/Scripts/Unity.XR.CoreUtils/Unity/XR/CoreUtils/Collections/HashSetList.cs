using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Unity.XR.CoreUtils.Collections
{
	public class HashSetList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback, ISet<T>, IReadOnlyCollection<T>
	{
		private readonly List<T> m_InternalList;

		private readonly HashSet<T> m_InternalHashSet;

		public int Count => 0;

		bool ICollection<T>.IsReadOnly => false;

		public T this[int index] => default(T);

		public HashSetList(int capacity = 0)
		{
		}

		public List<T>.Enumerator GetEnumerator()
		{
			return default(List<T>.Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<T>.Add(T item)
		{
		}

		public bool Add(T item)
		{
			return false;
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void ExceptWith(IEnumerable<T> other)
		{
		}

		public void IntersectWith(IEnumerable<T> other)
		{
		}

		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return false;
		}

		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return false;
		}

		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return false;
		}

		public bool Overlaps(IEnumerable<T> other)
		{
			return false;
		}

		public bool SetEquals(IEnumerable<T> other)
		{
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<T> other)
		{
		}

		public void UnionWith(IEnumerable<T> other)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public void OnDeserialization(object sender)
		{
		}

		private void RefreshList()
		{
		}

		public IReadOnlyList<T> AsList()
		{
			return null;
		}
	}
}
