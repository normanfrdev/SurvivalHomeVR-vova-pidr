using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class VariantList<TBase, TImplementation> : IList<TBase>, ICollection<TBase>, IEnumerable<TBase>, IEnumerable where TImplementation : TBase
	{
		public TBase this[int index]
		{
			get
			{
				return default(TBase);
			}
			set
			{
			}
		}

		public IList<TImplementation> implementation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public VariantList(IList<TImplementation> implementation)
		{
		}

		public void Add(TBase item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(TBase item)
		{
			return false;
		}

		public bool Remove(TBase item)
		{
			return false;
		}

		public void CopyTo(TBase[] array, int arrayIndex)
		{
		}

		public int IndexOf(TBase item)
		{
			return 0;
		}

		public void Insert(int index, TBase item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<TBase> IEnumerable<TBase>.GetEnumerator()
		{
			return null;
		}

		public NoAllocEnumerator<TBase> GetEnumerator()
		{
			return default(NoAllocEnumerator<TBase>);
		}
	}
}
