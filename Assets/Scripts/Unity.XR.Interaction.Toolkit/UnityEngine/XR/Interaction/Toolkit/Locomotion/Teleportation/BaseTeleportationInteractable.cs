using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public abstract class BaseTeleportationInteractable : XRBaseInteractable, IXRReticleDirectionProvider
	{
		public enum TeleportTrigger
		{
			OnSelectExited = 0,
			OnSelectEntered = 1,
			OnActivated = 2,
			OnDeactivated = 3,
			[Obsolete("OnSelectExit has been deprecated. Use OnSelectExited instead. (UnityUpgradable) -> OnSelectExited", true)]
			OnSelectExit = 0,
			[Obsolete("OnSelectEnter has been deprecated. Use OnSelectEntered instead. (UnityUpgradable) -> OnSelectEntered", true)]
			OnSelectEnter = 1,
			[Obsolete("OnActivate has been deprecated. Use OnActivated instead. (UnityUpgradable) -> OnActivated", true)]
			OnActivate = 2,
			[Obsolete("OnDeactivate has been deprecated. Use OnDeactivated instead. (UnityUpgradable) -> OnDeactivated", true)]
			OnDeactivate = 3
		}

		private const float k_DefaultNormalToleranceDegrees = 30f;

		[SerializeField]
		[Tooltip("The teleportation provider that this teleportation interactable will communicate teleport requests to. If no teleportation provider is configured, will attempt to find a teleportation provider.")]
		private TeleportationProvider m_TeleportationProvider;

		[SerializeField]
		[Tooltip("How to orient the rig after teleportation.\nSet to:\n\nWorld Space Up to stay oriented according to the world space up vector.\n\nSet to Target Up to orient according to the target BaseTeleportationInteractable Transform's up vector.\n\nSet to Target Up And Forward to orient according to the target BaseTeleportationInteractable Transform's rotation.\n\nSet to None to maintain the same orientation before and after teleporting.")]
		private MatchOrientation m_MatchOrientation;

		[SerializeField]
		[Tooltip("Whether or not to rotate the rig to match the forward direction of the attach transform of the selecting interactor.")]
		private bool m_MatchDirectionalInput;

		[SerializeField]
		[Tooltip("Specify when the teleportation will be triggered. Options map to when the trigger is pressed or when it is released.")]
		private TeleportTrigger m_TeleportTrigger;

		[SerializeField]
		[Tooltip("When enabled, this teleportation interactable will only be selectable by a ray interactor if its current hit normal is aligned with this object's up vector.")]
		private bool m_FilterSelectionByHitNormal;

		[SerializeField]
		[Tooltip("Sets the tolerance in degrees from this object's up vector for a hit normal to be considered aligned with the up vector.")]
		private float m_UpNormalToleranceDegrees;

		[SerializeField]
		private TeleportingEvent m_Teleporting;

		private readonly LinkedPool<TeleportingEventArgs> m_TeleportingEventArgs;

		private readonly Dictionary<IXRInteractor, Vector3> m_TeleportForwardPerInteractor;

		private const string k_GenerateTeleportRequestDeprecated = "GenerateTeleportRequest(XRBaseInteractor, RaycastHit, ref TeleportRequest) has been deprecated. Use GenerateTeleportRequest(IXRInteractor, RaycastHit, ref TeleportRequest) instead.";

		public TeleportationProvider teleportationProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MatchOrientation matchOrientation
		{
			get
			{
				return default(MatchOrientation);
			}
			set
			{
			}
		}

		public bool matchDirectionalInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TeleportTrigger teleportTrigger
		{
			get
			{
				return default(TeleportTrigger);
			}
			set
			{
			}
		}

		public bool filterSelectionByHitNormal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float upNormalToleranceDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TeleportingEvent teleporting
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Reset()
		{
		}

		protected virtual bool GenerateTeleportRequest(IXRInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
		{
			return false;
		}

		protected bool SendTeleportRequest(IXRInteractor interactor)
		{
			return false;
		}

		private void UpdateTeleportRequestRotation(IXRInteractor interactor, ref TeleportRequest teleportRequest)
		{
		}

		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		protected override void OnActivated(ActivateEventArgs args)
		{
		}

		protected override void OnDeactivated(DeactivateEventArgs args)
		{
		}

		public override bool IsSelectableBy(IXRSelectInteractor interactor)
		{
			return false;
		}

		public void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Vector3? optionalReticleForward)
		{
			reticleUp = default(Vector3);
			optionalReticleForward = null;
		}

		[Obsolete("GenerateTeleportRequest(XRBaseInteractor, RaycastHit, ref TeleportRequest) has been deprecated. Use GenerateTeleportRequest(IXRInteractor, RaycastHit, ref TeleportRequest) instead.", true)]
		protected virtual bool GenerateTeleportRequest(XRBaseInteractor interactor, RaycastHit raycastHit, ref TeleportRequest teleportRequest)
		{
			return false;
		}
	}
}
