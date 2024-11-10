using System;

namespace UnityEngine.XR.OpenXR
{
	internal static class OpenXRAnalytics
	{
		[Serializable]
		private struct InitializeEvent
		{
			public bool success;

			public string runtime;

			public string runtime_version;

			public string plugin_version;

			public string api_version;

			public string[] available_extensions;

			public string[] enabled_extensions;

			public string[] enabled_features;

			public string[] failed_features;
		}

		private const int kMaxEventsPerHour = 1000;

		private const int kMaxNumberOfElements = 1000;

		private const string kVendorKey = "unity.openxr";

		private const string kEventInitialize = "openxr_initialize";

		private static bool s_Initialized;

		private static bool Initialize()
		{
			return false;
		}

		public static void SendInitializeEvent(bool success)
		{
		}

		private static InitializeEvent CreateInitializeEvent(bool success)
		{
			return default(InitializeEvent);
		}

		private static void SendPlayerAnalytics(InitializeEvent data)
		{
		}
	}
}
