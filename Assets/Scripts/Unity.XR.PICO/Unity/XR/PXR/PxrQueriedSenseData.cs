using System;

namespace Unity.XR.PXR
{
	public struct PxrQueriedSenseData
	{
		public PxrStructureType type;

		public uint queriedSpatialEntityCapacityInput;

		public uint queriedSpatialEntityCountOutput;

		public IntPtr queriedSpatialEntities;
	}
}
