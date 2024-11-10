using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class VariantCollection<TBase, TImplementation> : ICollection<TBase>, IEnumerable<TBase>, IEnumerable where TImplementation : TBase
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__10 : IEnumerator<TBase>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TBase _003C_003E2__current;

			public VariantCollection<TBase, TImplementation> _003C_003E4__this;

			private IEnumerator<TImplementation> _003C_003E7__wrap1;

			TBase IEnumerator<TBase>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TBase);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public ICollection<TImplementation> implementation
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

		public VariantCollection(ICollection<TImplementation> implementation)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(VariantCollection<, >._003CGetEnumerator_003Ed__10))]
		public IEnumerator<TBase> GetEnumerator()
		{
			return null;
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
	}
}
