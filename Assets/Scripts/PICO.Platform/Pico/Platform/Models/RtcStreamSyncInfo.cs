using System;

namespace Pico.Platform.Models
{
	public class RtcStreamSyncInfo
	{
		public readonly RtcRemoteStreamKey StreamKey;

		public readonly RtcSyncInfoStreamType StreamType;

		public readonly byte[] Data;

		public RtcStreamSyncInfo(IntPtr o)
		{
		}
	}
}
