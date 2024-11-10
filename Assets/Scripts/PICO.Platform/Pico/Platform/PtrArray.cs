using System;

namespace Pico.Platform
{
	internal class PtrArray
	{
		public IntPtr[] a;

		private bool freed;

		public PtrArray(string[] a)
		{
		}

		public void Free()
		{
		}

		~PtrArray()
		{
		}
	}
}
