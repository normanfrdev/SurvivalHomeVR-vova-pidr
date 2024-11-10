using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitOrder(13)]
	public sealed class Sequence : Unit
	{
		[CompilerGenerated]
		private sealed class _003CEnterCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Flow flow;

			public Sequence _003C_003E4__this;

			private GraphStack _003Cstack_003E5__2;

			private IEnumerator<ControlOutput> _003C_003E7__wrap2;

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
			public _003CEnterCoroutine_003Ed__14(int _003C_003E1__state)
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

		[SerializeAs("outputCount")]
		private int _outputCount;

		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput enter
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
		[Inspectable]
		[InspectorLabel("Steps")]
		[UnitHeaderInspectable("Steps")]
		public int outputCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DoNotSerialize]
		public ReadOnlyCollection<ControlOutput> multiOutputs
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

		private ControlOutput Enter(Flow flow)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEnterCoroutine_003Ed__14))]
		private IEnumerator EnterCoroutine(Flow flow)
		{
			return null;
		}

		public void CopyFrom(Sequence source)
		{
		}
	}
}
