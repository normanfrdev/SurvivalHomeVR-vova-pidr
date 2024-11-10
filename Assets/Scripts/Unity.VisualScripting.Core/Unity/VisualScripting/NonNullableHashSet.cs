using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class NonNullableHashSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		private readonly HashSet<T> set;

		public int Count => 0;

		public bool IsReadOnly => false;

		public NonNullableHashSet()
		{
		}

		public NonNullableHashSet(IEqualityComparer<T> comparer)
		{
		}

		public NonNullableHashSet(IEnumerable<T> collection)
		{
		}

		public NonNullableHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
		}

		public bool Add(T item)
		{
			return false;
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

		public void ExceptWith(IEnumerable<T> other)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
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

		public bool Remove(T item)
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

		void ICollection<T>.Add(T item)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
