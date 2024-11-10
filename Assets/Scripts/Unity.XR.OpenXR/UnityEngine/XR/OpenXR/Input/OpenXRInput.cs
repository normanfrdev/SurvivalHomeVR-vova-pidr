using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.XR.OpenXR.Features;

namespace UnityEngine.XR.OpenXR.Input
{
	public static class OpenXRInput
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct SerializedGuid
		{
			[FieldOffset(0)]
			public Guid guid;

			[FieldOffset(0)]
			public ulong ulong1;

			[FieldOffset(8)]
			public ulong ulong2;
		}

		internal struct SerializedBinding
		{
			public ulong actionId;

			public string path;
		}

		[Flags]
		public enum InputSourceNameFlags
		{
			UserPath = 1,
			InteractionProfile = 2,
			Component = 4,
			All = 7
		}

		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private struct GetInternalDeviceIdCommand : IInputDeviceCommandInfo
		{
			private const int k_BaseCommandSizeSize = 8;

			private const int k_Size = 12;

			[FieldOffset(0)]
			private InputDeviceCommand baseCommand;

			[FieldOffset(8)]
			public readonly uint deviceId;

			private static FourCC Type => default(FourCC);

			public FourCC typeStatic => default(FourCC);

			public static GetInternalDeviceIdCommand Create()
			{
				return default(GetInternalDeviceIdCommand);
			}
		}

		private static readonly Dictionary<string, OpenXRInteractionFeature.ActionType> ExpectedControlTypeToActionType;

		private const string s_devicePoseActionName = "devicepose";

		private const string s_pointerActionName = "pointer";

		private static readonly Dictionary<string, string> kVirtualControlMap;

		private const string Library = "UnityOpenXR";

		internal static void RegisterLayouts()
		{
		}

		private static bool ValidateActionMapConfig(OpenXRInteractionFeature interactionFeature, OpenXRInteractionFeature.ActionMapConfig actionMapConfig)
		{
			return false;
		}

		internal static void AttachActionSets()
		{
		}

		private static bool RegisterDevices(List<OpenXRInteractionFeature.ActionMapConfig> actionMaps, bool isAdditive)
		{
			return false;
		}

		private static bool CreateActions(List<OpenXRInteractionFeature.ActionMapConfig> actionMaps, Dictionary<string, List<SerializedBinding>> interactionProfiles)
		{
			return false;
		}

		private static void SetDpadBindingCustomValues()
		{
		}

		private static char SanitizeCharForOpenXRPath(char c)
		{
			return '\0';
		}

		private static string SanitizeStringForOpenXRPath(string input)
		{
			return null;
		}

		private static string GetActionHandleName(InputControl control)
		{
			return null;
		}

		public static void SendHapticImpulse(InputActionReference actionRef, float amplitude, float duration, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static void SendHapticImpulse(InputActionReference actionRef, float amplitude, float frequency, float duration, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static void SendHapticImpulse(InputAction action, float amplitude, float duration, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static void SendHapticImpulse(InputAction action, float amplitude, float frequency, float duration, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static void StopHaptics(InputActionReference actionRef, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static void StopHaptics(InputAction inputAction, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
		}

		public static bool TryGetInputSourceName(InputAction inputAction, int index, out string name, InputSourceNameFlags flags = InputSourceNameFlags.All, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
			name = null;
			return false;
		}

		public static bool GetActionIsActive(InputAction inputAction)
		{
			return false;
		}

		public static bool TrySetControllerLateLatchAction(InputAction inputAction)
		{
			return false;
		}

		public static ulong GetActionHandle(InputAction inputAction, UnityEngine.InputSystem.InputDevice inputDevice = null)
		{
			return 0uL;
		}

		private static uint GetDeviceId(UnityEngine.InputSystem.InputDevice inputDevice)
		{
			return 0u;
		}

		private static string UserPathToDeviceName(string userPath)
		{
			return null;
		}

		[DllImport("UnityOpenXR", CallingConvention = CallingConvention.Cdecl, EntryPoint = "OpenXRInputProvider_SetDpadBindingCustomValues")]
		private static extern void Internal_SetDpadBindingCustomValues([MarshalAs(UnmanagedType.I1)] bool isLeft, float forceThreshold, float forceThresholdReleased, float centerRegion, float wedgeAngle, [MarshalAs(UnmanagedType.I1)] bool isSticky);

		[DllImport("UnityOpenXR", CallingConvention = CallingConvention.Cdecl, EntryPoint = "OpenXRInputProvider_SendHapticImpulse")]
		private static extern void Internal_SendHapticImpulse(uint deviceId, ulong actionId, float amplitude, float frequency, float duration);

		[DllImport("UnityOpenXR", CallingConvention = CallingConvention.Cdecl, EntryPoint = "OpenXRInputProvider_StopHaptics")]
		private static extern void Internal_StopHaptics(uint deviceId, ulong actionId);

		[DllImport("UnityOpenXR", EntryPoint = "OpenXRInputProvider_GetActionIdByControl")]
		private static extern ulong Internal_GetActionId(uint deviceId, string name);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_TryGetInputSourceName")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_TryGetInputSourceNamePtr(uint deviceId, ulong actionId, uint index, uint flags, out IntPtr outName);

		internal static bool Internal_TryGetInputSourceName(uint deviceId, ulong actionId, uint index, uint flags, out string outName)
		{
			outName = null;
			return false;
		}

		[DllImport("UnityOpenXR", EntryPoint = "OpenXRInputProvider_TrySetControllerLateLatchAction")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_TrySetControllerLateLatchAction(uint deviceId, ulong actionId);

		[DllImport("UnityOpenXR", EntryPoint = "OpenXRInputProvider_GetActionIsActive")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetActionIsActive(uint deviceId, string name);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_RegisterDeviceDefinition")]
		private static extern ulong Internal_RegisterDeviceDefinition(string userPath, string interactionProfile, [MarshalAs(UnmanagedType.I1)] bool isAdditive, uint characteristics, string name, string manufacturer, string serialNumber);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_CreateActionSet")]
		private static extern ulong Internal_CreateActionSet(string name, string localizedName, SerializedGuid guid);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_CreateAction")]
		private static extern ulong Internal_CreateAction(ulong actionSetId, string name, string localizedName, uint actionType, SerializedGuid guid, string[] userPaths, uint userPathCount, [MarshalAs(UnmanagedType.I1)] bool isAdditive, string[] usages, uint usageCount);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_SuggestBindings")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_SuggestBindings(string interactionProfile, SerializedBinding[] serializedBindings, uint serializedBindingCount);

		[DllImport("UnityOpenXR", CharSet = CharSet.Ansi, EntryPoint = "OpenXRInputProvider_AttachActionSets")]
		[return: MarshalAs(UnmanagedType.U1)]
		internal static extern bool Internal_AttachActionSets();
	}
}
