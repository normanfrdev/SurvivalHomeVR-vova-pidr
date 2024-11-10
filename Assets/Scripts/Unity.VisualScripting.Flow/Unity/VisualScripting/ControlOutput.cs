using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class ControlOutput : UnitPort<ControlInput, IUnitInputPort, ControlConnection>, IUnitControlPort, IUnitPort, IGraphItem, IUnitOutputPort
	{
		public override IEnumerable<ControlConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<ControlInput> validConnectedPorts => null;

		public override IEnumerable<IUnitInputPort> invalidConnectedPorts => null;

		public bool isPredictable => false;

		public bool couldBeEntered => false;

		public ControlConnection connection => null;

		public override bool hasValidConnection => false;

		public ControlOutput(string key)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public bool IsPredictable(Recursion recursion)
		{
			return false;
		}

		public override bool CanConnectToValid(ControlInput port)
		{
			return false;
		}

		public override void ConnectToValid(ControlInput port)
		{
		}

		public override void ConnectToInvalid(IUnitInputPort port)
		{
		}

		public override void DisconnectFromValid(ControlInput port)
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
