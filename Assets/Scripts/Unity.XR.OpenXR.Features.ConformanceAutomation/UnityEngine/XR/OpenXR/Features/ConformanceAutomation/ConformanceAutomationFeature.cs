using System;
using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.NativeTypes;

namespace UnityEngine.XR.OpenXR.Features.ConformanceAutomation
{
	public class ConformanceAutomationFeature : OpenXRFeature
	{
		public const string featureId = "com.unity.openxr.feature.conformance";

		private static ulong xrInstance;

		private static ulong xrSession;

		private const string ExtLib = "ConformanceAutomationExt";

		protected internal override bool OnInstanceCreate(ulong instance)
		{
			return false;
		}

		protected internal override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		protected internal override void OnSessionCreate(ulong xrSessionId)
		{
		}

		protected internal override void OnSessionDestroy(ulong xrSessionId)
		{
		}

		public static bool ConformanceAutomationSetActive(string interactionProfile, string topLevelPath, bool isActive)
		{
			return false;
		}

		public static bool ConformanceAutomationSetBool(string topLevelPath, string inputSourcePath, bool state)
		{
			return false;
		}

		public static bool ConformanceAutomationSetFloat(string topLevelPath, string inputSourcePath, float state)
		{
			return false;
		}

		public static bool ConformanceAutomationSetVec2(string topLevelPath, string inputSourcePath, Vector2 state)
		{
			return false;
		}

		public static bool ConformanceAutomationSetPose(string topLevelPath, string inputSourcePath, Vector3 position, Quaternion orientation)
		{
			return false;
		}

		public static bool ConformanceAutomationSetVelocity(string topLevelPath, string inputSourcePath, bool linearValid, Vector3 linear, bool angularValid, Vector3 angular)
		{
			return false;
		}

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_initialize")]
		private static extern void initialize(IntPtr xrGetInstanceProcAddr, ulong xrInstance);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceActiveEXT")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceActiveEXT(ulong xrSession, ulong interactionProfile, ulong topLevelPath, [MarshalAs(UnmanagedType.I1)] bool isActive);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceStateBoolEXT")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceStateBoolEXT(ulong xrSession, ulong topLevelPath, ulong inputSourcePath, [MarshalAs(UnmanagedType.I1)] bool state);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceStateFloatEXT")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceStateFloatEXT(ulong xrSession, ulong topLevelPath, ulong inputSourcePath, float state);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceStateVector2fEXT")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceStateVector2fEXT(ulong xrSession, ulong topLevelPath, ulong inputSourcePath, XrVector2f state);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceLocationEXT")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceLocationEXT(ulong xrSession, ulong topLevelPath, ulong inputSourcePath, ulong space, XrPosef pose);

		[DllImport("ConformanceAutomationExt", EntryPoint = "script_xrSetInputDeviceVelocityUNITY")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool xrSetInputDeviceVelocityUNITY(ulong xrSession, ulong topLevelPath, ulong inputSourcePath, [MarshalAs(UnmanagedType.I1)] bool linearValid, XrVector3f linear, [MarshalAs(UnmanagedType.I1)] bool angularValid, XrVector3f angular);
	}
}
