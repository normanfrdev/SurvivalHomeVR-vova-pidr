using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class BoundsUtils
	{
		private static readonly List<Renderer> k_Renderers;

		private static readonly List<Transform> k_Transforms;

		public static Bounds GetBounds(List<GameObject> gameObjects)
		{
			return default(Bounds);
		}

		public static Bounds GetBounds(Transform[] transforms)
		{
			return default(Bounds);
		}

		public static Bounds GetBounds(Transform transform)
		{
			return default(Bounds);
		}

		public static Bounds GetBounds(List<Renderer> renderers)
		{
			return default(Bounds);
		}

		public static Bounds GetBounds<T>(List<T> colliders) where T : Collider
		{
			return default(Bounds);
		}

		public static Bounds GetBounds(List<Vector3> points)
		{
			return default(Bounds);
		}
	}
}
