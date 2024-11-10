using UnityEngine;

namespace Unity.XR.PXR
{
	public struct PxrVector4f
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public Quaternion ToQuat()
		{
			return default(Quaternion);
		}

		public Quaternion ToQuatFlippedZ()
		{
			return default(Quaternion);
		}
	}
}
