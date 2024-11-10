using System;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsDateConverter : fsConverter
	{
		private const string DefaultDateTimeFormatString = "o";

		private const string DateTimeOffsetFormatString = "o";

		private string DateTimeFormatString => null;

		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			serialized = null;
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
		{
			return default(fsResult);
		}
	}
}
