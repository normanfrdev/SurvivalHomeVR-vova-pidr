using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Switch On Enum")]
	[UnitShortTitle("Switch")]
	[UnitSubtitle("On Enum")]
	[UnitOrder(3)]
	[TypeIcon(typeof(IBranchUnit))]
	public sealed class SwitchOnEnum : Unit, IBranchUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[DoNotSerialize]
		public Dictionary<Enum, ControlOutput> branches
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
		[UnitHeaderInspectable]
		[TypeFilter(new Type[] { }, Enums = true, Classes = false, Interfaces = false, Structs = false, Primitives = false)]
		public Type enumType
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
		[PortLabelHidden]
		public ValueInput @enum
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

		public ControlOutput Enter(Flow flow)
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
