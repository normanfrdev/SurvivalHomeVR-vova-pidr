using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class HPReverbG2ControllerProfile : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "HP Reverb G2 Controller (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class ReverbG2Controller : XRControllerWithRumble
		{
			[Preserve]
			[InputControl(aliases = new string[] { "A", "X", "buttonA", "buttonX" }, usage = "PrimaryButton")]
			public ButtonControl primaryButton
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
			[InputControl(aliases = new string[] { "B", "Y", "buttonB", "buttonY" }, usage = "SecondaryButton")]
			public ButtonControl secondaryButton
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
			[InputControl(usage = "Trigger")]
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
			[InputControl(aliases = new string[] { "indexButton", "indexTouched", "triggerbutton" }, usage = "TriggerButton")]
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
			[InputControl(aliases = new string[] { "Primary2DAxis", "Joystick" }, usage = "Primary2DAxis")]
			public Vector2Control thumbstick
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
			[InputControl(aliases = new string[] { "JoystickOrPadPressed", "thumbstickClick", "joystickClicked" }, usage = "Primary2DAxisClick")]
			public ButtonControl thumbstickClicked
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
			[InputControl(offset = 0u, alias = "aimPose", usage = "Pointer")]
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
			[InputControl(offset = 29u)]
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
			[InputControl(offset = 32u)]
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
			[InputControl(offset = 36u, alias = "gripPosition")]
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
			[InputControl(offset = 48u, alias = "gripOrientation")]
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
			[InputControl(offset = 96u)]
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
			[InputControl(offset = 108u, alias = "pointerOrientation")]
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

		public const string featureId = "com.unity.openxr.feature.input.hpreverb";

		public const string profile = "/interaction_profiles/hp/mixed_reality_controller";

		public const string buttonX = "/input/x/click";

		public const string buttonY = "/input/y/click";

		public const string buttonA = "/input/a/click";

		public const string buttonB = "/input/b/click";

		public const string menu = "/input/menu/click";

		public const string squeeze = "/input/squeeze/value";

		public const string trigger = "/input/trigger/value";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		private const string kDeviceLocalizedName = "HP Reverb G2 Controller OpenXR";

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
