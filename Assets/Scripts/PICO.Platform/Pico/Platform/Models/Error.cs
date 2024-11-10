using System;

namespace Pico.Platform.Models
{
	public class Error
	{
		public readonly int Code;

		public readonly string Message;

		public Error(int code, string msg)
		{
		}

		public Error(IntPtr handle)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
