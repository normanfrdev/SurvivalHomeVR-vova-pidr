using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class ValueOutput : UnitPort<ValueInput, IUnitInputPort, ValueConnection>, IUnitValuePort, IUnitPort, IGraphItem, IUnitOutputPort
	{
		internal readonly Func<Flow, object> getValue;

		internal Func<Flow, bool> canPredictValue;

		public bool supportsPrediction => false;

		public bool supportsFetch => false;

		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override IEnumerable<ValueConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<ValueInput> validConnectedPorts => null;

		public override IEnumerable<IUnitInputPort> invalidConnectedPorts => null;

		public ValueOutput(string key, Type type, Func<Flow, object> getValue)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public ValueOutput(string key, Type type)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public override bool CanConnectToValid(ValueInput port)
		{
			return false;
		}

		public override void ConnectToValid(ValueInput port)
		{
		}

		public override void ConnectToInvalid(IUnitInputPort port)
		{
		}

		public override void DisconnectFromValid(ValueInput port)
		{
		}

		public override void DisconnectFromInvalid(IUnitInputPort port)
		{
		}

		public ValueOutput PredictableIf(Func<Flow, bool> condition)
		{
			return null;
		}

		public ValueOutput Predictable()
		{
			return null;
		}

		public override IUnitPort CompatiblePort(IUnit unit)
		{
			return null;
		}
	}
}
