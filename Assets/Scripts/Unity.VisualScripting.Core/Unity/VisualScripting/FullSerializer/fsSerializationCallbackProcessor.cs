using System;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsSerializationCallbackProcessor : fsObjectProcessor
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override void OnBeforeSerialize(Type storageType, object instance)
		{
		}

		public override void OnAfterSerialize(Type storageType, object instance, ref fsData data)
		{
		}

		public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
		{
		}

		public override void OnAfterDeserialize(Type storageType, object instance)
		{
		}
	}
}
