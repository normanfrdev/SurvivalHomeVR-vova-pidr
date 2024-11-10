using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class InvalidOutput : UnitPort<IUnitInputPort, IUnitInputPort, InvalidConnection>, IUnitInvalidPort, IUnitPort, IGraphItem, IUnitOutputPort
	{
		public override IEnumerable<InvalidConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<IUnitInputPort> validConnectedPorts => null;

		public override IEnumerable<IUnitInputPort> invalidConnectedPorts => null;

		public InvalidOutput(string key)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public override bool CanConnectToValid(IUnitInputPort port)
		{
			return false;
		}

		public override void ConnectToValid(IUnitInputPort port)
		{
		}

		public override void ConnectToInvalid(IUnitInputPort port)
		{
		}

		public override void DisconnectFromValid(IUnitInputPort port)
		{
		}

		public override void DisconnectFromInvalid(IUnitInputPort port)
		{
		}

		public override IUnitPort CompatiblePort(IUnit unit)
		{
			return null;
		}
	}
}
