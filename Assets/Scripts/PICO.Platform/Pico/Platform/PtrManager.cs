using System;

namespace Pico.Platform
{
	public class PtrManager
	{
		public IntPtr ptr;

		private bool freed;

		public PtrManager(byte[] a)
		{
		}

		public void Free()
		{
		}

		~PtrManager()
		{
		}
	}
}
