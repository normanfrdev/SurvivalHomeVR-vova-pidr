using System;
using System.Collections;
using System.Reflection;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsIEnumerableConverter : fsConverter
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			serialized = null;
			return default(fsResult);
		}

		private bool IsStack(Type type)
		{
			return false;
		}

		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		private static int HintSize(IEnumerable collection)
		{
			return 0;
		}

		private static Type GetElementType(Type objectType)
		{
			return null;
		}

		private static void TryClear(Type type, object instance)
		{
		}

		private static int TryGetExistingSize(Type type, object instance)
		{
			return 0;
		}

		private static MethodInfo GetAddMethod(Type type)
		{
			return null;
		}
	}
}
