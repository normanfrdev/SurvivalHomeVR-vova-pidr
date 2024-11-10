using System;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Obsolete("InputHelpers has been deprecated in version 3.0.0. Use XRInputDeviceButtonReader or XRInputDeviceValueReader instead.")]
	public static class InputHelpers
	{
		[Obsolete("Button has been deprecated in version 3.0.0. Use XRInputDeviceButtonReader or XRInputDeviceValueReader instead.")]
		public enum Button
		{
			None = 0,
			MenuButton = 1,
			Trigger = 2,
			Grip = 3,
			TriggerButton = 4,
			GripButton = 5,
			PrimaryButton = 6,
			PrimaryTouch = 7,
			SecondaryButton = 8,
			SecondaryTouch = 9,
			Primary2DAxisTouch = 10,
			Primary2DAxisClick = 11,
			Secondary2DAxisTouch = 12,
			Secondary2DAxisClick = 13,
			PrimaryAxis2DUp = 14,
			PrimaryAxis2DDown = 15,
			PrimaryAxis2DLeft = 16,
			PrimaryAxis2DRight = 17,
			SecondaryAxis2DUp = 18,
			SecondaryAxis2DDown = 19,
			SecondaryAxis2DLeft = 20,
			SecondaryAxis2DRight = 21,
			[Obsolete("TriggerPressed has been deprecated. Use TriggerButton instead. (UnityUpgradable) -> TriggerButton", true)]
			TriggerPressed = 4,
			[Obsolete("GripPressed has been deprecated. Use GripButton instead. (UnityUpgradable) -> GripButton", true)]
			GripPressed = 5
		}

		[Obsolete("Axis2D has been deprecated in version 3.0.0. Use XRInputDeviceButtonReader or XRInputDeviceValueReader instead.")]
		public enum Axis2D
		{
			None = 0,
			PrimaryAxis2D = 1,
			SecondaryAxis2D = 2
		}

		private enum ButtonReadType
		{
			None = 0,
			Binary = 1,
			Axis1D = 2,
			Axis2DUp = 3,
			Axis2DDown = 4,
			Axis2DLeft = 5,
			Axis2DRight = 6
		}

		private struct ButtonInfo
		{
			public string name;

			public ButtonReadType type;

			public ButtonInfo(string name, ButtonReadType type)
			{
			}
		}

		private static readonly ButtonInfo[] s_ButtonData;

		private static readonly string[] s_Axis2DNames;

		private const float k_DefaultPressThreshold = 0.1f;

		[Obsolete("IsPressed has been deprecated in version 3.0.0. Use XRInputDeviceButtonReader instead.")]
		public static bool IsPressed(this InputDevice device, Button button, out bool isPressed, float pressThreshold = -1f)
		{
			isPressed = default(bool);
			return false;
		}

		[Obsolete("TryReadSingleValue has been deprecated in version 3.0.0. Use XRInputDeviceValueReader instead.")]
		public static bool TryReadSingleValue(this InputDevice device, Button button, out float singleValue)
		{
			singleValue = default(float);
			return false;
		}

		[Obsolete("TryReadAxis2DValue has been deprecated in version 3.0.0. Use XRInputDeviceValueReader instead.")]
		public static bool TryReadAxis2DValue(this InputDevice device, Axis2D axis2D, out Vector2 value)
		{
			value = default(Vector2);
			return false;
		}
	}
}
