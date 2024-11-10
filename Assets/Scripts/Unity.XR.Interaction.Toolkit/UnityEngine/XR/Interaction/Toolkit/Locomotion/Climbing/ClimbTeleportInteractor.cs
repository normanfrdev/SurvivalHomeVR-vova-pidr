using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
	[AddComponentMenu("XR/Locomotion/Climb Teleport Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbTeleportInteractor.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class ClimbTeleportInteractor : XRBaseInteractor, IXRActivateInteractor, IXRInteractor
	{
		[SerializeField]
		[Tooltip("The climb locomotion provider to query for active locomotion and climbed interactable.")]
		private ClimbProvider m_ClimbProvider;

		[SerializeField]
		[Tooltip("Optional settings for how the hovered teleport volume evaluates a destination anchor. Applies as an override to the teleport volume's settings if set to Use Value or if the asset reference is set.")]
		private TeleportVolumeDestinationSettingsDatumProperty m_DestinationEvaluationSettings;

		private readonly LinkedPool<ActivateEventArgs> m_ActivateEventArgs;

		private readonly LinkedPool<DeactivateEventArgs> m_DeactivateEventArgs;

		private TeleportationMultiAnchorVolume m_TargetTeleportVolume;

		private TeleportVolumeDestinationSettingsDatumProperty m_PreservedTeleportVolumeSettings;

		public ClimbProvider climbProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TeleportVolumeDestinationSettingsDatumProperty destinationEvaluationSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool isSelectActive => false;

		public bool shouldActivate => false;

		public bool shouldDeactivate => false;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnClimbBegin(LocomotionProvider provider)
		{
		}

		private void OnClimbEnd(LocomotionProvider provider)
		{
		}

		private void OnClimbAnchorUpdated(ClimbProvider provider)
		{
		}

		private void SetTargetTeleportVolume(ClimbInteractable activeClimbInteractable)
		{
		}

		private void ReleaseTargetTeleportVolume()
		{
		}

		public override void GetValidTargets(List<IXRInteractable> targets)
		{
		}

		public void GetActivateTargets(List<IXRActivateInteractable> targets)
		{
		}

		Transform IXRInteractor.get_transform()
		{
			return null;
		}
	}
}
