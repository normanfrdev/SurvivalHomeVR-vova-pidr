using System;

namespace Pico.Platform.Models
{
	public sealed class Packet : IDisposable
	{
		private readonly ulong size;

		private readonly IntPtr handler;

		public string SenderId => null;

		public ulong Size => 0uL;

		public Packet(IntPtr handler)
		{
		}

		public ulong GetBytes(byte[] dest)
		{
			return 0uL;
		}

		public string GetBytes()
		{
			return null;
		}

		~Packet()
		{
		}

		public void Dispose()
		{
		}
	}
}
