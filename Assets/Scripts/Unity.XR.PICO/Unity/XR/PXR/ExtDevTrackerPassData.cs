using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct ExtDevTrackerPassData
	{
		public TrackerSN trackerSN;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
		public byte[] passData;
	}
}
