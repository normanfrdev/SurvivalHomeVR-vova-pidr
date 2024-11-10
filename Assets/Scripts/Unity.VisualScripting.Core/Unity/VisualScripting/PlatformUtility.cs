using UnityEngine;

namespace Unity.VisualScripting
{
	public static class PlatformUtility
	{
		public static readonly bool supportsJit;

		static PlatformUtility()
		{
		}

		private static bool CheckJitSupport()
		{
			return false;
		}

		public static bool IsEditor(this RuntimePlatform platform)
		{
			return false;
		}

		public static bool IsStandalone(this RuntimePlatform platform)
		{
			return false;
		}
	}
}
