using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Select")]
	[TypeIcon(typeof(ISelectUnit))]
	[UnitOrder(6)]
	public sealed class SelectUnit : Unit, ISelectUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
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

		[DoNotSerialize]
		[PortLabel("True")]
		public ValueInput ifTrue
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
		[PortLabel("False")]
		public ValueInput ifFalse
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
		public ValueOutput selection
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

		public object Branch(Flow flow)
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
	[TypeIcon(typeof(ISelectUnit))]
	public abstract class SelectUnit<T> : Unit, ISelectUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[DoNotSerialize]
		public List<KeyValuePair<T, ValueInput>> branches
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

		[Inspectable]
		[Serialize]
		public List<T> options
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
		public ValueInput selector
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
		public ValueInput @default
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
		public ValueOutput selection
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

		protected override void Definition()
		{
		}

		protected virtual bool Matches(T a, T b)
		{
			return false;
		}

		public object Result(Flow flow)
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
