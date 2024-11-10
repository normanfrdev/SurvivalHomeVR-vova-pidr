using System;

namespace Unity.VisualScripting
{
	public sealed class ControlConnection : UnitConnection<ControlOutput, ControlInput>, IUnitConnection, IConnection<IUnitOutputPort, IUnitInputPort>, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public override ControlOutput source => null;

		public override ControlInput destination => null;

		IUnitOutputPort IConnection<IUnitOutputPort, IUnitInputPort>.source => null;

		IUnitInputPort IConnection<IUnitOutputPort, IUnitInputPort>.destination => null;

		public override bool sourceExists => false;

		public override bool destinationExists => false;

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public ControlConnection()
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		public ControlConnection(ControlOutput source, ControlInput destination)
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		FlowGraph IUnitConnection.get_graph()
		{
			return null;
		}
	}
}
