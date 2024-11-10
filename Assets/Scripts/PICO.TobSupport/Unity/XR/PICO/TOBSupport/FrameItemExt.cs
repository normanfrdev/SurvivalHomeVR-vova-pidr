using System.Runtime.InteropServices;

namespace Unity.XR.PICO.TOBSupport
{
	public struct FrameItemExt
	{
		public FrameItem frame;

		public bool is_rgb;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public double[] rgb_tsw_matrix;

		public bool is_anti_distortion;

		public AlgoResult six_dof_pose;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] reserved;
	}
}
