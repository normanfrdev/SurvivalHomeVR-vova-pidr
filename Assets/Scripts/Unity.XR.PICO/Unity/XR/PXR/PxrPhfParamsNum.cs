using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct PxrPhfParamsNum
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PxrPhfParams[] phfParams;
	}
}
