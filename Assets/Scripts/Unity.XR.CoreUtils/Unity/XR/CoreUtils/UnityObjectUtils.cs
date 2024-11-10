using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class UnityObjectUtils
	{
		public static void Destroy(Object obj, bool withUndo = false)
		{
		}

		public static T ConvertUnityObjectToType<T>(Object objectIn) where T : class
		{
			return null;
		}

		public static void RemoveDestroyedObjects<T>(List<T> list) where T : Object
		{
		}

		public static void RemoveDestroyedKeys<TKey, TValue>(Dictionary<TKey, TValue> dictionary) where TKey : Object
		{
		}
	}
}
