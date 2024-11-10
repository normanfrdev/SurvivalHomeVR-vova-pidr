using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitTitle("For Each Loop")]
	[UnitCategory("Control")]
	[UnitOrder(10)]
	public class ForEach : LoopUnit
	{
		[CompilerGenerated]
		private sealed class _003CLoopCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ForEach _003C_003E4__this;

			public Flow flow;

			private int _003Cloop_003E5__2;

			private IEnumerator _003Cenumerator_003E5__3;

			private IDictionaryEnumerator _003CdictionaryEnumerator_003E5__4;

			private int _003CcurrentIndex_003E5__5;

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
			public _003CLoopCoroutine_003Ed__24(int _003C_003E1__state)
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

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput collection
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
		[PortLabel("Index")]
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

		[DoNotSerialize]
		[PortLabel("Key")]
		public ValueOutput currentKey
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
		[PortLabel("Item")]
		public ValueOutput currentItem
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

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Dictionary")]
		[InspectorToggleLeft]
		public bool dictionary
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

		protected override void Definition()
		{
		}

		private int Start(Flow flow, out IEnumerator enumerator, out IDictionaryEnumerator dictionaryEnumerator, out int currentIndex)
		{
			enumerator = null;
			dictionaryEnumerator = null;
			currentIndex = default(int);
			return 0;
		}

		private bool MoveNext(Flow flow, IEnumerator enumerator, IDictionaryEnumerator dictionaryEnumerator, ref int currentIndex)
		{
			return false;
		}

		protected override ControlOutput Loop(Flow flow)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoopCoroutine_003Ed__24))]
		protected override IEnumerator LoopCoroutine(Flow flow)
		{
			return null;
		}
	}
}
