using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	internal static class Light2DManager
	{
		private static SortingLayer[] s_SortingLayers;

		public static List<Light2D> lights
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static void RegisterLight(Light2D light)
		{
		}

		public static void DeregisterLight(Light2D light)
		{
		}

		public static void ErrorIfDuplicateGlobalLight(Light2D light)
		{
		}

		public static bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, out Color color)
		{
			color = default(Color);
			return false;
		}

		private static bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex)
		{
			return false;
		}

		public static SortingLayer[] GetCachedSortingLayer()
		{
			return null;
		}
	}
}
