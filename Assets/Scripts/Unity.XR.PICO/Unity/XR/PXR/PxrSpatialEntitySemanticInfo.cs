using System;

namespace Unity.XR.PXR
{
	public struct PxrSpatialEntitySemanticInfo
	{
		public PxrStructureType type;

		public uint semanticCapacityInput;

		public uint semanticCountOutput;

		public IntPtr semanticLabels;
	}
}
