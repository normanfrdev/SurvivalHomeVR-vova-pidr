using System;

namespace Pico.Platform.Models
{
	public class SystemInfo
	{
		public readonly string ROMVersion;

		public readonly string Locale;

		public readonly string ProductName;

		public readonly bool IsCnDevice;

		public readonly string MatrixVersionName;

		public readonly long MatrixVersionCode;

		public SystemInfo(IntPtr o)
		{
		}
	}
}
