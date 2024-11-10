using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class ComponentUtils<T>
	{
		private static readonly List<T> k_RetrievalList;

		public static T GetComponent(GameObject gameObject)
		{
			return default(T);
		}

		public static T GetComponentInChildren(GameObject gameObject)
		{
			return default(T);
		}
	}
	public static class ComponentUtils
	{
		public static T GetOrAddIf<T>(GameObject gameObject, bool add) where T : Component
		{
			return null;
		}
	}
}
