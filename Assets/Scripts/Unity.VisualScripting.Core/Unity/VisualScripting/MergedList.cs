using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class MergedList<T> : IMergedCollection<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			private Dictionary<Type, IList<T>>.Enumerator listsEnumerator;

			private T currentItem;

			private IList<T> currentList;

			private int indexInCurrentList;

			private bool exceeded;

			public T Current => default(T);

			object IEnumerator.Current => null;

			public Enumerator(MergedList<T> merged)
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

		protected readonly Dictionary<Type, IList<T>> lists;

		public int Count => 0;

		public bool IsReadOnly => false;

		public virtual void Include<TI>(IList<TI> list) where TI : T
		{
		}

		public bool Includes<TI>() where TI : T
		{
			return false;
		}

		public bool Includes(Type elementType)
		{
			return false;
		}

		public IList<TI> ForType<TI>() where TI : T
		{
			return null;
		}

		protected IList<T> GetListForItem(T item)
		{
			return null;
		}

		protected IList<T> GetListForType(Type type, bool throwOnFail = true)
		{
			return null;
		}

		public bool Contains(T item)
		{
			return false;
		}

		public virtual void Add(T item)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Remove(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}
}
