using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, IGraphElementCollection<TConnection>, IKeyedCollection<Guid, TConnection>, ICollection<TConnection>, IEnumerable<TConnection>, IEnumerable, INotifyCollectionChanged<TConnection> where TConnection : IConnection<TSource, TDestination>, IGraphElement
	{
		TConnection IKeyedCollection<Guid, TConnection>.this[Guid key] => default(TConnection);

		TConnection IKeyedCollection<Guid, TConnection>.this[int index] => default(TConnection);

		public event Action<TConnection> ItemAdded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<TConnection> ItemRemoved
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action CollectionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public GraphConnectionCollection(IGraph graph)
		{
			((ConnectionCollectionBase<, , , >)(object)this)._002Ector((TCollection)default(_00213));
		}

		public bool TryGetValue(Guid key, out TConnection value)
		{
			value = default(TConnection);
			return false;
		}

		public bool Contains(Guid key)
		{
			return false;
		}

		public bool Remove(Guid key)
		{
			return false;
		}

		protected override void BeforeAdd(TConnection item)
		{
		}

		protected override void AfterAdd(TConnection item)
		{
		}

		protected override void BeforeRemove(TConnection item)
		{
		}

		protected override void AfterRemove(TConnection item)
		{
		}
	}
}
