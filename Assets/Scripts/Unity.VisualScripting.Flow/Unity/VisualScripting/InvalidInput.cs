using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class InvalidInput : UnitPort<IUnitOutputPort, IUnitOutputPort, InvalidConnection>, IUnitInvalidPort, IUnitPort, IGraphItem, IUnitInputPort
	{
		public override IEnumerable<InvalidConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<IUnitOutputPort> validConnectedPorts => null;

		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts => null;

		public InvalidInput(string key)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public override bool CanConnectToValid(IUnitOutputPort port)
		{
			return false;
		}

		public override void ConnectToValid(IUnitOutputPort port)
		{
		}

		public override void ConnectToInvalid(IUnitOutputPort port)
		{
		}

		public override void DisconnectFromValid(IUnitOutputPort port)
		{
		}

		public override void DisconnectFromInvalid(IUnitOutputPort port)
		{
		}

		public override IUnitPort CompatiblePort(IUnit unit)
		{
			return null;
		}
	}
}
