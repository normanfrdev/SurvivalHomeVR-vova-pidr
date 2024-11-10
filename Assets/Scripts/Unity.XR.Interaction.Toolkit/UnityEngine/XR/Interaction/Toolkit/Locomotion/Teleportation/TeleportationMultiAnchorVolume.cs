using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[AddComponentMenu("XR/Teleportation Multi-Anchor Volume", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationMultiAnchorVolume.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportationMultiAnchorVolume : BaseTeleportationInteractable
	{
		private static class DefaultDestinationFilterCache
		{
			private static FurthestTeleportationAnchorFilter s_FilterInstance;

			private static readonly HashSet<TeleportationMultiAnchorVolume> s_Users;

			public static ITeleportationVolumeAnchorFilter SubscribeAndGetInstance(TeleportationMultiAnchorVolume user)
			{
				return null;
			}

			public static void Unsubscribe(TeleportationMultiAnchorVolume user)
			{
			}
		}

		[SerializeField]
		[Tooltip("The transforms that represent the possible teleportation destinations.")]
		private List<Transform> m_AnchorTransforms;

		[SerializeField]
		[Tooltip("Settings for how this volume evaluates a destination anchor.")]
		private TeleportVolumeDestinationSettingsDatumProperty m_DestinationEvaluationSettings;

		private ITeleportationVolumeAnchorFilter m_DefaultAnchorFilterCache;

		private bool m_WaitingToEvaluateDestination;

		private float m_WaitStartTime;

		private float m_LastDestinationQueryTime;

		public List<Transform> anchorTransforms => null;

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

		public ITeleportationVolumeAnchorFilter destinationEvaluationFilter => null;

		public float destinationEvaluationProgress
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform destinationAnchor
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

		private bool shouldDelayDestinationEvaluation => false;

		public event Action<TeleportationMultiAnchorVolume> destinationAnchorChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void OnDrawGizmosSelected()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected override void OnHoverExited(HoverExitEventArgs args)
		{
		}

		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void EvaluateDestinationAnchor()
		{
		}

		private void SetDestinationAtValidIndex(int anchorIndex)
		{
		}

		private void ClearDestinationAnchor()
		{
		}

		public override Transform GetAttachTransform(IXRInteractor interactor)
		{
			return null;
		}

		protected override bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
		{
			return false;
		}
	}
}
