using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class DPadInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "D-Pad Binding (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class DPad : XRController
		{
			[Preserve]
			[InputControl]
			public ButtonControl thumbstickDpadUp
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
			[InputControl]
			public ButtonControl thumbstickDpadDown
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
			[InputControl]
			public ButtonControl thumbstickDpadLeft
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
			[InputControl]
			public ButtonControl thumbstickDpadRight
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
			[InputControl]
			public ButtonControl trackpadDpadUp
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
			[InputControl]
			public ButtonControl trackpadDpadDown
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
			[InputControl]
			public ButtonControl trackpadDpadLeft
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
			[InputControl]
			public ButtonControl trackpadDpadRight
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
			[InputControl]
			public ButtonControl trackpadDpadCenter
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

		public const string featureId = "com.unity.openxr.feature.input.dpadinteraction";

		public float forceThresholdLeft;

		public float forceThresholdReleaseLeft;

		public float centerRegionLeft;

		public float wedgeAngleLeft;

		public bool isStickyLeft;

		public float forceThresholdRight;

		public float forceThresholdReleaseRight;

		public float centerRegionRight;

		public float wedgeAngleRight;

		public bool isStickyRight;

		public const string thumbstickDpadUp = "/input/thumbstick/dpad_up";

		public const string thumbstickDpadDown = "/input/thumbstick/dpad_down";

		public const string thumbstickDpadLeft = "/input/thumbstick/dpad_left";

		public const string thumbstickDpadRight = "/input/thumbstick/dpad_right";

		public const string trackpadDpadUp = "/input/trackpad/dpad_up";

		public const string trackpadDpadDown = "/input/trackpad/dpad_down";

		public const string trackpadDpadLeft = "/input/trackpad/dpad_left";

		public const string trackpadDpadRight = "/input/trackpad/dpad_right";

		public const string trackpadDpadCenter = "/input/trackpad/dpad_center";

		public const string profile = "/interaction_profiles/unity/dpad";

		private const string kDeviceLocalizedName = "DPad Interaction OpenXR";

		public string[] extensionStrings;

		internal override bool IsAdditive => false;

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

		internal override void AddAdditiveActions(List<ActionMapConfig> actionMaps, ActionMapConfig additiveMap)
		{
		}
	}
}
