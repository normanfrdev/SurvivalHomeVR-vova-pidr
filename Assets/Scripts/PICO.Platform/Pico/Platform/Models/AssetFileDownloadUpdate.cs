using System;

namespace Pico.Platform.Models
{
	public class AssetFileDownloadUpdate
	{
		public readonly ulong AssetId;

		public readonly ulong BytesTotal;

		public readonly long BytesTransferred;

		public readonly AssetFileDownloadCompleteStatus CompleteStatus;

		public AssetFileDownloadUpdate(IntPtr o)
		{
		}
	}
}
