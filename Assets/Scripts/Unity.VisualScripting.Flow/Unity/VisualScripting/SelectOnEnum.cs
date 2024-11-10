using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Select On Enum")]
	[UnitShortTitle("Select")]
	[UnitSubtitle("On Enum")]
	[UnitOrder(7)]
	[TypeIcon(typeof(ISelectUnit))]
	public sealed class SelectOnEnum : Unit, ISelectUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[DoNotSerialize]
		public Dictionary<object, ValueInput> branches
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

		public override bool canDefine => false;

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
}
