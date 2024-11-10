using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitTitle("For Loop")]
	[UnitCategory("Control")]
	[UnitOrder(9)]
	public sealed class For : LoopUnit
	{
		[CompilerGenerated]
		private sealed class _003CLoopCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public For _003C_003E4__this;

			public Flow flow;

			private int _003Cloop_003E5__2;

			private int _003CcurrentIndex_003E5__3;

			private int _003ClastIndex_003E5__4;

			private bool _003Cascending_003E5__5;

			private GraphStack _003Cstack_003E5__6;

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
			public _003CLoopCoroutine_003Ed__21(int _003C_003E1__state)
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

		[PortLabel("First")]
		[DoNotSerialize]
		public ValueInput firstIndex
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

		[PortLabel("Last")]
		[DoNotSerialize]
		public ValueInput lastIndex
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

		[DoNotSerialize]
		public ValueInput step
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

		[PortLabel("Index")]
		[DoNotSerialize]
		public ValueOutput currentIndex
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

		private int Start(Flow flow, out int currentIndex, out int lastIndex, out bool ascending)
		{
			currentIndex = default(int);
			lastIndex = default(int);
			ascending = default(bool);
			return 0;
		}

		private bool CanMoveNext(int currentIndex, int lastIndex, bool ascending)
		{
			return false;
		}

		private void MoveNext(Flow flow, ref int currentIndex)
		{
		}

		protected override ControlOutput Loop(Flow flow)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoopCoroutine_003Ed__21))]
		protected override IEnumerator LoopCoroutine(Flow flow)
		{
			return null;
		}

		public bool IsStepValueZero()
		{
			return false;
		}
	}
}
