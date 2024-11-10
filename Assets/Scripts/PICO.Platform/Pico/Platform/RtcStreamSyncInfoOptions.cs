using System;

namespace Pico.Platform
{
	public class RtcStreamSyncInfoOptions
	{
		private IntPtr Handle;

		public void SetRepeatCount(int value)
		{
		}

		public void SetStreamIndex(RtcStreamIndex value)
		{
		}

		public void SetStreamType(RtcSyncInfoStreamType value)
		{
		}

		public static explicit operator IntPtr(RtcStreamSyncInfoOptions options)
		{
			return (IntPtr)0;
		}

		~RtcStreamSyncInfoOptions()
		{
		}
	}
}
