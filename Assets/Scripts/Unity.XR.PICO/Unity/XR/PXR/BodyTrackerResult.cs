using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct BodyTrackerResult
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
		public BodyTrackerTransform[] trackingdata;
	}
}
