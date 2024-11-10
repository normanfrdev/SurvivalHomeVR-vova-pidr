using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class LayerMaskExtensions
	{
		public static int GetFirstLayerIndex(this LayerMask layerMask)
		{
			return 0;
		}

		public static bool Contains(this LayerMask mask, int layer)
		{
			return false;
		}
	}
}
