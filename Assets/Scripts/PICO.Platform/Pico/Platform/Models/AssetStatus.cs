using System;

namespace Pico.Platform.Models
{
	public class AssetStatus
	{
		public readonly ulong AssetId;

		public readonly string Filename;

		public readonly string Filepath;

		public readonly string DownloadStatus;

		public AssetStatus(IntPtr o)
		{
		}
	}
}
