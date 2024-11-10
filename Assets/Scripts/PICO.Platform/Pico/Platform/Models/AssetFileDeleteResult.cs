using System;

namespace Pico.Platform.Models
{
	public class AssetFileDeleteResult
	{
		public readonly string Filepath;

		public readonly bool Success;

		public readonly ulong AssetId;

		public AssetFileDeleteResult(IntPtr o)
		{
		}
	}
}
