using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class HandInteractionProfile : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Hand Interaction (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class HandInteraction : XRController
		{
			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "device", "gripPose" }, usage = "Device")]
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
			[InputControl(offset = 0u, alias = "aimPose", usage = "Pointer")]
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
			[InputControl(offset = 0u, usage = "Poke")]
			public PoseControl pokePose
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
			[InputControl(offset = 0u, usage = "Pinch")]
			public PoseControl pinchPose
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
			[InputControl(usage = "PinchValue")]
			public AxisControl pinchValue
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
			[InputControl(usage = "PinchTouched")]
			public ButtonControl pinchTouched
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
			[InputControl(usage = "PinchReady")]
			public ButtonControl pinchReady
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
			[InputControl(usage = "PointerActivateValue")]
			public AxisControl pointerActivateValue
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
			[InputControl(usage = "PointerActivated")]
			public ButtonControl pointerActivated
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
			[InputControl(usage = "PointerActivateReady")]
			public ButtonControl pointerActivateReady
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
			[InputControl(usage = "GraspValue")]
			public AxisControl graspValue
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
			[InputControl(usage = "GraspFirm")]
			public ButtonControl graspFirm
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
			[InputControl(usage = "GraspReady")]
			public ButtonControl graspReady
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
			[InputControl(offset = 2u)]
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
			[InputControl(offset = 4u)]
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
			[InputControl(offset = 8u, noisy = true, alias = "gripPosition")]
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
			[InputControl(offset = 20u, noisy = true, alias = "gripRotation")]
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
			[InputControl(offset = 68u, noisy = true)]
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
			[InputControl(offset = 80u, noisy = true)]
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
			[InputControl(offset = 128u, noisy = true)]
			public Vector3Control pokePosition
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
			[InputControl(offset = 140u, noisy = true)]
			public QuaternionControl pokeRotation
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
			[InputControl(offset = 188u, noisy = true)]
			public Vector3Control pinchPosition
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
			[InputControl(offset = 200u, noisy = true)]
			public QuaternionControl pinchRotation
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

		public const string featureId = "com.unity.openxr.feature.input.handinteraction";

		public const string profile = "/interaction_profiles/ext/hand_interaction_ext";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string poke = "/input/poke_ext/pose";

		public const string pinch = "/input/pinch_ext/pose";

		public const string pinchValue = "/input/pinch_ext/value";

		public const string pinchReady = "/input/pinch_ext/ready_ext";

		public const string pointerActivateValue = "/input/aim_activate_ext/value";

		public const string pointerActivateReady = "/input/aim_activate_ext/ready_ext";

		public const string graspValue = "/input/grasp_ext/value";

		public const string graspReady = "/input/grasp_ext/ready_ext";

		private const string kDeviceLocalizedName = "Hand Interaction OpenXR";

		public const string extensionString = "XR_EXT_hand_interaction";

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
