using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class UnitPort<TValidOther, TInvalidOther, TExternalConnection> : IUnitPort, IGraphItem where TValidOther : IUnitPort where TInvalidOther : IUnitPort where TExternalConnection : IUnitConnection
	{
		public IUnit unit
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

		public string key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IGraph graph => null;

		public IEnumerable<IUnitRelation> relations => null;

		public abstract IEnumerable<TExternalConnection> validConnections { get; }

		public abstract IEnumerable<InvalidConnection> invalidConnections { get; }

		public abstract IEnumerable<TValidOther> validConnectedPorts { get; }

		public abstract IEnumerable<TInvalidOther> invalidConnectedPorts { get; }

		IEnumerable<IUnitConnection> IUnitPort.validConnections => null;

		public IEnumerable<IUnitConnection> connections => null;

		public IEnumerable<IUnitPort> connectedPorts => null;

		public bool hasAnyConnection => false;

		public virtual bool hasValidConnection => false;

		public virtual bool hasInvalidConnection => false;

		protected UnitPort(string key)
		{
		}

		private bool CanConnectTo(IUnitPort port)
		{
			return false;
		}

		public bool CanValidlyConnectTo(IUnitPort port)
		{
			return false;
		}

		public bool CanInvalidlyConnectTo(IUnitPort port)
		{
			return false;
		}

		public void ValidlyConnectTo(IUnitPort port)
		{
		}

		public void InvalidlyConnectTo(IUnitPort port)
		{
		}

		public void Disconnect()
		{
		}

		public abstract bool CanConnectToValid(TValidOther port);

		public bool CanConnectToInvalid(TInvalidOther port)
		{
			return false;
		}

		public abstract void ConnectToValid(TValidOther port);

		public abstract void ConnectToInvalid(TInvalidOther port);

		public abstract void DisconnectFromValid(TValidOther port);

		public abstract void DisconnectFromInvalid(TInvalidOther port);

		public abstract IUnitPort CompatiblePort(IUnit unit);

		protected void ConnectInvalid(IUnitOutputPort source, IUnitInputPort destination)
		{
		}

		protected void DisconnectInvalid(IUnitOutputPort source, IUnitInputPort destination)
		{
		}
	}
}
