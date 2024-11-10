using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class PalmPoseInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Palm Pose (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		public class PalmPose : XRController
		{
			[Preserve]
			[InputControl(offset = 0u)]
			public PoseControl palmPose
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
			[InputControl(offset = 0u)]
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
			[InputControl(offset = 8u, noisy = true, alias = "palmPosition")]
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
			[InputControl(offset = 20u, noisy = true, alias = "palmRotation")]
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
			[InputControl(offset = 8u, noisy = true)]
			public Vector3Control palmPosition
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
			[InputControl(offset = 20u, noisy = true)]
			public QuaternionControl palmRotation
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

		public const string featureId = "com.unity.openxr.feature.input.palmpose";

		public const string palmPose = "/input/palm_ext/pose";

		public const string profile = "/interaction_profiles/ext/palmpose";

		private const string kDeviceLocalizedName = "Palm Pose Interaction OpenXR";

		public const string extensionString = "XR_EXT_palm_pose";

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
