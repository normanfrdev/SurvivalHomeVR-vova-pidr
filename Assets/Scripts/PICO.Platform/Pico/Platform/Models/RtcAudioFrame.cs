using System;

namespace Pico.Platform.Models
{
	public class RtcAudioFrame
	{
		public readonly RtcAudioChannel Channel;

		public readonly IntPtr Data;

		public readonly long DataSize;

		public readonly RtcAudioSampleRate SampleRate;

		public readonly long TimeStampInUs;

		public RtcAudioFrame(IntPtr o)
		{
		}

		public byte[] GetData()
		{
			return null;
		}

		public void SetData(byte[] data)
		{
		}
	}
}
