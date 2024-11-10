using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class WatchedList<T> : Collection<T>, INotifyCollectionChanged<T>
	{
		public event Action<T> ItemAdded
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

		public event Action<T> ItemRemoved
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

		protected override void InsertItem(int index, T item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void ClearItems()
		{
		}

		public WatchedList()
		{
			((Collection<T>)(object)this)._002Ector();
		}
	}
}
