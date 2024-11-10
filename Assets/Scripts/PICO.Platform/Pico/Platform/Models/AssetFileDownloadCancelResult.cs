using System;

namespace Pico.Platform.Models
{
	public class AssetFileDownloadCancelResult
	{
		public readonly string Filepath;

		public readonly bool Success;

		public readonly ulong AssetId;

		public AssetFileDownloadCancelResult(IntPtr o)
		{
		}
	}
}
