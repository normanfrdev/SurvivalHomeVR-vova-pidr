using System.Runtime.InteropServices;

namespace UnityEngine.XR.OpenXR
{
	public static class OpenXRUtility
	{
		private const string LibraryName = "UnityOpenXR";

		public static bool IsSessionFocused => false;

		public static bool IsUserPresent => false;

		private static Pose Inverse(Pose p)
		{
			return default(Pose);
		}

		public static Pose ComputePoseToWorldSpace(Transform t, Camera camera)
		{
			return default(Pose);
		}

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_IsSessionFocused")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_IsSessionFocused();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetUserPresence")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetUserPresence();
	}
}
