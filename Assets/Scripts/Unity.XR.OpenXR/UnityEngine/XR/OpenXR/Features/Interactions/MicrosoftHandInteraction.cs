using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class MicrosoftHandInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Hololens Hand (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class HoloLensHand : XRController
		{
			[Preserve]
			[InputControl(usage = "PrimaryAxis")]
			public AxisControl select
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
			[InputControl(aliases = new string[] { "Primary", "selectbutton" }, usages = new string[] { "PrimaryButton" })]
			public ButtonControl selectPressed
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
			[InputControl(alias = "Secondary", usage = "Grip")]
			public AxisControl squeeze
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
			[InputControl(aliases = new string[] { "GripButton", "squeezeClicked" }, usages = new string[] { "GripButton" })]
			public ButtonControl squeezePressed
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
			[InputControl(offset = 0u, alias = "device", usage = "Device")]
			public PoseControl devicePose
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
			[InputControl(offset = 0u, usage = "Pointer")]
			public PoseControl pointer
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
			[InputControl(offset = 132u)]
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
			[InputControl(offset = 136u)]
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
			[InputControl(offset = 20u, alias = "gripPosition")]
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
			[InputControl(offset = 32u, alias = "gripOrientation")]
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
			[InputControl(offset = 80u)]
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
			[InputControl(offset = 92u, alias = "pointerOrientation")]
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

			protected override void FinishSetup()
			{
			}
		}

		public const string featureId = "com.unity.openxr.feature.input.handtracking";

		public const string extensionString = "XR_MSFT_hand_interaction";

		public const string profile = "/interaction_profiles/microsoft/hand_interaction";

		public const string select = "/input/select/value";

		public const string squeeze = "/input/squeeze/value";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		private const string kDeviceLocalizedName = "HoloLens Hand OpenXR";

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
