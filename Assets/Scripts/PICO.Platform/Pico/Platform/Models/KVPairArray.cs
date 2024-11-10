using System;
using System.Runtime.CompilerServices;

namespace Pico.Platform.Models
{
	public class KVPairArray
	{
		private IntPtr Handle;

		public uint Size
		{
			[CompilerGenerated]
			get
			{
				return 0u;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IntPtr GetHandle()
		{
			return (IntPtr)0;
		}

		public KVPairArray(uint size)
		{
		}

		~KVPairArray()
		{
		}

		public KVPair GetElement(uint index)
		{
			return null;
		}
	}
}
