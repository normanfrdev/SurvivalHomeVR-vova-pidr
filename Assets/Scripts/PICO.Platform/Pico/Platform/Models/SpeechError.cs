using System;

namespace Pico.Platform.Models
{
	public class SpeechError
	{
		public readonly string Message;

		public readonly string SessionId;

		public readonly int Code;

		public SpeechError(IntPtr o)
		{
		}
	}
}
