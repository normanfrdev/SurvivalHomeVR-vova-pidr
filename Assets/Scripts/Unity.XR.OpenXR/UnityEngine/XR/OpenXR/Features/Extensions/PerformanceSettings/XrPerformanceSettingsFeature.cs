using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine.Events;

namespace UnityEngine.XR.OpenXR.Features.Extensions.PerformanceSettings
{
	public class XrPerformanceSettingsFeature : OpenXRFeature
	{
		internal static class NativeApi
		{
			internal delegate void XrPerformanceNotificationDelegate(PerformanceChangeNotification notification);

			[DllImport("UnityOpenXR")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool xr_performance_settings_setEventCallback(XrPerformanceNotificationDelegate callback);

			[DllImport("UnityOpenXR")]
			[return: MarshalAs(UnmanagedType.U1)]
			internal static extern bool xr_performance_settings_setPerformanceLevel(PerformanceDomain domain, PerformanceLevelHint level);
		}

		public const string featureId = "com.unity.openxr.feature.extension.performance_settings";

		public const string extensionString = "XR_EXT_performance_settings";

		public static event UnityAction<PerformanceChangeNotification> OnXrPerformanceChangeNotification
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static bool SetPerformanceLevelHint(PerformanceDomain domain, PerformanceLevelHint level)
		{
			return false;
		}

		protected internal override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		[MonoPInvokeCallback(typeof(NativeApi.XrPerformanceNotificationDelegate))]
		private static void OnXrPerformanceNotificationCallback(PerformanceChangeNotification notification)
		{
		}
	}
}
