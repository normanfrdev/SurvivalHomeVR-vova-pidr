using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Unity.VisualScripting
{
	public abstract class NonNullableCollection<T> : Collection<T>
	{
		protected override void InsertItem(int index, T item)
		{
		}

		protected override void SetItem(int index, T item)
		{
		}

		public void AddRange(IEnumerable<T> collection)
		{
		}

		protected NonNullableCollection()
		{
			((Collection<T>)(object)this)._002Ector();
		}
	}
}
