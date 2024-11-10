using System.Runtime.InteropServices;

namespace Unity.XR.PXR
{
	public struct EyeTrackingData
	{
		private int apiVersion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public PerEyeData[] eyeDatas;

		public void SetVersion(int version)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
