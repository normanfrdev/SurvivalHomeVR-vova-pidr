using System.Collections.Generic;
using Unity.XR.CoreUtils.Bindings;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	[AddComponentMenu("XR/Controller Input Action Manager")]
	public class ControllerInputActionManager : MonoBehaviour
	{
		[Space]
		[Header("Interactors")]
		[SerializeField]
		[Tooltip("The interactor used for distant/ray manipulation. Use this or Near-Far Interactor, not both.")]
		private XRRayInteractor m_RayInteractor;

		[SerializeField]
		[Tooltip("Near-Far Interactor used for distant/ray manipulation. Use this or Ray Interactor, not both.")]
		private NearFarInteractor m_NearFarInteractor;

		[SerializeField]
		[Tooltip("The interactor used for teleportation.")]
		private XRRayInteractor m_TeleportInteractor;

		[Space]
		[Header("Controller Actions")]
		[SerializeField]
		[Tooltip("The reference to the action to start the teleport aiming mode for this controller.")]
		[FormerlySerializedAs("m_TeleportModeActivate")]
		private InputActionReference m_TeleportMode;

		[SerializeField]
		[Tooltip("The reference to the action to cancel the teleport aiming mode for this controller.")]
		private InputActionReference m_TeleportModeCancel;

		[SerializeField]
		[Tooltip("The reference to the action of continuous turning the XR Origin with this controller.")]
		private InputActionReference m_Turn;

		[SerializeField]
		[Tooltip("The reference to the action of snap turning the XR Origin with this controller.")]
		private InputActionReference m_SnapTurn;

		[SerializeField]
		[Tooltip("The reference to the action of moving the XR Origin with this controller.")]
		private InputActionReference m_Move;

		[SerializeField]
		[Tooltip("The reference to the action of scrolling UI with this controller.")]
		private InputActionReference m_UIScroll;

		[Space]
		[Header("Locomotion Settings")]
		[SerializeField]
		[Tooltip("If true, continuous movement will be enabled. If false, teleport will be enabled.")]
		private bool m_SmoothMotionEnabled;

		[SerializeField]
		[Tooltip("If true, continuous turn will be enabled. If false, snap turn will be enabled. Note: If smooth motion is enabled and enable strafe is enabled on the continuous move provider, turn will be overriden in favor of strafe.")]
		private bool m_SmoothTurnEnabled;

		[SerializeField]
		[Tooltip("With the Near-Far Interactor, if true, teleport will be enabled during near interaction. If false, teleport will be disabled during near interaction.")]
		private bool m_NearFarEnableTeleportDuringNearInteraction;

		[Space]
		[Header("UI Settings")]
		[SerializeField]
		[Tooltip("If true, UI scrolling will be enabled. Locomotion will be disabled when pointing at UI to allow it to be scrolled.")]
		private bool m_UIScrollingEnabled;

		[Space]
		[Header("Mediation Events")]
		[SerializeField]
		[Tooltip("Event fired when the active ray interactor changes between interaction and teleport.")]
		private UnityEvent<IXRRayProvider> m_RayInteractorChanged;

		private bool m_StartCalled;

		private bool m_PostponedDeactivateTeleport;

		private bool m_HoveringScrollableUI;

		private readonly HashSet<InputAction> m_LocomotionUsers;

		private readonly BindingsGroup m_BindingsGroup;

		public bool smoothMotionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smoothTurnEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool uiScrollingEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void SetupInteractorEvents()
		{
		}

		private void TeardownInteractorEvents()
		{
		}

		private void OnStartTeleport(InputAction.CallbackContext context)
		{
		}

		private void OnCancelTeleport(InputAction.CallbackContext context)
		{
		}

		private void OnNearFarSelectionRegionChanged(NearFarInteractor.Region selectionRegion)
		{
		}

		private void OnStartLocomotion(InputAction.CallbackContext context)
		{
		}

		private void OnStopLocomotion(InputAction.CallbackContext context)
		{
		}

		private void OnRaySelectEntered(SelectEnterEventArgs args)
		{
		}

		private void OnRaySelectExited(SelectExitEventArgs args)
		{
		}

		private void OnUIHoverEntered(UIHoverEventArgs args)
		{
		}

		private void OnUIHoverExited(UIHoverEventArgs args)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Start()
		{
		}

		protected void Update()
		{
		}

		private void UpdateLocomotionActions()
		{
		}

		private void DisableTeleportActions()
		{
		}

		private void DisableMoveAndTurnActions()
		{
		}

		private void DisableAllLocomotionActions()
		{
		}

		private void UpdateUIActions()
		{
		}

		private static void SetEnabled(InputActionReference actionReference, bool enabled)
		{
		}

		private static void EnableAction(InputActionReference actionReference)
		{
		}

		private static void DisableAction(InputActionReference actionReference)
		{
		}

		private static InputAction GetInputAction(InputActionReference actionReference)
		{
			return null;
		}
	}
}
