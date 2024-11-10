using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class ValueInput : UnitPort<ValueOutput, IUnitOutputPort, ValueConnection>, IUnitValuePort, IUnitPort, IGraphItem, IUnitInputPort
	{
		private static readonly HashSet<Type> typesWithDefaultValues;

		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool hasDefaultValue => false;

		public override IEnumerable<ValueConnection> validConnections => null;

		public override IEnumerable<InvalidConnection> invalidConnections => null;

		public override IEnumerable<ValueOutput> validConnectedPorts => null;

		public override IEnumerable<IUnitOutputPort> invalidConnectedPorts => null;

		[DoNotSerialize]
		internal object _defaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool nullMeansSelf
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool allowsNull
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ValueConnection connection => null;

		public override bool hasValidConnection => false;

		public ValueInput(string key, Type type)
		{
			((UnitPort<, , >)(object)this)._002Ector((string)null);
		}

		public void SetDefaultValue(object value)
		{
		}

		public override bool CanConnectToValid(ValueOutput port)
		{
			return false;
		}

		public override void ConnectToValid(ValueOutput port)
		{
		}

		public override void ConnectToInvalid(IUnitOutputPort port)
		{
		}

		public override void DisconnectFromValid(ValueOutput port)
		{
		}

		public override void DisconnectFromInvalid(IUnitOutputPort port)
		{
		}

		public ValueInput NullMeansSelf()
		{
			return null;
		}

		public ValueInput AllowsNull()
		{
			return null;
		}

		public static bool SupportsDefaultValue(Type type)
		{
			return false;
		}

		public override IUnitPort CompatiblePort(IUnit unit)
		{
			return null;
		}
	}
}
