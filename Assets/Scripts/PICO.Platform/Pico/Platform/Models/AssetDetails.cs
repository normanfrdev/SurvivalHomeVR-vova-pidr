using System;

namespace Pico.Platform.Models
{
	public class AssetDetails
	{
		public ulong AssetId;

		public string AssetType;

		public string DownloadStatus;

		public string Filepath;

		public string Metadata;

		public string Filename;

		public int Version;

		public string IapStatus;

		public string IapSku;

		public string IapName;

		public string IapPrice;

		public string IapCurrency;

		public string IapDescription;

		public string IapIcon;

		public AssetDetails(IntPtr o)
		{
		}
	}
}
