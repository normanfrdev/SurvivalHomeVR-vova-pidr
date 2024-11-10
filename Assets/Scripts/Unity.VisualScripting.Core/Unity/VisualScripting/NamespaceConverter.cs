using System;
using Unity.VisualScripting.FullSerializer;

namespace Unity.VisualScripting
{
	public class NamespaceConverter : fsDirectConverter
	{
		public override Type ModelType => null;

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
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
