using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class Namespace
	{
		private class Collection : KeyedCollection<string, Namespace>, IKeyedCollection<string, Namespace>, ICollection<Namespace>, IEnumerable<Namespace>, IEnumerable
		{
			protected override string GetKeyForItem(Namespace item)
			{
				return null;
			}

			public new bool TryGetValue(string key, out Namespace value)
			{
				value = null;
				return false;
			}

			public Collection()
			{
				((KeyedCollection<TKey, TItem>)(object)this)._002Ector();
			}

			Namespace IKeyedCollection<string, Namespace>.get_Item(string key)
			{
				return null;
			}

			bool IKeyedCollection<string, Namespace>.Contains(string key)
			{
				return false;
			}

			bool IKeyedCollection<string, Namespace>.Remove(string key)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAndAncestors_003Ed__21 : IEnumerable<Namespace>, IEnumerable, IEnumerator<Namespace>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Namespace _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Namespace _003C_003E4__this;

			private IEnumerator<Namespace> _003C_003E7__wrap1;

			Namespace IEnumerator<Namespace>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CAndAncestors_003Ed__21(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<Namespace> IEnumerable<Namespace>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Ancestors_003Ed__20 : IEnumerable<Namespace>, IEnumerable, IEnumerator<Namespace>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private Namespace _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Namespace _003C_003E4__this;

			private Namespace _003Cancestor_003E5__2;

			Namespace IEnumerator<Namespace>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003Cget_Ancestors_003Ed__20(int _003C_003E1__state)
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

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Namespace> IEnumerable<Namespace>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly Collection collection;

		public Namespace Root
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Namespace Parent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string FullName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsRoot
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool IsGlobal
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public IEnumerable<Namespace> Ancestors
		{
			[IteratorStateMachine(typeof(_003Cget_Ancestors_003Ed__20))]
			get
			{
				return null;
			}
		}

		public static Namespace Global
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private Namespace(string fullName)
		{
		}

		[IteratorStateMachine(typeof(_003CAndAncestors_003Ed__21))]
		public IEnumerable<Namespace> AndAncestors()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		static Namespace()
		{
		}

		public static Namespace FromFullName(string fullName)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static implicit operator Namespace(string fullName)
		{
			return null;
		}

		public static implicit operator string(Namespace @namespace)
		{
			return null;
		}

		public static bool operator ==(Namespace a, Namespace b)
		{
			return false;
		}

		public static bool operator !=(Namespace a, Namespace b)
		{
			return false;
		}
	}
}
