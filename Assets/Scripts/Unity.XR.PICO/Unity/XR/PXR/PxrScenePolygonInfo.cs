using System;

namespace Unity.XR.PXR
{
	public struct PxrScenePolygonInfo
	{
		public PxrStructureType type;

		public uint polygonCapacityInput;

		public uint polygonCountOutput;

		public IntPtr vertices;
	}
}
