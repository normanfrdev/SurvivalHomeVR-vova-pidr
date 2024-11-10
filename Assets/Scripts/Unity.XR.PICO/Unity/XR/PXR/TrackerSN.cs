using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct TrackerSN
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
		public string value;
	}
}
