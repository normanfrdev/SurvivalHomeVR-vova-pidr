using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public abstract class MemberUnit : Unit, IAotStubbable
	{
		[CompilerGenerated]
		private sealed class _003CGetAotStubs_003Ed__15 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public MemberUnit _003C_003E4__this;

			object IEnumerator<object>.Current
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
			public _003CGetAotStubs_003Ed__15(int _003C_003E1__state)
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
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Serialize]
		[MemberFilter(Fields = true, Properties = true, Methods = true, Constructors = true)]
		public Member member
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput target
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

		public override bool canDefine => false;

		protected MemberUnit()
		{
		}

		protected MemberUnit(Member member)
		{
		}

		protected override void Definition()
		{
		}

		protected abstract bool IsMemberValid(Member member);

		public override void Prewarm()
		{
		}

		[IteratorStateMachine(typeof(_003CGetAotStubs_003Ed__15))]
		public override IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}
	}
}
