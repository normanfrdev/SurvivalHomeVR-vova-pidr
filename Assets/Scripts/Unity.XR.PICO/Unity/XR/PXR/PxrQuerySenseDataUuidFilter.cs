using System;

namespace Unity.XR.PXR
{
	public struct PxrQuerySenseDataUuidFilter
	{
		public PxrStructureType type;

		public uint uuidCount;

		public IntPtr uuidList;
	}
}
