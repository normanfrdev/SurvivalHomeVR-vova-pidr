using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct MotionTrackerConnectState
	{
		public int trackerSum;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
		public TrackerSN[] trackersSN;
	}
}
