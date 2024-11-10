using System;
using System.Runtime.InteropServices;

namespace UnityEngine.XR.OpenXR.Features
{
	public class FoveatedRenderingFeature : OpenXRFeature
	{
		public const string featureId = "com.unity.openxr.feature.foveatedrendering";

		private const string Library = "UnityOpenXR";

		protected internal override bool OnInstanceCreate(ulong instance)
		{
			return false;
		}

		protected internal override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		[DllImport("UnityOpenXR", EntryPoint = "UnityFoveation_intercept_xrGetInstanceProcAddr")]
		private static extern IntPtr Internal_Unity_intercept_xrGetInstanceProcAddr(IntPtr func);

		[DllImport("UnityOpenXR", EntryPoint = "UnityFoveation_SetUseFoveatedRenderingLegacyMode")]
		private static extern void Internal_Unity_SetUseFoveatedRenderingLegacyMode([MarshalAs(UnmanagedType.I1)] bool value);

		[DllImport("UnityOpenXR", EntryPoint = "UnityFoveation_GetUseFoveatedRenderingLegacyMode")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_Unity_GetUseFoveatedRenderingLegacyMode();
	}
}
