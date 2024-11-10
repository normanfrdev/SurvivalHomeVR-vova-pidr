using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class)]
	[fsObject(Converter = typeof(UnitCategoryConverter))]
	public class UnitCategory : Attribute
	{
		[CompilerGenerated]
		private sealed class _003CAndAncestors_003Ed__18 : IEnumerable<UnitCategory>, IEnumerable, IEnumerator<UnitCategory>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private UnitCategory _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public UnitCategory _003C_003E4__this;

			private IEnumerator<UnitCategory> _003C_003E7__wrap1;

			UnitCategory IEnumerator<UnitCategory>.Current
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
			public _003CAndAncestors_003Ed__18(int _003C_003E1__state)
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
			IEnumerator<UnitCategory> IEnumerable<UnitCategory>.GetEnumerator()
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
		private sealed class _003Cget_ancestors_003Ed__17 : IEnumerable<UnitCategory>, IEnumerable, IEnumerator<UnitCategory>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private UnitCategory _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public UnitCategory _003C_003E4__this;

			private UnitCategory _003Cancestor_003E5__2;

			UnitCategory IEnumerator<UnitCategory>.Current
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
			public _003Cget_ancestors_003Ed__17(int _003C_003E1__state)
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
			IEnumerator<UnitCategory> IEnumerable<UnitCategory>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public UnitCategory root
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnitCategory parent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string fullName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool isRoot
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public IEnumerable<UnitCategory> ancestors
		{
			[IteratorStateMachine(typeof(_003Cget_ancestors_003Ed__17))]
			get
			{
				return null;
			}
		}

		public UnitCategory(string fullName)
		{
		}

		[IteratorStateMachine(typeof(_003CAndAncestors_003Ed__18))]
		public IEnumerable<UnitCategory> AndAncestors()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator ==(UnitCategory a, UnitCategory b)
		{
			return false;
		}

		public static bool operator !=(UnitCategory a, UnitCategory b)
		{
			return false;
		}
	}
}
