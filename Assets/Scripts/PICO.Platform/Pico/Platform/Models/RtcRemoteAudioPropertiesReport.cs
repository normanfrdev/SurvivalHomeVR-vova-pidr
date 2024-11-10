using System;

namespace Pico.Platform.Models
{
	public class RtcRemoteAudioPropertiesReport
	{
		public readonly RtcRemoteAudioPropertiesInfo[] AudioPropertiesInfos;

		public readonly int TotalRemoteVolume;

		public RtcRemoteAudioPropertiesReport(IntPtr o)
		{
		}
	}
}
