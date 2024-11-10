using System;

namespace Pico.Platform.Models
{
	public class AssetFileDeleteForSafety
	{
		public readonly ulong AssetId;

		public readonly string Reason;

		public AssetFileDeleteForSafety(IntPtr o)
		{
		}
	}
}
