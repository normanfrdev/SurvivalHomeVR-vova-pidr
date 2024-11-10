using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.VisualScripting
{
	public static class SceneSingleton<T> where T : MonoBehaviour, ISingleton
	{
		private static Dictionary<Scene, T> instances;

		private static readonly SingletonAttribute attribute;

		private static bool persistent => false;

		private static bool automatic => false;

		private static string name => null;

		private static HideFlags hideFlags => default(HideFlags);

		static SceneSingleton()
		{
		}

		private static void EnsureSceneValid(Scene scene)
		{
		}

		public static bool InstantiatedIn(Scene scene)
		{
			return false;
		}

		public static T InstanceIn(Scene scene)
		{
			return null;
		}

		private static T[] FindObjectsOfType()
		{
			return null;
		}

		private static T[] FindInstances(Scene scene)
		{
			return null;
		}

		private static T FindOrCreateInstance(Scene scene)
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
