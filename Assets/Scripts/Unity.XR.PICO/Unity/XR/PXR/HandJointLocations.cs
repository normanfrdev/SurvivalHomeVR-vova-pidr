using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct HandJointLocations
	{
		public uint isActive;

		public uint jointCount;

		public float handScale;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
		public HandJointLocation[] jointLocations;
	}
}
