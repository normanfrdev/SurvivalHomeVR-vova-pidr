using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Select On Flow")]
	[UnitShortTitle("Select")]
	[UnitSubtitle("On Flow")]
	[UnitOrder(8)]
	[TypeIcon(typeof(ISelectUnit))]
	public sealed class SelectOnFlow : Unit, ISelectUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[SerializeAs("branchCount")]
		private int _branchCount;

		[DoNotSerialize]
		[Inspectable]
		[UnitHeaderInspectable("Branches")]
		public int branchCount
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
		public Dictionary<ControlInput, ValueInput> branches
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

		public ControlOutput Select(Flow flow, ValueInput branchValue)
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
