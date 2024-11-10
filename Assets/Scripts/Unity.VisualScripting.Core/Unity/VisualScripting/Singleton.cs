using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	public static class Singleton<T> where T : MonoBehaviour, ISingleton
	{
		private static readonly SingletonAttribute attribute;

		private static readonly object _lock;

		private static readonly HashSet<T> awoken;

		private static T _instance;

		private static bool persistent => false;

		private static bool automatic => false;

		private static string name => null;

		private static HideFlags hideFlags => default(HideFlags);

		public static bool instantiated => false;

		public static T instance => null;

		static Singleton()
		{
		}

		private static T[] FindObjectsOfType()
		{
			return null;
		}

		private static T[] FindInstances()
		{
			return null;
		}

		public static T Instantiate()
		{
			return null;
		}

		public static void Awake(T instance)
		{
		}

		public static void OnDestroy(T instance)
		{
		}
	}
}
