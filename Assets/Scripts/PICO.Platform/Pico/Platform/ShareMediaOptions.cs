using System;

namespace Pico.Platform
{
	public class ShareMediaOptions
	{
		private IntPtr Handle;

		public void SetShareMediaType(ShareMediaType value)
		{
		}

		public void SetVideoPath(string value)
		{
		}

		public void SetVideoThumbPath(string value)
		{
		}

		public void AddImagePath(string ele)
		{
		}

		public void ClearImagePaths()
		{
		}

		public void SetShareAppType(ShareAppType value)
		{
		}

		public static explicit operator IntPtr(ShareMediaOptions options)
		{
			return (IntPtr)0;
		}

		~ShareMediaOptions()
		{
		}
	}
}
