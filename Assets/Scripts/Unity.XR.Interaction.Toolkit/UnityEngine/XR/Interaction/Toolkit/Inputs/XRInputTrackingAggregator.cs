using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.XR.OpenXR.Features.Interactions;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
	public static class XRInputTrackingAggregator
	{
		public static class Characteristics
		{
			public static InputDeviceCharacteristics hmd => default(InputDeviceCharacteristics);

			public static InputDeviceCharacteristics eyeGaze => default(InputDeviceCharacteristics);

			public static InputDeviceCharacteristics leftController => default(InputDeviceCharacteristics);

			public static InputDeviceCharacteristics rightController => default(InputDeviceCharacteristics);

			public static InputDeviceCharacteristics leftTrackedHand => default(InputDeviceCharacteristics);

			public static InputDeviceCharacteristics rightTrackedHand => default(InputDeviceCharacteristics);
		}

		private static List<InputDevice> s_XRInputDevices;

		public static TrackingStatus GetHMDStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetEyeGazeStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetLeftControllerStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetRightControllerStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetLeftTrackedHandStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetRightTrackedHandStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetLeftMetaAimHandStatus()
		{
			return default(TrackingStatus);
		}

		public static TrackingStatus GetRightMetaAimHandStatus()
		{
			return default(TrackingStatus);
		}

		internal static bool TryGetDeviceWithExactCharacteristics(InputDeviceCharacteristics desiredCharacteristics, out InputDevice inputDevice)
		{
			inputDevice = default(InputDevice);
			return false;
		}

		private static TrackingStatus GetTrackingStatus(TrackedDevice device)
		{
			return default(TrackingStatus);
		}

		private static TrackingStatus GetTrackingStatus(EyeGazeInteraction.EyeGazeDevice device)
		{
			return default(TrackingStatus);
		}

		private static TrackingStatus GetTrackingStatus(InputDevice device)
		{
			return default(TrackingStatus);
		}
	}
}
