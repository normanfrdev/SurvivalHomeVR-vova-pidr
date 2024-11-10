using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination>, ICollection<TConnection>, IEnumerable<TConnection>, IEnumerable where TConnection : IConnection<TSource, TDestination> where TCollection : ICollection<TConnection>
	{
		private readonly Dictionary<TDestination, List<TConnection>> byDestination;

		private readonly Dictionary<TSource, List<TConnection>> bySource;

		protected readonly TCollection collection;

		public IEnumerable<TConnection> this[TSource source] => null;

		public IEnumerable<TConnection> this[TDestination destination] => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		public ConnectionCollectionBase(TCollection collection)
		{
		}

		public IEnumerator<TConnection> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerable<TConnection> WithSource(TSource source)
		{
			return null;
		}

		public List<TConnection> WithSourceNoAlloc(TSource source)
		{
			return null;
		}

		public TConnection SingleOrDefaultWithSource(TSource source)
		{
			return default(TConnection);
		}

		public IEnumerable<TConnection> WithDestination(TDestination destination)
		{
			return null;
		}

		public List<TConnection> WithDestinationNoAlloc(TDestination destination)
		{
			return null;
		}

		public TConnection SingleOrDefaultWithDestination(TDestination destination)
		{
			return default(TConnection);
		}

		public void Add(TConnection item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TConnection item)
		{
			return false;
		}

		public void CopyTo(TConnection[] array, int arrayIndex)
		{
		}

		public bool Remove(TConnection item)
		{
			return false;
		}

		protected virtual void BeforeAdd(TConnection item)
		{
		}

		protected virtual void AfterAdd(TConnection item)
		{
		}

		protected virtual void BeforeRemove(TConnection item)
		{
		}

		protected virtual void AfterRemove(TConnection item)
		{
		}

		private void AddToDictionaries(TConnection item)
		{
		}

		private void RemoveFromDictionaries(TConnection item)
		{
		}
	}
}
