using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class ValueConnection : UnitConnection<ValueOutput, ValueInput>, IUnitConnection, IConnection<IUnitOutputPort, IUnitInputPort>, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public class DebugData : UnitConnectionDebugData
		{
			public object lastValue
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

			public bool assignedLastValue
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
		}

		public override ValueOutput source => null;

		public override ValueInput destination => null;

		IUnitOutputPort IConnection<IUnitOutputPort, IUnitInputPort>.source => null;

		IUnitInputPort IConnection<IUnitOutputPort, IUnitInputPort>.destination => null;

		public override bool sourceExists => false;

		public override bool destinationExists => false;

		public override IGraphElementDebugData CreateDebugData()
		{
			return null;
		}

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public ValueConnection()
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		public ValueConnection(ValueOutput source, ValueInput destination)
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		FlowGraph IUnitConnection.get_graph()
		{
			return null;
		}
	}
}
