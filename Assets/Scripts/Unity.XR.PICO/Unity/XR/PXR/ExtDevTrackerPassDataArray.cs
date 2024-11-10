using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct ExtDevTrackerPassDataArray
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public ExtDevTrackerPassData[] passDatas;
	}
}
