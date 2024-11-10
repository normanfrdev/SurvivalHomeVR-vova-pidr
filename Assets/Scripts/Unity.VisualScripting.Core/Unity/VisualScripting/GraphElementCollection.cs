using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IGraphElementCollection<TElement>, IKeyedCollection<Guid, TElement>, ICollection<TElement>, IEnumerable<TElement>, IEnumerable, INotifyCollectionChanged<TElement>, IProxyableNotifyCollectionChanged<TElement> where TElement : IGraphElement
	{
		public IGraph graph
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool ProxyCollectionChange
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

		public event Action<TElement> ItemAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<TElement> ItemRemoved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action CollectionChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public GraphElementCollection(IGraph graph)
		{
			((GuidCollection<>)(object)this)._002Ector();
		}

		public void BeforeAdd(TElement element)
		{
		}

		public void AfterAdd(TElement element)
		{
		}

		public void BeforeRemove(TElement element)
		{
		}

		public void AfterRemove(TElement element)
		{
		}

		protected override void InsertItem(int index, TElement element)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void ClearItems()
		{
		}

		protected override void SetItem(int index, TElement item)
		{
		}

		public new NoAllocEnumerator<TElement> GetEnumerator()
		{
			return default(NoAllocEnumerator<TElement>);
		}

		TElement IKeyedCollection<Guid, TElement>.get_Item(Guid key)
		{
			return default(TElement);
		}

		bool IKeyedCollection<Guid, TElement>.Contains(Guid key)
		{
			return false;
		}

		bool IKeyedCollection<Guid, TElement>.Remove(Guid key)
		{
			return false;
		}
	}
}
