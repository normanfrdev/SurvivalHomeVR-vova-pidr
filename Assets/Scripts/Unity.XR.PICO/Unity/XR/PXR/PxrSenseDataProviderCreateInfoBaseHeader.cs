using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct PxrSenseDataProviderCreateInfoBaseHeader
	{
		public PxrStructureType type;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		public byte[] data;
	}
}
