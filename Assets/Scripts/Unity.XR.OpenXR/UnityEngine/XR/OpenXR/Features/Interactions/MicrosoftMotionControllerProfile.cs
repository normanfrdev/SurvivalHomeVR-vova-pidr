using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class MicrosoftMotionControllerProfile : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Windows MR Controller (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class WMRSpatialController : XRControllerWithRumble
		{
			[Preserve]
			[InputControl(aliases = new string[] { "Primary2DAxis", "thumbstickaxes", "thumbstick" }, usage = "Primary2DAxis")]
			public Vector2Control joystick
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

			[Preserve]
			[InputControl(aliases = new string[] { "Secondary2DAxis", "touchpadaxes", "trackpad" }, usage = "Secondary2DAxis")]
			public Vector2Control touchpad
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

			[Preserve]
			[InputControl(aliases = new string[] { "GripAxis", "squeeze" }, usage = "Grip")]
			public AxisControl grip
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

			[Preserve]
			[InputControl(aliases = new string[] { "GripButton", "squeezeClicked" }, usage = "GripButton")]
			public ButtonControl gripPressed
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

			[Preserve]
			[InputControl(aliases = new string[] { "Primary", "menubutton" }, usage = "MenuButton")]
			public ButtonControl menu
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

			[Preserve]
			[InputControl(aliases = new string[] { "triggeraxis" }, usage = "Trigger")]
			public AxisControl trigger
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

			[Preserve]
			[InputControl(alias = "triggerbutton", usage = "TriggerButton")]
			public ButtonControl triggerPressed
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

			[Preserve]
			[InputControl(aliases = new string[] { "joystickClicked", "thumbstickpressed" }, usage = "Primary2DAxisClick")]
			public ButtonControl joystickClicked
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

			[Preserve]
			[InputControl(aliases = new string[] { "joystickorpadpressed", "touchpadpressed", "trackpadClicked" }, usage = "Secondary2DAxisClick")]
			public ButtonControl touchpadClicked
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

			[Preserve]
			[InputControl(aliases = new string[] { "joystickorpadtouched", "touchpadtouched", "trackpadTouched" }, usage = "Secondary2DAxisTouch")]
			public ButtonControl touchpadTouched
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

			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "device", "gripPose" }, usage = "Device")]
			public UnityEngine.InputSystem.XR.PoseControl devicePose
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

			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "aimPose" }, usage = "Pointer")]
			public UnityEngine.InputSystem.XR.PoseControl pointer
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

			[Preserve]
			[InputControl(offset = 32u)]
			public new ButtonControl isTracked
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

			[Preserve]
			[InputControl(offset = 36u)]
			public new IntegerControl trackingState
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

			[Preserve]
			[InputControl(offset = 40u, aliases = new string[] { "gripPosition" })]
			public new Vector3Control devicePosition
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

			[Preserve]
			[InputControl(offset = 52u, aliases = new string[] { "gripOrientation" })]
			public new QuaternionControl deviceRotation
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

			[Preserve]
			[InputControl(offset = 100u)]
			public Vector3Control pointerPosition
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

			[Preserve]
			[InputControl(offset = 112u, aliases = new string[] { "pointerOrientation" })]
			public QuaternionControl pointerRotation
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

			[Preserve]
			[InputControl(usage = "Haptic")]
			public HapticControl haptic
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

		public const string featureId = "com.unity.openxr.feature.input.microsoftmotioncontroller";

		public const string profile = "/interaction_profiles/microsoft/motion_controller";

		public const string menu = "/input/menu/click";

		public const string squeeze = "/input/squeeze/click";

		public const string trigger = "/input/trigger/value";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string trackpad = "/input/trackpad";

		public const string trackpadClick = "/input/trackpad/click";

		public const string trackpadTouch = "/input/trackpad/touch";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		private const string kDeviceLocalizedName = "Windows MR Controller OpenXR";

		protected override void RegisterDeviceLayout()
		{
		}

		protected override void UnregisterDeviceLayout()
		{
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
