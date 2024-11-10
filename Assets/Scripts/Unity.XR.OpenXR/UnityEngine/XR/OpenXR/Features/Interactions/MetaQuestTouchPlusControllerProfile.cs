using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class MetaQuestTouchPlusControllerProfile : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Meta Quest Touch Plus Controller(OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class QuestTouchPlusController : XRControllerWithRumble
		{
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
			[InputControl(aliases = new string[] { "Primary", "menuButton", "systemButton" }, usage = "MenuButton")]
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
			[InputControl(aliases = new string[] { "ATouched", "XTouched", "ATouch", "XTouch", "buttonATouched", "buttonXTouched" }, usage = "PrimaryTouch")]
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
			[InputControl(aliases = new string[] { "BTouched", "YTouched", "BTouch", "YTouch", "buttonBTouched", "buttonYTouched" }, usage = "SecondaryTouch")]
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
			[InputControl(aliases = new string[] { "indexTouch", "indexNearTouched" }, usage = "TriggerTouch")]
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
			[InputControl(aliases = new string[] { "JoystickOrPadTouched", "thumbstickTouch", "joystickTouched" }, usage = "Primary2DAxisTouch")]
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
			[InputControl(usage = "ThumbrestTouch")]
			public ButtonControl thumbrestTouched
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
			[InputControl(offset = 28u, usage = "IsTracked")]
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
			[InputControl(offset = 32u, usage = "TrackingState")]
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
			[InputControl(offset = 36u, noisy = true, alias = "gripPosition")]
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
			[InputControl(offset = 48u, noisy = true, alias = "gripOrientation")]
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

			[Preserve]
			[InputControl(usage = "TriggerForce")]
			public AxisControl triggerForce
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
			[InputControl(usage = "TriggerCurl")]
			public AxisControl triggerCurl
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
			[InputControl(usage = "TriggerSlide")]
			public AxisControl triggerSlide
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
			[InputControl(usage = "TriggerProximity")]
			public ButtonControl triggerProximity
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
			[InputControl(usage = "ThumbProximity")]
			public ButtonControl thumbProximity
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

		public const string featureId = "com.unity.openxr.feature.input.metaquestplus";

		public const string profile = "/interaction_profiles/meta/touch_controller_plus";

		public const string buttonX = "/input/x/click";

		public const string buttonXTouch = "/input/x/touch";

		public const string buttonY = "/input/y/click";

		public const string buttonYTouch = "/input/y/touch";

		public const string menu = "/input/menu/click";

		public const string buttonA = "/input/a/click";

		public const string buttonATouch = "/input/a/touch";

		public const string buttonB = "/input/b/click";

		public const string buttonBTouch = "/input/b/touch";

		public const string system = "/input/system/click";

		public const string squeeze = "/input/squeeze/value";

		public const string trigger = "/input/trigger/value";

		public const string triggerTouch = "/input/trigger/touch";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string thumbstickTouch = "/input/thumbstick/touch";

		public const string thumbrest = "/input/thumbrest/touch";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		public const string triggerForce = "/input/trigger/force";

		public const string triggerCurl = "/input/trigger/curl_meta";

		public const string triggerSlide = "/input/trigger/slide_meta";

		public const string triggerProximity = "/input/trigger/proximity_meta";

		public const string thumbProximity = "/input/thumb_meta/proximity_meta";

		private const string kDeviceLocalizedName = "Meta Quest Touch Plus Controller OpenXR";

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

		protected override string GetDeviceLayoutName()
		{
			return null;
		}

		protected override void RegisterActionMapsWithRuntime()
		{
		}
	}
}
