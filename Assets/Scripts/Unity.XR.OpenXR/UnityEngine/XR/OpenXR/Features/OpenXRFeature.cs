using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.OpenXR.NativeTypes;

namespace UnityEngine.XR.OpenXR.Features
{
	[Serializable]
	public abstract class OpenXRFeature : ScriptableObject
	{
		internal enum LoaderEvent
		{
			SubsystemCreate = 0,
			SubsystemDestroy = 1,
			SubsystemStart = 2,
			SubsystemStop = 3
		}

		internal enum NativeEvent
		{
			XrSetupConfigValues = 0,
			XrSystemIdChanged = 1,
			XrInstanceChanged = 2,
			XrSessionChanged = 3,
			XrBeginSession = 4,
			XrSessionStateChanged = 5,
			XrChangedSpaceApp = 6,
			XrEndSession = 7,
			XrDestroySession = 8,
			XrDestroyInstance = 9,
			XrIdle = 10,
			XrReady = 11,
			XrSynchronized = 12,
			XrVisible = 13,
			XrFocused = 14,
			XrStopping = 15,
			XrExiting = 16,
			XrLossPending = 17,
			XrInstanceLossPending = 18,
			XrRestartRequested = 19,
			XrRequestRestartLoop = 20,
			XrRequestGetSystemLoop = 21
		}

		[Flags]
		protected internal enum StatFlags
		{
			StatOptionNone = 0,
			ClearOnUpdate = 1,
			All = 1
		}

		[FormerlySerializedAs("enabled")]
		[HideInInspector]
		[SerializeField]
		private bool m_enabled;

		[HideInInspector]
		[SerializeField]
		internal string nameUi;

		[HideInInspector]
		[SerializeField]
		internal string version;

		[HideInInspector]
		[SerializeField]
		internal string featureIdInternal;

		[HideInInspector]
		[SerializeField]
		internal string openxrExtensionStrings;

		[HideInInspector]
		[SerializeField]
		internal string company;

		[HideInInspector]
		[SerializeField]
		internal int priority;

		[HideInInspector]
		[SerializeField]
		internal bool required;

		[NonSerialized]
		internal bool internalFieldsUpdated;

		private const string Library = "UnityOpenXR";

		internal bool failedInitialization
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal static bool requiredFeatureFailed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected static IntPtr xrGetInstanceProcAddr => (IntPtr)0;

		protected internal virtual IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		protected internal virtual void OnSubsystemCreate()
		{
		}

		protected internal virtual void OnSubsystemStart()
		{
		}

		protected internal virtual void OnSubsystemStop()
		{
		}

		protected internal virtual void OnSubsystemDestroy()
		{
		}

		protected internal virtual bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected internal virtual void OnSystemChange(ulong xrSystem)
		{
		}

		protected internal virtual void OnSessionCreate(ulong xrSession)
		{
		}

		protected internal virtual void OnAppSpaceChange(ulong xrSpace)
		{
		}

		protected internal virtual void OnSessionStateChange(int oldState, int newState)
		{
		}

		protected internal virtual void OnSessionBegin(ulong xrSession)
		{
		}

		protected internal virtual void OnSessionEnd(ulong xrSession)
		{
		}

		protected internal virtual void OnSessionExiting(ulong xrSession)
		{
		}

		protected internal virtual void OnSessionDestroy(ulong xrSession)
		{
		}

		protected internal virtual void OnInstanceDestroy(ulong xrInstance)
		{
		}

		protected internal virtual void OnSessionLossPending(ulong xrSession)
		{
		}

		protected internal virtual void OnInstanceLossPending(ulong xrInstance)
		{
		}

		protected internal virtual void OnFormFactorChange(int xrFormFactor)
		{
		}

		protected internal virtual void OnViewConfigurationTypeChange(int xrViewConfigurationType)
		{
		}

		protected internal virtual void OnEnvironmentBlendModeChange(XrEnvironmentBlendMode xrEnvironmentBlendMode)
		{
		}

		protected internal virtual void OnEnabledChange()
		{
		}

		protected static string PathToString(ulong path)
		{
			return null;
		}

		protected static ulong StringToPath(string str)
		{
			return 0uL;
		}

		protected static ulong GetCurrentInteractionProfile(ulong userPath)
		{
			return 0uL;
		}

		protected static ulong GetCurrentInteractionProfile(string userPath)
		{
			return 0uL;
		}

		protected static ulong GetCurrentAppSpace()
		{
			return 0uL;
		}

		protected static int GetViewConfigurationTypeForRenderPass(int renderPassIndex)
		{
			return 0;
		}

		protected static void SetEnvironmentBlendMode(XrEnvironmentBlendMode xrEnvironmentBlendMode)
		{
		}

		protected static XrEnvironmentBlendMode GetEnvironmentBlendMode()
		{
			return default(XrEnvironmentBlendMode);
		}

		protected void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : ISubsystemDescriptor where TSubsystem : ISubsystem
		{
		}

		protected void StartSubsystem<T>() where T : class, ISubsystem
		{
		}

		protected void StopSubsystem<T>() where T : class, ISubsystem
		{
		}

		protected void DestroySubsystem<T>() where T : class, ISubsystem
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Awake()
		{
		}

		internal static bool ReceiveLoaderEvent(OpenXRLoaderBase loader, LoaderEvent e)
		{
			return false;
		}

		internal static void ReceiveNativeEvent(NativeEvent e, ulong payload)
		{
		}

		internal static void Initialize()
		{
		}

		internal static void HookGetInstanceProcAddr()
		{
		}

		protected ulong GetAction(InputAction inputAction)
		{
			return 0uL;
		}

		protected internal static ulong RegisterStatsDescriptor(string statName, StatFlags statFlags)
		{
			return 0uL;
		}

		protected internal static void SetStatAsFloat(ulong statId, float value)
		{
		}

		protected internal static void SetStatAsUInt(ulong statId, uint value)
		{
		}

		[DllImport("UnityOpenXR", EntryPoint = "Internal_PathToString")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_PathToStringPtr(ulong pathId, out IntPtr path);

		[DllImport("UnityOpenXR")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_StringToPath([MarshalAs(UnmanagedType.LPStr)] string str, out ulong pathId);

		[DllImport("UnityOpenXR")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetCurrentInteractionProfile(ulong pathId, out ulong interactionProfile);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetFormFactor")]
		private static extern int Internal_GetFormFactor();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetViewConfigurationType")]
		private static extern int Internal_GetViewConfigurationType();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetViewTypeFromRenderIndex")]
		private static extern int Internal_GetViewTypeFromRenderIndex(int renderPassIndex);

		[DllImport("UnityOpenXR", EntryPoint = "session_GetSessionState")]
		private static extern void Internal_GetSessionState(out int oldState, out int newState);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetEnvironmentBlendMode")]
		private static extern XrEnvironmentBlendMode Internal_GetEnvironmentBlendMode();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetEnvironmentBlendMode")]
		private static extern void Internal_SetEnvironmentBlendMode(XrEnvironmentBlendMode xrEnvironmentBlendMode);

		[DllImport("UnityOpenXR", EntryPoint = "OpenXRInputProvider_GetAppSpace")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetAppSpace(out ulong appSpace);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetProcAddressPtr")]
		internal static extern IntPtr Internal_GetProcAddressPtr([MarshalAs(UnmanagedType.I1)] bool loaderDefault);

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetProcAddressPtrAndLoadStage1")]
		internal static extern void Internal_SetProcAddressPtrAndLoadStage1(IntPtr func);

		[DllImport("UnityOpenXR")]
		internal static extern ulong runtime_RegisterStatsDescriptor(string statName, StatFlags statFlags);

		[DllImport("UnityOpenXR")]
		internal static extern void runtime_SetStatAsFloat(ulong statId, float value);

		[DllImport("UnityOpenXR")]
		internal static extern void runtime_SetStatAsUInt(ulong statId, uint value);
	}
}
