using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class ControlInput : UnitPort<ControlOutput, IUnitOutputPort, ControlConnection>, IUnitControlPort, IUnitPort, IGraphItem, IUnitInputPort
	{
		internal readonly Func<Flow, ControlOutput> action;

		internal readonly Func<Flow, IEnumerator> coroutineAction;

		public bool supportsCoroutine => false;

		public bool requiresCoroutine => false;

		public override IEnumerable<ControlConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<ControlOutput> validConnectedPorts => null;

		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts => null;

		public bool isPredictable => false;

		public bool couldBeEntered => false;

		public ControlInput(string key, Func<Flow, ControlOutput> action)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public ControlInput(string key, Func<Flow, IEnumerator> coroutineAction)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public ControlInput(string key, Func<Flow, ControlOutput> action, Func<Flow, IEnumerator> coroutineAction)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public bool IsPredictable(Recursion recursion)
		{
			return false;
		}

		public override bool CanConnectToValid(ControlOutput port)
		{
			return false;
		}

		public override void ConnectToValid(ControlOutput port)
		{
		}

		public override void ConnectToInvalid(IUnitOutputPort port)
		{
		}

		public override void DisconnectFromValid(ControlOutput port)
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
