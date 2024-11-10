using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct BodyTrackerTransform
	{
		public BodyTrackerRole bone;

		public BodyTrackerTransPose localpose;

		public BodyTrackerTransPose globalpose;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public double[] velo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public double[] acce;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public double[] wvelo;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public double[] wacce;

		public uint Action;
	}
}
