using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
	[SelectionBase]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Rigidbody))]
	[AddComponentMenu("XR/Climb Interactable", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbInteractable.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class ClimbInteractable : XRBaseInteractable
	{
		private const float k_DefaultMaxInteractionDistance = 0.1f;

		[SerializeField]
		[Tooltip("The climb provider that performs locomotion while this interactable is selected. If no climb provider is configured, will attempt to find one.")]
		private ClimbProvider m_ClimbProvider;

		[SerializeField]
		[Tooltip("Transform that defines the coordinate space for climb locomotion. Will use this GameObject's Transform by default.")]
		private Transform m_ClimbTransform;

		[SerializeField]
		[Tooltip("Controls whether to apply a distance check when validating hover and select interaction.")]
		private bool m_FilterInteractionByDistance;

		[SerializeField]
		[Tooltip("The maximum distance that an interactor can be from this interactable to begin hover or select.")]
		private float m_MaxInteractionDistance;

		[SerializeField]
		[Tooltip("The teleport volume used to assist with movement to a specific destination after ending a climb (optional, may be None). Only used if there is a Climb Teleport Interactor in the scene.")]
		private TeleportationMultiAnchorVolume m_ClimbAssistanceTeleportVolume;

		[SerializeField]
		[Tooltip("Optional override of locomotion settings specified in the climb provider. Only applies as an override if set to Use Value or if the asset reference is set.")]
		private ClimbSettingsDatumProperty m_ClimbSettingsOverride;

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

		public Transform climbTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool filterInteractionByDistance
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxInteractionDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TeleportationMultiAnchorVolume climbAssistanceTeleportVolume
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ClimbSettingsDatumProperty climbSettingsOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnValidate()
		{
		}

		protected override void Reset()
		{
		}

		protected override void Awake()
		{
		}

		public override bool IsHoverableBy(IXRHoverInteractor interactor)
		{
			return false;
		}

		public override bool IsSelectableBy(IXRSelectInteractor interactor)
		{
			return false;
		}

		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}
	}
}
