using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement>, INotifyCollectionChanged<IGraphElement>
	{
		public event Action<IGraphElement> ItemAdded
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

		public event Action<IGraphElement> ItemRemoved
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

		public override void Include<TSubItem>(IKeyedCollection<Guid, TSubItem> collection)
		{
		}

		public MergedGraphElementCollection()
		{
			((MergedKeyedCollection<, >)(object)this)._002Ector();
		}
	}
}
