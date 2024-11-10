using System;

namespace Unity.VisualScripting
{
	public sealed class InvalidConnection : UnitConnection<IUnitOutputPort, IUnitInputPort>, IUnitConnection, IConnection<IUnitOutputPort, IUnitInputPort>, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public override IUnitOutputPort source => null;

		public override IUnitInputPort destination => null;

		public IUnitOutputPort validSource => null;

		public IUnitInputPort validDestination => null;

		public override bool sourceExists => false;

		public override bool destinationExists => false;

		public bool validSourceExists => false;

		public bool validDestinationExists => false;

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public InvalidConnection()
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		public InvalidConnection(IUnitOutputPort source, IUnitInputPort destination)
		{
			((UnitConnection<, >)(object)this)._002Ector();
		}

		public override void AfterRemove()
		{
		}

		public override bool HandleDependencies()
		{
			return false;
		}

		FlowGraph IUnitConnection.get_graph()
		{
			return null;
		}
	}
}
