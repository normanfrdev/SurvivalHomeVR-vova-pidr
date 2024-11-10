using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public sealed class Expose : Unit, IAotStubbable
	{
		[CompilerGenerated]
		private sealed class _003CGetAotStubs_003Ed__24 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public Expose _003C_003E4__this;

			private Dictionary<ValueOutput, Member>.ValueCollection.Enumerator _003C_003E7__wrap1;

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
			public _003CGetAotStubs_003Ed__24(int _003C_003E1__state)
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
		[Inspectable]
		[TypeFilter(new Type[] { }, Enums = false)]
		public Type type
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

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Instance")]
		[InspectorToggleLeft]
		public bool instance
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

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Static")]
		[InspectorToggleLeft]
		public bool @static
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

		[DoNotSerialize]
		public Dictionary<ValueOutput, Member> members
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

		public Expose()
		{
		}

		public Expose(Type type)
		{
		}

		[IteratorStateMachine(typeof(_003CGetAotStubs_003Ed__24))]
		public override IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		protected override void Definition()
		{
		}

		private bool Include(Member member)
		{
			return false;
		}

		private object GetValue(Flow flow, Member member)
		{
			return null;
		}
	}
}
