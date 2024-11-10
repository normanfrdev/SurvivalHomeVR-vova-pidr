using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine.XR.Management;
using UnityEngine.XR.OpenXR.Features;

namespace UnityEngine.XR.OpenXR
{
	public class OpenXRLoaderBase : XRLoaderHelper
	{
		internal enum LoaderState
		{
			Uninitialized = 0,
			InitializeAttempted = 1,
			Initialized = 2,
			StartAttempted = 3,
			Started = 4,
			StopAttempted = 5,
			Stopped = 6,
			DeinitializeAttempted = 7
		}

		internal delegate void ReceiveNativeEventDelegate(OpenXRFeature.NativeEvent e, ulong payload);

		private const double k_IdlePollingWaitTimeInSeconds = 0.1;

		private static List<XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors;

		private static List<XRInputSubsystemDescriptor> s_InputSubsystemDescriptors;

		private List<LoaderState> validLoaderInitStates;

		private List<LoaderState> validLoaderStartStates;

		private List<LoaderState> validLoaderStopStates;

		private List<LoaderState> validLoaderDeinitStates;

		private List<LoaderState> runningStates;

		private OpenXRFeature.NativeEvent currentOpenXRState;

		private bool actionSetsAttached;

		private UnhandledExceptionEventHandler unhandledExceptionHandler;

		internal bool DisableValidationChecksOnEnteringPlaymode;

		private double lastPollCheckTime;

		private const string LibraryName = "UnityOpenXR";

		internal static OpenXRLoaderBase Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal LoaderState currentLoaderState
		{
			[CompilerGenerated]
			get
			{
				return default(LoaderState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal XRDisplaySubsystem displaySubsystem => null;

		internal XRInputSubsystem inputSubsystem => null;

		private bool isInitialized => false;

		private bool isStarted => false;

		private static void ExceptionHandler(object sender, UnhandledExceptionEventArgs args)
		{
		}

		public override bool Initialize()
		{
			return false;
		}

		private bool InitializeInternal()
		{
			return false;
		}

		private bool CreateSubsystems()
		{
			return false;
		}

		internal void ProcessOpenXRMessageLoop()
		{
		}

		public override bool Start()
		{
			return false;
		}

		private bool StartInternal()
		{
			return false;
		}

		public override bool Stop()
		{
			return false;
		}

		private void StopInternal()
		{
		}

		public override bool Deinitialize()
		{
			return false;
		}

		internal new void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : ISubsystemDescriptor where TSubsystem : ISubsystem
		{
		}

		internal new void StartSubsystem<T>() where T : class, ISubsystem
		{
		}

		internal new void StopSubsystem<T>() where T : class, ISubsystem
		{
		}

		internal new void DestroySubsystem<T>() where T : class, ISubsystem
		{
		}

		private void SetApplicationInfo()
		{
		}

		internal static byte[] StringToWCHAR_T(string s)
		{
			return null;
		}

		private bool LoadOpenXRSymbols()
		{
			return false;
		}

		private void RequestOpenXRFeatures()
		{
		}

		private static void DebugLogEnabledSpecExtensions()
		{
		}

		[MonoPInvokeCallback(typeof(ReceiveNativeEventDelegate))]
		private static void ReceiveNativeEvent(OpenXRFeature.NativeEvent e, ulong payload)
		{
		}

		internal static void RegisterOpenXRCallbacks()
		{
		}

		[DllImport("UnityOpenXR", EntryPoint = "main_LoadOpenXRLibrary")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_LoadOpenXRLibrary(byte[] loaderPath);

		[DllImport("UnityOpenXR", EntryPoint = "main_UnloadOpenXRLibrary")]
		internal static extern void Internal_UnloadOpenXRLibrary();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_SetCallbacks")]
		private static extern void Internal_SetCallbacks(ReceiveNativeEventDelegate callback);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "NativeConfig_SetApplicationInfo")]
		private static extern void Internal_SetApplicationInfo(string applicationName, string applicationVersion, uint applicationVersionHash, string engineVersion);

		[DllImport("UnityOpenXR", EntryPoint = "session_RequestExitSession")]
		internal static extern void Internal_RequestExitSession();

		[DllImport("UnityOpenXR", EntryPoint = "session_InitializeSession")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_InitializeSession();

		[DllImport("UnityOpenXR", EntryPoint = "session_CreateSessionIfNeeded")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_CreateSessionIfNeeded();

		[DllImport("UnityOpenXR", EntryPoint = "session_BeginSession")]
		internal static extern void Internal_BeginSession();

		[DllImport("UnityOpenXR", EntryPoint = "session_EndSession")]
		internal static extern void Internal_EndSession();

		[DllImport("UnityOpenXR", EntryPoint = "session_DestroySession")]
		internal static extern void Internal_DestroySession();

		[DllImport("UnityOpenXR", EntryPoint = "messagepump_PumpMessageLoop")]
		private static extern void Internal_PumpMessageLoop();

		[DllImport("UnityOpenXR", EntryPoint = "session_SetSuccessfullyInitialized")]
		internal static extern void Internal_SetSuccessfullyInitialized([MarshalAs(UnmanagedType.I1)] bool value);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "unity_ext_RequestEnableExtensionString")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_RequestEnableExtensionString(string extensionString);
	}
}
