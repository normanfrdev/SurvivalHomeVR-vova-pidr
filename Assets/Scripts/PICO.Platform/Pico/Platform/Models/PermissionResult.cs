using System;

namespace Pico.Platform.Models
{
	public class PermissionResult
	{
		public readonly string[] AuthorizedPermissions;

		public readonly string AccessToken;

		public readonly string UserID;

		public PermissionResult(IntPtr o)
		{
		}
	}
}
