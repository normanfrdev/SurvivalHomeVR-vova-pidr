using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine.XR.OpenXR.Features.Extensions.PerformanceSettings;
using UnityEngine.XR.OpenXR.NativeTypes;

namespace UnityEngine.XR.OpenXR.Features.Mock
{
	public class MockRuntime : OpenXRFeature
	{
		public enum ScriptEvent
		{
			Unknown = 0,
			EndFrame = 1,
			HapticImpulse = 2,
			HapticStop = 3
		}

		public delegate void ScriptEventDelegate(ScriptEvent evt, ulong param);

		public delegate XrResult BeforeFunctionDelegate(string functionName);

		public delegate void AfterFunctionDelegate(string functionName, XrResult result);

		private static Dictionary<string, AfterFunctionDelegate> s_AfterFunctionCallbacks;

		private static Dictionary<string, BeforeFunctionDelegate> s_BeforeFunctionCallbacks;

		public const string featureId = "com.unity.openxr.feature.mockruntime";

		public bool ignoreValidationErrors;

		private const string extLib = "mock_api";

		public static MockRuntime Instance => null;

		public static event ScriptEventDelegate onScriptEvent
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

		[MonoPInvokeCallback(typeof(ScriptEventDelegate))]
		private static void ReceiveScriptEvent(ScriptEvent evt, ulong param)
		{
		}

		[MonoPInvokeCallback(typeof(BeforeFunctionDelegate))]
		private static XrResult BeforeFunctionCallback(string function)
		{
			return default(XrResult);
		}

		[MonoPInvokeCallback(typeof(BeforeFunctionDelegate))]
		private static void AfterFunctionCallback(string function, XrResult result)
		{
		}

		public static void SetFunctionCallback(string function, BeforeFunctionDelegate beforeCallback, AfterFunctionDelegate afterCallback)
		{
		}

		public static void SetFunctionCallback(string function, BeforeFunctionDelegate beforeCallback)
		{
		}

		public static void SetFunctionCallback(string function, AfterFunctionDelegate afterCallback)
		{
		}

		public static BeforeFunctionDelegate GetBeforeFunctionCallback(string function)
		{
			return null;
		}

		public static AfterFunctionDelegate GetAfterFunctionCallback(string function)
		{
			return null;
		}

		public static void ClearFunctionCallbacks()
		{
		}

		public static void ResetDefaults()
		{
		}

		protected internal override void OnInstanceDestroy(ulong instance)
		{
		}

		[DllImport("mock_api", EntryPoint = "MockRuntime_HookCreateInstance")]
		public static extern IntPtr HookCreateInstance(IntPtr func);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetKeepFunctionCallbacks")]
		public static extern void SetKeepFunctionCallbacks([MarshalAs(UnmanagedType.I1)] bool value);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetView")]
		public static extern void SetViewPose(XrViewConfigurationType viewConfigurationType, int viewIndex, Vector3 position, Quaternion orientation, Vector4 fov);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetViewState")]
		public static extern void SetViewState(XrViewConfigurationType viewConfigurationType, XrViewStateFlags viewStateFlags);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetReferenceSpace")]
		public static extern void SetSpace(XrReferenceSpaceType referenceSpace, Vector3 position, Quaternion orientation, XrSpaceLocationFlags locationFlags);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetActionSpace")]
		public static extern void SetSpace(ulong actionHandle, Vector3 position, Quaternion orientation, XrSpaceLocationFlags locationFlags);

		[DllImport("mock_api", EntryPoint = "MockRuntime_RegisterScriptEventCallback")]
		private static extern XrResult Internal_RegisterScriptEventCallback(ScriptEventDelegate callback);

		[DllImport("mock_api", EntryPoint = "MockRuntime_TransitionToState")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_TransitionToState(XrSessionState state, [MarshalAs(UnmanagedType.I1)] bool forceTransition);

		[DllImport("mock_api", EntryPoint = "MockRuntime_GetSessionState")]
		private static extern XrSessionState Internal_GetSessionState();

		[DllImport("mock_api", EntryPoint = "MockRuntime_RequestExitSession")]
		public static extern void RequestExitSession();

		[DllImport("mock_api", EntryPoint = "MockRuntime_CauseInstanceLoss")]
		public static extern void CauseInstanceLoss();

		[DllImport("mock_api", EntryPoint = "MockRuntime_CauseUserPresenceChange")]
		public static extern void CauseUserPresenceChange([MarshalAs(UnmanagedType.U1)] bool hasUserPresent);

		[DllImport("mock_api", EntryPoint = "MockRuntime_SetReferenceSpaceBounds")]
		internal static extern void SetReferenceSpaceBounds(XrReferenceSpaceType referenceSpace, Vector2 bounds);

		[DllImport("mock_api", EntryPoint = "MockRuntime_GetEndFrameStats")]
		internal static extern void GetEndFrameStats(out int primaryLayerCount, out int secondaryLayerCount);

		[DllImport("mock_api", EntryPoint = "MockRuntime_ActivateSecondaryView")]
		internal static extern void ActivateSecondaryView(XrViewConfigurationType viewConfigurationType, [MarshalAs(UnmanagedType.I1)] bool activate);

		[DllImport("mock_api")]
		private static extern void MockRuntime_RegisterFunctionCallbacks(BeforeFunctionDelegate hookBefore, AfterFunctionDelegate hookAfter);

		[DllImport("mock_api", EntryPoint = "MockRuntime_MetaPerformanceMetrics_SeedCounterOnce_Float")]
		internal static extern void MetaPerformanceMetrics_SeedCounterOnce_Float(string xrPathString, float value, uint unit);

		[DllImport("mock_api", EntryPoint = "MockRuntime_PerformanceSettings_CauseNotification")]
		internal static extern void PerformanceSettings_CauseNotification(PerformanceDomain domain, PerformanceSubDomain subDomain, PerformanceNotificationLevel level);

		[DllImport("mock_api", EntryPoint = "MockRuntime_PerformanceSettings_GetPerformanceLevelHint")]
		internal static extern PerformanceLevelHint PerformanceSettings_GetPerformanceLevelHint(PerformanceDomain domain);

		internal static bool IsAndroidThreadTypeRegistered(uint threadType)
		{
			return false;
		}

		internal static ulong GetRegisteredAndroidThreadsCount()
		{
			return 0uL;
		}
	}
}
