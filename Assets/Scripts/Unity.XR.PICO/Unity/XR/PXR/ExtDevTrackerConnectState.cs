using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct ExtDevTrackerConnectState
	{
		public int extNumber;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public ExtDevTrackerInfo[] info;
	}
}
