using System;

namespace Unity.VisualScripting.FullSerializer.Internal.Converters
{
	public class UnityEvent_Converter : fsConverter
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override bool RequestCycleSupport(Type storageType)
		{
			return false;
		}

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			serialized = null;
			return default(fsResult);
		}
	}
}
