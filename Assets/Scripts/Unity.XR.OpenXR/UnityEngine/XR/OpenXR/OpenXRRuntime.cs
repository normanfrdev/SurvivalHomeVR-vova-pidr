using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine.XR.OpenXR
{
	public static class OpenXRRuntime
	{
		private const string LibraryName = "UnityOpenXR";

		public static string name => null;

		public static string version => null;

		public static string apiVersion => null;

		public static string pluginVersion => null;

		public static bool retryInitializationOnFormFactorErrors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event Func<bool> wantsToQuit
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

		public static event Func<bool> wantsToRestart
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

		public static bool IsExtensionEnabled(string extensionName)
		{
			return false;
		}

		public static uint GetExtensionVersion(string extensionName)
		{
			return 0u;
		}

		public static string[] GetEnabledExtensions()
		{
			return null;
		}

		public static string[] GetAvailableExtensions()
		{
			return null;
		}

		private static bool InvokeEvent(Func<bool> func)
		{
			return false;
		}

		internal static bool ShouldQuit()
		{
			return false;
		}

		internal static bool ShouldRestart()
		{
			return false;
		}

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetRuntimeName")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetRuntimeName(out IntPtr runtimeNamePtr);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetRuntimeVersion")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetRuntimeVersion(out ushort major, out ushort minor, out uint patch);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetAPIVersion")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetAPIVersion(out ushort major, out ushort minor, out uint patch);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetPluginVersion")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetPluginVersion(out IntPtr pluginVersionPtr);

		[DllImport("UnityOpenXR", EntryPoint = "unity_ext_IsExtensionEnabled")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_IsExtensionEnabled(string extensionName);

		[DllImport("UnityOpenXR", EntryPoint = "unity_ext_GetExtensionVersion")]
		private static extern uint Internal_GetExtensionVersion(string extensionName);

		[DllImport("UnityOpenXR", EntryPoint = "unity_ext_GetEnabledExtensionCount")]
		private static extern uint Internal_GetEnabledExtensionCount();

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "unity_ext_GetEnabledExtensionName")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetEnabledExtensionNamePtr(uint index, out IntPtr outName);

		[DllImport("UnityOpenXR", EntryPoint = "session_SetSoftRestartLoopAtInitialization")]
		private static extern void Internal_SetSoftRestartLoopAtInitialization([MarshalAs(UnmanagedType.I1)] bool value);

		[DllImport("UnityOpenXR", EntryPoint = "session_GetSoftRestartLoopAtInitialization")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetSoftRestartLoopAtInitialization();

		private static bool Internal_GetEnabledExtensionName(uint index, out string extensionName)
		{
			extensionName = null;
			return false;
		}

		[DllImport("UnityOpenXR", EntryPoint = "unity_ext_GetAvailableExtensionCount")]
		private static extern uint Internal_GetAvailableExtensionCount();

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "unity_ext_GetAvailableExtensionName")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetAvailableExtensionNamePtr(uint index, out IntPtr extensionName);

		private static bool Internal_GetAvailableExtensionName(uint index, out string extensionName)
		{
			extensionName = null;
			return false;
		}

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "session_GetLastError")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetLastError(out IntPtr error);

		internal static bool GetLastError(out string error)
		{
			error = null;
			return false;
		}

		internal static void LogLastError()
		{
		}
	}
}
