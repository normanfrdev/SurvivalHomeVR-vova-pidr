using System.Runtime.InteropServices;

namespace Unity.XR.PICO.TOBSupport
{
	public struct AlgoResult
	{
		public SixDof pose;

		public SixDof relocation_pose;

		public double vx;

		public double vy;

		public double vz;

		public double ax;

		public double ay;

		public double az;

		public double wx;

		public double wy;

		public double wz;

		public double w_ax;

		public double w_ay;

		public double w_az;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
		public byte[] reserved;
	}
}
