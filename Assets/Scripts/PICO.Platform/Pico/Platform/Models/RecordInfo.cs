using System;

namespace Pico.Platform.Models
{
	public class RecordInfo
	{
		public readonly string VideoPath;

		public readonly int DurationInMilliSeconds;

		public readonly int Width;

		public readonly int Height;

		public readonly string JobId;

		public RecordInfo(IntPtr o)
		{
		}
	}
}
