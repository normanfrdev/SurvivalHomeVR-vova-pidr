using System;

namespace Pico.Platform
{
	public class RtcAudioPropertyOptions
	{
		public IntPtr Handle;

		public void SetInterval(int value)
		{
		}

		~RtcAudioPropertyOptions()
		{
		}

		public static explicit operator IntPtr(RtcAudioPropertyOptions options)
		{
			return (IntPtr)0;
		}
	}
}
