using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.XR.CoreUtils
{
	public static class GameObjectUtils
	{
		private static readonly List<GameObject> k_GameObjects;

		private static readonly List<Transform> k_Transforms;

		public static event Action<GameObject> GameObjectInstantiated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static GameObject Create()
		{
			return null;
		}

		public static GameObject Create(string name)
		{
			return null;
		}

		public static GameObject Instantiate(GameObject original, Transform parent = null, bool worldPositionStays = true)
		{
			return null;
		}

		public static GameObject Instantiate(GameObject original, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public static GameObject Instantiate(GameObject original, Transform parent, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public static GameObject CloneWithHideFlags(GameObject original, Transform parent = null)
		{
			return null;
		}

		private static void CopyHideFlagsRecursively(GameObject copyFrom, GameObject copyTo)
		{
		}

		public static T ExhaustiveComponentSearch<T>(GameObject desiredSource) where T : Component
		{
			return null;
		}

		public static T ExhaustiveTaggedComponentSearch<T>(GameObject desiredSource, string tag) where T : Component
		{
			return null;
		}

		public static T GetComponentInScene<T>(Scene scene) where T : Component
		{
			return null;
		}

		public static void GetComponentsInScene<T>(Scene scene, List<T> components, bool includeInactive = false) where T : Component
		{
		}

		public static T GetComponentInActiveScene<T>() where T : Component
		{
			return null;
		}

		public static void GetComponentsInActiveScene<T>(List<T> components, bool includeInactive = false) where T : Component
		{
		}

		public static void GetComponentsInAllScenes<T>(List<T> components, bool includeInactive = false) where T : Component
		{
		}

		public static void GetChildGameObjects(this GameObject go, List<GameObject> childGameObjects)
		{
		}

		public static GameObject GetNamedChild(this GameObject go, string name)
		{
			return null;
		}
	}
}
