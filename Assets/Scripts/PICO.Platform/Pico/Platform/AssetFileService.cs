using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class AssetFileService
	{
		public static Task<AssetFileDeleteResult> DeleteById(ulong assetFileId)
		{
			return null;
		}

		public static Task<AssetFileDeleteResult> DeleteByName(string assetFileName)
		{
			return null;
		}

		public static Task<AssetFileDownloadResult> DownloadById(ulong assetFileId)
		{
			return null;
		}

		public static Task<AssetFileDownloadResult> DownloadByName(string assetFileName)
		{
			return null;
		}

		public static Task<AssetFileDownloadCancelResult> DownloadCancelById(ulong assetFileId)
		{
			return null;
		}

		public static Task<AssetFileDownloadCancelResult> DownloadCancelByName(string assetFileName)
		{
			return null;
		}

		public static Task<AssetStatus> StatusById(ulong assetId)
		{
			return null;
		}

		public static Task<AssetStatus> StatusByName(string assetFileName)
		{
			return null;
		}

		public static Task<AssetDetailsList> GetList()
		{
			return null;
		}

		public static Task<AssetDetailsList> GetNextAssetDetailsListPage(AssetDetailsList list)
		{
			return null;
		}

		public static void SetOnDownloadUpdateCallback(Message<AssetFileDownloadUpdate>.Handler handler)
		{
		}

		public static void SetOnDeleteForSafetyCallback(Message<AssetFileDeleteForSafety>.Handler handler)
		{
		}
	}
}
