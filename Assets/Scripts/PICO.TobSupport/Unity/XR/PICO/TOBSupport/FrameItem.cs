using System;

namespace Unity.XR.PICO.TOBSupport
{
	public struct FrameItem
	{
		public byte camera_id;

		public uint width;

		public uint height;

		public uint format;

		public uint exposure_duration;

		public ulong timestamp;

		public ulong qtimer_timestamp;

		public ulong framenumber;

		public uint datasize;

		public IntPtr data;
	}
}
