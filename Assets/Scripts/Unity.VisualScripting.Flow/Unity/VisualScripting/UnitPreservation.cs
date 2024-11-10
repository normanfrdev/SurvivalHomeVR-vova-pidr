using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class UnitPreservation : IPoolable
	{
		private struct UnitPortPreservation
		{
			public readonly IUnit unit;

			public readonly string key;

			public UnitPortPreservation(IUnitPort port)
			{
			}

			public UnitPortPreservation(IUnit unit, string key)
			{
			}

			public IUnitPort GetOrCreateInput(out InvalidInput newInvalidInput)
			{
				newInvalidInput = null;
				return null;
			}

			public IUnitPort GetOrCreateOutput(out InvalidOutput newInvalidOutput)
			{
				newInvalidOutput = null;
				return null;
			}
		}

		private readonly Dictionary<string, object> defaultValues;

		private readonly Dictionary<string, List<UnitPortPreservation>> inputConnections;

		private readonly Dictionary<string, List<UnitPortPreservation>> outputConnections;

		private bool disposed;

		void IPoolable.New()
		{
		}

		void IPoolable.Free()
		{
		}

		private UnitPreservation()
		{
		}

		public static UnitPreservation Preserve(IUnit unit)
		{
			return null;
		}

		public void RestoreTo(IUnit unit)
		{
		}

		private void RestoreConnection(UnitPortPreservation sourcePreservation, UnitPortPreservation destinationPreservation)
		{
		}
	}
}
