using System.Runtime.InteropServices;

namespace Unity.XR.PICO.TOBSupport
{
	public struct SixDof
	{
		public long timestamp;

		public double x;

		public double y;

		public double z;

		public double rw;

		public double rx;

		public double ry;

		public double rz;

		public byte type;

		public byte confidence;

		public PoseErrorType error;

		public double plane_height;

		public byte plane_status;

		public byte relocation_status;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
		public byte[] reserved;
	}
}
