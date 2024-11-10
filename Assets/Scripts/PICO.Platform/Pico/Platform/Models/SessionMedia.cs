using System;

namespace Pico.Platform.Models
{
	public class SessionMedia
	{
		public readonly CaptureInfo[] Images;

		public readonly RecordInfo[] Videos;

		public SessionMedia(IntPtr o)
		{
		}
	}
}
