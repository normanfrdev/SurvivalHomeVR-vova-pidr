using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public class HandCommonPosesInteraction : OpenXRInteractionFeature
	{
		[Preserve]
		[InputControlLayout(displayName = "Hand Interaction Poses (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" }, isGenericTypeOfDevice = true)]
		public class HandInteractionPoses : OpenXRDevice
		{
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
			[InputControl(offset = 0u)]
			public UnityEngine.InputSystem.XR.PoseControl pokePose
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
			public UnityEngine.InputSystem.XR.PoseControl pinchPose
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

		public const string featureId = "com.unity.openxr.feature.input.handinteractionposes";

		public const string profile = "/interaction_profiles/unity/hand_interaction_poses";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string poke = "/input/poke_ext/pose";

		public const string pinch = "/input/pinch_ext/pose";

		private const string kDeviceLocalizedName = "Hand Interaction Poses OpenXR";

		public const string extensionString = "XR_EXT_hand_interaction";

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

		internal override void AddAdditiveActions(List<ActionMapConfig> actionMaps, ActionMapConfig additiveMap)
		{
		}
	}
}
