using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Time")]
	[UnitOrder(6)]
	[TypeIcon(typeof(WaitUnit))]
	public sealed class WaitForFlow : Unit, IGraphElementWithData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public sealed class Data : IGraphElementData
		{
			public bool[] inputsActivated;

			public bool isWaitingCoroutine;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public WaitForFlow _003C_003E4__this;

			public Flow flow;

			internal bool _003CEnterCoroutine_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEnterCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WaitForFlow _003C_003E4__this;

			public Flow flow;

			public int index;

			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

			private Data _003Cdata_003E5__2;

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
			public _003CEnterCoroutine_003Ed__25(int _003C_003E1__state)
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

		[SerializeAs("inputCount")]
		private int _inputCount;

		[Serialize]
		[Inspectable]
		public bool resetOnExit
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		[Inspectable]
		[UnitHeaderInspectable("Inputs")]
		public int inputCount
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
		public ReadOnlyCollection<ControlInput> awaitedInputs
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
		public ControlInput reset
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
		[PortLabelHidden]
		public ControlOutput exit
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

		public IGraphElementData CreateData()
		{
			return null;
		}

		private ControlOutput Enter(Flow flow, int index)
		{
			return null;
		}

		private bool CheckActivated(Flow flow)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CEnterCoroutine_003Ed__25))]
		private IEnumerator EnterCoroutine(Flow flow, int index)
		{
			return null;
		}

		private ControlOutput Reset(Flow flow)
		{
			return null;
		}
	}
}
