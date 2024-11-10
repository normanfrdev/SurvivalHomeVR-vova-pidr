using System;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Unity.VisualScripting
{
	public class UnityObjectConverter : fsConverter
	{
		private List<UnityEngine.Object> objectReferences => null;

		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override bool RequestCycleSupport(Type storageType)
		{
			return false;
		}

		public override bool RequestInheritanceSupport(Type storageType)
		{
			return false;
		}

		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
		{
			serialized = null;
			return default(fsResult);
		}

		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}
	}
}
