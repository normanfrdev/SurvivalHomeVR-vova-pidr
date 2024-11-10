using System;

namespace Unity.XR.PXR
{
	public struct PxrAnchorComponentPlaneInfo
	{
		public PxrStructureType type;

		public PxrVector3f center;

		public PxrExtent2Df extent;

		public uint polygonSize;

		public IntPtr polygonVertices;
	}
}
