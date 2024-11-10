using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct BodyTrackingData
	{
		private int apiVersion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
		public BodyTrackingRoleData[] roleDatas;

		public override string ToString()
		{
			return null;
		}
	}
}
