using Unity.XR.CoreUtils.Bindings;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.SmartTweenableVariables;

namespace UnityEngine.XR.Interaction.Toolkit.UI.BodyUI
{
	[AddComponentMenu("XR/Hand Menu", 22)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.BodyUI.HandMenu.html")]
	public class HandMenu : MonoBehaviour
	{
		public enum UpDirection
		{
			WorldUp = 0,
			TransformUp = 1,
			CameraUp = 2
		}

		public enum MenuHandedness
		{
			None = 0,
			Left = 1,
			Right = 2,
			Either = 3
		}

		[SerializeField]
		[Tooltip("Child GameObject used to hold the hand menu UI. This is the transform that moves each frame.")]
		private GameObject m_HandMenuUIGameObject;

		[Header("Hand alignment")]
		[SerializeField]
		[Tooltip("Which hand should the menu anchor to. None will disable the hand menu. Either will try to follow the first hand to meet requirements.")]
		private MenuHandedness m_MenuHandedness;

		[SerializeField]
		[Tooltip("Determines the up direction of the menu when the hand menu is looking at the camera.")]
		private UpDirection m_HandMenuUpDirection;

		[Header("Palm anchor")]
		[SerializeField]
		[Tooltip("Anchor associated with the left palm pose for the hand.")]
		private Transform m_LeftPalmAnchor;

		[SerializeField]
		[Tooltip("Anchor associated with the right palm pose for the hand.")]
		private Transform m_RightPalmAnchor;

		[Header("Position follow config.")]
		[SerializeField]
		[Tooltip("Minimum distance in meters from target before which tween starts.")]
		private float m_MinFollowDistance;

		[SerializeField]
		[Tooltip("Maximum distance in meters from target before tween targets, when time threshold is reached.")]
		private float m_MaxFollowDistance;

		[SerializeField]
		[Tooltip("Time required to elapse before the max distance allowed goes from the min distance to the max.")]
		private float m_MinToMaxDelaySeconds;

		[Header("Gaze Alignment Config")]
		[SerializeField]
		[Tooltip("If true, menu will hide when gaze to menu origin's divergence angle is above the threshold. In other words, the menu will only show if looking roughly in it's direction.")]
		private bool m_HideMenuWhenGazeDiverges;

		[SerializeField]
		[Tooltip("Only show menu if gaze to menu origin's divergence angle is below this value.")]
		private float m_MenuVisibleGazeAngleDivergenceThreshold;

		private float m_MenuVisibilityDotThreshold;

		private readonly SmartFollowVector3TweenableVariable m_HandAnchorSmartFollow;

		private readonly QuaternionTweenableVariable m_RotTweenFollow;

		private readonly Vector3TweenableVariable m_MenuScaleTweenable;

		private readonly BindingsGroup m_BindingsGroup;

		private Transform m_CameraTransform;

		private bool m_WasMenuHiddenLastFrame;

		private MenuHandedness m_LastHandThatMetRequirements;

		[Header("Animation Settings")]
		[SerializeField]
		[Tooltip("Should the menu animate when it is revealed or hidden.")]
		private bool m_AnimateMenuHideAndReveal;

		[SerializeField]
		[Tooltip("Duration of the reveal/hide animation in seconds.")]
		private float m_RevealHideAnimationDuration;

		[Header("Selection Behavior")]
		[SerializeField]
		[Tooltip("Should the menu hide when a selection is made with the hand for which the menu is anchored to.")]
		private bool m_HideMenuOnSelect;

		[SerializeField]
		[Tooltip("XR Interaction Manager used to determine if a hand is selecting. Will find one if None. Used for Hide Menu On Select.")]
		private XRInteractionManager m_InteractionManager;

		[Header("Follow presets")]
		[SerializeField]
		private FollowPresetDatumProperty m_HandTrackingFollowPreset;

		[SerializeField]
		private FollowPresetDatumProperty m_ControllerFollowPreset;

		private XRInputModalityManager.InputMode m_CurrentInputMode;

		private Transform m_LeftOffsetRoot;

		private Transform m_RightOffsetRoot;

		private Coroutine m_HideCoroutine;

		private Coroutine m_ShowCoroutine;

		private Transform m_LastValidCameraTransform;

		private Transform m_LastValidPalmAnchor;

		private Transform m_LastValidPalmAnchorOffset;

		private Vector3 m_InitialMenuLocalScale;

		private readonly BindableVariable<bool> m_MenuVisibleBindableVariable;

		private float m_LastValidTrackingTime;

		public GameObject handMenuUIGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MenuHandedness menuHandedness
		{
			get
			{
				return default(MenuHandedness);
			}
			set
			{
			}
		}

		public UpDirection handMenuUpDirection
		{
			get
			{
				return default(UpDirection);
			}
			set
			{
			}
		}

		public Transform leftPalmAnchor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform rightPalmAnchor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float minFollowDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxFollowDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minToMaxDelaySeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hideMenuWhenGazeDiverges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float menuVisibleGazeDivergenceThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool animateMenuHideAndRevel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float revealHideAnimationDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hideMenuOnSelect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XRInteractionManager interactionManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void OnDestroy()
		{
		}

		protected void OnValidate()
		{
		}

		private void OnInputModeChanged(XRInputModalityManager.InputMode newInputMode)
		{
		}

		private FollowPreset GetCurrentPreset()
		{
			return null;
		}

		private void ShowMenu()
		{
		}

		private void OnMenuVisible()
		{
		}

		private void HideMenu()
		{
		}

		private void OnMenuHidden()
		{
		}

		protected void LateUpdate()
		{
		}

		private bool TryGetTrackedAnchors(MenuHandedness desiredHandedness, in FollowPreset currentPreset, out MenuHandedness targetHandedness, out Transform cameraTransform, out Transform palmAnchor, out Transform palmAnchorOffset)
		{
			targetHandedness = default(MenuHandedness);
			cameraTransform = null;
			palmAnchor = null;
			palmAnchorOffset = null;
			return false;
		}

		private bool TryGetInteractionManager(out XRInteractionManager manager)
		{
			manager = null;
			return false;
		}

		private void GetTransformAnchorsForHandedness(MenuHandedness handedness, out Transform palmAnchor, out Transform palmAnchorOffset)
		{
			palmAnchor = null;
			palmAnchorOffset = null;
		}

		private Vector3 GetReferenceUpDirection(Transform cameraTransform)
		{
			return default(Vector3);
		}

		private bool PalmMeetsRequirements(Transform cameraTransform, Transform palmAnchor, bool isRightHand, in FollowPreset currentPresent)
		{
			return false;
		}

		private bool TryGetCamera(out Transform cameraTransform)
		{
			cameraTransform = null;
			return false;
		}

		private static float AngleToDot(float angleDeg)
		{
			return 0f;
		}
	}
}
