using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement
{
	[DefaultExecutionOrder(-209)]
	[AddComponentMenu("XR/Locomotion/Two-Handed Grab Move Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement.TwoHandedGrabMoveProvider.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TwoHandedGrabMoveProvider : ConstrainedMoveProvider
	{
		[SerializeField]
		[Tooltip("The left hand grab move instance which will be used as one half of two-handed locomotion.")]
		private GrabMoveProvider m_LeftGrabMoveProvider;

		[SerializeField]
		[Tooltip("The right hand grab move instance which will be used as one half of two-handed locomotion.")]
		private GrabMoveProvider m_RightGrabMoveProvider;

		[SerializeField]
		[Tooltip("Controls whether to override the settings for individual handed providers with this provider's settings on initialization.")]
		private bool m_OverrideSharedSettingsOnInit;

		[SerializeField]
		[Tooltip("The ratio of actual movement distance to controller movement distance.")]
		private float m_MoveFactor;

		[SerializeField]
		[Tooltip("Controls whether translation requires both grab move inputs to be active.")]
		private bool m_RequireTwoHandsForTranslation;

		[SerializeField]
		[Tooltip("Controls whether to enable yaw rotation of the user.")]
		private bool m_EnableRotation;

		[SerializeField]
		[Tooltip("Controls whether to enable uniform scaling of the user.")]
		private bool m_EnableScaling;

		[SerializeField]
		[Tooltip("The minimum user scale allowed.")]
		private float m_MinimumScale;

		[SerializeField]
		[Tooltip("The maximum user scale allowed.")]
		private float m_MaximumScale;

		private bool m_IsMoving;

		private Vector3 m_PreviousMidpointBetweenControllers;

		private float m_InitialOriginYaw;

		private Vector3 m_InitialLeftToRightDirection;

		private Vector3 m_InitialLeftToRightOrthogonal;

		private float m_InitialOriginScale;

		private float m_InitialDistanceBetweenHands;

		public GrabMoveProvider leftGrabMoveProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GrabMoveProvider rightGrabMoveProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool overrideSharedSettingsOnInit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float moveFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool requireTwoHandsForTranslation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float minimumScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maximumScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XRBodyYawRotation rotateTransformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public XRBodyScale scaleTransformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected override Vector3 ComputeDesiredMove(out bool attemptingMove)
		{
			attemptingMove = default(bool);
			return default(Vector3);
		}

		protected override void MoveRig(Vector3 translationInWorldSpace)
		{
		}
	}
}
