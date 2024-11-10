using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class ValveIndexControllerProfile : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Index Controller (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class ValveIndexController : XRControllerWithRumble
		{
			[Preserve]
			[InputControl(alias = "systemButton", usage = "MenuButton")]
			public ButtonControl system
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
			[InputControl(usage = "MenuTouch")]
			public ButtonControl systemTouched
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
			[InputControl(usage = "PrimaryButton")]
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
			[InputControl(usage = "PrimaryTouch")]
			public ButtonControl primaryTouched
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
			[InputControl(usage = "SecondaryButton")]
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
			[InputControl(usage = "SecondaryTouch")]
			public ButtonControl secondaryTouched
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
			[InputControl(alias = "squeezeForce", usage = "GripForce")]
			public AxisControl gripForce
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
			[InputControl(usage = "TriggerButton")]
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
			[InputControl(usage = "TriggerTouch")]
			public ButtonControl triggerTouched
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
			[InputControl(aliases = new string[] { "joystick", "Primary2DAxis" }, usage = "Primary2DAxis")]
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
			[InputControl(alias = "joystickClicked", usage = "Primary2DAxisClick")]
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
			[InputControl(alias = "joystickTouched", usage = "Primary2DAxisTouch")]
			public ButtonControl thumbstickTouched
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
			[InputControl(aliases = new string[] { "touchpad", "Secondary2DAxis" }, usage = "Secondary2DAxis")]
			public Vector2Control trackpad
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
			[InputControl(alias = "touchpadTouched", usage = "Secondary2DAxisTouch")]
			public ButtonControl trackpadTouched
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
			[InputControl(alias = "touchpadForce", usage = "Secondary2DAxisForce")]
			public AxisControl trackpadForce
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
			[InputControl(offset = 53u)]
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
			[InputControl(offset = 56u)]
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
			[InputControl(offset = 60u, alias = "gripPosition")]
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
			[InputControl(offset = 72u, alias = "gripOrientation")]
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
			[InputControl(offset = 120u)]
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
			[InputControl(offset = 132u, alias = "pointerOrientation")]
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

		public const string featureId = "com.unity.openxr.feature.input.valveindex";

		public const string profile = "/interaction_profiles/valve/index_controller";

		public const string system = "/input/system/click";

		public const string systemTouch = "/input/system/touch";

		public const string buttonA = "/input/a/click";

		public const string buttonATouch = "/input/a/touch";

		public const string buttonB = "/input/b/click";

		public const string buttonBTouch = "/input/b/touch";

		public const string squeeze = "/input/squeeze/value";

		public const string squeezeForce = "/input/squeeze/force";

		public const string triggerClick = "/input/trigger/click";

		public const string trigger = "/input/trigger/value";

		public const string triggerTouch = "/input/trigger/touch";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string thumbstickTouch = "/input/thumbstick/touch";

		public const string trackpad = "/input/trackpad";

		public const string trackpadForce = "/input/trackpad/force";

		public const string trackpadTouch = "/input/trackpad/touch";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		private const string kDeviceLocalizedName = "Index Controller OpenXR";

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
