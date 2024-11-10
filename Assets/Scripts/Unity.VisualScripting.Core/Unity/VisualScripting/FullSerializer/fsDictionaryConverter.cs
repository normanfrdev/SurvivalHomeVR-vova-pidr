using System;
using System.Collections;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsDictionaryConverter : fsConverter
	{
		public override bool CanProcess(Type type)
		{
			return false;
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
		{
			return default(fsResult);
		}

		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
		{
			serialized = null;
			return default(fsResult);
		}

		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value)
		{
			return default(fsResult);
		}

		private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType)
		{
			keyStorageType = null;
			valueStorageType = null;
		}
	}
}
