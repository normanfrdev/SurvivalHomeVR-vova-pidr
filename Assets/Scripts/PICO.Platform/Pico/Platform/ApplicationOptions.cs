using System;

namespace Pico.Platform
{
	public class ApplicationOptions
	{
		private readonly IntPtr Handle;

		public void SetDeeplinkMessage(string value)
		{
		}

		public static explicit operator IntPtr(ApplicationOptions options)
		{
			return (IntPtr)0;
		}

		~ApplicationOptions()
		{
		}
	}
}
