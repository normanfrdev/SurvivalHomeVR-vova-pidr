using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class EyeGazeInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Eye Gaze (OpenXR)", isGenericTypeOfDevice = true)]
		public class EyeGazeDevice : OpenXRDevice
		{
			[Preserve]
			[InputControl(offset = 0u, usages = new string[] { "Device", "gaze" })]
			public UnityEngine.InputSystem.XR.PoseControl pose
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

			protected override void FinishSetup()
			{
			}
		}

		public const string featureId = "com.unity.openxr.feature.input.eyetracking";

		private const string userPath = "/user/eyes_ext";

		private const string profile = "/interaction_profiles/ext/eye_gaze_interaction";

		private const string pose = "/input/gaze_ext/pose";

		private const string kDeviceLocalizedName = "Eye Tracking OpenXR";

		public const string extensionString = "XR_EXT_eye_gaze_interaction";

		private const string layoutName = "EyeGaze";

		protected internal override bool OnInstanceCreate(ulong instance)
		{
			return false;
		}

		protected override void RegisterDeviceLayout()
		{
		}

		protected override void UnregisterDeviceLayout()
		{
		}

		protected override InteractionProfileType GetInteractionProfileType()
		{
			return default(InteractionProfileType);
		}

		protected override string GetDeviceLayoutName()
		{
			return null;
		}

		protected override void RegisterActionMapsWithRuntime()
		{
		}
	}
}
