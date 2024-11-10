using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class VariantKeyedCollection<TBase, TImplementation, TKey> : VariantCollection<TBase, TImplementation>, IKeyedCollection<TKey, TBase>, ICollection<TBase>, IEnumerable<TBase>, IEnumerable where TImplementation : TBase
	{
		public TBase this[TKey key] => default(TBase);

		public new IKeyedCollection<TKey, TImplementation> implementation
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

		TBase IKeyedCollection<TKey, TBase>.this[int index] => default(TBase);

		public VariantKeyedCollection(IKeyedCollection<TKey, TImplementation> implementation)
		{
			((VariantCollection<, >)(object)this)._002Ector((ICollection<TImplementation>)null);
		}

		public bool TryGetValue(TKey key, out TBase value)
		{
			value = default(TBase);
			return false;
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}
	}
}
