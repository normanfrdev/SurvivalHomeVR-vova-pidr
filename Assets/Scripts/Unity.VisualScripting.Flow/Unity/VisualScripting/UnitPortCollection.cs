using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class UnitPortCollection<TPort> : KeyedCollection<string, TPort>, IUnitPortCollection<TPort>, IKeyedCollection<string, TPort>, ICollection<TPort>, IEnumerable<TPort>, IEnumerable where TPort : IUnitPort
	{
		public IUnit unit
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnitPortCollection(IUnit unit)
		{
			((KeyedCollection<TKey, TItem>)(object)this)._002Ector();
		}

		private void BeforeAdd(TPort port)
		{
		}

		private void AfterAdd(TPort port)
		{
		}

		private void BeforeRemove(TPort port)
		{
		}

		private void AfterRemove(TPort port)
		{
		}

		public TPort Single()
		{
			return default(TPort);
		}

		protected override string GetKeyForItem(TPort item)
		{
			return null;
		}

		public new bool TryGetValue(string key, out TPort value)
		{
			value = default(TPort);
			return false;
		}

		protected override void InsertItem(int index, TPort item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void SetItem(int index, TPort item)
		{
		}

		protected override void ClearItems()
		{
		}

		TPort IKeyedCollection<string, TPort>.get_Item(string key)
		{
			return default(TPort);
		}

		bool IKeyedCollection<string, TPort>.Contains(string key)
		{
			return false;
		}

		bool IKeyedCollection<string, TPort>.Remove(string key)
		{
			return false;
		}
	}
}
