using System;

namespace Pico.Platform
{
	public class StartAsrOptions
	{
		public IntPtr Handle;

		public void SetAutoStop(bool value)
		{
		}

		public void SetVadMaxDurationInSeconds(int value)
		{
		}

		public void SetShowPunctual(bool value)
		{
		}

		public static explicit operator IntPtr(StartAsrOptions options)
		{
			return (IntPtr)0;
		}

		~StartAsrOptions()
		{
		}
	}
}
