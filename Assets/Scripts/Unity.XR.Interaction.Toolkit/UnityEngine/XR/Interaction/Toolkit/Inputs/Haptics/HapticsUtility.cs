using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	public static class HapticsUtility
	{
		public enum Controller
		{
			Left = 0,
			Right = 1,
			Both = 2
		}

		private static HapticImpulseCommandChannelGroup s_LeftChannelGroup;

		private static HapticImpulseCommandChannelGroup s_RightChannelGroup;

		private static XRInputDeviceHapticImpulseChannelGroup s_LegacyLeftChannelGroup;

		private static XRInputDeviceHapticImpulseChannelGroup s_LegacyRightChannelGroup;

		private static InputDevice s_LegacyLeftDevice;

		private static InputDevice s_LegacyRightDevice;

		private static HapticControlActionManager s_HapticControlManager;

		private static InputAction s_LeftHapticAction;

		private static InputAction s_RightHapticAction;

		public static bool SendHapticImpulse(float amplitude, float duration, Controller controller, float frequency = 0f, int channel = 0)
		{
			return false;
		}

		private static bool SendHapticImpulseOpenXR(InputAction hapticAction, float amplitude, float duration, float frequency)
		{
			return false;
		}

		private static bool SendHapticImpulse(ref HapticImpulseCommandChannelGroup channelGroup, UnityEngine.InputSystem.InputDevice device, int channel, float amplitude, float duration, float frequency)
		{
			return false;
		}

		private static bool SendHapticImpulseLegacy(ref XRInputDeviceHapticImpulseChannelGroup channelGroup, ref InputDevice device, InputDeviceCharacteristics characteristics, int channel, float amplitude, float duration, float frequency)
		{
			return false;
		}

		private static InputAction GetLeftHapticAction()
		{
			return null;
		}

		private static InputAction GetRightHapticAction()
		{
			return null;
		}
	}
}
