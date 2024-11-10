using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct PxrEventDataBuffer
	{
		public PxrStructureType type;

		public PxrEventLevel eventLevel;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 500)]
		public byte[] data;
	}
}
