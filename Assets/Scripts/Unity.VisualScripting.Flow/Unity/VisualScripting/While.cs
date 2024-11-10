using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitTitle("While Loop")]
	[UnitCategory("Control")]
	[UnitOrder(11)]
	public class While : LoopUnit
	{
		[CompilerGenerated]
		private sealed class _003CLoopCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public While _003C_003E4__this;

			public Flow flow;

			private int _003Cloop_003E5__2;

			private GraphStack _003Cstack_003E5__3;

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
			public _003CLoopCoroutine_003Ed__8(int _003C_003E1__state)
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
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput condition
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

		protected override void Definition()
		{
		}

		private int Start(Flow flow)
		{
			return 0;
		}

		private bool CanMoveNext(Flow flow)
		{
			return false;
		}

		protected override ControlOutput Loop(Flow flow)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoopCoroutine_003Ed__8))]
		protected override IEnumerator LoopCoroutine(Flow flow)
		{
			return null;
		}
	}
}
