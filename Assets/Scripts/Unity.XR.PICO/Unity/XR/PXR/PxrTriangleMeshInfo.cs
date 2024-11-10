using System;

namespace Unity.XR.PXR
{
	public struct PxrTriangleMeshInfo
	{
		public PxrStructureType type;

		public uint vertexCapacityInput;

		public uint vertexCountOutput;

		public IntPtr vertices;

		public uint indexCapacityInput;

		public uint indexCountOutput;

		public IntPtr indices;
	}
}
