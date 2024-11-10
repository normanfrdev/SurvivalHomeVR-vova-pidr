using System;

namespace Unity.XR.PXR
{
	public struct PxrAnchorEntityLoadUuidFilter
	{
		public PxrStructureType type;

		public uint uuidCount;

		public IntPtr uuidList;
	}
}
