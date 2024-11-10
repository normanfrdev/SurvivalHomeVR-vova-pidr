using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class MergedCollection<T> : IMergedCollection<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__11 : IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			public MergedCollection<T> _003C_003E4__this;

			private Dictionary<Type, ICollection<T>>.ValueCollection.Enumerator _003C_003E7__wrap1;

			private IEnumerator<T> _003C_003E7__wrap2;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CGetEnumerator_003Ed__11(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly Dictionary<Type, ICollection<T>> collections;

		public int Count => 0;

		public bool IsReadOnly => false;

		public void Include<TI>(ICollection<TI> collection) where TI : T
		{
		}

		public bool Includes<TI>() where TI : T
		{
			return false;
		}

		public bool Includes(Type implementationType)
		{
			return false;
		}

		public ICollection<TI> ForType<TI>() where TI : T
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(MergedCollection<>._003CGetEnumerator_003Ed__11))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private ICollection<T> GetCollectionForItem(T item)
		{
			return null;
		}

		private ICollection<T> GetCollectionForType(Type type, bool throwOnFail = true)
		{
			return null;
		}

		public bool Contains(T item)
		{
			return false;
		}

		public virtual void Add(T item)
		{
		}

		public virtual void Clear()
		{
		}

		public virtual bool Remove(T item)
		{
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}
	}
}
